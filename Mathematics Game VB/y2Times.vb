Public Class y2Times
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        y2Home.Show()
        Me.Hide()
    End Sub
    Dim total As Double = 0.0

    Public Function GetDivisor(n As Integer) As Integer
        Dim random2 As New Random
        Dim txt3 As Integer() = New Integer() {}
        For i As Integer = 1 To n
            If n Mod i = 0 Then
                ReDim Preserve txt3(txt3.Length)
                txt3(txt3.Length - 1) = i
            End If
        Next
        Return txt3(random2.Next(0, txt3.Length - 1))
    End Function

    Public Sub GenerateSum()
        Showing()
        lblDisplay.Hide()
        btnGo.Hide()
        lblYN.Text = (" ")
        lblCorrection.Text = (" ")
        btnSkip.Text = ("Skip")
        btnSubmit.Text = ("Submit Answer")
        lblPlus.Text = ("×")
        txtboxAnswer.Clear()
        Dim random1 As New Random
        Dim num1 = random1.Next(1, 40)
        Dim num0 = GetDivisor(num1)
        lblRan1.Text = num0
        lblTotal.Text = num1
        total = num1 / num0
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
        lblTotal.Hide()
        lblYN.Hide()
        lblCorrection.Hide()
        lblAmount.Hide()
        pbBack.Hide()
        txtboxAnswer.Hide()
    End Sub
    Public Sub Showing()
        lblYour.Show()
        lblOut.Show()
        lblQR.Show()
        lblEqual.Show()
        lblScore.Show()
        btnSkip.Show()
        lblRan1.Show()
        lblTotal.Show()
        lblPlus.Show()
        lblYN.Show()
        lblCorrection.Show()
        pbBack.Show()
        txtboxAnswer.Show()
    End Sub
    Private Sub Submit()
        If Not btnSubmit.Text = Nothing Then
            If btnSubmit.Text = ("Play Again") Then
                GenerateSum()
                Showing()
                lblAmount.Text = 0
                lblDisplay.Text = 0
                lblScore.Text = 0
                lblQR.Text = 1
            End If
        End If
        If Not txtboxAnswer.Text = Nothing Then
            If txtboxAnswer.Text = total Then
                lblYN.ForeColor = Color.Lime
                lblYN.Text = ("✔")
                btnSkip.Text = ("Next")
                Sounding()
                lblScore.Text = lblScore.Text + 1
                lblDisplay.Text = lblDisplay.Text + 1
                lblAmount.Text = lblAmount.Text + 1
                lblQR.Text = lblQR.Text + 1
            Else
                lblYN.ForeColor = Color.Red
                lblYN.Text = ("✘")
                btnSkip.Text = ("Next")
                lblCorrection.Text = total
                lblAmount.Text = lblAmount.Text + 1
                lblQR.Text = lblQR.Text + 1
            End If
        End If
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Submit()
    End Sub

    Private Sub y2Times_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQR.Text = 1
        OnlyTen()
        GenerateSum()
    End Sub
    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        If Not lblAmount.Text = Nothing Then
            If lblAmount.Text = 10 Then
                Hidden()
                btnSubmit.Text = ("Play Again")
                btnSkip.Text = ("Go to Home")
                lblQR.Text = ("Well Done Your Score is: ")
                lblDisplay.Show()
                lblQR.Show()
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
                lblQR.Text = 1
            End If
        End If
    End Sub
    Private Sub y2Times_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnSubmit_Click(sender, e) 'or cmdExit.PerformClick()
        End If
        If e.KeyCode = Keys.Right Then
            e.Handled = True
            btnSkip_Click(sender, e) 'or cmdExit.PerformClick()
        End If
    End Sub
    Sub Sounding()
        My.Computer.Audio.Play("C:\Users\s16023\source\repos\Assignment no lock\Buzzer.mp3",
            AudioPlayMode.WaitToComplete)
    End Sub
End Class