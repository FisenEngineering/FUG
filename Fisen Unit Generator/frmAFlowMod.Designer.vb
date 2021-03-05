<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAFlowMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAFlowMod))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgSelection = New System.Windows.Forms.TabPage()
        Me.lstItemsInDB = New System.Windows.Forms.ListBox()
        Me.btnDoneSelection = New System.Windows.Forms.Button()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.chkNoDampers = New System.Windows.Forms.CheckBox()
        Me.chkShipOldDampers = New System.Windows.Forms.CheckBox()
        Me.chkFlanges = New System.Windows.Forms.CheckBox()
        Me.grpDown2Side = New System.Windows.Forms.GroupBox()
        Me.txtSPAdjustSideDisch = New System.Windows.Forms.TextBox()
        Me.chkAdjustESPDown = New System.Windows.Forms.CheckBox()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.cmdLoadMod = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSFanAFlow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgSelection.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.grpDown2Side.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgSelection)
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 220)
        Me.TabControl1.TabIndex = 12
        '
        'tpgSelection
        '
        Me.tpgSelection.Controls.Add(Me.lstItemsInDB)
        Me.tpgSelection.Controls.Add(Me.btnDoneSelection)
        Me.tpgSelection.Location = New System.Drawing.Point(4, 22)
        Me.tpgSelection.Name = "tpgSelection"
        Me.tpgSelection.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgSelection.Size = New System.Drawing.Size(579, 194)
        Me.tpgSelection.TabIndex = 5
        Me.tpgSelection.Text = "Selection"
        Me.tpgSelection.UseVisualStyleBackColor = True
        '
        'lstItemsInDB
        '
        Me.lstItemsInDB.FormattingEnabled = True
        Me.lstItemsInDB.Location = New System.Drawing.Point(6, 6)
        Me.lstItemsInDB.Name = "lstItemsInDB"
        Me.lstItemsInDB.ScrollAlwaysVisible = True
        Me.lstItemsInDB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstItemsInDB.Size = New System.Drawing.Size(500, 173)
        Me.lstItemsInDB.TabIndex = 8
        '
        'btnDoneSelection
        '
        Me.btnDoneSelection.Location = New System.Drawing.Point(513, 153)
        Me.btnDoneSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneSelection.Name = "btnDoneSelection"
        Me.btnDoneSelection.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneSelection.TabIndex = 7
        Me.btnDoneSelection.Text = ">"
        Me.btnDoneSelection.UseVisualStyleBackColor = True
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.txtSFanAFlow)
        Me.tpgConditions.Controls.Add(Me.Label1)
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
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(579, 194)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(4, 173)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 32
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
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
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 194)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
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
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.chkNoDampers)
        Me.tpgPerformance.Controls.Add(Me.chkShipOldDampers)
        Me.tpgPerformance.Controls.Add(Me.chkFlanges)
        Me.tpgPerformance.Controls.Add(Me.grpDown2Side)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 194)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'chkNoDampers
        '
        Me.chkNoDampers.AutoSize = True
        Me.chkNoDampers.Location = New System.Drawing.Point(10, 114)
        Me.chkNoDampers.Name = "chkNoDampers"
        Me.chkNoDampers.Size = New System.Drawing.Size(163, 17)
        Me.chkNoDampers.TabIndex = 20
        Me.chkNoDampers.Text = "No Dampers/Hoods by Fisen"
        Me.chkNoDampers.UseVisualStyleBackColor = True
        Me.chkNoDampers.Visible = False
        '
        'chkShipOldDampers
        '
        Me.chkShipOldDampers.AutoSize = True
        Me.chkShipOldDampers.Location = New System.Drawing.Point(10, 160)
        Me.chkShipOldDampers.Name = "chkShipOldDampers"
        Me.chkShipOldDampers.Size = New System.Drawing.Size(196, 17)
        Me.chkShipOldDampers.TabIndex = 19
        Me.chkShipOldDampers.Text = "Ship Removed Hoods and Dampers"
        Me.chkShipOldDampers.UseVisualStyleBackColor = True
        Me.chkShipOldDampers.Visible = False
        '
        'chkFlanges
        '
        Me.chkFlanges.AutoSize = True
        Me.chkFlanges.Location = New System.Drawing.Point(10, 137)
        Me.chkFlanges.Name = "chkFlanges"
        Me.chkFlanges.Size = New System.Drawing.Size(230, 17)
        Me.chkFlanges.TabIndex = 18
        Me.chkFlanges.Text = "Provide 1"" Duct Flanges for New Openings"
        Me.chkFlanges.UseVisualStyleBackColor = True
        Me.chkFlanges.Visible = False
        '
        'grpDown2Side
        '
        Me.grpDown2Side.Controls.Add(Me.txtSPAdjustSideDisch)
        Me.grpDown2Side.Controls.Add(Me.chkAdjustESPDown)
        Me.grpDown2Side.Location = New System.Drawing.Point(7, 33)
        Me.grpDown2Side.Name = "grpDown2Side"
        Me.grpDown2Side.Size = New System.Drawing.Size(310, 51)
        Me.grpDown2Side.TabIndex = 15
        Me.grpDown2Side.TabStop = False
        Me.grpDown2Side.Text = "Static Adjustment for Conversion"
        Me.grpDown2Side.Visible = False
        '
        'txtSPAdjustSideDisch
        '
        Me.txtSPAdjustSideDisch.Location = New System.Drawing.Point(238, 19)
        Me.txtSPAdjustSideDisch.Name = "txtSPAdjustSideDisch"
        Me.txtSPAdjustSideDisch.Size = New System.Drawing.Size(66, 20)
        Me.txtSPAdjustSideDisch.TabIndex = 1
        '
        'chkAdjustESPDown
        '
        Me.chkAdjustESPDown.AutoSize = True
        Me.chkAdjustESPDown.Location = New System.Drawing.Point(15, 22)
        Me.chkAdjustESPDown.Name = "chkAdjustESPDown"
        Me.chkAdjustESPDown.Size = New System.Drawing.Size(217, 17)
        Me.chkAdjustESPDown.TabIndex = 0
        Me.chkAdjustESPDown.Text = "Adjust ESP Down for Conversion to Side"
        Me.chkAdjustESPDown.UseVisualStyleBackColor = True
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
        Me.Cancel.Location = New System.Drawing.Point(124, 241)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(20, 241)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Enabled = False
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(530, 249)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 18
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(566, 249)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 17
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Enabled = False
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(458, 249)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 86
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Enabled = False
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(494, 249)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 85
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'cmdLoadMod
        '
        Me.cmdLoadMod.Enabled = False
        Me.cmdLoadMod.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.LoadFileIconSmall
        Me.cmdLoadMod.Location = New System.Drawing.Point(422, 249)
        Me.cmdLoadMod.Name = "cmdLoadMod"
        Me.cmdLoadMod.Size = New System.Drawing.Size(30, 29)
        Me.cmdLoadMod.TabIndex = 84
        Me.cmdLoadMod.Text = "L"
        Me.cmdLoadMod.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(227, 261)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 87
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "cfm"
        '
        'txtSFanAFlow
        '
        Me.txtSFanAFlow.Location = New System.Drawing.Point(230, 7)
        Me.txtSFanAFlow.Name = "txtSFanAFlow"
        Me.txtSFanAFlow.Size = New System.Drawing.Size(66, 20)
        Me.txtSFanAFlow.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Any performace is based upon an airflow of:"
        '
        'frmAFlowMod
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.cmdLoadMod)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAFlowMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Air Flow Modification"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgSelection.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.grpDown2Side.ResumeLayout(False)
        Me.grpDown2Side.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgSelection As TabPage
    Friend WithEvents lstItemsInDB As ListBox
    Friend WithEvents btnDoneSelection As Button
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents cmdDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents grpDown2Side As GroupBox
    Friend WithEvents txtSPAdjustSideDisch As TextBox
    Friend WithEvents chkAdjustESPDown As CheckBox
    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents cmdLoadMod As Button
    Friend WithEvents chkShipOldDampers As CheckBox
    Friend WithEvents chkFlanges As CheckBox
    Friend WithEvents chkNoDampers As CheckBox
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSFanAFlow As TextBox
    Friend WithEvents Label1 As Label
End Class
