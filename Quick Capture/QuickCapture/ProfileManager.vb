Public Class Profile_Manager
    Private relocTimer As New System.Windows.Forms.Timer
    Private mtfPos As Point
    Private profiles As New List(Of String)

    Private Sub Profile_Manager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Profile_Manager_Load(sender As Object, e As EventArgs) Handles Me.Load
        relocTimer.Interval = 1
        AddHandler relocTimer.Tick, AddressOf RelocTimer_Tick
        Me.Location = New Point(QuickCaptureForm.Location.X + ((QuickCaptureForm.Width - Me.Width) / 2),
                                QuickCaptureForm.Location.Y + ((QuickCaptureForm.Height - Me.Height) / 2))
        'MsgBox(QuickCaptureForm.Location.X & QuickCaptureForm.Location.Y)
    End Sub

    Sub New(ByVal p As List(Of String))
        InitializeComponent()
        profiles = p
        For i = 0 To profiles.Count - 1
            lbProfiles.Items.Add(profiles(i))
        Next
        If lbProfiles.Items.Count > 0 Then
            lbProfiles.SelectedIndex = 0
        End If
    End Sub

    Private Sub proManager_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawTopBar(e.Graphics)
        e.Graphics.DrawLine(New Pen(SystemColors.ActiveCaption), New Point(153, 140), New Point(294, 140))
        e.Graphics.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(0, 0), New Point(300, 0))
        e.Graphics.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(0, 0), New Point(0, 31))
        e.Graphics.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(299, 0), New Point(299, 31))
    End Sub

    Private Sub DrawTopBar(g As Graphics)
        g.FillRectangle(Brushes.SlateGray, New Rectangle(New Point(0, 0), New Size(Me.Width, 31)))
        g.DrawIcon(My.Resources.al_Icon, New Rectangle(5, 5, 21, 21))
        g.DrawString(Replace(Me.Name, "_", " "), New Font("Arial", 12), Brushes.Black, _
                              New Point(31, (31 - g.MeasureString(My.Application.Info.Title, New Font("Arial", 12)).Height) / 2))
    End Sub

    Private Sub Profile_Manager_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Location.Y < 32 And e.Button = Windows.Forms.MouseButtons.Left Then
            mtfPos = New Point(Math.Abs(Me.Location.X - MousePosition.X), Math.Abs(Me.Location.Y - MousePosition.Y))
            relocTimer.Enabled = True
        End If
    End Sub

    Private Sub Profile_Manager_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If relocTimer.Enabled Then
            relocTimer.Enabled = False
        End If
    End Sub

    Private Sub RelocTimer_Tick(sender As Object, e As EventArgs)
        Me.Location = New Point(MousePosition.X - mtfPos.X, MousePosition.Y - mtfPos.Y)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If tbNewName.Text.Trim() = String.Empty Then
            MessageBox.Show("Please enter a name.", "Quick Capture - Profile Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf lbProfiles.Items.Contains(tbNewName.Text.Trim()) Then
            MessageBox.Show("That profile already exists.", "Quick Capture - Profile Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            profiles.Add(tbNewName.Text.Trim())
            profiles.Sort()
            lbProfiles.Items.Add(tbNewName.Text.Trim())
            tbNewName.Text = String.Empty
            tbNewName.Focus()
        End If
    End Sub

    Private Sub tbExistingName_TextChanged(sender As Object, e As EventArgs) Handles tbExistingName.TextChanged
        If tbExistingName.Text.Trim().Length <> 0 Then
            tbExistingName.Text = SettingsPanel.RemoveIllegalChars(tbExistingName.Text)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If profiles.Count > 0 And lbProfiles.SelectedIndex <> -1 Then
            Dim tmpInt As Integer = lbProfiles.SelectedIndex
            profiles.RemoveAt(lbProfiles.SelectedIndex)
            If tmpInt >= profiles.Count Then
                tmpInt = tmpInt - 1
            End If
            lbProfiles.Items.Clear()
            For i = 0 To profiles.Count - 1
                lbProfiles.Items.Add(profiles(i))
            Next
            If lbProfiles.Items.Count > 0 Then
                lbProfiles.SelectedIndex = tmpInt
            End If
        End If
    End Sub

    Private Sub lbProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProfiles.SelectedIndexChanged
        tbExistingName.Text = lbProfiles.Items(lbProfiles.SelectedIndex).ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tmpStrings As New List(Of String)
        For i = 0 To lbProfiles.Items.Count - 1
            tmpStrings.Add(Settings.FileDirectory & FileIO.Profile.FileNamePartA & lbProfiles.Items(i).ToString() & FileIO.Profile.FileNamePartB)
        Next
        For Each fileFound As String In System.IO.Directory.GetFiles(Settings.FileDirectory)
            If (fileFound.StartsWith(Settings.FileDirectory & FileIO.Profile.FileNamePartA) And fileFound.EndsWith(FileIO.Profile.FileNamePartB)) Then
                If tmpStrings.Contains(fileFound) Then
                    tmpStrings.Remove(fileFound)
                Else
                    System.IO.File.Delete(fileFound)
                End If
            End If
        Next
        For Each tmps As String In tmpStrings
            'MsgBox(tmps.Split("\\")(tmps.Split("\\").Length - 1).Split("_")(1).Split(".")(0))
            FileIO.Profile.CreateDefault(tmps.Split("\\")(tmps.Split("\\").Length - 1).Split("_")(1).Split(".")(0))
        Next
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim tmp2 As New List(Of String)

        ' Retieve profile data
        For Each fileFound As String In System.IO.Directory.GetFiles(Settings.FileDirectory)
            If (fileFound.StartsWith(Settings.FileDirectory & FileIO.Profile.FileNamePartA) And fileFound.EndsWith(FileIO.Profile.FileNamePartB)) Then
                tmp2.Add(fileFound.Replace(Settings.FileDirectory & FileIO.Profile.FileNamePartA, "").Replace(FileIO.Profile.FileNamePartB, ""))
            End If
        Next
        tmp2.Sort()
        profiles.Clear()
        profiles.AddRange(tmp2)
        Me.Close()
    End Sub

    Private Sub tbNewName_TextChanged(sender As Object, e As EventArgs) Handles tbNewName.TextChanged
        tbNewName.Text = SettingsPanel.RemoveIllegalChars(tbNewName.Text)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim index As Integer = lbProfiles.SelectedIndex
        If tbExistingName.Text.Trim().Length = 0 Then
            MessageBox.Show("Please enter a name.", "Quick Capture - Profile Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf lbProfiles.Items.Contains(tbExistingName.Text.Trim()) And lbProfiles.Items.IndexOf(tbExistingName.Text.Trim()) <> index Then
            MessageBox.Show("Another profile already has that name.", "Quick Capture - Profile Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not profiles(index) = tbExistingName.Text.Trim() Then
                My.Computer.FileSystem.RenameFile(Settings.FileDirectory & FileIO.Profile.FileNamePartA & profiles(index) & FileIO.Profile.FileNamePartB,
                                              FileIO.Profile.FileNamePartA & tbExistingName.Text.Trim() & FileIO.Profile.FileNamePartB)
            End If
            'MsgBox(Settings.FileDirectory & FileIO.Profile.FileNamePartA & tbExistingName.Text.Trim() & FileIO.Profile.FileNamePartB)
            profiles(index) = tbExistingName.Text.Trim()
            lbProfiles.Items.Clear()
            For i = 0 To profiles.Count - 1
                lbProfiles.Items.Add(profiles(i))
            Next
            lbProfiles.SelectedIndex = index
        End If
    End Sub
End Class