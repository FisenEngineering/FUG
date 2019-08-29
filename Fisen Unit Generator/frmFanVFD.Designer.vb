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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
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
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkBACnet = New System.Windows.Forms.CheckBox()
        Me.chkSpecificVFD = New System.Windows.Forms.CheckBox()
        Me.chkRemotePad = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
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
        Me.chk65kInstall = New System.Windows.Forms.CheckBox()
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
        Me.tpgConditions.Controls.Add(Me.CheckBox7)
        Me.tpgConditions.Controls.Add(Me.CheckBox8)
        Me.tpgConditions.Controls.Add(Me.CheckBox9)
        Me.tpgConditions.Controls.Add(Me.CheckBox4)
        Me.tpgConditions.Controls.Add(Me.CheckBox5)
        Me.tpgConditions.Controls.Add(Me.CheckBox6)
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
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(210, 50)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox7.TabIndex = 32
        Me.CheckBox7.Text = "with Disconnect"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Enabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(210, 28)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox8.TabIndex = 31
        Me.CheckBox8.Text = "with Bypass Safety Switch"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Enabled = False
        Me.CheckBox9.Location = New System.Drawing.Point(192, 6)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox9.TabIndex = 30
        Me.CheckBox9.Text = "Exhaust Fan VFD"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(23, 128)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox4.TabIndex = 29
        Me.CheckBox4.Text = "with Disconnect"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(23, 106)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox5.TabIndex = 28
        Me.CheckBox5.Text = "with Bypass Safety Switch"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(5, 84)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox6.TabIndex = 27
        Me.CheckBox6.Text = "Return Fan VFD"
        Me.CheckBox6.UseVisualStyleBackColor = True
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
        '
        'chkSFanVFD
        '
        Me.chkSFanVFD.AutoSize = True
        Me.chkSFanVFD.Checked = True
        Me.chkSFanVFD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSFanVFD.Location = New System.Drawing.Point(5, 6)
        Me.chkSFanVFD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSFanVFD.Name = "chkSFanVFD"
        Me.chkSFanVFD.Size = New System.Drawing.Size(103, 17)
        Me.chkSFanVFD.TabIndex = 24
        Me.chkSFanVFD.Text = "Supply Fan VFD"
        Me.chkSFanVFD.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 120)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kInstall)
        Me.tpgOptions.Controls.Add(Me.cmbVFDBrand)
        Me.tpgOptions.Controls.Add(Me.chkNEMA4xDrive)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
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
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(226, 143)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 30
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(212, 124)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 29
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
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
        Me.btnDoneOptions.Location = New System.Drawing.Point(385, 120)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
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
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 120)
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
        Me.btnDonePerformance.Location = New System.Drawing.Point(385, 120)
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
        'chk65kInstall
        '
        Me.chk65kInstall.AutoSize = True
        Me.chk65kInstall.Location = New System.Drawing.Point(5, 120)
        Me.chk65kInstall.Margin = New System.Windows.Forms.Padding(2)
        Me.chk65kInstall.Name = "chk65kInstall"
        Me.chk65kInstall.Size = New System.Drawing.Size(107, 17)
        Me.chk65kInstall.TabIndex = 33
        Me.chk65kInstall.Text = "65kIA Installation"
        Me.chk65kInstall.UseVisualStyleBackColor = True
        '
        'frmFanVFD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
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
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
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
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chkNEMA4xDrive As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents cmbVFDBrand As ComboBox
    Friend WithEvents chk65kInstall As CheckBox
End Class
