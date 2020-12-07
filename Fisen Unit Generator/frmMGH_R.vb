Imports System.Xml
Public Class frmMGH_R
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("MGH_R") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()

        Call UpdateBaseUnitRequiredItems()
        'Call UpdateBaseUnitDrawingTags
        'Call UpdateReferTags
        'Call UpdateAFTags
        'Call HydroTags

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i
        If chkWriteHistory.Checked Then Call WriteHistory()
        Me.Hide()
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '523%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '523%'"
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
    Private Sub UpdateBaseUnitRequiredItems()
        frmMain.lstRequiredFactoryItems.Items.Add("Stainless Steel Heat Exchanger")
    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("523100")
        ModuleCodeList.Add("523101")
        If optSATCtrl.Checked = True Then 'Normal SAT Controls
            ModuleCodeList.Add("523110")
            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    ModuleCodeList.Add("523112") 'SE 4Stage Board
                Else
                    ModuleCodeList.Add("523114") 'IPU
                End If
            Else 'This should mean S20, S10, S5
                ModuleCodeList.Add("523111") 'SE Single board
            End If

            If chkTempering.Checked = True Then
                ModuleCodeList.Add("523130")
                If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                    If optSE.Checked = True Then
                        ModuleCodeList.Add("523132") 'SE 4Stage Board
                    Else
                        ModuleCodeList.Add("523134") 'IPU
                    End If
                Else 'This should mean S20, S10, S5
                    ModuleCodeList.Add("523131") 'SE Single board
                End If

            End If

            If chkSATReset.Checked = True Then
                ModuleCodeList.Add("523135")
            End If
        End If

        If opt100OACtrls.Checked = True Then
            ModuleCodeList.Add("523140") '100% OA SAT Controls
            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    ModuleCodeList.Add("523143") 'SE 100% Outdoor Air
                Else
                    ModuleCodeList.Add("523145") 'IPU 100% Outdoor Air
                End If
            Else 'This should mean S20, S10, S5
                ModuleCodeList.Add("523143") 'SE Single board
            End If
        End If

        If optGBAS.Checked = True Then
            ModuleCodeList.Add("523120") 'GBAS Interface
        End If

        If optCustomCtrl.Checked Then
            ModuleCodeList.Add("523105")
            Select Case cmbCustomControls.Text
                Case Is = "IPU Enabled/Fisen Controlled Modulation"
                    ModuleCodeList.Add("523161")
            End Select

        End If

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                ModuleCodeList.Add("523150")
            Case Is = "Series10"
                ModuleCodeList.Add("523151")
            Case Is = "Series12"
                ModuleCodeList.Add("523158")
            Case Is = "Series20"
                ModuleCodeList.Add("523152")
            Case Is = "Series40"
                ModuleCodeList.Add("523153")
            Case Is = "Series100"
                ModuleCodeList.Add("523154")
            Case Is = "Select"
                ModuleCodeList.Add("523156")
            Case Is = "Premier"
                ModuleCodeList.Add("523157")
            Case Is = "Choice"
                ModuleCodeList.Add("523155")
        End Select



        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnit.GenCodesPresent = False Then frmMain.ThisUnitGenCodes.Add("960000")
            frmMain.ThisUnit.GenCodesPresent = True
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

        If chkPropane.Checked Then
            ModuleCodeList.Add("523999")
            ModuleCodeList.Add("523998")
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("523F6A")
        End If

        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert()

        frmMain.ThisUnit.CommNodes = "2"
    End Sub
    Private Sub AuxPanelCodeInsert()
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

    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.GasTrainTest = True
        frmMain.ThisUnitWarrTest.GHeatTest = True
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MGH_R")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Gas Heat Retrofit")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "25"
            Case Is = "Series10"
                tempWeight = "25"
            Case Is = "Series12"
                tempWeight = "25"
            Case Is = "Series20"
                tempWeight = "25"
            Case Is = "Series40"
                tempWeight = "35"
            Case Is = "Series100"
                tempWeight = "65"
            Case Is = "Choice"
                tempWeight = "25"
            Case Is = "Select"
                tempWeight = "35"
            Case Is = "Premier"
                tempWeight = "35"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.SSE = txtSSE.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"

    End Sub

    Private Sub frmMGH_R_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        If frmMain.ThisUnitHeatPerf.Airflow > 0 Then
            txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        Else
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtInputCap.Text = frmMain.ThisUnitHeatPerf.InputCapacity
        txtOutCap.Text = frmMain.ThisUnitHeatPerf.OutputCapacity
        txtSSE.Text = frmMain.ThisUnitHeatPerf.SSE
        txtLAT.Text = frmMain.ThisUnitHeatPerf.LeavingAirTemp
        txtDeltaT.Text = frmMain.ThisUnitHeatPerf.DeltaT
        If frmMain.ThisUnit.Family = "Series100" Then optIPU.Enabled = True
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
        Call PopulateAuxPanelList()

        Call PopulateAuxPanelList()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = True
            Case Is = "Series10"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series12"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series20"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series40"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series100"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Premier"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Select"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Choice"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
        End Select

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

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        ModuleCodeList.Add("523100")
    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/MGH_R")

        TempVal = xNodeRoot.SelectSingleNode("HeatingAirflow").InnerText
        txtHeatAF.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EAT").InnerText
        txtEAT.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("InputCapacity").InnerText
        txtInputCap.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("Propane").InnerText
        If TempVal = "Yes" Then chkPropane.Checked = True Else chkPropane.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("AtElevation").InnerText
        If TempVal = "Yes" Then chkUnitAtElevation.Checked = True Else chkUnitAtElevation.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("Elevation").InnerText
        txtElevation.Text = TempVal

    End Sub

    Private Sub PopulateAuxPanelList()
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
                    Case Is = "Series10"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 12 Downflow")
                        cmbAuxPanelOpts.Items.Add("Series 12 Horizontal")
                        cmbAuxPanelOpts.Items.Add("Series 12 Horizontal No Return")
                        cmbAuxPanelOpts.Items.Add("Series 12 Convertible")
                        cmbAuxPanelOpts.Items.Add("Series 12 Custom Application")
                        cmbAuxPanelOpts.Text = "Series 12 Downflow"

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
        Dim PerfGood As Boolean
        Dim dummy As MsgBoxResult

        PerfGood = True

        If Not (IsNumeric(txtHeatAF.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtEAT.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtInputCap.Text)) Then
            PerfGood = False
        End If

        If PerfGood Then
            TabControl1.SelectedIndex = 1
        Else
            dummy = MsgBox("One or more of your inputs is invalid.")
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked = True Then
            chkTempering.Enabled = True
            If frmMain.ThisUnit.Family <> "Series40" Then
                chkSATReset.Enabled = True
            End If
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
            chkSATReset.Enabled = False
            chkSATReset.Checked = False
        End If

    End Sub

    Private Sub opt100OACtrls_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OACtrls.CheckedChanged

    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim temp As Double
        temp = Val(txtLAT.Text) - Val(txtEAT.Text)
        txtDeltaT.Text = Format(temp, "0.0")
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub optCustomCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optCustomCtrl.CheckedChanged
        If optCustomCtrl.Checked Then
            cmbCustomControls.Enabled = True
            cmbCustomControls.SelectedItem = 0
        Else
            cmbCustomControls.Enabled = False
        End If

    End Sub


    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "MGH(R)"
        frmHistoryReport.cmbModCode.Text = "MGH(R)"
        frmHistoryReport.Show()
    End Sub

    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim CToPropane, Elevation, GBAS, CstmCtrl, Controller, DeltaT As String

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

        If chkPropane.Checked Then CToPropane = "Yes" Else CToPropane = "No"
        Elevation = txtElevation.Text
        If optGBAS.Checked Then GBAS = "Yes" Else GBAS = "No"
        If optCustomCtrl.Checked Then CstmCtrl = cmbCustomControls.Text Else CstmCtrl = "n/a"
        Controller = "-"
        If optSE.Checked Then Controller = "SE"
        If optIPU.Checked Then Controller = "IPU"
        If optASE.Checked Then Controller = "ASE"
        DeltaT = txtDeltaT.Text

        MySQL = "Select * FROM tblHistoryMGH_R WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryMGH_R SET ConvertToPropane='" & CToPropane & "', Elevation='" & Elevation & "', " & "GBAS='" & GBAS & "', CustomControl='" & CstmCtrl & "', Controller='" & Controller & "', DeltaT='" & DeltaT & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryMGH_R (JobName,UnitID,Version,ModelNumber,ConvertToPropane,Elevation,GBAS,CustomControl,Controller,DeltaT) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & CToPropane & "','" & Elevation & "','" & GBAS & "','" & CstmCtrl & "','" & Controller & "','" & DeltaT & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

End Class