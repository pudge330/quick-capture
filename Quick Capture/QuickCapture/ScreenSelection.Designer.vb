<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenSelection
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.flpScreens = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(0, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 30)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Apply"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.Location = New System.Drawing.Point(150, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 30)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'flpScreens
        '
        Me.flpScreens.Location = New System.Drawing.Point(18, 49)
        Me.flpScreens.Name = "flpScreens"
        Me.flpScreens.Size = New System.Drawing.Size(264, 232)
        Me.flpScreens.TabIndex = 18
        '
        'ScreenSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(300, 329)
        Me.Controls.Add(Me.flpScreens)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScreenSelection"
        Me.Text = "ScreenSecection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents flpScreens As System.Windows.Forms.FlowLayoutPanel
End Class
