Public Class frmNewCustomCode
    Private pCancelled As Boolean
    Private pWhichCustom As String
    Private pNewOrEdit As String
    Public Property NewOrEdit As String
        Get
            Return pNewOrEdit
        End Get
        Set(value As String)
            pNewOrEdit = value
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
    Public Property WhichCustom As String
        Get
            Return pWhichCustom
        End Get
        Set(value As String)
            pWhichCustom = value
        End Set
    End Property
    Private Sub frmNewCustomCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fiopcode As String

        If pNewOrEdit = "New" Then
            Me.Text = "Edit Existing Custom Code " & pWhichCustom
            Call GetNextCstmCode()
        Else
            Me.Text = "New Custom Code " & pWhichCustom
            fiopcode = InputBox("Please Enter the Fisen Installed OPtion code you want to edit.", "Fisen Unit Generator")
            If Not (LoadOldCode(fiopcode)) Then
                'The code loaded was bad
            Else
                'The code loaded AOK
            End If
        End If



    End Sub
    Private Function LoadOldCode(lcode As String) As Boolean
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim TableName As String
        Dim Dummy As MsgBoxResult

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Dim GTG As Boolean

        GTG = True
        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                TableName = "tblCstmSMDB"
            Case Is = "Power"
                TableName = "tblCstmHVDB"
            Case Is = "Controls"
                TableName = "tblCstmCtrl"
            Case Is = "Mechanical"
                TableName = "tblCstmMechDB"
            Case Is = "Refrigeration"
                TableName = "tblCstmRef"
            Case Else
                TableName = "Error"
                Dummy = MsgBox("Error in selecting database field: " & pWhichCustom & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select

        MySQL = "SELECT * FROM " & TableName & " WHERE CstmCode='" & lcode & "'"
        rs.Open(MySQL, con)

        If rs.BOF And rs.EOF Then
            GTG = False
        Else
            txtNewOpCode.Text = lcode
            txtCstmFIOP.Text = rs.Fields("CstmFIOP").Value.ToString
            chkTagALongOnly.Checked = rs.Fields("TagALongOnly").Value
            chkDesignCaution.Checked = rs.Fields("DesignCaution").Value
            txtWeight.Text = rs.Fields("CstmWeight").Value

            chkMCAChange.Checked = rs.Fields("MCAChange").Value
            txtLoadName.Text = rs.Fields("LoadName").Value.ToString
            txtLoadValue.Text = rs.Fields("LoadValue").Value.ToString
            txtLoadHP.Text = rs.Fields("LoadHP").Value.ToString

            chkTestAirflow.Checked = rs.Fields("TestAF").Value
            chkTestCoil.Checked = rs.Fields("TestCoil").Value
            chkTestControls.Checked = rs.Fields("TestCtrl").Value
            chkTestHydro.Checked = rs.Fields("TestHydro").Value
            chkTestEHeat.Checked = rs.Fields("TestEHeat").Value
            chkTestGasHeat.Checked = rs.Fields("TestGHeat").Value
            chkTestGasTrain.Checked = rs.Fields("TestGTrain").Value
            chkTestReferInst.Checked = rs.Fields("TestRefInst").Value
            chkTestRefer.Checked = rs.Fields("TestRef").Value
            chkTestMotors.Checked = rs.Fields("TestMotor").Value

            chkSeries5.Checked = rs.Fields("Series5OK").Value
            chkSeries10.Checked = rs.Fields("Series10OK").Value
            chkSeries20.Checked = rs.Fields("Series20OK").Value
            chkSeries40.Checked = rs.Fields("Series40OK").Value
            chkSeries12.Checked = rs.Fields("Series12OK").Value
            chkSeries100A.Checked = rs.Fields("Series100AOK").Value
            chkSeries100B.Checked = rs.Fields("Series100BOK").Value
            chkSeries100C.Checked = rs.Fields("Series100COK").Value
            chkSeriesLX.Checked = rs.Fields("SeriesLXOK").Value
            chkSeriesChoice.Checked = rs.Fields("ChoiceOK").Value
            chkSeriesPremier.Checked = rs.Fields("PremierOK").Value
            chkSeriesSelect.Checked = rs.Fields("SelectOK").Value
            chkSeries20ODSplit.Checked = rs.Fields("Series20ODSplitOK").Value
            chkSeries20IDSplit.Checked = rs.Fields("Series20IDSplitOK").Value
            chkSeries40ODSplit.Checked = rs.Fields("Series40ODSplitOK").Value
            chkYCUL.Checked = rs.Fields("YCULOK").Value
            chkYULA.Checked = rs.Fields("YLUAOK").Value
            chkSeriesXTO.Checked = rs.Fields("XTOOK").Value
            chkSeriesXTI.Checked = rs.Fields("XTIOK").Value
            chkSeriesL.Checked = rs.Fields("SeriesLOK").Value
            chkDOAS.Checked = rs.Fields("DOASOK").Value
            chkBlank.Checked = rs.Fields("BlankOK").Value
            chkSeriesYVAA.Checked = rs.Fields("YVAAOK").Value
            chkSeriesYCAL.Checked = rs.Fields("YCALOK").Value
            chkSeriesYLAA.Checked = rs.Fields("YLAAOK").Value

        End If

        rs.Close()
        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode='" & lcode & "'"
        rs.Open(MySQL, con)
        If rs.BOF And rs.EOF Then
            GTG = False
        Else
            chkCUL.Checked = rs.Fields("CULLineItem").Value
            chkDEV.Checked = rs.Fields("Dev").Value
            chkIncludeOnFIOP.Checked = rs.Fields("IncludeOnFIOP").Value
            chkDQRqd.Checked = rs.Fields("DQRqd").Value
            txtDQText.Text = rs.Fields("DQText").Value.ToString
            nudLevel.Value = rs.Fields("Level").Value
            txtParentCode.Text = rs.Fields("Parent").Value.ToString
        End If

        rs.Close()
        rs = Nothing
        con = Nothing



        Return GTG
    End Function
    Private Sub GetNextCstmCode()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim FieldName As String
        Dim dummy As MsgBoxResult

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                FieldName = "CstmSM"
            Case Is = "Power"
                FieldName = "CstmPower"
            Case Is = "Controls"
                FieldName = "CstmCtrl"
            Case Is = "Mechanical"
                FieldName = "CstmMech"
            Case Is = "Refrigeration"
                FieldName = "CstmRef"
            Case Else
                FieldName = "Error"
                dummy = MsgBox("Error in selecting database field: " & pWhichCustom & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select

        MySQL = "SELECT * FROM tblCstmNextNum"
        rs.Open(MySQL, con)
        rs.MoveLast()

        txtNewOpCode.Text = rs.Fields(FieldName).Value
        rs.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub WriteNextCstmCode()
        Dim con As ADODB.Connection
        Dim dbProvider As String
        Dim MySQL As String
        Dim FieldName As String
        Dim dummy As MsgBoxResult

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                FieldName = "CstmSM"
            Case Is = "Power"
                FieldName = "CstmPower"
            Case Is = "Controls"
                FieldName = "CstmCtrl"
            Case Is = "Mechanical"
                FieldName = "CstmMech"
            Case Is = "Refrigeration"
                FieldName = "CstmRef"
            Case Else
                FieldName = "Error"
                dummy = MsgBox("Error in selecting database field: " & pWhichCustom & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select

        MySQL = "UPDATE tblCstmNextNum SET " & FieldName & "='" & Trim(Str(Val(txtNewOpCode.Text) + 1)) & "' WHERE PK=1"
        con.Execute(MySQL)
        con.Close()
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

        If pNewOrEdit = "New" Then
            Call WriteNewFIOPtoCstm()
            Call WriteNextCstmCode()
            Call WriteNewFIOPtoFisenMain()
            Call CreateAndAssociateDetails()

            frmAssociateDrawings.ShowDialog()
        Else
            Call WriteUpdatetoCstm
        End If

    End Sub

    Private Sub WriteUpdatetoCstm()

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
        Dim dummy As MsgBoxResult

        Dim con As ADODB.Connection
        'Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim TableName As String

        Dim NewCode, NewDesc, NewWeight, LoadName, LoadVal, MCAChange, TagALong, DesignCaution As String
        Dim TestAF, TestCoil, TestCtrl, TestHydro, TestElec, TestGas, TestGTrain, TestRefInst, TestRefer, TestMotor As String

        'Needs Select and Series 12
        Dim S5, S10, S20, S40, S100A, S100B, S100C, S100, SLX, SChoice, SPremier, SXTO, SXTI, SYVAA, SYCAL, SYLAA As String
        Dim SSelect, S12, SSeriesL, S20ODSplt, S20IDSplit, S40ODSplit, SBlank, SYCUL, SYLUA, SDOAS As String

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
        If chkSeriesSelect.Checked Then SSelect = "True" Else SSelect = "False"
        If chkSeries12.Checked Then S12 = "True" Else S12 = "False"
        If chkSeriesL.Checked Then SSeriesL = "True" Else SSeriesL = "False"
        If chkSeries20ODSplit.Checked Then S20ODSplt = "True" Else S20ODSplt = "False"
        If chkSeries20IDSplit.Checked Then S20IDSplit = "True" Else S20IDSplit = "False"
        If chkSeries40ODSplit.Checked Then S40ODSplit = "True" Else S40ODSplit = "False"
        If chkBlank.Checked Then SBlank = "True" Else SBlank = "False"
        If chkYCUL.Checked Then SYCUL = "True" Else SYCUL = "False"
        If chkYULA.Checked Then SYLUA = "True" Else SYLUA = "False"
        If chkDOAS.Checked Then SDOAS = "True" Else SDOAS = "False"

        If chkDesignCaution.Checked Then DesignCaution = "TRUE" Else DesignCaution = "FALSE"

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()


        Select Case pWhichCustom
            Case Is = "Sheet Metal"
                TableName = "tblCstmSMDB"
            Case Is = "Power"
                TableName = "tblCstmHVDB"
            Case Is = "Controls"
                TableName = "tblCstmCtrl"
            Case Is = "Mechanical"
                TableName = "tblCstmMechDB"
            Case Is = "Refrigeration"
                TableName = "tblCstmRef"
            Case Else
                TableName = "Error"
                dummy = MsgBox("Error in selecting database table: " & pWhichCustom & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select

        MySQL = "INSERT INTO " & TableName & " (CstmCode,TagALongOnly,CstmFIOP,CstmWeight,MCAChange,LoadName,LoadValue,DesignCaution,TestAF,TestCoil,TestCtrl,TestMotor,TestEHeat,TestGHeat,TestGTrain,TestHydro,TestRef,TestRefInst,Series5OK,Series10OK,Series20OK,Series40OK,Series100OK,Series100AOK,Series100BOK,Series100COK,XTIOK,XTOOK,ChoiceOK,PremierOK,YVAAOK,YCALOK,YLAAOK,SeriesLXOK,BlankOK,Series20ODSplitOK,Series20IDSplitOK,Series40ODSplitOK,YCULOK,YLUAOK,DOASOK,SeriesLOK) "
        MySQL = MySQL & "VALUES ('" & NewCode & "'," & TagALong & ",'" & NewDesc & "', " & Val(NewWeight) & "," & MCAChange & ",'" & LoadName & "','" & LoadVal & "'," & DesignCaution
        MySQL = MySQL & "," & TestAF & "," & TestCoil & "," & TestCtrl & "," & TestMotor & "," & TestElec & "," & TestGas & "," & TestGTrain & "," & TestHydro & "," & TestRefer & "," & TestRefInst
        MySQL = MySQL & "," & S5 & "," & S10 & "," & S20 & "," & S40 & "," & S100 & "," & S100A & "," & S100B & "," & S100C & "," & SXTI & "," & SXTO & "," & SChoice & "," & SPremier & "," & SYVAA & "," & SYCAL & "," & SYLAA & "," & SLX & "," & SBlank & "," & S20ODSplt & "," & S20IDSplit & "," & S40ODSplit & "," & SYCUL & "," & SYLUA & "," & SDOAS & "," & SSeriesL & ")"

        con.Execute(MySQL)

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

    Private Sub cmdConstDetails_Click(sender As Object, e As EventArgs) Handles cmdConstDetails.Click

    End Sub
End Class