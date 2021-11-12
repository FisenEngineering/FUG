Imports Microsoft.Office.Interop.Excel


Public Class frmUpdateWeightTables
    Private pStubb As String
    Private pcancelled As Boolean
    Private pAOK As Boolean

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

    Private Sub frmUpdateWeightTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStubb.Text = pStubb
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pcancelled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dummy As MsgBoxResult
        Dim msgstring As String
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim Stubb, Mass, AMass, BMass, CMass, DMass As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Stubb = txtStubb.Text
        Mass = txtBaseWeight.Text
        AMass = txtAWeight.Text
        BMass = txtBWeight.Text
        CMass = txtCWeight.Text
        DMass = txtDWeight.Text

        MySQL = "INSERT INTO tblUPGWeights (ModelStub,BaseWeight,AWeight,BWeight,CWeight,DWeight) VALUES ('" & Stubb & "','" & Mass & "','" & AMass & "','" & BMass & "','" & CMass & "','" & DMass & "')"
        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

        msgstring = "Program will pause for up to 3 seconds for database update."
        dummy = MsgBox(msgstring, vbOKOnly, "Fisen Unit Generator")

        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()
        Do While Not (pAOK)
            'do nothing
            My.Application.DoEvents()
        Loop
        Me.Hide()
    End Sub

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