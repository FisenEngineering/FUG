<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLowAmbient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLowAmbient))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.lblLineVolts = New System.Windows.Forms.Label()
        Me.lstLineVoltage = New System.Windows.Forms.ListBox()
        Me.grpCondRTU = New System.Windows.Forms.GroupBox()
        Me.chkRTUOnGrade = New System.Windows.Forms.CheckBox()
        Me.chkRTUUseHT = New System.Windows.Forms.CheckBox()
        Me.grpCondChill = New System.Windows.Forms.GroupBox()
        Me.chkChillerOnGrade = New System.Windows.Forms.CheckBox()
        Me.chkSinglePointPower = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optneg30Ambient = New System.Windows.Forms.RadioButton()
        Me.optneg20Ambient = New System.Windows.Forms.RadioButton()
        Me.optneg10Ambient = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkSMBottom = New System.Windows.Forms.CheckBox()
        Me.chkBaseRailEnclosure = New System.Windows.Forms.CheckBox()
        Me.grpOptRTU = New System.Windows.Forms.GroupBox()
        Me.grpOptChill = New System.Windows.Forms.GroupBox()
        Me.chkYCAVTopBlockoff = New System.Windows.Forms.CheckBox()
        Me.chkYCAVEmptyFanBlockoff = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.chkFieldHTbyFisen = New System.Windows.Forms.CheckBox()
        Me.lblFtOfHT = New System.Windows.Forms.Label()
        Me.chkRemoteEvap = New System.Windows.Forms.CheckBox()
        Me.nudFtOfHT = New System.Windows.Forms.NumericUpDown()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.grpCtrlRTU = New System.Windows.Forms.GroupBox()
        Me.grpCtrlChill = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optDDC = New System.Windows.Forms.RadioButton()
        Me.optElectroMechanical = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.grpPerfRTU = New System.Windows.Forms.GroupBox()
        Me.grpPerfChill = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWatts = New System.Windows.Forms.Label()
        Me.lblAdditionalHT = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbWattsPerFoot = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbHTVolts = New System.Windows.Forms.ComboBox()
        Me.cmdSelectXFmr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFtofHeatTrace = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optXFrmr15 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr10 = New System.Windows.Forms.RadioButton()
        Me.optXFrmrNA = New System.Windows.Forms.RadioButton()
        Me.optXFrmr7dot5 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr5 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr3 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr2 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr1dot5 = New System.Windows.Forms.RadioButton()
        Me.optXFrmr1 = New System.Windows.Forms.RadioButton()
        Me.optXFrmrdot75 = New System.Windows.Forms.RadioButton()
        Me.optXFrmrDot5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.chkOATempSpoof = New System.Windows.Forms.CheckBox()
        Me.chkDedicatedPower = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.grpCondRTU.SuspendLayout()
        Me.grpCondChill.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpOptChill.SuspendLayout()
        CType(Me.nudFtOfHT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 335)
        Me.TabControl1.TabIndex = 5
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkDedicatedPower)
        Me.tpgConditions.Controls.Add(Me.lblLineVolts)
        Me.tpgConditions.Controls.Add(Me.lstLineVoltage)
        Me.tpgConditions.Controls.Add(Me.grpCondRTU)
        Me.tpgConditions.Controls.Add(Me.grpCondChill)
        Me.tpgConditions.Controls.Add(Me.chkSinglePointPower)
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 309)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'lblLineVolts
        '
        Me.lblLineVolts.AutoSize = True
        Me.lblLineVolts.Enabled = False
        Me.lblLineVolts.Location = New System.Drawing.Point(10, 112)
        Me.lblLineVolts.Name = "lblLineVolts"
        Me.lblLineVolts.Size = New System.Drawing.Size(88, 13)
        Me.lblLineVolts.TabIndex = 32
        Me.lblLineVolts.Text = "Unit Line Voltage"
        '
        'lstLineVoltage
        '
        Me.lstLineVoltage.Enabled = False
        Me.lstLineVoltage.FormattingEnabled = True
        Me.lstLineVoltage.Items.AddRange(New Object() {"200", "208", "230", "460", "575"})
        Me.lstLineVoltage.Location = New System.Drawing.Point(32, 128)
        Me.lstLineVoltage.Name = "lstLineVoltage"
        Me.lstLineVoltage.Size = New System.Drawing.Size(42, 69)
        Me.lstLineVoltage.TabIndex = 31
        '
        'grpCondRTU
        '
        Me.grpCondRTU.Controls.Add(Me.chkRTUOnGrade)
        Me.grpCondRTU.Controls.Add(Me.chkRTUUseHT)
        Me.grpCondRTU.Enabled = False
        Me.grpCondRTU.Location = New System.Drawing.Point(372, 65)
        Me.grpCondRTU.Name = "grpCondRTU"
        Me.grpCondRTU.Size = New System.Drawing.Size(200, 162)
        Me.grpCondRTU.TabIndex = 30
        Me.grpCondRTU.TabStop = False
        Me.grpCondRTU.Text = "RTU Only Conditions"
        '
        'chkRTUOnGrade
        '
        Me.chkRTUOnGrade.AutoSize = True
        Me.chkRTUOnGrade.Location = New System.Drawing.Point(8, 23)
        Me.chkRTUOnGrade.Name = "chkRTUOnGrade"
        Me.chkRTUOnGrade.Size = New System.Drawing.Size(175, 17)
        Me.chkRTUOnGrade.TabIndex = 30
        Me.chkRTUOnGrade.Text = "On Grade or Full Perimeter Curb"
        Me.chkRTUOnGrade.UseVisualStyleBackColor = True
        '
        'chkRTUUseHT
        '
        Me.chkRTUUseHT.AutoSize = True
        Me.chkRTUUseHT.Location = New System.Drawing.Point(8, 46)
        Me.chkRTUUseHT.Name = "chkRTUUseHT"
        Me.chkRTUUseHT.Size = New System.Drawing.Size(186, 17)
        Me.chkRTUUseHT.TabIndex = 29
        Me.chkRTUUseHT.Text = "Heat Trace on Comps/Suc./etc..."
        Me.chkRTUUseHT.UseVisualStyleBackColor = True
        '
        'grpCondChill
        '
        Me.grpCondChill.Controls.Add(Me.chkChillerOnGrade)
        Me.grpCondChill.Enabled = False
        Me.grpCondChill.Location = New System.Drawing.Point(372, 7)
        Me.grpCondChill.Name = "grpCondChill"
        Me.grpCondChill.Size = New System.Drawing.Size(200, 52)
        Me.grpCondChill.TabIndex = 29
        Me.grpCondChill.TabStop = False
        Me.grpCondChill.Text = "Chiller Only Conditions"
        '
        'chkChillerOnGrade
        '
        Me.chkChillerOnGrade.AutoSize = True
        Me.chkChillerOnGrade.Location = New System.Drawing.Point(8, 19)
        Me.chkChillerOnGrade.Name = "chkChillerOnGrade"
        Me.chkChillerOnGrade.Size = New System.Drawing.Size(143, 17)
        Me.chkChillerOnGrade.TabIndex = 28
        Me.chkChillerOnGrade.Text = "Chiller Installed on Grade"
        Me.chkChillerOnGrade.UseVisualStyleBackColor = True
        '
        'chkSinglePointPower
        '
        Me.chkSinglePointPower.AutoSize = True
        Me.chkSinglePointPower.Location = New System.Drawing.Point(120, 16)
        Me.chkSinglePointPower.Name = "chkSinglePointPower"
        Me.chkSinglePointPower.Size = New System.Drawing.Size(115, 17)
        Me.chkSinglePointPower.TabIndex = 27
        Me.chkSinglePointPower.Text = "Single Point Power"
        Me.chkSinglePointPower.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optneg30Ambient)
        Me.GroupBox1.Controls.Add(Me.optneg20Ambient)
        Me.GroupBox1.Controls.Add(Me.optneg10Ambient)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 102)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minimum Ambient"
        '
        'optneg30Ambient
        '
        Me.optneg30Ambient.AutoSize = True
        Me.optneg30Ambient.Location = New System.Drawing.Point(6, 75)
        Me.optneg30Ambient.Name = "optneg30Ambient"
        Me.optneg30Ambient.Size = New System.Drawing.Size(81, 17)
        Me.optneg30Ambient.TabIndex = 27
        Me.optneg30Ambient.Text = "-30 Ambient"
        Me.optneg30Ambient.UseVisualStyleBackColor = True
        '
        'optneg20Ambient
        '
        Me.optneg20Ambient.AutoSize = True
        Me.optneg20Ambient.Checked = True
        Me.optneg20Ambient.Location = New System.Drawing.Point(6, 48)
        Me.optneg20Ambient.Name = "optneg20Ambient"
        Me.optneg20Ambient.Size = New System.Drawing.Size(81, 17)
        Me.optneg20Ambient.TabIndex = 26
        Me.optneg20Ambient.TabStop = True
        Me.optneg20Ambient.Text = "-20 Ambient"
        Me.optneg20Ambient.UseVisualStyleBackColor = True
        '
        'optneg10Ambient
        '
        Me.optneg10Ambient.AutoSize = True
        Me.optneg10Ambient.Location = New System.Drawing.Point(5, 21)
        Me.optneg10Ambient.Name = "optneg10Ambient"
        Me.optneg10Ambient.Size = New System.Drawing.Size(81, 17)
        Me.optneg10Ambient.TabIndex = 25
        Me.optneg10Ambient.Text = "-10 Ambient"
        Me.optneg10Ambient.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(520, 273)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkSMBottom)
        Me.tpgOptions.Controls.Add(Me.chkBaseRailEnclosure)
        Me.tpgOptions.Controls.Add(Me.grpOptRTU)
        Me.tpgOptions.Controls.Add(Me.grpOptChill)
        Me.tpgOptions.Controls.Add(Me.Label7)
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.chkFieldHTbyFisen)
        Me.tpgOptions.Controls.Add(Me.lblFtOfHT)
        Me.tpgOptions.Controls.Add(Me.chkRemoteEvap)
        Me.tpgOptions.Controls.Add(Me.nudFtOfHT)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Size = New System.Drawing.Size(579, 309)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkSMBottom
        '
        Me.chkSMBottom.AutoSize = True
        Me.chkSMBottom.Location = New System.Drawing.Point(10, 147)
        Me.chkSMBottom.Name = "chkSMBottom"
        Me.chkSMBottom.Size = New System.Drawing.Size(119, 17)
        Me.chkSMBottom.TabIndex = 60
        Me.chkSMBottom.Text = "Sheet Metal Bottom"
        Me.chkSMBottom.UseVisualStyleBackColor = True
        '
        'chkBaseRailEnclosure
        '
        Me.chkBaseRailEnclosure.AutoSize = True
        Me.chkBaseRailEnclosure.Location = New System.Drawing.Point(10, 124)
        Me.chkBaseRailEnclosure.Name = "chkBaseRailEnclosure"
        Me.chkBaseRailEnclosure.Size = New System.Drawing.Size(113, 17)
        Me.chkBaseRailEnclosure.TabIndex = 59
        Me.chkBaseRailEnclosure.Text = "Baserail Enclosure"
        Me.chkBaseRailEnclosure.UseVisualStyleBackColor = True
        '
        'grpOptRTU
        '
        Me.grpOptRTU.Enabled = False
        Me.grpOptRTU.Location = New System.Drawing.Point(368, 76)
        Me.grpOptRTU.Name = "grpOptRTU"
        Me.grpOptRTU.Size = New System.Drawing.Size(200, 52)
        Me.grpOptRTU.TabIndex = 58
        Me.grpOptRTU.TabStop = False
        Me.grpOptRTU.Text = "RTU Only Options"
        '
        'grpOptChill
        '
        Me.grpOptChill.Controls.Add(Me.chkYCAVTopBlockoff)
        Me.grpOptChill.Controls.Add(Me.chkYCAVEmptyFanBlockoff)
        Me.grpOptChill.Enabled = False
        Me.grpOptChill.Location = New System.Drawing.Point(368, 7)
        Me.grpOptChill.Name = "grpOptChill"
        Me.grpOptChill.Size = New System.Drawing.Size(200, 63)
        Me.grpOptChill.TabIndex = 57
        Me.grpOptChill.TabStop = False
        Me.grpOptChill.Text = "Chiller Only Options"
        '
        'chkYCAVTopBlockoff
        '
        Me.chkYCAVTopBlockoff.AutoSize = True
        Me.chkYCAVTopBlockoff.Location = New System.Drawing.Point(6, 19)
        Me.chkYCAVTopBlockoff.Name = "chkYCAVTopBlockoff"
        Me.chkYCAVTopBlockoff.Size = New System.Drawing.Size(166, 17)
        Me.chkYCAVTopBlockoff.TabIndex = 29
        Me.chkYCAVTopBlockoff.Text = "YCAV Top Ctrl Panel Blockoff"
        Me.chkYCAVTopBlockoff.UseVisualStyleBackColor = True
        '
        'chkYCAVEmptyFanBlockoff
        '
        Me.chkYCAVEmptyFanBlockoff.AutoSize = True
        Me.chkYCAVEmptyFanBlockoff.Location = New System.Drawing.Point(6, 42)
        Me.chkYCAVEmptyFanBlockoff.Name = "chkYCAVEmptyFanBlockoff"
        Me.chkYCAVEmptyFanBlockoff.Size = New System.Drawing.Size(149, 17)
        Me.chkYCAVEmptyFanBlockoff.TabIndex = 34
        Me.chkYCAVEmptyFanBlockoff.Text = "YCAV Empty Fan Blockoff"
        Me.chkYCAVEmptyFanBlockoff.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(28, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "This is total.  Consider multiple circuits."
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(10, 284)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 54
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'chkFieldHTbyFisen
        '
        Me.chkFieldHTbyFisen.AutoSize = True
        Me.chkFieldHTbyFisen.Enabled = False
        Me.chkFieldHTbyFisen.Location = New System.Drawing.Point(31, 53)
        Me.chkFieldHTbyFisen.Name = "chkFieldHTbyFisen"
        Me.chkFieldHTbyFisen.Size = New System.Drawing.Size(96, 17)
        Me.chkFieldHTbyFisen.TabIndex = 33
        Me.chkFieldHTbyFisen.Text = "Fisen Provided"
        Me.chkFieldHTbyFisen.UseVisualStyleBackColor = True
        '
        'lblFtOfHT
        '
        Me.lblFtOfHT.AutoSize = True
        Me.lblFtOfHT.Enabled = False
        Me.lblFtOfHT.Location = New System.Drawing.Point(102, 29)
        Me.lblFtOfHT.Name = "lblFtOfHT"
        Me.lblFtOfHT.Size = New System.Drawing.Size(127, 13)
        Me.lblFtOfHT.TabIndex = 32
        Me.lblFtOfHT.Text = "Feet of Suction/Evap HT"
        '
        'chkRemoteEvap
        '
        Me.chkRemoteEvap.AutoSize = True
        Me.chkRemoteEvap.Location = New System.Drawing.Point(10, 7)
        Me.chkRemoteEvap.Name = "chkRemoteEvap"
        Me.chkRemoteEvap.Size = New System.Drawing.Size(180, 17)
        Me.chkRemoteEvap.TabIndex = 31
        Me.chkRemoteEvap.Text = "Remote Evaporator/Split System"
        Me.chkRemoteEvap.UseVisualStyleBackColor = True
        '
        'nudFtOfHT
        '
        Me.nudFtOfHT.Enabled = False
        Me.nudFtOfHT.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudFtOfHT.Location = New System.Drawing.Point(31, 27)
        Me.nudFtOfHT.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudFtOfHT.Name = "nudFtOfHT"
        Me.nudFtOfHT.Size = New System.Drawing.Size(60, 20)
        Me.nudFtOfHT.TabIndex = 30
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(520, 273)
        Me.btnDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkOATempSpoof)
        Me.tpgControls.Controls.Add(Me.grpCtrlRTU)
        Me.tpgControls.Controls.Add(Me.grpCtrlChill)
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 309)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpCtrlRTU
        '
        Me.grpCtrlRTU.Enabled = False
        Me.grpCtrlRTU.Location = New System.Drawing.Point(372, 138)
        Me.grpCtrlRTU.Name = "grpCtrlRTU"
        Me.grpCtrlRTU.Size = New System.Drawing.Size(200, 52)
        Me.grpCtrlRTU.TabIndex = 60
        Me.grpCtrlRTU.TabStop = False
        Me.grpCtrlRTU.Text = "RTU Only Controls"
        '
        'grpCtrlChill
        '
        Me.grpCtrlChill.Enabled = False
        Me.grpCtrlChill.Location = New System.Drawing.Point(372, 7)
        Me.grpCtrlChill.Name = "grpCtrlChill"
        Me.grpCtrlChill.Size = New System.Drawing.Size(200, 125)
        Me.grpCtrlChill.TabIndex = 59
        Me.grpCtrlChill.TabStop = False
        Me.grpCtrlChill.Text = "Chiller Only Controls"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optDDC)
        Me.GroupBox2.Controls.Add(Me.optElectroMechanical)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 76)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control Style"
        '
        'optDDC
        '
        Me.optDDC.AutoSize = True
        Me.optDDC.Location = New System.Drawing.Point(6, 48)
        Me.optDDC.Name = "optDDC"
        Me.optDDC.Size = New System.Drawing.Size(48, 17)
        Me.optDDC.TabIndex = 28
        Me.optDDC.Text = "DDC"
        Me.optDDC.UseVisualStyleBackColor = True
        '
        'optElectroMechanical
        '
        Me.optElectroMechanical.AutoSize = True
        Me.optElectroMechanical.Checked = True
        Me.optElectroMechanical.Location = New System.Drawing.Point(6, 21)
        Me.optElectroMechanical.Name = "optElectroMechanical"
        Me.optElectroMechanical.Size = New System.Drawing.Size(113, 17)
        Me.optElectroMechanical.TabIndex = 27
        Me.optElectroMechanical.TabStop = True
        Me.optElectroMechanical.Text = "ElectroMechanical"
        Me.optElectroMechanical.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(520, 273)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.grpPerfRTU)
        Me.tpgPerformance.Controls.Add(Me.grpPerfChill)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.Label5)
        Me.tpgPerformance.Controls.Add(Me.lblWatts)
        Me.tpgPerformance.Controls.Add(Me.lblAdditionalHT)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.cmbWattsPerFoot)
        Me.tpgPerformance.Controls.Add(Me.Label3)
        Me.tpgPerformance.Controls.Add(Me.cmbHTVolts)
        Me.tpgPerformance.Controls.Add(Me.cmdSelectXFmr)
        Me.tpgPerformance.Controls.Add(Me.Label1)
        Me.tpgPerformance.Controls.Add(Me.txtFtofHeatTrace)
        Me.tpgPerformance.Controls.Add(Me.GroupBox3)
        Me.tpgPerformance.Controls.Add(Me.Label2)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 309)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'grpPerfRTU
        '
        Me.grpPerfRTU.Enabled = False
        Me.grpPerfRTU.Location = New System.Drawing.Point(372, 140)
        Me.grpPerfRTU.Name = "grpPerfRTU"
        Me.grpPerfRTU.Size = New System.Drawing.Size(200, 52)
        Me.grpPerfRTU.TabIndex = 62
        Me.grpPerfRTU.TabStop = False
        Me.grpPerfRTU.Text = "RTU Only Controls"
        '
        'grpPerfChill
        '
        Me.grpPerfChill.Enabled = False
        Me.grpPerfChill.Location = New System.Drawing.Point(372, 9)
        Me.grpPerfChill.Name = "grpPerfChill"
        Me.grpPerfChill.Size = New System.Drawing.Size(200, 125)
        Me.grpPerfChill.TabIndex = 61
        Me.grpPerfChill.TabStop = False
        Me.grpPerfChill.Text = "Chiller Only Controls"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "additional."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "+"
        '
        'lblWatts
        '
        Me.lblWatts.AutoSize = True
        Me.lblWatts.Location = New System.Drawing.Point(211, 74)
        Me.lblWatts.Name = "lblWatts"
        Me.lblWatts.Size = New System.Drawing.Size(50, 13)
        Me.lblWatts.TabIndex = 36
        Me.lblWatts.Text = "xxx watts"
        '
        'lblAdditionalHT
        '
        Me.lblAdditionalHT.AutoSize = True
        Me.lblAdditionalHT.Location = New System.Drawing.Point(230, 12)
        Me.lblAdditionalHT.Name = "lblAdditionalHT"
        Me.lblAdditionalHT.Size = New System.Drawing.Size(25, 13)
        Me.lblAdditionalHT.TabIndex = 35
        Me.lblAdditionalHT.Text = "888"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Heat Trace W/Ft."
        '
        'cmbWattsPerFoot
        '
        Me.cmbWattsPerFoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWattsPerFoot.Enabled = False
        Me.cmbWattsPerFoot.FormattingEnabled = True
        Me.cmbWattsPerFoot.Items.AddRange(New Object() {"3", "5", "8"})
        Me.cmbWattsPerFoot.Location = New System.Drawing.Point(105, 71)
        Me.cmbWattsPerFoot.Name = "cmbWattsPerFoot"
        Me.cmbWattsPerFoot.Size = New System.Drawing.Size(100, 21)
        Me.cmbWattsPerFoot.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Heat Trace Volts"
        '
        'cmbHTVolts
        '
        Me.cmbHTVolts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHTVolts.Enabled = False
        Me.cmbHTVolts.FormattingEnabled = True
        Me.cmbHTVolts.Items.AddRange(New Object() {"120", "240"})
        Me.cmbHTVolts.Location = New System.Drawing.Point(105, 41)
        Me.cmbHTVolts.Name = "cmbHTVolts"
        Me.cmbHTVolts.Size = New System.Drawing.Size(100, 21)
        Me.cmbHTVolts.TabIndex = 31
        '
        'cmdSelectXFmr
        '
        Me.cmdSelectXFmr.Image = CType(resources.GetObject("cmdSelectXFmr.Image"), System.Drawing.Image)
        Me.cmdSelectXFmr.Location = New System.Drawing.Point(322, 9)
        Me.cmdSelectXFmr.Name = "cmdSelectXFmr"
        Me.cmdSelectXFmr.Size = New System.Drawing.Size(22, 22)
        Me.cmdSelectXFmr.TabIndex = 30
        Me.cmdSelectXFmr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Ft. of Heat Trace"
        '
        'txtFtofHeatTrace
        '
        Me.txtFtofHeatTrace.Location = New System.Drawing.Point(105, 9)
        Me.txtFtofHeatTrace.Name = "txtFtofHeatTrace"
        Me.txtFtofHeatTrace.Size = New System.Drawing.Size(100, 20)
        Me.txtFtofHeatTrace.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optXFrmr15)
        Me.GroupBox3.Controls.Add(Me.optXFrmr10)
        Me.GroupBox3.Controls.Add(Me.optXFrmrNA)
        Me.GroupBox3.Controls.Add(Me.optXFrmr7dot5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr3)
        Me.GroupBox3.Controls.Add(Me.optXFrmr2)
        Me.GroupBox3.Controls.Add(Me.optXFrmr1dot5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr1)
        Me.GroupBox3.Controls.Add(Me.optXFrmrdot75)
        Me.GroupBox3.Controls.Add(Me.optXFrmrDot5)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 158)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transformer"
        '
        'optXFrmr15
        '
        Me.optXFrmr15.AutoSize = True
        Me.optXFrmr15.Location = New System.Drawing.Point(75, 111)
        Me.optXFrmr15.Name = "optXFrmr15"
        Me.optXFrmr15.Size = New System.Drawing.Size(69, 17)
        Me.optXFrmr15.TabIndex = 39
        Me.optXFrmr15.Text = "15.0 kVA"
        Me.optXFrmr15.UseVisualStyleBackColor = True
        '
        'optXFrmr10
        '
        Me.optXFrmr10.AutoSize = True
        Me.optXFrmr10.Location = New System.Drawing.Point(75, 88)
        Me.optXFrmr10.Name = "optXFrmr10"
        Me.optXFrmr10.Size = New System.Drawing.Size(69, 17)
        Me.optXFrmr10.TabIndex = 38
        Me.optXFrmr10.Text = "10.0 kVA"
        Me.optXFrmr10.UseVisualStyleBackColor = True
        '
        'optXFrmrNA
        '
        Me.optXFrmrNA.AutoSize = True
        Me.optXFrmrNA.Checked = True
        Me.optXFrmrNA.Location = New System.Drawing.Point(6, 134)
        Me.optXFrmrNA.Name = "optXFrmrNA"
        Me.optXFrmrNA.Size = New System.Drawing.Size(45, 17)
        Me.optXFrmrNA.TabIndex = 37
        Me.optXFrmrNA.TabStop = True
        Me.optXFrmrNA.Text = "N/A"
        Me.optXFrmrNA.UseVisualStyleBackColor = True
        '
        'optXFrmr7dot5
        '
        Me.optXFrmr7dot5.AutoSize = True
        Me.optXFrmr7dot5.Location = New System.Drawing.Point(75, 65)
        Me.optXFrmr7dot5.Name = "optXFrmr7dot5"
        Me.optXFrmr7dot5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr7dot5.TabIndex = 36
        Me.optXFrmr7dot5.Text = "7.5 kVA"
        Me.optXFrmr7dot5.UseVisualStyleBackColor = True
        '
        'optXFrmr5
        '
        Me.optXFrmr5.AutoSize = True
        Me.optXFrmr5.Location = New System.Drawing.Point(75, 42)
        Me.optXFrmr5.Name = "optXFrmr5"
        Me.optXFrmr5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr5.TabIndex = 35
        Me.optXFrmr5.Text = "5.0 kVA"
        Me.optXFrmr5.UseVisualStyleBackColor = True
        '
        'optXFrmr3
        '
        Me.optXFrmr3.AutoSize = True
        Me.optXFrmr3.Location = New System.Drawing.Point(75, 19)
        Me.optXFrmr3.Name = "optXFrmr3"
        Me.optXFrmr3.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr3.TabIndex = 34
        Me.optXFrmr3.Text = "3.0 kVA"
        Me.optXFrmr3.UseVisualStyleBackColor = True
        '
        'optXFrmr2
        '
        Me.optXFrmr2.AutoSize = True
        Me.optXFrmr2.Location = New System.Drawing.Point(6, 111)
        Me.optXFrmr2.Name = "optXFrmr2"
        Me.optXFrmr2.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr2.TabIndex = 33
        Me.optXFrmr2.Text = "2.0 kVA"
        Me.optXFrmr2.UseVisualStyleBackColor = True
        '
        'optXFrmr1dot5
        '
        Me.optXFrmr1dot5.AutoSize = True
        Me.optXFrmr1dot5.Location = New System.Drawing.Point(6, 88)
        Me.optXFrmr1dot5.Name = "optXFrmr1dot5"
        Me.optXFrmr1dot5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr1dot5.TabIndex = 31
        Me.optXFrmr1dot5.Text = "1.5 kVA"
        Me.optXFrmr1dot5.UseVisualStyleBackColor = True
        '
        'optXFrmr1
        '
        Me.optXFrmr1.AutoSize = True
        Me.optXFrmr1.Location = New System.Drawing.Point(6, 65)
        Me.optXFrmr1.Name = "optXFrmr1"
        Me.optXFrmr1.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr1.TabIndex = 30
        Me.optXFrmr1.Text = "1.0 kVA"
        Me.optXFrmr1.UseVisualStyleBackColor = True
        '
        'optXFrmrdot75
        '
        Me.optXFrmrdot75.AutoSize = True
        Me.optXFrmrdot75.Location = New System.Drawing.Point(6, 42)
        Me.optXFrmrdot75.Name = "optXFrmrdot75"
        Me.optXFrmrdot75.Size = New System.Drawing.Size(69, 17)
        Me.optXFrmrdot75.TabIndex = 29
        Me.optXFrmrdot75.Text = "0.75 kVA"
        Me.optXFrmrdot75.UseVisualStyleBackColor = True
        '
        'optXFrmrDot5
        '
        Me.optXFrmrDot5.AutoSize = True
        Me.optXFrmrDot5.Location = New System.Drawing.Point(6, 19)
        Me.optXFrmrDot5.Name = "optXFrmrDot5"
        Me.optXFrmrDot5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmrDot5.TabIndex = 28
        Me.optXFrmrDot5.Text = "0.5 kVA"
        Me.optXFrmrDot5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "MCA will require updating Manually."
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(520, 273)
        Me.btnDonePerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Size = New System.Drawing.Size(579, 309)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 351)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(13, 351)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(523, 355)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 18
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(559, 355)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 17
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(220, 370)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 19
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'chkOATempSpoof
        '
        Me.chkOATempSpoof.AutoSize = True
        Me.chkOATempSpoof.Location = New System.Drawing.Point(13, 90)
        Me.chkOATempSpoof.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOATempSpoof.Name = "chkOATempSpoof"
        Me.chkOATempSpoof.Size = New System.Drawing.Size(148, 17)
        Me.chkOATempSpoof.TabIndex = 61
        Me.chkOATempSpoof.Text = "OA Temp Spoof Required"
        Me.chkOATempSpoof.UseVisualStyleBackColor = True
        '
        'chkDedicatedPower
        '
        Me.chkDedicatedPower.AutoSize = True
        Me.chkDedicatedPower.Location = New System.Drawing.Point(120, 39)
        Me.chkDedicatedPower.Name = "chkDedicatedPower"
        Me.chkDedicatedPower.Size = New System.Drawing.Size(168, 17)
        Me.chkDedicatedPower.TabIndex = 33
        Me.chkDedicatedPower.Text = "Dedicated 240V Power Circuit"
        Me.chkDedicatedPower.UseVisualStyleBackColor = True
        '
        'frmLowAmbient
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(605, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLowAmbient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Low Ambient Chiller"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.grpCondRTU.ResumeLayout(False)
        Me.grpCondRTU.PerformLayout()
        Me.grpCondChill.ResumeLayout(False)
        Me.grpCondChill.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpOptChill.ResumeLayout(False)
        Me.grpOptChill.PerformLayout()
        CType(Me.nudFtOfHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optneg30Ambient As RadioButton
    Friend WithEvents optneg20Ambient As RadioButton
    Friend WithEvents optneg10Ambient As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optDDC As RadioButton
    Friend WithEvents optElectroMechanical As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents chkYCAVTopBlockoff As CheckBox
    Friend WithEvents chkFieldHTbyFisen As CheckBox
    Friend WithEvents lblFtOfHT As Label
    Friend WithEvents chkRemoteEvap As CheckBox
    Friend WithEvents nudFtOfHT As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optXFrmr7dot5 As RadioButton
    Friend WithEvents optXFrmr5 As RadioButton
    Friend WithEvents optXFrmr3 As RadioButton
    Friend WithEvents optXFrmr2 As RadioButton
    Friend WithEvents optXFrmr1dot5 As RadioButton
    Friend WithEvents optXFrmr1 As RadioButton
    Friend WithEvents optXFrmrdot75 As RadioButton
    Friend WithEvents optXFrmrDot5 As RadioButton
    Friend WithEvents optXFrmrNA As RadioButton
    Friend WithEvents chkYCAVEmptyFanBlockoff As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFtofHeatTrace As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbHTVolts As ComboBox
    Friend WithEvents cmdSelectXFmr As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbWattsPerFoot As ComboBox
    Friend WithEvents lblAdditionalHT As Label
    Friend WithEvents lblWatts As Label
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents chkChillerOnGrade As CheckBox
    Friend WithEvents chkSinglePointPower As CheckBox
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents optXFrmr15 As RadioButton
    Friend WithEvents optXFrmr10 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents grpCondRTU As GroupBox
    Friend WithEvents grpCondChill As GroupBox
    Friend WithEvents grpOptRTU As GroupBox
    Friend WithEvents grpOptChill As GroupBox
    Friend WithEvents grpCtrlRTU As GroupBox
    Friend WithEvents grpCtrlChill As GroupBox
    Friend WithEvents grpPerfRTU As GroupBox
    Friend WithEvents grpPerfChill As GroupBox
    Friend WithEvents chkRTUUseHT As CheckBox
    Friend WithEvents lblLineVolts As Label
    Friend WithEvents lstLineVoltage As ListBox
    Friend WithEvents chkSMBottom As CheckBox
    Friend WithEvents chkBaseRailEnclosure As CheckBox
    Friend WithEvents chkRTUOnGrade As CheckBox
    Friend WithEvents chkOATempSpoof As CheckBox
    Friend WithEvents chkDedicatedPower As CheckBox
End Class
