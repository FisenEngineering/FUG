<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomCoil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomCoil))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.lblFluid = New System.Windows.Forms.Label()
        Me.txtFluid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbCoilType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAllocatedAPD = New System.Windows.Forms.TextBox()
        Me.lblAllocatedAPD = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCircuitsofRH = New System.Windows.Forms.Label()
        Me.nudCircuitsofRH = New System.Windows.Forms.NumericUpDown()
        Me.txtAFlow = New System.Windows.Forms.TextBox()
        Me.lblReclaimAirflow = New System.Windows.Forms.Label()
        Me.lblReclaimCap = New System.Windows.Forms.Label()
        Me.lblRefType = New System.Windows.Forms.Label()
        Me.txtReclaimCap = New System.Windows.Forms.TextBox()
        Me.txtRefType = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkPumpedCoil = New System.Windows.Forms.CheckBox()
        Me.chkFilterBankRelocation = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optPenTTHeatSecBFieldCut = New System.Windows.Forms.RadioButton()
        Me.optPenConvertibleFieldCut = New System.Windows.Forms.RadioButton()
        Me.optPenTTBFieldCut = New System.Windows.Forms.RadioButton()
        Me.optPenTTWFieldCut = New System.Windows.Forms.RadioButton()
        Me.chkN2Holding = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudRows = New System.Windows.Forms.NumericUpDown()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.grpLowLimit = New System.Windows.Forms.GroupBox()
        Me.optLLBreakStuff = New System.Windows.Forms.RadioButton()
        Me.optLLNone = New System.Windows.Forms.RadioButton()
        Me.optLLAveragingSensor = New System.Windows.Forms.RadioButton()
        Me.optLLUnwired = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPHCoilLATCtrl = New System.Windows.Forms.RadioButton()
        Me.optNoControls = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtOutConn = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblFPDUnits = New System.Windows.Forms.Label()
        Me.txtRefPD = New System.Windows.Forms.TextBox()
        Me.lblFluidPressDrop = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCoilAPD = New System.Windows.Forms.TextBox()
        Me.lblActualAPD = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInConn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.tpgValves = New System.Windows.Forms.TabPage()
        Me.btnDoneValves = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSelectAValve = New System.Windows.Forms.Button()
        Me.cmbValveDesc = New System.Windows.Forms.ComboBox()
        Me.cmbValveSize = New System.Windows.Forms.ComboBox()
        Me.txtValveMPN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValveType = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValveTag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optValveNone = New System.Windows.Forms.RadioButton()
        Me.optValve2Way = New System.Windows.Forms.RadioButton()
        Me.optValve3Way = New System.Windows.Forms.RadioButton()
        Me.lblFluidFlowUnits = New System.Windows.Forms.Label()
        Me.lblFluidFlow = New System.Windows.Forms.Label()
        Me.txtFluidFlow = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgControls.SuspendLayout()
        Me.grpLowLimit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgValves.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgValves)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 217)
        Me.TabControl1.TabIndex = 8
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.lblFluidFlowUnits)
        Me.tpgConditions.Controls.Add(Me.lblFluidFlow)
        Me.tpgConditions.Controls.Add(Me.txtFluidFlow)
        Me.tpgConditions.Controls.Add(Me.lblFluid)
        Me.tpgConditions.Controls.Add(Me.txtFluid)
        Me.tpgConditions.Controls.Add(Me.Label17)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Controls.Add(Me.Label18)
        Me.tpgConditions.Controls.Add(Me.Label16)
        Me.tpgConditions.Controls.Add(Me.cmbCoilType)
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.txtAllocatedAPD)
        Me.tpgConditions.Controls.Add(Me.lblAllocatedAPD)
        Me.tpgConditions.Controls.Add(Me.Label14)
        Me.tpgConditions.Controls.Add(Me.Label13)
        Me.tpgConditions.Controls.Add(Me.lblCircuitsofRH)
        Me.tpgConditions.Controls.Add(Me.nudCircuitsofRH)
        Me.tpgConditions.Controls.Add(Me.txtAFlow)
        Me.tpgConditions.Controls.Add(Me.lblReclaimAirflow)
        Me.tpgConditions.Controls.Add(Me.lblReclaimCap)
        Me.tpgConditions.Controls.Add(Me.lblRefType)
        Me.tpgConditions.Controls.Add(Me.txtReclaimCap)
        Me.tpgConditions.Controls.Add(Me.txtRefType)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(456, 191)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'lblFluid
        '
        Me.lblFluid.AutoSize = True
        Me.lblFluid.Enabled = False
        Me.lblFluid.Location = New System.Drawing.Point(242, 36)
        Me.lblFluid.Name = "lblFluid"
        Me.lblFluid.Size = New System.Drawing.Size(29, 13)
        Me.lblFluid.TabIndex = 62
        Me.lblFluid.Text = "Fluid"
        '
        'txtFluid
        '
        Me.txtFluid.Enabled = False
        Me.txtFluid.Location = New System.Drawing.Point(277, 33)
        Me.txtFluid.Name = "txtFluid"
        Me.txtFluid.Size = New System.Drawing.Size(62, 20)
        Me.txtFluid.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(234, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "ºF"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(166, 136)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(62, 20)
        Me.txtEAT.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 13)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Entering DB Temperature"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(110, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Coil Style"
        '
        'cmbCoilType
        '
        Me.cmbCoilType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCoilType.FormattingEnabled = True
        Me.cmbCoilType.Location = New System.Drawing.Point(166, 6)
        Me.cmbCoilType.Name = "cmbCoilType"
        Me.cmbCoilType.Size = New System.Drawing.Size(173, 21)
        Me.cmbCoilType.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = """wc"
        '
        'txtAllocatedAPD
        '
        Me.txtAllocatedAPD.Location = New System.Drawing.Point(166, 162)
        Me.txtAllocatedAPD.Name = "txtAllocatedAPD"
        Me.txtAllocatedAPD.Size = New System.Drawing.Size(62, 20)
        Me.txtAllocatedAPD.TabIndex = 8
        '
        'lblAllocatedAPD
        '
        Me.lblAllocatedAPD.AutoSize = True
        Me.lblAllocatedAPD.Location = New System.Drawing.Point(25, 165)
        Me.lblAllocatedAPD.Name = "lblAllocatedAPD"
        Me.lblAllocatedAPD.Size = New System.Drawing.Size(137, 13)
        Me.lblAllocatedAPD.TabIndex = 53
        Me.lblAllocatedAPD.Text = "Allocated Reclaim Coil APD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "MBH"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "cfm"
        '
        'lblCircuitsofRH
        '
        Me.lblCircuitsofRH.AutoSize = True
        Me.lblCircuitsofRH.Location = New System.Drawing.Point(257, 113)
        Me.lblCircuitsofRH.Name = "lblCircuitsofRH"
        Me.lblCircuitsofRH.Size = New System.Drawing.Size(91, 13)
        Me.lblCircuitsofRH.TabIndex = 49
        Me.lblCircuitsofRH.Text = "Circuits of Reheat"
        '
        'nudCircuitsofRH
        '
        Me.nudCircuitsofRH.Location = New System.Drawing.Point(354, 111)
        Me.nudCircuitsofRH.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCircuitsofRH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCircuitsofRH.Name = "nudCircuitsofRH"
        Me.nudCircuitsofRH.Size = New System.Drawing.Size(62, 20)
        Me.nudCircuitsofRH.TabIndex = 6
        Me.nudCircuitsofRH.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtAFlow
        '
        Me.txtAFlow.Location = New System.Drawing.Point(166, 110)
        Me.txtAFlow.Name = "txtAFlow"
        Me.txtAFlow.Size = New System.Drawing.Size(62, 20)
        Me.txtAFlow.TabIndex = 5
        '
        'lblReclaimAirflow
        '
        Me.lblReclaimAirflow.AutoSize = True
        Me.lblReclaimAirflow.Location = New System.Drawing.Point(63, 113)
        Me.lblReclaimAirflow.Name = "lblReclaimAirflow"
        Me.lblReclaimAirflow.Size = New System.Drawing.Size(99, 13)
        Me.lblReclaimAirflow.TabIndex = 46
        Me.lblReclaimAirflow.Text = "Reclaim Coil Airflow"
        '
        'lblReclaimCap
        '
        Me.lblReclaimCap.AutoSize = True
        Me.lblReclaimCap.Location = New System.Drawing.Point(51, 62)
        Me.lblReclaimCap.Name = "lblReclaimCap"
        Me.lblReclaimCap.Size = New System.Drawing.Size(109, 13)
        Me.lblReclaimCap.TabIndex = 45
        Me.lblReclaimCap.Text = "Reclaim Coil Capacity"
        '
        'lblRefType
        '
        Me.lblRefType.AutoSize = True
        Me.lblRefType.Location = New System.Drawing.Point(76, 36)
        Me.lblRefType.Name = "lblRefType"
        Me.lblRefType.Size = New System.Drawing.Size(86, 13)
        Me.lblRefType.TabIndex = 44
        Me.lblRefType.Text = "Refrigerant Type"
        '
        'txtReclaimCap
        '
        Me.txtReclaimCap.Location = New System.Drawing.Point(166, 59)
        Me.txtReclaimCap.Name = "txtReclaimCap"
        Me.txtReclaimCap.Size = New System.Drawing.Size(62, 20)
        Me.txtReclaimCap.TabIndex = 3
        '
        'txtRefType
        '
        Me.txtRefType.Location = New System.Drawing.Point(166, 33)
        Me.txtRefType.Name = "txtRefType"
        Me.txtRefType.Size = New System.Drawing.Size(62, 20)
        Me.txtRefType.TabIndex = 1
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(387, 164)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 9
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkPumpedCoil)
        Me.tpgOptions.Controls.Add(Me.chkFilterBankRelocation)
        Me.tpgOptions.Controls.Add(Me.GroupBox4)
        Me.tpgOptions.Controls.Add(Me.chkN2Holding)
        Me.tpgOptions.Controls.Add(Me.Label12)
        Me.tpgOptions.Controls.Add(Me.nudRows)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(456, 191)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkPumpedCoil
        '
        Me.chkPumpedCoil.AutoSize = True
        Me.chkPumpedCoil.Location = New System.Drawing.Point(12, 62)
        Me.chkPumpedCoil.Name = "chkPumpedCoil"
        Me.chkPumpedCoil.Size = New System.Drawing.Size(165, 17)
        Me.chkPumpedCoil.TabIndex = 43
        Me.chkPumpedCoil.Text = "Pumped Coil /w 3-Way Valve"
        Me.chkPumpedCoil.UseVisualStyleBackColor = True
        Me.chkPumpedCoil.Visible = False
        '
        'chkFilterBankRelocation
        '
        Me.chkFilterBankRelocation.AutoSize = True
        Me.chkFilterBankRelocation.Location = New System.Drawing.Point(12, 164)
        Me.chkFilterBankRelocation.Name = "chkFilterBankRelocation"
        Me.chkFilterBankRelocation.Size = New System.Drawing.Size(176, 17)
        Me.chkFilterBankRelocation.TabIndex = 42
        Me.chkFilterBankRelocation.Text = "Filter Bank Relocation Required"
        Me.chkFilterBankRelocation.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optPenTTHeatSecBFieldCut)
        Me.GroupBox4.Controls.Add(Me.optPenConvertibleFieldCut)
        Me.GroupBox4.Controls.Add(Me.optPenTTBFieldCut)
        Me.GroupBox4.Controls.Add(Me.optPenTTWFieldCut)
        Me.GroupBox4.Location = New System.Drawing.Point(183, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 105)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Connections"
        '
        'optPenTTHeatSecBFieldCut
        '
        Me.optPenTTHeatSecBFieldCut.AutoSize = True
        Me.optPenTTHeatSecBFieldCut.Location = New System.Drawing.Point(17, 35)
        Me.optPenTTHeatSecBFieldCut.Name = "optPenTTHeatSecBFieldCut"
        Me.optPenTTHeatSecBFieldCut.Size = New System.Drawing.Size(211, 17)
        Me.optPenTTHeatSecBFieldCut.TabIndex = 14
        Me.optPenTTHeatSecBFieldCut.Text = "Through the Heat Sec. Base - Field Cut"
        Me.optPenTTHeatSecBFieldCut.UseVisualStyleBackColor = True
        '
        'optPenConvertibleFieldCut
        '
        Me.optPenConvertibleFieldCut.AutoSize = True
        Me.optPenConvertibleFieldCut.Location = New System.Drawing.Point(17, 81)
        Me.optPenConvertibleFieldCut.Name = "optPenConvertibleFieldCut"
        Me.optPenConvertibleFieldCut.Size = New System.Drawing.Size(128, 17)
        Me.optPenConvertibleFieldCut.TabIndex = 13
        Me.optPenConvertibleFieldCut.Text = "Convertible - Field Cut"
        Me.optPenConvertibleFieldCut.UseVisualStyleBackColor = True
        '
        'optPenTTBFieldCut
        '
        Me.optPenTTBFieldCut.AutoSize = True
        Me.optPenTTBFieldCut.Checked = True
        Me.optPenTTBFieldCut.Location = New System.Drawing.Point(17, 13)
        Me.optPenTTBFieldCut.Name = "optPenTTBFieldCut"
        Me.optPenTTBFieldCut.Size = New System.Drawing.Size(160, 17)
        Me.optPenTTBFieldCut.TabIndex = 11
        Me.optPenTTBFieldCut.TabStop = True
        Me.optPenTTBFieldCut.Text = "Through the Base - Field Cut"
        Me.optPenTTBFieldCut.UseVisualStyleBackColor = True
        '
        'optPenTTWFieldCut
        '
        Me.optPenTTWFieldCut.AutoSize = True
        Me.optPenTTWFieldCut.Location = New System.Drawing.Point(17, 58)
        Me.optPenTTWFieldCut.Name = "optPenTTWFieldCut"
        Me.optPenTTWFieldCut.Size = New System.Drawing.Size(157, 17)
        Me.optPenTTWFieldCut.TabIndex = 12
        Me.optPenTTWFieldCut.Text = "Through the Wall - Field Cut"
        Me.optPenTTWFieldCut.UseVisualStyleBackColor = True
        '
        'chkN2Holding
        '
        Me.chkN2Holding.AutoSize = True
        Me.chkN2Holding.Location = New System.Drawing.Point(12, 39)
        Me.chkN2Holding.Name = "chkN2Holding"
        Me.chkN2Holding.Size = New System.Drawing.Size(142, 17)
        Me.chkN2Holding.TabIndex = 10
        Me.chkN2Holding.Text = "Nitrogen Holding Charge"
        Me.chkN2Holding.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Number of Rows"
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(12, 13)
        Me.nudRows.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(34, 20)
        Me.nudRows.TabIndex = 9
        Me.nudRows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(386, 164)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 13
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.grpLowLimit)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(456, 191)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpLowLimit
        '
        Me.grpLowLimit.Controls.Add(Me.optLLBreakStuff)
        Me.grpLowLimit.Controls.Add(Me.optLLNone)
        Me.grpLowLimit.Controls.Add(Me.optLLAveragingSensor)
        Me.grpLowLimit.Controls.Add(Me.optLLUnwired)
        Me.grpLowLimit.Location = New System.Drawing.Point(233, 6)
        Me.grpLowLimit.Name = "grpLowLimit"
        Me.grpLowLimit.Size = New System.Drawing.Size(216, 111)
        Me.grpLowLimit.TabIndex = 9
        Me.grpLowLimit.TabStop = False
        Me.grpLowLimit.Text = "Low Limit Protection"
        '
        'optLLBreakStuff
        '
        Me.optLLBreakStuff.AutoSize = True
        Me.optLLBreakStuff.Location = New System.Drawing.Point(6, 41)
        Me.optLLBreakStuff.Name = "optLLBreakStuff"
        Me.optLLBreakStuff.Size = New System.Drawing.Size(173, 17)
        Me.optLLBreakStuff.TabIndex = 19
        Me.optLLBreakStuff.Text = "Low Limit Stat Break/Open/etc"
        Me.optLLBreakStuff.UseVisualStyleBackColor = True
        '
        'optLLNone
        '
        Me.optLLNone.AutoSize = True
        Me.optLLNone.Location = New System.Drawing.Point(6, 88)
        Me.optLLNone.Name = "optLLNone"
        Me.optLLNone.Size = New System.Drawing.Size(51, 17)
        Me.optLLNone.TabIndex = 18
        Me.optLLNone.Text = "None"
        Me.optLLNone.UseVisualStyleBackColor = True
        '
        'optLLAveragingSensor
        '
        Me.optLLAveragingSensor.AutoSize = True
        Me.optLLAveragingSensor.Location = New System.Drawing.Point(6, 65)
        Me.optLLAveragingSensor.Name = "optLLAveragingSensor"
        Me.optLLAveragingSensor.Size = New System.Drawing.Size(210, 17)
        Me.optLLAveragingSensor.TabIndex = 17
        Me.optLLAveragingSensor.Text = "Coil Leaving Averaging Thermistor Only"
        Me.optLLAveragingSensor.UseVisualStyleBackColor = True
        '
        'optLLUnwired
        '
        Me.optLLUnwired.AutoSize = True
        Me.optLLUnwired.Checked = True
        Me.optLLUnwired.Location = New System.Drawing.Point(6, 19)
        Me.optLLUnwired.Name = "optLLUnwired"
        Me.optLLUnwired.Size = New System.Drawing.Size(133, 17)
        Me.optLLUnwired.TabIndex = 16
        Me.optLLUnwired.TabStop = True
        Me.optLLUnwired.Text = "Low Limit Stat Unwired"
        Me.optLLUnwired.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPHCoilLATCtrl)
        Me.GroupBox1.Controls.Add(Me.optNoControls)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 67)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control Style"
        '
        'optPHCoilLATCtrl
        '
        Me.optPHCoilLATCtrl.AutoSize = True
        Me.optPHCoilLATCtrl.Location = New System.Drawing.Point(6, 42)
        Me.optPHCoilLATCtrl.Name = "optPHCoilLATCtrl"
        Me.optPHCoilLATCtrl.Size = New System.Drawing.Size(99, 17)
        Me.optPHCoilLATCtrl.TabIndex = 15
        Me.optPHCoilLATCtrl.Text = "PH LAT Control"
        Me.optPHCoilLATCtrl.UseVisualStyleBackColor = True
        '
        'optNoControls
        '
        Me.optNoControls.AutoSize = True
        Me.optNoControls.Checked = True
        Me.optNoControls.Location = New System.Drawing.Point(6, 19)
        Me.optNoControls.Name = "optNoControls"
        Me.optNoControls.Size = New System.Drawing.Size(51, 17)
        Me.optNoControls.TabIndex = 14
        Me.optNoControls.TabStop = True
        Me.optNoControls.Text = "None"
        Me.optNoControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(386, 164)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.Label25)
        Me.tpgPerformance.Controls.Add(Me.txtOutConn)
        Me.tpgPerformance.Controls.Add(Me.Label26)
        Me.tpgPerformance.Controls.Add(Me.lblFPDUnits)
        Me.tpgPerformance.Controls.Add(Me.txtRefPD)
        Me.tpgPerformance.Controls.Add(Me.lblFluidPressDrop)
        Me.tpgPerformance.Controls.Add(Me.Label23)
        Me.tpgPerformance.Controls.Add(Me.txtCoilAPD)
        Me.tpgPerformance.Controls.Add(Me.lblActualAPD)
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.txtInConn)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(456, 191)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(261, 139)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 13)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "inches"
        '
        'txtOutConn
        '
        Me.txtOutConn.Location = New System.Drawing.Point(193, 136)
        Me.txtOutConn.Name = "txtOutConn"
        Me.txtOutConn.Size = New System.Drawing.Size(62, 20)
        Me.txtOutConn.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(95, 139)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 13)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "Outlet Connection"
        '
        'lblFPDUnits
        '
        Me.lblFPDUnits.AutoSize = True
        Me.lblFPDUnits.Location = New System.Drawing.Point(261, 61)
        Me.lblFPDUnits.Name = "lblFPDUnits"
        Me.lblFPDUnits.Size = New System.Drawing.Size(20, 13)
        Me.lblFPDUnits.TabIndex = 69
        Me.lblFPDUnits.Text = "psi"
        '
        'txtRefPD
        '
        Me.txtRefPD.Location = New System.Drawing.Point(193, 58)
        Me.txtRefPD.Name = "txtRefPD"
        Me.txtRefPD.Size = New System.Drawing.Size(62, 20)
        Me.txtRefPD.TabIndex = 2
        '
        'lblFluidPressDrop
        '
        Me.lblFluidPressDrop.AutoSize = True
        Me.lblFluidPressDrop.Location = New System.Drawing.Point(50, 61)
        Me.lblFluidPressDrop.Name = "lblFluidPressDrop"
        Me.lblFluidPressDrop.Size = New System.Drawing.Size(137, 13)
        Me.lblFluidPressDrop.TabIndex = 67
        Me.lblFluidPressDrop.Text = "Refrigeration Pressure Drop"
        Me.lblFluidPressDrop.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(261, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = """wc"
        '
        'txtCoilAPD
        '
        Me.txtCoilAPD.Location = New System.Drawing.Point(193, 84)
        Me.txtCoilAPD.Name = "txtCoilAPD"
        Me.txtCoilAPD.Size = New System.Drawing.Size(62, 20)
        Me.txtCoilAPD.TabIndex = 3
        '
        'lblActualAPD
        '
        Me.lblActualAPD.AutoSize = True
        Me.lblActualAPD.Location = New System.Drawing.Point(61, 87)
        Me.lblActualAPD.Name = "lblActualAPD"
        Me.lblActualAPD.Size = New System.Drawing.Size(123, 13)
        Me.lblActualAPD.TabIndex = 64
        Me.lblActualAPD.Text = "Actual Reclaim Coil APD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "ºF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(261, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "ºF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "inches"
        '
        'txtInConn
        '
        Me.txtInConn.Location = New System.Drawing.Point(193, 110)
        Me.txtInConn.Name = "txtInConn"
        Me.txtInConn.Size = New System.Drawing.Size(62, 20)
        Me.txtInConn.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Inlet Connection"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Delta T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Leaving DB Temp"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(193, 32)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(62, 20)
        Me.txtDeltaT.TabIndex = 1
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(193, 6)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(62, 20)
        Me.txtLAT.TabIndex = 0
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(386, 164)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerf.TabIndex = 6
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
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
        Me.tpgValves.Controls.Add(Me.Label1)
        Me.tpgValves.Controls.Add(Me.Label2)
        Me.tpgValves.Controls.Add(Me.txtValveTag)
        Me.tpgValves.Controls.Add(Me.Label3)
        Me.tpgValves.Controls.Add(Me.btnDoneValves)
        Me.tpgValves.Location = New System.Drawing.Point(4, 22)
        Me.tpgValves.Name = "tpgValves"
        Me.tpgValves.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgValves.Size = New System.Drawing.Size(456, 191)
        Me.tpgValves.TabIndex = 3
        Me.tpgValves.Text = "Valves"
        Me.tpgValves.UseVisualStyleBackColor = True
        '
        'btnDoneValves
        '
        Me.btnDoneValves.Location = New System.Drawing.Point(386, 164)
        Me.btnDoneValves.Name = "btnDoneValves"
        Me.btnDoneValves.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneValves.TabIndex = 7
        Me.btnDoneValves.Text = ">"
        Me.btnDoneValves.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 249)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 249)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSelectAValve
        '
        Me.btnSelectAValve.Image = CType(resources.GetObject("btnSelectAValve.Image"), System.Drawing.Image)
        Me.btnSelectAValve.Location = New System.Drawing.Point(77, 59)
        Me.btnSelectAValve.Name = "btnSelectAValve"
        Me.btnSelectAValve.Size = New System.Drawing.Size(22, 22)
        Me.btnSelectAValve.TabIndex = 34
        Me.btnSelectAValve.UseVisualStyleBackColor = True
        '
        'cmbValveDesc
        '
        Me.cmbValveDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveDesc.FormattingEnabled = True
        Me.cmbValveDesc.Items.AddRange(New Object() {"-"})
        Me.cmbValveDesc.Location = New System.Drawing.Point(105, 59)
        Me.cmbValveDesc.Name = "cmbValveDesc"
        Me.cmbValveDesc.Size = New System.Drawing.Size(240, 21)
        Me.cmbValveDesc.TabIndex = 33
        '
        'cmbValveSize
        '
        Me.cmbValveSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValveSize.FormattingEnabled = True
        Me.cmbValveSize.Items.AddRange(New Object() {"1/2", "3/4", "1", "1-1/4", "1-1/2", "2", "2-1/2", "-"})
        Me.cmbValveSize.Location = New System.Drawing.Point(288, 32)
        Me.cmbValveSize.Name = "cmbValveSize"
        Me.cmbValveSize.Size = New System.Drawing.Size(57, 21)
        Me.cmbValveSize.TabIndex = 32
        '
        'txtValveMPN
        '
        Me.txtValveMPN.Location = New System.Drawing.Point(105, 112)
        Me.txtValveMPN.Name = "txtValveMPN"
        Me.txtValveMPN.Size = New System.Drawing.Size(240, 20)
        Me.txtValveMPN.TabIndex = 30
        Me.txtValveMPN.Text = "-"
        Me.txtValveMPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(351, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Mfg. Part Number"
        '
        'txtValveType
        '
        Me.txtValveType.Location = New System.Drawing.Point(105, 86)
        Me.txtValveType.Name = "txtValveType"
        Me.txtValveType.Size = New System.Drawing.Size(240, 20)
        Me.txtValveType.TabIndex = 28
        Me.txtValveType.Text = "-"
        Me.txtValveType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(351, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Body Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Description"
        '
        'txtValveTag
        '
        Me.txtValveTag.Location = New System.Drawing.Point(305, 6)
        Me.txtValveTag.Name = "txtValveTag"
        Me.txtValveTag.Size = New System.Drawing.Size(40, 20)
        Me.txtValveTag.TabIndex = 24
        Me.txtValveTag.Text = "PHV-1"
        Me.txtValveTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tag"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optValve3Way)
        Me.GroupBox2.Controls.Add(Me.optValve2Way)
        Me.GroupBox2.Controls.Add(Me.optValveNone)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 100)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valves"
        '
        'optValveNone
        '
        Me.optValveNone.AutoSize = True
        Me.optValveNone.Checked = True
        Me.optValveNone.Location = New System.Drawing.Point(6, 21)
        Me.optValveNone.Name = "optValveNone"
        Me.optValveNone.Size = New System.Drawing.Size(51, 17)
        Me.optValveNone.TabIndex = 15
        Me.optValveNone.TabStop = True
        Me.optValveNone.Text = "None"
        Me.optValveNone.UseVisualStyleBackColor = True
        '
        'optValve2Way
        '
        Me.optValve2Way.AutoSize = True
        Me.optValve2Way.Location = New System.Drawing.Point(6, 44)
        Me.optValve2Way.Name = "optValve2Way"
        Me.optValve2Way.Size = New System.Drawing.Size(86, 17)
        Me.optValve2Way.TabIndex = 16
        Me.optValve2Way.Text = "2 Way Valve"
        Me.optValve2Way.UseVisualStyleBackColor = True
        '
        'optValve3Way
        '
        Me.optValve3Way.AutoSize = True
        Me.optValve3Way.Location = New System.Drawing.Point(6, 67)
        Me.optValve3Way.Name = "optValve3Way"
        Me.optValve3Way.Size = New System.Drawing.Size(86, 17)
        Me.optValve3Way.TabIndex = 17
        Me.optValve3Way.Text = "3 Way Valve"
        Me.optValve3Way.UseVisualStyleBackColor = True
        '
        'lblFluidFlowUnits
        '
        Me.lblFluidFlowUnits.AutoSize = True
        Me.lblFluidFlowUnits.Location = New System.Drawing.Point(234, 87)
        Me.lblFluidFlowUnits.Name = "lblFluidFlowUnits"
        Me.lblFluidFlowUnits.Size = New System.Drawing.Size(27, 13)
        Me.lblFluidFlowUnits.TabIndex = 65
        Me.lblFluidFlowUnits.Text = "gpm"
        '
        'lblFluidFlow
        '
        Me.lblFluidFlow.AutoSize = True
        Me.lblFluidFlow.Location = New System.Drawing.Point(102, 87)
        Me.lblFluidFlow.Name = "lblFluidFlow"
        Me.lblFluidFlow.Size = New System.Drawing.Size(54, 13)
        Me.lblFluidFlow.TabIndex = 64
        Me.lblFluidFlow.Text = "Fluid Flow"
        '
        'txtFluidFlow
        '
        Me.txtFluidFlow.Location = New System.Drawing.Point(166, 84)
        Me.txtFluidFlow.Name = "txtFluidFlow"
        Me.txtFluidFlow.Size = New System.Drawing.Size(62, 20)
        Me.txtFluidFlow.TabIndex = 4
        '
        'frmCustomCoil
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(467, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCustomCoil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Coil"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgControls.ResumeLayout(False)
        Me.grpLowLimit.ResumeLayout(False)
        Me.grpLowLimit.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.tpgValves.ResumeLayout(False)
        Me.tpgValves.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents cmbCoilType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAllocatedAPD As TextBox
    Friend WithEvents lblAllocatedAPD As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCircuitsofRH As Label
    Friend WithEvents nudCircuitsofRH As NumericUpDown
    Friend WithEvents txtAFlow As TextBox
    Friend WithEvents lblReclaimAirflow As Label
    Friend WithEvents lblReclaimCap As Label
    Friend WithEvents lblRefType As Label
    Friend WithEvents txtReclaimCap As TextBox
    Friend WithEvents txtRefType As TextBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents optPenTTWFieldCut As RadioButton
    Friend WithEvents optPenTTBFieldCut As RadioButton
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtInConn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents tpgValves As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents nudRows As NumericUpDown
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkN2Holding As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optPHCoilLATCtrl As RadioButton
    Friend WithEvents optNoControls As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents txtOutConn As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents lblFPDUnits As Label
    Friend WithEvents txtRefPD As TextBox
    Friend WithEvents lblFluidPressDrop As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCoilAPD As TextBox
    Friend WithEvents lblActualAPD As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblFluid As Label
    Friend WithEvents txtFluid As TextBox
    Friend WithEvents grpLowLimit As GroupBox
    Friend WithEvents optLLBreakStuff As RadioButton
    Friend WithEvents optLLNone As RadioButton
    Friend WithEvents optLLAveragingSensor As RadioButton
    Friend WithEvents optLLUnwired As RadioButton
    Friend WithEvents optPenConvertibleFieldCut As RadioButton
    Friend WithEvents chkFilterBankRelocation As CheckBox
    Friend WithEvents chkPumpedCoil As CheckBox
    Friend WithEvents optPenTTHeatSecBFieldCut As RadioButton
    Friend WithEvents btnDoneValves As Button
    Friend WithEvents btnSelectAValve As Button
    Friend WithEvents cmbValveDesc As ComboBox
    Friend WithEvents cmbValveSize As ComboBox
    Friend WithEvents txtValveMPN As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtValveType As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValveTag As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optValve3Way As RadioButton
    Friend WithEvents optValve2Way As RadioButton
    Friend WithEvents optValveNone As RadioButton
    Friend WithEvents lblFluidFlowUnits As Label
    Friend WithEvents lblFluidFlow As Label
    Friend WithEvents txtFluidFlow As TextBox
End Class
