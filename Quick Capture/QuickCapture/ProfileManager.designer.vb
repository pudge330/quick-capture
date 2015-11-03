<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile_Manager
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
        Me.lbProfiles = New System.Windows.Forms.ListBox()
        Me.tbNewName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbExistingName = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbProfiles
        '
        Me.lbProfiles.FormattingEnabled = True
        Me.lbProfiles.Location = New System.Drawing.Point(6, 37)
        Me.lbProfiles.Name = "lbProfiles"
        Me.lbProfiles.Size = New System.Drawing.Size(141, 238)
        Me.lbProfiles.Sorted = True
        Me.lbProfiles.TabIndex = 4
        '
        'tbNewName
        '
        Me.tbNewName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewName.Location = New System.Drawing.Point(153, 81)
        Me.tbNewName.Name = "tbNewName"
        Me.tbNewName.Size = New System.Drawing.Size(141, 22)
        Me.tbNewName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(153, 109)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(141, 23)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "Add"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(154, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "New Profile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(154, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Selected Profile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name"
        '
        'tbExistingName
        '
        Me.tbExistingName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExistingName.Location = New System.Drawing.Point(153, 194)
        Me.tbExistingName.Name = "tbExistingName"
        Me.tbExistingName.Size = New System.Drawing.Size(141, 22)
        Me.tbExistingName.TabIndex = 11
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(153, 251)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(141, 23)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(0, 298)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Location = New System.Drawing.Point(150, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(153, 222)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(141, 23)
        Me.btnApply.TabIndex = 17
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Profile_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(300, 329)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbExistingName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNewName)
        Me.Controls.Add(Me.lbProfiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Profile_Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbProfiles As System.Windows.Forms.ListBox
    Friend WithEvents tbNewName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbExistingName As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
End Class
