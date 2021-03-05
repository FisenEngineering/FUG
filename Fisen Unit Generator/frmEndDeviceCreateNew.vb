Public Class frmEndDeviceCreateNew
    Private pCancelled As Boolean
    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property

    Private Sub frmEndDeviceCreateNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateClassWithSensors()
        cmbClass.Text = "Unselected"

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub PopulateClassWithEndDevice()
        cmbClass.Items.Clear()
        cmbClass.Items.Add("Relay - Control - Coil")
        cmbClass.Items.Add("Valve - Hydronic")
        cmbClass.Items.Add("Controller")
        cmbClass.Items.Add("UV Lights")
        cmbClass.Items.Add("Actuator - Modulating")
        cmbClass.Items.Add("Bipolar Ionization Emitter")
        cmbClass.Items.Add("Unselected")
        cmbClass.Text = "Unselected"
    End Sub
    Private Sub PopulateClassWithSensors()
        cmbClass.Items.Clear()
        cmbClass.Items.Add("Control Relay Contact")
        cmbClass.Items.Add("Current Transducer")
        cmbClass.Items.Add("Pressure Transducer")
        cmbClass.Items.Add("Radiometer")
        cmbClass.Items.Add("Switch - Limit")
        cmbClass.Items.Add("Switch - Level")
        cmbClass.Items.Add("Switch - Manual - Maintained")
        cmbClass.Items.Add("Thermistor - Averaging")
        cmbClass.Items.Add("Switch - Limit - Tip Style")
        cmbClass.Items.Add("Unselected")
        cmbClass.Text = "Unselected"
    End Sub

    Private Sub optEndDeviceType_CheckedChanged(sender As Object, e As EventArgs) Handles optEndDeviceType.CheckedChanged
        If optEndDeviceType.Checked Then Call PopulateClassWithEndDevice()
    End Sub

    Private Sub optSensorTypr_CheckedChanged(sender As Object, e As EventArgs) Handles optSensorTypr.CheckedChanged
        If optSensorTypr.Checked Then Call PopulateClassWithSensors()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If PrevalidateData() Then Call WriteTheData()
        Me.Hide()

    End Sub

    Private Function PrevalidateData() As Boolean
        Dim GTG As Boolean
        Dim lName, lClass, lTag, lPath, lFileName As String
        Dim dummy As MsgBoxResult

        GTG = True
        lName = txtName.Text
        lClass = cmbClass.Text
        lTag = txtTag.Text
        lPath = txtPath.Text
        lFileName = txtFileName.Text

        If lName = "" Then GTG = False
        If lClass = "Unselected" Then GTG = False
        If lTag = "" Then GTG = False
        If lPath = "" Then GTG = False
        If lFileName = "" Then GTG = False

        If Not (GTG) Then
            dummy = MsgBox("One or more entries are not ready for entry.", vbOKOnly, "Fisen Unit Generator")
        End If

        Return GTG
    End Function

    Private Sub WriteTheData()
        Dim con As ADODB.Connection
        Dim dbProvider As String
        Dim MySQL As String

        Dim lName, lType, lClass, lTag, lPath, lFileName As String
        If optEndDeviceType.Checked Then lType = "End Device" Else lType = "Sensor"
        lName = txtName.Text
        lClass = cmbClass.Text
        lTag = txtTag.Text
        lPath = txtPath.Text
        lFileName = txtFileName.Text

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        MySQL = "INSERT INTO tblEndDevices (EDName, EDType, EDClass, EDTag, EDCutSheetPath, EDCutSheet) VALUES ('" & lName & "','" & lType & "','" & lClass & "','" & lTag & "','" & lPath & "','" & lFileName & "')"
        con.Execute(MySQL)
        con.Close()
        con = Nothing

    End Sub
End Class