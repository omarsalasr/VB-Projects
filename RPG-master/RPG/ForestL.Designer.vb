<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForestL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForestL))
        Me.pctForestR = New System.Windows.Forms.PictureBox()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctEgg = New System.Windows.Forms.PictureBox()
        Me.pctGolem = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.tmrConversation = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMovePeople = New System.Windows.Forms.Timer(Me.components)
        Me.pctRock = New System.Windows.Forms.PictureBox()
        Me.pctLighter = New System.Windows.Forms.PictureBox()
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        Me.w5 = New System.Windows.Forms.PictureBox()
        CType(Me.pctForestR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEgg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGolem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLighter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctForestR
        '
        Me.pctForestR.BackColor = System.Drawing.Color.Black
        Me.pctForestR.Location = New System.Drawing.Point(967, 185)
        Me.pctForestR.Name = "pctForestR"
        Me.pctForestR.Size = New System.Drawing.Size(17, 141)
        Me.pctForestR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctForestR.TabIndex = 19
        Me.pctForestR.TabStop = False
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(1, 458)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 21
        '
        'pctEgg
        '
        Me.pctEgg.BackColor = System.Drawing.Color.Transparent
        Me.pctEgg.Image = CType(resources.GetObject("pctEgg.Image"), System.Drawing.Image)
        Me.pctEgg.Location = New System.Drawing.Point(137, 234)
        Me.pctEgg.Name = "pctEgg"
        Me.pctEgg.Size = New System.Drawing.Size(104, 116)
        Me.pctEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEgg.TabIndex = 22
        Me.pctEgg.TabStop = False
        '
        'pctGolem
        '
        Me.pctGolem.BackColor = System.Drawing.Color.Aqua
        Me.pctGolem.Image = CType(resources.GetObject("pctGolem.Image"), System.Drawing.Image)
        Me.pctGolem.Location = New System.Drawing.Point(360, 251)
        Me.pctGolem.Name = "pctGolem"
        Me.pctGolem.Size = New System.Drawing.Size(145, 126)
        Me.pctGolem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGolem.TabIndex = 23
        Me.pctGolem.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(658, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 459)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'tmrConversation
        '
        Me.tmrConversation.Enabled = True
        Me.tmrConversation.Interval = 2000
        '
        'tmrMovePeople
        '
        Me.tmrMovePeople.Interval = 10
        '
        'pctRock
        '
        Me.pctRock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctRock.Image = CType(resources.GetObject("pctRock.Image"), System.Drawing.Image)
        Me.pctRock.Location = New System.Drawing.Point(68, 398)
        Me.pctRock.Name = "pctRock"
        Me.pctRock.Size = New System.Drawing.Size(46, 40)
        Me.pctRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRock.TabIndex = 25
        Me.pctRock.TabStop = False
        '
        'pctLighter
        '
        Me.pctLighter.BackColor = System.Drawing.Color.Red
        Me.pctLighter.Location = New System.Drawing.Point(860, 216)
        Me.pctLighter.Name = "pctLighter"
        Me.pctLighter.Size = New System.Drawing.Size(26, 34)
        Me.pctLighter.TabIndex = 26
        Me.pctLighter.TabStop = False
        Me.pctLighter.Visible = False
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(886, 215)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(61, 95)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 27
        Me.mainChar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(983, 459)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(201, 97)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(624, 253)
        Me.lblEnd.TabIndex = 37
        Me.lblEnd.Text = "   GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You were eaten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    by Golem"
        Me.lblEnd.Visible = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(1, 458)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(983, 27)
        Me.w1.TabIndex = 38
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(1, -25)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(983, 27)
        Me.w2.TabIndex = 39
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(983, -1)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(26, 189)
        Me.w3.TabIndex = 40
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(983, 322)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(26, 137)
        Me.w4.TabIndex = 41
        Me.w4.TabStop = False
        '
        'w5
        '
        Me.w5.Location = New System.Drawing.Point(-25, 0)
        Me.w5.Name = "w5"
        Me.w5.Size = New System.Drawing.Size(26, 459)
        Me.w5.TabIndex = 42
        Me.w5.TabStop = False
        '
        'ForestL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w5)
        Me.Controls.Add(Me.w4)
        Me.Controls.Add(Me.w3)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.pctLighter)
        Me.Controls.Add(Me.pctForestR)
        Me.Controls.Add(Me.pctRock)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pctGolem)
        Me.Controls.Add(Me.pctEgg)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.w1)
        Me.Name = "ForestL"
        Me.Text = "ForestL"
        CType(Me.pctForestR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEgg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGolem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLighter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctForestR As System.Windows.Forms.PictureBox
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctEgg As System.Windows.Forms.PictureBox
    Friend WithEvents pctGolem As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrConversation As System.Windows.Forms.Timer
    Friend WithEvents tmrMovePeople As System.Windows.Forms.Timer
    Friend WithEvents pctRock As System.Windows.Forms.PictureBox
    Friend WithEvents pctLighter As System.Windows.Forms.PictureBox
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
    Friend WithEvents w5 As System.Windows.Forms.PictureBox
End Class
