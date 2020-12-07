Public Class frmNewCustomCode
    Private pCancelled As Boolean
    Private pWhichCustom As String
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property WhichCustom As String
        Get
            Return pWhichCustom
        End Get
        Set(value As String)
            pWhichCustom = value
        End Set
    End Property
    Private Sub frmNewCustomCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & pWhichCustom
        Call GetNextCstmCode

    End Sub
    Private Sub GetNextCstmCode()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim TableName As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                TableName = "tblCstmSMDB"
            Case Else

        End Select

        MySQL = "SELECT * FROM " & TableName & " ORDER BY CstmCode"
        rs.Open(MySQL, con)
        rs.MoveLast()

        txtNewOpCode.Text = Val(rs.Fields("CstmCode").Value) + 1
        rs.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub chkMCAChange_CheckedChanged(sender As Object, e As EventArgs) Handles chkMCAChange.CheckedChanged
        If chkMCAChange.Checked Then
            Label4.Visible = True
            Label5.Visible = True
            txtLoadName.Visible = True
            txtLoadValue.Visible = True
        Else
            Label4.Visible = False
            Label5.Visible = False
            txtLoadName.Visible = False
            txtLoadName.Text = "-"
            txtLoadValue.Visible = False
            txtLoadValue.Text = "0"
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dummy As MsgBoxResult
        If Not (ValidParentCode(txtParentCode.Text)) Then
            dummy = MsgBox("That Parent Code does not appear to be properly formatted.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If
        Call WriteNewFIOPtoCstm()
        Call WriteNewFIOPtoFisenMain()
        Call CreateAndAssociateDetails

    End Sub

    Private Sub CreateAndAssociateDetails()
        Dim lNewFIOP As String
        Dim lMODCode As String

        lNewFIOP = txtNewOpCode.Text
        Select Case pWhichCustom
            Case Is = "Controls"
                lMODCode = "CstmCtrl" '980000
            Case Is = "Mechanical"
                lMODCode = "CstmMech" '940000
            Case Is = "Power"
                lMODCode = "CstmHV" '920000
            Case Is = "Refrigeration"
                lMODCode = "CstmRef" '970000
            Case Is = "Sheet Metal"
                lMODCode = "CstmSM" '990000
            Case Else
                lMODCode = "CstmSM" '990000
                Stop
        End Select
        frmConstDetails.FIOPCode = lNewFIOP
        frmConstDetails.PrimaryMod = lMODCode
        frmConstDetails.ShowDialog()
        frmConstDetails.Close()

    End Sub

    Private Function ValidParentCode(PCode As String) As Boolean
        Dim temppcode As Boolean
        Dim First2 As String

        temppcode = True

        If Not (chkTagALongOnly.Checked) Then
            temppcode = True
        Else
            PCode = UCase(PCode)
            PCode = Trim(PCode)
            If Len(PCode) <> 6 Then
                temppcode = False
            Else
                First2 = Mid(PCode, 1, 2)
                Select Case pWhichCustom
                    Case Is = "Controls"
                        If First2 <> "98" Then temppcode = False
                    Case Is = "Mechanical"
                        If First2 <> "94" Then temppcode = False
                    Case Is = "Power"
                        If First2 <> "92" Then temppcode = False
                    Case Is = "Refrigeration"
                        If First2 <> "97" Then temppcode = False
                    Case Is = "Sheet Metal"
                        If First2 <> "99" Then temppcode = False
                End Select
            End If
        End If






        Return temppcode
    End Function

    Private Sub WriteNewFIOPtoFisenMain()
        Dim con As ADODB.Connection
        Dim dbProvider As String
        Dim MySQL As String

        Dim NewCode, NewModCode, NewLevel, NewDesc, NewParent, DQText As String
        Dim NewDev, NewIncludeOnFIOP, NewCULLineItem, NewDQREquired As String

        NewCode = txtNewOpCode.Text
        Select Case pWhichCustom
            Case Is = "Controls"
                NewModCode = "CstmCtrl" '980000
                NewParent = "980000"
            Case Is = "Mechanical"
                NewModCode = "CstmMech" '940000
                NewParent = "940000"
            Case Is = "Power"
                NewModCode = "CstmHV" '920000
                NewParent = "920000"
            Case Is = "Refrigeration"
                NewModCode = "CstmRef" '970000
                NewParent = "970000"
            Case Is = "Sheet Metal"
                NewModCode = "CstmSM" '990000
                NewParent = "990000"
            Case Else
                NewModCode = "CstmSM" '990000
                NewParent = "990000"
                Stop
        End Select

        If chkTagALongOnly.Checked Then NewParent = Trim(txtParentCode.Text)

        NewLevel = Trim(Str(nudLevel.Value))
        NewDesc = txtCstmFIOP.Text
        If chkDEV.Checked Then NewDev = "TRUE" Else NewDev = "FALSE"
        NewIncludeOnFIOP = "TRUE"
        If chkCUL.Checked Then NewCULLineItem = "TRUE" Else NewCULLineItem = "FALSE"
        NewDQREquired = "FALSE"
        DQText = ""

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()




        'MySQL = "INSERT INTO tblFisenInstalledOptions (FIOpCode,ModCode,Level,Description,Parent,Dev,IncludeOnFIOP,CULLineItem,DQRqd,DQText,Field1) "
        'MySQL = MySQL & "VALUES ('" & NewCode & "','" & NewModCode & "'," & Val(NewLevel) & ",'" & NewDesc & "','" & NewParent & "'," & NewDev & "," & NewCULLineItem & "," & NewCULLineItem & "," & NewDQREquired & ",'" & DQText & "',0)"

        MySQL = "INSERT INTO tblFisenInstalledOptions "
        MySQL = MySQL & "VALUES ('" & NewCode & "','" & NewModCode & "'," & Val(NewLevel) & ",'" & NewDesc & "','" & NewParent & "'," & NewDev & "," & NewIncludeOnFIOP & "," & NewCULLineItem & "," & NewDQREquired & ",'" & DQText & "',0)"


        Debug.Print(MySQL)
        con.Execute(MySQL)

        con = Nothing

        Me.Hide()

    End Sub
    Private Sub WriteNewFIOPtoCstm()
        Dim con As ADODB.Connection
        'Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim TableName As String

        Dim NewCode, NewDesc, NewWeight, LoadName, LoadVal, MCAChange, TagALong, DesignCaution As String
        Dim TestAF, TestCoil, TestCtrl, TestHydro, TestElec, TestGas, TestGTrain, TestRefInst, TestRefer, TestMotor As String

        'Needs Select and Series 12
        Dim S5, S10, S20, S40, S100A, S100B, S100C, S100, SLX, SChoice, SPremier, SXTO, SXTI, SYVAA, SYCAL, SYLAA As String

        NewCode = txtNewOpCode.Text
        NewDesc = txtCstmFIOP.Text
        If chkTagALongOnly.Checked Then TagALong = "TRUE" Else TagALong = "FALSE"
        NewWeight = txtWeight.Text
        If chkMCAChange.Checked Then MCAChange = "TRUE" Else MCAChange = "FALSE"
        LoadName = txtLoadName.Text
        LoadVal = txtLoadValue.Text

        If chkTestAirflow.Checked Then TestAF = "TRUE" Else TestAF = "FALSE"
        If chkTestCoil.Checked Then TestCoil = "TRUE" Else TestCoil = "FALSE"
        If chkTestControls.Checked Then TestCtrl = "TRUE" Else TestCtrl = "FALSE"
        If chkTestHydro.Checked Then TestHydro = "TRUE" Else TestHydro = "FALSE"
        If chkTestEHeat.Checked Then TestElec = "TRUE" Else TestElec = "FALSE"
        If chkTestGasHeat.Checked Then TestGas = "TRUE" Else TestGas = "FALSE"
        If chkTestGasTrain.Checked Then TestGTrain = "TRUE" Else TestGTrain = "FALSE"
        If chkTestReferInst.Checked Then TestRefInst = "TRUE" Else TestRefInst = "FALSE"
        If chkTestRefer.Checked Then TestRefer = "TRUE" Else TestRefer = "FALSE"
        If chkTestMotors.Checked Then TestMotor = "TRUE" Else TestMotor = "FALSE"

        If chkSeries5.Checked Then S5 = "TRUE" Else S5 = "FALSE"
        If chkSeries10.Checked Then S10 = "TRUE" Else S10 = "FALSE"
        If chkSeries20.Checked Then S20 = "TRUE" Else S20 = "FALSE"
        If chkSeries40.Checked Then S40 = "TRUE" Else S40 = "FALSE"
        If chkSeries100A.Checked Then S100A = "TRUE" Else S100A = "FALSE"
        If chkSeries100B.Checked Then S100B = "TRUE" Else S100B = "FALSE"
        If chkSeries100C.Checked Then S100C = "TRUE" Else S100C = "FALSE"
        If (chkSeries100A.Checked Or chkSeries100B.Checked Or chkSeries100C.Checked) Then S100 = "TRUE" Else S100 = "FALSE"
        If chkSeriesLX.Checked Then SLX = "TRUE" Else SLX = "FALSE"
        If chkSeriesChoice.Checked Then SChoice = "TRUE" Else SChoice = "FALSE"
        If chkSeriesPremier.Checked Then SPremier = "TRUE" Else SPremier = "FALSE"
        If chkSeriesXTO.Checked Then SXTO = "TRUE" Else SXTO = "FALSE"
        If chkSeriesXTI.Checked Then SXTI = "TRUE" Else SXTI = "FALSE"
        If chkSeriesYVAA.Checked Then SYVAA = "TRUE" Else SYVAA = "FALSE"
        If chkSeriesYCAL.Checked Then SYCAL = "TRUE" Else SYCAL = "FALSE"
        If chkSeriesYLAA.Checked Then SYLAA = "TRUE" Else SYLAA = "FALSE"
        If chkDesignCaution.Checked Then DesignCaution = "TRUE" Else DesignCaution = "FALSE"

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()


        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                TableName = "tblCstmSMDB"
            Case Else

        End Select

        MySQL = "INSERT INTO " & TableName & " (CstmCode,TagALongOnly,CstmFIOP,CstmWeight,MCAChange,LoadName,LoadValue,DesignCaution,TestAF,TestCoil,TestCtrl,TestMotor,TestEHeat,TestGHeat,TestGTrain,TestHydro,TestRef,TestRefInst,Series5OK,Series10OK,Series20OK,Series40OK,Series100OK,Series100AOK,Series100BOK,Series100COK,XTIOK,XTOOK,ChoiceOK,PremierOK,YVAAOK,YCALOK,YLAAOK,SeriesLXOK) "
        MySQL = MySQL & "VALUES ('" & NewCode & "'," & TagALong & ",'" & NewDesc & "', " & Val(NewWeight) & "," & MCAChange & ",'" & LoadName & "','" & LoadVal & "'," & DesignCaution
        MySQL = MySQL & "," & TestAF & "," & TestCoil & "," & TestCtrl & "," & TestMotor & "," & TestElec & "," & TestGas & "," & TestGTrain & "," & TestHydro & "," & TestRefer & "," & TestRefInst
        MySQL = MySQL & "," & S5 & "," & S10 & "," & S20 & "," & S40 & "," & S100 & "," & S100A & "," & S100B & "," & S100C & "," & SXTI & "," & SXTO & "," & SChoice & "," & SPremier & "," & SYVAA & "," & SYCAL & "," & SYLAA & "," & SLX & ")"

        con.Execute(MySQL)

        'rs.Close()
        'rs = Nothing
        con = Nothing

        Me.Hide()

    End Sub

    Private Sub chkTagALongOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkTagALongOnly.CheckedChanged
        If chkTagALongOnly.Checked = True Then
            nudLevel.Enabled = True
            nudLevel.Value = 2
            nudLevel.Minimum = 2
            lblParentCode.Visible = True
            txtParentCode.Visible = True

        Else
            nudLevel.Minimum = 1
            nudLevel.Value = 1
            nudLevel.Enabled = False
            lblParentCode.Visible = False
            txtParentCode.Visible = False
            txtParentCode.Text = ""
        End If
    End Sub
End Class