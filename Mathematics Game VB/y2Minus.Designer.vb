<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class y2Minus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(y2Minus))
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblCorrection = New System.Windows.Forms.Label()
        Me.lblYN = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtboxAnswer = New System.Windows.Forms.TextBox()
        Me.lblRan2 = New System.Windows.Forms.Label()
        Me.lblRan1 = New System.Windows.Forms.Label()
        Me.lblMinus = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lblYour = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBack
        '
        Me.pbBack.BackgroundImage = CType(resources.GetObject("pbBack.BackgroundImage"), System.Drawing.Image)
        Me.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Location = New System.Drawing.Point(12, 12)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(147, 130)
        Me.pbBack.TabIndex = 16
        Me.pbBack.TabStop = False
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.BackColor = System.Drawing.Color.White
        Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblEqual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEqual.Location = New System.Drawing.Point(481, 300)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(43, 46)
        Me.lblEqual.TabIndex = 70
        Me.lblEqual.Text = "="
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblResult.ForeColor = System.Drawing.Color.Blue
        Me.lblResult.Location = New System.Drawing.Point(337, 191)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(29, 46)
        Me.lblResult.TabIndex = 69
        Me.lblResult.Text = "i"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDisplay.Location = New System.Drawing.Point(550, 251)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(42, 46)
        Me.lblDisplay.TabIndex = 68
        Me.lblDisplay.Text = "0"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(640, 400)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(100, 53)
        Me.btnGo.TabIndex = 67
        Me.btnGo.Text = "Go to Home"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(203, 629)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(12, 20)
        Me.lblAmount.TabIndex = 66
        Me.lblAmount.Text = "l"
        '
        'lblCorrection
        '
        Me.lblCorrection.AutoSize = True
        Me.lblCorrection.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblCorrection.Location = New System.Drawing.Point(860, 198)
        Me.lblCorrection.Name = "lblCorrection"
        Me.lblCorrection.Size = New System.Drawing.Size(29, 46)
        Me.lblCorrection.TabIndex = 64
        Me.lblCorrection.Text = "l"
        '
        'lblYN
        '
        Me.lblYN.AutoSize = True
        Me.lblYN.BackColor = System.Drawing.Color.White
        Me.lblYN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblYN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYN.Location = New System.Drawing.Point(790, 198)
        Me.lblYN.Name = "lblYN"
        Me.lblYN.Size = New System.Drawing.Size(29, 46)
        Me.lblYN.TabIndex = 63
        Me.lblYN.Text = "l"
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(640, 400)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(100, 53)
        Me.btnSkip.TabIndex = 62
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(400, 400)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 53)
        Me.btnSubmit.TabIndex = 61
        Me.btnSubmit.Text = "Submit Answer"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtboxAnswer
        '
        Me.txtboxAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtboxAnswer.Location = New System.Drawing.Point(650, 191)
        Me.txtboxAnswer.Name = "txtboxAnswer"
        Me.txtboxAnswer.Size = New System.Drawing.Size(100, 53)
        Me.txtboxAnswer.TabIndex = 60
        '
        'lblRan2
        '
        Me.lblRan2.AutoSize = True
        Me.lblRan2.BackColor = System.Drawing.Color.White
        Me.lblRan2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRan2.Location = New System.Drawing.Point(547, 300)
        Me.lblRan2.Name = "lblRan2"
        Me.lblRan2.Size = New System.Drawing.Size(29, 46)
        Me.lblRan2.TabIndex = 59
        Me.lblRan2.Text = "l"
        '
        'lblRan1
        '
        Me.lblRan1.AutoSize = True
        Me.lblRan1.BackColor = System.Drawing.Color.White
        Me.lblRan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRan1.Location = New System.Drawing.Point(454, 191)
        Me.lblRan1.Name = "lblRan1"
        Me.lblRan1.Size = New System.Drawing.Size(29, 46)
        Me.lblRan1.TabIndex = 58
        Me.lblRan1.Text = "l"
        '
        'lblMinus
        '
        Me.lblMinus.AutoSize = True
        Me.lblMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblMinus.ForeColor = System.Drawing.Color.Black
        Me.lblMinus.Location = New System.Drawing.Point(554, 191)
        Me.lblMinus.Name = "lblMinus"
        Me.lblMinus.Size = New System.Drawing.Size(33, 46)
        Me.lblMinus.TabIndex = 57
        Me.lblMinus.Text = "-"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblOut.Location = New System.Drawing.Point(381, 589)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(67, 40)
        Me.lblOut.TabIndex = 76
        Me.lblOut.Text = "/10"
        '
        'lblYour
        '
        Me.lblYour.AutoSize = True
        Me.lblYour.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblYour.Location = New System.Drawing.Point(98, 589)
        Me.lblYour.Name = "lblYour"
        Me.lblYour.Size = New System.Drawing.Size(242, 40)
        Me.lblYour.TabIndex = 75
        Me.lblYour.Text = "Your Score is:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblScore.Location = New System.Drawing.Point(347, 589)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(37, 40)
        Me.lblScore.TabIndex = 74
        Me.lblScore.Text = "0"
        '
        'y2Minus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.lblYour)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblCorrection)
        Me.Controls.Add(Me.lblYN)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtboxAnswer)
        Me.Controls.Add(Me.lblRan2)
        Me.Controls.Add(Me.lblRan1)
        Me.Controls.Add(Me.lblMinus)
        Me.Controls.Add(Me.pbBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "y2Minus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year 2 Subtraction Quiz"
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBack As PictureBox
    Friend WithEvents lblEqual As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblCorrection As Label
    Friend WithEvents lblYN As Label
    Friend WithEvents btnSkip As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtboxAnswer As TextBox
    Friend WithEvents lblRan2 As Label
    Friend WithEvents lblRan1 As Label
    Friend WithEvents lblMinus As Label
    Friend WithEvents lblOut As Label
    Friend WithEvents lblYour As Label
    Friend WithEvents lblScore As Label
End Class
