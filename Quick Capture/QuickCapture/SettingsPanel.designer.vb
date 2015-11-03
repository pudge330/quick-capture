<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanel))
        Me.cbSingleImage = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbPostfix = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPrefix = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbHotKey = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbHKMod2 = New System.Windows.Forms.ComboBox()
        Me.cbHKMod1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbViewScreen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDelay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.tbSaveLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pBorder = New System.Windows.Forms.Panel()
        Me.btnManageProfiles = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProfiles = New System.Windows.Forms.ComboBox()
        Me.cbClipboard = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbAllScreens = New System.Windows.Forms.ComboBox()
        Me.btnChooseScreens = New System.Windows.Forms.Button()
        Me.lDefaultScreens = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbAutoStart = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'cbSingleImage
        '
        Me.cbSingleImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSingleImage.FormattingEnabled = True
        Me.cbSingleImage.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbSingleImage.Location = New System.Drawing.Point(6, 345)
        Me.cbSingleImage.Name = "cbSingleImage"
        Me.cbSingleImage.Size = New System.Drawing.Size(156, 21)
        Me.cbSingleImage.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Save as Single Image"
        '
        'tbPostfix
        '
        Me.tbPostfix.Location = New System.Drawing.Point(6, 294)
        Me.tbPostfix.Name = "tbPostfix"
        Me.tbPostfix.Size = New System.Drawing.Size(156, 20)
        Me.tbPostfix.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Postfix"
        '
        'tbPrefix
        '
        Me.tbPrefix.Location = New System.Drawing.Point(6, 236)
        Me.tbPrefix.Name = "tbPrefix"
        Me.tbPrefix.Size = New System.Drawing.Size(156, 20)
        Me.tbPrefix.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Prefix"
        '
        'cbHotKey
        '
        Me.cbHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHotKey.FormattingEnabled = True
        Me.cbHotKey.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Num 0", "Num 1", "Num 2", "Num 3", "Num 4", "Num 5", "Num 6", "Num 7", "Num 8", "Num 9", "NumPad 0", "NumPad 1", "NumPad 2", "NumPad 3", "NumPad 4", "NumPad 5", "NumPad 6", "NumPad 7", "NumPad 8", "NumPad 9"})
        Me.cbHotKey.Location = New System.Drawing.Point(400, 175)
        Me.cbHotKey.Name = "cbHotKey"
        Me.cbHotKey.Size = New System.Drawing.Size(196, 21)
        Me.cbHotKey.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Hot Key"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(488, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 12)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "and"
        '
        'cbHKMod2
        '
        Me.cbHKMod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHKMod2.FormattingEnabled = True
        Me.cbHKMod2.Items.AddRange(New Object() {"ALT", "CONTROL", "SHIFT", "WINDOW", "-- NONE --"})
        Me.cbHKMod2.Location = New System.Drawing.Point(514, 119)
        Me.cbHKMod2.Name = "cbHKMod2"
        Me.cbHKMod2.Size = New System.Drawing.Size(82, 21)
        Me.cbHKMod2.TabIndex = 38
        '
        'cbHKMod1
        '
        Me.cbHKMod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHKMod1.FormattingEnabled = True
        Me.cbHKMod1.Items.AddRange(New Object() {"ALT", "CONTROL", "SHIFT", "WINDOW"})
        Me.cbHKMod1.Location = New System.Drawing.Point(400, 119)
        Me.cbHKMod1.Name = "cbHKMod1"
        Me.cbHKMod1.Size = New System.Drawing.Size(82, 21)
        Me.cbHKMod1.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Hot Key Modifier"
        '
        'cbViewScreen
        '
        Me.cbViewScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbViewScreen.FormattingEnabled = True
        Me.cbViewScreen.Location = New System.Drawing.Point(6, 175)
        Me.cbViewScreen.Name = "cbViewScreen"
        Me.cbViewScreen.Size = New System.Drawing.Size(156, 21)
        Me.cbViewScreen.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Viewing Screen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 12)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "1000 = 1 Sec"
        '
        'tbDelay
        '
        Me.tbDelay.Location = New System.Drawing.Point(6, 115)
        Me.tbDelay.Name = "tbDelay"
        Me.tbDelay.Size = New System.Drawing.Size(93, 20)
        Me.tbDelay.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Snapshot Delay (Open Window)"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(678, 53)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(118, 23)
        Me.btnBrowse.TabIndex = 30
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'tbSaveLocation
        '
        Me.tbSaveLocation.Location = New System.Drawing.Point(110, 55)
        Me.tbSaveLocation.Name = "tbSaveLocation"
        Me.tbSaveLocation.ReadOnly = True
        Me.tbSaveLocation.Size = New System.Drawing.Size(562, 20)
        Me.tbSaveLocation.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Default Location"
        '
        'pBorder
        '
        Me.pBorder.BackColor = System.Drawing.Color.Black
        Me.pBorder.Location = New System.Drawing.Point(4, 42)
        Me.pBorder.Name = "pBorder"
        Me.pBorder.Size = New System.Drawing.Size(749, 1)
        Me.pBorder.TabIndex = 27
        '
        'btnManageProfiles
        '
        Me.btnManageProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageProfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProfiles.Location = New System.Drawing.Point(608, 4)
        Me.btnManageProfiles.Name = "btnManageProfiles"
        Me.btnManageProfiles.Size = New System.Drawing.Size(145, 35)
        Me.btnManageProfiles.TabIndex = 26
        Me.btnManageProfiles.Text = "Manage Profiles"
        Me.btnManageProfiles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Current Profile"
        '
        'cbProfiles
        '
        Me.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProfiles.FormattingEnabled = True
        Me.cbProfiles.Location = New System.Drawing.Point(115, 4)
        Me.cbProfiles.Name = "cbProfiles"
        Me.cbProfiles.Size = New System.Drawing.Size(487, 33)
        Me.cbProfiles.TabIndex = 24
        '
        'cbClipboard
        '
        Me.cbClipboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClipboard.FormattingEnabled = True
        Me.cbClipboard.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbClipboard.Location = New System.Drawing.Point(400, 345)
        Me.cbClipboard.Name = "cbClipboard"
        Me.cbClipboard.Size = New System.Drawing.Size(156, 21)
        Me.cbClipboard.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(397, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Copy To Clipboard"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(397, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "All Screens"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(397, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Screen(s) to Capture"
        '
        'cbAllScreens
        '
        Me.cbAllScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAllScreens.FormattingEnabled = True
        Me.cbAllScreens.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbAllScreens.Location = New System.Drawing.Point(400, 293)
        Me.cbAllScreens.Name = "cbAllScreens"
        Me.cbAllScreens.Size = New System.Drawing.Size(156, 21)
        Me.cbAllScreens.TabIndex = 54
        '
        'btnChooseScreens
        '
        Me.btnChooseScreens.Location = New System.Drawing.Point(400, 233)
        Me.btnChooseScreens.Name = "btnChooseScreens"
        Me.btnChooseScreens.Size = New System.Drawing.Size(101, 23)
        Me.btnChooseScreens.TabIndex = 55
        Me.btnChooseScreens.Text = "Select"
        Me.btnChooseScreens.UseVisualStyleBackColor = True
        '
        'lDefaultScreens
        '
        Me.lDefaultScreens.AutoSize = True
        Me.lDefaultScreens.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDefaultScreens.Location = New System.Drawing.Point(507, 244)
        Me.lDefaultScreens.Name = "lDefaultScreens"
        Me.lDefaultScreens.Size = New System.Drawing.Size(15, 12)
        Me.lDefaultScreens.TabIndex = 56
        Me.lDefaultScreens.Text = "__"
        '
        'cbAutoStart
        '
        Me.cbAutoStart.AutoSize = True
        Me.cbAutoStart.Enabled = False
        Me.cbAutoStart.Location = New System.Drawing.Point(701, 352)
        Me.cbAutoStart.Name = "cbAutoStart"
        Me.cbAutoStart.Size = New System.Drawing.Size(73, 17)
        Me.cbAutoStart.TabIndex = 60
        Me.cbAutoStart.Text = "Auto Start"
        Me.cbAutoStart.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackgroundImage = CType(resources.GetObject("Panel12.BackgroundImage"), System.Drawing.Image)
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel12.Enabled = False
        Me.Panel12.Location = New System.Drawing.Point(780, 350)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(16, 16)
        Me.Panel12.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Panel12, "Whether or not to start app on windows startup.")
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel11.Location = New System.Drawing.Point(608, 266)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(16, 16)
        Me.Panel11.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel11, "Whether or not to capture all screens.")
        '
        'Panel10
        '
        Me.Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), System.Drawing.Image)
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel10.Location = New System.Drawing.Point(608, 323)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(16, 16)
        Me.Panel10.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel10, "Whether or not to copy image(s) to the clipboard.")
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), System.Drawing.Image)
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(608, 208)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(16, 16)
        Me.Panel9.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel9, "Which screens to capture.")
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel7.Location = New System.Drawing.Point(608, 146)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(16, 16)
        Me.Panel7.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel7, "Choose a hot key.")
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Location = New System.Drawing.Point(608, 86)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(16, 16)
        Me.Panel6.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel6, "Hot key modifier, must select one.")
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(196, 323)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(16, 16)
        Me.Panel5.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel5, "Whether or not to save mutiple screen shots as a single image.")
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(196, 266)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(16, 16)
        Me.Panel4.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel4, "Postfix to the name of the image being saved.")
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(196, 205)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 16)
        Me.Panel3.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Panel3, "Prefix to the name of the image being saved.")
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(196, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 16)
        Me.Panel2.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.Panel2, "Screen the program initially loads on.")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(196, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 16)
        Me.Panel1.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Panel1, "Time the window will disappear for when taking a screen shot.")
        '
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.cbAutoStart)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lDefaultScreens)
        Me.Controls.Add(Me.btnChooseScreens)
        Me.Controls.Add(Me.cbAllScreens)
        Me.Controls.Add(Me.cbClipboard)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbSingleImage)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbPostfix)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbPrefix)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbHotKey)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbHKMod2)
        Me.Controls.Add(Me.cbHKMod1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbViewScreen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDelay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbSaveLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pBorder)
        Me.Controls.Add(Me.btnManageProfiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProfiles)
        Me.Name = "SettingsPanel"
        Me.Size = New System.Drawing.Size(800, 369)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSingleImage As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbPostfix As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbHotKey As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbHKMod2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbHKMod1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbViewScreen As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents tbSaveLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pBorder As System.Windows.Forms.Panel
    Friend WithEvents btnManageProfiles As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbProfiles As System.Windows.Forms.ComboBox
    Friend WithEvents cbClipboard As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbAllScreens As System.Windows.Forms.ComboBox
    Friend WithEvents btnChooseScreens As System.Windows.Forms.Button
    Friend WithEvents lDefaultScreens As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents cbAutoStart As System.Windows.Forms.CheckBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel

End Class
