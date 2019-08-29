<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDigScroll
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.txtTotalSubcooling = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompSuperheat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEvapSuperheat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAmbientTemp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCondTemp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEvapTemp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTandem = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optLargeSplit = New System.Windows.Forms.RadioButton()
        Me.optYPALRTU = New System.Windows.Forms.RadioButton()
        Me.optUPGRTU = New System.Windows.Forms.RadioButton()
        Me.optUPGSplit = New System.Windows.Forms.RadioButton()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chkOverloadRelays = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk4thCircuit = New System.Windows.Forms.CheckBox()
        Me.chk3rdCircuit = New System.Windows.Forms.CheckBox()
        Me.chk2ndCircuit = New System.Windows.Forms.CheckBox()
        Me.chk1stCircuit = New System.Windows.Forms.CheckBox()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.chkSuctionPressureCtrls = New System.Windows.Forms.CheckBox()
        Me.chkGBASControls = New System.Windows.Forms.CheckBox()
        Me.chkEvaporatorControls = New System.Windows.Forms.CheckBox()
        Me.chkFieldSelectable = New System.Windows.Forms.CheckBox()
        Me.chkModbusPoints = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.txtDesignPointCurrent = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNewCompRLA = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExistingCompRLA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSuctionTemp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSuctionP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSCap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTCap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(12, 195)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(90, 195)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 179)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.txtTotalSubcooling)
        Me.tpgConditions.Controls.Add(Me.Label12)
        Me.tpgConditions.Controls.Add(Me.txtCompSuperheat)
        Me.tpgConditions.Controls.Add(Me.Label11)
        Me.tpgConditions.Controls.Add(Me.txtEvapSuperheat)
        Me.tpgConditions.Controls.Add(Me.Label10)
        Me.tpgConditions.Controls.Add(Me.TextBox1)
        Me.tpgConditions.Controls.Add(Me.Label9)
        Me.tpgConditions.Controls.Add(Me.txtAmbientTemp)
        Me.tpgConditions.Controls.Add(Me.Label7)
        Me.tpgConditions.Controls.Add(Me.txtCondTemp)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.txtEvapTemp)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.chkTandem)
        Me.tpgConditions.Controls.Add(Me.GroupBox1)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(451, 153)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'txtTotalSubcooling
        '
        Me.txtTotalSubcooling.Location = New System.Drawing.Point(405, 52)
        Me.txtTotalSubcooling.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalSubcooling.Name = "txtTotalSubcooling"
        Me.txtTotalSubcooling.Size = New System.Drawing.Size(40, 20)
        Me.txtTotalSubcooling.TabIndex = 39
        Me.txtTotalSubcooling.Text = "15.0"
        Me.txtTotalSubcooling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(314, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Total Subcooling"
        '
        'txtCompSuperheat
        '
        Me.txtCompSuperheat.Location = New System.Drawing.Point(405, 28)
        Me.txtCompSuperheat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCompSuperheat.Name = "txtCompSuperheat"
        Me.txtCompSuperheat.Size = New System.Drawing.Size(40, 20)
        Me.txtCompSuperheat.TabIndex = 37
        Me.txtCompSuperheat.Text = "20.0"
        Me.txtCompSuperheat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 31)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Comp. Superheat"
        '
        'txtEvapSuperheat
        '
        Me.txtEvapSuperheat.Location = New System.Drawing.Point(405, 4)
        Me.txtEvapSuperheat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEvapSuperheat.Name = "txtEvapSuperheat"
        Me.txtEvapSuperheat.Size = New System.Drawing.Size(40, 20)
        Me.txtEvapSuperheat.TabIndex = 35
        Me.txtEvapSuperheat.Text = "10.0"
        Me.txtEvapSuperheat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 7)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Evap. Superheat"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(260, 73)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "60.0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Suction Gas Temp"
        '
        'txtAmbientTemp
        '
        Me.txtAmbientTemp.Location = New System.Drawing.Point(260, 49)
        Me.txtAmbientTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmbientTemp.Name = "txtAmbientTemp"
        Me.txtAmbientTemp.Size = New System.Drawing.Size(40, 20)
        Me.txtAmbientTemp.TabIndex = 31
        Me.txtAmbientTemp.Text = "95.0"
        Me.txtAmbientTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Ambient Temperature"
        '
        'txtCondTemp
        '
        Me.txtCondTemp.Location = New System.Drawing.Point(260, 26)
        Me.txtCondTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCondTemp.Name = "txtCondTemp"
        Me.txtCondTemp.Size = New System.Drawing.Size(40, 20)
        Me.txtCondTemp.TabIndex = 29
        Me.txtCondTemp.Text = "105.0"
        Me.txtCondTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Condensing Temperature"
        '
        'txtEvapTemp
        '
        Me.txtEvapTemp.Location = New System.Drawing.Point(260, 4)
        Me.txtEvapTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEvapTemp.Name = "txtEvapTemp"
        Me.txtEvapTemp.Size = New System.Drawing.Size(40, 20)
        Me.txtEvapTemp.TabIndex = 27
        Me.txtEvapTemp.Text = "40.0"
        Me.txtEvapTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Evaporator Temperature"
        '
        'chkTandem
        '
        Me.chkTandem.AutoSize = True
        Me.chkTandem.Enabled = False
        Me.chkTandem.Location = New System.Drawing.Point(5, 112)
        Me.chkTandem.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTandem.Name = "chkTandem"
        Me.chkTandem.Size = New System.Drawing.Size(268, 17)
        Me.chkTandem.TabIndex = 25
        Me.chkTandem.Text = "Tandem Digital Scroll Replaces 1 Base Compressor"
        Me.chkTandem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optLargeSplit)
        Me.GroupBox1.Controls.Add(Me.optYPALRTU)
        Me.GroupBox1.Controls.Add(Me.optUPGRTU)
        Me.GroupBox1.Controls.Add(Me.optUPGSplit)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(113, 102)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base System"
        '
        'optLargeSplit
        '
        Me.optLargeSplit.AutoSize = True
        Me.optLargeSplit.Location = New System.Drawing.Point(4, 59)
        Me.optLargeSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.optLargeSplit.Name = "optLargeSplit"
        Me.optLargeSplit.Size = New System.Drawing.Size(75, 17)
        Me.optLargeSplit.TabIndex = 28
        Me.optLargeSplit.Text = "Large Split"
        Me.optLargeSplit.UseVisualStyleBackColor = True
        '
        'optYPALRTU
        '
        Me.optYPALRTU.AutoSize = True
        Me.optYPALRTU.Location = New System.Drawing.Point(4, 81)
        Me.optYPALRTU.Margin = New System.Windows.Forms.Padding(2)
        Me.optYPALRTU.Name = "optYPALRTU"
        Me.optYPALRTU.Size = New System.Drawing.Size(78, 17)
        Me.optYPALRTU.TabIndex = 27
        Me.optYPALRTU.Text = "YPAL RTU"
        Me.optYPALRTU.UseVisualStyleBackColor = True
        '
        'optUPGRTU
        '
        Me.optUPGRTU.AutoSize = True
        Me.optUPGRTU.Checked = True
        Me.optUPGRTU.Location = New System.Drawing.Point(4, 39)
        Me.optUPGRTU.Margin = New System.Windows.Forms.Padding(2)
        Me.optUPGRTU.Name = "optUPGRTU"
        Me.optUPGRTU.Size = New System.Drawing.Size(74, 17)
        Me.optUPGRTU.TabIndex = 26
        Me.optUPGRTU.TabStop = True
        Me.optUPGRTU.Text = "UPG RTU"
        Me.optUPGRTU.UseVisualStyleBackColor = True
        '
        'optUPGSplit
        '
        Me.optUPGSplit.AutoSize = True
        Me.optUPGSplit.Location = New System.Drawing.Point(4, 17)
        Me.optUPGSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.optUPGSplit.Name = "optUPGSplit"
        Me.optUPGSplit.Size = New System.Drawing.Size(108, 17)
        Me.optUPGSplit.TabIndex = 25
        Me.optUPGSplit.Text = "UPG Split System"
        Me.optUPGSplit.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(403, 127)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkOverloadRelays)
        Me.tpgOptions.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(451, 153)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chkOverloadRelays
        '
        Me.chkOverloadRelays.AutoSize = True
        Me.chkOverloadRelays.Checked = True
        Me.chkOverloadRelays.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOverloadRelays.Location = New System.Drawing.Point(133, 23)
        Me.chkOverloadRelays.Name = "chkOverloadRelays"
        Me.chkOverloadRelays.Size = New System.Drawing.Size(189, 17)
        Me.chkOverloadRelays.TabIndex = 28
        Me.chkOverloadRelays.Text = "Use Overload relays to limit current"
        Me.chkOverloadRelays.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Checked = True
        Me.chkMountEquipmentTouch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(23, 132)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 27
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Checked = True
        Me.chkIncludeEquipmentTouch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(10, 114)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 26
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk4thCircuit)
        Me.GroupBox2.Controls.Add(Me.chk3rdCircuit)
        Me.GroupBox2.Controls.Add(Me.chk2ndCircuit)
        Me.GroupBox2.Controls.Add(Me.chk1stCircuit)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(113, 102)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Digital Scrolls on:"
        '
        'chk4thCircuit
        '
        Me.chk4thCircuit.AutoSize = True
        Me.chk4thCircuit.Enabled = False
        Me.chk4thCircuit.Location = New System.Drawing.Point(4, 80)
        Me.chk4thCircuit.Margin = New System.Windows.Forms.Padding(2)
        Me.chk4thCircuit.Name = "chk4thCircuit"
        Me.chk4thCircuit.Size = New System.Drawing.Size(73, 17)
        Me.chk4thCircuit.TabIndex = 29
        Me.chk4thCircuit.Text = "4th Circuit"
        Me.chk4thCircuit.UseVisualStyleBackColor = True
        '
        'chk3rdCircuit
        '
        Me.chk3rdCircuit.AutoSize = True
        Me.chk3rdCircuit.Enabled = False
        Me.chk3rdCircuit.Location = New System.Drawing.Point(4, 59)
        Me.chk3rdCircuit.Margin = New System.Windows.Forms.Padding(2)
        Me.chk3rdCircuit.Name = "chk3rdCircuit"
        Me.chk3rdCircuit.Size = New System.Drawing.Size(73, 17)
        Me.chk3rdCircuit.TabIndex = 28
        Me.chk3rdCircuit.Text = "3rd Circuit"
        Me.chk3rdCircuit.UseVisualStyleBackColor = True
        '
        'chk2ndCircuit
        '
        Me.chk2ndCircuit.AutoSize = True
        Me.chk2ndCircuit.Location = New System.Drawing.Point(4, 37)
        Me.chk2ndCircuit.Margin = New System.Windows.Forms.Padding(2)
        Me.chk2ndCircuit.Name = "chk2ndCircuit"
        Me.chk2ndCircuit.Size = New System.Drawing.Size(76, 17)
        Me.chk2ndCircuit.TabIndex = 27
        Me.chk2ndCircuit.Text = "2nd Circuit"
        Me.chk2ndCircuit.UseVisualStyleBackColor = True
        '
        'chk1stCircuit
        '
        Me.chk1stCircuit.AutoSize = True
        Me.chk1stCircuit.Checked = True
        Me.chk1stCircuit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk1stCircuit.Enabled = False
        Me.chk1stCircuit.Location = New System.Drawing.Point(4, 17)
        Me.chk1stCircuit.Margin = New System.Windows.Forms.Padding(2)
        Me.chk1stCircuit.Name = "chk1stCircuit"
        Me.chk1stCircuit.Size = New System.Drawing.Size(72, 17)
        Me.chk1stCircuit.TabIndex = 26
        Me.chk1stCircuit.Text = "1st Circuit"
        Me.chk1stCircuit.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(403, 127)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.chkSuctionPressureCtrls)
        Me.tpgControls.Controls.Add(Me.chkGBASControls)
        Me.tpgControls.Controls.Add(Me.chkEvaporatorControls)
        Me.tpgControls.Controls.Add(Me.chkFieldSelectable)
        Me.tpgControls.Controls.Add(Me.chkModbusPoints)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(451, 153)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'chkSuctionPressureCtrls
        '
        Me.chkSuctionPressureCtrls.AutoSize = True
        Me.chkSuctionPressureCtrls.Enabled = False
        Me.chkSuctionPressureCtrls.Location = New System.Drawing.Point(27, 77)
        Me.chkSuctionPressureCtrls.Name = "chkSuctionPressureCtrls"
        Me.chkSuctionPressureCtrls.Size = New System.Drawing.Size(172, 17)
        Me.chkSuctionPressureCtrls.TabIndex = 31
        Me.chkSuctionPressureCtrls.Text = "Suction Pressure Control Mode"
        Me.chkSuctionPressureCtrls.UseVisualStyleBackColor = True
        '
        'chkGBASControls
        '
        Me.chkGBASControls.AutoSize = True
        Me.chkGBASControls.Enabled = False
        Me.chkGBASControls.Location = New System.Drawing.Point(27, 54)
        Me.chkGBASControls.Name = "chkGBASControls"
        Me.chkGBASControls.Size = New System.Drawing.Size(121, 17)
        Me.chkGBASControls.TabIndex = 30
        Me.chkGBASControls.Text = "GBAS Control Mode"
        Me.chkGBASControls.UseVisualStyleBackColor = True
        '
        'chkEvaporatorControls
        '
        Me.chkEvaporatorControls.AutoSize = True
        Me.chkEvaporatorControls.Enabled = False
        Me.chkEvaporatorControls.Location = New System.Drawing.Point(27, 30)
        Me.chkEvaporatorControls.Name = "chkEvaporatorControls"
        Me.chkEvaporatorControls.Size = New System.Drawing.Size(212, 17)
        Me.chkEvaporatorControls.TabIndex = 29
        Me.chkEvaporatorControls.Text = "Evaporator Leaving Temperature Mode"
        Me.chkEvaporatorControls.UseVisualStyleBackColor = True
        '
        'chkFieldSelectable
        '
        Me.chkFieldSelectable.AutoSize = True
        Me.chkFieldSelectable.Checked = True
        Me.chkFieldSelectable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFieldSelectable.Location = New System.Drawing.Point(6, 6)
        Me.chkFieldSelectable.Name = "chkFieldSelectable"
        Me.chkFieldSelectable.Size = New System.Drawing.Size(184, 17)
        Me.chkFieldSelectable.TabIndex = 28
        Me.chkFieldSelectable.Text = "Field Selectable Controls Strategy"
        Me.chkFieldSelectable.UseVisualStyleBackColor = True
        '
        'chkModbusPoints
        '
        Me.chkModbusPoints.AutoSize = True
        Me.chkModbusPoints.Location = New System.Drawing.Point(6, 101)
        Me.chkModbusPoints.Name = "chkModbusPoints"
        Me.chkModbusPoints.Size = New System.Drawing.Size(157, 17)
        Me.chkModbusPoints.TabIndex = 27
        Me.chkModbusPoints.Text = "Configure Unit as MODBUS"
        Me.chkModbusPoints.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(403, 127)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.txtDesignPointCurrent)
        Me.tpgPerformance.Controls.Add(Me.Label15)
        Me.tpgPerformance.Controls.Add(Me.txtNewCompRLA)
        Me.tpgPerformance.Controls.Add(Me.Label14)
        Me.tpgPerformance.Controls.Add(Me.txtExistingCompRLA)
        Me.tpgPerformance.Controls.Add(Me.Label13)
        Me.tpgPerformance.Controls.Add(Me.txtSuctionTemp)
        Me.tpgPerformance.Controls.Add(Me.Label8)
        Me.tpgPerformance.Controls.Add(Me.txtSuctionP)
        Me.tpgPerformance.Controls.Add(Me.Label5)
        Me.tpgPerformance.Controls.Add(Me.txtPower)
        Me.tpgPerformance.Controls.Add(Me.Label6)
        Me.tpgPerformance.Controls.Add(Me.txtSCap)
        Me.tpgPerformance.Controls.Add(Me.Label3)
        Me.tpgPerformance.Controls.Add(Me.txtTCap)
        Me.tpgPerformance.Controls.Add(Me.Label4)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(451, 153)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'txtDesignPointCurrent
        '
        Me.txtDesignPointCurrent.Location = New System.Drawing.Point(110, 58)
        Me.txtDesignPointCurrent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesignPointCurrent.Name = "txtDesignPointCurrent"
        Me.txtDesignPointCurrent.Size = New System.Drawing.Size(40, 20)
        Me.txtDesignPointCurrent.TabIndex = 2
        Me.txtDesignPointCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 61)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Design Point Current"
        '
        'txtNewCompRLA
        '
        Me.txtNewCompRLA.Location = New System.Drawing.Point(110, 34)
        Me.txtNewCompRLA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewCompRLA.Name = "txtNewCompRLA"
        Me.txtNewCompRLA.Size = New System.Drawing.Size(40, 20)
        Me.txtNewCompRLA.TabIndex = 1
        Me.txtNewCompRLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "New Comp RLA"
        '
        'txtExistingCompRLA
        '
        Me.txtExistingCompRLA.Location = New System.Drawing.Point(110, 10)
        Me.txtExistingCompRLA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExistingCompRLA.Name = "txtExistingCompRLA"
        Me.txtExistingCompRLA.Size = New System.Drawing.Size(40, 20)
        Me.txtExistingCompRLA.TabIndex = 0
        Me.txtExistingCompRLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 13)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Existing Comp RLA"
        '
        'txtSuctionTemp
        '
        Me.txtSuctionTemp.Location = New System.Drawing.Point(341, 106)
        Me.txtSuctionTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuctionTemp.Name = "txtSuctionTemp"
        Me.txtSuctionTemp.Size = New System.Drawing.Size(40, 20)
        Me.txtSuctionTemp.TabIndex = 7
        Me.txtSuctionTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(209, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Sat. Suction Temperature"
        '
        'txtSuctionP
        '
        Me.txtSuctionP.Location = New System.Drawing.Point(341, 82)
        Me.txtSuctionP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuctionP.Name = "txtSuctionP"
        Me.txtSuctionP.Size = New System.Drawing.Size(40, 20)
        Me.txtSuctionP.TabIndex = 6
        Me.txtSuctionP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Suction Pressure"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(341, 58)
        Me.txtPower.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(40, 20)
        Me.txtPower.TabIndex = 5
        Me.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Power Input"
        '
        'txtSCap
        '
        Me.txtSCap.Location = New System.Drawing.Point(341, 34)
        Me.txtSCap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSCap.Name = "txtSCap"
        Me.txtSCap.Size = New System.Drawing.Size(40, 20)
        Me.txtSCap.TabIndex = 4
        Me.txtSCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Sensible Capacity"
        '
        'txtTCap
        '
        Me.txtTCap.Location = New System.Drawing.Point(341, 10)
        Me.txtTCap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTCap.Name = "txtTCap"
        Me.txtTCap.Size = New System.Drawing.Size(40, 20)
        Me.txtTCap.TabIndex = 3
        Me.txtTCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total Capacity"
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(403, 127)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 8
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(451, 153)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'frmDigScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDigScroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Digital Scroll Compressor"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optLargeSplit As RadioButton
    Friend WithEvents optYPALRTU As RadioButton
    Friend WithEvents optUPGRTU As RadioButton
    Friend WithEvents optUPGSplit As RadioButton
    Friend WithEvents chkTandem As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk4thCircuit As CheckBox
    Friend WithEvents chk3rdCircuit As CheckBox
    Friend WithEvents chk2ndCircuit As CheckBox
    Friend WithEvents chk1stCircuit As CheckBox
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents chkModbusPoints As CheckBox
    Friend WithEvents chkSuctionPressureCtrls As CheckBox
    Friend WithEvents chkGBASControls As CheckBox
    Friend WithEvents chkEvaporatorControls As CheckBox
    Friend WithEvents chkFieldSelectable As CheckBox
    Friend WithEvents txtEvapTemp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmbientTemp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCondTemp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSuctionTemp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSuctionP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSCap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTCap As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalSubcooling As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCompSuperheat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEvapSuperheat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkOverloadRelays As CheckBox
    Friend WithEvents txtDesignPointCurrent As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNewCompRLA As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExistingCompRLA As TextBox
    Friend WithEvents Label13 As Label
End Class
