<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssociateDrawings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssociateDrawings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFIOPType = New System.Windows.Forms.ComboBox()
        Me.optOldCon = New System.Windows.Forms.RadioButton()
        Me.optNewCon = New System.Windows.Forms.RadioButton()
        Me.txtFIOPCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.cmdPasteWMFPath = New System.Windows.Forms.Button()
        Me.cmdChooseProjectDirectory = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPasteWMFPath)
        Me.GroupBox1.Controls.Add(Me.cmdChooseProjectDirectory)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtConPath)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFIOPType)
        Me.GroupBox1.Controls.Add(Me.optOldCon)
        Me.GroupBox1.Controls.Add(Me.optNewCon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Field Connections"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 115)
        Me.DataGridView1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Path:"
        '
        'txtConPath
        '
        Me.txtConPath.Location = New System.Drawing.Point(46, 63)
        Me.txtConPath.Name = "txtConPath"
        Me.txtConPath.Size = New System.Drawing.Size(657, 20)
        Me.txtConPath.TabIndex = 6
        Me.txtConPath.Text = "Connections\xxx.wmf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(242, 37)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(528, 20)
        Me.txtDescription.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type:"
        '
        'cmbFIOPType
        '
        Me.cmbFIOPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFIOPType.FormattingEnabled = True
        Me.cmbFIOPType.Items.AddRange(New Object() {"Controls", "Gas", "Power", "Unselected"})
        Me.cmbFIOPType.Location = New System.Drawing.Point(46, 36)
        Me.cmbFIOPType.Name = "cmbFIOPType"
        Me.cmbFIOPType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFIOPType.TabIndex = 2
        '
        'optOldCon
        '
        Me.optOldCon.AutoSize = True
        Me.optOldCon.Enabled = False
        Me.optOldCon.Location = New System.Drawing.Point(3, 89)
        Me.optOldCon.Name = "optOldCon"
        Me.optOldCon.Size = New System.Drawing.Size(95, 17)
        Me.optOldCon.TabIndex = 1
        Me.optOldCon.Text = "Reuse Existing"
        Me.optOldCon.UseVisualStyleBackColor = True
        '
        'optNewCon
        '
        Me.optNewCon.AutoSize = True
        Me.optNewCon.Checked = True
        Me.optNewCon.Location = New System.Drawing.Point(6, 19)
        Me.optNewCon.Name = "optNewCon"
        Me.optNewCon.Size = New System.Drawing.Size(47, 17)
        Me.optNewCon.TabIndex = 0
        Me.optNewCon.TabStop = True
        Me.optNewCon.Text = "New"
        Me.optNewCon.UseVisualStyleBackColor = True
        '
        'txtFIOPCode
        '
        Me.txtFIOPCode.Location = New System.Drawing.Point(77, 12)
        Me.txtFIOPCode.Name = "txtFIOPCode"
        Me.txtFIOPCode.Size = New System.Drawing.Size(74, 20)
        Me.txtFIOPCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FIOP Code"
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(12, 297)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddItem.TabIndex = 3
        Me.cmdAddItem.Text = "Add"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'cmdPasteWMFPath
        '
        Me.cmdPasteWMFPath.Image = CType(resources.GetObject("cmdPasteWMFPath.Image"), System.Drawing.Image)
        Me.cmdPasteWMFPath.Location = New System.Drawing.Point(744, 62)
        Me.cmdPasteWMFPath.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPasteWMFPath.Name = "cmdPasteWMFPath"
        Me.cmdPasteWMFPath.Size = New System.Drawing.Size(26, 20)
        Me.cmdPasteWMFPath.TabIndex = 7
        Me.cmdPasteWMFPath.UseVisualStyleBackColor = True
        '
        'cmdChooseProjectDirectory
        '
        Me.cmdChooseProjectDirectory.Enabled = False
        Me.cmdChooseProjectDirectory.Location = New System.Drawing.Point(710, 62)
        Me.cmdChooseProjectDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChooseProjectDirectory.Name = "cmdChooseProjectDirectory"
        Me.cmdChooseProjectDirectory.Size = New System.Drawing.Size(26, 20)
        Me.cmdChooseProjectDirectory.TabIndex = 6
        Me.cmdChooseProjectDirectory.Text = "..."
        Me.cmdChooseProjectDirectory.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(116, 468)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 468)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAssociateDrawings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFIOPCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAssociateDrawings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Associate Connection Drawings for New FIOP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbFIOPType As ComboBox
    Friend WithEvents optOldCon As RadioButton
    Friend WithEvents optNewCon As RadioButton
    Friend WithEvents txtFIOPCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents cmdPasteWMFPath As Button
    Friend WithEvents cmdChooseProjectDirectory As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
End Class
