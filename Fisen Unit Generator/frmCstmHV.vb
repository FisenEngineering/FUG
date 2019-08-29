Public Class frmCstmHV
    Private pCancelled As Boolean
    Private pModsSelected As Integer()
    Private pTagALongsSelected As New ArrayList
    Private pTagALongParent As New ArrayList

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub frmCstmHV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadPermittedPowerMods()

    End Sub

    Private Sub LoadPermittedPowerMods()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstItemsInDB.Items.Clear()


        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCstmHVDB WHERE " & frmMain.ThisUnit.Family & "OK=TRUE AND TagALongOnly=FALSE ORDER BY CstmFIOP"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstItemsInDB.Items.Add(rs.Fields("CstmFIOP").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i As Integer
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String
        Dim tempWeight As String

        tempWeight = -9999.0

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1

            MySQL = "SELECT * FROM tblCstmHVDB WHERE CstmFIOP='" & lstItemsInDB.SelectedItems.Item(i) & "'"
            rs.Open(MySQL, con)

            rs.MoveFirst()
            Do While Not (rs.EOF)
                'Call UpdatePerformance()

                'Handle the mass
                frmMain.ThisUnitPhysicalData.ModLoadMod.Add("CstmHV")
                frmMain.ThisUnitPhysicalData.ModLoadItem.Add(rs.Fields("CstmFIOP").Value)
                frmMain.ThisUnitPhysicalData.ModLoadMass.Add(rs.Fields("CstmWeight").Value)

                'Handle the warranty
                If rs.Fields("TestAF").Value = True Then frmMain.ThisUnitWarrTest.AirflowTest = True
                If rs.Fields("TestCoil").Value = True Then frmMain.ThisUnitWarrTest.CoilTest = True
                If rs.Fields("TestCtrl").Value = True Then frmMain.ThisUnitWarrTest.CtrlTest = True
                If rs.Fields("TestMotor").Value = True Then frmMain.ThisUnitWarrTest.MotorTest = True
                If rs.Fields("TestEHeat").Value = True Then frmMain.ThisUnitWarrTest.EHeatTest = True
                If rs.Fields("TestGHeat").Value = True Then frmMain.ThisUnitWarrTest.GHeatTest = True
                If rs.Fields("TestGTrain").Value = True Then frmMain.ThisUnitWarrTest.GasTrainTest = True
                If rs.Fields("TestHydro").Value = True Then frmMain.ThisUnitWarrTest.HydroPress = True
                If rs.Fields("TestRef").Value = True Then frmMain.ThisUnitWarrTest.RefTest = True
                If rs.Fields("TestRefInst").Value = True Then frmMain.ThisUnitWarrTest.RefInsp = True

                Call UpdateCodeList(rs.Fields("CstmCode").Value)
                If rs.Fields("MCAChange").Value = True Then
                    Call CustomMCARequired(rs.Fields("LoadName").Value, rs.Fields("LoadHP").Value, rs.Fields("LoadValue").Value)
                End If
                Call UpdateJCIRequiredItems(rs.Fields("CstmCode").Value)
                rs.MoveNext()

            Loop
            rs.Close()

        Next i
        con.Close()
        rs = Nothing
        con = Nothing
        Me.Hide()
    End Sub
    Private Sub CustomMCARequired(LoadName As String, LoadHP As String, LoadValue As String)
        Dim elecchar As String
        Dim newrow As String()

        If frmMain.UseCustomMCA = False Then
            frmMain.UseCustomMCA = True
            Call frmMain.PreLoadElec()
        End If
        elecchar = frmMain.ThisUnitElecData.CommVolts & "-" & frmMain.ThisUnitElecData.CommPhase & "-" & frmMain.ThisUnitElecData.CommFreq
        newrow = {True, False, "All", True, LoadName, elecchar, LoadHP, LoadValue, False}
        frmMain.dgvElecLoads.Rows.Add(newrow)

    End Sub
    Private Sub UpdateJCIRequiredItems(loccode As String)
        Dim lcon As ADODB.Connection
        Dim lrs As ADODB.Recordset
        Dim ldbProvider As String
        Dim MySQL2 As String
        Dim reccount As Integer

        lcon = New ADODB.Connection
        ldbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        lcon.ConnectionString = ldbProvider
        lcon.Open()
        lrs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        MySQL2 = "SELECT COUNT(*) as RowCount FROM tblCstmJCIRequired WHERE CstmFIOPID='" & loccode & "'"
        lrs.Open(MySQL2, lcon)
        reccount = lrs.Fields("RowCount").Value
        lrs.Close()
        If reccount > 0 Then
            MySQL2 = "SELECT * FROM tblCstmJCIRequired WHERE CstmFIOPID='" & loccode & "'"
            lrs.Open(MySQL2, lcon)
            'If lrs.RecordCount > 0 Then
            lrs.MoveFirst()
            Do While Not (lrs.EOF)
                frmMain.lstRequiredFactoryItems.Items.Add(lrs.Fields("JCIRequiredItem").Value)
                lrs.MoveNext()
            Loop
            'End If

            lcon.Close()
        End If
        lrs = Nothing
        lcon = Nothing
    End Sub
    Private Sub AddFieldInstalledItems(locCode As String)

        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='FieldInstalled')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            frmMain.ThisUnitFieldInst.Add(rs2.Fields("TagALongData").Value)
            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub AddTagALongCodes(locCode As String)
        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='FIOP')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            UpdateCodeList(rs2.Fields("TagALongData").Value)
            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub AddJCIREquiredMods(locCode As String)

        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }
        MySQL2 = "SELECT * FROM tblCstmTagALong WHERE (CstmCode='" & locCode & "') AND (TagALongType='JCIRqd')"
        rs2.Open(MySQL2, con2)

        Do While Not (rs2.EOF)
            frmMain.lstRequiredFactoryItems.Items.Add(rs2.Fields("TagALongData").Value)

            rs2.MoveNext()
        Loop
        rs2.Close()

        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub UpdateCodeList(locCode As String)
        Dim i As Integer
        frmMain.ThisUnitCstmHVCodes.Add(locCode)
        For i = 0 To pTagALongParent.Count - 1
            If pTagALongParent.Item(i) = locCode Then
                frmMain.ThisUnitCstmMechCodes.Add(pTagALongsSelected.Item(i))
            End If
        Next
    End Sub

    Private Sub btnDoneSelection_Click(sender As Object, e As EventArgs) Handles btnDoneSelection.Click

        Call PerformDesignCautionScan()
        lblCount.Text = Str(lstItemsInDB.SelectedItems.Count - 1)
        lblCurrentCstmMod.Text = lstItemsInDB.SelectedItems.Item(Val(lblCount.Text))
        Call TagALongPopulate(lblCurrentCstmMod.Text)

        TabControl1.SelectTab("tpgConditions")
    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click

        Dim i As Integer
        Dim temp As String

        If ((lstTagAlongs.SelectedItems.Count > 0) And (lblCount.Text <> 0)) Then
            For i = 0 To lstTagAlongs.SelectedItems.Count - 1
                temp = Mid(lstTagAlongs.SelectedItems.Item(i), 1, 6)
                pTagALongsSelected.Add(temp)
                pTagALongParent.Add(lblCurrentCode.Text)
            Next
        End If

        If lblCount.Text <> 0 Then
            lblCount.Text = Val(lblCount.Text - 1)
            lblCurrentCstmMod.Text = lstItemsInDB.SelectedItems.Item(Val(lblCount.Text))
            Call TagALongPopulate(lblCurrentCstmMod.Text)
        Else
            If lstTagAlongs.SelectedItems.Count > 0 Then
                For i = 0 To lstTagAlongs.SelectedItems.Count - 1
                    pTagALongsSelected.Add(Mid(lstTagAlongs.SelectedItems.Item(i), 1, 6))
                    pTagALongParent.Add(lblCurrentCode.Text)
                Next
            End If
            TabControl1.SelectTab("tpgOptions")
        End If

    End Sub

    Private Sub cmdDoneOptions_Click(sender As Object, e As EventArgs) Handles cmdDoneOptions.Click
        TabControl1.SelectTab("tpgControls")
    End Sub

    Private Sub btnDoneControls_Click(sender As Object, e As EventArgs) Handles btnDoneControls.Click
        TabControl1.SelectTab("tpgPerformance")
    End Sub

    Private Sub btnDonePerf_Click(sender As Object, e As EventArgs) Handles btnDonePerf.Click
        btnOK.Enabled = True
        btnDonePerf.Enabled = False
        TabControl1.Enabled = False
    End Sub
    Private Sub TagALongPopulate(loccode As String)
        Dim con2 As ADODB.Connection
        Dim rs2 As ADODB.Recordset
        Dim dbProvider2 As String
        Dim MySQL2 As String
        Dim Reccount As Integer
        con2 = New ADODB.Connection
        dbProvider2 = "FIL=MS ACCESS;DSN=FUGenerator"
        con2.ConnectionString = dbProvider2
        con2.Open()
        rs2 = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

        MySQL2 = "SELECT COUNT(*) as RowCount FROM tblCstmHVDB INNER JOIN tblCstmTagALong ON tblCstmHVDB.CstmCode = tblCstmTagALong.CstmCode WHERE (((tblCstmHVDB.CstmFIOP)='" & loccode & "'))"
        rs2.Open(MySQL2, con2)
        Reccount = rs2.Fields("RowCount").Value
        rs2.Close()

        If Reccount > 0 Then
            MySQL2 = "SELECT tblCstmHVDB.CstmCode as CstmCode, tblCstmHVDB.CstmFIOP as CstmFIOP, tblCstmTagALong.TagALongData as TagALongID, tblCstmTagALong.DataComment as TagAlongName FROM tblCstmHVDB INNER JOIN tblCstmTagALong ON tblCstmHVDB.CstmCode = tblCstmTagALong.CstmCode WHERE (((tblCstmHVDB.CstmFIOP)='" & loccode & "'))"

            rs2.Open(MySQL2, con2)
            lstTagAlongs.Items.Clear()
            lblCurrentCode.Text = rs2.Fields("CstmCode").Value

            Do While Not (rs2.EOF)

                lstTagAlongs.Items.Add(rs2.Fields("TagAlongID").Value & "-" & rs2.Fields("TagAlongName").Value)
                rs2.MoveNext()
            Loop
            rs2.Close()
        End If
        con2.Close()
        rs2 = Nothing
        con2 = Nothing
    End Sub
    Private Sub PerformDesignCautionScan()
        Dim i As Integer
        Dim dummy As MsgBoxResult
        Dim startingcaution As String
        Dim eachline As String
        Dim totalmessage As String
        Dim spacepos As Integer
        Dim Reccount As Integer

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

        For i = 0 To lstItemsInDB.SelectedItems.Count - 1
            MySQL = "SELECT COUNT(*) as RowCount FROM tblCstmHVDB INNER JOIN tblDesignCautions ON tblCstmHVDB.CstmCode = tblDesignCautions.TriggerCode WHERE tblCstmHVDB.CstmFIOP='" & lstItemsInDB.SelectedItems.Item(i) & "'"
            rs.Open(MySQL, con)
            Reccount = rs.Fields("RowCount").Value
            rs.Close()

            If Reccount > 0 Then
                MySQL = "SELECT tblCstmHVDB.CstmCode as CstmCode, tblCstmHVDB.CstmFIOP as CstmFIOP, tblDesignCautions.ShortName as ShortName, tblDesignCautions.LongText as MyLongText, tblDesignCautions.TriggerCode as TriggerCode FROM tblCstmHVDB INNER JOIN tblDesignCautions ON tblCstmHVDB.CstmCode = tblDesignCautions.TriggerCode WHERE tblCstmHVDB.CstmFIOP='" & lstItemsInDB.SelectedItems.Item(i) & "'"
                rs.Open(MySQL, con)

                rs.MoveFirst()
                Do While Not (rs.EOF)
                    dummy = MsgBox(rs.Fields("ShortName").Value & vbCrLf & "Do you wish to see details?", vbYesNo, rs.Fields("CstmFIOP").Value)
                    If dummy = vbYes Then
                        totalmessage = ""
                        startingcaution = rs.Fields("MyLongText").Value
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
                        dummy = MsgBox(totalmessage, vbOKOnly, rs.Fields("CstmFIOP").Value)
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