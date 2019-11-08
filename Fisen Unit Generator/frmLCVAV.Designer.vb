<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLCVAV
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.optDrivebyField = New System.Windows.Forms.RadioButton()
        Me.optDrivebyFisen = New System.Windows.Forms.RadioButton()
        Me.optDrivebyJCI = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.grpSinglePhaseSFan = New System.Windows.Forms.GroupBox()
        Me.optJustECMotor = New System.Windows.Forms.RadioButton()
        Me.optReplaceFanAndMotor = New System.Windows.Forms.RadioButton()
        Me.optNot1Phase = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkECMotorStaging = New System.Windows.Forms.CheckBox()
        Me.chkIntellispeed = New System.Windows.Forms.CheckBox()
        Me.chkHSFaninRH = New System.Windows.Forms.CheckBox()
        Me.chkUnitisHeatPump = New System.Windows.Forms.CheckBox()
        Me.chkFisenMWUCtrl = New System.Windows.Forms.CheckBox()
        Me.chkFisenSATCtrl = New System.Windows.Forms.CheckBox()
        Me.chkFisenDSPCtrl = New System.Windows.Forms.CheckBox()
        Me.optFisenVAV = New System.Windows.Forms.RadioButton()
        Me.optSEVAV = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpSinglePhaseSFan.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 195)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 195)
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
        Me.TabControl1.Location = New System.Drawing.Point(9, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 179)
        Me.TabControl1.TabIndex = 7
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 153)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.optDrivebyField)
        Me.GroupBox1.Controls.Add(Me.optDrivebyFisen)
        Me.GroupBox1.Controls.Add(Me.optDrivebyJCI)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 114)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "JCI EC Motor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'optDrivebyField
        '
        Me.optDrivebyField.AutoSize = True
        Me.optDrivebyField.Location = New System.Drawing.Point(6, 65)
        Me.optDrivebyField.Name = "optDrivebyField"
        Me.optDrivebyField.Size = New System.Drawing.Size(189, 17)
        Me.optDrivebyField.TabIndex = 10
        Me.optDrivebyField.Text = "Field Provided/Field Installed Drive"
        Me.optDrivebyField.UseVisualStyleBackColor = True
        '
        'optDrivebyFisen
        '
        Me.optDrivebyFisen.AutoSize = True
        Me.optDrivebyFisen.Checked = True
        Me.optDrivebyFisen.Location = New System.Drawing.Point(6, 42)
        Me.optDrivebyFisen.Name = "optDrivebyFisen"
        Me.optDrivebyFisen.Size = New System.Drawing.Size(123, 17)
        Me.optDrivebyFisen.TabIndex = 9
        Me.optDrivebyFisen.TabStop = True
        Me.optDrivebyFisen.Text = "Fisen Provided Drive"
        Me.optDrivebyFisen.UseVisualStyleBackColor = True
        '
        'optDrivebyJCI
        '
        Me.optDrivebyJCI.AutoSize = True
        Me.optDrivebyJCI.Location = New System.Drawing.Point(6, 19)
        Me.optDrivebyJCI.Name = "optDrivebyJCI"
        Me.optDrivebyJCI.Size = New System.Drawing.Size(113, 17)
        Me.optDrivebyJCI.TabIndex = 8
        Me.optDrivebyJCI.Text = "JCI Provided Drive"
        Me.optDrivebyJCI.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 124)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.grpSinglePhaseSFan)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(432, 153)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'grpSinglePhaseSFan
        '
        Me.grpSinglePhaseSFan.Controls.Add(Me.optJustECMotor)
        Me.grpSinglePhaseSFan.Controls.Add(Me.optReplaceFanAndMotor)
        Me.grpSinglePhaseSFan.Controls.Add(Me.optNot1Phase)
        Me.grpSinglePhaseSFan.Location = New System.Drawing.Point(225, 42)
        Me.grpSinglePhaseSFan.Name = "grpSinglePhaseSFan"
        Me.grpSinglePhaseSFan.Size = New System.Drawing.Size(158, 105)
        Me.grpSinglePhaseSFan.TabIndex = 30
        Me.grpSinglePhaseSFan.TabStop = False
        Me.grpSinglePhaseSFan.Text = "Single Phase Supply Fan"
        '
        'optJustECMotor
        '
        Me.optJustECMotor.AutoSize = True
        Me.optJustECMotor.Location = New System.Drawing.Point(6, 65)
        Me.optJustECMotor.Name = "optJustECMotor"
        Me.optJustECMotor.Size = New System.Drawing.Size(109, 17)
        Me.optJustECMotor.TabIndex = 2
        Me.optJustECMotor.Text = "Use JCI EC Motor"
        Me.optJustECMotor.UseVisualStyleBackColor = True
        '
        'optReplaceFanAndMotor
        '
        Me.optReplaceFanAndMotor.AutoSize = True
        Me.optReplaceFanAndMotor.Location = New System.Drawing.Point(6, 42)
        Me.optReplaceFanAndMotor.Name = "optReplaceFanAndMotor"
        Me.optReplaceFanAndMotor.Size = New System.Drawing.Size(137, 17)
        Me.optReplaceFanAndMotor.TabIndex = 1
        Me.optReplaceFanAndMotor.Text = "Replace Fan and Motor"
        Me.optReplaceFanAndMotor.UseVisualStyleBackColor = True
        '
        'optNot1Phase
        '
        Me.optNot1Phase.AutoSize = True
        Me.optNot1Phase.Checked = True
        Me.optNot1Phase.Location = New System.Drawing.Point(6, 19)
        Me.optNot1Phase.Name = "optNot1Phase"
        Me.optNot1Phase.Size = New System.Drawing.Size(144, 17)
        Me.optNot1Phase.TabIndex = 0
        Me.optNot1Phase.TabStop = True
        Me.optNot1Phase.Text = "Not a Single Phase SFan"
        Me.optNot1Phase.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbAuxPanelOpts)
        Me.GroupBox3.Controls.Add(Me.optUseAux)
        Me.GroupBox3.Controls.Add(Me.optNoAux)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 105)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Auxillary Control Panel"
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
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(20, 22)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(5, 3)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(385, 124)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 153)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkECMotorStaging)
        Me.GroupBox2.Controls.Add(Me.chkIntellispeed)
        Me.GroupBox2.Controls.Add(Me.chkHSFaninRH)
        Me.GroupBox2.Controls.Add(Me.chkUnitisHeatPump)
        Me.GroupBox2.Controls.Add(Me.chkFisenMWUCtrl)
        Me.GroupBox2.Controls.Add(Me.chkFisenSATCtrl)
        Me.GroupBox2.Controls.Add(Me.chkFisenDSPCtrl)
        Me.GroupBox2.Controls.Add(Me.optFisenVAV)
        Me.GroupBox2.Controls.Add(Me.optSEVAV)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(375, 137)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LCVAV Style"
        '
        'chkECMotorStaging
        '
        Me.chkECMotorStaging.AutoSize = True
        Me.chkECMotorStaging.Location = New System.Drawing.Point(219, 80)
        Me.chkECMotorStaging.Margin = New System.Windows.Forms.Padding(2)
        Me.chkECMotorStaging.Name = "chkECMotorStaging"
        Me.chkECMotorStaging.Size = New System.Drawing.Size(128, 17)
        Me.chkECMotorStaging.TabIndex = 15
        Me.chkECMotorStaging.Text = "ECM Staged not VFD"
        Me.chkECMotorStaging.UseVisualStyleBackColor = True
        '
        'chkIntellispeed
        '
        Me.chkIntellispeed.AutoSize = True
        Me.chkIntellispeed.Location = New System.Drawing.Point(219, 18)
        Me.chkIntellispeed.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIntellispeed.Name = "chkIntellispeed"
        Me.chkIntellispeed.Size = New System.Drawing.Size(159, 17)
        Me.chkIntellispeed.TabIndex = 14
        Me.chkIntellispeed.Text = "Configure SE for Intellispeed"
        Me.chkIntellispeed.UseVisualStyleBackColor = True
        '
        'chkHSFaninRH
        '
        Me.chkHSFaninRH.AutoSize = True
        Me.chkHSFaninRH.Location = New System.Drawing.Point(219, 38)
        Me.chkHSFaninRH.Margin = New System.Windows.Forms.Padding(2)
        Me.chkHSFaninRH.Name = "chkHSFaninRH"
        Me.chkHSFaninRH.Size = New System.Drawing.Size(152, 17)
        Me.chkHSFaninRH.TabIndex = 13
        Me.chkHSFaninRH.Text = "High Speed Fan in Reheat"
        Me.chkHSFaninRH.UseVisualStyleBackColor = True
        '
        'chkUnitisHeatPump
        '
        Me.chkUnitisHeatPump.AutoSize = True
        Me.chkUnitisHeatPump.Location = New System.Drawing.Point(219, 59)
        Me.chkUnitisHeatPump.Margin = New System.Windows.Forms.Padding(2)
        Me.chkUnitisHeatPump.Name = "chkUnitisHeatPump"
        Me.chkUnitisHeatPump.Size = New System.Drawing.Size(111, 17)
        Me.chkUnitisHeatPump.TabIndex = 12
        Me.chkUnitisHeatPump.Text = "Unit is Heat Pump"
        Me.chkUnitisHeatPump.UseVisualStyleBackColor = True
        '
        'chkFisenMWUCtrl
        '
        Me.chkFisenMWUCtrl.AutoSize = True
        Me.chkFisenMWUCtrl.Enabled = False
        Me.chkFisenMWUCtrl.Location = New System.Drawing.Point(26, 104)
        Me.chkFisenMWUCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFisenMWUCtrl.Name = "chkFisenMWUCtrl"
        Me.chkFisenMWUCtrl.Size = New System.Drawing.Size(177, 17)
        Me.chkFisenMWUCtrl.TabIndex = 11
        Me.chkFisenMWUCtrl.Text = "MWU/DWU Control for Heating"
        Me.chkFisenMWUCtrl.UseVisualStyleBackColor = True
        '
        'chkFisenSATCtrl
        '
        Me.chkFisenSATCtrl.AutoSize = True
        Me.chkFisenSATCtrl.Enabled = False
        Me.chkFisenSATCtrl.Location = New System.Drawing.Point(26, 82)
        Me.chkFisenSATCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFisenSATCtrl.Name = "chkFisenSATCtrl"
        Me.chkFisenSATCtrl.Size = New System.Drawing.Size(136, 17)
        Me.chkFisenSATCtrl.TabIndex = 10
        Me.chkFisenSATCtrl.Text = "SAT Control for Cooling"
        Me.chkFisenSATCtrl.UseVisualStyleBackColor = True
        '
        'chkFisenDSPCtrl
        '
        Me.chkFisenDSPCtrl.AutoSize = True
        Me.chkFisenDSPCtrl.Enabled = False
        Me.chkFisenDSPCtrl.Location = New System.Drawing.Point(26, 60)
        Me.chkFisenDSPCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFisenDSPCtrl.Name = "chkFisenDSPCtrl"
        Me.chkFisenDSPCtrl.Size = New System.Drawing.Size(159, 17)
        Me.chkFisenDSPCtrl.TabIndex = 9
        Me.chkFisenDSPCtrl.Text = "Duct Static Pressure Control"
        Me.chkFisenDSPCtrl.UseVisualStyleBackColor = True
        '
        'optFisenVAV
        '
        Me.optFisenVAV.AutoSize = True
        Me.optFisenVAV.Location = New System.Drawing.Point(4, 38)
        Me.optFisenVAV.Margin = New System.Windows.Forms.Padding(2)
        Me.optFisenVAV.Name = "optFisenVAV"
        Me.optFisenVAV.Size = New System.Drawing.Size(101, 17)
        Me.optFisenVAV.TabIndex = 1
        Me.optFisenVAV.Text = "LCVAV by Fisen"
        Me.optFisenVAV.UseVisualStyleBackColor = True
        '
        'optSEVAV
        '
        Me.optSEVAV.AutoSize = True
        Me.optSEVAV.Checked = True
        Me.optSEVAV.Location = New System.Drawing.Point(4, 17)
        Me.optSEVAV.Margin = New System.Windows.Forms.Padding(2)
        Me.optSEVAV.Name = "optSEVAV"
        Me.optSEVAV.Size = New System.Drawing.Size(176, 17)
        Me.optSEVAV.TabIndex = 0
        Me.optSEVAV.TabStop = True
        Me.optSEVAV.Text = "Utilize Existing SE Control Board"
        Me.optSEVAV.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 124)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.chkNoPerformance)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 153)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'chkNoPerformance
        '
        Me.chkNoPerformance.AutoSize = True
        Me.chkNoPerformance.Checked = True
        Me.chkNoPerformance.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoPerformance.Enabled = False
        Me.chkNoPerformance.Location = New System.Drawing.Point(6, 6)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(248, 17)
        Me.chkNoPerformance.TabIndex = 28
        Me.chkNoPerformance.Text = "No Performance to Report for This Modification"
        Me.chkNoPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(385, 124)
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
        Me.DebugPage.Size = New System.Drawing.Size(432, 153)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Location = New System.Drawing.Point(349, 196)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(96, 29)
        Me.cmdDesignCautions.TabIndex = 8
        Me.cmdDesignCautions.Text = "Design Cautions"
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'frmLCVAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLCVAV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LCVAV"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpSinglePhaseSFan.ResumeLayout(False)
        Me.grpSinglePhaseSFan.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFisenMWUCtrl As CheckBox
    Friend WithEvents chkFisenSATCtrl As CheckBox
    Friend WithEvents chkFisenDSPCtrl As CheckBox
    Friend WithEvents optFisenVAV As RadioButton
    Friend WithEvents optSEVAV As RadioButton
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents chkUnitisHeatPump As CheckBox
    Friend WithEvents chkHSFaninRH As CheckBox
    Friend WithEvents chkIntellispeed As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optDrivebyField As RadioButton
    Friend WithEvents optDrivebyFisen As RadioButton
    Friend WithEvents optDrivebyJCI As RadioButton
    Friend WithEvents grpSinglePhaseSFan As GroupBox
    Friend WithEvents optJustECMotor As RadioButton
    Friend WithEvents optReplaceFanAndMotor As RadioButton
    Friend WithEvents optNot1Phase As RadioButton
    Friend WithEvents chkECMotorStaging As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cmdDesignCautions As Button
End Class
