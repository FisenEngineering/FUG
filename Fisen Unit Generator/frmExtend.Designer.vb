<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtend
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgStandard = New System.Windows.Forms.TabPage()
        Me.cmdLoadStandard = New System.Windows.Forms.Button()
        Me.lstStandardDesigns = New System.Windows.Forms.ListBox()
        Me.cmdDoneStandard = New System.Windows.Forms.Button()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optFinishXTO = New System.Windows.Forms.RadioButton()
        Me.optFinishYPAL = New System.Windows.Forms.RadioButton()
        Me.optFinishChampagne = New System.Windows.Forms.RadioButton()
        Me.optFinishGalvanized = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optECIndoor = New System.Windows.Forms.RadioButton()
        Me.optECOutdoor = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgWalls = New System.Windows.Forms.TabPage()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgRoof = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgDoors = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmbProfileText = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExtensionLength = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbExtensionType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optFinish409SS = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optGenConstPostPanel = New System.Windows.Forms.RadioButton()
        Me.optGenConstOmega = New System.Windows.Forms.RadioButton()
        Me.optGenConstHybrid = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optWalls2Inch = New System.Windows.Forms.RadioButton()
        Me.optWalls1Inch = New System.Windows.Forms.RadioButton()
        Me.tpgFloor = New System.Windows.Forms.TabPage()
        Me.tpgBaseRail = New System.Windows.Forms.TabPage()
        Me.tpgWeights = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tpgStandard.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgWalls.SuspendLayout()
        Me.tpgRoof.SuspendLayout()
        Me.tpgDoors.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgStandard)
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgWalls)
        Me.TabControl1.Controls.Add(Me.tpgRoof)
        Me.TabControl1.Controls.Add(Me.tpgFloor)
        Me.TabControl1.Controls.Add(Me.tpgBaseRail)
        Me.TabControl1.Controls.Add(Me.tpgDoors)
        Me.TabControl1.Controls.Add(Me.tpgWeights)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 8
        '
        'tpgStandard
        '
        Me.tpgStandard.Controls.Add(Me.cmdLoadStandard)
        Me.tpgStandard.Controls.Add(Me.lstStandardDesigns)
        Me.tpgStandard.Controls.Add(Me.cmdDoneStandard)
        Me.tpgStandard.Location = New System.Drawing.Point(4, 22)
        Me.tpgStandard.Name = "tpgStandard"
        Me.tpgStandard.Size = New System.Drawing.Size(579, 194)
        Me.tpgStandard.TabIndex = 5
        Me.tpgStandard.Text = "Standard"
        Me.tpgStandard.UseVisualStyleBackColor = True
        '
        'cmdLoadStandard
        '
        Me.cmdLoadStandard.Location = New System.Drawing.Point(296, 83)
        Me.cmdLoadStandard.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLoadStandard.Name = "cmdLoadStandard"
        Me.cmdLoadStandard.Size = New System.Drawing.Size(95, 24)
        Me.cmdLoadStandard.TabIndex = 9
        Me.cmdLoadStandard.Text = "Load Selected"
        Me.cmdLoadStandard.UseVisualStyleBackColor = True
        '
        'lstStandardDesigns
        '
        Me.lstStandardDesigns.FormattingEnabled = True
        Me.lstStandardDesigns.Items.AddRange(New Object() {"Series 40 - Supply Plenum Extension - 58.5 inch", "Custom Cabinet Extention"})
        Me.lstStandardDesigns.Location = New System.Drawing.Point(13, 12)
        Me.lstStandardDesigns.Name = "lstStandardDesigns"
        Me.lstStandardDesigns.Size = New System.Drawing.Size(276, 173)
        Me.lstStandardDesigns.TabIndex = 8
        '
        'cmdDoneStandard
        '
        Me.cmdDoneStandard.Enabled = False
        Me.cmdDoneStandard.Location = New System.Drawing.Point(520, 162)
        Me.cmdDoneStandard.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneStandard.Name = "cmdDoneStandard"
        Me.cmdDoneStandard.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneStandard.TabIndex = 7
        Me.cmdDoneStandard.Text = ">"
        Me.cmdDoneStandard.UseVisualStyleBackColor = True
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.cmbExtensionType)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.cmbExtensionLength)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.cmbProfileText)
        Me.tpgConditions.Controls.Add(Me.GroupBox2)
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 194)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optFinish409SS)
        Me.GroupBox2.Controls.Add(Me.optFinishXTO)
        Me.GroupBox2.Controls.Add(Me.optFinishYPAL)
        Me.GroupBox2.Controls.Add(Me.optFinishChampagne)
        Me.GroupBox2.Controls.Add(Me.optFinishGalvanized)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 48)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exterior Finish"
        '
        'optFinishXTO
        '
        Me.optFinishXTO.AutoSize = True
        Me.optFinishXTO.Location = New System.Drawing.Point(357, 19)
        Me.optFinishXTO.Name = "optFinishXTO"
        Me.optFinishXTO.Size = New System.Drawing.Size(80, 17)
        Me.optFinishXTO.TabIndex = 4
        Me.optFinishXTO.Text = "XTO Brown"
        Me.optFinishXTO.UseVisualStyleBackColor = True
        '
        'optFinishYPAL
        '
        Me.optFinishYPAL.AutoSize = True
        Me.optFinishYPAL.Location = New System.Drawing.Point(266, 19)
        Me.optFinishYPAL.Name = "optFinishYPAL"
        Me.optFinishYPAL.Size = New System.Drawing.Size(85, 17)
        Me.optFinishYPAL.TabIndex = 3
        Me.optFinishYPAL.Text = "YPAL Brown"
        Me.optFinishYPAL.UseVisualStyleBackColor = True
        '
        'optFinishChampagne
        '
        Me.optFinishChampagne.AutoSize = True
        Me.optFinishChampagne.Location = New System.Drawing.Point(117, 19)
        Me.optFinishChampagne.Name = "optFinishChampagne"
        Me.optFinishChampagne.Size = New System.Drawing.Size(143, 17)
        Me.optFinishChampagne.TabIndex = 2
        Me.optFinishChampagne.Text = "UPG/Champagne Brown"
        Me.optFinishChampagne.UseVisualStyleBackColor = True
        '
        'optFinishGalvanized
        '
        Me.optFinishGalvanized.AutoSize = True
        Me.optFinishGalvanized.Checked = True
        Me.optFinishGalvanized.Location = New System.Drawing.Point(6, 19)
        Me.optFinishGalvanized.Name = "optFinishGalvanized"
        Me.optFinishGalvanized.Size = New System.Drawing.Size(105, 17)
        Me.optFinishGalvanized.TabIndex = 1
        Me.optFinishGalvanized.TabStop = True
        Me.optFinishGalvanized.Text = "Galvanized Steel"
        Me.optFinishGalvanized.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optECIndoor)
        Me.GroupBox1.Controls.Add(Me.optECOutdoor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 48)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Environmental Construction"
        '
        'optECIndoor
        '
        Me.optECIndoor.AutoSize = True
        Me.optECIndoor.Location = New System.Drawing.Point(137, 19)
        Me.optECIndoor.Name = "optECIndoor"
        Me.optECIndoor.Size = New System.Drawing.Size(117, 17)
        Me.optECIndoor.TabIndex = 2
        Me.optECIndoor.Text = "Indoor Construction"
        Me.optECIndoor.UseVisualStyleBackColor = True
        '
        'optECOutdoor
        '
        Me.optECOutdoor.AutoSize = True
        Me.optECOutdoor.Checked = True
        Me.optECOutdoor.Location = New System.Drawing.Point(6, 19)
        Me.optECOutdoor.Name = "optECOutdoor"
        Me.optECOutdoor.Size = New System.Drawing.Size(125, 17)
        Me.optECOutdoor.TabIndex = 1
        Me.optECOutdoor.TabStop = True
        Me.optECOutdoor.Text = "Outdoor Construction"
        Me.optECOutdoor.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(520, 162)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgWalls
        '
        Me.tpgWalls.Controls.Add(Me.GroupBox4)
        Me.tpgWalls.Controls.Add(Me.GroupBox3)
        Me.tpgWalls.Controls.Add(Me.cmdDoneOptions)
        Me.tpgWalls.Location = New System.Drawing.Point(4, 22)
        Me.tpgWalls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgWalls.Name = "tpgWalls"
        Me.tpgWalls.Size = New System.Drawing.Size(579, 194)
        Me.tpgWalls.TabIndex = 4
        Me.tpgWalls.Text = "Walls"
        Me.tpgWalls.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(520, 162)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgRoof
        '
        Me.tpgRoof.Controls.Add(Me.Label2)
        Me.tpgRoof.Controls.Add(Me.btnDoneControls)
        Me.tpgRoof.Location = New System.Drawing.Point(4, 22)
        Me.tpgRoof.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgRoof.Name = "tpgRoof"
        Me.tpgRoof.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgRoof.Size = New System.Drawing.Size(579, 194)
        Me.tpgRoof.TabIndex = 1
        Me.tpgRoof.Text = "Roof"
        Me.tpgRoof.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "No Controls Apply to this Modification"
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(520, 162)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgDoors
        '
        Me.tpgDoors.Controls.Add(Me.btnDonePerf)
        Me.tpgDoors.Location = New System.Drawing.Point(4, 22)
        Me.tpgDoors.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgDoors.Name = "tpgDoors"
        Me.tpgDoors.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgDoors.Size = New System.Drawing.Size(579, 194)
        Me.tpgDoors.TabIndex = 2
        Me.tpgDoors.Text = "Doors"
        Me.tpgDoors.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(520, 162)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 14
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Size = New System.Drawing.Size(579, 194)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(116, 241)
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
        Me.btnOK.Location = New System.Drawing.Point(12, 241)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmbProfileText
        '
        Me.cmbProfileText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfileText.FormattingEnabled = True
        Me.cmbProfileText.Location = New System.Drawing.Point(10, 80)
        Me.cmbProfileText.Name = "cmbProfileText"
        Me.cmbProfileText.Size = New System.Drawing.Size(260, 21)
        Me.cmbProfileText.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Profile"
        '
        'cmbExtensionLength
        '
        Me.cmbExtensionLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExtensionLength.FormattingEnabled = True
        Me.cmbExtensionLength.Location = New System.Drawing.Point(276, 80)
        Me.cmbExtensionLength.Name = "cmbExtensionLength"
        Me.cmbExtensionLength.Size = New System.Drawing.Size(69, 21)
        Me.cmbExtensionLength.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Length"
        '
        'cmbExtensionType
        '
        Me.cmbExtensionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExtensionType.FormattingEnabled = True
        Me.cmbExtensionType.Location = New System.Drawing.Point(276, 34)
        Me.cmbExtensionType.Name = "cmbExtensionType"
        Me.cmbExtensionType.Size = New System.Drawing.Size(260, 21)
        Me.cmbExtensionType.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Type"
        '
        'optFinish409SS
        '
        Me.optFinish409SS.AutoSize = True
        Me.optFinish409SS.Location = New System.Drawing.Point(443, 19)
        Me.optFinish409SS.Name = "optFinish409SS"
        Me.optFinish409SS.Size = New System.Drawing.Size(60, 17)
        Me.optFinish409SS.TabIndex = 5
        Me.optFinish409SS.Text = "409 SS"
        Me.optFinish409SS.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optGenConstHybrid)
        Me.GroupBox3.Controls.Add(Me.optGenConstOmega)
        Me.GroupBox3.Controls.Add(Me.optGenConstPostPanel)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 88)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General Construction"
        '
        'optGenConstPostPanel
        '
        Me.optGenConstPostPanel.AutoSize = True
        Me.optGenConstPostPanel.Checked = True
        Me.optGenConstPostPanel.Location = New System.Drawing.Point(6, 19)
        Me.optGenConstPostPanel.Name = "optGenConstPostPanel"
        Me.optGenConstPostPanel.Size = New System.Drawing.Size(135, 17)
        Me.optGenConstPostPanel.TabIndex = 5
        Me.optGenConstPostPanel.TabStop = True
        Me.optGenConstPostPanel.Text = "Formed Post and Panel"
        Me.optGenConstPostPanel.UseVisualStyleBackColor = True
        '
        'optGenConstOmega
        '
        Me.optGenConstOmega.AutoSize = True
        Me.optGenConstOmega.Location = New System.Drawing.Point(6, 42)
        Me.optGenConstOmega.Name = "optGenConstOmega"
        Me.optGenConstOmega.Size = New System.Drawing.Size(192, 17)
        Me.optGenConstOmega.TabIndex = 6
        Me.optGenConstOmega.Text = "Aluminum Channel and Foam Panel"
        Me.optGenConstOmega.UseVisualStyleBackColor = True
        '
        'optGenConstHybrid
        '
        Me.optGenConstHybrid.AutoSize = True
        Me.optGenConstHybrid.Location = New System.Drawing.Point(6, 65)
        Me.optGenConstHybrid.Name = "optGenConstHybrid"
        Me.optGenConstHybrid.Size = New System.Drawing.Size(164, 17)
        Me.optGenConstHybrid.TabIndex = 7
        Me.optGenConstHybrid.Text = "Formed Post and Foam Panel"
        Me.optGenConstHybrid.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optWalls2Inch)
        Me.GroupBox4.Controls.Add(Me.optWalls1Inch)
        Me.GroupBox4.Location = New System.Drawing.Point(235, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 88)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General Construction"
        '
        'optWalls2Inch
        '
        Me.optWalls2Inch.AutoSize = True
        Me.optWalls2Inch.Location = New System.Drawing.Point(6, 42)
        Me.optWalls2Inch.Name = "optWalls2Inch"
        Me.optWalls2Inch.Size = New System.Drawing.Size(65, 17)
        Me.optWalls2Inch.TabIndex = 6
        Me.optWalls2Inch.Text = "2"" Walls"
        Me.optWalls2Inch.UseVisualStyleBackColor = True
        '
        'optWalls1Inch
        '
        Me.optWalls1Inch.AutoSize = True
        Me.optWalls1Inch.Checked = True
        Me.optWalls1Inch.Location = New System.Drawing.Point(6, 19)
        Me.optWalls1Inch.Name = "optWalls1Inch"
        Me.optWalls1Inch.Size = New System.Drawing.Size(65, 17)
        Me.optWalls1Inch.TabIndex = 5
        Me.optWalls1Inch.TabStop = True
        Me.optWalls1Inch.Text = "1"" Walls"
        Me.optWalls1Inch.UseVisualStyleBackColor = True
        '
        'tpgFloor
        '
        Me.tpgFloor.Location = New System.Drawing.Point(4, 22)
        Me.tpgFloor.Name = "tpgFloor"
        Me.tpgFloor.Size = New System.Drawing.Size(579, 194)
        Me.tpgFloor.TabIndex = 6
        Me.tpgFloor.Text = "Floor"
        Me.tpgFloor.UseVisualStyleBackColor = True
        '
        'tpgBaseRail
        '
        Me.tpgBaseRail.Location = New System.Drawing.Point(4, 22)
        Me.tpgBaseRail.Name = "tpgBaseRail"
        Me.tpgBaseRail.Size = New System.Drawing.Size(579, 194)
        Me.tpgBaseRail.TabIndex = 7
        Me.tpgBaseRail.Text = "Base Rail"
        Me.tpgBaseRail.UseVisualStyleBackColor = True
        '
        'tpgWeights
        '
        Me.tpgWeights.Location = New System.Drawing.Point(4, 22)
        Me.tpgWeights.Name = "tpgWeights"
        Me.tpgWeights.Size = New System.Drawing.Size(579, 194)
        Me.tpgWeights.TabIndex = 8
        Me.tpgWeights.Text = "Weights"
        Me.tpgWeights.UseVisualStyleBackColor = True
        '
        'frmExtend
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmExtend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cabinet Extension"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgStandard.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgWalls.ResumeLayout(False)
        Me.tpgRoof.ResumeLayout(False)
        Me.tpgRoof.PerformLayout()
        Me.tpgDoors.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgWalls As TabPage
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgRoof As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgDoors As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents optECIndoor As RadioButton
    Friend WithEvents optECOutdoor As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tpgStandard As TabPage
    Friend WithEvents cmdLoadStandard As Button
    Friend WithEvents lstStandardDesigns As ListBox
    Friend WithEvents cmdDoneStandard As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optFinishXTO As RadioButton
    Friend WithEvents optFinishYPAL As RadioButton
    Friend WithEvents optFinishChampagne As RadioButton
    Friend WithEvents optFinishGalvanized As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProfileText As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbExtensionLength As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbExtensionType As ComboBox
    Friend WithEvents optFinish409SS As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optWalls2Inch As RadioButton
    Friend WithEvents optWalls1Inch As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optGenConstHybrid As RadioButton
    Friend WithEvents optGenConstOmega As RadioButton
    Friend WithEvents optGenConstPostPanel As RadioButton
    Friend WithEvents tpgFloor As TabPage
    Friend WithEvents tpgBaseRail As TabPage
    Friend WithEvents tpgWeights As TabPage
End Class
