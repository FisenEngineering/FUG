<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateShipWithTables
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstModCodesInPlay = New System.Windows.Forms.ListBox()
        Me.txtModCodeActive = New System.Windows.Forms.TextBox()
        Me.txtModWordsActive = New System.Windows.Forms.TextBox()
        Me.lstActiveShipWithsRequired = New System.Windows.Forms.ListBox()
        Me.lstAvailableShipWiths = New System.Windows.Forms.ListBox()
        Me.cmdMakeRequired = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdCreateAvailable = New System.Windows.Forms.Button()
        Me.txtNewShipWith = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(93, 415)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 31
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(12, 415)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 30
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'lstModCodesInPlay
        '
        Me.lstModCodesInPlay.FormattingEnabled = True
        Me.lstModCodesInPlay.Location = New System.Drawing.Point(12, 12)
        Me.lstModCodesInPlay.Name = "lstModCodesInPlay"
        Me.lstModCodesInPlay.Size = New System.Drawing.Size(770, 134)
        Me.lstModCodesInPlay.TabIndex = 32
        '
        'txtModCodeActive
        '
        Me.txtModCodeActive.Location = New System.Drawing.Point(12, 152)
        Me.txtModCodeActive.Name = "txtModCodeActive"
        Me.txtModCodeActive.ReadOnly = True
        Me.txtModCodeActive.Size = New System.Drawing.Size(100, 20)
        Me.txtModCodeActive.TabIndex = 33
        '
        'txtModWordsActive
        '
        Me.txtModWordsActive.Location = New System.Drawing.Point(118, 152)
        Me.txtModWordsActive.Name = "txtModWordsActive"
        Me.txtModWordsActive.ReadOnly = True
        Me.txtModWordsActive.Size = New System.Drawing.Size(664, 20)
        Me.txtModWordsActive.TabIndex = 34
        '
        'lstActiveShipWithsRequired
        '
        Me.lstActiveShipWithsRequired.FormattingEnabled = True
        Me.lstActiveShipWithsRequired.Location = New System.Drawing.Point(12, 178)
        Me.lstActiveShipWithsRequired.Name = "lstActiveShipWithsRequired"
        Me.lstActiveShipWithsRequired.Size = New System.Drawing.Size(770, 95)
        Me.lstActiveShipWithsRequired.TabIndex = 36
        '
        'lstAvailableShipWiths
        '
        Me.lstAvailableShipWiths.FormattingEnabled = True
        Me.lstAvailableShipWiths.Location = New System.Drawing.Point(556, 279)
        Me.lstAvailableShipWiths.Name = "lstAvailableShipWiths"
        Me.lstAvailableShipWiths.Size = New System.Drawing.Size(226, 95)
        Me.lstAvailableShipWiths.TabIndex = 37
        '
        'cmdMakeRequired
        '
        Me.cmdMakeRequired.Enabled = False
        Me.cmdMakeRequired.Location = New System.Drawing.Point(451, 279)
        Me.cmdMakeRequired.Name = "cmdMakeRequired"
        Me.cmdMakeRequired.Size = New System.Drawing.Size(99, 23)
        Me.cmdMakeRequired.TabIndex = 38
        Me.cmdMakeRequired.Text = "Make Required"
        Me.cmdMakeRequired.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Enabled = False
        Me.cmdRemove.Location = New System.Drawing.Point(13, 279)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(99, 23)
        Me.cmdRemove.TabIndex = 39
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdCreateAvailable
        '
        Me.cmdCreateAvailable.Location = New System.Drawing.Point(451, 378)
        Me.cmdCreateAvailable.Name = "cmdCreateAvailable"
        Me.cmdCreateAvailable.Size = New System.Drawing.Size(99, 23)
        Me.cmdCreateAvailable.TabIndex = 40
        Me.cmdCreateAvailable.Text = "Create Available"
        Me.cmdCreateAvailable.UseVisualStyleBackColor = True
        '
        'txtNewShipWith
        '
        Me.txtNewShipWith.Location = New System.Drawing.Point(556, 380)
        Me.txtNewShipWith.Name = "txtNewShipWith"
        Me.txtNewShipWith.Size = New System.Drawing.Size(226, 20)
        Me.txtNewShipWith.TabIndex = 41
        '
        'frmUpdateShipWithTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNewShipWith)
        Me.Controls.Add(Me.cmdCreateAvailable)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdMakeRequired)
        Me.Controls.Add(Me.lstAvailableShipWiths)
        Me.Controls.Add(Me.lstActiveShipWithsRequired)
        Me.Controls.Add(Me.txtModWordsActive)
        Me.Controls.Add(Me.txtModCodeActive)
        Me.Controls.Add(Me.lstModCodesInPlay)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdateShipWithTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Ship With Tables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lstModCodesInPlay As ListBox
    Friend WithEvents txtModCodeActive As TextBox
    Friend WithEvents txtModWordsActive As TextBox
    Friend WithEvents lstActiveShipWithsRequired As ListBox
    Friend WithEvents lstAvailableShipWiths As ListBox
    Friend WithEvents cmdMakeRequired As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdCreateAvailable As Button
    Friend WithEvents txtNewShipWith As TextBox
End Class
