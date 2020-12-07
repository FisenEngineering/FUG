Public Class frmFanMaintenance
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Call CreateNewDBEntry
        Me.Hide()
    End Sub
    Private Sub CreateNewDBEntry()
        Dim con As ADODB.Connection
        Dim dbProvider As String

        Dim MySQL As String

        Dim lFanID, lFilePath, lFileName, lSupplyFan, lReturnFan, lExhaustFan, lSubID, lNotes As String

        lFanID = txtFanID.Text
        lFilePath = txtFilePath.Text
        lFileName = txtFileName.Text
        If chkSupplyFan.Checked Then lSupplyFan = "TRUE" Else lSupplyFan = "FALSE"
        If chkReturnFan.Checked Then lReturnFan = "TRUE" Else lReturnFan = "FALSE"
        If chkExhaustFan.Checked Then lExhaustFan = "TRUE" Else lExhaustFan = "FALSE"
        lSubID = txtSubID.Text
        lNotes = "Record Created by:" & Environment.UserName & " on " & Date.Today

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        MySQL = "INSERT INTO tblFanCurves (FanID,FilePath,FileName,SupplyFan,ReturnFan,ExhaustFan,SubID,Notes) VALUES ('" & lFanID & "','" & lFilePath & "','" & lFileName & "'," & lSupplyFan & "," & lReturnFan & "," & lExhaustFan & ",'" & lSubID & "','" & lNotes & "')"
        con.Execute(MySQL)

        con.Close()
        con = Nothing
    End Sub
End Class