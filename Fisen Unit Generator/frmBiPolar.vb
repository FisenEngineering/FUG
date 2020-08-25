Imports System.Reflection
Imports System.Xml
Imports Microsoft.Office.Interop.Excel

Public Class frmBiPolar
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
        Call UpdateWarrantyItems()

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

    Private Sub UpdateCodeList(Preview As Boolean)
        Dim errmsg As String
        Dim dummy As MsgBoxResult
        Dim snippet As String

        frmMain.ThisUnitMods.Add("BiPolar") 'Mod Code goes here!
        ModuleCodeList.Clear()
        ModuleCodeList.Add("430000")

        Select Case cmbBipolarStyle.Text
            Case Is = "Use Standard"
                ModuleCodeList.Add("430001")
                Select Case frmMain.ThisUnit.Family
                    Case Is = "Series5"
                        ModuleCodeList.Add("430Z05")
                    Case Is = "Series10"
                        ModuleCodeList.Add("430Z03")
                    Case Is = "Series12"
                        ModuleCodeList.Add("430Z06")
                    Case Is = "Series20"
                        ModuleCodeList.Add("430Z04")
                    Case Is = "Series40"
                 'Depricated *Probably not going to be used*
                    Case Is = "Series100"
                        If frmMain.ThisUnit.Cabinet = "Series100A" Then ModuleCodeList.Add("430Z08")
                        If frmMain.ThisUnit.Cabinet = "Series100B" Then ModuleCodeList.Add("430Z09")
                        If frmMain.ThisUnit.Cabinet = "Series100C" Then ModuleCodeList.Add("430Z0A")
                    Case Is = "Choice"
                        ModuleCodeList.Add("430Z07")
                    Case Is = "Select"
                        snippet = Mid(frmMain.ThisUnit.ModelNumber, 3, 2)
                        If snippet = "35" Then ModuleCodeList.Add("430Z01")
                        If snippet = "40" Then ModuleCodeList.Add("430Z0B")
                        If snippet = "50" Then ModuleCodeList.Add("430Z02")
                    Case Else
                        errmsg = "Error assigning weight in Bipolar:UpdateCodeList. BiPolarStyle Error" & vbCrLf & "Continue or cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                        If dummy = vbCancel Then Stop
                End Select
            Case Is = "CP Plasma Bar #PB-066"
                ModuleCodeList.Add("430002")
                ModuleCodeList.Add("430Q01")
            Case Else
                errmsg = "Error assigning PlasmaBar Style Bipolar:UpdateCodeList." & vbCrLf & "Continue or cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                If dummy = vbCancel Then Stop
        End Select

        If optInstDSEvap.Checked Then ModuleCodeList.Add("430Y02")
        If optInstUSEvap.Checked Then ModuleCodeList.Add("430Y01")
        If chkInstHGRHCoil.Checked Then ModuleCodeList.Add("430Y03")


        ModuleCodeList.Add("430100")
        If optPwrConvOutlet.Checked Then
            ModuleCodeList.Add("430101")
            ModuleCodeList.Add("430102")
        End If
        If optPwrUnitPower.Checked Then
            ModuleCodeList.Add("430104")
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    ModuleCodeList.Add("430X01")
                Case Is = "Series10"
                    ModuleCodeList.Add("430X01")
                Case Is = "Series12"
                    ModuleCodeList.Add("430X01")
                Case Is = "Series20"
                    ModuleCodeList.Add("430X01")
                Case Is = "Series40"
                 'Depricated *Probably not going to be used*
                Case Is = "Series100"
                    ModuleCodeList.Add("430X01")
                Case Is = "Premier"
                    ModuleCodeList.Add("430X01")
                Case Is = "Choice"
                    ModuleCodeList.Add("430X01")
                Case Is = "Select"
                    ModuleCodeList.Add("430X01")
                Case Else
                    errmsg = "Error assigning Transformer Size in Bipolar:UpdateCodeList." & vbCrLf & optPwrUnitPower.Checked & " is undefined.  Continue or cancel?"
                    dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop
            End Select
        End If
        If optPwrDedicated.Checked Then ModuleCodeList.Add("430103")

        ModuleCodeList.Add("430200")
        If chkEMControlsOnly.Checked Then ModuleCodeList.Add("430210")
        If optCtrl247.Checked Then ModuleCodeList.Add("430201")
        If optCtrlWithSupplyFan.Checked Then ModuleCodeList.Add("430202")
        If optCtrlCustom.Checked Then
            ModuleCodeList.Add("430205")
            'Code for custom controls.
        End If

        If Not (Preview) Then
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
                    Case Is = "Premier Cabinet Custom Application"
                        frmMain.ThisUnitGenCodes.Add("960024")
                    Case Is = "Choice Cabinet Custom Application"
                        frmMain.ThisUnitGenCodes.Add("960025")
                    Case Is = "Select Cabinet Custom Application"
                        frmMain.ThisUnitGenCodes.Add("960026")
                End Select
            End If
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("420F6A")
        End If

    End Sub

    Private Sub WriteHistory()
        'Created as V2 on 10 Jun 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim PowerSource, ControlStyle, InstallLocation, BarStyle As String

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

        PowerSource = "N/A"
        If optPwrConvOutlet.Checked Then PowerSource = "Convenience Outlet"
        If optPwrUnitPower.Checked Then PowerSource = "Unit Powered"
        If optPwrDedicated.Checked Then PowerSource = "Dedicated Connection"

        ControlStyle = "N/A"
        If optCtrl247.Checked Then ControlStyle = "24-7 Operation"
        If optCtrlWithSupplyFan.Checked Then ControlStyle = "With Supply Fan"
        If optCtrlCustom.Checked Then ControlStyle = "Custom Controls"

        InstallLocation = "N/A"
        If optInstUSEvap.Checked Then InstallLocation = "Pre Evap"
        If optInstDSEvap.Checked Then InstallLocation = "Post Evap"
        If chkInstHGRHCoil.Checked Then InstallLocation = InstallLocation & "-Post HGRH"

        BarStyle = cmbBipolarStyle.Text

        MySQL = "Select * FROM tblHistoryBiPolar WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryBiPolar SET PowerSource='" & PowerSource & "', ControlStyle='" & ControlStyle & "', " & "InstallLocation='" & InstallLocation & "', " & "BarStyle='" & BarStyle & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryBiPolar (JobName,UnitID,Version,ModelNumber,PowerSource,ControlStyle,InstallLocation,BarStyle) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & PowerSource & "','" & ControlStyle & "','" & InstallLocation & "','" & BarStyle & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub UpdateBaseUnitRequiredItems()
        If optPwrConvOutlet.Checked Then frmMain.lstRequiredFactoryItems.Items.Add("Powered Convenience Outlet")
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim dummy As MsgBoxResult
        Dim errmsg As String

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("BiPolar")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Bipolar Airstream Ionization")

        'Now it's logic to assign the values.
        tempWeight = 0
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "2"
            Case Is = "Series10"
                tempWeight = "2"
            Case Is = "Series20"
                tempWeight = "4"
            Case Is = "Series40"
                tempWeight = "7"
            Case Is = "Series100"
                If frmMain.ThisUnit.Cabinet = "Series100A" Then tempWeight = "7"
                If frmMain.ThisUnit.Cabinet = "Series100B" Then tempWeight = "14"
                If frmMain.ThisUnit.Cabinet = "Series100C" Then tempWeight = "16"
            Case Is = "Premier"
                tempWeight = "16"
            Case Is = "Choice"
                tempWeight = "7"
            Case Is = "Select"
                tempWeight = "7"
            Case Else
                tempWeight = "9999"
                errmsg = "Error assigning weight In Bipolar:UpdateWeightTable." & vbCrLf & "Continue using 9999 or cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                If dummy = vbCancel Then Stop
        End Select

        If optPwrUnitPower.Checked Then tempWeight = Trim(Str(Val(tempWeight) + 30))

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub UpdatePerformance()
        Dim NewRow As String()
        Dim RqdVA As Double
        Dim XFmrVA As Double
        Dim PriVolts As Double
        Dim PrimeAmps As Double
        Dim ElecChar As String
        Dim dummy As MsgBoxResult
        Dim PutOnEmergency As Boolean
        Dim PutOnCommercial As Boolean


        PutOnEmergency = False

        PriVolts = Val(frmMain.ThisUnitElecData.CommVolts)
        ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                RqdVA = 3
                XFmrVA = 50
            Case Is = "Series10"
                RqdVA = 4
                XFmrVA = 50
            Case Is = "Series20"
                RqdVA = 8
                XFmrVA = 50
            Case Is = "Select"
                RqdVA = 15
                XFmrVA = 50
            Case Is = "Choice"
                RqdVA = 8
                XFmrVA = 50
            Case Is = "Series100"
                If frmMain.ThisUnit.Cabinet = "Series100A" Then RqdVA = 15
                If frmMain.ThisUnit.Cabinet = "Series100B" Then RqdVA = 35
                If frmMain.ThisUnit.Cabinet = "Series100C" Then RqdVA = 49
                XFmrVA = 50
            Case Else
                RqdVA = 2000
                XFmrVA = 2000
                dummy = MsgBox("Unit type undefined in 'BiPolar:Update Performance'" & vbCrLf & "Using Bogus Value.", vbOKCancel, "Fisen Unit Generator")
                If dummy = vbCancel Then Stop
        End Select

        If optPwrUnitPower.Checked Then
            PrimeAmps = XfmrPrimaryAmps(PriVolts, XFmrVA)
            If PrimeAmps > 0.9999 Then
                If optDPPEmergency.Checked Then PutOnEmergency = True
                PutOnCommercial = Not (PutOnEmergency)
                NewRow = {True, False, "All", PutOnCommercial, "Bipolar Ionization Transformer", ElecChar, "-", Format(PrimeAmps, "0.0"), PutOnEmergency, "Math"}
                frmMain.ThisUnitElecData.ModLoad.Add(NewRow)
                frmMain.chkUseCustomMCA.Checked = True
            End If
        End If

        If optPwrConvOutlet.Checked Then
            frmMain.ThisUnitElecData.COPLoadsPresent = True
            frmMain.ThisUnitElecData.COPLoad.Add("Bipolar Ionization Unit," & Format(RqdVA, "0.0"))
        End If

    End Sub

    Private Sub frmBiPolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call PopulateAuxPanelList()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
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



        If frmMain.ThisUnitElecData.DPPPresent Then grpDPPCkt.Visible = True
        cmbBipolarStyle.Text = "Use Standard"

        ModuleCodeList.Add("430000")
        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/BiPolar")

        TempVal = xNodeRoot.SelectSingleNode("PowerSource").InnerText
        If TempVal = "Convenience Outlet" Then optPwrConvOutlet.Checked = True
        If TempVal = "Dedicated Circuit" Then optPwrDedicated.Checked = True
        If TempVal = "Unit Powered" Then optPwrUnitPower.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("BiPolarStyle").InnerText
        If TempVal = "Use Standard" Then cmbBipolarStyle.Text = "Use Standard"
        If TempVal = "CP Plasma Bar #PB-066" Then cmbBipolarStyle.Text = "CP Plasma Bar #PB-066"



    End Sub
    Private Sub PopulateAuxPanelList()
        'V1.1 Added Check for it already existing
        If frmMain.HasAuxillaryPanel = True Then
            optUseAux.Checked = True
            fraAuxPanel.Enabled = False
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
    Private Sub optPwrUnitPower_CheckedChanged(sender As Object, e As EventArgs) Handles optPwrUnitPower.CheckedChanged
        If optPwrUnitPower.Checked And frmMain.ThisUnitElecData.DPPPresent Then
            optDPPCommercial.Checked = True
            optDPPNA.Enabled = False
        End If

        If optPwrUnitPower.Checked = False Then
            optDPPNA.Checked = True
            optDPPNA.Enabled = True
            optDPPCommercial.Enabled = False
            optDPPEmergency.Enabled = False
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '430%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '430%'"
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

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "BiPolar"
        frmHistoryReport.cmbModCode.Text = "BiPolar"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdFIOPPreview_Click(sender As Object, e As EventArgs) Handles cmdFIOPPreview.Click
        'version 1.0
        'Modify: Code XXX in SQL declaration below.

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Call UpdateCodeList(True)

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

        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode LIKE '430%'"
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

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
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

    Private Sub chkMountEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkMountEquipmentTouch.CheckedChanged

    End Sub
End Class