Imports System.Runtime.CompilerServices
Imports System.Xml
Public Class frmUVLights
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

        Call UpdateCodeList()
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

        frmMain.DesignNotes = frmMain.DesignNotes & txtDesignNotesHard.Text & vbCrLf & vbCrLf & txtDesignNotesSoft.Text

        Me.Hide()
    End Sub
    Private Sub UpdateBaseUnitRequiredItems()
        If optPwrConvOutlet.Checked Then frmMain.lstRequiredFactoryItems.Items.Add("Powered Convenience Outlet")
    End Sub

    Private Sub UpdateCodeList()
        Dim snippet As String

        frmMain.ThisUnitMods.Add("UVLights") 'Mod Code goes here!
        ModuleCodeList.Clear()
        ModuleCodeList.Add("420000")

        ModuleCodeList.Add("420001")
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                ModuleCodeList.Add("420Z05")
            Case Is = "Series10"
                ModuleCodeList.Add("420Z03")
            Case Is = "Series12"
                ModuleCodeList.Add("420Z06")
            Case Is = "Series20"
                ModuleCodeList.Add("420Z04")
            Case Is = "Series40"
                 'Depricated *Probably not going to be used*
            Case Is = "Series100"

            Case Is = "Premier"

            Case Is = "Choice"

            Case Is = "Select"
                snippet = Mid(frmMain.ThisUnit.ModelNumber, 3, 2)
                If snippet = "35" Then ModuleCodeList.Add("420Z01")
                If snippet = "50" Then ModuleCodeList.Add("420Z02")
            Case Is = "SeriesLX"
                ModuleCodeList.Add("420Z07")
            Case Else

        End Select

        If optInstDSEvap.Checked Then ModuleCodeList.Add("420Y02")
        If optInstUSEvap.Checked Then ModuleCodeList.Add("420Y03")
        If chkInstHGRHCoil.Checked Then ModuleCodeList.Add("420Y01")

        ModuleCodeList.Add("420100")
        If optPwrConvOutlet.Checked Then
            ModuleCodeList.Add("420101")
            ModuleCodeList.Add("420102")
        End If
        If optPwrUnitPower.Checked Then
            If Not (chkShareXfmr.Checked) Then
                ModuleCodeList.Add("420104")
                If frmMain.ThisUnit.Family = "Select" Then ModuleCodeList.Add("420X03")
                If frmMain.ThisUnit.Family = "Series10" Then ModuleCodeList.Add("420X01")
                If frmMain.ThisUnit.Family = "Series5" Then ModuleCodeList.Add("420X01")
                If frmMain.ThisUnit.Family = "Series20" Then ModuleCodeList.Add("420X02")
                If frmMain.ThisUnit.Family = "SeriesLX" Then ModuleCodeList.Add("420X01")
            Else
                ModuleCodeList.Add("420105")
                If frmMain.ThisUnit.Family = "Series12" Then ModuleCodeList.Add("420X04")
                If frmMain.ThisUnit.Family = "Series20" Then ModuleCodeList.Add("420X02")
            End If
            End If
            If optPwrDedicated.Checked Then ModuleCodeList.Add("420103")

        ModuleCodeList.Add("420200")
        If chkEMControlsOnly.Checked Then ModuleCodeList.Add("420210")

        If optCtrl247.Checked Then ModuleCodeList.Add("420201")
        If optCtrlWithSupplyFan.Checked Then ModuleCodeList.Add("420203")
        If optCtrlWithComps.Checked Then ModuleCodeList.Add("420204")
        If optCtrlCustom.Checked Then
            ModuleCodeList.Add("420205")
            'Code for custom controls.
        End If
        If chkDoorSafetySwitch.Checked Then ModuleCodeList.Add("420202")

        ModuleCodeList.Add("420300")
        ModuleCodeList.Add("420301")


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

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("420F6A")
        End If

    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("UVLights")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Ultraviolet Lights")

        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "55"
            Case Is = "Series10"
                tempWeight = "65"
            Case Is = "Series12"
                tempWeight = "65"
            Case Is = "Series20"
                tempWeight = "85"
            Case Is = "Series40"
                tempWeight = "125"
            Case Is = "Series100"
                tempWeight = "150"
            Case Is = "Premier"
                tempWeight = "150"
            Case Is = "Choice"
                tempWeight = "120"
            Case Is = "Select"
                tempWeight = "125"
            Case Is = "SeriesLX"
                tempWeight = "65"
            Case Else
                tempWeight = "9999"
        End Select

        If optPwrUnitPower.Checked Then tempWeight = Trim(Str(Val(tempWeight) + 30))

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub UpdatePerformance()
        Dim NewRow As String()
        Dim RqdVA, XfmrVA As Double
        Dim PriVolts As Double
        Dim PrimeAmps As Double
        Dim ElecChar As String
        Dim dummy As MsgBoxResult

        Dim lDesignNote As String

        PriVolts = Val(frmMain.ThisUnitElecData.CommVolts)
        ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
        If optPwrUnitPower.Checked Then
            Select Case frmMain.ThisUnit.Family
                Case Is = "Series5"
                    RqdVA = 66
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 100 Else XfmrVA = 150
                Case Is = "Series10"
                    If Not (chkShareXfmr.Checked) Then
                        XfmrVA = 100
                        txtDesignNotesHard.Text = txtDesignNotesHard.Text & "UV Light Transformer is 100VA - Non Shared." & vbCrLf
                        lDesignNote = Format(100 / frmMain.ThisUnitElecData.CommVolts, "0.0")
                        frmMain.txtElecFisenLoadNotesComm.Text = frmMain.txtElecFisenLoadNotesComm.Text & "Fisen added load: UVLights - 100va Transformer - " & lDesignNote & " A Primary Current" & vbCrLf
                    Else
                        XfmrVA = 150
                    End If
                    RqdVA = 84
                Case Is = "Series12"
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 100 Else XfmrVA = 150
                    RqdVA = 84
                Case Is = "SeriesLX"
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 100 Else XfmrVA = 150
                    RqdVA = 84
                Case Is = "Series20"
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 250 Else XfmrVA = 250
                    RqdVA = 170
                Case Is = "Select"
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 500 Else XfmrVA = 500
                    RqdVA = 340
                Case Is = "Series100"
                    'Needs Fixing!!!!!
                    dummy = MsgBox("Unit type undefined in 'BiPolar:Update Performance'" & vbCrLf & "Using Bogus Value.", vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop
                    If frmMain.ThisUnit.Cabinet = "Series100A" Then RqdVA = 340 Else XfmrVA = 250
                    If frmMain.ThisUnit.Cabinet = "Series100B" Then RqdVA = 340 Else XfmrVA = 250
                    If frmMain.ThisUnit.Cabinet = "Series100C" Then RqdVA = 680 Else XfmrVA = 250
                    If Not (chkShareXfmr.Checked) Then XfmrVA = 500 Else XfmrVA = 250
                    If frmMain.ThisUnit.Cabinet = "Series100C" Then XfmrVA = 750 Else XfmrVA = 250
                Case Is = "Blank"

                Case Else
                    RqdVA = 2000
                    XfmrVA = 2000
                    dummy = MsgBox("Unit type undefined in 'BiPolar:Update Performance'" & vbCrLf & "Using Bogus Value.", vbOKCancel, "Fisen Unit Generator")
                    If dummy = vbCancel Then Stop
            End Select

            PrimeAmps = XfmrPrimaryAmps(PriVolts, XfmrVA)

            If PrimeAmps > 0.9999 Then
                NewRow = {True, False, "All", True, "UV LIGHT XFMR", ElecChar, "-", Format(PrimeAmps, "0.0"), False, "Math"}
                frmMain.ThisUnitElecData.ModLoad.Add(NewRow)
                frmMain.chkUseCustomMCA.Checked = True
            End If
        End If

        If optPwrConvOutlet.Checked Then
            frmMain.ThisUnitElecData.COPLoadsPresent = True
            frmMain.ThisUnitElecData.COPLoad.Add("Ultraviolet Lights," & Format(RqdVA, "0.0"))
        End If

        lDesignNote = "Missing UV Tube Selection for Design.  Please update."
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"

            Case Is = "Series10"
                lDesignNote = "UV Light Tubes - 2 33 inch Ultravation UV Matrix EZ-Series"
            Case Is = "Series12"

            Case Is = "Series20"

            Case Is = "Series40"
                 'Depricated *Probably not going to be used*
            Case Is = "Series100"

            Case Is = "Premier"

            Case Is = "Choice"

            Case Is = "Select"

            Case Is = "SeriesLX"

            Case Is = "Series20ODSplit"

            Case Is = "Series20IDSplit"

            Case Is = "Series40ODSplit"

            Case Is = "YCUL"

            Case Is = "YLUA"

            Case Is = "DOAS"

            Case Is = "SeriesL"

            Case Is = "Blank"

            Case Else

        End Select
        txtDesignNotesHard.Text = txtDesignNotesHard.Text & lDesignNote & vbCrLf

    End Sub
    Private Sub WriteHistory()
        'Created as V2 on 10 Jun 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim PowerSource, ControlStyle, InstallLocation As String

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
        If optCtrlWithComps.Checked Then ControlStyle = "With Compressors"
        If optCtrlWithSupplyFan.Checked Then ControlStyle = "With Supply Fan"
        If optCtrlCustom.Checked Then ControlStyle = "Custom Controls"

        InstallLocation = "N/A"
        If optInstUSEvap.Checked Then InstallLocation = "Pre Evap"
        If optInstDSEvap.Checked Then InstallLocation = "Post Evap"
        If chkInstHGRHCoil.Checked Then InstallLocation = InstallLocation & "-Post HGRH"

        MySQL = "Select * FROM tblHistoryUVLights WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryUVLights SET PowerSource='" & PowerSource & "', ControlStyle='" & ControlStyle & "', " & "InstallLocation='" & InstallLocation & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryUVLights (JobName,UnitID,Version,ModelNumber,PowerSource,ControlStyle,InstallLocation) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & PowerSource & "','" & ControlStyle & "','" & InstallLocation & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub frmUVLights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Case Is = "SeriesLX"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
        End Select

        ModuleCodeList.Add("420000")
        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True

        txtDesignNotesHard.Text = "***BiPolar Notes and Comments***" & vbCrLf

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
                End Select
            End If
        End If
    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/UVLights")

        TempVal = xNodeRoot.SelectSingleNode("PowerSource").InnerText
        If TempVal = "Convenience Outlet" Then optPwrConvOutlet.Checked = True
        If TempVal = "Dedicated Circuit" Then optPwrDedicated.Checked = True
        If TempVal = "Unit Powered" Then optPwrUnitPower.Checked = True

    End Sub
    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '420%'"
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

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "UVLights"
        frmHistoryReport.cmbModCode.Text = "UVLights"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)
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
        TabControl1.SelectTab("tpgNotesPage")

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneNotes_Click(sender As Object, e As EventArgs) Handles btnDoneNotes.Click
        If txtDesignNotesSoft.Text = "" Then txtDesignNotesSoft.Text = "No user entered design notes."
        btnOK.Enabled = True
        btnDoneNotes.Enabled = False
    End Sub
End Class