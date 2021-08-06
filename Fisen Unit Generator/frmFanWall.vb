Imports System.Xml

Public Class frmFanWall
    Private pCancelled As Boolean
    Private pFanWallStyle As String
    Private ModuleCodeList As New ArrayList
    Private pResearchMode

    Public Property FanWallStyle As String
        Get
            Return pFanWallStyle
        End Get
        Set(value As String)
            pFanWallStyle = value
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
    Private Sub frmFanWall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateAuxPanelList()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series10"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series20"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series40"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "SeriesLX"

            Case Is = "Series100"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Premier"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Select"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Choice"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
        End Select

        Select Case pFanWallStyle
            Case Is = "Supply Fan Array"
                txtAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
                txtESP.Text = frmMain.ThisUnitSFanPerf.ESP

            Case Is = "Return Fan Array"
                txtAirflow.Text = frmMain.ThisUnitRXPerf.Airflow
                txtESP.Text = frmMain.ThisUnitRXPerf.ESP

            Case Is = "Exhaust Fan Array"
                txtAirflow.Text = frmMain.ThisUnitRXPerf.Airflow
                txtESP.Text = frmMain.ThisUnitRXPerf.Airflow
        End Select

        cmbArraySize.Text = "Unselected"
        cmbFanType.Text = pFanWallStyle
        txtElevation.Text = frmMain.ThisUnitCoolPerf.Elevation
        If Val(txtElevation.Text) > 0 Then chkESPatElev.Checked = True
        lblKFactor.Text = Format(ElevationCorrection(txtElevation.Text), "0.00")


        'If it’s a DPP project then turn on DPP controls for handling during update performance.
        'n/a remains usable to permit n/a for dedicated supply.
        If frmMain.ThisUnitElecData.DPPPresent Then grpDPPCkt.Visible = True

        If pFanWallStyle = "Supply Fan Array" Then ModuleCodeList.Add("390100")
        If pFanWallStyle = "Return Fan Array" Then ModuleCodeList.Add("391100")
        If pFanWallStyle = "Exhaust Fan Array" Then ModuleCodeList.Add("392100")

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        'Loading the Digital Conditions will vary with every mod.
        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True



    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        'Placeholder Rightnow
        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/SFanWall")

        If cmbFanType.Text = "Return Fan" Then xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/RFanWall")
        If cmbFanType.Text = "Exhaust Fan" Then xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/XFanWall")

        'TempVal = xNodeRoot.SelectSingleNode("FlowConfig").InnerText

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Call UpdatePerformance()
        'Call UpdateWeightTable()
        'Call UpdateWarrantyItems()

        Call UpdateCodeList(False)
        'Call UpdateBaseUnitRequiredItems()
        'Call UpdateBaseUnitDrawingTags
        'Call UpdateReferTags
        'Call UpdateAFTags
        'Call HydroTags

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
        'Call AuxPanelCodeInsert

        'Call PerformDesignCautionScan(False)
        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

        'If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        'Version 1.0 - Requires specificity(2 places) to be performed when inserted.
        'Version 1.0.M - Modified to handle multiple fan types.

        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer

        Dim FType As String

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

        FType = "999"
        If pFanWallStyle = "Return Fan Wall" Then FType = "391"
        If pFanWallStyle = "Supplt Fan Wall" Then FType = "390"

        For i = 0 To ModuleCodeList.Count - 1


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '" & FType & "%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '" & FType & "%'"
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

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        If pFanWallStyle = "Supply Fan Array" Then frmHistoryReport.MyModule = "SFanWall"
        If pFanWallStyle = "Return Fan Array" Then frmHistoryReport.MyModule = "RFanWall"
        If pFanWallStyle = "Exhaust Fan Array" Then frmHistoryReport.MyModule = "XFanWall"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdFIOPPreview_Click(sender As Object, e As EventArgs) Handles cmdFIOPPreview.Click
        'version 1.0
        'version 1.0M - Modified to accept 2 different fan types
        'Modify: Code XXX in SQL declaration below.

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Dim FType As String

        FType = "999"
        If pFanWallStyle = "Supply Fan Array" Then FType = "390"
        If pFanWallStyle = "Return Fan Array" Then FType = "391"

        Call UpdateCodeList(True)

        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode LIKE '" & FType & "%'"
        rs.Open(MySQL, con)

        For i = 0 To ModuleCodeList.Count - 1
            rs.MoveFirst()
            rs.Find("FIOpCode='" & ModuleCodeList(i) & "'")
            OneLine = ""
            For j = 1 To Val(rs.Fields("Level").Value)
                OneLine = OneLine & "\tab "
            Next
            OneLine = OneLine & rs.Fields("Description").Value & " - " & rs.Fields("FIopCode").Value & "\par "
            AllLines.Append(OneLine)
        Next
        AllLines.Append("}")

        con.Close()
        rs = Nothing
        con = Nothing

        frmFIOPPreview.ReportData = AllLines.ToString
        frmFIOPPreview.Show()
    End Sub
    Private Sub UpdateCodeList(Preview As Boolean)
        Select Case pFanWallStyle
            Case Is = "Supply Fan Array"
                If Not (Preview) Then
                    frmMain.ThisUnitMods.Add("SFanWall") 'Mod Code goes here!
                End If
                Call SFanArrayHandler()


            Case Is = "Return Fan Array"
                If Not (Preview) Then
                    frmMain.ThisUnitMods.Add("RFanWall") 'Mod Code goes here!
                End If
                Call RFanArrayHandler()


            Case Is = "Exhaust Fan Array"
                If Not (Preview) Then
                    frmMain.ThisUnitMods.Add("XFanWall") 'Mod Code goes here!
                End If
                Call XFanArrayHandler()


        End Select

        'Do all the common stuff
        If Not (Preview) Then
            If chkWriteHistory.Checked = True Then Call WriteHistory()
        End If

    End Sub
    Private Sub SFanArrayHandler()
        ModuleCodeList.Clear()
        ModuleCodeList.Add("390100")

        If chk65kASCCRBase.Checked Then ModuleCodeList.Add("390F6A")
    End Sub
    Private Sub RFanArrayHandler()
        ModuleCodeList.Clear()
        ModuleCodeList.Add("391100")

        If chk65kASCCRBase.Checked Then ModuleCodeList.Add("391F6A")
    End Sub
    Private Sub XFanArrayHandler()
        ModuleCodeList.Clear()
        ModuleCodeList.Add("392100")

        If chk65kASCCRBase.Checked Then ModuleCodeList.Add("392F6A")
    End Sub
    Private Sub WriteHistory()

    End Sub
    Private Sub PopulateAuxPanelList()
        'V1.2 Added LX Series Support
        'V1.1 Added Check for it already existing
        If frmMain.HasAuxillaryPanel = True Then
            optUseAux.Checked = True
            grpAuxPanel.Enabled = False
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

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult
        If cmbArraySize.Text = "Unselected" Then
            dummy = MsgBox("You must select an array size before continuing.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If
    End Sub

    Private Sub cmbFanType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFanType.SelectedIndexChanged
        Me.Text = pFanWallStyle
    End Sub

    Private Sub cmbArraySize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArraySize.SelectedIndexChanged
        Dim fancount As String
        Dim dummy As MsgBoxResult
        Dim msgstr As String
        Select Case cmbArraySize.Text
            Case Is = "2x1"
                fancount = 2
            Case Is = "2x2"
                fancount = 4
            Case Is = "3x1"
                fancount = 3
            Case Is = "3x2"
                fancount = 6
            Case Is = "3x3"
                fancount = 9
            Case Is = "4x1"
                fancount = 4
            Case Is = "4x2"
                fancount = 8
            Case Is = "4x3"
                fancount = 12
            Case Is = "4x4"
                fancount = 16
            Case Is = "Unselected"
                fancount = 99
            Case Else
                fancount = 99
                msgstr = "Somehow you have selected an undefied fan array.  Please reselect array size."
                dummy = MsgBox(msgstr, vbOK + vbAbort, "Fisen Unit Generator")
                If dummy = vbAbort Then Stop
        End Select
        lblFanCount.Text = Trim(Str(fancount))
        txtAirflowEachFan.Text = Format(Val(txtAirflow.Text) / Val(lblFanCount.Text), "0")
    End Sub

    Private Sub txtElevation_TextChanged(sender As Object, e As EventArgs) Handles txtElevation.TextChanged
        lblKFactor.Text = Format(ElevationCorrection(txtElevation.Text), "0.00")
        tslblElevation.Text = "Elevation: " & txtElevation.Text
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

        Call PopulateStaticDropdown()

        TabControl1.SelectTab("tpgStaticSum")
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim i As Integer
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

    Private Sub txtESP_TextChanged(sender As Object, e As EventArgs) Handles txtESP.TextChanged
        tslblESP.Text = "ESP: " & txtESP.Text
    End Sub

    Private Sub txtTSP_TextChanged(sender As Object, e As EventArgs) Handles txtTSP.TextChanged
        tslblTSP.Text = "TSP: " & txtTSP.Text
    End Sub

    Private Sub txtAirflow_TextChanged(sender As Object, e As EventArgs) Handles txtAirflow.TextChanged
        tslblAirflow.Text = "Airflow:" & txtAirflow.Text
        txtAirflowEachFan.Text = Format(Val(txtAirflow.Text) / Val(lblFanCount.Text), "0")
    End Sub

    Private Sub PopulateStaticDropdown()
        Dim dummy As MsgBoxResult
        Dim msgstr As String

        Dim myfam As String

        myfam = frmMain.ThisUnit.Family
        cmbUSPType.Items.Clear()
        cmbUSPType.Items.Add("Generic")
        Select Case myfam
            Case Is = "Series5"
                'Unlikely - Use Generic
            Case Is = "Series10"
                'Unlikely - Use Generic
            Case Is = "Series20"
                'Unlikely - Use Generic
            Case Is = "Series40"
                Select Case pFanWallStyle
                    Case Is = "Supply Fan Array"
                        cmbUSPType.Items.Add("S40 - Downflow Supply SFan")
                        cmbUSPType.Items.Add("S40 - Rear Supply SFan")

                    Case Is = "Return Fan Array"
                        cmbUSPType.Items.Add("S40 - Bottom Return RFan")
                        cmbUSPType.Items.Add("S40 - End Return RFan")
                        cmbUSPType.Items.Add("S40 - Rear Return RFan")

                    Case Is = "Exhaust Fan Array"
                        cmbUSPType.Items.Add("S40 - Bottom Return XFan")

                End Select
            Case Is = "Series100"
                Select Case pFanWallStyle
                    Case Is = "Supply Fan Array"
                        If frmMain.ThisUnit.Cabinet = "Series100A" Then
                            cmbUSPType.Items.Add("S100A - Downflow Supply SFan")
                            cmbUSPType.Items.Add("S100A - Rear Supply SFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100B" Then
                            cmbUSPType.Items.Add("S100B - Downflow Supply SFan")
                            cmbUSPType.Items.Add("S100B - Rear Supply SFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100C" Then
                            cmbUSPType.Items.Add("S100C - Downflow Supply SFan")
                            cmbUSPType.Items.Add("S100C - Rear Supply SFan")

                        End If
                    Case Is = "Return Fan Array"
                        If frmMain.ThisUnit.Cabinet = "Series100A" Then
                            cmbUSPType.Items.Add("S100A - Bottom Return RFan")
                            cmbUSPType.Items.Add("S100A - End Return RFan")
                            cmbUSPType.Items.Add("S100A - Rear Return RFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100B" Then
                            cmbUSPType.Items.Add("S100B - Bottom Return RFan")
                            cmbUSPType.Items.Add("S100B - End Return RFan")
                            cmbUSPType.Items.Add("S100B - Rear Return RFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100C" Then
                            cmbUSPType.Items.Add("S100C - Bottom Return RFan")
                            cmbUSPType.Items.Add("S100C - End Return RFan")
                            cmbUSPType.Items.Add("S100C - Rear Return RFan")

                        End If
                    Case Is = "Exhaust Fan Array"
                        If frmMain.ThisUnit.Cabinet = "Series100A" Then
                            cmbUSPType.Items.Add("S100A - Bottom Return XFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100B" Then
                            cmbUSPType.Items.Add("S100B - Bottom Return XFan")

                        End If
                        If frmMain.ThisUnit.Cabinet = "Series100C" Then
                            cmbUSPType.Items.Add("S100C - Bottom Return XFan")

                        End If
                End Select
            Case Is = "Select"
                Select Case pFanWallStyle
                    Case Is = "Supply Fan Array"
                        cmbUSPType.Items.Add("Select - Downflow Supply SFan")
                        cmbUSPType.Items.Add("Select - Rear Supply SFan")

                    Case Is = "Return Fan Array"
                        cmbUSPType.Items.Add("Select - Bottom Return RFan")
                        cmbUSPType.Items.Add("Select - End Return RFan")
                        cmbUSPType.Items.Add("Select - Rear Return RFan")

                    Case Is = "Exhaust Fan Array"
                        cmbUSPType.Items.Add("Select - Bottom Return XFan")

                End Select
            Case Is = "Choice"
                Select Case pFanWallStyle
                    Case Is = "Supply Fan Array"
                        cmbUSPType.Items.Add("Choice - Downflow Supply SFan")
                        cmbUSPType.Items.Add("Choice - Rear Supply SFan")

                    Case Is = "Return Fan Array"
                        cmbUSPType.Items.Add("Choice - Bottom Return RFan")
                        cmbUSPType.Items.Add("Choice - End Return RFan")
                        cmbUSPType.Items.Add("Choice - Rear Return RFan")

                    Case Is = "Exhaust Fan Array"
                        cmbUSPType.Items.Add("Choice - Bottom Return XFan")

                End Select
            Case Is = "Premier"
                Select Case pFanWallStyle
                    Case Is = "Supply Fan Array"
                        cmbUSPType.Items.Add("Premier - Downflow Supply SFan")
                        cmbUSPType.Items.Add("Premier - Rear Supply SFan")

                    Case Is = "Return Fan Array"
                        cmbUSPType.Items.Add("Premier - Bottom Return RFan")
                        cmbUSPType.Items.Add("Premier - End Return RFan")
                        cmbUSPType.Items.Add("Premier - Rear Return RFan")

                    Case Is = "Exhaust Fan Array"
                        cmbUSPType.Items.Add("Premier - Bottom Return XFan")

                End Select
            Case Is = "SeriesLX"
                'Unlikely - Use Generic
            Case Is = "Blank"
                'Do nothing Generic will handle it.
            Case Else
                msgstr = "Unknown/unexpected family: " & myfam & " in PopulateStaticDropdown.  Aborting."
                dummy = MsgBox(msgstr, vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select


        cmbUSPType.Items.Add("Unselected")
        cmbUSPType.Text = "Unselected"
    End Sub

    Private Sub cmdPopulateStaticTable_Click(sender As Object, e As EventArgs) Handles cmdPopulateStaticTable.Click
        Dim dummy As MsgBoxResult
        Dim msgstr As String

        Select Case cmbUSPType.Text
            Case Is = "S40 - Downflow Supply SFan"
            Case Is = "S40 - Rear Supply SFan"
            Case Is = "S40 - Bottom Return RFan"
            Case Is = "S40 - End Return RFan"
            Case Is = "S40 - Rear Return RFan"
            Case Is = "S40 - Bottom Return XFan"
            Case Is = "S100A - Downflow Supply SFan"
                Call PullYPALStaticsSFan()
            Case Is = "S100A - Rear Supply SFan"
                Call PullYPALStaticsSFan()
            Case Is = "S100B - Downflow Supply SFan"
                Call PullYPALStaticsSFan()
            Case Is = "S100B - Rear Supply SFan"
                Call PullYPALStaticsSFan()
            Case Is = "S100C - Downflow Supply SFan"
                Call PullYPALStaticsSFan()
            Case Is = "S100C - Rear Supply SFan"
                Call PullYPALStaticsSFan()

            Case Is = "S100A - Bottom Return RFan"
            Case Is = "S100A - End Return RFan"
            Case Is = "S100A - Rear Return RFan"
            Case Is = "S100B - Bottom Return RFan"
            Case Is = "S100B - End Return RFan"
            Case Is = "S100B - Rear Return RFan"
            Case Is = "S100C - Bottom Return RFan"
            Case Is = "S100C - End Return RFan"
            Case Is = "S100C - Rear Return RFan"
            Case Is = "S100A - Bottom Return XFan"
            Case Is = "S100B - Bottom Return XFan"
            Case Is = "S100C - Bottom Return XFan"
            Case Is = "Select - Downflow Supply SFan"
            Case Is = "Select - Rear Supply SFan"
            Case Is = "Select - Bottom Return RFan"
            Case Is = "Select - End Return RFan"
            Case Is = "Select - Rear Return RFan"
            Case Is = "Select - Bottom Return XFan"
            Case Is = "Choice - Downflow Supply SFan"
            Case Is = "Choice - Rear Supply SFan"
            Case Is = "Choice - Bottom Return RFan"
            Case Is = "Choice - End Return RFan"
            Case Is = "Choice - Rear Return RFan"
            Case Is = "Choice - Bottom Return XFan"
            Case Is = "Premier - Downflow Supply SFan"
            Case Is = "Premier - Rear Supply SFan"
            Case Is = "Premier - Bottom Return RFan"
            Case Is = "Premier - End Return RFan"
            Case Is = "Premier - Rear Return RFan"
            Case Is = "Premier - Bottom Return XFan"
            Case Else
                msgstr = "Unknown/unexpected configuration: " & cmbUSPType.Text & " in Static Summary Assignment.  Aborting."
                dummy = MsgBox(msgstr, vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select
        btnReturn.Enabled = True
    End Sub
    Private Sub PullYPALStaticsSFan()
        Dim i As Integer
        Dim NewRow As String()

        For i = 0 To frmMain.ThisUnitSFanPerf.StaticNameYpal.Count - 1
            NewRow = {frmMain.ThisUnitSFanPerf.StaticNameYpal.Item(i), Format(Val(frmMain.ThisUnitSFanPerf.StaticDataYpal.Item(i)), "0.00"), Format(Val(frmMain.ThisUnitSFanPerf.StaticDataYpal.Item(i)) / Val(lblKFactor.Text), "0.00")}
            dgvStaticSummary.Rows.Add(NewRow)
        Next
    End Sub
End Class