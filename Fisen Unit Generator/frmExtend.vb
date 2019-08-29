Imports System.ComponentModel

Public Class frmExtend
    Private pCancelled As Boolean
    Private pCustom As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub UpdatePerformance()

    End Sub

    Private Sub UpdateWeightTable()

    End Sub

    Private Sub UpdateWarrantyItems()

    End Sub

    Private Sub UpdateCodeList()
        Dim dummy As MsgBoxResult
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("610000")

        'indoor or outdoor construction
        If optECIndoor.Checked Then
            frmMain.ThisUnitCodes.Add("610005")
        Else
            frmMain.ThisUnitCodes.Add("610006")
        End If

        'Handle the profile
        Select Case cmbProfileText.Text
            Case Is = "Series 100 A-Cabinet Standard Profile"
                frmMain.ThisUnitCodes.Add("610010")
            Case Is = "Series 100 B-Cabinet Standard Profile"
                frmMain.ThisUnitCodes.Add("610011")
            Case Is = "Series 100 C-Cabinet Standard Profile"
                frmMain.ThisUnitCodes.Add("610012")
            Case Is = "Series 40 Cabinet Standard Profile"
                frmMain.ThisUnitCodes.Add("610013")
            Case Else
                dummy = MsgBox("Unhandled Cabinet Profile in 'UpdateCodeList'.  Please Correct.", vbOKOnly)
                Stop

        End Select

        'handle the length
        If cmbExtensionType.Text = "Intake End" Then
            Select Case cmbExtensionLength.Text
                Case Is = "48"
                    frmMain.ThisUnitCodes.Add("6100020") '48" extension
                Case Is = "60"
                    frmMain.ThisUnitCodes.Add("6100021") '60" extension
                Case Is = "72"
                    frmMain.ThisUnitCodes.Add("6100022") '72" extension
                Case Is = "84"
                    frmMain.ThisUnitCodes.Add("6100023") '84" extension
                Case Else
                    dummy = MsgBox("Unhandled Extension Length in 'UpdateCodeList'.  Please Correct.", vbOKOnly)
                    Stop
            End Select
        End If

        'handle the Exterior Surface Finish
        If optFinishGalvanized.Checked = True Then
            frmMain.ThisUnitCodes.Add("610030")
        End If
        If optFinishChampagne.Checked = True Then
            frmMain.ThisUnitCodes.Add("610031")
        End If
        If optFinishYPAL.Checked = True Then
            frmMain.ThisUnitCodes.Add("610032")
        End If
        If optFinishXTO.Checked = True Then
            frmMain.ThisUnitCodes.Add("610033")
        End If
        If optFinish409SS.Checked = True Then
            frmMain.ThisUnitCodes.Add("610034")
        End If

        'Set the standard design code if appropriate
        If pCustom = False Then
            Select Case lstStandardDesigns.Text
                Case Is = "Series 40 - Supply Plenum Extension - 58.5 inch"
                    frmMain.ThisUnitCodes.Add("610401")
            End Select
        Else
            frmMain.ThisUnitCodes.Add("610999")
        End If





    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'No Performance for this modification
        'Call UpdatePerformance
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("Extend") 'Mod Code goes here!
        'No GenCodes for this unit
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        '     frmMain.ThisUnit.GenCodesPresent = True
        '     frmMain.ThisUnitMods.Add("Common")
        'End If
        Call UpdateCodeList()
        Me.Hide()
    End Sub

    Private Sub frmExtend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstStandardDesigns.Text = "Custom Cabinet Extention"
        cmbExtensionType.Items.Add("Intake End")
        cmbExtensionType.Text = "Intake End"
        Call PopulateProfile()
        Call PopulateLength()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                optFinishChampagne.Checked = True
            Case Is = "Series10"
                optFinishChampagne.Checked = True
            Case Is = "Series12"
                optFinishChampagne.Checked = True
            Case Is = "Series20"
                optFinishChampagne.Checked = True
            Case Is = "Series40"
                optFinishChampagne.Checked = True
            Case Is = "Series100"
                optFinishYPAL.Checked = True
            Case Is = "XTO"
                optFinishXTO.Checked = True
            Case Is = "XTI"
                optFinishGalvanized.Checked = True
            Case Else

        End Select

    End Sub

    Private Sub PopulateLength()
        cmbExtensionLength.Items.Add("48")
        cmbExtensionLength.Items.Add("60")
        cmbExtensionLength.Items.Add("72")
        cmbExtensionLength.Items.Add("84")
    End Sub
    Private Sub PopulateProfile()
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                'Nothing Yet
            Case Is = "Series10"
                'Nothing Yet
            Case Is = "Series12"
                'Nothing Yet
            Case Is = "Series20"
                'Nothing Yet
            Case Is = "Series40"
                cmbProfileText.Items.Add("Series 40 Cabinet Standard Profile")
            Case Is = "Series100"
                If frmMain.ThisUnit.Cabinet = "S100A" Then
                    cmbProfileText.Items.Add("Series 100 A-Cabinet Standard Profile")
                End If
                If frmMain.ThisUnit.Cabinet = "S100B" Then
                    cmbProfileText.Items.Add("Series 100 B-Cabinet Standard Profile")
                End If
                If frmMain.ThisUnit.Cabinet = "S100C" Then
                    cmbProfileText.Items.Add("Series 100 C-Cabinet Standard Profile")
                End If
                cmbExtensionLength.Items.Add("48")
                cmbExtensionLength.Items.Add("60")
                cmbExtensionLength.Items.Add("72")
                cmbExtensionLength.Items.Add("84")
            Case Else

        End Select
    End Sub

    Private Sub cmdLoadStandard_Click(sender As Object, e As EventArgs) Handles cmdLoadStandard.Click
        Select Case lstStandardDesigns.Text
            Case Is = "Series 40 - Supply Plenum Extension - 58.5 inch"
                Call LoadS40SupplyExtension
        End Select
        cmdDoneStandard.Enabled = True
        cmdLoadStandard.Enabled = False
        lstStandardDesigns.Enabled = False
    End Sub

    Private Sub cmdDoneStandard_Click(sender As Object, e As EventArgs) Handles cmdDoneStandard.Click


        If lstStandardDesigns.Text <> "Custom Cabinet Extension" Then
            pCustom = False
        Else
            pCustom = True
        End If

        TabControl1.SelectTab("tpgConditions")
    End Sub

    Private Sub optECOutdoor_CheckedChanged(sender As Object, e As EventArgs) Handles optECOutdoor.CheckedChanged
        pCustom = True

    End Sub

    Private Sub optECIndoor_CheckedChanged(sender As Object, e As EventArgs) Handles optECIndoor.CheckedChanged
        pCustom = True

    End Sub
    Private Sub LoadS40SupplyExtension()
        optECOutdoor.Checked = True

    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgWalls")
    End Sub
End Class