<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDWall
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.lstLinerMaterial = New System.Windows.Forms.ListBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optHXComesOut = New System.Windows.Forms.RadioButton()
        Me.optHXStaysIn = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkNoControls = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.optHXNotThere = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.tpgConditions.Controls.Add(Me.lstLinerMaterial)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(432, 153)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'lstLinerMaterial
        '
        Me.lstLinerMaterial.FormattingEnabled = True
        Me.lstLinerMaterial.Items.AddRange(New Object() {"Galvanized Liners", "Stainless Steel(304) Liners"})
        Me.lstLinerMaterial.Location = New System.Drawing.Point(6, 6)
        Me.lstLinerMaterial.Name = "lstLinerMaterial"
        Me.lstLinerMaterial.Size = New System.Drawing.Size(168, 56)
        Me.lstLinerMaterial.TabIndex = 25
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
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(432, 153)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optHXNotThere)
        Me.GroupBox1.Controls.Add(Me.optHXComesOut)
        Me.GroupBox1.Controls.Add(Me.optHXStaysIn)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 90)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Heat Exchanger Removal"
        '
        'optHXComesOut
        '
        Me.optHXComesOut.AutoSize = True
        Me.optHXComesOut.Location = New System.Drawing.Point(6, 42)
        Me.optHXComesOut.Name = "optHXComesOut"
        Me.optHXComesOut.Size = New System.Drawing.Size(147, 17)
        Me.optHXComesOut.TabIndex = 1
        Me.optHXComesOut.Text = "Remove and Replace HX"
        Me.optHXComesOut.UseVisualStyleBackColor = True
        '
        'optHXStaysIn
        '
        Me.optHXStaysIn.AutoSize = True
        Me.optHXStaysIn.Checked = True
        Me.optHXStaysIn.Location = New System.Drawing.Point(6, 19)
        Me.optHXStaysIn.Name = "optHXStaysIn"
        Me.optHXStaysIn.Size = New System.Drawing.Size(120, 17)
        Me.optHXStaysIn.TabIndex = 0
        Me.optHXStaysIn.TabStop = True
        Me.optHXStaysIn.Text = "Do Not Remove HX"
        Me.optHXStaysIn.UseVisualStyleBackColor = True
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
        Me.tpgControls.Controls.Add(Me.chkNoControls)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(432, 153)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkNoControls
        '
        Me.chkNoControls.AutoSize = True
        Me.chkNoControls.Checked = True
        Me.chkNoControls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoControls.Enabled = False
        Me.chkNoControls.Location = New System.Drawing.Point(6, 6)
        Me.chkNoControls.Name = "chkNoControls"
        Me.chkNoControls.Size = New System.Drawing.Size(218, 17)
        Me.chkNoControls.TabIndex = 26
        Me.chkNoControls.Text = "No Controls Options for This Modification"
        Me.chkNoControls.UseVisualStyleBackColor = True
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
        Me.chkNoPerformance.Location = New System.Drawing.Point(6, 6)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(248, 17)
        Me.chkNoPerformance.TabIndex = 26
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
        'optHXNotThere
        '
        Me.optHXNotThere.AutoSize = True
        Me.optHXNotThere.Location = New System.Drawing.Point(6, 65)
        Me.optHXNotThere.Name = "optHXNotThere"
        Me.optHXNotThere.Size = New System.Drawing.Size(120, 17)
        Me.optHXNotThere.TabIndex = 2
        Me.optHXNotThere.Text = "No Gas Heat in Unit"
        Me.optHXNotThere.UseVisualStyleBackColor = True
        '
        'frmDWall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmDWall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Double Wall"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents optHXComesOut As RadioButton
    Friend WithEvents optHXStaysIn As RadioButton
    Friend WithEvents chkNoControls As CheckBox
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents lstLinerMaterial As ListBox
    Friend WithEvents optHXNotThere As RadioButton
End Class
