Public Class frmUpdateElectricalTables
    Private pStubb As String
    Private pcancelled As Boolean
    Private pVolts As String
    Private pPhase As String
    Private pAOK As Boolean
    Public Property Volts As String
        Get
            Volts = pVolts
        End Get
        Set(value As String)
            pVolts = value
        End Set
    End Property
    Public Property Phase As String
        Get
            Phase = pPhase
        End Get
        Set(value As String)
            pPhase = value
        End Set
    End Property
    Public Property Stubb As String
        Get
            Stubb = pStubb
        End Get
        Set(value As String)
            pStubb = value
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
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If ValidateEntries() Then
            Call UpdateStandardLoadRecord()
        Else
            Exit Sub
        End If
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()
        Do While Not (pAOK)
            'do nothing
            My.Application.DoEvents()
        Loop
        Me.Hide()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        pcancelled = True
        Me.Hide()
    End Sub

    Private Sub frmUpdateElectricalTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStubb.Text = pStubb
        txtVoltage.Text = pVolts
        txtPhase.Text = pPhase
        Call LoadStandardLoads()


    End Sub

    Private Sub UpdateStandardLoadRecord()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim ExistingRecordID As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblElectricalInfo WHERE (JCISnipit='" & txtStubb.Text & "') AND (Voltage='" & txtVoltage.Text & "')"
        rs.Open(MySQL, con)

        ExistingRecordID = rs.Fields(0).Value
        MySQL = "UPDATE tblElectricalInfo SET Compressor1FLA='" & txtCompFLA1.Text & "', Compressor2FLA='" & txtCompFLA2.Text & "', Compressor3FLA='" & txtCompFLA3.Text & "', Compressor4FLA='" & txtCompFLA4.Text & "', Compressor5FLA='" & txtCompFLA5.Text & "', Compressor6FLA='" & txtCompFLA6.Text & "', Compressor7FLA='" & txtCompFLA7.Text & "', Compressor8FLA='" & txtCompFLA8.Text & "', "
        MySQL = MySQL & "CondenserFan1FLA='" & txtCFanFLA1.Text & "', CondenserFan2FLA='" & txtCFanFLA2.Text & "', CondenserFan3FLA='" & txtCFanFLA3.Text & "', CondenserFan4FLA='" & txtCFanFLA4.Text & "', CondenserFan5FLA='" & txtCFanFLA5.Text & "', CondenserFan6FLA='" & txtCFanFLA6.Text & "', CondenserFan7FLA='" & txtCFanFLA7.Text & "', CondenserFan8FLA='" & txtCFanFLA8.Text & "', CondenserFan9FLA='" & txtCFanFLA9.Text & "', "
        MySQL = MySQL & "CondenserFan1HP='" & txtCFanHP1.Text & "', CondenserFan2HP='" & txtCFanHP2.Text & "', CondenserFan3HP='" & txtCFanHP3.Text & "', CondenserFan4HP='" & txtCFanHP4.Text & "', CondenserFan5HP='" & txtCFanHP5.Text & "', CondenserFan6HP='" & txtCFanHP6.Text & "', CondenserFan7HP='" & txtCFanHP7.Text & "', CondenserFan8HP='" & txtCFanHP8.Text & "', CondenserFan9HP='" & txtCFanHP9.Text & "', "
        MySQL = MySQL & "DataDate='" & txtDataDate.Text & "', DataSource='" & txtDataSource.Text & "' WHERE ID=" & ExistingRecordID
        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub LoadStandardLoads()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim Snipet As String
        Dim Volts As String
        Dim i As Integer
        Dim ThisTextBox As TextBox

        Dim ThisField As String
        Dim ThisFieldHP As String


        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Snipet = txtStubb.Text
        Volts = txtVoltage.Text

        MySQL = "SELECT * FROM tblElectricalInfo WHERE (JCISnipit='" & Snipet & "') AND (Voltage='" & Volts & "')"

        rs.Open(MySQL, con)

        For i = 1 To 8
            ThisField = "Compressor" & Trim(Str(i)) & "FLA"
            ThisTextBox = Me.Controls("txtCompFLA" & Trim(Str(i)))
            ThisTextBox.Text = rs.Fields(ThisField).Value
        Next i

        For i = 1 To 9
            ThisField = "CondenserFan" & Trim(Str(i)) & "FLA"
            ThisFieldHP = "CondenserFan" & Trim(Str(i)) & "HP"
            ThisTextBox = Me.Controls("txtCFanFLA" & Trim(Str(i)))
            ThisTextBox.Text = rs.Fields(ThisField).Value
            ThisTextBox = Me.Controls("txtCFanHP" & Trim(Str(i)))
            ThisTextBox.Text = rs.Fields(ThisFieldHP).Value
        Next i

        txtDataDate.Text = rs.Fields("DataDate").Value
        txtDataSource.Text = rs.Fields("DataSource").Value

        con.Close()
        rs = Nothing
        con = Nothing


    End Sub
    Private Function ValidateEntries() As Boolean
        Dim GTG As Boolean
        Dim i As Integer
        Dim ThisTextBox As TextBox
        Dim dummy As MsgBoxResult
        Dim msgstr As String
        Dim mymonth As String
        Dim myyear As String

        GTG = True

        For i = 1 To 8
            ThisTextBox = Me.Controls("txtCompFLA" & Trim(Str(i)))
            If Not (IsNumeric(ThisTextBox.Text)) Then
                msgstr = "The entry in Compressor " & Trim(Str(i)) & " RLA must be a numeric value."
                dummy = MsgBox(msgstr)
                GTG = False
                Exit For
            End If
        Next

        If GTG Then
            For i = 1 To 9
                ThisTextBox = Me.Controls("txtCFanFLA" & Trim(Str(i)))
                If Not (IsNumeric(ThisTextBox.Text)) Then
                    msgstr = "The entry in Condenser Fan " & Trim(Str(i)) & " FLA must be a numeric value."
                    dummy = MsgBox(msgstr)
                    GTG = False
                    Exit For
                End If
            Next
        End If

        If GTG Then
            For i = 1 To 9
                ThisTextBox = Me.Controls("txtCFanHP" & Trim(Str(i)))
                If ThisTextBox.Text = "" Then
                    msgstr = "The entry in Condenser Fan " & Trim(Str(i)) & " HP must not be blank."
                    dummy = MsgBox(msgstr)
                    GTG = False
                    Exit For
                End If
            Next
        End If

        If GTG Then
            If Len(txtDataDate.Text) <> 4 Then
                msgstr = "The entry in Data Date HP must be in the format YYMM"
                dummy = MsgBox(msgstr)
                GTG = False
            End If

            If GTG Then
                mymonth = Mid(txtDataDate.Text, 3, 2)
                myyear = Mid(txtDataDate.Text, 1, 2)
                If Not (IsNumeric(mymonth)) Or Not (IsNumeric(myyear)) Then
                    GTG = False
                End If

                If GTG Then
                    If (Val(mymonth) < 1) Or Val(mymonth > 12) Then
                        GTG = False
                    End If
                End If

                If Not (GTG) Then
                    msgstr = "The entry in Data Date HP must be in the format YYMM"
                    dummy = MsgBox(msgstr)
                    GTG = False
                End If
            End If

            If GTG Then
                If txtDataSource.Text = "" Then
                    msgstr = "The Data Source entry must not be blank."
                    dummy = MsgBox(msgstr)
                    GTG = False
                End If
            End If

        End If

        Return GTG
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        pAOK = True

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pAOK = False
    End Sub
End Class