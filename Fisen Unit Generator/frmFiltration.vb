Public Class frmFiltration
    Private pCancelled As Boolean
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
        frmMain.ThisUnitMods.Add("Filt") 'Mod Code goes here!

        Call UpdateCodeList()
        Me.Hide()

    End Sub

    Private Sub UpdatePerformance()
        If chkFFBank.Checked Then
            frmMain.ThisUnitFilters.HasNewFinalFilters = True
            frmMain.ThisUnitFilters.FFilterSize1 = lblFilterSize1.Text
            frmMain.ThisUnitFilters.FFilterSize2 = lblFilterSize2.Text
            frmMain.ThisUnitFilters.FFilterSize3 = lblFilterSize3.Text
            frmMain.ThisUnitFilters.FFilterQ1 = lblFilterQ1.Text
            frmMain.ThisUnitFilters.FFilterQ2 = lblFilterQ2.Text
            frmMain.ThisUnitFilters.FFilterQ3 = lblFilterQ3.Text
            frmMain.ThisUnitFilters.FFFaceArea =
            frmMain.ThisUnitFilters.FFFaceVelocity
            frmMain.ThisUnitFilters.FFAPD = lblFaceArea.Text
            frmMain.ThisUnitFilters.FFMaxAPD = lblMaxAPD.Text
            frmMain.ThisUnitFilters.FFDFA = txtDFA.Text
            frmMain.ThisUnitFilters.FFStaticItem = lblStaticBudget.Text
        End If
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("395000")
        If chkFFBank.Checked Then
            frmMain.ThisUnitCodes.Add("395800") 'Final Filter Bank
            Select Case cmbFFType.Text
                Case Is = "MERV 14 (12in)"
            End Select
        End If



        frmMain.ThisUnitCodes.Add("395110")
        frmMain.ThisUnitCodes.Add("395212")

        frmMain.ThisUnitCodes.Add("395823")
        frmMain.ThisUnitCodes.Add("395891")
        frmMain.ThisUnitCodes.Add("395886")


        frmMain.ThisUnitCodes.Add("395860")

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
        If ((chkIFBank.Checked = False) And (chkFFBank.Checked = False) And (chkModJCIFilts.Checked = False)) Then
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
        TabControl1.SelectTab("tpgFilters")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs)
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub chkFFMagnehelic_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFMagnehelic.CheckedChanged
        If chkFFMagnehelic.Checked = True Then
            cmbFFMagRange.Enabled = True
            cmbFFMagRange.Text = "0.00-2.00"
            chkFFMinihelic.Enabled = True
        Else
            cmbFFMagRange.Enabled = False
            chkFFMinihelic.Enabled = False
            chkFFMinihelic.Checked = False
        End If
    End Sub

    Private Sub frmFiltration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbIFType.Text = "N/A"
        cmbFFType.Text = "N/A"

        txtAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow

    End Sub

    Private Sub chkIFBank_CheckedChanged(sender As Object, e As EventArgs) Handles chkIFBank.CheckedChanged
        If chkIFBank.Checked = True Then
            cmbIFType.Enabled = True
            chkIFPrefilt.Enabled = True
            grpIFFilts.Enabled = True
        Else
            cmbIFType.Enabled = False
            cmbIFType.Text = "N/A"
            chkIFPrefilt.Enabled = False
            chkIFPrefilt.Checked = False
            grpIFFilts.Enabled = False
        End If

    End Sub

    Private Sub chkFFBank_CheckedChanged(sender As Object, e As EventArgs) Handles chkFFBank.CheckedChanged
        If chkFFBank.Checked = True Then
            cmbFFType.Enabled = True
            chkFFPrefilt.Enabled = True
            grpFFFilts.Enabled = True
        Else
            cmbFFType.Enabled = False
            cmbFFType.Text = "N/A"
            chkFFPrefilt.Enabled = False
            chkFFPrefilt.Checked = False
            grpFFFilts.Enabled = False
        End If
    End Sub

    Private Sub cmbFFType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFFType.SelectedIndexChanged
        Select Case cmbFFType.Text
            Case Is = "MERV 14 (12in)"
                cmbActFF.Items.Clear()
                cmbActFF.Items.Add("AAF Varicell 12in M14")
                cmbActFF.Text = "AAF Varicell 12in M14"

        End Select
    End Sub

    Private Sub chkModJCIFilts_CheckedChanged(sender As Object, e As EventArgs) Handles chkModJCIFilts.CheckedChanged
        If chkModJCIFilts.Checked = True Then
            grpJCIFilts.Enabled = True
        Else
            grpJCIFilts.Enabled = True
        End If
    End Sub
    Private Sub cmdAddFF_Click(sender As Object, e As EventArgs) Handles cmdAddFF.Click
        lstFFSelected.Items.Add(lstFFAvail.Text)
    End Sub

    Private Sub cmdSubFF_Click(sender As Object, e As EventArgs) Handles cmdSubFF.Click
        lstFFSelected.Items.Remove(lstFFSelected.SelectedItem)
    End Sub

    Private Sub btnDoneFilters_Click(sender As Object, e As EventArgs) Handles btnDoneFilters.Click
        Call CountFFilters()
        Call CalcFFFaceandVel()
        Call CalcFFAPD()

        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub CalcFFAPD()
        Dim apd As Double
        Dim velocity As Double
        Dim Maxapd As Double
        Dim recDFA As Double
        Dim statbudget As Double

        velocity = Val(lblFaceVelocity.Text)
        Select Case cmbActFF.Text
            Case Is = "AAF Varicell 12in M14"
                apd = 0.000001785714 * velocity ^ 2 + 0.000001428571 * velocity + 0.128
                Maxapd = 1.5
                recDFA = apd
                If apd + recDFA > Maxapd Then recDFA = Maxapd - apd
        End Select

        lblAPD.Text = Format(apd, "0.00")
        lblMaxAPD.Text = Format(Maxapd, "0.00")
        txtDFA.Text = Format(recDFA, "0.00")
        statbudget = recDFA + apd
        lblStaticBudget.Text = Format(statbudget, "0.00")

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
        lblFaceArea.Text = Format(Face, "0.0")
        Vel = Val(txtAirflow.Text) / Face
        lblFaceVelocity.Text = Format(Vel, "0.0")
    End Sub

    Private Sub CountFFilters()
        Dim i, j As Integer
        Dim FiltArray() As String

        ReDim FiltArray(lstFFSelected.Items.Count - 1)

        lblFilterSize1.Text = ""
        lblFilterQ1.Text = ""
        lblFilterSize2.Text = ""
        lblFilterQ2.Text = ""
        lblFilterSize3.Text = ""
        lblFilterQ3.Text = ""

        For i = 0 To lstFFSelected.Items.Count - 1
            FiltArray(i) = lstFFSelected.Items(i)
        Next

        Dim uniqueFilters As String() = FiltArray.Distinct().ToArray()
        If uniqueFilters.Length >= 1 Then
            lblFilterSize1.Text = uniqueFilters(0)
            lblFilterQ1.Text = FiltArray.Count(Function(size) size = lblFilterSize1.Text)
        End If

        If uniqueFilters.Length >= 2 Then
            lblFilterSize2.Text = uniqueFilters(1)
            lblFilterQ2.Text = FiltArray.Count(Function(size) size = lblFilterSize2.Text)
        End If

        If uniqueFilters.Length >= 3 Then
            lblFilterSize3.Text = uniqueFilters(2)
            lblFilterQ3.Text = FiltArray.Count(Function(size) size = lblFilterSize3.Text)
        End If

    End Sub

    Private Sub PopulateFFilterOptsM14x12()
        lstFFAvail.Items.Clear()
        lstFFAvail.Items.Add("24x24x12")
        lstFFAvail.Items.Add("20x25x12")
        lstFFAvail.Items.Add("20x24x12")
        lstFFAvail.Items.Add("20x20x12")
        lstFFAvail.Items.Add("18x24x12")
        lstFFAvail.Items.Add("16x25x12")
        lstFFAvail.Items.Add("16x20x12")
        lstFFAvail.Items.Add("12x24x12")
    End Sub

    Private Sub cmbActFF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActFF.SelectedIndexChanged
        Select Case cmbActFF.Text
            Case Is = "AAF Varicell 12in M14"
                Call PopulateFFilterOptsM14x12()
        End Select

    End Sub

    Private Sub txtDFA_Leave(sender As Object, e As EventArgs) Handles txtDFA.Leave
        Dim apd As Double
        Dim dfa As Double
        Dim budget As Double

        apd = Val(lblAPD.Text)
        dfa = Val(txtDFA.Text)
        budget = apd + dfa
        lblStaticBudget.Text = Format(budget, "0.00")
    End Sub

    Private Sub btnDonePerformance_Click_1(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
    End Sub
End Class