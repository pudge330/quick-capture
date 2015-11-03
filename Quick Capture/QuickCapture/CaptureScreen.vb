Imports System.Drawing

Public Class CaptureScreen
    Public screenshot As Bitmap
    Private copyToClipboard As Boolean = True
    Private timeStamp As String = ""
    Public ssImages As New List(Of Bitmap)

    Sub New(copyToClipboard As Boolean)
        copyToClipboard = copyToClipboard
    End Sub

    Public Sub CaptureScreenShot(ByVal defaultScreens As Integer(), ByVal allScreens As Boolean)

        Dim g As Graphics
        Dim tmpSize As Size
        Dim tmpPoint As Point
        ssImages.Clear()
        If allScreens Then
            tmpSize = New Size(0, 0)
            ssImages.Clear()
            For i = 0 To Screen.AllScreens.Count - 1
                ssImages.Add(New Bitmap(Screen.AllScreens(i).Bounds.Width, Screen.AllScreens(i).Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))

                g = Graphics.FromImage(ssImages(i))
                g.CopyFromScreen(Screen.AllScreens(i).Bounds.X, Screen.AllScreens(i).Bounds.Y, 0, 0, Screen.AllScreens(i).Bounds.Size, CopyPixelOperation.SourceCopy)
                g.Dispose()
                If tmpSize.Height < Screen.AllScreens(i).Bounds.Height Then
                    tmpSize = New Size(tmpSize.Width + Screen.AllScreens(i).Bounds.Width, Screen.AllScreens(i).Bounds.Height)
                Else
                    tmpSize = New Size(tmpSize.Width + Screen.AllScreens(i).Bounds.Width, tmpSize.Height)
                End If
            Next
            screenshot = New Bitmap(tmpSize.Width, tmpSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            g = Graphics.FromImage(screenshot)
            g.Clear(Color.White)
            tmpPoint = New Point(0, 0)
            For i = 0 To ssImages.Count - 1
                If ssImages(i).Height < tmpSize.Height Then
                    tmpPoint = New Point(tmpPoint.X, tmpSize.Height - ssImages(i).Height)
                Else
                    tmpPoint = New Point(tmpPoint.X, 0)
                End If
                g.DrawImage(ssImages(i), tmpPoint)
                tmpPoint = New Point(tmpPoint.X + ssImages(i).Width, 0)
            Next
            g.Dispose()
            If copyToClipboard Then
                timeStamp = DateAndTime.Now.Month & "-" & DateAndTime.Now.Day & "-" & DateAndTime.Now.Year _
                            & "@" & DateAndTime.Now.Hour & "-" & DateAndTime.Now.Minute & "-" & _
                            DateAndTime.Now.Second & "-" & DateAndTime.Now.Millisecond
                ToClipBoard()
            End If
        Else
            tmpPoint = New Point(0, 0)
            For i = 0 To defaultScreens.Length - 1
                If CInt(defaultScreens(i)) > -1 And CInt(defaultScreens(i)) < Screen.AllScreens.Length Then
                    ssImages.Add(New Bitmap(Screen.AllScreens(CInt(defaultScreens(i))).Bounds.Width,
                                            Screen.AllScreens(CInt(defaultScreens(i))).Bounds.Height,
                                            System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                    g = Graphics.FromImage(ssImages(ssImages.Count - 1))
                    g.CopyFromScreen(Screen.AllScreens(CInt(defaultScreens(i))).Bounds.X,
                                     Screen.AllScreens(CInt(defaultScreens(i))).Bounds.Y, 0, 0,
                                     Screen.AllScreens(CInt(defaultScreens(i))).Bounds.Size,
                                     CopyPixelOperation.SourceCopy)
                    g.Dispose()
                    If tmpSize.Height < ssImages(ssImages.Count - 1).Height Then
                        tmpSize = New Size(tmpSize.Width + ssImages(ssImages.Count - 1).Width, ssImages(ssImages.Count - 1).Height)
                    Else
                        tmpSize = New Size(tmpSize.Width + ssImages(ssImages.Count - 1).Width, tmpSize.Height)
                    End If
                End If
            Next
            screenshot = New Bitmap(tmpSize.Width, tmpSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            g = Graphics.FromImage(screenshot)
            g.Clear(Color.White)
            tmpPoint = New Point(0, 0)
            For i = 0 To ssImages.Count - 1
                If ssImages(i).Height < tmpSize.Height Then
                    tmpPoint = New Point(tmpPoint.X, tmpSize.Height - ssImages(i).Height)
                Else
                    tmpPoint = New Point(tmpPoint.X, 0)
                End If
                g.DrawImage(ssImages(i), tmpPoint)
                tmpPoint = New Point(tmpPoint.X + ssImages(i).Width, 0)
            Next
            g.Dispose()
            If copyToClipboard Then
                timeStamp = DateAndTime.Now.Month & "-" & DateAndTime.Now.Day & "-" & DateAndTime.Now.Year _
                            & "@" & DateAndTime.Now.Hour & "-" & DateAndTime.Now.Minute & "-" & _
                            DateAndTime.Now.Second & "-" & DateAndTime.Now.Millisecond
                ToClipBoard()
            End If
        End If
    End Sub

    Private Sub ToClipBoard()
        Dim cbTempDir As String = Settings.FileDirectory & "Temp\"
        System.IO.Directory.CreateDirectory(cbTempDir)
        Dim TempName As String = "Temp_" & timeStamp & ".jpg"
        screenshot.Save(cbTempDir & TempName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Clipboard.SetImage(screenshot)
        Dim Paths As New System.Collections.Specialized.StringCollection()
        Paths.Add(cbTempDir & TempName)
        Clipboard.SetFileDropList(Paths)
    End Sub

    Public Sub Dispose()
        screenshot.Dispose()
        For i = 0 To ssImages.Count - 1
            ssImages(i).Dispose()
        Next
        copyToClipboard = Nothing
        timeStamp = Nothing
    End Sub
End Class