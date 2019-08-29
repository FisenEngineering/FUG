<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCstmAirside
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
        Me.pgProposal = New System.Windows.Forms.TabPage()
        Me.pgConstruction = New System.Windows.Forms.TabPage()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnDoneCouplings = New System.Windows.Forms.Button()
        Me.pgCooling = New System.Windows.Forms.TabPage()
        Me.pgHeating = New System.Windows.Forms.TabPage()
        Me.pgReheat = New System.Windows.Forms.TabPage()
        Me.pgSupplyFan = New System.Windows.Forms.TabPage()
        Me.pgReturnFan = New System.Windows.Forms.TabPage()
        Me.pgExhaustFan = New System.Windows.Forms.TabPage()
        Me.pgOutdoorAir = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.pgProposal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgProposal)
        Me.TabControl1.Controls.Add(Me.pgConstruction)
        Me.TabControl1.Controls.Add(Me.pgCooling)
        Me.TabControl1.Controls.Add(Me.pgHeating)
        Me.TabControl1.Controls.Add(Me.pgReheat)
        Me.TabControl1.Controls.Add(Me.pgSupplyFan)
        Me.TabControl1.Controls.Add(Me.pgReturnFan)
        Me.TabControl1.Controls.Add(Me.pgExhaustFan)
        Me.TabControl1.Controls.Add(Me.pgOutdoorAir)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1177, 544)
        Me.TabControl1.TabIndex = 0
        '
        'pgProposal
        '
        Me.pgProposal.Controls.Add(Me.btnDoneCouplings)
        Me.pgProposal.Location = New System.Drawing.Point(4, 22)
        Me.pgProposal.Name = "pgProposal"
        Me.pgProposal.Padding = New System.Windows.Forms.Padding(3)
        Me.pgProposal.Size = New System.Drawing.Size(1169, 518)
        Me.pgProposal.TabIndex = 0
        Me.pgProposal.Text = "Proposal"
        Me.pgProposal.UseVisualStyleBackColor = True
        '
        'pgConstruction
        '
        Me.pgConstruction.Location = New System.Drawing.Point(4, 22)
        Me.pgConstruction.Name = "pgConstruction"
        Me.pgConstruction.Padding = New System.Windows.Forms.Padding(3)
        Me.pgConstruction.Size = New System.Drawing.Size(1169, 518)
        Me.pgConstruction.TabIndex = 1
        Me.pgConstruction.Text = "Construction"
        Me.pgConstruction.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 566)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 36)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(13, 566)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 36)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnDoneCouplings
        '
        Me.btnDoneCouplings.Location = New System.Drawing.Point(1066, 475)
        Me.btnDoneCouplings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoneCouplings.Name = "btnDoneCouplings"
        Me.btnDoneCouplings.Size = New System.Drawing.Size(96, 36)
        Me.btnDoneCouplings.TabIndex = 22
        Me.btnDoneCouplings.Text = ">"
        Me.btnDoneCouplings.UseVisualStyleBackColor = True
        '
        'pgCooling
        '
        Me.pgCooling.Location = New System.Drawing.Point(4, 22)
        Me.pgCooling.Name = "pgCooling"
        Me.pgCooling.Padding = New System.Windows.Forms.Padding(3)
        Me.pgCooling.Size = New System.Drawing.Size(1169, 518)
        Me.pgCooling.TabIndex = 2
        Me.pgCooling.Text = "pgCooling"
        Me.pgCooling.UseVisualStyleBackColor = True
        '
        'pgHeating
        '
        Me.pgHeating.Location = New System.Drawing.Point(4, 22)
        Me.pgHeating.Name = "pgHeating"
        Me.pgHeating.Size = New System.Drawing.Size(1169, 518)
        Me.pgHeating.TabIndex = 3
        Me.pgHeating.Text = "Heating"
        Me.pgHeating.UseVisualStyleBackColor = True
        '
        'pgReheat
        '
        Me.pgReheat.Location = New System.Drawing.Point(4, 22)
        Me.pgReheat.Name = "pgReheat"
        Me.pgReheat.Size = New System.Drawing.Size(1169, 518)
        Me.pgReheat.TabIndex = 4
        Me.pgReheat.Text = "Reheat"
        Me.pgReheat.UseVisualStyleBackColor = True
        '
        'pgSupplyFan
        '
        Me.pgSupplyFan.Location = New System.Drawing.Point(4, 22)
        Me.pgSupplyFan.Name = "pgSupplyFan"
        Me.pgSupplyFan.Size = New System.Drawing.Size(1169, 518)
        Me.pgSupplyFan.TabIndex = 5
        Me.pgSupplyFan.Text = "Supply Fan"
        Me.pgSupplyFan.UseVisualStyleBackColor = True
        '
        'pgReturnFan
        '
        Me.pgReturnFan.Location = New System.Drawing.Point(4, 22)
        Me.pgReturnFan.Name = "pgReturnFan"
        Me.pgReturnFan.Size = New System.Drawing.Size(1169, 518)
        Me.pgReturnFan.TabIndex = 6
        Me.pgReturnFan.Text = "Return Fan"
        Me.pgReturnFan.UseVisualStyleBackColor = True
        '
        'pgExhaustFan
        '
        Me.pgExhaustFan.Location = New System.Drawing.Point(4, 22)
        Me.pgExhaustFan.Name = "pgExhaustFan"
        Me.pgExhaustFan.Size = New System.Drawing.Size(1169, 518)
        Me.pgExhaustFan.TabIndex = 7
        Me.pgExhaustFan.Text = "Exhaust Fan"
        Me.pgExhaustFan.UseVisualStyleBackColor = True
        '
        'pgOutdoorAir
        '
        Me.pgOutdoorAir.Location = New System.Drawing.Point(4, 22)
        Me.pgOutdoorAir.Name = "pgOutdoorAir"
        Me.pgOutdoorAir.Size = New System.Drawing.Size(1169, 518)
        Me.pgOutdoorAir.TabIndex = 8
        Me.pgOutdoorAir.Text = "Outdoor Air"
        Me.pgOutdoorAir.UseVisualStyleBackColor = True
        '
        'frmCstmAirside
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1201, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCstmAirside"
        Me.Text = "Custom Airside"
        Me.TabControl1.ResumeLayout(False)
        Me.pgProposal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgProposal As TabPage
    Friend WithEvents pgConstruction As TabPage
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnDoneCouplings As Button
    Friend WithEvents pgCooling As TabPage
    Friend WithEvents pgHeating As TabPage
    Friend WithEvents pgReheat As TabPage
    Friend WithEvents pgSupplyFan As TabPage
    Friend WithEvents pgReturnFan As TabPage
    Friend WithEvents pgExhaustFan As TabPage
    Friend WithEvents pgOutdoorAir As TabPage
End Class
