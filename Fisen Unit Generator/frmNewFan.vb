Imports System.Xml
Public Class frmNewFan
    Private pCancelled As Boolean
    Private pFanStyle As String
    Private ModuleCodeList As New ArrayList
    Private pResearchMode

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
    Public Property ResearchMode As Boolean
        Get
            Return pResearchMode
        End Get
        Set(value As Boolean)
            pResearchMode = value
        End Set
    End Property
    Private Sub SetupResearchMode()
        'This line commented out because of the unique nature of NewFan
        'Me.Text = Me.Text & " ***Research Mode***"
        btnOK.Text = "Research Mode"
        chkWriteHistory.Checked = False
        chkWriteHistory.Enabled = False
    End Sub

    Private Sub frmNewFan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFamily As String
        Dim dummy As MsgBoxResult

        'If the user is SUPER! then alow mid operation fan list refreshes.
        If SuperUser() Then
            cmdRefreshFanList.Visible = True
            cmdCreateNewFan.Visible = True

        End If

        If pResearchMode Then Call SetupResearchMode()

        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True


        If frmMain.HasHMI Then
            chkIncludeEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Enabled = False
        End If

        If frmMain.HasUMHMI Then
            chkMountEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Enabled = False
        End If

        If frmMain.ThisUnitElecData.DPPPresent Then
            grpDPPCkt.Visible = True
            optDPPNA.Enabled = False
            optDPPEmergency.Checked = True
        End If


        lFamily = frmMain.ThisUnit.Family

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
            chkReheatCoil.Visible = True
            chkPwrExhaustPresent.Visible = True
            optAFFan.Checked = True
            chkReliefHoodsShipLoose.Visible = False
            chkHeatBaffles.Visible = True

            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    opt1InchFilters.Checked = True
                    cmdS5BottomSupply.Visible = True
                    lblNote1.Text = "An ALTI 9-9R has been successfully used."

                Case Is = "Series10"
                    cmdS10BottomSupply.Visible = True
                    cmdS10SideSupply.Visible = True
                    lblNote1.Text = "Preferred Max Fan ATZAF12-12FF"
                Case Is = "Series12"

                Case Is = "Series20"
                    cmdS20SideSupply.Visible = True
                    cmdS20BottomSupply.Visible = True
                    lblNote1.Text = "Preferred Max Fan ATZAF18-18FF (ATZAF20-20FF is Possible)"
                Case Is = "Series40"
                    'Depricated *Probably not going to be used*
                    cmdS40Supply.Visible = True
                    lblNote1.Text = "An ATZAF22-22FF has been successfully used."
                Case Is = "Series100"

                Case Is = "Premier"
                    cmdPremierBottomSupply.Visible = True
                    cmdPremierRearSupply.Visible = True

                Case Is = "Choice"
                    cmdChoiceBottomSupply.Visible = True
                    cmdChoiceRearSupply.Visible = True
                    chkFisen2Rear.Visible = True
                    lblNote1.Text = "Preferred Size is 18-18 for 25+ Tons and 15-15 for 20- Tons"

                Case Is = "Select"
                    cmdSelectBottomSupply.Visible = True
                    cmdSelectRearSupply.Visible = True


                Case Is = "SeriesLX"
                    cmdLXBottomSupply.Visible = True
                    cmdLXRearSupply.Visible = True

                Case Else
                    dummy = MsgBox("The Family " & frmMain.ThisUnit.Family & " is not recognized in this module.  Aborting.", vbOKOnly, "Fisen Unit Generator")
                    Stop
            End Select

            Select Case frmMain.ThisUnitHeatPerf.HeatType
                Case Is = "Gas Heat"
                    cmbHeatBox.Text = "Gas"
                Case Is = "Electric"
                    cmbHeatBox.Text = "72kW"
                Case Is = "None"
                    cmbHeatBox.Text = "CoolOnly"
                Case Else
                    cmbHeatBox.Text = "Not Selected"
            End Select

            For i = 0 To frmMain.ThisUnitFactOpts.Count - 1
                If frmMain.ThisUnitFactOpts.Item(i) = "4" & """" & " MERV 13 Filters" Then opt4InchFilters.Checked = True
                If InStr(frmMain.ThisUnitFactOpts.Item(i), "Economizer") > 0 Then chkEconPresent.Checked = True
                If InStr(frmMain.ThisUnitFactOpts.Item(i), "Exhaust") > 0 Then chkPwrExhaustPresent.Checked = True
            Next i

            ModuleCodeList.Add("320100")
        End If
        If pFanStyle = "Return Fan" Then
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"

                Case Is = "Series10"
                    cmdS10BottomReturn.Visible = True
                    cmdS10SideReturn.Visible = True
                    lblNote1.Text = "DNE fan Is a Continental AFK 16In Fan (2hp max).  14In fan Is preferred (2hp max)."
                    chkS10BottomRAMonitor.Visible = True

                    chkInletMeasuringStationOnly.Visible = True
                    chkInletMeasuringStationWithXMit.Visible = True
                    chkInletMeasuringStationFull.Visible = True
                Case Is = "Series12"

                Case Is = "Series20"
                    cmdS20BottomReturn.Visible = True
                    cmdS20SideReturn.Visible = True
                    lblNote1.Text = "DNE fan Is a Continental AFK 27In Fan (5hp max).  24In Is preferred (2hp max)."
                Case Is = "Series40"
                    'Depricated *Probably not going to be used*
                    cmdS40EndReturn.Visible = True
                    cmdS40BottomReturn.Visible = True
                    lblNote1.Text = "Preferred Max Fan NAPAF18 (2)"
                    chkRFPiezoRingsOnly.Visible = True
                    chkRFPiezoRingsXmitterOnly.Visible = True
                    chkRFPiezoRingsNet.Visible = True
                Case Is = "Series100"
                    cmdS100BEndReturn.Visible = True
                Case Is = "Premier"

                Case Is = "Choice"

                Case Is = "Select"
                    cmdSeltectEndReturn.Visible = True
                Case Else

            End Select
            ModuleCodeList.Add("330100")
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
                 'Depricated *Probably not going to be used*
            Case Is = "Series100"

            Case Is = "Premier"

            Case Is = "Choice"

            Case Is = "Select"

            Case Else

        End Select

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()

        tslblAirflow.Text = "Airflow:" & txtAirflow.Text
        tslblTSP.Text = "TSP: " & "TBD"
        tslblESP.Text = "ESP: " & txtESP.Text
        tslblElevation.Text = "Elevation: " & txtElevation.Text

        cmbNewMotorHP.Text = "n/a"

    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/SFan")

        If cmbFanType.Text = "Return Fan" Then xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/RFan")
        If cmbFanType.Text = "Exhaust Fan" Then xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/XFan")

        TempVal = xNodeRoot.SelectSingleNode("FlowConfig").InnerText
        If TempVal = "Downflow" Then optDownFlow.Checked = True Else optHorizFlow.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("Isolation").InnerText
        If TempVal = "None" Then optIsoNone.Checked = True
        If TempVal = "1 inch" Then optIso1.Checked = True
        If TempVal = "2 inch" Then optIso2.Checked = True

        txtAirflow.Text = xNodeRoot.SelectSingleNode("Airflow").InnerText
        txtESP.Text = xNodeRoot.SelectSingleNode("ESP").InnerText
        txtElevation.Text = xNodeRoot.SelectSingleNode("Elevation").InnerText

    End Sub
    Private Sub PopulateAuxPanelList()
        'Added Initial LX Series Support
        'V1.1 Added Check for it already existing
        If frmMain.HasAuxillaryPanel = True Then
            optUseAux.Checked = True
            fraAuxPanel.Enabled = False
            cmbAuxPanelOpts.Items.Clear()
            cmbAuxPanelOpts.Items.Add("Selected in Other Module")
            cmbAuxPanelOpts.Text = "Selected in Other Module"
        Else
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
                    Case Is = "SeriesLX"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("LX Series Custom Application")
                        cmbAuxPanelOpts.Text = "LX Series Custom Application"
                    Case Is = "Series40"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 40 Custom Application")
                        cmbAuxPanelOpts.Text = "Series 40 Custom Application"
                    Case Is = "Series100"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 100 Custom Application")
                        cmbAuxPanelOpts.Text = "Series 100 Custom Application"
                    Case Is = "Premier"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Premier Cabinet Custom Application")
                        cmbAuxPanelOpts.Text = "Premier Cabinet Custom Application"
                    Case Is = "Choice"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Choice Cabinet Custom Application")
                        cmbAuxPanelOpts.Text = "Choice Cabinet Custom Application"
                    Case Is = "Select"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Select Cabinet Custom Application")
                        cmbAuxPanelOpts.Text = "Select Cabinet Custom Application"
                End Select
            End If
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

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        cmbFanSelected.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        MySQL = ""
        If pFanStyle = "Supply Fan" Then MySQL = "SELECT * FROM tblFanCurves WHERE SupplyFan=TRUE ORDER BY FanID"
        If pFanStyle = "Return Fan" Then MySQL = "SELECT * FROM tblFanCurves WHERE ReturnFan=TRUE ORDER BY FanID"
        If pFanStyle = "Exhaust Fan" Then MySQL = "SELECT * FROM tblFanCurves WHERE ExhaustFan=TRUE ORDER BY FanID"

        rs.Open(MySQL, con)

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
        If pFanStyle = "Exhaust Fan" Then

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
        ModuleCodeList.Clear()

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



        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                If frmMain.HasUMHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
                End If
            Else
                If frmMain.HasHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960001") 'Adds an HMI
                End If
            End If
        End If

        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert

        Call PerformDesignCautionScan()

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

        Me.Hide()
    End Sub

    Private Sub AuxPanelCodeInsert() 'Called from near the end of UpdateCode()
        'V1.1 - Added Custom Option for LX Series Units.
        'V1.0
        If ((optUseAux.Checked = True) And (frmMain.HasAuxillaryPanel = False)) Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
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
                Case Is = "LX Series Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960027")
                Case Is = "Series 100 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960023")
                Case Is = "Premier Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960024")
                Case Is = "Choice Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960025")
                Case Is = "Select Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960026")
            End Select
        End If
    End Sub

    Private Sub WriteSFanHistory()
        'Updated to version 2.0 29 April 2020
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String

        'next dim the module specific
        Dim rqAF, RQESP, TSP, Fan, FanQ, Fanbhpea, systembhp, motorhpea, systemhp As String

        Dim MySQL As String
        Dim ExistingRecordID As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text
        modnum = frmMain.txtModelNumber.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rqAF = txtAirflow.Text
        RQESP = txtESP.Text
        TSP = txtTSP.Text
        Fan = cmbFanSelected.Text
        FanQ = nudFanCount.Value
        Fanbhpea = txtFanbhp.Text / FanQ
        systembhp = txtFanbhp.Text
        motorhpea = frmMain.ThisUnitSFanPerf.MotorHP / FanQ
        systemhp = frmMain.ThisUnitSFanPerf.MotorHP

        MySQL = "Select * FROM tblHistorySFan WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistorySFan SET Airflow='" & rqAF & "', ESP='" & RQESP & "', " & "TSP='" & TSP & "', Fan='" & Fan & "', FanQ='" & FanQ & "', FanBHPea='" & Fanbhpea & "', SystemBHP='" & systembhp & "', MotorHPea='" & motorhpea & "', SystemHP='" & systemhp & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistorySFan (JobName, UnitID, Version, ModelNumber, Airflow, ESP, TSP, Fan, FanQ, FanBHPea, SystemBHP, MotorHPea, SystemHP) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & rqAF & "','" & RQESP & "','" & TSP & "','" & Fan & "','" & FanQ & "','" & Fanbhpea & "','" & systembhp & "','" & motorhpea & "','" & systemhp & "')"
            con.Execute(MySQL)
        End If

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
        ModuleCodeList.Add("350100") 'Exhaust Fan Level 1 Code

        'handle the fan type
        If optFCFan.Checked Then ModuleCodeList.Add("350101")
        If optAFFan.Checked Then ModuleCodeList.Add("350102")
        If optPlenumFan.Checked Then ModuleCodeList.Add("350103")
        If optPropFan.Checked Then ModuleCodeList.Add("350104")

        ''handle the drive
        'If optBeltDrive.Checked Then
        '    ModuleCodeList.Add("330120") ' belt drive spec
        '    If optCVSystem.Checked Then
        '        ModuleCodeList.Add("330121") 'sheaves for motorstarter
        '    Else
        '        ModuleCodeList.Add("330122") 'sheaves for VFD
        '    End If
        'Else
        '    ModuleCodeList.Add("330110") 'direct drive spec
        'End If

        'If chkMultipleFans.Checked Then ModuleCodeList.Add("330119")

        ''handle the isolation
        'If optIsoNone.Checked Then ModuleCodeList.Add("330130")
        'If optIso1.Checked Then ModuleCodeList.Add("330131")
        'If optIso2.Checked Then ModuleCodeList.Add("330132")

        ''handle the starter type
        'If optCVSystem.Checked Then
        '    ModuleCodeList.Add("330140") 'motorstarter discussion code / ol relay
        'Else
        '    If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
        '        ModuleCodeList.Add("330141") 'vfd rplace
        '        If frmMain.ThisUnit.Family = "Series100" Then
        '            ModuleCodeList.Add("330201")
        '        Else
        '            ModuleCodeList.Add("330202")
        '        End If
        '    Else
        '        ModuleCodeList.Add("330142") 'reuse vfd
        '    End If

        '    If optNoBypass.Checked Then ModuleCodeList.Add("330145")
        '    If optReuseBypass.Checked Then ModuleCodeList.Add("330146")
        '    If optNewBypass.Checked Then ModuleCodeList.Add("330147")
        '    If chkRemoteVFDKeypad.Checked Then
        '        ModuleCodeList.Add("330148")
        '    End If
        'End If

        ''handle the motor
        'If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
        '    ModuleCodeList.Add("330150") 'provide new motor

        '    If optTEFC.Checked Then ModuleCodeList.Add("330152")
        '    If optODP.Checked Then ModuleCodeList.Add("330151")
        'Else
        '    ModuleCodeList.Add("330155") 'reuse existing motor
        'End If

        'If chkMultipleFans.Checked Then ModuleCodeList.Add("330159")

        'ModuleCodeList.Add("330160") 'Return Fan Controls
        'If optNoControls.Checked Then
        '    ModuleCodeList.Add("330161") 'Return Fan NO Controls
        '    ModuleCodeList.Add("330162") 'On/Off Only
        'Else
        '    If optTrackSupplyFan.Checked Then ModuleCodeList.Add("330165")
        '    If optGBASRFan.Checked Then
        '        ModuleCodeList.Add("330170") 'GBAS Return Fan
        '        ModuleCodeList.Add("330171") 'GBAS Actuated Dampers
        '    End If
        '    If optBldgStaticPressureCtrl.Checked Then
        '        ModuleCodeList.Add("330180") 'General Building Static PRessure Control Statement
        '        If optBSPbySE.Checked Then ModuleCodeList.Add("330181") 'SE Econ Return Fan
        '        If optBSPbyFisen.Checked Then ModuleCodeList.Add("330182") 'Fisen Ctrl Return Fan
        '        If optBSPbyIPU.Checked Then
        '            ModuleCodeList.Add("330185") 'IPU Ctrl of Return Fan
        '            If chkIPUModulateDamper.Checked Then
        '                ModuleCodeList.Add("330186") 'IPU modulate relief damper
        '            End If
        '        End If
        '    End If

        'End If
        'If optNoRelief.Checked Then ModuleCodeList.Add("330190")
        'If optBaroRelief.Checked Then
        '    ModuleCodeList.Add("330191")
        '    If chkReliefHoodsShipLoose.Checked Then ModuleCodeList.Add("330194") Else ModuleCodeList.Add("330193")
        'End If
        'If optControlRelief.Checked Then
        '    ModuleCodeList.Add("330192")
        '    If chkReliefHoodsShipLoose.Checked Then ModuleCodeList.Add("330194") Else ModuleCodeList.Add("330193")
        'End If

        'If chk65kASCCRBase.Checked Then
        '    ModuleCodeList.Add("350F6A")
        'End If

    End Sub
    Private Sub UpdateCodeListRFan()

        'Add the level 0 code(s)
        ModuleCodeList.Add("330100") 'Supply Fan Level 1 Code
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series10"
                ModuleCodeList.Add("330910")
            Case Is = "Series20"
                ModuleCodeList.Add("330920")
            Case Is = "Series40"
                ModuleCodeList.Add("330940")
            Case Is = "Series100"
                ModuleCodeList.Add("330990")
        End Select


        'handle the fan type
        If optFCFan.Checked Then
            ModuleCodeList.Add("330101")
        End If
        If optAFFan.Checked Then
            ModuleCodeList.Add("330102")
        End If
        If optPlenumFan.Checked Then
            ModuleCodeList.Add("330103")
        End If
        If optPropFan.Checked Then
            ModuleCodeList.Add("330104")
        End If
        'handle the drive
        If optBeltDrive.Checked Then
            ModuleCodeList.Add("330120") ' belt drive spec
            If optCVSystem.Checked Then
                ModuleCodeList.Add("330121") 'sheaves for motorstarter
            Else
                ModuleCodeList.Add("330122") 'sheaves for VFD
            End If
        Else
            ModuleCodeList.Add("330110") 'direct drive spec
        End If

        If chkMultipleFans.Checked Then
            ModuleCodeList.Add("330119")
        End If
        'handle the isolation
        If optIsoNone.Checked Then
            ModuleCodeList.Add("330130")
        End If
        If optIso1.Checked Then
            ModuleCodeList.Add("330131")
        End If
        If optIso2.Checked Then
            ModuleCodeList.Add("330132")
        End If

        'handle the starter type
        If optCVSystem.Checked Then
            ModuleCodeList.Add("330140") 'motorstarter discussion code / ol relay
        Else
            If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
                ModuleCodeList.Add("330141") 'vfd rplace
                If frmMain.ThisUnit.Family = "Series100" Then
                    ModuleCodeList.Add("330201")
                Else
                    ModuleCodeList.Add("330202")
                End If
            Else
                ModuleCodeList.Add("330142") 'reuse vfd
            End If

            If optNoBypass.Checked Then
                ModuleCodeList.Add("330145")
            End If

            If optReuseBypass.Checked Then
                ModuleCodeList.Add("330146")
            End If
            If optNewBypass.Checked Then
                ModuleCodeList.Add("330147")
            End If
            If chkRemoteVFDKeypad.Checked Then
                ModuleCodeList.Add("330148")
            End If
        End If

        'handle the motor
        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            ModuleCodeList.Add("330150") 'provide new motor

            If optTEFC.Checked Then
                ModuleCodeList.Add("330152")
            End If
            If optODP.Checked Then
                ModuleCodeList.Add("330151")
            End If
        Else
            ModuleCodeList.Add("330155") 'reuse existing motor
        End If

        If chkMultipleFans.Checked Then
            ModuleCodeList.Add("330159")
        End If

        ModuleCodeList.Add("330160") 'Return Fan Controls
        If optNoControls.Checked Then
            ModuleCodeList.Add("330161") 'Return Fan NO Controls
            ModuleCodeList.Add("330162") 'On/Off Only
        Else
            If optTrackSupplyFan.Checked Then
                ModuleCodeList.Add("330165")
            End If
            If optGBASRFan.Checked Then
                ModuleCodeList.Add("330170") 'GBAS Return Fan
                ModuleCodeList.Add("330171") 'GBAS Actuated Dampers
            End If
            If optBldgStaticPressureCtrl.Checked Then
                ModuleCodeList.Add("330180") 'General Building Static PRessure Control Statement
                If optBSPbySE.Checked Then
                    ModuleCodeList.Add("330181") 'SE Econ Return Fan
                End If
                If optBSPbyFisen.Checked Then
                    ModuleCodeList.Add("330182") 'Fisen Ctrl Return Fan
                End If
                If optBSPbyIPU.Checked Then
                    ModuleCodeList.Add("330185") 'IPU Ctrl of Return Fan
                    If chkIPUModulateDamper.Checked Then
                        ModuleCodeList.Add("330186") 'IPU modulate relief damper
                    End If
                End If
            End If

        End If
        If chkRFPiezoRingsOnly.Checked Then
            ModuleCodeList.Add("330169")
        End If
        If chkRFPiezoRingsXmitterOnly.Checked Then
            ModuleCodeList.Add("330168")
        End If
        If chkRFPiezoRingsNet.Checked Then
            ModuleCodeList.Add("330167")
        End If

        If frmMain.ThisUnit.Family = "Series10" Then
            If chkInletMeasuringStationOnly.Checked Then
                ModuleCodeList.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016H") 'No Change to sequence code.
            End If
            If chkInletMeasuringStationWithXMit.Checked Then
                ModuleCodeList.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016B") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016G") 'Return Fan Terminal Blocks
                ModuleCodeList.Add("33016H") 'No Change to sequence code.
            End If
            If chkInletMeasuringStationFull.Checked Then
                ModuleCodeList.Add("33016A") 'Series 10 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016B") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016C") 'Return Fan Airflow Monitor Wired to Fisen Controller
            End If
        End If
        If frmMain.ThisUnit.Family = "Series20" Then
            If chkInletMeasuringStationOnly.Checked Then
                ModuleCodeList.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016H") 'No Change to sequence code.
            End If
            If chkInletMeasuringStationWithXMit.Checked Then
                ModuleCodeList.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016E") 'Return Fan Airflow Monitor Wired to Fisen Controller
                ModuleCodeList.Add("33016G") 'Return Fan Terminal Blocks
                ModuleCodeList.Add("33016H") 'No Change to sequence code.
            End If
            If chkInletMeasuringStationFull.Checked Then
                ModuleCodeList.Add("33016D") 'Series 20 Return Fan(Bottom Return) Airflow Measuring Station
                ModuleCodeList.Add("33016E") 'Return Fan Airflow Transducer
                ModuleCodeList.Add("33016F") 'Return Fan Airflow Monitor Wired to Fisen Controller
            End If
        End If



        If optNoRelief.Checked Then
            ModuleCodeList.Add("330190")
        End If
        If optBaroRelief.Checked Then
            ModuleCodeList.Add("330191")
            If chkReliefHoodsShipLoose.Checked Then ModuleCodeList.Add("330194") Else ModuleCodeList.Add("330193")
        End If
        If optControlRelief.Checked Then
            ModuleCodeList.Add("330192")
            If chkReliefHoodsShipLoose.Checked Then
                ModuleCodeList.Add("330194")
            Else
                ModuleCodeList.Add("330193")
            End If
        End If

        If optHorizFlow.Checked Then
            If frmMain.ThisUnit.Family = "Series10" Then
                ModuleCodeList.Add("330310")
                ModuleCodeList.Add("330311")
                ModuleCodeList.Add("330312")
                ModuleCodeList.Add("330313")
                ModuleCodeList.Add("330324")
                ModuleCodeList.Add("330325")
            End If

            If frmMain.ThisUnit.Family = "Series20" Then
                ModuleCodeList.Add("330320")
                ModuleCodeList.Add("330321")
                ModuleCodeList.Add("330322")
                ModuleCodeList.Add("330313")
                ModuleCodeList.Add("330323")
                ModuleCodeList.Add("330325")
            End If

        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("330F6A")
        End If


        'handle the commnodes
        If Not ((chkRFPiezoRingsNet.Checked) Or (chkInletMeasuringStationFull.Checked)) Then
            frmMain.ThisUnit.CommNodes = "2"
        End If

    End Sub
    Private Sub UpdateCodeListSFan()
        'Add the level 0 code(s)
        ModuleCodeList.Add("320100") 'Supply Fan Level 0 Code

        'handle the fan type
        If optFCFan.Checked Then ModuleCodeList.Add("320101")
        If optAFFan.Checked Then ModuleCodeList.Add("320102")
        If optPlenumFan.Checked Then ModuleCodeList.Add("320103")
        If optPropFan.Checked Then ModuleCodeList.Add("320104")
        Call BOMCodesSupplyFan()


        'handle the drive
        If optBeltDrive.Checked Then
            ModuleCodeList.Add("320120") ' belt drive spec
            If optCVSystem.Checked Then
                ModuleCodeList.Add("320121") 'sheaves for motorstarter
            Else
                ModuleCodeList.Add("320122") 'sheaves for VFD
            End If
        Else
            ModuleCodeList.Add("320110") 'direct drive spec
        End If

        'handle the isolation
        If optIsoNone.Checked Then ModuleCodeList.Add("320130")
        If optIso1.Checked Then ModuleCodeList.Add("320131")
        If optIso2.Checked Then ModuleCodeList.Add("320132")

        'handle the starter type
        If optCVSystem.Checked Then
            ModuleCodeList.Add("320140") 'motorstarter discussion code / ol relay
        Else
            If ((optReplaceVFD.Checked) Or (optNewVFD.Checked)) Then
                ModuleCodeList.Add("320141") 'vfd rplace
                If chkRetainVFD.Checked Then ModuleCodeList.Add("320F01")
                If optReplaceVFD.Checked Then ModuleCodeList.Add("320F02")
            Else
                ModuleCodeList.Add("320142") 'reuse vfd
            End If
            If optNoBypass.Checked Then ModuleCodeList.Add("320145")
            If optReuseBypass.Checked Then ModuleCodeList.Add("320146")
            If optNewBypass.Checked Then ModuleCodeList.Add("320147")
            If chkRemoteVFDKeypad.Checked Then
                ModuleCodeList.Add("320148")
            End If
        End If

        'handle the motor
        If ((optReplaceMotor.Checked) Or (optNewMotor.Checked)) Then
            ModuleCodeList.Add("320150") 'provide new motor
            If chkRetainMotor.Checked Then ModuleCodeList.Add("320F00")
            If optReplaceMotor.Checked Then ModuleCodeList.Add("320F03")
            If optTEFC.Checked Then ModuleCodeList.Add("320152")
            If optODP.Checked Then ModuleCodeList.Add("320151")
            If ((frmMain.ThisUnit.Family = "Series10") And (Val(cmbNewMotorHP.Text) > 5)) Then
                ModuleCodeList.Add("320158")
            End If

        Else
            ModuleCodeList.Add("320155") 'reuse existing motor
        End If

        'Handle the controls
        ModuleCodeList.Add("320200")
        ModuleCodeList.Add("320205") 'No Controls Changes
        If chkSFanROPiezo.Checked Then
            ModuleCodeList.Add("320241")
        End If
        If chkSFanROandXmitPiezo.Checked Then
            ModuleCodeList.Add("320242")
        End If
        If chkSFanNetPointPiezo.Checked Then
            ModuleCodeList.Add("320243")
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("320F6A")
        End If

        If chkHeatBaffles.Checked Then
            ModuleCodeList.Add("320C01")
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
                Case Is = "Choice"
                    tempWeight = "51"
                Case Is = "Select"
                Case Is = "Premier"
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
                Case Is = "Select"

                    If optHorizFlow.Checked Then
                        tempWeight = "756"
                    Else
                        tempWeight = "615"
                    End If
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

            motorhp = "1"
            If optReuseMotor.Checked Then
                motorhp = cmbExistingMotor.Text
            End If

            If optMotorTypeODP.Checked Or optMotorTypeTEFC.Checked Then
                motorhp = cmbNewMotorHP.Text
            End If

            If optMotorTypeIP54.Checked Then
                motorhp = txtIECMotorkW.Text
                frmMain.ThisUnitSFanPerf.MhpUnits = "kW"
                frmMain.ThisUnitSFanPerf.BhpUnits = "kW"
                frmMain.ThisUnitSFanPerf.MFLA = txtIECMotorFLA.Text
                If frmMain.UseCustomMCA = False Then
                    frmMain.UseCustomMCA = True
                    Call frmMain.PreLoadElec()
                End If

                ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
                MotorFLA = Format(txtIECMotorFLA.Text, "0.0")
                If optDPPCommercial.Checked Then
                    NewRow = {True, False, "All", True, "EC Motor Supply Fan", ElecChar, cmbNewMotorHP.Text, MotorFLA, False, "IEC Motor"}
                Else
                    NewRow = {True, False, "All", False, "EC Motor Supply Fan", ElecChar, cmbNewMotorHP.Text, MotorFLA, True, "IEC Motor"}
                End If
                frmMain.dgvElecLoads.Rows.Add(NewRow)
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
                MotorFLA = NEMAMotorFLA(cmbNewMotorHP.Text, frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase)

                NewRow = {True, False, "All", True, "RETURN FAN", ElecChar, cmbNewMotorHP.Text, MotorFLA, False, "NEMA"}
                frmMain.ThisUnitElecData.ModLoad.Add(NewRow)
                frmMain.chkUseCustomMCA.Checked = True
                Call frmMain.CalculateCustomMCA()
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
        Dim dummy As MsgBoxResult
        If ((optReuseMotor.Checked = False) Or (optReuseVFD.Checked = False)) Then
            If cmbNewMotorHP.Text = "n/a" Then
                dummy = MsgBox("You must select a new motor/drive horsepower.")
                Exit Sub
            End If
        End If

        If cmbNewMotorHP.Text = "Unselected" Then
            dummy = MsgBox("You must select a new motor/drive horsepower.")
            Exit Sub
        End If

        btnDonePerf.Enabled = False
        If Not (pResearchMode) Then btnOK.Enabled = True
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



        If frmMain.ThisUnitMFilters.FilterBankName <> "-" Then
            If chkESPatElev.Checked Then
                ItemAtATP = frmMain.ThisUnitMFilters.FStaticItem
                ItemAtSTP = Format(Val(frmMain.ThisUnitMFilters.FStaticItem) * Val(lblKFactor.Text), "0.00")
            Else
                ItemAtSTP = frmMain.ThisUnitMFilters.FStaticItem
                ItemAtATP = Format(Val(frmMain.ThisUnitMFilters.FStaticItem) / Val(lblKFactor.Text), "0.00")
            End If
            NewRow = {"Misc. Filter Bank", ItemAtSTP, ItemAtATP}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

        If frmMain.ThisUnitHeatPerf.HeatType = "Hot Water" Then
            If chkESPatElev.Checked Then
                ItemAtATP = frmMain.ThisUnitHeatPerf.CoilAPD
                ItemAtSTP = Format(Val(frmMain.ThisUnitHeatPerf.CoilAPD) * Val(lblKFactor.Text), "0.00")
            Else
                ItemAtSTP = frmMain.ThisUnitHeatPerf.CoilAPD
                ItemAtATP = Format(Val(frmMain.ThisUnitHeatPerf.CoilAPD) / Val(lblKFactor.Text), "0.00")
            End If
            NewRow = {"Hot Water Coil", ItemAtSTP, ItemAtATP}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

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

        tslblAirflow.Text = "Airflow:" & txtAirflow.Text
        tslblTSP.Text = "TSP: " & txtTSP.Text
        tslblESP.Text = "ESP: " & txtESP.Text
        tslblElevation.Text = "Elevation: " & txtElevation.Text

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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
    End Sub

    Private Sub cmdChoiceBottomSupply_Click(sender As Object, e As EventArgs) Handles cmdChoiceBottomSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim reheatmod As Double
        Dim FactoryOptions As Double
        Dim HeatBaffles As Double

        Dim econyesno, reheatyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureChoice(airflow, True)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentChoice(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        'Nothing on a series 20 !!!

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentChoice(airflow, econyesno)

        reheatyesno = chkReheatCoil.Checked
        reheatmod = ReheatAdjustmentChoice(airflow, reheatyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod + reheatmod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        If chkHeatBaffles.Checked Then
            HeatBaffles = 0.000000001331941323 * airflow * airflow - 0.000000563361120313 * airflow
            NewRow = {"Standard Heat Baffles", Format(HeatBaffles, "0.00"), Format(HeatBaffles / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        End If
        cmdChoiceBottomSupply.Enabled = False
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
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
        FilterMod = FilterAdjustmentS10(airflow, fourinchers)
        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS10(airflow, econyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS10BottomSupply.Enabled = False
        btnReturn.Enabled = True
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
                Case Is = "J06ZJ"
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
                Case Is = "J12ZH"
                    temp = 0.000000119120125705 * localAirflow ^ 2 + 0.000013904963053223 * localAirflow
                Case Is = "J12ZB"
                    temp = 0.000000124168 * localAirflow ^ 2 - 0.000010597484 * localAirflow
                Case Is = "J12XP"
                    temp = 0.000000145691 * localAirflow ^ 2 - 0.000039648178 * localAirflow
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
                Case Is = "J08ZT"
                    temp = 0.000000047632 * localAirflow ^ 2 + 0.000094404159 * localAirflow
                Case Is = "J10ZF"
                    temp = 0.000000054358 * localAirflow ^ 2 + 0.000071105472 * localAirflow
                Case Is = "J10ZJ"
                    temp = 0.000000009937 * localAirflow ^ 2 + 0.000260485433 * localAirflow
                Case Is = "J10ZR"
                    temp = 0.000000039043 * localAirflow ^ 2 + 0.000171795214 * localAirflow
                Case Is = "J10ZT"
                    temp = 0.000000056968826816 * localAirflow ^ 2 + 0.000070914044138178 * localAirflow
                Case Is = "J10ZB"
                    temp = 0.000000056968826816 * localAirflow ^ 2 + 0.000070914044138178 * localAirflow
                Case Is = "J12ZJ"
                    temp = 0.000000062138 * localAirflow ^ 2 + 0.000041605488 * localAirflow
                Case Is = "J12ZT"
                    temp = 0.000000059436091033 * localAirflow ^ 2 + 0.000061252317328535 * localAirflow
                Case Is = "J12ZR"
                    temp = 0.000000073142 * localAirflow ^ 2 + 0.000040949828 * localAirflow
                Case Is = "J12ZF"
                    temp = 0.000000062138 * localAirflow ^ 2 + 0.000041605488 * localAirflow
                Case Is = "J12ZH"
                    temp = 0.000000070777592264 * localAirflow ^ 2 + 0.000005982431510823 * localAirflow
                Case Is = "J12XP"
                    temp = 0.000000073142 * localAirflow ^ 2 + 0.000040949828 * localAirflow
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
                    Case Is = "J12ZB"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZR"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZJ"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZB"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J10ZT"
                        temp = -0.000000019929338691 * localAirflow ^ 2 + 0.00001501848785131 * localAirflow
                    Case Is = "J08ZJ"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J07ZR"
                        temp = -0.000000016071428571 * localAirflow ^ 2 + 0.000009009034443817 * localAirflow - 0.0158819169960459
                    Case Is = "J06ZR"
                        temp = -0.000000008403034 * localAirflow ^ 2 + 0.000011537438724 * localAirflow
                    Case Is = "J06ZJ"
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
                    Case Is = "J06ZJ"
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
                    Case Is = "J06ZJ"
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
                    Case Is = "J06ZJ"
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
                    Case Is = "J06ZJ"
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
                    Case Is = "J12XP"
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
                    Case Is = "J06ZJ"
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
                Case Is = "J12XP"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZT"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZF"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J12ZB"
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
                Case Is = "J08ZT"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J07ZR"
                    temp = 0.000000019600508187 * localAirflow ^ 2 - 0.00002628740824393 * localAirflow + 0.0985795454545449
                Case Is = "J06ZR"
                    temp = 0.000000001978349 * localAirflow ^ 2 + 0.000050003935905 * localAirflow
                Case Is = "J06ZJ"
                    temp = 0.000000001978349 * localAirflow ^ 2 + 0.000050003935905 * localAirflow
                Case Else
                    temp = 99.9
                    Dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:FilterAdjustmentS10")

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
                Case Is = "J12ZH"
                    temp = -0.000000020419254658 * localAirflow ^ 2 + 0.000412447769621681 * localAirflow - 0.761850296442687
                Case Is = "J12ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J12XP"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J12ZT"
                    temp = -0.000000019882834557 * localAirflow ^ 2 + 0.000399254658385093 * localAirflow - 0.646415513833994
                Case Is = "J12ZF"
                    temp = -0.00000002100701087 * localAirflow ^ 2 + 0.000416422272434739 * localAirflow - 0.768013952863524
                Case Is = "J12ZB"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZR"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZB"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J10ZT"
                    temp = -0.000000019882834557 * localAirflow ^ 2 + 0.000399254658385093 * localAirflow - 0.646415513833994
                Case Is = "J08ZJ"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J08ZT"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J07ZR"
                    temp = 0.925546828325 * Math.Log(localAirflow) - 7.095546030582
                Case Is = "J06ZR"
                    temp = 0.000000012497656 * localAirflow ^ 2 + 0.000022831433083 * localAirflow
                Case Is = "J06ZJ"
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
        If airflow < 27800 Then
            Damper = 0.03
        Else
            Damper = 0.00000000008192973097 * airflow ^ 2 - 0.00000220175944777729 * airflow + 0.03
        End If

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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
    End Sub
    Private Function ReheatAdjustmentChoice(localAirflow As Double, EconPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If EconPresent Then
            Select Case Snippet
                Case Is = "AD15"
                    temp = 0.000000000378728 * localAirflow * localAirflow + 0.000007568681319 * localAirflow
                Case Is = "AD18"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD20"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD25"
                    temp = 0.000000000527988161 * localAirflow * localAirflow + 0.000002891529555149 * localAirflow
                Case Is = "AD28"
                    temp = 0.000000000527988161 * localAirflow * localAirflow + 0.000002891529555149 * localAirflow
                Case Is = "AE23"
                    temp = 0.000000002021565 * localAirflow * localAirflow + -0.000000814652502 * localAirflow
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-reheat Adjustment. Snippet: " & Snippet)
                    Stop

            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function
    Private Function ReheatAdjustmentSelect(localAirflow As Double, ReheatPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If ReheatPresent Then
            Select Case Snippet
                Case Is = "JV28"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV30"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV35"
                    temp = 0.000000000902086791 * localAirflow ^ 2 + 0.000001823714253789 * localAirflow
                Case Is = "JV40"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV50"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH28"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH30"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH35"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH40"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH50"
                    dummy = MsgBox("That size and configuration of reheat performance is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-reheat Adjustment. Snippet: " & Snippet)
                    Stop

            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function
    Private Function EconAdjustmentSelect(localAirflow As Double, EconPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If EconPresent Then

            Select Case Snippet
                Case Is = "JV28"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV30"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV35"
                    temp = 0.000000002061540851 * localAirflow ^ 2 + 0.000002556271410935 * localAirflow
                Case Is = "JV40"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV50"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH28"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH30"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH35"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH40"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH50"
                    dummy = MsgBox("That size and configuration of economizer is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                    Stop
            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function
    Private Function EconAdjustmentChoice(localAirflow As Double, EconPresent As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If EconPresent Then
            Select Case Snippet
                Case Is = "AD15"
                    temp = 0.000000001884485 * localAirflow * localAirflow - 0.000000627289377 * localAirflow
                Case Is = "AD18"
                    temp = 0.000000001884485 * localAirflow * localAirflow - 0.000000627289377 * localAirflow
                Case Is = "AD20"
                    temp = 0.000000001884485 * localAirflow * localAirflow - 0.000000627289377 * localAirflow
                Case Is = "AD25"
                    temp = 0.000000002278228 * localAirflow * localAirflow - 0.000002849307913 * localAirflow
                Case Is = "AD28"
                    temp = 0.000000002278228 * localAirflow * localAirflow - 0.000002849307913 * localAirflow
                Case Is = "AE23"
                    temp = 0.000000002021565 * localAirflow * localAirflow - -0.000000814652502 * localAirflow
                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-econ Adjustment. Snippet: " & Snippet)
                    Stop

            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function
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
                    temp = 0.000000000952 * localAirflow ^ 2 + 0.000000857143 * localAirflow + 0.050857142857

            End Select
        Else
            temp = 0
        End If

        Return temp
    End Function
    Private Function UnitStaticPressureSelect(localAirflow As Double, BottomD As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If BottomD Then
            Select Case Snippet
                Case Is = "JV28"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV30"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV35"
                    temp = 0.00000000670400518292 * localAirflow ^ 2 + 0.000025457516140759 * localAirflow
                Case Is = "JV40"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JV50"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        Else
            Select Case Snippet
                Case Is = "JH28"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH30"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH35"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH40"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "JH50"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        End If

        Return temp
    End Function
    Private Function UnitStaticPressureChoice(localAirflow As Double, BottomD As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        If BottomD Then
            Select Case Snippet
                Case Is = "AD15"
                    temp = 0.000000016479818338 * localAirflow * localAirflow + 0.000021670973147619 * localAirflow
                Case Is = "AD18"
                    temp = 0.000000014559366969 * localAirflow * localAirflow + 0.000034955393655571 * localAirflow
                Case Is = "AD20"
                    temp = 0.000000013842003837 * localAirflow * localAirflow + 0.000040791751160522 * localAirflow
                Case Is = "AD25"
                    temp = 0.0000000000441146 * localAirflow * localAirflow + 0.000135164829143736 * localAirflow
                Case Is = "AD28"
                    temp = 0.0000000026707484 * localAirflow * localAirflow + 0.000144459630343065 * localAirflow
                Case Is = "AE23"
                    temp = 0.000000014101912 * localAirflow * localAirflow + 0.000083320844638 * localAirflow
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        Else
            Select Case Snippet
                Case Is = "AD15"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD18"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD20"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD25"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Is = "AD28"
                    Dummy = MsgBox("That size and configuration is not yet configured.  You will need to manually enter USP.", vbOKOnly, "Fisen Unit Generator")
                    temp = 0.00
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
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
                Case Is = "J18ZJ"
                    temp = 0.000000020999 * localAirflow ^ 2 + 0.00010369692 * localAirflow + 0
                Case Is = "J20ZJ"
                    temp = 0.0000000192 * localAirflow * localAirflow + 0.0000567739 * localAirflow
                Case Is = "J15ZR"
                    temp = 0.000000013833 * localAirflow ^ 2 + 0.000150417882 * localAirflow + 0
                Case Is = "J20ZR"
                    temp = 0.0000000199 * localAirflow ^ 2 + 0.000031375 * localAirflow - 0
                Case Is = "J25ZR"
                    temp = 0.0000000205 * localAirflow ^ 2 + 0.0000656707 * localAirflow + 0
                Case Is = "J25ZJ"
                    'temp = 0.0000000009732853 * localAirflow ^ 2 + 0.0000000009732853 * localAirflow + 0
                    temp = 0.0000000009732853 * localAirflow ^ 2 + 0.000181115 * localAirflow + 0
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
                Case Is = "J20ZJ"
                    temp = 0.0000000177 * localAirflow * localAirflow + 0.0000379674 * localAirflow
                Case Is = "J15ZR"
                    temp = 0.000000006085 * localAirflow ^ 2 + 0.000164261398 * localAirflow + 0
                Case Is = "J20ZR"
                    temp = 0.000000037853 * localAirflow ^ 2 - 0.000036529367 * localAirflow + 0
                Case Is = "J25ZR"
                    temp = 0.0000000199 * localAirflow ^ 2 + 0.000031375 * localAirflow + 0
                Case Is = "J25ZJ"
                    temp = 0.00000000006071 * localAirflow ^ 2 + 0.00016307526566 * localAirflow + 0
                Case Else
                    Dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)
                    Stop
            End Select
        End If

        Return temp
    End Function

    Private Function HeatAdjustmentChoice(localAirflow As Double, HeatCode As String)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        Select Case HeatCode
            Case Is = "Gas"
                temp = 0
            Case Is = "CoolOnly"
                Select Case Snippet
                    Case Is = "AD15"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD18"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD20"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD25"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD28"
                        temp = 0.000000003797771 * localAirflow * localAirflow + 0.000008489596936 * localAirflow
                        temp = temp * -1
                    Case Is = "AE23"
                        temp = 0.000000005417236 * localAirflow * localAirflow + -0.000006248683958 * localAirflow
                        temp = temp * -1
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-Gas Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select
            Case Is = "25kW"
                Select Case Snippet
                    Case Is = "AD15"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD18"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD20"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD25"
                        temp = 0.000000003378167 * localAirflow * localAirflow + 0.000009183424741 * localAirflow
                    Case Is = "AD28"
                        temp = 0.000000003378167 * localAirflow * localAirflow + 0.000009183424741 * localAirflow
                    Case Is = "AE23"
                        temp = 0.000000002373844 * localAirflow * localAirflow + -0.000009286213233 * localAirflow
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select

            Case Is = "50kW"
                Select Case Snippet
                    Case Is = "AD15"
                        dummy = MsgBox("That size and configuration of 50kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD18"
                        dummy = MsgBox("That size and configuration of 50kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD20"
                        dummy = MsgBox("That size and configuration of 50kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD25"
                        temp = 0.000000003237572909 * localAirflow * localAirflow + 0.000008239749281796 * localAirflow
                    Case Is = "AD28"
                        temp = 0.000000003237572909 * localAirflow * localAirflow + 0.000008239749281796 * localAirflow
                    Case Is = "AE23"
                        temp = 0.000000002667024 * localAirflow * localAirflow + -0.000010621689347 * localAirflow
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-50kw elec Adjustment. Snippet: " & Snippet)
                        Stop
                End Select

            Case Is = "75kW"
                Select Case Snippet
                    Case Is = "AD15"
                        dummy = MsgBox("That size and configuration of 75 kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD18"
                        dummy = MsgBox("That size and configuration of 75 kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD20"
                        dummy = MsgBox("That size and configuration of 75 kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "AD25"
                        temp = 0.00000000299708366 * localAirflow * localAirflow + 0.000008624314442413 * localAirflow
                    Case Is = "AD28"
                        temp = 0.00000000299708366 * localAirflow * localAirflow + 0.000008624314442413 * localAirflow
                    Case Is = "AE23"
                        temp = 0.000000002696383 * localAirflow * localAirflow + -0.000009168275116 * localAirflow
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-75 kw elec Adjustment. Snippet: " & Snippet)
                        Stop
                End Select

        End Select
        Return temp
    End Function
    Private Function HeatAdjustmentSelect(localAirflow As Double, HeatCode As String)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 4)

        temp = 0
        Select Case HeatCode
            Case Is = "Gas"
                temp = 0
            Case Is = "CoolOnly"
                Select Case Snippet
                    Case Is = "JV28"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV30"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV35"
                        temp = -0.00000000074971315 * localAirflow ^ 2 + 0.000035307431723476 * localAirflow
                        temp = temp * -1
                    Case Is = "JV40"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV50"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH28"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH30"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH35"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH40"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH50"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-Gas Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select
            Case Is = "36kW"
                Select Case Snippet
                    Case Is = "JV28"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV30"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV35"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV40"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV50"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH28"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH30"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH35"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH40"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH50"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select

            Case Is = "54kW"
                Select Case Snippet
                    Case Is = "JV28"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV30"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV35"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV40"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV50"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH28"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH30"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH35"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH40"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH50"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select
            Case Is = "72kW"
                Select Case Snippet
                        Case Is = "JV28"
                            dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JV30"
                            dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JV35"
                            dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JV40"
                            dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JV50"
                            dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JH28"
                            dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JH30"
                            dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JH35"
                            dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JH40"
                            dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Is = "JH50"
                            dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                            temp = 0.00
                        Case Else
                            dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                            Stop
                    End Select
            Case Is = "90kW"
                Select Case Snippet
                    Case Is = "JV28"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV30"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV35"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV40"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JV50"
                        dummy = MsgBox("That size and configuration of 25kw elec is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH28"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH30"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH35"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH40"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Is = "JH50"
                        dummy = MsgBox("That size and configuration of cool only is not yet configured.  You will need to manually enter USP adjustment.", vbOKOnly, "Fisen Unit Generator")
                        temp = 0.00
                    Case Else
                        dummy = MsgBox("Unspecified Unit type in frmNewFan.vb-25kw Heat Adjustment. Snippet: " & Snippet)
                        Stop
                End Select
        End Select
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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
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
        btnReturn.Enabled = True
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
            Case Is = "ComefriATLI9-7_R"
                frmMain.ThisUnitCodes.Add("320B01")
            Case Is = "ComefriATLI15-11_T2"
                frmMain.ThisUnitCodes.Add("320B02")
            Case Is = "Comefri ATZAF_15-15_FF_BT2_T1"
                frmMain.ThisUnitCodes.Add("320B02")
            Case Else
                dummy = MsgBox("Fan not defined for BOM.  Please Add and Rerun.")
                Stop
        End Select
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

        SoundClip = ""
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
        SoundClip = ""

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

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        If cmbFanType.Text = "Supply Fan" Then frmHistoryReport.MyModule = "SFan"
        If cmbFanType.Text = "Return Fan" Then frmHistoryReport.MyModule = "RFan"
        If cmbFanType.Text = "Exhaust Fan" Then frmHistoryReport.MyModule = "XFan"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        If cmbFanType.Text = "Supply Fan" Then Call PerformDesignCautionScanSFan(True)
        If cmbFanType.Text = "Return Fan" Then Call PerformDesignCautionScanRFan(True)
        If cmbFanType.Text = "Exhaust Fan" Then Call PerformDesignCautionScanXFan(True)
    End Sub

    Private Sub PerformDesignCautionScanSFan(Prelim As Boolean)
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


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '320%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '320%'"
                Else
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                End If
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Design Caution")
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
                        dummy = MsgBox(totalmessage, vbOKOnly, "Design Caution")
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

    Private Sub PerformDesignCautionScanRFan(Prelim As Boolean)
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


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '330%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '330%'"
                Else
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                End If
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Design Caution")
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
                        dummy = MsgBox(totalmessage, vbOKOnly, "Design Caution")
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


    Private Sub PerformDesignCautionScanXFan(Prelim As Boolean)
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


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '350%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '350%'"
                Else
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                End If
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Design Caution")
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
                        dummy = MsgBox(totalmessage, vbOKOnly, "Design Caution")
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

    Private Sub cmdS5BottomSupply_Click(sender As Object, e As EventArgs) Handles cmdS5BottomSupply.Click
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
        BaseUnit = UnitStaticPressureS5(airflow, True)
        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentS5(airflow, cmbHeatBox.Text)
        'now the FilterAdjustment
        If opt2InchFilters.Checked = True Then fourinchers = False
        If opt4InchFilters.Checked = True Then fourinchers = True
        FilterMod = FilterAdjustmentS5(airflow, fourinchers)
        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentS5(airflow, econyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        cmdS5BottomSupply.Enabled = False
        btnReturn.Enabled = True


    End Sub
    Private Function UnitStaticPressureS5(localAirflow As Double, BottomD As Boolean)
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If BottomD Then

            Select Case Snippet
                Case Is = "J05ZE"
                    temp = 0.000000196428180185 * localAirflow ^ 2 + 0.00015767659173568 * localAirflow + 0

                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)

                    Stop
            End Select

        Else
            Select Case Snippet

                Case Else
                    dummy = MsgBox("Unspecified Unit type in frmNewFan.vb. Snippet: " & Snippet)

                    Stop
            End Select
        End If

        Return temp
    End Function

    Private Function HeatAdjustmentS5(localairflow As Double, HeatCode As String) As Double
        Dim temp As Double
        Dim Snippet As String
        Dim dummy As MsgBoxResult
        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0

        If ((HeatCode = "5kW") Or (HeatCode = "7kW") Or (HeatCode = "10kW") Or (HeatCode = "15kW")) Then HeatCode = "LowEHeat"
        If ((HeatCode = "20kW") Or (HeatCode = "30kW")) Then HeatCode = "HighEHeat"

        Select Case HeatCode
            Case Is = "Gas"
                temp = 0
            Case Is = "CoolOnly"
                temp = -1 * (0.000000013827152977 * localairflow ^ 2 + 0.000064011853295175 * localairflow + 0)
            Case Is = "LowEHeat"
                temp = 0.000000017967687593 * localairflow ^ 2 + 0.000030671416103432 * localairflow + 0
            Case Is = "HighEHeat"
                temp = 0.000000019170269338 * localairflow ^ 2 + 0.000013531429499279 * localairflow + 0
            Case Else
                temp = 99.9
                dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:HeatAdjustmentS5")
        End Select

        If temp < 0 Then temp = 0
        Return temp
    End Function

    Private Function FilterAdjustmentS5(localairflow As Double, FourInch As Boolean) As Double
        'no filter adjustments for series 5 so far
        Return 0
    End Function

    Private Function EconAdjustmentS5(localairflow As Double, econpresent As Boolean) As Double
        Dim temp As Double
        Dim Snippet As String
        Dim Dummy As MsgBoxResult

        Snippet = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        temp = 0
        If econpresent Then
            Select Case Snippet
                Case Is = "J03ZE"
                    temp = 0.000000019817227871 * localairflow ^ 2 + 0.000037498122551706 * localairflow + 0
                Case Is = "J04ZE"
                    temp = 0.000000019817227871 * localairflow ^ 2 + 0.000037498122551706 * localairflow + 0
                Case Is = "J05ZE"
                    temp = 0.000000019817227871 * localairflow ^ 2 + 0.000037498122551706 * localairflow + 0
                Case Is = "J06ZE"
                    temp = 0.000000019817227871 * localairflow ^ 2 + 0.000037498122551706 * localairflow + 0
                Case Else
                    temp = 99.9
                    Dummy = MsgBox("That Model Number is not modeled.  Please notify JBL to add a model.", vbOKOnly, "NewFan:EconAdjustmentS5")

            End Select
            If temp < 0 Then temp = 0
        Else
            temp = 0
        End If

        Return temp
    End Function

    Private Sub cmdGenericStatic_Click(sender As Object, e As EventArgs) Handles cmdGenericStatic.Click

        Dim NewRow As String()

        NewRow = {"Base Unit Static", "???", "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Installed Options", "???", "0.00"}
        dgvStaticSummary.Rows.Add(NewRow)

        btnReturn.Enabled = True
    End Sub

    Private Sub cmdRefreshFanList_Click(sender As Object, e As EventArgs) Handles cmdRefreshFanList.Click
        Call LoadTheFanList()
    End Sub

    Private Sub optNoAux_CheckedChanged_1(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged_1(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub cmdLXBottomSupply_Click(sender As Object, e As EventArgs) Handles cmdLXBottomSupply.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub

    Private Sub cmdLXRearSupply_Click(sender As Object, e As EventArgs) Handles cmdLXRearSupply.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub



    Private Sub cmdChoiceRearSupply_Click(sender As Object, e As EventArgs) Handles cmdChoiceRearSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim reheatmod As Double
        Dim FactoryOptions As Double
        Dim HeatBaffles As Double

        Dim econyesno, reheatyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureChoice(airflow, True)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentChoice(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        'Nothing on a series 20 !!!

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentChoice(airflow, econyesno)

        reheatyesno = chkReheatCoil.Checked
        reheatmod = ReheatAdjustmentChoice(airflow, reheatyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod + reheatmod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        If chkHeatBaffles.Checked Then
            HeatBaffles = 0.000000001331941323 * airflow * airflow - 0.000000563361120313 * airflow
            NewRow = {"Standard Heat Baffles", Format(HeatBaffles, "0.00"), Format(HeatBaffles / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

        If chkFisen2Rear.Checked Then
            HeatBaffles = 0.000000009564935065 * airflow * airflow - 0.000006064832535891 * airflow + 0.0270664217361984
            NewRow = {"Rear Discharge Reconfiguration", Format(HeatBaffles, "0.00"), Format(HeatBaffles / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

        cmdSelectBottomSupply.Enabled = False
        cmdSelectRearSupply.Enabled = False
        btnReturn.Enabled = True
    End Sub

    Private Sub cmdSelectBottomSupply_Click(sender As Object, e As EventArgs) Handles cmdSelectBottomSupply.Click
        Dim BaseUnit As Double
        Dim GasHeatMod As Double
        Dim FilterMod As Double
        Dim EconMod As Double
        Dim reheatmod As Double
        Dim FactoryOptions As Double
        Dim HeatBaffles As Double

        Dim econyesno, reheatyesno As Boolean

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the Base Unit
        BaseUnit = UnitStaticPressureSelect(airflow, True)

        'now the heatAdjustment
        GasHeatMod = HeatAdjustmentSelect(airflow, cmbHeatBox.Text)

        'now the FilterAdjustment
        'Nothing on a series 20 !!!

        'finally the EconMod
        econyesno = chkEconPresent.Checked
        EconMod = EconAdjustmentSelect(airflow, econyesno)

        reheatyesno = chkReheatCoil.Checked
        reheatmod = ReheatAdjustmentSelect(airflow, reheatyesno)

        FactoryOptions = GasHeatMod + FilterMod + EconMod + reheatmod

        NewRow = {"Base Unit Static Pressure", Format(BaseUnit, "0.00"), Format(BaseUnit / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Factory Options", Format(FactoryOptions, "0.00"), Format(FactoryOptions / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        If chkHeatBaffles.Checked Then
            HeatBaffles = 0.000000001331941323 * airflow * airflow - 0.000000563361120313 * airflow
            NewRow = {"Standard Heat Baffles", Format(HeatBaffles, "0.00"), Format(HeatBaffles / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

        If chkFisen2Rear.Checked Then
            HeatBaffles = 0.000000009564935065 * airflow * airflow - 0.000006064832535891 * airflow + 0.0270664217361984
            NewRow = {"Rear Discharge Reconfiguration", Format(HeatBaffles, "0.00"), Format(HeatBaffles / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        End If

        cmdChoiceRearSupply.Enabled = False
        btnReturn.Enabled = True

        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub

    Private Sub cmdSelectRearSupply_Click(sender As Object, e As EventArgs) Handles cmdSelectRearSupply.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub

    Private Sub cmdPremierBottomSupply_Click(sender As Object, e As EventArgs) Handles cmdPremierBottomSupply.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub

    Private Sub cmdPremierRearSupply_Click(sender As Object, e As EventArgs) Handles cmdPremierRearSupply.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Performance for that unit and configuration has not been modeled.  Use Generic.", vbOKOnly, "Fisen Unit Generator")
    End Sub

    Private Sub optMotorTypeODP_CheckedChanged(sender As Object, e As EventArgs) Handles optMotorTypeODP.CheckedChanged
        If optMotorTypeODP.Checked Then
            lblHPNote1.Visible = True
            lblIECNote1.Visible = False
            lblIECNote2.Visible = False
            lblNEMAMotorhp.Visible = True
            lblIECMotorkW.Visible = False
            lblIECMotorFLA.Visible = False
            cmbNewMotorHP.Visible = True
            cmbNewMotorHP.Text = "Unselected"
            txtIECMotorkW.Visible = False
            txtIECMotorFLA.Visible = False
            txtIECMotorFLA.Text = ""
            txtIECMotorkW.Text = ""
        End If
    End Sub

    Private Sub optMotorTypeTEFC_CheckedChanged(sender As Object, e As EventArgs) Handles optMotorTypeTEFC.CheckedChanged
        If optMotorTypeTEFC.Checked Then
            lblHPNote1.Visible = True
            lblIECNote1.Visible = False
            lblIECNote2.Visible = False
            lblNEMAMotorhp.Visible = True
            lblIECMotorkW.Visible = False
            lblIECMotorFLA.Visible = False
            cmbNewMotorHP.Visible = True
            cmbNewMotorHP.Text = "Unselected"
            txtIECMotorkW.Visible = False
            txtIECMotorFLA.Visible = False
            txtIECMotorFLA.Text = ""
            txtIECMotorkW.Text = ""
        End If
    End Sub

    Private Sub optMotorTypeIP54_CheckedChanged(sender As Object, e As EventArgs) Handles optMotorTypeIP54.CheckedChanged
        If optMotorTypeIP54.Checked Then
            lblHPNote1.Visible = False
            lblIECNote1.Visible = True
            lblIECNote2.Visible = True
            lblNEMAMotorhp.Visible = False
            lblIECMotorkW.Visible = True
            lblIECMotorFLA.Visible = True
            cmbNewMotorHP.Visible = False
            cmbNewMotorHP.Text = "IEC"
            txtIECMotorkW.Visible = True
            txtIECMotorFLA.Visible = True
            txtIECMotorFLA.Text = ""
            txtIECMotorkW.Text = ""
        End If
    End Sub

    Private Sub frmNewFan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If pResearchMode Then Me.Text = Me.Text & "***Research Mode***" Else Me.Text = "Add or Replace a " & pFanStyle
    End Sub

    Private Sub cmdCreateNewFan_Click(sender As Object, e As EventArgs) Handles cmdCreateNewFan.Click
        frmFanMaintenance.ShowDialog()
        frmFanMaintenance.Close()
    End Sub

    Private Sub cmdS10SideReturn_Click(sender As Object, e As EventArgs) Handles cmdS10SideReturn.Click
        Dim RAOpening As Double
        Dim NinetyBend As Double
        Dim Damper As Double
        Dim Hood As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the return air opening
        RAOpening = 0.000000002564 * airflow ^ 2 + 0.000000051282 * airflow + 0.000181818182
        'now the transition
        NinetyBend = 0.05
        'now the damper
        Damper = 0.000000004266854998 * airflow ^ 2 + 0.000031695476713075 * airflow + 0.00885010063426657
        'finally the hood
        Hood = 0.000000001010744741 * airflow ^ 2 + 0.000009026079425346 * airflow + 0.00166151293860098

        NewRow = {"Return Air Opening", Format(RAOpening, "0.00"), Format(RAOpening / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Cabinet Transitions", Format(NinetyBend, "0.00"), Format(NinetyBend / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Damper / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hood", Format(Hood, "0.00"), Format(Hood / Val(lblKFactor.Text), "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)



        frmMain.ThisUnitRXPerf.DuctLoc = "Side"
        cmdS10SideReturn.Enabled = False
        btnReturn.Enabled = True
    End Sub

    Private Sub cmdSeltectEndReturn_Click(sender As Object, e As EventArgs) Handles cmdSeltectEndReturn.Click
        Dim Transition As Double

        Dim Damper As Double
        Dim Hood As Double

        Dim airflow As Double

        Dim NewRow As String()

        airflow = Val(txtAirflow.Text)
        'first the transition/90
        Transition = 0.000000005892857 * airflow ^ 2 - 0.000104107142857 * airflow + 0.510714285714287
        'now the damper
        Damper = 0.000000001396 * airflow ^ 2 + 0.000023993506 * airflow - 0.138268398268
        'finally the hood
        Hood = 0.000000000249 * airflow ^ 2 + 0.000000025974 * airflow + 0.014406926407

        NewRow = {"Relief Transition", Format(Transition, "0.00"), Format(Val(lblKFactor.Text) * Transition, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Dampers", Format(Damper, "0.00"), Format(Val(lblKFactor.Text) * Damper, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        NewRow = {"Exhaust Air Hoods", Format(Hood, "0.00"), Format(Val(lblKFactor.Text) * Hood, "0.00")}
        dgvStaticSummary.Rows.Add(NewRow)
        frmMain.ThisUnitRXPerf.DuctLoc = "End"
        cmdSeltectEndReturn.Enabled = False
        btnReturn.Enabled = True
    End Sub
    Private Sub optReplaceVFD_CheckedChanged(sender As Object, e As EventArgs) Handles optReplaceVFD.CheckedChanged
        If optReplaceVFD.Checked Then
            cmbNewMotorHP.Text = "Unselected"
            chkRetainVFD.Enabled = True
        Else
            ' unk
        End If
    End Sub
    Private Sub optReplaceMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optReplaceMotor.CheckedChanged
        If optReplaceMotor.Checked Then
            cmbNewMotorHP.Text = "Unselected"
            optTEFC.Enabled = True
            optODP.Enabled = True
            cmbNewMotorHP.Enabled = True
            chkRetainVFD.Enabled = True
        Else
            'unk
        End If
    End Sub
    Private Sub optReuseVFD_CheckedChanged(sender As Object, e As EventArgs) Handles optReuseVFD.CheckedChanged
        If optReuseVFD.Checked Then
            chkRetainVFD.Enabled = False
            chkRetainVFD.Checked = False
        End If
    End Sub
    Private Sub optReuseMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optReuseMotor.CheckedChanged
        If optReuseMotor.Checked = True Then
            cmbNewMotorHP.Text = "n/a"
            chkRetainMotor.Enabled = False
            chkRetainMotor.Checked = False
        End If
    End Sub
    Private Sub optNewVFD_CheckedChanged(sender As Object, e As EventArgs) Handles optNewVFD.CheckedChanged
        If optNewVFD.Checked Then
            cmbNewMotorHP.Text = "Unselected"
            chkRetainVFD.Enabled = True
            chkRetainVFD.Checked = False
        End If
    End Sub
    Private Sub optNewMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optNewMotor.CheckedChanged
        If optNewMotor.Checked Then
            grpNewMotorType.Enabled = True
            optMotorTypeODP.Checked = True
            optMotorTypena.Enabled = False
            cmbNewMotorHP.Text = "Unselected"
            chkRetainMotor.Enabled = True
            chkRetainMotor.Checked = False
        End If
    End Sub

End Class