Public Class frmPointEditCreate
    Private pCancelled As Boolean
    Private pWhichAction As String
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property WhichAction As String
        Get
            Return pWhichAction
        End Get
        Set(value As String)
            pWhichAction = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dummy As MsgBoxResult
        Dim errmsg As String

        Dim PntType, PntRW, PntRange, PntName, PntNotes As String
        Dim GTG As Boolean

        PntName = txtPointName.Text
        PntType = cmbType.Text
        PntRW = cmbRW.Text
        PntRange = cmbRange.Text
        PntNotes = txtNotes.Text

        GTG = True
        If PntName = "" Then GTG = False
        If PntType = "Unselected" Then GTG = False
        If PntRW = "Unselected" Then GTG = False
        If PntRange = "Unselected" Then GTG = False
        If PntNotes = "" Then GTG = False

        If GTG = False Then
            errmsg = "One or more of the expected peices of information is missing." & vbCrLf & "Please complete the required information."
            dummy = MsgBox(errmsg, vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If

        If pWhichAction = "Create" Then Call CreateNewPoint()

    End Sub

    Private Sub CreateNewPoint()

        Dim lPoint, lType, lNotes, lRange, lReadWrite As String

        Dim con As ADODB.Connection
        Dim dbProvider As String
        Dim MySQL As String

        lPoint = txtPointName.Text
        lType = cmbType.Text
        lRange = cmbRange.Text
        lNotes = txtNotes.Text
        lReadWrite = cmbRW.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        MySQL = "INSERT INTO tblPointList (Point, Type, Notes, Rng, ReadWrite) "
        MySQL = MySQL & "VALUES ('" & lPoint & "','" & lType & "','" & lNotes & "','" & lRange & "','" & lReadWrite & "')"

        con.Execute(MySQL)

        con = Nothing

        Me.Hide()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If pWhichAction = "Create" Then
            Select Case cmbType.Text
                Case Is = "BVAP"
                    cmbRW.Text = "R/W"
                Case Is = "BAVS"
                    cmbRW.Text = "R"
                Case Is = "BBVP"
                    cmbRW.Text = "R/W"
                Case Is = "BBVS"
                    cmbRW.Text = "R"
                Case Is = "Alarm"
                    cmbRW.Text = "R"
                Case Is = "n/a"
                    cmbRW.Text = "n/a"
                Case Is = "Unselected"
                    cmbRW.Text = "Unselected"
                    cmbRange.Text = "Unselected"
            End Select
        End If
    End Sub

    Private Sub frmPointEditCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pWhichAction = "Create" Then
            cmbType.Text = "Unselected"
            cmbRW.Text = "Unselected"
            cmbRange.Text = "Unselected"
            btnOK.Text = "Create"
            cmdMechOnly.Enabled = True
            Me.Text = "Create New Point"
        End If

    End Sub

    Private Sub cmdMechOnly_Click(sender As Object, e As EventArgs) Handles cmdMechOnly.Click
        txtNotes.Text = "There are no control points for the XXXXXXXXXX modification.  This modification does not involve the installation of any communicating sensors, end devices, or hardware.  This is a non-communicating modification."
        cmbType.Text = "n/a"
        cmbRW.Text = "n/a"
        cmbRange.Text = "n/a"
    End Sub
End Class