Public Class y2Divide
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
        lblQR.Hide()
        btnGo.Hide()
        lblYN.Text = (" ")
        lblCorrection.Text = (" ")
        btnSkip.Text = ("Skip")
        btnSubmit.Text = ("Submit Answer")
        lblDivide.Text = ("÷")
        txtboxAnswer.Clear()
        Dim random1 As New Random
        Dim num0 = random1.Next(1, 40)
        Dim num1 = GetDivisor(num0)
        lblRan1.Text = num0
        lblRan2.Text = num1
        total = num0 / num1
    End Sub
    'Dim random0 As New Random
    'Dim random1 As New Random
    'Dim total As Double = 0.0
    'Dim num2 As Double = 0.0
    'Dim num3 As Double = 0.0
    'Dim rnd1 As String() = New String() {1, 2, 4, 4, 6, 8, 9, 10, 12, 12, 14, 15, 16, 18, 18, 20, 20, 21, 21, 22, 24, 24, 25, 26, 27, 27, 28, 28, 30, 30}
    'Dim rnd2 As String() = New String() {0, 1, 2, 1, 2, 4, 3, 2, 3, 2, 2, 3, 2, 6, 9, 5, 10, 3, 0, 11, 2, 6, 5, 2, 9, 0, 4, 2, 3, 2}

    'Public Sub GenerateSum()
    '    Showing()
    '    lblDisplay.Hide()
    '    lblResult.Hide()
    '    btnGo.Hide()
    '    lblYN.Text = (" ")
    '    lblCorrection.Text = (" ")
    '    btnSkip.Text = ("Skip")
    '    btnSubmit.Text = ("Submit Answer")
    '    lblDivide.Text = ("÷")
    '    txtboxAnswer.Clear()
    '    Dim num0 = random0.Next(0, 30)
    '    Dim num1 = random1.Next(0, 30)

    '    num2 = rnd1(num0)
    '    num3 = rnd2(num1)
    '    lblRan1.Text = num2
    '    lblRan2.Text = num3
    '    total = num2 / num3
    'End Sub

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
        lblDivide.Hide()
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
        lblDivide.Show()
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

    Private Sub y2Divide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            End If
        End If
    End Sub
    Private Sub y2Divide_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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