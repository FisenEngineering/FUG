<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlankWarranty
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
        Me.Label54 = New System.Windows.Forms.Label()
        Me.clbTestList = New System.Windows.Forms.CheckedListBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(91, 13)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(66, 13)
        Me.Label54.TabIndex = 21
        Me.Label54.Text = "Testing Text"
        '
        'clbTestList
        '
        Me.clbTestList.CheckOnClick = True
        Me.clbTestList.FormattingEnabled = True
        Me.clbTestList.Items.AddRange(New Object() {"Quality Assurance Inspection", "Airflow Run Test", "Coil Pressure Test", "Electrical Controls Run Test", "Electric Motor Test", "Electric Heat Run Test", "Gas Heat Run Test", "Gas Train Inspection", "Hydronic Pressure Test", "Refrigeration Run Test", "Refrigeration System Inspection"})
        Me.clbTestList.Location = New System.Drawing.Point(13, 32)
        Me.clbTestList.Margin = New System.Windows.Forms.Padding(4)
        Me.clbTestList.Name = "clbTestList"
        Me.clbTestList.Size = New System.Drawing.Size(241, 169)
        Me.clbTestList.TabIndex = 20
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(91, 208)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 29)
        Me.Cancel.TabIndex = 23
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(13, 208)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 29)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmBlankWarranty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.clbTestList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBlankWarranty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Please Select Required Warranty"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label54 As Label
    Friend WithEvents clbTestList As CheckedListBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnOK As Button
End Class
