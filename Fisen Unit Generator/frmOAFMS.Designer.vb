<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOAFMS
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.optHorizontal = New System.Windows.Forms.RadioButton()
        Me.optDownflow = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAirflow = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(120, 240)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(16, 240)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 4
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.optHorizontal)
        Me.tpgConditions.Controls.Add(Me.optDownflow)
        Me.tpgConditions.Controls.Add(Me.Label10)
        Me.tpgConditions.Controls.Add(Me.txtAirflow)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 25)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 191)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'optHorizontal
        '
        Me.optHorizontal.AutoSize = True
        Me.optHorizontal.Location = New System.Drawing.Point(8, 64)
        Me.optHorizontal.Name = "optHorizontal"
        Me.optHorizontal.Size = New System.Drawing.Size(190, 21)
        Me.optHorizontal.TabIndex = 34
        Me.optHorizontal.Text = "Horizontal Discharge Unit"
        Me.optHorizontal.UseVisualStyleBackColor = True
        '
        'optDownflow
        '
        Me.optDownflow.AutoSize = True
        Me.optDownflow.Checked = True
        Me.optDownflow.Location = New System.Drawing.Point(8, 37)
        Me.optDownflow.Name = "optDownflow"
        Me.optDownflow.Size = New System.Drawing.Size(117, 21)
        Me.optDownflow.TabIndex = 33
        Me.optDownflow.TabStop = True
        Me.optDownflow.Text = "Downflow Unit"
        Me.optDownflow.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Airflow (cfm)"
        '
        'txtAirflow
        '
        Me.txtAirflow.Enabled = False
        Me.txtAirflow.Location = New System.Drawing.Point(8, 8)
        Me.txtAirflow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(52, 22)
        Me.txtAirflow.TabIndex = 31
        Me.txtAirflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 25)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Size = New System.Drawing.Size(579, 191)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 25)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 191)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.chkNoPerformance)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 25)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 191)
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
        Me.chkNoPerformance.Location = New System.Drawing.Point(17, 16)
        Me.chkNoPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(327, 21)
        Me.chkNoPerformance.TabIndex = 27
        Me.chkNoPerformance.Text = "No Performance to Report for This Modification"
        Me.chkNoPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(513, 153)
        Me.btnDonePerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 25)
        Me.DebugPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Size = New System.Drawing.Size(579, 191)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'frmOAFMS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOAFMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Outdoor Airflow Monitoring"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
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
    Friend WithEvents optHorizontal As RadioButton
    Friend WithEvents optDownflow As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAirflow As TextBox
End Class
