Public Class frmUpdateUnitDrawings
    Private Sub frmUpdateUnitDrawings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFamily.SelectedItem = "All"
        Call LoadAvailableDrawings()
    End Sub
    Private Sub LoadAvailableDrawings()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailDwgs.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        If cmbFamily.SelectedItem.ToString = "All" Then
            MySQL = "Select * FROM tblUnitDrawings ORDER BY PlainName"
        Else
            MySQL = "Select * FROM tblUnitDrawings WHERE " & cmbFamily.SelectedItem.ToString & "=True ORDER BY PlainName"
        End If

        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstAvailDwgs.Items.Add(rs.Fields("PlainName").Value)
            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmbFamily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFamily.SelectedIndexChanged
        Call LoadAvailableDrawings()
    End Sub

    Private Sub PopulateRecordFields(DrawingPlainName As String)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblUnitDrawings WHERE PlainName='" & DrawingPlainName & "'"

        rs.Open(MySQL, con)

        rs.MoveFirst()
        txtDrawingID.Text = rs.Fields("DrawingID").Value.ToString
        txtPlainName.Text = rs.Fields("PlainName").Value.ToString
        txtFileName.Text = rs.Fields("DrawingName").Value.ToString
        txtWMFName.Text = rs.Fields("WMFName").Value.ToString
        txtPath.Text = rs.Fields("DrawingPath").Value.ToString
        txtType.Text = rs.Fields("DrawingType").Value.ToString
        txtDescription.Text = rs.Fields("DrawingDescription").Value.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub lstAvailDwgs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailDwgs.SelectedIndexChanged
        Call PopulateRecordFields(lstAvailDwgs.SelectedItem.ToString)
    End Sub

    Private Sub cmdValidateFiles_Click(sender As Object, e As EventArgs) Handles cmdValidateFiles.Click
        Dim FullPath As String
        FullPath = My.Settings.ResourceDir & "BaseUnit\Drawings"

    End Sub
End Class