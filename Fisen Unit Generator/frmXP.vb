Imports System.ComponentModel
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class frmXP
    Private pCancelled As Boolean
    Private ModuleCodeList As New ArrayList
    Private pGroup As String
    Private pDivision As String
    Private pClass As String

    Public Property Cancelled As Boolean
        Get
            Return pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Private Sub frmXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMain.ThisUnitElecData.UnitIs65kASCCR = True Then chk65kASCCRBase.Checked = True

        If Not (frmMain.chkSaveinProjDB.Checked) Then chkWriteHistory.Checked = False
        If frmMain.chkDebug.Checked Then chkWriteHistory.Checked = False

        cmbClass.Text = "Unselected"
        cmbDivision.Text = "Unselected"
        cmbGroup.Text = "Unselected"

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pCancelled = False
        pGroup = "Unselected"
        pDivision = "Unselected"
        pClass = "Unselected"

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Call UpdatePerformance()
        'Call UpdateWeightTable()
        'Call UpdateWarrantyItems
        frmMain.ThisUnitMods.Add("XP")
        'Call UpdateCodeList()
        'If chkWriteHistory.Checked = True Then Call WriteXPHistory()
        'Call WriteModuleData()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedIndexChanged
        Select Case cmbClass.Text
            Case Is = "Class I"
                txtCDGDescription.Text = "Flamable Gasses and Vapors" & vbCrLf
                cmbClass.Enabled = False
                cmbDivision.Items.Clear()
                cmbDivision.Items.Add("1")
                cmbDivision.Items.Add("2")
                cmbDivision.Items.Add("Unselected")
                cmbDivision.Text = "Unselected"
                Call PopulateGroup("I")
            Case Is = "Class II"
                txtCDGDescription.Text = "Combustible Dust" & vbCrLf
                cmbClass.Enabled = False
                cmbDivision.Items.Clear()
                cmbDivision.Items.Add("1")
                cmbDivision.Items.Add("2")
                cmbDivision.Items.Add("Unselected")
                cmbDivision.Text = "Unselected"
                Call PopulateGroup("II")
            Case Is = "Class III"
                txtCDGDescription.Text = "Fibers and Filings" & vbCrLf
                cmbClass.Enabled = False
                cmbDivision.Items.Clear()
                cmbDivision.Items.Add("1")
                cmbDivision.Items.Add("2")
                cmbDivision.Items.Add("Unselected")
                cmbDivision.Text = "Unselected"
                Call PopulateGroup("III")
            Case Else
                cmbDivision.Items.Add("Unselected")
                cmbDivision.Text = "Unselected"
        End Select
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDivision.SelectedIndexChanged
        Select Case cmbDivision.Text
            Case Is = "1"
                txtCDGDescription.Text = txtCDGDescription.Text & "Hazard exists under normal operating conditions or routine maintenance." & vbCrLf
                cmbDivision.Enabled = False
                cmbGroup.Text = "Unselected"

            Case Is = "2"
                txtCDGDescription.Text = txtCDGDescription.Text & "Hazard exists under abnormal operating conditions." & vbCrLf
                cmbDivision.Enabled = False
                cmbGroup.Text = "Unselected"

            Case Else
                cmbGroup.Text = "Unselected"
        End Select
    End Sub

    Private Sub PopulateGroup(ThisClass As String)
        cmbGroup.Items.Clear()

        Select Case ThisClass
            Case Is = "I"
                cmbGroup.Items.Add("A - Acetylene")
                cmbGroup.Items.Add("B - Hydrogen, Butadiene, Ethylene Oxide, Propylene Oxide, and Acrolein")
                cmbGroup.Items.Add("C - Ethylene, Cyclopropane, Ethyl Ether")
                cmbGroup.Items.Add("D - Acetone, Ammonia, Benzene, Butane, Ethanol, Gasoline, Hexane, Methane, Methanol, Methane, Naphtha, Natural Gas, Propane, and Toluene")
            Case Is = "II"
                cmbGroup.Items.Add("E - Metal Dusts")
                cmbGroup.Items.Add("F - Carbonaceous Dusts")
                cmbGroup.Items.Add("G - Other Dusts")
            Case Is = "III"
                cmbGroup.Items.Add("Not Applicable to this Class")
        End Select
        cmbGroup.Items.Add("Unselected")
        cmbGroup.Text = "Unselected"

    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If cmbGroup.Text <> "Unselected" Then
            If Not (cmbClass.Text = "Class III") Then

            Else
                txtCDGDescription.Text = txtCDGDescription.Text & "No Groups defined for this Class of location." & vbCrLf
            End If
        End If
        cmbGroup.Enabled = False
    End Sub

    Private Sub cmdResetCDG_Click(sender As Object, e As EventArgs) Handles cmdResetCDG.Click
        cmbGroup.Items.Clear()
        cmbGroup.Items.Add("Unselected")
        cmbGroup.Enabled = True
        cmbGroup.Text = "Unselected"

        cmbClass.Items.Clear()
        cmbClass.Items.Add("Unselected")
        cmbClass.Items.Add("Class I")
        cmbClass.Items.Add("Class II")
        cmbClass.Items.Add("Class III")
        cmbClass.Enabled = True
        cmbClass.Text = "Unselected"

        cmbDivision.Items.Clear()
        cmbDivision.Items.Add("Unselected")
        cmbDivision.Enabled = True
        cmbDivision.Text = "Unselected"

        txtCDGDescription.Text = "Undefined"

    End Sub
End Class