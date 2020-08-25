Imports Fisen_Unit_Generator.My

Public Class frmUserOptions
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Call ReconcileOptions()
        My.Settings.Save()
        If optResearch.Checked Then Call frmMain.SetResearchMode()

        Me.Close()
    End Sub



    Private Sub frmUserOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpAdminOptions.Enabled = frmMain.chkDebug.Checked
        Call InitializeOptions()
    End Sub

    Private Sub InitializeOptions()
        chkUOAutoLaunchWord.Checked = My.Settings.UOWordLaunch
        chkUOMoveCutstoSD.Checked = My.Settings.UOMoveCuts2SD
        chkSkipAutoArchive.Checked = My.Settings.UOSkipArchive

        If My.Settings.UOResearchMode Then
            optResearch.Checked = True
        Else
            optSubGen.Checked = True
        End If
    End Sub
    Private Sub ReconcileOptions()
        My.Settings.UOWordLaunch = chkUOAutoLaunchWord.Checked
        My.Settings.UOMoveCuts2SD = chkUOMoveCutstoSD.Checked
        My.Settings.UOSkipArchive = chkSkipAutoArchive.Checked

        If optResearch.Checked Then
            My.Settings.UOResearchMode = True
        Else
            My.Settings.UOResearchMode = False
        End If

    End Sub
End Class