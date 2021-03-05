<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssociateSequences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssociateSequences))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFIOPCode = New System.Windows.Forms.TextBox()
        Me.txtFIOPPlainName = New System.Windows.Forms.TextBox()
        Me.dgvSOO = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIOPCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SequencePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdDisassociate = New System.Windows.Forms.Button()
        Me.cmdAssociate = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.cmdPasteProjectDir = New System.Windows.Forms.Button()
        Me.cmdChooseProjectDirectory = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.test = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        CType(Me.dgvSOO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(94, 487)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 487)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FIOP Code"
        '
        'txtFIOPCode
        '
        Me.txtFIOPCode.Location = New System.Drawing.Point(77, 6)
        Me.txtFIOPCode.Name = "txtFIOPCode"
        Me.txtFIOPCode.Size = New System.Drawing.Size(74, 20)
        Me.txtFIOPCode.TabIndex = 6
        Me.txtFIOPCode.Text = "890100"
        '
        'txtFIOPPlainName
        '
        Me.txtFIOPPlainName.Location = New System.Drawing.Point(157, 6)
        Me.txtFIOPPlainName.Name = "txtFIOPPlainName"
        Me.txtFIOPPlainName.ReadOnly = True
        Me.txtFIOPPlainName.Size = New System.Drawing.Size(614, 20)
        Me.txtFIOPPlainName.TabIndex = 8
        '
        'dgvSOO
        '
        Me.dgvSOO.AllowUserToAddRows = False
        Me.dgvSOO.AllowUserToDeleteRows = False
        Me.dgvSOO.AllowUserToResizeColumns = False
        Me.dgvSOO.AllowUserToResizeRows = False
        Me.dgvSOO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvSOO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSOO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FIOPCode, Me.ShortName, Me.Version, Me.Description, Me.SequencePath})
        Me.dgvSOO.Location = New System.Drawing.Point(77, 292)
        Me.dgvSOO.Name = "dgvSOO"
        Me.dgvSOO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSOO.Size = New System.Drawing.Size(698, 189)
        Me.dgvSOO.TabIndex = 9
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        Me.ID.Width = 43
        '
        'FIOPCode
        '
        Me.FIOPCode.HeaderText = "FIOP"
        Me.FIOPCode.Name = "FIOPCode"
        Me.FIOPCode.Visible = False
        Me.FIOPCode.Width = 56
        '
        'ShortName
        '
        Me.ShortName.HeaderText = "Short Name"
        Me.ShortName.Name = "ShortName"
        Me.ShortName.ReadOnly = True
        Me.ShortName.Width = 88
        '
        'Version
        '
        Me.Version.HeaderText = "Version"
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.Width = 67
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 85
        '
        'SequencePath
        '
        Me.SequencePath.HeaderText = "Path"
        Me.SequencePath.Name = "SequencePath"
        Me.SequencePath.ReadOnly = True
        Me.SequencePath.Width = 54
        '
        'cmdDisassociate
        '
        Me.cmdDisassociate.Location = New System.Drawing.Point(172, 257)
        Me.cmdDisassociate.Name = "cmdDisassociate"
        Me.cmdDisassociate.Size = New System.Drawing.Size(89, 29)
        Me.cmdDisassociate.TabIndex = 10
        Me.cmdDisassociate.Text = "Disassociate"
        Me.cmdDisassociate.UseVisualStyleBackColor = True
        '
        'cmdAssociate
        '
        Me.cmdAssociate.Location = New System.Drawing.Point(77, 257)
        Me.cmdAssociate.Name = "cmdAssociate"
        Me.cmdAssociate.Size = New System.Drawing.Size(89, 29)
        Me.cmdAssociate.TabIndex = 11
        Me.cmdAssociate.Text = "Associate"
        Me.cmdAssociate.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(77, 32)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(626, 20)
        Me.txtFilePath.TabIndex = 12
        '
        'cmdPasteProjectDir
        '
        Me.cmdPasteProjectDir.Image = CType(resources.GetObject("cmdPasteProjectDir.Image"), System.Drawing.Image)
        Me.cmdPasteProjectDir.Location = New System.Drawing.Point(744, 31)
        Me.cmdPasteProjectDir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPasteProjectDir.Name = "cmdPasteProjectDir"
        Me.cmdPasteProjectDir.Size = New System.Drawing.Size(26, 20)
        Me.cmdPasteProjectDir.TabIndex = 14
        Me.cmdPasteProjectDir.UseVisualStyleBackColor = True
        '
        'cmdChooseProjectDirectory
        '
        Me.cmdChooseProjectDirectory.Location = New System.Drawing.Point(710, 31)
        Me.cmdChooseProjectDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChooseProjectDirectory.Name = "cmdChooseProjectDirectory"
        Me.cmdChooseProjectDirectory.Size = New System.Drawing.Size(26, 20)
        Me.cmdChooseProjectDirectory.TabIndex = 13
        Me.cmdChooseProjectDirectory.Text = "..."
        Me.cmdChooseProjectDirectory.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(77, 110)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(694, 141)
        Me.TextBox3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Preview"
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(447, 487)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(72, 29)
        Me.test.TabIndex = 18
        Me.test.Text = "OK"
        Me.test.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Version"
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(77, 58)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(74, 20)
        Me.txtVersion.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(223, 58)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(547, 20)
        Me.txtDescription.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Short Name"
        '
        'txtShortName
        '
        Me.txtShortName.Location = New System.Drawing.Point(77, 84)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(693, 20)
        Me.txtShortName.TabIndex = 23
        '
        'frmAssociateSequences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtShortName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cmdPasteProjectDir)
        Me.Controls.Add(Me.cmdChooseProjectDirectory)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.cmdAssociate)
        Me.Controls.Add(Me.cmdDisassociate)
        Me.Controls.Add(Me.dgvSOO)
        Me.Controls.Add(Me.txtFIOPPlainName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFIOPCode)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAssociateSequences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Associate/Disassociate Sequence of Operation"
        CType(Me.dgvSOO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFIOPCode As TextBox
    Friend WithEvents txtFIOPPlainName As TextBox
    Friend WithEvents dgvSOO As DataGridView
    Friend WithEvents cmdDisassociate As Button
    Friend WithEvents cmdAssociate As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents cmdPasteProjectDir As Button
    Friend WithEvents cmdChooseProjectDirectory As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents test As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FIOPCode As DataGridViewTextBoxColumn
    Friend WithEvents ShortName As DataGridViewTextBoxColumn
    Friend WithEvents Version As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents SequencePath As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtShortName As TextBox
End Class
