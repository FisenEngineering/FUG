Imports System.ComponentModel
Public Class frm100OA
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
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("OA100") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("0A0100")
        frmMain.ThisUnitCodes.Add("0A0701")


        If opt100OACapable.Checked Then
            frmMain.ThisUnitCodes.Add("0A0105") '100% OA Capable

            frmMain.ThisUnitCodes.Add("0A0110") 'Modulating Damper
            frmMain.ThisUnitCodes.Add("0A0113")

            frmMain.ThisUnitCodes.Add("0A0130") 'Controls for 100% Outdoor Air Capable Unit
            frmMain.ThisUnitCodes.Add("0A0135")
            frmMain.ThisUnitCodes.Add("0A0140")
            frmMain.ThisUnitCodes.Add("0A0145")
            frmMain.ThisUnitCodes.Add("0A0150")

            If ((frmMain.ThisUnit.Family = "Series10") Or (frmMain.ThisUnit.Family = "Series20")) And optReturnHorizontal.Checked Then
                frmMain.ThisUnitCodes.Add("0A0550")
            End If
        Else
            frmMain.ThisUnitCodes.Add("0A0101") '100% Outdoor Air Conversion

            frmMain.ThisUnitCodes.Add("0A0111") 'Open/Closed Damper
            frmMain.ThisUnitCodes.Add("0A0112")
            frmMain.ThisUnitCodes.Add("0A0113")

            frmMain.ThisUnitCodes.Add("0A0119") 'Seal Existing Return Air Opening

            frmMain.ThisUnitCodes.Add("0A0120") 'Controls for 100% Outdoor Air Unit
        End If

        If opt100OA.Checked Then
            'Handle the Controls

            'mode controls
            If optModeAuto.Checked = True Then
                frmMain.ThisUnitCodes.Add("0A0123")
            End If
            If optModeGBAS.Checked = True Then
                frmMain.ThisUnitCodes.Add("0A0125")
            End If
            If optModeDATOnly.Checked = True Then
                frmMain.ThisUnitCodes.Add("0A0129")
            End If

            If optSE.Checked Then
                'handle the heating
                If optNoHeat.Checked Then
                    If optHeatCtrlDAFutureTB.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0160")
                    End If
                    If optHeatCtrlDAFieldInstTB.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0161")
                    End If
                End If
                If optEHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0183")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0193")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0173")
                    End If
                End If
                If optGasHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0180")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0190")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0170")
                    End If
                End If
                If optHeatcoGas.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0184")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0194")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0174")
                    End If
                End If
                If optHWHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0181")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0191")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0171")
                    End If
                End If
                If optSteamHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0182")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0192")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0172")
                    End If
                End If

                'This is the cooling for an SE Controller
                If optCoolCtrlStagedOA.Checked Then
                    frmMain.ThisUnitCodes.Add("0A0151")
                    'hande the HGRH Stuffs
                    If chkFisenHGRH.Checked And chkFisenMHGRH.Checked Then
                        If optSE.Checked Then
                            frmMain.ThisUnitCodes.Add("0A0381")
                        Else
                            frmMain.ThisUnitCodes.Add("0A0383")
                        End If
                    End If
                    If chkFisenHGRH.Checked And Not (chkFisenMHGRH.Checked) Then
                        If optSE.Checked Then
                            frmMain.ThisUnitCodes.Add("0A0380")
                        Else
                            frmMain.ThisUnitCodes.Add("0A0382")
                        End If
                    End If
                    'handle the zone override sensor
                    If chkZoneOvrSensor.Checked Then
                            frmMain.ThisUnitCodes.Add("0A0122")
                        End If
                    End If
                    If optCoolCtrlDAByFisenSE.Checked Then
                    frmMain.ThisUnitCodes.Add("0A0152")
                End If
                If optCoolCtrlGBAS.Checked Then

                End If
                If optCoolCtrlBySE.Checked Then
                    frmMain.ThisUnitCodes.Add("0A0153")
                End If
                If optCoolCtrlByIPU.Checked Then

                End If

                If chkIntellispeed.Checked Then
                    frmMain.ThisUnitCodes.Add("0A0370")
                End If

            Else
                'This is the heating for an IPU
                If optNoHeat.Checked Then
                    If optHeatCtrlDAFutureTB.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0260")
                    End If
                    If optHeatCtrlDAFieldInstTB.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0261")
                    End If
                End If
                If optEHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0283")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0293")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0273")
                    End If
                End If

                If optGasHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0280")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0290")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0270")
                    End If
                End If
                If optHeatcoGas.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0284")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0294")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0274")
                    End If
                End If
                If optHWHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0281")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0291")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0271")
                    End If
                End If
                If optSteamHeat.Checked Then
                    If optHeatCtrlDAByFisen.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0282")
                    End If
                    If optHeatCtrlDABaseUnit.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0292")
                    End If
                    If optHeatCtrlStagedOA.Checked Then
                        frmMain.ThisUnitCodes.Add("0A0272")
                    End If
                End If
                'This is the cooling for an IPU
                If optCoolCtrlStagedOA.Checked Then
                    frmMain.ThisUnitCodes.Add("0A0251")
                End If

                If optCoolCtrlGBAS.Checked Then

                End If
                If optCoolCtrlByIPU.Checked Then

                End If
            End If








            'handle the safeties
            If optSE.Checked Then 'handles the SE Controller
                frmMain.ThisUnitCodes.Add("0A0390")
                frmMain.ThisUnitCodes.Add("0A0391")
            Else 'now handle the ipu
                frmMain.ThisUnitCodes.Add("0A0399")
                frmMain.ThisUnitCodes.Add("0A0398")

            End If

        Else
            'This is the 100OA Capable section

        End If

        frmMain.ThisUnit.CommNodes = "2"


        'Every unit gets a touch??
        If frmMain.HasUMHMI = False Then
            frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
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
        Call PopulateAuxPanelList()

        If frmMain.ThisUnit.Family = "Series5" Then
            optUseAux.Checked = True
            optNoAux.Enabled = False
            optIPU.Enabled = False
        End If

        If frmMain.ThisUnit.Family = "Series10" Then
            optUseAux.Checked = True
            optNoAux.Enabled = False
            optIPU.Enabled = False
        End If

        If frmMain.ThisUnit.Family = "Series20" Then
            optIPU.Enabled = False
        End If

        If frmMain.ThisUnit.Family = "Series100" Then
            optIPU.Checked = True
        End If

        If ((InTheQueue("Reduced Air Flow") = True) Or (AlreadyDone("LowAF") = True)) Then
            chkLowAF.Checked = True
            chkLowAF.Enabled = False
        End If

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

    Private Sub optGasHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optGasHeat.CheckedChanged
        If optGasHeat.Checked = True Then
            chkModHeat.Enabled = True
        Else
            chkModHeat.Enabled = False
            chkModHeat.Checked = False
        End If
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

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optModeGBAS_CheckedChanged(sender As Object, e As EventArgs) Handles optModeGBAS.CheckedChanged
        If optModeGBAS.Checked = True Then
            optHeatCtrlGBAS.Checked = True
            optHeatCtrlGBAS.Enabled = True
            optHeatCtrlStagedOA.Enabled = False
            optHeatCtrlDAByFisen.enabled = False
            optHeatCtrlDAFutureTB.Enabled = False
            optHeatCtrlDAFieldInstTB.Enabled = False
            optHeatCtrlDABaseUnit.Enabled = False

            optCoolCtrlGBAS.Checked = True
            optCoolCtrlGBAS.Enabled = True
            optCoolCtrlStagedOA.Enabled = False
            optCoolCtrlBySE.Enabled = False
            optCoolCtrlByIPU.Enabled = False
            optCoolCtrlDAByFisenSE.Enabled = False

            optGBASVernier.Checked = True
            grpGBASCtrl4.Enabled = True


        End If
    End Sub

    Private Sub optModeAuto_CheckedChanged(sender As Object, e As EventArgs) Handles optModeAuto.CheckedChanged
        If optModeAuto.Checked = True Then

            optHeatCtrlStagedOA.Checked = True
            optHeatCtrlStagedOA.Enabled = True
            optHeatCtrlGBAS.Enabled = False

            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = True

            optCoolCtrlStagedOA.Checked = True
            optCoolCtrlStagedOA.Enabled = True
            optCoolCtrlBySE.Enabled = True
            optCoolCtrlByIPU.Enabled = True
            optCoolCtrlGBAS.Enabled = False
            optCoolCtrlDAByFisenSE.Enabled = True

            optGBASVernier.Checked = False
            optGBASFuture.Checked = False
            optGBAS3Level.Checked = False
            chkGBASOADamper.Checked = False
            grpGBASCtrl4.Enabled = False

        End If
    End Sub

    Private Sub optModeDATOnly_CheckedChanged(sender As Object, e As EventArgs) Handles optModeDATOnly.CheckedChanged
        If optModeDATOnly.Checked = True Then

            optHeatCtrlDAByFisen.Enabled = True
            optHeatCtrlDAByFisen.Checked = True

            optHeatCtrlStagedOA.Enabled = False
            optHeatCtrlDAFutureTB.Enabled = True
            optHeatCtrlDAFieldInstTB.Enabled = True
            optHeatCtrlDABaseUnit.Enabled = False
            optHeatCtrlGBAS.Enabled = False

            optCoolCtrlDAByFisenSE.Enabled = True
            optCoolCtrlDAByFisenSE.Checked = True

            optCoolCtrlStagedOA.Enabled = False
            optCoolCtrlBySE.Enabled = True
            optCoolCtrlByIPU.Enabled = True
            optCoolCtrlGBAS.Enabled = False


            optGBASVernier.Checked = False
            optGBASFuture.Checked = False
            optGBAS3Level.Checked = False
            chkGBASOADamper.Checked = False
            grpGBASCtrl4.Enabled = False
        End If
    End Sub

    Private Sub optEHeat_CheckedChanged(sender As Object, e As EventArgs) Handles optEHeat.CheckedChanged
        If optEHeat.Checked Then
            chkModEHeat.Enabled = True
        Else
            chkModEHeat.Enabled = False
            chkModEHeat.Checked = False
        End If
    End Sub

    Private Sub opt100OACapable_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OACapable.CheckedChanged
        If opt100OACapable.Checked Then
            grpReturn.Visible = True
            optReturnBottom.Checked = True
        Else
            grpReturn.Visible = False
            optReturnBottom.Checked = False
            optReturnHorizontal.Checked = False
        End If
    End Sub
End Class