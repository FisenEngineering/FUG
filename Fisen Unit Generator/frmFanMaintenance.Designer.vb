<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFanMaintenance
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
        Me.chkSupplyFan = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.chkReturnFan = New System.Windows.Forms.CheckBox()
        Me.chkExhaustFan = New System.Windows.Forms.CheckBox()
        Me.txtFanID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSupplyFan
        '
        Me.chkSupplyFan.AutoSize = True
        Me.chkSupplyFan.Location = New System.Drawing.Point(12, 92)
        Me.chkSupplyFan.Name = "chkSupplyFan"
        Me.chkSupplyFan.Size = New System.Drawing.Size(79, 17)
        Me.chkSupplyFan.TabIndex = 0
        Me.chkSupplyFan.Text = "Supply Fan"
        Me.chkSupplyFan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 74)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fan Manufacturer and Style"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Continental"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(90, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Comefri ATZAF_FF"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(211, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Comefri ATLI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(303, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Other"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(360, 18)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(210, 20)
        Me.txtFilePath.TabIndex = 4
        Me.txtFilePath.Text = "\Continental\"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Enabled = False
        Me.RadioButton5.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "NewFan01"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Enabled = False
        Me.RadioButton6.Location = New System.Drawing.Point(90, 42)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.Text = "NewFan02"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Enabled = False
        Me.RadioButton7.Location = New System.Drawing.Point(211, 42)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton7.TabIndex = 7
        Me.RadioButton7.Text = "NewFan03"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'chkReturnFan
        '
        Me.chkReturnFan.AutoSize = True
        Me.chkReturnFan.Checked = True
        Me.chkReturnFan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReturnFan.Location = New System.Drawing.Point(102, 92)
        Me.chkReturnFan.Name = "chkReturnFan"
        Me.chkReturnFan.Size = New System.Drawing.Size(79, 17)
        Me.chkReturnFan.TabIndex = 2
        Me.chkReturnFan.Text = "Return Fan"
        Me.chkReturnFan.UseVisualStyleBackColor = True
        '
        'chkExhaustFan
        '
        Me.chkExhaustFan.AutoSize = True
        Me.chkExhaustFan.Checked = True
        Me.chkExhaustFan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExhaustFan.Location = New System.Drawing.Point(223, 92)
        Me.chkExhaustFan.Name = "chkExhaustFan"
        Me.chkExhaustFan.Size = New System.Drawing.Size(85, 17)
        Me.chkExhaustFan.TabIndex = 3
        Me.chkExhaustFan.Text = "Exhaust Fan"
        Me.chkExhaustFan.UseVisualStyleBackColor = True
        '
        'txtFanID
        '
        Me.txtFanID.Location = New System.Drawing.Point(12, 145)
        Me.txtFanID.Name = "txtFanID"
        Me.txtFanID.Size = New System.Drawing.Size(210, 20)
        Me.txtFanID.TabIndex = 5
        Me.txtFanID.Text = "AFKsss/hhh/bb/pp_rpm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Database ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Submittal ID"
        '
        'txtSubID
        '
        Me.txtSubID.Location = New System.Drawing.Point(228, 145)
        Me.txtSubID.Name = "txtSubID"
        Me.txtSubID.Size = New System.Drawing.Size(210, 20)
        Me.txtSubID.TabIndex = 7
        Me.txtSubID.Text = "AFK sss/hhh/bb/pp rpm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fan Curve Name"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(12, 184)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(210, 20)
        Me.txtFileName.TabIndex = 9
        Me.txtFileName.Text = "CFM_sss-hhh-bb_rpmm.png"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(87, 211)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(67, 21)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 211)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(67, 21)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "Create"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmFanMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFanID)
        Me.Controls.Add(Me.chkExhaustFan)
        Me.Controls.Add(Me.chkReturnFan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkSupplyFan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFanMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fan Curve Maintenance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkSupplyFan As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents chkReturnFan As CheckBox
    Friend WithEvents chkExhaustFan As CheckBox
    Friend WithEvents txtFanID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
End Class
