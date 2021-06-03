Imports System.Reflection
Imports System.Xml
Imports Microsoft.Office.Interop.Excel

Public Class frmBiPolar
    Private pCancelled As Boolean
    Private pCount1002 As Integer
    Private pCount508 As Integer
    Private ModuleCodeList As New ArrayList

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pCancelled = False
        pCount1002 = 0
        pCount508 = 0

    End Sub

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
        frmMain.DesignNotes = frmMain.DesignNotes & txtDesignNotesHard.Text & vbCrLf & vbCrLf & txtDesignNotesSoft.Text

        Me.Hide()
    End Sub

    Private Sub UpdateCodeList(Preview As Boolean)
        Dim errmsg As String
        Dim dummy As MsgBoxResult
        Dim snippet As String

        If Not (Preview) Then frmMain.ThisUnitMods.Add("BiPolar") 'Mod Code goes here!
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
                        ModuleCodeList.Add("430Z0C")
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
            If Not (chkShareXfmr.Checked) Then
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
                        ModuleCodeList.Add("430X03")
                    Case Is = "Select"
                        ModuleCodeList.Add("430X01")
                    Case Else
                        errmsg = "Error assigning Transformer Size in Bipolar:UpdateCodeList." & vbCrLf & optPwrUnitPower.Checked & " is undefined.  Continue or cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, "Fisen Unit Generator")
                        If dummy = vbCancel Then Stop
                End Select
            Else
                ModuleCodeList.Add("430105")
                If frmMain.ThisUnit.Family = "Series12" Then ModuleCodeList.Add("430X03")
                If frmMain.ThisUnit.Family = "Series20" Then ModuleCodeList.Add("430X04")
            End If
        End If
            If optPwrDedicated.Checked Then ModuleCodeList.Add("430103")

        'Handle the controls
        ModuleCodeList.Add("430200")
        If chkEMControlsOnly.Checked Then ModuleCodeList.Add("430210")
        If optCtrl247.Checked Then ModuleCodeList.Add("430201")
        If optCtrlWithSupplyFan.Checked Then ModuleCodeList.Add("430202")
        If optCtrlCustom.Checked Then
            ModuleCodeList.Add("430205")
            'Code for custom controls.
        End If

        'Handle the MnA Panel
        If Not (optNoMnA.Checked) Then
            If optRemoteMnA.Checked Then ModuleCodeList.Add("4302A1") 'Remote Mounted panel
            If optLocalMnA.Checked Then ModuleCodeList.Add("4302A2") 'Local Mounted Panel
            If optBACnetOnlyMnA.Checked Then ModuleCodeList.Add("4302A3") 'Bacnet Only No Panel
            If chkBACnetMnA.Checked Then ModuleCodeList.Add("4302A4") 'Backnet package/points are required.
        Else
            ModuleCodeList.Add("4302AZ") 'No MnA Panel
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
            Case Is = "Series12"
                tempWeight = "5"
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

    Private Function GetGeneratorDetails() As String
        Dim dummy As MsgBoxResult
        Dim errmsg As String
        Dim ldn As String
        Dim lNomTons, lAirflow As Double
        Dim lstrNomTons As String
        Dim lcabinet As String
        Dim lcount As String

        lstrNomTons = frmMain.txtNominalTons.Text
        lNomTons = Val(lstrNomTons)
        lAirflow = Val(frmMain.ThisUnitSFanPerf.Airflow)

        ldn = "Undefined Bipolar Type"
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                ldn = "Series 5 cabinets are not supported.  Program limits exceeded"
                errmsg = "Series 5 cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Series10"
                ldn = "Standard Series 10 " & S10CabinetHeightTorS() & " cabinet. - " & lstrNomTons & " Ton - 1 Matterhorn 1002 with (2) F Tubes / Order with remote intensity kit." & vbCrLf
                pCount1002 = 1
                pCount508 = 0
            Case Is = "Series12"
                ldn = "Series 12 cabinets are not supported.  Program limits exceeded"
                errmsg = "Series 12 cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Series20"
                Select Case lAirflow
                    Case 0 To 5000
                        ldn = "Standard Series 20 cabinet. - " & lstrNomTons & " Ton - 1 Matterhorn 1002 with (2) F Tubes / Order with S-Clips.  Good for up to 5,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 0
                    Case 5001 To 10000
                        ldn = "Standard Series 20 cabinet. - " & lstrNomTons & " Ton - 2 Matterhorn 1002 with (2) F Tubes / Order with S-Clips.  Good for up to 10,000 cfm" & vbCrLf
                        pCount1002 = 2
                        pCount508 = 0
                    Case 10001 To 12000
                        ldn = "Standard Series 20 cabinet. - " & lstrNomTons & " Ton - 1 508FC with (7) F Tubes  Good for up to 12000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 1
                    Case Else
                        ldn = "Series 20 cabinet with airflow over 12,000 cfm.  Program limits exceeded."
                        errmsg = "Series 20 cabinet with airflow over 12,000 cfm.  Continue or Cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                        If dummy = vbCancel Then Stop
                        If SuperUser() Then
                            errmsg = "Enter custom message for Design Notes Report"
                            ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                        End If
                        pCount1002 = 0
                        pCount508 = 0
                End Select
            Case Is = "Series40"
                'Depricated *Probably not going to be used*
                ldn = "Series 40 cabinets are not supported.  Program limits exceeded"
                errmsg = "Series 40 cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Series100"
                lcabinet = frmMain.ThisUnit.Cabinet
                Select Case lAirflow
                    Case 0 To 5000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 1 Matterhorn 1002 with (2) F Tubes / Order with S-Clips / Order with remote intensity kit.  Good for up to 5,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 0
                    Case 5001 To 10000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 2 Matterhorn 1002 with (2) F Tubes / Order with S-Clips / Order with remote intensity kit.  Good for up to 10,000 cfm" & vbCrLf
                        pCount1002 = 2
                        pCount508 = 0
                    Case 10001 To 15000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 1 508FC with (7) F Tubes / Order with remote intensity kit.  Good for up to 15,000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 1
                    Case 15001 To 20000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 1 508FC with (8) F Tubes / Order with remote intensity kits. 1 M-1002FC with (2) F Tubes/Order with Remote Intensity Kit / Order with S Clips.  Good for up to 20,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 1
                    Case 20001 To 30000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 2 508FC with (8) F Tubes / Order with remote intensity kit.  Good for up to 30,000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 2
                    Case 30001 To 45000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 3 508FC with (8) F Tubes / Order with remote intensity kit.  Good for up to 30,000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 3
                    Case 45001 To 60000
                        ldn = "Standard Series 100 " & lcabinet & " cabinet. - " & lstrNomTons & " Ton - 4 508FC with (8) F Tubes / Order with remote intensity kit.  Good for up to 30,000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 4
                    Case Else
                        ldn = "Series 100 cabinet with airflow over 60,000 cfm.  Program limits exceeded."
                        errmsg = "Series 100 cabinet with airflow over 60,000 cfm.  Continue or Cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                        If dummy = vbCancel Then Stop
                        If SuperUser() Then
                            errmsg = "Enter custom message for Design Notes Report"
                            ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                        End If
                        pCount1002 = 0
                        pCount508 = 0
                End Select
            Case Is = "Premier"
                ldn = "Premier cabinets are not supported.  Program limits exceeded"
                errmsg = "Premier cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Choice"
                Select Case lAirflow
                    Case 0 To 5000
                        ldn = "Standard Choice cabinet. - " & lstrNomTons & " Ton - 1 Matterhorn 1002 with (2) F Tubes / Order with S-Clips.  Good for up to 5,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 0
                    Case 5001 To 10000
                        ldn = "Standard Choice cabinet. - " & lstrNomTons & " Ton - 2 Matterhorn 1002 with (2) F Tubes / Order with S-Clips.  Good for up to 10,000 cfm" & vbCrLf
                        pCount1002 = 2
                        pCount508 = 0
                    Case 10001 To 15000
                        ldn = "Standard Choice cabinet. - " & lstrNomTons & " Ton - 1 508FC with (8) F Tubes  Good for up to 15000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 1
                    Case Else
                        ldn = "Choice cabinet with airflow over 15,000 cfm.  Program limits exceeded."
                        errmsg = "Choice cabinet with airflow over 15,000 cfm.  Continue or Cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                        If dummy = vbCancel Then Stop
                        If SuperUser() Then
                            errmsg = "Enter custom message for Design Notes Report"
                            ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                        End If
                        pCount1002 = 0
                        pCount508 = 0
                End Select
            Case Is = "Select"
                Select Case lAirflow
                    Case 0 To 5000
                        ldn = "Standard Select cabinet. - " & lstrNomTons & " Ton - 1 Matterhorn 1002 with (2) F Tubes / Order with S-Clips / Order with remote intensity kit.  Good for up to 5,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 0
                    Case 5001 To 10000
                        ldn = "Standard Select cabinet. - " & lstrNomTons & " Ton - 2 Matterhorn 1002 with (2) F Tubes / Order with S-Clips / Order with remote intensity kit.  Good for up to 10,000 cfm" & vbCrLf
                        pCount1002 = 2
                        pCount508 = 0
                    Case 10001 To 15000
                        ldn = "Standard Select cabinet. - " & lstrNomTons & "  Ton - 1 508FC with (7) F Tubes / Order with remote intensity kit.  Good for up to 15,000 cfm" & vbCrLf
                        pCount1002 = 0
                        pCount508 = 1
                    Case 15001 To 20000
                        ldn = "Standard Select cabinet. - " & lstrNomTons & "  Ton - 1 508FC with (8) F Tubes / Order with remote intensity kits. 1 M-1002FC with (2) F Tubes/Order with Remote Intensity Kit / Order with S Clips.  Good for up to 20,000 cfm" & vbCrLf
                        pCount1002 = 1
                        pCount508 = 1
                    Case Else
                        ldn = "Select cabinet with airflow over 20,000 cfm.  Program limits exceeded."
                        errmsg = "Select cabinet with airflow over 20,000 cfm.  Continue or Cancel?"
                        dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                        If dummy = vbCancel Then Stop
                        If SuperUser() Then
                            errmsg = "Enter custom message for Design Notes Report"
                            ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                        End If
                        pCount1002 = 0
                        pCount508 = 0
                End Select

            Case Is = "SeriesLX"
                ldn = "Series LX cabinets are not supported.  Program limits exceeded"
                errmsg = "Series LX cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Series20IDSplit"
                ldn = "Series 20 ID Split cabinets are not supported.  Program limits exceeded"
                errmsg = "Series 20 ID Split cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "DOAS"
                ldn = "DOAS cabinets are not supported.  Program limits exceeded"
                errmsg = "DOAS cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "SeriesL"
                ldn = "SeriesL cabinets are not supported.  Program limits exceeded"
                errmsg = "SeriesL cabinets are not supported in this module yet.  Continue or Cancel?"
                dummy = MsgBox(errmsg, vbOKCancel, frmMain.gProgName)
                If dummy = vbCancel Then Stop
                If SuperUser() Then
                    errmsg = "Enter custom message for Design Notes Report"
                    ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                End If
                pCount1002 = 0
                pCount508 = 0
            Case Is = "Blank"
                ldn = "Example: 1 Matterhorn 1002 with (2) F Tubes / Order with S-Clips / Order with Remote Indicator."
                errmsg = "Enter custom message for Design Notes Report"
                ldn = InputBox(errmsg, frmMain.gProgName, ldn)
                errmsg = "How many Matterhorn 1002s?"
                lcount = "0"
                lcount = InputBox(errmsg, frmMain.gProgName, lcount)
                pCount1002 = Val(lcount)
                errmsg = "How many Matterhorn 508s?"
                lcount = "0"
                lcount = InputBox(errmsg, frmMain.gProgName, lcount)
                pCount508 = Val(lcount)
            Case Else
                dummy = MsgBox("Error in BiPolar:GetGeneratorDetails: " & frmMain.ThisUnit.Family & " is not defined.", vbOKOnly, frmMain.gProgName)
                Stop
        End Select
        Return ldn
    End Function
    Private Sub UpdatePerformance()
        Dim NewRow As String()
        Dim RqdVA As Double
        Dim XFmrVA As Double
        Dim PriVolts As Double
        Dim PrimeAmps As Double
        Dim ElecChar As String
        Dim PutOnEmergency As Boolean
        Dim PutOnCommercial As Boolean
        Dim SourceText As String

        PutOnEmergency = False

        PriVolts = Val(frmMain.ThisUnitElecData.CommVolts)
        ElecChar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq

        XFmrVA = Val(StandardTransformer(pCount1002 * 0.037 + pCount508 * 0.48))
        SourceText = "Math-" & Trim(Str(XFmrVA)) & "va transformer."
        If optPwrUnitPower.Checked Then
            PrimeAmps = XfmrPrimaryAmps(PriVolts, XFmrVA)
            If PrimeAmps > 0.9999 Then
                If optDPPEmergency.Checked Then PutOnEmergency = True
                PutOnCommercial = Not (PutOnEmergency)
                NewRow = {True, False, "All", PutOnCommercial, "Bipolar Ionization Transformer", ElecChar, "-", Format(PrimeAmps, "0.0"), PutOnEmergency, SourceText}
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
            Case Is = "Series12"
                optUseAux.Checked = frmMain.HasAuxillaryPanel
                optInstDSEvap.Checked = True
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

        txtDesignNotesHard.Text = "***BiPolar Notes and Comments***" & vbCrLf



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
        Dim PowerSource As String

        PowerSource = "Undefined Error."
        If optPwrUnitPower.Checked Then PowerSource = "Unit Powered Transformer, Fisen Installed."
        If optPwrConvOutlet.Checked Then PowerSource = "JCI Powered Convenience Outlet Transformer."
        If optPwrDedicated.Checked Then PowerSource = "Dedicated 115 VAC Circuit, Field Wired."
        txtDesignNotesHard.Text = txtDesignNotesHard.Text & "Bipolar Ionization Powered by " & PowerSource & vbCrLf
        If Not (optDPPNA.Checked) Then
            PowerSource = "Undefined Error."
            If optDPPEmergency.Checked Then PowerSource = "Unit mounted transformer on Emergency Circuit."
            If optDPPCommercial.Checked Then PowerSource = "Unit mounted transformer on Commercial Circuit."
            txtDesignNotesHard.Text = txtDesignNotesHard.Text & PowerSource & vbCrLf
        End If
        If chkShareXfmr.Checked Then txtDesignNotesHard.Text = txtDesignNotesHard.Text & "Transformer shared with UV Lights." & vbCrLf
        If chk65kASCCRBase.Checked Then txtDesignNotesHard.Text = txtDesignNotesHard.Text & "Base unit is 65k SCCR.  BiPolar must also be 65k SCCR." & vbCrLf


        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        If cmbBipolarStyle.Text = "Use Standard" Then
            txtDesignNotesHard.Text = txtDesignNotesHard.Text & GetGeneratorDetails() & vbCrLf
            If optPwrUnitPower.Checked Then
                txtDesignNotesHard.Text = txtDesignNotesHard.Text & GetRequredTransformer() & vbCrLf
                txtPerfNotes.Text = GetRequredTransformer() & vbCrLf
            End If
        End If

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click

        TabControl1.SelectTab("tpgNotesPage")
    End Sub

    Private Sub btnDoneNotes_Click(sender As Object, e As EventArgs) Handles btnDoneNotes.Click
        If txtDesignNotesSoft.Text = "" Then txtDesignNotesSoft.Text = "No user entered design notes."
        btnOK.Enabled = True
        btnDoneNotes.Enabled = False
    End Sub

    Private Function GetRequredTransformer() As String
        Dim lSharedXfmr As Boolean
        Dim ldn As String
        Dim rqdVA As Double
        Dim lpvolts As Double

        lpvolts = Val(frmMain.ThisUnitElecData.CommVolts)

        lSharedXfmr = chkShareXfmr.Checked
        rqdVA = pCount1002 * 0.037 + pCount508 * 0.48
        ldn = "Unit Mounted and Wired Power Supply - " & StandardTransformer(rqdVA) & " va Transformer - " & Trim(Str(XfmrPrimaryAmps(lpvolts, Val(StandardTransformer(rqdVA))))) & " Amps at " & frmMain.ThisUnitElecData.CommVolts & "."
        If XfmrPrimaryAmps(lpvolts, Val(StandardTransformer(rqdVA))) < 1.0 Then
            ldn = ldn & " No impact on MCA/MOP."
        End If
        Return ldn
    End Function
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

    Private Sub chkEMControlsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkEMControlsOnly.CheckedChanged
        If chkEMControlsOnly.Checked Then
            grpMnAOptions.Enabled = False
            chkBACnetMnA.Checked = False
            optNoMnA.Checked = True
        Else
            grpMnAOptions.Enabled = True
            chkBACnetMnA.Checked = True
            optRemoteMnA.Checked = True

        End If
    End Sub

    Private Sub chkBACnetMnA_CheckedChanged(sender As Object, e As EventArgs) Handles chkBACnetMnA.CheckedChanged
        If chkBACnetMnA.Checked Then
            optBACnetOnlyMnA.Enabled = True
        Else
            optBACnetOnlyMnA.Enabled = False
            optNoMnA.Checked = True
        End If
    End Sub


End Class