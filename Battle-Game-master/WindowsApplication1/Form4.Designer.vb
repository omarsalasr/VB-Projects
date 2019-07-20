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
        Me.mainChar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.mainChar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'mainChar
        '
        Me.mainChar.Image = CType(resources.GetObject("mainChar.Image"),System.Drawing.Image)
        Me.mainChar.Location = New System.Drawing.Point(258, 146)
        Me.mainChar.Name = "mainChar"
        Me.mainChar.Size = New System.Drawing.Size(184, 186)
        Me.mainChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainChar.TabIndex = 1
        Me.mainChar.TabStop = false
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose your Hero"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(69, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Natsu"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "hero 1.png")
        Me.ImageList1.Images.SetKeyName(1, "hero 2.png")
        Me.ImageList1.Images.SetKeyName(2, "images.jpg")
        Me.ImageList1.Images.SetKeyName(3, "question-mark-face.jpg")
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.Location = New System.Drawing.Point(285, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 38)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Knight"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.Location = New System.Drawing.Point(503, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Kisame"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 186)
        Me.Label2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 186)
        Me.Label3.TabIndex = 4
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 472)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mainChar)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.mainChar,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents mainChar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
