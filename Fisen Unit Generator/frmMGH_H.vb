Imports System.IO
Public Class frmMGH_H
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList
    Private BurnerList As New ArrayList

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

        frmMain.ThisUnitMods.Add("MGH_H") 'Mod Code goes here!

        If chkMountEquipmentTouch.Checked = True Then
            If frmMain.HasUMHMI = False Then
                frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
                frmMain.optHMIInstalled.Checked = True
            End If
        End If
        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.HasHMI = False Then
                frmMain.ThisUnitGenCodes.Add("960001") 'Adds an HMI
                frmMain.optHMIShipLoose.Checked = True
            End If
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


        If frmMain.ThisUnit.Family = "Series10" Then
            frmMain.ThisUnitGenCodes.Add("960005") 'Adds a panel if it's a series 10
        End If
        frmMain.ThisUnit.CommNodes = "2"

        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Call WriteDesignNotesReport()

        Me.Hide()
    End Sub

    Private Sub WriteDesignNotesReport()
        Dim ThisReport As System.IO.StreamWriter
        Dim i As Integer
        Dim tb As TextBox
        Dim dd As ComboBox

        Dim TubeMaterial, TubeMaterialCode, InsertLength, Config, Rating, TubesNum, FMode, Power, Fuel, DTemp, Elev, Housing, HousingMat As String
        Dim Stubb, StubbType As String

        'tempfilename = frmMain.txtProjectDirectory.Text & frmMain.ThisUnit.JobNumber & "-" & frmMain.ThisUnit.UnitNumber & "\" & "Submittal Source (Do not Distribute)\Submittal Design\" & frmMain.ThisUnit.JobNumber & "-" & frmMain.ThisUnit.UnitNumber & " - " & "HeatCo Burner Report " & Ver2FileVer(frmMain.txtUnitVersion.Text) & ".txt"
        'ThisReport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
        ThisReport = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\jlevine\Desktop\zzzz.txt", False)
        ThisReport.WriteLine("HeatCo Burner Report")
        ThisReport.WriteLine(" ")
        ThisReport.WriteLine("Slots are arranged numerically 1-9 as if looking at the heaters from the gas train side of the unit.")
        ThisReport.WriteLine(" ")
        ThisReport.WriteLine("SLOT 1 | SLOT 2 | SLOT 3")
        ThisReport.WriteLine("-------|--------|-------")
        ThisReport.WriteLine("SLOT 4 | SLOT 5 | SLOT 6")
        ThisReport.WriteLine("-------|--------|-------")
        ThisReport.WriteLine("SLOT 7 | SLOT 8 | SLOT 9")

        TubeMaterial = lstTubeMaterial.Text
        Select Case TubeMaterial
            Case Is = "409 Stainless Steel"
                TubeMaterialCode = "SS"
            Case Is = "304 Stainless Steel"
                TubeMaterialCode = "CS"
            Case Is = "439 Stainless Steel"
                TubeMaterialCode = "HS"
        End Select

        Select Case lstPower.Text
            Case Is = "120 VAC"
                Power = "1"
            Case Is = "230 VAC"
                Power = "2"
            Case Is = "208 VAC"
                Power = "3"
        End Select

        If chkPropane.Checked Then Fuel = "L" Else Fuel = "N"

        Select Case lstDesignTempRise.Text
            Case Is = "20-90°F (A-G,P,Q Configuration)"
                DTemp = "R1"
            Case Is = "20-75°F (A-G,P,Q Configuration)"
                DTemp = "R6"
            Case Is = "20-60°F (H-N,R,S Configuration)"
                DTemp = "R3"
        End Select

        'This needs fixing
        Elev = "S"
        Housing = "XX"
        HousingMat = "X"

        For i = 1 To 9
            tb = fraAPDLayout.Controls("txtLoc" & Trim(Str(i)))
            dd = fraAPDLayout.Controls("cmbLoc" & Trim(Str(i)))

            Stubb = Mid(tb.Text, 1, 2)
            If Stubb = "HM" Then
                StubbType = Mid(tb.Text, 3, 1)
                Select Case StubbType
                    Case Is = "B"
                        InsertLength = "76"
                        Rating = Mid(tb.Text, 4, 3)
                        Select Case Rating
                            Case Is = "600"
                                TubesNum = "12"
                            Case Is = "500"
                                TubesNum = "10"
                            Case Is = "400"
                                TubesNum = "8"
                            Case Is = "300"
                                TubesNum = "6"
                            Case Is = "250"
                                TubesNum = "5"
                            Case Is = "200"
                                TubesNum = "4"
                        End Select
                End Select
            End If
            Config = dd.Text
            FMode = "**"

            ThisReport.WriteLine("Slot " & Trim(Str(i)) & " Burner Selection")
            If dd.Text = "Not Used" Then
                ThisReport.WriteLine("No Burner in this slot")
            Else
                ThisReport.WriteLine(Stubb & StubbType & Rating & TubeMaterialCode & InsertLength & Config & TubesNum & FMode & Power & Fuel & DTemp & Elev & Housing & HousingMat)
            End If
        Next

        ThisReport.WriteLine(" ")
        ThisReport.WriteLine(" ")
        ThisReport.WriteLine(" ")
        ThisReport.WriteLine("End of Report")

        ThisReport.Close()
    End Sub

    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim BurnerTypes, SFanMove, GasTrainBumpout, RoofRaise, BypassTunnel, ControlStyle, OutCap, DeltaT, APD, AFlow As String

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

        BurnerTypes = ""
        If chkHMB300Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMB300.Value)) & ")" & "HMB300 "
        If chkHMB400Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMB400.Value)) & ")" & "HMB400 "
        If chkHMB500Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMB500.Value)) & ")" & "HMB500 "
        If chkHMB600Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMB500.Value)) & ")" & "HMB600 "

        If chkHMG500Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMG500.Value)) & ")" & "HMG500 "

        If chkHE750Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHE750.Value)) & ")" & "HE750 "

        If chkHMT0700Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMT0700.Value)) & ")" & "HMT1100 "
        If chkHMT1100Burner.Checked Then BurnerTypes = BurnerTypes & "(" & Trim(Str(nudHMT1100.Value)) & ")" & "HMT1100 "

        BurnerTypes = Trim(BurnerTypes)


        If chkSupplyFanRelocate.Checked Then SFanMove = "Yes" Else SFanMove = "No"

        If chkGasTrainBumpout.Checked Then GasTrainBumpout = "Yes" Else GasTrainBumpout = "No"

        If chkGasTrainRoofRaise.Checked Then RoofRaise = "Yes" Else RoofRaise = "No"

        If chkBypassTunnel.Checked Then BypassTunnel = "Yes" Else BypassTunnel = "No"

        If optSATCtrl.Checked Then ControlStyle = "SAT Control" Else ControlStyle = "-"
        If chkTempering.Checked Then ControlStyle = "SAT Control with Tempering"
        If opt100OACtrlsMode.Checked Then ControlStyle = "100OA with Mode Control"
        If opt100OACtrls.Checked Then ControlStyle = "100OA with DAT Control"
        If optGBAS.Checked Then ControlStyle = "GBAS Control"
        If optCustomCtrl.Checked Then ControlStyle = cmbCstmCtrl.Text

        OutCap = Format(Val(txtOutCap.Text), "0.0")
        DeltaT = Format(Val(txtDeltaT.Text), "0.0")
        APD = Format(Val(txtBurnerAPD.Text), "0.00")
        AFlow = Format(Val(txtBurnerAirflow.Text), "0.0")

        MySQL = "Select * FROM tblHistoryMGH_H WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryMGH_H SET BurnerTypes='" & BurnerTypes & "', SFanMove='" & SFanMove & "', " & "GasTrainBumpout='" & GasTrainBumpout & "', RoofRaise='" & RoofRaise & "', BypassTunnel='" & BypassTunnel & "', ControlStyle='" & ControlStyle & "', OutCap='" & OutCap & "', DeltaT='" & DeltaT & "', APD='" & APD & "', AFlow='" & AFlow & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryMGH_H (JobName,UnitID,Version,ModelNumber,BurnerTypes, SFanMove, GasTrainBumpout, RoofRaise, BypassTunnel, ControlStyle, OutCap, DeltaT, APD, AFlow) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & BurnerTypes & "','" & SFanMove & "','" & GasTrainBumpout & "','" & RoofRaise & "','" & BypassTunnel & "','" & ControlStyle & "','" & OutCap & "','" & DeltaT & "','" & APD & "','" & AFlow & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub UpdateCodeList()
        Dim ModCount As Integer
        Dim OnOffCount As Integer
        Dim OffLoHiCount As Integer

        ModCount = nudModCount.Value
        OnOffCount = nudOnOffCount.Value
        OffLoHiCount = nudOffLowHighCount.Value

        ModuleCodeList.Clear()

        ModuleCodeList.Add("520000")
        ModuleCodeList.Add("520010")
        'Handle the Burner Counts

        If chkHMB600Burner.Checked Then
            If nudHMB600.Value = 6 Then
                ModuleCodeList.Add("520506")
            End If
            If nudHMB600.Value = 5 Then
                ModuleCodeList.Add("520505")
            End If
            If nudHMB600.Value = 4 Then
                ModuleCodeList.Add("520504")
            End If
            If nudHMB600.Value = 3 Then
                ModuleCodeList.Add("520503")
            End If
            If nudHMB600.Value = 2 Then
                ModuleCodeList.Add("520502")
            End If
            If nudHMB600.Value = 1 Then
                ModuleCodeList.Add("520501")
            End If
        End If

        If chkHMB500Burner.Checked Then
            If nudHMB500.Value = 4 Then
                ModuleCodeList.Add("520514")
            End If
            If nudHMB500.Value = 3 Then
                ModuleCodeList.Add("520513")
            End If
            If nudHMB500.Value = 2 Then
                ModuleCodeList.Add("520512")
            End If
            If nudHMB500.Value = 1 Then
                ModuleCodeList.Add("520511")
            End If
        End If
        If chkHMG500Burner.Checked Then
            If nudHMG500.Value = 4 Then
                ModuleCodeList.Add("520584")
            End If
            If nudHMG500.Value = 3 Then
                ModuleCodeList.Add("520583")
            End If
            If nudHMG500.Value = 2 Then
                ModuleCodeList.Add("520582")
            End If
            If nudHMG500.Value = 1 Then
                ModuleCodeList.Add("520581")
            End If
        End If
        If chkHMB400Burner.Checked Then
            If nudHMB400.Value = 4 Then
                ModuleCodeList.Add("520524")
            End If
            If nudHMB400.Value = 3 Then
                ModuleCodeList.Add("520523")
            End If
            If nudHMB400.Value = 2 Then
                ModuleCodeList.Add("520522")
            End If
            If nudHMB400.Value = 1 Then
                ModuleCodeList.Add("520521")
            End If
        End If
        If chkHMB300Burner.Checked Then
            If nudHMB300.Value = 4 Then
                ModuleCodeList.Add("520534")
            End If
            If nudHMB300.Value = 3 Then
                ModuleCodeList.Add("520533")
            End If
            If nudHMB300.Value = 2 Then
                ModuleCodeList.Add("520532")
            End If
            If nudHMB300.Value = 1 Then
                ModuleCodeList.Add("520531")
            End If
        End If

        If chkHE750Burner.Checked Then
            If nudHE750.Value = 1 Then
                ModuleCodeList.Add("520601")
            End If
        End If

        If chkHMB300Burner.Checked Or chkHMB400Burner.Checked Or chkHMB500Burner.Checked Or chkHMB600Burner.Checked Or chkHMG500Burner.Checked Then
            ModuleCodeList.Add("520500")
        End If

        If chkHE750Burner.Checked Then
            ModuleCodeList.Add("520600")
        End If

        If chkHMT1100Burner.Checked Then
            If nudHMT1100.Value = 4 Then
                ModuleCodeList.Add("520T14")
            End If
            If nudHMT1100.Value = 3 Then
                ModuleCodeList.Add("520T13")
            End If
            If nudHMT1100.Value = 2 Then
                ModuleCodeList.Add("520T12")
            End If
            If nudHMT1100.Value = 1 Then
                ModuleCodeList.Add("520T11")
            End If
        End If

        If chkHMT1100Burner.Checked Then
            If nudHMT0700.Value = 4 Then
                ModuleCodeList.Add("520T74")
            End If
            If nudHMT0700.Value = 3 Then
                ModuleCodeList.Add("520T73")
            End If
            If nudHMT0700.Value = 2 Then
                ModuleCodeList.Add("520T72")
            End If
            If nudHMT0700.Value = 1 Then
                ModuleCodeList.Add("520T71")
            End If
        End If

        'Handle the gas train
        ModuleCodeList.Add("520030")
        ModuleCodeList.Add("520031")
        ModuleCodeList.Add("520032")
        ModuleCodeList.Add("520033")
        ModuleCodeList.Add("520034")

        'handle the controls
        ModuleCodeList.Add("520101")
        If optSATCtrl.Checked Then
            If optSE.Checked Then
                ModuleCodeList.Add("520111")
                ModuleCodeList.Add("520113")
            End If
            If optIPU.Checked Then
                ModuleCodeList.Add("520110")
                ModuleCodeList.Add("520112")
                If ((ModCount = 1) And (OnOffCount = 0) And (OffLoHiCount = 0)) Then
                    ModuleCodeList.Add("520305")
                End If
            End If
            If chkTempering.Checked Then ModuleCodeList.Add("520115")

        End If
        If opt100OACtrls.Checked Then
            ModuleCodeList.Add("520120")
        End If
        If optCustomCtrl.Checked Then
            ModuleCodeList.Add("520105")
        End If
        If chkSupplyFanRelocate.Checked Then
            ModuleCodeList.Add("520900")
            ModuleCodeList.Add("520905")
        End If
        If chkGasTrainBumpout.Checked Then
            ModuleCodeList.Add("520910")
        End If

        If chkGasTrainRoofRaise.Checked Then
            ModuleCodeList.Add("520911")
        End If

        If chkBypassTunnel.Checked Then
            ModuleCodeList.Add("520920")
        End If

        If chkManualBalanceDamper.Checked Then
            ModuleCodeList.Add("520921")
        End If

        ModuleCodeList.Add("520199")

        PerformDesignCautionScan(False)

    End Sub
    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        'Version 1.0 - Requires specificity to be performed when inserted.

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '520%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '520%'"
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
        If optSE.Checked Then
            frmMain.lstRequiredFactoryItems.Items.Add("Unit Equipped with SE Controller")
        Else
            frmMain.lstRequiredFactoryItems.Items.Add("Unit Equipped with IPU Controller")
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
        Dim ModWeight, DampWeight, FlueWeight, WallWeight As Integer


        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MGH_H")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Gas Heat Heatco")

        ModWeight = 0
        'Handle HMB Module Weights
        If chkHMB600Burner.Checked Then ModWeight = ModWeight + nudHMB600.Value * 285
        If chkHMB500Burner.Checked Then ModWeight = ModWeight + nudHMB500.Value * 265
        If chkHMB400Burner.Checked Then ModWeight = ModWeight + nudHMB400.Value * 186
        If chkHMB300Burner.Checked Then ModWeight = ModWeight + nudHMB300.Value * 170

        'Handle HMG Module Weights
        If chkHMG500Burner.Checked Then ModWeight = ModWeight + nudHMG500.Value * 234

        'Handle the HE Module Weights
        If chkHE750Burner.Checked Then ModWeight = ModWeight + nudHE750.Value * 921

        'Handle the HMT Module Weights
        If chkHMT1100Burner.Checked Then ModWeight = ModWeight + nudHMT1100.Value * 550
        If chkHMT0700Burner.Checked Then ModWeight = ModWeight + nudHMT0700.Value * 415

        'Handle Wall, Flue, and Damper Weights
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                If chkManualBalanceDamper.Checked Then DampWeight = 25
                WallWeight = 115
                FlueWeight = 55
            Case Is = "Series100"
                If chkManualBalanceDamper.Checked Then DampWeight = 40
                WallWeight = 195
                FlueWeight = 80
        End Select
        tempWeight = Format(ModWeight + 1.1 * (DampWeight + WallWeight + FlueWeight), "0.0")

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim tempAPD As String
        Dim i As Integer

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.SSE = txtSSE.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"
        frmMain.ThisUnitHeatPerf.HeatType = "Gas"
        tempAPD = Format(Val(txtBurnerAPD.Text) * 1.1, "0.00")
        If frmMain.ThisUnit.Family = "Series100" Then
            frmMain.ThisUnitSFanPerf.StaticNameYpal.Add("Gas Heat Exchanger")
            frmMain.ThisUnitSFanPerf.StaticDataYpal.Add(tempAPD)
        End If
        frmMain.ThisUnitSFanPerf.ESP = frmMain.ThisUnitSFanPerf.ESP - (Val(tempAPD))

        For i = 0 To frmMain.ThisUnitSFanPerf.StaticNameYpal.Count - 1
            If frmMain.ThisUnitSFanPerf.StaticNameYpal(i) = "External Static Pressure" Then
                frmMain.ThisUnitSFanPerf.StaticDataYpal(i) = frmMain.ThisUnitSFanPerf.StaticDataYpal(i) - (Val(tempAPD))
                Exit For
            End If
        Next


    End Sub
    Private Sub frmMGH_H_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

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
        If frmMain.ThisUnit.Family = "Series100" Then
            optIPU.Enabled = True
            optIPU.Checked = True
            optSE.Enabled = False
        End If

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

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        Call InitializeAPDPage()

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

        txtSFanAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
        txtBurnerAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
        txtBypassAirflow.Text = "0"

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
    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim deltat As Double

        txtSSE.Text = DetermineEfficiency()
        txtOutCap.Text = Format(Val(txtInputCap.Text) * Val(txtSSE.Text) / 100, "0.0")
        deltat = Val(txtOutCap.Text) * 1000 / Val(txtHeatAF.Text) / 1.085
        txtDeltaT.Text = Format(deltat, "0.0")
        txtLAT.Text = Format(Val(txtEAT.Text) + deltat, "0.0")
        cmdBurnerAPDCalc.PerformClick()
        TabControl1.SelectTab("tpgPerformance")

    End Sub

    Private Function DetermineEfficiency() As String
        Dim sse As String
        sse = "-99.0"
        If chkHE750Burner.Checked Then sse = "80.0"
        If chkHMB300Burner.Checked Then sse = "80.0"
        If chkHMB400Burner.Checked Then sse = "80.0"
        If chkHMB500Burner.Checked Then sse = "80.0"
        If chkHMB600Burner.Checked Then sse = "80.0"
        If chkHMG500Burner.Checked Then sse = "80.0"
        If chkHMT0700Burner.Checked Then sse = "80.0"
        If chkHMT1100Burner.Checked Then sse = "80.0"

        Return sse
    End Function

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        Dim ModCount As Integer
        Dim OnOffCount As Integer
        Dim OffLoHiCount As Integer
        Dim BurnerCount As Integer

        BurnerCount = nudHMB200.Value + nudHMB250.Value + nudHMB300.Value + nudHMB400.Value + nudHMB500.Value + nudHMB600.Value + nudHMG500.Value + nudHMT0700.Value + nudHMT1100.Value + nudHE750.Value

        'guess the counts and populate
        ModCount = 1
        OnOffCount = BurnerCount - 1
        OffLoHiCount = 0

        nudModCount.Value = ModCount
        nudOnOffCount.Value = OnOffCount
        nudOffLowHighCount.Value = OffLoHiCount


        TabControl1.SelectTab("tpgControls")
    End Sub
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs)
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub chkHMB600Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB600Burner.CheckedChanged
        If chkHMB600Burner.Checked Then nudHMB600.Value = 1 Else nudHMB600.Value = 0
    End Sub

    Private Sub nudHMB600_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB600.ValueChanged
        If nudHMB600.Value = 0 Then chkHMB600Burner.Checked = False Else chkHMB600Burner.Checked = True

    End Sub

    Private Sub chkHMB500Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB500Burner.CheckedChanged
        If chkHMB500Burner.Checked Then nudHMB500.Value = 1 Else nudHMB500.Value = 0
    End Sub

    Private Sub nudHMB500_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB500.ValueChanged
        If nudHMB500.Value = 0 Then chkHMB500Burner.Checked = False Else chkHMB500Burner.Checked = True

    End Sub

    Private Sub chkHMB400Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB400Burner.CheckedChanged
        If chkHMB400Burner.Checked Then nudHMB400.Value = 1 Else nudHMB400.Value = 0
    End Sub

    Private Sub nudHMB400_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB400.ValueChanged
        If nudHMB400.Value = 0 Then chkHMB400Burner.Checked = False Else chkHMB400Burner.Checked = True

    End Sub
    Private Sub chkHMB300Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB300Burner.CheckedChanged
        If chkHMB300Burner.Checked Then nudHMB300.Value = 1 Else nudHMB300.Value = 0
    End Sub

    Private Sub nudHMB300_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB300.ValueChanged
        If nudHMB300.Value = 0 Then chkHMB300Burner.Checked = False Else chkHMB300Burner.Checked = True

    End Sub

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked Then
            chkTempering.Enabled = True
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
        End If
    End Sub

    Private Sub ChkHE750Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHE750Burner.CheckedChanged
        If chkHE750Burner.Checked Then nudHE750.Value = 1 Else nudHE750.Value = 0

    End Sub

    Private Sub OptSE_CheckedChanged(sender As Object, e As EventArgs) Handles optSE.CheckedChanged
        If optIPU.Checked Then
            optSATCtrl.Enabled = True
            optSATCtrl.Checked = True
            chkTempering.Checked = False
            chkTempering.Enabled = True
            opt100OACtrls.Enabled = True
            optGBAS.Enabled = True
            optCustomCtrl.Enabled = True
        End If
    End Sub

    Private Sub OptIPU_CheckedChanged(sender As Object, e As EventArgs) Handles optIPU.CheckedChanged
        If optIPU.Checked Then
            optSATCtrl.Enabled = True
            optSATCtrl.Checked = True
            chkTempering.Checked = False
            chkTempering.Enabled = False
            opt100OACtrls.Enabled = False
            optGBAS.Enabled = False
            optCustomCtrl.Enabled = False
        End If
    End Sub

    Private Sub ChkBypassTunnel_CheckedChanged(sender As Object, e As EventArgs) Handles chkBypassTunnel.CheckedChanged
        If chkBypassTunnel.Checked Then
            chkManualBalanceDamper.Enabled = True
        Else
            chkManualBalanceDamper.Enabled = False
            chkManualBalanceDamper.Checked = False
        End If
    End Sub

    Private Sub CmdBurnerAPDCalc_Click(sender As Object, e As EventArgs) Handles cmdBurnerAPDCalc.Click

        TabControl1.SelectTab("tpgAPDCalcs")
        txtBypassAirflow.Text = Str(Val(txtSFanAirflow.Text) - Val(txtBurnerAirflow.Text))
    End Sub

    Private Sub chkHMT1100Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMT1100Burner.CheckedChanged
        If chkHMT1100Burner.Checked Then nudHMT1100.Value = 1 Else nudHMT1100.Value = 0
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "100OA"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Call InitializeAPDPage()
        Call PopulateAPDMasterList()
        Call PopulateAPDPage("1")

    End Sub

    Private Sub InitializeAPDPage()

        Dim dd As ComboBox
        Dim pb As PictureBox
        Dim cb As CheckBox

        For Each pb In fraAPDLayout.Controls.OfType(Of PictureBox)
            pb.LoadAsync("S:\FUG\Resources\Mods\MGH_H\ConfigImages\InkedNotUsed_LI.jpg")
        Next

        For Each dd In fraAPDLayout.Controls.OfType(Of ComboBox)
            dd.Items.Clear()
            dd.Items.Add("Not Used")
            dd.Text = "Not Used"
        Next

        For Each cb In fraAPDLayout.Controls.OfType(Of CheckBox)
            cb.Checked = False
            cb.Enabled = True
        Next

    End Sub

    Private Sub PopulateAPDMasterList()
        Dim cb As CheckBox
        Dim nud As NumericUpDown
        Dim bCount As Integer

        BurnerList.Clear()

        For Each cb In fraBurners.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                For Each nud In fraBurners.Controls.OfType(Of NumericUpDown)
                    bCount = 0
                    If nud.Name = "nud" & cb.Text Then
                        bCount = nud.Value
                    End If
                    For i = 1 To bCount
                        BurnerList.Add(cb.Text)
                    Next i
                Next
            End If
        Next
    End Sub

    Private Sub PopulateStyleDD(SlotID As String)
        Dim dd As ComboBox
        For Each dd In fraAPDLayout.Controls.OfType(Of ComboBox)
            If dd.Name = "cmbLoc" & SlotID Then
                dd.Items.Clear()
                dd.Items.Add("Unselected")
                dd.Items.Add("A")
                dd.Items.Add("B")
                dd.Items.Add("C")
                dd.Items.Add("D")
                dd.Items.Add("E")
                dd.Items.Add("F")
                dd.Items.Add("G")
                dd.Items.Add("H")
                dd.Items.Add("I")
                dd.Items.Add("J")
                dd.Items.Add("K")
                dd.Items.Add("L")
                dd.Items.Add("M")
                dd.Items.Add("N")
                dd.Items.Add("O")
                dd.Items.Add("P")
                dd.Items.Add("Q")
                dd.Items.Add("R")
                dd.Items.Add("S")
                dd.Text = "Unselected"

            End If
        Next
    End Sub

    Private Sub PopulateAPDPage(SlotID As String)

        lstBurnersAvail.Items.Clear()

        For i = 0 To BurnerList.Count - 1
            lstBurnersAvail.Items.Add(BurnerList.Item(i))
        Next i

    End Sub

    Private Sub lstBurnersAvail_MouseDown(sender As Object, e As MouseEventArgs) Handles lstBurnersAvail.MouseDown
        lstBurnersAvail.DoDragDrop(lstBurnersAvail.Text, DragDropEffects.Move)
    End Sub
    Private Sub txtLoc1_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc1.DragDrop
        txtLoc1.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("1")

    End Sub
    Private Sub txtLoc2_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc2.DragDrop
        txtLoc2.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("2")

    End Sub
    Private Sub txtLoc3_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc3.DragDrop
        txtLoc3.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("3")

    End Sub
    Private Sub txtLoc4_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc4.DragDrop
        txtLoc4.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("4")

    End Sub
    Private Sub txtLoc5_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc5.DragDrop
        txtLoc5.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("5")

    End Sub
    Private Sub txtLoc6_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc6.DragDrop
        txtLoc6.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("6")

    End Sub
    Private Sub txtLoc7_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc7.DragDrop
        txtLoc7.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("7")

    End Sub
    Private Sub txtLoc8_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc8.DragDrop
        txtLoc8.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("8")

    End Sub
    Private Sub txtLoc9_DragDrop(sender As Object, e As DragEventArgs) Handles txtLoc9.DragDrop
        txtLoc9.Text = e.Data.GetData(DataFormats.Text).ToString()
        lstBurnersAvail.Items.RemoveAt(lstBurnersAvail.SelectedIndex)
        Call PopulateStyleDD("9")

    End Sub

    Private Sub txtLoc1_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc1.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc2_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc2.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc3_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc3.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc4_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc4.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc5_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc5.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc6_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc6.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc7_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc7.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc8_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc8.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub txtLoc9_DragEnter(sender As Object, e As DragEventArgs) Handles txtLoc9.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub DisableRightExits()
        chkOutlet7.Enabled = False
        chkOutlet8.Enabled = False
        chkOutlet9.Enabled = False
        chkOutlet10.Enabled = False
        chkOutlet11.Enabled = False
        chkOutlet12.Enabled = False
    End Sub
    Private Sub DisableBottomExits()
        chkOutlet1.Enabled = False
        chkOutlet2.Enabled = False
        chkOutlet3.Enabled = False
        chkOutlet4.Enabled = False
        chkOutlet5.Enabled = False
        chkOutlet6.Enabled = False
    End Sub
    Private Sub DisableTopInlets()
        chkInlet13.Enabled = False
        chkInlet14.Enabled = False
        chkInlet15.Enabled = False
        chkInlet16.Enabled = False
        chkInlet17.Enabled = False
        chkInlet18.Enabled = False
        chkInlet19.Enabled = False
        chkInlet20.Enabled = False
        chkInlet21.Enabled = False
        chkInlet22.Enabled = False
        chkInlet23.Enabled = False
        chkInlet24.Enabled = False
    End Sub

    Private Sub DisableLeftInlets()
        chkInlet1.Enabled = False
        chkInlet2.Enabled = False
        chkInlet3.Enabled = False
        chkInlet4.Enabled = False
        chkInlet5.Enabled = False
        chkInlet6.Enabled = False
        chkInlet7.Enabled = False
        chkInlet8.Enabled = False
        chkInlet9.Enabled = False
        chkInlet10.Enabled = False
        chkInlet11.Enabled = False
        chkInlet12.Enabled = False
    End Sub
    Private Sub chkOutlet1_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet1.CheckedChanged
        If chkOutlet1.Checked Then Call DisableRightExits()
    End Sub
    Private Sub chkOutlet2_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet2.CheckedChanged
        If chkOutlet2.Checked Then Call DisableRightExits()
    End Sub
    Private Sub chkOutlet3_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet3.CheckedChanged
        If chkOutlet3.Checked Then Call DisableRightExits()
    End Sub
    Private Sub chkOutlet4_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet3.CheckedChanged
        If chkOutlet4.Checked Then Call DisableRightExits()
    End Sub
    Private Sub chkOutlet5_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet5.CheckedChanged
        If chkOutlet5.Checked Then Call DisableRightExits()
    End Sub
    Private Sub chkOutlet6_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet6.CheckedChanged
        If chkOutlet6.Checked Then Call DisableRightExits()
    End Sub

    Private Sub chkOutlet7_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet7.CheckedChanged
        If chkOutlet7.Checked Then Call DisableBottomExits()
    End Sub
    Private Sub chkOutlet8_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet8.CheckedChanged
        If chkOutlet8.Checked Then Call DisableBottomExits()
    End Sub
    Private Sub chkOutlet9_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet9.CheckedChanged
        If chkOutlet9.Checked Then Call DisableBottomExits()
    End Sub
    Private Sub chkOutlet10_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet10.CheckedChanged
        If chkOutlet10.Checked Then Call DisableBottomExits()
    End Sub
    Private Sub chkOutlet11_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet11.CheckedChanged
        If chkOutlet11.Checked Then Call DisableBottomExits()
    End Sub
    Private Sub chkOutlet12_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutlet12.CheckedChanged
        If chkOutlet12.Checked Then Call DisableBottomExits()
    End Sub



    Private Sub chkInlet1_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet1.CheckedChanged
        If chkInlet1.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet2_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet2.CheckedChanged
        If chkInlet2.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet3_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet3.CheckedChanged
        If chkInlet3.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet4_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet4.CheckedChanged
        If chkInlet4.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet5_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet5.CheckedChanged
        If chkInlet5.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet6_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet6.CheckedChanged
        If chkInlet6.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet7_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet7.CheckedChanged
        If chkInlet7.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet8_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet8.CheckedChanged
        If chkInlet8.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet9_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet9.CheckedChanged
        If chkInlet9.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet10_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet10.CheckedChanged
        If chkInlet10.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet11_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet11.CheckedChanged
        If chkInlet11.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet12_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet12.CheckedChanged
        If chkInlet12.Checked Then Call DisableTopInlets()
    End Sub

    Private Sub chkInlet13_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet13.CheckedChanged
        If chkInlet13.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet14_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet14.CheckedChanged
        If chkInlet14.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet15_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet15.CheckedChanged
        If chkInlet15.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet16_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet16.CheckedChanged
        If chkInlet16.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet17_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet17.CheckedChanged
        If chkInlet17.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet18_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet18.CheckedChanged
        If chkInlet18.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet19_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet19.CheckedChanged
        If chkInlet19.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet20_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet20.CheckedChanged
        If chkInlet20.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet21_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet21.CheckedChanged
        If chkInlet21.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet22_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet22.CheckedChanged
        If chkInlet22.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet23_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet23.CheckedChanged
        If chkInlet23.Checked Then Call DisableLeftInlets()
    End Sub

    Private Sub chkInlet24_CheckedChanged(sender As Object, e As EventArgs) Handles chkInlet24.CheckedChanged
        If chkInlet24.Checked Then Call DisableLeftInlets()
    End Sub

    Private Function Row1InChecks() As Integer
        Dim Row1Checks As Integer

        If chkInlet1.Checked Then Row1Checks = Row1Checks + 1
        If chkInlet2.Checked Then Row1Checks = Row1Checks + 1
        If chkInlet3.Checked Then Row1Checks = Row1Checks + 1
        If chkInlet4.Checked Then Row1Checks = Row1Checks + 1
        Return Row1Checks
    End Function

    Private Function Row2InChecks() As Integer
        Dim Row2Checks As Integer

        If chkInlet5.Checked Then Row2Checks = Row2Checks + 1
        If chkInlet6.Checked Then Row2Checks = Row2Checks + 1
        If chkInlet7.Checked Then Row2Checks = Row2Checks + 1
        If chkInlet8.Checked Then Row2Checks = Row2Checks + 1

        Return Row2Checks

    End Function

    Private Function Row3InChecks() As Integer
        Dim Row3Checks As Integer

        If chkInlet9.Checked Then Row3Checks = Row3Checks + 1
        If chkInlet10.Checked Then Row3Checks = Row3Checks + 1
        If chkInlet11.Checked Then Row3Checks = Row3Checks + 1
        If chkInlet12.Checked Then Row3Checks = Row3Checks + 1

        Return Row3Checks

    End Function

    Private Function Col1InChecks() As Integer
        Dim ColInChecks As Integer
        If chkInlet13.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet14.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet15.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet16.Checked Then ColInChecks = ColInChecks + 1
        Return ColInChecks
    End Function

    Private Function Col2InChecks() As Integer
        Dim ColInChecks As Integer
        If chkInlet17.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet18.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet19.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet20.Checked Then ColInChecks = ColInChecks + 1
        Return ColInChecks
    End Function

    Private Function Col3InChecks() As Integer
        Dim ColInChecks As Integer
        If chkInlet21.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet22.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet23.Checked Then ColInChecks = ColInChecks + 1
        If chkInlet24.Checked Then ColInChecks = ColInChecks + 1
        Return ColInChecks
    End Function

    Private Function Col1ExitPercent() As Double
        Dim colper As Double
        colper = Col1OutChecks() / TotalOutChecks()
        Return colper

    End Function

    Private Function Col2ExitPercent() As Double
        Dim colper As Double
        colper = Col2OutChecks() / TotalOutChecks()
        Return colper

    End Function

    Private Function Col3ExitPercent() As Double
        Dim colper As Double
        colper = Col3OutChecks() / TotalOutChecks()
        Return colper

    End Function

    Private Function Col1OutChecks() As Integer
        Dim ColOutChecks As Integer
        If chkOutlet1.Checked Then ColOutChecks = 1
        If chkOutlet2.Checked Then ColOutChecks = ColOutChecks + 1

        Return ColOutChecks
    End Function

    Private Function Col2OutChecks() As Integer
        Dim ColOutChecks As Integer
        If chkOutlet3.Checked Then ColOutChecks = 1
        If chkOutlet4.Checked Then ColOutChecks = ColOutChecks + 1

        Return ColOutChecks
    End Function

    Private Function Col3OutChecks() As Integer
        Dim ColOutChecks As Integer
        If chkOutlet5.Checked Then ColOutChecks = 1
        If chkOutlet6.Checked Then ColOutChecks = ColOutChecks + 1

        Return ColOutChecks
    End Function

    Private Function TotalOutChecks() As Integer
        Dim TotalChecks As Integer
        For Each cb In fraAPDLayout.Controls.OfType(Of CheckBox)
            If ((Mid(cb.Name, 1, 9) = "chkOutlet") And (cb.Checked)) Then
                If cb.Checked Then TotalChecks = TotalChecks + 1
            End If
        Next

        Return TotalChecks
    End Function


    Private Function TotalInChecks() As Integer
        Dim TotalChecks As Integer
        For Each cb In fraAPDLayout.Controls.OfType(Of CheckBox)
            If ((Mid(cb.Name, 1, 8) = "chkInlet") And (cb.Checked)) Then
                If cb.Checked Then TotalChecks = TotalChecks + 1
            End If
        Next

        Return TotalChecks
    End Function

    Private Function DownFlow() As Boolean
        Dim df As Boolean
        If chkOutlet1.Enabled Then df = True

        Return df

    End Function


    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click

        Dim AFlow As Double
        Dim Row1Flow, Row2Flow, Row3Flow As Double
        Dim Row1Per, Row2Per, Row3Per As Double
        Dim Col1Flow, Col2Flow, Col3Flow As Double
        Dim Col1Per, Col2Per, Col3Per As Double
        Dim Row1Checks, Row2Checks, Row3Checks, Col1Checks, Col2Checks, Col3Checks, TotalChecks As Integer

        Row1Checks = Row1InChecks()
        Row2Checks = Row2InChecks()
        Row3Checks = Row3InChecks()

        Col1Checks = Col1InChecks()
        Col2Checks = Col2InChecks()
        Col3Checks = Col3InChecks()

        TotalChecks = TotalInChecks()
        Row1Per = Row1Checks / TotalChecks
        Row2Per = Row2Checks / TotalChecks
        Row3Per = Row3Checks / TotalChecks
        Col1Per = Col1Checks / TotalChecks
        Col2Per = Col2Checks / TotalChecks
        Col3Per = Col3Checks / TotalChecks

        AFlow = Val(txtHeatAF.Text)

        Row1Flow = AFlow * Row1Per
        Row2Flow = AFlow * Row2Per
        Row3Flow = AFlow * Row3Per
        Col1Flow = AFlow * Col1Per
        Col2Flow = AFlow * Col2Per
        Col3Flow = AFlow * Col3Per

        lblAFRow1.Text = Format(Row1Flow, "0")
        lblAFRow2.Text = Format(Row2Flow, "0")
        lblAFRow3.Text = Format(Row3Flow, "0")
        lblAFCol1.Text = Format(Col1Flow, "0")
        lblAFCol2.Text = Format(Col2Flow, "0")
        lblAFCol3.Text = Format(Col3Flow, "0")

        Call Slot1Flow()
        Call Slot2Flow()
        Call Slot3Flow()
        Call Slot4Flow()
        Call Slot5Flow()
        Call Slot6Flow()
        Call Slot7Flow()
        Call Slot8Flow()
        Call Slot9Flow()

        Call CalculateAPD()

    End Sub

    Private Sub CalculateAPD()
        Dim APDR1C1, APDR1C2, APDR1C3, APDR2C1, APDR2C2, APDR2C3, APDR3C1, APDR3C2, APDR3C3 As Double
        Dim S1APD, S2APD, S3APD, S4APD, S5APD, S6APD, S7APD, S8APD, S9APD As Double
        Dim MaxAPD As Double

        S1APD = Val(lblAPDLoc1.Text)
        S2APD = Val(lblAPDLoc2.Text)
        S3APD = Val(lblAPDLoc3.Text)
        S4APD = Val(lblAPDLoc4.Text)
        S5APD = Val(lblAPDLoc5.Text)
        S6APD = Val(lblAPDLoc6.Text)
        S7APD = Val(lblAPDLoc7.Text)
        S8APD = Val(lblAPDLoc8.Text)
        S9APD = Val(lblAPDLoc9.Text)

        APDR1C1 = S1APD + S4APD + S7APD
        APDR1C2 = S1APD + S2APD + S5APD + S8APD
        APDR1C3 = S1APD + S2APD + S3APD + S6APD + S9APD
        APDR2C1 = S4APD + S7APD
        APDR2C2 = S4APD + S5APD + S8APD
        APDR2C3 = S4APD + S5APD + S6APD + S9APD
        APDR3C1 = S7APD
        APDR3C2 = S7APD + S8APD
        APDR3C3 = S7APD + S8APD + S9APD

        MaxAPD = APDR1C1
        If APDR1C2 > MaxAPD Then MaxAPD = APDR1C2
        If APDR1C3 > MaxAPD Then MaxAPD = APDR1C3
        If APDR2C1 > MaxAPD Then MaxAPD = APDR2C1
        If APDR2C2 > MaxAPD Then MaxAPD = APDR2C2
        If APDR2C3 > MaxAPD Then MaxAPD = APDR2C3
        If APDR3C1 > MaxAPD Then MaxAPD = APDR3C1
        If APDR3C2 > MaxAPD Then MaxAPD = APDR3C2
        If APDR3C3 > MaxAPD Then MaxAPD = APDR3C3

        lblAPDSystem.Text = Format(MaxAPD, "0.00")
        txtAPDCalc.Text = Format(MaxAPD, "0.00")

    End Sub

    Private Sub Slot1Flow()
        Dim Myflow As Double
        Myflow = 0

        If HorizInlet() Then
            Myflow = Val(lblAFRow1.Text)
        Else
            Myflow = Val(lblAFCol1.Text)
        End If

        If Myflow < 0 Then Myflow = 0
        lblLoc1.Text = Format(Myflow, "0")
        lblAPDLoc1.Text = Format(ModuleAPD(Myflow, txtLoc1.Text, cmbLoc1.Text), "0.00")

    End Sub

    Private Sub Slot2Flow()
        Dim Myflow As Double
        Dim Col1Loss As Double

        Myflow = 0

        If HorizInlet() Then
            Myflow = Val(lblAFRow1.Text)
            Col1Loss = (Col1ExitPercent() * Val(lblAFRow1.Text))
            Myflow = Myflow - Col1Loss
        Else

        End If

        If Myflow < 0 Then Myflow = 0
        lblLoc2.Text = Format(Myflow, "0")
        lblAPDLoc2.Text = Format(ModuleAPD(Myflow, txtLoc2.Text, cmbLoc2.Text), "0.00")
    End Sub
    Private Sub Slot3Flow()
        Dim Myflow As Double
        Dim Col1Loss, Col2Loss
        Myflow = 0

        If HorizInlet() Then
            Col1Loss = (Col1ExitPercent() * Val(lblAFRow1.Text))
            Col2Loss = (Col2ExitPercent() * Val(lblAFRow1.Text))
            Myflow = Val(lblAFRow1.Text) - Col1Loss - Col2Loss
        Else

        End If

        If Myflow < 0 Then Myflow = 0
        lblLoc3.Text = Format(Myflow, "0")
        lblAPDLoc3.Text = Format(ModuleAPD(Myflow, txtLoc3.Text, cmbLoc3.Text), "0.00")

    End Sub
    Private Sub Slot4Flow()
        Dim MyFlow As Double
        Dim Row1Gain As Double

        MyFlow = 0
        If HorizInlet() Then
            MyFlow = Val(lblAFRow2.Text)
            Row1Gain = Val(lblAFRow1.Text) * Col1ExitPercent()
            MyFlow = MyFlow + Row1Gain
        Else

        End If


        If MyFlow < 0 Then MyFlow = 0
        lblLoc4.Text = Format(MyFlow, "0")
        lblAPDLoc4.Text = Format(ModuleAPD(MyFlow, txtLoc4.Text, cmbLoc4.Text), "0.00")

    End Sub

    Private Sub Slot5Flow()
        Dim MyFlow As Double
        Dim Col1Loss As Double
        Dim Row1Gain As Double


        If HorizInlet() Then
            MyFlow = Val(lblAFRow2.Text)
            Col1Loss = (Col1ExitPercent() * Val(lblAFRow2.Text))
            Row1Gain = (Col2ExitPercent() * Val(lblAFRow1.Text))
            MyFlow = MyFlow - Col1Loss + Row1Gain
        Else

        End If

        If MyFlow < 0 Then MyFlow = 0
        lblLoc5.Text = Format(MyFlow, "0")
        lblAPDLoc5.Text = Format(ModuleAPD(MyFlow, txtLoc5.Text, cmbLoc5.Text), "0.00")

    End Sub

    Private Sub Slot6Flow()
        Dim MyFlow As Double
        Dim Col1Loss, Col2Loss As Double
        Dim Row1Gain As Double

        If HorizInlet() Then
            MyFlow = Val(lblAFRow2.Text)
            Col1Loss = (Col1ExitPercent() * Val(lblAFRow2.Text))
            Col2Loss = (Col2ExitPercent() * Val(lblAFRow2.Text))
            Row1Gain = Val(lblLoc3.Text)
            MyFlow = MyFlow - Col1Loss - Col2Loss + Row1Gain
        Else

        End If

        If MyFlow < 0 Then MyFlow = 0
        lblLoc6.Text = Format(MyFlow, "0")
        lblAPDLoc6.Text = Format(ModuleAPD(MyFlow, txtLoc6.Text, cmbLoc6.Text), "0.00")
    End Sub

    Private Sub Slot7Flow()
        Dim MyFlow As Double
        Dim Row2Gain As Double

        MyFlow = 0

        If HorizInlet() Then
            MyFlow = Val(lblAFRow3.Text)
            Row2Gain = Val(lblLoc4.Text) * Col1ExitPercent()
            MyFlow = MyFlow + Row2Gain
        Else

        End If

        If MyFlow < 0 Then MyFlow = 0
        lblLoc7.Text = Format(MyFlow, "0")
        lblAPDLoc7.Text = Format(ModuleAPD(MyFlow, txtLoc7.Text, cmbLoc7.Text), "0.00")


    End Sub

    Private Sub Slot8Flow()
        Dim MyFlow As Double
        Dim Col1Loss As Double
        Dim Row2Gain As Double


        If HorizInlet() Then
            MyFlow = Val(lblAFRow3.Text)
            Col1Loss = (Col1ExitPercent() * Val(lblLoc7.Text))
            Row2Gain = (Col2ExitPercent() * Val(lblLoc5.Text))
            MyFlow = MyFlow - Col1Loss + Row2Gain
        Else

        End If

        If MyFlow < 0 Then MyFlow = 0
        lblLoc8.Text = Format(MyFlow, "0")
        lblAPDLoc8.Text = Format(ModuleAPD(MyFlow, txtLoc8.Text, cmbLoc8.Text), "0.00")
    End Sub

    Private Sub Slot9Flow()
        Dim MyFlow As Double
        Dim Col1Loss, Col2Loss As Double
        Dim Row2Gain As Double

        If HorizInlet() Then
            MyFlow = Val(lblAFRow3.Text)
            Col1Loss = (Col1ExitPercent() * Val(lblLoc7.Text))
            Col2Loss = (Col2ExitPercent() * Val(lblLoc8.Text))
            Row2Gain = Val(lblLoc6.Text)
            MyFlow = MyFlow - Col1Loss - Col2Loss + Row2Gain
        Else

        End If

        If MyFlow < 0 Then MyFlow = 0
        lblLoc9.Text = Format(MyFlow, "0")
        lblAPDLoc9.Text = Format(ModuleAPD(MyFlow, txtLoc9.Text, cmbLoc9.Text), "0.00")

    End Sub

    Private Function ConfigFileName(cfg As String) As String
        Dim FileName As String

        Select Case cfg
            Case Is = "A"
                FileName = "ConfigA.png"
            Case Is = "B"
                FileName = "ConfigB.png"
            Case Is = "C"
                FileName = "ConfigC.png"
            Case Is = "D"
                FileName = "ConfigD.png"
            Case Is = "E"
                FileName = "ConfigE.png"
            Case Is = "F"
                FileName = "ConfigF.png"
            Case Is = "G"
                FileName = "ConfigG.png"
            Case Is = "H"
                FileName = "ConfigH.png"
            Case Is = "I"
                FileName = "ConfigI.png"
            Case Is = "J"
                FileName = "ConfigJ.png"
            Case Is = "K"
                FileName = "ConfigK.png"
            Case Is = "L"
                FileName = "ConfigL.png"
            Case Is = "M"
                FileName = "ConfigM.png"
            Case Is = "N"
                FileName = "ConfigN.png"
            Case Is = "O"
                FileName = "ConfigO.png"
            Case Is = "P"
                FileName = "ConfigP.png"
            Case Is = "Q"
                FileName = "ConfigQ.png"
            Case Is = "R"
                FileName = "ConfigR.png"
            Case Is = "S"
                FileName = "ConfigS.png"
            Case Is = "Not Used"
                FileName = "InkedNotUsed_LI.jpg"
            Case Is = "Unselected"
                FileName = "InkedConfigRqd.jpg"
            Case Else
                FileName = "InkedNotUsed_LI.jpg"
        End Select

        Return FileName

    End Function

    Private Sub cmbLoc1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc1.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc1.LoadAsync(FilePath & ConfigFileName(cmbLoc1.Text))
    End Sub

    Private Sub cmbLoc2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc2.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc2.LoadAsync(FilePath & ConfigFileName(cmbLoc2.Text))
    End Sub

    Private Sub cmbLoc3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc3.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc3.LoadAsync(FilePath & ConfigFileName(cmbLoc3.Text))
    End Sub

    Private Sub cmbLoc4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc4.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc4.LoadAsync(FilePath & ConfigFileName(cmbLoc4.Text))
    End Sub

    Private Sub cmbLoc5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc5.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc5.LoadAsync(FilePath & ConfigFileName(cmbLoc5.Text))
    End Sub

    Private Sub cmbLoc6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc6.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc6.LoadAsync(FilePath & ConfigFileName(cmbLoc6.Text))
    End Sub

    Private Sub cmbLoc7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc7.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc7.LoadAsync(FilePath & ConfigFileName(cmbLoc7.Text))
    End Sub

    Private Sub cmbLoc8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc8.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc8.LoadAsync(FilePath & ConfigFileName(cmbLoc8.Text))
    End Sub

    Private Sub cmbLoc9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoc9.SelectedIndexChanged
        Dim FilePath As String
        FilePath = "S:\FUG\Resources\Mods\MGH_H\ConfigImages\"

        picLoc9.LoadAsync(FilePath & ConfigFileName(cmbLoc9.Text))
    End Sub

    Private Function HMB200AlfaAPD(airflow As Double) As Double
        Dim APD As Double

        APD = 0.000000004875 * airflow * airflow + 0.000010425 * airflow - 0.009506249999999

        Return APD
    End Function

    Private Function HMB300AlfaAPD(airflow As Double) As Double
        Dim APD As Double

        APD = 0.000000003525 * airflow * airflow + 0.000001635 * airflow + 0.004916249999994


        Return APD
    End Function

    Private Function HMB400AlfaAPD(airflow As Double) As Double
        Dim APD As Double

        APD = 0.000000002223214 * airflow * airflow + 0.000003091071429 * airflow - 0.001838839285722


        Return APD
    End Function

    Private Function HMB500AlfaAPD(airflow As Double) As Double
        Dim APD As Double

        APD = 0.00000000125 * airflow * airflow + 0.000009178571429 * airflow - 0.029437499999996


        Return APD
    End Function

    Private Function HMB600AlfaAPD(airflow As Double) As Double
        Dim APD As Double

        APD = 0.000000001040179 * airflow * airflow + 0.000004959821429 * airflow - 0.011333705357151


        Return APD
    End Function

    Private Function ModuleAPD(BurnerFlow As Double, BurnerType As String, BurnerConfig As String) As Double
        Dim BrnrAPD As Double

        BrnrAPD = 0.00
        Select Case BurnerType
            Case Is = "HMB300"
                If BurnerAlfa(BurnerConfig) Then BrnrAPD = HMB300AlfaAPD(BurnerFlow)
            Case Is = "HMB400"
                If BurnerAlfa(BurnerConfig) Then BrnrAPD = HMB400AlfaAPD(BurnerFlow)
            Case Is = "HMB500"
                If BurnerAlfa(BurnerConfig) Then BrnrAPD = HMB500AlfaAPD(BurnerFlow)
            Case Is = "HMB600"
                If BurnerAlfa(BurnerConfig) Then BrnrAPD = HMB600AlfaAPD(BurnerFlow)
            Case Is = "Not Used"
                BrnrAPD = 0
            Case Is = "Unselected"
                BrnrAPD = 99.99

        End Select









        Return BrnrAPD
    End Function

    Private Function BurnerAlfa(Config As String) As Boolean
        Dim alfa As Boolean

        alfa = False
        Select Case Config
            Case "A" To "G", "P", "Q"
                alfa = True
            Case Else
                alfa = False
        End Select

        Return alfa
    End Function
    Private Function BurnerBeta(Config As String) As Boolean
        Dim beta As Boolean

        beta = False
        Select Case Config
            Case "H" To "N", "R", "S"
                beta = True
            Case Else
                beta = False
        End Select

        Return beta
    End Function

    Private Function HorizInlet() As Boolean
        Dim temp As Boolean
        temp = False

        If Val(lblAFRow1.Text > 0) Then temp = True
        If Val(lblAFRow2.Text > 0) Then temp = True
        If Val(lblAFRow3.Text > 0) Then temp = True


        Return temp
    End Function

    Private Function TopInlet() As Boolean
        Dim temp As Boolean
        temp = False

        If Val(lblAFCol1.Text > 0) Then temp = True
        If Val(lblAFCol2.Text > 0) Then temp = True
        If Val(lblAFCol3.Text > 0) Then temp = True


        Return temp
    End Function

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click

        txtBurnerAPD.Text = txtAPDCalc.Text

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call WriteDesignNotesReport()
    End Sub

    Private Sub nudHMT1100_ValueChanged(sender As Object, e As EventArgs) Handles nudHMT1100.ValueChanged
        If nudHMT1100.Value = 0 Then chkHMT1100Burner.Checked = False Else chkHMT1100Burner.Checked = True
    End Sub

    Private Sub nudHMT0700_ValueChanged(sender As Object, e As EventArgs) Handles nudHMT0700.ValueChanged
        If nudHMT0700.Value = 0 Then chkHMT0700Burner.Checked = False Else chkHMT0700Burner.Checked = True
    End Sub

    Private Sub nudHMG500_ValueChanged(sender As Object, e As EventArgs) Handles nudHMG500.ValueChanged
        If nudHMG500.Value = 0 Then chkHMG500Burner.Checked = False Else chkHMG500Burner.Checked = True
    End Sub

    Private Sub chkHMT0700Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMT0700Burner.CheckedChanged
        If chkHMT0700Burner.Checked Then nudHMT0700.Value = 1 Else nudHMT0700.Value = 0
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Checked = False
        End If
    End Sub
End Class