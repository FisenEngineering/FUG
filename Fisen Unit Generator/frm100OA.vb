Imports System.ComponentModel
Imports System.Xml

Public Class frm100OA
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
        frmMain.ThisUnitMods.Add("OA100") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems()
        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        If optJCIHGBP.Checked Then
            frmMain.lstRequiredFactoryItems.Items.Add("Factory installed HGBP on Circuit 1")
        End If
    End Sub
    Private Sub UpdateCodeList()
        Dim BaseControl As String
        Dim HeatType As String

        HeatType = "None"
        If optGasHeat.Checked Then HeatType = "Gas"
        If optEHeat.Checked Then HeatType = "Electric"
        If optHWHeat.Checked Then HeatType = "Hot Water"
        If optSteamHeat.Checked Then HeatType = "Steam"
        If optHeatcoGas.Checked Then HeatType = "Heatco"

        BaseControl = "SE"
        If optSE.Checked Then BaseControl = "SE"
        If optIPU.Checked Then BaseControl = "IPU"
        If optASE.Checked Then BaseControl = "ASE"

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("0A0100")
        If optJCIHGBP.Checked Then
            ModuleCodeList.Add("0A0701")
        End If


        'Mechanical Stuffs
        If opt100OACapable.Checked Then
            ModuleCodeList.Add("0A0105") '100% OA Capable

            ModuleCodeList.Add("0A0110") 'Modulating Damper
            ModuleCodeList.Add("0A0113")

        Else
            ModuleCodeList.Add("0A0101") '100% Outdoor Air Conversion

            ModuleCodeList.Add("0A0111") 'Open/Closed Damper
            ModuleCodeList.Add("0A0112")
            ModuleCodeList.Add("0A0114")

            ModuleCodeList.Add("0A0119") 'Seal Existing Return Air Opening

        End If

        'Controls for OA Capable
        If opt100OACapable.Checked Then
            ModuleCodeList.Add("0A0130") 'Controls for 100% Outdoor Air Capable Unit
            If chk65kASCCRBase.Checked Then ModuleCodeList.Add("0A0991")

            Select Case BaseControl
                Case Is = "SE"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0135") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0145") 'MAT Protection
                    ModuleCodeList.Add("0A0150") 'SG High Limit

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A01A5") 'OAT Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01B5") 'GBAS Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01C5") 'Base Unit Only Mode Control
                Case Is = "IPU"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0136") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0146") 'MAT Protection
                    ModuleCodeList.Add("0A0151") 'SG High Limit

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A01A6") 'OAT Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01B6") 'GBAS Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01C6") 'Base Unit Only Mode Control
                Case Is = "ASE"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0137") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0147") 'MAT Protection
                    ModuleCodeList.Add("0A0152") 'SG High Limit

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A01A7") 'OAT Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01B7") 'GBAS Mode Control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A01C7") 'Base Unit Only Mode Control

            End Select



            If ((frmMain.ThisUnit.Family = "Series10") Or (frmMain.ThisUnit.Family = "Series20")) And optReturnHorizontal.Checked Then
                ModuleCodeList.Add("0A0550")
            End If
        End If

        'Controls for 100OA
        If opt100OA.Checked Then
            'Handle the Controls
            ModuleCodeList.Add("0A0120") 'Controls for 100% Outdoor Air Unit
            If chk65kASCCRBase.Checked Then ModuleCodeList.Add("0A0990")

            Select Case BaseControl
                Case Is = "SE"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0390") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0395") 'High Suction Gas Protection
                    If chkOADamperSwitch.Checked Then
                        ModuleCodeList.Add("0A0301") 'OA Damper Limit Switch
                        ModuleCodeList.Add("0A0308") 'FanSS with Large Motor
                    Else
                        ModuleCodeList.Add("0A0305") 'FanSS with Small Motor
                    End If

                    'Intellispeed Conversion
                    If chkIntellispeed.Checked Then ModuleCodeList.Add("0A0370")

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A0123") 'OA Temp based mode control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A0125") 'GBAS
                    If optModeDATOnly.Checked Then ModuleCodeList.Add("0A0129") 'DAT Only

                    'Handle the cooling controls

                    'handle the heating controls
                    Select Case HeatType
                        Case Is = "None"
                        Case Is = "Gas"
                        Case Is = "Electric"
                        Case Is = "Hot Water"
                        Case Is = "Steam"
                        Case Is = "Heatco"
                    End Select

                    'Handle Zone Override Sensors

                Case Is = "IPU"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0391") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0396") 'High Suction Gas Protection
                    If chkOADamperSwitch.Checked Then
                        ModuleCodeList.Add("0A0302") 'OA Damper Limit Switch 
                        ModuleCodeList.Add("0A0309") 'FanSS with Large Motor
                    Else
                        ModuleCodeList.Add("0A0306") 'FanSS with Small Motor
                    End If

                    'Convert VFD
                    If chkIntellispeed.Checked Then ModuleCodeList.Add("0A0371")

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A0123") 'OA Temp based mode control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A0125") 'GBAS
                    If optModeDATOnly.Checked Then ModuleCodeList.Add("0A0129") 'DAT Only

                    'Handle the cooling controls
                    If optCoolCtrlByBaseUnit.Checked Then ModuleCodeList.Add("0A02E3")

                    'handle the heating controls
                    Select Case HeatType
                        Case Is = "None"
                        Case Is = "Gas"
                            If optHeatCtrlStagedOA.Checked Then ModuleCodeList.Add("0A0270")
                        Case Is = "Electric"
                        Case Is = "Hot Water"
                        Case Is = "Steam"
                        Case Is = "Heatco"
                    End Select

                    'Handle Zone Override Sensors
                    If chkZoneOvrSensor.Checked Then
                        If optCoolCtrlByBaseUnit.Checked Then ModuleCodeList.Add("0A02D1")
                        If optCoolCtrlDAByFisen.Checked Then ModuleCodeList.Add("0A02D2")
                        If optCoolCtrlStagedOA.Checked Then ModuleCodeList.Add("0A02D3")
                        If optHeatCtrlStagedOA.Checked Then ModuleCodeList.Add("0A02D4")
                        If optHeatCtrlDAByFisen.Checked Then ModuleCodeList.Add("0A02D5")
                        If optHeatCtrlDABaseUnit.Checked Then ModuleCodeList.Add("0A02D6")
                    End If


                Case Is = "ASE"
                    'First Handle the general safeties
                    ModuleCodeList.Add("0A0392") 'Timed Freeze Protection
                    ModuleCodeList.Add("0A0397") 'High Suction Gas Protection
                    If chkOADamperSwitch.Checked Then
                        ModuleCodeList.Add("0A0303") 'OA Damper Limit Switch 
                        ModuleCodeList.Add("0A030A") 'FanSS with Large Motor
                    Else
                        ModuleCodeList.Add("0A0307") 'FanSS with Small Motor
                    End If

                    'Mode Control
                    If optModeAuto.Checked Then ModuleCodeList.Add("0A0123") 'OA Temp based mode control
                    If optModeGBAS.Checked Then ModuleCodeList.Add("0A0125") 'GBAS
                    If optModeDATOnly.Checked Then ModuleCodeList.Add("0A0129") 'DAT Only

                    'Handle the cooling controls

                    'handle the heating controls
                    Select Case HeatType
                        Case Is = "None"
                        Case Is = "Gas"
                        Case Is = "Electric"
                        Case Is = "Hot Water"
                        Case Is = "Steam"
                        Case Is = "Heatco"
                    End Select

                    'Handle Zone Override Sensors


            End Select

        End If

        frmMain.ThisUnit.CommNodes = "2"


        'Every unit gets a touch??
        If frmMain.HasUMHMI = False Then
            frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
        End If


        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert() 'v1.0

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

    End Sub

    Private Sub AuxPanelCodeInsert()
        'v 1.0
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
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("OA100")
        'Next Line is the line item description i.e. Hot Water Description
        If opt100OACapable.Checked Then
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("100% Outdoor Air Capable")
        Else
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("100% Outdoor Air")
        End If
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If opt100OA.Checked = True Then tempWeight = "55"
                If opt100OACapable.Checked = True Then tempWeight = "35"
            Case Is = "Series10"
                If opt100OA.Checked = True Then tempWeight = "65"
                If opt100OACapable.Checked = True Then tempWeight = "35"
            Case Is = "Series20"
                If opt100OA.Checked = True Then tempWeight = "65"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Is = "Series40"
                If opt100OA.Checked = True Then tempWeight = "85"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Is = "Series100"
                If opt100OA.Checked = True Then tempWeight = "175"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Is = "Premier"
                If opt100OA.Checked = True Then tempWeight = "85"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Is = "Choice"
                If opt100OA.Checked = True Then tempWeight = "65"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Is = "Select"
                If opt100OA.Checked = True Then tempWeight = "65"
                If opt100OACapable.Checked = True Then tempWeight = "20"
            Case Else
                tempWeight = "9999"
        End Select



        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'No performance for this modification

    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load

        pCancelled = False

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
        Call PopulateAuxPanelList() 'V1.0

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = True
                optNoAux.Enabled = False
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Series10"
                optUseAux.Checked = True
                optNoAux.Enabled = False
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Series12"
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Series20"
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Series40"
                'Depricated *Probably not going to be used*
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Series100"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                chkYPALtoVAV.Enabled = True
            Case Is = "Premier"
                optSE.Enabled = False
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Checked = True
            Case Is = "Choice"
                optSE.Enabled = True
                optIPU.Enabled = False
                optASE.Enabled = False
            Case Is = "Select"
                optSE.Enabled = False
                optIPU.Enabled = False
                optASE.Checked = True
            Case Else

        End Select

        If ((InTheQueue("Reduced Air Flow") = True) Or (AlreadyDone("LowAF") = True)) Then
            chkLowAF.Checked = True
            chkLowAF.Enabled = False
        End If

        If ((InTheQueue("Hot Gas Bypass") = True) Or (AlreadyDone("HGBP") = True)) Then
            optFisenHGBP.Checked = True
        End If

        If Val(frmMain.ThisUnitSFanPerf.MotorHP) > 5.0 Then
            chkOADamperSwitch.Checked = True
        End If


        ModuleCodeList.Add("0A0100")

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True


    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/OA100")

        TempVal = xNodeRoot.SelectSingleNode("Conversion").InnerText
        If TempVal = "100OA" Then opt100OA.Checked = True Else opt100OACapable.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("ReturnCon").InnerText
        If TempVal = "Bottom" Then optReturnBottom.Checked = True
        If TempVal = "Horizontal" Then optReturnHorizontal.Checked = True
        If TempVal = "No Return" Then optReturnNone.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("HeatType").InnerText
        If TempVal = "None" Then optNoHeat.Checked = True
        If TempVal = "Gas" Then optGasHeat.Checked = True
        If TempVal = "Electric" Then optEHeat.Checked = True
        If TempVal = "Hot Water" Then optHWHeat.Checked = True
        If TempVal = "Steam" Then optSteamHeat.Checked = True
        If TempVal = "Heatco" Then optHeatcoGas.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("ModByFisen").InnerText
        If TempVal = "Yes" Then chkModHeat.Checked = True Else chkModHeat.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("LowAF").InnerText
        If TempVal = "Yes" Then chkLowAF.Checked = True Else chkLowAF.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("HGRHByJCI").InnerText
        If TempVal = "Yes" Then chkJCIHGRH.Checked = True Else chkJCIHGRH.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("HGRHConvByFisen").InnerText
        If TempVal = "Yes" Then chkHGRH_Conv.Checked = True Else chkHGRH_Conv.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("HGRHByFisen").InnerText
        If TempVal = "Yes" Then chkFisenHGRH.Checked = True Else chkFisenHGRH.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("HGRHModByFisen").InnerText
        If TempVal = "Yes" Then chkFisenMHGRH.Checked = True Else chkFisenMHGRH.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("HGBP").InnerText
        If TempVal = "ByJCI" Then optJCIHGBP.Checked = True Else optFisenHGBP.Checked = True


    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click

        If chkLowAF.Checked Then
            If ((InTheQueue("Reduced Air Flow") = False) And (AlreadyDone("LowAF") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Reduced Air Flow")
            End If
        End If
        If chkHGRH_Conv.Checked Then
            If ((InTheQueue("Modulating Hot Gas Reheat Conversion") = False) And (AlreadyDone("MHGRG_Conv") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Modulating Hot Gas Reheat Conversion")
            End If

        End If
        If chkFisenHGRH.Checked Then
            If ((InTheQueue("Hot Gas Reheat") = False) And (AlreadyDone("HGRH") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Hot Gas Reheat")
            End If
        End If
        If optFisenHGBP.Checked Then
            If ((InTheQueue("Hot Gas Bypass") = False) And (AlreadyDone("HGBP") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Hot Gas Bypass")
            End If
        End If
        If chkModHeat.Checked Then
            If optGasHeat.Checked Then
                If ((InTheQueue("Modulating Gas Heat Retrofit") = False) And (AlreadyDone("MGH_R") = False)) Then
                    frmMain.lstSelectedMods.Items.Add("Modulating Gas Heat Retrofit")
                End If
            End If
            If optEHeat.Checked Then
                If ((InTheQueue("Modulating Electric Heat Retrofit") = False) And (AlreadyDone("MEHeat_R") = False)) Then
                    frmMain.lstSelectedMods.Items.Add("Modulating Electric Heat Retrofit")
                End If
            End If

            If optHeatcoGas.Checked Then
                If ((InTheQueue("Modulating Gas Heat Heatco") = False) And (AlreadyDone("MGH_H") = False)) Then
                    frmMain.lstSelectedMods.Items.Add("Modulating Gas Heat Heatco")
                End If
            End If
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub
    Private Function AlreadyDone(modcode As String) As Boolean
        Dim i As Integer
        Dim thistest As Boolean
        thistest = False
        For i = 0 To frmMain.ThisUnitMods.Count - 1
            If frmMain.ThisUnitMods.Item(i) = modcode Then
                thistest = True
            End If
        Next
        AlreadyDone = thistest
    End Function
    Private Function InTheQueue(modname As String) As Boolean
        Dim i As Integer
        Dim thistest As Boolean
        thistest = False
        For i = 0 To frmMain.lstSelectedMods.Items.Count - 1
            If frmMain.lstSelectedMods.Items.Item(i) = modname Then
                thistest = True
            End If
        Next
        InTheQueue = thistest
    End Function

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        txtNoPerformanceNote.Text = "If RA opening Is part Of the supply fan total Static," & vbCrLf & "remove this prior To calculating fan performance."
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub chkJCIHGRH_CheckedChanged(sender As Object, e As EventArgs) Handles chkJCIHGRH.CheckedChanged
        If chkJCIHGRH.Checked Then
            chkHGRH_Conv.Enabled = True
        Else
            chkHGRH_Conv.Enabled = False
            chkHGRH_Conv.Checked = False
        End If
    End Sub

    Private Sub chkFisenHGRH_CheckedChanged(sender As Object, e As EventArgs) Handles chkFisenHGRH.CheckedChanged
        If chkFisenHGRH.Checked Then
            chkFisenMHGRH.Enabled = True
        Else
            chkFisenMHGRH.Checked = False
            chkFisenMHGRH.Enabled = False
        End If
    End Sub


    Private Sub PopulateAuxPanelList()
        'V1.0
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
    End Sub

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optModeGBAS_CheckedChanged(sender As Object, e As EventArgs) Handles optModeGBAS.CheckedChanged
        If opt100OA.Checked Then
            If optModeGBAS.Checked = True Then

                'handle the zone override sensor
                chkZoneOvrSensor.Enabled = False
                chkZoneOvrSensor.Checked = False

                'handle the cooling controls    
                optCoolCtrlStagedOA.Enabled = False
                optCoolCtrlDAByFisen.Enabled = False
                optCoolCtrlByBaseUnit.Enabled = False
                optCoolCtrlGBAS.Enabled = True
                optCoolCtrlGBAS.Checked = True

                'handle the heating controls
                If Not (optNoHeat.Checked) Then
                    grpGBASHeat.Enabled = True
                    optHeatCtrlGBAS.Checked = True
                    optGBASVernier.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = True
                    optHeatCtrlNone.Enabled = False
                Else 'executes if no heat
                    optHeatCtrlNone.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = True
                End If


                'Handle the GBAS Controls
                grpGBASCtrl4.Enabled = True
                optGBASCooling.Checked = True


            End If
        Else
            If optModeGBAS.Checked = True Then

                'handle the zone override sensor
                chkZoneOvrSensor.Enabled = False
                chkZoneOvrSensor.Checked = False

                'handle the cooling controls    
                optCoolCtrlStagedOA.Enabled = False
                optCoolCtrlDAByFisen.Enabled = False
                optCoolCtrlByBaseUnit.Enabled = False
                optCoolCtrlGBAS.Enabled = True
                optCoolCtrlGBAS.Checked = True

                'handle the heating controls
                If Not (optNoHeat.Checked) Then
                    grpGBASHeat.Enabled = True
                    optHeatCtrlGBAS.Checked = True
                    optGBASVernier.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = True
                    optHeatCtrlNone.Enabled = False
                Else 'executes if no heat
                    optHeatCtrlNone.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = True
                End If


                'Handle the GBAS Controls
                grpGBASCtrl4.Enabled = True
                optGBASCooling.Checked = True


            End If
        End If
    End Sub

    Private Sub optModeAuto_CheckedChanged(sender As Object, e As EventArgs) Handles optModeAuto.CheckedChanged
        If opt100OA.Checked Then
            If optModeAuto.Checked = True Then
                'Handle Zone Override Sensor
                chkZoneOvrSensor.Enabled = True
                chkZoneOvrSensor.Checked = True

                'Handle Cooling Controls
                optCoolCtrlStagedOA.Enabled = True
                optCoolCtrlStagedOA.Checked = True
                optCoolCtrlDAByFisen.Enabled = True
                optCoolCtrlByBaseUnit.Enabled = True
                optCoolCtrlGBAS.Enabled = False

                'Handle Heating Controls
                If Not (optNoHeat.Checked) Then
                    optHeatCtrlStagedOA.Checked = True

                    optHeatCtrlStagedOA.Enabled = True
                    optHeatCtrlDAByFisen.Enabled = True
                    optHeatCtrlDAFutureTB.Enabled = True
                    optHeatCtrlDABaseUnit.Enabled = True
                    optHeatCtrlDAFieldInstTB.Enabled = True
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = False

                Else 'executes if no heat
                    optHeatCtrlNone.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = True

                End If

                'Handle GBAS Controls
                grpGBASCtrl4.Enabled = False
                optGBASNoGBAS.Checked = True
                chkGBASOADamper.Checked = False
                optNoGBASHeat.Checked = True

            End If
        Else

            'handle the cool options
            optCoolCtrlStagedOA.Enabled = False
            optCoolCtrlDAByFisen.Enabled = True
            optCoolCtrlByBaseUnit.Enabled = True
            optCoolCtrlGBAS.Enabled = False
            optCoolCtrlByBaseUnit.Checked = True



            'handle the heat options
            If optNoHeat.Checked Then
                optHeatCtrlDAByFisen.Enabled = False
                optHeatCtrlDABaseUnit.Enabled = False
                optHeatCtrlDAFieldInstTB.Enabled = False
                optHeatCtrlDAFutureTB.Enabled = False
                optHeatCtrlStagedOA.Enabled = False
                optHeatCtrlGBAS.Enabled = False
                optHeatCtrlNone.Enabled = True
                optHeatCtrlNone.Checked = True
            Else
                optHeatCtrlDAByFisen.Enabled = True
                optHeatCtrlDABaseUnit.Enabled = True
                optHeatCtrlDABaseUnit.Checked = True
                optHeatCtrlDAFieldInstTB.Enabled = True
                optHeatCtrlDAFutureTB.Enabled = True
                optHeatCtrlStagedOA.Enabled = False
                optHeatCtrlGBAS.Enabled = False
                optHeatCtrlNone.Enabled = False
            End If

            'Handle GBAS Controls
            grpGBASCtrl4.Enabled = False
            optGBASNoGBAS.Checked = True
            chkGBASOADamper.Checked = False
            optNoGBASHeat.Checked = True


        End If
    End Sub

    Private Sub optModeDATOnly_CheckedChanged(sender As Object, e As EventArgs) Handles optModeDATOnly.CheckedChanged
        If opt100OA.Checked Then
            If optModeDATOnly.Checked = True Then
                'handle the Zone Override Sensor
                chkZoneOvrSensor.Enabled = True
                chkZoneOvrSensor.Checked = False

                'handle the cooling controls
                optCoolCtrlStagedOA.Enabled = False
                optCoolCtrlDAByFisen.Enabled = True
                optCoolCtrlByBaseUnit.Checked = True
                optCoolCtrlByBaseUnit.Enabled = True
                optCoolCtrlGBAS.Enabled = False


                'handle the heating controls
                If Not (optNoHeat.Checked) Then 'Unit has heat
                    optHeatCtrlDAByFisen.Checked = True

                    optHeatCtrlStagedOA.Enabled = True
                    optHeatCtrlDAByFisen.Enabled = True
                    optHeatCtrlDAFutureTB.Enabled = True
                    optHeatCtrlDABaseUnit.Enabled = True
                    optHeatCtrlDAFieldInstTB.Enabled = True
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = False
                Else 'unit doesn't have heat
                    optHeatCtrlNone.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = True
                End If

                'handle the GBAS Controls
                grpGBASCtrl4.Enabled = False
                optGBASNoGBAS.Checked = True
                chkGBASOADamper.Checked = False
                optNoGBASHeat.Checked = True

            End If
        Else

        End If
    End Sub
    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "100OA"
        frmHistoryReport.cmbModCode.Text = "100OA"
        frmHistoryReport.Show()
    End Sub

    Private Sub WriteHistory()
        'updated to version 2.0 28 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim Controller, HeatType, HeatCtrl, CoolCtrl, ModeCtrl, ZoneOverride As String

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

        Controller = "Unselected"
        If optSE.Checked Then Controller = "SE"
        If optIPU.Checked Then Controller = "IPU"
        If optASE.Checked Then Controller = "ASE"

        'Set the heat type
        HeatType = "UnSelected"
        If optNoHeat.Checked Then HeatType = "None"
        If optHWHeat.Checked Then HeatType = "HotWater"
        If optSteamHeat.Checked Then HeatType = "Steam"
        If optEHeat.Checked Then HeatType = "Electric"
        If optGasHeat.Checked Then HeatType = "Gas"
        If optHeatcoGas.Checked Then HeatType = "HeatCo"

        HeatCtrl = "Unselected"
        If optHeatCtrlStagedOA.Checked Then HeatCtrl = "OAStaged"
        If optHeatCtrlDAByFisen.Checked Then HeatCtrl = "DATByFisen"
        If optHeatCtrlDAFutureTB.Checked Then HeatCtrl = "DATFutureHeat"
        If optHeatCtrlDABaseUnit.Checked Then HeatCtrl = "DATBaseUnit"
        If optHeatCtrlDAFieldInstTB.Checked Then HeatCtrl = "DATFieldInstalledHeat"
        If optHeatCtrlGBAS.Checked Then HeatCtrl = "GBAS"

        CoolCtrl = "Unselected"
        If optCoolCtrlStagedOA.Checked Then CoolCtrl = "OAStaged"
        If optCoolCtrlDAByFisen.Checked Then CoolCtrl = "DATByFisen"
        If optCoolCtrlByBaseUnit.Checked Then CoolCtrl = "DATBaseUnit"
        If optCoolCtrlGBAS.Checked Then CoolCtrl = "GBAS"

        ModeCtrl = "Unselected"
        If optModeAuto.Checked Then ModeCtrl = "Auto-OA"
        If optModeGBAS.Checked Then ModeCtrl = "GBAS"
        If optModeDATOnly.Checked Then ModeCtrl = "DATOnly"
        If optModeNoChange.Checked Then ModeCtrl = "No Change"

        If chkZoneOvrSensor.Checked Then
            ZoneOverride = "Yes"
        Else
            ZoneOverride = "No"
        End If

        MySQL = "Select * FROM tblHistory100OA WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistory100OA SET Controller='" & Controller & "', HeatType=" & HeatType & ", " & "HeatCtrl='" & HeatCtrl & "', CoolCtrl='" & CoolCtrl & "', ModeCtrl='" & ModeCtrl & "', ZoneOverride='" & ZoneOverride & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistory100OA (JobName,UnitID,Version,ModelNumber,Controller,HeatType,HeatCtrl,CoolCtrl,ModeCtrl,ZoneOverride) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & Controller & "','" & HeatType & "','" & HeatCtrl & "','" & CoolCtrl & "','" & ModeCtrl & "','" & ZoneOverride & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '0A0%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '0A0%'"
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

    Private Sub opt100OA_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OA.CheckedChanged
        If opt100OA.Checked Then
            optReturnBottom.Enabled = False
            optReturnHorizontal.Enabled = False
            optReturnNone.Enabled = True
            optReturnNone.Checked = True

            chkOADamperSwitch.Enabled = True
            chkOADamperSwitch.Enabled = False
            If Val(frmMain.ThisUnitSFanPerf.MotorHP) > 5.0 Then
                chkOADamperSwitch.Checked = True
            Else
                chkOADamperSwitch.Checked = False
            End If

            optModeAuto.Enabled = True
            optModeAuto.Checked = True
            optModeGBAS.Enabled = True
            optModeDATOnly.Enabled = True
            optModeNoChange.Enabled = True



        End If
    End Sub

    Private Sub opt100OACapable_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OACapable.CheckedChanged
        If opt100OACapable.Checked Then
            optReturnBottom.Enabled = True
            optReturnBottom.Checked = True
            optReturnHorizontal.Enabled = True
            optReturnNone.Enabled = False

            chkOADamperSwitch.Checked = False
            chkOADamperSwitch.Enabled = False
            If Val(frmMain.ThisUnitSFanPerf.MotorHP) > 5.0 Then
                chkOADamperSwitch.Checked = True
            Else
                chkOADamperSwitch.Checked = False
            End If

            optModeAuto.Enabled = True
            optModeGBAS.Enabled = True
            optModeDATOnly.Enabled = False
            optModeNoChange.Enabled = True
            optModeNoChange.Checked = True
        End If
    End Sub

    Private Sub optNoHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optNoHeat.CheckedChanged

        If optNoHeat.Checked Then
            chkModHeat.Checked = False
            chkModHeat.Enabled = False

            optHeatCtrlNone.Checked = True

            optHeatCtrlStagedOA.Enabled = False
            optHeatCtrlDAByFisen.Enabled = False
            optHeatCtrlDAFutureTB.Enabled = False
            optHeatCtrlDABaseUnit.Enabled = False
            optHeatCtrlDAFieldInstTB.Enabled = False
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = True

            optNoGBASHeat.Checked = True
        Else

        End If

    End Sub

    Private Sub optGasHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optGasHeat.CheckedChanged
        If optGasHeat.Checked = True Then
            chkModHeat.Enabled = True
            optHeatCtrlStagedOA.Checked = True

            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = False
        End If
    End Sub
    Private Sub optEHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optEHeat.CheckedChanged
        If optEHeat.Checked Then
            chkModHeat.Enabled = True
            optHeatCtrlStagedOA.Checked = True

            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = False
        End If
    End Sub

    Private Sub optHWHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optHWHeat.CheckedChanged
        If optHWHeat.Checked Then
            chkModHeat.Enabled = True
            optHeatCtrlStagedOA.Checked = True

            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = False
        End If
    End Sub

    Private Sub optSteamHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optSteamHeat.CheckedChanged
        If optSteamHeat.Checked Then
            chkModHeat.Enabled = True
            optHeatCtrlStagedOA.Checked = True

            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = False
        End If
    End Sub

    Private Sub optHeatcoGas_CheckedChanged(sender As Object, e As EventArgs) Handles optHeatcoGas.CheckedChanged
        If optHeatcoGas.Checked Then
            chkModHeat.Enabled = True
            optHeatCtrlStagedOA.Checked = True

            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlGBAS.Enabled = False
            optHeatCtrlNone.Enabled = False
        End If
    End Sub

    Private Sub optModeNoChange_CheckedChanged(sender As Object, e As EventArgs) Handles optModeNoChange.CheckedChanged
        If opt100OA.Checked Then
            If optModeNoChange.Checked = True Then
                'handle the Zone Override Sensor
                chkZoneOvrSensor.Enabled = False
                chkZoneOvrSensor.Checked = False

                'handle the cooling controls
                optCoolCtrlByBaseUnit.Checked = True

                optCoolCtrlStagedOA.Enabled = False
                optCoolCtrlDAByFisen.Enabled = False
                optCoolCtrlByBaseUnit.Enabled = True
                optCoolCtrlGBAS.Enabled = False

                'handle the heating controls
                If Not (optNoHeat.Checked) Then
                    optHeatCtrlDABaseUnit.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = True
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = False
                Else 'This executes if no heat unit
                    optHeatCtrlNone.Checked = True

                    optHeatCtrlStagedOA.Enabled = False
                    optHeatCtrlDAByFisen.Enabled = False
                    optHeatCtrlDAFutureTB.Enabled = False
                    optHeatCtrlDABaseUnit.Enabled = False
                    optHeatCtrlDAFieldInstTB.Enabled = False
                    optHeatCtrlGBAS.Enabled = False
                    optHeatCtrlNone.Enabled = True
                End If

                'handle the GBAS Controls
                grpGBASCtrl4.Enabled = False
                optGBASNoGBAS.Checked = True
                chkGBASOADamper.Checked = False
                optNoGBASHeat.Checked = True

            End If
        Else
            '100 OA Capable
            optCoolCtrlByBaseUnit.Enabled = True
            optCoolCtrlByBaseUnit.Checked = True
            optCoolCtrlStagedOA.Enabled = False
            optCoolCtrlDAByFisen.Enabled = False
            optCoolCtrlGBAS.Enabled = False

            optHeatCtrlDABaseUnit.Enabled = True
            optHeatCtrlDABaseUnit.Checked = True
            optHeatCtrlGBAS.Enabled = False
            If chkModHeat.Checked Then
                optHeatCtrlDAByFisen.Enabled = True
            Else
                optHeatCtrlDAByFisen.Enabled = False
            End If

        End If
    End Sub
End Class