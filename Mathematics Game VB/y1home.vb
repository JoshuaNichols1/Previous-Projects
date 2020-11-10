Public Class y1home
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        y1Plus.Show()
        Me.Hide()
    End Sub

    Private Sub btnY2_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        y1Minus.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub y1Home_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D1 Then
            e.Handled = True
            btn_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.D2 Then
            e.Handled = True
            btnY2_Click(sender, e) 'or cmdExit.PerformClick()
        End If
    End Sub
End Class