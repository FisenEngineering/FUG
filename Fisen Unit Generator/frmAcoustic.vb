Public Class frmAcoustic
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
        frmMain.ThisUnitMods.Add("Acoustic") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("480000")

        If chkBrinmarBlankets.Checked Then


            frmMain.ThisUnitCodes.Add("480100")

            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    'nothing yet
                Case Is = "Series10"
                    If frmMain.txtNominalTons.Text = "5" Then
                        frmMain.ThisUnitCodes.Add("480105")
                    End If
                Case Is = "Series20ODSplit"

                    frmMain.ThisUnitCodes.Add("480121")

                Case Is = "Series20"
                    If frmMain.txtNominalTons.Text = "15" Then
                        frmMain.ThisUnitCodes.Add("480115")
                    End If

                Case Is = "Series40"
                    If frmMain.txtNominalTons.Text = "30" Then
                        frmMain.ThisUnitCodes.Add("480130")
                    End If
                    If frmMain.txtNominalTons.Text = "40" Then
                        frmMain.ThisUnitCodes.Add("480140")
                    End If

                Case Is = "Series100"
                    If frmMain.txtNominalTons.Text = "15" Then
                        'nothing yet
                    End If
            End Select
        End If

        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'frmMain.ThisUnit.CommNodes = "2"
        'use logic to step through the controls to determine the codes and use the above format...

    End Sub

    Private Sub UpdateBaseUnitRequiredItems()
        'none yet
    End Sub

    Private Sub UpdateWarrantyItems()
        'None. Yet.
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As Integer
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("Acoustic")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Acoustic Package")
        tempWeight = 0
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 25
                End If
            Case Is = "Series10"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 40
                End If
            Case Is = "Series20ODSplit"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 40
                End If
            Case Is = "Series20"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 80
                End If
            Case Is = "Series40"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 85
                End If
            Case Is = "Series 100"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 145
                End If
            Case Is = "Choice"
                If chkBrinmarBlankets.Checked Then
                    tempWeight = tempWeight + 80
                End If
            Case Else
                tempWeight = 9999
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(Str(tempWeight))
    End Sub


    Private Sub UpdatePerformance()
        'Nothing. Yet

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
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
End Class