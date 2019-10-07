Public Class frmMGH_H
    Private pCancelled As Boolean
    Private pmodweight As Integer

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


        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("MGH_H") 'Mod Code goes here!

        If chkIncludeEquipmentTouch.Checked Then
            frmMain.ThisUnit.GenCodesPresent = True
            If chkMountEquipmentTouch.Checked Then
                frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
            Else
                frmMain.ThisUnitGenCodes.Add("960001") 'Adds an HMI
            End If
        End If

            If frmMain.ThisUnit.Family = "Series10" Then
            frmMain.ThisUnitGenCodes.Add("960005") 'Adds a panel if it's a series 10
        End If
        frmMain.ThisUnit.CommNodes = "2"

        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems()
        Call UpdateWeightTable()
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        frmMain.ThisUnitCodes.Add("520000")
        frmMain.ThisUnitCodes.Add("520010")
        'Handle the Burner Counts

        If chkHMB600Burner.Checked Then
            If nudHMB600.Value = 6 Then
                frmMain.ThisUnitCodes.Add("520506")
                pmodweight = pmodweight + 285 * 6
            End If
            If nudHMB600.Value = 5 Then
                frmMain.ThisUnitCodes.Add("520505")
                pmodweight = pmodweight + 285 * 5
            End If
            If nudHMB600.Value = 4 Then
                frmMain.ThisUnitCodes.Add("520504")
                pmodweight = pmodweight + 285 * 4
            End If
            If nudHMB600.Value = 3 Then
                frmMain.ThisUnitCodes.Add("520503")
                pmodweight = pmodweight + 285 * 3
            End If
            If nudHMB600.Value = 2 Then
                frmMain.ThisUnitCodes.Add("520502")
                pmodweight = pmodweight + 285 * 2
            End If
            If nudHMB600.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520501")
                pmodweight = pmodweight + 285 * 1
            End If
        End If

        If chkHMB500Burner.Checked Then
            If nudHMB500.Value = 4 Then
                frmMain.ThisUnitCodes.Add("520514")
                pmodweight = pmodweight + 265 * 4
            End If
            If nudHMB500.Value = 3 Then
                frmMain.ThisUnitCodes.Add("520513")
                pmodweight = pmodweight + 265 * 3
            End If
            If nudHMB500.Value = 2 Then
                frmMain.ThisUnitCodes.Add("520512")
                pmodweight = pmodweight + 265 * 2
            End If
            If nudHMB500.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520511")
                pmodweight = pmodweight + 265 * 1
            End If
        End If
        If chkHMG500Burner.Checked Then
            If nudHMG500.Value = 4 Then
                frmMain.ThisUnitCodes.Add("520584")
                pmodweight = pmodweight + 265 * 4
            End If
            If nudHMG500.Value = 3 Then
                frmMain.ThisUnitCodes.Add("520583")
                pmodweight = pmodweight + 265 * 3
            End If
            If nudHMG500.Value = 2 Then
                frmMain.ThisUnitCodes.Add("520582")
                pmodweight = pmodweight + 265 * 2
            End If
            If nudHMG500.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520581")
                pmodweight = pmodweight + 265 * 1
            End If
        End If
        If chkHMB400Burner.Checked Then
            If nudHMB400.Value = 4 Then
                frmMain.ThisUnitCodes.Add("520524")
                pmodweight = pmodweight + 186 * 4
            End If
            If nudHMB400.Value = 3 Then
                frmMain.ThisUnitCodes.Add("520523")
                pmodweight = pmodweight + 186 * 3
            End If
            If nudHMB400.Value = 2 Then
                frmMain.ThisUnitCodes.Add("520522")
                pmodweight = pmodweight + 186 * 2
            End If
            If nudHMB400.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520521")
                pmodweight = pmodweight + 186 * 1
            End If
        End If
        If chkHMB300Burner.Checked Then
            If nudHMB300.Value = 4 Then
                frmMain.ThisUnitCodes.Add("520534")
                pmodweight = pmodweight + 170 * 4
            End If
            If nudHMB300.Value = 3 Then
                frmMain.ThisUnitCodes.Add("520533")
                pmodweight = pmodweight + 170 * 3
            End If
            If nudHMB300.Value = 2 Then
                frmMain.ThisUnitCodes.Add("520532")
                pmodweight = pmodweight + 170 * 2
            End If
            If nudHMB300.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520531")
                pmodweight = pmodweight + 170 * 1
            End If
        End If

        If chkHE750Burner.Checked Then
            If nudHE750.Value = 1 Then
                frmMain.ThisUnitCodes.Add("520601")
                pmodweight = pmodweight + 1237 * 1.15 * 1
            End If
        End If

        If chkHMB300Burner.Checked Or chkHMB400Burner.Checked Or chkHMB500Burner.Checked Or chkHMB600Burner.Checked Or chkHMG500Burner.Checked Then
            frmMain.ThisUnitCodes.Add("520500")
        End If

        If chkHE750Burner.Checked Then
            frmMain.ThisUnitCodes.Add("520600")
        End If

        'Handle the gas train
        frmMain.ThisUnitCodes.Add("520030")
        frmMain.ThisUnitCodes.Add("520031")
        frmMain.ThisUnitCodes.Add("520032")
        frmMain.ThisUnitCodes.Add("520033")
        frmMain.ThisUnitCodes.Add("520034")

        'handle the controls
        frmMain.ThisUnitCodes.Add("520101")
        If optSATCtrl.Checked Then
            If optSE.Checked Then
                frmMain.ThisUnitCodes.Add("520111")
                frmMain.ThisUnitCodes.Add("520113")
            End If
            If optIPU.Checked Then
                frmMain.ThisUnitCodes.Add("520110")
                frmMain.ThisUnitCodes.Add("520112")
            End If
            If chkTempering.Checked Then frmMain.ThisUnitCodes.Add("520115")

        End If
            If opt100OACtrls.Checked Then
            frmMain.ThisUnitCodes.Add("520120")
        End If
        If optCustomCtrl.Checked Then
            frmMain.ThisUnitCodes.Add("520105")
        End If
        If chkSupplyFanRelocate.Checked Then
            frmMain.ThisUnitCodes.Add("520900")
            frmMain.ThisUnitCodes.Add("520905")
        End If
        If chkGasTrainBumpout.Checked Then
            frmMain.ThisUnitCodes.Add("520910")
        End If

        If chkGasTrainRoofRaise.Checked Then
            frmMain.ThisUnitCodes.Add("520911")
        End If

        If chkBypassTunnel.Checked Then
            frmMain.ThisUnitCodes.Add("520920")
        End If

        If chkManualBalanceDamper.Checked Then
            frmMain.ThisUnitCodes.Add("520921")
        End If

        frmMain.ThisUnitCodes.Add("520199")
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        If optSE.Checked Then
            frmMain.lstRequiredFactoryItems.Items.Add("Unit Equipped with SE Controller")
        Else
            frmMain.lstRequiredFactoryItems.Items.Add("Unit Equipped with IPU Controller")
        End If
    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.GasTrainTest = True
        frmMain.ThisUnitWarrTest.GHeatTest = True
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MGH_H")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Gas Heat Heatco")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                If chkManualBalanceDamper.Checked Then
                    pmodweight = pmodweight + 25
                End If
                tempWeight = pmodweight + 115
            Case Is = "Series100"
                If chkManualBalanceDamper.Checked Then
                    pmodweight = pmodweight + 40
                End If
                tempWeight = pmodweight + 275
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim tempAPD As String
        Dim i As Integer

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.SSE = txtSSE.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"
        frmMain.ThisUnitHeatPerf.HeatType = "Gas"
        tempAPD = Format(Val(txtBurnerAPD.Text) * 1.1, "0.00")
        If frmMain.ThisUnit.Family = "Series100" Then
            frmMain.ThisUnitSFanPerf.StaticNameYpal.Add("Gas Heat Exchanger")
            frmMain.ThisUnitSFanPerf.StaticDataYpal.Add(tempAPD)
        End If
        frmMain.ThisUnitSFanPerf.ESP = frmMain.ThisUnitSFanPerf.ESP - (Val(tempAPD))

        For i = 0 To frmMain.ThisUnitSFanPerf.StaticNameYpal.Count - 1
            If frmMain.ThisUnitSFanPerf.StaticNameYpal(i) = "External Static Pressure" Then
                frmMain.ThisUnitSFanPerf.StaticDataYpal(i) = frmMain.ThisUnitSFanPerf.StaticDataYpal(i) - (Val(tempAPD))
                Exit For
            End If
        Next


    End Sub
    Private Sub frmMGH_H_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        pmodweight = 0

        If frmMain.ThisUnitHeatPerf.Airflow > 0 Then
            txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        Else
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtInputCap.Text = frmMain.ThisUnitHeatPerf.InputCapacity
        txtOutCap.Text = frmMain.ThisUnitHeatPerf.OutputCapacity
        txtSSE.Text = frmMain.ThisUnitHeatPerf.SSE
        txtLAT.Text = frmMain.ThisUnitHeatPerf.LeavingAirTemp
        txtDeltaT.Text = frmMain.ThisUnitHeatPerf.DeltaT
        If frmMain.ThisUnit.Family = "Series100" Then
            optIPU.Enabled = True
            optIPU.Checked = True
            optSE.Enabled = False

            chkIncludeEquipmentTouch.Checked = True
            chkMountEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Enabled = False

        End If
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim PerfGood As Boolean
        Dim dummy As MsgBoxResult

        PerfGood = True

        If Not (IsNumeric(txtHeatAF.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtEAT.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtInputCap.Text)) Then
            PerfGood = False
        End If

        txtSFanAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
        txtBurnerAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
        txtBypassAirflow.Text = "0"

        If PerfGood Then
            TabControl1.SelectedIndex = 1
        Else
            dummy = MsgBox("One or more of your inputs is invalid.")
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim deltat As Double

        txtSSE.Text = DetermineEfficiency()
        txtOutCap.Text = Format(Val(txtInputCap.Text) * Val(txtSSE.Text) / 100, "0.0")
        deltat = Val(txtOutCap.Text) * 1000 / Val(txtHeatAF.Text) / 1.085
        txtDeltaT.Text = Format(deltat, "0.0")
        txtLAT.Text = Format(Val(txtEAT.Text) + deltat, "0.0")
        cmdBurnerAPDCalc.PerformClick()
        TabControl1.SelectTab("tpgPerformance")

    End Sub

    Private Function DetermineEfficiency() As String
        Dim sse As String
        If chkHE750Burner.Checked Then sse = "80.0"
        If chkHMB300Burner.Checked Then sse = "80.0"
        If chkHMB400Burner.Checked Then sse = "80.0"
        If chkHMB500Burner.Checked Then sse = "80.0"
        If chkHMB600Burner.Checked Then sse = "80.0"
        If chkHMG500Burner.Checked Then sse = "80.0"

        Return sse
    End Function

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
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

    Private Sub chkHMB600Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB600Burner.CheckedChanged
        If chkHMB600Burner.Checked Then nudHMB600.Value = 1
    End Sub

    Private Sub nudHMB600_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB600.ValueChanged
        If nudHMB600.Value = 0 Then chkHMB600Burner.Checked = False Else chkHMB600Burner.Checked = True

    End Sub

    Private Sub chkHMB500Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB500Burner.CheckedChanged
        If chkHMB500Burner.Checked Then nudHMB500.Value = 1
    End Sub

    Private Sub nudHMB500_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB500.ValueChanged
        If nudHMB500.Value = 0 Then chkHMB500Burner.Checked = False Else chkHMB500Burner.Checked = True

    End Sub

    Private Sub chkHMB400Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB400Burner.CheckedChanged
        If chkHMB400Burner.Checked Then nudHMB400.Value = 1
    End Sub

    Private Sub nudHMB400_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB400.ValueChanged
        If nudHMB400.Value = 0 Then chkHMB400Burner.Checked = False Else chkHMB400Burner.Checked = True

    End Sub
    Private Sub chkHMB300Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHMB300Burner.CheckedChanged
        If chkHMB300Burner.Checked Then nudHMB300.Value = 1
    End Sub

    Private Sub nudHMB300_ValueChanged(sender As Object, e As EventArgs) Handles nudHMB300.ValueChanged
        If nudHMB300.Value = 0 Then chkHMB300Burner.Checked = False Else chkHMB300Burner.Checked = True

    End Sub

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked Then
            chkTempering.Enabled = True
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
        End If
    End Sub

    Private Sub ChkHE750Burner_CheckedChanged(sender As Object, e As EventArgs) Handles chkHE750Burner.CheckedChanged
        If chkHE750Burner.Checked Then
            nudHE750.Value = 1
        Else
            nudHE750.Value = 0
        End If
    End Sub

    Private Sub OptSE_CheckedChanged(sender As Object, e As EventArgs) Handles optSE.CheckedChanged
        If optIPU.Checked Then
            optSATCtrl.Enabled = True
            optSATCtrl.Checked = True
            chkTempering.Checked = False
            chkTempering.Enabled = True
            opt100OACtrls.Enabled = True
            optGBAS.Enabled = True
            optCustomCtrl.Enabled = True
        End If
    End Sub

    Private Sub OptIPU_CheckedChanged(sender As Object, e As EventArgs) Handles optIPU.CheckedChanged
        If optIPU.Checked Then
            optSATCtrl.Enabled = True
            optSATCtrl.Checked = True
            chkTempering.Checked = False
            chkTempering.Enabled = False
            opt100OACtrls.Enabled = False
            optGBAS.Enabled = False
            optCustomCtrl.Enabled = False
        End If
    End Sub

    Private Sub ChkBypassTunnel_CheckedChanged(sender As Object, e As EventArgs) Handles chkBypassTunnel.CheckedChanged
        If chkBypassTunnel.Checked Then
            chkManualBalanceDamper.Enabled = True
        Else
            chkManualBalanceDamper.Enabled = False
            chkManualBalanceDamper.Checked = False
        End If
    End Sub

    Private Sub CmdBurnerAPDCalc_Click(sender As Object, e As EventArgs) Handles cmdBurnerAPDCalc.Click
        Dim BurnerAPD As Double
        Dim FirstAPD As Double
        Dim airflow As Double

        airflow = Val(txtBurnerAirflow.Text)
        BurnerAPD = "0.0"
        If chkHE750Burner.Checked Then
            FirstAPD = 0.000000002752976 * Airflow ^ 2 - 0.000005919642857 * airflow + 0.009409077380961
            cmdBurnerAPDCalc.Enabled = True
        End If

        BurnerAPD = FirstAPD
        txtBurnerAPD.Text = Format(BurnerAPD, "0.00")
        txtBypassAirflow.Text = Str(Val(txtSFanAirflow.Text) - Val(txtBurnerAirflow.Text))
    End Sub
End Class