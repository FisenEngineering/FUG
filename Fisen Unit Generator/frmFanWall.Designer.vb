<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFanWall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFanWall))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFanCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAirflowEachFan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbArraySize = New System.Windows.Forms.ComboBox()
        Me.cmdStaticSummary = New System.Windows.Forms.Button()
        Me.lblKFactor = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkTSPatElev = New System.Windows.Forms.CheckBox()
        Me.chkSFatElev = New System.Windows.Forms.CheckBox()
        Me.chkUSPatElev = New System.Windows.Forms.CheckBox()
        Me.chkESPatElev = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optIso2 = New System.Windows.Forms.RadioButton()
        Me.optIso1 = New System.Windows.Forms.RadioButton()
        Me.optIsoNone = New System.Windows.Forms.RadioButton()
        Me.grpFlowConfig = New System.Windows.Forms.GroupBox()
        Me.optHorizFlow = New System.Windows.Forms.RadioButton()
        Me.optDownFlow = New System.Windows.Forms.RadioButton()
        Me.grpDPPCkt = New System.Windows.Forms.GroupBox()
        Me.optDPPEmergency = New System.Windows.Forms.RadioButton()
        Me.optDPPCommercial = New System.Windows.Forms.RadioButton()
        Me.optDPPNA = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbFanType = New System.Windows.Forms.ComboBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.grpAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkReliefHoodsShipLoose = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.tpgStaticSum = New System.Windows.Forms.TabPage()
        Me.cmdPopulateStaticTable = New System.Windows.Forms.Button()
        Me.cmbUSPType = New System.Windows.Forms.ComboBox()
        Me.chkHeatBaffles = New System.Windows.Forms.CheckBox()
        Me.chkReheatCoil = New System.Windows.Forms.CheckBox()
        Me.chkPwrExhaustPresent = New System.Windows.Forms.CheckBox()
        Me.chkEconPresent = New System.Windows.Forms.CheckBox()
        Me.grpFilterStyle = New System.Windows.Forms.GroupBox()
        Me.opt1InchFilters = New System.Windows.Forms.RadioButton()
        Me.opt6inch95 = New System.Windows.Forms.RadioButton()
        Me.opt6inch65 = New System.Windows.Forms.RadioButton()
        Me.opt4InchFilters = New System.Windows.Forms.RadioButton()
        Me.opt2InchFilters = New System.Windows.Forms.RadioButton()
        Me.lblHeatType = New System.Windows.Forms.Label()
        Me.cmbHeatBox = New System.Windows.Forms.ComboBox()
        Me.dgvStaticSummary = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSTPStatic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colATPStatic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslblAirflow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblTSP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblESP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblElevation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grpFlowConfig.SuspendLayout()
        Me.grpDPPCkt.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgStaticSum.SuspendLayout()
        Me.grpFilterStyle.SuspendLayout()
        CType(Me.dgvStaticSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 473)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 68
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(90, 461)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 65
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 461)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 64
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(748, 461)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 69
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(784, 461)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 67
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(820, 461)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 66
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.tpgStaticSum)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 441)
        Me.TabControl1.TabIndex = 70
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label10)
        Me.tpgConditions.Controls.Add(Me.lblFanCount)
        Me.tpgConditions.Controls.Add(Me.Label7)
        Me.tpgConditions.Controls.Add(Me.Label9)
        Me.tpgConditions.Controls.Add(Me.txtAirflowEachFan)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.cmbArraySize)
        Me.tpgConditions.Controls.Add(Me.cmdStaticSummary)
        Me.tpgConditions.Controls.Add(Me.lblKFactor)
        Me.tpgConditions.Controls.Add(Me.Label32)
        Me.tpgConditions.Controls.Add(Me.chkTSPatElev)
        Me.tpgConditions.Controls.Add(Me.chkSFatElev)
        Me.tpgConditions.Controls.Add(Me.chkUSPatElev)
        Me.tpgConditions.Controls.Add(Me.chkESPatElev)
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
        Me.tpgConditions.Controls.Add(Me.GroupBox5)
        Me.tpgConditions.Controls.Add(Me.grpFlowConfig)
        Me.tpgConditions.Controls.Add(Me.grpDPPCkt)
        Me.tpgConditions.Controls.Add(Me.Label19)
        Me.tpgConditions.Controls.Add(Me.cmbFanType)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(834, 415)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Fans"
        '
        'lblFanCount
        '
        Me.lblFanCount.AutoSize = True
        Me.lblFanCount.Location = New System.Drawing.Point(340, 76)
        Me.lblFanCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFanCount.Name = "lblFanCount"
        Me.lblFanCount.Size = New System.Drawing.Size(19, 13)
        Me.lblFanCount.TabIndex = 109
        Me.lblFanCount.Text = "99"
        Me.lblFanCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "CFM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Each Fan Flow"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAirflowEachFan
        '
        Me.txtAirflowEachFan.Location = New System.Drawing.Point(171, 101)
        Me.txtAirflowEachFan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAirflowEachFan.Name = "txtAirflowEachFan"
        Me.txtAirflowEachFan.Size = New System.Drawing.Size(81, 20)
        Me.txtAirflowEachFan.TabIndex = 106
        Me.txtAirflowEachFan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Array Size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbArraySize
        '
        Me.cmbArraySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArraySize.FormattingEnabled = True
        Me.cmbArraySize.Items.AddRange(New Object() {"2x1", "2x2", "3x1", "3x2", "3x3", "4x1", "4x2", "4x3", "4x4", "Unselected"})
        Me.cmbArraySize.Location = New System.Drawing.Point(171, 45)
        Me.cmbArraySize.Name = "cmbArraySize"
        Me.cmbArraySize.Size = New System.Drawing.Size(111, 21)
        Me.cmbArraySize.TabIndex = 104
        '
        'cmdStaticSummary
        '
        Me.cmdStaticSummary.Location = New System.Drawing.Point(171, 157)
        Me.cmdStaticSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdStaticSummary.Name = "cmdStaticSummary"
        Me.cmdStaticSummary.Size = New System.Drawing.Size(81, 22)
        Me.cmdStaticSummary.TabIndex = 81
        Me.cmdStaticSummary.Text = "Summary"
        Me.cmdStaticSummary.UseVisualStyleBackColor = True
        '
        'lblKFactor
        '
        Me.lblKFactor.AutoSize = True
        Me.lblKFactor.Location = New System.Drawing.Point(290, 274)
        Me.lblKFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKFactor.Name = "lblKFactor"
        Me.lblKFactor.Size = New System.Drawing.Size(28, 13)
        Me.lblKFactor.TabIndex = 103
        Me.lblKFactor.Text = "1.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(290, 76)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 13)
        Me.Label32.TabIndex = 102
        Me.Label32.Text = "Elev"
        '
        'chkTSPatElev
        '
        Me.chkTSPatElev.AutoSize = True
        Me.chkTSPatElev.Location = New System.Drawing.Point(295, 246)
        Me.chkTSPatElev.Name = "chkTSPatElev"
        Me.chkTSPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkTSPatElev.TabIndex = 101
        Me.chkTSPatElev.UseVisualStyleBackColor = True
        '
        'chkSFatElev
        '
        Me.chkSFatElev.AutoSize = True
        Me.chkSFatElev.Location = New System.Drawing.Point(295, 218)
        Me.chkSFatElev.Name = "chkSFatElev"
        Me.chkSFatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkSFatElev.TabIndex = 100
        Me.chkSFatElev.UseVisualStyleBackColor = True
        '
        'chkUSPatElev
        '
        Me.chkUSPatElev.AutoSize = True
        Me.chkUSPatElev.Location = New System.Drawing.Point(295, 190)
        Me.chkUSPatElev.Name = "chkUSPatElev"
        Me.chkUSPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkUSPatElev.TabIndex = 99
        Me.chkUSPatElev.UseVisualStyleBackColor = True
        '
        'chkESPatElev
        '
        Me.chkESPatElev.AutoSize = True
        Me.chkESPatElev.Location = New System.Drawing.Point(295, 132)
        Me.chkESPatElev.Name = "chkESPatElev"
        Me.chkESPatElev.Size = New System.Drawing.Size(15, 14)
        Me.chkESPatElev.TabIndex = 98
        Me.chkESPatElev.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(262, 274)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "ft."
        '
        'txtElevation
        '
        Me.txtElevation.Location = New System.Drawing.Point(171, 271)
        Me.txtElevation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtElevation.Name = "txtElevation"
        Me.txtElevation.Size = New System.Drawing.Size(81, 20)
        Me.txtElevation.TabIndex = 85
        Me.txtElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(113, 274)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "Elevation"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = """wc"
        '
        'txtUSPSafetyFactor
        '
        Me.txtUSPSafetyFactor.Location = New System.Drawing.Point(171, 215)
        Me.txtUSPSafetyFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUSPSafetyFactor.Name = "txtUSPSafetyFactor"
        Me.txtUSPSafetyFactor.Size = New System.Drawing.Size(81, 20)
        Me.txtUSPSafetyFactor.TabIndex = 83
        Me.txtUSPSafetyFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(96, 218)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Safety Factor"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = """wc"
        '
        'txtTSP
        '
        Me.txtTSP.Location = New System.Drawing.Point(171, 243)
        Me.txtTSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTSP.Name = "txtTSP"
        Me.txtTSP.Size = New System.Drawing.Size(81, 20)
        Me.txtTSP.TabIndex = 84
        Me.txtTSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 246)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Total Static Pressure"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 132)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = """wc"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "CFM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 190)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = """wc"
        '
        'txtUSP
        '
        Me.txtUSP.Location = New System.Drawing.Point(171, 187)
        Me.txtUSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUSP.Name = "txtUSP"
        Me.txtUSP.Size = New System.Drawing.Size(81, 20)
        Me.txtUSP.TabIndex = 82
        Me.txtUSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Estimated Unit Static Pressure"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "External Static Pressure"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 76)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Total Airflow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtESP
        '
        Me.txtESP.Location = New System.Drawing.Point(171, 129)
        Me.txtESP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtESP.Name = "txtESP"
        Me.txtESP.Size = New System.Drawing.Size(81, 20)
        Me.txtESP.TabIndex = 80
        Me.txtESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(171, 73)
        Me.txtAirflow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(81, 20)
        Me.txtAirflow.TabIndex = 79
        Me.txtAirflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optIso2)
        Me.GroupBox5.Controls.Add(Me.optIso1)
        Me.GroupBox5.Controls.Add(Me.optIsoNone)
        Me.GroupBox5.Location = New System.Drawing.Point(590, 91)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(111, 96)
        Me.GroupBox5.TabIndex = 78
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
        'grpFlowConfig
        '
        Me.grpFlowConfig.Controls.Add(Me.optHorizFlow)
        Me.grpFlowConfig.Controls.Add(Me.optDownFlow)
        Me.grpFlowConfig.Location = New System.Drawing.Point(590, 11)
        Me.grpFlowConfig.Name = "grpFlowConfig"
        Me.grpFlowConfig.Size = New System.Drawing.Size(111, 74)
        Me.grpFlowConfig.TabIndex = 77
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
        'grpDPPCkt
        '
        Me.grpDPPCkt.Controls.Add(Me.optDPPEmergency)
        Me.grpDPPCkt.Controls.Add(Me.optDPPCommercial)
        Me.grpDPPCkt.Controls.Add(Me.optDPPNA)
        Me.grpDPPCkt.Location = New System.Drawing.Point(707, 11)
        Me.grpDPPCkt.Name = "grpDPPCkt"
        Me.grpDPPCkt.Size = New System.Drawing.Size(119, 100)
        Me.grpDPPCkt.TabIndex = 76
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(88, 21)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 13)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Fan Wall Type"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFanType
        '
        Me.cmbFanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFanType.Enabled = False
        Me.cmbFanType.FormattingEnabled = True
        Me.cmbFanType.Items.AddRange(New Object() {"Supply Fan Array", "Return Fan Array", "Exhaust Fan Array", "Not Selected"})
        Me.cmbFanType.Location = New System.Drawing.Point(171, 18)
        Me.cmbFanType.Name = "cmbFanType"
        Me.cmbFanType.Size = New System.Drawing.Size(111, 21)
        Me.cmbFanType.TabIndex = 0
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(771, 383)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 9
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.grpAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chkReliefHoodsShipLoose)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(834, 415)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(618, 356)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 100
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(612, 334)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 99
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(9, 390)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 98
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'grpAuxPanel
        '
        Me.grpAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.grpAuxPanel.Controls.Add(Me.optUseAux)
        Me.grpAuxPanel.Controls.Add(Me.optNoAux)
        Me.grpAuxPanel.Enabled = False
        Me.grpAuxPanel.Location = New System.Drawing.Point(612, 235)
        Me.grpAuxPanel.Name = "grpAuxPanel"
        Me.grpAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.grpAuxPanel.TabIndex = 97
        Me.grpAuxPanel.TabStop = False
        Me.grpAuxPanel.Text = "Auxiliary Control Panel"
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
        Me.optUseAux.Text = "Use Auxiliary Control Panel"
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
        'chkReliefHoodsShipLoose
        '
        Me.chkReliefHoodsShipLoose.AutoSize = True
        Me.chkReliefHoodsShipLoose.Location = New System.Drawing.Point(618, 5)
        Me.chkReliefHoodsShipLoose.Name = "chkReliefHoodsShipLoose"
        Me.chkReliefHoodsShipLoose.Size = New System.Drawing.Size(143, 17)
        Me.chkReliefHoodsShipLoose.TabIndex = 86
        Me.chkReliefHoodsShipLoose.Text = "Relief Hoods Ship Loose"
        Me.chkReliefHoodsShipLoose.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(771, 383)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(834, 415)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(771, 383)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Size = New System.Drawing.Size(834, 415)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(771, 383)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 24
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'tpgStaticSum
        '
        Me.tpgStaticSum.Controls.Add(Me.cmdPopulateStaticTable)
        Me.tpgStaticSum.Controls.Add(Me.cmbUSPType)
        Me.tpgStaticSum.Controls.Add(Me.chkHeatBaffles)
        Me.tpgStaticSum.Controls.Add(Me.chkReheatCoil)
        Me.tpgStaticSum.Controls.Add(Me.chkPwrExhaustPresent)
        Me.tpgStaticSum.Controls.Add(Me.chkEconPresent)
        Me.tpgStaticSum.Controls.Add(Me.grpFilterStyle)
        Me.tpgStaticSum.Controls.Add(Me.lblHeatType)
        Me.tpgStaticSum.Controls.Add(Me.cmbHeatBox)
        Me.tpgStaticSum.Controls.Add(Me.dgvStaticSummary)
        Me.tpgStaticSum.Controls.Add(Me.btnReturn)
        Me.tpgStaticSum.Location = New System.Drawing.Point(4, 22)
        Me.tpgStaticSum.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgStaticSum.Name = "tpgStaticSum"
        Me.tpgStaticSum.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgStaticSum.Size = New System.Drawing.Size(834, 415)
        Me.tpgStaticSum.TabIndex = 3
        Me.tpgStaticSum.Text = "Static Summary"
        Me.tpgStaticSum.UseVisualStyleBackColor = True
        '
        'cmdPopulateStaticTable
        '
        Me.cmdPopulateStaticTable.Location = New System.Drawing.Point(279, 209)
        Me.cmdPopulateStaticTable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPopulateStaticTable.Name = "cmdPopulateStaticTable"
        Me.cmdPopulateStaticTable.Size = New System.Drawing.Size(86, 21)
        Me.cmdPopulateStaticTable.TabIndex = 47
        Me.cmdPopulateStaticTable.Text = "Populate"
        Me.cmdPopulateStaticTable.UseVisualStyleBackColor = True
        '
        'cmbUSPType
        '
        Me.cmbUSPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUSPType.FormattingEnabled = True
        Me.cmbUSPType.Items.AddRange(New Object() {"Unselected"})
        Me.cmbUSPType.Location = New System.Drawing.Point(26, 210)
        Me.cmbUSPType.Name = "cmbUSPType"
        Me.cmbUSPType.Size = New System.Drawing.Size(246, 21)
        Me.cmbUSPType.TabIndex = 46
        '
        'chkHeatBaffles
        '
        Me.chkHeatBaffles.AutoSize = True
        Me.chkHeatBaffles.Location = New System.Drawing.Point(589, 9)
        Me.chkHeatBaffles.Name = "chkHeatBaffles"
        Me.chkHeatBaffles.Size = New System.Drawing.Size(179, 17)
        Me.chkHeatBaffles.TabIndex = 45
        Me.chkHeatBaffles.Text = "Standard  Heat Baffles Required"
        Me.chkHeatBaffles.UseVisualStyleBackColor = True
        Me.chkHeatBaffles.Visible = False
        '
        'chkReheatCoil
        '
        Me.chkReheatCoil.AutoSize = True
        Me.chkReheatCoil.Location = New System.Drawing.Point(514, 110)
        Me.chkReheatCoil.Name = "chkReheatCoil"
        Me.chkReheatCoil.Size = New System.Drawing.Size(120, 17)
        Me.chkReheatCoil.TabIndex = 44
        Me.chkReheatCoil.Text = "Reheat Coil Present"
        Me.chkReheatCoil.UseVisualStyleBackColor = True
        Me.chkReheatCoil.Visible = False
        '
        'chkPwrExhaustPresent
        '
        Me.chkPwrExhaustPresent.AutoSize = True
        Me.chkPwrExhaustPresent.Location = New System.Drawing.Point(388, 133)
        Me.chkPwrExhaustPresent.Name = "chkPwrExhaustPresent"
        Me.chkPwrExhaustPresent.Size = New System.Drawing.Size(136, 17)
        Me.chkPwrExhaustPresent.TabIndex = 43
        Me.chkPwrExhaustPresent.Text = "Power Exhaust Present"
        Me.chkPwrExhaustPresent.UseVisualStyleBackColor = True
        Me.chkPwrExhaustPresent.Visible = False
        '
        'chkEconPresent
        '
        Me.chkEconPresent.AutoSize = True
        Me.chkEconPresent.Location = New System.Drawing.Point(388, 110)
        Me.chkEconPresent.Name = "chkEconPresent"
        Me.chkEconPresent.Size = New System.Drawing.Size(120, 17)
        Me.chkEconPresent.TabIndex = 42
        Me.chkEconPresent.Text = "Economizer Present"
        Me.chkEconPresent.UseVisualStyleBackColor = True
        Me.chkEconPresent.Visible = False
        '
        'grpFilterStyle
        '
        Me.grpFilterStyle.Controls.Add(Me.opt1InchFilters)
        Me.grpFilterStyle.Controls.Add(Me.opt6inch95)
        Me.grpFilterStyle.Controls.Add(Me.opt6inch65)
        Me.grpFilterStyle.Controls.Add(Me.opt4InchFilters)
        Me.grpFilterStyle.Controls.Add(Me.opt2InchFilters)
        Me.grpFilterStyle.Location = New System.Drawing.Point(388, 35)
        Me.grpFilterStyle.Name = "grpFilterStyle"
        Me.grpFilterStyle.Size = New System.Drawing.Size(246, 69)
        Me.grpFilterStyle.TabIndex = 41
        Me.grpFilterStyle.TabStop = False
        Me.grpFilterStyle.Text = "Filters"
        Me.grpFilterStyle.Visible = False
        '
        'opt1InchFilters
        '
        Me.opt1InchFilters.AutoSize = True
        Me.opt1InchFilters.Location = New System.Drawing.Point(6, 19)
        Me.opt1InchFilters.Name = "opt1InchFilters"
        Me.opt1InchFilters.Size = New System.Drawing.Size(66, 17)
        Me.opt1InchFilters.TabIndex = 28
        Me.opt1InchFilters.Text = "1"" Filters"
        Me.opt1InchFilters.UseVisualStyleBackColor = True
        '
        'opt6inch95
        '
        Me.opt6inch95.AutoSize = True
        Me.opt6inch95.Location = New System.Drawing.Point(160, 42)
        Me.opt6inch95.Name = "opt6inch95"
        Me.opt6inch95.Size = New System.Drawing.Size(59, 17)
        Me.opt6inch95.TabIndex = 3
        Me.opt6inch95.Text = "6"" 95%"
        Me.opt6inch95.UseVisualStyleBackColor = True
        '
        'opt6inch65
        '
        Me.opt6inch65.AutoSize = True
        Me.opt6inch65.Location = New System.Drawing.Point(160, 19)
        Me.opt6inch65.Name = "opt6inch65"
        Me.opt6inch65.Size = New System.Drawing.Size(59, 17)
        Me.opt6inch65.TabIndex = 2
        Me.opt6inch65.Text = "6"" 65%"
        Me.opt6inch65.UseVisualStyleBackColor = True
        '
        'opt4InchFilters
        '
        Me.opt4InchFilters.AutoSize = True
        Me.opt4InchFilters.Location = New System.Drawing.Point(78, 42)
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
        Me.opt2InchFilters.Location = New System.Drawing.Point(78, 19)
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
        Me.lblHeatType.Location = New System.Drawing.Point(385, 10)
        Me.lblHeatType.Name = "lblHeatType"
        Me.lblHeatType.Size = New System.Drawing.Size(57, 13)
        Me.lblHeatType.TabIndex = 40
        Me.lblHeatType.Text = "Heat Type"
        Me.lblHeatType.Visible = False
        '
        'cmbHeatBox
        '
        Me.cmbHeatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeatBox.FormattingEnabled = True
        Me.cmbHeatBox.Items.AddRange(New Object() {"Gas", "267 MBH Gas", "512 MBH Gas", "800 MBH Gas", "CoolOnly", "5kW", "7kW", "9kW", "10kW", "15kW", "18kW", "20kW", "24kW", "25kW", "30kW", "36kW", "40kW", "50kW", "54kW", "72kW", "75kW", "Not Selected"})
        Me.cmbHeatBox.Location = New System.Drawing.Point(448, 7)
        Me.cmbHeatBox.Name = "cmbHeatBox"
        Me.cmbHeatBox.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeatBox.TabIndex = 39
        Me.cmbHeatBox.Visible = False
        '
        'dgvStaticSummary
        '
        Me.dgvStaticSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaticSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colSTPStatic, Me.colATPStatic})
        Me.dgvStaticSummary.Location = New System.Drawing.Point(7, 7)
        Me.dgvStaticSummary.Name = "dgvStaticSummary"
        Me.dgvStaticSummary.RowHeadersWidth = 51
        Me.dgvStaticSummary.RowTemplate.Height = 28
        Me.dgvStaticSummary.Size = New System.Drawing.Size(369, 197)
        Me.dgvStaticSummary.TabIndex = 10
        '
        'colItem
        '
        Me.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colItem.DefaultCellStyle = DataGridViewCellStyle10
        Me.colItem.HeaderText = "Item"
        Me.colItem.MinimumWidth = 6
        Me.colItem.Name = "colItem"
        Me.colItem.Width = 52
        '
        'colSTPStatic
        '
        Me.colSTPStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSTPStatic.DefaultCellStyle = DataGridViewCellStyle11
        Me.colSTPStatic.HeaderText = "Static(std)"
        Me.colSTPStatic.MinimumWidth = 6
        Me.colSTPStatic.Name = "colSTPStatic"
        Me.colSTPStatic.Width = 79
        '
        'colATPStatic
        '
        Me.colATPStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colATPStatic.DefaultCellStyle = DataGridViewCellStyle12
        Me.colATPStatic.HeaderText = "Static(elev)"
        Me.colATPStatic.MinimumWidth = 6
        Me.colATPStatic.Name = "colATPStatic"
        Me.colATPStatic.Width = 85
        '
        'btnReturn
        '
        Me.btnReturn.Enabled = False
        Me.btnReturn.Location = New System.Drawing.Point(771, 383)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(55, 28)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(712, 461)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 71
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblAirflow, Me.tslblTSP, Me.tslblESP, Me.tslblElevation})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(867, 22)
        Me.StatusStrip1.TabIndex = 72
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
        Me.tslblTSP.Size = New System.Drawing.Size(53, 17)
        Me.tslblTSP.Text = "TSP: x.xx"
        '
        'tslblESP
        '
        Me.tslblESP.Name = "tslblESP"
        Me.tslblESP.Size = New System.Drawing.Size(53, 17)
        Me.tslblESP.Text = "ESP: x.xx"
        '
        'tslblElevation
        '
        Me.tslblElevation.Name = "tslblElevation"
        Me.tslblElevation.Size = New System.Drawing.Size(85, 17)
        Me.tslblElevation.Text = "Elevation: xxxx"
        '
        'frmFanWall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFanWall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmFanWall"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.grpFlowConfig.ResumeLayout(False)
        Me.grpFlowConfig.PerformLayout()
        Me.grpDPPCkt.ResumeLayout(False)
        Me.grpDPPCkt.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpAuxPanel.ResumeLayout(False)
        Me.grpAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
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

    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents grpDPPCkt As GroupBox
    Friend WithEvents optDPPEmergency As RadioButton
    Friend WithEvents optDPPCommercial As RadioButton
    Friend WithEvents optDPPNA As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbFanType As ComboBox
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents grpAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents chkReliefHoodsShipLoose As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents tpgStaticSum As TabPage
    Friend WithEvents btnReturn As Button
    Friend WithEvents cmdScience As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optIso2 As RadioButton
    Friend WithEvents optIso1 As RadioButton
    Friend WithEvents optIsoNone As RadioButton
    Friend WithEvents grpFlowConfig As GroupBox
    Friend WithEvents optHorizFlow As RadioButton
    Friend WithEvents optDownFlow As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbArraySize As ComboBox
    Friend WithEvents cmdStaticSummary As Button
    Friend WithEvents lblKFactor As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents chkTSPatElev As CheckBox
    Friend WithEvents chkSFatElev As CheckBox
    Friend WithEvents chkUSPatElev As CheckBox
    Friend WithEvents chkESPatElev As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtElevation As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUSPSafetyFactor As TextBox
    Friend WithEvents Label16 As Label
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAirflowEachFan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFanCount As Label
    Friend WithEvents dgvStaticSummary As DataGridView
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colSTPStatic As DataGridViewTextBoxColumn
    Friend WithEvents colATPStatic As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslblAirflow As ToolStripStatusLabel
    Friend WithEvents tslblTSP As ToolStripStatusLabel
    Friend WithEvents tslblESP As ToolStripStatusLabel
    Friend WithEvents tslblElevation As ToolStripStatusLabel
    Friend WithEvents cmbUSPType As ComboBox
    Friend WithEvents chkHeatBaffles As CheckBox
    Friend WithEvents chkReheatCoil As CheckBox
    Friend WithEvents chkPwrExhaustPresent As CheckBox
    Friend WithEvents chkEconPresent As CheckBox
    Friend WithEvents grpFilterStyle As GroupBox
    Friend WithEvents opt1InchFilters As RadioButton
    Friend WithEvents opt6inch95 As RadioButton
    Friend WithEvents opt6inch65 As RadioButton
    Friend WithEvents opt4InchFilters As RadioButton
    Friend WithEvents opt2InchFilters As RadioButton
    Friend WithEvents lblHeatType As Label
    Friend WithEvents cmbHeatBox As ComboBox
    Friend WithEvents cmdPopulateStaticTable As Button
End Class
