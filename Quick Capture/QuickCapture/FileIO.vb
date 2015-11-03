Imports System.IO

Public Class FileIO
    Public Class App
        Shared _FileName As String = "AppSttg.qcsf"
        Public Shared ReadOnly Property FileName As String
            Get
                Return _FileName
            End Get
        End Property

        Shared Sub CreateDefault()
            Try
                Directory.CreateDirectory(Settings.FileDirectory)
                Dim sw As New StreamWriter(File.Create(Settings.FileDirectory & FileName))
                sw.WriteLine(Settings.FallBack.CurrentProfileIndex.ToString() & "|" & Settings.FallBack.AutoStart.ToString())
                sw.Close()
                sw.Dispose()
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-001", ex.Message, "Coulnt create new app defaults.")
            End Try
        End Sub

        Shared Function Read() As Settings.App
            Try
                If (File.Exists(Settings.FileDirectory & FileName)) Then
                    Return Convert(File.ReadAllLines(Settings.FileDirectory & FileName))
                Else
                    CreateDefault()
                    QC_Debugger.Write("QC-FIO-002", "App settings file did not exist.", "Created new app settings file at runtime.")
                    Return Convert(File.ReadAllLines(Settings.FileDirectory & FileName))
                End If
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-003", ex.Message & " : " & ex.StackTrace, "Created app settings temporary file at runtime.")
                Return New Settings.App
            End Try
        End Function

        Shared Sub Save(ByVal appSttg As Settings.App)
            Try
                Directory.CreateDirectory(Settings.FileDirectory)
                Dim sw As New StreamWriter(File.Create(Settings.FileDirectory & FileName))
                sw.WriteLine(appSttg.CurrentProfileIndex.ToString() & "|" & appSttg.AutoStart.ToString())
                sw.Close()
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-004", ex.Message, "Failed to save app settings file.")
            End Try
        End Sub

        Shared Function Convert(ByVal file As String()) As Settings.App
            Dim tmp As New Settings.App

            tmp.Profiles = GetProfileNames()
            Try
                tmp.CurrentProfileIndex = CInt(file(0).Split("|")(0))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-006", "Failed to convert CurrentProfileIndex to Integer.", "Used default value.")
                tmp.CurrentProfileIndex = Settings.FallBack.CurrentProfileIndex
            End Try

            ' Attempts to validate data, defaults used on failure 
            Try
                tmp.AutoStart = CBool(file(0).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-005", "Failed to convert AutoStart to Boolean.", "Used default value.")
                tmp.AutoStart = Settings.FallBack.AutoStart
            End Try

            If tmp.CurrentProfileIndex <> -1 And tmp.CurrentProfileIndex < tmp.Profiles.Count Then
                tmp.CurrentProfile = Profile.Read(tmp.Profiles(tmp.CurrentProfileIndex))
            Else
                tmp.CurrentProfile = New Settings.Profile
            End If
            Return tmp
        End Function

        Shared Sub ClearTempDir()
            Try
                Dim filePaths = Directory.GetFiles(Settings.FileDirectory & "Temp\")
                For i = 0 To filePaths.Length - 1
                    'QC_Debugger.Write("QC-FIO-106", "FileFound", filePaths(i))
                    If filePaths(i).StartsWith(Settings.FileDirectory & "Temp\Temp_") And filePaths(i).EndsWith(".jpg") Then
                        File.Delete(filePaths(i))
                    End If
                Next
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-105", ex.Message, "Could not clean temp folder.")
            End Try
        End Sub

        Shared Function GetProfileNames() As List(Of String)
            Dim tmp2 As New List(Of String)

            ' Retieve profile data
            For Each fileFound As String In Directory.GetFiles(Settings.FileDirectory)
                If (fileFound.StartsWith(Settings.FileDirectory & Profile.FileNamePartA) And fileFound.EndsWith(Profile.FileNamePartB)) Then
                    tmp2.Add(fileFound.Replace(Settings.FileDirectory & Profile.FileNamePartA, "").Replace(Profile.FileNamePartB, ""))
                End If
            Next
            tmp2.Sort()
            Return tmp2
        End Function
    End Class

    Public Class Profile
        Shared _FileNamePartA As String = "Profile_"
        Shared _FileNamePartB As String = ".qcsf"
        Public Shared ReadOnly Property FileNamePartA As String
            Get
                Return _FileNamePartA
            End Get
        End Property
        Public Shared ReadOnly Property FileNamePartB As String
            Get
                Return _FileNamePartB
            End Get
        End Property

        Shared Sub CreateDefault(name As String)
            Try
                Directory.CreateDirectory(Settings.FileDirectory)
                Dim sw As New StreamWriter(File.Create(Settings.FileDirectory & FileNamePartA & name & FileNamePartB))
                sw.WriteLine(Settings.FallBack.SaveLocation & "|" & Settings.FallBack.SSOpenWndDelay.ToString())
                sw.WriteLine(Settings.FallBack.HKModifier(0).ToString() & "|" & Settings.FallBack.HKModifier(1).ToString())
                sw.WriteLine(Settings.FallBack.HKKeyCode.ToString() & "|" & Settings.FallBack.ViewScreen.ToString())
                sw.WriteLine(Settings.FallBack.Prefix & "|" & Settings.FallBack.Postfix)
                sw.WriteLine(Settings.FallBack.DefaultScreens(0) & "|" & Settings.FallBack.AllScreens.ToString())
                sw.WriteLine(Settings.FallBack.SaveAsSingle.ToString() & "|" & Settings.FallBack.CopyToClipBoard.ToString())
                sw.Close()
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-007", ex.Message, "Coulnt create new profile defaults.")
            End Try
        End Sub

        Shared Function Read(fileName As String) As Settings.Profile
            Try
                If (File.Exists(Settings.FileDirectory & _FileNamePartA & fileName & FileNamePartB)) Then
                    Return Convert(File.ReadAllLines(Settings.FileDirectory & _FileNamePartA & fileName & FileNamePartB))
                Else
                    CreateDefault(fileName)
                    QC_Debugger.Write("QC-FIO-008", "Profile settings file did not exist.", "Created new profile settings file at runtime for " & fileName & ".")
                    Return Convert(File.ReadAllLines(Settings.FileDirectory & _FileNamePartA & fileName & FileNamePartB))
                End If
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-009", ex.Message, "Created profile settings temporary file at runtime.")
                Return New Settings.Profile
            End Try
        End Function

        Shared Sub Save(ByVal proSttg As Settings.Profile, filename As String)
            Try
                Directory.CreateDirectory(settings.FileDirectory)
                Dim sw As New StreamWriter(File.Create(Settings.FileDirectory & FileNamePartA & filename & FileNamePartB))
                sw.WriteLine(proSttg.SaveLocation & "|" & proSttg.SSOpenWndDelay.ToString())
                sw.WriteLine(proSttg.HKMod1.ToString() & "|" & proSttg.HKMod2.ToString())
                sw.WriteLine(proSttg.HKKeyCode.ToString() & "|" & proSttg.ViewScreen.ToString())
                sw.WriteLine(proSttg.Prefix & "|" & proSttg.Postfix)
                Dim screens As String = ""
                For i = 0 To proSttg.DefaultScreens.Count - 1
                    screens = screens & proSttg.DefaultScreens(i).ToString()
                    If i <> proSttg.DefaultScreens.Count - 1 Then
                        screens = screens & ","
                    End If
                Next
                sw.WriteLine(screens & "|" & proSttg.AllScreens.ToString())
                sw.WriteLine(proSttg.SaveAsSingle.ToString() & "|" & proSttg.CopyToClipBoard.ToString())
                sw.Close()
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-010", ex.Message, "Failed to save profile settings file.")
            End Try
        End Sub

        Shared Function Convert(ByVal file As String()) As Settings.Profile
            Dim tmp As New Settings.Profile()

            ' Attempts to validate data, defaults used on failure 
            'line 1
            Try
                tmp.SaveLocation = file(0).Split("|")(0)
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-011", "Failed to read DefaultLocation.", "Used default value.")
            End Try
            Try
                tmp.SSOpenWndDelay = CInt(file(0).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-012", "Failed to convert SSOpenWndDelay to integer.", "Used default value.")
            End Try
            'line 2
            Try
                tmp.HKMod1 = CInt(file(1).Split("|")(0))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-013", "Failed to convert HKModifier(0) to integer.", "Used default value.")
            End Try
            Try
                tmp.HKMod2 = CInt(file(1).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-014", "Failed to convert HKModifier(1) to integer.", "Used default value.")
            End Try
            'line 3
            Try
                tmp.HKKeyCode = CInt(file(2).Split("|")(0))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-015", "Failed to convert HKKeyCode to integer.", "Used default value.")
            End Try
            Try
                tmp.ViewScreen = CInt(file(2).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-016", "Failed to convert ViewScreen to integer.", "Used default value.")
            End Try
            'line 4
            Try
                tmp.Prefix = file(3).Split("|")(0)
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-017", "Failed to read Prefix.", "Used default value.")
            End Try
            Try
                tmp.Postfix = file(3).Split("|")(1)
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-018", "Failed to read Postfix.", "Used default value.")
            End Try
            'line 5
            Try
                tmp.DefaultScreens.Clear()
                For i = 0 To file(4).Split("|")(0).Split(",").Length - 1
                    tmp.DefaultScreens.Add(CInt(file(4).Split("|")(0).Split(",")(i)))
                Next
                'tmp.DefaultScreens = Array.ConvertAll(file(4).Split("|")(0).Split(","), Function(str) Int32.Parse(str)).ToList()
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-019", "Failed to convert DefaultScreens to Int Array.", "Used default value.")
            End Try
            Try
                tmp.AllScreens = CBool(file(4).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-020", "Failed to convert AllScreens to boolean.", "Used default value.")
            End Try
            'line 6
            Try
                tmp.SaveAsSingle = CBool(file(5).Split("|")(0))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-021", "Failed to convert SaveAsSingle to boolean.", "Used default value.")
            End Try
            Try
                tmp.CopyToClipBoard = CBool(file(5).Split("|")(1))
            Catch ex As Exception
                QC_Debugger.Write("QC-FIO-022", "Failed to convert CopyToClipBoard to boolean.", "Used default value.")
            End Try
            Return tmp
        End Function
    End Class
End Class

Public Class QC_Debugger
    Private Shared debugFolder = Settings.FileDirectory & "Debug\"
    Private Shared ext = ".qcdf"
    Private Shared debugFile = debugFolder & "QC_Debug" & ext

    Public Shared Sub Write(ByVal _ErrorCode As String, ByVal _ExceptionMsg As String, ByVal _Solution As String)
        Try
            Dim dt As String = TimeOfDay.Hour & "." & TimeOfDay.Minute & "." & TimeOfDay.Second & "::" & DateAndTime.Now.Month & "." & DateAndTime.Now.Day & "." & DateAndTime.Now.Year
            Directory.CreateDirectory(debugFolder)
            Dim sw As New StreamWriter(debugFile, True)
            'Add time/date to line
            sw.WriteLine(_ErrorCode & "  |  " & dt & "  |  " & _ExceptionMsg & "  |  " & _Solution & Environment.NewLine)
            sw.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Quick Capture", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
