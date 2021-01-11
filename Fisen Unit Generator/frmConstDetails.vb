Public Class frmConstDetails
    Private CDTitleList As New ArrayList
    Private CDText As New ArrayList
    Private NewAssociation As New ArrayList
    Private NewAssID As New ArrayList

    Private pCurCDTextChanged As New Boolean
    Private pFIOPCode As String
    Private pPrimaryMod As String

    Public Property PrimaryMod As String
        Get
            Return pPrimaryMod
        End Get
        Set(value As String)
            pPrimaryMod = value
        End Set
    End Property
    Public Property FIOPCode As String
        Get
            Return pFIOPCode
        End Get
        Set(value As String)
            pFIOPCode = value
        End Set
    End Property


    Private Sub cmdAddNewDetail_Click(sender As Object, e As EventArgs) Handles cmdAddNewDetail.Click
        Dim dummy As MsgBoxResult
        Dim myMsg As String
        Dim myMBT As String
        Dim NewTitle As String


        myMBT = "Fisen Unit Generator"
        myMsg = "Please enter the text for the new Construction Detail Title."

        NewTitle = InputBox(myMsg, myMBT, "No Spell Checking Occurs.  Be Careful.")
        If ((NewTitle = "No Spell Checking Occurs.  Be Careful.") Or (NewTitle = "")) Then
            myMsg = "That's not a real title.  Try again."
            dummy = MsgBox(myMsg, vbOKOnly, myMBT)
            Exit Sub
        End If

        lstNewTitles.Items.Add(NewTitle)

        CDTitleList.Add(NewTitle)
        CDText.Add("This is a new detail.  Please Create the text.")
        lstNewTitles.SelectedItem = NewTitle
        lstNewAssociation.Items.Add(NewTitle)
        NewAssociation.Add(NewTitle)
        NewAssID.Add("NewOne")

    End Sub

    Private Sub lstNewTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNewTitles.SelectedIndexChanged
        txtCDText.Text = CDText.Item(lstNewTitles.SelectedIndex)
    End Sub

    Private Sub txtCDText_Leave(sender As Object, e As EventArgs) Handles txtCDText.Leave
        If CDText.Count > 0 Then
            If txtCDText.Text <> CDText.Item(lstNewTitles.SelectedIndex) Then CDText.Item(lstNewTitles.SelectedIndex) = txtCDText.Text
        End If
    End Sub

    Private Sub frmConstDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCommonDetail.Text = "Unselected"
        If pFIOPCode = "" Then pFIOPCode = "ZZZZZZ"
        If pPrimaryMod = "" Then pPrimaryMod = "XxxxXxx"
        txtFIOPCode.Text = pFIOPCode
        txtPrimaryMod.Text = pPrimaryMod

    End Sub

    Private Sub cmbCommonDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommonDetail.SelectedIndexChanged
        If cmbCommonDetail.Text <> "Unselected" Then cmdAddCommon.Enabled = True
    End Sub

    Private Sub cmdAddCommon_Click(sender As Object, e As EventArgs) Handles cmdAddCommon.Click
        Dim lNewDeet, lNewID As String
        Select Case cmbCommonDetail.Text

            Case Is = "Power Wiring RTU"
                lNewID = "51"
                lNewDeet = "Power Wiring RTU"
            Case Is = "Power Wiring Chiller"
                '267
                lNewID = "267"
                lNewDeet = "Power Wiring Chiller"
            Case Is = "Power Wiring AHU"
                '586
                lNewID = "586"
                lNewDeet = "Power Wiring AHU"
            Case Is = "Control Wiring RTU"
                '62
                lNewID = "62"
                lNewDeet = "Control Wiring RTU"
            Case Is = "Control Wiring Chiller"
                '268
                lNewID = "268"
                lNewDeet = "Control Wiring Chiller"
            Case Is = "Control Wiring AHU"
                '587
                lNewID = "587"
                lNewDeet = "Control Wiring AHU"
            Case Is = "Unit Mounted Disconnect Evaluation"
                '52
                lNewID = "52"
                lNewDeet = "Unit Mounted Disconnect Evaluation"
            Case Is = "Unselected"
                cmdAddCommon.Enabled = False
                Exit Sub
        End Select
        NewAssID.Add(lNewID)
        NewAssociation.Add(lNewDeet)
        lstNewAssociation.Items.Add(lNewDeet)
        cmdAddCommon.Enabled = False
        cmbCommonDetail.Text = "Unselected"
    End Sub

    Private Sub cmdPoputlateDGV_Click(sender As Object, e As EventArgs) Handles cmdPoputlateDGV.Click
        'Should probably consider checking the validity of the search terms
        Call QueryConstDeets(txtTitleQ.Text, txtTextQ.Text)
    End Sub
    Private Sub QueryConstDeets(ltitle As String, ldeet As String)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim NewRow As String()
        Dim ThisID As String
        Dim ThisTitle As String
        Dim ThisDeet As String

        Dim TitleWhereClause, DeetWhereClause As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        dgvExistingDetails.Rows.Clear()

        MySQL = "SELECT * FROM tblConstructionDetails"
        TitleWhereClause = ""
        If ltitle <> "" Then
            TitleWhereClause = " (DetailTitle LIKE '%" & ltitle & "%')"
            MySQL = MySQL & " WHERE" & TitleWhereClause
        End If

        If ldeet <> "" Then
            DeetWhereClause = " (DetailText Like '%" & ldeet & "%')"
            If TitleWhereClause = "" Then
                MySQL = MySQL & " WHERE" & DeetWhereClause
            Else
                MySQL = MySQL & " OR" & DeetWhereClause
            End If
        End If

        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            ThisID = rs.Fields("ID").Value
            ThisTitle = rs.Fields("DetailTitle").Value
            ThisDeet = rs.Fields("DetailText").Value
            NewRow = {ThisID, ThisTitle, ThisDeet}
            dgvExistingDetails.Rows.Add(NewRow)
            rs.MoveNext()
        Loop
        cmdAddSelectedRow.Enabled = False
        If dgvExistingDetails.Rows.Count > 1 Then
            cmdAddSelectedRow.Enabled = False
        End If
    End Sub

    Private Sub dgvExistingDetails_SelectionChanged(sender As Object, e As EventArgs) Handles dgvExistingDetails.SelectionChanged
        cmdAddSelectedRow.Enabled = True
    End Sub

    Private Sub cmdAddSelectedRow_Click(sender As Object, e As EventArgs) Handles cmdAddSelectedRow.Click
        Dim lNewDeet As String
        Dim lNewID As String

        lNewDeet = dgvExistingDetails.SelectedRows.Item(0).Cells(1).Value
        lNewID = dgvExistingDetails.SelectedRows.Item(0).Cells(0).Value
        lstNewAssociation.Items.Add(lNewDeet)
        NewAssID.Add(lNewID)
        NewAssociation.Add(lNewDeet)


        cmdAddSelectedRow.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dummy As MsgBoxResult
        If NewAssociation.Count = 0 Then
            dummy = MsgBox("No new associations added Proceed?", vbOKCancel, "Fisen Unit Generator")
            If dummy = vbCancel Then Exit Sub
        Else
            Call CreateNewDetails()
            Call GetNewDetailIDs()
            Call CreateNewAssociations()
        End If
        Me.Hide()
    End Sub

    Private Sub GetNewDetailIDs()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim ExistingRecordID As String

        Dim i As Integer
        Dim lTitle As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        For i = 0 To CDTitleList.Count - 1
            lTitle = CDTitleList.Item(i)

            MySQL = "SELECT * FROM tblConstructionDetails WHERE DetailTitle='" & lTitle & "'"
            rs.Open(MySQL, con)
            ExistingRecordID = rs.Fields("ID").Value
            NewAssID.Item(i) = Trim(ExistingRecordID)
            rs.Close()


        Next

        con.Close()
        con = Nothing

    End Sub
    Private Sub CreateNewDetails()
        Dim con As ADODB.Connection
        Dim dbProvider As String

        Dim MySQL As String

        Dim i As Integer
        Dim lTitle, lDeet, lPMod, lDetailItem As String

        lDetailItem = "FALSE"
        lPMod = pPrimaryMod

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        For i = 0 To CDTitleList.Count - 1
            lTitle = CDTitleList.Item(i)
            lDeet = CDText.Item(i)
            MySQL = "INSERT INTO tblConstructionDetails (PrimaryMod, DetailTitle,DetailText,DetailItem) VALUES ('" & lPMod & "','" & lTitle & "','" & lDeet & "'," & lDetailItem & ")"
            con.Execute(MySQL)
        Next

        con.Close()
        con = Nothing
    End Sub
    Private Sub CreateNewAssociations()
        Dim con As ADODB.Connection
        Dim dbProvider As String

        Dim MySQL As String

        Dim i As Integer
        Dim lFIOP, lDetailID As String

        lFIOP = txtFIOPCode.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        For i = 0 To NewAssID.Count - 1
            lDetailID = NewAssID.Item(i)
            MySQL = "INSERT INTO tblRequiredDetails (FIOpCode,DetailID) VALUES ('" & lFIOP & "','" & lDetailID & "')"
            con.Execute(MySQL)
        Next

        con.Close()
        con = Nothing
    End Sub
End Class