Imports System.Xml
Public Class frmCustomCoil
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

    Private Sub PopulateAuxPanelList()
        'V1.1 Added Check for it already existing
        If frmMain.HasAuxillaryPanel = True Then
            optUseAux.Checked = True
            grpAuxPanel.Enabled = False
            cmbAuxPanelOpts.Items.Clear()
            cmbAuxPanelOpts.Items.Add("Selected in Other Module")
            cmbAuxPanelOpts.Text = "Selected in Other Module"

        Else
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
        End If
    End Sub

    Private Sub AuxPanelCodeInsert()
        'V1.0
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

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub


    Private Sub frmCustomCoil_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call PopulateAuxPanelList()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = True
            Case Is = "Series10"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series20"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series40"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series100"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Premier"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Select"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Choice"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
        End Select

        ModuleCodeList.Add("950000")
        cmbCoilType.Items.Add("Reclaim Coil - Hot Gas")
        cmbCoilType.Items.Add("Preheat Reclaim Coil - Glycol")
        cmbCoilType.Items.Add("Preheat Coil - Fluid")
        cmbCoilType.Items.Add("Unselected")
        cmbCoilType.Text = "Unselected"

        txtAFlow.Text = frmMain.ThisUnitSFanPerf.Airflow
        txtEAT.Text = frmMain.ThisUnitCoolPerf.LeavingDB
        cmbRefType.Text = "Unselected"

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("CstmCoil") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()

        Call PerformDesignCautionScan(False)
        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        Dim esp As Double
        Dim coilapd As Double

        frmMain.ThisUnitCstmCoilPerf.CoilStyle = cmbCoilType.Text

        frmMain.ThisUnitCstmCoilPerf.ReheatCapacity = txtReclaimCap.Text

        Select Case cmbCoilType.Text
            Case Is = "Reclaim Coil - Hot Gas"
                frmMain.ThisUnitCstmCoilPerf.RefType = cmbRefType.Text
            Case Is = "Preheat Reclaim Coil - Glycol"
                frmMain.ThisUnitCstmCoilPerf.RefType = txtFluid.Text
            Case Is = "Preheat Coil - Water"
                frmMain.ThisUnitCstmCoilPerf.RefType = txtFluid.Text

        End Select

        frmMain.ThisUnitCstmCoilPerf.CstmCoilAirflow = txtAFlow.Text

        frmMain.ThisUnitCstmCoilPerf.EATDB = txtEAT.Text
        frmMain.ThisUnitCstmCoilPerf.LATDB = txtLAT.Text

        Select Case cmbCoilType.Text
            Case Is = "Reclaim Coil - Hot Gas"
                frmMain.ThisUnitCstmCoilPerf.RefPD = txtRefPD.Text
            Case Is = "Preheat Reclaim Coil - Glycol"
                frmMain.ThisUnitCstmCoilPerf.RefPD = txtRefPD.Text
            Case Is = "Preheat Coil - Water"
                frmMain.ThisUnitCstmCoilPerf.RefPD = txtRefPD.Text

        End Select

        frmMain.ThisUnitCstmCoilPerf.InletConn = txtInConn.Text
        frmMain.ThisUnitCstmCoilPerf.OutletConn = txtOutConn.Text

        esp = Val(frmMain.ThisUnitSFanPerf.ESP)
        coilapd = Val(txtAllocatedAPD.Text)
        If Val(txtCoilAPD.Text) > coilapd Then
            coilapd = Val(txtCoilAPD.Text)
        End If
        esp = esp - coilapd
        frmMain.ThisUnitSFanPerf.ESP = Format(esp, "0.00")

        If optValve2Way.Checked Or optValve3Way.Checked Then
            frmMain.ThisUnitHydroData.HWVPresent = True
            frmMain.ThisUnitHydroData.HWVTag = txtValveTag.Text
            frmMain.ThisUnitHydroData.HWVDescription = cmbValveDesc.Text
            frmMain.ThisUnitHydroData.HWVSize = cmbValveSize.Text
            frmMain.ThisUnitHydroData.HWVType = txtValveType.Text
            frmMain.ThisUnitHydroData.HWVMPN = txtValveMPN.Text
        Else
            frmMain.ThisUnitHydroData.HWVPresent = False
        End If

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("CstmCoil")

        'Next Line is the line item description i.e. Hot Water Description


        frmMain.ThisUnitPhysicalData.ModLoadItem.Add(cmbCoilType.Text)

        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "101"
                End If
                If cmbCoilType.Text = "Preheat Reclaim Coil - Glycol" Then
                    tempWeight = "130"
                End If
                If cmbCoilType.Text = "Preheat Coil - Fluid" Then
                    tempWeight = "130"
                End If

            Case Is = "Series10"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "119"
                End If
                If cmbCoilType.Text = "Preheat Reclaim Coil - Glycol" Then
                    tempWeight = "160"
                End If
                If cmbCoilType.Text = "Preheat Coil - Fluid" Then
                    tempWeight = "165"
                End If
            Case Is = "Series20"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "185"
                End If
                If cmbCoilType.Text = "Preheat Reclaim Coil - Glycol" Then
                    tempWeight = "400"
                End If
                If cmbCoilType.Text = "Preheat Coil - Fluid" Then
                    tempWeight = "210"
                End If
            Case Is = "Series40"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "246"
                End If
                If cmbCoilType.Text = "Preheat Reclaim Coil - Glycol" Then
                    tempWeight = "480"
                End If
                If cmbCoilType.Text = "Preheat Coil - Fluid" Then
                    tempWeight = "485"
                End If
            Case Is = "Series 100"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "410"
                End If
                If cmbCoilType.Text = "Preheat Reclaim Coil - Glycol" Then
                    tempWeight = "590"
                End If
                If cmbCoilType.Text = "Preheat Coil - Fluid" Then
                    tempWeight = "608"
                End If
            Case Is = "Select"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "246"
                End If
            Case Is = "Choice"
                If cmbCoilType.Text = "Reclaim Coil - Hot Gas" Then
                    tempWeight = "246"
                End If
            Case Is = "Premier"
                tempWeight = "9999"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CoilTest = True
        If chkPumpedCoil.Checked = True Then
            frmMain.ThisUnitWarrTest.HydroPress = True
            frmMain.ThisUnitWarrTest.MotorTest = True
        End If

    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()

        'Add the level 0 code(s)

        ModuleCodeList.Add("950000") 'Custom Coil
        Select Case cmbCoilType.Text
            Case Is = "Reclaim Coil - Hot Gas"
                ModuleCodeList.Add("950100") 'obviously a reclaim coil
                Select Case nudRows.Value
                    Case Is = 1
                        ModuleCodeList.Add("950101") '1 row coil
                    Case Is = 2
                        ModuleCodeList.Add("950102") '2 row coil
                    Case Is = 3
                        ModuleCodeList.Add("950103") '3 row coil
                    Case Is = 4
                        ModuleCodeList.Add("950104") '4 row coil
                End Select
                If chkN2Holding.Checked Then ModuleCodeList.Add("950115")

            Case Is = "Preheat Reclaim Coil - Glycol"
                ModuleCodeList.Add("950106") 'obviously a reclaim coil
                Select Case nudRows.Value
                    Case Is = 2
                        ModuleCodeList.Add("950107") '2 row coil
                    Case Is = 3
                        ModuleCodeList.Add("950108") '3 row coil
                    Case Is = 4
                        ModuleCodeList.Add("950109") '4 row coil
                End Select

            Case Is = "Preheat Coil - Fluid"
                ModuleCodeList.Add("950200") 'Preheat Fluid Coil
                Select Case nudRows.Value
                    Case Is = 1
                        ModuleCodeList.Add("950201") '1 row coil
                    Case Is = 2
                        ModuleCodeList.Add("950202") '2 row coil
                    Case Is = 3
                        ModuleCodeList.Add("950203") '3 row coil
                    Case Is = 4
                        ModuleCodeList.Add("950204") '4 row coil
                End Select
        End Select



        'now handle the penetrations
        If optPenTTBFieldCut.Checked Then
            ModuleCodeList.Add("950110")
        End If
        If optPenTTWFieldCut.Checked Then
            ModuleCodeList.Add("950111")
        End If
        If optPenConvertibleFieldCut.Checked Then
            ModuleCodeList.Add("950112")
        End If
        If optPenTTHeatSecBFieldCut.Checked Then
            ModuleCodeList.Add("950113")
        End If

        'now the controls
        ModuleCodeList.Add("950170")
        Select Case cmbCoilType.Text
            Case Is = "Reclaim Coil - Hot Gas"
                If optNoControls.Checked Then
                    ModuleCodeList.Add("950175")
                End If
            Case Is = "Preheat Reclaim Coil - Glycol"
                If optNoControls.Checked Then
                    ModuleCodeList.Add("950176")
                End If
            Case Is = "Preheat Coil - Fluid"
                If optNoControls.Checked Then
                    ModuleCodeList.Add("950177")
                End If
                If optPHCoilLATCtrl.Checked Then
                    ModuleCodeList.Add("950190")
                End If
        End Select


        'Handle the lowlimits on glycol coils
        Select Case cmbCoilType.Text
            Case Is = "Preheat Reclaim Coil - Glycol"
                If optLLUnwired.Checked Then
                    ModuleCodeList.Add("950180")
                End If
                If optLLBreakStuff.Checked Then
                    ModuleCodeList.Add("950181")
                End If
                If optLLAveragingSensor.Checked Then
                    ModuleCodeList.Add("950182")
                End If
                If optLLNone.Checked Then
                    ModuleCodeList.Add("950183")
                End If
            Case Is = "Reclaim Coil - Hot Gas"
            Case Is = "Preheat Coil - Fluid"
                If optLLUnwired.Checked Then
                    ModuleCodeList.Add("950180")
                End If
                If optLLBreakStuff.Checked Then
                    ModuleCodeList.Add("950181")
                End If
                If optLLAveragingSensor.Checked Then
                    ModuleCodeList.Add("950182")
                End If
                If optLLNone.Checked Then
                    ModuleCodeList.Add("950183")
                End If

        End Select

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("605F6A")
        End If

        'this Is where we set the number of comm nodes.
        If optLLBreakStuff.Checked Then
            frmMain.ThisUnit.CommNodes = "2"
        End If




    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/CustomCoil")

        cmbCoilType.Text = xNodeRoot.SelectSingleNode("CoilType").InnerText
        cmbRefType.Text = xNodeRoot.SelectSingleNode("RefType").InnerText

    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")

    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult
        If cmbCoilType.Text = "Unselected" Then
            dummy = MsgBox("You must select a coil type.", vbOKOnly, "Custom Coil Module")
            Exit Sub
        End If
        If cmbRefType.Enabled = True And cmbRefType.Text = "Unselected" Then
            dummy = MsgBox("You must select/enter a refrigerant.", vbOKOnly, "Custom Coil Module")
            Exit Sub
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        Dim dummy As MsgBoxResult
        If chkFilterBankRelocation.Checked Then
            If ((InTheQueue("Custom Mechanical Options") = False) And (AlreadyDone("CstmMech") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Custom Mechanical Options")
            End If
            dummy = MsgBox("Add Filter Bank Relocation in the Custom Mechanical form when prompted.", vbOKOnly, "Fisen Unit Generator")
        End If

        If chkPumpedCoil.Checked Then
            If ((InTheQueue("Custom Mechanical Options") = False) And (AlreadyDone("CstmMech") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Custom Mechanical Options")
            End If
            dummy = MsgBox("Add Pumped Coil in the Custom Mechanical form when prompted.", vbOKOnly, "Fisen Unit Generator")
        End If

        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneValves_Click(sender As Object, e As EventArgs) Handles btnDoneValves.Click
        btnDoneValves.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click

        If cmbCoilType.Text = "Preheat Coil - Fluid" Then
            TabControl1.SelectTab("tpgValves")
        Else
            btnDonePerf.Enabled = False
            btnOK.Enabled = True
        End If

    End Sub

    Private Sub txtLAT_LostFocus(sender As Object, e As EventArgs) Handles txtLAT.LostFocus
        txtDeltaT.Text = Str(Val(txtLAT.Text) - Val(txtEAT.Text))
    End Sub

    Private Sub cmbCoilType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCoilType.SelectedIndexChanged
        Select Case cmbCoilType.Text
            Case Is = "Reclaim Coil - Hot Gas"
                lblFluid.Enabled = False
                txtFluid.Enabled = False
                grpLowLimit.Enabled = False
                optLLNone.Checked = True
                lblFluidPressDrop.Text = "Refrigeration Pressure Drop"
                lblFPDUnits.Text = "psi"
                lblRefType.Enabled = True
                cmbRefType.Enabled = True
                lblCircuitsofRH.Visible = True
                nudCircuitsofRH.Visible = True
                lblReclaimCap.Text = "Reclaim Coil Capacity"
                lblReclaimAirflow.Text = "Reclaim Coil Airflow"
                lblAllocatedAPD.Text = "Allocated Reclaim Coil APD"
                lblActualAPD.Text = "Reclaim Coil APD"
                chkPumpedCoil.Visible = False
                chkPumpedCoil.Checked = False
                chkN2Holding.Visible = True
                chkN2Holding.Checked = False
                lblFluidFlow.Text = "Mass Flow"
                lblFluidFlowUnits.Text = "lb/hr"
            Case Is = "Preheat Reclaim Coil - Glycol"
                lblFluid.Enabled = True
                txtFluid.Enabled = True
                grpLowLimit.Enabled = True
                lblFluidPressDrop.Text = "Glycol Pressure Drop"
                lblFPDUnits.Text = "ft."
                lblRefType.Enabled = False
                cmbRefType.Enabled = False
                lblCircuitsofRH.Visible = False
                nudCircuitsofRH.Visible = False
                lblReclaimCap.Text = "Reclaim Coil Capacity"
                lblReclaimAirflow.Text = "Reclaim Coil Airflow"
                lblAllocatedAPD.Text = "Allocated Reclaim Coil APD"
                lblActualAPD.Text = "Reclaim Coil APD"
                chkPumpedCoil.Visible = False
                chkPumpedCoil.Checked = False
                chkN2Holding.Visible = False
                chkN2Holding.Checked = False
                lblFluidFlow.Text = "Fluid Flow"
                lblFluidFlowUnits.Text = "gpm"

            Case Is = "Preheat Coil - Fluid"
                lblFluid.Enabled = True
                txtFluid.Enabled = True
                grpLowLimit.Enabled = True
                lblRefType.Enabled = False
                cmbRefType.Enabled = False
                lblReclaimCap.Text = "Preheat Coil Capacity"
                lblReclaimAirflow.Text = "Preheat Coil Airflow"
                lblCircuitsofRH.Visible = False
                nudCircuitsofRH.Visible = False
                lblAllocatedAPD.Text = "Allocated Preheat Coil APD"
                lblFluidPressDrop.Text = "Fluid Pressure Drop"
                lblFPDUnits.Text = "ft."
                lblActualAPD.Text = "Preheat Coil APD"
                chkPumpedCoil.Visible = True
                chkPumpedCoil.Checked = False
                chkN2Holding.Visible = False
                chkN2Holding.Checked = False
                lblFluidFlow.Text = "Fluid Flow"
                lblFluidFlowUnits.Text = "gpm"

        End Select

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

    Private Sub cmbValveSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValveSize.SelectedIndexChanged
        If cmbValveSize.Text <> "-" Then

            Call LoadTheValveList()
        Else
            txtValveTag.Text = "-"
            txtValveType.Text = "-"
            txtValveMPN.Text = "-"

        End If
    End Sub
    Private Sub LoadTheValveList()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        If optValveNone.Checked Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        cmbValveDesc.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        MySQL = ""
        If optValve2Way.Checked Then
            MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='2 Way' AND Size='" & cmbValveSize.Text & "' ORDER BY CV"
        End If
        If optValve3Way.Checked Then
            MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='3 Way' AND Size='" & cmbValveSize.Text & "' ORDER BY CV"
        End If


        rs.Open(MySQL, con)

        i = 0
        rs.MoveFirst()
        Do While Not (rs.EOF)
            cmbValveDesc.Items.Add(rs.Fields("Description").Value)
            rs.MoveNext()
        Loop

        cmbValveDesc.Items.Add("-")
        cmbValveDesc.Text = "-"
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub cmbValveDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValveDesc.SelectedIndexChanged
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer

        Dim MySQL As String

        If cmbValveDesc.Text = "-" Then
            txtValveType.Text = "-"
            txtValveMPN.Text = "-"
        Else
            con = New ADODB.Connection
            dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
            con.ConnectionString = dbProvider
            con.Open()

            rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

            MySQL = "SELECT * FROM tblHydroHWValves WHERE Description='" & cmbValveDesc.Text & "' ORDER BY CV"

            rs.Open(MySQL, con)

            i = 0
            rs.MoveFirst()
            txtValveType.Text = rs.Fields("Description").Value
            txtValveMPN.Text = rs.Fields("AssemblyPN").Value
            con.Close()

        End If



        rs = Nothing
        con = Nothing
    End Sub

    Private Sub btnSelectAValve_Click(sender As Object, e As EventArgs) Handles btnSelectAValve.Click
        Dim TwoORThree As String

        If optValve2Way.Checked Then
            TwoORThree = "2 Way"
        Else
            TwoORThree = "3 Way"
        End If
        cmbValveDesc.Text = SelectAValve(txtFluidFlow.Text, cmbValveSize.Text, TwoORThree)
    End Sub
    Private Function SelectAValve(Flow As String, BodySize As String, Style As String) As String
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim SelectedValve As String
        Dim RqdCV As Double
        Dim ValveCV As Double

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroHWValves WHERE Style='" & Style & "' AND Size='" & BodySize & "' ORDER BY CV"


        RqdCV = Val(Flow) / 2.0

        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            ValveCV = rs.Fields("CV").Value
            If RqdCV <= ValveCV Then
                Exit Do
            Else
                rs.MoveNext()
            End If
        Loop

        SelectedValve = rs.Fields("Description").Value

        con.Close()

        rs = Nothing
        con = Nothing

        Return SelectedValve

    End Function

    Private Sub chkPumpedCoil_CheckedChanged(sender As Object, e As EventArgs) Handles chkPumpedCoil.CheckedChanged
        If chkPumpedCoil.Checked Then
            optValve3Way.Checked = True
            optValveNone.Enabled = False
            optValve2Way.Enabled = False
            optValve3Way.Enabled = True
        Else
            optValveNone.Checked = True
            optValveNone.Enabled = True
            optValve2Way.Enabled = True
            optValve3Way.Enabled = True
        End If
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "CustomCoil"
        frmHistoryReport.cmbModCode.Text = "CustomCoil"
        frmHistoryReport.Show()
    End Sub
    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific
        Dim CoilStyle, RefFluid, Capacity, Flow, Airflow, EATdb, xRows, LAT, FPD, CoilAPD As String

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

        CoilStyle = cmbCoilType.Text
        If txtFluid.Enabled Then
            RefFluid = txtFluid.Text
        Else
            RefFluid = cmbRefType.Text
        End If
        Capacity = txtReclaimCap.Text
        Flow = txtFluidFlow.Text
        Airflow = txtAFlow.Text
        xRows = Str(nudRows.Value)
        EATdb = txtEAT.Text
        LAT = txtLAT.Text
        FPD = txtRefPD.Text
        CoilAPD = txtCoilAPD.Text



        MySQL = "Select * FROM tblHistoryCustomCoil WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryCustomCoil SET CoilStyle='" & CoilStyle & "', RefFluid='" & RefFluid & "', " & "Capacity='" & Capacity & "', Flow='" & Flow & "', Airflow='" & Airflow & "', EATdb='" & EATdb & "', xRows='" & xRows & "', LAT='" & LAT & "', FPD='" & FPD & "', CoilAPD='" & CoilAPD & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryCustomCoil (JobName,UnitID,Version,ModelNumber,CoilStyle,RefFluid,Capacity,Flow,Airflow,EATdb,xRows,LAT,FPD,CoilAPD) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & CoilStyle & "','" & RefFluid & "','" & Capacity & "','" & Flow & "','" & Airflow & "','" & EATdb & "','" & xRows & "','" & LAT & "','" & FPD & "','" & CoilAPD & "')"
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
        'Version 1.0 - Requires specificity to be performed when inserted.

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '950%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '420%'"
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

End Class