Public Class frmCondInt
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

        Call UpdatePerformance()
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("CondInt") 'Mod Code goes here!
        Call UpdateCodeList()

        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()

    End Sub

    Private Sub UpdateWeightTable()

    End Sub
    Private Sub UpdateWarrantyItems()

    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("710000")

        'Add the Base Rail Style
        If optCommonRail.Checked Then
            If optBaseStructSteel.Checked Then
                frmMain.ThisUnitCodes.Add("710035")
            End If
            If optBaseStructAl.Checked Then
                frmMain.ThisUnitCodes.Add("710030")
            End If
            If optBaseFormedSteel.Checked Then
                frmMain.ThisUnitCodes.Add("710025")
            End If
        Else
            If optBaseStructSteel.Checked Then
                frmMain.ThisUnitCodes.Add("710010")
            End If
            If optBaseStructAl.Checked Then
                frmMain.ThisUnitCodes.Add("710015")
            End If
            If optBaseFormedSteel.Checked Then
                frmMain.ThisUnitCodes.Add("710020")
            End If
        End If

        'Add the codes for the pan or lack-ther-of under the condensing unit
        If optUnderCUNothing.Checked Then
            frmMain.ThisUnitCodes.Add("710045")
        End If
        If optUnderCUPan.Checked Then
            frmMain.ThisUnitCodes.Add("710050")
            frmMain.ThisUnitCodes.Add("710060")
        End If
        If optUnderCUPanInsulated.Checked Then
            frmMain.ThisUnitCodes.Add("710055")
            If cmbInsulationType.Text = "1 in. Fiberglass" Then frmMain.ThisUnitCodes.Add("710056")
            If cmbInsulationType.Text = "1-1/2 in. Elastomeric" Then frmMain.ThisUnitCodes.Add("710057")
            If cmbInsulationType.Text = "2 in. Spray" Then frmMain.ThisUnitCodes.Add("710058")
            frmMain.ThisUnitCodes.Add("710060")
        End If

        'Add the codes for attachment and isolation

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub frmCondInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbInsulationType.Text = "None"
    End Sub

    Private Sub optUnderCUPanInsulated_CheckedChanged(sender As Object, e As EventArgs) Handles optUnderCUPanInsulated.CheckedChanged
        If optUnderCUPanInsulated.Checked = True Then
            cmbInsulationType.Enabled = True
            cmbInsulationType.Text = "1 in. Fiberglass"
        Else
            cmbInsulationType.Enabled = False
            cmbInsulationType.Text = "None"
        End If
    End Sub

    Private Sub btnDoneSelection_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab("tpgRefrigeration")
    End Sub

    Private Sub btnDoneRefrigeration_Click(sender As Object, e As EventArgs) Handles btnDoneRefrigeration.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub cmdDoneControls_Click(sender As Object, e As EventArgs) Handles cmdDoneControls.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        TabControl1.SelectTab("tpgWeights")
    End Sub

    Private Sub btnDoneWeights_Click(sender As Object, e As EventArgs) Handles btnDoneWeights.Click
        btnOK.Enabled = True
    End Sub
End Class