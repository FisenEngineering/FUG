Public Class frmAFlowMod
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub btnDoneSelection_Click(sender As Object, e As EventArgs) Handles btnDoneSelection.Click
        TabControl1.SelectTab("tpgConditions")
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click

        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click

        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i As Integer

        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()

        frmMain.ThisUnitMods.Add("AFlowMod") 'Mod Code goes here!

        Call UpdateCodeList()

        Call UpdateBaseUnitREquiredItems()
        'Call UpdateBaseUnitDrawingTags
        'Call UpdateReferTags
        'Call UpdateAFTags
        'Call HydroTags

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i


        Me.Hide()
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        For i = 0 To ModuleCodeList.Count - 1


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '340%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '340%'"
                Else
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                End If
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Design Caution")
                    If dummy = vbYes Then
                        totalmessage = ""
                        startingcaution = rs.Fields("LongText").Value
                        While Len(startingcaution) > 61
                            spacepos = 61
                            Do While ((Mid(startingcaution, spacepos, 1) <> " ") And (Mid(startingcaution, spacepos, 1) <> ",") And (Mid(startingcaution, spacepos, 1) <> "."))
                                spacepos = spacepos - 1
                            Loop

                            eachline = Mid(startingcaution, 1, spacepos - 1)
                            startingcaution = Mid(startingcaution, spacepos)
                            totalmessage = totalmessage & vbCrLf & eachline
                        End While
                        totalmessage = totalmessage & vbCrLf & startingcaution
                        dummy = MsgBox(totalmessage, vbOKOnly, "Design Caution")
                    End If
                    rs.MoveNext()
                Loop
                rs.Close()
            End If
        Next
        con.Close()

        rs = Nothing
        con = Nothing
    End Sub
    Private Sub UpdateCodeList()
        Dim i As Integer
        Dim ThisAFMod As String
        Dim dummy As MsgBoxResult

        ModuleCodeList.Clear()
        ModuleCodeList.Add("340100")

        For i = 0 To lstItemsInDB.Items.Count - 1
            ThisAFMod = lstItemsInDB.Items(i).ToString()
            If lstItemsInDB.SelectedItems.Contains(ThisAFMod) Then

                Select Case ThisAFMod
                    Case Is = "Return Air Blockoff"
                        Select Case frmMain.ThisUnit.Family
                            Case Is = "Series5"
                                ModuleCodeList.Add("340110")
                            Case Is = "Series10"
                                ModuleCodeList.Add("340111")
                            Case Is = "Series20"
                                ModuleCodeList.Add("340112")
                            Case Is = "Series40"
                                ModuleCodeList.Add("340113")
                            Case Is = "Series100"
                                ModuleCodeList.Add("340114")
                            Case Is = "Choice"
                                ModuleCodeList.Add("340115")
                            Case Is = "Select"
                                ModuleCodeList.Add("340116")
                            Case Is = "Premier"
                                ModuleCodeList.Add("340117")
                        End Select
                    Case Is = "S40 Bottom Return to Rear Return (No Exhaust Fan)"
                        ModuleCodeList.Add("340150")
                    Case Is = "S40 Bottom Return to Rear Return (Factory Exhaust Fans)"
                        ModuleCodeList.Add("340151")
                    Case Is = "S40 Bottom Supply to Rear Supply (Factory Electric Heat)"
                        ModuleCodeList.Add("340210")
                    Case Is = "A-Cabinet Bottom Return to Rear Return (JCI Return Fans)"
                        ModuleCodeList.Add("340118")
                        ModuleCodeList.Add("340Z01")
                        ModuleCodeList.Add("340Z02")
                        ModuleCodeList.Add("340Z03")
                        ModuleCodeList.Add("340Z04")
                    Case Else
                        dummy = MsgBox("Error is assigning ModCodes:" & vbCrLf & "Unknown Code - " & ThisAFMod, vbOKOnly, "Fisen Unit Generator")
                        Stop
                End Select
            End If
        Next i
    End Sub
    Private Sub UpdateBaseUnitREquiredItems()
        'None
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.AirflowTest = True

    End Sub
    Private Sub UpdateWeightTable()
        Dim Netmass As Double
        Dim ThisAFMod As String

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("AFlowMod")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Airflow Path Reconfiguration (Net)")

        NetMass = 0
        For i = 0 To lstItemsInDB.Items.Count - 1
            ThisAFMod = lstItemsInDB.Items(i).ToString()
            If lstItemsInDB.SelectedItems.Contains(ThisAFMod) Then
                Netmass = Netmass + UpdateWeightTableMass(ThisAFMod)
            End If
        Next i
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(NetMass)

    End Sub
    Private Function UpdateWeightTableMass(locMod As String)
        Dim mass As Double

        mass = 0
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 16
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series10"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 18
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series20"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 31
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series40"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 56
                    Case Is = "S40 Bottom Return to Rear Return (No Exhaust Fan)"
                        mass = 48
                    Case Is = "S40 Bottom Return to Rear Return (Factory Exhaust Fans)"
                        mass = 52
                    Case Is = "S40 Bottom Supply to Rear Supply (Factory Electric Heat)"
                        mass = 68
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series 100"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 74
                    Case Is = "A-Cabinet Bottom Return to Rear Return (JCI Return Fans)"
                        mass = 54
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Premier"
                Select Case locMod
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Choice"
                Select Case locMod
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Select"
                Select Case locMod
                    Case Else
                        mass = -9999
                End Select
            Case Else
                mass = -9999
        End Select
        Return mass
    End Function
    Private Sub UpdatePerformance()
        'Nothing here
    End Sub

    Private Sub frmAFlowMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateAvailableModifications()
        'Prime the pump
        ModuleCodeList.Add("340100")

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True
    End Sub

    Private Sub PopulateAvailableModifications()
        Dim MyFam As String
        MyFam = frmMain.ThisUnit.Family

        lstItemsInDB.Items.Clear()

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Series10"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Series12"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Series20"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Series40"
                lstItemsInDB.Items.Add("S40 Bottom Return to Rear Return (No Exhaust Fan)")
                lstItemsInDB.Items.Add("S40 Bottom Return to Rear Return (Factory Exhaust Fans)")
                lstItemsInDB.Items.Add("S40 Bottom Supply to Rear Supply (Factory Electric Heat)")
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Series100"
                lstItemsInDB.Items.Add("Return Air Blockoff")
                lstItemsInDB.Items.Add("A-Cabinet Bottom Return to Rear Return (JCI Return Fans)")
            Case Is = "Premier"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Choice"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Select"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Else

        End Select
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "AFlowMod"
        frmHistoryReport.cmbModCode.Text = "AFlowMod"
        frmHistoryReport.Show()
    End Sub
End Class