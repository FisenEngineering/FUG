﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPipePkg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPipePkg))
        Me.tbcPipePkg = New System.Windows.Forms.TabControl()
        Me.pgProposal = New System.Windows.Forms.TabPage()
        Me.grpPumpSystem = New System.Windows.Forms.GroupBox()
        Me.optPumpSystemParallel = New System.Windows.Forms.RadioButton()
        Me.optPumpSystemPriStby = New System.Windows.Forms.RadioButton()
        Me.optPumpSystemNA = New System.Windows.Forms.RadioButton()
        Me.grpPumpCtrl = New System.Windows.Forms.GroupBox()
        Me.chkPCtrlDisc = New System.Windows.Forms.CheckBox()
        Me.chkPCtrlBypass = New System.Windows.Forms.CheckBox()
        Me.cmbPCtrlSpecDrive = New System.Windows.Forms.ComboBox()
        Me.optPCtrlCVPumps = New System.Windows.Forms.RadioButton()
        Me.optPCtrlSpecificRemote = New System.Windows.Forms.RadioButton()
        Me.optPCtrlStdRemote = New System.Windows.Forms.RadioButton()
        Me.optPCtrlIVSRemote = New System.Windows.Forms.RadioButton()
        Me.optPCtrlIVSonPump = New System.Windows.Forms.RadioButton()
        Me.optPCtrlNA = New System.Windows.Forms.RadioButton()
        Me.cmbPotFeedStyle = New System.Windows.Forms.ComboBox()
        Me.cmbGMUStyle = New System.Windows.Forms.ComboBox()
        Me.cmbExpTankStyle = New System.Windows.Forms.ComboBox()
        Me.txtBTCapacity = New System.Windows.Forms.TextBox()
        Me.cmbBuffTankStyle = New System.Windows.Forms.ComboBox()
        Me.chk65kASCCRBase = New System.Windows.Forms.CheckBox()
        Me.grpPumpMotorStyle = New System.Windows.Forms.GroupBox()
        Me.optPumpMotorNA = New System.Windows.Forms.RadioButton()
        Me.optTEFCPumpMotor = New System.Windows.Forms.RadioButton()
        Me.optODPPumpMotor = New System.Windows.Forms.RadioButton()
        Me.nudPumpCount = New System.Windows.Forms.NumericUpDown()
        Me.cmbPumpStyle = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cmbPotFeedSpec = New System.Windows.Forms.ComboBox()
        Me.cmbInsSpec = New System.Windows.Forms.ComboBox()
        Me.cmbGMUSpec = New System.Windows.Forms.ComboBox()
        Me.cmbStrainSpec = New System.Windows.Forms.ComboBox()
        Me.cmbAirSepSpec = New System.Windows.Forms.ComboBox()
        Me.cmbExpTankSpec = New System.Windows.Forms.ComboBox()
        Me.cmbBuffTankSpec = New System.Windows.Forms.ComboBox()
        Me.cmbSucDiffSpec = New System.Windows.Forms.ComboBox()
        Me.cmbTDVSpec = New System.Windows.Forms.ComboBox()
        Me.cmbPumpSpec = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmbFluidHeat = New System.Windows.Forms.ComboBox()
        Me.cmbFluidPercentHeat = New System.Windows.Forms.ComboBox()
        Me.txtFlowHeat = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.grpPkgModel = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optPipeConsMulti = New System.Windows.Forms.RadioButton()
        Me.optPipeConsSingle = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optPipeBaseNPT = New System.Windows.Forms.RadioButton()
        Me.optPipeBaseWeld = New System.Windows.Forms.RadioButton()
        Me.optPipeBaseVic = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optExtDeetNA = New System.Windows.Forms.RadioButton()
        Me.optExtDeetFootprint = New System.Windows.Forms.RadioButton()
        Me.optExtDeetCommonBR = New System.Windows.Forms.RadioButton()
        Me.optExtDeetBaseRail = New System.Windows.Forms.RadioButton()
        Me.chkScopeEnclosure = New System.Windows.Forms.CheckBox()
        Me.chkPkgAHUCool = New System.Windows.Forms.CheckBox()
        Me.chkPkgAHUHeat = New System.Windows.Forms.CheckBox()
        Me.optPkgAHU = New System.Windows.Forms.RadioButton()
        Me.optPkgSkid = New System.Windows.Forms.RadioButton()
        Me.optPkgIntegral = New System.Windows.Forms.RadioButton()
        Me.chkScopePotFeed = New System.Windows.Forms.CheckBox()
        Me.btnDoneProposal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optCoilHeadSpec = New System.Windows.Forms.RadioButton()
        Me.txtTotalHead = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFisenHead = New System.Windows.Forms.TextBox()
        Me.txtChillerHead = New System.Windows.Forms.TextBox()
        Me.txtExternalHead = New System.Windows.Forms.TextBox()
        Me.optTotalHeadSpec = New System.Windows.Forms.RadioButton()
        Me.optStandardHeadSpec = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbFluid = New System.Windows.Forms.ComboBox()
        Me.cmbFluidPercent = New System.Windows.Forms.ComboBox()
        Me.txtFlow = New System.Windows.Forms.TextBox()
        Me.chkScopeSuctionDiff = New System.Windows.Forms.CheckBox()
        Me.chkScopeTDV = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkScopeStrainer = New System.Windows.Forms.CheckBox()
        Me.chkScopeInsulation = New System.Windows.Forms.CheckBox()
        Me.chkScopeGMU = New System.Windows.Forms.CheckBox()
        Me.chkScopeExpansionTank = New System.Windows.Forms.CheckBox()
        Me.chkScopeAirSeparator = New System.Windows.Forms.CheckBox()
        Me.chkScopePumps = New System.Windows.Forms.CheckBox()
        Me.chkScopeBufferTank = New System.Windows.Forms.CheckBox()
        Me.pgPumps = New System.Windows.Forms.TabPage()
        Me.grpPumpBypass = New System.Windows.Forms.GroupBox()
        Me.optPumpBypass3ContactorAuto = New System.Windows.Forms.RadioButton()
        Me.optPumpBypassNA = New System.Windows.Forms.RadioButton()
        Me.optPumpBypass2ContactorAuto = New System.Windows.Forms.RadioButton()
        Me.optPumpBypass2Contactor = New System.Windows.Forms.RadioButton()
        Me.grpPumpDisconnects = New System.Windows.Forms.GroupBox()
        Me.optPMDna = New System.Windows.Forms.RadioButton()
        Me.optPMDFusedDisc = New System.Windows.Forms.RadioButton()
        Me.optPMDIECDisc = New System.Windows.Forms.RadioButton()
        Me.optPMDSafeSwitch = New System.Windows.Forms.RadioButton()
        Me.txtPumpDryMass = New System.Windows.Forms.TextBox()
        Me.txtPumpWetMass = New System.Windows.Forms.TextBox()
        Me.txtImpellerDia = New System.Windows.Forms.TextBox()
        Me.txtPumpHP = New System.Windows.Forms.TextBox()
        Me.cmbPumpVolts = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmbPumpMotorSpeed = New System.Windows.Forms.ComboBox()
        Me.txtPumpMotorType = New System.Windows.Forms.TextBox()
        Me.txtPumpMotorFLA = New System.Windows.Forms.TextBox()
        Me.cmbPumpMotorHP = New System.Windows.Forms.ComboBox()
        Me.txtPRptCountAndStyle = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnDonePumps = New System.Windows.Forms.Button()
        Me.pgSpecOpt = New System.Windows.Forms.TabPage()
        Me.cmdDoneSpecOpt = New System.Windows.Forms.Button()
        Me.grpSucDiffOptions = New System.Windows.Forms.GroupBox()
        Me.chkSucDiffOptionsBlowDownValve = New System.Windows.Forms.CheckBox()
        Me.grpTDVOptions = New System.Windows.Forms.GroupBox()
        Me.optTDVOptionsStraight = New System.Windows.Forms.RadioButton()
        Me.optTDVOptionsAngle = New System.Windows.Forms.RadioButton()
        Me.optTDVOptionsNA = New System.Windows.Forms.RadioButton()
        Me.grpBufferTankOpts = New System.Windows.Forms.GroupBox()
        Me.chkBuffTankOptionsCstmNozzles = New System.Windows.Forms.CheckBox()
        Me.grpBTDrain = New System.Windows.Forms.GroupBox()
        Me.optBTDrainNA = New System.Windows.Forms.RadioButton()
        Me.optBTDrainNone = New System.Windows.Forms.RadioButton()
        Me.optBTDrainChainCap = New System.Windows.Forms.RadioButton()
        Me.optBTDrainValve = New System.Windows.Forms.RadioButton()
        Me.grpBTVenting = New System.Windows.Forms.GroupBox()
        Me.optBTVentNA = New System.Windows.Forms.RadioButton()
        Me.optBTVentNone = New System.Windows.Forms.RadioButton()
        Me.optBTVentAuto = New System.Windows.Forms.RadioButton()
        Me.optBTVentManual = New System.Windows.Forms.RadioButton()
        Me.grpHeatTrace = New System.Windows.Forms.GroupBox()
        Me.optBTHTNA = New System.Windows.Forms.RadioButton()
        Me.chkBTHTUnitPowered = New System.Windows.Forms.CheckBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtBTkWofHeat = New System.Windows.Forms.TextBox()
        Me.optBTHTNone = New System.Windows.Forms.RadioButton()
        Me.optBTHTHeatTrace = New System.Windows.Forms.RadioButton()
        Me.optBTHTImmersion = New System.Windows.Forms.RadioButton()
        Me.grpBTankInsulation = New System.Windows.Forms.GroupBox()
        Me.optBTInsNA = New System.Windows.Forms.RadioButton()
        Me.optBTUninsulated = New System.Windows.Forms.RadioButton()
        Me.optBTArmaflex = New System.Windows.Forms.RadioButton()
        Me.optBTSprayFoam = New System.Windows.Forms.RadioButton()
        Me.pgWSEcon = New System.Windows.Forms.TabPage()
        Me.pgHydronicDwg = New System.Windows.Forms.TabPage()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.txtAvailDescription = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstAvailHydroDrawing = New System.Windows.Forms.ListBox()
        Me.btnDoneHydronicDwg = New System.Windows.Forms.Button()
        Me.pgPipeandFittings = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblPipeSA = New System.Windows.Forms.Label()
        Me.lblPipeEL = New System.Windows.Forms.Label()
        Me.lblPipeVol = New System.Windows.Forms.Label()
        Me.lblPipeWeight = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.lblConRed2SA = New System.Windows.Forms.Label()
        Me.lblConRed2EL = New System.Windows.Forms.Label()
        Me.lblConRed2Vol = New System.Windows.Forms.Label()
        Me.lblConRed2Mass = New System.Windows.Forms.Label()
        Me.lblConRed1SA = New System.Windows.Forms.Label()
        Me.lblConRed1EL = New System.Windows.Forms.Label()
        Me.lblConRed1Vol = New System.Windows.Forms.Label()
        Me.lblConRed1Mass = New System.Windows.Forms.Label()
        Me.lblBTeeSA = New System.Windows.Forms.Label()
        Me.lblBTeeEL = New System.Windows.Forms.Label()
        Me.lblBTeeVol = New System.Windows.Forms.Label()
        Me.lblBTeeMass = New System.Windows.Forms.Label()
        Me.lblTeeSA = New System.Windows.Forms.Label()
        Me.lblTeeEL = New System.Windows.Forms.Label()
        Me.lblTeeVol = New System.Windows.Forms.Label()
        Me.lblTeeMass = New System.Windows.Forms.Label()
        Me.lbl90SA = New System.Windows.Forms.Label()
        Me.lbl90EL = New System.Windows.Forms.Label()
        Me.lbl90Vol = New System.Windows.Forms.Label()
        Me.lbl90Mass = New System.Windows.Forms.Label()
        Me.lbl45SA = New System.Windows.Forms.Label()
        Me.lbl45EL = New System.Windows.Forms.Label()
        Me.lbl45Vol = New System.Windows.Forms.Label()
        Me.lbl45Mass = New System.Windows.Forms.Label()
        Me.lbl225SA = New System.Windows.Forms.Label()
        Me.lbl225EL = New System.Windows.Forms.Label()
        Me.lbl225Vol = New System.Windows.Forms.Label()
        Me.lbl225Mass = New System.Windows.Forms.Label()
        Me.cmbFittingStyle = New System.Windows.Forms.ComboBox()
        Me.cmbPipeSchedule = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.nudConRed2 = New System.Windows.Forms.NumericUpDown()
        Me.nudConRed1 = New System.Windows.Forms.NumericUpDown()
        Me.nudBTee = New System.Windows.Forms.NumericUpDown()
        Me.nudTee = New System.Windows.Forms.NumericUpDown()
        Me.nud90 = New System.Windows.Forms.NumericUpDown()
        Me.nud45 = New System.Windows.Forms.NumericUpDown()
        Me.nud225 = New System.Windows.Forms.NumericUpDown()
        Me.txtPipeLength = New System.Windows.Forms.TextBox()
        Me.txtPDper100ft = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblzzz = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl225Weight = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbPipeSize = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDonePipe = New System.Windows.Forms.Button()
        Me.pgSpecialties = New System.Windows.Forms.TabPage()
        Me.chkOutletIso = New System.Windows.Forms.CheckBox()
        Me.chkInletIso = New System.Windows.Forms.CheckBox()
        Me.gridAvailItems = New System.Windows.Forms.DataGridView()
        Me.ItemSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manuf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InletSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutletSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DryWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FluidVol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtSpecTag = New System.Windows.Forms.TextBox()
        Me.btnDelSpecialtytoGrid = New System.Windows.Forms.Button()
        Me.lstAvailSpecialties = New System.Windows.Forms.ListBox()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.btnAddSpecialtytoGrid = New System.Windows.Forms.Button()
        Me.gridSepecialties = New System.Windows.Forms.DataGridView()
        Me.SpecTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PipeSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InletVTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutVTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecDryWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecFluidVol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecPDrop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDoneSpecialties = New System.Windows.Forms.Button()
        Me.pgValves = New System.Windows.Forms.TabPage()
        Me.btnAddValve = New System.Windows.Forms.Button()
        Me.gridValveSchedule = New System.Windows.Forms.DataGridView()
        Me.ValveTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveStyle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValveVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValvePD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pgCouplings = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblVicOutlet72_2 = New System.Windows.Forms.Label()
        Me.lblVicOutlet72_1 = New System.Windows.Forms.Label()
        Me.cmbVicOutlet02 = New System.Windows.Forms.ComboBox()
        Me.cmbVicOutlet01 = New System.Windows.Forms.ComboBox()
        Me.nudVicOutlet72_2 = New System.Windows.Forms.NumericUpDown()
        Me.nudVicOutlet72_1 = New System.Windows.Forms.NumericUpDown()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblVicReducing750_2 = New System.Windows.Forms.Label()
        Me.lblVicReducing750_1 = New System.Windows.Forms.Label()
        Me.lblVicFlange741 = New System.Windows.Forms.Label()
        Me.lblVicFlex177 = New System.Windows.Forms.Label()
        Me.lblVicRigid107H = New System.Windows.Forms.Label()
        Me.cmbVicReducing02 = New System.Windows.Forms.ComboBox()
        Me.cmbVicReducing01 = New System.Windows.Forms.ComboBox()
        Me.nudVicReducing750_2 = New System.Windows.Forms.NumericUpDown()
        Me.nudVicReducing750_1 = New System.Windows.Forms.NumericUpDown()
        Me.nudVicFlange741 = New System.Windows.Forms.NumericUpDown()
        Me.nudVicFlex177 = New System.Windows.Forms.NumericUpDown()
        Me.nudVicRigid107H = New System.Windows.Forms.NumericUpDown()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.lblVicFlange741ccc = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnDoneCouplings = New System.Windows.Forms.Button()
        Me.pgStructure = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnDoneStructure = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudAnchorHoles = New System.Windows.Forms.NumericUpDown()
        Me.chkAnchorHoles = New System.Windows.Forms.CheckBox()
        Me.nudFloorDrainCount = New System.Windows.Forms.NumericUpDown()
        Me.chkFloorDrains = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAluminumTread = New System.Windows.Forms.CheckBox()
        Me.cmbDecking = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBaseRail = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbHeight = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbWidth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSkidLength = New System.Windows.Forms.ComboBox()
        Me.chkEnclosure = New System.Windows.Forms.CheckBox()
        Me.lstPkgStructure = New System.Windows.Forms.ListBox()
        Me.pgElectrical = New System.Windows.Forms.TabPage()
        Me.pgMassAudit = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtWetWeight = New System.Windows.Forms.TextBox()
        Me.txtDryWeight = New System.Windows.Forms.TextBox()
        Me.txtFluidVolume = New System.Windows.Forms.TextBox()
        Me.txtPackagePD = New System.Windows.Forms.TextBox()
        Me.txtWeightPerGallon = New System.Windows.Forms.TextBox()
        Me.txtFluidSG = New System.Windows.Forms.TextBox()
        Me.cmdViewHistory = New System.Windows.Forms.Button()
        Me.cmdDesignCautions = New System.Windows.Forms.Button()
        Me.cmdFIOPPreview = New System.Windows.Forms.Button()
        Me.tbcPipePkg.SuspendLayout()
        Me.pgProposal.SuspendLayout()
        Me.grpPumpSystem.SuspendLayout()
        Me.grpPumpCtrl.SuspendLayout()
        Me.grpPumpMotorStyle.SuspendLayout()
        CType(Me.nudPumpCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPkgModel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pgPumps.SuspendLayout()
        Me.grpPumpBypass.SuspendLayout()
        Me.grpPumpDisconnects.SuspendLayout()
        Me.pgSpecOpt.SuspendLayout()
        Me.grpSucDiffOptions.SuspendLayout()
        Me.grpTDVOptions.SuspendLayout()
        Me.grpBufferTankOpts.SuspendLayout()
        Me.grpBTDrain.SuspendLayout()
        Me.grpBTVenting.SuspendLayout()
        Me.grpHeatTrace.SuspendLayout()
        Me.grpBTankInsulation.SuspendLayout()
        Me.pgHydronicDwg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgPipeandFittings.SuspendLayout()
        CType(Me.nudConRed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConRed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBTee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud225, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgSpecialties.SuspendLayout()
        CType(Me.gridAvailItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSepecialties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgValves.SuspendLayout()
        CType(Me.gridValveSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCouplings.SuspendLayout()
        CType(Me.nudVicOutlet72_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicOutlet72_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicReducing750_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicReducing750_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicFlange741, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicFlex177, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVicRigid107H, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgStructure.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudAnchorHoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFloorDrainCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcPipePkg
        '
        Me.tbcPipePkg.Controls.Add(Me.pgProposal)
        Me.tbcPipePkg.Controls.Add(Me.pgPumps)
        Me.tbcPipePkg.Controls.Add(Me.pgSpecOpt)
        Me.tbcPipePkg.Controls.Add(Me.pgWSEcon)
        Me.tbcPipePkg.Controls.Add(Me.pgHydronicDwg)
        Me.tbcPipePkg.Controls.Add(Me.pgPipeandFittings)
        Me.tbcPipePkg.Controls.Add(Me.pgSpecialties)
        Me.tbcPipePkg.Controls.Add(Me.pgValves)
        Me.tbcPipePkg.Controls.Add(Me.pgCouplings)
        Me.tbcPipePkg.Controls.Add(Me.pgStructure)
        Me.tbcPipePkg.Controls.Add(Me.pgElectrical)
        Me.tbcPipePkg.Controls.Add(Me.pgMassAudit)
        Me.tbcPipePkg.Location = New System.Drawing.Point(16, 15)
        Me.tbcPipePkg.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcPipePkg.Name = "tbcPipePkg"
        Me.tbcPipePkg.SelectedIndex = 0
        Me.tbcPipePkg.Size = New System.Drawing.Size(1169, 544)
        Me.tbcPipePkg.TabIndex = 0
        '
        'pgProposal
        '
        Me.pgProposal.Controls.Add(Me.grpPumpSystem)
        Me.pgProposal.Controls.Add(Me.grpPumpCtrl)
        Me.pgProposal.Controls.Add(Me.cmbPotFeedStyle)
        Me.pgProposal.Controls.Add(Me.cmbGMUStyle)
        Me.pgProposal.Controls.Add(Me.cmbExpTankStyle)
        Me.pgProposal.Controls.Add(Me.txtBTCapacity)
        Me.pgProposal.Controls.Add(Me.cmbBuffTankStyle)
        Me.pgProposal.Controls.Add(Me.chk65kASCCRBase)
        Me.pgProposal.Controls.Add(Me.grpPumpMotorStyle)
        Me.pgProposal.Controls.Add(Me.nudPumpCount)
        Me.pgProposal.Controls.Add(Me.cmbPumpStyle)
        Me.pgProposal.Controls.Add(Me.Label51)
        Me.pgProposal.Controls.Add(Me.cmbPotFeedSpec)
        Me.pgProposal.Controls.Add(Me.cmbInsSpec)
        Me.pgProposal.Controls.Add(Me.cmbGMUSpec)
        Me.pgProposal.Controls.Add(Me.cmbStrainSpec)
        Me.pgProposal.Controls.Add(Me.cmbAirSepSpec)
        Me.pgProposal.Controls.Add(Me.cmbExpTankSpec)
        Me.pgProposal.Controls.Add(Me.cmbBuffTankSpec)
        Me.pgProposal.Controls.Add(Me.cmbSucDiffSpec)
        Me.pgProposal.Controls.Add(Me.cmbTDVSpec)
        Me.pgProposal.Controls.Add(Me.cmbPumpSpec)
        Me.pgProposal.Controls.Add(Me.Label50)
        Me.pgProposal.Controls.Add(Me.Label49)
        Me.pgProposal.Controls.Add(Me.Label45)
        Me.pgProposal.Controls.Add(Me.Label46)
        Me.pgProposal.Controls.Add(Me.cmbFluidHeat)
        Me.pgProposal.Controls.Add(Me.cmbFluidPercentHeat)
        Me.pgProposal.Controls.Add(Me.txtFlowHeat)
        Me.pgProposal.Controls.Add(Me.Label47)
        Me.pgProposal.Controls.Add(Me.grpPkgModel)
        Me.pgProposal.Controls.Add(Me.chkScopePotFeed)
        Me.pgProposal.Controls.Add(Me.btnDoneProposal)
        Me.pgProposal.Controls.Add(Me.GroupBox3)
        Me.pgProposal.Controls.Add(Me.Label12)
        Me.pgProposal.Controls.Add(Me.Label11)
        Me.pgProposal.Controls.Add(Me.cmbFluid)
        Me.pgProposal.Controls.Add(Me.cmbFluidPercent)
        Me.pgProposal.Controls.Add(Me.txtFlow)
        Me.pgProposal.Controls.Add(Me.chkScopeSuctionDiff)
        Me.pgProposal.Controls.Add(Me.chkScopeTDV)
        Me.pgProposal.Controls.Add(Me.Label6)
        Me.pgProposal.Controls.Add(Me.chkScopeStrainer)
        Me.pgProposal.Controls.Add(Me.chkScopeInsulation)
        Me.pgProposal.Controls.Add(Me.chkScopeGMU)
        Me.pgProposal.Controls.Add(Me.chkScopeExpansionTank)
        Me.pgProposal.Controls.Add(Me.chkScopeAirSeparator)
        Me.pgProposal.Controls.Add(Me.chkScopePumps)
        Me.pgProposal.Controls.Add(Me.chkScopeBufferTank)
        Me.pgProposal.Location = New System.Drawing.Point(4, 22)
        Me.pgProposal.Name = "pgProposal"
        Me.pgProposal.Size = New System.Drawing.Size(1161, 518)
        Me.pgProposal.TabIndex = 3
        Me.pgProposal.Text = "Proposal"
        Me.pgProposal.UseVisualStyleBackColor = True
        '
        'grpPumpSystem
        '
        Me.grpPumpSystem.Controls.Add(Me.optPumpSystemParallel)
        Me.grpPumpSystem.Controls.Add(Me.optPumpSystemPriStby)
        Me.grpPumpSystem.Controls.Add(Me.optPumpSystemNA)
        Me.grpPumpSystem.Location = New System.Drawing.Point(458, 168)
        Me.grpPumpSystem.Name = "grpPumpSystem"
        Me.grpPumpSystem.Size = New System.Drawing.Size(319, 42)
        Me.grpPumpSystem.TabIndex = 89
        Me.grpPumpSystem.TabStop = False
        Me.grpPumpSystem.Text = "Pump System"
        Me.grpPumpSystem.Visible = False
        '
        'optPumpSystemParallel
        '
        Me.optPumpSystemParallel.AutoSize = True
        Me.optPumpSystemParallel.Location = New System.Drawing.Point(163, 19)
        Me.optPumpSystemParallel.Name = "optPumpSystemParallel"
        Me.optPumpSystemParallel.Size = New System.Drawing.Size(108, 17)
        Me.optPumpSystemParallel.TabIndex = 8
        Me.optPumpSystemParallel.Text = "Parallel Operation"
        Me.optPumpSystemParallel.UseVisualStyleBackColor = True
        '
        'optPumpSystemPriStby
        '
        Me.optPumpSystemPriStby.AutoSize = True
        Me.optPumpSystemPriStby.Location = New System.Drawing.Point(54, 19)
        Me.optPumpSystemPriStby.Name = "optPumpSystemPriStby"
        Me.optPumpSystemPriStby.Size = New System.Drawing.Size(103, 17)
        Me.optPumpSystemPriStby.TabIndex = 7
        Me.optPumpSystemPriStby.Text = "Primary/Standby"
        Me.optPumpSystemPriStby.UseVisualStyleBackColor = True
        '
        'optPumpSystemNA
        '
        Me.optPumpSystemNA.AutoSize = True
        Me.optPumpSystemNA.Checked = True
        Me.optPumpSystemNA.Location = New System.Drawing.Point(6, 19)
        Me.optPumpSystemNA.Name = "optPumpSystemNA"
        Me.optPumpSystemNA.Size = New System.Drawing.Size(42, 17)
        Me.optPumpSystemNA.TabIndex = 6
        Me.optPumpSystemNA.TabStop = True
        Me.optPumpSystemNA.Text = "n/a"
        Me.optPumpSystemNA.UseVisualStyleBackColor = True
        '
        'grpPumpCtrl
        '
        Me.grpPumpCtrl.Controls.Add(Me.chkPCtrlDisc)
        Me.grpPumpCtrl.Controls.Add(Me.chkPCtrlBypass)
        Me.grpPumpCtrl.Controls.Add(Me.cmbPCtrlSpecDrive)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlCVPumps)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlSpecificRemote)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlStdRemote)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlIVSRemote)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlIVSonPump)
        Me.grpPumpCtrl.Controls.Add(Me.optPCtrlNA)
        Me.grpPumpCtrl.Location = New System.Drawing.Point(458, 6)
        Me.grpPumpCtrl.Name = "grpPumpCtrl"
        Me.grpPumpCtrl.Size = New System.Drawing.Size(319, 156)
        Me.grpPumpCtrl.TabIndex = 88
        Me.grpPumpCtrl.TabStop = False
        Me.grpPumpCtrl.Text = "Pump Control"
        Me.grpPumpCtrl.Visible = False
        '
        'chkPCtrlDisc
        '
        Me.chkPCtrlDisc.AutoSize = True
        Me.chkPCtrlDisc.Enabled = False
        Me.chkPCtrlDisc.Location = New System.Drawing.Point(188, 42)
        Me.chkPCtrlDisc.Name = "chkPCtrlDisc"
        Me.chkPCtrlDisc.Size = New System.Drawing.Size(133, 17)
        Me.chkPCtrlDisc.TabIndex = 92
        Me.chkPCtrlDisc.Text = "Individual Disconnects"
        Me.chkPCtrlDisc.UseVisualStyleBackColor = True
        '
        'chkPCtrlBypass
        '
        Me.chkPCtrlBypass.AutoSize = True
        Me.chkPCtrlBypass.Enabled = False
        Me.chkPCtrlBypass.Location = New System.Drawing.Point(188, 66)
        Me.chkPCtrlBypass.Name = "chkPCtrlBypass"
        Me.chkPCtrlBypass.Size = New System.Drawing.Size(60, 17)
        Me.chkPCtrlBypass.TabIndex = 91
        Me.chkPCtrlBypass.Text = "Bypass"
        Me.chkPCtrlBypass.UseVisualStyleBackColor = True
        '
        'cmbPCtrlSpecDrive
        '
        Me.cmbPCtrlSpecDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPCtrlSpecDrive.Enabled = False
        Me.cmbPCtrlSpecDrive.FormattingEnabled = True
        Me.cmbPCtrlSpecDrive.Items.AddRange(New Object() {"Unselected", "Danfoss HVAC", "ABB ACH550", "Eaton HMax", "Not Required"})
        Me.cmbPCtrlSpecDrive.Location = New System.Drawing.Point(20, 106)
        Me.cmbPCtrlSpecDrive.Name = "cmbPCtrlSpecDrive"
        Me.cmbPCtrlSpecDrive.Size = New System.Drawing.Size(285, 21)
        Me.cmbPCtrlSpecDrive.TabIndex = 90
        '
        'optPCtrlCVPumps
        '
        Me.optPCtrlCVPumps.AutoSize = True
        Me.optPCtrlCVPumps.Location = New System.Drawing.Point(6, 133)
        Me.optPCtrlCVPumps.Name = "optPCtrlCVPumps"
        Me.optPCtrlCVPumps.Size = New System.Drawing.Size(110, 17)
        Me.optPCtrlCVPumps.TabIndex = 14
        Me.optPCtrlCVPumps.Text = "On/Off CV Pumps"
        Me.optPCtrlCVPumps.UseVisualStyleBackColor = True
        '
        'optPCtrlSpecificRemote
        '
        Me.optPCtrlSpecificRemote.AutoSize = True
        Me.optPCtrlSpecificRemote.Location = New System.Drawing.Point(6, 88)
        Me.optPCtrlSpecificRemote.Name = "optPCtrlSpecificRemote"
        Me.optPCtrlSpecificRemote.Size = New System.Drawing.Size(176, 17)
        Me.optPCtrlSpecificRemote.TabIndex = 13
        Me.optPCtrlSpecificRemote.Text = "Specific Drive Remote Mounted"
        Me.optPCtrlSpecificRemote.UseVisualStyleBackColor = True
        '
        'optPCtrlStdRemote
        '
        Me.optPCtrlStdRemote.AutoSize = True
        Me.optPCtrlStdRemote.Location = New System.Drawing.Point(6, 65)
        Me.optPCtrlStdRemote.Name = "optPCtrlStdRemote"
        Me.optPCtrlStdRemote.Size = New System.Drawing.Size(181, 17)
        Me.optPCtrlStdRemote.TabIndex = 12
        Me.optPCtrlStdRemote.Text = "Standard Drive Remote Mounted"
        Me.optPCtrlStdRemote.UseVisualStyleBackColor = True
        '
        'optPCtrlIVSRemote
        '
        Me.optPCtrlIVSRemote.AutoSize = True
        Me.optPCtrlIVSRemote.Location = New System.Drawing.Point(6, 42)
        Me.optPCtrlIVSRemote.Name = "optPCtrlIVSRemote"
        Me.optPCtrlIVSRemote.Size = New System.Drawing.Size(155, 17)
        Me.optPCtrlIVSRemote.TabIndex = 11
        Me.optPCtrlIVSRemote.Text = "IVS Drive Remote Mounted"
        Me.optPCtrlIVSRemote.UseVisualStyleBackColor = True
        '
        'optPCtrlIVSonPump
        '
        Me.optPCtrlIVSonPump.AutoSize = True
        Me.optPCtrlIVSonPump.Location = New System.Drawing.Point(6, 19)
        Me.optPCtrlIVSonPump.Name = "optPCtrlIVSonPump"
        Me.optPCtrlIVSonPump.Size = New System.Drawing.Size(145, 17)
        Me.optPCtrlIVSonPump.TabIndex = 10
        Me.optPCtrlIVSonPump.Text = "IVS Drive Pump Mounted"
        Me.optPCtrlIVSonPump.UseVisualStyleBackColor = True
        '
        'optPCtrlNA
        '
        Me.optPCtrlNA.AutoSize = True
        Me.optPCtrlNA.Checked = True
        Me.optPCtrlNA.Location = New System.Drawing.Point(188, 19)
        Me.optPCtrlNA.Name = "optPCtrlNA"
        Me.optPCtrlNA.Size = New System.Drawing.Size(42, 17)
        Me.optPCtrlNA.TabIndex = 9
        Me.optPCtrlNA.TabStop = True
        Me.optPCtrlNA.Text = "n/a"
        Me.optPCtrlNA.UseVisualStyleBackColor = True
        '
        'cmbPotFeedStyle
        '
        Me.cmbPotFeedStyle.AutoCompleteCustomSource.AddRange(New String() {"Use Standard", "Bladder Style", "Diaphram Style", "Not Required"})
        Me.cmbPotFeedStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPotFeedStyle.Enabled = False
        Me.cmbPotFeedStyle.FormattingEnabled = True
        Me.cmbPotFeedStyle.Items.AddRange(New Object() {"Not Required", "Bladder Tank", "Diaphram Tank", "Use Standard"})
        Me.cmbPotFeedStyle.Location = New System.Drawing.Point(412, 441)
        Me.cmbPotFeedStyle.Name = "cmbPotFeedStyle"
        Me.cmbPotFeedStyle.Size = New System.Drawing.Size(173, 21)
        Me.cmbPotFeedStyle.TabIndex = 87
        '
        'cmbGMUStyle
        '
        Me.cmbGMUStyle.AutoCompleteCustomSource.AddRange(New String() {"Use Standard", "Bladder Style", "Diaphram Style", "Not Required"})
        Me.cmbGMUStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGMUStyle.Enabled = False
        Me.cmbGMUStyle.FormattingEnabled = True
        Me.cmbGMUStyle.Items.AddRange(New Object() {"Not Required", "Bladder Tank", "Diaphram Tank", "Use Standard"})
        Me.cmbGMUStyle.Location = New System.Drawing.Point(412, 414)
        Me.cmbGMUStyle.Name = "cmbGMUStyle"
        Me.cmbGMUStyle.Size = New System.Drawing.Size(173, 21)
        Me.cmbGMUStyle.TabIndex = 86
        '
        'cmbExpTankStyle
        '
        Me.cmbExpTankStyle.AutoCompleteCustomSource.AddRange(New String() {"Use Standard", "Bladder Style", "Diaphram Style", "Not Required"})
        Me.cmbExpTankStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpTankStyle.Enabled = False
        Me.cmbExpTankStyle.FormattingEnabled = True
        Me.cmbExpTankStyle.Items.AddRange(New Object() {"Not Required", "Bladder Tank", "Diaphram Tank", "Use Standard"})
        Me.cmbExpTankStyle.Location = New System.Drawing.Point(412, 338)
        Me.cmbExpTankStyle.Name = "cmbExpTankStyle"
        Me.cmbExpTankStyle.Size = New System.Drawing.Size(173, 21)
        Me.cmbExpTankStyle.TabIndex = 85
        '
        'txtBTCapacity
        '
        Me.txtBTCapacity.Enabled = False
        Me.txtBTCapacity.Location = New System.Drawing.Point(597, 310)
        Me.txtBTCapacity.Name = "txtBTCapacity"
        Me.txtBTCapacity.ReadOnly = True
        Me.txtBTCapacity.Size = New System.Drawing.Size(112, 20)
        Me.txtBTCapacity.TabIndex = 84
        Me.txtBTCapacity.Text = "-"
        '
        'cmbBuffTankStyle
        '
        Me.cmbBuffTankStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuffTankStyle.Enabled = False
        Me.cmbBuffTankStyle.FormattingEnabled = True
        Me.cmbBuffTankStyle.Items.AddRange(New Object() {"Not Required"})
        Me.cmbBuffTankStyle.Location = New System.Drawing.Point(412, 310)
        Me.cmbBuffTankStyle.Name = "cmbBuffTankStyle"
        Me.cmbBuffTankStyle.Size = New System.Drawing.Size(173, 21)
        Me.cmbBuffTankStyle.TabIndex = 83
        '
        'chk65kASCCRBase
        '
        Me.chk65kASCCRBase.AutoSize = True
        Me.chk65kASCCRBase.Location = New System.Drawing.Point(836, 494)
        Me.chk65kASCCRBase.Margin = New System.Windows.Forms.Padding(4)
        Me.chk65kASCCRBase.Name = "chk65kASCCRBase"
        Me.chk65kASCCRBase.Size = New System.Drawing.Size(215, 17)
        Me.chk65kASCCRBase.TabIndex = 62
        Me.chk65kASCCRBase.Text = "Base\Fisen Modified Unit is 65kA SCCR"
        Me.chk65kASCCRBase.UseVisualStyleBackColor = True
        '
        'grpPumpMotorStyle
        '
        Me.grpPumpMotorStyle.Controls.Add(Me.optPumpMotorNA)
        Me.grpPumpMotorStyle.Controls.Add(Me.optTEFCPumpMotor)
        Me.grpPumpMotorStyle.Controls.Add(Me.optODPPumpMotor)
        Me.grpPumpMotorStyle.Enabled = False
        Me.grpPumpMotorStyle.Location = New System.Drawing.Point(597, 216)
        Me.grpPumpMotorStyle.Name = "grpPumpMotorStyle"
        Me.grpPumpMotorStyle.Size = New System.Drawing.Size(180, 46)
        Me.grpPumpMotorStyle.TabIndex = 82
        Me.grpPumpMotorStyle.TabStop = False
        Me.grpPumpMotorStyle.Text = "Motor Type"
        '
        'optPumpMotorNA
        '
        Me.optPumpMotorNA.AutoSize = True
        Me.optPumpMotorNA.Checked = True
        Me.optPumpMotorNA.Location = New System.Drawing.Point(121, 20)
        Me.optPumpMotorNA.Name = "optPumpMotorNA"
        Me.optPumpMotorNA.Size = New System.Drawing.Size(45, 17)
        Me.optPumpMotorNA.TabIndex = 85
        Me.optPumpMotorNA.TabStop = True
        Me.optPumpMotorNA.Text = "N/A"
        Me.optPumpMotorNA.UseVisualStyleBackColor = True
        '
        'optTEFCPumpMotor
        '
        Me.optTEFCPumpMotor.AutoSize = True
        Me.optTEFCPumpMotor.Location = New System.Drawing.Point(63, 20)
        Me.optTEFCPumpMotor.Name = "optTEFCPumpMotor"
        Me.optTEFCPumpMotor.Size = New System.Drawing.Size(52, 17)
        Me.optTEFCPumpMotor.TabIndex = 84
        Me.optTEFCPumpMotor.Text = "TEFC"
        Me.optTEFCPumpMotor.UseVisualStyleBackColor = True
        '
        'optODPPumpMotor
        '
        Me.optODPPumpMotor.AutoSize = True
        Me.optODPPumpMotor.Location = New System.Drawing.Point(6, 20)
        Me.optODPPumpMotor.Name = "optODPPumpMotor"
        Me.optODPPumpMotor.Size = New System.Drawing.Size(48, 17)
        Me.optODPPumpMotor.TabIndex = 83
        Me.optODPPumpMotor.Text = "ODP"
        Me.optODPPumpMotor.UseVisualStyleBackColor = True
        '
        'nudPumpCount
        '
        Me.nudPumpCount.Location = New System.Drawing.Point(360, 233)
        Me.nudPumpCount.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudPumpCount.Name = "nudPumpCount"
        Me.nudPumpCount.Size = New System.Drawing.Size(46, 20)
        Me.nudPumpCount.TabIndex = 81
        Me.nudPumpCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPumpStyle
        '
        Me.cmbPumpStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPumpStyle.Enabled = False
        Me.cmbPumpStyle.FormattingEnabled = True
        Me.cmbPumpStyle.Items.AddRange(New Object() {"Close Coupled Dual Arm", "Close Coupled Twin Pump", "Close Coupled Vertical Inline", "Split Coupled Twin Pump", "Split Coupled Dual Arm", "Split Coupled Vertical Inline", "Split Coupled End Suction"})
        Me.cmbPumpStyle.Location = New System.Drawing.Point(412, 232)
        Me.cmbPumpStyle.Name = "cmbPumpStyle"
        Me.cmbPumpStyle.Size = New System.Drawing.Size(173, 21)
        Me.cmbPumpStyle.TabIndex = 42
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(243, 216)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 13)
        Me.Label51.TabIndex = 41
        Me.Label51.Text = "Brand"
        Me.Label51.Visible = False
        '
        'cmbPotFeedSpec
        '
        Me.cmbPotFeedSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPotFeedSpec.Enabled = False
        Me.cmbPotFeedSpec.FormattingEnabled = True
        Me.cmbPotFeedSpec.Items.AddRange(New Object() {"Use Standard", "Not Required"})
        Me.cmbPotFeedSpec.Location = New System.Drawing.Point(164, 441)
        Me.cmbPotFeedSpec.Name = "cmbPotFeedSpec"
        Me.cmbPotFeedSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbPotFeedSpec.TabIndex = 40
        '
        'cmbInsSpec
        '
        Me.cmbInsSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInsSpec.Enabled = False
        Me.cmbInsSpec.FormattingEnabled = True
        Me.cmbInsSpec.Items.AddRange(New Object() {"Use Standard", "Elastomeric 3/4 inch", "Elastomeric 1-1/2 inch", "Fiberglass 2 inch", "Mineral Wool 2 inch", "Not Required"})
        Me.cmbInsSpec.Location = New System.Drawing.Point(164, 468)
        Me.cmbInsSpec.Name = "cmbInsSpec"
        Me.cmbInsSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbInsSpec.TabIndex = 39
        '
        'cmbGMUSpec
        '
        Me.cmbGMUSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGMUSpec.Enabled = False
        Me.cmbGMUSpec.FormattingEnabled = True
        Me.cmbGMUSpec.Items.AddRange(New Object() {"Use Standard", "GTP", "John Wood", "Not Required"})
        Me.cmbGMUSpec.Location = New System.Drawing.Point(164, 414)
        Me.cmbGMUSpec.Name = "cmbGMUSpec"
        Me.cmbGMUSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbGMUSpec.TabIndex = 38
        '
        'cmbStrainSpec
        '
        Me.cmbStrainSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStrainSpec.Enabled = False
        Me.cmbStrainSpec.FormattingEnabled = True
        Me.cmbStrainSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Not Required"})
        Me.cmbStrainSpec.Location = New System.Drawing.Point(164, 388)
        Me.cmbStrainSpec.Name = "cmbStrainSpec"
        Me.cmbStrainSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbStrainSpec.TabIndex = 37
        '
        'cmbAirSepSpec
        '
        Me.cmbAirSepSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAirSepSpec.Enabled = False
        Me.cmbAirSepSpec.FormattingEnabled = True
        Me.cmbAirSepSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Honeywell", "Not Required"})
        Me.cmbAirSepSpec.Location = New System.Drawing.Point(164, 362)
        Me.cmbAirSepSpec.Name = "cmbAirSepSpec"
        Me.cmbAirSepSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbAirSepSpec.TabIndex = 36
        '
        'cmbExpTankSpec
        '
        Me.cmbExpTankSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpTankSpec.Enabled = False
        Me.cmbExpTankSpec.FormattingEnabled = True
        Me.cmbExpTankSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Not Required"})
        Me.cmbExpTankSpec.Location = New System.Drawing.Point(164, 336)
        Me.cmbExpTankSpec.Name = "cmbExpTankSpec"
        Me.cmbExpTankSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbExpTankSpec.TabIndex = 35
        '
        'cmbBuffTankSpec
        '
        Me.cmbBuffTankSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuffTankSpec.Enabled = False
        Me.cmbBuffTankSpec.FormattingEnabled = True
        Me.cmbBuffTankSpec.Items.AddRange(New Object() {"Use Standard", "Niles Steel Tank", "Buckeye Fabrication", "Elbi", "Not Required"})
        Me.cmbBuffTankSpec.Location = New System.Drawing.Point(164, 310)
        Me.cmbBuffTankSpec.Name = "cmbBuffTankSpec"
        Me.cmbBuffTankSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbBuffTankSpec.TabIndex = 34
        '
        'cmbSucDiffSpec
        '
        Me.cmbSucDiffSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucDiffSpec.Enabled = False
        Me.cmbSucDiffSpec.FormattingEnabled = True
        Me.cmbSucDiffSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Not Required"})
        Me.cmbSucDiffSpec.Location = New System.Drawing.Point(164, 284)
        Me.cmbSucDiffSpec.Name = "cmbSucDiffSpec"
        Me.cmbSucDiffSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbSucDiffSpec.TabIndex = 33
        '
        'cmbTDVSpec
        '
        Me.cmbTDVSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTDVSpec.Enabled = False
        Me.cmbTDVSpec.FormattingEnabled = True
        Me.cmbTDVSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Not Required"})
        Me.cmbTDVSpec.Location = New System.Drawing.Point(164, 258)
        Me.cmbTDVSpec.Name = "cmbTDVSpec"
        Me.cmbTDVSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbTDVSpec.TabIndex = 32
        '
        'cmbPumpSpec
        '
        Me.cmbPumpSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPumpSpec.Enabled = False
        Me.cmbPumpSpec.FormattingEnabled = True
        Me.cmbPumpSpec.Items.AddRange(New Object() {"Use Standard", "Armstrong", "Bell and Gossett", "Taco", "Not Required"})
        Me.cmbPumpSpec.Location = New System.Drawing.Point(164, 232)
        Me.cmbPumpSpec.Name = "cmbPumpSpec"
        Me.cmbPumpSpec.Size = New System.Drawing.Size(190, 21)
        Me.cmbPumpSpec.TabIndex = 31
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(996, 372)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(44, 13)
        Me.Label50.TabIndex = 30
        Me.Label50.Text = "Heating"
        Me.Label50.Visible = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(804, 372)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(42, 13)
        Me.Label49.TabIndex = 29
        Me.Label49.Text = "Cooling"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(1078, 451)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(66, 13)
        Me.Label45.TabIndex = 28
        Me.Label45.Text = "% by Weight"
        Me.Label45.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(1078, 421)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(29, 13)
        Me.Label46.TabIndex = 27
        Me.Label46.Text = "Fluid"
        Me.Label46.Visible = False
        '
        'cmbFluidHeat
        '
        Me.cmbFluidHeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluidHeat.FormattingEnabled = True
        Me.cmbFluidHeat.Items.AddRange(New Object() {"Water", "Ethylene Glycol", "Propylene Glycol"})
        Me.cmbFluidHeat.Location = New System.Drawing.Point(960, 417)
        Me.cmbFluidHeat.Name = "cmbFluidHeat"
        Me.cmbFluidHeat.Size = New System.Drawing.Size(112, 21)
        Me.cmbFluidHeat.TabIndex = 26
        Me.cmbFluidHeat.Visible = False
        '
        'cmbFluidPercentHeat
        '
        Me.cmbFluidPercentHeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluidPercentHeat.FormattingEnabled = True
        Me.cmbFluidPercentHeat.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "-"})
        Me.cmbFluidPercentHeat.Location = New System.Drawing.Point(960, 447)
        Me.cmbFluidPercentHeat.Name = "cmbFluidPercentHeat"
        Me.cmbFluidPercentHeat.Size = New System.Drawing.Size(112, 21)
        Me.cmbFluidPercentHeat.TabIndex = 25
        Me.cmbFluidPercentHeat.Visible = False
        '
        'txtFlowHeat
        '
        Me.txtFlowHeat.Location = New System.Drawing.Point(960, 388)
        Me.txtFlowHeat.Name = "txtFlowHeat"
        Me.txtFlowHeat.Size = New System.Drawing.Size(112, 20)
        Me.txtFlowHeat.TabIndex = 24
        Me.txtFlowHeat.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(1078, 393)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(58, 13)
        Me.Label47.TabIndex = 23
        Me.Label47.Text = "Flow (gpm)"
        Me.Label47.Visible = False
        '
        'grpPkgModel
        '
        Me.grpPkgModel.Controls.Add(Me.GroupBox6)
        Me.grpPkgModel.Controls.Add(Me.GroupBox5)
        Me.grpPkgModel.Controls.Add(Me.GroupBox4)
        Me.grpPkgModel.Controls.Add(Me.chkScopeEnclosure)
        Me.grpPkgModel.Controls.Add(Me.chkPkgAHUCool)
        Me.grpPkgModel.Controls.Add(Me.chkPkgAHUHeat)
        Me.grpPkgModel.Controls.Add(Me.optPkgAHU)
        Me.grpPkgModel.Controls.Add(Me.optPkgSkid)
        Me.grpPkgModel.Controls.Add(Me.optPkgIntegral)
        Me.grpPkgModel.Location = New System.Drawing.Point(3, 3)
        Me.grpPkgModel.Name = "grpPkgModel"
        Me.grpPkgModel.Size = New System.Drawing.Size(450, 207)
        Me.grpPkgModel.TabIndex = 22
        Me.grpPkgModel.TabStop = False
        Me.grpPkgModel.Text = "Type of Package"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optPipeConsMulti)
        Me.GroupBox6.Controls.Add(Me.optPipeConsSingle)
        Me.GroupBox6.Location = New System.Drawing.Point(300, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(139, 89)
        Me.GroupBox6.TabIndex = 90
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Connection Basis"
        '
        'optPipeConsMulti
        '
        Me.optPipeConsMulti.AutoSize = True
        Me.optPipeConsMulti.Location = New System.Drawing.Point(6, 42)
        Me.optPipeConsMulti.Name = "optPipeConsMulti"
        Me.optPipeConsMulti.Size = New System.Drawing.Size(74, 17)
        Me.optPipeConsMulti.TabIndex = 7
        Me.optPipeConsMulti.Text = "Multi-Point"
        Me.optPipeConsMulti.UseVisualStyleBackColor = True
        '
        'optPipeConsSingle
        '
        Me.optPipeConsSingle.AutoSize = True
        Me.optPipeConsSingle.Checked = True
        Me.optPipeConsSingle.Location = New System.Drawing.Point(6, 19)
        Me.optPipeConsSingle.Name = "optPipeConsSingle"
        Me.optPipeConsSingle.Size = New System.Drawing.Size(81, 17)
        Me.optPipeConsSingle.TabIndex = 6
        Me.optPipeConsSingle.TabStop = True
        Me.optPipeConsSingle.Text = "Single Point"
        Me.optPipeConsSingle.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optPipeBaseNPT)
        Me.GroupBox5.Controls.Add(Me.optPipeBaseWeld)
        Me.GroupBox5.Controls.Add(Me.optPipeBaseVic)
        Me.GroupBox5.Location = New System.Drawing.Point(155, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 89)
        Me.GroupBox5.TabIndex = 89
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Piping Basis"
        '
        'optPipeBaseNPT
        '
        Me.optPipeBaseNPT.AutoSize = True
        Me.optPipeBaseNPT.Location = New System.Drawing.Point(6, 65)
        Me.optPipeBaseNPT.Name = "optPipeBaseNPT"
        Me.optPipeBaseNPT.Size = New System.Drawing.Size(133, 17)
        Me.optPipeBaseNPT.TabIndex = 8
        Me.optPipeBaseNPT.Text = "Threaded/Brased Only"
        Me.optPipeBaseNPT.UseVisualStyleBackColor = True
        '
        'optPipeBaseWeld
        '
        Me.optPipeBaseWeld.AutoSize = True
        Me.optPipeBaseWeld.Location = New System.Drawing.Point(6, 42)
        Me.optPipeBaseWeld.Name = "optPipeBaseWeld"
        Me.optPipeBaseWeld.Size = New System.Drawing.Size(103, 17)
        Me.optPipeBaseWeld.TabIndex = 7
        Me.optPipeBaseWeld.Text = "Welded Flanged"
        Me.optPipeBaseWeld.UseVisualStyleBackColor = True
        '
        'optPipeBaseVic
        '
        Me.optPipeBaseVic.AutoSize = True
        Me.optPipeBaseVic.Checked = True
        Me.optPipeBaseVic.Location = New System.Drawing.Point(6, 19)
        Me.optPipeBaseVic.Name = "optPipeBaseVic"
        Me.optPipeBaseVic.Size = New System.Drawing.Size(97, 17)
        Me.optPipeBaseVic.TabIndex = 6
        Me.optPipeBaseVic.TabStop = True
        Me.optPipeBaseVic.Text = "Victaulic Piping"
        Me.optPipeBaseVic.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optExtDeetNA)
        Me.GroupBox4.Controls.Add(Me.optExtDeetFootprint)
        Me.GroupBox4.Controls.Add(Me.optExtDeetCommonBR)
        Me.GroupBox4.Controls.Add(Me.optExtDeetBaseRail)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(143, 117)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extention Detail"
        '
        'optExtDeetNA
        '
        Me.optExtDeetNA.AutoSize = True
        Me.optExtDeetNA.Location = New System.Drawing.Point(7, 88)
        Me.optExtDeetNA.Name = "optExtDeetNA"
        Me.optExtDeetNA.Size = New System.Drawing.Size(42, 17)
        Me.optExtDeetNA.TabIndex = 6
        Me.optExtDeetNA.Text = "n/a"
        Me.optExtDeetNA.UseVisualStyleBackColor = True
        '
        'optExtDeetFootprint
        '
        Me.optExtDeetFootprint.AutoSize = True
        Me.optExtDeetFootprint.Location = New System.Drawing.Point(7, 65)
        Me.optExtDeetFootprint.Name = "optExtDeetFootprint"
        Me.optExtDeetFootprint.Size = New System.Drawing.Size(130, 17)
        Me.optExtDeetFootprint.TabIndex = 5
        Me.optExtDeetFootprint.Text = "Within Chiller Footprint"
        Me.optExtDeetFootprint.UseVisualStyleBackColor = True
        '
        'optExtDeetCommonBR
        '
        Me.optExtDeetCommonBR.AutoSize = True
        Me.optExtDeetCommonBR.Location = New System.Drawing.Point(7, 42)
        Me.optExtDeetCommonBR.Name = "optExtDeetCommonBR"
        Me.optExtDeetCommonBR.Size = New System.Drawing.Size(106, 17)
        Me.optExtDeetCommonBR.TabIndex = 4
        Me.optExtDeetCommonBR.Text = "Common Baserail"
        Me.optExtDeetCommonBR.UseVisualStyleBackColor = True
        '
        'optExtDeetBaseRail
        '
        Me.optExtDeetBaseRail.AutoSize = True
        Me.optExtDeetBaseRail.Checked = True
        Me.optExtDeetBaseRail.Location = New System.Drawing.Point(7, 19)
        Me.optExtDeetBaseRail.Name = "optExtDeetBaseRail"
        Me.optExtDeetBaseRail.Size = New System.Drawing.Size(110, 17)
        Me.optExtDeetBaseRail.TabIndex = 3
        Me.optExtDeetBaseRail.TabStop = True
        Me.optExtDeetBaseRail.Text = "Extended Baserail"
        Me.optExtDeetBaseRail.UseVisualStyleBackColor = True
        '
        'chkScopeEnclosure
        '
        Me.chkScopeEnclosure.AutoSize = True
        Me.chkScopeEnclosure.Location = New System.Drawing.Point(6, 165)
        Me.chkScopeEnclosure.Name = "chkScopeEnclosure"
        Me.chkScopeEnclosure.Size = New System.Drawing.Size(119, 17)
        Me.chkScopeEnclosure.TabIndex = 7
        Me.chkScopeEnclosure.Text = "Enclosure Required"
        Me.chkScopeEnclosure.UseVisualStyleBackColor = True
        '
        'chkPkgAHUCool
        '
        Me.chkPkgAHUCool.AutoSize = True
        Me.chkPkgAHUCool.Enabled = False
        Me.chkPkgAHUCool.Location = New System.Drawing.Point(288, 42)
        Me.chkPkgAHUCool.Name = "chkPkgAHUCool"
        Me.chkPkgAHUCool.Size = New System.Drawing.Size(61, 17)
        Me.chkPkgAHUCool.TabIndex = 6
        Me.chkPkgAHUCool.Text = "Cooling"
        Me.chkPkgAHUCool.UseVisualStyleBackColor = True
        '
        'chkPkgAHUHeat
        '
        Me.chkPkgAHUHeat.AutoSize = True
        Me.chkPkgAHUHeat.Enabled = False
        Me.chkPkgAHUHeat.Location = New System.Drawing.Point(219, 42)
        Me.chkPkgAHUHeat.Name = "chkPkgAHUHeat"
        Me.chkPkgAHUHeat.Size = New System.Drawing.Size(63, 17)
        Me.chkPkgAHUHeat.TabIndex = 5
        Me.chkPkgAHUHeat.Text = "Heating"
        Me.chkPkgAHUHeat.UseVisualStyleBackColor = True
        '
        'optPkgAHU
        '
        Me.optPkgAHU.AutoSize = True
        Me.optPkgAHU.Location = New System.Drawing.Point(212, 19)
        Me.optPkgAHU.Name = "optPkgAHU"
        Me.optPkgAHU.Size = New System.Drawing.Size(102, 17)
        Me.optPkgAHU.TabIndex = 4
        Me.optPkgAHU.Text = "Air Handler Coils"
        Me.optPkgAHU.UseVisualStyleBackColor = True
        '
        'optPkgSkid
        '
        Me.optPkgSkid.AutoSize = True
        Me.optPkgSkid.Location = New System.Drawing.Point(103, 19)
        Me.optPkgSkid.Name = "optPkgSkid"
        Me.optPkgSkid.Size = New System.Drawing.Size(103, 17)
        Me.optPkgSkid.TabIndex = 3
        Me.optPkgSkid.Text = "Standalone Skid"
        Me.optPkgSkid.UseVisualStyleBackColor = True
        '
        'optPkgIntegral
        '
        Me.optPkgIntegral.AutoSize = True
        Me.optPkgIntegral.Checked = True
        Me.optPkgIntegral.Location = New System.Drawing.Point(6, 19)
        Me.optPkgIntegral.Name = "optPkgIntegral"
        Me.optPkgIntegral.Size = New System.Drawing.Size(91, 17)
        Me.optPkgIntegral.TabIndex = 2
        Me.optPkgIntegral.TabStop = True
        Me.optPkgIntegral.Text = "Integral Chiller"
        Me.optPkgIntegral.UseVisualStyleBackColor = True
        '
        'chkScopePotFeed
        '
        Me.chkScopePotFeed.AutoSize = True
        Me.chkScopePotFeed.Location = New System.Drawing.Point(9, 443)
        Me.chkScopePotFeed.Name = "chkScopePotFeed"
        Me.chkScopePotFeed.Size = New System.Drawing.Size(124, 17)
        Me.chkScopePotFeed.TabIndex = 21
        Me.chkScopePotFeed.Text = "Chemical Pot Feeder"
        Me.chkScopePotFeed.UseVisualStyleBackColor = True
        '
        'btnDoneProposal
        '
        Me.btnDoneProposal.Location = New System.Drawing.Point(1061, 475)
        Me.btnDoneProposal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneProposal.Name = "btnDoneProposal"
        Me.btnDoneProposal.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneProposal.TabIndex = 20
        Me.btnDoneProposal.Text = ">"
        Me.btnDoneProposal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optCoilHeadSpec)
        Me.GroupBox3.Controls.Add(Me.txtTotalHead)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtFisenHead)
        Me.GroupBox3.Controls.Add(Me.txtChillerHead)
        Me.GroupBox3.Controls.Add(Me.txtExternalHead)
        Me.GroupBox3.Controls.Add(Me.optTotalHeadSpec)
        Me.GroupBox3.Controls.Add(Me.optStandardHeadSpec)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(783, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 231)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Static Resistance"
        '
        'optCoilHeadSpec
        '
        Me.optCoilHeadSpec.AutoSize = True
        Me.optCoilHeadSpec.Location = New System.Drawing.Point(16, 201)
        Me.optCoilHeadSpec.Name = "optCoilHeadSpec"
        Me.optCoilHeadSpec.Size = New System.Drawing.Size(88, 17)
        Me.optCoilHeadSpec.TabIndex = 19
        Me.optCoilHeadSpec.Text = "Coil Package"
        Me.optCoilHeadSpec.UseVisualStyleBackColor = True
        '
        'txtTotalHead
        '
        Me.txtTotalHead.Enabled = False
        Me.txtTotalHead.Location = New System.Drawing.Point(79, 159)
        Me.txtTotalHead.Name = "txtTotalHead"
        Me.txtTotalHead.Size = New System.Drawing.Size(112, 20)
        Me.txtTotalHead.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fisen Budget PD (ft.)"
        '
        'txtFisenHead
        '
        Me.txtFisenHead.Location = New System.Drawing.Point(79, 104)
        Me.txtFisenHead.Name = "txtFisenHead"
        Me.txtFisenHead.Size = New System.Drawing.Size(112, 20)
        Me.txtFisenHead.TabIndex = 16
        '
        'txtChillerHead
        '
        Me.txtChillerHead.Location = New System.Drawing.Point(79, 76)
        Me.txtChillerHead.Name = "txtChillerHead"
        Me.txtChillerHead.Size = New System.Drawing.Size(112, 20)
        Me.txtChillerHead.TabIndex = 15
        '
        'txtExternalHead
        '
        Me.txtExternalHead.Location = New System.Drawing.Point(79, 48)
        Me.txtExternalHead.Name = "txtExternalHead"
        Me.txtExternalHead.Size = New System.Drawing.Size(112, 20)
        Me.txtExternalHead.TabIndex = 14
        '
        'optTotalHeadSpec
        '
        Me.optTotalHeadSpec.AutoSize = True
        Me.optTotalHeadSpec.Location = New System.Drawing.Point(16, 132)
        Me.optTotalHeadSpec.Name = "optTotalHeadSpec"
        Me.optTotalHeadSpec.Size = New System.Drawing.Size(113, 17)
        Me.optTotalHeadSpec.TabIndex = 1
        Me.optTotalHeadSpec.Text = "Total Specification"
        Me.optTotalHeadSpec.UseVisualStyleBackColor = True
        '
        'optStandardHeadSpec
        '
        Me.optStandardHeadSpec.AutoSize = True
        Me.optStandardHeadSpec.Checked = True
        Me.optStandardHeadSpec.Location = New System.Drawing.Point(16, 21)
        Me.optStandardHeadSpec.Name = "optStandardHeadSpec"
        Me.optStandardHeadSpec.Size = New System.Drawing.Size(99, 17)
        Me.optStandardHeadSpec.TabIndex = 0
        Me.optStandardHeadSpec.TabStop = True
        Me.optStandardHeadSpec.Text = "Standard Sizing"
        Me.optStandardHeadSpec.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "External Head (ft.)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(197, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Displacement (ft.)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(197, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Chiller PD (ft.)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(890, 451)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "% by Weight"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(890, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fluid"
        '
        'cmbFluid
        '
        Me.cmbFluid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluid.FormattingEnabled = True
        Me.cmbFluid.Items.AddRange(New Object() {"Water", "Ethylene Glycol", "Propylene Glycol"})
        Me.cmbFluid.Location = New System.Drawing.Point(772, 417)
        Me.cmbFluid.Name = "cmbFluid"
        Me.cmbFluid.Size = New System.Drawing.Size(112, 21)
        Me.cmbFluid.TabIndex = 16
        '
        'cmbFluidPercent
        '
        Me.cmbFluidPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFluidPercent.FormattingEnabled = True
        Me.cmbFluidPercent.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "-"})
        Me.cmbFluidPercent.Location = New System.Drawing.Point(772, 447)
        Me.cmbFluidPercent.Name = "cmbFluidPercent"
        Me.cmbFluidPercent.Size = New System.Drawing.Size(112, 21)
        Me.cmbFluidPercent.TabIndex = 15
        '
        'txtFlow
        '
        Me.txtFlow.Location = New System.Drawing.Point(772, 388)
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.Size = New System.Drawing.Size(112, 20)
        Me.txtFlow.TabIndex = 13
        '
        'chkScopeSuctionDiff
        '
        Me.chkScopeSuctionDiff.AutoSize = True
        Me.chkScopeSuctionDiff.Location = New System.Drawing.Point(9, 286)
        Me.chkScopeSuctionDiff.Name = "chkScopeSuctionDiff"
        Me.chkScopeSuctionDiff.Size = New System.Drawing.Size(98, 17)
        Me.chkScopeSuctionDiff.TabIndex = 12
        Me.chkScopeSuctionDiff.Text = "Suction Difuser"
        Me.chkScopeSuctionDiff.UseVisualStyleBackColor = True
        '
        'chkScopeTDV
        '
        Me.chkScopeTDV.AutoSize = True
        Me.chkScopeTDV.Location = New System.Drawing.Point(9, 260)
        Me.chkScopeTDV.Name = "chkScopeTDV"
        Me.chkScopeTDV.Size = New System.Drawing.Size(107, 17)
        Me.chkScopeTDV.TabIndex = 11
        Me.chkScopeTDV.Text = "Triple Duty Valve"
        Me.chkScopeTDV.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(890, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Flow (gpm)"
        '
        'chkScopeStrainer
        '
        Me.chkScopeStrainer.AutoSize = True
        Me.chkScopeStrainer.Location = New System.Drawing.Point(9, 390)
        Me.chkScopeStrainer.Name = "chkScopeStrainer"
        Me.chkScopeStrainer.Size = New System.Drawing.Size(62, 17)
        Me.chkScopeStrainer.TabIndex = 6
        Me.chkScopeStrainer.Text = "Strainer"
        Me.chkScopeStrainer.UseVisualStyleBackColor = True
        '
        'chkScopeInsulation
        '
        Me.chkScopeInsulation.AutoSize = True
        Me.chkScopeInsulation.Location = New System.Drawing.Point(9, 470)
        Me.chkScopeInsulation.Name = "chkScopeInsulation"
        Me.chkScopeInsulation.Size = New System.Drawing.Size(71, 17)
        Me.chkScopeInsulation.TabIndex = 5
        Me.chkScopeInsulation.Text = "Insulation"
        Me.chkScopeInsulation.UseVisualStyleBackColor = True
        '
        'chkScopeGMU
        '
        Me.chkScopeGMU.AutoSize = True
        Me.chkScopeGMU.Location = New System.Drawing.Point(9, 416)
        Me.chkScopeGMU.Name = "chkScopeGMU"
        Me.chkScopeGMU.Size = New System.Drawing.Size(51, 17)
        Me.chkScopeGMU.TabIndex = 4
        Me.chkScopeGMU.Text = "GMU"
        Me.chkScopeGMU.UseVisualStyleBackColor = True
        '
        'chkScopeExpansionTank
        '
        Me.chkScopeExpansionTank.AutoSize = True
        Me.chkScopeExpansionTank.Location = New System.Drawing.Point(9, 338)
        Me.chkScopeExpansionTank.Name = "chkScopeExpansionTank"
        Me.chkScopeExpansionTank.Size = New System.Drawing.Size(103, 17)
        Me.chkScopeExpansionTank.TabIndex = 3
        Me.chkScopeExpansionTank.Text = "Expansion Tank"
        Me.chkScopeExpansionTank.UseVisualStyleBackColor = True
        '
        'chkScopeAirSeparator
        '
        Me.chkScopeAirSeparator.AutoSize = True
        Me.chkScopeAirSeparator.Location = New System.Drawing.Point(9, 364)
        Me.chkScopeAirSeparator.Name = "chkScopeAirSeparator"
        Me.chkScopeAirSeparator.Size = New System.Drawing.Size(87, 17)
        Me.chkScopeAirSeparator.TabIndex = 2
        Me.chkScopeAirSeparator.Text = "Air Separator"
        Me.chkScopeAirSeparator.UseVisualStyleBackColor = True
        '
        'chkScopePumps
        '
        Me.chkScopePumps.AutoSize = True
        Me.chkScopePumps.Location = New System.Drawing.Point(9, 234)
        Me.chkScopePumps.Name = "chkScopePumps"
        Me.chkScopePumps.Size = New System.Drawing.Size(64, 17)
        Me.chkScopePumps.TabIndex = 1
        Me.chkScopePumps.Text = "Pump(s)"
        Me.chkScopePumps.UseVisualStyleBackColor = True
        '
        'chkScopeBufferTank
        '
        Me.chkScopeBufferTank.AutoSize = True
        Me.chkScopeBufferTank.Location = New System.Drawing.Point(9, 312)
        Me.chkScopeBufferTank.Name = "chkScopeBufferTank"
        Me.chkScopeBufferTank.Size = New System.Drawing.Size(82, 17)
        Me.chkScopeBufferTank.TabIndex = 0
        Me.chkScopeBufferTank.Text = "Buffer Tank"
        Me.chkScopeBufferTank.UseVisualStyleBackColor = True
        '
        'pgPumps
        '
        Me.pgPumps.Controls.Add(Me.grpPumpBypass)
        Me.pgPumps.Controls.Add(Me.grpPumpDisconnects)
        Me.pgPumps.Controls.Add(Me.txtPumpDryMass)
        Me.pgPumps.Controls.Add(Me.txtPumpWetMass)
        Me.pgPumps.Controls.Add(Me.txtImpellerDia)
        Me.pgPumps.Controls.Add(Me.txtPumpHP)
        Me.pgPumps.Controls.Add(Me.cmbPumpVolts)
        Me.pgPumps.Controls.Add(Me.Label54)
        Me.pgPumps.Controls.Add(Me.cmbPumpMotorSpeed)
        Me.pgPumps.Controls.Add(Me.txtPumpMotorType)
        Me.pgPumps.Controls.Add(Me.txtPumpMotorFLA)
        Me.pgPumps.Controls.Add(Me.cmbPumpMotorHP)
        Me.pgPumps.Controls.Add(Me.txtPRptCountAndStyle)
        Me.pgPumps.Controls.Add(Me.Label35)
        Me.pgPumps.Controls.Add(Me.Label36)
        Me.pgPumps.Controls.Add(Me.Label34)
        Me.pgPumps.Controls.Add(Me.Label33)
        Me.pgPumps.Controls.Add(Me.Label32)
        Me.pgPumps.Controls.Add(Me.Label31)
        Me.pgPumps.Controls.Add(Me.Label30)
        Me.pgPumps.Controls.Add(Me.Label29)
        Me.pgPumps.Controls.Add(Me.Label28)
        Me.pgPumps.Controls.Add(Me.btnDonePumps)
        Me.pgPumps.Location = New System.Drawing.Point(4, 22)
        Me.pgPumps.Margin = New System.Windows.Forms.Padding(4)
        Me.pgPumps.Name = "pgPumps"
        Me.pgPumps.Padding = New System.Windows.Forms.Padding(4)
        Me.pgPumps.Size = New System.Drawing.Size(1161, 518)
        Me.pgPumps.TabIndex = 1
        Me.pgPumps.Text = "Pumps"
        Me.pgPumps.UseVisualStyleBackColor = True
        '
        'grpPumpBypass
        '
        Me.grpPumpBypass.Controls.Add(Me.optPumpBypass3ContactorAuto)
        Me.grpPumpBypass.Controls.Add(Me.optPumpBypassNA)
        Me.grpPumpBypass.Controls.Add(Me.optPumpBypass2ContactorAuto)
        Me.grpPumpBypass.Controls.Add(Me.optPumpBypass2Contactor)
        Me.grpPumpBypass.Location = New System.Drawing.Point(226, 167)
        Me.grpPumpBypass.Name = "grpPumpBypass"
        Me.grpPumpBypass.Size = New System.Drawing.Size(212, 89)
        Me.grpPumpBypass.TabIndex = 108
        Me.grpPumpBypass.TabStop = False
        Me.grpPumpBypass.Text = "Pump Drive Bypass"
        '
        'optPumpBypass3ContactorAuto
        '
        Me.optPumpBypass3ContactorAuto.AutoSize = True
        Me.optPumpBypass3ContactorAuto.Location = New System.Drawing.Point(6, 65)
        Me.optPumpBypass3ContactorAuto.Name = "optPumpBypass3ContactorAuto"
        Me.optPumpBypass3ContactorAuto.Size = New System.Drawing.Size(130, 17)
        Me.optPumpBypass3ContactorAuto.TabIndex = 114
        Me.optPumpBypass3ContactorAuto.Text = "3 Contactor Automatic"
        Me.optPumpBypass3ContactorAuto.UseVisualStyleBackColor = True
        '
        'optPumpBypassNA
        '
        Me.optPumpBypassNA.AutoSize = True
        Me.optPumpBypassNA.Checked = True
        Me.optPumpBypassNA.Location = New System.Drawing.Point(161, 19)
        Me.optPumpBypassNA.Name = "optPumpBypassNA"
        Me.optPumpBypassNA.Size = New System.Drawing.Size(42, 17)
        Me.optPumpBypassNA.TabIndex = 112
        Me.optPumpBypassNA.TabStop = True
        Me.optPumpBypassNA.Text = "n/a"
        Me.optPumpBypassNA.UseVisualStyleBackColor = True
        '
        'optPumpBypass2ContactorAuto
        '
        Me.optPumpBypass2ContactorAuto.AutoSize = True
        Me.optPumpBypass2ContactorAuto.Location = New System.Drawing.Point(6, 42)
        Me.optPumpBypass2ContactorAuto.Name = "optPumpBypass2ContactorAuto"
        Me.optPumpBypass2ContactorAuto.Size = New System.Drawing.Size(130, 17)
        Me.optPumpBypass2ContactorAuto.TabIndex = 113
        Me.optPumpBypass2ContactorAuto.Text = "2 Contactor Automatic"
        Me.optPumpBypass2ContactorAuto.UseVisualStyleBackColor = True
        '
        'optPumpBypass2Contactor
        '
        Me.optPumpBypass2Contactor.AutoSize = True
        Me.optPumpBypass2Contactor.Location = New System.Drawing.Point(6, 19)
        Me.optPumpBypass2Contactor.Name = "optPumpBypass2Contactor"
        Me.optPumpBypass2Contactor.Size = New System.Drawing.Size(132, 17)
        Me.optPumpBypass2Contactor.TabIndex = 112
        Me.optPumpBypass2Contactor.Text = "Manual Bypass Switch"
        Me.optPumpBypass2Contactor.UseVisualStyleBackColor = True
        '
        'grpPumpDisconnects
        '
        Me.grpPumpDisconnects.Controls.Add(Me.optPMDna)
        Me.grpPumpDisconnects.Controls.Add(Me.optPMDFusedDisc)
        Me.grpPumpDisconnects.Controls.Add(Me.optPMDIECDisc)
        Me.grpPumpDisconnects.Controls.Add(Me.optPMDSafeSwitch)
        Me.grpPumpDisconnects.Enabled = False
        Me.grpPumpDisconnects.Location = New System.Drawing.Point(10, 167)
        Me.grpPumpDisconnects.Name = "grpPumpDisconnects"
        Me.grpPumpDisconnects.Size = New System.Drawing.Size(210, 89)
        Me.grpPumpDisconnects.TabIndex = 107
        Me.grpPumpDisconnects.TabStop = False
        Me.grpPumpDisconnects.Text = "Pump Motor Disconnects"
        '
        'optPMDna
        '
        Me.optPMDna.AutoSize = True
        Me.optPMDna.Checked = True
        Me.optPMDna.Location = New System.Drawing.Point(161, 19)
        Me.optPMDna.Name = "optPMDna"
        Me.optPMDna.Size = New System.Drawing.Size(42, 17)
        Me.optPMDna.TabIndex = 111
        Me.optPMDna.TabStop = True
        Me.optPMDna.Text = "n/a"
        Me.optPMDna.UseVisualStyleBackColor = True
        '
        'optPMDFusedDisc
        '
        Me.optPMDFusedDisc.AutoSize = True
        Me.optPMDFusedDisc.Location = New System.Drawing.Point(6, 65)
        Me.optPMDFusedDisc.Name = "optPMDFusedDisc"
        Me.optPMDFusedDisc.Size = New System.Drawing.Size(122, 17)
        Me.optPMDFusedDisc.TabIndex = 110
        Me.optPMDFusedDisc.Text = "Fused Disconnect(s)"
        Me.optPMDFusedDisc.UseVisualStyleBackColor = True
        '
        'optPMDIECDisc
        '
        Me.optPMDIECDisc.AutoSize = True
        Me.optPMDIECDisc.Location = New System.Drawing.Point(6, 42)
        Me.optPMDIECDisc.Name = "optPMDIECDisc"
        Me.optPMDIECDisc.Size = New System.Drawing.Size(140, 17)
        Me.optPMDIECDisc.TabIndex = 109
        Me.optPMDIECDisc.Text = "IEC Motor Disconnect(s)"
        Me.optPMDIECDisc.UseVisualStyleBackColor = True
        '
        'optPMDSafeSwitch
        '
        Me.optPMDSafeSwitch.AutoSize = True
        Me.optPMDSafeSwitch.Location = New System.Drawing.Point(6, 19)
        Me.optPMDSafeSwitch.Name = "optPMDSafeSwitch"
        Me.optPMDSafeSwitch.Size = New System.Drawing.Size(149, 17)
        Me.optPMDSafeSwitch.TabIndex = 108
        Me.optPMDSafeSwitch.Text = "Individual Safety Switches"
        Me.optPMDSafeSwitch.UseVisualStyleBackColor = True
        '
        'txtPumpDryMass
        '
        Me.txtPumpDryMass.Location = New System.Drawing.Point(107, 141)
        Me.txtPumpDryMass.Name = "txtPumpDryMass"
        Me.txtPumpDryMass.ReadOnly = True
        Me.txtPumpDryMass.Size = New System.Drawing.Size(113, 20)
        Me.txtPumpDryMass.TabIndex = 106
        Me.txtPumpDryMass.Text = "0"
        '
        'txtPumpWetMass
        '
        Me.txtPumpWetMass.Location = New System.Drawing.Point(10, 141)
        Me.txtPumpWetMass.Name = "txtPumpWetMass"
        Me.txtPumpWetMass.ReadOnly = True
        Me.txtPumpWetMass.Size = New System.Drawing.Size(91, 20)
        Me.txtPumpWetMass.TabIndex = 105
        Me.txtPumpWetMass.Text = "0"
        '
        'txtImpellerDia
        '
        Me.txtImpellerDia.Location = New System.Drawing.Point(107, 102)
        Me.txtImpellerDia.Name = "txtImpellerDia"
        Me.txtImpellerDia.ReadOnly = True
        Me.txtImpellerDia.Size = New System.Drawing.Size(113, 20)
        Me.txtImpellerDia.TabIndex = 104
        Me.txtImpellerDia.Text = "n/a"
        '
        'txtPumpHP
        '
        Me.txtPumpHP.Location = New System.Drawing.Point(10, 102)
        Me.txtPumpHP.Name = "txtPumpHP"
        Me.txtPumpHP.ReadOnly = True
        Me.txtPumpHP.Size = New System.Drawing.Size(91, 20)
        Me.txtPumpHP.TabIndex = 103
        Me.txtPumpHP.Text = "n/a"
        '
        'cmbPumpVolts
        '
        Me.cmbPumpVolts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPumpVolts.Enabled = False
        Me.cmbPumpVolts.FormattingEnabled = True
        Me.cmbPumpVolts.Items.AddRange(New Object() {"Unselected", "200-3", "208-3", "230-3", "460-3", "575-3", "Not Required"})
        Me.cmbPumpVolts.Location = New System.Drawing.Point(10, 62)
        Me.cmbPumpVolts.Name = "cmbPumpVolts"
        Me.cmbPumpVolts.Size = New System.Drawing.Size(91, 21)
        Me.cmbPumpVolts.TabIndex = 102
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(7, 45)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(73, 13)
        Me.Label54.TabIndex = 101
        Me.Label54.Text = "Pump Voltage"
        '
        'cmbPumpMotorSpeed
        '
        Me.cmbPumpMotorSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPumpMotorSpeed.FormattingEnabled = True
        Me.cmbPumpMotorSpeed.Items.AddRange(New Object() {"Unselected", "1800", "3600", "Not Required"})
        Me.cmbPumpMotorSpeed.Location = New System.Drawing.Point(402, 62)
        Me.cmbPumpMotorSpeed.Name = "cmbPumpMotorSpeed"
        Me.cmbPumpMotorSpeed.Size = New System.Drawing.Size(177, 21)
        Me.cmbPumpMotorSpeed.TabIndex = 100
        '
        'txtPumpMotorType
        '
        Me.txtPumpMotorType.Location = New System.Drawing.Point(226, 63)
        Me.txtPumpMotorType.Name = "txtPumpMotorType"
        Me.txtPumpMotorType.ReadOnly = True
        Me.txtPumpMotorType.Size = New System.Drawing.Size(170, 20)
        Me.txtPumpMotorType.TabIndex = 99
        '
        'txtPumpMotorFLA
        '
        Me.txtPumpMotorFLA.Location = New System.Drawing.Point(585, 63)
        Me.txtPumpMotorFLA.Name = "txtPumpMotorFLA"
        Me.txtPumpMotorFLA.ReadOnly = True
        Me.txtPumpMotorFLA.Size = New System.Drawing.Size(72, 20)
        Me.txtPumpMotorFLA.TabIndex = 98
        '
        'cmbPumpMotorHP
        '
        Me.cmbPumpMotorHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPumpMotorHP.Enabled = False
        Me.cmbPumpMotorHP.FormattingEnabled = True
        Me.cmbPumpMotorHP.Items.AddRange(New Object() {"0.5", "1", "1.5", "2", "3", "5", "7.5", "10", "15", "20", "25", "30", "40", "50", "Unselected", "Not Required"})
        Me.cmbPumpMotorHP.Location = New System.Drawing.Point(107, 62)
        Me.cmbPumpMotorHP.Name = "cmbPumpMotorHP"
        Me.cmbPumpMotorHP.Size = New System.Drawing.Size(113, 21)
        Me.cmbPumpMotorHP.TabIndex = 97
        '
        'txtPRptCountAndStyle
        '
        Me.txtPRptCountAndStyle.Location = New System.Drawing.Point(10, 20)
        Me.txtPRptCountAndStyle.Name = "txtPRptCountAndStyle"
        Me.txtPRptCountAndStyle.ReadOnly = True
        Me.txtPRptCountAndStyle.Size = New System.Drawing.Size(647, 20)
        Me.txtPRptCountAndStyle.TabIndex = 32
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(107, 125)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 13)
        Me.Label35.TabIndex = 31
        Me.Label35.Text = "Dry Weight"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 125)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 13)
        Me.Label36.TabIndex = 30
        Me.Label36.Text = "Wet Weight"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(586, 44)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(71, 13)
        Me.Label34.TabIndex = 29
        Me.Label34.Text = "Motor Current"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(107, 86)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 13)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Impeller Diameter"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(399, 45)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 13)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Motor Speed"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(226, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 13)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Motor Type"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 86)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(94, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Pump Horsepower"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(107, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Motor Horsepower"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Pump Count and Style"
        '
        'btnDonePumps
        '
        Me.btnDonePumps.Location = New System.Drawing.Point(1057, 471)
        Me.btnDonePumps.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePumps.Name = "btnDonePumps"
        Me.btnDonePumps.Size = New System.Drawing.Size(96, 36)
        Me.btnDonePumps.TabIndex = 21
        Me.btnDonePumps.Text = ">"
        Me.btnDonePumps.UseVisualStyleBackColor = True
        '
        'pgSpecOpt
        '
        Me.pgSpecOpt.Controls.Add(Me.cmdDoneSpecOpt)
        Me.pgSpecOpt.Controls.Add(Me.grpSucDiffOptions)
        Me.pgSpecOpt.Controls.Add(Me.grpTDVOptions)
        Me.pgSpecOpt.Controls.Add(Me.grpBufferTankOpts)
        Me.pgSpecOpt.Location = New System.Drawing.Point(4, 22)
        Me.pgSpecOpt.Name = "pgSpecOpt"
        Me.pgSpecOpt.Size = New System.Drawing.Size(1161, 518)
        Me.pgSpecOpt.TabIndex = 8
        Me.pgSpecOpt.Text = "Specialty Options"
        Me.pgSpecOpt.UseVisualStyleBackColor = True
        '
        'cmdDoneSpecOpt
        '
        Me.cmdDoneSpecOpt.Location = New System.Drawing.Point(1061, 475)
        Me.cmdDoneSpecOpt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneSpecOpt.Name = "cmdDoneSpecOpt"
        Me.cmdDoneSpecOpt.Size = New System.Drawing.Size(96, 36)
        Me.cmdDoneSpecOpt.TabIndex = 22
        Me.cmdDoneSpecOpt.Text = ">"
        Me.cmdDoneSpecOpt.UseVisualStyleBackColor = True
        '
        'grpSucDiffOptions
        '
        Me.grpSucDiffOptions.Controls.Add(Me.chkSucDiffOptionsBlowDownValve)
        Me.grpSucDiffOptions.Location = New System.Drawing.Point(14, 98)
        Me.grpSucDiffOptions.Name = "grpSucDiffOptions"
        Me.grpSucDiffOptions.Size = New System.Drawing.Size(208, 96)
        Me.grpSucDiffOptions.TabIndex = 2
        Me.grpSucDiffOptions.TabStop = False
        Me.grpSucDiffOptions.Text = "Suction Diffusers"
        '
        'chkSucDiffOptionsBlowDownValve
        '
        Me.chkSucDiffOptionsBlowDownValve.AutoSize = True
        Me.chkSucDiffOptionsBlowDownValve.Location = New System.Drawing.Point(6, 19)
        Me.chkSucDiffOptionsBlowDownValve.Name = "chkSucDiffOptionsBlowDownValve"
        Me.chkSucDiffOptionsBlowDownValve.Size = New System.Drawing.Size(199, 17)
        Me.chkSucDiffOptionsBlowDownValve.TabIndex = 6
        Me.chkSucDiffOptionsBlowDownValve.Text = "Blow Down Valve /w Cap and Chain"
        Me.chkSucDiffOptionsBlowDownValve.UseVisualStyleBackColor = True
        '
        'grpTDVOptions
        '
        Me.grpTDVOptions.Controls.Add(Me.optTDVOptionsStraight)
        Me.grpTDVOptions.Controls.Add(Me.optTDVOptionsAngle)
        Me.grpTDVOptions.Controls.Add(Me.optTDVOptionsNA)
        Me.grpTDVOptions.Location = New System.Drawing.Point(14, 4)
        Me.grpTDVOptions.Name = "grpTDVOptions"
        Me.grpTDVOptions.Size = New System.Drawing.Size(208, 88)
        Me.grpTDVOptions.TabIndex = 1
        Me.grpTDVOptions.TabStop = False
        Me.grpTDVOptions.Text = "Triple Duty Valve(s)"
        '
        'optTDVOptionsStraight
        '
        Me.optTDVOptionsStraight.AutoSize = True
        Me.optTDVOptionsStraight.Enabled = False
        Me.optTDVOptionsStraight.Location = New System.Drawing.Point(6, 65)
        Me.optTDVOptionsStraight.Name = "optTDVOptionsStraight"
        Me.optTDVOptionsStraight.Size = New System.Drawing.Size(64, 17)
        Me.optTDVOptionsStraight.TabIndex = 5
        Me.optTDVOptionsStraight.Text = "Straight "
        Me.optTDVOptionsStraight.UseVisualStyleBackColor = True
        '
        'optTDVOptionsAngle
        '
        Me.optTDVOptionsAngle.AutoSize = True
        Me.optTDVOptionsAngle.Enabled = False
        Me.optTDVOptionsAngle.Location = New System.Drawing.Point(6, 42)
        Me.optTDVOptionsAngle.Name = "optTDVOptionsAngle"
        Me.optTDVOptionsAngle.Size = New System.Drawing.Size(52, 17)
        Me.optTDVOptionsAngle.TabIndex = 4
        Me.optTDVOptionsAngle.Text = "Angle"
        Me.optTDVOptionsAngle.UseVisualStyleBackColor = True
        '
        'optTDVOptionsNA
        '
        Me.optTDVOptionsNA.AutoSize = True
        Me.optTDVOptionsNA.Checked = True
        Me.optTDVOptionsNA.Location = New System.Drawing.Point(6, 19)
        Me.optTDVOptionsNA.Name = "optTDVOptionsNA"
        Me.optTDVOptionsNA.Size = New System.Drawing.Size(88, 17)
        Me.optTDVOptionsNA.TabIndex = 3
        Me.optTDVOptionsNA.TabStop = True
        Me.optTDVOptionsNA.Text = "Not Required"
        Me.optTDVOptionsNA.UseVisualStyleBackColor = True
        '
        'grpBufferTankOpts
        '
        Me.grpBufferTankOpts.Controls.Add(Me.chkBuffTankOptionsCstmNozzles)
        Me.grpBufferTankOpts.Controls.Add(Me.grpBTDrain)
        Me.grpBufferTankOpts.Controls.Add(Me.grpBTVenting)
        Me.grpBufferTankOpts.Controls.Add(Me.grpHeatTrace)
        Me.grpBufferTankOpts.Controls.Add(Me.grpBTankInsulation)
        Me.grpBufferTankOpts.Location = New System.Drawing.Point(228, 4)
        Me.grpBufferTankOpts.Name = "grpBufferTankOpts"
        Me.grpBufferTankOpts.Size = New System.Drawing.Size(248, 430)
        Me.grpBufferTankOpts.TabIndex = 0
        Me.grpBufferTankOpts.TabStop = False
        Me.grpBufferTankOpts.Text = "Buffer Tanks"
        '
        'chkBuffTankOptionsCstmNozzles
        '
        Me.chkBuffTankOptionsCstmNozzles.AutoSize = True
        Me.chkBuffTankOptionsCstmNozzles.Location = New System.Drawing.Point(12, 20)
        Me.chkBuffTankOptionsCstmNozzles.Name = "chkBuffTankOptionsCstmNozzles"
        Me.chkBuffTankOptionsCstmNozzles.Size = New System.Drawing.Size(175, 17)
        Me.chkBuffTankOptionsCstmNozzles.TabIndex = 12
        Me.chkBuffTankOptionsCstmNozzles.Text = "Custom Nozzle Locations/Sizes"
        Me.chkBuffTankOptionsCstmNozzles.UseVisualStyleBackColor = True
        '
        'grpBTDrain
        '
        Me.grpBTDrain.Controls.Add(Me.optBTDrainNA)
        Me.grpBTDrain.Controls.Add(Me.optBTDrainNone)
        Me.grpBTDrain.Controls.Add(Me.optBTDrainChainCap)
        Me.grpBTDrain.Controls.Add(Me.optBTDrainValve)
        Me.grpBTDrain.Location = New System.Drawing.Point(6, 358)
        Me.grpBTDrain.Name = "grpBTDrain"
        Me.grpBTDrain.Size = New System.Drawing.Size(233, 66)
        Me.grpBTDrain.TabIndex = 11
        Me.grpBTDrain.TabStop = False
        Me.grpBTDrain.Text = "Drain"
        '
        'optBTDrainNA
        '
        Me.optBTDrainNA.AutoSize = True
        Me.optBTDrainNA.Checked = True
        Me.optBTDrainNA.Location = New System.Drawing.Point(8, 43)
        Me.optBTDrainNA.Name = "optBTDrainNA"
        Me.optBTDrainNA.Size = New System.Drawing.Size(42, 17)
        Me.optBTDrainNA.TabIndex = 8
        Me.optBTDrainNA.TabStop = True
        Me.optBTDrainNA.Text = "n/a"
        Me.optBTDrainNA.UseVisualStyleBackColor = True
        '
        'optBTDrainNone
        '
        Me.optBTDrainNone.AutoSize = True
        Me.optBTDrainNone.Location = New System.Drawing.Point(8, 19)
        Me.optBTDrainNone.Name = "optBTDrainNone"
        Me.optBTDrainNone.Size = New System.Drawing.Size(77, 17)
        Me.optBTDrainNone.TabIndex = 2
        Me.optBTDrainNone.Text = "None/Plug"
        Me.optBTDrainNone.UseVisualStyleBackColor = True
        '
        'optBTDrainChainCap
        '
        Me.optBTDrainChainCap.AutoSize = True
        Me.optBTDrainChainCap.Location = New System.Drawing.Point(93, 42)
        Me.optBTDrainChainCap.Name = "optBTDrainChainCap"
        Me.optBTDrainChainCap.Size = New System.Drawing.Size(137, 17)
        Me.optBTDrainChainCap.TabIndex = 1
        Me.optBTDrainChainCap.Text = "Valve and Chained Cap"
        Me.optBTDrainChainCap.UseVisualStyleBackColor = True
        '
        'optBTDrainValve
        '
        Me.optBTDrainValve.AutoSize = True
        Me.optBTDrainValve.Location = New System.Drawing.Point(93, 19)
        Me.optBTDrainValve.Name = "optBTDrainValve"
        Me.optBTDrainValve.Size = New System.Drawing.Size(121, 17)
        Me.optBTDrainValve.TabIndex = 0
        Me.optBTDrainValve.Text = "Valve and Cap/Plug"
        Me.optBTDrainValve.UseVisualStyleBackColor = True
        '
        'grpBTVenting
        '
        Me.grpBTVenting.Controls.Add(Me.optBTVentNA)
        Me.grpBTVenting.Controls.Add(Me.optBTVentNone)
        Me.grpBTVenting.Controls.Add(Me.optBTVentAuto)
        Me.grpBTVenting.Controls.Add(Me.optBTVentManual)
        Me.grpBTVenting.Location = New System.Drawing.Point(6, 286)
        Me.grpBTVenting.Name = "grpBTVenting"
        Me.grpBTVenting.Size = New System.Drawing.Size(233, 66)
        Me.grpBTVenting.TabIndex = 10
        Me.grpBTVenting.TabStop = False
        Me.grpBTVenting.Text = "Venting"
        '
        'optBTVentNA
        '
        Me.optBTVentNA.AutoSize = True
        Me.optBTVentNA.Checked = True
        Me.optBTVentNA.Location = New System.Drawing.Point(8, 42)
        Me.optBTVentNA.Name = "optBTVentNA"
        Me.optBTVentNA.Size = New System.Drawing.Size(42, 17)
        Me.optBTVentNA.TabIndex = 7
        Me.optBTVentNA.TabStop = True
        Me.optBTVentNA.Text = "n/a"
        Me.optBTVentNA.UseVisualStyleBackColor = True
        '
        'optBTVentNone
        '
        Me.optBTVentNone.AutoSize = True
        Me.optBTVentNone.Location = New System.Drawing.Point(8, 19)
        Me.optBTVentNone.Name = "optBTVentNone"
        Me.optBTVentNone.Size = New System.Drawing.Size(77, 17)
        Me.optBTVentNone.TabIndex = 2
        Me.optBTVentNone.Text = "None/Plug"
        Me.optBTVentNone.UseVisualStyleBackColor = True
        '
        'optBTVentAuto
        '
        Me.optBTVentAuto.AutoSize = True
        Me.optBTVentAuto.Location = New System.Drawing.Point(93, 42)
        Me.optBTVentAuto.Name = "optBTVentAuto"
        Me.optBTVentAuto.Size = New System.Drawing.Size(72, 17)
        Me.optBTVentAuto.TabIndex = 1
        Me.optBTVentAuto.Text = "Auto Vent"
        Me.optBTVentAuto.UseVisualStyleBackColor = True
        '
        'optBTVentManual
        '
        Me.optBTVentManual.AutoSize = True
        Me.optBTVentManual.Location = New System.Drawing.Point(93, 19)
        Me.optBTVentManual.Name = "optBTVentManual"
        Me.optBTVentManual.Size = New System.Drawing.Size(85, 17)
        Me.optBTVentManual.TabIndex = 0
        Me.optBTVentManual.Text = "Manual Vent"
        Me.optBTVentManual.UseVisualStyleBackColor = True
        '
        'grpHeatTrace
        '
        Me.grpHeatTrace.Controls.Add(Me.optBTHTNA)
        Me.grpHeatTrace.Controls.Add(Me.chkBTHTUnitPowered)
        Me.grpHeatTrace.Controls.Add(Me.Label43)
        Me.grpHeatTrace.Controls.Add(Me.txtBTkWofHeat)
        Me.grpHeatTrace.Controls.Add(Me.optBTHTNone)
        Me.grpHeatTrace.Controls.Add(Me.optBTHTHeatTrace)
        Me.grpHeatTrace.Controls.Add(Me.optBTHTImmersion)
        Me.grpHeatTrace.Location = New System.Drawing.Point(6, 168)
        Me.grpHeatTrace.Name = "grpHeatTrace"
        Me.grpHeatTrace.Size = New System.Drawing.Size(233, 112)
        Me.grpHeatTrace.TabIndex = 9
        Me.grpHeatTrace.TabStop = False
        Me.grpHeatTrace.Text = "Aux. Heat"
        '
        'optBTHTNA
        '
        Me.optBTHTNA.AutoSize = True
        Me.optBTHTNA.Checked = True
        Me.optBTHTNA.Location = New System.Drawing.Point(96, 19)
        Me.optBTHTNA.Name = "optBTHTNA"
        Me.optBTHTNA.Size = New System.Drawing.Size(42, 17)
        Me.optBTHTNA.TabIndex = 6
        Me.optBTHTNA.TabStop = True
        Me.optBTHTNA.Text = "n/a"
        Me.optBTHTNA.UseVisualStyleBackColor = True
        '
        'chkBTHTUnitPowered
        '
        Me.chkBTHTUnitPowered.AutoSize = True
        Me.chkBTHTUnitPowered.Location = New System.Drawing.Point(6, 91)
        Me.chkBTHTUnitPowered.Name = "chkBTHTUnitPowered"
        Me.chkBTHTUnitPowered.Size = New System.Drawing.Size(90, 17)
        Me.chkBTHTUnitPowered.TabIndex = 5
        Me.chkBTHTUnitPowered.Text = "Unit Powered"
        Me.chkBTHTUnitPowered.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(72, 68)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "kW of Electric Heat"
        '
        'txtBTkWofHeat
        '
        Me.txtBTkWofHeat.Location = New System.Drawing.Point(6, 65)
        Me.txtBTkWofHeat.Name = "txtBTkWofHeat"
        Me.txtBTkWofHeat.Size = New System.Drawing.Size(60, 20)
        Me.txtBTkWofHeat.TabIndex = 3
        '
        'optBTHTNone
        '
        Me.optBTHTNone.AutoSize = True
        Me.optBTHTNone.Location = New System.Drawing.Point(8, 19)
        Me.optBTHTNone.Name = "optBTHTNone"
        Me.optBTHTNone.Size = New System.Drawing.Size(51, 17)
        Me.optBTHTNone.TabIndex = 2
        Me.optBTHTNone.Text = "None"
        Me.optBTHTNone.UseVisualStyleBackColor = True
        '
        'optBTHTHeatTrace
        '
        Me.optBTHTHeatTrace.AutoSize = True
        Me.optBTHTHeatTrace.Location = New System.Drawing.Point(8, 42)
        Me.optBTHTHeatTrace.Name = "optBTHTHeatTrace"
        Me.optBTHTHeatTrace.Size = New System.Drawing.Size(79, 17)
        Me.optBTHTHeatTrace.TabIndex = 1
        Me.optBTHTHeatTrace.Text = "Heat Trace"
        Me.optBTHTHeatTrace.UseVisualStyleBackColor = True
        '
        'optBTHTImmersion
        '
        Me.optBTHTImmersion.AutoSize = True
        Me.optBTHTImmersion.Location = New System.Drawing.Point(96, 42)
        Me.optBTHTImmersion.Name = "optBTHTImmersion"
        Me.optBTHTImmersion.Size = New System.Drawing.Size(110, 17)
        Me.optBTHTImmersion.TabIndex = 0
        Me.optBTHTImmersion.Text = "Immersion Heater "
        Me.optBTHTImmersion.UseVisualStyleBackColor = True
        '
        'grpBTankInsulation
        '
        Me.grpBTankInsulation.Controls.Add(Me.optBTInsNA)
        Me.grpBTankInsulation.Controls.Add(Me.optBTUninsulated)
        Me.grpBTankInsulation.Controls.Add(Me.optBTArmaflex)
        Me.grpBTankInsulation.Controls.Add(Me.optBTSprayFoam)
        Me.grpBTankInsulation.Location = New System.Drawing.Point(6, 96)
        Me.grpBTankInsulation.Name = "grpBTankInsulation"
        Me.grpBTankInsulation.Size = New System.Drawing.Size(233, 66)
        Me.grpBTankInsulation.TabIndex = 8
        Me.grpBTankInsulation.TabStop = False
        Me.grpBTankInsulation.Text = "Insulation"
        '
        'optBTInsNA
        '
        Me.optBTInsNA.AutoSize = True
        Me.optBTInsNA.Checked = True
        Me.optBTInsNA.Location = New System.Drawing.Point(6, 43)
        Me.optBTInsNA.Name = "optBTInsNA"
        Me.optBTInsNA.Size = New System.Drawing.Size(42, 17)
        Me.optBTInsNA.TabIndex = 3
        Me.optBTInsNA.TabStop = True
        Me.optBTInsNA.Text = "n/a"
        Me.optBTInsNA.UseVisualStyleBackColor = True
        '
        'optBTUninsulated
        '
        Me.optBTUninsulated.AutoSize = True
        Me.optBTUninsulated.Location = New System.Drawing.Point(6, 19)
        Me.optBTUninsulated.Name = "optBTUninsulated"
        Me.optBTUninsulated.Size = New System.Drawing.Size(81, 17)
        Me.optBTUninsulated.TabIndex = 2
        Me.optBTUninsulated.Text = "Uninsulated"
        Me.optBTUninsulated.UseVisualStyleBackColor = True
        '
        'optBTArmaflex
        '
        Me.optBTArmaflex.AutoSize = True
        Me.optBTArmaflex.Location = New System.Drawing.Point(93, 42)
        Me.optBTArmaflex.Name = "optBTArmaflex"
        Me.optBTArmaflex.Size = New System.Drawing.Size(113, 17)
        Me.optBTArmaflex.TabIndex = 1
        Me.optBTArmaflex.Text = "Armaflex Insulation"
        Me.optBTArmaflex.UseVisualStyleBackColor = True
        '
        'optBTSprayFoam
        '
        Me.optBTSprayFoam.AutoSize = True
        Me.optBTSprayFoam.Location = New System.Drawing.Point(93, 19)
        Me.optBTSprayFoam.Name = "optBTSprayFoam"
        Me.optBTSprayFoam.Size = New System.Drawing.Size(129, 17)
        Me.optBTSprayFoam.TabIndex = 0
        Me.optBTSprayFoam.Text = "Spray Foam Insulation"
        Me.optBTSprayFoam.UseVisualStyleBackColor = True
        '
        'pgWSEcon
        '
        Me.pgWSEcon.Location = New System.Drawing.Point(4, 22)
        Me.pgWSEcon.Name = "pgWSEcon"
        Me.pgWSEcon.Padding = New System.Windows.Forms.Padding(3)
        Me.pgWSEcon.Size = New System.Drawing.Size(1161, 518)
        Me.pgWSEcon.TabIndex = 10
        Me.pgWSEcon.Text = "WS Econ"
        Me.pgWSEcon.UseVisualStyleBackColor = True
        '
        'pgHydronicDwg
        '
        Me.pgHydronicDwg.Controls.Add(Me.RadioButton4)
        Me.pgHydronicDwg.Controls.Add(Me.txtAvailDescription)
        Me.pgHydronicDwg.Controls.Add(Me.Button4)
        Me.pgHydronicDwg.Controls.Add(Me.RadioButton3)
        Me.pgHydronicDwg.Controls.Add(Me.RadioButton2)
        Me.pgHydronicDwg.Controls.Add(Me.RadioButton1)
        Me.pgHydronicDwg.Controls.Add(Me.PictureBox1)
        Me.pgHydronicDwg.Controls.Add(Me.lstAvailHydroDrawing)
        Me.pgHydronicDwg.Controls.Add(Me.btnDoneHydronicDwg)
        Me.pgHydronicDwg.Location = New System.Drawing.Point(4, 22)
        Me.pgHydronicDwg.Name = "pgHydronicDwg"
        Me.pgHydronicDwg.Size = New System.Drawing.Size(1161, 518)
        Me.pgHydronicDwg.TabIndex = 7
        Me.pgHydronicDwg.Text = "Hydronic Drawing"
        Me.pgHydronicDwg.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(917, 109)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton4.TabIndex = 30
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Insert Only"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'txtAvailDescription
        '
        Me.txtAvailDescription.Location = New System.Drawing.Point(23, 307)
        Me.txtAvailDescription.Multiline = True
        Me.txtAvailDescription.Name = "txtAvailDescription"
        Me.txtAvailDescription.Size = New System.Drawing.Size(391, 190)
        Me.txtAvailDescription.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(908, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 30)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Load BOM from Template"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(917, 82)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton3.TabIndex = 27
        Me.RadioButton3.Text = "Copy and Insert"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(917, 28)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.Text = "Copy Now"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(917, 55)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.Text = "Flag for Copy"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(438, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lstAvailHydroDrawing
        '
        Me.lstAvailHydroDrawing.FormattingEnabled = True
        Me.lstAvailHydroDrawing.Location = New System.Drawing.Point(23, 29)
        Me.lstAvailHydroDrawing.Name = "lstAvailHydroDrawing"
        Me.lstAvailHydroDrawing.Size = New System.Drawing.Size(391, 251)
        Me.lstAvailHydroDrawing.TabIndex = 22
        '
        'btnDoneHydronicDwg
        '
        Me.btnDoneHydronicDwg.Location = New System.Drawing.Point(1061, 475)
        Me.btnDoneHydronicDwg.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneHydronicDwg.Name = "btnDoneHydronicDwg"
        Me.btnDoneHydronicDwg.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneHydronicDwg.TabIndex = 21
        Me.btnDoneHydronicDwg.Text = ">"
        Me.btnDoneHydronicDwg.UseVisualStyleBackColor = True
        '
        'pgPipeandFittings
        '
        Me.pgPipeandFittings.Controls.Add(Me.TextBox2)
        Me.pgPipeandFittings.Controls.Add(Me.lblPipeSA)
        Me.pgPipeandFittings.Controls.Add(Me.lblPipeEL)
        Me.pgPipeandFittings.Controls.Add(Me.lblPipeVol)
        Me.pgPipeandFittings.Controls.Add(Me.lblPipeWeight)
        Me.pgPipeandFittings.Controls.Add(Me.Label44)
        Me.pgPipeandFittings.Controls.Add(Me.Label48)
        Me.pgPipeandFittings.Controls.Add(Me.Label52)
        Me.pgPipeandFittings.Controls.Add(Me.Label56)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed2SA)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed2EL)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed2Vol)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed2Mass)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed1SA)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed1EL)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed1Vol)
        Me.pgPipeandFittings.Controls.Add(Me.lblConRed1Mass)
        Me.pgPipeandFittings.Controls.Add(Me.lblBTeeSA)
        Me.pgPipeandFittings.Controls.Add(Me.lblBTeeEL)
        Me.pgPipeandFittings.Controls.Add(Me.lblBTeeVol)
        Me.pgPipeandFittings.Controls.Add(Me.lblBTeeMass)
        Me.pgPipeandFittings.Controls.Add(Me.lblTeeSA)
        Me.pgPipeandFittings.Controls.Add(Me.lblTeeEL)
        Me.pgPipeandFittings.Controls.Add(Me.lblTeeVol)
        Me.pgPipeandFittings.Controls.Add(Me.lblTeeMass)
        Me.pgPipeandFittings.Controls.Add(Me.lbl90SA)
        Me.pgPipeandFittings.Controls.Add(Me.lbl90EL)
        Me.pgPipeandFittings.Controls.Add(Me.lbl90Vol)
        Me.pgPipeandFittings.Controls.Add(Me.lbl90Mass)
        Me.pgPipeandFittings.Controls.Add(Me.lbl45SA)
        Me.pgPipeandFittings.Controls.Add(Me.lbl45EL)
        Me.pgPipeandFittings.Controls.Add(Me.lbl45Vol)
        Me.pgPipeandFittings.Controls.Add(Me.lbl45Mass)
        Me.pgPipeandFittings.Controls.Add(Me.lbl225SA)
        Me.pgPipeandFittings.Controls.Add(Me.lbl225EL)
        Me.pgPipeandFittings.Controls.Add(Me.lbl225Vol)
        Me.pgPipeandFittings.Controls.Add(Me.lbl225Mass)
        Me.pgPipeandFittings.Controls.Add(Me.cmbFittingStyle)
        Me.pgPipeandFittings.Controls.Add(Me.cmbPipeSchedule)
        Me.pgPipeandFittings.Controls.Add(Me.Label24)
        Me.pgPipeandFittings.Controls.Add(Me.Label23)
        Me.pgPipeandFittings.Controls.Add(Me.ComboBox5)
        Me.pgPipeandFittings.Controls.Add(Me.ComboBox4)
        Me.pgPipeandFittings.Controls.Add(Me.nudConRed2)
        Me.pgPipeandFittings.Controls.Add(Me.nudConRed1)
        Me.pgPipeandFittings.Controls.Add(Me.nudBTee)
        Me.pgPipeandFittings.Controls.Add(Me.nudTee)
        Me.pgPipeandFittings.Controls.Add(Me.nud90)
        Me.pgPipeandFittings.Controls.Add(Me.nud45)
        Me.pgPipeandFittings.Controls.Add(Me.nud225)
        Me.pgPipeandFittings.Controls.Add(Me.txtPipeLength)
        Me.pgPipeandFittings.Controls.Add(Me.txtPDper100ft)
        Me.pgPipeandFittings.Controls.Add(Me.Label22)
        Me.pgPipeandFittings.Controls.Add(Me.Label21)
        Me.pgPipeandFittings.Controls.Add(Me.lblzzz)
        Me.pgPipeandFittings.Controls.Add(Me.Label19)
        Me.pgPipeandFittings.Controls.Add(Me.lbl225Weight)
        Me.pgPipeandFittings.Controls.Add(Me.Label17)
        Me.pgPipeandFittings.Controls.Add(Me.Label16)
        Me.pgPipeandFittings.Controls.Add(Me.Label15)
        Me.pgPipeandFittings.Controls.Add(Me.Label14)
        Me.pgPipeandFittings.Controls.Add(Me.cmbPipeSize)
        Me.pgPipeandFittings.Controls.Add(Me.Label13)
        Me.pgPipeandFittings.Controls.Add(Me.btnDonePipe)
        Me.pgPipeandFittings.Location = New System.Drawing.Point(4, 22)
        Me.pgPipeandFittings.Name = "pgPipeandFittings"
        Me.pgPipeandFittings.Size = New System.Drawing.Size(1161, 518)
        Me.pgPipeandFittings.TabIndex = 4
        Me.pgPipeandFittings.Text = " Pipe and Fittings"
        Me.pgPipeandFittings.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(20, 355)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(399, 20)
        Me.TextBox2.TabIndex = 106
        Me.TextBox2.Text = "Coming Soon: Non - Main Sizes"
        '
        'lblPipeSA
        '
        Me.lblPipeSA.AutoSize = True
        Me.lblPipeSA.Location = New System.Drawing.Point(684, 76)
        Me.lblPipeSA.Name = "lblPipeSA"
        Me.lblPipeSA.Size = New System.Drawing.Size(46, 13)
        Me.lblPipeSA.TabIndex = 83
        Me.lblPipeSA.Text = "22.5° Ell"
        Me.lblPipeSA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPipeEL
        '
        Me.lblPipeEL.AutoSize = True
        Me.lblPipeEL.Location = New System.Drawing.Point(595, 76)
        Me.lblPipeEL.Name = "lblPipeEL"
        Me.lblPipeEL.Size = New System.Drawing.Size(46, 13)
        Me.lblPipeEL.TabIndex = 82
        Me.lblPipeEL.Text = "22.5° Ell"
        Me.lblPipeEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPipeVol
        '
        Me.lblPipeVol.AutoSize = True
        Me.lblPipeVol.Location = New System.Drawing.Point(506, 76)
        Me.lblPipeVol.Name = "lblPipeVol"
        Me.lblPipeVol.Size = New System.Drawing.Size(46, 13)
        Me.lblPipeVol.TabIndex = 81
        Me.lblPipeVol.Text = "22.5° Ell"
        Me.lblPipeVol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPipeWeight
        '
        Me.lblPipeWeight.AutoSize = True
        Me.lblPipeWeight.Location = New System.Drawing.Point(417, 76)
        Me.lblPipeWeight.Name = "lblPipeWeight"
        Me.lblPipeWeight.Size = New System.Drawing.Size(46, 13)
        Me.lblPipeWeight.TabIndex = 80
        Me.lblPipeWeight.Text = "22.5° Ell"
        Me.lblPipeWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(684, 48)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 13)
        Me.Label44.TabIndex = 79
        Me.Label44.Text = "Surface"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(595, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(47, 13)
        Me.Label48.TabIndex = 78
        Me.Label48.Text = "Equ Len"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(506, 48)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(42, 13)
        Me.Label52.TabIndex = 77
        Me.Label52.Text = "Volume"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(417, 48)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(41, 13)
        Me.Label56.TabIndex = 76
        Me.Label56.Text = "Weight"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed2SA
        '
        Me.lblConRed2SA.AutoSize = True
        Me.lblConRed2SA.Location = New System.Drawing.Point(684, 331)
        Me.lblConRed2SA.Name = "lblConRed2SA"
        Me.lblConRed2SA.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed2SA.TabIndex = 75
        Me.lblConRed2SA.Text = "22.5° Ell"
        Me.lblConRed2SA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed2EL
        '
        Me.lblConRed2EL.AutoSize = True
        Me.lblConRed2EL.Location = New System.Drawing.Point(595, 331)
        Me.lblConRed2EL.Name = "lblConRed2EL"
        Me.lblConRed2EL.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed2EL.TabIndex = 74
        Me.lblConRed2EL.Text = "22.5° Ell"
        Me.lblConRed2EL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed2Vol
        '
        Me.lblConRed2Vol.AutoSize = True
        Me.lblConRed2Vol.Location = New System.Drawing.Point(506, 331)
        Me.lblConRed2Vol.Name = "lblConRed2Vol"
        Me.lblConRed2Vol.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed2Vol.TabIndex = 73
        Me.lblConRed2Vol.Text = "22.5° Ell"
        Me.lblConRed2Vol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed2Mass
        '
        Me.lblConRed2Mass.AutoSize = True
        Me.lblConRed2Mass.Location = New System.Drawing.Point(417, 331)
        Me.lblConRed2Mass.Name = "lblConRed2Mass"
        Me.lblConRed2Mass.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed2Mass.TabIndex = 72
        Me.lblConRed2Mass.Text = "22.5° Ell"
        Me.lblConRed2Mass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed1SA
        '
        Me.lblConRed1SA.AutoSize = True
        Me.lblConRed1SA.Location = New System.Drawing.Point(684, 303)
        Me.lblConRed1SA.Name = "lblConRed1SA"
        Me.lblConRed1SA.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed1SA.TabIndex = 71
        Me.lblConRed1SA.Text = "22.5° Ell"
        Me.lblConRed1SA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed1EL
        '
        Me.lblConRed1EL.AutoSize = True
        Me.lblConRed1EL.Location = New System.Drawing.Point(595, 303)
        Me.lblConRed1EL.Name = "lblConRed1EL"
        Me.lblConRed1EL.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed1EL.TabIndex = 70
        Me.lblConRed1EL.Text = "22.5° Ell"
        Me.lblConRed1EL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed1Vol
        '
        Me.lblConRed1Vol.AutoSize = True
        Me.lblConRed1Vol.Location = New System.Drawing.Point(506, 303)
        Me.lblConRed1Vol.Name = "lblConRed1Vol"
        Me.lblConRed1Vol.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed1Vol.TabIndex = 69
        Me.lblConRed1Vol.Text = "22.5° Ell"
        Me.lblConRed1Vol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConRed1Mass
        '
        Me.lblConRed1Mass.AutoSize = True
        Me.lblConRed1Mass.Location = New System.Drawing.Point(417, 303)
        Me.lblConRed1Mass.Name = "lblConRed1Mass"
        Me.lblConRed1Mass.Size = New System.Drawing.Size(46, 13)
        Me.lblConRed1Mass.TabIndex = 68
        Me.lblConRed1Mass.Text = "22.5° Ell"
        Me.lblConRed1Mass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBTeeSA
        '
        Me.lblBTeeSA.AutoSize = True
        Me.lblBTeeSA.Location = New System.Drawing.Point(683, 275)
        Me.lblBTeeSA.Name = "lblBTeeSA"
        Me.lblBTeeSA.Size = New System.Drawing.Size(46, 13)
        Me.lblBTeeSA.TabIndex = 67
        Me.lblBTeeSA.Text = "22.5° Ell"
        Me.lblBTeeSA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBTeeEL
        '
        Me.lblBTeeEL.AutoSize = True
        Me.lblBTeeEL.Location = New System.Drawing.Point(594, 275)
        Me.lblBTeeEL.Name = "lblBTeeEL"
        Me.lblBTeeEL.Size = New System.Drawing.Size(46, 13)
        Me.lblBTeeEL.TabIndex = 66
        Me.lblBTeeEL.Text = "22.5° Ell"
        Me.lblBTeeEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBTeeVol
        '
        Me.lblBTeeVol.AutoSize = True
        Me.lblBTeeVol.Location = New System.Drawing.Point(505, 275)
        Me.lblBTeeVol.Name = "lblBTeeVol"
        Me.lblBTeeVol.Size = New System.Drawing.Size(46, 13)
        Me.lblBTeeVol.TabIndex = 65
        Me.lblBTeeVol.Text = "22.5° Ell"
        Me.lblBTeeVol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBTeeMass
        '
        Me.lblBTeeMass.AutoSize = True
        Me.lblBTeeMass.Location = New System.Drawing.Point(416, 275)
        Me.lblBTeeMass.Name = "lblBTeeMass"
        Me.lblBTeeMass.Size = New System.Drawing.Size(46, 13)
        Me.lblBTeeMass.TabIndex = 64
        Me.lblBTeeMass.Text = "22.5° Ell"
        Me.lblBTeeMass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTeeSA
        '
        Me.lblTeeSA.AutoSize = True
        Me.lblTeeSA.Location = New System.Drawing.Point(684, 247)
        Me.lblTeeSA.Name = "lblTeeSA"
        Me.lblTeeSA.Size = New System.Drawing.Size(46, 13)
        Me.lblTeeSA.TabIndex = 63
        Me.lblTeeSA.Text = "22.5° Ell"
        Me.lblTeeSA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTeeEL
        '
        Me.lblTeeEL.AutoSize = True
        Me.lblTeeEL.Location = New System.Drawing.Point(595, 247)
        Me.lblTeeEL.Name = "lblTeeEL"
        Me.lblTeeEL.Size = New System.Drawing.Size(46, 13)
        Me.lblTeeEL.TabIndex = 62
        Me.lblTeeEL.Text = "22.5° Ell"
        Me.lblTeeEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTeeVol
        '
        Me.lblTeeVol.AutoSize = True
        Me.lblTeeVol.Location = New System.Drawing.Point(506, 247)
        Me.lblTeeVol.Name = "lblTeeVol"
        Me.lblTeeVol.Size = New System.Drawing.Size(46, 13)
        Me.lblTeeVol.TabIndex = 61
        Me.lblTeeVol.Text = "22.5° Ell"
        Me.lblTeeVol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTeeMass
        '
        Me.lblTeeMass.AutoSize = True
        Me.lblTeeMass.Location = New System.Drawing.Point(417, 247)
        Me.lblTeeMass.Name = "lblTeeMass"
        Me.lblTeeMass.Size = New System.Drawing.Size(46, 13)
        Me.lblTeeMass.TabIndex = 60
        Me.lblTeeMass.Text = "22.5° Ell"
        Me.lblTeeMass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl90SA
        '
        Me.lbl90SA.AutoSize = True
        Me.lbl90SA.Location = New System.Drawing.Point(684, 219)
        Me.lbl90SA.Name = "lbl90SA"
        Me.lbl90SA.Size = New System.Drawing.Size(46, 13)
        Me.lbl90SA.TabIndex = 59
        Me.lbl90SA.Text = "22.5° Ell"
        Me.lbl90SA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl90EL
        '
        Me.lbl90EL.AutoSize = True
        Me.lbl90EL.Location = New System.Drawing.Point(595, 219)
        Me.lbl90EL.Name = "lbl90EL"
        Me.lbl90EL.Size = New System.Drawing.Size(46, 13)
        Me.lbl90EL.TabIndex = 58
        Me.lbl90EL.Text = "22.5° Ell"
        Me.lbl90EL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl90Vol
        '
        Me.lbl90Vol.AutoSize = True
        Me.lbl90Vol.Location = New System.Drawing.Point(506, 219)
        Me.lbl90Vol.Name = "lbl90Vol"
        Me.lbl90Vol.Size = New System.Drawing.Size(46, 13)
        Me.lbl90Vol.TabIndex = 57
        Me.lbl90Vol.Text = "22.5° Ell"
        Me.lbl90Vol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl90Mass
        '
        Me.lbl90Mass.AutoSize = True
        Me.lbl90Mass.Location = New System.Drawing.Point(417, 219)
        Me.lbl90Mass.Name = "lbl90Mass"
        Me.lbl90Mass.Size = New System.Drawing.Size(46, 13)
        Me.lbl90Mass.TabIndex = 56
        Me.lbl90Mass.Text = "22.5° Ell"
        Me.lbl90Mass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl45SA
        '
        Me.lbl45SA.AutoSize = True
        Me.lbl45SA.Location = New System.Drawing.Point(684, 191)
        Me.lbl45SA.Name = "lbl45SA"
        Me.lbl45SA.Size = New System.Drawing.Size(46, 13)
        Me.lbl45SA.TabIndex = 55
        Me.lbl45SA.Text = "22.5° Ell"
        Me.lbl45SA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl45EL
        '
        Me.lbl45EL.AutoSize = True
        Me.lbl45EL.Location = New System.Drawing.Point(595, 191)
        Me.lbl45EL.Name = "lbl45EL"
        Me.lbl45EL.Size = New System.Drawing.Size(46, 13)
        Me.lbl45EL.TabIndex = 54
        Me.lbl45EL.Text = "22.5° Ell"
        Me.lbl45EL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl45Vol
        '
        Me.lbl45Vol.AutoSize = True
        Me.lbl45Vol.Location = New System.Drawing.Point(506, 191)
        Me.lbl45Vol.Name = "lbl45Vol"
        Me.lbl45Vol.Size = New System.Drawing.Size(46, 13)
        Me.lbl45Vol.TabIndex = 53
        Me.lbl45Vol.Text = "22.5° Ell"
        Me.lbl45Vol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl45Mass
        '
        Me.lbl45Mass.AutoSize = True
        Me.lbl45Mass.Location = New System.Drawing.Point(417, 191)
        Me.lbl45Mass.Name = "lbl45Mass"
        Me.lbl45Mass.Size = New System.Drawing.Size(46, 13)
        Me.lbl45Mass.TabIndex = 52
        Me.lbl45Mass.Text = "22.5° Ell"
        Me.lbl45Mass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl225SA
        '
        Me.lbl225SA.AutoSize = True
        Me.lbl225SA.Location = New System.Drawing.Point(684, 163)
        Me.lbl225SA.Name = "lbl225SA"
        Me.lbl225SA.Size = New System.Drawing.Size(46, 13)
        Me.lbl225SA.TabIndex = 51
        Me.lbl225SA.Text = "22.5° Ell"
        Me.lbl225SA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl225EL
        '
        Me.lbl225EL.AutoSize = True
        Me.lbl225EL.Location = New System.Drawing.Point(595, 163)
        Me.lbl225EL.Name = "lbl225EL"
        Me.lbl225EL.Size = New System.Drawing.Size(46, 13)
        Me.lbl225EL.TabIndex = 50
        Me.lbl225EL.Text = "22.5° Ell"
        Me.lbl225EL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl225Vol
        '
        Me.lbl225Vol.AutoSize = True
        Me.lbl225Vol.Location = New System.Drawing.Point(506, 163)
        Me.lbl225Vol.Name = "lbl225Vol"
        Me.lbl225Vol.Size = New System.Drawing.Size(46, 13)
        Me.lbl225Vol.TabIndex = 49
        Me.lbl225Vol.Text = "22.5° Ell"
        Me.lbl225Vol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl225Mass
        '
        Me.lbl225Mass.AutoSize = True
        Me.lbl225Mass.Location = New System.Drawing.Point(417, 163)
        Me.lbl225Mass.Name = "lbl225Mass"
        Me.lbl225Mass.Size = New System.Drawing.Size(46, 13)
        Me.lbl225Mass.TabIndex = 48
        Me.lbl225Mass.Text = "22.5° Ell"
        Me.lbl225Mass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbFittingStyle
        '
        Me.cmbFittingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFittingStyle.FormattingEnabled = True
        Me.cmbFittingStyle.Items.AddRange(New Object() {"Victaulic"})
        Me.cmbFittingStyle.Location = New System.Drawing.Point(20, 45)
        Me.cmbFittingStyle.Name = "cmbFittingStyle"
        Me.cmbFittingStyle.Size = New System.Drawing.Size(112, 21)
        Me.cmbFittingStyle.TabIndex = 47
        '
        'cmbPipeSchedule
        '
        Me.cmbPipeSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPipeSchedule.FormattingEnabled = True
        Me.cmbPipeSchedule.Items.AddRange(New Object() {"Schedule 40"})
        Me.cmbPipeSchedule.Location = New System.Drawing.Point(20, 15)
        Me.cmbPipeSchedule.Name = "cmbPipeSchedule"
        Me.cmbPipeSchedule.Size = New System.Drawing.Size(112, 21)
        Me.cmbPipeSchedule.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(138, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Fitting Style"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(138, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Pipe Schedule"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.ComboBox5.Location = New System.Drawing.Point(138, 328)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox5.TabIndex = 43
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.ComboBox4.Location = New System.Drawing.Point(138, 300)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox4.TabIndex = 42
        '
        'nudConRed2
        '
        Me.nudConRed2.Location = New System.Drawing.Point(64, 329)
        Me.nudConRed2.Name = "nudConRed2"
        Me.nudConRed2.Size = New System.Drawing.Size(68, 20)
        Me.nudConRed2.TabIndex = 41
        Me.nudConRed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudConRed1
        '
        Me.nudConRed1.Location = New System.Drawing.Point(64, 301)
        Me.nudConRed1.Name = "nudConRed1"
        Me.nudConRed1.Size = New System.Drawing.Size(68, 20)
        Me.nudConRed1.TabIndex = 40
        Me.nudConRed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudBTee
        '
        Me.nudBTee.Location = New System.Drawing.Point(63, 273)
        Me.nudBTee.Name = "nudBTee"
        Me.nudBTee.Size = New System.Drawing.Size(68, 20)
        Me.nudBTee.TabIndex = 39
        Me.nudBTee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudTee
        '
        Me.nudTee.Location = New System.Drawing.Point(64, 245)
        Me.nudTee.Name = "nudTee"
        Me.nudTee.Size = New System.Drawing.Size(68, 20)
        Me.nudTee.TabIndex = 38
        Me.nudTee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nud90
        '
        Me.nud90.Location = New System.Drawing.Point(64, 217)
        Me.nud90.Name = "nud90"
        Me.nud90.Size = New System.Drawing.Size(68, 20)
        Me.nud90.TabIndex = 37
        Me.nud90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nud45
        '
        Me.nud45.Location = New System.Drawing.Point(64, 189)
        Me.nud45.Name = "nud45"
        Me.nud45.Size = New System.Drawing.Size(68, 20)
        Me.nud45.TabIndex = 36
        Me.nud45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nud225
        '
        Me.nud225.Location = New System.Drawing.Point(64, 161)
        Me.nud225.Name = "nud225"
        Me.nud225.Size = New System.Drawing.Size(68, 20)
        Me.nud225.TabIndex = 35
        Me.nud225.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPipeLength
        '
        Me.txtPipeLength.Location = New System.Drawing.Point(20, 133)
        Me.txtPipeLength.Name = "txtPipeLength"
        Me.txtPipeLength.Size = New System.Drawing.Size(112, 20)
        Me.txtPipeLength.TabIndex = 34
        Me.txtPipeLength.Text = "0"
        Me.txtPipeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPDper100ft
        '
        Me.txtPDper100ft.Location = New System.Drawing.Point(20, 105)
        Me.txtPDper100ft.Name = "txtPDper100ft"
        Me.txtPDper100ft.Size = New System.Drawing.Size(112, 20)
        Me.txtPDper100ft.TabIndex = 33
        Me.txtPDper100ft.Text = "0.00"
        Me.txtPDper100ft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(251, 331)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Concentric Reducer"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(251, 303)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Concentric Reducer"
        '
        'lblzzz
        '
        Me.lblzzz.AutoSize = True
        Me.lblzzz.Location = New System.Drawing.Point(137, 275)
        Me.lblzzz.Name = "lblzzz"
        Me.lblzzz.Size = New System.Drawing.Size(94, 13)
        Me.lblzzz.TabIndex = 30
        Me.lblzzz.Text = "Tee - Branch Flow"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(138, 247)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Tee - Straight Flow"
        '
        'lbl225Weight
        '
        Me.lbl225Weight.AutoSize = True
        Me.lbl225Weight.Location = New System.Drawing.Point(138, 163)
        Me.lbl225Weight.Name = "lbl225Weight"
        Me.lbl225Weight.Size = New System.Drawing.Size(46, 13)
        Me.lbl225Weight.TabIndex = 28
        Me.lbl225Weight.Text = "22.5° Ell"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(138, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "90° Ell"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(138, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "45° Ell"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(138, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Estimated Pipe Length(ft.)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(139, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Pressure Drop/100' (ft.)"
        Me.ToolTip1.SetToolTip(Me.Label14, "asdf")
        '
        'cmbPipeSize
        '
        Me.cmbPipeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPipeSize.FormattingEnabled = True
        Me.cmbPipeSize.Items.AddRange(New Object() {"3", "4", "5", "6", "8", "10"})
        Me.cmbPipeSize.Location = New System.Drawing.Point(19, 75)
        Me.cmbPipeSize.Name = "cmbPipeSize"
        Me.cmbPipeSize.Size = New System.Drawing.Size(112, 21)
        Me.cmbPipeSize.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(138, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Main Run Pipe Size"
        '
        'btnDonePipe
        '
        Me.btnDonePipe.Location = New System.Drawing.Point(1061, 475)
        Me.btnDonePipe.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonePipe.Name = "btnDonePipe"
        Me.btnDonePipe.Size = New System.Drawing.Size(96, 36)
        Me.btnDonePipe.TabIndex = 21
        Me.btnDonePipe.Text = ">"
        Me.btnDonePipe.UseVisualStyleBackColor = True
        '
        'pgSpecialties
        '
        Me.pgSpecialties.Controls.Add(Me.chkOutletIso)
        Me.pgSpecialties.Controls.Add(Me.chkInletIso)
        Me.pgSpecialties.Controls.Add(Me.gridAvailItems)
        Me.pgSpecialties.Controls.Add(Me.Label39)
        Me.pgSpecialties.Controls.Add(Me.txtSpecTag)
        Me.pgSpecialties.Controls.Add(Me.btnDelSpecialtytoGrid)
        Me.pgSpecialties.Controls.Add(Me.lstAvailSpecialties)
        Me.pgSpecialties.Controls.Add(Me.btnDebug)
        Me.pgSpecialties.Controls.Add(Me.btnAddSpecialtytoGrid)
        Me.pgSpecialties.Controls.Add(Me.gridSepecialties)
        Me.pgSpecialties.Controls.Add(Me.btnDoneSpecialties)
        Me.pgSpecialties.Location = New System.Drawing.Point(4, 22)
        Me.pgSpecialties.Margin = New System.Windows.Forms.Padding(4)
        Me.pgSpecialties.Name = "pgSpecialties"
        Me.pgSpecialties.Size = New System.Drawing.Size(1161, 518)
        Me.pgSpecialties.TabIndex = 2
        Me.pgSpecialties.Text = "Specialties"
        Me.pgSpecialties.UseVisualStyleBackColor = True
        '
        'chkOutletIso
        '
        Me.chkOutletIso.AutoSize = True
        Me.chkOutletIso.Location = New System.Drawing.Point(359, 210)
        Me.chkOutletIso.Name = "chkOutletIso"
        Me.chkOutletIso.Size = New System.Drawing.Size(101, 17)
        Me.chkOutletIso.TabIndex = 31
        Me.chkOutletIso.Text = "Outlet Iso Valve"
        Me.chkOutletIso.UseVisualStyleBackColor = True
        '
        'chkInletIso
        '
        Me.chkInletIso.AutoSize = True
        Me.chkInletIso.Location = New System.Drawing.Point(359, 183)
        Me.chkInletIso.Name = "chkInletIso"
        Me.chkInletIso.Size = New System.Drawing.Size(93, 17)
        Me.chkInletIso.TabIndex = 30
        Me.chkInletIso.Text = "Inlet Iso Valve"
        Me.chkInletIso.UseVisualStyleBackColor = True
        '
        'gridAvailItems
        '
        Me.gridAvailItems.AllowUserToAddRows = False
        Me.gridAvailItems.AllowUserToDeleteRows = False
        Me.gridAvailItems.AllowUserToResizeColumns = False
        Me.gridAvailItems.AllowUserToResizeRows = False
        Me.gridAvailItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridAvailItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAvailItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemSize, Me.Manuf, Me.InletSize, Me.OutletSize, Me.DryWeight, Me.FluidVol})
        Me.gridAvailItems.Location = New System.Drawing.Point(3, 183)
        Me.gridAvailItems.MultiSelect = False
        Me.gridAvailItems.Name = "gridAvailItems"
        Me.gridAvailItems.ReadOnly = True
        Me.gridAvailItems.RowHeadersWidth = 20
        Me.gridAvailItems.RowTemplate.Height = 24
        Me.gridAvailItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAvailItems.Size = New System.Drawing.Size(350, 150)
        Me.gridAvailItems.TabIndex = 29
        '
        'ItemSize
        '
        Me.ItemSize.HeaderText = "Size"
        Me.ItemSize.Name = "ItemSize"
        Me.ItemSize.ReadOnly = True
        Me.ItemSize.Width = 52
        '
        'Manuf
        '
        Me.Manuf.HeaderText = "Manufacturer"
        Me.Manuf.Name = "Manuf"
        Me.Manuf.ReadOnly = True
        Me.Manuf.Width = 95
        '
        'InletSize
        '
        Me.InletSize.HeaderText = "Inlet"
        Me.InletSize.Name = "InletSize"
        Me.InletSize.ReadOnly = True
        Me.InletSize.Width = 52
        '
        'OutletSize
        '
        Me.OutletSize.HeaderText = "Outlet"
        Me.OutletSize.Name = "OutletSize"
        Me.OutletSize.ReadOnly = True
        Me.OutletSize.Width = 60
        '
        'DryWeight
        '
        Me.DryWeight.HeaderText = "DWeight"
        Me.DryWeight.Name = "DryWeight"
        Me.DryWeight.ReadOnly = True
        Me.DryWeight.Width = 74
        '
        'FluidVol
        '
        Me.FluidVol.HeaderText = "Vol"
        Me.FluidVol.Name = "FluidVol"
        Me.FluidVol.ReadOnly = True
        Me.FluidVol.Width = 47
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(58, 18)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(26, 13)
        Me.Label39.TabIndex = 28
        Me.Label39.Text = "Tag"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSpecTag
        '
        Me.txtSpecTag.Location = New System.Drawing.Point(100, 15)
        Me.txtSpecTag.Name = "txtSpecTag"
        Me.txtSpecTag.Size = New System.Drawing.Size(75, 20)
        Me.txtSpecTag.TabIndex = 27
        Me.txtSpecTag.Text = "Tag-01"
        Me.txtSpecTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelSpecialtytoGrid
        '
        Me.btnDelSpecialtytoGrid.Location = New System.Drawing.Point(359, 85)
        Me.btnDelSpecialtytoGrid.Name = "btnDelSpecialtytoGrid"
        Me.btnDelSpecialtytoGrid.Size = New System.Drawing.Size(97, 28)
        Me.btnDelSpecialtytoGrid.TabIndex = 26
        Me.btnDelSpecialtytoGrid.Text = "Remove"
        Me.btnDelSpecialtytoGrid.UseVisualStyleBackColor = True
        '
        'lstAvailSpecialties
        '
        Me.lstAvailSpecialties.FormattingEnabled = True
        Me.lstAvailSpecialties.Items.AddRange(New Object() {"Triple Duty Valve", "Suction Diffuser", "Bladder Expansion Tank", "Air Separator", "Automatic Air Vent", "Buffer Tank", "Wye Strainer", "Tee Strainer", "Glycol Makeup Unit", "Chemical Pot Feeder"})
        Me.lstAvailSpecialties.Location = New System.Drawing.Point(3, 45)
        Me.lstAvailSpecialties.Name = "lstAvailSpecialties"
        Me.lstAvailSpecialties.Size = New System.Drawing.Size(350, 108)
        Me.lstAvailSpecialties.TabIndex = 25
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(386, 389)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(70, 41)
        Me.btnDebug.TabIndex = 24
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'btnAddSpecialtytoGrid
        '
        Me.btnAddSpecialtytoGrid.Location = New System.Drawing.Point(359, 45)
        Me.btnAddSpecialtytoGrid.Name = "btnAddSpecialtytoGrid"
        Me.btnAddSpecialtytoGrid.Size = New System.Drawing.Size(97, 28)
        Me.btnAddSpecialtytoGrid.TabIndex = 23
        Me.btnAddSpecialtytoGrid.Text = "Add"
        Me.btnAddSpecialtytoGrid.UseVisualStyleBackColor = True
        '
        'gridSepecialties
        '
        Me.gridSepecialties.AllowUserToAddRows = False
        Me.gridSepecialties.AllowUserToDeleteRows = False
        Me.gridSepecialties.AllowUserToResizeColumns = False
        Me.gridSepecialties.AllowUserToResizeRows = False
        Me.gridSepecialties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridSepecialties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSepecialties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SpecTag, Me.Item, Me.PipeSize, Me.Manufacturer, Me.InletVTag, Me.OutVTag, Me.SpecDryWeight, Me.SpecFluidVol, Me.SpecPDrop})
        Me.gridSepecialties.Location = New System.Drawing.Point(508, 17)
        Me.gridSepecialties.MultiSelect = False
        Me.gridSepecialties.Name = "gridSepecialties"
        Me.gridSepecialties.ReadOnly = True
        Me.gridSepecialties.RowHeadersWidth = 20
        Me.gridSepecialties.RowTemplate.Height = 24
        Me.gridSepecialties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSepecialties.Size = New System.Drawing.Size(646, 451)
        Me.gridSepecialties.TabIndex = 22
        '
        'SpecTag
        '
        Me.SpecTag.HeaderText = "Tag"
        Me.SpecTag.Name = "SpecTag"
        Me.SpecTag.ReadOnly = True
        Me.SpecTag.Width = 51
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 52
        '
        'PipeSize
        '
        Me.PipeSize.HeaderText = "Size"
        Me.PipeSize.Name = "PipeSize"
        Me.PipeSize.ReadOnly = True
        Me.PipeSize.Width = 52
        '
        'Manufacturer
        '
        Me.Manufacturer.FillWeight = 200.0!
        Me.Manufacturer.HeaderText = "Manufacturer"
        Me.Manufacturer.Name = "Manufacturer"
        Me.Manufacturer.ReadOnly = True
        Me.Manufacturer.Width = 95
        '
        'InletVTag
        '
        Me.InletVTag.HeaderText = "Inlet Valve"
        Me.InletVTag.Name = "InletVTag"
        Me.InletVTag.ReadOnly = True
        Me.InletVTag.Width = 82
        '
        'OutVTag
        '
        Me.OutVTag.HeaderText = "Outlet Valve"
        Me.OutVTag.Name = "OutVTag"
        Me.OutVTag.ReadOnly = True
        Me.OutVTag.Width = 90
        '
        'SpecDryWeight
        '
        Me.SpecDryWeight.HeaderText = "DWeight"
        Me.SpecDryWeight.Name = "SpecDryWeight"
        Me.SpecDryWeight.ReadOnly = True
        Me.SpecDryWeight.Width = 74
        '
        'SpecFluidVol
        '
        Me.SpecFluidVol.HeaderText = "Vol"
        Me.SpecFluidVol.Name = "SpecFluidVol"
        Me.SpecFluidVol.ReadOnly = True
        Me.SpecFluidVol.Width = 47
        '
        'SpecPDrop
        '
        Me.SpecPDrop.HeaderText = "PD"
        Me.SpecPDrop.Name = "SpecPDrop"
        Me.SpecPDrop.ReadOnly = True
        Me.SpecPDrop.Width = 47
        '
        'btnDoneSpecialties
        '
        Me.btnDoneSpecialties.Location = New System.Drawing.Point(1061, 475)
        Me.btnDoneSpecialties.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneSpecialties.Name = "btnDoneSpecialties"
        Me.btnDoneSpecialties.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneSpecialties.TabIndex = 21
        Me.btnDoneSpecialties.Text = ">"
        Me.btnDoneSpecialties.UseVisualStyleBackColor = True
        '
        'pgValves
        '
        Me.pgValves.Controls.Add(Me.btnAddValve)
        Me.pgValves.Controls.Add(Me.gridValveSchedule)
        Me.pgValves.Controls.Add(Me.Button2)
        Me.pgValves.Location = New System.Drawing.Point(4, 22)
        Me.pgValves.Name = "pgValves"
        Me.pgValves.Size = New System.Drawing.Size(1161, 518)
        Me.pgValves.TabIndex = 5
        Me.pgValves.Text = "Valves"
        Me.pgValves.UseVisualStyleBackColor = True
        '
        'btnAddValve
        '
        Me.btnAddValve.Location = New System.Drawing.Point(466, 337)
        Me.btnAddValve.Name = "btnAddValve"
        Me.btnAddValve.Size = New System.Drawing.Size(96, 36)
        Me.btnAddValve.TabIndex = 24
        Me.btnAddValve.Text = "Add"
        Me.btnAddValve.UseVisualStyleBackColor = True
        '
        'gridValveSchedule
        '
        Me.gridValveSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridValveSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridValveSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ValveTag, Me.ValveDescription, Me.ValveSize, Me.ValveType, Me.ValveStyle, Me.ValveWeight, Me.ValveVolume, Me.ValvePD})
        Me.gridValveSchedule.Location = New System.Drawing.Point(3, 3)
        Me.gridValveSchedule.MultiSelect = False
        Me.gridValveSchedule.Name = "gridValveSchedule"
        Me.gridValveSchedule.RowHeadersWidth = 20
        Me.gridValveSchedule.RowTemplate.Height = 24
        Me.gridValveSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridValveSchedule.Size = New System.Drawing.Size(1151, 311)
        Me.gridValveSchedule.TabIndex = 23
        '
        'ValveTag
        '
        Me.ValveTag.HeaderText = "Tag"
        Me.ValveTag.Name = "ValveTag"
        Me.ValveTag.ReadOnly = True
        Me.ValveTag.Width = 51
        '
        'ValveDescription
        '
        Me.ValveDescription.HeaderText = "Description"
        Me.ValveDescription.Name = "ValveDescription"
        Me.ValveDescription.ReadOnly = True
        Me.ValveDescription.Width = 85
        '
        'ValveSize
        '
        Me.ValveSize.HeaderText = "Size"
        Me.ValveSize.Name = "ValveSize"
        Me.ValveSize.ReadOnly = True
        Me.ValveSize.Width = 52
        '
        'ValveType
        '
        Me.ValveType.HeaderText = "Type"
        Me.ValveType.Name = "ValveType"
        Me.ValveType.ReadOnly = True
        Me.ValveType.Width = 56
        '
        'ValveStyle
        '
        Me.ValveStyle.HeaderText = "Style"
        Me.ValveStyle.Name = "ValveStyle"
        Me.ValveStyle.ReadOnly = True
        Me.ValveStyle.Width = 55
        '
        'ValveWeight
        '
        Me.ValveWeight.HeaderText = "DryWeight"
        Me.ValveWeight.Name = "ValveWeight"
        Me.ValveWeight.ReadOnly = True
        Me.ValveWeight.Width = 82
        '
        'ValveVolume
        '
        Me.ValveVolume.HeaderText = "Fluid Vol"
        Me.ValveVolume.Name = "ValveVolume"
        Me.ValveVolume.ReadOnly = True
        Me.ValveVolume.Width = 72
        '
        'ValvePD
        '
        Me.ValvePD.HeaderText = "PD"
        Me.ValvePD.Name = "ValvePD"
        Me.ValvePD.ReadOnly = True
        Me.ValvePD.Width = 47
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1061, 475)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 36)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pgCouplings
        '
        Me.pgCouplings.Controls.Add(Me.TextBox1)
        Me.pgCouplings.Controls.Add(Me.lblVicOutlet72_2)
        Me.pgCouplings.Controls.Add(Me.lblVicOutlet72_1)
        Me.pgCouplings.Controls.Add(Me.cmbVicOutlet02)
        Me.pgCouplings.Controls.Add(Me.cmbVicOutlet01)
        Me.pgCouplings.Controls.Add(Me.nudVicOutlet72_2)
        Me.pgCouplings.Controls.Add(Me.nudVicOutlet72_1)
        Me.pgCouplings.Controls.Add(Me.Label61)
        Me.pgCouplings.Controls.Add(Me.Label62)
        Me.pgCouplings.Controls.Add(Me.Label37)
        Me.pgCouplings.Controls.Add(Me.lblVicReducing750_2)
        Me.pgCouplings.Controls.Add(Me.lblVicReducing750_1)
        Me.pgCouplings.Controls.Add(Me.lblVicFlange741)
        Me.pgCouplings.Controls.Add(Me.lblVicFlex177)
        Me.pgCouplings.Controls.Add(Me.lblVicRigid107H)
        Me.pgCouplings.Controls.Add(Me.cmbVicReducing02)
        Me.pgCouplings.Controls.Add(Me.cmbVicReducing01)
        Me.pgCouplings.Controls.Add(Me.nudVicReducing750_2)
        Me.pgCouplings.Controls.Add(Me.nudVicReducing750_1)
        Me.pgCouplings.Controls.Add(Me.nudVicFlange741)
        Me.pgCouplings.Controls.Add(Me.nudVicFlex177)
        Me.pgCouplings.Controls.Add(Me.nudVicRigid107H)
        Me.pgCouplings.Controls.Add(Me.Label53)
        Me.pgCouplings.Controls.Add(Me.lblVicFlange741ccc)
        Me.pgCouplings.Controls.Add(Me.Label58)
        Me.pgCouplings.Controls.Add(Me.Label59)
        Me.pgCouplings.Controls.Add(Me.Label60)
        Me.pgCouplings.Controls.Add(Me.Label18)
        Me.pgCouplings.Controls.Add(Me.btnDoneCouplings)
        Me.pgCouplings.Location = New System.Drawing.Point(4, 22)
        Me.pgCouplings.Name = "pgCouplings"
        Me.pgCouplings.Size = New System.Drawing.Size(1161, 518)
        Me.pgCouplings.TabIndex = 6
        Me.pgCouplings.Text = "Couplings"
        Me.pgCouplings.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(399, 20)
        Me.TextBox1.TabIndex = 105
        Me.TextBox1.Text = "Coming Soon: Non - Main Sizes"
        '
        'lblVicOutlet72_2
        '
        Me.lblVicOutlet72_2.AutoSize = True
        Me.lblVicOutlet72_2.Location = New System.Drawing.Point(377, 240)
        Me.lblVicOutlet72_2.Name = "lblVicOutlet72_2"
        Me.lblVicOutlet72_2.Size = New System.Drawing.Size(22, 13)
        Me.lblVicOutlet72_2.TabIndex = 104
        Me.lblVicOutlet72_2.Text = "0.0"
        Me.lblVicOutlet72_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicOutlet72_1
        '
        Me.lblVicOutlet72_1.AutoSize = True
        Me.lblVicOutlet72_1.Location = New System.Drawing.Point(377, 212)
        Me.lblVicOutlet72_1.Name = "lblVicOutlet72_1"
        Me.lblVicOutlet72_1.Size = New System.Drawing.Size(22, 13)
        Me.lblVicOutlet72_1.TabIndex = 103
        Me.lblVicOutlet72_1.Text = "0.0"
        Me.lblVicOutlet72_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbVicOutlet02
        '
        Me.cmbVicOutlet02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVicOutlet02.FormattingEnabled = True
        Me.cmbVicOutlet02.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.cmbVicOutlet02.Location = New System.Drawing.Point(98, 237)
        Me.cmbVicOutlet02.Name = "cmbVicOutlet02"
        Me.cmbVicOutlet02.Size = New System.Drawing.Size(112, 21)
        Me.cmbVicOutlet02.TabIndex = 102
        '
        'cmbVicOutlet01
        '
        Me.cmbVicOutlet01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVicOutlet01.FormattingEnabled = True
        Me.cmbVicOutlet01.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.cmbVicOutlet01.Location = New System.Drawing.Point(98, 209)
        Me.cmbVicOutlet01.Name = "cmbVicOutlet01"
        Me.cmbVicOutlet01.Size = New System.Drawing.Size(112, 21)
        Me.cmbVicOutlet01.TabIndex = 101
        '
        'nudVicOutlet72_2
        '
        Me.nudVicOutlet72_2.Location = New System.Drawing.Point(24, 238)
        Me.nudVicOutlet72_2.Name = "nudVicOutlet72_2"
        Me.nudVicOutlet72_2.Size = New System.Drawing.Size(68, 20)
        Me.nudVicOutlet72_2.TabIndex = 100
        Me.nudVicOutlet72_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudVicOutlet72_1
        '
        Me.nudVicOutlet72_1.Location = New System.Drawing.Point(24, 210)
        Me.nudVicOutlet72_1.Name = "nudVicOutlet72_1"
        Me.nudVicOutlet72_1.Size = New System.Drawing.Size(68, 20)
        Me.nudVicOutlet72_1.TabIndex = 99
        Me.nudVicOutlet72_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(216, 240)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(68, 13)
        Me.Label61.TabIndex = 98
        Me.Label61.Text = "Vic Outlet 72"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(216, 185)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(92, 13)
        Me.Label62.TabIndex = 97
        Me.Label62.Text = "Vic Reducing 750"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(377, 49)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 13)
        Me.Label37.TabIndex = 96
        Me.Label37.Text = "Weight"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicReducing750_2
        '
        Me.lblVicReducing750_2.AutoSize = True
        Me.lblVicReducing750_2.Location = New System.Drawing.Point(377, 185)
        Me.lblVicReducing750_2.Name = "lblVicReducing750_2"
        Me.lblVicReducing750_2.Size = New System.Drawing.Size(22, 13)
        Me.lblVicReducing750_2.TabIndex = 95
        Me.lblVicReducing750_2.Text = "0.0"
        Me.lblVicReducing750_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicReducing750_1
        '
        Me.lblVicReducing750_1.AutoSize = True
        Me.lblVicReducing750_1.Location = New System.Drawing.Point(377, 157)
        Me.lblVicReducing750_1.Name = "lblVicReducing750_1"
        Me.lblVicReducing750_1.Size = New System.Drawing.Size(22, 13)
        Me.lblVicReducing750_1.TabIndex = 94
        Me.lblVicReducing750_1.Text = "0.0"
        Me.lblVicReducing750_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicFlange741
        '
        Me.lblVicFlange741.AutoSize = True
        Me.lblVicFlange741.Location = New System.Drawing.Point(377, 131)
        Me.lblVicFlange741.Name = "lblVicFlange741"
        Me.lblVicFlange741.Size = New System.Drawing.Size(46, 13)
        Me.lblVicFlange741.TabIndex = 91
        Me.lblVicFlange741.Text = "22.5° Ell"
        Me.lblVicFlange741.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicFlex177
        '
        Me.lblVicFlex177.AutoSize = True
        Me.lblVicFlex177.Location = New System.Drawing.Point(377, 103)
        Me.lblVicFlex177.Name = "lblVicFlex177"
        Me.lblVicFlex177.Size = New System.Drawing.Size(46, 13)
        Me.lblVicFlex177.TabIndex = 90
        Me.lblVicFlex177.Text = "22.5° Ell"
        Me.lblVicFlex177.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVicRigid107H
        '
        Me.lblVicRigid107H.AutoSize = True
        Me.lblVicRigid107H.Location = New System.Drawing.Point(377, 75)
        Me.lblVicRigid107H.Name = "lblVicRigid107H"
        Me.lblVicRigid107H.Size = New System.Drawing.Size(46, 13)
        Me.lblVicRigid107H.TabIndex = 89
        Me.lblVicRigid107H.Text = "22.5° Ell"
        Me.lblVicRigid107H.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbVicReducing02
        '
        Me.cmbVicReducing02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVicReducing02.FormattingEnabled = True
        Me.cmbVicReducing02.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.cmbVicReducing02.Location = New System.Drawing.Point(98, 182)
        Me.cmbVicReducing02.Name = "cmbVicReducing02"
        Me.cmbVicReducing02.Size = New System.Drawing.Size(112, 21)
        Me.cmbVicReducing02.TabIndex = 88
        '
        'cmbVicReducing01
        '
        Me.cmbVicReducing01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVicReducing01.FormattingEnabled = True
        Me.cmbVicReducing01.Items.AddRange(New Object() {"3""", "4""", "5""", "6""", "8""", "10"""})
        Me.cmbVicReducing01.Location = New System.Drawing.Point(98, 154)
        Me.cmbVicReducing01.Name = "cmbVicReducing01"
        Me.cmbVicReducing01.Size = New System.Drawing.Size(112, 21)
        Me.cmbVicReducing01.TabIndex = 87
        '
        'nudVicReducing750_2
        '
        Me.nudVicReducing750_2.Location = New System.Drawing.Point(24, 183)
        Me.nudVicReducing750_2.Name = "nudVicReducing750_2"
        Me.nudVicReducing750_2.Size = New System.Drawing.Size(68, 20)
        Me.nudVicReducing750_2.TabIndex = 86
        Me.nudVicReducing750_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudVicReducing750_1
        '
        Me.nudVicReducing750_1.Location = New System.Drawing.Point(24, 155)
        Me.nudVicReducing750_1.Name = "nudVicReducing750_1"
        Me.nudVicReducing750_1.Size = New System.Drawing.Size(68, 20)
        Me.nudVicReducing750_1.TabIndex = 85
        Me.nudVicReducing750_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudVicFlange741
        '
        Me.nudVicFlange741.Location = New System.Drawing.Point(24, 129)
        Me.nudVicFlange741.Name = "nudVicFlange741"
        Me.nudVicFlange741.Size = New System.Drawing.Size(68, 20)
        Me.nudVicFlange741.TabIndex = 82
        Me.nudVicFlange741.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudVicFlex177
        '
        Me.nudVicFlex177.Location = New System.Drawing.Point(24, 101)
        Me.nudVicFlex177.Name = "nudVicFlex177"
        Me.nudVicFlex177.Size = New System.Drawing.Size(68, 20)
        Me.nudVicFlex177.TabIndex = 81
        Me.nudVicFlex177.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudVicRigid107H
        '
        Me.nudVicRigid107H.Location = New System.Drawing.Point(24, 73)
        Me.nudVicRigid107H.Name = "nudVicRigid107H"
        Me.nudVicRigid107H.Size = New System.Drawing.Size(68, 20)
        Me.nudVicRigid107H.TabIndex = 80
        Me.nudVicRigid107H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(216, 212)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(68, 13)
        Me.Label53.TabIndex = 79
        Me.Label53.Text = "Vic Outlet 72"
        '
        'lblVicFlange741ccc
        '
        Me.lblVicFlange741ccc.AutoSize = True
        Me.lblVicFlange741ccc.Location = New System.Drawing.Point(98, 131)
        Me.lblVicFlange741ccc.Name = "lblVicFlange741ccc"
        Me.lblVicFlange741ccc.Size = New System.Drawing.Size(78, 13)
        Me.lblVicFlange741ccc.TabIndex = 76
        Me.lblVicFlange741ccc.Text = "Vic Flange 741"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(98, 75)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(106, 13)
        Me.Label58.TabIndex = 75
        Me.Label58.Text = "QuickVic Rigid 107H"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(216, 157)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(92, 13)
        Me.Label59.TabIndex = 74
        Me.Label59.Text = "Vic Reducing 750"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(98, 103)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(93, 13)
        Me.Label60.TabIndex = 73
        Me.Label60.Text = "QuickVic Flex 177"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(801, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(191, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Also Handle Pipe Clamps and Supports"
        '
        'btnDoneCouplings
        '
        Me.btnDoneCouplings.Location = New System.Drawing.Point(1061, 475)
        Me.btnDoneCouplings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneCouplings.Name = "btnDoneCouplings"
        Me.btnDoneCouplings.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneCouplings.TabIndex = 21
        Me.btnDoneCouplings.Text = ">"
        Me.btnDoneCouplings.UseVisualStyleBackColor = True
        '
        'pgStructure
        '
        Me.pgStructure.Controls.Add(Me.Label42)
        Me.pgStructure.Controls.Add(Me.Label20)
        Me.pgStructure.Controls.Add(Me.btnDoneStructure)
        Me.pgStructure.Controls.Add(Me.GroupBox2)
        Me.pgStructure.Controls.Add(Me.GroupBox1)
        Me.pgStructure.Location = New System.Drawing.Point(4, 22)
        Me.pgStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.pgStructure.Name = "pgStructure"
        Me.pgStructure.Padding = New System.Windows.Forms.Padding(4)
        Me.pgStructure.Size = New System.Drawing.Size(1161, 518)
        Me.pgStructure.TabIndex = 0
        Me.pgStructure.Text = "Structure"
        Me.pgStructure.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(457, 166)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(148, 13)
        Me.Label42.TabIndex = 30
        Me.Label42.Text = "Handle Insulation here as well"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(457, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Enclosure Electrical and Other Electrical"
        '
        'btnDoneStructure
        '
        Me.btnDoneStructure.Location = New System.Drawing.Point(1057, 471)
        Me.btnDoneStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneStructure.Name = "btnDoneStructure"
        Me.btnDoneStructure.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneStructure.TabIndex = 21
        Me.btnDoneStructure.Text = ">"
        Me.btnDoneStructure.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudAnchorHoles)
        Me.GroupBox2.Controls.Add(Me.chkAnchorHoles)
        Me.GroupBox2.Controls.Add(Me.nudFloorDrainCount)
        Me.GroupBox2.Controls.Add(Me.chkFloorDrains)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 238)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(301, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Structure Features"
        '
        'nudAnchorHoles
        '
        Me.nudAnchorHoles.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudAnchorHoles.Location = New System.Drawing.Point(139, 55)
        Me.nudAnchorHoles.Margin = New System.Windows.Forms.Padding(4)
        Me.nudAnchorHoles.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudAnchorHoles.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudAnchorHoles.Name = "nudAnchorHoles"
        Me.nudAnchorHoles.Size = New System.Drawing.Size(48, 20)
        Me.nudAnchorHoles.TabIndex = 3
        Me.nudAnchorHoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudAnchorHoles.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'chkAnchorHoles
        '
        Me.chkAnchorHoles.AutoSize = True
        Me.chkAnchorHoles.Checked = True
        Me.chkAnchorHoles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnchorHoles.Location = New System.Drawing.Point(11, 57)
        Me.chkAnchorHoles.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAnchorHoles.Name = "chkAnchorHoles"
        Me.chkAnchorHoles.Size = New System.Drawing.Size(90, 17)
        Me.chkAnchorHoles.TabIndex = 2
        Me.chkAnchorHoles.Text = "Anchor Holes"
        Me.chkAnchorHoles.UseVisualStyleBackColor = True
        '
        'nudFloorDrainCount
        '
        Me.nudFloorDrainCount.Enabled = False
        Me.nudFloorDrainCount.Location = New System.Drawing.Point(139, 27)
        Me.nudFloorDrainCount.Margin = New System.Windows.Forms.Padding(4)
        Me.nudFloorDrainCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudFloorDrainCount.Name = "nudFloorDrainCount"
        Me.nudFloorDrainCount.Size = New System.Drawing.Size(48, 20)
        Me.nudFloorDrainCount.TabIndex = 1
        Me.nudFloorDrainCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFloorDrains
        '
        Me.chkFloorDrains.AutoSize = True
        Me.chkFloorDrains.Location = New System.Drawing.Point(11, 28)
        Me.chkFloorDrains.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFloorDrains.Name = "chkFloorDrains"
        Me.chkFloorDrains.Size = New System.Drawing.Size(77, 17)
        Me.chkFloorDrains.TabIndex = 0
        Me.chkFloorDrains.Text = "Floor Drain"
        Me.chkFloorDrains.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAluminumTread)
        Me.GroupBox1.Controls.Add(Me.cmbDecking)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbBaseRail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbHeight)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbWidth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSkidLength)
        Me.GroupBox1.Controls.Add(Me.chkEnclosure)
        Me.GroupBox1.Controls.Add(Me.lstPkgStructure)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(301, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Package Structure"
        '
        'chkAluminumTread
        '
        Me.chkAluminumTread.AutoSize = True
        Me.chkAluminumTread.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAluminumTread.Location = New System.Drawing.Point(91, 190)
        Me.chkAluminumTread.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAluminumTread.Name = "chkAluminumTread"
        Me.chkAluminumTread.Size = New System.Drawing.Size(125, 17)
        Me.chkAluminumTread.TabIndex = 12
        Me.chkAluminumTread.Text = "Aluminum Treadplate"
        Me.chkAluminumTread.UseVisualStyleBackColor = True
        '
        'cmbDecking
        '
        Me.cmbDecking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDecking.FormattingEnabled = True
        Me.cmbDecking.Items.AddRange(New Object() {"Open Grid", "3/16 Steel Deck", "3/16 Steel Diamond Deck", "n/a"})
        Me.cmbDecking.Location = New System.Drawing.Point(91, 156)
        Me.cmbDecking.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDecking.Name = "cmbDecking"
        Me.cmbDecking.Size = New System.Drawing.Size(189, 21)
        Me.cmbDecking.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Decking"
        '
        'cmbBaseRail
        '
        Me.cmbBaseRail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaseRail.FormattingEnabled = True
        Me.cmbBaseRail.Items.AddRange(New Object() {"4""", "6""", "6"" Full", "8""", "n/a"})
        Me.cmbBaseRail.Location = New System.Drawing.Point(208, 123)
        Me.cmbBaseRail.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBaseRail.Name = "cmbBaseRail"
        Me.cmbBaseRail.Size = New System.Drawing.Size(72, 21)
        Me.cmbBaseRail.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Base Rail"
        '
        'cmbHeight
        '
        Me.cmbHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeight.FormattingEnabled = True
        Me.cmbHeight.Items.AddRange(New Object() {"84""", "96""", "120""", "n/a"})
        Me.cmbHeight.Location = New System.Drawing.Point(208, 90)
        Me.cmbHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHeight.Name = "cmbHeight"
        Me.cmbHeight.Size = New System.Drawing.Size(72, 21)
        Me.cmbHeight.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Height"
        '
        'cmbWidth
        '
        Me.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWidth.FormattingEnabled = True
        Me.cmbWidth.Items.AddRange(New Object() {"44.3125""", "48""", "64""", "80""", "88.25""", "90.25""", "96""", "101""", "119""", "143""", "n/a"})
        Me.cmbWidth.Location = New System.Drawing.Point(208, 57)
        Me.cmbWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbWidth.Name = "cmbWidth"
        Me.cmbWidth.Size = New System.Drawing.Size(72, 21)
        Me.cmbWidth.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length"
        '
        'cmbSkidLength
        '
        Me.cmbSkidLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkidLength.FormattingEnabled = True
        Me.cmbSkidLength.Items.AddRange(New Object() {"48""", "64""", "80""", "96""", "112""", "128""", "n/a"})
        Me.cmbSkidLength.Location = New System.Drawing.Point(208, 23)
        Me.cmbSkidLength.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSkidLength.Name = "cmbSkidLength"
        Me.cmbSkidLength.Size = New System.Drawing.Size(72, 21)
        Me.cmbSkidLength.TabIndex = 2
        '
        'chkEnclosure
        '
        Me.chkEnclosure.AutoSize = True
        Me.chkEnclosure.Location = New System.Drawing.Point(8, 92)
        Me.chkEnclosure.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEnclosure.Name = "chkEnclosure"
        Me.chkEnclosure.Size = New System.Drawing.Size(73, 17)
        Me.chkEnclosure.TabIndex = 1
        Me.chkEnclosure.Text = "Enclosure"
        Me.chkEnclosure.UseVisualStyleBackColor = True
        '
        'lstPkgStructure
        '
        Me.lstPkgStructure.FormattingEnabled = True
        Me.lstPkgStructure.Items.AddRange(New Object() {"Skid Only", "Attached Skid", "Existing Footprint", "AHU Vestibule", "AHU Standalone"})
        Me.lstPkgStructure.Location = New System.Drawing.Point(8, 23)
        Me.lstPkgStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPkgStructure.Name = "lstPkgStructure"
        Me.lstPkgStructure.Size = New System.Drawing.Size(129, 30)
        Me.lstPkgStructure.TabIndex = 0
        '
        'pgElectrical
        '
        Me.pgElectrical.Location = New System.Drawing.Point(4, 22)
        Me.pgElectrical.Name = "pgElectrical"
        Me.pgElectrical.Size = New System.Drawing.Size(1161, 518)
        Me.pgElectrical.TabIndex = 9
        Me.pgElectrical.Text = "Electrical"
        Me.pgElectrical.UseVisualStyleBackColor = True
        '
        'pgMassAudit
        '
        Me.pgMassAudit.Location = New System.Drawing.Point(4, 22)
        Me.pgMassAudit.Name = "pgMassAudit"
        Me.pgMassAudit.Padding = New System.Windows.Forms.Padding(3)
        Me.pgMassAudit.Size = New System.Drawing.Size(1161, 518)
        Me.pgMassAudit.TabIndex = 11
        Me.pgMassAudit.Text = "Mass Audit"
        Me.pgMassAudit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(120, 566)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(16, 566)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(1064, 591)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Wet Weight (lbs)"
        Me.ToolTip1.SetToolTip(Me.Label25, "asdf")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1064, 561)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Dry Weight (lbs)"
        Me.ToolTip1.SetToolTip(Me.Label26, "asdf")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(789, 591)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Fluid Volume (gal)"
        Me.ToolTip1.SetToolTip(Me.Label27, "asdf")
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(513, 591)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(92, 13)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "Pressure Drop (ft.)"
        Me.ToolTip1.SetToolTip(Me.Label38, "asdf")
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(789, 561)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(62, 13)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "Weight/Gal"
        Me.ToolTip1.SetToolTip(Me.Label40, "asdf")
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(513, 561)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(53, 13)
        Me.Label41.TabIndex = 58
        Me.Label41.Text = "Fluid S.G."
        Me.ToolTip1.SetToolTip(Me.Label41, "asdf")
        '
        'txtWetWeight
        '
        Me.txtWetWeight.Enabled = False
        Me.txtWetWeight.Location = New System.Drawing.Point(946, 588)
        Me.txtWetWeight.Name = "txtWetWeight"
        Me.txtWetWeight.Size = New System.Drawing.Size(112, 20)
        Me.txtWetWeight.TabIndex = 51
        Me.txtWetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDryWeight
        '
        Me.txtDryWeight.Enabled = False
        Me.txtDryWeight.Location = New System.Drawing.Point(946, 558)
        Me.txtDryWeight.Name = "txtDryWeight"
        Me.txtDryWeight.Size = New System.Drawing.Size(112, 20)
        Me.txtDryWeight.TabIndex = 50
        Me.txtDryWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFluidVolume
        '
        Me.txtFluidVolume.Enabled = False
        Me.txtFluidVolume.Location = New System.Drawing.Point(671, 588)
        Me.txtFluidVolume.Name = "txtFluidVolume"
        Me.txtFluidVolume.Size = New System.Drawing.Size(112, 20)
        Me.txtFluidVolume.TabIndex = 53
        Me.txtFluidVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPackagePD
        '
        Me.txtPackagePD.Enabled = False
        Me.txtPackagePD.Location = New System.Drawing.Point(395, 588)
        Me.txtPackagePD.Name = "txtPackagePD"
        Me.txtPackagePD.Size = New System.Drawing.Size(112, 20)
        Me.txtPackagePD.TabIndex = 55
        Me.txtPackagePD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeightPerGallon
        '
        Me.txtWeightPerGallon.Enabled = False
        Me.txtWeightPerGallon.Location = New System.Drawing.Point(671, 558)
        Me.txtWeightPerGallon.Name = "txtWeightPerGallon"
        Me.txtWeightPerGallon.Size = New System.Drawing.Size(112, 20)
        Me.txtWeightPerGallon.TabIndex = 57
        Me.txtWeightPerGallon.Text = "8.71"
        Me.txtWeightPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFluidSG
        '
        Me.txtFluidSG.Enabled = False
        Me.txtFluidSG.Location = New System.Drawing.Point(395, 558)
        Me.txtFluidSG.Name = "txtFluidSG"
        Me.txtFluidSG.Size = New System.Drawing.Size(112, 20)
        Me.txtFluidSG.TabIndex = 59
        Me.txtFluidSG.Text = "1.00"
        Me.txtFluidSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdViewHistory
        '
        Me.cmdViewHistory.Image = CType(resources.GetObject("cmdViewHistory.Image"), System.Drawing.Image)
        Me.cmdViewHistory.Location = New System.Drawing.Point(1123, 612)
        Me.cmdViewHistory.Name = "cmdViewHistory"
        Me.cmdViewHistory.Size = New System.Drawing.Size(30, 29)
        Me.cmdViewHistory.TabIndex = 61
        Me.cmdViewHistory.UseVisualStyleBackColor = True
        '
        'cmdDesignCautions
        '
        Me.cmdDesignCautions.Image = CType(resources.GetObject("cmdDesignCautions.Image"), System.Drawing.Image)
        Me.cmdDesignCautions.Location = New System.Drawing.Point(1159, 612)
        Me.cmdDesignCautions.Name = "cmdDesignCautions"
        Me.cmdDesignCautions.Size = New System.Drawing.Size(30, 29)
        Me.cmdDesignCautions.TabIndex = 60
        Me.cmdDesignCautions.UseVisualStyleBackColor = True
        '
        'cmdFIOPPreview
        '
        Me.cmdFIOPPreview.Image = CType(resources.GetObject("cmdFIOPPreview.Image"), System.Drawing.Image)
        Me.cmdFIOPPreview.Location = New System.Drawing.Point(1087, 612)
        Me.cmdFIOPPreview.Name = "cmdFIOPPreview"
        Me.cmdFIOPPreview.Size = New System.Drawing.Size(30, 29)
        Me.cmdFIOPPreview.TabIndex = 62
        Me.cmdFIOPPreview.UseVisualStyleBackColor = True
        '
        'frmPipePkg
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1201, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdFIOPPreview)
        Me.Controls.Add(Me.cmdViewHistory)
        Me.Controls.Add(Me.cmdDesignCautions)
        Me.Controls.Add(Me.txtFluidSG)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtWeightPerGallon)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtPackagePD)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtFluidVolume)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtWetWeight)
        Me.Controls.Add(Me.txtDryWeight)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tbcPipePkg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPipePkg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Piping Package"
        Me.tbcPipePkg.ResumeLayout(False)
        Me.pgProposal.ResumeLayout(False)
        Me.pgProposal.PerformLayout()
        Me.grpPumpSystem.ResumeLayout(False)
        Me.grpPumpSystem.PerformLayout()
        Me.grpPumpCtrl.ResumeLayout(False)
        Me.grpPumpCtrl.PerformLayout()
        Me.grpPumpMotorStyle.ResumeLayout(False)
        Me.grpPumpMotorStyle.PerformLayout()
        CType(Me.nudPumpCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPkgModel.ResumeLayout(False)
        Me.grpPkgModel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pgPumps.ResumeLayout(False)
        Me.pgPumps.PerformLayout()
        Me.grpPumpBypass.ResumeLayout(False)
        Me.grpPumpBypass.PerformLayout()
        Me.grpPumpDisconnects.ResumeLayout(False)
        Me.grpPumpDisconnects.PerformLayout()
        Me.pgSpecOpt.ResumeLayout(False)
        Me.grpSucDiffOptions.ResumeLayout(False)
        Me.grpSucDiffOptions.PerformLayout()
        Me.grpTDVOptions.ResumeLayout(False)
        Me.grpTDVOptions.PerformLayout()
        Me.grpBufferTankOpts.ResumeLayout(False)
        Me.grpBufferTankOpts.PerformLayout()
        Me.grpBTDrain.ResumeLayout(False)
        Me.grpBTDrain.PerformLayout()
        Me.grpBTVenting.ResumeLayout(False)
        Me.grpBTVenting.PerformLayout()
        Me.grpHeatTrace.ResumeLayout(False)
        Me.grpHeatTrace.PerformLayout()
        Me.grpBTankInsulation.ResumeLayout(False)
        Me.grpBTankInsulation.PerformLayout()
        Me.pgHydronicDwg.ResumeLayout(False)
        Me.pgHydronicDwg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgPipeandFittings.ResumeLayout(False)
        Me.pgPipeandFittings.PerformLayout()
        CType(Me.nudConRed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConRed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBTee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud225, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgSpecialties.ResumeLayout(False)
        Me.pgSpecialties.PerformLayout()
        CType(Me.gridAvailItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSepecialties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgValves.ResumeLayout(False)
        CType(Me.gridValveSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCouplings.ResumeLayout(False)
        Me.pgCouplings.PerformLayout()
        CType(Me.nudVicOutlet72_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicOutlet72_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicReducing750_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicReducing750_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicFlange741, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicFlex177, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVicRigid107H, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgStructure.ResumeLayout(False)
        Me.pgStructure.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudAnchorHoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFloorDrainCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbcPipePkg As TabControl
    Friend WithEvents pgStructure As TabPage
    Friend WithEvents pgPumps As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstPkgStructure As ListBox
    Friend WithEvents pgSpecialties As TabPage
    Friend WithEvents cmbHeight As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbWidth As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSkidLength As ComboBox
    Friend WithEvents chkEnclosure As CheckBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cmbBaseRail As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkAluminumTread As CheckBox
    Friend WithEvents cmbDecking As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudAnchorHoles As NumericUpDown
    Friend WithEvents chkAnchorHoles As CheckBox
    Friend WithEvents nudFloorDrainCount As NumericUpDown
    Friend WithEvents chkFloorDrains As CheckBox
    Friend WithEvents pgProposal As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalHead As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFisenHead As TextBox
    Friend WithEvents txtChillerHead As TextBox
    Friend WithEvents txtExternalHead As TextBox
    Friend WithEvents optTotalHeadSpec As RadioButton
    Friend WithEvents optStandardHeadSpec As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbFluid As ComboBox
    Friend WithEvents cmbFluidPercent As ComboBox
    Friend WithEvents txtFlow As TextBox
    Friend WithEvents chkScopeSuctionDiff As CheckBox
    Friend WithEvents chkScopeTDV As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkScopeStrainer As CheckBox
    Friend WithEvents chkScopeInsulation As CheckBox
    Friend WithEvents chkScopeGMU As CheckBox
    Friend WithEvents chkScopeExpansionTank As CheckBox
    Friend WithEvents chkScopeAirSeparator As CheckBox
    Friend WithEvents chkScopePumps As CheckBox
    Friend WithEvents chkScopeBufferTank As CheckBox
    Friend WithEvents btnDoneProposal As Button
    Friend WithEvents btnDoneSpecialties As Button
    Friend WithEvents btnDonePumps As Button
    Friend WithEvents btnDoneStructure As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pgHydronicDwg As TabPage
    Friend WithEvents pgValves As TabPage
    Friend WithEvents pgCouplings As TabPage
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstAvailHydroDrawing As ListBox
    Friend WithEvents btnDoneHydronicDwg As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDoneCouplings As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents btnAddSpecialtytoGrid As Button
    Friend WithEvents gridSepecialties As DataGridView
    Friend WithEvents txtWetWeight As TextBox
    Friend WithEvents txtDryWeight As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtFluidVolume As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents btnDebug As Button
    Friend WithEvents gridValveSchedule As DataGridView
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnDelSpecialtytoGrid As Button
    Friend WithEvents lstAvailSpecialties As ListBox
    Friend WithEvents txtPackagePD As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txtSpecTag As TextBox
    Friend WithEvents gridAvailItems As DataGridView
    Friend WithEvents chkOutletIso As CheckBox
    Friend WithEvents chkInletIso As CheckBox
    Friend WithEvents ItemSize As DataGridViewTextBoxColumn
    Friend WithEvents Manuf As DataGridViewTextBoxColumn
    Friend WithEvents InletSize As DataGridViewTextBoxColumn
    Friend WithEvents OutletSize As DataGridViewTextBoxColumn
    Friend WithEvents DryWeight As DataGridViewTextBoxColumn
    Friend WithEvents FluidVol As DataGridViewTextBoxColumn
    Friend WithEvents Label40 As Label
    Friend WithEvents txtWeightPerGallon As TextBox
    Friend WithEvents SpecTag As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents PipeSize As DataGridViewTextBoxColumn
    Friend WithEvents Manufacturer As DataGridViewTextBoxColumn
    Friend WithEvents InletVTag As DataGridViewTextBoxColumn
    Friend WithEvents OutVTag As DataGridViewTextBoxColumn
    Friend WithEvents SpecDryWeight As DataGridViewTextBoxColumn
    Friend WithEvents SpecFluidVol As DataGridViewTextBoxColumn
    Friend WithEvents SpecPDrop As DataGridViewTextBoxColumn
    Friend WithEvents ValveTag As DataGridViewTextBoxColumn
    Friend WithEvents ValveDescription As DataGridViewTextBoxColumn
    Friend WithEvents ValveSize As DataGridViewTextBoxColumn
    Friend WithEvents ValveType As DataGridViewTextBoxColumn
    Friend WithEvents ValveStyle As DataGridViewTextBoxColumn
    Friend WithEvents ValveWeight As DataGridViewTextBoxColumn
    Friend WithEvents ValveVolume As DataGridViewTextBoxColumn
    Friend WithEvents ValvePD As DataGridViewTextBoxColumn
    Friend WithEvents btnAddValve As Button
    Friend WithEvents txtFluidSG As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents pgPipeandFittings As TabPage
    Friend WithEvents cmbFittingStyle As ComboBox
    Friend WithEvents cmbPipeSchedule As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents nudConRed2 As NumericUpDown
    Friend WithEvents nudConRed1 As NumericUpDown
    Friend WithEvents nudBTee As NumericUpDown
    Friend WithEvents nudTee As NumericUpDown
    Friend WithEvents nud90 As NumericUpDown
    Friend WithEvents nud45 As NumericUpDown
    Friend WithEvents nud225 As NumericUpDown
    Friend WithEvents txtPipeLength As TextBox
    Friend WithEvents txtPDper100ft As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblzzz As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl225Weight As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbPipeSize As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDonePipe As Button
    Friend WithEvents lbl225Vol As Label
    Friend WithEvents lbl225Mass As Label
    Friend WithEvents lbl225EL As Label
    Friend WithEvents lbl225SA As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents lblConRed2SA As Label
    Friend WithEvents lblConRed2EL As Label
    Friend WithEvents lblConRed2Vol As Label
    Friend WithEvents lblConRed2Mass As Label
    Friend WithEvents lblConRed1SA As Label
    Friend WithEvents lblConRed1EL As Label
    Friend WithEvents lblConRed1Vol As Label
    Friend WithEvents lblConRed1Mass As Label
    Friend WithEvents lblBTeeSA As Label
    Friend WithEvents lblBTeeEL As Label
    Friend WithEvents lblBTeeVol As Label
    Friend WithEvents lblBTeeMass As Label
    Friend WithEvents lblTeeSA As Label
    Friend WithEvents lblTeeEL As Label
    Friend WithEvents lblTeeVol As Label
    Friend WithEvents lblTeeMass As Label
    Friend WithEvents lbl90SA As Label
    Friend WithEvents lbl90EL As Label
    Friend WithEvents lbl90Vol As Label
    Friend WithEvents lbl90Mass As Label
    Friend WithEvents lbl45SA As Label
    Friend WithEvents lbl45EL As Label
    Friend WithEvents lbl45Vol As Label
    Friend WithEvents lbl45Mass As Label
    Friend WithEvents lblPipeSA As Label
    Friend WithEvents lblPipeEL As Label
    Friend WithEvents lblPipeVol As Label
    Friend WithEvents lblPipeWeight As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents chkScopePotFeed As CheckBox
    Friend WithEvents txtAvailDescription As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblVicOutlet72_2 As Label
    Friend WithEvents lblVicOutlet72_1 As Label
    Friend WithEvents cmbVicOutlet02 As ComboBox
    Friend WithEvents cmbVicOutlet01 As ComboBox
    Friend WithEvents nudVicOutlet72_2 As NumericUpDown
    Friend WithEvents nudVicOutlet72_1 As NumericUpDown
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lblVicReducing750_2 As Label
    Friend WithEvents lblVicReducing750_1 As Label
    Friend WithEvents lblVicFlange741 As Label
    Friend WithEvents lblVicFlex177 As Label
    Friend WithEvents lblVicRigid107H As Label
    Friend WithEvents cmbVicReducing02 As ComboBox
    Friend WithEvents cmbVicReducing01 As ComboBox
    Friend WithEvents nudVicReducing750_2 As NumericUpDown
    Friend WithEvents nudVicReducing750_1 As NumericUpDown
    Friend WithEvents nudVicFlange741 As NumericUpDown
    Friend WithEvents nudVicFlex177 As NumericUpDown
    Friend WithEvents nudVicRigid107H As NumericUpDown
    Friend WithEvents Label53 As Label
    Friend WithEvents lblVicFlange741ccc As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents pgSpecOpt As TabPage
    Friend WithEvents grpBufferTankOpts As GroupBox
    Friend WithEvents grpHeatTrace As GroupBox
    Friend WithEvents optBTHTNone As RadioButton
    Friend WithEvents optBTHTHeatTrace As RadioButton
    Friend WithEvents optBTHTImmersion As RadioButton
    Friend WithEvents grpBTankInsulation As GroupBox
    Friend WithEvents optBTUninsulated As RadioButton
    Friend WithEvents optBTArmaflex As RadioButton
    Friend WithEvents optBTSprayFoam As RadioButton
    Friend WithEvents chkBTHTUnitPowered As CheckBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtBTkWofHeat As TextBox
    Friend WithEvents grpBTVenting As GroupBox
    Friend WithEvents optBTVentNone As RadioButton
    Friend WithEvents optBTVentAuto As RadioButton
    Friend WithEvents optBTVentManual As RadioButton
    Friend WithEvents grpBTDrain As GroupBox
    Friend WithEvents optBTDrainNone As RadioButton
    Friend WithEvents optBTDrainChainCap As RadioButton
    Friend WithEvents optBTDrainValve As RadioButton
    Friend WithEvents grpPkgModel As GroupBox
    Friend WithEvents chkPkgAHUCool As CheckBox
    Friend WithEvents chkPkgAHUHeat As CheckBox
    Friend WithEvents optPkgAHU As RadioButton
    Friend WithEvents optPkgSkid As RadioButton
    Friend WithEvents optPkgIntegral As RadioButton
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents cmbFluidHeat As ComboBox
    Friend WithEvents cmbFluidPercentHeat As ComboBox
    Friend WithEvents txtFlowHeat As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents optCoilHeadSpec As RadioButton
    Friend WithEvents cmbPumpSpec As ComboBox
    Friend WithEvents cmbPotFeedSpec As ComboBox
    Friend WithEvents cmbInsSpec As ComboBox
    Friend WithEvents cmbGMUSpec As ComboBox
    Friend WithEvents cmbStrainSpec As ComboBox
    Friend WithEvents cmbAirSepSpec As ComboBox
    Friend WithEvents cmbExpTankSpec As ComboBox
    Friend WithEvents cmbBuffTankSpec As ComboBox
    Friend WithEvents cmbSucDiffSpec As ComboBox
    Friend WithEvents cmbTDVSpec As ComboBox
    Friend WithEvents Label51 As Label
    Friend WithEvents cmbPumpStyle As ComboBox
    Friend WithEvents nudPumpCount As NumericUpDown
    Friend WithEvents grpTDVOptions As GroupBox
    Friend WithEvents optTDVOptionsStraight As RadioButton
    Friend WithEvents optTDVOptionsAngle As RadioButton
    Friend WithEvents optTDVOptionsNA As RadioButton
    Friend WithEvents cmdViewHistory As Button
    Friend WithEvents cmdDesignCautions As Button
    Friend WithEvents optODPPumpMotor As RadioButton
    Friend WithEvents grpPumpMotorStyle As GroupBox
    Friend WithEvents optTEFCPumpMotor As RadioButton
    Friend WithEvents optPumpMotorNA As RadioButton
    Friend WithEvents chk65kASCCRBase As CheckBox
    Friend WithEvents grpSucDiffOptions As GroupBox
    Friend WithEvents chkSucDiffOptionsBlowDownValve As CheckBox
    Friend WithEvents cmbBuffTankStyle As ComboBox
    Friend WithEvents chkBuffTankOptionsCstmNozzles As CheckBox
    Friend WithEvents optBTInsNA As RadioButton
    Friend WithEvents optBTHTNA As RadioButton
    Friend WithEvents optBTDrainNA As RadioButton
    Friend WithEvents optBTVentNA As RadioButton
    Friend WithEvents txtBTCapacity As TextBox
    Friend WithEvents cmbExpTankStyle As ComboBox
    Friend WithEvents chkScopeEnclosure As CheckBox
    Friend WithEvents cmbGMUStyle As ComboBox
    Friend WithEvents cmbPotFeedStyle As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optPipeBaseNPT As RadioButton
    Friend WithEvents optPipeBaseWeld As RadioButton
    Friend WithEvents optPipeBaseVic As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optExtDeetFootprint As RadioButton
    Friend WithEvents optExtDeetCommonBR As RadioButton
    Friend WithEvents optExtDeetBaseRail As RadioButton
    Friend WithEvents cmdFIOPPreview As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents optPipeConsMulti As RadioButton
    Friend WithEvents optPipeConsSingle As RadioButton
    Friend WithEvents cmdDoneSpecOpt As Button
    Friend WithEvents pgElectrical As TabPage
    Friend WithEvents grpPumpCtrl As GroupBox
    Friend WithEvents grpPumpSystem As GroupBox
    Friend WithEvents optPumpSystemParallel As RadioButton
    Friend WithEvents optPumpSystemPriStby As RadioButton
    Friend WithEvents optPumpSystemNA As RadioButton
    Friend WithEvents cmbPCtrlSpecDrive As ComboBox
    Friend WithEvents optPCtrlCVPumps As RadioButton
    Friend WithEvents optPCtrlSpecificRemote As RadioButton
    Friend WithEvents optPCtrlStdRemote As RadioButton
    Friend WithEvents optPCtrlIVSRemote As RadioButton
    Friend WithEvents optPCtrlIVSonPump As RadioButton
    Friend WithEvents optPCtrlNA As RadioButton
    Friend WithEvents txtPRptCountAndStyle As TextBox
    Friend WithEvents optExtDeetNA As RadioButton
    Friend WithEvents chkPCtrlDisc As CheckBox
    Friend WithEvents chkPCtrlBypass As CheckBox
    Friend WithEvents pgWSEcon As TabPage
    Friend WithEvents cmbPumpMotorHP As ComboBox
    Friend WithEvents cmbPumpVolts As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents cmbPumpMotorSpeed As ComboBox
    Friend WithEvents txtPumpMotorType As TextBox
    Friend WithEvents txtPumpMotorFLA As TextBox
    Friend WithEvents txtPumpDryMass As TextBox
    Friend WithEvents txtPumpWetMass As TextBox
    Friend WithEvents txtImpellerDia As TextBox
    Friend WithEvents txtPumpHP As TextBox
    Friend WithEvents pgMassAudit As TabPage
    Friend WithEvents grpPumpDisconnects As GroupBox
    Friend WithEvents optPMDna As RadioButton
    Friend WithEvents optPMDFusedDisc As RadioButton
    Friend WithEvents optPMDIECDisc As RadioButton
    Friend WithEvents optPMDSafeSwitch As RadioButton
    Friend WithEvents grpPumpBypass As GroupBox
    Friend WithEvents optPumpBypass3ContactorAuto As RadioButton
    Friend WithEvents optPumpBypassNA As RadioButton
    Friend WithEvents optPumpBypass2ContactorAuto As RadioButton
    Friend WithEvents optPumpBypass2Contactor As RadioButton
End Class
