<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHGBP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHGBP))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.cmbRefrigerant = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbHGBPStyle4 = New System.Windows.Forms.ComboBox()
        Me.cmbHGBPStyle3 = New System.Windows.Forms.ComboBox()
        Me.cmbHGBPStyle2 = New System.Windows.Forms.ComboBox()
        Me.cmbHGBPStyle1 = New System.Windows.Forms.ComboBox()
        Me.chkStage4 = New System.Windows.Forms.CheckBox()
        Me.chkStage3 = New System.Windows.Forms.CheckBox()
        Me.chkStage2 = New System.Windows.Forms.CheckBox()
        Me.chkStage1 = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkRemoveJCIHGBP = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optNoIso = New System.Windows.Forms.RadioButton()
        Me.optSolIso = New System.Windows.Forms.RadioButton()
        Me.optManIso = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkDischargeTStat = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 195)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 195)
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
        Me.TabControl1.Size = New System.Drawing.Size(440, 179)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.cmbRefrigerant)
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 153)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'cmbRefrigerant
        '
        Me.cmbRefrigerant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefrigerant.FormattingEnabled = True
        Me.cmbRefrigerant.Items.AddRange(New Object() {"R410A", "R22", "R407C", "R134A"})
        Me.cmbRefrigerant.Location = New System.Drawing.Point(6, 20)
        Me.cmbRefrigerant.Name = "cmbRefrigerant"
        Me.cmbRefrigerant.Size = New System.Drawing.Size(102, 21)
        Me.cmbRefrigerant.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbHGBPStyle4)
        Me.GroupBox1.Controls.Add(Me.cmbHGBPStyle3)
        Me.GroupBox1.Controls.Add(Me.cmbHGBPStyle2)
        Me.GroupBox1.Controls.Add(Me.cmbHGBPStyle1)
        Me.GroupBox1.Controls.Add(Me.chkStage4)
        Me.GroupBox1.Controls.Add(Me.chkStage3)
        Me.GroupBox1.Controls.Add(Me.chkStage2)
        Me.GroupBox1.Controls.Add(Me.chkStage1)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 129)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stages of HGBP"
        '
        'cmbHGBPStyle4
        '
        Me.cmbHGBPStyle4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHGBPStyle4.FormattingEnabled = True
        Me.cmbHGBPStyle4.Items.AddRange(New Object() {"To Suction Line", "To Evaporator Inlet", "By JCI", "Rawal", "None"})
        Me.cmbHGBPStyle4.Location = New System.Drawing.Point(103, 97)
        Me.cmbHGBPStyle4.Name = "cmbHGBPStyle4"
        Me.cmbHGBPStyle4.Size = New System.Drawing.Size(121, 21)
        Me.cmbHGBPStyle4.TabIndex = 28
        '
        'cmbHGBPStyle3
        '
        Me.cmbHGBPStyle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHGBPStyle3.FormattingEnabled = True
        Me.cmbHGBPStyle3.Items.AddRange(New Object() {"To Suction Line", "To Evaporator Inlet", "By JCI", "Rawal", "None"})
        Me.cmbHGBPStyle3.Location = New System.Drawing.Point(103, 70)
        Me.cmbHGBPStyle3.Name = "cmbHGBPStyle3"
        Me.cmbHGBPStyle3.Size = New System.Drawing.Size(121, 21)
        Me.cmbHGBPStyle3.TabIndex = 27
        '
        'cmbHGBPStyle2
        '
        Me.cmbHGBPStyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHGBPStyle2.FormattingEnabled = True
        Me.cmbHGBPStyle2.Items.AddRange(New Object() {"To Suction Line", "To Evaporator Inlet", "By JCI", "Rawal", "None"})
        Me.cmbHGBPStyle2.Location = New System.Drawing.Point(103, 43)
        Me.cmbHGBPStyle2.Name = "cmbHGBPStyle2"
        Me.cmbHGBPStyle2.Size = New System.Drawing.Size(121, 21)
        Me.cmbHGBPStyle2.TabIndex = 26
        '
        'cmbHGBPStyle1
        '
        Me.cmbHGBPStyle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHGBPStyle1.FormattingEnabled = True
        Me.cmbHGBPStyle1.Items.AddRange(New Object() {"To Suction Line", "To Evaporator Inlet", "By JCI", "Rawal"})
        Me.cmbHGBPStyle1.Location = New System.Drawing.Point(103, 16)
        Me.cmbHGBPStyle1.Name = "cmbHGBPStyle1"
        Me.cmbHGBPStyle1.Size = New System.Drawing.Size(121, 21)
        Me.cmbHGBPStyle1.TabIndex = 25
        '
        'chkStage4
        '
        Me.chkStage4.AutoSize = True
        Me.chkStage4.Location = New System.Drawing.Point(12, 99)
        Me.chkStage4.Name = "chkStage4"
        Me.chkStage4.Size = New System.Drawing.Size(73, 17)
        Me.chkStage4.TabIndex = 3
        Me.chkStage4.Text = "4th Circuit"
        Me.chkStage4.UseVisualStyleBackColor = True
        '
        'chkStage3
        '
        Me.chkStage3.AutoSize = True
        Me.chkStage3.Location = New System.Drawing.Point(12, 72)
        Me.chkStage3.Name = "chkStage3"
        Me.chkStage3.Size = New System.Drawing.Size(73, 17)
        Me.chkStage3.TabIndex = 2
        Me.chkStage3.Text = "3rd Circuit"
        Me.chkStage3.UseVisualStyleBackColor = True
        '
        'chkStage2
        '
        Me.chkStage2.AutoSize = True
        Me.chkStage2.Location = New System.Drawing.Point(12, 45)
        Me.chkStage2.Name = "chkStage2"
        Me.chkStage2.Size = New System.Drawing.Size(76, 17)
        Me.chkStage2.TabIndex = 1
        Me.chkStage2.Text = "2nd Circuit"
        Me.chkStage2.UseVisualStyleBackColor = True
        '
        'chkStage1
        '
        Me.chkStage1.AutoSize = True
        Me.chkStage1.Checked = True
        Me.chkStage1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStage1.Enabled = False
        Me.chkStage1.Location = New System.Drawing.Point(12, 18)
        Me.chkStage1.Name = "chkStage1"
        Me.chkStage1.Size = New System.Drawing.Size(72, 17)
        Me.chkStage1.TabIndex = 0
        Me.chkStage1.Text = "1st Circuit"
        Me.chkStage1.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(385, 124)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkRemoveJCIHGBP)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(432, 153)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkRemoveJCIHGBP
        '
        Me.chkRemoveJCIHGBP.AutoSize = True
        Me.chkRemoveJCIHGBP.Location = New System.Drawing.Point(133, 19)
        Me.chkRemoveJCIHGBP.Name = "chkRemoveJCIHGBP"
        Me.chkRemoveJCIHGBP.Size = New System.Drawing.Size(215, 17)
        Me.chkRemoveJCIHGBP.TabIndex = 26
        Me.chkRemoveJCIHGBP.Text = "Remove JCI Installed HGBP on Circuit 1"
        Me.chkRemoveJCIHGBP.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optNoIso)
        Me.GroupBox2.Controls.Add(Me.optSolIso)
        Me.GroupBox2.Controls.Add(Me.optManIso)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 92)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Isolation"
        '
        'optNoIso
        '
        Me.optNoIso.AutoSize = True
        Me.optNoIso.Location = New System.Drawing.Point(15, 68)
        Me.optNoIso.Name = "optNoIso"
        Me.optNoIso.Size = New System.Drawing.Size(51, 17)
        Me.optNoIso.TabIndex = 2
        Me.optNoIso.Text = "None"
        Me.optNoIso.UseVisualStyleBackColor = True
        '
        'optSolIso
        '
        Me.optSolIso.AutoSize = True
        Me.optSolIso.Location = New System.Drawing.Point(15, 45)
        Me.optSolIso.Name = "optSolIso"
        Me.optSolIso.Size = New System.Drawing.Size(96, 17)
        Me.optSolIso.TabIndex = 1
        Me.optSolIso.Text = "Solenoid Valve"
        Me.optSolIso.UseVisualStyleBackColor = True
        '
        'optManIso
        '
        Me.optManIso.AutoSize = True
        Me.optManIso.Checked = True
        Me.optManIso.Location = New System.Drawing.Point(15, 22)
        Me.optManIso.Name = "optManIso"
        Me.optManIso.Size = New System.Drawing.Size(90, 17)
        Me.optManIso.TabIndex = 0
        Me.optManIso.TabStop = True
        Me.optManIso.Text = "Manual Valve"
        Me.optManIso.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(385, 124)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkDischargeTStat)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 153)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkDischargeTStat
        '
        Me.chkDischargeTStat.AutoSize = True
        Me.chkDischargeTStat.Location = New System.Drawing.Point(6, 6)
        Me.chkDischargeTStat.Name = "chkDischargeTStat"
        Me.chkDischargeTStat.Size = New System.Drawing.Size(215, 17)
        Me.chkDischargeTStat.TabIndex = 26
        Me.chkDischargeTStat.Text = "Unit has Micro Channel Condenser Coils"
        Me.chkDischargeTStat.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(385, 124)
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
        Me.tpgPerformance.Size = New System.Drawing.Size(432, 153)
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
        Me.btnDonePerformance.Location = New System.Drawing.Point(385, 124)
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
        Me.DebugPage.Size = New System.Drawing.Size(432, 153)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(377, 195)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 14
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(413, 195)
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
        Me.chkWriteHistory.Location = New System.Drawing.Point(168, 207)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 15
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'frmHGBP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmHGBP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hot Gas Bypass"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbHGBPStyle4 As ComboBox
    Friend WithEvents cmbHGBPStyle3 As ComboBox
    Friend WithEvents cmbHGBPStyle2 As ComboBox
    Friend WithEvents cmbHGBPStyle1 As ComboBox
    Friend WithEvents chkStage4 As CheckBox
    Friend WithEvents chkStage3 As CheckBox
    Friend WithEvents chkStage2 As CheckBox
    Friend WithEvents chkStage1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optNoIso As RadioButton
    Friend WithEvents optSolIso As RadioButton
    Friend WithEvents optManIso As RadioButton
    Friend WithEvents cmbRefrigerant As ComboBox
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents chkDischargeTStat As CheckBox
    Friend WithEvents chkRemoveJCIHGBP As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chkWriteHistory As CheckBox
End Class
