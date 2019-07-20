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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblScoreW2 = New System.Windows.Forms.Label()
        Me.lblScoreC2 = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stage1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txbResponse = New System.Windows.Forms.TextBox()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrAnswer = New System.Windows.Forms.Timer(Me.components)
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = true
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitle.Location = New System.Drawing.Point(169, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(338, 39)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Random Math Game"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = true
        Me.lblWrong.Font = New System.Drawing.Font("Lucida Bright", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblWrong.Location = New System.Drawing.Point(571, 76)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(90, 28)
        Me.lblWrong.TabIndex = 5
        Me.lblWrong.Text = "Wrong"
        Me.lblWrong.Visible = false
        '
        'lblScoreW2
        '
        Me.lblScoreW2.AutoSize = true
        Me.lblScoreW2.Font = New System.Drawing.Font("Lucida Bright", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblScoreW2.Location = New System.Drawing.Point(610, 123)
        Me.lblScoreW2.Name = "lblScoreW2"
        Me.lblScoreW2.Size = New System.Drawing.Size(0, 28)
        Me.lblScoreW2.TabIndex = 6
        '
        'lblScoreC2
        '
        Me.lblScoreC2.AutoSize = true
        Me.lblScoreC2.Font = New System.Drawing.Font("Lucida Bright", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblScoreC2.Location = New System.Drawing.Point(390, 123)
        Me.lblScoreC2.Name = "lblScoreC2"
        Me.lblScoreC2.Size = New System.Drawing.Size(0, 28)
        Me.lblScoreC2.TabIndex = 7
        '
        'lblRight
        '
        Me.lblRight.AutoSize = true
        Me.lblRight.Font = New System.Drawing.Font("Lucida Bright", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRight.Location = New System.Drawing.Point(350, 76)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(97, 28)
        Me.lblRight.TabIndex = 8
        Me.lblRight.Text = "Correct"
        Me.lblRight.Visible = false
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = true
        Me.lblPlayer2.Font = New System.Drawing.Font("Lucida Bright", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(35, 76)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(164, 28)
        Me.lblPlayer2.TabIndex = 4
        Me.lblPlayer2.Text = "Player Name:"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPlayer2.Visible = false
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.Stage1ToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'Stage1ToolStripMenuItem
        '
        Me.Stage1ToolStripMenuItem.Name = "Stage1ToolStripMenuItem"
        Me.Stage1ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.Stage1ToolStripMenuItem.Text = "Stage 1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txbResponse
        '
        Me.txbResponse.Location = New System.Drawing.Point(290, 242)
        Me.txbResponse.Name = "txbResponse"
        Me.txbResponse.Size = New System.Drawing.Size(100, 20)
        Me.txbResponse.TabIndex = 0
        Me.txbResponse.Visible = False
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblem.Location = New System.Drawing.Point(33, 227)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(34, 37)
        Me.lblProblem.TabIndex = 11
        Me.lblProblem.Text = "?"
        Me.lblProblem.Visible = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(507, 227)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 42)
        Me.lblAnswer.TabIndex = 12
        Me.lblAnswer.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(314, 165)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 33)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "60"
        Me.lblTime.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(662, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "3"
        Me.Label1.Visible = False
        '
        'tmrAnswer
        '
        '
        'btnEasy
        '
        Me.btnEasy.Location = New System.Drawing.Point(157, 163)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(95, 50)
        Me.btnEasy.TabIndex = 15
        Me.btnEasy.Text = "Easy"
        Me.btnEasy.UseVisualStyleBackColor = True
        Me.btnEasy.Visible = False
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(295, 163)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(95, 50)
        Me.btnMedium.TabIndex = 16
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        Me.btnMedium.Visible = False
        '
        'btnHard
        '
        Me.btnHard.Location = New System.Drawing.Point(430, 163)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(95, 50)
        Me.btnHard.TabIndex = 17
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = True
        Me.btnHard.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 42)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Choose your difficulty"
        Me.Label2.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Blue
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(12, 24)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(110, 20)
        Me.lblStart.TabIndex = 19
        Me.lblStart.Text = "^ Click to Start"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 322)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.txbResponse)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblScoreW2)
        Me.Controls.Add(Me.lblScoreC2)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Stage 2"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents lblScoreW2 As System.Windows.Forms.Label
    Friend WithEvents lblScoreC2 As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txbResponse As System.Windows.Forms.TextBox
    Friend WithEvents lblProblem As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrAnswer As System.Windows.Forms.Timer
    Friend WithEvents Stage1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEasy As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents btnHard As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
