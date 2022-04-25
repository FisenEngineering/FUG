<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateSoOTable
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lstModCodesInPlay = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtModWordsActive = New System.Windows.Forms.TextBox()
        Me.txtModCodeActive = New System.Windows.Forms.TextBox()
        Me.lstActiveSoO = New System.Windows.Forms.ListBox()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lstAvailableSoOFiles = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdMakeRequired = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdChangeDirectory = New System.Windows.Forms.Button()
        Me.rtbSoOPreview = New System.Windows.Forms.RichTextBox()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(93, 581)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(12, 581)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 32
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lstModCodesInPlay
        '
        Me.lstModCodesInPlay.FormattingEnabled = True
        Me.lstModCodesInPlay.Location = New System.Drawing.Point(12, 12)
        Me.lstModCodesInPlay.Name = "lstModCodesInPlay"
        Me.lstModCodesInPlay.Size = New System.Drawing.Size(770, 134)
        Me.lstModCodesInPlay.TabIndex = 34
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'txtModWordsActive
        '
        Me.txtModWordsActive.Location = New System.Drawing.Point(118, 152)
        Me.txtModWordsActive.Name = "txtModWordsActive"
        Me.txtModWordsActive.ReadOnly = True
        Me.txtModWordsActive.Size = New System.Drawing.Size(664, 20)
        Me.txtModWordsActive.TabIndex = 36
        '
        'txtModCodeActive
        '
        Me.txtModCodeActive.Location = New System.Drawing.Point(12, 152)
        Me.txtModCodeActive.Name = "txtModCodeActive"
        Me.txtModCodeActive.ReadOnly = True
        Me.txtModCodeActive.Size = New System.Drawing.Size(100, 20)
        Me.txtModCodeActive.TabIndex = 35
        '
        'lstActiveSoO
        '
        Me.lstActiveSoO.FormattingEnabled = True
        Me.lstActiveSoO.Location = New System.Drawing.Point(12, 191)
        Me.lstActiveSoO.Name = "lstActiveSoO"
        Me.lstActiveSoO.Size = New System.Drawing.Size(770, 56)
        Me.lstActiveSoO.TabIndex = 37
        '
        'cmdRemove
        '
        Me.cmdRemove.Enabled = False
        Me.cmdRemove.Location = New System.Drawing.Point(209, 552)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(99, 23)
        Me.cmdRemove.TabIndex = 40
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'lstAvailableSoOFiles
        '
        Me.lstAvailableSoOFiles.FormattingEnabled = True
        Me.lstAvailableSoOFiles.Location = New System.Drawing.Point(12, 266)
        Me.lstAvailableSoOFiles.Name = "lstAvailableSoOFiles"
        Me.lstAvailableSoOFiles.Size = New System.Drawing.Size(770, 69)
        Me.lstAvailableSoOFiles.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Active Sequence Files Required"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Available Sequence of Operation Files"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Preview"
        '
        'cmdMakeRequired
        '
        Me.cmdMakeRequired.Enabled = False
        Me.cmdMakeRequired.Location = New System.Drawing.Point(315, 552)
        Me.cmdMakeRequired.Name = "cmdMakeRequired"
        Me.cmdMakeRequired.Size = New System.Drawing.Size(99, 23)
        Me.cmdMakeRequired.TabIndex = 46
        Me.cmdMakeRequired.Text = "Make Required"
        Me.cmdMakeRequired.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(420, 552)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Upload New SoO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdChangeDirectory
        '
        Me.cmdChangeDirectory.Location = New System.Drawing.Point(525, 552)
        Me.cmdChangeDirectory.Name = "cmdChangeDirectory"
        Me.cmdChangeDirectory.Size = New System.Drawing.Size(99, 23)
        Me.cmdChangeDirectory.TabIndex = 48
        Me.cmdChangeDirectory.Text = "Change Directory"
        Me.cmdChangeDirectory.UseVisualStyleBackColor = True
        '
        'rtbSoOPreview
        '
        Me.rtbSoOPreview.Location = New System.Drawing.Point(12, 354)
        Me.rtbSoOPreview.Name = "rtbSoOPreview"
        Me.rtbSoOPreview.Size = New System.Drawing.Size(770, 192)
        Me.rtbSoOPreview.TabIndex = 49
        Me.rtbSoOPreview.Text = ""
        '
        'frmUpdateSoOTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.rtbSoOPreview)
        Me.Controls.Add(Me.cmdChangeDirectory)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdMakeRequired)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAvailableSoOFiles)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.lstActiveSoO)
        Me.Controls.Add(Me.txtModWordsActive)
        Me.Controls.Add(Me.txtModCodeActive)
        Me.Controls.Add(Me.lstModCodesInPlay)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdateSoOTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Sequence of Operation Tables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lstModCodesInPlay As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtModWordsActive As TextBox
    Friend WithEvents txtModCodeActive As TextBox
    Friend WithEvents lstActiveSoO As ListBox
    Friend WithEvents cmdRemove As Button
    Friend WithEvents lstAvailableSoOFiles As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdMakeRequired As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdChangeDirectory As Button
    Friend WithEvents rtbSoOPreview As RichTextBox
    Friend WithEvents fbd As FolderBrowserDialog
End Class
