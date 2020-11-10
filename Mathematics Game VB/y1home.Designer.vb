<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class y1home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(y1home))
        Me.lblChoose2 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChoose2
        '
        Me.lblChoose2.AutoSize = True
        Me.lblChoose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblChoose2.Location = New System.Drawing.Point(500, 191)
        Me.lblChoose2.Name = "lblChoose2"
        Me.lblChoose2.Size = New System.Drawing.Size(170, 46)
        Me.lblChoose2.TabIndex = 9
        Me.lblChoose2.Text = "Choose:"
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(700, 371)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(180, 100)
        Me.btnMinus.TabIndex = 11
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(300, 371)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(180, 100)
        Me.btnPlus.TabIndex = 10
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'pbBack
        '
        Me.pbBack.BackgroundImage = CType(resources.GetObject("pbBack.BackgroundImage"), System.Drawing.Image)
        Me.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Location = New System.Drawing.Point(12, 12)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(147, 130)
        Me.pbBack.TabIndex = 13
        Me.pbBack.TabStop = False
        '
        'y1home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblChoose2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "y1home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year 1 Home"
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChoose2 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents pbBack As PictureBox
End Class
