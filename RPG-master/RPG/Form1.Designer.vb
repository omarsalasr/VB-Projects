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
        Me.pctDoor = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrConversation = New System.Windows.Forms.Timer(Me.components)
        Me.pctRope = New System.Windows.Forms.PictureBox()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctAkats = New System.Windows.Forms.PictureBox()
        Me.pctKing = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.pctDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAkats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctDoor
        '
        Me.pctDoor.BackColor = System.Drawing.Color.Black
        Me.pctDoor.Location = New System.Drawing.Point(495, 452)
        Me.pctDoor.Name = "pctDoor"
        Me.pctDoor.Size = New System.Drawing.Size(141, 17)
        Me.pctDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDoor.TabIndex = 0
        Me.pctDoor.TabStop = False
        Me.pctDoor.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'tmrConversation
        '
        Me.tmrConversation.Enabled = True
        Me.tmrConversation.Interval = 3000
        '
        'pctRope
        '
        Me.pctRope.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctRope.Location = New System.Drawing.Point(554, 224)
        Me.pctRope.Name = "pctRope"
        Me.pctRope.Size = New System.Drawing.Size(13, 103)
        Me.pctRope.TabIndex = 5
        Me.pctRope.TabStop = False
        Me.pctRope.Visible = False
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
        Me.txtMessages.TabIndex = 4
        '
        'pctAkats
        '
        Me.pctAkats.BackColor = System.Drawing.Color.Transparent
        Me.pctAkats.Image = CType(resources.GetObject("pctAkats.Image"), System.Drawing.Image)
        Me.pctAkats.Location = New System.Drawing.Point(516, 469)
        Me.pctAkats.Name = "pctAkats"
        Me.pctAkats.Size = New System.Drawing.Size(100, 118)
        Me.pctAkats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAkats.TabIndex = 25
        Me.pctAkats.TabStop = False
        '
        'pctKing
        '
        Me.pctKing.BackColor = System.Drawing.Color.Transparent
        Me.pctKing.Image = CType(resources.GetObject("pctKing.Image"), System.Drawing.Image)
        Me.pctKing.Location = New System.Drawing.Point(504, 151)
        Me.pctKing.Name = "pctKing"
        Me.pctKing.Size = New System.Drawing.Size(107, 96)
        Me.pctKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctKing.TabIndex = 26
        Me.pctKing.TabStop = False
        Me.pctKing.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(532, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 12)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblStart
        '
        Me.lblStart.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(106, 94)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(780, 172)
        Me.lblStart.TabIndex = 28
        Me.lblStart.Text = "Click here to start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  the adventure"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(457, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(203, 220)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(983, 463)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(457, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 175)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(410, 72)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(312, 229)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 40
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctDoor)
        Me.Controls.Add(Me.pctRope)
        Me.Controls.Add(Me.pctKing)
        Me.Controls.Add(Me.pctAkats)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        CType(Me.pctDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAkats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctKing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents pctDoor As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrConversation As System.Windows.Forms.Timer
    Friend WithEvents pctRope As System.Windows.Forms.PictureBox
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctAkats As System.Windows.Forms.PictureBox
    Friend WithEvents pctKing As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox

End Class
