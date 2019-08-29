<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPCtrl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optTermStripOnly = New System.Windows.Forms.RadioButton()
        Me.optCustController = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optFisen3R = New System.Windows.Forms.RadioButton()
        Me.optCPNEMA3R = New System.Windows.Forms.RadioButton()
        Me.optFisenNEMA1 = New System.Windows.Forms.RadioButton()
        Me.optCPNEMA1 = New System.Windows.Forms.RadioButton()
        Me.optUseUnitPanel = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optNoPanelPower = New System.Windows.Forms.RadioButton()
        Me.optFieldPanelPower = New System.Windows.Forms.RadioButton()
        Me.optUnitPanelPower = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgASensors = New System.Windows.Forms.TabPage()
        Me.chkASensFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.txtASensName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtASensTag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAddASensor = New System.Windows.Forms.Button()
        Me.lstASensorName = New System.Windows.Forms.ListBox()
        Me.lstASensorChoice = New System.Windows.Forms.ListBox()
        Me.btnDoneASensors = New System.Windows.Forms.Button()
        Me.tpgBSensors = New System.Windows.Forms.TabPage()
        Me.chkBSensFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.txtBSensName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBSensTag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAddBSensor = New System.Windows.Forms.Button()
        Me.lstBSensorName = New System.Windows.Forms.ListBox()
        Me.lstBSensorChoice = New System.Windows.Forms.ListBox()
        Me.btnDoneBSensors = New System.Windows.Forms.Button()
        Me.tpgADevice = New System.Windows.Forms.TabPage()
        Me.btnDoneADevices = New System.Windows.Forms.Button()
        Me.tpgBDevice = New System.Windows.Forms.TabPage()
        Me.btnDoneBDevices = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkADeviceFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.txtADeviceName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtADeviceTag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdAddADevice = New System.Windows.Forms.Button()
        Me.lstADeviceName = New System.Windows.Forms.ListBox()
        Me.lstADeviceChoice = New System.Windows.Forms.ListBox()
        Me.chkBDeviceFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.txtBDeviceName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBDeviceTag = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdAddBDevice = New System.Windows.Forms.Button()
        Me.lstBDeviceName = New System.Windows.Forms.ListBox()
        Me.lstBDeviceChoice = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optASensorProvidedbyFisen = New System.Windows.Forms.RadioButton()
        Me.optASensorProvidedByJCI = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optBSensorProvidedByFisen = New System.Windows.Forms.RadioButton()
        Me.optBSensorProvidedByJCI = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optADeviceProvidedByFisen = New System.Windows.Forms.RadioButton()
        Me.optADeviceProvidedByJCI = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optBDeviceProvidedByFisen = New System.Windows.Forms.RadioButton()
        Me.optBDeviceProvidedByJCI = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgASensors.SuspendLayout()
        Me.tpgBSensors.SuspendLayout()
        Me.tpgADevice.SuspendLayout()
        Me.tpgBDevice.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgASensors)
        Me.TabControl1.Controls.Add(Me.tpgBSensors)
        Me.TabControl1.Controls.Add(Me.tpgADevice)
        Me.TabControl1.Controls.Add(Me.tpgBDevice)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 331)
        Me.TabControl1.TabIndex = 3
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.GroupBox4)
        Me.tpgConditions.Controls.Add(Me.GroupBox3)
        Me.tpgConditions.Controls.Add(Me.GroupBox2)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(599, 305)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optTermStripOnly)
        Me.GroupBox4.Controls.Add(Me.optCustController)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 111)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(132, 70)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controller"
        '
        'optTermStripOnly
        '
        Me.optTermStripOnly.AutoSize = True
        Me.optTermStripOnly.Location = New System.Drawing.Point(6, 42)
        Me.optTermStripOnly.Name = "optTermStripOnly"
        Me.optTermStripOnly.Size = New System.Drawing.Size(116, 17)
        Me.optTermStripOnly.TabIndex = 26
        Me.optTermStripOnly.Text = "Wired to Term Strip"
        Me.optTermStripOnly.UseVisualStyleBackColor = True
        '
        'optCustController
        '
        Me.optCustController.AutoSize = True
        Me.optCustController.Checked = True
        Me.optCustController.Location = New System.Drawing.Point(6, 19)
        Me.optCustController.Name = "optCustController"
        Me.optCustController.Size = New System.Drawing.Size(114, 17)
        Me.optCustController.TabIndex = 25
        Me.optCustController.TabStop = True
        Me.optCustController.Text = "Customer Provided"
        Me.optCustController.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optFisen3R)
        Me.GroupBox3.Controls.Add(Me.optCPNEMA3R)
        Me.GroupBox3.Controls.Add(Me.optFisenNEMA1)
        Me.GroupBox3.Controls.Add(Me.optCPNEMA1)
        Me.GroupBox3.Controls.Add(Me.optUseUnitPanel)
        Me.GroupBox3.Location = New System.Drawing.Point(144, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 175)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enclosure"
        '
        'optFisen3R
        '
        Me.optFisen3R.AutoSize = True
        Me.optFisen3R.Location = New System.Drawing.Point(6, 111)
        Me.optFisen3R.Name = "optFisen3R"
        Me.optFisen3R.Size = New System.Drawing.Size(146, 17)
        Me.optFisen3R.TabIndex = 29
        Me.optFisen3R.Text = "Fisen Provided NEMA 3R"
        Me.optFisen3R.UseVisualStyleBackColor = True
        '
        'optCPNEMA3R
        '
        Me.optCPNEMA3R.AutoSize = True
        Me.optCPNEMA3R.Location = New System.Drawing.Point(6, 65)
        Me.optCPNEMA3R.Name = "optCPNEMA3R"
        Me.optCPNEMA3R.Size = New System.Drawing.Size(165, 17)
        Me.optCPNEMA3R.TabIndex = 27
        Me.optCPNEMA3R.Text = "Customer Provided NEMA 3R"
        Me.optCPNEMA3R.UseVisualStyleBackColor = True
        '
        'optFisenNEMA1
        '
        Me.optFisenNEMA1.AutoSize = True
        Me.optFisenNEMA1.Location = New System.Drawing.Point(6, 88)
        Me.optFisenNEMA1.Name = "optFisenNEMA1"
        Me.optFisenNEMA1.Size = New System.Drawing.Size(138, 17)
        Me.optFisenNEMA1.TabIndex = 28
        Me.optFisenNEMA1.Text = "Fisen Provided NEMA 1"
        Me.optFisenNEMA1.UseVisualStyleBackColor = True
        '
        'optCPNEMA1
        '
        Me.optCPNEMA1.AutoSize = True
        Me.optCPNEMA1.Location = New System.Drawing.Point(6, 42)
        Me.optCPNEMA1.Name = "optCPNEMA1"
        Me.optCPNEMA1.Size = New System.Drawing.Size(157, 17)
        Me.optCPNEMA1.TabIndex = 26
        Me.optCPNEMA1.Text = "Customer Provided NEMA 1"
        Me.optCPNEMA1.UseVisualStyleBackColor = True
        '
        'optUseUnitPanel
        '
        Me.optUseUnitPanel.AutoSize = True
        Me.optUseUnitPanel.Checked = True
        Me.optUseUnitPanel.Location = New System.Drawing.Point(6, 19)
        Me.optUseUnitPanel.Name = "optUseUnitPanel"
        Me.optUseUnitPanel.Size = New System.Drawing.Size(96, 17)
        Me.optUseUnitPanel.TabIndex = 25
        Me.optUseUnitPanel.TabStop = True
        Me.optUseUnitPanel.Text = "Use Unit Panel"
        Me.optUseUnitPanel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optNoPanelPower)
        Me.GroupBox2.Controls.Add(Me.optFieldPanelPower)
        Me.GroupBox2.Controls.Add(Me.optUnitPanelPower)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 99)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control Power"
        '
        'optNoPanelPower
        '
        Me.optNoPanelPower.AutoSize = True
        Me.optNoPanelPower.Location = New System.Drawing.Point(6, 65)
        Me.optNoPanelPower.Name = "optNoPanelPower"
        Me.optNoPanelPower.Size = New System.Drawing.Size(118, 17)
        Me.optNoPanelPower.TabIndex = 27
        Me.optNoPanelPower.Text = "No Power Required"
        Me.optNoPanelPower.UseVisualStyleBackColor = True
        '
        'optFieldPanelPower
        '
        Me.optFieldPanelPower.AutoSize = True
        Me.optFieldPanelPower.Location = New System.Drawing.Point(6, 42)
        Me.optFieldPanelPower.Name = "optFieldPanelPower"
        Me.optFieldPanelPower.Size = New System.Drawing.Size(122, 17)
        Me.optFieldPanelPower.TabIndex = 26
        Me.optFieldPanelPower.Text = "Panel Field Powered"
        Me.optFieldPanelPower.UseVisualStyleBackColor = True
        '
        'optUnitPanelPower
        '
        Me.optUnitPanelPower.AutoSize = True
        Me.optUnitPanelPower.Checked = True
        Me.optUnitPanelPower.Location = New System.Drawing.Point(6, 19)
        Me.optUnitPanelPower.Name = "optUnitPanelPower"
        Me.optUnitPanelPower.Size = New System.Drawing.Size(119, 17)
        Me.optUnitPanelPower.TabIndex = 25
        Me.optUnitPanelPower.TabStop = True
        Me.optUnitPanelPower.Text = "Panel Unit Powered"
        Me.optUnitPanelPower.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(538, 271)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgASensors
        '
        Me.tpgASensors.Controls.Add(Me.GroupBox1)
        Me.tpgASensors.Controls.Add(Me.chkASensFieldInstalled)
        Me.tpgASensors.Controls.Add(Me.txtASensName)
        Me.tpgASensors.Controls.Add(Me.Label2)
        Me.tpgASensors.Controls.Add(Me.txtASensTag)
        Me.tpgASensors.Controls.Add(Me.Label1)
        Me.tpgASensors.Controls.Add(Me.cmdAddASensor)
        Me.tpgASensors.Controls.Add(Me.lstASensorName)
        Me.tpgASensors.Controls.Add(Me.lstASensorChoice)
        Me.tpgASensors.Controls.Add(Me.btnDoneASensors)
        Me.tpgASensors.Location = New System.Drawing.Point(4, 22)
        Me.tpgASensors.Name = "tpgASensors"
        Me.tpgASensors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgASensors.Size = New System.Drawing.Size(599, 305)
        Me.tpgASensors.TabIndex = 1
        Me.tpgASensors.Text = "Analog Sensors"
        Me.tpgASensors.UseVisualStyleBackColor = True
        '
        'chkASensFieldInstalled
        '
        Me.chkASensFieldInstalled.AutoSize = True
        Me.chkASensFieldInstalled.Location = New System.Drawing.Point(39, 137)
        Me.chkASensFieldInstalled.Name = "chkASensFieldInstalled"
        Me.chkASensFieldInstalled.Size = New System.Drawing.Size(90, 17)
        Me.chkASensFieldInstalled.TabIndex = 32
        Me.chkASensFieldInstalled.Text = "Field Installed"
        Me.chkASensFieldInstalled.UseVisualStyleBackColor = True
        '
        'txtASensName
        '
        Me.txtASensName.Location = New System.Drawing.Point(193, 107)
        Me.txtASensName.Name = "txtASensName"
        Me.txtASensName.Size = New System.Drawing.Size(265, 20)
        Me.txtASensName.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Name"
        '
        'txtASensTag
        '
        Me.txtASensTag.Location = New System.Drawing.Point(39, 107)
        Me.txtASensTag.Name = "txtASensTag"
        Me.txtASensTag.Size = New System.Drawing.Size(100, 20)
        Me.txtASensTag.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tag"
        '
        'cmdAddASensor
        '
        Me.cmdAddASensor.Location = New System.Drawing.Point(538, 130)
        Me.cmdAddASensor.Name = "cmdAddASensor"
        Me.cmdAddASensor.Size = New System.Drawing.Size(55, 28)
        Me.cmdAddASensor.TabIndex = 27
        Me.cmdAddASensor.Text = "Add"
        Me.cmdAddASensor.UseVisualStyleBackColor = True
        '
        'lstASensorName
        '
        Me.lstASensorName.FormattingEnabled = True
        Me.lstASensorName.Location = New System.Drawing.Point(6, 217)
        Me.lstASensorName.Name = "lstASensorName"
        Me.lstASensorName.Size = New System.Drawing.Size(526, 82)
        Me.lstASensorName.TabIndex = 26
        '
        'lstASensorChoice
        '
        Me.lstASensorChoice.FormattingEnabled = True
        Me.lstASensorChoice.Location = New System.Drawing.Point(6, 6)
        Me.lstASensorChoice.Name = "lstASensorChoice"
        Me.lstASensorChoice.Size = New System.Drawing.Size(526, 95)
        Me.lstASensorChoice.TabIndex = 25
        '
        'btnDoneASensors
        '
        Me.btnDoneASensors.Location = New System.Drawing.Point(538, 271)
        Me.btnDoneASensors.Name = "btnDoneASensors"
        Me.btnDoneASensors.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneASensors.TabIndex = 24
        Me.btnDoneASensors.Text = ">"
        Me.btnDoneASensors.UseVisualStyleBackColor = True
        '
        'tpgBSensors
        '
        Me.tpgBSensors.Controls.Add(Me.GroupBox5)
        Me.tpgBSensors.Controls.Add(Me.chkBSensFieldInstalled)
        Me.tpgBSensors.Controls.Add(Me.txtBSensName)
        Me.tpgBSensors.Controls.Add(Me.Label3)
        Me.tpgBSensors.Controls.Add(Me.txtBSensTag)
        Me.tpgBSensors.Controls.Add(Me.Label4)
        Me.tpgBSensors.Controls.Add(Me.cmdAddBSensor)
        Me.tpgBSensors.Controls.Add(Me.lstBSensorName)
        Me.tpgBSensors.Controls.Add(Me.lstBSensorChoice)
        Me.tpgBSensors.Controls.Add(Me.btnDoneBSensors)
        Me.tpgBSensors.Location = New System.Drawing.Point(4, 22)
        Me.tpgBSensors.Name = "tpgBSensors"
        Me.tpgBSensors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgBSensors.Size = New System.Drawing.Size(599, 305)
        Me.tpgBSensors.TabIndex = 2
        Me.tpgBSensors.Text = "Binary Sensors"
        Me.tpgBSensors.UseVisualStyleBackColor = True
        '
        'chkBSensFieldInstalled
        '
        Me.chkBSensFieldInstalled.AutoSize = True
        Me.chkBSensFieldInstalled.Location = New System.Drawing.Point(39, 137)
        Me.chkBSensFieldInstalled.Name = "chkBSensFieldInstalled"
        Me.chkBSensFieldInstalled.Size = New System.Drawing.Size(90, 17)
        Me.chkBSensFieldInstalled.TabIndex = 40
        Me.chkBSensFieldInstalled.Text = "Field Installed"
        Me.chkBSensFieldInstalled.UseVisualStyleBackColor = True
        '
        'txtBSensName
        '
        Me.txtBSensName.Location = New System.Drawing.Point(193, 107)
        Me.txtBSensName.Name = "txtBSensName"
        Me.txtBSensName.Size = New System.Drawing.Size(265, 20)
        Me.txtBSensName.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Name"
        '
        'txtBSensTag
        '
        Me.txtBSensTag.Location = New System.Drawing.Point(39, 107)
        Me.txtBSensTag.Name = "txtBSensTag"
        Me.txtBSensTag.Size = New System.Drawing.Size(100, 20)
        Me.txtBSensTag.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tag"
        '
        'cmdAddBSensor
        '
        Me.cmdAddBSensor.Location = New System.Drawing.Point(538, 130)
        Me.cmdAddBSensor.Name = "cmdAddBSensor"
        Me.cmdAddBSensor.Size = New System.Drawing.Size(55, 28)
        Me.cmdAddBSensor.TabIndex = 35
        Me.cmdAddBSensor.Text = "Add"
        Me.cmdAddBSensor.UseVisualStyleBackColor = True
        '
        'lstBSensorName
        '
        Me.lstBSensorName.FormattingEnabled = True
        Me.lstBSensorName.Location = New System.Drawing.Point(6, 217)
        Me.lstBSensorName.Name = "lstBSensorName"
        Me.lstBSensorName.Size = New System.Drawing.Size(526, 82)
        Me.lstBSensorName.TabIndex = 34
        '
        'lstBSensorChoice
        '
        Me.lstBSensorChoice.FormattingEnabled = True
        Me.lstBSensorChoice.Location = New System.Drawing.Point(6, 6)
        Me.lstBSensorChoice.Name = "lstBSensorChoice"
        Me.lstBSensorChoice.Size = New System.Drawing.Size(526, 95)
        Me.lstBSensorChoice.TabIndex = 33
        '
        'btnDoneBSensors
        '
        Me.btnDoneBSensors.Location = New System.Drawing.Point(538, 271)
        Me.btnDoneBSensors.Name = "btnDoneBSensors"
        Me.btnDoneBSensors.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneBSensors.TabIndex = 25
        Me.btnDoneBSensors.Text = ">"
        Me.btnDoneBSensors.UseVisualStyleBackColor = True
        '
        'tpgADevice
        '
        Me.tpgADevice.Controls.Add(Me.GroupBox6)
        Me.tpgADevice.Controls.Add(Me.chkADeviceFieldInstalled)
        Me.tpgADevice.Controls.Add(Me.txtADeviceName)
        Me.tpgADevice.Controls.Add(Me.Label5)
        Me.tpgADevice.Controls.Add(Me.txtADeviceTag)
        Me.tpgADevice.Controls.Add(Me.Label6)
        Me.tpgADevice.Controls.Add(Me.cmdAddADevice)
        Me.tpgADevice.Controls.Add(Me.lstADeviceName)
        Me.tpgADevice.Controls.Add(Me.lstADeviceChoice)
        Me.tpgADevice.Controls.Add(Me.btnDoneADevices)
        Me.tpgADevice.Location = New System.Drawing.Point(4, 22)
        Me.tpgADevice.Name = "tpgADevice"
        Me.tpgADevice.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgADevice.Size = New System.Drawing.Size(599, 305)
        Me.tpgADevice.TabIndex = 6
        Me.tpgADevice.Text = "Analog Devices"
        Me.tpgADevice.UseVisualStyleBackColor = True
        '
        'btnDoneADevices
        '
        Me.btnDoneADevices.Location = New System.Drawing.Point(538, 271)
        Me.btnDoneADevices.Name = "btnDoneADevices"
        Me.btnDoneADevices.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneADevices.TabIndex = 26
        Me.btnDoneADevices.Text = ">"
        Me.btnDoneADevices.UseVisualStyleBackColor = True
        '
        'tpgBDevice
        '
        Me.tpgBDevice.Controls.Add(Me.GroupBox7)
        Me.tpgBDevice.Controls.Add(Me.chkBDeviceFieldInstalled)
        Me.tpgBDevice.Controls.Add(Me.txtBDeviceName)
        Me.tpgBDevice.Controls.Add(Me.Label7)
        Me.tpgBDevice.Controls.Add(Me.txtBDeviceTag)
        Me.tpgBDevice.Controls.Add(Me.Label8)
        Me.tpgBDevice.Controls.Add(Me.cmdAddBDevice)
        Me.tpgBDevice.Controls.Add(Me.lstBDeviceName)
        Me.tpgBDevice.Controls.Add(Me.lstBDeviceChoice)
        Me.tpgBDevice.Controls.Add(Me.btnDoneBDevices)
        Me.tpgBDevice.Location = New System.Drawing.Point(4, 22)
        Me.tpgBDevice.Name = "tpgBDevice"
        Me.tpgBDevice.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgBDevice.Size = New System.Drawing.Size(599, 305)
        Me.tpgBDevice.TabIndex = 5
        Me.tpgBDevice.Text = "Binary Devices"
        Me.tpgBDevice.UseVisualStyleBackColor = True
        '
        'btnDoneBDevices
        '
        Me.btnDoneBDevices.Location = New System.Drawing.Point(538, 271)
        Me.btnDoneBDevices.Name = "btnDoneBDevices"
        Me.btnDoneBDevices.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneBDevices.TabIndex = 26
        Me.btnDoneBDevices.Text = ">"
        Me.btnDoneBDevices.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(599, 305)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDonePerformance.Location = New System.Drawing.Point(540, 274)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(599, 305)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(109, 339)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(5, 339)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkADeviceFieldInstalled
        '
        Me.chkADeviceFieldInstalled.AutoSize = True
        Me.chkADeviceFieldInstalled.Location = New System.Drawing.Point(39, 137)
        Me.chkADeviceFieldInstalled.Name = "chkADeviceFieldInstalled"
        Me.chkADeviceFieldInstalled.Size = New System.Drawing.Size(90, 17)
        Me.chkADeviceFieldInstalled.TabIndex = 40
        Me.chkADeviceFieldInstalled.Text = "Field Installed"
        Me.chkADeviceFieldInstalled.UseVisualStyleBackColor = True
        '
        'txtADeviceName
        '
        Me.txtADeviceName.Location = New System.Drawing.Point(193, 107)
        Me.txtADeviceName.Name = "txtADeviceName"
        Me.txtADeviceName.Size = New System.Drawing.Size(265, 20)
        Me.txtADeviceName.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Name"
        '
        'txtADeviceTag
        '
        Me.txtADeviceTag.Location = New System.Drawing.Point(39, 107)
        Me.txtADeviceTag.Name = "txtADeviceTag"
        Me.txtADeviceTag.Size = New System.Drawing.Size(100, 20)
        Me.txtADeviceTag.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tag"
        '
        'cmdAddADevice
        '
        Me.cmdAddADevice.Location = New System.Drawing.Point(538, 130)
        Me.cmdAddADevice.Name = "cmdAddADevice"
        Me.cmdAddADevice.Size = New System.Drawing.Size(55, 28)
        Me.cmdAddADevice.TabIndex = 35
        Me.cmdAddADevice.Text = "Add"
        Me.cmdAddADevice.UseVisualStyleBackColor = True
        '
        'lstADeviceName
        '
        Me.lstADeviceName.FormattingEnabled = True
        Me.lstADeviceName.Location = New System.Drawing.Point(6, 217)
        Me.lstADeviceName.Name = "lstADeviceName"
        Me.lstADeviceName.Size = New System.Drawing.Size(526, 82)
        Me.lstADeviceName.TabIndex = 34
        '
        'lstADeviceChoice
        '
        Me.lstADeviceChoice.FormattingEnabled = True
        Me.lstADeviceChoice.Location = New System.Drawing.Point(6, 6)
        Me.lstADeviceChoice.Name = "lstADeviceChoice"
        Me.lstADeviceChoice.Size = New System.Drawing.Size(526, 95)
        Me.lstADeviceChoice.TabIndex = 33
        '
        'chkBDeviceFieldInstalled
        '
        Me.chkBDeviceFieldInstalled.AutoSize = True
        Me.chkBDeviceFieldInstalled.Location = New System.Drawing.Point(39, 137)
        Me.chkBDeviceFieldInstalled.Name = "chkBDeviceFieldInstalled"
        Me.chkBDeviceFieldInstalled.Size = New System.Drawing.Size(90, 17)
        Me.chkBDeviceFieldInstalled.TabIndex = 40
        Me.chkBDeviceFieldInstalled.Text = "Field Installed"
        Me.chkBDeviceFieldInstalled.UseVisualStyleBackColor = True
        '
        'txtBDeviceName
        '
        Me.txtBDeviceName.Location = New System.Drawing.Point(193, 107)
        Me.txtBDeviceName.Name = "txtBDeviceName"
        Me.txtBDeviceName.Size = New System.Drawing.Size(265, 20)
        Me.txtBDeviceName.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Name"
        '
        'txtBDeviceTag
        '
        Me.txtBDeviceTag.Location = New System.Drawing.Point(39, 107)
        Me.txtBDeviceTag.Name = "txtBDeviceTag"
        Me.txtBDeviceTag.Size = New System.Drawing.Size(100, 20)
        Me.txtBDeviceTag.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tag"
        '
        'cmdAddBDevice
        '
        Me.cmdAddBDevice.Location = New System.Drawing.Point(538, 130)
        Me.cmdAddBDevice.Name = "cmdAddBDevice"
        Me.cmdAddBDevice.Size = New System.Drawing.Size(55, 28)
        Me.cmdAddBDevice.TabIndex = 35
        Me.cmdAddBDevice.Text = "Add"
        Me.cmdAddBDevice.UseVisualStyleBackColor = True
        '
        'lstBDeviceName
        '
        Me.lstBDeviceName.FormattingEnabled = True
        Me.lstBDeviceName.Location = New System.Drawing.Point(6, 217)
        Me.lstBDeviceName.Name = "lstBDeviceName"
        Me.lstBDeviceName.Size = New System.Drawing.Size(526, 82)
        Me.lstBDeviceName.TabIndex = 34
        '
        'lstBDeviceChoice
        '
        Me.lstBDeviceChoice.FormattingEnabled = True
        Me.lstBDeviceChoice.Location = New System.Drawing.Point(6, 6)
        Me.lstBDeviceChoice.Name = "lstBDeviceChoice"
        Me.lstBDeviceChoice.Size = New System.Drawing.Size(526, 95)
        Me.lstBDeviceChoice.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optASensorProvidedbyFisen)
        Me.GroupBox1.Controls.Add(Me.optASensorProvidedByJCI)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 43)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provided by"
        '
        'optASensorProvidedbyFisen
        '
        Me.optASensorProvidedbyFisen.AutoSize = True
        Me.optASensorProvidedbyFisen.Checked = True
        Me.optASensorProvidedbyFisen.Location = New System.Drawing.Point(52, 19)
        Me.optASensorProvidedbyFisen.Name = "optASensorProvidedbyFisen"
        Me.optASensorProvidedbyFisen.Size = New System.Drawing.Size(50, 17)
        Me.optASensorProvidedbyFisen.TabIndex = 1
        Me.optASensorProvidedbyFisen.TabStop = True
        Me.optASensorProvidedbyFisen.Text = "Fisen"
        Me.optASensorProvidedbyFisen.UseVisualStyleBackColor = True
        '
        'optASensorProvidedByJCI
        '
        Me.optASensorProvidedByJCI.AutoSize = True
        Me.optASensorProvidedByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optASensorProvidedByJCI.Name = "optASensorProvidedByJCI"
        Me.optASensorProvidedByJCI.Size = New System.Drawing.Size(40, 17)
        Me.optASensorProvidedByJCI.TabIndex = 0
        Me.optASensorProvidedByJCI.Text = "JCI"
        Me.optASensorProvidedByJCI.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optBSensorProvidedByFisen)
        Me.GroupBox5.Controls.Add(Me.optBSensorProvidedByJCI)
        Me.GroupBox5.Location = New System.Drawing.Point(39, 168)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(100, 43)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Provided by"
        '
        'optBSensorProvidedByFisen
        '
        Me.optBSensorProvidedByFisen.AutoSize = True
        Me.optBSensorProvidedByFisen.Checked = True
        Me.optBSensorProvidedByFisen.Location = New System.Drawing.Point(52, 19)
        Me.optBSensorProvidedByFisen.Name = "optBSensorProvidedByFisen"
        Me.optBSensorProvidedByFisen.Size = New System.Drawing.Size(50, 17)
        Me.optBSensorProvidedByFisen.TabIndex = 1
        Me.optBSensorProvidedByFisen.TabStop = True
        Me.optBSensorProvidedByFisen.Text = "Fisen"
        Me.optBSensorProvidedByFisen.UseVisualStyleBackColor = True
        '
        'optBSensorProvidedByJCI
        '
        Me.optBSensorProvidedByJCI.AutoSize = True
        Me.optBSensorProvidedByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optBSensorProvidedByJCI.Name = "optBSensorProvidedByJCI"
        Me.optBSensorProvidedByJCI.Size = New System.Drawing.Size(40, 17)
        Me.optBSensorProvidedByJCI.TabIndex = 0
        Me.optBSensorProvidedByJCI.Text = "JCI"
        Me.optBSensorProvidedByJCI.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optADeviceProvidedByFisen)
        Me.GroupBox6.Controls.Add(Me.optADeviceProvidedByJCI)
        Me.GroupBox6.Location = New System.Drawing.Point(39, 160)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(100, 43)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Provided by"
        '
        'optADeviceProvidedByFisen
        '
        Me.optADeviceProvidedByFisen.AutoSize = True
        Me.optADeviceProvidedByFisen.Checked = True
        Me.optADeviceProvidedByFisen.Location = New System.Drawing.Point(52, 19)
        Me.optADeviceProvidedByFisen.Name = "optADeviceProvidedByFisen"
        Me.optADeviceProvidedByFisen.Size = New System.Drawing.Size(50, 17)
        Me.optADeviceProvidedByFisen.TabIndex = 1
        Me.optADeviceProvidedByFisen.TabStop = True
        Me.optADeviceProvidedByFisen.Text = "Fisen"
        Me.optADeviceProvidedByFisen.UseVisualStyleBackColor = True
        '
        'optADeviceProvidedByJCI
        '
        Me.optADeviceProvidedByJCI.AutoSize = True
        Me.optADeviceProvidedByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optADeviceProvidedByJCI.Name = "optADeviceProvidedByJCI"
        Me.optADeviceProvidedByJCI.Size = New System.Drawing.Size(40, 17)
        Me.optADeviceProvidedByJCI.TabIndex = 0
        Me.optADeviceProvidedByJCI.Text = "JCI"
        Me.optADeviceProvidedByJCI.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optBDeviceProvidedByFisen)
        Me.GroupBox7.Controls.Add(Me.optBDeviceProvidedByJCI)
        Me.GroupBox7.Location = New System.Drawing.Point(39, 160)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(100, 43)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Provided by"
        '
        'optBDeviceProvidedByFisen
        '
        Me.optBDeviceProvidedByFisen.AutoSize = True
        Me.optBDeviceProvidedByFisen.Checked = True
        Me.optBDeviceProvidedByFisen.Location = New System.Drawing.Point(52, 19)
        Me.optBDeviceProvidedByFisen.Name = "optBDeviceProvidedByFisen"
        Me.optBDeviceProvidedByFisen.Size = New System.Drawing.Size(50, 17)
        Me.optBDeviceProvidedByFisen.TabIndex = 1
        Me.optBDeviceProvidedByFisen.TabStop = True
        Me.optBDeviceProvidedByFisen.Text = "Fisen"
        Me.optBDeviceProvidedByFisen.UseVisualStyleBackColor = True
        '
        'optBDeviceProvidedByJCI
        '
        Me.optBDeviceProvidedByJCI.AutoSize = True
        Me.optBDeviceProvidedByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optBDeviceProvidedByJCI.Name = "optBDeviceProvidedByJCI"
        Me.optBDeviceProvidedByJCI.Size = New System.Drawing.Size(40, 17)
        Me.optBDeviceProvidedByJCI.TabIndex = 0
        Me.optBDeviceProvidedByJCI.Text = "JCI"
        Me.optBDeviceProvidedByJCI.UseVisualStyleBackColor = True
        '
        'frmCPCtrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCPCtrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Provided Controls"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgASensors.ResumeLayout(False)
        Me.tpgASensors.PerformLayout()
        Me.tpgBSensors.ResumeLayout(False)
        Me.tpgBSensors.PerformLayout()
        Me.tpgADevice.ResumeLayout(False)
        Me.tpgADevice.PerformLayout()
        Me.tpgBDevice.ResumeLayout(False)
        Me.tpgBDevice.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgASensors As TabPage
    Friend WithEvents btnDoneASensors As Button
    Friend WithEvents tpgBSensors As TabPage
    Friend WithEvents btnDoneBSensors As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optTermStripOnly As RadioButton
    Friend WithEvents optCustController As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optFisen3R As RadioButton
    Friend WithEvents optCPNEMA3R As RadioButton
    Friend WithEvents optFisenNEMA1 As RadioButton
    Friend WithEvents optCPNEMA1 As RadioButton
    Friend WithEvents optUseUnitPanel As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optFieldPanelPower As RadioButton
    Friend WithEvents optUnitPanelPower As RadioButton
    Friend WithEvents optNoPanelPower As RadioButton
    Friend WithEvents cmdAddASensor As Button
    Friend WithEvents lstASensorName As ListBox
    Friend WithEvents lstASensorChoice As ListBox
    Friend WithEvents txtASensName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtASensTag As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkASensFieldInstalled As CheckBox
    Friend WithEvents chkBSensFieldInstalled As CheckBox
    Friend WithEvents txtBSensName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBSensTag As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdAddBSensor As Button
    Friend WithEvents lstBSensorName As ListBox
    Friend WithEvents lstBSensorChoice As ListBox
    Friend WithEvents tpgADevice As TabPage
    Friend WithEvents tpgBDevice As TabPage
    Friend WithEvents btnDoneADevices As Button
    Friend WithEvents btnDoneBDevices As Button
    Friend WithEvents chkADeviceFieldInstalled As CheckBox
    Friend WithEvents txtADeviceName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtADeviceTag As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdAddADevice As Button
    Friend WithEvents lstADeviceName As ListBox
    Friend WithEvents lstADeviceChoice As ListBox
    Friend WithEvents chkBDeviceFieldInstalled As CheckBox
    Friend WithEvents txtBDeviceName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBDeviceTag As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdAddBDevice As Button
    Friend WithEvents lstBDeviceName As ListBox
    Friend WithEvents lstBDeviceChoice As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optASensorProvidedbyFisen As RadioButton
    Friend WithEvents optASensorProvidedByJCI As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optBSensorProvidedByFisen As RadioButton
    Friend WithEvents optBSensorProvidedByJCI As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optADeviceProvidedByFisen As RadioButton
    Friend WithEvents optADeviceProvidedByJCI As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents optBDeviceProvidedByFisen As RadioButton
    Friend WithEvents optBDeviceProvidedByJCI As RadioButton
End Class
