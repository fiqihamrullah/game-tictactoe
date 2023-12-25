Public Class FrmOptions

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()

    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        gs.adasuara = chkAdaSuara.Checked
        gs.pilbacksound = cmblagubackground.SelectedIndex
        Me.Close()
    End Sub

    Private Sub FrmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkAdaSuara.Checked = gs.adasuara
        cmblagubackground.SelectedIndex = gs.pilbacksound
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        FrmAbout.ShowDialog()
    End Sub
End Class