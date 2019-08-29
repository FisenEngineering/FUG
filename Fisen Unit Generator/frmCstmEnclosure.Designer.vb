<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCstmEnclosure
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
        Me.tpgBase = New System.Windows.Forms.TabPage()
        Me.btnDoneSelection = New System.Windows.Forms.Button()
        Me.tpgFloor = New System.Windows.Forms.TabPage()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgWall = New System.Windows.Forms.TabPage()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgRoof = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.tpgDoors = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.optPumpPkgEnc = New System.Windows.Forms.RadioButton()
        Me.optRTUEnc = New System.Windows.Forms.RadioButton()
        Me.optAHUEnc = New System.Windows.Forms.RadioButton()
        Me.chkOutdoorConst = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optBaseStructSteel = New System.Windows.Forms.RadioButton()
        Me.optBaseStructAl = New System.Windows.Forms.RadioButton()
        Me.optBaseFormedSteel = New System.Windows.Forms.RadioButton()
        Me.optBaseMechFormedSteel = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgBase.SuspendLayout()
        Me.tpgFloor.SuspendLayout()
        Me.tpgWall.SuspendLayout()
        Me.tpgRoof.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgDoors.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgBase)
        Me.TabControl1.Controls.Add(Me.tpgFloor)
        Me.TabControl1.Controls.Add(Me.tpgWall)
        Me.TabControl1.Controls.Add(Me.tpgRoof)
        Me.TabControl1.Controls.Add(Me.tpgDoors)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 10
        '
        'tpgBase
        '
        Me.tpgBase.Controls.Add(Me.GroupBox3)
        Me.tpgBase.Controls.Add(Me.GroupBox2)
        Me.tpgBase.Controls.Add(Me.btnDoneSelection)
        Me.tpgBase.Location = New System.Drawing.Point(4, 22)
        Me.tpgBase.Name = "tpgBase"
        Me.tpgBase.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgBase.Size = New System.Drawing.Size(579, 194)
        Me.tpgBase.TabIndex = 5
        Me.tpgBase.Text = "Base"
        Me.tpgBase.UseVisualStyleBackColor = True
        '
        'btnDoneSelection
        '
        Me.btnDoneSelection.Location = New System.Drawing.Point(516, 159)
        Me.btnDoneSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneSelection.Name = "btnDoneSelection"
        Me.btnDoneSelection.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneSelection.TabIndex = 7
        Me.btnDoneSelection.Text = ">"
        Me.btnDoneSelection.UseVisualStyleBackColor = True
        '
        'tpgFloor
        '
        Me.tpgFloor.Controls.Add(Me.btnDoneConditions)
        Me.tpgFloor.Location = New System.Drawing.Point(4, 22)
        Me.tpgFloor.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgFloor.Name = "tpgFloor"
        Me.tpgFloor.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgFloor.Size = New System.Drawing.Size(579, 194)
        Me.tpgFloor.TabIndex = 0
        Me.tpgFloor.Text = "Floor"
        Me.tpgFloor.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgWall
        '
        Me.tpgWall.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgWall.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgWall.Controls.Add(Me.cmdDoneOptions)
        Me.tpgWall.Location = New System.Drawing.Point(4, 22)
        Me.tpgWall.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgWall.Name = "tpgWall"
        Me.tpgWall.Size = New System.Drawing.Size(579, 194)
        Me.tpgWall.TabIndex = 4
        Me.tpgWall.Text = "Walls"
        Me.tpgWall.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(23, 27)
        Me.chkMountEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 10
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(4, 4)
        Me.chkIncludeEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 9
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(513, 153)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgRoof
        '
        Me.tpgRoof.Controls.Add(Me.btnDoneControls)
        Me.tpgRoof.Controls.Add(Me.GroupBox1)
        Me.tpgRoof.Location = New System.Drawing.Point(4, 22)
        Me.tpgRoof.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgRoof.Name = "tpgRoof"
        Me.tpgRoof.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgRoof.Size = New System.Drawing.Size(579, 194)
        Me.tpgRoof.TabIndex = 1
        Me.tpgRoof.Text = "Roof"
        Me.tpgRoof.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(403, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(165, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Unit Control"
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Enabled = False
        Me.optIPU.Location = New System.Drawing.Point(19, 57)
        Me.optIPU.Margin = New System.Windows.Forms.Padding(4)
        Me.optIPU.Name = "optIPU"
        Me.optIPU.Size = New System.Drawing.Size(90, 17)
        Me.optIPU.TabIndex = 1
        Me.optIPU.Text = "IPU Controller"
        Me.optIPU.UseVisualStyleBackColor = True
        '
        'optSE
        '
        Me.optSE.AutoSize = True
        Me.optSE.Checked = True
        Me.optSE.Location = New System.Drawing.Point(19, 25)
        Me.optSE.Margin = New System.Windows.Forms.Padding(4)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 0
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
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
        Me.btnDonePerf.Location = New System.Drawing.Point(513, 153)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 14
        Me.btnDonePerf.Text = ">"
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(579, 194)
        Me.tpgOptions.TabIndex = 6
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 194)
        Me.tpgPerformance.TabIndex = 7
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
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
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(13, 277)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 277)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'optPumpPkgEnc
        '
        Me.optPumpPkgEnc.AutoSize = True
        Me.optPumpPkgEnc.Checked = True
        Me.optPumpPkgEnc.Location = New System.Drawing.Point(220, 286)
        Me.optPumpPkgEnc.Name = "optPumpPkgEnc"
        Me.optPumpPkgEnc.Size = New System.Drawing.Size(148, 17)
        Me.optPumpPkgEnc.TabIndex = 13
        Me.optPumpPkgEnc.TabStop = True
        Me.optPumpPkgEnc.Text = "Pump Package Enclosure"
        Me.optPumpPkgEnc.UseVisualStyleBackColor = True
        '
        'optRTUEnc
        '
        Me.optRTUEnc.AutoSize = True
        Me.optRTUEnc.Location = New System.Drawing.Point(220, 263)
        Me.optRTUEnc.Name = "optRTUEnc"
        Me.optRTUEnc.Size = New System.Drawing.Size(133, 17)
        Me.optRTUEnc.TabIndex = 14
        Me.optRTUEnc.Text = "Rooftop Unit Envelope"
        Me.optRTUEnc.UseVisualStyleBackColor = True
        '
        'optAHUEnc
        '
        Me.optAHUEnc.AutoSize = True
        Me.optAHUEnc.Location = New System.Drawing.Point(220, 240)
        Me.optAHUEnc.Name = "optAHUEnc"
        Me.optAHUEnc.Size = New System.Drawing.Size(152, 17)
        Me.optAHUEnc.TabIndex = 15
        Me.optAHUEnc.Text = "Air Handling Unit Envelope"
        Me.optAHUEnc.UseVisualStyleBackColor = True
        '
        'chkOutdoorConst
        '
        Me.chkOutdoorConst.AutoSize = True
        Me.chkOutdoorConst.Checked = True
        Me.chkOutdoorConst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOutdoorConst.Location = New System.Drawing.Point(17, 235)
        Me.chkOutdoorConst.Name = "chkOutdoorConst"
        Me.chkOutdoorConst.Size = New System.Drawing.Size(126, 17)
        Me.chkOutdoorConst.TabIndex = 16
        Me.chkOutdoorConst.Text = "Outdoor Construction"
        Me.chkOutdoorConst.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optBaseMechFormedSteel)
        Me.GroupBox2.Controls.Add(Me.optBaseFormedSteel)
        Me.GroupBox2.Controls.Add(Me.optBaseStructAl)
        Me.GroupBox2.Controls.Add(Me.optBaseStructSteel)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 110)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Base Rail Materials"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(222, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 110)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'optBaseStructSteel
        '
        Me.optBaseStructSteel.AutoSize = True
        Me.optBaseStructSteel.Checked = True
        Me.optBaseStructSteel.Location = New System.Drawing.Point(6, 19)
        Me.optBaseStructSteel.Name = "optBaseStructSteel"
        Me.optBaseStructSteel.Size = New System.Drawing.Size(137, 17)
        Me.optBaseStructSteel.TabIndex = 10
        Me.optBaseStructSteel.TabStop = True
        Me.optBaseStructSteel.Text = "Welded Structural Steel"
        Me.optBaseStructSteel.UseVisualStyleBackColor = True
        '
        'optBaseStructAl
        '
        Me.optBaseStructAl.AutoSize = True
        Me.optBaseStructAl.Location = New System.Drawing.Point(6, 42)
        Me.optBaseStructAl.Name = "optBaseStructAl"
        Me.optBaseStructAl.Size = New System.Drawing.Size(158, 17)
        Me.optBaseStructAl.TabIndex = 11
        Me.optBaseStructAl.Text = "Welded Structural Aluminum"
        Me.optBaseStructAl.UseVisualStyleBackColor = True
        '
        'optBaseFormedSteel
        '
        Me.optBaseFormedSteel.AutoSize = True
        Me.optBaseFormedSteel.Location = New System.Drawing.Point(6, 65)
        Me.optBaseFormedSteel.Name = "optBaseFormedSteel"
        Me.optBaseFormedSteel.Size = New System.Drawing.Size(127, 17)
        Me.optBaseFormedSteel.TabIndex = 12
        Me.optBaseFormedSteel.Text = "Welded Formed Steel"
        Me.optBaseFormedSteel.UseVisualStyleBackColor = True
        '
        'optBaseMechFormedSteel
        '
        Me.optBaseMechFormedSteel.AutoSize = True
        Me.optBaseMechFormedSteel.Location = New System.Drawing.Point(6, 88)
        Me.optBaseMechFormedSteel.Name = "optBaseMechFormedSteel"
        Me.optBaseMechFormedSteel.Size = New System.Drawing.Size(199, 17)
        Me.optBaseMechFormedSteel.TabIndex = 13
        Me.optBaseMechFormedSteel.Text = "Mechanically Fastened Formed Steel"
        Me.optBaseMechFormedSteel.UseVisualStyleBackColor = True
        '
        'frmCstmEnclosure
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 326)
        Me.Controls.Add(Me.chkOutdoorConst)
        Me.Controls.Add(Me.optAHUEnc)
        Me.Controls.Add(Me.optRTUEnc)
        Me.Controls.Add(Me.optPumpPkgEnc)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCstmEnclosure"
        Me.Text = "Custom Enclosure"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgBase.ResumeLayout(False)
        Me.tpgFloor.ResumeLayout(False)
        Me.tpgWall.ResumeLayout(False)
        Me.tpgWall.PerformLayout()
        Me.tpgRoof.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgDoors.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgBase As TabPage
    Friend WithEvents btnDoneSelection As Button
    Friend WithEvents tpgFloor As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgWall As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgRoof As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents tpgDoors As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents optPumpPkgEnc As RadioButton
    Friend WithEvents optRTUEnc As RadioButton
    Friend WithEvents optAHUEnc As RadioButton
    Friend WithEvents chkOutdoorConst As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optBaseMechFormedSteel As RadioButton
    Friend WithEvents optBaseFormedSteel As RadioButton
    Friend WithEvents optBaseStructAl As RadioButton
    Friend WithEvents optBaseStructSteel As RadioButton
End Class
