﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm100OA
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkIntellispeed = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.chkJCIHGRH = New System.Windows.Forms.CheckBox()
        Me.chkHGRH_Conv = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optFisenHGBP = New System.Windows.Forms.RadioButton()
        Me.optJCIHGBP = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chkModEHeat = New System.Windows.Forms.CheckBox()
        Me.optHeatcoGas = New System.Windows.Forms.RadioButton()
        Me.chkModHeat = New System.Windows.Forms.CheckBox()
        Me.optSteamHeat = New System.Windows.Forms.RadioButton()
        Me.optHWHeat = New System.Windows.Forms.RadioButton()
        Me.optEHeat = New System.Windows.Forms.RadioButton()
        Me.optGasHeat = New System.Windows.Forms.RadioButton()
        Me.optNoHeat = New System.Windows.Forms.RadioButton()
        Me.chkFisenMHGRH = New System.Windows.Forms.CheckBox()
        Me.chkFisenHGRH = New System.Windows.Forms.CheckBox()
        Me.chkLowAF = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt100OACapable = New System.Windows.Forms.RadioButton()
        Me.opt100OA = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkZoneOvrSensor = New System.Windows.Forms.CheckBox()
        Me.grp100OACapable = New System.Windows.Forms.GroupBox()
        Me.optCoolCtrlByIPU = New System.Windows.Forms.RadioButton()
        Me.optCoolCtrlBySE = New System.Windows.Forms.RadioButton()
        Me.optCoolCtrlGBAS = New System.Windows.Forms.RadioButton()
        Me.optCoolCtrlStagedOA = New System.Windows.Forms.RadioButton()
        Me.optCoolCtrlDAByFisenSE = New System.Windows.Forms.RadioButton()
        Me.grpModeCtrl = New System.Windows.Forms.GroupBox()
        Me.optModeNoChange = New System.Windows.Forms.RadioButton()
        Me.optModeDATOnly = New System.Windows.Forms.RadioButton()
        Me.optModeGBAS = New System.Windows.Forms.RadioButton()
        Me.optModeAuto = New System.Windows.Forms.RadioButton()
        Me.grpHeatCtrl = New System.Windows.Forms.GroupBox()
        Me.optHeatCtrlDABaseUnit = New System.Windows.Forms.RadioButton()
        Me.optHeatCtrlDAByFisen = New System.Windows.Forms.RadioButton()
        Me.optHeatCtrlGBAS = New System.Windows.Forms.RadioButton()
        Me.optHeatCtrlDAFutureTB = New System.Windows.Forms.RadioButton()
        Me.optHeatCtrlDAFieldInstTB = New System.Windows.Forms.RadioButton()
        Me.optHeatCtrlStagedOA = New System.Windows.Forms.RadioButton()
        Me.grpGBASCtrl4 = New System.Windows.Forms.GroupBox()
        Me.chkGBASOADamper = New System.Windows.Forms.CheckBox()
        Me.optGBASFuture = New System.Windows.Forms.RadioButton()
        Me.optGBAS3Level = New System.Windows.Forms.RadioButton()
        Me.optGBASVernier = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.grpReturn = New System.Windows.Forms.GroupBox()
        Me.optReturnHorizontal = New System.Windows.Forms.RadioButton()
        Me.optReturnBottom = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.grp100OACapable.SuspendLayout()
        Me.grpModeCtrl.SuspendLayout()
        Me.grpHeatCtrl.SuspendLayout()
        Me.grpGBASCtrl4.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.grpReturn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(16, 240)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(120, 240)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkIntellispeed)
        Me.tpgConditions.Controls.Add(Me.GroupBox2)
        Me.tpgConditions.Controls.Add(Me.chkJCIHGRH)
        Me.tpgConditions.Controls.Add(Me.chkHGRH_Conv)
        Me.tpgConditions.Controls.Add(Me.GroupBox8)
        Me.tpgConditions.Controls.Add(Me.GroupBox9)
        Me.tpgConditions.Controls.Add(Me.chkFisenMHGRH)
        Me.tpgConditions.Controls.Add(Me.chkFisenHGRH)
        Me.tpgConditions.Controls.Add(Me.chkLowAF)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 194)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chkIntellispeed
        '
        Me.chkIntellispeed.AutoSize = True
        Me.chkIntellispeed.Location = New System.Drawing.Point(5, 110)
        Me.chkIntellispeed.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIntellispeed.Name = "chkIntellispeed"
        Me.chkIntellispeed.Size = New System.Drawing.Size(214, 17)
        Me.chkIntellispeed.TabIndex = 42
        Me.chkIntellispeed.Text = "Convert Intellispeed to Constant Volume"
        Me.chkIntellispeed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optIPU)
        Me.GroupBox2.Controls.Add(Me.optSE)
        Me.GroupBox2.Location = New System.Drawing.Point(221, 126)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(212, 63)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Base Unit Controls"
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Location = New System.Drawing.Point(5, 41)
        Me.optIPU.Name = "optIPU"
        Me.optIPU.Size = New System.Drawing.Size(43, 17)
        Me.optIPU.TabIndex = 3
        Me.optIPU.Text = "IPU"
        Me.optIPU.UseVisualStyleBackColor = True
        '
        'optSE
        '
        Me.optSE.AutoSize = True
        Me.optSE.Checked = True
        Me.optSE.Location = New System.Drawing.Point(5, 18)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 1
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
        '
        'chkJCIHGRH
        '
        Me.chkJCIHGRH.AutoSize = True
        Me.chkJCIHGRH.Location = New System.Drawing.Point(5, 27)
        Me.chkJCIHGRH.Margin = New System.Windows.Forms.Padding(2)
        Me.chkJCIHGRH.Name = "chkJCIHGRH"
        Me.chkJCIHGRH.Size = New System.Drawing.Size(76, 17)
        Me.chkJCIHGRH.TabIndex = 40
        Me.chkJCIHGRH.Text = "JCI HGRH"
        Me.chkJCIHGRH.UseVisualStyleBackColor = True
        '
        'chkHGRH_Conv
        '
        Me.chkHGRH_Conv.AutoSize = True
        Me.chkHGRH_Conv.Enabled = False
        Me.chkHGRH_Conv.Location = New System.Drawing.Point(30, 47)
        Me.chkHGRH_Conv.Margin = New System.Windows.Forms.Padding(2)
        Me.chkHGRH_Conv.Name = "chkHGRH_Conv"
        Me.chkHGRH_Conv.Size = New System.Drawing.Size(103, 17)
        Me.chkHGRH_Conv.TabIndex = 39
        Me.chkHGRH_Conv.Text = "Mod Conversion"
        Me.chkHGRH_Conv.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optFisenHGBP)
        Me.GroupBox8.Controls.Add(Me.optJCIHGBP)
        Me.GroupBox8.Location = New System.Drawing.Point(437, 5)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(140, 116)
        Me.GroupBox8.TabIndex = 38
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Hot Gas Bypass"
        '
        'optFisenHGBP
        '
        Me.optFisenHGBP.AutoSize = True
        Me.optFisenHGBP.Location = New System.Drawing.Point(5, 41)
        Me.optFisenHGBP.Name = "optFisenHGBP"
        Me.optFisenHGBP.Size = New System.Drawing.Size(98, 17)
        Me.optFisenHGBP.TabIndex = 3
        Me.optFisenHGBP.Text = "Fisen HGBP (1)"
        Me.optFisenHGBP.UseVisualStyleBackColor = True
        '
        'optJCIHGBP
        '
        Me.optJCIHGBP.AutoSize = True
        Me.optJCIHGBP.Checked = True
        Me.optJCIHGBP.Location = New System.Drawing.Point(5, 18)
        Me.optJCIHGBP.Name = "optJCIHGBP"
        Me.optJCIHGBP.Size = New System.Drawing.Size(88, 17)
        Me.optJCIHGBP.TabIndex = 1
        Me.optJCIHGBP.TabStop = True
        Me.optJCIHGBP.Text = "JCI HGBP (1)"
        Me.optJCIHGBP.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkModEHeat)
        Me.GroupBox9.Controls.Add(Me.optHeatcoGas)
        Me.GroupBox9.Controls.Add(Me.chkModHeat)
        Me.GroupBox9.Controls.Add(Me.optSteamHeat)
        Me.GroupBox9.Controls.Add(Me.optHWHeat)
        Me.GroupBox9.Controls.Add(Me.optEHeat)
        Me.GroupBox9.Controls.Add(Me.optGasHeat)
        Me.GroupBox9.Controls.Add(Me.optNoHeat)
        Me.GroupBox9.Location = New System.Drawing.Point(221, 6)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(212, 116)
        Me.GroupBox9.TabIndex = 37
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Heat Type"
        '
        'chkModEHeat
        '
        Me.chkModEHeat.AutoSize = True
        Me.chkModEHeat.Enabled = False
        Me.chkModEHeat.Location = New System.Drawing.Point(70, 41)
        Me.chkModEHeat.Margin = New System.Windows.Forms.Padding(2)
        Me.chkModEHeat.Name = "chkModEHeat"
        Me.chkModEHeat.Size = New System.Drawing.Size(120, 17)
        Me.chkModEHeat.TabIndex = 39
        Me.chkModEHeat.Text = "Modulation by Fisen"
        Me.chkModEHeat.UseVisualStyleBackColor = True
        '
        'optHeatcoGas
        '
        Me.optHeatcoGas.AutoSize = True
        Me.optHeatcoGas.Location = New System.Drawing.Point(5, 88)
        Me.optHeatcoGas.Name = "optHeatcoGas"
        Me.optHeatcoGas.Size = New System.Drawing.Size(82, 17)
        Me.optHeatcoGas.TabIndex = 38
        Me.optHeatcoGas.Text = "Gas Heatco"
        Me.optHeatcoGas.UseVisualStyleBackColor = True
        '
        'chkModHeat
        '
        Me.chkModHeat.AutoSize = True
        Me.chkModHeat.Enabled = False
        Me.chkModHeat.Location = New System.Drawing.Point(70, 67)
        Me.chkModHeat.Margin = New System.Windows.Forms.Padding(2)
        Me.chkModHeat.Name = "chkModHeat"
        Me.chkModHeat.Size = New System.Drawing.Size(120, 17)
        Me.chkModHeat.TabIndex = 37
        Me.chkModHeat.Text = "Modulation by Fisen"
        Me.chkModHeat.UseVisualStyleBackColor = True
        '
        'optSteamHeat
        '
        Me.optSteamHeat.AutoSize = True
        Me.optSteamHeat.Location = New System.Drawing.Point(150, 19)
        Me.optSteamHeat.Name = "optSteamHeat"
        Me.optSteamHeat.Size = New System.Drawing.Size(55, 17)
        Me.optSteamHeat.TabIndex = 5
        Me.optSteamHeat.Text = "Steam"
        Me.optSteamHeat.UseVisualStyleBackColor = True
        '
        'optHWHeat
        '
        Me.optHWHeat.AutoSize = True
        Me.optHWHeat.Location = New System.Drawing.Point(70, 18)
        Me.optHWHeat.Name = "optHWHeat"
        Me.optHWHeat.Size = New System.Drawing.Size(74, 17)
        Me.optHWHeat.TabIndex = 4
        Me.optHWHeat.Text = "Hot Water"
        Me.optHWHeat.UseVisualStyleBackColor = True
        '
        'optEHeat
        '
        Me.optEHeat.AutoSize = True
        Me.optEHeat.Location = New System.Drawing.Point(5, 41)
        Me.optEHeat.Name = "optEHeat"
        Me.optEHeat.Size = New System.Drawing.Size(60, 17)
        Me.optEHeat.TabIndex = 3
        Me.optEHeat.Text = "Electric"
        Me.optEHeat.UseVisualStyleBackColor = True
        '
        'optGasHeat
        '
        Me.optGasHeat.AutoSize = True
        Me.optGasHeat.Location = New System.Drawing.Point(5, 66)
        Me.optGasHeat.Name = "optGasHeat"
        Me.optGasHeat.Size = New System.Drawing.Size(44, 17)
        Me.optGasHeat.TabIndex = 2
        Me.optGasHeat.Text = "Gas"
        Me.optGasHeat.UseVisualStyleBackColor = True
        '
        'optNoHeat
        '
        Me.optNoHeat.AutoSize = True
        Me.optNoHeat.Checked = True
        Me.optNoHeat.Location = New System.Drawing.Point(5, 18)
        Me.optNoHeat.Name = "optNoHeat"
        Me.optNoHeat.Size = New System.Drawing.Size(51, 17)
        Me.optNoHeat.TabIndex = 1
        Me.optNoHeat.TabStop = True
        Me.optNoHeat.Text = "None"
        Me.optNoHeat.UseVisualStyleBackColor = True
        '
        'chkFisenMHGRH
        '
        Me.chkFisenMHGRH.AutoSize = True
        Me.chkFisenMHGRH.Enabled = False
        Me.chkFisenMHGRH.Location = New System.Drawing.Point(30, 89)
        Me.chkFisenMHGRH.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFisenMHGRH.Name = "chkFisenMHGRH"
        Me.chkFisenMHGRH.Size = New System.Drawing.Size(78, 17)
        Me.chkFisenMHGRH.TabIndex = 35
        Me.chkFisenMHGRH.Text = "Modulating"
        Me.chkFisenMHGRH.UseVisualStyleBackColor = True
        '
        'chkFisenHGRH
        '
        Me.chkFisenHGRH.AutoSize = True
        Me.chkFisenHGRH.Location = New System.Drawing.Point(5, 68)
        Me.chkFisenHGRH.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFisenHGRH.Name = "chkFisenHGRH"
        Me.chkFisenHGRH.Size = New System.Drawing.Size(86, 17)
        Me.chkFisenHGRH.TabIndex = 34
        Me.chkFisenHGRH.Text = "Fisen HGRH"
        Me.chkFisenHGRH.UseVisualStyleBackColor = True
        '
        'chkLowAF
        '
        Me.chkLowAF.AutoSize = True
        Me.chkLowAF.Location = New System.Drawing.Point(5, 6)
        Me.chkLowAF.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLowAF.Name = "chkLowAF"
        Me.chkLowAF.Size = New System.Drawing.Size(104, 17)
        Me.chkLowAF.TabIndex = 33
        Me.chkLowAF.Text = "Reduced Airflow"
        Me.chkLowAF.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.grpReturn)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(579, 194)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbAuxPanelOpts)
        Me.GroupBox3.Controls.Add(Me.optUseAux)
        Me.GroupBox3.Controls.Add(Me.optNoAux)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 105)
        Me.GroupBox3.TabIndex = 28
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt100OACapable)
        Me.GroupBox1.Controls.Add(Me.opt100OA)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 71)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversion"
        '
        'opt100OACapable
        '
        Me.opt100OACapable.AutoSize = True
        Me.opt100OACapable.Location = New System.Drawing.Point(6, 42)
        Me.opt100OACapable.Name = "opt100OACapable"
        Me.opt100OACapable.Size = New System.Drawing.Size(149, 17)
        Me.opt100OACapable.TabIndex = 1
        Me.opt100OACapable.TabStop = True
        Me.opt100OACapable.Text = "100% Outdoor Air Capable"
        Me.opt100OACapable.UseVisualStyleBackColor = True
        '
        'opt100OA
        '
        Me.opt100OA.AutoSize = True
        Me.opt100OA.Checked = True
        Me.opt100OA.Location = New System.Drawing.Point(6, 19)
        Me.opt100OA.Name = "opt100OA"
        Me.opt100OA.Size = New System.Drawing.Size(107, 17)
        Me.opt100OA.TabIndex = 0
        Me.opt100OA.TabStop = True
        Me.opt100OA.Text = "100% Outdoor Air"
        Me.opt100OA.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkZoneOvrSensor)
        Me.tpgControls.Controls.Add(Me.grp100OACapable)
        Me.tpgControls.Controls.Add(Me.grpModeCtrl)
        Me.tpgControls.Controls.Add(Me.grpHeatCtrl)
        Me.tpgControls.Controls.Add(Me.grpGBASCtrl4)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(579, 194)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkZoneOvrSensor
        '
        Me.chkZoneOvrSensor.AutoSize = True
        Me.chkZoneOvrSensor.Location = New System.Drawing.Point(6, 172)
        Me.chkZoneOvrSensor.Margin = New System.Windows.Forms.Padding(2)
        Me.chkZoneOvrSensor.Name = "chkZoneOvrSensor"
        Me.chkZoneOvrSensor.Size = New System.Drawing.Size(130, 17)
        Me.chkZoneOvrSensor.TabIndex = 35
        Me.chkZoneOvrSensor.Text = "Zone Override Sensor"
        Me.chkZoneOvrSensor.UseVisualStyleBackColor = True
        '
        'grp100OACapable
        '
        Me.grp100OACapable.Controls.Add(Me.optCoolCtrlByIPU)
        Me.grp100OACapable.Controls.Add(Me.optCoolCtrlBySE)
        Me.grp100OACapable.Controls.Add(Me.optCoolCtrlGBAS)
        Me.grp100OACapable.Controls.Add(Me.optCoolCtrlStagedOA)
        Me.grp100OACapable.Controls.Add(Me.optCoolCtrlDAByFisenSE)
        Me.grp100OACapable.Location = New System.Drawing.Point(6, 74)
        Me.grp100OACapable.Name = "grp100OACapable"
        Me.grp100OACapable.Size = New System.Drawing.Size(307, 93)
        Me.grp100OACapable.TabIndex = 31
        Me.grp100OACapable.TabStop = False
        Me.grp100OACapable.Text = "Cool Control"
        '
        'optCoolCtrlByIPU
        '
        Me.optCoolCtrlByIPU.AutoSize = True
        Me.optCoolCtrlByIPU.Enabled = False
        Me.optCoolCtrlByIPU.Location = New System.Drawing.Point(132, 65)
        Me.optCoolCtrlByIPU.Name = "optCoolCtrlByIPU"
        Me.optCoolCtrlByIPU.Size = New System.Drawing.Size(96, 17)
        Me.optCoolCtrlByIPU.TabIndex = 10
        Me.optCoolCtrlByIPU.Text = "DA Ctrl(by IPU)"
        Me.optCoolCtrlByIPU.UseVisualStyleBackColor = True
        '
        'optCoolCtrlBySE
        '
        Me.optCoolCtrlBySE.AutoSize = True
        Me.optCoolCtrlBySE.Enabled = False
        Me.optCoolCtrlBySE.Location = New System.Drawing.Point(132, 42)
        Me.optCoolCtrlBySE.Name = "optCoolCtrlBySE"
        Me.optCoolCtrlBySE.Size = New System.Drawing.Size(92, 17)
        Me.optCoolCtrlBySE.TabIndex = 9
        Me.optCoolCtrlBySE.Text = "DA Ctrl(by SE)"
        Me.optCoolCtrlBySE.UseVisualStyleBackColor = True
        '
        'optCoolCtrlGBAS
        '
        Me.optCoolCtrlGBAS.AutoSize = True
        Me.optCoolCtrlGBAS.Enabled = False
        Me.optCoolCtrlGBAS.Location = New System.Drawing.Point(6, 65)
        Me.optCoolCtrlGBAS.Name = "optCoolCtrlGBAS"
        Me.optCoolCtrlGBAS.Size = New System.Drawing.Size(54, 17)
        Me.optCoolCtrlGBAS.TabIndex = 8
        Me.optCoolCtrlGBAS.Text = "GBAS"
        Me.optCoolCtrlGBAS.UseVisualStyleBackColor = True
        '
        'optCoolCtrlStagedOA
        '
        Me.optCoolCtrlStagedOA.AutoSize = True
        Me.optCoolCtrlStagedOA.Checked = True
        Me.optCoolCtrlStagedOA.Location = New System.Drawing.Point(6, 19)
        Me.optCoolCtrlStagedOA.Name = "optCoolCtrlStagedOA"
        Me.optCoolCtrlStagedOA.Size = New System.Drawing.Size(74, 17)
        Me.optCoolCtrlStagedOA.TabIndex = 7
        Me.optCoolCtrlStagedOA.TabStop = True
        Me.optCoolCtrlStagedOA.Text = "StagedOA"
        Me.optCoolCtrlStagedOA.UseVisualStyleBackColor = True
        '
        'optCoolCtrlDAByFisenSE
        '
        Me.optCoolCtrlDAByFisenSE.AutoSize = True
        Me.optCoolCtrlDAByFisenSE.Enabled = False
        Me.optCoolCtrlDAByFisenSE.Location = New System.Drawing.Point(6, 42)
        Me.optCoolCtrlDAByFisenSE.Name = "optCoolCtrlDAByFisenSE"
        Me.optCoolCtrlDAByFisenSE.Size = New System.Drawing.Size(120, 17)
        Me.optCoolCtrlDAByFisenSE.TabIndex = 6
        Me.optCoolCtrlDAByFisenSE.Text = "DA Ctrl(by Fisen-SE)"
        Me.optCoolCtrlDAByFisenSE.UseVisualStyleBackColor = True
        '
        'grpModeCtrl
        '
        Me.grpModeCtrl.Controls.Add(Me.optModeNoChange)
        Me.grpModeCtrl.Controls.Add(Me.optModeDATOnly)
        Me.grpModeCtrl.Controls.Add(Me.optModeGBAS)
        Me.grpModeCtrl.Controls.Add(Me.optModeAuto)
        Me.grpModeCtrl.Location = New System.Drawing.Point(319, 78)
        Me.grpModeCtrl.Name = "grpModeCtrl"
        Me.grpModeCtrl.Size = New System.Drawing.Size(188, 89)
        Me.grpModeCtrl.TabIndex = 29
        Me.grpModeCtrl.TabStop = False
        Me.grpModeCtrl.Text = "Mode Control "
        '
        'optModeNoChange
        '
        Me.optModeNoChange.AutoSize = True
        Me.optModeNoChange.Location = New System.Drawing.Point(83, 65)
        Me.optModeNoChange.Name = "optModeNoChange"
        Me.optModeNoChange.Size = New System.Drawing.Size(79, 17)
        Me.optModeNoChange.TabIndex = 7
        Me.optModeNoChange.TabStop = True
        Me.optModeNoChange.Text = "No Change"
        Me.optModeNoChange.UseVisualStyleBackColor = True
        '
        'optModeDATOnly
        '
        Me.optModeDATOnly.AutoSize = True
        Me.optModeDATOnly.Location = New System.Drawing.Point(6, 65)
        Me.optModeDATOnly.Name = "optModeDATOnly"
        Me.optModeDATOnly.Size = New System.Drawing.Size(71, 17)
        Me.optModeDATOnly.TabIndex = 6
        Me.optModeDATOnly.TabStop = True
        Me.optModeDATOnly.Text = "DAT Only"
        Me.optModeDATOnly.UseVisualStyleBackColor = True
        '
        'optModeGBAS
        '
        Me.optModeGBAS.AutoSize = True
        Me.optModeGBAS.Location = New System.Drawing.Point(6, 42)
        Me.optModeGBAS.Name = "optModeGBAS"
        Me.optModeGBAS.Size = New System.Drawing.Size(95, 17)
        Me.optModeGBAS.TabIndex = 5
        Me.optModeGBAS.TabStop = True
        Me.optModeGBAS.Text = "GBAS Controls"
        Me.optModeGBAS.UseVisualStyleBackColor = True
        '
        'optModeAuto
        '
        Me.optModeAuto.AutoSize = True
        Me.optModeAuto.Checked = True
        Me.optModeAuto.Location = New System.Drawing.Point(6, 19)
        Me.optModeAuto.Name = "optModeAuto"
        Me.optModeAuto.Size = New System.Drawing.Size(131, 17)
        Me.optModeAuto.TabIndex = 4
        Me.optModeAuto.TabStop = True
        Me.optModeAuto.Text = "Auto Mode (OA Temp)"
        Me.optModeAuto.UseVisualStyleBackColor = True
        '
        'grpHeatCtrl
        '
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlDABaseUnit)
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlDAByFisen)
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlGBAS)
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlDAFutureTB)
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlDAFieldInstTB)
        Me.grpHeatCtrl.Controls.Add(Me.optHeatCtrlStagedOA)
        Me.grpHeatCtrl.Location = New System.Drawing.Point(6, 6)
        Me.grpHeatCtrl.Name = "grpHeatCtrl"
        Me.grpHeatCtrl.Size = New System.Drawing.Size(307, 68)
        Me.grpHeatCtrl.TabIndex = 28
        Me.grpHeatCtrl.TabStop = False
        Me.grpHeatCtrl.Text = "Heat Control"
        '
        'optHeatCtrlDABaseUnit
        '
        Me.optHeatCtrlDABaseUnit.AutoSize = True
        Me.optHeatCtrlDABaseUnit.Enabled = False
        Me.optHeatCtrlDABaseUnit.Location = New System.Drawing.Point(124, 45)
        Me.optHeatCtrlDABaseUnit.Name = "optHeatCtrlDABaseUnit"
        Me.optHeatCtrlDABaseUnit.Size = New System.Drawing.Size(113, 17)
        Me.optHeatCtrlDABaseUnit.TabIndex = 11
        Me.optHeatCtrlDABaseUnit.Text = "DA Ctrl - Base Unit"
        Me.optHeatCtrlDABaseUnit.UseVisualStyleBackColor = True
        '
        'optHeatCtrlDAByFisen
        '
        Me.optHeatCtrlDAByFisen.AutoSize = True
        Me.optHeatCtrlDAByFisen.Enabled = False
        Me.optHeatCtrlDAByFisen.Location = New System.Drawing.Point(6, 45)
        Me.optHeatCtrlDAByFisen.Name = "optHeatCtrlDAByFisen"
        Me.optHeatCtrlDAByFisen.Size = New System.Drawing.Size(107, 17)
        Me.optHeatCtrlDAByFisen.TabIndex = 10
        Me.optHeatCtrlDAByFisen.Text = "DA Ctrl - By Fisen"
        Me.optHeatCtrlDAByFisen.UseVisualStyleBackColor = True
        '
        'optHeatCtrlGBAS
        '
        Me.optHeatCtrlGBAS.AutoSize = True
        Me.optHeatCtrlGBAS.Enabled = False
        Me.optHeatCtrlGBAS.Location = New System.Drawing.Point(243, 45)
        Me.optHeatCtrlGBAS.Name = "optHeatCtrlGBAS"
        Me.optHeatCtrlGBAS.Size = New System.Drawing.Size(54, 17)
        Me.optHeatCtrlGBAS.TabIndex = 9
        Me.optHeatCtrlGBAS.Text = "GBAS"
        Me.optHeatCtrlGBAS.UseVisualStyleBackColor = True
        '
        'optHeatCtrlDAFutureTB
        '
        Me.optHeatCtrlDAFutureTB.AutoSize = True
        Me.optHeatCtrlDAFutureTB.Location = New System.Drawing.Point(124, 22)
        Me.optHeatCtrlDAFutureTB.Name = "optHeatCtrlDAFutureTB"
        Me.optHeatCtrlDAFutureTB.Size = New System.Drawing.Size(85, 17)
        Me.optHeatCtrlDAFutureTB.TabIndex = 8
        Me.optHeatCtrlDAFutureTB.TabStop = True
        Me.optHeatCtrlDAFutureTB.Text = "DA Ctrl (Fut.)"
        Me.optHeatCtrlDAFutureTB.UseVisualStyleBackColor = True
        '
        'optHeatCtrlDAFieldInstTB
        '
        Me.optHeatCtrlDAFieldInstTB.AutoSize = True
        Me.optHeatCtrlDAFieldInstTB.Location = New System.Drawing.Point(219, 22)
        Me.optHeatCtrlDAFieldInstTB.Name = "optHeatCtrlDAFieldInstTB"
        Me.optHeatCtrlDAFieldInstTB.Size = New System.Drawing.Size(83, 17)
        Me.optHeatCtrlDAFieldInstTB.TabIndex = 7
        Me.optHeatCtrlDAFieldInstTB.TabStop = True
        Me.optHeatCtrlDAFieldInstTB.Text = "DA Ctrl Field"
        Me.optHeatCtrlDAFieldInstTB.UseVisualStyleBackColor = True
        '
        'optHeatCtrlStagedOA
        '
        Me.optHeatCtrlStagedOA.AutoSize = True
        Me.optHeatCtrlStagedOA.Checked = True
        Me.optHeatCtrlStagedOA.Location = New System.Drawing.Point(6, 22)
        Me.optHeatCtrlStagedOA.Name = "optHeatCtrlStagedOA"
        Me.optHeatCtrlStagedOA.Size = New System.Drawing.Size(116, 17)
        Me.optHeatCtrlStagedOA.TabIndex = 6
        Me.optHeatCtrlStagedOA.TabStop = True
        Me.optHeatCtrlStagedOA.Text = "DA Ctrl (StagedOA)"
        Me.optHeatCtrlStagedOA.UseVisualStyleBackColor = True
        '
        'grpGBASCtrl4
        '
        Me.grpGBASCtrl4.Controls.Add(Me.chkGBASOADamper)
        Me.grpGBASCtrl4.Controls.Add(Me.optGBASFuture)
        Me.grpGBASCtrl4.Controls.Add(Me.optGBAS3Level)
        Me.grpGBASCtrl4.Controls.Add(Me.optGBASVernier)
        Me.grpGBASCtrl4.Enabled = False
        Me.grpGBASCtrl4.Location = New System.Drawing.Point(319, 6)
        Me.grpGBASCtrl4.Name = "grpGBASCtrl4"
        Me.grpGBASCtrl4.Size = New System.Drawing.Size(224, 68)
        Me.grpGBASCtrl4.TabIndex = 27
        Me.grpGBASCtrl4.TabStop = False
        Me.grpGBASCtrl4.Text = "GBAS Controls"
        '
        'chkGBASOADamper
        '
        Me.chkGBASOADamper.AutoSize = True
        Me.chkGBASOADamper.Location = New System.Drawing.Point(138, 42)
        Me.chkGBASOADamper.Name = "chkGBASOADamper"
        Me.chkGBASOADamper.Size = New System.Drawing.Size(81, 17)
        Me.chkGBASOADamper.TabIndex = 5
        Me.chkGBASOADamper.Text = "OA Damper"
        Me.chkGBASOADamper.UseVisualStyleBackColor = True
        '
        'optGBASFuture
        '
        Me.optGBASFuture.AutoSize = True
        Me.optGBASFuture.Location = New System.Drawing.Point(96, 19)
        Me.optGBASFuture.Name = "optGBASFuture"
        Me.optGBASFuture.Size = New System.Drawing.Size(123, 17)
        Me.optGBASFuture.TabIndex = 4
        Me.optGBASFuture.TabStop = True
        Me.optGBASFuture.Text = "Future Heat (Vernier)"
        Me.optGBASFuture.UseVisualStyleBackColor = True
        '
        'optGBAS3Level
        '
        Me.optGBAS3Level.AutoSize = True
        Me.optGBAS3Level.Location = New System.Drawing.Point(6, 41)
        Me.optGBAS3Level.Name = "optGBAS3Level"
        Me.optGBAS3Level.Size = New System.Drawing.Size(117, 17)
        Me.optGBAS3Level.TabIndex = 3
        Me.optGBAS3Level.TabStop = True
        Me.optGBAS3Level.Text = "Off/Low/High Heat"
        Me.optGBAS3Level.UseVisualStyleBackColor = True
        '
        'optGBASVernier
        '
        Me.optGBASVernier.AutoSize = True
        Me.optGBASVernier.Location = New System.Drawing.Point(6, 19)
        Me.optGBASVernier.Name = "optGBASVernier"
        Me.optGBASVernier.Size = New System.Drawing.Size(84, 17)
        Me.optGBASVernier.TabIndex = 2
        Me.optGBASVernier.Text = "Vernier Heat"
        Me.optGBASVernier.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 194)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDonePerformance.Location = New System.Drawing.Point(513, 153)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(579, 194)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'grpReturn
        '
        Me.grpReturn.Controls.Add(Me.optReturnHorizontal)
        Me.grpReturn.Controls.Add(Me.optReturnBottom)
        Me.grpReturn.Location = New System.Drawing.Point(226, 6)
        Me.grpReturn.Name = "grpReturn"
        Me.grpReturn.Size = New System.Drawing.Size(144, 71)
        Me.grpReturn.TabIndex = 29
        Me.grpReturn.TabStop = False
        Me.grpReturn.Text = "Return"
        '
        'optReturnHorizontal
        '
        Me.optReturnHorizontal.AutoSize = True
        Me.optReturnHorizontal.Location = New System.Drawing.Point(6, 42)
        Me.optReturnHorizontal.Name = "optReturnHorizontal"
        Me.optReturnHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.optReturnHorizontal.TabIndex = 3
        Me.optReturnHorizontal.Text = "Horizontal"
        Me.optReturnHorizontal.UseVisualStyleBackColor = True
        '
        'optReturnBottom
        '
        Me.optReturnBottom.AutoSize = True
        Me.optReturnBottom.Location = New System.Drawing.Point(6, 19)
        Me.optReturnBottom.Name = "optReturnBottom"
        Me.optReturnBottom.Size = New System.Drawing.Size(58, 17)
        Me.optReturnBottom.TabIndex = 2
        Me.optReturnBottom.Text = "Bottom"
        Me.optReturnBottom.UseVisualStyleBackColor = True
        '
        'frm100OA
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm100OA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "100% Outdoor Air"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.grp100OACapable.ResumeLayout(False)
        Me.grp100OACapable.PerformLayout()
        Me.grpModeCtrl.ResumeLayout(False)
        Me.grpModeCtrl.PerformLayout()
        Me.grpHeatCtrl.ResumeLayout(False)
        Me.grpHeatCtrl.PerformLayout()
        Me.grpGBASCtrl4.ResumeLayout(False)
        Me.grpGBASCtrl4.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.grpReturn.ResumeLayout(False)
        Me.grpReturn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents grpModeCtrl As GroupBox
    Friend WithEvents optModeGBAS As RadioButton
    Friend WithEvents optModeAuto As RadioButton
    Friend WithEvents grpHeatCtrl As GroupBox
    Friend WithEvents optHeatCtrlDAFutureTB As RadioButton
    Friend WithEvents optHeatCtrlDAFieldInstTB As RadioButton
    Friend WithEvents optHeatCtrlStagedOA As RadioButton
    Friend WithEvents grpGBASCtrl4 As GroupBox
    Friend WithEvents chkGBASOADamper As CheckBox
    Friend WithEvents optGBASFuture As RadioButton
    Friend WithEvents optGBAS3Level As RadioButton
    Friend WithEvents optGBASVernier As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opt100OACapable As RadioButton
    Friend WithEvents opt100OA As RadioButton
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents optFisenHGBP As RadioButton
    Friend WithEvents optJCIHGBP As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents chkModHeat As CheckBox
    Friend WithEvents optSteamHeat As RadioButton
    Friend WithEvents optHWHeat As RadioButton
    Friend WithEvents optEHeat As RadioButton
    Friend WithEvents optGasHeat As RadioButton
    Friend WithEvents optNoHeat As RadioButton
    Friend WithEvents chkFisenMHGRH As CheckBox
    Friend WithEvents chkFisenHGRH As CheckBox
    Friend WithEvents chkLowAF As CheckBox
    Friend WithEvents chkJCIHGRH As CheckBox
    Friend WithEvents chkHGRH_Conv As CheckBox
    Friend WithEvents optModeDATOnly As RadioButton
    Friend WithEvents optHeatCtrlDAByFisen As RadioButton
    Friend WithEvents optHeatCtrlGBAS As RadioButton
    Friend WithEvents grp100OACapable As GroupBox
    Friend WithEvents optCoolCtrlGBAS As RadioButton
    Friend WithEvents optCoolCtrlStagedOA As RadioButton
    Friend WithEvents optCoolCtrlDAByFisenSE As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents chkZoneOvrSensor As CheckBox
    Friend WithEvents optHeatcoGas As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents chkModEHeat As CheckBox
    Friend WithEvents optCoolCtrlByIPU As RadioButton
    Friend WithEvents optCoolCtrlBySE As RadioButton
    Friend WithEvents optHeatCtrlDABaseUnit As RadioButton
    Friend WithEvents optModeNoChange As RadioButton
    Friend WithEvents chkIntellispeed As CheckBox
    Friend WithEvents grpReturn As GroupBox
    Friend WithEvents optReturnHorizontal As RadioButton
    Friend WithEvents optReturnBottom As RadioButton
End Class
