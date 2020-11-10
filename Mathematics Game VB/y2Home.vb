Public Class y2Home
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        y2Plus.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        y2Minus.Show()
        Me.Hide()
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        y2Times.Show()
        Me.Hide()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        y2Divide.Show()
        Me.Hide()
    End Sub
    Private Sub y2Home_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D1 Then
            e.Handled = True
            btnPlus_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.D2 Then
            e.Handled = True
            btnMinus_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.D3 Then
            e.Handled = True
            btnTimes_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.D4 Then
            e.Handled = True
            btnDivide_Click(sender, e) 'or cmdExit.PerformClick()
        End If
    End Sub
End Class