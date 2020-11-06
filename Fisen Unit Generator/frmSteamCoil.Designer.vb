<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSteamCoil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSteamCoil))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgConditions = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSteamPressure = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOutputCap = New System.Windows.Forms.TextBox()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.pgOptions = New System.Windows.Forms.TabPage()
        Me.chkS40DrawThroughCoil = New System.Windows.Forms.CheckBox()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optCoil2Row = New System.Windows.Forms.RadioButton()
        Me.optCoil1Row = New System.Windows.Forms.RadioButton()
        Me.optCoilCustom = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optValveFieldProvFieldInst = New System.Windows.Forms.RadioButton()
        Me.optValveFisenProvFisenInst = New System.Windows.Forms.RadioButton()
        Me.optValveFisenProvFieldInst = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optValveModulating = New System.Windows.Forms.RadioButton()
        Me.optValveOnOff = New System.Windows.Forms.RadioButton()
        Me.optValveNone = New System.Windows.Forms.RadioButton()
        Me.chkEpoxy = New System.Windows.Forms.CheckBox()
        Me.pgDSOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optDSFanOutlet = New System.Windows.Forms.RadioButton()
        Me.optDSFanInlet = New System.Windows.Forms.RadioButton()
        Me.btnDoneDSOptions = New System.Windows.Forms.Button()
        Me.pgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optBU_SE_Fisen_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fact_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_Other = New System.Windows.Forms.RadioButton()
        Me.optBU_IPU_Unwired = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fact_FisenWires = New System.Windows.Forms.RadioButton()
        Me.optBU_IPU_FisenWires = New System.Windows.Forms.RadioButton()
        Me.optBU_SE_Fisen_FisenWires = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cmbValveCtrlFisenCustom = New System.Windows.Forms.ComboBox()
        Me.optValveCtrlFisenCustom = New System.Windows.Forms.RadioButton()
        Me.optValveCtrlBaseUnit = New System.Windows.Forms.RadioButton()
        Me.optValveCtrlNone = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkBreakonLL = New System.Windows.Forms.CheckBox()
        Me.optLLWired = New System.Windows.Forms.RadioButton()
        Me.optLLUnwired = New System.Windows.Forms.RadioButton()
        Me.pgPerf = New System.Windows.Forms.TabPage()
        Me.optCoilOnly = New System.Windows.Forms.RadioButton()
        Me.optAPDAllowance = New System.Windows.Forms.RadioButton()
        Me.txtOutletSize = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInletSize = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOutCap = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCoilAPD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCondFlow = New System.Windows.Forms.TextBox()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.tpgValves = New System.Windows.Forms.TabPage()
        Me.cmbValveDesc = New System.Windows.Forms.ComboBox()
        Me.cmbValveSize = New System.Windows.Forms.ComboBox()
        Me.txtValveMPN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValveType = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValveTag = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnDoneValve = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sciConnections = New System.Windows.Forms.PictureBox()
        Me.btnSelectAValve = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.pgConditions.SuspendLayout()
        Me.pgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pgDSOptions.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pgControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pgPerf.SuspendLayout()
        Me.tpgValves.SuspendLayout()
        CType(Me.sciConnections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(7, 291)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(85, 291)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgConditions)
        Me.TabControl1.Controls.Add(Me.pgOptions)
        Me.TabControl1.Controls.Add(Me.pgDSOptions)
        Me.TabControl1.Controls.Add(Me.pgControls)
        Me.TabControl1.Controls.Add(Me.pgPerf)
        Me.TabControl1.Controls.Add(Me.tpgValves)
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 275)
        Me.TabControl1.TabIndex = 2
        '
        'pgConditions
        '
        Me.pgConditions.Controls.Add(Me.Label4)
        Me.pgConditions.Controls.Add(Me.txtSteamPressure)
        Me.pgConditions.Controls.Add(Me.btnDoneConditions)
        Me.pgConditions.Controls.Add(Me.Label3)
        Me.pgConditions.Controls.Add(Me.txtOutputCap)
        Me.pgConditions.Controls.Add(Me.txtHeatAF)
        Me.pgConditions.Controls.Add(Me.Label2)
        Me.pgConditions.Controls.Add(Me.Label1)
        Me.pgConditions.Controls.Add(Me.txtEAT)
        Me.pgConditions.Location = New System.Drawing.Point(4, 22)
        Me.pgConditions.Name = "pgConditions"
        Me.pgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.pgConditions.Size = New System.Drawing.Size(440, 249)
        Me.pgConditions.TabIndex = 0
        Me.pgConditions.Text = "Conditions"
        Me.pgConditions.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Steam Pressure(psi)"
        '
        'txtSteamPressure
        '
        Me.txtSteamPressure.Location = New System.Drawing.Point(5, 86)
        Me.txtSteamPressure.Name = "txtSteamPressure"
        Me.txtSteamPressure.Size = New System.Drawing.Size(40, 20)
        Me.txtSteamPressure.TabIndex = 4
        Me.txtSteamPressure.Text = "88888"
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 220)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 5
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Output Capacity(mbh)"
        '
        'txtOutputCap
        '
        Me.txtOutputCap.Location = New System.Drawing.Point(5, 59)
        Me.txtOutputCap.Name = "txtOutputCap"
        Me.txtOutputCap.Size = New System.Drawing.Size(40, 20)
        Me.txtOutputCap.TabIndex = 3
        Me.txtOutputCap.Text = "88888"
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(5, 6)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(40, 20)
        Me.txtHeatAF.TabIndex = 1
        Me.txtHeatAF.Text = "88888"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(5, 32)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(40, 20)
        Me.txtEAT.TabIndex = 2
        Me.txtEAT.Text = "88888"
        '
        'pgOptions
        '
        Me.pgOptions.Controls.Add(Me.chkS40DrawThroughCoil)
        Me.pgOptions.Controls.Add(Me.fraAuxPanel)
        Me.pgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.pgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.pgOptions.Controls.Add(Me.GroupBox6)
        Me.pgOptions.Controls.Add(Me.btnDoneOptions)
        Me.pgOptions.Controls.Add(Me.GroupBox2)
        Me.pgOptions.Controls.Add(Me.GroupBox1)
        Me.pgOptions.Controls.Add(Me.chkEpoxy)
        Me.pgOptions.Location = New System.Drawing.Point(4, 22)
        Me.pgOptions.Name = "pgOptions"
        Me.pgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.pgOptions.Size = New System.Drawing.Size(440, 249)
        Me.pgOptions.TabIndex = 1
        Me.pgOptions.Text = "Options"
        Me.pgOptions.UseVisualStyleBackColor = True
        '
        'chkS40DrawThroughCoil
        '
        Me.chkS40DrawThroughCoil.AutoSize = True
        Me.chkS40DrawThroughCoil.Location = New System.Drawing.Point(6, 123)
        Me.chkS40DrawThroughCoil.Name = "chkS40DrawThroughCoil"
        Me.chkS40DrawThroughCoil.Size = New System.Drawing.Size(195, 17)
        Me.chkS40DrawThroughCoil.TabIndex = 51
        Me.chkS40DrawThroughCoil.Text = "Install Coil in Draw Through Position"
        Me.chkS40DrawThroughCoil.UseVisualStyleBackColor = True
        Me.chkS40DrawThroughCoil.Visible = False
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Enabled = False
        Me.fraAuxPanel.Location = New System.Drawing.Point(212, 104)
        Me.fraAuxPanel.Name = "fraAuxPanel"
        Me.fraAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.fraAuxPanel.TabIndex = 50
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
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(21, 228)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 35
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(6, 210)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 34
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optCoil2Row)
        Me.GroupBox6.Controls.Add(Me.optCoil1Row)
        Me.GroupBox6.Controls.Add(Me.optCoilCustom)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(131, 92)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Coil"
        '
        'optCoil2Row
        '
        Me.optCoil2Row.AutoSize = True
        Me.optCoil2Row.Enabled = False
        Me.optCoil2Row.Location = New System.Drawing.Point(6, 66)
        Me.optCoil2Row.Name = "optCoil2Row"
        Me.optCoil2Row.Size = New System.Drawing.Size(102, 17)
        Me.optCoil2Row.TabIndex = 2
        Me.optCoil2Row.Text = "Standard 2 Row"
        Me.optCoil2Row.UseVisualStyleBackColor = True
        '
        'optCoil1Row
        '
        Me.optCoil1Row.AutoSize = True
        Me.optCoil1Row.Enabled = False
        Me.optCoil1Row.Location = New System.Drawing.Point(6, 43)
        Me.optCoil1Row.Name = "optCoil1Row"
        Me.optCoil1Row.Size = New System.Drawing.Size(102, 17)
        Me.optCoil1Row.TabIndex = 1
        Me.optCoil1Row.Text = "Standard 1 Row"
        Me.optCoil1Row.UseVisualStyleBackColor = True
        '
        'optCoilCustom
        '
        Me.optCoilCustom.AutoSize = True
        Me.optCoilCustom.Checked = True
        Me.optCoilCustom.Location = New System.Drawing.Point(6, 20)
        Me.optCoilCustom.Name = "optCoilCustom"
        Me.optCoilCustom.Size = New System.Drawing.Size(123, 17)
        Me.optCoilCustom.TabIndex = 0
        Me.optCoilCustom.TabStop = True
        Me.optCoilCustom.Text = "Custom Performance"
        Me.optCoilCustom.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(385, 220)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 28
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optValveFieldProvFieldInst)
        Me.GroupBox2.Controls.Add(Me.optValveFisenProvFisenInst)
        Me.GroupBox2.Controls.Add(Me.optValveFisenProvFieldInst)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 92)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valve"
        '
        'optValveFieldProvFieldInst
        '
        Me.optValveFieldProvFieldInst.AutoSize = True
        Me.optValveFieldProvFieldInst.Checked = True
        Me.optValveFieldProvFieldInst.Location = New System.Drawing.Point(6, 60)
        Me.optValveFieldProvFieldInst.Name = "optValveFieldProvFieldInst"
        Me.optValveFieldProvFieldInst.Size = New System.Drawing.Size(136, 17)
        Me.optValveFieldProvFieldInst.TabIndex = 5
        Me.optValveFieldProvFieldInst.TabStop = True
        Me.optValveFieldProvFieldInst.Tag = ""
        Me.optValveFieldProvFieldInst.Text = "Field Provided/Installed"
        Me.optValveFieldProvFieldInst.UseVisualStyleBackColor = True
        '
        'optValveFisenProvFisenInst
        '
        Me.optValveFisenProvFisenInst.AutoSize = True
        Me.optValveFisenProvFisenInst.Location = New System.Drawing.Point(6, 14)
        Me.optValveFisenProvFisenInst.Name = "optValveFisenProvFisenInst"
        Me.optValveFisenProvFisenInst.Size = New System.Drawing.Size(139, 17)
        Me.optValveFisenProvFisenInst.TabIndex = 4
        Me.optValveFisenProvFisenInst.Text = "Fisen Provided/Installed"
        Me.optValveFisenProvFisenInst.UseVisualStyleBackColor = True
        '
        'optValveFisenProvFieldInst
        '
        Me.optValveFisenProvFieldInst.AutoSize = True
        Me.optValveFisenProvFieldInst.Location = New System.Drawing.Point(6, 37)
        Me.optValveFisenProvFieldInst.Name = "optValveFisenProvFieldInst"
        Me.optValveFisenProvFieldInst.Size = New System.Drawing.Size(164, 17)
        Me.optValveFisenProvFieldInst.TabIndex = 3
        Me.optValveFisenProvFieldInst.Text = "Fisen Provided/Field Installed"
        Me.optValveFisenProvFieldInst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optValveModulating)
        Me.GroupBox1.Controls.Add(Me.optValveOnOff)
        Me.GroupBox1.Controls.Add(Me.optValveNone)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 92)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valve"
        '
        'optValveModulating
        '
        Me.optValveModulating.AutoSize = True
        Me.optValveModulating.Location = New System.Drawing.Point(15, 66)
        Me.optValveModulating.Name = "optValveModulating"
        Me.optValveModulating.Size = New System.Drawing.Size(77, 17)
        Me.optValveModulating.TabIndex = 2
        Me.optValveModulating.TabStop = True
        Me.optValveModulating.Text = "Modulating"
        Me.optValveModulating.UseVisualStyleBackColor = True
        '
        'optValveOnOff
        '
        Me.optValveOnOff.AutoSize = True
        Me.optValveOnOff.Location = New System.Drawing.Point(15, 43)
        Me.optValveOnOff.Name = "optValveOnOff"
        Me.optValveOnOff.Size = New System.Drawing.Size(58, 17)
        Me.optValveOnOff.TabIndex = 1
        Me.optValveOnOff.TabStop = True
        Me.optValveOnOff.Text = "On/Off"
        Me.optValveOnOff.UseVisualStyleBackColor = True
        '
        'optValveNone
        '
        Me.optValveNone.AutoSize = True
        Me.optValveNone.Checked = True
        Me.optValveNone.Location = New System.Drawing.Point(15, 20)
        Me.optValveNone.Name = "optValveNone"
        Me.optValveNone.Size = New System.Drawing.Size(51, 17)
        Me.optValveNone.TabIndex = 0
        Me.optValveNone.TabStop = True
        Me.optValveNone.Text = "None"
        Me.optValveNone.UseVisualStyleBackColor = True
        '
        'chkEpoxy
        '
        Me.chkEpoxy.AutoSize = True
        Me.chkEpoxy.Location = New System.Drawing.Point(6, 104)
        Me.chkEpoxy.Name = "chkEpoxy"
        Me.chkEpoxy.Size = New System.Drawing.Size(110, 17)
        Me.chkEpoxy.TabIndex = 25
        Me.chkEpoxy.Text = "E-Coat Epoxy Coil"
        Me.chkEpoxy.UseVisualStyleBackColor = True
        '
        'pgDSOptions
        '
        Me.pgDSOptions.Controls.Add(Me.GroupBox7)
        Me.pgDSOptions.Controls.Add(Me.btnDoneDSOptions)
        Me.pgDSOptions.Location = New System.Drawing.Point(4, 22)
        Me.pgDSOptions.Name = "pgDSOptions"
        Me.pgDSOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDSOptions.Size = New System.Drawing.Size(440, 249)
        Me.pgDSOptions.TabIndex = 5
        Me.pgDSOptions.Text = "DS_ Options"
        Me.pgDSOptions.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optDSFanOutlet)
        Me.GroupBox7.Controls.Add(Me.optDSFanInlet)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(111, 63)
        Me.GroupBox7.TabIndex = 30
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Coil Position"
        '
        'optDSFanOutlet
        '
        Me.optDSFanOutlet.AutoSize = True
        Me.optDSFanOutlet.Checked = True
        Me.optDSFanOutlet.Location = New System.Drawing.Point(6, 42)
        Me.optDSFanOutlet.Name = "optDSFanOutlet"
        Me.optDSFanOutlet.Size = New System.Drawing.Size(106, 17)
        Me.optDSFanOutlet.TabIndex = 1
        Me.optDSFanOutlet.TabStop = True
        Me.optDSFanOutlet.Text = "Coil at Fan Outlet"
        Me.optDSFanOutlet.UseVisualStyleBackColor = True
        '
        'optDSFanInlet
        '
        Me.optDSFanInlet.AutoSize = True
        Me.optDSFanInlet.Location = New System.Drawing.Point(6, 19)
        Me.optDSFanInlet.Name = "optDSFanInlet"
        Me.optDSFanInlet.Size = New System.Drawing.Size(98, 17)
        Me.optDSFanInlet.TabIndex = 0
        Me.optDSFanInlet.Text = "Coil at Fan Inlet"
        Me.optDSFanInlet.UseVisualStyleBackColor = True
        '
        'btnDoneDSOptions
        '
        Me.btnDoneDSOptions.Location = New System.Drawing.Point(385, 220)
        Me.btnDoneDSOptions.Name = "btnDoneDSOptions"
        Me.btnDoneDSOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneDSOptions.TabIndex = 29
        Me.btnDoneDSOptions.Text = ">"
        Me.btnDoneDSOptions.UseVisualStyleBackColor = True
        '
        'pgControls
        '
        Me.pgControls.Controls.Add(Me.GroupBox3)
        Me.pgControls.Controls.Add(Me.GroupBox9)
        Me.pgControls.Controls.Add(Me.btnDoneControls)
        Me.pgControls.Controls.Add(Me.GroupBox4)
        Me.pgControls.Location = New System.Drawing.Point(4, 22)
        Me.pgControls.Name = "pgControls"
        Me.pgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.pgControls.Size = New System.Drawing.Size(440, 249)
        Me.pgControls.TabIndex = 2
        Me.pgControls.Text = "Controls"
        Me.pgControls.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(178, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 138)
        Me.GroupBox3.TabIndex = 33
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
        Me.optBU_Other.Location = New System.Drawing.Point(6, 115)
        Me.optBU_Other.Name = "optBU_Other"
        Me.optBU_Other.Size = New System.Drawing.Size(42, 17)
        Me.optBU_Other.TabIndex = 4
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
        Me.optBU_SE_Fisen_FisenWires.Location = New System.Drawing.Point(6, 47)
        Me.optBU_SE_Fisen_FisenWires.Name = "optBU_SE_Fisen_FisenWires"
        Me.optBU_SE_Fisen_FisenWires.Size = New System.Drawing.Size(185, 17)
        Me.optBU_SE_Fisen_FisenWires.TabIndex = 0
        Me.optBU_SE_Fisen_FisenWires.Text = "SE 4 Stage by Fisen - Fisen Wires"
        Me.optBU_SE_Fisen_FisenWires.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmbValveCtrlFisenCustom)
        Me.GroupBox9.Controls.Add(Me.optValveCtrlFisenCustom)
        Me.GroupBox9.Controls.Add(Me.optValveCtrlBaseUnit)
        Me.GroupBox9.Controls.Add(Me.optValveCtrlNone)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(166, 120)
        Me.GroupBox9.TabIndex = 32
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Valve Controls"
        '
        'cmbValveCtrlFisenCustom
        '
        Me.cmbValveCtrlFisenCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveCtrlFisenCustom.Enabled = False
        Me.cmbValveCtrlFisenCustom.FormattingEnabled = True
        Me.cmbValveCtrlFisenCustom.Items.AddRange(New Object() {"n/a", "Fisen Custom 01", "Fisen Custom 02"})
        Me.cmbValveCtrlFisenCustom.Location = New System.Drawing.Point(6, 89)
        Me.cmbValveCtrlFisenCustom.Name = "cmbValveCtrlFisenCustom"
        Me.cmbValveCtrlFisenCustom.Size = New System.Drawing.Size(154, 21)
        Me.cmbValveCtrlFisenCustom.TabIndex = 32
        '
        'optValveCtrlFisenCustom
        '
        Me.optValveCtrlFisenCustom.AutoSize = True
        Me.optValveCtrlFisenCustom.Location = New System.Drawing.Point(6, 65)
        Me.optValveCtrlFisenCustom.Name = "optValveCtrlFisenCustom"
        Me.optValveCtrlFisenCustom.Size = New System.Drawing.Size(154, 17)
        Me.optValveCtrlFisenCustom.TabIndex = 2
        Me.optValveCtrlFisenCustom.TabStop = True
        Me.optValveCtrlFisenCustom.Text = "Fisen Custom Valve Control"
        Me.optValveCtrlFisenCustom.UseVisualStyleBackColor = True
        '
        'optValveCtrlBaseUnit
        '
        Me.optValveCtrlBaseUnit.AutoSize = True
        Me.optValveCtrlBaseUnit.Location = New System.Drawing.Point(6, 42)
        Me.optValveCtrlBaseUnit.Name = "optValveCtrlBaseUnit"
        Me.optValveCtrlBaseUnit.Size = New System.Drawing.Size(142, 17)
        Me.optValveCtrlBaseUnit.TabIndex = 1
        Me.optValveCtrlBaseUnit.TabStop = True
        Me.optValveCtrlBaseUnit.Text = "Base Unit Controls Valve"
        Me.optValveCtrlBaseUnit.UseVisualStyleBackColor = True
        '
        'optValveCtrlNone
        '
        Me.optValveCtrlNone.AutoSize = True
        Me.optValveCtrlNone.Checked = True
        Me.optValveCtrlNone.Location = New System.Drawing.Point(6, 19)
        Me.optValveCtrlNone.Name = "optValveCtrlNone"
        Me.optValveCtrlNone.Size = New System.Drawing.Size(51, 17)
        Me.optValveCtrlNone.TabIndex = 0
        Me.optValveCtrlNone.TabStop = True
        Me.optValveCtrlNone.Text = "None"
        Me.optValveCtrlNone.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 220)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 31
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkBreakonLL)
        Me.GroupBox4.Controls.Add(Me.optLLWired)
        Me.GroupBox4.Controls.Add(Me.optLLUnwired)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(172, 96)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Low Limt Stat"
        '
        'chkBreakonLL
        '
        Me.chkBreakonLL.AutoSize = True
        Me.chkBreakonLL.Location = New System.Drawing.Point(20, 72)
        Me.chkBreakonLL.Name = "chkBreakonLL"
        Me.chkBreakonLL.Size = New System.Drawing.Size(147, 17)
        Me.chkBreakonLL.TabIndex = 2
        Me.chkBreakonLL.Text = "Break Valve Power, etc..."
        Me.chkBreakonLL.UseVisualStyleBackColor = True
        '
        'optLLWired
        '
        Me.optLLWired.AutoSize = True
        Me.optLLWired.Location = New System.Drawing.Point(6, 46)
        Me.optLLWired.Name = "optLLWired"
        Me.optLLWired.Size = New System.Drawing.Size(123, 17)
        Me.optLLWired.TabIndex = 1
        Me.optLLWired.TabStop = True
        Me.optLLWired.Text = "Wired to Controller(s)"
        Me.optLLWired.UseVisualStyleBackColor = True
        '
        'optLLUnwired
        '
        Me.optLLUnwired.AutoSize = True
        Me.optLLUnwired.Checked = True
        Me.optLLUnwired.Location = New System.Drawing.Point(6, 23)
        Me.optLLUnwired.Name = "optLLUnwired"
        Me.optLLUnwired.Size = New System.Drawing.Size(109, 17)
        Me.optLLUnwired.TabIndex = 0
        Me.optLLUnwired.TabStop = True
        Me.optLLUnwired.Text = "Provided Unwired"
        Me.optLLUnwired.UseVisualStyleBackColor = True
        '
        'pgPerf
        '
        Me.pgPerf.Controls.Add(Me.sciConnections)
        Me.pgPerf.Controls.Add(Me.optCoilOnly)
        Me.pgPerf.Controls.Add(Me.optAPDAllowance)
        Me.pgPerf.Controls.Add(Me.txtOutletSize)
        Me.pgPerf.Controls.Add(Me.Label15)
        Me.pgPerf.Controls.Add(Me.txtInletSize)
        Me.pgPerf.Controls.Add(Me.Label14)
        Me.pgPerf.Controls.Add(Me.txtOutCap)
        Me.pgPerf.Controls.Add(Me.Label13)
        Me.pgPerf.Controls.Add(Me.btnDonePerf)
        Me.pgPerf.Controls.Add(Me.Label5)
        Me.pgPerf.Controls.Add(Me.txtCoilAPD)
        Me.pgPerf.Controls.Add(Me.Label6)
        Me.pgPerf.Controls.Add(Me.txtCondFlow)
        Me.pgPerf.Controls.Add(Me.txtLAT)
        Me.pgPerf.Controls.Add(Me.Label7)
        Me.pgPerf.Controls.Add(Me.Label8)
        Me.pgPerf.Controls.Add(Me.txtDeltaT)
        Me.pgPerf.Location = New System.Drawing.Point(4, 22)
        Me.pgPerf.Name = "pgPerf"
        Me.pgPerf.Padding = New System.Windows.Forms.Padding(3)
        Me.pgPerf.Size = New System.Drawing.Size(440, 249)
        Me.pgPerf.TabIndex = 4
        Me.pgPerf.Text = "Performance"
        Me.pgPerf.UseVisualStyleBackColor = True
        '
        'optCoilOnly
        '
        Me.optCoilOnly.AutoSize = True
        Me.optCoilOnly.Location = New System.Drawing.Point(169, 111)
        Me.optCoilOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.optCoilOnly.Name = "optCoilOnly"
        Me.optCoilOnly.Size = New System.Drawing.Size(155, 17)
        Me.optCoilOnly.TabIndex = 50
        Me.optCoilOnly.Text = "Coil Only (FUG will add10%)"
        Me.optCoilOnly.UseVisualStyleBackColor = True
        '
        'optAPDAllowance
        '
        Me.optAPDAllowance.AutoSize = True
        Me.optAPDAllowance.Checked = True
        Me.optAPDAllowance.Location = New System.Drawing.Point(24, 111)
        Me.optAPDAllowance.Margin = New System.Windows.Forms.Padding(2)
        Me.optAPDAllowance.Name = "optAPDAllowance"
        Me.optAPDAllowance.Size = New System.Drawing.Size(144, 17)
        Me.optAPDAllowance.TabIndex = 49
        Me.optAPDAllowance.TabStop = True
        Me.optAPDAllowance.Text = "Allowance From Proposal"
        Me.optAPDAllowance.UseVisualStyleBackColor = True
        '
        'txtOutletSize
        '
        Me.txtOutletSize.Location = New System.Drawing.Point(210, 58)
        Me.txtOutletSize.Name = "txtOutletSize"
        Me.txtOutletSize.Size = New System.Drawing.Size(40, 20)
        Me.txtOutletSize.TabIndex = 6
        Me.txtOutletSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(256, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Outlet Size (in)"
        '
        'txtInletSize
        '
        Me.txtInletSize.Location = New System.Drawing.Point(210, 32)
        Me.txtInletSize.Name = "txtInletSize"
        Me.txtInletSize.Size = New System.Drawing.Size(40, 20)
        Me.txtInletSize.TabIndex = 5
        Me.txtInletSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(256, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Inlet Size (in)"
        '
        'txtOutCap
        '
        Me.txtOutCap.Location = New System.Drawing.Point(210, 6)
        Me.txtOutCap.Name = "txtOutCap"
        Me.txtOutCap.Size = New System.Drawing.Size(40, 20)
        Me.txtOutCap.TabIndex = 4
        Me.txtOutCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(256, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Output Capacity(mbh)"
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(385, 220)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerf.TabIndex = 7
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Coil APD(iwc)"
        '
        'txtCoilAPD
        '
        Me.txtCoilAPD.Location = New System.Drawing.Point(5, 86)
        Me.txtCoilAPD.Name = "txtCoilAPD"
        Me.txtCoilAPD.Size = New System.Drawing.Size(40, 20)
        Me.txtCoilAPD.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Condensate Flow(lb/hr)"
        '
        'txtCondFlow
        '
        Me.txtCondFlow.Location = New System.Drawing.Point(5, 59)
        Me.txtCondFlow.Name = "txtCondFlow"
        Me.txtCondFlow.Size = New System.Drawing.Size(40, 20)
        Me.txtCondFlow.TabIndex = 2
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(5, 6)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(40, 20)
        Me.txtLAT.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Delta T(ºF)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Leaving Air Temp(ºF)"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(5, 32)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(40, 20)
        Me.txtDeltaT.TabIndex = 1
        '
        'tpgValves
        '
        Me.tpgValves.Controls.Add(Me.btnSelectAValve)
        Me.tpgValves.Controls.Add(Me.cmbValveDesc)
        Me.tpgValves.Controls.Add(Me.cmbValveSize)
        Me.tpgValves.Controls.Add(Me.txtValveMPN)
        Me.tpgValves.Controls.Add(Me.Label20)
        Me.tpgValves.Controls.Add(Me.txtValveType)
        Me.tpgValves.Controls.Add(Me.Label19)
        Me.tpgValves.Controls.Add(Me.Label18)
        Me.tpgValves.Controls.Add(Me.Label17)
        Me.tpgValves.Controls.Add(Me.txtValveTag)
        Me.tpgValves.Controls.Add(Me.Label16)
        Me.tpgValves.Controls.Add(Me.btnDoneValve)
        Me.tpgValves.Location = New System.Drawing.Point(4, 22)
        Me.tpgValves.Name = "tpgValves"
        Me.tpgValves.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgValves.Size = New System.Drawing.Size(440, 249)
        Me.tpgValves.TabIndex = 3
        Me.tpgValves.Text = "Valves"
        Me.tpgValves.UseVisualStyleBackColor = True
        '
        'cmbValveDesc
        '
        Me.cmbValveDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveDesc.FormattingEnabled = True
        Me.cmbValveDesc.Items.AddRange(New Object() {"-"})
        Me.cmbValveDesc.Location = New System.Drawing.Point(88, 59)
        Me.cmbValveDesc.Name = "cmbValveDesc"
        Me.cmbValveDesc.Size = New System.Drawing.Size(240, 21)
        Me.cmbValveDesc.TabIndex = 33
        '
        'cmbValveSize
        '
        Me.cmbValveSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveSize.FormattingEnabled = True
        Me.cmbValveSize.Items.AddRange(New Object() {"1/2", "3/4", "1", "1-1/4", "1-1/2", "2", "2-1/2", "-"})
        Me.cmbValveSize.Location = New System.Drawing.Point(271, 32)
        Me.cmbValveSize.Name = "cmbValveSize"
        Me.cmbValveSize.Size = New System.Drawing.Size(57, 21)
        Me.cmbValveSize.TabIndex = 32
        '
        'txtValveMPN
        '
        Me.txtValveMPN.Location = New System.Drawing.Point(88, 112)
        Me.txtValveMPN.Name = "txtValveMPN"
        Me.txtValveMPN.Size = New System.Drawing.Size(240, 20)
        Me.txtValveMPN.TabIndex = 30
        Me.txtValveMPN.Text = "-"
        Me.txtValveMPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(334, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Mfg. Part Number"
        '
        'txtValveType
        '
        Me.txtValveType.Location = New System.Drawing.Point(88, 86)
        Me.txtValveType.Name = "txtValveType"
        Me.txtValveType.Size = New System.Drawing.Size(240, 20)
        Me.txtValveType.TabIndex = 28
        Me.txtValveType.Text = "-"
        Me.txtValveType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(334, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(334, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Body Size"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(334, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Description"
        '
        'txtValveTag
        '
        Me.txtValveTag.Location = New System.Drawing.Point(271, 6)
        Me.txtValveTag.Name = "txtValveTag"
        Me.txtValveTag.Size = New System.Drawing.Size(57, 20)
        Me.txtValveTag.TabIndex = 24
        Me.txtValveTag.Text = "STMV-1"
        Me.txtValveTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(334, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Tag"
        '
        'btnDoneValve
        '
        Me.btnDoneValve.Location = New System.Drawing.Point(385, 220)
        Me.btnDoneValve.Name = "btnDoneValve"
        Me.btnDoneValve.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneValve.TabIndex = 8
        Me.btnDoneValve.Text = ">"
        Me.btnDoneValve.UseVisualStyleBackColor = True
        '
        'sciConnections
        '
        Me.sciConnections.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.sciConnections.Location = New System.Drawing.Point(337, 55)
        Me.sciConnections.Name = "sciConnections"
        Me.sciConnections.Size = New System.Drawing.Size(24, 24)
        Me.sciConnections.TabIndex = 51
        Me.sciConnections.TabStop = False
        '
        'btnSelectAValve
        '
        Me.btnSelectAValve.Image = CType(resources.GetObject("btnSelectAValve.Image"), System.Drawing.Image)
        Me.btnSelectAValve.Location = New System.Drawing.Point(60, 59)
        Me.btnSelectAValve.Name = "btnSelectAValve"
        Me.btnSelectAValve.Size = New System.Drawing.Size(22, 22)
        Me.btnSelectAValve.TabIndex = 34
        Me.btnSelectAValve.UseVisualStyleBackColor = True
        '
        'frmSteamCoil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmSteamCoil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Steam Coil"
        Me.TabControl1.ResumeLayout(False)
        Me.pgConditions.ResumeLayout(False)
        Me.pgConditions.PerformLayout()
        Me.pgOptions.ResumeLayout(False)
        Me.pgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pgDSOptions.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pgControls.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pgPerf.ResumeLayout(False)
        Me.pgPerf.PerformLayout()
        Me.tpgValves.ResumeLayout(False)
        Me.tpgValves.PerformLayout()
        CType(Me.sciConnections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgConditions As TabPage
    Friend WithEvents pgOptions As TabPage
    Friend WithEvents pgControls As TabPage
    Friend WithEvents tpgValves As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSteamPressure As TextBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOutputCap As TextBox
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents pgPerf As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCoilAPD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCondFlow As TextBox
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optCoil2Row As RadioButton
    Friend WithEvents optCoil1Row As RadioButton
    Friend WithEvents optCoilCustom As RadioButton
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optValveModulating As RadioButton
    Friend WithEvents optValveOnOff As RadioButton
    Friend WithEvents optValveNone As RadioButton
    Friend WithEvents chkEpoxy As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkBreakonLL As CheckBox
    Friend WithEvents optLLWired As RadioButton
    Friend WithEvents optLLUnwired As RadioButton
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents pgDSOptions As TabPage
    Friend WithEvents btnDoneDSOptions As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents optDSFanOutlet As RadioButton
    Friend WithEvents optDSFanInlet As RadioButton
    Friend WithEvents txtOutletSize As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtInletSize As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOutCap As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDoneValve As Button
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents cmbValveCtrlFisenCustom As ComboBox
    Friend WithEvents optValveCtrlFisenCustom As RadioButton
    Friend WithEvents optValveCtrlBaseUnit As RadioButton
    Friend WithEvents optValveCtrlNone As RadioButton
    Friend WithEvents optCoilOnly As RadioButton
    Friend WithEvents optAPDAllowance As RadioButton
    Friend WithEvents btnSelectAValve As Button
    Friend WithEvents cmbValveDesc As ComboBox
    Friend WithEvents cmbValveSize As ComboBox
    Friend WithEvents txtValveMPN As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtValveType As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValveTag As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents chkS40DrawThroughCoil As CheckBox
    Friend WithEvents optValveFieldProvFieldInst As RadioButton
    Friend WithEvents optValveFisenProvFisenInst As RadioButton
    Friend WithEvents optValveFisenProvFieldInst As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optBU_SE_Fisen_Unwired As RadioButton
    Friend WithEvents optBU_SE_Fact_Unwired As RadioButton
    Friend WithEvents optBU_Other As RadioButton
    Friend WithEvents optBU_IPU_Unwired As RadioButton
    Friend WithEvents optBU_SE_Fact_FisenWires As RadioButton
    Friend WithEvents optBU_IPU_FisenWires As RadioButton
    Friend WithEvents optBU_SE_Fisen_FisenWires As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents sciConnections As PictureBox
End Class
