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
        Me.pctHereRight = New System.Windows.Forms.PictureBox()
        Me.pctWaterfall = New System.Windows.Forms.PictureBox()
        Me.pctRiver = New System.Windows.Forms.PictureBox()
        Me.pctHouse = New System.Windows.Forms.PictureBox()
        Me.pctHeli = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctHereUp = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctForest = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctHereRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctWaterfall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRiver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHereUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctForest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctHereRight
        '
        Me.pctHereRight.Image = Global.Text_Game.My.Resources.Resources.Here_right
        Me.pctHereRight.Location = New System.Drawing.Point(123, 349)
        Me.pctHereRight.Name = "pctHereRight"
        Me.pctHereRight.Size = New System.Drawing.Size(146, 42)
        Me.pctHereRight.TabIndex = 5
        Me.pctHereRight.TabStop = False
        Me.pctHereRight.Visible = False
        '
        'pctWaterfall
        '
        Me.pctWaterfall.BackColor = System.Drawing.Color.Black
        Me.pctWaterfall.Location = New System.Drawing.Point(275, 333)
        Me.pctWaterfall.Name = "pctWaterfall"
        Me.pctWaterfall.Size = New System.Drawing.Size(128, 73)
        Me.pctWaterfall.TabIndex = 4
        Me.pctWaterfall.TabStop = False
        '
        'pctRiver
        '
        Me.pctRiver.BackColor = System.Drawing.Color.Black
        Me.pctRiver.Location = New System.Drawing.Point(489, 175)
        Me.pctRiver.Name = "pctRiver"
        Me.pctRiver.Size = New System.Drawing.Size(128, 73)
        Me.pctRiver.TabIndex = 3
        Me.pctRiver.TabStop = False
        '
        'pctHouse
        '
        Me.pctHouse.BackColor = System.Drawing.Color.Black
        Me.pctHouse.Location = New System.Drawing.Point(275, 41)
        Me.pctHouse.Name = "pctHouse"
        Me.pctHouse.Size = New System.Drawing.Size(128, 73)
        Me.pctHouse.TabIndex = 2
        Me.pctHouse.TabStop = False
        '
        'pctHeli
        '
        Me.pctHeli.BackColor = System.Drawing.Color.Black
        Me.pctHeli.Location = New System.Drawing.Point(64, 175)
        Me.pctHeli.Name = "pctHeli"
        Me.pctHeli.Size = New System.Drawing.Size(128, 73)
        Me.pctHeli.TabIndex = 1
        Me.pctHeli.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Text_Game.My.Resources.Resources.Whole_Map
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(677, 434)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pctHereUp
        '
        Me.pctHereUp.Image = Global.Text_Game.My.Resources.Resources.Here_up
        Me.pctHereUp.Location = New System.Drawing.Point(275, 256)
        Me.pctHereUp.Name = "pctHereUp"
        Me.pctHereUp.Size = New System.Drawing.Size(146, 42)
        Me.pctHereUp.TabIndex = 6
        Me.pctHereUp.TabStop = False
        Me.pctHereUp.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'pctForest
        '
        Me.pctForest.BackColor = System.Drawing.Color.Black
        Me.pctForest.Location = New System.Drawing.Point(275, 177)
        Me.pctForest.Name = "pctForest"
        Me.pctForest.Size = New System.Drawing.Size(128, 73)
        Me.pctForest.TabIndex = 7
        Me.pctForest.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(228, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Location Unknown"
        Me.Label1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 434)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctHereUp)
        Me.Controls.Add(Me.pctHereRight)
        Me.Controls.Add(Me.pctWaterfall)
        Me.Controls.Add(Me.pctRiver)
        Me.Controls.Add(Me.pctHouse)
        Me.Controls.Add(Me.pctHeli)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctForest)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pctHereRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctWaterfall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRiver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHereUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctForest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctHeli As System.Windows.Forms.PictureBox
    Friend WithEvents pctHouse As System.Windows.Forms.PictureBox
    Friend WithEvents pctRiver As System.Windows.Forms.PictureBox
    Friend WithEvents pctWaterfall As System.Windows.Forms.PictureBox
    Friend WithEvents pctHereRight As System.Windows.Forms.PictureBox
    Friend WithEvents pctHereUp As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctForest As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
