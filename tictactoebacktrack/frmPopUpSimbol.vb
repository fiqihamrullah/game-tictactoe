Public Class frmPopUpSimbol
    Dim pilbidak As TTTSymbol
    Private Sub pbtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtnSelect.Click
        Me.Close()
        mystat.symbol = pilbidak
        SuaraKlik()
        ' FrmPlay.Show()
    End Sub
    Private Sub pbcircle_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcircle.MouseHover
        pbcircle.BackColor = Color.Tan
    End Sub
    Private Sub pbcircle_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcircle.MouseLeave
        If pilbidak <> TTTSymbol.Circle Then
            pbcircle.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub pbcross_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcross.MouseHover
        pbcross.BackColor = Color.Tan
    End Sub
    Private Sub pbcross_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcross.MouseLeave
        If pilbidak <> TTTSymbol.Cross Then
            pbcross.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub pbcircle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcircle.Click
        pilbidak = TTTSymbol.Circle
        pbcross_MouseLeave(sender, e)
        pbcom_MouseLeave(sender, e)
        pbcircle_MouseLeave(sender, e)

    End Sub

    Private Sub pbcross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcross.Click
        pilbidak = TTTSymbol.Cross
        pbcircle_MouseLeave(sender, e)
        pbhuman_MouseLeave(sender, e)

        pbcross_MouseLeave(sender, e)
    End Sub

    Private Sub frmPopUpSimbol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pilbidak = TTTSymbol.NONE
    End Sub


    Private Sub pbhuman_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhuman.MouseHover
        pbhuman.BackColor = Color.Tan
    End Sub

    Private Sub pbcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pbcom_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcom.MouseHover

        pbcom.BackColor = Color.Tan
    End Sub

    Private Sub pbhuman_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhuman.MouseLeave
        If pilbidak <> TTTSymbol.User Then
            pbhuman.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub pbcom_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcom.MouseLeave
        If pilbidak <> TTTSymbol.Com Then
            pbcom.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub pbhuman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbhuman.Click
        pilbidak = TTTSymbol.User
        pbcom_MouseLeave(sender, e)
        pbcircle_MouseLeave(sender, e)
        pbcross_MouseLeave(sender, e)

    End Sub

    
    Private Sub pbcom_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcom.Click
        pilbidak = TTTSymbol.Com
        pbhuman_MouseLeave(sender, e)
        pbcircle_MouseLeave(sender, e)
        pbcross_MouseLeave(sender, e)
    End Sub
End Class