Public Class frmCstmRef
    Private pCancelled As Boolean
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
    Private Sub frmCstmRef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

        Call PopulateAuxPanelList()

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True
        ModuleCodeList.Add("970000")

        Call LoadPermittedRefMods()

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optSE.Checked = True
            Case Is = "Series10"
                optSE.Checked = True
            Case Is = "Series12"
                optSE.Checked = True
            Case Is = "Series20"
                optSE.Checked = True
            Case Is = "Series40"
                'Depricated *Probably not going to be used*
                optSE.Checked = True
            Case Is = "Series100"
                optIPU.Checked = True
            Case Is = "Premier"
                optASE.Checked = True
            Case Is = "Choice"
                optSE.Checked = True
            Case Is = "Select"
                optSE.Checked = True
            Case Is = "YVAA"
                optIPU.Checked = True
            Case Is = "YLAA"
                optIPU.Checked = True
            Case Is = "YCAL"
                optIPU.Checked = True
            Case Else

        End Select
    End Sub
    Private Sub LoadPermittedRefMods()
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

        MySQL = "SELECT * FROM tblCstmRef WHERE " & frmMain.ThisUnit.Family & "OK=TRUE ORDER BY CstmFIOP"
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
        Dim Reccount As Integer

        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        MySQL2 = "SELECT COUNT(*) as RowCount FROM tblCstmRef INNER JOIN tblCstmTagALong ON tblCstmRef.CstmCode = tblCstmTagALong.CstmCode WHERE (((tblCstmRef.CstmFIOP)='" & loccode & "'))"

        rs2.Open(MySQL2, con2)
        Reccount = rs2.Fields("RowCount").Value
        rs2.Close()

        If Reccount > 0 Then
            MySQL2 = "SELECT tblCstmRef.CstmCode as CstmCode, tblCstmRef.CstmFIOP as CstmFIOP, tblCstmTagALong.TagALongData as TagALongID, tblCstmTagALong.DataComment as TagAlongName FROM tblCstmRef INNER JOIN tblCstmTagALong ON tblCstmRef.CstmCode = tblCstmTagALong.CstmCode WHERE (((tblCstmRef.CstmFIOP)='" & loccode & "'))"

            rs2.Open(MySQL2, con2)
            lstTagAlongs.Items.Clear()
            lblCurrentCode.Text = rs2.Fields("CstmCode").Value

            Do While Not (rs2.EOF)

                lstTagAlongs.Items.Add(rs2.Fields("TagAlongID").Value & "-" & rs2.Fields("TagAlongName").Value)
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '970%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '970%'"
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

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i As Integer
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim tempWeight As String

        tempWeight = -9999.0
        ModuleCodeList.Clear()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1

            MySQL = "SELECT * FROM tblCstmRef WHERE CstmFIOP='" & lstItemsInDB.SelectedItems.Item(i) & "'"
            rs.Open(MySQL, con)

            rs.MoveFirst()
            Do While Not (rs.EOF)
                'Call UpdatePerformance()

                'Handle the mass
                frmMain.ThisUnitPhysicalData.ModLoadMod.Add("CstmRef")
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
                Call UpdateJCIRequiredItems(rs.Fields("CstmCode").Value)
                rs.MoveNext()
            Loop
            rs.Close()

        Next i
        con.Close()
        rs = Nothing
        con = Nothing

        'Add Auxillary Panel if selected
        Call AuxPanelCodeInsert() 'v1.0

        If chkWriteHistory.Checked = True Then Call WriteHistory()

        'handle base SCCR Unit Code
        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("970F6A")
        End If

        If chk30kASCCRBase.Checked Then
            ModuleCodeList.Add("970F6B")
        End If

        Call PerformDesignCautionScan(False)
        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCstmRefCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

        Me.Hide()
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

        MySQL2 = "SELECT COUNT(*) as RowCount FROM tblCstmJCIRequired WHERE CstmFIOPID='" & loccode & "'"
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
        frmMain.dgvElecLoads.Rows.Add(newrow)

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

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "CstmRef"
        frmHistoryReport.Show()
    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
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

    Private Sub WriteHistory()
        'Updated to Version 2.0 29 Apr 2020

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
            MySQL = "Select * FROM tblCstmRef WHERE (CstmFIOP='" & lstItemsInDB.SelectedItems(i).ToString & "')"
            rs.Open(MySQL, con)
            pSelectedCodes.Add(rs.Fields("CstmCode").Value)
            rs.Close()
        Next i


        For i = 1 To lstItemsInDB.SelectedItems.Count

            CstmDesc = lstItemsInDB.SelectedItems(i - 1).ToString
            CstmCode = pSelectedCodes.Item(i - 1)

            MySQL = "Select * FROM tblHistoryCstmRef WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "') AND (CustomCode='" & CstmCode & "')"
            rs.Open(MySQL, con)

            If Not (rs.EOF And rs.BOF) Then
                'Update SQL
                ExistingRecordID = rs.Fields(0).Value
                MySQL = "UPDATE tblHistoryCstmRef SET Controller='" & Controller & "', CustomCode='" & CstmCode & "', " & "CustomDescription='" & CstmDesc & "' WHERE ID=" & ExistingRecordID
                con.Execute(MySQL)
            Else
                'Insert SQL
                MySQL = "INSERT INTO tblHistoryCstmRef (JobName,UnitID,Version,ModelNumber,CustomCode,CustomDescription,Controller) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & CstmCode & "','" & CstmDesc & "','" & Controller & "')"
                con.Execute(MySQL)
            End If
            rs.Close()

        Next i

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
End Class