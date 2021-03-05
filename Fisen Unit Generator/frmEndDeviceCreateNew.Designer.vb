<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndDeviceCreateNew
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.optEndDeviceType = New System.Windows.Forms.RadioButton()
        Me.optSensorTypr = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 163)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 163)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(380, 20)
        Me.txtName.TabIndex = 0
        '
        'optEndDeviceType
        '
        Me.optEndDeviceType.AutoSize = True
        Me.optEndDeviceType.Location = New System.Drawing.Point(75, 35)
        Me.optEndDeviceType.Name = "optEndDeviceType"
        Me.optEndDeviceType.Size = New System.Drawing.Size(81, 17)
        Me.optEndDeviceType.TabIndex = 1
        Me.optEndDeviceType.Text = "End Device"
        Me.optEndDeviceType.UseVisualStyleBackColor = True
        '
        'optSensorTypr
        '
        Me.optSensorTypr.AutoSize = True
        Me.optSensorTypr.Checked = True
        Me.optSensorTypr.Location = New System.Drawing.Point(171, 35)
        Me.optSensorTypr.Name = "optSensorTypr"
        Me.optSensorTypr.Size = New System.Drawing.Size(58, 17)
        Me.optSensorTypr.TabIndex = 2
        Me.optSensorTypr.TabStop = True
        Me.optSensorTypr.Text = "Sensor"
        Me.optSensorTypr.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Class:"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(75, 88)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(100, 20)
        Me.txtTag.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tag:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(213, 111)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(242, 20)
        Me.txtPath.TabIndex = 5
        Me.txtPath.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Path:"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Unselected"})
        Me.cmbClass.Location = New System.Drawing.Point(75, 58)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(215, 21)
        Me.cmbClass.TabIndex = 3
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(75, 137)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(380, 20)
        Me.txtFileName.TabIndex = 6
        Me.txtFileName.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "File Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "...\CutSheets\EndDevices\"
        '
        'frmEndDeviceCreateNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.optSensorTypr)
        Me.Controls.Add(Me.optEndDeviceType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEndDeviceCreateNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New End Device"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents optEndDeviceType As RadioButton
    Friend WithEvents optSensorTypr As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTag As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
