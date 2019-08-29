Public Class frmDSUnitBase
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance

    End Sub

    Private Sub UpdatePerformance()
        frmMain.ThisUnitDS.FanSpeed = txtFanSpeed.Text
        frmMain.ThisUnitDS.CompQty = txtCompQty.Text
        frmMain.ThisUnitDS.CompSpeed = txtCompSpeed.Text
        Me.Hide()
    End Sub
End Class