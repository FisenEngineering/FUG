Imports System.ComponentModel
Public Class ModDialog_for_Fisen_Unit_Generator1
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
        Me.Hide()
    End Sub

    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
    End Sub
End Class