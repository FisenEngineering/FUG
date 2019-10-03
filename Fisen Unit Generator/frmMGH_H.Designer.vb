<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMGH_H
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
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputCap = New System.Windows.Forms.TextBox()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.nudHE750 = New System.Windows.Forms.NumericUpDown()
        Me.chkHE750Burner = New System.Windows.Forms.CheckBox()
        Me.chkGasTrainRoofRaise = New System.Windows.Forms.CheckBox()
        Me.nudHMG500 = New System.Windows.Forms.NumericUpDown()
        Me.chkHMG500Burner = New System.Windows.Forms.CheckBox()
        Me.chkGasTrainBumpout = New System.Windows.Forms.CheckBox()
        Me.chkSupplyFanRelocate = New System.Windows.Forms.CheckBox()
        Me.nudHMB300 = New System.Windows.Forms.NumericUpDown()
        Me.chkHMB300Burner = New System.Windows.Forms.CheckBox()
        Me.nudHMB400 = New System.Windows.Forms.NumericUpDown()
        Me.chkHMB400Burner = New System.Windows.Forms.CheckBox()
        Me.nudHMB500 = New System.Windows.Forms.NumericUpDown()
        Me.chkHMB500Burner = New System.Windows.Forms.CheckBox()
        Me.nudHMB600 = New System.Windows.Forms.NumericUpDown()
        Me.chkHMB600Burner = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.optCustomCtrl = New System.Windows.Forms.RadioButton()
        Me.opt100OACtrls = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.chkTempering = New System.Windows.Forms.CheckBox()
        Me.optSATCtrl = New System.Windows.Forms.RadioButton()
        Me.optGBAS = New System.Windows.Forms.RadioButton()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.txtOutCap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSSE = New System.Windows.Forms.TextBox()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        CType(Me.nudHE750, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHMG500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHMB300, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHMB400, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHMB500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHMB600, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 327)
        Me.TabControl1.TabIndex = 9
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.txtInputCap)
        Me.tpgConditions.Controls.Add(Me.txtHeatAF)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(583, 301)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(520, 265)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Input Capacity(mbh)"
        '
        'txtInputCap
        '
        Me.txtInputCap.Location = New System.Drawing.Point(8, 73)
        Me.txtInputCap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCap.Name = "txtInputCap"
        Me.txtInputCap.Size = New System.Drawing.Size(52, 20)
        Me.txtInputCap.TabIndex = 4
        Me.txtInputCap.Text = "88888"
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(8, 7)
        Me.txtHeatAF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(52, 20)
        Me.txtHeatAF.TabIndex = 0
        Me.txtHeatAF.Text = "88888"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(8, 39)
        Me.txtEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(52, 20)
        Me.txtEAT.TabIndex = 2
        Me.txtEAT.Text = "88888"
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.nudHE750)
        Me.tpgOptions.Controls.Add(Me.chkHE750Burner)
        Me.tpgOptions.Controls.Add(Me.chkGasTrainRoofRaise)
        Me.tpgOptions.Controls.Add(Me.nudHMG500)
        Me.tpgOptions.Controls.Add(Me.chkHMG500Burner)
        Me.tpgOptions.Controls.Add(Me.chkGasTrainBumpout)
        Me.tpgOptions.Controls.Add(Me.chkSupplyFanRelocate)
        Me.tpgOptions.Controls.Add(Me.nudHMB300)
        Me.tpgOptions.Controls.Add(Me.chkHMB300Burner)
        Me.tpgOptions.Controls.Add(Me.nudHMB400)
        Me.tpgOptions.Controls.Add(Me.chkHMB400Burner)
        Me.tpgOptions.Controls.Add(Me.nudHMB500)
        Me.tpgOptions.Controls.Add(Me.chkHMB500Burner)
        Me.tpgOptions.Controls.Add(Me.nudHMB600)
        Me.tpgOptions.Controls.Add(Me.chkHMB600Burner)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(583, 301)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'nudHE750
        '
        Me.nudHE750.Location = New System.Drawing.Point(440, 64)
        Me.nudHE750.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHE750.Name = "nudHE750"
        Me.nudHE750.Size = New System.Drawing.Size(35, 20)
        Me.nudHE750.TabIndex = 27
        '
        'chkHE750Burner
        '
        Me.chkHE750Burner.AutoSize = True
        Me.chkHE750Burner.Location = New System.Drawing.Point(329, 64)
        Me.chkHE750Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHE750Burner.Name = "chkHE750Burner"
        Me.chkHE750Burner.Size = New System.Drawing.Size(104, 17)
        Me.chkHE750Burner.TabIndex = 26
        Me.chkHE750Burner.Text = "HE750 Burner(s)"
        Me.chkHE750Burner.UseVisualStyleBackColor = True
        '
        'chkGasTrainRoofRaise
        '
        Me.chkGasTrainRoofRaise.AutoSize = True
        Me.chkGasTrainRoofRaise.Location = New System.Drawing.Point(204, 272)
        Me.chkGasTrainRoofRaise.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGasTrainRoofRaise.Name = "chkGasTrainRoofRaise"
        Me.chkGasTrainRoofRaise.Size = New System.Drawing.Size(145, 17)
        Me.chkGasTrainRoofRaise.TabIndex = 25
        Me.chkGasTrainRoofRaise.Text = "Gas Train Roof Elevation"
        Me.chkGasTrainRoofRaise.UseVisualStyleBackColor = True
        '
        'nudHMG500
        '
        Me.nudHMG500.Location = New System.Drawing.Point(282, 108)
        Me.nudHMG500.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHMG500.Name = "nudHMG500"
        Me.nudHMG500.Size = New System.Drawing.Size(35, 20)
        Me.nudHMG500.TabIndex = 24
        '
        'chkHMG500Burner
        '
        Me.chkHMG500Burner.AutoSize = True
        Me.chkHMG500Burner.Location = New System.Drawing.Point(168, 109)
        Me.chkHMG500Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHMG500Burner.Name = "chkHMG500Burner"
        Me.chkHMG500Burner.Size = New System.Drawing.Size(117, 17)
        Me.chkHMG500Burner.TabIndex = 23
        Me.chkHMG500Burner.Text = "HMG 500 Burner(s)"
        Me.chkHMG500Burner.UseVisualStyleBackColor = True
        '
        'chkGasTrainBumpout
        '
        Me.chkGasTrainBumpout.AutoSize = True
        Me.chkGasTrainBumpout.Location = New System.Drawing.Point(204, 247)
        Me.chkGasTrainBumpout.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGasTrainBumpout.Name = "chkGasTrainBumpout"
        Me.chkGasTrainBumpout.Size = New System.Drawing.Size(117, 17)
        Me.chkGasTrainBumpout.TabIndex = 22
        Me.chkGasTrainBumpout.Text = "Gas Train Bumpout"
        Me.chkGasTrainBumpout.UseVisualStyleBackColor = True
        '
        'chkSupplyFanRelocate
        '
        Me.chkSupplyFanRelocate.AutoSize = True
        Me.chkSupplyFanRelocate.Location = New System.Drawing.Point(204, 222)
        Me.chkSupplyFanRelocate.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSupplyFanRelocate.Name = "chkSupplyFanRelocate"
        Me.chkSupplyFanRelocate.Size = New System.Drawing.Size(133, 17)
        Me.chkSupplyFanRelocate.TabIndex = 21
        Me.chkSupplyFanRelocate.Text = "Supply Fan Relocation"
        Me.chkSupplyFanRelocate.UseVisualStyleBackColor = True
        '
        'nudHMB300
        '
        Me.nudHMB300.Location = New System.Drawing.Point(126, 160)
        Me.nudHMB300.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHMB300.Name = "nudHMB300"
        Me.nudHMB300.Size = New System.Drawing.Size(35, 20)
        Me.nudHMB300.TabIndex = 20
        '
        'chkHMB300Burner
        '
        Me.chkHMB300Burner.AutoSize = True
        Me.chkHMB300Burner.Location = New System.Drawing.Point(12, 161)
        Me.chkHMB300Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHMB300Burner.Name = "chkHMB300Burner"
        Me.chkHMB300Burner.Size = New System.Drawing.Size(116, 17)
        Me.chkHMB300Burner.TabIndex = 19
        Me.chkHMB300Burner.Text = "HMB 300 Burner(s)"
        Me.chkHMB300Burner.UseVisualStyleBackColor = True
        '
        'nudHMB400
        '
        Me.nudHMB400.Location = New System.Drawing.Point(126, 135)
        Me.nudHMB400.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHMB400.Name = "nudHMB400"
        Me.nudHMB400.Size = New System.Drawing.Size(35, 20)
        Me.nudHMB400.TabIndex = 18
        '
        'chkHMB400Burner
        '
        Me.chkHMB400Burner.AutoSize = True
        Me.chkHMB400Burner.Location = New System.Drawing.Point(12, 136)
        Me.chkHMB400Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHMB400Burner.Name = "chkHMB400Burner"
        Me.chkHMB400Burner.Size = New System.Drawing.Size(116, 17)
        Me.chkHMB400Burner.TabIndex = 17
        Me.chkHMB400Burner.Text = "HMB 400 Burner(s)"
        Me.chkHMB400Burner.UseVisualStyleBackColor = True
        '
        'nudHMB500
        '
        Me.nudHMB500.Location = New System.Drawing.Point(126, 109)
        Me.nudHMB500.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHMB500.Name = "nudHMB500"
        Me.nudHMB500.Size = New System.Drawing.Size(35, 20)
        Me.nudHMB500.TabIndex = 16
        '
        'chkHMB500Burner
        '
        Me.chkHMB500Burner.AutoSize = True
        Me.chkHMB500Burner.Location = New System.Drawing.Point(12, 110)
        Me.chkHMB500Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHMB500Burner.Name = "chkHMB500Burner"
        Me.chkHMB500Burner.Size = New System.Drawing.Size(116, 17)
        Me.chkHMB500Burner.TabIndex = 15
        Me.chkHMB500Burner.Text = "HMB 500 Burner(s)"
        Me.chkHMB500Burner.UseVisualStyleBackColor = True
        '
        'nudHMB600
        '
        Me.nudHMB600.Location = New System.Drawing.Point(126, 83)
        Me.nudHMB600.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudHMB600.Name = "nudHMB600"
        Me.nudHMB600.Size = New System.Drawing.Size(35, 20)
        Me.nudHMB600.TabIndex = 14
        '
        'chkHMB600Burner
        '
        Me.chkHMB600Burner.AutoSize = True
        Me.chkHMB600Burner.Location = New System.Drawing.Point(12, 84)
        Me.chkHMB600Burner.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHMB600Burner.Name = "chkHMB600Burner"
        Me.chkHMB600Burner.Size = New System.Drawing.Size(116, 17)
        Me.chkHMB600Burner.TabIndex = 13
        Me.chkHMB600Burner.Text = "HMB 600 Burner(s)"
        Me.chkHMB600Burner.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(31, 272)
        Me.chkMountEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(12, 249)
        Me.chkIncludeEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(520, 265)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.RadioButton1)
        Me.tpgControls.Controls.Add(Me.optCustomCtrl)
        Me.tpgControls.Controls.Add(Me.opt100OACtrls)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.chkTempering)
        Me.tpgControls.Controls.Add(Me.optSATCtrl)
        Me.tpgControls.Controls.Add(Me.optGBAS)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(583, 301)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(8, 68)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(201, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "100% Outdoor Air Unit (Mode Control)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'optCustomCtrl
        '
        Me.optCustomCtrl.AutoSize = True
        Me.optCustomCtrl.Location = New System.Drawing.Point(8, 151)
        Me.optCustomCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.optCustomCtrl.Name = "optCustomCtrl"
        Me.optCustomCtrl.Size = New System.Drawing.Size(101, 17)
        Me.optCustomCtrl.TabIndex = 9
        Me.optCustomCtrl.Text = "Custom Controls"
        Me.optCustomCtrl.UseVisualStyleBackColor = True
        '
        'opt100OACtrls
        '
        Me.opt100OACtrls.AutoSize = True
        Me.opt100OACtrls.Location = New System.Drawing.Point(8, 93)
        Me.opt100OACtrls.Margin = New System.Windows.Forms.Padding(4)
        Me.opt100OACtrls.Name = "opt100OACtrls"
        Me.opt100OACtrls.Size = New System.Drawing.Size(184, 17)
        Me.opt100OACtrls.TabIndex = 8
        Me.opt100OACtrls.Text = "100% Outdoor Air Unit (DAT Only)"
        Me.opt100OACtrls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(520, 265)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(117, 73)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Unit Control"
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Enabled = False
        Me.optIPU.Location = New System.Drawing.Point(19, 50)
        Me.optIPU.Margin = New System.Windows.Forms.Padding(4)
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
        Me.optSE.Location = New System.Drawing.Point(19, 25)
        Me.optSE.Margin = New System.Windows.Forms.Padding(4)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 0
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
        '
        'chkTempering
        '
        Me.chkTempering.AutoSize = True
        Me.chkTempering.Enabled = False
        Me.chkTempering.Location = New System.Drawing.Point(25, 32)
        Me.chkTempering.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempering.Name = "chkTempering"
        Me.chkTempering.Size = New System.Drawing.Size(167, 17)
        Me.chkTempering.TabIndex = 2
        Me.chkTempering.Text = "Supply Air Tempering Controls"
        Me.chkTempering.UseVisualStyleBackColor = True
        '
        'optSATCtrl
        '
        Me.optSATCtrl.AutoSize = True
        Me.optSATCtrl.Checked = True
        Me.optSATCtrl.Location = New System.Drawing.Point(8, 7)
        Me.optSATCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.optSATCtrl.Name = "optSATCtrl"
        Me.optSATCtrl.Size = New System.Drawing.Size(176, 17)
        Me.optSATCtrl.TabIndex = 1
        Me.optSATCtrl.TabStop = True
        Me.optSATCtrl.Text = "Supply Air Temperature Controls"
        Me.optSATCtrl.UseVisualStyleBackColor = True
        '
        'optGBAS
        '
        Me.optGBAS.AutoSize = True
        Me.optGBAS.Enabled = False
        Me.optGBAS.Location = New System.Drawing.Point(8, 122)
        Me.optGBAS.Margin = New System.Windows.Forms.Padding(4)
        Me.optGBAS.Name = "optGBAS"
        Me.optGBAS.Size = New System.Drawing.Size(146, 17)
        Me.optGBAS.TabIndex = 0
        Me.optGBAS.Text = "GBAS (3rd Party Controls)"
        Me.optGBAS.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.txtOutCap)
        Me.tpgPerformance.Controls.Add(Me.Label5)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.txtSSE)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Size = New System.Drawing.Size(583, 301)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(520, 265)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 14
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Delta T"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(8, 105)
        Me.txtDeltaT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(52, 20)
        Me.txtDeltaT.TabIndex = 12
        Me.txtDeltaT.Text = "88888"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Leaving Air Temp(ºF)"
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(8, 73)
        Me.txtLAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(52, 20)
        Me.txtLAT.TabIndex = 10
        Me.txtLAT.Text = "88888"
        '
        'txtOutCap
        '
        Me.txtOutCap.Location = New System.Drawing.Point(8, 7)
        Me.txtOutCap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOutCap.Name = "txtOutCap"
        Me.txtOutCap.Size = New System.Drawing.Size(52, 20)
        Me.txtOutCap.TabIndex = 6
        Me.txtOutCap.Text = "88888"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SSE(%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Output Capacity(mbh)"
        '
        'txtSSE
        '
        Me.txtSSE.Location = New System.Drawing.Point(8, 39)
        Me.txtSSE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSSE.Name = "txtSSE"
        Me.txtSSE.Size = New System.Drawing.Size(52, 20)
        Me.txtSSE.TabIndex = 8
        Me.txtSSE.Text = "88888"
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Size = New System.Drawing.Size(583, 301)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(112, 343)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(8, 343)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmMGH_H
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMGH_H"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modulating Gas Heat Heatco"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        CType(Me.nudHE750, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHMG500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHMB300, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHMB400, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHMB500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHMB600, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputCap As TextBox
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents optCustomCtrl As RadioButton
    Friend WithEvents opt100OACtrls As RadioButton
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents chkTempering As CheckBox
    Friend WithEvents optSATCtrl As RadioButton
    Friend WithEvents optGBAS As RadioButton
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents txtOutCap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSSE As TextBox
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents nudHMB600 As NumericUpDown
    Friend WithEvents chkHMB600Burner As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents nudHMB400 As NumericUpDown
    Friend WithEvents chkHMB400Burner As CheckBox
    Friend WithEvents nudHMB500 As NumericUpDown
    Friend WithEvents chkHMB500Burner As CheckBox
    Friend WithEvents nudHMB300 As NumericUpDown
    Friend WithEvents chkHMB300Burner As CheckBox
    Friend WithEvents chkGasTrainBumpout As CheckBox
    Friend WithEvents chkSupplyFanRelocate As CheckBox
    Friend WithEvents chkGasTrainRoofRaise As CheckBox
    Friend WithEvents nudHMG500 As NumericUpDown
    Friend WithEvents chkHMG500Burner As CheckBox
    Friend WithEvents nudHE750 As NumericUpDown
    Friend WithEvents chkHE750Burner As CheckBox
End Class
