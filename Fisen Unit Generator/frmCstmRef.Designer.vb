﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCstmRef
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCstmRef))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgSelection = New System.Windows.Forms.TabPage()
        Me.cmdAddNewCode = New System.Windows.Forms.Button()
        Me.lstItemsInDB = New System.Windows.Forms.ListBox()
        Me.btnDoneSelection = New System.Windows.Forms.Button()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.cmdAddNewTagALong = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblCurrentCode = New System.Windows.Forms.Label()
        Me.lblCurrentCstmMod = New System.Windows.Forms.Label()
        Me.lstTagAlongs = New System.Windows.Forms.ListBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk30kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.grpAuxPanel = New System.Windows.Forms.GroupBox()
        Me.cmbAuxPanelOpts = New System.Windows.Forms.ComboBox()
        Me.optUseAux = New System.Windows.Forms.RadioButton()
        Me.optNoAux = New System.Windows.Forms.RadioButton()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optOtherControl = New System.Windows.Forms.RadioButton()
        Me.optASE = New System.Windows.Forms.RadioButton()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdScience = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1.SuspendLayout()
        Me.tpgSelection.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpAuxPanel.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(587, 273)
        Me.TabControl1.TabIndex = 5
        '
        'tpgSelection
        '
        Me.tpgSelection.Controls.Add(Me.cmdAddNewCode)
        Me.tpgSelection.Controls.Add(Me.lstItemsInDB)
        Me.tpgSelection.Controls.Add(Me.btnDoneSelection)
        Me.tpgSelection.Location = New System.Drawing.Point(4, 22)
        Me.tpgSelection.Name = "tpgSelection"
        Me.tpgSelection.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgSelection.Size = New System.Drawing.Size(579, 247)
        Me.tpgSelection.TabIndex = 5
        Me.tpgSelection.Text = "Selection"
        Me.tpgSelection.UseVisualStyleBackColor = True
        '
        'cmdAddNewCode
        '
        Me.cmdAddNewCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewCode.Location = New System.Drawing.Point(481, 215)
        Me.cmdAddNewCode.Name = "cmdAddNewCode"
        Me.cmdAddNewCode.Size = New System.Drawing.Size(30, 28)
        Me.cmdAddNewCode.TabIndex = 26
        Me.cmdAddNewCode.Text = "+"
        Me.ToolTip1.SetToolTip(Me.cmdAddNewCode, "Add a new custom code to the database.")
        Me.cmdAddNewCode.UseVisualStyleBackColor = True
        '
        'lstItemsInDB
        '
        Me.lstItemsInDB.FormattingEnabled = True
        Me.lstItemsInDB.Location = New System.Drawing.Point(6, 5)
        Me.lstItemsInDB.Name = "lstItemsInDB"
        Me.lstItemsInDB.ScrollAlwaysVisible = True
        Me.lstItemsInDB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstItemsInDB.Size = New System.Drawing.Size(567, 186)
        Me.lstItemsInDB.TabIndex = 25
        '
        'btnDoneSelection
        '
        Me.btnDoneSelection.Location = New System.Drawing.Point(517, 215)
        Me.btnDoneSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneSelection.Name = "btnDoneSelection"
        Me.btnDoneSelection.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneSelection.TabIndex = 24
        Me.btnDoneSelection.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnDoneSelection, "Process inputs and move to the Conditions tab.")
        Me.btnDoneSelection.UseVisualStyleBackColor = True
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.cmdAddNewTagALong)
        Me.tpgConditions.Controls.Add(Me.lblCount)
        Me.tpgConditions.Controls.Add(Me.lblCurrentCode)
        Me.tpgConditions.Controls.Add(Me.lblCurrentCstmMod)
        Me.tpgConditions.Controls.Add(Me.lstTagAlongs)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 247)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'cmdAddNewTagALong
        '
        Me.cmdAddNewTagALong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewTagALong.Location = New System.Drawing.Point(481, 215)
        Me.cmdAddNewTagALong.Name = "cmdAddNewTagALong"
        Me.cmdAddNewTagALong.Size = New System.Drawing.Size(30, 28)
        Me.cmdAddNewTagALong.TabIndex = 31
        Me.cmdAddNewTagALong.Text = "+"
        Me.cmdAddNewTagALong.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(440, 230)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 27
        Me.lblCount.Text = "Count"
        Me.lblCount.Visible = False
        '
        'lblCurrentCode
        '
        Me.lblCurrentCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCode.Location = New System.Drawing.Point(7, 4)
        Me.lblCurrentCode.Name = "lblCurrentCode"
        Me.lblCurrentCode.Size = New System.Drawing.Size(504, 21)
        Me.lblCurrentCode.TabIndex = 26
        Me.lblCurrentCode.Text = "Current Code"
        '
        'lblCurrentCstmMod
        '
        Me.lblCurrentCstmMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCstmMod.Location = New System.Drawing.Point(7, 25)
        Me.lblCurrentCstmMod.Name = "lblCurrentCstmMod"
        Me.lblCurrentCstmMod.Size = New System.Drawing.Size(504, 42)
        Me.lblCurrentCstmMod.TabIndex = 25
        Me.lblCurrentCstmMod.Text = "Current Option"
        '
        'lstTagAlongs
        '
        Me.lstTagAlongs.FormattingEnabled = True
        Me.lstTagAlongs.Location = New System.Drawing.Point(7, 92)
        Me.lstTagAlongs.Name = "lstTagAlongs"
        Me.lstTagAlongs.ScrollAlwaysVisible = True
        Me.lstTagAlongs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTagAlongs.Size = New System.Drawing.Size(565, 108)
        Me.lstTagAlongs.TabIndex = 24
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(517, 215)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnDoneConditions, "Process inputs and move to the Options tab.")
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk30kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.grpAuxPanel)
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Size = New System.Drawing.Size(579, 247)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk30kASCCRBase
        '
        Me.chk30kASCCRBase.AutoSize = True
        Me.chk30kASCCRBase.Location = New System.Drawing.Point(8, 202)
        Me.chk30kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk30kASCCRBase.Name = "chk30kASCCRBase"
        Me.chk30kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk30kASCCRBase.TabIndex = 34
        Me.chk30kASCCRBase.Text = "Base\Fisen Modified Unit is 30kA SCCR"
        Me.chk30kASCCRBase.UseVisualStyleBackColor = True
        '
        'grpAuxPanel
        '
        Me.grpAuxPanel.Controls.Add(Me.cmbAuxPanelOpts)
        Me.grpAuxPanel.Controls.Add(Me.optUseAux)
        Me.grpAuxPanel.Controls.Add(Me.optNoAux)
        Me.grpAuxPanel.Location = New System.Drawing.Point(8, 55)
        Me.grpAuxPanel.Name = "grpAuxPanel"
        Me.grpAuxPanel.Size = New System.Drawing.Size(214, 105)
        Me.grpAuxPanel.TabIndex = 33
        Me.grpAuxPanel.TabStop = False
        Me.grpAuxPanel.Text = "Auxilary Control Panel"
        '
        'cmbAuxPanelOpts
        '
        Me.cmbAuxPanelOpts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuxPanelOpts.FormattingEnabled = True
        Me.cmbAuxPanelOpts.Location = New System.Drawing.Point(6, 65)
        Me.cmbAuxPanelOpts.Name = "cmbAuxPanelOpts"
        Me.cmbAuxPanelOpts.Size = New System.Drawing.Size(202, 21)
        Me.cmbAuxPanelOpts.TabIndex = 29
        '
        'optUseAux
        '
        Me.optUseAux.AutoSize = True
        Me.optUseAux.Location = New System.Drawing.Point(6, 42)
        Me.optUseAux.Name = "optUseAux"
        Me.optUseAux.Size = New System.Drawing.Size(149, 17)
        Me.optUseAux.TabIndex = 1
        Me.optUseAux.TabStop = True
        Me.optUseAux.Text = "Use Auxilary Control Panel"
        Me.optUseAux.UseVisualStyleBackColor = True
        '
        'optNoAux
        '
        Me.optNoAux.AutoSize = True
        Me.optNoAux.Checked = True
        Me.optNoAux.Location = New System.Drawing.Point(6, 19)
        Me.optNoAux.Name = "optNoAux"
        Me.optNoAux.Size = New System.Drawing.Size(51, 17)
        Me.optNoAux.TabIndex = 0
        Me.optNoAux.TabStop = True
        Me.optNoAux.Text = "None"
        Me.optNoAux.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(8, 173)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 32
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(27, 31)
        Me.chkMountEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 26
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(8, 8)
        Me.chkIncludeEquipmentTouch.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 25
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(517, 215)
        Me.btnDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnDoneOptions, "Process inputs and move to the Controls tab.")
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox1)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 247)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optOtherControl)
        Me.GroupBox1.Controls.Add(Me.optASE)
        Me.GroupBox1.Controls.Add(Me.optIPU)
        Me.GroupBox1.Controls.Add(Me.optSE)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(140, 136)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Unit Control"
        '
        'optOtherControl
        '
        Me.optOtherControl.AutoSize = True
        Me.optOtherControl.Enabled = False
        Me.optOtherControl.Location = New System.Drawing.Point(8, 110)
        Me.optOtherControl.Margin = New System.Windows.Forms.Padding(4)
        Me.optOtherControl.Name = "optOtherControl"
        Me.optOtherControl.Size = New System.Drawing.Size(51, 17)
        Me.optOtherControl.TabIndex = 4
        Me.optOtherControl.Text = "Other"
        Me.optOtherControl.UseVisualStyleBackColor = True
        '
        'optASE
        '
        Me.optASE.AutoSize = True
        Me.optASE.Enabled = False
        Me.optASE.Location = New System.Drawing.Point(8, 81)
        Me.optASE.Margin = New System.Windows.Forms.Padding(4)
        Me.optASE.Name = "optASE"
        Me.optASE.Size = New System.Drawing.Size(93, 17)
        Me.optASE.TabIndex = 3
        Me.optASE.Text = "ASE Controller"
        Me.optASE.UseVisualStyleBackColor = True
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Enabled = False
        Me.optIPU.Location = New System.Drawing.Point(8, 52)
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
        Me.optSE.Enabled = False
        Me.optSE.Location = New System.Drawing.Point(8, 23)
        Me.optSE.Margin = New System.Windows.Forms.Padding(4)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 0
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(517, 215)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnDoneControls, "Process inputs and move to the Performance tab.")
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 247)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(517, 215)
        Me.btnDonePerf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePerf.Name = "btnDonePerf"
        Me.btnDonePerf.Size = New System.Drawing.Size(55, 28)
        Me.btnDonePerf.TabIndex = 25
        Me.btnDonePerf.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnDonePerf, "Process inputs and enable the OK Button.")
        Me.btnDonePerf.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(4)
        Me.DebugPage.Size = New System.Drawing.Size(579, 247)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 294)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.Cancel, "Choosing Cancel will abort the program.")
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(13, 294)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.ToolTip1.SetToolTip(Me.btnOK, "OK enables when you have completed all tabs.")
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(220, 314)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 20
        Me.chkWriteHistory.Text = "Write History"
        Me.ToolTip1.SetToolTip(Me.chkWriteHistory, "Uncheck to inhibit writing this modification to the history logs.")
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        Me.chkWriteHistory.Visible = False
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(530, 293)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.cmdViewHistory, "Launch a window showing history for this modification.")
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(566, 293)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.cmdDesignCautions, "Display the design cautions on record for this modification.")
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdScience
        '
        Me.cmdScience.Image = Global.Fisen_Unit_Generator.My.Resources.Resources.Science2
        Me.cmdScience.Location = New System.Drawing.Point(458, 292)
        Me.cmdScience.Name = "cmdScience"
        Me.cmdScience.Size = New System.Drawing.Size(30, 29)
        Me.cmdScience.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.cmdScience, "Science!")
        Me.cmdScience.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(494, 292)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.cmdFIOPPreview, "Preview FIOp page for this modification.")
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(612, 22)
        Me.StatusStrip1.TabIndex = 78
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmCstmRef
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(612, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdScience)
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCstmRef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Refrigeration"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgSelection.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpAuxPanel.ResumeLayout(False)
        Me.grpAuxPanel.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
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
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDonePerf As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lstTagAlongs As ListBox
    Friend WithEvents lblCurrentCstmMod As Label
    Friend WithEvents lblCurrentCode As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents grpAuxPanel As GroupBox
    Friend WithEvents cmbAuxPanelOpts As ComboBox
    Friend WithEvents optUseAux As RadioButton
    Friend WithEvents optNoAux As RadioButton
    Friend WithEvents optASE As RadioButton
    Friend WithEvents chk30kASCCRBase As CheckBox
    Friend WithEvents cmdAddNewCode As Button
    Friend WithEvents cmdScience As Button
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents cmdAddNewTagALong As Button
    Friend WithEvents optOtherControl As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
