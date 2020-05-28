<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWMFZoom
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
        Me.picZoomBox = New System.Windows.Forms.PictureBox()
        CType(Me.picZoomBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picZoomBox
        '
        Me.picZoomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picZoomBox.Location = New System.Drawing.Point(12, 12)
        Me.picZoomBox.Name = "picZoomBox"
        Me.picZoomBox.Size = New System.Drawing.Size(1306, 674)
        Me.picZoomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picZoomBox.TabIndex = 0
        Me.picZoomBox.TabStop = False
        '
        'frmWMFZoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 698)
        Me.Controls.Add(Me.picZoomBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWMFZoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmWMFZoom"
        CType(Me.picZoomBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picZoomBox As PictureBox
End Class
