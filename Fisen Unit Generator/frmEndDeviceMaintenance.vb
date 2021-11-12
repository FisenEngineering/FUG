Public Class frmEndDeviceMaintenance
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub frmEndDeviceMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSensorClass.Text = "All"
        Call PopulateEndDeviceList()
    End Sub

    Private Sub PopulateEndDeviceList()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim lEDType As String
        Dim lID, lEDName, lEDTag, lEDCutSheet, lEDCutSheetPath, lEDClass As String
        Dim EDClassFilter As String
        Dim NewRow As String()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        lEDType = "Unk"
        lEDClass = "Unk"
        If optEDTSensor.Checked Then
            lEDType = "Sensor"
            lEDClass = cmbSensorClass.Text
        End If
        If optEDTEndDevice.Checked Then
            lEDType = "End Device"
            lEDClass = cmbEndDeviceClass.Text
        End If

        EDClassFilter = ""
        If lEDClass <> "All" Then
            EDClassFilter = " AND (EDClass LIKE '" & lEDClass & "%')"
        End If

        dgvEndDevices.Rows.Clear()

        MySQL = "SELECT * FROM tblEndDevices WHERE (EDType='" & lEDType & "')" & EDClassFilter
        rs.Open(MySQL, con)
        Do While Not rs.EOF
            lID = rs.Fields("ID").Value
            lEDName = rs.Fields("EDName").Value
            lEDTag = rs.Fields("EDTag").Value
            lEDCutSheet = rs.Fields("EDCutSheet").Value
            lEDCutSheetPath = rs.Fields("EDCutSheetPath").Value
            NewRow = {lID, lEDTag, lEDName, "Upload", lEDCutSheet, lEDCutSheetPath}
            dgvEndDevices.Rows.Add(NewRow)
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
        con = Nothing
    End Sub

    Private Sub optEDTSensor_CheckedChanged(sender As Object, e As EventArgs) Handles optEDTSensor.CheckedChanged
        If optEDTSensor.Checked Then
            cmbEndDeviceClass.Text = "All"
            cmbEndDeviceClass.Enabled = False
            cmbSensorClass.Enabled = True
            Call PopulateEndDeviceList()
        End If
    End Sub

    Private Sub optEDTEndDevice_CheckedChanged(sender As Object, e As EventArgs) Handles optEDTEndDevice.CheckedChanged
        If optEDTEndDevice.Checked Then
            cmbSensorClass.Text = "All"
            cmbSensorClass.Enabled = False
            cmbEndDeviceClass.Enabled = True
            Call PopulateEndDeviceList()
        End If
    End Sub

    Private Sub cmbSensorClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSensorClass.SelectedIndexChanged
        If optEDTSensor.Checked Then Call PopulateEndDeviceList()
    End Sub

    Private Sub cmbEndDeviceClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEndDeviceClass.SelectedIndexChanged
        If optEDTEndDevice.Checked Then Call PopulateEndDeviceList()
    End Sub

    Private Sub cmdSearchForFIOPs_Click(sender As Object, e As EventArgs) Handles cmdSearchForFIOPs.Click
        Call PopulateFIOPCodeList()
    End Sub

    Private Sub PopulateFIOPCodeList()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim lFIOPFilter, lFIOPCode, lDescription As String
        Dim NewRow As String()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        lFIOPFilter = txtFIOPCode.Text
        If Len(lFIOPFilter) = 0 Then Exit Sub
        If ((Len(lFIOPFilter) < 6) And (Mid(lFIOPFilter, Len(lFIOPFilter), 1) <> "%")) Then
            lFIOPFilter = lFIOPFilter & "%"
        End If

        dgvFIOPCodes.Rows.Clear()
        MySQL = "SELECT * FROM tblFisenInstalledOptions WHERE (FIOpCode LIKE'" & lFIOPFilter & "')"
        rs.Open(MySQL, con)
        Do While Not rs.EOF
            lFIOPCode = rs.Fields("FIOpCode").Value
            lDescription = rs.Fields("Description").Value
            NewRow = {lFIOPCode, lDescription}
            dgvFIOPCodes.Rows.Add(NewRow)
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
        con = Nothing
    End Sub

    Private Sub dgvFIOPCodes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFIOPCodes.SelectionChanged
        txtSelectedFIOP.Text = dgvFIOPCodes.SelectedRows.Item(0).Cells(0).Value & " - " & dgvFIOPCodes.SelectedRows.Item(0).Cells(1).Value
    End Sub

    Private Sub PopulateRqdEndDevices()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim lFIOPFilter, lFIOPCode, lDescription As String
        Dim NewRow As String()

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        lFIOPFilter = dgvFIOPCodes.SelectedRows.Item(0).Cells(0).Value

        dgvRequiredED.Rows.Clear()

        MySQL = "SELECT tblRequiredEndDevices.FIOpCode, tblEndDevices.EDTag, tblEndDevices.EDName FROM tblRequiredEndDevices INNER Join tblEndDevices On tblRequiredEndDevices.EndDeviceID = tblEndDevices.ID WHERE (tblRequiredEndDevices.FIOpCode='" & lFIOPFilter & "')"
        rs.Open(MySQL, con)
        Do While Not rs.EOF
            lFIOPCode = rs.Fields("FIOpCode").Value
            lDescription = rs.Fields("Description").Value
            NewRow = {lFIOPCode, lDescription}
            dgvRequiredED.Rows.Add(NewRow)
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
        con = Nothing
    End Sub

    Private Sub cmdCreateNewED_Click(sender As Object, e As EventArgs) Handles cmdCreateNewED.Click
        frmEndDeviceCreateNew.ShowDialog()
        frmEndDeviceCreateNew.Dispose()
        Call PopulateEndDeviceList()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pcancelled = True
        Me.Hide()
    End Sub
End Class