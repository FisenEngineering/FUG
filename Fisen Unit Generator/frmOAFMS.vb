Public Class frmOAFMS
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
        frmMain.ThisUnitMods.Add("OAFMS")
        Call UpdatePerformance()
        Call UpdateWeightTable()
        Call UpdateWarrantyItems()
        Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        'None at this time
    End Sub
    Private Sub UpdateCodeList()
        Dim dummy As MsgBoxResult
        frmMain.ThisUnitCodes.Add("381000")
        frmMain.ThisUnitCodes.Add("381200")

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If optDownflow.Checked = True Then
                    frmMain.ThisUnitCodes.Add("381020")
                Else
                    frmMain.ThisUnitCodes.Add("381021")
                End If
                frmMain.ThisUnitCodes.Add("381010")
            Case Is = "Series10"
                If optDownflow.Checked = True Then
                    frmMain.ThisUnitCodes.Add("381005")
                Else
                    frmMain.ThisUnitCodes.Add("381006")
                End If
                frmMain.ThisUnitCodes.Add("381010")
            Case Is = "Series20"
                If optDownflow.Checked = True Then
                    frmMain.ThisUnitCodes.Add("381007")
                Else
                    frmMain.ThisUnitCodes.Add("381008")
                End If

                frmMain.ThisUnitCodes.Add("381015")
            Case Is = "Series40"
                If Val(txtAirflow.Text) >= 12500 Then
                    frmMain.ThisUnitCodes.Add("381004") 'High Flow Design
                Else
                    frmMain.ThisUnitCodes.Add("381003") 'Low Flow Design
                End If
                frmMain.ThisUnitCodes.Add("381010")
            Case Is = "Select"
                frmMain.ThisUnitCodes.Add("381030")
                frmMain.ThisUnitCodes.Add("381200")
                frmMain.ThisUnitCodes.Add("381010")
            Case Is = "Choice"
                Debug.Print(frmMain.ThisUnit.NominalTons)
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "15.0"
                        frmMain.ThisUnitCodes.Add("381009")
                    Case Is = "17.5"
                        frmMain.ThisUnitCodes.Add("381009")
                    Case Is = "20.0"
                        frmMain.ThisUnitCodes.Add("381009")
                    Case Is = "25.0"
                        frmMain.ThisUnitCodes.Add("38100A")
                    Case Is = "27.5"
                        frmMain.ThisUnitCodes.Add("38100A")
                    Case Else
                        dummy = MsgBox("Error is OAFMS Assign Codes")
                        Stop
                End Select


            Case Else
        End Select

        'now the controls
        frmMain.ThisUnitCodes.Add("381099")
        frmMain.ThisUnitCodes.Add("381100")
        frmMain.ThisUnitCodes.Add("381110")
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("OAFMS")
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Outdoor Airflow Monitoring Station")
        tempWeight = "9999"
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "45"
            Case Is = "Series10"
                tempWeight = "60"
            Case Is = "Series20"
                tempWeight = "80"
            Case Is = "Choice"
                Select Case frmMain.ThisUnit.NominalTons
                    Case Is = "15.0"
                        tempWeight = "87"
                    Case Is = "17.5"
                        tempWeight = "87"
                    Case Is = "20.0"
                        tempWeight = "87"
                    Case Is = "25.0"
                        tempWeight = "93"
                    Case Is = "27.5"
                        tempWeight = "93"
                    Case Else
                        tempWeight = "-9999"
                End Select
            Case Is = "Series40"
                If frmMain.ThisUnit.NominalTons = "25" Then
                    tempWeight = "25"
                Else
                    tempWeight = "115"
                End If
            Case Is = "Select"
                tempWeight = 112
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub

    Private Sub frmOAFMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAirflow.Text = frmMain.ThisUnitSFanPerf.Airflow
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

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub cmdScience_Click(sender As Object, e As EventArgs) Handles cmdScience.Click
        Dim DesignFilePrefix As String
        Dim DesignFilePath As String

        DesignFilePrefix = "OAFMS"
        DesignFilePath = My.Settings.ResourceDir & "Mods\OAFMS\Design\Science\"

        frmScience.CallingMod = DesignFilePrefix
        frmScience.SciPath = DesignFilePath

        frmScience.Show()

    End Sub
End Class