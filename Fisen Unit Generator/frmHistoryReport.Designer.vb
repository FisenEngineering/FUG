<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoryReport
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
        Me.txtReport = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.chkFilterByFamily = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbModCode = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtReport
        '
        Me.txtReport.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReport.Location = New System.Drawing.Point(12, 91)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(776, 346)
        Me.txtReport.TabIndex = 0
        Me.txtReport.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(272, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(352, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 29)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(432, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 29)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'chkFilterByFamily
        '
        Me.chkFilterByFamily.AutoSize = True
        Me.chkFilterByFamily.Checked = True
        Me.chkFilterByFamily.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFilterByFamily.Location = New System.Drawing.Point(12, 19)
        Me.chkFilterByFamily.Name = "chkFilterByFamily"
        Me.chkFilterByFamily.Size = New System.Drawing.Size(94, 17)
        Me.chkFilterByFamily.TabIndex = 6
        Me.chkFilterByFamily.Text = "Filter by Family"
        Me.chkFilterByFamily.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(630, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'cmbModCode
        '
        Me.cmbModCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModCode.FormattingEnabled = True
        Me.cmbModCode.Items.AddRange(New Object() {"Unit Report", "100OA", "CstmCtrl", "DWall", "Filters", "HGBP", "HWCoil", "LCVAV", "MGH(R)", "MHGRH_Conv", "RFan", "SFan", "XFan", "Not Selected"})
        Me.cmbModCode.Location = New System.Drawing.Point(12, 47)
        Me.cmbModCode.Name = "cmbModCode"
        Me.cmbModCode.Size = New System.Drawing.Size(174, 21)
        Me.cmbModCode.TabIndex = 8
        '
        'frmHistoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.cmbModCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFilterByFamily)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtReport)
        Me.MinimumSize = New System.Drawing.Size(530, 265)
        Me.Name = "frmHistoryReport"
        Me.Text = "frmHistoryReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents chkFilterByFamily As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbModCode As ComboBox
    Friend WithEvents txtReport As RichTextBox
End Class
