Public Class frmLowAmbient
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance
        'none presently for this modification - MCA/MOP in the future.

        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("LowAmbient") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Me.Hide()

    End Sub
    Private Function XFmrPrimaryAmps(volts) As Double
        Dim temp As Double

        If optXFrmrDot5.Checked Then temp = 500 / volts
        If optXFrmrdot75.Checked Then temp = 750 / volts
        If optXFrmr1.Checked Then temp = 1000 / volts
        If optXFrmr1dot5.Checked Then temp = 1500 / volts
        If optXFrmr2.Checked Then temp = 2000 / volts
        If optXFrmr3.Checked Then temp = 3000 / volts
        If optXFrmr5.Checked Then temp = 5000 / volts
        If optXFrmr7dot5.Checked Then temp = 7500 / volts

        XFmrPrimaryAmps = temp
    End Function
    Private Sub UpdatePerformance()
        Dim temp As String
        Dim dummy As MsgBoxResult
        Dim LowAmbientSize As String

        Dim PrimaryAmps As Double
        Dim ElecChar As String
        Dim NewRow As String()

        temp = "0.0"
        PrimaryAmps = 999.0

        If optneg10Ambient.Checked = True Then temp = "-10.0"
        If optneg20Ambient.Checked = True Then temp = "-20.0"
        If optneg30Ambient.Checked = True Then temp = "-30.0"
        frmMain.ThisChillerMainPerf.MinAmbient = temp

        'handle the mca addition

        If chkSinglePointPower.Checked = True Then

            If frmMain.UseCustomMCA = False Then
                frmMain.UseCustomMCA = True
                Call frmMain.PreLoadElec()
            End If


            ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
            If optXFrmrNA.Checked = False Then
                PrimaryAmps = XFmrPrimaryAmps(lstLineVoltage.SelectedItem)
            End If


            NewRow = {True, False, "All", True, "Low Ambient Xfrmr", ElecChar, "-", Format(PrimaryAmps, "0.0"), False, "Math"}
            frmMain.dgvElecLoads.Rows.Add(NewRow)

            If optXFrmrNA.Checked = False Then

                If optXFrmrDot5.Checked Then LowAmbientSize = "(0.5kVA)"
                If optXFrmrdot75.Checked Then LowAmbientSize = "(0.75kVA)"
                If optXFrmr1dot5.Checked Then LowAmbientSize = "(1.5kVA)"
                If optXFrmr2.Checked Then LowAmbientSize = "(2kVA)"
                If optXFrmr3.Checked Then LowAmbientSize = "(3kVA)"
                If optXFrmr5.Checked Then LowAmbientSize = "(5kVA)"
                If optXFrmr7dot5.Checked Then LowAmbientSize = "(7.5kVA)"

                If frmMain.ThisUnitElecData.FisenLoad01 = " " Then
                    frmMain.ThisUnitElecData.FisenLoad01 = "Low Ambient Power " & LowAmbientSize
                    frmMain.ThisUnitElecData.FisenLoadFLA01 = Format(Val(PrimaryAmps), "0.0")
                Else
                    dummy = MsgBox("Fisen Load 01 already assigned.", vbOKOnly)
                End If
            End If
        End If
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("890100")
        If frmMain.ThisUnit.Kingdom = "Chiller" Then
            If optneg10Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890101")
            End If

            If optneg20Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890102")
            End If

            If optneg30Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890103")
            End If
        End If

        If frmMain.ThisUnit.Kingdom = "Misc" Then
            If optneg10Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890105")
            End If

            If optneg20Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890106")
            End If

            If optneg30Ambient.Checked Then
                frmMain.ThisUnitCodes.Add("890107")
            End If
        End If

        frmMain.ThisUnitCodes.Add("890110")
        frmMain.ThisUnitCodes.Add("890120")
        frmMain.ThisUnitCodes.Add("890130")
        frmMain.ThisUnitCodes.Add("890140")
        If Not (chkSinglePointPower.Checked) Then
            frmMain.ThisUnitCodes.Add("890141")
        Else
            If (Val(lstLineVoltage.Text) > 230) Then
                frmMain.ThisUnitCodes.Add("890143")
                If optXFrmrDot5.Checked Then frmMain.ThisUnitCodes.Add("890201")
                If optXFrmrdot75.Checked Then frmMain.ThisUnitCodes.Add("890202")
                If optXFrmr1.Checked Then frmMain.ThisUnitCodes.Add("890203")
                If optXFrmr1dot5.Checked Then frmMain.ThisUnitCodes.Add("890204")
                If optXFrmr2.Checked Then frmMain.ThisUnitCodes.Add("890205")
                If optXFrmr3.Checked Then frmMain.ThisUnitCodes.Add("890206")
                If optXFrmr5.Checked Then frmMain.ThisUnitCodes.Add("890207")
                If optXFrmr7dot5.Checked Then frmMain.ThisUnitCodes.Add("890208")
            Else
                frmMain.ThisUnitCodes.Add("890142")
            End If
        End If
        frmMain.ThisUnitCodes.Add("890150")
        If chkBaseRailEnclosure.Checked Then
            frmMain.ThisUnitCodes.Add("890152")
        Else
            frmMain.ThisUnitCodes.Add("890151")
        End If
        If chkYCAVTopBlockoff.Checked Then
            frmMain.ThisUnitCodes.Add("890155")
            frmMain.ThisUnitCodes.Add("890156")
            If chkYCAVEmptyFanBlockoff.Checked Then
                frmMain.ThisUnitCodes.Add("890157")
            End If
        End If
        If chkRemoteEvap.Checked Then
            frmMain.ThisUnitCodes.Add("890180")
            If chkFieldHTbyFisen.Checked Then
                If nudFtOfHT.Value = "25" Then frmMain.ThisUnitCodes.Add("890221")
                If nudFtOfHT.Value = "50" Then frmMain.ThisUnitCodes.Add("890222")
                If nudFtOfHT.Value = "75" Then frmMain.ThisUnitCodes.Add("890223")
                If nudFtOfHT.Value = "100" Then frmMain.ThisUnitCodes.Add("890224")
                If nudFtOfHT.Value = "125" Then frmMain.ThisUnitCodes.Add("890225")
                If nudFtOfHT.Value = "150" Then frmMain.ThisUnitCodes.Add("890226")
                If nudFtOfHT.Value = "175" Then frmMain.ThisUnitCodes.Add("890227")
                If nudFtOfHT.Value = "200" Then frmMain.ThisUnitCodes.Add("890228")
            Else
                If nudFtOfHT.Value = "25" Then frmMain.ThisUnitCodes.Add("890181")
                If nudFtOfHT.Value = "50" Then frmMain.ThisUnitCodes.Add("890182")
                If nudFtOfHT.Value = "75" Then frmMain.ThisUnitCodes.Add("890183")
                If nudFtOfHT.Value = "100" Then frmMain.ThisUnitCodes.Add("890184")
                If nudFtOfHT.Value = "125" Then frmMain.ThisUnitCodes.Add("890185")
                If nudFtOfHT.Value = "150" Then frmMain.ThisUnitCodes.Add("890186")
                If nudFtOfHT.Value = "175" Then frmMain.ThisUnitCodes.Add("890187")
                If nudFtOfHT.Value = "200" Then frmMain.ThisUnitCodes.Add("890188")
            End If

        End If
        If frmMain.ThisUnit.Family = "YVAA" Then frmMain.ThisUnitCodes.Add("890170") 'Adds a hidden code to configure the sequence for YVAA.

    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.EHeatTest = True
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim traceweight As Double
        Dim baserailmass As Double
        Dim singlepointmass As Double

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("LowAmbient")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Low Ambient Start Package")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        If chkBaseRailEnclosure.Checked Then
            baserailmass = 340
        Else
            baserailmass = 0
        End If
        If chkSinglePointPower.Checked Then
            If Val(lstLineVoltage.Text) > 230 Then
                singlepointmass = 65
            Else
                singlepointmass = 15
            End If
        End If
        traceweight = Val(txtFtofHeatTrace.Text) / 16
        tempWeight = Str(traceweight + singlepointmass + baserailmass + 54)
        tempWeight = Format(Val(tempWeight), "0")
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        lblAdditionalHT.Text = "+" & Trim(Str(nudFtOfHT.Value)) & " ft Additional"
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim feetneeded As Double
        Dim slug As String
        Dim varqd As Double

        If ((chkSinglePointPower.Checked) And ((lstLineVoltage.Text = "460") Or (lstLineVoltage.Text = "575"))) Then
            Select Case frmMain.ThisUnit.Family
                Case Is = "YCAL"
                    slug = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)
                    feetneeded = YCALHTReqd(slug)
                Case Is = "YVAA"
                    slug = Mid(frmMain.ThisUnit.ModelNumber, 5, 3)
                    feetneeded = YVAAHTReqd(slug)
                Case Is = "YLAA"
                    slug = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)
                    feetneeded = YLAAHTReqd(slug)
                Case Is = "Series40ODSplit"
                    slug = Mid(frmMain.ThisUnit.ModelNumber, 1, 3)
                    feetneeded = S40ODSplitHTReqd(slug)
                Case Is = "Series20ODSplit"
                    slug = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
                    feetneeded = S20ODSplitHTReqd(slug)
                Case Else
                    feetneeded = 9999
            End Select
            feetneeded = feetneeded + nudFtOfHT.Value
            varqd = (feetneeded * 8)
            If ((varqd < (7500 * 0.8))) Then optXFrmr7dot5.Checked = True
            If ((varqd < (5000 * 0.8))) Then optXFrmr5.Checked = True
            If ((varqd < (3000 * 0.8))) Then optXFrmr3.Checked = True
            If ((varqd < (2000 * 0.8))) Then optXFrmr2.Checked = True
            If ((varqd < (1500 * 0.8))) Then optXFrmr1dot5.Checked = True
            If ((varqd < (1000 * 0.8))) Then optXFrmr1.Checked = True
            If ((varqd < (750 * 0.8))) Then optXFrmrdot75.Checked = True
            If varqd < (500 * 0.8) Then optXFrmrDot5.Checked = True
        End If

        Call CalculateTransformer()

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub frmLowAmbient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ChilSize As String

        ChilSize = "0000"

        Select Case frmMain.ThisUnit.Family
            Case Is = "YCAL"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)

            Case Is = "YLAA"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)
            Case Is = "YVAA"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 3)
            Case Is = "YCIV"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)
            Case Is = "YCAV"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 4)
            Case Is = "YVFA"
                ChilSize = Mid(frmMain.ThisUnit.ModelNumber, 5, 3)

        End Select
        txtFtofHeatTrace.Text = FeetTraceNeeded(frmMain.ThisUnit.Family, ChilSize)


        If frmMain.ThisUnit.Family = "YCAV" Then chkYCAVTopBlockoff.Checked = True
        If frmMain.ThisUnit.Family <> "YCAV" Then
            chkYCAVTopBlockoff.Checked = False
            chkYCAVTopBlockoff.Enabled = False
        End If

        cmbHTVolts.Text = "240"
        cmbWattsPerFoot.Text = "8"
    End Sub

    Private Function FeetTraceNeeded(ChillFam As String, ChillSize As String) As String
        Dim tempfeet As String
        Dim dummy As MsgBoxResult

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


        MySQL = "SELECT * FROM tblLowAmbientHT WHERE ModelStub='" & ChillFam & ChillSize & "'"

        tempfeet = "-9999"

        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            tempfeet = rs.Fields("HT_Feet").Value
            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

        If tempfeet = "-9999" Then dummy = MsgBox("Invalid Chiller Size in Feet Assignment.", vbOKOnly)

        FeetTraceNeeded = tempfeet
    End Function

    Private Sub chkSinglePointPower_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinglePointPower.CheckedChanged
        If chkSinglePointPower.Checked = True Then
            lblLineVolts.Enabled = True
            lstLineVoltage.Enabled = True

            lstLineVoltage.Text = frmMain.ThisUnitElecData.CommVolts
        Else
            lblLineVolts.Enabled = False
            lstLineVoltage.Enabled = False

        End If
    End Sub

    Private Sub chkRemoteEvap_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoteEvap.CheckedChanged
        If chkRemoteEvap.Checked Then
            nudFtOfHT.Enabled = True
            lblFtOfHT.Enabled = True
            chkFieldHTbyFisen.Enabled = True
            chkFieldHTbyFisen.Checked = True
        Else
            nudFtOfHT.Enabled = False
            nudFtOfHT.Value = 0
            lblFtOfHT.Enabled = False
            chkFieldHTbyFisen.Enabled = False
            chkFieldHTbyFisen.Checked = False
        End If
    End Sub

    Private Function S40ODSplitHTReqd(unitsize As String) As Double
        Dim ftofht As Double

        Select Case unitsize
            Case Is = "J30"
                ftofht = 150
            Case Is = "J40"
                ftofht = 150
            Case Is = "J50"
                ftofht = 150
            Case Else
                ftofht = 9999
        End Select
        S40ODSplitHTReqd = ftofht
    End Function

    Private Function S20ODSplitHTReqd(unitsize As String) As Double
        Dim ftofht As Double

        Select Case unitsize
            Case Is = "J07PC"
                ftofht = 50
            Case Is = "J10PC"
                ftofht = 50
            Case Is = "J07YC"
                ftofht = 50
            Case Is = "J10YC"
                ftofht = 50
            Case Is = "J10YD"
                ftofht = 100
            Case Is = "J12YC"
                ftofht = 50
            Case Is = "J12YD"
                ftofht = 100
            Case Is = "J15PC"
                ftofht = 75
            Case Is = "J15PD"
                ftofht = 150
            Case Is = "J20PC"
                ftofht = 75
            Case Is = "J20PD"
                ftofht = 150
            Case Is = "J15YC"
                ftofht = 75
            Case Is = "J15YC"
                ftofht = 150
            Case Is = "J20YC"
                ftofht = 75
            Case Is = "J20YD"
                ftofht = 150
            Case Is = "J25YC"
                ftofht = 100
            Case Else
                ftofht = 9999
        End Select
        S20ODSplitHTReqd = ftofht
    End Function

    Private Function YCALHTReqd(unitsize As String) As Double
        Dim ftofht As Double

        Select Case unitsize
            Case Is = "0019"
                ftofht = 150
            Case Is = "0022"
                ftofht = 150
            Case Is = "0028"
                ftofht = 150
            Case Is = "0033"
                ftofht = 150
            Case Is = "0043"
                ftofht = 160
            Case Is = "0046"
                ftofht = 170
            Case Is = "0052"
                ftofht = 175
            Case Is = "0056"
                ftofht = 195
            Case Is = "0066"
                ftofht = 200
            Case Else
                ftofht = 9999
        End Select
        YCALHTReqd = ftofht
    End Function

    Private Function YLAAHTReqd(unitsize As String) As Double
        Dim ftofht As Double

        Select Case unitsize
            Case Is = "0065"
                ftofht = 175
            Case Is = "0070"
                ftofht = 210
            Case Is = "0080"
                ftofht = 190
            Case Is = "0089"
                ftofht = 215
            Case Is = "0092"
                ftofht = 225
            Case Is = "0100"
                ftofht = 250
            Case Is = "0101"
                ftofht = 255
            Case Is = "0115"
                ftofht = 255
            Case Is = "0120"
                ftofht = 280
            Case Is = "0125"
                ftofht = 240
            Case Is = "0136"
                ftofht = 250
            Case Is = "0142"
                ftofht = 270
            Case Is = "0155"
                ftofht = 250
            Case Is = "0156"
                ftofht = 250
            Case Is = "0170"
                ftofht = 250
            Case Is = "0175"
                ftofht = 275
            Case Is = "0200"
                ftofht = 300
            Case Else
                ftofht = 9999
        End Select
        YLAAHTReqd = ftofht
    End Function

    Private Function YVAAHTReqd(unitsize As String) As Double
        Dim ftofht As Double

        Select Case unitsize
            Case Is = "015"
                ftofht = 175
            Case Is = "016"
                ftofht = 210
            Case Is = "017"
                ftofht = 190
            Case Is = "018"
                ftofht = 215
            Case Is = "019"
                ftofht = 225
            Case Is = "020"
                ftofht = 250
            Case Is = "021"
                ftofht = 255
            Case Is = "023"
                ftofht = 255
            Case Is = "024"
                ftofht = 280
            Case Is = "026"
                ftofht = 240
            Case Is = "027"
                ftofht = 250
            Case Is = "029"
                ftofht = 270
            Case Is = "030"
                ftofht = 250
            Case Is = "031"
                ftofht = 250
            Case Is = "032"
                ftofht = 250
            Case Is = "033"
                ftofht = 275
            Case Is = "034"
                ftofht = 300
            Case Is = "037"
                ftofht = 300
            Case Is = "041"
                ftofht = 300
            Case Is = "044"
                ftofht = 300
            Case Is = "048"
                ftofht = 300
            Case Is = "050"
                ftofht = 300
            Case Is = "052"
                ftofht = 300
            Case Else
                ftofht = 9999
        End Select
        YVAAHTReqd = ftofht
    End Function

    Private Sub CalculateTransformer()
        Dim Watts As Double
        Dim volts As Double
        Dim cap As Double

        volts = Val(cmbHTVolts.Text)

        Select Case cmbWattsPerFoot.Text
            Case Is = "8"
                cap = 0.076
            Case Is = "5"
                cap = 0.05
            Case Is = "3"
                cap = 0.03
        End Select

        Watts = volts * cap * (Val(txtFtofHeatTrace.Text) + nudFtOfHT.Value)
        Select Case Watts
            Case 0 To 400
                optXFrmrDot5.Checked = True
            Case 400.01 To 600
                optXFrmrdot75.Checked = True
            Case 600.01 To 800
                optXFrmr1.Checked = True
            Case 800.01 To 1200
                optXFrmr1dot5.Checked = True
            Case 1200.01 To 1800
                optXFrmr2.Checked = True
            Case 1800.01 To 2650
                optXFrmr3.Checked = True
            Case 2650.01 To 4500
                optXFrmr5.Checked = True
            Case 4500.01 To 7000
                optXFrmr7dot5.Checked = True
        End Select

        lblWatts.Text = Format(Watts, "0.0") & "Watts"
    End Sub
    Private Sub cmdSelectXFmr_Click(sender As Object, e As EventArgs) Handles cmdSelectXFmr.Click
        Call CalculateTransformer()
    End Sub

    Private Sub nudFtOfHT_Leave(sender As Object, e As EventArgs) Handles nudFtOfHT.Leave
        Dim length As Double
        Dim div1 As Double
        Dim div2 As Double
        length = nudFtOfHT.Value
        div1 = length \ 25
        div2 = length / 25
        If div1 <> div2 Then
            nudFtOfHT.Value = Trim(Str(25 * (div1 + 1)))
        End If
    End Sub
End Class