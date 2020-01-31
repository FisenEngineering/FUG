Public Class frmPipePkg
    Private pCancelled As Boolean
    Private HydroDesc(25) As String
    Private HydroWMF(25) As String


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
        Call InitializeProposalDropdowns


    End Sub
    Private Sub InitializeProposalDropdowns()
        cmbPumpSpec.Text = "Use Standard"
        cmbTDVSpec.Text = "Use Standard"
        cmbSucDiffSpec.Text = "Use Standard"
        cmbBuffTankSpec.Text = "Use Standard"
        cmbExpTankSpec.Text = "Use Standard"
        cmbAirSepSpec.Text = "Use Standard"
        cmbStrainSpec.Text = "Use Standard"
        cmbGMUSpec.Text = "Use Standard"
        cmbInsSpec.Text = "Use Standard"
        cmbPotFeedSpec.Text = "Use Standard"

    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("PipePkg") 'Mod Code goes here!
        Call UpdateCodeList()
        Me.Hide()
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
    Private Sub UpdateCodeList()
        Dim i As Integer
        Dim CurrentSpecialty As String
        Dim dummy As MsgBoxResult

        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("800000") 'Hydronic Piping Package

        frmMain.ThisUnitCodes.Add("800300") 'Hydronic Specialties
        For i = 0 To gridSepecialties.Rows.Count - 1

            CurrentSpecialty = gridSepecialties.Rows(i).Cells.Item(1).Value
            Select Case CurrentSpecialty
                Case Is = "Suction Diffuser"
                    frmMain.ThisUnitCodes.Add("800310")
                Case Is = "Triple Duty Valve"
                    frmMain.ThisUnitCodes.Add("800305")
                Case Is = "Bladder Expansion Tank"
                    frmMain.ThisUnitCodes.Add("800315")
                Case Is = "Air Separator"
                    frmMain.ThisUnitCodes.Add("800320")
                Case Is = "Automatic Air Vent"
                    frmMain.ThisUnitCodes.Add("800321")
                Case Is = "Wye Strainer"
                    frmMain.ThisUnitCodes.Add("800325")
                Case Is = "Tee Strainer"
                    frmMain.ThisUnitCodes.Add("800326")
                Case Is = "Glycol Makeup Unit"
                    frmMain.ThisUnitCodes.Add("800330")
                Case Is = "Buffer Tank"
                    frmMain.ThisUnitCodes.Add("800A00")
                    Select Case gridSepecialties.Rows(i).Cells.Item(1).Value
                        Case Is = "160"
                            frmMain.ThisUnitCodes.Add("800336")
                        Case Is = "250"
                            frmMain.ThisUnitCodes.Add("800337")
                    End Select
                    'Handle the BT Insulation
                    If optBTUninsulated.Checked Then frmMain.ThisUnitCodes.Add("800338")
                    If optBTSprayFoam.Checked Then frmMain.ThisUnitCodes.Add("800339")
                    If optBTArmaflex.Checked Then frmMain.ThisUnitCodes.Add("800340")

                    'Handle the BT Heat
                    If optBTHTNone.Checked Then frmMain.ThisUnitCodes.Add("800341")
                    If ((optBTHTHeatTrace.Checked) And (chkBTHTUnitPowered.Checked)) Then frmMain.ThisUnitCodes.Add("800345")
                    If ((optBTHTHeatTrace.Checked) And (chkBTHTUnitPowered.Checked = False)) Then frmMain.ThisUnitCodes.Add("800344")
                    If ((optBTHTImmersion.Checked) And (chkBTHTUnitPowered.Checked)) Then frmMain.ThisUnitCodes.Add("800343")
                    If ((optBTHTImmersion.Checked) And (chkBTHTUnitPowered.Checked = False)) Then frmMain.ThisUnitCodes.Add("800342")

                    'Handle the BT Venting
                    If optBTVentNone.Checked Then frmMain.ThisUnitCodes.Add("800347")
                    If optBTVentManual.Checked Then frmMain.ThisUnitCodes.Add("800348")
                    If optBTVentAuto.Checked Then
                        frmMain.ThisUnitCodes.Add("800349")
                        frmMain.ThisUnitCodes.Add("800350")
                    End If

                    'Handle the BT Drain
                    If optBTDrainNone.Checked Then frmMain.ThisUnitCodes.Add("800351")
                    If optBTDrainValve.Checked Then frmMain.ThisUnitCodes.Add("800352")
                    If optBTDrainChainCap.Checked Then frmMain.ThisUnitCodes.Add("800353")

                Case Else
                    dummy = MsgBox("Unknown Specialty! Error!")
                    End
            End Select
        Next
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
        Call LoadApplicableHydroDrawings()

        tbcPipePkg.SelectTab("pgHydronicDWG")
    End Sub

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
        lstAvailSpecialties.ClearSelected()
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click

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
End Class