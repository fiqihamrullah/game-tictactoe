Public Class Board
    Dim size As Integer
    Dim board(,) As Integer
    Public Sub New(ByVal size As Integer)
        Me.size = size
        ReDim board(size, size)
        Empty()
    End Sub
    Public Sub Empty()
        Dim i, j As Integer
        For i = 0 To size - 1
            For j = 0 To size - 1
                board(i, j) = TTTSymbol.NONE
            Next j
        Next i
    End Sub
    Public Function GetBoardContent(ByVal i As Integer, ByVal j As Integer)
        Return board(i, j)
    End Function
    Public Sub SetBoardContent(ByVal i As Integer, ByVal j As Integer, ByVal val As Integer)
        board(i, j) = val
    End Sub
    Public Sub Copy(ByVal b As Board)
        Dim i, j As Integer
        For i = 0 To size - 1
            For j = 0 To size - 1
                board(i, j) = b.GetBoardContent(i, j)
            Next j
        Next i
    End Sub
    Public Sub Print()

    End Sub
    Public Function IsWin(ByVal valbidak As Integer) As Boolean
        Dim bwin As Boolean = False
        Dim i As Integer
        Dim c As Integer
        'Check Horizontal
        For i = 0 To size - 1
            c = 0
            For j = 0 To size - 1
                If (board(i, j) = valbidak) Then
                    c += 1
                End If
            Next j
            If c = size Then
                bwin = True
                Exit For
            End If
        Next i
        'Cek Vertikal
        If (bwin = False) Then
            For j = 0 To size - 1
                c = 0
                For i = 0 To size - 1
                    If (board(i, j) = valbidak) Then
                        c += 1
                    End If
                Next i
                If c = size Then
                    bwin = True
                    Exit For
                End If
            Next j
        End If
        'Cek Diagonal
        If (bwin = False) Then
            c = 0
            For i = 0 To size - 1
                If (board(i, i) = valbidak) Then
                    c += 1
                End If
            Next i
            If c = size Then
                bwin = True
            End If

            c = 0
            For i = 0 To size - 1
                If (board((size - 1) - i, i) = valbidak) Then
                    c += 1
                End If
            Next i
            If c = size Then
                bwin = True
            End If

        End If

        Return bwin
    End Function
    Public Function GetSize() As Integer
        Return size
    End Function
    Public Function IsDraw() As Boolean
        Dim bDraw As Boolean = True
        Dim i, j As Integer
        For i = 0 To size - 1
            For j = 0 To size - 1
                If (board(i, j) = 0) Then
                    bDraw = False
                    Exit For
                End If
            Next
            If bDraw = False Then
                Exit For
            End If
        Next i
        Return bDraw
    End Function

End Class
