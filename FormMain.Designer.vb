Namespace VideoHandle
    Partial Class FormMain
        Private components As System.ComponentModel.IContainer = Nothing


        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.btnPlayLoop = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnPlayLoop
            '
            Me.btnPlayLoop.Location = New System.Drawing.Point(30, 23)
            Me.btnPlayLoop.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.btnPlayLoop.Name = "btnPlayLoop"
            Me.btnPlayLoop.Size = New System.Drawing.Size(150, 44)
            Me.btnPlayLoop.TabIndex = 5
            Me.btnPlayLoop.Text = "Play Video"
            Me.btnPlayLoop.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(30, 79)
            Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(150, 44)
            Me.Button1.TabIndex = 11
            Me.Button1.Text = "Change Handle"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(30, 135)
            Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(508, 31)
            Me.TextBox1.TabIndex = 12
            Me.TextBox1.Text = "window media-player handle "
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Black
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(574, 23)
            Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(374, 360)
            Me.PictureBox1.TabIndex = 13
            Me.PictureBox1.TabStop = False
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(192, 23)
            Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(346, 31)
            Me.TextBox2.TabIndex = 14
            Me.TextBox2.Text = "C:\DosGames\Tesseract.mp4"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(568, 412)
            Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(189, 25)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "handle picturebox:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(762, 412)
            Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(0, 25)
            Me.Label2.TabIndex = 16
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(30, 185)
            Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(236, 44)
            Me.Button2.TabIndex = 17
            Me.Button2.Text = "Resize to 188;188"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(74, 312)
            Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(62, 25)
            Me.Label3.TabIndex = 18
            Me.Label3.Text = "width"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(74, 363)
            Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(71, 25)
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "height"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(74, 412)
            Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 25)
            Me.Label5.TabIndex = 21
            Me.Label5.Text = "origin size"
            '
            'FormMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(972, 475)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.btnPlayLoop)
            Me.Controls.Add(Me.PictureBox1)
            Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Fun with Video"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents btnPlayLoop As System.Windows.Forms.Button
        Private WithEvents Button1 As Button
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Private WithEvents Button2 As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label5 As Label
    End Class
End Namespace