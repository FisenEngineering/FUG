﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCustomCode
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
        Me.txtNewOpCode = New System.Windows.Forms.TextBox()
        Me.txtCstmFIOP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.chkMCAChange = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLoadName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLoadValue = New System.Windows.Forms.TextBox()
        Me.chkTestAirflow = New System.Windows.Forms.CheckBox()
        Me.chkTestCoil = New System.Windows.Forms.CheckBox()
        Me.chkTestControls = New System.Windows.Forms.CheckBox()
        Me.chkTestMotors = New System.Windows.Forms.CheckBox()
        Me.chkTestEHeat = New System.Windows.Forms.CheckBox()
        Me.chkTestGasHeat = New System.Windows.Forms.CheckBox()
        Me.chkTestGasTrain = New System.Windows.Forms.CheckBox()
        Me.chkTestHydro = New System.Windows.Forms.CheckBox()
        Me.chkTestRefer = New System.Windows.Forms.CheckBox()
        Me.chkTestReferInst = New System.Windows.Forms.CheckBox()
        Me.chkSeriesXTI = New System.Windows.Forms.CheckBox()
        Me.chkSeriesXTO = New System.Windows.Forms.CheckBox()
        Me.chkSeries40 = New System.Windows.Forms.CheckBox()
        Me.chkSeries100C = New System.Windows.Forms.CheckBox()
        Me.chkSeries100B = New System.Windows.Forms.CheckBox()
        Me.chkSeries100A = New System.Windows.Forms.CheckBox()
        Me.chkSeriesChoice = New System.Windows.Forms.CheckBox()
        Me.chkSeries20 = New System.Windows.Forms.CheckBox()
        Me.chkSeries10 = New System.Windows.Forms.CheckBox()
        Me.chkSeries5 = New System.Windows.Forms.CheckBox()
        Me.chkSeriesPremier = New System.Windows.Forms.CheckBox()
        Me.chkSeriesSelect = New System.Windows.Forms.CheckBox()
        Me.chkSeriesYVAA = New System.Windows.Forms.CheckBox()
        Me.chkSeriesYCAL = New System.Windows.Forms.CheckBox()
        Me.chkSeriesYLAA = New System.Windows.Forms.CheckBox()
        Me.chkSeriesLX = New System.Windows.Forms.CheckBox()
        Me.chkSeries12 = New System.Windows.Forms.CheckBox()
        Me.chkTagALongOnly = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkDesignCaution = New System.Windows.Forms.CheckBox()
        Me.chkCUL = New System.Windows.Forms.CheckBox()
        Me.chkDEV = New System.Windows.Forms.CheckBox()
        Me.nudLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblParentCode = New System.Windows.Forms.Label()
        Me.txtParentCode = New System.Windows.Forms.TextBox()
        Me.cmdConstDetails = New System.Windows.Forms.Button()
        Me.chkBlank = New System.Windows.Forms.CheckBox()
        Me.chkSeries40ODSplit = New System.Windows.Forms.CheckBox()
        Me.chkSeries20IDSplit = New System.Windows.Forms.CheckBox()
        Me.chkSeries20ODSplit = New System.Windows.Forms.CheckBox()
        Me.chkYULA = New System.Windows.Forms.CheckBox()
        Me.chkYCUL = New System.Windows.Forms.CheckBox()
        Me.chkSeriesL = New System.Windows.Forms.CheckBox()
        Me.chkDOAS = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLoadHP = New System.Windows.Forms.TextBox()
        Me.chkIncludeOnFIOP = New System.Windows.Forms.CheckBox()
        Me.chkDQRqd = New System.Windows.Forms.CheckBox()
        Me.txtDQText = New System.Windows.Forms.TextBox()
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewOpCode
        '
        Me.txtNewOpCode.Location = New System.Drawing.Point(12, 28)
        Me.txtNewOpCode.Name = "txtNewOpCode"
        Me.txtNewOpCode.ReadOnly = True
        Me.txtNewOpCode.Size = New System.Drawing.Size(87, 20)
        Me.txtNewOpCode.TabIndex = 0
        '
        'txtCstmFIOP
        '
        Me.txtCstmFIOP.Location = New System.Drawing.Point(134, 28)
        Me.txtCstmFIOP.Name = "txtCstmFIOP"
        Me.txtCstmFIOP.Size = New System.Drawing.Size(405, 20)
        Me.txtCstmFIOP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FIOP Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIOP Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FIOP Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(134, 67)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(87, 20)
        Me.txtWeight.TabIndex = 4
        '
        'chkMCAChange
        '
        Me.chkMCAChange.AutoSize = True
        Me.chkMCAChange.Location = New System.Drawing.Point(134, 93)
        Me.chkMCAChange.Name = "chkMCAChange"
        Me.chkMCAChange.Size = New System.Drawing.Size(133, 17)
        Me.chkMCAChange.TabIndex = 6
        Me.chkMCAChange.Text = "Causes MCA Change?"
        Me.chkMCAChange.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Load Name"
        Me.Label4.Visible = False
        '
        'txtLoadName
        '
        Me.txtLoadName.Location = New System.Drawing.Point(273, 91)
        Me.txtLoadName.Name = "txtLoadName"
        Me.txtLoadName.Size = New System.Drawing.Size(125, 20)
        Me.txtLoadName.TabIndex = 7
        Me.txtLoadName.Text = "-"
        Me.txtLoadName.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Load Value"
        Me.Label5.Visible = False
        '
        'txtLoadValue
        '
        Me.txtLoadValue.Location = New System.Drawing.Point(404, 91)
        Me.txtLoadValue.Name = "txtLoadValue"
        Me.txtLoadValue.Size = New System.Drawing.Size(135, 20)
        Me.txtLoadValue.TabIndex = 9
        Me.txtLoadValue.Text = "0"
        Me.txtLoadValue.Visible = False
        '
        'chkTestAirflow
        '
        Me.chkTestAirflow.AutoSize = True
        Me.chkTestAirflow.Location = New System.Drawing.Point(134, 221)
        Me.chkTestAirflow.Name = "chkTestAirflow"
        Me.chkTestAirflow.Size = New System.Drawing.Size(81, 17)
        Me.chkTestAirflow.TabIndex = 11
        Me.chkTestAirflow.Text = "Test Airflow"
        Me.chkTestAirflow.UseVisualStyleBackColor = True
        '
        'chkTestCoil
        '
        Me.chkTestCoil.AutoSize = True
        Me.chkTestCoil.Location = New System.Drawing.Point(251, 222)
        Me.chkTestCoil.Name = "chkTestCoil"
        Me.chkTestCoil.Size = New System.Drawing.Size(67, 17)
        Me.chkTestCoil.TabIndex = 12
        Me.chkTestCoil.Text = "Test Coil"
        Me.chkTestCoil.UseVisualStyleBackColor = True
        '
        'chkTestControls
        '
        Me.chkTestControls.AutoSize = True
        Me.chkTestControls.Location = New System.Drawing.Point(362, 222)
        Me.chkTestControls.Name = "chkTestControls"
        Me.chkTestControls.Size = New System.Drawing.Size(88, 17)
        Me.chkTestControls.TabIndex = 13
        Me.chkTestControls.Text = "Test Controls"
        Me.chkTestControls.UseVisualStyleBackColor = True
        '
        'chkTestMotors
        '
        Me.chkTestMotors.AutoSize = True
        Me.chkTestMotors.Location = New System.Drawing.Point(251, 267)
        Me.chkTestMotors.Name = "chkTestMotors"
        Me.chkTestMotors.Size = New System.Drawing.Size(82, 17)
        Me.chkTestMotors.TabIndex = 14
        Me.chkTestMotors.Text = "Test Motors"
        Me.chkTestMotors.UseVisualStyleBackColor = True
        '
        'chkTestEHeat
        '
        Me.chkTestEHeat.AutoSize = True
        Me.chkTestEHeat.Location = New System.Drawing.Point(134, 244)
        Me.chkTestEHeat.Name = "chkTestEHeat"
        Me.chkTestEHeat.Size = New System.Drawing.Size(111, 17)
        Me.chkTestEHeat.TabIndex = 15
        Me.chkTestEHeat.Text = "Test Electric Heat"
        Me.chkTestEHeat.UseVisualStyleBackColor = True
        '
        'chkTestGasHeat
        '
        Me.chkTestGasHeat.AutoSize = True
        Me.chkTestGasHeat.Location = New System.Drawing.Point(251, 244)
        Me.chkTestGasHeat.Name = "chkTestGasHeat"
        Me.chkTestGasHeat.Size = New System.Drawing.Size(95, 17)
        Me.chkTestGasHeat.TabIndex = 16
        Me.chkTestGasHeat.Text = "Test Gas Heat"
        Me.chkTestGasHeat.UseVisualStyleBackColor = True
        '
        'chkTestGasTrain
        '
        Me.chkTestGasTrain.AutoSize = True
        Me.chkTestGasTrain.Location = New System.Drawing.Point(362, 245)
        Me.chkTestGasTrain.Name = "chkTestGasTrain"
        Me.chkTestGasTrain.Size = New System.Drawing.Size(96, 17)
        Me.chkTestGasTrain.TabIndex = 17
        Me.chkTestGasTrain.Text = "Test Gas Train"
        Me.chkTestGasTrain.UseVisualStyleBackColor = True
        '
        'chkTestHydro
        '
        Me.chkTestHydro.AutoSize = True
        Me.chkTestHydro.Location = New System.Drawing.Point(456, 222)
        Me.chkTestHydro.Name = "chkTestHydro"
        Me.chkTestHydro.Size = New System.Drawing.Size(136, 17)
        Me.chkTestHydro.TabIndex = 18
        Me.chkTestHydro.Text = "Test Hydronic Pressure"
        Me.chkTestHydro.UseVisualStyleBackColor = True
        '
        'chkTestRefer
        '
        Me.chkTestRefer.AutoSize = True
        Me.chkTestRefer.Location = New System.Drawing.Point(134, 267)
        Me.chkTestRefer.Name = "chkTestRefer"
        Me.chkTestRefer.Size = New System.Drawing.Size(110, 17)
        Me.chkTestRefer.TabIndex = 19
        Me.chkTestRefer.Text = "Test Refrigeration"
        Me.chkTestRefer.UseVisualStyleBackColor = True
        '
        'chkTestReferInst
        '
        Me.chkTestReferInst.AutoSize = True
        Me.chkTestReferInst.Location = New System.Drawing.Point(456, 245)
        Me.chkTestReferInst.Name = "chkTestReferInst"
        Me.chkTestReferInst.Size = New System.Drawing.Size(163, 17)
        Me.chkTestReferInst.TabIndex = 20
        Me.chkTestReferInst.Text = "Test Refrigeration Installation"
        Me.chkTestReferInst.UseVisualStyleBackColor = True
        '
        'chkSeriesXTI
        '
        Me.chkSeriesXTI.AutoSize = True
        Me.chkSeriesXTI.Location = New System.Drawing.Point(249, 423)
        Me.chkSeriesXTI.Name = "chkSeriesXTI"
        Me.chkSeriesXTI.Size = New System.Drawing.Size(43, 17)
        Me.chkSeriesXTI.TabIndex = 30
        Me.chkSeriesXTI.Text = "XTI"
        Me.chkSeriesXTI.UseVisualStyleBackColor = True
        '
        'chkSeriesXTO
        '
        Me.chkSeriesXTO.AutoSize = True
        Me.chkSeriesXTO.Location = New System.Drawing.Point(132, 423)
        Me.chkSeriesXTO.Name = "chkSeriesXTO"
        Me.chkSeriesXTO.Size = New System.Drawing.Size(48, 17)
        Me.chkSeriesXTO.TabIndex = 29
        Me.chkSeriesXTO.Text = "XTO"
        Me.chkSeriesXTO.UseVisualStyleBackColor = True
        '
        'chkSeries40
        '
        Me.chkSeries40.AutoSize = True
        Me.chkSeries40.Location = New System.Drawing.Point(456, 309)
        Me.chkSeries40.Name = "chkSeries40"
        Me.chkSeries40.Size = New System.Drawing.Size(70, 17)
        Me.chkSeries40.TabIndex = 28
        Me.chkSeries40.Text = "Series 40"
        Me.chkSeries40.UseVisualStyleBackColor = True
        '
        'chkSeries100C
        '
        Me.chkSeries100C.AutoSize = True
        Me.chkSeries100C.Location = New System.Drawing.Point(362, 332)
        Me.chkSeries100C.Name = "chkSeries100C"
        Me.chkSeries100C.Size = New System.Drawing.Size(83, 17)
        Me.chkSeries100C.TabIndex = 27
        Me.chkSeries100C.Text = "Series 100C"
        Me.chkSeries100C.UseVisualStyleBackColor = True
        '
        'chkSeries100B
        '
        Me.chkSeries100B.AutoSize = True
        Me.chkSeries100B.Location = New System.Drawing.Point(251, 331)
        Me.chkSeries100B.Name = "chkSeries100B"
        Me.chkSeries100B.Size = New System.Drawing.Size(83, 17)
        Me.chkSeries100B.TabIndex = 26
        Me.chkSeries100B.Text = "Series 100B"
        Me.chkSeries100B.UseVisualStyleBackColor = True
        '
        'chkSeries100A
        '
        Me.chkSeries100A.AutoSize = True
        Me.chkSeries100A.Location = New System.Drawing.Point(134, 331)
        Me.chkSeries100A.Name = "chkSeries100A"
        Me.chkSeries100A.Size = New System.Drawing.Size(83, 17)
        Me.chkSeries100A.TabIndex = 25
        Me.chkSeries100A.Text = "Series 100A"
        Me.chkSeries100A.UseVisualStyleBackColor = True
        '
        'chkSeriesChoice
        '
        Me.chkSeriesChoice.AutoSize = True
        Me.chkSeriesChoice.Location = New System.Drawing.Point(134, 354)
        Me.chkSeriesChoice.Name = "chkSeriesChoice"
        Me.chkSeriesChoice.Size = New System.Drawing.Size(59, 17)
        Me.chkSeriesChoice.TabIndex = 24
        Me.chkSeriesChoice.Text = "Choice"
        Me.chkSeriesChoice.UseVisualStyleBackColor = True
        '
        'chkSeries20
        '
        Me.chkSeries20.AutoSize = True
        Me.chkSeries20.Location = New System.Drawing.Point(362, 309)
        Me.chkSeries20.Name = "chkSeries20"
        Me.chkSeries20.Size = New System.Drawing.Size(70, 17)
        Me.chkSeries20.TabIndex = 23
        Me.chkSeries20.Text = "Series 20"
        Me.chkSeries20.UseVisualStyleBackColor = True
        '
        'chkSeries10
        '
        Me.chkSeries10.AutoSize = True
        Me.chkSeries10.Location = New System.Drawing.Point(251, 309)
        Me.chkSeries10.Name = "chkSeries10"
        Me.chkSeries10.Size = New System.Drawing.Size(70, 17)
        Me.chkSeries10.TabIndex = 22
        Me.chkSeries10.Text = "Series 10"
        Me.chkSeries10.UseVisualStyleBackColor = True
        '
        'chkSeries5
        '
        Me.chkSeries5.AutoSize = True
        Me.chkSeries5.Location = New System.Drawing.Point(134, 308)
        Me.chkSeries5.Name = "chkSeries5"
        Me.chkSeries5.Size = New System.Drawing.Size(64, 17)
        Me.chkSeries5.TabIndex = 21
        Me.chkSeries5.Text = "Series 5"
        Me.chkSeries5.UseVisualStyleBackColor = True
        '
        'chkSeriesPremier
        '
        Me.chkSeriesPremier.AutoSize = True
        Me.chkSeriesPremier.Location = New System.Drawing.Point(251, 354)
        Me.chkSeriesPremier.Name = "chkSeriesPremier"
        Me.chkSeriesPremier.Size = New System.Drawing.Size(61, 17)
        Me.chkSeriesPremier.TabIndex = 31
        Me.chkSeriesPremier.Text = "Premier"
        Me.chkSeriesPremier.UseVisualStyleBackColor = True
        '
        'chkSeriesSelect
        '
        Me.chkSeriesSelect.AutoSize = True
        Me.chkSeriesSelect.Location = New System.Drawing.Point(362, 355)
        Me.chkSeriesSelect.Name = "chkSeriesSelect"
        Me.chkSeriesSelect.Size = New System.Drawing.Size(56, 17)
        Me.chkSeriesSelect.TabIndex = 32
        Me.chkSeriesSelect.Text = "Select"
        Me.chkSeriesSelect.UseVisualStyleBackColor = True
        '
        'chkSeriesYVAA
        '
        Me.chkSeriesYVAA.AutoSize = True
        Me.chkSeriesYVAA.Location = New System.Drawing.Point(132, 446)
        Me.chkSeriesYVAA.Name = "chkSeriesYVAA"
        Me.chkSeriesYVAA.Size = New System.Drawing.Size(54, 17)
        Me.chkSeriesYVAA.TabIndex = 33
        Me.chkSeriesYVAA.Text = "YVAA"
        Me.chkSeriesYVAA.UseVisualStyleBackColor = True
        '
        'chkSeriesYCAL
        '
        Me.chkSeriesYCAL.AutoSize = True
        Me.chkSeriesYCAL.Location = New System.Drawing.Point(249, 446)
        Me.chkSeriesYCAL.Name = "chkSeriesYCAL"
        Me.chkSeriesYCAL.Size = New System.Drawing.Size(53, 17)
        Me.chkSeriesYCAL.TabIndex = 34
        Me.chkSeriesYCAL.Text = "YCAL"
        Me.chkSeriesYCAL.UseVisualStyleBackColor = True
        '
        'chkSeriesYLAA
        '
        Me.chkSeriesYLAA.AutoSize = True
        Me.chkSeriesYLAA.Location = New System.Drawing.Point(360, 447)
        Me.chkSeriesYLAA.Name = "chkSeriesYLAA"
        Me.chkSeriesYLAA.Size = New System.Drawing.Size(53, 17)
        Me.chkSeriesYLAA.TabIndex = 35
        Me.chkSeriesYLAA.Text = "YLAA"
        Me.chkSeriesYLAA.UseVisualStyleBackColor = True
        '
        'chkSeriesLX
        '
        Me.chkSeriesLX.AutoSize = True
        Me.chkSeriesLX.Location = New System.Drawing.Point(456, 331)
        Me.chkSeriesLX.Name = "chkSeriesLX"
        Me.chkSeriesLX.Size = New System.Drawing.Size(71, 17)
        Me.chkSeriesLX.TabIndex = 36
        Me.chkSeriesLX.Text = "Series LX"
        Me.chkSeriesLX.UseVisualStyleBackColor = True
        '
        'chkSeries12
        '
        Me.chkSeries12.AutoSize = True
        Me.chkSeries12.Location = New System.Drawing.Point(532, 309)
        Me.chkSeries12.Name = "chkSeries12"
        Me.chkSeries12.Size = New System.Drawing.Size(70, 17)
        Me.chkSeries12.TabIndex = 37
        Me.chkSeries12.Text = "Series 12"
        Me.chkSeries12.UseVisualStyleBackColor = True
        '
        'chkTagALongOnly
        '
        Me.chkTagALongOnly.AutoSize = True
        Me.chkTagALongOnly.Location = New System.Drawing.Point(545, 30)
        Me.chkTagALongOnly.Name = "chkTagALongOnly"
        Me.chkTagALongOnly.Size = New System.Drawing.Size(106, 17)
        Me.chkTagALongOnly.TabIndex = 38
        Me.chkTagALongOnly.Text = "Tag A Long Only"
        Me.chkTagALongOnly.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(114, 467)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 40
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 467)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 39
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkDesignCaution
        '
        Me.chkDesignCaution.AutoSize = True
        Me.chkDesignCaution.Location = New System.Drawing.Point(545, 53)
        Me.chkDesignCaution.Name = "chkDesignCaution"
        Me.chkDesignCaution.Size = New System.Drawing.Size(98, 17)
        Me.chkDesignCaution.TabIndex = 41
        Me.chkDesignCaution.Text = "Design Caution"
        Me.chkDesignCaution.UseVisualStyleBackColor = True
        '
        'chkCUL
        '
        Me.chkCUL.AutoSize = True
        Me.chkCUL.Checked = True
        Me.chkCUL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCUL.Location = New System.Drawing.Point(12, 54)
        Me.chkCUL.Name = "chkCUL"
        Me.chkCUL.Size = New System.Drawing.Size(100, 17)
        Me.chkCUL.TabIndex = 42
        Me.chkCUL.Text = "Include on CUL"
        Me.chkCUL.UseVisualStyleBackColor = True
        '
        'chkDEV
        '
        Me.chkDEV.AutoSize = True
        Me.chkDEV.Enabled = False
        Me.chkDEV.Location = New System.Drawing.Point(12, 77)
        Me.chkDEV.Name = "chkDEV"
        Me.chkDEV.Size = New System.Drawing.Size(48, 17)
        Me.chkDEV.TabIndex = 43
        Me.chkDEV.Text = "DEV"
        Me.chkDEV.UseVisualStyleBackColor = True
        '
        'nudLevel
        '
        Me.nudLevel.Enabled = False
        Me.nudLevel.Location = New System.Drawing.Point(15, 182)
        Me.nudLevel.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLevel.Name = "nudLevel"
        Me.nudLevel.Size = New System.Drawing.Size(30, 20)
        Me.nudLevel.TabIndex = 44
        Me.nudLevel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Level"
        '
        'lblParentCode
        '
        Me.lblParentCode.AutoSize = True
        Me.lblParentCode.Location = New System.Drawing.Point(15, 205)
        Me.lblParentCode.Name = "lblParentCode"
        Me.lblParentCode.Size = New System.Drawing.Size(66, 13)
        Me.lblParentCode.TabIndex = 47
        Me.lblParentCode.Text = "Parent Code"
        Me.lblParentCode.Visible = False
        '
        'txtParentCode
        '
        Me.txtParentCode.Location = New System.Drawing.Point(15, 221)
        Me.txtParentCode.Name = "txtParentCode"
        Me.txtParentCode.Size = New System.Drawing.Size(87, 20)
        Me.txtParentCode.TabIndex = 46
        Me.txtParentCode.Visible = False
        '
        'cmdConstDetails
        '
        Me.cmdConstDetails.Location = New System.Drawing.Point(15, 247)
        Me.cmdConstDetails.Name = "cmdConstDetails"
        Me.cmdConstDetails.Size = New System.Drawing.Size(87, 21)
        Me.cmdConstDetails.TabIndex = 48
        Me.cmdConstDetails.Text = "Const. Details"
        Me.cmdConstDetails.UseVisualStyleBackColor = True
        '
        'chkBlank
        '
        Me.chkBlank.AutoSize = True
        Me.chkBlank.Checked = True
        Me.chkBlank.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlank.Enabled = False
        Me.chkBlank.Location = New System.Drawing.Point(530, 423)
        Me.chkBlank.Name = "chkBlank"
        Me.chkBlank.Size = New System.Drawing.Size(53, 17)
        Me.chkBlank.TabIndex = 49
        Me.chkBlank.Text = "Blank"
        Me.chkBlank.UseVisualStyleBackColor = True
        '
        'chkSeries40ODSplit
        '
        Me.chkSeries40ODSplit.AutoSize = True
        Me.chkSeries40ODSplit.Location = New System.Drawing.Point(360, 378)
        Me.chkSeries40ODSplit.Name = "chkSeries40ODSplit"
        Me.chkSeries40ODSplit.Size = New System.Drawing.Size(107, 17)
        Me.chkSeries40ODSplit.TabIndex = 52
        Me.chkSeries40ODSplit.Text = "Series 40 ID Split"
        Me.chkSeries40ODSplit.UseVisualStyleBackColor = True
        '
        'chkSeries20IDSplit
        '
        Me.chkSeries20IDSplit.AutoSize = True
        Me.chkSeries20IDSplit.Location = New System.Drawing.Point(249, 377)
        Me.chkSeries20IDSplit.Name = "chkSeries20IDSplit"
        Me.chkSeries20IDSplit.Size = New System.Drawing.Size(107, 17)
        Me.chkSeries20IDSplit.TabIndex = 51
        Me.chkSeries20IDSplit.Text = "Series 20 ID Split"
        Me.chkSeries20IDSplit.UseVisualStyleBackColor = True
        '
        'chkSeries20ODSplit
        '
        Me.chkSeries20ODSplit.AutoSize = True
        Me.chkSeries20ODSplit.Location = New System.Drawing.Point(132, 377)
        Me.chkSeries20ODSplit.Name = "chkSeries20ODSplit"
        Me.chkSeries20ODSplit.Size = New System.Drawing.Size(112, 17)
        Me.chkSeries20ODSplit.TabIndex = 50
        Me.chkSeries20ODSplit.Text = "Series 20 OD Split"
        Me.chkSeries20ODSplit.UseVisualStyleBackColor = True
        '
        'chkYULA
        '
        Me.chkYULA.AutoSize = True
        Me.chkYULA.Location = New System.Drawing.Point(249, 401)
        Me.chkYULA.Name = "chkYULA"
        Me.chkYULA.Size = New System.Drawing.Size(54, 17)
        Me.chkYULA.TabIndex = 54
        Me.chkYULA.Text = "YULA"
        Me.chkYULA.UseVisualStyleBackColor = True
        '
        'chkYCUL
        '
        Me.chkYCUL.AutoSize = True
        Me.chkYCUL.Location = New System.Drawing.Point(132, 400)
        Me.chkYCUL.Name = "chkYCUL"
        Me.chkYCUL.Size = New System.Drawing.Size(54, 17)
        Me.chkYCUL.TabIndex = 53
        Me.chkYCUL.Text = "YCUL"
        Me.chkYCUL.UseVisualStyleBackColor = True
        '
        'chkSeriesL
        '
        Me.chkSeriesL.AutoSize = True
        Me.chkSeriesL.Location = New System.Drawing.Point(360, 423)
        Me.chkSeriesL.Name = "chkSeriesL"
        Me.chkSeriesL.Size = New System.Drawing.Size(64, 17)
        Me.chkSeriesL.TabIndex = 55
        Me.chkSeriesL.Text = "Series L"
        Me.chkSeriesL.UseVisualStyleBackColor = True
        '
        'chkDOAS
        '
        Me.chkDOAS.AutoSize = True
        Me.chkDOAS.Location = New System.Drawing.Point(454, 423)
        Me.chkDOAS.Name = "chkDOAS"
        Me.chkDOAS.Size = New System.Drawing.Size(64, 17)
        Me.chkDOAS.TabIndex = 56
        Me.chkDOAS.Text = "Addison"
        Me.chkDOAS.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(545, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Load HP"
        Me.Label7.Visible = False
        '
        'txtLoadHP
        '
        Me.txtLoadHP.Location = New System.Drawing.Point(545, 91)
        Me.txtLoadHP.Name = "txtLoadHP"
        Me.txtLoadHP.Size = New System.Drawing.Size(74, 20)
        Me.txtLoadHP.TabIndex = 57
        Me.txtLoadHP.Text = "-"
        Me.txtLoadHP.Visible = False
        '
        'chkIncludeOnFIOP
        '
        Me.chkIncludeOnFIOP.AutoSize = True
        Me.chkIncludeOnFIOP.Checked = True
        Me.chkIncludeOnFIOP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeOnFIOP.Location = New System.Drawing.Point(12, 100)
        Me.chkIncludeOnFIOP.Name = "chkIncludeOnFIOP"
        Me.chkIncludeOnFIOP.Size = New System.Drawing.Size(103, 17)
        Me.chkIncludeOnFIOP.TabIndex = 59
        Me.chkIncludeOnFIOP.Text = "Include on FIOP"
        Me.chkIncludeOnFIOP.UseVisualStyleBackColor = True
        '
        'chkDQRqd
        '
        Me.chkDQRqd.AutoSize = True
        Me.chkDQRqd.Location = New System.Drawing.Point(12, 123)
        Me.chkDQRqd.Name = "chkDQRqd"
        Me.chkDQRqd.Size = New System.Drawing.Size(88, 17)
        Me.chkDQRqd.TabIndex = 60
        Me.chkDQRqd.Text = "DQ Required"
        Me.chkDQRqd.UseVisualStyleBackColor = True
        '
        'txtDQText
        '
        Me.txtDQText.Location = New System.Drawing.Point(12, 146)
        Me.txtDQText.Name = "txtDQText"
        Me.txtDQText.Size = New System.Drawing.Size(527, 20)
        Me.txtDQText.TabIndex = 61
        '
        'frmNewCustomCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDQText)
        Me.Controls.Add(Me.chkDQRqd)
        Me.Controls.Add(Me.chkIncludeOnFIOP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLoadHP)
        Me.Controls.Add(Me.chkDOAS)
        Me.Controls.Add(Me.chkSeriesL)
        Me.Controls.Add(Me.chkYULA)
        Me.Controls.Add(Me.chkYCUL)
        Me.Controls.Add(Me.chkSeries40ODSplit)
        Me.Controls.Add(Me.chkSeries20IDSplit)
        Me.Controls.Add(Me.chkSeries20ODSplit)
        Me.Controls.Add(Me.chkBlank)
        Me.Controls.Add(Me.cmdConstDetails)
        Me.Controls.Add(Me.lblParentCode)
        Me.Controls.Add(Me.txtParentCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudLevel)
        Me.Controls.Add(Me.chkDEV)
        Me.Controls.Add(Me.chkCUL)
        Me.Controls.Add(Me.chkDesignCaution)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkTagALongOnly)
        Me.Controls.Add(Me.chkSeries12)
        Me.Controls.Add(Me.chkSeriesLX)
        Me.Controls.Add(Me.chkSeriesYLAA)
        Me.Controls.Add(Me.chkSeriesYCAL)
        Me.Controls.Add(Me.chkSeriesYVAA)
        Me.Controls.Add(Me.chkSeriesSelect)
        Me.Controls.Add(Me.chkSeriesPremier)
        Me.Controls.Add(Me.chkSeriesXTI)
        Me.Controls.Add(Me.chkSeriesXTO)
        Me.Controls.Add(Me.chkSeries40)
        Me.Controls.Add(Me.chkSeries100C)
        Me.Controls.Add(Me.chkSeries100B)
        Me.Controls.Add(Me.chkSeries100A)
        Me.Controls.Add(Me.chkSeriesChoice)
        Me.Controls.Add(Me.chkSeries20)
        Me.Controls.Add(Me.chkSeries10)
        Me.Controls.Add(Me.chkSeries5)
        Me.Controls.Add(Me.chkTestReferInst)
        Me.Controls.Add(Me.chkTestRefer)
        Me.Controls.Add(Me.chkTestHydro)
        Me.Controls.Add(Me.chkTestGasTrain)
        Me.Controls.Add(Me.chkTestGasHeat)
        Me.Controls.Add(Me.chkTestEHeat)
        Me.Controls.Add(Me.chkTestMotors)
        Me.Controls.Add(Me.chkTestControls)
        Me.Controls.Add(Me.chkTestCoil)
        Me.Controls.Add(Me.chkTestAirflow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLoadValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLoadName)
        Me.Controls.Add(Me.chkMCAChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCstmFIOP)
        Me.Controls.Add(Me.txtNewOpCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewCustomCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Custom Code"
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewOpCode As TextBox
    Friend WithEvents txtCstmFIOP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents chkMCAChange As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLoadName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLoadValue As TextBox
    Friend WithEvents chkTestAirflow As CheckBox
    Friend WithEvents chkTestCoil As CheckBox
    Friend WithEvents chkTestControls As CheckBox
    Friend WithEvents chkTestMotors As CheckBox
    Friend WithEvents chkTestEHeat As CheckBox
    Friend WithEvents chkTestGasHeat As CheckBox
    Friend WithEvents chkTestGasTrain As CheckBox
    Friend WithEvents chkTestHydro As CheckBox
    Friend WithEvents chkTestRefer As CheckBox
    Friend WithEvents chkTestReferInst As CheckBox
    Friend WithEvents chkSeriesXTI As CheckBox
    Friend WithEvents chkSeriesXTO As CheckBox
    Friend WithEvents chkSeries40 As CheckBox
    Friend WithEvents chkSeries100C As CheckBox
    Friend WithEvents chkSeries100B As CheckBox
    Friend WithEvents chkSeries100A As CheckBox
    Friend WithEvents chkSeriesChoice As CheckBox
    Friend WithEvents chkSeries20 As CheckBox
    Friend WithEvents chkSeries10 As CheckBox
    Friend WithEvents chkSeries5 As CheckBox
    Friend WithEvents chkSeriesPremier As CheckBox
    Friend WithEvents chkSeriesSelect As CheckBox
    Friend WithEvents chkSeriesYVAA As CheckBox
    Friend WithEvents chkSeriesYCAL As CheckBox
    Friend WithEvents chkSeriesYLAA As CheckBox
    Friend WithEvents chkSeriesLX As CheckBox
    Friend WithEvents chkSeries12 As CheckBox
    Friend WithEvents chkTagALongOnly As CheckBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chkDesignCaution As CheckBox
    Friend WithEvents chkCUL As CheckBox
    Friend WithEvents chkDEV As CheckBox
    Friend WithEvents nudLevel As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents lblParentCode As Label
    Friend WithEvents txtParentCode As TextBox
    Friend WithEvents cmdConstDetails As Button
    Friend WithEvents chkBlank As CheckBox
    Friend WithEvents chkSeries40ODSplit As CheckBox
    Friend WithEvents chkSeries20IDSplit As CheckBox
    Friend WithEvents chkSeries20ODSplit As CheckBox
    Friend WithEvents chkYULA As CheckBox
    Friend WithEvents chkYCUL As CheckBox
    Friend WithEvents chkSeriesL As CheckBox
    Friend WithEvents chkDOAS As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLoadHP As TextBox
    Friend WithEvents chkIncludeOnFIOP As CheckBox
    Friend WithEvents chkDQRqd As CheckBox
    Friend WithEvents txtDQText As TextBox
End Class
