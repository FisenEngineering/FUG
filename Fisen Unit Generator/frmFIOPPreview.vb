Public Class frmFIOPPreview
    Private pReportData As String
    Public Property ReportData As String
        Get
            ReportData = pReportData
        End Get
        Set(value As String)
            pReportData = value
        End Set
    End Property
    Private Sub frmFIOPPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtReport.Rtf = pReportData
    End Sub

    Private Sub cmdShowFIOPS_Click(sender As Object, e As EventArgs) Handles cmdShowFIOPS.Click
        txtReport.Rtf = pReportData
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        txtReport.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(txtReport.SelectedText)
    End Sub
End Class