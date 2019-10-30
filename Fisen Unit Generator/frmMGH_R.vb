Public Class frmMGH_R
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
        frmMain.ThisUnitMods.Add("MGH_R") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems
        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        frmMain.lstRequiredFactoryItems.Items.Add("Stainless Steel Heat Exchanger")
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("523100")
        frmMain.ThisUnitCodes.Add("523101")
        If optSATCtrl.Checked = True Then 'Normal SAT Controls
            frmMain.ThisUnitCodes.Add("523110")
            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    frmMain.ThisUnitCodes.Add("523112") 'SE 4Stage Board
                Else
                    frmMain.ThisUnitCodes.Add("523114") 'IPU
                End If
            Else 'This should mean S20, S10, S5
                frmMain.ThisUnitCodes.Add("523111") 'SE Single board
            End If

            If chkTempering.Checked = True Then
                frmMain.ThisUnitCodes.Add("523130")
                If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                    If optSE.Checked = True Then
                        frmMain.ThisUnitCodes.Add("523132") 'SE 4Stage Board
                    Else
                        frmMain.ThisUnitCodes.Add("523134") 'IPU
                    End If
                Else 'This should mean S20, S10, S5
                    frmMain.ThisUnitCodes.Add("523131") 'SE Single board
                End If

            End If

            If chkSATReset.Checked = True Then
                frmMain.ThisUnitCodes.Add("523135")
            End If
        End If

        If opt100OACtrls.Checked = True Then
            frmMain.ThisUnitCodes.Add("523140") '100% OA SAT Controls
            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    frmMain.ThisUnitCodes.Add("523143") 'SE 100% Outdoor Air
                Else
                    frmMain.ThisUnitCodes.Add("523145") 'IPU 100% Outdoor Air
                End If
            Else 'This should mean S20, S10, S5
                frmMain.ThisUnitCodes.Add("523143") 'SE Single board
            End If
        End If

        If optGBAS.Checked = True Then
            frmMain.ThisUnitCodes.Add("523120") 'GBAS Interface
        End If

        If optCustomCtrl.Checked Then
            frmMain.ThisUnitCodes.Add("523105")
            Select Case cmbCustomControls.Text
                Case Is = "IPU Enabled/Fisen Controlled Modulation"
                    frmMain.ThisUnitCodes.Add("523161")
            End Select

        End If

            Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                frmMain.ThisUnitCodes.Add("523150")
            Case Is = "Series10"
                frmMain.ThisUnitCodes.Add("523151")
            Case Is = "Series20"
                frmMain.ThisUnitCodes.Add("523152")
            Case Is = "Series40"
                frmMain.ThisUnitCodes.Add("523153")
            Case Is = "Series100"
                frmMain.ThisUnitCodes.Add("523154")
        End Select

        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        If chkPropane.Checked Then
            frmMain.ThisUnitCodes.Add("523999")
            frmMain.ThisUnitCodes.Add("523998")
        End If

        frmMain.ThisUnit.CommNodes = "2"
        'use logic to step through the controls to determine the codes and use the above format...

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
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MGH_R")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Gas Heat Retrofit")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "25"
            Case Is = "Series10"
                tempWeight = "25"
            Case Is = "Series20"
                tempWeight = "25"
            Case Is = "Series40"
                tempWeight = "35"
            Case Is = "Series100"
                tempWeight = "65"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.SSE = txtSSE.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"

    End Sub

    Private Sub frmMGH_R_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

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
        If frmMain.ThisUnit.Family = "Series100" Then optIPU.Enabled = True
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

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked = True Then
            chkTempering.Enabled = True
            If frmMain.ThisUnit.Family <> "Series40" Then
                chkSATReset.Enabled = True
            End If
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
            chkSATReset.Enabled = False
            chkSATReset.Checked = False
        End If

    End Sub

    Private Sub opt100OACtrls_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OACtrls.CheckedChanged

    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim temp As Double
        temp = Val(txtLAT.Text) - Val(txtEAT.Text)
        txtDeltaT.Text = Format(temp, "0.0")
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub optCustomCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optCustomCtrl.CheckedChanged
        If optCustomCtrl.Checked Then
            cmbCustomControls.Enabled = True
            cmbCustomControls.SelectedItem = 0
        Else
            cmbCustomControls.Enabled = False
        End If

    End Sub
End Class