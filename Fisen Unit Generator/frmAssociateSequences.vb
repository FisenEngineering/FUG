Public Class frmAssociateSequences
    Private pCancelled As Boolean
    Private pFIOPCode As String

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property FIOPNumber As String
        Get
            Return pFIOPCode
        End Get
        Set(value As String)
            pFIOPCode = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pFIOPCode = "Not Set"
        pCancelled = False
    End Sub
    Private Function GetFIOPPlainText(lFIOP As String) As String
        Dim TempText As String

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode='" & lFIOP & "'"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        TempText = rs.Fields("Description").Value.ToString

        con.Close()
        rs = Nothing
        con = Nothing

        Return TempText
    End Function

    Private Sub PopulateDGV(lFIOP)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim NewRow As String()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        MySQL = "SELECT * FROM tblSequenceofOperation WHERE FIOpCode='" & lFIOP & "'"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        Do While Not (rs.EOF)
            NewRow = {rs.Fields("ID").Value.ToString, rs.Fields("FIOpCode").Value.ToString, rs.Fields("ShortName").Value.ToString, rs.Fields("Version").Value.ToString, rs.Fields("Description").Value.ToString, rs.Fields("SequenceText").Value.ToString}
            dgvSOO.Rows.Add(NewRow)
            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles test.Click
        txtFIOPPlainName.Text = GetFIOPPlainText(txtFIOPCode.Text)
        Call PopulateDGV(txtFIOPCode.Text)
    End Sub

    Private Sub cmdAssociate_Click(sender As Object, e As EventArgs) Handles cmdAssociate.Click

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim lFIOP, lpath, lversion, ldescription, lshortname As String

        lFIOP = txtFIOPCode.Text
        lpath = txtFilePath.Text
        lversion = txtVersion.Text
        ldescription = txtDescription.Text
        lshortname = txtShortName.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "INSERT INTO tblSequenceofOperation (FIOpCode,SequenceText,Version,Description,ShortName) VALUES ('" & lFIOP & "','" & lpath & "','" & lversion & "','" & ldescription & "','" & lshortname & "')"
        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
    End Sub

    Private Sub frmAssociateSequences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
End Class