Imports System.ComponentModel
Imports System.Reflection
Imports System.Xml
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class frmLowAF
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList
    Private LowerFlow As Double
    Private UpperFlow As Double
    Private LowerTCapVals(4) As Double
    Private UpperTCapVals(4) As Double
    Private LowerPowVals(4) As Double
    Private UpperPowVals(4) As Double

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
        frmMain.ThisUnitMods.Add("LowAF") 'Mod Code goes here!
        Call UpdateCodeList()
        If chkWriteHistory.Checked Then Call WriteHistory()

        Me.Hide()
    End Sub

    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("398800")
        If optExistingSheaves.Checked Then
            ModuleCodeList.Add("398805")
        End If
        If optResheave.Checked Then
            ModuleCodeList.Add("398810")
        End If
        If optFanWallBypassExisting.Checked Then
            ModuleCodeList.Add("398815")
        End If
        If optFanWallBypassNew.Checked Then
            ModuleCodeList.Add("398820")
        End If
        If optReplaceFan.Checked Then
            ModuleCodeList.Add("398825")
        End If

        'controls

        ModuleCodeList.Add("398835")
        If optSE.Checked Then
            If chkAntiFrostProtection.Checked Then
                ModuleCodeList.Add("398840")
            End If
            If chkElecHeatProtection.Checked Then
                ModuleCodeList.Add("398850")
            End If
            If chkGasHeatProtection.Checked Then
                ModuleCodeList.Add("398845")
            End If
        Else
            If chkAntiFrostProtection.Checked Then
                ModuleCodeList.Add("398855")
            End If
            If chkElecHeatProtection.Checked Then
                ModuleCodeList.Add("398865")
            End If
            If chkGasHeatProtection.Checked Then
                ModuleCodeList.Add("398860")
            End If
        End If
        If chkSeriesConversion.Checked Then
            ModuleCodeList.Add("398830")
            If optRefDwg1Ckt.Checked = True Then
                frmMain.lstUsingRefer.Items.Add("Series Conversion 1 Circuit ZR")
            End If
            If optRefDwg2Ckt.Checked = True Then
                frmMain.lstUsingRefer.Items.Add("Series Conversion 2 Circuit ZR")
            End If
        End If
        'use logic to step through the controls to determine the codes and use the above format...

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("398F6A")
        End If

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

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
            Case Is = "Choice"
                If optExistingSheaves.Checked Then tempWeight = "10" '10 for the new controls
                If optResheave.Checked Then tempWeight = "8" '10 for the new controls 5 for net new sheaves
                If optFanWallBypassExisting.Checked Then tempWeight = "15" '10+5 for FWBP
                If optFanWallBypassNew.Checked Then tempWeight = "23" '10+5+8
                If optReplaceFan.Checked Then tempWeight = "10" 'just the controls - fan is a different line item
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim i As Integer
        Dim tsp As Double

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

        If frmMain.ThisUnit.Family = "Series100" Then
            tsp = 0
            For i = 0 To dgvStaticSummary.RowCount - 1
                frmMain.ThisUnitSFanPerf.StaticDataYpal.Item(i) = dgvStaticSummary.Rows(i).Cells.Item(2).Value
                tsp = tsp + Val(dgvStaticSummary.Rows(i).Cells.Item(2).Value)
            Next
            frmMain.ThisUnitSFanPerf.TSP = tsp
        End If
    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer
        Dim sqft As Double
        Dim NewRow As String()

        pCancelled = False

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

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

            For i = 0 To frmMain.ThisUnitSFanPerf.StaticNameYpal.Count - 1
                NewRow = {frmMain.ThisUnitSFanPerf.StaticNameYpal(i), frmMain.ThisUnitSFanPerf.StaticDataYpal(i), "x.x"}
                dgvStaticSummary.Rows.Add(NewRow)

            Next
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

        ModuleCodeList.Add("398000")

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/LowAF")

        TempVal = xNodeRoot.SelectSingleNode("OA100Unit").InnerText
        If TempVal = "Yes" Then chk100OA.Checked = True Else chk100OA.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("Airflow").InnerText
        txtAirflow.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("ESP").InnerText
        txtESP.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("HeatingAF").InnerText
        txtHeatingAF.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("Ambient").InnerText
        txtAmbient.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EDBCooling").InnerText
        txtEDB.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EWBCooling").InnerText
        txtEWB.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EDBHeating").InnerText
        txtHeatEAT.Text = TempVal

    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult
        Dim tempaf As String
        Dim delta_h As Double

        If ((txtAmbient.Text) <> (txtEDB.Text) And (chk100OA.Checked = True)) Then
            dummy = MsgBox("Entering Air DB should equal Ambient DB.  Proceed Anyway?", vbYesNo)
            If dummy = vbNo Then Exit Sub
        End If


        If frmMain.ThisUnit.Family = "Series100" Then
            Call UpdateStaticSummaryValues()
        End If

        Call CalculateCoolingPerf()

        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub CalculateCoolingPerf()
        Dim appXL As Excel.Application
        Dim wbXL As Excel.Workbook
        Dim wbsXL As Excel.Workbooks
        Dim wsXL As Excel.Worksheet
        Dim Dummy As MsgBoxResult

        Dim FileName As String

        Dim LRBaseAtLowAmb, LRBaseAtHighAmb As Integer
        Dim HRBaseAtLowAmb, HRBaseAtHighAmb As Integer
        Dim i As Integer

        Dim amb, lowamb, highamb As Double
        Dim LowTCap, HighTCap As Double
        Dim LowPow, HighPow As Double
        Dim LowAF, HighAF As Double
        Dim airflow As Double
        Dim LowWB, HighWB As Double
        Dim WB As Double
        Dim LowWBBase, HighWBBase As Integer

        TabControl1.SelectTab("tpgCoolCalc")

        FileName = UnitDataFile(frmMain.ThisUnit.Family)

        Me.Cursor = Cursors.WaitCursor
        If frmMain.chkDebug.Checked Then Dummy = MsgBox("About to run excel.application") 'RemoveMe
        appXL = CreateObject("excel.application")
        If frmMain.chkDebug.Checked Then Dummy = MsgBox("just ran excel.application") 'RemoveMe
        appXL.Visible = True
        wbsXL = appXL.Workbooks
        wbXL = wbsXL.Open(FileName)
        wsXL = CType(wbXL.Sheets(UnitDataPage()), Excel.Worksheet)
        'wsXL = wbXL.ActiveSheet
        txtMinCatAirflow.Text = wsXL.Cells(58, 1).value
        txtNominalAirflow.Text = Trim(Str(400 * Val(frmMain.ThisUnit.NominalTons)))
        txtMinCatHeatAF.Text = MinCatalogedHeatAF()

        'set up the cool perf pages
        lblLowAmbient.Text = SetLowAmbient(txtAmbient.Text)
        lblHighAmbient.Text = SetHighAmbient(txtAmbient.Text)

        LRBaseAtLowAmb = SetLowRowBase(lblLowAmbient.Text)
        LRBaseAtHighAmb = SetLowRowBase(lblHighAmbient.Text)
        HRBaseAtLowAmb = SetHighRowBase(lblLowAmbient.Text)
        HRBaseAtHighAmb = SetHighRowBase(lblHighAmbient.Text)

        'setup the airflows
        lblLAFatLowAmb.Text = wsXL.Cells(LRBaseAtLowAmb, 1).value
        lblLAFatHighAmb.Text = wsXL.Cells(LRBaseAtHighAmb, 1).value
        lblHAFatLowAmb.Text = wsXL.Cells(HRBaseAtLowAmb, 1).value
        lblHAFatHighAmb.Text = wsXL.Cells(HRBaseAtHighAmb, 1).value

        'Setup the wetbulb values
        lstWBTempsLowAmbLowFlow.Items.Clear()
        lstWBTempsLowAmbHighFlow.Items.Clear()
        lstWBTempsHighAmbLowFlow.Items.Clear()
        lstWBTempsHighAmbHighFlow.Items.Clear()
        lstTCapLowAmbLowFlow.Items.Clear()
        lstTCapLowAmbHighFlow.Items.Clear()
        lstTCapHighAmbLowFlow.Items.Clear()
        lstTCapHighAmbHighFlow.Items.Clear()
        lstPowerLowAmbLowFlow.Items.Clear()
        lstPowerLowAmbHighFlow.Items.Clear()
        lstPowerHighAmbLowFlow.Items.Clear()
        lstPowerHighAmbHighFlow.Items.Clear()
        lstWBLowAF.Items.Clear()
        lstWBHighAF.Items.Clear()
        lstTCapLowAF.Items.Clear()
        lstTCapHighAF.Items.Clear()
        lstPowerLowAF.Items.Clear()
        lstPowerHighAF.Items.Clear()
        lstWBAct.Items.Clear()
        lstTCapAct.Items.Clear()
        lstPowAct.Items.Clear()

        For i = 0 To 3
            lstWBTempsLowAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtLowAmb + i, 2).value)
            lstWBTempsLowAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtLowAmb + i, 2).value)
            lstWBTempsHighAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtHighAmb + i, 2).value)
            lstWBTempsHighAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtHighAmb + i, 2).value)

            lstTCapLowAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtLowAmb + i, 3).value)
            lstTCapLowAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtLowAmb + i, 3).value)
            lstTCapHighAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtHighAmb + i, 3).value)
            lstTCapHighAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtHighAmb + i, 3).value)

            lstPowerLowAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtLowAmb + i, 4).value)
            lstPowerLowAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtLowAmb + i, 4).value)
            lstPowerHighAmbLowFlow.Items.Add(wsXL.Cells(LRBaseAtHighAmb + i, 4).value)
            lstPowerHighAmbHighFlow.Items.Add(wsXL.Cells(HRBaseAtHighAmb + i, 4).value)
        Next


        wbsXL.Close()
        appXL.Quit()
        Me.Cursor = Cursors.Default

        lblAmbient.Text = txtAmbient.Text
        lblLowAF.Text = lblLAFatLowAmb.Text
        lblHighAF.Text = lblHAFatLowAmb.Text
        lowamb = Val(lblLowAmbient.Text)
        highamb = Val(lblHighAmbient.Text)
        amb = Val(txtAmbient.Text)
        LowAF = Val(lblLowAF.Text)
        HighAF = Val(lblHighAF.Text)
        airflow = Val(txtAirflow.Text)


        For i = 0 To 3
            lstWBLowAF.Items.Add(lstWBTempsLowAmbLowFlow.Items(i))
            lstWBHighAF.Items.Add(lstWBTempsLowAmbHighFlow.Items(i))
            LowTCap = Val(lstTCapLowAmbLowFlow.Items(i))
            HighTCap = Val(lstTCapHighAmbLowFlow.Items(i))
            lstTCapLowAF.Items.Add(Format(LinearInterp(lowamb, LowTCap, highamb, HighTCap, amb), "0.0"))
            LowTCap = Val(lstTCapLowAmbHighFlow.Items(i))
            HighTCap = Val(lstTCapHighAmbHighFlow.Items(i))
            lstTCapHighAF.Items.Add(Format(LinearInterp(lowamb, LowTCap, highamb, HighTCap, amb), "0.0"))
            LowPow = Val(lstPowerLowAmbLowFlow.Items(i))
            HighPow = Val(lstPowerHighAmbLowFlow.Items(i))
            lstPowerLowAF.Items.Add(Format(LinearInterp(lowamb, LowPow, highamb, HighPow, amb), "0.0"))
            LowPow = Val(lstPowerLowAmbHighFlow.Items(i))
            HighPow = Val(lstPowerHighAmbHighFlow.Items(i))
            lstPowerHighAF.Items.Add(Format(LinearInterp(lowamb, LowPow, highamb, HighPow, amb), "0.0"))
        Next

        lblAFact.Text = txtAirflow.Text
        For i = 0 To 3
            lstWBAct.Items.Add(lstWBLowAF.Items(i))
            LowTCap = Val(lstTCapLowAF.Items(i))
            HighTCap = Val(lstTCapHighAF.Items(i))
            lstTCapAct.Items.Add(Format(LinearInterp(LowAF, LowTCap, HighAF, HighTCap, airflow), "0.0"))
            LowPow = Val(lstPowerLowAF.Items(i))
            HighPow = Val(lstPowerHighAF.Items(i))
            lstPowAct.Items.Add(Format(LinearInterp(LowAF, LowPow, HighAF, HighPow, airflow), "0.0"))
        Next

        'Final Evolution
        lblAmbFinal.Text = txtAmbient.Text
        lblWBFinal.Text = txtEWB.Text
        WB = Val(txtEWB.Text)
        LowWBBase = SetLowWBBase(WB)
        LowWB = Val(lstWBAct.Items(LowWBBase))
        HighWBBase = SetHighWBBase(WB)
        HighWB = Val(lstWBAct.Items(HighWBBase))
        lblTCapFinal.Text = Format(LinearInterp(LowWB, lstTCapAct.Items(LowWBBase), HighWB, lstTCapAct.Items(HighWBBase), WB), "0.0")
        lblPowerFinal.Text = Format(LinearInterp(LowWB, lstPowAct.Items(LowWBBase), HighWB, lstPowAct.Items(HighWBBase), WB), "0.0")

        txtTCap.Text = lblTCapFinal.Text
        txtPower.Text = lblPowerFinal.Text

    End Sub

    Private Sub UpdateStaticSummaryValues()
        Dim ItemCount As Integer
        Dim i As Integer
        Dim oldValue As Double
        Dim newvalue As Double
        Dim airflow As Double


        ItemCount = dgvStaticSummary.RowCount
        airflow = Val(txtAirflow.Text)
        For i = 0 To ItemCount - 1
            oldValue = Val(dgvStaticSummary.Rows(i).Cells.Item(1).Value)
            Select Case dgvStaticSummary.Rows(i).Cells.Item(0).Value
                Case Is = "External Static Pressure"
                    newvalue = oldValue
                Case Is = "Evaporator Coil (Wet)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 55
                            newvalue = 0.000000000081589 * airflow * airflow + 0.000021037964258 * airflow + 0
                        Case 60 To 65
                            newvalue = 0.00000000012907 * airflow * airflow + 0.000027653702656 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000456962 * airflow * airflow + 0.000008227113347 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000444713 * airflow * airflow + 0.000008505720156 * airflow + 0
                        Case 120
                            newvalue = 0.000000000016934 * airflow * airflow + 0.000019129051071 * airflow + 0
                        Case 130 To 150
                            newvalue = 0.000000000026434 * airflow * airflow + 0.000022679880017 * airflow + 0
                    End Select
                Case Is = "HGRH Coil"
                    newvalue = 0.000000000538114 * airflow * airflow + 0.000002362657399 * airflow + 0
                Case Is = "Return Air Opening (Bottom)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000448587 * airflow * airflow + 0.000000268247849 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000252543 * airflow * airflow + 0.000000637498659 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.00000000022138 * airflow * airflow + 0.000000854062796 * airflow + 0
                        Case 120 To 150
                            newvalue = -0.000000000004672 * airflow * airflow + 0.000000853469563 * airflow + 0
                    End Select
                Case Is = "Return Air Opening (Side)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.00000000092955253575 * airflow * airflow - 0.0000002578786255074 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000302842 * airflow * airflow + 0.000000494210936 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000213492 * airflow * airflow + 0.000001235321111 * airflow + 0
                    End Select
                Case Is = "Return Air Opening (Rear)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000363896 * airflow * airflow + 0.000000419172149 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000010570088419 * airflow * airflow + 0.0000002371110833065 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000110219 * airflow * airflow + 0.000000724188021 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000061358 * airflow * airflow - 0.000001811095697 * airflow + 0
                    End Select
                Case Is = "Filter(2"" Throwaway)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000208048 * airflow * airflow + 0.000004072711081 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000114221 * airflow * airflow + 0.000002555501436 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000089367 * airflow * airflow + 0.000001765334955 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000047338 * airflow * airflow + 0.000002041842647 * airflow + 0
                    End Select
                Case Is = "Filter(2"" Cleanable)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000166701396124193 * airflow * airflow - 0.000000314648885184433 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000094127 * airflow * airflow - 0.000000518814273 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000062676 * airflow * airflow - 0.000000389067632 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000039728 * airflow * airflow - 0.000000131354035 * airflow + 0
                    End Select
                Case Is = "Filter(2"" Pleated, MERV 8)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000180959 * airflow * airflow + 0.000004498841525 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000083539 * airflow * airflow + 0.000003265782332 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000052173 * airflow * airflow + 0.000002931027755 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000036491 * airflow * airflow + 0.000002541965238 * airflow + 0
                    End Select
                Case Is = "Filter(2"" Carbon, MERV 8)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000149405 * airflow * airflow + 0.000010736971492 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000074942 * airflow * airflow + 0.000007561453604 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000045249 * airflow * airflow + 0.000006520638241 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000025472 * airflow * airflow + 0.000005807810438 * airflow + 0
                    End Select
                Case Is = "Filter(Rigid Filter Track Throwaway (only))"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.00000000031275737009 * airflow * airflow + 0.00000540632224967498 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000190411 * airflow * airflow + 0.000003960338243 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000152138 * airflow * airflow + 0.000003675337385 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000076922 * airflow * airflow + 0.000002750916113 * airflow + 0
                    End Select
                Case Is = "Filter(12"" MERV11 Prefilter MERV8)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000516055 * airflow * airflow + 0.000014780410601 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.000000000314759 * airflow * airflow + 0.000011177274366 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.00000000024603 * airflow * airflow + 0.00001054443845 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000134952 * airflow * airflow + 0.000007288530648 * airflow + 0
                    End Select
                Case Is = "Filter(12"" MERV14 Prefilter MERV8)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000618352 * airflow * airflow + 0.000024458977069 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000036409551174 * airflow * airflow + 0.000018923495424159 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000302511 * airflow * airflow + 0.000017021977167 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000157892 * airflow * airflow + 0.000012283714967 * airflow + 0
                    End Select
                Case Is = "Filter(Final Filter 12"" MERV14)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000404933 * airflow * airflow + 0.000021425420971 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.0000000002207374075 * airflow * airflow + 0.0000149887346727201 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000165831 * airflow * airflow + 0.000013993123534 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.00000000008607 * airflow * airflow + 0.000010791418312 * airflow + 0
                    End Select
                Case Is = "Damper(Standard OAD & Hoods Cleanable Filter)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.00000000138579838062 * airflow * airflow - 0.0000012261855148395 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000079680517821 * airflow * airflow - 0.0000010000960747865 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000608385 * airflow * airflow - 0.000000896166905 * airflow + 0
                        Case 120 To 130
                            newvalue = 0.00000000031866 * airflow * airflow - 0.000000298017102 * airflow + 0
                        Case 150
                            newvalue = 0.000000000249967 * airflow * airflow - 0.000000498617279 * airflow + 0
                    End Select
                Case Is = "Damper(Low Leak OAD & Hoods Cleanable Filter)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.00000000136034664959962 * airflow * airflow - 0.00000134778822969089 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000081383145503 * airflow * airflow - 0.00000100708458454003 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000620525 * airflow * airflow - 0.000000909677388 * airflow + 0
                        Case 120 To 130
                            newvalue = 0.000000000308788 * airflow * airflow - 0.000000483036263 * airflow + 0
                        Case 150
                            newvalue = 0.000000000242061 * airflow * airflow - 0.000000410986033 * airflow + 0
                    End Select
                Case Is = "Return Air Damper (Bottom/Rear Return)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000484060419333394 * airflow * airflow + 0.0000000673627442224342 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.0000000003952092196 * airflow * airflow + 0.00000001280788617595 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000290247 * airflow * airflow - 0.000000009763077 * airflow + 0
                        Case 120 To 130
                            newvalue = 0.000000000215053 * airflow * airflow + 0.00000008764771 * airflow + 0
                        Case 150
                            newvalue = 0.000000000149117 * airflow * airflow - 0.000000082277482 * airflow + 0
                    End Select
                Case Is = "Damper(Powered Exhaust)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000212203187171931 * airflow * airflow - 0.000000120399587215617 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000009166707629 * airflow * airflow - 0.00000002711610302793 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000058029 * airflow * airflow - 0.000000008157381 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000031745 * airflow * airflow - 0.000000001932412 * airflow + 0
                    End Select
                Case Is = "Discharge Air Opening (Side)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000438558628285654 * airflow * airflow - 0.000000126886553746382 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000036158751296 * airflow * airflow - 0.00000009745558216857 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000302967 * airflow * airflow + 0.00000011601987 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000187847 * airflow * airflow + 0.00000005366468 * airflow + 0
                    End Select
                Case Is = "Discharge Air Opening (Bottom)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000448586759146251 * airflow * airflow + 0.000000268247849254268 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000038865416354 * airflow * airflow - 0.00000023437853763754 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000296302 * airflow * airflow + 0.000000194743877 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.00000000013429 * airflow * airflow + 0.000000089644275 * airflow + 0
                    End Select
                Case Is = "Gas Heat(375MBH)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000343300687643258 * airflow * airflow - 0.000000304230047926688 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000028990939179 * airflow * airflow - 0.00000025525134355752 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000226384 * airflow * airflow - 0.000000093220554 * airflow + 0
                    End Select
                Case Is = "Gas Heat(750MBH)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000501797249426965 * airflow * airflow - 0.000000033079808293442 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000041886744956 * airflow * airflow + 0.00000002469494393399 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000332235 * airflow * airflow - 0.000000043901639 * airflow + 0
                    End Select
                Case Is = "Gas Heat(1125MBH)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000540855485765884 * airflow * airflow - 0.00000044832008652603 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000043967620563 * airflow * airflow - 0.0000001400055410575 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000346027 * airflow * airflow - 0.000000025950275 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000351755 * airflow * airflow - 0.000000234192263 * airflow + 0
                    End Select
                Case Is = "Electric Heat(40kW)"
                    newvalue = 0.0000000000596540449895316 * airflow * airflow + 0.000000308161918653681 * airflow + 0
                Case Is = "Electric Heat(80kW)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000139612419254011 * airflow * airflow + 0.000000111481558658048 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000011685375183 * airflow * airflow + 0.00000006079076252098 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000072948 * airflow * airflow + 0.000000103790079 * airflow + 0
                    End Select
                Case Is = "Electric Heat(100kW)"
                    newvalue = 0.000000000129385 * airflow * airflow + 0.000000056461729 * airflow + 0
                Case Is = "Electric Heat(108kW)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000212203187171931 * airflow * airflow - 0.000000120399587215617 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000016280580083 * airflow * airflow + 0.00000015735411527781 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000163006 * airflow * airflow + 0.000000212383301 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000152071 * airflow * airflow - 0.00000002558461 * airflow + 0
                    End Select
                Case Is = "Electric Heat(150kW)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 50 To 65
                            newvalue = 0.000000000248352831443059 * airflow * airflow + 0.000000399537602079763 * airflow + 0
                        Case 70 To 80
                            newvalue = 0.00000000022766559122 * airflow * airflow - 0.00000008256547980793 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000224666 * airflow * airflow - 0.000000006088085 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000185223 * airflow * airflow - 0.000000070372707 * airflow + 0
                    End Select
                Case Is = "Electric Heat(200kW)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 70 To 80
                            newvalue = 0.00000000028205211275 * airflow * airflow - 0.00000014939629285385 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.00000000027821 * airflow * airflow - 0.00000003629644 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000239357 * airflow * airflow + 0.000000102226652 * airflow + 0
                    End Select
                Case Is = "Electric Heat(250kW)"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 90 To 105
                            newvalue = 0.000000000387733 * airflow * airflow - 0.000000126191812 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000307523 * airflow * airflow - 0.000000029015264 * airflow + 0
                    End Select
                Case Is = "Hot Water Heat"
                    newvalue = 0.000000000588199178400262 * airflow * airflow + 0.00000537972940791229 * airflow + 0
                Case Is = "Steam Coil Heat"
                    newvalue = 0.000000000555398446104846 * airflow * airflow + 0.00000487579257583417 * airflow + 0
                Case Is = "Safety Grate"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 70 To 80
                            newvalue = 0.00000000011022105393 * airflow * airflow + 0.00000069424750354507 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000000087647 * airflow * airflow + 0.000000668490705 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000000042433 * airflow * airflow + 0.000000540770487 * airflow + 0
                    End Select
                Case Is = "Inlet Screen"
                    Select Case Val(frmMain.ThisUnit.NominalTons)
                        Case 70 To 80
                            newvalue = 0.00000000266801152748 * airflow * airflow - 0.0000365073994715144 * airflow + 0
                        Case 90 To 105
                            newvalue = 0.000000002253369 * airflow * airflow - 0.000026986397298 * airflow + 0
                        Case 120 To 150
                            newvalue = 0.000000001065055 * airflow * airflow - 0.000013049952678 * airflow + 0
                    End Select
                Case Else
                    newvalue = "-99.9"
            End Select
            dgvStaticSummary.Rows(i).Cells.Item(2).Value = Format(newvalue, "0.00")
        Next

    End Sub


    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim heatlat As Double
        Dim aflow As Double
        Dim btuout As Double
        Dim sqft As Double
        Dim h1, h2, deltah As Double

        btuout = Val(frmMain.ThisUnitHeatPerf.OutputCapacity) * 1000
        aflow = Val(txtAirflow.Text)
        heatlat = btuout / (aflow * 1.085) + Val(txtHeatEAT.Text)
        txtHeatingLAT.Text = Format(heatlat, "0.0")

        If frmMain.ThisUnit.Family = "Series100" Then
            sqft = lblsqftevap.Text
            txtFaceVelocity.Text = Format(Val(txtAirflow.Text) / sqft, "0.0")
        Else
            txtFaceVelocity.Text = "-"
        End If

        h1 = psyEnthalpy_db_wb(Val(txtEDB.Text), Val(txtEWB.Text), psyAtmosphericPressure(Val(frmMain.ThisUnitCoolPerf.Elevation)))
        deltah = (Val(txtTCap.Text) * 1000) / (4.5 * Val(txtAirflow.Text))
        h2 = h1 - deltah
        txtFinalEnth.Text = Format(h2, "0.0")
        txtInitialEnth.Text = Format(h1, "0.0")


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
            Case Is = "Choice"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "15.0"
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "N1"
                                    lowflow = 3600
                                Case Is = "S1"
                                    lowflow = 3600
                                Case Is = "N3"
                                    lowflow = 4620
                                Case Is = "S3"
                                    lowflow = 4620
                                Case Is = "T3"
                                    lowflow = 4620
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "E1"
                                    lowflow = 4500
                                Case Is = "E2"
                                    lowflow = 4500
                                Case Is = "E3"
                                    lowflow = 60000
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If

                    Case Is = "17.5"
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "N1"
                                    lowflow = 3600
                                Case Is = "S1"
                                    lowflow = 3600
                                Case Is = "N3"
                                    lowflow = 4620
                                Case Is = "S3"
                                    lowflow = 4620
                                Case Is = "T3"
                                    lowflow = 4620
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "E1"
                                    lowflow = 5250
                                Case Is = "E2"
                                    lowflow = 5250
                                Case Is = "E3"
                                    lowflow = 60000
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                    Case Is = "20.0"
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "N1"
                                    lowflow = 3660
                                Case Is = "S1"
                                    lowflow = 3660
                                Case Is = "N3"
                                    lowflow = 4620
                                Case Is = "S3"
                                    lowflow = 4620
                                Case Is = "T3"
                                    lowflow = 4620
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "E1"
                                    lowflow = 6000
                                Case Is = "E2"
                                    lowflow = 6000
                                Case Is = "E3"
                                    lowflow = 6000
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                    Case Is = "25.0"
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "N1"
                                    lowflow = 4120
                                Case Is = "S1"
                                    lowflow = 4120
                                Case Is = "N3"
                                    lowflow = 5450
                                Case Is = "S3"
                                    lowflow = 5450
                                Case Is = "T3"
                                    lowflow = 5450
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "E1"
                                    lowflow = 7500
                                Case Is = "E2"
                                    lowflow = 7500
                                Case Is = "E3"
                                    lowflow = 7500
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                    Case Is = "27.5"
                        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "N1"
                                    lowflow = 4120
                                Case Is = "S1"
                                    lowflow = 4120
                                Case Is = "N3"
                                    lowflow = 5450
                                Case Is = "S3"
                                    lowflow = 5450
                                Case Is = "T3"
                                    lowflow = 5450
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                        If frmMain.ThisUnitHeatPerf.HeatType = "Electric Heat" Then
                            Select Case Mid(frmMain.ThisUnit.ModelNumber, 5, 2)
                                Case Is = "E1"
                                    lowflow = 8250
                                Case Is = "E2"
                                    lowflow = 8250
                                Case Is = "E3"
                                    lowflow = 8250
                                Case Else
                                    lowflow = -9999
                            End Select
                        End If
                    Case Else
                        lowflow = 9999
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
        '0.0 is a placeholder
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' AND Ambient=" & Val("0.0") & " ORDER BY CatAirflow"
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
        '0.0 in next line is a placeholder.
        MySQL = "SELECT * FROM tblUPGCoolPerformance WHERE ModelSnip='" & Snip & "' AND Ambient=" & Val("0.0") & " ORDER BY CatAirflow DESC"
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
            grpRefDrawings.Enabled = True
            If frmMain.ThisUnitCoolPerf.NumRefCircuits = "1" Then optRefDwg1Ckt.Checked = True
            If frmMain.ThisUnitCoolPerf.NumRefCircuits = "2" Then optRefDwg2Ckt.Checked = True
            If frmMain.ThisUnitCoolPerf.NumRefCircuits = "3" Then optRefDwg3Ckt.Checked = True
            If frmMain.ThisUnitCoolPerf.NumRefCircuits = "4" Then optRefDwg4Ckt.Checked = True
        End If
        If chkSeriesConversion.Checked = False Then
            grpRefDrawings.Enabled = False
            optRefDwgNone.Checked = True
        End If
    End Sub

    Private Sub cmdFanHeatCalc_Click(sender As Object, e As EventArgs) Handles cmdFanHeatCalc.Click
        Dim temp As Double
        temp = 2545 * Val(txtFanBHP.Text) / 0.92
        lblFanHeat.Text = Format(temp, "0.0")

    End Sub
    Private Sub SuggestLowAFMethod()
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
    Private Sub cmdMethodSuggest_Click(sender As Object, e As EventArgs) Handles cmdMethodSuggest.Click
        Call SuggestLowAFMethod()
    End Sub

    Private Sub cmdCalcDehumCap_Click(sender As Object, e As EventArgs) Handles cmdCalcDehumCap.Click
        txtDehumCap.Text = Format(psyDehumCapacity(txtEDB.Text, txtEWB.Text, txtLADB.Text, txtLAWB.Text, txtAirflow.Text), "0.0")
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer
        Dim TCode As String

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '398%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '315%'"
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

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "LowAF"
        frmHistoryReport.cmbModCode.Text = "LowAF"
        frmHistoryReport.Show()
    End Sub
    Private Sub WriteHistory()
        'updated to version 2.0 1 May 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver As String
        Dim modnum, rqAF, RQStatic, Soln, NomAir, MinCatAir, BypassAir As String

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
        RQStatic = txtESP.Text
        NomAir = txtNominalAirflow.Text
        MinCatAir = txtMinCatAirflow.Text
        BypassAir = txtBypassAF.Text

        If optExistingSheaves.Checked Then Soln = "Adjust Sheaves"
        If optResheave.Checked Then Soln = "Resheave"
        If optFanWallBypassExisting.Checked Then Soln = "FWBypass"
        If optFanWallBypassNew.Checked Then Soln = "FWBypass-Resheave"
        If optReplaceFan.Checked Then Soln = "Replace Fan"

        MySQL = "Select * FROM tblHistoryLowAF WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryLowAF SET RQAirflow='" & rqAF & "', RQStatic='" & RQStatic & "', " & "Solution='" & Soln & "', NominalAir='" & NomAir & "', MinCatAir='" & MinCatAir & "', BypassAir='" & BypassAir & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryLowAF (JobName, UnitID, Version, ModelNumber, RQAirflow, RQStatic, Solution, NominalAir, MinCatAir, BypassAir) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & rqAF & "','" & RQStatic & "','" & Soln & "','" & NomAir & "','" & MinCatAir & "','" & BypassAir & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        Call CalculateCoolingPerf()

    End Sub

    Private Function SetLowWBBase(wb As Double) As Integer
        Dim tempwb As Integer

        tempwb = 1 'typically 72
        If wb <= Val(lstWBAct.Items(1)) Then tempwb = 2 'typically 67
        If wb <= Val(lstWBAct.Items(2)) Then tempwb = 3 'typically 62

        Return tempwb
    End Function

    Private Function SetHighWBBase(wb As Double) As Integer
        Dim tempwb As Double

        tempwb = 2 'typically 67
        If wb >= Val(lstWBAct.Items(2)) Then tempwb = 1 'typically 72
        If wb >= Val(lstWBAct.Items(1)) Then tempwb = 0 'typically 77

        Return tempwb
    End Function

    Private Function LinearInterp(x1 As Double, y1 As Double, x3 As Double, y3 As Double, x2 As Double) As Double
        Dim a, b, c, y2 As Double
        If ((x1 = x3) And (y1 = y3)) Then
            y2 = y1
        Else
            a = x2 - x1
            b = y3 - y1
            c = x3 - x1

            y2 = (a * b / c) + y1
        End If

        Return y2
    End Function

    Private Function SetLowRowBase(ambval As String) As Integer
        Dim lowcell As Integer

        Select Case ambval
            Case Is = "75.0"
                lowcell = 58
            Case Is = "85.0"
                lowcell = 70
            Case Is = "95.0"
                lowcell = 81
            Case Is = "105.0"
                lowcell = 92
            Case Is = "115.0"
                lowcell = 103
            Case Is = "125.0"
                lowcell = 114
        End Select

        Return lowcell
    End Function

    Private Function SetHighRowBase(ambval As String) As Integer
        Dim lowcell As Integer

        Select Case ambval
            Case Is = "75.0"
                lowcell = 63
            Case Is = "85.0"
                lowcell = 74
            Case Is = "95.0"
                lowcell = 85
            Case Is = "105.0"
                lowcell = 96
            Case Is = "115.0"
                lowcell = 107
            Case Is = "125.0"
                lowcell = 118
        End Select

        Return lowcell
    End Function

    Private Function SetLowAmbient(strAmbient As String) As String
        Dim dblAmb As Double
        Dim Temp As String

        dblAmb = Val(strAmbient)

        Temp = "75.0"
        If dblAmb >= 85.0 Then Temp = "85.0"
        If dblAmb >= 95.0 Then Temp = "95.0"
        If dblAmb >= 105.0 Then Temp = "105.0"
        If dblAmb >= 115.0 Then Temp = "115.0"

        Return Temp
    End Function
    Private Function SetHighAmbient(strAmbient As String) As String
        Dim dblAmb As Double
        Dim Temp As String

        dblAmb = Val(strAmbient)

        Temp = "125.0"
        If dblAmb <= 115.0 Then Temp = "115.0"
        If dblAmb <= 105.0 Then Temp = "105.0"
        If dblAmb <= 95.0 Then Temp = "95.0"
        If dblAmb <= 85.0 Then Temp = "85.0"

        Return Temp
    End Function
    Private Function UnitDataPage() As String
        Dim MyFamily, MyModel, MySnip As String

        MyFamily = frmMain.ThisUnit.Family
        MyModel = frmMain.ThisUnit.ModelNumber
        MySnip = "Error"
        Select Case MyFamily
            Case Is = "Series5"
                MySnip = Mid(MyModel, 1, 5)
            Case Is = "Series10"
                MySnip = Mid(MyModel, 1, 5)
            Case Is = "Series20"
                MySnip = Mid(MyModel, 1, 5)
            Case Is = "Series40"
                Stop
            Case Is = "Series100"
                Stop
            Case Is = "Select"
                Stop
            Case Is = "Choice"
                MySnip = Mid(MyModel, 1, 4)
            Case Is = "Premier"
                Stop
        End Select

        Return MySnip

    End Function

    Private Function UnitDataFile(MyFamily As String) As String
        Dim TempFile, ThisFile, ThisPath As String

        ThisPath = My.Settings.ResourceDir
        ThisPath = ThisPath & "Mods\LowAF\Design\"
        ThisPath = ThisPath & frmMain.ThisUnit.Family & "\"

        ThisFile = "_100OACalculator.xlsm"
        If MyFamily = "Series100" Then
            ThisFile = frmMain.ThisUnit.Cabinet & ThisFile
        Else
            ThisFile = MyFamily & ThisFile
        End If

        TempFile = ThisPath & ThisFile

        Return TempFile
    End Function

    Private Sub txtLADB_Leave(sender As Object, e As EventArgs) Handles txtLADB.Leave
        Dim temp As Double
        temp = Format(Val(txtAirflow.Text) * 1.085 * (Val(txtEDB.Text) - Val(txtLADB.Text)), "0.0")
        txtSCap.Text = temp

    End Sub
End Class