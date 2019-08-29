Imports System.ComponentModel
Public Class frmDigScroll
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
        Dim i As Integer
        Dim loadname As String
        Dim ElecChar As String
        Dim NewRow As String()

        Call UpdatePerformance()
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("DigScroll") 'Mod Code goes here!
        Call UpdateCodeList()
        frmMain.UseCustomMCA = True
        Call frmMain.PreLoadElec()

        i = 0
        If frmMain.dgvElecLoads.RowCount > 0 Then
            Do
                loadname = frmMain.dgvElecLoads.Rows(i).Cells.Item(4).Value
                If ((loadname = "COMPRESSOR") And (frmMain.dgvElecLoads.Rows(i).Cells.Item(7).Value = Trim(txtExistingCompRLA.Text))) Then
                    ElecChar = frmMain.dgvElecLoads.Rows(i).Cells.Item(5).Value
                    frmMain.dgvElecLoads.Rows.RemoveAt(i)
                    NewRow = {True, False, "Cool", True, "COMP-DIGITAL", ElecChar, "-", txtNewCompRLA.Text, False}
                    frmMain.dgvElecLoads.Rows.Add(NewRow)
                    Exit Do
                End If
                i = i + 1
            Loop Until (i = frmMain.dgvElecLoads.RowCount)
        End If





        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("790000")
        If ((optLargeSplit.Checked) Or (optUPGSplit.Checked)) Then
            If chk1stCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790010")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790001")
            End If
            If chk2ndCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790011")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790002")
            End If
            If chk3rdCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790012")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790003")
            End If
            If chk4thCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790013")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790004")
            End If
        Else
            If chk1stCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790020")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790001")
            End If
            If chk2ndCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790021")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790002")
            End If
            If chk3rdCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790022")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790003")
            End If
            If chk4thCircuit.Checked Then
                frmMain.ThisUnitCodes.Add("790023")
                If chkTandem.Checked Then frmMain.ThisUnitCodes.Add("790004")
            End If
        End If

        'Power
        frmMain.ThisUnitCodes.Add("790090")
        frmMain.ThisUnitCodes.Add("790110")
        If chkOverloadRelays.Checked Then frmMain.ThisUnitCodes.Add("790030")

        'Specialties/Power
        frmMain.ThisUnitCodes.Add("790100")
        frmMain.ThisUnitCodes.Add("790105")


        'Controls
        frmMain.ThisUnitCodes.Add("790200")
        If chkFieldSelectable.Checked Then
            frmMain.ThisUnitCodes.Add("790210")
            frmMain.ThisUnitCodes.Add("790215")
            frmMain.ThisUnitCodes.Add("790225")
            If ((optLargeSplit.Checked) Or (optUPGSplit.Checked)) Then
                frmMain.ThisUnitCodes.Add("790221")
            Else
                frmMain.ThisUnitCodes.Add("790220")
            End If
        End If

        If chkIncludeEquipmentTouch.Checked = True Then
            If chkMountEquipmentTouch.Checked = True Then
                frmMain.ThisUnitGenCodes.Add("960002")
            Else
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If
        If chkModbusPoints.Checked = True Then
            frmMain.ThisUnitGenCodes.Add("960004")
        End If

        frmMain.ThisUnit.CommNodes = "2"

        'use logic to step through the controls to determine the codes and use the above format...

    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True

        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("DigScroll")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Digital Scroll Compressor(s) (Net)")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = 20
            Case Is = "Series10"
                tempWeight = 25
            Case Is = "Series20"
                tempWeight = 25
            Case Is = "Series40"
                tempWeight = 30
            Case Is = "YPAL"
                tempWeight = 35
            Case Is = "Series20ODSplit"
                tempWeight = 25
            Case Else
                tempWeight = "9999"
        End Select
        If chkTandem.Checked Then tempWeight = tempWeight + 206
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text

        frmMain.ThisUnitCoolPerf.TotalCapacity = txtTCap.Text
        frmMain.ThisUnitCoolPerf.SensibleCapacity = txtSCap.Text
        frmMain.ThisUnitCoolPerf.Power = txtPower.Text

    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If frmMain.ThisUnit.Kingdom = "RTU" Then
            If frmMain.ThisUnit.Family = "Series100" Then
                optYPALRTU.Checked = True
            Else
                optUPGRTU.Checked = True
            End If
            txtAmbientTemp.Text = frmMain.ThisUnitCoolPerf.AmbientDB
        Else
            If frmMain.ThisUnit.Family = "Series20ODSplit" Then
                optUPGSplit.Checked = True
            Else
                optLargeSplit.Checked = True
            End If
        End If

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
    End Sub

    Private Sub optUPGSplit_CheckedChanged(sender As Object, e As EventArgs) Handles optUPGSplit.CheckedChanged
        If optUPGSplit.Checked Then
            chkTandem.Enabled = True
        Else
            chkTandem.Enabled = False
        End If
    End Sub

    Private Sub optLargeSplit_CheckedChanged(sender As Object, e As EventArgs) Handles optLargeSplit.CheckedChanged
        If optLargeSplit.Checked Then
            chkTandem.Enabled = True
        Else
            chkTandem.Enabled = False
        End If
    End Sub

    Private Sub optYPALRTU_CheckedChanged(sender As Object, e As EventArgs) Handles optYPALRTU.CheckedChanged
        If optYPALRTU.Checked Then
            chkTandem.Enabled = True
        Else
            chkTandem.Enabled = False
        End If
    End Sub

    Private Sub optUPGRTU_CheckedChanged(sender As Object, e As EventArgs) Handles optUPGRTU.CheckedChanged
        If optUPGRTU.Checked Then
            chkTandem.Enabled = False
            chkTandem.Checked = False
        Else
            chkTandem.Enabled = True
        End If
    End Sub

    Private Sub chk2ndCircuit_CheckedChanged(sender As Object, e As EventArgs) Handles chk2ndCircuit.CheckedChanged
        If chk2ndCircuit.Checked Then
            chk3rdCircuit.Enabled = True
        Else
            chk3rdCircuit.Enabled = False
            chk4thCircuit.Enabled = False
            chk3rdCircuit.Checked = False
            chk4thCircuit.Checked = False

        End If
    End Sub

    Private Sub chk3rdCircuit_CheckedChanged(sender As Object, e As EventArgs) Handles chk3rdCircuit.CheckedChanged
        If chk3rdCircuit.Checked Then
            chk4thCircuit.Enabled = True
        Else
            chk3rdCircuit.Checked = False
            chk4thCircuit.Checked = False

        End If
    End Sub

    Private Sub chkFieldSelectable_CheckedChanged(sender As Object, e As EventArgs) Handles chkFieldSelectable.CheckedChanged
        If Not (chkFieldSelectable.Checked) Then
            chkGBASControls.Enabled = True
            chkSuctionPressureCtrls.Enabled = True
            chkEvaporatorControls.Enabled = True
        Else
            chkGBASControls.Enabled = False
            chkSuctionPressureCtrls.Enabled = False
            chkEvaporatorControls.Enabled = False
            chkGBASControls.Checked = False
            chkSuctionPressureCtrls.Checked = False
            chkEvaporatorControls.Checked = False
        End If
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

End Class