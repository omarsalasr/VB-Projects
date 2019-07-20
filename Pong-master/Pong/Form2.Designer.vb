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
        Me.playArea = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.pctBall = New System.Windows.Forms.PictureBox()
        Me.pctPlayer2 = New System.Windows.Forms.PictureBox()
        Me.pctPlayer1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrMoveBall = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovePaddle = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.playArea.SuspendLayout()
        CType(Me.pctBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'playArea
        '
        Me.playArea.BackColor = System.Drawing.Color.Black
        Me.playArea.Controls.Add(Me.Label2)
        Me.playArea.Controls.Add(Me.Label3)
        Me.playArea.Controls.Add(Me.lblRules)
        Me.playArea.Controls.Add(Me.lblControl)
        Me.playArea.Controls.Add(Me.pctBall)
        Me.playArea.Controls.Add(Me.pctPlayer2)
        Me.playArea.Controls.Add(Me.pctPlayer1)
        Me.playArea.Location = New System.Drawing.Point(12, 149)
        Me.playArea.Name = "playArea"
        Me.playArea.Size = New System.Drawing.Size(923, 475)
        Me.playArea.TabIndex = 0
        Me.playArea.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(880, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "1"
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.White
        Me.lblRules.Location = New System.Drawing.Point(522, 161)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(285, 160)
        Me.lblRules.TabIndex = 3
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        '
        'lblControl
        '
        Me.lblControl.AutoSize = True
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.ForeColor = System.Drawing.Color.White
        Me.lblControl.Location = New System.Drawing.Point(125, 174)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(279, 120)
        Me.lblControl.TabIndex = 2
        Me.lblControl.Text = "Player 1 Controls:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Press the W key to move up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Press the S key to " & _
    "move down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Player 2 Controls:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     -Press the Up arrow key to move up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     -Pr" & _
    "ess the Down arrow key to "
        '
        'pctBall
        '
        Me.pctBall.Image = CType(resources.GetObject("pctBall.Image"), System.Drawing.Image)
        Me.pctBall.Location = New System.Drawing.Point(450, 220)
        Me.pctBall.Name = "pctBall"
        Me.pctBall.Size = New System.Drawing.Size(30, 29)
        Me.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBall.TabIndex = 1
        Me.pctBall.TabStop = False
        '
        'pctPlayer2
        '
        Me.pctPlayer2.BackColor = System.Drawing.Color.White
        Me.pctPlayer2.Location = New System.Drawing.Point(877, 161)
        Me.pctPlayer2.Name = "pctPlayer2"
        Me.pctPlayer2.Size = New System.Drawing.Size(29, 148)
        Me.pctPlayer2.TabIndex = 0
        Me.pctPlayer2.TabStop = False
        '
        'pctPlayer1
        '
        Me.pctPlayer1.BackColor = System.Drawing.Color.White
        Me.pctPlayer1.Location = New System.Drawing.Point(19, 161)
        Me.pctPlayer1.Name = "pctPlayer1"
        Me.pctPlayer1.Size = New System.Drawing.Size(29, 148)
        Me.pctPlayer1.TabIndex = 0
        Me.pctPlayer1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
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
        'tmrMoveBall
        '
        Me.tmrMoveBall.Interval = 15
        '
        'tmrMovePaddle
        '
        Me.tmrMovePaddle.Interval = 10
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(98, 24)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(631, 24)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(122, 33)
        Me.lblPlayer2.TabIndex = 2
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(99, 73)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(74, 25)
        Me.lblScore1.TabIndex = 3
        Me.lblScore1.Text = "Score:"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(632, 73)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(74, 25)
        Me.lblScore2.TabIndex = 3
        Me.lblScore2.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(355, 67)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(70, 31)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "        "
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(169, 73)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(66, 25)
        Me.lblNum1.TabIndex = 5
        Me.lblNum1.Text = "         "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(703, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "         "
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(702, 73)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(66, 25)
        Me.lblNum2.TabIndex = 6
        Me.lblNum2.Text = "         "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 636)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.playArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Pong 1v1"
        Me.playArea.ResumeLayout(false)
        Me.playArea.PerformLayout
        CType(Me.pctBall,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctPlayer2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctPlayer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents playArea As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrMoveBall As System.Windows.Forms.Timer
    Friend WithEvents pctBall As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMovePaddle As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblRules As System.Windows.Forms.Label
    Friend WithEvents lblControl As System.Windows.Forms.Label
    Friend WithEvents MainScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
