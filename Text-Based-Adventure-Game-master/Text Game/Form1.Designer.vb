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
        Me.ListA = New System.Windows.Forms.ListBox()
        Me.TextA = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.seconds = New System.Windows.Forms.Label()
        Me.minutes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.minutes1 = New System.Windows.Forms.Label()
        Me.seconds1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListA
        '
        Me.ListA.BackColor = System.Drawing.Color.Black
        Me.ListA.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListA.ForeColor = System.Drawing.Color.White
        Me.ListA.FormattingEnabled = True
        Me.ListA.ItemHeight = 20
        Me.ListA.Location = New System.Drawing.Point(1, 0)
        Me.ListA.Name = "ListA"
        Me.ListA.Size = New System.Drawing.Size(690, 464)
        Me.ListA.TabIndex = 0
        '
        'TextA
        '
        Me.TextA.BackColor = System.Drawing.Color.Black
        Me.TextA.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextA.ForeColor = System.Drawing.Color.White
        Me.TextA.Location = New System.Drawing.Point(2, 442)
        Me.TextA.Name = "TextA"
        Me.TextA.Size = New System.Drawing.Size(699, 24)
        Me.TextA.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(268, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 82)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'seconds
        '
        Me.seconds.BackColor = System.Drawing.Color.Black
        Me.seconds.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seconds.ForeColor = System.Drawing.Color.White
        Me.seconds.Location = New System.Drawing.Point(51, 34)
        Me.seconds.Name = "seconds"
        Me.seconds.Size = New System.Drawing.Size(63, 40)
        Me.seconds.TabIndex = 11
        Me.seconds.Text = "00"
        Me.seconds.Visible = False
        '
        'minutes
        '
        Me.minutes.BackColor = System.Drawing.Color.Black
        Me.minutes.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes.ForeColor = System.Drawing.Color.White
        Me.minutes.Location = New System.Drawing.Point(4, 34)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(40, 40)
        Me.minutes.TabIndex = 13
        Me.minutes.Text = "3"
        Me.minutes.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = ":"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.minutes)
        Me.GroupBox1.Controls.Add(Me.seconds)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(532, 337)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 77)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Escape!"
        Me.Label2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.minutes1)
        Me.GroupBox2.Controls.Add(Me.seconds1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(532, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 80)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'minutes1
        '
        Me.minutes1.BackColor = System.Drawing.Color.Black
        Me.minutes1.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes1.ForeColor = System.Drawing.Color.White
        Me.minutes1.Location = New System.Drawing.Point(5, 32)
        Me.minutes1.Name = "minutes1"
        Me.minutes1.Size = New System.Drawing.Size(40, 45)
        Me.minutes1.TabIndex = 13
        Me.minutes1.Text = "3"
        Me.minutes1.Visible = False
        '
        'seconds1
        '
        Me.seconds1.BackColor = System.Drawing.Color.Black
        Me.seconds1.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seconds1.ForeColor = System.Drawing.Color.White
        Me.seconds1.Location = New System.Drawing.Point(51, 32)
        Me.seconds1.Name = "seconds1"
        Me.seconds1.Size = New System.Drawing.Size(63, 45)
        Me.seconds1.TabIndex = 11
        Me.seconds1.Text = "00"
        Me.seconds1.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 45)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = ":"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 31)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Potion"
        Me.Label3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(702, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextA)
        Me.Controls.Add(Me.ListA)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListA As System.Windows.Forms.ListBox
    Friend WithEvents TextA As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents seconds As System.Windows.Forms.Label
    Friend WithEvents minutes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents minutes1 As System.Windows.Forms.Label
    Friend WithEvents seconds1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
