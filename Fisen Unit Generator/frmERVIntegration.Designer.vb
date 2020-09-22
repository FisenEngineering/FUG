<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmERVIntegration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmERVIntegration))
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.grpIntStyle = New System.Windows.Forms.GroupBox()
        Me.optSplitShip = New System.Windows.Forms.RadioButton()
        Me.optShipAttached = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.grpAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.grpDPPCkt = New System.Windows.Forms.GroupBox()
        Me.optDPPEmergency = New System.Windows.Forms.RadioButton()
        Me.optDPPCommercial = New System.Windows.Forms.RadioButton()
        Me.optDPPNA = New System.Windows.Forms.RadioButton()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.grpFlowStyle = New System.Windows.Forms.GroupBox()
        Me.optPartialFlow = New System.Windows.Forms.RadioButton()
        Me.optFullFlow = New System.Windows.Forms.RadioButton()
        Me.cmbWheelModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpPowerStyle = New System.Windows.Forms.GroupBox()
        Me.optSPP = New System.Windows.Forms.RadioButton()
        Me.optMPP = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.grpIntStyle.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.grpDPPCkt.SuspendLayout()
        Me.grpFlowStyle.SuspendLayout()
        Me.grpPowerStyle.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 252)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 22
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 240)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 19
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 240)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(379, 241)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 21
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(415, 241)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 20
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 226)
        Me.TabControl1.TabIndex = 23
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.grpPowerStyle)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.cmbWheelModel)
        Me.tpgConditions.Controls.Add(Me.grpFlowStyle)
        Me.tpgConditions.Controls.Add(Me.grpIntStyle)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 200)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'grpIntStyle
        '
        Me.grpIntStyle.Controls.Add(Me.optSplitShip)
        Me.grpIntStyle.Controls.Add(Me.optShipAttached)
        Me.grpIntStyle.Location = New System.Drawing.Point(6, 6)
        Me.grpIntStyle.Name = "grpIntStyle"
        Me.grpIntStyle.Size = New System.Drawing.Size(174, 44)
        Me.grpIntStyle.TabIndex = 11
        Me.grpIntStyle.TabStop = False
        Me.grpIntStyle.Text = "Integration Style"
        '
        'optSplitShip
        '
        Me.optSplitShip.AutoSize = True
        Me.optSplitShip.Location = New System.Drawing.Point(102, 18)
        Me.optSplitShip.Margin = New System.Windows.Forms.Padding(2)
        Me.optSplitShip.Name = "optSplitShip"
        Me.optSplitShip.Size = New System.Drawing.Size(69, 17)
        Me.optSplitShip.TabIndex = 13
        Me.optSplitShip.Text = "Split Ship"
        Me.optSplitShip.UseVisualStyleBackColor = True
        '
        'optShipAttached
        '
        Me.optShipAttached.AutoSize = True
        Me.optShipAttached.Checked = True
        Me.optShipAttached.Location = New System.Drawing.Point(6, 18)
        Me.optShipAttached.Margin = New System.Windows.Forms.Padding(2)
        Me.optShipAttached.Name = "optShipAttached"
        Me.optShipAttached.Size = New System.Drawing.Size(92, 17)
        Me.optShipAttached.TabIndex = 12
        Me.optShipAttached.TabStop = True
        Me.optShipAttached.Text = "Ship Attached"
        Me.optShipAttached.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(388, 174)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.grpAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(432, 200)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(5, 179)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 31
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'grpAuxPanel
        '
        Me.grpAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.grpAuxPanel.Controls.Add(Me.optUseAux)
        Me.grpAuxPanel.Controls.Add(Me.optNoAux)
        Me.grpAuxPanel.Location = New System.Drawing.Point(5, 42)
        Me.grpAuxPanel.Name = "grpAuxPanel"
        Me.grpAuxPanel.Size = New System.Drawing.Size(214, 105)
        Me.grpAuxPanel.TabIndex = 29
        Me.grpAuxPanel.TabStop = False
        Me.grpAuxPanel.Text = "Auxilary Control Panel"
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
        Me.optUseAux.Size = New System.Drawing.Size(149, 17)
        Me.optUseAux.TabIndex = 1
        Me.optUseAux.TabStop = True
        Me.optUseAux.Text = "Use Auxilary Control Panel"
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
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(20, 22)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(5, 3)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(388, 174)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 200)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(388, 174)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.grpDPPCkt)
        Me.tpgPerformance.Controls.Add(Me.chkNoPerformance)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 200)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'grpDPPCkt
        '
        Me.grpDPPCkt.Controls.Add(Me.optDPPEmergency)
        Me.grpDPPCkt.Controls.Add(Me.optDPPCommercial)
        Me.grpDPPCkt.Controls.Add(Me.optDPPNA)
        Me.grpDPPCkt.Location = New System.Drawing.Point(307, 6)
        Me.grpDPPCkt.Name = "grpDPPCkt"
        Me.grpDPPCkt.Size = New System.Drawing.Size(119, 100)
        Me.grpDPPCkt.TabIndex = 29
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
        'chkNoPerformance
        '
        Me.chkNoPerformance.AutoSize = True
        Me.chkNoPerformance.Enabled = False
        Me.chkNoPerformance.Location = New System.Drawing.Point(6, 174)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(248, 17)
        Me.chkNoPerformance.TabIndex = 28
        Me.chkNoPerformance.Text = "No Performance to Report for This Modification"
        Me.chkNoPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(388, 174)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerf.TabIndex = 14
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(432, 200)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(343, 240)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 63
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'grpFlowStyle
        '
        Me.grpFlowStyle.Controls.Add(Me.optPartialFlow)
        Me.grpFlowStyle.Controls.Add(Me.optFullFlow)
        Me.grpFlowStyle.Location = New System.Drawing.Point(6, 56)
        Me.grpFlowStyle.Name = "grpFlowStyle"
        Me.grpFlowStyle.Size = New System.Drawing.Size(174, 44)
        Me.grpFlowStyle.TabIndex = 12
        Me.grpFlowStyle.TabStop = False
        Me.grpFlowStyle.Text = "Flow Style"
        '
        'optPartialFlow
        '
        Me.optPartialFlow.AutoSize = True
        Me.optPartialFlow.Location = New System.Drawing.Point(90, 18)
        Me.optPartialFlow.Margin = New System.Windows.Forms.Padding(2)
        Me.optPartialFlow.Name = "optPartialFlow"
        Me.optPartialFlow.Size = New System.Drawing.Size(79, 17)
        Me.optPartialFlow.TabIndex = 13
        Me.optPartialFlow.Text = "Partial Flow"
        Me.optPartialFlow.UseVisualStyleBackColor = True
        '
        'optFullFlow
        '
        Me.optFullFlow.AutoSize = True
        Me.optFullFlow.Checked = True
        Me.optFullFlow.Location = New System.Drawing.Point(6, 18)
        Me.optFullFlow.Margin = New System.Windows.Forms.Padding(2)
        Me.optFullFlow.Name = "optFullFlow"
        Me.optFullFlow.Size = New System.Drawing.Size(66, 17)
        Me.optFullFlow.TabIndex = 12
        Me.optFullFlow.TabStop = True
        Me.optFullFlow.Text = "Full Flow"
        Me.optFullFlow.UseVisualStyleBackColor = True
        '
        'cmbWheelModel
        '
        Me.cmbWheelModel.FormattingEnabled = True
        Me.cmbWheelModel.Items.AddRange(New Object() {"Unselected", "VS28"})
        Me.cmbWheelModel.Location = New System.Drawing.Point(186, 23)
        Me.cmbWheelModel.Name = "cmbWheelModel"
        Me.cmbWheelModel.Size = New System.Drawing.Size(121, 21)
        Me.cmbWheelModel.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wheel Model Number"
        '
        'grpPowerStyle
        '
        Me.grpPowerStyle.Controls.Add(Me.optSPP)
        Me.grpPowerStyle.Controls.Add(Me.optMPP)
        Me.grpPowerStyle.Location = New System.Drawing.Point(6, 106)
        Me.grpPowerStyle.Name = "grpPowerStyle"
        Me.grpPowerStyle.Size = New System.Drawing.Size(174, 44)
        Me.grpPowerStyle.TabIndex = 15
        Me.grpPowerStyle.TabStop = False
        Me.grpPowerStyle.Text = "Power Style"
        '
        'optSPP
        '
        Me.optSPP.AutoSize = True
        Me.optSPP.Location = New System.Drawing.Point(90, 18)
        Me.optSPP.Margin = New System.Windows.Forms.Padding(2)
        Me.optSPP.Name = "optSPP"
        Me.optSPP.Size = New System.Drawing.Size(46, 17)
        Me.optSPP.TabIndex = 13
        Me.optSPP.Text = "SPP"
        Me.optSPP.UseVisualStyleBackColor = True
        '
        'optMPP
        '
        Me.optMPP.AutoSize = True
        Me.optMPP.Checked = True
        Me.optMPP.Location = New System.Drawing.Point(6, 18)
        Me.optMPP.Margin = New System.Windows.Forms.Padding(2)
        Me.optMPP.Name = "optMPP"
        Me.optMPP.Size = New System.Drawing.Size(48, 17)
        Me.optMPP.TabIndex = 12
        Me.optMPP.TabStop = True
        Me.optMPP.Text = "MPP"
        Me.optMPP.UseVisualStyleBackColor = True
        '
        'frmERVIntegration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmERVIntegration"
        Me.Text = "JCI ERV Integration"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.grpIntStyle.ResumeLayout(False)
        Me.grpIntStyle.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpAuxPanel.ResumeLayout(False)
        Me.grpAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.grpDPPCkt.ResumeLayout(False)
        Me.grpDPPCkt.PerformLayout()
        Me.grpFlowStyle.ResumeLayout(False)
        Me.grpFlowStyle.PerformLayout()
        Me.grpPowerStyle.ResumeLayout(False)
        Me.grpPowerStyle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents grpIntStyle As GroupBox
    Friend WithEvents optSplitShip As RadioButton
    Friend WithEvents optShipAttached As RadioButton
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents grpAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents grpDPPCkt As GroupBox
    Friend WithEvents optDPPEmergency As RadioButton
    Friend WithEvents optDPPCommercial As RadioButton
    Friend WithEvents optDPPNA As RadioButton
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbWheelModel As ComboBox
    Friend WithEvents grpFlowStyle As GroupBox
    Friend WithEvents optPartialFlow As RadioButton
    Friend WithEvents optFullFlow As RadioButton
    Friend WithEvents grpPowerStyle As GroupBox
    Friend WithEvents optSPP As RadioButton
    Friend WithEvents optMPP As RadioButton
End Class
