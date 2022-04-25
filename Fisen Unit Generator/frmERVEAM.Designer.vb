<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmERVEAM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmERVEAM))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDWStyle = New System.Windows.Forms.ComboBox()
        Me.optSingleWall = New System.Windows.Forms.RadioButton()
        Me.optDoubleWall = New System.Windows.Forms.RadioButton()
        Me.grpDPPCkt = New System.Windows.Forms.GroupBox()
        Me.optDPPEmergency = New System.Windows.Forms.RadioButton()
        Me.optDPPCommercial = New System.Windows.Forms.RadioButton()
        Me.optDPPNA = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.grpAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdLoadMod = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optUnfinished = New System.Windows.Forms.RadioButton()
        Me.optPainted = New System.Windows.Forms.RadioButton()
        Me.chkRTUPowered = New System.Windows.Forms.CheckBox()
        Me.chkLocalDisconect = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optFanAxial = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optEconAirIsoOpenClose = New System.Windows.Forms.RadioButton()
        Me.optEconAirIsoModulating = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optEconReliefAirIsoModulating = New System.Windows.Forms.RadioButton()
        Me.optEconReliefAirIsoOpenClose = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optERVIsoModulating = New System.Windows.Forms.RadioButton()
        Me.optERVIsoOpenClose = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optReliefFanCtrlOther = New System.Windows.Forms.RadioButton()
        Me.optReliefFanCtrlTrack = New System.Windows.Forms.RadioButton()
        Me.optEconAirIsoBarometric = New System.Windows.Forms.RadioButton()
        Me.optEconReliefAirIsoBarometric = New System.Windows.Forms.RadioButton()
        Me.optERVIsoBarometric = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDPPCkt.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(573, 283)
        Me.TabControl1.TabIndex = 8
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkLocalDisconect)
        Me.tpgConditions.Controls.Add(Me.chkRTUPowered)
        Me.tpgConditions.Controls.Add(Me.GroupBox2)
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.grpDPPCkt)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(565, 257)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDWStyle)
        Me.GroupBox1.Controls.Add(Me.optSingleWall)
        Me.GroupBox1.Controls.Add(Me.optDoubleWall)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 82)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Module Construction"
        '
        'cmbDWStyle
        '
        Me.cmbDWStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDWStyle.FormattingEnabled = True
        Me.cmbDWStyle.Items.AddRange(New Object() {"n/a", "Unselected", "Galvanized", "Stainless Steel"})
        Me.cmbDWStyle.Location = New System.Drawing.Point(23, 38)
        Me.cmbDWStyle.Name = "cmbDWStyle"
        Me.cmbDWStyle.Size = New System.Drawing.Size(121, 21)
        Me.cmbDWStyle.TabIndex = 79
        '
        'optSingleWall
        '
        Me.optSingleWall.AutoSize = True
        Me.optSingleWall.Location = New System.Drawing.Point(11, 59)
        Me.optSingleWall.Name = "optSingleWall"
        Me.optSingleWall.Size = New System.Drawing.Size(78, 17)
        Me.optSingleWall.TabIndex = 15
        Me.optSingleWall.Text = "Single Wall"
        Me.optSingleWall.UseVisualStyleBackColor = True
        '
        'optDoubleWall
        '
        Me.optDoubleWall.AutoSize = True
        Me.optDoubleWall.Checked = True
        Me.optDoubleWall.Location = New System.Drawing.Point(11, 20)
        Me.optDoubleWall.Name = "optDoubleWall"
        Me.optDoubleWall.Size = New System.Drawing.Size(83, 17)
        Me.optDoubleWall.TabIndex = 14
        Me.optDoubleWall.TabStop = True
        Me.optDoubleWall.Text = "Double Wall"
        Me.optDoubleWall.UseVisualStyleBackColor = True
        '
        'grpDPPCkt
        '
        Me.grpDPPCkt.Controls.Add(Me.optDPPEmergency)
        Me.grpDPPCkt.Controls.Add(Me.optDPPCommercial)
        Me.grpDPPCkt.Controls.Add(Me.optDPPNA)
        Me.grpDPPCkt.Location = New System.Drawing.Point(440, 6)
        Me.grpDPPCkt.Name = "grpDPPCkt"
        Me.grpDPPCkt.Size = New System.Drawing.Size(119, 100)
        Me.grpDPPCkt.TabIndex = 77
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
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(518, 228)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.Label2)
        Me.tpgOptions.Controls.Add(Me.Label1)
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.grpAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(565, 257)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(4, 232)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 31
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'grpAuxPanel
        '
        Me.grpAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.grpAuxPanel.Controls.Add(Me.optUseAux)
        Me.grpAuxPanel.Controls.Add(Me.optNoAux)
        Me.grpAuxPanel.Location = New System.Drawing.Point(5, 42)
        Me.grpAuxPanel.Name = "grpAuxPanel"
        Me.grpAuxPanel.Size = New System.Drawing.Size(214, 105)
        Me.grpAuxPanel.TabIndex = 29
        Me.grpAuxPanel.TabStop = False
        Me.grpAuxPanel.Text = "Auxilary Control Panel"
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
        Me.optUseAux.Size = New System.Drawing.Size(149, 17)
        Me.optUseAux.TabIndex = 1
        Me.optUseAux.TabStop = True
        Me.optUseAux.Text = "Use Auxilary Control Panel"
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
        Me.cmdDoneOptions.Location = New System.Drawing.Point(518, 228)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox7)
        Me.tpgControls.Controls.Add(Me.GroupBox6)
        Me.tpgControls.Controls.Add(Me.GroupBox5)
        Me.tpgControls.Controls.Add(Me.GroupBox4)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(565, 257)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(518, 228)
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
        Me.tpgPerformance.Size = New System.Drawing.Size(565, 257)
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
        Me.btnDonePerf.Location = New System.Drawing.Point(518, 228)
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
        Me.DebugPage.Size = New System.Drawing.Size(565, 257)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(172, 313)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 20
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(94, 301)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 19
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(16, 301)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(437, 301)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 84
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(473, 301)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 83
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(545, 301)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 82
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(509, 301)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 81
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdLoadMod
        '
        Me.cmdLoadMod.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.LoadFileIconSmall
        Me.cmdLoadMod.Location = New System.Drawing.Point(401, 301)
        Me.cmdLoadMod.Name = "cmdLoadMod"
        Me.cmdLoadMod.Size = New System.Drawing.Size(30, 29)
        Me.cmdLoadMod.TabIndex = 80
        Me.cmdLoadMod.Text = "L"
        Me.cmdLoadMod.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optUnfinished)
        Me.GroupBox2.Controls.Add(Me.optPainted)
        Me.GroupBox2.Location = New System.Drawing.Point(165, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(89, 82)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Module Finish"
        '
        'optUnfinished
        '
        Me.optUnfinished.AutoSize = True
        Me.optUnfinished.Location = New System.Drawing.Point(11, 43)
        Me.optUnfinished.Name = "optUnfinished"
        Me.optUnfinished.Size = New System.Drawing.Size(75, 17)
        Me.optUnfinished.TabIndex = 15
        Me.optUnfinished.Text = "Unfinished"
        Me.optUnfinished.UseVisualStyleBackColor = True
        '
        'optPainted
        '
        Me.optPainted.AutoSize = True
        Me.optPainted.Checked = True
        Me.optPainted.Location = New System.Drawing.Point(11, 20)
        Me.optPainted.Name = "optPainted"
        Me.optPainted.Size = New System.Drawing.Size(61, 17)
        Me.optPainted.TabIndex = 14
        Me.optPainted.TabStop = True
        Me.optPainted.Text = "Painted"
        Me.optPainted.UseVisualStyleBackColor = True
        '
        'chkRTUPowered
        '
        Me.chkRTUPowered.AutoSize = True
        Me.chkRTUPowered.Location = New System.Drawing.Point(6, 94)
        Me.chkRTUPowered.Name = "chkRTUPowered"
        Me.chkRTUPowered.Size = New System.Drawing.Size(174, 17)
        Me.chkRTUPowered.TabIndex = 80
        Me.chkRTUPowered.Text = "SPP - Wired to RTU Main Lugs"
        Me.chkRTUPowered.UseVisualStyleBackColor = True
        '
        'chkLocalDisconect
        '
        Me.chkLocalDisconect.AutoSize = True
        Me.chkLocalDisconect.Location = New System.Drawing.Point(6, 117)
        Me.chkLocalDisconect.Name = "chkLocalDisconect"
        Me.chkLocalDisconect.Size = New System.Drawing.Size(154, 17)
        Me.chkLocalDisconect.TabIndex = 81
        Me.chkLocalDisconect.Text = "Local Disconnect/Unfused"
        Me.chkLocalDisconect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "(Base Unit/Not EAM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "(Base Unit/Not EAM)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optFanAxial)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 43)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fan Type"
        '
        'optFanAxial
        '
        Me.optFanAxial.AutoSize = True
        Me.optFanAxial.Checked = True
        Me.optFanAxial.Location = New System.Drawing.Point(6, 19)
        Me.optFanAxial.Name = "optFanAxial"
        Me.optFanAxial.Size = New System.Drawing.Size(114, 17)
        Me.optFanAxial.TabIndex = 1
        Me.optFanAxial.TabStop = True
        Me.optFanAxial.Text = "Axial/Propeller Fan"
        Me.optFanAxial.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optEconAirIsoBarometric)
        Me.GroupBox4.Controls.Add(Me.optEconAirIsoModulating)
        Me.GroupBox4.Controls.Add(Me.optEconAirIsoOpenClose)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 91)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Econ Air Iso. Damper"
        '
        'optEconAirIsoOpenClose
        '
        Me.optEconAirIsoOpenClose.AutoSize = True
        Me.optEconAirIsoOpenClose.Checked = True
        Me.optEconAirIsoOpenClose.Location = New System.Drawing.Point(6, 19)
        Me.optEconAirIsoOpenClose.Name = "optEconAirIsoOpenClose"
        Me.optEconAirIsoOpenClose.Size = New System.Drawing.Size(82, 17)
        Me.optEconAirIsoOpenClose.TabIndex = 1
        Me.optEconAirIsoOpenClose.Text = "Open/Close"
        Me.optEconAirIsoOpenClose.UseVisualStyleBackColor = True
        '
        'optEconAirIsoModulating
        '
        Me.optEconAirIsoModulating.AutoSize = True
        Me.optEconAirIsoModulating.Enabled = False
        Me.optEconAirIsoModulating.Location = New System.Drawing.Point(6, 42)
        Me.optEconAirIsoModulating.Name = "optEconAirIsoModulating"
        Me.optEconAirIsoModulating.Size = New System.Drawing.Size(77, 17)
        Me.optEconAirIsoModulating.TabIndex = 2
        Me.optEconAirIsoModulating.Text = "Modulating"
        Me.optEconAirIsoModulating.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optEconReliefAirIsoBarometric)
        Me.GroupBox5.Controls.Add(Me.optEconReliefAirIsoModulating)
        Me.GroupBox5.Controls.Add(Me.optEconReliefAirIsoOpenClose)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 103)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(170, 91)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Econ Relief Air Iso Damper"
        '
        'optEconReliefAirIsoModulating
        '
        Me.optEconReliefAirIsoModulating.AutoSize = True
        Me.optEconReliefAirIsoModulating.Enabled = False
        Me.optEconReliefAirIsoModulating.Location = New System.Drawing.Point(6, 42)
        Me.optEconReliefAirIsoModulating.Name = "optEconReliefAirIsoModulating"
        Me.optEconReliefAirIsoModulating.Size = New System.Drawing.Size(77, 17)
        Me.optEconReliefAirIsoModulating.TabIndex = 2
        Me.optEconReliefAirIsoModulating.Text = "Modulating"
        Me.optEconReliefAirIsoModulating.UseVisualStyleBackColor = True
        '
        'optEconReliefAirIsoOpenClose
        '
        Me.optEconReliefAirIsoOpenClose.AutoSize = True
        Me.optEconReliefAirIsoOpenClose.Checked = True
        Me.optEconReliefAirIsoOpenClose.Location = New System.Drawing.Point(6, 19)
        Me.optEconReliefAirIsoOpenClose.Name = "optEconReliefAirIsoOpenClose"
        Me.optEconReliefAirIsoOpenClose.Size = New System.Drawing.Size(82, 17)
        Me.optEconReliefAirIsoOpenClose.TabIndex = 1
        Me.optEconReliefAirIsoOpenClose.Text = "Open/Close"
        Me.optEconReliefAirIsoOpenClose.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optERVIsoBarometric)
        Me.GroupBox6.Controls.Add(Me.optERVIsoModulating)
        Me.GroupBox6.Controls.Add(Me.optERVIsoOpenClose)
        Me.GroupBox6.Location = New System.Drawing.Point(182, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(170, 91)
        Me.GroupBox6.TabIndex = 37
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ERV Iso. Damper"
        '
        'optERVIsoModulating
        '
        Me.optERVIsoModulating.AutoSize = True
        Me.optERVIsoModulating.Enabled = False
        Me.optERVIsoModulating.Location = New System.Drawing.Point(6, 42)
        Me.optERVIsoModulating.Name = "optERVIsoModulating"
        Me.optERVIsoModulating.Size = New System.Drawing.Size(77, 17)
        Me.optERVIsoModulating.TabIndex = 2
        Me.optERVIsoModulating.Text = "Modulating"
        Me.optERVIsoModulating.UseVisualStyleBackColor = True
        '
        'optERVIsoOpenClose
        '
        Me.optERVIsoOpenClose.AutoSize = True
        Me.optERVIsoOpenClose.Checked = True
        Me.optERVIsoOpenClose.Location = New System.Drawing.Point(6, 19)
        Me.optERVIsoOpenClose.Name = "optERVIsoOpenClose"
        Me.optERVIsoOpenClose.Size = New System.Drawing.Size(82, 17)
        Me.optERVIsoOpenClose.TabIndex = 1
        Me.optERVIsoOpenClose.Text = "Open/Close"
        Me.optERVIsoOpenClose.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optReliefFanCtrlOther)
        Me.GroupBox7.Controls.Add(Me.optReliefFanCtrlTrack)
        Me.GroupBox7.Location = New System.Drawing.Point(358, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(170, 91)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Econ Relief Air Fan Ctrl"
        '
        'optReliefFanCtrlOther
        '
        Me.optReliefFanCtrlOther.AutoSize = True
        Me.optReliefFanCtrlOther.Enabled = False
        Me.optReliefFanCtrlOther.Location = New System.Drawing.Point(6, 42)
        Me.optReliefFanCtrlOther.Name = "optReliefFanCtrlOther"
        Me.optReliefFanCtrlOther.Size = New System.Drawing.Size(51, 17)
        Me.optReliefFanCtrlOther.TabIndex = 2
        Me.optReliefFanCtrlOther.Text = "Other"
        Me.optReliefFanCtrlOther.UseVisualStyleBackColor = True
        '
        'optReliefFanCtrlTrack
        '
        Me.optReliefFanCtrlTrack.AutoSize = True
        Me.optReliefFanCtrlTrack.Checked = True
        Me.optReliefFanCtrlTrack.Location = New System.Drawing.Point(6, 19)
        Me.optReliefFanCtrlTrack.Name = "optReliefFanCtrlTrack"
        Me.optReliefFanCtrlTrack.Size = New System.Drawing.Size(134, 17)
        Me.optReliefFanCtrlTrack.TabIndex = 1
        Me.optReliefFanCtrlTrack.Text = "Tracks RTU OAD Pos."
        Me.optReliefFanCtrlTrack.UseVisualStyleBackColor = True
        '
        'optEconAirIsoBarometric
        '
        Me.optEconAirIsoBarometric.AutoSize = True
        Me.optEconAirIsoBarometric.Enabled = False
        Me.optEconAirIsoBarometric.Location = New System.Drawing.Point(6, 65)
        Me.optEconAirIsoBarometric.Name = "optEconAirIsoBarometric"
        Me.optEconAirIsoBarometric.Size = New System.Drawing.Size(75, 17)
        Me.optEconAirIsoBarometric.TabIndex = 3
        Me.optEconAirIsoBarometric.Text = "Barometric"
        Me.optEconAirIsoBarometric.UseVisualStyleBackColor = True
        '
        'optEconReliefAirIsoBarometric
        '
        Me.optEconReliefAirIsoBarometric.AutoSize = True
        Me.optEconReliefAirIsoBarometric.Enabled = False
        Me.optEconReliefAirIsoBarometric.Location = New System.Drawing.Point(6, 65)
        Me.optEconReliefAirIsoBarometric.Name = "optEconReliefAirIsoBarometric"
        Me.optEconReliefAirIsoBarometric.Size = New System.Drawing.Size(75, 17)
        Me.optEconReliefAirIsoBarometric.TabIndex = 4
        Me.optEconReliefAirIsoBarometric.Text = "Barometric"
        Me.optEconReliefAirIsoBarometric.UseVisualStyleBackColor = True
        '
        'optERVIsoBarometric
        '
        Me.optERVIsoBarometric.AutoSize = True
        Me.optERVIsoBarometric.Enabled = False
        Me.optERVIsoBarometric.Location = New System.Drawing.Point(6, 65)
        Me.optERVIsoBarometric.Name = "optERVIsoBarometric"
        Me.optERVIsoBarometric.Size = New System.Drawing.Size(75, 17)
        Me.optERVIsoBarometric.TabIndex = 5
        Me.optERVIsoBarometric.Text = "Barometric"
        Me.optERVIsoBarometric.UseVisualStyleBackColor = True
        '
        'frmERVEAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(597, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdLoadMod)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmERVEAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERV Economizer Assist Module"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDPPCkt.ResumeLayout(False)
        Me.grpDPPCkt.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpAuxPanel.ResumeLayout(False)
        Me.grpAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents grpAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents grpDPPCkt As GroupBox
    Friend WithEvents optDPPEmergency As RadioButton
    Friend WithEvents optDPPCommercial As RadioButton
    Friend WithEvents optDPPNA As RadioButton
    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdLoadMod As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbDWStyle As ComboBox
    Friend WithEvents optSingleWall As RadioButton
    Friend WithEvents optDoubleWall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optUnfinished As RadioButton
    Friend WithEvents optPainted As RadioButton
    Friend WithEvents chkLocalDisconect As CheckBox
    Friend WithEvents chkRTUPowered As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optFanAxial As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optERVIsoModulating As RadioButton
    Friend WithEvents optERVIsoOpenClose As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optEconReliefAirIsoModulating As RadioButton
    Friend WithEvents optEconReliefAirIsoOpenClose As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optEconAirIsoModulating As RadioButton
    Friend WithEvents optEconAirIsoOpenClose As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents optReliefFanCtrlOther As RadioButton
    Friend WithEvents optReliefFanCtrlTrack As RadioButton
    Friend WithEvents optEconAirIsoBarometric As RadioButton
    Friend WithEvents optEconReliefAirIsoBarometric As RadioButton
    Friend WithEvents optERVIsoBarometric As RadioButton
End Class
