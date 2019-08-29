<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHGRH
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRHCoilAPD = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudCircuitsofRH = New System.Windows.Forms.NumericUpDown()
        Me.txtEATDB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHGRHAFlow = New System.Windows.Forms.TextBox()
        Me.txtHGRHCap = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.optFieldStat = New System.Windows.Forms.RadioButton()
        Me.optFisenRASensor = New System.Windows.Forms.RadioButton()
        Me.optFisenZoneSensor = New System.Windows.Forms.RadioButton()
        Me.optFisenRAStat = New System.Windows.Forms.RadioButton()
        Me.optFisenZoneHum = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkModbusPoints = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optMODBUSRH = New System.Windows.Forms.RadioButton()
        Me.optHumPriority = New System.Windows.Forms.RadioButton()
        Me.chkModulatingCtrl = New System.Windows.Forms.CheckBox()
        Me.opt100OARH = New System.Windows.Forms.RadioButton()
        Me.optRHNetworkOnly = New System.Windows.Forms.RadioButton()
        Me.optRHGBAS = New System.Windows.Forms.RadioButton()
        Me.optTempPriority = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optMODBUSDH = New System.Windows.Forms.RadioButton()
        Me.chkSensorControl = New System.Windows.Forms.CheckBox()
        Me.optDHThermostat = New System.Windows.Forms.RadioButton()
        Me.optDHGBASEnab = New System.Windows.Forms.RadioButton()
        Me.optDHCompsByJCI = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.optParallelPiping = New System.Windows.Forms.RadioButton()
        Me.optSeriesPiping = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDehumCap = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.chkECoat = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOptions.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(88, 233)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(10, 233)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 217)
        Me.TabControl1.TabIndex = 7
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.txtRHCoilAPD)
        Me.tpgConditions.Controls.Add(Me.Label15)
        Me.tpgConditions.Controls.Add(Me.Label14)
        Me.tpgConditions.Controls.Add(Me.Label12)
        Me.tpgConditions.Controls.Add(Me.Label13)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.nudCircuitsofRH)
        Me.tpgConditions.Controls.Add(Me.txtEATDB)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.txtHGRHAFlow)
        Me.tpgConditions.Controls.Add(Me.txtHGRHCap)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 191)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = """wc"
        '
        'txtRHCoilAPD
        '
        Me.txtRHCoilAPD.Location = New System.Drawing.Point(169, 115)
        Me.txtRHCoilAPD.Name = "txtRHCoilAPD"
        Me.txtRHCoilAPD.Size = New System.Drawing.Size(62, 20)
        Me.txtRHCoilAPD.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Reheat Coil Pressure Drop"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(237, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "CFM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(237, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "MBH"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(237, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "ºF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Circuits of Reheat"
        '
        'nudCircuitsofRH
        '
        Me.nudCircuitsofRH.Location = New System.Drawing.Point(169, 89)
        Me.nudCircuitsofRH.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCircuitsofRH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCircuitsofRH.Name = "nudCircuitsofRH"
        Me.nudCircuitsofRH.Size = New System.Drawing.Size(62, 20)
        Me.nudCircuitsofRH.TabIndex = 48
        Me.nudCircuitsofRH.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtEATDB
        '
        Me.txtEATDB.Location = New System.Drawing.Point(169, 63)
        Me.txtEATDB.Name = "txtEATDB"
        Me.txtEATDB.Size = New System.Drawing.Size(62, 20)
        Me.txtEATDB.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Entering DB Temp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Hot Gas Reheat Airflow"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Hot Gas Reheat Capacity (Max)"
        '
        'txtHGRHAFlow
        '
        Me.txtHGRHAFlow.Location = New System.Drawing.Point(169, 38)
        Me.txtHGRHAFlow.Name = "txtHGRHAFlow"
        Me.txtHGRHAFlow.Size = New System.Drawing.Size(62, 20)
        Me.txtHGRHAFlow.TabIndex = 43
        '
        'txtHGRHCap
        '
        Me.txtHGRHCap.Location = New System.Drawing.Point(169, 12)
        Me.txtHGRHCap.Name = "txtHGRHCap"
        Me.txtHGRHCap.Size = New System.Drawing.Size(62, 20)
        Me.txtHGRHCap.TabIndex = 42
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(387, 164)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkECoat)
        Me.tpgOptions.Controls.Add(Me.optFieldStat)
        Me.tpgOptions.Controls.Add(Me.optFisenRASensor)
        Me.tpgOptions.Controls.Add(Me.optFisenZoneSensor)
        Me.tpgOptions.Controls.Add(Me.optFisenRAStat)
        Me.tpgOptions.Controls.Add(Me.optFisenZoneHum)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(432, 191)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'optFieldStat
        '
        Me.optFieldStat.AutoSize = True
        Me.optFieldStat.Checked = True
        Me.optFieldStat.Location = New System.Drawing.Point(3, 82)
        Me.optFieldStat.Name = "optFieldStat"
        Me.optFieldStat.Size = New System.Drawing.Size(152, 17)
        Me.optFieldStat.TabIndex = 37
        Me.optFieldStat.TabStop = True
        Me.optFieldStat.Text = "Field Provided Stat/Sensor"
        Me.optFieldStat.UseVisualStyleBackColor = True
        '
        'optFisenRASensor
        '
        Me.optFisenRASensor.AutoSize = True
        Me.optFisenRASensor.Location = New System.Drawing.Point(3, 63)
        Me.optFisenRASensor.Name = "optFisenRASensor"
        Me.optFisenRASensor.Size = New System.Drawing.Size(258, 17)
        Me.optFisenRASensor.TabIndex = 36
        Me.optFisenRASensor.Text = "Fisen Supplied Field Installed RA Humidity Sensor"
        Me.optFisenRASensor.UseVisualStyleBackColor = True
        '
        'optFisenZoneSensor
        '
        Me.optFisenZoneSensor.AutoSize = True
        Me.optFisenZoneSensor.Location = New System.Drawing.Point(3, 44)
        Me.optFisenZoneSensor.Name = "optFisenZoneSensor"
        Me.optFisenZoneSensor.Size = New System.Drawing.Size(268, 17)
        Me.optFisenZoneSensor.TabIndex = 35
        Me.optFisenZoneSensor.Text = "Fisen Supplied Field Installed Zone Humidity Sensor"
        Me.optFisenZoneSensor.UseVisualStyleBackColor = True
        '
        'optFisenRAStat
        '
        Me.optFisenRAStat.AutoSize = True
        Me.optFisenRAStat.Location = New System.Drawing.Point(3, 23)
        Me.optFisenRAStat.Name = "optFisenRAStat"
        Me.optFisenRAStat.Size = New System.Drawing.Size(231, 17)
        Me.optFisenRAStat.TabIndex = 34
        Me.optFisenRAStat.Text = "Fisen Supplied Field Installed RA Humidistat"
        Me.optFisenRAStat.UseVisualStyleBackColor = True
        '
        'optFisenZoneHum
        '
        Me.optFisenZoneHum.AutoSize = True
        Me.optFisenZoneHum.Location = New System.Drawing.Point(3, 3)
        Me.optFisenZoneHum.Name = "optFisenZoneHum"
        Me.optFisenZoneHum.Size = New System.Drawing.Size(241, 17)
        Me.optFisenZoneHum.TabIndex = 33
        Me.optFisenZoneHum.Text = "Fisen Supplied Field Installed Zone Humidistat"
        Me.optFisenZoneHum.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(19, 122)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(5, 103)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(272, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch (Not provided if only mod)"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(386, 164)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkModbusPoints)
        Me.tpgControls.Controls.Add(Me.GroupBox3)
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 191)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkModbusPoints
        '
        Me.chkModbusPoints.AutoSize = True
        Me.chkModbusPoints.Location = New System.Drawing.Point(316, 83)
        Me.chkModbusPoints.Name = "chkModbusPoints"
        Me.chkModbusPoints.Size = New System.Drawing.Size(96, 17)
        Me.chkModbusPoints.TabIndex = 31
        Me.chkModbusPoints.Text = "Modbus Points"
        Me.chkModbusPoints.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optMODBUSRH)
        Me.GroupBox3.Controls.Add(Me.optHumPriority)
        Me.GroupBox3.Controls.Add(Me.chkModulatingCtrl)
        Me.GroupBox3.Controls.Add(Me.opt100OARH)
        Me.GroupBox3.Controls.Add(Me.optRHNetworkOnly)
        Me.GroupBox3.Controls.Add(Me.optRHGBAS)
        Me.GroupBox3.Controls.Add(Me.optTempPriority)
        Me.GroupBox3.Location = New System.Drawing.Point(149, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 181)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reheat Strategy"
        '
        'optMODBUSRH
        '
        Me.optMODBUSRH.AutoSize = True
        Me.optMODBUSRH.Location = New System.Drawing.Point(6, 117)
        Me.optMODBUSRH.Name = "optMODBUSRH"
        Me.optMODBUSRH.Size = New System.Drawing.Size(123, 17)
        Me.optMODBUSRH.TabIndex = 11
        Me.optMODBUSRH.Text = "MODBUS - Temp Pri"
        Me.optMODBUSRH.UseVisualStyleBackColor = True
        '
        'optHumPriority
        '
        Me.optHumPriority.AutoSize = True
        Me.optHumPriority.Location = New System.Drawing.Point(6, 38)
        Me.optHumPriority.Name = "optHumPriority"
        Me.optHumPriority.Size = New System.Drawing.Size(97, 17)
        Me.optHumPriority.TabIndex = 10
        Me.optHumPriority.Text = "TStat - Hum Pri"
        Me.optHumPriority.UseVisualStyleBackColor = True
        '
        'chkModulatingCtrl
        '
        Me.chkModulatingCtrl.AutoSize = True
        Me.chkModulatingCtrl.Location = New System.Drawing.Point(6, 141)
        Me.chkModulatingCtrl.Name = "chkModulatingCtrl"
        Me.chkModulatingCtrl.Size = New System.Drawing.Size(78, 17)
        Me.chkModulatingCtrl.TabIndex = 9
        Me.chkModulatingCtrl.Text = "Modulating"
        Me.chkModulatingCtrl.UseVisualStyleBackColor = True
        '
        'opt100OARH
        '
        Me.opt100OARH.AutoSize = True
        Me.opt100OARH.Enabled = False
        Me.opt100OARH.Location = New System.Drawing.Point(6, 95)
        Me.opt100OARH.Name = "opt100OARH"
        Me.opt100OARH.Size = New System.Drawing.Size(129, 17)
        Me.opt100OARH.TabIndex = 3
        Me.opt100OARH.Text = "100% Outdoor Air Unit"
        Me.opt100OARH.UseVisualStyleBackColor = True
        '
        'optRHNetworkOnly
        '
        Me.optRHNetworkOnly.AutoSize = True
        Me.optRHNetworkOnly.Enabled = False
        Me.optRHNetworkOnly.Location = New System.Drawing.Point(6, 76)
        Me.optRHNetworkOnly.Name = "optRHNetworkOnly"
        Me.optRHNetworkOnly.Size = New System.Drawing.Size(127, 17)
        Me.optRHNetworkOnly.TabIndex = 2
        Me.optRHNetworkOnly.Text = "Network Only (GBAS)"
        Me.optRHNetworkOnly.UseVisualStyleBackColor = True
        '
        'optRHGBAS
        '
        Me.optRHGBAS.AutoSize = True
        Me.optRHGBAS.Enabled = False
        Me.optRHGBAS.Location = New System.Drawing.Point(6, 57)
        Me.optRHGBAS.Name = "optRHGBAS"
        Me.optRHGBAS.Size = New System.Drawing.Size(90, 17)
        Me.optRHGBAS.TabIndex = 1
        Me.optRHGBAS.Text = "GBAS Control"
        Me.optRHGBAS.UseVisualStyleBackColor = True
        '
        'optTempPriority
        '
        Me.optTempPriority.AutoSize = True
        Me.optTempPriority.Checked = True
        Me.optTempPriority.Location = New System.Drawing.Point(6, 19)
        Me.optTempPriority.Name = "optTempPriority"
        Me.optTempPriority.Size = New System.Drawing.Size(102, 17)
        Me.optTempPriority.TabIndex = 0
        Me.optTempPriority.TabStop = True
        Me.optTempPriority.Text = "TStat - Temp Pri"
        Me.optTempPriority.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optMODBUSDH)
        Me.GroupBox2.Controls.Add(Me.chkSensorControl)
        Me.GroupBox2.Controls.Add(Me.optDHThermostat)
        Me.GroupBox2.Controls.Add(Me.optDHGBASEnab)
        Me.GroupBox2.Controls.Add(Me.optDHCompsByJCI)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 181)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dehum Strategy"
        '
        'optMODBUSDH
        '
        Me.optMODBUSDH.AutoSize = True
        Me.optMODBUSDH.Location = New System.Drawing.Point(7, 89)
        Me.optMODBUSDH.Name = "optMODBUSDH"
        Me.optMODBUSDH.Size = New System.Drawing.Size(108, 17)
        Me.optMODBUSDH.TabIndex = 9
        Me.optMODBUSDH.Text = "MODBUS Control"
        Me.optMODBUSDH.UseVisualStyleBackColor = True
        '
        'chkSensorControl
        '
        Me.chkSensorControl.AutoSize = True
        Me.chkSensorControl.Location = New System.Drawing.Point(6, 118)
        Me.chkSensorControl.Name = "chkSensorControl"
        Me.chkSensorControl.Size = New System.Drawing.Size(95, 17)
        Me.chkSensorControl.TabIndex = 8
        Me.chkSensorControl.Text = "Sensor Control"
        Me.chkSensorControl.UseVisualStyleBackColor = True
        '
        'optDHThermostat
        '
        Me.optDHThermostat.AutoSize = True
        Me.optDHThermostat.Checked = True
        Me.optDHThermostat.Location = New System.Drawing.Point(6, 65)
        Me.optDHThermostat.Name = "optDHThermostat"
        Me.optDHThermostat.Size = New System.Drawing.Size(114, 17)
        Me.optDHThermostat.TabIndex = 2
        Me.optDHThermostat.TabStop = True
        Me.optDHThermostat.Text = "Thermostat Control"
        Me.optDHThermostat.UseVisualStyleBackColor = True
        '
        'optDHGBASEnab
        '
        Me.optDHGBASEnab.AutoSize = True
        Me.optDHGBASEnab.Location = New System.Drawing.Point(6, 42)
        Me.optDHGBASEnab.Name = "optDHGBASEnab"
        Me.optDHGBASEnab.Size = New System.Drawing.Size(96, 17)
        Me.optDHGBASEnab.TabIndex = 1
        Me.optDHGBASEnab.Text = "GBAS Enabled"
        Me.optDHGBASEnab.UseVisualStyleBackColor = True
        '
        'optDHCompsByJCI
        '
        Me.optDHCompsByJCI.AutoSize = True
        Me.optDHCompsByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optDHCompsByJCI.Name = "optDHCompsByJCI"
        Me.optDHCompsByJCI.Size = New System.Drawing.Size(116, 17)
        Me.optDHCompsByJCI.TabIndex = 0
        Me.optDHCompsByJCI.Text = "JCI Controls Comps"
        Me.optDHCompsByJCI.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(386, 164)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 67)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Unit Control"
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Location = New System.Drawing.Point(14, 46)
        Me.optIPU.Name = "optIPU"
        Me.optIPU.Size = New System.Drawing.Size(90, 17)
        Me.optIPU.TabIndex = 1
        Me.optIPU.Text = "IPU Controller"
        Me.optIPU.UseVisualStyleBackColor = True
        '
        'optSE
        '
        Me.optSE.AutoSize = True
        Me.optSE.Checked = True
        Me.optSE.Location = New System.Drawing.Point(14, 20)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 0
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.optParallelPiping)
        Me.tpgPerformance.Controls.Add(Me.optSeriesPiping)
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.txtDehumCap)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 191)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'optParallelPiping
        '
        Me.optParallelPiping.AutoSize = True
        Me.optParallelPiping.Checked = True
        Me.optParallelPiping.Location = New System.Drawing.Point(111, 83)
        Me.optParallelPiping.Name = "optParallelPiping"
        Me.optParallelPiping.Size = New System.Drawing.Size(91, 17)
        Me.optParallelPiping.TabIndex = 56
        Me.optParallelPiping.TabStop = True
        Me.optParallelPiping.Text = "Parallel Piping"
        Me.optParallelPiping.UseVisualStyleBackColor = True
        '
        'optSeriesPiping
        '
        Me.optSeriesPiping.AutoSize = True
        Me.optSeriesPiping.Location = New System.Drawing.Point(15, 83)
        Me.optSeriesPiping.Name = "optSeriesPiping"
        Me.optSeriesPiping.Size = New System.Drawing.Size(86, 17)
        Me.optSeriesPiping.TabIndex = 55
        Me.optSeriesPiping.Text = "Series Piping"
        Me.optSeriesPiping.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(171, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "ºF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(171, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "ºF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "lb/hr"
        '
        'txtDehumCap
        '
        Me.txtDehumCap.Location = New System.Drawing.Point(103, 57)
        Me.txtDehumCap.Name = "txtDehumCap"
        Me.txtDehumCap.Size = New System.Drawing.Size(62, 20)
        Me.txtDehumCap.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Dehum Capacity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Delta T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Leaving DB Temp"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(103, 32)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(62, 20)
        Me.txtDeltaT.TabIndex = 40
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(103, 6)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(62, 20)
        Me.txtLAT.TabIndex = 39
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(386, 164)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerf.TabIndex = 14
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.DebugPage.Size = New System.Drawing.Size(432, 191)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'chkECoat
        '
        Me.chkECoat.AutoSize = True
        Me.chkECoat.Location = New System.Drawing.Point(5, 170)
        Me.chkECoat.Name = "chkECoat"
        Me.chkECoat.Size = New System.Drawing.Size(124, 17)
        Me.chkECoat.TabIndex = 38
        Me.chkECoat.Text = "E-Coat Epoy Coating"
        Me.chkECoat.UseVisualStyleBackColor = True
        '
        'frmHGRH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmHGRH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hot Gas Reheat"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudCircuitsofRH As NumericUpDown
    Friend WithEvents txtEATDB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHGRHAFlow As TextBox
    Friend WithEvents txtHGRHCap As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optDHGBASEnab As RadioButton
    Friend WithEvents optDHCompsByJCI As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optRHGBAS As RadioButton
    Friend WithEvents optTempPriority As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDehumCap As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents optDHThermostat As RadioButton
    Friend WithEvents opt100OARH As RadioButton
    Friend WithEvents optRHNetworkOnly As RadioButton
    Friend WithEvents optParallelPiping As RadioButton
    Friend WithEvents optSeriesPiping As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRHCoilAPD As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents optFieldStat As RadioButton
    Friend WithEvents optFisenRASensor As RadioButton
    Friend WithEvents optFisenZoneSensor As RadioButton
    Friend WithEvents optFisenRAStat As RadioButton
    Friend WithEvents optFisenZoneHum As RadioButton
    Friend WithEvents chkSensorControl As CheckBox
    Friend WithEvents chkModulatingCtrl As CheckBox
    Friend WithEvents optHumPriority As RadioButton
    Friend WithEvents optMODBUSRH As RadioButton
    Friend WithEvents optMODBUSDH As RadioButton
    Friend WithEvents chkModbusPoints As CheckBox
    Friend WithEvents chkECoat As CheckBox
End Class
