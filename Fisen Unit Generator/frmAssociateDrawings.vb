Public Class frmAssociateDrawings
    Private pCancelled As Boolean
    Private pFIOPCode As String
    Public Property FIOPCode As String
        Get
            Return pFIOPCode
        End Get
        Set(value As String)
            pFIOPCode = value
        End Set
    End Property
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub frmAssociateDrawings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pFIOPCode <> "Unset" Then
            txtFIOPCode.ReadOnly = True
            txtFIOPCode.Text = pFIOPCode
        End If

        cmbFIOPType.Text = "Unselected"

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        pFIOPCode = "Unset"

    End Sub

    Private Sub cmdPasteWMFPath_Click(sender As Object, e As EventArgs) Handles cmdPasteWMFPath.Click
        Dim clip As String
        clip = Clipboard.GetText
        If InStr(clip, "Connections") Then
            clip = Mid(clip, InStr(clip, "Connections"))
            If InStr(clip, """") Then
                clip = Mid(clip, 1, Len(clip) - 1)
            End If

        End If

        txtConPath.Text = clip
    End Sub

    Private Sub cmdAddItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        If optNewCon.Checked Then
            Call AddNewConnection()
        Else

        End If
    End Sub

    Private Sub AddNewConnection()
        Dim con As ADODB.Connection
        Dim dbProvider As String

        Dim MySQL As String
        Dim lFIOPCode, lType, LDescription, lSource As String

        lFIOPCode = txtFIOPCode.Text
        lType = cmbFIOPType.Text
        LDescription = txtDescription.text
        lSource = txtConPath.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        'Insert SQL
        MySQL = "INSERT INTO tblFieldConnections VALUES ('" & lFIOPCode & "','" & lType & "','" & lDescription & "','" & lSource & "')"
        con.Execute(MySQL)

        con.Close()
        con = Nothing
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()

    End Sub
End Class