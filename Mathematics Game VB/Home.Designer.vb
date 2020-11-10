<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btnY1 = New System.Windows.Forms.Button()
        Me.btnY2 = New System.Windows.Forms.Button()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.lblChoose1 = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnY1
        '
        Me.btnY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnY1.Location = New System.Drawing.Point(300, 371)
        Me.btnY1.Name = "btnY1"
        Me.btnY1.Size = New System.Drawing.Size(180, 100)
        Me.btnY1.TabIndex = 4
        Me.btnY1.Text = "Year 1"
        Me.btnY1.UseVisualStyleBackColor = True
        '
        'btnY2
        '
        Me.btnY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnY2.Location = New System.Drawing.Point(700, 371)
        Me.btnY2.Name = "btnY2"
        Me.btnY2.Size = New System.Drawing.Size(180, 100)
        Me.btnY2.TabIndex = 5
        Me.btnY2.Text = "Year 2"
        Me.btnY2.UseVisualStyleBackColor = True
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblToday.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblToday.Location = New System.Drawing.Point(400, 191)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(402, 46)
        Me.lblToday.TabIndex = 7
        Me.lblToday.Text = "Start Learning Today!"
        '
        'lblChoose1
        '
        Me.lblChoose1.AutoSize = True
        Me.lblChoose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblChoose1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblChoose1.Location = New System.Drawing.Point(500, 275)
        Me.lblChoose1.Name = "lblChoose1"
        Me.lblChoose1.Size = New System.Drawing.Size(170, 46)
        Me.lblChoose1.TabIndex = 8
        Me.lblChoose1.Text = "Choose:"
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(12, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(147, 130)
        Me.pbLogo.TabIndex = 9
        Me.pbLogo.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.lblChoose1)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.btnY2)
        Me.Controls.Add(Me.btnY1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnY1 As Button
    Friend WithEvents btnY2 As Button
    Friend WithEvents lblToday As Label
    Friend WithEvents lblChoose1 As Label
    Friend WithEvents pbLogo As PictureBox
End Class
