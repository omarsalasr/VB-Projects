<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chamber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chamber))
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctAkats = New System.Windows.Forms.PictureBox()
        Me.pctKing = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pctLine = New System.Windows.Forms.PictureBox()
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCivMove = New System.Windows.Forms.Timer(Me.components)
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        Me.w5 = New System.Windows.Forms.PictureBox()
        Me.w6 = New System.Windows.Forms.PictureBox()
        Me.w7 = New System.Windows.Forms.PictureBox()
        CType(Me.pctAkats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(0, 460)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 22
        '
        'pctAkats
        '
        Me.pctAkats.BackColor = System.Drawing.Color.Transparent
        Me.pctAkats.Image = CType(resources.GetObject("pctAkats.Image"), System.Drawing.Image)
        Me.pctAkats.Location = New System.Drawing.Point(44, 206)
        Me.pctAkats.Name = "pctAkats"
        Me.pctAkats.Size = New System.Drawing.Size(100, 118)
        Me.pctAkats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAkats.TabIndex = 24
        Me.pctAkats.TabStop = False
        '
        'pctKing
        '
        Me.pctKing.BackColor = System.Drawing.Color.Transparent
        Me.pctKing.Image = CType(resources.GetObject("pctKing.Image"), System.Drawing.Image)
        Me.pctKing.Location = New System.Drawing.Point(352, 19)
        Me.pctKing.Name = "pctKing"
        Me.pctKing.Size = New System.Drawing.Size(79, 65)
        Me.pctKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctKing.TabIndex = 25
        Me.pctKing.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(321, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 12)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(321, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 106)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(453, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 106)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(321, 104)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 106)
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'pctLine
        '
        Me.pctLine.BackColor = System.Drawing.Color.Transparent
        Me.pctLine.Location = New System.Drawing.Point(578, 4)
        Me.pctLine.Name = "pctLine"
        Me.pctLine.Size = New System.Drawing.Size(12, 454)
        Me.pctLine.TabIndex = 30
        Me.pctLine.TabStop = False
        Me.pctLine.Visible = False
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 2000
        '
        'tmrCivMove
        '
        Me.tmrCivMove.Interval = 10
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(846, 197)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(83, 107)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 31
        Me.mainChar.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pain.PNG")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(983, 458)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 32
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(44, 104)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(528, 304)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(181, 109)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(643, 253)
        Me.lblEnd.TabIndex = 40
        Me.lblEnd.Text = "   GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You were caught" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   by Vermel"
        Me.lblEnd.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(619, 148)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(82, 96)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 41
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(-37, 0)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(37, 457)
        Me.w1.TabIndex = 42
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(982, 0)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(37, 457)
        Me.w2.TabIndex = 43
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(0, 455)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(983, 33)
        Me.w3.TabIndex = 44
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(0, -31)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(983, 33)
        Me.w4.TabIndex = 45
        Me.w4.TabStop = False
        '
        'w5
        '
        Me.w5.Location = New System.Drawing.Point(452, 0)
        Me.w5.Name = "w5"
        Me.w5.Size = New System.Drawing.Size(12, 106)
        Me.w5.TabIndex = 46
        Me.w5.TabStop = False
        '
        'w6
        '
        Me.w6.Location = New System.Drawing.Point(321, 0)
        Me.w6.Name = "w6"
        Me.w6.Size = New System.Drawing.Size(12, 106)
        Me.w6.TabIndex = 47
        Me.w6.TabStop = False
        '
        'w7
        '
        Me.w7.Location = New System.Drawing.Point(331, 89)
        Me.w7.Name = "w7"
        Me.w7.Size = New System.Drawing.Size(121, 15)
        Me.w7.TabIndex = 48
        Me.w7.TabStop = False
        '
        'Chamber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w4)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.pctLine)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctAkats)
        Me.Controls.Add(Me.pctKing)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.w3)
        Me.Controls.Add(Me.w7)
        Me.Controls.Add(Me.w6)
        Me.Controls.Add(Me.w5)
        Me.Name = "Chamber"
        CType(Me.pctAkats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctAkats As System.Windows.Forms.PictureBox
    Friend WithEvents pctKing As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctLine As System.Windows.Forms.PictureBox
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents tmrCivMove As System.Windows.Forms.Timer
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
    Friend WithEvents w5 As System.Windows.Forms.PictureBox
    Friend WithEvents w6 As System.Windows.Forms.PictureBox
    Friend WithEvents w7 As System.Windows.Forms.PictureBox
End Class
