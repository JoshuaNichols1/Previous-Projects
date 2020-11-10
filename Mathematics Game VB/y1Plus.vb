Public Class y1Plus
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        y1home.Show()
        Me.Hide()
    End Sub
    Dim random0 As New Random
    Dim random1 As New Random
    Dim total As Double = 0.0

    Public Sub GenerateSum()
        Showing()
        lblDisplay.Hide()
        lblResult.Hide()
        btnGo.Hide()
        lblYN.Text = (" ")
        lblCorrection.Text = (" ")
        btnSkip.Text = ("Skip")
        btnSubmit.Text = ("Submit Answer")
        lblPlus.Text = ("+")
        txtboxAnswer.Clear()
        Dim num0 = random0.Next(1, 20)
        Dim num1 = random1.Next(0, 20)

        lblRan1.Text = num0
        lblRan2.Text = num1
        total = num0 + num1
    End Sub

    Public Sub OnlyTen()
        lblAmount.ForeColor = Color.White
        lblAmount.Text = 0
    End Sub

    Public Sub Hidden()
        lblYour.Hide()
        lblOut.Hide()
        lblEqual.Hide()
        lblScore.Hide()
        btnSkip.Hide()
        lblPlus.Hide()
        lblRan1.Hide()
        lblRan2.Hide()
        lblYN.Hide()
        lblCorrection.Hide()
        lblAmount.Hide()
        pbBack.Hide()
        txtboxAnswer.Hide()
    End Sub

    Public Sub Showing()
        lblYour.Show()
        lblOut.Show()
        lblEqual.Show()
        lblScore.Show()
        btnSkip.Show()
        lblRan1.Show()
        lblRan2.Show()
        lblPlus.Show()
        lblYN.Show()
        lblCorrection.Show()
        pbBack.Show()
        txtboxAnswer.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not btnSubmit.Text = Nothing Then
            If btnSubmit.Text = ("Play Again") Then
                GenerateSum()
                Showing()
                lblAmount.Text = 0
                lblDisplay.Text = 0
                lblScore.Text = 0
            End If
        End If
        If Not txtboxAnswer.Text = Nothing Then
            If txtboxAnswer.Text = total Then
                lblYN.ForeColor = Color.Lime
                lblYN.Text = ("✔")
                btnSkip.Text = ("Next")
                lblScore.Text = lblScore.Text + 1
                lblDisplay.Text = lblDisplay.Text + 1
                lblAmount.Text = lblAmount.Text + 1
            Else
                lblYN.ForeColor = Color.Red
                lblYN.Text = ("✘")
                btnSkip.Text = ("Next")
                lblCorrection.Text = total
                lblAmount.Text = lblAmount.Text + 1
            End If
        End If
    End Sub

    Private Sub y1Plus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OnlyTen()
        GenerateSum()
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        If Not lblAmount.Text = Nothing Then
            If lblAmount.Text = 10 Then
                Hidden()
                btnSubmit.Text = ("Play Again")
                btnSkip.Text = ("Go to Home")
                lblResult.Text = ("Well Done Your Score is: ")
                lblDisplay.Show()
                lblResult.Show()
                lblAmount.Text = 0
                btnGo.Show()
                btnSkip.Hide()
            Else
                GenerateSum()
            End If
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If Not btnSkip.Text = Nothing Then
            If btnSkip.Text = ("Go to Home") Then
                Me.Hide()
                y1home.Show()
                GenerateSum()
                lblScore.Text = 0
                lblAmount.Text = 0
                lblDisplay.Text = 0
            End If
        End If
    End Sub
    Private Sub y1Plus_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnSubmit_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.Right Then
            e.Handled = True
            btnSkip_Click(sender, e) 'or cmdExit.PerformClick()
        End If
    End Sub
End Class