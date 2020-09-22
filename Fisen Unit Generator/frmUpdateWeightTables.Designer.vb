<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateWeightTables
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
        Me.txtStubb = New System.Windows.Forms.TextBox()
        Me.txtBaseWeight = New System.Windows.Forms.TextBox()
        Me.txtAWeight = New System.Windows.Forms.TextBox()
        Me.txtBWeight = New System.Windows.Forms.TextBox()
        Me.txtCWeight = New System.Windows.Forms.TextBox()
        Me.txtDWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(90, 129)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 129)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtStubb
        '
        Me.txtStubb.Location = New System.Drawing.Point(12, 25)
        Me.txtStubb.Name = "txtStubb"
        Me.txtStubb.Size = New System.Drawing.Size(100, 20)
        Me.txtStubb.TabIndex = 8
        '
        'txtBaseWeight
        '
        Me.txtBaseWeight.Location = New System.Drawing.Point(12, 64)
        Me.txtBaseWeight.Name = "txtBaseWeight"
        Me.txtBaseWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBaseWeight.TabIndex = 9
        '
        'txtAWeight
        '
        Me.txtAWeight.Location = New System.Drawing.Point(12, 103)
        Me.txtAWeight.Name = "txtAWeight"
        Me.txtAWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtAWeight.TabIndex = 10
        '
        'txtBWeight
        '
        Me.txtBWeight.Location = New System.Drawing.Point(118, 103)
        Me.txtBWeight.Name = "txtBWeight"
        Me.txtBWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBWeight.TabIndex = 11
        '
        'txtCWeight
        '
        Me.txtCWeight.Location = New System.Drawing.Point(224, 103)
        Me.txtCWeight.Name = "txtCWeight"
        Me.txtCWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtCWeight.TabIndex = 12
        '
        'txtDWeight
        '
        Me.txtDWeight.Location = New System.Drawing.Point(330, 103)
        Me.txtDWeight.Name = "txtDWeight"
        Me.txtDWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDWeight.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Model Number Stubb"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Base Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "A Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "B Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "C Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "D Weight"
        '
        'frmUpdateWeightTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(436, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDWeight)
        Me.Controls.Add(Me.txtCWeight)
        Me.Controls.Add(Me.txtBWeight)
        Me.Controls.Add(Me.txtAWeight)
        Me.Controls.Add(Me.txtBaseWeight)
        Me.Controls.Add(Me.txtStubb)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdateWeightTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update UPG Unit Weight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtStubb As TextBox
    Friend WithEvents txtBaseWeight As TextBox
    Friend WithEvents txtAWeight As TextBox
    Friend WithEvents txtBWeight As TextBox
    Friend WithEvents txtCWeight As TextBox
    Friend WithEvents txtDWeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
