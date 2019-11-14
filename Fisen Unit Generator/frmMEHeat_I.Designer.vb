<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEHeat_I
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
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInputCapBTU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputCapkW = New System.Windows.Forms.TextBox()
        Me.txtHeatAF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEAT = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optEmerFisenSSFused = New System.Windows.Forms.RadioButton()
        Me.optEmerFisenMLO = New System.Windows.Forms.RadioButton()
        Me.optEmerJCIMLO = New System.Windows.Forms.RadioButton()
        Me.optEmerFisenMCDS = New System.Windows.Forms.RadioButton()
        Me.optEmerFisenSS = New System.Windows.Forms.RadioButton()
        Me.optEmerJCIDisc = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optCommFisenSSFused = New System.Windows.Forms.RadioButton()
        Me.optCommFisenMLO = New System.Windows.Forms.RadioButton()
        Me.optCommJCIMLO = New System.Windows.Forms.RadioButton()
        Me.optCommFisenMCDS = New System.Windows.Forms.RadioButton()
        Me.optCommFisenSS = New System.Windows.Forms.RadioButton()
        Me.optCommJCIDisc = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkFisenPhaseLoss = New System.Windows.Forms.CheckBox()
        Me.chkJCIPhaseLoss = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkNoPerformance = New System.Windows.Forms.CheckBox()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.cmbHeatUse = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Location = New System.Drawing.Point(355, 237)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(96, 29)
        Me.cmdDesignCautions.TabIndex = 12
        Me.cmdDesignCautions.Text = "Design Cautions"
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 237)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 237)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 219)
        Me.TabControl1.TabIndex = 13
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.cmbHeatUse)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.txtInputCapBTU)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.txtInputCapkW)
        Me.tpgConditions.Controls.Add(Me.txtHeatAF)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtEAT)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(440, 193)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Input Capacity(btu/h)"
        '
        'txtInputCapBTU
        '
        Me.txtInputCapBTU.Location = New System.Drawing.Point(9, 118)
        Me.txtInputCapBTU.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCapBTU.Name = "txtInputCapBTU"
        Me.txtInputCapBTU.Size = New System.Drawing.Size(52, 20)
        Me.txtInputCapBTU.TabIndex = 30
        Me.txtInputCapBTU.Text = "-"
        Me.txtInputCapBTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Input Capacity(kW)"
        '
        'txtInputCapkW
        '
        Me.txtInputCapkW.Location = New System.Drawing.Point(9, 90)
        Me.txtInputCapkW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCapkW.Name = "txtInputCapkW"
        Me.txtInputCapkW.Size = New System.Drawing.Size(52, 20)
        Me.txtInputCapkW.TabIndex = 27
        Me.txtInputCapkW.Text = "-"
        Me.txtInputCapkW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeatAF
        '
        Me.txtHeatAF.Location = New System.Drawing.Point(8, 34)
        Me.txtHeatAF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeatAF.Name = "txtHeatAF"
        Me.txtHeatAF.Size = New System.Drawing.Size(52, 20)
        Me.txtHeatAF.TabIndex = 24
        Me.txtHeatAF.Text = "-"
        Me.txtHeatAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Entering Air Temp(ºF)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Heating Airflow(cfm)"
        '
        'txtEAT
        '
        Me.txtEAT.Location = New System.Drawing.Point(9, 62)
        Me.txtEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEAT.Name = "txtEAT"
        Me.txtEAT.Size = New System.Drawing.Size(52, 20)
        Me.txtEAT.TabIndex = 26
        Me.txtEAT.Text = "-"
        Me.txtEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(440, 193)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optEmerFisenSSFused)
        Me.GroupBox1.Controls.Add(Me.optEmerFisenMLO)
        Me.GroupBox1.Controls.Add(Me.optEmerJCIMLO)
        Me.GroupBox1.Controls.Add(Me.optEmerFisenMCDS)
        Me.GroupBox1.Controls.Add(Me.optEmerFisenSS)
        Me.GroupBox1.Controls.Add(Me.optEmerJCIDisc)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 66)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Emergency Circuit"
        '
        'optEmerFisenSSFused
        '
        Me.optEmerFisenSSFused.AutoSize = True
        Me.optEmerFisenSSFused.Location = New System.Drawing.Point(86, 42)
        Me.optEmerFisenSSFused.Name = "optEmerFisenSSFused"
        Me.optEmerFisenSSFused.Size = New System.Drawing.Size(169, 17)
        Me.optEmerFisenSSFused.TabIndex = 5
        Me.optEmerFisenSSFused.Text = "Fisen HD Safety Switch Fused"
        Me.optEmerFisenSSFused.UseVisualStyleBackColor = True
        '
        'optEmerFisenMLO
        '
        Me.optEmerFisenMLO.AutoSize = True
        Me.optEmerFisenMLO.Location = New System.Drawing.Point(261, 42)
        Me.optEmerFisenMLO.Name = "optEmerFisenMLO"
        Me.optEmerFisenMLO.Size = New System.Drawing.Size(76, 17)
        Me.optEmerFisenMLO.TabIndex = 4
        Me.optEmerFisenMLO.Text = "Fisen MLO"
        Me.optEmerFisenMLO.UseVisualStyleBackColor = True
        '
        'optEmerJCIMLO
        '
        Me.optEmerJCIMLO.AutoSize = True
        Me.optEmerJCIMLO.Location = New System.Drawing.Point(6, 42)
        Me.optEmerJCIMLO.Name = "optEmerJCIMLO"
        Me.optEmerJCIMLO.Size = New System.Drawing.Size(66, 17)
        Me.optEmerJCIMLO.TabIndex = 3
        Me.optEmerJCIMLO.Text = "JCI MLO"
        Me.optEmerJCIMLO.UseVisualStyleBackColor = True
        '
        'optEmerFisenMCDS
        '
        Me.optEmerFisenMCDS.AutoSize = True
        Me.optEmerFisenMCDS.Location = New System.Drawing.Point(261, 19)
        Me.optEmerFisenMCDS.Name = "optEmerFisenMCDS"
        Me.optEmerFisenMCDS.Size = New System.Drawing.Size(84, 17)
        Me.optEmerFisenMCDS.TabIndex = 2
        Me.optEmerFisenMCDS.Text = "Fisen MCDS"
        Me.optEmerFisenMCDS.UseVisualStyleBackColor = True
        '
        'optEmerFisenSS
        '
        Me.optEmerFisenSS.AutoSize = True
        Me.optEmerFisenSS.Checked = True
        Me.optEmerFisenSS.Location = New System.Drawing.Point(86, 19)
        Me.optEmerFisenSS.Name = "optEmerFisenSS"
        Me.optEmerFisenSS.Size = New System.Drawing.Size(154, 17)
        Me.optEmerFisenSS.TabIndex = 1
        Me.optEmerFisenSS.TabStop = True
        Me.optEmerFisenSS.Text = "Fisen HD Safety Switch NF"
        Me.optEmerFisenSS.UseVisualStyleBackColor = True
        '
        'optEmerJCIDisc
        '
        Me.optEmerJCIDisc.AutoSize = True
        Me.optEmerJCIDisc.Location = New System.Drawing.Point(6, 19)
        Me.optEmerJCIDisc.Name = "optEmerJCIDisc"
        Me.optEmerJCIDisc.Size = New System.Drawing.Size(74, 17)
        Me.optEmerJCIDisc.TabIndex = 0
        Me.optEmerJCIDisc.Text = "JCI MCDS"
        Me.optEmerJCIDisc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCommFisenSSFused)
        Me.GroupBox2.Controls.Add(Me.optCommFisenMLO)
        Me.GroupBox2.Controls.Add(Me.optCommJCIMLO)
        Me.GroupBox2.Controls.Add(Me.optCommFisenMCDS)
        Me.GroupBox2.Controls.Add(Me.optCommFisenSS)
        Me.GroupBox2.Controls.Add(Me.optCommJCIDisc)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 66)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commercial Circuit"
        '
        'optCommFisenSSFused
        '
        Me.optCommFisenSSFused.AutoSize = True
        Me.optCommFisenSSFused.Location = New System.Drawing.Point(86, 42)
        Me.optCommFisenSSFused.Name = "optCommFisenSSFused"
        Me.optCommFisenSSFused.Size = New System.Drawing.Size(169, 17)
        Me.optCommFisenSSFused.TabIndex = 5
        Me.optCommFisenSSFused.Text = "Fisen HD Safety Switch Fused"
        Me.optCommFisenSSFused.UseVisualStyleBackColor = True
        '
        'optCommFisenMLO
        '
        Me.optCommFisenMLO.AutoSize = True
        Me.optCommFisenMLO.Location = New System.Drawing.Point(261, 42)
        Me.optCommFisenMLO.Name = "optCommFisenMLO"
        Me.optCommFisenMLO.Size = New System.Drawing.Size(76, 17)
        Me.optCommFisenMLO.TabIndex = 4
        Me.optCommFisenMLO.Text = "Fisen MLO"
        Me.optCommFisenMLO.UseVisualStyleBackColor = True
        '
        'optCommJCIMLO
        '
        Me.optCommJCIMLO.AutoSize = True
        Me.optCommJCIMLO.Location = New System.Drawing.Point(6, 42)
        Me.optCommJCIMLO.Name = "optCommJCIMLO"
        Me.optCommJCIMLO.Size = New System.Drawing.Size(66, 17)
        Me.optCommJCIMLO.TabIndex = 3
        Me.optCommJCIMLO.Text = "JCI MLO"
        Me.optCommJCIMLO.UseVisualStyleBackColor = True
        '
        'optCommFisenMCDS
        '
        Me.optCommFisenMCDS.AutoSize = True
        Me.optCommFisenMCDS.Location = New System.Drawing.Point(261, 19)
        Me.optCommFisenMCDS.Name = "optCommFisenMCDS"
        Me.optCommFisenMCDS.Size = New System.Drawing.Size(84, 17)
        Me.optCommFisenMCDS.TabIndex = 2
        Me.optCommFisenMCDS.Text = "Fisen MCDS"
        Me.optCommFisenMCDS.UseVisualStyleBackColor = True
        '
        'optCommFisenSS
        '
        Me.optCommFisenSS.AutoSize = True
        Me.optCommFisenSS.Location = New System.Drawing.Point(86, 19)
        Me.optCommFisenSS.Name = "optCommFisenSS"
        Me.optCommFisenSS.Size = New System.Drawing.Size(154, 17)
        Me.optCommFisenSS.TabIndex = 1
        Me.optCommFisenSS.Text = "Fisen HD Safety Switch NF"
        Me.optCommFisenSS.UseVisualStyleBackColor = True
        '
        'optCommJCIDisc
        '
        Me.optCommJCIDisc.AutoSize = True
        Me.optCommJCIDisc.Checked = True
        Me.optCommJCIDisc.Location = New System.Drawing.Point(6, 19)
        Me.optCommJCIDisc.Name = "optCommJCIDisc"
        Me.optCommJCIDisc.Size = New System.Drawing.Size(74, 17)
        Me.optCommJCIDisc.TabIndex = 0
        Me.optCommJCIDisc.TabStop = True
        Me.optCommJCIDisc.Text = "JCI MCDS"
        Me.optCommJCIDisc.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkFisenPhaseLoss)
        Me.tpgControls.Controls.Add(Me.chkJCIPhaseLoss)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(440, 193)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkFisenPhaseLoss
        '
        Me.chkFisenPhaseLoss.AutoSize = True
        Me.chkFisenPhaseLoss.Location = New System.Drawing.Point(6, 29)
        Me.chkFisenPhaseLoss.Name = "chkFisenPhaseLoss"
        Me.chkFisenPhaseLoss.Size = New System.Drawing.Size(250, 17)
        Me.chkFisenPhaseLoss.TabIndex = 27
        Me.chkFisenPhaseLoss.Text = "Fisen Phase Loss Monitor on Emergency Circuit"
        Me.chkFisenPhaseLoss.UseVisualStyleBackColor = True
        '
        'chkJCIPhaseLoss
        '
        Me.chkJCIPhaseLoss.AutoSize = True
        Me.chkJCIPhaseLoss.Location = New System.Drawing.Point(6, 6)
        Me.chkJCIPhaseLoss.Name = "chkJCIPhaseLoss"
        Me.chkJCIPhaseLoss.Size = New System.Drawing.Size(241, 17)
        Me.chkJCIPhaseLoss.TabIndex = 26
        Me.chkJCIPhaseLoss.Text = "JCI Phase Loss Monitor on Commercial Circuit"
        Me.chkJCIPhaseLoss.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(393, 164)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.CheckBox2)
        Me.tpgPerformance.Controls.Add(Me.chkNoPerformance)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(440, 193)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(13, 36)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(165, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Use the custom MCA feature."
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chkNoPerformance
        '
        Me.chkNoPerformance.AutoSize = True
        Me.chkNoPerformance.Checked = True
        Me.chkNoPerformance.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoPerformance.Enabled = False
        Me.chkNoPerformance.Location = New System.Drawing.Point(13, 13)
        Me.chkNoPerformance.Name = "chkNoPerformance"
        Me.chkNoPerformance.Size = New System.Drawing.Size(248, 17)
        Me.chkNoPerformance.TabIndex = 27
        Me.chkNoPerformance.Text = "No Performance to Report for This Modification"
        Me.chkNoPerformance.UseVisualStyleBackColor = True
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(393, 164)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 25
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(440, 193)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'cmbHeatUse
        '
        Me.cmbHeatUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeatUse.FormattingEnabled = True
        Me.cmbHeatUse.Items.AddRange(New Object() {"Main Heat", "Preheat", "Reactivation Heat"})
        Me.cmbHeatUse.Location = New System.Drawing.Point(8, 6)
        Me.cmbHeatUse.Name = "cmbHeatUse"
        Me.cmbHeatUse.Size = New System.Drawing.Size(168, 21)
        Me.cmbHeatUse.TabIndex = 32
        '
        'frmMEHeat_I
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMEHeat_I"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modulating Electric Heat - Indeeco"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optEmerFisenSSFused As RadioButton
    Friend WithEvents optEmerFisenMLO As RadioButton
    Friend WithEvents optEmerJCIMLO As RadioButton
    Friend WithEvents optEmerFisenMCDS As RadioButton
    Friend WithEvents optEmerFisenSS As RadioButton
    Friend WithEvents optEmerJCIDisc As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optCommFisenSSFused As RadioButton
    Friend WithEvents optCommFisenMLO As RadioButton
    Friend WithEvents optCommJCIMLO As RadioButton
    Friend WithEvents optCommFisenMCDS As RadioButton
    Friend WithEvents optCommFisenSS As RadioButton
    Friend WithEvents optCommJCIDisc As RadioButton
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkFisenPhaseLoss As CheckBox
    Friend WithEvents chkJCIPhaseLoss As CheckBox
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents chkNoPerformance As CheckBox
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInputCapBTU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputCapkW As TextBox
    Friend WithEvents txtHeatAF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEAT As TextBox
    Friend WithEvents cmbHeatUse As ComboBox
End Class
