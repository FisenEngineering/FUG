Public Class frmUpdateShipWithTables
    Private pcancelled As Boolean
    Private pAOK As Boolean
    Private pSingleCode As String
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
    Public Property SingleCode As String
        Get
            SingleCode = pSingleCode
        End Get
        Set(value As String)
            pSingleCode = value
        End Set
    End Property


    Private Sub frmUpdateShipWithTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadTheActiveCodes

    End Sub

    Private Sub LoadTheActiveCodes()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim i As Integer
        Dim CodeList As New ArrayList
        Dim DescList As New ArrayList

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        For i = 0 To frmMain.ThisUnitCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCodes(i))
        Next

        For i = 0 To frmMain.ThisUnitCstmMechCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCstmMechCodes(i))
        Next

        For i = 0 To frmMain.ThisUnitCstmRefCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCstmRefCodes(i))
        Next

        For i = 0 To frmMain.ThisUnitCstmCtrlCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCstmCtrlCodes(i))
        Next

        For i = 0 To frmMain.ThisUnitCstmHVCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCstmHVCodes(i))
        Next

        For i = 0 To frmMain.ThisUnitCstmSMCodes.Count - 1
            CodeList.Add(frmMain.ThisUnitCstmSMCodes(i))
        Next

        MySQL = "Select * FROM tblFisenInstalledOptions"
        rs.Open(MySQL, con)

        For i = 0 To CodeList.Count - 1
            rs.MoveFirst()
            rs.Find("FIOpCode='" & CodeList(i).ToString & "'")
            DescList.Add(CodeList(i) & "-" & rs.Fields("Description").Value)
        Next

        For i = 0 To DescList.Count - 1
            lstModCodesInPlay.Items.Add(DescList(i))
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        'If ValidateEntries() Then
        'Call UpdateStandardLoadRecord()
        'Else
        'Exit Sub
        'End If

        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()


        Me.Hide()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pcancelled = True
        Me.Hide()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pAOK = False
        pcancelled = False
        pSingleCode = "000000"

    End Sub

    Private Sub lstModCodesInPlay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModCodesInPlay.SelectedIndexChanged
        txtModCodeActive.Text = Mid(lstModCodesInPlay.SelectedItem.ToString, 1, 6)
        txtModWordsActive.Text = Mid(lstModCodesInPlay.SelectedItem.ToString, 8)
        Call PopulateActiveShipWithsRequired()
        Call PopulateAvailableShipWiths()

    End Sub

    Private Sub PopulateAvailableShipWiths()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim i As Integer
        Dim AddIt As Boolean

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        MySQL = "SELECT * FROM tblShipWiths"
        rs.Open(MySQL, con)

        lstAvailableShipWiths.Items.Clear()
        rs.MoveFirst()
        Do While Not (rs.EOF)
            AddIt = True
            For i = 0 To lstActiveShipWithsRequired.Items.Count - 1
                If (Mid(lstActiveShipWithsRequired.Items.Item(i).ToString, InStr(lstActiveShipWithsRequired.Items.Item(i).ToString, "-") + 1)) = (rs.Fields("ShipWithItem").Value.ToString) Then
                    AddIt = False
                End If
            Next
            If AddIt Then lstAvailableShipWiths.Items.Add(rs.Fields("ID").Value.ToString & "-" & rs.Fields("ShipWithItem").Value.ToString)
            rs.MoveNext()
        Loop


        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub PopulateActiveShipWithsRequired()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim i As Integer
        Dim CodeList As New ArrayList
        Dim DescList As New ArrayList

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT tblShipWithsRequired.FIOpCode, tblShipWithsRequired.FIOpID, tblShipWiths.ShipWithItem FROM tblShipWithsRequired INNER JOIN tblShipWiths ON tblShipWithsRequired.FIOpID = tblShipWiths.ID WHERE FIOpCode='" & txtModCodeActive.Text & "'"
        rs.Open(MySQL, con)

        If (rs.BOF And rs.EOF) Then
            lstActiveShipWithsRequired.Items.Clear()
            lstActiveShipWithsRequired.Items.Add("None Required")
        Else
            rs.MoveFirst()

            Do While Not (rs.EOF)
                CodeList.Add(rs.Fields("FIOpID").Value.ToString)
                DescList.Add(rs.Fields("FIOpID").Value.ToString & "-" & rs.Fields("ShipWithItem").Value.ToString)
                rs.MoveNext()
            Loop
        End If

        lstActiveShipWithsRequired.Items.Clear()
        For i = 0 To DescList.Count - 1
            lstActiveShipWithsRequired.Items.Add(DescList(i))
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmdMakeRequired_Click(sender As Object, e As EventArgs) Handles cmdMakeRequired.Click
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

        MySQL = "INSERT INTO tblShipWithsRequired (FIOpCode, FIOpID) VALUES ('" & txtModCodeActive.Text & "'," & Val(Mid(lstAvailableShipWiths.SelectedItem.ToString, 1, InStr(lstAvailableShipWiths.SelectedItem.ToString, "-") - 1)) & ")"
        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

        Call PopulateActiveShipWithsRequired()
        Call PopulateAvailableShipWiths()
        cmdMakeRequired.Enabled = False

    End Sub

    Private Sub lstAvailableShipWiths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailableShipWiths.SelectedIndexChanged
        cmdMakeRequired.Enabled = True
    End Sub

    Private Sub lstActiveShipWithsRequired_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActiveShipWithsRequired.SelectedIndexChanged
        cmdRemove.Enabled = True


    End Sub

    Private Sub RemoveRequiredItem()
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

        MySQL = "DELETE FROM tblShipWithsRequired WHERE ((FIOpCode='" & txtModCodeActive.Text & "') AND (FIOpID=" & Val(Mid(lstActiveShipWithsRequired.SelectedItem.ToString, 1, InStr(lstActiveShipWithsRequired.SelectedItem.ToString, "-") - 1)) & "))"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing


        Call PopulateActiveShipWithsRequired()

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Call RemoveRequiredItem()
        cmdRemove.Enabled = False
    End Sub

    Private Sub cmdCreateAvailable_Click(sender As Object, e As EventArgs) Handles cmdCreateAvailable.Click
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        If txtNewShipWith.Text = "" Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        'Insert SQL
        MySQL = "INSERT INTO tblShipWiths (ShipWithItem) VALUES ('" & txtNewShipWith.Text & "')"
        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

        Call PopulateAvailableShipWiths()
    End Sub
End Class