Public Class frmPopUpLevel
    Dim pil As GameLevel
    Private Sub pbtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtnSelect.Click
        mystat.level = pil
        SuaraKlik()
        Me.Close()
        frmPopUpSimbol.ShowDialog(FrmMenuUtama)
    End Sub
    Private Sub lbleasy_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleasy.MouseHover
        lblselect.Visible = True
    End Sub
    Private Sub lbleasy_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleasy.MouseLeave
        If pil <> GameLevel.EASY Then
            lblselect.Visible = False
        End If
    End Sub
    Private Sub frmPopUpLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pil = GameLevel.NONE
    End Sub

    Private Sub lblmedium_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmedium.MouseHover
        lblselect2.Visible = True
    End Sub

    Private Sub lblmedium_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmedium.MouseLeave
        If pil <> GameLevel.MEDIUM Then
            lblselect2.Visible = False
        End If
    End Sub

    Private Sub lblhard_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhard.MouseHover
        lblselecthard.Visible = True
    End Sub

    Private Sub lblhard_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhard.MouseLeave
        If pil <> GameLevel.HARD Then
            lblselecthard.Visible = False
        End If
    End Sub

    Private Sub lbleasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbleasy.Click
        pil = GameLevel.EASY
        lblmedium_MouseLeave(sender, e)
        lblhard_MouseLeave(sender, e)

    End Sub

    Private Sub lblmedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmedium.Click
        pil = GameLevel.MEDIUM
        lbleasy_MouseLeave(sender, e)
        lblhard_MouseLeave(sender, e)
    End Sub

    Private Sub lblhard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhard.Click
        pil = GameLevel.HARD
        lblmedium_MouseLeave(sender, e)
        lbleasy_MouseLeave(sender, e)
    End Sub

    Private Sub lblselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblselect.Click

    End Sub
End Class