Public Class ScreenSelection
    Private relocTimer As New System.Windows.Forms.Timer
    Private mtfPos As Point
    Dim scrns As Integer()

    Sub New(screens As Integer())
        InitializeComponent()
        scrns = screens
    End Sub

    Private Sub ScreenSecection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relocTimer.Interval = 1
        AddHandler relocTimer.Tick, AddressOf RelocTimer_Tick
        For i = 0 To Screen.AllScreens.Length - 1
            Dim tmp As New CheckBox()
            tmp.Name = "cbScreen_" & i
            tmp.Text = Screen.AllScreens(i).DeviceName
            If scrns.Contains(i) Then
                tmp.Checked = True
            End If
            flpScreens.Controls.Add(tmp)
            flpScreens.AutoScroll = True
            flpScreens.WrapContents = True
            Me.Location = New Point(QuickCaptureForm.Location.X + ((QuickCaptureForm.Width - Me.Width) / 2),
                                QuickCaptureForm.Location.Y + ((QuickCaptureForm.Height - Me.Height) / 2))
        Next
    End Sub

    Private Sub DrawTopBar(g As Graphics)
        g.FillRectangle(Brushes.SlateGray, New Rectangle(New Point(0, 0), New Size(Me.Width, 31)))
        g.DrawIcon(My.Resources.al_Icon, New Rectangle(5, 5, 21, 21))
        g.DrawString(Replace(Me.Name, "_", " "), New Font("Arial", 12), Brushes.Black, _
                              New Point(31, (31 - g.MeasureString(My.Application.Info.Title, New Font("Arial", 12)).Height) / 2))
        g.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(0, 0), New Point(300, 0))
        g.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(0, 0), New Point(0, 31))
        g.DrawLine(New Pen(SystemColors.ControlDarkDark), New Point(299, 0), New Point(299, 31))
    End Sub

    Private Sub ScreenSecection_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Location.Y < 32 And e.Button = Windows.Forms.MouseButtons.Left Then
            mtfPos = New Point(Math.Abs(Me.Location.X - MousePosition.X), Math.Abs(Me.Location.Y - MousePosition.Y))
            relocTimer.Enabled = True
        End If
    End Sub

    Private Sub ScreenSecection_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If relocTimer.Enabled Then
            relocTimer.Enabled = False
        End If
    End Sub

    Private Sub ScreenSecection_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawTopBar(e.Graphics)
    End Sub

    Private Sub RelocTimer_Tick(sender As Object, e As EventArgs)
        Me.Location = New Point(MousePosition.X - mtfPos.X, MousePosition.Y - mtfPos.Y)
    End Sub

End Class