<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class y2Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(y2Home))
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(700, 371)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(180, 100)
        Me.btnMinus.TabIndex = 14
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(300, 371)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(180, 100)
        Me.btnPlus.TabIndex = 13
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(505, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 46)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Choose:"
        '
        'btnTimes
        '
        Me.btnTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(300, 586)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(180, 100)
        Me.btnTimes.TabIndex = 15
        Me.btnTimes.Text = "×"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'pbBack
        '
        Me.pbBack.BackgroundImage = CType(resources.GetObject("pbBack.BackgroundImage"), System.Drawing.Image)
        Me.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Location = New System.Drawing.Point(12, 12)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(147, 130)
        Me.pbBack.TabIndex = 17
        Me.pbBack.TabStop = False
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(709, 586)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(180, 100)
        Me.btnDivide.TabIndex = 18
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'y2Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "y2Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year 2 Home"
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTimes As Button
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents btnDivide As Button
End Class
