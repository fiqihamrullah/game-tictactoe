Imports System.Media

Public Enum TTTSymbol
    NONE = 0
    Circle = 1
    Cross = 2
    User = 3
    Com = 4
End Enum
Public Enum TurnAction
    COM = 2
    Player = 1
End Enum

Public Enum GameCondition
    COMPUTER_WIN = 7
    HUMAN_WIN = 4
    DRAW = 5
    GAMECONTINUE = 6
End Enum

Public Enum GameLevel
    NONE = 0
    EASY = 1
    MEDIUM = 2
    HARD = 3
End Enum

Public Structure GameStat
    Dim symbol As TTTSymbol
    Dim level As GameLevel
    Dim nwin As Integer
    Dim nloses As Integer
    Dim ndraw As Integer


End Structure
Public Structure GameSetting
    Dim adasuara As Boolean
    Dim pilbacksound As Integer

End Structure

Module ModulBantu
    Public mystat As GameStat
    Public gs As GameSetting
    Dim sndpback1 As SoundPlayer
    Dim sndpback2 As SoundPlayer

    Public Sub SuaraKlik()

        Dim sndP As New SoundPlayer(My.Resources.click)
        If (gs.adasuara) Then
            sndP.Play()
        End If

    End Sub

    Public Sub SoundDraw()

        Dim sndP As New SoundPlayer(My.Resources.draw)
        If (gs.adasuara) Then
            sndP.Play()
        End If

    End Sub

    Public Sub SoundWin()

        Dim sndP As New SoundPlayer(My.Resources.winnerofgame)
        If (gs.adasuara) Then
            sndP.Play()
        End If

    End Sub

    Public Sub SoundLose()

        Dim sndP As New SoundPlayer(My.Resources.gameover)
        If (gs.adasuara) Then
            sndP.Play()
        End If

    End Sub

    Public Sub PlayBack1()
        sndpback1 = New SoundPlayer(My.Resources.back1)
        If (gs.adasuara) Then
            sndpback1.Play()
        End If
    End Sub

    Public Sub StopPlayBack1()
        sndpback1.Stop()
    End Sub

    Public Sub PlayBack2()
        sndpback2 = New SoundPlayer(My.Resources.back2)
        If (gs.adasuara) Then
            sndpback2.Play()
        End If
    End Sub

    Public Sub StopPlayBack2()
        sndpback2.Stop()
    End Sub

End Module
