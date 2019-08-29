Imports System.ComponentModel
Public Class frmDWall
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
        frmMain.ThisUnitMods.Add("DWall") 'Mod Code goes here!
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("605100")
        If frmMain.ThisUnitHeatPerf.HeatType = "Gas" Then
            If optHXStaysIn.Checked = True Then
                frmMain.ThisUnitCodes.Add("605105")
            Else
                frmMain.ThisUnitCodes.Add("605110")
            End If
        Else
            frmMain.ThisUnitCodes.Add("605115")
        End If
        'use logic to step through the controls to determine the codes and use the above format...

    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim SSWalls As Boolean

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("DWall")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Double Wall Sheet Metal Liners")
        tempWeight = "9999"
        'Now it's logic to assign the values.

        SSWalls = False
        If lstLinerMaterial.GetItemText(lstLinerMaterial.SelectedItem) = "Stainless Steel(304) Liners" Then SSWalls = True

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "86"
            Case Is = "Series10"
                tempWeight = "115"
            Case Is = "Series12"
                tempWeight = "128"
            Case Else
                tempWeight = "9999"
        End Select
        If SSWalls = True Then
            tempWeight = tempWeight * 0.95
        End If
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim dummy As MsgBoxResult
        If Not (chkNoPerformance.Checked) Then
            dummy = MsgBox("Error in Performance Logic")
        End If
    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

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
    End Sub

    Private Sub frmDWall_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lstLinerMaterial.SelectedIndex = 0 'Select Galvanized as the default

    End Sub
End Class