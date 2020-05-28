Imports System.ComponentModel
Public Class frmMHGRH_Conv
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
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("MHGRH_Conv") 'Mod Code goes here!
        Call UpdateCodeList()

        Call UpdateBaseUnitRequiredItems()
        'Call UpdateBaseUnitDrawingTags
        Call SetSuggestedReferFilters()
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

    Private Sub WriteHistory()
        'Updated to version 2.0 20 May 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim RHCap, RHAF, EAT, Ckts, DHStrat, RHStrat, DeltaT As String

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

        RHCap = txtHGRHCap.Text
        RHAF = txtHGRHAFlow.Text
        EAT = txtEATDB.Text
        Ckts = Trim(Str(nudCircuitsofRH.Value))
        If optDHCompsByJCI.Checked Then DHStrat = "By JCI" Else DHStrat = "GBAS Enab"
        If optRHSATCtrl.Checked Then RHStrat = "SAT by Fisen" Else RHStrat = "GBAS SAT"
        DeltaT = txtDeltaT.Text

        MySQL = "Select * FROM tblHistoryMHGRH_Conv WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryMHGRH_Conv SET MaxRHCap='" & RHCap & "', RHAirFlow='" & RHAF & "', " & "EATDB='" & EAT & "', Ckts='" & Ckts & "', DehumStrat='" & DHStrat & "', RHStrat='" & RHStrat & "', DeltaT='" & DeltaT & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryMHGRH_Conv (JobName,UnitID,Version,ModelNumber,MaxRHCap,RHAirFlow,EATDB,Ckts,DehumStrat,RHStrat,DeltaT) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & RHCap & "','" & RHAF & "','" & EAT & "','" & Ckts & "','" & DHStrat & "','" & RHStrat & "','" & DeltaT & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub SetSuggestedReferFilters()
        Dim TempVar As String

        TempVar = ""
        If nudCircuitsofRH.Value = 1 Then TempVar = "MHGRH(R)1 "
        If nudCircuitsofRH.Value = 2 Then TempVar = "MHGRH(R)2 "
        If nudCircuitsofRH.Value = 3 Then TempVar = "MHGRH(R)3 "

        Select Case frmMain.ThisUnitCoolPerf.NumRefCircuits
            Case Is = "1"
                TempVar = TempVar & "1Ckt "
            Case Is = "2"
                TempVar = TempVar & "2Ckt "
            Case Is = "3"
                TempVar = TempVar & "3Ckt "
        End Select

        frmMain.txtReferSuggestedTags.Text = Trim(frmMain.txtReferSuggestedTags.Text & " " & TempVar)

    End Sub

    Private Sub UpdateBaseUnitRequiredItems()
        frmMain.lstRequiredFactoryItems.Items.Add("Base Unit Comes with HGRH from JCI Factory")
    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()

        'Add the level 0 code
        ModuleCodeList.Add("725200") 'MHGRH Conv
        ModuleCodeList.Add("725201") 'JCI Installed Coil
        ModuleCodeList.Add("725202") 'Valves
        ModuleCodeList.Add("725203") 'Parallel Coil Config
        ModuleCodeList.Add("725207") 'Controls
        If optDHCompsByJCI.Checked = True Then
            ModuleCodeList.Add("725215") 'JCI SE Enables Compressors
        Else
            ModuleCodeList.Add("725210") 'GBAS Dehum Enable
        End If
        If optRHSATCtrl.Checked = True Then
            ModuleCodeList.Add("725220") 'HGRH SAT Control
        Else
            ModuleCodeList.Add("725225") 'HGRH GBAS Control
        End If
        If frmMain.ThisUnit.Family = "Series20" Then
            ModuleCodeList.Add("725240") 'HPCO Relocation
        End If
        If chkZTempReset.Checked = True Then ModuleCodeList.Add("725221")
        If chkFisenZoneHum.Checked = True Then ModuleCodeList.Add("725230")
        If chkFisenRAStat.Checked = True Then ModuleCodeList.Add("725230")
        If chkFisenZoneSensor.Checked = True Then ModuleCodeList.Add("725230")
        If chkFisenRASensor.Checked = True Then ModuleCodeList.Add("725230")

        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert

        frmMain.ThisUnit.CommNodes = "2"
        Call AssignReferSpecialties()

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("725F6A")
        End If



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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '725%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '725%'"
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

    Private Sub AssignReferSpecialties()
        Dim stub As String
        Dim dummy As MsgBoxResult

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 2)
            Case Is = "Series10"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
            Case Is = "Series20"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
            Case Is = "Select"
                stub = ""
            Case Is = "Choice"
                stub = ""
            Case Is = "Premier"
                stub = ""
        End Select
        Select Case stub
            Case Is = ""
                frmMain.ThisUnitReferSpecs.Add("")
                dummy = MsgBox("Refer specialties undefined for this unit." & vbCrLf & "Please add manually", vbOKOnly)
            Case Is = "JA3ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "JA4ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "JA5ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J06ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J07ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J08ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J10ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J10ZT"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J12ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J12ZT"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J15ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J20ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("RVH615")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                frmMain.ThisUnitReferSpecs.Add("AW15502-650")
                frmMain.ThisUnitReferSpecsTag.Add("BHB1")
            Case Is = "J25ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("RVH615")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                frmMain.ThisUnitReferSpecs.Add("AW15502-650")
                frmMain.ThisUnitReferSpecsTag.Add("BHB1")
            Case Is = "V2"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MV1/2")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "V3"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "V4"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
        End Select




    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True
        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MHGRH_Conv")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Hot Gas Reheat Conversion")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "115"
            Case Is = "Series10"
                tempWeight = "115"
            Case Is = "Series20"
                tempWeight = "100"
            Case Is = "Series40"
                'We should never execute this line!
                tempWeight = "-9999"
            Case Is = "Select"
                tempWeight = "155"
            Case Is = "Permier"
                tempWeight = "175"
            Case Is = "Choice"
                tempWeight = "115"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text
        frmMain.ThisUnitRHPerf.ControlType = "Modulating"
        frmMain.ThisUnitRHPerf.RHCapacity = txtHGRHCap.Text
        frmMain.ThisUnitRHPerf.RHAirflow = txtHGRHAFlow.Text
        frmMain.ThisUnitRHPerf.EAT = txtEATDB.Text
        frmMain.ThisUnitRHPerf.LAT = txtLAT.Text
        frmMain.ThisUnitRHPerf.DHCapacity = txtDehumCap.Text

    End Sub

    Private Sub frmMHGRH_Conv_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim temp As Double
        pCancelled = False

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        temp = Val(frmMain.ThisUnit.NominalTons) / 2 * 12 * 1.25

        txtHGRHCap.Text = Format(temp, "0.0")

        If Val(frmMain.ThisUnitRHPerf.RHAirflow) > 0 Then
            txtHGRHAFlow.Text = frmMain.ThisUnitRHPerf.RHAirflow
        Else
            txtHGRHAFlow.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If

        txtEATDB.Text = frmMain.ThisUnitCoolPerf.LeavingDB

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If

        Call PopulateAuxPanelList()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = True
            Case Is = "Series10"
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

        lstControlStyle.SelectedIndex = 0
        ModuleCodeList.Add("725000")
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
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click

        txtDehumCap.Text = frmMain.ThisUnitRHPerf.DHCapacity

        txtLAT.Text = Format(Val(txtHGRHCap.Text) * 1000 / 1.085 / Val(txtHGRHAFlow.Text) + Val(txtEATDB.Text), "0.0")
            txtDeltaT.Text = Format(Val(txtHGRHCap.Text) * 1000 / 1.085 / Val(txtHGRHAFlow.Text), "0.0")

        If Val(txtLAT.Text) > 80 Then txtLAT.Text = "80.0"

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnDonePerformance.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub txtLAT_Leave(sender As Object, e As EventArgs) Handles txtLAT.Leave
        If Val(txtLAT.Text) > 80 Then txtLAT.Text = "80.0"
        txtDeltaT.Text = Format(Val(txtLAT.Text) - Val(txtEATDB.Text), "0.0")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub optRHGBAS_CheckedChanged(sender As Object, e As EventArgs) Handles optRHGBAS.CheckedChanged
        chkZTempReset.Enabled = optRHSATCtrl.Checked
        If optRHGBAS.Checked = True Then chkZTempReset.Checked = False
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
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
        frmHistoryReport.MyModule = "MHGRH_Conv"
        frmHistoryReport.cmbModCode.Text = "MHGRH_Conv"
        frmHistoryReport.Show()
    End Sub
End Class