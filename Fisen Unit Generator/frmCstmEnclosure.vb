Public Class frmCstmEnclosure
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
        frmMain.ThisUnitMods.Add("CstmEncl") 'Mod Code goes here!
        Call UpdateCodeList()

        frmMain.UseCustomMCA = True
        Call frmMain.PreLoadElec()

        'Example code for the updating of the custom electrical tables if needed
        'i = 0
        'Do
        '    loadname = frmMain.dgvElecLoads.Rows(i).Cells.Item(4).Value
        '    If ((loadname = "COMPRESSOR") And (frmMain.dgvElecLoads.Rows(i).Cells.Item(7).Value = Trim(txtExistingCompRLA.Text))) Then
        '        ElecChar = frmMain.dgvElecLoads.Rows(i).Cells.Item(5).Value
        '        frmMain.dgvElecLoads.Rows.RemoveAt(i)
        '        NewRow = {True, False, "Cool", True, "COMP-DIGITAL", ElecChar, "-", txtNewCompRLA.Text, False}
        '        frmMain.dgvElecLoads.Rows.Add(NewRow)
        '        Exit Do
        '    End If
        '    i = i + 1
        'Loop Until (i = frmMain.dgvElecLoads.RowCount)






        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()

    End Sub
    Private Sub UpdateWeightTable()

    End Sub
    Private Sub UpdateWarrantyItems()

    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("101000")
        If optAHUEnc.Checked Then
            frmMain.ThisUnitCodes.Add("101100")
            If chkOutdoorConst.Checked Then
                frmMain.ThisUnitCodes.Add("101101")
            End If
        End If
        If optRTUEnc.Checked Then
            If optRTUEnc.Checked Then
                frmMain.ThisUnitCodes.Add("101200")
                If chkOutdoorConst.Checked Then
                    frmMain.ThisUnitCodes.Add("101201")
                End If
            End If
        End If
        If optPumpPkgEnc.Checked Then
            If optAHUEnc.Checked Then
                frmMain.ThisUnitCodes.Add("101300")
                If chkOutdoorConst.Checked Then
                    frmMain.ThisUnitCodes.Add("101301")
                End If
            End If
        End If
        frmMain.ThisUnitCodes.Add("101500")

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
End Class