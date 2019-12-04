<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEHeat_I
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMEHeat_I))
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.cmbHeatUse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInputCapBTU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputCapkW = New System.Windows.Forms.TextBox()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkPressurePlate = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optOpenCoil = New System.Windows.Forms.RadioButton()
        Me.optFinTube = New System.Windows.Forms.RadioButton()
        Me.grpMainDischargeConfig = New System.Windows.Forms.GroupBox()
        Me.optFrontDischarge = New System.Windows.Forms.RadioButton()
        Me.optRearDischarge = New System.Windows.Forms.RadioButton()
        Me.optBottomDischarge = New System.Windows.Forms.RadioButton()
        Me.optConvertibleDischarge = New System.Windows.Forms.RadioButton()
        Me.chkLocalDisconnect = New System.Windows.Forms.CheckBox()
        Me.chkModulatingHeat = New System.Windows.Forms.CheckBox()
        Me.chk65KIA = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.opt100AOModeCtrl = New System.Windows.Forms.RadioButton()
        Me.optCustomCtrl = New System.Windows.Forms.RadioButton()
        Me.opt100OACtrls = New System.Windows.Forms.RadioButton()
        Me.chkTempering = New System.Windows.Forms.CheckBox()
        Me.optSATCtrl = New System.Windows.Forms.RadioButton()
        Me.optGBAS = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.cmdCapacityCalcs = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHeaterSP = New System.Windows.Forms.TextBox()
        Me.cmdStaticCalcs = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHeaterVel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHeaterW = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHeaterH = New System.Windows.Forms.TextBox()
        Me.txtHeaterVoltage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUnitVoltage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAppliedCapacitymbh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAppliedCapacitykw = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.optPCU = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpMainDischargeConfig.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Location = New System.Drawing.Point(355, 237)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(96, 29)
        Me.cmdDesignCautions.TabIndex = 12
        Me.cmdDesignCautions.Text = "Design Cautions"
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 237)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 237)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 10
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
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 219)
        Me.TabControl1.TabIndex = 13
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.cmbHeatUse)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.txtInputCapBTU)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.txtInputCapkW)
        Me.tpgConditions.Controls.Add(Me.txtHeatAF)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(440, 193)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'cmbHeatUse
        '
        Me.cmbHeatUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeatUse.FormattingEnabled = True
        Me.cmbHeatUse.Items.AddRange(New Object() {"Main Heat", "Preheat", "Reactivation Heat"})
        Me.cmbHeatUse.Location = New System.Drawing.Point(8, 6)
        Me.cmbHeatUse.Name = "cmbHeatUse"
        Me.cmbHeatUse.Size = New System.Drawing.Size(168, 21)
        Me.cmbHeatUse.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Input Capacity(btu/h)"
        '
        'txtInputCapBTU
        '
        Me.txtInputCapBTU.Location = New System.Drawing.Point(9, 118)
        Me.txtInputCapBTU.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCapBTU.Name = "txtInputCapBTU"
        Me.txtInputCapBTU.Size = New System.Drawing.Size(52, 20)
        Me.txtInputCapBTU.TabIndex = 4
        Me.txtInputCapBTU.Text = "-"
        Me.txtInputCapBTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nominal Input Capacity(kW)"
        '
        'txtInputCapkW
        '
        Me.txtInputCapkW.Location = New System.Drawing.Point(9, 90)
        Me.txtInputCapkW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCapkW.Name = "txtInputCapkW"
        Me.txtInputCapkW.Size = New System.Drawing.Size(52, 20)
        Me.txtInputCapkW.TabIndex = 3
        Me.txtInputCapkW.Text = "-"
        Me.txtInputCapkW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(8, 34)
        Me.txtHeatAF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(52, 20)
        Me.txtHeatAF.TabIndex = 1
        Me.txtHeatAF.Text = "-"
        Me.txtHeatAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(9, 62)
        Me.txtEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(52, 20)
        Me.txtEAT.TabIndex = 2
        Me.txtEAT.Text = "-"
        Me.txtEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 5
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkPressurePlate)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.grpMainDischargeConfig)
        Me.tpgOptions.Controls.Add(Me.chkLocalDisconnect)
        Me.tpgOptions.Controls.Add(Me.chkModulatingHeat)
        Me.tpgOptions.Controls.Add(Me.chk65KIA)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(440, 193)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkPressurePlate
        '
        Me.chkPressurePlate.AutoSize = True
        Me.chkPressurePlate.Location = New System.Drawing.Point(8, 82)
        Me.chkPressurePlate.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPressurePlate.Name = "chkPressurePlate"
        Me.chkPressurePlate.Size = New System.Drawing.Size(172, 17)
        Me.chkPressurePlate.TabIndex = 3
        Me.chkPressurePlate.Text = "Install 40% MFP Pressure Plate"
        Me.chkPressurePlate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optOpenCoil)
        Me.GroupBox3.Controls.Add(Me.optFinTube)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 45)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Element Type"
        '
        'optOpenCoil
        '
        Me.optOpenCoil.AutoSize = True
        Me.optOpenCoil.Checked = True
        Me.optOpenCoil.Location = New System.Drawing.Point(6, 18)
        Me.optOpenCoil.Name = "optOpenCoil"
        Me.optOpenCoil.Size = New System.Drawing.Size(71, 17)
        Me.optOpenCoil.TabIndex = 0
        Me.optOpenCoil.TabStop = True
        Me.optOpenCoil.Text = "Open Coil"
        Me.optOpenCoil.UseVisualStyleBackColor = True
        '
        'optFinTube
        '
        Me.optFinTube.AutoSize = True
        Me.optFinTube.Location = New System.Drawing.Point(83, 18)
        Me.optFinTube.Name = "optFinTube"
        Me.optFinTube.Size = New System.Drawing.Size(85, 17)
        Me.optFinTube.TabIndex = 1
        Me.optFinTube.Text = "Finned Tube"
        Me.optFinTube.UseVisualStyleBackColor = True
        '
        'grpMainDischargeConfig
        '
        Me.grpMainDischargeConfig.Controls.Add(Me.optFrontDischarge)
        Me.grpMainDischargeConfig.Controls.Add(Me.optRearDischarge)
        Me.grpMainDischargeConfig.Controls.Add(Me.optBottomDischarge)
        Me.grpMainDischargeConfig.Controls.Add(Me.optConvertibleDischarge)
        Me.grpMainDischargeConfig.Location = New System.Drawing.Point(336, 7)
        Me.grpMainDischargeConfig.Name = "grpMainDischargeConfig"
        Me.grpMainDischargeConfig.Size = New System.Drawing.Size(98, 109)
        Me.grpMainDischargeConfig.TabIndex = 30
        Me.grpMainDischargeConfig.TabStop = False
        Me.grpMainDischargeConfig.Text = "Discharge"
        '
        'optFrontDischarge
        '
        Me.optFrontDischarge.AutoSize = True
        Me.optFrontDischarge.Location = New System.Drawing.Point(6, 87)
        Me.optFrontDischarge.Name = "optFrontDischarge"
        Me.optFrontDischarge.Size = New System.Drawing.Size(49, 17)
        Me.optFrontDischarge.TabIndex = 3
        Me.optFrontDischarge.Text = "Front"
        Me.optFrontDischarge.UseVisualStyleBackColor = True
        '
        'optRearDischarge
        '
        Me.optRearDischarge.AutoSize = True
        Me.optRearDischarge.Location = New System.Drawing.Point(6, 64)
        Me.optRearDischarge.Name = "optRearDischarge"
        Me.optRearDischarge.Size = New System.Drawing.Size(48, 17)
        Me.optRearDischarge.TabIndex = 2
        Me.optRearDischarge.Text = "Rear"
        Me.optRearDischarge.UseVisualStyleBackColor = True
        '
        'optBottomDischarge
        '
        Me.optBottomDischarge.AutoSize = True
        Me.optBottomDischarge.Location = New System.Drawing.Point(6, 41)
        Me.optBottomDischarge.Name = "optBottomDischarge"
        Me.optBottomDischarge.Size = New System.Drawing.Size(58, 17)
        Me.optBottomDischarge.TabIndex = 1
        Me.optBottomDischarge.Text = "Bottom"
        Me.optBottomDischarge.UseVisualStyleBackColor = True
        '
        'optConvertibleDischarge
        '
        Me.optConvertibleDischarge.AutoSize = True
        Me.optConvertibleDischarge.Checked = True
        Me.optConvertibleDischarge.Location = New System.Drawing.Point(6, 19)
        Me.optConvertibleDischarge.Name = "optConvertibleDischarge"
        Me.optConvertibleDischarge.Size = New System.Drawing.Size(78, 17)
        Me.optConvertibleDischarge.TabIndex = 0
        Me.optConvertibleDischarge.TabStop = True
        Me.optConvertibleDischarge.Text = "Convertible"
        Me.optConvertibleDischarge.UseVisualStyleBackColor = True
        '
        'chkLocalDisconnect
        '
        Me.chkLocalDisconnect.AutoSize = True
        Me.chkLocalDisconnect.Location = New System.Drawing.Point(8, 7)
        Me.chkLocalDisconnect.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLocalDisconnect.Name = "chkLocalDisconnect"
        Me.chkLocalDisconnect.Size = New System.Drawing.Size(179, 17)
        Me.chkLocalDisconnect.TabIndex = 0
        Me.chkLocalDisconnect.Text = "Local Heater Disconnect Switch"
        Me.chkLocalDisconnect.UseVisualStyleBackColor = True
        '
        'chkModulatingHeat
        '
        Me.chkModulatingHeat.AutoSize = True
        Me.chkModulatingHeat.Location = New System.Drawing.Point(8, 32)
        Me.chkModulatingHeat.Margin = New System.Windows.Forms.Padding(4)
        Me.chkModulatingHeat.Name = "chkModulatingHeat"
        Me.chkModulatingHeat.Size = New System.Drawing.Size(113, 17)
        Me.chkModulatingHeat.TabIndex = 1
        Me.chkModulatingHeat.Text = "Modulating Heater"
        Me.chkModulatingHeat.UseVisualStyleBackColor = True
        '
        'chk65KIA
        '
        Me.chk65KIA.AutoSize = True
        Me.chk65KIA.Location = New System.Drawing.Point(8, 57)
        Me.chk65KIA.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65KIA.Name = "chk65KIA"
        Me.chk65KIA.Size = New System.Drawing.Size(162, 17)
        Me.chk65KIA.TabIndex = 2
        Me.chk65KIA.Text = "65 kIA SCCR Electric Heater"
        Me.chk65KIA.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(221, 168)
        Me.chkMountEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 5
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(202, 145)
        Me.chkIncludeEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 4
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 6
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.opt100AOModeCtrl)
        Me.tpgControls.Controls.Add(Me.optCustomCtrl)
        Me.tpgControls.Controls.Add(Me.opt100OACtrls)
        Me.tpgControls.Controls.Add(Me.chkTempering)
        Me.tpgControls.Controls.Add(Me.optSATCtrl)
        Me.tpgControls.Controls.Add(Me.optGBAS)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(440, 193)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPCU)
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(316, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(117, 104)
        Me.GroupBox1.TabIndex = 32
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
        'opt100AOModeCtrl
        '
        Me.opt100AOModeCtrl.AutoSize = True
        Me.opt100AOModeCtrl.Enabled = False
        Me.opt100AOModeCtrl.Location = New System.Drawing.Point(7, 57)
        Me.opt100AOModeCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.opt100AOModeCtrl.Name = "opt100AOModeCtrl"
        Me.opt100AOModeCtrl.Size = New System.Drawing.Size(201, 17)
        Me.opt100AOModeCtrl.TabIndex = 2
        Me.opt100AOModeCtrl.Text = "100% Outdoor Air Unit (Mode Control)"
        Me.opt100AOModeCtrl.UseVisualStyleBackColor = True
        '
        'optCustomCtrl
        '
        Me.optCustomCtrl.AutoSize = True
        Me.optCustomCtrl.Location = New System.Drawing.Point(7, 132)
        Me.optCustomCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.optCustomCtrl.Name = "optCustomCtrl"
        Me.optCustomCtrl.Size = New System.Drawing.Size(101, 17)
        Me.optCustomCtrl.TabIndex = 5
        Me.optCustomCtrl.Text = "Custom Controls"
        Me.optCustomCtrl.UseVisualStyleBackColor = True
        '
        'opt100OACtrls
        '
        Me.opt100OACtrls.AutoSize = True
        Me.opt100OACtrls.Location = New System.Drawing.Point(7, 82)
        Me.opt100OACtrls.Margin = New System.Windows.Forms.Padding(4)
        Me.opt100OACtrls.Name = "opt100OACtrls"
        Me.opt100OACtrls.Size = New System.Drawing.Size(184, 17)
        Me.opt100OACtrls.TabIndex = 3
        Me.opt100OACtrls.Text = "100% Outdoor Air Unit (DAT Only)"
        Me.opt100OACtrls.UseVisualStyleBackColor = True
        '
        'chkTempering
        '
        Me.chkTempering.AutoSize = True
        Me.chkTempering.Enabled = False
        Me.chkTempering.Location = New System.Drawing.Point(24, 32)
        Me.chkTempering.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempering.Name = "chkTempering"
        Me.chkTempering.Size = New System.Drawing.Size(167, 17)
        Me.chkTempering.TabIndex = 1
        Me.chkTempering.Text = "Supply Air Tempering Controls"
        Me.chkTempering.UseVisualStyleBackColor = True
        '
        'optSATCtrl
        '
        Me.optSATCtrl.AutoSize = True
        Me.optSATCtrl.Checked = True
        Me.optSATCtrl.Location = New System.Drawing.Point(7, 7)
        Me.optSATCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.optSATCtrl.Name = "optSATCtrl"
        Me.optSATCtrl.Size = New System.Drawing.Size(176, 17)
        Me.optSATCtrl.TabIndex = 0
        Me.optSATCtrl.TabStop = True
        Me.optSATCtrl.Text = "Supply Air Temperature Controls"
        Me.optSATCtrl.UseVisualStyleBackColor = True
        '
        'optGBAS
        '
        Me.optGBAS.AutoSize = True
        Me.optGBAS.Enabled = False
        Me.optGBAS.Location = New System.Drawing.Point(7, 107)
        Me.optGBAS.Margin = New System.Windows.Forms.Padding(4)
        Me.optGBAS.Name = "optGBAS"
        Me.optGBAS.Size = New System.Drawing.Size(146, 17)
        Me.optGBAS.TabIndex = 4
        Me.optGBAS.Text = "GBAS (3rd Party Controls)"
        Me.optGBAS.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 6
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.cmdCapacityCalcs)
        Me.tpgPerformance.Controls.Add(Me.GroupBox2)
        Me.tpgPerformance.Controls.Add(Me.txtHeaterVoltage)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.txtUnitVoltage)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.txtAppliedCapacitymbh)
        Me.tpgPerformance.Controls.Add(Me.Label8)
        Me.tpgPerformance.Controls.Add(Me.txtAppliedCapacitykw)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.Label5)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(440, 193)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'cmdCapacityCalcs
        '
        Me.cmdCapacityCalcs.Image = CType(resources.GetObject("cmdCapacityCalcs.Image"), System.Drawing.Image)
        Me.cmdCapacityCalcs.Location = New System.Drawing.Point(153, 37)
        Me.cmdCapacityCalcs.Name = "cmdCapacityCalcs"
        Me.cmdCapacityCalcs.Size = New System.Drawing.Size(22, 22)
        Me.cmdCapacityCalcs.TabIndex = 2
        Me.cmdCapacityCalcs.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtHeaterSP)
        Me.GroupBox2.Controls.Add(Me.cmdStaticCalcs)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtHeaterVel)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtHeaterW)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtHeaterH)
        Me.GroupBox2.Location = New System.Drawing.Point(213, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 150)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Static Addition"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(68, 79)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Static Pressure"
        '
        'txtHeaterSP
        '
        Me.txtHeaterSP.Location = New System.Drawing.Point(7, 76)
        Me.txtHeaterSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeaterSP.Name = "txtHeaterSP"
        Me.txtHeaterSP.Size = New System.Drawing.Size(52, 20)
        Me.txtHeaterSP.TabIndex = 4
        Me.txtHeaterSP.Text = "-"
        Me.txtHeaterSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdStaticCalcs
        '
        Me.cmdStaticCalcs.Image = CType(resources.GetObject("cmdStaticCalcs.Image"), System.Drawing.Image)
        Me.cmdStaticCalcs.Location = New System.Drawing.Point(119, 47)
        Me.cmdStaticCalcs.Name = "cmdStaticCalcs"
        Me.cmdStaticCalcs.Size = New System.Drawing.Size(22, 22)
        Me.cmdStaticCalcs.TabIndex = 2
        Me.cmdStaticCalcs.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(68, 51)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Velocity"
        '
        'txtHeaterVel
        '
        Me.txtHeaterVel.Location = New System.Drawing.Point(7, 48)
        Me.txtHeaterVel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeaterVel.Name = "txtHeaterVel"
        Me.txtHeaterVel.Size = New System.Drawing.Size(52, 20)
        Me.txtHeaterVel.TabIndex = 3
        Me.txtHeaterVel.Text = "-"
        Me.txtHeaterVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(152, 23)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "W"
        '
        'txtHeaterW
        '
        Me.txtHeaterW.Location = New System.Drawing.Point(91, 20)
        Me.txtHeaterW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeaterW.Name = "txtHeaterW"
        Me.txtHeaterW.Size = New System.Drawing.Size(52, 20)
        Me.txtHeaterW.TabIndex = 1
        Me.txtHeaterW.Text = "-"
        Me.txtHeaterW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "H"
        '
        'txtHeaterH
        '
        Me.txtHeaterH.Location = New System.Drawing.Point(7, 20)
        Me.txtHeaterH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeaterH.Name = "txtHeaterH"
        Me.txtHeaterH.Size = New System.Drawing.Size(52, 20)
        Me.txtHeaterH.TabIndex = 0
        Me.txtHeaterH.Text = "-"
        Me.txtHeaterH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeaterVoltage
        '
        Me.txtHeaterVoltage.Location = New System.Drawing.Point(8, 37)
        Me.txtHeaterVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeaterVoltage.Name = "txtHeaterVoltage"
        Me.txtHeaterVoltage.Size = New System.Drawing.Size(52, 20)
        Me.txtHeaterVoltage.TabIndex = 1
        Me.txtHeaterVoltage.Text = "-"
        Me.txtHeaterVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Heater Voltage"
        '
        'txtUnitVoltage
        '
        Me.txtUnitVoltage.Location = New System.Drawing.Point(8, 9)
        Me.txtUnitVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitVoltage.Name = "txtUnitVoltage"
        Me.txtUnitVoltage.Size = New System.Drawing.Size(52, 20)
        Me.txtUnitVoltage.TabIndex = 0
        Me.txtUnitVoltage.Text = "-"
        Me.txtUnitVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Unit Voltage"
        '
        'txtAppliedCapacitymbh
        '
        Me.txtAppliedCapacitymbh.Location = New System.Drawing.Point(8, 93)
        Me.txtAppliedCapacitymbh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAppliedCapacitymbh.Name = "txtAppliedCapacitymbh"
        Me.txtAppliedCapacitymbh.Size = New System.Drawing.Size(52, 20)
        Me.txtAppliedCapacitymbh.TabIndex = 4
        Me.txtAppliedCapacitymbh.Text = "-"
        Me.txtAppliedCapacitymbh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Applied Capacity (mbh)"
        '
        'txtAppliedCapacitykw
        '
        Me.txtAppliedCapacitykw.Location = New System.Drawing.Point(8, 65)
        Me.txtAppliedCapacitykw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAppliedCapacitykw.Name = "txtAppliedCapacitykw"
        Me.txtAppliedCapacitykw.Size = New System.Drawing.Size(52, 20)
        Me.txtAppliedCapacitykw.TabIndex = 3
        Me.txtAppliedCapacitykw.Text = "-"
        Me.txtAppliedCapacitykw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Applied Input Capacity (kW)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Delta T"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(8, 149)
        Me.txtDeltaT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(52, 20)
        Me.txtDeltaT.TabIndex = 6
        Me.txtDeltaT.Text = "-"
        Me.txtDeltaT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Leaving Air Temp(ºF)"
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(8, 121)
        Me.txtLAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(52, 20)
        Me.txtLAT.TabIndex = 5
        Me.txtLAT.Text = "-"
        Me.txtLAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(393, 164)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 7
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(440, 193)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'optPCU
        '
        Me.optPCU.AutoSize = True
        Me.optPCU.Enabled = False
        Me.optPCU.Location = New System.Drawing.Point(19, 75)
        Me.optPCU.Margin = New System.Windows.Forms.Padding(4)
        Me.optPCU.Name = "optPCU"
        Me.optPCU.Size = New System.Drawing.Size(94, 17)
        Me.optPCU.TabIndex = 2
        Me.optPCU.Text = "PCU Controller"
        Me.optPCU.UseVisualStyleBackColor = True
        '
        'frmMEHeat_I
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMEHeat_I"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modulating Electric Heat - Indeeco"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpMainDischargeConfig.ResumeLayout(False)
        Me.grpMainDischargeConfig.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInputCapBTU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputCapkW As TextBox
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents cmbHeatUse As ComboBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chkLocalDisconnect As CheckBox
    Friend WithEvents chkModulatingHeat As CheckBox
    Friend WithEvents chk65KIA As CheckBox
    Friend WithEvents grpMainDischargeConfig As GroupBox
    Friend WithEvents optFrontDischarge As RadioButton
    Friend WithEvents optRearDischarge As RadioButton
    Friend WithEvents optBottomDischarge As RadioButton
    Friend WithEvents optConvertibleDischarge As RadioButton
    Friend WithEvents opt100AOModeCtrl As RadioButton
    Friend WithEvents optCustomCtrl As RadioButton
    Friend WithEvents opt100OACtrls As RadioButton
    Friend WithEvents chkTempering As CheckBox
    Friend WithEvents optSATCtrl As RadioButton
    Friend WithEvents optGBAS As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents txtAppliedCapacitykw As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHeaterVoltage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUnitVoltage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAppliedCapacitymbh As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHeaterVel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHeaterW As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtHeaterH As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHeaterSP As TextBox
    Friend WithEvents cmdStaticCalcs As Button
    Friend WithEvents chkPressurePlate As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optOpenCoil As RadioButton
    Friend WithEvents optFinTube As RadioButton
    Friend WithEvents cmdCapacityCalcs As Button
    Friend WithEvents optPCU As RadioButton
End Class
