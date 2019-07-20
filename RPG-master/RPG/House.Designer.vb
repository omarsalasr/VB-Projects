<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class House
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(House))
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.tmrConv = New System.Windows.Forms.Timer(Me.components)
        Me.pctDoor = New System.Windows.Forms.PictureBox()
        Me.pctStorage = New System.Windows.Forms.PictureBox()
        Me.pctTable = New System.Windows.Forms.PictureBox()
        Me.pctCounter = New System.Windows.Forms.PictureBox()
        Me.w1 = New System.Windows.Forms.PictureBox()
        Me.w2 = New System.Windows.Forms.PictureBox()
        Me.w3 = New System.Windows.Forms.PictureBox()
        Me.w4 = New System.Windows.Forms.PictureBox()
        Me.w5 = New System.Windows.Forms.PictureBox()
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainChar
        '
        Me.mainChar.BackColor = System.Drawing.Color.Transparent
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"), System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(50, 25)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(61, 95)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 1
        Me.mainChar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 212)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtMessages
        '
        Me.txtMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMessages.Enabled = False
        Me.txtMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(1, 457)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessages.Size = New System.Drawing.Size(983, 154)
        Me.txtMessages.TabIndex = 5
        '
        'tmrConv
        '
        Me.tmrConv.Enabled = True
        Me.tmrConv.Interval = 2000
        '
        'pctDoor
        '
        Me.pctDoor.BackColor = System.Drawing.Color.Black
        Me.pctDoor.Location = New System.Drawing.Point(967, 263)
        Me.pctDoor.Name = "pctDoor"
        Me.pctDoor.Size = New System.Drawing.Size(17, 141)
        Me.pctDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDoor.TabIndex = 8
        Me.pctDoor.TabStop = False
        '
        'pctStorage
        '
        Me.pctStorage.BackColor = System.Drawing.Color.Transparent
        Me.pctStorage.Image = CType(resources.GetObject("pctStorage.Image"), System.Drawing.Image)
        Me.pctStorage.Location = New System.Drawing.Point(13, 245)
        Me.pctStorage.Name = "pctStorage"
        Me.pctStorage.Size = New System.Drawing.Size(131, 77)
        Me.pctStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctStorage.TabIndex = 9
        Me.pctStorage.TabStop = False
        '
        'pctTable
        '
        Me.pctTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctTable.Location = New System.Drawing.Point(685, 84)
        Me.pctTable.Name = "pctTable"
        Me.pctTable.Size = New System.Drawing.Size(202, 102)
        Me.pctTable.TabIndex = 10
        Me.pctTable.TabStop = False
        '
        'pctCounter
        '
        Me.pctCounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctCounter.Location = New System.Drawing.Point(581, 3)
        Me.pctCounter.Name = "pctCounter"
        Me.pctCounter.Size = New System.Drawing.Size(403, 45)
        Me.pctCounter.TabIndex = 11
        Me.pctCounter.TabStop = False
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(-39, 0)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(37, 457)
        Me.w1.TabIndex = 12
        Me.w1.TabStop = False
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(983, 5)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(37, 249)
        Me.w2.TabIndex = 12
        Me.w2.TabStop = False
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(1, 457)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(983, 44)
        Me.w3.TabIndex = 12
        Me.w3.TabStop = False
        '
        'w4
        '
        Me.w4.Location = New System.Drawing.Point(2, -40)
        Me.w4.Name = "w4"
        Me.w4.Size = New System.Drawing.Size(983, 41)
        Me.w4.TabIndex = 12
        Me.w4.TabStop = False
        '
        'w5
        '
        Me.w5.Location = New System.Drawing.Point(983, 407)
        Me.w5.Name = "w5"
        Me.w5.Size = New System.Drawing.Size(37, 55)
        Me.w5.TabIndex = 12
        Me.w5.TabStop = False
        '
        'House
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.w4)
        Me.Controls.Add(Me.w5)
        Me.Controls.Add(Me.w2)
        Me.Controls.Add(Me.w1)
        Me.Controls.Add(Me.pctDoor)
        Me.Controls.Add(Me.mainChar)
        Me.Controls.Add(Me.pctCounter)
        Me.Controls.Add(Me.pctTable)
        Me.Controls.Add(Me.pctStorage)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.w3)
        Me.Name = "House"
        Me.Text = "Form2"
        CType(Me.mainChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.w5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMessages As System.Windows.Forms.TextBox
    Friend WithEvents tmrConv As System.Windows.Forms.Timer
    Friend WithEvents pctDoor As System.Windows.Forms.PictureBox
    Friend WithEvents pctStorage As System.Windows.Forms.PictureBox
    Friend WithEvents pctTable As System.Windows.Forms.PictureBox
    Friend WithEvents pctCounter As System.Windows.Forms.PictureBox
    Friend WithEvents w1 As System.Windows.Forms.PictureBox
    Friend WithEvents w2 As System.Windows.Forms.PictureBox
    Friend WithEvents w3 As System.Windows.Forms.PictureBox
    Friend WithEvents w4 As System.Windows.Forms.PictureBox
    Friend WithEvents w5 As System.Windows.Forms.PictureBox
End Class
