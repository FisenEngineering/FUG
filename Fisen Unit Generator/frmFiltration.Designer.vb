<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltration
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkModJCIFilts = New System.Windows.Forms.CheckBox()
        Me.cmbFFType = New System.Windows.Forms.ComboBox()
        Me.cmbIFType = New System.Windows.Forms.ComboBox()
        Me.chkFFPrefilt = New System.Windows.Forms.CheckBox()
        Me.chkIFPrefilt = New System.Windows.Forms.CheckBox()
        Me.chkFFBank = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAirflow = New System.Windows.Forms.TextBox()
        Me.chkIFBank = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkDownExtModule = New System.Windows.Forms.CheckBox()
        Me.chkSideExtModule = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.grpCtrlFinal = New System.Windows.Forms.GroupBox()
        Me.chkFFMinihelic = New System.Windows.Forms.CheckBox()
        Me.cmbFFMagRange = New System.Windows.Forms.ComboBox()
        Me.chkFFMagnehelic = New System.Windows.Forms.CheckBox()
        Me.grpCtrlFactory = New System.Windows.Forms.GroupBox()
        Me.grpCtrlInitital = New System.Windows.Forms.GroupBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgFilters = New System.Windows.Forms.TabPage()
        Me.btnDoneFilters = New System.Windows.Forms.Button()
        Me.grpFFFilts = New System.Windows.Forms.GroupBox()
        Me.cmbActFF = New System.Windows.Forms.ComboBox()
        Me.cmdSubFF = New System.Windows.Forms.Button()
        Me.cmdAddFF = New System.Windows.Forms.Button()
        Me.lstFFSelected = New System.Windows.Forms.ListBox()
        Me.lstFFAvail = New System.Windows.Forms.ListBox()
        Me.grpJCIFilts = New System.Windows.Forms.GroupBox()
        Me.grpIFFilts = New System.Windows.Forms.GroupBox()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStaticBudget = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDFA = New System.Windows.Forms.TextBox()
        Me.lblMaxAPD = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAPD = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFaceVelocity = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFaceArea = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFilterQ3 = New System.Windows.Forms.Label()
        Me.lblFilterQ2 = New System.Windows.Forms.Label()
        Me.lblFilterQ1 = New System.Windows.Forms.Label()
        Me.lblFilterSize3 = New System.Windows.Forms.Label()
        Me.lblFilterSize2 = New System.Windows.Forms.Label()
        Me.lblFilterSize1 = New System.Windows.Forms.Label()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.grpCtrlFinal.SuspendLayout()
        Me.tpgFilters.SuspendLayout()
        Me.grpFFFilts.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgFilters)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(5, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(639, 326)
        Me.TabControl1.TabIndex = 5
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkModJCIFilts)
        Me.tpgConditions.Controls.Add(Me.cmbFFType)
        Me.tpgConditions.Controls.Add(Me.cmbIFType)
        Me.tpgConditions.Controls.Add(Me.chkFFPrefilt)
        Me.tpgConditions.Controls.Add(Me.chkIFPrefilt)
        Me.tpgConditions.Controls.Add(Me.chkFFBank)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtAirflow)
        Me.tpgConditions.Controls.Add(Me.chkIFBank)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(631, 300)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chkModJCIFilts
        '
        Me.chkModJCIFilts.AutoSize = True
        Me.chkModJCIFilts.Location = New System.Drawing.Point(6, 124)
        Me.chkModJCIFilts.Name = "chkModJCIFilts"
        Me.chkModJCIFilts.Size = New System.Drawing.Size(193, 17)
        Me.chkModJCIFilts.TabIndex = 34
        Me.chkModJCIFilts.Text = "Modify/Relpace Factory Filter Bank"
        Me.chkModJCIFilts.UseVisualStyleBackColor = True
        '
        'cmbFFType
        '
        Me.cmbFFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFFType.Enabled = False
        Me.cmbFFType.FormattingEnabled = True
        Me.cmbFFType.Items.AddRange(New Object() {"MERV 8 (2in)", "MERV 8 (4in)", "MERV 14 (4in)", "MERV 14 (6in)", "MERV 14 (12in)", "N/A"})
        Me.cmbFFType.Location = New System.Drawing.Point(179, 76)
        Me.cmbFFType.Name = "cmbFFType"
        Me.cmbFFType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFFType.TabIndex = 33
        '
        'cmbIFType
        '
        Me.cmbIFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIFType.Enabled = False
        Me.cmbIFType.FormattingEnabled = True
        Me.cmbIFType.Items.AddRange(New Object() {"MERV 8 (2in)", "MERV 8 (4in)", "MERV 14 (4in)", "MERV 14 (6in)", "MERV 14 (12in)", "N/A"})
        Me.cmbIFType.Location = New System.Drawing.Point(179, 30)
        Me.cmbIFType.Name = "cmbIFType"
        Me.cmbIFType.Size = New System.Drawing.Size(121, 21)
        Me.cmbIFType.TabIndex = 32
        '
        'chkFFPrefilt
        '
        Me.chkFFPrefilt.AutoSize = True
        Me.chkFFPrefilt.Enabled = False
        Me.chkFFPrefilt.Location = New System.Drawing.Point(20, 101)
        Me.chkFFPrefilt.Name = "chkFFPrefilt"
        Me.chkFFPrefilt.Size = New System.Drawing.Size(144, 17)
        Me.chkFFPrefilt.TabIndex = 30
        Me.chkFFPrefilt.Text = "Final Filter Bank Prefilters"
        Me.chkFFPrefilt.UseVisualStyleBackColor = True
        '
        'chkIFPrefilt
        '
        Me.chkIFPrefilt.AutoSize = True
        Me.chkIFPrefilt.Enabled = False
        Me.chkIFPrefilt.Location = New System.Drawing.Point(20, 55)
        Me.chkIFPrefilt.Name = "chkIFPrefilt"
        Me.chkIFPrefilt.Size = New System.Drawing.Size(146, 17)
        Me.chkIFPrefilt.TabIndex = 29
        Me.chkIFPrefilt.Text = "Initial Filter Bank Prefilters"
        Me.chkIFPrefilt.UseVisualStyleBackColor = True
        '
        'chkFFBank
        '
        Me.chkFFBank.AutoSize = True
        Me.chkFFBank.Location = New System.Drawing.Point(5, 78)
        Me.chkFFBank.Name = "chkFFBank"
        Me.chkFFBank.Size = New System.Drawing.Size(101, 17)
        Me.chkFFBank.TabIndex = 25
        Me.chkFFBank.Text = "Final Filter Bank"
        Me.chkFFBank.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Airflow"
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(6, 6)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(56, 20)
        Me.txtAirflow.TabIndex = 27
        '
        'chkIFBank
        '
        Me.chkIFBank.AutoSize = True
        Me.chkIFBank.Location = New System.Drawing.Point(6, 32)
        Me.chkIFBank.Name = "chkIFBank"
        Me.chkIFBank.Size = New System.Drawing.Size(103, 17)
        Me.chkIFBank.TabIndex = 23
        Me.chkIFBank.Text = "Initial Filter Bank"
        Me.chkIFBank.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(574, 271)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 22
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkDownExtModule)
        Me.tpgOptions.Controls.Add(Me.chkSideExtModule)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(631, 300)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkDownExtModule
        '
        Me.chkDownExtModule.AutoSize = True
        Me.chkDownExtModule.Location = New System.Drawing.Point(6, 29)
        Me.chkDownExtModule.Name = "chkDownExtModule"
        Me.chkDownExtModule.Size = New System.Drawing.Size(177, 17)
        Me.chkDownExtModule.TabIndex = 25
        Me.chkDownExtModule.Text = "Downflow External Filter Module"
        Me.chkDownExtModule.UseVisualStyleBackColor = True
        '
        'chkSideExtModule
        '
        Me.chkSideExtModule.AutoSize = True
        Me.chkSideExtModule.Location = New System.Drawing.Point(6, 6)
        Me.chkSideExtModule.Name = "chkSideExtModule"
        Me.chkSideExtModule.Size = New System.Drawing.Size(202, 17)
        Me.chkSideExtModule.TabIndex = 24
        Me.chkSideExtModule.Text = "Side Discharge External Filter Module"
        Me.chkSideExtModule.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(574, 271)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 23
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.grpCtrlFinal)
        Me.tpgControls.Controls.Add(Me.grpCtrlFactory)
        Me.tpgControls.Controls.Add(Me.grpCtrlInitital)
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(631, 300)
        Me.tpgControls.TabIndex = 4
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpCtrlFinal
        '
        Me.grpCtrlFinal.Controls.Add(Me.chkFFMinihelic)
        Me.grpCtrlFinal.Controls.Add(Me.cmbFFMagRange)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFMagnehelic)
        Me.grpCtrlFinal.Location = New System.Drawing.Point(419, 16)
        Me.grpCtrlFinal.Name = "grpCtrlFinal"
        Me.grpCtrlFinal.Size = New System.Drawing.Size(200, 150)
        Me.grpCtrlFinal.TabIndex = 34
        Me.grpCtrlFinal.TabStop = False
        Me.grpCtrlFinal.Text = "Final Filters"
        '
        'chkFFMinihelic
        '
        Me.chkFFMinihelic.AutoSize = True
        Me.chkFFMinihelic.Enabled = False
        Me.chkFFMinihelic.Location = New System.Drawing.Point(114, 41)
        Me.chkFFMinihelic.Name = "chkFFMinihelic"
        Me.chkFFMinihelic.Size = New System.Drawing.Size(67, 17)
        Me.chkFFMinihelic.TabIndex = 33
        Me.chkFFMinihelic.Text = "Minihelic"
        Me.chkFFMinihelic.UseVisualStyleBackColor = True
        '
        'cmbFFMagRange
        '
        Me.cmbFFMagRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFFMagRange.Enabled = False
        Me.cmbFFMagRange.FormattingEnabled = True
        Me.cmbFFMagRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00"})
        Me.cmbFFMagRange.Location = New System.Drawing.Point(27, 39)
        Me.cmbFFMagRange.Name = "cmbFFMagRange"
        Me.cmbFFMagRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbFFMagRange.TabIndex = 32
        '
        'chkFFMagnehelic
        '
        Me.chkFFMagnehelic.AutoSize = True
        Me.chkFFMagnehelic.Location = New System.Drawing.Point(6, 19)
        Me.chkFFMagnehelic.Name = "chkFFMagnehelic"
        Me.chkFFMagnehelic.Size = New System.Drawing.Size(116, 17)
        Me.chkFFMagnehelic.TabIndex = 31
        Me.chkFFMagnehelic.Text = "Magnehelic Gauge"
        Me.chkFFMagnehelic.UseVisualStyleBackColor = True
        '
        'grpCtrlFactory
        '
        Me.grpCtrlFactory.Location = New System.Drawing.Point(213, 16)
        Me.grpCtrlFactory.Name = "grpCtrlFactory"
        Me.grpCtrlFactory.Size = New System.Drawing.Size(200, 150)
        Me.grpCtrlFactory.TabIndex = 33
        Me.grpCtrlFactory.TabStop = False
        Me.grpCtrlFactory.Text = "Factory Filters"
        '
        'grpCtrlInitital
        '
        Me.grpCtrlInitital.Location = New System.Drawing.Point(7, 16)
        Me.grpCtrlInitital.Name = "grpCtrlInitital"
        Me.grpCtrlInitital.Size = New System.Drawing.Size(200, 150)
        Me.grpCtrlInitital.TabIndex = 32
        Me.grpCtrlInitital.TabStop = False
        Me.grpCtrlInitital.Text = "Initial Filters"
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(21, 271)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 31
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(7, 252)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 30
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(574, 271)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 24
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgFilters
        '
        Me.tpgFilters.Controls.Add(Me.btnDoneFilters)
        Me.tpgFilters.Controls.Add(Me.grpFFFilts)
        Me.tpgFilters.Controls.Add(Me.grpJCIFilts)
        Me.tpgFilters.Controls.Add(Me.grpIFFilts)
        Me.tpgFilters.Location = New System.Drawing.Point(4, 22)
        Me.tpgFilters.Name = "tpgFilters"
        Me.tpgFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgFilters.Size = New System.Drawing.Size(631, 300)
        Me.tpgFilters.TabIndex = 2
        Me.tpgFilters.Text = "Filters"
        Me.tpgFilters.UseVisualStyleBackColor = True
        '
        'btnDoneFilters
        '
        Me.btnDoneFilters.Location = New System.Drawing.Point(574, 271)
        Me.btnDoneFilters.Name = "btnDoneFilters"
        Me.btnDoneFilters.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneFilters.TabIndex = 38
        Me.btnDoneFilters.Text = ">"
        Me.btnDoneFilters.UseVisualStyleBackColor = True
        '
        'grpFFFilts
        '
        Me.grpFFFilts.Controls.Add(Me.cmbActFF)
        Me.grpFFFilts.Controls.Add(Me.cmdSubFF)
        Me.grpFFFilts.Controls.Add(Me.cmdAddFF)
        Me.grpFFFilts.Controls.Add(Me.lstFFSelected)
        Me.grpFFFilts.Controls.Add(Me.lstFFAvail)
        Me.grpFFFilts.Enabled = False
        Me.grpFFFilts.Location = New System.Drawing.Point(418, 6)
        Me.grpFFFilts.Name = "grpFFFilts"
        Me.grpFFFilts.Size = New System.Drawing.Size(200, 259)
        Me.grpFFFilts.TabIndex = 37
        Me.grpFFFilts.TabStop = False
        Me.grpFFFilts.Text = "Final Filters"
        '
        'cmbActFF
        '
        Me.cmbActFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActFF.FormattingEnabled = True
        Me.cmbActFF.Location = New System.Drawing.Point(6, 19)
        Me.cmbActFF.Name = "cmbActFF"
        Me.cmbActFF.Size = New System.Drawing.Size(188, 21)
        Me.cmbActFF.TabIndex = 4
        '
        'cmdSubFF
        '
        Me.cmdSubFF.Location = New System.Drawing.Point(110, 158)
        Me.cmdSubFF.Name = "cmdSubFF"
        Me.cmdSubFF.Size = New System.Drawing.Size(29, 22)
        Me.cmdSubFF.TabIndex = 3
        Me.cmdSubFF.Text = "-"
        Me.cmdSubFF.UseVisualStyleBackColor = True
        '
        'cmdAddFF
        '
        Me.cmdAddFF.Location = New System.Drawing.Point(75, 158)
        Me.cmdAddFF.Name = "cmdAddFF"
        Me.cmdAddFF.Size = New System.Drawing.Size(29, 22)
        Me.cmdAddFF.TabIndex = 2
        Me.cmdAddFF.Text = "+"
        Me.cmdAddFF.UseVisualStyleBackColor = True
        '
        'lstFFSelected
        '
        Me.lstFFSelected.FormattingEnabled = True
        Me.lstFFSelected.Location = New System.Drawing.Point(6, 184)
        Me.lstFFSelected.Name = "lstFFSelected"
        Me.lstFFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstFFSelected.TabIndex = 1
        '
        'lstFFAvail
        '
        Me.lstFFAvail.FormattingEnabled = True
        Me.lstFFAvail.Location = New System.Drawing.Point(6, 45)
        Me.lstFFAvail.Name = "lstFFAvail"
        Me.lstFFAvail.Size = New System.Drawing.Size(188, 108)
        Me.lstFFAvail.TabIndex = 0
        '
        'grpJCIFilts
        '
        Me.grpJCIFilts.Enabled = False
        Me.grpJCIFilts.Location = New System.Drawing.Point(212, 6)
        Me.grpJCIFilts.Name = "grpJCIFilts"
        Me.grpJCIFilts.Size = New System.Drawing.Size(200, 259)
        Me.grpJCIFilts.TabIndex = 36
        Me.grpJCIFilts.TabStop = False
        Me.grpJCIFilts.Text = "Factory Filters"
        '
        'grpIFFilts
        '
        Me.grpIFFilts.Enabled = False
        Me.grpIFFilts.Location = New System.Drawing.Point(6, 6)
        Me.grpIFFilts.Name = "grpIFFilts"
        Me.grpIFFilts.Size = New System.Drawing.Size(200, 259)
        Me.grpIFFilts.TabIndex = 35
        Me.grpIFFilts.TabStop = False
        Me.grpIFFilts.Text = "Initial Filters"
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.GroupBox1)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(631, 300)
        Me.tpgPerformance.TabIndex = 5
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStaticBudget)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDFA)
        Me.GroupBox1.Controls.Add(Me.lblMaxAPD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAPD)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblFaceVelocity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblFaceArea)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblFilterQ3)
        Me.GroupBox1.Controls.Add(Me.lblFilterQ2)
        Me.GroupBox1.Controls.Add(Me.lblFilterQ1)
        Me.GroupBox1.Controls.Add(Me.lblFilterSize3)
        Me.GroupBox1.Controls.Add(Me.lblFilterSize2)
        Me.GroupBox1.Controls.Add(Me.lblFilterSize1)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 259)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Final Filters"
        '
        'lblStaticBudget
        '
        Me.lblStaticBudget.AutoSize = True
        Me.lblStaticBudget.Location = New System.Drawing.Point(107, 163)
        Me.lblStaticBudget.Name = "lblStaticBudget"
        Me.lblStaticBudget.Size = New System.Drawing.Size(28, 13)
        Me.lblStaticBudget.TabIndex = 17
        Me.lblStaticBudget.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Static Budget"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DFA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDFA
        '
        Me.txtDFA.Location = New System.Drawing.Point(108, 140)
        Me.txtDFA.Name = "txtDFA"
        Me.txtDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtDFA.TabIndex = 14
        Me.txtDFA.Text = "0.00"
        '
        'lblMaxAPD
        '
        Me.lblMaxAPD.AutoSize = True
        Me.lblMaxAPD.Location = New System.Drawing.Point(107, 124)
        Me.lblMaxAPD.Name = "lblMaxAPD"
        Me.lblMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblMaxAPD.TabIndex = 13
        Me.lblMaxAPD.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Max. Final APD"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAPD
        '
        Me.lblAPD.AutoSize = True
        Me.lblAPD.Location = New System.Drawing.Point(107, 100)
        Me.lblAPD.Name = "lblAPD"
        Me.lblAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblAPD.TabIndex = 11
        Me.lblAPD.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "APD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFaceVelocity
        '
        Me.lblFaceVelocity.AutoSize = True
        Me.lblFaceVelocity.Location = New System.Drawing.Point(107, 87)
        Me.lblFaceVelocity.Name = "lblFaceVelocity"
        Me.lblFaceVelocity.Size = New System.Drawing.Size(22, 13)
        Me.lblFaceVelocity.TabIndex = 9
        Me.lblFaceVelocity.Text = "0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Face Velocity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFaceArea
        '
        Me.lblFaceArea.AutoSize = True
        Me.lblFaceArea.Location = New System.Drawing.Point(107, 74)
        Me.lblFaceArea.Name = "lblFaceArea"
        Me.lblFaceArea.Size = New System.Drawing.Size(22, 13)
        Me.lblFaceArea.TabIndex = 7
        Me.lblFaceArea.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Face Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterQ3
        '
        Me.lblFilterQ3.AutoSize = True
        Me.lblFilterQ3.Location = New System.Drawing.Point(77, 42)
        Me.lblFilterQ3.Name = "lblFilterQ3"
        Me.lblFilterQ3.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterQ3.TabIndex = 5
        Me.lblFilterQ3.Text = "lblFilterSize3"
        '
        'lblFilterQ2
        '
        Me.lblFilterQ2.AutoSize = True
        Me.lblFilterQ2.Location = New System.Drawing.Point(77, 29)
        Me.lblFilterQ2.Name = "lblFilterQ2"
        Me.lblFilterQ2.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterQ2.TabIndex = 4
        Me.lblFilterQ2.Text = "lblFilterSize2"
        '
        'lblFilterQ1
        '
        Me.lblFilterQ1.AutoSize = True
        Me.lblFilterQ1.Location = New System.Drawing.Point(77, 16)
        Me.lblFilterQ1.Name = "lblFilterQ1"
        Me.lblFilterQ1.Size = New System.Drawing.Size(39, 13)
        Me.lblFilterQ1.TabIndex = 3
        Me.lblFilterQ1.Text = "Label6"
        '
        'lblFilterSize3
        '
        Me.lblFilterSize3.AutoSize = True
        Me.lblFilterSize3.Location = New System.Drawing.Point(6, 42)
        Me.lblFilterSize3.Name = "lblFilterSize3"
        Me.lblFilterSize3.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize3.TabIndex = 2
        Me.lblFilterSize3.Text = "lblFilterSize3"
        Me.lblFilterSize3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterSize2
        '
        Me.lblFilterSize2.AutoSize = True
        Me.lblFilterSize2.Location = New System.Drawing.Point(6, 29)
        Me.lblFilterSize2.Name = "lblFilterSize2"
        Me.lblFilterSize2.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize2.TabIndex = 1
        Me.lblFilterSize2.Text = "lblFilterSize2"
        Me.lblFilterSize2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterSize1
        '
        Me.lblFilterSize1.AutoSize = True
        Me.lblFilterSize1.Location = New System.Drawing.Point(6, 16)
        Me.lblFilterSize1.Name = "lblFilterSize1"
        Me.lblFilterSize1.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize1.TabIndex = 0
        Me.lblFilterSize1.Text = "lblFilterSize1"
        Me.lblFilterSize1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(574, 271)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 10
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(631, 300)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(83, 343)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(5, 343)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmFiltration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(646, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filtration"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.grpCtrlFinal.ResumeLayout(False)
        Me.grpCtrlFinal.PerformLayout()
        Me.tpgFilters.ResumeLayout(False)
        Me.grpFFFilts.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgFilters As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chkFFBank As CheckBox
    Friend WithEvents chkIFBank As CheckBox
    Friend WithEvents cmbFFType As ComboBox
    Friend WithEvents cmbIFType As ComboBox
    Friend WithEvents chkFFPrefilt As CheckBox
    Friend WithEvents chkIFPrefilt As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAirflow As TextBox
    Friend WithEvents chkDownExtModule As CheckBox
    Friend WithEvents chkSideExtModule As CheckBox
    Friend WithEvents grpCtrlFinal As GroupBox
    Friend WithEvents grpCtrlFactory As GroupBox
    Friend WithEvents grpCtrlInitital As GroupBox
    Friend WithEvents chkFFMinihelic As CheckBox
    Friend WithEvents cmbFFMagRange As ComboBox
    Friend WithEvents chkFFMagnehelic As CheckBox
    Friend WithEvents chkModJCIFilts As CheckBox
    Friend WithEvents grpFFFilts As GroupBox
    Friend WithEvents cmdSubFF As Button
    Friend WithEvents cmdAddFF As Button
    Friend WithEvents lstFFSelected As ListBox
    Friend WithEvents lstFFAvail As ListBox
    Friend WithEvents grpJCIFilts As GroupBox
    Friend WithEvents grpIFFilts As GroupBox
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDoneFilters As Button
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFilterQ3 As Label
    Friend WithEvents lblFilterQ2 As Label
    Friend WithEvents lblFilterQ1 As Label
    Friend WithEvents lblFilterSize3 As Label
    Friend WithEvents lblFilterSize2 As Label
    Friend WithEvents lblFilterSize1 As Label
    Friend WithEvents lblFaceArea As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFaceVelocity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbActFF As ComboBox
    Friend WithEvents lblAPD As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDFA As TextBox
    Friend WithEvents lblMaxAPD As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStaticBudget As Label
    Friend WithEvents Label8 As Label
End Class
