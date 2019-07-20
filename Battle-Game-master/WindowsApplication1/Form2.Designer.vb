<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.enemys = New System.Windows.Forms.PictureBox()
        Me.btnBattle = New System.Windows.Forms.Button()
        Me.Herolvl = New System.Windows.Forms.Label()
        Me.HeroAttack = New System.Windows.Forms.Label()
        Me.HeroDef = New System.Windows.Forms.Label()
        Me.enemyLvl = New System.Windows.Forms.Label()
        Me.enemyAttack = New System.Windows.Forms.Label()
        Me.enemyDef = New System.Windows.Forms.Label()
        Me.HeroHp = New System.Windows.Forms.Label()
        Me.enemyHp = New System.Windows.Forms.Label()
        Me.btnMainForm = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblLoot = New System.Windows.Forms.Label()
        CType(Me.mainChar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.enemys,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'mainChar
        '
        Me.mainChar.Location = New System.Drawing.Point(74, 41)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(201, 186)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 0
        Me.mainChar.TabStop = false
        '
        'enemys
        '
        Me.enemys.BackColor = System.Drawing.Color.Transparent
        Me.enemys.Location = New System.Drawing.Point(568, 42)
        Me.enemys.Name = "enemys"
        Me.enemys.Size = New System.Drawing.Size(201, 186)
        Me.enemys.TabIndex = 0
        Me.enemys.TabStop = false
        '
        'btnBattle
        '
        Me.btnBattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnBattle.Location = New System.Drawing.Point(362, 111)
        Me.btnBattle.Name = "btnBattle"
        Me.btnBattle.Size = New System.Drawing.Size(101, 47)
        Me.btnBattle.TabIndex = 1
        Me.btnBattle.Text = "Battle!!!!"
        Me.btnBattle.UseVisualStyleBackColor = true
        '
        'Herolvl
        '
        Me.Herolvl.AutoSize = true
        Me.Herolvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Herolvl.Location = New System.Drawing.Point(28, 264)
        Me.Herolvl.Name = "Herolvl"
        Me.Herolvl.Size = New System.Drawing.Size(66, 24)
        Me.Herolvl.TabIndex = 2
        Me.Herolvl.Text = "Label1"
        '
        'HeroAttack
        '
        Me.HeroAttack.AutoSize = true
        Me.HeroAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HeroAttack.Location = New System.Drawing.Point(28, 325)
        Me.HeroAttack.Name = "HeroAttack"
        Me.HeroAttack.Size = New System.Drawing.Size(66, 24)
        Me.HeroAttack.TabIndex = 2
        Me.HeroAttack.Text = "Label1"
        '
        'HeroDef
        '
        Me.HeroDef.AutoSize = true
        Me.HeroDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HeroDef.Location = New System.Drawing.Point(185, 325)
        Me.HeroDef.Name = "HeroDef"
        Me.HeroDef.Size = New System.Drawing.Size(66, 24)
        Me.HeroDef.TabIndex = 2
        Me.HeroDef.Text = "Label1"
        '
        'enemyLvl
        '
        Me.enemyLvl.AutoSize = true
        Me.enemyLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.enemyLvl.Location = New System.Drawing.Point(541, 264)
        Me.enemyLvl.Name = "enemyLvl"
        Me.enemyLvl.Size = New System.Drawing.Size(66, 24)
        Me.enemyLvl.TabIndex = 2
        Me.enemyLvl.Text = "Label1"
        '
        'enemyAttack
        '
        Me.enemyAttack.AutoSize = true
        Me.enemyAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.enemyAttack.Location = New System.Drawing.Point(541, 325)
        Me.enemyAttack.Name = "enemyAttack"
        Me.enemyAttack.Size = New System.Drawing.Size(66, 24)
        Me.enemyAttack.TabIndex = 2
        Me.enemyAttack.Text = "Label1"
        '
        'enemyDef
        '
        Me.enemyDef.AutoSize = true
        Me.enemyDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.enemyDef.Location = New System.Drawing.Point(703, 325)
        Me.enemyDef.Name = "enemyDef"
        Me.enemyDef.Size = New System.Drawing.Size(66, 24)
        Me.enemyDef.TabIndex = 2
        Me.enemyDef.Text = "Label1"
        '
        'HeroHp
        '
        Me.HeroHp.AutoSize = true
        Me.HeroHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HeroHp.Location = New System.Drawing.Point(185, 264)
        Me.HeroHp.Name = "HeroHp"
        Me.HeroHp.Size = New System.Drawing.Size(66, 24)
        Me.HeroHp.TabIndex = 2
        Me.HeroHp.Text = "Label1"
        '
        'enemyHp
        '
        Me.enemyHp.AutoSize = true
        Me.enemyHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.enemyHp.Location = New System.Drawing.Point(703, 264)
        Me.enemyHp.Name = "enemyHp"
        Me.enemyHp.Size = New System.Drawing.Size(66, 24)
        Me.enemyHp.TabIndex = 2
        Me.enemyHp.Text = "Label1"
        '
        'btnMainForm
        '
        Me.btnMainForm.Location = New System.Drawing.Point(379, 385)
        Me.btnMainForm.Name = "btnMainForm"
        Me.btnMainForm.Size = New System.Drawing.Size(75, 23)
        Me.btnMainForm.TabIndex = 1
        Me.btnMainForm.Text = "Back"
        Me.btnMainForm.UseVisualStyleBackColor = true
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Chrysanthemum.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Desert.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Hydrangeas.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Jellyfish.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Koala.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Lighthouse.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Penguins.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Tulips.jpg")
        Me.ImageList1.Images.SetKeyName(8, "3 headed dog.jpg")
        Me.ImageList1.Images.SetKeyName(9, "9 tailed fox.jpg")
        Me.ImageList1.Images.SetKeyName(10, "hero 1.png")
        Me.ImageList1.Images.SetKeyName(11, "hero 2.png")
        Me.ImageList1.Images.SetKeyName(12, "images.jpg")
        '
        'lblBack
        '
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBack.Location = New System.Drawing.Point(272, 420)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(292, 56)
        Me.lblBack.TabIndex = 2
        Me.lblBack.Text = "      "
        Me.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoot
        '
        Me.lblLoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLoot.Location = New System.Drawing.Point(302, 206)
        Me.lblLoot.Name = "lblLoot"
        Me.lblLoot.Size = New System.Drawing.Size(233, 160)
        Me.lblLoot.TabIndex = 2
        Me.lblLoot.Text = "      "
        Me.lblLoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 472)
        Me.Controls.Add(Me.enemyDef)
        Me.Controls.Add(Me.lblLoot)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.enemyHp)
        Me.Controls.Add(Me.HeroHp)
        Me.Controls.Add(Me.HeroDef)
        Me.Controls.Add(Me.enemyAttack)
        Me.Controls.Add(Me.enemyLvl)
        Me.Controls.Add(Me.HeroAttack)
        Me.Controls.Add(Me.Herolvl)
        Me.Controls.Add(Me.btnMainForm)
        Me.Controls.Add(Me.btnBattle)
        Me.Controls.Add(Me.enemys)
        Me.Controls.Add(Me.mainChar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.mainChar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.enemys,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents enemys As System.Windows.Forms.PictureBox
    Friend WithEvents btnBattle As System.Windows.Forms.Button
    Friend WithEvents Herolvl As System.Windows.Forms.Label
    Friend WithEvents HeroAttack As System.Windows.Forms.Label
    Friend WithEvents HeroDef As System.Windows.Forms.Label
    Friend WithEvents enemyLvl As System.Windows.Forms.Label
    Friend WithEvents enemyAttack As System.Windows.Forms.Label
    Friend WithEvents enemyDef As System.Windows.Forms.Label
    Friend WithEvents HeroHp As System.Windows.Forms.Label
    Friend WithEvents enemyHp As System.Windows.Forms.Label
    Friend WithEvents btnMainForm As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblLoot As System.Windows.Forms.Label
End Class
