<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFanVFD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFanVFD))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.chkXFanDisconnect = New System.Windows.Forms.CheckBox()
        Me.chkXFanBypass = New System.Windows.Forms.CheckBox()
        Me.chkXFanVFD = New System.Windows.Forms.CheckBox()
        Me.chkRFanDisconnect = New System.Windows.Forms.CheckBox()
        Me.chkRFanBypass = New System.Windows.Forms.CheckBox()
        Me.chkRFanVFD = New System.Windows.Forms.CheckBox()
        Me.chkSFanDisconnect = New System.Windows.Forms.CheckBox()
        Me.chkSFanBypass = New System.Windows.Forms.CheckBox()
        Me.chkSFanVFD = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.cmbVFDBrand = New System.Windows.Forms.ComboBox()
        Me.chkNEMA4xDrive = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkBACnet = New System.Windows.Forms.CheckBox()
        Me.chkSpecificVFD = New System.Windows.Forms.CheckBox()
        Me.chkRemotePad = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSFanBalanceOnly = New System.Windows.Forms.RadioButton()
        Me.optSFanFisenLCVAV = New System.Windows.Forms.RadioButton()
        Me.optSFanSELCVAV = New System.Windows.Forms.RadioButton()
        Me.optSFanSEVFDReady = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(440, 188)
        Me.TabControl1.TabIndex = 3
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkXFanDisconnect)
        Me.tpgConditions.Controls.Add(Me.chkXFanBypass)
        Me.tpgConditions.Controls.Add(Me.chkXFanVFD)
        Me.tpgConditions.Controls.Add(Me.chkRFanDisconnect)
        Me.tpgConditions.Controls.Add(Me.chkRFanBypass)
        Me.tpgConditions.Controls.Add(Me.chkRFanVFD)
        Me.tpgConditions.Controls.Add(Me.chkSFanDisconnect)
        Me.tpgConditions.Controls.Add(Me.chkSFanBypass)
        Me.tpgConditions.Controls.Add(Me.chkSFanVFD)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 162)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chkXFanDisconnect
        '
        Me.chkXFanDisconnect.AutoSize = True
        Me.chkXFanDisconnect.Location = New System.Drawing.Point(210, 50)
        Me.chkXFanDisconnect.Margin = New System.Windows.Forms.Padding(2)
        Me.chkXFanDisconnect.Name = "chkXFanDisconnect"
        Me.chkXFanDisconnect.Size = New System.Drawing.Size(102, 17)
        Me.chkXFanDisconnect.TabIndex = 32
        Me.chkXFanDisconnect.Text = "with Disconnect"
        Me.chkXFanDisconnect.UseVisualStyleBackColor = True
        Me.chkXFanDisconnect.Visible = False
        '
        'chkXFanBypass
        '
        Me.chkXFanBypass.AutoSize = True
        Me.chkXFanBypass.Location = New System.Drawing.Point(210, 28)
        Me.chkXFanBypass.Margin = New System.Windows.Forms.Padding(2)
        Me.chkXFanBypass.Name = "chkXFanBypass"
        Me.chkXFanBypass.Size = New System.Drawing.Size(150, 17)
        Me.chkXFanBypass.TabIndex = 31
        Me.chkXFanBypass.Text = "with Bypass Safety Switch"
        Me.chkXFanBypass.UseVisualStyleBackColor = True
        Me.chkXFanBypass.Visible = False
        '
        'chkXFanVFD
        '
        Me.chkXFanVFD.AutoSize = True
        Me.chkXFanVFD.Location = New System.Drawing.Point(192, 6)
        Me.chkXFanVFD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkXFanVFD.Name = "chkXFanVFD"
        Me.chkXFanVFD.Size = New System.Drawing.Size(109, 17)
        Me.chkXFanVFD.TabIndex = 30
        Me.chkXFanVFD.Text = "Exhaust Fan VFD"
        Me.chkXFanVFD.UseVisualStyleBackColor = True
        Me.chkXFanVFD.Visible = False
        '
        'chkRFanDisconnect
        '
        Me.chkRFanDisconnect.AutoSize = True
        Me.chkRFanDisconnect.Location = New System.Drawing.Point(23, 128)
        Me.chkRFanDisconnect.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRFanDisconnect.Name = "chkRFanDisconnect"
        Me.chkRFanDisconnect.Size = New System.Drawing.Size(102, 17)
        Me.chkRFanDisconnect.TabIndex = 29
        Me.chkRFanDisconnect.Text = "with Disconnect"
        Me.chkRFanDisconnect.UseVisualStyleBackColor = True
        Me.chkRFanDisconnect.Visible = False
        '
        'chkRFanBypass
        '
        Me.chkRFanBypass.AutoSize = True
        Me.chkRFanBypass.Location = New System.Drawing.Point(23, 106)
        Me.chkRFanBypass.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRFanBypass.Name = "chkRFanBypass"
        Me.chkRFanBypass.Size = New System.Drawing.Size(150, 17)
        Me.chkRFanBypass.TabIndex = 28
        Me.chkRFanBypass.Text = "with Bypass Safety Switch"
        Me.chkRFanBypass.UseVisualStyleBackColor = True
        Me.chkRFanBypass.Visible = False
        '
        'chkRFanVFD
        '
        Me.chkRFanVFD.AutoSize = True
        Me.chkRFanVFD.Location = New System.Drawing.Point(5, 84)
        Me.chkRFanVFD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRFanVFD.Name = "chkRFanVFD"
        Me.chkRFanVFD.Size = New System.Drawing.Size(103, 17)
        Me.chkRFanVFD.TabIndex = 27
        Me.chkRFanVFD.Text = "Return Fan VFD"
        Me.chkRFanVFD.UseVisualStyleBackColor = True
        Me.chkRFanVFD.Visible = False
        '
        'chkSFanDisconnect
        '
        Me.chkSFanDisconnect.AutoSize = True
        Me.chkSFanDisconnect.Location = New System.Drawing.Point(23, 50)
        Me.chkSFanDisconnect.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSFanDisconnect.Name = "chkSFanDisconnect"
        Me.chkSFanDisconnect.Size = New System.Drawing.Size(102, 17)
        Me.chkSFanDisconnect.TabIndex = 26
        Me.chkSFanDisconnect.Text = "with Disconnect"
        Me.chkSFanDisconnect.UseVisualStyleBackColor = True
        Me.chkSFanDisconnect.Visible = False
        '
        'chkSFanBypass
        '
        Me.chkSFanBypass.AutoSize = True
        Me.chkSFanBypass.Location = New System.Drawing.Point(23, 28)
        Me.chkSFanBypass.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSFanBypass.Name = "chkSFanBypass"
        Me.chkSFanBypass.Size = New System.Drawing.Size(150, 17)
        Me.chkSFanBypass.TabIndex = 25
        Me.chkSFanBypass.Text = "with Bypass Safety Switch"
        Me.chkSFanBypass.UseVisualStyleBackColor = True
        Me.chkSFanBypass.Visible = False
        '
        'chkSFanVFD
        '
        Me.chkSFanVFD.AutoSize = True
        Me.chkSFanVFD.Location = New System.Drawing.Point(5, 6)
        Me.chkSFanVFD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSFanVFD.Name = "chkSFanVFD"
        Me.chkSFanVFD.Size = New System.Drawing.Size(103, 17)
        Me.chkSFanVFD.TabIndex = 24
        Me.chkSFanVFD.Text = "Supply Fan VFD"
        Me.chkSFanVFD.UseVisualStyleBackColor = True
        Me.chkSFanVFD.Visible = False
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 133)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.cmbVFDBrand)
        Me.tpgOptions.Controls.Add(Me.chkNEMA4xDrive)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.chkBACnet)
        Me.tpgOptions.Controls.Add(Me.chkSpecificVFD)
        Me.tpgOptions.Controls.Add(Me.chkRemotePad)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(432, 162)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'cmbVFDBrand
        '
        Me.cmbVFDBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVFDBrand.Enabled = False
        Me.cmbVFDBrand.FormattingEnabled = True
        Me.cmbVFDBrand.Items.AddRange(New Object() {"ABB Eclipse", "Danfoss VLT HVAC - FC102", "Danfoss VLT HVAC Basic - FC101", "Fisen Standard", "Rockwell Automation Power Flex 753", ""})
        Me.cmbVFDBrand.Location = New System.Drawing.Point(24, 55)
        Me.cmbVFDBrand.Name = "cmbVFDBrand"
        Me.cmbVFDBrand.Size = New System.Drawing.Size(152, 21)
        Me.cmbVFDBrand.TabIndex = 6
        '
        'chkNEMA4xDrive
        '
        Me.chkNEMA4xDrive.AutoSize = True
        Me.chkNEMA4xDrive.Location = New System.Drawing.Point(5, 102)
        Me.chkNEMA4xDrive.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNEMA4xDrive.Name = "chkNEMA4xDrive"
        Me.chkNEMA4xDrive.Size = New System.Drawing.Size(99, 17)
        Me.chkNEMA4xDrive.TabIndex = 32
        Me.chkNEMA4xDrive.Text = "NEMA 4x Drive"
        Me.chkNEMA4xDrive.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbAuxPanelOpts)
        Me.GroupBox3.Controls.Add(Me.optUseAux)
        Me.GroupBox3.Controls.Add(Me.optNoAux)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 105)
        Me.GroupBox3.TabIndex = 31
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
        'chkBACnet
        '
        Me.chkBACnet.AutoSize = True
        Me.chkBACnet.Location = New System.Drawing.Point(5, 81)
        Me.chkBACnet.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBACnet.Name = "chkBACnet"
        Me.chkBACnet.Size = New System.Drawing.Size(212, 17)
        Me.chkBACnet.TabIndex = 28
        Me.chkBACnet.Text = "BACnet Communications Interface Card"
        Me.chkBACnet.UseVisualStyleBackColor = True
        '
        'chkSpecificVFD
        '
        Me.chkSpecificVFD.AutoSize = True
        Me.chkSpecificVFD.Location = New System.Drawing.Point(5, 37)
        Me.chkSpecificVFD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSpecificVFD.Name = "chkSpecificVFD"
        Me.chkSpecificVFD.Size = New System.Drawing.Size(119, 17)
        Me.chkSpecificVFD.TabIndex = 26
        Me.chkSpecificVFD.Text = "Specific Brand VFD"
        Me.chkSpecificVFD.UseVisualStyleBackColor = True
        '
        'chkRemotePad
        '
        Me.chkRemotePad.AutoSize = True
        Me.chkRemotePad.Location = New System.Drawing.Point(5, 15)
        Me.chkRemotePad.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRemotePad.Name = "chkRemotePad"
        Me.chkRemotePad.Size = New System.Drawing.Size(154, 17)
        Me.chkRemotePad.TabIndex = 25
        Me.chkRemotePad.Text = "Remote Mount Control Pad"
        Me.chkRemotePad.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(385, 133)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 162)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(214, 137)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 32
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(200, 118)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 31
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSFanBalanceOnly)
        Me.GroupBox1.Controls.Add(Me.optSFanFisenLCVAV)
        Me.GroupBox1.Controls.Add(Me.optSFanSELCVAV)
        Me.GroupBox1.Controls.Add(Me.optSFanSEVFDReady)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(134, 113)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Fan"
        '
        'optSFanBalanceOnly
        '
        Me.optSFanBalanceOnly.AutoSize = True
        Me.optSFanBalanceOnly.Location = New System.Drawing.Point(4, 83)
        Me.optSFanBalanceOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.optSFanBalanceOnly.Name = "optSFanBalanceOnly"
        Me.optSFanBalanceOnly.Size = New System.Drawing.Size(109, 17)
        Me.optSFanBalanceOnly.TabIndex = 30
        Me.optSFanBalanceOnly.Text = "Fan Balance Only"
        Me.optSFanBalanceOnly.UseVisualStyleBackColor = True
        '
        'optSFanFisenLCVAV
        '
        Me.optSFanFisenLCVAV.AutoSize = True
        Me.optSFanFisenLCVAV.Location = New System.Drawing.Point(4, 61)
        Me.optSFanFisenLCVAV.Margin = New System.Windows.Forms.Padding(2)
        Me.optSFanFisenLCVAV.Name = "optSFanFisenLCVAV"
        Me.optSFanFisenLCVAV.Size = New System.Drawing.Size(87, 17)
        Me.optSFanFisenLCVAV.TabIndex = 29
        Me.optSFanFisenLCVAV.Text = "Fisen LCVAV"
        Me.optSFanFisenLCVAV.UseVisualStyleBackColor = True
        '
        'optSFanSELCVAV
        '
        Me.optSFanSELCVAV.AutoSize = True
        Me.optSFanSELCVAV.Location = New System.Drawing.Point(4, 39)
        Me.optSFanSELCVAV.Margin = New System.Windows.Forms.Padding(2)
        Me.optSFanSELCVAV.Name = "optSFanSELCVAV"
        Me.optSFanSELCVAV.Size = New System.Drawing.Size(113, 17)
        Me.optSFanSELCVAV.TabIndex = 28
        Me.optSFanSELCVAV.Text = "SE Board - LCVAV"
        Me.optSFanSELCVAV.UseVisualStyleBackColor = True
        '
        'optSFanSEVFDReady
        '
        Me.optSFanSEVFDReady.AutoSize = True
        Me.optSFanSEVFDReady.Checked = True
        Me.optSFanSEVFDReady.Location = New System.Drawing.Point(4, 17)
        Me.optSFanSEVFDReady.Margin = New System.Windows.Forms.Padding(2)
        Me.optSFanSEVFDReady.Name = "optSFanSEVFDReady"
        Me.optSFanSEVFDReady.Size = New System.Drawing.Size(134, 17)
        Me.optSFanSEVFDReady.TabIndex = 27
        Me.optSFanSEVFDReady.TabStop = True
        Me.optSFanSEVFDReady.Text = "SE Board - VFD Ready"
        Me.optSFanSEVFDReady.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 133)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.chkNoPerformance)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 162)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'chkNoPerformance
        '
        Me.chkNoPerformance.AutoSize = True
        Me.chkNoPerformance.Checked = True
        Me.chkNoPerformance.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoPerformance.Enabled = False
        Me.chkNoPerformance.Location = New System.Drawing.Point(13, 13)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(248, 17)
        Me.chkNoPerformance.TabIndex = 27
        Me.chkNoPerformance.Text = "No Performance to Report for This Modification"
        Me.chkNoPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(385, 133)
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
        Me.DebugPage.Size = New System.Drawing.Size(432, 162)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 204)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 204)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(381, 200)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 14
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(417, 200)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 13
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 216)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 15
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(5, 125)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 34
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'frmFanVFD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmFanVFD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fan Variable Frequency Drive"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
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
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chkXFanDisconnect As CheckBox
    Friend WithEvents chkXFanBypass As CheckBox
    Friend WithEvents chkXFanVFD As CheckBox
    Friend WithEvents chkRFanDisconnect As CheckBox
    Friend WithEvents chkRFanBypass As CheckBox
    Friend WithEvents chkRFanVFD As CheckBox
    Friend WithEvents chkSFanDisconnect As CheckBox
    Friend WithEvents chkSFanBypass As CheckBox
    Friend WithEvents chkSFanVFD As CheckBox
    Friend WithEvents chkSpecificVFD As CheckBox
    Friend WithEvents chkRemotePad As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSFanFisenLCVAV As RadioButton
    Friend WithEvents optSFanSELCVAV As RadioButton
    Friend WithEvents optSFanSEVFDReady As RadioButton
    Friend WithEvents chkBACnet As CheckBox
    Friend WithEvents optSFanBalanceOnly As RadioButton
    Friend WithEvents chkNEMA4xDrive As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents cmbVFDBrand As ComboBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chk65kASCCRBase As CheckBox
End Class
