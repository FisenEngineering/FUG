﻿Public Class frmAFlowMod
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
        Dim i As Integer
        Dim CurMod As String
        Dim dummy As MsgBoxResult
        Dim airflow As Double


        If lstItemsInDB.SelectedItems.Count = 0 Then
            dummy = MsgBox("You must select at least 1 modification.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If

        airflow = frmMain.ThisUnitSFanPerf.Airflow
        txtSFanAFlow.Text = Format(airflow, "0")

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1
            CurMod = lstItemsInDB.SelectedItems.Item(i)



            Select Case CurMod
                Case Is = "Supply Air - Convert to Rear Discharge"
                    'Turn on the appropriate controls on the Performance Tab
                    Select Case frmMain.ThisUnit.Family
                        Case Is = "Series5"

                        Case Is = "Series10"

                        Case Is = "Series12"

                        Case Is = "Series20"

                        Case Is = "Series40"
                            'Depricated *Probably not going to be used*
                        Case Is = "Series100"

                        Case Is = "Premier"

                        Case Is = "Choice"
                            grpDown2Side.Visible = True
                            txtSPAdjustSideDisch.Text = Format(0.000000009564935065 * airflow * airflow - 0.000006064832535891 * airflow + 0.0270664217361984, "0.00")
                        Case Is = "Select"

                        Case Else

                    End Select
                Case Is = "Return Air - Convert to Rear Return"
                    'Turn on the appropriate controls on the Performance Tab
                    'None yet
            End Select

        Next


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
                            Case Else
                                dummy = MsgBox("Error in Code Assignment for Return Air Blockoff: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
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
                    Case Is = "Supply Air - Convert to Rear Discharge"
                        Select Case frmMain.ThisUnit.Family
                            Case Is = "Series5"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series10"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series12"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series20"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series40"
                                'Depricated *Probably not going to be used*
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series100"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Premier"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Choice"
                                ModuleCodeList.Add("340119")
                            Case Is = "Select"
                                ModuleCodeList.Add("340120")
                            Case Else
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear - Unrecognized Family", vbOKOnly, "Fisen Unit Generator")
                                Stop
                        End Select
                    Case Is = "Return Air - Convert to Rear Return"
                        Select Case frmMain.ThisUnit.Family
                            Case Is = "Series5"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series10"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series12"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series20"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series40"
                                'Depricated *Probably not going to be used*
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Series100"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Premier"
                                dummy = MsgBox("Error in Code Assignment for Supply Air to Rear: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                                Stop
                            Case Is = "Choice"
                                ModuleCodeList.Add("340121")
                            Case Is = "Select"
                                ModuleCodeList.Add("340122")
                            Case Else
                                dummy = MsgBox("Error in Code Assignment for Return Air to Rear - Unrecognized Family", vbOKOnly, "Fisen Unit Generator")
                                Stop
                        End Select
                    Case Is = "A-Cabinet Bottom Supply to Top Supply"
                        ModuleCodeList.Add("340123") 'convert to top.
                    Case Is = "B-Cabinet Bottom Supply to Top Supply"
                        ModuleCodeList.Add("340124") 'convert to top
                    Case Is = "C-Cabinet Bottom Supply to Top Supply"
                        ModuleCodeList.Add("340125") 'convert to top
                    Case Is = "B-Cut in Outdoor Air Opening for RA Only Unit (No Damper)"
                        ModuleCodeList.Add("340126") 'cut in a OA opening
                    Case Else
                        dummy = MsgBox("Error is assigning ModCodes:" & vbCrLf & "Unknown Code - " & ThisAFMod, vbOKOnly, "Fisen Unit Generator")
                        Stop
                End Select
            End If
        Next i
    End Sub
    Private Sub UpdateBaseUnitREquiredItems()
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
                        'Nothing
                    Case Is = "S40 Bottom Return to Rear Return (No Exhaust Fan)"
                        'Nothing
                    Case Is = "S40 Bottom Return to Rear Return (Factory Exhaust Fans)"
                        'Nothing
                    Case Is = "S40 Bottom Supply to Rear Supply (Factory Electric Heat)"
                        'Nothing
                    Case Is = "A-Cabinet Bottom Return to Rear Return (JCI Return Fans)"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit requires factory return fans (Bottom).")
                    Case Is = "A-Cabinet Bottom Supply to Top Supply"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit requires factory bottom discharge.")
                    Case Is = "B-Cabinet Bottom Supply to Top Supply"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit requires factory bottom discharge.")
                    Case Is = "C-Cabinet Bottom Supply to Top Supply"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit requires factory bottom discharge.")
                    Case Is = "B-Cut in Outdoor Air Opening for RA Only Unit (No Damper)"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit requires order without economizer")
                    Case Is = "Supply Air - Convert to Rear Discharge"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit ordered with bottom supply.")
                    Case Is = "Return Air - Convert to Rear Return"
                        frmMain.lstRequiredFactoryItems.Items.Add("Base unit ordered with bottom supply.")
                    Case Else
                        dummy = MsgBox("Error is assigning Required Base Unit Items:" & vbCrLf & "Unknown Code - " & ThisAFMod, vbOKOnly, "Fisen Unit Generator")
                        Stop
                End Select
            End If
        Next i

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
            Case Is = "Series100"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 74
                    Case Is = "A-Cabinet Bottom Return to Rear Return (JCI Return Fans)"
                        mass = 54
                    Case Is = "A-Cabinet Bottom Supply to Top Supply"
                        mass = 16
                    Case Is = "B-Cabinet Bottom Supply to Top Supply"
                        mass = 22
                    Case Is ="C-Cabinet Bottom Supply to Top Supply"
                        mass = 31
                    Case Is ="B-Cut in Outdoor Air Opening for RA Only Unit (No Damper)"
                        mass = 8
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
                    Case Is = "Supply Air - Convert to Rear Discharge"
                        mass = 48
                    Case Is = "Return Air - Convert to Rear Return"
                        mass = 32
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Select"
                Select Case locMod
                    Case Is = "Supply Air - Convert to Rear Discharge"
                        mass = 54
                    Case Is = "Return Air - Convert to Rear Return"
                        mass = 34
                    Case Else
                        mass = -9999
                End Select
            Case Else
                mass = -9999
        End Select
        Return mass
    End Function
    Private Sub UpdatePerformance()
        Dim ESP As Double
        If chkAdjustESPDown.Checked Then
            ESP = Val(frmMain.ThisUnitSFanPerf.ESP)
            ESP = ESP - Val(txtSPAdjustSideDisch.Text)
            frmMain.ThisUnitSFanPerf.ESP = Format(ESP, "0.00")
        End If
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
                lstItemsInDB.Items.Add("A-Cabinet Bottom Supply to Top Supply")
                lstItemsInDB.Items.Add("B-Cabinet Bottom Supply to Top Supply")
                lstItemsInDB.Items.Add("C-Cabinet Bottom Supply to Top Supply")
                lstItemsInDB.Items.Add("B-Cut in Outdoor Air Opening for RA Only Unit (No Damper)")
            Case Is = "Premier"
                lstItemsInDB.Items.Add("Return Air Blockoff")
            Case Is = "Choice"
                lstItemsInDB.Items.Add("Return Air Blockoff")
                lstItemsInDB.Items.Add("Supply Air - Convert to Rear Discharge")
                lstItemsInDB.Items.Add("Return Air - Convert to Rear Return")
            Case Is = "Select"
                lstItemsInDB.Items.Add("Return Air Blockoff")
                lstItemsInDB.Items.Add("Supply Air - Convert to Rear Discharge")
                lstItemsInDB.Items.Add("Return Air - Convert to Rear Return")
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

    Private Sub txtSFanAFlow_Leave(sender As Object, e As EventArgs) Handles txtSFanAFlow.Leave
        txtSPAdjustSideDisch.Text = Format(0.000000009564935065 * Val(txtSFanAFlow.Text) * Val(txtSFanAFlow.Text) - 0.000006064832535891 * Val(txtSFanAFlow.Text) + 0.0270664217361984, "0.00")
    End Sub
End Class