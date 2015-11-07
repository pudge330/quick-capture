'   TODO 
'   3) Apply addition Settings [AutoStart]
'
'   TODO for 2.0 Remake
'   Look into an alternative for animation for smoothness with less flicker
'   Make 85-99% of all Variables ROD (Read On Demand) to reduce memory consumption.
'       - Only 100% necessary variables needed to run stays loaded in memory.
'   Create New UserControl to handle the look and functionality of the main and popup forms 
'       - Use Events to handle Moving, Closing, Minimizing, Disposing etc. as necessary
'   In settingsPanel when a change is made and validated it auto-saves, eliminating holding all settings in
'       memory and remove save on profileindexchange


Public Class QuickCaptureForm
    Private tmpMousePos As Point
    Private relocateTimer As New System.Windows.Forms.Timer
    Private prvToggleTimer As New System.Windows.Forms.Timer
    Private allowFullExit As Boolean = False
    Private isPreviewShowing As Boolean = True
    Private tempShowPreview As Boolean = False
    Private sttgPanel As SettingsPanel
    Private hotkeyManager As HotKeyManager
    Private defaultFileName As String
    Private appSttg As Settings.App = New Settings.App
    Private screenShots As New List(Of Bitmap)

    Private Sub QuickCapture_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.DoubleBuffered = True
        appSttg = FileIO.App.Read()
        hotkeyManager = New HotKeyManager(Me.Handle)
        ApplySettings()
        ' Initial Setup
        relocateTimer.Interval = 1
        AddHandler relocateTimer.Tick, AddressOf relocateTimer_Tick
        prvToggleTimer.Interval = 1
        AddHandler prvToggleTimer.Tick, AddressOf prvToggleTimer_Tick

        tbFileName.AutoSize = False
        tbFileName.Height = 35
        tbDirectory.AutoSize = False
        tbDirectory.Height = 35

        pPreview.BackgroundImage = New Bitmap(pPreview.Width, pPreview.Height)

        CaptureScreenShot()
        Dim s As String = ""
        'MsgBox(appSttg.Profiles(0) & vbNewLine & appSttg.CurrentProfile.SaveLocation)
    End Sub

    Sub ApplySettings()
        ' Apply App Settings
        tbDirectory.Text = "{" & appSttg.CurrentProfile.SaveLocation.Split("\\")(appSttg.CurrentProfile.SaveLocation.Split("\\").Length - 1) & "}"

        If hotkeyManager.CurrentHotKeys Then
            UnregisterHotKeys()
        End If
        RegisterHotKeys()

        Dim tmpRec As Rectangle = Screen.AllScreens(appSttg.CurrentProfile.ViewScreen).WorkingArea
        Dim tmpRec2 As Rectangle = New Rectangle(Me.Location, Me.Size)
        If Not tmpRec.IntersectsWith(tmpRec2) Then
            Dim x As Integer = Screen.AllScreens(appSttg.CurrentProfile.ViewScreen).WorkingArea.X +
                ((Screen.AllScreens(appSttg.CurrentProfile.ViewScreen).WorkingArea.Width - Me.Size.Width) / 2)
            Dim y As Integer = Screen.AllScreens(appSttg.CurrentProfile.ViewScreen).WorkingArea.Y +
                ((Screen.AllScreens(appSttg.CurrentProfile.ViewScreen).WorkingArea.Height - Me.Size.Height) / 2)
            Me.Location = New Point(x, y)
        End If

        Dim tmpS As String = ""
        Select Case (appSttg.CurrentProfile.HKMod1)
            Case 0
                tmpS = tmpS & "ALT"
            Case 1
                tmpS = tmpS & "CONTROL"
            Case 2
                tmpS = tmpS & "SHIFT"
            Case 3
                tmpS = tmpS & "WINDOW"
        End Select
        Select Case (appSttg.CurrentProfile.HKMod2)
            Case -1
            Case 0
                tmpS = tmpS & " + " & "ALT"
            Case 1
                tmpS = tmpS & " + " & "CONTROL"
            Case 2
                tmpS = tmpS & " + " & "SHIFT"
            Case 3
                tmpS = tmpS & " + " & "WINDOW"
        End Select
        If appSttg.CurrentProfile.HKKeyCode <> -1 Then
            tmpS = tmpS & " + " & Settings.KCodesValues(appSttg.CurrentProfile.HKKeyCode)
        Else
            tmpS = tmpS & " + " & "P"
        End If
        cmsiCapture.Text = "Capture <" & tmpS & ">"
        niMain.Text = "Quick Capture" & vbNewLine & vbNewLine & "<" & tmpS & ">"


        If Not System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) & "\QC_STARTUP.qcsf") Then

        End If
    End Sub

    Private Sub QuickCaptureForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not allowFullExit Then
            e.Cancel = True
            If Not sttgPanel Is Nothing Then
                If sttgPanel.isSttgShowing Then
                    sttgPanel.ToggleAnimation()
                    If tempShowPreview Then
                        tempShowPreview = False
                        prvToggleTimer.Enabled = True
                    End If
                    sttgPanel = Nothing
                End If
            End If
            Me.Hide()
        Else
            'MsgBox("0")
            FileIO.App.ClearTempDir()
        End If
    End Sub

    Private Sub QuickCapture_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawTopBar(e.Graphics)
    End Sub

    Private Sub QuickCaptureForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged, Me.GotFocus
        Me.Focus()
        tbFileName.Focus()
        tbFileName.SelectAll()
    End Sub

    Private Sub QuickCaptureForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) And tbFileName.Focused Then
            SaveScreenShot()
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = HotKeyRegistryClass.Messages.WM_HOTKEY Then
            Dim ID As String = m.WParam.ToString()
            Select Case ID
                Case hotkeyManager.IndexOf("capture")
                    CaptureScreenShot()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub cmsiExit_Click(sender As Object, e As EventArgs) Handles cmsiExit.Click
        allowFullExit = True
        Me.Close()
    End Sub

    Private Sub cmsiCapture_Click(sender As Object, e As EventArgs) Handles cmsiCapture.Click
        CaptureScreenShot()
    End Sub

    Private Sub RegisterHotKeys()
        Dim hkms As HotKeyRegistryClass.Modifiers() = {HotKeyRegistryClass.Modifiers.MOD_ALT, HotKeyRegistryClass.Modifiers.MOD_SHIFT}
        For i = 0 To hkms.Length - 1
            If i = 0 Then
                Select Case appSttg.CurrentProfile.HKMod1
                    Case 0
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_ALT
                    Case 1
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_CTRL
                    Case 2
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_SHIFT
                    Case 3
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_WIN
                    Case Else
                        hkms(i) = Settings.FallBack.HKModifier(i)
                End Select
            Else
                Select Case appSttg.CurrentProfile.HKMod2
                    Case -1
                    Case 0
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_ALT
                    Case 1
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_CTRL
                    Case 2
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_SHIFT
                    Case 3
                        hkms(i) = HotKeyRegistryClass.Modifiers.MOD_WIN
                    Case Else
                        hkms(i) = Settings.FallBack.HKModifier(i)
                End Select
            End If
        Next
        Dim kc As Integer = -1
        If appSttg.CurrentProfile.HKKeyCode > -1 And appSttg.CurrentProfile.HKKeyCode < Settings.KCodes.Count Then
            kc = Settings.KCodes(appSttg.CurrentProfile.HKKeyCode)
        Else
            kc = Settings.KCodes(Settings.FallBack.HKKeyCode)
        End If
        If appSttg.CurrentProfile.HKMod1 <> -1 And appSttg.CurrentProfile.HKMod2 <> -1 Then
            hotkeyManager.AddHotKey("capture", hkms(0) Or hkms(1), kc)
        ElseIf appSttg.CurrentProfile.HKMod1 <> -1 Then
            hotkeyManager.AddHotKey("capture", hkms(0), kc)
        Else
            hotkeyManager.AddHotKey("capture", hkms(1), kc)
        End If
    End Sub

    Private Sub UnregisterHotKeys()
        hotkeyManager.RemoveHotKey("capture")
    End Sub

    Private Sub CaptureScreenShot()
        If Me.Visible Then
            Me.Hide()
            Threading.Thread.Sleep(appSttg.CurrentProfile.SSOpenWndDelay)
        End If
        Dim ssCamera As New CaptureScreen(appSttg.CurrentProfile.CopyToClipBoard)
        ssCamera.CaptureScreenShot(appSttg.CurrentProfile.DefaultScreens.ToArray(), appSttg.CurrentProfile.AllScreens)
        defaultFileName = DateAndTime.Now.Month & "-" & DateAndTime.Now.Day & "-" & DateAndTime.Now.Year _
                        & "@" & DateAndTime.Now.Hour & "-" & DateAndTime.Now.Minute & "-" & _
                        DateAndTime.Now.Second & "-" & DateAndTime.Now.Millisecond
        pPreview.BackgroundImage = ssCamera.screenshot.Clone()
        screenShots.Clear()
        For i = 0 To ssCamera.ssImages.Count - 1
            screenShots.Add(ssCamera.ssImages(i).Clone())
        Next
        If Not Me.Visible Then
            Me.Show()
        End If
        ssCamera.Dispose()
        ssCamera = Nothing
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub SaveScreenShot()
        If appSttg.CurrentProfile.SaveAsSingle Then
            Dim newImg As New Bitmap(pPreview.BackgroundImage)
            Try
                'MsgBox("1) " & appSttg.CurrentProfile.Prefix & vbNewLine & "2) " & appSttg.CurrentProfile.Postfix)
                If tbFileName.Text.Trim() = String.Empty Then
                    newImg.Save(appSttg.CurrentProfile.SaveLocation + "\" + appSttg.CurrentProfile.Prefix + "ss_" + defaultFileName.ToString() + appSttg.CurrentProfile.Postfix + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                Else
                    newImg.Save(appSttg.CurrentProfile.SaveLocation + "\" + appSttg.CurrentProfile.Prefix + tbFileName.Text + appSttg.CurrentProfile.Postfix + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
                tbFileName.Text = String.Empty
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error saving screen shot")
            End Try
            newImg.Dispose()
        Else
            For i = 0 To screenShots.Count - 1
                Try
                    'MsgBox("1) " & appSttg.CurrentProfile.Prefix & vbNewLine & "2) " & appSttg.CurrentProfile.Postfix)
                    If tbFileName.Text.Trim() = String.Empty Then
                        screenShots(i).Save(appSttg.CurrentProfile.SaveLocation + "\" + appSttg.CurrentProfile.Prefix + "ss_" + defaultFileName.ToString() + appSttg.CurrentProfile.Postfix + " (" + i.ToString() + ").jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    Else
                        screenShots(i).Save(appSttg.CurrentProfile.SaveLocation + "\" + appSttg.CurrentProfile.Prefix + tbFileName.Text + appSttg.CurrentProfile.Postfix + " (" + i.ToString() + ").jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    End If
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Error saving screen shot")
                End Try
            Next
            tbFileName.Text = String.Empty
        End If
    End Sub

#Region "Top-Bar"
    Private Sub DrawTopBar(g As Graphics)
        Dim totalbytesofmemory As Long = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64
        Dim roundedMb As Double = CDbl(CDbl(totalbytesofmemory / 1024) / 1024)
        Dim s As String = ""
        If appSttg.CurrentProfileIndex <> -1 Then
            s = " - " & appSttg.Profiles(appSttg.CurrentProfileIndex)
        End If
        g.FillRectangle(Brushes.SlateGray, New Rectangle(New Point(0, 0), New Size(Me.Width, 31)))
        g.DrawIcon(My.Resources.al_Icon, New Rectangle(5, 5, 21, 21))
        g.DrawString(My.Application.Info.Title & s & " : " & roundedMb & "mb", New Font("Arial", 12), Brushes.Black, New Point(31, (31 - g.MeasureString(My.Application.Info.Title, New Font("Arial", 12)).Height) / 2))
    End Sub

    Private Sub btnClose_LeftClick(sender As Object, e As MouseEventArgs) Handles btnClose.LeftClick
        Me.Close()
    End Sub

    Private Sub btnMinimize_LeftClick(sender As Object, e As MouseEventArgs) Handles btnMinimize.LeftClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Re-location"
    Private Sub QuickLaunch_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Location.Y < 32 And e.Button = Windows.Forms.MouseButtons.Left Then
            tmpMousePos = New Point(Math.Abs(Me.Location.X - MousePosition.X), Math.Abs(Me.Location.Y - MousePosition.Y))
            relocateTimer.Enabled = True
        End If
    End Sub

    Private Sub QuickLaunch_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If relocateTimer.Enabled Then
            relocateTimer.Enabled = False
        End If
    End Sub

    Private Sub relocateTimer_Tick(sender As Object, e As EventArgs)
        Me.Location = New Point(MousePosition.X - tmpMousePos.X, MousePosition.Y - tmpMousePos.Y)
    End Sub
#End Region
#Region "Toggle-Preview"
    Public Sub ToggleControls(Optional _Hide As Boolean = True)
        If _Hide Then
            pControlsToHide.Hide()
            pPreviewBar.Hide()
        Else
            pControlsToHide.Show()
            pPreviewBar.Show()
        End If
    End Sub

    Private Sub prvToggleTimer_Tick(sender As Object, e As EventArgs)
        If isPreviewShowing Then
            pPreview.Hide()
            If Me.Height > 115 Then
                Me.Size = New Size(Me.Width, Me.Height - 10)
            Else
                Me.Size = New Size(Me.Width, 115)
                isPreviewShowing = False
                prvToggleTimer.Enabled = False
            End If
        Else
            If Me.Height < 400 Then
                Me.Size = New Size(Me.Width, Me.Height + 10)
            Else
                Me.Size = New Size(Me.Width, 400)
                isPreviewShowing = True
                prvToggleTimer.Enabled = False
                pPreview.Show()
            End If
        End If
    End Sub

    Private Sub pPreviewBar_MouseClick(sender As Object, e As MouseEventArgs) Handles pPreviewBar.MouseClick, lblPreview.MouseClick, pPreviewArrowsLeft.MouseClick, pPreviewArrowsRight.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If prvToggleTimer.Enabled Then
                If isPreviewShowing Then
                    isPreviewShowing = False
                Else
                    isPreviewShowing = True
                End If
            Else
                prvToggleTimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub pPreviewBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pPreviewBar.MouseDown, lblPreview.MouseDown, pPreviewArrowsLeft.MouseDown, pPreviewArrowsRight.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pPreviewBar.BackColor = Color.SlateGray
        End If
    End Sub

    Private Sub pPreviewBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pPreviewBar.MouseUp, lblPreview.MouseUp, pPreviewArrowsLeft.MouseUp, pPreviewArrowsRight.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pPreviewBar.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub pPreviewBar_MouseEnter(sender As Object, e As EventArgs) Handles pPreviewBar.MouseEnter, lblPreview.MouseEnter, pPreviewArrowsLeft.MouseEnter, pPreviewArrowsRight.MouseEnter
        If isPreviewShowing Then
            pPreviewArrowsLeft.BackgroundImage = My.Resources.up_arrows
            pPreviewArrowsRight.BackgroundImage = My.Resources.up_arrows
        Else
            pPreviewArrowsLeft.BackgroundImage = My.Resources.down_arrows
            pPreviewArrowsRight.BackgroundImage = My.Resources.down_arrows
        End If
        pPreviewBar.BackColor = Color.Gray
    End Sub

    Private Sub pPreviewBar_MouseLeave(sender As Object, e As EventArgs) Handles pPreviewBar.MouseLeave, lblPreview.MouseLeave, pPreviewArrowsLeft.MouseLeave, pPreviewArrowsRight.MouseLeave
        pPreviewArrowsLeft.BackgroundImage = Nothing
        pPreviewArrowsRight.BackgroundImage = Nothing
        pPreviewBar.BackColor = Color.Transparent
    End Sub
#End Region
#Region "Control-Buttons"
    Private Sub btnCamera_LeftClick(sender As Object, e As MouseEventArgs) Handles btnCamera.LeftClick, niMain.DoubleClick
        CaptureScreenShot()
    End Sub

    Private Sub btnFolder_LeftClick(sender As Object, e As MouseEventArgs) Handles btnFolder.LeftClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim f As New FolderBrowserDialog
            f.SelectedPath = appSttg.CurrentProfile.SaveLocation
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                appSttg.CurrentProfile.SaveLocation = f.SelectedPath
                tbDirectory.Text = "{" & appSttg.CurrentProfile.SaveLocation.Split("\\")(appSttg.CurrentProfile.SaveLocation.Split("\\").Length - 1) & "}"
            End If
            f.Dispose()
        End If
    End Sub

    Private Sub btnSave_LeftClick(sender As Object, e As MouseEventArgs) Handles btnSave.LeftClick
        SaveScreenShot()
    End Sub

    Private Sub btnSettings_LeftClick(sender As Object, e As MouseEventArgs) Handles btnSettings.LeftClick
        'MsgBox(appSttg.CurrentProfile.SaveLocation)
        If sttgPanel Is Nothing Then
            Me.TopMost = False
            'MsgBox("1")
            sttgPanel = New SettingsPanel(appSttg)
            Me.Controls.Add(sttgPanel)
            sttgPanel.BringToFront()
            sttgPanel.Location = New Point(800, 31)
            sttgPanel.Size = New Size(800, 43)
            btnSettings.BringToFront()
            sttgPanel.ApplySettings()
            If Not isPreviewShowing Then
                tempShowPreview = True
                prvToggleTimer.Enabled = True
                sttgPanel.ToggleAnimation()
            Else
                sttgPanel.ToggleAnimation()
                'If tempShowPreview Then
                '    tempShowPreview = False
                '    prvToggleTimer.Enabled = True
                'End If
            End If
        Else
            Me.TopMost = True
            sttgPanel.ToggleAnimation()
            If tempShowPreview Then
                tempShowPreview = False
                prvToggleTimer.Enabled = True
            End If
            sttgPanel = Nothing
            'MsgBox("0")
            ApplySettings()
        End If
        'If Not isPreviewShowing Then
        '    tempShowPreview = True
        '    prvToggleTimer.Enabled = True
        '    sttgPanel.ToggleAnimation()
        'Else
        '    sttgPanel.ToggleAnimation()
        '    If tempShowPreview Then
        '        tempShowPreview = False
        '        prvToggleTimer.Enabled = True
        '    End If
        'End If
    End Sub
#End Region
End Class