Public Class frmAFlowMod
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub btnDoneSelection_Click(sender As Object, e As EventArgs) Handles btnDoneSelection.Click
        TabControl1.SelectTab("tpgConditions")
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
        Dim ThisAFMod As String
        Dim NetMass As Double

        Call UpdatePerformance()
        Call UpdateWarrantyItems()

        frmMain.ThisUnitMods.Add("AFlowMod") 'Mod Code goes here!
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        'frmMain.ThisUnit.GenCodesPresent = True
        'frmMain.ThisUnitMods.Add("Common")
        'End If

        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("340100")
        Call UpdateWeightTable()
        NetMass = 0
        For i = 0 To lstItemsInDB.Items.Count - 1
            ThisAFMod = lstItemsInDB.Items(i).ToString()
            If lstItemsInDB.SelectedItems.Contains(ThisAFMod) Then
                Call UpdateCodeList(ThisAFMod)
                NetMass = NetMass + UpdateWeightTableMass(ThisAFMod)
                Call UpdateBaseUnitREquiredItems()
            End If
        Next i
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(NetMass)
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList(locCode As String)
        Dim dummy As MsgBoxResult

        Select Case locCode
            Case Is = "Return Air Blockoff"
                Select Case frmMain.ThisUnit.Family
                    Case Is = "Series5"
                        frmMain.ThisUnitCodes.Add("340110")
                    Case Is = "Series10"
                        frmMain.ThisUnitCodes.Add("340111")
                    Case Is = "Series20"
                        frmMain.ThisUnitCodes.Add("340112")
                    Case Is = "Series40"
                        frmMain.ThisUnitCodes.Add("340113")
                    Case Is = "Series100"
                        frmMain.ThisUnitCodes.Add("340114")
                End Select
            Case Is = "S40 Bottom Return to Rear Return (No Exhaust Fan)"
                If frmMain.ThisUnit.Family <> "Series40" Then
                    dummy = MsgBox("Series 40 option selected on non-series 40 base unit.  Aborting.")
                    Stop
                End If
                frmMain.ThisUnitCodes.Add("340150")

            Case Is = "S40 Bottom Return to Rear Return (Factory Exhaust Fans)"
                If frmMain.ThisUnit.Family <> "Series40" Then
                    dummy = MsgBox("Series 40 option selected on non-series 40 base unit.  Aborting.")
                    Stop
                End If
                frmMain.ThisUnitCodes.Add("340151")

            Case Is = "S40 Bottom Supply to Rear Supply (Factory Electric Heat)"
                If frmMain.ThisUnit.Family <> "Series40" Then
                    dummy = MsgBox("Series 40 option selected on non-series 40 base unit.  Aborting.")
                    Stop
                End If
                frmMain.ThisUnitCodes.Add("340210")

        End Select

    End Sub
    Private Sub UpdateBaseUnitREquiredItems()
        'None
    End Sub
    Private Sub UpdateWarrantyItems()
        'None
    End Sub
    Private Sub UpdateWeightTable()

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("AFlowMod")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Airflow Path Reconfiguration (Net)")

    End Sub
    Private Function UpdateWeightTableMass(locMod As String)
        Dim mass As Double

        mass = 0
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 16
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series10"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 18
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series20"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 31
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series40"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 56
                    Case Is = "S40 Bottom Return to Rear Return (No Exhaust Fan)"
                        mass = 48
                    Case Is = "S40 Bottom Return to Rear Return (Factory Exhaust Fans)"
                        mass = 52
                    Case Is = "S40 Bottom Supply to Rear Supply (Factory Electric Heat)"
                        mass = 68
                    Case Else
                        mass = -9999
                End Select
            Case Is = "Series 100"
                Select Case locMod
                    Case Is = "Return Air Blockoff"
                        mass = 74
                    Case Else
                        mass = -9999
                End Select
            Case Else
                mass = "9999"
        End Select
        Return mass
    End Function
    Private Sub UpdatePerformance()
        'Nothing here
    End Sub

    Private Sub frmAFlowMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class