<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HQ))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCivMove = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.pctKing = New System.Windows.Forms.PictureBox()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(421, 440)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(1, 456)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 23
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 3000
        '
        'tmrCivMove
        '
        Me.tmrCivMove.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(912, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 378)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(345, 149)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(101, 140)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 29
        Me.mainChar.TabStop = False
        '
        'pctKing
        '
        Me.pctKing.BackColor = System.Drawing.Color.Transparent
        Me.pctKing.Image = CType(resources.GetObject("pctKing.Image"), System.Drawing.Image)
        Me.pctKing.Location = New System.Drawing.Point(496, 162)
        Me.pctKing.Name = "pctKing"
        Me.pctKing.Size = New System.Drawing.Size(118, 127)
        Me.pctKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctKing.TabIndex = 30
        Me.pctKing.TabStop = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.Black
        Me.p1.Location = New System.Drawing.Point(828, 199)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(65, 21)
        Me.p1.TabIndex = 34
        Me.p1.TabStop = False
        Me.p1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(983, 455)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(452, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(203, 220)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(1, 456)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(983, 25)
        Me.w1.TabIndex = 44
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(1, -22)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(983, 25)
        Me.w2.TabIndex = 45
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(-24, 1)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(26, 455)
        Me.w3.TabIndex = 46
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(912, 32)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(26, 378)
        Me.w4.TabIndex = 47
        Me.w4.TabStop = False
        '
        'HQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w3)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.pctKing)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.w4)
        Me.Name = "HQ"
        Me.Text = "HQ"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents tmrCivMove As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents pctKing As System.Windows.Forms.PictureBox
    Friend WithEvents p1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
End Class
