<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHWCoil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHWCoil))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbFluidPer = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbFluidList = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEFT = New System.Windows.Forms.TextBox()
        Me.txtFluidFlow = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputCap = New System.Windows.Forms.TextBox()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkS40DrawThroughCoil = New System.Windows.Forms.CheckBox()
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
        Me.optValve3Way = New System.Windows.Forms.RadioButton()
        Me.optValve2Way = New System.Windows.Forms.RadioButton()
        Me.optValveNone = New System.Windows.Forms.RadioButton()
        Me.chkEpoxy = New System.Windows.Forms.CheckBox()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbValveCtrlFisenCustom = New System.Windows.Forms.ComboBox()
        Me.optValveCtrlFisenCustom = New System.Windows.Forms.RadioButton()
        Me.optValveCtrlBaseUnit = New System.Windows.Forms.RadioButton()
        Me.optValveCtrlNone = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkBreakonLL = New System.Windows.Forms.CheckBox()
        Me.optLLWired = New System.Windows.Forms.RadioButton()
        Me.optLLUnwired = New System.Windows.Forms.RadioButton()
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtActualAPD = New System.Windows.Forms.TextBox()
        Me.optCoilOnly = New System.Windows.Forms.RadioButton()
        Me.optAPDAllowance = New System.Windows.Forms.RadioButton()
        Me.txtOutletSize = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInletSize = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOutCap = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFPD = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLFT = New System.Windows.Forms.TextBox()
        Me.txtAPD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.tpgValves = New System.Windows.Forms.TabPage()
        Me.btnSelectAValve = New System.Windows.Forms.Button()
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
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgValves.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgValves)
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 275)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.cmbFluidPer)
        Me.tpgConditions.Controls.Add(Me.Label7)
        Me.tpgConditions.Controls.Add(Me.cmbFluidList)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.txtEFT)
        Me.tpgConditions.Controls.Add(Me.txtFluidFlow)
        Me.tpgConditions.Controls.Add(Me.Label6)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.txtInputCap)
        Me.tpgConditions.Controls.Add(Me.txtHeatAF)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(441, 249)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(394, 220)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 22
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fluid Percentage"
        '
        'cmbFluidPer
        '
        Me.cmbFluidPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluidPer.FormattingEnabled = True
        Me.cmbFluidPer.Location = New System.Drawing.Point(179, 82)
        Me.cmbFluidPer.Name = "cmbFluidPer"
        Me.cmbFluidPer.Size = New System.Drawing.Size(121, 21)
        Me.cmbFluidPer.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fluid"
        '
        'cmbFluidList
        '
        Me.cmbFluidList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluidList.FormattingEnabled = True
        Me.cmbFluidList.ItemHeight = 13
        Me.cmbFluidList.Location = New System.Drawing.Point(179, 58)
        Me.cmbFluidList.Name = "cmbFluidList"
        Me.cmbFluidList.Size = New System.Drawing.Size(121, 21)
        Me.cmbFluidList.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Entering Fluid Temp(ºF)"
        '
        'txtEFT
        '
        Me.txtEFT.Location = New System.Drawing.Point(4, 87)
        Me.txtEFT.Name = "txtEFT"
        Me.txtEFT.Size = New System.Drawing.Size(40, 20)
        Me.txtEFT.TabIndex = 4
        Me.txtEFT.Text = "88888"
        Me.txtEFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFluidFlow
        '
        Me.txtFluidFlow.Location = New System.Drawing.Point(4, 114)
        Me.txtFluidFlow.Name = "txtFluidFlow"
        Me.txtFluidFlow.Size = New System.Drawing.Size(40, 20)
        Me.txtFluidFlow.TabIndex = 5
        Me.txtFluidFlow.Text = "88888"
        Me.txtFluidFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fluid Flow(gpm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Input Capacity(mbh)"
        '
        'txtInputCap
        '
        Me.txtInputCap.Location = New System.Drawing.Point(4, 59)
        Me.txtInputCap.Name = "txtInputCap"
        Me.txtInputCap.Size = New System.Drawing.Size(40, 20)
        Me.txtInputCap.TabIndex = 3
        Me.txtInputCap.Text = "88888"
        Me.txtInputCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(4, 6)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(40, 20)
        Me.txtHeatAF.TabIndex = 1
        Me.txtHeatAF.Text = "88888"
        Me.txtHeatAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(4, 32)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(40, 20)
        Me.txtEAT.TabIndex = 2
        Me.txtEAT.Text = "88888"
        Me.txtEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
        Me.tpgOptions.Controls.Add(Me.CheckBox1)
        Me.tpgOptions.Controls.Add(Me.CheckBox2)
        Me.tpgOptions.Controls.Add(Me.chkS40DrawThroughCoil)
        Me.tpgOptions.Controls.Add(Me.GroupBox6)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.chkEpoxy)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(441, 249)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 203)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Provide Equipment Touch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(12, 224)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(165, 17)
        Me.CheckBox2.TabIndex = 33
        Me.CheckBox2.Text = "Unit Mount Equipment Touch"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chkS40DrawThroughCoil
        '
        Me.chkS40DrawThroughCoil.AutoSize = True
        Me.chkS40DrawThroughCoil.Location = New System.Drawing.Point(6, 127)
        Me.chkS40DrawThroughCoil.Name = "chkS40DrawThroughCoil"
        Me.chkS40DrawThroughCoil.Size = New System.Drawing.Size(195, 17)
        Me.chkS40DrawThroughCoil.TabIndex = 25
        Me.chkS40DrawThroughCoil.Text = "Install Coil in Draw Through Position"
        Me.chkS40DrawThroughCoil.UseVisualStyleBackColor = True
        Me.chkS40DrawThroughCoil.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optCoil2Row)
        Me.GroupBox6.Controls.Add(Me.optCoil1Row)
        Me.GroupBox6.Controls.Add(Me.optCoilCustom)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(152, 92)
        Me.GroupBox6.TabIndex = 24
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
        Me.btnDoneOptions.Location = New System.Drawing.Point(394, 220)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 23
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optValveFieldProvFieldInst)
        Me.GroupBox2.Controls.Add(Me.optValveFisenProvFisenInst)
        Me.GroupBox2.Controls.Add(Me.optValveFisenProvFieldInst)
        Me.GroupBox2.Location = New System.Drawing.Point(251, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 92)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valve"
        '
        'optValveFieldProvFieldInst
        '
        Me.optValveFieldProvFieldInst.AutoSize = True
        Me.optValveFieldProvFieldInst.Checked = True
        Me.optValveFieldProvFieldInst.Location = New System.Drawing.Point(6, 66)
        Me.optValveFieldProvFieldInst.Name = "optValveFieldProvFieldInst"
        Me.optValveFieldProvFieldInst.Size = New System.Drawing.Size(136, 17)
        Me.optValveFieldProvFieldInst.TabIndex = 2
        Me.optValveFieldProvFieldInst.TabStop = True
        Me.optValveFieldProvFieldInst.Tag = ""
        Me.optValveFieldProvFieldInst.Text = "Field Provided/Installed"
        Me.optValveFieldProvFieldInst.UseVisualStyleBackColor = True
        '
        'optValveFisenProvFisenInst
        '
        Me.optValveFisenProvFisenInst.AutoSize = True
        Me.optValveFisenProvFisenInst.Location = New System.Drawing.Point(6, 19)
        Me.optValveFisenProvFisenInst.Name = "optValveFisenProvFisenInst"
        Me.optValveFisenProvFisenInst.Size = New System.Drawing.Size(139, 17)
        Me.optValveFisenProvFisenInst.TabIndex = 1
        Me.optValveFisenProvFisenInst.Text = "Fisen Provided/Installed"
        Me.optValveFisenProvFisenInst.UseVisualStyleBackColor = True
        '
        'optValveFisenProvFieldInst
        '
        Me.optValveFisenProvFieldInst.AutoSize = True
        Me.optValveFisenProvFieldInst.Location = New System.Drawing.Point(6, 42)
        Me.optValveFisenProvFieldInst.Name = "optValveFisenProvFieldInst"
        Me.optValveFisenProvFieldInst.Size = New System.Drawing.Size(164, 17)
        Me.optValveFisenProvFieldInst.TabIndex = 0
        Me.optValveFisenProvFieldInst.Text = "Fisen Provided/Field Installed"
        Me.optValveFisenProvFieldInst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optValve3Way)
        Me.GroupBox1.Controls.Add(Me.optValve2Way)
        Me.GroupBox1.Controls.Add(Me.optValveNone)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valve"
        '
        'optValve3Way
        '
        Me.optValve3Way.AutoSize = True
        Me.optValve3Way.Location = New System.Drawing.Point(15, 66)
        Me.optValve3Way.Name = "optValve3Way"
        Me.optValve3Way.Size = New System.Drawing.Size(56, 17)
        Me.optValve3Way.TabIndex = 2
        Me.optValve3Way.TabStop = True
        Me.optValve3Way.Text = "3-Way"
        Me.optValve3Way.UseVisualStyleBackColor = True
        '
        'optValve2Way
        '
        Me.optValve2Way.AutoSize = True
        Me.optValve2Way.Location = New System.Drawing.Point(15, 43)
        Me.optValve2Way.Name = "optValve2Way"
        Me.optValve2Way.Size = New System.Drawing.Size(56, 17)
        Me.optValve2Way.TabIndex = 1
        Me.optValve2Way.TabStop = True
        Me.optValve2Way.Text = "2-Way"
        Me.optValve2Way.UseVisualStyleBackColor = True
        '
        'optValveNone
        '
        Me.optValveNone.AutoSize = True
        Me.optValveNone.Checked = True
        Me.optValveNone.Location = New System.Drawing.Point(15, 19)
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
        Me.chkEpoxy.TabIndex = 0
        Me.chkEpoxy.Text = "E-Coat Epoxy Coil"
        Me.chkEpoxy.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.GroupBox5)
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.GroupBox4)
        Me.tpgControls.Controls.Add(Me.GroupBox3)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(441, 249)
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbValveCtrlFisenCustom)
        Me.GroupBox5.Controls.Add(Me.optValveCtrlFisenCustom)
        Me.GroupBox5.Controls.Add(Me.optValveCtrlBaseUnit)
        Me.GroupBox5.Controls.Add(Me.optValveCtrlNone)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 138)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Valve Controls"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkBreakonLL)
        Me.GroupBox4.Controls.Add(Me.optLLWired)
        Me.GroupBox4.Controls.Add(Me.optLLUnwired)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(168, 95)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Low Limt Stat"
        '
        'chkBreakonLL
        '
        Me.chkBreakonLL.AutoSize = True
        Me.chkBreakonLL.Enabled = False
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
        Me.btnDoneControls.Location = New System.Drawing.Point(394, 220)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 24
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.Label21)
        Me.tpgPerformance.Controls.Add(Me.txtActualAPD)
        Me.tpgPerformance.Controls.Add(Me.optCoilOnly)
        Me.tpgPerformance.Controls.Add(Me.optAPDAllowance)
        Me.tpgPerformance.Controls.Add(Me.txtOutletSize)
        Me.tpgPerformance.Controls.Add(Me.Label15)
        Me.tpgPerformance.Controls.Add(Me.txtInletSize)
        Me.tpgPerformance.Controls.Add(Me.Label14)
        Me.tpgPerformance.Controls.Add(Me.txtOutCap)
        Me.tpgPerformance.Controls.Add(Me.Label13)
        Me.tpgPerformance.Controls.Add(Me.txtFPD)
        Me.tpgPerformance.Controls.Add(Me.Label12)
        Me.tpgPerformance.Controls.Add(Me.Label5)
        Me.tpgPerformance.Controls.Add(Me.txtLFT)
        Me.tpgPerformance.Controls.Add(Me.txtAPD)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(441, 249)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Actual Coil APD (iwc) at Heating Airflow"
        '
        'txtActualAPD
        '
        Me.txtActualAPD.Location = New System.Drawing.Point(3, 84)
        Me.txtActualAPD.Name = "txtActualAPD"
        Me.txtActualAPD.Size = New System.Drawing.Size(40, 20)
        Me.txtActualAPD.TabIndex = 3
        Me.txtActualAPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'optCoilOnly
        '
        Me.optCoilOnly.AutoSize = True
        Me.optCoilOnly.Location = New System.Drawing.Point(196, 129)
        Me.optCoilOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.optCoilOnly.Name = "optCoilOnly"
        Me.optCoilOnly.Size = New System.Drawing.Size(155, 17)
        Me.optCoilOnly.TabIndex = 44
        Me.optCoilOnly.Text = "Coil Only (FUG will add10%)"
        Me.optCoilOnly.UseVisualStyleBackColor = True
        '
        'optAPDAllowance
        '
        Me.optAPDAllowance.AutoSize = True
        Me.optAPDAllowance.Checked = True
        Me.optAPDAllowance.Location = New System.Drawing.Point(51, 129)
        Me.optAPDAllowance.Margin = New System.Windows.Forms.Padding(2)
        Me.optAPDAllowance.Name = "optAPDAllowance"
        Me.optAPDAllowance.Size = New System.Drawing.Size(144, 17)
        Me.optAPDAllowance.TabIndex = 43
        Me.optAPDAllowance.TabStop = True
        Me.optAPDAllowance.Text = "Allowance From Proposal"
        Me.optAPDAllowance.UseVisualStyleBackColor = True
        '
        'txtOutletSize
        '
        Me.txtOutletSize.Location = New System.Drawing.Point(265, 57)
        Me.txtOutletSize.Name = "txtOutletSize"
        Me.txtOutletSize.Size = New System.Drawing.Size(40, 20)
        Me.txtOutletSize.TabIndex = 8
        Me.txtOutletSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(311, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Outlet Size (in)"
        '
        'txtInletSize
        '
        Me.txtInletSize.Location = New System.Drawing.Point(265, 32)
        Me.txtInletSize.Name = "txtInletSize"
        Me.txtInletSize.Size = New System.Drawing.Size(40, 20)
        Me.txtInletSize.TabIndex = 7
        Me.txtInletSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(311, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Inlet Size (in)"
        '
        'txtOutCap
        '
        Me.txtOutCap.Location = New System.Drawing.Point(265, 6)
        Me.txtOutCap.Name = "txtOutCap"
        Me.txtOutCap.Size = New System.Drawing.Size(40, 20)
        Me.txtOutCap.TabIndex = 6
        Me.txtOutCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(311, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Output Capacity(mbh)"
        '
        'txtFPD
        '
        Me.txtFPD.Location = New System.Drawing.Point(3, 150)
        Me.txtFPD.Name = "txtFPD"
        Me.txtFPD.Size = New System.Drawing.Size(40, 20)
        Me.txtFPD.TabIndex = 5
        Me.txtFPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Fluid Pressure Drop(ft) (Coil Only)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Leaving Fluid Temp(ºF)"
        '
        'txtLFT
        '
        Me.txtLFT.Location = New System.Drawing.Point(3, 58)
        Me.txtLFT.Name = "txtLFT"
        Me.txtLFT.Size = New System.Drawing.Size(40, 20)
        Me.txtLFT.TabIndex = 2
        Me.txtLFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAPD
        '
        Me.txtAPD.Location = New System.Drawing.Point(3, 110)
        Me.txtAPD.Name = "txtAPD"
        Me.txtAPD.Size = New System.Drawing.Size(40, 20)
        Me.txtAPD.TabIndex = 4
        Me.txtAPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Air Pressure Drop(iwc) as Applied to System"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Delta T"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(3, 32)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(40, 20)
        Me.txtDeltaT.TabIndex = 1
        Me.txtDeltaT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Leaving Air Temp(ºF)"
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(3, 6)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(40, 20)
        Me.txtLAT.TabIndex = 0
        Me.txtLAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(394, 220)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 9
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
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
        Me.tpgValves.Size = New System.Drawing.Size(441, 249)
        Me.tpgValves.TabIndex = 3
        Me.tpgValves.Text = "Valves"
        Me.tpgValves.UseVisualStyleBackColor = True
        '
        'btnSelectAValve
        '
        Me.btnSelectAValve.Image = CType(resources.GetObject("btnSelectAValve.Image"), System.Drawing.Image)
        Me.btnSelectAValve.Location = New System.Drawing.Point(69, 58)
        Me.btnSelectAValve.Name = "btnSelectAValve"
        Me.btnSelectAValve.Size = New System.Drawing.Size(22, 22)
        Me.btnSelectAValve.TabIndex = 23
        Me.btnSelectAValve.UseVisualStyleBackColor = True
        '
        'cmbValveDesc
        '
        Me.cmbValveDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveDesc.FormattingEnabled = True
        Me.cmbValveDesc.Items.AddRange(New Object() {"-"})
        Me.cmbValveDesc.Location = New System.Drawing.Point(97, 58)
        Me.cmbValveDesc.Name = "cmbValveDesc"
        Me.cmbValveDesc.Size = New System.Drawing.Size(240, 21)
        Me.cmbValveDesc.TabIndex = 22
        '
        'cmbValveSize
        '
        Me.cmbValveSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveSize.FormattingEnabled = True
        Me.cmbValveSize.Items.AddRange(New Object() {"1/2", "3/4", "1", "1-1/4", "1-1/2", "2", "2-1/2", "-"})
        Me.cmbValveSize.Location = New System.Drawing.Point(280, 31)
        Me.cmbValveSize.Name = "cmbValveSize"
        Me.cmbValveSize.Size = New System.Drawing.Size(57, 21)
        Me.cmbValveSize.TabIndex = 21
        '
        'txtValveMPN
        '
        Me.txtValveMPN.Location = New System.Drawing.Point(97, 111)
        Me.txtValveMPN.Name = "txtValveMPN"
        Me.txtValveMPN.Size = New System.Drawing.Size(240, 20)
        Me.txtValveMPN.TabIndex = 19
        Me.txtValveMPN.Text = "-"
        Me.txtValveMPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(343, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Mfg. Part Number"
        '
        'txtValveType
        '
        Me.txtValveType.Location = New System.Drawing.Point(97, 85)
        Me.txtValveType.Name = "txtValveType"
        Me.txtValveType.Size = New System.Drawing.Size(240, 20)
        Me.txtValveType.TabIndex = 17
        Me.txtValveType.Text = "-"
        Me.txtValveType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(343, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(343, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Body Size"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(343, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Description"
        '
        'txtValveTag
        '
        Me.txtValveTag.Location = New System.Drawing.Point(297, 5)
        Me.txtValveTag.Name = "txtValveTag"
        Me.txtValveTag.Size = New System.Drawing.Size(40, 20)
        Me.txtValveTag.TabIndex = 11
        Me.txtValveTag.Text = "HWV-1"
        Me.txtValveTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(343, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Tag"
        '
        'btnDoneValve
        '
        Me.btnDoneValve.Location = New System.Drawing.Point(394, 220)
        Me.btnDoneValve.Name = "btnDoneValve"
        Me.btnDoneValve.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneValve.TabIndex = 10
        Me.btnDoneValve.Text = ">"
        Me.btnDoneValve.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(163, 303)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 12
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'frmHWCoil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmHWCoil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hot Water Coil"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.tpgValves.ResumeLayout(False)
        Me.tpgValves.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents tpgValves As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputCap As TextBox
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEFT As TextBox
    Friend WithEvents txtFluidFlow As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbFluidPer As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbFluidList As ComboBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optValveFieldProvFieldInst As RadioButton
    Friend WithEvents optValveFisenProvFisenInst As RadioButton
    Friend WithEvents optValveFisenProvFieldInst As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optValve3Way As RadioButton
    Friend WithEvents optValve2Way As RadioButton
    Friend WithEvents optValveNone As RadioButton
    Friend WithEvents chkEpoxy As CheckBox
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optBU_SE_Fact_FisenWires As RadioButton
    Friend WithEvents optBU_IPU_FisenWires As RadioButton
    Friend WithEvents optBU_SE_Fisen_FisenWires As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optValveCtrlFisenCustom As RadioButton
    Friend WithEvents optValveCtrlBaseUnit As RadioButton
    Friend WithEvents optValveCtrlNone As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkBreakonLL As CheckBox
    Friend WithEvents optLLWired As RadioButton
    Friend WithEvents optLLUnwired As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLFT As TextBox
    Friend WithEvents txtAPD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents txtFPD As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtOutCap As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optCoil2Row As RadioButton
    Friend WithEvents optCoil1Row As RadioButton
    Friend WithEvents optCoilCustom As RadioButton
    Friend WithEvents txtOutletSize As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtInletSize As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents optCoilOnly As RadioButton
    Friend WithEvents optAPDAllowance As RadioButton
    Friend WithEvents chkS40DrawThroughCoil As CheckBox
    Friend WithEvents optBU_Other As RadioButton
    Friend WithEvents optBU_IPU_Unwired As RadioButton
    Friend WithEvents cmbValveCtrlFisenCustom As ComboBox
    Friend WithEvents optBU_SE_Fisen_Unwired As RadioButton
    Friend WithEvents optBU_SE_Fact_Unwired As RadioButton
    Friend WithEvents btnDoneValve As Button
    Friend WithEvents txtValveMPN As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtValveType As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValveTag As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbValveSize As ComboBox
    Friend WithEvents cmbValveDesc As ComboBox
    Friend WithEvents btnSelectAValve As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents txtActualAPD As TextBox
    Friend WithEvents chkWriteHistory As CheckBox
End Class
