Public Class frmFanVFD
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("FanVFD") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems
        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        If chkSFanVFD.Checked Then
            frmMain.lstRequiredFactoryItems.Items.Add("VAV (Customer Installed VFD)")
        End If
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("301100") 'Fan Variable Frequency Drive
        If chkSFanVFD.Checked Then
            frmMain.ThisUnitCodes.Add("301101") 'Supply Fan VFD Install
            If chkSFanBypass.Checked Then frmMain.ThisUnitCodes.Add("301102")
            If chkSFanBypass.Checked = False Then frmMain.ThisUnitCodes.Add("301150")
            If chkSFanDisconnect.Checked Then frmMain.ThisUnitCodes.Add("301103")
            If chkRemotePad.Checked Then frmMain.ThisUnitCodes.Add("301104")
            If chkSpecificVFD.Checked Then
                frmMain.ThisUnitCodes.Add("301105")
                Select Case cmbVFDBrand.Text
                    Case Is = "Danfoss VLT HVAC - FC 102"
                        frmMain.ThisUnitCodes.Add("301200")
                    Case Is = "ABB Eclipse"
                        frmMain.ThisUnitCodes.Add("301203")
                    Case Is = "Fisen Standard"
                        frmMain.ThisUnitCodes.Add("301202")
                    Case Is = "Rockwell Automation Power Flex 753"
                        frmMain.ThisUnitCodes.Add("301204")
                    Case Else
                        frmMain.ThisUnitCodes.Add("301202")
                End Select
            End If
            If chkBACnet.Checked Then
                frmMain.ThisUnitCodes.Add("301106")
                If cmbVFDBrand.Text = "Danfoss VLT HVAC - FC 102" Then
                    frmMain.ThisUnitCodes.Add("301201")
                End If
                frmMain.ThisUnit.CommNodes = "2"
            End If
            If chkNEMA4xDrive.Checked Then frmMain.ThisUnitCodes.Add("301109")
            If optSFanSEVFDReady.Checked Then frmMain.ThisUnitCodes.Add("301110")
            If optSFanFisenLCVAV.Checked Then frmMain.ThisUnitCodes.Add("301120")
            If optSFanSELCVAV.Checked Then frmMain.ThisUnitCodes.Add("301130")
            If optSFanBalanceOnly.Checked Then frmMain.ThisUnitCodes.Add("301125")
            If chk65kInstall.Checked Then frmMain.ThisUnitCodes.Add("301250")

        End If


        'use logic to step through the controls to determine the codes and use the above format...
        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If
    End Sub

    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.MotorTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("FanVFD")
        'Next Line is the line item description i.e. Hot Water Description
        tempWeight = "9999"
        If chkSFanVFD.Checked Then
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Supply Fan VFD")

            'Now it's logic to assign the values.
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    tempWeight = "25"
                    If chkSFanBypass.Checked Then tempWeight = "35"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Is = "Series10"
                    tempWeight = "30"
                    If chkSFanBypass.Checked Then tempWeight = "35"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 12)
                Case Is = "Series20"
                    tempWeight = "35"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Series40"
                    tempWeight = "40"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Series 100"
                    tempWeight = "65"
                    If chkSFanBypass.Checked Then tempWeight = "70"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 40)
                Case Else
                    tempWeight = "9999"
            End Select
        End If
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'There are no performance modifications related to this option
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub ChkSFanVFD_CheckedChanged(sender As Object, e As EventArgs) Handles chkSFanVFD.CheckedChanged
        If chkSFanVFD.Checked Then
            chkSFanBypass.Enabled = True
            chkSFanDisconnect.Enabled = True
        Else
            chkSFanBypass.Checked = False
            chkSFanDisconnect.Checked = False
            chkSFanBypass.Enabled = False
            chkSFanDisconnect.Enabled = False
        End If

    End Sub

    Private Sub chkSpecificVFD_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecificVFD.CheckedChanged
        If chkSpecificVFD.Checked Then
            cmbVFDBrand.Enabled = True
            cmbVFDBrand.Text = "Fisen Standard"
        Else
            cmbVFDBrand.Enabled = False
            cmbVFDBrand.Text = "Fisen Standard"
        End If
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

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

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
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

    Private Sub frmFanVFD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

        Call PopulateAuxPanelList()
        cmbVFDBrand.Text = "Fisen Standard"

    End Sub
End Class