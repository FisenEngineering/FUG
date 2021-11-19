<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateUnitDrawings
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lstAvailDwgs = New System.Windows.Forms.ListBox()
        Me.cmbFamily = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDrawingID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlainName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWMFName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.chkFileValid = New System.Windows.Forms.CheckBox()
        Me.chkWMFValid = New System.Windows.Forms.CheckBox()
        Me.cmdValidateFiles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(93, 626)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(12, 626)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 32
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lstAvailDwgs
        '
        Me.lstAvailDwgs.FormattingEnabled = True
        Me.lstAvailDwgs.Location = New System.Drawing.Point(12, 53)
        Me.lstAvailDwgs.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAvailDwgs.Name = "lstAvailDwgs"
        Me.lstAvailDwgs.Size = New System.Drawing.Size(450, 134)
        Me.lstAvailDwgs.TabIndex = 34
        '
        'cmbFamily
        '
        Me.cmbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamily.FormattingEnabled = True
        Me.cmbFamily.Items.AddRange(New Object() {"Series5", "Series10", "Series12", "Series20", "xSelectx", "Choice", "Series100", "Series100A", "Series100B", "Series100C", "Series20IDSplit", "Series40ODSplit", "XTO", "XTI", "YorkCustom", "YCAL", "YLAA", "YVAA", "YCIV", "YCUL", "YCAV", "RJ", "RL", "RS", "DS", "CS", "DOAS", "Series20ODSplit", "Premier", "SeriesLX", "All"})
        Me.cmbFamily.Location = New System.Drawing.Point(15, 25)
        Me.cmbFamily.Name = "cmbFamily"
        Me.cmbFamily.Size = New System.Drawing.Size(94, 21)
        Me.cmbFamily.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Unit Family Filter"
        '
        'txtDrawingID
        '
        Me.txtDrawingID.Location = New System.Drawing.Point(12, 213)
        Me.txtDrawingID.Name = "txtDrawingID"
        Me.txtDrawingID.Size = New System.Drawing.Size(450, 20)
        Me.txtDrawingID.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Drawing ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Plain Name"
        '
        'txtPlainName
        '
        Me.txtPlainName.Location = New System.Drawing.Point(12, 252)
        Me.txtPlainName.Name = "txtPlainName"
        Me.txtPlainName.Size = New System.Drawing.Size(450, 20)
        Me.txtPlainName.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Drawing File Name"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(12, 291)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(450, 20)
        Me.txtFileName.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Drawing WMF Name"
        '
        'txtWMFName
        '
        Me.txtWMFName.Location = New System.Drawing.Point(12, 330)
        Me.txtWMFName.Name = "txtWMFName"
        Me.txtWMFName.Size = New System.Drawing.Size(450, 20)
        Me.txtWMFName.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Drawing Path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 369)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(450, 20)
        Me.txtPath.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Drawing Type"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(12, 408)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(450, 20)
        Me.txtType.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Drawing Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 447)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(450, 104)
        Me.txtDescription.TabIndex = 49
        '
        'chkFileValid
        '
        Me.chkFileValid.AutoSize = True
        Me.chkFileValid.Enabled = False
        Me.chkFileValid.Location = New System.Drawing.Point(468, 293)
        Me.chkFileValid.Name = "chkFileValid"
        Me.chkFileValid.Size = New System.Drawing.Size(89, 17)
        Me.chkFileValid.TabIndex = 51
        Me.chkFileValid.Text = "Not Checked"
        Me.chkFileValid.UseVisualStyleBackColor = True
        '
        'chkWMFValid
        '
        Me.chkWMFValid.AutoSize = True
        Me.chkWMFValid.Enabled = False
        Me.chkWMFValid.Location = New System.Drawing.Point(468, 332)
        Me.chkWMFValid.Name = "chkWMFValid"
        Me.chkWMFValid.Size = New System.Drawing.Size(89, 17)
        Me.chkWMFValid.TabIndex = 52
        Me.chkWMFValid.Text = "Not Checked"
        Me.chkWMFValid.UseVisualStyleBackColor = True
        '
        'cmdValidateFiles
        '
        Me.cmdValidateFiles.Location = New System.Drawing.Point(468, 187)
        Me.cmdValidateFiles.Name = "cmdValidateFiles"
        Me.cmdValidateFiles.Size = New System.Drawing.Size(89, 23)
        Me.cmdValidateFiles.TabIndex = 53
        Me.cmdValidateFiles.Text = "Validate Files"
        Me.cmdValidateFiles.UseVisualStyleBackColor = True
        '
        'frmUpdateUnitDrawings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(1442, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdValidateFiles)
        Me.Controls.Add(Me.chkWMFValid)
        Me.Controls.Add(Me.chkFileValid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWMFName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlainName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDrawingID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFamily)
        Me.Controls.Add(Me.lstAvailDwgs)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdateUnitDrawings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unit Drawing Database Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lstAvailDwgs As ListBox
    Friend WithEvents cmbFamily As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDrawingID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlainName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWMFName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents chkFileValid As CheckBox
    Friend WithEvents chkWMFValid As CheckBox
    Friend WithEvents cmdValidateFiles As Button
End Class
