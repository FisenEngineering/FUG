<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMGH_R
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
        Me.components = New System.ComponentModel.Container()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputCap = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkPropane = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.cmbCustomControls = New System.Windows.Forms.ComboBox()
        Me.chkSATReset = New System.Windows.Forms.CheckBox()
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
        Me.TTfrmMGH_R = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkUnitAtElevation = New System.Windows.Forms.CheckBox()
        Me.txtElevation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 195)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 195)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(6, 6)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(40, 20)
        Me.txtHeatAF.TabIndex = 0
        Me.txtHeatAF.Text = "88888"
        Me.txtHeatAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(6, 32)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(40, 20)
        Me.txtEAT.TabIndex = 2
        Me.txtEAT.Text = "88888"
        Me.txtEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Input Capacity(mbh)"
        '
        'txtInputCap
        '
        Me.txtInputCap.Location = New System.Drawing.Point(6, 59)
        Me.txtInputCap.Name = "txtInputCap"
        Me.txtInputCap.Size = New System.Drawing.Size(40, 20)
        Me.txtInputCap.TabIndex = 4
        Me.txtInputCap.Text = "88888"
        Me.txtInputCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.TabControl1.Size = New System.Drawing.Size(440, 179)
        Me.TabControl1.TabIndex = 6
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.txtElevation)
        Me.tpgConditions.Controls.Add(Me.chkUnitAtElevation)
        Me.tpgConditions.Controls.Add(Me.chkPropane)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.txtInputCap)
        Me.tpgConditions.Controls.Add(Me.txtHeatAF)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 153)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chkPropane
        '
        Me.chkPropane.AutoSize = True
        Me.chkPropane.Enabled = False
        Me.chkPropane.Location = New System.Drawing.Point(6, 85)
        Me.chkPropane.Name = "chkPropane"
        Me.chkPropane.Size = New System.Drawing.Size(212, 17)
        Me.chkPropane.TabIndex = 7
        Me.chkPropane.Text = "Unit Will be Field Converted to Propane"
        Me.chkPropane.UseVisualStyleBackColor = True
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
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
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
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Enabled = False
        Me.fraAuxPanel.Location = New System.Drawing.Point(3, 57)
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
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(17, 22)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(3, 3)
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
        Me.tpgControls.Controls.Add(Me.cmbCustomControls)
        Me.tpgControls.Controls.Add(Me.chkSATReset)
        Me.tpgControls.Controls.Add(Me.optCustomCtrl)
        Me.tpgControls.Controls.Add(Me.opt100OACtrls)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.chkTempering)
        Me.tpgControls.Controls.Add(Me.optSATCtrl)
        Me.tpgControls.Controls.Add(Me.optGBAS)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 153)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'cmbCustomControls
        '
        Me.cmbCustomControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomControls.Enabled = False
        Me.cmbCustomControls.FormattingEnabled = True
        Me.cmbCustomControls.Items.AddRange(New Object() {"IPU Enabled/Fisen Controlled Modulation"})
        Me.cmbCustomControls.Location = New System.Drawing.Point(113, 126)
        Me.cmbCustomControls.Name = "cmbCustomControls"
        Me.cmbCustomControls.Size = New System.Drawing.Size(266, 21)
        Me.cmbCustomControls.TabIndex = 11
        '
        'chkSATReset
        '
        Me.chkSATReset.AutoSize = True
        Me.chkSATReset.Location = New System.Drawing.Point(41, 53)
        Me.chkSATReset.Name = "chkSATReset"
        Me.chkSATReset.Size = New System.Drawing.Size(209, 17)
        Me.chkSATReset.TabIndex = 10
        Me.chkSATReset.Text = "Supply Air Temperature Setpoint Reset"
        Me.TTfrmMGH_R.SetToolTip(Me.chkSATReset, "Not Available on Series 40 Design")
        Me.chkSATReset.UseVisualStyleBackColor = True
        '
        'optCustomCtrl
        '
        Me.optCustomCtrl.AutoSize = True
        Me.optCustomCtrl.Location = New System.Drawing.Point(6, 127)
        Me.optCustomCtrl.Name = "optCustomCtrl"
        Me.optCustomCtrl.Size = New System.Drawing.Size(101, 17)
        Me.optCustomCtrl.TabIndex = 9
        Me.optCustomCtrl.Text = "Custom Controls"
        Me.optCustomCtrl.UseVisualStyleBackColor = True
        '
        'opt100OACtrls
        '
        Me.opt100OACtrls.AutoSize = True
        Me.opt100OACtrls.Location = New System.Drawing.Point(6, 80)
        Me.opt100OACtrls.Name = "opt100OACtrls"
        Me.opt100OACtrls.Size = New System.Drawing.Size(129, 17)
        Me.opt100OACtrls.TabIndex = 8
        Me.opt100OACtrls.TabStop = True
        Me.opt100OACtrls.Text = "100% Outdoor Air Unit"
        Me.opt100OACtrls.UseVisualStyleBackColor = True
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
        Me.optIPU.Enabled = False
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
        'chkTempering
        '
        Me.chkTempering.AutoSize = True
        Me.chkTempering.Checked = True
        Me.chkTempering.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTempering.Location = New System.Drawing.Point(41, 30)
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
        Me.optSATCtrl.Location = New System.Drawing.Point(6, 6)
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
        Me.optGBAS.Location = New System.Drawing.Point(6, 103)
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
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 153)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Delta T"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(6, 85)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(40, 20)
        Me.txtDeltaT.TabIndex = 12
        Me.txtDeltaT.Text = "88888"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Leaving Air Temp(ºF)"
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(6, 59)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(40, 20)
        Me.txtLAT.TabIndex = 10
        Me.txtLAT.Text = "88888"
        '
        'txtOutCap
        '
        Me.txtOutCap.Location = New System.Drawing.Point(6, 6)
        Me.txtOutCap.Name = "txtOutCap"
        Me.txtOutCap.Size = New System.Drawing.Size(40, 20)
        Me.txtOutCap.TabIndex = 6
        Me.txtOutCap.Text = "88888"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SSE(%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Output Capacity(mbh)"
        '
        'txtSSE
        '
        Me.txtSSE.Location = New System.Drawing.Point(6, 32)
        Me.txtSSE.Name = "txtSSE"
        Me.txtSSE.Size = New System.Drawing.Size(40, 20)
        Me.txtSSE.TabIndex = 8
        Me.txtSSE.Text = "88888"
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
        'chkUnitAtElevation
        '
        Me.chkUnitAtElevation.AutoSize = True
        Me.chkUnitAtElevation.Location = New System.Drawing.Point(6, 108)
        Me.chkUnitAtElevation.Name = "chkUnitAtElevation"
        Me.chkUnitAtElevation.Size = New System.Drawing.Size(114, 17)
        Me.chkUnitAtElevation.TabIndex = 8
        Me.chkUnitAtElevation.Text = "Unit is at Elevation"
        Me.chkUnitAtElevation.UseVisualStyleBackColor = True
        '
        'txtElevation
        '
        Me.txtElevation.Location = New System.Drawing.Point(126, 106)
        Me.txtElevation.Name = "txtElevation"
        Me.txtElevation.Size = New System.Drawing.Size(40, 20)
        Me.txtElevation.TabIndex = 9
        Me.txtElevation.Text = "0"
        Me.txtElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(172, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Elevation (ft.)"
        '
        'frmMGH_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmMGH_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modulating Gas Heat Retrofit"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputCap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents chkTempering As CheckBox
    Friend WithEvents optSATCtrl As RadioButton
    Friend WithEvents optGBAS As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents txtOutCap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSSE As TextBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents opt100OACtrls As RadioButton
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents optCustomCtrl As RadioButton
    Friend WithEvents chkSATReset As CheckBox
    Friend WithEvents TTfrmMGH_R As ToolTip
    Friend WithEvents chkPropane As CheckBox
    Friend WithEvents cmbCustomControls As ComboBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtElevation As TextBox
    Friend WithEvents chkUnitAtElevation As CheckBox
End Class
