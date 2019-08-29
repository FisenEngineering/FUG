Public Class frmHumid
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub frmHumid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'Call UpdatePerformance
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("Humid") 'Mod Code goes here!
        'No GenCodes for this unit
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        '     frmMain.ThisUnit.GenCodesPresent = True
        '     frmMain.ThisUnitMods.Add("Common")
        'End If
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no items to test for this modification
        'Maybe controls eventually

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String

        Dim TubeWeight As Double
        Dim SpecWeight As Double
        Dim GenWeight As Double

        Dim ModWeight As Double

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("Humid")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Humidification System")
        tempWeight = "9999"

        GenWeight = 0
        SpecWeight = 0

        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                TubeWeight = 46
            Case Is = "Series10"
                TubeWeight = 52
            Case Is = "Series20"
                TubeWeight = 86
            Case Is = "Series40"
                TubeWeight = 114
            Case Is = "Series100"
                TubeWeight = 188
            Case Else
                TubeWeight = 9999
        End Select

        ModWeight = TubeWeight + SpecWeight + GenWeight
        tempWeight = Trim(Str(ModWeight))

        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
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
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("410000")
        'frmMain.ThisUnitCodes.Add("")

        'Handle the tubes
        If chkDispersionTubes.Checked Then
            frmMain.ThisUnitCodes.Add("410500")
            If optTubesFisenProvInst.Checked Then
                frmMain.ThisUnitCodes.Add("410510")
                frmMain.ThisUnitCodes.Add("410511")
            End If
            If optTubesFisenProvFieldInst.Checked Then
                frmMain.ThisUnitCodes.Add("410510")
                frmMain.ThisUnitCodes.Add("410512")
            End If
            If optTubesFieldProvFieldInst.Checked Then
                frmMain.ThisUnitCodes.Add("410515")
            End If

            If optCutsField.Checked Then
                frmMain.ThisUnitCodes.Add("410517")
            End If
            If optCutsFisenSide.Checked Then
                frmMain.ThisUnitCodes.Add("410518")
            End If
            If optCutsFisenBottom.Checked Then
                frmMain.ThisUnitCodes.Add("410519")
            End If

            If optSameSideDrain.Checked Then
                frmMain.ThisUnitCodes.Add("410526")
            End If
            If optOppositeSideDrain.Checked Then
                frmMain.ThisUnitCodes.Add("410525")
            End If

            If optTrapExternal.Checked Then
                frmMain.ThisUnitCodes.Add("410530")
            End If

            If optTrapInteralProvisions.Checked Then
                frmMain.ThisUnitCodes.Add("410531")
            End If
        End If

        'Handle the Drain Pan
        If OptDrainPanNone.Checked Then
            frmMain.ThisUnitCodes.Add("410521")
        End If
        'Handle the Drain Pan
        If OptDrainPanGalv.Checked Then
            frmMain.ThisUnitCodes.Add("410520")
            frmMain.ThisUnitCodes.Add("410522")
        End If
        'Handle the Drain Pan
        If optDrainPanStainless.Checked Then
            frmMain.ThisUnitCodes.Add("410520")
            frmMain.ThisUnitCodes.Add("410522")
        End If
        If OptDrainPanNone.Checked = False Then
            If optCutsField.Checked Then
                frmMain.ThisUnitCodes.Add("410527")
            End If
            If optCutsFisenSide.Checked Then
                frmMain.ThisUnitCodes.Add("410528")
            End If
            If optCutsFisenBottom.Checked Then
                frmMain.ThisUnitCodes.Add("410529")
            End If

        End If

        'handle the controls
        frmMain.ThisUnitCodes.Add("410600")
        If optControlsNone.Checked = False Then
            frmMain.ThisUnitCodes.Add("410605")
        End If

        'no need to add a node for communications for this modification.
        'frmMain.ThisUnit.CommNodes = "2"

        'Now The Safeties
        If chkSafeNone.Checked = False Then
            frmMain.ThisUnitCodes.Add("410650")
        End If

        'no need to add a node for communications for this modification.
        'frmMain.ThisUnit.CommNodes = "2"

    End Sub

    Private Sub chkDispersionTubes_CheckedChanged(sender As Object, e As EventArgs) Handles chkDispersionTubes.CheckedChanged
        If chkDispersionTubes.Checked = True Then
            grpTubes.Enabled = True
            grpSteamConditions.Enabled = True
            txtSteamCap.Text = "0.0"


        Else
            grpTubes.Enabled = False
            grpSteamConditions.Enabled = False
            txtSteamCap.Text = ""
            chkAtmospheric.Checked = False
            txtSteamPressure.Text = ""
        End If
    End Sub

    Private Sub chkAtmospheric_CheckedChanged(sender As Object, e As EventArgs) Handles chkAtmospheric.CheckedChanged
        If chkAtmospheric.Checked = True Then
            txtSteamPressure.Enabled = False
            txtSteamPressure.Text = ""
        Else
            txtSteamPressure.Enabled = True
            txtSteamPressure.Text = 0.0
        End If
    End Sub
End Class