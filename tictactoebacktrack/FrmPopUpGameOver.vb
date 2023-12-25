Public Class FrmPopUpGameOver
    Public Sub setMenang()
        SoundWin()
        lblStatus.Text = "Anda Menang"
        mystat.nwin += 1
    End Sub

    Public Sub setKalah()
        SoundLose()
        lblStatus.Text = "Anda Kalah"
        mystat.nloses += 1
    End Sub
    Public Sub setDraw()
        SoundDraw()
        lblStatus.Text = "---- Draw----"
        mystat.ndraw += 1
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub FrmPopUpGameOver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class