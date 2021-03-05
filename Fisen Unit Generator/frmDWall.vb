Imports System.ComponentModel
Imports System.Xml
Public Class frmDWall
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
        Call UpdateWarrantyItems()
        frmMain.ThisUnitMods.Add("DWall") 'Mod Code goes here!
        Call UpdateCodeList()

        If chkWriteHistory.Checked = True Then Call WriteHistory()

        PerformDesignCautionScan(False)

        For i = 0 To ModuleCodeList.Count - 1
            frmMain.ThisUnitCodes.Add(ModuleCodeList.Item(i))
        Next i

        Me.Hide()
    End Sub

    Private Sub WriteHistory()
        'Updated to version 2.0 27 Apr 2020

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver, modnum As String
        'next we dim the module specific
        Dim HXAction, Material As String

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

        Material = lstLinerMaterial.Text
        HXAction = "Error"
        If optHXComesOut.Checked Then HXAction = "Remove/Rinstall HX"
        If optHXNotThere.Checked Then HXAction = "No Gas Heat"
        If optHXStaysIn.Checked Then HXAction = "Keep HX Installed"

        MySQL = "Select * FROM tblHistoryDWall WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "')"
        rs.Open(MySQL, con)

        If Not (rs.EOF And rs.BOF) Then
            'Update SQL
            ExistingRecordID = rs.Fields(0).Value
            MySQL = "UPDATE tblHistoryDWall SET HXAction='" & HXAction & "', Material='" & Material & "' WHERE ID=" & ExistingRecordID
            con.Execute(MySQL)
        Else
            'Insert SQL
            MySQL = "INSERT INTO tblHistoryDWall (JobName, UnitID, Version, ModelNumber, HXAction, Material) VALUES ('" & jname & "','" & unit & "','" & ver & "','" & modnum & "','" & HXAction & "','" & Material & "')"
            con.Execute(MySQL)
        End If

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub UpdateCodeList()

        ModuleCodeList.Clear()
        'Add the level 0 code
        ModuleCodeList.Add("605100")
        If lstLinerMaterial.Text = "Galvanized Liners" Then ModuleCodeList.Add("605101")
        If lstLinerMaterial.Text = "Stainless Steel(304) Liners" Then ModuleCodeList.Add("605102")
        If frmMain.ThisUnitHeatPerf.HeatType = "Gas Heat" Then
            If optHXStaysIn.Checked = True Then
                ModuleCodeList.Add("605105")
            Else
                ModuleCodeList.Add("605110")
            End If
        Else
            ModuleCodeList.Add("605115")
        End If

        If chk65kASCCRBase.Checked Then
            ModuleCodeList.Add("605F6A")
        End If


    End Sub
    Private Sub UpdateWarrantyItems()
        'There are no warranty items related to this modification.

    End Sub
    Private Sub UpdateWeightTable()
        Dim tempWeight As String
        Dim SSWalls As Boolean

        'next line is the mod code i.e. HWCoil...
        frmMain.ThisUnitPhysicalData.ModLoadMod.Add("DWall")
        'Next Line is the line item description i.e. Hot Water Description
        frmMain.ThisUnitPhysicalData.ModLoadItem.Add("Double Wall Sheet Metal Liners")
        tempWeight = "9999"
        'Now it's logic to assign the values.

        SSWalls = False
        If lstLinerMaterial.GetItemText(lstLinerMaterial.SelectedItem) = "Stainless Steel(304) Liners" Then SSWalls = True

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series5"
                tempWeight = "86"
            Case Is = "Series10"
                tempWeight = "115"
            Case Is = "Series12"
                tempWeight = "128"
            Case Is = "Series20"
                tempWeight = "187"
            Case Is = "Choice"
                tempWeight = "190"
            Case Else
                tempWeight = "9999"
        End Select
        If SSWalls = True Then
            tempWeight = tempWeight * 0.95
        End If
        frmMain.ThisUnitPhysicalData.ModLoadMass.Add(tempWeight)
    End Sub
    Private Sub UpdatePerformance()
        Dim dummy As MsgBoxResult
        If Not (chkNoPerformance.Checked) Then
            dummy = MsgBox("Error in Performance Logic")
        End If
    End Sub
    Private Sub frmHWCoil_Load(sender As Object, e As EventArgs) Handles Me.Load
        pCancelled = False

        If frmMain.chk65kASCCRBase.Checked Then chk65kASCCRBase.Checked = True

        If Not (frmMain.chkDebug.Checked) Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("DebugPage"))
        End If

        If Not (frmMain.chkInhibitDigConditions.Checked) Then Call LoadDigConditions()
        ModuleCodeList.Add("605100")

    End Sub
    Private Sub LoadDigConditions()
        Dim ModFilePath As String
        Dim xDoc As XmlDocument = New XmlDocument
        Dim TempVal As String


        ModFilePath = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Sales Info\" & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - ModsFile.xml"
        xDoc.Load(ModFilePath)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//ModFile/Modifications/DWall")

        TempVal = xNodeRoot.SelectSingleNode("Material").InnerText
        If TempVal = "Galvanized G90" Then
            lstLinerMaterial.Text = "Galvanized Liners"
        End If
        If TempVal = "SS 304" Then
            lstLinerMaterial.Text = "Stainless Steel(304) Liners"
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

    Private Sub frmDWall_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lstLinerMaterial.SelectedIndex = 0 'Select Galvanized as the default

    End Sub

    Private Sub cmdDesignCautions_Click(sender As Object, e As EventArgs) Handles cmdDesignCautions.Click
        PerformDesignCautionScan(True)

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
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode LIKE '605%'"
            Else
                MySQL = "SELECT COUNT(*) as RowCount FROM tblDesignCautions WHERE TriggerCode='" & ModuleCodeList.Item(i) & "'"
            End If

            rs.Open(MySQL, con)
            RecCount = rs.Fields("RowCount").Value
            rs.Close()

            If RecCount > 0 Then
                If Prelim Then
                    MySQL = "SELECT * FROM tblDesignCautions WHERE TriggerCode LIKE '605%'"
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

    Private Sub cmdViewHistory_Click(sender As Object, e As EventArgs) Handles cmdViewHistory.Click
        frmHistoryReport.MyModule = "DWall"
        frmHistoryReport.cmbModCode.Text = "DWall"
        frmHistoryReport.Show()
    End Sub
End Class