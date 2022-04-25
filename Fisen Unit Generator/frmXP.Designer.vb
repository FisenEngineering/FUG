<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXP))
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.txtCDGDescription = New System.Windows.Forms.TextBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optBU_SE_Fisen_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fact_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_Other = New System.Windows.Forms.RadioButton()
        Me.optBU_IPU_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fact_FisenWires = New System.Windows.Forms.RadioButton()
        Me.optBU_IPU_FisenWires = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fisen_FisenWires = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.tpgValves = New System.Windows.Forms.TabPage()
        Me.btnDoneValve = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdResetCDG = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdLoadMod = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgValves.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 421)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 87
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgValves)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 391)
        Me.TabControl1.TabIndex = 86
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.cmdResetCDG)
        Me.tpgConditions.Controls.Add(Me.txtCDGDescription)
        Me.tpgConditions.Controls.Add(Me.cmbGroup)
        Me.tpgConditions.Controls.Add(Me.cmbDivision)
        Me.tpgConditions.Controls.Add(Me.cmbClass)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(768, 365)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'txtCDGDescription
        '
        Me.txtCDGDescription.Location = New System.Drawing.Point(6, 46)
        Me.txtCDGDescription.Multiline = True
        Me.txtCDGDescription.Name = "txtCDGDescription"
        Me.txtCDGDescription.ReadOnly = True
        Me.txtCDGDescription.Size = New System.Drawing.Size(375, 94)
        Me.txtCDGDescription.TabIndex = 29
        Me.txtCDGDescription.Text = "Undefined"
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"Unselected"})
        Me.cmbGroup.Location = New System.Drawing.Point(178, 19)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(203, 21)
        Me.cmbGroup.TabIndex = 28
        '
        'cmbDivision
        '
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Items.AddRange(New Object() {"Unselected"})
        Me.cmbDivision.Location = New System.Drawing.Point(92, 19)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(80, 21)
        Me.cmbDivision.TabIndex = 27
        '
        'cmbClass
        '
        Me.cmbClass.AutoCompleteCustomSource.AddRange(New String() {"Unselected", "Class I", "Class II", "Class III"})
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Unselected", "Class I", "Class II", "Class III"})
        Me.cmbClass.Location = New System.Drawing.Point(6, 19)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(80, 21)
        Me.cmbClass.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Division"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Class"
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(721, 336)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 22
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(768, 365)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(6, 151)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 47
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Enabled = False
        Me.fraAuxPanel.Location = New System.Drawing.Point(221, 104)
        Me.fraAuxPanel.Name = "fraAuxPanel"
        Me.fraAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.fraAuxPanel.TabIndex = 46
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
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(721, 336)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 23
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.GroupBox3)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(768, 365)
        Me.tpgControls.TabIndex = 4
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(178, 159)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 30
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(194, 182)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 31
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optBU_SE_Fisen_Unwired)
        Me.GroupBox3.Controls.Add(Me.optBU_SE_Fact_Unwired)
        Me.GroupBox3.Controls.Add(Me.optBU_Other)
        Me.GroupBox3.Controls.Add(Me.optBU_IPU_Unwired)
        Me.GroupBox3.Controls.Add(Me.optBU_SE_Fact_FisenWires)
        Me.GroupBox3.Controls.Add(Me.optBU_IPU_FisenWires)
        Me.GroupBox3.Controls.Add(Me.optBU_SE_Fisen_FisenWires)
        Me.GroupBox3.Location = New System.Drawing.Point(178, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 138)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Base Unit Control"
        '
        'optBU_SE_Fisen_Unwired
        '
        Me.optBU_SE_Fisen_Unwired.AutoSize = True
        Me.optBU_SE_Fisen_Unwired.Location = New System.Drawing.Point(134, 116)
        Me.optBU_SE_Fisen_Unwired.Name = "optBU_SE_Fisen_Unwired"
        Me.optBU_SE_Fisen_Unwired.Size = New System.Drawing.Size(123, 17)
        Me.optBU_SE_Fisen_Unwired.TabIndex = 6
        Me.optBU_SE_Fisen_Unwired.Text = "SE by Fisen Unwired"
        Me.optBU_SE_Fisen_Unwired.UseVisualStyleBackColor = True
        '
        'optBU_SE_Fact_Unwired
        '
        Me.optBU_SE_Fact_Unwired.AutoSize = True
        Me.optBU_SE_Fact_Unwired.Location = New System.Drawing.Point(134, 93)
        Me.optBU_SE_Fact_Unwired.Name = "optBU_SE_Fact_Unwired"
        Me.optBU_SE_Fact_Unwired.Size = New System.Drawing.Size(113, 17)
        Me.optBU_SE_Fact_Unwired.TabIndex = 5
        Me.optBU_SE_Fact_Unwired.Text = "SE by JCI Unwired"
        Me.optBU_SE_Fact_Unwired.UseVisualStyleBackColor = True
        '
        'optBU_Other
        '
        Me.optBU_Other.AutoSize = True
        Me.optBU_Other.Checked = True
        Me.optBU_Other.Location = New System.Drawing.Point(6, 115)
        Me.optBU_Other.Name = "optBU_Other"
        Me.optBU_Other.Size = New System.Drawing.Size(42, 17)
        Me.optBU_Other.TabIndex = 4
        Me.optBU_Other.TabStop = True
        Me.optBU_Other.Text = "n/a"
        Me.optBU_Other.UseVisualStyleBackColor = True
        '
        'optBU_IPU_Unwired
        '
        Me.optBU_IPU_Unwired.AutoSize = True
        Me.optBU_IPU_Unwired.Location = New System.Drawing.Point(134, 70)
        Me.optBU_IPU_Unwired.Name = "optBU_IPU_Unwired"
        Me.optBU_IPU_Unwired.Size = New System.Drawing.Size(91, 17)
        Me.optBU_IPU_Unwired.TabIndex = 3
        Me.optBU_IPU_Unwired.Text = "IPU - Unwired"
        Me.optBU_IPU_Unwired.UseVisualStyleBackColor = True
        '
        'optBU_SE_Fact_FisenWires
        '
        Me.optBU_SE_Fact_FisenWires.AutoSize = True
        Me.optBU_SE_Fact_FisenWires.Enabled = False
        Me.optBU_SE_Fact_FisenWires.Location = New System.Drawing.Point(6, 24)
        Me.optBU_SE_Fact_FisenWires.Name = "optBU_SE_Fact_FisenWires"
        Me.optBU_SE_Fact_FisenWires.Size = New System.Drawing.Size(175, 17)
        Me.optBU_SE_Fact_FisenWires.TabIndex = 2
        Me.optBU_SE_Fact_FisenWires.Text = "SE 4 Stage by JCI - Fisen Wires"
        Me.optBU_SE_Fact_FisenWires.UseVisualStyleBackColor = True
        '
        'optBU_IPU_FisenWires
        '
        Me.optBU_IPU_FisenWires.AutoSize = True
        Me.optBU_IPU_FisenWires.Enabled = False
        Me.optBU_IPU_FisenWires.Location = New System.Drawing.Point(6, 70)
        Me.optBU_IPU_FisenWires.Name = "optBU_IPU_FisenWires"
        Me.optBU_IPU_FisenWires.Size = New System.Drawing.Size(107, 17)
        Me.optBU_IPU_FisenWires.TabIndex = 1
        Me.optBU_IPU_FisenWires.Text = "IPU - Fisen Wires"
        Me.optBU_IPU_FisenWires.UseVisualStyleBackColor = True
        '
        'optBU_SE_Fisen_FisenWires
        '
        Me.optBU_SE_Fisen_FisenWires.AutoSize = True
        Me.optBU_SE_Fisen_FisenWires.Enabled = False
        Me.optBU_SE_Fisen_FisenWires.Location = New System.Drawing.Point(6, 47)
        Me.optBU_SE_Fisen_FisenWires.Name = "optBU_SE_Fisen_FisenWires"
        Me.optBU_SE_Fisen_FisenWires.Size = New System.Drawing.Size(185, 17)
        Me.optBU_SE_Fisen_FisenWires.TabIndex = 0
        Me.optBU_SE_Fisen_FisenWires.Text = "SE 4 Stage by Fisen - Fisen Wires"
        Me.optBU_SE_Fisen_FisenWires.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(721, 336)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 24
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(768, 365)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(721, 336)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 9
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'tpgValves
        '
        Me.tpgValves.Controls.Add(Me.btnDoneValve)
        Me.tpgValves.Location = New System.Drawing.Point(4, 22)
        Me.tpgValves.Name = "tpgValves"
        Me.tpgValves.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgValves.Size = New System.Drawing.Size(768, 365)
        Me.tpgValves.TabIndex = 3
        Me.tpgValves.Text = "Valves"
        Me.tpgValves.UseVisualStyleBackColor = True
        '
        'btnDoneValve
        '
        Me.btnDoneValve.Location = New System.Drawing.Point(721, 336)
        Me.btnDoneValve.Name = "btnDoneValve"
        Me.btnDoneValve.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneValve.TabIndex = 10
        Me.btnDoneValve.Text = ">"
        Me.btnDoneValve.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 409)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 85
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 409)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 84
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdResetCDG
        '
        Me.cmdResetCDG.BackgroundImage = Global.Fisen_Unit_Generator.My.Resources.Resources.Reset24x24
        Me.cmdResetCDG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdResetCDG.Location = New System.Drawing.Point(387, 19)
        Me.cmdResetCDG.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdResetCDG.Name = "cmdResetCDG"
        Me.cmdResetCDG.Size = New System.Drawing.Size(21, 21)
        Me.cmdResetCDG.TabIndex = 30
        Me.cmdResetCDG.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(646, 405)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 92
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(682, 405)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 91
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdLoadMod
        '
        Me.cmdLoadMod.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.LoadFileIconSmall
        Me.cmdLoadMod.Location = New System.Drawing.Point(610, 405)
        Me.cmdLoadMod.Name = "cmdLoadMod"
        Me.cmdLoadMod.Size = New System.Drawing.Size(30, 29)
        Me.cmdLoadMod.TabIndex = 90
        Me.cmdLoadMod.Text = "L"
        Me.cmdLoadMod.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(718, 405)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 89
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(754, 405)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 88
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'frmXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.cmdLoadMod)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmXP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Explosion Proof"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgValves.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents cmdLoadMod As Button
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optBU_SE_Fisen_Unwired As RadioButton
    Friend WithEvents optBU_SE_Fact_Unwired As RadioButton
    Friend WithEvents optBU_Other As RadioButton
    Friend WithEvents optBU_IPU_Unwired As RadioButton
    Friend WithEvents optBU_SE_Fact_FisenWires As RadioButton
    Friend WithEvents optBU_IPU_FisenWires As RadioButton
    Friend WithEvents optBU_SE_Fisen_FisenWires As RadioButton
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents tpgValves As TabPage
    Friend WithEvents btnDoneValve As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtCDGDescription As TextBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents cmbDivision As ComboBox
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdResetCDG As Button
End Class
