<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLowAF
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
        Me.chk100OA = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHeatEAT = New System.Windows.Forms.TextBox()
        Me.txtEWB = New System.Windows.Forms.TextBox()
        Me.txtEDB = New System.Windows.Forms.TextBox()
        Me.txtAmbient = New System.Windows.Forms.TextBox()
        Me.txtESP = New System.Windows.Forms.TextBox()
        Me.txtAirflow = New System.Windows.Forms.TextBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optRefDwg2Ckt = New System.Windows.Forms.RadioButton()
        Me.optRefDwg1Ckt = New System.Windows.Forms.RadioButton()
        Me.optRefDwgNone = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkSeriesConversion = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtMinCatAirflow = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNominalAirflow = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optReplaceFan = New System.Windows.Forms.RadioButton()
        Me.optFanWallBypassNew = New System.Windows.Forms.RadioButton()
        Me.optFanWallBypassExisting = New System.Windows.Forms.RadioButton()
        Me.optResheave = New System.Windows.Forms.RadioButton()
        Me.optExistingSheaves = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAntiFrostProtection = New System.Windows.Forms.CheckBox()
        Me.chkElecHeatProtection = New System.Windows.Forms.CheckBox()
        Me.chkGasHeatProtection = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblFanHeat = New System.Windows.Forms.Label()
        Me.cmdFanHeatCalc = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtUnitLATwb = New System.Windows.Forms.TextBox()
        Me.txtUnitLATdb = New System.Windows.Forms.TextBox()
        Me.txtFanRPM = New System.Windows.Forms.TextBox()
        Me.lblRPM = New System.Windows.Forms.Label()
        Me.lblFanbhp2 = New System.Windows.Forms.Label()
        Me.txtFanBHP = New System.Windows.Forms.TextBox()
        Me.lblFanHP = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtHeatingLAT = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBypassAF = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLAWB = New System.Windows.Forms.TextBox()
        Me.txtLADB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFinalEnth = New System.Windows.Forms.TextBox()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtSCap = New System.Windows.Forms.TextBox()
        Me.txtTCap = New System.Windows.Forms.TextBox()
        Me.txtDBfromPsych = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.lblFinalEnthalpy = New System.Windows.Forms.Label()
        Me.lblInitialEnthalpy = New System.Windows.Forms.Label()
        Me.lblMyAmb = New System.Windows.Forms.Label()
        Me.lblLowAmb = New System.Windows.Forms.Label()
        Me.lblHiAmb = New System.Windows.Forms.Label()
        Me.lblkW2HiAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW2HiAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH2HiAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH2HiAmbLoAF = New System.Windows.Forms.Label()
        Me.lblkW1HiAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW1HiAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH1HiAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH1HiAmbLoAF = New System.Windows.Forms.Label()
        Me.lblHighAFHiTemp = New System.Windows.Forms.Label()
        Me.lblLowAFHiTemp = New System.Windows.Forms.Label()
        Me.lblkW2LoAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW2LoAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH2LoAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH2LoAmbLoAF = New System.Windows.Forms.Label()
        Me.lblkW1LoAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW1LoAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH1LoAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH1LoAmbLoAF = New System.Windows.Forms.Label()
        Me.lblHighAFLowTemp = New System.Windows.Forms.Label()
        Me.lblLowAFLowTemp = New System.Windows.Forms.Label()
        Me.lblkW3MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblMBH3MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblMyWB = New System.Windows.Forms.Label()
        Me.lblkW2MyAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW2MyAmbLoAF = New System.Windows.Forms.Label()
        Me.lblkW2MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblMBH2MyAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH2MyAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH2MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblkW1MyAmbHiAF = New System.Windows.Forms.Label()
        Me.lblkW1MyAmbLoAF = New System.Windows.Forms.Label()
        Me.lblkW1MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblMBH1MyAmbHiAF = New System.Windows.Forms.Label()
        Me.lblMBH1MyAmbLoAF = New System.Windows.Forms.Label()
        Me.lblMBH1MyAmbMyAF = New System.Windows.Forms.Label()
        Me.lblHighAFMyTemp = New System.Windows.Forms.Label()
        Me.lblLowAFMyTemp = New System.Windows.Forms.Label()
        Me.lblMyAF = New System.Windows.Forms.Label()
        Me.lblWB2 = New System.Windows.Forms.Label()
        Me.lblWB1 = New System.Windows.Forms.Label()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtFaceVelocity = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblsqftevap = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.DebugPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(16, 284)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(120, 284)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
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
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(599, 268)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.lblsqftevap)
        Me.tpgConditions.Controls.Add(Me.chk100OA)
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.Label7)
        Me.tpgConditions.Controls.Add(Me.Label4)
        Me.tpgConditions.Controls.Add(Me.Label6)
        Me.tpgConditions.Controls.Add(Me.Label5)
        Me.tpgConditions.Controls.Add(Me.Label3)
        Me.tpgConditions.Controls.Add(Me.Label2)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtHeatEAT)
        Me.tpgConditions.Controls.Add(Me.txtEWB)
        Me.tpgConditions.Controls.Add(Me.txtEDB)
        Me.tpgConditions.Controls.Add(Me.txtAmbient)
        Me.tpgConditions.Controls.Add(Me.txtESP)
        Me.tpgConditions.Controls.Add(Me.txtAirflow)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(591, 242)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'chk100OA
        '
        Me.chk100OA.AutoSize = True
        Me.chk100OA.Location = New System.Drawing.Point(6, 6)
        Me.chk100OA.Name = "chk100OA"
        Me.chk100OA.Size = New System.Drawing.Size(136, 17)
        Me.chk100OA.TabIndex = 53
        Me.chk100OA.Text = "100% Outdoor Air Unit?"
        Me.chk100OA.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(296, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Heating"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Cooling"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Entering DB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Entering DB"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Entering WB"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Ambient"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "ESP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Airflow"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtHeatEAT
        '
        Me.txtHeatEAT.Location = New System.Drawing.Point(290, 101)
        Me.txtHeatEAT.Name = "txtHeatEAT"
        Me.txtHeatEAT.Size = New System.Drawing.Size(63, 20)
        Me.txtHeatEAT.TabIndex = 4
        Me.txtHeatEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEWB
        '
        Me.txtEWB.Location = New System.Drawing.Point(102, 155)
        Me.txtEWB.Name = "txtEWB"
        Me.txtEWB.Size = New System.Drawing.Size(63, 20)
        Me.txtEWB.TabIndex = 6
        Me.txtEWB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEDB
        '
        Me.txtEDB.Location = New System.Drawing.Point(102, 129)
        Me.txtEDB.Name = "txtEDB"
        Me.txtEDB.Size = New System.Drawing.Size(63, 20)
        Me.txtEDB.TabIndex = 5
        Me.txtEDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmbient
        '
        Me.txtAmbient.Location = New System.Drawing.Point(102, 103)
        Me.txtAmbient.Name = "txtAmbient"
        Me.txtAmbient.Size = New System.Drawing.Size(63, 20)
        Me.txtAmbient.TabIndex = 3
        Me.txtAmbient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtESP
        '
        Me.txtESP.Location = New System.Drawing.Point(290, 28)
        Me.txtESP.Name = "txtESP"
        Me.txtESP.Size = New System.Drawing.Size(63, 20)
        Me.txtESP.TabIndex = 2
        Me.txtESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(102, 27)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(63, 20)
        Me.txtAirflow.TabIndex = 1
        Me.txtAirflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(544, 210)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 23
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.GroupBox4)
        Me.tpgOptions.Controls.Add(Me.CheckBox1)
        Me.tpgOptions.Controls.Add(Me.chkSeriesConversion)
        Me.tpgOptions.Controls.Add(Me.Label24)
        Me.tpgOptions.Controls.Add(Me.txtMinCatAirflow)
        Me.tpgOptions.Controls.Add(Me.Label23)
        Me.tpgOptions.Controls.Add(Me.txtNominalAirflow)
        Me.tpgOptions.Controls.Add(Me.GroupBox1)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(591, 242)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optRefDwg2Ckt)
        Me.GroupBox4.Controls.Add(Me.optRefDwg1Ckt)
        Me.GroupBox4.Controls.Add(Me.optRefDwgNone)
        Me.GroupBox4.Location = New System.Drawing.Point(430, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(155, 94)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Refrigeration Drawings"
        '
        'optRefDwg2Ckt
        '
        Me.optRefDwg2Ckt.AutoSize = True
        Me.optRefDwg2Ckt.Location = New System.Drawing.Point(6, 65)
        Me.optRefDwg2Ckt.Name = "optRefDwg2Ckt"
        Me.optRefDwg2Ckt.Size = New System.Drawing.Size(144, 17)
        Me.optRefDwg2Ckt.TabIndex = 2
        Me.optRefDwg2Ckt.Text = "Series Conversion (2 Ckt)"
        Me.optRefDwg2Ckt.UseVisualStyleBackColor = True
        '
        'optRefDwg1Ckt
        '
        Me.optRefDwg1Ckt.AutoSize = True
        Me.optRefDwg1Ckt.Location = New System.Drawing.Point(6, 42)
        Me.optRefDwg1Ckt.Name = "optRefDwg1Ckt"
        Me.optRefDwg1Ckt.Size = New System.Drawing.Size(144, 17)
        Me.optRefDwg1Ckt.TabIndex = 1
        Me.optRefDwg1Ckt.Text = "Series Conversion (1 Ckt)"
        Me.optRefDwg1Ckt.UseVisualStyleBackColor = True
        '
        'optRefDwgNone
        '
        Me.optRefDwgNone.AutoSize = True
        Me.optRefDwgNone.Checked = True
        Me.optRefDwgNone.Location = New System.Drawing.Point(6, 19)
        Me.optRefDwgNone.Name = "optRefDwgNone"
        Me.optRefDwgNone.Size = New System.Drawing.Size(51, 17)
        Me.optRefDwgNone.TabIndex = 0
        Me.optRefDwgNone.TabStop = True
        Me.optRefDwgNone.Text = "None"
        Me.optRefDwgNone.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(6, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(187, 17)
        Me.CheckBox1.TabIndex = 51
        Me.CheckBox1.Text = "Heat Pump Disable Heating Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkSeriesConversion
        '
        Me.chkSeriesConversion.AutoSize = True
        Me.chkSeriesConversion.Location = New System.Drawing.Point(6, 153)
        Me.chkSeriesConversion.Name = "chkSeriesConversion"
        Me.chkSeriesConversion.Size = New System.Drawing.Size(146, 17)
        Me.chkSeriesConversion.TabIndex = 50
        Me.chkSeriesConversion.Text = "HGRH Series Conversion"
        Me.chkSeriesConversion.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(340, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Minimum Cataloged Airflow"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMinCatAirflow
        '
        Me.txtMinCatAirflow.Location = New System.Drawing.Point(522, 46)
        Me.txtMinCatAirflow.Name = "txtMinCatAirflow"
        Me.txtMinCatAirflow.Size = New System.Drawing.Size(63, 20)
        Me.txtMinCatAirflow.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(383, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 13)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Unit Nominal Airflow"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNominalAirflow
        '
        Me.txtNominalAirflow.Location = New System.Drawing.Point(522, 20)
        Me.txtNominalAirflow.Name = "txtNominalAirflow"
        Me.txtNominalAirflow.Size = New System.Drawing.Size(63, 20)
        Me.txtNominalAirflow.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optReplaceFan)
        Me.GroupBox1.Controls.Add(Me.optFanWallBypassNew)
        Me.GroupBox1.Controls.Add(Me.optFanWallBypassExisting)
        Me.GroupBox1.Controls.Add(Me.optResheave)
        Me.GroupBox1.Controls.Add(Me.optExistingSheaves)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 141)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Airflow Reduction Method"
        '
        'optReplaceFan
        '
        Me.optReplaceFan.AutoSize = True
        Me.optReplaceFan.Location = New System.Drawing.Point(6, 111)
        Me.optReplaceFan.Name = "optReplaceFan"
        Me.optReplaceFan.Size = New System.Drawing.Size(86, 17)
        Me.optReplaceFan.TabIndex = 30
        Me.optReplaceFan.Text = "Replace Fan"
        Me.optReplaceFan.UseVisualStyleBackColor = True
        '
        'optFanWallBypassNew
        '
        Me.optFanWallBypassNew.AutoSize = True
        Me.optFanWallBypassNew.Location = New System.Drawing.Point(6, 88)
        Me.optFanWallBypassNew.Name = "optFanWallBypassNew"
        Me.optFanWallBypassNew.Size = New System.Drawing.Size(180, 17)
        Me.optFanWallBypassNew.TabIndex = 29
        Me.optFanWallBypassNew.Text = "Fan Wall Bypass (New Sheaves)"
        Me.optFanWallBypassNew.UseVisualStyleBackColor = True
        '
        'optFanWallBypassExisting
        '
        Me.optFanWallBypassExisting.AutoSize = True
        Me.optFanWallBypassExisting.Checked = True
        Me.optFanWallBypassExisting.Location = New System.Drawing.Point(7, 65)
        Me.optFanWallBypassExisting.Name = "optFanWallBypassExisting"
        Me.optFanWallBypassExisting.Size = New System.Drawing.Size(194, 17)
        Me.optFanWallBypassExisting.TabIndex = 28
        Me.optFanWallBypassExisting.TabStop = True
        Me.optFanWallBypassExisting.Text = "Fan Wall Bypass (Existing Sheaves)"
        Me.optFanWallBypassExisting.UseVisualStyleBackColor = True
        '
        'optResheave
        '
        Me.optResheave.AutoSize = True
        Me.optResheave.Location = New System.Drawing.Point(7, 42)
        Me.optResheave.Name = "optResheave"
        Me.optResheave.Size = New System.Drawing.Size(74, 17)
        Me.optResheave.TabIndex = 27
        Me.optResheave.Text = "Resheave"
        Me.optResheave.UseVisualStyleBackColor = True
        '
        'optExistingSheaves
        '
        Me.optExistingSheaves.AutoSize = True
        Me.optExistingSheaves.Location = New System.Drawing.Point(6, 19)
        Me.optExistingSheaves.Name = "optExistingSheaves"
        Me.optExistingSheaves.Size = New System.Drawing.Size(138, 17)
        Me.optExistingSheaves.TabIndex = 26
        Me.optExistingSheaves.Text = "Adjust Existing Sheaves"
        Me.optExistingSheaves.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(544, 210)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 24
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.GroupBox3)
        Me.tpgControls.Controls.Add(Me.GroupBox2)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(591, 242)
        Me.tpgControls.TabIndex = 2
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optIPU)
        Me.GroupBox3.Controls.Add(Me.optSE)
        Me.GroupBox3.Location = New System.Drawing.Point(211, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 67)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Base Unit Control"
        '
        'optIPU
        '
        Me.optIPU.AutoSize = True
        Me.optIPU.Enabled = False
        Me.optIPU.Location = New System.Drawing.Point(14, 46)
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
        Me.optSE.Location = New System.Drawing.Point(14, 20)
        Me.optSE.Name = "optSE"
        Me.optSE.Size = New System.Drawing.Size(86, 17)
        Me.optSE.TabIndex = 0
        Me.optSE.TabStop = True
        Me.optSE.Text = "SE Controller"
        Me.optSE.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAntiFrostProtection)
        Me.GroupBox2.Controls.Add(Me.chkElecHeatProtection)
        Me.GroupBox2.Controls.Add(Me.chkGasHeatProtection)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 89)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine Protection"
        '
        'chkAntiFrostProtection
        '
        Me.chkAntiFrostProtection.AutoSize = True
        Me.chkAntiFrostProtection.Checked = True
        Me.chkAntiFrostProtection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAntiFrostProtection.Location = New System.Drawing.Point(6, 65)
        Me.chkAntiFrostProtection.Name = "chkAntiFrostProtection"
        Me.chkAntiFrostProtection.Size = New System.Drawing.Size(121, 17)
        Me.chkAntiFrostProtection.TabIndex = 29
        Me.chkAntiFrostProtection.Text = "Anti-Frost Protection"
        Me.chkAntiFrostProtection.UseVisualStyleBackColor = True
        '
        'chkElecHeatProtection
        '
        Me.chkElecHeatProtection.AutoSize = True
        Me.chkElecHeatProtection.Location = New System.Drawing.Point(6, 42)
        Me.chkElecHeatProtection.Name = "chkElecHeatProtection"
        Me.chkElecHeatProtection.Size = New System.Drawing.Size(138, 17)
        Me.chkElecHeatProtection.TabIndex = 28
        Me.chkElecHeatProtection.Text = "Electric Heat Protection"
        Me.chkElecHeatProtection.UseVisualStyleBackColor = True
        '
        'chkGasHeatProtection
        '
        Me.chkGasHeatProtection.AutoSize = True
        Me.chkGasHeatProtection.Location = New System.Drawing.Point(6, 19)
        Me.chkGasHeatProtection.Name = "chkGasHeatProtection"
        Me.chkGasHeatProtection.Size = New System.Drawing.Size(114, 17)
        Me.chkGasHeatProtection.TabIndex = 27
        Me.chkGasHeatProtection.Text = "Gas HX Protection"
        Me.chkGasHeatProtection.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(544, 210)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 25
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.Label34)
        Me.tpgPerformance.Controls.Add(Me.txtFaceVelocity)
        Me.tpgPerformance.Controls.Add(Me.Label35)
        Me.tpgPerformance.Controls.Add(Me.Label33)
        Me.tpgPerformance.Controls.Add(Me.lblFanHeat)
        Me.tpgPerformance.Controls.Add(Me.cmdFanHeatCalc)
        Me.tpgPerformance.Controls.Add(Me.Label32)
        Me.tpgPerformance.Controls.Add(Me.Label31)
        Me.tpgPerformance.Controls.Add(Me.Label29)
        Me.tpgPerformance.Controls.Add(Me.Label30)
        Me.tpgPerformance.Controls.Add(Me.txtUnitLATwb)
        Me.tpgPerformance.Controls.Add(Me.txtUnitLATdb)
        Me.tpgPerformance.Controls.Add(Me.txtFanRPM)
        Me.tpgPerformance.Controls.Add(Me.lblRPM)
        Me.tpgPerformance.Controls.Add(Me.lblFanbhp2)
        Me.tpgPerformance.Controls.Add(Me.txtFanBHP)
        Me.tpgPerformance.Controls.Add(Me.lblFanHP)
        Me.tpgPerformance.Controls.Add(Me.Label27)
        Me.tpgPerformance.Controls.Add(Me.txtHeatingLAT)
        Me.tpgPerformance.Controls.Add(Me.Label28)
        Me.tpgPerformance.Controls.Add(Me.Label26)
        Me.tpgPerformance.Controls.Add(Me.Label25)
        Me.tpgPerformance.Controls.Add(Me.txtBypassAF)
        Me.tpgPerformance.Controls.Add(Me.Label22)
        Me.tpgPerformance.Controls.Add(Me.Label21)
        Me.tpgPerformance.Controls.Add(Me.txtLAWB)
        Me.tpgPerformance.Controls.Add(Me.txtLADB)
        Me.tpgPerformance.Controls.Add(Me.Label15)
        Me.tpgPerformance.Controls.Add(Me.Label10)
        Me.tpgPerformance.Controls.Add(Me.Label20)
        Me.tpgPerformance.Controls.Add(Me.Label19)
        Me.tpgPerformance.Controls.Add(Me.Label18)
        Me.tpgPerformance.Controls.Add(Me.Label17)
        Me.tpgPerformance.Controls.Add(Me.Label16)
        Me.tpgPerformance.Controls.Add(Me.txtFinalEnth)
        Me.tpgPerformance.Controls.Add(Me.txtPower)
        Me.tpgPerformance.Controls.Add(Me.txtSCap)
        Me.tpgPerformance.Controls.Add(Me.txtTCap)
        Me.tpgPerformance.Controls.Add(Me.txtDBfromPsych)
        Me.tpgPerformance.Controls.Add(Me.Label14)
        Me.tpgPerformance.Controls.Add(Me.Label13)
        Me.tpgPerformance.Controls.Add(Me.Label12)
        Me.tpgPerformance.Controls.Add(Me.Label11)
        Me.tpgPerformance.Controls.Add(Me.Label9)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(591, 242)
        Me.tpgPerformance.TabIndex = 4
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(558, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(27, 13)
        Me.Label33.TabIndex = 85
        Me.Label33.Tag = ""
        Me.Label33.Text = "mbh"
        '
        'lblFanHeat
        '
        Me.lblFanHeat.AutoSize = True
        Me.lblFanHeat.Location = New System.Drawing.Point(509, 91)
        Me.lblFanHeat.Name = "lblFanHeat"
        Me.lblFanHeat.Size = New System.Drawing.Size(43, 13)
        Me.lblFanHeat.TabIndex = 84
        Me.lblFanHeat.Tag = ""
        Me.lblFanHeat.Text = "fanheat"
        '
        'cmdFanHeatCalc
        '
        Me.cmdFanHeatCalc.Location = New System.Drawing.Point(462, 85)
        Me.cmdFanHeatCalc.Name = "cmdFanHeatCalc"
        Me.cmdFanHeatCalc.Size = New System.Drawing.Size(41, 23)
        Me.cmdFanHeatCalc.TabIndex = 83
        Me.cmdFanHeatCalc.Text = "Calc"
        Me.cmdFanHeatCalc.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(479, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(26, 13)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "Unit"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(371, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 13)
        Me.Label31.TabIndex = 81
        Me.Label31.Text = "Coil"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(522, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(17, 13)
        Me.Label29.TabIndex = 80
        Me.Label29.Tag = ""
        Me.Label29.Text = "°F"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(522, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(17, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Tag = ""
        Me.Label30.Text = "°F"
        '
        'txtUnitLATwb
        '
        Me.txtUnitLATwb.Location = New System.Drawing.Point(462, 61)
        Me.txtUnitLATwb.Name = "txtUnitLATwb"
        Me.txtUnitLATwb.Size = New System.Drawing.Size(54, 20)
        Me.txtUnitLATwb.TabIndex = 78
        '
        'txtUnitLATdb
        '
        Me.txtUnitLATdb.Location = New System.Drawing.Point(462, 36)
        Me.txtUnitLATdb.Name = "txtUnitLATdb"
        Me.txtUnitLATdb.Size = New System.Drawing.Size(54, 20)
        Me.txtUnitLATdb.TabIndex = 77
        '
        'txtFanRPM
        '
        Me.txtFanRPM.Location = New System.Drawing.Point(133, 176)
        Me.txtFanRPM.Name = "txtFanRPM"
        Me.txtFanRPM.Size = New System.Drawing.Size(54, 20)
        Me.txtFanRPM.TabIndex = 19
        '
        'lblRPM
        '
        Me.lblRPM.AutoSize = True
        Me.lblRPM.Location = New System.Drawing.Point(48, 179)
        Me.lblRPM.Name = "lblRPM"
        Me.lblRPM.Size = New System.Drawing.Size(52, 13)
        Me.lblRPM.TabIndex = 76
        Me.lblRPM.Text = "Fan RPM"
        '
        'lblFanbhp2
        '
        Me.lblFanbhp2.AutoSize = True
        Me.lblFanbhp2.Location = New System.Drawing.Point(193, 205)
        Me.lblFanbhp2.Name = "lblFanbhp2"
        Me.lblFanbhp2.Size = New System.Drawing.Size(25, 13)
        Me.lblFanbhp2.TabIndex = 74
        Me.lblFanbhp2.Tag = ""
        Me.lblFanbhp2.Text = "bhp"
        '
        'txtFanBHP
        '
        Me.txtFanBHP.Location = New System.Drawing.Point(133, 202)
        Me.txtFanBHP.Name = "txtFanBHP"
        Me.txtFanBHP.Size = New System.Drawing.Size(54, 20)
        Me.txtFanBHP.TabIndex = 20
        '
        'lblFanHP
        '
        Me.lblFanHP.AutoSize = True
        Me.lblFanHP.Location = New System.Drawing.Point(57, 205)
        Me.lblFanHP.Name = "lblFanHP"
        Me.lblFanHP.Size = New System.Drawing.Size(43, 13)
        Me.lblFanHP.TabIndex = 73
        Me.lblFanHP.Text = "Fan HP"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(415, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Tag = ""
        Me.Label27.Text = "°F"
        '
        'txtHeatingLAT
        '
        Me.txtHeatingLAT.Location = New System.Drawing.Point(356, 115)
        Me.txtHeatingLAT.Name = "txtHeatingLAT"
        Me.txtHeatingLAT.Size = New System.Drawing.Size(54, 20)
        Me.txtHeatingLAT.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(232, 118)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(118, 13)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Heating Leaving Air DB"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(415, 178)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 68
        Me.Label26.Tag = ""
        Me.Label26.Text = "cfm"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(262, 178)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Bypassed Airflow"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBypassAF
        '
        Me.txtBypassAF.Location = New System.Drawing.Point(355, 173)
        Me.txtBypassAF.Name = "txtBypassAF"
        Me.txtBypassAF.Size = New System.Drawing.Size(55, 20)
        Me.txtBypassAF.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(415, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 13)
        Me.Label22.TabIndex = 65
        Me.Label22.Tag = ""
        Me.Label22.Text = "°F"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(415, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Tag = ""
        Me.Label21.Text = "°F"
        '
        'txtLAWB
        '
        Me.txtLAWB.Location = New System.Drawing.Point(355, 61)
        Me.txtLAWB.Name = "txtLAWB"
        Me.txtLAWB.Size = New System.Drawing.Size(54, 20)
        Me.txtLAWB.TabIndex = 17
        '
        'txtLADB
        '
        Me.txtLADB.Location = New System.Drawing.Point(355, 36)
        Me.txtLADB.Name = "txtLADB"
        Me.txtLADB.Size = New System.Drawing.Size(54, 20)
        Me.txtLADB.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(271, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Leaving Air DB"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Leaving Air WB"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(193, 143)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Tag = ""
        Me.Label20.Text = "°F"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(193, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 58
        Me.Label19.Tag = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(193, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Tag = ""
        Me.Label18.Text = "kW"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(193, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Tag = ""
        Me.Label17.Text = "mbh"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(193, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Tag = ""
        Me.Label16.Text = "mbh"
        '
        'txtFinalEnth
        '
        Me.txtFinalEnth.Location = New System.Drawing.Point(133, 113)
        Me.txtFinalEnth.Name = "txtFinalEnth"
        Me.txtFinalEnth.Size = New System.Drawing.Size(54, 20)
        Me.txtFinalEnth.TabIndex = 14
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(133, 87)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(54, 20)
        Me.txtPower.TabIndex = 13
        '
        'txtSCap
        '
        Me.txtSCap.Location = New System.Drawing.Point(133, 61)
        Me.txtSCap.Name = "txtSCap"
        Me.txtSCap.Size = New System.Drawing.Size(54, 20)
        Me.txtSCap.TabIndex = 12
        '
        'txtTCap
        '
        Me.txtTCap.Location = New System.Drawing.Point(133, 37)
        Me.txtTCap.Name = "txtTCap"
        Me.txtTCap.Size = New System.Drawing.Size(54, 20)
        Me.txtTCap.TabIndex = 11
        '
        'txtDBfromPsych
        '
        Me.txtDBfromPsych.Location = New System.Drawing.Point(133, 139)
        Me.txtDBfromPsych.Name = "txtDBfromPsych"
        Me.txtDBfromPsych.Size = New System.Drawing.Size(54, 20)
        Me.txtDBfromPsych.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "DB from Psych"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Final Enthalpy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Sensible Cooling"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Power"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Total Cooling"
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(544, 210)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 22
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Controls.Add(Me.lblFinalEnthalpy)
        Me.DebugPage.Controls.Add(Me.lblInitialEnthalpy)
        Me.DebugPage.Controls.Add(Me.lblMyAmb)
        Me.DebugPage.Controls.Add(Me.lblLowAmb)
        Me.DebugPage.Controls.Add(Me.lblHiAmb)
        Me.DebugPage.Controls.Add(Me.lblkW2HiAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW2HiAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2HiAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2HiAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblkW1HiAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW1HiAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1HiAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1HiAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblHighAFHiTemp)
        Me.DebugPage.Controls.Add(Me.lblLowAFHiTemp)
        Me.DebugPage.Controls.Add(Me.lblkW2LoAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW2LoAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2LoAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2LoAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblkW1LoAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW1LoAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1LoAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1LoAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblHighAFLowTemp)
        Me.DebugPage.Controls.Add(Me.lblLowAFLowTemp)
        Me.DebugPage.Controls.Add(Me.lblkW3MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblMBH3MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblMyWB)
        Me.DebugPage.Controls.Add(Me.lblkW2MyAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW2MyAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblkW2MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2MyAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2MyAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH2MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblkW1MyAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblkW1MyAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblkW1MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1MyAmbHiAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1MyAmbLoAF)
        Me.DebugPage.Controls.Add(Me.lblMBH1MyAmbMyAF)
        Me.DebugPage.Controls.Add(Me.lblHighAFMyTemp)
        Me.DebugPage.Controls.Add(Me.lblLowAFMyTemp)
        Me.DebugPage.Controls.Add(Me.lblMyAF)
        Me.DebugPage.Controls.Add(Me.lblWB2)
        Me.DebugPage.Controls.Add(Me.lblWB1)
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(591, 242)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Calculations"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'lblFinalEnthalpy
        '
        Me.lblFinalEnthalpy.AutoSize = True
        Me.lblFinalEnthalpy.Location = New System.Drawing.Point(526, 208)
        Me.lblFinalEnthalpy.Name = "lblFinalEnthalpy"
        Me.lblFinalEnthalpy.Size = New System.Drawing.Size(45, 13)
        Me.lblFinalEnthalpy.TabIndex = 44
        Me.lblFinalEnthalpy.Text = "Label38"
        '
        'lblInitialEnthalpy
        '
        Me.lblInitialEnthalpy.AutoSize = True
        Me.lblInitialEnthalpy.Location = New System.Drawing.Point(526, 180)
        Me.lblInitialEnthalpy.Name = "lblInitialEnthalpy"
        Me.lblInitialEnthalpy.Size = New System.Drawing.Size(45, 13)
        Me.lblInitialEnthalpy.TabIndex = 43
        Me.lblInitialEnthalpy.Text = "Label38"
        '
        'lblMyAmb
        '
        Me.lblMyAmb.AutoSize = True
        Me.lblMyAmb.Location = New System.Drawing.Point(384, 63)
        Me.lblMyAmb.Name = "lblMyAmb"
        Me.lblMyAmb.Size = New System.Drawing.Size(59, 13)
        Me.lblMyAmb.TabIndex = 42
        Me.lblMyAmb.Text = "MyAmbient"
        '
        'lblLowAmb
        '
        Me.lblLowAmb.AutoSize = True
        Me.lblLowAmb.ForeColor = System.Drawing.Color.Blue
        Me.lblLowAmb.Location = New System.Drawing.Point(384, 121)
        Me.lblLowAmb.Name = "lblLowAmb"
        Me.lblLowAmb.Size = New System.Drawing.Size(65, 13)
        Me.lblLowAmb.TabIndex = 41
        Me.lblLowAmb.Text = "LowAmbient"
        '
        'lblHiAmb
        '
        Me.lblHiAmb.AutoSize = True
        Me.lblHiAmb.ForeColor = System.Drawing.Color.Red
        Me.lblHiAmb.Location = New System.Drawing.Point(384, 180)
        Me.lblHiAmb.Name = "lblHiAmb"
        Me.lblHiAmb.Size = New System.Drawing.Size(67, 13)
        Me.lblHiAmb.TabIndex = 40
        Me.lblHiAmb.Text = "HighAmbient"
        '
        'lblkW2HiAmbHiAF
        '
        Me.lblkW2HiAmbHiAF.AutoSize = True
        Me.lblkW2HiAmbHiAF.ForeColor = System.Drawing.Color.Red
        Me.lblkW2HiAmbHiAF.Location = New System.Drawing.Point(315, 208)
        Me.lblkW2HiAmbHiAF.Name = "lblkW2HiAmbHiAF"
        Me.lblkW2HiAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2HiAmbHiAF.TabIndex = 39
        Me.lblkW2HiAmbHiAF.Text = "Label57"
        '
        'lblkW2HiAmbLoAF
        '
        Me.lblkW2HiAmbLoAF.AutoSize = True
        Me.lblkW2HiAmbLoAF.ForeColor = System.Drawing.Color.Red
        Me.lblkW2HiAmbLoAF.Location = New System.Drawing.Point(315, 179)
        Me.lblkW2HiAmbLoAF.Name = "lblkW2HiAmbLoAF"
        Me.lblkW2HiAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2HiAmbLoAF.TabIndex = 38
        Me.lblkW2HiAmbLoAF.Text = "Label58"
        '
        'lblMBH2HiAmbHiAF
        '
        Me.lblMBH2HiAmbHiAF.AutoSize = True
        Me.lblMBH2HiAmbHiAF.ForeColor = System.Drawing.Color.Red
        Me.lblMBH2HiAmbHiAF.Location = New System.Drawing.Point(236, 208)
        Me.lblMBH2HiAmbHiAF.Name = "lblMBH2HiAmbHiAF"
        Me.lblMBH2HiAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2HiAmbHiAF.TabIndex = 37
        Me.lblMBH2HiAmbHiAF.Text = "444.4"
        '
        'lblMBH2HiAmbLoAF
        '
        Me.lblMBH2HiAmbLoAF.AutoSize = True
        Me.lblMBH2HiAmbLoAF.ForeColor = System.Drawing.Color.Red
        Me.lblMBH2HiAmbLoAF.Location = New System.Drawing.Point(236, 179)
        Me.lblMBH2HiAmbLoAF.Name = "lblMBH2HiAmbLoAF"
        Me.lblMBH2HiAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2HiAmbLoAF.TabIndex = 36
        Me.lblMBH2HiAmbLoAF.Text = "555.5"
        '
        'lblkW1HiAmbHiAF
        '
        Me.lblkW1HiAmbHiAF.AutoSize = True
        Me.lblkW1HiAmbHiAF.ForeColor = System.Drawing.Color.Red
        Me.lblkW1HiAmbHiAF.Location = New System.Drawing.Point(150, 208)
        Me.lblkW1HiAmbHiAF.Name = "lblkW1HiAmbHiAF"
        Me.lblkW1HiAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1HiAmbHiAF.TabIndex = 35
        Me.lblkW1HiAmbHiAF.Text = "Label61"
        '
        'lblkW1HiAmbLoAF
        '
        Me.lblkW1HiAmbLoAF.AutoSize = True
        Me.lblkW1HiAmbLoAF.ForeColor = System.Drawing.Color.Red
        Me.lblkW1HiAmbLoAF.Location = New System.Drawing.Point(150, 179)
        Me.lblkW1HiAmbLoAF.Name = "lblkW1HiAmbLoAF"
        Me.lblkW1HiAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1HiAmbLoAF.TabIndex = 34
        Me.lblkW1HiAmbLoAF.Text = "Label62"
        '
        'lblMBH1HiAmbHiAF
        '
        Me.lblMBH1HiAmbHiAF.AutoSize = True
        Me.lblMBH1HiAmbHiAF.ForeColor = System.Drawing.Color.Red
        Me.lblMBH1HiAmbHiAF.Location = New System.Drawing.Point(71, 208)
        Me.lblMBH1HiAmbHiAF.Name = "lblMBH1HiAmbHiAF"
        Me.lblMBH1HiAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1HiAmbHiAF.TabIndex = 33
        Me.lblMBH1HiAmbHiAF.Text = "333.3"
        '
        'lblMBH1HiAmbLoAF
        '
        Me.lblMBH1HiAmbLoAF.AutoSize = True
        Me.lblMBH1HiAmbLoAF.ForeColor = System.Drawing.Color.Red
        Me.lblMBH1HiAmbLoAF.Location = New System.Drawing.Point(71, 179)
        Me.lblMBH1HiAmbLoAF.Name = "lblMBH1HiAmbLoAF"
        Me.lblMBH1HiAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1HiAmbLoAF.TabIndex = 32
        Me.lblMBH1HiAmbLoAF.Text = "222.2"
        '
        'lblHighAFHiTemp
        '
        Me.lblHighAFHiTemp.AutoSize = True
        Me.lblHighAFHiTemp.ForeColor = System.Drawing.Color.Red
        Me.lblHighAFHiTemp.Location = New System.Drawing.Point(6, 208)
        Me.lblHighAFHiTemp.Name = "lblHighAFHiTemp"
        Me.lblHighAFHiTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblHighAFHiTemp.TabIndex = 31
        Me.lblHighAFHiTemp.Text = "3000"
        '
        'lblLowAFHiTemp
        '
        Me.lblLowAFHiTemp.AutoSize = True
        Me.lblLowAFHiTemp.ForeColor = System.Drawing.Color.Red
        Me.lblLowAFHiTemp.Location = New System.Drawing.Point(6, 179)
        Me.lblLowAFHiTemp.Name = "lblLowAFHiTemp"
        Me.lblLowAFHiTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblLowAFHiTemp.TabIndex = 30
        Me.lblLowAFHiTemp.Text = "2500"
        '
        'lblkW2LoAmbHiAF
        '
        Me.lblkW2LoAmbHiAF.AutoSize = True
        Me.lblkW2LoAmbHiAF.ForeColor = System.Drawing.Color.Blue
        Me.lblkW2LoAmbHiAF.Location = New System.Drawing.Point(315, 150)
        Me.lblkW2LoAmbHiAF.Name = "lblkW2LoAmbHiAF"
        Me.lblkW2LoAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2LoAmbHiAF.TabIndex = 29
        Me.lblkW2LoAmbHiAF.Text = "Label47"
        '
        'lblkW2LoAmbLoAF
        '
        Me.lblkW2LoAmbLoAF.AutoSize = True
        Me.lblkW2LoAmbLoAF.ForeColor = System.Drawing.Color.Blue
        Me.lblkW2LoAmbLoAF.Location = New System.Drawing.Point(315, 121)
        Me.lblkW2LoAmbLoAF.Name = "lblkW2LoAmbLoAF"
        Me.lblkW2LoAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2LoAmbLoAF.TabIndex = 28
        Me.lblkW2LoAmbLoAF.Text = "Label48"
        '
        'lblMBH2LoAmbHiAF
        '
        Me.lblMBH2LoAmbHiAF.AutoSize = True
        Me.lblMBH2LoAmbHiAF.ForeColor = System.Drawing.Color.Blue
        Me.lblMBH2LoAmbHiAF.Location = New System.Drawing.Point(236, 150)
        Me.lblMBH2LoAmbHiAF.Name = "lblMBH2LoAmbHiAF"
        Me.lblMBH2LoAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2LoAmbHiAF.TabIndex = 27
        Me.lblMBH2LoAmbHiAF.Text = "444.4"
        '
        'lblMBH2LoAmbLoAF
        '
        Me.lblMBH2LoAmbLoAF.AutoSize = True
        Me.lblMBH2LoAmbLoAF.ForeColor = System.Drawing.Color.Blue
        Me.lblMBH2LoAmbLoAF.Location = New System.Drawing.Point(236, 121)
        Me.lblMBH2LoAmbLoAF.Name = "lblMBH2LoAmbLoAF"
        Me.lblMBH2LoAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2LoAmbLoAF.TabIndex = 26
        Me.lblMBH2LoAmbLoAF.Text = "555.5"
        '
        'lblkW1LoAmbHiAF
        '
        Me.lblkW1LoAmbHiAF.AutoSize = True
        Me.lblkW1LoAmbHiAF.ForeColor = System.Drawing.Color.Blue
        Me.lblkW1LoAmbHiAF.Location = New System.Drawing.Point(150, 150)
        Me.lblkW1LoAmbHiAF.Name = "lblkW1LoAmbHiAF"
        Me.lblkW1LoAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1LoAmbHiAF.TabIndex = 25
        Me.lblkW1LoAmbHiAF.Text = "Label51"
        '
        'lblkW1LoAmbLoAF
        '
        Me.lblkW1LoAmbLoAF.AutoSize = True
        Me.lblkW1LoAmbLoAF.ForeColor = System.Drawing.Color.Blue
        Me.lblkW1LoAmbLoAF.Location = New System.Drawing.Point(150, 121)
        Me.lblkW1LoAmbLoAF.Name = "lblkW1LoAmbLoAF"
        Me.lblkW1LoAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1LoAmbLoAF.TabIndex = 24
        Me.lblkW1LoAmbLoAF.Text = "Label52"
        '
        'lblMBH1LoAmbHiAF
        '
        Me.lblMBH1LoAmbHiAF.AutoSize = True
        Me.lblMBH1LoAmbHiAF.ForeColor = System.Drawing.Color.Blue
        Me.lblMBH1LoAmbHiAF.Location = New System.Drawing.Point(71, 150)
        Me.lblMBH1LoAmbHiAF.Name = "lblMBH1LoAmbHiAF"
        Me.lblMBH1LoAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1LoAmbHiAF.TabIndex = 23
        Me.lblMBH1LoAmbHiAF.Text = "333.3"
        '
        'lblMBH1LoAmbLoAF
        '
        Me.lblMBH1LoAmbLoAF.AutoSize = True
        Me.lblMBH1LoAmbLoAF.ForeColor = System.Drawing.Color.Blue
        Me.lblMBH1LoAmbLoAF.Location = New System.Drawing.Point(71, 121)
        Me.lblMBH1LoAmbLoAF.Name = "lblMBH1LoAmbLoAF"
        Me.lblMBH1LoAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1LoAmbLoAF.TabIndex = 22
        Me.lblMBH1LoAmbLoAF.Text = "222.2"
        '
        'lblHighAFLowTemp
        '
        Me.lblHighAFLowTemp.AutoSize = True
        Me.lblHighAFLowTemp.ForeColor = System.Drawing.Color.Blue
        Me.lblHighAFLowTemp.Location = New System.Drawing.Point(6, 150)
        Me.lblHighAFLowTemp.Name = "lblHighAFLowTemp"
        Me.lblHighAFLowTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblHighAFLowTemp.TabIndex = 21
        Me.lblHighAFLowTemp.Text = "3000"
        '
        'lblLowAFLowTemp
        '
        Me.lblLowAFLowTemp.AutoSize = True
        Me.lblLowAFLowTemp.ForeColor = System.Drawing.Color.Blue
        Me.lblLowAFLowTemp.Location = New System.Drawing.Point(6, 121)
        Me.lblLowAFLowTemp.Name = "lblLowAFLowTemp"
        Me.lblLowAFLowTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblLowAFLowTemp.TabIndex = 20
        Me.lblLowAFLowTemp.Text = "2500"
        '
        'lblkW3MyAmbMyAF
        '
        Me.lblkW3MyAmbMyAF.AutoSize = True
        Me.lblkW3MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblkW3MyAmbMyAF.Location = New System.Drawing.Point(463, 35)
        Me.lblkW3MyAmbMyAF.Name = "lblkW3MyAmbMyAF"
        Me.lblkW3MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW3MyAmbMyAF.TabIndex = 19
        Me.lblkW3MyAmbMyAF.Text = "Label44"
        '
        'lblMBH3MyAmbMyAF
        '
        Me.lblMBH3MyAmbMyAF.AutoSize = True
        Me.lblMBH3MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblMBH3MyAmbMyAF.Location = New System.Drawing.Point(384, 35)
        Me.lblMBH3MyAmbMyAF.Name = "lblMBH3MyAmbMyAF"
        Me.lblMBH3MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblMBH3MyAmbMyAF.TabIndex = 18
        Me.lblMBH3MyAmbMyAF.Text = "Label45"
        '
        'lblMyWB
        '
        Me.lblMyWB.AutoSize = True
        Me.lblMyWB.Location = New System.Drawing.Point(422, 13)
        Me.lblMyWB.Name = "lblMyWB"
        Me.lblMyWB.Size = New System.Drawing.Size(50, 13)
        Me.lblMyWB.TabIndex = 17
        Me.lblMyWB.Text = "New WB"
        '
        'lblkW2MyAmbHiAF
        '
        Me.lblkW2MyAmbHiAF.AutoSize = True
        Me.lblkW2MyAmbHiAF.Location = New System.Drawing.Point(315, 92)
        Me.lblkW2MyAmbHiAF.Name = "lblkW2MyAmbHiAF"
        Me.lblkW2MyAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2MyAmbHiAF.TabIndex = 16
        Me.lblkW2MyAmbHiAF.Text = "Label38"
        '
        'lblkW2MyAmbLoAF
        '
        Me.lblkW2MyAmbLoAF.AutoSize = True
        Me.lblkW2MyAmbLoAF.Location = New System.Drawing.Point(315, 63)
        Me.lblkW2MyAmbLoAF.Name = "lblkW2MyAmbLoAF"
        Me.lblkW2MyAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2MyAmbLoAF.TabIndex = 15
        Me.lblkW2MyAmbLoAF.Text = "Label39"
        '
        'lblkW2MyAmbMyAF
        '
        Me.lblkW2MyAmbMyAF.AutoSize = True
        Me.lblkW2MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblkW2MyAmbMyAF.Location = New System.Drawing.Point(315, 35)
        Me.lblkW2MyAmbMyAF.Name = "lblkW2MyAmbMyAF"
        Me.lblkW2MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW2MyAmbMyAF.TabIndex = 14
        Me.lblkW2MyAmbMyAF.Text = "Label40"
        '
        'lblMBH2MyAmbHiAF
        '
        Me.lblMBH2MyAmbHiAF.AutoSize = True
        Me.lblMBH2MyAmbHiAF.Location = New System.Drawing.Point(236, 92)
        Me.lblMBH2MyAmbHiAF.Name = "lblMBH2MyAmbHiAF"
        Me.lblMBH2MyAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2MyAmbHiAF.TabIndex = 13
        Me.lblMBH2MyAmbHiAF.Text = "444.4"
        '
        'lblMBH2MyAmbLoAF
        '
        Me.lblMBH2MyAmbLoAF.AutoSize = True
        Me.lblMBH2MyAmbLoAF.Location = New System.Drawing.Point(236, 63)
        Me.lblMBH2MyAmbLoAF.Name = "lblMBH2MyAmbLoAF"
        Me.lblMBH2MyAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH2MyAmbLoAF.TabIndex = 12
        Me.lblMBH2MyAmbLoAF.Text = "555.5"
        '
        'lblMBH2MyAmbMyAF
        '
        Me.lblMBH2MyAmbMyAF.AutoSize = True
        Me.lblMBH2MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblMBH2MyAmbMyAF.Location = New System.Drawing.Point(236, 35)
        Me.lblMBH2MyAmbMyAF.Name = "lblMBH2MyAmbMyAF"
        Me.lblMBH2MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblMBH2MyAmbMyAF.TabIndex = 11
        Me.lblMBH2MyAmbMyAF.Text = "Label43"
        '
        'lblkW1MyAmbHiAF
        '
        Me.lblkW1MyAmbHiAF.AutoSize = True
        Me.lblkW1MyAmbHiAF.Location = New System.Drawing.Point(150, 92)
        Me.lblkW1MyAmbHiAF.Name = "lblkW1MyAmbHiAF"
        Me.lblkW1MyAmbHiAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1MyAmbHiAF.TabIndex = 10
        Me.lblkW1MyAmbHiAF.Text = "Label35"
        '
        'lblkW1MyAmbLoAF
        '
        Me.lblkW1MyAmbLoAF.AutoSize = True
        Me.lblkW1MyAmbLoAF.Location = New System.Drawing.Point(150, 63)
        Me.lblkW1MyAmbLoAF.Name = "lblkW1MyAmbLoAF"
        Me.lblkW1MyAmbLoAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1MyAmbLoAF.TabIndex = 9
        Me.lblkW1MyAmbLoAF.Text = "Label36"
        '
        'lblkW1MyAmbMyAF
        '
        Me.lblkW1MyAmbMyAF.AutoSize = True
        Me.lblkW1MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblkW1MyAmbMyAF.Location = New System.Drawing.Point(150, 35)
        Me.lblkW1MyAmbMyAF.Name = "lblkW1MyAmbMyAF"
        Me.lblkW1MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblkW1MyAmbMyAF.TabIndex = 8
        Me.lblkW1MyAmbMyAF.Text = "Label37"
        '
        'lblMBH1MyAmbHiAF
        '
        Me.lblMBH1MyAmbHiAF.AutoSize = True
        Me.lblMBH1MyAmbHiAF.Location = New System.Drawing.Point(71, 92)
        Me.lblMBH1MyAmbHiAF.Name = "lblMBH1MyAmbHiAF"
        Me.lblMBH1MyAmbHiAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1MyAmbHiAF.TabIndex = 7
        Me.lblMBH1MyAmbHiAF.Text = "333.3"
        '
        'lblMBH1MyAmbLoAF
        '
        Me.lblMBH1MyAmbLoAF.AutoSize = True
        Me.lblMBH1MyAmbLoAF.Location = New System.Drawing.Point(71, 63)
        Me.lblMBH1MyAmbLoAF.Name = "lblMBH1MyAmbLoAF"
        Me.lblMBH1MyAmbLoAF.Size = New System.Drawing.Size(34, 13)
        Me.lblMBH1MyAmbLoAF.TabIndex = 6
        Me.lblMBH1MyAmbLoAF.Text = "222.2"
        '
        'lblMBH1MyAmbMyAF
        '
        Me.lblMBH1MyAmbMyAF.AutoSize = True
        Me.lblMBH1MyAmbMyAF.ForeColor = System.Drawing.Color.Green
        Me.lblMBH1MyAmbMyAF.Location = New System.Drawing.Point(71, 35)
        Me.lblMBH1MyAmbMyAF.Name = "lblMBH1MyAmbMyAF"
        Me.lblMBH1MyAmbMyAF.Size = New System.Drawing.Size(45, 13)
        Me.lblMBH1MyAmbMyAF.TabIndex = 5
        Me.lblMBH1MyAmbMyAF.Text = "Label34"
        '
        'lblHighAFMyTemp
        '
        Me.lblHighAFMyTemp.AutoSize = True
        Me.lblHighAFMyTemp.Location = New System.Drawing.Point(6, 92)
        Me.lblHighAFMyTemp.Name = "lblHighAFMyTemp"
        Me.lblHighAFMyTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblHighAFMyTemp.TabIndex = 4
        Me.lblHighAFMyTemp.Text = "3000"
        '
        'lblLowAFMyTemp
        '
        Me.lblLowAFMyTemp.AutoSize = True
        Me.lblLowAFMyTemp.Location = New System.Drawing.Point(6, 63)
        Me.lblLowAFMyTemp.Name = "lblLowAFMyTemp"
        Me.lblLowAFMyTemp.Size = New System.Drawing.Size(31, 13)
        Me.lblLowAFMyTemp.TabIndex = 3
        Me.lblLowAFMyTemp.Text = "2500"
        '
        'lblMyAF
        '
        Me.lblMyAF.AutoSize = True
        Me.lblMyAF.Location = New System.Drawing.Point(6, 35)
        Me.lblMyAF.Name = "lblMyAF"
        Me.lblMyAF.Size = New System.Drawing.Size(42, 13)
        Me.lblMyAF.TabIndex = 2
        Me.lblMyAF.Text = "NewAF"
        '
        'lblWB2
        '
        Me.lblWB2.AutoSize = True
        Me.lblWB2.Location = New System.Drawing.Point(274, 13)
        Me.lblWB2.Name = "lblWB2"
        Me.lblWB2.Size = New System.Drawing.Size(40, 13)
        Me.lblWB2.TabIndex = 1
        Me.lblWB2.Text = "72 WB"
        '
        'lblWB1
        '
        Me.lblWB1.AutoSize = True
        Me.lblWB1.Location = New System.Drawing.Point(106, 13)
        Me.lblWB1.Name = "lblWB1"
        Me.lblWB1.Size = New System.Drawing.Size(49, 13)
        Me.lblWB1.TabIndex = 0
        Me.lblWB1.Text = "77.0 WB"
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(222, 303)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 3
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(416, 91)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 13)
        Me.Label34.TabIndex = 88
        Me.Label34.Tag = ""
        Me.Label34.Text = "fpm"
        '
        'txtFaceVelocity
        '
        Me.txtFaceVelocity.Location = New System.Drawing.Point(356, 88)
        Me.txtFaceVelocity.Name = "txtFaceVelocity"
        Me.txtFaceVelocity.Size = New System.Drawing.Size(54, 20)
        Me.txtFaceVelocity.TabIndex = 86
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(279, 90)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 13)
        Me.Label35.TabIndex = 87
        Me.Label35.Text = "Face Velocity"
        '
        'lblsqftevap
        '
        Me.lblsqftevap.AutoSize = True
        Me.lblsqftevap.Location = New System.Drawing.Point(12, 188)
        Me.lblsqftevap.Name = "lblsqftevap"
        Me.lblsqftevap.Size = New System.Drawing.Size(24, 13)
        Me.lblsqftevap.TabIndex = 54
        Me.lblsqftevap.Text = "sqft"
        Me.lblsqftevap.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmLowAF
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(612, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLowAF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reduced Air Flow"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.DebugPage.ResumeLayout(False)
        Me.DebugPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHeatEAT As TextBox
    Friend WithEvents txtEWB As TextBox
    Friend WithEvents txtEDB As TextBox
    Friend WithEvents txtAmbient As TextBox
    Friend WithEvents txtESP As TextBox
    Friend WithEvents txtAirflow As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFinalEnth As TextBox
    Friend WithEvents txtPower As TextBox
    Friend WithEvents txtSCap As TextBox
    Friend WithEvents txtTCap As TextBox
    Friend WithEvents txtDBfromPsych As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtLAWB As TextBox
    Friend WithEvents txtLADB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optReplaceFan As RadioButton
    Friend WithEvents optFanWallBypassNew As RadioButton
    Friend WithEvents optFanWallBypassExisting As RadioButton
    Friend WithEvents optResheave As RadioButton
    Friend WithEvents optExistingSheaves As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents txtMinCatAirflow As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtNominalAirflow As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkAntiFrostProtection As CheckBox
    Friend WithEvents chkElecHeatProtection As CheckBox
    Friend WithEvents chkGasHeatProtection As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtBypassAF As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtHeatingLAT As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents chkSeriesConversion As CheckBox
    Friend WithEvents txtFanRPM As TextBox
    Friend WithEvents lblRPM As Label
    Friend WithEvents lblFanbhp2 As Label
    Friend WithEvents txtFanBHP As TextBox
    Friend WithEvents lblFanHP As Label
    Friend WithEvents lblkW3MyAmbMyAF As Label
    Friend WithEvents lblMBH3MyAmbMyAF As Label
    Friend WithEvents lblMyWB As Label
    Friend WithEvents lblkW2MyAmbHiAF As Label
    Friend WithEvents lblkW2MyAmbLoAF As Label
    Friend WithEvents lblkW2MyAmbMyAF As Label
    Friend WithEvents lblMBH2MyAmbHiAF As Label
    Friend WithEvents lblMBH2MyAmbLoAF As Label
    Friend WithEvents lblMBH2MyAmbMyAF As Label
    Friend WithEvents lblkW1MyAmbHiAF As Label
    Friend WithEvents lblkW1MyAmbLoAF As Label
    Friend WithEvents lblkW1MyAmbMyAF As Label
    Friend WithEvents lblMBH1MyAmbHiAF As Label
    Friend WithEvents lblMBH1MyAmbLoAF As Label
    Friend WithEvents lblMBH1MyAmbMyAF As Label
    Friend WithEvents lblHighAFMyTemp As Label
    Friend WithEvents lblLowAFMyTemp As Label
    Friend WithEvents lblMyAF As Label
    Friend WithEvents lblWB2 As Label
    Friend WithEvents lblWB1 As Label
    Friend WithEvents lblMyAmb As Label
    Friend WithEvents lblLowAmb As Label
    Friend WithEvents lblHiAmb As Label
    Friend WithEvents lblkW2HiAmbHiAF As Label
    Friend WithEvents lblkW2HiAmbLoAF As Label
    Friend WithEvents lblMBH2HiAmbHiAF As Label
    Friend WithEvents lblMBH2HiAmbLoAF As Label
    Friend WithEvents lblkW1HiAmbHiAF As Label
    Friend WithEvents lblkW1HiAmbLoAF As Label
    Friend WithEvents lblMBH1HiAmbHiAF As Label
    Friend WithEvents lblMBH1HiAmbLoAF As Label
    Friend WithEvents lblHighAFHiTemp As Label
    Friend WithEvents lblLowAFHiTemp As Label
    Friend WithEvents lblkW2LoAmbHiAF As Label
    Friend WithEvents lblkW2LoAmbLoAF As Label
    Friend WithEvents lblMBH2LoAmbHiAF As Label
    Friend WithEvents lblMBH2LoAmbLoAF As Label
    Friend WithEvents lblkW1LoAmbHiAF As Label
    Friend WithEvents lblkW1LoAmbLoAF As Label
    Friend WithEvents lblMBH1LoAmbHiAF As Label
    Friend WithEvents lblMBH1LoAmbLoAF As Label
    Friend WithEvents lblHighAFLowTemp As Label
    Friend WithEvents lblLowAFLowTemp As Label
    Friend WithEvents lblFinalEnthalpy As Label
    Friend WithEvents lblInitialEnthalpy As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optRefDwg2Ckt As RadioButton
    Friend WithEvents optRefDwg1Ckt As RadioButton
    Friend WithEvents optRefDwgNone As RadioButton
    Friend WithEvents chk100OA As CheckBox
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optIPU As RadioButton
    Friend WithEvents optSE As RadioButton
    Friend WithEvents Label33 As Label
    Friend WithEvents lblFanHeat As Label
    Friend WithEvents cmdFanHeatCalc As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtUnitLATwb As TextBox
    Friend WithEvents txtUnitLATdb As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtFaceVelocity As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents lblsqftevap As Label
End Class
