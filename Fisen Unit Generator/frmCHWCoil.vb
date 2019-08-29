Public Class frmCHWCoil
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
        'Call UpdatePerformance
        'none presently for this modification - MCA/MOP in the future.

        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("CHWCoil") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList()
        Me.Hide()

    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("490000")

        frmMain.ThisUnitCodes.Add("490006")
        frmMain.ThisUnitCodes.Add("490020")
        frmMain.ThisUnitCodes.Add("490021")
        frmMain.ThisUnitCodes.Add("490022")
        frmMain.ThisUnitCodes.Add("490023")
        frmMain.ThisUnitCodes.Add("490031")
        frmMain.ThisUnitCodes.Add("490040")
        frmMain.ThisUnitCodes.Add("490800")
        frmMain.ThisUnitCodes.Add("490810")
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CoilTest = True
        frmMain.ThisUnitWarrTest.HydroPress = True
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String


        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("CHWCoil")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Chilled Water Coil")
        tempWeight = "9999"

        tempWeight = "395"
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
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
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub
End Class