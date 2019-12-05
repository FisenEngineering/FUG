<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmERW
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
        Me.txtDryWeight = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tbcERW = New System.Windows.Forms.TabControl()
        Me.pgProposal = New System.Windows.Forms.TabPage()
        Me.grpXABypassDampers = New System.Windows.Forms.GroupBox()
        Me.optXABPDamperNone = New System.Windows.Forms.RadioButton()
        Me.optXABPDamperAtmosphere = New System.Windows.Forms.RadioButton()
        Me.optXABPDamperWheel = New System.Windows.Forms.RadioButton()
        Me.grpXABypassHoods = New System.Windows.Forms.GroupBox()
        Me.chkXABPHoodFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.optXABPHoodNone = New System.Windows.Forms.RadioButton()
        Me.chkXABPHoodMesh = New System.Windows.Forms.CheckBox()
        Me.optXABPHoodByFisen = New System.Windows.Forms.RadioButton()
        Me.optXABPHoodReuseJCI = New System.Windows.Forms.RadioButton()
        Me.grpRABPDampers = New System.Windows.Forms.GroupBox()
        Me.optRABPDampersNone = New System.Windows.Forms.RadioButton()
        Me.optRABPDampersByFisen = New System.Windows.Forms.RadioButton()
        Me.optRABPDampersReuse = New System.Windows.Forms.RadioButton()
        Me.grpOABPDampers = New System.Windows.Forms.GroupBox()
        Me.optOABPDampersNone = New System.Windows.Forms.RadioButton()
        Me.optOABPDampersByFisen = New System.Windows.Forms.RadioButton()
        Me.optOABPDampersReuse = New System.Windows.Forms.RadioButton()
        Me.grpOABPHoods = New System.Windows.Forms.GroupBox()
        Me.chkOABPHoodFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.optOABPHoodNone = New System.Windows.Forms.RadioButton()
        Me.chkOABPHoodMetalFilters = New System.Windows.Forms.CheckBox()
        Me.optOABPHoodByFisen = New System.Windows.Forms.RadioButton()
        Me.optOABPHoodReuseJCI = New System.Windows.Forms.RadioButton()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.optOADamperNone = New System.Windows.Forms.RadioButton()
        Me.optOADamperReuseJCI = New System.Windows.Forms.RadioButton()
        Me.optOADamperByFisen = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.chkOAHoodFieldInstalled = New System.Windows.Forms.CheckBox()
        Me.chkOAHoodMetalFilters = New System.Windows.Forms.CheckBox()
        Me.optOAHoodByFisen = New System.Windows.Forms.RadioButton()
        Me.optOAHoodReuseJCI = New System.Windows.Forms.RadioButton()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.cmbExtensionList = New System.Windows.Forms.ComboBox()
        Me.optCabinetStandAlone = New System.Windows.Forms.RadioButton()
        Me.optCabinetExtension = New System.Windows.Forms.RadioButton()
        Me.optCabinetInCab = New System.Windows.Forms.RadioButton()
        Me.cmbWheel = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtSFStaticPressureAllowance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optSFanJCI = New System.Windows.Forms.RadioButton()
        Me.optSFanOAFan = New System.Windows.Forms.RadioButton()
        Me.optSFanFisen = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optXFanbyJCI = New System.Windows.Forms.RadioButton()
        Me.txtRFStaticPressureAllowance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.optRFanbyJCI = New System.Windows.Forms.RadioButton()
        Me.optRFanByFisen = New System.Windows.Forms.RadioButton()
        Me.optXFanByFisen = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkFiltrationOAMetal = New System.Windows.Forms.CheckBox()
        Me.chkFiltrationRAAngledRack = New System.Windows.Forms.CheckBox()
        Me.chkFiltrationOAAngledRack = New System.Windows.Forms.CheckBox()
        Me.chkFiltrationRAMERV8 = New System.Windows.Forms.CheckBox()
        Me.chkFiltrationOAMERV8 = New System.Windows.Forms.CheckBox()
        Me.grpReliefDampers = New System.Windows.Forms.GroupBox()
        Me.optReliefDamperNone = New System.Windows.Forms.RadioButton()
        Me.optReliefDamperActuated = New System.Windows.Forms.RadioButton()
        Me.optReliefDamperBarometric = New System.Windows.Forms.RadioButton()
        Me.chkScopeXABypassDampers = New System.Windows.Forms.CheckBox()
        Me.chkScopeRABypassDampers = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optMultiPointPower = New System.Windows.Forms.RadioButton()
        Me.optSinglePointPower = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optPartialFlow = New System.Windows.Forms.RadioButton()
        Me.optFullFlow = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkERWVFDbyFisen = New System.Windows.Forms.CheckBox()
        Me.chkERWBypassSwitch = New System.Windows.Forms.CheckBox()
        Me.optCSWheel = New System.Windows.Forms.RadioButton()
        Me.optVSWheel = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPlasticWheel = New System.Windows.Forms.RadioButton()
        Me.optAlWheel = New System.Windows.Forms.RadioButton()
        Me.btnDoneProposal = New System.Windows.Forms.Button()
        Me.chkScopeOABypass = New System.Windows.Forms.CheckBox()
        Me.pgConditions = New System.Windows.Forms.TabPage()
        Me.cmdDoneConditions = New System.Windows.Forms.Button()
        Me.chkEnaAntiFrostCond = New System.Windows.Forms.CheckBox()
        Me.chkEnaAltCond = New System.Windows.Forms.CheckBox()
        Me.txtCondWAFRAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW2RAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW1RAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondS2RAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondS1RAFlow = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCondWAFSAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondWAFRAwb = New System.Windows.Forms.TextBox()
        Me.txtCondWAFRAdb = New System.Windows.Forms.TextBox()
        Me.txtCondWAFOAwb = New System.Windows.Forms.TextBox()
        Me.txtCondWAFOAdb = New System.Windows.Forms.TextBox()
        Me.txtCondWAFOAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW2SAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW2RAwb = New System.Windows.Forms.TextBox()
        Me.txtCondW2RAdb = New System.Windows.Forms.TextBox()
        Me.txtCondW2OAwb = New System.Windows.Forms.TextBox()
        Me.txtCondW2OAdb = New System.Windows.Forms.TextBox()
        Me.txtCondW2OAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW1SAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondW1RAwb = New System.Windows.Forms.TextBox()
        Me.txtCondW1RAdb = New System.Windows.Forms.TextBox()
        Me.txtCondW1OAwb = New System.Windows.Forms.TextBox()
        Me.txtCondW1OAdb = New System.Windows.Forms.TextBox()
        Me.txtCondW1OAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondS2SAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondS2RAwb = New System.Windows.Forms.TextBox()
        Me.txtCondS2RAdb = New System.Windows.Forms.TextBox()
        Me.txtCondS2OAwb = New System.Windows.Forms.TextBox()
        Me.txtCondS2OAdb = New System.Windows.Forms.TextBox()
        Me.txtCondS2OAFlow = New System.Windows.Forms.TextBox()
        Me.txtCondS1SAFlow = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCondS1RAwb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCondS1RAdb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCondS1OAwb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCondS1OAdb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCondS1OAFlow = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pgAirflowDwg = New System.Windows.Forms.TabPage()
        Me.txtAvailDescription = New System.Windows.Forms.TextBox()
        Me.pboxAirflow = New System.Windows.Forms.PictureBox()
        Me.lstAvailAirflow = New System.Windows.Forms.ListBox()
        Me.btnDoneAirflowDwg = New System.Windows.Forms.Button()
        Me.pgControls = New System.Windows.Forms.TabPage()
        Me.cmdDoneControls = New System.Windows.Forms.Button()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.RadioButton31 = New System.Windows.Forms.RadioButton()
        Me.RadioButton32 = New System.Windows.Forms.RadioButton()
        Me.pgStatic = New System.Windows.Forms.TabPage()
        Me.chkRXStaticTransFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticReliefHoodFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticReliefDamperFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticHWClothFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticERWFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticRAFiltersFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticSafetyFull = New System.Windows.Forms.CheckBox()
        Me.chkRXStaticRAOpeningFull = New System.Windows.Forms.CheckBox()
        Me.cmdXFStaticUpdate = New System.Windows.Forms.Button()
        Me.txtStaticTableFullReturn = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txtStaticTableExhaustAirFlow = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.cmdSFStaticUpdate = New System.Windows.Forms.Button()
        Me.txtStaticTableFreshAirFlow = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.txtSFStaticOADamp = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtRXFStaticTrans = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtRXFStaticTotal = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtRXFStaticCabFX = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.lblRecFanTypeStatic = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtRXFStaticHWCloth = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtRXFStaticRAOpening = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtRXFStaticReliefHood = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtRXFStaticReliefDamp = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtRXFStaticERW = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtRXFStaticRAFilt = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtRXFStaticSafetyGrate = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtSFStaticTrans = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtSFStaticOAHood = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtSFStaticTotal = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtSFStaticCabFX = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtSFStaticERW = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtSFStaticOAFilt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtSFStaticMetalFilt = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cmdDoneStaticTables = New System.Windows.Forms.Button()
        Me.pgPerformance = New System.Windows.Forms.TabPage()
        Me.txtERWElectricalInfo = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmdCalculateMixed = New System.Windows.Forms.Button()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtMixPerfWFFMAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1WLFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1WLdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2MAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1MAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2MAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1WLwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS1MAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1RAFlow = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtMixPerfW1RAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfWFFMAdb = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtMixPerfWFFMixFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1RAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2MAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1MixFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2MixFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW1MAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2MAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2MixFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS1MAdb = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtMixPerfS1MixFlow = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtMixPerfWFFRAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2RAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2RAwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS1RAwb = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtMixPerfWFFRAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfWFFRAFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfWFFWLwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfWFFWLdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfWFFWLFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2RAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2RAFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2WLwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2WLdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfW2WLFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2RAdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2RAFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2WLwb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2WLdb = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS2WLFlow = New System.Windows.Forms.TextBox()
        Me.txtMixPerfS1RAdb = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtMixPerfS1RAFlow = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtMixPerfS1WLwb = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtMixPerfS1WLdb = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtMixPerfS1WLFlow = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPerfWFFTotEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1SAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfW1SAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfW2TotEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1TotEff = New System.Windows.Forms.TextBox()
        Me.txtPerfS2TotEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1SAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfS1TotEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1XAdb = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtPerfW1XAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfWFFLatEff = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPerfWFFSensEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1XAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfW2LatEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1SensEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW2SensEff = New System.Windows.Forms.TextBox()
        Me.txtPerfW1LatEff = New System.Windows.Forms.TextBox()
        Me.txtPerfS2LatEff = New System.Windows.Forms.TextBox()
        Me.txtPerfS2SensEff = New System.Windows.Forms.TextBox()
        Me.txtPerfS1LatEff = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtPerfS1SensEff = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtPerfWFFXAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfW2XAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfS2XAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfS1XAFlow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPerfWFFXAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfWFFXAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfWFFSAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfWFFSAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfWFFSAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfW2XAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfW2XAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfW2SAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfW2SAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfW2SAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfS2XAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfS2XAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfS2SAwb = New System.Windows.Forms.TextBox()
        Me.txtPerfS2SAdb = New System.Windows.Forms.TextBox()
        Me.txtPerfS2SAFlow = New System.Windows.Forms.TextBox()
        Me.txtPerfS1XAwb = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtPerfS1XAdb = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtPerfS1SAwb = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtPerfS1SAdb = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtPerfS1SAFlow = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cmdDonePerformance = New System.Windows.Forms.Button()
        Me.lblUnitVolts = New System.Windows.Forms.Label()
        Me.lblUnitCabinet = New System.Windows.Forms.Label()
        Me.lblUnitSeries = New System.Windows.Forms.Label()
        Me.tbcERW.SuspendLayout()
        Me.pgProposal.SuspendLayout()
        Me.grpXABypassDampers.SuspendLayout()
        Me.grpXABypassHoods.SuspendLayout()
        Me.grpRABPDampers.SuspendLayout()
        Me.grpOABPDampers.SuspendLayout()
        Me.grpOABPHoods.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grpReliefDampers.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pgConditions.SuspendLayout()
        Me.pgAirflowDwg.SuspendLayout()
        CType(Me.pboxAirflow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgControls.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.pgStatic.SuspendLayout()
        Me.pgPerformance.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDryWeight
        '
        Me.txtDryWeight.Enabled = False
        Me.txtDryWeight.Location = New System.Drawing.Point(981, 628)
        Me.txtDryWeight.Name = "txtDryWeight"
        Me.txtDryWeight.Size = New System.Drawing.Size(112, 20)
        Me.txtDryWeight.TabIndex = 65
        Me.txtDryWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1099, 631)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "Dry Weight (lbs)"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(107, 612)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 62
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(3, 612)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 61
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'tbcERW
        '
        Me.tbcERW.Controls.Add(Me.pgProposal)
        Me.tbcERW.Controls.Add(Me.pgConditions)
        Me.tbcERW.Controls.Add(Me.pgAirflowDwg)
        Me.tbcERW.Controls.Add(Me.pgControls)
        Me.tbcERW.Controls.Add(Me.pgStatic)
        Me.tbcERW.Controls.Add(Me.pgPerformance)
        Me.tbcERW.Location = New System.Drawing.Point(12, 13)
        Me.tbcERW.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcERW.Name = "tbcERW"
        Me.tbcERW.SelectedIndex = 0
        Me.tbcERW.Size = New System.Drawing.Size(1169, 544)
        Me.tbcERW.TabIndex = 0
        '
        'pgProposal
        '
        Me.pgProposal.Controls.Add(Me.grpXABypassDampers)
        Me.pgProposal.Controls.Add(Me.grpXABypassHoods)
        Me.pgProposal.Controls.Add(Me.grpRABPDampers)
        Me.pgProposal.Controls.Add(Me.grpOABPDampers)
        Me.pgProposal.Controls.Add(Me.grpOABPHoods)
        Me.pgProposal.Controls.Add(Me.GroupBox13)
        Me.pgProposal.Controls.Add(Me.GroupBox12)
        Me.pgProposal.Controls.Add(Me.Label46)
        Me.pgProposal.Controls.Add(Me.GroupBox11)
        Me.pgProposal.Controls.Add(Me.cmbWheel)
        Me.pgProposal.Controls.Add(Me.GroupBox9)
        Me.pgProposal.Controls.Add(Me.GroupBox8)
        Me.pgProposal.Controls.Add(Me.GroupBox7)
        Me.pgProposal.Controls.Add(Me.grpReliefDampers)
        Me.pgProposal.Controls.Add(Me.chkScopeXABypassDampers)
        Me.pgProposal.Controls.Add(Me.chkScopeRABypassDampers)
        Me.pgProposal.Controls.Add(Me.GroupBox5)
        Me.pgProposal.Controls.Add(Me.GroupBox4)
        Me.pgProposal.Controls.Add(Me.GroupBox2)
        Me.pgProposal.Controls.Add(Me.GroupBox1)
        Me.pgProposal.Controls.Add(Me.btnDoneProposal)
        Me.pgProposal.Controls.Add(Me.chkScopeOABypass)
        Me.pgProposal.Location = New System.Drawing.Point(4, 22)
        Me.pgProposal.Name = "pgProposal"
        Me.pgProposal.Size = New System.Drawing.Size(1161, 518)
        Me.pgProposal.TabIndex = 3
        Me.pgProposal.Text = "Proposal"
        Me.pgProposal.UseVisualStyleBackColor = True
        '
        'grpXABypassDampers
        '
        Me.grpXABypassDampers.Controls.Add(Me.optXABPDamperNone)
        Me.grpXABypassDampers.Controls.Add(Me.optXABPDamperAtmosphere)
        Me.grpXABypassDampers.Controls.Add(Me.optXABPDamperWheel)
        Me.grpXABypassDampers.Enabled = False
        Me.grpXABypassDampers.Location = New System.Drawing.Point(437, 226)
        Me.grpXABypassDampers.Name = "grpXABypassDampers"
        Me.grpXABypassDampers.Size = New System.Drawing.Size(208, 91)
        Me.grpXABypassDampers.TabIndex = 43
        Me.grpXABypassDampers.TabStop = False
        Me.grpXABypassDampers.Text = "Exhaust Air Bypass Damper(s)"
        '
        'optXABPDamperNone
        '
        Me.optXABPDamperNone.AutoSize = True
        Me.optXABPDamperNone.Checked = True
        Me.optXABPDamperNone.Location = New System.Drawing.Point(6, 65)
        Me.optXABPDamperNone.Name = "optXABPDamperNone"
        Me.optXABPDamperNone.Size = New System.Drawing.Size(51, 17)
        Me.optXABPDamperNone.TabIndex = 4
        Me.optXABPDamperNone.TabStop = True
        Me.optXABPDamperNone.Text = "None"
        Me.optXABPDamperNone.UseVisualStyleBackColor = True
        '
        'optXABPDamperAtmosphere
        '
        Me.optXABPDamperAtmosphere.AutoSize = True
        Me.optXABPDamperAtmosphere.Location = New System.Drawing.Point(6, 42)
        Me.optXABPDamperAtmosphere.Name = "optXABPDamperAtmosphere"
        Me.optXABPDamperAtmosphere.Size = New System.Drawing.Size(97, 17)
        Me.optXABPDamperAtmosphere.TabIndex = 3
        Me.optXABPDamperAtmosphere.Text = "To Atmosphere"
        Me.optXABPDamperAtmosphere.UseVisualStyleBackColor = True
        '
        'optXABPDamperWheel
        '
        Me.optXABPDamperWheel.AutoSize = True
        Me.optXABPDamperWheel.Location = New System.Drawing.Point(6, 19)
        Me.optXABPDamperWheel.Name = "optXABPDamperWheel"
        Me.optXABPDamperWheel.Size = New System.Drawing.Size(93, 17)
        Me.optXABPDamperWheel.TabIndex = 2
        Me.optXABPDamperWheel.Text = "Around Wheel"
        Me.optXABPDamperWheel.UseVisualStyleBackColor = True
        '
        'grpXABypassHoods
        '
        Me.grpXABypassHoods.Controls.Add(Me.chkXABPHoodFieldInstalled)
        Me.grpXABypassHoods.Controls.Add(Me.optXABPHoodNone)
        Me.grpXABypassHoods.Controls.Add(Me.chkXABPHoodMesh)
        Me.grpXABypassHoods.Controls.Add(Me.optXABPHoodByFisen)
        Me.grpXABypassHoods.Controls.Add(Me.optXABPHoodReuseJCI)
        Me.grpXABypassHoods.Enabled = False
        Me.grpXABypassHoods.Location = New System.Drawing.Point(437, 126)
        Me.grpXABypassHoods.Name = "grpXABypassHoods"
        Me.grpXABypassHoods.Size = New System.Drawing.Size(208, 89)
        Me.grpXABypassHoods.TabIndex = 42
        Me.grpXABypassHoods.TabStop = False
        Me.grpXABypassHoods.Text = "Exhaust Air Bypass Hood(s)"
        '
        'chkXABPHoodFieldInstalled
        '
        Me.chkXABPHoodFieldInstalled.AutoSize = True
        Me.chkXABPHoodFieldInstalled.Location = New System.Drawing.Point(17, 65)
        Me.chkXABPHoodFieldInstalled.Name = "chkXABPHoodFieldInstalled"
        Me.chkXABPHoodFieldInstalled.Size = New System.Drawing.Size(124, 17)
        Me.chkXABPHoodFieldInstalled.TabIndex = 40
        Me.chkXABPHoodFieldInstalled.Text = "Field Installed Hoods"
        Me.chkXABPHoodFieldInstalled.UseVisualStyleBackColor = True
        '
        'optXABPHoodNone
        '
        Me.optXABPHoodNone.AutoSize = True
        Me.optXABPHoodNone.Checked = True
        Me.optXABPHoodNone.Location = New System.Drawing.Point(147, 20)
        Me.optXABPHoodNone.Name = "optXABPHoodNone"
        Me.optXABPHoodNone.Size = New System.Drawing.Size(51, 17)
        Me.optXABPHoodNone.TabIndex = 39
        Me.optXABPHoodNone.TabStop = True
        Me.optXABPHoodNone.Text = "None"
        Me.optXABPHoodNone.UseVisualStyleBackColor = True
        '
        'chkXABPHoodMesh
        '
        Me.chkXABPHoodMesh.AutoSize = True
        Me.chkXABPHoodMesh.Location = New System.Drawing.Point(17, 42)
        Me.chkXABPHoodMesh.Name = "chkXABPHoodMesh"
        Me.chkXABPHoodMesh.Size = New System.Drawing.Size(124, 17)
        Me.chkXABPHoodMesh.TabIndex = 38
        Me.chkXABPHoodMesh.Text = "1/4"" Hardware Cloth"
        Me.chkXABPHoodMesh.UseVisualStyleBackColor = True
        '
        'optXABPHoodByFisen
        '
        Me.optXABPHoodByFisen.AutoSize = True
        Me.optXABPHoodByFisen.Location = New System.Drawing.Point(80, 19)
        Me.optXABPHoodByFisen.Name = "optXABPHoodByFisen"
        Me.optXABPHoodByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optXABPHoodByFisen.TabIndex = 3
        Me.optXABPHoodByFisen.Text = "By Fisen"
        Me.optXABPHoodByFisen.UseVisualStyleBackColor = True
        '
        'optXABPHoodReuseJCI
        '
        Me.optXABPHoodReuseJCI.AutoSize = True
        Me.optXABPHoodReuseJCI.Location = New System.Drawing.Point(6, 19)
        Me.optXABPHoodReuseJCI.Name = "optXABPHoodReuseJCI"
        Me.optXABPHoodReuseJCI.Size = New System.Drawing.Size(74, 17)
        Me.optXABPHoodReuseJCI.TabIndex = 2
        Me.optXABPHoodReuseJCI.Text = "Reuse JCI"
        Me.optXABPHoodReuseJCI.UseVisualStyleBackColor = True
        '
        'grpRABPDampers
        '
        Me.grpRABPDampers.Controls.Add(Me.optRABPDampersNone)
        Me.grpRABPDampers.Controls.Add(Me.optRABPDampersByFisen)
        Me.grpRABPDampers.Controls.Add(Me.optRABPDampersReuse)
        Me.grpRABPDampers.Location = New System.Drawing.Point(223, 294)
        Me.grpRABPDampers.Name = "grpRABPDampers"
        Me.grpRABPDampers.Size = New System.Drawing.Size(208, 39)
        Me.grpRABPDampers.TabIndex = 41
        Me.grpRABPDampers.TabStop = False
        Me.grpRABPDampers.Text = "Return Air Bypass Damper(s)"
        '
        'optRABPDampersNone
        '
        Me.optRABPDampersNone.AutoSize = True
        Me.optRABPDampersNone.Location = New System.Drawing.Point(147, 16)
        Me.optRABPDampersNone.Name = "optRABPDampersNone"
        Me.optRABPDampersNone.Size = New System.Drawing.Size(51, 17)
        Me.optRABPDampersNone.TabIndex = 40
        Me.optRABPDampersNone.Text = "None"
        Me.optRABPDampersNone.UseVisualStyleBackColor = True
        '
        'optRABPDampersByFisen
        '
        Me.optRABPDampersByFisen.AutoSize = True
        Me.optRABPDampersByFisen.Location = New System.Drawing.Point(80, 16)
        Me.optRABPDampersByFisen.Name = "optRABPDampersByFisen"
        Me.optRABPDampersByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optRABPDampersByFisen.TabIndex = 3
        Me.optRABPDampersByFisen.Text = "By Fisen"
        Me.optRABPDampersByFisen.UseVisualStyleBackColor = True
        '
        'optRABPDampersReuse
        '
        Me.optRABPDampersReuse.AutoSize = True
        Me.optRABPDampersReuse.Checked = True
        Me.optRABPDampersReuse.Location = New System.Drawing.Point(6, 16)
        Me.optRABPDampersReuse.Name = "optRABPDampersReuse"
        Me.optRABPDampersReuse.Size = New System.Drawing.Size(74, 17)
        Me.optRABPDampersReuse.TabIndex = 2
        Me.optRABPDampersReuse.TabStop = True
        Me.optRABPDampersReuse.Text = "Reuse JCI"
        Me.optRABPDampersReuse.UseVisualStyleBackColor = True
        '
        'grpOABPDampers
        '
        Me.grpOABPDampers.Controls.Add(Me.optOABPDampersNone)
        Me.grpOABPDampers.Controls.Add(Me.optOABPDampersByFisen)
        Me.grpOABPDampers.Controls.Add(Me.optOABPDampersReuse)
        Me.grpOABPDampers.Enabled = False
        Me.grpOABPDampers.Location = New System.Drawing.Point(223, 226)
        Me.grpOABPDampers.Name = "grpOABPDampers"
        Me.grpOABPDampers.Size = New System.Drawing.Size(208, 39)
        Me.grpOABPDampers.TabIndex = 40
        Me.grpOABPDampers.TabStop = False
        Me.grpOABPDampers.Text = "Outdoor Air Bypass Damper(s)"
        '
        'optOABPDampersNone
        '
        Me.optOABPDampersNone.AutoSize = True
        Me.optOABPDampersNone.Checked = True
        Me.optOABPDampersNone.Location = New System.Drawing.Point(147, 16)
        Me.optOABPDampersNone.Name = "optOABPDampersNone"
        Me.optOABPDampersNone.Size = New System.Drawing.Size(51, 17)
        Me.optOABPDampersNone.TabIndex = 40
        Me.optOABPDampersNone.TabStop = True
        Me.optOABPDampersNone.Text = "None"
        Me.optOABPDampersNone.UseVisualStyleBackColor = True
        '
        'optOABPDampersByFisen
        '
        Me.optOABPDampersByFisen.AutoSize = True
        Me.optOABPDampersByFisen.Location = New System.Drawing.Point(80, 16)
        Me.optOABPDampersByFisen.Name = "optOABPDampersByFisen"
        Me.optOABPDampersByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optOABPDampersByFisen.TabIndex = 3
        Me.optOABPDampersByFisen.Text = "By Fisen"
        Me.optOABPDampersByFisen.UseVisualStyleBackColor = True
        '
        'optOABPDampersReuse
        '
        Me.optOABPDampersReuse.AutoSize = True
        Me.optOABPDampersReuse.Location = New System.Drawing.Point(6, 16)
        Me.optOABPDampersReuse.Name = "optOABPDampersReuse"
        Me.optOABPDampersReuse.Size = New System.Drawing.Size(74, 17)
        Me.optOABPDampersReuse.TabIndex = 2
        Me.optOABPDampersReuse.Text = "Reuse JCI"
        Me.optOABPDampersReuse.UseVisualStyleBackColor = True
        '
        'grpOABPHoods
        '
        Me.grpOABPHoods.Controls.Add(Me.chkOABPHoodFieldInstalled)
        Me.grpOABPHoods.Controls.Add(Me.optOABPHoodNone)
        Me.grpOABPHoods.Controls.Add(Me.chkOABPHoodMetalFilters)
        Me.grpOABPHoods.Controls.Add(Me.optOABPHoodByFisen)
        Me.grpOABPHoods.Controls.Add(Me.optOABPHoodReuseJCI)
        Me.grpOABPHoods.Enabled = False
        Me.grpOABPHoods.Location = New System.Drawing.Point(223, 126)
        Me.grpOABPHoods.Name = "grpOABPHoods"
        Me.grpOABPHoods.Size = New System.Drawing.Size(208, 89)
        Me.grpOABPHoods.TabIndex = 39
        Me.grpOABPHoods.TabStop = False
        Me.grpOABPHoods.Text = "Outdoor Air Bypass Hood(s)"
        '
        'chkOABPHoodFieldInstalled
        '
        Me.chkOABPHoodFieldInstalled.AutoSize = True
        Me.chkOABPHoodFieldInstalled.Location = New System.Drawing.Point(17, 65)
        Me.chkOABPHoodFieldInstalled.Name = "chkOABPHoodFieldInstalled"
        Me.chkOABPHoodFieldInstalled.Size = New System.Drawing.Size(124, 17)
        Me.chkOABPHoodFieldInstalled.TabIndex = 40
        Me.chkOABPHoodFieldInstalled.Text = "Field Installed Hoods"
        Me.chkOABPHoodFieldInstalled.UseVisualStyleBackColor = True
        '
        'optOABPHoodNone
        '
        Me.optOABPHoodNone.AutoSize = True
        Me.optOABPHoodNone.Checked = True
        Me.optOABPHoodNone.Location = New System.Drawing.Point(147, 20)
        Me.optOABPHoodNone.Name = "optOABPHoodNone"
        Me.optOABPHoodNone.Size = New System.Drawing.Size(51, 17)
        Me.optOABPHoodNone.TabIndex = 39
        Me.optOABPHoodNone.TabStop = True
        Me.optOABPHoodNone.Text = "None"
        Me.optOABPHoodNone.UseVisualStyleBackColor = True
        '
        'chkOABPHoodMetalFilters
        '
        Me.chkOABPHoodMetalFilters.AutoSize = True
        Me.chkOABPHoodMetalFilters.Location = New System.Drawing.Point(17, 42)
        Me.chkOABPHoodMetalFilters.Name = "chkOABPHoodMetalFilters"
        Me.chkOABPHoodMetalFilters.Size = New System.Drawing.Size(150, 17)
        Me.chkOABPHoodMetalFilters.TabIndex = 38
        Me.chkOABPHoodMetalFilters.Text = "1"" Permanent Metal Filters"
        Me.chkOABPHoodMetalFilters.UseVisualStyleBackColor = True
        '
        'optOABPHoodByFisen
        '
        Me.optOABPHoodByFisen.AutoSize = True
        Me.optOABPHoodByFisen.Location = New System.Drawing.Point(80, 19)
        Me.optOABPHoodByFisen.Name = "optOABPHoodByFisen"
        Me.optOABPHoodByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optOABPHoodByFisen.TabIndex = 3
        Me.optOABPHoodByFisen.Text = "By Fisen"
        Me.optOABPHoodByFisen.UseVisualStyleBackColor = True
        '
        'optOABPHoodReuseJCI
        '
        Me.optOABPHoodReuseJCI.AutoSize = True
        Me.optOABPHoodReuseJCI.Location = New System.Drawing.Point(6, 19)
        Me.optOABPHoodReuseJCI.Name = "optOABPHoodReuseJCI"
        Me.optOABPHoodReuseJCI.Size = New System.Drawing.Size(74, 17)
        Me.optOABPHoodReuseJCI.TabIndex = 2
        Me.optOABPHoodReuseJCI.Text = "Reuse JCI"
        Me.optOABPHoodReuseJCI.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.optOADamperNone)
        Me.GroupBox13.Controls.Add(Me.optOADamperReuseJCI)
        Me.GroupBox13.Controls.Add(Me.optOADamperByFisen)
        Me.GroupBox13.Location = New System.Drawing.Point(437, 13)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(208, 39)
        Me.GroupBox13.TabIndex = 38
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Outdoor Air Damper(s)"
        '
        'optOADamperNone
        '
        Me.optOADamperNone.AutoSize = True
        Me.optOADamperNone.Location = New System.Drawing.Point(147, 16)
        Me.optOADamperNone.Name = "optOADamperNone"
        Me.optOADamperNone.Size = New System.Drawing.Size(51, 17)
        Me.optOADamperNone.TabIndex = 41
        Me.optOADamperNone.Text = "None"
        Me.optOADamperNone.UseVisualStyleBackColor = True
        '
        'optOADamperReuseJCI
        '
        Me.optOADamperReuseJCI.AutoSize = True
        Me.optOADamperReuseJCI.Location = New System.Drawing.Point(6, 16)
        Me.optOADamperReuseJCI.Name = "optOADamperReuseJCI"
        Me.optOADamperReuseJCI.Size = New System.Drawing.Size(74, 17)
        Me.optOADamperReuseJCI.TabIndex = 3
        Me.optOADamperReuseJCI.Text = "Reuse JCI"
        Me.optOADamperReuseJCI.UseVisualStyleBackColor = True
        '
        'optOADamperByFisen
        '
        Me.optOADamperByFisen.AutoSize = True
        Me.optOADamperByFisen.Checked = True
        Me.optOADamperByFisen.Location = New System.Drawing.Point(80, 16)
        Me.optOADamperByFisen.Name = "optOADamperByFisen"
        Me.optOADamperByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optOADamperByFisen.TabIndex = 2
        Me.optOADamperByFisen.TabStop = True
        Me.optOADamperByFisen.Text = "By Fisen"
        Me.optOADamperByFisen.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.chkOAHoodFieldInstalled)
        Me.GroupBox12.Controls.Add(Me.chkOAHoodMetalFilters)
        Me.GroupBox12.Controls.Add(Me.optOAHoodByFisen)
        Me.GroupBox12.Controls.Add(Me.optOAHoodReuseJCI)
        Me.GroupBox12.Location = New System.Drawing.Point(223, 8)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(208, 89)
        Me.GroupBox12.TabIndex = 37
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Outdoor Air Hood(s)"
        '
        'chkOAHoodFieldInstalled
        '
        Me.chkOAHoodFieldInstalled.AutoSize = True
        Me.chkOAHoodFieldInstalled.Location = New System.Drawing.Point(17, 65)
        Me.chkOAHoodFieldInstalled.Name = "chkOAHoodFieldInstalled"
        Me.chkOAHoodFieldInstalled.Size = New System.Drawing.Size(124, 17)
        Me.chkOAHoodFieldInstalled.TabIndex = 39
        Me.chkOAHoodFieldInstalled.Text = "Field Installed Hoods"
        Me.chkOAHoodFieldInstalled.UseVisualStyleBackColor = True
        '
        'chkOAHoodMetalFilters
        '
        Me.chkOAHoodMetalFilters.AutoSize = True
        Me.chkOAHoodMetalFilters.Location = New System.Drawing.Point(17, 42)
        Me.chkOAHoodMetalFilters.Name = "chkOAHoodMetalFilters"
        Me.chkOAHoodMetalFilters.Size = New System.Drawing.Size(150, 17)
        Me.chkOAHoodMetalFilters.TabIndex = 38
        Me.chkOAHoodMetalFilters.Text = "1"" Permanent Metal Filters"
        Me.chkOAHoodMetalFilters.UseVisualStyleBackColor = True
        '
        'optOAHoodByFisen
        '
        Me.optOAHoodByFisen.AutoSize = True
        Me.optOAHoodByFisen.Location = New System.Drawing.Point(80, 19)
        Me.optOAHoodByFisen.Name = "optOAHoodByFisen"
        Me.optOAHoodByFisen.Size = New System.Drawing.Size(65, 17)
        Me.optOAHoodByFisen.TabIndex = 3
        Me.optOAHoodByFisen.Text = "By Fisen"
        Me.optOAHoodByFisen.UseVisualStyleBackColor = True
        '
        'optOAHoodReuseJCI
        '
        Me.optOAHoodReuseJCI.AutoSize = True
        Me.optOAHoodReuseJCI.Checked = True
        Me.optOAHoodReuseJCI.Location = New System.Drawing.Point(6, 19)
        Me.optOAHoodReuseJCI.Name = "optOAHoodReuseJCI"
        Me.optOAHoodReuseJCI.Size = New System.Drawing.Size(74, 17)
        Me.optOAHoodReuseJCI.TabIndex = 2
        Me.optOAHoodReuseJCI.TabStop = True
        Me.optOAHoodReuseJCI.Text = "Reuse JCI"
        Me.optOAHoodReuseJCI.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 60)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(85, 13)
        Me.Label46.TabIndex = 36
        Me.Label46.Text = "Wheel Selection"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cmbExtensionList)
        Me.GroupBox11.Controls.Add(Me.optCabinetStandAlone)
        Me.GroupBox11.Controls.Add(Me.optCabinetExtension)
        Me.GroupBox11.Controls.Add(Me.optCabinetInCab)
        Me.GroupBox11.Location = New System.Drawing.Point(899, 8)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(208, 100)
        Me.GroupBox11.TabIndex = 35
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Installation Style"
        '
        'cmbExtensionList
        '
        Me.cmbExtensionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExtensionList.FormattingEnabled = True
        Me.cmbExtensionList.Location = New System.Drawing.Point(6, 40)
        Me.cmbExtensionList.Name = "cmbExtensionList"
        Me.cmbExtensionList.Size = New System.Drawing.Size(196, 21)
        Me.cmbExtensionList.TabIndex = 7
        '
        'optCabinetStandAlone
        '
        Me.optCabinetStandAlone.AutoSize = True
        Me.optCabinetStandAlone.Location = New System.Drawing.Point(83, 19)
        Me.optCabinetStandAlone.Name = "optCabinetStandAlone"
        Me.optCabinetStandAlone.Size = New System.Drawing.Size(79, 17)
        Me.optCabinetStandAlone.TabIndex = 6
        Me.optCabinetStandAlone.Text = "Standalone"
        Me.optCabinetStandAlone.UseVisualStyleBackColor = True
        '
        'optCabinetExtension
        '
        Me.optCabinetExtension.AutoSize = True
        Me.optCabinetExtension.Checked = True
        Me.optCabinetExtension.Location = New System.Drawing.Point(6, 19)
        Me.optCabinetExtension.Name = "optCabinetExtension"
        Me.optCabinetExtension.Size = New System.Drawing.Size(71, 17)
        Me.optCabinetExtension.TabIndex = 5
        Me.optCabinetExtension.TabStop = True
        Me.optCabinetExtension.Text = "Extension"
        Me.optCabinetExtension.UseVisualStyleBackColor = True
        '
        'optCabinetInCab
        '
        Me.optCabinetInCab.AutoSize = True
        Me.optCabinetInCab.Location = New System.Drawing.Point(6, 70)
        Me.optCabinetInCab.Name = "optCabinetInCab"
        Me.optCabinetInCab.Size = New System.Drawing.Size(73, 17)
        Me.optCabinetInCab.TabIndex = 4
        Me.optCabinetInCab.Text = "In Cabinet"
        Me.optCabinetInCab.UseVisualStyleBackColor = True
        '
        'cmbWheel
        '
        Me.cmbWheel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWheel.FormattingEnabled = True
        Me.cmbWheel.Location = New System.Drawing.Point(9, 76)
        Me.cmbWheel.Name = "cmbWheel"
        Me.cmbWheel.Size = New System.Drawing.Size(208, 21)
        Me.cmbWheel.TabIndex = 34
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtSFStaticPressureAllowance)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.optSFanJCI)
        Me.GroupBox9.Controls.Add(Me.optSFanOAFan)
        Me.GroupBox9.Controls.Add(Me.optSFanFisen)
        Me.GroupBox9.Location = New System.Drawing.Point(223, 394)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(208, 120)
        Me.GroupBox9.TabIndex = 33
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Supply Source"
        '
        'txtSFStaticPressureAllowance
        '
        Me.txtSFStaticPressureAllowance.Location = New System.Drawing.Point(6, 91)
        Me.txtSFStaticPressureAllowance.Name = "txtSFStaticPressureAllowance"
        Me.txtSFStaticPressureAllowance.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticPressureAllowance.TabIndex = 27
        Me.txtSFStaticPressureAllowance.Text = "1.00"
        Me.txtSFStaticPressureAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "SP Allowance"
        '
        'optSFanJCI
        '
        Me.optSFanJCI.AutoSize = True
        Me.optSFanJCI.Checked = True
        Me.optSFanJCI.Location = New System.Drawing.Point(6, 68)
        Me.optSFanJCI.Name = "optSFanJCI"
        Me.optSFanJCI.Size = New System.Drawing.Size(110, 17)
        Me.optSFanJCI.TabIndex = 5
        Me.optSFanJCI.TabStop = True
        Me.optSFanJCI.Text = "Supply Fan by JCI"
        Me.optSFanJCI.UseVisualStyleBackColor = True
        '
        'optSFanOAFan
        '
        Me.optSFanOAFan.AutoSize = True
        Me.optSFanOAFan.Location = New System.Drawing.Point(6, 45)
        Me.optSFanOAFan.Name = "optSFanOAFan"
        Me.optSFanOAFan.Size = New System.Drawing.Size(103, 17)
        Me.optSFanOAFan.TabIndex = 4
        Me.optSFanOAFan.Text = "OA Fan by Fisen"
        Me.optSFanOAFan.UseVisualStyleBackColor = True
        '
        'optSFanFisen
        '
        Me.optSFanFisen.AutoSize = True
        Me.optSFanFisen.Location = New System.Drawing.Point(6, 22)
        Me.optSFanFisen.Name = "optSFanFisen"
        Me.optSFanFisen.Size = New System.Drawing.Size(120, 17)
        Me.optSFanFisen.TabIndex = 3
        Me.optSFanFisen.Text = "Supply Fan by Fisen"
        Me.optSFanFisen.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optXFanbyJCI)
        Me.GroupBox8.Controls.Add(Me.txtRFStaticPressureAllowance)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.optRFanbyJCI)
        Me.GroupBox8.Controls.Add(Me.optRFanByFisen)
        Me.GroupBox8.Controls.Add(Me.optXFanByFisen)
        Me.GroupBox8.Location = New System.Drawing.Point(437, 379)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(208, 135)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Exhaust Source"
        '
        'optXFanbyJCI
        '
        Me.optXFanbyJCI.AutoSize = True
        Me.optXFanbyJCI.Location = New System.Drawing.Point(6, 38)
        Me.optXFanbyJCI.Name = "optXFanbyJCI"
        Me.optXFanbyJCI.Size = New System.Drawing.Size(116, 17)
        Me.optXFanbyJCI.TabIndex = 30
        Me.optXFanbyJCI.Text = "Exhaust Fan by JCI"
        Me.optXFanbyJCI.UseVisualStyleBackColor = True
        '
        'txtRFStaticPressureAllowance
        '
        Me.txtRFStaticPressureAllowance.Location = New System.Drawing.Point(6, 106)
        Me.txtRFStaticPressureAllowance.Name = "txtRFStaticPressureAllowance"
        Me.txtRFStaticPressureAllowance.Size = New System.Drawing.Size(67, 20)
        Me.txtRFStaticPressureAllowance.TabIndex = 29
        Me.txtRFStaticPressureAllowance.Text = "-"
        Me.txtRFStaticPressureAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "SP Allowance"
        '
        'optRFanbyJCI
        '
        Me.optRFanbyJCI.AutoSize = True
        Me.optRFanbyJCI.Location = New System.Drawing.Point(6, 84)
        Me.optRFanbyJCI.Name = "optRFanbyJCI"
        Me.optRFanbyJCI.Size = New System.Drawing.Size(110, 17)
        Me.optRFanbyJCI.TabIndex = 5
        Me.optRFanbyJCI.Text = "Return Fan by JCI"
        Me.optRFanbyJCI.UseVisualStyleBackColor = True
        '
        'optRFanByFisen
        '
        Me.optRFanByFisen.AutoSize = True
        Me.optRFanByFisen.Location = New System.Drawing.Point(6, 61)
        Me.optRFanByFisen.Name = "optRFanByFisen"
        Me.optRFanByFisen.Size = New System.Drawing.Size(120, 17)
        Me.optRFanByFisen.TabIndex = 4
        Me.optRFanByFisen.Text = "Return Fan by Fisen"
        Me.optRFanByFisen.UseVisualStyleBackColor = True
        '
        'optXFanByFisen
        '
        Me.optXFanByFisen.AutoSize = True
        Me.optXFanByFisen.Checked = True
        Me.optXFanByFisen.Location = New System.Drawing.Point(6, 15)
        Me.optXFanByFisen.Name = "optXFanByFisen"
        Me.optXFanByFisen.Size = New System.Drawing.Size(126, 17)
        Me.optXFanByFisen.TabIndex = 3
        Me.optXFanByFisen.TabStop = True
        Me.optXFanByFisen.Text = "Exhaust Fan by Fisen"
        Me.optXFanByFisen.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkFiltrationOAMetal)
        Me.GroupBox7.Controls.Add(Me.chkFiltrationRAAngledRack)
        Me.GroupBox7.Controls.Add(Me.chkFiltrationOAAngledRack)
        Me.GroupBox7.Controls.Add(Me.chkFiltrationRAMERV8)
        Me.GroupBox7.Controls.Add(Me.chkFiltrationOAMERV8)
        Me.GroupBox7.Location = New System.Drawing.Point(651, 13)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(208, 137)
        Me.GroupBox7.TabIndex = 31
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filtration"
        '
        'chkFiltrationOAMetal
        '
        Me.chkFiltrationOAMetal.AutoSize = True
        Me.chkFiltrationOAMetal.Checked = True
        Me.chkFiltrationOAMetal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrationOAMetal.Enabled = False
        Me.chkFiltrationOAMetal.Location = New System.Drawing.Point(6, 19)
        Me.chkFiltrationOAMetal.Name = "chkFiltrationOAMetal"
        Me.chkFiltrationOAMetal.Size = New System.Drawing.Size(154, 17)
        Me.chkFiltrationOAMetal.TabIndex = 6
        Me.chkFiltrationOAMetal.Text = "OA Permanent Metal Filters"
        Me.chkFiltrationOAMetal.UseVisualStyleBackColor = True
        '
        'chkFiltrationRAAngledRack
        '
        Me.chkFiltrationRAAngledRack.AutoSize = True
        Me.chkFiltrationRAAngledRack.Enabled = False
        Me.chkFiltrationRAAngledRack.Location = New System.Drawing.Point(20, 111)
        Me.chkFiltrationRAAngledRack.Name = "chkFiltrationRAAngledRack"
        Me.chkFiltrationRAAngledRack.Size = New System.Drawing.Size(136, 17)
        Me.chkFiltrationRAAngledRack.TabIndex = 5
        Me.chkFiltrationRAAngledRack.Text = "RA Filters Angled Rack"
        Me.chkFiltrationRAAngledRack.UseVisualStyleBackColor = True
        '
        'chkFiltrationOAAngledRack
        '
        Me.chkFiltrationOAAngledRack.AutoSize = True
        Me.chkFiltrationOAAngledRack.Enabled = False
        Me.chkFiltrationOAAngledRack.Location = New System.Drawing.Point(20, 65)
        Me.chkFiltrationOAAngledRack.Name = "chkFiltrationOAAngledRack"
        Me.chkFiltrationOAAngledRack.Size = New System.Drawing.Size(136, 17)
        Me.chkFiltrationOAAngledRack.TabIndex = 4
        Me.chkFiltrationOAAngledRack.Text = "OA Filters Angled Rack"
        Me.chkFiltrationOAAngledRack.UseVisualStyleBackColor = True
        '
        'chkFiltrationRAMERV8
        '
        Me.chkFiltrationRAMERV8.AutoSize = True
        Me.chkFiltrationRAMERV8.Location = New System.Drawing.Point(6, 88)
        Me.chkFiltrationRAMERV8.Name = "chkFiltrationRAMERV8"
        Me.chkFiltrationRAMERV8.Size = New System.Drawing.Size(128, 17)
        Me.chkFiltrationRAMERV8.TabIndex = 3
        Me.chkFiltrationRAMERV8.Text = "RA Filters MERV 8 2"""
        Me.chkFiltrationRAMERV8.UseVisualStyleBackColor = True
        '
        'chkFiltrationOAMERV8
        '
        Me.chkFiltrationOAMERV8.AutoSize = True
        Me.chkFiltrationOAMERV8.Location = New System.Drawing.Point(6, 42)
        Me.chkFiltrationOAMERV8.Name = "chkFiltrationOAMERV8"
        Me.chkFiltrationOAMERV8.Size = New System.Drawing.Size(128, 17)
        Me.chkFiltrationOAMERV8.TabIndex = 2
        Me.chkFiltrationOAMERV8.Text = "OA Filters MERV 8 2"""
        Me.chkFiltrationOAMERV8.UseVisualStyleBackColor = True
        '
        'grpReliefDampers
        '
        Me.grpReliefDampers.Controls.Add(Me.optReliefDamperNone)
        Me.grpReliefDampers.Controls.Add(Me.optReliefDamperActuated)
        Me.grpReliefDampers.Controls.Add(Me.optReliefDamperBarometric)
        Me.grpReliefDampers.Enabled = False
        Me.grpReliefDampers.Location = New System.Drawing.Point(437, 323)
        Me.grpReliefDampers.Name = "grpReliefDampers"
        Me.grpReliefDampers.Size = New System.Drawing.Size(208, 50)
        Me.grpReliefDampers.TabIndex = 30
        Me.grpReliefDampers.TabStop = False
        Me.grpReliefDampers.Text = "Relief Dampers"
        '
        'optReliefDamperNone
        '
        Me.optReliefDamperNone.AutoSize = True
        Me.optReliefDamperNone.Checked = True
        Me.optReliefDamperNone.Location = New System.Drawing.Point(136, 19)
        Me.optReliefDamperNone.Name = "optReliefDamperNone"
        Me.optReliefDamperNone.Size = New System.Drawing.Size(51, 17)
        Me.optReliefDamperNone.TabIndex = 3
        Me.optReliefDamperNone.TabStop = True
        Me.optReliefDamperNone.Text = "None"
        Me.optReliefDamperNone.UseVisualStyleBackColor = True
        '
        'optReliefDamperActuated
        '
        Me.optReliefDamperActuated.AutoSize = True
        Me.optReliefDamperActuated.Location = New System.Drawing.Point(62, 19)
        Me.optReliefDamperActuated.Name = "optReliefDamperActuated"
        Me.optReliefDamperActuated.Size = New System.Drawing.Size(68, 17)
        Me.optReliefDamperActuated.TabIndex = 2
        Me.optReliefDamperActuated.Text = "Actuated"
        Me.optReliefDamperActuated.UseVisualStyleBackColor = True
        '
        'optReliefDamperBarometric
        '
        Me.optReliefDamperBarometric.AutoSize = True
        Me.optReliefDamperBarometric.Location = New System.Drawing.Point(6, 19)
        Me.optReliefDamperBarometric.Name = "optReliefDamperBarometric"
        Me.optReliefDamperBarometric.Size = New System.Drawing.Size(50, 17)
        Me.optReliefDamperBarometric.TabIndex = 1
        Me.optReliefDamperBarometric.Text = "Baro."
        Me.optReliefDamperBarometric.UseVisualStyleBackColor = True
        '
        'chkScopeXABypassDampers
        '
        Me.chkScopeXABypassDampers.AutoSize = True
        Me.chkScopeXABypassDampers.Location = New System.Drawing.Point(437, 103)
        Me.chkScopeXABypassDampers.Name = "chkScopeXABypassDampers"
        Me.chkScopeXABypassDampers.Size = New System.Drawing.Size(167, 17)
        Me.chkScopeXABypassDampers.TabIndex = 29
        Me.chkScopeXABypassDampers.Text = "Exhaust Air Bypass Damper(s)"
        Me.chkScopeXABypassDampers.UseVisualStyleBackColor = True
        '
        'chkScopeRABypassDampers
        '
        Me.chkScopeRABypassDampers.AutoSize = True
        Me.chkScopeRABypassDampers.Checked = True
        Me.chkScopeRABypassDampers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScopeRABypassDampers.Location = New System.Drawing.Point(223, 271)
        Me.chkScopeRABypassDampers.Name = "chkScopeRABypassDampers"
        Me.chkScopeRABypassDampers.Size = New System.Drawing.Size(161, 17)
        Me.chkScopeRABypassDampers.TabIndex = 28
        Me.chkScopeRABypassDampers.Text = "Return Air Bypass Damper(s)"
        Me.chkScopeRABypassDampers.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optMultiPointPower)
        Me.GroupBox5.Controls.Add(Me.optSinglePointPower)
        Me.GroupBox5.Location = New System.Drawing.Point(899, 114)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 50)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Power"
        '
        'optMultiPointPower
        '
        Me.optMultiPointPower.AutoSize = True
        Me.optMultiPointPower.Location = New System.Drawing.Point(93, 19)
        Me.optMultiPointPower.Name = "optMultiPointPower"
        Me.optMultiPointPower.Size = New System.Drawing.Size(71, 17)
        Me.optMultiPointPower.TabIndex = 2
        Me.optMultiPointPower.Text = "MultiPoint"
        Me.optMultiPointPower.UseVisualStyleBackColor = True
        '
        'optSinglePointPower
        '
        Me.optSinglePointPower.AutoSize = True
        Me.optSinglePointPower.Checked = True
        Me.optSinglePointPower.Location = New System.Drawing.Point(6, 19)
        Me.optSinglePointPower.Name = "optSinglePointPower"
        Me.optSinglePointPower.Size = New System.Drawing.Size(81, 17)
        Me.optSinglePointPower.TabIndex = 1
        Me.optSinglePointPower.TabStop = True
        Me.optSinglePointPower.Text = "Single Point"
        Me.optSinglePointPower.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optPartialFlow)
        Me.GroupBox4.Controls.Add(Me.optFullFlow)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 196)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 50)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Wheel Flow"
        '
        'optPartialFlow
        '
        Me.optPartialFlow.AutoSize = True
        Me.optPartialFlow.Checked = True
        Me.optPartialFlow.Location = New System.Drawing.Point(93, 19)
        Me.optPartialFlow.Name = "optPartialFlow"
        Me.optPartialFlow.Size = New System.Drawing.Size(54, 17)
        Me.optPartialFlow.TabIndex = 2
        Me.optPartialFlow.TabStop = True
        Me.optPartialFlow.Text = "Partial"
        Me.optPartialFlow.UseVisualStyleBackColor = True
        '
        'optFullFlow
        '
        Me.optFullFlow.AutoSize = True
        Me.optFullFlow.Location = New System.Drawing.Point(6, 19)
        Me.optFullFlow.Name = "optFullFlow"
        Me.optFullFlow.Size = New System.Drawing.Size(41, 17)
        Me.optFullFlow.TabIndex = 1
        Me.optFullFlow.Text = "Full"
        Me.optFullFlow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkERWVFDbyFisen)
        Me.GroupBox2.Controls.Add(Me.chkERWBypassSwitch)
        Me.GroupBox2.Controls.Add(Me.optCSWheel)
        Me.GroupBox2.Controls.Add(Me.optVSWheel)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 87)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wheel Speed"
        '
        'chkERWVFDbyFisen
        '
        Me.chkERWVFDbyFisen.AutoSize = True
        Me.chkERWVFDbyFisen.Checked = True
        Me.chkERWVFDbyFisen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkERWVFDbyFisen.Location = New System.Drawing.Point(26, 41)
        Me.chkERWVFDbyFisen.Name = "chkERWVFDbyFisen"
        Me.chkERWVFDbyFisen.Size = New System.Drawing.Size(149, 17)
        Me.chkERWVFDbyFisen.TabIndex = 4
        Me.chkERWVFDbyFisen.Text = "Fisen Provided ERW VFD"
        Me.chkERWVFDbyFisen.UseVisualStyleBackColor = True
        '
        'chkERWBypassSwitch
        '
        Me.chkERWBypassSwitch.AutoSize = True
        Me.chkERWBypassSwitch.Location = New System.Drawing.Point(26, 64)
        Me.chkERWBypassSwitch.Name = "chkERWBypassSwitch"
        Me.chkERWBypassSwitch.Size = New System.Drawing.Size(128, 17)
        Me.chkERWBypassSwitch.TabIndex = 3
        Me.chkERWBypassSwitch.Text = "Bypass Safety Switch"
        Me.chkERWBypassSwitch.UseVisualStyleBackColor = True
        '
        'optCSWheel
        '
        Me.optCSWheel.AutoSize = True
        Me.optCSWheel.Location = New System.Drawing.Point(90, 19)
        Me.optCSWheel.Name = "optCSWheel"
        Me.optCSWheel.Size = New System.Drawing.Size(67, 17)
        Me.optCSWheel.TabIndex = 2
        Me.optCSWheel.Text = "Constant"
        Me.optCSWheel.UseVisualStyleBackColor = True
        '
        'optVSWheel
        '
        Me.optVSWheel.AutoSize = True
        Me.optVSWheel.Checked = True
        Me.optVSWheel.Location = New System.Drawing.Point(6, 19)
        Me.optVSWheel.Name = "optVSWheel"
        Me.optVSWheel.Size = New System.Drawing.Size(63, 17)
        Me.optVSWheel.TabIndex = 1
        Me.optVSWheel.TabStop = True
        Me.optVSWheel.Text = "Variable"
        Me.optVSWheel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPlasticWheel)
        Me.GroupBox1.Controls.Add(Me.optAlWheel)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 49)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wheel Material"
        '
        'optPlasticWheel
        '
        Me.optPlasticWheel.AutoSize = True
        Me.optPlasticWheel.Location = New System.Drawing.Point(93, 19)
        Me.optPlasticWheel.Name = "optPlasticWheel"
        Me.optPlasticWheel.Size = New System.Drawing.Size(62, 17)
        Me.optPlasticWheel.TabIndex = 2
        Me.optPlasticWheel.Text = "Polymer"
        Me.optPlasticWheel.UseVisualStyleBackColor = True
        '
        'optAlWheel
        '
        Me.optAlWheel.AutoSize = True
        Me.optAlWheel.Checked = True
        Me.optAlWheel.Location = New System.Drawing.Point(6, 19)
        Me.optAlWheel.Name = "optAlWheel"
        Me.optAlWheel.Size = New System.Drawing.Size(70, 17)
        Me.optAlWheel.TabIndex = 1
        Me.optAlWheel.TabStop = True
        Me.optAlWheel.Text = "Aluminum"
        Me.optAlWheel.UseVisualStyleBackColor = True
        '
        'btnDoneProposal
        '
        Me.btnDoneProposal.Location = New System.Drawing.Point(1061, 478)
        Me.btnDoneProposal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneProposal.Name = "btnDoneProposal"
        Me.btnDoneProposal.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneProposal.TabIndex = 20
        Me.btnDoneProposal.Text = ">"
        Me.btnDoneProposal.UseVisualStyleBackColor = True
        '
        'chkScopeOABypass
        '
        Me.chkScopeOABypass.AutoSize = True
        Me.chkScopeOABypass.Location = New System.Drawing.Point(223, 103)
        Me.chkScopeOABypass.Name = "chkScopeOABypass"
        Me.chkScopeOABypass.Size = New System.Drawing.Size(167, 17)
        Me.chkScopeOABypass.TabIndex = 1
        Me.chkScopeOABypass.Text = "Outdoor Air Bypass Damper(s)"
        Me.chkScopeOABypass.UseVisualStyleBackColor = True
        '
        'pgConditions
        '
        Me.pgConditions.Controls.Add(Me.cmdDoneConditions)
        Me.pgConditions.Controls.Add(Me.chkEnaAntiFrostCond)
        Me.pgConditions.Controls.Add(Me.chkEnaAltCond)
        Me.pgConditions.Controls.Add(Me.txtCondWAFRAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW2RAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW1RAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondS2RAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondS1RAFlow)
        Me.pgConditions.Controls.Add(Me.Label33)
        Me.pgConditions.Controls.Add(Me.Label28)
        Me.pgConditions.Controls.Add(Me.Label29)
        Me.pgConditions.Controls.Add(Me.Label30)
        Me.pgConditions.Controls.Add(Me.Label31)
        Me.pgConditions.Controls.Add(Me.Label32)
        Me.pgConditions.Controls.Add(Me.Label20)
        Me.pgConditions.Controls.Add(Me.Label18)
        Me.pgConditions.Controls.Add(Me.Label12)
        Me.pgConditions.Controls.Add(Me.Label11)
        Me.pgConditions.Controls.Add(Me.Label10)
        Me.pgConditions.Controls.Add(Me.txtCondWAFSAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondWAFRAwb)
        Me.pgConditions.Controls.Add(Me.txtCondWAFRAdb)
        Me.pgConditions.Controls.Add(Me.txtCondWAFOAwb)
        Me.pgConditions.Controls.Add(Me.txtCondWAFOAdb)
        Me.pgConditions.Controls.Add(Me.txtCondWAFOAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW2SAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW2RAwb)
        Me.pgConditions.Controls.Add(Me.txtCondW2RAdb)
        Me.pgConditions.Controls.Add(Me.txtCondW2OAwb)
        Me.pgConditions.Controls.Add(Me.txtCondW2OAdb)
        Me.pgConditions.Controls.Add(Me.txtCondW2OAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW1SAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondW1RAwb)
        Me.pgConditions.Controls.Add(Me.txtCondW1RAdb)
        Me.pgConditions.Controls.Add(Me.txtCondW1OAwb)
        Me.pgConditions.Controls.Add(Me.txtCondW1OAdb)
        Me.pgConditions.Controls.Add(Me.txtCondW1OAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondS2SAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondS2RAwb)
        Me.pgConditions.Controls.Add(Me.txtCondS2RAdb)
        Me.pgConditions.Controls.Add(Me.txtCondS2OAwb)
        Me.pgConditions.Controls.Add(Me.txtCondS2OAdb)
        Me.pgConditions.Controls.Add(Me.txtCondS2OAFlow)
        Me.pgConditions.Controls.Add(Me.txtCondS1SAFlow)
        Me.pgConditions.Controls.Add(Me.Label9)
        Me.pgConditions.Controls.Add(Me.txtCondS1RAwb)
        Me.pgConditions.Controls.Add(Me.Label7)
        Me.pgConditions.Controls.Add(Me.txtCondS1RAdb)
        Me.pgConditions.Controls.Add(Me.Label8)
        Me.pgConditions.Controls.Add(Me.txtCondS1OAwb)
        Me.pgConditions.Controls.Add(Me.Label6)
        Me.pgConditions.Controls.Add(Me.txtCondS1OAdb)
        Me.pgConditions.Controls.Add(Me.Label5)
        Me.pgConditions.Controls.Add(Me.txtCondS1OAFlow)
        Me.pgConditions.Controls.Add(Me.Label4)
        Me.pgConditions.Location = New System.Drawing.Point(4, 22)
        Me.pgConditions.Name = "pgConditions"
        Me.pgConditions.Size = New System.Drawing.Size(1161, 518)
        Me.pgConditions.TabIndex = 8
        Me.pgConditions.Text = "Conditions"
        Me.pgConditions.UseVisualStyleBackColor = True
        '
        'cmdDoneConditions
        '
        Me.cmdDoneConditions.Location = New System.Drawing.Point(1061, 478)
        Me.cmdDoneConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneConditions.Name = "cmdDoneConditions"
        Me.cmdDoneConditions.Size = New System.Drawing.Size(96, 36)
        Me.cmdDoneConditions.TabIndex = 37
        Me.cmdDoneConditions.Text = ">"
        Me.cmdDoneConditions.UseVisualStyleBackColor = True
        '
        'chkEnaAntiFrostCond
        '
        Me.chkEnaAntiFrostCond.AutoSize = True
        Me.chkEnaAntiFrostCond.Location = New System.Drawing.Point(473, 228)
        Me.chkEnaAntiFrostCond.Name = "chkEnaAntiFrostCond"
        Me.chkEnaAntiFrostCond.Size = New System.Drawing.Size(158, 17)
        Me.chkEnaAntiFrostCond.TabIndex = 1
        Me.chkEnaAntiFrostCond.Text = "Enable Anti-Frost Conditions"
        Me.chkEnaAntiFrostCond.UseVisualStyleBackColor = True
        '
        'chkEnaAltCond
        '
        Me.chkEnaAltCond.AutoSize = True
        Me.chkEnaAltCond.Location = New System.Drawing.Point(254, 229)
        Me.chkEnaAltCond.Name = "chkEnaAltCond"
        Me.chkEnaAltCond.Size = New System.Drawing.Size(126, 17)
        Me.chkEnaAltCond.TabIndex = 0
        Me.chkEnaAltCond.Text = "Enable Alt Conditions"
        Me.chkEnaAltCond.UseVisualStyleBackColor = True
        '
        'txtCondWAFRAFlow
        '
        Me.txtCondWAFRAFlow.Enabled = False
        Me.txtCondWAFRAFlow.Location = New System.Drawing.Point(473, 150)
        Me.txtCondWAFRAFlow.Name = "txtCondWAFRAFlow"
        Me.txtCondWAFRAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFRAFlow.TabIndex = 34
        Me.txtCondWAFRAFlow.Text = "-"
        Me.txtCondWAFRAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2RAFlow
        '
        Me.txtCondW2RAFlow.Enabled = False
        Me.txtCondW2RAFlow.Location = New System.Drawing.Point(400, 150)
        Me.txtCondW2RAFlow.Name = "txtCondW2RAFlow"
        Me.txtCondW2RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2RAFlow.TabIndex = 27
        Me.txtCondW2RAFlow.Text = "-"
        Me.txtCondW2RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1RAFlow
        '
        Me.txtCondW1RAFlow.Location = New System.Drawing.Point(327, 151)
        Me.txtCondW1RAFlow.Name = "txtCondW1RAFlow"
        Me.txtCondW1RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1RAFlow.TabIndex = 20
        Me.txtCondW1RAFlow.Text = "6000"
        Me.txtCondW1RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2RAFlow
        '
        Me.txtCondS2RAFlow.Enabled = False
        Me.txtCondS2RAFlow.Location = New System.Drawing.Point(254, 151)
        Me.txtCondS2RAFlow.Name = "txtCondS2RAFlow"
        Me.txtCondS2RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2RAFlow.TabIndex = 13
        Me.txtCondS2RAFlow.Text = "-"
        Me.txtCondS2RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS1RAFlow
        '
        Me.txtCondS1RAFlow.Location = New System.Drawing.Point(181, 152)
        Me.txtCondS1RAFlow.Name = "txtCondS1RAFlow"
        Me.txtCondS1RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1RAFlow.TabIndex = 6
        Me.txtCondS1RAFlow.Text = "6000"
        Me.txtCondS1RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(20, 151)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(155, 20)
        Me.Label33.TabIndex = 74
        Me.Label33.Text = "Wheel Return Airflow (cfm)"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(414, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 13)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "Winter"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(338, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 13)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "Winter"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(268, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 13)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "Summer"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(192, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 70
        Me.Label31.Text = "Summer"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(487, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 13)
        Me.Label32.TabIndex = 69
        Me.Label32.Text = "Winter"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(403, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "Condition 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(330, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Condition 1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(257, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Condition 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(184, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Condition 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(481, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Anti-Frost"
        '
        'txtCondWAFSAFlow
        '
        Me.txtCondWAFSAFlow.Enabled = False
        Me.txtCondWAFSAFlow.Location = New System.Drawing.Point(473, 46)
        Me.txtCondWAFSAFlow.Name = "txtCondWAFSAFlow"
        Me.txtCondWAFSAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFSAFlow.TabIndex = 30
        Me.txtCondWAFSAFlow.Text = "-"
        Me.txtCondWAFSAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondWAFRAwb
        '
        Me.txtCondWAFRAwb.Enabled = False
        Me.txtCondWAFRAwb.Location = New System.Drawing.Point(473, 202)
        Me.txtCondWAFRAwb.Name = "txtCondWAFRAwb"
        Me.txtCondWAFRAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFRAwb.TabIndex = 36
        Me.txtCondWAFRAwb.Text = "-"
        Me.txtCondWAFRAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondWAFRAdb
        '
        Me.txtCondWAFRAdb.Enabled = False
        Me.txtCondWAFRAdb.Location = New System.Drawing.Point(473, 176)
        Me.txtCondWAFRAdb.Name = "txtCondWAFRAdb"
        Me.txtCondWAFRAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFRAdb.TabIndex = 35
        Me.txtCondWAFRAdb.Text = "-"
        Me.txtCondWAFRAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondWAFOAwb
        '
        Me.txtCondWAFOAwb.Enabled = False
        Me.txtCondWAFOAwb.Location = New System.Drawing.Point(473, 124)
        Me.txtCondWAFOAwb.Name = "txtCondWAFOAwb"
        Me.txtCondWAFOAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFOAwb.TabIndex = 33
        Me.txtCondWAFOAwb.Text = "-"
        Me.txtCondWAFOAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondWAFOAdb
        '
        Me.txtCondWAFOAdb.Enabled = False
        Me.txtCondWAFOAdb.Location = New System.Drawing.Point(473, 98)
        Me.txtCondWAFOAdb.Name = "txtCondWAFOAdb"
        Me.txtCondWAFOAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFOAdb.TabIndex = 32
        Me.txtCondWAFOAdb.Text = "-"
        Me.txtCondWAFOAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondWAFOAFlow
        '
        Me.txtCondWAFOAFlow.Enabled = False
        Me.txtCondWAFOAFlow.Location = New System.Drawing.Point(473, 72)
        Me.txtCondWAFOAFlow.Name = "txtCondWAFOAFlow"
        Me.txtCondWAFOAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondWAFOAFlow.TabIndex = 31
        Me.txtCondWAFOAFlow.Text = "-"
        Me.txtCondWAFOAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2SAFlow
        '
        Me.txtCondW2SAFlow.Enabled = False
        Me.txtCondW2SAFlow.Location = New System.Drawing.Point(400, 46)
        Me.txtCondW2SAFlow.Name = "txtCondW2SAFlow"
        Me.txtCondW2SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2SAFlow.TabIndex = 23
        Me.txtCondW2SAFlow.Text = "-"
        Me.txtCondW2SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2RAwb
        '
        Me.txtCondW2RAwb.Enabled = False
        Me.txtCondW2RAwb.Location = New System.Drawing.Point(400, 202)
        Me.txtCondW2RAwb.Name = "txtCondW2RAwb"
        Me.txtCondW2RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2RAwb.TabIndex = 29
        Me.txtCondW2RAwb.Text = "-"
        Me.txtCondW2RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2RAdb
        '
        Me.txtCondW2RAdb.Enabled = False
        Me.txtCondW2RAdb.Location = New System.Drawing.Point(400, 176)
        Me.txtCondW2RAdb.Name = "txtCondW2RAdb"
        Me.txtCondW2RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2RAdb.TabIndex = 28
        Me.txtCondW2RAdb.Text = "-"
        Me.txtCondW2RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2OAwb
        '
        Me.txtCondW2OAwb.Enabled = False
        Me.txtCondW2OAwb.Location = New System.Drawing.Point(400, 124)
        Me.txtCondW2OAwb.Name = "txtCondW2OAwb"
        Me.txtCondW2OAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2OAwb.TabIndex = 26
        Me.txtCondW2OAwb.Text = "-"
        Me.txtCondW2OAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2OAdb
        '
        Me.txtCondW2OAdb.Enabled = False
        Me.txtCondW2OAdb.Location = New System.Drawing.Point(400, 98)
        Me.txtCondW2OAdb.Name = "txtCondW2OAdb"
        Me.txtCondW2OAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2OAdb.TabIndex = 25
        Me.txtCondW2OAdb.Text = "-"
        Me.txtCondW2OAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW2OAFlow
        '
        Me.txtCondW2OAFlow.Enabled = False
        Me.txtCondW2OAFlow.Location = New System.Drawing.Point(400, 72)
        Me.txtCondW2OAFlow.Name = "txtCondW2OAFlow"
        Me.txtCondW2OAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW2OAFlow.TabIndex = 24
        Me.txtCondW2OAFlow.Text = "-"
        Me.txtCondW2OAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1SAFlow
        '
        Me.txtCondW1SAFlow.Location = New System.Drawing.Point(327, 47)
        Me.txtCondW1SAFlow.Name = "txtCondW1SAFlow"
        Me.txtCondW1SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1SAFlow.TabIndex = 16
        Me.txtCondW1SAFlow.Text = "6000"
        Me.txtCondW1SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1RAwb
        '
        Me.txtCondW1RAwb.Location = New System.Drawing.Point(327, 203)
        Me.txtCondW1RAwb.Name = "txtCondW1RAwb"
        Me.txtCondW1RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1RAwb.TabIndex = 22
        Me.txtCondW1RAwb.Text = "64"
        Me.txtCondW1RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1RAdb
        '
        Me.txtCondW1RAdb.Location = New System.Drawing.Point(327, 177)
        Me.txtCondW1RAdb.Name = "txtCondW1RAdb"
        Me.txtCondW1RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1RAdb.TabIndex = 21
        Me.txtCondW1RAdb.Text = "70"
        Me.txtCondW1RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1OAwb
        '
        Me.txtCondW1OAwb.Location = New System.Drawing.Point(327, 125)
        Me.txtCondW1OAwb.Name = "txtCondW1OAwb"
        Me.txtCondW1OAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1OAwb.TabIndex = 19
        Me.txtCondW1OAwb.Text = "31"
        Me.txtCondW1OAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1OAdb
        '
        Me.txtCondW1OAdb.Location = New System.Drawing.Point(327, 99)
        Me.txtCondW1OAdb.Name = "txtCondW1OAdb"
        Me.txtCondW1OAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1OAdb.TabIndex = 18
        Me.txtCondW1OAdb.Text = "32"
        Me.txtCondW1OAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondW1OAFlow
        '
        Me.txtCondW1OAFlow.Location = New System.Drawing.Point(327, 73)
        Me.txtCondW1OAFlow.Name = "txtCondW1OAFlow"
        Me.txtCondW1OAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondW1OAFlow.TabIndex = 17
        Me.txtCondW1OAFlow.Text = "6000"
        Me.txtCondW1OAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2SAFlow
        '
        Me.txtCondS2SAFlow.Enabled = False
        Me.txtCondS2SAFlow.Location = New System.Drawing.Point(254, 47)
        Me.txtCondS2SAFlow.Name = "txtCondS2SAFlow"
        Me.txtCondS2SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2SAFlow.TabIndex = 9
        Me.txtCondS2SAFlow.Text = "-"
        Me.txtCondS2SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2RAwb
        '
        Me.txtCondS2RAwb.Enabled = False
        Me.txtCondS2RAwb.Location = New System.Drawing.Point(254, 203)
        Me.txtCondS2RAwb.Name = "txtCondS2RAwb"
        Me.txtCondS2RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2RAwb.TabIndex = 15
        Me.txtCondS2RAwb.Text = "-"
        Me.txtCondS2RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2RAdb
        '
        Me.txtCondS2RAdb.Enabled = False
        Me.txtCondS2RAdb.Location = New System.Drawing.Point(254, 177)
        Me.txtCondS2RAdb.Name = "txtCondS2RAdb"
        Me.txtCondS2RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2RAdb.TabIndex = 14
        Me.txtCondS2RAdb.Text = "-"
        Me.txtCondS2RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2OAwb
        '
        Me.txtCondS2OAwb.Enabled = False
        Me.txtCondS2OAwb.Location = New System.Drawing.Point(254, 125)
        Me.txtCondS2OAwb.Name = "txtCondS2OAwb"
        Me.txtCondS2OAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2OAwb.TabIndex = 12
        Me.txtCondS2OAwb.Text = "-"
        Me.txtCondS2OAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2OAdb
        '
        Me.txtCondS2OAdb.Enabled = False
        Me.txtCondS2OAdb.Location = New System.Drawing.Point(254, 99)
        Me.txtCondS2OAdb.Name = "txtCondS2OAdb"
        Me.txtCondS2OAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2OAdb.TabIndex = 11
        Me.txtCondS2OAdb.Text = "-"
        Me.txtCondS2OAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS2OAFlow
        '
        Me.txtCondS2OAFlow.Enabled = False
        Me.txtCondS2OAFlow.Location = New System.Drawing.Point(254, 73)
        Me.txtCondS2OAFlow.Name = "txtCondS2OAFlow"
        Me.txtCondS2OAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS2OAFlow.TabIndex = 10
        Me.txtCondS2OAFlow.Text = "-"
        Me.txtCondS2OAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCondS1SAFlow
        '
        Me.txtCondS1SAFlow.Location = New System.Drawing.Point(181, 48)
        Me.txtCondS1SAFlow.Name = "txtCondS1SAFlow"
        Me.txtCondS1SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1SAFlow.TabIndex = 2
        Me.txtCondS1SAFlow.Text = "6000"
        Me.txtCondS1SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Wheel Supply Airflow (cfm)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCondS1RAwb
        '
        Me.txtCondS1RAwb.Location = New System.Drawing.Point(181, 204)
        Me.txtCondS1RAwb.Name = "txtCondS1RAwb"
        Me.txtCondS1RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1RAwb.TabIndex = 8
        Me.txtCondS1RAwb.Text = "64"
        Me.txtCondS1RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "RA Temp. WB (°F)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCondS1RAdb
        '
        Me.txtCondS1RAdb.Location = New System.Drawing.Point(181, 178)
        Me.txtCondS1RAdb.Name = "txtCondS1RAdb"
        Me.txtCondS1RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1RAdb.TabIndex = 7
        Me.txtCondS1RAdb.Text = "70"
        Me.txtCondS1RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "RA Temp. DB (°F)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCondS1OAwb
        '
        Me.txtCondS1OAwb.Location = New System.Drawing.Point(181, 126)
        Me.txtCondS1OAwb.Name = "txtCondS1OAwb"
        Me.txtCondS1OAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1OAwb.TabIndex = 5
        Me.txtCondS1OAwb.Text = "60"
        Me.txtCondS1OAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "OA Temp. WB (°F)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCondS1OAdb
        '
        Me.txtCondS1OAdb.Location = New System.Drawing.Point(181, 100)
        Me.txtCondS1OAdb.Name = "txtCondS1OAdb"
        Me.txtCondS1OAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1OAdb.TabIndex = 4
        Me.txtCondS1OAdb.Text = "80"
        Me.txtCondS1OAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "OA Temp. DB (°F)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCondS1OAFlow
        '
        Me.txtCondS1OAFlow.Location = New System.Drawing.Point(181, 74)
        Me.txtCondS1OAFlow.Name = "txtCondS1OAFlow"
        Me.txtCondS1OAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtCondS1OAFlow.TabIndex = 3
        Me.txtCondS1OAFlow.Text = "6000"
        Me.txtCondS1OAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "OA Airflow (cfm)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgAirflowDwg
        '
        Me.pgAirflowDwg.Controls.Add(Me.txtAvailDescription)
        Me.pgAirflowDwg.Controls.Add(Me.pboxAirflow)
        Me.pgAirflowDwg.Controls.Add(Me.lstAvailAirflow)
        Me.pgAirflowDwg.Controls.Add(Me.btnDoneAirflowDwg)
        Me.pgAirflowDwg.Location = New System.Drawing.Point(4, 22)
        Me.pgAirflowDwg.Name = "pgAirflowDwg"
        Me.pgAirflowDwg.Size = New System.Drawing.Size(1161, 518)
        Me.pgAirflowDwg.TabIndex = 7
        Me.pgAirflowDwg.Text = "Airflow Drawing"
        Me.pgAirflowDwg.UseVisualStyleBackColor = True
        '
        'txtAvailDescription
        '
        Me.txtAvailDescription.Location = New System.Drawing.Point(23, 261)
        Me.txtAvailDescription.Multiline = True
        Me.txtAvailDescription.Name = "txtAvailDescription"
        Me.txtAvailDescription.Size = New System.Drawing.Size(391, 207)
        Me.txtAvailDescription.TabIndex = 29
        '
        'pboxAirflow
        '
        Me.pboxAirflow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pboxAirflow.Location = New System.Drawing.Point(420, 29)
        Me.pboxAirflow.Name = "pboxAirflow"
        Me.pboxAirflow.Size = New System.Drawing.Size(737, 439)
        Me.pboxAirflow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxAirflow.TabIndex = 24
        Me.pboxAirflow.TabStop = False
        '
        'lstAvailAirflow
        '
        Me.lstAvailAirflow.FormattingEnabled = True
        Me.lstAvailAirflow.Location = New System.Drawing.Point(23, 29)
        Me.lstAvailAirflow.Name = "lstAvailAirflow"
        Me.lstAvailAirflow.Size = New System.Drawing.Size(391, 212)
        Me.lstAvailAirflow.TabIndex = 20
        '
        'btnDoneAirflowDwg
        '
        Me.btnDoneAirflowDwg.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDoneAirflowDwg.Location = New System.Drawing.Point(1061, 475)
        Me.btnDoneAirflowDwg.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneAirflowDwg.Name = "btnDoneAirflowDwg"
        Me.btnDoneAirflowDwg.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneAirflowDwg.TabIndex = 21
        Me.btnDoneAirflowDwg.Text = ">"
        Me.btnDoneAirflowDwg.UseVisualStyleBackColor = True
        '
        'pgControls
        '
        Me.pgControls.Controls.Add(Me.cmdDoneControls)
        Me.pgControls.Controls.Add(Me.GroupBox19)
        Me.pgControls.Location = New System.Drawing.Point(4, 22)
        Me.pgControls.Margin = New System.Windows.Forms.Padding(4)
        Me.pgControls.Name = "pgControls"
        Me.pgControls.Size = New System.Drawing.Size(1161, 518)
        Me.pgControls.TabIndex = 2
        Me.pgControls.Text = "Controls"
        Me.pgControls.UseVisualStyleBackColor = True
        '
        'cmdDoneControls
        '
        Me.cmdDoneControls.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDoneControls.Location = New System.Drawing.Point(1061, 478)
        Me.cmdDoneControls.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneControls.Name = "cmdDoneControls"
        Me.cmdDoneControls.Size = New System.Drawing.Size(96, 36)
        Me.cmdDoneControls.TabIndex = 39
        Me.cmdDoneControls.Text = ">"
        Me.cmdDoneControls.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.CheckBox12)
        Me.GroupBox19.Controls.Add(Me.CheckBox13)
        Me.GroupBox19.Controls.Add(Me.RadioButton31)
        Me.GroupBox19.Controls.Add(Me.RadioButton32)
        Me.GroupBox19.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(208, 89)
        Me.GroupBox19.TabIndex = 38
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Outdoor Air Damper Actuators"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(17, 65)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox12.TabIndex = 39
        Me.CheckBox12.Text = "Prove Open"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(17, 42)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox13.TabIndex = 38
        Me.CheckBox13.Text = "Modulating"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'RadioButton31
        '
        Me.RadioButton31.AutoSize = True
        Me.RadioButton31.Location = New System.Drawing.Point(80, 19)
        Me.RadioButton31.Name = "RadioButton31"
        Me.RadioButton31.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton31.TabIndex = 3
        Me.RadioButton31.Text = "By Fisen"
        Me.RadioButton31.UseVisualStyleBackColor = True
        '
        'RadioButton32
        '
        Me.RadioButton32.AutoSize = True
        Me.RadioButton32.Checked = True
        Me.RadioButton32.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton32.Name = "RadioButton32"
        Me.RadioButton32.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton32.TabIndex = 2
        Me.RadioButton32.TabStop = True
        Me.RadioButton32.Text = "Reuse JCI"
        Me.RadioButton32.UseVisualStyleBackColor = True
        '
        'pgStatic
        '
        Me.pgStatic.Controls.Add(Me.chkRXStaticTransFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticReliefHoodFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticReliefDamperFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticHWClothFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticERWFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticRAFiltersFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticSafetyFull)
        Me.pgStatic.Controls.Add(Me.chkRXStaticRAOpeningFull)
        Me.pgStatic.Controls.Add(Me.cmdXFStaticUpdate)
        Me.pgStatic.Controls.Add(Me.txtStaticTableFullReturn)
        Me.pgStatic.Controls.Add(Me.Label88)
        Me.pgStatic.Controls.Add(Me.txtStaticTableExhaustAirFlow)
        Me.pgStatic.Controls.Add(Me.Label87)
        Me.pgStatic.Controls.Add(Me.cmdSFStaticUpdate)
        Me.pgStatic.Controls.Add(Me.txtStaticTableFreshAirFlow)
        Me.pgStatic.Controls.Add(Me.Label86)
        Me.pgStatic.Controls.Add(Me.txtSFStaticOADamp)
        Me.pgStatic.Controls.Add(Me.Label66)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticTrans)
        Me.pgStatic.Controls.Add(Me.Label63)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticTotal)
        Me.pgStatic.Controls.Add(Me.Label64)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticCabFX)
        Me.pgStatic.Controls.Add(Me.Label65)
        Me.pgStatic.Controls.Add(Me.Label62)
        Me.pgStatic.Controls.Add(Me.Label61)
        Me.pgStatic.Controls.Add(Me.lblRecFanTypeStatic)
        Me.pgStatic.Controls.Add(Me.Label60)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticHWCloth)
        Me.pgStatic.Controls.Add(Me.Label51)
        Me.pgStatic.Controls.Add(Me.Label52)
        Me.pgStatic.Controls.Add(Me.Label53)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticRAOpening)
        Me.pgStatic.Controls.Add(Me.Label54)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticReliefHood)
        Me.pgStatic.Controls.Add(Me.Label55)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticReliefDamp)
        Me.pgStatic.Controls.Add(Me.Label56)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticERW)
        Me.pgStatic.Controls.Add(Me.Label57)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticRAFilt)
        Me.pgStatic.Controls.Add(Me.Label58)
        Me.pgStatic.Controls.Add(Me.txtRXFStaticSafetyGrate)
        Me.pgStatic.Controls.Add(Me.Label59)
        Me.pgStatic.Controls.Add(Me.txtSFStaticTrans)
        Me.pgStatic.Controls.Add(Me.Label25)
        Me.pgStatic.Controls.Add(Me.Label27)
        Me.pgStatic.Controls.Add(Me.Label38)
        Me.pgStatic.Controls.Add(Me.txtSFStaticOAHood)
        Me.pgStatic.Controls.Add(Me.Label39)
        Me.pgStatic.Controls.Add(Me.txtSFStaticTotal)
        Me.pgStatic.Controls.Add(Me.Label40)
        Me.pgStatic.Controls.Add(Me.txtSFStaticCabFX)
        Me.pgStatic.Controls.Add(Me.Label41)
        Me.pgStatic.Controls.Add(Me.txtSFStaticERW)
        Me.pgStatic.Controls.Add(Me.Label48)
        Me.pgStatic.Controls.Add(Me.txtSFStaticOAFilt)
        Me.pgStatic.Controls.Add(Me.Label49)
        Me.pgStatic.Controls.Add(Me.txtSFStaticMetalFilt)
        Me.pgStatic.Controls.Add(Me.Label50)
        Me.pgStatic.Controls.Add(Me.cmdDoneStaticTables)
        Me.pgStatic.Location = New System.Drawing.Point(4, 22)
        Me.pgStatic.Name = "pgStatic"
        Me.pgStatic.Size = New System.Drawing.Size(1161, 518)
        Me.pgStatic.TabIndex = 9
        Me.pgStatic.Text = "Static Tables"
        Me.pgStatic.UseVisualStyleBackColor = True
        '
        'chkRXStaticTransFull
        '
        Me.chkRXStaticTransFull.AutoSize = True
        Me.chkRXStaticTransFull.Location = New System.Drawing.Point(684, 287)
        Me.chkRXStaticTransFull.Name = "chkRXStaticTransFull"
        Me.chkRXStaticTransFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticTransFull.TabIndex = 223
        Me.chkRXStaticTransFull.Text = "Full Flow"
        Me.chkRXStaticTransFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticReliefHoodFull
        '
        Me.chkRXStaticReliefHoodFull.AutoSize = True
        Me.chkRXStaticReliefHoodFull.Location = New System.Drawing.Point(684, 261)
        Me.chkRXStaticReliefHoodFull.Name = "chkRXStaticReliefHoodFull"
        Me.chkRXStaticReliefHoodFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticReliefHoodFull.TabIndex = 222
        Me.chkRXStaticReliefHoodFull.Text = "Full Flow"
        Me.chkRXStaticReliefHoodFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticReliefDamperFull
        '
        Me.chkRXStaticReliefDamperFull.AutoSize = True
        Me.chkRXStaticReliefDamperFull.Location = New System.Drawing.Point(684, 235)
        Me.chkRXStaticReliefDamperFull.Name = "chkRXStaticReliefDamperFull"
        Me.chkRXStaticReliefDamperFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticReliefDamperFull.TabIndex = 221
        Me.chkRXStaticReliefDamperFull.Text = "Full Flow"
        Me.chkRXStaticReliefDamperFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticHWClothFull
        '
        Me.chkRXStaticHWClothFull.AutoSize = True
        Me.chkRXStaticHWClothFull.Location = New System.Drawing.Point(684, 209)
        Me.chkRXStaticHWClothFull.Name = "chkRXStaticHWClothFull"
        Me.chkRXStaticHWClothFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticHWClothFull.TabIndex = 220
        Me.chkRXStaticHWClothFull.Text = "Full Flow"
        Me.chkRXStaticHWClothFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticERWFull
        '
        Me.chkRXStaticERWFull.AutoSize = True
        Me.chkRXStaticERWFull.Location = New System.Drawing.Point(684, 183)
        Me.chkRXStaticERWFull.Name = "chkRXStaticERWFull"
        Me.chkRXStaticERWFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticERWFull.TabIndex = 219
        Me.chkRXStaticERWFull.Text = "Full Flow"
        Me.chkRXStaticERWFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticRAFiltersFull
        '
        Me.chkRXStaticRAFiltersFull.AutoSize = True
        Me.chkRXStaticRAFiltersFull.Location = New System.Drawing.Point(684, 157)
        Me.chkRXStaticRAFiltersFull.Name = "chkRXStaticRAFiltersFull"
        Me.chkRXStaticRAFiltersFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticRAFiltersFull.TabIndex = 218
        Me.chkRXStaticRAFiltersFull.Text = "Full Flow"
        Me.chkRXStaticRAFiltersFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticSafetyFull
        '
        Me.chkRXStaticSafetyFull.AutoSize = True
        Me.chkRXStaticSafetyFull.Checked = True
        Me.chkRXStaticSafetyFull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRXStaticSafetyFull.Location = New System.Drawing.Point(684, 131)
        Me.chkRXStaticSafetyFull.Name = "chkRXStaticSafetyFull"
        Me.chkRXStaticSafetyFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticSafetyFull.TabIndex = 217
        Me.chkRXStaticSafetyFull.Text = "Full Flow"
        Me.chkRXStaticSafetyFull.UseVisualStyleBackColor = True
        '
        'chkRXStaticRAOpeningFull
        '
        Me.chkRXStaticRAOpeningFull.AutoSize = True
        Me.chkRXStaticRAOpeningFull.Checked = True
        Me.chkRXStaticRAOpeningFull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRXStaticRAOpeningFull.Location = New System.Drawing.Point(684, 105)
        Me.chkRXStaticRAOpeningFull.Name = "chkRXStaticRAOpeningFull"
        Me.chkRXStaticRAOpeningFull.Size = New System.Drawing.Size(67, 17)
        Me.chkRXStaticRAOpeningFull.TabIndex = 216
        Me.chkRXStaticRAOpeningFull.Text = "Full Flow"
        Me.chkRXStaticRAOpeningFull.UseVisualStyleBackColor = True
        '
        'cmdXFStaticUpdate
        '
        Me.cmdXFStaticUpdate.Location = New System.Drawing.Point(684, 336)
        Me.cmdXFStaticUpdate.Name = "cmdXFStaticUpdate"
        Me.cmdXFStaticUpdate.Size = New System.Drawing.Size(52, 20)
        Me.cmdXFStaticUpdate.TabIndex = 215
        Me.cmdXFStaticUpdate.Text = "Calc"
        Me.cmdXFStaticUpdate.UseVisualStyleBackColor = True
        '
        'txtStaticTableFullReturn
        '
        Me.txtStaticTableFullReturn.Location = New System.Drawing.Point(684, 77)
        Me.txtStaticTableFullReturn.Name = "txtStaticTableFullReturn"
        Me.txtStaticTableFullReturn.Size = New System.Drawing.Size(67, 20)
        Me.txtStaticTableFullReturn.TabIndex = 213
        Me.txtStaticTableFullReturn.Text = "0"
        Me.txtStaticTableFullReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(661, 50)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(116, 20)
        Me.Label88.TabIndex = 214
        Me.Label88.Text = "Full Return Flow (cfm)"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaticTableExhaustAirFlow
        '
        Me.txtStaticTableExhaustAirFlow.Location = New System.Drawing.Point(374, 21)
        Me.txtStaticTableExhaustAirFlow.Name = "txtStaticTableExhaustAirFlow"
        Me.txtStaticTableExhaustAirFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtStaticTableExhaustAirFlow.TabIndex = 211
        Me.txtStaticTableExhaustAirFlow.Text = "0"
        Me.txtStaticTableExhaustAirFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(252, 20)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(116, 20)
        Me.Label87.TabIndex = 212
        Me.Label87.Text = "Exhaust Air Flow (cfm)"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSFStaticUpdate
        '
        Me.cmdSFStaticUpdate.Location = New System.Drawing.Point(237, 284)
        Me.cmdSFStaticUpdate.Name = "cmdSFStaticUpdate"
        Me.cmdSFStaticUpdate.Size = New System.Drawing.Size(52, 20)
        Me.cmdSFStaticUpdate.TabIndex = 210
        Me.cmdSFStaticUpdate.Text = "Calc"
        Me.cmdSFStaticUpdate.UseVisualStyleBackColor = True
        '
        'txtStaticTableFreshAirFlow
        '
        Me.txtStaticTableFreshAirFlow.Location = New System.Drawing.Point(164, 22)
        Me.txtStaticTableFreshAirFlow.Name = "txtStaticTableFreshAirFlow"
        Me.txtStaticTableFreshAirFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtStaticTableFreshAirFlow.TabIndex = 0
        Me.txtStaticTableFreshAirFlow.Text = "0"
        Me.txtStaticTableFreshAirFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(3, 21)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(155, 20)
        Me.Label86.TabIndex = 120
        Me.Label86.Text = "Fresh Air Flow (cfm)"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticOADamp
        '
        Me.txtSFStaticOADamp.Location = New System.Drawing.Point(164, 154)
        Me.txtSFStaticOADamp.Name = "txtSFStaticOADamp"
        Me.txtSFStaticOADamp.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticOADamp.TabIndex = 3
        Me.txtSFStaticOADamp.Text = "0.00"
        Me.txtSFStaticOADamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(3, 153)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(155, 20)
        Me.Label66.TabIndex = 118
        Me.Label66.Text = "OA Damper (iwc)"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticTrans
        '
        Me.txtRXFStaticTrans.Location = New System.Drawing.Point(611, 284)
        Me.txtRXFStaticTrans.Name = "txtRXFStaticTrans"
        Me.txtRXFStaticTrans.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticTrans.TabIndex = 14
        Me.txtRXFStaticTrans.Text = "0.00"
        Me.txtRXFStaticTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(450, 283)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(155, 20)
        Me.Label63.TabIndex = 116
        Me.Label63.Text = "Transitions (iwc)"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticTotal
        '
        Me.txtRXFStaticTotal.Enabled = False
        Me.txtRXFStaticTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRXFStaticTotal.Location = New System.Drawing.Point(611, 336)
        Me.txtRXFStaticTotal.Name = "txtRXFStaticTotal"
        Me.txtRXFStaticTotal.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticTotal.TabIndex = 113
        Me.txtRXFStaticTotal.Text = "0.00"
        Me.txtRXFStaticTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(450, 335)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(155, 20)
        Me.Label64.TabIndex = 115
        Me.Label64.Text = "Module Total (iwc)"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticCabFX
        '
        Me.txtRXFStaticCabFX.Enabled = False
        Me.txtRXFStaticCabFX.Location = New System.Drawing.Point(611, 310)
        Me.txtRXFStaticCabFX.Name = "txtRXFStaticCabFX"
        Me.txtRXFStaticCabFX.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticCabFX.TabIndex = 112
        Me.txtRXFStaticCabFX.Text = "0.00"
        Me.txtRXFStaticCabFX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(450, 309)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(155, 20)
        Me.Label65.TabIndex = 114
        Me.Label65.Text = "Cabinet Effects (iwc)"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(556, 45)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(71, 13)
        Me.Label62.TabIndex = 110
        Me.Label62.Text = "ERW Module"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(105, 45)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(71, 13)
        Me.Label61.TabIndex = 109
        Me.Label61.Text = "ERW Module"
        '
        'lblRecFanTypeStatic
        '
        Me.lblRecFanTypeStatic.AutoSize = True
        Me.lblRecFanTypeStatic.Location = New System.Drawing.Point(562, 58)
        Me.lblRecFanTypeStatic.Name = "lblRecFanTypeStatic"
        Me.lblRecFanTypeStatic.Size = New System.Drawing.Size(60, 13)
        Me.lblRecFanTypeStatic.TabIndex = 108
        Me.lblRecFanTypeStatic.Text = "Return Fan"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(109, 58)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(60, 13)
        Me.Label60.TabIndex = 107
        Me.Label60.Text = "Supply Fan"
        '
        'txtRXFStaticHWCloth
        '
        Me.txtRXFStaticHWCloth.Location = New System.Drawing.Point(611, 206)
        Me.txtRXFStaticHWCloth.Name = "txtRXFStaticHWCloth"
        Me.txtRXFStaticHWCloth.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticHWCloth.TabIndex = 11
        Me.txtRXFStaticHWCloth.Text = "0.00"
        Me.txtRXFStaticHWCloth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(450, 205)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(155, 20)
        Me.Label51.TabIndex = 106
        Me.Label51.Text = "Hardware Cloth (iwc)"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(622, 71)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(34, 13)
        Me.Label52.TabIndex = 105
        Me.Label52.Text = "Static"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(614, 84)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(48, 13)
        Me.Label53.TabIndex = 104
        Me.Label53.Text = "Pressure"
        '
        'txtRXFStaticRAOpening
        '
        Me.txtRXFStaticRAOpening.Location = New System.Drawing.Point(611, 102)
        Me.txtRXFStaticRAOpening.Name = "txtRXFStaticRAOpening"
        Me.txtRXFStaticRAOpening.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticRAOpening.TabIndex = 7
        Me.txtRXFStaticRAOpening.Text = "0.00"
        Me.txtRXFStaticRAOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(450, 101)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(155, 20)
        Me.Label54.TabIndex = 103
        Me.Label54.Text = "Return Air Opening"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticReliefHood
        '
        Me.txtRXFStaticReliefHood.Location = New System.Drawing.Point(611, 258)
        Me.txtRXFStaticReliefHood.Name = "txtRXFStaticReliefHood"
        Me.txtRXFStaticReliefHood.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticReliefHood.TabIndex = 13
        Me.txtRXFStaticReliefHood.Text = "0.00"
        Me.txtRXFStaticReliefHood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(450, 257)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(155, 20)
        Me.Label55.TabIndex = 102
        Me.Label55.Text = "Relief Hood (iwc)"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticReliefDamp
        '
        Me.txtRXFStaticReliefDamp.Location = New System.Drawing.Point(611, 232)
        Me.txtRXFStaticReliefDamp.Name = "txtRXFStaticReliefDamp"
        Me.txtRXFStaticReliefDamp.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticReliefDamp.TabIndex = 12
        Me.txtRXFStaticReliefDamp.Text = "0.00"
        Me.txtRXFStaticReliefDamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(450, 231)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(155, 20)
        Me.Label56.TabIndex = 101
        Me.Label56.Text = "Relief Damper (iwc)"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticERW
        '
        Me.txtRXFStaticERW.Location = New System.Drawing.Point(611, 180)
        Me.txtRXFStaticERW.Name = "txtRXFStaticERW"
        Me.txtRXFStaticERW.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticERW.TabIndex = 10
        Me.txtRXFStaticERW.Text = "0.00"
        Me.txtRXFStaticERW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(450, 179)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(155, 20)
        Me.Label57.TabIndex = 100
        Me.Label57.Text = "Energy Recovery Wheel (iwc)"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticRAFilt
        '
        Me.txtRXFStaticRAFilt.Location = New System.Drawing.Point(611, 154)
        Me.txtRXFStaticRAFilt.Name = "txtRXFStaticRAFilt"
        Me.txtRXFStaticRAFilt.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticRAFilt.TabIndex = 9
        Me.txtRXFStaticRAFilt.Text = "0.00"
        Me.txtRXFStaticRAFilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(450, 153)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(155, 20)
        Me.Label58.TabIndex = 99
        Me.Label58.Text = "Return Air Filters (iwc)"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRXFStaticSafetyGrate
        '
        Me.txtRXFStaticSafetyGrate.Location = New System.Drawing.Point(611, 128)
        Me.txtRXFStaticSafetyGrate.Name = "txtRXFStaticSafetyGrate"
        Me.txtRXFStaticSafetyGrate.Size = New System.Drawing.Size(67, 20)
        Me.txtRXFStaticSafetyGrate.TabIndex = 8
        Me.txtRXFStaticSafetyGrate.Text = "0.00"
        Me.txtRXFStaticSafetyGrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(450, 127)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(155, 20)
        Me.Label59.TabIndex = 98
        Me.Label59.Text = "Safety Grate (iwc)"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticTrans
        '
        Me.txtSFStaticTrans.Location = New System.Drawing.Point(164, 232)
        Me.txtSFStaticTrans.Name = "txtSFStaticTrans"
        Me.txtSFStaticTrans.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticTrans.TabIndex = 6
        Me.txtSFStaticTrans.Text = "0.00"
        Me.txtSFStaticTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(3, 231)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(155, 20)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "Transitions (iwc)"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(175, 71)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 13)
        Me.Label27.TabIndex = 89
        Me.Label27.Text = "Static"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(167, 84)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 13)
        Me.Label38.TabIndex = 88
        Me.Label38.Text = "Pressure"
        '
        'txtSFStaticOAHood
        '
        Me.txtSFStaticOAHood.Location = New System.Drawing.Point(164, 102)
        Me.txtSFStaticOAHood.Name = "txtSFStaticOAHood"
        Me.txtSFStaticOAHood.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticOAHood.TabIndex = 1
        Me.txtSFStaticOAHood.Text = "0.00"
        Me.txtSFStaticOAHood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(3, 101)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(155, 20)
        Me.Label39.TabIndex = 87
        Me.Label39.Text = "Outdoor Air Hood (iwc)"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticTotal
        '
        Me.txtSFStaticTotal.Enabled = False
        Me.txtSFStaticTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSFStaticTotal.Location = New System.Drawing.Point(164, 284)
        Me.txtSFStaticTotal.Name = "txtSFStaticTotal"
        Me.txtSFStaticTotal.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticTotal.TabIndex = 81
        Me.txtSFStaticTotal.Text = "0.00"
        Me.txtSFStaticTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(3, 283)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(155, 20)
        Me.Label40.TabIndex = 86
        Me.Label40.Text = "Module Total (iwc)"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticCabFX
        '
        Me.txtSFStaticCabFX.Enabled = False
        Me.txtSFStaticCabFX.Location = New System.Drawing.Point(164, 258)
        Me.txtSFStaticCabFX.Name = "txtSFStaticCabFX"
        Me.txtSFStaticCabFX.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticCabFX.TabIndex = 80
        Me.txtSFStaticCabFX.Text = "0.00"
        Me.txtSFStaticCabFX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(3, 257)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(155, 20)
        Me.Label41.TabIndex = 85
        Me.Label41.Text = "Cabinet Effects (iwc)"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticERW
        '
        Me.txtSFStaticERW.Location = New System.Drawing.Point(164, 206)
        Me.txtSFStaticERW.Name = "txtSFStaticERW"
        Me.txtSFStaticERW.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticERW.TabIndex = 5
        Me.txtSFStaticERW.Text = "0.00"
        Me.txtSFStaticERW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(3, 205)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(155, 20)
        Me.Label48.TabIndex = 84
        Me.Label48.Text = "Energy Recovery Wheel (iwc)"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticOAFilt
        '
        Me.txtSFStaticOAFilt.Location = New System.Drawing.Point(164, 180)
        Me.txtSFStaticOAFilt.Name = "txtSFStaticOAFilt"
        Me.txtSFStaticOAFilt.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticOAFilt.TabIndex = 4
        Me.txtSFStaticOAFilt.Text = "0.00"
        Me.txtSFStaticOAFilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(3, 179)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(155, 20)
        Me.Label49.TabIndex = 83
        Me.Label49.Text = "Outdoor Air Filters (iwc)"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSFStaticMetalFilt
        '
        Me.txtSFStaticMetalFilt.Location = New System.Drawing.Point(164, 128)
        Me.txtSFStaticMetalFilt.Name = "txtSFStaticMetalFilt"
        Me.txtSFStaticMetalFilt.Size = New System.Drawing.Size(67, 20)
        Me.txtSFStaticMetalFilt.TabIndex = 2
        Me.txtSFStaticMetalFilt.Text = "0.00"
        Me.txtSFStaticMetalFilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(3, 127)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(155, 20)
        Me.Label50.TabIndex = 82
        Me.Label50.Text = "Metal Filters (iwc)"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDoneStaticTables
        '
        Me.cmdDoneStaticTables.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDoneStaticTables.Location = New System.Drawing.Point(1061, 478)
        Me.cmdDoneStaticTables.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoneStaticTables.Name = "cmdDoneStaticTables"
        Me.cmdDoneStaticTables.Size = New System.Drawing.Size(96, 36)
        Me.cmdDoneStaticTables.TabIndex = 15
        Me.cmdDoneStaticTables.Text = ">"
        Me.cmdDoneStaticTables.UseVisualStyleBackColor = True
        '
        'pgPerformance
        '
        Me.pgPerformance.Controls.Add(Me.txtERWElectricalInfo)
        Me.pgPerformance.Controls.Add(Me.Label47)
        Me.pgPerformance.Controls.Add(Me.Button4)
        Me.pgPerformance.Controls.Add(Me.GroupBox10)
        Me.pgPerformance.Controls.Add(Me.GroupBox3)
        Me.pgPerformance.Controls.Add(Me.cmdDonePerformance)
        Me.pgPerformance.Location = New System.Drawing.Point(4, 22)
        Me.pgPerformance.Name = "pgPerformance"
        Me.pgPerformance.Size = New System.Drawing.Size(1161, 518)
        Me.pgPerformance.TabIndex = 4
        Me.pgPerformance.Text = "Performance"
        Me.pgPerformance.UseVisualStyleBackColor = True
        '
        'txtERWElectricalInfo
        '
        Me.txtERWElectricalInfo.Location = New System.Drawing.Point(116, 456)
        Me.txtERWElectricalInfo.Name = "txtERWElectricalInfo"
        Me.txtERWElectricalInfo.Size = New System.Drawing.Size(256, 20)
        Me.txtERWElectricalInfo.TabIndex = 0
        Me.txtERWElectricalInfo.Text = "Unspecified"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(10, 459)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 13)
        Me.Label47.TabIndex = 37
        Me.Label47.Text = "ERW Electrical Info"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(917, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 30)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Load BOM from Template"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmdCalculateMixed)
        Me.GroupBox10.Controls.Add(Me.Label67)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFMAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1WLFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1WLdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2MAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1MAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2MAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1WLwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1MAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1RAFlow)
        Me.GroupBox10.Controls.Add(Me.Label68)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1RAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFMAdb)
        Me.GroupBox10.Controls.Add(Me.Label69)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFMixFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1RAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2MAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1MixFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2MixFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW1MAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2MAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2MixFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1MAdb)
        Me.GroupBox10.Controls.Add(Me.Label70)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1MixFlow)
        Me.GroupBox10.Controls.Add(Me.Label71)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFRAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2RAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2RAwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1RAwb)
        Me.GroupBox10.Controls.Add(Me.Label72)
        Me.GroupBox10.Controls.Add(Me.Label73)
        Me.GroupBox10.Controls.Add(Me.Label74)
        Me.GroupBox10.Controls.Add(Me.Label75)
        Me.GroupBox10.Controls.Add(Me.Label76)
        Me.GroupBox10.Controls.Add(Me.Label77)
        Me.GroupBox10.Controls.Add(Me.Label78)
        Me.GroupBox10.Controls.Add(Me.Label79)
        Me.GroupBox10.Controls.Add(Me.Label80)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFRAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFRAFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFWLwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFWLdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfWFFWLFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2RAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2RAFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2WLwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2WLdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfW2WLFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2RAdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2RAFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2WLwb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2WLdb)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS2WLFlow)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1RAdb)
        Me.GroupBox10.Controls.Add(Me.Label81)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1RAFlow)
        Me.GroupBox10.Controls.Add(Me.Label82)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1WLwb)
        Me.GroupBox10.Controls.Add(Me.Label83)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1WLdb)
        Me.GroupBox10.Controls.Add(Me.Label84)
        Me.GroupBox10.Controls.Add(Me.txtMixPerfS1WLFlow)
        Me.GroupBox10.Controls.Add(Me.Label85)
        Me.GroupBox10.Location = New System.Drawing.Point(603, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(554, 286)
        Me.GroupBox10.TabIndex = 23
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Air Mixing Performance"
        '
        'cmdCalculateMixed
        '
        Me.cmdCalculateMixed.Location = New System.Drawing.Point(19, 222)
        Me.cmdCalculateMixed.Name = "cmdCalculateMixed"
        Me.cmdCalculateMixed.Size = New System.Drawing.Size(52, 20)
        Me.cmdCalculateMixed.TabIndex = 209
        Me.cmdCalculateMixed.Text = "Calc"
        Me.cmdCalculateMixed.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(337, 12)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(38, 13)
        Me.Label67.TabIndex = 187
        Me.Label67.Text = "Winter"
        '
        'txtMixPerfWFFMAwb
        '
        Me.txtMixPerfWFFMAwb.Enabled = False
        Me.txtMixPerfWFFMAwb.Location = New System.Drawing.Point(469, 248)
        Me.txtMixPerfWFFMAwb.Name = "txtMixPerfWFFMAwb"
        Me.txtMixPerfWFFMAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFMAwb.TabIndex = 44
        Me.txtMixPerfWFFMAwb.Text = "-"
        Me.txtMixPerfWFFMAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1WLFlow
        '
        Me.txtMixPerfW1WLFlow.Location = New System.Drawing.Point(323, 40)
        Me.txtMixPerfW1WLFlow.Name = "txtMixPerfW1WLFlow"
        Me.txtMixPerfW1WLFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1WLFlow.TabIndex = 18
        Me.txtMixPerfW1WLFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1WLdb
        '
        Me.txtMixPerfW1WLdb.Location = New System.Drawing.Point(323, 66)
        Me.txtMixPerfW1WLdb.Name = "txtMixPerfW1WLdb"
        Me.txtMixPerfW1WLdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1WLdb.TabIndex = 19
        Me.txtMixPerfW1WLdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2MAwb
        '
        Me.txtMixPerfW2MAwb.Enabled = False
        Me.txtMixPerfW2MAwb.Location = New System.Drawing.Point(396, 248)
        Me.txtMixPerfW2MAwb.Name = "txtMixPerfW2MAwb"
        Me.txtMixPerfW2MAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2MAwb.TabIndex = 35
        Me.txtMixPerfW2MAwb.Text = "-"
        Me.txtMixPerfW2MAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1MAwb
        '
        Me.txtMixPerfW1MAwb.Location = New System.Drawing.Point(323, 248)
        Me.txtMixPerfW1MAwb.Name = "txtMixPerfW1MAwb"
        Me.txtMixPerfW1MAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1MAwb.TabIndex = 26
        Me.txtMixPerfW1MAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2MAwb
        '
        Me.txtMixPerfS2MAwb.Enabled = False
        Me.txtMixPerfS2MAwb.Location = New System.Drawing.Point(250, 248)
        Me.txtMixPerfS2MAwb.Name = "txtMixPerfS2MAwb"
        Me.txtMixPerfS2MAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2MAwb.TabIndex = 17
        Me.txtMixPerfS2MAwb.Text = "-"
        Me.txtMixPerfS2MAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1WLwb
        '
        Me.txtMixPerfW1WLwb.Location = New System.Drawing.Point(323, 92)
        Me.txtMixPerfW1WLwb.Name = "txtMixPerfW1WLwb"
        Me.txtMixPerfW1WLwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1WLwb.TabIndex = 20
        Me.txtMixPerfW1WLwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS1MAwb
        '
        Me.txtMixPerfS1MAwb.Location = New System.Drawing.Point(177, 248)
        Me.txtMixPerfS1MAwb.Name = "txtMixPerfS1MAwb"
        Me.txtMixPerfS1MAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1MAwb.TabIndex = 8
        Me.txtMixPerfS1MAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1RAFlow
        '
        Me.txtMixPerfW1RAFlow.Location = New System.Drawing.Point(323, 118)
        Me.txtMixPerfW1RAFlow.Name = "txtMixPerfW1RAFlow"
        Me.txtMixPerfW1RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1RAFlow.TabIndex = 21
        Me.txtMixPerfW1RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(16, 247)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(155, 20)
        Me.Label68.TabIndex = 208
        Me.Label68.Text = "MA Temp. WB (°F)"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfW1RAdb
        '
        Me.txtMixPerfW1RAdb.Location = New System.Drawing.Point(323, 144)
        Me.txtMixPerfW1RAdb.Name = "txtMixPerfW1RAdb"
        Me.txtMixPerfW1RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1RAdb.TabIndex = 22
        Me.txtMixPerfW1RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfWFFMAdb
        '
        Me.txtMixPerfWFFMAdb.Enabled = False
        Me.txtMixPerfWFFMAdb.Location = New System.Drawing.Point(469, 222)
        Me.txtMixPerfWFFMAdb.Name = "txtMixPerfWFFMAdb"
        Me.txtMixPerfWFFMAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFMAdb.TabIndex = 43
        Me.txtMixPerfWFFMAdb.Text = "-"
        Me.txtMixPerfWFFMAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(326, 25)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(60, 13)
        Me.Label69.TabIndex = 182
        Me.Label69.Text = "Condition 1"
        '
        'txtMixPerfWFFMixFlow
        '
        Me.txtMixPerfWFFMixFlow.Enabled = False
        Me.txtMixPerfWFFMixFlow.Location = New System.Drawing.Point(469, 196)
        Me.txtMixPerfWFFMixFlow.Name = "txtMixPerfWFFMixFlow"
        Me.txtMixPerfWFFMixFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFMixFlow.TabIndex = 42
        Me.txtMixPerfWFFMixFlow.Text = "-"
        Me.txtMixPerfWFFMixFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1RAwb
        '
        Me.txtMixPerfW1RAwb.Location = New System.Drawing.Point(323, 170)
        Me.txtMixPerfW1RAwb.Name = "txtMixPerfW1RAwb"
        Me.txtMixPerfW1RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1RAwb.TabIndex = 23
        Me.txtMixPerfW1RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2MAdb
        '
        Me.txtMixPerfW2MAdb.Enabled = False
        Me.txtMixPerfW2MAdb.Location = New System.Drawing.Point(396, 222)
        Me.txtMixPerfW2MAdb.Name = "txtMixPerfW2MAdb"
        Me.txtMixPerfW2MAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2MAdb.TabIndex = 34
        Me.txtMixPerfW2MAdb.Text = "-"
        Me.txtMixPerfW2MAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1MixFlow
        '
        Me.txtMixPerfW1MixFlow.Location = New System.Drawing.Point(323, 196)
        Me.txtMixPerfW1MixFlow.Name = "txtMixPerfW1MixFlow"
        Me.txtMixPerfW1MixFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1MixFlow.TabIndex = 24
        Me.txtMixPerfW1MixFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2MixFlow
        '
        Me.txtMixPerfW2MixFlow.Enabled = False
        Me.txtMixPerfW2MixFlow.Location = New System.Drawing.Point(396, 196)
        Me.txtMixPerfW2MixFlow.Name = "txtMixPerfW2MixFlow"
        Me.txtMixPerfW2MixFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2MixFlow.TabIndex = 33
        Me.txtMixPerfW2MixFlow.Text = "-"
        Me.txtMixPerfW2MixFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW1MAdb
        '
        Me.txtMixPerfW1MAdb.Location = New System.Drawing.Point(323, 222)
        Me.txtMixPerfW1MAdb.Name = "txtMixPerfW1MAdb"
        Me.txtMixPerfW1MAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW1MAdb.TabIndex = 25
        Me.txtMixPerfW1MAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2MAdb
        '
        Me.txtMixPerfS2MAdb.Enabled = False
        Me.txtMixPerfS2MAdb.Location = New System.Drawing.Point(250, 222)
        Me.txtMixPerfS2MAdb.Name = "txtMixPerfS2MAdb"
        Me.txtMixPerfS2MAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2MAdb.TabIndex = 16
        Me.txtMixPerfS2MAdb.Text = "-"
        Me.txtMixPerfS2MAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2MixFlow
        '
        Me.txtMixPerfS2MixFlow.Enabled = False
        Me.txtMixPerfS2MixFlow.Location = New System.Drawing.Point(250, 196)
        Me.txtMixPerfS2MixFlow.Name = "txtMixPerfS2MixFlow"
        Me.txtMixPerfS2MixFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2MixFlow.TabIndex = 15
        Me.txtMixPerfS2MixFlow.Text = "-"
        Me.txtMixPerfS2MixFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS1MAdb
        '
        Me.txtMixPerfS1MAdb.Location = New System.Drawing.Point(177, 222)
        Me.txtMixPerfS1MAdb.Name = "txtMixPerfS1MAdb"
        Me.txtMixPerfS1MAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1MAdb.TabIndex = 7
        Me.txtMixPerfS1MAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(16, 221)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(155, 20)
        Me.Label70.TabIndex = 198
        Me.Label70.Text = "MA Temp. DB (°F)"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfS1MixFlow
        '
        Me.txtMixPerfS1MixFlow.Location = New System.Drawing.Point(177, 196)
        Me.txtMixPerfS1MixFlow.Name = "txtMixPerfS1MixFlow"
        Me.txtMixPerfS1MixFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1MixFlow.TabIndex = 6
        Me.txtMixPerfS1MixFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(16, 195)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(155, 20)
        Me.Label71.TabIndex = 196
        Me.Label71.Text = "Mixed Air Flow (cfm)"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfWFFRAwb
        '
        Me.txtMixPerfWFFRAwb.Enabled = False
        Me.txtMixPerfWFFRAwb.Location = New System.Drawing.Point(469, 170)
        Me.txtMixPerfWFFRAwb.Name = "txtMixPerfWFFRAwb"
        Me.txtMixPerfWFFRAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFRAwb.TabIndex = 41
        Me.txtMixPerfWFFRAwb.Text = "-"
        Me.txtMixPerfWFFRAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2RAwb
        '
        Me.txtMixPerfW2RAwb.Enabled = False
        Me.txtMixPerfW2RAwb.Location = New System.Drawing.Point(396, 170)
        Me.txtMixPerfW2RAwb.Name = "txtMixPerfW2RAwb"
        Me.txtMixPerfW2RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2RAwb.TabIndex = 32
        Me.txtMixPerfW2RAwb.Text = "-"
        Me.txtMixPerfW2RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2RAwb
        '
        Me.txtMixPerfS2RAwb.Enabled = False
        Me.txtMixPerfS2RAwb.Location = New System.Drawing.Point(250, 170)
        Me.txtMixPerfS2RAwb.Name = "txtMixPerfS2RAwb"
        Me.txtMixPerfS2RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2RAwb.TabIndex = 14
        Me.txtMixPerfS2RAwb.Text = "-"
        Me.txtMixPerfS2RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS1RAwb
        '
        Me.txtMixPerfS1RAwb.Location = New System.Drawing.Point(177, 170)
        Me.txtMixPerfS1RAwb.Name = "txtMixPerfS1RAwb"
        Me.txtMixPerfS1RAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1RAwb.TabIndex = 5
        Me.txtMixPerfS1RAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(16, 169)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(155, 20)
        Me.Label72.TabIndex = 190
        Me.Label72.Text = "RA Temp. WB (°F)"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(410, 13)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(38, 13)
        Me.Label73.TabIndex = 189
        Me.Label73.Text = "Winter"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(261, 12)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(45, 13)
        Me.Label74.TabIndex = 188
        Me.Label74.Text = "Summer"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(188, 11)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(45, 13)
        Me.Label75.TabIndex = 186
        Me.Label75.Text = "Summer"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(483, 13)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(38, 13)
        Me.Label76.TabIndex = 185
        Me.Label76.Text = "Winter"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(399, 26)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(60, 13)
        Me.Label77.TabIndex = 184
        Me.Label77.Text = "Condition 2"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(253, 25)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(60, 13)
        Me.Label78.TabIndex = 183
        Me.Label78.Text = "Condition 2"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(180, 24)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(60, 13)
        Me.Label79.TabIndex = 181
        Me.Label79.Text = "Condition 1"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(477, 26)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(51, 13)
        Me.Label80.TabIndex = 180
        Me.Label80.Text = "Anti-Frost"
        '
        'txtMixPerfWFFRAdb
        '
        Me.txtMixPerfWFFRAdb.Enabled = False
        Me.txtMixPerfWFFRAdb.Location = New System.Drawing.Point(469, 144)
        Me.txtMixPerfWFFRAdb.Name = "txtMixPerfWFFRAdb"
        Me.txtMixPerfWFFRAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFRAdb.TabIndex = 40
        Me.txtMixPerfWFFRAdb.Text = "-"
        Me.txtMixPerfWFFRAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfWFFRAFlow
        '
        Me.txtMixPerfWFFRAFlow.Enabled = False
        Me.txtMixPerfWFFRAFlow.Location = New System.Drawing.Point(469, 118)
        Me.txtMixPerfWFFRAFlow.Name = "txtMixPerfWFFRAFlow"
        Me.txtMixPerfWFFRAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFRAFlow.TabIndex = 39
        Me.txtMixPerfWFFRAFlow.Text = "-"
        Me.txtMixPerfWFFRAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfWFFWLwb
        '
        Me.txtMixPerfWFFWLwb.Enabled = False
        Me.txtMixPerfWFFWLwb.Location = New System.Drawing.Point(469, 92)
        Me.txtMixPerfWFFWLwb.Name = "txtMixPerfWFFWLwb"
        Me.txtMixPerfWFFWLwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFWLwb.TabIndex = 38
        Me.txtMixPerfWFFWLwb.Text = "-"
        Me.txtMixPerfWFFWLwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfWFFWLdb
        '
        Me.txtMixPerfWFFWLdb.Enabled = False
        Me.txtMixPerfWFFWLdb.Location = New System.Drawing.Point(469, 66)
        Me.txtMixPerfWFFWLdb.Name = "txtMixPerfWFFWLdb"
        Me.txtMixPerfWFFWLdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFWLdb.TabIndex = 37
        Me.txtMixPerfWFFWLdb.Text = "-"
        Me.txtMixPerfWFFWLdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfWFFWLFlow
        '
        Me.txtMixPerfWFFWLFlow.Enabled = False
        Me.txtMixPerfWFFWLFlow.Location = New System.Drawing.Point(469, 40)
        Me.txtMixPerfWFFWLFlow.Name = "txtMixPerfWFFWLFlow"
        Me.txtMixPerfWFFWLFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfWFFWLFlow.TabIndex = 36
        Me.txtMixPerfWFFWLFlow.Text = "-"
        Me.txtMixPerfWFFWLFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2RAdb
        '
        Me.txtMixPerfW2RAdb.Enabled = False
        Me.txtMixPerfW2RAdb.Location = New System.Drawing.Point(396, 144)
        Me.txtMixPerfW2RAdb.Name = "txtMixPerfW2RAdb"
        Me.txtMixPerfW2RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2RAdb.TabIndex = 31
        Me.txtMixPerfW2RAdb.Text = "-"
        Me.txtMixPerfW2RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2RAFlow
        '
        Me.txtMixPerfW2RAFlow.Enabled = False
        Me.txtMixPerfW2RAFlow.Location = New System.Drawing.Point(396, 118)
        Me.txtMixPerfW2RAFlow.Name = "txtMixPerfW2RAFlow"
        Me.txtMixPerfW2RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2RAFlow.TabIndex = 30
        Me.txtMixPerfW2RAFlow.Text = "-"
        Me.txtMixPerfW2RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2WLwb
        '
        Me.txtMixPerfW2WLwb.Enabled = False
        Me.txtMixPerfW2WLwb.Location = New System.Drawing.Point(396, 92)
        Me.txtMixPerfW2WLwb.Name = "txtMixPerfW2WLwb"
        Me.txtMixPerfW2WLwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2WLwb.TabIndex = 29
        Me.txtMixPerfW2WLwb.Text = "-"
        Me.txtMixPerfW2WLwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2WLdb
        '
        Me.txtMixPerfW2WLdb.Enabled = False
        Me.txtMixPerfW2WLdb.Location = New System.Drawing.Point(396, 66)
        Me.txtMixPerfW2WLdb.Name = "txtMixPerfW2WLdb"
        Me.txtMixPerfW2WLdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2WLdb.TabIndex = 28
        Me.txtMixPerfW2WLdb.Text = "-"
        Me.txtMixPerfW2WLdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfW2WLFlow
        '
        Me.txtMixPerfW2WLFlow.Enabled = False
        Me.txtMixPerfW2WLFlow.Location = New System.Drawing.Point(396, 40)
        Me.txtMixPerfW2WLFlow.Name = "txtMixPerfW2WLFlow"
        Me.txtMixPerfW2WLFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfW2WLFlow.TabIndex = 27
        Me.txtMixPerfW2WLFlow.Text = "-"
        Me.txtMixPerfW2WLFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2RAdb
        '
        Me.txtMixPerfS2RAdb.Enabled = False
        Me.txtMixPerfS2RAdb.Location = New System.Drawing.Point(250, 144)
        Me.txtMixPerfS2RAdb.Name = "txtMixPerfS2RAdb"
        Me.txtMixPerfS2RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2RAdb.TabIndex = 13
        Me.txtMixPerfS2RAdb.Text = "-"
        Me.txtMixPerfS2RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2RAFlow
        '
        Me.txtMixPerfS2RAFlow.Enabled = False
        Me.txtMixPerfS2RAFlow.Location = New System.Drawing.Point(250, 118)
        Me.txtMixPerfS2RAFlow.Name = "txtMixPerfS2RAFlow"
        Me.txtMixPerfS2RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2RAFlow.TabIndex = 12
        Me.txtMixPerfS2RAFlow.Text = "-"
        Me.txtMixPerfS2RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2WLwb
        '
        Me.txtMixPerfS2WLwb.Enabled = False
        Me.txtMixPerfS2WLwb.Location = New System.Drawing.Point(250, 92)
        Me.txtMixPerfS2WLwb.Name = "txtMixPerfS2WLwb"
        Me.txtMixPerfS2WLwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2WLwb.TabIndex = 11
        Me.txtMixPerfS2WLwb.Text = "-"
        Me.txtMixPerfS2WLwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2WLdb
        '
        Me.txtMixPerfS2WLdb.Enabled = False
        Me.txtMixPerfS2WLdb.Location = New System.Drawing.Point(250, 66)
        Me.txtMixPerfS2WLdb.Name = "txtMixPerfS2WLdb"
        Me.txtMixPerfS2WLdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2WLdb.TabIndex = 10
        Me.txtMixPerfS2WLdb.Text = "-"
        Me.txtMixPerfS2WLdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS2WLFlow
        '
        Me.txtMixPerfS2WLFlow.Enabled = False
        Me.txtMixPerfS2WLFlow.Location = New System.Drawing.Point(250, 40)
        Me.txtMixPerfS2WLFlow.Name = "txtMixPerfS2WLFlow"
        Me.txtMixPerfS2WLFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS2WLFlow.TabIndex = 9
        Me.txtMixPerfS2WLFlow.Text = "-"
        Me.txtMixPerfS2WLFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMixPerfS1RAdb
        '
        Me.txtMixPerfS1RAdb.Location = New System.Drawing.Point(177, 144)
        Me.txtMixPerfS1RAdb.Name = "txtMixPerfS1RAdb"
        Me.txtMixPerfS1RAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1RAdb.TabIndex = 4
        Me.txtMixPerfS1RAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(16, 143)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(155, 20)
        Me.Label81.TabIndex = 158
        Me.Label81.Text = "RA Temp. DB (°F)"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfS1RAFlow
        '
        Me.txtMixPerfS1RAFlow.Location = New System.Drawing.Point(177, 118)
        Me.txtMixPerfS1RAFlow.Name = "txtMixPerfS1RAFlow"
        Me.txtMixPerfS1RAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1RAFlow.TabIndex = 3
        Me.txtMixPerfS1RAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(16, 117)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(155, 20)
        Me.Label82.TabIndex = 156
        Me.Label82.Text = "Return Air Flow to Unit (cfm)"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfS1WLwb
        '
        Me.txtMixPerfS1WLwb.Location = New System.Drawing.Point(177, 92)
        Me.txtMixPerfS1WLwb.Name = "txtMixPerfS1WLwb"
        Me.txtMixPerfS1WLwb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1WLwb.TabIndex = 2
        Me.txtMixPerfS1WLwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(16, 91)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(155, 20)
        Me.Label83.TabIndex = 154
        Me.Label83.Text = "Whl Lvg FA Temp. WB (°F)"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfS1WLdb
        '
        Me.txtMixPerfS1WLdb.Location = New System.Drawing.Point(177, 66)
        Me.txtMixPerfS1WLdb.Name = "txtMixPerfS1WLdb"
        Me.txtMixPerfS1WLdb.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1WLdb.TabIndex = 1
        Me.txtMixPerfS1WLdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(16, 65)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(155, 20)
        Me.Label84.TabIndex = 152
        Me.Label84.Text = "Whl Lvg FA Temp. DB (°F)"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMixPerfS1WLFlow
        '
        Me.txtMixPerfS1WLFlow.Location = New System.Drawing.Point(177, 40)
        Me.txtMixPerfS1WLFlow.Name = "txtMixPerfS1WLFlow"
        Me.txtMixPerfS1WLFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtMixPerfS1WLFlow.TabIndex = 0
        Me.txtMixPerfS1WLFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(16, 39)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(155, 20)
        Me.Label85.TabIndex = 150
        Me.Label85.Text = "Whl Lvg FA Airflow (cfm)"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFTotEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1SAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1SAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2TotEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1TotEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2TotEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1SAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1TotEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1XAdb)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1XAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFLatEff)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFSensEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1XAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2LatEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1SensEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2SensEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfW1LatEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2LatEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2SensEff)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1LatEff)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1SensEff)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFXAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2XAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2XAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1XAFlow)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFXAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFXAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFSAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFSAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfWFFSAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2XAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2XAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2SAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2SAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfW2SAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2XAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2XAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2SAwb)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2SAdb)
        Me.GroupBox3.Controls.Add(Me.txtPerfS2SAFlow)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1XAwb)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1XAdb)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1SAwb)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1SAdb)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.txtPerfS1SAFlow)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(543, 286)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Wheel Performance"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(329, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Winter"
        '
        'txtPerfWFFTotEff
        '
        Me.txtPerfWFFTotEff.Enabled = False
        Me.txtPerfWFFTotEff.Location = New System.Drawing.Point(461, 249)
        Me.txtPerfWFFTotEff.Name = "txtPerfWFFTotEff"
        Me.txtPerfWFFTotEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFTotEff.TabIndex = 44
        Me.txtPerfWFFTotEff.Text = "-"
        Me.txtPerfWFFTotEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1SAFlow
        '
        Me.txtPerfW1SAFlow.Location = New System.Drawing.Point(315, 41)
        Me.txtPerfW1SAFlow.Name = "txtPerfW1SAFlow"
        Me.txtPerfW1SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1SAFlow.TabIndex = 18
        Me.txtPerfW1SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1SAdb
        '
        Me.txtPerfW1SAdb.Location = New System.Drawing.Point(315, 67)
        Me.txtPerfW1SAdb.Name = "txtPerfW1SAdb"
        Me.txtPerfW1SAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1SAdb.TabIndex = 19
        Me.txtPerfW1SAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2TotEff
        '
        Me.txtPerfW2TotEff.Enabled = False
        Me.txtPerfW2TotEff.Location = New System.Drawing.Point(388, 249)
        Me.txtPerfW2TotEff.Name = "txtPerfW2TotEff"
        Me.txtPerfW2TotEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2TotEff.TabIndex = 35
        Me.txtPerfW2TotEff.Text = "-"
        Me.txtPerfW2TotEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1TotEff
        '
        Me.txtPerfW1TotEff.Location = New System.Drawing.Point(315, 249)
        Me.txtPerfW1TotEff.Name = "txtPerfW1TotEff"
        Me.txtPerfW1TotEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1TotEff.TabIndex = 26
        Me.txtPerfW1TotEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2TotEff
        '
        Me.txtPerfS2TotEff.Enabled = False
        Me.txtPerfS2TotEff.Location = New System.Drawing.Point(242, 249)
        Me.txtPerfS2TotEff.Name = "txtPerfS2TotEff"
        Me.txtPerfS2TotEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2TotEff.TabIndex = 17
        Me.txtPerfS2TotEff.Text = "-"
        Me.txtPerfS2TotEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1SAwb
        '
        Me.txtPerfW1SAwb.Location = New System.Drawing.Point(315, 93)
        Me.txtPerfW1SAwb.Name = "txtPerfW1SAwb"
        Me.txtPerfW1SAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1SAwb.TabIndex = 20
        Me.txtPerfW1SAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS1TotEff
        '
        Me.txtPerfS1TotEff.Location = New System.Drawing.Point(169, 249)
        Me.txtPerfS1TotEff.Name = "txtPerfS1TotEff"
        Me.txtPerfS1TotEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1TotEff.TabIndex = 8
        Me.txtPerfS1TotEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1XAdb
        '
        Me.txtPerfW1XAdb.Location = New System.Drawing.Point(315, 119)
        Me.txtPerfW1XAdb.Name = "txtPerfW1XAdb"
        Me.txtPerfW1XAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1XAdb.TabIndex = 21
        Me.txtPerfW1XAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 248)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(155, 20)
        Me.Label34.TabIndex = 144
        Me.Label34.Text = "Total Effectiveness (%)"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfW1XAwb
        '
        Me.txtPerfW1XAwb.Location = New System.Drawing.Point(315, 145)
        Me.txtPerfW1XAwb.Name = "txtPerfW1XAwb"
        Me.txtPerfW1XAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1XAwb.TabIndex = 22
        Me.txtPerfW1XAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfWFFLatEff
        '
        Me.txtPerfWFFLatEff.Enabled = False
        Me.txtPerfWFFLatEff.Location = New System.Drawing.Point(461, 223)
        Me.txtPerfWFFLatEff.Name = "txtPerfWFFLatEff"
        Me.txtPerfWFFLatEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFLatEff.TabIndex = 43
        Me.txtPerfWFFLatEff.Text = "-"
        Me.txtPerfWFFLatEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(318, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 118
        Me.Label22.Text = "Condition 1"
        '
        'txtPerfWFFSensEff
        '
        Me.txtPerfWFFSensEff.Enabled = False
        Me.txtPerfWFFSensEff.Location = New System.Drawing.Point(461, 197)
        Me.txtPerfWFFSensEff.Name = "txtPerfWFFSensEff"
        Me.txtPerfWFFSensEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFSensEff.TabIndex = 42
        Me.txtPerfWFFSensEff.Text = "-"
        Me.txtPerfWFFSensEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1XAFlow
        '
        Me.txtPerfW1XAFlow.Location = New System.Drawing.Point(315, 171)
        Me.txtPerfW1XAFlow.Name = "txtPerfW1XAFlow"
        Me.txtPerfW1XAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1XAFlow.TabIndex = 23
        Me.txtPerfW1XAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2LatEff
        '
        Me.txtPerfW2LatEff.Enabled = False
        Me.txtPerfW2LatEff.Location = New System.Drawing.Point(388, 223)
        Me.txtPerfW2LatEff.Name = "txtPerfW2LatEff"
        Me.txtPerfW2LatEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2LatEff.TabIndex = 34
        Me.txtPerfW2LatEff.Text = "-"
        Me.txtPerfW2LatEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1SensEff
        '
        Me.txtPerfW1SensEff.Location = New System.Drawing.Point(315, 197)
        Me.txtPerfW1SensEff.Name = "txtPerfW1SensEff"
        Me.txtPerfW1SensEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1SensEff.TabIndex = 24
        Me.txtPerfW1SensEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2SensEff
        '
        Me.txtPerfW2SensEff.Enabled = False
        Me.txtPerfW2SensEff.Location = New System.Drawing.Point(388, 197)
        Me.txtPerfW2SensEff.Name = "txtPerfW2SensEff"
        Me.txtPerfW2SensEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2SensEff.TabIndex = 33
        Me.txtPerfW2SensEff.Text = "-"
        Me.txtPerfW2SensEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW1LatEff
        '
        Me.txtPerfW1LatEff.Location = New System.Drawing.Point(315, 223)
        Me.txtPerfW1LatEff.Name = "txtPerfW1LatEff"
        Me.txtPerfW1LatEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW1LatEff.TabIndex = 25
        Me.txtPerfW1LatEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2LatEff
        '
        Me.txtPerfS2LatEff.Enabled = False
        Me.txtPerfS2LatEff.Location = New System.Drawing.Point(242, 223)
        Me.txtPerfS2LatEff.Name = "txtPerfS2LatEff"
        Me.txtPerfS2LatEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2LatEff.TabIndex = 16
        Me.txtPerfS2LatEff.Text = "-"
        Me.txtPerfS2LatEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2SensEff
        '
        Me.txtPerfS2SensEff.Enabled = False
        Me.txtPerfS2SensEff.Location = New System.Drawing.Point(242, 197)
        Me.txtPerfS2SensEff.Name = "txtPerfS2SensEff"
        Me.txtPerfS2SensEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2SensEff.TabIndex = 15
        Me.txtPerfS2SensEff.Text = "-"
        Me.txtPerfS2SensEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS1LatEff
        '
        Me.txtPerfS1LatEff.Location = New System.Drawing.Point(169, 223)
        Me.txtPerfS1LatEff.Name = "txtPerfS1LatEff"
        Me.txtPerfS1LatEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1LatEff.TabIndex = 7
        Me.txtPerfS1LatEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 222)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(155, 20)
        Me.Label44.TabIndex = 134
        Me.Label44.Text = "Latent Effectiveness (%)"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfS1SensEff
        '
        Me.txtPerfS1SensEff.Location = New System.Drawing.Point(169, 197)
        Me.txtPerfS1SensEff.Name = "txtPerfS1SensEff"
        Me.txtPerfS1SensEff.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1SensEff.TabIndex = 6
        Me.txtPerfS1SensEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 196)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(155, 20)
        Me.Label45.TabIndex = 132
        Me.Label45.Text = "Sens. Effectiveness (%)"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfWFFXAFlow
        '
        Me.txtPerfWFFXAFlow.Enabled = False
        Me.txtPerfWFFXAFlow.Location = New System.Drawing.Point(461, 171)
        Me.txtPerfWFFXAFlow.Name = "txtPerfWFFXAFlow"
        Me.txtPerfWFFXAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFXAFlow.TabIndex = 41
        Me.txtPerfWFFXAFlow.Text = "-"
        Me.txtPerfWFFXAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2XAFlow
        '
        Me.txtPerfW2XAFlow.Enabled = False
        Me.txtPerfW2XAFlow.Location = New System.Drawing.Point(388, 171)
        Me.txtPerfW2XAFlow.Name = "txtPerfW2XAFlow"
        Me.txtPerfW2XAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2XAFlow.TabIndex = 32
        Me.txtPerfW2XAFlow.Text = "-"
        Me.txtPerfW2XAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2XAFlow
        '
        Me.txtPerfS2XAFlow.Enabled = False
        Me.txtPerfS2XAFlow.Location = New System.Drawing.Point(242, 171)
        Me.txtPerfS2XAFlow.Name = "txtPerfS2XAFlow"
        Me.txtPerfS2XAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2XAFlow.TabIndex = 14
        Me.txtPerfS2XAFlow.Text = "-"
        Me.txtPerfS2XAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS1XAFlow
        '
        Me.txtPerfS1XAFlow.Location = New System.Drawing.Point(169, 171)
        Me.txtPerfS1XAFlow.Name = "txtPerfS1XAFlow"
        Me.txtPerfS1XAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1XAFlow.TabIndex = 5
        Me.txtPerfS1XAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Wheel Exhaust Airflow (cfm)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(402, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Winter"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Summer"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(180, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Summer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(475, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 121
        Me.Label17.Text = "Winter"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(391, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Condition 2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(245, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 13)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "Condition 2"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(172, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 13)
        Me.Label23.TabIndex = 117
        Me.Label23.Text = "Condition 1"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(469, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 116
        Me.Label24.Text = "Anti-Frost"
        '
        'txtPerfWFFXAwb
        '
        Me.txtPerfWFFXAwb.Enabled = False
        Me.txtPerfWFFXAwb.Location = New System.Drawing.Point(461, 145)
        Me.txtPerfWFFXAwb.Name = "txtPerfWFFXAwb"
        Me.txtPerfWFFXAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFXAwb.TabIndex = 40
        Me.txtPerfWFFXAwb.Text = "-"
        Me.txtPerfWFFXAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfWFFXAdb
        '
        Me.txtPerfWFFXAdb.Enabled = False
        Me.txtPerfWFFXAdb.Location = New System.Drawing.Point(461, 119)
        Me.txtPerfWFFXAdb.Name = "txtPerfWFFXAdb"
        Me.txtPerfWFFXAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFXAdb.TabIndex = 39
        Me.txtPerfWFFXAdb.Text = "-"
        Me.txtPerfWFFXAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfWFFSAwb
        '
        Me.txtPerfWFFSAwb.Enabled = False
        Me.txtPerfWFFSAwb.Location = New System.Drawing.Point(461, 93)
        Me.txtPerfWFFSAwb.Name = "txtPerfWFFSAwb"
        Me.txtPerfWFFSAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFSAwb.TabIndex = 38
        Me.txtPerfWFFSAwb.Text = "-"
        Me.txtPerfWFFSAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfWFFSAdb
        '
        Me.txtPerfWFFSAdb.Enabled = False
        Me.txtPerfWFFSAdb.Location = New System.Drawing.Point(461, 67)
        Me.txtPerfWFFSAdb.Name = "txtPerfWFFSAdb"
        Me.txtPerfWFFSAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFSAdb.TabIndex = 37
        Me.txtPerfWFFSAdb.Text = "-"
        Me.txtPerfWFFSAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfWFFSAFlow
        '
        Me.txtPerfWFFSAFlow.Enabled = False
        Me.txtPerfWFFSAFlow.Location = New System.Drawing.Point(461, 41)
        Me.txtPerfWFFSAFlow.Name = "txtPerfWFFSAFlow"
        Me.txtPerfWFFSAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfWFFSAFlow.TabIndex = 36
        Me.txtPerfWFFSAFlow.Text = "-"
        Me.txtPerfWFFSAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2XAwb
        '
        Me.txtPerfW2XAwb.Enabled = False
        Me.txtPerfW2XAwb.Location = New System.Drawing.Point(388, 145)
        Me.txtPerfW2XAwb.Name = "txtPerfW2XAwb"
        Me.txtPerfW2XAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2XAwb.TabIndex = 31
        Me.txtPerfW2XAwb.Text = "-"
        Me.txtPerfW2XAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2XAdb
        '
        Me.txtPerfW2XAdb.Enabled = False
        Me.txtPerfW2XAdb.Location = New System.Drawing.Point(388, 119)
        Me.txtPerfW2XAdb.Name = "txtPerfW2XAdb"
        Me.txtPerfW2XAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2XAdb.TabIndex = 30
        Me.txtPerfW2XAdb.Text = "-"
        Me.txtPerfW2XAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2SAwb
        '
        Me.txtPerfW2SAwb.Enabled = False
        Me.txtPerfW2SAwb.Location = New System.Drawing.Point(388, 93)
        Me.txtPerfW2SAwb.Name = "txtPerfW2SAwb"
        Me.txtPerfW2SAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2SAwb.TabIndex = 29
        Me.txtPerfW2SAwb.Text = "-"
        Me.txtPerfW2SAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2SAdb
        '
        Me.txtPerfW2SAdb.Enabled = False
        Me.txtPerfW2SAdb.Location = New System.Drawing.Point(388, 67)
        Me.txtPerfW2SAdb.Name = "txtPerfW2SAdb"
        Me.txtPerfW2SAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2SAdb.TabIndex = 28
        Me.txtPerfW2SAdb.Text = "-"
        Me.txtPerfW2SAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfW2SAFlow
        '
        Me.txtPerfW2SAFlow.Enabled = False
        Me.txtPerfW2SAFlow.Location = New System.Drawing.Point(388, 41)
        Me.txtPerfW2SAFlow.Name = "txtPerfW2SAFlow"
        Me.txtPerfW2SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfW2SAFlow.TabIndex = 27
        Me.txtPerfW2SAFlow.Text = "-"
        Me.txtPerfW2SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2XAwb
        '
        Me.txtPerfS2XAwb.Enabled = False
        Me.txtPerfS2XAwb.Location = New System.Drawing.Point(242, 145)
        Me.txtPerfS2XAwb.Name = "txtPerfS2XAwb"
        Me.txtPerfS2XAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2XAwb.TabIndex = 13
        Me.txtPerfS2XAwb.Text = "-"
        Me.txtPerfS2XAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2XAdb
        '
        Me.txtPerfS2XAdb.Enabled = False
        Me.txtPerfS2XAdb.Location = New System.Drawing.Point(242, 119)
        Me.txtPerfS2XAdb.Name = "txtPerfS2XAdb"
        Me.txtPerfS2XAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2XAdb.TabIndex = 12
        Me.txtPerfS2XAdb.Text = "-"
        Me.txtPerfS2XAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2SAwb
        '
        Me.txtPerfS2SAwb.Enabled = False
        Me.txtPerfS2SAwb.Location = New System.Drawing.Point(242, 93)
        Me.txtPerfS2SAwb.Name = "txtPerfS2SAwb"
        Me.txtPerfS2SAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2SAwb.TabIndex = 11
        Me.txtPerfS2SAwb.Text = "-"
        Me.txtPerfS2SAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2SAdb
        '
        Me.txtPerfS2SAdb.Enabled = False
        Me.txtPerfS2SAdb.Location = New System.Drawing.Point(242, 67)
        Me.txtPerfS2SAdb.Name = "txtPerfS2SAdb"
        Me.txtPerfS2SAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2SAdb.TabIndex = 10
        Me.txtPerfS2SAdb.Text = "-"
        Me.txtPerfS2SAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS2SAFlow
        '
        Me.txtPerfS2SAFlow.Enabled = False
        Me.txtPerfS2SAFlow.Location = New System.Drawing.Point(242, 41)
        Me.txtPerfS2SAFlow.Name = "txtPerfS2SAFlow"
        Me.txtPerfS2SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS2SAFlow.TabIndex = 9
        Me.txtPerfS2SAFlow.Text = "-"
        Me.txtPerfS2SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerfS1XAwb
        '
        Me.txtPerfS1XAwb.Location = New System.Drawing.Point(169, 145)
        Me.txtPerfS1XAwb.Name = "txtPerfS1XAwb"
        Me.txtPerfS1XAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1XAwb.TabIndex = 4
        Me.txtPerfS1XAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 144)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(155, 20)
        Me.Label35.TabIndex = 88
        Me.Label35.Text = "XA Temp. WB (°F)"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfS1XAdb
        '
        Me.txtPerfS1XAdb.Location = New System.Drawing.Point(169, 119)
        Me.txtPerfS1XAdb.Name = "txtPerfS1XAdb"
        Me.txtPerfS1XAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1XAdb.TabIndex = 3
        Me.txtPerfS1XAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 118)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(155, 20)
        Me.Label36.TabIndex = 86
        Me.Label36.Text = "XA Temp. DB (°F)"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfS1SAwb
        '
        Me.txtPerfS1SAwb.Location = New System.Drawing.Point(169, 93)
        Me.txtPerfS1SAwb.Name = "txtPerfS1SAwb"
        Me.txtPerfS1SAwb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1SAwb.TabIndex = 2
        Me.txtPerfS1SAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(8, 92)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(155, 20)
        Me.Label37.TabIndex = 84
        Me.Label37.Text = "Wheel SA Temp. WB (°F)"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfS1SAdb
        '
        Me.txtPerfS1SAdb.Location = New System.Drawing.Point(169, 67)
        Me.txtPerfS1SAdb.Name = "txtPerfS1SAdb"
        Me.txtPerfS1SAdb.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1SAdb.TabIndex = 1
        Me.txtPerfS1SAdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(8, 66)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(155, 20)
        Me.Label42.TabIndex = 82
        Me.Label42.Text = "Wheel SA Temp. DB (°F)"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerfS1SAFlow
        '
        Me.txtPerfS1SAFlow.Location = New System.Drawing.Point(169, 41)
        Me.txtPerfS1SAFlow.Name = "txtPerfS1SAFlow"
        Me.txtPerfS1SAFlow.Size = New System.Drawing.Size(67, 20)
        Me.txtPerfS1SAFlow.TabIndex = 0
        Me.txtPerfS1SAFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(155, 20)
        Me.Label43.TabIndex = 80
        Me.Label43.Text = "Wheel SA Airflow (cfm)"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDonePerformance
        '
        Me.cmdDonePerformance.Location = New System.Drawing.Point(1061, 475)
        Me.cmdDonePerformance.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDonePerformance.Name = "cmdDonePerformance"
        Me.cmdDonePerformance.Size = New System.Drawing.Size(96, 36)
        Me.cmdDonePerformance.TabIndex = 1
        Me.cmdDonePerformance.Text = ">"
        Me.cmdDonePerformance.UseVisualStyleBackColor = True
        '
        'lblUnitVolts
        '
        Me.lblUnitVolts.AutoSize = True
        Me.lblUnitVolts.Location = New System.Drawing.Point(710, 561)
        Me.lblUnitVolts.Name = "lblUnitVolts"
        Me.lblUnitVolts.Size = New System.Drawing.Size(68, 13)
        Me.lblUnitVolts.TabIndex = 75
        Me.lblUnitVolts.Text = "Unit Voltage:"
        '
        'lblUnitCabinet
        '
        Me.lblUnitCabinet.AutoSize = True
        Me.lblUnitCabinet.Location = New System.Drawing.Point(231, 577)
        Me.lblUnitCabinet.Name = "lblUnitCabinet"
        Me.lblUnitCabinet.Size = New System.Drawing.Size(68, 13)
        Me.lblUnitCabinet.TabIndex = 76
        Me.lblUnitCabinet.Text = "Unit Cabinet:"
        '
        'lblUnitSeries
        '
        Me.lblUnitSeries.AutoSize = True
        Me.lblUnitSeries.Location = New System.Drawing.Point(231, 561)
        Me.lblUnitSeries.Name = "lblUnitSeries"
        Me.lblUnitSeries.Size = New System.Drawing.Size(61, 13)
        Me.lblUnitSeries.TabIndex = 77
        Me.lblUnitSeries.Text = "Unit Series:"
        '
        'frmERW
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1201, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUnitSeries)
        Me.Controls.Add(Me.lblUnitCabinet)
        Me.Controls.Add(Me.lblUnitVolts)
        Me.Controls.Add(Me.txtDryWeight)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tbcERW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmERW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Energy Recovery Wheel"
        Me.tbcERW.ResumeLayout(False)
        Me.pgProposal.ResumeLayout(False)
        Me.pgProposal.PerformLayout()
        Me.grpXABypassDampers.ResumeLayout(False)
        Me.grpXABypassDampers.PerformLayout()
        Me.grpXABypassHoods.ResumeLayout(False)
        Me.grpXABypassHoods.PerformLayout()
        Me.grpRABPDampers.ResumeLayout(False)
        Me.grpRABPDampers.PerformLayout()
        Me.grpOABPDampers.ResumeLayout(False)
        Me.grpOABPDampers.PerformLayout()
        Me.grpOABPHoods.ResumeLayout(False)
        Me.grpOABPHoods.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.grpReliefDampers.ResumeLayout(False)
        Me.grpReliefDampers.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pgConditions.ResumeLayout(False)
        Me.pgConditions.PerformLayout()
        Me.pgAirflowDwg.ResumeLayout(False)
        Me.pgAirflowDwg.PerformLayout()
        CType(Me.pboxAirflow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgControls.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.pgStatic.ResumeLayout(False)
        Me.pgStatic.PerformLayout()
        Me.pgPerformance.ResumeLayout(False)
        Me.pgPerformance.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDryWeight As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents tbcERW As TabControl
    Friend WithEvents pgProposal As TabPage
    Friend WithEvents btnDoneProposal As Button
    Friend WithEvents chkScopeOABypass As CheckBox
    Friend WithEvents pgAirflowDwg As TabPage
    Friend WithEvents txtAvailDescription As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents pboxAirflow As PictureBox
    Friend WithEvents lstAvailAirflow As ListBox
    Friend WithEvents btnDoneAirflowDwg As Button
    Friend WithEvents pgControls As TabPage
    Friend WithEvents pgPerformance As TabPage
    Friend WithEvents cmdDonePerformance As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optPartialFlow As RadioButton
    Friend WithEvents optFullFlow As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optCSWheel As RadioButton
    Friend WithEvents optVSWheel As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optPlasticWheel As RadioButton
    Friend WithEvents optAlWheel As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optMultiPointPower As RadioButton
    Friend WithEvents optSinglePointPower As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtSFStaticPressureAllowance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents optSFanJCI As RadioButton
    Friend WithEvents optSFanOAFan As RadioButton
    Friend WithEvents optSFanFisen As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtRFStaticPressureAllowance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents optRFanbyJCI As RadioButton
    Friend WithEvents optRFanByFisen As RadioButton
    Friend WithEvents optXFanByFisen As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chkFiltrationOAMetal As CheckBox
    Friend WithEvents chkFiltrationRAAngledRack As CheckBox
    Friend WithEvents chkFiltrationOAAngledRack As CheckBox
    Friend WithEvents chkFiltrationRAMERV8 As CheckBox
    Friend WithEvents chkFiltrationOAMERV8 As CheckBox
    Friend WithEvents grpReliefDampers As GroupBox
    Friend WithEvents optReliefDamperActuated As RadioButton
    Friend WithEvents optReliefDamperBarometric As RadioButton
    Friend WithEvents chkScopeXABypassDampers As CheckBox
    Friend WithEvents chkScopeRABypassDampers As CheckBox
    Friend WithEvents pgConditions As TabPage
    Friend WithEvents txtCondS1RAwb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCondS1RAdb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCondS1OAwb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCondS1OAdb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCondS1OAFlow As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkEnaAntiFrostCond As CheckBox
    Friend WithEvents chkEnaAltCond As CheckBox
    Friend WithEvents txtCondWAFRAFlow As TextBox
    Friend WithEvents txtCondW2RAFlow As TextBox
    Friend WithEvents txtCondW1RAFlow As TextBox
    Friend WithEvents txtCondS2RAFlow As TextBox
    Friend WithEvents txtCondS1RAFlow As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCondWAFSAFlow As TextBox
    Friend WithEvents txtCondWAFRAwb As TextBox
    Friend WithEvents txtCondWAFRAdb As TextBox
    Friend WithEvents txtCondWAFOAwb As TextBox
    Friend WithEvents txtCondWAFOAdb As TextBox
    Friend WithEvents txtCondWAFOAFlow As TextBox
    Friend WithEvents txtCondW2SAFlow As TextBox
    Friend WithEvents txtCondW2RAwb As TextBox
    Friend WithEvents txtCondW2RAdb As TextBox
    Friend WithEvents txtCondW2OAwb As TextBox
    Friend WithEvents txtCondW2OAdb As TextBox
    Friend WithEvents txtCondW2OAFlow As TextBox
    Friend WithEvents txtCondW1SAFlow As TextBox
    Friend WithEvents txtCondW1RAwb As TextBox
    Friend WithEvents txtCondW1RAdb As TextBox
    Friend WithEvents txtCondW1OAwb As TextBox
    Friend WithEvents txtCondW1OAdb As TextBox
    Friend WithEvents txtCondW1OAFlow As TextBox
    Friend WithEvents txtCondS2SAFlow As TextBox
    Friend WithEvents txtCondS2RAwb As TextBox
    Friend WithEvents txtCondS2RAdb As TextBox
    Friend WithEvents txtCondS2OAwb As TextBox
    Friend WithEvents txtCondS2OAdb As TextBox
    Friend WithEvents txtCondS2OAFlow As TextBox
    Friend WithEvents txtCondS1SAFlow As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPerfWFFTotEff As TextBox
    Friend WithEvents txtPerfW2TotEff As TextBox
    Friend WithEvents txtPerfS2TotEff As TextBox
    Friend WithEvents txtPerfW1TotEff As TextBox
    Friend WithEvents txtPerfS1TotEff As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtPerfWFFLatEff As TextBox
    Friend WithEvents txtPerfWFFSensEff As TextBox
    Friend WithEvents txtPerfW2LatEff As TextBox
    Friend WithEvents txtPerfW2SensEff As TextBox
    Friend WithEvents txtPerfS2LatEff As TextBox
    Friend WithEvents txtPerfS2SensEff As TextBox
    Friend WithEvents txtPerfW1LatEff As TextBox
    Friend WithEvents txtPerfW1SensEff As TextBox
    Friend WithEvents txtPerfS1LatEff As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents txtPerfS1SensEff As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtPerfWFFXAFlow As TextBox
    Friend WithEvents txtPerfW2XAFlow As TextBox
    Friend WithEvents txtPerfS2XAFlow As TextBox
    Friend WithEvents txtPerfW1XAFlow As TextBox
    Friend WithEvents txtPerfS1XAFlow As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPerfWFFXAwb As TextBox
    Friend WithEvents txtPerfWFFXAdb As TextBox
    Friend WithEvents txtPerfWFFSAwb As TextBox
    Friend WithEvents txtPerfWFFSAdb As TextBox
    Friend WithEvents txtPerfWFFSAFlow As TextBox
    Friend WithEvents txtPerfW2XAwb As TextBox
    Friend WithEvents txtPerfW2XAdb As TextBox
    Friend WithEvents txtPerfW2SAwb As TextBox
    Friend WithEvents txtPerfW2SAdb As TextBox
    Friend WithEvents txtPerfW2SAFlow As TextBox
    Friend WithEvents txtPerfS2XAwb As TextBox
    Friend WithEvents txtPerfS2XAdb As TextBox
    Friend WithEvents txtPerfS2SAwb As TextBox
    Friend WithEvents txtPerfS2SAdb As TextBox
    Friend WithEvents txtPerfS2SAFlow As TextBox
    Friend WithEvents txtPerfW1XAwb As TextBox
    Friend WithEvents txtPerfW1XAdb As TextBox
    Friend WithEvents txtPerfW1SAwb As TextBox
    Friend WithEvents txtPerfW1SAdb As TextBox
    Friend WithEvents txtPerfW1SAFlow As TextBox
    Friend WithEvents txtPerfS1XAwb As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtPerfS1XAdb As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtPerfS1SAwb As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtPerfS1SAdb As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtPerfS1SAFlow As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents cmbWheel As ComboBox
    Friend WithEvents txtERWElectricalInfo As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents lblUnitVolts As Label
    Friend WithEvents chkERWVFDbyFisen As CheckBox
    Friend WithEvents chkERWBypassSwitch As CheckBox
    Friend WithEvents optReliefDamperNone As RadioButton
    Friend WithEvents optCabinetInCab As RadioButton
    Friend WithEvents grpOABPHoods As GroupBox
    Friend WithEvents optOABPHoodNone As RadioButton
    Friend WithEvents chkOABPHoodMetalFilters As CheckBox
    Friend WithEvents optOABPHoodByFisen As RadioButton
    Friend WithEvents optOABPHoodReuseJCI As RadioButton
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents optOADamperReuseJCI As RadioButton
    Friend WithEvents optOADamperByFisen As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents chkOAHoodMetalFilters As CheckBox
    Friend WithEvents optOAHoodByFisen As RadioButton
    Friend WithEvents optOAHoodReuseJCI As RadioButton
    Friend WithEvents optCabinetExtension As RadioButton
    Friend WithEvents grpOABPDampers As GroupBox
    Friend WithEvents optOABPDampersNone As RadioButton
    Friend WithEvents optOABPDampersByFisen As RadioButton
    Friend WithEvents optOABPDampersReuse As RadioButton
    Friend WithEvents grpXABypassDampers As GroupBox
    Friend WithEvents optXABPDamperAtmosphere As RadioButton
    Friend WithEvents optXABPDamperWheel As RadioButton
    Friend WithEvents grpXABypassHoods As GroupBox
    Friend WithEvents optXABPHoodNone As RadioButton
    Friend WithEvents chkXABPHoodMesh As CheckBox
    Friend WithEvents optXABPHoodByFisen As RadioButton
    Friend WithEvents optXABPHoodReuseJCI As RadioButton
    Friend WithEvents grpRABPDampers As GroupBox
    Friend WithEvents optRABPDampersNone As RadioButton
    Friend WithEvents optRABPDampersByFisen As RadioButton
    Friend WithEvents optRABPDampersReuse As RadioButton
    Friend WithEvents chkOAHoodFieldInstalled As CheckBox
    Friend WithEvents chkOABPHoodFieldInstalled As CheckBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents RadioButton31 As RadioButton
    Friend WithEvents RadioButton32 As RadioButton
    Friend WithEvents optOADamperNone As RadioButton
    Friend WithEvents chkXABPHoodFieldInstalled As CheckBox
    Friend WithEvents optCabinetStandAlone As RadioButton
    Friend WithEvents cmbExtensionList As ComboBox
    Friend WithEvents cmdDoneConditions As Button
    Friend WithEvents pgStatic As TabPage
    Friend WithEvents cmdDoneControls As Button
    Friend WithEvents cmdDoneStaticTables As Button
    Friend WithEvents lblRecFanTypeStatic As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents txtRXFStaticHWCloth As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents txtRXFStaticRAOpening As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtRXFStaticReliefHood As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtRXFStaticReliefDamp As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents txtRXFStaticERW As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents txtRXFStaticRAFilt As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents txtRXFStaticSafetyGrate As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents txtSFStaticTrans As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtSFStaticOAHood As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtSFStaticTotal As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtSFStaticCabFX As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtSFStaticERW As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txtSFStaticOAFilt As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txtSFStaticMetalFilt As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtRXFStaticTrans As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txtRXFStaticTotal As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents txtRXFStaticCabFX As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents txtSFStaticOADamp As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtMixPerfWFFMAwb As TextBox
    Friend WithEvents txtMixPerfW1WLFlow As TextBox
    Friend WithEvents txtMixPerfW1WLdb As TextBox
    Friend WithEvents txtMixPerfW2MAwb As TextBox
    Friend WithEvents txtMixPerfW1MAwb As TextBox
    Friend WithEvents txtMixPerfS2MAwb As TextBox
    Friend WithEvents txtMixPerfW1WLwb As TextBox
    Friend WithEvents txtMixPerfS1MAwb As TextBox
    Friend WithEvents txtMixPerfW1RAFlow As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents txtMixPerfW1RAdb As TextBox
    Friend WithEvents txtMixPerfWFFMAdb As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents txtMixPerfWFFMixFlow As TextBox
    Friend WithEvents txtMixPerfW1RAwb As TextBox
    Friend WithEvents txtMixPerfW2MAdb As TextBox
    Friend WithEvents txtMixPerfW1MixFlow As TextBox
    Friend WithEvents txtMixPerfW2MixFlow As TextBox
    Friend WithEvents txtMixPerfW1MAdb As TextBox
    Friend WithEvents txtMixPerfS2MAdb As TextBox
    Friend WithEvents txtMixPerfS2MixFlow As TextBox
    Friend WithEvents txtMixPerfS1MAdb As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents txtMixPerfS1MixFlow As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents txtMixPerfWFFRAwb As TextBox
    Friend WithEvents txtMixPerfW2RAwb As TextBox
    Friend WithEvents txtMixPerfS2RAwb As TextBox
    Friend WithEvents txtMixPerfS1RAwb As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents txtMixPerfWFFRAdb As TextBox
    Friend WithEvents txtMixPerfWFFRAFlow As TextBox
    Friend WithEvents txtMixPerfWFFWLwb As TextBox
    Friend WithEvents txtMixPerfWFFWLdb As TextBox
    Friend WithEvents txtMixPerfWFFWLFlow As TextBox
    Friend WithEvents txtMixPerfW2RAdb As TextBox
    Friend WithEvents txtMixPerfW2RAFlow As TextBox
    Friend WithEvents txtMixPerfW2WLwb As TextBox
    Friend WithEvents txtMixPerfW2WLdb As TextBox
    Friend WithEvents txtMixPerfW2WLFlow As TextBox
    Friend WithEvents txtMixPerfS2RAdb As TextBox
    Friend WithEvents txtMixPerfS2RAFlow As TextBox
    Friend WithEvents txtMixPerfS2WLwb As TextBox
    Friend WithEvents txtMixPerfS2WLdb As TextBox
    Friend WithEvents txtMixPerfS2WLFlow As TextBox
    Friend WithEvents txtMixPerfS1RAdb As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents txtMixPerfS1RAFlow As TextBox
    Friend WithEvents Label82 As Label
    Friend WithEvents txtMixPerfS1WLwb As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents txtMixPerfS1WLdb As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents txtMixPerfS1WLFlow As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents cmdCalculateMixed As Button
    Friend WithEvents lblUnitCabinet As Label
    Friend WithEvents lblUnitSeries As Label
    Friend WithEvents txtStaticTableFreshAirFlow As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents cmdSFStaticUpdate As Button
    Friend WithEvents txtStaticTableExhaustAirFlow As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents cmdXFStaticUpdate As Button
    Friend WithEvents txtStaticTableFullReturn As TextBox
    Friend WithEvents Label88 As Label
    Friend WithEvents chkRXStaticTransFull As CheckBox
    Friend WithEvents chkRXStaticReliefHoodFull As CheckBox
    Friend WithEvents chkRXStaticReliefDamperFull As CheckBox
    Friend WithEvents chkRXStaticHWClothFull As CheckBox
    Friend WithEvents chkRXStaticERWFull As CheckBox
    Friend WithEvents chkRXStaticRAFiltersFull As CheckBox
    Friend WithEvents chkRXStaticSafetyFull As CheckBox
    Friend WithEvents chkRXStaticRAOpeningFull As CheckBox
    Friend WithEvents optXFanbyJCI As RadioButton
    Friend WithEvents optXABPDamperNone As RadioButton
End Class
