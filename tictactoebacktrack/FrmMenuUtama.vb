
Public Class FrmMenuUtama

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBtnPlay.Click

        SuaraKlik()

        frmPopUpLevel.ShowDialog()
        Me.Hide()


        FrmPlay.Show()
    End Sub

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gs.adasuara = True
        gs.pilbacksound = 0
    End Sub

    Private Sub pbtnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtnOptions.Click
        FrmOptions.ShowDialog()
    End Sub
End Class
