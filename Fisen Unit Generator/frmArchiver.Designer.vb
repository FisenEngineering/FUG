<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchiver
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
        Me.lstFilesToArchive = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTargetDir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(450, 256)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(372, 256)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lstFilesToArchive
        '
        Me.lstFilesToArchive.FormattingEnabled = True
        Me.lstFilesToArchive.Location = New System.Drawing.Point(15, 18)
        Me.lstFilesToArchive.Name = "lstFilesToArchive"
        Me.lstFilesToArchive.Size = New System.Drawing.Size(506, 169)
        Me.lstFilesToArchive.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Uncheck items you do not want moved to the archive directory:"
        '
        'txtTargetDir
        '
        Me.txtTargetDir.Location = New System.Drawing.Point(12, 206)
        Me.txtTargetDir.Multiline = True
        Me.txtTargetDir.Name = "txtTargetDir"
        Me.txtTargetDir.ReadOnly = True
        Me.txtTargetDir.Size = New System.Drawing.Size(509, 44)
        Me.txtTargetDir.TabIndex = 8
        '
        'frmArchiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTargetDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFilesToArchive)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmArchiver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Archive Submittal Design Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lstFilesToArchive As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTargetDir As TextBox
End Class
