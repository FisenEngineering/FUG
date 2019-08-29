Public Class frmMEHeat_R
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        txtDeltaT.Text = Format(Val(txtOutCap.Text) * 1000 / 1.085 / Val(txtHeatAF.Text), "0.0")
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub frmMEHeat_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.ThisUnitHeatPerf.Airflow > 0 Then
            txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        Else
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtOutCap.Text = frmMain.ThisUnitHeatPerf.OutputCapacity
        txtLAT.Text = frmMain.ThisUnitHeatPerf.LeavingAirTemp
        txtDeltaT.Text = frmMain.ThisUnitHeatPerf.DeltaT
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("MEHeat_R") 'Mod Code goes here!
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        'frmMain.ThisUnit.GenCodesPresent = True
        'frmMain.ThisUnitMods.Add("Common")
        'End If
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("501100")
        If chkFisenInstallsJCI.Checked Then frmMain.ThisUnitCodes.Add("501101")
        If optFisenSCR.Checked Then
            frmMain.ThisUnitCodes.Add("501105") 'Fisen SCR
        Else
            frmMain.ThisUnitCodes.Add("501110") 'Field SCR
        End If

        'now the controls
        frmMain.ThisUnitCodes.Add("501120")

        If optCustomCtrl.Checked Then
            frmMain.ThisUnitCodes.Add("501140")
        End If

        If optSATCtrl.Checked = True Then 'Normal SAT Controls

            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    frmMain.ThisUnitCodes.Add("501125") 'SE 4Stage Board
                Else
                    frmMain.ThisUnitCodes.Add("501128") 'IPU
                End If
            Else 'This should mean S20, S10, S5
                frmMain.ThisUnitCodes.Add("501121") 'SE Single board
            End If

            If chkTempering.Checked = True Then
                frmMain.ThisUnitCodes.Add("501126")
                If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                    If optSE.Checked = True Then
                        frmMain.ThisUnitCodes.Add("501127") 'SE 4Stage Board
                    Else
                        frmMain.ThisUnitCodes.Add("501129") 'IPU
                    End If
                Else 'This should mean S20, S10, S5
                    frmMain.ThisUnitCodes.Add("501131") 'SE Single board
                End If

            End If
        End If

        If opt100OACtrls.Checked = True Then

            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    frmMain.ThisUnitCodes.Add("501136") 'SE 100% Outdoor Air
                Else
                    frmMain.ThisUnitCodes.Add("501137") 'IPU 100% Outdoor Air
                End If
            Else 'This should mean S20, S10, S5
                frmMain.ThisUnitCodes.Add("501138") 'SE Single board
            End If
        End If

        If opt100OACapable.Checked Then
            frmMain.ThisUnitCodes.Add("501151")
            If ((frmMain.ThisUnit.Family = "Series40") Or (frmMain.ThisUnit.Family = "Series100")) Then
                If optSE.Checked = True Then
                    frmMain.ThisUnitCodes.Add("501153") 'SE 100% Outdoor Air Capable four stage board

                Else
                    frmMain.ThisUnitCodes.Add("501154") 'IPU 100% Outdoor Air Capable
                End If
            Else 'This should mean S20, S10, S5
                frmMain.ThisUnitCodes.Add("501152") 'SE Single board
            End If
        End If

        If optGBAS.Checked = True Then
            frmMain.ThisUnitCodes.Add("501130") 'GBAS Interface
        End If

        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                If frmMain.HasUMHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
                End If

            Else
                If frmMain.HasHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960001")
                End If
            End If
        End If

        frmMain.ThisUnit.CommNodes = "2"
        'use logic to step through the controls to determine the codes and use the above format...
    End Sub
    Private Sub UpdatePerformance()

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"

    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        frmMain.lstRequiredFactoryItems.Items.Add("Base Unit has Factory Electric Heat?")
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MEHeat_R")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Electric Heat Retrofit")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "30"
            Case Is = "Series10"
                tempWeight = "30"
            Case Is = "Series20"
                tempWeight = "20"
            Case Is = "Series40"
                tempWeight = "20"
            Case Is = "Series 100"
                tempWeight = "30"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.EHeatTest = True
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub opt100OACtrls_CheckedChanged(sender As Object, e As EventArgs) Handles opt100OACtrls.CheckedChanged

    End Sub

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked = True Then
            chkTempering.Enabled = True
            chkTempering.Checked = True
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
        End If
    End Sub
End Class