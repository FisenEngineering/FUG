Public Class frmCoatings
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList

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
        Call UpdateWarrantyItems
        frmMain.ThisUnitMods.Add("Coatings")
        Call UpdateCodeList()
        'If chkWriteHistory.Checked = True Then Call WriteHWCoilHistory()
        'Call WriteModuleData()
        Me.Hide()
    End Sub

    Private Sub UpdateCodeList()
        Dim HMIAlreadyThere As Boolean
        Dim i As Integer

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("440000")

        'Handle the 1st level coatings
        If chkMicroGuardExt.Checked Or chkMicroGuardInt.Checked Then
            ModuleCodeList.Add("440100")
        End If

        Select Case nudMicroGuardIntCoats.Value
            Case Is = 1
                ModuleCodeList.Add("440101")
            Case Is = 2
                ModuleCodeList.Add("440102")
            Case Is = 3
                ModuleCodeList.Add("440103")
            Case Is = 4
                ModuleCodeList.Add("440104")
            Case Else
                'Do Nothing
        End Select
        Select Case nudMicroGuardExtCoats.Value
            Case Is = 1
                ModuleCodeList.Add("440105")
            Case Is = 2
                ModuleCodeList.Add("440106")
            Case Is = 3
                ModuleCodeList.Add("440107")
            Case Is = 4
                ModuleCodeList.Add("440108")
            Case Else
                'Do Nothing
        End Select

        If chkRustGripExt.Checked Or chkRustGripExt.Checked Then
            ModuleCodeList.Add("440200")
        End If

        Select Case nudRustGripIntCoats.Value
            Case Is = 1
                ModuleCodeList.Add("440201")
            Case Is = 2
                ModuleCodeList.Add("440202")
            Case Is = 3
                ModuleCodeList.Add("440203")
            Case Is = 4
                ModuleCodeList.Add("440204")
            Case Else
                'Do Nothing
        End Select
        Select Case nudRustGripExtCoats.Value
            Case Is = 1
                ModuleCodeList.Add("440205")
            Case Is = 2
                ModuleCodeList.Add("440206")
            Case Is = 3
                ModuleCodeList.Add("440207")
            Case Is = 4
                ModuleCodeList.Add("440208")
            Case Else
                'Do Nothing
        End Select

        'Handle the hmi
        If chkIncludeEquipmentTouch.Checked = True Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
            HMIAlreadyThere = False
            For iHMI = 0 To frmMain.ThisUnitGenCodes.Count - 1
                If ((frmMain.ThisUnitGenCodes.Item(iHMI) = "960002") Or (frmMain.ThisUnitGenCodes.Item(iHMI) = "960001")) Then HMIAlreadyThere = True
            Next
            If ((chkMountEquipmentTouch.Checked = True) And (HMIAlreadyThere = False)) Then
                frmMain.ThisUnitGenCodes.Add("960002")
            End If
            If ((chkMountEquipmentTouch.Checked = False) And (HMIAlreadyThere = False)) Then
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If

        'handle the commnodes
        'There is no need to add an additional commnode for this modification at this time.
        'frmMain.ThisUnit.CommNodes = "2"

        'Add Auxillary Panel if selected
        If ((optUseAux.Checked = True) And (frmMain.HasAuxillaryPanel = False)) Then
            If frmMain.ThisUnitGenCodes.Count = 0 Then frmMain.ThisUnitGenCodes.Add("960000")
            frmMain.HasAuxillaryPanel = True
            Select Case cmbAuxPanelOpts.Text
                Case Is = "Series 5 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960008")
                Case Is = "Series 5 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960013")
                Case Is = "Series 5 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960014")
                Case Is = "Series 5 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960015")
                Case Is = "Series 5 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960017")
                Case Is = "Series 10 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960005")
                Case Is = "Series 10 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960006")
                Case Is = "Series 10 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960007")
                Case Is = "Series 10 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960010")
                Case Is = "Series 10 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960016")
                Case Is = "Series 20 Downflow"
                    frmMain.ThisUnitGenCodes.Add("960018")
                Case Is = "Series 20 Horizontal"
                    frmMain.ThisUnitGenCodes.Add("960019")
                Case Is = "Series 20 Horizontal No Return"
                    frmMain.ThisUnitGenCodes.Add("960020")
                Case Is = "Series 20 Convertible"
                    frmMain.ThisUnitGenCodes.Add("960021")
                Case Is = "Series 20 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960012")
                Case Is = "Series 40 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960022")
                Case Is = "Series 100 Custom Application"
                    frmMain.ThisUnitGenCodes.Add("960023")
            End Select
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("440F6A")
        End If

        'Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i



    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        'none needed at this time.
    End Sub
    Private Sub UpdateWarrantyItems()
        'none needed at this time.
    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim WeightPerCoat As Integer
        Dim Dummy As MsgBoxResult

        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HWCoil")
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Water Coil")
        tempWeight = "0"

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                WeightPerCoat = 5
            Case Is = "Series10"
                WeightPerCoat = 5
            Case Is = "Series20"
                WeightPerCoat = 8
            Case Is = "Premier"
                WeightPerCoat = 10
            Case Is = "Choice"
                WeightPerCoat = 8
            Case Is = "Select"
                WeightPerCoat = 9
            Case Is = "Series100"
                Select Case frmMain.ThisUnit.Cabinet
                    Case Is = "A"
                        WeightPerCoat = 9
                    Case Is = "B"
                        WeightPerCoat = 10
                    Case Is = "C"
                        WeightPerCoat = 12
                End Select

            Case Is = "Series20ODSplit"
                WeightPerCoat = 4

            Case Is = "Series20IDSplit"
                WeightPerCoat = 4
            Case Is = "Series40ODSplit"
                WeightPerCoat = 6
            Case Is = "XTO"
                WeightPerCoat = 10
            Case Is = "XTI"
                WeightPerCoat = 10
            Case Is = "YorkCustom"
                WeightPerCoat = 10
            Case Is = "YCAL"
                WeightPerCoat = 4
            Case Is = "YLAA"
                WeightPerCoat = 4
            Case Is = "YVAA"
                WeightPerCoat = 6
            Case Is = "YCIV"
                WeightPerCoat = 6
            Case Is = "YCAV"
                WeightPerCoat = 7
            Case Is = "YCUL"
                WeightPerCoat = 3
            Case Is = "RJ"
                WeightPerCoat = 2
            Case Is = "RL"
                WeightPerCoat = 2
            Case Is = "RS"
                WeightPerCoat = 2
            Case Is = "DS"
                WeightPerCoat = 2
            Case Is = "CS"
                WeightPerCoat = 2
            Case Is = "DOAS"
                WeightPerCoat = 6
            Case Is = "SeriesLX"
                WeightPerCoat = 6
            Case Is = "Blank"
                WeightPerCoat = 5
            Case Else
                WeightPerCoat = -1
                Dummy = MsgBox("Error in Weight Selection for HWCoil Module.", vbOKOnly)
        End Select

        tempWeight = tempWeight + WeightPerCoat * CoatingCoatCount


        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Function CoatingCoatCount() As Integer
        Dim TempCount As Integer

        TempCount = nudMicroGuardExtCoats.Value + nudMicroGuardIntCoats.Value + nudRustGripExtCoats.Value + nudRustGripIntCoats.Value

        Return TempCount
    End Function

    Private Sub chkRustGripExt_CheckedChanged(sender As Object, e As EventArgs) Handles chkRustGripExt.CheckedChanged
        If chkRustGripExt.Checked Then
            nudRustGripExtCoats.Enabled = True
            nudRustGripExtCoats.Value = 1
        Else
            nudRustGripExtCoats.Enabled = False
            nudRustGripExtCoats.Value = 0
        End If
    End Sub

    Private Sub chkRustGripInt_CheckedChanged(sender As Object, e As EventArgs) Handles chkRustGripInt.CheckedChanged
        If chkRustGripInt.Checked Then
            nudRustGripIntCoats.Enabled = True
            nudRustGripIntCoats.Value = 1
        Else
            nudRustGripIntCoats.Enabled = False
            nudRustGripIntCoats.Value = 0
        End If
    End Sub

    Private Sub chkMicroGuardExt_CheckedChanged(sender As Object, e As EventArgs) Handles chkMicroGuardExt.CheckedChanged
        If chkMicroGuardExt.Checked Then
            nudMicroGuardExtCoats.Enabled = True
            nudMicroGuardExtCoats.Value = 1
        Else
            nudMicroGuardExtCoats.Enabled = False
            nudMicroGuardExtCoats.Value = 0
        End If
    End Sub

    Private Sub chkMicroGuardInt_CheckedChanged(sender As Object, e As EventArgs) Handles chkMicroGuardInt.CheckedChanged
        If chkMicroGuardInt.Checked Then
            nudMicroGuardIntCoats.Enabled = True
            nudMicroGuardIntCoats.Value = 1
        Else
            nudMicroGuardIntCoats.Enabled = False
            nudMicroGuardIntCoats.Value = 0
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
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
        btnOK.Enabled = True
    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked Then
            chkMountEquipmentTouch.Enabled = True
        Else
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        End If
    End Sub

    Private Sub frmCoatings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        Call GlbPopulateAuxPanelList(optNoAux, optUseAux, cmbAuxPanelOpts)

        'If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        ModuleCodeList.Add("440000")

    End Sub
End Class