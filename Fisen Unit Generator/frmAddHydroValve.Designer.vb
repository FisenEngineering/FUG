<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddHydroValve
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optBallValve = New System.Windows.Forms.RadioButton()
        Me.optButterflyValve = New System.Windows.Forms.RadioButton()
        Me.lstValveStyle = New System.Windows.Forms.ListBox()
        Me.lstValveBrand = New System.Windows.Forms.ListBox()
        Me.lstValveSize = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optBallValve)
        Me.GroupBox1.Controls.Add(Me.optButterflyValve)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valve Type"
        '
        'optBallValve
        '
        Me.optBallValve.AutoSize = True
        Me.optBallValve.Location = New System.Drawing.Point(132, 21)
        Me.optBallValve.Name = "optBallValve"
        Me.optBallValve.Size = New System.Drawing.Size(91, 21)
        Me.optBallValve.TabIndex = 1
        Me.optBallValve.Text = "Ball Valve"
        Me.optBallValve.UseVisualStyleBackColor = True
        '
        'optButterflyValve
        '
        Me.optButterflyValve.AutoSize = True
        Me.optButterflyValve.Checked = True
        Me.optButterflyValve.Location = New System.Drawing.Point(6, 21)
        Me.optButterflyValve.Name = "optButterflyValve"
        Me.optButterflyValve.Size = New System.Drawing.Size(120, 21)
        Me.optButterflyValve.TabIndex = 0
        Me.optButterflyValve.TabStop = True
        Me.optButterflyValve.Text = "Butterfly Valve"
        Me.optButterflyValve.UseVisualStyleBackColor = True
        '
        'lstValveStyle
        '
        Me.lstValveStyle.FormattingEnabled = True
        Me.lstValveStyle.ItemHeight = 16
        Me.lstValveStyle.Location = New System.Drawing.Point(12, 72)
        Me.lstValveStyle.Name = "lstValveStyle"
        Me.lstValveStyle.Size = New System.Drawing.Size(160, 84)
        Me.lstValveStyle.TabIndex = 1
        '
        'lstValveBrand
        '
        Me.lstValveBrand.FormattingEnabled = True
        Me.lstValveBrand.ItemHeight = 16
        Me.lstValveBrand.Location = New System.Drawing.Point(178, 72)
        Me.lstValveBrand.Name = "lstValveBrand"
        Me.lstValveBrand.Size = New System.Drawing.Size(160, 84)
        Me.lstValveBrand.TabIndex = 2
        '
        'lstValveSize
        '
        Me.lstValveSize.FormattingEnabled = True
        Me.lstValveSize.ItemHeight = 16
        Me.lstValveSize.Location = New System.Drawing.Point(344, 72)
        Me.lstValveSize.Name = "lstValveSize"
        Me.lstValveSize.Size = New System.Drawing.Size(160, 84)
        Me.lstValveSize.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 202)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(107, 39)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(128, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 39)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddHydroValve
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(517, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstValveSize)
        Me.Controls.Add(Me.lstValveBrand)
        Me.Controls.Add(Me.lstValveStyle)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddHydroValve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Hydronic Valve"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optBallValve As RadioButton
    Friend WithEvents optButterflyValve As RadioButton
    Friend WithEvents lstValveStyle As ListBox
    Friend WithEvents lstValveBrand As ListBox
    Friend WithEvents lstValveSize As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
