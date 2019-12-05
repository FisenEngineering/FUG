Imports System.Drawing.Imaging
Public Class frmERW
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList

    Dim AirflowDesc(36) As String
    Dim AirflowPath(36) As String

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub optCSWheel_CheckedChanged(sender As Object, e As EventArgs) Handles optCSWheel.CheckedChanged
        Call UpdateERWElectrical()
        If optVSWheel.Checked = True Then
            chkERWVFDbyFisen.Enabled = True
            chkERWVFDbyFisen.Checked = True
            chkERWBypassSwitch.Enabled = True
            chkERWBypassSwitch.Checked = False
        Else
            chkERWVFDbyFisen.Enabled = False
            chkERWVFDbyFisen.Checked = False
            chkERWBypassSwitch.Enabled = False
            chkERWBypassSwitch.Checked = False
        End If
    End Sub

    Private Sub pgConditions_Click(sender As Object, e As EventArgs) Handles pgConditions.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("ERW") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Me.Hide()
    End Sub

    Private Sub UpdatePerformance()
        frmMain.ThisUnitERWPerf.ERW_ModelNumber = cmbWheel.Text
        Call UpdateWheelStaticTable()
        Call UpdateSummer1ConditionTable()
        Call UpdateSummer2ConditionTable()
        Call UpdateWinter1ConditionTable()
        Call UpdateWinter2ConditionTable()
        Call UpdateWinterFFConditionTable()
        Call UpdateSummer1PerfTable()
        Call UpdateSummer2PerfTable()
        Call UpdateWinter1PerfTable()
        Call UpdateWinter2PerfTable()
        Call UpdateWinterFFPerfTable()
        Call UpdateSummer1MixPerfTable()
        Call UpdateSummer2MixPerfTable()
        Call UpdateWinter1MixPerfTable()
        Call UpdateWinter2MixPerfTable()
        Call UpdateWinterFFMixPerfTable()

    End Sub
    Private Sub UpdateWeightTable()

    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.AirflowTest = True
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code(s)
        ModuleCodeList.Add("E10000") 'Energy Recovery Wheel
        If optAlWheel.Checked Then
            ModuleCodeList.Add("E10100") 'Aluminum Wheel
        End If
        If optPlasticWheel.Checked Then
            ModuleCodeList.Add("E10110") 'Polymer Wheel
        End If

        'handle constant or variable speed wheel
        If optVSWheel.Checked = True Then
            ModuleCodeList.Add("E10155")
            If chkERWVFDbyFisen.Checked Then
                ModuleCodeList.Add("E10160")
                If chkERWBypassSwitch.Checked Then
                    ModuleCodeList.Add("E10162")
                End If
            Else
                ModuleCodeList.Add("E10161")
            End If
        Else
            ModuleCodeList.Add("E10150")
        End If

        'handle full flow wheel or partial flow wheel
        If optFullFlow.Checked Then
            ModuleCodeList.Add("E10180")

        Else 'It's a partial flow wheel.
            ModuleCodeList.Add("E10185")

        End If

        'Handle the Codes for the OA Subsystem
        'Hoods
        If optOAHoodReuseJCI.Checked Then
            ModuleCodeList.Add("E10201")
            If chkOAHoodMetalFilters.Checked Then
                ModuleCodeList.Add("E10221")
            End If
        Else
            ModuleCodeList.Add("E10202")
            If chkOAHoodMetalFilters.Checked Then
                ModuleCodeList.Add("E10222")
            End If
        End If
        If chkOAHoodFieldInstalled.Checked Then
            ModuleCodeList.Add("E10248")
        End If

        'OA Dampers
        If optOADamperByFisen.Checked Then
            ModuleCodeList.Add("E10232")
        End If
        If optOADamperReuseJCI.Checked Then
            ModuleCodeList.Add("E10231")
        End If

        'OA Bypass Dampers
        If chkScopeOABypass.Checked Then
            ModuleCodeList.Add("E10250")
        End If
        If optOABPHoodReuseJCI.Checked Then
            ModuleCodeList.Add("E10251")
            If chkOABPHoodMetalFilters.Checked Then
                ModuleCodeList.Add("E10271")
            End If
        End If
        If optOABPHoodByFisen.Checked Then
            ModuleCodeList.Add("E10252")
            If chkOABPHoodMetalFilters.Checked Then
                ModuleCodeList.Add("E10272")
            End If
        End If
        If chkOABPHoodFieldInstalled.Checked Then
            ModuleCodeList.Add("E10298")
        End If
        If optOABPDampersReuse.Checked Then
            ModuleCodeList.Add("E10281")
        End If
        If optOABPDampersByFisen.Checked Then
            ModuleCodeList.Add("E10282")
        End If

        'Handle the Return Air Bypass Stuffs
        If chkScopeRABypassDampers.Checked Then
            ModuleCodeList.Add("E10300")
        End If
        If optRABPDampersReuse.Checked Then
            ModuleCodeList.Add("E10381")
        End If
        If optRABPDampersByFisen.Checked Then
            ModuleCodeList.Add("E10382")
        End If

        'Handle the Supply Fan/Outdoor Fan Codes
        If optSFanFisen.Checked Then
            ModuleCodeList.Add("E10920")
        End If
        If optSFanOAFan.Checked Then
            ModuleCodeList.Add("E10921")
        End If

        'Handle the Codes for the Exhaust Air System
        If chkScopeXABypassDampers.Checked Then
            ModuleCodeList.Add("E10400")
        End If
        If optXABPHoodReuseJCI.Checked Then
            ModuleCodeList.Add("E10401")
            If chkXABPHoodMesh.Checked Then
                ModuleCodeList.Add("E10421")
            End If
        Else
            ModuleCodeList.Add("E10402")
            If chkXABPHoodMesh.Checked Then
                ModuleCodeList.Add("E10421")
            End If
        End If
        If chkXABPHoodFieldInstalled.Checked Then
            ModuleCodeList.Add("E10448")
        End If

        If optXABPDamperWheel.Checked Then
            ModuleCodeList.Add("E10431")
        End If
        If optXABPDamperAtmosphere.Checked Then
            ModuleCodeList.Add("E10432")
        End If

        'Handle the Exhaust Air Fan
        If optXFanByFisen.Checked Then
            ModuleCodeList.Add("E10930")
        End If
        If optRFanByFisen.Checked Then
            ModuleCodeList.Add("E10931")
        End If

        'Handle the Relief Damper Codes
        If optReliefDamperActuated.Checked Then
            ModuleCodeList.Add("E10470")
        End If
        If optReliefDamperBarometric.Checked Then
            ModuleCodeList.Add("E10471")
        End If
        If optReliefDamperNone.Checked Then
            ModuleCodeList.Add("E10472")
        End If

        'Handle the Filtration Codes
        If (chkFiltrationOAMetal.Checked) Or (chkFiltrationOAMERV8.Checked) Or (chkFiltrationRAMERV8.Checked) Then
            ModuleCodeList.Add("E10600")
        End If

        If chkFiltrationOAMERV8.Checked Then
            ModuleCodeList.Add("E106610")
            If chkFiltrationOAAngledRack.Checked Then
                ModuleCodeList.Add("E10612")
            Else
                ModuleCodeList.Add("E10611")
            End If
        End If

        If chkFiltrationRAMERV8.Checked Then
            ModuleCodeList.Add("E106630")
            If chkFiltrationRAAngledRack.Checked Then
                ModuleCodeList.Add("E10632")
            Else
                ModuleCodeList.Add("E10631")
            End If
        End If

        'Power Connections
        If optSinglePointPower.Checked Then
            ModuleCodeList.Add("E10999")
        Else
            ModuleCodeList.Add("E10998")
        End If

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

    End Sub
    Private Sub FillWheelSelectionList(WhlMaterial As String)

        cmbWheel.Items.Clear()
        cmbWheel.Items.Add("Unselected")
        If WhlMaterial = "Aluminum" Then
            If frmMain.ThisUnit.Cabinet = "S100A" Then
                cmbWheel.Items.Add("TA3C-54-100")
                cmbWheel.Items.Add("TA3C-60-200")
                cmbWheel.Items.Add("TA3C-66-200")
            End If
            If frmMain.ThisUnit.Cabinet = "S100B" Then
                cmbWheel.Items.Add("TA3C-54-100")
                cmbWheel.Items.Add("TA3C-60-200")
                cmbWheel.Items.Add("TA3C-66-200")
            End If
            If frmMain.ThisUnit.Cabinet = "S100C" Then
                cmbWheel.Items.Add("TA3C-54-100")
                cmbWheel.Items.Add("TA3C-60-200")
                cmbWheel.Items.Add("TA3C-66-200")
            End If
        End If

            If WhlMaterial = "Plastic" Then

            cmbWheel.Items.Add("ERC-52-1.5")
            cmbWheel.Items.Add("ERC-52-3.0")
            cmbWheel.Items.Add("ERC-58-1.5")
            cmbWheel.Items.Add("ERC-58-3.0")
            cmbWheel.Items.Add("TBD")
        End If

        cmbWheel.Text = "Unselected"
    End Sub
    Private Sub FillCabinetExtensionList()
        cmbExtensionList.Items.Clear()
        If frmMain.ThisUnit.Cabinet = "S100A" Then
            cmbExtensionList.Items.Add("48 inch Series 100A")
            cmbExtensionList.Items.Add("60 inch Series 100A")
        End If

        If frmMain.ThisUnit.Cabinet = "S100B" Then
            cmbExtensionList.Items.Add("48 inch Series 100B")
            cmbExtensionList.Items.Add("60 inch Series 100B")
        End If

        If frmMain.ThisUnit.Cabinet = "S100C" Then
            cmbExtensionList.Items.Add("48 inch Series 100C")
            cmbExtensionList.Items.Add("60 inch Series 100C")
        End If
        cmbExtensionList.Items.Add("Custom")
        cmbExtensionList.Items.Add("N/A")

        cmbExtensionList.Text = "Custom"

    End Sub

    Private Sub frmERW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillWheelSelectionList("Aluminum")
        Call FillCabinetExtensionList()
        lblUnitVolts.Text = "Unit Voltage:" & frmMain.ThisUnitElecData.CommVolts
        lblUnitSeries.Text = "Unit Series:" & frmMain.ThisUnit.Family
        lblUnitCabinet.Text = "Unit Cabinet:" & frmMain.ThisUnit.Cabinet

    End Sub

    Private Sub optAlWheel_CheckedChanged(sender As Object, e As EventArgs) Handles optAlWheel.CheckedChanged
        If optAlWheel.Checked = True Then
            Call FillWheelSelectionList("Aluminum")
        End If
        If optPlasticWheel.Checked = True Then
            Call FillWheelSelectionList("Plastic")
        End If
    End Sub

    Private Sub UpdateERWElectrical()
        Dim motorhp As String
        Dim vfdhp As String

        vfdhp = "0"
        motorhp = "0"

        Select Case cmbWheel.Text
            Case Is = "TA3C-54-100"
                Select Case frmMain.ThisUnitElecData.CommVolts
                    Case Is = "208"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "230"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "460"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "575"
                        vfdhp = "1.5"
                        motorhp = "0.15"
                    Case Else
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                End Select

            Case Is = "TA3C-60-200"
                Select Case frmMain.ThisUnitElecData.CommVolts
                    Case Is = "208"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "230"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "460"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "575"
                        vfdhp = "1.5"
                        motorhp = "1/2"
                    Case Else
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                End Select
            Case Is = "TA3C-66-200"
                Select Case frmMain.ThisUnitElecData.CommVolts
                    Case Is = "208"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "230"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "460"
                        vfdhp = "1/2"
                        motorhp = "1/2"
                    Case Is = "575"
                        vfdhp = "1.5"
                        motorhp = "1/2"
                    Case Else
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                End Select
            Case Is = "ERC-52-1.5"
                Select Case frmMain.ThisUnitElecData.CommVolts
                    Case Is = "208"
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                    Case Is = "230"
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                    Case Is = "460"
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                    Case Is = "575"
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                    Case Else
                        vfdhp = "***Error***"
                        motorhp = "***Error***"
                End Select
            Case Is = "ERC-52-3.0"
                vfdhp = "***Error***"
                motorhp = "***Error***"
            Case Is = "ERC-58-1.5"
                vfdhp = "***Error***"
                motorhp = "***Error***"
            Case Is = "ERC-58-3.0"
                vfdhp = "***Error***"
                motorhp = "***Error***"
            Case Else
                vfdhp = "***Error***"
                motorhp = "***Error***"
        End Select




        txtERWElectricalInfo.Text = motorhp & " hp motor at " & frmMain.ThisUnitElecData.CommVolts & " Volts"
        If optVSWheel.Checked Then
            txtERWElectricalInfo.Text = txtERWElectricalInfo.Text & " with " & vfdhp & " hp VFD"
        End If
    End Sub
    Private Sub btnDoneProposal_Click(sender As Object, e As EventArgs) Handles btnDoneProposal.Click
        Call UpdateERWElectrical()
        tbcERW.SelectTab("pgConditions")
    End Sub

    Private Sub cmbWheel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWheel.SelectedIndexChanged
        Call UpdateERWElectrical()
    End Sub

    Private Sub chkScopeOABypass_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeOABypass.CheckedChanged
        If chkScopeOABypass.Checked Then
            grpOABPHoods.Enabled = True
            grpOABPDampers.Enabled = True
            optOABPDampersByFisen.Checked = True
            optOABPDampersNone.Enabled = False
            optOABPHoodNone.Enabled = False
            optOABPHoodReuseJCI.Checked = True
        Else
            grpOABPHoods.Enabled = False
            optOABPHoodNone.Checked = True
            chkOABPHoodMetalFilters.Checked = False
            chkOABPHoodFieldInstalled.Checked = False
            grpOABPDampers.Enabled = False
            optOABPDampersNone.Checked = True
            optOABPDampersNone.Enabled = True
        End If
    End Sub

    Private Sub chkScopeRABypassDampers_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeRABypassDampers.CheckedChanged
        If chkScopeRABypassDampers.Checked Then
            grpRABPDampers.Enabled = True
            optRABPDampersReuse.Checked = True
            optRABPDampersNone.Enabled = False
        Else
            grpRABPDampers.Enabled = False
            optRABPDampersNone.Checked = True
            optRABPDampersNone.Enabled = True
        End If
    End Sub

    Private Sub chkOAHoodMetalFilters_CheckedChanged(sender As Object, e As EventArgs) Handles chkOAHoodMetalFilters.CheckedChanged
        If chkOAHoodMetalFilters.Checked Then
            chkFiltrationOAMetal.Checked = True
        Else
            chkFiltrationOAMetal.Checked = False
        End If
    End Sub

    Private Sub chkFiltrationOAMERV8_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrationOAMERV8.CheckedChanged
        If chkFiltrationOAMERV8.Checked Then
            chkFiltrationOAAngledRack.Enabled = True
        Else
            chkFiltrationOAAngledRack.Enabled = False
            chkFiltrationOAAngledRack.Checked = False
        End If
    End Sub

    Private Sub chkFiltrationRAMERV8_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrationRAMERV8.CheckedChanged
        If chkFiltrationRAMERV8.Checked Then
            chkFiltrationRAAngledRack.Enabled = True
        Else
            chkFiltrationRAAngledRack.Enabled = False
            chkFiltrationRAAngledRack.Checked = False
        End If
    End Sub

    Private Sub optCabinetInCab_CheckedChanged(sender As Object, e As EventArgs) Handles optCabinetInCab.CheckedChanged
        If optCabinetInCab.Checked = True Then
            cmbExtensionList.Text = "N/A"
            cmbExtensionList.Enabled = False
        Else
            cmbExtensionList.Text = "Custom"
            cmbExtensionList.Enabled = True
        End If
    End Sub





    Private Sub chkEnaAltCond_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnaAltCond.CheckedChanged
        If chkEnaAltCond.Checked = True Then
            txtCondS2SAFlow.Enabled = True
            txtCondS2OAFlow.Enabled = True
            txtCondS2OAdb.Enabled = True
            txtCondS2OAwb.Enabled = True
            txtCondS2RAFlow.Enabled = True
            txtCondS2RAdb.Enabled = True
            txtCondS2RAwb.Enabled = True
            txtCondW2SAFlow.Enabled = True
            txtCondW2OAFlow.Enabled = True
            txtCondW2OAdb.Enabled = True
            txtCondW2OAwb.Enabled = True
            txtCondW2RAFlow.Enabled = True
            txtCondW2RAdb.Enabled = True
            txtCondW2RAwb.Enabled = True
            txtPerfS2SAFlow.Enabled = True
            txtPerfS2SAdb.Enabled = True
            txtPerfS2SAwb.Enabled = True
            txtPerfS2XAdb.Enabled = True
            txtPerfS2XAwb.Enabled = True
            txtPerfS2XAFlow.Enabled = True
            txtPerfS2SensEff.Enabled = True
            txtPerfS2LatEff.Enabled = True
            txtPerfS2TotEff.Enabled = True
            txtPerfW2SAFlow.Enabled = True
            txtPerfW2SAdb.Enabled = True
            txtPerfW2SAwb.Enabled = True
            txtPerfW2XAdb.Enabled = True
            txtPerfW2XAwb.Enabled = True
            txtPerfW2XAFlow.Enabled = True
            txtPerfW2SensEff.Enabled = True
            txtPerfW2LatEff.Enabled = True
            txtPerfW2TotEff.Enabled = True

            txtMixPerfS2WLFlow.Enabled = True
            txtMixPerfS2WLdb.Enabled = True
            txtMixPerfS2WLwb.Enabled = True
            txtMixPerfS2RAFlow.Enabled = True
            txtMixPerfS2RAdb.Enabled = True
            txtMixPerfS2RAwb.Enabled = True
            txtMixPerfS2MixFlow.Enabled = True
            txtMixPerfS2MAdb.Enabled = True
            txtMixPerfS2MAwb.Enabled = True
            txtMixPerfW2WLFlow.Enabled = True
            txtMixPerfW2WLdb.Enabled = True
            txtMixPerfW2WLwb.Enabled = True
            txtMixPerfW2RAFlow.Enabled = True
            txtMixPerfW2RAdb.Enabled = True
            txtMixPerfW2RAwb.Enabled = True
            txtMixPerfW2MixFlow.Enabled = True
            txtMixPerfW2MAdb.Enabled = True
            txtMixPerfW2MAwb.Enabled = True






        Else
            txtCondS2SAFlow.Enabled = False
            txtCondS2OAFlow.Enabled = False
            txtCondS2OAdb.Enabled = False
            txtCondS2OAwb.Enabled = False
            txtCondS2RAFlow.Enabled = False
            txtCondS2RAdb.Enabled = False
            txtCondS2RAwb.Enabled = False
            txtCondW2SAFlow.Enabled = False
            txtCondW2OAFlow.Enabled = False
            txtCondW2OAdb.Enabled = False
            txtCondW2OAwb.Enabled = False
            txtCondW2RAFlow.Enabled = False
            txtCondW2RAdb.Enabled = False
            txtCondW2RAwb.Enabled = False

            txtPerfS2SAFlow.Enabled = False
            txtPerfS2SAdb.Enabled = False
            txtPerfS2SAwb.Enabled = False
            txtPerfS2XAdb.Enabled = False
            txtPerfS2XAwb.Enabled = False
            txtPerfS2XAFlow.Enabled = False
            txtPerfS2SensEff.Enabled = False
            txtPerfS2LatEff.Enabled = False
            txtPerfS2TotEff.Enabled = False
            txtPerfW2SAFlow.Enabled = False
            txtPerfW2SAdb.Enabled = False
            txtPerfW2SAwb.Enabled = False
            txtPerfW2XAdb.Enabled = False
            txtPerfW2XAwb.Enabled = False
            txtPerfW2XAFlow.Enabled = False
            txtPerfW2SensEff.Enabled = False
            txtPerfW2LatEff.Enabled = False
            txtPerfW2TotEff.Enabled = False

            txtMixPerfS2WLFlow.Enabled = False
            txtMixPerfS2WLdb.Enabled = False
            txtMixPerfS2WLwb.Enabled = False
            txtMixPerfS2RAFlow.Enabled = False
            txtMixPerfS2RAdb.Enabled = False
            txtMixPerfS2RAwb.Enabled = False
            txtMixPerfS2MixFlow.Enabled = False
            txtMixPerfS2MAdb.Enabled = False
            txtMixPerfS2MAwb.Enabled = False
            txtMixPerfW2WLFlow.Enabled = False
            txtMixPerfW2WLdb.Enabled = False
            txtMixPerfW2WLwb.Enabled = False
            txtMixPerfW2RAFlow.Enabled = False
            txtMixPerfW2RAdb.Enabled = False
            txtMixPerfW2RAwb.Enabled = False
            txtMixPerfW2MixFlow.Enabled = False
            txtMixPerfW2MAdb.Enabled = False
            txtMixPerfW2MAwb.Enabled = False

            txtCondS2SAFlow.Text = "-"
            txtCondS2OAFlow.Text = "-"
            txtCondS2OAdb.Text = "-"
            txtCondS2OAwb.Text = "-"
            txtCondS2RAFlow.Text = "-"
            txtCondS2RAdb.Text = "-"
            txtCondS2RAwb.Text = "-"
            txtCondW2SAFlow.Text = "-"
            txtCondW2OAFlow.Text = "-"
            txtCondW2OAdb.Text = "-"
            txtCondW2OAwb.Text = "-"
            txtCondW2RAFlow.Text = "-"
            txtCondW2RAdb.Text = "-"
            txtCondW2RAwb.Text = "-"

            txtPerfS2SAFlow.Text = "-"
            txtPerfS2SAdb.Text = "-"
            txtPerfS2SAwb.Text = "-"
            txtPerfS2XAdb.Text = "-"
            txtPerfS2XAwb.Text = "-"
            txtPerfS2XAFlow.Text = "-"
            txtPerfS2SensEff.Text = "-"
            txtPerfS2LatEff.Text = "-"
            txtPerfS2TotEff.Text = "-"
            txtPerfW2SAFlow.Text = "-"
            txtPerfW2SAdb.Text = "-"
            txtPerfW2SAwb.Text = "-"
            txtPerfW2XAdb.Text = "-"
            txtPerfW2XAwb.Text = "-"
            txtPerfW2XAFlow.Text = "-"
            txtPerfW2SensEff.Text = "-"
            txtPerfW2LatEff.Text = "-"
            txtPerfW2TotEff.Text = "-"

            txtMixPerfS2WLFlow.Text = "-"
            txtMixPerfS2WLdb.Text = "-"
            txtMixPerfS2WLwb.Text = "-"
            txtMixPerfS2RAFlow.Text = "-"
            txtMixPerfS2RAdb.Text = "-"
            txtMixPerfS2RAwb.Text = "-"
            txtMixPerfS2MixFlow.Text = "-"
            txtMixPerfS2MAdb.Text = "-"
            txtMixPerfS2MAwb.Text = "-"
            txtMixPerfW2WLFlow.Text = "-"
            txtMixPerfW2WLdb.Text = "-"
            txtMixPerfW2WLwb.Text = "-"
            txtMixPerfW2RAFlow.Text = "-"
            txtMixPerfW2RAdb.Text = "-"
            txtMixPerfW2RAwb.Text = "-"
            txtMixPerfW2MixFlow.Text = "-"
            txtMixPerfW2MAdb.Text = "-"
            txtMixPerfW2MAwb.Text = "-"


        End If
    End Sub

    Private Sub chkEnaAntiFrostCond_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnaAntiFrostCond.CheckedChanged
        If chkEnaAntiFrostCond.Checked = True Then
            txtCondWAFSAFlow.Enabled = True
            txtCondWAFOAFlow.Enabled = True
            txtCondWAFOAdb.Enabled = True
            txtCondWAFOAwb.Enabled = True
            txtCondWAFRAFlow.Enabled = True
            txtCondWAFRAdb.Enabled = True
            txtCondWAFRAwb.Enabled = True

            txtPerfWFFSAFlow.Enabled = True
            txtPerfWFFSAdb.Enabled = True
            txtPerfWFFSAwb.Enabled = True
            txtPerfWFFXAdb.Enabled = True
            txtPerfWFFXAwb.Enabled = True
            txtPerfWFFXAFlow.Enabled = True
            txtPerfWFFSensEff.Enabled = True
            txtPerfWFFLatEff.Enabled = True
            txtPerfWFFTotEff.Enabled = True

            txtMixPerfWFFWLFlow.Enabled = True
            txtMixPerfWFFWLdb.Enabled = True
            txtMixPerfWFFWLwb.Enabled = True
            txtMixPerfWFFRAFlow.Enabled = True
            txtMixPerfWFFRAdb.Enabled = True
            txtMixPerfWFFRAwb.Enabled = True
            txtMixPerfWFFMixFlow.Enabled = True
            txtMixPerfWFFMAdb.Enabled = True
            txtMixPerfWFFMAwb.Enabled = True

        Else
            txtCondWAFSAFlow.Enabled = False
            txtCondWAFOAFlow.Enabled = False
            txtCondWAFOAdb.Enabled = False
            txtCondWAFOAwb.Enabled = False
            txtCondWAFRAFlow.Enabled = False
            txtCondWAFRAdb.Enabled = False
            txtCondWAFRAwb.Enabled = False

            txtPerfWFFSAFlow.Enabled = False
            txtPerfWFFSAdb.Enabled = False
            txtPerfWFFSAwb.Enabled = False
            txtPerfWFFXAdb.Enabled = False
            txtPerfWFFXAwb.Enabled = False
            txtPerfWFFXAFlow.Enabled = False
            txtPerfWFFSensEff.Enabled = False
            txtPerfWFFLatEff.Enabled = False
            txtPerfWFFTotEff.Enabled = False

            txtMixPerfWFFWLFlow.Enabled = False
            txtMixPerfWFFWLdb.Enabled = False
            txtMixPerfWFFWLwb.Enabled = False
            txtMixPerfWFFRAFlow.Enabled = False
            txtMixPerfWFFRAdb.Enabled = False
            txtMixPerfWFFRAwb.Enabled = False
            txtMixPerfWFFMixFlow.Enabled = False
            txtMixPerfWFFMAdb.Enabled = False
            txtMixPerfWFFMAwb.Enabled = False

            txtCondWAFSAFlow.Text = "-"
            txtCondWAFOAFlow.Text = "-"
            txtCondWAFOAdb.Text = "-"
            txtCondWAFOAwb.Text = "-"
            txtCondWAFRAFlow.Text = "-"
            txtCondWAFRAdb.Text = "-"
            txtCondWAFRAwb.Text = "-"

            txtPerfWFFSAFlow.Text = "-"
            txtPerfWFFSAdb.Text = "-"
            txtPerfWFFSAwb.Text = "-"
            txtPerfWFFXAdb.Text = "-"
            txtPerfWFFXAwb.Text = "-"
            txtPerfWFFXAFlow.Text = "-"
            txtPerfWFFSensEff.Text = "-"
            txtPerfWFFLatEff.Text = "-"
            txtPerfWFFTotEff.Text = "-"

            txtMixPerfWFFWLFlow.Text = "-"
            txtMixPerfWFFWLdb.Text = "-"
            txtMixPerfWFFWLwb.Text = "-"
            txtMixPerfWFFRAFlow.Text = "-"
            txtMixPerfWFFRAdb.Text = "-"
            txtMixPerfWFFRAwb.Text = "-"
            txtMixPerfWFFMixFlow.Text = "-"
            txtMixPerfWFFMAdb.Text = "-"
            txtMixPerfWFFMAwb.Text = "-"
        End If
    End Sub



    Private Sub chkERWVFDbyFisen_CheckedChanged(sender As Object, e As EventArgs) Handles chkERWVFDbyFisen.CheckedChanged
        If chkERWVFDbyFisen.Checked Then
            chkERWBypassSwitch.Enabled = True
        Else
            chkERWBypassSwitch.Enabled = False
            chkERWBypassSwitch.Checked = False
        End If
    End Sub

    Private Sub cmdDoneConditions_Click(sender As Object, e As EventArgs) Handles cmdDoneConditions.Click
        Dim MaxFreshAir As Double
        Dim MaxExhaustAir As Double

        txtPerfS1SAFlow.Text = txtCondS1SAFlow.Text
        txtPerfS2SAFlow.Text = txtCondS2SAFlow.Text
        txtPerfW1SAFlow.Text = txtCondW1SAFlow.Text
        txtPerfW2SAFlow.Text = txtCondW2SAFlow.Text
        txtPerfWFFSAFlow.Text = txtCondWAFSAFlow.Text

        txtMixPerfS1WLFlow.Text = txtCondS1SAFlow.Text
        txtMixPerfS2WLFlow.Text = txtCondS2SAFlow.Text
        txtMixPerfW1WLFlow.Text = txtCondW1SAFlow.Text
        txtMixPerfW2WLFlow.Text = txtCondW2SAFlow.Text
        txtMixPerfWFFWLFlow.Text = txtCondWAFSAFlow.Text

        txtMixPerfS1RAdb.Text = txtCondS1RAdb.Text
        txtMixPerfS2RAdb.Text = txtCondS2RAdb.Text
        txtMixPerfW1RAdb.Text = txtCondW1RAdb.Text
        txtMixPerfW2RAdb.Text = txtCondW2RAdb.Text
        txtMixPerfWFFRAdb.Text = txtCondWAFRAdb.Text

        txtMixPerfS1RAwb.Text = txtCondS1RAwb.Text
        txtMixPerfS2RAwb.Text = txtCondS2RAwb.Text
        txtMixPerfW1RAwb.Text = txtCondW1RAwb.Text
        txtMixPerfW2RAwb.Text = txtCondW2RAwb.Text
        txtMixPerfWFFRAwb.Text = txtCondWAFRAwb.Text

        MaxFreshAir = Val(txtCondS1OAFlow.Text)
        If IsNumeric(txtCondS2OAFlow.Text) And (Val(txtCondS2OAFlow.Text) > MaxFreshAir) Then MaxFreshAir = Val(txtCondS2OAFlow.Text)
        If IsNumeric(txtCondW1OAFlow.Text) And (Val(txtCondW1OAFlow.Text) > MaxFreshAir) Then MaxFreshAir = Val(txtCondW1OAFlow.Text)
        If IsNumeric(txtCondW2OAFlow.Text) And (Val(txtCondW2OAFlow.Text) > MaxFreshAir) Then MaxFreshAir = Val(txtCondW2OAFlow.Text)
        If IsNumeric(txtCondWAFOAFlow.Text) And (Val(txtCondWAFOAFlow.Text) > MaxFreshAir) Then MaxFreshAir = Val(txtCondWAFOAFlow.Text)
        txtStaticTableFreshAirFlow.Text = Format(MaxFreshAir, "0")

        MaxExhaustAir = Val(txtCondS1RAFlow.Text)
        If IsNumeric(txtCondS2RAFlow.Text) And (Val(txtCondS2RAFlow.Text) > MaxExhaustAir) Then MaxExhaustAir = Val(txtCondS2RAFlow.Text)
        If IsNumeric(txtCondW1RAFlow.Text) And (Val(txtCondW1RAFlow.Text) > MaxExhaustAir) Then MaxExhaustAir = Val(txtCondW1RAFlow.Text)
        If IsNumeric(txtCondW2RAFlow.Text) And (Val(txtCondW2RAFlow.Text) > MaxExhaustAir) Then MaxExhaustAir = Val(txtCondW2RAFlow.Text)
        If IsNumeric(txtCondWAFRAFlow.Text) And (Val(txtCondWAFRAFlow.Text) > MaxExhaustAir) Then MaxExhaustAir = Val(txtCondWAFRAFlow.Text)
        txtStaticTableExhaustAirFlow.Text = Format(MaxExhaustAir, "0")

        Call LoadApplicableAirFlowDrawings()

        tbcERW.SelectTab("pgAirflowDwg")
    End Sub

    Private Sub LoadApplicableAirFlowDrawings()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailAirflow.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblAirflowDiagrams WHERE " & frmMain.ThisUnit.Family & "=True"
        rs.Open(MySQL, con)
        '       If rs.RecordCount > 0 Then
        rs.MoveFirst()
        i = 0
        Do While Not (rs.EOF)
            lstAvailAirflow.Items.Add(rs.Fields("PlainName").Value)
            AirflowDesc(i) = rs.Fields("DrawingDescription").Value
            AirflowPath(i) = My.Settings.ResourceDir & "\AirflowDiagrams" & rs.Fields("DrawingPath").Value & "RR" & rs.Fields("WMFName").Value
            i = i + 1
            rs.MoveNext()
        Loop
        'End If
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub lstAvailAirflow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailAirflow.SelectedIndexChanged
        Dim wmf1 As Metafile


        If lstAvailAirflow.SelectedIndex >= 0 Then
            txtAvailDescription.Text = AirflowDesc(lstAvailAirflow.SelectedIndex)

            wmf1 = Image.FromFile(AirflowPath(lstAvailAirflow.SelectedIndex))

            pboxAirflow.Image = wmf1

        End If
    End Sub

    Private Sub btnDoneAirflowDwg_Click(sender As Object, e As EventArgs) Handles btnDoneAirflowDwg.Click
        If lstAvailAirflow.SelectedIndex >= 0 Then
            frmMain.lstUsingAirflow.Items.Add(lstAvailAirflow.SelectedItem)
        End If

        tbcERW.SelectTab("pgControls")

    End Sub

    Private Sub cmdDonePerformance_Click(sender As Object, e As EventArgs) Handles cmdDonePerformance.Click
        btnOK.Enabled = True
    End Sub



    Private Sub cmdDoneStaticTables_Click(sender As Object, e As EventArgs) Handles cmdDoneStaticTables.Click
        tbcERW.SelectTab("pgPerformance")
    End Sub



    Private Sub txtSFStaticOAHood_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticOAHood.LostFocus
        txtSFStaticOAHood.Text = Format(Val(txtSFStaticOAHood.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtSFStaticMetalFilt_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticMetalFilt.LostFocus
        txtSFStaticMetalFilt.Text = Format(Val(txtSFStaticMetalFilt.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtSFStaticOADamp_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticOADamp.LostFocus
        txtSFStaticOADamp.Text = Format(Val(txtSFStaticOADamp.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtSFStaticOAFilt_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticOAFilt.LostFocus
        txtSFStaticOAFilt.Text = Format(Val(txtSFStaticOAFilt.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtSFStaticERW_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticERW.LostFocus
        txtSFStaticERW.Text = Format(Val(txtSFStaticERW.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtSFStaticTrans_LostFocus(sender As Object, e As EventArgs) Handles txtSFStaticTrans.LostFocus
        txtSFStaticTrans.Text = Format(Val(txtSFStaticTrans.Text), "0.00")
        txtSFStaticCabFX.Text = Format(SFCabFXCalc(), "0.00")
        txtSFStaticTotal.Text = Format(SFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticRAOpening_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticRAOpening.LostFocus
        txtRXFStaticRAOpening.Text = Format(Val(txtRXFStaticRAOpening.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticSafetyGrate_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticSafetyGrate.LostFocus
        txtRXFStaticSafetyGrate.Text = Format(Val(txtRXFStaticSafetyGrate.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticRAFilt_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticRAFilt.LostFocus
        txtRXFStaticRAFilt.Text = Format(Val(txtRXFStaticRAFilt.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticERW_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticERW.LostFocus
        txtRXFStaticERW.Text = Format(Val(txtRXFStaticERW.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticHWCloth_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticHWCloth.LostFocus
        txtRXFStaticHWCloth.Text = Format(Val(txtRXFStaticHWCloth.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticReliefDamp_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticReliefDamp.LostFocus
        txtRXFStaticReliefDamp.Text = Format(Val(txtRXFStaticReliefDamp.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticReliefHood_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticReliefHood.LostFocus
        txtRXFStaticReliefHood.Text = Format(Val(txtRXFStaticReliefHood.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Sub txtRXFStaticTrans_LostFocus(sender As Object, e As EventArgs) Handles txtRXFStaticTrans.LostFocus
        txtRXFStaticTrans.Text = Format(Val(txtRXFStaticTrans.Text), "0.00")
        txtRXFStaticCabFX.Text = Format(RXFCabFXCalc(), "0.00")
        txtRXFStaticTotal.Text = Format(RXFCabTotal(), "0.00")
    End Sub

    Private Function SFCabFXCalc() As Double
        Dim SFSubTotal As Double
        Dim OAHood, MetFilt, OADamp, OAFilt, ERW, Trans As Double
        OAHood = Val(txtSFStaticOAHood.Text)
        MetFilt = Val(txtSFStaticMetalFilt.Text)
        OADamp = Val(txtSFStaticOADamp.Text)
        OAFilt = Val(txtSFStaticOAFilt.Text)
        ERW = Val(txtSFStaticERW.Text)
        Trans = Val(txtSFStaticTrans.Text)
        SFSubTotal = OAHood + MetFilt + OADamp + OAFilt + ERW + Trans
        SFCabFXCalc = 0.1 * SFSubTotal

    End Function

    Private Function SFCabTotal() As Double
        Dim SFSubTotal As Double
        Dim OAHood, MetFilt, OADamp, OAFilt, ERW, Trans, Safety As Double
        OAHood = Val(txtSFStaticOAHood.Text)
        MetFilt = Val(txtSFStaticMetalFilt.Text)
        OADamp = Val(txtSFStaticOADamp.Text)
        OAFilt = Val(txtSFStaticOAFilt.Text)
        ERW = Val(txtSFStaticERW.Text)
        Trans = Val(txtSFStaticTrans.Text)
        Safety = Val(txtSFStaticCabFX.Text)
        SFSubTotal = OAHood + MetFilt + OADamp + OAFilt + ERW + Trans + Safety
        SFCabTotal = SFSubTotal

    End Function

    Private Function RXFCabFXCalc() As Double
        Dim RXFSubTotal As Double
        Dim RAOpening, SafetyGrate, RAFilt, ERW, HWCloth, RelDamp, Trans

        RAOpening = Val(txtRXFStaticRAOpening.Text)
        SafetyGrate = Val(txtRXFStaticSafetyGrate.Text)
        RAFilt = Val(txtRXFStaticRAFilt.Text)
        ERW = Val(txtRXFStaticERW.Text)
        HWCloth = Val(txtRXFStaticHWCloth.Text)
        RelDamp = Val(txtRXFStaticReliefDamp.Text)
        Trans = Val(txtRXFStaticTrans.Text)

        RXFSubTotal = RAOpening + SafetyGrate + RAFilt + ERW + HWCloth + RelDamp + Trans
        RXFCabFXCalc = 0.1 * RXFSubTotal

    End Function

    Private Function RXFCabTotal() As Double
        Dim RXFSubTotal As Double
        Dim RAOpening, SafetyGrate, RAFilt, ERW, HWCloth, RelDamp, Trans, Safety

        RAOpening = Val(txtRXFStaticRAOpening.Text)
        SafetyGrate = Val(txtRXFStaticSafetyGrate.Text)
        RAFilt = Val(txtRXFStaticRAFilt.Text)
        ERW = Val(txtRXFStaticERW.Text)
        HWCloth = Val(txtRXFStaticHWCloth.Text)
        RelDamp = Val(txtRXFStaticReliefDamp.Text)
        Trans = Val(txtRXFStaticTrans.Text)
        Safety = Val(txtRXFStaticCabFX.Text)
        RXFSubTotal = RAOpening + SafetyGrate + RAFilt + ERW + HWCloth + RelDamp + Trans + Safety
        RXFCabTotal = RXFSubTotal

    End Function

    Private Sub UpdateWheelStaticTable()

        frmMain.ThisUnitERWPerf.SFStaticOAHood = txtSFStaticOAHood.Text
        frmMain.ThisUnitERWPerf.SFStaticMetalFilt = txtSFStaticMetalFilt.Text
        frmMain.ThisUnitERWPerf.SFStaticOADamp = txtSFStaticOADamp.Text
        frmMain.ThisUnitERWPerf.SFStaticOAFilt = txtSFStaticOAFilt.Text
        frmMain.ThisUnitERWPerf.SFStaticERW = txtSFStaticERW.Text
        frmMain.ThisUnitERWPerf.SFStaticTrans = txtSFStaticTrans.Text
        frmMain.ThisUnitERWPerf.SFStaticCabFX = txtSFStaticCabFX.Text
        frmMain.ThisUnitERWPerf.SFStaticTotal = txtSFStaticTotal.Text

        frmMain.ThisUnitERWPerf.RXFStaticRAOpening = txtRXFStaticRAOpening.Text
        frmMain.ThisUnitERWPerf.RXFStaticSafetyGrate = txtRXFStaticSafetyGrate.Text
        frmMain.ThisUnitERWPerf.RXFStaticRAFilt = txtRXFStaticRAFilt.Text
        frmMain.ThisUnitERWPerf.RXFStaticERW = txtRXFStaticERW.Text
        frmMain.ThisUnitERWPerf.RXFStaticHWCloth = txtRXFStaticHWCloth.Text
        frmMain.ThisUnitERWPerf.RXFStaticReliefDamp = txtRXFStaticReliefDamp.Text
        frmMain.ThisUnitERWPerf.RXFStaticReliefHood = txtRXFStaticReliefHood.Text
        frmMain.ThisUnitERWPerf.RXFStaticTrans = txtRXFStaticTrans.Text
        frmMain.ThisUnitERWPerf.RXFStaticCabFX = txtRXFStaticCabFX.Text
        frmMain.ThisUnitERWPerf.RXFStaticTotal = txtRXFStaticTotal.Text

    End Sub

    Private Sub UpdateSummer1ConditionTable()
        frmMain.ThisUnitERWPerf.SupplyAFSummer1 = txtCondS1SAFlow.Text
        frmMain.ThisUnitERWPerf.OAAFSummer1 = txtCondS1OAFlow.Text
        frmMain.ThisUnitERWPerf.OATdbSummer1 = txtCondS1OAdb.Text
        frmMain.ThisUnitERWPerf.OATwbSummer1 = txtCondS1OAwb.Text
        frmMain.ThisUnitERWPerf.ReturnAFSummer1 = txtCondS1RAFlow.Text
        frmMain.ThisUnitERWPerf.RATdbSummer1 = txtCondS1RAdb.Text
        frmMain.ThisUnitERWPerf.RATwbSummer1 = txtCondS1RAwb.Text
    End Sub
    Private Sub UpdateSummer2ConditionTable()
        frmMain.ThisUnitERWPerf.SupplyAFSummer2 = txtCondS2SAFlow.Text
        frmMain.ThisUnitERWPerf.OAAFSummer2 = txtCondS2OAFlow.Text
        frmMain.ThisUnitERWPerf.OATdbSummer2 = txtCondS2OAdb.Text
        frmMain.ThisUnitERWPerf.OATwbSummer2 = txtCondS2OAwb.Text
        frmMain.ThisUnitERWPerf.ReturnAFSummer2 = txtCondS2RAFlow.Text
        frmMain.ThisUnitERWPerf.RATdbSummer2 = txtCondS2RAdb.Text
        frmMain.ThisUnitERWPerf.RATwbSummer2 = txtCondS2RAwb.Text
    End Sub
    Private Sub UpdateWinter1ConditionTable()
        frmMain.ThisUnitERWPerf.SupplyAFWinter1 = txtCondW1SAFlow.Text
        frmMain.ThisUnitERWPerf.OAAFWinter1 = txtCondW1OAFlow.Text
        frmMain.ThisUnitERWPerf.OATdbWinter1 = txtCondW1OAdb.Text
        frmMain.ThisUnitERWPerf.OATwbWinter1 = txtCondW1OAwb.Text
        frmMain.ThisUnitERWPerf.ReturnAFWinter1 = txtCondW1RAFlow.Text
        frmMain.ThisUnitERWPerf.RATdbWinter1 = txtCondW1RAdb.Text
        frmMain.ThisUnitERWPerf.RATwbWinter1 = txtCondW1RAwb.Text
    End Sub
    Private Sub UpdateWinter2ConditionTable()
        frmMain.ThisUnitERWPerf.SupplyAFWinter2 = txtCondW2SAFlow.Text
        frmMain.ThisUnitERWPerf.OAAFWinter2 = txtCondW2OAFlow.Text
        frmMain.ThisUnitERWPerf.OATdbWinter2 = txtCondW2OAdb.Text
        frmMain.ThisUnitERWPerf.OATwbWinter2 = txtCondW2OAwb.Text
        frmMain.ThisUnitERWPerf.ReturnAFWinter2 = txtCondW2RAFlow.Text
        frmMain.ThisUnitERWPerf.RATdbWinter2 = txtCondW2RAdb.Text
        frmMain.ThisUnitERWPerf.RATwbWinter2 = txtCondW2RAwb.Text
    End Sub
    Private Sub UpdateWinterFFConditionTable()
        frmMain.ThisUnitERWPerf.SupplyAFWinterFF = txtCondWAFSAFlow.Text
        frmMain.ThisUnitERWPerf.OAAFWinterFF = txtCondWAFOAFlow.Text
        frmMain.ThisUnitERWPerf.OATdbWinterFF = txtCondWAFOAdb.Text
        frmMain.ThisUnitERWPerf.OATwbWinterFF = txtCondWAFOAwb.Text
        frmMain.ThisUnitERWPerf.ReturnAFWinterFF = txtCondWAFRAFlow.Text
        frmMain.ThisUnitERWPerf.RATdbWinterFF = txtCondWAFRAdb.Text
        frmMain.ThisUnitERWPerf.RATwbWinterFF = txtCondWAFRAwb.Text
    End Sub

    Private Sub UpdateSummer1PerfTable()
        frmMain.ThisUnitERWPerf.PerfSAAFlowS1 = txtPerfS1SAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSATempdbS1 = txtPerfS1SAdb.Text
        frmMain.ThisUnitERWPerf.PerfSATempwbS1 = txtPerfS1SAwb.Text
        frmMain.ThisUnitERWPerf.PerfXATempdbS1 = txtPerfS1XAdb.Text
        frmMain.ThisUnitERWPerf.PerfXATempwbS1 = txtPerfS1XAwb.Text
        frmMain.ThisUnitERWPerf.PerfXAAFlowS1 = txtPerfS1XAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSensEffS1 = txtPerfS1SensEff.Text
        frmMain.ThisUnitERWPerf.PerfLatEffS1 = txtPerfS1LatEff.Text
        frmMain.ThisUnitERWPerf.PerfTotEffS1 = txtPerfS1TotEff.Text
    End Sub
    Private Sub UpdateSummer2PerfTable()
        frmMain.ThisUnitERWPerf.PerfSAAFlowS2 = txtPerfS2SAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSATempdbS2 = txtPerfS2SAdb.Text
        frmMain.ThisUnitERWPerf.PerfSATempwbS2 = txtPerfS2SAwb.Text
        frmMain.ThisUnitERWPerf.PerfXATempdbS2 = txtPerfS2XAdb.Text
        frmMain.ThisUnitERWPerf.PerfXATempwbS2 = txtPerfS2XAwb.Text
        frmMain.ThisUnitERWPerf.PerfXAAFlowS2 = txtPerfS2XAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSensEffS2 = txtPerfS2SensEff.Text
        frmMain.ThisUnitERWPerf.PerfLatEffS2 = txtPerfS2LatEff.Text
        frmMain.ThisUnitERWPerf.PerfTotEffS2 = txtPerfS2TotEff.Text
    End Sub
    Private Sub UpdateWinter1PerfTable()
        frmMain.ThisUnitERWPerf.PerfSAAFlowW1 = txtPerfW1SAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSATempdbW1 = txtPerfW1SAdb.Text
        frmMain.ThisUnitERWPerf.PerfSATempwbW1 = txtPerfW1SAwb.Text
        frmMain.ThisUnitERWPerf.PerfXATempdbW1 = txtPerfW1XAdb.Text
        frmMain.ThisUnitERWPerf.PerfXATempwbW1 = txtPerfW1XAwb.Text
        frmMain.ThisUnitERWPerf.PerfXAAFlowW1 = txtPerfW1XAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSensEffW1 = txtPerfW1SensEff.Text
        frmMain.ThisUnitERWPerf.PerfLatEffW1 = txtPerfW1LatEff.Text
        frmMain.ThisUnitERWPerf.PerfTotEffW1 = txtPerfW1TotEff.Text
    End Sub
    Private Sub UpdateWinter2PerfTable()
        frmMain.ThisUnitERWPerf.PerfSAAFlowW2 = txtPerfW2SAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSATempdbW2 = txtPerfW2SAdb.Text
        frmMain.ThisUnitERWPerf.PerfSATempwbW2 = txtPerfW2SAwb.Text
        frmMain.ThisUnitERWPerf.PerfXATempdbW2 = txtPerfW2XAdb.Text
        frmMain.ThisUnitERWPerf.PerfXATempwbW2 = txtPerfW2XAwb.Text
        frmMain.ThisUnitERWPerf.PerfXAAFlowW2 = txtPerfW2XAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSensEffW2 = txtPerfW2SensEff.Text
        frmMain.ThisUnitERWPerf.PerfLatEffW2 = txtPerfW2LatEff.Text
        frmMain.ThisUnitERWPerf.PerfTotEffW2 = txtPerfW2TotEff.Text
    End Sub
    Private Sub UpdateWinterFFPerfTable()
        frmMain.ThisUnitERWPerf.PerfSAAFlowWFF = txtPerfWFFSAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSATempdbWFF = txtPerfWFFSAdb.Text
        frmMain.ThisUnitERWPerf.PerfSATempwbWFF = txtPerfWFFSAwb.Text
        frmMain.ThisUnitERWPerf.PerfXATempdbWFF = txtPerfWFFXAdb.Text
        frmMain.ThisUnitERWPerf.PerfXATempwbWFF = txtPerfWFFXAwb.Text
        frmMain.ThisUnitERWPerf.PerfXAAFlowWFF = txtPerfWFFXAFlow.Text
        frmMain.ThisUnitERWPerf.PerfSensEffWFF = txtPerfWFFSensEff.Text
        frmMain.ThisUnitERWPerf.PerfLatEffWFF = txtPerfWFFLatEff.Text
        frmMain.ThisUnitERWPerf.PerfTotEffWFF = txtPerfWFFTotEff.Text
    End Sub
    Private Sub UpdateSummer1MixPerfTable()
        frmMain.ThisUnitERWPerf.MixPerfS1WLFlow = txtMixPerfS1WLFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS1WLdb = txtMixPerfS1WLdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS1WLwb = txtMixPerfS1WLwb.Text
        frmMain.ThisUnitERWPerf.MixPerfS1RAFlow = txtMixPerfS1RAFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS1RAdb = txtMixPerfS1RAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS1RAwb = txtMixPerfS1RAwb.Text
        frmMain.ThisUnitERWPerf.MixPerfS1MixFlow = txtMixPerfS1MixFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS1MAdb = txtMixPerfS1MAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS1MAwb = txtMixPerfS1MAwb.Text

    End Sub

    Private Sub UpdateSummer2MixPerfTable()
        frmMain.ThisUnitERWPerf.MixPerfS2WLFlow = txtMixPerfS2WLFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS2WLdb = txtMixPerfS2WLdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS2WLwb = txtMixPerfS2WLwb.Text
        frmMain.ThisUnitERWPerf.MixPerfS2RAFlow = txtMixPerfS2RAFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS2RAdb = txtMixPerfS2RAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS2RAwb = txtMixPerfS2RAwb.Text
        frmMain.ThisUnitERWPerf.MixPerfS2MixFlow = txtMixPerfS2MixFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfS2MAdb = txtMixPerfS2MAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfS2MAwb = txtMixPerfS2MAwb.Text
    End Sub

    Private Sub UpdateWinter1MixPerfTable()
        frmMain.ThisUnitERWPerf.MixPerfW1WLFlow = txtMixPerfW1WLFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW1WLdb = txtMixPerfW1WLdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW1WLwb = txtMixPerfW1WLwb.Text
        frmMain.ThisUnitERWPerf.MixPerfW1RAFlow = txtMixPerfW1RAFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW1RAdb = txtMixPerfW1RAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW1RAwb = txtMixPerfW1RAwb.Text
        frmMain.ThisUnitERWPerf.MixPerfW1MixFlow = txtMixPerfW1MixFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW1MAdb = txtMixPerfW1MAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW1MAwb = txtMixPerfW1MAwb.Text
    End Sub

    Private Sub UpdateWinter2MixPerfTable()
        frmMain.ThisUnitERWPerf.MixPerfW2WLFlow = txtMixPerfW2WLFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW2WLdb = txtMixPerfW2WLdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW2WLwb = txtMixPerfW2WLwb.Text
        frmMain.ThisUnitERWPerf.MixPerfW2RAFlow = txtMixPerfW2RAFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW2RAdb = txtMixPerfW2RAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW2RAwb = txtMixPerfW2RAwb.Text
        frmMain.ThisUnitERWPerf.MixPerfW2MixFlow = txtMixPerfW2MixFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfW2MAdb = txtMixPerfW2MAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfW2MAwb = txtMixPerfW2MAwb.Text
    End Sub

    Private Sub UpdateWinterFFMixPerfTable()
        frmMain.ThisUnitERWPerf.MixPerfWFFWLFlow = txtMixPerfWFFWLFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFWLdb = txtMixPerfWFFWLdb.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFWLwb = txtMixPerfWFFWLwb.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFRAFlow = txtMixPerfWFFRAFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFRAdb = txtMixPerfWFFRAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFRAwb = txtMixPerfWFFRAwb.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFMixFlow = txtMixPerfWFFMixFlow.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFMAdb = txtMixPerfWFFMAdb.Text
        frmMain.ThisUnitERWPerf.MixPerfWFFMAwb = txtMixPerfWFFMAwb.Text
    End Sub

    Private Function MixedEnthalpy(dbFA As Double, wbFA As Double, dbRA As Double, wbRA As Double, FlowFA As Double, FlowRA As Double) As Double

        Dim atmpress As Double

        Dim EnthalpyFA As Double
        Dim EnthalpyRA As Double
        Dim MassFlowDryFA As Double
        Dim MassFlowVaporFA As Double
        Dim MassFlowMoistFA As Double
        Dim MassFlowDryRA As Double
        Dim MassFlowVaporRA As Double
        Dim MassFlowMoistRA As Double
        Dim SpecificVolumeFA As Double
        Dim SpecificVolumeRA As Double
        Dim MassFlowDryMA As Double
        Dim MassFlowVaporMA As Double
        Dim MassFlowMoistMA As Double

        atmpress = BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation)

        EnthalpyFA = BasPsychrometrics.psyEnthalpy_db_wb(dbFA, wbFA, atmpress)
        EnthalpyRA = BasPsychrometrics.psyEnthalpy_db_wb(dbRA, wbRA, atmpress)


        SpecificVolumeFA = BasPsychrometrics.psySpecificVolume(dbFA, wbFA, atmpress)
        SpecificVolumeRA = BasPsychrometrics.psySpecificVolume(dbRA, wbRA, atmpress)

        MassFlowDryFA = FlowFA / SpecificVolumeFA
        MassFlowDryRA = FlowRA / SpecificVolumeRA

        MassFlowVaporFA = MassFlowDryFA * BasPsychrometrics.psyHumRatio_db_wb(dbFA, wbFA, atmpress)
        MassFlowVaporRA = MassFlowDryRA * BasPsychrometrics.psyHumRatio_db_wb(dbRA, wbRA, atmpress)

        MassFlowMoistFA = MassFlowDryFA + MassFlowVaporFA
        MassFlowMoistRA = MassFlowDryRA + MassFlowVaporRA

        MassFlowDryMA = MassFlowDryFA + MassFlowDryRA
        MassFlowVaporMA = MassFlowVaporFA + MassFlowVaporRA
        MassFlowMoistMA = MassFlowDryMA + MassFlowVaporMA

        MixedEnthalpy = ((EnthalpyFA * MassFlowMoistFA) + (EnthalpyRA * MassFlowMoistRA)) / MassFlowMoistMA

    End Function

    Private Sub cmdCalculateMixed_Click(sender As Object, e As EventArgs) Handles cmdCalculateMixed.Click


        txtMixPerfS1MixFlow.Text = Val(txtMixPerfS1WLFlow.Text) + Val(txtMixPerfS1RAFlow.Text)
        txtMixPerfS1MAdb.Text = ((Val(txtMixPerfS1WLFlow.Text) * Val(txtMixPerfS1WLdb.Text)) + (Val(txtMixPerfS1RAFlow.Text) * Val(txtMixPerfS1RAdb.Text))) / Val(txtMixPerfS1MixFlow.Text)
        txtMixPerfS1MAwb.Text = BasPsychrometrics.psyWB(Val(txtMixPerfS1MAdb.Text), MixedEnthalpy(Val(txtMixPerfS1WLdb.Text), Val(txtMixPerfS1WLwb.Text), Val(txtMixPerfS1RAdb.Text), Val(txtMixPerfS1RAwb.Text), Val(txtMixPerfS1WLFlow.Text), Val(txtMixPerfS1RAFlow.Text)), BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation))

        If (IsNumeric(txtMixPerfS2WLFlow.Text) And IsNumeric(txtMixPerfS2RAFlow.Text)) Then
            txtMixPerfS2MixFlow.Text = Val(txtMixPerfS2WLFlow.Text) + Val(txtMixPerfS2RAFlow.Text)
            txtMixPerfS2MAdb.Text = ((Val(txtMixPerfS2WLFlow.Text) * Val(txtMixPerfS2WLdb.Text)) + (Val(txtMixPerfS2RAFlow.Text) * Val(txtMixPerfS2RAdb.Text))) / Val(txtMixPerfS2MixFlow.Text)
            txtMixPerfS2MAwb.Text = BasPsychrometrics.psyWB(Val(txtMixPerfS2WLdb.Text), MixedEnthalpy(Val(txtMixPerfS2WLdb.Text), Val(txtMixPerfS2WLwb.Text), Val(txtMixPerfS2RAdb.Text), Val(txtMixPerfS2RAwb.Text), Val(txtMixPerfS2WLFlow.Text), Val(txtMixPerfS2RAFlow.Text)), BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation))
        Else
            txtMixPerfS2MixFlow.Text = "-"
            txtMixPerfS2MAdb.Text = "-"

        End If
        If (IsNumeric(txtMixPerfW1WLFlow.Text) And IsNumeric(txtMixPerfW1RAFlow.Text)) Then
            txtMixPerfW1MixFlow.Text = Val(txtMixPerfW1WLFlow.Text) + Val(txtMixPerfW1RAFlow.Text)
            txtMixPerfW1MAdb.Text = ((Val(txtMixPerfW1WLFlow.Text) * Val(txtMixPerfW1WLdb.Text)) + (Val(txtMixPerfW1RAFlow.Text) * Val(txtMixPerfW1RAdb.Text))) / Val(txtMixPerfW1MixFlow.Text)
            txtMixPerfW1MAwb.Text = BasPsychrometrics.psyWB(Val(txtMixPerfW1WLdb.Text), MixedEnthalpy(Val(txtMixPerfW1WLdb.Text), Val(txtMixPerfW1WLwb.Text), Val(txtMixPerfW1RAdb.Text), Val(txtMixPerfW1RAwb.Text), Val(txtMixPerfW1WLFlow.Text), Val(txtMixPerfW1RAFlow.Text)), BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation))
        Else
            txtMixPerfW1MixFlow.Text = "-"
            txtMixPerfW1MAdb.Text = "-"

        End If
        If (IsNumeric(txtMixPerfW2WLFlow.Text) And IsNumeric(txtMixPerfW2RAFlow.Text)) Then
            txtMixPerfW2MixFlow.Text = Val(txtMixPerfW2WLFlow.Text) + Val(txtMixPerfW2RAFlow.Text)
            txtMixPerfW2MAdb.Text = ((Val(txtMixPerfW2WLFlow.Text) * Val(txtMixPerfW2WLdb.Text)) + (Val(txtMixPerfW2RAFlow.Text) * Val(txtMixPerfW2RAdb.Text))) / Val(txtMixPerfW2MixFlow.Text)
            txtMixPerfW2MAwb.Text = BasPsychrometrics.psyWB(Val(txtMixPerfW2WLdb.Text), MixedEnthalpy(Val(txtMixPerfW2WLdb.Text), Val(txtMixPerfW2WLwb.Text), Val(txtMixPerfW2RAdb.Text), Val(txtMixPerfW2RAwb.Text), Val(txtMixPerfW2WLFlow.Text), Val(txtMixPerfW2RAFlow.Text)), BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation))
        Else
            txtMixPerfW2MixFlow.Text = "-"
            txtMixPerfW2MAdb.Text = "-"

        End If
        If (IsNumeric(txtMixPerfWFFWLFlow.Text) And IsNumeric(txtMixPerfWFFRAFlow.Text)) Then
            txtMixPerfWFFMixFlow.Text = Val(txtMixPerfWFFWLFlow.Text) + Val(txtMixPerfWFFRAFlow.Text)
            txtMixPerfWFFMAdb.Text = ((Val(txtMixPerfWFFWLFlow.Text) * Val(txtMixPerfWFFWLdb.Text)) + (Val(txtMixPerfWFFRAFlow.Text) * Val(txtMixPerfWFFRAdb.Text))) / Val(txtMixPerfWFFMixFlow.Text)
            txtMixPerfWFFMAwb.Text = BasPsychrometrics.psyWB(Val(txtMixPerfWFFWLdb.Text), MixedEnthalpy(Val(txtMixPerfWFFWLdb.Text), Val(txtMixPerfWFFWLwb.Text), Val(txtMixPerfWFFRAdb.Text), Val(txtMixPerfWFFRAwb.Text), Val(txtMixPerfWFFWLFlow.Text), Val(txtMixPerfWFFRAFlow.Text)), BasPsychrometrics.psyAtmosphericPressure(frmMain.ThisUnitCoolPerf.Elevation))
        Else
            txtMixPerfWFFMixFlow.Text = "-"
            txtMixPerfWFFMAdb.Text = "-"

        End If




    End Sub

    Private Function FreshAirMistElimPD(UnitSeries As String, UnitCabinet As String, Airflow As Double, MeshFilters As Boolean) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99
        If MeshFilters = True Then
            Select Case UnitSeries
                Case Is = "Series100"
                    Select Case UnitCabinet
                        Case Is = "S100A"
                            TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                        Case Is = "S100B"
                        Case Is = "S100C"
                    End Select
                Case Else
                    TempPD = -99.99
            End Select
        Else
            TempPD = 0.00
        End If
        FreshAirMistElimPD = TempPD
    End Function

    Private Function FreshAirHoodPD(UnitSeries As String, UnitCabinet As String, Airflow As Double) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99

        Select Case UnitSeries
            Case Is = "Series100"
                Select Case UnitCabinet
                    Case Is = "S100A"
                        TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                    Case Is = "S100B"
                    Case Is = "S100C"
                End Select
            Case Else
                TempPD = -99.99
        End Select
        FreshAirHoodPD = TempPD
    End Function

    Private Function FreshAirOADamperPD(UnitSeries As String, UnitCabinet As String, Airflow As Double) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99

        Select Case UnitSeries
            Case Is = "Series100"
                Select Case UnitCabinet
                    Case Is = "S100A"
                        TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                    Case Is = "S100B"
                    Case Is = "S100C"
                End Select
            Case Else
                TempPD = -99.99
        End Select
        FreshAirOADamperPD = TempPD
    End Function

    Private Function FreshAirOAFiltersPD(UnitSeries As String, UnitCabinet As String, Airflow As Double, OAFilters As Boolean, AngledRack As Boolean) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99
        If OAFilters = True Then
            Select Case UnitSeries
                Case Is = "Series100"
                    Select Case UnitCabinet
                        Case Is = "S100A"
                            If AngledRack = True Then
                                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                            Else
                                TempPD = -99.0
                            End If
                        Case Is = "S100B"
                        Case Is = "S100C"
                    End Select
                Case Else
                    TempPD = -99.99
            End Select
        Else
            TempPD = 0.00
        End If
        FreshAirOAFiltersPD = TempPD
    End Function

    Private Function FreshAirERWPD(ERWModel As String, Airflow As Double) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99

        Select Case ERWModel
            Case Is = "TA3C-54-100"
                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
            Case Is = "TA3C-60-200"
                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
            Case Is = "TA3C-66-200"
                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
            Case Else
                TempPD = -99.99
        End Select
        FreshAirERWPD = TempPD
    End Function

    Private Function FreshAirTransitionsPD(UnitSeries As String, UnitCabinet As String, ERWModel As String, Airflow As Double) As Double
        Dim TempPD As Double
        Dim AF As Double

        AF = Val(Airflow)
        TempPD = -99.99

        Select Case UnitSeries
            Case Is = "Series100"
                Select Case UnitCabinet
                    Case Is = "S100A"
                        Select Case ERWModel
                            Case Is = "TA3C-54-100"
                                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                            Case Is = "TA3C-60-200"
                                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                            Case Is = "TA3C-66-200"
                                TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                        End Select
                    Case Is = "S100B"
                    Case Is = "S100C"
                End Select
            Case Else
                TempPD = -99.99
        End Select
        FreshAirTransitionsPD = TempPD
    End Function

    Private Function FreshAirSafetyFactor() As Double
        Dim TempSF As Double

        TempSF = 99.9

        TempSF = Val(txtSFStaticOAHood.Text) + Val(txtSFStaticMetalFilt.Text) + Val(txtSFStaticOADamp.Text) + Val(txtSFStaticOAFilt.Text) + Val(txtSFStaticERW.Text) + Val(txtSFStaticTrans.Text)
        TempSF = TempSF * 0.1

        FreshAirSafetyFactor = TempSF
    End Function

    Private Function FreshAirTotal() As Double
        Dim TempSF As Double

        TempSF = 99.9

        TempSF = Val(txtSFStaticOAHood.Text) + Val(txtSFStaticMetalFilt.Text) + Val(txtSFStaticOADamp.Text) + Val(txtSFStaticOAFilt.Text) + Val(txtSFStaticERW.Text) + Val(txtSFStaticTrans.Text) + Val(txtSFStaticCabFX.Text)

        FreshAirTotal = TempSF
    End Function


    Private Sub txtStaticTableFreshAirFlow_LostFocus(sender As Object, e As EventArgs) Handles txtStaticTableFreshAirFlow.LostFocus
        txtSFStaticOAHood.Text = Format(FreshAirHoodPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticMetalFilt.Text = Format(FreshAirMistElimPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text), chkFiltrationOAMetal.Checked), "0.00")
        txtSFStaticOADamp.Text = Format(FreshAirOADamperPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticOAFilt.Text = Format(FreshAirOAFiltersPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text), chkFiltrationOAMERV8.Checked, chkFiltrationOAAngledRack.Checked), "0.00")
        txtSFStaticERW.Text = Format(FreshAirERWPD(cmbWheel.Text, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticTrans.Text = Format(FreshAirTransitionsPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, cmbWheel.Text, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticCabFX.Text = Format(FreshAirSafetyFactor(), "0.00")
        txtSFStaticTotal.Text = Format(FreshAirTotal(), "0.00")

    End Sub

    Private Sub txtStaticTableExhaustAirFlow_LostFocus(sender As Object, e As EventArgs) Handles txtStaticTableExhaustAirFlow.LostFocus


        txtRXFStaticCabFX.Text = Format(RXAirSafetyFactor(), "0.00")
        txtRXFStaticTotal.Text = Format(RXAirTotal(), "0.00")
    End Sub

    Private Sub txtStaticTableFullReturn_LostFocus(sender As Object, e As EventArgs) Handles txtStaticTableFullReturn.LostFocus


        txtRXFStaticCabFX.Text = Format(RXAirSafetyFactor(), "0.00")
        txtRXFStaticTotal.Text = Format(RXAirTotal(), "0.00")
    End Sub

    Private Sub cmdDoneControls_Click(sender As Object, e As EventArgs) Handles cmdDoneControls.Click
        txtSFStaticOAHood.Text = Format(FreshAirHoodPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticMetalFilt.Text = Format(FreshAirMistElimPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text), chkFiltrationOAMetal.Checked), "0.00")
        txtSFStaticOADamp.Text = Format(FreshAirOADamperPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticOAFilt.Text = Format(FreshAirOAFiltersPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, Val(txtStaticTableFreshAirFlow.Text), chkFiltrationOAMERV8.Checked, chkFiltrationOAAngledRack.Checked), "0.00")
        txtSFStaticERW.Text = Format(FreshAirERWPD(cmbWheel.Text, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticTrans.Text = Format(FreshAirTransitionsPD(frmMain.ThisUnit.Family, frmMain.ThisUnit.Cabinet, cmbWheel.Text, Val(txtStaticTableFreshAirFlow.Text)), "0.00")
        txtSFStaticCabFX.Text = Format(FreshAirSafetyFactor(), "0.00")
        txtSFStaticTotal.Text = Format(FreshAirTotal(), "0.00")



        txtRXFStaticCabFX.Text = Format(RXAirSafetyFactor(), "0.00")
        txtRXFStaticTotal.Text = Format(RXAirTotal(), "0.00")

        tbcERW.SelectTab("pgStatic")
    End Sub

    Private Sub cmdSFStaticUpdate_Click(sender As Object, e As EventArgs) Handles cmdSFStaticUpdate.Click
        txtSFStaticCabFX.Text = Format(FreshAirSafetyFactor(), "0.00")
        txtSFStaticTotal.Text = Format(FreshAirTotal(), "0.00")

    End Sub

    Private Function RXAirSafetyFactor() As Double
        Dim TempSF As Double

        TempSF = 99.9

        TempSF = Val(txtRXFStaticRAOpening.Text) + Val(txtRXFStaticSafetyGrate.Text) + Val(txtRXFStaticRAFilt.Text) + Val(txtRXFStaticERW.Text) + Val(txtRXFStaticHWCloth.Text) + Val(txtRXFStaticReliefDamp.Text) + Val(txtRXFStaticReliefDamp.Text) + Val(txtRXFStaticReliefHood.Text) + Val(txtRXFStaticTrans.Text)
        TempSF = TempSF * 0.1

        RXAirSafetyFactor = TempSF
    End Function

    Private Function RXAirTotal() As Double
        Dim TempSF As Double

        TempSF = 99.9

        TempSF = Val(txtRXFStaticRAOpening.Text) + Val(txtRXFStaticSafetyGrate.Text) + Val(txtRXFStaticRAFilt.Text) + Val(txtRXFStaticERW.Text) + Val(txtRXFStaticHWCloth.Text) + Val(txtRXFStaticReliefDamp.Text) + Val(txtRXFStaticReliefDamp.Text) + Val(txtRXFStaticReliefHood.Text) + Val(txtRXFStaticTrans.Text) + Val(txtRXFStaticCabFX.Text)
        RXAirTotal = TempSF
    End Function

    Private Sub cmdXFStaticUpdate_Click(sender As Object, e As EventArgs) Handles cmdSFStaticUpdate.Click
        txtRXFStaticRAOpening.Text = "0"

        txtRXFStaticCabFX.Text = Format(RXAirSafetyFactor(), "0.00")
        txtRXFStaticTotal.Text = Format(RXAirTotal(), "0.00")

    End Sub
    Private Function RXAirRAOpeningPD(UnitSeries As String, UnitCabinet As String, FullFlow As Boolean) As Double
        Dim TempPD As Double
        Dim AF As Double

        If FullFlow Then
            AF = Val(txtStaticTableFullReturn.Text)
        Else
            AF = Val(txtStaticTableExhaustAirFlow.Text)
        End If

        TempPD = -99.99

        Select Case UnitSeries
            Case Is = "Series100"
                Select Case UnitCabinet
                    Case Is = "S100A"
                        TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                    Case Is = "S100B"
                    Case Is = "S100C"
                End Select
            Case Else
                TempPD = -99.99
        End Select
        RXAirRAOpeningPD = TempPD
    End Function
    Private Function RXAirSafetyGRatePD(UnitSeries As String, UnitCabinet As String, FullFlow As Boolean) As Double
        Dim TempPD As Double
        Dim AF As Double

        If FullFlow Then
            AF = Val(txtStaticTableFullReturn.Text)
        Else
            AF = Val(txtStaticTableExhaustAirFlow.Text)
        End If

        TempPD = -99.99

        Select Case UnitSeries
            Case Is = "Series100"
                Select Case UnitCabinet
                    Case Is = "S100A"
                        TempPD = 0.000000000022109 * AF * AF + 0.000005369047619 * AF
                    Case Is = "S100B"
                    Case Is = "S100C"
                End Select
            Case Else
                TempPD = -99.99
        End Select
        RXAirSafetyGRatePD = TempPD
    End Function

    Private Sub optFullFlow_CheckedChanged(sender As Object, e As EventArgs) Handles optFullFlow.CheckedChanged
        If optFullFlow.Checked Then
            chkScopeOABypass.Checked = False
            chkScopeOABypass.Enabled = False
            chkScopeXABypassDampers.Checked = False
            chkScopeXABypassDampers.Enabled = False
        Else
            chkScopeOABypass.Enabled = True
            chkScopeXABypassDampers.Enabled = True
        End If
    End Sub

    Private Sub optSFanFisen_CheckedChanged(sender As Object, e As EventArgs) Handles optSFanFisen.CheckedChanged
        If optSFanJCI.Checked Then
            txtSFStaticPressureAllowance.Enabled = True
            txtSFStaticPressureAllowance.Text = "1.00"
        End If

        If ((optSFanFisen.Checked) Or (optSFanOAFan.Checked)) Then
            txtSFStaticPressureAllowance.Enabled = False
            txtSFStaticPressureAllowance.Text = "-"
        End If

    End Sub
    Private Sub optSFanJCI_CheckedChanged(sender As Object, e As EventArgs) Handles optSFanJCI.CheckedChanged
        If optSFanJCI.Checked Then
            txtSFStaticPressureAllowance.Enabled = True
            txtSFStaticPressureAllowance.Text = "1.00"
        End If

        If ((optSFanFisen.Checked) Or (optSFanOAFan.Checked)) Then
            txtSFStaticPressureAllowance.Enabled = False
            txtSFStaticPressureAllowance.Text = "-"
        End If
    End Sub
    Private Sub optXFanbyJCI_CheckedChanged(sender As Object, e As EventArgs) Handles optXFanbyJCI.CheckedChanged
        If ((optXFanbyJCI.Checked) Or (optRFanbyJCI.Checked)) Then
            txtRFStaticPressureAllowance.Enabled = True
            txtRFStaticPressureAllowance.Text = "1.00"
        Else
            txtRFStaticPressureAllowance.Enabled = False
            txtRFStaticPressureAllowance.Text = "-"
        End If
    End Sub
    Private Sub optXFanByFisen_CheckedChanged(sender As Object, e As EventArgs) Handles optXFanByFisen.CheckedChanged
        If optXFanByFisen.Checked Then
            lblRecFanTypeStatic.Text = "Exhaust Fan"
        Else
            lblRecFanTypeStatic.Text = "Return Fan"
        End If
    End Sub

    Private Sub optRFanByFisen_CheckedChanged(sender As Object, e As EventArgs) Handles optRFanByFisen.CheckedChanged
        If ((optXFanbyJCI.Checked) Or (optRFanbyJCI.Checked)) Then
            txtRFStaticPressureAllowance.Enabled = True
            txtRFStaticPressureAllowance.Text = "1.00"
        Else
            txtRFStaticPressureAllowance.Enabled = False
            txtRFStaticPressureAllowance.Text = "-"
        End If
    End Sub

    Private Sub optRFanbyJCI_CheckedChanged(sender As Object, e As EventArgs) Handles optRFanbyJCI.CheckedChanged
        If ((optXFanbyJCI.Checked) Or (optRFanbyJCI.Checked)) Then
            txtRFStaticPressureAllowance.Enabled = True
            txtRFStaticPressureAllowance.Text = "1.00"
        Else
            txtRFStaticPressureAllowance.Enabled = False
            txtRFStaticPressureAllowance.Text = "-"
        End If
    End Sub
    Private Sub chkScopeXABypassDampers_CheckedChanged(sender As Object, e As EventArgs) Handles chkScopeXABypassDampers.CheckedChanged
        If chkScopeXABypassDampers.Checked Then
            grpXABypassHoods.Enabled = True
            grpXABypassDampers.Enabled = True
            grpReliefDampers.Enabled = True

            optXABPHoodByFisen.Checked = True
            optReliefDamperActuated.Checked = False
        Else
            grpXABypassHoods.Enabled = False
            grpXABypassDampers.Enabled = False
            grpReliefDampers.Enabled = False
            optXABPHoodNone.Checked = True
            chkXABPHoodMesh.Checked = False
            chkXABPHoodFieldInstalled.Checked = False
            optReliefDamperNone.Checked = True

        End If
    End Sub


End Class