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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbl1v1 = New System.Windows.Forms.Label()
        Me.lbl4way = New System.Windows.Forms.Label()
        Me.pctHover1 = New System.Windows.Forms.PictureBox()
        Me.pctHover3 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.btn1v1Con = New System.Windows.Forms.Button()
        Me.btn4WayCon = New System.Windows.Forms.Button()
        CType(Me.pctHover1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHover3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(249, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 57)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pong"
        '
        'lbl1v1
        '
        Me.lbl1v1.AutoSize = True
        Me.lbl1v1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1v1.ForeColor = System.Drawing.Color.White
        Me.lbl1v1.Location = New System.Drawing.Point(283, 180)
        Me.lbl1v1.Name = "lbl1v1"
        Me.lbl1v1.Size = New System.Drawing.Size(70, 25)
        Me.lbl1v1.TabIndex = 2
        Me.lbl1v1.Text = "1 vs 1"
        '
        'lbl4way
        '
        Me.lbl4way.AutoSize = True
        Me.lbl4way.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4way.ForeColor = System.Drawing.Color.White
        Me.lbl4way.Location = New System.Drawing.Point(222, 240)
        Me.lbl4way.Name = "lbl4way"
        Me.lbl4way.Size = New System.Drawing.Size(186, 25)
        Me.lbl4way.TabIndex = 2
        Me.lbl4way.Text = "4 Way Free-for-All"
        '
        'pctHover1
        '
        Me.pctHover1.Image = CType(resources.GetObject("pctHover1.Image"), System.Drawing.Image)
        Me.pctHover1.Location = New System.Drawing.Point(236, 180)
        Me.pctHover1.Name = "pctHover1"
        Me.pctHover1.Size = New System.Drawing.Size(28, 25)
        Me.pctHover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHover1.TabIndex = 3
        Me.pctHover1.TabStop = False
        Me.pctHover1.Visible = False
        '
        'pctHover3
        '
        Me.pctHover3.Image = CType(resources.GetObject("pctHover3.Image"), System.Drawing.Image)
        Me.pctHover3.Location = New System.Drawing.Point(177, 240)
        Me.pctHover3.Name = "pctHover3"
        Me.pctHover3.Size = New System.Drawing.Size(28, 25)
        Me.pctHover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHover3.TabIndex = 3
        Me.pctHover3.TabStop = False
        Me.pctHover3.Visible = False
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.White
        Me.pct2.Location = New System.Drawing.Point(577, 109)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(30, 175)
        Me.pct2.TabIndex = 1
        Me.pct2.TabStop = False
        '
        'pct1
        '
        Me.pct1.BackColor = System.Drawing.Color.White
        Me.pct1.Location = New System.Drawing.Point(25, 109)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(30, 175)
        Me.pct1.TabIndex = 1
        Me.pct1.TabStop = False
        '
        'btn1v1Con
        '
        Me.btn1v1Con.Location = New System.Drawing.Point(393, 180)
        Me.btn1v1Con.Name = "btn1v1Con"
        Me.btn1v1Con.Size = New System.Drawing.Size(111, 25)
        Me.btn1v1Con.TabIndex = 4
        Me.btn1v1Con.Text = "Continue"
        Me.btn1v1Con.UseVisualStyleBackColor = True
        Me.btn1v1Con.Visible = False
        '
        'btn4WayCon
        '
        Me.btn4WayCon.Location = New System.Drawing.Point(435, 240)
        Me.btn4WayCon.Name = "btn4WayCon"
        Me.btn4WayCon.Size = New System.Drawing.Size(111, 25)
        Me.btn4WayCon.TabIndex = 4
        Me.btn4WayCon.Text = "Continue"
        Me.btn4WayCon.UseVisualStyleBackColor = True
        Me.btn4WayCon.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(629, 412)
        Me.Controls.Add(Me.btn4WayCon)
        Me.Controls.Add(Me.btn1v1Con)
        Me.Controls.Add(Me.pctHover3)
        Me.Controls.Add(Me.pctHover1)
        Me.Controls.Add(Me.lbl4way)
        Me.Controls.Add(Me.lbl1v1)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Pong menu"
        CType(Me.pctHover1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctHover3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pct2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pct1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbl1v1 As System.Windows.Forms.Label
    Friend WithEvents lbl4way As System.Windows.Forms.Label
    Friend WithEvents pctHover1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctHover3 As System.Windows.Forms.PictureBox
    Friend WithEvents pct2 As System.Windows.Forms.PictureBox
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn1v1Con As System.Windows.Forms.Button
    Friend WithEvents btn4WayCon As System.Windows.Forms.Button

End Class
