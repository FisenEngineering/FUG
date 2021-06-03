Public Class frmSCCR
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'No Performance for this modification
        'Call UpdatePerformance
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("SCCR") 'Mod Code goes here!
        'No GenCodes for this unit
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        '     frmMain.ThisUnit.GenCodesPresent = True
        '     frmMain.ThisUnitMods.Add("Common")
        'End If
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.MotorTest = True

        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim DisconnectCoeff As Double
        Dim ModWeight As Double
        Dim DiscWeight As Double
        Dim BlankInput As String

        If optFSS.Checked Then
            DisconnectCoeff = 1
        Else
            DisconnectCoeff = 0
        End If

        DiscWeight = 0
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("SCCR")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Short Circuit Current Rating")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                ModWeight = 20
                DiscWeight = 20
            Case Is = "Series10"
                ModWeight = 22
                DiscWeight = 20
            Case Is = "Series12"
                ModWeight = 22
                DiscWeight = 20
            Case Is = "Series20"
                ModWeight = 25
                DiscWeight = 35
            Case Is = "Series40"
                ModWeight = 35
                DiscWeight = 50
            Case Is = "Series100"
                ModWeight = 45
                DiscWeight = 65
            Case Is = "Blank"
                BlankInput = InputBox("What weight for the SCCR Mod?", "SCCR:UpdateWeightTable", "45")
                ModWeight = Val(BlankInput)
                If optFSS.Checked Then
                    BlankInput = InputBox("What weight for the Disconnect?", "SCCR:UpdateWeightTable", "65")
                    DiscWeight = Val(BlankInput)
                Else
                    DiscWeight = 0
                End If
            Case Else
                ModWeight = 9999
                DiscWeight = 0
        End Select

        ModWeight = ModWeight + DisconnectCoeff * DiscWeight
        tempWeight = Trim(Str(ModWeight))

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub frmSCCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
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
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("401100")

        If opt65kButton.Checked Then
            frmMain.ThisUnitCodes.Add("401103")
        End If
        If optFSS.Checked Then
            frmMain.ThisUnitCodes.Add("401120")
            If chkDisconnectLoose.Checked Then frmMain.ThisUnitCodes.Add("401121")
            frmMain.ThisUnitElecData.CommFused = True
        Else
            frmMain.ThisUnitCodes.Add("401125")
        End If

        'no need to add a node for communications for this modification.
        'frmMain.ThisUnit.CommNodes = "2"

    End Sub
End Class