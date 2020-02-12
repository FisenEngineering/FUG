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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLowAF))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.lblsqftevap = New System.Windows.Forms.Label()
        Me.chk100OA = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.cmdMethodSuggest = New System.Windows.Forms.Button()
        Me.optReplaceFan = New System.Windows.Forms.RadioButton()
        Me.optFanWallBypassNew = New System.Windows.Forms.RadioButton()
        Me.optFanWallBypassExisting = New System.Windows.Forms.RadioButton()
        Me.optResheave = New System.Windows.Forms.RadioButton()
        Me.optExistingSheaves = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtMinCatHeatAF = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optIPU = New System.Windows.Forms.RadioButton()
        Me.optSE = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAntiFrostProtection = New System.Windows.Forms.CheckBox()
        Me.chkElecHeatProtection = New System.Windows.Forms.CheckBox()
        Me.chkGasHeatProtection = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.cmdCalcDehumCap = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDehumCap = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtFaceVelocity = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
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
        Me.tpgCoolCalc = New System.Windows.Forms.TabPage()
        Me.tpgStaticSummary = New System.Windows.Forms.TabPage()
        Me.dgvStaticSummary = New System.Windows.Forms.DataGridView()
        Me.ColItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrigSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdjSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtHeatingAF = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.tpgStaticSummary.SuspendLayout()
        CType(Me.dgvStaticSummary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.tpgCoolCalc)
        Me.TabControl1.Controls.Add(Me.tpgStaticSummary)
        Me.TabControl1.Location = New System.Drawing.Point(7, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(599, 268)
        Me.TabControl1.TabIndex = 2
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.Label39)
        Me.tpgConditions.Controls.Add(Me.txtHeatingAF)
        Me.tpgConditions.Controls.Add(Me.lblsqftevap)
        Me.tpgConditions.Controls.Add(Me.chk100OA)
        Me.tpgConditions.Controls.Add(Me.Label8)
        Me.tpgConditions.Controls.Add(Me.Label7)
        Me.tpgConditions.Controls.Add(Me.Label4)
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
        'lblsqftevap
        '
        Me.lblsqftevap.AutoSize = True
        Me.lblsqftevap.Location = New System.Drawing.Point(12, 218)
        Me.lblsqftevap.Name = "lblsqftevap"
        Me.lblsqftevap.Size = New System.Drawing.Size(24, 13)
        Me.lblsqftevap.TabIndex = 54
        Me.lblsqftevap.Text = "sqft"
        Me.lblsqftevap.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblsqftevap.Visible = False
        '
        'chk100OA
        '
        Me.chk100OA.AutoSize = True
        Me.chk100OA.Location = New System.Drawing.Point(6, 6)
        Me.chk100OA.Name = "chk100OA"
        Me.chk100OA.Size = New System.Drawing.Size(136, 17)
        Me.chk100OA.TabIndex = 7
        Me.chk100OA.Text = "100% Outdoor Air Unit?"
        Me.chk100OA.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Heating"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Cooling"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Entering DB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Entering WB"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Ambient"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "ESP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Cooling Airflow"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtHeatEAT
        '
        Me.txtHeatEAT.Location = New System.Drawing.Point(171, 157)
        Me.txtHeatEAT.Name = "txtHeatEAT"
        Me.txtHeatEAT.Size = New System.Drawing.Size(63, 20)
        Me.txtHeatEAT.TabIndex = 5
        Me.txtHeatEAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEWB
        '
        Me.txtEWB.Location = New System.Drawing.Point(102, 183)
        Me.txtEWB.Name = "txtEWB"
        Me.txtEWB.Size = New System.Drawing.Size(63, 20)
        Me.txtEWB.TabIndex = 4
        Me.txtEWB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEDB
        '
        Me.txtEDB.Location = New System.Drawing.Point(102, 157)
        Me.txtEDB.Name = "txtEDB"
        Me.txtEDB.Size = New System.Drawing.Size(63, 20)
        Me.txtEDB.TabIndex = 3
        Me.txtEDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmbient
        '
        Me.txtAmbient.Location = New System.Drawing.Point(102, 131)
        Me.txtAmbient.Name = "txtAmbient"
        Me.txtAmbient.Size = New System.Drawing.Size(63, 20)
        Me.txtAmbient.TabIndex = 2
        Me.txtAmbient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtESP
        '
        Me.txtESP.Location = New System.Drawing.Point(234, 64)
        Me.txtESP.Name = "txtESP"
        Me.txtESP.Size = New System.Drawing.Size(63, 20)
        Me.txtESP.TabIndex = 1
        Me.txtESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(234, 38)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(63, 20)
        Me.txtAirflow.TabIndex = 0
        Me.txtAirflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(544, 210)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 6
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
        Me.Label24.Location = New System.Drawing.Point(383, 49)
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
        Me.Label23.Location = New System.Drawing.Point(415, 23)
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
        Me.GroupBox1.Controls.Add(Me.cmdMethodSuggest)
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
        'cmdMethodSuggest
        '
        Me.cmdMethodSuggest.Image = CType(resources.GetObject("cmdMethodSuggest.Image"), System.Drawing.Image)
        Me.cmdMethodSuggest.Location = New System.Drawing.Point(240, 113)
        Me.cmdMethodSuggest.Name = "cmdMethodSuggest"
        Me.cmdMethodSuggest.Size = New System.Drawing.Size(22, 22)
        Me.cmdMethodSuggest.TabIndex = 31
        Me.cmdMethodSuggest.UseVisualStyleBackColor = True
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
        Me.tpgControls.Controls.Add(Me.Label36)
        Me.tpgControls.Controls.Add(Me.txtMinCatHeatAF)
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
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(3, 104)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(138, 13)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Min. Heat Cataloged Airflow"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMinCatHeatAF
        '
        Me.txtMinCatHeatAF.Location = New System.Drawing.Point(142, 101)
        Me.txtMinCatHeatAF.Name = "txtMinCatHeatAF"
        Me.txtMinCatHeatAF.Size = New System.Drawing.Size(63, 20)
        Me.txtMinCatHeatAF.TabIndex = 50
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
        Me.tpgPerformance.Controls.Add(Me.cmdCalcDehumCap)
        Me.tpgPerformance.Controls.Add(Me.Label37)
        Me.tpgPerformance.Controls.Add(Me.txtDehumCap)
        Me.tpgPerformance.Controls.Add(Me.Label38)
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
        'cmdCalcDehumCap
        '
        Me.cmdCalcDehumCap.Image = CType(resources.GetObject("cmdCalcDehumCap.Image"), System.Drawing.Image)
        Me.cmdCalcDehumCap.Location = New System.Drawing.Point(440, 140)
        Me.cmdCalcDehumCap.Name = "cmdCalcDehumCap"
        Me.cmdCalcDehumCap.Size = New System.Drawing.Size(22, 22)
        Me.cmdCalcDehumCap.TabIndex = 92
        Me.cmdCalcDehumCap.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(405, 143)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 13)
        Me.Label37.TabIndex = 91
        Me.Label37.Tag = ""
        Me.Label37.Text = "lb/hr"
        '
        'txtDehumCap
        '
        Me.txtDehumCap.Location = New System.Drawing.Point(346, 140)
        Me.txtDehumCap.Name = "txtDehumCap"
        Me.txtDehumCap.Size = New System.Drawing.Size(54, 20)
        Me.txtDehumCap.TabIndex = 89
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(210, 143)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(129, 13)
        Me.Label38.TabIndex = 90
        Me.Label38.Text = "Dehumidification Capacity"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(406, 91)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 13)
        Me.Label34.TabIndex = 88
        Me.Label34.Tag = ""
        Me.Label34.Text = "fpm"
        '
        'txtFaceVelocity
        '
        Me.txtFaceVelocity.Location = New System.Drawing.Point(346, 88)
        Me.txtFaceVelocity.Name = "txtFaceVelocity"
        Me.txtFaceVelocity.Size = New System.Drawing.Size(54, 20)
        Me.txtFaceVelocity.TabIndex = 86
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(269, 90)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 13)
        Me.Label35.TabIndex = 87
        Me.Label35.Text = "Face Velocity"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(557, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(27, 13)
        Me.Label33.TabIndex = 85
        Me.Label33.Tag = ""
        Me.Label33.Text = "mbh"
        '
        'lblFanHeat
        '
        Me.lblFanHeat.AutoSize = True
        Me.lblFanHeat.Location = New System.Drawing.Point(508, 91)
        Me.lblFanHeat.Name = "lblFanHeat"
        Me.lblFanHeat.Size = New System.Drawing.Size(43, 13)
        Me.lblFanHeat.TabIndex = 84
        Me.lblFanHeat.Tag = ""
        Me.lblFanHeat.Text = "fanheat"
        '
        'cmdFanHeatCalc
        '
        Me.cmdFanHeatCalc.Location = New System.Drawing.Point(461, 85)
        Me.cmdFanHeatCalc.Name = "cmdFanHeatCalc"
        Me.cmdFanHeatCalc.Size = New System.Drawing.Size(41, 23)
        Me.cmdFanHeatCalc.TabIndex = 83
        Me.cmdFanHeatCalc.Text = "Calc"
        Me.cmdFanHeatCalc.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(478, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(26, 13)
        Me.Label32.TabIndex = 82
        Me.Label32.Text = "Unit"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(361, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 13)
        Me.Label31.TabIndex = 81
        Me.Label31.Text = "Coil"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(521, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(17, 13)
        Me.Label29.TabIndex = 80
        Me.Label29.Tag = ""
        Me.Label29.Text = "°F"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(521, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(17, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Tag = ""
        Me.Label30.Text = "°F"
        '
        'txtUnitLATwb
        '
        Me.txtUnitLATwb.Location = New System.Drawing.Point(461, 61)
        Me.txtUnitLATwb.Name = "txtUnitLATwb"
        Me.txtUnitLATwb.Size = New System.Drawing.Size(54, 20)
        Me.txtUnitLATwb.TabIndex = 78
        '
        'txtUnitLATdb
        '
        Me.txtUnitLATdb.Location = New System.Drawing.Point(461, 36)
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
        Me.Label27.Location = New System.Drawing.Point(405, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Tag = ""
        Me.Label27.Text = "°F"
        '
        'txtHeatingLAT
        '
        Me.txtHeatingLAT.Location = New System.Drawing.Point(346, 115)
        Me.txtHeatingLAT.Name = "txtHeatingLAT"
        Me.txtHeatingLAT.Size = New System.Drawing.Size(54, 20)
        Me.txtHeatingLAT.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(222, 118)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(118, 13)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Heating Leaving Air DB"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(404, 207)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 68
        Me.Label26.Tag = ""
        Me.Label26.Text = "cfm"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(251, 207)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Bypassed Airflow"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBypassAF
        '
        Me.txtBypassAF.Location = New System.Drawing.Point(344, 202)
        Me.txtBypassAF.Name = "txtBypassAF"
        Me.txtBypassAF.Size = New System.Drawing.Size(55, 20)
        Me.txtBypassAF.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(405, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 13)
        Me.Label22.TabIndex = 65
        Me.Label22.Tag = ""
        Me.Label22.Text = "°F"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(405, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Tag = ""
        Me.Label21.Text = "°F"
        '
        'txtLAWB
        '
        Me.txtLAWB.Location = New System.Drawing.Point(345, 61)
        Me.txtLAWB.Name = "txtLAWB"
        Me.txtLAWB.Size = New System.Drawing.Size(54, 20)
        Me.txtLAWB.TabIndex = 17
        '
        'txtLADB
        '
        Me.txtLADB.Location = New System.Drawing.Point(345, 36)
        Me.txtLADB.Name = "txtLADB"
        Me.txtLADB.Size = New System.Drawing.Size(54, 20)
        Me.txtLADB.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(261, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Leaving Air DB"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(258, 65)
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
        Me.txtTCap.TabIndex = 0
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
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(591, 242)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'tpgCoolCalc
        '
        Me.tpgCoolCalc.Location = New System.Drawing.Point(4, 22)
        Me.tpgCoolCalc.Name = "tpgCoolCalc"
        Me.tpgCoolCalc.Size = New System.Drawing.Size(591, 242)
        Me.tpgCoolCalc.TabIndex = 5
        Me.tpgCoolCalc.Text = "Cool Perf"
        Me.tpgCoolCalc.UseVisualStyleBackColor = True
        '
        'tpgStaticSummary
        '
        Me.tpgStaticSummary.Controls.Add(Me.dgvStaticSummary)
        Me.tpgStaticSummary.Location = New System.Drawing.Point(4, 22)
        Me.tpgStaticSummary.Name = "tpgStaticSummary"
        Me.tpgStaticSummary.Size = New System.Drawing.Size(591, 242)
        Me.tpgStaticSummary.TabIndex = 6
        Me.tpgStaticSummary.Text = "Static Summary"
        Me.tpgStaticSummary.UseVisualStyleBackColor = True
        '
        'dgvStaticSummary
        '
        Me.dgvStaticSummary.AllowUserToAddRows = False
        Me.dgvStaticSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStaticSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaticSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColItem, Me.colOrigSP, Me.colAdjSP})
        Me.dgvStaticSummary.Location = New System.Drawing.Point(5, 3)
        Me.dgvStaticSummary.Name = "dgvStaticSummary"
        Me.dgvStaticSummary.Size = New System.Drawing.Size(411, 150)
        Me.dgvStaticSummary.TabIndex = 0
        '
        'ColItem
        '
        Me.ColItem.HeaderText = "Item"
        Me.ColItem.Name = "ColItem"
        Me.ColItem.Width = 52
        '
        'colOrigSP
        '
        Me.colOrigSP.HeaderText = "Orig. SP"
        Me.colOrigSP.Name = "colOrigSP"
        Me.colOrigSP.Width = 71
        '
        'colAdjSP
        '
        Me.colAdjSP.HeaderText = "Adj. SP"
        Me.colAdjSP.Name = "colAdjSP"
        Me.colAdjSP.Width = 67
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
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Location = New System.Drawing.Point(510, 291)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(96, 29)
        Me.cmdDesignCautions.TabIndex = 9
        Me.cmdDesignCautions.Text = "Design Cautions"
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(326, 44)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 13)
        Me.Label39.TabIndex = 56
        Me.Label39.Text = "Heating Airflow"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtHeatingAF
        '
        Me.txtHeatingAF.Location = New System.Drawing.Point(410, 41)
        Me.txtHeatingAF.Name = "txtHeatingAF"
        Me.txtHeatingAF.Size = New System.Drawing.Size(63, 20)
        Me.txtHeatingAF.TabIndex = 55
        Me.txtHeatingAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmLowAF
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(612, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDesignCautions)
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
        Me.tpgControls.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.tpgPerformance.PerformLayout()
        Me.tpgStaticSummary.ResumeLayout(False)
        CType(Me.dgvStaticSummary, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label36 As Label
    Friend WithEvents txtMinCatHeatAF As TextBox
    Friend WithEvents cmdMethodSuggest As Button
    Friend WithEvents cmdCalcDehumCap As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents txtDehumCap As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents tpgCoolCalc As TabPage
    Friend WithEvents tpgStaticSummary As TabPage
    Friend WithEvents dgvStaticSummary As DataGridView
    Friend WithEvents ColItem As DataGridViewTextBoxColumn
    Friend WithEvents colOrigSP As DataGridViewTextBoxColumn
    Friend WithEvents colAdjSP As DataGridViewTextBoxColumn
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents txtHeatingAF As TextBox
End Class
