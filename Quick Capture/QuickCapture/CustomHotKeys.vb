Public NotInheritable Class HotKeyRegistryClass
    Private Declare Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32, ByVal fsModifier As Int32, ByVal vk As Int32) As Int32
    Private Declare Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32) As Int32
    Private Handle As IntPtr = IntPtr.Zero
    Private Registry As New System.Collections.Generic.List(Of Int32)

    Public Enum Messages
        [WM_HOTKEY] = &H312
    End Enum

    Public Enum Modifiers
        [MOD_ALT] = &H1
        [MOD_CTRL] = &H2
        [MOD_SHIFT] = &H4
        [MOD_WIN] = &H8
    End Enum



    Sub New(ByVal Handle As IntPtr)
        Me.Handle = Handle
    End Sub

    Public Function Register(ByVal Modifier As Int32, ByVal Key As System.Windows.Forms.Keys) As Int32
        Dim ret As Int32
        ret = NextAvailableIndex()
        Call RegisterHotKey(Me.Handle, ret, Modifier, Key)
        Registry.Insert(ret, ret)
        Return ret
    End Function

    Public Sub Unregister(ByVal ID As Int32)
        Call UnregisterHotKey(Me.Handle, ID)
        Registry.Remove(ID)
    End Sub

    Private Function NextAvailableIndex() As Int32
        Dim ret As Int32 = 0
        Dim n As Int32 = 0

        For i As Int32 = 0 To Registry.Count - 1
            If Registry(i) = n Then
                n = n + 1
            ElseIf n < Registry(i) Then
                Return n
            End If
        Next
        If n = Registry.Count Then
            Return Registry.Count
        End If
        Return ret
    End Function
End Class

Public NotInheritable Class HotKeyManager
    Private registryClass As HotKeyRegistryClass
    Private hotKeyIndexes As List(Of Int32)
    Private hotKeyNames As List(Of String)
    Private _curHotKeys As Boolean = False
    Public ReadOnly Property CurrentHotKeys As Boolean
        Get
            Return _curHotKeys
        End Get
    End Property

    Public Sub New(ByVal _handle As IntPtr)
        registryClass = New HotKeyRegistryClass(_handle)
        hotKeyIndexes = New List(Of Int32)
        hotKeyNames = New List(Of String)
    End Sub

    Public Sub New(ByRef regClass As HotKeyRegistryClass)
        registryClass = regClass
        hotKeyIndexes = New List(Of Int32)
        hotKeyNames = New List(Of String)
    End Sub

    Public Sub AddHotKey(ByVal _title As String, ByVal _modifier As Int32, ByVal _key As System.Windows.Forms.Keys)
        AddToList(_title, registryClass.Register(_modifier, _key))
        _curHotKeys = True
    End Sub

    Public Sub RemoveHotKey(ByVal _title As String)
        registryClass.Unregister(hotKeyIndexes(hotKeyNames.IndexOf(_title)))
        RemovefromList(_title)
        If Not hotKeyIndexes.Count > 0 Then
            _curHotKeys = False
        End If
    End Sub

    Public Sub AddToList(ByVal _title As String, ByVal _index As Int32)
        hotKeyNames.Add(_title)
        hotKeyIndexes.Add(_index)
    End Sub

    Private Sub RemovefromList(ByVal _title As String)
        hotKeyIndexes.RemoveAt(hotKeyNames.IndexOf(_title))
        hotKeyNames.RemoveAt(hotKeyNames.IndexOf(_title))
    End Sub

    Public Function IndexOf(ByVal _title As String)
        Return hotKeyNames.IndexOf(_title)
    End Function
End Class