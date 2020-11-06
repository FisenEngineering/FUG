Public Class frmMZ
    Private pMZStyle As String
    Private pMZCurbPresent As Boolean
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList

    Public ReadOnly Property Cancelled As Boolean
        Get
            Cancelled = pCancelled
        End Get
    End Property
    Public Property MZStyle As String
        Get
            MZStyle = pMZStyle
        End Get
        Set(value As String)
            pMZStyle = value
        End Set
    End Property
    Public Property MZCurbPresent As Boolean
        Get
            MZCurbPresent = pMZCurbPresent
        End Get
        Set(value As Boolean)
            pMZCurbPresent = value
        End Set
    End Property
    Private Sub frmMZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        cmbMZBaseType.Text = pMZStyle
        chkMZBaseRequired.Checked = pMZCurbPresent

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("LCVAV") 'Mod Code goes here!
        If frmMain.ThisUnit.GenCodesPresent = False Then
            frmMain.ThisUnit.GenCodesPresent = True
            'frmMain.ThisUnitMods.Add("Common")
        End If
        Call UpdateCodeList(False)

        'Call UpdateBaseUnitRequiredItems()
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
        Me.Hide()

    End Sub

    Private Sub UpdatePerformance()

    End Sub
    Private Sub UpdateWeightTable()

    End Sub
    Private Sub UpdateWarrantyItems()

    End Sub
    Private Sub UpdateCodeList(Preview As Boolean)

    End Sub
    Private Sub PerformDesignCautionScan(Prelim As Boolean)

    End Sub
    Private Sub WriteHistory()

    End Sub
End Class