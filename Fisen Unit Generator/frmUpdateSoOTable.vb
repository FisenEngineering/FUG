Public Class frmUpdateSoOTable
    Private pcancelled As Boolean
    Private pAOK As Boolean
    Private pSingleCode As String
    Private SoORoot As String
    Private pActiveFilePath As New ArrayList
    Private pActiveShortNames As New ArrayList

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

    Private Sub frmUpdateSoOTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadTheActiveCodes()
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
        'This delay permits the database update to propigate.  There's probably a better way.
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
        SoORoot = My.Settings.ResourceDir & "Mods\EAM\SequenceOfOperation\"

    End Sub

    Private Sub lstModCodesInPlay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModCodesInPlay.SelectedIndexChanged
        txtModCodeActive.Text = Mid(lstModCodesInPlay.SelectedItem.ToString, 1, 6)
        txtModWordsActive.Text = Mid(lstModCodesInPlay.SelectedItem.ToString, 8)
        Call PopulateActiveSoORequired()
        Call PopulateAvailableSoOFiles()
    End Sub

    Private Sub PopulateActiveSoORequired()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim i As Integer
        Dim DescList As New ArrayList

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblSequenceofOperation WHERE FIOpCode='" & txtModCodeActive.Text & "'"
        rs.Open(MySQL, con)

        If (rs.BOF And rs.EOF) Then
            lstActiveSoO.Items.Clear()
            lstActiveSoO.Items.Add("None Required")
        Else
            rs.MoveFirst()

            pActiveFilePath.Clear()
            pActiveShortNames.Clear()

            Do While Not (rs.EOF)
                pActiveFilePath.Add(My.Settings.ResourceDir & "\Mods\" & rs.Fields("SequenceText").Value.ToString)
                DescList.Add(rs.Fields("ShortName").Value.ToString & "-" & rs.Fields("Description").Value.ToString)
                pActiveShortNames.Add(rs.Fields("ShortName").Value.ToString)
                rs.MoveNext()
            Loop
        End If

        lstActiveSoO.Items.Clear()
        For i = 0 To DescList.Count - 1
            lstActiveSoO.Items.Add(DescList(i))
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub



    Private Sub lstActiveSoO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActiveSoO.SelectedIndexChanged
        lstAvailableSoOFiles.ClearSelected()
        Call PopulateSoOPreview()
        cmdRemove.Enabled = True
    End Sub

    Private Sub PopulateSoOPreview()
        If lstActiveSoO.SelectedIndex > -1 Then
            rtbSoOPreview.LoadFile(pActiveFilePath.Item(lstActiveSoO.SelectedIndex))
        End If
    End Sub

    Private Sub PopulateAvailableSoOFiles()
        Dim MyDirInfo As New IO.DirectoryInfo(SoORoot)
        Dim MyFileInfoArray As IO.FileInfo() = MyDirInfo.GetFiles("*.rtf")
        Dim MyFileInfo As IO.FileInfo

        lstAvailableSoOFiles.Items.Clear()

        For Each MyFileInfo In MyFileInfoArray
            lstAvailableSoOFiles.Items.Add(MyFileInfo.FullName)
        Next

    End Sub

    Private Sub cmdChangeDirectory_Click(sender As Object, e As EventArgs) Handles cmdChangeDirectory.Click
        fbd.SelectedPath = SoORoot
        'fbd.RootFolder = My.Settings.ResourceDir
        fbd.ShowDialog()
        SoORoot = fbd.SelectedPath
        Call PopulateAvailableSoOFiles()
    End Sub

    Private Sub lstAvailableSoOFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailableSoOFiles.SelectedIndexChanged
        lstActiveSoO.ClearSelected()
        rtbSoOPreview.Text = ""
        If lstAvailableSoOFiles.SelectedIndex > -1 Then
            rtbSoOPreview.LoadFile(lstAvailableSoOFiles.Text)
            cmdMakeRequired.Enabled = True
        Else
            cmdMakeRequired.Enabled = False
        End If
    End Sub

    Private Sub cmdMakeRequired_Click(sender As Object, e As EventArgs) Handles cmdMakeRequired.Click
        Dim verGuess, DescGuess, SNameGuess As String

        verGuess = SoOVersionGuess(lstAvailableSoOFiles.Text)
        DescGuess = DescriptionGuess(lstAvailableSoOFiles.Text)
        SNameGuess = ShortNameGuess(lstAvailableSoOFiles.Text)

        frmMakeSoORequired.MyVer = verGuess
        frmMakeSoORequired.MyDesc = DescGuess
        frmMakeSoORequired.MyShortName = SNameGuess

        frmMakeSoORequired.ShowDialog()

        'Call MakeItemRequired()
        cmdMakeRequired.Enabled = False
    End Sub

    Private Function ShortNameGuess(SoOFilePath As String) As String
        Dim CodeRoot As String
        Dim NameGuess As String
        Dim USLoc, DotLoc, slashLoc As Integer

        CodeRoot = "EAM"
        USLoc = InStrRev(SoOFilePath, "_")
        DotLoc = InStrRev(SoOFilePath, ".")
        slashLoc = InStrRev(SoOFilePath, "\")

        If USLoc > 0 Then
            NameGuess = CodeRoot & "_" & Mid(SoOFilePath, USLoc + 1, DotLoc - USLoc - 1)
        Else
            NameGuess = CodeRoot & "_" & Mid(SoOFilePath, slashLoc + 1, DotLoc - slashLoc - 1)
        End If

        Return NameGuess
    End Function

    Private Function DescriptionGuess(SoOFilePath As String) As String
        Dim locstart, locstop, loclength As Integer
        locstart = 0
        locstop = rtbSoOPreview.Find("(", RichTextBoxFinds.NoHighlight)
        locstop = locstop - 1
        loclength = locstop - locstart + 1

        Return rtbSoOPreview.Text.Substring(locstart, loclength)
    End Function

    Private Function SoOVersionGuess(SoOFilePath As String) As String
        Dim locstart, locstop, loclength As Integer
        locstart = rtbSoOPreview.Find("Ver.", RichTextBoxFinds.NoHighlight)
        locstart = locstart + 5
        locstop = rtbSoOPreview.Find(")", RichTextBoxFinds.NoHighlight)
        locstop = locstop - 1
        loclength = locstop - locstart + 1

        Return rtbSoOPreview.Text.Substring(locstart, loclength)

    End Function

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Call RemoveRequiredItem()
        cmdRemove.Enabled = False
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

        MySQL = "DELETE FROM tblSequenceofOperation WHERE ((FIOpCode='" & txtModCodeActive.Text & "') AND (ShortName='" & pActiveShortNames.Item(lstActiveSoO.SelectedIndex) & "'))"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing


    End Sub

End Class