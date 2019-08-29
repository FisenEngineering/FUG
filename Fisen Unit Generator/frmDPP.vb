Public Class frmDPP
    Private pCancelled As Boolean
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
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("DPP") 'Mod Code goes here!
        Call UpdateCodeList
        Me.Hide()
    End Sub

    Private Sub UpdateCodeList()
        Dim i As Integer

        'Add the level 0 code
        If frmMain.ThisUnit.Kingdom <> "Chiller" Then
            frmMain.ThisUnitCodes.Add("210000")
            'Add the level 1 codes for the connection points.
            If optCommJCIDisc.Checked Then frmMain.ThisUnitCodes.Add("210101")
            If optCommJCIMLO.Checked Then frmMain.ThisUnitCodes.Add("210104")
            If optCommFisenSSFused.Checked Then frmMain.ThisUnitCodes.Add("210107")
            If optCommFisenSS.Checked Then frmMain.ThisUnitCodes.Add("210106")
            If optCommFisenMCDS.Checked Then frmMain.ThisUnitCodes.Add("210105")
            If optCommFisenMLO.Checked Then frmMain.ThisUnitCodes.Add("210108")
            If optEmerJCIDisc.Checked Then frmMain.ThisUnitCodes.Add("210201")
            If optEmerJCIMLO.Checked Then frmMain.ThisUnitCodes.Add("210204")
            If optEmerFisenSSFused.Checked Then frmMain.ThisUnitCodes.Add("210207")
            If optEmerFisenSS.Checked Then frmMain.ThisUnitCodes.Add("210206")
            If optEmerFisenMCDS.Checked Then frmMain.ThisUnitCodes.Add("210205")
            If optEmerFisenMLO.Checked Then frmMain.ThisUnitCodes.Add("210208")
            'add the level 1 codes for the load tallys
            frmMain.ThisUnitCodes.Add("210100")
            'add the individual loads
            For i = 0 To lstCommCircuit.Items.Count - 1
                If lstCommCircuit.Items.Item(i) = "Supply Fan" Then frmMain.ThisUnitCodes.Add("210110")
                If lstCommCircuit.Items.Item(i) = "Return Fan" Then frmMain.ThisUnitCodes.Add("210112")
                If lstCommCircuit.Items.Item(i) = "Exhaust Fan" Then frmMain.ThisUnitCodes.Add("210111")
                If lstCommCircuit.Items.Item(i) = "Compressors" Then frmMain.ThisUnitCodes.Add("210113")
                If lstCommCircuit.Items.Item(i) = "Condenser Fans" Then frmMain.ThisUnitCodes.Add("210114")
                If lstCommCircuit.Items.Item(i) = "Electric Heat" Then frmMain.ThisUnitCodes.Add("210115")
                If lstCommCircuit.Items.Item(i) = "Gas Heat" Then frmMain.ThisUnitCodes.Add("210116")
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then frmMain.ThisUnitCodes.Add("210117")
                If lstCommCircuit.Items.Item(i) = "Convenience Outlet" Then frmMain.ThisUnitCodes.Add("210118")
            Next
            frmMain.ThisUnitCodes.Add("210200")
            For i = 0 To lstEmerCircuit.Items.Count - 1
                If lstEmerCircuit.Items.Item(i) = "Supply Fan" Then frmMain.ThisUnitCodes.Add("210210")
                If lstEmerCircuit.Items.Item(i) = "Return Fan" Then frmMain.ThisUnitCodes.Add("210212")
                If lstEmerCircuit.Items.Item(i) = "Exhaust Fan" Then frmMain.ThisUnitCodes.Add("210211")
                If lstEmerCircuit.Items.Item(i) = "Compressors" Then frmMain.ThisUnitCodes.Add("210213")
                If lstEmerCircuit.Items.Item(i) = "Condenser Fans" Then frmMain.ThisUnitCodes.Add("210214")
                If lstEmerCircuit.Items.Item(i) = "Electric Heat" Then frmMain.ThisUnitCodes.Add("210215")
                If lstEmerCircuit.Items.Item(i) = "Gas Heat" Then frmMain.ThisUnitCodes.Add("210216")
                If lstEmerCircuit.Items.Item(i) = "Control Power Transformer" Then frmMain.ThisUnitCodes.Add("210217")
                If lstEmerCircuit.Items.Item(i) = "Convenience Outlet" Then frmMain.ThisUnitCodes.Add("210218")
            Next

            If chkFisenPhaseLoss.Checked Then frmMain.ThisUnitCodes.Add("210302")
            If chkJCIPhaseLoss.Checked Then frmMain.ThisUnitCodes.Add("210301")

        Else
            frmMain.ThisUnitCodes.Add("211000")
            'Add the level 1 codes for the connection points.
            If optCommJCIDisc.Checked Then frmMain.ThisUnitCodes.Add("211101")
            If optCommJCIMLO.Checked Then frmMain.ThisUnitCodes.Add("211104")
            If optCommFisenSSFused.Checked Then frmMain.ThisUnitCodes.Add("211107")
            If optCommFisenSS.Checked Then frmMain.ThisUnitCodes.Add("211106")
            If optCommFisenMCDS.Checked Then frmMain.ThisUnitCodes.Add("211105")
            If optCommFisenMLO.Checked Then frmMain.ThisUnitCodes.Add("211108")
            If optEmerJCIDisc.Checked Then frmMain.ThisUnitCodes.Add("211201")
            If optEmerJCIMLO.Checked Then frmMain.ThisUnitCodes.Add("211204")
            If optEmerFisenSSFused.Checked Then frmMain.ThisUnitCodes.Add("211207")
            If optEmerFisenSS.Checked Then frmMain.ThisUnitCodes.Add("211206")
            If optEmerFisenMCDS.Checked Then frmMain.ThisUnitCodes.Add("211205")
            If optEmerFisenMLO.Checked Then frmMain.ThisUnitCodes.Add("211208")
            'add the level 1 codes for the load tallys
            frmMain.ThisUnitCodes.Add("211100")
            'add the individual loads
            For i = 0 To lstCommCircuit.Items.Count - 1
                If lstCommCircuit.Items.Item(i) = "System 1 Compressors" Then
                    frmMain.ThisUnitCodes.Add("211111")
                    frmMain.ThisUnitCodes.Add("211112")
                    frmMain.ThisUnitCodes.Add("211113")
                End If

                If lstCommCircuit.Items.Item(i) = "System 1 Condenser Fans" Then frmMain.ThisUnitCodes.Add("211180")
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then frmMain.ThisUnitCodes.Add("211181")
                If lstCommCircuit.Items.Item(i) = "System 2 Compressors" Then
                    frmMain.ThisUnitCodes.Add("211211")
                    frmMain.ThisUnitCodes.Add("211212")
                    frmMain.ThisUnitCodes.Add("211213")
                End If

                If lstCommCircuit.Items.Item(i) = "System 2 Condenser Fans" Then frmMain.ThisUnitCodes.Add("211280")
                If lstCommCircuit.Items.Item(i) = "Control Power Transformer" Then frmMain.ThisUnitCodes.Add("211281")
            Next
            frmMain.ThisUnitCodes.Add("211200")
            'add the individual loads
            For i = 0 To lstEmerCircuit.Items.Count - 1
                If lstEmerCircuit.Items.Item(i) = "System 1 Compressors" Then frmMain.ThisUnitCodes.Add("211110")
                If lstEmerCircuit.Items.Item(i) = "System 1 Condenser Fans" Then frmMain.ThisUnitCodes.Add("211112")
                If lstEmerCircuit.Items.Item(i) = "Control Power Transformer" Then frmMain.ThisUnitCodes.Add("211117")
                If lstEmerCircuit.Items.Item(i) = "System 2 Compressors" Then frmMain.ThisUnitCodes.Add("211110")
                If lstEmerCircuit.Items.Item(i) = "System 2 Condenser Fans" Then frmMain.ThisUnitCodes.Add("211112")

            Next

        End If



    End Sub
    Private Sub UpdatePerformance()
        If optCommJCIDisc.Checked Or optCommFisenSS.Checked Or optCommFisenMCDS.Checked Then frmMain.ThisUnitElecData.CommDisconnect = True
        If optCommFisenSSFused.Checked Then frmMain.ThisUnitElecData.CommFused = True
        If optEmerJCIDisc.Checked Or optEmerFisenSS.Checked Or optEmerFisenMCDS.Checked Then frmMain.ThisUnitElecData.EmerDisconnect = True
        If optEmerFisenSS.Checked Then frmMain.ThisUnitElecData.EmerFused = True
        frmMain.ThisUnitElecData.EmerCircuit = True

        'Eventually automatically setup the MCA Table
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
    End Sub
End Class