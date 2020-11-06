<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMHGRH_Conv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMHGRH_Conv))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudCircuitsofRH = New System.Windows.Forms.NumericUpDown()
        Me.txtEATDB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHGRHAFlow = New System.Windows.Forms.TextBox()
        Me.txtHGRHCap = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkFisenRASensor = New System.Windows.Forms.CheckBox()
        Me.chkFisenRAStat = New System.Windows.Forms.CheckBox()
        Me.chkFisenZoneSensor = New System.Windows.Forms.CheckBox()
        Me.chkFisenZoneHum = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkZTempReset = New System.Windows.Forms.CheckBox()
        Me.optRHGBAS = New System.Windows.Forms.RadioButton()
        Me.optRHSATCtrl = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDHGBASEnab = New System.Windows.Forms.RadioButton()
        Me.optDHCompsByJCI = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstControlStyle = New System.Windows.Forms.ListBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDehumCap = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDeltaT = New System.Windows.Forms.TextBox()
        Me.txtLAT = New System.Windows.Forms.TextBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(14, 240)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(92, 240)
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
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(661, 224)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label14)
        Me.tpgConditions.Controls.Add(Me.Label12)
        Me.tpgConditions.Controls.Add(Me.Label13)
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.nudCircuitsofRH)
        Me.tpgConditions.Controls.Add(Me.txtEATDB)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.txtHGRHAFlow)
        Me.tpgConditions.Controls.Add(Me.txtHGRHCap)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(653, 198)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(239, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "CFM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(239, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "MBH"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(239, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "ºF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Circuits of Reheat"
        '
        'nudCircuitsofRH
        '
        Me.nudCircuitsofRH.Location = New System.Drawing.Point(171, 83)
        Me.nudCircuitsofRH.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCircuitsofRH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCircuitsofRH.Name = "nudCircuitsofRH"
        Me.nudCircuitsofRH.Size = New System.Drawing.Size(62, 20)
        Me.nudCircuitsofRH.TabIndex = 30
        Me.nudCircuitsofRH.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtEATDB
        '
        Me.txtEATDB.Location = New System.Drawing.Point(171, 57)
        Me.txtEATDB.Name = "txtEATDB"
        Me.txtEATDB.Size = New System.Drawing.Size(62, 20)
        Me.txtEATDB.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Entering DB Temp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Hot Gas Reheat Airflow"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Hot Gas Reheat Capacity (Max)"
        '
        'txtHGRHAFlow
        '
        Me.txtHGRHAFlow.Location = New System.Drawing.Point(171, 32)
        Me.txtHGRHAFlow.Name = "txtHGRHAFlow"
        Me.txtHGRHAFlow.Size = New System.Drawing.Size(62, 20)
        Me.txtHGRHAFlow.TabIndex = 25
        '
        'txtHGRHCap
        '
        Me.txtHGRHCap.Location = New System.Drawing.Point(171, 6)
        Me.txtHGRHCap.Name = "txtHGRHCap"
        Me.txtHGRHCap.Size = New System.Drawing.Size(62, 20)
        Me.txtHGRHCap.TabIndex = 24
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(606, 168)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkFisenRASensor)
        Me.tpgOptions.Controls.Add(Me.chkFisenRAStat)
        Me.tpgOptions.Controls.Add(Me.chkFisenZoneSensor)
        Me.tpgOptions.Controls.Add(Me.chkFisenZoneHum)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(653, 198)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(7, 174)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 49
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Location = New System.Drawing.Point(433, 25)
        Me.fraAuxPanel.Name = "fraAuxPanel"
        Me.fraAuxPanel.Size = New System.Drawing.Size(214, 93)
        Me.fraAuxPanel.TabIndex = 48
        Me.fraAuxPanel.TabStop = False
        Me.fraAuxPanel.Text = "Auxiliary Control Panel"
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
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(20, 117)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 32
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(6, 98)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 31
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkFisenRASensor
        '
        Me.chkFisenRASensor.AutoSize = True
        Me.chkFisenRASensor.Location = New System.Drawing.Point(6, 75)
        Me.chkFisenRASensor.Name = "chkFisenRASensor"
        Me.chkFisenRASensor.Size = New System.Drawing.Size(259, 17)
        Me.chkFisenRASensor.TabIndex = 28
        Me.chkFisenRASensor.Text = "Fisen Supplied Field Installed RA Humidity Sensor"
        Me.chkFisenRASensor.UseVisualStyleBackColor = True
        '
        'chkFisenRAStat
        '
        Me.chkFisenRAStat.AutoSize = True
        Me.chkFisenRAStat.Location = New System.Drawing.Point(6, 29)
        Me.chkFisenRAStat.Name = "chkFisenRAStat"
        Me.chkFisenRAStat.Size = New System.Drawing.Size(232, 17)
        Me.chkFisenRAStat.TabIndex = 27
        Me.chkFisenRAStat.Text = "Fisen Supplied Field Installed RA Humidistat"
        Me.chkFisenRAStat.UseVisualStyleBackColor = True
        '
        'chkFisenZoneSensor
        '
        Me.chkFisenZoneSensor.AutoSize = True
        Me.chkFisenZoneSensor.Location = New System.Drawing.Point(6, 52)
        Me.chkFisenZoneSensor.Name = "chkFisenZoneSensor"
        Me.chkFisenZoneSensor.Size = New System.Drawing.Size(202, 17)
        Me.chkFisenZoneSensor.TabIndex = 26
        Me.chkFisenZoneSensor.Text = "Fisen Supplied Zone Humidity Sensor"
        Me.chkFisenZoneSensor.UseVisualStyleBackColor = True
        '
        'chkFisenZoneHum
        '
        Me.chkFisenZoneHum.AutoSize = True
        Me.chkFisenZoneHum.Location = New System.Drawing.Point(6, 6)
        Me.chkFisenZoneHum.Name = "chkFisenZoneHum"
        Me.chkFisenZoneHum.Size = New System.Drawing.Size(175, 17)
        Me.chkFisenZoneHum.TabIndex = 25
        Me.chkFisenZoneHum.Text = "Fisen Supplied Zone Humidistat"
        Me.chkFisenZoneHum.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(606, 168)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.Label1)
        Me.tpgControls.Controls.Add(Me.lstControlStyle)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(653, 198)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkZTempReset)
        Me.GroupBox2.Controls.Add(Me.optRHGBAS)
        Me.GroupBox2.Controls.Add(Me.optRHSATCtrl)
        Me.GroupBox2.Location = New System.Drawing.Point(157, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 93)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reheat Strategy"
        '
        'chkZTempReset
        '
        Me.chkZTempReset.AutoSize = True
        Me.chkZTempReset.Location = New System.Drawing.Point(26, 42)
        Me.chkZTempReset.Name = "chkZTempReset"
        Me.chkZTempReset.Size = New System.Drawing.Size(118, 17)
        Me.chkZTempReset.TabIndex = 2
        Me.chkZTempReset.Text = "Space Temp Reset"
        Me.chkZTempReset.UseVisualStyleBackColor = True
        '
        'optRHGBAS
        '
        Me.optRHGBAS.AutoSize = True
        Me.optRHGBAS.Location = New System.Drawing.Point(6, 65)
        Me.optRHGBAS.Name = "optRHGBAS"
        Me.optRHGBAS.Size = New System.Drawing.Size(90, 17)
        Me.optRHGBAS.TabIndex = 1
        Me.optRHGBAS.Text = "GBAS Control"
        Me.optRHGBAS.UseVisualStyleBackColor = True
        '
        'optRHSATCtrl
        '
        Me.optRHSATCtrl.AutoSize = True
        Me.optRHSATCtrl.Checked = True
        Me.optRHSATCtrl.Location = New System.Drawing.Point(6, 19)
        Me.optRHSATCtrl.Name = "optRHSATCtrl"
        Me.optRHSATCtrl.Size = New System.Drawing.Size(138, 17)
        Me.optRHSATCtrl.TabIndex = 0
        Me.optRHSATCtrl.TabStop = True
        Me.optRHSATCtrl.Text = "Supply Air Temp Control"
        Me.optRHSATCtrl.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDHGBASEnab)
        Me.GroupBox1.Controls.Add(Me.optDHCompsByJCI)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 70)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dehum Strategy"
        '
        'optDHGBASEnab
        '
        Me.optDHGBASEnab.AutoSize = True
        Me.optDHGBASEnab.Location = New System.Drawing.Point(6, 42)
        Me.optDHGBASEnab.Name = "optDHGBASEnab"
        Me.optDHGBASEnab.Size = New System.Drawing.Size(90, 17)
        Me.optDHGBASEnab.TabIndex = 1
        Me.optDHGBASEnab.Text = "GBAS Enable"
        Me.optDHGBASEnab.UseVisualStyleBackColor = True
        '
        'optDHCompsByJCI
        '
        Me.optDHCompsByJCI.AutoSize = True
        Me.optDHCompsByJCI.Checked = True
        Me.optDHCompsByJCI.Location = New System.Drawing.Point(6, 19)
        Me.optDHCompsByJCI.Name = "optDHCompsByJCI"
        Me.optDHCompsByJCI.Size = New System.Drawing.Size(116, 17)
        Me.optDHCompsByJCI.TabIndex = 0
        Me.optDHCompsByJCI.TabStop = True
        Me.optDHCompsByJCI.Text = "SE Controls Enable"
        Me.optDHCompsByJCI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Control Style"
        '
        'lstControlStyle
        '
        Me.lstControlStyle.FormattingEnabled = True
        Me.lstControlStyle.Items.AddRange(New Object() {"Modulating(Conversion)"})
        Me.lstControlStyle.Location = New System.Drawing.Point(27, 24)
        Me.lstControlStyle.Name = "lstControlStyle"
        Me.lstControlStyle.Size = New System.Drawing.Size(124, 17)
        Me.lstControlStyle.TabIndex = 26
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(606, 168)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.txtDehumCap)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.Label7)
        Me.tpgPerformance.Controls.Add(Me.Label8)
        Me.tpgPerformance.Controls.Add(Me.txtDeltaT)
        Me.tpgPerformance.Controls.Add(Me.txtLAT)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(653, 198)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "ºF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "ºF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "lb/hr"
        '
        'txtDehumCap
        '
        Me.txtDehumCap.Location = New System.Drawing.Point(108, 59)
        Me.txtDehumCap.Name = "txtDehumCap"
        Me.txtDehumCap.Size = New System.Drawing.Size(62, 20)
        Me.txtDehumCap.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Dehum Capacity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Delta T"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Leaving DB Temp"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(108, 34)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(62, 20)
        Me.txtDeltaT.TabIndex = 31
        '
        'txtLAT
        '
        Me.txtLAT.Location = New System.Drawing.Point(108, 8)
        Me.txtLAT.Name = "txtLAT"
        Me.txtLAT.Size = New System.Drawing.Size(62, 20)
        Me.txtLAT.TabIndex = 30
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(606, 168)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(653, 198)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(594, 240)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 16
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(630, 240)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 15
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(170, 252)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 20
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Enabled = False
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(522, 240)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 73
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Enabled = False
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(558, 240)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 72
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'frmMHGRH_Conv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmMHGRH_Conv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modulating Hot Gas Reheat Conversion"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        CType(Me.nudCircuitsofRH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents lstControlStyle As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudCircuitsofRH As NumericUpDown
    Friend WithEvents txtEATDB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHGRHAFlow As TextBox
    Friend WithEvents txtHGRHCap As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDehumCap As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDeltaT As TextBox
    Friend WithEvents txtLAT As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkZTempReset As CheckBox
    Friend WithEvents optRHGBAS As RadioButton
    Friend WithEvents optRHSATCtrl As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optDHGBASEnab As RadioButton
    Friend WithEvents optDHCompsByJCI As RadioButton
    Friend WithEvents chkFisenRASensor As CheckBox
    Friend WithEvents chkFisenRAStat As CheckBox
    Friend WithEvents chkFisenZoneSensor As CheckBox
    Friend WithEvents chkFisenZoneHum As CheckBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
End Class
