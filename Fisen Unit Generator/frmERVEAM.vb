Public Class frmERVEAM
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList
    Private pResearchMode As Boolean

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

    Private Sub frmERVEAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

        cmbDWStyle.Text = "Unselected"

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
            Case Is = "SeriesLX"
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

        'If it’s a DPP project then turn on DPP controls for handling during update performance.
        'n/a remains usable to permit n/a for dedicated supply.
        If frmMain.ThisUnitElecData.DPPPresent Then grpDPPCkt.Visible = True

        'Final Preparations
        ModuleCodeList.Add("E90000")
        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        'Loading the Digital Conditions will vary with every mod.

        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True

    End Sub

    Private Sub LoadDigConditions()
        'nothing here just yet.
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("ERV-EAM") 'Mod Code goes here!
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

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()

    End Sub
    Private Sub UpdatePerformance()
        'There is no performance to update for this modification yet
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim cabinetmass, fanmass, motormass, dampermass As Integer
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("ERV-EAM")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("ERV Economizer Assist Module")

        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Series10"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Series20"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Series40"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Series100"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Premier"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Choice"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Is = "Select"
                cabinetmass = 0
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 0
                motormass = 0
                dampermass = 0
            Case Else
                cabinetmass = 2500
                If optDoubleWall.Checked Then cabinetmass = cabinetmass + 0
                fanmass = 2500
                motormass = 2500
                dampermass = 2499
        End Select

        tempWeight = Str(cabinetmass + fanmass + motormass + dampermass)
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.AirflowTest = True
    End Sub

    Private Sub UpdateCodeList()
        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("E90000")

        'Handle major style division.  Only one type right now.
        ModuleCodeList.Add("E90100")

        'Handle the ship withs and supports.
        ModuleCodeList.Add("E90121")
        ModuleCodeList.Add("E90122")
        ModuleCodeList.Add("E90123")

        'Handle Cabinet Construction
        If optSingleWall.Checked Then
            ModuleCodeList.Add("E90111")
        Else
            ModuleCodeList.Add("E90110")
            Select Case cmbDWStyle.Text
                Case Is = "Galvanized"
                    ModuleCodeList.Add("E90112")
                Case Is = "Stainless Steel"
                    ModuleCodeList.Add("E90113")
            End Select
        End If

        'handle painting options
        ModuleCodeList.Add("E90130")
        If optPainted.Checked Then
            ModuleCodeList.Add("E90131")
        Else
            ModuleCodeList.Add("E90132")
        End If

        'Handle electrical options
        ModuleCodeList.Add("E90140")
        If chkRTUPowered.Checked Then
            ModuleCodeList.Add("E90141")
        Else
            ModuleCodeList.Add("E90142")
        End If

        If chkLocalDisconect.Checked Then
            ModuleCodeList.Add("E90143")
        Else
            ModuleCodeList.Add("E90144")
        End If

        'handle mechanical options
        ModuleCodeList.Add("E90150")

        If optFanAxial.Checked Then ModuleCodeList.Add("E9015M")

        ModuleCodeList.Add("E90151")
        If optEconAirIsoOpenClose.Checked Then ModuleCodeList.Add("E90152")
        If optEconAirIsoModulating.Checked Then ModuleCodeList.Add("E90153")
        If optEconAirIsoBarometric.Checked Then ModuleCodeList.Add("E90154")

        ModuleCodeList.Add("E90156")
        If optEconReliefAirIsoOpenClose.Checked Then ModuleCodeList.Add("E90157")
        If optEconReliefAirIsoModulating.Checked Then ModuleCodeList.Add("E90158")
        If optEconReliefAirIsoBarometric.Checked Then ModuleCodeList.Add("E90159")

        ModuleCodeList.Add("E9015B")
        If optERVIsoOpenClose.Checked Then ModuleCodeList.Add("E9015C")
        If optERVIsoModulating.Checked Then ModuleCodeList.Add("E9015D")
        If optERVIsoBarometric.Checked Then ModuleCodeList.Add("E9015E")

        ModuleCodeList.Add("E90160")
        If optReliefFanCtrlTrack.Checked Then ModuleCodeList.Add("E90161")



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

        If chk65kASCCRBase.Checked Then ModuleCodeList.Add("E90F6A")

    End Sub
    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim ERVModelNum As String

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

        ERVModelNum = "TEST"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblHistoryERVEAM WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryERVEAM SET ERVModelNumber='" & ERVModelNum & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryERVEAM (JobName,UnitID,Version,ModelNumber,ERVModelNumber) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & ERVModelNum & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult

        'validate all options are correctly selected before proceeding
        If cmbDWStyle.Text = "Unselected" Then
            dummy = MsgBox("You must select a double wall material before proceeding.")
            Exit Sub
        End If


        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False

    End Sub

    Private Sub optDoubleWall_CheckedChanged(sender As Object, e As EventArgs) Handles optDoubleWall.CheckedChanged
        If optDoubleWall.Checked Then
            cmbDWStyle.Enabled = True
            cmbDWStyle.Text = "Unselected"
        Else
            cmbDWStyle.Enabled = False
            cmbDWStyle.Text = "n/a"
        End If
    End Sub

End Class