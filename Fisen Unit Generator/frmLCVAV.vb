﻿Imports System.Xml

Public Class frmLCVAV
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
        frmMain.ThisUnitMods.Add("LCVAV") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()

        'Call UpdateBaseUnitRequiredItems()
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
    Private Sub UpdatePerformance()
        'There is no performance to update for this modification
    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("315000")
        If chkECMotorStaging.Checked Then
            ModuleCodeList.Add("315310") 'EC Motor Staging
        End If
        If optSEVAV.Checked Then
            ModuleCodeList.Add("315100") 'SE Controller LCVAV
            ModuleCodeList.Add("315105") 'Utilize Existing SE Controller
            If chkIntellispeed.Checked = True Then
                ModuleCodeList.Add("315130")
            Else
                ModuleCodeList.Add("315110") 'Supply Air Temperature Controls by SE Controller 
                ModuleCodeList.Add("315115") 'MWU/DWU Controls by SE Controller
                ModuleCodeList.Add("315120") 'Duct Static Pressure Controls by SE Controller
                ModuleCodeList.Add("315121") 'Fisen Provided and Installed Duct Static Pressure Sensor
            End If
            If chkUnitisHeatPump.Checked Then ModuleCodeList.Add("315122") 'High Speed Fan in Heat Relay
            If chkHSFaninRH.Checked Then ModuleCodeList.Add("315123") 'High Speed Fan in Reheat Mode

        Else
            ModuleCodeList.Add("315200") 'Fisen Controller LCVAV

            If chkFisenSATCtrl.Checked Then
                ModuleCodeList.Add("315210")
            End If
            If chkFisenDSPCtrl.Checked Then
                ModuleCodeList.Add("315220")
                ModuleCodeList.Add("315221")
            End If
            If chkFisenMWUCtrl.Checked Then
                ModuleCodeList.Add("315215")
            End If
            frmMain.ThisUnit.CommNodes = "2"
        End If

        If (optSEVAV.Checked And chkUpgradeSEBoard.Checked) Then
            frmMain.ThisUnitGenCodes.Add("960009") 'Add the board with VAV terminals.
        End If

        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnit.GenCodesPresent = False Then frmMain.ThisUnitGenCodes.Add("960000")
            frmMain.ThisUnit.GenCodesPresent = True
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
            ModuleCodeList.Add("315F6A")
        End If

    End Sub

    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub

    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("LCVAV")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Light Commercial VAV Conversion")

        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "12"
            Case Is = "Series10"
                tempWeight = "12"
            Case Is = "Series20"
                tempWeight = "13"
            Case Is = "Series40"
                tempWeight = "14"
            Case Is = "Series100"
                tempWeight = "65"
            Case Is = "Premier"
                tempWeight = "65"
            Case Is = "Choice"
                tempWeight = "13"
            Case Is = "Select"
                tempWeight = "18"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        If optDrivebyFisen.Checked Then
            If ((InTheQueue("Fan VFD") = False) And (AlreadyDone("FanVFD") = False)) Then
                frmMain.lstSelectedMods.Items.Add("Fan VFD")
            End If
        End If
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub optFisenVAV_CheckedChanged(sender As Object, e As EventArgs)
        If optFisenVAV.Checked = True Then
            chkFisenDSPCtrl.Enabled = True
            chkFisenMWUCtrl.Enabled = True
            chkFisenSATCtrl.Enabled = True
        Else
            chkFisenDSPCtrl.Enabled = False
            chkFisenMWUCtrl.Enabled = False
            chkFisenSATCtrl.Enabled = False
            chkFisenDSPCtrl.Checked = False
            chkFisenMWUCtrl.Checked = False
            chkFisenSATCtrl.Checked = False
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub frmLCVAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If frmMain.ThisUnitSFanPerf.VFDPresent Then
            optDrivebyJCI.Checked = True
        End If

        If InStr(frmMain.ThisUnit.ModelNumber, "ZR") > 0 Then
            chkHSFaninRH.Checked = True
        End If

        ModuleCodeList.Add("315000")
        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True

    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/LCVAV")

        TempVal = xNodeRoot.SelectSingleNode("UpgradeSE").InnerText
        If TempVal = "True" Then chkUpgradeSEBoard.Checked = True Else chkUpgradeSEBoard.Checked = False

        TempVal = xNodeRoot.SelectSingleNode("VFDSource").InnerText
        If TempVal = "JCI Provided" Then optDrivebyJCI.Checked = True
        If TempVal = "Fisen Provided" Then optDrivebyFisen.Checked = True
        If TempVal = "Field Provided" Then optDrivebyField.Checked = True
        If TempVal = "JCI EC Motor" Then optJCIECMotor.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("VAVStyle").InnerText
        If TempVal = "Use SE Board" Then optSEVAV.Checked = True
        If TempVal = "Use OEM Board" Then optFisenVAV.Checked = True

        TempVal = xNodeRoot.SelectSingleNode("ExistingMotor").InnerText
        If TempVal = "Not a Single Phase Motor" Then optNot1Phase.Checked = True
        If TempVal = "Use JCI EC Motor" Then optJustECMotor.Checked = True
        If TempVal = "R and R Fan and Motor" Then optReplaceFanAndMotor.Checked = True
    End Sub
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
    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
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

    Private Sub optJustECMotor_CheckedChanged(sender As Object, e As EventArgs) Handles optJustECMotor.CheckedChanged
        If optJustECMotor.Checked Then
            chkECMotorStaging.Checked = True
            chkECMotorStaging.Enabled = False
        End If
    End Sub
    Private Sub PresentDesignCautions()
        Dim LocalFamily As String

        LocalFamily = frmMain.ThisUnit.Family

        Select Case LocalFamily
            Case Is = "Series5"

        End Select
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs)
        Call PerformDesignCautionScan(True)

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '315%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '315%'"
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

    Private Sub optDrivebyFisen_CheckedChanged(sender As Object, e As EventArgs) Handles optDrivebyFisen.CheckedChanged
        If optDrivebyFisen.Checked Then
            chkUpgradeSEBoard.Checked = True
        End If
    End Sub

    Private Sub optDrivebyField_CheckedChanged(sender As Object, e As EventArgs) Handles optDrivebyField.CheckedChanged
        If optDrivebyField.Checked Then
            chkUpgradeSEBoard.Checked = True
        End If
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "LCVAV"
        frmHistoryReport.cmbModCode.Text = "LCVAV"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdDesignCautions_Click_1(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click

    End Sub

    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim ConvStyle, DSPC, SATCool, MWU, HSFanRH, HeatPump, ECMStaged, UpgradeBoard As String

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

        If optSEVAV.Checked Then
            ConvStyle = "Existing SE"
            DSPC = "n/a"
            SATCool = "n/a"
            MWU = "n/a"
        Else
            ConvStyle = "By Fisen"
            If chkFisenDSPCtrl.Checked Then DSPC = "Yes" Else DSPC = "No"
            If chkFisenSATCtrl.Checked Then SATCool = "Yes" Else SATCool = "No"
            If chkFisenMWUCtrl.Checked Then SATCool = "Yes" Else SATCool = "No"
        End If

        If chkHSFaninRH.Checked Then HSFanRH = "Yes" Else HSFanRH = "No"
        If chkUnitisHeatPump.Checked Then HeatPump = "Yes" Else HeatPump = "No"
        If chkECMotorStaging.Checked Then ECMStaged = "Yes" Else ECMStaged = "No"
        If chkUpgradeSEBoard.Checked Then UpgradeBoard = "Yes" Else UpgradeBoard = "No"

        MySQL = "Select * FROM tblHistoryLCVAV WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryLCVAV SET Style='" & ConvStyle & "', DSPC='" & DSPC & "', " & "SATCooling='" & SATCool & "', MWU='" & MWU & "', HSFanReheat='" & HSFanRH & "', HeatPump='" & HeatPump & "', ECMStaged='" & ECMStaged & "', UpgradeBoard='" & UpgradeBoard & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryLCVAV (JobName,UnitID,Version,ModelNumber,Style,DSPC,SATCooling,MWU,HSFanReheat,HeatPump,ECMStaged,UpgradeBoard) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & ConvStyle & "','" & DSPC & "','" & SATCool & "','" & MWU & "','" & HSFanRH & "','" & HeatPump & "','" & ECMStaged & "','" & UpgradeBoard & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

End Class