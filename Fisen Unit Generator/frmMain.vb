﻿Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Drawing.Imaging
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Vbe.Interop
Imports System.Xml.Schema
Imports System.Windows.Markup

Public Class frmMain
    Public Const gProgName As String = "Fisen Unit Generator"
    Public ThisUnit As clsUnitClass
    Public ThisUnitDS As clsDSUnitClass
    Public ThisUnitCoolPerf As clsCoolPerf
    Public ThisUnitRHPerf As clsReheatPerf
    Public ThisUnitHeatPerf As clsHeatPerf
    Public ThisUnitSFanPerf As clsSupplyPerf
    Public ThisUnitIFilters As clsFilters
    Public ThisUnitFFilters As clsFilters
    Public ThisUnitJCIFilters As clsFilters
    Public ThisUnitMFilters As clsFilters
    Public ThisUnitRXPerf As ClsRXPerf
    Public ThisChillerMainPerf As clsChillerMainPerf
    Public ThisUnitWarrTest As clsWarrTest
    Public ThisUnitPhysicalData As clsPhysicalData
    Public ThisUnitElecData As clsElecData
    Public ThisUnitHydroData As ClsHydronicsData
    Public ThisUnitRefData As ClsRefrigData
    Public ThisUnitSpecialPerf As ClsSpecialPerf
    Public ThisUnitCstmCoilPerf As ClsCustomCoil
    Public ThisUnitERWPerf As ClsERW
    Public ThisYPALPerf As ClsYPALMainPerf
    Public ModBarn As clsModPaddock
    Public JCICoolPerf As clsJCICoolPerfCalc
    Public ThisUnitControls As clsControls

    Public ThisUnitMods As New ArrayList
    Public ThisUnitCodes As New ArrayList
    Public ThisUnitCstmMechCodes As New ArrayList
    Public ThisUnitCstmCtrlCodes As New ArrayList
    Public ThisUnitCstmHVCodes As New ArrayList
    Public ThisUnitCstmRefCodes As New ArrayList
    Public ThisUnitCstmSMCodes As New ArrayList
    Public ThisUnitGenCodes As New ArrayList
    Public ThisUnitDQCodes As New ArrayList
    Public ThisUnitFactOpts As New ArrayList
    Public ThisUnitFieldInst As New ArrayList
    Public ThisUnitEndDevices As New ArrayList
    Public ThisUnitUnitDrawings As New ArrayList
    Public ThisUnitUnitDrawingsAction As New ArrayList
    Public ThisUnitHydro As New ArrayList
    Public ThisUnitRefer As New ArrayList
    Public ThisUnitReferSpecs As New ArrayList
    Public ThisUnitReferSpecsTag As New ArrayList
    Public ThisUnitAirflow As New ArrayList

    Public UserOptions As New clsUserOptions

    Public ThisUnitAirflowDiag As New ArrayList

    Private DwgDesc(500) As String
    Public UnitWMFPAth As New ArrayList

    Private HydroDesc(50) As String

    Private ReferDesc(50) As String
    Public ReferWMFPath As New ArrayList

    Private AirflowDesc(50) As String
    Private PipePkgDefined As Boolean
    Private ERWDefined As Boolean
    Private ProgramGTG As Boolean

    Public UseCustomMCA As Boolean
    Public HasAuxillaryPanel As Boolean

    Public UserID As String

    Public DesignNotes As String


    Public ReadOnly Property SU As Boolean
        Get
            SU = False
            If chkDebug.Checked Then SU = True
            If UserID = "jlevine" Then SU = True
            If UserID = "jmucinski" Then SU = True
            If UserID = "jruemenapp" Then SU = True
        End Get
    End Property

    Public Function HasHMI() As Boolean
        Dim i As Integer
        Dim ListTop As Integer
        Dim RetVal As Boolean
        RetVal = False
        i = 0

        ListTop = ThisUnitGenCodes.Count
        If ListTop > 0 Then
            For i = 0 To (ListTop - 1)
                If ((ThisUnitGenCodes.Item(i) = "960001")) Then
                    RetVal = True
                End If
            Next
        End If
        Return RetVal
    End Function
    Public Function HasUMHMI() As Boolean
        Dim i As Integer
        Dim ListTop As Integer
        Dim RetVal As Boolean
        RetVal = False
        i = 0

        ListTop = ThisUnitGenCodes.Count
        If ListTop > 0 Then
            For i = 0 To (ListTop - 1)
                If ((ThisUnitGenCodes.Item(i) = "960002")) Then
                    RetVal = True
                End If
            Next
        End If
        Return RetVal
    End Function

    Private Sub optRTU_CheckedChanged(sender As Object, e As EventArgs) Handles optRTU.CheckedChanged
        fraRTU.Enabled = True
        fraAHU.Enabled = False
        fraChiller.Enabled = False
        fraMisc.Enabled = False
    End Sub
    Private Sub optAHU_CheckedChanged(sender As Object, e As EventArgs) Handles optAHU.CheckedChanged
        fraRTU.Enabled = False
        fraAHU.Enabled = True
        fraChiller.Enabled = False
        fraMisc.Enabled = False
    End Sub
    Private Sub optChiller_CheckedChanged(sender As Object, e As EventArgs) Handles optChiller.CheckedChanged
        fraRTU.Enabled = False
        fraAHU.Enabled = False
        fraChiller.Enabled = True
        fraMisc.Enabled = False
        If optChiller.Checked Then optChillerYVAA.Checked = True
    End Sub

    Private Sub optBlankFamily_CheckedChanged(sender As Object, e As EventArgs) Handles optBlankFamily.CheckedChanged
        fraRTU.Enabled = False
        fraAHU.Enabled = False
        fraChiller.Enabled = False
        fraMisc.Enabled = False
    End Sub

    Private Function SetUnitFamily() As String
        Dim TempFamily

        TempFamily = "Error in SetUnitFamily()"

        If optRTUSeries5.Checked Then TempFamily = "Series5"
        If optRTUSeries10.Checked Then TempFamily = "Series10"
        If optRTUSeries12.Checked Then TempFamily = "Series12"
        If optRTUSeries20.Checked Then TempFamily = "Series20"
        If optRTUSeries40.Checked Then TempFamily = "Series40"
        If optRTUSeries100.Checked Then TempFamily = "Series100"
        If optRTUChoice.Checked Then TempFamily = "Choice"
        If optRTUPremier.Checked Then TempFamily = "Premier"
        If optRTUSelect.Checked Then TempFamily = "Select"
        If optRTUSeriesLX.Checked Then TempFamily = "SeriesLX"

        If optAHUXTI.Checked Then TempFamily = "XTI"
        If optAHUXTO.Checked Then TempFamily = "XTO"
        If optAHUYorkCustom.Checked Then TempFamily = "YorkCustom"

        If optChillerYCAL.Checked Then TempFamily = "YCAL"
        If optChillerYLAA.Checked Then TempFamily = "YLAA"
        If optChillerYVAA.Checked Then TempFamily = "YVAA"
        If optChillerYCIV.Checked Then TempFamily = "YCIV"
        If optChillerYCAV.Checked Then TempFamily = "YCAV"

        If optMiscDS.Checked Then TempFamily = "DS"
        If optS20ODSplit.Checked Then TempFamily = "Series20ODSplit"
        If optS40ODSplit.Checked Then TempFamily = "Series40ODSplit"
        If optS20IDSplit.Checked Then TempFamily = "Series20IDSplit"
        If optYCULSplit.Checked Then TempFamily = "YCUL"
        If optYLUASplit.Checked Then TempFamily = "YLUA"
        If optDOAS.Checked Then TempFamily = "DOAS"

        If optLSeries.Checked Then TempFamily = "SeriesL"

        If optBlankFamily.Checked Then TempFamily = "Blank"

        Return TempFamily
    End Function
    Private Function SetUnitCabinet() As String
        Dim dummy As MsgBoxResult
        Dim TempCabinet As String
        TempCabinet = "n/a"
        If optRTUSeries100.Checked = True Then
            If ((chkS100ACabinet.Checked = False) And (chkS100BCabinet.Checked = False) And (chkS100CCabinet.Checked = False)) Then
                dummy = MsgBox("Please Choose a Cabinet Size", vbOK)
            End If
            If chkS100ACabinet.Checked Then TempCabinet = "Series100A"
            If chkS100BCabinet.Checked Then TempCabinet = "Series100B"
            If chkS100CCabinet.Checked Then TempCabinet = "Series100C"
        End If

        Return TempCabinet
    End Function
    Private Function SetUnitKingdom() As String
        Dim TempKing As String

        TempKing = "Error in SetUnitKingdom()"
        If optRTU.Checked Then TempKing = "RTU"
        If optAHU.Checked Then TempKing = "AHU"
        If optChiller.Checked Then TempKing = "Chiller"
        If optMisc.Checked Then TempKing = "Misc"
        If optBlankFamily.Checked Then TempKing = "Blank"

        Return TempKing
    End Function
    Private Sub btnDoneBU_Click(sender As Object, e As EventArgs) Handles btnDoneBU.Click

        Dim dummy As MsgBoxResult

        If optRTUSeries100.Checked = True Then
            If ((chkS100ACabinet.Checked = False) And (chkS100BCabinet.Checked = False) And (chkS100CCabinet.Checked = False)) Then
                dummy = MsgBox("Please Choose a Cabinet Size", vbOK)
                Exit Sub
            End If
        End If

        ProgramGTG = True

        ThisUnit.Family = SetUnitFamily()
        ThisUnit.Cabinet = SetUnitCabinet()
        ThisUnit.Kingdom = SetUnitKingdom()

        My.Settings.LastFamily = SetUnitFamily()
        My.Settings.LastCabinet = SetUnitCabinet()
        My.Settings.LastKingdom = SetUnitKingdom()

        If chkDebug.Checked = False Then
            chkDebug.Visible = False
        End If

        TSLabelFamily.Text = "Family: " & ThisUnit.Family

        txtJobNumber.Text = My.Settings.LastJobNumber
        txtUnitNumber.Text = My.Settings.LastUnitNumber
        txtProjectDirectory.Text = My.Settings.LastProjDir

        If IsNumeric(Mid(txtJobNumber.Text, 1, 4)) Then
            nudJobNumberAdj.Value = Val(Mid(txtJobNumber.Text, 1, 4))
        Else
            nudJobNumberAdj.Value = 3300
        End If
        My.Settings.Save()

        If Not (LocalJobDirExists()) Then

            If My.Settings.UOLocalFolder = "" Then
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Desktop\")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.UOLocalFolder)
            End If

        End If
        Call WritePageRedoFileBU()

        tabMain.SelectTab("pgProjectData")
    End Sub

    Private Sub WritePageRedoFileBU()
        Dim myXMLSettings As New XmlWriterSettings
        Dim UnitWriter As XmlWriter
        Dim TargetPath As String

        myXMLSettings.Indent = True
        myXMLSettings.NewLineOnAttributes = True

        TargetPath = My.Settings.UOLocalFolder & "LastUnitRedoFile.xml"
        UnitWriter = XmlWriter.Create(TargetPath, myXMLSettings)

        UnitWriter.WriteComment("Fisen Unit Definition File")

        UnitWriter.WriteStartElement("BaseUnit")

        UnitWriter.WriteStartElement("Kingdom")
        UnitWriter.WriteString(SetUnitKingdom())
        UnitWriter.WriteEndElement() 'Kingdom 

        UnitWriter.WriteStartElement("Family")
        UnitWriter.WriteString(SetUnitFamily())
        UnitWriter.WriteEndElement() 'Kingdom 

        UnitWriter.WriteStartElement("Family")
        UnitWriter.WriteString(SetUnitFamily())
        UnitWriter.WriteEndElement() 'Family 

        UnitWriter.WriteStartElement("Cabinet")
        UnitWriter.WriteString(SetUnitCabinet())
        UnitWriter.WriteEndElement() 'Cabinet 

        UnitWriter.WriteEndElement() 'BaseUnit

        UnitWriter.WriteEndDocument()
        UnitWriter.Close()
    End Sub

    Private Sub PreloadBaseChiller()
        txtBCNetCoolCap.Text = ThisChillerMainPerf.NetCapacity
        txtBCRefType.Text = ThisChillerMainPerf.Refrigerant
        If ThisUnit.Family = "YLAA" Then
            Select Case ThisChillerMainPerf.NominalTons
                Case Is = "70.0"
                    txtBCFanCount.Text = "4"
                Case Else
                    txtBCFanCount.Text = "-"
            End Select
        End If

        txtBCPinA.Text = ThisChillerMainPerf.PINA
        txtBCPinB.Text = ThisChillerMainPerf.PINB
        txtBCPinC.Text = ThisChillerMainPerf.PINC
        txtBCPinD.Text = ThisChillerMainPerf.PIND
        txtBCPinE.Text = ThisChillerMainPerf.PINE
        txtBCPinF.Text = ThisChillerMainPerf.PINF
        txtBCPinG.Text = ThisChillerMainPerf.PING
        txtBCPinH.Text = ThisChillerMainPerf.PINH
        txtBCPinI.Text = ThisChillerMainPerf.PINI

        txtBCEWT.Text = ThisChillerMainPerf.EWT
        txtBCLWT.Text = ThisChillerMainPerf.LWT
        txtBCFlow.Text = ThisChillerMainPerf.Flow
        txtBCFPD.Text = ThisChillerMainPerf.FPD

        Select Case ThisChillerMainPerf.Fluid
            Case Is = "Water"
                cmbFluid.Text = "Water"
            Case Is = "PG"
                cmbFluid.Text = "Propylene Glycol"
            Case Is = "EG"
                cmbFluid.Text = "Ethylene Glycol"
        End Select

        cmbFluidPercent.Text = ThisChillerMainPerf.FluidPercent

        txtFoulFactor.Text = ThisChillerMainPerf.FoulingFactor

        txtBCFluidVol.Text = ThisChillerMainPerf.EvapVolume
        txtBCMinFlow.Text = ThisChillerMainPerf.MinFlow
        txtBCMaxFlow.Text = ThisChillerMainPerf.MaxFlow

        txtBCAmbient.Text = ThisChillerMainPerf.Ambient
        txtBCAltitude.Text = ThisChillerMainPerf.Altitude
        txtMinAmbient.Text = ThisChillerMainPerf.MinAmbient

        txtBCEER.Text = ThisChillerMainPerf.EER
        txtBCIPLV.Text = ThisChillerMainPerf.IPLV
        txtBCNPLV.Text = ThisChillerMainPerf.NPLV

        txtBCRigMass.Text = ThisChillerMainPerf.RigWeight
        txtBCOpMass.Text = ThisChillerMainPerf.OpWeight
        txtBCRefCharge.Text = ThisChillerMainPerf.RefrigerantCharge
        txtChillerLength.Text = "360.0"
        txtChillerWidth.Text = "82.8"

        txtChillCompressorkW.Text = ThisUnitElecData.CompressorkW

        txtChillTotalkW.Text = ThisUnitElecData.TotalkW


        txtBCVolts.Text = ThisUnitElecData.CommVolts

        txtChillMCA.Text = ThisUnitElecData.CommMCA
        If ThisUnit.Family = "YVAA" Then
            lblMinRecFuse.Text = "Min Fuse"
            txtMinRecFuse.Text = ThisUnitElecData.MinFuse
            lblMaxFuseMaxCB.Text = "Max Fuse"
            txtMaxFuseMaxCB.Text = ThisUnitElecData.CommMOP
            lblMaxDE.Visible = False
            txtMaxDE.Visible = False
            lblPowerFactorStarter.Text = "Power Factor"
            txtChillPowerFactorStarter.Text = ThisUnitElecData.PowerFactor

        Else
            txtMinRecFuse.Text = ThisUnitElecData.RecFuse
            txtMaxFuseMaxCB.Text = ThisUnitElecData.MaxCB
            txtMaxDE.Text = ThisUnitElecData.MaxDE
            txtChillPowerFactorStarter.Visible = False
            lblPowerFactorStarter.Visible = False
            lblPowerFactorStarter.Text = "Starter Type"
            txtChillPowerFactorStarter.Text = ThisUnitElecData.StarterType
        End If
        txtChillSCCR.Text = ThisUnitElecData.SCCR
        txtChillLugs.Text = ThisUnitElecData.WiresPerPhase
        txtChillWireSize.Text = ThisUnitElecData.LugSize

        txtChillControlkVA.Text = ThisUnitElecData.ControlkVA




    End Sub
    Private Sub LoadApplicableDrawings()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i, j As Integer
        Dim FilterMatch As Boolean
        Dim StubMatch As Boolean
        Dim TempVar As String
        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailDwgs.Items.Clear()
        UnitWMFPAth.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        If ThisUnit.Family = "Select" Then TempVar = "xSelectx" Else TempVar = ThisUnit.Family

        MySQL = "Select * FROM tblUnitDrawings WHERE " & TempVar & "=True ORDER BY PlainName"

        'Pull back all the drawings if blank
        If ThisUnit.Family = "Blank" Then MySQL = "Select * FROM tblUnitDrawings ORDER BY PlainName"

        rs.Open(MySQL, con)

        i = 0
        rs.MoveFirst()
        'FilterMatch = True

        Do While Not (rs.EOF)
            FilterMatch = True
            StubMatch = False
            'First filter on the stub if checked
            If chkUnitFilterOnStubbs.Checked Then
                If InStr(rs.Fields("DrawingID").Value, lblStubTag.Text) > 0 Then StubMatch = True
            Else
                StubMatch = True
            End If

            'Second see if the record contains each and every tag
            For j = 0 To lstUnitTagstoApply.SelectedItems.Count - 1
                If Not (InStr(rs.Fields("DrawingID").Value, lstUnitTagstoApply.SelectedItems(j)) > 0) Then FilterMatch = False
            Next

            'If lstUnitTagstoApply.SelectedItems.Count > 0 Then
            '    For j = 0 To lstUnitTagstoApply.SelectedItems.Count - 1
            '        If (InStr(rs.Fields("DrawingID").Value, lstUnitTagstoApply.SelectedItems(j)) > 0) Then
            '            If chkUnitFilterOnStubbs.Checked Then
            '                If Not (InStr(rs.Fields("DrawingID").Value, lblStubTag.Text) > 0) Then FilterMatch = False
            '            Else
            '                FilterMatch = FilterMatch And True
            '            End If
            '        Else
            '            FilterMatch = False
            '        End If
            '    Next
            'End If

            If FilterMatch And StubMatch Then
                lstAvailDwgs.Items.Add(rs.Fields("PlainName").Value)
                DwgDesc(i) = rs.Fields("DrawingDescription").Value
                UnitWMFPAth.Add(My.Settings.ResourceDir & "BaseUnit\Drawings" & rs.Fields("DrawingPath").Value & rs.Fields("WMFName").Value)
                i = i + 1
            End If
            rs.MoveNext()
            FilterMatch = True
            StubMatch = False
        Loop

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadApplicableAirflow()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer
        Dim TempVar As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailAirflow.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        If ThisUnit.Family = "Select" Then TempVar = "xSelectx" Else TempVar = ThisUnit.Family

        MySQL = "Select * FROM tblAirflowDiagrams WHERE " & TempVar & "=True"
        If ThisUnit.Family = "Blank" Then MySQL = "Select * FROM tblAirflowDiagrams"

        rs.Open(MySQL, con)
        '       If rs.RecordCount > 0 Then
        rs.MoveFirst()
        i = 0
        Do While Not (rs.EOF)
            lstAvailAirflow.Items.Add(rs.Fields("PlainName").Value)
            AirflowDesc(i) = rs.Fields("DrawingDescription").Value
            i = i + 1
            rs.MoveNext()
        Loop
        'End If
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadApplicableRefer()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer
        Dim TempVar As String
        Dim FilterMatch As Boolean

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailRefer.Items.Clear()
        ReferWMFPath.Clear()
        FilterMatch = False


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        If ThisUnit.Family = "Select" Then TempVar = "xSelectx" Else TempVar = ThisUnit.Family
        MySQL = "Select * FROM tblReferDrawings WHERE " & TempVar & "=True"
        If ThisUnit.Family = "Blank" Then MySQL = "Select * FROM tblReferDrawings"
        rs.Open(MySQL, con)
        '       If rs.RecordCount > 0 Then
        rs.MoveFirst()
        i = 0
        Do While Not (rs.EOF)
            If lstReferTagstoApply.SelectedItems.Count > 0 Then
                For j = 0 To lstReferTagstoApply.SelectedItems.Count - 1
                    If InStr(rs.Fields("DrawingID").Value, lstReferTagstoApply.SelectedItems(j)) > 0 Then
                        FilterMatch = FilterMatch And True
                    Else
                        FilterMatch = False
                    End If
                Next
            End If
            If chkReferFilterOnStubb.Checked Then
                If InStr(rs.Fields("DrawingID").Value, Mid(ThisUnit.ModelNumber, 1, 5)) > 0 Then
                    FilterMatch = FilterMatch And True
                Else
                    FilterMatch = False
                End If
            End If
            If FilterMatch Then
                lstAvailRefer.Items.Add(rs.Fields("PlainName").Value)
                ReferDesc(i) = rs.Fields("DrawingDescription").Value
                ReferWMFPath.Add(My.Settings.ResourceDir & "ReferDrawings" & rs.Fields("DrawingPath").Value & rs.Fields("WMFName").Value)
                i = i + 1
            End If
            rs.MoveNext()
            FilterMatch = True
        Loop
        'End If
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadApplicableHydro()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim i As Integer
        Dim TempVar As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstAvailHydro.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }
        If ThisUnit.Family = "Select" Then TempVar = "xSelectx" Else TempVar = ThisUnit.Family
        MySQL = "Select * FROM tblHydroDrawings WHERE " & TempVar & "=True"
        If ThisUnit.Family = "Blank" Then MySQL = "Select * FROM tblHydroDrawings"

        rs.Open(MySQL, con)
        '       If rs.RecordCount > 0 Then
        rs.MoveFirst()
        i = 0
        Do While Not (rs.EOF)
            lstAvailHydro.Items.Add(rs.Fields("PlainName").Value)
            HydroDesc(i) = rs.Fields("DrawingDescription").Value
            i = i + 1
            rs.MoveNext()
        Loop
        'End If
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub loadPermittedMods()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstAvailableMods.Items.Clear()
        lstSelectedMods.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblModCodes WHERE " & ThisUnit.Family & "OK=True ORDER BY ModPlainName"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstAvailableMods.Items.Add(rs.Fields("ModPlainName").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        If lstAvailableMods.Text <> "" Then
            lstSelectedMods.Items.Add(lstAvailableMods.Text)
            lstAvailableMods.Items.Remove(lstAvailableMods.SelectedItem)
        End If

    End Sub
    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click
        lstAvailableMods.Items.Add(lstSelectedMods.SelectedItem)
        lstSelectedMods.Items.Remove(lstSelectedMods.SelectedItem)
    End Sub
    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click
        Call loadPermittedMods()
    End Sub

    Private Function MZBaseRequired() As Boolean
        Dim i As Integer
        Dim TempRQ As Boolean
        TempRQ = False
        For i = 0 To lstSelectedMods.Items.Count - 1
            If lstSelectedMods.Items(i) = "Multizone - Adapter Curb" Then
                TempRQ = True
                lstSelectedMods.Items.RemoveAt(i)
                Exit For
            End If
        Next
        MZBaseRequired = TempRQ
    End Function
    Private Sub btnDoneModSel_Click(sender As Object, e As EventArgs) Handles btnDoneModSel.Click
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim OA100Present, LowAFPresent As Boolean

        Dim thisitem As String

        'check for no selections
        If lstSelectedMods.Items.Count = 0 Then
            dummy = MsgBox("You haven't selected any modifications." & vbCrLf & "Are you certain?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbNo Then Exit Sub
        End If

        'scan for 100% OA without low airflow
        OA100Present = False
        LowAFPresent = False
        For i = 0 To lstSelectedMods.Items.Count - 1
            If lstSelectedMods.Items(i) = "100% Outdoor Air" Then OA100Present = True
            If lstSelectedMods.Items(i) = "Reduced Air Flow" Then LowAFPresent = True
            If lstSelectedMods.Items(i) = "Short Circuit Current Rating" Then ThisUnitElecData.UnitIs65kASCCR = True
        Next
        If (OA100Present And Not (LowAFPresent)) Then
            dummy = MsgBox("You have selected 100% OA without Reduced Airflow.  Are you certain you want to proceed?", vbYesNo, "Fisen Unit Generator")
            If dummy = vbNo Then Exit Sub
        End If


        'This block of codes processes mods at a higher priority
        For i = 0 To lstSelectedMods.Items.Count - 1
            If lstSelectedMods.Items(i) = "Reduced Air Flow" Then
                frmLowAF.ShowDialog()
                If frmLowAF.Cancelled = True Then
                    dummy = MsgBox("User Cancelled Generation in LowAF Module." & vbCrLf & "Exiting Program.", vbOKOnly, "Fisen Unit Generator")
                    Call WriteToEventLog("LowAF", "User Cancelled", "Operator", Str(dummy))
                    End
                Else
                    frmLowAF.Dispose()
                End If

                lstSelectedMods.Items.RemoveAt(i)
                Exit For
            End If
        Next

        'this block of codes processes/moves mods that should be processed last to the end of the list.

        'Add Dual Point Power to the Very End of the list!
        For i = 0 To lstSelectedMods.Items.Count - 1
            If lstSelectedMods.Items(i) = "Dual Point Power" Then
                lstSelectedMods.Items.Add("Dual Point Power")
                lstSelectedMods.Items.RemoveAt(i)
                ThisUnitElecData.DPPPresent = True
                Exit For
            End If
        Next


        Do While lstSelectedMods.Items.Count > 0

            thisitem = lstSelectedMods.Items(0)
            Select Case thisitem
                Case Is = "100% Outdoor Air"
                    frm100OA.ShowDialog()
                    If frm100OA.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in 100% OA Module.  Exiting Program.")
                        Call WriteToEventLog("100OA", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frm100OA.Dispose()
                    End If

                Case Is = "Acoustic Package"
                    frmAcoustic.ShowDialog()
                    If frmAcoustic.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Acoustic Package Module.  Exiting Program.")
                        Call WriteToEventLog("100OA", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmAcoustic.Dispose()
                    End If

                Case Is = "Airflow Path Reconfiguration"
                    frmAFlowMod.ShowDialog()
                    If frmAFlowMod.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Airflow Path Reconfiguration Module.  Exiting Program.")
                        Call WriteToEventLog("AFlowMod", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmAFlowMod.Dispose()
                    End If

                Case Is = "Bipolar Ionization Array"
                    frmBiPolar.ShowDialog()
                    If frmBiPolar.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Bipolar Module.  Exiting Program.")
                        Call WriteToEventLog("BiPolar", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmBiPolar.Dispose()
                    End If

                Case Is = "Chilled Water Coil"
                    frmCHWCoil.ShowDialog()
                    If frmCHWCoil.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Chilled Water Coil.  Exiting Program.")
                        Call WriteToEventLog("CHWCoil", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmCHWCoil.Dispose()
                    End If

                Case Is = "Protective Coatings"
                    frmCoatings.showdialog
                    If frmCoatings.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Chilled Water Coil.  Exiting Program.")
                        Call WriteToEventLog("CHWCoil", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmCoatings.Dispose()
                    End If

                Case Is = "Custom Coil"
                    frmCustomCoil.ShowDialog()
                    If frmCustomCoil.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation in Custom Coil Module.  Exiting Program.")
                        Call WriteToEventLog("CstmCoil", "User Cancelled", "Operator", Str(dummy))
                        Stop
                    Else
                        frmCustomCoil.Dispose()
                    End If

                Case Is = "Custom Controls"
                    frmCstmCtrl.ShowDialog()
                    If frmCstmCtrl.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmCtrl.Dispose()
                    End If

                Case Is = "Custom Enclosure"
                    frmCstmEnclosure.ShowDialog()
                    If frmCstmEnclosure.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmEnclosure.Dispose()
                    End If

                Case Is = "Custom Mechanical Options"
                    frmCstmMech.ShowDialog()
                    If frmCstmMech.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmMech.Dispose()
                    End If

                Case Is = "Custom Power Options"
                    frmCstmHV.ShowDialog()
                    If frmCstmHV.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmHV.Dispose()
                    End If

                Case Is = "Custom Refrigeration"
                    frmCstmRef.ShowDialog()
                    If frmCstmRef.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmRef.Dispose()
                    End If

                Case Is = "Custom Sheetmetal"
                    frmCstmSM.ShowDialog()
                    If frmCstmSM.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmCstmSM.Dispose()
                    End If

                Case Is = "Digital Scroll Compressor"
                    frmDigScroll.ShowDialog()
                    If frmDigScroll.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmDigScroll.Dispose()
                    End If



                Case Is = "Double Wall Sheetmetal Liners"
                    frmDWall.ShowDialog()
                    If frmDWall.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmDWall.Dispose()
                    End If

                Case Is = "Dual Point Power"
                    frmDPP.ShowDialog()
                    If frmDPP.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In Dual Point Power Modula.  Exiting Program.")
                        End
                    Else
                        frmDPP.Dispose()
                    End If

                Case Is = "Energy Recovery Wheel"
                    frmERW.ShowDialog()
                    If frmERW.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In ERW Module.  Exiting Program.")
                        End
                    Else
                        ERWDefined = True
                        frmERW.Dispose()
                    End If

                Case Is = "ERV Economizer Assist Module"
                    frmERVEAM.ShowDialog()
                    If frmERVEAM.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In ERV Integration Module.  Exiting Program.")
                        End
                    Else
                        ERWDefined = True
                        frmERVIntegration.Dispose()
                    End If

                Case Is = "ERV Integration"
                    frmERVIntegration.ShowDialog()
                    If frmERVIntegration.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In ERV Integration Module.  Exiting Program.")
                        End
                    Else
                        ERWDefined = True
                        frmERVIntegration.Dispose()
                    End If

                Case Is = "Exhaust Fan"
                    frmNewFan.FanStyle = "Exhaust Fan"
                    frmNewFan.ShowDialog()
                    If frmNewFan.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmNewFan.Dispose()
                    End If

                Case Is = "Extended Cabinet"
                    frmExtend.ShowDialog()
                    If frmExtend.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In Extended Cabinet Module.  Exiting Program.")
                        End
                    Else
                        frmExtend.Dispose()
                    End If

                Case Is = "Supply Fan VFD"
                    frmFanVFD.FanType = "Supply Fan"
                    frmFanVFD.ShowDialog()
                    If frmFanVFD.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmFanVFD.Dispose()
                    End If

                Case Is = "Return Fan VFD"
                    frmFanVFD.FanType = "Return Fan"
                    frmFanVFD.ShowDialog()
                    If frmFanVFD.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmFanVFD.Dispose()
                    End If

                Case Is = "Exhaust Fan VFD"
                    frmFanVFD.FanType = "Exhaust Fan"
                    frmFanVFD.ShowDialog()
                    If frmFanVFD.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmFanVFD.Dispose()
                    End If

                Case Is = "Filtration"
                    frmFiltration.ShowDialog()
                    If frmFiltration.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation In Filtration Module.  Exiting Program.")
                        End
                    Else
                        frmFiltration.Dispose()
                    End If

                Case Is = "Hot Gas Bypass"
                    frmHGBP.ShowDialog()
                    If frmHGBP.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmHGBP.Dispose()
                    End If

                Case Is = "Hot Gas Reheat"
                    frmHGRH.ShowDialog()
                    If frmHGRH.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmHGRH.Dispose()
                    End If

                Case Is = "Hot Water Coil"
                    frmHWCoil.ShowDialog()
                    If frmHWCoil.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmHWCoil.Dispose()
                    End If

                Case Is = "Humidification"
                    frmHumid.ShowDialog()
                    If frmHumid.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        'This form stays loaded for access to the schedule data at write time.
                        'frmPipePkg.Dispose()
                        'PipePkgDefined = True
                    End If

                Case Is = "Light Commercial VAV"
                    frmLCVAV.ShowDialog()
                    If frmFanVFD.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmLCVAV.Dispose()
                    End If

                Case Is = "Low Ambient Start"
                    frmLowAmbient.ShowDialog()
                    If frmLowAmbient.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmLowAmbient.Dispose()
                    End If

                Case Is = "Modulating Electric Main Heat Fisen Provided"
                    frmMEHeat_I.HeatUse = "Main Heat"
                    frmMEHeat_I.ShowDialog()
                    If frmMEHeat_I.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMEHeat_I.Dispose()
                    End If

                Case Is = "Modulating Electric Pre-Heat Fisen Provided"
                    frmMEHeat_I.HeatUse = "Pre-Heat"
                    frmMEHeat_I.ShowDialog()
                    If frmMEHeat_I.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMEHeat_I.Dispose()
                    End If

                Case Is = "Modulating Electric Reactivation Heat Fisen Provided"
                    frmMEHeat_I.HeatUse = "Reactivation Heat"
                    frmMEHeat_I.ShowDialog()
                    If frmMEHeat_I.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMEHeat_I.Dispose()
                    End If

                Case Is = "Modulating Electric Heat Retrofit"
                    frmMEHeat_R.ShowDialog()
                    If frmMEHeat_R.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMEHeat_R.Dispose()
                    End If

                Case Is = "Modulating Gas Heat Heatco"
                    frmMGH_H.ShowDialog()
                    If frmMGH_H.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMGH_H.Dispose()
                    End If

                Case Is = "Modulating Gas Heat Retrofit"
                    frmMGH_R.ShowDialog()
                    If frmMGH_R.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMGH_R.Dispose()
                    End If

                Case Is = "Modulating Hot Gas Reheat Conversion"
                    frmMHGRH_Conv.ShowDialog()
                    If frmMHGRH_Conv.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMHGRH_Conv.Dispose()
                    End If

                Case Is = "Multizone - Packaged VAV"
                    frmMZ.MZStyle = "MZ-VAV"
                    frmMZ.MZCurbPresent = MZBaseRequired()
                    frmMZ.ShowDialog()
                    If frmMZ.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMZ.Dispose()
                    End If

                Case Is = "Multizone - Dual Deck"
                    frmMZ.MZStyle = "MZ-DD"
                    frmMZ.MZCurbPresent = MZBaseRequired()
                    frmMZ.ShowDialog()
                    If frmMZ.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMZ.Dispose()
                    End If

                Case Is = "Multizone - Triple Deck"
                    frmMZ.MZStyle = "MZ-TD"
                    frmMZ.MZCurbPresent = MZBaseRequired()
                    frmMZ.ShowDialog()
                    If frmMZ.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMZ.Dispose()
                    End If

                Case Is = "Multizone - Changeover Bypass"
                    frmMZ.MZStyle = "MZ-COBP"
                    frmMZ.MZCurbPresent = MZBaseRequired()
                    frmMZ.ShowDialog()
                    If frmMZ.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmMZ.Dispose()
                    End If

                Case Is = "Outdoor Airflow Monitoring Station"
                    frmOAFMS.ShowDialog()
                    If frmOAFMS.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmOAFMS.Dispose()
                    End If

                Case Is = "Piping Package"
                    frmPipePkg.ShowDialog()
                    If frmPipePkg.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        'This form stays loaded for access to the schedule data at write time.
                        'frmPipePkg.Dispose()
                        PipePkgDefined = True
                    End If

                Case Is = "Reduced Air Flow"
                    frmLowAF.ShowDialog()
                    If frmLowAF.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmLowAF.Dispose()
                    End If

                Case Is = "Return Fan"
                    frmNewFan.FanStyle = "Return Fan"
                    frmNewFan.ShowDialog()
                    If frmNewFan.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmNewFan.Dispose()
                    End If

                Case Is = "Return Fan Wall"
                    frmFanWall.FanWallStyle = "Return Fan Wall"
                    frmFanWall.ShowDialog()
                    If frmFanWall.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmFanWall.Dispose()
                    End If

                Case Is = "Short Circuit Current Rating"
                    frmSCCR.ShowDialog()
                    If frmSCCR.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmSCCR.Dispose()
                    End If

                Case Is = "Steam Coil"
                    frmSteamCoil.ShowDialog()
                    If frmSteamCoil.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmSteamCoil.Dispose()
                    End If

                Case Is = "Supply Fan"
                    frmNewFan.FanStyle = "Supply Fan"
                    frmNewFan.ShowDialog()
                    If frmNewFan.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmNewFan.Dispose()
                    End If

                Case Is = "Supply Fan Wall"
                    frmFanWall.FanWallStyle = "Supply Fan Wall"
                    frmFanWall.ShowDialog()
                    If frmFanWall.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmFanWall.Dispose()
                    End If

                Case Is = "Ultraviolet Lights"
                    frmUVLights.ShowDialog()
                    If frmUVLights.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmUVLights.Dispose()
                    End If

                Case Is = "Classified Location"
                    frmXP.ShowDialog()
                    If frmXP.Cancelled = True Then
                        dummy = MsgBox("User Cancelled Generation.  Exiting Program.")
                        End
                    Else
                        frmXP.Dispose()
                    End If

                Case Else
                    dummy = MsgBox("Undefined modification type: " & thisitem)
            End Select

            lstSelectedMods.Items.RemoveAt(0)
        Loop

        For i = 0 To ThisUnitFactOpts.Count - 1
            lstFactOpts.Items.Add(ThisUnitFactOpts.Item(i))
        Next i

        If lstRequiredFactoryItems.Items.Count = 0 Then
            lstRequiredFactoryItems.Items.Add("None")
            chkBaseUnitGTG.Checked = True
            chkBaseUnitGTG.Enabled = False
        End If

        tabMain.SelectTab("pgFactOpts")
    End Sub
    Private Sub CoolPerfPrep()
        txtTCap.Text = ThisUnitCoolPerf.TotalCapacity
        txtSCap.Text = ThisUnitCoolPerf.SensibleCapacity
        txtRef.Text = ThisUnitCoolPerf.Refrigerant
        txtEff.Text = ThisUnitCoolPerf.Efficiency
        txtAmbientDB.Text = ThisUnitCoolPerf.AmbientDB
        txtEDB.Text = ThisUnitCoolPerf.EnteringDB
        txtEWB.Text = ThisUnitCoolPerf.EnteringWB
        txtLDB.Text = ThisUnitCoolPerf.LeavingDB
        txtLWB.Text = ThisUnitCoolPerf.LeavingWB
        txtPower.Text = ThisUnitCoolPerf.Power
        txtElev.Text = ThisUnitCoolPerf.Elevation

        If ThisUnit.Family = "DS" Then
            lblRef.Visible = False
            txtRef.Visible = False
            txtRef.Text = "n/a"
            lblAmbientDB.Visible = False
            txtAmbientDB.Visible = False
            txtAmbientDB.Text = "n/a"

        End If


        If ThisUnit.Family = "Series100" Then
            txtYPALEER.Text = ThisUnitCoolPerf.Efficiency
            txtYPALIPLV.Text = ThisUnitCoolPerf.IEER
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dummy As MsgBoxResult
        Dim errmsg As String

        Dim locFamily As String
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim Ver As String
        Dim UPGFile As String = "S:\FUG\Resources\WordTemplates\UPG Submittal Template "
        Dim YPALFile As String = "S:\FUG\Resources\WordTemplates\YPAL Submittal Template "
        Dim YLAAFile As String = "S:\FUG\Resources\WordTemplates\YLAA Submittal Template "
        Dim YVAAFile As String = "S:\FUG\Resources\WordTemplates\YVAA-YCIV Submittal Template "
        Dim BlankFile As String = "S:\FUG\Resources\WordTemplates\Blank Submittal Template "

        Button1.Enabled = False

        locFamily = Me.ThisUnit.Family

        Call SaveTheXMLData()
        If chkWriteStaticAudittoFile.Checked Then Call WriteSFStaticPressureReport()

        Call HandleFlaggedFileMoves()

        If chkSaveinProjDB.Checked Then Call WriteUnitHistory()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT TemplateVer FROM tblWordTemplateVersion WHERE Family='" & locFamily & "'"
        rs.Open(MySQL, con)
        Ver = rs.Fields("TemplateVer").Value

        If My.Settings.UOWordLaunch Then
            Select Case locFamily
                Case Is = "Series5"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Series10"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Series12"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Series20"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Series40"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "SeriesLX"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Series100"
                    YPALFile = YPALFile & Ver & ".dotm"
                    Process.Start(YPALFile)
                Case Is = "YLAA"
                    YLAAFile = YLAAFile & Ver & ".dotm"
                    Process.Start(YLAAFile)
                Case Is = "YVAA"
                    YVAAFile = YVAAFile & Ver & ".dotm"
                    Process.Start(YVAAFile)
                Case Is = "Choice"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Select"
                    UPGFile = UPGFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Is = "Blank"
                    UPGFile = BlankFile & Ver & ".dotm"
                    Process.Start(UPGFile)
                Case Else
                    errmsg = "The unit Family: " & locFamily & " is undefind as we launch a Word template." & vbCrLf
                    errmsg = errmsg & "The .xml file has been written, but you will need to launch" & vbCrLf
                    errmsg = errmsg & "the appropriate Word template yourself."
                    dummy = MsgBox(errmsg, vbOKOnly, "Fisen Unit Generator")
            End Select
        End If

        con.Close()
        rs = Nothing
        con = Nothing

        End 'Main program
    End Sub
    Private Sub WriteUnitHistory()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, verdat, modelnum, modlist, CID As String
        Dim i As Integer


        Dim MySQL As String
        Dim ExistingRecordID As String

        jname = txtProjectName.Text
        unit = txtJobNumber.Text & "-" & txtUnitNumber.Text
        ver = txtUnitVersion.Text
        verdat = dtpUnitDate.Value
        modelnum = txtModelNumber.Text
        CID = Environment.UserName
        modlist = ""
        For i = 0 To ThisUnitMods.Count - 1
            modlist = modlist & ThisUnitMods.Item(i) & " "
        Next
        If ThisUnitCstmMechCodes.Count > 0 Then modlist = modlist & "CstmMech "
        If ThisUnitCstmRefCodes.Count > 0 Then modlist = modlist & "CstmRef "
        If ThisUnitCstmSMCodes.Count > 0 Then modlist = modlist & "CstmSM "
        If ThisUnitCstmHVCodes.Count > 0 Then modlist = modlist & "CstmHV "
        If ThisUnitCstmCtrlCodes.Count > 0 Then modlist = modlist & "CstmCtrl "
        If ThisUnitGenCodes.Count > 0 Then modlist = modlist & "Common "
        Trim(modlist)

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblHistory WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistory SET CreatorID='" & CID & "', VersionDate='" & verdat & "', ModCodes='" & modlist & "' WHERE ID=" & ExistingRecordID

            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistory (JobName, UnitID, Version, VersionDate, ModelNumber, ModCodes, CreatorID) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & verdat & "','" & modelnum & "','" & modlist & "','" & CID & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub HandleFlaggedFileMoves()
        Dim i As Integer

        'First Handle Moving the Unit Drawings
        For i = 0 To ThisUnitUnitDrawings.Count - 1
            If ThisUnitUnitDrawingsAction.Item(i) = "SubmittalFlaggedCopy" Then
                CopyUnitDrawings(ThisUnitUnitDrawings.Item(i))
            End If
        Next
    End Sub
    Private Sub WriteProjectData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("JobNumber")
        lUnitWriter.WriteString(ThisUnit.JobNumber)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ProjectName")
        lUnitWriter.WriteString(ThisUnit.ProjectName)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("PrintedDate")
        lUnitWriter.WriteString(ThisUnit.PrintDate)
        lUnitWriter.WriteEndElement()

    End Sub
    Private Sub WriteYPALOnlyData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("YPALPerformance")

        lUnitWriter.WriteStartElement("UnitSize")
        lUnitWriter.WriteString(ThisYPALPerf.UnitSize)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SoundData")

        lUnitWriter.WriteStartElement("DuctedDischarge")

        lUnitWriter.WriteStartElement("v63")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v125")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v250")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v500")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v1k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v2k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v4k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v8k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("dBA")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedDischargePWL(8))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'DuctedDischarge

        lUnitWriter.WriteStartElement("DuctedInlet")

        lUnitWriter.WriteStartElement("v63")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v125")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v250")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v500")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v1k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v2k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v4k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v8k")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("dBA")
        lUnitWriter.WriteString(ThisYPALPerf.DuctedInletPWL(8))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'DuctedInlet

        lUnitWriter.WriteStartElement("Radiated")

        lUnitWriter.WriteStartElement("v63")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v125")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v250")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v500")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v1k")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v2k")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v4k")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("v8k")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("dBA")
        lUnitWriter.WriteString(ThisYPALPerf.RadiatedPWL(8))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'Radiated



        lUnitWriter.WriteEndElement() 'SoundData


        lUnitWriter.WriteEndElement() 'YPALPerformance
    End Sub

    Private Sub WriteBaseUnitData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("Brand")
        Select Case cmbBrand.Text
            Case Is = "JCI"
                lUnitWriter.WriteString("JCI")
            Case Is = "York"
                lUnitWriter.WriteString("York")
            Case Is = "TMP"
                lUnitWriter.WriteString("TempMaster")
            Case Is = "FRJ"
                lUnitWriter.WriteString("Fraser-Johnston")
            Case Is = "LUX"
                lUnitWriter.WriteString("Luxaire")
            Case Is = "Gua"
                lUnitWriter.WriteString("Guardian")
        End Select

        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Kingdom")
        lUnitWriter.WriteString(ThisUnit.Kingdom)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Family")
        lUnitWriter.WriteString(ThisUnit.Family)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FamilyByBrand")
        lUnitWriter.WriteString(ThisUnit.FamilyBrand)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("UnitTag")
        lUnitWriter.WriteString(ThisUnit.uTag)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("UnitNumber")
        lUnitWriter.WriteString(ThisUnit.UnitNumber)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Quantity")
        lUnitWriter.WriteString(ThisUnit.Quantity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("UnitVersion")
        lUnitWriter.WriteString(ThisUnit.Version)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("UnitDate")
        lUnitWriter.WriteString(ThisUnit.UnitDate)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ModelNumber")
        lUnitWriter.WriteString(ThisUnit.ModelNumber)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("BrandModelNumber")
        lUnitWriter.WriteString(ThisUnit.BrandModelNumber)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("NominalTons")
        lUnitWriter.WriteString(ThisUnit.NominalTons)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ContainsXRangeSFan")
        If ThisUnitSFanPerf.XRangeFan Then
            lUnitWriter.WriteString("Yes")
        Else
            lUnitWriter.WriteString("No")
        End If
        lUnitWriter.WriteEndElement() 'Contains Extended Range Fan

        lUnitWriter.WriteStartElement("ContainsXRangeRFan")
        If ThisUnitRXPerf.XRangeFan Then
            lUnitWriter.WriteString("Yes")
        Else
            lUnitWriter.WriteString("No")
        End If
        lUnitWriter.WriteEndElement() 'Contains Extended Range Fan

        lUnitWriter.WriteStartElement("ContainsCstmCoil")
        If ThisUnitCstmCoilPerf.CoilStyle = "None" Then
            lUnitWriter.WriteString("No")
        Else
            lUnitWriter.WriteString("Yes")
        End If
        lUnitWriter.WriteEndElement() 'Contains Custom Coil

        lUnitWriter.WriteStartElement("ContainsERW")
        If ThisUnitERWPerf.ContainsERW = False Then
            lUnitWriter.WriteString("No")
        Else
            lUnitWriter.WriteString("Yes")
        End If
        lUnitWriter.WriteEndElement() 'Contains ERW

        lUnitWriter.WriteStartElement("Notes")
        lUnitWriter.WriteString(ThisUnit.Notes)
        lUnitWriter.WriteEndElement()

        If ThisUnit.Kingdom = "Chiller" Then
            lUnitWriter.WriteStartElement("PIN")

            lUnitWriter.WriteStartElement("PINA")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINA)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINB")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINB)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINC")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINC)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PIND")
            lUnitWriter.WriteString(ThisChillerMainPerf.PIND)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINE")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINE)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINF")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINF)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PING")
            lUnitWriter.WriteString(ThisChillerMainPerf.PING)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINH")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINH)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteStartElement("PINI")
            lUnitWriter.WriteString(ThisChillerMainPerf.PINI)
            lUnitWriter.WriteEndElement() 'PIN

            lUnitWriter.WriteEndElement() 'PIN
        End If

        If ThisUnit.UPGCertifications.Count > 0 Then
            lUnitWriter.WriteStartElement("Certifications")
            For i = 0 To ThisUnit.UPGCertifications.Count - 1
                lUnitWriter.WriteStartElement("Cert")
                lUnitWriter.WriteString(ThisUnit.UPGCertifications.Item(i))
                lUnitWriter.WriteEndElement() 'Cert
            Next i
            lUnitWriter.WriteEndElement() 'Certifications
        End If

        If ThisUnit.Family = "DS" Then
            lUnitWriter.WriteStartElement("DSUnitData")

            lUnitWriter.WriteStartElement("FanSpeed")
            lUnitWriter.WriteString(ThisUnitDS.FanSpeed)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CompressorCount")
            lUnitWriter.WriteString(ThisUnitDS.CompQty)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CompressorSpeed")
            lUnitWriter.WriteString(ThisUnitDS.CompSpeed)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteEndElement() 'End the DSUnitSpecific Data
        End If

    End Sub
    Private Sub WriteHeatingPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("HeatType")
        lUnitWriter.WriteString(ThisUnitHeatPerf.HeatType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ControlStyle")
        lUnitWriter.WriteString(ThisUnitHeatPerf.ControlStyle)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutputCapacity")
        lUnitWriter.WriteString(ThisUnitHeatPerf.OutputCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InputCapacity")
        lUnitWriter.WriteString(ThisUnitHeatPerf.InputCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Airflow")
        lUnitWriter.WriteString(ThisUnitHeatPerf.Airflow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EnteringAirTemp")
        lUnitWriter.WriteString(ThisUnitHeatPerf.EnteringAirTemp)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingAirTemp")
        lUnitWriter.WriteString(ThisUnitHeatPerf.LeavingAirTemp)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DeltaT")
        lUnitWriter.WriteString(ThisUnitHeatPerf.DeltaT)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SteamPressure")
        lUnitWriter.WriteString(ThisUnitHeatPerf.SteamPressure)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("CondensateFlow")
        lUnitWriter.WriteString(ThisUnitHeatPerf.CondensateFlow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("CoilAPD")
        lUnitWriter.WriteString(ThisUnitHeatPerf.CoilAPD)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Fluid")
        lUnitWriter.WriteString(ThisUnitHeatPerf.Fluid)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FluidFlow")
        lUnitWriter.WriteString(ThisUnitHeatPerf.FluidFlow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EnteringFluidTemp")
        lUnitWriter.WriteString(ThisUnitHeatPerf.EntFluidTemp)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingFluidTemp")
        lUnitWriter.WriteString(ThisUnitHeatPerf.LvgFluidTemp)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FluidPressureDrop")
        lUnitWriter.WriteString(ThisUnitHeatPerf.FluidPressureDrop)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("AppliedEHeat")
        lUnitWriter.WriteString(ThisUnitHeatPerf.AppliedEHeat)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("NominalEHeat")
        lUnitWriter.WriteString(ThisUnitHeatPerf.NominalEHeat)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SSE")
        lUnitWriter.WriteString(ThisUnitHeatPerf.SSE)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("GasConsumption")
        lUnitWriter.WriteString(ThisUnitHeatPerf.GasConsumption)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("GasHeatContent")
        lUnitWriter.WriteString(ThisUnitHeatPerf.GasHeatContent)
        lUnitWriter.WriteEndElement()

    End Sub
    Private Sub WriteCoolingPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("TotalCapacity")
        lUnitWriter.WriteString(ThisUnitCoolPerf.TotalCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SensibleCapacity")
        lUnitWriter.WriteString(ThisUnitCoolPerf.SensibleCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Refrigerant")
        lUnitWriter.WriteString(ThisUnitCoolPerf.Refrigerant)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EfficiencyAtARI")
        lUnitWriter.WriteString(ThisUnitCoolPerf.Efficiency)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("AmbientDB")
        lUnitWriter.WriteString(ThisUnitCoolPerf.AmbientDB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EnteringDB")
        lUnitWriter.WriteString(ThisUnitCoolPerf.EnteringDB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EnteringWB")
        lUnitWriter.WriteString(ThisUnitCoolPerf.EnteringWB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingDB")
        lUnitWriter.WriteString(ThisUnitCoolPerf.LeavingDB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingWB")
        lUnitWriter.WriteString(ThisUnitCoolPerf.LeavingWB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Power")
        lUnitWriter.WriteString(ThisUnitCoolPerf.Power)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Elevation")
        lUnitWriter.WriteString(ThisUnitCoolPerf.Elevation)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingDBUnit")
        lUnitWriter.WriteString(ThisUnitCoolPerf.LeavingDBUnit)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LeavingWBUnit")
        lUnitWriter.WriteString(ThisUnitCoolPerf.LeavingWBUnit)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FaceVelocity")
        lUnitWriter.WriteString(ThisUnitCoolPerf.FaceVelocity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("IEER")
        lUnitWriter.WriteString(ThisUnitCoolPerf.IEER)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SuctionP")
        lUnitWriter.WriteString(ThisUnitCoolPerf.SuctionP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SuctionT")
        lUnitWriter.WriteString(ThisUnitCoolPerf.SuctionT)
        lUnitWriter.WriteEndElement()

    End Sub
    Private Sub WriteReheatPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("ControlType")
        lUnitWriter.WriteString(ThisUnitRHPerf.ControlType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("RHCapacity")
        lUnitWriter.WriteString(ThisUnitRHPerf.RHCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Airflow")
        lUnitWriter.WriteString(ThisUnitRHPerf.RHAirflow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EAT")
        lUnitWriter.WriteString(ThisUnitRHPerf.EAT)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LAT")
        lUnitWriter.WriteString(ThisUnitRHPerf.LAT)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DeltaT")
        lUnitWriter.WriteString(ThisUnitRHPerf.DeltaT)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DHCapacity")
        lUnitWriter.WriteString(ThisUnitRHPerf.DHCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("CoilAPD")
        lUnitWriter.WriteString(ThisUnitRHPerf.CoilAPD)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("PipingStyle")
        lUnitWriter.WriteString(ThisUnitRHPerf.PipingStyle)
        lUnitWriter.WriteEndElement()

    End Sub
    Private Sub WriteCstmCoilPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("CoilType")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.CoilStyle)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("CoilCapacity")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.ReheatCapacity)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Refrigerant")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.RefType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Airflow")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.CstmCoilAirflow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("RefrigerantPD")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.RefPD)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FluidFlow")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.FluidFlow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("EAT")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.EATDB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LAT")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.LATDB)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DeltaT")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.DeltaT)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletSize")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.InletConn)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletSize")
        lUnitWriter.WriteString(ThisUnitCstmCoilPerf.OutletConn)
        lUnitWriter.WriteEndElement()

    End Sub
    Private Sub WriteSFanPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        Dim i As Integer

        lUnitWriter.WriteStartElement("Airflow")
        lUnitWriter.WriteString(ThisUnitSFanPerf.Airflow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FanText")
        lUnitWriter.WriteString(ThisUnitSFanPerf.FanSelected)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorText")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MotorText)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ESP")
        lUnitWriter.WriteString(ThisUnitSFanPerf.ESP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("TSP")
        lUnitWriter.WriteString(ThisUnitSFanPerf.TSP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("RPM")
        lUnitWriter.WriteString(ThisUnitSFanPerf.RPM)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorHP")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MotorHP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorHPUnit")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MhpUnits)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("BrakeHP")
        lUnitWriter.WriteString(ThisUnitSFanPerf.BrakeHP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("BrakeHPUnit")
        lUnitWriter.WriteString(ThisUnitSFanPerf.BhpUnits)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorFLA")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MFLA)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("kWPower")
        lUnitWriter.WriteString(ThisUnitSFanPerf.kWPower)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DriveType")
        lUnitWriter.WriteString(ThisUnitSFanPerf.DriveType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DuctLocation")
        lUnitWriter.WriteString(ThisUnitSFanPerf.DuctLoc)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MaxFanRPM")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MaxRPM)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL63")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL125")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL250")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL500")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL1k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL2k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL4k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL8k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.OutletPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL63")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL125")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL250")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL500")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL1k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL2k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL4k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL8k")
        lUnitWriter.WriteString(ThisUnitSFanPerf.InletPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletdBW")
        lUnitWriter.WriteString(ThisUnitSFanPerf.Outlet_dBW)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletdBA5")
        lUnitWriter.WriteString(ThisUnitSFanPerf.Outlet_dBA5)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletdBW")
        lUnitWriter.WriteString(ThisUnitSFanPerf.Inlet_dBW)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletdBA5")
        lUnitWriter.WriteString(ThisUnitSFanPerf.Inlet_dBA5)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FanCurvePicture")
        lUnitWriter.WriteString(ThisUnitSFanPerf.FanSelected)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("StaticSummary")
        If ThisUnitSFanPerf.XRangeFan Then
            For i = 0 To ThisUnitSFanPerf.StaticSummaryItem.Count - 2
                lUnitWriter.WriteStartElement("LineItem")
                lUnitWriter.WriteString(ThisUnitSFanPerf.StaticSummaryItem(i))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteStartElement("LineItemSTP")
                lUnitWriter.WriteString(ThisUnitSFanPerf.StaticPDataSTP(i))
                lUnitWriter.WriteEndElement()
                If ThisUnitSFanPerf.StaticPDataATP.Count > 0 Then
                    lUnitWriter.WriteStartElement("LineItemATP")
                    lUnitWriter.WriteString(ThisUnitSFanPerf.StaticPDataATP(i))
                    lUnitWriter.WriteEndElement()
                End If
            Next
        Else
            If ThisUnit.Family = "Series100" Then
                For i = 0 To ThisUnitSFanPerf.StaticNameYpal.Count - 1
                    lUnitWriter.WriteStartElement("StaticItem" & Trim(Str(i)))
                    lUnitWriter.WriteStartElement("StaticItem")
                    lUnitWriter.WriteString(ThisUnitSFanPerf.StaticNameYpal(i))
                    lUnitWriter.WriteEndElement()
                    lUnitWriter.WriteStartElement("StaticData")
                    lUnitWriter.WriteString(ThisUnitSFanPerf.StaticDataYpal(i))
                    lUnitWriter.WriteEndElement()
                    lUnitWriter.WriteEndElement()
                Next i
            End If
        End If
        lUnitWriter.WriteEndElement()

    End Sub

    Private Sub WriteFFilterPerformance(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("Present")
        If ThisUnitFFilters.HasNewFilters Then
            lUnitWriter.WriteString("True")
        Else
            lUnitWriter.WriteString("False")
        End If
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Filter1")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterQ1)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterSize1)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 1

        lUnitWriter.WriteStartElement("Filter2")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterQ2)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterSize2)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 2

        lUnitWriter.WriteStartElement("Filter3")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterQ3)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterSize3)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 3

        lUnitWriter.WriteStartElement("Filter4")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterQ4)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterSize4)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitFFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 4

        lUnitWriter.WriteStartElement("InitialResistance")
        lUnitWriter.WriteString(ThisUnitFFilters.FAPD)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DFA")
        lUnitWriter.WriteString(ThisUnitFFilters.FDFA)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FinalResistance")
        lUnitWriter.WriteString(Format((Val(ThisUnitFFilters.FAPD) + Val(ThisUnitFFilters.FDFA)), "0.00"))
        lUnitWriter.WriteEndElement()

    End Sub


    Private Sub WriteIFilterPerformance(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("Present")
        If ThisUnitIFilters.HasNewFilters Then
            lUnitWriter.WriteString("True")
        Else
            lUnitWriter.WriteString("False")
        End If
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Filter1")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterQ1)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterSize1)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 1

        lUnitWriter.WriteStartElement("Filter2")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterQ2)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterSize2)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 2

        lUnitWriter.WriteStartElement("Filter3")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterQ3)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterSize3)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 3

        lUnitWriter.WriteStartElement("Filter4")

        lUnitWriter.WriteStartElement("Qty")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterQ4)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Size")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterSize4)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Rating")
        lUnitWriter.WriteString(ThisUnitIFilters.FilterType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'End Filter 4

        lUnitWriter.WriteStartElement("InitialResistance")
        lUnitWriter.WriteString(ThisUnitIFilters.FAPD)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DFA")
        lUnitWriter.WriteString(ThisUnitIFilters.FDFA)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FinalResistance")
        lUnitWriter.WriteString(Format((Val(ThisUnitIFilters.FAPD) + Val(ThisUnitIFilters.FDFA)), "0.00"))
        lUnitWriter.WriteEndElement()

    End Sub

    Private Sub WriteRXPerfData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("FanStyle")
        lUnitWriter.WriteString(ThisUnitRXPerf.FanStyle)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Airflow")
        lUnitWriter.WriteString(ThisUnitRXPerf.Airflow)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FanText")
        lUnitWriter.WriteString(ThisUnitRXPerf.FanSelected)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorText")
        lUnitWriter.WriteString(ThisUnitRXPerf.MotorText)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FanCount")
        lUnitWriter.WriteString(ThisUnitRXPerf.FanCount)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("ESP")
        lUnitWriter.WriteString(ThisUnitRXPerf.ESP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("TSP")
        lUnitWriter.WriteString(ThisUnitRXPerf.TSP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("RPM")
        lUnitWriter.WriteString(ThisUnitRXPerf.RPM)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorHP")
        lUnitWriter.WriteString(ThisUnitRXPerf.MotorHP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorHPUnit")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MhpUnits)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("BrakeHP")
        lUnitWriter.WriteString(ThisUnitRXPerf.BrakeHP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("BrakeHPUnit")
        lUnitWriter.WriteString(ThisUnitSFanPerf.BhpUnits)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MotorFLA")
        lUnitWriter.WriteString(ThisUnitSFanPerf.MFLA)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("kWPower")
        lUnitWriter.WriteString(ThisUnitRXPerf.kWPower)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DriveType")
        lUnitWriter.WriteString(ThisUnitRXPerf.DriveType)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("DuctLocation")
        lUnitWriter.WriteString(ThisUnitRXPerf.DuctLoc)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("MaxFanRPM")
        lUnitWriter.WriteString(ThisUnitRXPerf.MaxRPM)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL63")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL125")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL250")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL500")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL1k")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL2k")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL4k")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletPWL8k")
        lUnitWriter.WriteString(ThisUnitRXPerf.OutletPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL63")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(0))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL125")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(1))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL250")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(2))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL500")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(3))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL1k")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(4))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL2k")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(5))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL4k")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(6))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletPWL8k")
        lUnitWriter.WriteString(ThisUnitRXPerf.InletPWL(7))
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletdBW")
        lUnitWriter.WriteString(ThisUnitRXPerf.Outlet_dBW)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OutletdBA5")
        lUnitWriter.WriteString(ThisUnitRXPerf.Outlet_dBA5)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletdBW")
        lUnitWriter.WriteString(ThisUnitRXPerf.Inlet_dBW)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("InletdBA5")
        lUnitWriter.WriteString(ThisUnitRXPerf.Inlet_dBA5)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("FanCurvePicture")
        lUnitWriter.WriteString(ThisUnitRXPerf.FanSelected)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("StaticSummary")
        For i = 0 To ThisUnitRXPerf.StaticSummaryItem.Count - 2
            lUnitWriter.WriteStartElement("LineItem")
            lUnitWriter.WriteString(ThisUnitRXPerf.StaticSummaryItem(i))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("LineItemSTP")
            lUnitWriter.WriteString(ThisUnitRXPerf.StaticPDataSTP(i))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("LineItemATP")
            lUnitWriter.WriteString(ThisUnitRXPerf.StaticPDataATP(i))
            lUnitWriter.WriteEndElement()
        Next
        lUnitWriter.WriteEndElement()
    End Sub
    Private Sub WritePhysicalData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        Dim i As Integer
        Dim ij As Integer

        Dim OldMod As String

        lUnitWriter.WriteStartElement("Length")
        lUnitWriter.WriteString(ThisUnitPhysicalData.Length)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Width")
        lUnitWriter.WriteString(ThisUnitPhysicalData.Width)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Height")
        lUnitWriter.WriteString(ThisUnitPhysicalData.Height)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("OpWeight")
        lUnitWriter.WriteString(ThisUnitPhysicalData.OpWeight)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("RigWeight")
        lUnitWriter.WriteString(ThisUnitPhysicalData.RigWeight)
        lUnitWriter.WriteEndElement()

        If ThisUnit.Kingdom = "Chiller" Then
            lUnitWriter.WriteStartElement("RefCharge")
            lUnitWriter.WriteString(ThisChillerMainPerf.RefrigerantCharge)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("Notes")
            lUnitWriter.WriteString(ThisChillerMainPerf.Notes)
            lUnitWriter.WriteEndElement()

        End If

        lUnitWriter.WriteStartElement("BaseUnitWeight")
        lUnitWriter.WriteString(ThisUnitPhysicalData.BaseUnitWeight)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SFWeight")
        lUnitWriter.WriteString(ThisUnitPhysicalData.SFWeight)
        lUnitWriter.WriteEndElement()

        If ThisUnit.Kingdom = "Chiller" Then
            lUnitWriter.WriteStartElement("PointWeights")
            ij = 1
            For i = 0 To (ThisUnitPhysicalData.PointLoad.Count - 1) Step 2
                lUnitWriter.WriteStartElement("R" & Trim(Str(ij)))
                lUnitWriter.WriteStartElement("XDist")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoadXLoc(i))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteStartElement("YDist")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoadYLoc(i))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteStartElement("Weight")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoad(i))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteEndElement() 'R Whatever

                lUnitWriter.WriteStartElement("L" & Trim(Str(ij)))
                lUnitWriter.WriteStartElement("XDist")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoadXLoc(i + 1))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteStartElement("YDist")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoadYLoc(i + 1))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteStartElement("Weight")
                lUnitWriter.WriteString(ThisUnitPhysicalData.BasePointLoad(i + 1))
                lUnitWriter.WriteEndElement()
                lUnitWriter.WriteEndElement() 'L Whatever
                ij = ij + 1
            Next

        Else
            lUnitWriter.WriteStartElement("PointWeights")
            For i = 0 To ThisUnitPhysicalData.PointLoad.Count - 1
                lUnitWriter.WriteStartElement(Chr(65 + i))
                lUnitWriter.WriteString(ThisUnitPhysicalData.PointLoad(i))
                lUnitWriter.WriteEndElement() 'point A/b/c/
            Next

        End If
        lUnitWriter.WriteEndElement() 'pointweights
        lUnitWriter.WriteStartElement("ModWeights")

        OldMod = "XXX"

        For i = 0 To ThisUnitPhysicalData.ModLoadItem.Count - 1
            lUnitWriter.WriteStartElement(ThisUnitPhysicalData.ModLoadMod(i) & Trim(Str(i)))
            lUnitWriter.WriteStartElement("Name")
            lUnitWriter.WriteString(ThisUnitPhysicalData.ModLoadItem(i))
            lUnitWriter.WriteEndElement() 'Name
            lUnitWriter.WriteStartElement("Mass")
            lUnitWriter.WriteString(ThisUnitPhysicalData.ModLoadMass(i))
            lUnitWriter.WriteEndElement() 'Mass
            lUnitWriter.WriteEndElement() 'ModItem
        Next i

        lUnitWriter.WriteEndElement() 'Mod Weights

        lUnitWriter.WriteStartElement("Clearances")

        lUnitWriter.WriteStartElement("Right")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrRight)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Front")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrFront)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Back")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrBack)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Top")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrTop)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Bottom")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrBottom)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("Left")
        lUnitWriter.WriteString(ThisUnitPhysicalData.ClrLeft)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteEndElement() 'Clearances
    End Sub
    Private Sub WriteControlsElecData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("ControlsCircuits")
        lUnitWriter.WriteStartElement("CommNodes")
        lUnitWriter.WriteString(ThisUnit.CommNodes)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteEndElement() 'Controls Circuits
    End Sub
    Private Sub WriteMCAReport()
        Dim mcareport As System.IO.StreamWriter
        Dim tempfilename As String
        Dim rowcount As Integer
        Dim tempstr As String
        Dim i As Integer

        tempfilename = txtProjectDirectory.Text & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\" & "Submittal Source (Do not Distribute)\Submittal Design\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - " & "MCA Calculation Report " & Ver2FileVer(txtUnitVersion.Text) & ".txt"

        mcareport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
        mcareport.WriteLine("MCA Calculation Report")
        mcareport.WriteLine(" ")

        mcareport.WriteLine("Commercial Circuit Fisen Added Loads:")
        mcareport.WriteLine(txtElecFisenLoadNotesComm.Text)
        mcareport.WriteLine(" ")
        mcareport.WriteLine("Emergency Circuit Fisen Added Loads:")
        mcareport.WriteLine(txtElecFisenLoadNotesEmer.Text)
        mcareport.WriteLine(" ")

        If optMCAReportNoChange.Checked Then
            mcareport.WriteLine("FISEN MODIFICATIONS HAVE NO IMPACT - VALUE FROM BASE UNIT SELECTION")
            mcareport.WriteLine("Rule:")
            If chkMCANoChangeNo1ALoads.Checked Then
                mcareport.WriteLine("No Loads Over 1.0 Amp Added - NO CHANGE")
            End If
            If chkMCANoChangeOnlyAddVFD.Checked Then
                mcareport.WriteLine("Just add VFD to existing - NO CHANGE")
            End If
            If chkMCANoChangeOnlyAddFieldProvVFD.Checked Then
                mcareport.WriteLine("Just add VFD to Field Provided VFD Unit - NO CHANGE")
            End If
            If chkMCANoChangeOnlyAddSCR.Checked Then
                mcareport.WriteLine("Just add SCR - NO CHANGE")
            End If
            If chkMCANoChangeOnlyAddDigiScroll.Checked Then
                mcareport.WriteLine("Digital Scroll with external overloads - NO CHANGE")
            End If
            If chkMCANoChangeOnlyAddReactors.Checked Then
                mcareport.WriteLine("Just add Input/Output Reactors to Existing VFD - NO CHANGE")
            End If
        End If

        If optMCAReportA.Checked Then
            mcareport.WriteLine("Commercial Circuit")
            mcareport.WriteLine(ThisUnitElecData.CommVolts & " NETWORK")
            rowcount = dgvElecLoads.RowCount
            For i = 0 To rowcount - 1
                If dgvElecLoads.Rows(i).Cells.Item(3).Value Then
                    tempstr = dgvElecLoads.Rows(i).Cells.Item(4).Value & " - " & dgvElecLoads.Rows(i).Cells.Item(7).Value & " - " & dgvElecLoads.Rows(i).Cells.Item(9).Value
                    mcareport.WriteLine(tempstr)
                End If
            Next i
            mcareport.WriteLine(" ")
            mcareport.WriteLine("CALCULATION METHOD: 36.14(a) 1.25*LOAD1 + All other loads")
            mcareport.WriteLine(" ")

            If ThisUnitElecData.EmerCircuit Then
                mcareport.WriteLine("Emergency Circuit")
                mcareport.WriteLine(ThisUnitElecData.EmerVolts & " NETWORK")
                rowcount = dgvElecLoads.RowCount
                For i = 0 To rowcount - 1
                    If dgvElecLoads.Rows(i).Cells.Item(8).Value Then
                        tempstr = dgvElecLoads.Rows(i).Cells.Item(4).Value & " - " & dgvElecLoads.Rows(i).Cells.Item(7).Value & " - " & dgvElecLoads.Rows(i).Cells.Item(9).Value
                        mcareport.WriteLine(tempstr)
                    End If
                Next i
                mcareport.WriteLine(" ")
                mcareport.WriteLine("CALCULATION METHOD: 36.14(a) 1.25*LOAD1 + All other loads")
            End If
        End If

        mcareport.Close()
    End Sub

    Private Sub WriteSFStaticPressureReport()
        Dim SFStaticreport As System.IO.StreamWriter
        Dim tempfilename As String

        tempfilename = txtProjectDirectory.Text & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\" & "Submittal Source (Do not Distribute)\Submittal Design\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - " & "Supply Fan Static Audit Report " & Ver2FileVer(txtUnitVersion.Text) & ".txt"

        SFStaticreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
        SFStaticreport.WriteLine(txtStaticPressureAudit.Text)

        SFStaticreport.Close()
    End Sub

    Private Function FormatStaticLine(strItem As String, strSTP As String, strATP As String) As String
        Dim FinalLineItem As String

        FinalLineItem = strItem.PadRight(40) & strSTP.PadRight(10) & strATP.PadRight(10)

        Return FinalLineItem
    End Function

    Private Sub WriteDesignNotesReport()
        Dim designreport As System.IO.StreamWriter
        Dim tempfilename As String

        tempfilename = txtProjectDirectory.Text & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\" & "Submittal Source (Do not Distribute)\Submittal Design\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - " & "Design Notes Report " & Ver2FileVer(txtUnitVersion.Text) & ".txt"

        designreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
        designreport.WriteLine("Design Notes Report")
        designreport.WriteLine(" ")
        designreport.WriteLine(DesignNotes)
        designreport.WriteLine(" ")
        designreport.Close()

    End Sub

    Private Sub WriteCOPUseReport()
        Dim copreport As System.IO.StreamWriter
        Dim tempfilename As String
        Dim LoadItem, LoadVA As String
        Dim commaloc As Integer
        Dim i As Integer

        tempfilename = txtProjectDirectory.Text & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\" & "Submittal Source (Do not Distribute)\Submittal Design\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - " & "COP Use Report " & Ver2FileVer(txtUnitVersion.Text) & ".txt"

        copreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
        copreport.WriteLine("Powered Convenience Outlet Use Report")
        copreport.WriteLine(" ")
        If ThisUnitElecData.COPLoadsPresent = False Then
            copreport.WriteLine("FISEN MODIFICATIONS HAVE NO IMPACT ON POWERED CONVENIENCE OUTLET USE")
        Else
            copreport.WriteLine("FISEN MODIFICATIONS HAVE THE FOLLOWING IMPACT ON POWERED CONVENIENCE OUTLET USE:")
            For i = 0 To ThisUnitElecData.COPLoad.Count - 1
                commaloc = InStr(ThisUnitElecData.COPLoad(i), ",")
                LoadItem = Mid(ThisUnitElecData.COPLoad(i), 1, commaloc - 1)
                LoadVA = Mid(ThisUnitElecData.COPLoad(i), commaloc + 1)
                copreport.WriteLine("     " & LoadItem & " - " & LoadVA & " VA")
            Next
        End If
        copreport.Close()

    End Sub
    Private Sub WriteElectricalData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)
        Call WriteMCAReport()
        lUnitWriter.WriteStartElement("CommercialCircuit")
        lUnitWriter.WriteStartElement("Voltage")
        lUnitWriter.WriteString(ThisUnitElecData.CommVolts)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Phase")
        lUnitWriter.WriteString(ThisUnitElecData.CommPhase)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Hertz")
        lUnitWriter.WriteString(ThisUnitElecData.CommFreq)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("MCA")
        lUnitWriter.WriteString(ThisUnitElecData.CommMCA)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("MOP")
        lUnitWriter.WriteString(ThisUnitElecData.CommMOP)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Connection")
        If ThisUnitElecData.CommDisconnect Then lUnitWriter.WriteString("NFDisconnect")
        If ThisUnitElecData.CommFused Then lUnitWriter.WriteString("FusedDisconnect")
        If Not ((ThisUnitElecData.CommDisconnect) Or (ThisUnitElecData.CommFused)) Then lUnitWriter.WriteString("MLO")
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Loads")
        Call WriteElecLoads("Commercial", lUnitWriter, lsettings)
        lUnitWriter.WriteEndElement() 'Commercial Commercial Loads

        If ThisUnit.Family = "Series100" Then
            lUnitWriter.WriteStartElement("YPALLoads")

            lUnitWriter.WriteStartElement("CC1A")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC1A)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CC1B")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC1B)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CC2A")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC2A)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CC2B")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC2B)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CC3A")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC3A)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CC3B")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCC3B)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("CFans")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCFans)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("SFan")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadSFan)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("RXFan")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadRXFan)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("Xfmr")
            lUnitWriter.WriteString(ThisUnitElecData.YPALLoadCtrlXfmr)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteEndElement() 'End YPALLoads
        End If

        lUnitWriter.WriteEndElement() 'Commercial Circuit

        lUnitWriter.WriteStartElement("EmergencyCircuit")
        lUnitWriter.WriteStartElement("Voltage")
        lUnitWriter.WriteString(ThisUnitElecData.EmerVolts)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Phase")
        lUnitWriter.WriteString(ThisUnitElecData.EmerPhase)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Hertz")
        lUnitWriter.WriteString(ThisUnitElecData.EmerFreq)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("MCA")
        lUnitWriter.WriteString(ThisUnitElecData.EmerMCA)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("MOP")
        lUnitWriter.WriteString(ThisUnitElecData.EmerMOP)
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Connection")
        If ThisUnitElecData.EmerDisconnect Then lUnitWriter.WriteString("NFDisconnect")
        If ThisUnitElecData.EmerFused Then lUnitWriter.WriteString("FusedDisconnect")
        If Not ((ThisUnitElecData.EmerDisconnect) Or (ThisUnitElecData.EmerFused) Or (Not (ThisUnitElecData.EmerCircuit))) Then lUnitWriter.WriteString("MLO")
        If ThisUnitElecData.EmerCircuit = False Then lUnitWriter.WriteString("None")
        lUnitWriter.WriteEndElement()
        lUnitWriter.WriteStartElement("Loads")
        Call WriteElecLoads("Emergency", lUnitWriter, lsettings)
        lUnitWriter.WriteEndElement() 'Commercial Commercial Loads
        lUnitWriter.WriteEndElement() 'Emergency Circuit
    End Sub
    Private Sub WriteChillerElecData(lUnitWriter As XmlWriter, lsettings As XmlWriterSettings)


        lUnitWriter.WriteStartElement("Circuit1")

        lUnitWriter.WriteStartElement("MCA")
        lUnitWriter.WriteString(ThisUnitElecData.CommMCA)
        lUnitWriter.WriteEndElement()

        If ThisUnit.Family = "YVAA" Then
            lUnitWriter.WriteStartElement("MinFuse")
            lUnitWriter.WriteString(ThisUnitElecData.MinFuse)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("PowerFactor")
            lUnitWriter.WriteString(ThisUnitElecData.PowerFactor)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("ControlkVA")
            lUnitWriter.WriteString(ThisUnitElecData.ControlkVA)
            lUnitWriter.WriteEndElement()

        End If
        If ThisUnit.Family = "YCIV" Then
            lUnitWriter.WriteStartElement("MinFuse")
            lUnitWriter.WriteString(ThisUnitElecData.MinFuse)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("PowerFactor")
            lUnitWriter.WriteString(ThisUnitElecData.PowerFactor)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("ControlkVA")
            lUnitWriter.WriteString(ThisUnitElecData.ControlkVA)
            lUnitWriter.WriteEndElement()

        End If
        If ThisUnit.Family = "YLAA" Then
            lUnitWriter.WriteStartElement("RecFuse")
            lUnitWriter.WriteString(ThisUnitElecData.RecFuse)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("MaxCB")
            lUnitWriter.WriteString(ThisUnitElecData.MaxCB)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("TotalFankW")
            lUnitWriter.WriteString(ThisUnitElecData.TotalFankW)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("TotalWithHydroKitkW")
            lUnitWriter.WriteString(ThisUnitElecData.TotalkWWithHydroKit)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("StarterType")
            lUnitWriter.WriteString("Across the Line")
            lUnitWriter.WriteEndElement()

        End If

        lUnitWriter.WriteStartElement("MOP")
        lUnitWriter.WriteString(ThisUnitElecData.CommMOP)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("SCCR")
        lUnitWriter.WriteString(ThisUnitElecData.SCCR)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("WiresPerPhase")
        lUnitWriter.WriteString(ThisUnitElecData.WiresPerPhase)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("LugSize")
        lUnitWriter.WriteString(ThisUnitElecData.LugSize)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("TotalkW")
        lUnitWriter.WriteString(ThisUnitElecData.TotalkW)
        lUnitWriter.WriteEndElement()

        lUnitWriter.WriteStartElement("TotalCompkW")
        lUnitWriter.WriteString(ThisUnitElecData.CompressorkW)
        lUnitWriter.WriteEndElement()



        lUnitWriter.WriteEndElement() 'Circuit1

        lUnitWriter.WriteStartElement("LoadTable")
        lUnitWriter.WriteStartElement("Ckt1")
        If ThisUnit.Family = "YVAA" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(0))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(0))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(0))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(0))
            lUnitWriter.WriteEndElement() 'FanFLA

            lUnitWriter.WriteStartElement("ControlXMFR")
            lUnitWriter.WriteString(ThisUnitElecData.ControlxmfrFLA)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FisenLoad01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoad01)
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("FisenLoadFLA01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoadFLA01)
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnit.Family = "YCIV" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(0))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(0))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(0))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(0))
            lUnitWriter.WriteEndElement() 'FanFLA

            lUnitWriter.WriteStartElement("ControlXMFR")
            lUnitWriter.WriteString(ThisUnitElecData.ControlxmfrFLA)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FisenLoad01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoad01)
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("FisenLoadFLA01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoadFLA01)
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnit.Family = "YLAA" Then
            lUnitWriter.WriteStartElement("Comp1ARLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(0))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp1BRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(1))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp1CRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(2))
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FanQty")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty(0))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(0))
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("Comp1ALRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(0))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp1BLRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(1))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp1CLRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(2))
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("ControlXMFR")
            lUnitWriter.WriteString(ThisUnitElecData.ControlxmfrFLA)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FisenLoad01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoad01)
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FisenLoadFLA01")
            lUnitWriter.WriteString(ThisUnitElecData.FisenLoadFLA01)
            lUnitWriter.WriteEndElement()
        End If
        lUnitWriter.WriteEndElement() 'Ckt1

        lUnitWriter.WriteStartElement("Ckt2")
        If ThisUnit.Family = "YVAA" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(1))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(1))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(1))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(1))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        If ThisUnit.Family = "YCIV" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(1))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(1))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(1))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(1))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        If ThisUnit.Family = "YLAA" Then
            lUnitWriter.WriteStartElement("Comp2ARLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(3))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp2BRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(4))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp2CRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(5))
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("FanQty")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty(1))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(1))
            lUnitWriter.WriteEndElement()

            lUnitWriter.WriteStartElement("Comp2ALRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(3))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp2BLRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(4))
            lUnitWriter.WriteEndElement()
            lUnitWriter.WriteStartElement("Comp2CLRA")
            lUnitWriter.WriteString(ThisUnitElecData.CompLRA.Item(5))
            lUnitWriter.WriteEndElement()

        End If
        lUnitWriter.WriteEndElement() 'Ckt2

        lUnitWriter.WriteStartElement("Ckt3")
        If ThisUnit.Family = "YVAA" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(2))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(2))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(2))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(2))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        If ThisUnit.Family = "YCIV" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(2))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(2))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(2))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(2))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        lUnitWriter.WriteEndElement() 'Ckt3

        lUnitWriter.WriteStartElement("Ckt4")
        If ThisUnit.Family = "YVAA" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(3))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(3))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(3))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(3))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        If ThisUnit.Family = "YCIV" Then
            lUnitWriter.WriteStartElement("CompkW")
            lUnitWriter.WriteString(ThisUnitElecData.CompkW.Item(3))
            lUnitWriter.WriteEndElement() 'CompkW
            lUnitWriter.WriteStartElement("CompRLA")
            lUnitWriter.WriteString(ThisUnitElecData.CompRLA.Item(3))
            lUnitWriter.WriteEndElement() 'CompRLA
            lUnitWriter.WriteStartElement("FanQuantity")
            lUnitWriter.WriteString(ThisUnitElecData.FanQty.Item(3))
            lUnitWriter.WriteEndElement() 'FanQty
            lUnitWriter.WriteStartElement("FanFLA")
            lUnitWriter.WriteString(ThisUnitElecData.FanFLAeach.Item(3))
            lUnitWriter.WriteEndElement() 'FanFLA
        End If
        lUnitWriter.WriteEndElement() 'Ckt3

        lUnitWriter.WriteEndElement() 'LoadTable

    End Sub

    Private Sub WriteElecLoads(Circuit As String, locUnitWriter As XmlWriter, locsettings As XmlWriterSettings)
        Dim rowcount As Integer
        Dim i As Integer
        Dim ThisLoad As Boolean

        rowcount = 0

        If Not (chkUseCustomMCA.Checked) Then
            locUnitWriter.WriteStartElement("Load")
            locUnitWriter.WriteStartElement("Qty")
            locUnitWriter.WriteString("-")
            locUnitWriter.WriteEndElement() 'Qty
            locUnitWriter.WriteStartElement("Item")
            locUnitWriter.WriteString("NO CHANGE")
            locUnitWriter.WriteEndElement() 'Item
            locUnitWriter.WriteStartElement("Volts")
            locUnitWriter.WriteString("-")
            locUnitWriter.WriteEndElement() 'Volts
            locUnitWriter.WriteStartElement("HP")
            locUnitWriter.WriteString("-")
            locUnitWriter.WriteEndElement() 'HP
            locUnitWriter.WriteStartElement("FLA")
            locUnitWriter.WriteString("-")
            locUnitWriter.WriteEndElement() 'FLA
            locUnitWriter.WriteEndElement() 'Load

        Else
            rowcount = dgvElecLoads.RowCount
            For i = 0 To rowcount - 1
                ThisLoad = dgvElecLoads.Rows(i).Cells.Item(3).Value
                If ((Circuit = "Commercial") And ThisLoad) Or ((Circuit = "Emergency") And Not (ThisLoad)) Then
                    locUnitWriter.WriteStartElement("Load")
                    locUnitWriter.WriteStartElement("Qty")
                    locUnitWriter.WriteString("1")
                    locUnitWriter.WriteEndElement() 'Qty
                    locUnitWriter.WriteStartElement("Item")
                    locUnitWriter.WriteString(dgvElecLoads.Rows(i).Cells.Item(4).Value)
                    locUnitWriter.WriteEndElement() 'Item
                    locUnitWriter.WriteStartElement("Volts")
                    locUnitWriter.WriteString(dgvElecLoads.Rows(i).Cells.Item(5).Value)
                    locUnitWriter.WriteEndElement() 'Volts
                    locUnitWriter.WriteStartElement("HP")
                    locUnitWriter.WriteString(dgvElecLoads.Rows(i).Cells.Item(6).Value)
                    locUnitWriter.WriteEndElement() 'HP
                    locUnitWriter.WriteStartElement("FLA")
                    locUnitWriter.WriteString(dgvElecLoads.Rows(i).Cells.Item(7).Value)
                    locUnitWriter.WriteEndElement() 'FLA
                    locUnitWriter.WriteEndElement() 'Load
                End If
            Next i
        End If
    End Sub

    Private Sub SaveTheXMLData()
        Dim myXMLSettings As New XmlWriterSettings
        Dim UnitWriter As XmlWriter
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim prefix As String
        Dim dummy As MsgBoxResult
        Dim TargetPath As String

        Dim GenGen As Boolean
        GenGen = False

        myXMLSettings.Indent = True
        myXMLSettings.NewLineOnAttributes = True

        TargetPath = txtProjectDirectory.Text
        TargetPath = TargetPath & Trim(ThisUnit.JobNumber) & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\" & Trim(ThisUnit.JobNumber) & "-" & ThisUnit.UnitNumber & " - FUG-" & ThisUnit.Kingdom & "_" & Ver2FileVer(txtUnitVersion.Text) & ".xml"
        Clipboard.SetText("""" & TargetPath & """")

        UnitWriter = XmlWriter.Create(TargetPath, myXMLSettings)

        UnitWriter.WriteComment("Fisen Unit Definition File")

        UnitWriter.WriteStartElement("FisenProject")
        UnitWriter.WriteString("Fisen Custom Units")

        UnitWriter.WriteStartElement("ProjectData")
        Call WriteProjectData(UnitWriter, myXMLSettings)
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("Units")

        i = 1
        UnitWriter.WriteStartElement("Unit")
        UnitWriter.WriteAttributeString("ID", Format(i, "00"))

        UnitWriter.WriteStartElement("Kingdom")
        UnitWriter.WriteString(ThisUnit.Kingdom)
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("BaseUnitData")
        Call WriteBaseUnitData(UnitWriter, myXMLSettings)
        UnitWriter.WriteEndElement() 'ends base unit data

        Select Case ThisUnit.Kingdom
            Case Is = "Chiller"
                Call WriteChillerPerformance(UnitWriter, myXMLSettings)
            Case Is = "RTU"
                If ThisUnit.Family = "Series100" Then Call WriteYPALOnlyData(UnitWriter, myXMLSettings)
                Call WriteRTUPerformance(UnitWriter, myXMLSettings)
            Case Is = "Misc"
                If ThisUnit.Family = "Series20ODSplit" Then
                    Call WriteODSplitPerformance(UnitWriter, myXMLSettings)
                End If
            Case Else
                dummy = MsgBox("Unknown Kingdom In SaveTheXMLData")
        End Select

        UnitWriter.WriteStartElement("FactoryInstalledOptions")
        For j = 0 To ThisUnitFactOpts.Count - 1
            UnitWriter.WriteStartElement("FIOP")
            UnitWriter.WriteString(ThisUnitFactOpts.Item(j))
            UnitWriter.WriteEndElement() 'FIOP
        Next j
        UnitWriter.WriteEndElement() ' FactoryInstalledOptions

        UnitWriter.WriteStartElement("FieldInstalledItems")
        For j = 0 To ThisUnitFieldInst.Count - 1
            UnitWriter.WriteStartElement("FieldInst")
            UnitWriter.WriteString(ThisUnitFieldInst.Item(j))
            UnitWriter.WriteEndElement() 'Field Installed
        Next j
        UnitWriter.WriteEndElement() ' FactoryInstalledOptions

        Call WriteWarrTestData(UnitWriter, myXMLSettings)

        UnitWriter.WriteStartElement("UnitDrawingsRqd")
        For j = 0 To ThisUnitUnitDrawings.Count - 1
            UnitWriter.WriteStartElement("WMF")
            UnitWriter.WriteString(ThisUnitUnitDrawings.Item(j))
            UnitWriter.WriteEndElement() 'Unit Drawings
        Next j
        UnitWriter.WriteEndElement() 'Unit Drawings

        UnitWriter.WriteStartElement("HydroDrawingsRqd")
        If ThisUnitHydro.Count = 0 Then
            UnitWriter.WriteStartElement("WMF")
            UnitWriter.WriteString("n/a")
            UnitWriter.WriteEndElement() 'Hydro Drawings
        Else
            For j = 0 To ThisUnitHydro.Count - 1
                UnitWriter.WriteStartElement("WMF")
                UnitWriter.WriteString(ThisUnitHydro.Item(j))
                UnitWriter.WriteEndElement() 'Hydro Drawings
            Next j
        End If
        UnitWriter.WriteStartElement("InletSize")
        UnitWriter.WriteString(ThisUnitHydroData.InletSize)
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("OutletSize")
        UnitWriter.WriteString(ThisUnitHydroData.OutletSize)
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("HWValveSelected")
        If ThisUnitHydroData.HWVPresent = True Then
            UnitWriter.WriteString("Yes")
            UnitWriter.WriteEndElement()
            Call WriteHWVData(UnitWriter, myXMLSettings)
        Else
            UnitWriter.WriteString("No")
            UnitWriter.WriteEndElement()
        End If



        UnitWriter.WriteEndElement() 'Hydro Drawings

        UnitWriter.WriteStartElement("RefrigDrawingsRqd")
        If ThisUnitRefer.Count = 0 Then
            UnitWriter.WriteStartElement("WMF")
            UnitWriter.WriteString("n/a")
            UnitWriter.WriteEndElement() 'Refrigerant Drawings
        Else
            For j = 0 To ThisUnitRefer.Count - 1
                UnitWriter.WriteStartElement("WMF")
                UnitWriter.WriteString(ThisUnitRefer.Item(j))
                UnitWriter.WriteEndElement() 'Refrigerant Drawings
            Next j
        End If
        UnitWriter.WriteStartElement("CULiquidSize")
        If ThisUnitCstmCoilPerf.CoilStyle = "Reclaim Coil - Hot Gas" Then
            UnitWriter.WriteString(ThisUnitCstmCoilPerf.InletConn)
        Else
            UnitWriter.WriteString(ThisUnitRefData.CULiquidLineSize)
        End If
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("CUSuctionSize")
        If ThisUnitCstmCoilPerf.CoilStyle = "Reclaim Coil - Hot Gas" Then
            UnitWriter.WriteString(ThisUnitCstmCoilPerf.OutletConn)
        Else
            UnitWriter.WriteString(ThisUnitRefData.CUSuctionLineSize)
        End If
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("ReferSpecCount")
        UnitWriter.WriteString(Trim(Str(ThisUnitReferSpecs.Count)))
        UnitWriter.WriteEndElement()

        UnitWriter.WriteStartElement("ReferSpecs")
        UnitWriter.WriteString(Trim(Str(ThisUnitReferSpecs.Count)))


        If ThisUnitReferSpecs.Count > 0 Then
            For j = 0 To ThisUnitReferSpecs.Count - 1
                UnitWriter.WriteStartElement("Spec" & Trim(Str(j + 1)))
                UnitWriter.WriteStartElement("Item")
                UnitWriter.WriteString(ThisUnitReferSpecs.Item(j))
                UnitWriter.WriteEndElement() 'ITem

                UnitWriter.WriteStartElement("Tag")
                UnitWriter.WriteString(ThisUnitReferSpecsTag.Item(j))
                UnitWriter.WriteEndElement() 'Tag

                UnitWriter.WriteEndElement() 'Spec
            Next j
        End If

        UnitWriter.WriteEndElement() ' Refer Spec list

        UnitWriter.WriteStartElement("CoilType")
        UnitWriter.WriteString(ThisUnitCstmCoilPerf.CoilStyle)
        UnitWriter.WriteEndElement()


        UnitWriter.WriteEndElement() 'Refrig Drawings

        UnitWriter.WriteStartElement("AirFlowDiagramsRqd")
        If ThisUnitAirflow.Count = 0 Then
            UnitWriter.WriteStartElement("WMF")
            UnitWriter.WriteString("n/a")
            UnitWriter.WriteEndElement() 'Airflow Diagrams
        Else
            For j = 0 To ThisUnitAirflow.Count - 1
                UnitWriter.WriteStartElement("WMF")
                UnitWriter.WriteString(ThisUnitAirflow.Item(j))
                UnitWriter.WriteEndElement() 'Airflow Drawings
            Next j
        End If

        UnitWriter.WriteEndElement() 'Airflow Drawings

        UnitWriter.WriteStartElement("EndDevicesRqd")

        UnitWriter.WriteStartElement("ProcessEndDeviceTable")
        If dgvEndDevices.Rows.Count > 1 Then
            UnitWriter.WriteString("Yes")
            UnitWriter.WriteEndElement() 'Process Device Table
            UnitWriter.WriteStartElement("EndDeviceList")
            For i = 0 To dgvEndDevices.Rows.Count - 2
                UnitWriter.WriteStartElement("EndDevice")

                UnitWriter.WriteStartElement("Tag")
                UnitWriter.WriteString(dgvEndDevices.Rows(i).Cells.Item(0).Value)
                UnitWriter.WriteEndElement() 'Tag

                UnitWriter.WriteStartElement("Name")
                UnitWriter.WriteString(dgvEndDevices.Rows(i).Cells.Item(1).Value)
                UnitWriter.WriteEndElement() 'Name

                UnitWriter.WriteStartElement("Type")
                UnitWriter.WriteString(dgvEndDevices.Rows(i).Cells.Item(2).Value)
                UnitWriter.WriteEndElement() 'Type

                UnitWriter.WriteStartElement("IO")
                UnitWriter.WriteString(dgvEndDevices.Rows(i).Cells.Item(3).Value)
                UnitWriter.WriteEndElement() 'IO

                UnitWriter.WriteStartElement("FieldInstalled")
                UnitWriter.WriteString(dgvEndDevices.Rows(i).Cells.Item(4).Value)
                UnitWriter.WriteEndElement() 'Name

                UnitWriter.WriteEndElement() 'End Device
            Next i
            UnitWriter.WriteEndElement() 'End Device List
        Else
            UnitWriter.WriteString("No")
            UnitWriter.WriteEndElement() 'Process Device Table
        End If

        'Now handle moving the end device cutsheets as needed.
        If (chkEDMovetoCutSheets.Checked Or My.Settings.UOMoveCuts2SD) Then Call CopyEndDeviceCusSheets()

        UnitWriter.WriteEndElement() 'EndDevices Required

        UnitWriter.WriteStartElement("UnitModifications")
        Call WriteDesignNotesReport()
        k = 0
        For j = 0 To ThisUnitMods.Count - 1
            UnitWriter.WriteStartElement(ThisUnitMods.Item(j))
            prefix = Mid(ThisUnitCodes.Item(k), 1, 3)
            Do While (prefix = Mid(ThisUnitCodes.Item(k), 1, 3))
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCodes.Item(k))
                UnitWriter.WriteEndElement()
                k = k + 1
                If k > (ThisUnitCodes.Count - 1) Then Exit Do
            Loop
            UnitWriter.WriteEndElement()
        Next j
        If ThisUnitCstmMechCodes.Count > 0 Then
            UnitWriter.WriteStartElement("CstmMech")
            'UnitWriter.WriteStartElement("ModeCode")
            'UnitWriter.WriteString("940000")
            'UnitWriter.WriteEndElement()
            For j = 0 To ThisUnitCstmMechCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCstmMechCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Custom Mechanical Codes
        End If
        If ThisUnitCstmRefCodes.Count > 0 Then
            UnitWriter.WriteStartElement("CstmRef")
            'UnitWriter.WriteStartElement("ModeCode")
            'UnitWriter.WriteString("970000")
            'UnitWriter.WriteEndElement()
            For j = 0 To ThisUnitCstmRefCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCstmRefCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Custom Refrigeration Codes
        End If
        If ThisUnitCstmSMCodes.Count > 0 Then
            UnitWriter.WriteStartElement("CstmSM")
            'UnitWriter.WriteStartElement("ModeCode")
            'UnitWriter.WriteString("990000")
            'UnitWriter.WriteEndElement()
            For j = 0 To ThisUnitCstmSMCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCstmSMCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Custom Refrigeration Codes
        End If
        If ThisUnitCstmHVCodes.Count > 0 Then
            UnitWriter.WriteStartElement("CstmHV")
            'UnitWriter.WriteStartElement("ModeCode")
            'UnitWriter.WriteString("920000")
            'UnitWriter.WriteEndElement()
            For j = 0 To ThisUnitCstmHVCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCstmHVCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Custom High Voltage Codes
        End If
        If ThisUnitCstmCtrlCodes.Count > 0 Then
            UnitWriter.WriteStartElement("CstmCtrl")
            'UnitWriter.WriteStartElement("ModeCode")
            'UnitWriter.WriteString("980000")
            'UnitWriter.WriteEndElement()
            For j = 0 To ThisUnitCstmCtrlCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitCstmCtrlCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Custom High Voltage Codes
        End If
        If ThisUnitGenCodes.Count > 0 Then
            UnitWriter.WriteStartElement("Common")
            For j = 0 To ThisUnitGenCodes.Count - 1
                If ThisUnitGenCodes.Item(j) = "960000" Then GenGen = True 'The General Master code is present.
            Next j
            If Not (GenGen) Then
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString("960000")
                UnitWriter.WriteEndElement()
            End If
            For j = 0 To ThisUnitGenCodes.Count - 1
                UnitWriter.WriteStartElement("ModeCode")
                UnitWriter.WriteString(ThisUnitGenCodes.Item(j))
                UnitWriter.WriteEndElement()
            Next
            UnitWriter.WriteEndElement() 'Common Codes
        End If
        UnitWriter.WriteEndElement() 'Unit modifiactions

        UnitWriter.WriteStartElement("PhysicalData")
        Call WritePhysicalData(UnitWriter, myXMLSettings)
        UnitWriter.WriteEndElement() 'PhysicalData

        UnitWriter.WriteStartElement("ElectricalData")
        Call WriteElectricalData(UnitWriter, myXMLSettings)
        Call WriteControlsElecData(UnitWriter, myXMLSettings)
        If ThisUnit.Kingdom = "Chiller" Then
            UnitWriter.WriteStartElement("ChillerElectricalData")
            Call WriteChillerElecData(UnitWriter, myXMLSettings)
            UnitWriter.WriteEndElement()

        End If
        UnitWriter.WriteEndElement() 'Electrical Data

        UnitWriter.WriteStartElement("PipePackageData")

        If PipePkgDefined Then
            UnitWriter.WriteStartElement("PipePackagePresent")
            UnitWriter.WriteString("Yes")
            UnitWriter.WriteEndElement()

            Call WriteSpecialitiesData(UnitWriter, myXMLSettings)
            Call WriteValveData(UnitWriter, myXMLSettings)
        Else
            UnitWriter.WriteStartElement("PipePackagePresent")
            UnitWriter.WriteString("No")
            UnitWriter.WriteEndElement()
        End If

        UnitWriter.WriteEndElement() 'PipePkg Data

        UnitWriter.WriteStartElement("ERWData")

        If ERWDefined Then
            UnitWriter.WriteStartElement("ERWPresent")
            UnitWriter.WriteString("Yes")
            UnitWriter.WriteEndElement()

            Call WriteERWData(UnitWriter, myXMLSettings)
        Else
            UnitWriter.WriteStartElement("ERWPresent")
            UnitWriter.WriteString("No")
            UnitWriter.WriteEndElement()
        End If

        UnitWriter.WriteEndElement() 'PipePkg Data






        UnitWriter.WriteEndElement() 'Unit XX

        UnitWriter.WriteEndElement() 'Units
        UnitWriter.WriteEndElement() 'Fisen Project
        UnitWriter.WriteEndDocument()
        UnitWriter.Close()

        UnitWriter = Nothing

    End Sub
    Private Sub WriteHWVData(xUnitWriter As XmlWriter, xsettings As XmlWriterSettings)
        xUnitWriter.WriteStartElement("HWValve")

        xUnitWriter.WriteStartElement("Tag")
        xUnitWriter.WriteString(ThisUnitHydroData.HWVTag)
        xUnitWriter.WriteEndElement()

        xUnitWriter.WriteStartElement("Description")
        xUnitWriter.WriteString(ThisUnitHydroData.HWVDescription)
        xUnitWriter.WriteEndElement()

        xUnitWriter.WriteStartElement("Size")
        xUnitWriter.WriteString(ThisUnitHydroData.HWVSize)
        xUnitWriter.WriteEndElement()

        xUnitWriter.WriteStartElement("Type")
        xUnitWriter.WriteString(ThisUnitHydroData.HWVType)
        xUnitWriter.WriteEndElement()

        xUnitWriter.WriteStartElement("MFGPartNo")
        xUnitWriter.WriteString(ThisUnitHydroData.HWVMPN)
        xUnitWriter.WriteEndElement()

        xUnitWriter.WriteEndElement() 'HWValve
    End Sub
    Private Sub WriteERWData(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("StaticTable")

        lUnitWriter.WriteStartElement("SFanOAHood")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticOAHood)
        lUnitWriter.WriteEndElement() 'OA Hood

        lUnitWriter.WriteStartElement("SFanMetalFilt")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticMetalFilt)
        lUnitWriter.WriteEndElement() 'Metal Filt

        lUnitWriter.WriteStartElement("SFanOADamp")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticOADamp)
        lUnitWriter.WriteEndElement() 'OADamp

        lUnitWriter.WriteStartElement("SFanOAFilt")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticOAFilt)
        lUnitWriter.WriteEndElement() 'OAFilt

        lUnitWriter.WriteStartElement("SFanERW")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticERW)
        lUnitWriter.WriteEndElement() 'ERW

        lUnitWriter.WriteStartElement("SFanTrans")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticTrans)
        lUnitWriter.WriteEndElement() 'Trans

        lUnitWriter.WriteStartElement("SFanCabFX")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticCabFX)
        lUnitWriter.WriteEndElement() 'CabFX

        lUnitWriter.WriteStartElement("SFanTotal")
        lUnitWriter.WriteString(ThisUnitERWPerf.SFStaticTotal)
        lUnitWriter.WriteEndElement() 'Total

        lUnitWriter.WriteStartElement("RXFanRAOpening")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticRAOpening)
        lUnitWriter.WriteEndElement() 'RA Opening

        lUnitWriter.WriteStartElement("RXFanSafetyGrate")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticSafetyGrate)
        lUnitWriter.WriteEndElement() 'Safety Grate

        lUnitWriter.WriteStartElement("RXFanRAFilt")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticRAFilt)
        lUnitWriter.WriteEndElement() 'RA Filt

        lUnitWriter.WriteStartElement("RXFanERW")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticERW)
        lUnitWriter.WriteEndElement() 'ERW

        lUnitWriter.WriteStartElement("RXFanHWCloth")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticHWCloth)
        lUnitWriter.WriteEndElement() 'HWCloth

        lUnitWriter.WriteStartElement("RXFanReliefDamp")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticReliefDamp)
        lUnitWriter.WriteEndElement() 'Relief Damper

        lUnitWriter.WriteStartElement("RXFanReliefHood")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticReliefHood)
        lUnitWriter.WriteEndElement() 'Relief Hood

        lUnitWriter.WriteStartElement("RXFanTrans")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticTrans)
        lUnitWriter.WriteEndElement() 'Trans

        lUnitWriter.WriteStartElement("RXFanCabFX")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticCabFX)
        lUnitWriter.WriteEndElement() 'CabFX

        lUnitWriter.WriteStartElement("RXFanTotal")
        lUnitWriter.WriteString(ThisUnitERWPerf.RXFStaticTotal)
        lUnitWriter.WriteEndElement() 'Total

        lUnitWriter.WriteEndElement() 'Static Table

        lUnitWriter.WriteStartElement("ConditionsTable")

        lUnitWriter.WriteStartElement("SupplyAFSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.SupplyAFSummer1)
        lUnitWriter.WriteEndElement() 'Supply Airflow Summer 1

        lUnitWriter.WriteStartElement("OutdoorAFSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OAAFSummer1)
        lUnitWriter.WriteEndElement() 'Outdoor Air Flow Summer 1

        lUnitWriter.WriteStartElement("OATempdbSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATdbSummer1)
        lUnitWriter.WriteEndElement() 'OAT db Summer 1

        lUnitWriter.WriteStartElement("OATempwbSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATwbSummer1)
        lUnitWriter.WriteEndElement() 'OAT wb Summer 1

        lUnitWriter.WriteStartElement("ReturnAFSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.ReturnAFSummer1)
        lUnitWriter.WriteEndElement() 'Return Airflow Summer 1

        lUnitWriter.WriteStartElement("RATempdbSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATdbSummer1)
        lUnitWriter.WriteEndElement() 'Return Air Temp db Summer 1

        lUnitWriter.WriteStartElement("RATempwbSummer1")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATwbSummer1)
        lUnitWriter.WriteEndElement() 'Return Air Temp wb Summer 1

        lUnitWriter.WriteStartElement("SupplyAFSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.SupplyAFSummer2)
        lUnitWriter.WriteEndElement() 'Supply Airflow Summer 2

        lUnitWriter.WriteStartElement("OutdoorAFSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OAAFSummer2)
        lUnitWriter.WriteEndElement() 'Outdoor Air Flow Summer 2

        lUnitWriter.WriteStartElement("OATempdbSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATdbSummer2)
        lUnitWriter.WriteEndElement() 'OAT db Summer 2

        lUnitWriter.WriteStartElement("OATempwbSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATwbSummer2)
        lUnitWriter.WriteEndElement() 'OAT wb Summer 2

        lUnitWriter.WriteStartElement("ReturnAFSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.ReturnAFSummer2)
        lUnitWriter.WriteEndElement() 'Return Airflow Summer 2

        lUnitWriter.WriteStartElement("RATempdbSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATdbSummer2)
        lUnitWriter.WriteEndElement() 'Return Air Temp db Summer 2

        lUnitWriter.WriteStartElement("RATempwbSummer2")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATwbSummer2)
        lUnitWriter.WriteEndElement() 'Return Air Temp wb Summer 2

        lUnitWriter.WriteStartElement("SupplyAFWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.SupplyAFWinter1)
        lUnitWriter.WriteEndElement() 'Supply Airflow Winter 1

        lUnitWriter.WriteStartElement("OutdoorAFWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OAAFWinter1)
        lUnitWriter.WriteEndElement() 'Outdoor Air Flow Winter 1

        lUnitWriter.WriteStartElement("OATempdbWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATdbWinter1)
        lUnitWriter.WriteEndElement() 'OAT db Winter 1

        lUnitWriter.WriteStartElement("OATempwbWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATwbWinter1)
        lUnitWriter.WriteEndElement() 'OAT wb Winter 1

        lUnitWriter.WriteStartElement("ReturnAFWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.ReturnAFWinter1)
        lUnitWriter.WriteEndElement() 'Return Airflow Winter 1

        lUnitWriter.WriteStartElement("RATempdbWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATdbWinter1)
        lUnitWriter.WriteEndElement() 'Return Air Temp db Winter 1

        lUnitWriter.WriteStartElement("RATempwbWinter1")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATwbWinter1)
        lUnitWriter.WriteEndElement() 'Return Air Temp wb Winter 1

        lUnitWriter.WriteStartElement("SupplyAFWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.SupplyAFWinter2)
        lUnitWriter.WriteEndElement() 'Supply Airflow Winter 2

        lUnitWriter.WriteStartElement("OutdoorAFWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OAAFWinter2)
        lUnitWriter.WriteEndElement() 'Outdoor Air Flow Winter 2

        lUnitWriter.WriteStartElement("OATempdbWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATdbWinter2)
        lUnitWriter.WriteEndElement() 'OAT db Winter 2

        lUnitWriter.WriteStartElement("OATempwbWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATwbWinter2)
        lUnitWriter.WriteEndElement() 'OAT wb Winter 2

        lUnitWriter.WriteStartElement("ReturnAFWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.ReturnAFWinter2)
        lUnitWriter.WriteEndElement() 'Return Airflow Winter 2

        lUnitWriter.WriteStartElement("RATempdbWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATdbWinter2)
        lUnitWriter.WriteEndElement() 'Return Air Temp db Winter 2

        lUnitWriter.WriteStartElement("RATempwbWinter2")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATwbWinter2)
        lUnitWriter.WriteEndElement() 'Return Air Temp wb Winter 2

        lUnitWriter.WriteStartElement("SupplyAFWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.SupplyAFWinterFF)
        lUnitWriter.WriteEndElement() 'Supply Airflow WinterFF

        lUnitWriter.WriteStartElement("OutdoorAFWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.OAAFWinterFF)
        lUnitWriter.WriteEndElement() 'Outdoor Air Flow WinterFF

        lUnitWriter.WriteStartElement("OATempdbWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATdbWinterFF)
        lUnitWriter.WriteEndElement() 'OAT db WinterFF

        lUnitWriter.WriteStartElement("OATempwbWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.OATwbWinterFF)
        lUnitWriter.WriteEndElement() 'OAT wb WinterFF

        lUnitWriter.WriteStartElement("ReturnAFWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.ReturnAFWinterFF)
        lUnitWriter.WriteEndElement() 'Return Airflow WinterFF

        lUnitWriter.WriteStartElement("RATempdbWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATdbWinterFF)
        lUnitWriter.WriteEndElement() 'Return Air Temp db WinterFF

        lUnitWriter.WriteStartElement("RATempwbWinterFF")
        lUnitWriter.WriteString(ThisUnitERWPerf.RATwbWinterFF)
        lUnitWriter.WriteEndElement() 'Return Air Temp wb WinterFF

        lUnitWriter.WriteEndElement() 'Conditions Table

        Call WriteERWPerformanceTable(lUnitWriter)
        Call WriteERWMixingTable(lUnitWriter, lmyXMLSettings)

    End Sub
    Private Sub WriteERWPerformanceTable(lUW As XmlWriter)
        lUW.WriteStartElement("PerformanceTable")

        lUW.WriteStartElement("SupplyAirAirFlowS1")
        lUW.WriteString(ThisUnitERWPerf.PerfSAAFlowS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempdbS1")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempdbS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempwbS1")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempwbS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempdbS1")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempdbS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempwbS1")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempwbS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirAirFlowS1")
        lUW.WriteString(ThisUnitERWPerf.PerfXAAFlowS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SensibleEfficiencyS1")
        lUW.WriteString(ThisUnitERWPerf.PerfSensEffS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("LatentEfficiencyS1")
        lUW.WriteString(ThisUnitERWPerf.PerfLatEffS1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("TotalEfficiencyS1")
        lUW.WriteString(ThisUnitERWPerf.PerfTotEffS1)
        lUW.WriteEndElement()

        '********
        lUW.WriteStartElement("SupplyAirAirFlowS2")
        lUW.WriteString(ThisUnitERWPerf.PerfSAAFlowS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempdbS2")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempdbS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempwbS2")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempwbS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempdbS2")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempdbS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempwbS2")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempwbS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirAirFlowS2")
        lUW.WriteString(ThisUnitERWPerf.PerfXAAFlowS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SensibleEfficiencyS2")
        lUW.WriteString(ThisUnitERWPerf.PerfSensEffS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("LatentEfficiencyS2")
        lUW.WriteString(ThisUnitERWPerf.PerfLatEffS2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("TotalEfficiencyS2")
        lUW.WriteString(ThisUnitERWPerf.PerfTotEffS2)
        lUW.WriteEndElement()

        '**********
        lUW.WriteStartElement("SupplyAirAirFlowW1")
        lUW.WriteString(ThisUnitERWPerf.PerfSAAFlowW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempdbW1")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempdbW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempwbW1")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempwbW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempdbW1")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempdbW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempwbW1")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempwbW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirAirFlowW1")
        lUW.WriteString(ThisUnitERWPerf.PerfXAAFlowW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SensibleEfficiencyW1")
        lUW.WriteString(ThisUnitERWPerf.PerfSensEffW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("LatentEfficiencyW1")
        lUW.WriteString(ThisUnitERWPerf.PerfLatEffW1)
        lUW.WriteEndElement()

        lUW.WriteStartElement("TotalEfficiencyW1")
        lUW.WriteString(ThisUnitERWPerf.PerfTotEffW1)
        lUW.WriteEndElement()

        '**********
        lUW.WriteStartElement("SupplyAirAirFlowW2")
        lUW.WriteString(ThisUnitERWPerf.PerfSAAFlowW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempdbW2")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempdbW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempwbW2")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempwbW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempdbW2")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempdbW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempwbW2")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempwbW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirAirFlowW2")
        lUW.WriteString(ThisUnitERWPerf.PerfXAAFlowW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SensibleEfficiencyW2")
        lUW.WriteString(ThisUnitERWPerf.PerfSensEffW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("LatentEfficiencyW2")
        lUW.WriteString(ThisUnitERWPerf.PerfLatEffW2)
        lUW.WriteEndElement()

        lUW.WriteStartElement("TotalEfficiencyW2")
        lUW.WriteString(ThisUnitERWPerf.PerfTotEffW2)
        lUW.WriteEndElement()

        '**********
        lUW.WriteStartElement("SupplyAirAirFlowWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfSAAFlowWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempdbWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempdbWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SupplyAirTempwbWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfSATempwbWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempdbWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempdbWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirTempwbWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfXATempwbWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ExhaustAirAirFlowWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfXAAFlowWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("SensibleEfficiencyWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfSensEffWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("LatentEfficiencyWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfLatEffWFF)
        lUW.WriteEndElement()

        lUW.WriteStartElement("TotalEfficiencyWFF")
        lUW.WriteString(ThisUnitERWPerf.PerfTotEffWFF)
        lUW.WriteEndElement()

        lUW.WriteEndElement() 'Performance Table
    End Sub
    Private Sub WriteERWMixingTable(lUW As XmlWriter, lmyXMLSet As XmlWriterSettings)
        lUW.WriteStartElement("MixingTable")

        lUW.WriteStartElement("WheelLeavingFlowS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1WLFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempdbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1WLdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelleavingTempwbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1WLwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirFlowS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1RAFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempdbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1RAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempwbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1RAwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirFlowS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1MixFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempdbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1MAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempwbS1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS1MAwb)
        lUW.WriteEndElement()

        '********
        lUW.WriteStartElement("WheelLeavingFlowS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2WLFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempdbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2WLdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempwbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2WLwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirFlowS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2RAFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempdbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2RAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempwbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2RAwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirFlowS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2MixFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempdbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2MAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempwbS2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfS2MAwb)
        lUW.WriteEndElement()

        '********
        lUW.WriteStartElement("WheelLeavingFlowW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1WLFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempdbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1WLdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempwbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1WLwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirFlowW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1RAFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempdbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1RAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempwbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1RAwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirFlowW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1MixFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempdbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1MAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempwbW1")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW1MAwb)
        lUW.WriteEndElement()

        '********

        lUW.WriteStartElement("WheelLeavingFlowW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2WLFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempdbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2WLdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempwbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2WLwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirFlowW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2RAFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempdbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2RAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempwbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2RAwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirFlowW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2MixFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempdbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2MAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempwbW2")
        lUW.WriteString(ThisUnitERWPerf.MixPerfW2MAwb)
        lUW.WriteEndElement()

        '********

        lUW.WriteStartElement("WheelLeavingFlowWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFWLFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempdbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFWLdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("WheelLeavingTempwbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFWLwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirFlowWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFRAFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempdbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFRAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("ReturnAirTempwbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFRAwb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirFlowWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFMixFlow)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempdbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFMAdb)
        lUW.WriteEndElement()

        lUW.WriteStartElement("MixedAirTempwbWFF")
        lUW.WriteString(ThisUnitERWPerf.MixPerfWFFMAwb)
        lUW.WriteEndElement()

        '********
        lUW.WriteEndElement() 'Mixing Table
    End Sub
    Private Sub WriteValveData(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("Valves")
        For i = 0 To frmPipePkg.gridValveSchedule.RowCount - 1
            lUnitWriter.WriteStartElement("Valve")

            lUnitWriter.WriteStartElement("Tag")
            lUnitWriter.WriteString(frmPipePkg.gridValveSchedule.Rows.Item(i).Cells.Item("ValveTag").Value)
            lUnitWriter.WriteEndElement() 'tag

            lUnitWriter.WriteStartElement("Description")
            lUnitWriter.WriteString(frmPipePkg.gridValveSchedule.Rows.Item(i).Cells.Item("ValveDescription").Value)
            lUnitWriter.WriteEndElement() 'Description

            lUnitWriter.WriteStartElement("Size")
            lUnitWriter.WriteString(frmPipePkg.gridValveSchedule.Rows.Item(i).Cells.Item("ValveSize").Value)
            lUnitWriter.WriteEndElement() 'Size

            lUnitWriter.WriteStartElement("Type")
            lUnitWriter.WriteString(frmPipePkg.gridValveSchedule.Rows.Item(i).Cells.Item("ValveType").Value)
            lUnitWriter.WriteEndElement() 'Type

            lUnitWriter.WriteStartElement("Style")
            lUnitWriter.WriteString(frmPipePkg.gridValveSchedule.Rows.Item(i).Cells.Item("ValveStyle").Value)
            lUnitWriter.WriteEndElement() 'Style

            lUnitWriter.WriteEndElement() 'Valve
        Next i
        lUnitWriter.WriteEndElement() 'Valves
    End Sub
    Private Sub WriteSpecialitiesData(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("Spectialties")
        For i = 0 To frmPipePkg.gridSepecialties.RowCount - 1
            lUnitWriter.WriteStartElement("Spectialty")

            lUnitWriter.WriteStartElement("Tag")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("SpecTag").Value)
            lUnitWriter.WriteEndElement() 'tag

            lUnitWriter.WriteStartElement("Item")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("Item").Value)
            lUnitWriter.WriteEndElement() 'item

            lUnitWriter.WriteStartElement("Size")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("PipeSize").Value)
            lUnitWriter.WriteEndElement() 'Size

            lUnitWriter.WriteStartElement("Manufacturer")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("Manufacturer").Value)
            lUnitWriter.WriteEndElement() 'Manufacturer

            lUnitWriter.WriteStartElement("InletValve")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("InletVTag").Value)
            lUnitWriter.WriteEndElement() 'Inlet V

            lUnitWriter.WriteStartElement("OutletValve")
            lUnitWriter.WriteString(frmPipePkg.gridSepecialties.Rows.Item(i).Cells.Item("OutVTag").Value)
            lUnitWriter.WriteEndElement() 'Outlet v

            lUnitWriter.WriteEndElement() 'Spectialty
        Next i
        lUnitWriter.WriteEndElement() 'Spectialties
    End Sub

    Private Sub WriteWarrTestData(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)


        lUnitWriter.WriteStartElement("WarrantyTestingData")

        If ThisUnitWarrTest.QA = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Quality Assurance Inspection")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.AirflowTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Airflow Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.CoilTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Coil Pressure Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.CtrlTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Electrical Controls Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.MotorTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Electric Motor Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.EHeatTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Electric Heat Run Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.GasTrainTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Gas Train Run Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.GHeatTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Gas Heat Run Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.HydroPress = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Hydronic Pressure Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.RefTest = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Refrigeration Run Test")
            lUnitWriter.WriteEndElement()
        End If
        If ThisUnitWarrTest.RefInsp = True Then
            lUnitWriter.WriteStartElement("WarrText")
            lUnitWriter.WriteString("Refrigeration System Inspection")
            lUnitWriter.WriteEndElement()
        End If
        lUnitWriter.WriteStartElement("WarrPeriod")
        If opt1YrParts.Checked = True Then lUnitWriter.WriteString("1 Year Parts Only")
        If opt5YrParts.Checked = True Then lUnitWriter.WriteString("1 Year Labor")
        If opt1YrLabor.Checked = True Then lUnitWriter.WriteString("5 Year Parts Only")
        If opt5YrLabor.Checked = True Then lUnitWriter.WriteString("5 Year Labor")
        lUnitWriter.WriteEndElement() 'WarrPeriod

        lUnitWriter.WriteStartElement("WarrComps")
        lUnitWriter.WriteString(ThisUnitWarrTest.CompWarr)
        lUnitWriter.WriteEndElement() 'Compressor Elements

        lUnitWriter.WriteStartElement("WarrHX")
        lUnitWriter.WriteString(ThisUnitWarrTest.HXWarr)
        lUnitWriter.WriteEndElement() 'Heat Exchangers

        lUnitWriter.WriteStartElement("Note4")
        lUnitWriter.WriteString(ThisUnitWarrTest.Note4)
        lUnitWriter.WriteEndElement() 'Note4

        lUnitWriter.WriteEndElement() 'ends warranty and testing info


    End Sub
    Private Sub WriteChillerPerformance(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)

        lUnitWriter.WriteStartElement("EvaporatorData")
        Call WriteChillerEvapData(lUnitWriter, lmyXMLSettings)

        lUnitWriter.WriteEndElement() 'Evaporator Data

        lUnitWriter.WriteStartElement("CondenserData")
        Call WriteChillerCondenserData(lUnitWriter, lmyXMLSettings)

        lUnitWriter.WriteEndElement() 'Condenser Data

        lUnitWriter.WriteStartElement("PerformanceData")
        Call WriteChillerPerformanceData(lUnitWriter, lmyXMLSettings)

        lUnitWriter.WriteEndElement() 'Performance Data

        lUnitWriter.WriteStartElement("SoundData")
        Call WriteChillerSoundData(lUnitWriter, lmyXMLSettings)

        lUnitWriter.WriteEndElement() 'Performance Data


    End Sub
    Private Sub WriteChillerEvapData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        zUnitWriter.WriteStartElement("EWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.EWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("LWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.LWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Flow")
        zUnitWriter.WriteString(ThisChillerMainPerf.Flow)
        zUnitWriter.WriteEndElement()

        If ThisUnit.Family = "YLAA" Then
            zUnitWriter.WriteStartElement("EvapPD")
            zUnitWriter.WriteString(ThisChillerMainPerf.EvapPD)
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("StrainerPD")
            zUnitWriter.WriteString(ThisChillerMainPerf.StrainerPD)
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("ExtKitPD")
            zUnitWriter.WriteString(ThisChillerMainPerf.ExtKitPD)
            zUnitWriter.WriteEndElement()
        End If

        If ThisUnit.Family = "YVAA" Then
            zUnitWriter.WriteStartElement("NumPasses")
            zUnitWriter.WriteString(ThisChillerMainPerf.NumPass)
            zUnitWriter.WriteEndElement()
        End If

        If ThisUnit.Family = "YCIV" Then
            zUnitWriter.WriteStartElement("NumPasses")
            zUnitWriter.WriteString(ThisChillerMainPerf.NumPass)
            zUnitWriter.WriteEndElement()
        End If

        zUnitWriter.WriteStartElement("TPD")
        zUnitWriter.WriteString(ThisChillerMainPerf.FPD)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Fluid")
        zUnitWriter.WriteString(ThisChillerMainPerf.Fluid)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Percent")
        zUnitWriter.WriteString(ThisChillerMainPerf.FluidPercent)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("FoulFactor")
        zUnitWriter.WriteString(ThisChillerMainPerf.FoulingFactor)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("FluidVol")
        zUnitWriter.WriteString(ThisChillerMainPerf.EvapVolume)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MinFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MaxFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MaxFlow)
        zUnitWriter.WriteEndElement()
    End Sub

    Private Sub WriteChillerCondenserData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.Ambient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Altitude")
        zUnitWriter.WriteString(ThisChillerMainPerf.Altitude)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AmbientMin")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinAmbient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("CompType")
        zUnitWriter.WriteString(ThisChillerMainPerf.CompType)
        zUnitWriter.WriteEndElement()
    End Sub

    Private Sub WriteChillerSoundData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        Dim i As Integer

        If ThisUnit.Family = "YLAA" Then
            For i = 1 To 6
                zUnitWriter.WriteStartElement("Load" & Trim(Str(i)))

                zUnitWriter.WriteStartElement("Ambient")
                zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v63")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v125")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v250")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v500")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v1k")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v2k")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v4k")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("v8k")
                zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteStartElement("dBA")
                zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(i - 1))
                zUnitWriter.WriteEndElement()

                zUnitWriter.WriteEndElement()
            Next i
        End If


        If ((ThisUnit.Family = "YVAA") Or (ThisUnit.Family = "YCIV")) Then
            zUnitWriter.WriteStartElement("Load100")
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v1k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v2k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v4k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v8k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("dBA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(0))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteEndElement() ' Load100

            zUnitWriter.WriteStartElement("Load75")
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v1k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v2k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v4k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v8k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("dBA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteEndElement() ' Load75

            zUnitWriter.WriteStartElement("Load50")
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v1k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v2k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v4k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v8k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("dBA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(2))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteEndElement() ' Load50

            zUnitWriter.WriteStartElement("Load25")
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v1k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v2k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v4k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("v8k")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("dBA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(3))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteEndElement() ' Load25

        End If

    End Sub
    Private Sub WriteYLAAPartLoadPerformance(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        Dim i As Integer

        For i = 1 To 6
            zUnitWriter.WriteStartElement("Load" & Trim(Str(i)))
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i - 1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("Capacity")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(i - 1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("TotalkW")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(i - 1))
            zUnitWriter.WriteEndElement()

            zUnitWriter.WriteStartElement("Efficiency")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(i - 1))
            zUnitWriter.WriteEndElement()
            zUnitWriter.WriteEndElement() 'Load i
        Next i


    End Sub
    Private Sub WriteYVAAPartLoadPerformance(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        zUnitWriter.WriteStartElement("Load100")
        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(0))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Capacity")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(0))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("TotalkW")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(0))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Efficiency")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(0))
        zUnitWriter.WriteEndElement()
        zUnitWriter.WriteEndElement() ' Load100

        zUnitWriter.WriteStartElement("Load75")
        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(1))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Capacity")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(1))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("TotalkW")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(1))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Efficiency")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(1))
        zUnitWriter.WriteEndElement()
        zUnitWriter.WriteEndElement() ' Load75

        zUnitWriter.WriteStartElement("Load50")
        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(2))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Capacity")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(2))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("TotalkW")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(2))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Efficiency")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(2))
        zUnitWriter.WriteEndElement()
        zUnitWriter.WriteEndElement() ' Load50

        zUnitWriter.WriteStartElement("Load25")
        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(3))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Capacity")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(3))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("TotalkW")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(3))
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Efficiency")
        zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(3))
        zUnitWriter.WriteEndElement()
        zUnitWriter.WriteEndElement() ' Load25
    End Sub

    Private Sub WriteChillerPerformanceData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        zUnitWriter.WriteStartElement("EER")
        zUnitWriter.WriteString(ThisChillerMainPerf.EER)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("IPLV")
        zUnitWriter.WriteString(ThisChillerMainPerf.IPLV)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("NPLV")
        zUnitWriter.WriteString(ThisChillerMainPerf.NPLV)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AuxPerformance")
        If ThisUnit.Family = "YVAA" Then
            Call WriteYVAAPartLoadPerformance(zUnitWriter, zXMLSettings)
        End If
        If ThisUnit.Family = "YCIV" Then
            Call WriteYVAAPartLoadPerformance(zUnitWriter, zXMLSettings)
        End If
        If ThisUnit.Family = "YLAA" Then
            Call WriteYLAAPartLoadPerformance(zUnitWriter, zXMLSettings)
        End If

        zUnitWriter.WriteStartElement("AHRIEWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIEWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRILWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRILWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRITPD")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRITPD)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIFluid")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIFluid)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIFoulFactor")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIFoulFactor)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIVolume")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIVolume)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIAmbient")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIAmbient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIAltitude")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIAltitude)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRIEER")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRIEER)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRINPLV")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRINPLV)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AHRICoolCap")
        zUnitWriter.WriteString(ThisChillerMainPerf.AHRICoolCap)
        zUnitWriter.WriteEndElement()





        zUnitWriter.WriteEndElement() ' Aux Performance
    End Sub


    Private Sub WriteYZZZUnitData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        Dim i As Integer

        zUnitWriter.WriteStartElement("ElecDesc")
        zUnitWriter.WriteString(ThisChillerMainPerf.Elec)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Refrigerant")
        zUnitWriter.WriteString(ThisChillerMainPerf.Refrigerant)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINA")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINA)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINB")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINB)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINC")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINC)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PIND")
        zUnitWriter.WriteString(ThisChillerMainPerf.PIND)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINE")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINE)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINF")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINF)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PING")
        zUnitWriter.WriteString(ThisChillerMainPerf.PING)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINH")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINH)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINI")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINI)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RigWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.RigWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("OpWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.OpWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RefCharge")
        zUnitWriter.WriteString(ThisChillerMainPerf.RefrigerantCharge)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PartLoadData")
        For i = 0 To ThisChillerMainPerf.PLRStage.Count - 1
            zUnitWriter.WriteStartElement("Stage" & Trim(ThisChillerMainPerf.PLRStage(i)))
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i))
            zUnitWriter.WriteEndElement() 'Ambient
            zUnitWriter.WriteStartElement("Capacity")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(i))
            zUnitWriter.WriteEndElement() 'Capacity
            zUnitWriter.WriteStartElement("TotalkW")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(i))
            zUnitWriter.WriteEndElement() 'TotalkW
            zUnitWriter.WriteStartElement("Efficiency")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(i))
            zUnitWriter.WriteEndElement() 'Efficiency
            zUnitWriter.WriteEndElement() 'Stage i
        Next i
        zUnitWriter.WriteEndElement() 'Part load data

        zUnitWriter.WriteStartElement("SoundData")
        zUnitWriter.WriteStartElement("TableTitle")
        zUnitWriter.WriteString(ThisChillerMainPerf.SoundTableTitle)
        zUnitWriter.WriteEndElement() 'TableTitle

        For i = 0 To ThisChillerMainPerf.PLRStage.Count - 1
            zUnitWriter.WriteStartElement("Stage" & Trim(ThisChillerMainPerf.PLRStage(i)))
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i))
            zUnitWriter.WriteEndElement() 'Ambient
            zUnitWriter.WriteStartElement("Hz63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(i))
            zUnitWriter.WriteEndElement() 'Hz63
            zUnitWriter.WriteStartElement("Hz125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(i))
            zUnitWriter.WriteEndElement() 'Hz125
            zUnitWriter.WriteStartElement("Hz250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(i))
            zUnitWriter.WriteEndElement() 'Hz250
            zUnitWriter.WriteStartElement("Hz500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(i))
            zUnitWriter.WriteEndElement() 'Hz500
            zUnitWriter.WriteStartElement("Hz1")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(i))
            zUnitWriter.WriteEndElement() 'Hz1
            zUnitWriter.WriteStartElement("Hz2")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(i))
            zUnitWriter.WriteEndElement() 'Hz2
            zUnitWriter.WriteStartElement("Hz4")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(i))
            zUnitWriter.WriteEndElement() 'Hz4
            zUnitWriter.WriteStartElement("Hz8")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(i))
            zUnitWriter.WriteEndElement() 'Hz8
            zUnitWriter.WriteStartElement("HzLpA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(i))
            zUnitWriter.WriteEndElement() 'HzLpA
            zUnitWriter.WriteEndElement() 'Stage i
        Next i
        zUnitWriter.WriteEndElement() 'SoundData
    End Sub
    Private Sub WriteYVAAUnitData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        zUnitWriter.WriteStartElement("ElecDesc")
        zUnitWriter.WriteString(ThisChillerMainPerf.Elec)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Refrigerant")
        zUnitWriter.WriteString(ThisChillerMainPerf.Refrigerant)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINA")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINA)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINB")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINB)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINC")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINC)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PIND")
        zUnitWriter.WriteString(ThisChillerMainPerf.PIND)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINE")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINE)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINF")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINF)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PING")
        zUnitWriter.WriteString(ThisChillerMainPerf.PING)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINH")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINH)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINI")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINI)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.EWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("LWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.LWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Flow")
        zUnitWriter.WriteString(ThisChillerMainPerf.Flow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EvapPD")
        zUnitWriter.WriteString(ThisChillerMainPerf.FPD)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Fluid")
        zUnitWriter.WriteString(ThisChillerMainPerf.Fluid)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("FoulFactor")
        zUnitWriter.WriteString(ThisChillerMainPerf.FoulingFactor)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EvapVol")
        zUnitWriter.WriteString(ThisChillerMainPerf.EvapVolume)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MinFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MaxFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MaxFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.Ambient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Altitude")
        zUnitWriter.WriteString(ThisChillerMainPerf.Altitude)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AmbientMin")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinAmbient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("CompType")
        zUnitWriter.WriteString(ThisChillerMainPerf.CompType)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EER")
        zUnitWriter.WriteString(ThisChillerMainPerf.EER)
        zUnitWriter.WriteEndElement()


        zUnitWriter.WriteStartElement("NPLV")
        zUnitWriter.WriteString(ThisChillerMainPerf.NPLV)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RigWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.RigWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("OpWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.OpWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RefCharge")
        zUnitWriter.WriteString(ThisChillerMainPerf.RefrigerantCharge)
        zUnitWriter.WriteEndElement()
    End Sub
    Private Sub WriteYLAAUnitData(zUnitWriter As XmlWriter, zXMLSettings As XmlWriterSettings)
        Dim i As Integer

        zUnitWriter.WriteStartElement("ElecDesc")
        zUnitWriter.WriteString(ThisChillerMainPerf.Elec)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Refrigerant")
        zUnitWriter.WriteString(ThisChillerMainPerf.Refrigerant)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINA")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINA)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINB")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINB)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINC")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINC)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PIND")
        zUnitWriter.WriteString(ThisChillerMainPerf.PIND)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINE")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINE)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINF")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINF)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PING")
        zUnitWriter.WriteString(ThisChillerMainPerf.PING)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINH")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINH)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PINI")
        zUnitWriter.WriteString(ThisChillerMainPerf.PINI)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.EWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("LWT")
        zUnitWriter.WriteString(ThisChillerMainPerf.LWT)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Flow")
        zUnitWriter.WriteString(ThisChillerMainPerf.Flow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EvapPD")
        zUnitWriter.WriteString(ThisChillerMainPerf.FPD)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Fluid")
        zUnitWriter.WriteString(ThisChillerMainPerf.Fluid)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("FoulFactor")
        zUnitWriter.WriteString(ThisChillerMainPerf.FoulingFactor)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EvapVol")
        zUnitWriter.WriteString(ThisChillerMainPerf.EvapVolume)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MinFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("MaxFlow")
        zUnitWriter.WriteString(ThisChillerMainPerf.MaxFlow)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Ambient")
        zUnitWriter.WriteString(ThisChillerMainPerf.Ambient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("Altitude")
        zUnitWriter.WriteString(ThisChillerMainPerf.Altitude)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("AmbientMin")
        zUnitWriter.WriteString(ThisChillerMainPerf.MinAmbient)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("CompType")
        zUnitWriter.WriteString(ThisChillerMainPerf.CompType)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("EER")
        zUnitWriter.WriteString(ThisChillerMainPerf.EER)
        zUnitWriter.WriteEndElement()


        zUnitWriter.WriteStartElement("NPLV")
        zUnitWriter.WriteString(ThisChillerMainPerf.NPLV)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RigWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.RigWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("OpWeight")
        zUnitWriter.WriteString(ThisChillerMainPerf.OpWeight)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("RefCharge")
        zUnitWriter.WriteString(ThisChillerMainPerf.RefrigerantCharge)
        zUnitWriter.WriteEndElement()

        zUnitWriter.WriteStartElement("PartLoadData")
        For i = 0 To ThisChillerMainPerf.PLRStage.Count - 1
            zUnitWriter.WriteStartElement("Stage" & Trim(ThisChillerMainPerf.PLRStage(i)))
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i))
            zUnitWriter.WriteEndElement() 'Ambient
            zUnitWriter.WriteStartElement("Capacity")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRCapacity(i))
            zUnitWriter.WriteEndElement() 'Capacity
            zUnitWriter.WriteStartElement("TotalkW")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRTotalkW(i))
            zUnitWriter.WriteEndElement() 'TotalkW
            zUnitWriter.WriteStartElement("Efficiency")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLREfficiency(i))
            zUnitWriter.WriteEndElement() 'Efficiency
            zUnitWriter.WriteEndElement() 'Stage i
        Next i
        zUnitWriter.WriteEndElement() 'Part load data

        zUnitWriter.WriteStartElement("SoundData")
        zUnitWriter.WriteStartElement("TableTitle")
        zUnitWriter.WriteString(ThisChillerMainPerf.SoundTableTitle)
        zUnitWriter.WriteEndElement() 'TableTitle

        For i = 0 To ThisChillerMainPerf.PLRStage.Count - 1
            zUnitWriter.WriteStartElement("Stage" & Trim(ThisChillerMainPerf.PLRStage(i)))
            zUnitWriter.WriteStartElement("Ambient")
            zUnitWriter.WriteString(ThisChillerMainPerf.PLRAmbient(i))
            zUnitWriter.WriteEndElement() 'Ambient
            zUnitWriter.WriteStartElement("Hz63")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz63(i))
            zUnitWriter.WriteEndElement() 'Hz63
            zUnitWriter.WriteStartElement("Hz125")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz125(i))
            zUnitWriter.WriteEndElement() 'Hz125
            zUnitWriter.WriteStartElement("Hz250")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz250(i))
            zUnitWriter.WriteEndElement() 'Hz250
            zUnitWriter.WriteStartElement("Hz500")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz500(i))
            zUnitWriter.WriteEndElement() 'Hz500
            zUnitWriter.WriteStartElement("Hz1")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz1(i))
            zUnitWriter.WriteEndElement() 'Hz1
            zUnitWriter.WriteStartElement("Hz2")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz2(i))
            zUnitWriter.WriteEndElement() 'Hz2
            zUnitWriter.WriteStartElement("Hz4")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz4(i))
            zUnitWriter.WriteEndElement() 'Hz4
            zUnitWriter.WriteStartElement("Hz8")
            zUnitWriter.WriteString(ThisChillerMainPerf.Hz8(i))
            zUnitWriter.WriteEndElement() 'Hz8
            zUnitWriter.WriteStartElement("HzLpA")
            zUnitWriter.WriteString(ThisChillerMainPerf.HzLpA(i))
            zUnitWriter.WriteEndElement() 'HzLpA
            zUnitWriter.WriteEndElement() 'Stage i
        Next i
        zUnitWriter.WriteEndElement() 'SoundData
    End Sub
    Private Sub WriteODSplitPerformance(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("CoolingPerformance")
        Call WriteCoolingPerfData(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends cooling performance
    End Sub
    Private Sub WriteRTUPerformance(lUnitWriter As XmlWriter, lmyXMLSettings As XmlWriterSettings)
        lUnitWriter.WriteStartElement("CoolingPerformance")
        Call WriteCoolingPerfData(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends cooling performance

        If ThisUnitCstmCoilPerf.CoilStyle = "None" Then
            lUnitWriter.WriteStartElement("ReheatPerformance")
            Call WriteReheatPerfData(lUnitWriter, lmyXMLSettings)
            lUnitWriter.WriteEndElement() 'ends reheat performance
        Else
            lUnitWriter.WriteStartElement("CstmCoilPerformance")
            Call WriteCstmCoilPerfData(lUnitWriter, lmyXMLSettings)
            lUnitWriter.WriteEndElement() 'ends Custom Coil performance
        End If


        lUnitWriter.WriteStartElement("HeatingPerformance")
        Call WriteHeatingPerfData(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends heating performance

        lUnitWriter.WriteStartElement("SupplyFanPerformance")
        Call WriteSFanPerfData(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends Supply Fan performance

        lUnitWriter.WriteStartElement("RXFanPerformance")
        Call WriteRXPerfData(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends Supply Fan performance

        lUnitWriter.WriteStartElement("IFilterPerformance")
        Call WriteIFilterPerformance(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends Initial Filter Performance

        lUnitWriter.WriteStartElement("FFilterPerformance")
        Call WriteFFilterPerformance(lUnitWriter, lmyXMLSettings)
        lUnitWriter.WriteEndElement() 'ends Final Filter Performance

    End Sub
    Private Sub btnDoneCoolPerf_Click(sender As Object, e As EventArgs) Handles btnDoneCoolPerf.Click
        'save the values to the class
        ThisUnitCoolPerf.TotalCapacity = txtTCap.Text
        ThisUnitCoolPerf.SensibleCapacity = txtSCap.Text
        ThisUnitCoolPerf.Refrigerant = txtRef.Text
        ThisUnitCoolPerf.Efficiency = txtEff.Text
        ThisUnitCoolPerf.AmbientDB = txtAmbientDB.Text
        ThisUnitCoolPerf.EnteringDB = txtEDB.Text
        ThisUnitCoolPerf.EnteringWB = txtEWB.Text
        ThisUnitCoolPerf.LeavingDB = txtLDB.Text
        ThisUnitCoolPerf.LeavingWB = txtLWB.Text
        ThisUnitCoolPerf.Power = txtPower.Text
        ThisUnitCoolPerf.Elevation = txtElev.Text

        If ThisUnit.Family = "Series100" Then
            ThisUnitCoolPerf.Efficiency = txtYPALEER.Text
            ThisUnitCoolPerf.IEER = txtYPALIPLV.Text
        End If

        'preload the reheat page controls
        txtRHControlType.Text = ThisUnitRHPerf.ControlType
        txtRHCap.Text = ThisUnitRHPerf.RHCapacity
        If ((ThisUnitRHPerf.RHAirflow = "-100") And (Val(ThisUnitRHPerf.RHCapacity) > 0)) Then
            txtRHAirflow.Text = ThisUnitSFanPerf.Airflow
        Else
            txtRHAirflow.Text = ThisUnitRHPerf.RHAirflow
        End If
        txtRHEAT.Text = ThisUnitRHPerf.EAT
        txtRHLAT.Text = ThisUnitRHPerf.LAT
        txtRHDeltaT.Text = ThisUnitRHPerf.DeltaT
        txtDHCap.Text = ThisUnitRHPerf.DHCapacity
        txtRHCoilAPD.Text = ThisUnitRHPerf.CoilAPD
        txtPipeStyle.Text = ThisUnitRHPerf.PipingStyle

        tabMain.SelectTab("pgReheat")
    End Sub

    Private Sub ValidateLocalDirectory()
        Dim LocalRoot As String
        Dim BODName As String
        Dim SlashPos As Integer
        Dim JobNum As String
        Dim JobPath As String
        Dim UnitPath As String
        Dim FinalPath As String

        LocalRoot = My.Settings.UOLocalFolder
        JobNum = txtJobNumber.Text & "-" & txtUnitNumber.Text
        If txtJobNumber.Text = "BODF" Then
            'determine appropriate name if its a BOD
            BODName = Mid(txtProjectDirectory.Text, 1, Len(txtProjectDirectory.Text) - 1)
            SlashPos = InStrRev(BODName, "\")
            BODName = Mid(txtProjectDirectory.Text, SlashPos + 1)
            JobPath = LocalRoot & BODName & "\"
            UnitPath = JobPath & JobNum & "\"
            FinalPath = UnitPath & "Submittal Source (Do not Distribute)\Submittal Design\"
        Else
            'determine appropriate name if its a Job
            FinalPath = "bob"
        End If

        If Not (Directory.Exists(FinalPath)) Then
            Directory.CreateDirectory(FinalPath)
        End If
    End Sub

    Private Sub btnDonePD_Click(sender As Object, e As EventArgs) Handles btnDonePD.Click

        Dim Dummy As MsgBoxResult

        Dim TempFileName As String

        If Not (ProjectDataValid()) Then
            Exit Sub
        End If

        If My.Settings.UOStealthMode Then
            Call ValidateLocalDirectory()
        End If

        ThisUnit.Brand = cmbBrand.Text
        If txtModelNumber.Text = "" Then txtModelNumber.Text = txtBrandModelNumber.Text

        ThisUnit.JobNumber = Trim(txtJobNumber.Text)
        ThisUnit.ProjectName = txtProjectName.Text
        ThisUnit.uTag = txtUnitTag.Text
        ThisUnit.UnitNumber = txtUnitNumber.Text
        ThisUnit.Quantity = txtQty.Text
        ThisUnit.Version = txtUnitVersion.Text
        ThisUnit.NominalTons = txtNominalTons.Text
        ThisChillerMainPerf.NominalTons = txtNominalTons.Text
        ThisUnit.BrandModelNumber = txtBrandModelNumber.Text
        ThisUnit.ModelNumber = txtModelNumber.Text

        TSLabelModelNum.Text = "Model Number:" & txtModelNumber.Text

        ThisUnit.UnitDate = dtpUnitDate.Value
        ThisUnit.PrintDate = dtpPrintedDate.Value

        'Store some YPAL Specifics
        If ThisUnit.Family = "Series100" Then
            ThisYPALPerf.UnitSize = txtYPALUnitSize.Text
        End If

        If ((ThisUnit.Kingdom = "RTU") And (ThisUnit.Family <> "Series100")) Then
            ThisUnitPhysicalData.ImportPointLoadsUPG()
        End If

        If ((ThisUnit.Kingdom = "Misc") And (ThisUnit.Family <> "Series20IDSplit")) Then
            ThisUnitPhysicalData.ImportPointLoadsUPG()
        End If

        If ((ThisUnit.Kingdom = "RTU") And (ThisUnit.Family = "Series100")) Then
            If ThisUnitPhysicalData.BasePointLoad.Count = 0 Then
                ThisUnitPhysicalData.ImportPointLoadsYPAL()
            End If
        End If

        If ThisUnit.Kingdom = "Blank" Then
            ThisUnitPhysicalData.ImportPointLoadsBlank()
        End If

        Call loadPermittedMods()

        Select Case ThisUnit.Kingdom
            Case Is = "Chiller"
                Call PreloadBaseChiller()

                tabMain.SelectTab("pgBaseChiller")
            Case Is = "Misc"
                If ThisUnit.Family = "DS" Then
                    frmDSUnitBase.ShowDialog()
                End If
            Case Else

        End Select
        If ThisUnit.Kingdom <> "Chiller" Then

            tabMain.SelectTab("pgModifications")
        End If

        My.Settings.LastJobNumber = txtJobNumber.Text
        My.Settings.LastUnitNumber = txtUnitNumber.Text
        My.Settings.LastProjDir = txtProjectDirectory.Text

        If IsNumeric(Mid(txtJobNumber.Text, 1, 4)) Then
            nudJobNumberAdj.Value = Val(Mid(txtJobNumber.Text, 1, 4))
        Else
            nudJobNumberAdj.Value = 3300
        End If

        TempFileName = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Sales Info\" & txtJobNumber.Text & "-" & txtUnitNumber.Text & " - ModsFile.xml"
        If Not (My.Computer.FileSystem.FileExists(TempFileName)) Then
            chkInhibitDigConditions.Checked = True
            Dummy = MsgBox("Sales entered modification conditions file missing." & vbCrLf & "Conditions will need to be manually entered.", vbOKOnly, "Fisen Unit Generator")
        End If

        If chkDebug.Checked And Not (My.Settings.UOSkipArchive) Then
            Call ArchiveOldSubDesignFiles()
        End If

        My.Settings.Save()
        DesignNotes = "Design Notes for: " & txtJobNumber.Text & "-" & txtUnitNumber.Text & " - " & txtProjectName.Text & " " & dtpUnitDate.Text & " " & txtUnitVersion.Text & vbCrLf

        'Handle writing the recovery file
        If Not (chkThisIsARedo.Checked) Then Call WriteRedoFileProjectData()


    End Sub

    Private Sub WriteRedoFileProjectData()
        Dim RedoFilePath As String

        RedoFilePath = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\Submittal Design\RedoFile.xml"
        Dim myXMLSettings As New XmlWriterSettings
        Dim UnitWriter As XmlWriter

        myXMLSettings.Indent = True
        myXMLSettings.NewLineOnAttributes = True

        UnitWriter = XmlWriter.Create(RedoFilePath, myXMLSettings)

        UnitWriter.WriteComment("Fisen Unit Redo File")

        UnitWriter.WriteStartElement("ProjectData")

        UnitWriter.WriteStartElement("JobNumber")
        UnitWriter.WriteString(txtJobNumber.Text)
        UnitWriter.WriteEndElement() 'JobNumber 

        UnitWriter.WriteStartElement("UnitNumber")
        UnitWriter.WriteString(txtUnitNumber.Text)
        UnitWriter.WriteEndElement() 'Unit Number   

        UnitWriter.WriteStartElement("UnitDate")
        UnitWriter.WriteString(dtpUnitDate.Text)
        UnitWriter.WriteEndElement() 'Family 

        UnitWriter.WriteStartElement("PrintDate")
        UnitWriter.WriteString(dtpPrintedDate.Text)
        UnitWriter.WriteEndElement() 'Cabinet 

        UnitWriter.WriteStartElement("ProjectDir")
        UnitWriter.WriteString(txtProjectDirectory.Text)
        UnitWriter.WriteEndElement() 'Project Directory

        UnitWriter.WriteStartElement("BUS")
        UnitWriter.WriteString(txtBaseUnitFile.Text)
        UnitWriter.WriteEndElement() ' 

        UnitWriter.WriteStartElement("RedoFile")
        UnitWriter.WriteString(txtRedoFilePath.Text)
        UnitWriter.WriteEndElement() ' Redo File Path

        UnitWriter.WriteStartElement("ProjectName")
        UnitWriter.WriteString(txtProjectName.Text)
        UnitWriter.WriteEndElement() ' Project Name

        UnitWriter.WriteStartElement("Quantity")
        UnitWriter.WriteString(txtQty.Text)
        UnitWriter.WriteEndElement() ' Qty

        UnitWriter.WriteStartElement("BrandModNum")
        UnitWriter.WriteString(txtBrandModelNumber.Text)
        UnitWriter.WriteEndElement() ' BrandNum

        UnitWriter.WriteStartElement("JCIModNum")
        UnitWriter.WriteString(txtModelNumber.Text)
        UnitWriter.WriteEndElement() ' JCIModel Number

        UnitWriter.WriteStartElement("UnitTag")
        UnitWriter.WriteString(txtUnitTag.Text)
        UnitWriter.WriteEndElement() ' unit tag

        UnitWriter.WriteStartElement("UnitVer")
        UnitWriter.WriteString(txtUnitVersion.Text)
        UnitWriter.WriteEndElement() ' 

        UnitWriter.WriteStartElement("NomTons")
        UnitWriter.WriteString(txtNominalTons.Text)
        UnitWriter.WriteEndElement() ' 

        UnitWriter.WriteStartElement("UnitSize")
        UnitWriter.WriteString(txtYPALUnitSize.Text)
        UnitWriter.WriteEndElement() ' 

        UnitWriter.WriteStartElement("Brand")
        UnitWriter.WriteString(cmbBrand.Text)
        UnitWriter.WriteEndElement() ' 

        UnitWriter.WriteEndElement() 'Project Data

        UnitWriter.WriteEndDocument()
        UnitWriter.Close()

    End Sub

    Private Sub ArchiveOldSubDesignFiles()
        Dim ProjectDir As String
        Dim UnitDir As String
        Dim ArchiveDir As String
        Dim TargetDir As String
        Dim NewVersion, OldVersion As String
        Dim FileList As String()
        Dim JustFile As String
        Dim LastSlash As Integer
        Dim i, j


        'First Create the new archive directory.
        ProjectDir = txtProjectDirectory.Text
        UnitDir = ProjectDir & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\Submittal Design\"
        ArchiveDir = UnitDir & "Archive\"
        NewVersion = txtUnitVersion.Text
        OldVersion = "V" & Trim(Str(Val(NewVersion) - 1))
        My.Computer.FileSystem.CreateDirectory(ArchiveDir & OldVersion)
        TargetDir = ArchiveDir & OldVersion & "\"
        FileList = Directory.GetFiles(Mid(UnitDir, 1, Len(UnitDir) - 1))

        frmArchiver.localTargetDir = TargetDir
        frmArchiver.txtTargetDir.Text = TargetDir
        j = 0
        For i = 0 To FileList.Length - 1
            LastSlash = InStrRev(FileList(i), "\")
            JustFile = Mid(FileList(i), LastSlash + 1)

            If FileList(i) <> UnitDir & "BaseUnitFile.xml" Then
                frmArchiver.lstFilesToArchive.Items.Add(JustFile)
                frmArchiver.lstFilesToArchive.SetItemChecked(j, True)
                j = j + 1
                frmArchiver.FileAndPath.Add(FileList(i))
            End If
        Next

        If frmArchiver.lstFilesToArchive.Items.Count > 0 Then
            frmArchiver.ShowDialog()
        End If
        frmArchiver.Close()

    End Sub
    Private Sub cmbHeatType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeatType.SelectedIndexChanged
        Dim gas As Boolean
        Dim steam As Boolean
        Dim elec As Boolean
        Dim water As Boolean

        gas = (cmbHeatType.Text Like "Gas")
        steam = (cmbHeatType.Text Like "Steam")
        water = (cmbHeatType.Text Like "Hot Water")
        elec = (cmbHeatType.Text Like "Electric")

        Label29.Visible = gas
        Label28.Visible = gas
        txtHeatInCap.Visible = gas
        txtHeatSSE.Visible = gas

        Label37.Visible = water
        Label38.Visible = water
        Label39.Visible = (steam Or water)
        Label40.Visible = steam
        Label41.Visible = steam
        Label27.Visible = water
        Label24.Visible = water
        Label42.Visible = water
        txtHeatSteamP.Visible = steam
        txtHeatCondFlow.Visible = steam
        txtHeatCoilAPD.Visible = (steam Or water)
        txtHeatFluid.Visible = water
        txtHeatFluidFlow.Visible = water
        txtHeatEFT.Visible = water
        txtHeatLFT.Visible = water
        txtFPD.Visible = water

        Label44.Visible = elec
        Label43.Visible = elec
        txtHeatAppliedEHeat.Visible = elec
        txtHeatNominalEHeat.Visible = elec

        If cmbHeatType.Text = "None" Then
            cmbControlStyle.Text = "n/a"
            txtHeatOutCap.Text = "-"
            txtHeatAF.Text = "-"
            txtHeatEAT.Text = "-"
            txtHeatLAT.Text = "-"
            txtHeatDeltaT.Text = "-"
            txtHeatInCap.Text = "-"
            txtHeatSSE.Text = "-"
            txtHeatSteamP.Text = "-"
            txtHeatCondFlow.Text = "-"
            txtHeatCoilAPD.Text = "-"
            txtHeatFluid.Text = "-"
            txtHeatFluidFlow.Text = "-"
            txtHeatEFT.Text = "-"
            txtHeatLFT.Text = "-"
            txtFPD.Text = "-"
            txtHeatAppliedEHeat.Text = "-"
            txtHeatNominalEHeat.Text = "-"
        End If

    End Sub
    Private Sub btnDoneHP_Click(sender As Object, e As EventArgs) Handles btnDoneHP.Click

        ThisUnitHeatPerf.HeatType = cmbHeatType.Text
        ThisUnitHeatPerf.ControlStyle = cmbControlStyle.Text
        ThisUnitHeatPerf.OutputCapacity = txtHeatOutCap.Text
        ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        ThisUnitHeatPerf.EnteringAirTemp = txtHeatEAT.Text
        ThisUnitHeatPerf.LeavingAirTemp = txtHeatLAT.Text
        ThisUnitHeatPerf.DeltaT = txtHeatDeltaT.Text
        ThisUnitHeatPerf.SSE = txtHeatSSE.Text
        ThisUnitHeatPerf.InputCapacity = txtHeatInCap.Text
        ThisUnitHeatPerf.SteamPressure = txtHeatSteamP.Text
        ThisUnitHeatPerf.CondensateFlow = txtHeatCondFlow.Text
        ThisUnitHeatPerf.CoilAPD = txtHeatCoilAPD.Text
        ThisUnitHeatPerf.Fluid = txtHeatFluid.Text
        ThisUnitHeatPerf.FluidFlow = txtHeatFluidFlow.Text
        ThisUnitHeatPerf.EntFluidTemp = txtHeatEFT.Text
        ThisUnitHeatPerf.LvgFluidTemp = txtHeatLFT.Text
        ThisUnitHeatPerf.FluidPressureDrop = txtFPD.Text
        ThisUnitHeatPerf.AppliedEHeat = txtHeatAppliedEHeat.Text
        ThisUnitHeatPerf.NominalEHeat = txtHeatNominalEHeat.Text

        ThisUnitHeatPerf.GasConsumption = txtYPALGasConsumption.Text
        ThisUnitHeatPerf.GasHeatContent = txtYPALGasHeatContent.Text

        txtAirflow.Text = ThisUnitSFanPerf.Airflow
        txtESP.Text = ThisUnitSFanPerf.ESP
        txtTSP.Text = ThisUnitSFanPerf.TSP
        If txtTSP.Text = " " Then txtTSP.Text = "-"
        txtRPM.Text = ThisUnitSFanPerf.RPM
        txtMhp.Text = ThisUnitSFanPerf.MotorHP
        txtFanhp.Text = ThisUnitSFanPerf.BrakeHP
        txtFanPower.Text = ThisUnitSFanPerf.kWPower
        txtDriveType.Text = ThisUnitSFanPerf.DriveType
        txtDuctLoc.Text = ThisUnitSFanPerf.DuctLoc

        If ThisUnit.Family = "Series100" Then
            grpYPALSFanOnly.Visible = True
            txtSFanModel.Text = ThisUnitSFanPerf.FanSelected
            txtYPALSFanMotor.Text = ThisUnitSFanPerf.MotorText
        End If

        Call PreviewStaticPressureAudit()

        tabMain.SelectTab("pgSupplyAir")
    End Sub
    Private Sub PreviewStaticPressureAudit()

        Dim PreviewReport As String
        Dim i As Integer

        Dim LineItemDesc As String
        Dim SumSTP, SumATP As Double


        PreviewReport = "Supply Fan Static Pressure Audit" & vbCrLf & vbCrLf

        PreviewReport = PreviewReport & "Airflow: " & ThisUnitSFanPerf.Airflow & vbCrLf
        PreviewReport = PreviewReport & "Elevation: " & ThisUnitCoolPerf.Elevation & vbCrLf
        PreviewReport = PreviewReport & "Elevation kFactor: " & Format(ElevationCorrection(ThisUnitCoolPerf.Elevation), "0.00") & vbCrLf & vbCrLf

        PreviewReport = PreviewReport & "Fisen Added Static Pressure Loads" & vbCrLf & vbCrLf

        SumSTP = 0
        SumATP = 0
        PreviewReport = PreviewReport & FormatStaticLine("Item", "STP", "ATP") & vbCrLf
        For i = 0 To ThisUnitSFanPerf.StaticSummaryItem.Count - 2
            LineItemDesc = ThisUnitSFanPerf.StaticSummaryItem(i).ToString
            If ((LineItemDesc = "External Static Pressure") Or (LineItemDesc = "Base Unit Static Pressure") Or (LineItemDesc = "Factory Options") Or (LineItemDesc = "")) Then
                'These three aren't Fisen added loads so don't do anything with them...yet.
            Else
                PreviewReport = PreviewReport & FormatStaticLine(LineItemDesc, ThisUnitSFanPerf.StaticPDataSTP(i), ThisUnitSFanPerf.StaticPDataATP(i)) & vbCrLf
                SumSTP = SumSTP + Val(ThisUnitSFanPerf.StaticPDataSTP(i))
                SumATP = SumATP + Val(ThisUnitSFanPerf.StaticPDataATP(i))
            End If
        Next
        PreviewReport = PreviewReport & vbCrLf
        PreviewReport = PreviewReport & FormatStaticLine("Net Fisen Add", Str(SumSTP), Str(SumATP)) & vbCrLf & vbCrLf

        PreviewReport = PreviewReport & "Base Unit Information" & vbCrLf

        SumSTP = 0
        SumATP = 0
        For i = 0 To ThisUnitSFanPerf.StaticSummaryItem.Count - 2
            LineItemDesc = ThisUnitSFanPerf.StaticSummaryItem(i)
            If ((LineItemDesc = "External Static Pressure") Or (LineItemDesc = "Base Unit Static Pressure") Or (LineItemDesc = "Factory Options")) Then

                PreviewReport = PreviewReport & FormatStaticLine(LineItemDesc, ThisUnitSFanPerf.StaticPDataSTP(i), ThisUnitSFanPerf.StaticPDataATP(i)) & vbCrLf
                SumSTP = SumSTP + Val(ThisUnitSFanPerf.StaticPDataSTP(i))
                SumATP = SumATP + Val(ThisUnitSFanPerf.StaticPDataATP(i))
            Else
                'These three aren't base unit loads so don't do anything with them...yet.
            End If
        Next
        PreviewReport = PreviewReport & vbCrLf
        PreviewReport = PreviewReport & FormatStaticLine("Base Unit Totals", Str(SumSTP), Str(SumATP)) & vbCrLf & vbCrLf

        txtStaticPressureAudit.Text = PreviewReport
    End Sub
    Private Sub btnDoneRH_Click(sender As Object, e As EventArgs) Handles btnDoneRH.Click

        ThisUnitRHPerf.ControlType = txtRHControlType.Text
        ThisUnitRHPerf.RHCapacity = txtRHCap.Text
        ThisUnitRHPerf.RHAirflow = txtRHAirflow.Text
        ThisUnitRHPerf.EAT = txtRHEAT.Text
        ThisUnitRHPerf.LAT = txtRHLAT.Text

        ThisUnitRHPerf.DHCapacity = txtDHCap.Text
        ThisUnitRHPerf.CoilAPD = txtRHCoilAPD.Text
        ThisUnitRHPerf.PipingStyle = txtPipeStyle.Text

        'Prep the heating tab for display
        cmbHeatType.Text = ThisUnitHeatPerf.HeatType
        cmbControlStyle.Text = ThisUnitHeatPerf.ControlStyle
        txtHeatOutCap.Text = ThisUnitHeatPerf.OutputCapacity
        txtHeatAF.Text = ThisUnitHeatPerf.Airflow
        If ThisUnitHeatPerf.HeatType <> "None" And txtHeatAF.Text = "0" Then
            txtHeatAF.Text = ThisUnitSFanPerf.Airflow
        End If
        txtHeatEAT.Text = ThisUnitHeatPerf.EnteringAirTemp
        txtHeatLAT.Text = ThisUnitHeatPerf.LeavingAirTemp
        txtHeatDeltaT.Text = ThisUnitHeatPerf.DeltaT
        txtHeatSSE.Text = ThisUnitHeatPerf.SSE
        txtHeatInCap.Text = ThisUnitHeatPerf.InputCapacity
        txtHeatSteamP.Text = ThisUnitHeatPerf.SteamPressure
        txtHeatCondFlow.Text = ThisUnitHeatPerf.CondensateFlow
        txtHeatCoilAPD.Text = ThisUnitHeatPerf.CoilAPD
        txtHeatFluid.Text = ThisUnitHeatPerf.Fluid
        If Mid(txtHeatFluid.Text, 1, 1) = "P" Then
            txtHeatFluid.Text = "PG" & Mid(txtHeatFluid.Text, Len(txtHeatFluid.Text) - 1)
        End If
        If Mid(txtHeatFluid.Text, 1, 1) = "E" Then
            txtHeatFluid.Text = "PG" & Mid(txtHeatFluid.Text, Len(txtHeatFluid.Text) - 1)
        End If
        If Mid(txtHeatFluid.Text, 1, 1) = "W" Then
            txtHeatFluid.Text = "Water"
        End If
        txtHeatFluidFlow.Text = ThisUnitHeatPerf.FluidFlow
        txtHeatEFT.Text = ThisUnitHeatPerf.EntFluidTemp
        txtHeatLFT.Text = ThisUnitHeatPerf.LvgFluidTemp
        txtFPD.Text = ThisUnitHeatPerf.FluidPressureDrop
        txtHeatAppliedEHeat.Text = ThisUnitHeatPerf.AppliedEHeat
        txtHeatNominalEHeat.Text = ThisUnitHeatPerf.NominalEHeat

        If ((ThisUnit.Family = "Series100") And (ThisUnitHeatPerf.HeatType = "Gas Heat")) Then
            grpYPALGasHeat.Visible = True
            txtYPALGasHeatContent.Text = ThisUnitHeatPerf.GasHeatContent
            txtYPALGasConsumption.Text = Format(Val(ThisUnitHeatPerf.InputCapacity / ThisUnitHeatPerf.GasHeatContent * 1000.0), "0.0")
        End If


        tabMain.SelectTab("pgHeating")
    End Sub
    Private Sub btnDoneSA_Click(sender As Object, e As EventArgs) Handles btnDoneSA.Click
        ThisUnitSFanPerf.Airflow = txtAirflow.Text
        ThisUnitSFanPerf.ESP = txtESP.Text
        ThisUnitSFanPerf.TSP = txtTSP.Text
        ThisUnitSFanPerf.RPM = txtRPM.Text
        ThisUnitSFanPerf.MotorHP = txtMhp.Text
        ThisUnitSFanPerf.BrakeHP = txtFanhp.Text
        ThisUnitSFanPerf.kWPower = txtFanPower.Text
        ThisUnitSFanPerf.DriveType = txtDriveType.Text
        ThisUnitSFanPerf.DuctLoc = txtDuctLoc.Text

        If ThisUnit.Family = "Series100" Then
            ThisUnitSFanPerf.FanSelected = txtSFanModel.Text
            ThisUnitSFanPerf.MotorText = txtYPALSFanMotor.Text
        End If

        'Start the Preload for the RXFan Page.

        cmbFanStyle.Text = ThisUnitRXPerf.FanStyle
        txtRXAirflow.Text = ThisUnitRXPerf.Airflow
        txtRXESP.Text = ThisUnitRXPerf.ESP
        txtRXTSP.Text = ThisUnitRXPerf.TSP
        txtRXRPM.Text = ThisUnitRXPerf.RPM
        txtRXMhp.Text = ThisUnitRXPerf.MotorHP
        txtRXFanhp.Text = ThisUnitRXPerf.BrakeHP
        txtRXFanPower.Text = ThisUnitRXPerf.kWPower
        txtRXDriveType.Text = ThisUnitRXPerf.DriveType
        txtRXDuctLoc.Text = ThisUnitRXPerf.DuctLoc
        txtYPALRXFanModel.Text = ThisUnitRXPerf.FanSelected
        txtYPALRXFanMotor.Text = ThisUnitRXPerf.MotorText

        If ThisUnit.Family = "Series100" Then
            grpYPALRXFanOnly.Visible = True
        End If

        tabMain.SelectTab("pgRXAir")
    End Sub
    Private Sub btnDoneRXA_Click(sender As Object, e As EventArgs) Handles btnDoneRXA.Click

        ThisUnitRXPerf.FanStyle = cmbFanStyle.Text
        ThisUnitRXPerf.Airflow = txtRXAirflow.Text
        ThisUnitRXPerf.ESP = txtRXESP.Text
        ThisUnitRXPerf.TSP = txtRXTSP.Text
        ThisUnitRXPerf.RPM = txtRXRPM.Text
        ThisUnitRXPerf.MotorHP = txtRXMhp.Text
        ThisUnitRXPerf.BrakeHP = txtRXFanhp.Text
        ThisUnitRXPerf.kWPower = txtRXFanPower.Text
        ThisUnitRXPerf.DriveType = txtRXDriveType.Text
        ThisUnitRXPerf.DuctLoc = txtRXDuctLoc.Text

        If ThisUnit.Family = "Series100" Then
            ThisUnitRXPerf.FanSelected = txtYPALRXFanModel.Text
            ThisUnitRXPerf.MotorText = txtYPALRXFanMotor.Text
        End If


        'Initialize the Disconnect Info
        Call PreLoadElec()
        Call UpdateTheMCA()
        tabMain.SelectTab("pgElec")
    End Sub
    Public Sub PreLoadElec()
        txtCommVolts.Text = ThisUnitElecData.CommVolts
        txtCommPhase.Text = ThisUnitElecData.CommPhase
        txtCommFreq.Text = ThisUnitElecData.CommFreq
        txtCommMCA.Text = ThisUnitElecData.CommMCA
        txtCommMOP.Text = ThisUnitElecData.CommMOP
        txtEmerVolts.Text = ThisUnitElecData.EmerVolts
        txtEmerPhase.Text = ThisUnitElecData.EmerPhase
        txtEmerFreq.Text = ThisUnitElecData.EmerFreq
        txtEmerMCA.Text = ThisUnitElecData.EmerMCA
        txtEmerMOP.Text = ThisUnitElecData.EmerMOP

        'Setup the custom MCA Entries

        chkIncludeLoadinCalc.Checked = False
        chkElecHeatLoad.Checked = False
        cmbLoadMode.Text = "All"
        cmbElecLoads.Text = ""
        cmbLoadVoltsPhFreq.Text = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text
        txtElecLoadFLA.Text = ""
        cmbMotorHPList.Text = "-"

        If ThisUnitElecData.CommDisconnect Then optCommNFDisc.Checked = True
        If ThisUnitElecData.CommFused Then optCommFusedDisc.Checked = True
        If ThisUnitElecData.EmerCircuit Then optEmerMLO.Checked = True
        If ((ThisUnitElecData.EmerCircuit) And (ThisUnitElecData.EmerDisconnect)) Then optEmerNFDisc.Checked = True
        If ((ThisUnitElecData.EmerCircuit) And (ThisUnitElecData.EmerFused)) Then optEmerFusedDisc.Checked = True
        If UseCustomMCA = True Then
            chkUseCustomMCA.Checked = True
        Else

        End If
    End Sub
    Private Sub UpdateGrossWeights()
        Dim i As Integer
        Dim MyBaseWt As System.Windows.Forms.Label
        Dim MyModWt As System.Windows.Forms.Label
        Dim MyGrossWt As System.Windows.Forms.TextBox
        Dim intBaseWeight As Integer
        Dim intModWeight As Integer
        Dim intGrossWeight As Integer

        For i = 65 To 84
            MyBaseWt = grpPtLoads.Controls.Item("lblBaseWt" & Chr(i))
            MyModWt = grpPtLoads.Controls.Item("lblModWt" & Chr(i))
            MyGrossWt = grpPtLoads.Controls.Item("txtPtWt" & Chr(i))
            intBaseWeight = Val(MyBaseWt.Text)
            intModWeight = Val(MyModWt.Text)
            intGrossWeight = intBaseWeight + intModWeight
            MyGrossWt.Text = Trim(Str(intGrossWeight))
        Next i
    End Sub
    Private Sub UpdateModPointWeights()
        Dim i As Integer
        Dim MyModWeight As System.Windows.Forms.Label
        Dim MyPointLoc As System.Windows.Forms.TextBox

        Dim TopWeights As Double
        Dim BottomWeights As Double
        Dim leftpoints(20) As Double
        Dim rightpoints(20) As Double
        Dim rightpointcount As Integer
        Dim leftpointcount As Integer
        Dim rightdenominator As Integer
        Dim leftdenominator As Integer
        Dim numerator As Integer

        Dim CGPoint As Double
        Dim MyLoc As Double

        'bould the left / right point matrix
        rightpointcount = 0
        leftpointcount = 0
        For i = 0 To 19
            leftpoints(i) = 0
            rightpoints(i) = 0
        Next

        CGPoint = lblLongitudinal.Text
        For i = 1 To nudPointLoads.Value - 1 Step 2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)

            If MyLoc <= CGPoint Then
                rightpointcount = rightpointcount + 1
            Else
                'do nothing
            End If
        Next i
        leftpointcount = nudPointLoads.Value / 2 - rightpointcount
        rightdenominator = 0
        For i = 1 To rightpointcount
            rightdenominator = rightdenominator + i
        Next i

        For i = 1 To leftpointcount
            leftdenominator = leftdenominator + i
        Next i

        'set the coefficents now. right side
        numerator = rightpointcount
        For i = nudPointLoads.Value - 1 To 0 Step -2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc <= CGPoint Then
                rightpoints(i) = numerator / rightdenominator
                numerator = numerator - 1
            End If
        Next

        numerator = leftpointcount
        For i = 1 To nudPointLoads.Value - 1 Step 2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc > CGPoint Then
                leftpoints(i) = numerator / leftdenominator
                numerator = numerator - 1
            End If
        Next i

        TopWeights = (100 - vsbTransverse.Value) / 100 * Val(txtModWeight.Text)

        'First the top points
        'intPointModWeight = TopWeights / (nudPointLoads.Value / 2)
        For i = 66 To 84 Step 2
            MyModWeight = grpPtLoads.Controls.Item("lblModWt" & Chr(i))
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc <= CGPoint Then
                MyModWeight.Text = Format(((rightpointcount / (rightpointcount + leftpointcount))) * TopWeights * rightpoints(i - 65), "0")
            Else
                MyModWeight.Text = Format((1 - (rightpointcount / (rightpointcount + leftpointcount))) * TopWeights * leftpoints(i - 65), "0")
            End If

        Next i

        'Second the bottom points
        rightpointcount = 0
        leftpointcount = 0
        For i = 0 To 19
            leftpoints(i) = 0
            rightpoints(i) = 0
        Next

        For i = 0 To nudPointLoads.Value - 1 Step 2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)

            If MyLoc <= CGPoint Then
                rightpointcount = rightpointcount + 1
            Else
                'do nothing
            End If
        Next i
        leftpointcount = nudPointLoads.Value / 2 - rightpointcount
        rightdenominator = 0
        For i = 1 To rightpointcount
            rightdenominator = rightdenominator + i
        Next i

        leftdenominator = 0
        For i = 1 To leftpointcount
            leftdenominator = leftdenominator + i
        Next i

        'set the coefficents now. right side
        numerator = rightpointcount
        For i = nudPointLoads.Value - 2 To 0 Step -2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc <= CGPoint Then
                rightpoints(i) = numerator / rightdenominator
                numerator = numerator - 1
            End If
        Next

        numerator = leftpointcount
        For i = 0 To nudPointLoads.Value - 2 Step 2
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(65 + i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc > CGPoint Then
                leftpoints(i) = numerator / leftdenominator
                numerator = numerator - 1
            End If
        Next i

        BottomWeights = (vsbTransverse.Value / 100) * Val(txtModWeight.Text)

        For i = 65 To 84 Step 2
            MyModWeight = grpPtLoads.Controls.Item("lblModWt" & Chr(i))
            MyPointLoc = grpPtLoads.Controls.Item("txtPtdX" & Chr(i))
            MyLoc = Val(MyPointLoc.Text)
            If MyLoc <= CGPoint Then
                MyModWeight.Text = Format(((rightpointcount / (rightpointcount + leftpointcount))) * BottomWeights * rightpoints(i - 65), "0")
            Else
                MyModWeight.Text = Format((1 - (rightpointcount / (rightpointcount + leftpointcount))) * BottomWeights * leftpoints(i - 65), "0")
            End If

        Next i

    End Sub
    Private Sub btnDoneElec_Click(sender As Object, e As EventArgs) Handles btnDoneElec.Click
        Dim myobj As System.Windows.Forms.TextBox
        Dim mylbl As System.Windows.Forms.Label
        Dim MyPointBox As System.Windows.Forms.TextBox

        Dim MassAdds As Integer
        Dim MassSF As Integer
        Dim MassFluids As Double
        Dim spaces As Integer
        Dim spacelength As Double


        ThisUnitElecData.CommVolts = txtCommVolts.Text
        ThisUnitElecData.CommPhase = txtCommPhase.Text
        ThisUnitElecData.CommFreq = txtCommFreq.Text
        ThisUnitElecData.CommMCA = txtCommMCA.Text
        ThisUnitElecData.CommMOP = txtCommMOP.Text
        ThisUnitElecData.EmerVolts = txtEmerVolts.Text
        ThisUnitElecData.EmerPhase = txtEmerPhase.Text
        ThisUnitElecData.EmerFreq = txtEmerFreq.Text
        ThisUnitElecData.EmerMCA = txtEmerMCA.Text
        If Val(ThisUnitElecData.EmerMCA) = 0 Then ThisUnitElecData.EmerMCA = "-"
        If Val(ThisUnitElecData.EmerMOP) = 0 Then ThisUnitElecData.EmerMOP = "-"
        ThisUnitElecData.EmerMOP = txtEmerMOP.Text

        If optCommMLO.Checked Then
            ThisUnitElecData.CommDisconnect = False
            ThisUnitElecData.CommFused = False
        End If
        If optCommNFDisc.Checked Then
            ThisUnitElecData.CommDisconnect = True
            ThisUnitElecData.CommFused = False
        End If
        If optCommFusedDisc.Checked Then
            ThisUnitElecData.CommDisconnect = False
            ThisUnitElecData.CommFused = True
        End If

        If optEmerMLO.Checked Then
            ThisUnitElecData.EmerDisconnect = False
            ThisUnitElecData.EmerFused = False
            ThisUnitElecData.EmerCircuit = True
        End If
        If optEmerNFDisc.Checked Then
            ThisUnitElecData.EmerDisconnect = True
            ThisUnitElecData.EmerFused = False
            ThisUnitElecData.EmerCircuit = True
        End If
        If optEmerFusedDisc.Checked Then
            ThisUnitElecData.EmerDisconnect = False
            ThisUnitElecData.EmerFused = True
            ThisUnitElecData.EmerCircuit = True
        End If
        If optEmerNA.Checked Then
            ThisUnitElecData.EmerDisconnect = False
            ThisUnitElecData.EmerFused = False
            ThisUnitElecData.EmerCircuit = False
        End If

        'Now Prepare the Physical Data Page
        nudPointLoads.Value = ThisUnitPhysicalData.CalcPoints

        txtLength.Text = ThisUnitPhysicalData.Length
        txtWidth.Text = ThisUnitPhysicalData.Width
        txtHeight.Text = ThisUnitPhysicalData.Height
        txtBUWeight.Text = ThisUnitPhysicalData.BaseUnitWeight
        lblTransverse.Text = Str((vsbTransverse.Value) / 100 * txtWidth.Text)
        lblLongitudinal.Text = Str((100 - hsbLongitudinal.Value) / 100 * txtLength.Text)

        MassAdds = 0
        MassSF = 0
        If ThisUnitPhysicalData.ModLoadItem.Count > 0 Then
            For i = 0 To ThisUnitPhysicalData.ModLoadItem.Count - 1
                lstModWtMod.Items.Add(ThisUnitPhysicalData.ModLoadMod(i))
                lstModWtItem.Items.Add(ThisUnitPhysicalData.ModLoadItem(i))
                lstModWtMass.Items.Add(ThisUnitPhysicalData.ModLoadMass(i))
                MassAdds = MassAdds + Val(ThisUnitPhysicalData.ModLoadMass(i))
            Next
        End If

        MassSF = Format(MassAdds / 10, "0")
        lblSFMass.Text = Str(MassSF)

        txtModWeight.Text = Format(MassAdds + MassSF, "0")

        If ThisUnitPhysicalData.BasePointLoad.Count > 0 Then
            For i = 0 To Val(ThisUnitPhysicalData.BasePointLoad.Count) - 1
                mylbl = grpPtLoads.Controls.Item("lblBaseWt" & Chr(65 + i))
                mylbl.Text = ThisUnitPhysicalData.BasePointLoad(i)
            Next i

            For i = 0 To Val(ThisUnitPhysicalData.CalcPoints) - 1
                myobj = grpPtLoads.Controls.Item("txtPtWt" & Chr(65 + i))

                If ThisUnit.Kingdom = "RTU" Then
                    myobj.Text = Format(Val(ThisUnitPhysicalData.BasePointLoad(i)) + (MassAdds + MassSF) / Val(ThisUnitPhysicalData.CalcPoints), "0")
                Else
                    'myobj.Text = ThisUnitPhysicalData.PointLoad(i)
                End If

            Next i
            Call UpdateModPointWeights()
            Call UpdateGrossWeights()

        End If

        txtLength.Text = ThisUnitPhysicalData.Length
        txtWidth.Text = ThisUnitPhysicalData.Width
        txtHeight.Text = ThisUnitPhysicalData.Height
        txtBUWeight.Text = ThisUnitPhysicalData.BaseUnitWeight
        lblTransverse.Text = Str((vsbTransverse.Value) / 100 * txtWidth.Text)
        lblLongitudinal.Text = Str((100 - hsbLongitudinal.Value) / 100 * txtLength.Text)

        If ThisUnitPhysicalData.CalcPoints > 4 Then
            spaces = ThisUnitPhysicalData.CalcPoints / 2 + 1
            spacelength = ThisUnitPhysicalData.Length / spaces

            For i = 65 To (65 + ThisUnitPhysicalData.CalcPoints) Step 2

                MyPointBox = grpPtLoads.Controls.Item("txtPtdX" & Chr(i))
                MyPointBox.Text = Format((spacelength * (i - 65)) / 2, "0.0")
                MyPointBox = grpPtLoads.Controls.Item("txtPtdX" & Chr(i + 1))
                MyPointBox.Text = Format((spacelength * (i - 65)) / 2, "0.0")

            Next i

        Else
            txtPtdXD.Text = "0.0"
            txtPtdXC.Text = "0.0"
            txtPtdXB.Text = ThisUnitPhysicalData.Length
            txtPtdXA.Text = ThisUnitPhysicalData.Length
        End If

        MassFluids = Val(ThisChillerMainPerf.BaseFluidMass)

        txtRigWeight.Text = Str(Val(ThisUnitPhysicalData.BaseUnitWeight) + MassAdds + MassSF)
        txtOpWeight.Text = Str(Val(ThisUnitPhysicalData.BaseUnitWeight) + MassAdds + MassSF + MassFluids)

        txtRightClear.Text = ThisUnitPhysicalData.ClrRight
        txtTopClear.Text = ThisUnitPhysicalData.ClrTop
        txtFrontClear.Text = ThisUnitPhysicalData.ClrFront
        txtBottomClear.Text = ThisUnitPhysicalData.ClrBottom
        txtBackClear.Text = ThisUnitPhysicalData.ClrBack
        txtLeftClear.Text = ThisUnitPhysicalData.ClrLeft



        tabMain.SelectTab("pgPhysical")
    End Sub
    Private Sub btnDonePhysical_Click(sender As Object, e As EventArgs) Handles btnDonePhysical.Click
        Dim i As Integer
        Dim myobj As System.Windows.Forms.TextBox

        ThisUnitPhysicalData.Length = txtLength.Text
        ThisUnitPhysicalData.Width = txtWidth.Text
        ThisUnitPhysicalData.Height = txtHeight.Text
        ThisUnitPhysicalData.BaseUnitWeight = txtBUWeight.Text
        ThisUnitPhysicalData.RigWeight = txtRigWeight.Text
        ThisUnitPhysicalData.OpWeight = txtOpWeight.Text
        ThisChillerMainPerf.OpWeight = txtOpWeight.Text
        ThisChillerMainPerf.RigWeight = txtRigWeight.Text
        ThisUnitPhysicalData.ClrRight = txtRightClear.Text
        ThisUnitPhysicalData.ClrTop = txtTopClear.Text
        ThisUnitPhysicalData.ClrFront = txtFrontClear.Text
        ThisUnitPhysicalData.ClrBottom = txtBottomClear.Text
        ThisUnitPhysicalData.ClrBack = txtBackClear.Text
        ThisUnitPhysicalData.ClrLeft = txtLeftClear.Text
        ThisUnitPhysicalData.SFWeight = lblSFMass.Text
        ThisUnitPhysicalData.CalcPoints = nudPointLoads.Value
        ThisUnitPhysicalData.PointLoad.Clear()

        For i = 0 To Val(nudPointLoads.Value) - 1
            myobj = grpPtLoads.Controls.Item("txtPtWt" & Chr(65 + i))
            ThisUnitPhysicalData.PointLoad.Add(myobj.Text)
        Next i
        ThisUnitPhysicalData.ModLoadItem.Clear()
        ThisUnitPhysicalData.ModLoadMass.Clear()
        ThisUnitPhysicalData.ModLoadMod.Clear()

        For i = 0 To lstModWtItem.Items.Count - 1
            ThisUnitPhysicalData.ModLoadMod.Add(lstModWtMod.Items.Item(i))
            ThisUnitPhysicalData.ModLoadItem.Add(lstModWtItem.Items.Item(i))
            ThisUnitPhysicalData.ModLoadMass.Add(lstModWtMass.Items.Item(i))
        Next

        'Prep the certifications page
        chkAHRICert.Checked = True

        If ((ThisUnit.Kingdom = "RTU") And (ThisUnit.Family <> "Series100")) Then
            chkASHRAE90_1.Checked = ThisUnit.CertASHRAE901
            chkISO9001.Checked = ThisUnit.CertISO9001
            chkAHRICert.Checked = ThisUnit.CertAHRI
            chkCSADesign.Checked = ThisUnit.CertCSADesign
            chkETL.Checked = ThisUnit.CertETL
            chkEnergyStar.Checked = ThisUnit.CertEStar
            chkAmericanQ.Checked = ThisUnit.CertAmQ
            chkCSA_C_US.Checked = ThisUnit.CertCSACanUS
            chkETL_C_US.Checked = ThisUnit.CertETLCanUS
            chkCSAGas.Checked = ThisUnit.CertCSAGas

            tabMain.SelectTab("pgCerts")
        Else
            If chkCSAGas.Checked Then ThisUnit.UPGCertifications.Add("CSA Gas")
            btnDonePhysical.Enabled = False
            tabMain.Enabled = False
            Button1.Enabled = True
        End If

    End Sub
    Private Sub btnDoneBaseChiller_Click(sender As Object, e As EventArgs) Handles btnDoneBaseChiller.Click
        ThisChillerMainPerf.NominalTons = txtBCNetCoolCap.Text
        ThisChillerMainPerf.Refrigerant = txtBCRefType.Text

        ThisChillerMainPerf.PINA = txtBCPinA.Text
        ThisChillerMainPerf.PINB = txtBCPinB.Text
        ThisChillerMainPerf.PINC = txtBCPinC.Text
        ThisChillerMainPerf.PIND = txtBCPinD.Text
        ThisChillerMainPerf.PINE = txtBCPinE.Text
        ThisChillerMainPerf.PINF = txtBCPinF.Text
        ThisChillerMainPerf.PING = txtBCPinG.Text
        ThisChillerMainPerf.PINH = txtBCPinH.Text
        ThisChillerMainPerf.PINI = txtBCPinI.Text

        ThisChillerMainPerf.EWT = txtBCEWT.Text
        ThisChillerMainPerf.LWT = txtBCLWT.Text
        ThisChillerMainPerf.Flow = txtBCFlow.Text
        ThisChillerMainPerf.FPD = txtBCFPD.Text
        ThisChillerMainPerf.Fluid = cmbFluid.Text
        ThisChillerMainPerf.FluidPercent = cmbFluidPercent.Text

        ThisChillerMainPerf.FoulingFactor = txtFoulFactor.Text
        ThisChillerMainPerf.EvapVolume = txtBCFluidVol.Text
        ThisChillerMainPerf.MinFlow = txtBCMinFlow.Text
        ThisChillerMainPerf.MaxFlow = txtBCMaxFlow.Text

        ThisChillerMainPerf.Ambient = txtBCAmbient.Text
        ThisChillerMainPerf.Altitude = txtBCAltitude.Text

        ThisChillerMainPerf.EER = txtBCEER.Text
        ThisChillerMainPerf.NPLV = txtBCNPLV.Text

        ThisChillerMainPerf.RigWeight = txtBCRigMass.Text
        ThisChillerMainPerf.OpWeight = txtBCOpMass.Text
        ThisUnitPhysicalData.BaseUnitWeight = txtBCRigMass.Text
        ThisUnitPhysicalData.OpWeight = txtBCOpMass.Text
        ThisUnitPhysicalData.Width = txtChillerWidth.Text
        ThisUnitPhysicalData.Length = txtChillerLength.Text

        ThisChillerMainPerf.RefrigerantCharge = txtBCRefCharge.Text
        ThisChillerMainPerf.FanCount = txtBCFanCount.Text
        If ThisUnit.Family = "YVAA" Then ThisChillerMainPerf.CompType = "VSD Screw"
        If ThisUnit.Family = "YLAA" Then ThisChillerMainPerf.CompType = "Scroll"
        If ThisUnit.Family = "YCAL" Then ThisChillerMainPerf.CompType = "Scroll"
        If ThisUnit.Family = "YCAV" Then ThisChillerMainPerf.CompType = "VSD Screw"
        If ThisUnit.Family = "YCIV" Then ThisChillerMainPerf.CompType = "VSD Screw"

        ThisUnitElecData.CompressorkW = txtChillCompressorkW.Text


        ThisUnitElecData.TotalkW = txtChillTotalkW.Text
        ThisUnitElecData.CommMCA = txtChillMCA.Text
        ThisUnitElecData.CommMOP = txtMinRecFuse.Text

        'Killed these as I switch to FST  Put back?
        'ThisUnitElecData.CommVolts = Mid(ThisChillerMainPerf.ElecDesc, 1, 3)
        'ThisUnitElecData.CommPhase = Mid(ThisChillerMainPerf.ElecDesc, 5, 1)
        'ThisUnitElecData.CommFreq = Mid(ThisChillerMainPerf.ElecDesc, 7)

        ThisUnitElecData.CommMCA = txtChillMCA.Text
        ThisUnitElecData.MinFuse = txtMinRecFuse.Text
        ThisUnitElecData.RecFuse = txtMinRecFuse.Text
        ThisUnitElecData.MaxCB = txtMaxFuseMaxCB.Text
        ThisUnitElecData.CommMOP = txtMaxFuseMaxCB.Text
        ThisUnitElecData.MaxDE = txtMaxDE.Text
        ThisUnitElecData.SCCR = txtChillSCCR.Text
        ThisUnitElecData.WiresPerPhase = txtChillLugs.Text
        ThisUnitElecData.LugSize = txtChillWireSize.Text
        ThisUnitElecData.PowerFactor = txtChillPowerFactorStarter.Text
        ThisUnitElecData.ControlkVA = txtChillControlkVA.Text
        ThisUnitElecData.StarterType = txtChillPowerFactorStarter.Text


        tabMain.SelectTab("pgModifications")

    End Sub
    Private Sub cmbFluid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFluid.SelectedIndexChanged
        If cmbFluid.Text = "Water" Then
            lblFluidPercent.Visible = False
            cmbFluidPercent.Text = "100%"
            cmbFluidPercent.Visible = False
        Else
            lblFluidPercent.Visible = True
            cmbFluidPercent.Text = "30%"
            cmbFluidPercent.Visible = True
        End If
    End Sub

    Private Sub GuessNominalTonsODSplit()
        txtNominalTons.Text = Trim(Mid(txtModelNumber.Text, 2, 2))
    End Sub


    Private Sub ImportFromYCAVSource()
        ThisUnit.ImportYCAVData()
        txtUnitTag.Text = ThisUnit.uTag
        txtQty.Text = ThisUnit.Quantity
        txtBrandModelNumber.Text = ThisUnit.BrandModelNumber


    End Sub

    Private Sub ImportFromYLAASource()
        ThisUnit.ImportYLAAData()
        txtUnitTag.Text = ThisUnit.uTag
        txtQty.Text = ThisUnit.Quantity
        txtBrandModelNumber.Text = ThisUnit.BrandModelNumber
    End Sub
    Private Sub ImportFromYPALSource()
        ThisUnit.ImportYPALData()
        ThisYPALPerf.ImportYPALData()

        txtUnitTag.Text = ThisUnit.uTag
        txtQty.Text = ThisUnit.Quantity
        txtBrandModelNumber.Text = ThisUnit.BrandModelNumber
        txtYPALUnitSize.Text = ThisYPALPerf.UnitSize

        ThisUnitCoolPerf.ImportYPALData()
        ThisUnitSFanPerf.ImportYPALData()
        ThisUnitRXPerf.ImportYPALData()
        'ThisUnitSFanPerf.ImportYPALStatic()

    End Sub
    Private Sub GuessNominalTonsUPG()
        Dim S40Digit2 As String

        Select Case ThisUnit.Family
            Case Is = "Series40"
                S40Digit2 = Mid(txtModelNumber.Text, 2, 1)
                If S40Digit2 = "2" Then
                    txtNominalTons.Text = "25"
                Else
                    txtNominalTons.Text = Trim(Str(Val(S40Digit2) * 10))
                End If

            Case Is = "Series20"
                Select Case Mid(txtModelNumber.Text, 2, 2)
                    Case Is = "15"
                        txtNominalTons.Text = "15"
                    Case Is = "18"
                        txtNominalTons.Text = "17.5"
                    Case Is = "20"
                        txtNominalTons.Text = "20"
                    Case Is = "25"
                        txtNominalTons.Text = "25"
                End Select
            Case Is = "Series10"
                Select Case ThisUnit.Brand
                    Case Is = "Lux"

                        If Mid(txtModelNumber.Text, 4, 5) = "A3" Then
                            txtNominalTons.Text = "3"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "A4" Then
                            txtNominalTons.Text = "4"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "A5" Then
                            txtNominalTons.Text = "5"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "06" Then
                            txtNominalTons.Text = "6.5"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "07" Then
                            txtNominalTons.Text = "7.5"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "08" Then
                            txtNominalTons.Text = "8.5"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "10" Then
                            txtNominalTons.Text = "10"
                        End If
                        If Mid(txtModelNumber.Text, 4, 5) = "12" Then
                            txtNominalTons.Text = "12.5"
                        End If

                    Case Else

                        If Mid(txtModelNumber.Text, 1, 2) = "JA" Then
                            txtNominalTons.Text = Str(Val(Mid(txtModelNumber.Text, 3, 1)))
                        End If
                        If Mid(txtModelNumber.Text, 2, 2) = "06" Then
                            txtNominalTons.Text = "6.5"
                        End If
                        If Mid(txtModelNumber.Text, 2, 2) = "07" Then
                            txtNominalTons.Text = "7.5"
                        End If
                        If Mid(txtModelNumber.Text, 2, 2) = "08" Then
                            txtNominalTons.Text = "8.5"
                        End If
                        If Mid(txtModelNumber.Text, 2, 2) = "10" Then
                            txtNominalTons.Text = "10"
                        End If
                        If Mid(txtModelNumber.Text, 2, 2) = "12" Then
                            txtNominalTons.Text = "12.5"
                        End If
                End Select

            Case Is = "Series12"
                If ((Mid(txtModelNumber.Text, 1, 2) = "ZX") Or (Mid(txtModelNumber.Text, 1, 2) = "ZY")) Then
                    If Mid(txtModelNumber.Text, 4, 2) = "04" Then
                        txtNominalTons.Text = "3"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "05" Then
                        txtNominalTons.Text = "4"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "06" Then
                        txtNominalTons.Text = "5"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "07" Then
                        txtNominalTons.Text = "6"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "08" Then
                        txtNominalTons.Text = "7.5"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "09" Then
                        txtNominalTons.Text = "8.5"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "12" Then
                        txtNominalTons.Text = "10"
                    End If
                    If Mid(txtModelNumber.Text, 4, 2) = "14" Then
                        txtNominalTons.Text = "12.5"
                    End If
                End If
            Case Is = "Series5"
                Select Case Mid(txtModelNumber.Text, 2, 2)
                    Case Is = "03"
                        txtNominalTons.Text = "3"
                    Case Is = "04"
                        txtNominalTons.Text = "4"
                    Case Is = "05"
                        txtNominalTons.Text = "5"
                End Select
            Case Is = "Series40ODSplit"
                txtNominalTons.Text = Mid(txtModelNumber.Text, 2, 2)
            Case Is = "Series20ODSplit"
                Select Case Mid(txtModelNumber.Text, 2, 2)
                    Case Is = "07"
                        txtNominalTons.Text = "7.5"
                    Case Is = "10"
                        txtNominalTons.Text = "10"
                    Case Is = "12"
                        txtNominalTons.Text = "12"
                    Case Is = "15"
                        txtNominalTons.Text = "15"
                    Case Is = "20"
                        txtNominalTons.Text = "20"
                    Case Is = "25"
                        txtNominalTons.Text = "25"
                End Select

        End Select
    End Sub

    Private Function GuessJobNumber()
        Dim tempstr As String
        Dim slachloc As Integer
        Dim numericjob As String
        Dim totaljob As String
        If txtJobNumber.Text = "" Then
            tempstr = Mid(txtBaseUnitFile.Text, 4)
            slachloc = InStr(tempstr, "\")
            numericjob = Mid(tempstr, slachloc + 1, 4)
            If IsNumeric(numericjob) Then
                totaljob = Mid(tempstr, slachloc + 1, 5)
            Else
                totaljob = ""
            End If
        Else
            totaljob = txtJobNumber.Text
        End If
        GuessJobNumber = totaljob
    End Function

    Private Sub btnDoneFactOpts_Click(sender As Object, e As EventArgs) Handles btnDoneFactOpts.Click
        Dim i As Integer
        Dim dummy As MsgBoxResult
        If Not (chkBaseUnitGTG.Checked) Then
            dummy = MsgBox("Verify Base Unit Options First.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If
        ThisUnitFactOpts.Clear()

        For i = 0 To lstFactOpts.Items.Count - 1
            ThisUnitFactOpts.Add(lstFactOpts.Items.Item(i))
        Next i

        'After this point sets up the Field Installed Items on the next page
        Call PopulateModGenFieldInstalleds()

        If ThisUnitFieldInst.Count > 0 Then
            'lstFieldInst.ClearSelected()
            lstFieldInst.Items.Clear()

            For i = 0 To ThisUnitFieldInst.Count - 1
                lstFieldInst.Items.Add(ThisUnitFieldInst.Item(i))
            Next
        End If
        tabMain.SelectTab("pgFieldInst")
    End Sub
    Private Sub PopulateModGenFieldInstalleds()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim i As Integer
        Dim ThisCode As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        'ThisUnitFieldInst.Clear() 'I removed this in an attempt to fix the missing Field installed items.

        For i = 0 To ThisUnitCodes.Count - 1
            ThisCode = ThisUnitCodes.Item(i)
            MySQL = "SELECT tblShipWithsRequired.FIOpCode, tblShipWiths.ShipWithItem FROM tblShipWithsRequired INNER JOIN tblShipWiths ON tblShipWithsRequired.FIOpID = tblShipWiths.ID WHERE (((tblShipWithsRequired.FIOpCode)='" & ThisCode & "'))"
            rs.Open(MySQL, con)
            Do While Not (rs.EOF)
                ThisUnitFieldInst.Add(rs.Fields("ShipWithItem").Value & "- (" & ThisCode & ")")
                rs.MoveNext()
            Loop
            rs.Close()
        Next

        For i = 0 To ThisUnitCstmMechCodes.Count - 1
            ThisCode = ThisUnitCstmMechCodes.Item(i)
            MySQL = "SELECT tblShipWithsRequired.FIOpCode, tblShipWiths.ShipWithItem FROM tblShipWithsRequired INNER JOIN tblShipWiths ON tblShipWithsRequired.FIOpID = tblShipWiths.ID WHERE (((tblShipWithsRequired.FIOpCode)='" & ThisCode & "'))"
            rs.Open(MySQL, con)
            Do While Not (rs.EOF)
                ThisUnitFieldInst.Add(rs.Fields("ShipWithItem").Value & "- (" & ThisCode & ")")
                rs.MoveNext()
            Loop
            rs.Close()
        Next i

        For i = 0 To ThisUnitCstmRefCodes.Count - 1
            ThisCode = ThisUnitCstmRefCodes.Item(i)
            MySQL = "SELECT tblShipWithsRequired.FIOpCode, tblShipWiths.ShipWithItem FROM tblShipWithsRequired INNER JOIN tblShipWiths ON tblShipWithsRequired.FIOpID = tblShipWiths.ID WHERE (((tblShipWithsRequired.FIOpCode)='" & ThisCode & "'))"
            rs.Open(MySQL, con)
            Do While Not (rs.EOF)
                ThisUnitFieldInst.Add(rs.Fields("ShipWithItem").Value & "- (" & ThisCode & ")")
                rs.MoveNext()
            Loop
            rs.Close()
        Next i

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnAddFactOpt_Click(sender As Object, e As EventArgs) Handles btnAddFactOpt.Click
        If txtNewFactOpt.Text <> "" Then

            lstFactOpts.Items.Add(txtNewFactOpt.Text)
            txtNewFactOpt.Text = ""

            'If lstFactOpts.Items.Item(0) = "None" Then
            'lstFactOpts.Items.Clear()
            'lstFactOpts.Items.Add(txtNewFactOpt.Text)
            'txtNewFactOpt.Text = ""
            'Else
            'lstFactOpts.Items.Add(txtNewFactOpt.Text)
            'txtNewFactOpt.Text = ""
            'End If
        End If
    End Sub
    Private Sub btnDelFactOpt_Click(sender As Object, e As EventArgs) Handles btnDelFactOpt.Click
        lstFactOpts.Items.Remove(lstFactOpts.SelectedItem)
        If lstFactOpts.Items.Count = 0 Then
            lstFactOpts.Items.Add("None")
        End If
    End Sub
    Private Sub btnDoneFieldInst_Click(sender As Object, e As EventArgs) Handles btnDoneFieldInst.Click
        Dim i As Integer

        ThisUnitFieldInst.Clear()

        For i = 0 To lstFieldInst.Items.Count - 1
            ThisUnitFieldInst.Add(lstFieldInst.Items.Item(i))
        Next i


        'Prep the Warranty Tab
        opt1YrParts.Checked = ThisUnitWarrTest.Parts1yr
        opt5YrParts.Checked = ThisUnitWarrTest.Parts5yr
        opt1YrLabor.Checked = ThisUnitWarrTest.Labor1yr
        opt5YrLabor.Checked = ThisUnitWarrTest.Labor5yr

        Select Case ThisUnit.Family
            Case Is = "Series10"
                If Mid(ThisUnit.ModelNumber, 6, 1) = "C" Then
                    optNoGasHx.Checked = True
                Else
                    If Mid(ThisUnit.ModelNumber, 6, 1) = "S" Then
                        opt15YrSSHx.Checked = True
                    Else
                        opt10YrAlHX.Checked = True
                    End If
                End If
                opt5YrComps.Checked = True
            Case Is = "Series20"
                If Mid(ThisUnit.ModelNumber, 6, 1) = "C" Then
                    optNoGasHx.Checked = True
                Else
                    If Mid(ThisUnit.ModelNumber, 6, 1) = "S" Then
                        opt15YrSSHx.Checked = True
                    Else
                        opt10YrAlHX.Checked = True
                    End If
                End If
                opt5YrComps.Checked = True
            Case Is = "Series40"
                opt1YrComps.Checked = True
                optNoGasHx.Checked = True
            Case Is = "Series100"
                optNoGasHx.Checked = True
                opt5YrComps.Checked = True
                grpGasHeatWarrType.Visible = False
                grpCompEHeatWarrText.Visible = False
            Case Is = "Series20ODSplit"
                optNoGasHx.Checked = True
                opt5YrComps.Checked = True
                grpGasHeatWarrType.Visible = False
                grpCompEHeatWarrText.Visible = False
            Case Is = "Select"
                opt5YrComps.Checked = True
                If Mid(ThisUnit.ModelNumber, 5, 1) = "C" Then
                    optNoGasHx.Checked = True
                Else
                    If Mid(ThisUnit.ModelNumber, 5, 1) = "S" Then
                        opt15YrSSHx.Checked = True
                    Else
                        opt10YrAlHX.Checked = True
                    End If
                End If
            Case Is = "Choice"
                opt5YrComps.Checked = True
                If Mid(ThisUnit.ModelNumber, 5, 1) = "C" Then
                    optNoGasHx.Checked = True
                Else
                    If ((Mid(ThisUnit.ModelNumber, 5, 1) = "S") Or (Mid(ThisUnit.ModelNumber, 5, 1) = "T")) Then
                        opt15YrSSHx.Checked = True
                    Else
                        opt10YrAlHX.Checked = True
                    End If
                End If
            Case Is = "Premier"
                opt5YrComps.Checked = True
                If Mid(ThisUnit.ModelNumber, 5, 1) = "A" Then
                    optNoGasHx.Checked = True
                Else
                    If ((Mid(ThisUnit.ModelNumber, 5, 1) = "C") Or (Mid(ThisUnit.ModelNumber, 5, 1) = "G")) Then
                        opt15YrSSHx.Checked = True
                    Else
                        opt10YrAlHX.Checked = True
                    End If
                End If
        End Select

        If ThisUnit.Kingdom = "Chiller" Then
            optNoGasHx.Checked = True
            grpGasHeatWarrType.Visible = False

        End If

        If ThisUnitWarrTest.RefTest Then
            If ThisUnit.Family = "Series20ODSplit" Then
                ThisUnitWarrTest.RefTest = False
                ThisUnitWarrTest.RefInsp = True
            End If
        End If

        clbTestList.SetItemChecked(0, ThisUnitWarrTest.QA)
        clbTestList.SetItemChecked(1, ThisUnitWarrTest.AirflowTest)
        clbTestList.SetItemChecked(2, ThisUnitWarrTest.CoilTest)
        clbTestList.SetItemChecked(3, ThisUnitWarrTest.CtrlTest)
        clbTestList.SetItemChecked(4, ThisUnitWarrTest.MotorTest)
        clbTestList.SetItemChecked(5, ThisUnitWarrTest.EHeatTest)
        clbTestList.SetItemChecked(6, ThisUnitWarrTest.GHeatTest)
        clbTestList.SetItemChecked(7, ThisUnitWarrTest.GasTrainTest)
        clbTestList.SetItemChecked(8, ThisUnitWarrTest.HydroPress)
        clbTestList.SetItemChecked(9, ThisUnitWarrTest.RefTest)
        clbTestList.SetItemChecked(10, ThisUnitWarrTest.RefInsp)

        tabMain.SelectTab("pgWarranty")
    End Sub
    Private Sub btnAddFieldInst_Click(sender As Object, e As EventArgs) Handles btnAddFieldInst.Click

        If txtNewFieldInst.Text <> "" Then
            If lstFieldInst.Items.Count = 0 Then lstFieldInst.Items.Add(txtNewFieldInst.Text)
            If lstFieldInst.Items.Item(0) = "None" Then
                lstFieldInst.Items.Clear()
                lstFieldInst.Items.Add(txtNewFieldInst.Text)
                txtNewFactOpt.Text = ""
            Else
                lstFieldInst.Items.Add(txtNewFieldInst.Text)
                txtNewFieldInst.Text = ""
            End If
        End If


    End Sub
    Private Sub btnDelFieldInst_Click(sender As Object, e As EventArgs) Handles btnDelFieldInst.Click
        lstFieldInst.Items.Remove(lstFieldInst.SelectedItem)
        If lstFieldInst.Items.Count = 0 Then
            lstFieldInst.Items.Add("None")
        End If
    End Sub
    Private Sub btnDoneConns_Click(sender As Object, e As EventArgs) Handles btnDoneConns.Click
        If optNoComms.Checked = True Then ThisUnit.CommNodes = "0"
        If optOneNodeComms.Checked = True Then ThisUnit.CommNodes = "1"
        If optTwoNodeComms.Checked = True Then ThisUnit.CommNodes = "2"
        tabMain.SelectTab("pgShipping")

    End Sub

    Private Sub PrepUnitFilter()
        Dim SugTags As String
        Dim ArrTags() As String
        Dim i, TargetID As Integer
        Dim dummy As MsgBoxResult

        Select Case ThisUnitHeatPerf.HeatType
            Case Is = "Gas Heat"
                txtUnitSuggestedTags.Text = txtUnitSuggestedTags.Text & " GasHeat"
            Case Is = "Electric"
                txtUnitSuggestedTags.Text = txtUnitSuggestedTags.Text & " NoHeat"
            Case Is = "Hot Water"
                txtUnitSuggestedTags.Text = txtUnitSuggestedTags.Text & " HWHeat"
            Case Is = "None"
                txtUnitSuggestedTags.Text = txtUnitSuggestedTags.Text & " SteamHeat"
            Case Is = "Steam"
                txtUnitSuggestedTags.Text = txtUnitSuggestedTags.Text & " Heatco"
            Case Else
                dummy = MsgBox("Unexpected Heat Type: " & ThisUnitHeatPerf.HeatType & vbCrLf & "In PrepUnitFilter subroutine. Continue or Cancel program", vbOKCancel, "Fisen Unit Generator")
                If dummy = vbCancel Then End
        End Select

        If txtUnitSuggestedTags.Text = "" Then Exit Sub
        SugTags = Trim(txtUnitSuggestedTags.Text)
        ArrTags = SugTags.Split(" ")
        For i = 0 To ArrTags.Length - 1
            TargetID = lstUnitTagstoApply.FindString(ArrTags(i))
            If TargetID <> -1 Then
                lstUnitTagstoApply.SetSelected(TargetID, True)
            End If
        Next
    End Sub
    Private Sub btnDoneWarranty_Click(sender As Object, e As EventArgs) Handles btnDoneWarranty.Click
        ThisUnitWarrTest.Parts1yr = opt1YrParts.Checked
        ThisUnitWarrTest.Parts5yr = opt5YrParts.Checked
        ThisUnitWarrTest.Labor1yr = opt1YrLabor.Checked
        ThisUnitWarrTest.Labor5yr = opt5YrLabor.Checked

        ThisUnitWarrTest.QA = clbTestList.GetItemChecked(0)
        ThisUnitWarrTest.AirflowTest = clbTestList.GetItemChecked(1)
        ThisUnitWarrTest.CoilTest = clbTestList.GetItemChecked(2)
        ThisUnitWarrTest.CtrlTest = clbTestList.GetItemChecked(3)
        ThisUnitWarrTest.MotorTest = clbTestList.GetItemChecked(4)
        ThisUnitWarrTest.EHeatTest = clbTestList.GetItemChecked(5)
        ThisUnitWarrTest.GHeatTest = clbTestList.GetItemChecked(6)
        ThisUnitWarrTest.GasTrainTest = clbTestList.GetItemChecked(7)
        ThisUnitWarrTest.HydroPress = clbTestList.GetItemChecked(8)
        ThisUnitWarrTest.RefTest = clbTestList.GetItemChecked(9)
        ThisUnitWarrTest.RefInsp = clbTestList.GetItemChecked(10)

        If opt1YrComps.Checked = True Then
            ThisUnitWarrTest.CompWarr = "One (1) Year Warranty - #Brand# Compressors and Electric Heater Elements"
        Else
            ThisUnitWarrTest.CompWarr = "Five (5) Year Warranty - #Brand# Compressors and Electric Heater Elements"
        End If

        If opt10YrAlHX.Checked = True Then
            ThisUnitWarrTest.HXWarr = "Ten (10) Year Warranty - Aluminized Steel Tubular Heat Exchangers"
        End If

        If opt15YrSSHx.Checked = True Then
            ThisUnitWarrTest.HXWarr = "Fifteen (15) Year Warranty - Stainless Steel Tubular Heat Exchangers"
        End If

        If opt10YrSSHx.Checked = True Then
            ThisUnitWarrTest.HXWarr = "Ten (10) Year Warranty - Stainless Steel Tubular Heat Exchangers"
        End If

        If optNoGasHx.Checked = True Then
            ThisUnitWarrTest.HXWarr = "."
        End If

        Dim i As Integer

        Call LoadApplicableDrawings()
        Call PrepUnitFilter()

        If ThisUnitUnitDrawings.Count <> 0 Then
            For i = 0 To ThisUnitUnitDrawings.Count - 1
                lstUsingDwgs.Items.Add(ThisUnitUnitDrawings.Item(i))
            Next i
        End If

        tabMain.SelectTab("pgUnitDrawing")
    End Sub
    Private Sub btnDoneConstruction_Click(sender As Object, e As EventArgs) Handles btnDoneConstruction.Click

        If Not (optShippingNoNotes.Checked) Then
            ThisUnitMods.Add("Shipping")
            ThisUnitCodes.Add("910000")
        End If

        If optShippingNoShrink.Checked Then ThisUnitCodes.Add("910001") 'No Shring Wrap
        If optShippingFisenShrink.Checked Then ThisUnitCodes.Add("910002") 'shrink wrap

        If Not (optFieldWorkNoNotes.Checked) Then
            ThisUnitMods.Add("FieldWork")
            ThisUnitCodes.Add("SDF000")
        End If

        If optFieldWorkNoOnSiteSel.Checked Then ThisUnitCodes.Add("SDF901") 'No Assistance
        If optFieldWork1DayOnSiteSel.Checked Then ThisUnitCodes.Add("SDF902") '1 day assistance

        Select Case ThisUnit.Kingdom
            Case Is = "Chiller"
                tabMain.SelectTab("pgCHW")
            Case Else
                Call CoolPerfPrep()
                tabMain.SelectTab("pgCooling")
        End Select

    End Sub
    Private Sub lstAvailDwgs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailDwgs.SelectedIndexChanged
        Dim TempVar As String
        If lstAvailDwgs.SelectedIndex >= 0 Then
            txtDwgDesc.Text = DwgDesc(lstAvailDwgs.SelectedIndex)
            TempVar = UnitWMFPAth.Item(lstAvailDwgs.SelectedIndex)
            picUnitPreview.LoadAsync(TempVar)
        End If


    End Sub
    Private Sub btnUnitDwgAdd_Click(sender As Object, e As EventArgs) Handles btnUnitDwgAdd.Click
        Dim i As Integer
        Dim dontdoit As Boolean

        dontdoit = False

        If lstUsingDwgs.Items.Count > 0 Then
            For i = 0 To lstUsingDwgs.Items.Count - 1
                If lstUsingDwgs.Items.Item(i) = lstAvailDwgs.Text Then
                    dontdoit = True
                End If
            Next
        End If
        If Not (dontdoit) Then
            lstUsingDwgs.Items.Add(lstAvailDwgs.Text)
        End If
        lstAvailDwgs.ClearSelected()
        txtDwgDesc.Text = ""
        If optInsertUnitDrawing.Checked Then btnUnitDwgAdd.Enabled = False
        If lstUsingDwgs.Items.Count > 1 Then btnUnitDwgAdd.Enabled = False
    End Sub
    Private Sub btnUnitDwgDel_Click(sender As Object, e As EventArgs) Handles btnUnitDwgDel.Click
        lstUsingDwgs.Items.Remove(lstUsingDwgs.SelectedItem)
        If lstUsingDwgs.Items.Count = 0 Then btnUnitDwgAdd.Enabled = True
    End Sub
    Private Sub btnUnitDwgDelAll_Click(sender As Object, e As EventArgs) Handles btnUnitDwgDelAll.Click
        lstUsingDwgs.Items.Clear()
        If lstUsingDwgs.Items.Count = 0 Then btnUnitDwgAdd.Enabled = True
    End Sub
    Private Sub btnDoneUnitDwg_Click(sender As Object, e As EventArgs) Handles btnDoneUnitDwg.Click
        Dim i As Integer
        Dim NextShouldBeHydro As Boolean
        Dim Dummy As MsgBoxResult


        If lstUsingDwgs.Items.Count = 0 Then
            Dummy = MsgBox("Are you certain you don't want a unit drawing?", vbYesNo, "Fisen Unit Generator")
            If Dummy = vbNo Then Exit Sub
        End If

        NextShouldBeHydro = False
        ThisUnitUnitDrawings.Clear()

        If optCopyUnitDwgNow.Checked = True Then
            ThisUnitUnitDrawings.Add(lstUsingDwgs.Items.Item(i))
            ThisUnitUnitDrawingsAction.Add("Submittal")
            Call CopyUnitDrawings(lstUsingDwgs.Items.Item(i))
        Else
            For i = 0 To lstUsingDwgs.Items.Count - 1
                If optInsertUnitDrawing.Checked = True Then
                    ThisUnitUnitDrawings.Add(lstUsingDwgs.Items.Item(i))
                    ThisUnitUnitDrawingsAction.Add("Submittal")
                End If

                If optFlagUnitDrawing.Checked = True Then
                    ThisUnitUnitDrawings.Add(lstUsingDwgs.Items.Item(i))
                    ThisUnitUnitDrawingsAction.Add("SubmittalFlaggedCopy")

                End If

            Next i
        End If



        txtInletSize.Text = ThisUnitHydroData.InletSize
        txtOutletSize.Text = ThisUnitHydroData.OutletSize
        For i = 0 To ThisUnitMods.Count - 1
            If ThisUnitMods.Item(i) = "HWCoil" Then NextShouldBeHydro = True
            If ThisUnitMods.Item(i) = "PipePkg" Then NextShouldBeHydro = True
            If ThisUnitMods.Item(i) = "SteamCoil" Then NextShouldBeHydro = True
            If ((ThisUnitMods.Item(i) = "CstmCoil")) Then
                NextShouldBeHydro = True
                txtInletSize.Text = ThisUnitCstmCoilPerf.InletConn
                txtOutletSize.Text = ThisUnitCstmCoilPerf.OutletConn
            End If
        Next
        If ThisUnitHydro.Count <> 0 Then
            For i = 0 To ThisUnitHydro.Count - 1
                lstUsingHydro.Items.Add(ThisUnitHydro.Item(i))
            Next i
        End If

        If NextShouldBeHydro Then
            Call LoadApplicableHydro()
            tabMain.SelectTab("pgHydronics")
        Else
            tabMain.SelectTab("pgValveSchedule")
        End If

    End Sub
    Private Sub CopyUnitDrawings(DrawingName2Copy As String)

        Dim FileBase As String
        Dim FileName As String
        Dim SourcePath As String
        Dim ProjectPath As String
        Dim TargetPath As String

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

        MySQL = "SELECT * FROM tblUnitDrawings"
        rs.Open(MySQL, con)

        FileBase = ThisUnit.ResourcePath

        ProjectPath = txtProjectDirectory.Text
        TargetPath = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"

        rs.Find("PlainName='" & DrawingName2Copy & "'")
        FileName = rs.Fields("DrawingPath").Value
        FileName = FileName & rs.Fields("DrawingName").Value
        SourcePath = FileBase & "\BaseUnit\Drawings" & FileName
        TargetPath = txtProjectDirectory.Text
        TargetPath = TargetPath & Trim(ThisUnit.JobNumber) & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\" & Trim(ThisUnit.JobNumber) & "-" & ThisUnit.UnitNumber & " - Submittal Drawing " & Ver2FileVer(txtUnitVersion.Text) & ".dwg"
        FileCopy(SourcePath, TargetPath)

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnDoneHydronics_Click(sender As Object, e As EventArgs) Handles btnDoneHydronics.Click
        Call DoneHydronicsTab()
        tabMain.SelectTab("pgValveSchedule")
    End Sub
    Private Sub DoneHydronicsTab()
        ThisUnitHydro.Clear()

        If optHydroCopyNow.Checked = True Then
            Call CopyHydroDrawings()
        Else
            For i = 0 To lstUsingHydro.Items.Count - 1
                If optHydroInsertOnly.Checked = True Then
                    ThisUnitHydro.Add(lstUsingHydro.Items.Item(i))
                End If

                If optHydroFlagforCopy.Checked = True Then
                    ThisUnitHydro.Add(lstUsingHydro.Items.Item(i))
                    Call CopyHydroDrawings()
                End If

            Next i
        End If

        If ThisUnitCstmCoilPerf.CoilStyle = "Preheat Reclaim Coil - Glycol" Then
            ThisUnitCstmCoilPerf.InletConn = txtInletSize.Text
            ThisUnitCstmCoilPerf.OutletConn = txtOutletSize.Text
        End If
        ThisUnitHydroData.InletSize = txtInletSize.Text
        ThisUnitHydroData.OutletSize = txtOutletSize.Text

    End Sub

    Private Sub CopyHydroDrawings()
        Dim i As Integer
        Dim FileBase As String
        Dim FileName As String
        Dim SourcePath As String
        Dim ProjectPath As String
        Dim TargetPath As String
        Dim TargetName As String

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

        MySQL = "SELECT * FROM tblHydroDrawings"
        rs.Open(MySQL, con)

        FileBase = ThisUnit.ResourcePath


        ProjectPath = txtProjectDirectory.Text
        TargetPath = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        For i = 0 To ThisUnitHydro.Count - 1
            rs.Find("PlainName='" & ThisUnitHydro.Item(i) & "'")
            FileName = rs.Fields("DrawingPath").Value
            FileName = FileName & rs.Fields("DrawingName").Value
            SourcePath = FileBase & "\HydroDrawings" & FileName
            TargetName = rs.Fields("DrawingName").Value
            TargetName = Mid(TargetName, 1, InStr(TargetName, ".") - 1) & " " & Ver2FileVer(txtUnitVersion.Text) & Mid(TargetName, InStr(TargetName, "."))
            TargetPath = TargetPath & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - Hydronics Drawing Basis-" & Trim(Str(i)) & " - " & TargetName

            FileCopy(SourcePath, TargetPath)
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub btnHydroAdd_Click(sender As Object, e As EventArgs) Handles btnHydroAdd.Click
        Dim i As Integer
        Dim dontdoit As Boolean

        dontdoit = False

        If lstUsingHydro.Items.Count > 0 Then
            For i = 0 To lstUsingHydro.Items.Count - 1
                If lstUsingHydro.Items.Item(i) = lstAvailHydro.Text Then
                    dontdoit = True
                End If
            Next
        End If
        If Not (dontdoit) Then
            lstUsingHydro.Items.Add(lstAvailHydro.Text)
        End If
        lstAvailHydro.ClearSelected()
        txtHydroDesc.Text = ""
    End Sub
    Private Sub btnHydroDel_Click(sender As Object, e As EventArgs) Handles btnHydroDel.Click
        lstUsingHydro.Items.Remove(lstUsingHydro.SelectedItem)
    End Sub
    Private Sub btnHydroDelAll_Click(sender As Object, e As EventArgs) Handles btnHydroDelAll.Click
        lstUsingHydro.Items.Clear()
    End Sub
    Private Sub lstAvailHydro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailHydro.SelectedIndexChanged
        If lstAvailHydro.SelectedIndex >= 0 Then
            txtHydroDesc.Text = HydroDesc(lstAvailHydro.SelectedIndex)
        End If
    End Sub

    Private Sub btnDoneValves_Click(sender As Object, e As EventArgs) Handles btnDoneValves.Click
        Dim Dummy As MsgBoxResult
        Select Case ThisUnit.Kingdom
            Case Is = "Chiller"
                tabMain.SelectTab("pgSequence")
            Case Else
                If chkDebug.Checked Then Dummy = MsgBox("LoadApplicableReferNext") 'RemoveMe 
                Call LoadApplicableRefer()
                If chkDebug.Checked Then Dummy = MsgBox("PrepReferFilterNext") 'RemoveMe 
                Call PrepReferFilter()
                tabMain.SelectTab("pgRefrigeration")
        End Select
    End Sub
    Private Sub PrepReferFilter()
        Dim SugTags As String
        Dim ArrTags() As String
        Dim i, TargetID As Integer

        If txtReferSuggestedTags.Text = "" Then Exit Sub
        SugTags = Trim(txtReferSuggestedTags.Text)
        ArrTags = SugTags.Split(" ")
        For i = 0 To ArrTags.Length - 1
            TargetID = lstReferTagstoApply.FindString(ArrTags(i))
            lstReferTagstoApply.SetSelected(TargetID, True)
        Next

    End Sub
    Private Sub btnDoneAirflow_Click(sender As Object, e As EventArgs) Handles btnDoneAirflow.Click
        Call DoneAirflowTab()
        Call PrepSequenceTab()

        tabMain.SelectTab("pgSequence")
    End Sub

    Private Sub PrepSequenceTab()
        Dim i As Integer

        If My.Settings.UOResearchMode = False Then
            For i = 0 To ThisUnitMods.Count - 1
                lstModsForSoO.Items.Add(ThisUnitMods(i))
            Next
        Else
            Call SetResearchMode()
        End If
    End Sub

    Public Sub SetResearchMode()
        cmdSoOLoadMods.Visible = True
        cmdModsLoadMods.Visible = True
    End Sub

    Private Sub DoneAirflowTab()
        Dim i As Integer
        ThisUnitAirflow.Clear()
        For i = 0 To lstUsingAirflow.Items.Count - 1
            ThisUnitAirflow.Add(lstUsingAirflow.Items.Item(i))
        Next i
        If optReferCopyNow.Checked = True Then
            Call CopyAirflowDrawings()
        Else
            For i = 0 To lstUsingAirflow.Items.Count - 1
                If optAirflowInsertOnly.Checked = True Then
                    ThisUnitAirflow.Add(lstUsingAirflow.Items.Item(i))
                End If

                If optAirflowFlagforCopy.Checked = True Then
                    ThisUnitAirflow.Add(lstUsingAirflow.Items.Item(i))
                    Call CopyAirflowDrawings()
                End If

            Next i
        End If

    End Sub
    Private Sub btnDoneSequence_Click(sender As Object, e As EventArgs) Handles btnDoneSequence.Click
        tabMain.SelectTab("pgPoints")
    End Sub
    Private Sub btnDonePoints_Click(sender As Object, e As EventArgs) Handles btnDonePoints.Click
        Call PopulateEndDeviceDGV()
        tabMain.SelectTab("pgEndDeviceSchedule")
    End Sub
    Private Sub PopulateEndDeviceDGV()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim NewRow As String()
        Dim MyIo As String
        Dim i As Integer

        If ThisUnitEndDevices.Count = 0 Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblEndDevices"
        rs.Open(MySQL, con)

        For i = 0 To ThisUnitEndDevices.Count - 1
            rs.MoveFirst()
            rs.Find("ID=#" & ThisUnitEndDevices.Item(i) & "#")
            If Not rs.EOF Then
                If rs.Fields("EDType").Value = "Sensor" Then MyIo = "Input" Else MyIo = "Output"
                NewRow = {rs.Fields("EDTag").Value, rs.Fields("EDName").Value, rs.Fields("EDClass").Value, MyIo, False}
                dgvEndDevices.Rows.Add(NewRow)
            End If
        Next
    End Sub
    Private Sub btnDoneEndDev_Click(sender As Object, e As EventArgs) Handles btnDoneEndDev.Click
        Dim i As Integer
        Dim temp As String
        Dim MyWeightBox As System.Windows.Forms.TextBox
        Dim dummy As MsgBoxResult
        Dim NewRow As String()

        If Not (optMLBNone.Checked Or optMLB6126.Checked Or optMLB583.Checked Or optMLB812U.Checked Or optMLB560.Checked) Then
            dummy = MsgBox("You must select a controller before continuing.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If

        'Add the controller
        If optMLB6126.Checked Then
            NewRow = {"MLB", "Fisen 6126 Main Logic Board", "Controller", "n/a", False}
        End If
        If optMLB583.Checked Then
            NewRow = {"MLB", "Fisen 583 Main Logic Board", "Controller", "n/a", False}
        End If
        If optMLB812U.Checked Then
            NewRow = {"MLB", "Fisen 812UPro Main Logic Board", "Controller", "n/a", False}
        End If
        If optMLB560.Checked Then
            NewRow = {"MLB", "Fisen 560 Main Logic Board", "Controller", "n/a", False}
        End If

        If Not (optMLBNone.Checked) Then
            dgvEndDevices.Rows.Add(NewRow)
        End If

        If chkMLBExpansion.Checked Then
            If optMLB6126.Checked Then
                NewRow = {"MLB", "Fisen EX8160 Expansion Board", "Controller", "n/a", False}
                dgvEndDevices.Rows.Add(NewRow)
            End If
            If optMLB812U.Checked Then
                dummy = MsgBox("To use the Ex816U choose yes.", vbYesNo, "Selection of Expansion Module")
                If dummy = vbYes Then
                    NewRow = {"MLB", "Fisen EX816U Expansion Logic Board", "Controller", "n/a", False}
                Else
                    NewRow = {"MLB", "Fisen EX48U Expansion Logic Board", "Controller", "n/a", False}
                End If
                dgvEndDevices.Rows.Add(NewRow)
            End If
        End If

        'Prep the weight page for use
        For i = 65 To 84
            temp = "txtBaseWt" & Chr(i)
            MyWeightBox = pgWeights.Controls.Item(temp)

            If ((i - 64) <= ThisUnitPhysicalData.BasePointLoad.Count) Then
                MyWeightBox.Text = ThisUnitPhysicalData.BasePointLoad(i - 65)
            Else
                MyWeightBox.Text = "-"
            End If
        Next i



        tabMain.SelectTab("pgWeights")
    End Sub
    Private Sub btnDoneWeights_Click(sender As Object, e As EventArgs) Handles btnDoneWeights.Click
        Dim i As Integer
        Dim temp As String
        Dim MyWeightBox As System.Windows.Forms.TextBox
        Dim PointLoadCount



        'Prep the weight page for use
        ThisUnitPhysicalData.BasePointLoad.Clear()
        PointLoadCount = 0
        For i = 65 To 84
            temp = "txtBaseWt" & Chr(i)
            MyWeightBox = pgWeights.Controls.Item(temp)
            If MyWeightBox.Text <> "-" Then
                ThisUnitPhysicalData.BasePointLoad.Add(MyWeightBox.Text)
                PointLoadCount = PointLoadCount + 1
            End If

        Next i

        If PointLoadCount = 0 Then Exit Sub

        nudPointLoads.Value = PointLoadCount
        ThisUnitPhysicalData.CalcPoints = PointLoadCount

        'Prep for the connections tab
        Select Case ThisUnit.CommNodes
            Case Is = "0"
                optNoComms.Checked = True
            Case Is = "1"
                optOneNodeComms.Checked = True
            Case Is = "2"
                optTwoNodeComms.Checked = True
        End Select

        If HasHMI() Then optHMIShipLoose.Checked = True
        If HasUMHMI() Then optHMIInstalled.Checked = True

        tabMain.SelectTab("pgConnections")
    End Sub

    Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebug.CheckedChanged
        Dim dummy As MsgBoxResult
        Dim Answer As String

        If chkDebug.Checked = True Then
            If UserID <> "jlevine" Then
                Answer = InputBox("Enter Admin Password:", "Fisen Unit Generator")
            Else
                Answer = "bruno"
            End If

            If Answer <> "bruno" Then
                chkDebug.Checked = False
                dummy = MsgBox("Incorrect Password.")
            Else
                'chkDebug.Enabled = False
                cmdJumpButton.Visible = True
                cmbJumpDest.Visible = True
                cmdDebug.Visible = True
                chkSaveinProjDB.Checked = False

                cmdReloadOldFile.Enabled = True

            End If

            chkInhibitDigConditions.Checked = False
            chkInhibitDigConditions.Visible = True
            chkSaveinProjDB.Checked = False
            chkSaveinProjDB.Visible = True

            My.Settings.UOMoveCuts2SD = False

        End If

        cmbJumpDest.Text = My.Settings.DebugLastModule

    End Sub
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Call TranslateBrandModelNumber()
        If ThisUnit.Kingdom = "RTU" Then
            Call GuessNominalTonsUPG()
        End If
    End Sub
    Private Sub TranslateBrandModelNumber()
        Dim btu As String
        txtModelNumber.Text = txtBrandModelNumber.Text
        Select Case ThisUnit.Family
            Case Is = "Series40"
                txtModelNumber.Text = "V" & Mid(txtBrandModelNumber.Text, 2)
            Case Is = "Series20"
                If cmbBrand.Text = "TMP" Then
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                        Case = "ZK"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZW"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZS"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                    End Select
                End If
                If cmbBrand.Text = "York" Then
                    btu = Mid(txtBrandModelNumber.Text, 3, 3)
                    Select Case btu
                        Case Is = "180"
                            btu = "15"
                        Case Is = "210"
                            btu = "18"
                        Case Is = "240"
                            btu = "20"
                        Case Is = "300"
                            btu = "25"
                        Case Else
                            btu = "xx"
                    End Select
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                        Case = "ZJ"
                            txtModelNumber.Text = "J" & btu & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZR"
                            txtModelNumber.Text = "J" & btu & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZF"
                            txtModelNumber.Text = "J" & btu & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                    End Select
                End If
            Case Is = "Series10"
                If cmbBrand.Text = "JCI" Then
                    btu = Mid(txtBrandModelNumber.Text, 3, 3)
                    Select Case btu
                        Case Is = "037"
                            btu = "03"
                        Case Is = "049"
                            btu = "04"
                        Case Is = "060"
                            btu = "05"
                        Case Is = "072"
                            btu = "06"
                        Case Is = "078"
                            btu = "06"
                        Case Is = "090"
                            btu = "07"
                        Case Is = "96"
                            btu = "08"
                        Case Is = "102"
                            btu = "08"
                        Case Is = "120"
                            btu = "10"
                        Case Is = "150"
                            btu = "12"
                        Case Else
                            btu = "xx"
                    End Select
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)

                        Case = "ZJ"
                            txtModelNumber.Text = "J" & btu & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZR"
                            txtModelNumber.Text = "J" & btu & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZF"
                            txtModelNumber.Text = "J" & btu & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZT"
                            txtModelNumber.Text = "J" & btu & "ZT" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZB"
                            txtModelNumber.Text = "J" & btu & "ZB" & Mid(txtBrandModelNumber.Text, 6)
                    End Select
                End If
                If cmbBrand.Text = "York" Then
                    btu = Mid(txtBrandModelNumber.Text, 3, 3)
                    Select Case btu
                        Case Is = "060"
                            btu = "05"
                        Case Is = "072"
                            btu = "06"
                        Case Is = "090"
                            btu = "07"
                        Case Is = "96"
                            btu = "08"
                        Case Is = "120"
                            btu = "10"
                        Case Is = "150"
                            btu = "12"
                        Case Else
                            btu = "xx"
                    End Select
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)

                        Case = "ZJ"
                            txtModelNumber.Text = "J" & btu & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZR"
                            txtModelNumber.Text = "J" & btu & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZF"
                            txtModelNumber.Text = "J" & btu & "ZF" & Mid(txtBrandModelNumber.Text, 6)

                    End Select
                End If
                If cmbBrand.Text = "FRJ" Then
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                        Case = "ZU"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZW"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZK"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                    End Select
                End If
                If cmbBrand.Text = "TMP" Then
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                        Case = "ZU"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZW"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZK"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZV"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZT" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZS"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZJ"
                            btu = Mid(txtBrandModelNumber.Text, 3, 3)
                            Select Case btu
                                Case Is = "060"
                                    btu = "05"
                                Case Is = "072"
                                    btu = "06"
                                Case Is = "090"
                                    btu = "07"
                                Case Is = "96"
                                    btu = "08"
                                Case Is = "120"
                                    btu = "10"
                                Case Is = "150"
                                    btu = "12"
                                Case Else
                                    btu = "xx"
                            End Select
                            Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                                Case = "ZJ"
                                    txtModelNumber.Text = "J" & btu & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                                Case = "ZR"
                                    txtModelNumber.Text = "J" & btu & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                                Case = "ZF"
                                    txtModelNumber.Text = "J" & btu & "ZF" & Mid(txtBrandModelNumber.Text, 6)
                            End Select
                    End Select

                End If

                If cmbBrand.Text = "LUX" Then
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)
                        Case = "ZK"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZV"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZT" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZS"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZH" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZU"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZH" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZW"
                            txtModelNumber.Text = "J" & Mid(txtBrandModelNumber.Text, 4, 2) & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                    End Select
                End If

            Case Is = "Series5"
                If cmbBrand.Text = "York" Then
                    btu = Mid(txtBrandModelNumber.Text, 3, 3)
                    Select Case btu
                        Case Is = "036"
                            btu = "03"
                        Case Is = "048"
                            btu = "04"
                        Case Is = "060"
                            btu = "05"
                        Case Else
                            btu = "xx"
                    End Select
                    Select Case Mid(txtBrandModelNumber.Text, 1, 2)

                        Case = "ZJ"
                            txtModelNumber.Text = "J" & btu & "ZJ" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZR"
                            txtModelNumber.Text = "J" & btu & "ZR" & Mid(txtBrandModelNumber.Text, 6)
                        Case = "ZE"
                            txtModelNumber.Text = "J" & btu & "ZE" & Mid(txtBrandModelNumber.Text, 6)

                    End Select
                End If

            Case Is = "Select"
                If cmbBrand.Text = "TMP" Then
                    txtModelNumber.Text = "JV" & Mid(txtBrandModelNumber.Text, 3)
                End If
                If cmbBrand.Text = "York" Then
                    txtModelNumber.Text = "JV" & Mid(txtBrandModelNumber.Text, 3)
                End If
            Case Is = "Choice"
                txtModelNumber.Text = "AD" & Mid(txtBrandModelNumber.Text, 3)
        End Select


    End Sub
    Private Sub btnNoReheat_Click(sender As Object, e As EventArgs) Handles btnNoReheat.Click
        ThisUnitRHPerf.NoReheat()
        txtRHControlType.Text = ThisUnitRHPerf.ControlType
        txtRHCap.Text = ThisUnitRHPerf.RHCapacity
        txtRHAirflow.Text = ThisUnitRHPerf.RHAirflow
        txtRHEAT.Text = ThisUnitRHPerf.EAT
        txtRHLAT.Text = ThisUnitRHPerf.LAT
        txtRHDeltaT.Text = ThisUnitRHPerf.DeltaT
        txtDHCap.Text = ThisUnitRHPerf.DHCapacity
        txtRHCoilAPD.Text = ThisUnitRHPerf.CoilAPD
        txtPipeStyle.Text = ThisUnitRHPerf.PipingStyle
    End Sub
    Private Sub btnNoRXFan_Click(sender As Object, e As EventArgs) Handles btnNoRXFan.Click
        ThisUnitRXPerf.NoRXFans()
        txtRXAirflow.Text = ThisUnitRXPerf.Airflow
        txtRXESP.Text = ThisUnitRXPerf.ESP
        txtRXTSP.Text = ThisUnitRXPerf.TSP
        txtRXRPM.Text = ThisUnitRXPerf.RPM
        txtRXMhp.Text = ThisUnitRXPerf.MotorHP
        txtRXFanhp.Text = ThisUnitRXPerf.BrakeHP
        txtRXFanPower.Text = ThisUnitRXPerf.kWPower
        txtRXDriveType.Text = ThisUnitRXPerf.DriveType
        txtRXDuctLoc.Text = ThisUnitRXPerf.DuctLoc
    End Sub

    Private Sub btnDoneCerts_Click(sender As Object, e As EventArgs) Handles btnDoneCerts.Click

        If chkASHRAE90_1.Checked Then ThisUnit.UPGCertifications.Add("ASHRAE 90.1")
        If chkISO9001.Checked Then ThisUnit.UPGCertifications.Add("ISO 9001")
        If chkAHRICert.Checked Then ThisUnit.UPGCertifications.Add("AHRI")
        If chkCSADesign.Checked Then ThisUnit.UPGCertifications.Add("CSA Design")
        If chkETL.Checked Then ThisUnit.UPGCertifications.Add("ETL")
        If chkEnergyStar.Checked Then ThisUnit.UPGCertifications.Add("Energy Star")
        If chkAmericanQ.Checked Then ThisUnit.UPGCertifications.Add("American Quality")
        If chkCSA_C_US.Checked Then ThisUnit.UPGCertifications.Add("CSA Canada")
        If chkETL_C_US.Checked Then ThisUnit.UPGCertifications.Add("ETL Canada")
        If chkCSAGas.Checked Then ThisUnit.UPGCertifications.Add("CSA Gas")

        btnDoneCerts.Enabled = False
        If My.Settings.UOMoveCuts2SD Then
            tabMain.SelectTab("pgCutSheets")
        Else
            tabMain.Enabled = False
            Button1.Enabled = True
        End If


    End Sub

    Private Sub btnDoneCHW_Click(sender As Object, e As EventArgs) Handles btnDoneCHW.Click
        Call PreLoadElec()
        Call UpdateTheMCA()
        tabMain.SelectTab("pgElec")
    End Sub

    Private Sub picASHRAE90_1_Click(sender As Object, e As EventArgs) Handles picASHRAE90_1.Click
        chkASHRAE90_1.Checked = Not (chkASHRAE90_1.Checked)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        chkAmericanQ.Checked = Not (chkAmericanQ.Checked)
    End Sub

    Private Sub picISO9001_Click(sender As Object, e As EventArgs) Handles picISO9001.Click
        chkISO9001.Checked = Not (chkISO9001.Checked)
    End Sub

    Private Sub picAHRICert_Click(sender As Object, e As EventArgs) Handles picAHRICert.Click
        chkAHRICert.Checked = Not (chkAHRICert.Checked)
    End Sub

    Private Sub picETL_Click(sender As Object, e As EventArgs) Handles picETL.Click
        chkETL.Checked = Not (chkETL.Checked)
    End Sub

    Private Sub picCSAGas_Click(sender As Object, e As EventArgs) Handles picCSAGas.Click
        chkCSAGas.Checked = Not (chkCSAGas.Checked)
    End Sub

    Private Sub picETL_C_US_Click(sender As Object, e As EventArgs) Handles picETL_C_US.Click
        chkETL_C_US.Checked = Not (chkETL_C_US.Checked)
    End Sub

    Private Sub picCSA_C_US_Click(sender As Object, e As EventArgs) Handles picCSA_C_US.Click
        chkCSA_C_US.Checked = Not (chkCSA_C_US.Checked)
    End Sub

    Private Sub picEStar_Click(sender As Object, e As EventArgs) Handles picEStar.Click
        chkEnergyStar.Checked = Not (chkEnergyStar.Checked)
    End Sub

    Private Sub picCSADesignCert_Click(sender As Object, e As EventArgs) Handles picCSADesignCert.Click
        chkCSADesign.Checked = Not (chkCSADesign.Checked)
    End Sub

    Private Sub btnDoneRefrigeration_Click(sender As Object, e As EventArgs) Handles btnDoneRefrigeration.Click
        Dim Dummy As MsgBoxResult

        If ((txtReferSuggestedTags.Text <> "") And (lstUsingRefer.Items.Count = 0)) Then
            Dummy = MsgBox("Are you certain you don't want a refrigeration drawing?", vbYesNo, "Fisen Unit Generator")
            If Dummy = vbNo Then Exit Sub
        End If

        Call DoneRefrigerationTab()
        Call LoadApplicableAirflow()

        tabMain.SelectTab("pgAirflow")
    End Sub



    Private Sub DoneRefrigerationTab()
        ThisUnitRefer.Clear()

        If optReferCopyNow.Checked = True Then
            Call CopyReferDrawings()
        Else
            For i = 0 To lstUsingRefer.Items.Count - 1
                If optReferInsertOnly.Checked = True Then
                    ThisUnitRefer.Add(lstUsingRefer.Items.Item(i))
                End If

                If optReferFlagforCopy.Checked = True Then
                    ThisUnitRefer.Add(lstUsingRefer.Items.Item(i))
                    Call CopyReferDrawings()
                End If

            Next i
        End If

    End Sub

    Private Sub CopyAirflowDrawings()
        Dim i As Integer
        Dim FileBase As String
        Dim FileName As String
        Dim SourcePath As String
        Dim ProjectPath As String
        Dim TargetPath As String

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

        MySQL = "SELECT * FROM tblAirflowDiagrams"
        rs.Open(MySQL, con)

        FileBase = ThisUnit.ResourcePath

        ProjectPath = txtProjectDirectory.Text
        'If the following errors out make a test to see if the final \ is there.
        'TargetPath = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        TargetPath = ProjectPath & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        For i = 0 To ThisUnitRefer.Count - 1
            rs.Find("PlainName='" & ThisUnitAirflow.Item(i) & "'")
            FileName = rs.Fields("DrawingPath").Value
            FileName = FileName & rs.Fields("DrawingName").Value
            SourcePath = FileBase & "\AirflowDiagrams" & FileName
            TargetPath = TargetPath & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - Airflow Diagram " & Trim(Str(i)) & " " & Ver2FileVer(txtUnitVersion.Text) & ".dwg"
            FileCopy(SourcePath, TargetPath)
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub CopyReferDrawings()
        Dim i As Integer
        Dim FileBase As String
        Dim FileName As String
        Dim SourcePath As String
        Dim ProjectPath As String
        Dim TargetPath As String

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

        MySQL = "SELECT * FROM tblReferDrawings"
        rs.Open(MySQL, con)

        FileBase = ThisUnit.ResourcePath

        ProjectPath = txtProjectDirectory.Text
        'If the following errors out make a test to see if the final \ is there.
        'TargetPath = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        TargetPath = ProjectPath & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        For i = 0 To ThisUnitRefer.Count - 1
            rs.Find("PlainName='" & ThisUnitRefer.Item(i) & "'")
            FileName = rs.Fields("DrawingPath").Value
            FileName = FileName & rs.Fields("DrawingName").Value
            SourcePath = FileBase & "\ReferDrawings" & FileName
            TargetPath = TargetPath & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & " - Refrigeration Drawing" & Trim(Str(i)) & " " & Ver2FileVer(txtUnitVersion.Text) & ".dwg"
            FileCopy(SourcePath, TargetPath)
        Next

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub


    Private Sub DebugYPALTesting()
        txtProjectName.Text = "Test File"
        txtUnitTag.Text = "RTU-F01"
        txtBrandModelNumber.Text = "TMAL060CVE46BBFSN"
        txtModelNumber.Text = "YPAL060CVE46BBFSN"
        txtNominalTons.Text = "60"
        txtYPALUnitSize.Text = "123x123"
        cmbBrand.Text = "TMP"
    End Sub

    Private Sub optMisc_CheckedChanged(sender As Object, e As EventArgs) Handles optMisc.CheckedChanged
        fraRTU.Enabled = False
        fraAHU.Enabled = False
        fraChiller.Enabled = False
        fraMisc.Enabled = True
    End Sub

    Private Sub btnAddLoadComm_Click(sender As Object, e As EventArgs) Handles btnAddLoadComm.Click
        Dim NewRow As String()

        NewRow = {chkIncludeLoadinCalc.Checked, chkElecHeatLoad.Checked, cmbLoadMode.Text, True, cmbElecLoads.Text, cmbLoadVoltsPhFreq.Text, cmbMotorHPList.Text, txtElecLoadFLA.Text, False, "NEMA"}
        dgvElecLoads.Rows.Add(NewRow)

        chkIncludeLoadinCalc.Checked = False
        chkElecHeatLoad.Checked = False
        cmbLoadMode.Text = "All"
        cmbElecLoads.Text = ""

        cmbLoadVoltsPhFreq.Text = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text
        txtElecLoadFLA.Text = ""
        cmbMotorHPList.Text = "-"

        txtCommMCA.Text = Format(CalculateMCAComm(), "0.0")
        txtCommMOP.Text = Format(CalculateMOPComm(), "0")
        If optEmerNA.Checked = False Then
            txtEmerMCA.Text = Format(CalculateMCAEmer(), "0.0")
            txtEmerMOP.Text = Format(CalculateMOPEmer(), "0")
        End If
    End Sub
    Private Function CalculateMCAComm() As Double
        Dim LoadCount As Integer
        Dim i As Integer
        Dim CommLoad As Boolean
        Dim IncludeinCalc As Boolean
        Dim maxloadheat As Double
        Dim maxloadcool As Double
        Dim loadsumheat As Double
        Dim loadsumcool As Double
        Dim CurrentMode As String
        Dim mcaheat As Double
        Dim mcacool As Double
        Dim mcatouse As Double

        maxloadheat = -1
        maxloadcool = -1
        loadsumheat = 0
        loadsumcool = 0

        LoadCount = dgvElecLoads.RowCount
        For i = 0 To LoadCount - 1
            CommLoad = dgvElecLoads.Rows(i).Cells.Item(3).Value
            IncludeinCalc = dgvElecLoads.Rows(i).Cells.Item(0).Value
            If CommLoad And IncludeinCalc Then
                CurrentMode = dgvElecLoads.Rows(i).Cells.Item(2).Value

                If ((CurrentMode = "All") Or (CurrentMode = "Cool")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadcool Then maxloadcool = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumcool = loadsumcool + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If

                If ((CurrentMode = "All") Or (CurrentMode = "Heat")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadheat Then maxloadheat = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumheat = loadsumheat + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If
            End If
        Next
        mcaheat = loadsumheat + 0.25 * maxloadheat
        mcacool = loadsumcool + 0.25 * maxloadcool

        If mcacool > mcaheat Then
            mcatouse = mcacool
        Else
            mcatouse = mcaheat
        End If
        CalculateMCAComm = mcatouse

    End Function
    Private Function CalculateMOPComm() As Double
        Dim LoadCount As Integer
        Dim i As Integer
        Dim CommLoad As Boolean
        Dim IncludeinCalc As Boolean
        Dim maxloadheat As Double
        Dim maxloadcool As Double
        Dim loadsumheat As Double
        Dim loadsumcool As Double
        Dim CurrentMode As String
        Dim mopheat As Double
        Dim mopcool As Double
        Dim moptouse As Double

        maxloadheat = -1
        maxloadcool = -1
        loadsumheat = 0
        loadsumcool = 0

        LoadCount = dgvElecLoads.RowCount
        For i = 0 To LoadCount - 1
            CommLoad = dgvElecLoads.Rows(i).Cells.Item(3).Value
            IncludeinCalc = dgvElecLoads.Rows(i).Cells.Item(0).Value
            If CommLoad And IncludeinCalc Then
                CurrentMode = dgvElecLoads.Rows(i).Cells.Item(2).Value

                If ((CurrentMode = "All") Or (CurrentMode = "Cool")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadcool Then maxloadcool = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumcool = loadsumcool + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If

                If ((CurrentMode = "All") Or (CurrentMode = "Heat")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadheat Then maxloadheat = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumheat = loadsumheat + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If
            End If
        Next
        mopheat = loadsumheat + 1.25 * maxloadheat
        mopcool = loadsumcool + 1.25 * maxloadcool

        If mopcool > mopheat Then
            moptouse = mopcool
        Else
            moptouse = mopheat
        End If
        CalculateMOPComm = RoundDowntoFuseSize(moptouse)

    End Function
    Private Function CalculateMCAEmer() As Double
        Dim LoadCount As Integer
        Dim i As Integer
        Dim EmerLoad As Boolean
        Dim IncludeinCalc As Boolean
        Dim maxloadheat As Double
        Dim maxloadcool As Double
        Dim loadsumheat As Double
        Dim loadsumcool As Double
        Dim CurrentMode As String
        Dim mcaheat As Double
        Dim mcacool As Double
        Dim mcatouse As Double

        maxloadheat = -1
        maxloadcool = -1
        loadsumheat = 0
        loadsumcool = 0

        LoadCount = dgvElecLoads.RowCount
        For i = 0 To LoadCount - 1
            EmerLoad = dgvElecLoads.Rows(i).Cells.Item(8).Value
            IncludeinCalc = dgvElecLoads.Rows(i).Cells.Item(0).Value
            If EmerLoad And IncludeinCalc Then
                CurrentMode = dgvElecLoads.Rows(i).Cells.Item(2).Value

                Debug.Print(dgvElecLoads.Rows(i).Cells.Item(4).Value)

                If ((CurrentMode = "All") Or (CurrentMode = "Cool")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadcool Then maxloadcool = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumcool = loadsumcool + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If

                If ((CurrentMode = "All") Or (CurrentMode = "Heat")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadheat Then maxloadheat = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumheat = loadsumheat + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If
            End If
        Next
        mcaheat = loadsumheat + 0.25 * maxloadheat
        mcacool = loadsumcool + 0.25 * maxloadcool

        If mcacool > mcaheat Then
            mcatouse = mcacool
        Else
            mcatouse = mcaheat
        End If
        CalculateMCAEmer = mcatouse

    End Function
    Private Function CalculateMOPEmer() As Double
        Dim LoadCount As Integer
        Dim i As Integer
        Dim EmerLoad As Boolean
        Dim IncludeinCalc As Boolean
        Dim maxloadheat As Double
        Dim maxloadcool As Double
        Dim loadsumheat As Double
        Dim loadsumcool As Double
        Dim CurrentMode As String
        Dim mopheat As Double
        Dim mopcool As Double
        Dim moptouse As Double

        maxloadheat = -1
        maxloadcool = -1
        loadsumheat = 0
        loadsumcool = 0

        LoadCount = dgvElecLoads.RowCount
        For i = 0 To LoadCount - 1
            EmerLoad = dgvElecLoads.Rows(i).Cells.Item(8).Value
            IncludeinCalc = dgvElecLoads.Rows(i).Cells.Item(0).Value
            If EmerLoad And IncludeinCalc Then
                CurrentMode = dgvElecLoads.Rows(i).Cells.Item(2).Value

                If ((CurrentMode = "All") Or (CurrentMode = "Cool")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadcool Then maxloadcool = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumcool = loadsumcool + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If

                If ((CurrentMode = "All") Or (CurrentMode = "Heat")) Then
                    If dgvElecLoads.Rows(i).Cells.Item(7).Value > maxloadheat Then maxloadheat = dgvElecLoads.Rows(i).Cells.Item(7).Value
                    loadsumheat = loadsumheat + dgvElecLoads.Rows(i).Cells.Item(7).Value
                End If
            End If
        Next
        mopheat = loadsumheat + 1.25 * maxloadheat
        mopcool = loadsumcool + 1.25 * maxloadcool

        If mopcool > mopheat Then
            moptouse = mopcool
        Else
            moptouse = mopheat
        End If
        CalculateMOPEmer = RoundDowntoFuseSize(moptouse)

    End Function
    Private Function RoundDowntoFuseSize(amps As Double) As Double
        Dim fusesize As Double
        Select Case amps
            Case 0.0 To 19.99
                fusesize = 15
            Case 20 To 24.99
                fusesize = 20
            Case 25 To 29.99
                fusesize = 25
            Case 30 To 34.99
                fusesize = 30
            Case 35 To 39.99
                fusesize = 35
            Case 40 To 44.99
                fusesize = 40
            Case 45 To 49.99
                fusesize = 45
            Case 50 To 59.99
                fusesize = 50
            Case 60 To 69.99
                fusesize = 60
            Case 70 To 79.99
                fusesize = 70
            Case 80 To 89.99
                fusesize = 80
            Case 90 To 99.99
                fusesize = 90
            Case 100 To 109.99
                fusesize = 100
            Case 110 To 124.99
                fusesize = 110
            Case 125 To 149.99
                fusesize = 125
            Case 150 To 174.99
                fusesize = 150
            Case 175 To 199.99
                fusesize = 175
            Case 200 To 224.99
                fusesize = 200
            Case 225 To 249.99
                fusesize = 225
            Case 250 To 299.99
                fusesize = 250
            Case 300 To 349.99
                fusesize = 300
            Case 350 To 399.99
                fusesize = 350
            Case 400 To 449.99
                fusesize = 400
            Case Else
                fusesize = 0.0
        End Select
        RoundDowntoFuseSize = fusesize
    End Function
    Private Sub LoadModLoads()
        Dim i As Integer
        Dim NewRow As String()

        If ThisUnitElecData.ModLoad.Count > 0 Then
            For i = 0 To ThisUnitElecData.ModLoad.Count - 1

                NewRow = ThisUnitElecData.ModLoad(i)
                dgvElecLoads.Rows.Add(NewRow)
            Next
        End If

    End Sub
    Public Sub CalculateCustomMCA()
        Dim FLA As String

        FLA = "0.0"

        txtCommVolts.Text = ThisUnitElecData.CommVolts

        If chkUseCustomMCA.Checked Then
            dgvElecLoads.Rows.Clear()
            dgvElecLoads.Refresh()
            lblBaseUnitMCA.Text = txtCommMCA.Text
            lblBaseUnitMOP.Text = txtCommMOP.Text
            lblBaseUnitMCA.Visible = True
            lblBaseUnitMOP.Visible = True
            chkIncludeLoadinCalc.Visible = True
            chkElecHeatLoad.Visible = True
            cmbLoadMode.Visible = True
            cmbElecLoads.Visible = True
            cmbLoadVoltsPhFreq.Visible = True
            cmbMotorHPList.Visible = True
            txtElecLoadFLA.Visible = True
            cmdAddELoad.Visible = True
            cmdDeleteElecLoad.Visible = True
            btnAddLoadComm.Visible = True
            cmdUpdateMCA.Visible = True
            lblElecLoad1.Visible = True
            lblElecLoad2.Visible = True
            lblElecLoad3.Visible = True
            lblElecLoad4.Visible = True
            lblElecLoad5.Visible = True
            lblElecLoad6.Visible = True
            lblElecLoad7.Visible = True
            Select Case ThisUnit.Family
                Case Is = "YLAA"
                    Call LoadYLAAChillerLoads()
                Case Is = "YVAA"
                    Call LoadYVAAChillerLoads()
                Case Is = "YCIV"
                    Call LoadYVAAChillerLoads()
                Case Is = "Series100"
                    Call LoadYPALLoads()
                Case Else
                    Call LoadStandardLoads()
            End Select
            Call LoadModLoads()

            Call cmdUpdateMCA.PerformClick()
            optMCAReportA.Checked = True
        Else
            lblBaseUnitMCA.Visible = False
            lblBaseUnitMOP.Visible = False
            txtCommMCA.Text = lblBaseUnitMCA.Text
            txtCommMOP.Text = lblBaseUnitMOP.Text
            chkIncludeLoadinCalc.Visible = False
            chkElecHeatLoad.Visible = False
            cmbLoadMode.Visible = False
            cmbElecLoads.Visible = False
            cmbLoadVoltsPhFreq.Visible = False
            cmbMotorHPList.Visible = False
            txtElecLoadFLA.Visible = False
            cmdAddELoad.Visible = False
            cmdDeleteElecLoad.Visible = False
            btnAddLoadComm.Visible = False
            cmdUpdateMCA.Visible = False
            lblElecLoad1.Visible = False
            lblElecLoad2.Visible = False
            lblElecLoad3.Visible = False
            lblElecLoad4.Visible = False
            lblElecLoad5.Visible = False
            lblElecLoad6.Visible = False
            lblElecLoad7.Visible = False
            dgvElecLoads.Rows.Clear()
            dgvElecLoads.Refresh()
            optMCAReportNoChange.Checked = True
        End If
    End Sub
    Private Sub chkUseCustomMCA_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseCustomMCA.CheckedChanged
        Call CalculateCustomMCA()
    End Sub
    Private Sub LoadYLAAChillerLoads()
        Dim ElecChar As String
        Dim i As Integer
        Dim FLA As Double
        Dim BigLoad As Double

        Dim NewRow As String()
        ElecChar = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text


        FLA = 0
        BigLoad = -1

        For i = 0 To ThisUnitElecData.CompRLA.Count - 1
            If IsNumeric(ThisUnitElecData.CompRLA(i)) Then
                FLA = FLA + Val(ThisUnitElecData.CompRLA(i))
                If Val(ThisUnitElecData.CompRLA(i)) > BigLoad Then BigLoad = Val(ThisUnitElecData.CompRLA(i))
                NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisUnitElecData.CompRLA(i), False}
                dgvElecLoads.Rows.Add(NewRow)
            End If
        Next

        For i = 0 To ThisUnitElecData.FanFLAeach.Count - 1
            If IsNumeric(ThisUnitElecData.FanFLAeach(i)) Then

                For j = 1 To Val(ThisUnitElecData.FanQty(i))
                    FLA = FLA + Val(ThisUnitElecData.FanFLAeach(i))
                    If Val(ThisUnitElecData.FanFLAeach(i)) > BigLoad Then BigLoad = Val(ThisUnitElecData.FanFLAeach(i))
                    NewRow = {True, False, "Cool", True, "CONDENSER FAN", ElecChar, "-", ThisUnitElecData.FanFLAeach(i), False}
                    dgvElecLoads.Rows.Add(NewRow)
                Next j
            End If
        Next

        FLA = FLA + (0.25 * BigLoad)
        If ThisUnitElecData.CommMCA - FLA > 0.1 Then
            NewRow = {True, False, "Cool", True, "CONTROL TRANSFORMER", ElecChar, "-", ThisUnitElecData.CommMCA - FLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        End If

        ThisUnitElecData.ControlxmfrFLA = "-"
        If ThisUnitElecData.CommMCA - FLA >= 1.0 Then
            ThisUnitElecData.ControlxmfrFLA = Format(ThisUnitElecData.CommMCA - FLA, "0.0")
        End If
    End Sub
    Private Sub LoadYVAAChillerLoads()
        Dim ElecChar As String
        Dim i As Integer
        Dim j As Integer
        Dim NewRow As String()
        ElecChar = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text

        For i = 0 To ThisUnitElecData.CompRLA.Count - 1
            If IsNumeric(ThisUnitElecData.CompRLA(i)) Then
                NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisUnitElecData.CompRLA(i), False}
                dgvElecLoads.Rows.Add(NewRow)
            End If
        Next


        For i = 0 To ThisUnitElecData.FanFLAeach.Count - 1
            If IsNumeric(ThisUnitElecData.FanFLAeach(i)) Then
                For j = 1 To ThisUnitElecData.FanQty(i)
                    NewRow = {True, False, "Cool", True, "CONDENSER FAN", ElecChar, "-", ThisUnitElecData.FanFLAeach(i), False}
                    dgvElecLoads.Rows.Add(NewRow)
                Next j
            End If
        Next



    End Sub
    Private Sub LoadYPALLoads()
        Dim ElecChar As String
        Dim i As Integer
        Dim NewRow As String()
        Dim ThisFLA As String
        Dim FanCount As Integer

        Select Case ThisUnit.Cabinet
            Case Is = "Series100A"
                FanCount = 4
            Case Is = "Series100B"
                FanCount = 6
            Case Is = "Series100C"
                FanCount = 9
        End Select

        ElecChar = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text

        ThisFLA = ThisUnitElecData.YPALLoadCC1A
        NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
        dgvElecLoads.Rows.Add(NewRow)
        ThisFLA = ThisUnitElecData.YPALLoadCC1B
        NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
        dgvElecLoads.Rows.Add(NewRow)
        ThisFLA = ThisUnitElecData.YPALLoadCC2A
        NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
        dgvElecLoads.Rows.Add(NewRow)
        ThisFLA = ThisUnitElecData.YPALLoadCC2B
        NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
        dgvElecLoads.Rows.Add(NewRow)
        ThisFLA = ThisUnitElecData.YPALLoadCC3A
        If IsNumeric(ThisFLA) Then
            NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        End If
        ThisFLA = ThisUnitElecData.YPALLoadCC3B
        If IsNumeric(ThisFLA) Then
            NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", ThisFLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        End If

        ThisFLA = ThisUnitElecData.YPALLoadCFans
        ThisFLA = Format(Val(ThisFLA) / FanCount, "0.0")
        For i = 1 To FanCount
            NewRow = {True, False, "Cool", True, "CONDENSER FAN", ElecChar, "-", ThisFLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        Next

        ThisFLA = NEMAMotorFLA(ThisUnitSFanPerf.MotorHP, txtCommVolts.Text & "-" & txtCommPhase.Text)
        NewRow = {True, False, "All", True, "SUPPLY FAN", ElecChar, ThisUnitSFanPerf.MotorHP, ThisFLA, False}
        dgvElecLoads.Rows.Add(NewRow)

        If IsNumeric(ThisUnitRXPerf.MotorHP) Then
            ThisFLA = NEMAMotorFLA(ThisUnitRXPerf.MotorHP, txtCommVolts.Text)
            NewRow = {True, False, "All", True, UCase(ThisUnitRXPerf.FanStyle), ElecChar, ThisUnitRXPerf.MotorHP, ThisFLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        End If

        If IsNumeric(ThisUnitElecData.YPALLoadCtrlXfmr) Then
            ThisFLA = ThisUnitElecData.YPALLoadCtrlXfmr
            NewRow = {True, False, "All", True, "Controls Transformer", ElecChar, "-", ThisFLA, False}
            dgvElecLoads.Rows.Add(NewRow)
        End If

    End Sub
    Private Sub LoadStandardLoads()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim Snipet As String
        Dim NewRow As String()
        Dim ElecChar As String
        Dim i, j As Integer
        Dim ThisField As String
        Dim ThisFieldHP As String
        Dim Temphp As String
        Dim Tempfla As String
        Dim ConvLabel As String
        Dim Suffix As String
        Dim OACode As String

        Temphp = "-"
        Tempfla = "-"

        Dim xfhp As String
        Dim myload As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        Snipet = Mid(ThisUnit.ModelNumber, 1, 5)
        If Mid(Snipet, 1, 1) = "V" Then Snipet = Mid(Snipet, 1, 2) & "XXX"
        If Mid(Snipet, 1, 1) = "Y" Then Snipet = Mid(ThisUnit.ModelNumber, 1, 7)
        If ThisUnit.Family = "Select" Then
            Suffix = "-2"
            For i = 0 To ThisUnitFactOpts.Count - 1
                If ThisUnitFactOpts.Item(i) = "VAV Controller with VFD" Then Suffix = "-4"
            Next
            Snipet = Mid(ThisUnit.ModelNumber, 1, 4) & Suffix
        End If

        MySQL = "SELECT * FROM tblElectricalInfo WHERE (JCISnipit='" & Snipet & "') AND (Voltage='" & txtCommVolts.Text & "')"

        rs.Open(MySQL, con)

        'rs.MoveFirst()

        Do While Not (rs.EOF)
            'lstAvailableMods.Items.Add(rs.Fields("ModPlainName").Value)
            ElecChar = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text
            If ((ThisUnitSFanPerf.MotorHP <> " ") And (ThisUnitSFanPerf.MhpUnits <> "kW")) Then
                NewRow = {True, False, "All", True, "SUPPLY FAN", ElecChar, ThisUnitSFanPerf.MotorHP, NEMAMotorFLA(ThisUnitSFanPerf.MotorHP, txtCommVolts.Text & "-" & txtCommPhase.Text), False, "NEMA"}
                dgvElecLoads.Rows.Add(NewRow)
            End If
            For i = 1 To 8
                ThisField = "Compressor" & Trim(Str(i)) & "FLA"
                If rs.Fields(ThisField).Value <> 0 Then
                    NewRow = {True, False, "Cool", True, "COMPRESSOR", ElecChar, "-", rs.Fields(ThisField).Value, False, rs.Fields("DataSource").Value}
                    dgvElecLoads.Rows.Add(NewRow)
                End If
            Next i
            For i = 1 To 9
                ThisField = "CondenserFan" & Trim(Str(i)) & "FLA"
                ThisFieldHP = "CondenserFan" & Trim(Str(i)) & "HP"

                If rs.Fields(ThisField).Value <> 0 Then
                    NewRow = {True, False, "Cool", True, "CONDENSER FAN", ElecChar, rs.Fields(ThisFieldHP).Value, rs.Fields(ThisField).Value, False, rs.Fields("DataSource").Value}
                    dgvElecLoads.Rows.Add(NewRow)
                End If
            Next i
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

        'check for a convenience outlet
        For i = 0 To lstFactOpts.Items.Count - 1
            If (InStr(lstFactOpts.Items.Item(i), "Powered Convenience") > 0) And (InStr(lstFactOpts.Items.Item(i), "Non") = 0) Then
                Temphp = "-"
                If ThisUnit.Family = "Series100" Then
                    Select Case txtCommVolts.Text
                        Case Is = "575"
                            Tempfla = "5.2"
                        Case Is = "460"
                            Tempfla = "6.5"
                        Case Is = "230"
                            Tempfla = "13.0"
                        Case Is = "208"
                            Tempfla = "14.4"
                    End Select
                    ConvLabel = "MATH 2kVA"
                Else
                    Select Case txtCommVolts.Text
                        Case Is = "575"
                            Tempfla = "5.2"
                        Case Is = "460"
                            Tempfla = "6.5"
                        Case Is = "230"
                            Tempfla = "13.0"
                        Case Is = "208"
                            Tempfla = "14.4"
                    End Select
                    ConvLabel = "MATH 3KVA"
                End If

                NewRow = {True, False, "All", True, "CONVENIENCE OUTLET", ElecChar, Temphp, Tempfla, False, ConvLabel}
                dgvElecLoads.Rows.Add(NewRow)
            End If
        Next
        ' check for a factory xfan on UPG items
        If ThisUnitRXPerf.UPGXFanPresent Then
            Select Case ThisUnit.Family
                Case Is = "Series5"
                    'need to complete...
                Case Is = "Series10"
                    Select Case txtCommVolts.Text
                        Case Is = "575"
                            Tempfla = "1.5"
                        Case Is = "460"
                            Tempfla = "2.2"
                        Case Is = "230"
                            Tempfla = "5.0"
                        Case Is = "208"
                            Tempfla = "5.0"
                    End Select
                    xfhp = "3/4"
                Case Is = "Series20"
                    Select Case txtCommVolts.Text
                        Case Is = "575"
                            Tempfla = "1.5"
                        Case Is = "460"
                            Tempfla = "2.2"
                        Case Is = "230"
                            Tempfla = "5.0"
                        Case Is = "208"
                            Tempfla = "5.0"


                    End Select
                    xfhp = "3/4"
                Case Is = "Choice"
                    OACode = Mid(txtModelNumber.Text, 10, 1)
                    If ((OACode = "F") Or (OACode = "J") Or (OACode = "M") Or (OACode = "T")) Then
                        'It's Modulating
                        Select Case txtCommVolts.Text
                            Case Is = "575"
                                Tempfla = "2.7"
                            Case Is = "460"
                                Tempfla = "3.4"
                            Case Is = "230"
                                Tempfla = "6.7"
                            Case Is = "208"
                                Tempfla = "6.7"
                        End Select
                        xfhp = "2"
                    Else
                        'It's On/Off
                        Select Case txtCommVolts.Text
                            Case Is = "575"
                                Tempfla = "1.5"
                            Case Is = "460"
                                Tempfla = "2.2"
                            Case Is = "230"
                                Tempfla = "5.0"
                            Case Is = "208"
                                Tempfla = "5.0"
                        End Select
                        xfhp = "1.5"
                    End If

                Case Is = "Select"
                    OACode = Mid(txtModelNumber.Text, 10, 1)
                    If ((Mid(txtModelNumber.Text, 2, 2) = "40") Or (Mid(txtModelNumber.Text, 2, 2) = "50")) Then


                        If ((OACode = "D") Or (OACode = "G") Or (OACode = "K") Or (OACode = "R")) Then
                            'It's Modulating and a big unit
                            Select Case txtCommVolts.Text
                                Case Is = "575"
                                    Tempfla = "6.1"
                                Case Is = "460"
                                    Tempfla = "8.2"
                                Case Is = "230"
                                    Tempfla = "15.2"
                                Case Is = "208"
                                    Tempfla = "15.2"
                                Case Else
                            End Select
                            xfhp = "5"
                        Else
                            'its on/off and a big unit
                            Select Case txtCommVolts.Text
                                Case Is = "575"
                                    Tempfla = "2.7"
                                Case Is = "460"
                                    Tempfla = "3.4"
                                Case Is = "230"
                                    Tempfla = "6.8"
                                Case Is = "208"
                                    Tempfla = "7.2"
                                Case Else
                            End Select
                            xfhp = "2"
                        End If

                    Else
                        If ((OACode = "D") Or (OACode = "G") Or (OACode = "K") Or (OACode = "R")) Then
                            'its modulating and a small unit
                            Select Case txtCommVolts.Text
                                Case Is = "575"
                                    Tempfla = "4.9"
                                Case Is = "460"
                                    Tempfla = "4.8"
                                Case Is = "230"
                                    Tempfla = "9.6"
                                Case Is = "208"
                                    Tempfla = "9.6"
                                Case Else
                            End Select
                            xfhp = "3"
                        Else
                            'its on off and a small unit
                            Select Case txtCommVolts.Text
                                Case Is = "575"
                                    Tempfla = "1.6"
                                Case Is = "460"
                                    Tempfla = "2.1"
                                Case Is = "230"
                                    Tempfla = "4.2"
                                Case Is = "208"
                                    Tempfla = "4.0"
                                Case Else
                            End Select
                            xfhp = "1"
                        End If

                    End If

                    'Do Nothing
            End Select
            NewRow = {True, False, "All", True, "EXHAUST FAN", ElecChar, xfhp, Tempfla, False, "Tech Guide - Hard Code"}
            dgvElecLoads.Rows.Add(NewRow)

        End If

        If ThisUnitElecData.EmerCircuit Then
            For i = 0 To dgvElecLoads.Rows.Count - 1
                myload = dgvElecLoads.Rows(i).Cells(4).Value
                For j = 0 To ThisUnitElecData.EmerLoad.Count - 1
                    If myload = ThisUnitElecData.EmerLoad(j) Then
                        dgvElecLoads.Rows(i).Cells(3).Value = False
                        dgvElecLoads.Rows(i).Cells(8).Value = True
                        Exit For
                    End If
                Next
            Next
        End If

    End Sub

    Private Sub cmbMotorHPList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMotorHPList.SelectedIndexChanged
        txtElecLoadFLA.Text = NEMAMotorFLA(cmbMotorHPList.Text, Mid(cmbLoadVoltsPhFreq.Text, 1, 5))
    End Sub

    Private Sub cmdUpdateMCA_Click(sender As Object, e As EventArgs) Handles cmdUpdateMCA.Click
        Call UpdateTheMCA()
    End Sub

    Public Sub UpdateTheMCA()
        If chkUseCustomMCA.Checked Then
            txtCommMCA.Text = Format(CalculateMCAComm(), "0.0")
            txtCommMOP.Text = Format(CalculateMOPComm(), "0")
            If optEmerNA.Checked = False Then
                txtEmerMCA.Text = Format(CalculateMCAEmer(), "0.0")
                txtEmerMOP.Text = Format(CalculateMOPEmer(), "0")
            End If
        End If
    End Sub


    Private Sub cmdAddELoad_Click(sender As Object, e As EventArgs) Handles cmdAddELoad.Click
        Dim NewRow As String()

        NewRow = {chkIncludeLoadinCalc.Checked, chkElecHeatLoad.Checked, cmbLoadMode.Text, False, cmbElecLoads.Text, cmbLoadVoltsPhFreq.Text, cmbMotorHPList.Text, txtElecLoadFLA.Text, True, "NEMA"}
        dgvElecLoads.Rows.Add(NewRow)

        chkIncludeLoadinCalc.Checked = False
        chkElecHeatLoad.Checked = False
        cmbLoadMode.Text = "All"
        cmbElecLoads.Text = ""

        cmbLoadVoltsPhFreq.Text = txtCommVolts.Text & "-" & txtCommPhase.Text & "-" & txtCommFreq.Text
        txtElecLoadFLA.Text = ""
        cmbMotorHPList.Text = "-"

        txtCommMCA.Text = Format(CalculateMCAComm(), "0.0")
        txtCommMOP.Text = Format(CalculateMOPComm(), "0")
        If optEmerNA.Checked = False Then
            txtEmerMCA.Text = Format(CalculateMCAEmer(), "0.0")
            txtEmerMOP.Text = Format(CalculateMOPEmer(), "0")
        End If
    End Sub

    Private Sub cmdDeleteElecLoad_Click(sender As Object, e As EventArgs) Handles cmdDeleteElecLoad.Click
        dgvElecLoads.Rows.Remove(dgvElecLoads.SelectedRows(0))
        txtCommMCA.Text = Format(CalculateMCAComm(), "0.0")
        txtCommMOP.Text = Format(CalculateMOPComm(), "0")
        If optEmerNA.Checked = False Then
            txtEmerMCA.Text = Format(CalculateMCAEmer(), "0.0")
            txtEmerMOP.Text = Format(CalculateMOPEmer(), "0")
        End If
    End Sub

    Private Sub lstAvailableMods_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableMods.DoubleClick
        btnAddItem.PerformClick()
    End Sub

    Private Sub lstSelectedMods_DoubleClick(sender As Object, e As EventArgs) Handles lstSelectedMods.DoubleClick
        btnDelItem.PerformClick()
    End Sub

    Private Sub cmdChooseProjectDirectory_Click(sender As Object, e As EventArgs) Handles cmdChooseProjectDirectory.Click
        Dim temp As String

        temp = "J:\"

        If ((txtProjectDirectory.Text = "") And (txtJobNumber.Text <> "BODF")) Then
            temp = "J:\" & Mid(txtJobNumber.Text, 1, 2)
            If Val(Mid(txtJobNumber.Text, 3, 2)) < 50 Then
                temp = temp & "00-" & Mid(txtJobNumber.Text, 1, 2) & "49"
            Else
                temp = temp & "50-" & Mid(txtJobNumber.Text, 1, 2) & "99"

            End If
        End If

        If txtJobNumber.Text = "BODF" Then
            temp = "S:\Sales\Engineering for Quotes (new)\"
        End If

        FolderBrowserDialog1.SelectedPath = temp
        FolderBrowserDialog1.ShowDialog()
        txtProjectDirectory.Text = FolderBrowserDialog1.SelectedPath & "\"

    End Sub

    Private Sub ConstructProjDirGuess()
        Dim temp As String
        Dim numpart As String

        numpart = Trim(txtJobNumber.Text)
        If Len(numpart) < 4 Then
            Exit Sub
        End If
        numpart = Mid(numpart, 1, 4)
        If Not (IsNumeric(numpart)) Then
            Exit Sub
        End If

        If Val(numpart) < 3000 Then
            Exit Sub
        End If

        If txtJobNumber.Text <> "BODF" Then
            temp = "J:\" & Mid(txtJobNumber.Text, 1, 2)
            If Val(Mid(txtJobNumber.Text, 3, 2)) < 50 Then
                temp = temp & "00-" & Mid(txtJobNumber.Text, 1, 2) & "49\"
            Else
                temp = temp & "50-" & Mid(txtJobNumber.Text, 1, 2) & "99\"

            End If

            For Each founddirectory In My.Computer.FileSystem.GetDirectories(temp, FileIO.SearchOption.SearchTopLevelOnly, "*" & txtJobNumber.Text & "*")
                txtProjectDirectory.Text = founddirectory & "\"
            Next


        End If
    End Sub

    Private Sub btnReferAdd_Click(sender As Object, e As EventArgs) Handles btnReferAdd.Click
        Dim i As Integer
        Dim dontdoit As Boolean

        dontdoit = False

        If lstUsingRefer.Items.Count > 0 Then
            For i = 0 To lstUsingRefer.Items.Count - 1
                If lstUsingRefer.Items.Item(i) = lstAvailRefer.Text Then
                    dontdoit = True
                End If
            Next
        End If
        If Not (dontdoit) Then
            lstUsingRefer.Items.Add(lstAvailRefer.Text)
        End If
        lstAvailRefer.ClearSelected()
        txtReferDesc.Text = ""
    End Sub

    Private Sub btnReferDel_Click(sender As Object, e As EventArgs) Handles btnReferDel.Click
        lstUsingRefer.Items.Remove(lstUsingRefer.SelectedItem)
    End Sub

    Private Sub btnReferDelAll_Click(sender As Object, e As EventArgs) Handles btnReferDelAll.Click
        lstUsingRefer.Items.Clear()
    End Sub

    Private Sub lstAvailRefer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailRefer.SelectedIndexChanged
        Dim tempvar As String
        If lstAvailRefer.SelectedIndex >= 0 Then
            txtReferDesc.Text = ReferDesc(lstAvailRefer.SelectedIndex)
            tempvar = ReferWMFPath.Item(lstAvailRefer.SelectedIndex)
            picReferPreview.LoadAsync(tempvar)

        End If
    End Sub

    Private Sub txtJobNumber_Leave(sender As Object, e As EventArgs) Handles txtJobNumber.Leave
        If ((txtJobNumber.Text = "b") Or (txtJobNumber.Text = "B")) Then
            txtJobNumber.Text = "BODF"
        End If
        If Mid(txtJobNumber.Text, Len(txtJobNumber.Text)) <> "F" Then
            txtJobNumber.Text = txtJobNumber.Text & "F"
        End If
        If Mid(txtJobNumber.Text, Len(txtJobNumber.Text)) = "f" Then
            txtJobNumber.Text = Mid(txtJobNumber.Text, 1, Len(txtJobNumber.Text) - 1) & "F"
        End If
        If IsNumeric(Mid(txtJobNumber.Text, 1, 4)) Then
            Call ConstructProjDirGuess()
        End If
    End Sub

    Private Sub nudPointLoads_ValueChanged(sender As Object, e As EventArgs) Handles nudPointLoads.ValueChanged
        Dim MyWeightBox As System.Windows.Forms.TextBox
        Dim MyDistBox As System.Windows.Forms.TextBox
        Dim MyLabel As System.Windows.Forms.Label
        Dim BaseWeight As System.Windows.Forms.Label
        Dim ModWeight As System.Windows.Forms.Label

        Dim i As Integer
        Dim PointCount As Integer
        Dim HiLimit As Integer

        If ProgramGTG Then
            PointCount = nudPointLoads.Value
            HiLimit = 64 + PointCount

            For i = 65 To 84
                MyLabel = grpPtLoads.Controls.Item("lblPtWt" & Chr(i))
                MyWeightBox = grpPtLoads.Controls.Item("TxtPtWt" & Chr(i))
                MyDistBox = grpPtLoads.Controls.Item("TxtPtdX" & Chr(i))
                BaseWeight = grpPtLoads.Controls.Item("lblBaseWt" & Chr(i))
                ModWeight = grpPtLoads.Controls.Item("lblModWt" & Chr(i))

                If i <= HiLimit Then

                    MyLabel.Visible = True
                    MyWeightBox.Visible = True
                    MyDistBox.Visible = True
                    BaseWeight.Visible = True
                    ModWeight.Visible = True
                Else
                    MyLabel.Visible = False
                    MyWeightBox.Visible = False
                    MyDistBox.Visible = False
                    BaseWeight.Visible = False
                    ModWeight.Visible = False

                End If
            Next i
        End If
    End Sub

    Private Sub vsbTransverse_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbTransverse.Scroll
        lblTransverse.Text = Str((vsbTransverse.Value) / 100 * txtWidth.Text)
        lblLongitudinal.Text = Str((100 - hsbLongitudinal.Value) / 100 * txtLength.Text)
        Label151.Text = vsbTransverse.Value

        Call UpdateModPointWeights()
        Call UpdateGrossWeights()
    End Sub

    Private Sub hsbLongitudinal_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbLongitudinal.Scroll
        lblTransverse.Text = Str((vsbTransverse.Value) / 100 * txtWidth.Text)
        lblLongitudinal.Text = Str((100 - hsbLongitudinal.Value) / 100 * txtLength.Text)
        Label151.Text = vsbTransverse.Value

        Call UpdateModPointWeights()
        Call UpdateGrossWeights()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBaseWtA.Text = "1111"
        txtBaseWtB.Text = "1112"
        txtBaseWtC.Text = "1113"
        txtBaseWtD.Text = "1114"
        txtBaseWtE.Text = "1115"
        txtBaseWtF.Text = "1116"
        txtBaseWtG.Text = "1117"
        txtBaseWtH.Text = "1118"
    End Sub

    Private Sub cmbElecLoads_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbElecLoads.SelectedIndexChanged
        If cmbElecLoads.Text = "Convenience Outlet" Then
            Select Case txtCommVolts.Text
                Case Is = "575"
                    cmbMotorHPList.Text = "-"
                    txtElecLoadFLA.Text = "5.2"
                Case Is = "460"
                    cmbMotorHPList.Text = "-"
                    txtElecLoadFLA.Text = "6.5"
                Case Is = "230"
                    cmbMotorHPList.Text = "-"
                    txtElecLoadFLA.Text = "13.0"
                Case Is = "208"
                    cmbMotorHPList.Text = "-"
                    txtElecLoadFLA.Text = "14.4"
            End Select
        End If
    End Sub

    Private Sub optMCAReportNoChange_CheckedChanged(sender As Object, e As EventArgs) Handles optMCAReportNoChange.CheckedChanged
        If optMCAReportNoChange.Checked = True Then
            chkMCANoChangeNo1ALoads.Enabled = True
            chkMCANoChangeOnlyAddVFD.Enabled = True
            chkMCANoChangeOnlyAddFieldProvVFD.Enabled = True
            chkMCANoChangeOnlyAddSCR.Enabled = True
            chkMCANoChangeOnlyAddReactors.Enabled = True
        Else
            chkMCANoChangeNo1ALoads.Enabled = False
            chkMCANoChangeOnlyAddVFD.Enabled = False
            chkMCANoChangeOnlyAddFieldProvVFD.Enabled = False
            chkMCANoChangeOnlyAddSCR.Enabled = False
            chkMCANoChangeOnlyAddReactors.Enabled = False
            chkMCANoChangeNo1ALoads.Checked = False
            chkMCANoChangeOnlyAddVFD.Checked = False
            chkMCANoChangeOnlyAddFieldProvVFD.Checked = False
            chkMCANoChangeOnlyAddSCR.Checked = False
            chkMCANoChangeOnlyAddReactors.Checked = False

        End If
    End Sub

    Private Sub cmdFactOptImport_Click(sender As Object, e As EventArgs) Handles cmdFactOptImport.Click
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load("C:\Users\jlevine\Desktop\AC-1 Order Details.xml")




        xdoc = Nothing
    End Sub

    Private Sub cmdMakeSide_Click(sender As Object, e As EventArgs) Handles cmdMakeSide.Click
        txtDuctLoc.Text = "Side"
    End Sub

    Private Sub cmdMakeBottom_Click(sender As Object, e As EventArgs) Handles cmdMakeBottom.Click
        txtDuctLoc.Text = "Bottom"
    End Sub

    Private Sub cmdMakeRear_Click(sender As Object, e As EventArgs) Handles cmdMakeRear.Click
        txtDuctLoc.Text = "Rear"
    End Sub

    Private Sub cmdMakeFront_Click(sender As Object, e As EventArgs) Handles cmdMakeFront.Click
        txtDuctLoc.Text = "Front"
    End Sub

    Private Sub cmdJobNumLocal_Click(sender As Object, e As EventArgs) Handles cmdJobNumLocal.Click
        txtJobNumber.Text = "9999F"
    End Sub

    Private Sub nudJobNumberAdj_ValueChanged(sender As Object, e As EventArgs) Handles nudJobNumberAdj.ValueChanged
        If txtJobNumber.Text <> "BODF" Then
            txtJobNumber.Text = Trim(Str(nudJobNumberAdj.Value) & "F")
        End If
    End Sub

    Private Sub cmdJobNumBOD_Click(sender As Object, e As EventArgs) Handles cmdJobNumBOD.Click
        txtJobNumber.Text = "BODF"

    End Sub

    Private Sub optRTUSeries100_CheckedChanged(sender As Object, e As EventArgs) Handles optRTUSeries100.CheckedChanged
        If optRTUSeries100.Checked Then
            chkS100ACabinet.Enabled = True
            chkS100BCabinet.Enabled = True
            chkS100CCabinet.Enabled = True
            chkS100ACabinet.Checked = True
        Else
            chkS100ACabinet.Enabled = False
            chkS100BCabinet.Enabled = False
            chkS100CCabinet.Enabled = False
            chkS100ACabinet.Checked = False
            chkS100BCabinet.Checked = False
            chkS100CCabinet.Checked = False

        End If


    End Sub

    Private Sub chkS100ACabinet_CheckedChanged(sender As Object, e As EventArgs) Handles chkS100ACabinet.CheckedChanged
        If chkS100ACabinet.Checked = True Then
            chkS100BCabinet.Checked = False
            chkS100CCabinet.Checked = False
        End If
    End Sub

    Private Sub chkS100BCabinet_CheckedChanged(sender As Object, e As EventArgs) Handles chkS100BCabinet.CheckedChanged
        If chkS100BCabinet.Checked = True Then
            chkS100ACabinet.Checked = False
            chkS100CCabinet.Checked = False
        End If
    End Sub

    Private Sub chkS100CCabinet_CheckedChanged(sender As Object, e As EventArgs) Handles chkS100CCabinet.CheckedChanged
        If chkS100CCabinet.Checked = True Then
            chkS100ACabinet.Checked = False
            chkS100BCabinet.Checked = False
        End If
    End Sub

    Private Sub cmdFSTImport_Click(sender As Object, e As EventArgs) Handles cmdFSTImport.Click
        Dim FSTFile As String
        Dim FullFilePath As String


        FullFilePath = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\Submittal Design\BaseUnitFile.xml"
        If Not (My.Computer.FileSystem.FileExists(FullFilePath)) Then
            If txtBaseUnitFile.Text = "" Then
                OpenFileDialog1.InitialDirectory = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\Submittal Design\"
                OpenFileDialog1.FileName = "BaseUnitFile.xml"
                OpenFileDialog1.ShowDialog()
                txtBaseUnitFile.Text = OpenFileDialog1.FileName
            End If
        Else
            txtBaseUnitFile.Text = FullFilePath
        End If

        FSTFile = txtBaseUnitFile.Text
        If Mid(FSTFile, 1, 1) = """" Then
            FSTFile = Mid(FSTFile, 2, Len(FSTFile) - 2)
        End If
        txtBaseUnitFile.Text = FSTFile

        cmdFSTImport.Enabled = False

        Call FSTImportProjectData(FSTFile)
        Select Case ThisUnit.Kingdom
            Case Is = "RTU"
                If ThisUnit.Family <> "Series100" Then
                    ThisUnit.Notes = "Sound performance does not reflect finial finisher options." & vbCrLf & "Clearances designated as -1 require verifying clearance in the #Brand# Engineering Guide." & vbCrLf & "Weight is estimated to +/- 10%"
                    ThisUnitCoolPerf.ImportFSTUPGData()
                    ThisUnitRHPerf.ImportFSTUPGData()
                    ThisUnitHeatPerf.ImportFSTUPGData()
                    ThisUnitSFanPerf.ImportFSTUPGData()
                    ThisUnitRXPerf.ImportFSTUPGData()
                    ThisUnitElecData.ImportFSTUPGData()
                    ThisUnitPhysicalData.ImportFSTUPGData()
                    ThisUnit.ImportFSTCerts()
                Else
                    'Handle YPAL Import
                    ThisUnit.ImportFSTYPALData()
                    ThisUnitCoolPerf.ImportFSTYPALData()
                    'ThisUnitRHPerf.ImportFSTYPALData()
                    ThisUnitHeatPerf.ImportFSTYPALData()
                    ThisUnitSFanPerf.ImportFSTYPALData()
                    ThisUnitRXPerf.ImportFSTYPALData()
                    ThisUnitElecData.ImportFSTYPALData()
                    ThisUnitPhysicalData.ImportFSTYPALData()
                    ThisYPALPerf.ImportFSTYPALData()
                    ThisYPALPerf.ImportFSTYPALSoundData()  'This grabs all the sound data from the FST XML File

                End If
            Case Is = "Chiller"
                Select Case ThisUnit.Family
                    Case Is = "YVAA"
                        ThisChillerMainPerf.ImportChillerEvaporatorData()
                        ThisChillerMainPerf.ImportChillerCondenserData()
                        ThisChillerMainPerf.ImportYVAAPerformanceData()
                        ThisChillerMainPerf.ImportYVAASoundData()
                        ThisUnitElecData.ImportFSTYVAAData()
                        ThisUnitPhysicalData.ImportFSTYVAAData()
                    Case Is = "YLAA"
                        ThisChillerMainPerf.ImportChillerEvaporatorData()
                        ThisChillerMainPerf.ImportChillerCondenserData()
                        ThisChillerMainPerf.ImportYLAAPerformanceData()
                        ThisChillerMainPerf.ImportYLAASoundData()
                        ThisUnitElecData.ImportFSTYLAAData()
                        ThisUnitPhysicalData.ImportFSTYLAAData()
                        ThisChillerMainPerf.ImportYLAAPhysicalData()
                    Case Is = "YCIV"
                        ThisChillerMainPerf.ImportChillerEvaporatorData()
                        ThisChillerMainPerf.ImportChillerCondenserData()
                        ThisChillerMainPerf.ImportYVAAPerformanceData()
                        ThisChillerMainPerf.ImportYVAASoundData()
                        ThisUnitElecData.ImportFSTYVAAData()
                        ThisUnitPhysicalData.ImportFSTYVAAData()
                End Select

        End Select
        txtYPALUnitSize.Text = ThisYPALPerf.UnitSize
        Me.btnTranslate.PerformClick()
        Call GuessUnitVersion()
        txtRedoFilePath.Text = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\Submittal Design\RedoFile.xml"
    End Sub
    Private Sub GuessUnitVersion()
        Dim SubDir As String
        Dim SubName As String
        Dim NewVerNum, OldVerNum As String
        Dim FileList() As String

        SubDir = txtProjectDirectory.Text & txtJobNumber.Text & "-" & txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\"
        SubName = txtJobNumber.Text & "-" & txtUnitNumber.Text & " - Submittal V*"

        FileList = Directory.GetFiles(SubDir, SubName)


        If FileList.Length > 0 Then
            OldVerNum = Mid(FileList(0), InStr(FileList(0), "V") + 1, 1)
            NewVerNum = Trim(Str(Val(OldVerNum) + 1)) & ".0"
            txtUnitVersion.Text = NewVerNum
        End If

    End Sub
    Private Sub FSTImportProjectData(lFSTFile As String)
        Dim xDoc As XmlDocument = New XmlDocument
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim temp As String

        xDoc.Load(lFSTFile)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ProjectData")
        temp = xNodeRoot.SelectSingleNode("Kingdom").InnerText
        If temp <> ThisUnit.Kingdom Then
            dummy = MsgBox("Incorrect File Selection.")
            End
        End If
        temp = xNodeRoot.SelectSingleNode("Family").InnerText
        If temp <> ThisUnit.Family Then
            dummy = MsgBox("Incorrect File Selection.")
            End
        End If

        ThisUnit.Notes = xNodeRoot.SelectSingleNode("Notes").InnerText

        txtJobNumber.Text = xNodeRoot.SelectSingleNode("JobNumber").InnerText
        txtUnitNumber.Text = xNodeRoot.SelectSingleNode("UnitNumber").InnerText
        txtProjectName.Text = xNodeRoot.SelectSingleNode("ProjectName").InnerText
        txtQty.Text = xNodeRoot.SelectSingleNode("Quantity").InnerText
        txtUnitTag.Text = xNodeRoot.SelectSingleNode("UTag").InnerText
        cmbBrand.Text = xNodeRoot.SelectSingleNode("Brand").InnerText
        txtBrandModelNumber.Text = xNodeRoot.SelectSingleNode("BrandModelNum").InnerText
        txtModCodeImport.Text = xNodeRoot.SelectSingleNode("ModCodes").InnerText
        If xNodeRoot.SelectSingleNode("ModCodes").InnerText = "True" Then ThisUnitElecData.UnitIs65kASCCR = True

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/FIOPS")
        ThisUnitFactOpts.Clear()
        For i = 0 To xNodeRoot.ChildNodes.Count - 1
            ThisUnitFactOpts.Add(xNodeRoot.ChildNodes.Item(i).InnerText)
            If InStr(xNodeRoot.ChildNodes.Item(i).InnerText, "Disconnect") > 0 Then ThisUnitElecData.CommDisconnect = True
            If InStr(xNodeRoot.ChildNodes.Item(i).InnerText, "Powered Exhaust") Then ThisUnitRXPerf.UPGXFanPresent = True
            If xNodeRoot.ChildNodes.Item(i).InnerText = "Powered Convenience Outlet" Then ThisUnitElecData.ConvOutlet = True
            'Flag as VFD present if it's a FIOP
            If xNodeRoot.ChildNodes.Item(i).InnerText = "VAV Controller with VFD" Then ThisUnitSFanPerf.VFDPresent = True
            If xNodeRoot.ChildNodes.Item(i).InnerText = "Intellispeed VFD" Then ThisUnitSFanPerf.VFDPresent = True
            'Test for 65kA SCCR Base Unit
            If xNodeRoot.ChildNodes.Item(i).InnerText = "65kA SCCR" Then ThisUnitElecData.UnitIs65kASCCR = True
        Next

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/FieldInstalled")
        ThisUnitFieldInst.Clear()
        If xNodeRoot.ChildNodes.Count > 0 Then
            For i = 0 To xNodeRoot.ChildNodes.Count - 1
                ThisUnitFieldInst.Add(xNodeRoot.ChildNodes.Item(i).InnerText)
                If InStr(xNodeRoot.ChildNodes.Item(i).InnerText, "Powered Exhaust") Then ThisUnitRXPerf.UPGXFanPresent = True
            Next
        Else
            ThisUnitFieldInst.Add("None")
        End If

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/CoolingData")
        txtNominalTons.Text = Trim(xNodeRoot.SelectSingleNode("NominalTons").InnerText)


        If ThisUnit.Kingdom = "Chiller" Then
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ProjectData/PIN/PIN")

            ThisChillerMainPerf.PINA = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINB = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINC = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PIND = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINE = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINF = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PING = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINH = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            ThisChillerMainPerf.PINI = xNodeRoot.InnerText
            xNodeRoot = xNodeRoot.NextSibling

            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/CoolingData")
            ThisChillerMainPerf.NominalTons = xNodeRoot.SelectSingleNode("NominalTons").InnerText
            ThisChillerMainPerf.NetCapacity = xNodeRoot.SelectSingleNode("NominalTons").InnerText
            ThisChillerMainPerf.Refrigerant = xNodeRoot.SelectSingleNode("Refrigerant").InnerText
            ThisUnitCoolPerf.Refrigerant = xNodeRoot.SelectSingleNode("Refrigerant").InnerText
        End If

        xDoc = Nothing

    End Sub

    Private Sub SetupLastKingdomAndFamily()
        Dim dummy As MsgBoxResult
        Dim errmsg As String

        If My.Settings.LastKingdom = "RTU" Then
            optRTU.Checked = True
            Select Case My.Settings.LastFamily
                Case Is = "Series5"
                    optRTUSeries5.Checked = True
                Case Is = "Series10"
                    optRTUSeries10.Checked = True
                Case Is = "Series12"
                    optRTUSeries12.Checked = True
                Case Is = "Series20"
                    optRTUSeries20.Checked = True
                Case Is = "Series40"
                    optRTUSeries40.Checked = True
                Case Is = "Series100"
                    optRTUSeries100.Checked = True
                    If My.Settings.LastCabinet = "Series100A" Then chkS100ACabinet.Checked = True
                    If My.Settings.LastCabinet = "Series100B" Then chkS100BCabinet.Checked = True
                    If My.Settings.LastCabinet = "Series100C" Then chkS100CCabinet.Checked = True
                Case Is = "Choice"
                    optRTUChoice.Checked = True
                Case Is = "Select"
                    optRTUSelect.Checked = True
                Case Is = "Premier"
                    optRTUPremier.Checked = True
                Case Else
                    optRTUChoice.Checked = True
                    errmsg = "Unknown Family: " & My.Settings.LastFamily & " in Program Settings for Kingdom Type: RTU."
                    dummy = MsgBox(errmsg, vbOKOnly, gProgName)
                    Stop
            End Select
        End If

        If My.Settings.LastKingdom = "AHU" Then
            optAHU.Checked = True
            Select Case My.Settings.LastFamily
                Case Is = "XTO"
                    optAHUXTI.Checked = True
                Case Is = "XTI"
                    optAHUXTO.Checked = True
                Case Is = "YorkCustom"
                    optAHUYorkCustom.Checked = True
                Case Else
                    errmsg = "Unknown Family: " & My.Settings.LastFamily & " in Program Settings for Kingdom Type: AHU."
                    dummy = MsgBox(errmsg, vbOKOnly, gProgName)
                    Stop
            End Select
        End If

        If My.Settings.LastKingdom = "Chiller" Then
            optChiller.Checked = True
            Select Case My.Settings.LastFamily
                Case Is = "YCAL"
                    optChillerYCAL.Checked = True
                Case Is = "YLAA"
                    optChillerYLAA.Checked = True
                Case Is = "YVAA"
                    optChillerYVAA.Checked = True
                Case Is = "YCIV"
                    optChillerYCIV.Checked = True
                Case Is = "YCAV"
                    optChillerYCAV.Checked = True
                Case Else
                    errmsg = "Unknown Family: " & My.Settings.LastFamily & " in Program Settings for Kingdom Type: Chiller."
                    dummy = MsgBox(errmsg, vbOKOnly, gProgName)
                    Stop
            End Select
        End If

        If My.Settings.LastKingdom = "Misc" Then
            optMisc.Checked = True
            Select Case My.Settings.LastFamily
                Case Is = "DS"
                    optMiscDS.Checked = True
                Case Is = "Series20ODSplit"
                    optS20ODSplit.Checked = True
                Case Is = "Series40ODSplit"
                    optS40ODSplit.Checked = True
                Case Is = "Series20IDSplit"
                    optS20IDSplit.Checked = True
                Case Is = "YCUL"
                    optYCULSplit.Checked = True
                Case Is = "YLUA"
                    optYLUASplit.Checked = True
                Case Is = "DOAS"
                    optDOAS.Checked = True
                Case Else
                    errmsg = "Unknown Family: " & My.Settings.LastFamily & " in Program Settings for Kingdom Type: Misc."
                    dummy = MsgBox(errmsg, vbOKOnly, gProgName)
                    Stop
            End Select
        End If

        If My.Settings.LastKingdom = "Blank" Then
            optBlankFamily.Checked = True
        End If

    End Sub


    Private Sub cmdAutoAddMods_Click(sender As Object, e As EventArgs) Handles cmdAutoAddMods.Click
        Dim ModList(20) As String
        Dim i As Integer
        Dim ModString As String
        Dim ThisMod As String
        Dim modcount As Integer
        Dim myindex As Integer
        Dim NotFound As Boolean
        Dim dummy As MsgBoxResult
        Dim myMessage As String

        i = 0
        ModString = Trim(txtModCodeImport.Text)
        Do While Len(ModString) > 0
            i = i + 1
            If InStr(ModString, " ") Then
                ThisMod = Mid(ModString, 1, InStr(ModString, " ") - 1)
                ModString = Mid(ModString, InStr(ModString, " ") + 1, Len(ModString))
                ModList(i) = ThisMod
            Else
                ThisMod = ModString
                ModString = ""
                ModList(i) = ThisMod
            End If
        Loop
        modcount = i

        For i = 1 To modcount
            NotFound = False
            Select Case ModList(i)
                Case Is = "100OA"
                    myindex = lstAvailableMods.FindString("100% Outdoor Air")
                Case Is = "Acoustic"
                    myindex = lstAvailableMods.FindString("Acoustic Package")
                Case Is = "AFlowMod"
                    myindex = lstAvailableMods.FindString("Airflow Path Reconfiguration")
                Case Is = "BiPolar"
                    myindex = lstAvailableMods.FindString("Bipolar Ionization Array")
                Case Is = "CFan"
                    myindex = lstAvailableMods.FindString("Condenser Fan")
                Case Is = "CHWCoil"
                    myindex = lstAvailableMods.FindString("Chilled Water Coil")
                Case Is = "CPCtrl"
                    myindex = lstAvailableMods.FindString("Customer Provided Controls")
                Case Is = "CstmCoil"
                    myindex = lstAvailableMods.FindString("Custom Coil")
                Case Is = "CstmCtrl"
                    myindex = lstAvailableMods.FindString("Custom Controls")
                Case Is = "CstmEncl"
                    myindex = lstAvailableMods.FindString("Custom Enclosure")
                Case Is = "CstmHV"
                    myindex = lstAvailableMods.FindString("Custom Power Options")
                Case Is = "CstmMech"
                    myindex = lstAvailableMods.FindString("Custom Mechanical Options")
                Case Is = "CstmRef"
                    myindex = lstAvailableMods.FindString("Custom Refrigeration")
                Case Is = "CstmSM"
                    myindex = lstAvailableMods.FindString("Custom Sheetmetal")
                Case Is = "DigScroll"
                    myindex = lstAvailableMods.FindString("Digital Scroll Compressor")
                Case Is = "DPP"
                    myindex = lstAvailableMods.FindString("Dual Point Power")
                Case Is = "DWall"
                    myindex = lstAvailableMods.FindString("Double Wall Sheetmetal Liner")
                Case Is = "ERW"
                    myindex = lstAvailableMods.FindString("Energy Recovery Wheel")
                Case Is = "Extend"
                    myindex = lstAvailableMods.FindString("Extended Cabinet")
                Case Is = "FanWall"
                    myindex = lstAvailableMods.FindString("Supply Fan Wall")
                Case Is = "FanVFD"
                    myindex = lstAvailableMods.FindString("Fan VFD")
                Case Is = "SFVFD"
                    myindex = lstAvailableMods.FindString("Supply Fan VFD")
                Case Is = "RFVFD"
                    myindex = lstAvailableMods.FindString("Return Fan VFD")
                Case Is = "XFVFD"
                    myindex = lstAvailableMods.FindString("Exhaust Fan VFD")
                Case Is = "FanWall"
                    myindex = lstAvailableMods.FindString("Supply Fan Wall")
                Case Is = "Filt"
                    myindex = lstAvailableMods.FindString("Filtration")
                Case Is = "HGBP"
                    myindex = lstAvailableMods.FindString("Hot Gas Bypass")
                Case Is = "HGRH"
                    myindex = lstAvailableMods.FindString("Hot Gas Reheat")
                Case Is = "Humid"
                    myindex = lstAvailableMods.FindString("Humidification")
                Case Is = "HWCoil"
                    myindex = lstAvailableMods.FindString("Hot Water Coil")
                Case Is = "LCVAV"
                    myindex = lstAvailableMods.FindString("Light Commercial VAV")
                Case Is = "LowAF"
                    myindex = lstAvailableMods.FindString("Reduced Air Flow")
                Case Is = "LowAmbient-20"
                    myindex = lstAvailableMods.FindString("Low Ambient Chiller")
                Case Is = "LowAmbient-30"
                    myindex = lstAvailableMods.FindString("Low Ambient Chiller")
                Case Is = "LowAmbient-40"
                    myindex = lstAvailableMods.FindString("Low Ambient Chiller")
                Case Is = "MEHeat(I)"
                    myindex = lstAvailableMods.FindString("Modulating Electric Heat Fisen Provided")
                Case Is = "MEHeat(I)Pre"
                    myindex = lstAvailableMods.FindString("Modulating Electric Pre-Heat Fisen Provided")
                Case Is = "MEHeat(I)React"
                    myindex = lstAvailableMods.FindString("Modulating Electric Reactivation Heat Fisen Provided")
                Case Is = "MEHeat(R)"
                    myindex = lstAvailableMods.FindString("Modulating Electric Heat Retrofit")
                Case Is = "MGH(H)"
                    myindex = lstAvailableMods.FindString("Modulating Gas Heat Heatco")
                Case Is = "MGH(R)"
                    myindex = lstAvailableMods.FindString("Modulating Gas Heat Retrofit")
                Case Is = "MHGRH"
                    If ThisUnit.Family = "Series40" Then
                        myindex = lstAvailableMods.FindString("Hot Gas Reheat")
                    Else
                        myindex = lstAvailableMods.FindString("Modulating Hot Gas Reheat Conversion")
                    End If
                Case Is = "MZ-VAV"
                    myindex = lstAvailableMods.FindString("Multizone - Packaged VAV")
                Case Is = "MZ-DD"
                    myindex = lstAvailableMods.FindString("Multizone - Dual Deck")
                Case Is = "MZ-TD"
                    myindex = lstAvailableMods.FindString("Multizone - Triple Deck")
                Case Is = "MZ-COBP"
                    myindex = lstAvailableMods.FindString("Multizone - Changeover Bypass")
                Case Is = "MZ-Curb"
                    myindex = lstAvailableMods.FindString("Multizone - Adapter Curb")
                Case Is = "OAFMS"
                    myindex = lstAvailableMods.FindString("Outdoor Airflow Monitoring Station")
                Case Is = "PipePkg"
                    myindex = lstAvailableMods.FindString("Piping Package")
                Case Is = "RFan"
                    myindex = lstAvailableMods.FindString("Return Fan")
                Case Is = "SCCR"
                    myindex = lstAvailableMods.FindString("Short Circuit Current Rating")
                Case Is = "SFan"
                    myindex = lstAvailableMods.FindString("Supply Fan")
                Case Is = "SteamCoil"
                    myindex = lstAvailableMods.FindString("Steam Coil")
                Case Is = "UVLights"
                    myindex = lstAvailableMods.FindString("Ultraviolet Lights")
                Case Is = "XFan"
                    myindex = lstAvailableMods.FindString("Exhaust Fan")
                Case Else
                    NotFound = True
            End Select
            If Not (NotFound) Then
                lstAvailableMods.SelectedIndex = myindex
                btnAddItem.PerformClick()
            End If
            If NotFound Then
                myMessage = "Unable to automatically add:" & ModList(i) & vbCrLf & "Please add manually or correct the spelling."
                dummy = MsgBox(myMessage, vbOKOnly, "Fisen Unit Generator")
            End If
        Next


    End Sub

    Private Sub cmdJumpButton_Click(sender As Object, e As EventArgs) Handles cmdJumpButton.Click

        chkInhibitDigConditions.Checked = True
        My.Settings.DebugLastModule = cmbJumpDest.Text
        My.Settings.Save()

        ThisUnit.Family = "Series100"
        ThisUnit.Cabinet = "Series100B"
        txtJobNumber.Text = "3994F"
        txtUnitNumber.Text = "01"
        txtModelNumber.Text = "J12ZJS24G2D6BCD2E1"
        ThisUnit.ModelNumber = "J12ZJS24G2D6BCD2E1"
        txtProjectDirectory.Text = "J:\3950-3999\3994F - Test S10 MGH Do Not Use\"
        ThisUnit.NominalTons = "12.5"

        TSLabelFamily.Text = ThisUnit.Family
        TSLabelModelNum.Text = ThisUnit.ModelNumber

        Select Case cmbJumpDest.Text
            Case Is = "100% Outdoor Air"
                frm100OA.ShowDialog()
            Case Is = "Custom Controls"
                frmCstmCtrl.ShowDialog()
            Case Is = "Custom Mechaincal"
                frmCstmMech.ShowDialog()
            Case Is = "Custom Power"
                frmCstmHV.ShowDialog()
            Case Is = "Custom Refrigeration"
                frmCstmRef.ShowDialog()
            Case Is = "Custom Sheet Metal"
                frmCstmSM.ShowDialog()
            Case Is = "DWall"
                frmDWall.ShowDialog()
            Case Is = "Filtration"
                ThisUnitSFanPerf.Airflow = "3500"
                frmFiltration.ShowDialog()
            Case Is = "HGBP"
                frmHGBP.ShowDialog()
            Case Is = "HWCoil"
                frmHWCoil.ShowDialog()
            Case Is = "LCVAV"
                frmLCVAV.ShowDialog()
            Case Is = "LowAF"
                frmLowAF.ShowDialog()
            Case Is = "MGH Heatco"
                frmMGH_H.ShowDialog()
            Case Is = "Piping Package"
                frmPipePkg.ShowDialog()
            Case Is = "Return Fan"
                frmNewFan.FanStyle = "Return Fan"
                frmNewFan.ShowDialog()
            Case Is = "Steam Coil"
                frmSteamCoil.ShowDialog()
            Case Is = "Supply Fan"
                frmNewFan.FanStyle = "Supply Fan"
                frmNewFan.ShowDialog()
            Case Is = "SFanWall"
                frmFanWall.FanWallStyle = "Supply Fan Array"
                ThisUnitSFanPerf.Airflow = "10000"
                ThisUnitSFanPerf.ESP = "2.50"
                frmFanWall.ShowDialog()
            Case Is = "RFanWall"
                frmFanWall.FanWallStyle = "Return Fan Array"
                ThisUnitRXPerf.Airflow = "10000"
                ThisUnitRXPerf.ESP = "1.50"
                frmFanWall.ShowDialog()
            Case Is = "XFanWall"
                frmFanWall.FanWallStyle = "Exhaust Fan Array"
                ThisUnitRXPerf.Airflow = "10000"
                ThisUnitRXPerf.ESP = "1.50"
                frmFanWall.ShowDialog()
        End Select
    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click
        'frmXP.ShowDialog()
        'frmCoatings.ShowDialog()

        ThisUnit.Family = "Choice"
        frmOAFMS.ShowDialog()

    End Sub


    Private Sub cmbJumpDest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJumpDest.SelectedIndexChanged
        cmdJumpButton.Enabled = True
    End Sub

    Private Sub cmdPasteProjectDir_Click(sender As Object, e As EventArgs) Handles cmdPasteProjectDir.Click
        Dim clip As String
        clip = Clipboard.GetText
        If Mid(clip, 1, 5) = "local" Then
            clip = Mid(clip, 15) & "\"
        End If
        If Mid(clip, Len(clip), 1) <> "\" Then
            clip = clip & "\"
        End If
        txtProjectDirectory.Text = clip
    End Sub

    Private Sub BtnAirflowAdd_Click(sender As Object, e As EventArgs) Handles btnAirflowAdd.Click
        Dim i As Integer
        Dim dontdoit As Boolean

        dontdoit = False

        If lstUsingAirflow.Items.Count > 0 Then
            For i = 0 To lstUsingAirflow.Items.Count - 1
                If lstUsingAirflow.Items.Item(i) = lstAvailAirflow.Text Then
                    dontdoit = True
                End If
            Next
        End If
        If Not (dontdoit) Then
            lstUsingAirflow.Items.Add(lstAvailAirflow.Text)
        End If
        lstAvailAirflow.ClearSelected()
        txtAirflowDesc.Text = ""
    End Sub

    Private Sub BtnAirflowDel_Click(sender As Object, e As EventArgs) Handles btnAirflowDel.Click
        lstUsingAirflow.Items.Remove(lstUsingAirflow.SelectedItem)
    End Sub

    Private Sub BtnAirflowDelAll_Click(sender As Object, e As EventArgs) Handles btnAirflowDelAll.Click
        lstUsingAirflow.Items.Clear()
    End Sub

    Private Sub optEmerNA_CheckedChanged(sender As Object, e As EventArgs) Handles optEmerNA.CheckedChanged
        txtEmerVolts.Text = "-"
        txtEmerPhase.Text = "-"
        txtEmerFreq.Text = "-"

    End Sub

    Private Sub optEmerFusedDisc_CheckedChanged(sender As Object, e As EventArgs) Handles optEmerFusedDisc.CheckedChanged
        txtEmerVolts.Text = txtCommVolts.Text
        txtEmerPhase.Text = txtCommPhase.Text
        txtEmerFreq.Text = txtCommFreq.Text
    End Sub

    Private Sub optEmerNFDisc_CheckedChanged(sender As Object, e As EventArgs) Handles optEmerNFDisc.CheckedChanged
        txtEmerVolts.Text = txtCommVolts.Text
        txtEmerPhase.Text = txtCommPhase.Text
        txtEmerFreq.Text = txtCommFreq.Text
    End Sub

    Private Sub optEmerMLO_CheckedChanged(sender As Object, e As EventArgs) Handles optEmerMLO.CheckedChanged
        txtEmerVolts.Text = txtCommVolts.Text
        txtEmerPhase.Text = txtCommPhase.Text
        txtEmerFreq.Text = txtCommFreq.Text
    End Sub

    Private Sub cmdUPGERVModule_Click(sender As Object, e As EventArgs) Handles cmdUPGERVModule.Click
        If lstFieldInst.Items.Count > 0 Then
            If lstFieldInst.Items.Item(0) = "None" Then
                lstFieldInst.Items.Clear()
                lstFieldInst.Items.Add("UPG ERV Module - May ship separately.")
            Else
                lstFieldInst.Items.Add("UPG ERV Module - May ship separately.")
            End If
        End If


    End Sub

    Private Sub btnDoneCutSheets_Click(sender As Object, e As EventArgs) Handles btnDoneCutSheets.Click
        btnDoneCutSheets.Enabled = False
        tabMain.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub CopyEndDeviceCusSheets()
        Dim FileBase As String
        Dim FileName As String
        Dim BaseSourcePath As String
        Dim ProjectPath As String
        Dim BaseTargetPath1 As String
        Dim BaseTargetPath2 As String
        Dim i As Integer
        Dim FinalSourcePath As String
        Dim FinalTargetPath1 As String
        Dim FinalTargetPath2 As String

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

        MySQL = "SELECT * FROM tblEndDevices"
        rs.Open(MySQL, con)

        FileBase = ThisUnit.ResourcePath

        ProjectPath = txtProjectDirectory.Text


        BaseTargetPath1 = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\"
        BaseTargetPath2 = ProjectPath & "\" & ThisUnit.JobNumber & "-" & ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Cut Sheets to Include with Submittal\"
        BaseSourcePath = FileBase & "CutSheets\EndDevices\"

        For i = 0 To ThisUnitEndDevices.Count - 1
            rs.MoveFirst()
            rs.Find("ID=#" & Val(ThisUnitEndDevices.Item(i)) & "#")
            If rs.Fields("EDCutSheetPath").Value <> "-" Then
                FinalSourcePath = BaseSourcePath & rs.Fields("EDCutSheetPath").Value & rs.Fields("EDCutSheet").Value
                FileName = txtJobNumber.Text & "-" & txtUnitNumber.Text & " - Cut Sheet-" & rs.Fields("EDName").Value & " " & Ver2FileVer(txtUnitVersion.Text) & ".pdf"
                FinalTargetPath1 = BaseTargetPath1 & FileName
                FinalTargetPath2 = BaseTargetPath2 & FileName
                If My.Settings.UOMoveCuts2SD Then FileCopy(FinalSourcePath, FinalTargetPath1)
                If chkEDMovetoCutSheets.Checked Then FileCopy(FinalSourcePath, FinalTargetPath2)
            End If
        Next

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub optMLB6126_CheckedChanged(sender As Object, e As EventArgs) Handles optMLB6126.CheckedChanged
        If optMLB6126.Checked Or optMLB812U.Checked Then
            chkMLBExpansion.Enabled = True
        End If

        If ((optMLB6126.Checked = False) And (optMLB812U.Checked = False)) Then
            chkMLBExpansion.Checked = False
            chkMLBExpansion.Enabled = False
        End If
    End Sub

    Private Sub optMLB812U_CheckedChanged(sender As Object, e As EventArgs) Handles optMLB812U.CheckedChanged
        If optMLB6126.Checked Or optMLB812U.Checked Then
            chkMLBExpansion.Enabled = True
        End If

        If ((optMLB6126.Checked = False) And (optMLB812U.Checked = False)) Then
            chkMLBExpansion.Checked = False
            chkMLBExpansion.Enabled = False
        End If
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "Not Selected"
        ThisUnit.Family = SetUnitFamily()
        ThisUnit.Cabinet = SetUnitCabinet()
        ThisUnit.Kingdom = SetUnitKingdom()

        frmHistoryReport.ShowDialog()
    End Sub

    Private Sub picReferPreview_Click(sender As Object, e As EventArgs) Handles picReferPreview.Click
        Dim tempvar As String

        tempvar = ReferWMFPath.Item(lstAvailRefer.SelectedIndex)
        frmWMFZoom.ImagePath = tempvar
        frmWMFZoom.ShowDialog()

    End Sub

    Private Sub cmdReferApplyFilter_Click(sender As Object, e As EventArgs) Handles cmdReferApplyFilter.Click
        Call LoadApplicableRefer()
    End Sub

    Private Sub cmdClearFilter_Click(sender As Object, e As EventArgs) Handles cmdClearFilter.Click
        lstReferTagstoApply.SelectedItems.Clear()
        chkReferFilterOnStubb.Checked = False
        Call LoadApplicableRefer()
    End Sub

    Private Sub picUnitPreview_Click(sender As Object, e As EventArgs) Handles picUnitPreview.Click
        Dim tempvar As String

        tempvar = UnitWMFPAth.Item(lstAvailDwgs.SelectedIndex)
        frmWMFZoom.ImagePath = tempvar
        frmWMFZoom.ShowDialog()

    End Sub

    Private Sub cmdDwgApplyFilter_Click(sender As Object, e As EventArgs) Handles cmdDwgApplyFilter.Click
        Call LoadApplicableDrawings()
    End Sub

    Private Sub cmdDwgClearFilter_Click(sender As Object, e As EventArgs) Handles cmdDwgClearFilter.Click
        lstUnitTagstoApply.SelectedItems.Clear()
        chkUnitFilterOnStubbs.Checked = False
        Call LoadApplicableDrawings()
    End Sub

    Private Sub cmdUserOptions_Click(sender As Object, e As EventArgs) Handles cmdUserOptions.Click
        frmUserOptions.ShowDialog()
    End Sub

    Private Sub cmdReloadOldFile_Click(sender As Object, e As EventArgs) Handles cmdReloadOldFile.Click
        Dim FiletoLoad As String

        OpenFileDialog1.InitialDirectory = "J:\"
        OpenFileDialog1.ShowDialog()

        FiletoLoad = OpenFileDialog1.FileName
        Debug.Print(FiletoLoad)

    End Sub

    Private Sub cmdSoOLoadMods_Click(sender As Object, e As EventArgs) Handles cmdSoOLoadMods.Click
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstAvailableMods.Items.Clear()
        lstSelectedMods.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblModCodes ORDER BY ModPlainName"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstModsForSoO.Items.Add(rs.Fields("ModPlainName").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmdModsLoadMods_Click(sender As Object, e As EventArgs) Handles cmdModsLoadMods.Click
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstAvailableMods.Items.Clear()
        lstSelectedMods.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "Select * FROM tblModCodes ORDER BY ModPlainName"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstAvailableMods.Items.Add(rs.Fields("ModPlainName").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub cmdResearchMode_Click(sender As Object, e As EventArgs) Handles cmdResearchMode.Click
        Dim RQData As String
        Dim dummy As MsgBoxResult
        Dim MsgStr As String

        ThisUnit.Family = SetUnitFamily()
        ThisUnit.Cabinet = SetUnitCabinet()
        ThisUnit.Kingdom = SetUnitKingdom()

        Select Case cmbResearchTarget.Text

            Case Is = "Supply Fan"
                frmNewFan.FanStyle = "Supply Fan"
                RQData = InputBox("Please enter at least the first 5 digits of the model number you want to research.", "Fisen Unit Generator Research Mode", ThisUnit.ModelNumber)
                ThisUnit.ModelNumber = RQData
                frmNewFan.ResearchMode = True
                frmNewFan.ShowDialog()
                frmNewFan.ResearchMode = False
            Case Is = "Custom Controls"
                dummy = MsgBox("Have you selected the appropriate Unit Family?", vbYesNo, "Fisen Unit Generator")
                If dummy = vbYes Then

                Else
                    Exit Sub
                End If
            Case Is = "Custom Mechanical"

            Case Is = "Custom Power"

            Case Is = "Custom Refrigeration"

            Case Is = "Custom Sheetmetal"

            Case Else
                MsgStr = "Research for that module has not yet been implemented."
                dummy = MsgBox(MsgStr, vbOKOnly, "Fisen Unit Generator")
        End Select
    End Sub

    Private Sub optHMINone_CheckedChanged(sender As Object, e As EventArgs) Handles optHMINone.CheckedChanged
        Dim i As Integer
        If optHMINone.Checked Then
            For i = 0 To ThisUnitGenCodes.Count - 1
                If ((ThisUnitGenCodes.Item(i) = "960001") Or (ThisUnitGenCodes.Item(i) = "960002")) Then
                    ThisUnitGenCodes.RemoveAt(i)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub optHMIShipLoose_CheckedChanged(sender As Object, e As EventArgs) Handles optHMIShipLoose.CheckedChanged
        Dim i As Integer
        If optHMIShipLoose.Checked Then
            For i = 0 To ThisUnitGenCodes.Count - 1
                If ((ThisUnitGenCodes.Item(i) = "960001") Or (ThisUnitGenCodes.Item(i) = "960002")) Then
                    ThisUnitGenCodes.RemoveAt(i)
                    Exit For
                End If
            Next
            ThisUnitGenCodes.Add("960001")
        End If

    End Sub

    Private Sub optHMIInstalled_CheckedChanged(sender As Object, e As EventArgs) Handles optHMIInstalled.CheckedChanged
        Dim i As Integer
        If optHMIInstalled.Checked Then
            For i = 0 To ThisUnitGenCodes.Count - 1
                If ((ThisUnitGenCodes.Item(i) = "960001") Or (ThisUnitGenCodes.Item(i) = "960002")) Then
                    ThisUnitGenCodes.RemoveAt(i)
                    Exit For
                End If
            Next
            ThisUnitGenCodes.Add("960002")
        End If

    End Sub

    Private Sub cmdEndDeviceEdit_Click(sender As Object, e As EventArgs) Handles cmdEndDeviceEdit.Click
        frmEndDeviceMaintenance.ShowDialog()
    End Sub

    Private Sub cmdUpdateElecRecords_Click(sender As Object, e As EventArgs) Handles cmdUpdateElecRecords.Click
        Dim Snipet As String
        Dim Suffix As String

        frmUpdateElectricalTables.Volts = ThisUnitElecData.CommVolts
        frmUpdateElectricalTables.Phase = "3"
        Snipet = Mid(ThisUnit.ModelNumber, 1, 5)
        If Mid(Snipet, 1, 1) = "V" Then Snipet = Mid(Snipet, 1, 2) & "XXX"
        If Mid(Snipet, 1, 1) = "Y" Then Snipet = Mid(ThisUnit.ModelNumber, 1, 7)
        If ThisUnit.Family = "Select" Then
            Suffix = "-2"
            For i = 0 To ThisUnitFactOpts.Count - 1
                If ThisUnitFactOpts.Item(i) = "VAV Controller with VFD" Then Suffix = "-4"
            Next
            Snipet = Mid(ThisUnit.ModelNumber, 1, 4) & Suffix
        End If
        frmUpdateElectricalTables.Stubb = Snipet
        frmUpdateElectricalTables.ShowDialog()
        Call CalculateCustomMCA()

    End Sub

    Private Sub cmdAddNewFieldInstalled_Click(sender As Object, e As EventArgs) Handles cmdAddNewFieldInstalled.Click
        Dim i As Integer
        frmUpdateShipWithTables.ShowDialog()
        Call PopulateModGenFieldInstalleds()
        If ThisUnitFieldInst.Count > 0 Then
            lstFieldInst.Items.Clear()
            For i = 0 To ThisUnitFieldInst.Count - 1
                lstFieldInst.Items.Add(ThisUnitFieldInst.Item(i))
            Next

        End If
    End Sub

    Private Sub cmdUnitDrawingDBMaint_Click(sender As Object, e As EventArgs) Handles cmdUnitDrawingDBMaint.Click
        frmUpdateUnitDrawings.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmUpdateUnitDrawings.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmNewCustomCode.WhichCustom = "Power"
        ThisUnit.Family = "Series20"
        frmNewCustomCode.ShowDialog()

    End Sub

    Private Sub chkUnitFilterOnStubbs_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnitFilterOnStubbs.CheckedChanged
        Dim StubRoot As String
        Dim StubSuffix As String
        Dim FilterTag As String

        Select Case ThisUnit.Family
            Case Is = "Choice"
                StubRoot = "Choice"
                Select Case ThisUnit.NominalTons
                    Case Is = "15.0"
                        StubSuffix = "15"
                    Case Is = "17.5"
                        StubSuffix = "17"
                    Case Is = "20.0"
                        StubSuffix = "20"
                    Case Is = "25.0"
                        StubSuffix = "25"
                    Case Is = "27.5"
                        StubSuffix = "27"
                    Case Else
                        StubSuffix = "Error"
                        Stop
                End Select
            Case Is = "Series10"
                StubRoot = Mid(ThisUnit.ModelNumber, 1, 5)
            Case Is = "Series20"
                StubRoot = Mid(ThisUnit.ModelNumber, 1, 5)
            Case Is = "Select"
                StubRoot = "Select"
                Select Case ThisUnit.NominalTons
                    Case Is = "27.5"
                        StubSuffix = "28"
                    Case Is = "30.0"
                        StubSuffix = "30"
                    Case Is = "35.0"
                        StubSuffix = "35"
                    Case Is = "40.0"
                        StubSuffix = "40"
                    Case Is = "50.0"
                        StubSuffix = "50"
                    Case Else
                        StubSuffix = "Error"
                        Stop
                End Select
            Case Else
                StubRoot = "Error"
                Stop
        End Select
        FilterTag = StubRoot & StubSuffix
        lblStubTag.Text = FilterTag
    End Sub

    Private Sub cmdFisenIze_Click(sender As Object, e As EventArgs) Handles cmdFisenIze.Click
        Dim MyItem As String

        If lstFieldInst.SelectedIndex = -1 Then Exit Sub

        MyItem = lstFieldInst.SelectedItem
        MyItem = MyItem & " - Shall be installed in unit at Fisen prior to shipment to job site."
        lstFieldInst.Items(lstFieldInst.SelectedIndex) = MyItem
    End Sub
End Class