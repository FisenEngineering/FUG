Imports System.ComponentModel
Public Class frmLowAF
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
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("LowAF") 'Mod Code goes here!
        Call UpdateCodeList()
        Call WriteLowAFHistory

        Me.Hide()
    End Sub
    Private Sub WriteLowAFHistory()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver As String
        Dim modnum, rqAF, RQStatic, Soln, NomAir, MinCatAir, BypassAir As String
        Dim i As Integer


        Dim MySQL As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text

        modnum = frmMain.txtModelNumber.Text
        rqAF = txtAirflow.Text
        RQStatic = txtESP.Text
        NomAir = txtNominalAirflow.Text
        MinCatAir = txtMinCatAirflow.Text
        BypassAir = txtBypassAF.Text

        If optExistingSheaves.Checked Then Soln = "Adjust Sheaves"
        If optResheave.Checked Then Soln = "Resheave"
        If optFanWallBypassExisting.Checked Then Soln = "FWBypass"
        If optFanWallBypassNew.Checked Then Soln = "FWBypass-Resheave"
        If optReplaceFan.Checked Then Soln = "Replace Fan"

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "INSERT INTO tblHistoryLowAF (JobName, UnitID, Version, ModelNumber, RQAirflow, RQStatic, Solution, NominalAir, MinCatAir, BypassAir) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & rqAF & "','" & RQStatic & "','" & Soln & "','" & NomAir & "','" & MinCatAir & "','" & BypassAir & "')"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("398800")
        If optExistingSheaves.Checked Then
            frmMain.ThisUnitCodes.Add("398805")
        End If
        If optResheave.Checked Then
            frmMain.ThisUnitCodes.Add("398810")
        End If
        If optFanWallBypassExisting.Checked Then
            frmMain.ThisUnitCodes.Add("398815")
        End If
        If optFanWallBypassNew.Checked Then
            frmMain.ThisUnitCodes.Add("398820")
        End If
        If optReplaceFan.Checked Then
            frmMain.ThisUnitCodes.Add("398825")
        End If

        'controls

        frmMain.ThisUnitCodes.Add("398835")
        If optSE.Checked Then
            If chkAntiFrostProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398840")
            End If
            If chkElecHeatProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398850")
            End If
            If chkGasHeatProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398845")
            End If
        Else
            If chkAntiFrostProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398855")
            End If
            If chkElecHeatProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398865")
            End If
            If chkGasHeatProtection.Checked Then
                frmMain.ThisUnitCodes.Add("398860")
            End If
        End If
        If chkSeriesConversion.Checked Then
            frmMain.ThisUnitCodes.Add("398830")
            If optRefDwg1Ckt.Checked = True Then
                frmMain.lstUsingRefer.Items.Add("Series Conversion 1 Circuit ZR")
            End If
            If optRefDwg2Ckt.Checked = True Then
                frmMain.lstUsingRefer.Items.Add("Series Conversion 2 Circuit ZR")
            End If
        End If
        'use logic to step through the controls to determine the codes and use the above format...

    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.AirflowTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("LowAF")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Reduced Air Flow")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "5" '10 for the new controls 5 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "15" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "20" '10+5+5
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Is = "Series10"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "5" '10 for the new controls 5 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "15" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "20" '10+5+5
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Is = "Series20"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "8" '10 for the new controls 5 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "15" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "23" '10+5+8
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Is = "Series40"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "10" '10 for the new controls 10 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "15" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "25" '10+10+5
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Is = "Series100"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "30" '10 for the new controls 10 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "45" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "45" '10+10+5
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text
        frmMain.ThisUnitSFanPerf.Airflow = txtAirflow.Text
        frmMain.ThisUnitSFanPerf.ESP = txtESP.Text

        frmMain.ThisUnitSpecialPerf.OA100MinCatAF = txtMinCatAirflow.Text
        frmMain.ThisUnitSpecialPerf.OA100NominalAF = txtNominalAirflow.Text

        frmMain.ThisUnitHeatPerf.Airflow = txtAirflow.Text

        frmMain.ThisUnitCoolPerf.EnteringDB = txtEDB.Text
        frmMain.ThisUnitCoolPerf.EnteringWB = txtEWB.Text
        frmMain.ThisUnitCoolPerf.TotalCapacity = txtTCap.Text
        frmMain.ThisUnitCoolPerf.SensibleCapacity = txtSCap.Text
        frmMain.ThisUnitCoolPerf.Power = txtPower.Text
        frmMain.ThisUnitCoolPerf.LeavingDB = txtLADB.Text
        If Val(txtLADB.Text) < 48 Then
            If frmMain.ThisUnit.Kingdom = "RTU" And frmMain.ThisUnit.Family <> "Series100" Then
                frmMain.ThisUnit.Notes = "LAT is theoretical.  SE Controller my inhibit operation at temperatures this low."
            End If

            If frmMain.ThisUnit.Kingdom = "RTU" And frmMain.ThisUnit.Family = "Series100" Then
                frmMain.ThisUnit.Notes = "LAT is theoretical.  IPU Controller my inhibit operation at temperatures this low."
            End If
        End If
            frmMain.ThisUnitCoolPerf.LeavingWB = txtLAWB.Text
        frmMain.ThisUnitCoolPerf.LeavingDBUnit = txtUnitLATdb.Text
        frmMain.ThisUnitCoolPerf.LeavingDBUnit = txtUnitLATwb.Text

        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtHeatEAT.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtHeatingLAT.Text
        frmMain.ThisUnitCoolPerf.FaceVelocity = txtFaceVelocity.Text
        frmMain.ThisUnitRHPerf.DHCapacity = txtDehumCap.Text

    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer
        Dim sqft As Double

        pCancelled = False

        txtFanBHP.Text = frmMain.ThisUnitSFanPerf.BrakeHP
        txtFanRPM.Text = frmMain.ThisUnitSFanPerf.RPM

        txtESP.Text = frmMain.ThisUnitSFanPerf.ESP
        txtAmbient.Text = frmMain.ThisUnitCoolPerf.AmbientDB
        txtEDB.Text = frmMain.ThisUnitCoolPerf.EnteringDB
        txtEWB.Text = frmMain.ThisUnitCoolPerf.EnteringWB
        txtHeatEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp

        If frmMain.ThisUnit.Family = "Series100" Then
            sqft = frmMain.ThisUnitSFanPerf.Airflow / frmMain.ThisUnitCoolPerf.FaceVelocity
            lblsqftevap.Text = Format(sqft, "0.0")
            lblsqftevap.Visible = True
        End If


        For i = 0 To frmMain.lstSelectedMods.Items.Count - 1
            If frmMain.lstSelectedMods.Items(i) = "100% Outdoor Air" Then
                chk100OA.Checked = True
            End If

            If frmMain.lstSelectedMods.Items(i) = "Modulating Hot Gas Reheat Conversion" Then
                chkSeriesConversion.Visible = False
                chkSeriesConversion.Checked = False
            End If
        Next

        If frmMain.ThisUnit.Family = "Series100" Then optIPU.Checked = True

        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then chkGasHeatProtection.Checked = True
        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then chkElecHeatProtection.Checked = True


    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult
        Dim tempaf As String
        Dim delta_h As Double

        If ((txtAmbient.Text) <> (txtEDB.Text) And (chk100OA.Checked = True)) Then
            dummy = MsgBox("Entering Air DB should equal Ambient DB.  Proceed Anyway?", vbYesNo)
            If dummy = vbNo Then Exit Sub
        End If
        If frmMain.ThisUnit.Family <> "Series100" Then
            txtNominalAirflow.Text = Trim(Str(400 * Val(frmMain.ThisUnit.NominalTons)))
            txtMinCatAirflow.Text = MinCatalogedAirFlow()
            txtMinCatHeatAF.Text = MinCatalogedHeatAF

            lblInitialEnthalpy.Text = Format(psyEnthalpy_db_wb(Val(txtEDB.Text), Val(txtEWB.Text), psyAtmosphericPressure(0)), "0.0")


            lblHiAmb.Text = GetUPGUpperAmbient(Val(txtAmbient.Text))
            lblLowAmb.Text = GetUPGLowerAmbient(Val(txtAmbient.Text))

            tempaf = GetUPGUpperAirflow(Val(txtAirflow.Text))

            lblHighAFLowTemp.Text = tempaf
            lblHighAFHiTemp.Text = tempaf
            lblHighAFMyTemp.Text = tempaf

            tempaf = GetUPGLowerAirflow(Val(txtAirflow.Text))

            lblLowAFLowTemp.Text = tempaf
            lblLowAFHiTemp.Text = tempaf
            lblLowAFMyTemp.Text = tempaf
            Call SetTheWBHeader()
            Call CompleteDataTable()


            delta_h = Val(lblMBH3MyAmbMyAF.Text) * 1000 / 4.5 / Val(txtAirflow.Text)
            lblFinalEnthalpy.Text = Format(Val(lblInitialEnthalpy.Text) - delta_h, "0.0")
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub
    Private Sub SetTheWBHeader()
        Dim MyWB As Double
        Dim wb1 As Double
        Dim wb2 As Double

        MyWB = Val(txtEWB.Text)
        If MyWB <= 67 Then
            wb1 = 67
            wb2 = 62
        End If

        If ((MyWB <= 72) And (MyWB > 67)) Then
            wb1 = 72
            wb2 = 67
        End If

        If (MyWB > 72) Then
            wb1 = 77
            wb2 = 72
        End If

        lblWB1.Text = Format(wb1, "0.0")
        lblWB2.Text = Format(wb2, "0.0")
        lblMyWB.Text = Format(MyWB, "0.0")

    End Sub
    Private Function SlopeIntercept(x1 As Double, y1 As Double, x2 As Double, y2 As Double, newx As Double) As Double
        Dim m As Double
        Dim b As Double
        m = (y2 - y1) / (x2 - x1)
        b = y1 - m * x1
        SlopeIntercept = m * newx + b
    End Function
    Private Sub CompleteDataTable()

        Dim WB1Name As String
        Dim WB2Name As String

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        WB1Name = "XX"
        WB2Name = "XX"
        If lblWB1.Text = "77.0" Then WB1Name = "WB77"
        If lblWB1.Text = "72.0" Then WB1Name = "WB72"
        If lblWB1.Text = "67.0" Then WB1Name = "WB67"
        If lblWB2.Text = "72.0" Then WB2Name = "WB72"
        If lblWB2.Text = "67.0" Then WB2Name = "WB67"
        If lblWB2.Text = "62.0" Then WB2Name = "WB62"

        lblMyAmb.Text = txtAmbient.Text
        lblMyAF.Text = txtAirflow.Text


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        Dim Snip As String
        Snip = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        If Mid(Snip, 1, 1) = "V" Then
            Snip = Mid(Snip, 1, 2) & "XXX"
        End If
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & snip & "' AND Ambient=" & Val(lblHiAmb.Text) & " ORDER BY CatAirflow"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblMBH1HiAmbLoAF.Text = rs.Fields(WB1Name & "TCap").Value
        lblkW1HiAmbLoAF.Text = rs.Fields(WB1Name & "kW").Value
        lblMBH2HiAmbLoAF.Text = rs.Fields(WB2Name & "TCap").Value
        lblkW2HiAmbLoAF.Text = rs.Fields(WB2Name & "kW").Value

        rs.MoveNext()
        lblMBH1HiAmbHiAF.Text = rs.Fields(WB1Name & "TCap").Value
        lblkW1HiAmbHiAF.Text = rs.Fields(WB1Name & "kW").Value
        lblMBH2HiAmbHiAF.Text = rs.Fields(WB2Name & "TCap").Value
        lblkW2HiAmbHiAF.Text = rs.Fields(WB2Name & "kW").Value
        rs.Close()

        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' AND Ambient=" & Val(lblLowAmb.Text) & " ORDER BY CatAirflow"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblMBH1LoAmbLoAF.Text = rs.Fields(WB1Name & "TCap").Value
        lblkW1LoAmbLoAF.Text = rs.Fields(WB1Name & "kW").Value
        lblMBH2LoAmbLoAF.Text = rs.Fields(WB2Name & "TCap").Value
        lblkW2LoAmbLoAF.Text = rs.Fields(WB2Name & "kW").Value

        rs.MoveNext()
        lblMBH1LoAmbHiAF.Text = rs.Fields(WB1Name & "TCap").Value
        lblkW1LoAmbHiAF.Text = rs.Fields(WB1Name & "kW").Value
        lblMBH2LoAmbHiAF.Text = rs.Fields(WB2Name & "TCap").Value
        lblkW2LoAmbHiAF.Text = rs.Fields(WB2Name & "kW").Value

        con.Close()
        rs = Nothing
        con = Nothing

        lblMBH1MyAmbLoAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblMBH1LoAmbLoAF.Text, lblHiAmb.Text, lblMBH1HiAmbLoAF.Text, lblMyAmb.Text), "0.0")
        lblMBH1MyAmbHiAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblMBH1LoAmbHiAF.Text, lblHiAmb.Text, lblMBH1HiAmbHiAF.Text, lblMyAmb.Text), "0.0")
        lblkW1MyAmbLoAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblkW1LoAmbLoAF.Text, lblHiAmb.Text, lblkW1HiAmbLoAF.Text, lblMyAmb.Text), "0.0")
        lblkW1MyAmbHiAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblkW1LoAmbHiAF.Text, lblHiAmb.Text, lblkW1HiAmbHiAF.Text, lblMyAmb.Text), "0.0")
        lblMBH2MyAmbLoAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblMBH2LoAmbLoAF.Text, lblHiAmb.Text, lblMBH2LoAmbHiAF.Text, lblMyAmb.Text), "0.0")
        lblMBH2MyAmbHiAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblMBH2LoAmbHiAF.Text, lblHiAmb.Text, lblMBH2HiAmbHiAF.Text, lblMyAmb.Text), "0.0")
        lblkW2MyAmbLoAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblkW2LoAmbLoAF.Text, lblHiAmb.Text, lblkW2HiAmbLoAF.Text, lblMyAmb.Text), "0.0")
        lblkW2MyAmbHiAF.Text = Format(SlopeIntercept(lblLowAmb.Text, lblkW2LoAmbHiAF.Text, lblHiAmb.Text, lblkW2HiAmbHiAF.Text, lblMyAmb.Text), "0.0")

        lblMBH1MyAmbMyAF.Text = Format(SlopeIntercept(lblLowAFMyTemp.Text, lblMBH1MyAmbLoAF.Text, lblHighAFMyTemp.Text, lblMBH1MyAmbHiAF.Text, lblMyAF.Text), "0.0")
        lblkW1MyAmbMyAF.Text = Format(SlopeIntercept(lblLowAFMyTemp.Text, lblkW1MyAmbLoAF.Text, lblHighAFMyTemp.Text, lblkW1MyAmbHiAF.Text, lblMyAF.Text), "0.0")
        lblMBH2MyAmbMyAF.Text = Format(SlopeIntercept(lblLowAFMyTemp.Text, lblMBH2MyAmbLoAF.Text, lblHighAFMyTemp.Text, lblMBH2MyAmbHiAF.Text, lblMyAF.Text), "0.0")
        lblkW2MyAmbMyAF.Text = Format(SlopeIntercept(lblLowAFMyTemp.Text, lblkW2MyAmbLoAF.Text, lblHighAFMyTemp.Text, lblkW2MyAmbHiAF.Text, lblMyAF.Text), "0.0")


        lblMBH3MyAmbMyAF.Text = Format(SlopeIntercept(lblWB1.Text, lblMBH1MyAmbMyAF.Text, lblWB2.Text, lblMBH2MyAmbMyAF.Text, lblMyWB.Text), "0.0")
        lblkW3MyAmbMyAF.Text = Format(SlopeIntercept(lblWB1.Text, lblkW1MyAmbMyAF.Text, lblWB2.Text, lblkW2MyAmbMyAF.Text, lblMyWB.Text), "0.0")

    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim heatlat As Double
        Dim aflow As Double
        Dim btuout As Double
        Dim sqft As Double

        btuout = Val(frmMain.ThisUnitHeatPerf.OutputCapacity) * 1000
        aflow = Val(txtAirflow.Text)
        heatlat = btuout / (aflow * 1.085) + Val(txtHeatEAT.Text)
        txtHeatingLAT.Text = Format(heatlat, "0.0")
        txtTCap.Text = Format(Val(lblMBH3MyAmbMyAF.Text), "0.0")
        txtPower.Text = Format(Val(lblkW3MyAmbMyAF.Text), "0.0")
        txtFinalEnth.Text = lblFinalEnthalpy.Text

        If frmMain.ThisUnit.Family = "Series100" Then
            sqft = lblsqftevap.Text
            txtFaceVelocity.Text = Format(Val(txtAirflow.Text) / sqft, "0.0")
        Else
            txtFaceVelocity.Text = "-"
        End If
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Hide()
    End Sub

    Private Function MinCatalogedHeatAF() As String
        Dim tempflow As String
        Dim lowflow As Double
        lowflow = 0
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "3.0"
                        lowflow = 800
                    Case Is = "4.0"
                        lowflow = 1000
                    Case Is = "5.0"
                        lowflow = 1200
                    Case Is = "6.0"
                        lowflow = 1600
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series10"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "3.0"
                        lowflow = 900
                    Case Is = "4.0"
                        lowflow = 1200
                    Case Is = "5.0"
                        lowflow = 1500
                    Case Is = "6.5"
                        lowflow = 1800
                    Case Is = "7.5"
                        lowflow = 2000
                    Case Is = "8.5"
                        lowflow = 2200
                    Case Is = "10.0"
                        lowflow = 2600
                    Case Is = "12.5"
                        lowflow = 3200
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series20"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "15.0"
                        lowflow = 4000
                    Case Is = "17.5"
                        lowflow = 4400
                    Case Is = "20.0"
                        lowflow = 5200
                    Case Is = "25.0"
                        lowflow = 6600
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series40"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "25.0"
                        lowflow = 7500
                    Case Is = "30.0"
                        lowflow = 7500
                    Case Is = "40.0"
                        lowflow = 10000
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series100"


                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "50.0"
                        lowflow = 12000
                    Case Is = "55.0"
                        lowflow = 12000
                    Case Is = "60.0"
                        lowflow = 12000
                    Case Is = "65.0"
                        lowflow = 12000
                    Case Is = "70.0"
                        lowflow = 14000
                    Case Is = "75.0"
                        lowflow = 15500
                    Case Is = "80.0"
                        lowflow = 15000
                    Case Is = "90.0"
                        lowflow = 17500
                    Case Is = "105.0"
                        lowflow = 21000
                    Case Is = "120.0"
                        lowflow = -9999
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            lowflow = 19350
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            lowflow = 15000
                        End If
                    Case Is = "130.0"
                        lowflow = -9999
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            lowflow = 19350
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            lowflow = 15000
                        End If
                    Case Is = "150.0"
                        lowflow = -9999
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            lowflow = 19350
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            lowflow = 15000
                        End If
                    Case Else
                        lowflow = -9999
                End Select
            Case Else
                lowflow = -9999
        End Select

        tempflow = Val(lowflow)
        MinCatalogedHeatAF = tempflow
    End Function
    Private Function MinCatalogedAirFlow() As String
        Dim tempflow As String
        Dim lowflow As Double
        lowflow = 0
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "3.0"
                        lowflow = 800
                    Case Is = "4.0"
                        lowflow = 1000
                    Case Is = "5.0"
                        lowflow = 1200
                    Case Is = "6.0"
                        lowflow = 1600
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series10"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "3.0"
                        lowflow = 900
                    Case Is = "4.0"
                        lowflow = 1200
                    Case Is = "5.0"
                        lowflow = 1500
                    Case Is = "6.5"
                        lowflow = 1800
                    Case Is = "7.5"
                        lowflow = 2000
                    Case Is = "8.5"
                        lowflow = 2200
                    Case Is = "10.0"
                        lowflow = 2600
                    Case Is = "12.5"
                        lowflow = 3200
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series20"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "15.0"
                        lowflow = 4000
                    Case Is = "17.5"
                        lowflow = 4400
                    Case Is = "20.0"
                        lowflow = 5200
                    Case Is = "25.0"
                        lowflow = 6600
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series40"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "25.0"
                        lowflow = 7500
                    Case Is = "30.0"
                        lowflow = 7500
                    Case Is = "40.0"
                        lowflow = 10000
                    Case Else
                        lowflow = -9999
                End Select
            Case Is = "Series100"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "50.0"
                        lowflow = 12000
                    Case Is = "55.0"
                        lowflow = 12000
                    Case Is = "60.0"
                        lowflow = 12000
                    Case Is = "65.0"
                        lowflow = 12000
                    Case Is = "70.0"
                        lowflow = 14000
                    Case Is = "75.0"
                        lowflow = 15500
                    Case Is = "80.0"
                        lowflow = 15000
                    Case Is = "90.0"
                        lowflow = 17500
                    Case Is = "105.0"
                        lowflow = 21000
                    Case Is = "120.0"
                        lowflow = 32000
                    Case Is = "130.0"
                        lowflow = 32000
                    Case Is = "150.0"
                        lowflow = 32000
                    Case Else
                        lowflow = -9999
                End Select
            Case Else
                lowflow = -9999
        End Select

        tempflow = Val(lowflow)
        MinCatalogedAirFlow = tempflow
    End Function

    Private Sub optReplaceFan_CheckedChanged(sender As Object, e As EventArgs) Handles optReplaceFan.CheckedChanged
        If optReplaceFan.Checked Then
            lblFanbhp2.Visible = False
            lblFanHP.Visible = False
            lblRPM.Visible = False
            txtFanRPM.Visible = False
            txtFanBHP.Visible = False
        Else
            lblFanbhp2.Visible = True
            lblFanHP.Visible = True
            lblRPM.Visible = True
            txtFanRPM.Visible = True
            txtFanBHP.Visible = True
        End If
    End Sub
    Private Function GetUPGLowerAmbient(ThisAmbient As Double) As String
        Dim LowAmb As Double
        Dim CurAmb As Double

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
        Dim Snip As String
        Snip = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        If Mid(Snip, 1, 1) = "V" Then
            Snip = Mid(Snip, 1, 2) & "XXX"
        End If
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' ORDER BY Ambient DESC"
        rs.Open(MySQL, con)

        rs.MoveFirst()

        CurAmb = rs.Fields("Ambient").Value
        Do While Not (rs.EOF)
            If CurAmb <= ThisAmbient Then
                LowAmb = CurAmb
                Exit Do
            End If
            rs.MoveNext()
            CurAmb = rs.Fields("Ambient").Value
        Loop


        con.Close()
        rs = Nothing
        con = Nothing

        GetUPGLowerAmbient = Format(LowAmb, "0.0")
    End Function
    Private Function GetUPGUpperAmbient(ThisAmbient As Double) As String
        Dim HighAmb As Double
        Dim CurAmb As Double

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
        Dim Snip As String
        Snip = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        If Mid(Snip, 1, 1) = "V" Then
            Snip = Mid(Snip, 1, 2) & "XXX"
        End If
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' ORDER BY Ambient"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        CurAmb = rs.Fields("Ambient").Value
        Do While Not (rs.EOF)
            If CurAmb >= ThisAmbient Then
                HighAmb = CurAmb
                Exit Do
            End If
            rs.MoveNext()
            CurAmb = rs.Fields("Ambient").Value
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

        GetUPGUpperAmbient = Format(HighAmb, "0.0")
    End Function
    Private Function GetUPGLowerAirflow(Thisflow As Double) As String
        Dim LowAF As Double

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
        Dim Snip As String
        Snip = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        If Mid(Snip, 1, 1) = "V" Then
            Snip = Mid(Snip, 1, 2) & "XXX"
        End If
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' AND Ambient=" & Val(lblLowAmb.Text) & " ORDER BY CatAirflow"
        rs.Open(MySQL, con)

        rs.MoveFirst()

        LowAF = rs.Fields("CatAirflow").Value

        con.Close()
        rs = Nothing
        con = Nothing

        GetUPGLowerAirflow = Format(LowAF, "0.0")
    End Function
    Private Function GetUPGUpperAirflow(Thisflow As Double) As String
        Dim HighAF As Double

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
        Dim Snip As String
        Snip = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        If Mid(Snip, 1, 1) = "V" Then
            Snip = Mid(Snip, 1, 2) & "XXX"
        End If
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' AND Ambient=" & Val(lblLowAmb.Text) & " ORDER BY CatAirflow DESC"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        HighAF = rs.Fields("CatAirflow").Value

        con.Close()
        rs = Nothing
        con = Nothing

        GetUPGUpperAirflow = Format(HighAF, "0.0")
    End Function

    Private Sub chkSeriesConversion_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeriesConversion.CheckedChanged
        If chkSeriesConversion.Checked = True Then
            optRefDwg2Ckt.Checked = True
        End If
        If chkSeriesConversion.Checked = False Then
            optRefDwgNone.Checked = True
        End If
    End Sub

    Private Sub cmdFanHeatCalc_Click(sender As Object, e As EventArgs) Handles cmdFanHeatCalc.Click
        Dim temp As Double
        temp = 2545 * Val(txtFanBHP.Text) / 0.92
        lblFanHeat.Text = Format(temp, "0.0")

    End Sub

    Private Sub cmdMethodSuggest_Click(sender As Object, e As EventArgs) Handles cmdMethodSuggest.Click
        Dim nomAF, MinCatAF, SubAF As Double
        Dim dummy As MsgBoxResult

        If IsNumeric(txtNominalAirflow.Text) Then
            nomAF = Val(txtNominalAirflow.Text)
        Else
            nomAF = -9999
        End If

        If IsNumeric(txtMinCatAirflow.Text) Then
            MinCatAF = Val(txtMinCatAirflow.Text)
        Else
            MinCatAF = -9999
        End If

        SubAF = Val(txtAirflow.Text)

        If ((MinCatAF < 0) Or (nomAF < 0)) Then
            dummy = MsgBox("Enter valid Nominal and Minimum Cataloged Airflows first.", vbOKOnly, "Reduced Air Flow Error")
            Exit Sub
        End If

        If SubAF >= MinCatAF Then optExistingSheaves.Checked = True
        If ((SubAF < MinCatAF) And (SubAF >= (MinCatAF * 0.9))) Then optResheave.Checked = True
        If ((SubAF < (MinCatAF * 0.9) And (SubAF >= (MinCatAF * 0.66)))) Then optFanWallBypassExisting.Checked = True
        If ((SubAF < (MinCatAF * 0.66))) Then optFanWallBypassNew.Checked = True
        If SubAF < (MinCatAF * 0.5) Then optReplaceFan.Checked = True



    End Sub

    Private Sub cmdCalcDehumCap_Click(sender As Object, e As EventArgs) Handles cmdCalcDehumCap.Click
        txtDehumCap.Text = Format(psyDehumCapacity(txtEDB.Text, txtEWB.Text, txtLADB.Text, txtLAWB.Text, txtAirflow.Text), "0.0")
    End Sub
End Class