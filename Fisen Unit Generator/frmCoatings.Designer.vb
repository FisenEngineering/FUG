<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoatings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoatings))
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdLoadMod = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.nudMicroGuardIntCoats = New System.Windows.Forms.NumericUpDown()
        Me.nudMicroGuardExtCoats = New System.Windows.Forms.NumericUpDown()
        Me.nudRustGripIntCoats = New System.Windows.Forms.NumericUpDown()
        Me.nudRustGripExtCoats = New System.Windows.Forms.NumericUpDown()
        Me.chkMicroGuardInt = New System.Windows.Forms.CheckBox()
        Me.chkMicroGuardExt = New System.Windows.Forms.CheckBox()
        Me.chkRustGripInt = New System.Windows.Forms.CheckBox()
        Me.chkRustGripExt = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.fraAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        CType(Me.nudMicroGuardIntCoats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMicroGuardExtCoats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRustGripIntCoats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRustGripExtCoats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOptions.SuspendLayout()
        Me.fraAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdScience
        '
        Me.cmdScience.Enabled = False
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(313, 293)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 92
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Enabled = False
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(349, 293)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 91
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdLoadMod
        '
        Me.cmdLoadMod.Enabled = False
        Me.cmdLoadMod.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.LoadFileIconSmall
        Me.cmdLoadMod.Location = New System.Drawing.Point(277, 293)
        Me.cmdLoadMod.Name = "cmdLoadMod"
        Me.cmdLoadMod.Size = New System.Drawing.Size(30, 29)
        Me.cmdLoadMod.TabIndex = 90
        Me.cmdLoadMod.Text = "L"
        Me.cmdLoadMod.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Enabled = False
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(385, 293)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 89
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Enabled = False
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(421, 293)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 88
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 305)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 87
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 275)
        Me.TabControl1.TabIndex = 86
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.nudMicroGuardIntCoats)
        Me.tpgConditions.Controls.Add(Me.nudMicroGuardExtCoats)
        Me.tpgConditions.Controls.Add(Me.nudRustGripIntCoats)
        Me.tpgConditions.Controls.Add(Me.nudRustGripExtCoats)
        Me.tpgConditions.Controls.Add(Me.chkMicroGuardInt)
        Me.tpgConditions.Controls.Add(Me.chkMicroGuardExt)
        Me.tpgConditions.Controls.Add(Me.chkRustGripInt)
        Me.tpgConditions.Controls.Add(Me.chkRustGripExt)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(441, 249)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'nudMicroGuardIntCoats
        '
        Me.nudMicroGuardIntCoats.Enabled = False
        Me.nudMicroGuardIntCoats.Location = New System.Drawing.Point(221, 74)
        Me.nudMicroGuardIntCoats.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudMicroGuardIntCoats.Name = "nudMicroGuardIntCoats"
        Me.nudMicroGuardIntCoats.Size = New System.Drawing.Size(36, 20)
        Me.nudMicroGuardIntCoats.TabIndex = 30
        '
        'nudMicroGuardExtCoats
        '
        Me.nudMicroGuardExtCoats.Enabled = False
        Me.nudMicroGuardExtCoats.Location = New System.Drawing.Point(221, 51)
        Me.nudMicroGuardExtCoats.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudMicroGuardExtCoats.Name = "nudMicroGuardExtCoats"
        Me.nudMicroGuardExtCoats.Size = New System.Drawing.Size(36, 20)
        Me.nudMicroGuardExtCoats.TabIndex = 29
        '
        'nudRustGripIntCoats
        '
        Me.nudRustGripIntCoats.Enabled = False
        Me.nudRustGripIntCoats.Location = New System.Drawing.Point(221, 28)
        Me.nudRustGripIntCoats.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudRustGripIntCoats.Name = "nudRustGripIntCoats"
        Me.nudRustGripIntCoats.Size = New System.Drawing.Size(36, 20)
        Me.nudRustGripIntCoats.TabIndex = 28
        '
        'nudRustGripExtCoats
        '
        Me.nudRustGripExtCoats.Enabled = False
        Me.nudRustGripExtCoats.Location = New System.Drawing.Point(221, 5)
        Me.nudRustGripExtCoats.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudRustGripExtCoats.Name = "nudRustGripExtCoats"
        Me.nudRustGripExtCoats.Size = New System.Drawing.Size(36, 20)
        Me.nudRustGripExtCoats.TabIndex = 27
        '
        'chkMicroGuardInt
        '
        Me.chkMicroGuardInt.AutoSize = True
        Me.chkMicroGuardInt.Location = New System.Drawing.Point(6, 75)
        Me.chkMicroGuardInt.Name = "chkMicroGuardInt"
        Me.chkMicroGuardInt.Size = New System.Drawing.Size(209, 17)
        Me.chkMicroGuardInt.TabIndex = 26
        Me.chkMicroGuardInt.Text = "MicroGuard Coating on Cabinet Interior"
        Me.chkMicroGuardInt.UseVisualStyleBackColor = True
        '
        'chkMicroGuardExt
        '
        Me.chkMicroGuardExt.AutoSize = True
        Me.chkMicroGuardExt.Location = New System.Drawing.Point(6, 52)
        Me.chkMicroGuardExt.Name = "chkMicroGuardExt"
        Me.chkMicroGuardExt.Size = New System.Drawing.Size(212, 17)
        Me.chkMicroGuardExt.TabIndex = 25
        Me.chkMicroGuardExt.Text = "MicroGuard Coating on Cabinet Exterior"
        Me.chkMicroGuardExt.UseVisualStyleBackColor = True
        '
        'chkRustGripInt
        '
        Me.chkRustGripInt.AutoSize = True
        Me.chkRustGripInt.Location = New System.Drawing.Point(6, 29)
        Me.chkRustGripInt.Name = "chkRustGripInt"
        Me.chkRustGripInt.Size = New System.Drawing.Size(198, 17)
        Me.chkRustGripInt.TabIndex = 24
        Me.chkRustGripInt.Text = "Rust Grip Coating on Cabinet Interior"
        Me.chkRustGripInt.UseVisualStyleBackColor = True
        '
        'chkRustGripExt
        '
        Me.chkRustGripExt.AutoSize = True
        Me.chkRustGripExt.Location = New System.Drawing.Point(6, 6)
        Me.chkRustGripExt.Name = "chkRustGripExt"
        Me.chkRustGripExt.Size = New System.Drawing.Size(201, 17)
        Me.chkRustGripExt.TabIndex = 23
        Me.chkRustGripExt.Text = "Rust Grip Coating on Cabinet Exterior"
        Me.chkRustGripExt.UseVisualStyleBackColor = True
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
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.fraAuxPanel)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(441, 249)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(7, 224)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 47
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'fraAuxPanel
        '
        Me.fraAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.fraAuxPanel.Controls.Add(Me.optUseAux)
        Me.fraAuxPanel.Controls.Add(Me.optNoAux)
        Me.fraAuxPanel.Location = New System.Drawing.Point(3, 6)
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
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(394, 220)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 23
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
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
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(6, 204)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 30
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(23, 227)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 31
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
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
        Me.tpgPerformance.Controls.Add(Me.Label1)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPerformance.Size = New System.Drawing.Size(441, 249)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
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
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 293)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 85
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 293)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 84
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "There are no performance alterations for this modification."
        '
        'frmCoatings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.cmdLoadMod)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCoatings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Protective Coatings"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        CType(Me.nudMicroGuardIntCoats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMicroGuardExtCoats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRustGripIntCoats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRustGripExtCoats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.fraAuxPanel.ResumeLayout(False)
        Me.fraAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents cmdLoadMod As Button
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents fraAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents nudMicroGuardIntCoats As NumericUpDown
    Friend WithEvents nudMicroGuardExtCoats As NumericUpDown
    Friend WithEvents nudRustGripIntCoats As NumericUpDown
    Friend WithEvents nudRustGripExtCoats As NumericUpDown
    Friend WithEvents chkMicroGuardInt As CheckBox
    Friend WithEvents chkMicroGuardExt As CheckBox
    Friend WithEvents chkRustGripInt As CheckBox
    Friend WithEvents chkRustGripExt As CheckBox
    Friend WithEvents Label1 As Label
End Class
