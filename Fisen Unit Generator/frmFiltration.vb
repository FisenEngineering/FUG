Public Class frmFiltration
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
        Call WriteFilterAuditReport
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("Filt") 'Mod Code goes here!

        Call UpdateCodeList()
        Me.Hide()

    End Sub
    Private Sub WriteFilterAuditReport()
        Dim FilterReport As System.IO.StreamWriter
        Dim TargetPath As String
        Dim i As Integer

        TargetPath = frmMain.txtProjectDirectory.Text
        TargetPath = TargetPath & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & "\Submittal Source (Do not Distribute)\Submittal Design\" & Trim(frmMain.ThisUnit.JobNumber) & "-" & frmMain.ThisUnit.UnitNumber & " - Filter Audit.txt"

        FilterReport = My.Computer.FileSystem.OpenTextFileWriter(TargetPath, False)
        FilterReport.WriteLine("Filter Audit")
        FilterReport.WriteLine(" ")
        FilterReport.WriteLine("Initial Filters")
        FilterReport.WriteLine("------------------------------------------------------------------")
        If chkIFBank.Checked Then
            FilterReport.WriteLine(cmbIFType.Text & " Initial Filters requested on proposal")
            FilterReport.WriteLine(cmbActIF.Text & " Initial Filters selected for installation by Fisen")
            For i = 0 To lstIFSelected.Items.Count - 1
                FilterReport.WriteLine(lstIFSelected.Items(i).ToString)
            Next
            If chkIFPrefilt.Checked Then
                FilterReport.WriteLine(" Prefilters Provided by Fisen: AAF PerfectPleat MERV8 2in")
                For i = 0 To lstIFSelected.Items.Count - 1
                    FilterReport.WriteLine(lstIFSelected.Items(i).ToString)
                Next
            End If
        Else
            FilterReport.WriteLine("No Initial Filter Bank by Fisen")
        End If

        FilterReport.WriteLine("Final Filters")
        FilterReport.WriteLine("------------------------------------------------------------------")
        If chkFFBank.Checked Then
            FilterReport.WriteLine(cmbFFType.Text & " Final Filters requested on proposal")
            FilterReport.WriteLine(cmbActFF.Text & " Initial Filters selected for installation by Fisen")
            For i = 0 To lstFFSelected.Items.Count - 1
                FilterReport.WriteLine(lstFFSelected.Items(i).ToString)
            Next
            If chkFFPrefilt.Checked Then
                FilterReport.WriteLine(" Prefilters Provided by Fisen: AAF PerfectPleat MERV8 2in")
                For i = 0 To lstFFSelected.Items.Count - 1
                    FilterReport.WriteLine(lstFFSelected.Items(i).ToString)
                Next
            End If
        Else
            FilterReport.WriteLine("No Final Filter Bank by Fisen")
        End If

        FilterReport.WriteLine("------------------------------------------------------------------")
        FilterReport.WriteLine(" ")
        FilterReport.Close()
    End Sub

    Private Sub UpdatePerformance()
        Dim YPALStaticName As String
        If chkFFBank.Checked Then
            YPALStaticName = "Final Filter Bank"
            frmMain.ThisUnitFFilters.HasNewFilters = True
            frmMain.ThisUnitFFilters.FilterBankName = "Final Filter Bank"
            frmMain.ThisUnitFFilters.FilterType = cmbActFF.Text
            frmMain.ThisUnitFFilters.FilterSize1 = lblFilterSize1.Text
            frmMain.ThisUnitFFilters.FilterSize2 = lblFilterSize2.Text
            frmMain.ThisUnitFFilters.FilterSize3 = lblFilterSize3.Text
            frmMain.ThisUnitFFilters.FilterSize4 = lblFilterSize4.Text
            frmMain.ThisUnitFFilters.FilterQ1 = lblFilterQ1.Text
            frmMain.ThisUnitFFilters.FilterQ2 = lblFilterQ2.Text
            frmMain.ThisUnitFFilters.FilterQ3 = lblFilterQ3.Text
            frmMain.ThisUnitFFilters.FilterQ4 = lblFilterQ4.Text
            frmMain.ThisUnitFFilters.FaceArea = lblFaceArea.Text
            frmMain.ThisUnitFFilters.FaceVelocity = lblFaceVelocity.Text
            frmMain.ThisUnitFFilters.FAPD = lblAPD.Text
            frmMain.ThisUnitFFilters.FMaxAPD = lblMaxAPD.Text
            frmMain.ThisUnitFFilters.FDFA = txtDFA.Text
            frmMain.ThisUnitFFilters.PreFilterPresent = chkFFPrefilt.Checked
            If chkFFPrefilt.Checked Then
                frmMain.ThisUnitFFilters.PreFilterPresent = True
                frmMain.ThisUnitFFilters.PrefilterType = "AAF PerfectPleat MERV8 2in"
                frmMain.ThisUnitFFilters.PreFiltAPD = lblPreFAPD.Text
                frmMain.ThisUnitFFilters.PreFiltMaxAPD = lblPreFMaxAPD.Text
                frmMain.ThisUnitFFilters.PreFiltDFA = txtPreFDFA.Text
                YPALStaticName = YPALStaticName & " + Prefilters"
            Else
                frmMain.ThisUnitFFilters.PreFilterPresent = False
            End If
            ' #ToDo handle inserting this value when XRange Fans are present.
            frmMain.ThisUnitFFilters.FStaticItem = lblStaticBudget.Text

            If frmMain.ThisUnit.Family = "Series100" Then
                frmMain.ThisUnitSFanPerf.StaticNameYpal.Add(YPALStaticName)
                frmMain.ThisUnitSFanPerf.StaticDataYpal.Add(lblStaticBudget.Text)
            End If
        End If

        If chkIFBank.Checked Then
            YPALStaticName = "Initial Filter Bank"
            frmMain.ThisUnitIFilters.HasNewFilters = True
            frmMain.ThisUnitIFilters.FilterBankName = "Initial Filter Bank"
            frmMain.ThisUnitIFilters.FilterType = cmbActIF.Text
            frmMain.ThisUnitIFilters.FilterSize1 = lblIFilterSize1.Text
            frmMain.ThisUnitIFilters.FilterSize2 = lblIFilterSize2.Text
            frmMain.ThisUnitIFilters.FilterSize3 = lblIFilterSize3.Text
            frmMain.ThisUnitIFilters.FilterSize4 = lblIFilterSize4.Text
            frmMain.ThisUnitIFilters.FilterQ1 = lblIFilterQ1.Text
            frmMain.ThisUnitIFilters.FilterQ2 = lblIFilterQ2.Text
            frmMain.ThisUnitIFilters.FilterQ3 = lblIFilterQ3.Text
            frmMain.ThisUnitIFilters.FilterQ4 = lblIFilterQ4.Text
            frmMain.ThisUnitIFilters.FaceArea = lblIFaceArea.Text
            frmMain.ThisUnitIFilters.FaceVelocity = lblIFaceVelocity.Text
            frmMain.ThisUnitIFilters.FAPD = lblIAPD.Text
            frmMain.ThisUnitIFilters.FMaxAPD = lblIMaxAPD.Text
            frmMain.ThisUnitIFilters.FDFA = txtIDFA.Text
            frmMain.ThisUnitIFilters.PreFilterPresent = chkIFPrefilt.Checked
            If chkIFPrefilt.Checked Then
                frmMain.ThisUnitIFilters.PreFilterPresent = True
                frmMain.ThisUnitIFilters.PrefilterType = "AAF PerfectPleat MERV8 2in"
                frmMain.ThisUnitIFilters.PreFiltAPD = lblPreIAPD.Text
                frmMain.ThisUnitIFilters.PreFiltMaxAPD = lblPreIMaxAPD.Text
                frmMain.ThisUnitIFilters.PreFiltDFA = txtPreIDFA.Text
                YPALStaticName = YPALStaticName & " + Prefilters"
            Else
                frmMain.ThisUnitIFilters.PreFilterPresent = False
            End If
            ' #ToDo handle inserting this value when XRange Fans are present.
            frmMain.ThisUnitIFilters.FStaticItem = lblIStaticBudget.Text

            If frmMain.ThisUnit.Family = "Series100" Then
                frmMain.ThisUnitSFanPerf.StaticNameYpal.Add(YPALStaticName)
                frmMain.ThisUnitSFanPerf.StaticDataYpal.Add(lblIStaticBudget.Text)
            End If
        End If
    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("395000")

        If chkIFBank.Checked Then
            ModuleCodeList.Add("395100") 'Initial Filter Bank
            Select Case cmbIFType.Text
                Case Is = "MERV 8 (1in)"
                    ModuleCodeList.Add("395101") 'M8 1 Inch
                Case Is = "MERV 8 (2in)"
                    ModuleCodeList.Add("395102") 'M8 2 Inch
                Case Is = "MERV 8 (4in)"
                    ModuleCodeList.Add("395104") 'M8 4 Inch
                Case Is = "MERV 14 (4in)"
                    ModuleCodeList.Add("395114") 'M8 4 Inch
                Case Is = "MERV 14 (6in)"
                    ModuleCodeList.Add("395116") 'M8 6 Inch
                Case Is = "MERV 14 (12in)"
                    ModuleCodeList.Add("39511C") 'M8 12 Inch
            End Select

            'Handle the Prefilter rack
            If chkIFPrefilt.Checked Then
                ModuleCodeList.Add("395190") 'Initial PreFilter Bank
                ModuleCodeList.Add("395192") 'Filters for the Prefilter bank
            End If
            If chkIFPrefiltUseJCI.Checked Then
                ModuleCodeList.Add("395199") 'Use JCI Bank as prefilters
            End If

            If optIFRackGalv.Checked Then
                ModuleCodeList.Add("3951A0") 'Galvanized Rack
            End If
            If optIFRackSS.Checked Then
                ModuleCodeList.Add("3951A1") 'SS Rack
            End If
            If optIFRackHEPAGalv.Checked Then
                ModuleCodeList.Add("3951A2") 'HEPA Galvanized Rack
            End If
            If optIFRackHEPASS.Checked Then
                ModuleCodeList.Add("3951A3") 'HEPA Galvanized Rack
            End If
        End If

        If chkFFBank.Checked Then
            ModuleCodeList.Add("395200") 'Final Filter Bank
            Select Case cmbFFType.Text
                Case Is = "MERV 8 (1in)"
                    ModuleCodeList.Add("395201") 'M8 1 Inch
                Case Is = "MERV 8 (2in)"
                    ModuleCodeList.Add("395202") 'M8 2 Inch
                Case Is = "MERV 8 (4in)"
                    ModuleCodeList.Add("395204") 'M8 4 Inch
                Case Is = "MERV 14 (4in)"
                    ModuleCodeList.Add("395214") 'M8 4 Inch
                Case Is = "MERV 14 (6in)"
                    ModuleCodeList.Add("395216") 'M8 6 Inch
                Case Is = "MERV 14 (12in)"
                    ModuleCodeList.Add("39521C") 'M8 12 Inch
            End Select
            'Handle the Prefilter rack
            If chkFFPrefilt.Checked Then
                ModuleCodeList.Add("395290") 'Initial PreFilter Bank
                ModuleCodeList.Add("395292") 'Filters for the Prefilter bank
            End If
            If optFFRackGalv.Checked Then
                ModuleCodeList.Add("3952A0") 'Galvanized Rack
            End If
            If optIFRackSS.Checked Then
                ModuleCodeList.Add("3952A1") 'SS Rack
            End If
            If optIFRackHEPAGalv.Checked Then
                ModuleCodeList.Add("3952A2") 'HEPA Galvanized Rack
            End If
            If optIFRackHEPASS.Checked Then
                ModuleCodeList.Add("3952A3") 'HEPA Galvanized Rack
            End If
        End If

        'This mimics a checkbox for the reconfiguration of a JCI bank (Hopefully)
        If grpCtrlFactory.Enabled = True Then
            ModuleCodeList.Add("395300") 'JCI Filter Bank R/R/R
            If chkRemoveJCIIPreFilts.Checked Then
                ModuleCodeList.Add("395301")
            End If
            If chkRemoveJCIIFilts.Checked Then
                ModuleCodeList.Add("395302")
            End If
            If chkRelocateJCIIPreFilts.Checked Then
                ModuleCodeList.Add("395303")
            End If
            If chkRelocateJCIIFilts.Checked Then
                ModuleCodeList.Add("395304")
            End If
            If chkRemoveJCIIFinalPreFilts.Checked Then
                ModuleCodeList.Add("395305")
            End If
            If chkRemoveJCIFFilts.Checked Then
                ModuleCodeList.Add("395306")
            End If
            If chkRelocateJCIIFinalPreFilts.Checked Then
                ModuleCodeList.Add("395307")
            End If
            If chkRelocateJCIFFilts.Checked Then
                ModuleCodeList.Add("395308")
            End If
        End If



        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i
    End Sub
    Private Sub UpdateWarrantyItems()
        'None
        frmMain.ThisUnitWarrTest.AirflowTest = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String


        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("Filt")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Horizontal S20 Return Fan Module")
        tempWeight = "9999"

        'tempWeight = "35"

        'Shallow V Series 40
        'tempWeight = 64

        'Series 20 drop in downflow only
        tempWeight = 732

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        Dim dummy As MsgBoxResult
        Dim FBChecked As Boolean
        FBChecked = chkIFBank.Checked Or chkFFBank.Checked Or chkRelocateJCIIPreFilts.Checked Or chkRelocateJCIIPreFilts.Checked
        FBChecked = FBChecked Or chkRemoveJCIIFilts.Checked Or chkRelocateJCIIFilts.Checked
        FBChecked = FBChecked Or chkRemoveJCIIFinalPreFilts.Checked Or chkRelocateJCIIFinalPreFilts.Checked Or chkRemoveJCIFFilts.Checked Or chkRelocateJCIFFilts.Checked

        If Not (FBChecked) Then
            dummy = MsgBox("You must select at least one filter bank.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If

        If Not (IsNumeric(txtAirflow.Text)) Then
            dummy = MsgBox("Airflow must be a numeric value.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If

        If Val(txtAirflow.Text) < 0 Then
            dummy = MsgBox("Airflow must be greater than zero.", vbOKOnly, "Fisen Unit Generator")
            Exit Sub
        End If
        txtAirflow.Text = Trim(txtAirflow.Text)
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        Dim dummy As MsgBoxResult
        Dim gtg As Boolean
        gtg = True
        If cmbIFMagRange.Text = "Unselected" Then gtg = False
        If cmbIFXdcrRange.Text = "Unselected" Then gtg = False
        If cmbJCIFMagRange.Text = "Unselected" Then gtg = False
        If cmbJCIFXdcrRange.Text = "Unselected" Then gtg = False
        If cmbFFMagRange.Text = "Unselected" Then gtg = False
        If cmbFFXdcrRange.Text = "Unselected" Then gtg = False
        If Not (gtg) Then
            dummy = MsgBox("You must select a range for the Transducer/Magnehelic", vbOKOnly, "Filter Module")
            Exit Sub
        End If

        TabControl1.SelectTab("tpgFilters")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs)
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub



    Private Sub frmFiltration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIFType.Text = "N/A"
        cmbFFType.Text = "N/A"

        txtAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow

        cmbExternalModuleStyle.Text = "No Module Required"
        cmbIFMagRange.Text = "n/a"
        cmbIFXdcrRange.Text = "n/a"
        cmbJCIFMagRange.Text = "n/a"
        cmbJCIFXdcrRange.Text = "n/a"
        cmbFFMagRange.Text = "n/a"
        cmbFFXdcrRange.Text = "n/a"
    End Sub

    Private Sub chkIFBank_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFBank.CheckedChanged
        If chkIFBank.Checked = True Then
            cmbIFType.Enabled = True
            chkIFPrefilt.Enabled = True
            grpCtrlInitital.Enabled = True

            grpIFRack.Enabled = True
            optIFRackGalv.Checked = True

            'The Filters Tab Prep
            cmbActIF.Enabled = True
            lstIFAvail.Enabled = True
            cmdAddIF.Enabled = True
            cmdSubIF.Enabled = True
            lstIFSelected.Enabled = True

        Else
            cmbIFType.Enabled = False
            lstIFAvail.Enabled = False
            cmdAddIF.Enabled = False
            cmdSubIF.Enabled = False
            lstIFSelected.Enabled = False

            grpIFRack.Enabled = False
            optIFRackNA.Checked = True

            cmbIFType.Text = "N/A"
            chkIFPrefilt.Enabled = False
            chkIFPrefilt.Checked = False
            grpCtrlInitital.Enabled = True
            chkIFMagnehelic.Checked = False
            chkIFXducer.Checked = False
            chkIFDFS.Checked = False
        End If

    End Sub

    Private Sub chkFFBank_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFBank.CheckedChanged
        If chkFFBank.Checked = True Then
            cmbFFType.Enabled = True
            chkFFPrefilt.Enabled = True
            grpCtrlFinal.Enabled = True

            grpFFRack.Enabled = True
            optFFRackGalv.Checked = True

            'The Filters Tab Prep
            cmbActFF.Enabled = True
            lstFFAvail.Enabled = True
            cmdAddFF.Enabled = True
            cmdSubFF.Enabled = True
            lstFFSelected.Enabled = True

        Else
            cmbFFType.Enabled = False
            lstFFAvail.Enabled = False
            cmdAddFF.Enabled = False
            cmdSubFF.Enabled = False
            lstFFSelected.Enabled = False

            grpFFRack.Enabled = False
            optFFRackNA.Checked = True

            cmbFFType.Text = "N/A"
            chkFFPrefilt.Enabled = False
            chkFFPrefilt.Checked = False
            grpCtrlFinal.Enabled = False
            chkFFMagnehelic.Checked = False
            chkFFXducer.Checked = False
            chkFFDFS.Checked = False
        End If
    End Sub



    Private Sub chkModJCIFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveJCIIPreFilts.CheckedChanged
        If chkRemoveJCIIPreFilts.Checked = True Then

        Else

        End If
    End Sub


    Private Sub btnDoneFilters_Click(sender As Object, e As EventArgs) Handles btnDoneFilters.Click
        If lstFFSelected.Items.Count > 0 Then
            grpFinalPerf.Visible = True
            Call CountFFilters()
            Call CalcFFFaceandVel()
            Call CalcFFAPD()
        End If

        If lstIFSelected.Items.Count > 0 Then
            grpInitialPerf.Visible = True
            Call CountIFilters()
            Call CalcIFaceandVel()
            Call CalcIFAPD()
        End If

        TabControl1.SelectTab("tpgPerformance")
    End Sub



    Private Sub CalcIFAPD()

        Dim recDFA As Double
        Dim statbudget As Double
        Dim PreAPD As Double
        Dim PreMaxAPD As Double
        Dim PreRecDFA As Double

        lblIAPD.Text = FilterAPD(cmbActIF.Text, lblIFaceVelocity.Text)
        lblIMaxAPD.Text = FilterMaxAPD(cmbActIF.Text)
        recDFA = Val(FilterAPD(cmbActIF.Text, lblIFaceVelocity.Text))
        If recDFA + Val(FilterAPD(cmbActIF.Text, lblIFaceVelocity.Text)) > Val(FilterMaxAPD(cmbActIF.Text)) Then recDFA = Val(FilterMaxAPD(cmbActIF.Text)) - Val(FilterAPD(cmbActIF.Text, lblIFaceVelocity.Text))
        If recDFA < 0 Then recDFA = 0
        txtIDFA.Text = Format(recDFA, "0.00")

        If chkIFPrefilt.Checked Then
            PreAPD = Val(FilterAPD("AAF PerfectPleat 2in M8", lblIFaceVelocity.Text))
            lblPreIAPD.Text = Format(PreAPD, "0.00")
            PreMaxAPD = Val(FilterMaxAPD("AAF PerfectPleat 2in M8"))
            lblPreIMaxAPD.Text = Format(PreMaxAPD, "0.00")
            PreRecDFA = PreAPD
            If PreRecDFA + PreAPD > PreMaxAPD Then PreRecDFA = PreMaxAPD - PreAPD
            If PreRecDFA < 0 Then PreRecDFA = 0
            txtPreIDFA.Text = Format(PreRecDFA, "0.00")
        Else
            lblPreIAPD.Text = "-"
            lblPreIMaxAPD.Text = "-"
            txtPreIDFA.Text = "-"
        End If

        statbudget = recDFA + Val(FilterAPD(cmbActIF.Text, lblIFaceVelocity.Text)) + PreRecDFA + PreAPD
        lblIStaticBudget.Text = Format(statbudget, "0.00")

    End Sub

    Private Sub CalcFFAPD()

        Dim recDFA As Double
        Dim statbudget As Double
        Dim PreAPD As Double
        Dim PreMaxAPD As Double
        Dim PreRecDFA As Double

        lblAPD.Text = FilterAPD(cmbActFF.Text, lblFaceVelocity.Text)
        lblMaxAPD.Text = FilterMaxAPD(cmbActFF.Text)
        recDFA = Val(FilterAPD(cmbActFF.Text, lblIFaceVelocity.Text))
        If recDFA + Val(FilterAPD(cmbActFF.Text, lblIFaceVelocity.Text)) > Val(FilterMaxAPD(cmbActFF.Text)) Then recDFA = Val(FilterMaxAPD(cmbActFF.Text)) - Val(FilterAPD(cmbActFF.Text, lblIFaceVelocity.Text))
        If recDFA < 0 Then recDFA = 0
        txtDFA.Text = Format(recDFA, "0.00")

        If chkFFPrefilt.Checked Then
            PreAPD = Val(FilterAPD("AAF PerfectPleat 2in M8", lblFaceVelocity.Text))
            lblPreFAPD.Text = Format(PreAPD, "0.00")
            PreMaxAPD = Val(FilterMaxAPD("AAF PerfectPleat 2in M8"))
            lblPreFMaxAPD.Text = Format(PreMaxAPD, "0.00")
            PreRecDFA = PreAPD
            If PreRecDFA + PreAPD > PreMaxAPD Then PreRecDFA = PreMaxAPD - PreAPD
            If PreRecDFA < 0 Then PreRecDFA = 0
            txtPreFDFA.Text = Format(PreRecDFA, "0.00")
        Else
            lblPreFAPD.Text = "-"
            lblPreFMaxAPD.Text = "-"
            txtPreFDFA.Text = "-"
        End If

        statbudget = recDFA + Val(FilterAPD(cmbActFF.Text, lblIFaceVelocity.Text)) + PreRecDFA + PreAPD
        lblStaticBudget.Text = Format(statbudget, "0.00")

    End Sub
    Private Sub CalcIFaceandVel()
        Dim l, w As Double
        Dim Face As Double
        Dim Vel As Double

        Face = 0
        If lblIFilterSize1.Text <> "" Then
            l = Val(Mid(lblIFilterSize1.Text, 1, 2))
            w = Val(Mid(lblIFilterSize1.Text, 4, 2))
            Face = l * w / 144 * Val(lblIFilterQ1.Text)
        End If
        If lblIFilterSize2.Text <> "" Then
            l = Val(Mid(lblIFilterSize2.Text, 1, 2))
            w = Val(Mid(lblIFilterSize2.Text, 4, 2))
            Face = (l * w / 144 * Val(lblIFilterQ2.Text)) + Face
        End If
        If lblIFilterSize3.Text <> "" Then
            l = Val(Mid(lblIFilterSize3.Text, 1, 2))
            w = Val(Mid(lblIFilterSize3.Text, 4, 2))
            Face = (l * w / 144 * Val(lblIFilterQ3.Text)) + Face
        End If
        If lblIFilterSize4.Text <> "" Then
            l = Val(Mid(lblIFilterSize4.Text, 1, 2))
            w = Val(Mid(lblIFilterSize4.Text, 4, 2))
            Face = (l * w / 144 * Val(lblIFilterQ4.Text)) + Face
        End If

        lblIFaceArea.Text = Format(Face, "0.0")
        Vel = Val(txtAirflow.Text) / Face
        lblIFaceVelocity.Text = Format(Vel, "0.0")
    End Sub
    Private Sub CalcFFFaceandVel()
        Dim l, w As Double
        Dim Face As Double
        Dim Vel As Double

        Face = 0
        If lblFilterSize1.Text <> "" Then
            l = Val(Mid(lblFilterSize1.Text, 1, 2))
            w = Val(Mid(lblFilterSize1.Text, 4, 2))
            Face = l * w / 144 * Val(lblFilterQ1.Text)
        End If
        If lblFilterSize2.Text <> "" Then
            l = Val(Mid(lblFilterSize2.Text, 1, 2))
            w = Val(Mid(lblFilterSize2.Text, 4, 2))
            Face = (l * w / 144 * Val(lblFilterQ2.Text)) + Face
        End If
        If lblFilterSize3.Text <> "" Then
            l = Val(Mid(lblFilterSize3.Text, 1, 2))
            w = Val(Mid(lblFilterSize3.Text, 4, 2))
            Face = (l * w / 144 * Val(lblFilterQ3.Text)) + Face
        End If
        If lblFilterSize4.Text <> "" Then
            l = Val(Mid(lblFilterSize4.Text, 1, 2))
            w = Val(Mid(lblFilterSize4.Text, 4, 2))
            Face = (l * w / 144 * Val(lblFilterQ4.Text)) + Face
        End If

        lblFaceArea.Text = Format(Face, "0.0")
        Vel = Val(txtAirflow.Text) / Face
        lblFaceVelocity.Text = Format(Vel, "0.0")
    End Sub
    Private Sub CountIFilters()


        lblIFilterSize1.Text = ""
        lblIFilterQ1.Text = ""
        lblIFilterSize2.Text = ""
        lblIFilterQ2.Text = ""
        lblIFilterSize3.Text = ""
        lblIFilterQ3.Text = ""
        lblIFilterSize4.Text = ""
        lblIFilterQ4.Text = ""

        If lstIFSelected.Items.Count > 0 Then
            lblIFilterSize1.Text = Mid(lstIFSelected.Items(0), 6)
            lblIFilterQ1.Text = Mid(lstIFSelected.Items(0), 2, 2)
        End If
        If lstIFSelected.Items.Count > 1 Then
            lblIFilterSize2.Text = Mid(lstIFSelected.Items(1), 6)
            lblIFilterQ2.Text = Mid(lstIFSelected.Items(1), 2, 2)
        End If
        If lstIFSelected.Items.Count > 2 Then
            lblIFilterSize3.Text = Mid(lstIFSelected.Items(2), 6)
            lblIFilterQ3.Text = Mid(lstIFSelected.Items(2), 2, 2)
        End If
        If lstIFSelected.Items.Count > 3 Then
            lblIFilterSize4.Text = Mid(lstIFSelected.Items(3), 6)
            lblIFilterQ4.Text = Mid(lstIFSelected.Items(3), 2, 2)
        End If

    End Sub
    Private Sub CountFFilters()


        lblFilterSize1.Text = ""
        lblFilterQ1.Text = ""
        lblFilterSize2.Text = ""
        lblFilterQ2.Text = ""
        lblFilterSize3.Text = ""
        lblFilterQ3.Text = ""
        lblFilterSize4.Text = ""
        lblFilterQ4.Text = ""

        If lstFFSelected.Items.Count > 0 Then
            lblFilterSize1.Text = Mid(lstFFSelected.Items(0), 6)
            lblFilterQ1.Text = Mid(lstFFSelected.Items(0), 2, 2)
        End If
        If lstFFSelected.Items.Count > 1 Then
            lblFilterSize2.Text = Mid(lstFFSelected.Items(1), 6)
            lblFilterQ2.Text = Mid(lstFFSelected.Items(1), 2, 2)
        End If
        If lstFFSelected.Items.Count > 2 Then
            lblFilterSize3.Text = Mid(lstFFSelected.Items(2), 6)
            lblFilterQ3.Text = Mid(lstFFSelected.Items(2), 2, 2)
        End If
        If lstFFSelected.Items.Count > 3 Then
            lblFilterSize4.Text = Mid(lstFFSelected.Items(3), 6)
            lblFilterQ4.Text = Mid(lstFFSelected.Items(3), 2, 2)
        End If

    End Sub



    Private Sub cmbActFF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActFF.SelectedIndexChanged
        Call FillAvailableFilterSizes("Final")

    End Sub

    Private Sub txtDFA_Leave(sender As Object, e As EventArgs) Handles txtDFA.Leave
        Dim apd As Double
        Dim dfa As Double
        Dim preapd As Double
        Dim predfa As Double
        Dim budget As Double

        apd = Val(lblAPD.Text)
        dfa = Val(txtDFA.Text)
        preapd = Val(lblPreFAPD.Text)
        predfa = Val(txtPreFDFA.Text)
        budget = apd + dfa + preapd + predfa
        budget = apd + dfa
        lblStaticBudget.Text = Format(budget, "0.00")
    End Sub

    Private Sub btnDonePerformance_Click_1(sender As Object, e As EventArgs) Handles btnDonePerformance.Click

        btnOK.Enabled = True
    End Sub

    Private Sub optExtModNone_CheckedChanged(sender As Object, e As EventArgs) Handles optExtModNone.CheckedChanged
        If optExtModNone.Checked Then
            cmbExternalModuleStyle.Items.Clear()
            cmbExternalModuleStyle.Items.Add("No Module Required")
            cmbExternalModuleStyle.Text = "No Module Required"
        End If
    End Sub

    Private Sub optExtModHoriz_CheckedChanged(sender As Object, e As EventArgs) Handles optExtModHoriz.CheckedChanged
        If optExtModHoriz.Checked Then
            cmbExternalModuleStyle.Items.Clear()
            cmbExternalModuleStyle.Items.Add("Unselected")
            Select Case frmMain.ThisUnit.Family
                'Modules should have names that look like this:
                '
                Case Is = "Series5"

                Case Is = "Series10"
                    'This is a placeholder only
                    cmbExternalModuleStyle.Items.Add("S10 Horizontal XXX Discharge Module")
                Case Is = "Series12"

                Case Is = "Series20"
                    cmbExternalModuleStyle.Items.Add("S20 Horizontal Discharge Module")
                Case Is = "Series40"
                 'Depricated *Probably not going to be used*
                Case Is = "Series100"

                Case Is = "Premier"

                Case Is = "Choice"

                Case Else

            End Select
            cmbExternalModuleStyle.Items.Add("Custom Module")
            cmbExternalModuleStyle.Text = "Unselected"
        End If
    End Sub

    Private Sub optExtModDown_CheckedChanged(sender As Object, e As EventArgs) Handles optExtModDown.CheckedChanged
        If optExtModDown.Checked Then
            cmbExternalModuleStyle.Items.Clear()
            cmbExternalModuleStyle.Items.Add("Unselected")
            Select Case frmMain.ThisUnit.Family
                'Modules should have names that look like this:
                '
                Case Is = "Series5"

                Case Is = "Series10"
                    'This is a placeholder only
                    cmbExternalModuleStyle.Items.Add("S10 Downflow XXX Discharge Module")
                Case Is = "Series12"

                Case Is = "Series20"
                    'This is a placeholder/not the real thing.
                    cmbExternalModuleStyle.Items.Add("S20 Downflow XXX Discharge Module")
                Case Is = "Series40"
                 'Depricated *Probably not going to be used*
                Case Is = "Series100"
                    'This is a placeholder/not the real thing.
                    cmbExternalModuleStyle.Items.Add("S100 Downflow XXX Discharge Module")
                Case Is = "Premier"

                Case Is = "Choice"

                Case Else

            End Select
            cmbExternalModuleStyle.Items.Add("Custom Module")
            cmbExternalModuleStyle.Text = "Unselected"
        End If
    End Sub

    Private Sub optExtMod3Party_CheckedChanged(sender As Object, e As EventArgs) Handles optExtMod3Party.CheckedChanged
        If optExtMod3Party.Checked Then
            cmbExternalModuleStyle.Items.Clear()
            cmbExternalModuleStyle.Items.Add("Unselected")
            Select Case frmMain.ThisUnit.Family
                'Modules should have names that look like this:
                '
                Case Is = "Series5"

                Case Is = "Series10"
                    'This is a placeholder only
                    cmbExternalModuleStyle.Items.Add("S10 Downflow XXX Discharge Module")
                Case Is = "Series12"

                Case Is = "Series20"
                    'This is a placeholder/not the real thing.
                    cmbExternalModuleStyle.Items.Add("S20 Downflow XXX Discharge Module")
                Case Is = "Series40"
                 'Depricated *Probably not going to be used*
                Case Is = "Series100"
                    'This is a placeholder/not the real thing.
                    cmbExternalModuleStyle.Items.Add("S100 Downflow XXX Discharge Module")
                Case Is = "Premier"

                Case Is = "Choice"

                Case Else

            End Select
        End If
        cmbExternalModuleStyle.Items.Add("Custom Module")
            cmbExternalModuleStyle.Text = "Unselected"
    End Sub

    Private Sub chkRelocateJCIIPreFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkRelocateJCIIPreFilts.CheckedChanged
        If ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = True
        End If
        If Not ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = False
            chkJCIFMagnehelic.Checked = False
            chkJCIFXducer.Checked = False
            chkJCIFDFS.Checked = False
        End If

    End Sub

    Private Sub chkRemoveJCIIFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveJCIIFilts.CheckedChanged
        If ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = True
        End If
        If Not ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = False
            chkJCIFMagnehelic.Checked = False
            chkJCIFXducer.Checked = False
            chkJCIFDFS.Checked = False
        End If

    End Sub

    Private Sub chkRemoveJCIIFinalPreFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveJCIIFinalPreFilts.CheckedChanged
        If ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = True
        End If
        If Not ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = False
            chkJCIFMagnehelic.Checked = False
            chkJCIFXducer.Checked = False
            chkJCIFDFS.Checked = False
        End If

    End Sub

    Private Sub chkRemoveJCIFFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveJCIFFilts.CheckedChanged
        If ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = True
        End If
        If Not ((chkRelocateJCIIPreFilts.Checked) Or (chkRelocateJCIIFilts.Checked) Or (chkRelocateJCIIFinalPreFilts.Checked) Or (chkRelocateJCIFFilts.Checked)) Then
            grpCtrlFactory.Enabled = False
            chkJCIFMagnehelic.Checked = False
            chkJCIFXducer.Checked = False
            chkJCIFDFS.Checked = False
        End If

    End Sub

    Private Sub chkIFMagnehelic_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFMagnehelic.CheckedChanged
        If chkIFMagnehelic.Checked Then
            cmbIFMagRange.Enabled = True
            cmbIFMagRange.Text = "Unselected"
            chkIFMinihelic.Enabled = True
        Else
            cmbIFMagRange.Enabled = False
            cmbIFMagRange.Text = "n/a"
            chkIFMinihelic.Enabled = False
            chkIFMinihelic.Checked = False

        End If
    End Sub

    Private Sub chkJCIFMagnehelic_CheckedChanged(sender As Object, e As EventArgs) Handles chkJCIFMagnehelic.CheckedChanged
        If chkJCIFMagnehelic.Checked Then
            cmbJCIFMagRange.Enabled = True
            cmbJCIFMagRange.Text = "Unselected"
            chkJCIFMinihelic.Enabled = True
        Else
            cmbJCIFMagRange.Enabled = False
            cmbJCIFMagRange.Text = "n/a"
            chkJCIFMinihelic.Enabled = False
            chkJCIFMinihelic.Checked = False

        End If
    End Sub
    Private Sub chkFFMagnehelic_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFMagnehelic.CheckedChanged
        If chkFFMagnehelic.Checked = True Then
            cmbFFMagRange.Enabled = True
            cmbFFMagRange.Text = "Unselected"
            chkFFMinihelic.Enabled = True
        Else
            cmbFFMagRange.Enabled = False
            cmbFFMagRange.Text = "n/a"
            chkFFMinihelic.Enabled = False
            chkFFMinihelic.Checked = False
        End If
    End Sub



    Private Sub chkIFXducer_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFXducer.CheckedChanged
        If chkIFXducer.Checked = True Then
            cmbIFXdcrRange.Enabled = True
            cmbIFXdcrRange.Text = "Unselected"
            chkIFXdcrWire.Enabled = True
        Else
            cmbIFXdcrRange.Enabled = False
            cmbIFXdcrRange.Text = "n/a"
            chkIFXdcrWire.Enabled = False
            chkIFXdcrWire.Checked = False
        End If
    End Sub

    Private Sub chkJCIFXducer_CheckedChanged(sender As Object, e As EventArgs) Handles chkJCIFXducer.CheckedChanged
        If chkJCIFXducer.Checked = True Then
            cmbJCIFXdcrRange.Enabled = True
            cmbJCIFXdcrRange.Text = "Unselected"
            chkJCIFXdcrWire.Enabled = True
        Else
            cmbJCIFXdcrRange.Enabled = False
            cmbJCIFXdcrRange.Text = "n/a"
            chkJCIFXdcrWire.Enabled = False
            chkJCIFXdcrWire.Checked = False
        End If
    End Sub

    Private Sub chkFFXducer_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFXducer.CheckedChanged
        If chkFFXducer.Checked = True Then
            cmbFFXdcrRange.Enabled = True
            cmbFFXdcrRange.Text = "Unselected"
            chkFFXdcrWire.Enabled = True
        Else
            cmbFFXdcrRange.Enabled = False
            cmbFFXdcrRange.Text = "n/a"
            chkFFXdcrWire.Enabled = False
            chkFFXdcrWire.Checked = False
        End If
    End Sub

    Private Sub chkIFDFS_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFDFS.CheckedChanged
        If chkIFDFS.Checked = True Then
            chkIFDFSWire.Enabled = True
        Else
            chkIFDFSWire.Enabled = False
            chkIFDFSWire.Checked = False
        End If
    End Sub

    Private Sub chkJCIFDFS_CheckedChanged(sender As Object, e As EventArgs) Handles chkJCIFDFS.CheckedChanged
        If chkJCIFDFS.Checked = True Then
            chkJCIFDFSWire.Enabled = True
        Else
            chkJCIFDFSWire.Enabled = False
            chkJCIFDFSWire.Checked = False
        End If
    End Sub

    Private Sub chkFFDFS_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFDFS.CheckedChanged
        If chkFFDFS.Checked = True Then
            chkFFDFSWire.Enabled = True
        Else
            chkFFDFSWire.Enabled = False
            chkFFDFSWire.Checked = False
        End If
    End Sub


    Private Sub cmdAddFF_Click(sender As Object, e As EventArgs) Handles cmdAddFF.Click
        Dim FilterToAdd As String
        Dim FilterCount As Integer
        Dim FilterThere As Boolean
        Dim FoundFilterID As Integer
        Dim i As Integer

        FilterThere = False
        FilterToAdd = lstFFAvail.Text
        For i = 0 To lstFFSelected.Items.Count - 1
            If CStr(Mid(lstFFSelected.Items(i), 6)) = FilterToAdd Then
                FilterThere = True
                FoundFilterID = i
            End If
        Next
        If FilterThere Then
            FilterCount = Val(Mid(lstFFSelected.Items(FoundFilterID), 2, 2))
            FilterCount = FilterCount + 1
            lstFFSelected.Items(FoundFilterID) = "(" & Format(FilterCount, "00") & ")" & " " & FilterToAdd
            If chkFFPrefilt.Checked Then
                lstPreFFSelected.Items(FoundFilterID) = "(" & Format(FilterCount, "00") & ")" & " " & FilterToAdd
            End If
        Else
            lstFFSelected.Items.Add("(01) " & FilterToAdd)
            If chkFFPrefilt.Checked Then
                lstPreFFSelected.Items.Add("(01) " & FilterToAdd)
            End If
        End If

        If lstFFSelected.Items.Count = 4 Then cmdAddFF.Enabled = False

    End Sub

    Private Sub cmdSubFF_Click(sender As Object, e As EventArgs) Handles cmdSubFF.Click
        Dim FilterCount As Integer
        Dim FilterName As String
        Dim RemLine As Integer

        If lstFFSelected.Items.Count > -1 Then
            FilterCount = Val(Mid(lstFFSelected.Items(lstFFSelected.SelectedIndex), 2, 2))
            FilterName = Mid(lstFFSelected.Items(lstFFSelected.SelectedIndex), 6)
            RemLine = lstFFSelected.SelectedIndex
            If FilterCount = 1 Then
                lstFFSelected.Items.Remove(lstFFSelected.SelectedItem)
                If chkFFPrefilt.Checked Then
                    lstPreFFSelected.Items.RemoveAt(RemLine)
                End If
            Else
                FilterCount = FilterCount - 1
                lstFFSelected.Items(lstFFSelected.SelectedIndex) = "(" & Format(FilterCount, "00") & ")" & " " & FilterName
                If chkFFPrefilt.Checked Then
                    lstPreFFSelected.Items(RemLine) = "(" & Format(FilterCount, "00") & ")" & " " & FilterName
                End If
            End If
        End If

        If lstFFSelected.Items.Count < 4 Then cmdAddFF.Enabled = True

    End Sub
    Private Sub cmdAddIF_Click(sender As Object, e As EventArgs) Handles cmdAddIF.Click
        Dim FilterToAdd As String
        Dim FilterCount As Integer
        Dim FilterThere As Boolean
        Dim FoundFilterID As Integer
        Dim i As Integer

        FilterThere = False
        FilterToAdd = lstIFAvail.Text
        For i = 0 To lstIFSelected.Items.Count - 1
            If CStr(Mid(lstIFSelected.Items(i), 6)) = FilterToAdd Then
                FilterThere = True
                FoundFilterID = i
            End If

        Next
        If FilterThere Then
            FilterCount = Val(Mid(lstIFSelected.Items(FoundFilterID), 2, 2))
            FilterCount = FilterCount + 1
            lstIFSelected.Items(FoundFilterID) = "(" & Format(FilterCount, "00") & ")" & " " & FilterToAdd
            If chkIFPrefilt.Checked Then
                lstPreIFSelected.Items(FoundFilterID) = "(" & Format(FilterCount, "00") & ")" & " " & FilterToAdd
            End If
        Else
            lstIFSelected.Items.Add("(01) " & FilterToAdd)
            If chkIFPrefilt.Checked Then
                lstPreIFSelected.Items.Add("(01) " & FilterToAdd)
            End If
        End If
        If lstIFSelected.Items.Count = 4 Then cmdAddIF.Enabled = False
    End Sub

    Private Sub cmdSubIF_Click(sender As Object, e As EventArgs) Handles cmdSubIF.Click
        Dim FilterCount As Integer
        Dim FilterName As String
        Dim RemLine As Integer

        If lstIFSelected.Items.Count > -1 Then
            FilterCount = Val(Mid(lstIFSelected.Items(lstIFSelected.SelectedIndex), 2, 2))
            FilterName = Mid(lstIFSelected.Items(lstIFSelected.SelectedIndex), 6)
            RemLine = lstIFSelected.SelectedIndex
            If FilterCount = 1 Then

                lstIFSelected.Items.Remove(lstIFSelected.SelectedItem)
                If chkIFPrefilt.Checked Then
                    lstPreIFSelected.Items.RemoveAt(RemLine)
                End If
            Else
                FilterCount = FilterCount - 1
                lstIFSelected.Items(lstIFSelected.SelectedIndex) = "(" & Format(FilterCount, "00") & ")" & " " & FilterName
                If chkIFPrefilt.Checked Then
                    lstPreIFSelected.Items(RemLine) = "(" & Format(FilterCount, "00") & ")" & " " & FilterName
                End If
            End If
        End If
        If lstFFSelected.Items.Count < 4 Then cmdAddFF.Enabled = True
    End Sub

    Private Sub txtIDFA_Leave(sender As Object, e As EventArgs) Handles txtIDFA.Leave
        Dim apd As Double
        Dim dfa As Double
        Dim preapd As Double
        Dim predfa As Double
        Dim budget As Double

        apd = Val(lblIAPD.Text)
        dfa = Val(txtIDFA.Text)
        preapd = Val(lblPreIAPD.Text)
        predfa = Val(txtPreIDFA.Text)
        budget = apd + dfa + preapd + predfa
        lblIStaticBudget.Text = Format(budget, "0.00")
    End Sub

    Private Sub cmbActIF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActIF.SelectedIndexChanged
        Call FillAvailableFilterSizes("Initial")
    End Sub
    Private Sub PopulateFilterOptsVCM14x12(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("24x24x12")
        MyListBox.Items.Add("20x25x12")
        MyListBox.Items.Add("20x24x12")
        MyListBox.Items.Add("20x20x12")
        MyListBox.Items.Add("18x24x12")
        MyListBox.Items.Add("16x25x12")
        MyListBox.Items.Add("16x20x12")
        MyListBox.Items.Add("12x24x12")
    End Sub
    Private Sub PopulateFilterOptsVC2M14x4(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("24x24x12")
        MyListBox.Items.Add("20x25x12")
        MyListBox.Items.Add("20x24x12")
        MyListBox.Items.Add("20x20x12")
        MyListBox.Items.Add("18x24x12")
        MyListBox.Items.Add("16x25x12")
        MyListBox.Items.Add("16x20x12")
        MyListBox.Items.Add("12x24x12")
        MyListBox.Items.Add("12x12x12")
    End Sub
    Private Sub PopulateFilterOptsPPM8x2(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("10x20x2")
        MyListBox.Items.Add("12x20x2")
        MyListBox.Items.Add("12x24x2")
        MyListBox.Items.Add("14x25x2")
        MyListBox.Items.Add("15x20x2")
        MyListBox.Items.Add("15x25x2")
        MyListBox.Items.Add("16x16x2")
        MyListBox.Items.Add("16x20x2")
        MyListBox.Items.Add("16x24x2")
        MyListBox.Items.Add("16x25x2")
        MyListBox.Items.Add("18x24x2")
        MyListBox.Items.Add("18x25x2")
        MyListBox.Items.Add("20x20x2")
        MyListBox.Items.Add("20x24x2")
        MyListBox.Items.Add("20x25x2")
        MyListBox.Items.Add("24x24x2")
        MyListBox.Items.Add("25x25x2")
    End Sub
    Private Sub PopulateFilterOptsPPHCM8x2(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("10x20x2")
        MyListBox.Items.Add("12x20x2")
        MyListBox.Items.Add("12x24x2")
        MyListBox.Items.Add("14x25x2")
        MyListBox.Items.Add("15x20x2")
        MyListBox.Items.Add("15x25x2")
        MyListBox.Items.Add("16x16x2")
        MyListBox.Items.Add("16x20x2")
        MyListBox.Items.Add("16x24x2")
        MyListBox.Items.Add("16x25x2")
        MyListBox.Items.Add("18x24x2")
        MyListBox.Items.Add("18x25x2")
        MyListBox.Items.Add("20x20x2")
        MyListBox.Items.Add("20x24x2")
        MyListBox.Items.Add("20x25x2")
        MyListBox.Items.Add("24x24x2")
        MyListBox.Items.Add("25x25x2")
    End Sub
    Private Sub PopulateFilterOptsPPHCM8x1(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("10x10")
        MyListBox.Items.Add("10x20")
        MyListBox.Items.Add("12x20")
        MyListBox.Items.Add("12x24")
        MyListBox.Items.Add("14x25")
        MyListBox.Items.Add("15x20")
        MyListBox.Items.Add("15x25")
        MyListBox.Items.Add("16x16")
        MyListBox.Items.Add("16x20")
        MyListBox.Items.Add("16x24")
        MyListBox.Items.Add("16x25")
        MyListBox.Items.Add("18x24")
        MyListBox.Items.Add("18x25")
        MyListBox.Items.Add("20x20")
        MyListBox.Items.Add("20x24")
        MyListBox.Items.Add("20x25")
        MyListBox.Items.Add("24x24")
        MyListBox.Items.Add("25x25")
    End Sub
    Private Sub PopulateFilterOptsPPM8x4(MyBank As String)
        Dim MyListBox As New ListBox
        MyListBox = tpgFilters.Controls("lstFFAvail")
        If MyBank = "Final" Then
            MyListBox = tpgFilters.Controls("lstFFAvail")
        End If
        If MyBank = "Initial" Then
            MyListBox = tpgFilters.Controls("lstIFAvail")
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("12x24x4")
        MyListBox.Items.Add("16x20x4")
        MyListBox.Items.Add("16x25x4")
        MyListBox.Items.Add("18x24x4")
        MyListBox.Items.Add("20x20x4")
        MyListBox.Items.Add("20x25x4")
        MyListBox.Items.Add("24x20x4")
        MyListBox.Items.Add("24x24x4")
        MyListBox.Items.Add("25x29x4")
    End Sub
    Private Sub FillAvailableFilterSizes(WhichBank As String)
        Dim FilterType As String
        If WhichBank = "Initial" Then
            FilterType = cmbActIF.Text
        End If
        If WhichBank = "Final" Then
            FilterType = cmbActFF.Text
        End If

        Select Case FilterType
            Case Is = "AAF PerfectPleat HC 1in M8"
                Call PopulateFilterOptsPPHCM8x1(WhichBank)
            Case Is = "AAF PerfectPleat 2in M8"
                Call PopulateFilterOptsPPM8x2(WhichBank)
            Case Is = "AAF PerfectPleat HC 2in M8"
                Call PopulateFilterOptsPPHCM8x2(WhichBank)
            Case Is = "AAF PerfectPleat 4in M8"
                Call PopulateFilterOptsPPM8x4(WhichBank)
            Case Is = "AAF Varicell 12in M14"
                Call PopulateFilterOptsVCM14x12(WhichBank)
            Case Is = "AAF Varicell II 4in M14"
                Call PopulateFilterOptsVC2M14x4(WhichBank)

        End Select
    End Sub
    Private Sub cmbIFType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIFType.SelectedIndexChanged
        Select Case cmbIFType.Text
            Case Is = "MERV 8 (1in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF PerfectPleat HC 1in M8")
                cmbActIF.Text = "AAF PerfectPleat HC 1in M8"
            Case Is = "MERV 8 (2in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF PerfectPleat 2in M8")
                cmbActIF.Items.Add("AAF PerfectPleat HC 2in M8")
                cmbActIF.Text = "AAF PerfectPleat 2in M8"
            Case Is = "MERV 8 (4in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF PerfectPleat 4in M8")
                cmbActIF.Text = "AAF PerfectPleat 4in M8"
            Case Is = "MERV 14 (12in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF Varicell 12in M14")
                cmbActIF.Text = "AAF Varicell 12in M14"
            Case Is = "MERV 14 (4in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF Varicell II 4in M14")
                cmbActIF.Text = "AAF Varicell II 4in M14"
        End Select
    End Sub
    Private Sub cmbFFType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFFType.SelectedIndexChanged
        Select Case cmbFFType.Text
            Case Is = "MERV 8 (1in)"
                cmbActFF.Items.Clear()
                cmbActFF.Items.Add("AAF PerfectPleat HC 1in M8")
                cmbActFF.Text = "AAF PerfectPleat HC 1in M8"
            Case Is = "MERV 8 (2in)"
                cmbActFF.Items.Clear()
                cmbActFF.Items.Add("AAF PerfectPleat 2in M8")
                cmbActFF.Items.Add("AAF PerfectPleat HC 2in M8")
                cmbActFF.Text = "AAF PerfectPleat 2in M8"
            Case Is = "MERV 8 (4in)"
                cmbActIF.Items.Clear()
                cmbActIF.Items.Add("AAF PerfectPleat 4in M8")
                cmbActIF.Text = "AAF PerfectPleat 4in M8"
            Case Is = "MERV 14 (12in)"
                cmbActFF.Items.Clear()
                cmbActFF.Items.Add("AAF Varicell 12in M14")
                cmbActFF.Text = "AAF Varicell 12in M14"
            Case Is = "MERV 14 (4in)"
                cmbActFF.Items.Clear()
                cmbActFF.Items.Add("AAF Varicell II 4in M14")
                cmbActFF.Text = "AAF Varicell II 4in M14"
        End Select
    End Sub
    Private Function FilterAPD(FilterType As String, FaceVelocity As String) As String
        Dim lapd As Double
        Dim lvel As Double

        lvel = Val(FaceVelocity)
        Select Case FilterType
            Case Is = "AAF Varicell 12in M14"
                lapd = 0.000001785714 * lvel ^ 2 + 0.000001428571 * lvel + 0.128

            Case Is = "AAF Varicell II 4in M14"
                lapd = 0.000001188571 * lvel ^ 2 + 0.000676571429 * lvel - 0.006

            Case Is = "AAF PerfectPleat 2in M8"
                lapd = 0.000000457143 * lvel ^ 2 + 0.000217142857 * lvel + 0.016
            Case Is = "AAF PerfectPleat 4in M8"
                lapd = 0.000000685714 * lvel ^ 2 + 0.000117714286 * lvel + 0.006
            Case Is = "AAF PerfectPleat HC 1in M8"
                lapd = 0.00000048 * lvel ^ 2 + 0.000636 * lvel - 0.0175
            Case Is = "AAF PerfectPleat HC 2in M8"
                lapd = 0.000000548571 * lvel ^ 2 + 0.000196571429 * lvel + 0.000000000000
            Case Else
                lapd = -99.99
        End Select
        lapd = lapd * 1.05 'Cover error in the curve fitting

        Return Format(lapd, "0.00")
    End Function

    Private Function FilterMaxAPD(FilterType As String) As String
        Dim maxapd As Double
        Select Case FilterType
            Case Is = "AAF Varicell 12in M14"
                maxapd = 1.5
            Case Is = "AAF Varicell II 4in M14"
                maxapd = 1.5
            Case Is = "AAF PerfectPleat 2in M8"
                maxapd = 1
            Case Is = "AAF PerfectPleat 4in M8"
                maxapd = 1
            Case Is = "AAF PerfectPleat HC 1in M8"
                maxapd = 1
            Case Is = "AAF PerfectPleat HC 2in M8"
                maxapd = 1
            Case Else
                maxapd = -99.99
        End Select
        Return Format(maxapd, "0.00")

    End Function
    Private Sub chkIFPrefilt_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFPrefilt.CheckedChanged
        If chkIFPrefilt.Checked Then
            lstPreIFSelected.Enabled = True
        Else
            lstPreIFSelected.Enabled = False
        End If

    End Sub

    Private Sub chkFFPrefilt_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFPrefilt.CheckedChanged
        If chkFFPrefilt.Checked Then
            lstPreFFSelected.Enabled = True
        Else
            lstPreFFSelected.Enabled = False
        End If
    End Sub

    Private Sub txtPreFDFA_Leave(sender As Object, e As EventArgs) Handles txtPreFDFA.Leave
        Dim apd As Double
        Dim dfa As Double
        Dim preapd As Double
        Dim predfa As Double
        Dim budget As Double

        apd = Val(lblAPD.Text)
        dfa = Val(txtDFA.Text)
        preapd = Val(lblPreFAPD.Text)
        predfa = Val(txtPreFDFA.Text)
        budget = apd + dfa + preapd + predfa
        lblStaticBudget.Text = Format(budget, "0.00")
    End Sub

    Private Sub txtPreIDFA_Leave(sender As Object, e As EventArgs) Handles txtPreIDFA.Leave
        Dim apd As Double
        Dim dfa As Double
        Dim preapd As Double
        Dim predfa As Double
        Dim budget As Double

        apd = Val(lblIAPD.Text)
        dfa = Val(txtIDFA.Text)
        preapd = Val(lblPreIAPD.Text)
        predfa = Val(txtPreIDFA.Text)
        budget = apd + dfa + preapd + predfa
        lblIStaticBudget.Text = Format(budget, "0.00")
    End Sub
End Class