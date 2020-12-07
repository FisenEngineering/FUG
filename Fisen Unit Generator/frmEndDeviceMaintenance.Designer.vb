<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEndDeviceMaintenance
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
        Me.dgvEndDevices = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULCutSheet = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EDCutSheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDCutSheetPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEndDeviceClass = New System.Windows.Forms.ComboBox()
        Me.cmbSensorClass = New System.Windows.Forms.ComboBox()
        Me.optEDTEndDevice = New System.Windows.Forms.RadioButton()
        Me.optEDTSensor = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFIOPCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFIOPCodes = New System.Windows.Forms.DataGridView()
        Me.FIOPCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRequiredED = New System.Windows.Forms.DataGridView()
        Me.txtSelectedFIOP = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdSearchForFIOPs = New System.Windows.Forms.Button()
        Me.RQID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RQTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RQName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEndDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFIOPCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequiredED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEndDevices
        '
        Me.dgvEndDevices.AllowUserToAddRows = False
        Me.dgvEndDevices.AllowUserToDeleteRows = False
        Me.dgvEndDevices.AllowUserToResizeRows = False
        Me.dgvEndDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvEndDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEndDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EDTag, Me.EDName, Me.ULCutSheet, Me.EDCutSheet, Me.EDCutSheetPath})
        Me.dgvEndDevices.Location = New System.Drawing.Point(12, 12)
        Me.dgvEndDevices.MultiSelect = False
        Me.dgvEndDevices.Name = "dgvEndDevices"
        Me.dgvEndDevices.Size = New System.Drawing.Size(776, 150)
        Me.dgvEndDevices.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'EDTag
        '
        Me.EDTag.HeaderText = "Tag"
        Me.EDTag.Name = "EDTag"
        Me.EDTag.Width = 51
        '
        'EDName
        '
        Me.EDName.HeaderText = "End Device"
        Me.EDName.Name = "EDName"
        Me.EDName.Width = 88
        '
        'ULCutSheet
        '
        Me.ULCutSheet.HeaderText = "Upload"
        Me.ULCutSheet.Name = "ULCutSheet"
        Me.ULCutSheet.Width = 47
        '
        'EDCutSheet
        '
        Me.EDCutSheet.HeaderText = "Cut Sheet"
        Me.EDCutSheet.Name = "EDCutSheet"
        Me.EDCutSheet.Width = 79
        '
        'EDCutSheetPath
        '
        Me.EDCutSheetPath.HeaderText = "Path"
        Me.EDCutSheetPath.Name = "EDCutSheetPath"
        Me.EDCutSheetPath.Width = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEndDeviceClass)
        Me.GroupBox1.Controls.Add(Me.cmbSensorClass)
        Me.GroupBox1.Controls.Add(Me.optEDTEndDevice)
        Me.GroupBox1.Controls.Add(Me.optEDTSensor)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "End Device Type"
        '
        'cmbEndDeviceClass
        '
        Me.cmbEndDeviceClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndDeviceClass.FormattingEnabled = True
        Me.cmbEndDeviceClass.Items.AddRange(New Object() {"All", "Actuator", "Actuator - Modulating", "Actuator - On-Off", "Bipolar Ionization", "Contactor", "Contactor - Motor", "Relay", "Relay - Control", "Relay - Control - Coil", "Relay - Overload", "Relay - Power", "Relay - Power - Coil", "Controller", "Switch", "Switch - Level", "Switch - Limit", "UV Lights", "Valve", "Valve - Gas", "Valve - Hydronic", "Valve - Refrigeration", "VFD"})
        Me.cmbEndDeviceClass.Location = New System.Drawing.Point(284, 18)
        Me.cmbEndDeviceClass.Name = "cmbEndDeviceClass"
        Me.cmbEndDeviceClass.Size = New System.Drawing.Size(121, 21)
        Me.cmbEndDeviceClass.TabIndex = 3
        '
        'cmbSensorClass
        '
        Me.cmbSensorClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensorClass.FormattingEnabled = True
        Me.cmbSensorClass.Items.AddRange(New Object() {"All", "Control Relay Contact", "Current Transducer", "Differential Pressure Switch", "Photocell", "Pressure Transducer", "Thermistor", "Thermistor - Averaging", "Thermistor - Bullet Sensor", "Thermistor - Duct", "Thermostat", "Thermostat - Bulb", "Thermostat - Klixon", "Thermostat - Capillary Tube"})
        Me.cmbSensorClass.Location = New System.Drawing.Point(70, 18)
        Me.cmbSensorClass.Name = "cmbSensorClass"
        Me.cmbSensorClass.Size = New System.Drawing.Size(121, 21)
        Me.cmbSensorClass.TabIndex = 2
        '
        'optEDTEndDevice
        '
        Me.optEDTEndDevice.AutoSize = True
        Me.optEDTEndDevice.Location = New System.Drawing.Point(197, 19)
        Me.optEDTEndDevice.Name = "optEDTEndDevice"
        Me.optEDTEndDevice.Size = New System.Drawing.Size(81, 17)
        Me.optEDTEndDevice.TabIndex = 1
        Me.optEDTEndDevice.Text = "End Device"
        Me.optEDTEndDevice.UseVisualStyleBackColor = True
        '
        'optEDTSensor
        '
        Me.optEDTSensor.AutoSize = True
        Me.optEDTSensor.Checked = True
        Me.optEDTSensor.Location = New System.Drawing.Point(6, 19)
        Me.optEDTSensor.Name = "optEDTSensor"
        Me.optEDTSensor.Size = New System.Drawing.Size(58, 17)
        Me.optEDTSensor.TabIndex = 0
        Me.optEDTSensor.TabStop = True
        Me.optEDTSensor.Text = "Sensor"
        Me.optEDTSensor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(675, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add Selected"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFIOPCode
        '
        Me.txtFIOPCode.Location = New System.Drawing.Point(107, 237)
        Me.txtFIOPCode.Name = "txtFIOPCode"
        Me.txtFIOPCode.Size = New System.Drawing.Size(100, 20)
        Me.txtFIOPCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FIOp CodeCode:"
        '
        'dgvFIOPCodes
        '
        Me.dgvFIOPCodes.AllowUserToAddRows = False
        Me.dgvFIOPCodes.AllowUserToDeleteRows = False
        Me.dgvFIOPCodes.AllowUserToOrderColumns = True
        Me.dgvFIOPCodes.AllowUserToResizeColumns = False
        Me.dgvFIOPCodes.AllowUserToResizeRows = False
        Me.dgvFIOPCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFIOPCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFIOPCodes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIOPCode, Me.Description})
        Me.dgvFIOPCodes.Location = New System.Drawing.Point(12, 263)
        Me.dgvFIOPCodes.MultiSelect = False
        Me.dgvFIOPCodes.Name = "dgvFIOPCodes"
        Me.dgvFIOPCodes.RowHeadersVisible = False
        Me.dgvFIOPCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFIOPCodes.Size = New System.Drawing.Size(776, 150)
        Me.dgvFIOPCodes.TabIndex = 4
        '
        'FIOPCode
        '
        Me.FIOPCode.HeaderText = "FIOP"
        Me.FIOPCode.Name = "FIOPCode"
        Me.FIOPCode.ReadOnly = True
        Me.FIOPCode.Width = 56
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'dgvRequiredED
        '
        Me.dgvRequiredED.AllowUserToAddRows = False
        Me.dgvRequiredED.AllowUserToDeleteRows = False
        Me.dgvRequiredED.AllowUserToResizeColumns = False
        Me.dgvRequiredED.AllowUserToResizeRows = False
        Me.dgvRequiredED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRequiredED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequiredED.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RQID, Me.RQTag, Me.RQName})
        Me.dgvRequiredED.Location = New System.Drawing.Point(12, 469)
        Me.dgvRequiredED.MultiSelect = False
        Me.dgvRequiredED.Name = "dgvRequiredED"
        Me.dgvRequiredED.RowHeadersVisible = False
        Me.dgvRequiredED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequiredED.Size = New System.Drawing.Size(776, 150)
        Me.dgvRequiredED.TabIndex = 6
        '
        'txtSelectedFIOP
        '
        Me.txtSelectedFIOP.Location = New System.Drawing.Point(12, 443)
        Me.txtSelectedFIOP.Name = "txtSelectedFIOP"
        Me.txtSelectedFIOP.ReadOnly = True
        Me.txtSelectedFIOP.Size = New System.Drawing.Size(776, 20)
        Me.txtSelectedFIOP.TabIndex = 7
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 625)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 625)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdSearchForFIOPs
        '
        Me.cmdSearchForFIOPs.Location = New System.Drawing.Point(213, 237)
        Me.cmdSearchForFIOPs.Name = "cmdSearchForFIOPs"
        Me.cmdSearchForFIOPs.Size = New System.Drawing.Size(101, 20)
        Me.cmdSearchForFIOPs.TabIndex = 10
        Me.cmdSearchForFIOPs.Text = "Search for FIOPs"
        Me.cmdSearchForFIOPs.UseVisualStyleBackColor = True
        '
        'RQID
        '
        Me.RQID.HeaderText = "ID"
        Me.RQID.Name = "RQID"
        Me.RQID.Visible = False
        Me.RQID.Width = 24
        '
        'RQTag
        '
        Me.RQTag.HeaderText = "Tag"
        Me.RQTag.Name = "RQTag"
        Me.RQTag.Width = 51
        '
        'RQName
        '
        Me.RQName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RQName.HeaderText = "Name"
        Me.RQName.Name = "RQName"
        '
        'frmEndDeviceMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSearchForFIOPs)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSelectedFIOP)
        Me.Controls.Add(Me.dgvRequiredED)
        Me.Controls.Add(Me.dgvFIOPCodes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFIOPCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvEndDevices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEndDeviceMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "End Device Maintenance"
        CType(Me.dgvEndDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFIOPCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequiredED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEndDevices As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEndDeviceClass As ComboBox
    Friend WithEvents cmbSensorClass As ComboBox
    Friend WithEvents optEDTEndDevice As RadioButton
    Friend WithEvents optEDTSensor As RadioButton
    Friend WithEvents txtFIOPCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFIOPCodes As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvRequiredED As DataGridView
    Friend WithEvents txtSelectedFIOP As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EDTag As DataGridViewTextBoxColumn
    Friend WithEvents EDName As DataGridViewTextBoxColumn
    Friend WithEvents ULCutSheet As DataGridViewButtonColumn
    Friend WithEvents EDCutSheet As DataGridViewTextBoxColumn
    Friend WithEvents EDCutSheetPath As DataGridViewTextBoxColumn
    Friend WithEvents cmdSearchForFIOPs As Button
    Friend WithEvents FIOPCode As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents RQID As DataGridViewTextBoxColumn
    Friend WithEvents RQTag As DataGridViewTextBoxColumn
    Friend WithEvents RQName As DataGridViewTextBoxColumn
End Class
