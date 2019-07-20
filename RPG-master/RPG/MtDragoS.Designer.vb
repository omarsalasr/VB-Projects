<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MtDragoS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MtDragoS))
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pctMtDrago = New System.Windows.Forms.PictureBox()
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctSword = New System.Windows.Forms.PictureBox()
        Me.pctSwordHolder = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.w5 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w1 = New System.Windows.Forms.PictureBox()
        CType(Me.pctMtDrago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSwordHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(0, 458)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 12
        '
        'pctMtDrago
        '
        Me.pctMtDrago.BackColor = System.Drawing.Color.Black
        Me.pctMtDrago.Location = New System.Drawing.Point(505, 0)
        Me.pctMtDrago.Name = "pctMtDrago"
        Me.pctMtDrago.Size = New System.Drawing.Size(141, 17)
        Me.pctMtDrago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMtDrago.TabIndex = 17
        Me.pctMtDrago.TabStop = False
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 2000
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(523, 34)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(92, 140)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 20
        Me.mainChar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(132, 239)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 39)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'pctSword
        '
        Me.pctSword.BackColor = System.Drawing.Color.Transparent
        Me.pctSword.Image = CType(resources.GetObject("pctSword.Image"), System.Drawing.Image)
        Me.pctSword.Location = New System.Drawing.Point(162, 121)
        Me.pctSword.Name = "pctSword"
        Me.pctSword.Size = New System.Drawing.Size(48, 154)
        Me.pctSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSword.TabIndex = 34
        Me.pctSword.TabStop = False
        '
        'pctSwordHolder
        '
        Me.pctSwordHolder.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pctSwordHolder.Location = New System.Drawing.Point(132, 217)
        Me.pctSwordHolder.Name = "pctSwordHolder"
        Me.pctSwordHolder.Size = New System.Drawing.Size(107, 61)
        Me.pctSwordHolder.TabIndex = 33
        Me.pctSwordHolder.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(983, 462)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'w5
        '
        Me.w5.Location = New System.Drawing.Point(981, 0)
        Me.w5.Name = "w5"
        Me.w5.Size = New System.Drawing.Size(20, 458)
        Me.w5.TabIndex = 56
        Me.w5.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(-17, 0)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(20, 458)
        Me.w4.TabIndex = 57
        Me.w4.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(0, 456)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(983, 28)
        Me.w3.TabIndex = 58
        Me.w3.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(5, -15)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(498, 17)
        Me.w2.TabIndex = 59
        Me.w2.TabStop = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(647, -15)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(331, 17)
        Me.w1.TabIndex = 60
        Me.w1.TabStop = False
        '
        'MtDragoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.w4)
        Me.Controls.Add(Me.w5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctSword)
        Me.Controls.Add(Me.pctSwordHolder)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.pctMtDrago)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.w3)
        Me.Name = "MtDragoS"
        Me.Text = "MtDragoS"
        CType(Me.pctMtDrago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSwordHolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents pctMtDrago As System.Windows.Forms.PictureBox
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctSword As System.Windows.Forms.PictureBox
    Friend WithEvents pctSwordHolder As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents w5 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
End Class
