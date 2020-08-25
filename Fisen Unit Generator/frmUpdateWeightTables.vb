Public Class frmUpdateWeightTables
    Private pStubb As String
    Private pcancelled As Boolean

    Public Property Stubb As String
        Get
            Stubb = pStubb
        End Get
        Set(value As String)
            pstubb = value
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

    Private Sub frmUpdateWeightTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStubb.Text = pStubb
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
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
        Me.Hide()


    End Sub
End Class