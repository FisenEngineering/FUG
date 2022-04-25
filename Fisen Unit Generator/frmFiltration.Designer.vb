<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFiltration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiltration))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgConditions = New System.Windows.Forms.TabPage()
        Me.grpFFRack = New System.Windows.Forms.GroupBox()
        Me.optFFRackNA = New System.Windows.Forms.RadioButton()
        Me.optFFRackHEPASS = New System.Windows.Forms.RadioButton()
        Me.optFFRackHEPAGalv = New System.Windows.Forms.RadioButton()
        Me.optFFRackSS = New System.Windows.Forms.RadioButton()
        Me.optFFRackGalv = New System.Windows.Forms.RadioButton()
        Me.grpIFRack = New System.Windows.Forms.GroupBox()
        Me.optIFRackNA = New System.Windows.Forms.RadioButton()
        Me.optIFRackHEPASS = New System.Windows.Forms.RadioButton()
        Me.optIFRackHEPAGalv = New System.Windows.Forms.RadioButton()
        Me.optIFRackSS = New System.Windows.Forms.RadioButton()
        Me.optIFRackGalv = New System.Windows.Forms.RadioButton()
        Me.chkIFPrefiltUseJCI = New System.Windows.Forms.CheckBox()
        Me.chkRelocateJCIIFinalPreFilts = New System.Windows.Forms.CheckBox()
        Me.chkRemoveJCIIFinalPreFilts = New System.Windows.Forms.CheckBox()
        Me.chkRelocateJCIFFilts = New System.Windows.Forms.CheckBox()
        Me.chkRelocateJCIIFilts = New System.Windows.Forms.CheckBox()
        Me.chkRelocateJCIIPreFilts = New System.Windows.Forms.CheckBox()
        Me.chkRemoveJCIFFilts = New System.Windows.Forms.CheckBox()
        Me.chkRemoveJCIIFilts = New System.Windows.Forms.CheckBox()
        Me.chkRemoveJCIIPreFilts = New System.Windows.Forms.CheckBox()
        Me.cmbFFType = New System.Windows.Forms.ComboBox()
        Me.cmbIFType = New System.Windows.Forms.ComboBox()
        Me.chkFFPrefilt = New System.Windows.Forms.CheckBox()
        Me.chkIFPrefilt = New System.Windows.Forms.CheckBox()
        Me.chkFFBank = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAirflow = New System.Windows.Forms.TextBox()
        Me.chkIFBank = New System.Windows.Forms.CheckBox()
        Me.btnDoneConditions = New System.Windows.Forms.Button()
        Me.tpgOptions = New System.Windows.Forms.TabPage()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.cmbExternalModuleStyle = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optExtMod3Party = New System.Windows.Forms.RadioButton()
        Me.optExtModDown = New System.Windows.Forms.RadioButton()
        Me.optExtModHoriz = New System.Windows.Forms.RadioButton()
        Me.optExtModNone = New System.Windows.Forms.RadioButton()
        Me.btnDoneOptions = New System.Windows.Forms.Button()
        Me.tpgControls = New System.Windows.Forms.TabPage()
        Me.grpCtrlFinal = New System.Windows.Forms.GroupBox()
        Me.cmbFFXdcrRange = New System.Windows.Forms.ComboBox()
        Me.chkFFXdcrWire = New System.Windows.Forms.CheckBox()
        Me.chkFFDFSWire = New System.Windows.Forms.CheckBox()
        Me.chkFFDFS = New System.Windows.Forms.CheckBox()
        Me.chkFFXducer = New System.Windows.Forms.CheckBox()
        Me.chkFFMinihelic = New System.Windows.Forms.CheckBox()
        Me.cmbFFMagRange = New System.Windows.Forms.ComboBox()
        Me.chkFFMagnehelic = New System.Windows.Forms.CheckBox()
        Me.grpCtrlFactory = New System.Windows.Forms.GroupBox()
        Me.cmbJCIFXdcrRange = New System.Windows.Forms.ComboBox()
        Me.chkJCIFXdcrWire = New System.Windows.Forms.CheckBox()
        Me.chkJCIFDFSWire = New System.Windows.Forms.CheckBox()
        Me.chkJCIFDFS = New System.Windows.Forms.CheckBox()
        Me.chkJCIFXducer = New System.Windows.Forms.CheckBox()
        Me.chkJCIFMinihelic = New System.Windows.Forms.CheckBox()
        Me.cmbJCIFMagRange = New System.Windows.Forms.ComboBox()
        Me.chkJCIFMagnehelic = New System.Windows.Forms.CheckBox()
        Me.grpCtrlInitital = New System.Windows.Forms.GroupBox()
        Me.cmbIFXdcrRange = New System.Windows.Forms.ComboBox()
        Me.chkIFMagnehelic = New System.Windows.Forms.CheckBox()
        Me.chkIFXdcrWire = New System.Windows.Forms.CheckBox()
        Me.cmbIFMagRange = New System.Windows.Forms.ComboBox()
        Me.chkIFDFSWire = New System.Windows.Forms.CheckBox()
        Me.chkIFMinihelic = New System.Windows.Forms.CheckBox()
        Me.chkIFDFS = New System.Windows.Forms.CheckBox()
        Me.chkIFXducer = New System.Windows.Forms.CheckBox()
        Me.chkMountEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEquipmentTouch = New System.Windows.Forms.CheckBox()
        Me.btnDoneControls = New System.Windows.Forms.Button()
        Me.tpgFilters = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstPreFFSelected = New System.Windows.Forms.ListBox()
        Me.lstPreIFSelected = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdSubIF = New System.Windows.Forms.Button()
        Me.cmdAddIF = New System.Windows.Forms.Button()
        Me.lstIFSelected = New System.Windows.Forms.ListBox()
        Me.lstIFAvail = New System.Windows.Forms.ListBox()
        Me.lstFFSelected = New System.Windows.Forms.ListBox()
        Me.cmbActIF = New System.Windows.Forms.ComboBox()
        Me.cmdSubFF = New System.Windows.Forms.Button()
        Me.cmbActFF = New System.Windows.Forms.ComboBox()
        Me.cmdAddFF = New System.Windows.Forms.Button()
        Me.btnDoneFilters = New System.Windows.Forms.Button()
        Me.lstFFAvail = New System.Windows.Forms.ListBox()
        Me.tpgPerformance = New System.Windows.Forms.TabPage()
        Me.grpInitialPerf = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPreIDFA = New System.Windows.Forms.TextBox()
        Me.lblPreIMaxAPD = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblPreIAPD = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblIFilterQ4 = New System.Windows.Forms.Label()
        Me.lblIFilterSize4 = New System.Windows.Forms.Label()
        Me.lblIStaticBudget = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIDFA = New System.Windows.Forms.TextBox()
        Me.lblIMaxAPD = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblIAPD = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIFaceVelocity = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblIFaceArea = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblIFilterQ3 = New System.Windows.Forms.Label()
        Me.lblIFilterQ2 = New System.Windows.Forms.Label()
        Me.lblIFilterQ1 = New System.Windows.Forms.Label()
        Me.lblIFilterSize3 = New System.Windows.Forms.Label()
        Me.lblIFilterSize2 = New System.Windows.Forms.Label()
        Me.lblIFilterSize1 = New System.Windows.Forms.Label()
        Me.grpFinalPerf = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPreFDFA = New System.Windows.Forms.TextBox()
        Me.lblPreFMaxAPD = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblPreFAPD = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblFilterQ4 = New System.Windows.Forms.Label()
        Me.lblFilterSize4 = New System.Windows.Forms.Label()
        Me.lblStaticBudget = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDFA = New System.Windows.Forms.TextBox()
        Me.lblMaxAPD = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAPD = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFaceVelocity = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFaceArea = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFilterQ3 = New System.Windows.Forms.Label()
        Me.lblFilterQ2 = New System.Windows.Forms.Label()
        Me.lblFilterQ1 = New System.Windows.Forms.Label()
        Me.lblFilterSize3 = New System.Windows.Forms.Label()
        Me.lblFilterSize2 = New System.Windows.Forms.Label()
        Me.lblFilterSize1 = New System.Windows.Forms.Label()
        Me.btnDonePerformance = New System.Windows.Forms.Button()
        Me.DebugPage = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.chkWriteHistory = New System.Windows.Forms.CheckBox()
        Me.chkAddMERV132inToSeries20 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstPreMFSelected = New System.Windows.Forms.ListBox()
        Me.lblMiscFilters = New System.Windows.Forms.Label()
        Me.lstMFSelected = New System.Windows.Forms.ListBox()
        Me.cmdSubMF = New System.Windows.Forms.Button()
        Me.cmbActMF = New System.Windows.Forms.ComboBox()
        Me.lstMFAvail = New System.Windows.Forms.ListBox()
        Me.cmdAddMF = New System.Windows.Forms.Button()
        Me.grpMiscPerf = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPreMDFA = New System.Windows.Forms.TextBox()
        Me.lblPreMMaxAPD = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblPreMAPD = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblMFilterQ4 = New System.Windows.Forms.Label()
        Me.lblMFilterSize4 = New System.Windows.Forms.Label()
        Me.lblMStaticBudget = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtmDFA = New System.Windows.Forms.TextBox()
        Me.lblMMaxAPD = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblMAPD = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblMFaceVelocity = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblMFaceArea = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblMFilterQ3 = New System.Windows.Forms.Label()
        Me.lblMFilterQ2 = New System.Windows.Forms.Label()
        Me.lblMFilterQ1 = New System.Windows.Forms.Label()
        Me.lblMFilterSize3 = New System.Windows.Forms.Label()
        Me.lblMFilterSize2 = New System.Windows.Forms.Label()
        Me.lblMFilterSize1 = New System.Windows.Forms.Label()
        Me.chkMFPrefilt = New System.Windows.Forms.CheckBox()
        Me.chkAddMERV132inToSeries10 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.tpgConditions.SuspendLayout()
        Me.grpFFRack.SuspendLayout()
        Me.grpIFRack.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpgControls.SuspendLayout()
        Me.grpCtrlFinal.SuspendLayout()
        Me.grpCtrlFactory.SuspendLayout()
        Me.grpCtrlInitital.SuspendLayout()
        Me.tpgFilters.SuspendLayout()
        Me.tpgPerformance.SuspendLayout()
        Me.grpInitialPerf.SuspendLayout()
        Me.grpFinalPerf.SuspendLayout()
        Me.grpMiscPerf.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgConditions)
        Me.TabControl1.Controls.Add(Me.tpgOptions)
        Me.TabControl1.Controls.Add(Me.tpgControls)
        Me.TabControl1.Controls.Add(Me.tpgFilters)
        Me.TabControl1.Controls.Add(Me.tpgPerformance)
        Me.TabControl1.Controls.Add(Me.DebugPage)
        Me.TabControl1.Location = New System.Drawing.Point(5, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(910, 513)
        Me.TabControl1.TabIndex = 5
        '
        'tpgConditions
        '
        Me.tpgConditions.Controls.Add(Me.chkAddMERV132inToSeries10)
        Me.tpgConditions.Controls.Add(Me.chkMFPrefilt)
        Me.tpgConditions.Controls.Add(Me.chkAddMERV132inToSeries20)
        Me.tpgConditions.Controls.Add(Me.grpFFRack)
        Me.tpgConditions.Controls.Add(Me.grpIFRack)
        Me.tpgConditions.Controls.Add(Me.chkIFPrefiltUseJCI)
        Me.tpgConditions.Controls.Add(Me.chkRelocateJCIIFinalPreFilts)
        Me.tpgConditions.Controls.Add(Me.chkRemoveJCIIFinalPreFilts)
        Me.tpgConditions.Controls.Add(Me.chkRelocateJCIFFilts)
        Me.tpgConditions.Controls.Add(Me.chkRelocateJCIIFilts)
        Me.tpgConditions.Controls.Add(Me.chkRelocateJCIIPreFilts)
        Me.tpgConditions.Controls.Add(Me.chkRemoveJCIFFilts)
        Me.tpgConditions.Controls.Add(Me.chkRemoveJCIIFilts)
        Me.tpgConditions.Controls.Add(Me.chkRemoveJCIIPreFilts)
        Me.tpgConditions.Controls.Add(Me.cmbFFType)
        Me.tpgConditions.Controls.Add(Me.cmbIFType)
        Me.tpgConditions.Controls.Add(Me.chkFFPrefilt)
        Me.tpgConditions.Controls.Add(Me.chkIFPrefilt)
        Me.tpgConditions.Controls.Add(Me.chkFFBank)
        Me.tpgConditions.Controls.Add(Me.Label1)
        Me.tpgConditions.Controls.Add(Me.txtAirflow)
        Me.tpgConditions.Controls.Add(Me.chkIFBank)
        Me.tpgConditions.Controls.Add(Me.btnDoneConditions)
        Me.tpgConditions.Location = New System.Drawing.Point(4, 22)
        Me.tpgConditions.Name = "tpgConditions"
        Me.tpgConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgConditions.Size = New System.Drawing.Size(902, 487)
        Me.tpgConditions.TabIndex = 0
        Me.tpgConditions.Text = "Conditions"
        Me.tpgConditions.UseVisualStyleBackColor = True
        '
        'grpFFRack
        '
        Me.grpFFRack.Controls.Add(Me.optFFRackNA)
        Me.grpFFRack.Controls.Add(Me.optFFRackHEPASS)
        Me.grpFFRack.Controls.Add(Me.optFFRackHEPAGalv)
        Me.grpFFRack.Controls.Add(Me.optFFRackSS)
        Me.grpFFRack.Controls.Add(Me.optFFRackGalv)
        Me.grpFFRack.Enabled = False
        Me.grpFFRack.Location = New System.Drawing.Point(454, 268)
        Me.grpFFRack.Name = "grpFFRack"
        Me.grpFFRack.Size = New System.Drawing.Size(431, 67)
        Me.grpFFRack.TabIndex = 44
        Me.grpFFRack.TabStop = False
        Me.grpFFRack.Text = "Filter Rack Construction"
        '
        'optFFRackNA
        '
        Me.optFFRackNA.AutoSize = True
        Me.optFFRackNA.Checked = True
        Me.optFFRackNA.Location = New System.Drawing.Point(277, 19)
        Me.optFFRackNA.Name = "optFFRackNA"
        Me.optFFRackNA.Size = New System.Drawing.Size(42, 17)
        Me.optFFRackNA.TabIndex = 49
        Me.optFFRackNA.TabStop = True
        Me.optFFRackNA.Text = "n/a"
        Me.optFFRackNA.UseVisualStyleBackColor = True
        '
        'optFFRackHEPASS
        '
        Me.optFFRackHEPASS.AutoSize = True
        Me.optFFRackHEPASS.Location = New System.Drawing.Point(106, 42)
        Me.optFFRackHEPASS.Name = "optFFRackHEPASS"
        Me.optFFRackHEPASS.Size = New System.Drawing.Size(153, 17)
        Me.optFFRackHEPASS.TabIndex = 47
        Me.optFFRackHEPASS.Text = "Stainless Face Load HEPA"
        Me.optFFRackHEPASS.UseVisualStyleBackColor = True
        '
        'optFFRackHEPAGalv
        '
        Me.optFFRackHEPAGalv.AutoSize = True
        Me.optFFRackHEPAGalv.Location = New System.Drawing.Point(106, 19)
        Me.optFFRackHEPAGalv.Name = "optFFRackHEPAGalv"
        Me.optFFRackHEPAGalv.Size = New System.Drawing.Size(164, 17)
        Me.optFFRackHEPAGalv.TabIndex = 46
        Me.optFFRackHEPAGalv.Text = "Galvanized Face Load HEPA"
        Me.optFFRackHEPAGalv.UseVisualStyleBackColor = True
        '
        'optFFRackSS
        '
        Me.optFFRackSS.AutoSize = True
        Me.optFFRackSS.Location = New System.Drawing.Point(6, 42)
        Me.optFFRackSS.Name = "optFFRackSS"
        Me.optFFRackSS.Size = New System.Drawing.Size(94, 17)
        Me.optFFRackSS.TabIndex = 45
        Me.optFFRackSS.Text = "Stainless Steel"
        Me.optFFRackSS.UseVisualStyleBackColor = True
        '
        'optFFRackGalv
        '
        Me.optFFRackGalv.AutoSize = True
        Me.optFFRackGalv.Location = New System.Drawing.Point(6, 19)
        Me.optFFRackGalv.Name = "optFFRackGalv"
        Me.optFFRackGalv.Size = New System.Drawing.Size(78, 17)
        Me.optFFRackGalv.TabIndex = 44
        Me.optFFRackGalv.Text = "Galvanized"
        Me.optFFRackGalv.UseVisualStyleBackColor = True
        '
        'grpIFRack
        '
        Me.grpIFRack.Controls.Add(Me.optIFRackNA)
        Me.grpIFRack.Controls.Add(Me.optIFRackHEPASS)
        Me.grpIFRack.Controls.Add(Me.optIFRackHEPAGalv)
        Me.grpIFRack.Controls.Add(Me.optIFRackSS)
        Me.grpIFRack.Controls.Add(Me.optIFRackGalv)
        Me.grpIFRack.Enabled = False
        Me.grpIFRack.Location = New System.Drawing.Point(21, 268)
        Me.grpIFRack.Name = "grpIFRack"
        Me.grpIFRack.Size = New System.Drawing.Size(395, 67)
        Me.grpIFRack.TabIndex = 43
        Me.grpIFRack.TabStop = False
        Me.grpIFRack.Text = "Filter Rack Construction"
        '
        'optIFRackNA
        '
        Me.optIFRackNA.AutoSize = True
        Me.optIFRackNA.Checked = True
        Me.optIFRackNA.Location = New System.Drawing.Point(276, 19)
        Me.optIFRackNA.Name = "optIFRackNA"
        Me.optIFRackNA.Size = New System.Drawing.Size(42, 17)
        Me.optIFRackNA.TabIndex = 48
        Me.optIFRackNA.TabStop = True
        Me.optIFRackNA.Text = "n/a"
        Me.optIFRackNA.UseVisualStyleBackColor = True
        '
        'optIFRackHEPASS
        '
        Me.optIFRackHEPASS.AutoSize = True
        Me.optIFRackHEPASS.Location = New System.Drawing.Point(106, 42)
        Me.optIFRackHEPASS.Name = "optIFRackHEPASS"
        Me.optIFRackHEPASS.Size = New System.Drawing.Size(153, 17)
        Me.optIFRackHEPASS.TabIndex = 47
        Me.optIFRackHEPASS.Text = "Stainless Face Load HEPA"
        Me.optIFRackHEPASS.UseVisualStyleBackColor = True
        '
        'optIFRackHEPAGalv
        '
        Me.optIFRackHEPAGalv.AutoSize = True
        Me.optIFRackHEPAGalv.Location = New System.Drawing.Point(106, 19)
        Me.optIFRackHEPAGalv.Name = "optIFRackHEPAGalv"
        Me.optIFRackHEPAGalv.Size = New System.Drawing.Size(164, 17)
        Me.optIFRackHEPAGalv.TabIndex = 46
        Me.optIFRackHEPAGalv.Text = "Galvanized Face Load HEPA"
        Me.optIFRackHEPAGalv.UseVisualStyleBackColor = True
        '
        'optIFRackSS
        '
        Me.optIFRackSS.AutoSize = True
        Me.optIFRackSS.Location = New System.Drawing.Point(6, 42)
        Me.optIFRackSS.Name = "optIFRackSS"
        Me.optIFRackSS.Size = New System.Drawing.Size(94, 17)
        Me.optIFRackSS.TabIndex = 45
        Me.optIFRackSS.Text = "Stainless Steel"
        Me.optIFRackSS.UseVisualStyleBackColor = True
        '
        'optIFRackGalv
        '
        Me.optIFRackGalv.AutoSize = True
        Me.optIFRackGalv.Location = New System.Drawing.Point(6, 19)
        Me.optIFRackGalv.Name = "optIFRackGalv"
        Me.optIFRackGalv.Size = New System.Drawing.Size(78, 17)
        Me.optIFRackGalv.TabIndex = 44
        Me.optIFRackGalv.Text = "Galvanized"
        Me.optIFRackGalv.UseVisualStyleBackColor = True
        '
        'chkIFPrefiltUseJCI
        '
        Me.chkIFPrefiltUseJCI.AutoSize = True
        Me.chkIFPrefiltUseJCI.Enabled = False
        Me.chkIFPrefiltUseJCI.Location = New System.Drawing.Point(20, 246)
        Me.chkIFPrefiltUseJCI.Name = "chkIFPrefiltUseJCI"
        Me.chkIFPrefiltUseJCI.Size = New System.Drawing.Size(203, 17)
        Me.chkIFPrefiltUseJCI.TabIndex = 42
        Me.chkIFPrefiltUseJCI.Text = "Use Factory Initial Filters as Pre-Filters"
        Me.chkIFPrefiltUseJCI.UseVisualStyleBackColor = True
        '
        'chkRelocateJCIIFinalPreFilts
        '
        Me.chkRelocateJCIIFinalPreFilts.AutoSize = True
        Me.chkRelocateJCIIFinalPreFilts.Location = New System.Drawing.Point(460, 435)
        Me.chkRelocateJCIIFinalPreFilts.Name = "chkRelocateJCIIFinalPreFilts"
        Me.chkRelocateJCIIFinalPreFilts.Size = New System.Drawing.Size(204, 17)
        Me.chkRelocateJCIIFinalPreFilts.TabIndex = 41
        Me.chkRelocateJCIIFinalPreFilts.Text = "Relocate Factory Final Pre-Filter Bank"
        Me.chkRelocateJCIIFinalPreFilts.UseVisualStyleBackColor = True
        '
        'chkRemoveJCIIFinalPreFilts
        '
        Me.chkRemoveJCIIFinalPreFilts.AutoSize = True
        Me.chkRemoveJCIIFinalPreFilts.Location = New System.Drawing.Point(460, 412)
        Me.chkRemoveJCIIFinalPreFilts.Name = "chkRemoveJCIIFinalPreFilts"
        Me.chkRemoveJCIIFinalPreFilts.Size = New System.Drawing.Size(201, 17)
        Me.chkRemoveJCIIFinalPreFilts.TabIndex = 40
        Me.chkRemoveJCIIFinalPreFilts.Text = "Remove Factory Final Pre-Filter Bank"
        Me.chkRemoveJCIIFinalPreFilts.UseVisualStyleBackColor = True
        '
        'chkRelocateJCIFFilts
        '
        Me.chkRelocateJCIFFilts.AutoSize = True
        Me.chkRelocateJCIFFilts.Location = New System.Drawing.Point(703, 435)
        Me.chkRelocateJCIFFilts.Name = "chkRelocateJCIFFilts"
        Me.chkRelocateJCIFFilts.Size = New System.Drawing.Size(185, 17)
        Me.chkRelocateJCIFFilts.TabIndex = 39
        Me.chkRelocateJCIFFilts.Text = "Relocate Factory Final Filter Bank"
        Me.chkRelocateJCIFFilts.UseVisualStyleBackColor = True
        '
        'chkRelocateJCIIFilts
        '
        Me.chkRelocateJCIIFilts.AutoSize = True
        Me.chkRelocateJCIIFilts.Location = New System.Drawing.Point(703, 373)
        Me.chkRelocateJCIIFilts.Name = "chkRelocateJCIIFilts"
        Me.chkRelocateJCIIFilts.Size = New System.Drawing.Size(187, 17)
        Me.chkRelocateJCIIFilts.TabIndex = 38
        Me.chkRelocateJCIIFilts.Text = "Relocate Factory Initial Filter Bank"
        Me.chkRelocateJCIIFilts.UseVisualStyleBackColor = True
        '
        'chkRelocateJCIIPreFilts
        '
        Me.chkRelocateJCIIPreFilts.AutoSize = True
        Me.chkRelocateJCIIPreFilts.Location = New System.Drawing.Point(460, 373)
        Me.chkRelocateJCIIPreFilts.Name = "chkRelocateJCIIPreFilts"
        Me.chkRelocateJCIIPreFilts.Size = New System.Drawing.Size(206, 17)
        Me.chkRelocateJCIIPreFilts.TabIndex = 37
        Me.chkRelocateJCIIPreFilts.Text = "Relocate Factory Initial Pre-Filter Bank"
        Me.chkRelocateJCIIPreFilts.UseVisualStyleBackColor = True
        '
        'chkRemoveJCIFFilts
        '
        Me.chkRemoveJCIFFilts.AutoSize = True
        Me.chkRemoveJCIFFilts.Location = New System.Drawing.Point(703, 412)
        Me.chkRemoveJCIFFilts.Name = "chkRemoveJCIFFilts"
        Me.chkRemoveJCIFFilts.Size = New System.Drawing.Size(182, 17)
        Me.chkRemoveJCIFFilts.TabIndex = 36
        Me.chkRemoveJCIFFilts.Text = "Remove Factory Final Filter Bank"
        Me.chkRemoveJCIFFilts.UseVisualStyleBackColor = True
        '
        'chkRemoveJCIIFilts
        '
        Me.chkRemoveJCIIFilts.AutoSize = True
        Me.chkRemoveJCIIFilts.Location = New System.Drawing.Point(703, 350)
        Me.chkRemoveJCIIFilts.Name = "chkRemoveJCIIFilts"
        Me.chkRemoveJCIIFilts.Size = New System.Drawing.Size(184, 17)
        Me.chkRemoveJCIIFilts.TabIndex = 35
        Me.chkRemoveJCIIFilts.Text = "Remove Factory Initial Filter Bank"
        Me.chkRemoveJCIIFilts.UseVisualStyleBackColor = True
        '
        'chkRemoveJCIIPreFilts
        '
        Me.chkRemoveJCIIPreFilts.AutoSize = True
        Me.chkRemoveJCIIPreFilts.Location = New System.Drawing.Point(460, 350)
        Me.chkRemoveJCIIPreFilts.Name = "chkRemoveJCIIPreFilts"
        Me.chkRemoveJCIIPreFilts.Size = New System.Drawing.Size(203, 17)
        Me.chkRemoveJCIIPreFilts.TabIndex = 34
        Me.chkRemoveJCIIPreFilts.Text = "Remove Factory Initial Pre-Filter Bank"
        Me.chkRemoveJCIIPreFilts.UseVisualStyleBackColor = True
        '
        'cmbFFType
        '
        Me.cmbFFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFFType.Enabled = False
        Me.cmbFFType.FormattingEnabled = True
        Me.cmbFFType.Items.AddRange(New Object() {"MERV 8 (2in)", "MERV 8 (4in)", "MERV 13 (2in)", "MERV 14 (4in)", "MERV 14 (6in)", "MERV 14 (12in)", "N/A"})
        Me.cmbFFType.Location = New System.Drawing.Point(614, 198)
        Me.cmbFFType.Name = "cmbFFType"
        Me.cmbFFType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFFType.TabIndex = 33
        '
        'cmbIFType
        '
        Me.cmbIFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIFType.Enabled = False
        Me.cmbIFType.FormattingEnabled = True
        Me.cmbIFType.Items.AddRange(New Object() {"MERV 8 (2in)", "MERV 8 (4in)", "MERV 13 (2in)", "MERV 14 (4in)", "MERV 14 (6in)", "MERV 14 (12in)", "N/A"})
        Me.cmbIFType.Location = New System.Drawing.Point(179, 198)
        Me.cmbIFType.Name = "cmbIFType"
        Me.cmbIFType.Size = New System.Drawing.Size(121, 21)
        Me.cmbIFType.TabIndex = 32
        '
        'chkFFPrefilt
        '
        Me.chkFFPrefilt.AutoSize = True
        Me.chkFFPrefilt.Enabled = False
        Me.chkFFPrefilt.Location = New System.Drawing.Point(455, 223)
        Me.chkFFPrefilt.Name = "chkFFPrefilt"
        Me.chkFFPrefilt.Size = New System.Drawing.Size(213, 17)
        Me.chkFFPrefilt.TabIndex = 30
        Me.chkFFPrefilt.Text = "Final Filter Bank Pre-Filters (2"" MERV 8)"
        Me.chkFFPrefilt.UseVisualStyleBackColor = True
        '
        'chkIFPrefilt
        '
        Me.chkIFPrefilt.AutoSize = True
        Me.chkIFPrefilt.Enabled = False
        Me.chkIFPrefilt.Location = New System.Drawing.Point(20, 223)
        Me.chkIFPrefilt.Name = "chkIFPrefilt"
        Me.chkIFPrefilt.Size = New System.Drawing.Size(215, 17)
        Me.chkIFPrefilt.TabIndex = 29
        Me.chkIFPrefilt.Text = "Initial Filter Bank Pre-Filters (2"" MERV 8)"
        Me.chkIFPrefilt.UseVisualStyleBackColor = True
        '
        'chkFFBank
        '
        Me.chkFFBank.AutoSize = True
        Me.chkFFBank.Location = New System.Drawing.Point(440, 200)
        Me.chkFFBank.Name = "chkFFBank"
        Me.chkFFBank.Size = New System.Drawing.Size(101, 17)
        Me.chkFFBank.TabIndex = 25
        Me.chkFFBank.Text = "Final Filter Bank"
        Me.chkFFBank.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Airflow"
        '
        'txtAirflow
        '
        Me.txtAirflow.Location = New System.Drawing.Point(6, 6)
        Me.txtAirflow.Name = "txtAirflow"
        Me.txtAirflow.Size = New System.Drawing.Size(56, 20)
        Me.txtAirflow.TabIndex = 27
        '
        'chkIFBank
        '
        Me.chkIFBank.AutoSize = True
        Me.chkIFBank.Location = New System.Drawing.Point(6, 200)
        Me.chkIFBank.Name = "chkIFBank"
        Me.chkIFBank.Size = New System.Drawing.Size(103, 17)
        Me.chkIFBank.TabIndex = 23
        Me.chkIFBank.Text = "Initial Filter Bank"
        Me.chkIFBank.UseVisualStyleBackColor = True
        '
        'btnDoneConditions
        '
        Me.btnDoneConditions.Location = New System.Drawing.Point(847, 458)
        Me.btnDoneConditions.Name = "btnDoneConditions"
        Me.btnDoneConditions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneConditions.TabIndex = 22
        Me.btnDoneConditions.Text = ">"
        Me.btnDoneConditions.UseVisualStyleBackColor = True
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chk65kASCCRBase)
        Me.tpgOptions.Controls.Add(Me.cmbExternalModuleStyle)
        Me.tpgOptions.Controls.Add(Me.GroupBox2)
        Me.tpgOptions.Controls.Add(Me.btnDoneOptions)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOptions.Size = New System.Drawing.Size(902, 487)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(7, 391)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 31
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'cmbExternalModuleStyle
        '
        Me.cmbExternalModuleStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExternalModuleStyle.FormattingEnabled = True
        Me.cmbExternalModuleStyle.Items.AddRange(New Object() {"No Module Required"})
        Me.cmbExternalModuleStyle.Location = New System.Drawing.Point(6, 131)
        Me.cmbExternalModuleStyle.Name = "cmbExternalModuleStyle"
        Me.cmbExternalModuleStyle.Size = New System.Drawing.Size(200, 21)
        Me.cmbExternalModuleStyle.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optExtMod3Party)
        Me.GroupBox2.Controls.Add(Me.optExtModDown)
        Me.GroupBox2.Controls.Add(Me.optExtModHoriz)
        Me.GroupBox2.Controls.Add(Me.optExtModNone)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 119)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "External Module"
        '
        'optExtMod3Party
        '
        Me.optExtMod3Party.AutoSize = True
        Me.optExtMod3Party.Location = New System.Drawing.Point(6, 88)
        Me.optExtMod3Party.Name = "optExtMod3Party"
        Me.optExtMod3Party.Size = New System.Drawing.Size(130, 17)
        Me.optExtMod3Party.TabIndex = 3
        Me.optExtMod3Party.Text = "3rd Party Filter Module"
        Me.optExtMod3Party.UseVisualStyleBackColor = True
        '
        'optExtModDown
        '
        Me.optExtModDown.AutoSize = True
        Me.optExtModDown.Location = New System.Drawing.Point(6, 65)
        Me.optExtModDown.Name = "optExtModDown"
        Me.optExtModDown.Size = New System.Drawing.Size(135, 17)
        Me.optExtModDown.TabIndex = 2
        Me.optExtModDown.Text = "Downflow Filter Module"
        Me.optExtModDown.UseVisualStyleBackColor = True
        '
        'optExtModHoriz
        '
        Me.optExtModHoriz.AutoSize = True
        Me.optExtModHoriz.Location = New System.Drawing.Point(6, 42)
        Me.optExtModHoriz.Name = "optExtModHoriz"
        Me.optExtModHoriz.Size = New System.Drawing.Size(186, 17)
        Me.optExtModHoriz.TabIndex = 1
        Me.optExtModHoriz.Text = "Horizontal Discharge Filter Module"
        Me.optExtModHoriz.UseVisualStyleBackColor = True
        '
        'optExtModNone
        '
        Me.optExtModNone.AutoSize = True
        Me.optExtModNone.Checked = True
        Me.optExtModNone.Location = New System.Drawing.Point(6, 19)
        Me.optExtModNone.Name = "optExtModNone"
        Me.optExtModNone.Size = New System.Drawing.Size(51, 17)
        Me.optExtModNone.TabIndex = 0
        Me.optExtModNone.TabStop = True
        Me.optExtModNone.Text = "None"
        Me.optExtModNone.UseVisualStyleBackColor = True
        '
        'btnDoneOptions
        '
        Me.btnDoneOptions.Location = New System.Drawing.Point(847, 458)
        Me.btnDoneOptions.Name = "btnDoneOptions"
        Me.btnDoneOptions.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneOptions.TabIndex = 23
        Me.btnDoneOptions.Text = ">"
        Me.btnDoneOptions.UseVisualStyleBackColor = True
        '
        'tpgControls
        '
        Me.tpgControls.Controls.Add(Me.grpCtrlFinal)
        Me.tpgControls.Controls.Add(Me.grpCtrlFactory)
        Me.tpgControls.Controls.Add(Me.grpCtrlInitital)
        Me.tpgControls.Controls.Add(Me.chkMountEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.chkIncludeEquipmentTouch)
        Me.tpgControls.Controls.Add(Me.btnDoneControls)
        Me.tpgControls.Location = New System.Drawing.Point(4, 22)
        Me.tpgControls.Name = "tpgControls"
        Me.tpgControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgControls.Size = New System.Drawing.Size(902, 487)
        Me.tpgControls.TabIndex = 4
        Me.tpgControls.Text = "Controls"
        Me.tpgControls.UseVisualStyleBackColor = True
        '
        'grpCtrlFinal
        '
        Me.grpCtrlFinal.Controls.Add(Me.cmbFFXdcrRange)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFXdcrWire)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFDFSWire)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFDFS)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFXducer)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFMinihelic)
        Me.grpCtrlFinal.Controls.Add(Me.cmbFFMagRange)
        Me.grpCtrlFinal.Controls.Add(Me.chkFFMagnehelic)
        Me.grpCtrlFinal.Enabled = False
        Me.grpCtrlFinal.Location = New System.Drawing.Point(419, 16)
        Me.grpCtrlFinal.Name = "grpCtrlFinal"
        Me.grpCtrlFinal.Size = New System.Drawing.Size(200, 191)
        Me.grpCtrlFinal.TabIndex = 34
        Me.grpCtrlFinal.TabStop = False
        Me.grpCtrlFinal.Text = "Final Filters"
        '
        'cmbFFXdcrRange
        '
        Me.cmbFFXdcrRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFFXdcrRange.Enabled = False
        Me.cmbFFXdcrRange.FormattingEnabled = True
        Me.cmbFFXdcrRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbFFXdcrRange.Location = New System.Drawing.Point(27, 89)
        Me.cmbFFXdcrRange.Name = "cmbFFXdcrRange"
        Me.cmbFFXdcrRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbFFXdcrRange.TabIndex = 38
        '
        'chkFFXdcrWire
        '
        Me.chkFFXdcrWire.AutoSize = True
        Me.chkFFXdcrWire.Enabled = False
        Me.chkFFXdcrWire.Location = New System.Drawing.Point(27, 116)
        Me.chkFFXdcrWire.Name = "chkFFXdcrWire"
        Me.chkFFXdcrWire.Size = New System.Drawing.Size(135, 17)
        Me.chkFFXdcrWire.TabIndex = 37
        Me.chkFFXdcrWire.Text = "Wire to Fisen Controller"
        Me.chkFFXdcrWire.UseVisualStyleBackColor = True
        '
        'chkFFDFSWire
        '
        Me.chkFFDFSWire.AutoSize = True
        Me.chkFFDFSWire.Enabled = False
        Me.chkFFDFSWire.Location = New System.Drawing.Point(27, 162)
        Me.chkFFDFSWire.Name = "chkFFDFSWire"
        Me.chkFFDFSWire.Size = New System.Drawing.Size(135, 17)
        Me.chkFFDFSWire.TabIndex = 36
        Me.chkFFDFSWire.Text = "Wire to Fisen Controller"
        Me.chkFFDFSWire.UseVisualStyleBackColor = True
        '
        'chkFFDFS
        '
        Me.chkFFDFS.AutoSize = True
        Me.chkFFDFS.Location = New System.Drawing.Point(6, 139)
        Me.chkFFDFS.Name = "chkFFDFS"
        Me.chkFFDFS.Size = New System.Drawing.Size(107, 17)
        Me.chkFFDFS.TabIndex = 35
        Me.chkFFDFS.Text = "Dirty Filter Switch"
        Me.chkFFDFS.UseVisualStyleBackColor = True
        '
        'chkFFXducer
        '
        Me.chkFFXducer.AutoSize = True
        Me.chkFFXducer.Location = New System.Drawing.Point(6, 66)
        Me.chkFFXducer.Name = "chkFFXducer"
        Me.chkFFXducer.Size = New System.Drawing.Size(98, 17)
        Me.chkFFXducer.TabIndex = 34
        Me.chkFFXducer.Text = "DP Transducer"
        Me.chkFFXducer.UseVisualStyleBackColor = True
        '
        'chkFFMinihelic
        '
        Me.chkFFMinihelic.AutoSize = True
        Me.chkFFMinihelic.Enabled = False
        Me.chkFFMinihelic.Location = New System.Drawing.Point(114, 41)
        Me.chkFFMinihelic.Name = "chkFFMinihelic"
        Me.chkFFMinihelic.Size = New System.Drawing.Size(67, 17)
        Me.chkFFMinihelic.TabIndex = 33
        Me.chkFFMinihelic.Text = "Minihelic"
        Me.chkFFMinihelic.UseVisualStyleBackColor = True
        '
        'cmbFFMagRange
        '
        Me.cmbFFMagRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFFMagRange.Enabled = False
        Me.cmbFFMagRange.FormattingEnabled = True
        Me.cmbFFMagRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbFFMagRange.Location = New System.Drawing.Point(27, 39)
        Me.cmbFFMagRange.Name = "cmbFFMagRange"
        Me.cmbFFMagRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbFFMagRange.TabIndex = 32
        '
        'chkFFMagnehelic
        '
        Me.chkFFMagnehelic.AutoSize = True
        Me.chkFFMagnehelic.Location = New System.Drawing.Point(6, 19)
        Me.chkFFMagnehelic.Name = "chkFFMagnehelic"
        Me.chkFFMagnehelic.Size = New System.Drawing.Size(116, 17)
        Me.chkFFMagnehelic.TabIndex = 31
        Me.chkFFMagnehelic.Text = "Magnehelic Gauge"
        Me.chkFFMagnehelic.UseVisualStyleBackColor = True
        '
        'grpCtrlFactory
        '
        Me.grpCtrlFactory.Controls.Add(Me.cmbJCIFXdcrRange)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFXdcrWire)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFDFSWire)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFDFS)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFXducer)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFMinihelic)
        Me.grpCtrlFactory.Controls.Add(Me.cmbJCIFMagRange)
        Me.grpCtrlFactory.Controls.Add(Me.chkJCIFMagnehelic)
        Me.grpCtrlFactory.Enabled = False
        Me.grpCtrlFactory.Location = New System.Drawing.Point(213, 16)
        Me.grpCtrlFactory.Name = "grpCtrlFactory"
        Me.grpCtrlFactory.Size = New System.Drawing.Size(200, 191)
        Me.grpCtrlFactory.TabIndex = 33
        Me.grpCtrlFactory.TabStop = False
        Me.grpCtrlFactory.Text = "Factory Filters"
        '
        'cmbJCIFXdcrRange
        '
        Me.cmbJCIFXdcrRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJCIFXdcrRange.Enabled = False
        Me.cmbJCIFXdcrRange.FormattingEnabled = True
        Me.cmbJCIFXdcrRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbJCIFXdcrRange.Location = New System.Drawing.Point(27, 89)
        Me.cmbJCIFXdcrRange.Name = "cmbJCIFXdcrRange"
        Me.cmbJCIFXdcrRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbJCIFXdcrRange.TabIndex = 46
        '
        'chkJCIFXdcrWire
        '
        Me.chkJCIFXdcrWire.AutoSize = True
        Me.chkJCIFXdcrWire.Enabled = False
        Me.chkJCIFXdcrWire.Location = New System.Drawing.Point(27, 116)
        Me.chkJCIFXdcrWire.Name = "chkJCIFXdcrWire"
        Me.chkJCIFXdcrWire.Size = New System.Drawing.Size(135, 17)
        Me.chkJCIFXdcrWire.TabIndex = 45
        Me.chkJCIFXdcrWire.Text = "Wire to Fisen Controller"
        Me.chkJCIFXdcrWire.UseVisualStyleBackColor = True
        '
        'chkJCIFDFSWire
        '
        Me.chkJCIFDFSWire.AutoSize = True
        Me.chkJCIFDFSWire.Enabled = False
        Me.chkJCIFDFSWire.Location = New System.Drawing.Point(27, 162)
        Me.chkJCIFDFSWire.Name = "chkJCIFDFSWire"
        Me.chkJCIFDFSWire.Size = New System.Drawing.Size(135, 17)
        Me.chkJCIFDFSWire.TabIndex = 44
        Me.chkJCIFDFSWire.Text = "Wire to Fisen Controller"
        Me.chkJCIFDFSWire.UseVisualStyleBackColor = True
        '
        'chkJCIFDFS
        '
        Me.chkJCIFDFS.AutoSize = True
        Me.chkJCIFDFS.Location = New System.Drawing.Point(6, 139)
        Me.chkJCIFDFS.Name = "chkJCIFDFS"
        Me.chkJCIFDFS.Size = New System.Drawing.Size(107, 17)
        Me.chkJCIFDFS.TabIndex = 43
        Me.chkJCIFDFS.Text = "Dirty Filter Switch"
        Me.chkJCIFDFS.UseVisualStyleBackColor = True
        '
        'chkJCIFXducer
        '
        Me.chkJCIFXducer.AutoSize = True
        Me.chkJCIFXducer.Location = New System.Drawing.Point(6, 66)
        Me.chkJCIFXducer.Name = "chkJCIFXducer"
        Me.chkJCIFXducer.Size = New System.Drawing.Size(98, 17)
        Me.chkJCIFXducer.TabIndex = 42
        Me.chkJCIFXducer.Text = "DP Transducer"
        Me.chkJCIFXducer.UseVisualStyleBackColor = True
        '
        'chkJCIFMinihelic
        '
        Me.chkJCIFMinihelic.AutoSize = True
        Me.chkJCIFMinihelic.Enabled = False
        Me.chkJCIFMinihelic.Location = New System.Drawing.Point(114, 41)
        Me.chkJCIFMinihelic.Name = "chkJCIFMinihelic"
        Me.chkJCIFMinihelic.Size = New System.Drawing.Size(67, 17)
        Me.chkJCIFMinihelic.TabIndex = 41
        Me.chkJCIFMinihelic.Text = "Minihelic"
        Me.chkJCIFMinihelic.UseVisualStyleBackColor = True
        '
        'cmbJCIFMagRange
        '
        Me.cmbJCIFMagRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJCIFMagRange.Enabled = False
        Me.cmbJCIFMagRange.FormattingEnabled = True
        Me.cmbJCIFMagRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbJCIFMagRange.Location = New System.Drawing.Point(27, 39)
        Me.cmbJCIFMagRange.Name = "cmbJCIFMagRange"
        Me.cmbJCIFMagRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbJCIFMagRange.TabIndex = 40
        '
        'chkJCIFMagnehelic
        '
        Me.chkJCIFMagnehelic.AutoSize = True
        Me.chkJCIFMagnehelic.Location = New System.Drawing.Point(6, 19)
        Me.chkJCIFMagnehelic.Name = "chkJCIFMagnehelic"
        Me.chkJCIFMagnehelic.Size = New System.Drawing.Size(116, 17)
        Me.chkJCIFMagnehelic.TabIndex = 39
        Me.chkJCIFMagnehelic.Text = "Magnehelic Gauge"
        Me.chkJCIFMagnehelic.UseVisualStyleBackColor = True
        '
        'grpCtrlInitital
        '
        Me.grpCtrlInitital.Controls.Add(Me.cmbIFXdcrRange)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFMagnehelic)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFXdcrWire)
        Me.grpCtrlInitital.Controls.Add(Me.cmbIFMagRange)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFDFSWire)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFMinihelic)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFDFS)
        Me.grpCtrlInitital.Controls.Add(Me.chkIFXducer)
        Me.grpCtrlInitital.Enabled = False
        Me.grpCtrlInitital.Location = New System.Drawing.Point(7, 16)
        Me.grpCtrlInitital.Name = "grpCtrlInitital"
        Me.grpCtrlInitital.Size = New System.Drawing.Size(200, 191)
        Me.grpCtrlInitital.TabIndex = 32
        Me.grpCtrlInitital.TabStop = False
        Me.grpCtrlInitital.Text = "Initial Filters"
        '
        'cmbIFXdcrRange
        '
        Me.cmbIFXdcrRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIFXdcrRange.Enabled = False
        Me.cmbIFXdcrRange.FormattingEnabled = True
        Me.cmbIFXdcrRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbIFXdcrRange.Location = New System.Drawing.Point(27, 89)
        Me.cmbIFXdcrRange.Name = "cmbIFXdcrRange"
        Me.cmbIFXdcrRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbIFXdcrRange.TabIndex = 54
        '
        'chkIFMagnehelic
        '
        Me.chkIFMagnehelic.AutoSize = True
        Me.chkIFMagnehelic.Location = New System.Drawing.Point(6, 19)
        Me.chkIFMagnehelic.Name = "chkIFMagnehelic"
        Me.chkIFMagnehelic.Size = New System.Drawing.Size(116, 17)
        Me.chkIFMagnehelic.TabIndex = 47
        Me.chkIFMagnehelic.Text = "Magnehelic Gauge"
        Me.chkIFMagnehelic.UseVisualStyleBackColor = True
        '
        'chkIFXdcrWire
        '
        Me.chkIFXdcrWire.AutoSize = True
        Me.chkIFXdcrWire.Enabled = False
        Me.chkIFXdcrWire.Location = New System.Drawing.Point(27, 116)
        Me.chkIFXdcrWire.Name = "chkIFXdcrWire"
        Me.chkIFXdcrWire.Size = New System.Drawing.Size(135, 17)
        Me.chkIFXdcrWire.TabIndex = 53
        Me.chkIFXdcrWire.Text = "Wire to Fisen Controller"
        Me.chkIFXdcrWire.UseVisualStyleBackColor = True
        '
        'cmbIFMagRange
        '
        Me.cmbIFMagRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIFMagRange.Enabled = False
        Me.cmbIFMagRange.FormattingEnabled = True
        Me.cmbIFMagRange.Items.AddRange(New Object() {"0.00-0.50", "0.00-1.00", "0.00-2.00", "0.00-3.00", "0.00-5.00", "Unselected", "n/a"})
        Me.cmbIFMagRange.Location = New System.Drawing.Point(27, 39)
        Me.cmbIFMagRange.Name = "cmbIFMagRange"
        Me.cmbIFMagRange.Size = New System.Drawing.Size(81, 21)
        Me.cmbIFMagRange.TabIndex = 48
        '
        'chkIFDFSWire
        '
        Me.chkIFDFSWire.AutoSize = True
        Me.chkIFDFSWire.Enabled = False
        Me.chkIFDFSWire.Location = New System.Drawing.Point(27, 162)
        Me.chkIFDFSWire.Name = "chkIFDFSWire"
        Me.chkIFDFSWire.Size = New System.Drawing.Size(135, 17)
        Me.chkIFDFSWire.TabIndex = 52
        Me.chkIFDFSWire.Text = "Wire to Fisen Controller"
        Me.chkIFDFSWire.UseVisualStyleBackColor = True
        '
        'chkIFMinihelic
        '
        Me.chkIFMinihelic.AutoSize = True
        Me.chkIFMinihelic.Enabled = False
        Me.chkIFMinihelic.Location = New System.Drawing.Point(114, 41)
        Me.chkIFMinihelic.Name = "chkIFMinihelic"
        Me.chkIFMinihelic.Size = New System.Drawing.Size(67, 17)
        Me.chkIFMinihelic.TabIndex = 49
        Me.chkIFMinihelic.Text = "Minihelic"
        Me.chkIFMinihelic.UseVisualStyleBackColor = True
        '
        'chkIFDFS
        '
        Me.chkIFDFS.AutoSize = True
        Me.chkIFDFS.Location = New System.Drawing.Point(6, 139)
        Me.chkIFDFS.Name = "chkIFDFS"
        Me.chkIFDFS.Size = New System.Drawing.Size(107, 17)
        Me.chkIFDFS.TabIndex = 51
        Me.chkIFDFS.Text = "Dirty Filter Switch"
        Me.chkIFDFS.UseVisualStyleBackColor = True
        '
        'chkIFXducer
        '
        Me.chkIFXducer.AutoSize = True
        Me.chkIFXducer.Location = New System.Drawing.Point(6, 66)
        Me.chkIFXducer.Name = "chkIFXducer"
        Me.chkIFXducer.Size = New System.Drawing.Size(98, 17)
        Me.chkIFXducer.TabIndex = 50
        Me.chkIFXducer.Text = "DP Transducer"
        Me.chkIFXducer.UseVisualStyleBackColor = True
        '
        'chkMountEquipmentTouch
        '
        Me.chkMountEquipmentTouch.AutoSize = True
        Me.chkMountEquipmentTouch.Enabled = False
        Me.chkMountEquipmentTouch.Location = New System.Drawing.Point(21, 271)
        Me.chkMountEquipmentTouch.Name = "chkMountEquipmentTouch"
        Me.chkMountEquipmentTouch.Size = New System.Drawing.Size(165, 17)
        Me.chkMountEquipmentTouch.TabIndex = 31
        Me.chkMountEquipmentTouch.Text = "Unit Mount Equipment Touch"
        Me.chkMountEquipmentTouch.UseVisualStyleBackColor = True
        '
        'chkIncludeEquipmentTouch
        '
        Me.chkIncludeEquipmentTouch.AutoSize = True
        Me.chkIncludeEquipmentTouch.Location = New System.Drawing.Point(7, 252)
        Me.chkIncludeEquipmentTouch.Name = "chkIncludeEquipmentTouch"
        Me.chkIncludeEquipmentTouch.Size = New System.Drawing.Size(149, 17)
        Me.chkIncludeEquipmentTouch.TabIndex = 30
        Me.chkIncludeEquipmentTouch.Text = "Provide Equipment Touch"
        Me.chkIncludeEquipmentTouch.UseVisualStyleBackColor = True
        '
        'btnDoneControls
        '
        Me.btnDoneControls.Location = New System.Drawing.Point(847, 458)
        Me.btnDoneControls.Name = "btnDoneControls"
        Me.btnDoneControls.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneControls.TabIndex = 24
        Me.btnDoneControls.Text = ">"
        Me.btnDoneControls.UseVisualStyleBackColor = True
        '
        'tpgFilters
        '
        Me.tpgFilters.Controls.Add(Me.cmdAddMF)
        Me.tpgFilters.Controls.Add(Me.Label15)
        Me.tpgFilters.Controls.Add(Me.lstPreMFSelected)
        Me.tpgFilters.Controls.Add(Me.lblMiscFilters)
        Me.tpgFilters.Controls.Add(Me.lstMFSelected)
        Me.tpgFilters.Controls.Add(Me.cmdSubMF)
        Me.tpgFilters.Controls.Add(Me.cmbActMF)
        Me.tpgFilters.Controls.Add(Me.lstMFAvail)
        Me.tpgFilters.Controls.Add(Me.Label13)
        Me.tpgFilters.Controls.Add(Me.Label10)
        Me.tpgFilters.Controls.Add(Me.lstPreFFSelected)
        Me.tpgFilters.Controls.Add(Me.lstPreIFSelected)
        Me.tpgFilters.Controls.Add(Me.Label9)
        Me.tpgFilters.Controls.Add(Me.Label7)
        Me.tpgFilters.Controls.Add(Me.cmdSubIF)
        Me.tpgFilters.Controls.Add(Me.cmdAddIF)
        Me.tpgFilters.Controls.Add(Me.lstIFSelected)
        Me.tpgFilters.Controls.Add(Me.lstIFAvail)
        Me.tpgFilters.Controls.Add(Me.lstFFSelected)
        Me.tpgFilters.Controls.Add(Me.cmbActIF)
        Me.tpgFilters.Controls.Add(Me.cmdSubFF)
        Me.tpgFilters.Controls.Add(Me.cmbActFF)
        Me.tpgFilters.Controls.Add(Me.cmdAddFF)
        Me.tpgFilters.Controls.Add(Me.btnDoneFilters)
        Me.tpgFilters.Controls.Add(Me.lstFFAvail)
        Me.tpgFilters.Location = New System.Drawing.Point(4, 22)
        Me.tpgFilters.Name = "tpgFilters"
        Me.tpgFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgFilters.Size = New System.Drawing.Size(902, 487)
        Me.tpgFilters.TabIndex = 2
        Me.tpgFilters.Text = "Filters"
        Me.tpgFilters.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Pre-Initial Filters"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Pre-Final Filters"
        '
        'lstPreFFSelected
        '
        Me.lstPreFFSelected.Enabled = False
        Me.lstPreFFSelected.FormattingEnabled = True
        Me.lstPreFFSelected.Location = New System.Drawing.Point(380, 327)
        Me.lstPreFFSelected.Name = "lstPreFFSelected"
        Me.lstPreFFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstPreFFSelected.TabIndex = 45
        '
        'lstPreIFSelected
        '
        Me.lstPreIFSelected.Enabled = False
        Me.lstPreIFSelected.FormattingEnabled = True
        Me.lstPreIFSelected.Location = New System.Drawing.Point(186, 327)
        Me.lstPreIFSelected.Name = "lstPreIFSelected"
        Me.lstPreIFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstPreIFSelected.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(443, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Final Filters"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Initial Filters"
        '
        'cmdSubIF
        '
        Me.cmdSubIF.Enabled = False
        Me.cmdSubIF.Location = New System.Drawing.Point(237, 209)
        Me.cmdSubIF.Name = "cmdSubIF"
        Me.cmdSubIF.Size = New System.Drawing.Size(29, 22)
        Me.cmdSubIF.TabIndex = 41
        Me.cmdSubIF.Text = "-"
        Me.cmdSubIF.UseVisualStyleBackColor = True
        '
        'cmdAddIF
        '
        Me.cmdAddIF.Enabled = False
        Me.cmdAddIF.Location = New System.Drawing.Point(202, 209)
        Me.cmdAddIF.Name = "cmdAddIF"
        Me.cmdAddIF.Size = New System.Drawing.Size(29, 22)
        Me.cmdAddIF.TabIndex = 40
        Me.cmdAddIF.Text = "+"
        Me.cmdAddIF.UseVisualStyleBackColor = True
        '
        'lstIFSelected
        '
        Me.lstIFSelected.Enabled = False
        Me.lstIFSelected.FormattingEnabled = True
        Me.lstIFSelected.Location = New System.Drawing.Point(186, 239)
        Me.lstIFSelected.Name = "lstIFSelected"
        Me.lstIFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstIFSelected.TabIndex = 39
        '
        'lstIFAvail
        '
        Me.lstIFAvail.Enabled = False
        Me.lstIFAvail.FormattingEnabled = True
        Me.lstIFAvail.Location = New System.Drawing.Point(186, 95)
        Me.lstIFAvail.Name = "lstIFAvail"
        Me.lstIFAvail.Size = New System.Drawing.Size(188, 108)
        Me.lstIFAvail.TabIndex = 6
        '
        'lstFFSelected
        '
        Me.lstFFSelected.Enabled = False
        Me.lstFFSelected.FormattingEnabled = True
        Me.lstFFSelected.Location = New System.Drawing.Point(380, 239)
        Me.lstFFSelected.Name = "lstFFSelected"
        Me.lstFFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstFFSelected.TabIndex = 1
        '
        'cmbActIF
        '
        Me.cmbActIF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActIF.Enabled = False
        Me.cmbActIF.FormattingEnabled = True
        Me.cmbActIF.Location = New System.Drawing.Point(186, 68)
        Me.cmbActIF.Name = "cmbActIF"
        Me.cmbActIF.Size = New System.Drawing.Size(188, 21)
        Me.cmbActIF.TabIndex = 5
        '
        'cmdSubFF
        '
        Me.cmdSubFF.Enabled = False
        Me.cmdSubFF.Location = New System.Drawing.Point(446, 209)
        Me.cmdSubFF.Name = "cmdSubFF"
        Me.cmdSubFF.Size = New System.Drawing.Size(29, 22)
        Me.cmdSubFF.TabIndex = 3
        Me.cmdSubFF.Text = "-"
        Me.cmdSubFF.UseVisualStyleBackColor = True
        '
        'cmbActFF
        '
        Me.cmbActFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActFF.Enabled = False
        Me.cmbActFF.FormattingEnabled = True
        Me.cmbActFF.Location = New System.Drawing.Point(380, 68)
        Me.cmbActFF.Name = "cmbActFF"
        Me.cmbActFF.Size = New System.Drawing.Size(188, 21)
        Me.cmbActFF.TabIndex = 4
        '
        'cmdAddFF
        '
        Me.cmdAddFF.Enabled = False
        Me.cmdAddFF.Location = New System.Drawing.Point(411, 209)
        Me.cmdAddFF.Name = "cmdAddFF"
        Me.cmdAddFF.Size = New System.Drawing.Size(29, 22)
        Me.cmdAddFF.TabIndex = 2
        Me.cmdAddFF.Text = "+"
        Me.cmdAddFF.UseVisualStyleBackColor = True
        '
        'btnDoneFilters
        '
        Me.btnDoneFilters.Location = New System.Drawing.Point(847, 458)
        Me.btnDoneFilters.Name = "btnDoneFilters"
        Me.btnDoneFilters.Size = New System.Drawing.Size(41, 23)
        Me.btnDoneFilters.TabIndex = 38
        Me.btnDoneFilters.Text = ">"
        Me.btnDoneFilters.UseVisualStyleBackColor = True
        '
        'lstFFAvail
        '
        Me.lstFFAvail.Enabled = False
        Me.lstFFAvail.FormattingEnabled = True
        Me.lstFFAvail.Location = New System.Drawing.Point(380, 95)
        Me.lstFFAvail.Name = "lstFFAvail"
        Me.lstFFAvail.Size = New System.Drawing.Size(188, 108)
        Me.lstFFAvail.TabIndex = 0
        '
        'tpgPerformance
        '
        Me.tpgPerformance.Controls.Add(Me.grpMiscPerf)
        Me.tpgPerformance.Controls.Add(Me.grpInitialPerf)
        Me.tpgPerformance.Controls.Add(Me.grpFinalPerf)
        Me.tpgPerformance.Controls.Add(Me.btnDonePerformance)
        Me.tpgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpgPerformance.Name = "tpgPerformance"
        Me.tpgPerformance.Size = New System.Drawing.Size(902, 487)
        Me.tpgPerformance.TabIndex = 5
        Me.tpgPerformance.Text = "Performance"
        Me.tpgPerformance.UseVisualStyleBackColor = True
        '
        'grpInitialPerf
        '
        Me.grpInitialPerf.Controls.Add(Me.Label22)
        Me.grpInitialPerf.Controls.Add(Me.txtPreIDFA)
        Me.grpInitialPerf.Controls.Add(Me.lblPreIMaxAPD)
        Me.grpInitialPerf.Controls.Add(Me.Label21)
        Me.grpInitialPerf.Controls.Add(Me.lblPreIAPD)
        Me.grpInitialPerf.Controls.Add(Me.Label17)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterQ4)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterSize4)
        Me.grpInitialPerf.Controls.Add(Me.lblIStaticBudget)
        Me.grpInitialPerf.Controls.Add(Me.Label11)
        Me.grpInitialPerf.Controls.Add(Me.Label12)
        Me.grpInitialPerf.Controls.Add(Me.txtIDFA)
        Me.grpInitialPerf.Controls.Add(Me.lblIMaxAPD)
        Me.grpInitialPerf.Controls.Add(Me.Label14)
        Me.grpInitialPerf.Controls.Add(Me.lblIAPD)
        Me.grpInitialPerf.Controls.Add(Me.Label16)
        Me.grpInitialPerf.Controls.Add(Me.lblIFaceVelocity)
        Me.grpInitialPerf.Controls.Add(Me.Label18)
        Me.grpInitialPerf.Controls.Add(Me.lblIFaceArea)
        Me.grpInitialPerf.Controls.Add(Me.Label20)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterQ3)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterQ2)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterQ1)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterSize3)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterSize2)
        Me.grpInitialPerf.Controls.Add(Me.lblIFilterSize1)
        Me.grpInitialPerf.Location = New System.Drawing.Point(9, 6)
        Me.grpInitialPerf.Name = "grpInitialPerf"
        Me.grpInitialPerf.Size = New System.Drawing.Size(200, 336)
        Me.grpInitialPerf.TabIndex = 39
        Me.grpInitialPerf.TabStop = False
        Me.grpInitialPerf.Text = "Initial Filters"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(57, 289)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Pre DFA"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPreIDFA
        '
        Me.txtPreIDFA.Location = New System.Drawing.Point(105, 286)
        Me.txtPreIDFA.Name = "txtPreIDFA"
        Me.txtPreIDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtPreIDFA.TabIndex = 24
        Me.txtPreIDFA.Text = "0.00"
        '
        'lblPreIMaxAPD
        '
        Me.lblPreIMaxAPD.AutoSize = True
        Me.lblPreIMaxAPD.Location = New System.Drawing.Point(104, 270)
        Me.lblPreIMaxAPD.Name = "lblPreIMaxAPD"
        Me.lblPreIMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreIMaxAPD.TabIndex = 23
        Me.lblPreIMaxAPD.Text = "0.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 270)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(99, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Pre Max. Final APD"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPreIAPD
        '
        Me.lblPreIAPD.AutoSize = True
        Me.lblPreIAPD.Location = New System.Drawing.Point(104, 257)
        Me.lblPreIAPD.Name = "lblPreIAPD"
        Me.lblPreIAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreIAPD.TabIndex = 21
        Me.lblPreIAPD.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(31, 257)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Pre Filter APD"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFilterQ4
        '
        Me.lblIFilterQ4.AutoSize = True
        Me.lblIFilterQ4.Location = New System.Drawing.Point(77, 55)
        Me.lblIFilterQ4.Name = "lblIFilterQ4"
        Me.lblIFilterQ4.Size = New System.Drawing.Size(39, 13)
        Me.lblIFilterQ4.TabIndex = 19
        Me.lblIFilterQ4.Text = "Label7"
        '
        'lblIFilterSize4
        '
        Me.lblIFilterSize4.AutoSize = True
        Me.lblIFilterSize4.Location = New System.Drawing.Point(6, 55)
        Me.lblIFilterSize4.Name = "lblIFilterSize4"
        Me.lblIFilterSize4.Size = New System.Drawing.Size(39, 13)
        Me.lblIFilterSize4.TabIndex = 18
        Me.lblIFilterSize4.Text = "Label9"
        Me.lblIFilterSize4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIStaticBudget
        '
        Me.lblIStaticBudget.AutoSize = True
        Me.lblIStaticBudget.Location = New System.Drawing.Point(104, 320)
        Me.lblIStaticBudget.Name = "lblIStaticBudget"
        Me.lblIStaticBudget.Size = New System.Drawing.Size(28, 13)
        Me.lblIStaticBudget.TabIndex = 17
        Me.lblIStaticBudget.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Static Budget"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(76, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "DFA"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIDFA
        '
        Me.txtIDFA.Location = New System.Drawing.Point(105, 231)
        Me.txtIDFA.Name = "txtIDFA"
        Me.txtIDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtIDFA.TabIndex = 14
        Me.txtIDFA.Text = "0.00"
        '
        'lblIMaxAPD
        '
        Me.lblIMaxAPD.AutoSize = True
        Me.lblIMaxAPD.Location = New System.Drawing.Point(104, 215)
        Me.lblIMaxAPD.Name = "lblIMaxAPD"
        Me.lblIMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblIMaxAPD.TabIndex = 13
        Me.lblIMaxAPD.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Max. Final APD"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIAPD
        '
        Me.lblIAPD.AutoSize = True
        Me.lblIAPD.Location = New System.Drawing.Point(104, 202)
        Me.lblIAPD.Name = "lblIAPD"
        Me.lblIAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblIAPD.TabIndex = 11
        Me.lblIAPD.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(75, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "APD"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFaceVelocity
        '
        Me.lblIFaceVelocity.AutoSize = True
        Me.lblIFaceVelocity.Location = New System.Drawing.Point(104, 189)
        Me.lblIFaceVelocity.Name = "lblIFaceVelocity"
        Me.lblIFaceVelocity.Size = New System.Drawing.Size(22, 13)
        Me.lblIFaceVelocity.TabIndex = 9
        Me.lblIFaceVelocity.Text = "0.0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Face Velocity"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFaceArea
        '
        Me.lblIFaceArea.AutoSize = True
        Me.lblIFaceArea.Location = New System.Drawing.Point(104, 176)
        Me.lblIFaceArea.Name = "lblIFaceArea"
        Me.lblIFaceArea.Size = New System.Drawing.Size(22, 13)
        Me.lblIFaceArea.TabIndex = 7
        Me.lblIFaceArea.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(48, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Face Area"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFilterQ3
        '
        Me.lblIFilterQ3.AutoSize = True
        Me.lblIFilterQ3.Location = New System.Drawing.Point(77, 42)
        Me.lblIFilterQ3.Name = "lblIFilterQ3"
        Me.lblIFilterQ3.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterQ3.TabIndex = 5
        Me.lblIFilterQ3.Text = "Label21"
        '
        'lblIFilterQ2
        '
        Me.lblIFilterQ2.AutoSize = True
        Me.lblIFilterQ2.Location = New System.Drawing.Point(77, 29)
        Me.lblIFilterQ2.Name = "lblIFilterQ2"
        Me.lblIFilterQ2.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterQ2.TabIndex = 4
        Me.lblIFilterQ2.Text = "Label22"
        '
        'lblIFilterQ1
        '
        Me.lblIFilterQ1.AutoSize = True
        Me.lblIFilterQ1.Location = New System.Drawing.Point(77, 16)
        Me.lblIFilterQ1.Name = "lblIFilterQ1"
        Me.lblIFilterQ1.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterQ1.TabIndex = 3
        Me.lblIFilterQ1.Text = "Label23"
        '
        'lblIFilterSize3
        '
        Me.lblIFilterSize3.AutoSize = True
        Me.lblIFilterSize3.Location = New System.Drawing.Point(6, 42)
        Me.lblIFilterSize3.Name = "lblIFilterSize3"
        Me.lblIFilterSize3.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterSize3.TabIndex = 2
        Me.lblIFilterSize3.Text = "Label24"
        Me.lblIFilterSize3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFilterSize2
        '
        Me.lblIFilterSize2.AutoSize = True
        Me.lblIFilterSize2.Location = New System.Drawing.Point(5, 29)
        Me.lblIFilterSize2.Name = "lblIFilterSize2"
        Me.lblIFilterSize2.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterSize2.TabIndex = 1
        Me.lblIFilterSize2.Text = "Label25"
        Me.lblIFilterSize2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIFilterSize1
        '
        Me.lblIFilterSize1.AutoSize = True
        Me.lblIFilterSize1.Location = New System.Drawing.Point(6, 16)
        Me.lblIFilterSize1.Name = "lblIFilterSize1"
        Me.lblIFilterSize1.Size = New System.Drawing.Size(45, 13)
        Me.lblIFilterSize1.TabIndex = 0
        Me.lblIFilterSize1.Text = "Label26"
        Me.lblIFilterSize1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpFinalPerf
        '
        Me.grpFinalPerf.Controls.Add(Me.Label23)
        Me.grpFinalPerf.Controls.Add(Me.txtPreFDFA)
        Me.grpFinalPerf.Controls.Add(Me.lblPreFMaxAPD)
        Me.grpFinalPerf.Controls.Add(Me.Label25)
        Me.grpFinalPerf.Controls.Add(Me.lblPreFAPD)
        Me.grpFinalPerf.Controls.Add(Me.Label27)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterQ4)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterSize4)
        Me.grpFinalPerf.Controls.Add(Me.lblStaticBudget)
        Me.grpFinalPerf.Controls.Add(Me.Label8)
        Me.grpFinalPerf.Controls.Add(Me.Label2)
        Me.grpFinalPerf.Controls.Add(Me.txtDFA)
        Me.grpFinalPerf.Controls.Add(Me.lblMaxAPD)
        Me.grpFinalPerf.Controls.Add(Me.Label6)
        Me.grpFinalPerf.Controls.Add(Me.lblAPD)
        Me.grpFinalPerf.Controls.Add(Me.Label5)
        Me.grpFinalPerf.Controls.Add(Me.lblFaceVelocity)
        Me.grpFinalPerf.Controls.Add(Me.Label4)
        Me.grpFinalPerf.Controls.Add(Me.lblFaceArea)
        Me.grpFinalPerf.Controls.Add(Me.Label3)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterQ3)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterQ2)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterQ1)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterSize3)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterSize2)
        Me.grpFinalPerf.Controls.Add(Me.lblFilterSize1)
        Me.grpFinalPerf.Location = New System.Drawing.Point(215, 6)
        Me.grpFinalPerf.Name = "grpFinalPerf"
        Me.grpFinalPerf.Size = New System.Drawing.Size(200, 336)
        Me.grpFinalPerf.TabIndex = 38
        Me.grpFinalPerf.TabStop = False
        Me.grpFinalPerf.Text = "Final Filters"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(55, 289)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Pre DFA"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPreFDFA
        '
        Me.txtPreFDFA.Location = New System.Drawing.Point(103, 286)
        Me.txtPreFDFA.Name = "txtPreFDFA"
        Me.txtPreFDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtPreFDFA.TabIndex = 30
        Me.txtPreFDFA.Text = "0.00"
        '
        'lblPreFMaxAPD
        '
        Me.lblPreFMaxAPD.AutoSize = True
        Me.lblPreFMaxAPD.Location = New System.Drawing.Point(102, 270)
        Me.lblPreFMaxAPD.Name = "lblPreFMaxAPD"
        Me.lblPreFMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreFMaxAPD.TabIndex = 29
        Me.lblPreFMaxAPD.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 270)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 13)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Pre Max. Final APD"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPreFAPD
        '
        Me.lblPreFAPD.AutoSize = True
        Me.lblPreFAPD.Location = New System.Drawing.Point(102, 257)
        Me.lblPreFAPD.Name = "lblPreFAPD"
        Me.lblPreFAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreFAPD.TabIndex = 27
        Me.lblPreFAPD.Text = "0.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(29, 257)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 13)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "Pre Filter APD"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterQ4
        '
        Me.lblFilterQ4.AutoSize = True
        Me.lblFilterQ4.Location = New System.Drawing.Point(77, 55)
        Me.lblFilterQ4.Name = "lblFilterQ4"
        Me.lblFilterQ4.Size = New System.Drawing.Size(53, 13)
        Me.lblFilterQ4.TabIndex = 19
        Me.lblFilterQ4.Text = "lblFilterQ4"
        '
        'lblFilterSize4
        '
        Me.lblFilterSize4.AutoSize = True
        Me.lblFilterSize4.Location = New System.Drawing.Point(6, 55)
        Me.lblFilterSize4.Name = "lblFilterSize4"
        Me.lblFilterSize4.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize4.TabIndex = 18
        Me.lblFilterSize4.Text = "lblFilterSize4"
        Me.lblFilterSize4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStaticBudget
        '
        Me.lblStaticBudget.AutoSize = True
        Me.lblStaticBudget.Location = New System.Drawing.Point(102, 320)
        Me.lblStaticBudget.Name = "lblStaticBudget"
        Me.lblStaticBudget.Size = New System.Drawing.Size(28, 13)
        Me.lblStaticBudget.TabIndex = 17
        Me.lblStaticBudget.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Static Budget"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DFA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDFA
        '
        Me.txtDFA.Location = New System.Drawing.Point(105, 231)
        Me.txtDFA.Name = "txtDFA"
        Me.txtDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtDFA.TabIndex = 14
        Me.txtDFA.Text = "0.00"
        '
        'lblMaxAPD
        '
        Me.lblMaxAPD.AutoSize = True
        Me.lblMaxAPD.Location = New System.Drawing.Point(102, 215)
        Me.lblMaxAPD.Name = "lblMaxAPD"
        Me.lblMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblMaxAPD.TabIndex = 13
        Me.lblMaxAPD.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Max. Final APD"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAPD
        '
        Me.lblAPD.AutoSize = True
        Me.lblAPD.Location = New System.Drawing.Point(102, 202)
        Me.lblAPD.Name = "lblAPD"
        Me.lblAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblAPD.TabIndex = 11
        Me.lblAPD.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "APD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFaceVelocity
        '
        Me.lblFaceVelocity.AutoSize = True
        Me.lblFaceVelocity.Location = New System.Drawing.Point(102, 189)
        Me.lblFaceVelocity.Name = "lblFaceVelocity"
        Me.lblFaceVelocity.Size = New System.Drawing.Size(22, 13)
        Me.lblFaceVelocity.TabIndex = 9
        Me.lblFaceVelocity.Text = "0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Face Velocity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFaceArea
        '
        Me.lblFaceArea.AutoSize = True
        Me.lblFaceArea.Location = New System.Drawing.Point(102, 176)
        Me.lblFaceArea.Name = "lblFaceArea"
        Me.lblFaceArea.Size = New System.Drawing.Size(22, 13)
        Me.lblFaceArea.TabIndex = 7
        Me.lblFaceArea.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Face Area"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterQ3
        '
        Me.lblFilterQ3.AutoSize = True
        Me.lblFilterQ3.Location = New System.Drawing.Point(77, 42)
        Me.lblFilterQ3.Name = "lblFilterQ3"
        Me.lblFilterQ3.Size = New System.Drawing.Size(53, 13)
        Me.lblFilterQ3.TabIndex = 5
        Me.lblFilterQ3.Text = "lblFilterQ3"
        '
        'lblFilterQ2
        '
        Me.lblFilterQ2.AutoSize = True
        Me.lblFilterQ2.Location = New System.Drawing.Point(77, 29)
        Me.lblFilterQ2.Name = "lblFilterQ2"
        Me.lblFilterQ2.Size = New System.Drawing.Size(53, 13)
        Me.lblFilterQ2.TabIndex = 4
        Me.lblFilterQ2.Text = "lblFilterQ2"
        '
        'lblFilterQ1
        '
        Me.lblFilterQ1.AutoSize = True
        Me.lblFilterQ1.Location = New System.Drawing.Point(77, 16)
        Me.lblFilterQ1.Name = "lblFilterQ1"
        Me.lblFilterQ1.Size = New System.Drawing.Size(53, 13)
        Me.lblFilterQ1.TabIndex = 3
        Me.lblFilterQ1.Text = "lblFilterQ1"
        '
        'lblFilterSize3
        '
        Me.lblFilterSize3.AutoSize = True
        Me.lblFilterSize3.Location = New System.Drawing.Point(6, 42)
        Me.lblFilterSize3.Name = "lblFilterSize3"
        Me.lblFilterSize3.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize3.TabIndex = 2
        Me.lblFilterSize3.Text = "lblFilterSize3"
        Me.lblFilterSize3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterSize2
        '
        Me.lblFilterSize2.AutoSize = True
        Me.lblFilterSize2.Location = New System.Drawing.Point(6, 29)
        Me.lblFilterSize2.Name = "lblFilterSize2"
        Me.lblFilterSize2.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize2.TabIndex = 1
        Me.lblFilterSize2.Text = "lblFilterSize2"
        Me.lblFilterSize2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFilterSize1
        '
        Me.lblFilterSize1.AutoSize = True
        Me.lblFilterSize1.Location = New System.Drawing.Point(6, 16)
        Me.lblFilterSize1.Name = "lblFilterSize1"
        Me.lblFilterSize1.Size = New System.Drawing.Size(65, 13)
        Me.lblFilterSize1.TabIndex = 0
        Me.lblFilterSize1.Text = "lblFilterSize1"
        Me.lblFilterSize1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDonePerformance
        '
        Me.btnDonePerformance.Location = New System.Drawing.Point(847, 458)
        Me.btnDonePerformance.Name = "btnDonePerformance"
        Me.btnDonePerformance.Size = New System.Drawing.Size(41, 23)
        Me.btnDonePerformance.TabIndex = 10
        Me.btnDonePerformance.Text = ">"
        Me.btnDonePerformance.UseVisualStyleBackColor = True
        '
        'DebugPage
        '
        Me.DebugPage.Location = New System.Drawing.Point(4, 22)
        Me.DebugPage.Name = "DebugPage"
        Me.DebugPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DebugPage.Size = New System.Drawing.Size(894, 487)
        Me.DebugPage.TabIndex = 3
        Me.DebugPage.Text = "Debug"
        Me.DebugPage.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(83, 530)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(5, 530)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(873, 530)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 9
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(837, 530)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 10
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'chkWriteHistory
        '
        Me.chkWriteHistory.AutoSize = True
        Me.chkWriteHistory.Checked = True
        Me.chkWriteHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWriteHistory.Location = New System.Drawing.Point(161, 542)
        Me.chkWriteHistory.Name = "chkWriteHistory"
        Me.chkWriteHistory.Size = New System.Drawing.Size(86, 17)
        Me.chkWriteHistory.TabIndex = 13
        Me.chkWriteHistory.Text = "Write History"
        Me.chkWriteHistory.UseVisualStyleBackColor = True
        '
        'chkAddMERV132inToSeries20
        '
        Me.chkAddMERV132inToSeries20.AutoSize = True
        Me.chkAddMERV132inToSeries20.Location = New System.Drawing.Point(6, 78)
        Me.chkAddMERV132inToSeries20.Name = "chkAddMERV132inToSeries20"
        Me.chkAddMERV132inToSeries20.Size = New System.Drawing.Size(211, 17)
        Me.chkAddMERV132inToSeries20.TabIndex = 45
        Me.chkAddMERV132inToSeries20.Text = "Add MERV13 2"" to JCI Rack Series 20"
        Me.chkAddMERV132inToSeries20.UseVisualStyleBackColor = True
        Me.chkAddMERV132inToSeries20.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(637, 311)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Pre-Final Filters"
        '
        'lstPreMFSelected
        '
        Me.lstPreMFSelected.Enabled = False
        Me.lstPreMFSelected.FormattingEnabled = True
        Me.lstPreMFSelected.Location = New System.Drawing.Point(574, 327)
        Me.lstPreMFSelected.Name = "lstPreMFSelected"
        Me.lstPreMFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstPreMFSelected.TabIndex = 53
        '
        'lblMiscFilters
        '
        Me.lblMiscFilters.AutoSize = True
        Me.lblMiscFilters.Location = New System.Drawing.Point(637, 52)
        Me.lblMiscFilters.Name = "lblMiscFilters"
        Me.lblMiscFilters.Size = New System.Drawing.Size(59, 13)
        Me.lblMiscFilters.TabIndex = 52
        Me.lblMiscFilters.Text = "Misc Fliters"
        '
        'lstMFSelected
        '
        Me.lstMFSelected.Enabled = False
        Me.lstMFSelected.FormattingEnabled = True
        Me.lstMFSelected.Location = New System.Drawing.Point(574, 239)
        Me.lstMFSelected.Name = "lstMFSelected"
        Me.lstMFSelected.Size = New System.Drawing.Size(188, 69)
        Me.lstMFSelected.TabIndex = 49
        '
        'cmdSubMF
        '
        Me.cmdSubMF.Enabled = False
        Me.cmdSubMF.Location = New System.Drawing.Point(640, 209)
        Me.cmdSubMF.Name = "cmdSubMF"
        Me.cmdSubMF.Size = New System.Drawing.Size(29, 22)
        Me.cmdSubMF.TabIndex = 50
        Me.cmdSubMF.Text = "-"
        Me.cmdSubMF.UseVisualStyleBackColor = True
        '
        'cmbActMF
        '
        Me.cmbActMF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActMF.Enabled = False
        Me.cmbActMF.FormattingEnabled = True
        Me.cmbActMF.Location = New System.Drawing.Point(574, 68)
        Me.cmbActMF.Name = "cmbActMF"
        Me.cmbActMF.Size = New System.Drawing.Size(188, 21)
        Me.cmbActMF.TabIndex = 51
        '
        'lstMFAvail
        '
        Me.lstMFAvail.Enabled = False
        Me.lstMFAvail.FormattingEnabled = True
        Me.lstMFAvail.Location = New System.Drawing.Point(574, 95)
        Me.lstMFAvail.Name = "lstMFAvail"
        Me.lstMFAvail.Size = New System.Drawing.Size(188, 108)
        Me.lstMFAvail.TabIndex = 48
        '
        'cmdAddMF
        '
        Me.cmdAddMF.Enabled = False
        Me.cmdAddMF.Location = New System.Drawing.Point(605, 209)
        Me.cmdAddMF.Name = "cmdAddMF"
        Me.cmdAddMF.Size = New System.Drawing.Size(29, 22)
        Me.cmdAddMF.TabIndex = 55
        Me.cmdAddMF.Text = "+"
        Me.cmdAddMF.UseVisualStyleBackColor = True
        '
        'grpMiscPerf
        '
        Me.grpMiscPerf.Controls.Add(Me.Label19)
        Me.grpMiscPerf.Controls.Add(Me.txtPreMDFA)
        Me.grpMiscPerf.Controls.Add(Me.lblPreMMaxAPD)
        Me.grpMiscPerf.Controls.Add(Me.Label26)
        Me.grpMiscPerf.Controls.Add(Me.lblPreMAPD)
        Me.grpMiscPerf.Controls.Add(Me.Label29)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterQ4)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterSize4)
        Me.grpMiscPerf.Controls.Add(Me.lblMStaticBudget)
        Me.grpMiscPerf.Controls.Add(Me.Label33)
        Me.grpMiscPerf.Controls.Add(Me.Label34)
        Me.grpMiscPerf.Controls.Add(Me.txtmDFA)
        Me.grpMiscPerf.Controls.Add(Me.lblMMaxAPD)
        Me.grpMiscPerf.Controls.Add(Me.Label36)
        Me.grpMiscPerf.Controls.Add(Me.lblMAPD)
        Me.grpMiscPerf.Controls.Add(Me.Label38)
        Me.grpMiscPerf.Controls.Add(Me.lblMFaceVelocity)
        Me.grpMiscPerf.Controls.Add(Me.Label40)
        Me.grpMiscPerf.Controls.Add(Me.lblMFaceArea)
        Me.grpMiscPerf.Controls.Add(Me.Label42)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterQ3)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterQ2)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterQ1)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterSize3)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterSize2)
        Me.grpMiscPerf.Controls.Add(Me.lblMFilterSize1)
        Me.grpMiscPerf.Location = New System.Drawing.Point(421, 6)
        Me.grpMiscPerf.Name = "grpMiscPerf"
        Me.grpMiscPerf.Size = New System.Drawing.Size(200, 336)
        Me.grpMiscPerf.TabIndex = 40
        Me.grpMiscPerf.TabStop = False
        Me.grpMiscPerf.Text = "Misc Filters"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(55, 289)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Pre DFA"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPreMDFA
        '
        Me.txtPreMDFA.Location = New System.Drawing.Point(103, 286)
        Me.txtPreMDFA.Name = "txtPreMDFA"
        Me.txtPreMDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtPreMDFA.TabIndex = 30
        Me.txtPreMDFA.Text = "0.00"
        '
        'lblPreMMaxAPD
        '
        Me.lblPreMMaxAPD.AutoSize = True
        Me.lblPreMMaxAPD.Location = New System.Drawing.Point(102, 270)
        Me.lblPreMMaxAPD.Name = "lblPreMMaxAPD"
        Me.lblPreMMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreMMaxAPD.TabIndex = 29
        Me.lblPreMMaxAPD.Text = "0.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 270)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Pre Max. Final APD"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPreMAPD
        '
        Me.lblPreMAPD.AutoSize = True
        Me.lblPreMAPD.Location = New System.Drawing.Point(102, 257)
        Me.lblPreMAPD.Name = "lblPreMAPD"
        Me.lblPreMAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblPreMAPD.TabIndex = 27
        Me.lblPreMAPD.Text = "0.00"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(29, 257)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 13)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Pre Filter APD"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFilterQ4
        '
        Me.lblMFilterQ4.AutoSize = True
        Me.lblMFilterQ4.Location = New System.Drawing.Point(77, 55)
        Me.lblMFilterQ4.Name = "lblMFilterQ4"
        Me.lblMFilterQ4.Size = New System.Drawing.Size(62, 13)
        Me.lblMFilterQ4.TabIndex = 19
        Me.lblMFilterQ4.Text = "lblMFilterQ4"
        '
        'lblMFilterSize4
        '
        Me.lblMFilterSize4.AutoSize = True
        Me.lblMFilterSize4.Location = New System.Drawing.Point(6, 55)
        Me.lblMFilterSize4.Name = "lblMFilterSize4"
        Me.lblMFilterSize4.Size = New System.Drawing.Size(74, 13)
        Me.lblMFilterSize4.TabIndex = 18
        Me.lblMFilterSize4.Text = "lblMFilterSize4"
        Me.lblMFilterSize4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMStaticBudget
        '
        Me.lblMStaticBudget.AutoSize = True
        Me.lblMStaticBudget.Location = New System.Drawing.Point(102, 320)
        Me.lblMStaticBudget.Name = "lblMStaticBudget"
        Me.lblMStaticBudget.Size = New System.Drawing.Size(28, 13)
        Me.lblMStaticBudget.TabIndex = 17
        Me.lblMStaticBudget.Text = "0.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(31, 320)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 13)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "Static Budget"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(74, 234)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(28, 13)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "DFA"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtmDFA
        '
        Me.txtmDFA.Location = New System.Drawing.Point(105, 231)
        Me.txtmDFA.Name = "txtmDFA"
        Me.txtmDFA.Size = New System.Drawing.Size(55, 20)
        Me.txtmDFA.TabIndex = 14
        Me.txtmDFA.Text = "0.00"
        '
        'lblMMaxAPD
        '
        Me.lblMMaxAPD.AutoSize = True
        Me.lblMMaxAPD.Location = New System.Drawing.Point(102, 215)
        Me.lblMMaxAPD.Name = "lblMMaxAPD"
        Me.lblMMaxAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblMMaxAPD.TabIndex = 13
        Me.lblMMaxAPD.Text = "0.00"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(22, 215)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "Max. Final APD"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMAPD
        '
        Me.lblMAPD.AutoSize = True
        Me.lblMAPD.Location = New System.Drawing.Point(102, 202)
        Me.lblMAPD.Name = "lblMAPD"
        Me.lblMAPD.Size = New System.Drawing.Size(28, 13)
        Me.lblMAPD.TabIndex = 11
        Me.lblMAPD.Text = "0.00"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(73, 202)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 13)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "APD"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFaceVelocity
        '
        Me.lblMFaceVelocity.AutoSize = True
        Me.lblMFaceVelocity.Location = New System.Drawing.Point(102, 189)
        Me.lblMFaceVelocity.Name = "lblMFaceVelocity"
        Me.lblMFaceVelocity.Size = New System.Drawing.Size(22, 13)
        Me.lblMFaceVelocity.TabIndex = 9
        Me.lblMFaceVelocity.Text = "0.0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(31, 189)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 13)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Face Velocity"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFaceArea
        '
        Me.lblMFaceArea.AutoSize = True
        Me.lblMFaceArea.Location = New System.Drawing.Point(102, 176)
        Me.lblMFaceArea.Name = "lblMFaceArea"
        Me.lblMFaceArea.Size = New System.Drawing.Size(22, 13)
        Me.lblMFaceArea.TabIndex = 7
        Me.lblMFaceArea.Text = "0.0"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(46, 176)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 13)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Face Area"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFilterQ3
        '
        Me.lblMFilterQ3.AutoSize = True
        Me.lblMFilterQ3.Location = New System.Drawing.Point(77, 42)
        Me.lblMFilterQ3.Name = "lblMFilterQ3"
        Me.lblMFilterQ3.Size = New System.Drawing.Size(62, 13)
        Me.lblMFilterQ3.TabIndex = 5
        Me.lblMFilterQ3.Text = "lblMFilterQ3"
        '
        'lblMFilterQ2
        '
        Me.lblMFilterQ2.AutoSize = True
        Me.lblMFilterQ2.Location = New System.Drawing.Point(77, 29)
        Me.lblMFilterQ2.Name = "lblMFilterQ2"
        Me.lblMFilterQ2.Size = New System.Drawing.Size(62, 13)
        Me.lblMFilterQ2.TabIndex = 4
        Me.lblMFilterQ2.Text = "lblMFilterQ2"
        '
        'lblMFilterQ1
        '
        Me.lblMFilterQ1.AutoSize = True
        Me.lblMFilterQ1.Location = New System.Drawing.Point(77, 16)
        Me.lblMFilterQ1.Name = "lblMFilterQ1"
        Me.lblMFilterQ1.Size = New System.Drawing.Size(62, 13)
        Me.lblMFilterQ1.TabIndex = 3
        Me.lblMFilterQ1.Text = "lblMFilterQ1"
        '
        'lblMFilterSize3
        '
        Me.lblMFilterSize3.AutoSize = True
        Me.lblMFilterSize3.Location = New System.Drawing.Point(6, 42)
        Me.lblMFilterSize3.Name = "lblMFilterSize3"
        Me.lblMFilterSize3.Size = New System.Drawing.Size(74, 13)
        Me.lblMFilterSize3.TabIndex = 2
        Me.lblMFilterSize3.Text = "lblMFilterSize3"
        Me.lblMFilterSize3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFilterSize2
        '
        Me.lblMFilterSize2.AutoSize = True
        Me.lblMFilterSize2.Location = New System.Drawing.Point(6, 29)
        Me.lblMFilterSize2.Name = "lblMFilterSize2"
        Me.lblMFilterSize2.Size = New System.Drawing.Size(74, 13)
        Me.lblMFilterSize2.TabIndex = 1
        Me.lblMFilterSize2.Text = "lblMFilterSize2"
        Me.lblMFilterSize2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMFilterSize1
        '
        Me.lblMFilterSize1.AutoSize = True
        Me.lblMFilterSize1.Location = New System.Drawing.Point(6, 16)
        Me.lblMFilterSize1.Name = "lblMFilterSize1"
        Me.lblMFilterSize1.Size = New System.Drawing.Size(74, 13)
        Me.lblMFilterSize1.TabIndex = 0
        Me.lblMFilterSize1.Text = "lblMFilterSize1"
        Me.lblMFilterSize1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkMFPrefilt
        '
        Me.chkMFPrefilt.AutoSize = True
        Me.chkMFPrefilt.Enabled = False
        Me.chkMFPrefilt.Location = New System.Drawing.Point(6, 101)
        Me.chkMFPrefilt.Name = "chkMFPrefilt"
        Me.chkMFPrefilt.Size = New System.Drawing.Size(213, 17)
        Me.chkMFPrefilt.TabIndex = 46
        Me.chkMFPrefilt.Text = "Misc Filter Bank Pre-Filters (2"" MERV 8)"
        Me.chkMFPrefilt.UseVisualStyleBackColor = True
        '
        'chkAddMERV132inToSeries10
        '
        Me.chkAddMERV132inToSeries10.AutoSize = True
        Me.chkAddMERV132inToSeries10.Location = New System.Drawing.Point(6, 55)
        Me.chkAddMERV132inToSeries10.Name = "chkAddMERV132inToSeries10"
        Me.chkAddMERV132inToSeries10.Size = New System.Drawing.Size(211, 17)
        Me.chkAddMERV132inToSeries10.TabIndex = 47
        Me.chkAddMERV132inToSeries10.Text = "Add MERV13 2"" to JCI Rack Series 10"
        Me.chkAddMERV132inToSeries10.UseVisualStyleBackColor = True
        Me.chkAddMERV132inToSeries10.Visible = False
        '
        'frmFiltration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(919, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkWriteHistory)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filtration"
        Me.TabControl1.ResumeLayout(False)
        Me.tpgConditions.ResumeLayout(False)
        Me.tpgConditions.PerformLayout()
        Me.grpFFRack.ResumeLayout(False)
        Me.grpFFRack.PerformLayout()
        Me.grpIFRack.ResumeLayout(False)
        Me.grpIFRack.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpgControls.ResumeLayout(False)
        Me.tpgControls.PerformLayout()
        Me.grpCtrlFinal.ResumeLayout(False)
        Me.grpCtrlFinal.PerformLayout()
        Me.grpCtrlFactory.ResumeLayout(False)
        Me.grpCtrlFactory.PerformLayout()
        Me.grpCtrlInitital.ResumeLayout(False)
        Me.grpCtrlInitital.PerformLayout()
        Me.tpgFilters.ResumeLayout(False)
        Me.tpgFilters.PerformLayout()
        Me.tpgPerformance.ResumeLayout(False)
        Me.grpInitialPerf.ResumeLayout(False)
        Me.grpInitialPerf.PerformLayout()
        Me.grpFinalPerf.ResumeLayout(False)
        Me.grpFinalPerf.PerformLayout()
        Me.grpMiscPerf.ResumeLayout(False)
        Me.grpMiscPerf.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgConditions As TabPage
    Friend WithEvents btnDoneConditions As Button
    Friend WithEvents tpgOptions As TabPage
    Friend WithEvents btnDoneOptions As Button
    Friend WithEvents tpgControls As TabPage
    Friend WithEvents chkMountEquipmentTouch As CheckBox
    Friend WithEvents chkIncludeEquipmentTouch As CheckBox
    Friend WithEvents btnDoneControls As Button
    Friend WithEvents tpgFilters As TabPage
    Friend WithEvents DebugPage As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chkFFBank As CheckBox
    Friend WithEvents chkIFBank As CheckBox
    Friend WithEvents cmbFFType As ComboBox
    Friend WithEvents cmbIFType As ComboBox
    Friend WithEvents chkFFPrefilt As CheckBox
    Friend WithEvents chkIFPrefilt As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAirflow As TextBox
    Friend WithEvents grpCtrlFinal As GroupBox
    Friend WithEvents grpCtrlFactory As GroupBox
    Friend WithEvents grpCtrlInitital As GroupBox
    Friend WithEvents chkFFMinihelic As CheckBox
    Friend WithEvents cmbFFMagRange As ComboBox
    Friend WithEvents chkFFMagnehelic As CheckBox
    Friend WithEvents chkRemoveJCIIPreFilts As CheckBox
    Friend WithEvents cmdSubFF As Button
    Friend WithEvents cmdAddFF As Button
    Friend WithEvents lstFFSelected As ListBox
    Friend WithEvents lstFFAvail As ListBox
    Friend WithEvents tpgPerformance As TabPage
    Friend WithEvents btnDoneFilters As Button
    Friend WithEvents btnDonePerformance As Button
    Friend WithEvents grpFinalPerf As GroupBox
    Friend WithEvents lblFilterQ3 As Label
    Friend WithEvents lblFilterQ2 As Label
    Friend WithEvents lblFilterQ1 As Label
    Friend WithEvents lblFilterSize3 As Label
    Friend WithEvents lblFilterSize2 As Label
    Friend WithEvents lblFilterSize1 As Label
    Friend WithEvents lblFaceArea As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFaceVelocity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbActFF As ComboBox
    Friend WithEvents lblAPD As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDFA As TextBox
    Friend WithEvents lblMaxAPD As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStaticBudget As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkIFPrefiltUseJCI As CheckBox
    Friend WithEvents chkRelocateJCIIFinalPreFilts As CheckBox
    Friend WithEvents chkRemoveJCIIFinalPreFilts As CheckBox
    Friend WithEvents chkRelocateJCIFFilts As CheckBox
    Friend WithEvents chkRelocateJCIIFilts As CheckBox
    Friend WithEvents chkRelocateJCIIPreFilts As CheckBox
    Friend WithEvents chkRemoveJCIFFilts As CheckBox
    Friend WithEvents chkRemoveJCIIFilts As CheckBox
    Friend WithEvents cmbExternalModuleStyle As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optExtMod3Party As RadioButton
    Friend WithEvents optExtModDown As RadioButton
    Friend WithEvents optExtModHoriz As RadioButton
    Friend WithEvents optExtModNone As RadioButton
    Friend WithEvents cmbFFXdcrRange As ComboBox
    Friend WithEvents chkFFXdcrWire As CheckBox
    Friend WithEvents chkFFDFSWire As CheckBox
    Friend WithEvents chkFFDFS As CheckBox
    Friend WithEvents chkFFXducer As CheckBox
    Friend WithEvents cmbJCIFXdcrRange As ComboBox
    Friend WithEvents chkJCIFXdcrWire As CheckBox
    Friend WithEvents chkJCIFDFSWire As CheckBox
    Friend WithEvents chkJCIFDFS As CheckBox
    Friend WithEvents chkJCIFXducer As CheckBox
    Friend WithEvents chkJCIFMinihelic As CheckBox
    Friend WithEvents cmbJCIFMagRange As ComboBox
    Friend WithEvents chkJCIFMagnehelic As CheckBox
    Friend WithEvents cmbIFXdcrRange As ComboBox
    Friend WithEvents chkIFMagnehelic As CheckBox
    Friend WithEvents chkIFXdcrWire As CheckBox
    Friend WithEvents cmbIFMagRange As ComboBox
    Friend WithEvents chkIFDFSWire As CheckBox
    Friend WithEvents chkIFMinihelic As CheckBox
    Friend WithEvents chkIFDFS As CheckBox
    Friend WithEvents chkIFXducer As CheckBox
    Friend WithEvents cmbActIF As ComboBox
    Friend WithEvents lstIFAvail As ListBox
    Friend WithEvents cmdSubIF As Button
    Friend WithEvents cmdAddIF As Button
    Friend WithEvents lstIFSelected As ListBox
    Friend WithEvents lblFilterQ4 As Label
    Friend WithEvents lblFilterSize4 As Label
    Friend WithEvents grpInitialPerf As GroupBox
    Friend WithEvents lblIFilterQ4 As Label
    Friend WithEvents lblIFilterSize4 As Label
    Friend WithEvents lblIStaticBudget As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIDFA As TextBox
    Friend WithEvents lblIMaxAPD As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblIAPD As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblIFaceVelocity As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblIFaceArea As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblIFilterQ3 As Label
    Friend WithEvents lblIFilterQ2 As Label
    Friend WithEvents lblIFilterQ1 As Label
    Friend WithEvents lblIFilterSize3 As Label
    Friend WithEvents lblIFilterSize2 As Label
    Friend WithEvents lblIFilterSize1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lstPreFFSelected As ListBox
    Friend WithEvents lstPreIFSelected As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPreIAPD As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPreIDFA As TextBox
    Friend WithEvents lblPreIMaxAPD As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPreFDFA As TextBox
    Friend WithEvents lblPreFMaxAPD As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblPreFAPD As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents grpFFRack As GroupBox
    Friend WithEvents optFFRackHEPASS As RadioButton
    Friend WithEvents optFFRackHEPAGalv As RadioButton
    Friend WithEvents optFFRackSS As RadioButton
    Friend WithEvents optFFRackGalv As RadioButton
    Friend WithEvents grpIFRack As GroupBox
    Friend WithEvents optIFRackHEPASS As RadioButton
    Friend WithEvents optIFRackHEPAGalv As RadioButton
    Friend WithEvents optIFRackSS As RadioButton
    Friend WithEvents optIFRackGalv As RadioButton
    Friend WithEvents optFFRackNA As RadioButton
    Friend WithEvents optIFRackNA As RadioButton
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents chkWriteHistory As CheckBox
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents chkAddMERV132inToSeries20 As CheckBox
    Friend WithEvents cmdAddMF As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents lstPreMFSelected As ListBox
    Friend WithEvents lblMiscFilters As Label
    Friend WithEvents lstMFSelected As ListBox
    Friend WithEvents cmdSubMF As Button
    Friend WithEvents cmbActMF As ComboBox
    Friend WithEvents lstMFAvail As ListBox
    Friend WithEvents grpMiscPerf As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPreMDFA As TextBox
    Friend WithEvents lblPreMMaxAPD As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblPreMAPD As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblMFilterQ4 As Label
    Friend WithEvents lblMFilterSize4 As Label
    Friend WithEvents lblMStaticBudget As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtmDFA As TextBox
    Friend WithEvents lblMMaxAPD As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblMAPD As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents lblMFaceVelocity As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblMFaceArea As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents lblMFilterQ3 As Label
    Friend WithEvents lblMFilterQ2 As Label
    Friend WithEvents lblMFilterQ1 As Label
    Friend WithEvents lblMFilterSize3 As Label
    Friend WithEvents lblMFilterSize2 As Label
    Friend WithEvents lblMFilterSize1 As Label
    Friend WithEvents chkMFPrefilt As CheckBox
    Friend WithEvents chkAddMERV132inToSeries10 As CheckBox
End Class
