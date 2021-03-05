<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPointEditCreate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPointName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbRW = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRange = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdMechOnly = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 401)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(13, 401)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Point"
        '
        'txtPointName
        '
        Me.txtPointName.Location = New System.Drawing.Point(15, 25)
        Me.txtPointName.Name = "txtPointName"
        Me.txtPointName.Size = New System.Drawing.Size(773, 20)
        Me.txtPointName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Point Type"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"BAVP", "BAVS", "BBVP", "BBVS", "Alarm", "n/a", "Unselected"})
        Me.cmbType.Location = New System.Drawing.Point(15, 64)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(94, 21)
        Me.cmbType.TabIndex = 18
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(15, 104)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(773, 105)
        Me.txtNotes.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Notes"
        '
        'cmbRW
        '
        Me.cmbRW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRW.FormattingEnabled = True
        Me.cmbRW.Items.AddRange(New Object() {"R", "R/W", "n/a", "Unselected"})
        Me.cmbRW.Location = New System.Drawing.Point(117, 64)
        Me.cmbRW.Name = "cmbRW"
        Me.cmbRW.Size = New System.Drawing.Size(74, 21)
        Me.cmbRW.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Read/Write"
        '
        'cmbRange
        '
        Me.cmbRange.FormattingEnabled = True
        Me.cmbRange.Items.AddRange(New Object() {"-30-130ºF", "Off=0 On=1", "Off=1 On=0", "0.00-5.00", "0.00-100.00", "0.00-40.00", "0.0-60.0", "0=Normal 1=Alarm", "Unselected"})
        Me.cmbRange.Location = New System.Drawing.Point(197, 64)
        Me.cmbRange.Name = "cmbRange"
        Me.cmbRange.Size = New System.Drawing.Size(177, 21)
        Me.cmbRange.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Range"
        '
        'cmdMechOnly
        '
        Me.cmdMechOnly.Enabled = False
        Me.cmdMechOnly.Location = New System.Drawing.Point(674, 215)
        Me.cmdMechOnly.Name = "cmdMechOnly"
        Me.cmdMechOnly.Size = New System.Drawing.Size(114, 23)
        Me.cmdMechOnly.TabIndex = 27
        Me.cmdMechOnly.Text = "Mech Only"
        Me.cmdMechOnly.UseVisualStyleBackColor = True
        '
        'frmPointEditCreate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdMechOnly)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbRange)
        Me.Controls.Add(Me.cmbRW)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPointName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPointEditCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPointEditCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPointName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRW As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbRange As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdMechOnly As Button
End Class
