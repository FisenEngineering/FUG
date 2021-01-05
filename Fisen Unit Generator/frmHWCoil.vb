Imports System.ComponentModel
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class frmHWCoil

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
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems
        frmMain.ThisUnitMods.Add("HWCoil")
        Call UpdateCodeList()
        If chkWriteHistory.Checked = True Then Call WriteHWCoilHistory()
        Call WriteModuleData()
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        Dim iHMI As Integer
        Dim HMIAlreadyThere As Boolean
        Dim tbblockadded As Boolean

        tbblockadded = False

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("513300")

        'Now handle the coil
        ModuleCodeList.Add("513399")

        If Not (chkEpoxy.Checked) Then
            'Add the codes for the style of coil *Uncoated*
            If optCoilCustom.Checked Then ModuleCodeList.Add("513309") 'Custom coil
            If optCoil1Row.Checked Then ModuleCodeList.Add("513301") '1 row coil
            If optCoil2Row.Checked Then ModuleCodeList.Add("513306") '2 row coil
        Else
            'Add the codes for the style of coil *Coated*
            If optCoilCustom.Checked Then ModuleCodeList.Add("513315") 'Custom Coated Coil
            If optCoil1Row.Checked Then ModuleCodeList.Add("513307") 'Coated 1 Row Coil
            If optCoil2Row.Checked Then ModuleCodeList.Add("513308") 'Coated 2 Row Coil
        End If

        If chkS40DrawThroughCoil.Checked Then ModuleCodeList.Add("513390") 'Draw through coil Series 40

        'Valves...
        If optValveNone.Checked = False Then
            ModuleCodeList.Add("513302") 'Modulating Hot Water Valve
            'Valves Installed by Fisen
            If optValveFisenProvFisenInst.Checked = True Then
                If optValve2Way.Checked Then
                    ModuleCodeList.Add("513310") '2-Way Fisen Installed
                    frmMain.ThisUnitHydro.Add("Hot Water Coil and 2 Way Valve")
                End If

                If optValve3Way.Checked Then
                    ModuleCodeList.Add("513311") '3-Way Fisen Installed
                    frmMain.ThisUnitHydro.Add("Hot Water Coil and 3 Way Valve")
                End If

            Else
                If optValve2Way.Checked Then
                    ModuleCodeList.Add("513303") '2-Way Field Installed

                End If
                If optValve3Way.Checked Then
                    ModuleCodeList.Add("513304") '3-Way Field Installed

                End If

                frmMain.ThisUnitHydro.Add("Just Hot Water Coil")
            End If
        Else
            If optValveNone.Checked Then
                ModuleCodeList.Add("513330") 'Field provided and field installed valve

            End If
            frmMain.ThisUnitHydro.Add("Just Hot Water Coil")
        End If

        'Handle Freezestats
        ModuleCodeList.Add("513305") 'Low Limit Thermostat

        If optLLUnwired.Checked Then
            If frmMain.ModBarn.UnitHas4StageBoard Then
                ModuleCodeList.Add("513312") 'LLStat Unwired 513312
            Else
                ModuleCodeList.Add("51331A") 'LLStat Unwired 51331A No Stage 4 Board installed.
            End If
        End If
        'LLStat Wired to Controller 513313
        If optLLWired.Checked Then ModuleCodeList.Add("513313")
        'LLStat Breaks the Valve Power 513314
        If chkBreakonLL.Checked Then ModuleCodeList.Add("513314")
        If chkBreakonLL.Checked Then ModuleCodeList.Add("513323")
        If chkBreakonLL.Checked Then ModuleCodeList.Add("513324")
        If chkBreakonLL.Checked Then ModuleCodeList.Add("513325")
        If chkBreakonLL.Checked Then ModuleCodeList.Add("513326")
        If chkBreakonLL.Checked And Not (optValveFisenProvFisenInst.Checked) Then
            ModuleCodeList.Add("513327")
            tbblockadded = True
        End If

        'Handle Controls
        ModuleCodeList.Add("513320")

        'No Controls by Fisen
        If (optValveCtrlNone.Checked) Then
            ModuleCodeList.Add("513328")
            ModuleCodeList.Add("513316")
            If optBU_IPU_Unwired.Checked Then
                ModuleCodeList.Add("513381")

            End If
            If optBU_SE_Fact_Unwired.Checked Then
                ModuleCodeList.Add("513319") 'Fisen Provided SE Board
                ModuleCodeList.Add("513380") 'SE Available for Wiring

            End If
            If optBU_SE_Fisen_Unwired.Checked Then
                ModuleCodeList.Add("513319") 'Fisen Provided SE Board
                ModuleCodeList.Add("513380") 'SE Available for Wiring

            End If
        End If

        'Base Unit Controls the Valve Position
        If optValveCtrlBaseUnit.Checked Then
            If optBU_SE_Fact_FisenWires.Checked Then
                ModuleCodeList.Add("513317") 'Fisen Wired Valve Control
                ModuleCodeList.Add("513398") 'SAT Sensor Relocate

            End If
            If optBU_SE_Fisen_FisenWires.Checked Then
                ModuleCodeList.Add("513317") 'Fisen Wired Valve Control
                ModuleCodeList.Add("513398") 'SAT Sensor Relocate
                ModuleCodeList.Add("513319") 'Fisen Provided SE Board

            End If
            If optBU_IPU_FisenWires.Checked Then
                ModuleCodeList.Add("513329") 'Fisen Wired Valve Control - IPU
                ModuleCodeList.Add("513398") 'SAT Sensor Relocate

            End If
        End If

        'Fisen Controller Handles the Valve Position
        If optValveCtrlFisenCustom.Checked Then

        End If


        'Field wires the valve we need a terminal block.
        If (((optValveFieldProvFieldInst.Checked) Or (optValveFisenProvFieldInst.Checked)) And Not (optValveCtrlNone.Checked)) Then
            If Not (tbblockadded) Then ModuleCodeList.Add("513327")
        End If

        'Fisen adds a 4 stage board
        If ((optBU_SE_Fisen_FisenWires.Checked) Or (optBU_SE_Fisen_Unwired.Checked)) Then
            frmMain.ThisUnitGenCodes.Add("960003")
        End If

        'Handle the hmi
        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
            HMIAlreadyThere = False
            For iHMI = 0 To frmMain.ThisUnitGenCodes.Count - 1
                If ((frmMain.ThisUnitGenCodes.Item(iHMI) = "960002") Or (frmMain.ThisUnitGenCodes.Item(iHMI) = "960001")) Then HMIAlreadyThere = True
            Next
            If ((chkMountEquipmentTouch.Checked = True) And (HMIAlreadyThere = False)) Then
                frmMain.ThisUnitGenCodes.Add("960002")
            End If
            If ((chkMountEquipmentTouch.Checked = False) And (HMIAlreadyThere = False)) Then
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'handle the commnodes
        If Not (optValveCtrlNone.Checked) Then
            frmMain.ThisUnit.CommNodes = "2"
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

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("513F6A")
        End If


        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '513%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '513%'"
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
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CoilTest = True
        If optValveFisenProvFisenInst.Checked = True Then
            frmMain.ThisUnitWarrTest.HydroPress = True
        End If
        If optValveCtrlBaseUnit.Checked = True Then
            frmMain.ThisUnitWarrTest.CtrlTest = True
        End If
        If optValveCtrlFisenCustom.Checked = True Then
            frmMain.ThisUnitWarrTest.CtrlTest = True
        End If

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim Dummy As MsgBoxResult

        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HWCoil")
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Water Coil")
        tempWeight = "9999"
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If optCoil1Row.Checked = True Then tempWeight = "120"
                If optCoil2Row.Checked = True Then tempWeight = "145"
                If optCoilCustom.Checked = True Then tempWeight = "145"
            Case Is = "Series10"
                If optCoil1Row.Checked = True Then tempWeight = "120"
                If optCoil2Row.Checked = True Then tempWeight = "145"
                If optCoilCustom.Checked = True Then tempWeight = "145"
            Case Is = "Series20"
                If optCoil1Row.Checked = True Then tempWeight = "160"
                If optCoil2Row.Checked = True Then tempWeight = "205"
                If optCoilCustom.Checked = True Then tempWeight = "205"
            Case Is = "Series40"
                If optCoil1Row.Checked = True Then tempWeight = "170"
                If optCoil2Row.Checked = True Then tempWeight = "215"
                If optCoilCustom.Checked = True Then tempWeight = "215"
            Case Is = "Choice"
                If optCoil1Row.Checked = True Then tempWeight = "175"
                If optCoil2Row.Checked = True Then tempWeight = "195"
                If optCoilCustom.Checked = True Then tempWeight = "195"
            Case Is = "Select"
                If optCoil1Row.Checked = True Then tempWeight = "170"
                If optCoil2Row.Checked = True Then tempWeight = "215"
                If optCoilCustom.Checked = True Then tempWeight = "215"
            Case Else
                tempWeight = "9999"
                Dummy = MsgBox("Error in Weight Selection for HWCoil Module.", vbOKOnly)
        End Select
        If Not (optValveNone.Checked) Then tempWeight = tempWeight + 10
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim tempCS As String
        frmMain.ThisUnitHeatPerf.HeatType = "Hot Water"
        If optValveCtrlFisenCustom.Checked = True Then tempCS = "Modulating"
        If optValveCtrlBaseUnit.Checked = True Then tempCS = "Modulating"
        If optValveCtrlNone.Checked Then tempCS = "Field Provided"


        frmMain.ThisUnitHeatPerf.ControlStyle = tempCS
        frmMain.ThisUnitHeatPerf.OutputCapacity = txtOutCap.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCap.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.EnteringAirTemp = txtEAT.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Fluid = cmbFluidList.Text & cmbFluidPer.Text
        frmMain.ThisUnitHeatPerf.FluidFlow = txtFluidFlow.Text
        If optCoilOnly.Checked Then
            frmMain.ThisUnitHeatPerf.CoilAPD = Str(Val(txtAPD.Text) * 1.1)
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtAPD.Text) * 1.1)
        Else
            frmMain.ThisUnitHeatPerf.CoilAPD = txtAPD.Text
            frmMain.ThisUnitSFanPerf.ESP = Str(Val(frmMain.ThisUnitSFanPerf.ESP) - Val(txtAPD.Text))
        End If

        frmMain.ThisUnitHeatPerf.EntFluidTemp = txtEFT.Text
        frmMain.ThisUnitHeatPerf.LvgFluidTemp = txtLFT.Text
        frmMain.ThisUnitHydroData.InletSize = txtInletSize.Text
        frmMain.ThisUnitHydroData.OutletSize = txtOutletSize.Text

        If optValveFisenProvFieldInst.Checked Or optValveFisenProvFisenInst.Checked Then
            frmMain.ThisUnitHydroData.HWVPresent = True
            frmMain.ThisUnitHydroData.HWVTag = txtValveTag.Text
            frmMain.ThisUnitHydroData.HWVDescription = cmbValveDesc.Text
            frmMain.ThisUnitHydroData.HWVSize = cmbValveSize.Text
            frmMain.ThisUnitHydroData.HWVType = txtValveType.Text
            frmMain.ThisUnitHydroData.HWVMPN = txtValveMPN.Text
        Else
            frmMain.ThisUnitHydroData.HWVPresent = False
        End If

        If Not (optValveFisenProvFisenInst.Checked) Then
            frmMain.ThisUnitHeatPerf.FluidPressureDrop = txtFPD.Text
        Else
            frmMain.ThisUnitHeatPerf.FluidPressureDrop = Str(Val(txtFPD.Text) + 2.31 * 4)
        End If
    End Sub

    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        cmbFluidList.Items.Add("Water")
        cmbFluidList.Items.Add("Propylene Glycol")
        cmbFluidList.Items.Add("Ethylene Glycol")

        cmbFluidPer.Items.Add("100")
        cmbFluidPer.Items.Add("5")
        cmbFluidPer.Items.Add("10")
        cmbFluidPer.Items.Add("15")
        cmbFluidPer.Items.Add("20")
        cmbFluidPer.Items.Add("25")
        cmbFluidPer.Items.Add("30")
        cmbFluidPer.Items.Add("35")
        cmbFluidPer.Items.Add("40")
        cmbFluidPer.Items.Add("45")
        cmbFluidPer.Items.Add("50")


        txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        If Val(txtHeatAF.Text) <= 0 Then
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If
        txtEAT.Text = frmMain.ThisUnitHeatPerf.EnteringAirTemp
        txtInputCap.Text = frmMain.ThisUnitHeatPerf.InputCapacity
        txtEFT.Text = frmMain.ThisUnitHeatPerf.EntFluidTemp
        If Val(txtEFT.Text) <= 0 Then
            txtEFT.Text = "180.0"
        End If
        txtFluidFlow.Text = frmMain.ThisUnitHeatPerf.FluidFlow
        Select Case Mid(frmMain.ThisUnitHeatPerf.Fluid, 1, 2)
            Case Is = "Wa"
                cmbFluidList.Text = "Water"
            Case Is = "Et"
                cmbFluidList.Text = "Ethylene Glycol"
            Case Is = "Pr"
                cmbFluidList.Text = "Propylene Glycol"
        End Select
        Select Case Mid(frmMain.ThisUnitHeatPerf.Fluid, 3, 2)
            Case Is = "te"
                cmbFluidPer.Text = "100"
            Case Else
                cmbFluidPer.Text = Mid(frmMain.ThisUnitHeatPerf.Fluid, 3, 2)
        End Select

        If ((frmMain.ThisUnit.Family = "Series10") Or (frmMain.ThisUnit.Family = "Series5") Or (InStr(frmMain.ThisUnit.ModelNumber, "ZR") > 0)) Then
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Checked = False
            optBU_IPU_FisenWires.Checked = True
        End If

        cmbValveSize.Text = "-"
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
                chkS40DrawThroughCoil.Visible = True

            Case Is = "Series100"

            Case Else

        End Select
        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        ModuleCodeList.Add("513000")

    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/HWCoil")

        TempVal = xNodeRoot.SelectSingleNode("HeatingAirflow").InnerText
        txtHeatAF.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EAT").InnerText
        txtEAT.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("InputCapacity").InnerText
        txtInputCap.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("EFT").InnerText
        txtEFT.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("FluidFlow").InnerText
        txtFluidFlow.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("Fluid").InnerText
        cmbFluidList.Text = TempVal

        TempVal = xNodeRoot.SelectSingleNode("FlPercent").InnerText
        cmbFluidPer.Text = TempVal

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
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

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs)
        Call PopulateAuxPanelList()
    End Sub


    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim FFlow As Double
        Dim ConSize As String

        FFlow = Val(txtFluidFlow.Text)

        Select Case FFlow
            Case Is < 10
                ConSize = "3/4"
            Case 10 To 17.99
                ConSize = "1"
            Case 18 To 26.99
                ConSize = "1-1/4"
            Case 27 To 38.99
                ConSize = "1-1/2"
            Case 39 To 73.99
                ConSize = "2"
            Case 74 To 119.99
                ConSize = "2-1/2"
            Case Else
                ConSize = "-"
        End Select
        txtInletSize.Text = ConSize
        txtOutletSize.Text = ConSize

        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        txtOutCap.Text = txtInputCap.Text
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        If Not (optValveNone.Checked) Then
            Select Case txtOutletSize.Text
                Case Is = "3/4"
                    cmbValveSize.Text = "1/2"
                Case Is = "1"
                    cmbValveSize.Text = "3/4"
                Case Is = "1-1/4"
                    cmbValveSize.Text = "1"
                Case Is = "1-1/2"
                    cmbValveSize.Text = "1-1/4"
                Case Is = "2"
                    cmbValveSize.Text = "1-1/2"
                Case Is = "2-1/2"
                    cmbValveSize.Text = "2"
                Case Else
                    cmbValveSize.Text = txtOutletSize.Text

            End Select

            TabControl1.SelectTab("tpgValves")
        Else
            btnDonePerformance.Enabled = False
            TabControl1.Enabled = False
            btnOK.Enabled = True
        End If
    End Sub


    Private Sub btnDoneValve_Click(sender As Object, e As EventArgs) Handles btnDoneValve.Click
        btnDoneValve.Enabled = False
        TabControl1.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub txtLAT_Leave(sender As Object, e As EventArgs) Handles txtLAT.Leave
        txtDeltaT.Text = Str(Val(txtLAT.Text) - Val(txtEAT.Text))
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        End If
    End Sub

    Private Sub optValveNone_CheckedChanged(sender As Object, e As EventArgs) Handles optValveNone.CheckedChanged
        If optValveNone.Checked = True Then
            optValveFieldProvFieldInst.Enabled = True
            optValveFieldProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = False
            optValveFisenProvFisenInst.Enabled = False
            txtValveTag.Text = "-"
        End If
    End Sub
    Private Sub optValve2Way_CheckedChanged(sender As Object, e As EventArgs) Handles optValve2Way.CheckedChanged
        If optValve2Way.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "HWV-1"
        End If

    End Sub

    Private Sub optValve3Way_CheckedChanged(sender As Object, e As EventArgs) Handles optValve3Way.CheckedChanged
        If optValve3Way.Checked = True Then
            optValveFisenProvFieldInst.Checked = True
            optValveFisenProvFieldInst.Enabled = True
            optValveFisenProvFisenInst.Enabled = True
            optValveFieldProvFieldInst.Enabled = False
            txtValveTag.Text = "HWV-1"
        End If
    End Sub

    Private Sub optValveCtrlBaseUnit_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlBaseUnit.CheckedChanged
        If optValveCtrlBaseUnit.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = True
            optBU_SE_Fisen_FisenWires.Enabled = True
            optBU_IPU_FisenWires.Enabled = True
            optBU_SE_Fact_FisenWires.Checked = True

            optBU_IPU_Unwired.Enabled = False
            optBU_SE_Fact_Unwired.Enabled = False
            optBU_SE_Fisen_Unwired.Enabled = False
            optBU_Other.Enabled = False
            optBU_SE_Fact_Unwired.Checked = False

            cmbValveCtrlFisenCustom.Enabled = False
            cmbValveCtrlFisenCustom.Text = "n/a"

            optLLUnwired.Checked = True
            optLLWired.Enabled = True
            chkBreakonLL.Checked = False
            chkBreakonLL.Enabled = True

        End If
    End Sub

    Private Sub optValveCtrlNone_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlNone.CheckedChanged
        If optValveCtrlNone.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_IPU_FisenWires.Enabled = False
            optBU_IPU_Unwired.Enabled = True
            optBU_SE_Fact_Unwired.Enabled = True
            optBU_SE_Fact_Unwired.Checked = True
            optBU_SE_Fisen_Unwired.Enabled = True
            optBU_Other.Enabled = True
            optBU_Other.Checked = True

            cmbValveCtrlFisenCustom.Enabled = False
            cmbValveCtrlFisenCustom.Text = "n/a"

            optLLUnwired.Enabled = True
            optLLWired.Enabled = False

            chkBreakonLL.Enabled = False
            chkBreakonLL.Checked = False

        End If
    End Sub

    Private Sub optValveCtrlFisenCustom_CheckedChanged(sender As Object, e As EventArgs) Handles optValveCtrlFisenCustom.CheckedChanged
        If optValveCtrlFisenCustom.Checked = True Then
            optBU_SE_Fact_FisenWires.Enabled = False
            optBU_SE_Fisen_FisenWires.Enabled = False
            optBU_IPU_FisenWires.Enabled = False
            optBU_IPU_Unwired.Enabled = False
            optBU_SE_Fact_Unwired.Enabled = False
            optBU_SE_Fisen_Unwired.Enabled = False
            optBU_Other.Enabled = True
            optBU_Other.Checked = True

            cmbValveCtrlFisenCustom.Enabled = True
            cmbValveCtrlFisenCustom.Text = "Fisen Custom 01"

            optLLWired.Enabled = True
            chkBreakonLL.Enabled = True

        End If
    End Sub

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

    Private Sub btnSelectAValve_Click(sender As Object, e As EventArgs) Handles btnSelectAValve.Click
        Dim TwoORThree As String

        If optValve2Way.Checked Then
            TwoORThree = "2 Way"
        Else
            TwoORThree = "3 Way"
        End If
        cmbValveDesc.Text = SelectAValve(txtFluidFlow.Text, cmbValveSize.Text, TwoORThree)
    End Sub

    Private Sub cmbFluidList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFluidList.SelectedIndexChanged
        If cmbFluidList.Text = "Water" Then
            cmbFluidPer.Text = "100"
        End If
    End Sub

    Private Sub optLLUnwired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLUnwired.CheckedChanged
        If optLLUnwired.Checked Then
            chkBreakonLL.Checked = False
            chkBreakonLL.Enabled = False
        End If
    End Sub

    Private Sub optLLWired_CheckedChanged(sender As Object, e As EventArgs) Handles optLLWired.CheckedChanged
        If optLLWired.Checked Then
            chkBreakonLL.Enabled = True
            chkBreakonLL.Checked = True
        End If
    End Sub

    Private Sub WriteHWCoilHistory()
        'Upgraded to Version 2.0 30 April 2020
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific
        Dim HeatAirflow, EAT, EFT, Flow, Fluid, Percent, LAT, LFT, CoilAPD, FPD, Capacity As String

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

        HeatAirflow = txtHeatAF.Text
        HeatAirflow = HeatAirflow.PadRight(5, " ")
        EAT = txtEAT.Text
        EFT = txtEFT.Text
        Flow = txtFluidFlow.Text
        Flow = Flow.PadRight(5, " ")
        Fluid = cmbFluidList.Text
        Percent = cmbFluidPer.Text
        LAT = txtLAT.Text
        LFT = txtLFT.Text
        CoilAPD = Format(Val(txtActualAPD.Text), "0.0")
        FPD = txtFPD.Text
        Capacity = txtOutCap.Text

        MySQL = "Select * FROM tblHistoryHWCoil WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryHWCoil SET HeatAirFlow='" & HeatAirflow & "', EAT='" & EAT & "', " & "EFT='" & EFT & "', Flow='" & Flow & "', Fluid='" & Fluid & "', FPercent='" & Percent & "', LAT='" & LAT & "', LFT='" & LFT & "', CoilAPD='" & CoilAPD & "', FPD='" & FPD & "', Capacity='" & Capacity & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryHWCoil (JobName, UnitID, Version, ModelNumber, HeatAirflow, EAT, EFT, Flow, Fluid, FPercent, LAT, LFT, CoilAPD, FPD, Capacity) VALUES ('" _
& jname & "','" & unit & "','" & ver & "','" & modnum & "','" & HeatAirflow & "','" & EAT & "','" & EFT & "','" & Flow & "','" & Fluid & "','" & Percent & "','" & LAT & "','" & LFT & "','" & CoilAPD & "','" & FPD & "','" & Capacity & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub optUseAux_CheckedChanged_1(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optNoAux_CheckedChanged_1(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "HWCoil"
        frmHistoryReport.cmbModCode.Text = "HWCoil"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdLoadMod_Click(sender As Object, e As EventArgs) Handles cmdLoadMod.Click
        Call LoadPriorVersionData
    End Sub

    Private Sub LoadPriorVersionData()
        Dim FUGName, FUGPath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim myItem As String
        Dim dummy As MsgBoxResult


        FUGName = GuessPerfPrevVerFileName("HWCoil")
        FUGPath = frmMain.txtProjectDirectory.Text
        FUGPath = FUGPath & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\" & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & " - " & FUGName
        If Not (My.Computer.FileSystem.FileExists(FUGPath)) Then
            dummy = MsgBox("Couldn't locate the expected file." & vbCrLf & "Search for file?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbNo Then Exit Sub
            OpenFileDialog1.InitialDirectory = frmMain.txtProjectDirectory.Text & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
            OpenFileDialog1.Filter = ".xml Files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog = vbOK Then
                FUGPath = OpenFileDialog1.FileName
            Else
                Exit Sub
            End If

        End If
        xDoc.Load(FUGPath)
        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//HotWaterCoil/Conditions")

        txtHeatAF.Text = xNodeRoot.SelectSingleNode("HeatAF").InnerText
        txtEAT.Text = xNodeRoot.SelectSingleNode("EAT").InnerText
        txtInputCap.Text = xNodeRoot.SelectSingleNode("InCap").InnerText
        txtEFT.Text = xNodeRoot.SelectSingleNode("EFT").InnerText
        txtFluidFlow.Text = xNodeRoot.SelectSingleNode("FluidFlow").InnerText
        cmbFluidList.Text = xNodeRoot.SelectSingleNode("Fluid").InnerText
        cmbFluidPer.Text = xNodeRoot.SelectSingleNode("FluidPer").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//HotWaterCoil/Options")
        myItem = xNodeRoot.SelectSingleNode("Coil").InnerText
        Select Case myItem
            Case Is = "Custom"
                optCoilCustom.Checked = True
            Case Is = "1Row"
                optCoil1Row.Checked = True
            Case Is = "2Row"
                optCoil2Row.Checked = True
        End Select
        myItem = xNodeRoot.SelectSingleNode("Valve").InnerText
        Select Case myItem
            Case Is = "None"
                optValveNone.Checked = True
            Case Is = "2Way"
                optValve2Way.Checked = True
            Case Is = "3Way"
                optValve3Way.Checked = True
        End Select
        myItem = xNodeRoot.SelectSingleNode("ValveInstall").InnerText
        Select Case myItem
            Case Is = "FisenProvFisenInst"
                optValveFisenProvFisenInst.Checked = True
            Case Is = "FisenProvFieldInst"
                optValveFisenProvFieldInst.Checked = True
            Case Is = "FieldProvFieldInst"
                optValveFieldProvFieldInst.Checked = True
        End Select
        myItem = xNodeRoot.SelectSingleNode("ECoat").InnerText
        If myItem = "Yes" Then chkEpoxy.Checked = True Else chkEpoxy.Checked = False
        myItem = xNodeRoot.SelectSingleNode("DrawThrough").InnerText
        If myItem = "Yes" Then chkS40DrawThroughCoil.Checked = True Else chkS40DrawThroughCoil.Checked = False
        myItem = xNodeRoot.SelectSingleNode("SCCRBase").InnerText
        If myItem = "Yes" Then chk65kASCCRBase.Checked = True Else chk65kASCCRBase.Checked = False
        myItem = xNodeRoot.SelectSingleNode("AuxPanel").InnerText
        If myItem = "Yes" Then optUseAux.Checked = True Else optNoAux.Checked = True
        myItem = xNodeRoot.SelectSingleNode("AuxPanelLoc").InnerText
        cmbAuxPanelOpts.Text = myItem

        xNodeRoot = xDoc.SelectSingleNode("//HotWaterCoil/Controls")
        myItem = xNodeRoot.SelectSingleNode("ValveControls").InnerText
        Select Case myItem
            Case Is = "None"
                optValveCtrlNone.Checked = True
            Case Is = "BaseUnit"
                optValveCtrlBaseUnit.Checked = True
            Case Is = "FisenCustom"
                optValveCtrlFisenCustom.Checked = True
        End Select
        myItem = xNodeRoot.SelectSingleNode("ValveControlsDetail").InnerText
        cmbValveCtrlFisenCustom.Text = myItem
        myItem = xNodeRoot.SelectSingleNode("BaseUnitControl").InnerText
        Select Case myItem
            Case Is = "SE4StageByJCIFisenWires"
                optBU_SE_Fact_FisenWires.Checked = True
            Case Is = "SE4StageByFisenFisenWires"
                optBU_SE_Fisen_FisenWires.Checked = True
            Case Is = "IPUFisenWires"
                optBU_IPU_FisenWires.Checked = True
            Case Is = "IPUUnwired"
                optBU_IPU_Unwired.Checked = True
            Case Is = "SE4StageByJCIUnwired"
                optBU_SE_Fact_Unwired.Checked = True
            Case Is = "SE4StageByFisenUnwired"
                optBU_SE_Fisen_Unwired.Checked = True
            Case Is = "NotApplicable"
                optBU_Other.Checked = True
        End Select
        myItem = xNodeRoot.SelectSingleNode("LowLimitStat").InnerText
        If myItem = "Yes" Then optLLUnwired.Checked = True Else optLLWired.Checked = True
        myItem = xNodeRoot.SelectSingleNode("BreakPower").InnerText
        If myItem = "Yes" Then chkBreakonLL.Checked = True Else chkBreakonLL.Checked = False
        myItem = xNodeRoot.SelectSingleNode("EquipmentTouch").InnerText
        If myItem = "Yes" Then chkIncludeEquipmentTouch.Checked = True Else chkIncludeEquipmentTouch.Checked = False
        myItem = xNodeRoot.SelectSingleNode("MountTouch").InnerText
        If myItem = "Yes" Then chkMountEquipmentTouch.Checked = True Else chkMountEquipmentTouch.Checked = False

        xNodeRoot = xDoc.SelectSingleNode("//HotWaterCoil/Performance")
        txtLAT.Text = xNodeRoot.SelectSingleNode("LAT").InnerText
        txtDeltaT.Text = xNodeRoot.SelectSingleNode("DeltaT").InnerText
        txtLFT.Text = xNodeRoot.SelectSingleNode("LFT").InnerText
        txtActualAPD.Text = xNodeRoot.SelectSingleNode("ActualAPD").InnerText
        txtAPD.Text = xNodeRoot.SelectSingleNode("SystemAPD").InnerText
        myItem = xNodeRoot.SelectSingleNode("Allowance").InnerText
        If myItem = "Yes" Then optAPDAllowance.Checked = True
        txtFPD.Text = xNodeRoot.SelectSingleNode("FPD").InnerText
        txtOutCap.Text = xNodeRoot.SelectSingleNode("OutCapacity").InnerText
        txtInletSize.Text = xNodeRoot.SelectSingleNode("InletSize").InnerText
        txtOutletSize.Text = xNodeRoot.SelectSingleNode("OutletSize").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//HotWaterCoil/Valves")
        txtValveTag.Text = xNodeRoot.SelectSingleNode("Tag").InnerText
        cmbValveSize.Text = xNodeRoot.SelectSingleNode("BodySize").InnerText
        cmbValveDesc.Text = xNodeRoot.SelectSingleNode("Description").InnerText
        txtValveType.Text = xNodeRoot.SelectSingleNode("Type").InnerText
        txtValveMPN.Text = xNodeRoot.SelectSingleNode("PartNo").InnerText
    End Sub
    Private Sub WriteModuleData()
        Dim myXMLSettings As New XmlWriterSettings
        Dim ModWriter As XmlWriter
        Dim TargetName, TargetPath, ArchivePath As String
        Dim SlashLoc As Integer
        Dim myItem As String
        Dim dummy As MsgBoxResult


        TargetName = "HWCoilData"
        TargetPath = frmMain.txtProjectDirectory.Text
        TargetPath = TargetPath & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\" & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & " - FUG-" & TargetName & "_" & Ver2FileVer(frmMain.txtUnitVersion.Text) & ".xml"
        If My.Computer.FileSystem.FileExists(TargetPath) Then
            dummy = MsgBox("A previous version of the mod data file exists.  Archive prior to writing?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbYes Then
                SlashLoc = InStrRev(TargetPath, "\")
                ArchivePath = Mid(TargetPath, 1, SlashLoc) & "Archive\" & Mid(TargetPath, SlashLoc + 1)
                My.Computer.FileSystem.MoveFile(TargetPath, ArchivePath)
            End If
        End If

        myXMLSettings.Indent = True
        myXMLSettings.NewLineOnAttributes = True

        ModWriter = XmlWriter.Create(TargetPath, myXMLSettings)
        ModWriter.WriteComment("Hot Water Coil Modification Definition File")

        ModWriter.WriteStartElement("HotWaterCoil")
        ModWriter.WriteString("Fisen HWCoil Modification")


        ModWriter.WriteStartElement("Conditions") '************************************************************************************************************

        ModWriter.WriteStartElement("HeatAF")
        ModWriter.WriteString(txtHeatAF.Text)
        ModWriter.WriteEndElement() 'HeatAF

        ModWriter.WriteStartElement("EAT")
        ModWriter.WriteString(txtEAT.Text)
        ModWriter.WriteEndElement() 'EAT

        ModWriter.WriteStartElement("InCap")
        ModWriter.WriteString(txtInputCap.Text)
        ModWriter.WriteEndElement() 'InCap

        ModWriter.WriteStartElement("EFT")
        ModWriter.WriteString(txtEFT.Text)
        ModWriter.WriteEndElement() 'EFT

        ModWriter.WriteStartElement("FluidFlow")
        ModWriter.WriteString(txtFluidFlow.Text)
        ModWriter.WriteEndElement() 'FluidFlow

        ModWriter.WriteStartElement("Fluid")
        ModWriter.WriteString(cmbFluidList.Text)
        ModWriter.WriteEndElement() 'Fluid

        ModWriter.WriteStartElement("FluidPer")
        ModWriter.WriteString(cmbFluidPer.Text)
        ModWriter.WriteEndElement() 'Fluid%

        ModWriter.WriteEndElement() 'Conditions
        '************************************************************************************************************

        ModWriter.WriteStartElement("Options") '************************************************************************************************************

        ModWriter.WriteStartElement("Coil")
        myItem = "Error"
        If optCoilCustom.Checked Then myItem = "Custom"
        If optCoil1Row.Checked Then myItem = "1Row"
        If optCoil2Row.Checked Then myItem = "2Row"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Coil

        ModWriter.WriteStartElement("Valve")
        If optValveNone.Checked Then myItem = "None"
        If optValve2Way.Checked Then myItem = "2Way"
        If optValve3Way.Checked Then myItem = "3Way"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Valve

        ModWriter.WriteStartElement("ValveInstall")
        If optValveFisenProvFisenInst.Checked Then myItem = "FisenProvFisenInst"
        If optValveFisenProvFieldInst.Checked Then myItem = "FisenProvFieldInst"
        If optValveFieldProvFieldInst.Checked Then myItem = "FieldProvFieldInst"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Valve Install

        ModWriter.WriteStartElement("ECoat")
        If chkEpoxy.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'ECoat

        ModWriter.WriteStartElement("DrawThrough")
        If chkS40DrawThroughCoil.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'DrawThrough

        ModWriter.WriteStartElement("SCCRBase")
        If chk65kASCCRBase.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'SCCRBase

        ModWriter.WriteStartElement("AuxPanel")
        If optNoAux.Checked Then myItem = "None"
        If optUseAux.Checked Then myItem = "UseAux"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'AuxPanel

        ModWriter.WriteStartElement("AuxPanelLoc")
        myItem = cmbAuxPanelOpts.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'AuxPanelLoc

        ModWriter.WriteEndElement() 'Options
        '************************************************************************************************************



        ModWriter.WriteStartElement("Controls") '************************************************************************************************************

        ModWriter.WriteStartElement("ValveControls")
        If optValveCtrlNone.Checked Then myItem = "None"
        If optValveCtrlBaseUnit.Checked Then myItem = "BaseUnit"
        If optValveCtrlFisenCustom.Checked Then myItem = "FisenCustom"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'ValveControls

        ModWriter.WriteStartElement("ValveControlsDetail")
        myItem = cmbValveCtrlFisenCustom.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'ValveControlsDetail

        ModWriter.WriteStartElement("BaseUnitControl")
        If optBU_SE_Fact_FisenWires.Checked Then myItem = "SE4StageByJCIFisenWires"
        If optBU_SE_Fisen_FisenWires.Checked Then myItem = "SE4StageByFisenFisenWires"
        If optBU_IPU_FisenWires.Checked Then myItem = "IPUFisenWires"
        If optBU_IPU_Unwired.Checked Then myItem = "IPUUnwired"
        If optBU_SE_Fact_Unwired.Checked Then myItem = "SE4StageByJCIUnwired"
        If optBU_SE_Fisen_Unwired.Checked Then myItem = "SE4StageByFisenUnwired"
        If optBU_Other.Checked Then myItem = "NotApplicable"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Base Unit Control

        ModWriter.WriteStartElement("LowLimitStat")
        If optLLUnwired.Checked Then myItem = "Unwired"
        If optLLWired.Checked Then myItem = "Wired"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'LowLimitStat

        ModWriter.WriteStartElement("BreakPower")
        If chkBreakonLL.Checked Then myItem = "Yes"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Break Power

        ModWriter.WriteStartElement("EquipmentTouch")
        If chkIncludeEquipmentTouch.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Equipement Touch

        ModWriter.WriteStartElement("MountTouch")
        If chkMountEquipmentTouch.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Mount Touch


        ModWriter.WriteEndElement() 'Controls
        '************************************************************************************************************

        ModWriter.WriteStartElement("Performance") '************************************************************************************************************
        ModWriter.WriteStartElement("LAT")
        myItem = txtLAT.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'LAT

        ModWriter.WriteStartElement("DeltaT")
        myItem = txtDeltaT.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'DeltaT

        ModWriter.WriteStartElement("LFT")
        myItem = txtLFT.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'LFT

        ModWriter.WriteStartElement("ActualAPD")
        myItem = txtActualAPD.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'ActualAPD

        ModWriter.WriteStartElement("SystemAPD")
        myItem = txtAPD.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'SystemAPD

        ModWriter.WriteStartElement("Allowance")
        If optAPDAllowance.Checked Then myItem = "Yes" Else myItem = "No"
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Allowance

        ModWriter.WriteStartElement("FPD")
        myItem = txtFPD.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'FPD

        ModWriter.WriteStartElement("OutCapacity")
        myItem = txtOutCap.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'OutCap

        ModWriter.WriteStartElement("InletSize")
        myItem = txtInletSize.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'inletsize

        ModWriter.WriteStartElement("OutletSize")
        myItem = txtOutletSize.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'outlet size

        ModWriter.WriteEndElement() 'Performance
        '************************************************************************************************************

        ModWriter.WriteStartElement("Valves") '************************************************************************************************************
        ModWriter.WriteStartElement("Tag")
        myItem = txtValveTag.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Tag

        ModWriter.WriteStartElement("BodySize")
        myItem = cmbValveSize.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'BodySize

        ModWriter.WriteStartElement("Description")
        myItem = cmbValveDesc.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Description

        ModWriter.WriteStartElement("Type")
        myItem = txtValveType.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'Type

        ModWriter.WriteStartElement("PartNo")
        myItem = txtValveMPN.Text
        ModWriter.WriteString(myItem)
        ModWriter.WriteEndElement() 'PartNo


        ModWriter.WriteEndElement() 'Valves
        '************************************************************************************************************


        ModWriter.WriteEndElement() 'HotWaterCoil
        ModWriter.WriteEndDocument()
        ModWriter.Close()

        ModWriter = Nothing
    End Sub


End Class