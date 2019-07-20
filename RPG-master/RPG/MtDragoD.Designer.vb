<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MtDragoD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MtDragoD))
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctMtDrago = New System.Windows.Forms.PictureBox()
        Me.pctDragon = New System.Windows.Forms.PictureBox()
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pctSword = New System.Windows.Forms.PictureBox()
        Me.btnSmash = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.pctEgg = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        Me.w5 = New System.Windows.Forms.PictureBox()
        CType(Me.pctMtDrago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEgg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(0, 456)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 12
        '
        'pctMtDrago
        '
        Me.pctMtDrago.BackColor = System.Drawing.Color.Black
        Me.pctMtDrago.Location = New System.Drawing.Point(443, 440)
        Me.pctMtDrago.Name = "pctMtDrago"
        Me.pctMtDrago.Size = New System.Drawing.Size(141, 17)
        Me.pctMtDrago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMtDrago.TabIndex = 17
        Me.pctMtDrago.TabStop = False
        '
        'pctDragon
        '
        Me.pctDragon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctDragon.Image = CType(resources.GetObject("pctDragon.Image"), System.Drawing.Image)
        Me.pctDragon.Location = New System.Drawing.Point(306, 89)
        Me.pctDragon.Name = "pctDragon"
        Me.pctDragon.Size = New System.Drawing.Size(396, 241)
        Me.pctDragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDragon.TabIndex = 18
        Me.pctDragon.TabStop = False
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 2000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(306, 23)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(396, 38)
        Me.ProgressBar1.TabIndex = 19
        Me.ProgressBar1.Visible = False
        '
        'pctSword
        '
        Me.pctSword.BackColor = System.Drawing.Color.Red
        Me.pctSword.Image = CType(resources.GetObject("pctSword.Image"), System.Drawing.Image)
        Me.pctSword.Location = New System.Drawing.Point(530, 360)
        Me.pctSword.Name = "pctSword"
        Me.pctSword.Size = New System.Drawing.Size(158, 34)
        Me.pctSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSword.TabIndex = 20
        Me.pctSword.TabStop = False
        Me.pctSword.Visible = False
        '
        'btnSmash
        '
        Me.btnSmash.Enabled = False
        Me.btnSmash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSmash.Location = New System.Drawing.Point(71, 146)
        Me.btnSmash.Name = "btnSmash"
        Me.btnSmash.Size = New System.Drawing.Size(144, 113)
        Me.btnSmash.TabIndex = 21
        Me.btnSmash.Text = "Hit Me!!"
        Me.btnSmash.UseVisualStyleBackColor = True
        Me.btnSmash.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(477, 339)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(61, 95)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 24
        Me.mainChar.TabStop = False
        '
        'pctEgg
        '
        Me.pctEgg.BackColor = System.Drawing.Color.Transparent
        Me.pctEgg.Image = CType(resources.GetObject("pctEgg.Image"), System.Drawing.Image)
        Me.pctEgg.Location = New System.Drawing.Point(855, 23)
        Me.pctEgg.Name = "pctEgg"
        Me.pctEgg.Size = New System.Drawing.Size(104, 116)
        Me.pctEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEgg.TabIndex = 25
        Me.pctEgg.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(463, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(983, 458)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "sword.PNG")
        '
        'PictureBox5
        '
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(351, 104)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(312, 229)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(279, 77)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(442, 253)
        Me.lblEnd.TabIndex = 42
        Me.lblEnd.Text = " GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Dragon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "burnt you"
        Me.lblEnd.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(404, 333)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(214, 101)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(0, 455)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(444, 25)
        Me.w1.TabIndex = 51
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(583, 453)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(402, 25)
        Me.w2.TabIndex = 52
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(-18, -1)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(20, 458)
        Me.w3.TabIndex = 53
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(0, -16)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(983, 18)
        Me.w4.TabIndex = 54
        Me.w4.TabStop = False
        '
        'w5
        '
        Me.w5.Location = New System.Drawing.Point(982, -1)
        Me.w5.Name = "w5"
        Me.w5.Size = New System.Drawing.Size(20, 458)
        Me.w5.TabIndex = 55
        Me.w5.TabStop = False
        '
        'MtDragoD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w5)
        Me.Controls.Add(Me.w4)
        Me.Controls.Add(Me.w3)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctEgg)
        Me.Controls.Add(Me.pctSword)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.btnSmash)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pctDragon)
        Me.Controls.Add(Me.pctMtDrago)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.w2)
        Me.Name = "MtDragoD"
        Me.Text = "MtDragoD"
        CType(Me.pctMtDrago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEgg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctMtDrago As System.Windows.Forms.PictureBox
    Friend WithEvents pctDragon As System.Windows.Forms.PictureBox
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pctSword As System.Windows.Forms.PictureBox
    Friend WithEvents btnSmash As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents pctEgg As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
    Friend WithEvents w5 As System.Windows.Forms.PictureBox
End Class
