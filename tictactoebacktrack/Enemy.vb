Public Class Enemy
    Dim brd As Board
    Dim count As Integer

    Public Sub New(ByVal brd As Board)
        Me.brd = brd

    End Sub
    Private Function evaluatePosition() As GameCondition
        Dim c As GameCondition
        If brd.IsWin(TurnAction.COM) Then
            c = GameCondition.COMPUTER_WIN
        ElseIf brd.IsWin(TurnAction.Player) Then
            c = GameCondition.HUMAN_WIN
        ElseIf brd.IsDraw() Then
            c = GameCondition.DRAW
        Else
            c = GameCondition.GAMECONTINUE
        End If
        Return c
    End Function

    Public Function chooseMove(ByVal side As TurnAction) As Move
        Dim opp As TurnAction
        Dim reply As Move
        Dim eval As GameCondition
        Dim bestRow As Integer
        Dim bestCol As Integer
        Dim value As Integer

        Dim row, col As Integer


        count += 1

        eval = evaluatePosition()

        If (eval <> GameCondition.GAMECONTINUE) Then Return New Move(eval)
        If (side = TurnAction.Player) Then
            opp = TurnAction.COM
        Else
            opp = TurnAction.Player
        End If
        ' Application.DoEvents()
        value = IIf(side = TurnAction.Player, GameCondition.COMPUTER_WIN, GameCondition.HUMAN_WIN)
        'Application.DoEvents()
        For row = 0 To brd.GetSize() - 1
            For col = 0 To brd.GetSize() - 1
                If (brd.GetBoardContent(row, col) = TTTSymbol.NONE) Then
                    brd.SetBoardContent(row, col, side)
                    reply = chooseMove(opp)
                    brd.SetBoardContent(row, col, TTTSymbol.NONE)

                    If (mystat.level = GameLevel.HARD) Then
                        If (side = TurnAction.COM And reply.val > value Or side = TurnAction.Player And reply.val < value) Then
                            value = reply.val
                            bestRow = row
                            bestCol = col
                        End If
                    Else
                        If (reply.val = GameCondition.COMPUTER_WIN) Then
                            value = reply.val
                            bestRow = row
                            bestCol = col
                        End If
                    End If

                End If
            Next col

        Next row
        Return New Move(value, bestRow, bestCol)
    End Function
End Class
