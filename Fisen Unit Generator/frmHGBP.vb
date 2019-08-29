Imports System.ComponentModel
Public Class frmHGBP
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
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("HGBP") 'Mod Code goes here!
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("705100")
        If optManIso.Checked Then frmMain.ThisUnitCodes.Add("705105")
        If optSolIso.Checked Then frmMain.ThisUnitCodes.Add("705110")
        If optNoIso.Checked Then frmMain.ThisUnitCodes.Add("705115")
        If chkDischargeTStat.Checked Then frmMain.ThisUnitCodes.Add("705120")
        Select Case cmbHGBPStyle1.SelectedIndex
            Case Is = 0
                frmMain.ThisUnitCodes.Add("705151")
            Case Is = 1
                frmMain.ThisUnitCodes.Add("705161")
            Case Is = 2
                frmMain.ThisUnitCodes.Add("705181")
            Case Is = 3
                frmMain.ThisUnitCodes.Add("705171")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle2.SelectedIndex
            Case Is = 0
                frmMain.ThisUnitCodes.Add("705152")
            Case Is = 1
                frmMain.ThisUnitCodes.Add("705162")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                frmMain.ThisUnitCodes.Add("705172")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle3.SelectedIndex
            Case Is = 0
                frmMain.ThisUnitCodes.Add("705153")
            Case Is = 1
                frmMain.ThisUnitCodes.Add("705163")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                frmMain.ThisUnitCodes.Add("705173")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle4.SelectedIndex
            Case Is = 0
                frmMain.ThisUnitCodes.Add("705154")
            Case Is = 1
                frmMain.ThisUnitCodes.Add("705164")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                frmMain.ThisUnitCodes.Add("705174")
            Case Is = 4
                'Do Nothing 
        End Select

        If chkRemoveJCIHGBP.Checked Then
            frmMain.ThisUnitCodes.Add("705175")
        End If

        'use logic to step through the controls to determine the codes and use the above format...

    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        If chkDischargeTStat.Checked = True Then frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True
        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HGBP")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Gas Bypass")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If chkStage1.Checked = True Then tempWeight = "25"
                If chkStage2.Checked = True Then tempWeight = "50"
                If chkStage3.Checked = True Then tempWeight = "75"
                If chkStage4.Checked = True Then tempWeight = "100"
            Case Is = "Series10"
                If chkStage1.Checked = True Then tempWeight = "25"
                If chkStage2.Checked = True Then tempWeight = "50"
                If chkStage3.Checked = True Then tempWeight = "75"
                If chkStage4.Checked = True Then tempWeight = "100"
            Case Is = "Series20"
                If chkStage1.Checked = True Then tempWeight = "30"
                If chkStage2.Checked = True Then tempWeight = "60"
                If chkStage3.Checked = True Then tempWeight = "90"
                If chkStage4.Checked = True Then tempWeight = "120"
            Case Is = "Series40"
                If chkStage1.Checked = True Then tempWeight = "35"
                If chkStage2.Checked = True Then tempWeight = "70"
                If chkStage3.Checked = True Then tempWeight = "105"
                If chkStage4.Checked = True Then tempWeight = "140"
            Case Is = "Series100"
                If chkStage1.Checked = True Then tempWeight = "55"
                If chkStage2.Checked = True Then tempWeight = "90"
                If chkStage3.Checked = True Then tempWeight = "125"
                If chkStage4.Checked = True Then tempWeight = "160"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text
        'No Changes to performance
    End Sub
    Private Sub frmHGBP_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False
        cmbHGBPStyle1.Text = "To Suction Line"
        cmbHGBPStyle2.Text = "None"
        cmbHGBPStyle3.Text = "None"
        cmbHGBPStyle4.Text = "None"
        cmbRefrigerant.Text = "R410A"

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
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

    Private Sub chkStage2_CheckedChanged(sender As Object, e As EventArgs) Handles chkStage2.CheckedChanged
        If chkStage2.Checked = False Then cmbHGBPStyle2.Text = "None"
        If chkStage3.Checked = False Then cmbHGBPStyle3.Text = "None"
        If chkStage4.Checked = False Then cmbHGBPStyle4.Text = "None"

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub cmbHGBPStyle1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHGBPStyle1.SelectedIndexChanged
        If cmbHGBPStyle1.Text = "Rawal" Then
            chkRemoveJCIHGBP.Enabled = True
            chkRemoveJCIHGBP.Checked = False
        Else
            chkRemoveJCIHGBP.Enabled = False
            chkRemoveJCIHGBP.Checked = False
        End If
    End Sub
End Class