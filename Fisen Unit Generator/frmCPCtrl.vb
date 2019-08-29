Public Class frmCPCtrl
    Public EndDeviceCodes As New ArrayList
    Public ASensorList As New ArrayList
    Public BSensorList As New ArrayList
    Public ADeviceList As New ArrayList
    Public BDeviceList As New ArrayList

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Call UpdatePerformance
        'Call UpdateWeightTable
        'Call UpdateWarrantyItems()
        'frmMain.ThisUnitMods.Add("OA100") 'Mod Code goes here!
        'If frmMain.ThisUnit.GenCodesPresent = False Then
        'frmMain.ThisUnit.GenCodesPresent = True
        'frmMain.ThisUnitMods.Add("Common")
        'End If
        'Call UpdateCodeList
        Me.Hide()
    End Sub
    Private Sub UpdateCodeList()
        'Add the level 0 code
        frmMain.ThisUnitCodes.Add("930000")

        'Handle the enclosure choice
        If optUseUnitPanel.Checked Then frmMain.ThisUnitCodes.Add("930010")
        If optCPNEMA1.Checked Then frmMain.ThisUnitCodes.Add("930011")
        If optCPNEMA3R.Checked Then frmMain.ThisUnitCodes.Add("930012")
        If optFisenNEMA1.Checked Then frmMain.ThisUnitCodes.Add("930013")
        If optFisen3R.Checked Then frmMain.ThisUnitCodes.Add("930014")

        'Handle the panel power
        If optFieldPanelPower.Checked Then frmMain.ThisUnitCodes.Add("930025")
        If optUnitPanelPower.Checked Then frmMain.ThisUnitCodes.Add("930026")
        If optFieldPanelPower.Checked Then frmMain.ThisUnitCodes.Add("930027")

        'Handle if controller or terminal strip
        If optCustController.Checked Then frmMain.ThisUnitCodes.Add("930035")
        If optTermStripOnly.Checked Then frmMain.ThisUnitCodes.Add("930036")




    End Sub

    Private Sub frmCPCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadAnalogSensors()
        Call loadBinaryDevices()
        Call loadAnalogDevices()
        Call loadBinarySensors()

    End Sub

    Private Sub loadAnalogSensors()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstASensorChoice.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCPCtrlSensors WHERE SensorType='Analog' ORDER BY Description"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstASensorChoice.Items.Add(rs.Fields("Description").Value)
            ASensorList.Add(rs.Fields("FIOPID").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub loadBinarySensors()

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstBSensorChoice.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCPCtrlSensors WHERE SensorType='Binary' ORDER BY Description"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstBSensorChoice.Items.Add(rs.Fields("Description").Value)
            BSensorList.Add(rs.Fields("FIOPID").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub loadAnalogDevices()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstADeviceChoice.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCPCtrlDevices WHERE SensorType='Analog' ORDER BY Description"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstADeviceChoice.Items.Add(rs.Fields("Description").Value)
            ADeviceList.Add(rs.Fields("FIOPID").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub loadBinaryDevices()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstBDeviceChoice.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblCPCtrlDevices WHERE SensorType='Binary' ORDER BY Description"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        Do While Not (rs.EOF)
            lstBDeviceChoice.Items.Add(rs.Fields("Description").Value)
            BDeviceList.Add(rs.Fields("FIOPID").Value)
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub

    Private Sub btnDoneConditions_Click(sender As Object, e As EventArgs) Handles btnDoneConditions.Click
        TabControl1.SelectTab("tpgASensors")
    End Sub

    Private Sub cmdAddASensor_Click(sender As Object, e As EventArgs) Handles cmdAddASensor.Click
        Dim NewRow As String()
        Dim dummy As MsgBoxResult

        If txtASensTag.Text = "" Then
            dummy = MsgBox("Tag must not be blank.", vbOKOnly, "Fusen Unit Generator")
            Exit Sub
        End If

        If txtASensName.Text = "" Then
            dummy = MsgBox("Name must not be blank.", vbOKOnly, "Fusen Unit Generator")
            Exit Sub
        End If

        NewRow = {txtASensTag.Text, txtASensName.Text, lstASensorChoice.SelectedItem, "Input", optASensorProvidedbyFisen.Checked, chkASensFieldInstalled.Checked}
        frmMain.dgvEndDevices.Rows.Add(NewRow)
        lstASensorName.Items.Add(txtASensName.Text)
        EndDeviceCodes.Add(ASensorList.Item(lstASensorChoice.SelectedIndex))
        txtASensName.Text = ""
        txtASensTag.Text = ""
        chkASensFieldInstalled.Checked = False
        lstASensorChoice.ClearSelected()


    End Sub

    Private Sub btnDoneASensors_Click(sender As Object, e As EventArgs) Handles btnDoneASensors.Click
        TabControl1.SelectTab("tpgBSensors")
    End Sub

    Private Sub btnDoneBSensors_Click(sender As Object, e As EventArgs) Handles btnDoneBSensors.Click
        TabControl1.SelectTab("tpgADevices")
    End Sub

    Private Sub btnDoneADevices_Click(sender As Object, e As EventArgs) Handles btnDoneADevices.Click
        TabControl1.SelectTab("tpgBDevices")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim i As Integer
        For i = 0 To EndDeviceCodes.Count - 1
            Debug.Print(EndDeviceCodes.Item(i))
        Next i
    End Sub
End Class