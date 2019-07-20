<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.playArea = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.pctBall = New System.Windows.Forms.PictureBox()
        Me.pctPlayer4 = New System.Windows.Forms.PictureBox()
        Me.pctPlayer3 = New System.Windows.Forms.PictureBox()
        Me.pctPlayer2 = New System.Windows.Forms.PictureBox()
        Me.pctPlayer1 = New System.Windows.Forms.PictureBox()
        Me.tmrMoveBall = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrPaddle = New System.Windows.Forms.Timer(Me.components)
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.lblScore4 = New System.Windows.Forms.Label()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.playArea.SuspendLayout()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'playArea
        '
        Me.playArea.BackColor = System.Drawing.Color.Black
        Me.playArea.Controls.Add(Me.Label4)
        Me.playArea.Controls.Add(Me.Label3)
        Me.playArea.Controls.Add(Me.Label2)
        Me.playArea.Controls.Add(Me.Label1)
        Me.playArea.Controls.Add(Me.lblRules)
        Me.playArea.Controls.Add(Me.lblControl)
        Me.playArea.Controls.Add(Me.pctBall)
        Me.playArea.Controls.Add(Me.pctPlayer4)
        Me.playArea.Controls.Add(Me.pctPlayer3)
        Me.playArea.Controls.Add(Me.pctPlayer2)
        Me.playArea.Controls.Add(Me.pctPlayer1)
        Me.playArea.Location = New System.Drawing.Point(12, 45)
        Me.playArea.Name = "playArea"
        Me.playArea.Size = New System.Drawing.Size(821, 595)
        Me.playArea.TabIndex = 0
        Me.playArea.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(403, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(779, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "1"
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.White
        Me.lblRules.Location = New System.Drawing.Point(436, 158)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(333, 200)
        Me.lblRules.TabIndex = 5
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        '
        'lblControl
        '
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.ForeColor = System.Drawing.Color.White
        Me.lblControl.Location = New System.Drawing.Point(73, 125)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(314, 340)
        Me.lblControl.TabIndex = 4
        Me.lblControl.Text = resources.GetString("lblControl.Text")
        '
        'pctBall
        '
        Me.pctBall.Image = CType(resources.GetObject("pctBall.Image"), System.Drawing.Image)
        Me.pctBall.Location = New System.Drawing.Point(402, 278)
        Me.pctBall.Name = "pctBall"
        Me.pctBall.Size = New System.Drawing.Size(30, 29)
        Me.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBall.TabIndex = 2
        Me.pctBall.TabStop = False
        '
        'pctPlayer4
        '
        Me.pctPlayer4.BackColor = System.Drawing.Color.White
        Me.pctPlayer4.Location = New System.Drawing.Point(343, 549)
        Me.pctPlayer4.Name = "pctPlayer4"
        Me.pctPlayer4.Size = New System.Drawing.Size(148, 29)
        Me.pctPlayer4.TabIndex = 1
        Me.pctPlayer4.TabStop = False
        '
        'pctPlayer3
        '
        Me.pctPlayer3.BackColor = System.Drawing.Color.White
        Me.pctPlayer3.Location = New System.Drawing.Point(343, 18)
        Me.pctPlayer3.Name = "pctPlayer3"
        Me.pctPlayer3.Size = New System.Drawing.Size(148, 29)
        Me.pctPlayer3.TabIndex = 1
        Me.pctPlayer3.TabStop = False
        '
        'pctPlayer2
        '
        Me.pctPlayer2.BackColor = System.Drawing.Color.White
        Me.pctPlayer2.Location = New System.Drawing.Point(775, 225)
        Me.pctPlayer2.Name = "pctPlayer2"
        Me.pctPlayer2.Size = New System.Drawing.Size(29, 148)
        Me.pctPlayer2.TabIndex = 1
        Me.pctPlayer2.TabStop = False
        '
        'pctPlayer1
        '
        Me.pctPlayer1.BackColor = System.Drawing.Color.White
        Me.pctPlayer1.Location = New System.Drawing.Point(15, 225)
        Me.pctPlayer1.Name = "pctPlayer1"
        Me.pctPlayer1.Size = New System.Drawing.Size(29, 148)
        Me.pctPlayer1.TabIndex = 1
        Me.pctPlayer1.TabStop = False
        '
        'tmrMoveBall
        '
        Me.tmrMoveBall.Interval = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1133, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.MainScreenToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game/Reset"
        '
        'MainScreenToolStripMenuItem
        '
        Me.MainScreenToolStripMenuItem.Name = "MainScreenToolStripMenuItem"
        Me.MainScreenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MainScreenToolStripMenuItem.Text = "Main Screen"
        '
        'tmrPaddle
        '
        Me.tmrPaddle.Interval = 10
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(1005, 112)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(66, 25)
        Me.lblNum1.TabIndex = 8
        Me.lblNum1.Text = "         "
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(935, 112)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(74, 25)
        Me.lblScore1.TabIndex = 7
        Me.lblScore1.Text = "Score:"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(934, 63)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer1.TabIndex = 6
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(1005, 249)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(66, 25)
        Me.lblNum2.TabIndex = 11
        Me.lblNum2.Text = "         "
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(935, 249)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(74, 25)
        Me.lblScore2.TabIndex = 10
        Me.lblScore2.Text = "Score:"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(934, 203)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer2.TabIndex = 9
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(1005, 393)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(66, 25)
        Me.lblNum3.TabIndex = 14
        Me.lblNum3.Text = "         "
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore3.Location = New System.Drawing.Point(935, 393)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(74, 25)
        Me.lblScore3.TabIndex = 13
        Me.lblScore3.Text = "Score:"
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer3.Location = New System.Drawing.Point(934, 347)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer3.TabIndex = 12
        Me.lblPlayer3.Text = "Player 3"
        '
        'lblNum4
        '
        Me.lblNum4.AutoSize = True
        Me.lblNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum4.Location = New System.Drawing.Point(1005, 542)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(66, 25)
        Me.lblNum4.TabIndex = 17
        Me.lblNum4.Text = "         "
        '
        'lblScore4
        '
        Me.lblScore4.AutoSize = True
        Me.lblScore4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore4.Location = New System.Drawing.Point(935, 542)
        Me.lblScore4.Name = "lblScore4"
        Me.lblScore4.Size = New System.Drawing.Size(74, 25)
        Me.lblScore4.TabIndex = 16
        Me.lblScore4.Text = "Score:"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer4.Location = New System.Drawing.Point(934, 493)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer4.TabIndex = 15
        Me.lblPlayer4.Text = "Player 4"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 652)
        Me.Controls.Add(Me.lblNum4)
        Me.Controls.Add(Me.lblScore4)
        Me.Controls.Add(Me.lblPlayer4)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblPlayer3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.playArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Form4"
        Me.playArea.ResumeLayout(False)
        Me.playArea.PerformLayout()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playArea As System.Windows.Forms.GroupBox
    Friend WithEvents pctPlayer4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctBall As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMoveBall As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrPaddle As System.Windows.Forms.Timer
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents lblScore3 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3 As System.Windows.Forms.Label
    Friend WithEvents lblNum4 As System.Windows.Forms.Label
    Friend WithEvents lblScore4 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4 As System.Windows.Forms.Label
    Friend WithEvents lblRules As System.Windows.Forms.Label
    Friend WithEvents lblControl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
