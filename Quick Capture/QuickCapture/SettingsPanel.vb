Public Class SettingsPanel
    Public animationTimer As New Timer
    Public isSttgShowing As Boolean = False
    Private aSttg As Settings.App

    Private Sub SettingsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        animationTimer.Interval = 1
        AddHandler animationTimer.Tick, AddressOf animationTimer_Tick
        cbProfiles.Height = 35
        HideControls()
    End Sub

    Sub New(ByVal sttg As Settings.App)

        ' This call is required by the designer.
        InitializeComponent()

        aSttg = sttg
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SettingsPanel_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawBackground(e.Graphics)
    End Sub

    Sub ApplySettings()
        RemoveHandler cbProfiles.SelectedIndexChanged, AddressOf cbProfiles_SelectedIndexChanged
        cbProfiles.Items.Clear()
        For i = 0 To aSttg.Profiles.Count - 1
            cbProfiles.Items.Add(aSttg.Profiles(i))
        Next
        cbProfiles.Items.Add("-- DEFAULT --")
        'MsgBox(aSttg.CurrentProfileIndex)
        If aSttg.CurrentProfileIndex <> -1 Then
            cbProfiles.SelectedIndex = aSttg.CurrentProfileIndex
        Else
            cbProfiles.SelectedIndex = cbProfiles.Items.Count - 1
        End If
        AddHandler cbProfiles.SelectedIndexChanged, AddressOf cbProfiles_SelectedIndexChanged
        tbSaveLocation.Text = aSttg.CurrentProfile.SaveLocation
        tbDelay.Text = aSttg.CurrentProfile.SSOpenWndDelay
        RemoveHandler cbHKMod1.SelectedIndexChanged, AddressOf cbHKMod1_SelectedIndexChanged
        RemoveHandler cbHKMod2.SelectedIndexChanged, AddressOf cbHKMod1_SelectedIndexChanged
        cbHKMod1.SelectedIndex = aSttg.CurrentProfile.HKMod1
        If aSttg.CurrentProfile.HKMod2 <> -1 Then
            cbHKMod2.SelectedIndex = aSttg.CurrentProfile.HKMod2
        Else
            cbHKMod2.SelectedIndex = cbHKMod2.Items.Count - 1
        End If
        AddHandler cbHKMod1.SelectedIndexChanged, AddressOf cbHKMod1_SelectedIndexChanged
        AddHandler cbHKMod2.SelectedIndexChanged, AddressOf cbHKMod1_SelectedIndexChanged
        cbViewScreen.Items.Clear()
        For i = 0 To Screen.AllScreens.Length - 1
            cbViewScreen.Items.Add(Screen.AllScreens(i).DeviceName)
        Next
        cbViewScreen.SelectedIndex = aSttg.CurrentProfile.ViewScreen
        cbHotKey.SelectedIndex = aSttg.CurrentProfile.HKKeyCode
        tbPrefix.Text = aSttg.CurrentProfile.Prefix
        lDefaultScreens.Text = ""
        For i = 0 To aSttg.CurrentProfile.DefaultScreens.Count - 1
            lDefaultScreens.Text = lDefaultScreens.Text & aSttg.CurrentProfile.DefaultScreens(i).ToString()
            If i <> aSttg.CurrentProfile.DefaultScreens.Count - 1 Then
                lDefaultScreens.Text = lDefaultScreens.Text & " | "
            End If
        Next
        tbPostfix.Text = aSttg.CurrentProfile.Postfix
        If aSttg.CurrentProfile.AllScreens Then
            cbAllScreens.SelectedIndex = 0
        Else
            cbAllScreens.SelectedIndex = 1
        End If
        If aSttg.CurrentProfile.SaveAsSingle Then
            cbSingleImage.SelectedIndex = 0
        Else
            cbSingleImage.SelectedIndex = 1
        End If
        If aSttg.CurrentProfile.CopyToClipBoard Then
            cbClipboard.SelectedIndex = 0
        Else
            cbClipboard.SelectedIndex = 1
        End If
        If aSttg.AutoStart Then
            cbAutoStart.Checked = True
        Else
            cbAutoStart.Checked = False
        End If
    End Sub
    'Private bgRect1 As New Rectangle(757, 0, 0, 43) ' Y and Height is static
    'Private bgRect2 As New Rectangle(0, 43, 800, 0) ' X, Y and Width is static
    'Private Sub DrawBackground(g As Graphics)
    '    g.FillRectangle(Brushes.DarkGray, bgRect1)
    '    g.FillRectangle(Brushes.DarkGray, bgRect2)
    'End Sub

    'Private Sub animationTimer_Tick(sender As Object, e As EventArgs)
    '    If isSttgShowing Then
    '        HideControls()
    '        If bgRect2.Height > 0 Then
    '            bgRect2 = New Rectangle(bgRect2.X, bgRect2.Y, bgRect2.Width, bgRect2.Height - 15)
    '        Else
    '            bgRect2.Height = 0
    '            If bgRect1.X < 757 Then
    '                bgRect1 = New Rectangle(bgRect1.X + 60, bgRect1.Y, bgRect1.Width - 60, bgRect1.Height)
    '            Else
    '                bgRect1 = New Rectangle(757, bgRect1.Y, 0, bgRect1.Height)
    '                QuickCaptureForm.ToggleControls(False)
    '                isSttgShowing = False
    '                animationTimer.Enabled = False
    '            End If
    '        End If
    '        Me.SendToBack()
    '    Else ' Not showing
    '        If QuickCaptureForm.btnCamera.Visible Then
    '            QuickCaptureForm.ToggleControls()
    '        End If
    '        Me.BringToFront()
    '        If bgRect1.X > 0 Then
    '            bgRect1 = New Rectangle(bgRect1.X - 15, bgRect1.Y, bgRect1.Width + 15, bgRect1.Height)
    '        Else
    '            bgRect1 = New Rectangle(0, bgRect1.Y, 757, bgRect1.Height)
    '            If bgRect2.Height < 326 Then
    '                bgRect2 = New Rectangle(bgRect2.X, bgRect2.Y, bgRect2.Width, bgRect2.Height + 15)
    '            Else
    '                bgRect2 = New Rectangle(bgRect2.X, bgRect2.Y, bgRect2.Width, 326)
    '                isSttgShowing = True
    '                animationTimer.Enabled = False
    '                ShowControls()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub DrawBackground(g As Graphics)
        g.FillRectangle(Brushes.DarkGray, New Rectangle(0, 0, 757, 369))
        g.FillRectangle(Brushes.DarkGray, New Rectangle(757, 43, 43, 334))
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs)
        If isSttgShowing Then
            HideControls()
            If Me.Size.Height > 43 Then
                Me.Size = New Size(Me.Width, Me.Height - 15)
            Else
                Me.Size = New Size(Me.Width, 43)
                If Me.Location.X < 800 Then
                    Me.Location = New Point(Me.Location.X + 60, Me.Location.Y)
                Else
                    Me.Location = New Point(800, Me.Location.Y)
                    QuickCaptureForm.ToggleControls(False)
                    isSttgShowing = False
                    animationTimer.Enabled = False
                    FileIO.App.Save(aSttg)
                    If aSttg.CurrentProfileIndex <> -1 Then
                        FileIO.Profile.Save(aSttg.CurrentProfile, aSttg.Profiles(aSttg.CurrentProfileIndex))
                    End If
                    Me.Dispose()
                End If
            End If
        Else
            If QuickCaptureForm.btnCamera.Visible Then
                QuickCaptureForm.ToggleControls()
                System.Threading.Thread.Sleep(15)
            End If
            If Me.Location.X > 0 Then
                Me.Location = New Point(Me.Location.X - 60, Me.Location.Y)
            Else
                Me.Location = New Point(0, Me.Location.Y)
                If Me.Size.Height < 369 Then
                    Me.Size = New Size(Me.Width, Me.Height + 15)
                Else
                    Me.Size = New Size(Me.Width, 369)
                    isSttgShowing = True
                    animationTimer.Enabled = False
                    ShowControls()
                End If
            End If
        End If
    End Sub

    Public Sub ToggleAnimation()
        If animationTimer.Enabled Then
            If isSttgShowing Then
                isSttgShowing = False
            Else
                isSttgShowing = True
            End If
        Else
            animationTimer.Enabled = True
        End If
    End Sub

    Private Sub HideControls()
        For Each ctrl As Control In Me.Controls
            ctrl.Hide()
        Next
    End Sub

    Private Sub ShowControls()
        For Each ctrl As Control In Me.Controls
            ctrl.Show()
        Next
    End Sub

    Private Sub btnManageProfiles_Click(sender As Object, e As EventArgs) Handles btnManageProfiles.Click
        Dim pManager As New Profile_Manager(aSttg.Profiles)
        If pManager.ShowDialog() = DialogResult.OK Then
            aSttg.CurrentProfile = New Settings.Profile
            aSttg.CurrentProfileIndex = -1
            aSttg.Profiles = FileIO.App.GetProfileNames()
            QuickCaptureForm.Refresh()
            ApplySettings()
        End If
    End Sub

    Private Sub cbHKMod1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHKMod1.SelectedIndexChanged, cbHKMod2.SelectedIndexChanged
        If cbHKMod1.SelectedIndex = cbHKMod2.SelectedIndex And cbHKMod1.SelectedIndex <> -1 Then
            MessageBox.Show("Cannot be the same as the other modifier!", "Quick Capture - Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DirectCast(sender, Control).Name.EndsWith("1") Then
                cbHKMod1.SelectedIndex = aSttg.CurrentProfile.HKMod1
            Else
                If aSttg.CurrentProfile.HKMod2 <> -1 Then
                    cbHKMod2.SelectedIndex = aSttg.CurrentProfile.HKMod2
                Else
                    cbHKMod2.SelectedIndex = cbHKMod2.Items(cbHKMod2.Items.Count - 1)
                End If
            End If
        Else
            If DirectCast(sender, Control).Name.EndsWith("1") Then
                aSttg.CurrentProfile.HKMod1 = cbHKMod1.SelectedIndex
            Else
                If cbHKMod2.SelectedIndex <> cbHKMod2.Items.Count - 1 Then
                    aSttg.CurrentProfile.HKMod2 = cbHKMod2.SelectedIndex
                Else
                    aSttg.CurrentProfile.HKMod2 = -1
                End If
            End If
        End If
    End Sub

    Private Sub cbProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfiles.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        If cbProfiles.SelectedIndex <> cbProfiles.Items.Count - 1 Then
            If aSttg.CurrentProfileIndex <> -1 Then
                FileIO.Profile.Save(aSttg.CurrentProfile, aSttg.Profiles(aSttg.CurrentProfileIndex))
            End If
            aSttg.CurrentProfileIndex = cbProfiles.SelectedIndex
            aSttg.CurrentProfile = FileIO.Profile.Read(aSttg.Profiles(cbProfiles.SelectedIndex))
        Else
            aSttg.CurrentProfileIndex = -1
            aSttg.CurrentProfile = New Settings.Profile
        End If
        Threading.Thread.Sleep(250)
        ApplySettings()
        QuickCaptureForm.Refresh()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tbDelay_LostFocus(sender As Object, e As EventArgs) Handles tbDelay.LostFocus
        If tbDelay.Text.Trim = String.Empty Then
            tbDelay.Text = aSttg.CurrentProfile.SSOpenWndDelay
        Else
            aSttg.CurrentProfile.SSOpenWndDelay = tbDelay.Text
        End If
    End Sub

    Private Sub tbDelay_TextChanged(sender As Object, e As EventArgs) Handles tbDelay.TextChanged
        tbDelay.Text = RemoveNonNumeric(tbDelay.Text)
    End Sub

    Private Sub cbHotKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHotKey.SelectedIndexChanged
        aSttg.CurrentProfile.HKKeyCode = cbHotKey.SelectedIndex
    End Sub

    Private Sub cbViewScreen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbViewScreen.SelectedIndexChanged
        aSttg.CurrentProfile.ViewScreen = cbViewScreen.SelectedIndex
    End Sub

    Private Sub tbPrefix_TextChanged(sender As Object, e As EventArgs) Handles tbPrefix.TextChanged
        tbPrefix.Text = RemoveIllegalChars(tbPrefix.Text)
        aSttg.CurrentProfile.Prefix = tbPrefix.Text
    End Sub

    Private Sub btnChooseScreens_Click(sender As Object, e As EventArgs) Handles btnChooseScreens.Click
        Dim scrnChooser As New ScreenSelection(aSttg.CurrentProfile.DefaultScreens.ToArray())
        If scrnChooser.ShowDialog() = DialogResult.OK Then
            Dim tmp As New List(Of Integer)
            For i = 0 To Screen.AllScreens.Length - 1
                If DirectCast(scrnChooser.flpScreens.Controls(i), CheckBox).Checked Then
                    tmp.Add(i)
                End If
            Next
            aSttg.CurrentProfile.DefaultScreens.Clear()
            aSttg.CurrentProfile.DefaultScreens.AddRange(tmp)
            'tmp.CopyTo(aSttg.CurrentProfile.DefaultScreens)
            lDefaultScreens.Text = ""
            'MsgBox(aSttg.CurrentProfile.DefaultScreens.Count)
            For i = 0 To aSttg.CurrentProfile.DefaultScreens.Count - 1
                'MsgBox(i & ":" & aSttg.CurrentProfile.DefaultScreens(i))
                lDefaultScreens.Text = lDefaultScreens.Text & aSttg.CurrentProfile.DefaultScreens(i).ToString()
                If i <> aSttg.CurrentProfile.DefaultScreens.Count - 1 Then
                    lDefaultScreens.Text = lDefaultScreens.Text & " | "
                End If
            Next
        End If
    End Sub

    Private Sub tbPostfix_TextChanged(sender As Object, e As EventArgs) Handles tbPostfix.TextChanged
        tbPostfix.Text = RemoveIllegalChars(tbPostfix.Text)
        aSttg.CurrentProfile.Postfix = tbPostfix.Text
    End Sub

    Private Sub cbAllScreens_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAllScreens.SelectedIndexChanged
        If cbAllScreens.SelectedIndex = 0 Then
            aSttg.CurrentProfile.AllScreens = True
        Else
            aSttg.CurrentProfile.AllScreens = False
        End If
    End Sub

    Private Sub cbSingleImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSingleImage.SelectedIndexChanged
        If cbSingleImage.SelectedIndex = 0 Then
            aSttg.CurrentProfile.SaveAsSingle = True
        Else
            aSttg.CurrentProfile.SaveAsSingle = False
        End If
    End Sub

    Private Sub cbClipboard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClipboard.SelectedIndexChanged
        If cbClipboard.SelectedIndex = 0 Then
            aSttg.CurrentProfile.CopyToClipBoard = True
        Else
            aSttg.CurrentProfile.CopyToClipBoard = False
        End If
    End Sub

    Private Function RemoveNonNumeric(s As String) As String
        Dim tmp As String = ""
        For i = 0 To s.Length - 1
            If IsNumeric(s(i)) Then
                tmp = tmp & s(i)
            End If
        Next
        Return tmp
    End Function

    Public Shared Function RemoveIllegalChars(s As String) As String
        Dim allowed As New List(Of String)
        allowed.AddRange({"/", "|", ":", "*", "?", """", "<", ">", "|"})
        Dim tmp As String = ""
        For i = 0 To s.Length - 1
            If Not allowed.Contains(s(i)) Then
                tmp = tmp & s(i)
            End If
        Next
        Return tmp
    End Function

    Private Sub cbAutoStart_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoStart.CheckedChanged
        aSttg.AutoStart = cbAutoStart.Checked
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim f As New FolderBrowserDialog
        f.SelectedPath = tbSaveLocation.Text
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tbSaveLocation.Text = f.SelectedPath
            aSttg.CurrentProfile.SaveLocation = f.SelectedPath
        End If
        f.Dispose()
    End Sub
End Class
