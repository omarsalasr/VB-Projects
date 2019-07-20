<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.pctwShop = New System.Windows.Forms.PictureBox()
        Me.lblLvl = New System.Windows.Forms.Label()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblAttack = New System.Windows.Forms.Label()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.lblExpPotions = New System.Windows.Forms.Label()
        Me.lblHPotions = New System.Windows.Forms.Label()
        Me.btnHPotion = New System.Windows.Forms.Button()
        Me.btnExpPotion = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.battleArena = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.playArea = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctwShop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.battleArena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.playArea.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainChar
        '
        Me.mainChar.Location = New System.Drawing.Point(422, 250)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(63, 61)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 0
        Me.mainChar.TabStop = False
        '
        'pctwShop
        '
        Me.pctwShop.BackColor = System.Drawing.Color.Blue
        Me.pctwShop.Image = CType(resources.GetObject("pctwShop.Image"), System.Drawing.Image)
        Me.pctwShop.Location = New System.Drawing.Point(32, 63)
        Me.pctwShop.Name = "pctwShop"
        Me.pctwShop.Size = New System.Drawing.Size(289, 151)
        Me.pctwShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctwShop.TabIndex = 1
        Me.pctwShop.TabStop = False
        '
        'lblLvl
        '
        Me.lblLvl.AutoSize = True
        Me.lblLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLvl.Location = New System.Drawing.Point(14, 439)
        Me.lblLvl.Name = "lblLvl"
        Me.lblLvl.Size = New System.Drawing.Size(46, 25)
        Me.lblLvl.TabIndex = 3
        Me.lblLvl.Text = "Lvl:"
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.Location = New System.Drawing.Point(168, 439)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(55, 25)
        Me.lblExp.TabIndex = 3
        Me.lblExp.Text = "Exp:"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(338, 499)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(80, 25)
        Me.lblHealth.TabIndex = 3
        Me.lblHealth.Text = "Health:"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(14, 396)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(141, 25)
        Me.lblPlayerName.TabIndex = 3
        Me.lblPlayerName.Text = "Player Name:"
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttack.Location = New System.Drawing.Point(14, 499)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(78, 25)
        Me.lblAttack.TabIndex = 3
        Me.lblAttack.Text = "Attack:"
        '
        'lblDef
        '
        Me.lblDef.AutoSize = True
        Me.lblDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDef.Location = New System.Drawing.Point(165, 499)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(98, 25)
        Me.lblDef.TabIndex = 3
        Me.lblDef.Text = "Defense:"
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGold.Location = New System.Drawing.Point(338, 439)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(63, 25)
        Me.lblGold.TabIndex = 3
        Me.lblGold.Text = "Gold:"
        '
        'lblExpPotions
        '
        Me.lblExpPotions.AutoSize = True
        Me.lblExpPotions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpPotions.Location = New System.Drawing.Point(531, 499)
        Me.lblExpPotions.Name = "lblExpPotions"
        Me.lblExpPotions.Size = New System.Drawing.Size(133, 25)
        Me.lblExpPotions.TabIndex = 4
        Me.lblExpPotions.Text = "Exp Potions:"
        '
        'lblHPotions
        '
        Me.lblHPotions.AutoSize = True
        Me.lblHPotions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPotions.Location = New System.Drawing.Point(531, 439)
        Me.lblHPotions.Name = "lblHPotions"
        Me.lblHPotions.Size = New System.Drawing.Size(158, 25)
        Me.lblHPotions.TabIndex = 5
        Me.lblHPotions.Text = "Health Potions:"
        '
        'btnHPotion
        '
        Me.btnHPotion.Location = New System.Drawing.Point(536, 467)
        Me.btnHPotion.Name = "btnHPotion"
        Me.btnHPotion.Size = New System.Drawing.Size(75, 23)
        Me.btnHPotion.TabIndex = 6
        Me.btnHPotion.Text = "Use Potion"
        Me.btnHPotion.UseVisualStyleBackColor = True
        '
        'btnExpPotion
        '
        Me.btnExpPotion.Location = New System.Drawing.Point(536, 527)
        Me.btnExpPotion.Name = "btnExpPotion"
        Me.btnExpPotion.Size = New System.Drawing.Size(75, 23)
        Me.btnExpPotion.TabIndex = 6
        Me.btnExpPotion.Text = "Use Potion"
        Me.btnExpPotion.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "hero 1.png")
        Me.ImageList1.Images.SetKeyName(1, "hero 2.png")
        Me.ImageList1.Images.SetKeyName(2, "images.jpg")
        '
        'battleArena
        '
        Me.battleArena.Image = CType(resources.GetObject("battleArena.Image"), System.Drawing.Image)
        Me.battleArena.Location = New System.Drawing.Point(541, 63)
        Me.battleArena.Name = "battleArena"
        Me.battleArena.Size = New System.Drawing.Size(322, 151)
        Me.battleArena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.battleArena.TabIndex = 8
        Me.battleArena.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'playArea
        '
        Me.playArea.Controls.Add(Me.Label2)
        Me.playArea.Controls.Add(Me.Label1)
        Me.playArea.Controls.Add(Me.battleArena)
        Me.playArea.Controls.Add(Me.pctwShop)
        Me.playArea.Location = New System.Drawing.Point(13, 13)
        Me.playArea.Name = "playArea"
        Me.playArea.Size = New System.Drawing.Size(890, 369)
        Me.playArea.TabIndex = 9
        Me.playArea.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(642, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 45)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Arena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Shop"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 556)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.btnExpPotion)
        Me.Controls.Add(Me.btnHPotion)
        Me.Controls.Add(Me.lblExpPotions)
        Me.Controls.Add(Me.lblHPotions)
        Me.Controls.Add(Me.lblDef)
        Me.Controls.Add(Me.lblAttack)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.lblExp)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblLvl)
        Me.Controls.Add(Me.playArea)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctwShop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.battleArena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.playArea.ResumeLayout(False)
        Me.playArea.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents pctwShop As System.Windows.Forms.PictureBox
    Friend WithEvents lblLvl As System.Windows.Forms.Label
    Friend WithEvents lblExp As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblAttack As System.Windows.Forms.Label
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents lblGold As System.Windows.Forms.Label
    Friend WithEvents lblExpPotions As System.Windows.Forms.Label
    Friend WithEvents lblHPotions As System.Windows.Forms.Label
    Friend WithEvents btnHPotion As System.Windows.Forms.Button
    Friend WithEvents btnExpPotion As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents battleArena As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents playArea As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
