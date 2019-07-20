<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.pctBack = New System.Windows.Forms.PictureBox()
        Me.pctPlayer = New System.Windows.Forms.PictureBox()
        Me.pctAI2 = New System.Windows.Forms.PictureBox()
        Me.pctAI1 = New System.Windows.Forms.PictureBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctBack
        '
        Me.pctBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctBack.Image = CType(resources.GetObject("pctBack.Image"), System.Drawing.Image)
        Me.pctBack.Location = New System.Drawing.Point(12, 547)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(136, 56)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 4
        Me.pctBack.TabStop = False
        '
        'pctPlayer
        '
        Me.pctPlayer.BackColor = System.Drawing.Color.White
        Me.pctPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctPlayer.Image = CType(resources.GetObject("pctPlayer.Image"), System.Drawing.Image)
        Me.pctPlayer.Location = New System.Drawing.Point(155, 404)
        Me.pctPlayer.Name = "pctPlayer"
        Me.pctPlayer.Size = New System.Drawing.Size(100, 111)
        Me.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPlayer.TabIndex = 6
        Me.pctPlayer.TabStop = False
        '
        'pctAI2
        '
        Me.pctAI2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctAI2.Image = CType(resources.GetObject("pctAI2.Image"), System.Drawing.Image)
        Me.pctAI2.Location = New System.Drawing.Point(468, 404)
        Me.pctAI2.Name = "pctAI2"
        Me.pctAI2.Size = New System.Drawing.Size(100, 111)
        Me.pctAI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAI2.TabIndex = 7
        Me.pctAI2.TabStop = False
        '
        'pctAI1
        '
        Me.pctAI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctAI1.Image = CType(resources.GetObject("pctAI1.Image"), System.Drawing.Image)
        Me.pctAI1.Location = New System.Drawing.Point(316, 404)
        Me.pctAI1.Name = "pctAI1"
        Me.pctAI1.Size = New System.Drawing.Size(100, 111)
        Me.pctAI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAI1.TabIndex = 8
        Me.pctAI1.TabStop = False
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClick.Enabled = False
        Me.btnClick.Location = New System.Drawing.Point(18, 437)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(99, 60)
        Me.btnClick.TabIndex = 9
        Me.btnClick.Text = "Click me to move the rocket"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 10
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(25, 343)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(103, 56)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "5"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(24, 284)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(104, 39)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Click to Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(230, 547)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 46)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Blast Off!"
        Me.lblTitle.Visible = False
        '
        'lblFinish
        '
        Me.lblFinish.BackColor = System.Drawing.Color.White
        Me.lblFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinish.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinish.Location = New System.Drawing.Point(155, 13)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(413, 42)
        Me.lblFinish.TabIndex = 13
        Me.lblFinish.Text = "Finish Line"
        Me.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Yellow
        Me.btnMain.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(468, 546)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(127, 56)
        Me.btnMain.TabIndex = 14
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 615)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lblFinish)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.pctAI1)
        Me.Controls.Add(Me.pctAI2)
        Me.Controls.Add(Me.pctPlayer)
        Me.Controls.Add(Me.pctBack)
        Me.Name = "Form4"
        Me.Text = "Level 3"
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctAI2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctAI1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents pctBack As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pctAI2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctAI1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFinish As System.Windows.Forms.Label
    Friend WithEvents btnMain As System.Windows.Forms.Button
End Class
