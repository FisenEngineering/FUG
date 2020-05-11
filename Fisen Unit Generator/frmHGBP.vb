Imports System.ComponentModel
Imports System.Xml
Public Class frmHGBP
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
        Call UpdatePerformance
        Call UpdateWeightTable
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("HGBP") 'Mod Code goes here!
        Call UpdateCodeList()
        If chkWriteHistory.Checked = True Then Call WriteHistory()
        Me.Hide()
    End Sub

    Private Sub WriteHistory()
        'Updated to version 2.0 24 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'Next dim the module specific 
        Dim Ckt1, Ckt2, Ckt3, Ckt4 As String

        Dim MySQL As String
        Dim ExistingRecordID As String
        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text
        modnum = frmMain.txtModelNumber.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        If chkStage1.Checked Then
            Ckt1 = cmbHGBPStyle1.Text
        Else
            Ckt1 = "N/A"
        End If
        If chkStage2.Checked Then
            Ckt2 = cmbHGBPStyle2.Text
        Else
            Ckt2 = "N/A"
        End If
        If chkStage3.Checked Then
            Ckt3 = cmbHGBPStyle3.Text
        Else
            Ckt3 = "N/A"
        End If
        If chkStage4.Checked Then
            Ckt4 = cmbHGBPStyle4.Text
        Else
            Ckt4 = "N/A"
        End If

        MySQL = "Select * FROM tblHistoryHGBP WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryHGBP SET Circuit1='" & Ckt1 & "', Circuit2='" & Ckt2 & "', " & "Circuit3='" & Ckt3 & "', Circuit4='" & Ckt4 & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryHGBP (JobName,UnitID,Version,ModelNumber,Circuit1,Circuit2,Circuit3,Circuit4) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & Ckt1 & "','" & Ckt2 & "','" & Ckt3 & "','" & Ckt4 & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub UpdateCodeList()
        ModuleCodeList.Clear()

        'Add the level 0 code
        ModuleCodeList.Add("705100")
        If optManIso.Checked Then ModuleCodeList.Add("705105")
        If optSolIso.Checked Then ModuleCodeList.Add("705110")
        If optNoIso.Checked Then ModuleCodeList.Add("705115")
        If chkDischargeTStat.Checked Then ModuleCodeList.Add("705120")
        Select Case cmbHGBPStyle1.SelectedIndex
            Case Is = 0
                ModuleCodeList.Add("705151")
            Case Is = 1
                ModuleCodeList.Add("705161")
            Case Is = 2
                ModuleCodeList.Add("705181")
            Case Is = 3
                ModuleCodeList.Add("705171")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle2.SelectedIndex
            Case Is = 0
                ModuleCodeList.Add("705152")
            Case Is = 1
                ModuleCodeList.Add("705162")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                ModuleCodeList.Add("705172")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle3.SelectedIndex
            Case Is = 0
                ModuleCodeList.Add("705153")
            Case Is = 1
                ModuleCodeList.Add("705163")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                ModuleCodeList.Add("705173")
            Case Is = 4
                'Do Nothing 
        End Select
        Select Case cmbHGBPStyle4.SelectedIndex
            Case Is = 0
                ModuleCodeList.Add("705154")
            Case Is = 1
                ModuleCodeList.Add("705164")
            Case Is = 2
                'Do Nothing
            Case Is = 3
                ModuleCodeList.Add("705174")
            Case Is = 4
                'Do Nothing 
        End Select

        If chkRemoveJCIHGBP.Checked Then
            ModuleCodeList.Add("705175")
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("705F6A")
        End If

        Call PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
            AddUniqueEndDeviceRequirements(ModuleCodeList.Item(i))
        Next i

    End Sub
    Private Sub UpdateWarrantyItems()
        'using logic complete the following items...
        If chkDischargeTStat.Checked = True Then frmMain.ThisUnitWarrTest.CtrlTest = True
        frmMain.ThisUnitWarrTest.RefTest = True
        'get the idea?

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("HGBP")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Hot Gas Bypass")
        tempWeight = "9999"
        'Now it's logic to assign the values.
        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                If chkStage1.Checked = True Then tempWeight = "25"
                If chkStage2.Checked = True Then tempWeight = "50"
                If chkStage3.Checked = True Then tempWeight = "75"
                If chkStage4.Checked = True Then tempWeight = "100"
            Case Is = "Series10"
                If chkStage1.Checked = True Then tempWeight = "25"
                If chkStage2.Checked = True Then tempWeight = "50"
                If chkStage3.Checked = True Then tempWeight = "75"
                If chkStage4.Checked = True Then tempWeight = "100"
            Case Is = "Series12"
                If chkStage1.Checked = True Then tempWeight = "25"
                If chkStage2.Checked = True Then tempWeight = "50"
                If chkStage3.Checked = True Then tempWeight = "75"
                If chkStage4.Checked = True Then tempWeight = "100"
            Case Is = "Series20"
                If chkStage1.Checked = True Then tempWeight = "30"
                If chkStage2.Checked = True Then tempWeight = "60"
                If chkStage3.Checked = True Then tempWeight = "90"
                If chkStage4.Checked = True Then tempWeight = "120"
            Case Is = "Series40"
                If chkStage1.Checked = True Then tempWeight = "35"
                If chkStage2.Checked = True Then tempWeight = "70"
                If chkStage3.Checked = True Then tempWeight = "105"
                If chkStage4.Checked = True Then tempWeight = "140"
            Case Is = "Series100"
                If chkStage1.Checked = True Then tempWeight = "55"
                If chkStage2.Checked = True Then tempWeight = "90"
                If chkStage3.Checked = True Then tempWeight = "125"
                If chkStage4.Checked = True Then tempWeight = "160"
            Case Is = "Choice"
                If chkStage1.Checked = True Then tempWeight = "30"
                If chkStage2.Checked = True Then tempWeight = "60"
                If chkStage3.Checked = True Then tempWeight = "90"
                If chkStage4.Checked = True Then tempWeight = "120"
            Case Is = "Select"
                If chkStage1.Checked = True Then tempWeight = "30"
                If chkStage2.Checked = True Then tempWeight = "60"
                If chkStage3.Checked = True Then tempWeight = "90"
                If chkStage4.Checked = True Then tempWeight = "120"
            Case Is = "Premier"
                If chkStage1.Checked = True Then tempWeight = "55"
                If chkStage2.Checked = True Then tempWeight = "90"
                If chkStage3.Checked = True Then tempWeight = "125"
                If chkStage4.Checked = True Then tempWeight = "160"
            Case Else
                tempWeight = "9999"
        End Select
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        'items here will look like frmmain.thiunitheatperf.deltat = txtDeltat.text
        'No Changes to performance
    End Sub
    Private Sub frmHGBP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer
        pCancelled = False

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        'no obvious need for a famcase structure for this module at load time.
        cmbHGBPStyle1.Text = "To Suction Line"
        cmbHGBPStyle2.Text = "None"
        cmbHGBPStyle3.Text = "None"
        cmbHGBPStyle4.Text = "None"
        cmbRefrigerant.Text = "R410A"

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()

        ModuleCodeList.Add("705100")

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        'Scan the Factory Installed items for microchannel coils
        For i = 0 To frmMain.ThisUnitFactOpts.Count - 1
            If InStr(frmMain.ThisUnitFactOpts.Item(i), "Micro Channel") > 0 Then
                chkDischargeTStat.Checked = True
                Exit For
            End If
        Next

    End Sub

    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/HGBP")

        TempVal = xNodeRoot.SelectSingleNode("Circuit1").InnerText
        If TempVal = "Yes" Then
            chkStage1.Checked = True
            cmbHGBPStyle1.Text = "To Suction Line"
            TempVal = xNodeRoot.SelectSingleNode("Rawal1").InnerText
            If TempVal = "Yes" Then cmbHGBPStyle1.Text = "Rawal"
        Else
            chkStage1.Checked = False
            cmbHGBPStyle1.Text = ""
        End If

        TempVal = xNodeRoot.SelectSingleNode("Circuit2").InnerText
        If TempVal = "Yes" Then
            chkStage2.Checked = True
            cmbHGBPStyle2.Text = "To Suction Line"
            TempVal = xNodeRoot.SelectSingleNode("Rawal2").InnerText
            If TempVal = "Yes" Then cmbHGBPStyle2.Text = "Rawal"
        Else
            chkStage2.Checked = False
            cmbHGBPStyle2.Text = ""
        End If

        TempVal = xNodeRoot.SelectSingleNode("Circuit3").InnerText
        If TempVal = "Yes" Then
            chkStage3.Checked = True
            cmbHGBPStyle3.Text = "To Suction Line"
            TempVal = xNodeRoot.SelectSingleNode("Rawal3").InnerText
            If TempVal = "Yes" Then cmbHGBPStyle3.Text = "Rawal"
        Else
            chkStage3.Checked = False
            cmbHGBPStyle3.Text = ""
        End If

        TempVal = xNodeRoot.SelectSingleNode("Circuit4").InnerText
        If TempVal = "Yes" Then
            chkStage4.Checked = True
            cmbHGBPStyle4.Text = "To Suction Line"
            TempVal = xNodeRoot.SelectSingleNode("Rawal4").InnerText
            If TempVal = "Yes" Then cmbHGBPStyle4.Text = "Rawal"
        Else
            chkStage4.Checked = False
            cmbHGBPStyle4.Text = ""
        End If

        TempVal = xNodeRoot.SelectSingleNode("JCI2Rawal").InnerText
        If TempVal = "Yes" Then chkRemoveJCIHGBP.Checked = True





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
    End Sub

    Private Sub chkStage2_CheckedChanged(sender As Object, e As EventArgs) Handles chkStage2.CheckedChanged
        If chkStage2.Checked = False Then cmbHGBPStyle2.Text = "None"
        If chkStage3.Checked = False Then cmbHGBPStyle3.Text = "None"
        If chkStage4.Checked = False Then cmbHGBPStyle4.Text = "None"

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub cmbHGBPStyle1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHGBPStyle1.SelectedIndexChanged
        If cmbHGBPStyle1.Text = "Rawal" Then
            chkRemoveJCIHGBP.Enabled = True
            chkRemoveJCIHGBP.Checked = False
        Else
            chkRemoveJCIHGBP.Enabled = False
            chkRemoveJCIHGBP.Checked = False
        End If
    End Sub

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "HGBP"
        frmHistoryReport.cmbModCode.Text = "HGBP"
        frmHistoryReport.Show()
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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '705%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '705%'"
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
End Class