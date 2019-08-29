Public Class frmLCVAV
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
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("LCVAV") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        'There is no performance to update for this modification
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("315000")
        If chkECMotorStaging.Checked Then
            frmMain.ThisUnitCodes.Add("315310") 'EC Motor Staging
        End If
        If optSEVAV.Checked Then
            frmMain.ThisUnitCodes.Add("315100") 'SE Controller LCVAV
            frmMain.ThisUnitCodes.Add("315105") 'Utilize Existing SE Controller
            If chkIntellispeed.Checked = True Then
                frmMain.ThisUnitCodes.Add("315130")
            Else
                frmMain.ThisUnitCodes.Add("315110") 'Supply Air Temperature Controls by SE Controller 
                frmMain.ThisUnitCodes.Add("315115") 'MWU/DWU Controls by SE Controller
                frmMain.ThisUnitCodes.Add("315120") 'Duct Static Pressure Controls by SE Controller
                frmMain.ThisUnitCodes.Add("315121") 'Fisen Provided and Installed Duct Static Pressure Sensor
            End If
            If chkUnitisHeatPump.Checked Then frmMain.ThisUnitCodes.Add("315122") 'High Speed Fan in Heat Relay
            If chkHSFaninRH.Checked Then frmMain.ThisUnitCodes.Add("315123") 'High Speed Fan in Reheat Mode

        Else
            frmMain.ThisUnitCodes.Add("315200") 'Fisen Controller LCVAV

            If chkFisenSATCtrl.Checked Then
                frmMain.ThisUnitCodes.Add("315210")
            End If
            If chkFisenDSPCtrl.Checked Then
                frmMain.ThisUnitCodes.Add("315220")
                frmMain.ThisUnitCodes.Add("315221")
            End If
            If chkFisenMWUCtrl.Checked Then
                frmMain.ThisUnitCodes.Add("315215")
            End If
            frmMain.ThisUnit.CommNodes = "2"
        End If

        If optSEVAV.Checked Then
            frmMain.ThisUnitGenCodes.Add("960009") 'Add the board with VAV terminals.
        End If

        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                If frmMain.HasUMHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
                End If
            Else
                If frmMain.HasHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960001") 'Adds an HMI
                End If
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

    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub

    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("LCVAV")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Light Commercial VAV Conversion")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "12"
            Case Is = "Series10"
                tempWeight = "12"
            Case Is = "Series20"
                tempWeight = "13"
            Case Is = "Series40"
                tempWeight = "14"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        If optDrivebyFisen.Checked Then
            If ((InTheQueue("Fan VFD") = False) And (AlreadyDone("FanVFD") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Fan VFD")
            End If
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub optFisenVAV_CheckedChanged(sender As Object, e As EventArgs) Handles optFisenVAV.CheckedChanged
        If optFisenVAV.Checked = True Then
            chkFisenDSPCtrl.Enabled = True
            chkFisenMWUCtrl.Enabled = True
            chkFisenSATCtrl.Enabled = True
        Else
            chkFisenDSPCtrl.Enabled = False
            chkFisenMWUCtrl.Enabled = False
            chkFisenSATCtrl.Enabled = False
            chkFisenDSPCtrl.Checked = False
            chkFisenMWUCtrl.Checked = False
            chkFisenSATCtrl.Checked = False
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub frmLCVAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateAuxPanelList()
        If frmMain.ThisUnit.Family = "Series5" Then
            optUseAux.Checked = True
        End If

        If frmMain.ThisUnit.Family = "Series10" Then
            optUseAux.Checked = True

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

    Private Sub optJustECMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optJustECMotor.CheckedChanged
        If optJustECMotor.Checked Then
            chkECMotorStaging.Checked = True
            chkECMotorStaging.Enabled = False
        End If
    End Sub
    Private Sub PresentDesignCautions()
        Dim LocalFamily As String

        LocalFamily = frmMain.ThisUnit.Family

        Select Case LocalFamily
            Case Is = "Series5"

        End Select
    End Sub
End Class