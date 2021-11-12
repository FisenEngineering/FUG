Public Class frmMEHeat_I
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList
    Private pHeatUse As String

    Public Property HeatUse As String
        Get
            Return pHeatUse
        End Get
        Set(value As String)
            pHeatUse = value
        End Set
    End Property
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub frmMEHeat_I_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False

        If frmMain.ThisUnitHeatPerf.Airflow > 0 Then
            txtHeatAF.Text = frmMain.ThisUnitHeatPerf.Airflow
        Else
            txtHeatAF.Text = frmMain.ThisUnitSFanPerf.Airflow
        End If

        cmbHeatUse.Text = pHeatUse
        txtUnitVoltage.Text = frmMain.ThisUnitElecData.CommVolts
        Select Case txtUnitVoltage.Text
            Case Is = "208"
                txtHeaterVoltage.Text = "240"
            Case Is = "230"
                txtHeaterVoltage.Text = "240"
            Case Is = "460"
                txtHeaterVoltage.Text = "480"
            Case Is = "575"
                txtHeaterVoltage.Text = "575"
        End Select


    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call UpdatePerformance()
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("MEHeat_I") 'Mod Code goes here!

        Call UpdateCodeList
        Call UpdateBaseUnitRequiredItems
        Call UpdateWeightTable

        Me.Hide()
    End Sub
    Private Sub UpdatePerformance()
        Dim esp As Double
        Dim i As Integer

        frmMain.ThisUnitHeatPerf.OutputCapacity = txtAppliedCapacitymbh.Text
        frmMain.ThisUnitHeatPerf.LeavingAirTemp = txtLAT.Text
        frmMain.ThisUnitHeatPerf.DeltaT = txtDeltaT.Text
        frmMain.ThisUnitHeatPerf.Airflow = txtHeatAF.Text
        frmMain.ThisUnitHeatPerf.InputCapacity = txtInputCapBTU.Text
        frmMain.ThisUnitHeatPerf.ControlStyle = "Modulating"

        esp = frmMain.ThisUnitSFanPerf.ESP
        esp = esp - Val(txtHeaterSP.Text)
        frmMain.ThisUnitSFanPerf.ESP = Format(esp, "0.00")

        If frmMain.ThisUnit.Family = "Series100" Then
            frmMain.ThisUnitSFanPerf.StaticNameYpal.Add("Electric Heater")
            frmMain.ThisUnitSFanPerf.StaticDataYpal.Add(txtHeaterSP.Text)
            For i = 0 To frmMain.ThisUnitSFanPerf.StaticNameYpal.Count - 1
                If frmMain.ThisUnitSFanPerf.StaticNameYpal.Item(i) = "External Static Pressure" Then
                    frmMain.ThisUnitSFanPerf.StaticDataYpal.Item(i) = Format(esp, "0.00")
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub UpdateWarrantyItems()
        frmMain.ThisUnitWarrTest.EHeatTest = True
        frmMain.ThisUnitWarrTest.CtrlTest = True
    End Sub

    Private Sub UpdateCodeList()
        Dim HMIAlreadyThere As Boolean


        ModuleCodeList.Clear()

        Select Case pHeatUse
            Case Is = "Main Heat"
                ModuleCodeList.Add("505000") 'Modulating Electric Heat *Main*
                If optOpenCoil.Checked Then
                    ModuleCodeList.Add("505010") 'Open Coil
                End If
                If optFinTube.Checked Then
                    ModuleCodeList.Add("505020") 'Finned Tube
                End If

                If chkLocalDisconnect.Checked Then
                    ModuleCodeList.Add("505031") 'Local Disconnect Switch
                End If

                If chk65KIA.Checked Then
                    ModuleCodeList.Add("505032") '65k SCCR
                End If

                If chkPressurePlate.Checked Then
                    ModuleCodeList.Add("505033") 'Pressure Plate 40%
                End If

                If optConvertibleDischarge.Checked Then ModuleCodeList.Add("505034") 'Convertible AF
                If optBottomDischarge.Checked Then ModuleCodeList.Add("505035") 'Bottom AF
                If optRearDischarge.Checked Then ModuleCodeList.Add("505036") 'Rear AF
                If optFrontDischarge.Checked Then ModuleCodeList.Add("505037") 'Front AF

                'Now Handle the controls
                ModuleCodeList.Add("505100") 'Controls General
                If chkModulatingHeat.Checked Then
                    ModuleCodeList.Add("505106") 'Modulating
                Else
                    ModuleCodeList.Add("505105") 'Staged
                End If

                If optSE.Checked Then
                    If optSATCtrl.Checked Then
                        ModuleCodeList.Add("505110") 'SAT Control SE
                        If chkTempering.Checked Then ModuleCodeList.Add("505120") 'SA Tempering SE Controls
                    End If
                    If opt100AOModeCtrl.Checked Then
                        ModuleCodeList.Add("505130") 'Mode control 100OA with SE Controls
                    End If
                    If opt100OACtrls.Checked Then
                        ModuleCodeList.Add("505140") 'DAT Control for SE Controls
                    End If
                    If optGBAS.Checked Then
                        ModuleCodeList.Add("505150") 'GBAS SE
                    End If
                    If optCustomCtrl.Checked Then
                        ModuleCodeList.Add("505160") 'Custom SE
                    End If
                End If

                If optIPU.Checked Then
                    If optSATCtrl.Checked Then
                        ModuleCodeList.Add("505111") 'SAT Control IPU
                        If chkTempering.Checked Then ModuleCodeList.Add("505121") 'SA Tempering IPU Controls
                    End If
                    If opt100AOModeCtrl.Checked Then
                        ModuleCodeList.Add("505131") 'Mode control 100OA with IPU Controls
                    End If
                    If opt100OACtrls.Checked Then
                        ModuleCodeList.Add("505141") 'DAT Control for IPU Controls
                    End If
                    If optGBAS.Checked Then
                        ModuleCodeList.Add("505151") 'GBAS IPU
                    End If
                    If optCustomCtrl.Checked Then
                        ModuleCodeList.Add("505161") 'Custom IPU
                    End If
                End If

                If optPCU.Checked Then
                    If optSATCtrl.Checked Then
                        ModuleCodeList.Add("505112") 'SAT Control PCU
                        If chkTempering.Checked Then ModuleCodeList.Add("505122") 'SA Tempering PCU Controls
                    End If
                    If opt100AOModeCtrl.Checked Then
                        ModuleCodeList.Add("505132") 'Mode control 100OA with PCU Controls
                    End If
                    If opt100OACtrls.Checked Then
                        ModuleCodeList.Add("505142") 'DAT Control for PCU Controls
                    End If
                    If optGBAS.Checked Then
                        ModuleCodeList.Add("505152") 'GBAS PCU
                    End If
                    If optCustomCtrl.Checked Then
                        ModuleCodeList.Add("505162") 'Custom PCU
                    End If
                End If


            Case Is = "Pre-Heat"
            Case Is = "Reactivation Heat"
        End Select


        'use logic to step through the controls to determine the codes and use the above format...

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

        'Handle the HMI
        If chkIncludeEquipmentTouch.Checked = True Then
            HMIAlreadyThere = False
            For iHMI = 0 To frmMain.ThisUnitGenCodes.Count - 1
                If ((frmMain.ThisUnitGenCodes.Item(iHMI) = "960002") Or (frmMain.ThisUnitGenCodes.Item(iHMI) = "960001")) Then HMIAlreadyThere = True
            Next
            If ((chkMountEquipmentTouch.Checked = True) And (HMIAlreadyThere = False)) Then
                If frmMain.ThisUnitGenCodes.Count > 0 Then frmMain.ThisUnitGenCodes.Add("960000")
                frmMain.ThisUnitGenCodes.Add("960002")
            End If
            If ((chkMountEquipmentTouch.Checked = False) And (HMIAlreadyThere = False)) Then
                If frmMain.ThisUnitGenCodes.Count > 0 Then frmMain.ThisUnitGenCodes.Add("960000")
                frmMain.ThisUnitGenCodes.Add("960001")
            End If
        End If


    End Sub

    Private Sub UpdateBaseUnitRequiredItems()
        'Nothing at this time...
    End Sub

    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("MEHeat_I")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Modulating Electric Heater")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "85"
            Case Is = "Series10"
                tempWeight = "85"
            Case Is = "Series20"
                tempWeight = "98"
            Case Is = "Series40"
                tempWeight = "165"
            Case Is = "Series100"
                tempWeight = "260"
            Case Is = "Premier"
                tempWeight = "220"
            Case Is = "Choice"
                tempWeight = "220"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub

    Private Sub txtInputCapkW_Leave(sender As Object, e As EventArgs) Handles txtInputCapkW.Leave
        Dim kW As Double
        Dim btuh As Double

        If IsNumeric(txtInputCapkW.Text) Then
            kW = Val(txtInputCapkW.Text)
            btuh = kW * 3.4121416331
            txtInputCapBTU.Text = Format(btuh, "0.0")
        Else
            txtInputCapBTU.Text = "-"
        End If

    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        Call PerformDesignCautionScan(True)
    End Sub

    Private Sub PerformDesignCautionScan(Prelim As Boolean)
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim RecCount As Integer

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        For i = 0 To ModuleCodeList.Count - 1


            If Prelim Then
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '505%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '210%'"
                Else
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
                End If
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, "Design Caution")
                    If dummy = vbYes Then
                        totalmessage = ""
                        startingcaution = rs.Fields("LongText").Value
                        While Len(startingcaution) > 61
                            spacepos = 61
                            Do While ((Mid(startingcaution, spacepos, 1) <> " ") And (Mid(startingcaution, spacepos, 1) <> ",") And (Mid(startingcaution, spacepos, 1) <> "."))
                                spacepos = spacepos - 1
                            Loop

                            eachline = Mid(startingcaution, 1, spacepos - 1)
                            startingcaution = Mid(startingcaution, spacepos)
                            totalmessage = totalmessage & vbCrLf & eachline
                        End While
                        totalmessage = totalmessage & vbCrLf & startingcaution
                        dummy = MsgBox(totalmessage, vbOKOnly, "Design Caution")
                    End If
                    rs.MoveNext()
                Loop
                rs.Close()
            End If
        Next
        con.Close()

        rs = Nothing
        con = Nothing
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgOptions")

    End Sub

    Private Sub chkIncludeEquipmentTouch_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeEquipmentTouch.CheckedChanged
        If chkIncludeEquipmentTouch.Checked = False Then
            chkMountEquipmentTouch.Checked = False
            chkMountEquipmentTouch.Enabled = False
        Else
            chkMountEquipmentTouch.Enabled = True
        End If
    End Sub

    Private Sub btnDoneOptions_Click(sender As Object, e As EventArgs) Handles btnDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDonePerformance_Click(sender As Object, e As EventArgs) Handles btnDonePerformance.Click
        btnOK.Enabled = True
        btnDonePerformance.Enabled = False
        TabControl1.Enabled = False
    End Sub

    Private Sub optOpenCoil_CheckedChanged(sender As Object, e As EventArgs) Handles optOpenCoil.CheckedChanged
        If optOpenCoil.Checked Then
            chkPressurePlate.Enabled = True
        End If
    End Sub

    Private Sub optFinTube_CheckedChanged(sender As Object, e As EventArgs) Handles optFinTube.CheckedChanged
        If optFinTube.Checked = True Then
            chkPressurePlate.Enabled = False
            chkPressurePlate.Checked = False
        End If
    End Sub

    Private Sub optSATCtrl_CheckedChanged(sender As Object, e As EventArgs) Handles optSATCtrl.CheckedChanged
        If optSATCtrl.Checked = True Then
            chkTempering.Enabled = True
        Else
            chkTempering.Enabled = False
            chkTempering.Checked = False
        End If
    End Sub

    Private Sub CalculatePerformance()
        Dim topfrac, bottomfrac As Double
        Dim derate As Double
        Dim deltat As Double

        topfrac = Val(txtAppliedCapacitykw.Text)
        bottomfrac = Val(txtInputCapkW.Text)
        derate = topfrac ^ 2 / bottomfrac ^ 2
        txtAppliedCapacitykw.Text = Format(derate * Val(txtInputCapkW.Text), "0.0")
        txtAppliedCapacitymbh.Text = Format(Val(txtAppliedCapacitykw.Text) * 3.41214, "0.0")
        deltat = (Val(txtAppliedCapacitymbh.Text) * 1000) / 1.085 / Val(txtHeatAF.Text)
        txtDeltaT.Text = Format(deltat, "0.0")
        txtLAT.Text = Format(Val(txtEAT.Text) + deltat, "0.0")
    End Sub

    Private Sub txtHeaterVoltage_Leave(sender As Object, e As EventArgs) Handles txtHeaterVoltage.Leave
        Call CalculatePerformance()
    End Sub

    Private Sub cmdCapacityCalcs_Click(sender As Object, e As EventArgs) Handles cmdCapacityCalcs.Click
        Call CalculatePerformance()
    End Sub

    Private Function CalculateStatic() As String
        Dim airflow, area, velocity As Double
        Dim pplate, opencoil, fintube As Boolean
        Dim apd As Double

        area = Val(txtHeaterH.Text) * Val(txtHeaterW.Text) / 144
        airflow = Val(txtHeatAF.Text)

        txtHeaterVel.Text = Format(airflow / area, "0.0")

        pplate = chkPressurePlate.Checked
        opencoil = optOpenCoil.Checked
        fintube = optFinTube.Checked

        If opencoil And Not (pplate) Then
            apd = 0.000000159867271 * velocity ^ 1.84978474764467
        End If

        If pplate Then
            apd = 0.000000813121828994 * velocity ^ 1.88699380930719
        End If

        If fintube Then
            apd = 0.00000044610344757 * velocity ^ 1.84978282726347
        End If

        'add an allowance for the imperfect curve fit.
        apd = apd * 1.1

        Return Format(apd, "0.00")

    End Function

    Private Sub cmdStaticCalcs_Click(sender As Object, e As EventArgs) Handles cmdStaticCalcs.Click
        txtHeaterSP.Text = CalculateStatic()

    End Sub
End Class