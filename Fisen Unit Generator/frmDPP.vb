Public Class frmDPP
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
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("DPP") 'Mod Code goes here!
        Call UpdateCodeList()
        Call UpdatePerformance() 'Update performance must happen after update code list to get the load table to construct properly.
        Me.Hide()
    End Sub

    Private Sub UpdateCodeList()
        Dim i As Integer

        ModuleCodeList.Clear()
        'Add the level 0 code
        If frmMain.ThisUnit.Kingdom <> "Chiller" Then
            ModuleCodeList.Add("210000")
            'Add the level 1 codes for the connection points.
            If optCommJCIDisc.Checked Then ModuleCodeList.Add("210101")
            If optCommJCIMLO.Checked Then ModuleCodeList.Add("210104")
            If optCommFisenSSFused.Checked Then ModuleCodeList.Add("210107")
            If optCommFisenSS.Checked Then ModuleCodeList.Add("210106")
            If optCommFisenMCDS.Checked Then ModuleCodeList.Add("210105")
            If optCommFisenMLO.Checked Then ModuleCodeList.Add("210108")
            If optEmerJCIDisc.Checked Then ModuleCodeList.Add("210201")
            If optEmerJCIMLO.Checked Then ModuleCodeList.Add("210204")
            If optEmerFisenSSFused.Checked Then ModuleCodeList.Add("210207")
            If optEmerFisenSS.Checked Then ModuleCodeList.Add("210206")
            If optEmerFisenMCDS.Checked Then ModuleCodeList.Add("210205")
            If optEmerFisenMLO.Checked Then ModuleCodeList.Add("210208")
            'add the level 1 codes for the load tallys
            ModuleCodeList.Add("210100")
            'add the individual loads
            For i = 0 To lstCommCircuit.Items.Count - 1
                If lstCommCircuit.Items.Item(i) = "Supply Fan" Then
                    ModuleCodeList.Add("210110")
                    frmMain.ThisUnitElecData.CommLoad.Add("SUPPLY FAN")
                End If
                If lstCommCircuit.Items.Item(i) = "Return Fan" Then
                    ModuleCodeList.Add("210112")
                    frmMain.ThisUnitElecData.CommLoad.Add("RETURN FAN")
                End If
                If lstCommCircuit.Items.Item(i) = "Exhaust Fan" Then
                    ModuleCodeList.Add("210111")
                    frmMain.ThisUnitElecData.CommLoad.Add("EXHAUST FAN")
                End If
                If lstCommCircuit.Items.Item(i) = "Compressors" Then
                    ModuleCodeList.Add("210113")
                    frmMain.ThisUnitElecData.CommLoad.Add("COMPRESSOR")
                End If
                If lstCommCircuit.Items.Item(i) = "Condenser Fans" Then
                    ModuleCodeList.Add("210114")
                    frmMain.ThisUnitElecData.CommLoad.Add("CONDENSER FAN")
                End If
                If lstCommCircuit.Items.Item(i) = "Electric Heat" Then
                    ModuleCodeList.Add("210115")
                    frmMain.ThisUnitElecData.CommLoad.Add("ELECTRIC HEAT")
                End If
                If lstCommCircuit.Items.Item(i) = "Gas Heat" Then
                    ModuleCodeList.Add("210116")
                    frmMain.ThisUnitElecData.CommLoad.Add("GAS HEAT")
                End If
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then
                    ModuleCodeList.Add("210117")
                    frmMain.ThisUnitElecData.CommLoad.Add("CONTROL TRANSFORMER")
                End If
                If lstCommCircuit.Items.Item(i) = "Convenience Outlet" Then
                    ModuleCodeList.Add("210118")
                    frmMain.ThisUnitElecData.CommLoad.Add("CONVENIENCE OUTLET")
                End If
            Next
            ModuleCodeList.Add("210200")
            For i = 0 To lstEmerCircuit.Items.Count - 1
                If lstEmerCircuit.Items.Item(i) = "Supply Fan" Then
                    ModuleCodeList.Add("210210")
                    frmMain.ThisUnitElecData.EmerLoad.Add("SUPPLY FAN")
                End If
                If lstEmerCircuit.Items.Item(i) = "Return Fan" Then
                    ModuleCodeList.Add("210212")
                    frmMain.ThisUnitElecData.EmerLoad.Add("RETURN FAN")
                End If
                If lstEmerCircuit.Items.Item(i) = "Exhaust Fan" Then
                    ModuleCodeList.Add("210211")
                    frmMain.ThisUnitElecData.EmerLoad.Add("EXHAUST FAN")
                End If
                If lstEmerCircuit.Items.Item(i) = "Compressors" Then
                    ModuleCodeList.Add("210213")
                    frmMain.ThisUnitElecData.EmerLoad.Add("COMPRESSOR")
                End If
                If lstEmerCircuit.Items.Item(i) = "Condenser Fans" Then
                    ModuleCodeList.Add("210214")
                    frmMain.ThisUnitElecData.EmerLoad.Add("CONDENSER FAN")
                End If
                If lstEmerCircuit.Items.Item(i) = "Electric Heat" Then
                    ModuleCodeList.Add("210215")
                    frmMain.ThisUnitElecData.EmerLoad.Add("ELECTRIC HEAT")
                End If
                If lstEmerCircuit.Items.Item(i) = "Gas Heat" Then
                    ModuleCodeList.Add("210216")
                    frmMain.ThisUnitElecData.EmerLoad.Add("GAS HEAT")
                End If
                If lstEmerCircuit.Items.Item(i) = "Control Power Transformer" Then
                    ModuleCodeList.Add("210217")
                    frmMain.ThisUnitElecData.EmerLoad.Add("CONTROL TRANSFORMER")
                End If
                If lstEmerCircuit.Items.Item(i) = "Convenience Outlet" Then
                    ModuleCodeList.Add("210218")
                    frmMain.ThisUnitElecData.EmerLoad.Add("CONVENIENCE OUTLET")
                End If
            Next

            If chkFisenPhaseLoss.Checked Then ModuleCodeList.Add("210302")
            If chkJCIPhaseLoss.Checked Then ModuleCodeList.Add("210301")

        Else
            ModuleCodeList.Add("211000")
            'Add the level 1 codes for the connection points.
            If optCommJCIDisc.Checked Then ModuleCodeList.Add("211101")
            If optCommJCIMLO.Checked Then ModuleCodeList.Add("211104")
            If optCommFisenSSFused.Checked Then ModuleCodeList.Add("211107")
            If optCommFisenSS.Checked Then ModuleCodeList.Add("211106")
            If optCommFisenMCDS.Checked Then ModuleCodeList.Add("211105")
            If optCommFisenMLO.Checked Then ModuleCodeList.Add("211108")
            If optEmerJCIDisc.Checked Then ModuleCodeList.Add("211201")
            If optEmerJCIMLO.Checked Then ModuleCodeList.Add("211204")
            If optEmerFisenSSFused.Checked Then ModuleCodeList.Add("211207")
            If optEmerFisenSS.Checked Then ModuleCodeList.Add("211206")
            If optEmerFisenMCDS.Checked Then ModuleCodeList.Add("211205")
            If optEmerFisenMLO.Checked Then ModuleCodeList.Add("211208")
            'add the level 1 codes for the load tallys
            ModuleCodeList.Add("211100")
            'add the individual loads
            For i = 0 To lstCommCircuit.Items.Count - 1
                If lstCommCircuit.Items.Item(i) = "System 1 Compressors" Then
                    ModuleCodeList.Add("211111")
                    ModuleCodeList.Add("211112")
                    ModuleCodeList.Add("211113")
                End If

                If lstCommCircuit.Items.Item(i) = "System 1 Condenser Fans" Then ModuleCodeList.Add("211180")
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then ModuleCodeList.Add("211181")
                If lstCommCircuit.Items.Item(i) = "System 2 Compressors" Then
                    ModuleCodeList.Add("211211")
                    ModuleCodeList.Add("211212")
                    ModuleCodeList.Add("211213")
                End If

                If lstCommCircuit.Items.Item(i) = "System 2 Condenser Fans" Then ModuleCodeList.Add("211280")
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then ModuleCodeList.Add("211281")
            Next
            ModuleCodeList.Add("211200")
            'add the individual loads
            For i = 0 To lstEmerCircuit.Items.Count - 1
                If lstEmerCircuit.Items.Item(i) = "System 1 Compressors" Then ModuleCodeList.Add("211110")
                If lstEmerCircuit.Items.Item(i) = "System 1 Condenser Fans" Then ModuleCodeList.Add("211112")
                If lstEmerCircuit.Items.Item(i) = "Control Power Transformer" Then ModuleCodeList.Add("211117")
                If lstEmerCircuit.Items.Item(i) = "System 2 Compressors" Then ModuleCodeList.Add("211110")
                If lstEmerCircuit.Items.Item(i) = "System 2 Condenser Fans" Then ModuleCodeList.Add("211112")

            Next

        End If

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

    End Sub
    Private Sub UpdatePerformance()
        If optCommJCIDisc.Checked Or optCommFisenSS.Checked Or optCommFisenMCDS.Checked Then frmMain.ThisUnitElecData.CommDisconnect = True
        If optCommFisenSSFused.Checked Then frmMain.ThisUnitElecData.CommFused = True
        If optEmerJCIDisc.Checked Or optEmerFisenSS.Checked Or optEmerFisenMCDS.Checked Then frmMain.ThisUnitElecData.EmerDisconnect = True
        If optEmerFisenSS.Checked Then frmMain.ThisUnitElecData.EmerFused = True
        frmMain.ThisUnitElecData.EmerCircuit = True

        frmMain.ThisUnitElecData.EmerVolts = frmMain.ThisUnitElecData.CommVolts
        frmMain.ThisUnitElecData.EmerPhase = frmMain.ThisUnitElecData.CommPhase
        frmMain.ThisUnitElecData.EmerFreq = frmMain.ThisUnitElecData.CommFreq

        'Eventually automatically setup the MCA Table

        frmMain.chkUseCustomMCA.Checked = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As Integer
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("DPP")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Dual Point Power")
        tempWeight = 0
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 10
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 7
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 15
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 10
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 7
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 15
            Case Is = "Series10"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 12
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 9
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 17
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 12
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 9
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 17
            Case Is = "Series20"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 15
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 12
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 19
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 15
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 12
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 19
            Case Is = "Series40"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 20
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 10
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 23
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 20
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 10
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 23
            Case Is = "YPAL"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 25
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 15
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 25
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 25
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 15
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 25
            Case Is = "Series20ODSplit"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 10
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 7
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 15
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 10
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 7
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 15
            Case Is = "YLAA"
                If optCommFisenMCDS.Checked Then tempWeight = tempWeight + 56
                If optCommFisenMLO.Checked Then tempWeight = tempWeight + 8
                If optCommFisenSS.Checked Then tempWeight = tempWeight + 125
                If optEmerFisenMCDS.Checked Then tempWeight = tempWeight + 56
                If optEmerFisenMLO.Checked Then tempWeight = tempWeight + 8
                If optEmerFisenSS.Checked Then tempWeight = tempWeight + 125
            Case Else
                tempWeight = 9999
        End Select

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(Val(tempWeight))
    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.MotorTest = True

        'get the idea?

    End Sub

    Private Sub cmdAdd2Emer_Click(sender As Object, e As EventArgs) Handles cmdAdd2Emer.Click

        If lstNoCircuit.Text <> "" Then
            lstEmerCircuit.Items.Add(lstNoCircuit.Text)
            lstNoCircuit.Items.Remove(lstNoCircuit.SelectedItem)
        End If

    End Sub

    Private Sub cmdAdd2Comm_Click(sender As Object, e As EventArgs) Handles cmdAdd2Comm.Click
        If lstNoCircuit.Text <> "" Then
            lstCommCircuit.Items.Add(lstNoCircuit.Text)
            lstNoCircuit.Items.Remove(lstNoCircuit.SelectedItem)
        End If
    End Sub

    Private Sub cmdDelFromComm_Click(sender As Object, e As EventArgs) Handles cmdDelFromComm.Click
        If lstCommCircuit.Text <> "" Then
            lstNoCircuit.Items.Add(lstCommCircuit.Text)
            lstCommCircuit.Items.Remove(lstCommCircuit.SelectedItem)
        End If
    End Sub

    Private Sub cmdDelFromEmer_Click(sender As Object, e As EventArgs) Handles cmdDelFromEmer.Click
        If lstEmerCircuit.Text <> "" Then
            lstNoCircuit.Items.Add(lstEmerCircuit.Text)
            lstEmerCircuit.Items.Remove(lstEmerCircuit.SelectedItem)
        End If
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
    End Sub

    Private Sub frmDPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        If frmMain.ThisUnit.Family = "YLAA" Then
            lstEmerCircuit.Items.Clear()
            lstEmerCircuit.Items.Add("System 2 Compressors")
            lstEmerCircuit.Items.Add("System 2 Condenser Fans")
            lstEmerCircuit.Items.Add("Control Power Transformer")
        End If
        If frmMain.ThisUnit.Family = "YLAA" Then
            lstCommCircuit.Items.Clear()
            lstCommCircuit.Items.Add("System 1 Compressors")
            lstCommCircuit.Items.Add("System 1 Condenser Fans")
        End If
        If frmMain.ThisUnit.Family = "YLAA" Then
            lstNoCircuit.Items.Clear()
            lstNoCircuit.Items.Add("CHW Pump")
        End If

        If frmMain.ThisUnitElecData.ConvOutlet Then
            lstCommCircuit.Items.Add("Convenience Outlet")
            lblConv.Text = "Convenience Outlet Detected"
            lblConv.Visible = True
            For i = 0 To lstNoCircuit.Items.Count - 1
                If lstNoCircuit.Items(i) = "Convenience Outlet" Then
                    lstNoCircuit.Items.RemoveAt(i)
                    Exit For
                End If
            Next i
        End If

        If frmMain.ThisUnitRXPerf.UPGXFanPresent Then
            lstEmerCircuit.Items.Add("Exhaust Fan")
            lblXFan.Text = "UPG Exhaust Fan Detected"
            lblXFan.Visible = True
            For i = 0 To lstNoCircuit.Items.Count - 1
                If lstNoCircuit.Items(i) = "Exhaust Fan" Then
                    lstNoCircuit.Items.RemoveAt(i)
                    Exit For
                End If
            Next i
        End If

        For i = 0 To frmMain.ThisUnitFactOpts.Count - 1
            If frmMain.ThisUnitFactOpts.Item(i) = "Phase Monitor" Then
                chkJCIPhaseLoss.Checked = True
                Exit For
            End If
        Next
        ModuleCodeList.Add("210000")
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer
        Dim TCode As String

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '210%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '210%'"
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
End Class