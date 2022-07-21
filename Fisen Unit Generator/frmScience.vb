Public Class frmScience
    Private pCancelled As Boolean
    Private pCallingMod As String
    Private pSciPath As String
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property CallingMod As String
        Get
            CallingMod = pCallingMod
        End Get
        Set(value As String)
            pCallingMod = value
        End Set
    End Property
    Public Property SciPath As String
        Get
            SciPath = pSciPath
        End Get
        Set(value As String)
            pSciPath = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pCancelled = False
    End Sub

    Private Sub frmScience_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = pCallingMod & "Design Notes Inspector"
        lblSciPath.Text = pSciPath
        lblUnitFamily.Text = frmMain.ThisUnit.Family

        Call PopulateSciFactList(False)

    End Sub

    Private Sub PopulateSciFactList(FbyF As Boolean)
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

        If Not (FbyF) Then
            MySQL = "SELECT * FROM tblScienceFacts WHERE ModID='" & pCallingMod & "'"
        Else
            '
        End If

        rs.Open(MySQL, con)
        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstSciFact.Items.Add(rs.Fields("SciShortText").Value.ToString)
            rs.MoveNext()
        Loop
    End Sub
End Class