Imports System.ComponentModel

Public Class frmHWCoil

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
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems
        frmMain.ThisUnitMods.Add("HWCoil")
        Call UpdateCodeList()
        If chkWriteHistory.Checked = True Then Call WriteHWCoilHistory
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        Dim iHMI As Integer
        Dim HMIAlreadyThere As Boolean
        Dim tbblockadded As Boolean

        tbblockadded = False
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("513300")

        'Now handle the coil
        frmMain.ThisUnitCodes.Add("513399")

        If Not (chkEpoxy.Checked) Then
            'Add the codes for the style of coil *Uncoated*
            If optCoilCustom.Checked Then frmMain.ThisUnitCodes.Add("513309") 'Custom coil
            If optCoil1Row.Checked Then frmMain.ThisUnitCodes.Add("513301") '1 row coil
            If optCoil2Row.Checked Then frmMain.ThisUnitCodes.Add("513306") '2 row coil
        Else
            'Add the codes for the style of coil *Coated*
            If optCoilCustom.Checked Then frmMain.ThisUnitCodes.Add("513315") 'Custom Coated Coil
            If optCoil1Row.Checked Then frmMain.ThisUnitCodes.Add("513307") 'Coated 1 Row Coil
            If optCoil2Row.Checked Then frmMain.ThisUnitCodes.Add("513308") 'Coated 2 Row Coil
        End If

        If chkS40DrawThroughCoil.Checked Then frmMain.ThisUnitCodes.Add("513390") 'Draw through coil Series 40

        'Valves...
        If optValveNone.Checked = False Then
            frmMain.ThisUnitCodes.Add("513302") 'Modulating Hot Water Valve
            'Valves Installed by Fisen
            If optValveFisenProvFisenInst.Checked = True Then
                If optValve2Way.Checked Then
                    frmMain.ThisUnitCodes.Add("513310") '2-Way Fisen Installed
                    frmMain.ThisUnitHydro.Add("Hot Water Coil and 2 Way Valve")
                End If

                If optValve3Way.Checked Then
                    frmMain.ThisUnitCodes.Add("513311") '3-Way Fisen Installed
                    frmMain.ThisUnitHydro.Add("Hot Water Coil and 3 Way Valve")
                End If

            Else
                If optValve2Way.Checked Then
                    frmMain.ThisUnitCodes.Add("513303") '2-Way Field Installed

                End If
                If optValve3Way.Checked Then
                    frmMain.ThisUnitCodes.Add("513304") '3-Way Field Installed

                End If

                frmMain.ThisUnitHydro.Add("Just Hot Water Coil")
            End If
        Else
            If optValveNone.Checked Then
                frmMain.ThisUnitCodes.Add("513330") 'Field provided and field installed valve

            End If
            frmMain.ThisUnitHydro.Add("Just Hot Water Coil")
        End If

        'Handle Freezestats
        frmMain.ThisUnitCodes.Add("513305") 'Low Limit Thermostat

        If optLLUnwired.Checked Then
            If frmMain.ModBarn.UnitHas4StageBoard Then
                frmMain.ThisUnitCodes.Add("513312") 'LLStat Unwired 513312
            Else
                frmMain.ThisUnitCodes.Add("51331A") 'LLStat Unwired 51331A No Stage 4 Board installed.
            End If
        End If
        'LLStat Wired to Controller 513313
        If optLLWired.Checked Then frmMain.ThisUnitCodes.Add("513313")
        'LLStat Breaks the Valve Power 513314
        If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("513314")
        If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("513323")
        If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("513324")
        If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("513325")
        If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("513326")
        If chkBreakonLL.Checked And Not (optValveFisenProvFisenInst.Checked) Then
            frmMain.ThisUnitCodes.Add("513327")
            tbblockadded = True
        End If

        'Handle Controls
        frmMain.ThisUnitCodes.Add("513320")

        'No Controls by Fisen
        If (optValveCtrlNone.Checked) Then
            frmMain.ThisUnitCodes.Add("513328")
            frmMain.ThisUnitCodes.Add("513316")
            If optBU_IPU_Unwired.Checked Then
                frmMain.ThisUnitCodes.Add("513381")

            End If
            If optBU_SE_Fact_Unwired.Checked Then
                frmMain.ThisUnitCodes.Add("513319") 'Fisen Provided SE Board
                frmMain.ThisUnitCodes.Add("513380") 'SE Available for Wiring

            End If
            If optBU_SE_Fisen_Unwired.Checked Then
                frmMain.ThisUnitCodes.Add("513319") 'Fisen Provided SE Board
                frmMain.ThisUnitCodes.Add("513380") 'SE Available for Wiring

            End If
        End If

        'Base Unit Controls the Valve Position
        If optValveCtrlBaseUnit.Checked Then
            If optBU_SE_Fact_FisenWires.Checked Then
                frmMain.ThisUnitCodes.Add("513317") 'Fisen Wired Valve Control
                frmMain.ThisUnitCodes.Add("513398") 'SAT Sensor Relocate

            End If
            If optBU_SE_Fisen_FisenWires.Checked Then
                frmMain.ThisUnitCodes.Add("513317") 'Fisen Wired Valve Control
                frmMain.ThisUnitCodes.Add("513398") 'SAT Sensor Relocate
                frmMain.ThisUnitCodes.Add("513319") 'Fisen Provided SE Board

            End If
            If optBU_IPU_FisenWires.Checked Then
                frmMain.ThisUnitCodes.Add("513329") 'Fisen Wired Valve Control - IPU
                frmMain.ThisUnitCodes.Add("513398") 'SAT Sensor Relocate

            End If
        End If

        'Fisen Controller Handles the Valve Position
        If optValveCtrlFisenCustom.Checked Then

        End If


        'Field wires the valve we need a terminal block.
        If (((optValveFieldProvFieldInst.Checked) Or (optValveFisenProvFieldInst.Checked)) And Not (optValveCtrlNone.Checked)) Then
            If Not (tbblockadded) Then frmMain.ThisUnitCodes.Add("513327")
        End If

        'Fisen adds a 4 stage board
        If ((optBU_SE_Fisen_FisenWires.Checked) Or (optBU_SE_Fisen_Unwired.Checked)) Then
            frmMain.ThisUnitGenCodes.Add("960003")
        End If

        'Handle the hmi
        If chkIncludeEquipmentTouch.Checked = True Then
            HMIAlreadyThere = False
            For iHMI = 0 To frmMain.ThisUnitGenCodes.Count - 1
                If ((frmMain.ThisUnitGenCodes.Item(iHMI) = "960002") Or (frmMain.ThisUnitGenCodes.Item(iHMI) = "960001")) Then HMIAlreadyThere = True
            Next
            If ((chkMountEquipmentTouch.Checked = True) And (HMIAlreadyThere = False)) Then
                If frmMain.ThisUnitGenCodes.Count > 0 Then frmMain.ThisUnitGenCodes.Add("960000")
                frmMain.ThisUnitGenCodes.Add("960002")
            End If
            If ((chkMountEquipmentTouch.Checked = False) And (HMIAlreadyThere = False)) Then
                If frmMain.ThisUnitGenCodes.Count > 0 Then frmMain.ThisUnitGenCodes.Add("960000")
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'handle the commnodes
        If Not (optValveCtrlNone.Checked) Then
            frmMain.ThisUnit.CommNodes = "2"
        End If

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
    End Sub

    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CoilTest = True
        If optValveFisenProvFisenInst.Checked = True Then
            frmMain.ThisUnitWarrTest.HydroPress = True
        End If
        If optValveCtrlBaseUnit.Checked = True Then
            frmMain.ThisUnitWarrTest.CtrlTest = True
        End If
        If optValveCtrlFisenCustom.Checked = True Then
            frmMain.ThisUnitWarrTest.CtrlTest = True
        End If

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim Dummy As MsgBoxResult

        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HWCoil")
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Water Coil")
        tempWeight = "9999"
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If optCoil1Row.Checked = True Then tempWeight = "120"
                If optCoil2Row.Checked = True Then tempWeight = "145"
                If optCoilCustom.Checked = True Then tempWeight = "145"
            Case Is = "Series10"
                If optCoil1Row.Checked = True Then tempWeight = "120"
                If optCoil2Row.Checked = True Then tempWeight = "145"
                If optCoilCustom.Checked = True Then tempWeight = "145"
            Case Is = "Series20"
                If optCoil1Row.Checked = True Then tempWeight = "160"
                If optCoil2Row.Checked = True Then tempWeight = "205"
                If optCoilCustom.Checked = True Then tempWeight = "205"
            Case Is = "Series40"
                If optCoil1Row.Checked = True Then tempWeight = "170"
                If optCoil2Row.Checked = True Then tempWeight = "215"
                If optCoilCustom.Checked = True Then tempWeight = "215"
            Case Else
                tempWeight = "9999"
                Dummy = MsgBox("Error in Weight Selection for HWCoil Module.", vbOKOnly)
        End Select
        If Not (optValveNone.Checked) Then tempWeight = tempWeight + 10
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim tempCS As String
        frmMain.ThisUnitHeatPerf.HeatType = "Hot Water"
        If optValveCtrlFisenCustom.Checked = True Then tempCS = "Modulating"
        If optValveCtrlBaseUnit.Checked = True Then tempCS = "Modulating"
        If optValveCtrlNone.Checked Then tempCS = "Field Provided"


        frmMain.ThisUnitHeatPerf.ControlStyle = tempCS
        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Fluid = cmbFluidList.Text & cmbFluidPer.Text
        frmMain.ThisUnitHeatPerf.FluidFlow = txtFluidFlow.Text
        If optCoilOnly.Checked Then
            frmMain.ThisUnitHeatPerf.CoilAPD = Str(Val(txtAPD.Text) * 1.1)
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtAPD.Text) * 1.1)
        Else
            frmMain.ThisUnitHeatPerf.CoilAPD = txtAPD.Text
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtAPD.Text))
        End If

        frmMain.ThisUnitHeatPerf.EntFluidTemp = txtEFT.Text
        frmMain.ThisUnitHeatPerf.LvgFluidTemp = txtLFT.Text
        frmMain.ThisUnitHydroData.InletSize = txtInletSize.Text
        frmMain.ThisUnitHydroData.OutletSize = txtOutletSize.Text

        If optValveFisenProvFieldInst.Checked Or optValveFisenProvFisenInst.Checked Then
            frmMain.ThisUnitHydroData.HWVPresent = True
            frmMain.ThisUnitHydroData.HWVTag = txtValveTag.Text
            frmMain.ThisUnitHydroData.HWVDescription = cmbValveDesc.Text
            frmMain.ThisUnitHydroData.HWVSize = cmbValveSize.Text
            frmMain.ThisUnitHydroData.HWVType = txtValveType.Text
            frmMain.ThisUnitHydroData.HWVMPN = txtValveMPN.Text
        Else
            frmMain.ThisUnitHydroData.HWVPresent = False
        End If

        If Not (optValveFisenProvFisenInst.Checked) Then
            frmMain.ThisUnitHeatPerf.FluidPressureDrop = txtFPD.Text
        Else
            frmMain.ThisUnitHeatPerf.FluidPressureDrop = Str(Val(txtFPD.Text) + 2.31 * 4)
        End If
    End Sub

    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        cmbFluidList.Items.Add("Water")
        cmbFluidList.Items.Add("Propylene Glycol")
        cmbFluidList.Items.Add("Ethylene Glycol")

        cmbFluidPer.Items.Add("100")
        cmbFluidPer.Items.Add("5")
        cmbFluidPer.Items.Add("10")
        cmbFluidPer.Items.Add("15")
        cmbFluidPer.Items.Add("20")
        cmbFluidPer.Items.Add("25")
        cmbFluidPer.Items.Add("30")
        cmbFluidPer.Items.Add("35")
        cmbFluidPer.Items.Add("40")
        cmbFluidPer.Items.Add("45")
        cmbFluidPer.Items.Add("50")


        txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        If Val(txtHeatAF.Text) <= 0 Then
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtInputCap.Text = frmMain.ThisUnitHeatPerf.InputCapacity
        txtEFT.Text = frmMain.ThisUnitHeatPerf.EntFluidTemp
        If Val(txtEFT.Text) <= 0 Then
            txtEFT.Text = "180.0"
        End If
        txtFluidFlow.Text = frmMain.ThisUnitHeatPerf.FluidFlow
        Select Case Mid(frmMain.ThisUnitHeatPerf.Fluid, 1, 2)
            Case Is = "Wa"
                cmbFluidList.Text = "Water"
            Case Is = "Et"
                cmbFluidList.Text = "Ethylene Glycol"
            Case Is = "Pr"
                cmbFluidList.Text = "Propylene Glycol"
        End Select
        Select Case Mid(frmMain.ThisUnitHeatPerf.Fluid, 3, 2)
            Case Is = "te"
                cmbFluidPer.Text = "100"
            Case Else
                cmbFluidPer.Text = Mid(frmMain.ThisUnitHeatPerf.Fluid, 3, 2)
        End Select

        If ((frmMain.ThisUnit.Family = "Series10") Or (frmMain.ThisUnit.Family = "Series5") Or (InStr(frmMain.ThisUnit.ModelNumber, "ZR") > 0)) Then
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Checked = False
            optBU_IPU_FisenWires.Checked = True
        End If

        cmbValveSize.Text = "-"
        Call PopulateAuxPanelList()

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
                chkS40DrawThroughCoil.Visible = True

            Case Is = "Series100"

            Case Else

        End Select

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
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

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub


    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim FFlow As Double
        Dim ConSize As String

        FFlow = Val(txtFluidFlow.Text)

        Select Case FFlow
            Case Is < 10
                ConSize = "3/4"
            Case 10 To 17.99
                ConSize = "1"
            Case 18 To 26.99
                ConSize = "1-1/4"
            Case 27 To 38.99
                ConSize = "1-1/2"
            Case 39 To 73.99
                ConSize = "2"
            Case 74 To 119.99
                ConSize = "2-1/2"
            Case Else
                ConSize = "-"
        End Select
        txtInletSize.Text = ConSize
        txtOutletSize.Text = ConSize

        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        txtOutCap.Text = txtInputCap.Text
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        If Not (optValveNone.Checked) Then
            Select Case txtOutletSize.Text
                Case Is = "3/4"
                    cmbValveSize.Text = "1/2"
                Case Is = "1"
                    cmbValveSize.Text = "3/4"
                Case Is = "1-1/4"
                    cmbValveSize.Text = "1"
                Case Is = "1-1/2"
                    cmbValveSize.Text = "1-1/4"
                Case Is = "2"
                    cmbValveSize.Text = "1-1/2"
                Case Is = "2-1/2"
                    cmbValveSize.Text = "2"
                Case Else
                    cmbValveSize.Text = txtOutletSize.Text

            End Select

            TabControl1.SelectTab("tpgValves")
        Else
            btnDonePerformance.Enabled = False
            TabControl1.Enabled = False
            btnOK.Enabled = True
        End If
    End Sub


    Private Sub btnDoneValve_Click(sender As Object, e As EventArgs) Handles btnDoneValve.Click
        btnDoneValve.Enabled = False
        TabControl1.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub txtLAT_Leave(sender As Object, e As EventArgs) Handles txtLAT.Leave
        txtDeltaT.Text = Str(Val(txtLAT.Text) - Val(txtEAT.Text))
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        End If
    End Sub

    Private Sub optValveNone_CheckedChanged(sender As Object, e As EventArgs) Handles optValveNone.CheckedChanged
        If optValveNone.Checked = True Then
            optValveFieldProvFieldInst.Enabled = True
            optValveFieldProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = False
            optValveFisenProvFisenInst.Enabled = False
            txtValveTag.Text = "-"
        End If
    End Sub
    Private Sub optValve2Way_CheckedChanged(sender As Object, e As EventArgs) Handles optValve2Way.CheckedChanged
        If optValve2Way.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "HWV-1"
        End If

    End Sub

    Private Sub optValve3Way_CheckedChanged(sender As Object, e As EventArgs) Handles optValve3Way.CheckedChanged
        If optValve3Way.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "HWV-1"
        End If
    End Sub

    Private Sub optValveCtrlBaseUnit_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlBaseUnit.CheckedChanged
        If optValveCtrlBaseUnit.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = True
            optBU_SE_Fisen_FisenWires.Enabled = True
            optBU_IPU_FisenWires.Enabled = True
            optBU_SE_Fact_FisenWires.Checked = True

            optBU_IPU_Unwired.Enabled = False
            optBU_SE_Fact_Unwired.Enabled = False
            optBU_SE_Fisen_Unwired.Enabled = False
            optBU_Other.Enabled = False
            optBU_SE_Fact_Unwired.Checked = False

            cmbValveCtrlFisenCustom.Enabled = False
            cmbValveCtrlFisenCustom.Text = "n/a"

            optLLUnwired.Checked = True
            optLLWired.Enabled = True
            chkBreakonLL.Checked = False
            chkBreakonLL.Enabled = True

        End If
    End Sub

    Private Sub optValveCtrlNone_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlNone.CheckedChanged
        If optValveCtrlNone.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_IPU_FisenWires.Enabled = False
            optBU_IPU_Unwired.Enabled = True
            optBU_SE_Fact_Unwired.Enabled = True
            optBU_SE_Fact_Unwired.Checked = True
            optBU_SE_Fisen_Unwired.Enabled = True
            optBU_Other.Enabled = True
            optBU_Other.Checked = True

            cmbValveCtrlFisenCustom.Enabled = False
            cmbValveCtrlFisenCustom.Text = "n/a"

            optLLUnwired.Enabled = True
            optLLWired.Enabled = False

            chkBreakonLL.Enabled = False
            chkBreakonLL.Checked = False

        End If
    End Sub

    Private Sub optValveCtrlFisenCustom_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlFisenCustom.CheckedChanged
        If optValveCtrlFisenCustom.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_IPU_FisenWires.Enabled = False
            optBU_IPU_Unwired.Enabled = False
            optBU_SE_Fact_Unwired.Enabled = False
            optBU_SE_Fisen_Unwired.Enabled = False
            optBU_Other.Enabled = True
            optBU_Other.Checked = True

            cmbValveCtrlFisenCustom.Enabled = True
            cmbValveCtrlFisenCustom.Text = "Fisen Custom 01"

            optLLWired.Enabled = True
            chkBreakonLL.Enabled = True

        End If
    End Sub

    Private Sub cmbValveSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValveSize.SelectedIndexChanged
        If cmbValveSize.Text <> "-" Then

            Call LoadTheValveList()
        Else
            txtValveTag.Text = "-"
            txtValveType.Text = "-"
            txtValveMPN.Text = "-"

        End If
    End Sub

    Private Sub LoadTheValveList()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        If optValveNone.Checked Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        cmbValveDesc.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        If optValve2Way.Checked Then
            MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='2 Way' AND Size='" & cmbValveSize.Text & "' ORDER BY CV"
        End If
        If optValve3Way.Checked Then
            MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='3 Way' AND Size='" & cmbValveSize.Text & "' ORDER BY CV"
        End If


        rs.Open(MySQL, con)

        i = 0
        rs.MoveFirst()
        Do While Not (rs.EOF)
            cmbValveDesc.Items.Add(rs.Fields("Description").Value)
            rs.MoveNext()
        Loop

        cmbValveDesc.Items.Add("-")
        cmbValveDesc.Text = "-"
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmbValveDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValveDesc.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        If cmbValveDesc.Text = "-" Then
            txtValveType.Text = "-"
            txtValveMPN.Text = "-"
        Else
            con = New ADODB.Connection
            dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
            con.ConnectionString = dbProvider
            con.Open()

            rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

            MySQL = "SELECT * FROM tblHydroHWValves WHERE Description='" & cmbValveDesc.Text & "' ORDER BY CV"

            rs.Open(MySQL, con)

            i = 0
            rs.MoveFirst()
            txtValveType.Text = rs.Fields("Description").Value
            txtValveMPN.Text = rs.Fields("AssemblyPN").Value
            con.Close()

        End If



        rs = Nothing
        con = Nothing
    End Sub

    Private Function SelectAValve(Flow As String, BodySize As String, Style As String) As String
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim SelectedValve As String
        Dim RqdCV As Double
        Dim ValveCV As Double

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='" & Style & "' AND Size='" & BodySize & "' ORDER BY CV"


        RqdCV = Val(Flow) / 2.0

        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            ValveCV = rs.Fields("CV").Value
            If RqdCV <= ValveCV Then
                Exit Do
            Else
                rs.MoveNext()
            End If
        Loop

        SelectedValve = rs.Fields("Description").Value

        con.Close()

        rs = Nothing
        con = Nothing

        Return SelectedValve

    End Function

    Private Sub btnSelectAValve_Click(sender As Object, e As EventArgs) Handles btnSelectAValve.Click
        Dim TwoORThree As String

        If optValve2Way.Checked Then
            TwoORThree = "2 Way"
        Else
            TwoORThree = "3 Way"
        End If
        cmbValveDesc.Text = SelectAValve(txtFluidFlow.Text, cmbValveSize.Text, TwoORThree)
    End Sub

    Private Sub cmbFluidList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFluidList.SelectedIndexChanged
        If cmbFluidList.Text = "Water" Then
            cmbFluidPer.Text = "100"
        End If
    End Sub

    Private Sub optLLUnwired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLUnwired.CheckedChanged
        If optLLUnwired.Checked Then
            chkBreakonLL.Checked = False
            chkBreakonLL.Enabled = False
        End If
    End Sub

    Private Sub optLLWired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLWired.CheckedChanged
        If optLLWired.Checked Then
            chkBreakonLL.Enabled = True
            chkBreakonLL.Checked = True
        End If
    End Sub

    Private Sub WriteHWCoilHistory()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        Dim HeatAirflow, EAT, EFT, Flow, Fluid, Percent, LAT, LFT, CoilAPD, FPD, Capacity As String


        Dim MySQL As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text
        modnum = frmMain.txtModelNumber.Text

        HeatAirflow = txtHeatAF.Text
        EAT = txtEAT.Text
        EFT = txtEFT.Text
        Flow = txtFluidFlow.Text
        Fluid = cmbFluidList.Text
        Percent = cmbFluidPer.Text
        LAT = txtLAT.Text
        LFT = txtLFT.Text
        CoilAPD = txtActualAPD.Text
        FPD = txtFPD.Text
        Capacity = txtOutCap.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "INSERT INTO tblHistoryHWCoil (JobName, UnitID, Version, ModelNumber, HeatAirflow, EAT, EFT, Flow, Fluid, FPercent, LAT, LFT, CoilAPD, FPD, Capacity) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & HeatAirflow & "','" & EAT & "','" & EFT & "','" & Flow & "','" & Fluid & "','" & Percent & "','" & LAT & "','" & LFT & "','" & CoilAPD & "','" & FPD & "','" & Capacity & "')"

        con.Execute(MySQL)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

End Class