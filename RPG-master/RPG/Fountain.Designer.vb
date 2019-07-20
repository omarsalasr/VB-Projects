<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fountain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fountain))
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctPerson2 = New System.Windows.Forms.PictureBox()
        Me.pctOutsideCastle = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctPerson4 = New System.Windows.Forms.PictureBox()
        Me.pctGMem1 = New System.Windows.Forms.PictureBox()
        Me.pctPerson3 = New System.Windows.Forms.PictureBox()
        Me.pctPerson1 = New System.Windows.Forms.PictureBox()
        Me.pctGMem2 = New System.Windows.Forms.PictureBox()
        Me.tmrMovePeople = New System.Windows.Forms.Timer(Me.components)
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.pctHiddenPerson = New System.Windows.Forms.PictureBox()
        Me.pctShopG = New System.Windows.Forms.PictureBox()
        Me.pctHillGuy = New System.Windows.Forms.PictureBox()
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        CType(Me.pctPerson2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOutsideCastle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPerson4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGMem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPerson3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGMem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHiddenPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctShopG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHillGuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(1, 461)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 11
        '
        'pctPerson2
        '
        Me.pctPerson2.BackColor = System.Drawing.Color.Transparent
        Me.pctPerson2.Image = CType(resources.GetObject("pctPerson2.Image"), System.Drawing.Image)
        Me.pctPerson2.Location = New System.Drawing.Point(100, 55)
        Me.pctPerson2.Name = "pctPerson2"
        Me.pctPerson2.Size = New System.Drawing.Size(95, 102)
        Me.pctPerson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPerson2.TabIndex = 12
        Me.pctPerson2.TabStop = False
        '
        'pctOutsideCastle
        '
        Me.pctOutsideCastle.BackColor = System.Drawing.Color.Black
        Me.pctOutsideCastle.Location = New System.Drawing.Point(0, 298)
        Me.pctOutsideCastle.Name = "pctOutsideCastle"
        Me.pctOutsideCastle.Size = New System.Drawing.Size(17, 141)
        Me.pctOutsideCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctOutsideCastle.TabIndex = 15
        Me.pctOutsideCastle.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Blue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'pctPerson4
        '
        Me.pctPerson4.BackColor = System.Drawing.Color.Transparent
        Me.pctPerson4.Image = CType(resources.GetObject("pctPerson4.Image"), System.Drawing.Image)
        Me.pctPerson4.Location = New System.Drawing.Point(462, 20)
        Me.pctPerson4.Name = "pctPerson4"
        Me.pctPerson4.Size = New System.Drawing.Size(84, 87)
        Me.pctPerson4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPerson4.TabIndex = 17
        Me.pctPerson4.TabStop = False
        '
        'pctGMem1
        '
        Me.pctGMem1.BackColor = System.Drawing.Color.Transparent
        Me.pctGMem1.Image = CType(resources.GetObject("pctGMem1.Image"), System.Drawing.Image)
        Me.pctGMem1.Location = New System.Drawing.Point(706, 309)
        Me.pctGMem1.Name = "pctGMem1"
        Me.pctGMem1.Size = New System.Drawing.Size(92, 110)
        Me.pctGMem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGMem1.TabIndex = 18
        Me.pctGMem1.TabStop = False
        '
        'pctPerson3
        '
        Me.pctPerson3.BackColor = System.Drawing.Color.Transparent
        Me.pctPerson3.Image = CType(resources.GetObject("pctPerson3.Image"), System.Drawing.Image)
        Me.pctPerson3.Location = New System.Drawing.Point(716, 68)
        Me.pctPerson3.Name = "pctPerson3"
        Me.pctPerson3.Size = New System.Drawing.Size(82, 115)
        Me.pctPerson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPerson3.TabIndex = 19
        Me.pctPerson3.TabStop = False
        '
        'pctPerson1
        '
        Me.pctPerson1.BackColor = System.Drawing.Color.Transparent
        Me.pctPerson1.Image = CType(resources.GetObject("pctPerson1.Image"), System.Drawing.Image)
        Me.pctPerson1.Location = New System.Drawing.Point(231, 178)
        Me.pctPerson1.Name = "pctPerson1"
        Me.pctPerson1.Size = New System.Drawing.Size(102, 131)
        Me.pctPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPerson1.TabIndex = 20
        Me.pctPerson1.TabStop = False
        '
        'pctGMem2
        '
        Me.pctGMem2.BackColor = System.Drawing.Color.Transparent
        Me.pctGMem2.Image = CType(resources.GetObject("pctGMem2.Image"), System.Drawing.Image)
        Me.pctGMem2.Location = New System.Drawing.Point(804, 309)
        Me.pctGMem2.Name = "pctGMem2"
        Me.pctGMem2.Size = New System.Drawing.Size(92, 110)
        Me.pctGMem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGMem2.TabIndex = 21
        Me.pctGMem2.TabStop = False
        '
        'tmrMovePeople
        '
        Me.tmrMovePeople.Enabled = True
        Me.tmrMovePeople.Interval = 10
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 2000
        '
        'pctHiddenPerson
        '
        Me.pctHiddenPerson.BackColor = System.Drawing.Color.Red
        Me.pctHiddenPerson.Image = CType(resources.GetObject("pctHiddenPerson.Image"), System.Drawing.Image)
        Me.pctHiddenPerson.Location = New System.Drawing.Point(502, 190)
        Me.pctHiddenPerson.Name = "pctHiddenPerson"
        Me.pctHiddenPerson.Size = New System.Drawing.Size(84, 87)
        Me.pctHiddenPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHiddenPerson.TabIndex = 23
        Me.pctHiddenPerson.TabStop = False
        Me.pctHiddenPerson.Visible = False
        '
        'pctShopG
        '
        Me.pctShopG.BackColor = System.Drawing.Color.Transparent
        Me.pctShopG.Enabled = False
        Me.pctShopG.Image = CType(resources.GetObject("pctShopG.Image"), System.Drawing.Image)
        Me.pctShopG.Location = New System.Drawing.Point(517, 324)
        Me.pctShopG.Name = "pctShopG"
        Me.pctShopG.Size = New System.Drawing.Size(84, 87)
        Me.pctShopG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctShopG.TabIndex = 24
        Me.pctShopG.TabStop = False
        Me.pctShopG.Visible = False
        '
        'pctHillGuy
        '
        Me.pctHillGuy.BackColor = System.Drawing.Color.Red
        Me.pctHillGuy.Enabled = False
        Me.pctHillGuy.Image = CType(resources.GetObject("pctHillGuy.Image"), System.Drawing.Image)
        Me.pctHillGuy.Location = New System.Drawing.Point(393, 324)
        Me.pctHillGuy.Name = "pctHillGuy"
        Me.pctHillGuy.Size = New System.Drawing.Size(84, 87)
        Me.pctHillGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHillGuy.TabIndex = 25
        Me.pctHillGuy.TabStop = False
        Me.pctHillGuy.Visible = False
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(40, 324)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(61, 95)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 26
        Me.mainChar.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "shrek run.jpg")
        Me.ImageList1.Images.SetKeyName(1, "hillbilly - Copy.JPG")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(984, 466)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(122, 128)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(757, 253)
        Me.lblEnd.TabIndex = 40
        Me.lblEnd.Text = "     GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Hillbilly told" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Vermel about you"
        Me.lblEnd.Visible = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(985, -1)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(24, 466)
        Me.w1.TabIndex = 41
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(-23, 0)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(24, 298)
        Me.w2.TabIndex = 42
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(1, -24)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(983, 25)
        Me.w3.TabIndex = 43
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(1, 461)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(983, 25)
        Me.w4.TabIndex = 44
        Me.w4.TabStop = False
        '
        'Fountain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w3)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.pctOutsideCastle)
        Me.Controls.Add(Me.pctHillGuy)
        Me.Controls.Add(Me.pctShopG)
        Me.Controls.Add(Me.pctHiddenPerson)
        Me.Controls.Add(Me.pctGMem2)
        Me.Controls.Add(Me.pctPerson1)
        Me.Controls.Add(Me.pctPerson3)
        Me.Controls.Add(Me.pctGMem1)
        Me.Controls.Add(Me.pctPerson4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctPerson2)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.w4)
        Me.Name = "Fountain"
        Me.Text = "Form4"
        CType(Me.pctPerson2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOutsideCastle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPerson4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGMem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPerson3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPerson1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGMem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHiddenPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctShopG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHillGuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctPerson2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctOutsideCastle As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPerson4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctGMem1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPerson3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPerson1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctGMem2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMovePeople As System.Windows.Forms.Timer
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents pctHiddenPerson As System.Windows.Forms.PictureBox
    Friend WithEvents pctShopG As System.Windows.Forms.PictureBox
    Friend WithEvents pctHillGuy As System.Windows.Forms.PictureBox
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
End Class
