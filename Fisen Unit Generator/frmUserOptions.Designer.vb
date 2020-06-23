<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserOptions
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
        Me.chkUOAutoLaunchWord = New System.Windows.Forms.CheckBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.chkUOMoveCutstoSD = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkUOAutoLaunchWord
        '
        Me.chkUOAutoLaunchWord.AutoSize = True
        Me.chkUOAutoLaunchWord.Location = New System.Drawing.Point(559, 26)
        Me.chkUOAutoLaunchWord.Name = "chkUOAutoLaunchWord"
        Me.chkUOAutoLaunchWord.Size = New System.Drawing.Size(168, 17)
        Me.chkUOAutoLaunchWord.TabIndex = 0
        Me.chkUOAutoLaunchWord.Text = "Auto Launch Word Templates"
        Me.chkUOAutoLaunchWord.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(696, 401)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(92, 37)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'chkUOMoveCutstoSD
        '
        Me.chkUOMoveCutstoSD.AutoSize = True
        Me.chkUOMoveCutstoSD.Location = New System.Drawing.Point(559, 49)
        Me.chkUOMoveCutstoSD.Name = "chkUOMoveCutstoSD"
        Me.chkUOMoveCutstoSD.Size = New System.Drawing.Size(229, 17)
        Me.chkUOMoveCutstoSD.TabIndex = 2
        Me.chkUOMoveCutstoSD.Text = "Move Cutsheets to Submittal Design Folder"
        Me.chkUOMoveCutstoSD.UseVisualStyleBackColor = True
        '
        'frmUserOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkUOMoveCutstoSD)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.chkUOAutoLaunchWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUserOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fisen Unit Generator - User Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkUOAutoLaunchWord As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents chkUOMoveCutstoSD As CheckBox
End Class
