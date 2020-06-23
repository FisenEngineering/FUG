Imports Fisen_Unit_Generator.My

Public Class frmUserOptions
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Call ReconcileOptions()
        My.Settings.Save()
        Me.Close()
    End Sub



    Private Sub frmUserOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitializeOptions()
    End Sub

    Private Sub InitializeOptions()
        chkUOAutoLaunchWord.Checked = My.Settings.UOWordLaunch
        chkUOMoveCutstoSD.Checked = My.Settings.UOMoveCuts2SD
    End Sub
    Private Sub ReconcileOptions()
        My.Settings.UOWordLaunch = chkUOAutoLaunchWord.Checked
        My.Settings.UOMoveCuts2SD = chkUOMoveCutstoSD.Checked
    End Sub
End Class