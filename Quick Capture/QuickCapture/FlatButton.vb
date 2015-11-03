Public Class FlatButton
    Public Event LeftClick(sender As Object, e As MouseEventArgs)
    Public Event RightClick(sender As Object, e As MouseEventArgs)
    Private _NormalImage As Bitmap = Nothing
    Private _HoverImage As Bitmap = Nothing
    Private _ClickImage As Bitmap = Nothing
    Private _NormalColor As Color = Color.Transparent
    Private _HoverColor As Color = Color.Transparent
    Private _ClickColor As Color = Color.Transparent

    Property NormalImage As Bitmap
        Get
            Return _NormalImage
        End Get
        Set(value As Bitmap)
            _NormalImage = value
            Me.BackgroundImage = _NormalImage
        End Set
    End Property

    Property HoverImage As Bitmap
        Get
            Return _HoverImage
        End Get
        Set(value As Bitmap)
            _HoverImage = value
        End Set
    End Property

    Property ClickImage As Bitmap
        Get
            Return _ClickImage
        End Get
        Set(value As Bitmap)
            _ClickImage = value
        End Set
    End Property

    Property NormalColor As Color
        Get
            Return _NormalColor
        End Get
        Set(value As Color)
            _NormalColor = value
            Me.BackColor = _NormalColor
        End Set
    End Property

    Property HoverColor As Color
        Get
            Return _HoverColor
        End Get
        Set(value As Color)
            _HoverColor = value
        End Set
    End Property

    Property ClickColor As Color
        Get
            Return _ClickColor
        End Get
        Set(value As Color)
            _ClickColor = value
        End Set
    End Property

    Private Sub FlatButton_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            RaiseEvent LeftClick(sender, e)
        Else
            RaiseEvent RightClick(sender, e)
        End If
    End Sub

    Private Sub FlatButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.BackColor = _ClickColor
            If Not _ClickImage Is Nothing Then
                Me.BackgroundImage = _ClickImage
            End If
        End If
    End Sub

    Private Sub FlatButton_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.BackColor = _NormalColor
            If Not _NormalImage Is Nothing Then
                Me.BackgroundImage = _NormalImage
            End If
        End If
    End Sub

    Private Sub FlatButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BackColor = _HoverColor
        If Not _HoverImage Is Nothing Then
            Me.BackgroundImage = _HoverImage
        End If
    End Sub

    Private Sub FlatButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = _NormalColor
        If Not _NormalImage Is Nothing Then
            Me.BackgroundImage = _NormalImage
        End If
    End Sub
End Class
