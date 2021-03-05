<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBiPolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBiPolar))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkShareXfmr = New System.Windows.Forms.CheckBox()
        Me.cmbBipolarStyle = New System.Windows.Forms.ComboBox()
        Me.grpDPPCkt = New System.Windows.Forms.GroupBox()
        Me.optDPPEmergency = New System.Windows.Forms.RadioButton()
        Me.optDPPCommercial = New System.Windows.Forms.RadioButton()
        Me.optDPPNA = New System.Windows.Forms.RadioButton()
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
        Me.grpMnAOptions = New System.Windows.Forms.GroupBox()
        Me.optBACnetOnlyMnA = New System.Windows.Forms.RadioButton()
        Me.chkBACnetMnA = New System.Windows.Forms.CheckBox()
        Me.optNoMnA = New System.Windows.Forms.RadioButton()
        Me.optLocalMnA = New System.Windows.Forms.RadioButton()
        Me.optRemoteMnA = New System.Windows.Forms.RadioButton()
        Me.chkEMControlsOnly = New System.Windows.Forms.CheckBox()
        Me.cmbCustomControls = New System.Windows.Forms.ComboBox()
        Me.optCtrlCustom = New System.Windows.Forms.RadioButton()
        Me.optCtrlWithSupplyFan = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optASE = New System.Windows.Forms.RadioButton()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.optCtrl247 = New System.Windows.Forms.RadioButton()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.tpgNotesPage = New System.Windows.Forms.TabPage()
        Me.btnDoneNotes = New System.Windows.Forms.Button()
        Me.txtDesignNotesSoft = New System.Windows.Forms.TextBox()
        Me.txtDesignNotesHard = New System.Windows.Forms.TextBox()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdLoadMod = New System.Windows.Forms.Button()
        Me.txtPerfNotes = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.grpDPPCkt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.grpMnAOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgNotesPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgNotesPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 225)
        Me.TabControl1.TabIndex = 26
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkShareXfmr)
        Me.tpgConditions.Controls.Add(Me.cmbBipolarStyle)
        Me.tpgConditions.Controls.Add(Me.grpDPPCkt)
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
        'chkShareXfmr
        '
        Me.chkShareXfmr.AutoSize = True
        Me.chkShareXfmr.Location = New System.Drawing.Point(7, 113)
        Me.chkShareXfmr.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShareXfmr.Name = "chkShareXfmr"
        Me.chkShareXfmr.Size = New System.Drawing.Size(181, 17)
        Me.chkShareXfmr.TabIndex = 50
        Me.chkShareXfmr.Text = "Share Transformer with UVLights"
        Me.chkShareXfmr.UseVisualStyleBackColor = True
        '
        'cmbBipolarStyle
        '
        Me.cmbBipolarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBipolarStyle.FormattingEnabled = True
        Me.cmbBipolarStyle.Items.AddRange(New Object() {"Use Standard", "CP Plasma Bar #PB-066"})
        Me.cmbBipolarStyle.Location = New System.Drawing.Point(6, 137)
        Me.cmbBipolarStyle.Name = "cmbBipolarStyle"
        Me.cmbBipolarStyle.Size = New System.Drawing.Size(200, 21)
        Me.cmbBipolarStyle.TabIndex = 9
        '
        'grpDPPCkt
        '
        Me.grpDPPCkt.Controls.Add(Me.optDPPEmergency)
        Me.grpDPPCkt.Controls.Add(Me.optDPPCommercial)
        Me.grpDPPCkt.Controls.Add(Me.optDPPNA)
        Me.grpDPPCkt.Location = New System.Drawing.Point(212, 6)
        Me.grpDPPCkt.Name = "grpDPPCkt"
        Me.grpDPPCkt.Size = New System.Drawing.Size(119, 100)
        Me.grpDPPCkt.TabIndex = 8
        Me.grpDPPCkt.TabStop = False
        Me.grpDPPCkt.Text = "DPP Power Circuit"
        Me.grpDPPCkt.Visible = False
        '
        'optDPPEmergency
        '
        Me.optDPPEmergency.AutoSize = True
        Me.optDPPEmergency.Location = New System.Drawing.Point(6, 19)
        Me.optDPPEmergency.Name = "optDPPEmergency"
        Me.optDPPEmergency.Size = New System.Drawing.Size(110, 17)
        Me.optDPPEmergency.TabIndex = 13
        Me.optDPPEmergency.Text = "Emergency Circuit"
        Me.optDPPEmergency.UseVisualStyleBackColor = True
        '
        'optDPPCommercial
        '
        Me.optDPPCommercial.AutoSize = True
        Me.optDPPCommercial.Location = New System.Drawing.Point(6, 42)
        Me.optDPPCommercial.Name = "optDPPCommercial"
        Me.optDPPCommercial.Size = New System.Drawing.Size(111, 17)
        Me.optDPPCommercial.TabIndex = 12
        Me.optDPPCommercial.Text = "Commercial Circuit"
        Me.optDPPCommercial.UseVisualStyleBackColor = True
        '
        'optDPPNA
        '
        Me.optDPPNA.AutoSize = True
        Me.optDPPNA.Checked = True
        Me.optDPPNA.Location = New System.Drawing.Point(6, 65)
        Me.optDPPNA.Name = "optDPPNA"
        Me.optDPPNA.Size = New System.Drawing.Size(45, 17)
        Me.optDPPNA.TabIndex = 11
        Me.optDPPNA.TabStop = True
        Me.optDPPNA.Text = "N/A"
        Me.optDPPNA.UseVisualStyleBackColor = True
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
        Me.optInstUSEvap.Checked = True
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
        Me.optInstDSEvap.Location = New System.Drawing.Point(6, 43)
        Me.optInstDSEvap.Name = "optInstDSEvap"
        Me.optInstDSEvap.Size = New System.Drawing.Size(151, 17)
        Me.optInstDSEvap.TabIndex = 1
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
        Me.tpgControls.Controls.Add(Me.grpMnAOptions)
        Me.tpgControls.Controls.Add(Me.chkEMControlsOnly)
        Me.tpgControls.Controls.Add(Me.cmbCustomControls)
        Me.tpgControls.Controls.Add(Me.optCtrlCustom)
        Me.tpgControls.Controls.Add(Me.optCtrlWithSupplyFan)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.optCtrl247)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 199)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpMnAOptions
        '
        Me.grpMnAOptions.Controls.Add(Me.optBACnetOnlyMnA)
        Me.grpMnAOptions.Controls.Add(Me.chkBACnetMnA)
        Me.grpMnAOptions.Controls.Add(Me.optNoMnA)
        Me.grpMnAOptions.Controls.Add(Me.optLocalMnA)
        Me.grpMnAOptions.Controls.Add(Me.optRemoteMnA)
        Me.grpMnAOptions.Enabled = False
        Me.grpMnAOptions.Location = New System.Drawing.Point(6, 103)
        Me.grpMnAOptions.Name = "grpMnAOptions"
        Me.grpMnAOptions.Size = New System.Drawing.Size(373, 70)
        Me.grpMnAOptions.TabIndex = 14
        Me.grpMnAOptions.TabStop = False
        Me.grpMnAOptions.Text = "Monitor and Alarm Options"
        '
        'optBACnetOnlyMnA
        '
        Me.optBACnetOnlyMnA.AutoSize = True
        Me.optBACnetOnlyMnA.Enabled = False
        Me.optBACnetOnlyMnA.Location = New System.Drawing.Point(249, 42)
        Me.optBACnetOnlyMnA.Name = "optBACnetOnlyMnA"
        Me.optBACnetOnlyMnA.Size = New System.Drawing.Size(110, 17)
        Me.optBACnetOnlyMnA.TabIndex = 15
        Me.optBACnetOnlyMnA.Text = "BACnet Only MnA"
        Me.optBACnetOnlyMnA.UseVisualStyleBackColor = True
        '
        'chkBACnetMnA
        '
        Me.chkBACnetMnA.AutoSize = True
        Me.chkBACnetMnA.Location = New System.Drawing.Point(14, 43)
        Me.chkBACnetMnA.Name = "chkBACnetMnA"
        Me.chkBACnetMnA.Size = New System.Drawing.Size(150, 17)
        Me.chkBACnetMnA.TabIndex = 14
        Me.chkBACnetMnA.Text = "BACnet Monitor and Alarm"
        Me.chkBACnetMnA.UseVisualStyleBackColor = True
        '
        'optNoMnA
        '
        Me.optNoMnA.AutoSize = True
        Me.optNoMnA.Checked = True
        Me.optNoMnA.Enabled = False
        Me.optNoMnA.Location = New System.Drawing.Point(249, 20)
        Me.optNoMnA.Name = "optNoMnA"
        Me.optNoMnA.Size = New System.Drawing.Size(94, 17)
        Me.optNoMnA.TabIndex = 2
        Me.optNoMnA.TabStop = True
        Me.optNoMnA.Text = "No MnA Panel"
        Me.optNoMnA.UseVisualStyleBackColor = True
        '
        'optLocalMnA
        '
        Me.optLocalMnA.AutoSize = True
        Me.optLocalMnA.Enabled = False
        Me.optLocalMnA.Location = New System.Drawing.Point(137, 20)
        Me.optLocalMnA.Name = "optLocalMnA"
        Me.optLocalMnA.Size = New System.Drawing.Size(106, 17)
        Me.optLocalMnA.TabIndex = 1
        Me.optLocalMnA.Text = "Local MnA Panel"
        Me.optLocalMnA.UseVisualStyleBackColor = True
        '
        'optRemoteMnA
        '
        Me.optRemoteMnA.AutoSize = True
        Me.optRemoteMnA.Location = New System.Drawing.Point(14, 20)
        Me.optRemoteMnA.Name = "optRemoteMnA"
        Me.optRemoteMnA.Size = New System.Drawing.Size(117, 17)
        Me.optRemoteMnA.TabIndex = 0
        Me.optRemoteMnA.Text = "Remote MnA Panel"
        Me.optRemoteMnA.UseVisualStyleBackColor = True
        '
        'chkEMControlsOnly
        '
        Me.chkEMControlsOnly.AutoSize = True
        Me.chkEMControlsOnly.Checked = True
        Me.chkEMControlsOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEMControlsOnly.Location = New System.Drawing.Point(6, 176)
        Me.chkEMControlsOnly.Name = "chkEMControlsOnly"
        Me.chkEMControlsOnly.Size = New System.Drawing.Size(107, 17)
        Me.chkEMControlsOnly.TabIndex = 13
        Me.chkEMControlsOnly.Text = "EM Controls Only"
        Me.chkEMControlsOnly.UseVisualStyleBackColor = True
        '
        'cmbCustomControls
        '
        Me.cmbCustomControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomControls.Enabled = False
        Me.cmbCustomControls.FormattingEnabled = True
        Me.cmbCustomControls.Items.AddRange(New Object() {"Not Required"})
        Me.cmbCustomControls.Location = New System.Drawing.Point(25, 75)
        Me.cmbCustomControls.Name = "cmbCustomControls"
        Me.cmbCustomControls.Size = New System.Drawing.Size(266, 21)
        Me.cmbCustomControls.TabIndex = 11
        '
        'optCtrlCustom
        '
        Me.optCtrlCustom.AutoSize = True
        Me.optCtrlCustom.Enabled = False
        Me.optCtrlCustom.Location = New System.Drawing.Point(6, 52)
        Me.optCtrlCustom.Name = "optCtrlCustom"
        Me.optCtrlCustom.Size = New System.Drawing.Size(101, 17)
        Me.optCtrlCustom.TabIndex = 9
        Me.optCtrlCustom.Text = "Custom Controls"
        Me.optCtrlCustom.UseVisualStyleBackColor = True
        '
        'optCtrlWithSupplyFan
        '
        Me.optCtrlWithSupplyFan.AutoSize = True
        Me.optCtrlWithSupplyFan.Checked = True
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
        Me.optCtrl247.Location = New System.Drawing.Point(6, 6)
        Me.optCtrl247.Name = "optCtrl247"
        Me.optCtrl247.Size = New System.Drawing.Size(97, 17)
        Me.optCtrl247.TabIndex = 1
        Me.optCtrl247.Text = "24/7 Operation"
        Me.optCtrl247.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.txtPerfNotes)
        Me.tpgPerformance.Controls.Add(Me.Label1)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 199)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Performance Notes:"
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
        'tpgNotesPage
        '
        Me.tpgNotesPage.Controls.Add(Me.btnDoneNotes)
        Me.tpgNotesPage.Controls.Add(Me.txtDesignNotesSoft)
        Me.tpgNotesPage.Controls.Add(Me.txtDesignNotesHard)
        Me.tpgNotesPage.Location = New System.Drawing.Point(4, 22)
        Me.tpgNotesPage.Name = "tpgNotesPage"
        Me.tpgNotesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgNotesPage.Size = New System.Drawing.Size(432, 199)
        Me.tpgNotesPage.TabIndex = 3
        Me.tpgNotesPage.Text = "Notes"
        Me.tpgNotesPage.UseVisualStyleBackColor = True
        '
        'btnDoneNotes
        '
        Me.btnDoneNotes.Location = New System.Drawing.Point(385, 170)
        Me.btnDoneNotes.Name = "btnDoneNotes"
        Me.btnDoneNotes.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneNotes.TabIndex = 21
        Me.btnDoneNotes.Text = ">"
        Me.btnDoneNotes.UseVisualStyleBackColor = True
        '
        'txtDesignNotesSoft
        '
        Me.txtDesignNotesSoft.Location = New System.Drawing.Point(6, 76)
        Me.txtDesignNotesSoft.Multiline = True
        Me.txtDesignNotesSoft.Name = "txtDesignNotesSoft"
        Me.txtDesignNotesSoft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesignNotesSoft.Size = New System.Drawing.Size(420, 74)
        Me.txtDesignNotesSoft.TabIndex = 20
        '
        'txtDesignNotesHard
        '
        Me.txtDesignNotesHard.Location = New System.Drawing.Point(6, 6)
        Me.txtDesignNotesHard.Multiline = True
        Me.txtDesignNotesHard.Name = "txtDesignNotesHard"
        Me.txtDesignNotesHard.ReadOnly = True
        Me.txtDesignNotesHard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesignNotesHard.Size = New System.Drawing.Size(420, 64)
        Me.txtDesignNotesHard.TabIndex = 19
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 255)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 31
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(90, 243)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 28
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 243)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(381, 243)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 30
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(417, 243)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 29
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(345, 243)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 63
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(309, 243)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 76
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdLoadMod
        '
        Me.cmdLoadMod.Enabled = False
        Me.cmdLoadMod.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.LoadFileIconSmall
        Me.cmdLoadMod.Location = New System.Drawing.Point(273, 243)
        Me.cmdLoadMod.Name = "cmdLoadMod"
        Me.cmdLoadMod.Size = New System.Drawing.Size(30, 29)
        Me.cmdLoadMod.TabIndex = 88
        Me.cmdLoadMod.Text = "L"
        Me.cmdLoadMod.UseVisualStyleBackColor = True
        '
        'txtPerfNotes
        '
        Me.txtPerfNotes.Location = New System.Drawing.Point(6, 19)
        Me.txtPerfNotes.Multiline = True
        Me.txtPerfNotes.Name = "txtPerfNotes"
        Me.txtPerfNotes.ReadOnly = True
        Me.txtPerfNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPerfNotes.Size = New System.Drawing.Size(420, 145)
        Me.txtPerfNotes.TabIndex = 20
        '
        'frmBiPolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(457, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdLoadMod)
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBiPolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bipolar Ionization Subsystem"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.grpDPPCkt.ResumeLayout(False)
        Me.grpDPPCkt.PerformLayout()
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
        Me.grpMnAOptions.ResumeLayout(False)
        Me.grpMnAOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.tpgNotesPage.ResumeLayout(False)
        Me.tpgNotesPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optPwrDedicated As RadioButton
    Friend WithEvents optPwrConvOutlet As RadioButton
    Friend WithEvents optPwrUnitPower As RadioButton
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkInstHGRHCoil As CheckBox
    Friend WithEvents optInstUSEvap As RadioButton
    Friend WithEvents optInstDSEvap As RadioButton
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkEMControlsOnly As CheckBox
    Friend WithEvents cmbCustomControls As ComboBox
    Friend WithEvents optCtrlCustom As RadioButton
    Friend WithEvents optCtrlWithSupplyFan As RadioButton
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optASE As RadioButton
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents optCtrl247 As RadioButton
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents tpgNotesPage As TabPage
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents grpDPPCkt As GroupBox
    Friend WithEvents optDPPEmergency As RadioButton
    Friend WithEvents optDPPCommercial As RadioButton
    Friend WithEvents optDPPNA As RadioButton
    Friend WithEvents cmbBipolarStyle As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShareXfmr As CheckBox
    Friend WithEvents grpMnAOptions As GroupBox
    Friend WithEvents optBACnetOnlyMnA As RadioButton
    Friend WithEvents chkBACnetMnA As CheckBox
    Friend WithEvents optNoMnA As RadioButton
    Friend WithEvents optLocalMnA As RadioButton
    Friend WithEvents optRemoteMnA As RadioButton
    Friend WithEvents btnDoneNotes As Button
    Friend WithEvents txtDesignNotesSoft As TextBox
    Friend WithEvents txtDesignNotesHard As TextBox
    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdLoadMod As Button
    Friend WithEvents txtPerfNotes As TextBox
End Class
