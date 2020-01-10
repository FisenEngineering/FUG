Public Class frmHistoryReport
    Private pMyModule As String

    Public Property MyModule As String
        Get
            Return pMyModule
        End Get
        Set(value As String)
            pMyModule = value
        End Set
    End Property
    Private Sub frmHistoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitializeQuery
    End Sub

    Private Sub LoadFilterHistoryTable()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String

        Dim PFBString, ExtModString As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryFilters"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                txtReport.Text = txtReport.Text & OneLine & vbCrLf
                If rs.Fields(7).Value = "TRUE" Then
                    PFBString = "With Prefilters"
                Else
                    PFBString = "No Prefilters"
                End If
                If rs.Fields(8).Value = "None" Then
                    ExtModString = ""
                Else
                    ExtModString = "External Module: " & rs.Fields(8).Value
                End If
                OneLine = vbTab & rs.Fields(5).Value & vbTab & rs.Fields(6).Value & vbTab & rs.Fields(20).Value & " cfm " & rs.Fields(19).Value & " iwc " & PFBString & vbTab & ExtModString
                txtReport.Text = txtReport.Text & OneLine & vbCrLf
                OneLine = vbTab & rs.Fields(9).Value & " - (" & rs.Fields(11).Value & ")" & rs.Fields(10).Value
                If rs.Fields(12).Value <> "-" Then
                    OneLine = OneLine & " / (" & rs.Fields(13).Value & ")" & rs.Fields(12).Value
                End If
                If rs.Fields(14).Value <> "-" Then
                    OneLine = OneLine & " / (" & rs.Fields(15).Value & ")" & rs.Fields(14).Value
                End If
                If rs.Fields(16).Value <> "-" Then
                    OneLine = OneLine & " / (" & rs.Fields(17).Value & ")" & rs.Fields(16).Value
                End If
                If PFBString = "With Prefilters" Then
                    OneLine = OneLine & " Prefilters: " & rs.Fields(18).Value
                End If
                txtReport.Text = txtReport.Text & OneLine & vbCrLf
            End If

            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub InitializeQuery()
        Select Case pMyModule
            Case Is = "Filters"
                Call LoadFilterHistoryTable()
                Me.Text = "Filter History"
        End Select

    End Sub
    Private Sub chkFilterByFamily_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByFamily.CheckedChanged
        Call InitializeQuery()
    End Sub
End Class