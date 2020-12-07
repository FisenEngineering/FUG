<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConstDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCDText = New System.Windows.Forms.TextBox()
        Me.lstNewTitles = New System.Windows.Forms.ListBox()
        Me.cmdAddNewDetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNewAssociation = New System.Windows.Forms.ListBox()
        Me.txtFIOPCode = New System.Windows.Forms.TextBox()
        Me.cmdAddSelectedRow = New System.Windows.Forms.Button()
        Me.dgvExistingDetails = New System.Windows.Forms.DataGridView()
        Me.DetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTitleQ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTextQ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdPoputlateDGV = New System.Windows.Forms.Button()
        Me.cmbCommonDetail = New System.Windows.Forms.ComboBox()
        Me.cmdAddCommon = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPrimaryMod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvExistingDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New Construction Detail(s)"
        '
        'txtCDText
        '
        Me.txtCDText.Location = New System.Drawing.Point(12, 100)
        Me.txtCDText.Multiline = True
        Me.txtCDText.Name = "txtCDText"
        Me.txtCDText.Size = New System.Drawing.Size(776, 92)
        Me.txtCDText.TabIndex = 4
        '
        'lstNewTitles
        '
        Me.lstNewTitles.FormattingEnabled = True
        Me.lstNewTitles.Location = New System.Drawing.Point(12, 25)
        Me.lstNewTitles.Name = "lstNewTitles"
        Me.lstNewTitles.Size = New System.Drawing.Size(728, 69)
        Me.lstNewTitles.TabIndex = 6
        '
        'cmdAddNewDetail
        '
        Me.cmdAddNewDetail.Location = New System.Drawing.Point(746, 51)
        Me.cmdAddNewDetail.Name = "cmdAddNewDetail"
        Me.cmdAddNewDetail.Size = New System.Drawing.Size(39, 23)
        Me.cmdAddNewDetail.TabIndex = 7
        Me.cmdAddNewDetail.Text = "Add"
        Me.cmdAddNewDetail.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Asscociation for Code:"
        '
        'lstNewAssociation
        '
        Me.lstNewAssociation.FormattingEnabled = True
        Me.lstNewAssociation.Location = New System.Drawing.Point(9, 229)
        Me.lstNewAssociation.Name = "lstNewAssociation"
        Me.lstNewAssociation.Size = New System.Drawing.Size(779, 69)
        Me.lstNewAssociation.TabIndex = 10
        '
        'txtFIOPCode
        '
        Me.txtFIOPCode.Location = New System.Drawing.Point(128, 203)
        Me.txtFIOPCode.Name = "txtFIOPCode"
        Me.txtFIOPCode.ReadOnly = True
        Me.txtFIOPCode.Size = New System.Drawing.Size(100, 20)
        Me.txtFIOPCode.TabIndex = 11
        '
        'cmdAddSelectedRow
        '
        Me.cmdAddSelectedRow.Enabled = False
        Me.cmdAddSelectedRow.Location = New System.Drawing.Point(705, 323)
        Me.cmdAddSelectedRow.Name = "cmdAddSelectedRow"
        Me.cmdAddSelectedRow.Size = New System.Drawing.Size(83, 23)
        Me.cmdAddSelectedRow.TabIndex = 12
        Me.cmdAddSelectedRow.Text = "Add Selected"
        Me.cmdAddSelectedRow.UseVisualStyleBackColor = True
        '
        'dgvExistingDetails
        '
        Me.dgvExistingDetails.AllowUserToAddRows = False
        Me.dgvExistingDetails.AllowUserToDeleteRows = False
        Me.dgvExistingDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvExistingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExistingDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailID, Me.DetailTitle, Me.DetailText})
        Me.dgvExistingDetails.Location = New System.Drawing.Point(9, 351)
        Me.dgvExistingDetails.Name = "dgvExistingDetails"
        Me.dgvExistingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExistingDetails.Size = New System.Drawing.Size(779, 150)
        Me.dgvExistingDetails.TabIndex = 14
        '
        'DetailID
        '
        Me.DetailID.HeaderText = "DetailID"
        Me.DetailID.Name = "DetailID"
        Me.DetailID.ReadOnly = True
        Me.DetailID.Visible = False
        Me.DetailID.Width = 70
        '
        'DetailTitle
        '
        Me.DetailTitle.HeaderText = "Title"
        Me.DetailTitle.Name = "DetailTitle"
        Me.DetailTitle.ReadOnly = True
        Me.DetailTitle.Width = 52
        '
        'DetailText
        '
        Me.DetailText.HeaderText = "Detail Text"
        Me.DetailText.Name = "DetailText"
        Me.DetailText.ReadOnly = True
        Me.DetailText.Width = 83
        '
        'txtTitleQ
        '
        Me.txtTitleQ.Location = New System.Drawing.Point(89, 325)
        Me.txtTitleQ.Name = "txtTitleQ"
        Me.txtTitleQ.Size = New System.Drawing.Size(100, 20)
        Me.txtTitleQ.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Title Contains:"
        '
        'txtTextQ
        '
        Me.txtTextQ.Location = New System.Drawing.Point(320, 325)
        Me.txtTextQ.Name = "txtTextQ"
        Me.txtTextQ.Size = New System.Drawing.Size(100, 20)
        Me.txtTextQ.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Text Contains:"
        '
        'cmdPoputlateDGV
        '
        Me.cmdPoputlateDGV.Location = New System.Drawing.Point(426, 323)
        Me.cmdPoputlateDGV.Name = "cmdPoputlateDGV"
        Me.cmdPoputlateDGV.Size = New System.Drawing.Size(55, 23)
        Me.cmdPoputlateDGV.TabIndex = 19
        Me.cmdPoputlateDGV.Text = "Search"
        Me.cmdPoputlateDGV.UseVisualStyleBackColor = True
        '
        'cmbCommonDetail
        '
        Me.cmbCommonDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCommonDetail.FormattingEnabled = True
        Me.cmbCommonDetail.Items.AddRange(New Object() {"Power Wiring RTU", "Power Wiring Chiller", "Power Wiring AHU", "Control Wiring RTU", "Control Wiring Chiller", "Control Wiring AHU", "Unit Mounted Disconnect Evaluation", "Unselected"})
        Me.cmbCommonDetail.Location = New System.Drawing.Point(542, 202)
        Me.cmbCommonDetail.Name = "cmbCommonDetail"
        Me.cmbCommonDetail.Size = New System.Drawing.Size(161, 21)
        Me.cmbCommonDetail.TabIndex = 20
        '
        'cmdAddCommon
        '
        Me.cmdAddCommon.Enabled = False
        Me.cmdAddCommon.Location = New System.Drawing.Point(709, 201)
        Me.cmdAddCommon.Name = "cmdAddCommon"
        Me.cmdAddCommon.Size = New System.Drawing.Size(79, 23)
        Me.cmdAddCommon.TabIndex = 21
        Me.cmdAddCommon.Text = "Add Common"
        Me.cmdAddCommon.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "*OR*"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(111, 507)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 42
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(9, 507)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 41
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPrimaryMod
        '
        Me.txtPrimaryMod.Location = New System.Drawing.Point(313, 203)
        Me.txtPrimaryMod.Name = "txtPrimaryMod"
        Me.txtPrimaryMod.ReadOnly = True
        Me.txtPrimaryMod.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimaryMod.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Primary Mod:"
        '
        'frmConstDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPrimaryMod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdAddCommon)
        Me.Controls.Add(Me.cmbCommonDetail)
        Me.Controls.Add(Me.cmdPoputlateDGV)
        Me.Controls.Add(Me.txtTextQ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitleQ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvExistingDetails)
        Me.Controls.Add(Me.cmdAddSelectedRow)
        Me.Controls.Add(Me.txtFIOPCode)
        Me.Controls.Add(Me.lstNewAssociation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAddNewDetail)
        Me.Controls.Add(Me.lstNewTitles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCDText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConstDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Construction Detail Editor"
        CType(Me.dgvExistingDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtCDText As TextBox
    Friend WithEvents lstNewTitles As ListBox
    Friend WithEvents cmdAddNewDetail As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstNewAssociation As ListBox
    Friend WithEvents txtFIOPCode As TextBox
    Friend WithEvents cmdAddSelectedRow As Button
    Friend WithEvents dgvExistingDetails As DataGridView
    Friend WithEvents txtTitleQ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTextQ As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdPoputlateDGV As Button
    Friend WithEvents cmbCommonDetail As ComboBox
    Friend WithEvents cmdAddCommon As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DetailID As DataGridViewTextBoxColumn
    Friend WithEvents DetailTitle As DataGridViewTextBoxColumn
    Friend WithEvents DetailText As DataGridViewTextBoxColumn
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtPrimaryMod As TextBox
    Friend WithEvents Label6 As Label
End Class
