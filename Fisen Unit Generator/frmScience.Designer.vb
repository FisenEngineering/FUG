<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScience
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
        Me.lblSciPath = New System.Windows.Forms.Label()
        Me.lblUnitFamily = New System.Windows.Forms.Label()
        Me.lstSciFact = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSciPath
        '
        Me.lblSciPath.AutoSize = True
        Me.lblSciPath.Location = New System.Drawing.Point(12, 394)
        Me.lblSciPath.Name = "lblSciPath"
        Me.lblSciPath.Size = New System.Drawing.Size(39, 13)
        Me.lblSciPath.TabIndex = 0
        Me.lblSciPath.Text = "Label1"
        '
        'lblUnitFamily
        '
        Me.lblUnitFamily.AutoSize = True
        Me.lblUnitFamily.Location = New System.Drawing.Point(12, 416)
        Me.lblUnitFamily.Name = "lblUnitFamily"
        Me.lblUnitFamily.Size = New System.Drawing.Size(39, 13)
        Me.lblUnitFamily.TabIndex = 1
        Me.lblUnitFamily.Text = "Label1"
        '
        'lstSciFact
        '
        Me.lstSciFact.FormattingEnabled = True
        Me.lstSciFact.Location = New System.Drawing.Point(15, 12)
        Me.lstSciFact.Name = "lstSciFact"
        Me.lstSciFact.Size = New System.Drawing.Size(773, 186)
        Me.lstSciFact.TabIndex = 2
        '
        'frmScience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSciFact)
        Me.Controls.Add(Me.lblUnitFamily)
        Me.Controls.Add(Me.lblSciPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmScience"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmScience"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSciPath As Label
    Friend WithEvents lblUnitFamily As Label
    Friend WithEvents lstSciFact As ListBox
End Class
