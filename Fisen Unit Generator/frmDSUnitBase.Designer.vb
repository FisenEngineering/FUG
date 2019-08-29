<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDSUnitBase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFanSpeed = New System.Windows.Forms.TextBox()
        Me.txtCompQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompSpeed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 195)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fan Speed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFanSpeed
        '
        Me.txtFanSpeed.Location = New System.Drawing.Point(120, 6)
        Me.txtFanSpeed.Name = "txtFanSpeed"
        Me.txtFanSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtFanSpeed.TabIndex = 4
        Me.txtFanSpeed.Text = "n/a"
        '
        'txtCompQty
        '
        Me.txtCompQty.Location = New System.Drawing.Point(120, 32)
        Me.txtCompQty.Name = "txtCompQty"
        Me.txtCompQty.Size = New System.Drawing.Size(100, 20)
        Me.txtCompQty.TabIndex = 6
        Me.txtCompQty.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Compressor Qty"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompSpeed
        '
        Me.txtCompSpeed.Location = New System.Drawing.Point(120, 58)
        Me.txtCompSpeed.Name = "txtCompSpeed"
        Me.txtCompSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtCompSpeed.TabIndex = 8
        Me.txtCompSpeed.Text = "Single Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Compressor Speed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDSUnitBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCompSpeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCompQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFanSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmDSUnitBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Specific Data: DSV/DSH Unit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFanSpeed As TextBox
    Friend WithEvents txtCompQty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompSpeed As TextBox
    Friend WithEvents Label3 As Label
End Class
