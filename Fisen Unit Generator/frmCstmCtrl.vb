﻿Imports System.ComponentModel
Imports System.Xml
Public Class frmCstmCtrl
    Private pCancelled As Boolean
    Private pResearchMode As Boolean
    Private pModsSelected As Integer()
    Private pTagALongsSelected As New ArrayList
    Private pTagALongParent As New ArrayList
    Private pSelectedCodes As New ArrayList
    Private ModuleCodeList As New ArrayList


    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property ResearchMode As Boolean
        Get
            Return pResearchMode
        End Get
        Set(value As Boolean)
            pResearchMode = value
        End Set
    End Property
    Private Sub SetupResearchMode()
        Me.Text = Me.Text & " ***Research Mode***"
        btnOK.Text = "Research Mode"
        chkWriteHistory.Checked = False
        chkWriteHistory.Enabled = False
    End Sub

    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dummy As MsgBoxResult

        pCancelled = False

        If pResearchMode Then Call SetupResearchMode()

        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True
        ModuleCodeList.Add("980000")

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

        Call LoadPermittedCtrlMods()

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If

        Call PopulateAuxPanelList() 'V1.4
        optUseAux.Checked = frmMain.HasAuxillaryPanel

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series10"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series12"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series20"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series40"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series100"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Premier"
                optASE.Checked = True
                optSE.Enabled = False
                optIPU.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Choice"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Select"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "SeriesLX"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "DOAS"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "YVAA"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YLAA"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YCAL"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YCIV"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YCAV"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "XTI"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "XTO"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "YorkCustom"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "Series20IDSplit"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "DS"
                optOtherControl.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optSE.Enabled = False
            Case Is = "SeriesL"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series20ODSplit"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Series40ODSplit"
                optSE.Checked = True
                optIPU.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YCUL"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "YLUA"
                optIPU.Checked = True
                optSE.Enabled = False
                optASE.Enabled = False
                optOtherControl.Enabled = False
            Case Is = "Blank"
                optOtherControl.Checked = True
            Case Else
                dummy = MsgBox("FUG encountered an unknown Family in CstmCtrl Module", vbOKOnly, "Fisen Unit Generator")
                Call WriteToEventLog("CstmCtrl", "Unknown Family passed to module.", "Arby's", Str(dummy))
        End Select


        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()

        cmdAddNewCode.Visible = SuperUser()

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False
        chkWriteHistory.Visible = SuperUser() Or frmMain.chkDebug.Checked

    End Sub



    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String
        Dim i As Integer
        Dim KidCount As Integer
        Dim idx As Integer

        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/CstmCtrl")

        KidCount = xNodeRoot.ChildNodes.Count
        For i = 0 To KidCount - 1
            xNodeRoot = xDoc.SelectSingleNode("//ModFile/Modifications/CstmCtrl").ChildNodes(i)
            TempVal = xNodeRoot.InnerText
            idx = lstItemsInDB.FindStringExact(TempVal)
            lstItemsInDB.SetSelected(idx, True)
        Next




    End Sub

    Private Sub LoadPermittedCtrlMods()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstItemsInDB.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCstmCtrl WHERE " & frmMain.ThisUnit.Family & "OK=TRUE ORDER BY CstmFIOP"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstItemsInDB.Items.Add(rs.Fields("CstmFIOP").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnDoneSelection_Click(sender As Object, e As EventArgs) Handles btnDoneSelection.Click

        lblCount.Text = Str(lstItemsInDB.SelectedItems.Count - 1)
        lblCurrentCstmMod.Text = lstItemsInDB.SelectedItems.Item(Val(lblCount.Text))
        Call TagALongPopulate(lblCurrentCstmMod.Text)
        TabControl1.SelectTab("tpgConditions")
    End Sub
    Private Sub TagALongPopulate(loccode As String)
        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        Dim opcode As String

        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }


        MySQL2 = "SELECT * FROM tblCstmCtrl WHERE CstmFIOP='" & loccode & "'"
        rs2.Open(MySQL2, con2)
        opcode = rs2.Fields("CstmCode").Value.ToString
        rs2.Close()

        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE CstmCode='" & opcode & "'"
        rs2.Open(MySQL2, con2)
        If Not (rs2.BOF And rs2.EOF) Then

            lstTagAlongs.Items.Clear()
            lblCurrentCode.Text = rs2.Fields("CstmCode").Value

            Do While Not (rs2.EOF)

                lstTagAlongs.Items.Add(rs2.Fields("TagALongData").Value & "-" & rs2.Fields("DataComment").Value)
                rs2.MoveNext()
            Loop
            rs2.Close()
        End If


        con2.Close()
        rs2 = Nothing
        con2 = Nothing
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '980%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '980%'"
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

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim i As Integer
        Dim temp As String

        If ((lstTagAlongs.SelectedItems.Count > 0) And (lblCount.Text <> 0)) Then
            For i = 0 To lstTagAlongs.SelectedItems.Count - 1
                temp = Mid(lstTagAlongs.SelectedItems.Item(i), 1, 6)
                pTagALongsSelected.Add(temp)
                pTagALongParent.Add(lblCurrentCode.Text)
            Next
        End If

        If lblCount.Text <> 0 Then
            lblCount.Text = Val(lblCount.Text - 1)
            lblCurrentCstmMod.Text = lstItemsInDB.SelectedItems.Item(Val(lblCount.Text))
            Call TagALongPopulate(lblCurrentCstmMod.Text)
        Else
            If lstTagAlongs.SelectedItems.Count > 0 Then
                For i = 0 To lstTagAlongs.SelectedItems.Count - 1
                    pTagALongsSelected.Add(Mid(lstTagAlongs.SelectedItems.Item(i), 1, 6))
                    pTagALongParent.Add(lblCurrentCode.Text)
                Next
            End If
            TabControl1.SelectTab("tpgOptions")
        End If

    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click

        If Not (ResearchMode) Then btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i As Integer
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim tempWeight As String

        tempWeight = -9999.0

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        ModuleCodeList.Clear()
        ModuleCodeList.Add("980000")
        For i = 0 To lstItemsInDB.SelectedItems.Count - 1

            MySQL = "SELECT * FROM tblCstmCtrl WHERE CstmFIOP='" & lstItemsInDB.SelectedItems.Item(i) & "'"
            rs.Open(MySQL, con)

            rs.MoveFirst()
            Do While Not (rs.EOF)
                'Call UpdatePerformance()

                'Handle the mass
                frmMain.ThisUnitPhysicalData.ModLoadMod.Add("CstmCtrl")
                frmMain.ThisUnitPhysicalData.ModLoadItem.Add(rs.Fields("CstmFIOP").Value)
                frmMain.ThisUnitPhysicalData.ModLoadMass.Add(rs.Fields("CstmWeight").Value)

                'Handle the warranty
                If rs.Fields("TestAF").Value = True Then frmMain.ThisUnitWarrTest.AirflowTest = True
                If rs.Fields("TestCoil").Value = True Then frmMain.ThisUnitWarrTest.CoilTest = True
                If rs.Fields("TestCtrl").Value = True Then frmMain.ThisUnitWarrTest.CtrlTest = True
                If rs.Fields("TestMotor").Value = True Then frmMain.ThisUnitWarrTest.MotorTest = True
                If rs.Fields("TestEHeat").Value = True Then frmMain.ThisUnitWarrTest.EHeatTest = True
                If rs.Fields("TestGHeat").Value = True Then frmMain.ThisUnitWarrTest.GHeatTest = True
                If rs.Fields("TestGTrain").Value = True Then frmMain.ThisUnitWarrTest.GasTrainTest = True
                If rs.Fields("TestHydro").Value = True Then frmMain.ThisUnitWarrTest.HydroPress = True
                If rs.Fields("TestRef").Value = True Then frmMain.ThisUnitWarrTest.RefTest = True
                If rs.Fields("TestRefInst").Value = True Then frmMain.ThisUnitWarrTest.RefInsp = True

                Call UpdateCodeList(rs.Fields("CstmCode").Value)
                If rs.Fields("MCAChange").Value = True Then
                    Call CustomMCARequired(rs.Fields("LoadName").Value, rs.Fields("LoadHP").Value, rs.Fields("LoadValue").Value)
                End If

                Call UpdateJCIRequiredItems(rs.Fields("CstmCode").Value.ToString)
                Call UpdateBaseUnitDrawingTags(rs.Fields("BIUnitDrawings").Value.ToString)
                Call UpdateReferDrawingTags(rs.Fields("BIReferDrawings").Value.ToString)
                Call UpdateAirflowDrawingTags(rs.Fields("BIAirflowDrawings").Value.ToString)
                Call UpdateHydroDrawingTags(rs.Fields("BIHydroDrawings").Value.ToString)
                Call AddFieldInstalledItems(rs.Fields("CstmCode").Value.ToString)
                rs.MoveNext()
            Loop
            rs.Close()

        Next i
        con.Close()
        rs = Nothing
        con = Nothing

        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert() 'v1.3


        If chkWriteHistory.Checked = True Then Call WriteHistory()

        'handle base SCCR Unit Code
        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("980F6A")
        End If

        If chk30kASCCRBase.Checked Then
            ModuleCodeList.Add("970F6B")
        End If

        Call PerformDesignCautionScan(False)
        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCstmCtrlCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

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

        Me.Hide()
    End Sub
    Private Sub WriteHistory()
        'Updated to Version 2.0 29 Apr 2020
        'Update table name in 4 locations

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim CstmCode, CstmDesc, Controller As String

        Dim i As Integer

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
            .CursorType = ADODB.CursorTypeEnum.adOpenStatic
        }

        Controller = "Unselected"
        If optSE.Checked Then Controller = "SE"
        If optIPU.Checked Then Controller = "IPU"
        If optASE.Checked Then Controller = "ASE"

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1
            MySQL = "Select * FROM tblCstmCtrl WHERE (CstmFIOP='" & lstItemsInDB.SelectedItems(i).ToString & "')"
            rs.Open(MySQL, con)
            pSelectedCodes.Add(rs.Fields("CstmCode").Value)
            rs.Close()
        Next i


        For i = 1 To lstItemsInDB.SelectedItems.Count

            CstmDesc = lstItemsInDB.SelectedItems(i - 1).ToString
            CstmCode = pSelectedCodes.Item(i - 1)

            MySQL = "Select * FROM tblHistoryCstmCtrl WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "') AND (CustomCode='" & CstmCode & "')"
            rs.Open(MySQL, con)

            If Not (rs.EOF And rs.BOF) Then
                'Update SQL
                ExistingRecordID = rs.Fields(0).Value
                MySQL = "UPDATE tblHistoryCstmCtrl SET Controller='" & Controller & "', CustomCode='" & CstmCode & "', " & "CustomDescription='" & CstmDesc & "' WHERE ID=" & ExistingRecordID
                con.Execute(MySQL)
            Else
                'Insert SQL
                MySQL = "INSERT INTO tblHistoryCstmCtrl (JobName,UnitID,Version,ModelNumber,CustomCode,CustomDescription,Controller) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & CstmCode & "','" & CstmDesc & "','" & Controller & "')"
                con.Execute(MySQL)
            End If
            rs.Close()

        Next i

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub UpdateJCIRequiredItems(loccode As String)
        Dim lcon As ADODB.Connection
        Dim lrs As ADODB.Recordset
        Dim ldbProvider As String
        Dim MySQL2 As String
        Dim reccount As Integer

        lcon = New ADODB.Connection
        ldbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        lcon.ConnectionString = ldbProvider
        lcon.Open()
        lrs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        MySQL2 = "Select COUNT(*) As RowCount FROM tblCstmJCIRequired WHERE CstmFIOPID='" & loccode & "'"
        lrs.Open(MySQL2, lcon)
        reccount = lrs.Fields("RowCount").Value
        lrs.Close()
        If reccount > 0 Then
            MySQL2 = "SELECT * FROM tblCstmJCIRequired WHERE CstmFIOPID='" & loccode & "'"
            lrs.Open(MySQL2, lcon)
            'If lrs.RecordCount > 0 Then
            lrs.MoveFirst()
            Do While Not (lrs.EOF)
                frmMain.lstRequiredFactoryItems.Items.Add(lrs.Fields("JCIRequiredItem").Value)
                lrs.MoveNext()
            Loop
            'End If

            lcon.Close()
        End If
        lrs = Nothing
        lcon = Nothing
    End Sub
    Private Sub CustomMCARequired(LoadName As String, LoadHP As String, LoadValue As String)
        Dim elecchar As String
        Dim newrow As String()

        If frmMain.UseCustomMCA = False Then
            frmMain.UseCustomMCA = True
            Call frmMain.PreLoadElec()
        End If
        elecchar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
        newrow = {True, False, "All", True, LoadName, elecchar, LoadHP, LoadValue, False}

        frmMain.ThisUnitElecData.ModLoad.Add(newrow)
        frmMain.chkUseCustomMCA.Checked = True
        Call frmMain.CalculateCustomMCA()


    End Sub
    Private Sub AddFieldInstalledItems(locCode As String)

        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='FieldInstalled')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            frmMain.ThisUnitFieldInst.Add(rs2.Fields("TagALongData").Value)
            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub AddJCIREquiredMods(locCode As String)

        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='JCIRqd')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            frmMain.lstRequiredFactoryItems.Items.Add(rs2.Fields("TagALongData").Value)

            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub AddTagALongCodes(locCode As String)
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Is this used?")
        Stop

        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='FIOP')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            UpdateCodeList(rs2.Fields("TagALongData").Value)
            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing

    End Sub
    Private Sub UpdateCodeList(locCode As String)
        Dim i As Integer

        ModuleCodeList.Add(locCode)
        For i = 0 To pTagALongParent.Count - 1
            If pTagALongParent.Item(i) = locCode Then
                ModuleCodeList.Add(pTagALongsSelected.Item(i))
            End If
        Next

    End Sub

    Private Sub optNoAux_CheckedChanged(sender As Object, e As EventArgs) Handles optNoAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub optUseAux_CheckedChanged(sender As Object, e As EventArgs) Handles optUseAux.CheckedChanged
        Call PopulateAuxPanelList()
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "CstmCtrl"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Enabled = False
            chkMountEquipmentTouch.Checked = False
        End If
    End Sub
    Private Sub PopulateAuxPanelList()
        'V1.4 Added support for several family types
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
                        cmbAuxPanelOpts.Text = "Select Cabinet Custom Application"
                    Case Is = "Series20ODSplit"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 20 OD Split Custom Application")
                        cmbAuxPanelOpts.Text = "Series 20 OD Split Custom Application"
                    Case Is = "Series20IDSplit"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 20 ID Split Custom Application")
                        cmbAuxPanelOpts.Text = "Series 20 ID Split Custom Application"
                    Case Is = "Series40ODSplit"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series 40 OD Split Custom Application")
                        cmbAuxPanelOpts.Text = "Series 40 OD Split Custom Application"
                    Case Is = "YCUL"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("YCUL Frame Custom Application")
                        cmbAuxPanelOpts.Text = "YCUL Frame Custom Application"
                    Case Is = "YULA"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("YULA Frame Custom Application")
                        cmbAuxPanelOpts.Text = "YULA Frame Custom Application"
                    Case Is = "DOAS"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("DOAS Frame Custom Application")
                        cmbAuxPanelOpts.Text = "DOAS Frame Custom Application"
                    Case Is = "SeriesL"
                        cmbAuxPanelOpts.Items.Clear()
                        cmbAuxPanelOpts.Items.Add("Series L Frame Custom Application")
                        cmbAuxPanelOpts.Text = "Series L Frame Custom Application"
                End Select
            End If
        End If
    End Sub
    Private Sub AuxPanelCodeInsert() 'Called from near the end of UpdateCode()
        'V1.3  - Added several more family options and codes.
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
                Case Is = "Series 20 OD Split Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960029")
                Case Is = "Series 20 ID Split Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960030")
                Case Is = "Series 40 OD Split Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960031")
                Case Is = "YCUL Frame Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960032")
                Case Is = "YULA Frame Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960033")
                Case Is = "DOAS Frame Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960034")
                Case Is = "Series L Frame Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960035")
            End Select
        End If
    End Sub
    Private Sub UpdateBaseUnitDrawingTags(lUnitDrawingTag As String)

        frmMain.txtUnitSuggestedTags.Text = frmMain.txtUnitSuggestedTags.Text & lUnitDrawingTag
    End Sub

    Private Sub UpdateAirflowDrawingTags(lAirflowDrawingTag As String)

        frmMain.txtAirflowSuggestedTags.Text = frmMain.txtAirflowSuggestedTags.Text & lAirflowDrawingTag
    End Sub

    Private Sub UpdateReferDrawingTags(lUnitReferTag As String)

        frmMain.txtReferSuggestedTags.Text = frmMain.txtReferSuggestedTags.Text & lUnitReferTag
    End Sub

    Private Sub UpdateHydroDrawingTags(lHydroDrawingTag As String)

        frmMain.txtHydroSuggestedTags.Text = frmMain.txtHydroSuggestedTags.Text & lHydroDrawingTag
    End Sub

    Private Sub cmdScience_Click(sender As Object, e As EventArgs) Handles cmdScience.Click
        Dim dummy As MsgBoxResult
        dummy = MsgBox("Science! for the Custom Control Module is not yet implemented.")
        WriteToEventLog("CstmCtrl", "Science! for the Custom Control Module is not yet implemented.", "Development", Str(dummy))
    End Sub

    Private Sub cmdFIOPPreview_Click(sender As Object, e As EventArgs) Handles cmdFIOPPreview.Click
        Call FIOPPreview()
    End Sub
    Private Sub FIOPPreview()
        'version 1.0 Special for CstmNNNN
        'Modify: Code XXX in SQL declaration below AND THE TEMPMODLIST variable.

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer
        Dim TempModList As New ArrayList

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

        'Update next line
        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE FIOpCode Like '980%'"
        rs.Open(MySQL, con)

        'Update next line
        TempModList.Add("980000")

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1
            rs.MoveFirst()
            rs.Find("Description='" & lstItemsInDB.SelectedItems(i) & "'")
            TempModList.Add(rs.Fields("FIOpCode").Value)
            For j = 0 To pTagALongParent.Count - 1
                If pTagALongParent.Item(j) = rs.Fields("FIopCode").Value Then
                    TempModList.Add(pTagALongsSelected.Item(j))
                End If
            Next
        Next

        For i = 0 To TempModList.Count - 1
            rs.MoveFirst()
            rs.Find("FIOpCode='" & TempModList(i) & "'")
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