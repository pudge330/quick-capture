<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickCaptureForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickCaptureForm))
        Me.pPreviewBar = New System.Windows.Forms.Panel()
        Me.pPreviewArrowsRight = New System.Windows.Forms.Panel()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.pPreviewArrowsLeft = New System.Windows.Forms.Panel()
        Me.pControlsToHide = New System.Windows.Forms.Panel()
        Me.btnCamera = New QuickCapture.FlatButton()
        Me.btnFolder = New QuickCapture.FlatButton()
        Me.btnSave = New QuickCapture.FlatButton()
        Me.pPreview = New System.Windows.Forms.Panel()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.tbDirectory = New System.Windows.Forms.TextBox()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.niMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsiCapture = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSettings = New QuickCapture.FlatButton()
        Me.btnMinimize = New QuickCapture.FlatButton()
        Me.btnClose = New QuickCapture.FlatButton()
        Me.pPreviewBar.SuspendLayout()
        Me.pControlsToHide.SuspendLayout()
        Me.cmsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPreviewBar
        '
        Me.pPreviewBar.BackColor = System.Drawing.Color.Transparent
        Me.pPreviewBar.Controls.Add(Me.pPreviewArrowsRight)
        Me.pPreviewBar.Controls.Add(Me.lblPreview)
        Me.pPreviewBar.Controls.Add(Me.pPreviewArrowsLeft)
        Me.pPreviewBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pPreviewBar.Location = New System.Drawing.Point(0, 385)
        Me.pPreviewBar.Name = "pPreviewBar"
        Me.pPreviewBar.Size = New System.Drawing.Size(800, 15)
        Me.pPreviewBar.TabIndex = 0
        '
        'pPreviewArrowsRight
        '
        Me.pPreviewArrowsRight.Location = New System.Drawing.Point(432, 0)
        Me.pPreviewArrowsRight.Name = "pPreviewArrowsRight"
        Me.pPreviewArrowsRight.Size = New System.Drawing.Size(32, 15)
        Me.pPreviewArrowsRight.TabIndex = 2
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Location = New System.Drawing.Point(375, 1)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(51, 13)
        Me.lblPreview.TabIndex = 0
        Me.lblPreview.Text = "(Preview)"
        '
        'pPreviewArrowsLeft
        '
        Me.pPreviewArrowsLeft.Location = New System.Drawing.Point(337, 0)
        Me.pPreviewArrowsLeft.Name = "pPreviewArrowsLeft"
        Me.pPreviewArrowsLeft.Size = New System.Drawing.Size(32, 15)
        Me.pPreviewArrowsLeft.TabIndex = 1
        '
        'pControlsToHide
        '
        Me.pControlsToHide.BackColor = System.Drawing.Color.Transparent
        Me.pControlsToHide.Controls.Add(Me.btnCamera)
        Me.pControlsToHide.Controls.Add(Me.btnFolder)
        Me.pControlsToHide.Controls.Add(Me.btnSave)
        Me.pControlsToHide.Controls.Add(Me.pPreview)
        Me.pControlsToHide.Controls.Add(Me.lblDirectory)
        Me.pControlsToHide.Controls.Add(Me.lblFileName)
        Me.pControlsToHide.Controls.Add(Me.tbDirectory)
        Me.pControlsToHide.Controls.Add(Me.tbFileName)
        Me.pControlsToHide.Location = New System.Drawing.Point(0, 31)
        Me.pControlsToHide.Name = "pControlsToHide"
        Me.pControlsToHide.Size = New System.Drawing.Size(761, 354)
        Me.pControlsToHide.TabIndex = 0
        '
        'btnCamera
        '
        Me.btnCamera.BackColor = System.Drawing.Color.Transparent
        Me.btnCamera.BackgroundImage = Global.QuickCapture.My.Resources.Resources.camera44
        Me.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCamera.ClickColor = System.Drawing.Color.Gray
        Me.btnCamera.ClickImage = Nothing
        Me.btnCamera.HoverColor = System.Drawing.Color.SlateGray
        Me.btnCamera.HoverImage = Nothing
        Me.btnCamera.Location = New System.Drawing.Point(4, 4)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.NormalColor = System.Drawing.Color.Transparent
        Me.btnCamera.NormalImage = Global.QuickCapture.My.Resources.Resources.camera44
        Me.btnCamera.Size = New System.Drawing.Size(35, 35)
        Me.btnCamera.TabIndex = 10
        '
        'btnFolder
        '
        Me.btnFolder.BackColor = System.Drawing.Color.Transparent
        Me.btnFolder.BackgroundImage = Global.QuickCapture.My.Resources.Resources.folder250
        Me.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFolder.ClickColor = System.Drawing.Color.Gray
        Me.btnFolder.ClickImage = Nothing
        Me.btnFolder.HoverColor = System.Drawing.Color.SlateGray
        Me.btnFolder.HoverImage = Nothing
        Me.btnFolder.Location = New System.Drawing.Point(681, 4)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.NormalColor = System.Drawing.Color.Transparent
        Me.btnFolder.NormalImage = Global.QuickCapture.My.Resources.Resources.folder250
        Me.btnFolder.Size = New System.Drawing.Size(35, 35)
        Me.btnFolder.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = Global.QuickCapture.My.Resources.Resources.floppy1
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.ClickColor = System.Drawing.Color.Gray
        Me.btnSave.ClickImage = Nothing
        Me.btnSave.HoverColor = System.Drawing.Color.SlateGray
        Me.btnSave.HoverImage = Nothing
        Me.btnSave.Location = New System.Drawing.Point(721, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NormalColor = System.Drawing.Color.Transparent
        Me.btnSave.NormalImage = Global.QuickCapture.My.Resources.Resources.floppy1
        Me.btnSave.Size = New System.Drawing.Size(35, 35)
        Me.btnSave.TabIndex = 9
        '
        'pPreview
        '
        Me.pPreview.BackColor = System.Drawing.Color.Transparent
        Me.pPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pPreview.Location = New System.Drawing.Point(39, 69)
        Me.pPreview.Name = "pPreview"
        Me.pPreview.Size = New System.Drawing.Size(722, 275)
        Me.pPreview.TabIndex = 8
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.ForeColor = System.Drawing.Color.White
        Me.lblDirectory.Location = New System.Drawing.Point(511, 42)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(49, 13)
        Me.lblDirectory.TabIndex = 7
        Me.lblDirectory.Text = "Directory"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.ForeColor = System.Drawing.Color.White
        Me.lblFileName.Location = New System.Drawing.Point(41, 42)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(54, 13)
        Me.lblFileName.TabIndex = 6
        Me.lblFileName.Text = "File Name"
        '
        'tbDirectory
        '
        Me.tbDirectory.Enabled = False
        Me.tbDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDirectory.ForeColor = System.Drawing.Color.Black
        Me.tbDirectory.Location = New System.Drawing.Point(514, 4)
        Me.tbDirectory.Name = "tbDirectory"
        Me.tbDirectory.ReadOnly = True
        Me.tbDirectory.Size = New System.Drawing.Size(162, 35)
        Me.tbDirectory.TabIndex = 5
        '
        'tbFileName
        '
        Me.tbFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFileName.Location = New System.Drawing.Point(44, 4)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(466, 35)
        Me.tbFileName.TabIndex = 4
        '
        'niMain
        '
        Me.niMain.ContextMenuStrip = Me.cmsMain
        Me.niMain.Icon = CType(resources.GetObject("niMain.Icon"), System.Drawing.Icon)
        Me.niMain.Text = "Quick Capture" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<SHIFT + ALT + P>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.niMain.Visible = True
        '
        'cmsMain
        '
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsiCapture, Me.cmsiExit})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.Size = New System.Drawing.Size(223, 48)
        '
        'cmsiCapture
        '
        Me.cmsiCapture.Name = "cmsiCapture"
        Me.cmsiCapture.Size = New System.Drawing.Size(222, 22)
        Me.cmsiCapture.Text = "Capture <SHIFT + ALT + P>"
        '
        'cmsiExit
        '
        Me.cmsiExit.Name = "cmsiExit"
        Me.cmsiExit.Size = New System.Drawing.Size(222, 22)
        Me.cmsiExit.Text = "Exit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImage = Global.QuickCapture.My.Resources.Resources.settings21
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSettings.ClickColor = System.Drawing.Color.Gray
        Me.btnSettings.ClickImage = Nothing
        Me.btnSettings.HoverColor = System.Drawing.Color.SlateGray
        Me.btnSettings.HoverImage = Nothing
        Me.btnSettings.Location = New System.Drawing.Point(761, 35)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.NormalColor = System.Drawing.Color.Transparent
        Me.btnSettings.NormalImage = Global.QuickCapture.My.Resources.Resources.settings21
        Me.btnSettings.Size = New System.Drawing.Size(35, 35)
        Me.btnSettings.TabIndex = 7
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.SlateGray
        Me.btnMinimize.BackgroundImage = Global.QuickCapture.My.Resources.Resources.minimize_normal
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.ClickColor = System.Drawing.Color.Transparent
        Me.btnMinimize.ClickImage = Global.QuickCapture.My.Resources.Resources.minimize_click
        Me.btnMinimize.HoverColor = System.Drawing.Color.Transparent
        Me.btnMinimize.HoverImage = Global.QuickCapture.My.Resources.Resources.minimize_hover
        Me.btnMinimize.Location = New System.Drawing.Point(744, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NormalColor = System.Drawing.Color.SlateGray
        Me.btnMinimize.NormalImage = Global.QuickCapture.My.Resources.Resources.minimize_normal
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SlateGray
        Me.btnClose.BackgroundImage = Global.QuickCapture.My.Resources.Resources.close_normal
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.ClickColor = System.Drawing.Color.Transparent
        Me.btnClose.ClickImage = Global.QuickCapture.My.Resources.Resources.close_click
        Me.btnClose.HoverColor = System.Drawing.Color.Transparent
        Me.btnClose.HoverImage = Global.QuickCapture.My.Resources.Resources.close_hover
        Me.btnClose.Location = New System.Drawing.Point(772, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NormalColor = System.Drawing.Color.SlateGray
        Me.btnClose.NormalImage = Global.QuickCapture.My.Resources.Resources.close_normal
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 5
        '
        'QuickCaptureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pPreviewBar)
        Me.Controls.Add(Me.pControlsToHide)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "QuickCaptureForm"
        Me.TopMost = True
        Me.pPreviewBar.ResumeLayout(False)
        Me.pPreviewBar.PerformLayout()
        Me.pControlsToHide.ResumeLayout(False)
        Me.pControlsToHide.PerformLayout()
        Me.cmsMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPreviewBar As System.Windows.Forms.Panel
    Friend WithEvents pPreviewArrowsRight As System.Windows.Forms.Panel
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents pPreviewArrowsLeft As System.Windows.Forms.Panel
    Friend WithEvents pControlsToHide As System.Windows.Forms.Panel
    Friend WithEvents pPreview As System.Windows.Forms.Panel
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents tbDirectory As System.Windows.Forms.TextBox
    Friend WithEvents tbFileName As System.Windows.Forms.TextBox
    Friend WithEvents niMain As System.Windows.Forms.NotifyIcon
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents btnClose As QuickCapture.FlatButton
    Friend WithEvents btnMinimize As QuickCapture.FlatButton
    Friend WithEvents btnSettings As QuickCapture.FlatButton
    Friend WithEvents btnSave As QuickCapture.FlatButton
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsiCapture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCamera As QuickCapture.FlatButton
    Friend WithEvents btnFolder As QuickCapture.FlatButton

End Class
