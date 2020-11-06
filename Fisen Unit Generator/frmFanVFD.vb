Imports System.Xml
Public Class frmFanVFD
    Private pCancelled As Boolean
    Private Property pFanType As String
    Private ModuleCodeList As New ArrayList
    Private pResearchMode As Boolean

    Public Property ResearchMode As Boolean
        Get
            Return pResearchMode
        End Get
        Set(value As Boolean)
            pResearchMode = value
        End Set
    End Property

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property FanType As String
        Get
            Return pFanType
        End Get
        Set(value As String)
            pFanType = value
        End Set
    End Property

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()

        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList(False)
        Call UpdateBaseUnitRequiredItems()
        'Call UpdateBaseUnitDrawingTags
        'Call UpdateReferTags
        'Call UpdateAFTags
        'Call HydroTags

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        Select Case pFanType
            Case Is = "Supply Fan"
                frmMain.lstRequiredFactoryItems.Items.Add("Base Unit Equipped with Supply Fan from JCI")
            Case Is = "Return Fan"
                frmMain.lstRequiredFactoryItems.Items.Add("Base Unit Equipped with Return Fan from JCI")
            Case Is = "Exhaust Fan"
                frmMain.lstRequiredFactoryItems.Items.Add("Base Unit Equipped with Exhaust Fan from JCI")
        End Select

    End Sub
    Private Sub UpdateCodeList(Preview As Boolean)


        ModuleCodeList.Clear()
        Select Case pFanType
            Case Is = "Supply Fan"
                If Not (Preview) Then frmMain.ThisUnitMods.Add("SFanVFD") 'Mod Code goes here!
                'Add the level 0 code
                ModuleCodeList.Add("301100") 'Fan Variable Frequency Drive
                If chkSFanVFD.Checked Then
                    ModuleCodeList.Add("301101") 'Supply Fan VFD Install
                    If chkSFanBypass.Checked Then ModuleCodeList.Add("301102")
                    If chkSFanBypass.Checked = False Then ModuleCodeList.Add("301150")
                    If chkSFanDisconnect.Checked Then ModuleCodeList.Add("301103")
                    If chkRemotePad.Checked Then ModuleCodeList.Add("301104")
                    If chkSpecificVFD.Checked Then
                        ModuleCodeList.Add("301105")
                        Select Case cmbVFDBrand.Text
                            Case Is = "Danfoss VLT HVAC - FC 102"
                                ModuleCodeList.Add("301200")
                            Case Is = "ABB Eclipse"
                                ModuleCodeList.Add("301203")
                            Case Is = "Fisen Standard"
                                ModuleCodeList.Add("301202")
                            Case Is = "Rockwell Automation Power Flex 753"
                                ModuleCodeList.Add("301204")
                            Case Else
                                ModuleCodeList.Add("301202")
                        End Select
                    End If
                    If chkBACnet.Checked Then
                        ModuleCodeList.Add("301106")
                        If cmbVFDBrand.Text = "Danfoss VLT HVAC - FC 102" Then
                            ModuleCodeList.Add("301201")
                        End If
                        frmMain.ThisUnit.CommNodes = "2"
                    End If
                    If chkNEMA4xDrive.Checked Then ModuleCodeList.Add("301109")

                    'Handle the Controls
                    If optSFanSEVFDReady.Checked Then ModuleCodeList.Add("301110")
                    If optSFanFisenLCVAV.Checked Then ModuleCodeList.Add("301120")
                    If optSFanSELCVAV.Checked Then ModuleCodeList.Add("301130")
                    If optSFanBalanceOnly.Checked Then ModuleCodeList.Add("301125")

                End If
                If chk65kASCCRBase.Checked Then ModuleCodeList.Add("301F6A")
            Case Is = "Return Fan"
                If chk65kASCCRBase.Checked Then ModuleCodeList.Add("302F6A")
            Case Is = "Exhaust Fan"
                If chk65kASCCRBase.Checked Then ModuleCodeList.Add("303F6A")
        End Select



        'use logic to step through the controls to determine the codes and use the above format...
        If Not (Preview) Then
            If chkMountEquipmentTouch.Checked = True Then
                If frmMain.HasUMHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960002") 'Adds an HMI
                End If
            End If
            If chkIncludeEquipmentTouch.Checked = True Then
                If frmMain.HasHMI = False Then
                    frmMain.ThisUnitGenCodes.Add("960001") 'Adds an HMI
                End If
            End If

            Call AuxPanelCodeInsert()
        End If

    End Sub
    Private Sub AuxPanelCodeInsert() 'Called from near the end of UpdateCode()
        'V1.2 - Added Support for Blank Family
        'V1.1 - Added Custom Option for LX Series Units.
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
                Case Is = "LX Series Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960027")
                Case Is = "Series 100 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960023")
                Case Is = "Premier Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960024")
                Case Is = "Choice Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960025")
                Case Is = "Select Cabinet Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960026")
                Case Is = "Generic Unit Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960028")

            End Select
        End If
    End Sub

    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.MotorTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim dummy As MsgBoxResult
        Dim BlankInput As String
        Dim errmsg As String

        'Next Line is the line item description i.e. Hot Water Description
        tempWeight = "9999"
        If chkSFanVFD.Checked Then
            'next line is the mod code i.e. HWCoil...
            frmMain.ThisUnitPhysicalData.ModLoadMod.Add("SFanVFD")

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
                Case Is = "Choice"
                    tempWeight = "35"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Premier"
                    tempWeight = "40"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Select"
                    tempWeight = "35"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)

                Case Is = "Blank"
                    BlankInput = InputBox("What weight for the VFD?", "SFanVFD:UpdateWeightTable", "40")
                    tempWeight = BlankInput
                    If chkSFanBypass.Checked Then tempWeight = Format(Val(tempWeight) * 1.33, "0")
                    If chkSFanDisconnect.Checked Then tempWeight = Format(Val(tempWeight) * 1.1, "0")
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "SeriesLX"
                    tempWeight = "25"
                    If chkSFanBypass.Checked Then tempWeight = "35"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Else
                    tempWeight = "9999"
                    errmsg = "Error assigning weight in SFanVFD:UpdateWeightTable." & vbCrLf & "Continue using 9999 or cancel?"
                    dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop

            End Select
            frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
        End If

        If chkRFanVFD.Checked Then
            'next line is the mod code i.e. HWCoil...
            frmMain.ThisUnitPhysicalData.ModLoadMod.Add("RFanVFD")

            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Return Fan VFD")

            'Now it's logic to assign the values.
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    tempWeight = "25"
                    If chkRFanBypass.Checked Then tempWeight = "35"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Is = "Series10"
                    tempWeight = "30"
                    If chkRFanBypass.Checked Then tempWeight = "35"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 12)
                Case Is = "Series20"
                    tempWeight = "35"
                    If chkRFanBypass.Checked Then tempWeight = "45"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Series40"
                    tempWeight = "40"
                    If chkRFanBypass.Checked Then tempWeight = "45"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Series 100"
                    tempWeight = "65"
                    If chkRFanBypass.Checked Then tempWeight = "70"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 40)
                Case Is = "Choice"
                    tempWeight = "35"
                    If chkRFanBypass.Checked Then tempWeight = "45"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Premier"
                    tempWeight = "40"
                    If chkRFanBypass.Checked Then tempWeight = "45"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Select"
                    tempWeight = "35"
                    If chkRFanBypass.Checked Then tempWeight = "45"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "SeriesLX"
                    tempWeight = "25"
                    If chkRFanBypass.Checked Then tempWeight = "35"
                    If chkRFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Is = "Blank"
                    BlankInput = InputBox("What weight for the VFD?", "SFanVFD:UpdateWeightTable", "40")
                    tempWeight = BlankInput
                    If chkRFanBypass.Checked Then tempWeight = Format(Val(tempWeight) * 1.33, "0")
                    If chkRFanDisconnect.Checked Then tempWeight = Format(Val(tempWeight) * 1.1, "0")
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Else
                    tempWeight = "9999"
                    errmsg = "Error assigning weight in RFanVFD:UpdateWeightTable." & vbCrLf & "Continue using 9999 or cancel?"
                    dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop

            End Select
            frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
        End If
        If chkXFanVFD.Checked Then
            'next line is the mod code i.e. HWCoil...
            frmMain.ThisUnitPhysicalData.ModLoadMod.Add("XFanVFD")

            frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Exhaust Fan VFD")

            'Now it's logic to assign the values.
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    tempWeight = "25"
                    If chkXFanBypass.Checked Then tempWeight = "35"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Is = "Series10"
                    tempWeight = "30"
                    If chkXFanBypass.Checked Then tempWeight = "35"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 12)
                Case Is = "Series20"
                    tempWeight = "35"
                    If chkXFanBypass.Checked Then tempWeight = "45"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Series40"
                    tempWeight = "40"
                    If chkXFanBypass.Checked Then tempWeight = "45"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Series 100"
                    tempWeight = "65"
                    If chkXFanBypass.Checked Then tempWeight = "70"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 40)
                Case Is = "Choice"
                    tempWeight = "35"
                    If chkSFanBypass.Checked Then tempWeight = "45"
                    If chkSFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "Premier"
                    tempWeight = "40"
                    If chkXFanBypass.Checked Then tempWeight = "45"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Is = "Select"
                    tempWeight = "35"
                    If chkXFanBypass.Checked Then tempWeight = "45"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 20)
                Case Is = "SeriesLX"
                    tempWeight = "25"
                    If chkXFanBypass.Checked Then tempWeight = "35"
                    If chkXFanDisconnect.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 10)
                Case Is = "Blank"
                    BlankInput = InputBox("What weight for the VFD?", "SFanVFD:UpdateWeightTable", "40")
                    tempWeight = BlankInput
                    If chkXFanBypass.Checked Then tempWeight = Format(Val(tempWeight) * 1.33, "0")
                    If chkXFanDisconnect.Checked Then tempWeight = Format(Val(tempWeight) * 1.1, "0")
                    If chkNEMA4xDrive.Checked Then tempWeight = Str(Val(tempWeight) + 30)
                Case Else
                    tempWeight = "9999"
                    errmsg = "Error assigning weight in SFanVFD:UpdateWeightTable." & vbCrLf & "Continue using 9999 or cancel?"
                    dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop

            End Select
            frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
        End If


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

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs)
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub
    Private Sub PopulateAuxPanelList()
        'V1.3 Added Blank Unit Support
        'V1.2 Added LX Series Support
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
                    Case Is = "SeriesLX"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("LX Series Custom Application")
                        cmbAuxPanelOpts.Text = "LX Series Custom Application"
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
                    Case Is = "Blank"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Generic Unit Custom Application")
                        cmbAuxPanelOpts.Text = "Generic Unit Custom Application"
                End Select
            End If
        End If
    End Sub


    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub frmFanVFD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dummy As MsgBoxResult
        Dim TitleText As String

        pCancelled = False

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series10"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series12"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series20"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series40"
                'Depricated *Probably not going to be used*
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Series100"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Premier"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Choice"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Select"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Is = "Blank"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
            Case Else
                dummy = MsgBox("Error in FanVFD:Form Load for Unknown Family: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, "Fisen Unit Generator")
                Stop
        End Select

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        TitleText = "Install VFD for Fan"
        Select Case Me.FanType
            Case Is = "Supply Fan"
                chkSFanVFD.Visible = True
                chkSFanVFD.Checked = True
                chkSFanVFD.Enabled = False
                chkSFanBypass.Visible = True
                chkSFanDisconnect.Visible = True
                TitleText = "Supply Fan VFD"
                ModuleCodeList.Add("301100")
            Case Is = "Return Fan"
                chkRFanVFD.Visible = True
                chkRFanVFD.Checked = True
                chkRFanVFD.Enabled = False
                chkRFanBypass.Visible = True
                chkRFanDisconnect.Visible = True
                TitleText = "Return Fan VFD"
                ModuleCodeList.Add("302100")
            Case Is = "Exhaust Fan"
                chkXFanVFD.Visible = True
                chkXFanVFD.Checked = True
                chkXFanVFD.Enabled = False
                chkXFanBypass.Visible = True
                chkXFanDisconnect.Visible = True
                TitleText = "Exhaust Fan VFD"
                ModuleCodeList.Add("303100")
        End Select
        Me.Text = TitleText

        Call PopulateAuxPanelList()
        cmbVFDBrand.Text = "Fisen Standard"

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        If frmMain.HasHMI Then
            chkIncludeEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Enabled = False
        End If

        If frmMain.HasUMHMI Then
            chkMountEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Checked = True
            chkIncludeEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Enabled = False
        End If


        If pResearchMode Then Call SetupResearchMode()
    End Sub

    Private Sub SetupResearchMode()
        Me.Text = Me.Text & " ***Research Mode***"
        chkWriteHistory.Checked = False
        chkWriteHistory.Enabled = False
    End Sub

    Private Sub WriteHistory()
        'Created as V2 on 10 Jun 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim WhichFan, Bypass, Disconnect, VFDBrand, NEMA4X, Controls As String

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

        WhichFan = pFanType
        Bypass = "No"
        If chkSFanBypass.Checked Then Bypass = "Yes"
        If chkRFanBypass.Checked Then Bypass = "Yes"
        If chkXFanBypass.Checked Then Bypass = "Yes"
        Disconnect = "No"
        If chkSFanDisconnect.Checked Then Disconnect = "Yes"
        If chkRFanDisconnect.Checked Then Disconnect = "Yes"
        If chkXFanDisconnect.Checked Then Disconnect = "Yes"

        VFDBrand = cmbVFDBrand.Text
        If chkNEMA4xDrive.Checked Then NEMA4X = "Yes" Else NEMA4X = "No"

        Select Case pFanType
            Case Is = "Supply Fan"
                If optSFanSEVFDReady.Checked Then Controls = "SFan VFD Ready"
                If optSFanSELCVAV.Checked Then Controls = "SFan SE LCVAV"
                If optSFanFisenLCVAV.Checked Then Controls = "SFan Fisen LCVAV"
                If optSFanBalanceOnly.Checked Then Controls = "SFan Balance Only"
            Case Is = "Return Fan"
            Case Is = "Exhaust Fan"

        End Select

        MySQL = "Select * FROM tblHistoryFanVFD WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryFanVFD SET WhichFan='" & WhichFan & "', Bypass='" & Bypass & "', " & "Disconnect='" & Disconnect & "', " & "VFDBrand='" & VFDBrand & "', " & "NEMA4X='" & NEMA4X & "', " & "Controls='" & Controls & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryFanVFD (JobName,UnitID,Version,ModelNumber,WhichFan,Bypass,Disconnect,VFDBrand,NEMA4X,Controls) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & WhichFan & "','" & Bypass & "','" & Disconnect & "','" & VFDBrand & "','" & NEMA4X & "','" & Controls & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/OA100")
        If Me.FanType = "Supply Fan" Then
            xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/SFVFD")
            TempVal = xNodeRoot.SelectSingleNode("Bypass").InnerText
            If TempVal = "Yes" Then chkSFanBypass.Checked = True Else chkSFanBypass.Checked = False

            TempVal = xNodeRoot.SelectSingleNode("Disconnect").InnerText
            If TempVal = "Yes" Then chkSFanDisconnect.Checked = True Else chkSFanDisconnect.Checked = False

        End If

        If Me.FanType = "Return Fan" Then
            xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/RFVFD")

            TempVal = xNodeRoot.SelectSingleNode("Bypass").InnerText
            If TempVal = "Yes" Then chkRFanBypass.Checked = True Else chkRFanBypass.Checked = False

            TempVal = xNodeRoot.SelectSingleNode("Disconnect").InnerText
            If TempVal = "Yes" Then chkRFanDisconnect.Checked = True Else chkRFanDisconnect.Checked = False

        End If

        If Me.FanType = "Exhaust Fan" Then
            xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/XFVFD")

            TempVal = xNodeRoot.SelectSingleNode("Bypass").InnerText
            If TempVal = "Yes" Then chkXFanBypass.Checked = True Else chkXFanBypass.Checked = False

            TempVal = xNodeRoot.SelectSingleNode("Disconnect").InnerText
            If TempVal = "Yes" Then chkXFanDisconnect.Checked = True Else chkXFanDisconnect.Checked = False

        End If


    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click

        If pFanType = "Supply Fan" Then frmHistoryReport.MyModule = "SFanVFD"
        If pFanType = "Return Fan" Then frmHistoryReport.MyModule = "RFanVFD"
        If pFanType = "Exhaust Fan" Then frmHistoryReport.MyModule = "XFanVFD"
        frmHistoryReport.Show()

    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        'Version 1.0 - Requires specificity(2 places) to be performed when inserted.
        'Version 1.0M - Modified for specific fan types

        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer
        Dim FanTypeCode As String

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

        FanTypeCode = "999"
        Select Case pFanType
            Case Is = "Supply Fan"
                FanTypeCode = "301"
            Case Is = "Return Fan"
                FanTypeCode = "302"
            Case Is = "Exhaust Fan"
                FanTypeCode = "303"
        End Select


        For i = 0 To ModuleCodeList.Count - 1


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '" & FanTypeCode & "%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '" & FanTypeCode & "%'"
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

    Private Sub cmdFIOPPreview_Click(sender As Object, e As EventArgs) Handles cmdFIOPPreview.Click
        'version 1.0
        'Version 1.0M - Customized to handle the three different codes for the different fans
        'Modify: Code XXX in SQL declaration below.

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer

        Dim MySQL As String
        Dim FanCode As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Call UpdateCodeList(True)

        FanCode = "999"
        If pFanType = "Supply Fan" Then FanCode = "301"
        If pFanType = "Return Fan" Then FanCode = "302"
        If pFanType = "Exhaust Fan" Then FanCode = "303"

        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode LIKE '" & FanCode & "%'"
        rs.Open(MySQL, con)

        For i = 0 To ModuleCodeList.Count - 1
            rs.MoveFirst()
            rs.Find("FIOpCode='" & ModuleCodeList(i) & "'")
            OneLine = ""
            For j = 1 To Val(rs.Fields("Level").Value)
                OneLine = OneLine & "\tab "
            Next
            OneLine = OneLine & rs.Fields("Description").Value & " - " & rs.Fields("FIopCode").Value & "\par "
            AllLines.Append(OneLine)
        Next
        AllLines.Append("}")

        con.Close()
        rs = Nothing
        con = Nothing

        frmFIOPPreview.ReportData = AllLines.ToString
        frmFIOPPreview.Show()

    End Sub
End Class