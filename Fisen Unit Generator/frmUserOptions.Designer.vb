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
        Me.fraRunMode = New System.Windows.Forms.GroupBox()
        Me.optResearch = New System.Windows.Forms.RadioButton()
        Me.optSubGen = New System.Windows.Forms.RadioButton()
        Me.grpAdminOptions = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSkipAutoArchive = New System.Windows.Forms.CheckBox()
        Me.chkStealthMode = New System.Windows.Forms.CheckBox()
        Me.txtLocalDirectory = New System.Windows.Forms.TextBox()
        Me.fraRunMode.SuspendLayout()
        Me.grpAdminOptions.SuspendLayout()
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
        'grpAdminOptions
        '
        Me.grpAdminOptions.Controls.Add(Me.Label1)
        Me.grpAdminOptions.Controls.Add(Me.chkSkipAutoArchive)
        Me.grpAdminOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpAdminOptions.Name = "grpAdminOptions"
        Me.grpAdminOptions.Size = New System.Drawing.Size(332, 168)
        Me.grpAdminOptions.TabIndex = 4
        Me.grpAdminOptions.TabStop = False
        Me.grpAdminOptions.Text = "Admin Only Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Only Active in Debug/Admin Mode"
        '
        'chkSkipAutoArchive
        '
        Me.chkSkipAutoArchive.AutoSize = True
        Me.chkSkipAutoArchive.Location = New System.Drawing.Point(6, 37)
        Me.chkSkipAutoArchive.Name = "chkSkipAutoArchive"
        Me.chkSkipAutoArchive.Size = New System.Drawing.Size(111, 17)
        Me.chkSkipAutoArchive.TabIndex = 5
        Me.chkSkipAutoArchive.Text = "Skip Auto Archive"
        Me.chkSkipAutoArchive.UseVisualStyleBackColor = True
        '
        'chkStealthMode
        '
        Me.chkStealthMode.AutoSize = True
        Me.chkStealthMode.Location = New System.Drawing.Point(12, 186)
        Me.chkStealthMode.Name = "chkStealthMode"
        Me.chkStealthMode.Size = New System.Drawing.Size(201, 17)
        Me.chkStealthMode.TabIndex = 7
        Me.chkStealthMode.Text = "Save Design Files To Local Directory"
        Me.chkStealthMode.UseVisualStyleBackColor = True
        '
        'txtLocalDirectory
        '
        Me.txtLocalDirectory.Location = New System.Drawing.Point(34, 209)
        Me.txtLocalDirectory.Name = "txtLocalDirectory"
        Me.txtLocalDirectory.Size = New System.Drawing.Size(298, 20)
        Me.txtLocalDirectory.TabIndex = 8
        Me.txtLocalDirectory.Text = "C:\Users\jlevine\Desktop\AAA - Local Jobs\"
        '
        'frmUserOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLocalDirectory)
        Me.Controls.Add(Me.grpAdminOptions)
        Me.Controls.Add(Me.chkStealthMode)
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
        Me.grpAdminOptions.ResumeLayout(False)
        Me.grpAdminOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkUOAutoLaunchWord As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents chkUOMoveCutstoSD As CheckBox
    Friend WithEvents fraRunMode As GroupBox
    Friend WithEvents optResearch As RadioButton
    Friend WithEvents optSubGen As RadioButton
    Friend WithEvents grpAdminOptions As GroupBox
    Friend WithEvents chkSkipAutoArchive As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkStealthMode As CheckBox
    Friend WithEvents txtLocalDirectory As TextBox
End Class
