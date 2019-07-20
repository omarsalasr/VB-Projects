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
        Me.pctBackground = New System.Windows.Forms.PictureBox()
        Me.DragonRed = New System.Windows.Forms.PictureBox()
        Me.DragonGreen = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShootingGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpaceGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrMoveDragon = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctSpaceShip = New System.Windows.Forms.PictureBox()
        Me.tmrMoveShip = New System.Windows.Forms.Timer(Me.components)
        Me.pctBullet = New System.Windows.Forms.PictureBox()
        Me.tmrMoveBullet = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DragonRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DragonGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pctSpaceShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctBackground
        '
        Me.pctBackground.Image = CType(resources.GetObject("pctBackground.Image"), System.Drawing.Image)
        Me.pctBackground.Location = New System.Drawing.Point(-2, 27)
        Me.pctBackground.Name = "pctBackground"
        Me.pctBackground.Size = New System.Drawing.Size(1119, 571)
        Me.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBackground.TabIndex = 0
        Me.pctBackground.TabStop = False
        '
        'DragonRed
        '
        Me.DragonRed.Image = CType(resources.GetObject("DragonRed.Image"), System.Drawing.Image)
        Me.DragonRed.Location = New System.Drawing.Point(-103, 113)
        Me.DragonRed.Name = "DragonRed"
        Me.DragonRed.Size = New System.Drawing.Size(94, 71)
        Me.DragonRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DragonRed.TabIndex = 2
        Me.DragonRed.TabStop = False
        '
        'DragonGreen
        '
        Me.DragonGreen.Image = CType(resources.GetObject("DragonGreen.Image"), System.Drawing.Image)
        Me.DragonGreen.Location = New System.Drawing.Point(1131, 159)
        Me.DragonGreen.Name = "DragonGreen"
        Me.DragonGreen.Size = New System.Drawing.Size(94, 71)
        Me.DragonGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DragonGreen.TabIndex = 2
        Me.DragonGreen.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1117, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShootingGalleryToolStripMenuItem, Me.SpaceGameToolStripMenuItem})
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'ShootingGalleryToolStripMenuItem
        '
        Me.ShootingGalleryToolStripMenuItem.Name = "ShootingGalleryToolStripMenuItem"
        Me.ShootingGalleryToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ShootingGalleryToolStripMenuItem.Text = "Shooting Gallery"
        '
        'SpaceGameToolStripMenuItem
        '
        Me.SpaceGameToolStripMenuItem.Name = "SpaceGameToolStripMenuItem"
        Me.SpaceGameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SpaceGameToolStripMenuItem.Text = "Space Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tmrMoveDragon
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 137)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Click Here to Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(997, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "100"
        Me.Label1.Visible = False
        '
        'pctSpaceShip
        '
        Me.pctSpaceShip.BackColor = System.Drawing.Color.Black
        Me.pctSpaceShip.Image = CType(resources.GetObject("pctSpaceShip.Image"), System.Drawing.Image)
        Me.pctSpaceShip.Location = New System.Drawing.Point(495, 517)
        Me.pctSpaceShip.Name = "pctSpaceShip"
        Me.pctSpaceShip.Size = New System.Drawing.Size(100, 50)
        Me.pctSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSpaceShip.TabIndex = 6
        Me.pctSpaceShip.TabStop = False
        '
        'tmrMoveShip
        '
        Me.tmrMoveShip.Interval = 10
        '
        'pctBullet
        '
        Me.pctBullet.BackColor = System.Drawing.Color.Yellow
        Me.pctBullet.Location = New System.Drawing.Point(34, 456)
        Me.pctBullet.Name = "pctBullet"
        Me.pctBullet.Size = New System.Drawing.Size(15, 36)
        Me.pctBullet.TabIndex = 7
        Me.pctBullet.TabStop = False
        Me.pctBullet.Visible = False
        '
        'tmrMoveBullet
        '
        Me.tmrMoveBullet.Interval = 1
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(169, 615)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(20, 24)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1119, 10)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(25, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1119, 10)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 614)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Score:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1117, 650)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pctSpaceShip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DragonGreen)
        Me.Controls.Add(Me.DragonRed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pctBullet)
        Me.Controls.Add(Me.pctBackground)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DragonRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DragonGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.pctSpaceShip,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctBullet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pctBackground As System.Windows.Forms.PictureBox
    Friend WithEvents DragonRed As System.Windows.Forms.PictureBox
    Friend WithEvents DragonGreen As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShootingGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpaceGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrMoveDragon As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pctSpaceShip As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMoveShip As System.Windows.Forms.Timer
    Friend WithEvents pctBullet As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMoveBullet As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
