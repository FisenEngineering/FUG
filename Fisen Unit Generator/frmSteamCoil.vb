Imports System.ComponentModel
Public Class frmSteamCoil
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
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("SteamCoil")
        Call UpdateCodeList()
        Me.Hide()
    End Sub

    Private Sub UpdateCodeList()
        Dim iHMI As Integer
        Dim HMIAlreadyThere As Boolean

        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("524600")

        'Now Handle the coil
        frmMain.ThisUnitCodes.Add("524699") 'Steam Coil Details

        If Not (chkEpoxy.Checked) Then
            'Add the codes for the style of coil *Uncoated*
            If optCoilCustom.Checked Then frmMain.ThisUnitCodes.Add("524603") 'Custom coil
            If optCoil1Row.Checked Then frmMain.ThisUnitCodes.Add("524601") '1 row coil
            If optCoil2Row.Checked Then frmMain.ThisUnitCodes.Add("524602") '2 row coil
        Else
            'add the code for epoxy coating is applicable
            If optCoilCustom.Checked Then frmMain.ThisUnitCodes.Add("524632") 'Custom Coated Coil
            If optCoil1Row.Checked Then frmMain.ThisUnitCodes.Add("524630") 'Coated 1 Row Coil
            If optCoil2Row.Checked Then frmMain.ThisUnitCodes.Add("524631") 'Coated 2 Row Coil
        End If

        If chkS40DrawThroughCoil.Checked Then frmMain.ThisUnitCodes.Add("524640") 'Draw through coil Series 40

        'Handle coil location if this is a DS unit
        If frmMain.ThisUnit.Family = "DS" Then
            If optDSFanInlet.Checked Then
                frmMain.ThisUnitCodes.Add("524606") ' Located at the fan inlet
            Else
                frmMain.ThisUnitCodes.Add("524605") 'Located at the fan outlet
            End If
        End If

        '***********************************************************
        'Valves...
        frmMain.ThisUnitCodes.Add("524680") 'Steam Valve Details Level 1

        If optValveNone.Checked = False Then
            frmMain.ThisUnitCodes.Add("524681") 'No Steam Valve
            frmMain.ThisUnitHydro.Add("Just Steam Coil")
        Else
            If optValveFisenProvFisenInst.Checked Then
                If optValveOnOff.Checked Then
                    frmMain.ThisUnitCodes.Add("524684") 'Fisen Provided and installed
                    frmMain.ThisUnitHydro.Add("Just Steam Coil and On Off")
                End If
                If optValveModulating.Checked Then
                    frmMain.ThisUnitCodes.Add("524685") 'Fisen Provided and installed Modulating
                    frmMain.ThisUnitHydro.Add("Just Steam Coil and Modulating")
                End If
            End If
            If optValveFisenProvFieldInst.Checked Then
                If optValveOnOff.Checked Then
                    frmMain.ThisUnitCodes.Add("524682") 'Fisen Provided and field installed
                    frmMain.ThisUnitHydro.Add("Steam Coil and Field Installed On/Off")
                End If
                If optValveModulating.Checked Then
                    frmMain.ThisUnitCodes.Add("524683") 'Fisen Provided and field installed
                    frmMain.ThisUnitHydro.Add("Steam Coil and Field Installed Modulating")
                End If
            End If
            If optValveFieldProvFieldInst.Checked Then
                If optValveOnOff.Checked Then
                    frmMain.ThisUnitCodes.Add("524686") 'Field Provided and field installed
                    frmMain.ThisUnitHydro.Add("Steam Coil and Field Installed/Provided On/Off")
                End If
                If optValveModulating.Checked Then
                    frmMain.ThisUnitCodes.Add("524687") 'Field Provided and field installed
                    frmMain.ThisUnitHydro.Add("Steam Coil and Field Installed/Provided Modulating")
                End If
            End If
        End If


        'Handle Freeze Stats
        frmMain.ThisUnitCodes.Add("524620") 'Low Limit Thermostat

        'LLStat Unwired
        If optLLUnwired.Checked Then frmMain.ThisUnitCodes.Add("524621")

        'LLStat Wired to Controller
        If ((optLLWired.Checked) And (optValveCtrlBaseUnit.Checked)) Then
            frmMain.ThisUnitCodes.Add("524622")
            If chkBreakonLL.Checked Then
                frmMain.ThisUnitCodes.Add("524623") 'Wired to Fisen Controller
            End If
        End If
        If ((optLLWired.Checked) And (optValveCtrlFisenCustom.Checked)) Then frmMain.ThisUnitCodes.Add("524623")


        'LLStat Breaks the Valve Power
        If chkBreakonLL.Checked Then
            frmMain.ThisUnitCodes.Add("524624")
            frmMain.ThisUnitCodes.Add("524625")
            frmMain.ThisUnitCodes.Add("524626")
            frmMain.ThisUnitCodes.Add("524627")
        End If

        'Handle the terminal strip!
        'If chkBreakonLL.Checked And Not (optValveFisen.Checked) Then frmMain.ThisUnitCodes.Add("524647")

        'Handle Controls
        frmMain.ThisUnitCodes.Add("524640") 'Steam Coil Controls

        'no controls by fisen
        If optValveCtrlNone.Checked Then
            frmMain.ThisUnitCodes.Add("524641") 'No Steam Valve Controls

        End If
        'the base unit controller handles the controls
        If optValveCtrlBaseUnit.Checked Then
            If optBU_SE_Fact_Unwired.Checked Then

            End If

            If optBU_SE_Fisen_Unwired.Checked Then

            End If

            If optBU_SE_Fact_FisenWires.Checked Then
                frmMain.ThisUnitCodes.Add("524645") 'Fisen Wired Valve Control
                frmMain.ThisUnitCodes.Add("524642") 'SAT Sensor Relocate
                If Not (optValveFisenProvFisenInst.Checked) Then frmMain.ThisUnitCodes.Add("524660") 'Terminal Strip
                If chkBreakonLL.Checked Then frmMain.ThisUnitCodes.Add("524643") 'Freeze Avoidance
            End If

                If optBU_SE_Fisen_FisenWires.Checked Then

            End If

            If optBU_IPU_Unwired.Checked Then

            End If

            If optBU_IPU_FisenWires.Checked Then


            End If

        End If

        'special fisen controls
        If optValveCtrlFisenCustom.Checked Then


        End If


        frmMain.ThisUnit.CommNodes = "2"

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
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim Dummy As MsgBoxResult

        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("SteamCoil")
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Steam Coil")
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
            Case Is = "Select"
                If optCoil1Row.Checked = True Then tempWeight = "170"
                If optCoil2Row.Checked = True Then tempWeight = "215"
                If optCoilCustom.Checked = True Then tempWeight = "215"
            Case Else
                tempWeight = "9999"
                Dummy = MsgBox("Error in Weight Selection for Steam Module.", vbOKOnly)
        End Select
        If Not (optValveNone.Checked) Then tempWeight = tempWeight + 10
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CoilTest = True
        If Not (optValveNone.Checked = True) Then
            frmMain.ThisUnitWarrTest.HydroPress = True
        End If
        If Not (optValveNone.Checked = True) Then
            frmMain.ThisUnitWarrTest.CtrlTest = True
        End If
    End Sub
    Private Sub UpdatePerformance()
        Dim tempCS As String
        frmMain.ThisUnitHeatPerf.HeatType = "Steam"
        tempCS = "Unknown"

        If optValveOnOff.Checked = True Then tempCS = "Staged"
        If optValveModulating.Checked = True Then tempCS = "Modulating"
        If optValveNone.Checked Then tempCS = "Field Provided"

        frmMain.ThisUnitHeatPerf.ControlStyle = tempCS
        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutputCap.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = " "
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.CoilAPD = Str(Val(txtCoilAPD.Text) * 1.1)
        frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtCoilAPD.Text))
        frmMain.ThisUnitHeatPerf.SteamPressure = txtSteamPressure.Text
        frmMain.ThisUnitHeatPerf.CondensateFlow = txtCondFlow.Text

        If optCoilOnly.Checked Then
            frmMain.ThisUnitHeatPerf.CoilAPD = Str(Val(txtCoilAPD.Text) * 1.1)
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtCoilAPD.Text) * 1.1)
        Else
            frmMain.ThisUnitHeatPerf.CoilAPD = txtCoilAPD.Text
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtCoilAPD.Text))
        End If

        frmMain.ThisUnitHydroData.InletSize = txtInletSize.Text
        frmMain.ThisUnitHydroData.OutletSize = txtOutletSize.Text

        If Not (optValveNone.Checked = True) Then
            frmMain.ThisUnitHydroData.HWVPresent = True
            frmMain.ThisUnitHydroData.HWVTag = txtValveTag.Text
            frmMain.ThisUnitHydroData.HWVDescription = cmbValveDesc.Text
            frmMain.ThisUnitHydroData.HWVSize = cmbValveSize.Text
            frmMain.ThisUnitHydroData.HWVType = txtValveType.Text
            frmMain.ThisUnitHydroData.HWVMPN = txtValveMPN.Text
        Else
            frmMain.ThisUnitHydroData.HWVPresent = False
        End If

    End Sub
    Private Sub frmSteamCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False



        If frmMain.ThisUnit.Family <> "DS" Then TabControl1.TabPages.Remove(TabControl1.TabPages("pgDSOptions"))

        txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        If Val(txtHeatAF.Text) <= 0 Then
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If

        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtOutputCap.Text = frmMain.ThisUnitHeatPerf.OutputCapacity
        txtSteamPressure.Text = frmMain.ThisUnitHeatPerf.SteamPressure

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

    Private Sub optLLUnwired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLUnwired.CheckedChanged
        If optLLUnwired.Checked = True Then
            chkBreakonLL.Checked = False
            chkBreakonLL.Enabled = False
        End If
    End Sub

    Private Sub optLLWired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLWired.CheckedChanged
        If optLLWired.Checked = True Then
            chkBreakonLL.Checked = True
            chkBreakonLL.Enabled = True
        End If

    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim valid As Boolean
        Dim dummy As MsgBoxResult

        valid = True

        If Not (IsNumeric(txtHeatAF.Text)) Then valid = False
        If Not (IsNumeric(txtEAT.Text)) Then valid = False
        If Not (IsNumeric(txtOutputCap.Text)) Then valid = False
        If Not (IsNumeric(txtSteamPressure.Text)) Then valid = False

        If valid Then
            TabControl1.SelectTab("pgOptions")
        Else
            dummy = MsgBox("One of your conditions is not a number.  Please correct.")
        End If
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        Select Case frmMain.ThisUnit.Family
            Case Is = "DS"
                TabControl1.SelectTab("pgDSOptions")
            Case Else
                TabControl1.SelectTab("pgControls")
        End Select

    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim valid As Boolean
        Dim dummy As MsgBoxResult

        valid = True


        If valid Then
            TabControl1.SelectTab("pgPerf")
        Else
            dummy = MsgBox("You must select a base unit controler before continuing.")
        End If
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        Dim valid As Boolean
        Dim dummy As MsgBoxResult

        valid = True

        If Not (IsNumeric(txtLAT.Text)) Then valid = False
        If Not (IsNumeric(txtDeltaT.Text)) Then valid = False
        If Not (IsNumeric(txtCondFlow.Text)) Then valid = False
        If Not (IsNumeric(txtCoilAPD.Text)) Then valid = False

        If valid Then
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

                'Temporary
                cmbValveDesc.Items.Add("Steam Valve, HTCCV, 2 Way 7.31 Cv")
                txtValveType.Text = "NPT Steam High Temp Ball Valve"
                txtValveMPN.Text = "B220HT731+LF24-MFT US"
                TabControl1.SelectTab("tpgValves")
            Else
                btnDonePerf.Enabled = False
                TabControl1.Enabled = False
                btnOK.Enabled = True
            End If
        Else
            dummy = MsgBox("One of your conditions is not a number.  Please correct.")
        End If
    End Sub

    Private Sub btnDoneDSOptions_Click(sender As Object, e As EventArgs) Handles btnDoneDSOptions.Click
        TabControl1.SelectTab("pgControls")
    End Sub

    Private Sub txtLAT_Leave(sender As Object, e As EventArgs) Handles txtLAT.Leave
        txtDeltaT.Text = Str(Val(txtLAT.Text) - Val(txtEAT.Text))
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Checked = False
        End If
    End Sub

    Private Sub btnDoneValve_Click(sender As Object, e As EventArgs) Handles btnDoneValve.Click
        btnDoneValve.Enabled = False
        TabControl1.Enabled = False
        btnOK.Enabled = True
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

    Private Sub optValveOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles optValveOnOff.CheckedChanged
        If optValveOnOff.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "STMV-1"
        End If
    End Sub

    Private Sub optValveModulating_CheckedChanged(sender As Object, e As EventArgs) Handles optValveModulating.CheckedChanged
        If optValveOnOff.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "STMV-1"
        End If
    End Sub
End Class