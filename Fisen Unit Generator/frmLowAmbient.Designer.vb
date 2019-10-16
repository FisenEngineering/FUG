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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optneg30Ambient = New System.Windows.Forms.RadioButton()
        Me.optneg20Ambient = New System.Windows.Forms.RadioButton()
        Me.optneg10Ambient = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkYCAVEmptyFanBlockoff = New System.Windows.Forms.CheckBox()
        Me.chkFieldHTbyFisen = New System.Windows.Forms.CheckBox()
        Me.lblFtOfHT = New System.Windows.Forms.Label()
        Me.chkRemoteEvap = New System.Windows.Forms.CheckBox()
        Me.nudFtOfHT = New System.Windows.Forms.NumericUpDown()
        Me.chkYCAVTopBlockoff = New System.Windows.Forms.CheckBox()
        Me.lblLineVolts = New System.Windows.Forms.Label()
        Me.lstLineVoltage = New System.Windows.Forms.ListBox()
        Me.chkSinglePointPower = New System.Windows.Forms.CheckBox()
        Me.chkBaseRailEnclosure = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optDDC = New System.Windows.Forms.RadioButton()
        Me.optElectroMechanical = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
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
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 5
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 194)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
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
        Me.btnDoneConditions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkYCAVEmptyFanBlockoff)
        Me.tpgOptions.Controls.Add(Me.chkFieldHTbyFisen)
        Me.tpgOptions.Controls.Add(Me.lblFtOfHT)
        Me.tpgOptions.Controls.Add(Me.chkRemoteEvap)
        Me.tpgOptions.Controls.Add(Me.nudFtOfHT)
        Me.tpgOptions.Controls.Add(Me.chkYCAVTopBlockoff)
        Me.tpgOptions.Controls.Add(Me.lblLineVolts)
        Me.tpgOptions.Controls.Add(Me.lstLineVoltage)
        Me.tpgOptions.Controls.Add(Me.chkSinglePointPower)
        Me.tpgOptions.Controls.Add(Me.chkBaseRailEnclosure)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Size = New System.Drawing.Size(579, 194)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkYCAVEmptyFanBlockoff
        '
        Me.chkYCAVEmptyFanBlockoff.AutoSize = True
        Me.chkYCAVEmptyFanBlockoff.Location = New System.Drawing.Point(385, 30)
        Me.chkYCAVEmptyFanBlockoff.Name = "chkYCAVEmptyFanBlockoff"
        Me.chkYCAVEmptyFanBlockoff.Size = New System.Drawing.Size(149, 17)
        Me.chkYCAVEmptyFanBlockoff.TabIndex = 34
        Me.chkYCAVEmptyFanBlockoff.Text = "YCAV Empty Fan Blockoff"
        Me.chkYCAVEmptyFanBlockoff.UseVisualStyleBackColor = True
        '
        'chkFieldHTbyFisen
        '
        Me.chkFieldHTbyFisen.AutoSize = True
        Me.chkFieldHTbyFisen.Enabled = False
        Me.chkFieldHTbyFisen.Location = New System.Drawing.Point(164, 53)
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
        Me.lblFtOfHT.Location = New System.Drawing.Point(235, 29)
        Me.lblFtOfHT.Name = "lblFtOfHT"
        Me.lblFtOfHT.Size = New System.Drawing.Size(127, 13)
        Me.lblFtOfHT.TabIndex = 32
        Me.lblFtOfHT.Text = "Feet of Suction/Evap HT"
        '
        'chkRemoteEvap
        '
        Me.chkRemoteEvap.AutoSize = True
        Me.chkRemoteEvap.Location = New System.Drawing.Point(143, 7)
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
        Me.nudFtOfHT.Location = New System.Drawing.Point(164, 27)
        Me.nudFtOfHT.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudFtOfHT.Name = "nudFtOfHT"
        Me.nudFtOfHT.Size = New System.Drawing.Size(60, 20)
        Me.nudFtOfHT.TabIndex = 30
        '
        'chkYCAVTopBlockoff
        '
        Me.chkYCAVTopBlockoff.AutoSize = True
        Me.chkYCAVTopBlockoff.Location = New System.Drawing.Point(385, 7)
        Me.chkYCAVTopBlockoff.Name = "chkYCAVTopBlockoff"
        Me.chkYCAVTopBlockoff.Size = New System.Drawing.Size(166, 17)
        Me.chkYCAVTopBlockoff.TabIndex = 29
        Me.chkYCAVTopBlockoff.Text = "YCAV Top Ctrl Panel Blockoff"
        Me.chkYCAVTopBlockoff.UseVisualStyleBackColor = True
        '
        'lblLineVolts
        '
        Me.lblLineVolts.AutoSize = True
        Me.lblLineVolts.Enabled = False
        Me.lblLineVolts.Location = New System.Drawing.Point(25, 27)
        Me.lblLineVolts.Name = "lblLineVolts"
        Me.lblLineVolts.Size = New System.Drawing.Size(88, 13)
        Me.lblLineVolts.TabIndex = 28
        Me.lblLineVolts.Text = "Unit Line Voltage"
        '
        'lstLineVoltage
        '
        Me.lstLineVoltage.Enabled = False
        Me.lstLineVoltage.FormattingEnabled = True
        Me.lstLineVoltage.Items.AddRange(New Object() {"200", "208", "230", "460", "575"})
        Me.lstLineVoltage.Location = New System.Drawing.Point(47, 43)
        Me.lstLineVoltage.Name = "lstLineVoltage"
        Me.lstLineVoltage.Size = New System.Drawing.Size(42, 69)
        Me.lstLineVoltage.TabIndex = 27
        '
        'chkSinglePointPower
        '
        Me.chkSinglePointPower.AutoSize = True
        Me.chkSinglePointPower.Location = New System.Drawing.Point(7, 7)
        Me.chkSinglePointPower.Name = "chkSinglePointPower"
        Me.chkSinglePointPower.Size = New System.Drawing.Size(115, 17)
        Me.chkSinglePointPower.TabIndex = 26
        Me.chkSinglePointPower.Text = "Single Point Power"
        Me.chkSinglePointPower.UseVisualStyleBackColor = True
        '
        'chkBaseRailEnclosure
        '
        Me.chkBaseRailEnclosure.AutoSize = True
        Me.chkBaseRailEnclosure.Location = New System.Drawing.Point(385, 53)
        Me.chkBaseRailEnclosure.Name = "chkBaseRailEnclosure"
        Me.chkBaseRailEnclosure.Size = New System.Drawing.Size(113, 17)
        Me.chkBaseRailEnclosure.TabIndex = 25
        Me.chkBaseRailEnclosure.Text = "Baserail Enclosure"
        Me.chkBaseRailEnclosure.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 194)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
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
        Me.btnDoneControls.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
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
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 194)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
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
        Me.lblAdditionalHT.Location = New System.Drawing.Point(211, 14)
        Me.lblAdditionalHT.Name = "lblAdditionalHT"
        Me.lblAdditionalHT.Size = New System.Drawing.Size(71, 13)
        Me.lblAdditionalHT.TabIndex = 35
        Me.lblAdditionalHT.Text = "+ 0 Additional"
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
        Me.cmdSelectXFmr.Location = New System.Drawing.Point(336, 9)
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
        Me.GroupBox3.Controls.Add(Me.optXFrmrNA)
        Me.GroupBox3.Controls.Add(Me.optXFrmr7dot5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr3)
        Me.GroupBox3.Controls.Add(Me.optXFrmr2)
        Me.GroupBox3.Controls.Add(Me.optXFrmr1dot5)
        Me.GroupBox3.Controls.Add(Me.optXFrmr1)
        Me.GroupBox3.Controls.Add(Me.optXFrmrdot75)
        Me.GroupBox3.Controls.Add(Me.optXFrmrDot5)
        Me.GroupBox3.Location = New System.Drawing.Point(364, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 136)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transformer"
        '
        'optXFrmrNA
        '
        Me.optXFrmrNA.AutoSize = True
        Me.optXFrmrNA.Checked = True
        Me.optXFrmrNA.Location = New System.Drawing.Point(6, 111)
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
        Me.optXFrmr7dot5.Location = New System.Drawing.Point(75, 88)
        Me.optXFrmr7dot5.Name = "optXFrmr7dot5"
        Me.optXFrmr7dot5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr7dot5.TabIndex = 36
        Me.optXFrmr7dot5.Text = "7.5 kVA"
        Me.optXFrmr7dot5.UseVisualStyleBackColor = True
        '
        'optXFrmr5
        '
        Me.optXFrmr5.AutoSize = True
        Me.optXFrmr5.Location = New System.Drawing.Point(75, 65)
        Me.optXFrmr5.Name = "optXFrmr5"
        Me.optXFrmr5.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr5.TabIndex = 35
        Me.optXFrmr5.Text = "5.0 kVA"
        Me.optXFrmr5.UseVisualStyleBackColor = True
        '
        'optXFrmr3
        '
        Me.optXFrmr3.AutoSize = True
        Me.optXFrmr3.Location = New System.Drawing.Point(75, 42)
        Me.optXFrmr3.Name = "optXFrmr3"
        Me.optXFrmr3.Size = New System.Drawing.Size(63, 17)
        Me.optXFrmr3.TabIndex = 34
        Me.optXFrmr3.Text = "3.0 kVA"
        Me.optXFrmr3.UseVisualStyleBackColor = True
        '
        'optXFrmr2
        '
        Me.optXFrmr2.AutoSize = True
        Me.optXFrmr2.Location = New System.Drawing.Point(75, 19)
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
        Me.Label2.Location = New System.Drawing.Point(3, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "MCA will require updating Manually."
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(513, 153)
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
        Me.DebugPage.Size = New System.Drawing.Size(579, 194)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(124, 241)
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
        Me.btnOK.Location = New System.Drawing.Point(20, 241)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmLowAmbient
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(605, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLowAmbient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Low Ambient Chiller"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        CType(Me.nudFtOfHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgControls.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents chkBaseRailEnclosure As CheckBox
    Friend WithEvents lblLineVolts As Label
    Friend WithEvents lstLineVoltage As ListBox
    Friend WithEvents chkSinglePointPower As CheckBox
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
End Class
