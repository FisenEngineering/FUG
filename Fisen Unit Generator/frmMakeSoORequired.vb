Public Class frmMakeSoORequired
    Private pcancelled As Boolean
    Private pAOK As Boolean
    Private pVer As String
    Private pDesc As String
    Private pShortName As String

    Public Property MyVer As String
        Get
            Return pVer
        End Get
        Set(value As String)
            pVer = value
        End Set
    End Property

    Public Property MyDesc As String
        Get
            Return pDesc
        End Get
        Set(value As String)
            pDesc = value
        End Set
    End Property
    Public Property MyShortName As String
        Get
            Return pShortName
        End Get
        Set(value As String)
            pShortName = value
        End Set
    End Property
    Public Property Cancelled As Boolean
        Get
            Return pcancelled
        End Get
        Set(value As Boolean)
            pcancelled = value
        End Set
    End Property
    Public Property AOK As Boolean
        Get
            Return pAOK
        End Get
        Set(value As Boolean)
            pAOK = value
        End Set
    End Property
    Private Sub frmMakeSoORequired_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescription.Text = pDesc
        txtShortName.Text = pShortName
        txtVersion.Text = pVer

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        pDesc = txtDescription.Text
        pShortName = txtShortName.Text
        pVer = txtVersion.Text
        Me.Hide()

    End Sub
End Class