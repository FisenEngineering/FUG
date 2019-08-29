<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHumid
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
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.cmdDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.btnDonePerf = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkDispersionTubes = New System.Windows.Forms.CheckBox()
        Me.grpTubes = New System.Windows.Forms.GroupBox()
        Me.optTubesFisenProvInst = New System.Windows.Forms.RadioButton()
        Me.optTubesFieldProvFieldInst = New System.Windows.Forms.RadioButton()
        Me.optTubesFisenProvFieldInst = New System.Windows.Forms.RadioButton()
        Me.grpSteamConditions = New System.Windows.Forms.GroupBox()
        Me.chkAtmospheric = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSteamCap = New System.Windows.Forms.TextBox()
        Me.txtSteamPressure = New System.Windows.Forms.TextBox()
        Me.txtStaticBudget = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optDrainPanStainless = New System.Windows.Forms.RadioButton()
        Me.OptDrainPanGalv = New System.Windows.Forms.RadioButton()
        Me.OptDrainPanNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optControlsFieldProvidedFisenInstalled = New System.Windows.Forms.RadioButton()
        Me.optControlsFisen = New System.Windows.Forms.RadioButton()
        Me.optControlsNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optTrapInteralProvisions = New System.Windows.Forms.RadioButton()
        Me.optTrapExternal = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optCutsFisenSide = New System.Windows.Forms.RadioButton()
        Me.optCutsField = New System.Windows.Forms.RadioButton()
        Me.optCutsFisenBottom = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.chkSafeNone = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optOppositeSideDrain = New System.Windows.Forms.RadioButton()
        Me.optSameSideDrain = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.grpTubes.SuspendLayout()
        Me.grpSteamConditions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(14, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 228)
        Me.TabControl1.TabIndex = 8
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.TextBox5)
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.TextBox4)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.txtStaticBudget)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.grpSteamConditions)
        Me.tpgConditions.Controls.Add(Me.chkDispersionTubes)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgConditions.Size = New System.Drawing.Size(579, 202)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(520, 166)
        Me.btnDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneConditions.TabIndex = 6
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.GroupBox6)
        Me.tpgOptions.Controls.Add(Me.GroupBox5)
        Me.tpgOptions.Controls.Add(Me.GroupBox3)
        Me.tpgOptions.Controls.Add(Me.grpTubes)
        Me.tpgOptions.Controls.Add(Me.cmdDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(579, 202)
        Me.tpgOptions.TabIndex = 4
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'cmdDoneOptions
        '
        Me.cmdDoneOptions.Location = New System.Drawing.Point(520, 166)
        Me.cmdDoneOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneOptions.Name = "cmdDoneOptions"
        Me.cmdDoneOptions.Size = New System.Drawing.Size(55, 28)
        Me.cmdDoneOptions.TabIndex = 8
        Me.cmdDoneOptions.Text = ">"
        Me.cmdDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox7)
        Me.tpgControls.Controls.Add(Me.GroupBox4)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgControls.Size = New System.Drawing.Size(579, 202)
        Me.tpgControls.TabIndex = 1
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(520, 166)
        Me.btnDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(55, 28)
        Me.btnDoneControls.TabIndex = 7
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.btnDonePerf)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Padding = New System.Windows.Forms.Padding(4)
        Me.tpgPerformance.Size = New System.Drawing.Size(579, 202)
        Me.tpgPerformance.TabIndex = 2
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerf
        '
        Me.btnDonePerf.Location = New System.Drawing.Point(520, 166)
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
        Me.Cancel.Location = New System.Drawing.Point(117, 249)
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
        Me.btnOK.Location = New System.Drawing.Point(13, 249)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkDispersionTubes
        '
        Me.chkDispersionTubes.AutoSize = True
        Me.chkDispersionTubes.Location = New System.Drawing.Point(7, 7)
        Me.chkDispersionTubes.Name = "chkDispersionTubes"
        Me.chkDispersionTubes.Size = New System.Drawing.Size(108, 17)
        Me.chkDispersionTubes.TabIndex = 7
        Me.chkDispersionTubes.Text = "Dispersion Tubes"
        Me.chkDispersionTubes.UseVisualStyleBackColor = True
        '
        'grpTubes
        '
        Me.grpTubes.Controls.Add(Me.optTubesFisenProvFieldInst)
        Me.grpTubes.Controls.Add(Me.optTubesFieldProvFieldInst)
        Me.grpTubes.Controls.Add(Me.optTubesFisenProvInst)
        Me.grpTubes.Enabled = False
        Me.grpTubes.Location = New System.Drawing.Point(13, 12)
        Me.grpTubes.Name = "grpTubes"
        Me.grpTubes.Size = New System.Drawing.Size(227, 94)
        Me.grpTubes.TabIndex = 9
        Me.grpTubes.TabStop = False
        Me.grpTubes.Text = "Dispersion Tubes"
        '
        'optTubesFisenProvInst
        '
        Me.optTubesFisenProvInst.AutoSize = True
        Me.optTubesFisenProvInst.Checked = True
        Me.optTubesFisenProvInst.Location = New System.Drawing.Point(6, 19)
        Me.optTubesFisenProvInst.Name = "optTubesFisenProvInst"
        Me.optTubesFisenProvInst.Size = New System.Drawing.Size(145, 17)
        Me.optTubesFisenProvInst.TabIndex = 10
        Me.optTubesFisenProvInst.TabStop = True
        Me.optTubesFisenProvInst.Text = "Fisen Provided / Installed"
        Me.optTubesFisenProvInst.UseVisualStyleBackColor = True
        '
        'optTubesFieldProvFieldInst
        '
        Me.optTubesFieldProvFieldInst.AutoSize = True
        Me.optTubesFieldProvFieldInst.Location = New System.Drawing.Point(6, 42)
        Me.optTubesFieldProvFieldInst.Name = "optTubesFieldProvFieldInst"
        Me.optTubesFieldProvFieldInst.Size = New System.Drawing.Size(170, 17)
        Me.optTubesFieldProvFieldInst.TabIndex = 11
        Me.optTubesFieldProvFieldInst.Text = "Field Provided / Fisen Installed"
        Me.optTubesFieldProvFieldInst.UseVisualStyleBackColor = True
        '
        'optTubesFisenProvFieldInst
        '
        Me.optTubesFisenProvFieldInst.AutoSize = True
        Me.optTubesFisenProvFieldInst.Location = New System.Drawing.Point(6, 65)
        Me.optTubesFisenProvFieldInst.Name = "optTubesFisenProvFieldInst"
        Me.optTubesFisenProvFieldInst.Size = New System.Drawing.Size(170, 17)
        Me.optTubesFisenProvFieldInst.TabIndex = 12
        Me.optTubesFisenProvFieldInst.Text = "Fisen Provided / Field Installed"
        Me.optTubesFisenProvFieldInst.UseVisualStyleBackColor = True
        '
        'grpSteamConditions
        '
        Me.grpSteamConditions.Controls.Add(Me.txtSteamPressure)
        Me.grpSteamConditions.Controls.Add(Me.txtSteamCap)
        Me.grpSteamConditions.Controls.Add(Me.Label2)
        Me.grpSteamConditions.Controls.Add(Me.Label1)
        Me.grpSteamConditions.Controls.Add(Me.chkAtmospheric)
        Me.grpSteamConditions.Enabled = False
        Me.grpSteamConditions.Location = New System.Drawing.Point(7, 30)
        Me.grpSteamConditions.Name = "grpSteamConditions"
        Me.grpSteamConditions.Size = New System.Drawing.Size(200, 100)
        Me.grpSteamConditions.TabIndex = 8
        Me.grpSteamConditions.TabStop = False
        Me.grpSteamConditions.Text = "Steam Requirements"
        '
        'chkAtmospheric
        '
        Me.chkAtmospheric.AutoSize = True
        Me.chkAtmospheric.Location = New System.Drawing.Point(6, 35)
        Me.chkAtmospheric.Name = "chkAtmospheric"
        Me.chkAtmospheric.Size = New System.Drawing.Size(84, 17)
        Me.chkAtmospheric.TabIndex = 8
        Me.chkAtmospheric.Text = "Atmospheric"
        Me.chkAtmospheric.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Capacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Pressure"
        '
        'txtSteamCap
        '
        Me.txtSteamCap.Location = New System.Drawing.Point(60, 16)
        Me.txtSteamCap.Name = "txtSteamCap"
        Me.txtSteamCap.Size = New System.Drawing.Size(63, 20)
        Me.txtSteamCap.TabIndex = 9
        '
        'txtSteamPressure
        '
        Me.txtSteamPressure.Location = New System.Drawing.Point(75, 52)
        Me.txtSteamPressure.Name = "txtSteamPressure"
        Me.txtSteamPressure.Size = New System.Drawing.Size(63, 20)
        Me.txtSteamPressure.TabIndex = 11
        '
        'txtStaticBudget
        '
        Me.txtStaticBudget.Location = New System.Drawing.Point(505, 7)
        Me.txtStaticBudget.Name = "txtStaticBudget"
        Me.txtStaticBudget.Size = New System.Drawing.Size(63, 20)
        Me.txtStaticBudget.TabIndex = 13
        Me.txtStaticBudget.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Static Pressure Budget"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(505, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 20)
        Me.TextBox4.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "EAT db"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(505, 59)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(63, 20)
        Me.TextBox5.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "EARH"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optDrainPanStainless)
        Me.GroupBox3.Controls.Add(Me.OptDrainPanGalv)
        Me.GroupBox3.Controls.Add(Me.OptDrainPanNone)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(102, 94)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Drain Pan"
        '
        'optDrainPanStainless
        '
        Me.optDrainPanStainless.AutoSize = True
        Me.optDrainPanStainless.Location = New System.Drawing.Point(6, 65)
        Me.optDrainPanStainless.Name = "optDrainPanStainless"
        Me.optDrainPanStainless.Size = New System.Drawing.Size(94, 17)
        Me.optDrainPanStainless.TabIndex = 12
        Me.optDrainPanStainless.Text = "Stainless Steel"
        Me.optDrainPanStainless.UseVisualStyleBackColor = True
        '
        'OptDrainPanGalv
        '
        Me.OptDrainPanGalv.AutoSize = True
        Me.OptDrainPanGalv.Location = New System.Drawing.Point(6, 42)
        Me.OptDrainPanGalv.Name = "OptDrainPanGalv"
        Me.OptDrainPanGalv.Size = New System.Drawing.Size(78, 17)
        Me.OptDrainPanGalv.TabIndex = 11
        Me.OptDrainPanGalv.Text = "Galvanized"
        Me.OptDrainPanGalv.UseVisualStyleBackColor = True
        '
        'OptDrainPanNone
        '
        Me.OptDrainPanNone.AutoSize = True
        Me.OptDrainPanNone.Checked = True
        Me.OptDrainPanNone.Location = New System.Drawing.Point(6, 19)
        Me.OptDrainPanNone.Name = "OptDrainPanNone"
        Me.OptDrainPanNone.Size = New System.Drawing.Size(51, 17)
        Me.OptDrainPanNone.TabIndex = 10
        Me.OptDrainPanNone.TabStop = True
        Me.OptDrainPanNone.Text = "None"
        Me.OptDrainPanNone.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optControlsFieldProvidedFisenInstalled)
        Me.GroupBox4.Controls.Add(Me.optControlsFisen)
        Me.GroupBox4.Controls.Add(Me.optControlsNone)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(179, 94)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scope"
        '
        'optControlsFieldProvidedFisenInstalled
        '
        Me.optControlsFieldProvidedFisenInstalled.AutoSize = True
        Me.optControlsFieldProvidedFisenInstalled.Location = New System.Drawing.Point(6, 65)
        Me.optControlsFieldProvidedFisenInstalled.Name = "optControlsFieldProvidedFisenInstalled"
        Me.optControlsFieldProvidedFisenInstalled.Size = New System.Drawing.Size(170, 17)
        Me.optControlsFieldProvidedFisenInstalled.TabIndex = 12
        Me.optControlsFieldProvidedFisenInstalled.Text = "Field Provided / Fisen Installed"
        Me.optControlsFieldProvidedFisenInstalled.UseVisualStyleBackColor = True
        '
        'optControlsFisen
        '
        Me.optControlsFisen.AutoSize = True
        Me.optControlsFisen.Location = New System.Drawing.Point(6, 42)
        Me.optControlsFisen.Name = "optControlsFisen"
        Me.optControlsFisen.Size = New System.Drawing.Size(95, 17)
        Me.optControlsFisen.TabIndex = 11
        Me.optControlsFisen.Text = "Fisen Provided"
        Me.optControlsFisen.UseVisualStyleBackColor = True
        '
        'optControlsNone
        '
        Me.optControlsNone.AutoSize = True
        Me.optControlsNone.Checked = True
        Me.optControlsNone.Location = New System.Drawing.Point(6, 19)
        Me.optControlsNone.Name = "optControlsNone"
        Me.optControlsNone.Size = New System.Drawing.Size(51, 17)
        Me.optControlsNone.TabIndex = 10
        Me.optControlsNone.TabStop = True
        Me.optControlsNone.Text = "None"
        Me.optControlsNone.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optTrapInteralProvisions)
        Me.GroupBox5.Controls.Add(Me.optTrapExternal)
        Me.GroupBox5.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(102, 71)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Trap Provisions"
        '
        'optTrapInteralProvisions
        '
        Me.optTrapInteralProvisions.AutoSize = True
        Me.optTrapInteralProvisions.Location = New System.Drawing.Point(6, 42)
        Me.optTrapInteralProvisions.Name = "optTrapInteralProvisions"
        Me.optTrapInteralProvisions.Size = New System.Drawing.Size(60, 17)
        Me.optTrapInteralProvisions.TabIndex = 11
        Me.optTrapInteralProvisions.Text = "Internal"
        Me.optTrapInteralProvisions.UseVisualStyleBackColor = True
        '
        'optTrapExternal
        '
        Me.optTrapExternal.AutoSize = True
        Me.optTrapExternal.Checked = True
        Me.optTrapExternal.Location = New System.Drawing.Point(6, 19)
        Me.optTrapExternal.Name = "optTrapExternal"
        Me.optTrapExternal.Size = New System.Drawing.Size(51, 17)
        Me.optTrapExternal.TabIndex = 10
        Me.optTrapExternal.TabStop = True
        Me.optTrapExternal.Text = "None"
        Me.optTrapExternal.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optCutsFisenBottom)
        Me.GroupBox6.Controls.Add(Me.optCutsFisenSide)
        Me.GroupBox6.Controls.Add(Me.optCutsField)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(102, 82)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Connection Cuts"
        '
        'optCutsFisenSide
        '
        Me.optCutsFisenSide.AutoSize = True
        Me.optCutsFisenSide.Location = New System.Drawing.Point(6, 39)
        Me.optCutsFisenSide.Name = "optCutsFisenSide"
        Me.optCutsFisenSide.Size = New System.Drawing.Size(74, 17)
        Me.optCutsFisenSide.TabIndex = 11
        Me.optCutsFisenSide.Text = "Fisen Side"
        Me.optCutsFisenSide.UseVisualStyleBackColor = True
        '
        'optCutsField
        '
        Me.optCutsField.AutoSize = True
        Me.optCutsField.Checked = True
        Me.optCutsField.Location = New System.Drawing.Point(6, 16)
        Me.optCutsField.Name = "optCutsField"
        Me.optCutsField.Size = New System.Drawing.Size(47, 17)
        Me.optCutsField.TabIndex = 10
        Me.optCutsField.TabStop = True
        Me.optCutsField.Text = "Field"
        Me.optCutsField.UseVisualStyleBackColor = True
        '
        'optCutsFisenBottom
        '
        Me.optCutsFisenBottom.AutoSize = True
        Me.optCutsFisenBottom.Location = New System.Drawing.Point(6, 62)
        Me.optCutsFisenBottom.Name = "optCutsFisenBottom"
        Me.optCutsFisenBottom.Size = New System.Drawing.Size(86, 17)
        Me.optCutsFisenBottom.TabIndex = 12
        Me.optCutsFisenBottom.Text = "Fisen Bottom"
        Me.optCutsFisenBottom.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkSafeNone)
        Me.GroupBox7.Controls.Add(Me.CheckBox6)
        Me.GroupBox7.Controls.Add(Me.CheckBox5)
        Me.GroupBox7.Controls.Add(Me.CheckBox4)
        Me.GroupBox7.Controls.Add(Me.CheckBox3)
        Me.GroupBox7.Location = New System.Drawing.Point(389, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(179, 139)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Safeties"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Fan Interlock"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 43)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "Mechanical Cool Interlock"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 66)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox5.TabIndex = 2
        Me.CheckBox5.Text = "High Limit"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(6, 89)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox6.TabIndex = 3
        Me.CheckBox6.Text = "Drain Pan Overflow"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'chkSafeNone
        '
        Me.chkSafeNone.AutoSize = True
        Me.chkSafeNone.Checked = True
        Me.chkSafeNone.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSafeNone.Location = New System.Drawing.Point(6, 112)
        Me.chkSafeNone.Name = "chkSafeNone"
        Me.chkSafeNone.Size = New System.Drawing.Size(52, 17)
        Me.chkSafeNone.TabIndex = 4
        Me.chkSafeNone.Text = "None"
        Me.chkSafeNone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optOppositeSideDrain)
        Me.GroupBox1.Controls.Add(Me.optSameSideDrain)
        Me.GroupBox1.Location = New System.Drawing.Point(121, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 82)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condensate Return"
        '
        'optOppositeSideDrain
        '
        Me.optOppositeSideDrain.AutoSize = True
        Me.optOppositeSideDrain.Location = New System.Drawing.Point(6, 39)
        Me.optOppositeSideDrain.Name = "optOppositeSideDrain"
        Me.optOppositeSideDrain.Size = New System.Drawing.Size(91, 17)
        Me.optOppositeSideDrain.TabIndex = 12
        Me.optOppositeSideDrain.Text = "Opposite Side"
        Me.optOppositeSideDrain.UseVisualStyleBackColor = True
        '
        'optSameSideDrain
        '
        Me.optSameSideDrain.AutoSize = True
        Me.optSameSideDrain.Checked = True
        Me.optSameSideDrain.Location = New System.Drawing.Point(6, 16)
        Me.optSameSideDrain.Name = "optSameSideDrain"
        Me.optSameSideDrain.Size = New System.Drawing.Size(76, 17)
        Me.optSameSideDrain.TabIndex = 10
        Me.optSameSideDrain.TabStop = True
        Me.optSameSideDrain.Text = "Same Side"
        Me.optSameSideDrain.UseVisualStyleBackColor = True
        '
        'frmHumid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(614, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHumid"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Humidification"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgControls.ResumeLayout(False)
        Me.tpgPerformance.ResumeLayout(False)
        Me.grpTubes.ResumeLayout(False)
        Me.grpTubes.PerformLayout()
        Me.grpSteamConditions.ResumeLayout(False)
        Me.grpSteamConditions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
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
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStaticBudget As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpSteamConditions As GroupBox
    Friend WithEvents txtSteamPressure As TextBox
    Friend WithEvents txtSteamCap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAtmospheric As CheckBox
    Friend WithEvents chkDispersionTubes As CheckBox
    Friend WithEvents grpTubes As GroupBox
    Friend WithEvents optTubesFisenProvFieldInst As RadioButton
    Friend WithEvents optTubesFieldProvFieldInst As RadioButton
    Friend WithEvents optTubesFisenProvInst As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optCutsFisenBottom As RadioButton
    Friend WithEvents optCutsFisenSide As RadioButton
    Friend WithEvents optCutsField As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optTrapInteralProvisions As RadioButton
    Friend WithEvents optTrapExternal As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optDrainPanStainless As RadioButton
    Friend WithEvents OptDrainPanGalv As RadioButton
    Friend WithEvents OptDrainPanNone As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chkSafeNone As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optControlsFieldProvidedFisenInstalled As RadioButton
    Friend WithEvents optControlsFisen As RadioButton
    Friend WithEvents optControlsNone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optOppositeSideDrain As RadioButton
    Friend WithEvents optSameSideDrain As RadioButton
End Class
