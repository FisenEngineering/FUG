<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewFan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewFan))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkS10BottomRAMonitor = New System.Windows.Forms.CheckBox()
        Me.grpFlowConfig = New System.Windows.Forms.GroupBox()
        Me.optHorizFlow = New System.Windows.Forms.RadioButton()
        Me.optDownFlow = New System.Windows.Forms.RadioButton()
        Me.cmdStaticSummary = New System.Windows.Forms.Button()
        Me.lblKFactor = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkTSPatElev = New System.Windows.Forms.CheckBox()
        Me.chkSFatElev = New System.Windows.Forms.CheckBox()
        Me.chkUSPatElev = New System.Windows.Forms.CheckBox()
        Me.chkESPatElev = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbExistingMotor = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbFanType = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtElevation = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUSPSafetyFactor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTSP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtUSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtESP = New System.Windows.Forms.TextBox()
        Me.txtAirflow = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkReliefHoodsShipLoose = New System.Windows.Forms.CheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.grpReliefDampers = New System.Windows.Forms.GroupBox()
        Me.optControlRelief = New System.Windows.Forms.RadioButton()
        Me.optBaroRelief = New System.Windows.Forms.RadioButton()
        Me.optNoRelief = New System.Windows.Forms.RadioButton()
        Me.chkRemoteVFDKeypad = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbNewMotorHP = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optODP = New System.Windows.Forms.RadioButton()
        Me.optTEFC = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optNewBypass = New System.Windows.Forms.RadioButton()
        Me.optReuseBypass = New System.Windows.Forms.RadioButton()
        Me.optNoBypass = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optNewMotor = New System.Windows.Forms.RadioButton()
        Me.optReuseMotor = New System.Windows.Forms.RadioButton()
        Me.optReplaceMotor = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optNewVFD = New System.Windows.Forms.RadioButton()
        Me.optReuseVFD = New System.Windows.Forms.RadioButton()
        Me.optReplaceVFD = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optIso2 = New System.Windows.Forms.RadioButton()
        Me.optIso1 = New System.Windows.Forms.RadioButton()
        Me.optIsoNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optDirectDrive = New System.Windows.Forms.RadioButton()
        Me.optBeltDrive = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optPropFan = New System.Windows.Forms.RadioButton()
        Me.optPlenumFan = New System.Windows.Forms.RadioButton()
        Me.optAFFan = New System.Windows.Forms.RadioButton()
        Me.optFCFan = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optVAV = New System.Windows.Forms.RadioButton()
        Me.optVFDBalancing = New System.Windows.Forms.RadioButton()
        Me.optCVSystem = New System.Windows.Forms.RadioButton()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.grpXFans = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.grpSFanCtrlOptions = New System.Windows.Forms.GroupBox()
        Me.chkSFanNetPointPiezo = New System.Windows.Forms.CheckBox()
        Me.chkSFanROandXmitPiezo = New System.Windows.Forms.CheckBox()
        Me.chkSFanROPiezo = New System.Windows.Forms.CheckBox()
        Me.grpRFanCtrlOptions = New System.Windows.Forms.GroupBox()
        Me.chkInletMeasuringStationFull = New System.Windows.Forms.CheckBox()
        Me.chkInletMeasuringStationWithXMit = New System.Windows.Forms.CheckBox()
        Me.chkInletMeasuringStationOnly = New System.Windows.Forms.CheckBox()
        Me.chkRFPiezoRingsNet = New System.Windows.Forms.CheckBox()
        Me.chkRFPiezoRingsXmitterOnly = New System.Windows.Forms.CheckBox()
        Me.chkRFPiezoRingsOnly = New System.Windows.Forms.CheckBox()
        Me.chkGBASReliefDamper = New System.Windows.Forms.CheckBox()
        Me.optGBASRFan = New System.Windows.Forms.RadioButton()
        Me.grpBSPControls = New System.Windows.Forms.GroupBox()
        Me.chkIPUModulateDamper = New System.Windows.Forms.CheckBox()
        Me.optBSPbyFisen = New System.Windows.Forms.RadioButton()
        Me.optBSPbySE = New System.Windows.Forms.RadioButton()
        Me.optBSPbyIPU = New System.Windows.Forms.RadioButton()
        Me.optTrackSupplyFan = New System.Windows.Forms.RadioButton()
        Me.optBldgStaticPressureCtrl = New System.Windows.Forms.RadioButton()
        Me.optNoControls = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFanbhpeach = New System.Windows.Forms.TextBox()
        Me.btnbhpeachWiz = New System.Windows.Forms.Button()
        Me.optContinental = New System.Windows.Forms.RadioButton()
        Me.optComefri = New System.Windows.Forms.RadioButton()
        Me.cmdPasteInlet = New System.Windows.Forms.Button()
        Me.cmdPasteOutlet = New System.Windows.Forms.Button()
        Me.cmdBlankInlet = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.nudFanCount = New System.Windows.Forms.NumericUpDown()
        Me.chkMultipleFans = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbFanSelected = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtMaxFanSpeed = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtIndBA5 = New System.Windows.Forms.TextBox()
        Me.txtIndBW = New System.Windows.Forms.TextBox()
        Me.txtOutdBA5 = New System.Windows.Forms.TextBox()
        Me.txtOutdBW = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInPWL8k = New System.Windows.Forms.TextBox()
        Me.txtInPWL4k = New System.Windows.Forms.TextBox()
        Me.txtInPWL2k = New System.Windows.Forms.TextBox()
        Me.txtInPWL1k = New System.Windows.Forms.TextBox()
        Me.txtInPWL500 = New System.Windows.Forms.TextBox()
        Me.txtInPWL250 = New System.Windows.Forms.TextBox()
        Me.txtInPWL125 = New System.Windows.Forms.TextBox()
        Me.txtInPWL63 = New System.Windows.Forms.TextBox()
        Me.txtOutPWL8k = New System.Windows.Forms.TextBox()
        Me.txtOutPWL4k = New System.Windows.Forms.TextBox()
        Me.txtOutPWL2k = New System.Windows.Forms.TextBox()
        Me.txtOutPWL1k = New System.Windows.Forms.TextBox()
        Me.txtOutPWL500 = New System.Windows.Forms.TextBox()
        Me.txtOutPWL250 = New System.Windows.Forms.TextBox()
        Me.txtOutPWL125 = New System.Windows.Forms.TextBox()
        Me.txtOutPWL63 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFanbhp = New System.Windows.Forms.TextBox()
        Me.txtFanRPM = New System.Windows.Forms.TextBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.tpgStaticSum = New System.Windows.Forms.TabPage()
        Me.cmdS20BottomSupply = New System.Windows.Forms.Button()
        Me.chkPwrExhaustPresent = New System.Windows.Forms.CheckBox()
        Me.cmdS40Supply = New System.Windows.Forms.Button()
        Me.cmdS10SideSupply = New System.Windows.Forms.Button()
        Me.cmdS20SideSupply = New System.Windows.Forms.Button()
        Me.cmdS100BEndReturn = New System.Windows.Forms.Button()
        Me.chkEconPresent = New System.Windows.Forms.CheckBox()
        Me.grpFilterStyle = New System.Windows.Forms.GroupBox()
        Me.opt6inch95 = New System.Windows.Forms.RadioButton()
        Me.opt6inch65 = New System.Windows.Forms.RadioButton()
        Me.opt4InchFilters = New System.Windows.Forms.RadioButton()
        Me.opt2InchFilters = New System.Windows.Forms.RadioButton()
        Me.lblHeatType = New System.Windows.Forms.Label()
        Me.cmbHeatBox = New System.Windows.Forms.ComboBox()
        Me.cmdS10BottomSupply = New System.Windows.Forms.Button()
        Me.cmdS10BottomReturn = New System.Windows.Forms.Button()
        Me.cmdS20SideReturn = New System.Windows.Forms.Button()
        Me.cmdS40BottomReturn = New System.Windows.Forms.Button()
        Me.cmdS20BottomReturn = New System.Windows.Forms.Button()
        Me.cmdS40EndReturn = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.dgvStaticSummary = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSTPStatic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colATPStatic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslblAirflow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblTSP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblESP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.tslblElevation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.grpFlowConfig.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpReliefDampers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.grpXFans.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.grpSFanCtrlOptions.SuspendLayout()
        Me.grpRFanCtrlOptions.SuspendLayout()
        Me.grpBSPControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        CType(Me.nudFanCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgStaticSum.SuspendLayout()
        Me.grpFilterStyle.SuspendLayout()
        CType(Me.dgvStaticSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(116, 461)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 461)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgStaticSum)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 441)
        Me.TabControl1.TabIndex = 8
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkS10BottomRAMonitor)
        Me.tpgConditions.Controls.Add(Me.grpFlowConfig)
        Me.tpgConditions.Controls.Add(Me.cmdStaticSummary)
        Me.tpgConditions.Controls.Add(Me.lblKFactor)
        Me.tpgConditions.Controls.Add(Me.Label32)
        Me.tpgConditions.Controls.Add(Me.chkTSPatElev)
        Me.tpgConditions.Controls.Add(Me.chkSFatElev)
        Me.tpgConditions.Controls.Add(Me.chkUSPatElev)
        Me.tpgConditions.Controls.Add(Me.chkESPatElev)
        Me.tpgConditions.Controls.Add(Me.Label20)
        Me.tpgConditions.Controls.Add(Me.cmbExistingMotor)
        Me.tpgConditions.Controls.Add(Me.Label19)
        Me.tpgConditions.Controls.Add(Me.cmbFanType)
        Me.tpgConditions.Controls.Add(Me.Label17)
        Me.tpgConditions.Controls.Add(Me.txtElevation)
        Me.tpgConditions.Controls.Add(Me.Label18)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtUSPSafetyFactor)
        Me.tpgConditions.Controls.Add(Me.Label16)
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.txtTSP)
        Me.tpgConditions.Controls.Add(Me.Label15)
        Me.tpgConditions.Controls.Add(Me.Label14)
        Me.tpgConditions.Controls.Add(Me.Label12)
        Me.tpgConditions.Controls.Add(Me.Label13)
        Me.tpgConditions.Controls.Add(Me.txtUSP)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.txtESP)
        Me.tpgConditions.Controls.Add(Me.txtAirflow)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(645, 415)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chkS10BottomRAMonitor
        '
        Me.chkS10BottomRAMonitor.AutoSize = True
        Me.chkS10BottomRAMonitor.Location = New System.Drawing.Point(384, 7)
        Me.chkS10BottomRAMonitor.Name = "chkS10BottomRAMonitor"
        Me.chkS10BottomRAMonitor.Size = New System.Drawing.Size(250, 17)
        Me.chkS10BottomRAMonitor.TabIndex = 74
        Me.chkS10BottomRAMonitor.Text = "RA Monitor Module for Bottom Return Series 10"
        Me.chkS10BottomRAMonitor.UseVisualStyleBackColor = True
        Me.chkS10BottomRAMonitor.Visible = False
        '
        'grpFlowConfig
        '
        Me.grpFlowConfig.Controls.Add(Me.optHorizFlow)
        Me.grpFlowConfig.Controls.Add(Me.optDownFlow)
        Me.grpFlowConfig.Location = New System.Drawing.Point(85, 71)
        Me.grpFlowConfig.Name = "grpFlowConfig"
        Me.grpFlowConfig.Size = New System.Drawing.Size(111, 74)
        Me.grpFlowConfig.TabIndex = 73
        Me.grpFlowConfig.TabStop = False
        Me.grpFlowConfig.Text = "Flow Configuration"
        '
        'optHorizFlow
        '
        Me.optHorizFlow.AutoSize = True
        Me.optHorizFlow.Location = New System.Drawing.Point(6, 42)
        Me.optHorizFlow.Name = "optHorizFlow"
        Me.optHorizFlow.Size = New System.Drawing.Size(72, 17)
        Me.optHorizFlow.TabIndex = 75
        Me.optHorizFlow.Text = "Horizontal"
        Me.optHorizFlow.UseVisualStyleBackColor = True
        '
        'optDownFlow
        '
        Me.optDownFlow.AutoSize = True
        Me.optDownFlow.Checked = True
        Me.optDownFlow.Location = New System.Drawing.Point(6, 19)
        Me.optDownFlow.Name = "optDownFlow"
        Me.optDownFlow.Size = New System.Drawing.Size(72, 17)
        Me.optDownFlow.TabIndex = 74
        Me.optDownFlow.TabStop = True
        Me.optDownFlow.Text = "Downflow"
        Me.optDownFlow.UseVisualStyleBackColor = True
        '
        'cmdStaticSummary
        '
        Me.cmdStaticSummary.Location = New System.Drawing.Point(468, 99)
        Me.cmdStaticSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdStaticSummary.Name = "cmdStaticSummary"
        Me.cmdStaticSummary.Size = New System.Drawing.Size(81, 22)
        Me.cmdStaticSummary.TabIndex = 4
        Me.cmdStaticSummary.Text = "Summary"
        Me.cmdStaticSummary.UseVisualStyleBackColor = True
        '
        'lblKFactor
        '
        Me.lblKFactor.AutoSize = True
        Me.lblKFactor.Location = New System.Drawing.Point(598, 226)
        Me.lblKFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKFactor.Name = "lblKFactor"
        Me.lblKFactor.Size = New System.Drawing.Size(28, 13)
        Me.lblKFactor.TabIndex = 72
        Me.lblKFactor.Text = "1.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(606, 42)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 13)
        Me.Label32.TabIndex = 71
        Me.Label32.Text = "Elev"
        '
        'chkTSPatElev
        '
        Me.chkTSPatElev.AutoSize = True
        Me.chkTSPatElev.Location = New System.Drawing.Point(616, 197)
        Me.chkTSPatElev.Name = "chkTSPatElev"
        Me.chkTSPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkTSPatElev.TabIndex = 70
        Me.chkTSPatElev.UseVisualStyleBackColor = True
        '
        'chkSFatElev
        '
        Me.chkSFatElev.AutoSize = True
        Me.chkSFatElev.Location = New System.Drawing.Point(616, 163)
        Me.chkSFatElev.Name = "chkSFatElev"
        Me.chkSFatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkSFatElev.TabIndex = 69
        Me.chkSFatElev.UseVisualStyleBackColor = True
        '
        'chkUSPatElev
        '
        Me.chkUSPatElev.AutoSize = True
        Me.chkUSPatElev.Location = New System.Drawing.Point(616, 135)
        Me.chkUSPatElev.Name = "chkUSPatElev"
        Me.chkUSPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkUSPatElev.TabIndex = 68
        Me.chkUSPatElev.UseVisualStyleBackColor = True
        '
        'chkESPatElev
        '
        Me.chkESPatElev.AutoSize = True
        Me.chkESPatElev.Location = New System.Drawing.Point(616, 74)
        Me.chkESPatElev.Name = "chkESPatElev"
        Me.chkESPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkESPatElev.TabIndex = 67
        Me.chkESPatElev.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 155)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "Existing Motor"
        '
        'cmbExistingMotor
        '
        Me.cmbExistingMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExistingMotor.FormattingEnabled = True
        Me.cmbExistingMotor.Items.AddRange(New Object() {"0.5", "1", "2", "3", "5", "7.5", "10", "15", "20", "25", "30", "40", "50", "None"})
        Me.cmbExistingMotor.Location = New System.Drawing.Point(85, 151)
        Me.cmbExistingMotor.Name = "cmbExistingMotor"
        Me.cmbExistingMotor.Size = New System.Drawing.Size(111, 21)
        Me.cmbExistingMotor.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(53, 42)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 13)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Fan"
        '
        'cmbFanType
        '
        Me.cmbFanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFanType.Enabled = False
        Me.cmbFanType.FormattingEnabled = True
        Me.cmbFanType.Items.AddRange(New Object() {"Supply Fan", "Return Fan", "Exhaust Fan"})
        Me.cmbFanType.Location = New System.Drawing.Point(85, 39)
        Me.cmbFanType.Name = "cmbFanType"
        Me.cmbFanType.Size = New System.Drawing.Size(111, 21)
        Me.cmbFanType.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(559, 226)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "ft."
        '
        'txtElevation
        '
        Me.txtElevation.Location = New System.Drawing.Point(468, 223)
        Me.txtElevation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtElevation.Name = "txtElevation"
        Me.txtElevation.Size = New System.Drawing.Size(81, 20)
        Me.txtElevation.TabIndex = 8
        Me.txtElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(409, 226)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Elevation"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = """wc"
        '
        'txtUSPSafetyFactor
        '
        Me.txtUSPSafetyFactor.Location = New System.Drawing.Point(468, 159)
        Me.txtUSPSafetyFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUSPSafetyFactor.Name = "txtUSPSafetyFactor"
        Me.txtUSPSafetyFactor.Size = New System.Drawing.Size(81, 20)
        Me.txtUSPSafetyFactor.TabIndex = 6
        Me.txtUSPSafetyFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(390, 162)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Safety Factor"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(559, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = """wc"
        '
        'txtTSP
        '
        Me.txtTSP.Location = New System.Drawing.Point(468, 193)
        Me.txtTSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTSP.Name = "txtTSP"
        Me.txtTSP.Size = New System.Drawing.Size(81, 20)
        Me.txtTSP.TabIndex = 7
        Me.txtTSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(355, 196)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Total Static Pressure"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(559, 74)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = """wc"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(559, 42)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "CFM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(559, 132)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = """wc"
        '
        'txtUSP
        '
        Me.txtUSP.Location = New System.Drawing.Point(468, 129)
        Me.txtUSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUSP.Name = "txtUSP"
        Me.txtUSP.Size = New System.Drawing.Size(81, 20)
        Me.txtUSP.TabIndex = 5
        Me.txtUSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Estimated Unit Static Pressure"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "External Static Pressure"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Airflow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtESP
        '
        Me.txtESP.Location = New System.Drawing.Point(468, 71)
        Me.txtESP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtESP.Name = "txtESP"
        Me.txtESP.Size = New System.Drawing.Size(81, 20)
        Me.txtESP.TabIndex = 3
        Me.txtESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(468, 39)
        Me.txtAirflow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(81, 20)
        Me.txtAirflow.TabIndex = 2
        Me.txtAirflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(582, 379)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 9
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkReliefHoodsShipLoose)
        Me.tpgOptions.Controls.Add(Me.Label36)
        Me.tpgOptions.Controls.Add(Me.grpReliefDampers)
        Me.tpgOptions.Controls.Add(Me.chkRemoteVFDKeypad)
        Me.tpgOptions.Controls.Add(Me.Label21)
        Me.tpgOptions.Controls.Add(Me.cmbNewMotorHP)
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.GroupBox8)
        Me.tpgOptions.Controls.Add(Me.GroupBox7)
        Me.tpgOptions.Controls.Add(Me.GroupBox6)
        Me.tpgOptions.Controls.Add(Me.GroupBox5)
        Me.tpgOptions.Controls.Add(Me.GroupBox4)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(645, 415)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkReliefHoodsShipLoose
        '
        Me.chkReliefHoodsShipLoose.AutoSize = True
        Me.chkReliefHoodsShipLoose.Location = New System.Drawing.Point(494, 344)
        Me.chkReliefHoodsShipLoose.Name = "chkReliefHoodsShipLoose"
        Me.chkReliefHoodsShipLoose.Size = New System.Drawing.Size(143, 17)
        Me.chkReliefHoodsShipLoose.TabIndex = 86
        Me.chkReliefHoodsShipLoose.Text = "Relief Hoods Ship Loose"
        Me.chkReliefHoodsShipLoose.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(176, 307)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(136, 13)
        Me.Label36.TabIndex = 69
        Me.Label36.Text = "(Total in Multi-Fan Systems)"
        '
        'grpReliefDampers
        '
        Me.grpReliefDampers.Controls.Add(Me.optControlRelief)
        Me.grpReliefDampers.Controls.Add(Me.optBaroRelief)
        Me.grpReliefDampers.Controls.Add(Me.optNoRelief)
        Me.grpReliefDampers.Location = New System.Drawing.Point(512, 5)
        Me.grpReliefDampers.Name = "grpReliefDampers"
        Me.grpReliefDampers.Size = New System.Drawing.Size(129, 129)
        Me.grpReliefDampers.TabIndex = 68
        Me.grpReliefDampers.TabStop = False
        Me.grpReliefDampers.Text = "Relief Dampers"
        '
        'optControlRelief
        '
        Me.optControlRelief.AutoSize = True
        Me.optControlRelief.Location = New System.Drawing.Point(4, 75)
        Me.optControlRelief.Name = "optControlRelief"
        Me.optControlRelief.Size = New System.Drawing.Size(75, 17)
        Me.optControlRelief.TabIndex = 18
        Me.optControlRelief.TabStop = True
        Me.optControlRelief.Text = "Modulated"
        Me.optControlRelief.UseVisualStyleBackColor = True
        '
        'optBaroRelief
        '
        Me.optBaroRelief.AutoSize = True
        Me.optBaroRelief.Location = New System.Drawing.Point(4, 48)
        Me.optBaroRelief.Name = "optBaroRelief"
        Me.optBaroRelief.Size = New System.Drawing.Size(75, 17)
        Me.optBaroRelief.TabIndex = 17
        Me.optBaroRelief.TabStop = True
        Me.optBaroRelief.Text = "Barometric"
        Me.optBaroRelief.UseVisualStyleBackColor = True
        '
        'optNoRelief
        '
        Me.optNoRelief.AutoSize = True
        Me.optNoRelief.Location = New System.Drawing.Point(4, 21)
        Me.optNoRelief.Name = "optNoRelief"
        Me.optNoRelief.Size = New System.Drawing.Size(51, 17)
        Me.optNoRelief.TabIndex = 16
        Me.optNoRelief.Text = "None"
        Me.optNoRelief.UseVisualStyleBackColor = True
        '
        'chkRemoteVFDKeypad
        '
        Me.chkRemoteVFDKeypad.AutoSize = True
        Me.chkRemoteVFDKeypad.Location = New System.Drawing.Point(392, 235)
        Me.chkRemoteVFDKeypad.Name = "chkRemoteVFDKeypad"
        Me.chkRemoteVFDKeypad.Size = New System.Drawing.Size(130, 17)
        Me.chkRemoteVFDKeypad.TabIndex = 67
        Me.chkRemoteVFDKeypad.Text = "Remote VFD Key Pad"
        Me.chkRemoteVFDKeypad.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(68, 285)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 13)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "New Motor/Drive hp"
        '
        'cmbNewMotorHP
        '
        Me.cmbNewMotorHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewMotorHP.FormattingEnabled = True
        Me.cmbNewMotorHP.Items.AddRange(New Object() {"0.5", "1", "1.5", "2", "3", "5", "7.5", "10", "15", "20", "25", "30", "40", "50", "n/a"})
        Me.cmbNewMotorHP.Location = New System.Drawing.Point(179, 282)
        Me.cmbNewMotorHP.Name = "cmbNewMotorHP"
        Me.cmbNewMotorHP.Size = New System.Drawing.Size(121, 21)
        Me.cmbNewMotorHP.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optODP)
        Me.GroupBox1.Controls.Add(Me.optTEFC)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 46)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motor Type"
        '
        'optODP
        '
        Me.optODP.AutoSize = True
        Me.optODP.Checked = True
        Me.optODP.Location = New System.Drawing.Point(176, 21)
        Me.optODP.Name = "optODP"
        Me.optODP.Size = New System.Drawing.Size(48, 17)
        Me.optODP.TabIndex = 16
        Me.optODP.TabStop = True
        Me.optODP.Text = "ODP"
        Me.optODP.UseVisualStyleBackColor = True
        '
        'optTEFC
        '
        Me.optTEFC.AutoSize = True
        Me.optTEFC.Location = New System.Drawing.Point(6, 21)
        Me.optTEFC.Name = "optTEFC"
        Me.optTEFC.Size = New System.Drawing.Size(52, 17)
        Me.optTEFC.TabIndex = 15
        Me.optTEFC.Text = "TEFC"
        Me.optTEFC.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optNewBypass)
        Me.GroupBox8.Controls.Add(Me.optReuseBypass)
        Me.GroupBox8.Controls.Add(Me.optNoBypass)
        Me.GroupBox8.Location = New System.Drawing.Point(525, 135)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(116, 94)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "VFD Bypass"
        '
        'optNewBypass
        '
        Me.optNewBypass.AutoSize = True
        Me.optNewBypass.Location = New System.Drawing.Point(2, 68)
        Me.optNewBypass.Name = "optNewBypass"
        Me.optNewBypass.Size = New System.Drawing.Size(86, 17)
        Me.optNewBypass.TabIndex = 18
        Me.optNewBypass.Text = "Provide New"
        Me.optNewBypass.UseVisualStyleBackColor = True
        '
        'optReuseBypass
        '
        Me.optReuseBypass.AutoSize = True
        Me.optReuseBypass.Location = New System.Drawing.Point(2, 43)
        Me.optReuseBypass.Name = "optReuseBypass"
        Me.optReuseBypass.Size = New System.Drawing.Size(83, 17)
        Me.optReuseBypass.TabIndex = 17
        Me.optReuseBypass.Text = "Use Existing"
        Me.optReuseBypass.UseVisualStyleBackColor = True
        '
        'optNoBypass
        '
        Me.optNoBypass.AutoSize = True
        Me.optNoBypass.Checked = True
        Me.optNoBypass.Location = New System.Drawing.Point(2, 19)
        Me.optNoBypass.Name = "optNoBypass"
        Me.optNoBypass.Size = New System.Drawing.Size(51, 17)
        Me.optNoBypass.TabIndex = 16
        Me.optNoBypass.TabStop = True
        Me.optNoBypass.Text = "None"
        Me.optNoBypass.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optNewMotor)
        Me.GroupBox7.Controls.Add(Me.optReuseMotor)
        Me.GroupBox7.Controls.Add(Me.optReplaceMotor)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 183)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(516, 46)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Motor"
        '
        'optNewMotor
        '
        Me.optNewMotor.AutoSize = True
        Me.optNewMotor.Location = New System.Drawing.Point(335, 19)
        Me.optNewMotor.Name = "optNewMotor"
        Me.optNewMotor.Size = New System.Drawing.Size(116, 17)
        Me.optNewMotor.TabIndex = 17
        Me.optNewMotor.Text = "Provide New Motor"
        Me.optNewMotor.UseVisualStyleBackColor = True
        '
        'optReuseMotor
        '
        Me.optReuseMotor.AutoSize = True
        Me.optReuseMotor.Checked = True
        Me.optReuseMotor.Location = New System.Drawing.Point(176, 21)
        Me.optReuseMotor.Name = "optReuseMotor"
        Me.optReuseMotor.Size = New System.Drawing.Size(125, 17)
        Me.optReuseMotor.TabIndex = 16
        Me.optReuseMotor.TabStop = True
        Me.optReuseMotor.Text = "Reuse Existing Motor"
        Me.optReuseMotor.UseVisualStyleBackColor = True
        '
        'optReplaceMotor
        '
        Me.optReplaceMotor.AutoSize = True
        Me.optReplaceMotor.Location = New System.Drawing.Point(6, 21)
        Me.optReplaceMotor.Name = "optReplaceMotor"
        Me.optReplaceMotor.Size = New System.Drawing.Size(134, 17)
        Me.optReplaceMotor.TabIndex = 15
        Me.optReplaceMotor.Text = "Replace Existing Motor"
        Me.optReplaceMotor.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optNewVFD)
        Me.GroupBox6.Controls.Add(Me.optReuseVFD)
        Me.GroupBox6.Controls.Add(Me.optReplaceVFD)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 135)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(516, 46)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VFD"
        '
        'optNewVFD
        '
        Me.optNewVFD.AutoSize = True
        Me.optNewVFD.Location = New System.Drawing.Point(335, 21)
        Me.optNewVFD.Name = "optNewVFD"
        Me.optNewVFD.Size = New System.Drawing.Size(110, 17)
        Me.optNewVFD.TabIndex = 17
        Me.optNewVFD.Text = "Provide New VFD"
        Me.optNewVFD.UseVisualStyleBackColor = True
        '
        'optReuseVFD
        '
        Me.optReuseVFD.AutoSize = True
        Me.optReuseVFD.Checked = True
        Me.optReuseVFD.Location = New System.Drawing.Point(176, 21)
        Me.optReuseVFD.Name = "optReuseVFD"
        Me.optReuseVFD.Size = New System.Drawing.Size(119, 17)
        Me.optReuseVFD.TabIndex = 16
        Me.optReuseVFD.TabStop = True
        Me.optReuseVFD.Text = "Reuse Existing VFD"
        Me.optReuseVFD.UseVisualStyleBackColor = True
        '
        'optReplaceVFD
        '
        Me.optReplaceVFD.AutoSize = True
        Me.optReplaceVFD.Location = New System.Drawing.Point(6, 21)
        Me.optReplaceVFD.Name = "optReplaceVFD"
        Me.optReplaceVFD.Size = New System.Drawing.Size(128, 17)
        Me.optReplaceVFD.TabIndex = 15
        Me.optReplaceVFD.Text = "Replace Existing VFD"
        Me.optReplaceVFD.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optIso2)
        Me.GroupBox5.Controls.Add(Me.optIso1)
        Me.GroupBox5.Controls.Add(Me.optIsoNone)
        Me.GroupBox5.Location = New System.Drawing.Point(390, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(116, 129)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Isolation"
        '
        'optIso2
        '
        Me.optIso2.AutoSize = True
        Me.optIso2.Location = New System.Drawing.Point(4, 75)
        Me.optIso2.Name = "optIso2"
        Me.optIso2.Size = New System.Drawing.Size(36, 17)
        Me.optIso2.TabIndex = 18
        Me.optIso2.TabStop = True
        Me.optIso2.Text = "2"""
        Me.optIso2.UseVisualStyleBackColor = True
        '
        'optIso1
        '
        Me.optIso1.AutoSize = True
        Me.optIso1.Location = New System.Drawing.Point(4, 48)
        Me.optIso1.Name = "optIso1"
        Me.optIso1.Size = New System.Drawing.Size(36, 17)
        Me.optIso1.TabIndex = 17
        Me.optIso1.TabStop = True
        Me.optIso1.Text = "1"""
        Me.optIso1.UseVisualStyleBackColor = True
        '
        'optIsoNone
        '
        Me.optIsoNone.AutoSize = True
        Me.optIsoNone.Checked = True
        Me.optIsoNone.Location = New System.Drawing.Point(4, 21)
        Me.optIsoNone.Name = "optIsoNone"
        Me.optIsoNone.Size = New System.Drawing.Size(51, 17)
        Me.optIsoNone.TabIndex = 16
        Me.optIsoNone.TabStop = True
        Me.optIsoNone.Text = "None"
        Me.optIsoNone.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optDirectDrive)
        Me.GroupBox4.Controls.Add(Me.optBeltDrive)
        Me.GroupBox4.Location = New System.Drawing.Point(143, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(110, 129)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Drive"
        '
        'optDirectDrive
        '
        Me.optDirectDrive.AutoSize = True
        Me.optDirectDrive.Location = New System.Drawing.Point(6, 48)
        Me.optDirectDrive.Name = "optDirectDrive"
        Me.optDirectDrive.Size = New System.Drawing.Size(53, 17)
        Me.optDirectDrive.TabIndex = 14
        Me.optDirectDrive.TabStop = True
        Me.optDirectDrive.Text = "Direct"
        Me.optDirectDrive.UseVisualStyleBackColor = True
        '
        'optBeltDrive
        '
        Me.optBeltDrive.AutoSize = True
        Me.optBeltDrive.Checked = True
        Me.optBeltDrive.Location = New System.Drawing.Point(6, 21)
        Me.optBeltDrive.Name = "optBeltDrive"
        Me.optBeltDrive.Size = New System.Drawing.Size(43, 17)
        Me.optBeltDrive.TabIndex = 13
        Me.optBeltDrive.TabStop = True
        Me.optBeltDrive.Text = "Belt"
        Me.optBeltDrive.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optPropFan)
        Me.GroupBox3.Controls.Add(Me.optPlenumFan)
        Me.GroupBox3.Controls.Add(Me.optAFFan)
        Me.GroupBox3.Controls.Add(Me.optFCFan)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 129)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fan Type"
        '
        'optPropFan
        '
        Me.optPropFan.AutoSize = True
        Me.optPropFan.Location = New System.Drawing.Point(6, 102)
        Me.optPropFan.Name = "optPropFan"
        Me.optPropFan.Size = New System.Drawing.Size(47, 17)
        Me.optPropFan.TabIndex = 15
        Me.optPropFan.TabStop = True
        Me.optPropFan.Text = "Prop"
        Me.optPropFan.UseVisualStyleBackColor = True
        '
        'optPlenumFan
        '
        Me.optPlenumFan.AutoSize = True
        Me.optPlenumFan.Location = New System.Drawing.Point(6, 75)
        Me.optPlenumFan.Name = "optPlenumFan"
        Me.optPlenumFan.Size = New System.Drawing.Size(60, 17)
        Me.optPlenumFan.TabIndex = 14
        Me.optPlenumFan.TabStop = True
        Me.optPlenumFan.Text = "Plenum"
        Me.optPlenumFan.UseVisualStyleBackColor = True
        '
        'optAFFan
        '
        Me.optAFFan.AutoSize = True
        Me.optAFFan.Location = New System.Drawing.Point(6, 48)
        Me.optAFFan.Name = "optAFFan"
        Me.optAFFan.Size = New System.Drawing.Size(91, 17)
        Me.optAFFan.TabIndex = 13
        Me.optAFFan.TabStop = True
        Me.optAFFan.Text = "AF Centrifugal"
        Me.optAFFan.UseVisualStyleBackColor = True
        '
        'optFCFan
        '
        Me.optFCFan.AutoSize = True
        Me.optFCFan.Checked = True
        Me.optFCFan.Location = New System.Drawing.Point(6, 21)
        Me.optFCFan.Name = "optFCFan"
        Me.optFCFan.Size = New System.Drawing.Size(91, 17)
        Me.optFCFan.TabIndex = 12
        Me.optFCFan.TabStop = True
        Me.optFCFan.Text = "FC Centrifugal"
        Me.optFCFan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optVAV)
        Me.GroupBox2.Controls.Add(Me.optVFDBalancing)
        Me.GroupBox2.Controls.Add(Me.optCVSystem)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 129)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System"
        '
        'optVAV
        '
        Me.optVAV.AutoSize = True
        Me.optVAV.Checked = True
        Me.optVAV.Location = New System.Drawing.Point(3, 75)
        Me.optVAV.Name = "optVAV"
        Me.optVAV.Size = New System.Drawing.Size(87, 17)
        Me.optVAV.TabIndex = 18
        Me.optVAV.TabStop = True
        Me.optVAV.Text = "VFD Variable"
        Me.optVAV.UseVisualStyleBackColor = True
        '
        'optVFDBalancing
        '
        Me.optVFDBalancing.AutoSize = True
        Me.optVFDBalancing.Location = New System.Drawing.Point(3, 48)
        Me.optVFDBalancing.Name = "optVFDBalancing"
        Me.optVFDBalancing.Size = New System.Drawing.Size(96, 17)
        Me.optVFDBalancing.TabIndex = 17
        Me.optVFDBalancing.TabStop = True
        Me.optVFDBalancing.Text = "VFD Balancing"
        Me.optVFDBalancing.UseVisualStyleBackColor = True
        '
        'optCVSystem
        '
        Me.optCVSystem.AutoSize = True
        Me.optCVSystem.Location = New System.Drawing.Point(3, 21)
        Me.optCVSystem.Name = "optCVSystem"
        Me.optCVSystem.Size = New System.Drawing.Size(39, 17)
        Me.optCVSystem.TabIndex = 16
        Me.optCVSystem.TabStop = True
        Me.optCVSystem.Text = "CV"
        Me.optCVSystem.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(582, 379)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.grpXFans)
        Me.tpgControls.Controls.Add(Me.grpSFanCtrlOptions)
        Me.tpgControls.Controls.Add(Me.grpRFanCtrlOptions)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(645, 415)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpXFans
        '
        Me.grpXFans.Controls.Add(Me.CheckBox1)
        Me.grpXFans.Controls.Add(Me.RadioButton1)
        Me.grpXFans.Controls.Add(Me.GroupBox10)
        Me.grpXFans.Controls.Add(Me.RadioButton5)
        Me.grpXFans.Controls.Add(Me.RadioButton6)
        Me.grpXFans.Controls.Add(Me.RadioButton7)
        Me.grpXFans.Location = New System.Drawing.Point(286, 7)
        Me.grpXFans.Name = "grpXFans"
        Me.grpXFans.Size = New System.Drawing.Size(273, 250)
        Me.grpXFans.TabIndex = 10
        Me.grpXFans.TabStop = False
        Me.grpXFans.Text = "Exhaust Fan Control Options"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(186, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Modulate Relief Damper by GBAS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 205)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.Text = "GBAS Exhaust Fan VFD"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CheckBox2)
        Me.GroupBox10.Controls.Add(Me.RadioButton2)
        Me.GroupBox10.Controls.Add(Me.RadioButton3)
        Me.GroupBox10.Controls.Add(Me.RadioButton4)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 67)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(259, 109)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "BSP Control"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(18, 83)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(175, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Modulate Relief Damper by IPU"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Modulate VFD by Fisen Ctrl"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 14)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Modulate VFD by SE"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 60)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(128, 17)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Modulate VFD by IPU"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(12, 182)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(149, 17)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.Text = "Track Outdoor Air Damper"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Building Static Pressure Ctrl"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(142, 17)
        Me.RadioButton7.TabIndex = 9
        Me.RadioButton7.Text = "No Exhaust Fan Controls"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'grpSFanCtrlOptions
        '
        Me.grpSFanCtrlOptions.Controls.Add(Me.chkSFanNetPointPiezo)
        Me.grpSFanCtrlOptions.Controls.Add(Me.chkSFanROandXmitPiezo)
        Me.grpSFanCtrlOptions.Controls.Add(Me.chkSFanROPiezo)
        Me.grpSFanCtrlOptions.Location = New System.Drawing.Point(286, 263)
        Me.grpSFanCtrlOptions.Name = "grpSFanCtrlOptions"
        Me.grpSFanCtrlOptions.Size = New System.Drawing.Size(273, 92)
        Me.grpSFanCtrlOptions.TabIndex = 9
        Me.grpSFanCtrlOptions.TabStop = False
        Me.grpSFanCtrlOptions.Text = "Supply Fan Control Options"
        '
        'chkSFanNetPointPiezo
        '
        Me.chkSFanNetPointPiezo.AutoSize = True
        Me.chkSFanNetPointPiezo.Location = New System.Drawing.Point(11, 65)
        Me.chkSFanNetPointPiezo.Name = "chkSFanNetPointPiezo"
        Me.chkSFanNetPointPiezo.Size = New System.Drawing.Size(182, 17)
        Me.chkSFanNetPointPiezo.TabIndex = 16
        Me.chkSFanNetPointPiezo.Text = "Supply Fan Piezo Ring (Network)"
        Me.chkSFanNetPointPiezo.UseVisualStyleBackColor = True
        '
        'chkSFanROandXmitPiezo
        '
        Me.chkSFanROandXmitPiezo.AutoSize = True
        Me.chkSFanROandXmitPiezo.Location = New System.Drawing.Point(11, 42)
        Me.chkSFanROandXmitPiezo.Name = "chkSFanROandXmitPiezo"
        Me.chkSFanROandXmitPiezo.Size = New System.Drawing.Size(264, 17)
        Me.chkSFanROandXmitPiezo.TabIndex = 15
        Me.chkSFanROandXmitPiezo.Text = "Supply Fan Piezo Ring (Ring and Transimtter Only)"
        Me.chkSFanROandXmitPiezo.UseVisualStyleBackColor = True
        '
        'chkSFanROPiezo
        '
        Me.chkSFanROPiezo.AutoSize = True
        Me.chkSFanROPiezo.Location = New System.Drawing.Point(12, 19)
        Me.chkSFanROPiezo.Name = "chkSFanROPiezo"
        Me.chkSFanROPiezo.Size = New System.Drawing.Size(188, 17)
        Me.chkSFanROPiezo.TabIndex = 14
        Me.chkSFanROPiezo.Text = "Supply Fan Piezo Ring (Ring Only)"
        Me.chkSFanROPiezo.UseVisualStyleBackColor = True
        '
        'grpRFanCtrlOptions
        '
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkInletMeasuringStationFull)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkInletMeasuringStationWithXMit)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkInletMeasuringStationOnly)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkRFPiezoRingsNet)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkRFPiezoRingsXmitterOnly)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkRFPiezoRingsOnly)
        Me.grpRFanCtrlOptions.Controls.Add(Me.chkGBASReliefDamper)
        Me.grpRFanCtrlOptions.Controls.Add(Me.optGBASRFan)
        Me.grpRFanCtrlOptions.Controls.Add(Me.grpBSPControls)
        Me.grpRFanCtrlOptions.Controls.Add(Me.optTrackSupplyFan)
        Me.grpRFanCtrlOptions.Controls.Add(Me.optBldgStaticPressureCtrl)
        Me.grpRFanCtrlOptions.Controls.Add(Me.optNoControls)
        Me.grpRFanCtrlOptions.Location = New System.Drawing.Point(7, 7)
        Me.grpRFanCtrlOptions.Name = "grpRFanCtrlOptions"
        Me.grpRFanCtrlOptions.Size = New System.Drawing.Size(273, 384)
        Me.grpRFanCtrlOptions.TabIndex = 8
        Me.grpRFanCtrlOptions.TabStop = False
        Me.grpRFanCtrlOptions.Text = "Return Fan Control Options"
        '
        'chkInletMeasuringStationFull
        '
        Me.chkInletMeasuringStationFull.AutoSize = True
        Me.chkInletMeasuringStationFull.Location = New System.Drawing.Point(6, 357)
        Me.chkInletMeasuringStationFull.Name = "chkInletMeasuringStationFull"
        Me.chkInletMeasuringStationFull.Size = New System.Drawing.Size(250, 17)
        Me.chkInletMeasuringStationFull.TabIndex = 19
        Me.chkInletMeasuringStationFull.Text = "Inlet Measuring Station Network Point Available"
        Me.chkInletMeasuringStationFull.UseVisualStyleBackColor = True
        Me.chkInletMeasuringStationFull.Visible = False
        '
        'chkInletMeasuringStationWithXMit
        '
        Me.chkInletMeasuringStationWithXMit.AutoSize = True
        Me.chkInletMeasuringStationWithXMit.Location = New System.Drawing.Point(6, 334)
        Me.chkInletMeasuringStationWithXMit.Name = "chkInletMeasuringStationWithXMit"
        Me.chkInletMeasuringStationWithXMit.Size = New System.Drawing.Size(210, 17)
        Me.chkInletMeasuringStationWithXMit.TabIndex = 18
        Me.chkInletMeasuringStationWithXMit.Text = "Inlet Measuring Station and Transmitter"
        Me.chkInletMeasuringStationWithXMit.UseVisualStyleBackColor = True
        Me.chkInletMeasuringStationWithXMit.Visible = False
        '
        'chkInletMeasuringStationOnly
        '
        Me.chkInletMeasuringStationOnly.AutoSize = True
        Me.chkInletMeasuringStationOnly.Location = New System.Drawing.Point(6, 311)
        Me.chkInletMeasuringStationOnly.Name = "chkInletMeasuringStationOnly"
        Me.chkInletMeasuringStationOnly.Size = New System.Drawing.Size(235, 17)
        Me.chkInletMeasuringStationOnly.TabIndex = 17
        Me.chkInletMeasuringStationOnly.Text = "Inlet Measuring Station (No Xdcr or Controls)"
        Me.chkInletMeasuringStationOnly.UseVisualStyleBackColor = True
        Me.chkInletMeasuringStationOnly.Visible = False
        '
        'chkRFPiezoRingsNet
        '
        Me.chkRFPiezoRingsNet.AutoSize = True
        Me.chkRFPiezoRingsNet.Location = New System.Drawing.Point(6, 288)
        Me.chkRFPiezoRingsNet.Name = "chkRFPiezoRingsNet"
        Me.chkRFPiezoRingsNet.Size = New System.Drawing.Size(222, 17)
        Me.chkRFPiezoRingsNet.TabIndex = 16
        Me.chkRFPiezoRingsNet.Text = "Inlet Piezo Ring (Network Point Available)"
        Me.chkRFPiezoRingsNet.UseVisualStyleBackColor = True
        Me.chkRFPiezoRingsNet.Visible = False
        '
        'chkRFPiezoRingsXmitterOnly
        '
        Me.chkRFPiezoRingsXmitterOnly.AutoSize = True
        Me.chkRFPiezoRingsXmitterOnly.Location = New System.Drawing.Point(6, 265)
        Me.chkRFPiezoRingsXmitterOnly.Name = "chkRFPiezoRingsXmitterOnly"
        Me.chkRFPiezoRingsXmitterOnly.Size = New System.Drawing.Size(231, 17)
        Me.chkRFPiezoRingsXmitterOnly.TabIndex = 15
        Me.chkRFPiezoRingsXmitterOnly.Text = "Inlet Piezo Ring (Ring and Transmitter Only)"
        Me.chkRFPiezoRingsXmitterOnly.UseVisualStyleBackColor = True
        Me.chkRFPiezoRingsXmitterOnly.Visible = False
        '
        'chkRFPiezoRingsOnly
        '
        Me.chkRFPiezoRingsOnly.AutoSize = True
        Me.chkRFPiezoRingsOnly.Location = New System.Drawing.Point(6, 242)
        Me.chkRFPiezoRingsOnly.Name = "chkRFPiezoRingsOnly"
        Me.chkRFPiezoRingsOnly.Size = New System.Drawing.Size(155, 17)
        Me.chkRFPiezoRingsOnly.TabIndex = 14
        Me.chkRFPiezoRingsOnly.Text = "Inlet Piezo Ring (Ring Only)"
        Me.chkRFPiezoRingsOnly.UseVisualStyleBackColor = True
        Me.chkRFPiezoRingsOnly.Visible = False
        '
        'chkGBASReliefDamper
        '
        Me.chkGBASReliefDamper.AutoSize = True
        Me.chkGBASReliefDamper.Location = New System.Drawing.Point(24, 219)
        Me.chkGBASReliefDamper.Name = "chkGBASReliefDamper"
        Me.chkGBASReliefDamper.Size = New System.Drawing.Size(186, 17)
        Me.chkGBASReliefDamper.TabIndex = 13
        Me.chkGBASReliefDamper.Text = "Modulate Relief Damper by GBAS"
        Me.chkGBASReliefDamper.UseVisualStyleBackColor = True
        '
        'optGBASRFan
        '
        Me.optGBASRFan.AutoSize = True
        Me.optGBASRFan.Location = New System.Drawing.Point(12, 196)
        Me.optGBASRFan.Name = "optGBASRFan"
        Me.optGBASRFan.Size = New System.Drawing.Size(134, 17)
        Me.optGBASRFan.TabIndex = 12
        Me.optGBASRFan.Text = "GBAS Return Fan VFD"
        Me.optGBASRFan.UseVisualStyleBackColor = True
        '
        'grpBSPControls
        '
        Me.grpBSPControls.Controls.Add(Me.chkIPUModulateDamper)
        Me.grpBSPControls.Controls.Add(Me.optBSPbyFisen)
        Me.grpBSPControls.Controls.Add(Me.optBSPbySE)
        Me.grpBSPControls.Controls.Add(Me.optBSPbyIPU)
        Me.grpBSPControls.Location = New System.Drawing.Point(6, 65)
        Me.grpBSPControls.Name = "grpBSPControls"
        Me.grpBSPControls.Size = New System.Drawing.Size(259, 102)
        Me.grpBSPControls.TabIndex = 9
        Me.grpBSPControls.TabStop = False
        Me.grpBSPControls.Text = "BSP Control"
        '
        'chkIPUModulateDamper
        '
        Me.chkIPUModulateDamper.AutoSize = True
        Me.chkIPUModulateDamper.Location = New System.Drawing.Point(18, 83)
        Me.chkIPUModulateDamper.Name = "chkIPUModulateDamper"
        Me.chkIPUModulateDamper.Size = New System.Drawing.Size(175, 17)
        Me.chkIPUModulateDamper.TabIndex = 9
        Me.chkIPUModulateDamper.Text = "Modulate Relief Damper by IPU"
        Me.chkIPUModulateDamper.UseVisualStyleBackColor = True
        '
        'optBSPbyFisen
        '
        Me.optBSPbyFisen.AutoSize = True
        Me.optBSPbyFisen.Location = New System.Drawing.Point(6, 37)
        Me.optBSPbyFisen.Name = "optBSPbyFisen"
        Me.optBSPbyFisen.Size = New System.Drawing.Size(153, 17)
        Me.optBSPbyFisen.TabIndex = 14
        Me.optBSPbyFisen.TabStop = True
        Me.optBSPbyFisen.Text = "Modulate VFD by Fisen Ctrl"
        Me.optBSPbyFisen.UseVisualStyleBackColor = True
        '
        'optBSPbySE
        '
        Me.optBSPbySE.AutoSize = True
        Me.optBSPbySE.Location = New System.Drawing.Point(6, 14)
        Me.optBSPbySE.Name = "optBSPbySE"
        Me.optBSPbySE.Size = New System.Drawing.Size(124, 17)
        Me.optBSPbySE.TabIndex = 13
        Me.optBSPbySE.TabStop = True
        Me.optBSPbySE.Text = "Modulate VFD by SE"
        Me.optBSPbySE.UseVisualStyleBackColor = True
        '
        'optBSPbyIPU
        '
        Me.optBSPbyIPU.AutoSize = True
        Me.optBSPbyIPU.Location = New System.Drawing.Point(6, 60)
        Me.optBSPbyIPU.Name = "optBSPbyIPU"
        Me.optBSPbyIPU.Size = New System.Drawing.Size(128, 17)
        Me.optBSPbyIPU.TabIndex = 12
        Me.optBSPbyIPU.TabStop = True
        Me.optBSPbyIPU.Text = "Modulate VFD by IPU"
        Me.optBSPbyIPU.UseVisualStyleBackColor = True
        '
        'optTrackSupplyFan
        '
        Me.optTrackSupplyFan.AutoSize = True
        Me.optTrackSupplyFan.Location = New System.Drawing.Point(12, 173)
        Me.optTrackSupplyFan.Name = "optTrackSupplyFan"
        Me.optTrackSupplyFan.Size = New System.Drawing.Size(109, 17)
        Me.optTrackSupplyFan.TabIndex = 11
        Me.optTrackSupplyFan.Text = "Track Supply Fan"
        Me.optTrackSupplyFan.UseVisualStyleBackColor = True
        '
        'optBldgStaticPressureCtrl
        '
        Me.optBldgStaticPressureCtrl.AutoSize = True
        Me.optBldgStaticPressureCtrl.Checked = True
        Me.optBldgStaticPressureCtrl.Location = New System.Drawing.Point(6, 42)
        Me.optBldgStaticPressureCtrl.Name = "optBldgStaticPressureCtrl"
        Me.optBldgStaticPressureCtrl.Size = New System.Drawing.Size(154, 17)
        Me.optBldgStaticPressureCtrl.TabIndex = 10
        Me.optBldgStaticPressureCtrl.TabStop = True
        Me.optBldgStaticPressureCtrl.Text = "Building Static Pressure Ctrl"
        Me.optBldgStaticPressureCtrl.UseVisualStyleBackColor = True
        '
        'optNoControls
        '
        Me.optNoControls.AutoSize = True
        Me.optNoControls.Location = New System.Drawing.Point(6, 19)
        Me.optNoControls.Name = "optNoControls"
        Me.optNoControls.Size = New System.Drawing.Size(136, 17)
        Me.optNoControls.TabIndex = 9
        Me.optNoControls.Text = "No Return Fan Controls"
        Me.optNoControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(582, 379)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.fraAuxPanel)
        Me.tpgPerformance.Controls.Add(Me.Label35)
        Me.tpgPerformance.Controls.Add(Me.txtFanbhpeach)
        Me.tpgPerformance.Controls.Add(Me.btnbhpeachWiz)
        Me.tpgPerformance.Controls.Add(Me.optContinental)
        Me.tpgPerformance.Controls.Add(Me.optComefri)
        Me.tpgPerformance.Controls.Add(Me.cmdPasteInlet)
        Me.tpgPerformance.Controls.Add(Me.cmdPasteOutlet)
        Me.tpgPerformance.Controls.Add(Me.cmdBlankInlet)
        Me.tpgPerformance.Controls.Add(Me.Label37)
        Me.tpgPerformance.Controls.Add(Me.nudFanCount)
        Me.tpgPerformance.Controls.Add(Me.chkMultipleFans)
        Me.tpgPerformance.Controls.Add(Me.Label34)
        Me.tpgPerformance.Controls.Add(Me.Label33)
        Me.tpgPerformance.Controls.Add(Me.cmbFanSelected)
        Me.tpgPerformance.Controls.Add(Me.Label30)
        Me.tpgPerformance.Controls.Add(Me.Label31)
        Me.tpgPerformance.Controls.Add(Me.txtMaxFanSpeed)
        Me.tpgPerformance.Controls.Add(Me.Label28)
        Me.tpgPerformance.Controls.Add(Me.Label29)
        Me.tpgPerformance.Controls.Add(Me.txtIndBA5)
        Me.tpgPerformance.Controls.Add(Me.txtIndBW)
        Me.tpgPerformance.Controls.Add(Me.txtOutdBA5)
        Me.tpgPerformance.Controls.Add(Me.txtOutdBW)
        Me.tpgPerformance.Controls.Add(Me.Label24)
        Me.tpgPerformance.Controls.Add(Me.Label25)
        Me.tpgPerformance.Controls.Add(Me.Label26)
        Me.tpgPerformance.Controls.Add(Me.Label27)
        Me.tpgPerformance.Controls.Add(Me.Label22)
        Me.tpgPerformance.Controls.Add(Me.Label23)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL8k)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL4k)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL2k)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL1k)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL500)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL250)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL125)
        Me.tpgPerformance.Controls.Add(Me.txtInPWL63)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL8k)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL4k)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL2k)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL1k)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL500)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL250)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL125)
        Me.tpgPerformance.Controls.Add(Me.txtOutPWL63)
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.txtFanbhp)
        Me.tpgPerformance.Controls.Add(Me.txtFanRPM)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Size = New System.Drawing.Size(645, 415)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Enabled = False
        Me.fraAuxPanel.Location = New System.Drawing.Point(7, 314)
        Me.fraAuxPanel.Name = "fraAuxPanel"
        Me.fraAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.fraAuxPanel.TabIndex = 96
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
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(488, 87)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 13)
        Me.Label35.TabIndex = 95
        Me.Label35.Text = "bhp each"
        '
        'txtFanbhpeach
        '
        Me.txtFanbhpeach.Location = New System.Drawing.Point(399, 83)
        Me.txtFanbhpeach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFanbhpeach.Name = "txtFanbhpeach"
        Me.txtFanbhpeach.Size = New System.Drawing.Size(81, 20)
        Me.txtFanbhpeach.TabIndex = 94
        '
        'btnbhpeachWiz
        '
        Me.btnbhpeachWiz.Image = CType(resources.GetObject("btnbhpeachWiz.Image"), System.Drawing.Image)
        Me.btnbhpeachWiz.Location = New System.Drawing.Point(370, 82)
        Me.btnbhpeachWiz.Name = "btnbhpeachWiz"
        Me.btnbhpeachWiz.Size = New System.Drawing.Size(22, 22)
        Me.btnbhpeachWiz.TabIndex = 93
        Me.btnbhpeachWiz.UseVisualStyleBackColor = True
        '
        'optContinental
        '
        Me.optContinental.AutoSize = True
        Me.optContinental.Location = New System.Drawing.Point(7, 193)
        Me.optContinental.Name = "optContinental"
        Me.optContinental.Size = New System.Drawing.Size(78, 17)
        Me.optContinental.TabIndex = 92
        Me.optContinental.Text = "Continental"
        Me.optContinental.UseVisualStyleBackColor = True
        '
        'optComefri
        '
        Me.optComefri.AutoSize = True
        Me.optComefri.Checked = True
        Me.optComefri.Location = New System.Drawing.Point(7, 167)
        Me.optComefri.Name = "optComefri"
        Me.optComefri.Size = New System.Drawing.Size(60, 17)
        Me.optComefri.TabIndex = 91
        Me.optComefri.TabStop = True
        Me.optComefri.Text = "Comefri"
        Me.optComefri.UseVisualStyleBackColor = True
        '
        'cmdPasteInlet
        '
        Me.cmdPasteInlet.Location = New System.Drawing.Point(88, 193)
        Me.cmdPasteInlet.Name = "cmdPasteInlet"
        Me.cmdPasteInlet.Size = New System.Drawing.Size(20, 20)
        Me.cmdPasteInlet.TabIndex = 90
        Me.cmdPasteInlet.Text = "P"
        Me.cmdPasteInlet.UseVisualStyleBackColor = True
        '
        'cmdPasteOutlet
        '
        Me.cmdPasteOutlet.Location = New System.Drawing.Point(88, 165)
        Me.cmdPasteOutlet.Name = "cmdPasteOutlet"
        Me.cmdPasteOutlet.Size = New System.Drawing.Size(20, 20)
        Me.cmdPasteOutlet.TabIndex = 89
        Me.cmdPasteOutlet.Text = "P"
        Me.cmdPasteOutlet.UseVisualStyleBackColor = True
        '
        'cmdBlankInlet
        '
        Me.cmdBlankInlet.Location = New System.Drawing.Point(617, 193)
        Me.cmdBlankInlet.Name = "cmdBlankInlet"
        Me.cmdBlankInlet.Size = New System.Drawing.Size(20, 20)
        Me.cmdBlankInlet.TabIndex = 88
        Me.cmdBlankInlet.Text = "-"
        Me.cmdBlankInlet.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(197, 106)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(136, 13)
        Me.Label37.TabIndex = 87
        Me.Label37.Text = "(Total in Multi-Fan Systems)"
        '
        'nudFanCount
        '
        Me.nudFanCount.Location = New System.Drawing.Point(562, 43)
        Me.nudFanCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudFanCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFanCount.Name = "nudFanCount"
        Me.nudFanCount.Size = New System.Drawing.Size(39, 20)
        Me.nudFanCount.TabIndex = 86
        Me.nudFanCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkMultipleFans
        '
        Me.chkMultipleFans.AutoSize = True
        Me.chkMultipleFans.Location = New System.Drawing.Point(419, 44)
        Me.chkMultipleFans.Name = "chkMultipleFans"
        Me.chkMultipleFans.Size = New System.Drawing.Size(137, 17)
        Me.chkMultipleFans.TabIndex = 84
        Me.chkMultipleFans.Text = "Multiple Fans In Parallel"
        Me.chkMultipleFans.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(115, 197)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 13)
        Me.Label34.TabIndex = 83
        Me.Label34.Text = "Inlet"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(115, 169)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(35, 13)
        Me.Label33.TabIndex = 82
        Me.Label33.Text = "Outlet"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFanSelected
        '
        Me.cmbFanSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFanSelected.FormattingEnabled = True
        Me.cmbFanSelected.Location = New System.Drawing.Point(419, 11)
        Me.cmbFanSelected.Name = "cmbFanSelected"
        Me.cmbFanSelected.Size = New System.Drawing.Size(192, 21)
        Me.cmbFanSelected.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(338, 48)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 80
        Me.Label30.Text = "RPM"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(143, 49)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 13)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Max Blower Speed"
        '
        'txtMaxFanSpeed
        '
        Me.txtMaxFanSpeed.Location = New System.Drawing.Point(247, 46)
        Me.txtMaxFanSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxFanSpeed.Name = "txtMaxFanSpeed"
        Me.txtMaxFanSpeed.Size = New System.Drawing.Size(81, 20)
        Me.txtMaxFanSpeed.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(566, 142)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "dBA at 5"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(525, 142)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 13)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "dBW"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIndBA5
        '
        Me.txtIndBA5.Location = New System.Drawing.Point(573, 194)
        Me.txtIndBA5.Name = "txtIndBA5"
        Me.txtIndBA5.Size = New System.Drawing.Size(38, 20)
        Me.txtIndBA5.TabIndex = 23
        Me.txtIndBA5.Text = "88"
        Me.txtIndBA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIndBW
        '
        Me.txtIndBW.Location = New System.Drawing.Point(523, 194)
        Me.txtIndBW.Name = "txtIndBW"
        Me.txtIndBW.Size = New System.Drawing.Size(38, 20)
        Me.txtIndBW.TabIndex = 22
        Me.txtIndBW.Text = "88"
        Me.txtIndBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutdBA5
        '
        Me.txtOutdBA5.Location = New System.Drawing.Point(573, 166)
        Me.txtOutdBA5.Name = "txtOutdBA5"
        Me.txtOutdBA5.Size = New System.Drawing.Size(38, 20)
        Me.txtOutdBA5.TabIndex = 13
        Me.txtOutdBA5.Text = "88"
        Me.txtOutdBA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutdBW
        '
        Me.txtOutdBW.Location = New System.Drawing.Point(523, 166)
        Me.txtOutdBW.Name = "txtOutdBW"
        Me.txtOutdBW.Size = New System.Drawing.Size(38, 20)
        Me.txtOutdBW.TabIndex = 12
        Me.txtOutdBW.Text = "88"
        Me.txtOutdBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(485, 142)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "8k"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(439, 142)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 70
        Me.Label25.Text = "4k"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(393, 142)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 13)
        Me.Label26.TabIndex = 69
        Me.Label26.Text = "2k"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(347, 142)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(19, 13)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "1k"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(298, 142)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 67
        Me.Label22.Text = "500"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(253, 142)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 13)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "250"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(205, 142)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "125"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "63"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInPWL8k
        '
        Me.txtInPWL8k.Location = New System.Drawing.Point(479, 194)
        Me.txtInPWL8k.Name = "txtInPWL8k"
        Me.txtInPWL8k.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL8k.TabIndex = 21
        Me.txtInPWL8k.Text = "88"
        Me.txtInPWL8k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL4k
        '
        Me.txtInPWL4k.Location = New System.Drawing.Point(433, 194)
        Me.txtInPWL4k.Name = "txtInPWL4k"
        Me.txtInPWL4k.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL4k.TabIndex = 20
        Me.txtInPWL4k.Text = "88"
        Me.txtInPWL4k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL2k
        '
        Me.txtInPWL2k.Location = New System.Drawing.Point(387, 194)
        Me.txtInPWL2k.Name = "txtInPWL2k"
        Me.txtInPWL2k.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL2k.TabIndex = 19
        Me.txtInPWL2k.Text = "88"
        Me.txtInPWL2k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL1k
        '
        Me.txtInPWL1k.Location = New System.Drawing.Point(341, 194)
        Me.txtInPWL1k.Name = "txtInPWL1k"
        Me.txtInPWL1k.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL1k.TabIndex = 18
        Me.txtInPWL1k.Text = "88"
        Me.txtInPWL1k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL500
        '
        Me.txtInPWL500.Location = New System.Drawing.Point(295, 194)
        Me.txtInPWL500.Name = "txtInPWL500"
        Me.txtInPWL500.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL500.TabIndex = 17
        Me.txtInPWL500.Text = "88"
        Me.txtInPWL500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL250
        '
        Me.txtInPWL250.Location = New System.Drawing.Point(249, 194)
        Me.txtInPWL250.Name = "txtInPWL250"
        Me.txtInPWL250.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL250.TabIndex = 16
        Me.txtInPWL250.Text = "88"
        Me.txtInPWL250.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL125
        '
        Me.txtInPWL125.Location = New System.Drawing.Point(203, 194)
        Me.txtInPWL125.Name = "txtInPWL125"
        Me.txtInPWL125.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL125.TabIndex = 15
        Me.txtInPWL125.Text = "88"
        Me.txtInPWL125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInPWL63
        '
        Me.txtInPWL63.Location = New System.Drawing.Point(157, 194)
        Me.txtInPWL63.Name = "txtInPWL63"
        Me.txtInPWL63.Size = New System.Drawing.Size(38, 20)
        Me.txtInPWL63.TabIndex = 14
        Me.txtInPWL63.Text = "88"
        Me.txtInPWL63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL8k
        '
        Me.txtOutPWL8k.Location = New System.Drawing.Point(479, 166)
        Me.txtOutPWL8k.Name = "txtOutPWL8k"
        Me.txtOutPWL8k.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL8k.TabIndex = 11
        Me.txtOutPWL8k.Text = "88"
        Me.txtOutPWL8k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL4k
        '
        Me.txtOutPWL4k.Location = New System.Drawing.Point(433, 166)
        Me.txtOutPWL4k.Name = "txtOutPWL4k"
        Me.txtOutPWL4k.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL4k.TabIndex = 10
        Me.txtOutPWL4k.Text = "88"
        Me.txtOutPWL4k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL2k
        '
        Me.txtOutPWL2k.Location = New System.Drawing.Point(387, 166)
        Me.txtOutPWL2k.Name = "txtOutPWL2k"
        Me.txtOutPWL2k.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL2k.TabIndex = 9
        Me.txtOutPWL2k.Text = "88"
        Me.txtOutPWL2k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL1k
        '
        Me.txtOutPWL1k.Location = New System.Drawing.Point(341, 166)
        Me.txtOutPWL1k.Name = "txtOutPWL1k"
        Me.txtOutPWL1k.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL1k.TabIndex = 8
        Me.txtOutPWL1k.Text = "88"
        Me.txtOutPWL1k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL500
        '
        Me.txtOutPWL500.Location = New System.Drawing.Point(295, 166)
        Me.txtOutPWL500.Name = "txtOutPWL500"
        Me.txtOutPWL500.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL500.TabIndex = 7
        Me.txtOutPWL500.Text = "88"
        Me.txtOutPWL500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL250
        '
        Me.txtOutPWL250.Location = New System.Drawing.Point(249, 166)
        Me.txtOutPWL250.Name = "txtOutPWL250"
        Me.txtOutPWL250.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL250.TabIndex = 6
        Me.txtOutPWL250.Text = "88"
        Me.txtOutPWL250.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL125
        '
        Me.txtOutPWL125.Location = New System.Drawing.Point(203, 166)
        Me.txtOutPWL125.Name = "txtOutPWL125"
        Me.txtOutPWL125.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL125.TabIndex = 5
        Me.txtOutPWL125.Text = "88"
        Me.txtOutPWL125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutPWL63
        '
        Me.txtOutPWL63.Location = New System.Drawing.Point(157, 166)
        Me.txtOutPWL63.Name = "txtOutPWL63"
        Me.txtOutPWL63.Size = New System.Drawing.Size(38, 20)
        Me.txtOutPWL63.TabIndex = 4
        Me.txtOutPWL63.Text = "88"
        Me.txtOutPWL63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(338, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "RPM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 86)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "bhp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "BHP Required"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Blower Speed"
        '
        'txtFanbhp
        '
        Me.txtFanbhp.Location = New System.Drawing.Point(247, 82)
        Me.txtFanbhp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFanbhp.Name = "txtFanbhp"
        Me.txtFanbhp.Size = New System.Drawing.Size(81, 20)
        Me.txtFanbhp.TabIndex = 2
        '
        'txtFanRPM
        '
        Me.txtFanRPM.Location = New System.Drawing.Point(247, 10)
        Me.txtFanRPM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFanRPM.Name = "txtFanRPM"
        Me.txtFanRPM.Size = New System.Drawing.Size(81, 20)
        Me.txtFanRPM.TabIndex = 0
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(582, 379)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 24
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'tpgStaticSum
        '
        Me.tpgStaticSum.Controls.Add(Me.cmdS20BottomSupply)
        Me.tpgStaticSum.Controls.Add(Me.chkPwrExhaustPresent)
        Me.tpgStaticSum.Controls.Add(Me.cmdS40Supply)
        Me.tpgStaticSum.Controls.Add(Me.cmdS10SideSupply)
        Me.tpgStaticSum.Controls.Add(Me.cmdS20SideSupply)
        Me.tpgStaticSum.Controls.Add(Me.cmdS100BEndReturn)
        Me.tpgStaticSum.Controls.Add(Me.chkEconPresent)
        Me.tpgStaticSum.Controls.Add(Me.grpFilterStyle)
        Me.tpgStaticSum.Controls.Add(Me.lblHeatType)
        Me.tpgStaticSum.Controls.Add(Me.cmbHeatBox)
        Me.tpgStaticSum.Controls.Add(Me.cmdS10BottomSupply)
        Me.tpgStaticSum.Controls.Add(Me.cmdS10BottomReturn)
        Me.tpgStaticSum.Controls.Add(Me.cmdS20SideReturn)
        Me.tpgStaticSum.Controls.Add(Me.cmdS40BottomReturn)
        Me.tpgStaticSum.Controls.Add(Me.cmdS20BottomReturn)
        Me.tpgStaticSum.Controls.Add(Me.cmdS40EndReturn)
        Me.tpgStaticSum.Controls.Add(Me.btnReturn)
        Me.tpgStaticSum.Controls.Add(Me.dgvStaticSummary)
        Me.tpgStaticSum.Location = New System.Drawing.Point(4, 22)
        Me.tpgStaticSum.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgStaticSum.Name = "tpgStaticSum"
        Me.tpgStaticSum.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgStaticSum.Size = New System.Drawing.Size(645, 415)
        Me.tpgStaticSum.TabIndex = 3
        Me.tpgStaticSum.Text = "Static Summary"
        Me.tpgStaticSum.UseVisualStyleBackColor = True
        '
        'cmdS20BottomSupply
        '
        Me.cmdS20BottomSupply.Location = New System.Drawing.Point(110, 211)
        Me.cmdS20BottomSupply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS20BottomSupply.Name = "cmdS20BottomSupply"
        Me.cmdS20BottomSupply.Size = New System.Drawing.Size(94, 28)
        Me.cmdS20BottomSupply.TabIndex = 26
        Me.cmdS20BottomSupply.Text = "S20 Bottom SA"
        Me.cmdS20BottomSupply.UseVisualStyleBackColor = True
        Me.cmdS20BottomSupply.Visible = False
        '
        'chkPwrExhaustPresent
        '
        Me.chkPwrExhaustPresent.AutoSize = True
        Me.chkPwrExhaustPresent.Checked = True
        Me.chkPwrExhaustPresent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPwrExhaustPresent.Location = New System.Drawing.Point(391, 143)
        Me.chkPwrExhaustPresent.Name = "chkPwrExhaustPresent"
        Me.chkPwrExhaustPresent.Size = New System.Drawing.Size(136, 17)
        Me.chkPwrExhaustPresent.TabIndex = 25
        Me.chkPwrExhaustPresent.Text = "Power Exhaust Present"
        Me.chkPwrExhaustPresent.UseVisualStyleBackColor = True
        Me.chkPwrExhaustPresent.Visible = False
        '
        'cmdS40Supply
        '
        Me.cmdS40Supply.Location = New System.Drawing.Point(212, 211)
        Me.cmdS40Supply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS40Supply.Name = "cmdS40Supply"
        Me.cmdS40Supply.Size = New System.Drawing.Size(94, 28)
        Me.cmdS40Supply.TabIndex = 24
        Me.cmdS40Supply.Text = "S40 SA"
        Me.cmdS40Supply.UseVisualStyleBackColor = True
        Me.cmdS40Supply.Visible = False
        '
        'cmdS10SideSupply
        '
        Me.cmdS10SideSupply.Location = New System.Drawing.Point(8, 247)
        Me.cmdS10SideSupply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS10SideSupply.Name = "cmdS10SideSupply"
        Me.cmdS10SideSupply.Size = New System.Drawing.Size(94, 28)
        Me.cmdS10SideSupply.TabIndex = 23
        Me.cmdS10SideSupply.Text = "S10 Side SA"
        Me.cmdS10SideSupply.UseVisualStyleBackColor = True
        Me.cmdS10SideSupply.Visible = False
        '
        'cmdS20SideSupply
        '
        Me.cmdS20SideSupply.Location = New System.Drawing.Point(110, 247)
        Me.cmdS20SideSupply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS20SideSupply.Name = "cmdS20SideSupply"
        Me.cmdS20SideSupply.Size = New System.Drawing.Size(94, 28)
        Me.cmdS20SideSupply.TabIndex = 22
        Me.cmdS20SideSupply.Text = "S20 Side SA"
        Me.cmdS20SideSupply.UseVisualStyleBackColor = True
        Me.cmdS20SideSupply.Visible = False
        '
        'cmdS100BEndReturn
        '
        Me.cmdS100BEndReturn.Location = New System.Drawing.Point(314, 283)
        Me.cmdS100BEndReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS100BEndReturn.Name = "cmdS100BEndReturn"
        Me.cmdS100BEndReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS100BEndReturn.TabIndex = 20
        Me.cmdS100BEndReturn.Text = "S100B End RA"
        Me.cmdS100BEndReturn.UseVisualStyleBackColor = True
        Me.cmdS100BEndReturn.Visible = False
        '
        'chkEconPresent
        '
        Me.chkEconPresent.AutoSize = True
        Me.chkEconPresent.Checked = True
        Me.chkEconPresent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEconPresent.Location = New System.Drawing.Point(391, 120)
        Me.chkEconPresent.Name = "chkEconPresent"
        Me.chkEconPresent.Size = New System.Drawing.Size(120, 17)
        Me.chkEconPresent.TabIndex = 19
        Me.chkEconPresent.Text = "Economizer Present"
        Me.chkEconPresent.UseVisualStyleBackColor = True
        Me.chkEconPresent.Visible = False
        '
        'grpFilterStyle
        '
        Me.grpFilterStyle.Controls.Add(Me.opt6inch95)
        Me.grpFilterStyle.Controls.Add(Me.opt6inch65)
        Me.grpFilterStyle.Controls.Add(Me.opt4InchFilters)
        Me.grpFilterStyle.Controls.Add(Me.opt2InchFilters)
        Me.grpFilterStyle.Location = New System.Drawing.Point(391, 45)
        Me.grpFilterStyle.Name = "grpFilterStyle"
        Me.grpFilterStyle.Size = New System.Drawing.Size(246, 69)
        Me.grpFilterStyle.TabIndex = 18
        Me.grpFilterStyle.TabStop = False
        Me.grpFilterStyle.Text = "Filters"
        Me.grpFilterStyle.Visible = False
        '
        'opt6inch95
        '
        Me.opt6inch95.AutoSize = True
        Me.opt6inch95.Checked = True
        Me.opt6inch95.Location = New System.Drawing.Point(88, 42)
        Me.opt6inch95.Name = "opt6inch95"
        Me.opt6inch95.Size = New System.Drawing.Size(59, 17)
        Me.opt6inch95.TabIndex = 3
        Me.opt6inch95.TabStop = True
        Me.opt6inch95.Text = "6"" 95%"
        Me.opt6inch95.UseVisualStyleBackColor = True
        '
        'opt6inch65
        '
        Me.opt6inch65.AutoSize = True
        Me.opt6inch65.Checked = True
        Me.opt6inch65.Location = New System.Drawing.Point(88, 19)
        Me.opt6inch65.Name = "opt6inch65"
        Me.opt6inch65.Size = New System.Drawing.Size(59, 17)
        Me.opt6inch65.TabIndex = 2
        Me.opt6inch65.TabStop = True
        Me.opt6inch65.Text = "6"" 65%"
        Me.opt6inch65.UseVisualStyleBackColor = True
        '
        'opt4InchFilters
        '
        Me.opt4InchFilters.AutoSize = True
        Me.opt4InchFilters.Location = New System.Drawing.Point(6, 42)
        Me.opt4InchFilters.Name = "opt4InchFilters"
        Me.opt4InchFilters.Size = New System.Drawing.Size(66, 17)
        Me.opt4InchFilters.TabIndex = 1
        Me.opt4InchFilters.Text = "4"" Filters"
        Me.opt4InchFilters.UseVisualStyleBackColor = True
        '
        'opt2InchFilters
        '
        Me.opt2InchFilters.AutoSize = True
        Me.opt2InchFilters.Checked = True
        Me.opt2InchFilters.Location = New System.Drawing.Point(6, 19)
        Me.opt2InchFilters.Name = "opt2InchFilters"
        Me.opt2InchFilters.Size = New System.Drawing.Size(66, 17)
        Me.opt2InchFilters.TabIndex = 0
        Me.opt2InchFilters.TabStop = True
        Me.opt2InchFilters.Text = "2"" Filters"
        Me.opt2InchFilters.UseVisualStyleBackColor = True
        '
        'lblHeatType
        '
        Me.lblHeatType.AutoSize = True
        Me.lblHeatType.Location = New System.Drawing.Point(388, 20)
        Me.lblHeatType.Name = "lblHeatType"
        Me.lblHeatType.Size = New System.Drawing.Size(57, 13)
        Me.lblHeatType.TabIndex = 17
        Me.lblHeatType.Text = "Heat Type"
        Me.lblHeatType.Visible = False
        '
        'cmbHeatBox
        '
        Me.cmbHeatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeatBox.FormattingEnabled = True
        Me.cmbHeatBox.Items.AddRange(New Object() {"Gas", "267 MBH Gas", "512 MBH Gas", "800 MBH Gas", "CoolOnly", "9kW", "18kW", "24kW", "36kW", "40kW", "54kW", "72kW"})
        Me.cmbHeatBox.Location = New System.Drawing.Point(451, 17)
        Me.cmbHeatBox.Name = "cmbHeatBox"
        Me.cmbHeatBox.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeatBox.TabIndex = 16
        Me.cmbHeatBox.Visible = False
        '
        'cmdS10BottomSupply
        '
        Me.cmdS10BottomSupply.Location = New System.Drawing.Point(8, 211)
        Me.cmdS10BottomSupply.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS10BottomSupply.Name = "cmdS10BottomSupply"
        Me.cmdS10BottomSupply.Size = New System.Drawing.Size(94, 28)
        Me.cmdS10BottomSupply.TabIndex = 15
        Me.cmdS10BottomSupply.Text = "S10 Bottom SA"
        Me.cmdS10BottomSupply.UseVisualStyleBackColor = True
        Me.cmdS10BottomSupply.Visible = False
        '
        'cmdS10BottomReturn
        '
        Me.cmdS10BottomReturn.Location = New System.Drawing.Point(7, 283)
        Me.cmdS10BottomReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS10BottomReturn.Name = "cmdS10BottomReturn"
        Me.cmdS10BottomReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS10BottomReturn.TabIndex = 14
        Me.cmdS10BottomReturn.Text = "S10 Bottom RA"
        Me.cmdS10BottomReturn.UseVisualStyleBackColor = True
        Me.cmdS10BottomReturn.Visible = False
        '
        'cmdS20SideReturn
        '
        Me.cmdS20SideReturn.Location = New System.Drawing.Point(110, 319)
        Me.cmdS20SideReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS20SideReturn.Name = "cmdS20SideReturn"
        Me.cmdS20SideReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS20SideReturn.TabIndex = 13
        Me.cmdS20SideReturn.Text = "S20 Side RA"
        Me.cmdS20SideReturn.UseVisualStyleBackColor = True
        Me.cmdS20SideReturn.Visible = False
        '
        'cmdS40BottomReturn
        '
        Me.cmdS40BottomReturn.Location = New System.Drawing.Point(212, 247)
        Me.cmdS40BottomReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS40BottomReturn.Name = "cmdS40BottomReturn"
        Me.cmdS40BottomReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS40BottomReturn.TabIndex = 12
        Me.cmdS40BottomReturn.Text = "S40 Bottom RA"
        Me.cmdS40BottomReturn.UseVisualStyleBackColor = True
        Me.cmdS40BottomReturn.Visible = False
        '
        'cmdS20BottomReturn
        '
        Me.cmdS20BottomReturn.Location = New System.Drawing.Point(110, 283)
        Me.cmdS20BottomReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS20BottomReturn.Name = "cmdS20BottomReturn"
        Me.cmdS20BottomReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS20BottomReturn.TabIndex = 11
        Me.cmdS20BottomReturn.Text = "S20 Bottom RA"
        Me.cmdS20BottomReturn.UseVisualStyleBackColor = True
        Me.cmdS20BottomReturn.Visible = False
        '
        'cmdS40EndReturn
        '
        Me.cmdS40EndReturn.Location = New System.Drawing.Point(212, 283)
        Me.cmdS40EndReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdS40EndReturn.Name = "cmdS40EndReturn"
        Me.cmdS40EndReturn.Size = New System.Drawing.Size(94, 28)
        Me.cmdS40EndReturn.TabIndex = 10
        Me.cmdS40EndReturn.Text = "S40 End RA"
        Me.cmdS40EndReturn.UseVisualStyleBackColor = True
        Me.cmdS40EndReturn.Visible = False
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(582, 379)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(55, 28)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'dgvStaticSummary
        '
        Me.dgvStaticSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaticSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colSTPStatic, Me.colATPStatic})
        Me.dgvStaticSummary.Location = New System.Drawing.Point(7, 7)
        Me.dgvStaticSummary.Name = "dgvStaticSummary"
        Me.dgvStaticSummary.RowTemplate.Height = 28
        Me.dgvStaticSummary.Size = New System.Drawing.Size(369, 197)
        Me.dgvStaticSummary.TabIndex = 0
        '
        'colItem
        '
        Me.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colItem.DefaultCellStyle = DataGridViewCellStyle4
        Me.colItem.HeaderText = "Item"
        Me.colItem.Name = "colItem"
        Me.colItem.Width = 52
        '
        'colSTPStatic
        '
        Me.colSTPStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSTPStatic.DefaultCellStyle = DataGridViewCellStyle5
        Me.colSTPStatic.HeaderText = "Static(std)"
        Me.colSTPStatic.Name = "colSTPStatic"
        Me.colSTPStatic.Width = 79
        '
        'colATPStatic
        '
        Me.colATPStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colATPStatic.DefaultCellStyle = DataGridViewCellStyle6
        Me.colATPStatic.HeaderText = "Static(elev)"
        Me.colATPStatic.Name = "colATPStatic"
        Me.colATPStatic.Width = 85
        '
        'lblNote1
        '
        Me.lblNote1.AutoSize = True
        Me.lblNote1.Location = New System.Drawing.Point(305, 457)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(33, 13)
        Me.lblNote1.TabIndex = 9
        Me.lblNote1.Text = "Note:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblAirflow, Me.tslblTSP, Me.tslblESP, Me.tslblElevation})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(678, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslblAirflow
        '
        Me.tslblAirflow.Name = "tslblAirflow"
        Me.tslblAirflow.Size = New System.Drawing.Size(79, 17)
        Me.tslblAirflow.Text = "Airflow: XXXX"
        '
        'tslblTSP
        '
        Me.tslblTSP.Name = "tslblTSP"
        Me.tslblTSP.Size = New System.Drawing.Size(51, 17)
        Me.tslblTSP.Text = "TSP: x.xx"
        '
        'tslblESP
        '
        Me.tslblESP.Name = "tslblESP"
        Me.tslblESP.Size = New System.Drawing.Size(50, 17)
        Me.tslblESP.Text = "ESP: x.xx"
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(219, 480)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 11
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'tslblElevation
        '
        Me.tslblElevation.Name = "tslblElevation"
        Me.tslblElevation.Size = New System.Drawing.Size(81, 17)
        Me.tslblElevation.Text = "Elevation: xxxx"
        '
        'frmNewFan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(678, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblNote1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewFan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add or Replace a Unit Fan"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.grpFlowConfig.ResumeLayout(False)
        Me.grpFlowConfig.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpReliefDampers.ResumeLayout(False)
        Me.grpReliefDampers.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.grpXFans.ResumeLayout(False)
        Me.grpXFans.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.grpSFanCtrlOptions.ResumeLayout(False)
        Me.grpSFanCtrlOptions.PerformLayout()
        Me.grpRFanCtrlOptions.ResumeLayout(False)
        Me.grpRFanCtrlOptions.PerformLayout()
        Me.grpBSPControls.ResumeLayout(False)
        Me.grpBSPControls.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        CType(Me.nudFanCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgStaticSum.ResumeLayout(False)
        Me.tpgStaticSum.PerformLayout()
        Me.grpFilterStyle.ResumeLayout(False)
        Me.grpFilterStyle.PerformLayout()
        CType(Me.dgvStaticSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTSP As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtUSP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtESP As TextBox
    Friend WithEvents txtAirflow As TextBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFanbhp As TextBox
    Friend WithEvents txtFanRPM As TextBox
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents tpgStaticSum As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents txtElevation As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUSPSafetyFactor As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbFanType As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents optNewBypass As RadioButton
    Friend WithEvents optReuseBypass As RadioButton
    Friend WithEvents optNoBypass As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents optReuseMotor As RadioButton
    Friend WithEvents optReplaceMotor As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optReuseVFD As RadioButton
    Friend WithEvents optReplaceVFD As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optIso2 As RadioButton
    Friend WithEvents optIso1 As RadioButton
    Friend WithEvents optIsoNone As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optDirectDrive As RadioButton
    Friend WithEvents optBeltDrive As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optPropFan As RadioButton
    Friend WithEvents optPlenumFan As RadioButton
    Friend WithEvents optAFFan As RadioButton
    Friend WithEvents optFCFan As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optVAV As RadioButton
    Friend WithEvents optVFDBalancing As RadioButton
    Friend WithEvents optCVSystem As RadioButton
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbExistingMotor As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbNewMotorHP As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optODP As RadioButton
    Friend WithEvents optTEFC As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInPWL8k As TextBox
    Friend WithEvents txtInPWL4k As TextBox
    Friend WithEvents txtInPWL2k As TextBox
    Friend WithEvents txtInPWL1k As TextBox
    Friend WithEvents txtInPWL500 As TextBox
    Friend WithEvents txtInPWL250 As TextBox
    Friend WithEvents txtInPWL125 As TextBox
    Friend WithEvents txtInPWL63 As TextBox
    Friend WithEvents txtOutPWL8k As TextBox
    Friend WithEvents txtOutPWL4k As TextBox
    Friend WithEvents txtOutPWL2k As TextBox
    Friend WithEvents txtOutPWL1k As TextBox
    Friend WithEvents txtOutPWL500 As TextBox
    Friend WithEvents txtOutPWL250 As TextBox
    Friend WithEvents txtOutPWL125 As TextBox
    Friend WithEvents txtOutPWL63 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtIndBA5 As TextBox
    Friend WithEvents txtIndBW As TextBox
    Friend WithEvents txtOutdBA5 As TextBox
    Friend WithEvents txtOutdBW As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtMaxFanSpeed As TextBox
    Friend WithEvents cmbFanSelected As ComboBox
    Friend WithEvents lblKFactor As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents chkTSPatElev As CheckBox
    Friend WithEvents chkSFatElev As CheckBox
    Friend WithEvents chkUSPatElev As CheckBox
    Friend WithEvents chkESPatElev As CheckBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents dgvStaticSummary As DataGridView
    Friend WithEvents optNewMotor As RadioButton
    Friend WithEvents optNewVFD As RadioButton
    Friend WithEvents chkRemoteVFDKeypad As CheckBox
    Friend WithEvents grpRFanCtrlOptions As GroupBox
    Friend WithEvents optNoControls As RadioButton
    Friend WithEvents chkGBASReliefDamper As CheckBox
    Friend WithEvents optGBASRFan As RadioButton
    Friend WithEvents grpBSPControls As GroupBox
    Friend WithEvents chkIPUModulateDamper As CheckBox
    Friend WithEvents optBSPbyFisen As RadioButton
    Friend WithEvents optBSPbySE As RadioButton
    Friend WithEvents optBSPbyIPU As RadioButton
    Friend WithEvents optTrackSupplyFan As RadioButton
    Friend WithEvents optBldgStaticPressureCtrl As RadioButton
    Friend WithEvents grpSFanCtrlOptions As GroupBox
    Friend WithEvents grpReliefDampers As GroupBox
    Friend WithEvents optControlRelief As RadioButton
    Friend WithEvents optBaroRelief As RadioButton
    Friend WithEvents optNoRelief As RadioButton
    Friend WithEvents chkMultipleFans As CheckBox
    Friend WithEvents grpXFans As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents cmdStaticSummary As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colSTPStatic As DataGridViewTextBoxColumn
    Friend WithEvents colATPStatic As DataGridViewTextBoxColumn
    Friend WithEvents cmdS40EndReturn As Button
    Friend WithEvents nudFanCount As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents cmdS20BottomReturn As Button
    Friend WithEvents cmdS40BottomReturn As Button
    Friend WithEvents grpFlowConfig As GroupBox
    Friend WithEvents optHorizFlow As RadioButton
    Friend WithEvents optDownFlow As RadioButton
    Friend WithEvents cmdS20SideReturn As Button
    Friend WithEvents cmdS10BottomReturn As Button
    Friend WithEvents cmdS10BottomSupply As Button
    Friend WithEvents lblHeatType As Label
    Friend WithEvents cmbHeatBox As ComboBox
    Friend WithEvents grpFilterStyle As GroupBox
    Friend WithEvents opt4InchFilters As RadioButton
    Friend WithEvents opt2InchFilters As RadioButton
    Friend WithEvents chkEconPresent As CheckBox
    Friend WithEvents cmdS100BEndReturn As Button
    Friend WithEvents cmdS20SideSupply As Button
    Friend WithEvents cmdS10SideSupply As Button
    Friend WithEvents cmdS40Supply As Button
    Friend WithEvents opt6inch95 As RadioButton
    Friend WithEvents opt6inch65 As RadioButton
    Friend WithEvents chkPwrExhaustPresent As CheckBox
    Friend WithEvents cmdS20BottomSupply As Button
    Friend WithEvents lblNote1 As Label
    Friend WithEvents chkSFanROPiezo As CheckBox
    Friend WithEvents chkRFPiezoRingsXmitterOnly As CheckBox
    Friend WithEvents chkRFPiezoRingsOnly As CheckBox
    Friend WithEvents chkRFPiezoRingsNet As CheckBox
    Friend WithEvents chkSFanNetPointPiezo As CheckBox
    Friend WithEvents chkSFanROandXmitPiezo As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslblAirflow As ToolStripStatusLabel
    Friend WithEvents tslblTSP As ToolStripStatusLabel
    Friend WithEvents tslblESP As ToolStripStatusLabel
    Friend WithEvents cmdBlankInlet As Button
    Friend WithEvents cmdPasteOutlet As Button
    Friend WithEvents cmdPasteInlet As Button
    Friend WithEvents optContinental As RadioButton
    Friend WithEvents optComefri As RadioButton
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents chkS10BottomRAMonitor As CheckBox
    Friend WithEvents chkInletMeasuringStationFull As CheckBox
    Friend WithEvents chkInletMeasuringStationWithXMit As CheckBox
    Friend WithEvents chkInletMeasuringStationOnly As CheckBox
    Friend WithEvents chkReliefHoodsShipLoose As CheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtFanbhpeach As TextBox
    Friend WithEvents btnbhpeachWiz As Button
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents tslblElevation As ToolStripStatusLabel
End Class
