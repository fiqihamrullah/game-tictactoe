Public Class FrmPlay
    Dim awalx As Integer, akhirx As Integer
    Dim awaly As Integer, akhiry As Integer
    Dim renggangx As Integer
    Dim renggangy As Integer
    Dim turn As TurnAction
    Dim globalx As Integer
    Dim globaly As Integer
    Dim nxn As Integer
    Dim objbrd As Board
    Private Structure TTTPoint
        Dim row As Integer
        Dim col As Integer
    End Structure
    Dim cp As TTTPoint
    Private Function GetPointFromPosition(ByVal pos As Integer)
        Dim p As TTTPoint
        Dim row As Integer = Math.Floor(pos / nxn)
        Dim col As Integer = pos Mod nxn
        p.row = row
        p.col = col
        Return p
    End Function
    Private Function GetTTTPoint(ByVal x As Integer, ByVal y As Integer) As TTTPoint
        Dim sp As TTTPoint
        If (renggangx <> 0) Then
            sp.col = ((x - awalx) \ renggangx) + 1
            sp.row = ((y - awaly) \ renggangy) + 1
        Else
            sp.col = 0
            sp.row = 0
        End If
        Return sp
    End Function

    Private Sub FrmPlay_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If (gs.pilbacksound = 0) Then
            PlayBack1()
        Else
            PlayBack2()
        End If
    End Sub
    Private Sub FrmPlay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        turn = TurnAction.Player
        showStatus()

        If mystat.symbol = TTTSymbol.Circle Then

            pbPlayer.Image = My.Resources.circle
            pbCom.Image = My.Resources.cross


        ElseIf mystat.symbol = TTTSymbol.Cross Then

            pbPlayer.Image = My.Resources.cross

            pbCom.Image = My.Resources.circle
        ElseIf mystat.symbol = TTTSymbol.User Then

            pbPlayer.Image = My.Resources.user

            pbCom.Image = My.Resources.screen_windows
        Else
            pbPlayer.Image = My.Resources.screen_windows

            pbCom.Image = My.Resources.user

        End If


        If mystat.level = GameLevel.EASY Or mystat.level = GameLevel.MEDIUM Then
            nxn = 3
        Else
            nxn = 3
        End If
        awalx = 10
        akhirx = pbKotakTTT.Width - 10
        awaly = 10
        akhiry = pbKotakTTT.Height - 10
        renggangx = (akhirx - awalx) / nxn
        renggangy = (akhiry - awaly) / nxn
        ' ReDim jawaban(nxn, nxn)
        objbrd = New Board(nxn)
        objbrd.Empty()

    End Sub

    Private Sub showStatus()
        lblLevel.Text = mystat.level.ToString()
        lblgwins.Text = mystat.nwin.ToString()
        lblgloses.Text = mystat.nloses.ToString()
        lblturn.Text = turn.ToString()
    End Sub
    Private Sub nextTurn()
        If turn = TurnAction.COM Then
            turn = TurnAction.Player
        Else
            turn = TurnAction.COM
        End If
    End Sub
    Private Sub pbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtnExit.Click
        Me.Close()
        FrmMenuUtama.Show()
        StopPlayBack1()
    End Sub
    Private Sub RandomMethod()
        Dim rand As New Random
        Dim rnd As Integer
        Dim kosong As Boolean = False
        Dim pt As TTTPoint
        Do
            rnd = rand.Next(9)
            ' System.Diagnostics.Trace.WriteLine("Random : " + rnd.ToString())
            pt = GetPointFromPosition(rnd)
            'System.Diagnostics.Trace.WriteLine("PT Baris: " + pt.row.ToString() + ", PT Kolom : " + pt.col.ToString())
            If (objbrd.GetBoardContent(pt.row, pt.col) = 0) Then
                kosong = True
            End If
        Loop Until kosong = True
        objbrd.SetBoardContent(pt.row, pt.col, 2)
    End Sub

    Private Sub pbKotakTTT_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbKotakTTT.Paint
        Dim i As Integer, j As Integer
        Dim col, row As Integer
        Dim g As Graphics

        g = e.Graphics


        For row = 0 To nxn - 1
            For col = 0 To nxn - 1

                g.FillRectangle(Brushes.WhiteSmoke, awalx + ((col) * renggangx), awaly + ((row) * renggangy), renggangx, renggangy)

            Next col
        Next row

        g.FillRectangle(Brushes.Gold, awalx + ((cp.col - 1) * renggangx), awaly + ((cp.row - 1) * renggangy), renggangx, renggangy)

        For i = 0 To nxn - 1
            For j = 0 To nxn - 1
                If (objbrd.GetBoardContent(i, j) = 1) Then
                    g.DrawImage(pbPlayer.Image, awalx + ((j) * renggangx), awaly + ((i) * renggangy), renggangx, renggangy)
                ElseIf (objbrd.GetBoardContent(i, j) = 2) Then
                    g.DrawImage(pbCom.Image, awalx + ((j) * renggangx), awaly + ((i) * renggangy), renggangx, renggangy)
                End If
            Next j
        Next i



        Dim posborder As Integer = 0
        For i = awalx To akhirx + renggangx Step renggangx
            If (posborder Mod nxn = 0) Then
                g.DrawLine(New Pen(Color.Olive, 3), i, awaly, i, akhiry)
                posborder = 0
            Else
                g.DrawLine(New Pen(Color.Crimson), i, awaly, i, akhiry)
            End If

            posborder += 1
        Next i
        posborder = 0
        For i = awaly To akhiry Step renggangy
            If (posborder Mod nxn = 0) Then
                g.DrawLine(New Pen(Color.Olive, 3), awalx, i, akhirx, i)
                posborder = 0
            Else
                g.DrawLine(New Pen(Color.Crimson), awalx, i, akhirx, i)
            End If

            posborder += 1
        Next i
    End Sub

    Private Sub pbKotakTTT_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKotakTTT.MouseMove
        globalx = e.X
        globaly = e.Y
        cp = GetTTTPoint(globalx, globaly)
        pbKotakTTT.Invalidate()
    End Sub

    Private Sub pbKotakTTT_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbKotakTTT.MouseHover

    End Sub

    Private Sub pbKotakTTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbKotakTTT.Click
        If (objbrd.GetBoardContent(cp.row - 1, cp.col - 1) = 0) Then
            objbrd.SetBoardContent(cp.row - 1, cp.col - 1, 1)
            Application.DoEvents()
            ' SuaraKlik()
            pbKotakTTT.Invalidate()
            If (objbrd.IsWin(1)) Then
                Dim fgameover As FrmPopUpGameOver
                fgameover = New FrmPopUpGameOver()
                fgameover.setMenang()

                fgameover.ShowDialog()
                showStatus()

            End If

           
            If Not (objbrd.IsWin(1) Or objbrd.IsWin(2)) Then

                'pbKotakTTT.Invalidate()
                If Not (objbrd.IsDraw()) Then

                    If (mystat.level = GameLevel.EASY) Then
                        RandomMethod()
                    ElseIf mystat.level = GameLevel.MEDIUM Then
                        Dim musuh As New Enemy(objbrd)
                        Dim mv As Move
                        mv = musuh.chooseMove(TurnAction.COM)
                        objbrd.SetBoardContent(mv.Row, mv.Column, TurnAction.COM)
                    ElseIf mystat.level = GameLevel.HARD Then
                        Dim musuh As New Enemy(objbrd)
                        Dim mv As Move
                        mv = musuh.chooseMove(TurnAction.COM)
                        objbrd.SetBoardContent(mv.Row, mv.Column, TurnAction.COM)
                    End If
                    If (objbrd.IsWin(2)) Then
                        Dim fgameover As FrmPopUpGameOver
                        fgameover = New FrmPopUpGameOver()
                        fgameover.setKalah()
                        fgameover.ShowDialog()
                    End If
                    showStatus()
                Else

                    Dim fgameover As FrmPopUpGameOver
                    fgameover = New FrmPopUpGameOver()
                    fgameover.setDraw()
                    fgameover.ShowDialog()
                    showStatus()
                End If


            End If
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        objbrd.Empty()
        showStatus()
        pbKotakTTT.Invalidate()
    End Sub
End Class