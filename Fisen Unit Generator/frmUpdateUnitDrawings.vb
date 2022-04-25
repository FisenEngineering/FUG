Imports System.IO

Public Class frmUpdateUnitDrawings
    Private pSourceFilePath As String
    Private pSourceWMFPath As String
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
        FullPath = My.Settings.ResourceDir & "BaseUnit\Drawings" & txtPath.Text & txtFileName.Text
        If File.Exists(FullPath) Then
            chkFileValid.Checked = True
            chkFileValid.Text = "File Found"
            chkFileValid.ForeColor = System.Drawing.Color.Green
        Else
            chkFileValid.Checked = False
            chkFileValid.Text = "File Not Found"
            chkFileValid.ForeColor = System.Drawing.Color.Red
        End If

        FullPath = My.Settings.ResourceDir & "BaseUnit\Drawings" & txtPath.Text & txtWMFName.Text
        If File.Exists(FullPath) Then
            chkWMFValid.Checked = True
            chkWMFValid.Text = "File Found"
            chkWMFValid.ForeColor = System.Drawing.Color.Green
        Else
            chkWMFValid.Checked = False
            chkWMFValid.Text = "File Not Found"
            chkWMFValid.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim gtg As Boolean
        Dim dummy As MsgBoxResult

        gtg = True
        If txtDrawingID.Text = "" Then gtg = False
        If txtPlainName.Text = "" Then gtg = False
        If txtFileName.Text = "" Then gtg = False
        If txtWMFName.Text = "" Then gtg = False
        If Not (chkFileValid.Checked) Then gtg = False
        If Not (chkWMFValid.Checked) Then gtg = False
        If txtPath.Text = "" Then gtg = False
        If txtType.Text = "" Then gtg = False
        If txtDescription.Text = "" Then gtg = False
        If Not (gtg) Then
            dummy = MsgBox("One or more required entries are invalid.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If
        Call WriteToDataBase()

    End Sub
    Private Sub WriteToDataBase()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim DrawingID, PlainName, FileName, WMFName, PathName, DrawingType, DrawingDescription As String

        Dim dummy As MsgBoxResult

        DrawingID = txtDrawingID.Text
        PlainName = txtPlainName.Text
        FileName = txtFileName.Text
        WMFName = txtWMFName.Text
        PathName = txtPath.Text
        DrawingType = txtType.Text
        DrawingDescription = txtDescription.Text


        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenStatic
        }

        MySQL = "Select * FROM tblUnitDrawings WHERE DrawingID='" & DrawingID & "'"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'this is for updating an existing record.
            dummy = MsgBox("You will be updating an existing record. Proceed?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbNo Then Exit Sub
            MySQL = "UPDATE tblUnitDrawings SET PlainName='" & PlainName & "', DrawingName='" & FileName & "', WMFName='" & WMFName & "', DrawingPath='" & PathName & "', DrawingType='" & DrawingType & "', DrawingDescription='" & DrawingDescription & "' WHERE DrawingID='" & DrawingID & "'"
            con.Execute(MySQL)
        Else
            'this is for creating a new record.
            If cmbFamily.Text = "All" Then
                dummy = MsgBox("Please choose a family to assign this drawing record to.", vbOKOnly, "Fisen Unit Generator")
                Exit Sub
            End If
            dummy = MsgBox("You will be creating a new record.  Proceed?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbNo Then Exit Sub
            con.Execute(MySQL)
            MySQL = "INSERT INTO tblUnitDrawings (DrawingID,PlainName,DrawingName,WMFName,DrawingPath,DrawingType,DrawingDescription," & cmbFamily.Text & ") VALUES ('" & DrawingID & "','" & PlainName & "','" & FileName & "','" & WMFName & "','" & PathName & "','" & DrawingType & "','" & DrawingDescription & "', TRUE )"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Function GuessPathString(lFamily As String) As String
        Dim Kingdom As String
        Dim UseFamily As String

        UseFamily = lFamily
        Kingdom = ""
        Select Case lFamily
            Case Is = "Series5"
                Kingdom = "RTU"
            Case Is = "Series10"
                Kingdom = "RTU"
            Case Is = "Series20"
                Kingdom = "RTU"
            Case Is = "xSelectx"
                Kingdom = "RTU"
                UseFamily = "Select"
            Case Is = "Choice"
                Kingdom = "RTU"
            Case Is = "Series100"
                Kingdom = "RTU"
            Case Is = "Series100A"
                Kingdom = "RTU"
            Case Is = "Series100B"
                Kingdom = "RTU"
            Case Is = "Series100C"
                Kingdom = "RTU"
            Case Is = "Series20IDSplit"
                Kingdom = "IDSplit"
            Case Is = "Series40ODSplit"
                Kingdom = "ODSplit"
            Case Is = "XTO"
                Kingdom = "AHU"
            Case Is = "XTI"
                Kingdom = "AHU"
            Case Is = "YorkCustom"
                Kingdom = "AHU"
            Case Is = "YCAL"
                Kingdom = "Chillers"
            Case Is = "YLAA"
                Kingdom = "Chillers"
            Case Is = "YVAA"
                Kingdom = "Chillers"
            Case Is = "YCIV"
                Kingdom = "Chillers"
            Case Is = "YCUL"
                Kingdom = "Chillers"
            Case Is = "YCAV"
                Kingdom = "Chillers"
            Case Is = "RJ"
                Stop
            Case Is = "RL"
                Stop
            Case Is = "RS"
                Stop
            Case Is = "DS"
                Stop
            Case Is = "CS"
                Stop
            Case Is = "DOAS"
                Kingdom = "Misc"
            Case Is = "Series20ODSplit"
                Kingdom = "IDSplit"
            Case Is = "Permier"
                Kingdom = "RTU"
            Case Is = "SeriesLX"
                Kingdom = "RTU"
            Case Else
                Stop
        End Select

        GuessPathString = "\" & Kingdom & "\" & UseFamily & "\"

    End Function

    Private Sub cmdUploadDrawingFile_Click(sender As Object, e As EventArgs) Handles cmdUploadDrawingFile.Click

        Dim SourceFilePath As String

        OpenFileDialog1.InitialDirectory = "C:\Users\" & Environment.UserName & "\Desktop\"
        OpenFileDialog1.Filter = "AutoCAD Drawing|*.dwg|All Files|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            SourceFilePath = OpenFileDialog1.FileName
            pSourceFilePath = SourceFilePath
            chkFileValid.Checked = True
            chkFileValid.Text = "Upload Pending"
            chkFileValid.ForeColor = System.Drawing.Color.Blue
            txtType.Text = "BaseUnit"
            txtPath.Text = GuessPathString(cmbFamily.Text)
        Else
            'If the user presses cancel

        End If

    End Sub

    Private Sub cmdUploadWMFFile_Click(sender As Object, e As EventArgs) Handles cmdUploadWMFFile.Click

        Dim SourceFilePath As String

        OpenFileDialog1.InitialDirectory = "C:\Users\" & Environment.UserName & "\Desktop\"
        OpenFileDialog1.Filter = "Windows Metafile|*.wmf|All Files|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            SourceFilePath = OpenFileDialog1.FileName
            pSourceWMFPath = SourceFilePath
            chkWMFValid.Checked = True
            chkWMFValid.Text = "Upload Pending"
            chkWMFValid.ForeColor = System.Drawing.Color.Blue
        Else
            'If the user presses cancel

        End If

    End Sub
End Class