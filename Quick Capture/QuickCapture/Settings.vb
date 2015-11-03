Public Class Settings
    ' Static Readonly app settings
    Shared _FileDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\QuickCapture\"
    Shared _KCodes() As Integer = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105}
    Shared _KCodesValue() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Num 0", "Num 1", "Num 2", "Num 3", "Num 4", "Num 5", "Num 6", "Num 7", "Num 8", "Num 9", "NumPad 0", "NumPad 1", "NumPad 2", "NumPad 3", "NumPad 4", "NumPad 5", "NumPad 6", "NumPad 7", "NumPad 8", "NumPad 9"}
    Public Shared ReadOnly Property FileDirectory As String
        Get
            Return _FileDirectory
        End Get
    End Property
    Public Shared ReadOnly Property KCodes As List(Of Integer)
        Get
            Return _KCodes.ToList()
        End Get
    End Property
    Public Shared ReadOnly Property KCodesValues As List(Of String)
        Get
            Return _KCodesValue.ToList()
        End Get
    End Property

    Public Class App
        Private _CurrentProfileIndex As Integer
        Private _CurrentProfile As Profile
        Private _Profiles As List(Of String)
        Private _AutoStart As Boolean

        Sub New()
            Profiles = FallBack.Profiles.ToList
            CurrentProfileIndex = FallBack.CurrentProfileIndex
            CurrentProfile = New Profile
            AutoStart = FallBack.AutoStart
        End Sub

        Public Property CurrentProfileIndex As Integer
            Get
                Return _CurrentProfileIndex
            End Get
            Set(value As Integer)
                If value > -2 Then
                    _CurrentProfileIndex = value
                Else
                    Throw New Exception("Value out of range")
                End If
            End Set
        End Property
        Public Property CurrentProfile As Profile
            Get
                Return _CurrentProfile
            End Get
            Set(value As Profile)
                _CurrentProfile = value
            End Set
        End Property
        Public Property Profiles As List(Of String)
            Get
                Return _Profiles
            End Get
            Set(value As List(Of String))
                _Profiles = value
            End Set
        End Property
        Public Property AutoStart As Boolean
            Get
                Return _AutoStart
            End Get
            Set(value As Boolean)
                _AutoStart = value
            End Set
        End Property
    End Class

    Public Class Profile
        Private _SaveLocation As String
        Private _SSOpenWndDelay As Integer
        Private _ViewScreen As Integer
        Private _HKMod1 As Integer
        Private _HKMod2 As Integer
        Private _HKKeyCode As Integer
        Private _Prefix As String
        Private _Postfix As String
        Private _DefaultScreens As List(Of Integer)
        Private _AllScreens As Boolean
        Private _SaveAsSingle As Boolean
        Private _CopyToClipBoard As Boolean

        Sub New()
            SaveLocation = FallBack.SaveLocation
            SSOpenWndDelay = FallBack.SSOpenWndDelay
            ViewScreen = FallBack.ViewScreen
            _HKMod1 = FallBack.HKModifier(0)
            _HKMod2 = FallBack.HKModifier(1)
            HKKeyCode = FallBack.HKKeyCode
            Prefix = FallBack.Prefix
            Postfix = FallBack.Postfix
            _DefaultScreens = FallBack.DefaultScreens.ToList()
            AllScreens = FallBack.AllScreens
            SaveAsSingle = FallBack.SaveAsSingle
            CopyToClipBoard = FallBack.CopyToClipBoard
        End Sub

        Public Property SaveLocation As String
            Get
                Return _SaveLocation
            End Get
            Set(value As String)
                If System.IO.Directory.Exists(value) Then
                    _SaveLocation = value
                Else
                    _SaveLocation = Settings.FallBack.SaveLocation
                End If
            End Set
        End Property
        Public Property SSOpenWndDelay As Integer
            Get
                Return _SSOpenWndDelay
            End Get
            Set(value As Integer)
                If value >= 0 Then
                    _SSOpenWndDelay = value
                Else
                    _SSOpenWndDelay = Settings.FallBack.SSOpenWndDelay
                End If
            End Set
        End Property
        Public Property ViewScreen As Integer
            Get
                Return _ViewScreen
            End Get
            Set(value As Integer)
                If value > -1 And value < Screen.AllScreens.Length Then
                    _ViewScreen = value
                Else
                    _ViewScreen = Settings.FallBack.ViewScreen
                End If
            End Set
        End Property
        Public Property HKMod1 As Integer
            Get
                Return _HKMod1
            End Get
            Set(value As Integer)
                If value > -1 And value < 4 And value <> HKMod2 Then
                    _HKMod1 = value
                Else
                    If HKMod2 <> FallBack.HKModifier(0) Then
                        _HKMod1 = FallBack.HKModifier(0)
                    Else
                        _HKMod1 = FallBack.HKModifier(1)
                    End If
                End If
            End Set
        End Property
        Public Property HKMod2 As Integer
            Get
                Return _HKMod2
            End Get
            Set(value As Integer)
                If value > -2 And value < 4 And value <> HKMod1 Then
                    _HKMod2 = value
                Else
                    If HKMod1 <> FallBack.HKModifier(HKMod1) Then
                        _HKMod2 = Settings.FallBack.HKModifier(1)
                    Else
                        _HKMod2 = Settings.FallBack.HKModifier(0)
                    End If
                    _HKMod2 = Settings.FallBack.HKModifier(1)
                End If
            End Set
        End Property
        Public Property HKKeyCode As Integer
            Get
                Return _HKKeyCode
            End Get
            Set(value As Integer)
                '' Create a Global Function that check if the key is one accepted.
                _HKKeyCode = value
            End Set
        End Property
        Public Property Prefix As String
            Get
                Return _Prefix
            End Get
            Set(value As String)
                If Not value.Trim() = String.Empty And Not value = "**null**" Then
                    _Prefix = value
                Else
                    _Prefix = Settings.FallBack.Prefix
                End If
            End Set
        End Property
        Public Property Postfix As String
            Get
                Return _Postfix
            End Get
            Set(value As String)
                If Not value.Trim() = String.Empty And Not value = "**null**" Then
                    _Postfix = value
                Else
                    _Postfix = Settings.FallBack.Postfix
                End If
            End Set
        End Property
        Public Property DefaultScreens As List(Of Integer)
            Get
                Return _DefaultScreens
            End Get
            Set(value As List(Of Integer))
                If value.Count > -1 And value.Count < Screen.AllScreens.Length Then
                    'MsgBox("0")
                    _DefaultScreens.Clear()
                    _DefaultScreens.AddRange(value)
                Else
                    'MsgBox("1")
                    _DefaultScreens = Settings.FallBack.DefaultScreens.ToList()
                End If
            End Set
        End Property
        Public Property AllScreens As Boolean
            Get
                Return _AllScreens
            End Get
            Set(value As Boolean)
                If Not value = Nothing Then
                    _AllScreens = value
                Else
                    _AllScreens = Settings.FallBack.AllScreens
                End If
            End Set
        End Property
        Public Property SaveAsSingle As Boolean
            Get
                Return _SaveAsSingle
            End Get
            Set(value As Boolean)
                If Not value = Nothing Then
                    _SaveAsSingle = value
                Else
                    _SaveAsSingle = Settings.FallBack.SaveAsSingle
                End If
            End Set
        End Property
        Public Property CopyToClipBoard As Boolean
            Get
                Return _CopyToClipBoard
            End Get
            Set(value As Boolean)
                If Not value = Nothing Then
                    _CopyToClipBoard = value
                Else
                    _CopyToClipBoard = Settings.FallBack.CopyToClipBoard
                End If
            End Set
        End Property
    End Class
    Public Class FallBack
        ' App 
        Shared _CurrentProfileIndex As Integer = -1
        Shared _Profiles() As String = {}
        Shared _AutoStart As Boolean = False
        ' Profile
        Shared _SaveLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Shared _SSOpenWndDelay As Integer = 175
        Shared _HKModifier As Integer() = {0, 2}
        Shared _HKKeyCode As Integer = 15
        Shared _Prefix As String = ""
        Shared _Postfix As String = ""
        Shared _DefaultScreens() As Integer = {0}
        Shared _AllScreens As Boolean = False
        Shared _SaveAsSingle As Boolean = False
        Shared _CopyToClipBoard As Boolean = False
        Shared _ViewScreen As Integer = 0

        ' App
        Public Shared ReadOnly Property CurrentProfileIndex As Integer
            Get
                Return _CurrentProfileIndex
            End Get
        End Property
        Public Shared ReadOnly Property Profiles As String()
            Get
                Return _Profiles
            End Get
        End Property
        Public Shared ReadOnly Property AutoStart As Boolean
            Get
                Return _AutoStart
            End Get
        End Property
        'Profile
        Public Shared ReadOnly Property SaveLocation As String
            Get
                Return _SaveLocation
            End Get
        End Property
        Public Shared ReadOnly Property SSOpenWndDelay As String
            Get
                Return _SSOpenWndDelay
            End Get
        End Property
        Public Shared ReadOnly Property HKModifier As Integer()
            Get
                Return _HKModifier
            End Get
        End Property
        Public Shared ReadOnly Property HKKeyCode As Integer
            Get
                Return _HKKeyCode
            End Get
        End Property
        Public Shared ReadOnly Property Prefix As String
            Get
                Return _Prefix
            End Get
        End Property
        Public Shared ReadOnly Property Postfix As String
            Get
                Return _Postfix
            End Get
        End Property
        Public Shared ReadOnly Property DefaultScreens As Integer()
            Get
                Return _DefaultScreens
            End Get
        End Property
        Public Shared ReadOnly Property AllScreens As Boolean
            Get
                Return _AllScreens
            End Get
        End Property
        Public Shared ReadOnly Property SaveAsSingle As Boolean
            Get
                Return _SaveAsSingle
            End Get
        End Property
        Public Shared ReadOnly Property CopyToClipBoard As Boolean
            Get
                Return _CopyToClipBoard
            End Get
        End Property
        Public Shared ReadOnly Property ViewScreen As Integer
            Get
                Return _ViewScreen
            End Get
        End Property
    End Class
    '!CurrentProfile|auto start

    '!DefaultLocation|!SnapShot Delay (open-window)
    '!HotKey Modifier 1|!HotKey Modifier 2
    '!HotKey KeyCode|Viewing Screen
    '!Prefix | !Postfix
    'DefaultScreen(s)|All Screens
    'MS SaveAsSingle|!CopyTo ClipBoard
End Class
