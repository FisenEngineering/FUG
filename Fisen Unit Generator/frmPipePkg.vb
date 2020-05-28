Imports System.Reflection
Imports Microsoft.Office.Interop.Excel

Public Class frmPipePkg
    Private pCancelled As Boolean
    Private HydroDesc(25) As String
    Private HydroWMF(25) As String
    Private PumpsDone As Integer
    Private TDVDone As Boolean
    Private SucDiffDone As Boolean
    Private BTankDone As Boolean
    Private XTankDone As Boolean
    Private ASepDone As Boolean
    Private StrainDone As Boolean
    Private GMUDone As Boolean
    Private InsDone As Boolean
    Private PotFeedDone As Boolean
    Private ModuleCodeList As New ArrayList

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private pAutoValveDesc As String
    Public Property AutoValveDesc As String
        Get
            Return pAutoValveDesc
        End Get
        Set(value As String)
            pAutoValveDesc = value
        End Set
    End Property
    Private pAutoValveSize As String
    Public Property AutoValveSize As String
        Get
            AutoValveSize = pAutoValveSize
        End Get
        Set(value As String)
            pAutoValveSize = value
        End Set
    End Property
    Private Sub frmPipePkg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize the proposal choices
        Call InitializeProposalDropdowns()

        'Handle SCCR requirements of base unit
        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        'Prime the pump for Design Cautions
        ModuleCodeList.Add("800000")

        'Old stuff follows - Should eventually be deleted or migrated out of here.
        txtFlow.Text = frmMain.ThisChillerMainPerf.Flow
        cmbFluid.Text = frmMain.ThisChillerMainPerf.Fluid
        cmbFluidPercent.Text = frmMain.ThisChillerMainPerf.FluidPercent
        txtChillerHead.Text = frmMain.ThisChillerMainPerf.FPD
        lstPkgStructure.SetSelected(1, True)
        cmbHeight.Enabled = False
        cmbHeight.Text = "n/a"
        cmbSkidLength.Text = "64"""
        cmbWidth.Text = ChillerWidth(frmMain.ThisUnit.Family, frmMain.ThisChillerMainPerf.FanCount)
        cmbWidth.Enabled = False
        cmbBaseRail.Text = "6"""
        cmbDecking.Text = "Open Grid"
        chkAluminumTread.Enabled = False
        chkAluminumTread.Checked = False
        cmbPipeSize.SelectedIndex = 0
        cmbPipeSchedule.Text = "Schedule 40"
        cmbFittingStyle.Text = "Victaulic"
        cmbPipeSize.Text = "3"




    End Sub
    Private Sub InitializeProposalDropdowns()
        cmbPumpSpec.Text = "Not Required"
        cmbTDVSpec.Text = "Not Required"
        cmbSucDiffSpec.Text = "Not Required"
        cmbBuffTankSpec.Text = "Not Required"
        cmbExpTankSpec.Text = "Not Required"
        cmbAirSepSpec.Text = "Not Required"
        cmbStrainSpec.Text = "Not Required"
        cmbGMUSpec.Text = "Not Required"
        cmbInsSpec.Text = "Not Required"
        cmbPotFeedSpec.Text = "Not Required"

    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("PipePkg") 'Mod Code goes here!
        Call UpdateCodeList(False)

        Call PerformDesignCautionScan(False)
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '800'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '800'"
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

    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.HydroPress = True
        frmMain.ThisUnitWarrTest.MotorTest = True
        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("PipePkg")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Piping Package")
        tempWeight = "9999"
        'Now it's logic to assign the values.

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(txtDryWeight.Text)
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        'This needs to be done obviously
    End Sub
    Private Sub UpdateCodeList(Preview As Boolean)
        Dim i As Integer
        Dim dummy As MsgBoxResult

        'Add the level 0 code
        ModuleCodeList.Clear()
        ModuleCodeList.Add("800000") 'Hydronic Piping Package

        'Handle type of piping package
        If optPkgSkid.Checked Then
            ModuleCodeList.Add("800001")
        Else
            If optExtDeetBaseRail.Checked Then ModuleCodeList.Add("800002")
            If optExtDeetFootprint.Checked Then ModuleCodeList.Add("800003")
            If optExtDeetCommonBR.Checked Then ModuleCodeList.Add("800004")
        End If

            Call HandlePipingCodes()
        'Handle the codes for each of the installed specialties
        If chkScopePumps.Checked Then Call HandleCodesPumps()
        If chkScopeTDV.Checked Then Call HandleCodesTDV()
        If chkScopeSuctionDiff.Checked Then Call HandleCodesSucDiff()
        If chkScopeBufferTank.Checked Then Call HandleCodesBuffTank()
        If chkScopeExpansionTank.Checked Then Call HandleCodesExpansionTank()
        If chkScopeAirSeparator.Checked Then Call HandleCodesAirSeparator()
        If chkScopeStrainer.Checked Then Call HandleCodesStrainer()
        If chkScopeGMU.Checked Then Call HandleCodesGMU()
        If chkScopePotFeed.Checked Then HandleCodesPotFeed()
        If chkScopeInsulation.Checked Or Not (chkScopeInsulation.Checked) Then HandleCodesInsulation()

        Call PerformDesignCautionScan(False)

        If Not (Preview) Then
            For i = 0 To ModuleCodeList.Count - 1
                frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            Next i
        End If

    End Sub
    Private Sub HandlePipingCodes()
        ModuleCodeList.Add("800K00")
        If optPipeConsSingle.Checked Then ModuleCodeList.Add("800K01") Else ModuleCodeList.Add("800K02")
        If optPipeBaseVic.Checked Then
            ModuleCodeList.Add("800K03")
            ModuleCodeList.Add("800K06")
        End If
        If optPipeBaseWeld.Checked Then
            ModuleCodeList.Add("800K04")
            ModuleCodeList.Add("800K06")
        End If
        If optPipeBaseNPT.Checked Then
            ModuleCodeList.Add("800K05")
        End If
    End Sub
    Private Sub HandleCodesInsulation()
        ModuleCodeList.Add("800J00")
        Select Case cmbInsSpec.Text
            Case Is = "Use Standard"
                ModuleCodeList.Add("800J01")
            Case Is = "Elastomeric 3/4 inch"
                ModuleCodeList.Add("800J01")
            Case Is = "Elastomeric 1-1/2 inch"
                ModuleCodeList.Add("800J02")
            Case Is = "Fiberglass 2 inch"
                ModuleCodeList.Add("800J03")
            Case Is = "Mineral Wool 2 inch"
                ModuleCodeList.Add("800J04")
            Case Is = "Not Required"
                ModuleCodeList.Add("800J05")
        End Select
    End Sub
    Private Sub HandleCodesPotFeed()
        ModuleCodeList.Add("800I00")
        Select Case cmbPotFeedStyle.Text
            Case Is = "Use Standard", Is = "2 Gallon Capacity"
                ModuleCodeList.Add("800I01")
            Case Is = "5 Gallon Capacity"
                ModuleCodeList.Add("800I02")
        End Select

    End Sub
    Private Sub HandleCodesGMU()
        ModuleCodeList.Add("800H00")
        Select Case cmbGMUStyle.Text
            Case Is = "15 Gal. Internal"
                ModuleCodeList.Add("800H01")
            Case Is = "30 Gal. Internal"
                ModuleCodeList.Add("800H02")
            Case Is = "55 Gal. Internal"
                ModuleCodeList.Add("800H03")
            Case Is = "100 Gal. Internal"
                ModuleCodeList.Add("800H04")
            Case Is = "30 Gal. External"
                ModuleCodeList.Add("800H05")
            Case Is = "55 Gal. External"
                ModuleCodeList.Add("800H06")
            Case Is = "100 Gal. External"
                ModuleCodeList.Add("800H07")
        End Select
    End Sub
    Private Sub HandleCodesStrainer()
        ModuleCodeList.Add("800G00")
        Select Case cmbAirSepSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                ModuleCodeList.Add("800G01")
            Case Is = "Taco"
                ModuleCodeList.Add("800G02")
            Case Is = "Bell and Gossett"
                ModuleCodeList.Add("800G03")
            Case Is = "Watts"
                ModuleCodeList.Add("800G04")
        End Select
    End Sub
    Private Sub HandleCodesAirSeparator()
        ModuleCodeList.Add("800F00")
        Select Case cmbAirSepSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                ModuleCodeList.Add("800F01")
            Case Is = "Taco"
                ModuleCodeList.Add("800F03")
            Case Is = "Bell and Gossett"
                ModuleCodeList.Add("800F02")
            Case Is = "Honeywell"
                ModuleCodeList.Add("800F04")
        End Select
    End Sub

    Private Sub HandleCodesExpansionTank()
        ModuleCodeList.Add("800E00")
        Select Case cmbExpTankSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                ModuleCodeList.Add("800E01")
            Case Is = "Taco"
                ModuleCodeList.Add("800E02")
            Case Is = "Bell and Gossett"
                ModuleCodeList.Add("800E03")
        End Select

        Select Case cmbExpTankStyle.Text
            Case Is = "Use Standard", Is = "Diaphram Tank"
                ModuleCodeList.Add("800E04")
            Case Is = "Bladder Tank"
                ModuleCodeList.Add("800E05")
        End Select
    End Sub

    Private Sub HandleCodesBuffTank()
        ModuleCodeList.Add("800D00") 'Main code for Buffer Tanks are included
        'First branchout is by manufacturer
        Select Case cmbBuffTankSpec.Text
            Case Is = "Use Standard", Is = "Niles Steel Tank"
                ModuleCodeList.Add("800D01")
                Select Case cmbBuffTankStyle.Text
                    Case Is = "130 gal. CBT-24-072"
                        ModuleCodeList.Add("800DZ1")
                    Case Is = "210 gal. CBT-30-075"
                        ModuleCodeList.Add("800DZ2")
                    Case Is = "300 gal. CBT-36-072"
                        ModuleCodeList.Add("800DZ3")
                    Case Is = "400 gal. CBT-36-094"
                        ModuleCodeList.Add("800DZ4")
                    Case Is = "460 gal. CBT-42-084"
                        ModuleCodeList.Add("800DZ5")
                    Case Is = "528 gal. CBT-48-077"
                        ModuleCodeList.Add("800DZ6")
                    Case Is = "1000 gal. CBT-48-141"
                        ModuleCodeList.Add("800DZ7")
                    Case Is = "Custom Capacity Tank"
                        ModuleCodeList.Add("800DZ0")
                End Select
            Case Is = "Elbi"
                ModuleCodeList.Add("800D02")
                Select Case cmbBuffTankStyle.Text
                    Case Is = "Custom Capacity Tank"
                        ModuleCodeList.Add("800DZR")
                End Select
            Case Is = "Buckeye Fabrication"
                ModuleCodeList.Add("800D03")
                Select Case cmbBuffTankStyle.Text
                    Case Is = "Custom Capacity Tank"
                        ModuleCodeList.Add("800DZH")
                End Select
        End Select
        'Now handle the options for the specialty
        If chkBuffTankOptionsCstmNozzles.Checked Then ModuleCodeList.Add("800DA1")

        'Insulation Codes
        If optBTUninsulated.Checked Then ModuleCodeList.Add("800DB1")
        If optBTArmaflex.Checked Then ModuleCodeList.Add("800DB2")
        If optBTSprayFoam.Checked Then ModuleCodeList.Add("800DB3")

        'Aux Heat Codes
        If optBTHTNone.Checked Then
            ModuleCodeList.Add("800DC1")
        End If

        If optBTHTHeatTrace.Checked Then
            ModuleCodeList.Add("800DC2")
            If chkBTHTUnitPowered.Checked Then ModuleCodeList.Add("800DC5") Else ModuleCodeList.Add("800DC4")
        End If

        If optBTHTImmersion.Checked Then
            ModuleCodeList.Add("800DC3")
            If chkBTHTUnitPowered.Checked Then ModuleCodeList.Add("800DC5") Else ModuleCodeList.Add("800DC4")
        End If

        'VentingCodes
        If optBTVentNone.Checked Then ModuleCodeList.Add("800DD1")
        If optBTVentManual.Checked Then ModuleCodeList.Add("800DD2")
        If optBTVentAuto.Checked Then ModuleCodeList.Add("800DD3")

        'DrainCodes
        If optBTDrainNone.Checked Then ModuleCodeList.Add("800DE1")
        If optBTDrainValve.Checked Then ModuleCodeList.Add("800DE2")
        If optBTDrainChainCap.Checked Then ModuleCodeList.Add("800DE3")

    End Sub
    Private Sub HandleCodesSucDiff()

        ModuleCodeList.Add("800C00") 'Main Code for Suction Diffuser are included
        'First branchout by manufacturer...
        Select Case cmbSucDiffSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                ModuleCodeList.Add("800C01")
                ModuleCodeList.Add("800CZ1")
            Case Is = "Bell and Gossett"
                ModuleCodeList.Add("800C02")
            Case Is = "Taco"
                ModuleCodeList.Add("800C03")
        End Select
        If chkSucDiffOptionsBlowDownValve.Checked Then ModuleCodeList.Add("800CA1")

    End Sub
    Private Sub HandleCodesTDV()

        ModuleCodeList.Add("800B00") 'Main Code for TDV are included
        'First branchout by manufacturer...
        Select Case cmbTDVSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                ModuleCodeList.Add("800B01")
                ModuleCodeList.Add("800BZ1")
            Case Is = "Bell and Gossett"
                ModuleCodeList.Add("800B02")
            Case Is = "Taco"
                ModuleCodeList.Add("800B03")
        End Select

        'Handle the options page choices
        If optTDVOptionsStraight.Checked Then ModuleCodeList.Add("800B91")
        If optTDVOptionsAngle.Checked Then ModuleCodeList.Add("800B92")

    End Sub

    Private Sub HandleCodesPumps()
        Dim dummy As MsgBoxResult

        ModuleCodeList.Add("800A00") 'Main Code for Pumps are included

        'First branchout by manufacturer...
        Select Case cmbPumpSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                Select Case cmbPumpStyle.Text
                    Case Is = "Close Coupled Dual Arm"
                        ModuleCodeList.Add("800A10")
                        ModuleCodeList.Add("800AZ1") 'Series 4382
                    Case Is = "Close Coupled Twin Pump"
                        ModuleCodeList.Add("800A11")
                        ModuleCodeList.Add("800AZ2") 'Series 4372
                    Case Is = "Close Coupled Vertical Inline"
                        ModuleCodeList.Add("800A12")
                        ModuleCodeList.Add("800AZ3") 'Series 4380
                    Case Is = "Split Coupled Twin Pump"
                        ModuleCodeList.Add("800A14")
                        ModuleCodeList.Add("800AZ5") 'Series 4322
                    Case Is = "Split Coupled Dual Arm"
                        ModuleCodeList.Add("800A13")
                        ModuleCodeList.Add("800AZ4") 'Series 4302
                    Case Is = "Split Coupled Vertical Inline"
                        ModuleCodeList.Add("800A15")
                        ModuleCodeList.Add("800AZ6") 'Series 4300
                    Case Is = "Split Coupled End Suction"
                        ModuleCodeList.Add("800A16")
                        ModuleCodeList.Add("800AZ7") 'Series 4200h
                    Case Else
                        dummy = MsgBox("Error in Pump Selection Logic.", vbOKOnly, "Piping Package Error")
                        Stop
                End Select

            Case Is = "Bell and Gossett"
                dummy = MsgBox("B&G Pumps logic is incomplete.", vbOKOnly, "Piping Package Error")
                Stop
            Case Is = "Taco"
                dummy = MsgBox("B&G Pumps logic is incomplete.", vbOKOnly, "Piping Package Error")
                Stop
        End Select

        'Type of motors for the pumps
        If optODPPumpMotor.Checked Then
            ModuleCodeList.Add("800A71")
        End If
        If optTEFCPumpMotor.Checked Then
            ModuleCodeList.Add("800A72")
        End If

        'System design for the pumps
        If nudPumpCount.Value = 1 Then
            ModuleCodeList.Add("800AY3")
        Else
            If optPumpSystemPriStby.Checked Then ModuleCodeList.Add("800AY1")
            If optPumpSystemParallel.Checked Then ModuleCodeList.Add("800AY2")
        End If

        'Pump Drives or Contactors
        If optPCtrlIVSonPump.Checked Then ModuleCodeList.Add("800AX1")
        If optPCtrlIVSRemote.Checked Then ModuleCodeList.Add("800AX2")
        If optPCtrlStdRemote.Checked Then
            ModuleCodeList.Add("800AX3")
            ModuleCodeList.Add("800AV1")
        End If
        If optPCtrlSpecificRemote.Checked Then
            ModuleCodeList.Add("800AX4")
            If cmbPCtrlSpecDrive.Text = "Danfoss HVAC" Then ModuleCodeList.Add("800AV2")
            If cmbPCtrlSpecDrive.Text = "ABB ACH550" Then ModuleCodeList.Add("800AV3")
        End If
        If optPCtrlCVPumps.Checked Then ModuleCodeList.Add("800AX5")

    End Sub

    Private Function ChillerWidth(family As String, fans As String) As String
        Dim tempwidth As String
        tempwidth = -99
        Select Case family
            Case Is = "YLAA"
                tempwidth = "88.25"""

            Case Is = "YVAA"
                tempwidth = "88.25"""

            Case Is = "YCAL"
                If fans = 2 Then
                    tempwidth = "44.3125"""
                Else
                    tempwidth = "90.25"""
                End If

        End Select
        ChillerWidth = tempwidth
    End Function
    Private Sub lstPkgStructure_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPkgStructure.SelectedIndexChanged
        Select Case lstPkgStructure.Text
            Case Is = "Skid Only"
                cmbDecking.Items.Clear()
                cmbDecking.Items.Add("Open Grid")
                cmbDecking.Items.Add("3/16 Steel Deck")
                cmbDecking.Items.Add("3/16 Steel Diamond Deck")
                chkEnclosure.Checked = False
                chkEnclosure.Enabled = True
                cmbSkidLength.Enabled = True
                cmbSkidLength.Text = "96"""
                cmbWidth.Text = "88.25"""
                cmbWidth.Enabled = True
                cmbBaseRail.Enabled = True
                cmbBaseRail.Text = "6"""
                cmbDecking.Text = "Open Grid"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkAnchorHoles.Enabled = True
            Case Is = "Attached Skid"
                cmbDecking.Items.Clear()
                cmbDecking.Items.Add("Open Grid")
                cmbDecking.Items.Add("3/16 Steel Deck")
                cmbDecking.Items.Add("3/16 Steel Diamond Deck")
                chkEnclosure.Checked = False
                chkEnclosure.Enabled = True
                cmbWidth.Text = ChillerWidth(frmMain.ThisUnit.Family, frmMain.ThisChillerMainPerf.FanCount)
                cmbWidth.Enabled = False
                cmbSkidLength.Enabled = True
                cmbSkidLength.Text = "64"""
                cmbBaseRail.Enabled = False
                If frmMain.ThisUnit.Family = "YCAL" Then
                    cmbBaseRail.Text = "6"""
                Else
                    cmbBaseRail.Text = "6"" Full"
                End If
                cmbDecking.Text = "Open Grid"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkAnchorHoles.Enabled = True
            Case Is = "Existing Footprint"
                cmbDecking.Items.Clear()
                cmbDecking.Items.Add("n/a")
                chkEnclosure.Checked = False
                chkEnclosure.Enabled = False
                cmbHeight.Text = "n/a"
                cmbHeight.Enabled = False
                cmbWidth.Text = "n/a"
                cmbWidth.Enabled = False
                cmbSkidLength.Enabled = False
                cmbSkidLength.Text = "n/a"
                cmbBaseRail.Text = "n/a"
                cmbBaseRail.Enabled = False
                cmbDecking.Text = "n/a"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkAnchorHoles.Enabled = False
                chkAnchorHoles.Checked = False
        End Select
    End Sub
    Private Sub chkEnclosure_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnclosure.CheckedChanged
        If chkEnclosure.Checked = True Then
            cmbHeight.Enabled = True
            cmbHeight.Text = "96"""
            If cmbDecking.Text = "Open Grid" Then cmbDecking.Text = "3/16 Steel Deck"
            cmbDecking.Items.RemoveAt(0)
        Else
            cmbDecking.Items.Insert(0, "Open Grid")
            cmbHeight.Enabled = False
            cmbHeight.Text = "n/a"
        End If
    End Sub
    Private Sub cmbDecking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDecking.SelectedIndexChanged
        Select Case cmbDecking.Text
            Case Is = "Open Grid"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkFloorDrains.Checked = False
                chkFloorDrains.Enabled = False
            Case Is = "3/16 Steel Deck"
                chkAluminumTread.Enabled = True
                chkAluminumTread.Checked = False
                chkFloorDrains.Enabled = True
            Case Is = "3/16 Steel Diamond Deck"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkFloorDrains.Enabled = True
            Case Is = "n/a"
                chkAluminumTread.Enabled = False
                chkAluminumTread.Checked = False
                chkFloorDrains.Enabled = False
                chkFloorDrains.Checked = False
        End Select
    End Sub
    Private Sub chkFloorDrains_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloorDrains.CheckedChanged
        If chkFloorDrains.Checked = True Then
            nudFloorDrainCount.Enabled = True
            nudFloorDrainCount.Minimum = 1
            nudFloorDrainCount.Value = 1
        Else
            nudFloorDrainCount.Enabled = False
            nudFloorDrainCount.Minimum = 0
            nudFloorDrainCount.Value = 0
        End If
    End Sub
    Private Sub chkAnchorHoles_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnchorHoles.CheckedChanged
        If chkAnchorHoles.Checked = True Then
            nudAnchorHoles.Enabled = True
            nudAnchorHoles.Minimum = 4
            nudAnchorHoles.Value = 6
        Else
            nudAnchorHoles.Enabled = False
            nudAnchorHoles.Minimum = 0
            nudAnchorHoles.Value = 0
        End If
    End Sub

    Private Sub optTotalHeadSpec_CheckedChanged(sender As Object, e As EventArgs) Handles optTotalHeadSpec.CheckedChanged
        If optTotalHeadSpec.Checked Then
            txtExternalHead.Text = ""
            txtExternalHead.Enabled = False
            txtChillerHead.Text = ""
            txtChillerHead.Enabled = False
            txtFisenHead.Text = ""
            txtFisenHead.Enabled = False
            txtTotalHead.Enabled = True
        Else
            txtExternalHead.Enabled = True
            txtChillerHead.Enabled = True
            txtFisenHead.Enabled = True
            txtTotalHead.Text = ""
            txtTotalHead.Enabled = False
        End If
    End Sub

    Private Sub btnDoneProposal_Click(sender As Object, e As EventArgs) Handles btnDoneProposal.Click

        If chkScopePumps.Checked Then PumpsDone = nudPumpCount.Value
        If chkScopeTDV.Checked Then TDVDone = False
        If chkScopeSuctionDiff.Checked Then SucDiffDone = False
        If chkScopeBufferTank.Checked Then BTankDone = False
        If chkScopeExpansionTank.Checked Then XTankDone = False
        If chkScopeAirSeparator.Checked Then ASepDone = False
        If chkScopeStrainer.Checked Then StrainDone = False
        If chkScopeGMU.Checked Then GMUDone = False
        If chkScopePotFeed.Checked Then PotFeedDone = False
        If chkScopeInsulation.Checked Then InsDone = False

        txtPRptCountAndStyle.Text = PumpCountandStyle
        tbcPipePkg.SelectTab("pgPumps")
    End Sub

    Private Function PumpCountandStyle() As String
        Dim TempSTR As String
        Dim TempBrand As String
        Dim TempCtrl As String

        TempSTR = Trim(Str(nudPumpCount.Value))
        TempBrand = cmbPumpSpec.Text
        TempCtrl = ""
        If TempBrand = "Standard" Then TempBrand = "Armstrong"
        If optPCtrlIVSonPump.Checked Then TempCtrl = "with IVS Drive(s) on Pumps"
        If optPCtrlIVSRemote.Checked Then TempCtrl = "with IVS Drive(s) Remotely Mounted"
        If optPCtrlStdRemote.Checked Then TempCtrl = "with Standard Drive(s) Remotely Mounted"
        If optPCtrlSpecificRemote.Checked Then
            TempCtrl = "with " & cmbPCtrlSpecDrive.Text & " Remotely Mounted"
        End If
        If optPCtrlIVSonPump.Checked Then TempCtrl = "CV application with Motor Contactors"
        TempSTR = TempSTR & " " & TempBrand & " " & cmbPumpStyle.Text & " " & TempCtrl

        Return TempSTR
    End Function

    Private Sub LoadApplicableHydroDrawings()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailHydroDrawing.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroDrawings WHERE PipePkg=TRUE"
        rs.Open(MySQL, con)

        i = 0
        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstAvailHydroDrawing.Items.Add(rs.Fields("PlainName").Value)
            HydroDesc(i) = rs.Fields("DrawingDescription").Value
            HydroWMF(i) = "\HydroDrawings\" & rs.Fields("DrawingPath").Value & rs.Fields("WMFName").Value
            i = i + 1
            rs.MoveNext()
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnDonePipe_Click(sender As Object, e As EventArgs) Handles btnDonePipe.Click

        tbcPipePkg.SelectTab("pgSpecialties")
    End Sub

    Private Sub btnDoneSpecialties_Click(sender As Object, e As EventArgs) Handles btnDoneSpecialties.Click
        Dim Dummy As MsgBoxResult
        Dim SpecDone As Boolean
        SpecDone = False

        SpecDone = TDVDone And SucDiffDone And BTankDone And XTankDone And ASepDone And StrainDone And GMUDone And PotFeedDone
        If Not SpecDone Then
            Dummy = MsgBox("You have not added all the items in the scope." & "Proceed?", vbYesNo, "Piping Package")
            If Dummy = vbNo Then Exit Sub
        End If
        tbcPipePkg.SelectTab("pgValves")
    End Sub

    Private Sub btnDonePumps_Click(sender As Object, e As EventArgs) Handles btnDonePumps.Click

        tbcPipePkg.SelectTab("pgCouplings")
    End Sub

    Private Sub btnDoneStructure_Click(sender As Object, e As EventArgs) Handles btnDoneStructure.Click
        btnDonePumps.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub btnDoneHydronicDwg_Click(sender As Object, e As EventArgs) Handles btnDoneHydronicDwg.Click
        tbcPipePkg.SelectTab("pgPipeandFittings")
    End Sub

    Private Sub btnAddSpecialtytoGrid_Click(sender As Object, e As EventArgs) Handles btnAddSpecialtytoGrid.Click
        Dim NewRow As String()
        Dim strInletIso As String
        Dim strOutletIso As String


        strInletIso = "-"
        strOutletIso = "-"

        If chkInletIso.Checked Then
            pAutoValveDesc = lstAvailSpecialties.Text & " Inlet Isolation Valve"
            pAutoValveSize = gridAvailItems.SelectedRows.Item(0).Cells.Item(2).Value
            frmAddHydroValve.ShowDialog()
            strInletIso = frmAddHydroValve.NewValveTag
            frmAddHydroValve.Dispose()
        End If

        If chkOutletIso.Checked Then
            pAutoValveDesc = lstAvailSpecialties.Text & " Outlet Isolation Valve"
            pAutoValveSize = gridAvailItems.SelectedRows.Item(0).Cells.Item(3).Value
            frmAddHydroValve.ShowDialog()
            strOutletIso = frmAddHydroValve.NewValveTag
            frmAddHydroValve.Dispose()
        End If


        NewRow = {txtSpecTag.Text, lstAvailSpecialties.Text, gridAvailItems.SelectedRows.Item(0).Cells.Item(0).Value, gridAvailItems.SelectedRows.Item(0).Cells.Item(1).Value, strInletIso, strOutletIso, gridAvailItems.SelectedRows.Item(0).Cells("DryWeight").Value, gridAvailItems.SelectedRows.Item(0).Cells("FluidVol").Value}
        gridSepecialties.Rows.Add(NewRow)

        'recalc the weights and volume when something is added
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
        Call UpdateWorkComplete(lstAvailSpecialties.Text)
        lstAvailSpecialties.ClearSelected()



    End Sub

    Private Sub UpdateWorkComplete(lItem As String)
        Select Case lItem
            Case Is = "Pumps"
                PumpsDone = PumpsDone - 1
            Case Is = "Triple Duty Valve"
                TDVDone = True
            Case Is = "Suction Diffuser"
                SucDiffDone = True
            Case Is = "Buffer Tank"
                BTankDone = True
            Case Is = "Expansion Tank"
                XTankDone = True
            Case Is = "Air Separator"
                ASepDone = True
            Case Is = "Wye Strainer"
                StrainDone = True
            Case Is = "Tee Strainer"
                StrainDone = True
            Case Is = "Glycol Makeup Unit"
                StrainDone = True
            Case Is = "Chemical Pot Feeder"
                PotFeedDone = True
            Case Is = "Insulation"
                InsDone = True
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbcPipePkg.SelectTab("pgPumps")
    End Sub

    Private Sub btnDoneCouplings_Click(sender As Object, e As EventArgs) Handles btnDoneCouplings.Click
        tbcPipePkg.SelectTab("pgStructure")
    End Sub

    Private Sub lstAvailSpecialties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailSpecialties.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim tagbase As String
        Dim tagnum As Integer
        Dim i As Integer

        Dim MySQL As String
        Dim NewRow As String()

        If lstAvailSpecialties.Text = "" Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        gridAvailItems.Rows.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroSpecialtyData WHERE Type='" & lstAvailSpecialties.Text & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            NewRow = {rs.Fields("Size").Value, rs.Fields("Brand").Value, rs.Fields("InletSize").Value, rs.Fields("OutletSize").Value, rs.Fields("DryWeight").Value, rs.Fields("FluidVol").Value}
            gridAvailItems.Rows.Add(NewRow)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing
        tagbase = "T-"
        Select Case lstAvailSpecialties.Text
            Case Is = "Triple Duty Valve"
                tagbase = "DMPV-"
            Case Is = "Suction Diffuser"
                tagbase = "SD-"
            Case Is = "Bladder Expansion Tank"
                tagbase = "XT-"
            Case Is = "Air Separator"
                tagbase = "AS-"
            Case Is = "Automatic Air Vent"
                tagbase = "AAV-"
            Case Is = "Wye Strainer"
                tagbase = "WS-"
            Case Is = "Tee Strainer"
                tagbase = "TS-"
            Case Is = "Glycol Makeup Unit"
                tagbase = "GMU-"
            Case Is = "Chemical Pot Feeder"
                tagbase = "CPF-"
        End Select

        tagnum = 1
        For i = 0 To gridSepecialties.RowCount - 1
            If gridSepecialties.Rows.Item(i).Cells.Item("Item").Value = lstAvailSpecialties.Text Then
                tagnum = tagnum + 1
            End If
        Next

        txtSpecTag.Text = tagbase & Trim(Str(tagnum))
    End Sub
    Private Function PackagePD() As String
        Dim tempPD As Double

        tempPD = -999.666
        tempPD = SpecialtysPD + ValvesPD + FittingsPD + PipesPD

        PackagePD = tempPD
    End Function
    Private Function SpecialtysPD() As Double
        Dim i As Integer
        Dim temppd As Double
        Dim thispd As String
        temppd = 0
        For i = 0 To gridSepecialties.RowCount - 1

            thispd = gridSepecialties.Rows.Item(i).Cells.Item("SpecPDrop").Value
            temppd = temppd + Val(thispd)
        Next
        SpecialtysPD = temppd
    End Function
    Private Function ValvesPD() As Double
        Dim tempPD As Double
        Dim i As Integer

        Dim thispd As String
        tempPD = 0
        'For i = 0 To gridSepecialties.RowCount - 1
        For i = 0 To gridValveSchedule.RowCount - 1
            thispd = gridValveSchedule.Rows.Item(i).Cells.Item("ValvePD").Value
            tempPD = tempPD + Val(thispd)
        Next
        ValvesPD = tempPD
    End Function
    Private Function FittingsPD() As Double
        Dim tempPD As Double

        tempPD = -999.666

        FittingsPD = tempPD
    End Function
    Private Function PipesPD() As Double
        Dim tempPD As Double

        tempPD = -999.666
        tempPD = Val(txtPDper100ft.Text) / 100.0 * Val(txtPipeLength.Text)
        PipesPD = tempPD
    End Function
    Private Function PDper100Ft() As Double
        Dim FrictionFactor As Double
        Dim PipeLength As Double
        Dim PipeID As Double
        Dim PipeFlow As Double
        Dim Density As Double
        Dim Viscosity As Double
        Dim AbsRough As Double
        Dim ReyNum As Double
        Dim RelRough As Double
        Dim tempPD As Double

        Viscosity = 1.1 'cP
        Density = 62.4 'lb/cu ft
        PipeFlow = Val(txtFlow.Text)
        AbsRough = 0.0018
        If cmbPipeSize.Text = "" Then
            PipeID = 3
        Else
            PipeID = cmbPipeSize.Text
        End If


        ReyNum = 50.6 * PipeFlow * Density * txtFluidSG.Text / PipeID / Viscosity
        RelRough = AbsRough / PipeID

        FrictionFactor = 0.25 / (Math.Log10((AbsRough / 3.7 / PipeID) + (5.74 / ReyNum ^ 0.9))) ^ 2

        PipeLength = 100.0

        tempPD = 0.311 * FrictionFactor * PipeLength * PipeFlow * PipeFlow / PipeID ^ 5

        PDper100Ft = tempPD
    End Function
    Private Function PackageVolume() As String
        Dim tempvol As Double
        tempvol = -9999.666
        tempvol = SpecialtyVolumes() + ValveVolumes() + FittingVolumes + PipeVolumes

        PackageVolume = Format(tempvol, "0")
    End Function

    Private Function PackageWeight() As String
        Dim tempweight As Double
        tempweight = -9999.666
        tempweight = SpecialtyWeights() + ValveWeights() + FittingWeights() + PipeWeights() + CouplingWeights()

        PackageWeight = Format(tempweight, "0.0")
    End Function
    Private Function SpecialtyWeights() As Double
        Dim i As Integer
        Dim tempweight As Double
        Dim thisweight As String
        tempweight = 0
        For i = 0 To gridSepecialties.RowCount - 1
            'gridAvailItems.SelectedRows.Item(0).Cells.Item(2).Value
            thisweight = gridSepecialties.Rows.Item(i).Cells.Item("SpecDryWeight").Value
            tempweight = tempweight + Val(thisweight)
        Next
        SpecialtyWeights = tempweight
    End Function
    Private Function ValveWeights() As Double
        Dim i As Integer
        Dim tempweight As Double
        Dim thisweight As String
        tempweight = 0
        For i = 0 To gridValveSchedule.RowCount - 1
            thisweight = gridValveSchedule.Rows.Item(i).Cells.Item("ValveWeight").Value
            tempweight = tempweight + Val(thisweight)
        Next
        ValveWeights = tempweight
    End Function
    Private Function FittingWeights() As Double
        Dim tempweight As Double
        Dim Ell225Weight As Double
        Dim Ell45Weight As Double
        Dim Ell90Weight As Double
        Dim TeeWeight As Double
        Dim BTeeWeight As Double
        tempweight = 0
        Ell225Weight = Val(lbl225Mass.Text) * nud225.Value
        Ell90Weight = Val(lbl90Mass.Text) * nud90.Value
        Ell45Weight = Val(lbl45Mass.Text) * nud45.Value
        TeeWeight = Val(lblTeeMass.Text) * nudTee.Value
        BTeeWeight = Val(lblBTeeMass.Text) * nudBTee.Value

        tempweight = Ell225Weight + Ell90Weight + Ell45Weight + TeeWeight + BTeeWeight
        FittingWeights = tempweight
    End Function
    Private Function CouplingWeights() As Double
        Dim tempweight As Double
        tempweight = 0

        Dim RigidWeight As Double
        Dim FlexWeight As Double
        Dim FlangeWeight As Double
        Dim Red1Weight As Double
        Dim Red2Weight As Double
        Dim Out1Weight As Double
        Dim Out2Weight As Double
        RigidWeight = Val(lblVicRigid107H.Text) * nudVicRigid107H.Value
        FlexWeight = Val(lblVicFlex177.Text) * nudVicFlex177.Value
        FlangeWeight = Val(lblVicFlange741.Text) * nudVicFlange741.Value
        Red1Weight = Val(lblVicReducing750_1.Text) * nudVicReducing750_1.Value
        Red2Weight = Val(lblVicReducing750_2.Text) * nudVicReducing750_2.Value
        Out1Weight = Val(lblVicOutlet72_1.Text) * nudVicOutlet72_1.Value
        Out2Weight = Val(lblVicOutlet72_2.Text) * nudVicOutlet72_2.Value
        tempweight = RigidWeight + FlexWeight + FlangeWeight + Red1Weight + Red2Weight + Out1Weight + Out2Weight
        CouplingWeights = tempweight
    End Function
    Private Function PipeWeights() As Double
        Dim tempweight As Double
        Dim pipeweight As Double

        tempweight = 0
        If Double.TryParse(lblPipeWeight.Text, pipeweight) Then
            tempweight = Val(txtPipeLength.Text) * pipeweight
        End If
        PipeWeights = tempweight
    End Function
    Private Function SpecialtyVolumes() As Double
        Dim i As Integer
        Dim tempvol As Double
        Dim thisvol As String
        tempvol = 0
        For i = 0 To gridSepecialties.RowCount - 1
            thisvol = gridSepecialties.Rows.Item(i).Cells.Item("SpecFluidVol").Value
            tempvol = tempvol + Val(thisvol)
        Next
        SpecialtyVolumes = tempvol
    End Function
    Private Function ValveVolumes() As Double
        Dim i As Integer
        Dim tempvol As Double
        Dim thisvol As String
        tempvol = 0
        For i = 0 To gridValveSchedule.RowCount - 1
            thisvol = gridValveSchedule.Rows.Item(i).Cells.Item("ValveVolume").Value
            tempvol = tempvol + Val(thisvol)
        Next
        ValveVolumes = tempvol
    End Function
    Private Function FittingVolumes() As Double
        Dim tempvol As Double
        Dim Ell225Vol As Double
        Dim Ell45Vol As Double
        Dim Ell90Vol As Double
        Dim TeeVol As Double
        Dim BTeeVol As Double
        tempvol = 0
        Ell225Vol = Val(lbl225Vol.Text) * nud225.Value
        Ell90Vol = Val(lbl90Vol.Text) * nud90.Value
        Ell45Vol = Val(lbl45Vol.Text) * nud45.Value
        TeeVol = Val(lblTeeVol.Text) * nudTee.Value
        BTeeVol = Val(lblBTeeVol.Text) * nudBTee.Value

        tempvol = Ell225Vol + Ell90Vol + Ell45Vol + TeeVol + BTeeVol
        FittingVolumes = tempvol
    End Function

    Private Function PipeVolumes() As Double
        Dim tempvol As Double
        Dim pipevol As Double

        tempvol = 0
        If Double.TryParse(lblPipeVol.Text, pipevol) Then
            tempvol = Val(txtPipeLength.Text) * pipevol
        End If
        PipeVolumes = tempvol
    End Function
    Private Sub btnAddValve_Click(sender As Object, e As EventArgs) Handles btnAddValve.Click
        frmAddHydroValve.ShowDialog()
        frmAddHydroValve.Dispose()
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub cmbPipeSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPipeSize.SelectedIndexChanged
        Call LoadPipeData()
        Call LoadFittingData()
        Call LoadCouplingData()
        txtFluidVolume.Text = PackageVolume()
        txtDryWeight.Text = PackageWeight()
        txtPDper100ft.Text = Format(PDper100Ft(), "0.000")
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub
    Private Sub LoadPipeData()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSchedule As String
        Dim PipeSize As String

        Dim MySQL As String
        PipeSize = cmbPipeSize.Text
        PipeSchedule = cmbPipeSchedule.Text
        If PipeSchedule = "" Then Exit Sub
        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }



        MySQL = "SELECT * FROM tblHydroPipe WHERE PipeSchedule='" & PipeSchedule & "' AND PipeSize='" & PipeSize & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblPipeWeight.Text = rs.Fields("Weight").Value
        lblPipeVol.Text = rs.Fields("Volume").Value
        lblPipeEL.Text = rs.Fields("EquivLength").Value
        lblPipeSA.Text = rs.Fields("SurfaceArea").Value

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadFittingData()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim FittingStyle As String
        Dim PipeSize As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text
        FittingStyle = cmbFittingStyle.Text
        If FittingStyle = "" Then FittingStyle = "Victaulic"

        MySQL = "SELECT * FROM tblHydroFittings WHERE FittingStyle='" & FittingStyle & "' AND FittingSize='" & PipeSize & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        rs.Find("FittingType='225'")
        lbl225Mass.Text = rs.Fields("Weight").Value
        lbl225Vol.Text = rs.Fields("Volume").Value
        lbl225EL.Text = rs.Fields("EquivLength").Value
        lbl225SA.Text = rs.Fields("SurfaceArea").Value

        rs.MoveFirst()
        rs.Find("FittingType='45'")
        lbl45Mass.Text = rs.Fields("Weight").Value
        lbl45Vol.Text = rs.Fields("Volume").Value
        lbl45EL.Text = rs.Fields("EquivLength").Value
        lbl45SA.Text = rs.Fields("SurfaceArea").Value

        rs.MoveFirst()
        rs.Find("FittingType='90'")
        lbl90Mass.Text = rs.Fields("Weight").Value
        lbl90Vol.Text = rs.Fields("Volume").Value
        lbl90EL.Text = rs.Fields("EquivLength").Value
        lbl90SA.Text = rs.Fields("SurfaceArea").Value

        rs.MoveFirst()
        rs.Find("FittingType='Tee'")
        lblTeeMass.Text = rs.Fields("Weight").Value
        lblTeeVol.Text = rs.Fields("Volume").Value
        lblTeeEL.Text = rs.Fields("EquivLength").Value
        lblTeeSA.Text = rs.Fields("SurfaceArea").Value

        rs.MoveFirst()
        rs.Find("FittingType='BTee'")
        lblBTeeMass.Text = rs.Fields("Weight").Value
        lblBTeeVol.Text = rs.Fields("Volume").Value
        lblBTeeEL.Text = rs.Fields("EquivLength").Value
        lblBTeeSA.Text = rs.Fields("SurfaceArea").Value

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadCouplingData()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSize As String
        Dim TempText As String

        Dim MySQL As String

        cmbVicReducing01.Items.Clear()
        cmbVicReducing02.Items.Clear()
        cmbVicOutlet01.Items.Clear()
        cmbVicOutlet02.Items.Clear()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text

        MySQL = "SELECT * FROM tblHydroVicCouplings WHERE NominalSize='" & PipeSize & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        rs.Find("Style='Rigid'")
        lblVicRigid107H.Text = rs.Fields("Weight").Value

        rs.MoveFirst()
        rs.Find("Style='Flex'")
        lblVicFlex177.Text = rs.Fields("Weight").Value

        rs.MoveFirst()
        rs.Find("Style='Flange'")
        lblVicFlange741.Text = rs.Fields("Weight").Value

        rs.MoveFirst()
        Do While Not (rs.EOF)
            rs.Find("Style='Reducing'")
            TempText = PipeSize & """ x " & rs.Fields("OutletSize").Value & """"
            cmbVicReducing01.Items.Add(TempText)
            cmbVicReducing02.Items.Add(TempText)
            rs.MoveNext()
            rs.Find("Style='Reducing'")
        Loop

        rs.MoveFirst()
        Do While Not (rs.EOF)
            rs.Find("Style='Outlet'")
            TempText = rs.Fields("BranchSize").Value & """ Outlet"
            cmbVicOutlet01.Items.Add(TempText)
            cmbVicOutlet02.Items.Add(TempText)
            rs.MoveNext()
            rs.Find("Style='Outlet'")
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub nud225_ValueChanged(sender As Object, e As EventArgs) Handles nud225.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nud45_ValueChanged(sender As Object, e As EventArgs) Handles nud45.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nud90_ValueChanged(sender As Object, e As EventArgs) Handles nud90.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudTee_ValueChanged(sender As Object, e As EventArgs) Handles nudTee.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudBTee_ValueChanged(sender As Object, e As EventArgs) Handles nudBTee.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub tbcPipePkg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPipePkg.SelectedIndexChanged
        If tbcPipePkg.SelectedTab.Name = "pgPipeandFittings" Then
            Call LoadPipeData()
        End If
    End Sub

    Private Sub txtPipeLength_LostFocus(sender As Object, e As EventArgs) Handles txtPipeLength.LostFocus
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub cmbFluid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFluid.SelectedIndexChanged
        If cmbFluid.Text = "Water" Then cmbFluidPercent.Text = "-"
        txtFluidSG.Text = LoadSpecificGravity()
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")

    End Sub
    Private Function LoadSpecificGravity() As String
        Dim tempSG As String

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim FluidName As String
        Dim FluidPercent As String

        FluidName = cmbFluid.Text
        FluidPercent = cmbFluidPercent.Text

        If ((FluidName = "") Or (FluidPercent = "") Or (FluidPercent = "-") Or FluidName = "Water") Then
            LoadSpecificGravity = "1.000"
            Exit Function
        End If

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblFluids WHERE Fluid='" & FluidName & "' AND MixbyMass='" & FluidPercent & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        tempSG = rs.Fields("SpecificGravity").Value

        con.Close()
        rs = Nothing
        con = Nothing

        LoadSpecificGravity = tempSG
    End Function

    Private Sub cmbFluidPercent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFluidPercent.SelectedIndexChanged
        txtFluidSG.Text = LoadSpecificGravity()
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPDper100ft.Text = Format(PDper100Ft(), "0.000")
        txtPackagePD.Text = PackagePD()
        txtWeightPerGallon.Text = Format(Val(txtFluidSG.Text) * 8.71, "0.00")
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub cmbPipeSchedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPipeSchedule.SelectedIndexChanged
        txtFluidSG.Text = LoadSpecificGravity()
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPDper100ft.Text = Format(PDper100Ft(), "0.000")
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub cmbFittingStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFittingStyle.SelectedIndexChanged
        txtFluidSG.Text = LoadSpecificGravity()
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPDper100ft.Text = Format(PDper100Ft(), "0.000")
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub lstAvailHydroDrawing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailHydroDrawing.SelectedIndexChanged
        If lstAvailHydroDrawing.SelectedIndex >= 0 Then
            txtAvailDescription.Text = HydroDesc(lstAvailHydroDrawing.SelectedIndex)
            PictureBox1.ImageLocation = frmMain.ThisUnit.ResourcePath & HydroWMF(lstAvailHydroDrawing.SelectedIndex)

        End If
    End Sub

    Private Sub cmbVicReducing01_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVicReducing01.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSize As String
        Dim TempText As String

        Dim MySQL As String

        If cmbVicReducing01.Text = "" Then Exit Sub
        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text
        TempText = Trim(Mid(cmbVicReducing01.Text, InStr(cmbVicReducing01.Text, "x") + 2))
        TempText = Mid(TempText, 1, Len(TempText) - 1)

        MySQL = "SELECT * FROM tblHydroVicCouplings WHERE NominalSize='" & PipeSize & "' AND OutletSize='" & TempText & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblVicReducing750_1.Text = rs.Fields("Weight").Value

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmbVicReducing02_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVicReducing02.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSize As String
        Dim TempText As String

        Dim MySQL As String

        If cmbVicReducing02.Text = "" Then Exit Sub
        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text
        TempText = Trim(Mid(cmbVicReducing02.Text, InStr(cmbVicReducing02.Text, "x") + 2))
        TempText = Mid(TempText, 1, Len(TempText) - 1)

        MySQL = "SELECT * FROM tblHydroVicCouplings WHERE NominalSize='" & PipeSize & "' AND OutletSize='" & TempText & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblVicReducing750_2.Text = rs.Fields("Weight").Value

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmbVicOutlet01_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVicOutlet01.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSize As String
        Dim TempText As String

        Dim MySQL As String

        If cmbVicOutlet01.Text = "" Then Exit Sub
        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text
        TempText = Trim(Mid(cmbVicOutlet01.Text, 1, InStr(cmbVicOutlet01.Text, """") - 1))


        MySQL = "SELECT * FROM tblHydroVicCouplings WHERE NominalSize='" & PipeSize & "' AND BranchSize='" & TempText & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblVicOutlet72_1.Text = rs.Fields("Weight").Value

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmbVicOutlet02_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVicOutlet02.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim PipeSize As String
        Dim TempText As String

        Dim MySQL As String

        If cmbVicOutlet02.Text = "" Then Exit Sub
        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        PipeSize = cmbPipeSize.Text
        TempText = Trim(Mid(cmbVicOutlet02.Text, 1, InStr(cmbVicOutlet02.Text, """") - 1))


        MySQL = "SELECT * FROM tblHydroVicCouplings WHERE NominalSize='" & PipeSize & "' AND BranchSize='" & TempText & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        lblVicOutlet72_2.Text = rs.Fields("Weight").Value

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub nudVicRigid107H_ValueChanged(sender As Object, e As EventArgs) Handles nudVicRigid107H.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicFlex177_ValueChanged(sender As Object, e As EventArgs) Handles nudVicFlex177.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicFlange741_ValueChanged(sender As Object, e As EventArgs) Handles nudVicFlange741.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicReducing750_1_ValueChanged(sender As Object, e As EventArgs) Handles nudVicReducing750_1.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicReducing750_2_ValueChanged(sender As Object, e As EventArgs) Handles nudVicReducing750_2.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicOutlet72_1_ValueChanged(sender As Object, e As EventArgs) Handles nudVicOutlet72_1.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub nudVicOutlet72_2_ValueChanged(sender As Object, e As EventArgs) Handles nudVicOutlet72_2.ValueChanged
        txtDryWeight.Text = PackageWeight()
        txtFluidVolume.Text = PackageVolume()
        txtPackagePD.Text = PackagePD()
        txtWetWeight.Text = Format(Val(txtDryWeight.Text) + Val(txtFluidVolume.Text) * Val(txtWeightPerGallon.Text), "0.0")
    End Sub

    Private Sub optPkgAHU_CheckedChanged(sender As Object, e As EventArgs) Handles optPkgAHU.CheckedChanged
        If optPkgAHU.Checked = True Then
            chkPkgAHUCool.Enabled = True
            chkPkgAHUHeat.Enabled = True

        Else
            chkPkgAHUCool.Enabled = False
            chkPkgAHUHeat.Enabled = False
            chkPkgAHUCool.Checked = False
            chkPkgAHUHeat.Checked = False

        End If
    End Sub

    Private Sub chkPkgAHUHeat_CheckedChanged(sender As Object, e As EventArgs) Handles chkPkgAHUHeat.CheckedChanged
        If chkPkgAHUHeat.Checked = True Then
            txtFlowHeat.Visible = True
            cmbFluidHeat.Visible = True
            cmbFluidPercentHeat.Visible = True
            Label45.Visible = True
            Label46.Visible = True
            Label47.Visible = True
            Label50.Visible = True
        Else
            txtFlowHeat.Visible = False
            cmbFluidHeat.Visible = False
            cmbFluidPercentHeat.Visible = False
            txtFlowHeat.Text = False
            cmbFluidHeat.Text = False
            cmbFluidPercentHeat.Text = False
            Label45.Visible = False
            Label46.Visible = False
            Label47.Visible = False
            Label50.Visible = False

        End If
    End Sub

    Private Sub chkScopePumps_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopePumps.CheckedChanged
        If chkScopePumps.Checked Then
            cmbPumpSpec.Enabled = True
            cmbPumpSpec.Text = "Use Standard"
            nudPumpCount.Enabled = True
            nudPumpCount.Value = 1
            nudPumpCount.Minimum = 1
            cmbPumpStyle.Enabled = True
            chkScopeTDV.Checked = True
            chkScopeSuctionDiff.Checked = True
            grpPumpMotorStyle.Enabled = True
            grpPumpCtrl.Visible = True
            optPCtrlIVSonPump.Checked = True
            optPCtrlNA.Enabled = False
            grpPumpSystem.Visible = True
            optPumpSystemPriStby.Checked = True

            If chkScopeEnclosure.Checked Then
                optODPPumpMotor.Enabled = True
                optODPPumpMotor.Checked = True
                optTEFCPumpMotor.Enabled = True
                optPumpMotorNA.Enabled = False
            Else
                optODPPumpMotor.Enabled = False
                optTEFCPumpMotor.Enabled = True
                optPumpMotorNA.Enabled = False
                optTEFCPumpMotor.Checked = True
            End If

        Else
            cmbPumpSpec.Enabled = False
            cmbPumpSpec.Text = "Not Required"
            nudPumpCount.Enabled = False
            nudPumpCount.Minimum = 0
            nudPumpCount.Value = 0
            cmbPumpStyle.Enabled = False
            grpPumpMotorStyle.Enabled = False
            optODPPumpMotor.Enabled = False
            optTEFCPumpMotor.Enabled = False
            optPumpMotorNA.Enabled = True
            optPumpMotorNA.Checked = True
            grpPumpCtrl.Visible = False
            optPCtrlNA.Checked = True
            optPCtrlNA.Enabled = True

            grpPumpSystem.Visible = False
            optPumpSystemNA.Checked = True
        End If
    End Sub

    Private Sub cmbPumpSpec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPumpSpec.SelectedIndexChanged

        cmbPumpStyle.Items.Clear()

        Select Case cmbPumpSpec.Text
            Case Is = "Use Standard", Is = "Armstrong"
                cmbPumpStyle.Items.Add("Close Coupled Dual Arm")
                cmbPumpStyle.Items.Add("Split Coupled Dual Arm")
                cmbPumpStyle.Items.Add("Close Coupled Twin")
                cmbPumpStyle.Items.Add("Split Coupled Twin")
                cmbPumpStyle.Items.Add("Close Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled End Suction")
                cmbPumpStyle.Items.Add("Split End Suction")
                cmbPumpStyle.Items.Add("Unselected")
                cmbPumpStyle.Text = "Unselected"
            Case Is = "Bell and Gossett"
                cmbPumpStyle.Items.Add("Close Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled End Suction")
                cmbPumpStyle.Items.Add("Split End Suction")
                cmbPumpStyle.Items.Add("Unselected")
                cmbPumpStyle.Text = "Unselected"
            Case Is = "Taco"
                cmbPumpStyle.Items.Add("Close Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled Vertical Inline")
                cmbPumpStyle.Items.Add("Split Coupled End Suction")
                cmbPumpStyle.Items.Add("Split End Suction")
                cmbPumpStyle.Items.Add("Unselected")
                cmbPumpStyle.Text = "Unselected"
            Case Is = "Not Required"
                cmbPumpStyle.Items.Add("Not Required")
                cmbPumpStyle.Text = "Not Required"
        End Select
    End Sub

    Private Sub chkScopeTDV_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeTDV.CheckedChanged
        If chkScopeTDV.Checked Then
            cmbTDVSpec.Enabled = True
            cmbTDVSpec.Text = "Use Standard"
            optTDVOptionsAngle.Enabled = True
            optTDVOptionsStraight.Enabled = True
            optTDVOptionsNA.Enabled = False
            optTDVOptionsStraight.Checked = True
        Else
            cmbTDVSpec.Enabled = False
            cmbTDVSpec.Text = "Not Required"
            optTDVOptionsAngle.Enabled = False
            optTDVOptionsStraight.Enabled = False
            optTDVOptionsNA.Enabled = True
            optTDVOptionsNA.Checked = True
        End If

    End Sub

    Private Sub chkScopeSuctionDiff_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeSuctionDiff.CheckedChanged
        If chkScopeSuctionDiff.Checked Then
            cmbSucDiffSpec.Enabled = True
            cmbSucDiffSpec.Text = "Use Standard"
            grpSucDiffOptions.Enabled = True

        Else
            cmbSucDiffSpec.Enabled = False
            cmbSucDiffSpec.Text = "Not Required"
            grpSucDiffOptions.Enabled = True
            chkSucDiffOptionsBlowDownValve.Checked = False

        End If
    End Sub
    Private Sub chkScopeBufferTank_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeBufferTank.CheckedChanged
        If chkScopeBufferTank.Checked Then
            cmbBuffTankSpec.Enabled = True
            cmbBuffTankSpec.Text = "Use Standard"
            grpBufferTankOpts.Enabled = True
            optBTSprayFoam.Checked = True
            optBTHTNone.Checked = True
            txtBTkWofHeat.Text = "n/a"
            optBTVentManual.Checked = True
            optBTDrainValve.Checked = True
            cmbBuffTankStyle.Enabled = True
            txtBTCapacity.Enabled = True
        Else
            cmbBuffTankSpec.Enabled = False
            cmbBuffTankSpec.Text = "Not Required"
            grpBufferTankOpts.Enabled = False
            optBTInsNA.Checked = True
            optBTHTNA.Checked = True
            txtBTkWofHeat.Text = "n/a"
            optBTVentNA.Checked = True
            optBTDrainNA.Checked = True
            cmbBuffTankStyle.SelectedIndex = False
            txtBTCapacity.Enabled = False
        End If
    End Sub

    Private Sub chkScopeExpansionTank_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeExpansionTank.CheckedChanged
        If chkScopeExpansionTank.Checked Then
            cmbExpTankSpec.Enabled = True
            cmbExpTankSpec.Text = "Use Standard"
            cmbExpTankStyle.Enabled = True

        Else
            cmbExpTankSpec.Enabled = False
            cmbExpTankSpec.Text = "Not Required"
            cmbExpTankStyle.Enabled = False

        End If
    End Sub
    Private Sub chkScopeAirSeparator_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeAirSeparator.CheckedChanged
        If chkScopeAirSeparator.Checked Then
            cmbAirSepSpec.Enabled = True
            cmbAirSepSpec.Text = "Use Standard"
        Else
            cmbAirSepSpec.Enabled = False
            cmbAirSepSpec.Text = "Not Required"
        End If
    End Sub

    Private Sub chkScopeStrainer_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeStrainer.CheckedChanged
        If chkScopeStrainer.Checked Then
            cmbStrainSpec.Enabled = True
            cmbStrainSpec.Text = "Use Standard"
        Else
            cmbStrainSpec.Enabled = False
            cmbStrainSpec.Text = "Not Required"
        End If
    End Sub
    Private Sub chkScopeGMU_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeGMU.CheckedChanged
        If chkScopeGMU.Checked Then
            cmbGMUSpec.Enabled = True
            If chkScopeEnclosure.Checked Then cmbGMUSpec.Text = "GTP" Else cmbGMUSpec.Text = "John Wood"
            cmbGMUStyle.Enabled = True
        Else
            cmbGMUSpec.Enabled = False
            cmbGMUSpec.Text = "Not Required"
            cmbGMUStyle.Enabled = False
        End If
    End Sub

    Private Sub chkScopePotFeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopePotFeed.CheckedChanged
        If chkScopePotFeed.Checked Then
            cmbPotFeedSpec.Enabled = True
            cmbPotFeedSpec.Text = "Use Standard"
            cmbPotFeedStyle.Enabled = True
        Else
            cmbPotFeedSpec.Enabled = False
            cmbPotFeedSpec.Text = "Not Required"
            cmbPotFeedStyle.Enabled = False
        End If
    End Sub
    Private Sub chkScopeInsulation_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeInsulation.CheckedChanged
        If chkScopeInsulation.Checked Then
            cmbInsSpec.Enabled = True
            cmbInsSpec.Text = "Use Standard"
        Else
            cmbInsSpec.Enabled = False
            cmbInsSpec.Text = "Not Required"
        End If
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PumpsDone = 0
        SucDiffDone = True
        TDVDone = True
        BTankDone = True
        XTankDone = True
        ASepDone = True
        StrainDone = True
        GMUDone = True
        InsDone = True
        PotFeedDone = True

    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub cmbBuffTankSpec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuffTankSpec.SelectedIndexChanged
        cmbBuffTankStyle.Items.Clear()

        Select Case cmbBuffTankSpec.Text
            Case Is = "Use Standard", Is = "Niles Steel Tank"
                cmbBuffTankStyle.Items.Add("130 gal. CBT-24-072")
                cmbBuffTankStyle.Items.Add("210 gal. CBT-30-075")
                cmbBuffTankStyle.Items.Add("300 gal. CBT-36-072")
                cmbBuffTankStyle.Items.Add("400 gal. CBT-36-094")
                cmbBuffTankStyle.Items.Add("460 gal. CBT-42-084")
                cmbBuffTankStyle.Items.Add("528 gal. CBT-48-077")
                cmbBuffTankStyle.Items.Add("1000 gal. CBT-48-141")
                cmbBuffTankStyle.Items.Add("Custom Capacity Tank")
                cmbBuffTankStyle.Items.Add("Unselected")
                cmbBuffTankStyle.Text = "Unselected"
            Case Is = "Buckeye Fabrication"
                cmbBuffTankStyle.Items.Add("Custom Capacity Tank")
                cmbBuffTankStyle.Items.Add("Unselected")
                cmbBuffTankStyle.Text = "Unselected"
            Case Is = "Elbi"
                cmbBuffTankStyle.Items.Add("Custom Capacity Tank")
                cmbBuffTankStyle.Items.Add("Unselected")
                cmbBuffTankStyle.Text = "Unselected"
            Case Is = "Not Required"
                cmbBuffTankStyle.Items.Add("Not Required")
                cmbBuffTankStyle.Text = "Not Required"
        End Select
    End Sub

    Private Sub optBTHTNone_CheckedChanged(sender As Object, e As EventArgs) Handles optBTHTNone.CheckedChanged
        If optBTHTNone.Checked Then
            txtBTkWofHeat.Text = "n/a"
            txtBTkWofHeat.Enabled = False
            chkBTHTUnitPowered.Checked = False
            chkBTHTUnitPowered.Enabled = False
        End If
    End Sub

    Private Sub optBTHTNA_CheckedChanged(sender As Object, e As EventArgs) Handles optBTHTNA.CheckedChanged
        If optBTHTNA.Checked Then
            txtBTkWofHeat.Text = "n/a"
            txtBTkWofHeat.Enabled = False
            chkBTHTUnitPowered.Checked = False
            chkBTHTUnitPowered.Enabled = False
        End If
    End Sub

    Private Sub optBTHTHeatTrace_CheckedChanged(sender As Object, e As EventArgs) Handles optBTHTHeatTrace.CheckedChanged
        If optBTHTHeatTrace.Checked Then
            txtBTkWofHeat.Text = "0.0"
            txtBTkWofHeat.Enabled = True
            chkBTHTUnitPowered.Enabled = True
        End If
    End Sub

    Private Sub optBTHTImmersion_CheckedChanged(sender As Object, e As EventArgs) Handles optBTHTImmersion.CheckedChanged
        txtBTkWofHeat.Text = "0.0"
        txtBTkWofHeat.Enabled = True
        chkBTHTUnitPowered.Enabled = True
    End Sub

    Private Sub cmbBuffTankStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuffTankStyle.SelectedIndexChanged
        Select Case cmbBuffTankStyle.Text
            Case Is = "Custom Capacity Tank"
                txtBTCapacity.Text = "0"
                txtBTCapacity.ReadOnly = False
            Case Is = "Unselected"
                txtBTCapacity.Text = "-"
                txtBTCapacity.ReadOnly = True
            Case Is = "Not Required"
                txtBTCapacity.Text = "-"
                txtBTCapacity.ReadOnly = True
            Case Is = "130 gal. CBT-24-072"
                txtBTCapacity.Text = "130"
                txtBTCapacity.ReadOnly = True
            Case Is = "210 gal. CBT-30-075"
                txtBTCapacity.Text = "210"
                txtBTCapacity.ReadOnly = True
            Case Is = "300 gal. CBT-36-072"
                txtBTCapacity.Text = "300"
                txtBTCapacity.ReadOnly = True
            Case Is = "400 gal. CBT-36-094"
                txtBTCapacity.Text = "400"
                txtBTCapacity.ReadOnly = True
            Case Is = "460 gal. CBT-42-084"
                txtBTCapacity.Text = "460"
                txtBTCapacity.ReadOnly = True
            Case Is = "528 gal. CBT-48-077"
                txtBTCapacity.Text = "528"
                txtBTCapacity.ReadOnly = True
            Case Is = "1000 gal. CBT-48-141"
                txtBTCapacity.Text = "1000"
                txtBTCapacity.ReadOnly = True
        End Select
    End Sub

    Private Sub cmbExpTankSpec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpTankSpec.SelectedIndexChanged
        If cmbExpTankSpec.Text = "Not Required" Then
            cmbExpTankStyle.Text = "Not Required"
        Else
            cmbExpTankStyle.Text = "Use Standard"
        End If

    End Sub



    Private Sub cmbGMUSpec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGMUSpec.SelectedIndexChanged


        Select Case cmbGMUSpec.Text
            Case Is = "Use Standard"
                If chkScopeEnclosure.Checked Then
                    cmbGMUStyle.Items.Clear()
                    cmbGMUStyle.Items.Add("15 Gal. Internal")
                    cmbGMUStyle.Items.Add("30 Gal. Internal")
                    cmbGMUStyle.Items.Add("55 Gal. Internal")
                    cmbGMUStyle.Items.Add("100 Gal. Internal")
                    cmbGMUStyle.Text = "15 Gal. Internal"
                Else
                    cmbGMUStyle.Items.Clear()
                    cmbGMUStyle.Items.Add("30 Gal. External")
                    cmbGMUStyle.Items.Add("55 Gal. External")
                    cmbGMUStyle.Items.Add("100 Gal. External")
                    cmbGMUStyle.Text = "30 Gal. External"
                End If
            Case Is = "John Wood"
                cmbGMUStyle.Items.Clear()
                cmbGMUStyle.Items.Add("30 Gal. External")
                cmbGMUStyle.Items.Add("55 Gal. External")
                cmbGMUStyle.Items.Add("100 Gal. External")
                cmbGMUStyle.Text = "30 Gal. External"
            Case Is = "GTP"
                cmbGMUStyle.Items.Clear()
                cmbGMUStyle.Items.Add("15 Gal. Internal")
                cmbGMUStyle.Items.Add("30 Gal. Internal")
                cmbGMUStyle.Items.Add("55 Gal. Internal")
                cmbGMUStyle.Items.Add("100 Gal. Internal")
                cmbGMUStyle.Text = "15 Gal. Internal"
            Case Is = "Not Required"
                cmbGMUStyle.Items.Clear()
                cmbGMUStyle.Items.Add("Not Required")
                cmbGMUStyle.Text = "Not Required"
        End Select
    End Sub

    Private Sub cmbPotFeedSpec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPotFeedSpec.SelectedIndexChanged
        Select Case cmbPotFeedSpec.Text
            Case Is = "Use Standard"
                cmbPotFeedStyle.Items.Clear()
                cmbPotFeedStyle.Items.Add("Use Standard")
                cmbPotFeedStyle.Items.Add("2 Gallon Capacity")
                cmbPotFeedStyle.Items.Add("5 Gallon Capacity")
                cmbPotFeedStyle.Text = "Use Standard"
            Case Is = "Not Required"
                cmbPotFeedStyle.Items.Clear()
                cmbPotFeedStyle.Items.Add("Not Required")
                cmbPotFeedStyle.Text = "Not Required"
        End Select
    End Sub

    Private Sub cmdFIOPPreview_Click(sender As Object, e As EventArgs) Handles cmdFIOPPreview.Click
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

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

        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode LIKE '800%'"
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

    Private Sub cmdDoneSpecOpt_Click(sender As Object, e As EventArgs) Handles cmdDoneSpecOpt.Click
        Call LoadApplicableHydroDrawings()
        tbcPipePkg.SelectTab("pgHydronicDWG")
    End Sub

    Private Sub chkScopeEnclosure_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeEnclosure.CheckedChanged
        If chkScopeEnclosure.Checked Then
            If grpPumpMotorStyle.Enabled = True Then optODPPumpMotor.Enabled = True
        End If
    End Sub

    Private Sub optPCtrlSpecificRemote_CheckedChanged(sender As Object, e As EventArgs) Handles optPCtrlSpecificRemote.CheckedChanged
        If optPCtrlSpecificRemote.Checked Then
            cmbPCtrlSpecDrive.Enabled = True
            cmbPCtrlSpecDrive.Text = "Unselected"
        Else
            cmbPCtrlSpecDrive.Enabled = False
            cmbPCtrlSpecDrive.Text = "Not Required"
        End If
    End Sub
End Class