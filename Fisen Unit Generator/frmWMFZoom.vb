Public Class frmWMFZoom
    Private pImgPath As String

    Public Property ImagePath As String
        Get
            Return pImgPath
        End Get
        Set(value As String)
            pImgPath = value
        End Set
    End Property


    Private Sub frmWMFZoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picZoomBox.LoadAsync(ImagePath)
    End Sub
End Class