﻿Public Class frmNewFan
    Private pCancelled As Boolean
    Private pFanStyle As String
    Private ModuleCodeList As New ArrayList

    Public Property FanStyle As String
        Get
            Return pFanStyle
        End Get
        Set(value As String)
            pFanStyle = value
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

    Private Sub frmNewFan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        cmbFanSelected.Text = "None"
        cmbFanType.Text = pFanStyle

        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        Me.Text = "Add or Replace Unit " & pFanStyle
        Call LoadConditions()
        Call LoadTheFanList()
        Call PopulateAuxPanelList()

        If pFanStyle = "Supply Fan" Then
            lblHeatType.Visible = True
            cmbHeatBox.Visible = True
            grpFilterStyle.Visible = True
            chkEconPresent.Visible = True
            chkPwrExhaustPresent.Visible = True
            optAFFan.Checked = True
            chkReliefHoodsShipLoose.Visible = False

            If frmMain.ThisUnit.Family = "Series10" Then
                cmdS10BottomSupply.Visible = True
                cmdS10SideSupply.Visible = True
                lblNote1.Text = "Preferred Max Fan ATZAF12-12FF"
            End If

            If frmMain.ThisUnit.Family = "Series20" Then
                cmdS20SideSupply.Visible = True
                cmdS20BottomSupply.Visible = True
                lblNote1.Text = "Preferred Max Fan ATZAF18-18FF"
            End If

            If frmMain.ThisUnit.Family = "Series40" Then
                cmdS40Supply.Visible = True
                lblNote1.Text = "An ATZAF22-22FF has been successfully used."
            End If

            Select Case frmMain.ThisUnitHeatPerf.HeatType
                Case Is = "Gas"
                    cmbHeatBox.Text = "Gas"

                Case Is = "Electric"
                    cmbHeatBox.Text = "72kW"
                Case Is = "None"
                    cmbHeatBox.Text = "CoolOnly"
            End Select
        End If
        If pFanStyle = "Return Fan" Then
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series100"
                    cmdS100BEndReturn.Visible = True
                Case Is = "Series40"
                    cmdS40EndReturn.Visible = True
                    cmdS40BottomReturn.Visible = True
                    lblNote1.Text = "Preferred Max Fan NAPAF18 (2)"
                    chkRFPiezoRingsOnly.Visible = True
                    chkRFPiezoRingsXmitterOnly.Visible = True
                    chkRFPiezoRingsNet.Visible = True
                Case Is = "Series20"
                    cmdS20BottomReturn.Visible = True
                    cmdS20SideReturn.Visible = True
                    lblNote1.Text = "DNE fan is a Continental AFK 27in Fan (5hp max).  24in is preferred (2hp max)."
                Case Is = "Series10"
                    cmdS10BottomReturn.Visible = True
                    lblNote1.Text = "DNE fan is a Continental AFK 16in Fan (2hp max).  14in fan is preferred (2hp max)."
                    chkS10BottomRAMonitor.Visible = True
                    chkInletMeasuringStationOnly.Visible = True
                    chkInletMeasuringStationWithXMit.Visible = True
                    chkInletMeasuringStationFull.Visible = True
            End Select


        End If

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                fraAuxPanel.Enabled = True
            Case Is = "Series10"
                fraAuxPanel.Enabled = True
            Case Is = "Series12"
                fraAuxPanel.Enabled = True
            Case Is = "Series20"
                fraAuxPanel.Enabled = True
            Case Is = "Series40"

            Case Is = "Series100"

            Case Else

        End Select

    End Sub
    Private Sub PopulateAuxPanelList()
        If optNoAux.Checked = True Then
            cmbAuxPanelOpts.Items.Clear()
            cmbAuxPanelOpts.Items.Add("None")
            cmbAuxPanelOpts.Text = "None"
        Else
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    cmbAuxPanelOpts.Items.Clear()
                    cmbAuxPanelOpts.Items.Add("Series 5 Downflow")
                    cmbAuxPanelOpts.Items.Add("Series 5 Horizontal")
                    cmbAuxPanelOpts.Items.Add("Series 5 Horizontal No Return")
                    cmbAuxPanelOpts.Items.Add("Series 5 Convertible")
                    cmbAuxPanelOpts.Items.Add("Series 5 Custom Application")
                    cmbAuxPanelOpts.Text = "Series 5 Downflow"
                Case Is = "Series10"
                    cmbAuxPanelOpts.Items.Clear()
                    cmbAuxPanelOpts.Items.Add("Series 10 Downflow")
                    cmbAuxPanelOpts.Items.Add("Series 10 Horizontal")
                    cmbAuxPanelOpts.Items.Add("Series 10 Horizontal No Return")
                    cmbAuxPanelOpts.Items.Add("Series 10 Convertible")
                    cmbAuxPanelOpts.Items.Add("Series 10 Custom Application")
                    cmbAuxPanelOpts.Text = "Series 10 Downflow"
                Case Is = "Series20"
                    cmbAuxPanelOpts.Items.Clear()
                    cmbAuxPanelOpts.Items.Add("Series 20 Downflow")
                    cmbAuxPanelOpts.Items.Add("Series 20 Horizontal")
                    cmbAuxPanelOpts.Items.Add("Series 20 Horizontal No Return")
                    cmbAuxPanelOpts.Items.Add("Series 20 Convertible")
                    cmbAuxPanelOpts.Items.Add("Series 20 Custom Application")
                    cmbAuxPanelOpts.Text = "Series 20 Downflow"
                Case Is = "Series40"
                    cmbAuxPanelOpts.Items.Clear()
                    cmbAuxPanelOpts.Items.Add("Series 40 Custom Application")
                    cmbAuxPanelOpts.Text = "Series 40 Custom Application"
                Case Is = "Series100"
                    cmbAuxPanelOpts.Items.Clear()
                    cmbAuxPanelOpts.Items.Add("Series 100 Custom Application")
                    cmbAuxPanelOpts.Text = "Series 100 Custom Application"
            End Select
        End If
    End Sub
    Private Sub PerformDesignCautionScan()
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer

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

        For i = 0 To ModuleCodeList.Count - 1
            MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Return Fan Caution")
                    If dummy = vbYes Then
                        totalmessage = ""
                        startingcaution = rs.Fields("LongText").Value
                        While Len(startingcaution) > 61
                            spacepos = 61
                            Do While ((Mid(startingcaution, spacepos, 1) <> " ") And (Mid(startingcaution, spacepos, 1) <> ",") And (Mid(startingcaution, spacepos, 1) <> "."))
                                spacepos = spacepos - 1
                            Loop

                            eachline = Mid(startingcaution, 1, spacepos - 1)
                            startingcaution = Mid(startingcaution, spacepos)
                            totalmessage = totalmessage & vbCrLf & eachline
                        End While
                        totalmessage = totalmessage & vbCrLf & startingcaution
                        dummy = MsgBox(totalmessage, vbOKOnly, "Return Fan Caution")
                    End If
                    rs.MoveNext()
                Loop
                rs.Close()
            End If
        Next
        con.Close()

        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadTheFanList()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        cmbFanSelected.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        If pFanStyle = "Supply Fan" Then
            MySQL = "SELECT * FROM tblFanCurves WHERE SupplyFan=TRUE ORDER BY FanID"
        Else
            MySQL = "SELECT * FROM tblFanCurves WHERE ReturnFan=TRUE ORDER BY FanID"
        End If

        rs.Open(MySQL, con)

        i = 0
        rs.MoveFirst()
        Do While Not (rs.EOF)
            cmbFanSelected.Items.Add(rs.Fields("FanID").Value)
            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadConditions()

        If pFanStyle = "Supply Fan" Then
            cmbExistingMotor.Text = frmMain.ThisUnitSFanPerf.MotorHP
            txtAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
            txtESP.Text = Format(Val(frmMain.ThisUnitSFanPerf.ESP), "0.00")
            txtUSP.Text = CabinetStatic(txtAirflow.Text, optDownFlow.Checked)
            txtUSPSafetyFactor.Text = Format(Val(txtUSP.Text) * 0.1, "0.00")
            txtTSP.Text = Format(Val(txtESP.Text) + Val(txtUSP.Text) + Val(txtUSPSafetyFactor.Text), "0.00")
            txtElevation.Text = frmMain.ThisUnitCoolPerf.Elevation

            grpRFanCtrlOptions.Visible = False
            grpXFans.Visible = False
            grpSFanCtrlOptions.Visible = True
            grpReliefDampers.Visible = False

        End If
        If pFanStyle = "Return Fan" Then
            cmbExistingMotor.Text = "None"
            txtAirflow.Text = "0"
            txtESP.Text = "0.00"
            txtUSP.Text = "0.00"
            txtUSPSafetyFactor.Text = Format(Val(txtUSP.Text) * 0.1, "0.00")
            txtTSP.Text = Format(Val(txtESP.Text) + Val(txtUSP.Text) + Val(txtUSPSafetyFactor.Text), "0.00")
            txtElevation.Text = frmMain.ThisUnitCoolPerf.Elevation
            grpRFanCtrlOptions.Visible = True
            grpSFanCtrlOptions.Visible = False
            grpReliefDampers.Visible = True
            optBaroRelief.Checked = True

        End If
    End Sub
    Private Function CabinetStatic(lAirflow As String, DF As Boolean) As String
        Dim AF As Double
        Dim ModelStub As String
        Dim CabStatic As Double

        AF = Val(lAirflow)
        ModelStub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        Select Case ModelStub
            Case Is = "J20ZJ"
                If DF Then
                    CabStatic = 0.00000003533 * AF * AF + 0.000007930498 * AF
                Else
                    CabStatic = 0.000000037853 * AF * AF - 0.000036529367 * AF
                End If

            Case Else
                CabStatic = 9.99
        End Select

        CabinetStatic = Format(CabStatic, "0.00")

    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        If cmbFanType.Text = "Supply Fan" Then
            frmMain.ThisUnitMods.Add("SFan") 'Mod Code goes here!
            Call UpdateCodeListSFan()
            If chkWriteHistory.Checked = True Then Call WriteSFanHistory()
        End If

        If cmbFanType.Text = "Return Fan" Then
            frmMain.ThisUnitMods.Add("RFan") 'Mod Code goes here!
            Call UpdateCodeListRFan()
            If chkWriteHistory.Checked = True Then Call WriteRFanHistory()
        End If

        If cmbFanType.Text = "Exhaust Fan" Then
            frmMain.ThisUnitMods.Add("XFan") 'Mod Code goes here!
            Call UpdateCodeListXFan()
        End If
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        'frmMain.ThisUnit.GenCodesPresent = True
        'frmMain.ThisUnitMods.Add("Common")
        'End If

        'Add Auxillary Panel if selected
        If ((optUseAux.Checked = True) And (frmMain.HasAuxillaryPanel = False)) Then
            frmMain.HasAuxillaryPanel = True
            Select Case cmbAuxPanelOpts.Text
                Case Is = "Series 5 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960008")
                Case Is = "Series 5 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960013")
                Case Is = "Series 5 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960014")
                Case Is = "Series 5 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960015")
                Case Is = "Series 5 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960017")
                Case Is = "Series 10 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960005")
                Case Is = "Series 10 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960006")
                Case Is = "Series 10 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960007")
                Case Is = "Series 10 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960010")
                Case Is = "Series 10 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960016")
                Case Is = "Series 20 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960018")
                Case Is = "Series 20 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960019")
                Case Is = "Series 20 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960020")
                Case Is = "Series 20 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960021")
                Case Is = "Series 20 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960012")
                Case Is = "Series 40 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960022")
                Case Is = "Series 100 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960023")
            End Select
        End If

        Call PerformDesignCautionScan()


        Me.Hide()
    End Sub
    Private Sub WriteSFanHistory()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver As String
        Dim modnum, rqAF, RQESP, TSP, Fan, FanQ, Fanbhpea, systembhp, motorhpea, systemhp As String

        Dim MySQL As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text

        modnum = frmMain.txtModelNumber.Text
        rqAF = txtAirflow.Text
        RQESP = txtESP.Text
        TSP = txtTSP.Text
        Fan = cmbFanSelected.Text
        FanQ = nudFanCount.Value
        Fanbhpea = txtFanbhp.Text / FanQ
        systembhp = txtFanbhp.Text
        motorhpea = frmMain.ThisUnitSFanPerf.MotorHP / FanQ
        systemhp = frmMain.ThisUnitSFanPerf.MotorHP

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "INSERT INTO tblHistorySFan (JobName, UnitID, Version, ModelNumber, Airflow, ESP, TSP, Fan, FanQ, FanBHPea, SystemBHP, MotorHPea, SystemHP) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & rqAF & "','" & RQESP & "','" & TSP & "','" & Fan & "','" & FanQ & "','" & Fanbhpea & "','" & systembhp & "','" & motorhpea & "','" & systemhp & "')"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub WriteRFanHistory()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver As String
        Dim modnum, rqAF, RQESP, TSP, Fan, FanQ, Fanbhpea, systembhp, motorhpea, systemhp As String

        Dim MySQL As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text

        modnum = frmMain.txtModelNumber.Text
        rqAF = txtAirflow.Text
        RQESP = txtESP.Text
        TSP = txtTSP.Text
        Fan = cmbFanSelected.Text
        FanQ = nudFanCount.Value
        Fanbhpea = txtFanbhp.Text / FanQ
        systembhp = txtFanbhp.Text
        motorhpea = frmMain.ThisUnitRXPerf.MotorHP / FanQ
        systemhp = frmMain.ThisUnitRXPerf.MotorHP

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "INSERT INTO tblHistoryRFan (JobName, UnitID, Version, ModelNumber, Airflow, ESP, TSP, Fan, FanQ, FanBHPea, SystemBHP, MotorHPea, SystemHP) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & rqAF & "','" & RQESP & "','" & TSP & "','" & Fan & "','" & FanQ & "','" & Fanbhpea & "','" & systembhp & "','" & motorhpea & "','" & systemhp & "')"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub UpdateCodeListXFan()

        'Add the level 0 code(s)
        frmMain.ThisUnitCodes.Add("350100") 'Exhaust Fan Level 1 Code

        'handle the fan type
        If optFCFan.Checked Then frmMain.ThisUnitCodes.Add("350101")
        If optAFFan.Checked Then frmMain.ThisUnitCodes.Add("350102")
        If optPlenumFan.Checked Then frmMain.ThisUnitCodes.Add("350103")
        If optPropFan.Checked Then frmMain.ThisUnitCodes.Add("350104")

        'handle the drive
        If optBeltDrive.Checked Then
            frmMain.ThisUnitCodes.Add("330120") ' belt drive spec
            If optCVSystem.Checked Then
                frmMain.ThisUnitCodes.Add("330121") 'sheaves for motorstarter
            Else
                frmMain.ThisUnitCodes.Add("330122") 'sheaves for VFD
            End If
        Else
            frmMain.ThisUnitCodes.Add("330110") 'direct drive spec
        End If

        If chkMultipleFans.Checked Then frmMain.ThisUnitCodes.Add("330119")

        'handle the isolation
        If optIsoNone.Checked Then frmMain.ThisUnitCodes.Add("330130")
        If optIso1.Checked Then frmMain.ThisUnitCodes.Add("330131")
        If optIso2.Checked Then frmMain.ThisUnitCodes.Add("330132")

        'handle the starter type
        If optCVSystem.Checked Then
            frmMain.ThisUnitCodes.Add("330140") 'motorstarter discussion code / ol relay
        Else
            If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
                frmMain.ThisUnitCodes.Add("330141") 'vfd rplace
                If frmMain.ThisUnit.Family = "Series100" Then
                    frmMain.ThisUnitCodes.Add("330201")
                Else
                    frmMain.ThisUnitCodes.Add("330202")
                End If
            Else
                frmMain.ThisUnitCodes.Add("330142") 'reuse vfd
            End If

            If optNoBypass.Checked Then frmMain.ThisUnitCodes.Add("330145")
            If optReuseBypass.Checked Then frmMain.ThisUnitCodes.Add("330146")
            If optNewBypass.Checked Then frmMain.ThisUnitCodes.Add("330147")
            If chkRemoteVFDKeypad.Checked Then
                frmMain.ThisUnitCodes.Add("330148")
            End If
        End If

        'handle the motor
        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            frmMain.ThisUnitCodes.Add("330150") 'provide new motor

            If optTEFC.Checked Then frmMain.ThisUnitCodes.Add("330152")
            If optODP.Checked Then frmMain.ThisUnitCodes.Add("330151")
        Else
            frmMain.ThisUnitCodes.Add("330155") 'reuse existing motor
        End If

        If chkMultipleFans.Checked Then frmMain.ThisUnitCodes.Add("330159")

        frmMain.ThisUnitCodes.Add("330160") 'Return Fan Controls
        If optNoControls.Checked Then
            frmMain.ThisUnitCodes.Add("330161") 'Return Fan NO Controls
            frmMain.ThisUnitCodes.Add("330162") 'On/Off Only
        Else
            If optTrackSupplyFan.Checked Then frmMain.ThisUnitCodes.Add("330165")
            If optGBASRFan.Checked Then
                frmMain.ThisUnitCodes.Add("330170") 'GBAS Return Fan
                frmMain.ThisUnitCodes.Add("330171") 'GBAS Actuated Dampers
            End If
            If optBldgStaticPressureCtrl.Checked Then
                frmMain.ThisUnitCodes.Add("330180") 'General Building Static PRessure Control Statement
                If optBSPbySE.Checked Then frmMain.ThisUnitCodes.Add("330181") 'SE Econ Return Fan
                If optBSPbyFisen.Checked Then frmMain.ThisUnitCodes.Add("330182") 'Fisen Ctrl Return Fan
                If optBSPbyIPU.Checked Then
                    frmMain.ThisUnitCodes.Add("330185") 'IPU Ctrl of Return Fan
                    If chkIPUModulateDamper.Checked Then
                        frmMain.ThisUnitCodes.Add("330186") 'IPU modulate relief damper
                    End If
                End If
            End If

        End If
        If optNoRelief.Checked Then frmMain.ThisUnitCodes.Add("330190")
        If optBaroRelief.Checked Then
            frmMain.ThisUnitCodes.Add("330191")
            If chkReliefHoodsShipLoose.Checked Then frmMain.ThisUnitCodes.Add("330194") Else frmMain.ThisUnitCodes.Add("330193")
        End If
        If optControlRelief.Checked Then
            frmMain.ThisUnitCodes.Add("330192")
            If chkReliefHoodsShipLoose.Checked Then frmMain.ThisUnitCodes.Add("330194") Else frmMain.ThisUnitCodes.Add("330193")
        End If
    End Sub
    Private Sub UpdateCodeListRFan()

        'Add the level 0 code(s)
        frmMain.ThisUnitCodes.Add("330100") 'Supply Fan Level 1 Code
        ModuleCodeList.Add("330100")
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series10"
                frmMain.ThisUnitCodes.Add("330910")
                ModuleCodeList.Add("330910")
            Case Is = "Series20"
                frmMain.ThisUnitCodes.Add("330920")
                ModuleCodeList.Add("330920")
            Case Is = "Series40"
                frmMain.ThisUnitCodes.Add("330940")
                ModuleCodeList.Add("330940")
            Case Is = "Series100"
                frmMain.ThisUnitCodes.Add("330990")
                ModuleCodeList.Add("330990")
        End Select


        'handle the fan type
        If optFCFan.Checked Then
            frmMain.ThisUnitCodes.Add("330101")
            ModuleCodeList.Add("330101")
        End If
        If optAFFan.Checked Then
            frmMain.ThisUnitCodes.Add("330102")
            ModuleCodeList.Add("330102")
        End If
        If optPlenumFan.Checked Then
            frmMain.ThisUnitCodes.Add("330103")
            ModuleCodeList.Add("330103")
        End If
        If optPropFan.Checked Then
            frmMain.ThisUnitCodes.Add("330104")
            ModuleCodeList.Add("330104")
        End If
        'handle the drive
        If optBeltDrive.Checked Then
            frmMain.ThisUnitCodes.Add("330120") ' belt drive spec
            ModuleCodeList.Add("330120")
            If optCVSystem.Checked Then
                frmMain.ThisUnitCodes.Add("330121") 'sheaves for motorstarter
                ModuleCodeList.Add("330121")
            Else
                frmMain.ThisUnitCodes.Add("330122") 'sheaves for VFD
                ModuleCodeList.Add("330122")
            End If
        Else
            frmMain.ThisUnitCodes.Add("330110") 'direct drive spec
            ModuleCodeList.Add("330110")
        End If

        If chkMultipleFans.Checked Then
            frmMain.ThisUnitCodes.Add("330119")
            ModuleCodeList.Add("330119")
        End If
        'handle the isolation
        If optIsoNone.Checked Then
            frmMain.ThisUnitCodes.Add("330130")
            ModuleCodeList.Add("330130")
        End If
        If optIso1.Checked Then
            frmMain.ThisUnitCodes.Add("330131")
            ModuleCodeList.Add("330131")
        End If
        If optIso2.Checked Then
            frmMain.ThisUnitCodes.Add("330132")
            ModuleCodeList.Add("330132")
        End If

        'handle the starter type
        If optCVSystem.Checked Then
            frmMain.ThisUnitCodes.Add("330140") 'motorstarter discussion code / ol relay
            ModuleCodeList.Add("330140")
        Else
            If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
                frmMain.ThisUnitCodes.Add("330141") 'vfd rplace
                ModuleCodeList.Add("330141")
                If frmMain.ThisUnit.Family = "Series100" Then
                    frmMain.ThisUnitCodes.Add("330201")
                    ModuleCodeList.Add("330201")
                Else
                    frmMain.ThisUnitCodes.Add("330202")
                    ModuleCodeList.Add("330202")
                End If
            Else
                frmMain.ThisUnitCodes.Add("330142") 'reuse vfd
                ModuleCodeList.Add("330142")
            End If

            If optNoBypass.Checked Then
                frmMain.ThisUnitCodes.Add("330145")
                ModuleCodeList.Add("330145")
            End If

            If optReuseBypass.Checked Then
                frmMain.ThisUnitCodes.Add("330146")
                ModuleCodeList.Add("330146")
            End If
            If optNewBypass.Checked Then
                frmMain.ThisUnitCodes.Add("330147")
                ModuleCodeList.Add("330147")
            End If
            If chkRemoteVFDKeypad.Checked Then
                frmMain.ThisUnitCodes.Add("330148")
                ModuleCodeList.Add("330148")
            End If
        End If

        'handle the motor
        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            frmMain.ThisUnitCodes.Add("330150") 'provide new motor
            ModuleCodeList.Add("330150")

            If optTEFC.Checked Then
                frmMain.ThisUnitCodes.Add("330152")
                ModuleCodeList.Add("330152")
            End If
            If optODP.Checked Then
                frmMain.ThisUnitCodes.Add("330151")
                ModuleCodeList.Add("330151")
            End If
        Else
            frmMain.ThisUnitCodes.Add("330155") 'reuse existing motor
            ModuleCodeList.Add("330155")
        End If

        If chkMultipleFans.Checked Then
            frmMain.ThisUnitCodes.Add("330159")
            ModuleCodeList.Add("330159")
        End If

        frmMain.ThisUnitCodes.Add("330160") 'Return Fan Controls
        ModuleCodeList.Add("330160")
        If optNoControls.Checked Then
            frmMain.ThisUnitCodes.Add("330161") 'Return Fan NO Controls
            ModuleCodeList.Add("330161")
            frmMain.ThisUnitCodes.Add("330162") 'On/Off Only
            ModuleCodeList.Add("330162")
        Else
            If optTrackSupplyFan.Checked Then
                frmMain.ThisUnitCodes.Add("330165")
                ModuleCodeList.Add("330165")
            End If
            If optGBASRFan.Checked Then
                frmMain.ThisUnitCodes.Add("330170") 'GBAS Return Fan
                ModuleCodeList.Add("330170")
                frmMain.ThisUnitCodes.Add("330171") 'GBAS Actuated Dampers
                ModuleCodeList.Add("330171")
            End If
            If optBldgStaticPressureCtrl.Checked Then
                frmMain.ThisUnitCodes.Add("330180") 'General Building Static PRessure Control Statement
                ModuleCodeList.Add("330180")
                If optBSPbySE.Checked Then
                    frmMain.ThisUnitCodes.Add("330181") 'SE Econ Return Fan
                    ModuleCodeList.Add("330181")
                End If
                If optBSPbyFisen.Checked Then
                    frmMain.ThisUnitCodes.Add("330182") 'Fisen Ctrl Return Fan
                    ModuleCodeList.Add("330182")
                End If
                If optBSPbyIPU.Checked Then
                    frmMain.ThisUnitCodes.Add("330185") 'IPU Ctrl of Return Fan
                    ModuleCodeList.Add("330185")
                    If chkIPUModulateDamper.Checked Then
                        frmMain.ThisUnitCodes.Add("330186") 'IPU modulate relief damper
                        ModuleCodeList.Add("330186")
                    End If
                End If
            End If

        End If
        If chkRFPiezoRingsOnly.Checked Then
            frmMain.ThisUnitCodes.Add("330169")
            ModuleCodeList.Add("330169")
        End If
        If chkRFPiezoRingsXmitterOnly.Checked Then
            frmMain.ThisUnitCodes.Add("330168")
            ModuleCodeList.Add("330168")
        End If
        If chkRFPiezoRingsNet.Checked Then
            frmMain.ThisUnitCodes.Add("330167")
            ModuleCodeList.Add("330167")
        End If

        If frmMain.ThisUnit.Family = "Series10" Then
            If chkInletMeasuringStationOnly.Checked Then
                frmMain.ThisUnitCodes.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016A")
                frmMain.ThisUnitCodes.Add("33016H") 'No Change to sequence code.
                ModuleCodeList.Add("33016H")
            End If
            If chkInletMeasuringStationWithXMit.Checked Then
                frmMain.ThisUnitCodes.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016A")
                frmMain.ThisUnitCodes.Add("33016B") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016B")
                frmMain.ThisUnitCodes.Add("33016G") 'Return Fan Terminal Blocks
                ModuleCodeList.Add("33016G")
                frmMain.ThisUnitCodes.Add("33016H") 'No Change to sequence code.
                ModuleCodeList.Add("33016H")
            End If
            If chkInletMeasuringStationFull.Checked Then
                frmMain.ThisUnitCodes.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016A")
                frmMain.ThisUnitCodes.Add("33016B") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016B")
                frmMain.ThisUnitCodes.Add("33016C") 'Return Fan Airflow Monitor Wired to Fisen Controller
                ModuleCodeList.Add("33016C")
            End If
        End If
        If frmMain.ThisUnit.Family = "Series20" Then
            If chkInletMeasuringStationOnly.Checked Then
                frmMain.ThisUnitCodes.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016D")
                frmMain.ThisUnitCodes.Add("33016H") 'No Change to sequence code.
                ModuleCodeList.Add("33016H")
            End If
            If chkInletMeasuringStationWithXMit.Checked Then
                frmMain.ThisUnitCodes.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016D")
                frmMain.ThisUnitCodes.Add("33016E") 'Return Fan Airflow Monitor Wired to Fisen Controller
                ModuleCodeList.Add("33016E")
                frmMain.ThisUnitCodes.Add("33016G") 'Return Fan Terminal Blocks
                ModuleCodeList.Add("33016G")
                frmMain.ThisUnitCodes.Add("33016H") 'No Change to sequence code.
                ModuleCodeList.Add("33016H")
            End If
            If chkInletMeasuringStationFull.Checked Then
                frmMain.ThisUnitCodes.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016D")
                frmMain.ThisUnitCodes.Add("33016E") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016E")
                frmMain.ThisUnitCodes.Add("33016F") 'Return Fan Airflow Monitor Wired to Fisen Controller
                ModuleCodeList.Add("33016F")
            End If
        End If



        If optNoRelief.Checked Then
            frmMain.ThisUnitCodes.Add("330190")
            ModuleCodeList.Add("330190")
        End If
        If optBaroRelief.Checked Then
            frmMain.ThisUnitCodes.Add("330191")
            ModuleCodeList.Add("330191")
            If chkReliefHoodsShipLoose.Checked Then frmMain.ThisUnitCodes.Add("330194") Else frmMain.ThisUnitCodes.Add("330193")
        End If
        If optControlRelief.Checked Then
            frmMain.ThisUnitCodes.Add("330192")
            ModuleCodeList.Add("330192")
            If chkReliefHoodsShipLoose.Checked Then
                frmMain.ThisUnitCodes.Add("330194")
                ModuleCodeList.Add("330194")
            Else
                frmMain.ThisUnitCodes.Add("330193")
                ModuleCodeList.Add("330193")
            End If
        End If

        If optHorizFlow.Checked Then
            If frmMain.ThisUnit.Family = "Series10" Then
                frmMain.ThisUnitCodes.Add("330310")
                ModuleCodeList.Add("330310")
                frmMain.ThisUnitCodes.Add("330311")
                ModuleCodeList.Add("330311")
                frmMain.ThisUnitCodes.Add("330312")
                ModuleCodeList.Add("330312")
                frmMain.ThisUnitCodes.Add("330313")
                ModuleCodeList.Add("330313")
                frmMain.ThisUnitCodes.Add("330324")
                ModuleCodeList.Add("330324")
                frmMain.ThisUnitCodes.Add("330325")
                ModuleCodeList.Add("330325")
            End If

            If frmMain.ThisUnit.Family = "Series20" Then
                frmMain.ThisUnitCodes.Add("330320")
                ModuleCodeList.Add("330320")
                frmMain.ThisUnitCodes.Add("330321")
                ModuleCodeList.Add("330321")
                frmMain.ThisUnitCodes.Add("330322")
                ModuleCodeList.Add("330322")
                frmMain.ThisUnitCodes.Add("330313")
                ModuleCodeList.Add("330313")
                frmMain.ThisUnitCodes.Add("330323")
                ModuleCodeList.Add("330323")
                frmMain.ThisUnitCodes.Add("330325")
                ModuleCodeList.Add("330325")
            End If

        End If

        'handle the commnodes
        If Not ((chkRFPiezoRingsNet.Checked) Or (chkInletMeasuringStationFull.Checked)) Then
            frmMain.ThisUnit.CommNodes = "2"
        End If

    End Sub
    Private Sub UpdateCodeListSFan()
        'Add the level 0 code(s)
        frmMain.ThisUnitCodes.Add("320100") 'Supply Fan Level 0 Code

        'handle the fan type
        If optFCFan.Checked Then frmMain.ThisUnitCodes.Add("320101")
        If optAFFan.Checked Then frmMain.ThisUnitCodes.Add("320102")
        If optPlenumFan.Checked Then frmMain.ThisUnitCodes.Add("320103")
        If optPropFan.Checked Then frmMain.ThisUnitCodes.Add("320104")
        Call BOMCodesSupplyFan


        'handle the drive
        If optBeltDrive.Checked Then
            frmMain.ThisUnitCodes.Add("320120") ' belt drive spec
            If optCVSystem.Checked Then
                frmMain.ThisUnitCodes.Add("320121") 'sheaves for motorstarter
            Else
                frmMain.ThisUnitCodes.Add("320122") 'sheaves for VFD
            End If
        Else
            frmMain.ThisUnitCodes.Add("320110") 'direct drive spec
        End If

        'handle the isolation
        If optIsoNone.Checked Then frmMain.ThisUnitCodes.Add("320130")
        If optIso1.Checked Then frmMain.ThisUnitCodes.Add("320131")
        If optIso2.Checked Then frmMain.ThisUnitCodes.Add("320132")

        'handle the starter type
        If optCVSystem.Checked Then
            frmMain.ThisUnitCodes.Add("320140") 'motorstarter discussion code / ol relay
        Else
            If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
                frmMain.ThisUnitCodes.Add("320141") 'vfd rplace
            Else
                frmMain.ThisUnitCodes.Add("320142") 'reuse vfd

            End If
            If optNoBypass.Checked Then frmMain.ThisUnitCodes.Add("320145")
            If optReuseBypass.Checked Then frmMain.ThisUnitCodes.Add("320146")
            If optNewBypass.Checked Then frmMain.ThisUnitCodes.Add("320147")
            If chkRemoteVFDKeypad.Checked Then
                frmMain.ThisUnitCodes.Add("320148")
            End If
        End If

        'handle the motor
        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            frmMain.ThisUnitCodes.Add("320150") 'provide new motor
            If optTEFC.Checked Then frmMain.ThisUnitCodes.Add("320152")
            If optODP.Checked Then frmMain.ThisUnitCodes.Add("320151")
            If ((frmMain.ThisUnit.Family = "Series10") And (Val(cmbNewMotorHP.Text) > 5)) Then
                frmMain.ThisUnitCodes.Add("320158")
            End If

        Else
                frmMain.ThisUnitCodes.Add("320155") 'reuse existing motor
        End If

        'Handle the controls
        frmMain.ThisUnitCodes.Add("320200")
        frmMain.ThisUnitCodes.Add("320205") 'No Controls Changes
        If chkSFanROPiezo.Checked Then
            frmMain.ThisUnitCodes.Add("320241")
        End If
        If chkSFanROandXmitPiezo.Checked Then
            frmMain.ThisUnitCodes.Add("320242")
        End If
        If chkSFanNetPointPiezo.Checked Then
            frmMain.ThisUnitCodes.Add("320243")
        End If
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        tempWeight = "9999"

        If cmbFanType.Text = "Supply Fan" Then
            frmMain.ThisUnitPhysicalData.ModLoadMod.Add("SFan")
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Supply Fan Replacement (Net)")
            'Now it's logic to assign the values.
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    tempWeight = "30"
                Case Is = "Series10"
                    tempWeight = "45"
                Case Is = "Series20"
                    tempWeight = "65"
                Case Is = "Series40"
                    tempWeight = "205"
                Case Is = "Series 100"
                    tempWeight = "145"
                Case Else
                    tempWeight = "9999"
            End Select
        End If

        If cmbFanType.Text = "Return Fan" Then
            frmMain.ThisUnitPhysicalData.ModLoadMod.Add("RFan")

            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Return Fan Installation")
            'Now it's logic to assign the values.

            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    If optHorizFlow.Checked Then
                        tempWeight = "205"
                    Else
                        tempWeight = "105"
                    End If
                Case Is = "Series10"

                    If optHorizFlow.Checked Then
                        tempWeight = "275"
                    Else
                        tempWeight = "145"
                    End If
                Case Is = "Series20"
                    If optHorizFlow.Checked Then
                        tempWeight = "345"
                    Else
                        tempWeight = "195"
                    End If
                Case Is = "Series40"
                    tempWeight = "425"
                Case Is = "Series 100"
                    tempWeight = "698"
                Case Else
                    tempWeight = "9999"
            End Select
        End If

        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            tempWeight = Str(Val(tempWeight) + MotorWeight(cmbNewMotorHP.Text) - MotorWeight(cmbExistingMotor.Text))
        End If
        If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
            tempWeight = Str(Val(tempWeight) + 45)
        End If

        If chkS10BottomRAMonitor.Checked = True Then tempWeight = tempWeight + 58

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Function MotorWeight(hp As String) As String
        Dim tempwt As String
        tempwt = "9999"

        Select Case hp
            Case Is = "0.25"
                tempwt = "13"
            Case Is = "0.5"
                tempwt = "17"
            Case Is = "0.75"
                tempwt = "20"
            Case Is = "1"
                tempwt = "40"
            Case Is = "1.5"
                tempwt = "39"
            Case Is = "2"
                tempwt = "44"
            Case Is = "3"
                tempwt = "60"
            Case Is = "5"
                tempwt = "79"
            Case Is = "7.5"
                tempwt = "135"
            Case Is = "10"
                tempwt = "126"
            Case Is = "15"
                tempwt = "208"
            Case Is = "20"
                tempwt = "227"
            Case Is = "25"
                tempwt = "351"
            Case Is = "30"
                tempwt = "367"
            Case Is = "40"
                tempwt = "474"
            Case Is = "50"
                tempwt = "496"
            Case Is = "None"
                tempwt = "0"
        End Select
        MotorWeight = tempwt
    End Function
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.AirflowTest = True

    End Sub
    Private Sub UpdatePerformance()
        Dim motorhp As String
        Dim i As Integer
        Dim NewRow As String()
        Dim ElecChar As String
        Dim MotorFLA As String

        If cmbFanType.Text = "Supply Fan" Then

            frmMain.ThisUnitSFanPerf.Airflow = Format(Val(txtAirflow.Text), "0")
            frmMain.ThisUnitSFanPerf.RPM = txtFanRPM.Text
            frmMain.ThisUnitSFanPerf.ESP = Format(Val(txtESP.Text), "0.00")
            frmMain.ThisUnitSFanPerf.TSP = Format(Val(txtTSP.Text), "0.00")
            frmMain.ThisUnitCoolPerf.Elevation = Format(Val(txtElevation.Text), "0")
            frmMain.ThisUnitSFanPerf.BrakeHP = Format(Val(txtFanbhp.Text), "0.0")
            frmMain.ThisUnitSFanPerf.MaxRPM = Format(Val(txtMaxFanSpeed.Text), "0")
            If optReuseMotor.Checked Then
                motorhp = cmbExistingMotor.Text
            Else
                motorhp = cmbNewMotorHP.Text
            End If
            frmMain.ThisUnitSFanPerf.MotorHP = motorhp
            frmMain.ThisUnitSFanPerf.kWPower = Format(Val(txtFanbhp.Text) * 0.94, "0.0")
            If optBeltDrive.Checked Then
                frmMain.ThisUnitSFanPerf.DriveType = "Belt"
            Else
                frmMain.ThisUnitSFanPerf.DriveType = "Direct"
            End If
            frmMain.ThisUnitSFanPerf.InletPWL(0) = txtInPWL63.Text
            frmMain.ThisUnitSFanPerf.InletPWL(1) = txtInPWL125.Text
            frmMain.ThisUnitSFanPerf.InletPWL(2) = txtInPWL250.Text
            frmMain.ThisUnitSFanPerf.InletPWL(3) = txtInPWL500.Text
            frmMain.ThisUnitSFanPerf.InletPWL(4) = txtInPWL1k.Text
            frmMain.ThisUnitSFanPerf.InletPWL(5) = txtInPWL2k.Text
            frmMain.ThisUnitSFanPerf.InletPWL(6) = txtInPWL4k.Text
            frmMain.ThisUnitSFanPerf.InletPWL(7) = txtInPWL8k.Text
            frmMain.ThisUnitSFanPerf.Inlet_dBW = txtIndBW.Text
            frmMain.ThisUnitSFanPerf.Inlet_dBA5 = txtIndBA5.Text

            frmMain.ThisUnitSFanPerf.OutletPWL(0) = txtOutPWL63.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(1) = txtOutPWL125.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(2) = txtOutPWL250.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(3) = txtOutPWL500.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(4) = txtOutPWL1k.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(5) = txtOutPWL2k.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(6) = txtOutPWL4k.Text
            frmMain.ThisUnitSFanPerf.OutletPWL(7) = txtOutPWL8k.Text
            frmMain.ThisUnitSFanPerf.Outlet_dBW = txtOutdBW.Text
            frmMain.ThisUnitSFanPerf.Outlet_dBA5 = txtOutdBA5.Text
            frmMain.ThisUnitSFanPerf.XRangeFan = True
            frmMain.ThisUnitSFanPerf.FanSelected = cmbFanSelected.Text

            For i = 0 To dgvStaticSummary.RowCount - 1
                frmMain.ThisUnitSFanPerf.StaticSummaryItem.Add(dgvStaticSummary.Rows(i).Cells.Item(0).Value)
                frmMain.ThisUnitSFanPerf.StaticPDataSTP.Add(dgvStaticSummary.Rows(i).Cells.Item(1).Value)
                frmMain.ThisUnitSFanPerf.StaticPDataATP.Add(dgvStaticSummary.Rows(i).Cells.Item(2).Value)
            Next

            'handle the mca addition
            If optNewMotor.Checked = True Then
                If frmMain.UseCustomMCA = False Then
                    frmMain.UseCustomMCA = True
                    Call frmMain.PreLoadElec()
                End If
            End If

        End If
        If cmbFanType.Text = "Return Fan" Then

            frmMain.ThisUnitRXPerf.FanStyle = "Return"
            frmMain.ThisUnitRXPerf.Airflow = Format(Val(txtAirflow.Text), "0")
            frmMain.ThisUnitRXPerf.RPM = txtFanRPM.Text
            frmMain.ThisUnitRXPerf.ESP = Format(Val(txtESP.Text), "0.00")
            frmMain.ThisUnitRXPerf.TSP = Format(Val(txtTSP.Text), "0.00")
            frmMain.ThisUnitCoolPerf.Elevation = Format(Val(txtElevation.Text), "0")
            frmMain.ThisUnitRXPerf.BrakeHP = Format(Val(txtFanbhp.Text), "0.0")
            frmMain.ThisUnitRXPerf.MaxRPM = Format(Val(txtMaxFanSpeed.Text), "0")
            If optReuseMotor.Checked Then
                motorhp = cmbExistingMotor.Text
            Else
                motorhp = cmbNewMotorHP.Text
            End If
            frmMain.ThisUnitRXPerf.MotorHP = motorhp
            frmMain.ThisUnitRXPerf.kWPower = Format(Val(txtFanbhp.Text) * 0.94, "0.0")
            If optBeltDrive.Checked Then
                frmMain.ThisUnitRXPerf.DriveType = "Belt"
            Else
                frmMain.ThisUnitRXPerf.DriveType = "Direct"
            End If
            frmMain.ThisUnitRXPerf.InletPWL(0) = txtInPWL63.Text
            frmMain.ThisUnitRXPerf.InletPWL(1) = txtInPWL125.Text
            frmMain.ThisUnitRXPerf.InletPWL(2) = txtInPWL250.Text
            frmMain.ThisUnitRXPerf.InletPWL(3) = txtInPWL500.Text
            frmMain.ThisUnitRXPerf.InletPWL(4) = txtInPWL1k.Text
            frmMain.ThisUnitRXPerf.InletPWL(5) = txtInPWL2k.Text
            frmMain.ThisUnitRXPerf.InletPWL(6) = txtInPWL4k.Text
            frmMain.ThisUnitRXPerf.InletPWL(7) = txtInPWL8k.Text
            frmMain.ThisUnitRXPerf.Inlet_dBW = txtIndBW.Text
            frmMain.ThisUnitRXPerf.Inlet_dBA5 = txtIndBA5.Text

            frmMain.ThisUnitRXPerf.OutletPWL(0) = txtOutPWL63.Text
            frmMain.ThisUnitRXPerf.OutletPWL(1) = txtOutPWL125.Text
            frmMain.ThisUnitRXPerf.OutletPWL(2) = txtOutPWL250.Text
            frmMain.ThisUnitRXPerf.OutletPWL(3) = txtOutPWL500.Text
            frmMain.ThisUnitRXPerf.OutletPWL(4) = txtOutPWL1k.Text
            frmMain.ThisUnitRXPerf.OutletPWL(5) = txtOutPWL2k.Text
            frmMain.ThisUnitRXPerf.OutletPWL(6) = txtOutPWL4k.Text
            frmMain.ThisUnitRXPerf.OutletPWL(7) = txtOutPWL8k.Text
            frmMain.ThisUnitRXPerf.Outlet_dBW = txtOutdBW.Text
            frmMain.ThisUnitRXPerf.Outlet_dBA5 = txtOutdBA5.Text
            frmMain.ThisUnitRXPerf.XRangeFan = True

            frmMain.ThisUnitRXPerf.FanSelected = cmbFanSelected.Text

            For i = 0 To dgvStaticSummary.RowCount - 1
                frmMain.ThisUnitRXPerf.StaticSummaryItem.Add(dgvStaticSummary.Rows(i).Cells.Item(0).Value)
                frmMain.ThisUnitRXPerf.StaticPDataSTP.Add(dgvStaticSummary.Rows(i).Cells.Item(1).Value)
                frmMain.ThisUnitRXPerf.StaticPDataATP.Add(dgvStaticSummary.Rows(i).Cells.Item(2).Value)
            Next

            'handle the mca addition
            If optNewMotor.Checked = True Then
                If frmMain.UseCustomMCA = False Then
                    frmMain.UseCustomMCA = True
                    Call frmMain.PreLoadElec()
                End If

                ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
                MotorFLA = frmMain.NEMAMotorFLA(cmbNewMotorHP.Text, frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase)

                NewRow = {True, False, "All", True, "RETURN FAN", ElecChar, cmbNewMotorHP.Text, MotorFLA, False, "NEMA"}
                frmMain.dgvElecLoads.Rows.Add(NewRow)
            End If

            frmMain.ThisUnitRXPerf.FanCount = Str(nudFanCount.Value)

        End If
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        tslblAirflow.Text = "Airflow:" & txtAirflow.Text
        tslblTSP.Text = "TSP: " & txtTSP.Text
        tslblESP.Text = "ESP: " & txtESP.Text
        tslblElevation.Text = "Elevation: " & txtElevation.Text

        If cmbFanType.Text = "Return Fan" Then
            grpXFans.Visible = False
            optBSPbySE.Checked = True
            optNewMotor.Checked = True

            optNewVFD.Checked = True
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    optPropFan.Checked = True

                Case Is = "Series10"
                    optPropFan.Checked = True
                Case Is = "Series20"
                    optPropFan.Checked = True
                Case Is = "Series40"
                    optPlenumFan.Checked = True
                Case Is = "Series100"
                    optPlenumFan.Checked = True
                Case Else
            End Select
        End If

        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        Dim dummy As MsgBoxResult
        If ((optReuseMotor.Checked = False) Or (optReuseVFD.Checked = False)) Then
            If cmbNewMotorHP.Text = "n/a" Then
                dummy = MsgBox("You must select a new motor/drive horsepower.")
                Exit Sub
            End If
        End If

        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                cmbFanSelected.Text = "ContinentalPlaceHolder"
            Case Is = "Series10"
                cmbFanSelected.Text = "ContinentalPlaceHolder"
            Case Is = "Series20"
                cmbFanSelected.Text = "ContinentalPlaceHolder"
            Case Is = "Series40"
                cmbFanSelected.Text = "ComefriNAPAF18_T2"
                chkMultipleFans.Checked = True
                If optHorizFlow.Checked = True Then
                    chkReliefHoodsShipLoose.Checked = True
                End If
            Case Is = "Series100"
            Case Else
        End Select
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnDonePerf.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub optCVSystem_CheckedChanged(sender As Object, e As EventArgs) Handles optCVSystem.CheckedChanged
        If optCVSystem.Checked Then
            optReplaceVFD.Enabled = False
            optReuseVFD.Enabled = False
            optNoBypass.Enabled = False
            optReuseBypass.Enabled = False
            optNewBypass.Enabled = False
            optNoControls.Checked = True
            grpRFanCtrlOptions.Enabled = False
        Else
            optReplaceVFD.Enabled = True
            optReuseVFD.Enabled = True
            optNoBypass.Enabled = True
            optReuseBypass.Enabled = True
            optNewBypass.Enabled = True
        End If
    End Sub

    Private Sub optReplaceMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optReplaceMotor.CheckedChanged
        If optReplaceMotor.Checked Then
            optTEFC.Enabled = True
            optODP.Enabled = True
            cmbNewMotorHP.Enabled = True
            cmbNewMotorHP.Text = "5"
        Else
            optTEFC.Enabled = False
            optODP.Enabled = False
            cmbNewMotorHP.Enabled = False
            cmbNewMotorHP.Text = "n/a"
        End If
    End Sub

    Private Sub txtElevation_TextChanged(sender As Object, e As EventArgs) Handles txtElevation.TextChanged
        lblKFactor.Text = Format(ElevationCorrection(txtElevation.Text), "0.00")
    End Sub

    Private Sub optPropFan_CheckedChanged(sender As Object, e As EventArgs) Handles optPropFan.CheckedChanged
        If optPropFan.Checked Then
            optDirectDrive.Checked = True
            cmbFanSelected.Text = "ContinentalPlaceHolder"
        End If
    End Sub

    Private Sub optFCFan_CheckedChanged(sender As Object, e As EventArgs) Handles optFCFan.CheckedChanged
        If optFCFan.Checked Then
            optBeltDrive.Checked = True
        End If
    End Sub

    Private Sub optAFFan_CheckedChanged(sender As Object, e As EventArgs) Handles optAFFan.CheckedChanged
        If optAFFan.Checked Then
            optBeltDrive.Checked = True
        End If
    End Sub

    Private Sub optPlenumFan_CheckedChanged(sender As Object, e As EventArgs) Handles optPlenumFan.CheckedChanged
        If optPlenumFan.Checked Then
            optBeltDrive.Checked = True
        End If
    End Sub

    Private Sub optBldgStaticPressureCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optBldgStaticPressureCtrl.CheckedChanged
        If optBldgStaticPressureCtrl.Checked = True Then
            grpBSPControls.Enabled = True
        Else
            grpBSPControls.Enabled = False
            optBSPbySE.Checked = False
            optBSPbyFisen.Checked = False
            optBSPbyIPU.Checked = False
            chkIPUModulateDamper.Checked = False
        End If

    End Sub

    Private Sub optVFDBalancing_CheckedChanged(sender As Object, e As EventArgs) Handles optVFDBalancing.CheckedChanged
        If optVFDBalancing.Checked Then
            optNoControls.Checked = True
            grpRFanCtrlOptions.Enabled = False
        End If
    End Sub

    Private Sub cmdStaticSummary_Click(sender As Object, e As EventArgs) Handles cmdStaticSummary.Click
        Dim NewRow As String()
        Dim ItemAtSTP As String
        Dim ItemAtATP As String

        If chkESPatElev.Checked Then
            ItemAtATP = txtESP.Text
            ItemAtSTP = Format(Val(txtESP.Text) * Val(lblKFactor.Text), "0.00")
        Else
            ItemAtSTP = txtESP.Text
            ItemAtATP = Format(Val(txtESP.Text) / Val(lblKFactor.Text), "0.00")
        End If

        NewRow = {"External Static Pressure", ItemAtSTP, ItemAtATP}
        dgvStaticSummary.Rows.Add(NewRow)

        TabControl1.SelectTab("tpgStaticSum")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim i As Integer
        Dim rawtsp As Double
        Dim tsp As Double
        Dim atsp As Double
        Dim sfactor As Double
        Dim asfactor As Double
        Dim NewRow As String()

        tsp = 0.0
        atsp = 0.0


        For i = 0 To dgvStaticSummary.RowCount - 1
            If dgvStaticSummary.Rows(i).Cells.Item(0).Value <> "External Static Pressure" Then
                tsp = tsp + Val(dgvStaticSummary.Rows(i).Cells.Item(1).Value)
                atsp = atsp + Val(dgvStaticSummary.Rows(i).Cells.Item(2).Value)
            End If
        Next
        rawtsp = tsp
        sfactor = tsp * 0.1
        asfactor = atsp * 0.1
        'tsp = tsp + sfactor
        'atsp = atsp + asfactor

        If chkESPatElev.Checked Then
            txtUSP.Text = Format(atsp, "0.00")
            chkUSPatElev.Checked = True
            txtUSPSafetyFactor.Text = Format(asfactor, "0.00")
            chkSFatElev.Checked = True
            atsp = atsp + Val(txtESP.Text) + asfactor
            txtTSP.Text = Format(atsp, "0.00")
            chkTSPatElev.Checked = True
        Else
            txtUSP.Text = Format(tsp, "0.00")
            txtUSPSafetyFactor.Text = Format(sfactor, "0.00")
            tsp = tsp + Val(txtESP.Text) + sfactor
            txtTSP.Text = Format(tsp, "0.00")
        End If

        NewRow = {"Cabinet Effects", Format(sfactor, "0.00"), Format(asfactor, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)

        TabControl1.SelectTab("tpgConditions")
    End Sub

    Private Sub cmdS40EndReturn_Click(sender As Object, e As EventArgs) Handles cmdS40EndReturn.Click
        Dim RAOpening As Double
        Dim Damper As Double
        Dim Hood As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000001029 * airflow ^ 2 - 0.000019713718 * airflow + 0.143124739234
        'now the damper
        Damper = 0.000000005769 * airflow ^ 2 - 0.000107288969 * airflow + 0.719403182401 + 0.03
        'finally the hood
        Hood = 0.000000000446 * airflow ^ 2 - 0.000005461067 * airflow + 0.05213854886

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        frmMain.ThisUnitRXPerf.DuctLoc = "End"
        cmdS40EndReturn.Enabled = False

    End Sub

    Private Sub chkMultipleFans_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultipleFans.CheckedChanged
        If chkMultipleFans.Checked Then
            nudFanCount.Maximum = 4
            nudFanCount.Value = 2
            nudFanCount.Minimum = 2

        Else
            nudFanCount.Minimum = 1
            nudFanCount.Value = 1
            nudFanCount.Maximum = 1
        End If
    End Sub

    Private Sub cmdS20BottomReturn_Click(sender As Object, e As EventArgs) Handles cmdS20BottomReturn.Click
        Dim RAOpening As Double
        Dim NinetyBend As Double
        Dim Damper As Double
        Dim Hood As Double
        Dim airflow As Double
        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000000824 * airflow ^ 2 + 0.000000166491 * airflow - 0.001428563694
        'now the transition
        NinetyBend = 0.000000000959 * airflow ^ 2 + 0.000004083821 * airflow - 0.013746561097
        'now the damper
        Damper = 0.000000015328 * airflow ^ 2 - 0.000096979336 * airflow + 0.321525675874
        'finally the hood
        Hood = 0.00000000031 * airflow ^ 2 + 0.00000152434 * airflow + 0.01543379027

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), Format(RAOpening / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Cabinet Transitions", Format(NinetyBend, "0.00"), Format(NinetyBend / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Damper / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), Format(Hood / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        frmMain.ThisUnitRXPerf.DuctLoc = "Bottom"
        chkReliefHoodsShipLoose.Checked = True
        cmdS20BottomReturn.Enabled = False
    End Sub

    Private Sub cmdS20SideReturn_Click(sender As Object, e As EventArgs) Handles cmdS20SideReturn.Click
        Dim RAOpening As Double
        Dim NinetyBend As Double
        Dim Damper As Double
        Dim Hood As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000000824 * airflow ^ 2 + 0.000000166491 * airflow - 0.001428563694
        'now the transition
        NinetyBend = 0.000000000959 * airflow ^ 2 + 0.000004083821 * airflow - 0.013746561097
        'now the damper
        Damper = 0.000000013711 * airflow ^ 2 - 0.000132053909 * airflow + 0.439816513146
        'finally the hood
        Hood = 0.00000000031 * airflow ^ 2 + 0.00000152434 * airflow + 0.01543379027

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), Format(Val(lblKFactor.Text) ^ -1 * RAOpening, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Cabinet Transitions", Format(NinetyBend, "0.00"), Format(Val(lblKFactor.Text) ^ -1 * NinetyBend, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Val(lblKFactor.Text) ^ -1 * Damper, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), Format(Val(lblKFactor.Text) ^ -1 * Hood, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        frmMain.ThisUnitRXPerf.DuctLoc = "Side"
    End Sub

    Private Sub cmdS40BottomReturn_Click(sender As Object, e As EventArgs) Handles cmdS40BottomReturn.Click
        Dim RAOpening As Double

        Dim Damper As Double
        Dim Hood As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = -0.00000000013 * airflow ^ 2 + 0.000005557424 * airflow - 0.026070909091
        'now the damper
        Damper = 0.000000001396 * airflow ^ 2 + 0.000023993506 * airflow - 0.138268398268
        'finally the hood
        Hood = 0.000000000249 * airflow ^ 2 + 0.000000025974 * airflow + 0.014406926407

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), Format(Val(lblKFactor.Text) * RAOpening, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Val(lblKFactor.Text) * Damper, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), Format(Val(lblKFactor.Text) * Hood, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        frmMain.ThisUnitRXPerf.DuctLoc = "Bottom"
        cmdS40BottomReturn.Enabled = False
    End Sub

    Private Sub cmdS10BottomReturn_Click(sender As Object, e As EventArgs) Handles cmdS10BottomReturn.Click
        Dim RAOpening As Double
        Dim NinetyBend As Double
        Dim Damper As Double
        Dim Hood As Double
        Dim RAMod As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000002564 * airflow ^ 2 + 0.000000051282 * airflow + 0.000181818182
        'now the transition
        NinetyBend = 0.000000005921 * airflow ^ 2 - 0.000002354312 * airflow + 0.002727272727
        'now the damper
        Damper = 0.000000015664 * airflow ^ 2 - 0.000001286713 * airflow + 0.033454545455
        'finally the hood
        Hood = 0.000000001399 * airflow ^ 2 + 0.00000060979 * airflow + 0.009327272727

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), Format(RAOpening / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Cabinet Transitions", Format(NinetyBend, "0.00"), Format(NinetyBend / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Damper / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), Format(Hood / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)

        If chkS10BottomRAMonitor.Checked Then
            RAMod = 0.0000000062764091214 * airflow ^ 2 - 0.00000207626140113119 * airflow + 0.00186413551609189
            RAMod = RAMod * 1.1
            NewRow = {"Return Air Monitor Module", Format(RAMod, "0.00"), Format(RAMod / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)

        End If

        frmMain.ThisUnitRXPerf.DuctLoc = "Bottom"
        cmdS10BottomReturn.Enabled = False
    End Sub

    Private Sub cmdS10BottomSupply_Click(sender As Object, e As EventArgs) Handles cmdS10BottomSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim FactoryOptions As Double
        Dim fourinchers As Boolean
        Dim econyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureS10(airflow, True)
        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS10(airflow, cmbHeatBox.Text)
        'now the FilterAdjustment
        If opt2InchFilters.Checked = True Then fourinchers = False
        If opt4InchFilters.Checked = True Then fourinchers = True
        FilterMod = FilterAdjustmentS10(airflow, FourInchers)
        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS10(airflow, EconYesNo)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS10BottomSupply.Enabled = False



    End Sub
    Private Function UnitStaticPressureS10(localAirflow As Double, BottomD As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If BottomD Then

            Select Case Snippet
                Case Is = "J06ZR"
                    temp = 0.000000094891 * localAirflow ^ 2 + 0.000278041791 * localAirflow
                Case Is = "J07ZR"
                    temp = 0.00000017797 * localAirflow ^ 2 + 0.00011516589 * localAirflow
                Case Is = "J07ZT"
                    temp = 0.00000017797 * localAirflow ^ 2 + 0.00011516589 * localAirflow
                Case Is = "J08ZJ"
                    temp = 0.000000110419 * localAirflow ^ 2 + 0.000023117324 * localAirflow
                Case Is = "J10ZF"
                    temp = 0.000000092667 * localAirflow ^ 2 - 0.000082730604 * localAirflow
                Case Is = "J10ZJ"
                    temp = 0.000000081358 * localAirflow ^ 2 + 0.000128630509 * localAirflow
                Case Is = "J10ZR"
                    temp = 0.000000127606 * localAirflow ^ 2 + 0.000012701161 * localAirflow
                Case Is = "J10ZT"
                    temp = 0.000000084123418587 * localAirflow ^ 2 + 0.00011516719348998 * localAirflow
                Case Is = "J12ZJ"
                    temp = 0.000000124168 * localAirflow ^ 2 - 0.000010597484 * localAirflow
                Case Is = "J12ZT"
                    temp = 0.000000100649296001 * localAirflow ^ 2 + 0.00004369068562117 * localAirflow
                Case Is = "J12ZR"
                    temp = 0.000000145691 * localAirflow ^ 2 - 0.000039648178 * localAirflow
                Case Is = "J12ZF"
                    temp = 0.000000124168 * localAirflow ^ 2 - 0.000010597484 * localAirflow
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)

                    Stop
            End Select

        Else
            Select Case Snippet
                Case Is = "J06ZR"
                    temp = 0.000000139404 * localAirflow ^ 2 + 0.000016428148 * localAirflow
                Case Is = "J07ZR"
                    temp = 0.00000014609 * localAirflow ^ 2 + 0.000001211291 * localAirflow
                Case Is = "J07ZT"
                    temp = 0.00000014609 * localAirflow ^ 2 + 0.000001211291 * localAirflow
                Case Is = "J08ZJ"
                    temp = 0.000000047632 * localAirflow ^ 2 + 0.000094404159 * localAirflow
                Case Is = "J10ZF"
                    temp = 0.000000054358 * localAirflow ^ 2 + 0.000071105472 * localAirflow
                Case Is = "J10ZJ"
                    temp = 0.000000009937 * localAirflow ^ 2 + 0.000260485433 * localAirflow
                Case Is = "J10ZR"
                    temp = 0.000000039043 * localAirflow ^ 2 + 0.000171795214 * localAirflow
                Case Is = "J10ZT"
                    temp = 0.000000056968826816 * localAirflow ^ 2 + 0.000070914044138178 * localAirflow
                Case Is = "J12ZJ"
                    temp = 0.000000062138 * localAirflow ^ 2 + 0.000041605488 * localAirflow
                Case Is = "J12ZT"
                    temp = 0.000000059436091033 * localAirflow ^ 2 + 0.000061252317328535 * localAirflow
                Case Is = "J12ZR"
                    temp = 0.000000073142 * localAirflow ^ 2 + 0.000040949828 * localAirflow
                Case Is = "J12ZF"
                    temp = 0.000000062138 * localAirflow ^ 2 + 0.000041605488 * localAirflow
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)

                    Stop
            End Select
        End If

        Return temp
    End Function

    Private Function HeatAdjustmentS10(localAirflow As Double, HeatCode As String)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult
        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        Select Case HeatCode
            Case Is = "Gas"
                temp = 0
            Case Is = "CoolOnly"
                Select Case Snippet

                    Case Is = "J12ZR"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J12ZJ"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J12ZT"
                        temp = -0.000000019929338691 * localAirflow ^ 2 + 0.00001501848785131 * localAirflow
                    Case Is = "J12ZF"
                        temp = -0.000000015137607 * localAirflow ^ 2 + 0.000000933427427 * localAirflow
                    Case Is = "J12ZH"
                        temp = -0.000000015137607 * localAirflow ^ 2 + 0.000000933427427 * localAirflow
                    Case Is = "J10ZR"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZJ"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZT"
                        temp = -0.000000019929338691 * localAirflow ^ 2 + 0.00001501848785131 * localAirflow
                    Case Is = "J08ZJ"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J07ZR"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J06ZR"
                        temp = -0.000000008403034 * localAirflow ^ 2 + 0.000011537438724 * localAirflow
                        If temp > 0 Then temp = 0
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")
                End Select
            Case Is = "9kW"
                Select Case Snippet
                    Case Is = "J12ZR"
                        temp = 0.000000013911631846 * localAirflow * localAirflow - 0.000010962732919255 * localAirflow + 0.0196516798418959
                    Case Is = "J12ZJ"
                        temp = 0.000000013911631846 * localAirflow ^ 2 - 0.000010962732919255 * localAirflow + 0.0196516798418959
                    Case Is = "J12ZT"
                        temp = 0.000000013911631846 * localAirflow ^ 2 - 0.000010962732919255 * localAirflow + 0.0196516798418959
                    Case Is = "J12ZF"
                        temp = 0.000000012756155994 * localAirflow ^ 2 - 0.000000970284044153 * localAirflow
                    Case Is = "J12ZH"
                        temp = 0.000000012756155994 * localAirflow ^ 2 - 0.000000970284044153 * localAirflow
                    Case Is = "J08ZJ"
                        temp = 0.000000013911631846 * localAirflow ^ 2 - 0.000010962732919255 * localAirflow + 0.0196516798418959
                    Case Is = "J07ZR"
                        temp = 0.000000013911631846 * localAirflow ^ 2 - 0.000010962732919255 * localAirflow + 0.0196516798418959
                    Case Is = "J06ZR"
                        temp = 0.000000011948603 * localAirflow ^ 2 + 0.000001710118785 * localAirflow
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")

                End Select
            Case Is = "18kW"
                Select Case Snippet
                    Case Is = "J12ZR"
                        temp = 0.000000015774985884 * localAirflow * localAirflow - 0.000023178994918126 * localAirflow + 0.0481793478260862
                    Case Is = "J12ZJ"
                        temp = 0.000000015774985884 * localAirflow * localAirflow - 0.000023178994918126 * localAirflow + 0.0481793478260862
                    Case Is = "J12ZT"
                        temp = 0.000000015774985884 * localAirflow * localAirflow - 0.000023178994918126 * localAirflow + 0.0481793478260862
                    Case Is = "J12ZF"
                        temp = 0.000000012942145464 * localAirflow ^ 2 + 0.000001319148437772 * localAirflow
                    Case Is = "J12ZH"
                        temp = 0.000000012942145464 * localAirflow ^ 2 + 0.000001319148437772 * localAirflow
                    Case Is = "J08ZJ"
                        temp = 0.000000015774985884 * localAirflow ^ 2 - 0.000023178994918126 * localAirflow + 0.0481793478260862
                    Case Is = "J07ZR"
                        temp = 0.000000015774985884 * localAirflow * localAirflow - 0.000023178994918126 * localAirflow + 0.0481793478260862
                    Case Is = "J06ZR"
                        temp = 0.000000010965454 * localAirflow ^ 2 + 0.000008170233413 * localAirflow
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")

                End Select
            Case Is = "24kW"
                Select Case Snippet
                    Case Is = "J12ZR"
                        temp = 0.000000012859966121 * localAirflow * localAirflow + 0.000008085827216262 * localAirflow + 0.00369071146245078
                    Case Is = "J12ZJ"
                        temp = 0.000000012859966121 * localAirflow * localAirflow + 0.000008085827216262 * localAirflow + 0.00369071146245078
                    Case Is = "J12ZT"
                        temp = 0.000000012859966121 * localAirflow * localAirflow + 0.000008085827216262 * localAirflow + 0.00369071146245078
                    Case Is = "J12ZF"
                        temp = 0.000000012642960348 * localAirflow ^ 2 + 0.000009962473176877 * localAirflow
                    Case Is = "J12ZH"
                        temp = 0.000000012642960348 * localAirflow ^ 2 + 0.000009962473176877 * localAirflow
                    Case Is = "J08ZJ"
                        temp = 0.000000012859966121 * localAirflow ^ 2 + 0.000008085827216262 * localAirflow + 0.00369071146245078
                    Case Is = "J07ZR"
                        temp = 0.000000012859966121 * localAirflow * localAirflow + 0.000008085827216262 * localAirflow + 0.00369071146245078
                    Case Is = "J06ZR"
                        temp = 0.000000012554697 * localAirflow ^ 2 + 0.00001014514702 * localAirflow
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")

                End Select
            Case Is = "36kW"
                Select Case Snippet
                    Case Is = "J12ZR"
                        temp = 0.000000015047995483 * localAirflow * localAirflow - 0.00000540937323546 * localAirflow + 0.0331719367588933
                    Case Is = "J12ZJ"
                        temp = 0.000000015047995483 * localAirflow * localAirflow - 0.00000540937323546 * localAirflow + 0.0331719367588933
                    Case Is = "J12ZT"
                        temp = 0.000000015047995483 * localAirflow * localAirflow - 0.00000540937323546 * localAirflow + 0.0331719367588933
                    Case Is = "J12ZF"
                        temp = 0.000000013097558055 * localAirflow ^ 2 + 0.000011457830219542 * localAirflow
                    Case Is = "J12ZH"
                        temp = 0.000000013097558055 * localAirflow ^ 2 + 0.000011457830219542 * localAirflow
                    Case Is = "J08ZJ"
                        temp = 0.000000015047995483 * localAirflow ^ 2 - 0.00000540937323546 * localAirflow + 0.0331719367588933
                    Case Is = "J07ZR"
                        temp = 0.000000015047995483 * localAirflow * localAirflow - 0.00000540937323546 * localAirflow + 0.0331719367588933
                    Case Is = "J06ZR"
                        temp = 0.000000011571549 * localAirflow ^ 2 + 0.000016605261648 * localAirflow
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")

                End Select
            Case Is = "54kW"
                Select Case Snippet
                    Case Is = "J12ZR"
                        temp = 0.000000013212874082 * localAirflow * localAirflow + 0.000020112930547712 * localAirflow + 0.0100000000000018
                    Case Is = "J12ZJ"
                        temp = 0.000000013212874082 * localAirflow * localAirflow + 0.000020112930547712 * localAirflow + 0.0100000000000018
                    Case Is = "J12ZT"
                        temp = 0.000000013212874082 * localAirflow * localAirflow + 0.000020112930547712 * localAirflow + 0.0100000000000018
                    Case Is = "J12ZF"
                        temp = 0.000000012624895924 * localAirflow ^ 2 + 0.000025197711572097 * localAirflow
                    Case Is = "J12ZH"
                        temp = 0.000000012624895924 * localAirflow ^ 2 + 0.000025197711572097 * localAirflow
                    Case Is = "J08ZJ"
                        temp = 0.000000013212874082 * localAirflow ^ 2 + 0.000020112930547712 * localAirflow + 0.0100000000000018
                    Case Is = "J07ZR"
                        temp = 0.000000013212874082 * localAirflow * localAirflow + 0.000020112930547712 * localAirflow + 0.0100000000000018
                    Case Is = "J06ZR"
                        temp = 0.000000011825439 * localAirflow ^ 2 + 0.000027574352925 * localAirflow
                    Case Else
                        temp = 99.9
                        dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS10")
                End Select
        End Select
        If temp < 0 Then temp = 0
        Return temp
    End Function

    Private Function FilterAdjustmentS10(localAirflow As Double, FourInchFilters As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If FourInchFilters Then
            Select Case Snippet
                Case Is = "J12ZR"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZJ"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZT"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZF"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZH"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J10ZR"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J10ZJ"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J10ZT"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J10ZF"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J08ZJ"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J07ZR"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J06ZR"
                    temp = 0.000000001978349 * localAirflow ^ 2 + 0.000050003935905 * localAirflow
                Case Else
                    temp = 99.9
                    dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:FilterAdjustmentS10")

            End Select
            If temp < 0 Then temp = 0
        Else
            temp = 0
        End If

        Return temp
    End Function
    Private Function EconAdjustmentS10(localAirflow As Double, EconPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If EconPresent Then
            Select Case Snippet
                Case Is = "J12ZR"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J12ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J12ZT"
                    temp = -0.000000019882834557 * localAirflow ^ 2 + 0.000399254658385093 * localAirflow - 0.646415513833994
                Case Is = "J12ZF"
                    temp = -0.00000002100701087 * localAirflow ^ 2 + 0.000416422272434739 * localAirflow - 0.768013952863524
                Case Is = "J10ZR"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZT"
                    temp = -0.000000019882834557 * localAirflow ^ 2 + 0.000399254658385093 * localAirflow - 0.646415513833994
                Case Is = "J08ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J07ZR"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J06ZR"
                    temp = 0.000000012497656 * localAirflow ^ 2 + 0.000022831433083 * localAirflow
                Case Else
                    temp = 99.9
                    Dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:EconAdjustmentS10")

            End Select
            If temp < 0 Then temp = 0
        Else
            temp = 0
        End If

        Return temp
    End Function

    Private Sub cmdS100BEndReturn_Click(sender As Object, e As EventArgs) Handles cmdS100BEndReturn.Click
        Dim RAOpening As Double
        Dim Damper As Double
        Dim Hood As Double
        Dim CabTransitions As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000000068715 * airflow ^ 2 - 0.000000004982874 * airflow

        'now the transitions
        CabTransitions = 0.000000000136854 * (airflow / 2) ^ 2 - 0.000000231678622 * (airflow / 2)

        'now the damper
        Damper = 0.000000000398135 * airflow ^ 2 + 0.000003330381561 * airflow

        'finally the hood
        Hood = 0.00000000003079 * airflow ^ 2 + 0.000000642194162 * airflow

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Cabinet Transitions", Format(CabTransitions, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)

        frmMain.ThisUnitRXPerf.DuctLoc = "Side"
        cmdS100BEndReturn.Enabled = False
    End Sub

    Private Sub txtFanRPM_LostFocus(sender As Object, e As EventArgs) Handles txtFanRPM.LostFocus
        If optPropFan.Checked Then
            txtMaxFanSpeed.Text = txtFanRPM.Text
        End If
    End Sub

    Private Sub cmdS20SideSupply_Click(sender As Object, e As EventArgs) Handles cmdS20SideSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim FactoryOptions As Double

        Dim econyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureS20(airflow, False)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS20(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        'Nothing on a series 20 !!!

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS20(airflow, econyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS20SideSupply.Enabled = False
    End Sub
    Private Function EconAdjustmentS20(localAirflow As Double, EconPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If EconPresent Then
            Select Case Snippet
                Case Is = "J15ZF"
                    temp = 0.1
                Case Is = "J17ZF"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

                Case Is = "J20ZF"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

                Case Is = "J25ZF"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

                Case Is = "J15ZR"
                    temp = 0.1
                Case Is = "J17ZR"
                    temp = 0.000000000952 * localAirflow ^ 2 + 0.000000857143 * localAirflow + 0.050857142857
                Case Is = "J20ZR"
                    temp = 0.000000000952 * localAirflow ^ 2 + 0.000000857143 * localAirflow + 0.050857142857
                Case Is = "J25ZR"
                    temp = 0.000000000952 * localAirflow ^ 2 + 0.000000857143 * localAirflow + 0.050857142857

                Case Is = "J15ZJ"
                    temp = 0.1
                Case Is = "J17ZJ"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

                Case Is = "J20ZJ"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

                Case Is = "J25ZJ"
                    temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001

            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function

    Private Function UnitStaticPressureS20(localAirflow As Double, BottomD As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If BottomD Then
            Select Case Snippet
                Case Is = "J15ZF"
                    temp = 0.00000003533 * localAirflow ^ 2 - 0.000007930498 * localAirflow + 0
                Case Is = "J17ZF"
                    temp = 0.0000000178 * localAirflow ^ 2 - 0.00007275 * localAirflow + 0
                Case Is = "J20ZF"
                    temp = 0.0000000199 * localAirflow ^ 2 - 0.0000798051 * localAirflow + 0
                Case Is = "J25ZF"
                    temp = 0.0000000026 * localAirflow ^ 2 - 0.0001650528 * localAirflow + 0
                Case Is = "J15ZJ"
                    temp = 0.000000020999 * localAirflow ^ 2 + 0.00010369692 * localAirflow + 0
                    'Case Is = "J17ZJ"
                    '    temp = 0.0 * localAirflow ^ 2 - 0.0 * localAirflow + 0
                Case Is = "J20ZJ"
                    temp = 0.0000000192 * localAirflow * localAirflow + 0.0000567739 * localAirflow
                    'Case Is = "S25ZJ"
                    '    temp = 0.0 * localAirflow ^ 2 - 0.0 * localAirflow + 0
                Case Is = "J15ZR"
                    temp = 0.000000013833 * localAirflow ^ 2 + 0.000150417882 * localAirflow + 0
                Case Is = "J20ZR"
                    temp = 0.0000000199 * localAirflow ^ 2 + 0.000031375 * localAirflow - 0
                Case Is = "J25ZR"
                    temp = 0.0000000205 * localAirflow ^ 2 + 0.0000656707 * localAirflow + 0
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        Else
            Select Case Snippet
                Case Is = "J15ZF"
                    temp = 0.000000037853 * localAirflow ^ 2 - 0.000036529367 * localAirflow + 0
                Case Is = "J17ZF"
                    temp = 0.0000000205 * localAirflow ^ 2 - 0.0000173113 * localAirflow + 0
                Case Is = "J20ZF"
                    temp = 0.0000000154 * localAirflow ^ 2 - 0.0000790717 * localAirflow + 0
                Case Is = "J25ZF"
                    temp = 0.0000000004 * localAirflow ^ 2 - 0.0001641615 * localAirflow + 0
                Case Is = "J15ZJ"
                    temp = 0.000000027555 * localAirflow ^ 2 + 0.000029069193 * localAirflow + 0
                    'Case Is = "J17ZJ"
                    '    temp = 0.0 * localAirflow ^ 2 - 0.0 * localAirflow + 0
                Case Is = "J20ZJ"
                    temp = 0.0000000177 * localAirflow * localAirflow + 0.0000379674 * localAirflow
                    'Case Is = "S25ZJ"
                    '    temp = 0.0 * localAirflow ^ 2 - 0.0 * localAirflow + 0
                Case Is = "J15ZR"
                    temp = 0.000000006085 * localAirflow ^ 2 + 0.000164261398 * localAirflow + 0
                Case Is = "J20ZR"
                    temp = 0.000000037853 * localAirflow ^ 2 - 0.000036529367 * localAirflow + 0
                Case Is = "J25ZR"
                    temp = 0.0000000199 * localAirflow ^ 2 + 0.000031375 * localAirflow + 0
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        End If

        Return temp
    End Function
    Private Function HeatAdjustmentS20(localAirflow As Double, HeatCode As String)
        Dim temp As Double
        Dim Snippet As String

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        Select Case HeatCode
            Case Is = "Gas"
                temp = 0
            Case Is = "CoolOnly"
                Select Case Snippet
                    Case Is = "J15ZF"
                        temp = -0.1
                    Case Is = "J17ZF"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J20ZF"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J25ZF"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J15ZR"
                        temp = -0.1
                    Case Is = "J17ZR"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J20ZR"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J25ZR"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J15ZJ"
                        temp = -0.1
                    Case Is = "J17ZJ"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J20ZJ"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1
                    Case Is = "J25ZJ"
                        temp = 0.002142857142857 * localAirflow * localAirflow + 0.014142857142857 * 0.074000000000001
                        temp = temp * -1

                End Select
            Case Is = "18kW"
                Select Case Snippet
                    Case Is = "J15ZF"
                        temp = -0.1
                    Case Is = "J17ZF"
                        temp = 0.00000000216856 * localAirflow * localAirflow - 0.000002974969677 * localAirflow + 0.0
                    Case Is = "J20ZF"
                        temp = 0.00000000216856 * localAirflow * localAirflow - 0.000002974969677 * localAirflow + 0.0
                    Case Is = "J25ZF"
                        temp = 0.00000000216856 * localAirflow * localAirflow - 0.000002974969677 * localAirflow + 0.0
                End Select

            Case Is = "36kW"
                Select Case Snippet
                    Case Is = "J15ZF"
                        temp = 0.0000666666666666667 * localAirflow - 0.2

                    Case Is = "J17ZF"
                        temp = 0.000000003749035 * localAirflow * localAirflow - 0.0 * 0.000002205314809 + 0.0

                    Case Is = "J20ZF"
                        temp = 0.000000003749035 * localAirflow * localAirflow - 0.0 * 0.000002205314809 + 0.0
                    Case Is = "J25ZF"
                        temp = 0.000000003749035 * localAirflow * localAirflow - 0.0 * 0.000002205314809 + 0.0
                End Select
            Case Is = "54kW"
                Select Case Snippet
                    Case Is = "J15ZF"
                        temp = 0.0000666666666666667 * localAirflow - 0.1
                    Case Is = "J17ZF"
                        temp = 0.000000004388576 * localAirflow * localAirflow - 0.000007222405998 * localAirflow + 0.0

                    Case Is = "J20ZF"
                        temp = 0.000000004388576 * localAirflow * localAirflow - 0.000007222405998 * localAirflow + 0.0
                    Case Is = "J25ZF"
                        temp = 0.000000004388576 * localAirflow * localAirflow - 0.000007222405998 * localAirflow + 0.0
                End Select
            Case Is = "72kW"
                Select Case Snippet
                    Case Is = "J15ZF"
                        temp = 0.000133333333333333 * localAirflow - -0.4
                    Case Is = "J17ZF"
                        temp = 0.000000005969052 * localAirflow * localAirflow - 0.000007992060867 * localAirflow + 0.0
                    Case Is = "J20ZF"
                        temp = 0.000000005969052 * localAirflow * localAirflow - 0.000007992060867 * localAirflow + 0.0
                    Case Is = "J25ZF"
                        temp = 0.000000005969052 * localAirflow * localAirflow - 0.000007992060867 * localAirflow + 0.0
                End Select
        End Select
        Return temp
    End Function

    Private Sub cmdS10SideSupply_Click(sender As Object, e As EventArgs) Handles cmdS10SideSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim FactoryOptions As Double
        Dim fourinchers As Boolean
        Dim econyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureS10(airflow, False)
        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS10(airflow, cmbHeatBox.Text)
        'now the FilterAdjustment
        If opt2InchFilters.Checked = True Then fourinchers = False
        If opt4InchFilters.Checked = True Then fourinchers = True
        FilterMod = FilterAdjustmentS10(airflow, fourinchers)
        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS10(airflow, econyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS10SideSupply.Enabled = False
    End Sub

    Private Sub cmdS40Supply_Click(sender As Object, e As EventArgs) Handles cmdS40Supply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim filtertype As String
        Dim EconMod As Double
        Dim FactoryOptions As Double

        Dim econyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureS40(airflow)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS40(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        filtertype = "2 inch"
        If opt6inch65.Checked Then filtertype = "6 inch 65%"
        If opt6inch95.Checked Then filtertype = "6 inch 95%"

        FilterMod = FilterAdjustmentS40(airflow, filtertype)

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        If econyesno Then
            EconMod = EconAdjustmentS40(airflow, chkPwrExhaustPresent.Checked)

        End If

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS40Supply.Enabled = False
    End Sub
    Private Function UnitStaticPressureS40(localairflow As Double) As Double
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 2, 1)

        temp = 0

        Select Case Snippet
            Case Is = "2"
                temp = 0.000000009771 * localairflow ^ 2 + 0.000002576043 * localairflow + 0.241426648721
            Case Is = "3"
                temp = 0.000000006323560308 * localairflow ^ 2 + 0.000060251533223934 * localairflow + 0
            Case Is = "4"
                temp = 0.000000005957897595 * localairflow ^ 2 + 0.000041615000879843 * localairflow - 0.026197898153767

            Case Else
                Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                Stop
        End Select


        Return temp
    End Function
    Private Function HeatAdjustmentS40(localairflow As Double, HeatType As String) As Double
        Dim temp As Double
        temp = 0
        Select Case HeatType
            Case Is = "267 MBH Gas"
                temp = 0.000000000045230018 * localairflow ^ 2 + 0.000016690769505445 * localairflow + 0.00391358685949035
            Case Is = "512 MBH Gas"
                temp = 0.00000000012464986 * localairflow ^ 2 + 0.000033007843137255 * localairflow + 0.00683893557422991
            Case Is = "800 MBH Gas"
                temp = 0.000000000565826331 * localairflow ^ 2 + 0.000044292156862746 * localairflow + 0.0281134453781461
            Case Is = "40kW"
                temp = 0.000000001793393445 * localairflow ^ 2 - 0.000010162620491973 * localairflow + 0
            Case Is = "CoolOnly"
                temp = 0
            Case Else
                Stop
        End Select
        Return temp
    End Function
    Private Function FilterAdjustmentS40(localairflow As Double, FilterType As String) As Double
        Dim temp As Double
        temp = 0
        Select Case FilterType
            Case Is = "2 inch"
                temp = 0
            Case Is = "6 inch 65%"
                temp = 0.000000001379551821 * localairflow ^ 2 + 0.00001543137254902 * localairflow - 0.0229061624649872

            Case Is = "6 inch 95%"
                temp = 0.000000003056722689 * localairflow ^ 2 + 0.000035946078431373 * localairflow - 0.065574229691881

            Case Else
                Stop
        End Select
        Return temp
    End Function
    Private Function EconAdjustmentS40(localairflow As Double, PwrExhaust As Boolean) As Double
        Dim temp As Double
        temp = 0
        temp = 0.00000000102818074 * localairflow ^ 2 + 0.000006264160698265 * localairflow - 0.0137124408862109

        If PwrExhaust Then
            temp = temp + 0.00000000125210084 * localairflow ^ 2 + 0.000000086274509804 * localairflow + 0.00129971988795416
        End If


        Return temp
    End Function

    Private Sub cmdS20BottomSupply_Click(sender As Object, e As EventArgs) Handles cmdS20BottomSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim FactoryOptions As Double

        Dim econyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureS20(airflow, True)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS20(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        'Nothing on a series 20 !!!

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS20(airflow, econyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS20BottomSupply.Enabled = False
    End Sub
    Private Sub BOMCodesSupplyFan()
        Dim dummy As MsgBoxResult
        Select Case cmbFanSelected.Text
            Case Is = "Comefri ATZAF_12-12_FF_T1"
                frmMain.ThisUnitCodes.Add("320A01")
            Case Is = "Comefri ATZAF_22-22_FF_T1"
                frmMain.ThisUnitCodes.Add("320A02")
            Case Is = "Comefri ATZAF_15-15_FF_T1"
                frmMain.ThisUnitCodes.Add("320A03")
            Case Is = "Comefri ATZAF_18-18_FF_T1"
                frmMain.ThisUnitCodes.Add("320A04")
            Case Is = "Comefri ATZAF_20-20_FF_T1"
                frmMain.ThisUnitCodes.Add("320A05")
            Case Is = "Comefri ATZAF_12-12_FF_T2"
                frmMain.ThisUnitCodes.Add("320A06")
            Case Is = "Comefri ATZAF_22-22_FF_T2"
                frmMain.ThisUnitCodes.Add("320A07")
            Case Is = "Comefri ATZAF_15-15_FF_T2"
                frmMain.ThisUnitCodes.Add("320A08")
            Case Is = "Comefri ATZAF_18-18_FF_T2"
                frmMain.ThisUnitCodes.Add("320A09")
            Case Is = "Comefri ATZAF_20-20_FF_T2"
                frmMain.ThisUnitCodes.Add("320A0A")
            Case Else
                dummy = MsgBox("Fan not defined for BOM.  Please Add and Rerun.")
                Stop
        End Select
    End Sub

    Private Sub optReuseMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optReuseMotor.CheckedChanged
        If optReuseMotor.Checked = True Then
            cmbNewMotorHP.Text = "n/a"
        End If
    End Sub

    Private Sub optReuseVFD_CheckedChanged(sender As Object, e As EventArgs) Handles optReuseVFD.CheckedChanged
        If optReuseMotor.Checked = True Then
            cmbNewMotorHP.Text = "n/a"
        End If
    End Sub

    Private Sub cmdBlankInlet_Click(sender As Object, e As EventArgs) Handles cmdBlankInlet.Click
        txtInPWL63.Text = "-"
        txtInPWL125.Text = "-"
        txtInPWL250.Text = "-"
        txtInPWL500.Text = "-"
        txtInPWL1k.Text = "-"
        txtInPWL2k.Text = "-"
        txtInPWL4k.Text = "-"
        txtInPWL8k.Text = "-"
        txtIndBW.Text = "-"
        txtIndBA5.Text = "-"

    End Sub

    Private Sub cmdPasteOutlet_Click(sender As Object, e As EventArgs) Handles cmdPasteOutlet.Click
        Dim SoundClip As String
        Dim i As Integer

        Dim mystart As Integer
        Dim thisslash As Integer
        Dim datstop As Integer
        Dim datstart As Integer
        Dim dat(11) As String
        Dim Fan As String

        Fan = cmbFanSelected.Text

        If optComefri.Checked = True And Fan.StartsWith("Comefri") Then
            If My.Computer.Clipboard.ContainsText Then
                SoundClip = " " & My.Computer.Clipboard.GetText
            Else
                SoundClip = "XX"
                Exit Sub
            End If

            mystart = 1
            If SoundClip <> "XX" Then

                For i = 1 To 9


                    thisslash = InStr(SoundClip, "/")
                    datstop = thisslash - 1
                    datstart = InStrRev(SoundClip, " ", datstop - 1)
                    dat(i) = Trim(Mid(SoundClip, datstart, datstop - datstart + 1))

                    SoundClip = Mid(SoundClip, datstop + 2)
                Next

            End If
        ElseIf optComefri.Checked = True And Fan.StartsWith("AFK") Then
            MessageBox.Show("Are you sure you have a Comefri fan?")
        Else
            If optContinental.Checked = True And Fan.StartsWith("AFK") Then
                If My.Computer.Clipboard.ContainsText Then
                    SoundClip = My.Computer.Clipboard.GetText
                Else
                    SoundClip = "XX"
                    Exit Sub
                End If
                For i = 1 To 9
                    datstop = InStr(SoundClip, " ") - 1
                    dat(i) = Trim(Mid(SoundClip, 1, datstop))
                    SoundClip = Mid(SoundClip, datstop + 2)
                Next
            ElseIf optContinental.Checked = True And Fan.StartsWith("Comefri") Then
                MessageBox.Show("Are you sure you have a Continental fan?")
            Else
                MessageBox.Show("Something isn't adding up. Verify your information is correct.")
            End If
        End If
        txtOutPWL63.Text = dat(1)
        txtOutPWL125.Text = dat(2)
        txtOutPWL250.Text = dat(3)
        txtOutPWL500.Text = dat(4)
        txtOutPWL1k.Text = dat(5)
        txtOutPWL2k.Text = dat(6)
        txtOutPWL4k.Text = dat(7)
        txtOutPWL8k.Text = dat(8)
        txtOutdBW.Text = dat(9)
        txtOutdBA5.Text = Trim(SoundClip)


    End Sub

    Private Sub cmdPasteInlet_Click(sender As Object, e As EventArgs) Handles cmdPasteInlet.Click
        Dim SoundClip As String
        Dim i As Integer

        Dim mystart As Integer
        Dim thisslash As Integer
        Dim datstop As Integer
        Dim datstart As Integer
        Dim dat(11) As String
        Dim Fan As String

        Fan = cmbFanSelected.Text

        If optComefri.Checked = True And Fan.StartsWith("Comefri") Then
            If My.Computer.Clipboard.ContainsText Then
                SoundClip = " " & My.Computer.Clipboard.GetText
            Else
                SoundClip = "XX"
            End If

            mystart = 1
            If SoundClip <> "XX" Then

                For i = 1 To 9


                    thisslash = InStr(SoundClip, "/")
                    datstop = thisslash - 1
                    datstart = InStrRev(SoundClip, " ", datstop - 1)
                    dat(i) = Trim(Mid(SoundClip, datstart, datstop - datstart + 1))

                    SoundClip = Mid(SoundClip, datstop + 2)
                Next

            End If
        ElseIf optComefri.Checked = True And Fan.StartsWith("AFK") Then
            MessageBox.Show("Are you sure you have a Comefri fan?")
        Else
            If optContinental.Checked = True And Fan.StartsWith("AFK") Then
                If My.Computer.Clipboard.ContainsText Then
                    SoundClip = My.Computer.Clipboard.GetText
                Else
                    SoundClip = "XX"
                    Exit Sub
                End If
                For i = 1 To 9
                    datstop = InStr(SoundClip, " ") - 1
                    dat(i) = Trim(Mid(SoundClip, 1, datstop))
                    SoundClip = Mid(SoundClip, datstop + 2)

                Next
            ElseIf optContinental.Checked = True And Fan.StartsWith("Comefri") Then
                MessageBox.Show("Are you sure you have a Continental fan?")
            Else
                MessageBox.Show("Something isn't adding up. Verify your information is correct.")
            End If
        End If
        txtInPWL63.Text = dat(1)
        txtInPWL125.Text = dat(2)
        txtInPWL250.Text = dat(3)
        txtInPWL500.Text = dat(4)
        txtInPWL1k.Text = dat(5)
        txtInPWL2k.Text = dat(6)
        txtInPWL4k.Text = dat(7)
        txtInPWL8k.Text = dat(8)
        txtIndBW.Text = dat(9)
        txtIndBA5.Text = Trim(SoundClip)
    End Sub

    Private Sub chkInletMeasuringStationOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkInletMeasuringStationOnly.CheckedChanged
        If chkInletMeasuringStationOnly.Checked = True Then
            chkInletMeasuringStationWithXMit.Checked = False
            chkInletMeasuringStationFull.Checked = False
        End If
    End Sub

    Private Sub chkInletMeasuringStationWithXMit_CheckedChanged(sender As Object, e As EventArgs) Handles chkInletMeasuringStationWithXMit.CheckedChanged
        If chkInletMeasuringStationWithXMit.Checked = True Then
            chkInletMeasuringStationOnly.Checked = False
            chkInletMeasuringStationFull.Checked = False
        End If
    End Sub

    Private Sub chkInletMeasuringStationFull_CheckedChanged(sender As Object, e As EventArgs) Handles chkInletMeasuringStationFull.CheckedChanged
        If chkInletMeasuringStationFull.Checked = True Then
            chkInletMeasuringStationOnly.Checked = False
            chkInletMeasuringStationWithXMit.Checked = False
        End If
    End Sub

    Private Sub chkRFPiezoRingsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkRFPiezoRingsOnly.CheckedChanged
        If chkRFPiezoRingsOnly.Checked = True Then
            chkRFPiezoRingsXmitterOnly.Checked = False
            chkRFPiezoRingsNet.Checked = False
        End If
    End Sub

    Private Sub chkRFPiezoRingsXmitterOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkRFPiezoRingsXmitterOnly.CheckedChanged
        If chkRFPiezoRingsXmitterOnly.Checked = True Then
            chkRFPiezoRingsOnly.Checked = False
            chkRFPiezoRingsNet.Checked = False
        End If
    End Sub

    Private Sub chkRFPiezoRingsNet_CheckedChanged(sender As Object, e As EventArgs) Handles chkRFPiezoRingsNet.CheckedChanged
        If chkRFPiezoRingsNet.Checked = True Then
            chkRFPiezoRingsOnly.Checked = False
            chkRFPiezoRingsXmitterOnly.Checked = False
        End If
    End Sub

    Private Sub btnbhpeachWiz_Click(sender As Object, e As EventArgs) Handles btnbhpeachWiz.Click
        If txtFanbhp.Text = "" Then
            txtFanbhp.Text = Format((Val(txtFanbhpeach.Text) * nudFanCount.Value), "0.0")
        End If

        If txtFanbhpeach.Text = "" Then
            txtFanbhpeach.Text = Format((Val(txtFanbhp.Text) / nudFanCount.Value), "0.0")
        End If

    End Sub

    Private Sub txtESP_Leave(sender As Object, e As EventArgs) Handles txtESP.Leave
        If Val(txtElevation.Text) > 0 Then
            chkESPatElev.Checked = True
        End If
    End Sub

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub
End Class