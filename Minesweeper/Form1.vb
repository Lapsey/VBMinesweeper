Public Class frmMinesweeper
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        frmGame.Show()
    End Sub

    Private Sub btnPlay_MouseEnter(sender As Object, e As EventArgs) Handles btnPlay.MouseEnter
        btnPlay.BackColor = Color.Green
        btnPlay.ForeColor = Color.White
    End Sub

    Private Sub btnPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        btnPlay.BackColor = Color.LightGray
        btnPlay.ForeColor = Color.Black
    End Sub
End Class
