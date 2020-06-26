Imports System.IO
Public Class frmArchiver
    Public FileAndPath As New ArrayList
    Public localTargetDir As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i As Integer
        Dim JustFile As String

        For i = 0 To FileAndPath.Count - 1
            If lstFilesToArchive.GetItemChecked(i) Then
                JustFile = lstFilesToArchive.CheckedItems.Item(i)
                Directory.Move(FileAndPath.Item(i), localTargetDir & JustFile)
            End If
        Next
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
    End Sub

End Class