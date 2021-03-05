Public Class frmBlankWarranty
    Private Sub frmBlankWarranty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clbTestList.SetItemChecked(0, frmMain.ThisUnitWarrTest.QA)
        clbTestList.SetItemChecked(1, frmMain.ThisUnitWarrTest.AirflowTest)
        clbTestList.SetItemChecked(2, frmMain.ThisUnitWarrTest.CoilTest)
        clbTestList.SetItemChecked(3, frmMain.ThisUnitWarrTest.CtrlTest)
        clbTestList.SetItemChecked(4, frmMain.ThisUnitWarrTest.MotorTest)
        clbTestList.SetItemChecked(5, frmMain.ThisUnitWarrTest.EHeatTest)
        clbTestList.SetItemChecked(6, frmMain.ThisUnitWarrTest.GHeatTest)
        clbTestList.SetItemChecked(7, frmMain.ThisUnitWarrTest.GasTrainTest)
        clbTestList.SetItemChecked(8, frmMain.ThisUnitWarrTest.HydroPress)
        clbTestList.SetItemChecked(9, frmMain.ThisUnitWarrTest.RefTest)
        clbTestList.SetItemChecked(10, frmMain.ThisUnitWarrTest.RefInsp)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmMain.ThisUnitWarrTest.QA = clbTestList.GetItemChecked(0)
        frmMain.ThisUnitWarrTest.AirflowTest = clbTestList.GetItemChecked(1)
        frmMain.ThisUnitWarrTest.CoilTest = clbTestList.GetItemChecked(2)
        frmMain.ThisUnitWarrTest.CtrlTest = clbTestList.GetItemChecked(3)
        frmMain.ThisUnitWarrTest.MotorTest = clbTestList.GetItemChecked(4)
        frmMain.ThisUnitWarrTest.EHeatTest = clbTestList.GetItemChecked(5)
        frmMain.ThisUnitWarrTest.GHeatTest = clbTestList.GetItemChecked(6)
        frmMain.ThisUnitWarrTest.GasTrainTest = clbTestList.GetItemChecked(7)
        frmMain.ThisUnitWarrTest.HydroPress = clbTestList.GetItemChecked(8)
        frmMain.ThisUnitWarrTest.RefTest = clbTestList.GetItemChecked(9)
        frmMain.ThisUnitWarrTest.RefInsp = clbTestList.GetItemChecked(10)
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
    End Sub
End Class