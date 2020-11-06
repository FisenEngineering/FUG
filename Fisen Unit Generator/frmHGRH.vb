Public Class frmHGRH
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub frmHGRH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
        Call LoadConditions()
        txtDehumCap.Text = Format(psyDehumCapacity(frmMain.ThisUnitCoolPerf.EnteringDB, frmMain.ThisUnitCoolPerf.EnteringWB, frmMain.ThisUnitCoolPerf.LeavingDB, frmMain.ThisUnitCoolPerf.LeavingWB, frmMain.ThisUnitSFanPerf.Airflow), "0.0")
        If frmMain.ThisUnit.Family = "Select" Then
            chkSelectHGRH.Visible = True
        End If
    End Sub
    Private Sub LoadConditions()
        Dim temp As Double
        Dim tempapd As Double
        Dim tempaf As Double
        Dim temptons As String
        Dim divisor As Integer

        divisor = 1
        If frmMain.ThisUnit.Family = "Series40" Then
            divisor = 4 / nudCircuitsofRH.Value
        End If
        If frmMain.ThisUnit.Family = "Series20" Then
            divisor = 2 / nudCircuitsofRH.Value
        End If
        If frmMain.ThisUnit.Family = "Series10" Then
            divisor = 2 / nudCircuitsofRH.Value
        End If

        temp = Val(frmMain.ThisUnit.NominalTons) / divisor * 12 * 1.25
        If Val(frmMain.ThisUnitRHPerf.RHCapacity) > 0 Then
            txtHGRHCap.Text = frmMain.ThisUnitRHPerf.RHCapacity
        Else
            txtHGRHCap.Text = Format(temp, "0.0")
        End If
        If Val(frmMain.ThisUnitRHPerf.RHAirflow) > 0 Then
            txtHGRHAFlow.Text = frmMain.ThisUnitRHPerf.RHAirflow

        Else
            txtHGRHAFlow.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        If Val(frmMain.ThisUnitRHPerf.EAT) > 1 Then
            txtEATDB.Text = frmMain.ThisUnitRHPerf.EAT
        Else
            txtEATDB.Text = frmMain.ThisUnitCoolPerf.LeavingDB
        End If

        tempaf = Val(frmMain.ThisUnitSFanPerf.Airflow)
        temptons = frmMain.ThisUnit.NominalTons

        Select Case frmMain.ThisUnit.Family

            Case Is = "Series40"
                If nudCircuitsofRH.Value = 1 Then

                    Select Case frmMain.ThisUnit.NominalTons
                        Case Is = "25.0"
                            tempapd = 0.000012 * tempaf - 0.04
                        Case Is = "30.0"
                            tempapd = 0.000000000556 * tempaf * tempaf + 0.000001666667 * tempaf - 0.000000000000
                        Case Is = "40.0"
                            tempapd = 0.000000000625 * tempaf * tempaf - 0.000005 * tempaf + 0.06
                    End Select
                Else
                    Select Case frmMain.ThisUnit.NominalTons
                        Case Is = "25.0"
                            tempapd = 0.0000000008 * tempaf * tempaf + 0.000014 * tempaf - 0.04
                        Case Is = "30.0"
                            tempapd = 0.000000001111 * tempaf * tempaf + 0.000006666667 * tempaf - 0.000000000000
                        Case Is = "40.0"
                            tempapd = 0.000000000313 * tempaf * tempaf + 0.00002375 * tempaf - 0.13
                    End Select
                End If
            Case Else
                If nudCircuitsofRH.Value = 1 Then
                    tempapd = "0.20"
                Else
                    tempapd = "0.40"
                End If
        End Select
        txtRHCoilAPD.Text = Format(tempapd, "0.00")
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("HGRH") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        Dim esp As Double
        Dim coilapd As Double

        frmMain.ThisUnitRHPerf.LAT = txtLAT.Text
        frmMain.ThisUnitRHPerf.DHCapacity = txtDehumCap.Text
        frmMain.ThisUnitRHPerf.RHCapacity = txtHGRHCap.Text
        frmMain.ThisUnitRHPerf.EAT = txtEATDB.Text
        frmMain.ThisUnitRHPerf.RHAirflow = txtHGRHAFlow.Text
        frmMain.ThisUnitRHPerf.CircuitsRH = nudCircuitsofRH.Value
        frmMain.ThisUnitRHPerf.ControlType = "On/Off"
        If chkSelectHGRH.Checked Then frmMain.ThisUnitRHPerf.ControlType = "Modulating"
        If chkModulatingCtrl.Checked Then
            frmMain.ThisUnitRHPerf.ControlType = "Modulating"
        End If
        If optSeriesPiping.Checked Then
            frmMain.ThisUnitRHPerf.PipingStyle = "Series"
        Else
            frmMain.ThisUnitRHPerf.PipingStyle = "Parallel"
        End If
        esp = Val(frmMain.ThisUnitSFanPerf.ESP)
        coilapd = Val(txtRHCoilAPD.Text)
        esp = esp - coilapd
        frmMain.ThisUnitSFanPerf.ESP = Format(esp, "0.00")
        frmMain.ThisUnitRHPerf.CoilAPD = Format(coilapd, "0.00")
        frmMain.ThisUnitRHPerf.DHCapacity = txtDehumCap.Text

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HGRH")

        'Next Line is the line item description i.e. Hot Water Description

        If chkModulatingCtrl.Checked Then
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Hot Gas Reheat")
        Else
            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Gas Reheat")
        End If
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "160"
            Case Is = "Series10"
                If nudCircuitsofRH.Value = 1 Then
                    tempWeight = "160"
                Else
                    tempWeight = "260"
                End If
            Case Is = "Series20"
                If nudCircuitsofRH.Value = 1 Then
                    tempWeight = "210"
                Else
                    tempWeight = "290"
                End If
            Case Is = "Series40"
                If nudCircuitsofRH.Value = 1 Then
                    tempWeight = "185"
                Else
                    tempWeight = "350"
                End If
            Case Is = "Series 100"
                If nudCircuitsofRH.Value = 1 Then
                    tempWeight = "365"
                Else
                    tempWeight = "720"
                End If
            Case Else
                tempWeight = "9999"
        End Select
        If chkSelectHGRH.Checked Then tempWeight = "0"
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True
        frmMain.ThisUnitWarrTest.CoilTest = True

    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code(s)

        frmMain.ThisUnitCodes.Add("720500") 'Hot Gas Reheat
        If chkSelectHGRH.Checked Then
            frmMain.ThisUnitCodes.Add("720ZZ0") 'Hot Gas Reheat for select units.
        Else


            If nudCircuitsofRH.Value = 1 Then
                If Not (chkECoat.Checked) Then
                    frmMain.ThisUnitCodes.Add("720501") '1 Circuit HGRH Coil
                Else
                    frmMain.ThisUnitCodes.Add("720581") '1 Circuit HGRH Coil
                End If
                frmMain.ThisUnitCodes.Add("720511") 'Circuit of HGRH

            Else
                If Not (chkECoat.Checked) Then
                    frmMain.ThisUnitCodes.Add("720502") '1 Circuit HGRH Coil
                Else
                    frmMain.ThisUnitCodes.Add("720582") '1 Circuit HGRH Coil
                End If
                frmMain.ThisUnitCodes.Add("720510") '2 circuits of reheat
            End If
            If Not (chkModulatingCtrl.Checked) Then
                frmMain.ThisUnitCodes.Add("720503") ' On Off Hot Gas reheat valves 3-way
            Else
                frmMain.ThisUnitCodes.Add("720535") 'Modulating reheat valves
                If nudCircuitsofRH.Value = 2 Then
                    frmMain.ThisUnitCodes.Add("720536") 'Second circuit on off valves.
                End If
            End If

            If optParallelPiping.Checked = True Then
                frmMain.ThisUnitCodes.Add("720504")
            Else
                frmMain.ThisUnitCodes.Add("720505")
            End If

            frmMain.ThisUnitCodes.Add("720506") 'Hot Gas Reheat Controls
            If (chkModulatingCtrl.Checked) Then
                frmMain.ThisUnitCodes.Add("720537") 'Modulating Hot Gas Reheat Controls
            End If

            'Handle the compressor controls
            If optSE.Checked = True Then
                'SE Controller
                If optDHCompsByJCI.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720512") 'SE Controller handles enabling the compressors
                End If
                If optDHGBASEnab.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720509") 'SE Conroller based, GBAS compressor SS
                End If
                If optDHThermostat.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720514") 'SE Controller based, Thermostat Control for Compressor SS
                End If
                If optMODBUSDH.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720544") 'SE Controller MODBUS
                End If
            Else
                'IPU Controller
                If optDHCompsByJCI.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720513") 'IPU Controller handles enabling the compressors
                End If
                If optDHGBASEnab.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720516") 'IPU Conroller based, GBAS compressor SS
                End If
                If optDHThermostat.Checked = True Then
                    frmMain.ThisUnitCodes.Add("720515") 'IPU Controller based, Thermostat Control for Compressor SS
                End If
            End If

            'handle the reheat controls
            If optTempPriority.Checked Then
                frmMain.ThisUnitCodes.Add("720507") 'Temperature Priority Reheat Controls
            End If
            If optHumPriority.Checked Then
                frmMain.ThisUnitCodes.Add("720508") 'Humidity Priority Reheat Controls
            End If
            If optMODBUSRH.Checked Then
                frmMain.ThisUnitCodes.Add("720545") 'Modbus control of reheat
            End If

            If nudCircuitsofRH.Value = 1 Then
                If optRHGBAS.Checked Then
                    frmMain.ThisUnitCodes.Add("720518")
                End If
                If ((optRHNetworkOnly.Checked) And (optDHCompsByJCI.Checked)) Then
                    frmMain.ThisUnitCodes.Add("720519")
                End If
            Else
                If optRHGBAS.Checked Then
                    frmMain.ThisUnitCodes.Add("720538")
                End If
                If ((optRHNetworkOnly.Checked) And (optDHCompsByJCI.Checked)) Then
                    frmMain.ThisUnitCodes.Add("720543")
                End If
            End If

            If opt100OARH.Checked Then
                frmMain.ThisUnitCodes.Add("720520")
            End If

            If (chkModulatingCtrl.Checked) Then
                If ((optTempPriority.Checked) Or (optHumPriority.Checked) Or (opt100OARH.Checked)) Then
                    frmMain.ThisUnitCodes.Add("720517") 'SAT for MHGRH
                Else
                    If optRHGBAS.Checked Then
                        frmMain.ThisUnitCodes.Add("720539")
                        frmMain.ThisUnitCodes.Add("720540")
                    Else
                        frmMain.ThisUnitCodes.Add("720541")
                        frmMain.ThisUnitCodes.Add("720542")
                    End If
                End If
            End If

            If optFisenZoneHum.Checked = True Then
                frmMain.ThisUnitCodes.Add("720521")
            End If
            If optFisenRAStat.Checked = True Then
                frmMain.ThisUnitCodes.Add("720522")
            End If
            If optFisenZoneSensor.Checked = True Then
                frmMain.ThisUnitCodes.Add("720523")
            End If
            If optFisenRASensor.Checked = True Then
                frmMain.ThisUnitCodes.Add("720524")
            End If

            If optFieldStat.Checked = True Then
                frmMain.ThisUnitCodes.Add("720599")
            End If

            If Not (optRHNetworkOnly.Checked) Then
                If ((optRHGBAS.Checked = True) And (chkModulatingCtrl.Checked = False) And (nudCircuitsofRH.Value = 2)) Then
                    frmMain.ThisUnitCodes.Add("720526") '2 rh pairs.
                Else
                    If ((chkModulatingCtrl.Checked) And optRHGBAS.Checked) Then
                        frmMain.ThisUnitCodes.Add("720527") '1 rh pair and 1level pair
                    Else
                        If nudCircuitsofRH.Value = 2 Then
                            frmMain.ThisUnitCodes.Add("720526") '2 rh pair
                        Else
                            frmMain.ThisUnitCodes.Add("720525") '1 rh pair
                        End If
                    End If
                End If
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

            If chkModbusPoints.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960004")
            End If

            frmMain.ThisUnit.CommNodes = "2"
            Call AssignReferSpecialties()
        End If
    End Sub
    Private Sub AssignReferSpecialties()
        Dim stub As String
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                stub = Mid(frmMain.ThisUnit.ModelNumber, 1, 2)
        End Select
        Select Case stub
            Case Is = "V2"
                'Handle the first circuit
                If chkModulatingCtrl.Checked = True Then
                    frmMain.ThisUnitReferSpecs.Add("CDST-4")
                    frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R6-04")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                Else
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                End If

                If nudCircuitsofRH.Value = 2 Then
                    'Handle the second circuit
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-2")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR2")
                End If
            Case Is = "V3"
                'Handle the first circuit
                If chkModulatingCtrl.Checked = True Then
                    frmMain.ThisUnitReferSpecs.Add("MTW-9")
                    frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R6-04")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                Else
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                End If
                If nudCircuitsofRH.Value = 2 Then
                    'Handle the second circuit
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-2")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR2")
                End If
            Case Is = "V4"
                'Handle the first circuit
                If chkModulatingCtrl.Checked = True Then
                    frmMain.ThisUnitReferSpecs.Add("MTW-9")
                    frmMain.ThisUnitReferSpecsTag.Add("MTWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R6-04")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                Else
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-1")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR1")
                End If
                If nudCircuitsofRH.Value = 2 Then
                    'Handle the second circuit
                    frmMain.ThisUnitReferSpecs.Add("8D7B-HP")
                    frmMain.ThisUnitReferSpecsTag.Add("TWV-2")
                    frmMain.ThisUnitReferSpecs.Add("R5-02")
                    frmMain.ThisUnitReferSpecsTag.Add("RCVR2")
                End If
        End Select




    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim PerfGood As Boolean
        Dim dummy As MsgBoxResult

        PerfGood = True

        If Not (IsNumeric(txtHGRHCap.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtHGRHAFlow.Text)) Then
            PerfGood = False
        End If

        If Not (IsNumeric(txtEATDB.Text)) Then
            PerfGood = False
        End If

        If PerfGood Then
            TabControl1.SelectedIndex = 1
            TabControl1.SelectTab("tpgOptions")
        Else
            dummy = MsgBox("One or more of your inputs is invalid.")
        End If

    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        Dim temp As Double

        TabControl1.SelectTab("tpgControls")

        temp = Val(txtHGRHCap.Text) * 1000 / 1.085 / Val(txtHGRHAFlow.Text) + Val(txtEATDB.Text)
        If temp < 80 Then
            txtLAT.Text = Format(temp, "0.0")
            optParallelPiping.Checked = True
        Else
            txtLAT.Text = "80.0"
            temp = 80
            optSeriesPiping.Checked = True
        End If
        txtDeltaT.Text = Format(Val(txtLAT.Text) - Val(txtEATDB.Text), "0.0")
        txtDehumCap.Text = "-"

    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")

    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnDonePerf.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub nudCircuitsofRH_ValueChanged(sender As Object, e As EventArgs) Handles nudCircuitsofRH.ValueChanged
        Call LoadConditions()
    End Sub

    Private Sub chkModulatingCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles chkModulatingCtrl.CheckedChanged
        If chkModulatingCtrl.Checked = True Then
            optParallelPiping.Checked = True
            optSeriesPiping.Enabled = False
        Else
            optSeriesPiping.Enabled = True
        End If
    End Sub

    Private Sub optDHCompsByJCI_CheckedChanged(sender As Object, e As EventArgs) Handles optDHCompsByJCI.CheckedChanged
        If optDHCompsByJCI.Checked Then
            optTempPriority.Enabled = False
            optHumPriority.Enabled = False
            optMODBUSRH.Enabled = False
            optRHGBAS.Enabled = True
            optRHNetworkOnly.Enabled = True
            opt100OARH.Enabled = False
            optRHGBAS.Checked = True
        End If
    End Sub

    Private Sub optDHGBASEnab_CheckedChanged(sender As Object, e As EventArgs) Handles optDHGBASEnab.CheckedChanged
        If optDHGBASEnab.Checked Then
            optTempPriority.Enabled = False
            optHumPriority.Enabled = False
            optMODBUSRH.Enabled = False
            optRHGBAS.Enabled = True
            optRHNetworkOnly.Enabled = True
            opt100OARH.Enabled = False
            optRHGBAS.Checked = True
        End If
    End Sub

    Private Sub optDHThermostat_CheckedChanged(sender As Object, e As EventArgs) Handles optDHThermostat.CheckedChanged
        If optDHThermostat.Checked Then
            optTempPriority.Enabled = True
            optHumPriority.Enabled = True
            optRHGBAS.Enabled = False
            optRHNetworkOnly.Enabled = False
            opt100OARH.Enabled = True
            optTempPriority.Checked = True
        End If
    End Sub

    Private Sub cmdCalcDehumCap_Click(sender As Object, e As EventArgs) Handles cmdCalcDehumCap.Click
        txtDehumCap.Text = Format(psyDehumCapacity(frmMain.ThisUnitCoolPerf.EnteringDB, frmMain.ThisUnitCoolPerf.EnteringWB, frmMain.ThisUnitCoolPerf.LeavingDB, frmMain.ThisUnitCoolPerf.LeavingWB, frmMain.ThisUnitSFanPerf.Airflow), "0.0")

    End Sub

    Private Sub chkSelectHGRH_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectHGRH.CheckedChanged
        If chkSelectHGRH.Checked Then
            txtHGRHCap.Text = "-"
            txtHGRHAFlow.Text = "-"
            txtEATDB.Text = "-"
            nudCircuitsofRH.Value = 1
            txtRHCoilAPD.Text = "-"
            txtLAT.Text = "-"
            txtDeltaT.Text = "-"
            txtDehumCap.Text = "-"
        End If
    End Sub
End Class