﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.fraRunMode = New System.Windows.Forms.GroupBox()
        Me.optSubGen = New System.Windows.Forms.RadioButton()
        Me.optResearch = New System.Windows.Forms.RadioButton()
        Me.fraRunMode.SuspendLayout()
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
        'fraRunMode
        '
        Me.fraRunMode.Controls.Add(Me.optResearch)
        Me.fraRunMode.Controls.Add(Me.optSubGen)
        Me.fraRunMode.Location = New System.Drawing.Point(559, 302)
        Me.fraRunMode.Name = "fraRunMode"
        Me.fraRunMode.Size = New System.Drawing.Size(229, 66)
        Me.fraRunMode.TabIndex = 3
        Me.fraRunMode.TabStop = False
        Me.fraRunMode.Text = "Run Mode"
        '
        'optSubGen
        '
        Me.optSubGen.AutoSize = True
        Me.optSubGen.Checked = True
        Me.optSubGen.Location = New System.Drawing.Point(6, 19)
        Me.optSubGen.Name = "optSubGen"
        Me.optSubGen.Size = New System.Drawing.Size(123, 17)
        Me.optSubGen.TabIndex = 0
        Me.optSubGen.TabStop = True
        Me.optSubGen.Text = "Submittal Generation"
        Me.optSubGen.UseVisualStyleBackColor = True
        '
        'optResearch
        '
        Me.optResearch.AutoSize = True
        Me.optResearch.Location = New System.Drawing.Point(6, 42)
        Me.optResearch.Name = "optResearch"
        Me.optResearch.Size = New System.Drawing.Size(71, 17)
        Me.optResearch.TabIndex = 1
        Me.optResearch.Text = "Research"
        Me.optResearch.UseVisualStyleBackColor = True
        '
        'frmUserOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraRunMode)
        Me.Controls.Add(Me.chkUOMoveCutstoSD)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.chkUOAutoLaunchWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUserOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fisen Unit Generator - User Options"
        Me.fraRunMode.ResumeLayout(False)
        Me.fraRunMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkUOAutoLaunchWord As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents chkUOMoveCutstoSD As CheckBox
    Friend WithEvents fraRunMode As GroupBox
    Friend WithEvents optResearch As RadioButton
    Friend WithEvents optSubGen As RadioButton
End Class
