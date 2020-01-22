Imports System.ComponentModel
Public Class frmMHGRH_Conv
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
        frmMain.ThisUnitMods.Add("MHGRH_Conv") 'Mod Code goes here!
        Call UpdateCodeList()
        Call UpdateBaseUnitRequiredItems
        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        frmMain.lstRequiredFactoryItems.Items.Add("Base Unit Comes with HGRH from JCI Factory")
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("725200") 'MHGRH Conv
        frmMain.ThisUnitCodes.Add("725201") 'JCI Installed Coil
        frmMain.ThisUnitCodes.Add("725202") 'Valves
        frmMain.ThisUnitCodes.Add("725203") 'Parallel Coil Config
        frmMain.ThisUnitCodes.Add("725207") 'Controls
        If optDHCompsByJCI.Checked = True Then
            frmMain.ThisUnitCodes.Add("725215") 'JCI SE Enables Compressors
        Else
            frmMain.ThisUnitCodes.Add("725210") 'GBAS Dehum Enable
        End If
        If optRHSATCtrl.Checked = True Then
            frmMain.ThisUnitCodes.Add("725220") 'HGRH SAT Control
        Else
            frmMain.ThisUnitCodes.Add("725225") 'HGRH GBAS Control
        End If
        If frmMain.ThisUnit.Family = "Series20" Then
            frmMain.ThisUnitCodes.Add("725240") 'HPCO Relocation
        End If
        If chkZTempReset.Checked = True Then frmMain.ThisUnitCodes.Add("725221")
        If chkFisenZoneHum.Checked = True Then frmMain.ThisUnitCodes.Add("725230")
        If chkFisenRAStat.Checked = True Then frmMain.ThisUnitCodes.Add("725230")
        If chkFisenZoneSensor.Checked = True Then frmMain.ThisUnitCodes.Add("725230")
        If chkFisenRASensor.Checked = True Then frmMain.ThisUnitCodes.Add("725230")

        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'Add Auxillary Panel if selected
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
            End Select
        End If

        frmMain.ThisUnit.CommNodes = "2"
        Call AssignReferSpecialties()
    End Sub
    Private Sub AssignReferSpecialties()
        Dim stub As String
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 2)
            Case Is = "Series10"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
            Case Is = "Series20"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)
        End Select
        Select Case stub
            Case Is = ""
                frmMain.ThisUnitReferSpecs.Add("")
            Case Is = "JA3ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "JA4ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "JA5ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J06ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J07ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J08ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J10ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J10ZT"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R5-02")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J12ZR"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J12ZT"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J15ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "J20ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("RVH615")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                frmMain.ThisUnitReferSpecs.Add("AW15502-650")
                frmMain.ThisUnitReferSpecsTag.Add("BHB1")
            Case Is = "J25ZR"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("RVH615")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                frmMain.ThisUnitReferSpecs.Add("AW15502-650")
                frmMain.ThisUnitReferSpecsTag.Add("BHB1")
            Case Is = "V2"
                frmMain.ThisUnitReferSpecs.Add("CDST-4")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "V3"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
            Case Is = "V4"
                frmMain.ThisUnitReferSpecs.Add("MTW-9")
                frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                frmMain.ThisUnitReferSpecs.Add("R6-04")
                frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
        End Select




    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True
        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MHGRH_Conv")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Hot Gas Reheat Conversion")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "115"
            Case Is = "Series10"
                tempWeight = "115"
            Case Is = "Series20"
                tempWeight = "100"
            Case Is = "Series40"
                'We should never execute this line!
                tempWeight = "-9999"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text
        frmMain.ThisUnitRHPerf.ControlType = "Modulating"
        frmMain.ThisUnitRHPerf.RHCapacity = txtHGRHCap.Text
        frmMain.ThisUnitRHPerf.RHAirflow = txtHGRHAFlow.Text
        frmMain.ThisUnitRHPerf.EAT = txtEATDB.Text
        frmMain.ThisUnitRHPerf.LAT = txtLAT.Text
        frmMain.ThisUnitRHPerf.DHCapacity = txtDehumCap.Text

    End Sub

    Private Sub frmMHGRH_Conv_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim temp As Double
        pCancelled = False

        temp = Val(frmMain.ThisUnit.NominalTons) / 2 * 12 * 1.25

        txtHGRHCap.Text = Format(temp, "0.0")

        If Val(frmMain.ThisUnitRHPerf.RHAirflow) > 0 Then
            txtHGRHAFlow.Text = frmMain.ThisUnitRHPerf.RHAirflow
        Else
            txtHGRHAFlow.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If

        txtEATDB.Text = frmMain.ThisUnitCoolPerf.LeavingDB

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
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
                 'Depricated *Probably not going to be used*
            Case Is = "Series100"

            Case Is = "Premier"

            Case Is = "Choice"

            Case Else

        End Select
        lstControlStyle.SelectedIndex = 0
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

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click

        txtDehumCap.Text = frmMain.ThisUnitRHPerf.DHCapacity

        txtLAT.Text = Format(Val(txtHGRHCap.Text) * 1000 / 1.085 / Val(txtHGRHAFlow.Text) + Val(txtEATDB.Text), "0.0")
            txtDeltaT.Text = Format(Val(txtHGRHCap.Text) * 1000 / 1.085 / Val(txtHGRHAFlow.Text), "0.0")

        If Val(txtLAT.Text) > 80 Then txtLAT.Text = "80.0"

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnDonePerformance.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub txtLAT_Leave(sender As Object, e As EventArgs) Handles txtLAT.Leave
        If Val(txtLAT.Text) > 80 Then txtLAT.Text = "80.0"
        txtDeltaT.Text = Format(Val(txtLAT.Text) - Val(txtEATDB.Text), "0.0")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub optRHGBAS_CheckedChanged(sender As Object, e As EventArgs) Handles optRHGBAS.CheckedChanged
        chkZTempReset.Enabled = optRHSATCtrl.Checked
        If optRHGBAS.Checked = True Then chkZTempReset.Checked = False
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub
End Class