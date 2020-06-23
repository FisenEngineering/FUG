<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUVLights
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUVLights))
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optPwrDedicated = New System.Windows.Forms.RadioButton()
        Me.optPwrConvOutlet = New System.Windows.Forms.RadioButton()
        Me.optPwrUnitPower = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkInstHGRHCoil = New System.Windows.Forms.CheckBox()
        Me.optInstUSEvap = New System.Windows.Forms.RadioButton()
        Me.optInstDSEvap = New System.Windows.Forms.RadioButton()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkEMControlsOnly = New System.Windows.Forms.CheckBox()
        Me.chkDoorSafetySwitch = New System.Windows.Forms.CheckBox()
        Me.cmbCustomControls = New System.Windows.Forms.ComboBox()
        Me.optCtrlCustom = New System.Windows.Forms.RadioButton()
        Me.optCtrlWithSupplyFan = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optASE = New System.Windows.Forms.RadioButton()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.optCtrl247 = New System.Windows.Forms.RadioButton()
        Me.optCtrlWithComps = New System.Windows.Forms.RadioButton()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 252)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 24
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 240)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 21
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 240)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 20
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(381, 240)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 23
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(417, 240)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 22
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 225)
        Me.TabControl1.TabIndex = 25
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.GroupBox2)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 199)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optPwrDedicated)
        Me.GroupBox2.Controls.Add(Me.optPwrConvOutlet)
        Me.GroupBox2.Controls.Add(Me.optPwrUnitPower)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Power Source"
        '
        'optPwrDedicated
        '
        Me.optPwrDedicated.AutoSize = True
        Me.optPwrDedicated.Location = New System.Drawing.Point(6, 65)
        Me.optPwrDedicated.Name = "optPwrDedicated"
        Me.optPwrDedicated.Size = New System.Drawing.Size(190, 17)
        Me.optPwrDedicated.TabIndex = 10
        Me.optPwrDedicated.Text = "Dedicated Power Circuit (110 VAC)"
        Me.optPwrDedicated.UseVisualStyleBackColor = True
        '
        'optPwrConvOutlet
        '
        Me.optPwrConvOutlet.AutoSize = True
        Me.optPwrConvOutlet.Location = New System.Drawing.Point(6, 42)
        Me.optPwrConvOutlet.Name = "optPwrConvOutlet"
        Me.optPwrConvOutlet.Size = New System.Drawing.Size(182, 17)
        Me.optPwrConvOutlet.TabIndex = 9
        Me.optPwrConvOutlet.Text = "JCI Convenience Outlet Powered"
        Me.optPwrConvOutlet.UseVisualStyleBackColor = True
        '
        'optPwrUnitPower
        '
        Me.optPwrUnitPower.AutoSize = True
        Me.optPwrUnitPower.Checked = True
        Me.optPwrUnitPower.Location = New System.Drawing.Point(6, 19)
        Me.optPwrUnitPower.Name = "optPwrUnitPower"
        Me.optPwrUnitPower.Size = New System.Drawing.Size(89, 17)
        Me.optPwrUnitPower.TabIndex = 8
        Me.optPwrUnitPower.TabStop = True
        Me.optPwrUnitPower.Text = "Unit Powered"
        Me.optPwrUnitPower.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 170)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(432, 199)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkInstHGRHCoil)
        Me.GroupBox3.Controls.Add(Me.optInstUSEvap)
        Me.GroupBox3.Controls.Add(Me.optInstDSEvap)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 89)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Install Location"
        '
        'chkInstHGRHCoil
        '
        Me.chkInstHGRHCoil.AutoSize = True
        Me.chkInstHGRHCoil.Location = New System.Drawing.Point(23, 66)
        Me.chkInstHGRHCoil.Name = "chkInstHGRHCoil"
        Me.chkInstHGRHCoil.Size = New System.Drawing.Size(120, 17)
        Me.chkInstHGRHCoil.TabIndex = 11
        Me.chkInstHGRHCoil.Text = "Unit has HGRH Coil"
        Me.chkInstHGRHCoil.UseVisualStyleBackColor = True
        '
        'optInstUSEvap
        '
        Me.optInstUSEvap.AutoSize = True
        Me.optInstUSEvap.Location = New System.Drawing.Point(6, 20)
        Me.optInstUSEvap.Name = "optInstUSEvap"
        Me.optInstUSEvap.Size = New System.Drawing.Size(137, 17)
        Me.optInstUSEvap.TabIndex = 2
        Me.optInstUSEvap.TabStop = True
        Me.optInstUSEvap.Text = "Upstream of Evaporator"
        Me.optInstUSEvap.UseVisualStyleBackColor = True
        '
        'optInstDSEvap
        '
        Me.optInstDSEvap.AutoSize = True
        Me.optInstDSEvap.Checked = True
        Me.optInstDSEvap.Location = New System.Drawing.Point(6, 43)
        Me.optInstDSEvap.Name = "optInstDSEvap"
        Me.optInstDSEvap.Size = New System.Drawing.Size(151, 17)
        Me.optInstDSEvap.TabIndex = 1
        Me.optInstDSEvap.TabStop = True
        Me.optInstDSEvap.Text = "Downstream of Evaporator"
        Me.optInstDSEvap.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(211, 148)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 48
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Location = New System.Drawing.Point(211, 48)
        Me.fraAuxPanel.Name = "fraAuxPanel"
        Me.fraAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.fraAuxPanel.TabIndex = 47
        Me.fraAuxPanel.TabStop = False
        Me.fraAuxPanel.Text = "Auxillary Control Panel"
        '
        'cmbAuxPanelOpts
        '
        Me.cmbAuxPanelOpts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuxPanelOpts.FormattingEnabled = True
        Me.cmbAuxPanelOpts.Location = New System.Drawing.Point(6, 65)
        Me.cmbAuxPanelOpts.Name = "cmbAuxPanelOpts"
        Me.cmbAuxPanelOpts.Size = New System.Drawing.Size(202, 21)
        Me.cmbAuxPanelOpts.TabIndex = 29
        '
        'optUseAux
        '
        Me.optUseAux.AutoSize = True
        Me.optUseAux.Location = New System.Drawing.Point(6, 42)
        Me.optUseAux.Name = "optUseAux"
        Me.optUseAux.Size = New System.Drawing.Size(151, 17)
        Me.optUseAux.TabIndex = 1
        Me.optUseAux.TabStop = True
        Me.optUseAux.Text = "Use Auxillary Control Panel"
        Me.optUseAux.UseVisualStyleBackColor = True
        '
        'optNoAux
        '
        Me.optNoAux.AutoSize = True
        Me.optNoAux.Checked = True
        Me.optNoAux.Location = New System.Drawing.Point(6, 19)
        Me.optNoAux.Name = "optNoAux"
        Me.optNoAux.Size = New System.Drawing.Size(51, 17)
        Me.optNoAux.TabIndex = 0
        Me.optNoAux.TabStop = True
        Me.optNoAux.Text = "None"
        Me.optNoAux.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(217, 25)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(211, 3)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(385, 170)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkEMControlsOnly)
        Me.tpgControls.Controls.Add(Me.chkDoorSafetySwitch)
        Me.tpgControls.Controls.Add(Me.cmbCustomControls)
        Me.tpgControls.Controls.Add(Me.optCtrlCustom)
        Me.tpgControls.Controls.Add(Me.optCtrlWithSupplyFan)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.optCtrl247)
        Me.tpgControls.Controls.Add(Me.optCtrlWithComps)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 199)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkEMControlsOnly
        '
        Me.chkEMControlsOnly.AutoSize = True
        Me.chkEMControlsOnly.Checked = True
        Me.chkEMControlsOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEMControlsOnly.Enabled = False
        Me.chkEMControlsOnly.Location = New System.Drawing.Point(6, 149)
        Me.chkEMControlsOnly.Name = "chkEMControlsOnly"
        Me.chkEMControlsOnly.Size = New System.Drawing.Size(107, 17)
        Me.chkEMControlsOnly.TabIndex = 13
        Me.chkEMControlsOnly.Text = "EM Controls Only"
        Me.chkEMControlsOnly.UseVisualStyleBackColor = True
        '
        'chkDoorSafetySwitch
        '
        Me.chkDoorSafetySwitch.AutoSize = True
        Me.chkDoorSafetySwitch.Checked = True
        Me.chkDoorSafetySwitch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDoorSafetySwitch.Location = New System.Drawing.Point(6, 126)
        Me.chkDoorSafetySwitch.Name = "chkDoorSafetySwitch"
        Me.chkDoorSafetySwitch.Size = New System.Drawing.Size(200, 17)
        Me.chkDoorSafetySwitch.TabIndex = 12
        Me.chkDoorSafetySwitch.Text = "Cabinet Door Safety Switch Interlock"
        Me.chkDoorSafetySwitch.UseVisualStyleBackColor = True
        '
        'cmbCustomControls
        '
        Me.cmbCustomControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomControls.Enabled = False
        Me.cmbCustomControls.FormattingEnabled = True
        Me.cmbCustomControls.Items.AddRange(New Object() {"Not Required"})
        Me.cmbCustomControls.Location = New System.Drawing.Point(25, 99)
        Me.cmbCustomControls.Name = "cmbCustomControls"
        Me.cmbCustomControls.Size = New System.Drawing.Size(266, 21)
        Me.cmbCustomControls.TabIndex = 11
        '
        'optCtrlCustom
        '
        Me.optCtrlCustom.AutoSize = True
        Me.optCtrlCustom.Enabled = False
        Me.optCtrlCustom.Location = New System.Drawing.Point(6, 76)
        Me.optCtrlCustom.Name = "optCtrlCustom"
        Me.optCtrlCustom.Size = New System.Drawing.Size(101, 17)
        Me.optCtrlCustom.TabIndex = 9
        Me.optCtrlCustom.Text = "Custom Controls"
        Me.optCtrlCustom.UseVisualStyleBackColor = True
        '
        'optCtrlWithSupplyFan
        '
        Me.optCtrlWithSupplyFan.AutoSize = True
        Me.optCtrlWithSupplyFan.Location = New System.Drawing.Point(6, 29)
        Me.optCtrlWithSupplyFan.Name = "optCtrlWithSupplyFan"
        Me.optCtrlWithSupplyFan.Size = New System.Drawing.Size(146, 17)
        Me.optCtrlWithSupplyFan.TabIndex = 8
        Me.optCtrlWithSupplyFan.TabStop = True
        Me.optCtrlWithSupplyFan.Text = "Operates with Supply Fan"
        Me.optCtrlWithSupplyFan.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 170)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optASE)
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Unit Control"
        '
        'optASE
        '
        Me.optASE.AutoSize = True
        Me.optASE.Enabled = False
        Me.optASE.Location = New System.Drawing.Point(14, 66)
        Me.optASE.Name = "optASE"
        Me.optASE.Size = New System.Drawing.Size(93, 17)
        Me.optASE.TabIndex = 2
        Me.optASE.Text = "ASE Controller"
        Me.optASE.UseVisualStyleBackColor = True
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Enabled = False
        Me.optIPU.Location = New System.Drawing.Point(14, 43)
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
        'optCtrl247
        '
        Me.optCtrl247.AutoSize = True
        Me.optCtrl247.Checked = True
        Me.optCtrl247.Location = New System.Drawing.Point(6, 6)
        Me.optCtrl247.Name = "optCtrl247"
        Me.optCtrl247.Size = New System.Drawing.Size(97, 17)
        Me.optCtrl247.TabIndex = 1
        Me.optCtrl247.TabStop = True
        Me.optCtrl247.Text = "24/7 Operation"
        Me.optCtrl247.UseVisualStyleBackColor = True
        '
        'optCtrlWithComps
        '
        Me.optCtrlWithComps.AutoSize = True
        Me.optCtrlWithComps.Location = New System.Drawing.Point(6, 52)
        Me.optCtrlWithComps.Name = "optCtrlWithComps"
        Me.optCtrlWithComps.Size = New System.Drawing.Size(159, 17)
        Me.optCtrlWithComps.TabIndex = 0
        Me.optCtrlWithComps.Text = "Operates with Compressor(s)"
        Me.optCtrlWithComps.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 199)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(385, 170)
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
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(432, 199)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'frmUVLights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUVLights"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ultraviolet Lights"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents cmbCustomControls As ComboBox
    Friend WithEvents optCtrlCustom As RadioButton
    Friend WithEvents optCtrlWithSupplyFan As RadioButton
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optASE As RadioButton
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents optCtrl247 As RadioButton
    Friend WithEvents optCtrlWithComps As RadioButton
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optPwrDedicated As RadioButton
    Friend WithEvents optPwrConvOutlet As RadioButton
    Friend WithEvents optPwrUnitPower As RadioButton
    Friend WithEvents chkDoorSafetySwitch As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkInstHGRHCoil As CheckBox
    Friend WithEvents optInstUSEvap As RadioButton
    Friend WithEvents optInstDSEvap As RadioButton
    Friend WithEvents chkEMControlsOnly As CheckBox
End Class
