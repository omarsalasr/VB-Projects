<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblGO = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblLose = New System.Windows.Forms.Label()
        Me.lblLoseOgre = New System.Windows.Forms.Label()
        Me.lblCrash = New System.Windows.Forms.Label()
        Me.lblGiveUp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGO
        '
        Me.lblGO.BackColor = System.Drawing.Color.Black
        Me.lblGO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGO.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGO.ForeColor = System.Drawing.Color.White
        Me.lblGO.Location = New System.Drawing.Point(103, 42)
        Me.lblGO.Name = "lblGO"
        Me.lblGO.Size = New System.Drawing.Size(580, 112)
        Me.lblGO.TabIndex = 0
        Me.lblGO.Text = "GAME OVER"
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.Black
        Me.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWin.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.White
        Me.lblWin.Location = New System.Drawing.Point(147, 254)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(499, 80)
        Me.lblWin.TabIndex = 1
        Me.lblWin.Text = "You escaped!"
        Me.lblWin.Visible = False
        '
        'lblLose
        '
        Me.lblLose.BackColor = System.Drawing.Color.Black
        Me.lblLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLose.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose.ForeColor = System.Drawing.Color.White
        Me.lblLose.Location = New System.Drawing.Point(147, 199)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(499, 135)
        Me.lblLose.TabIndex = 2
        Me.lblLose.Text = "You were eaten alive!"
        Me.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLose.Visible = False
        '
        'lblLoseOgre
        '
        Me.lblLoseOgre.BackColor = System.Drawing.Color.Black
        Me.lblLoseOgre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoseOgre.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoseOgre.ForeColor = System.Drawing.Color.White
        Me.lblLoseOgre.Location = New System.Drawing.Point(147, 199)
        Me.lblLoseOgre.Name = "lblLoseOgre"
        Me.lblLoseOgre.Size = New System.Drawing.Size(499, 135)
        Me.lblLoseOgre.TabIndex = 3
        Me.lblLoseOgre.Text = "An Ogre ate you!"
        Me.lblLoseOgre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoseOgre.Visible = False
        '
        'lblCrash
        '
        Me.lblCrash.BackColor = System.Drawing.Color.Black
        Me.lblCrash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCrash.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrash.ForeColor = System.Drawing.Color.White
        Me.lblCrash.Location = New System.Drawing.Point(147, 188)
        Me.lblCrash.Name = "lblCrash"
        Me.lblCrash.Size = New System.Drawing.Size(499, 200)
        Me.lblCrash.TabIndex = 4
        Me.lblCrash.Text = "You crashed against a tree!"
        Me.lblCrash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCrash.Visible = False
        '
        'lblGiveUp
        '
        Me.lblGiveUp.BackColor = System.Drawing.Color.Black
        Me.lblGiveUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGiveUp.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiveUp.ForeColor = System.Drawing.Color.White
        Me.lblGiveUp.Location = New System.Drawing.Point(215, 209)
        Me.lblGiveUp.Name = "lblGiveUp"
        Me.lblGiveUp.Size = New System.Drawing.Size(360, 158)
        Me.lblGiveUp.TabIndex = 5
        Me.lblGiveUp.Text = "You lost hope!"
        Me.lblGiveUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGiveUp.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(795, 425)
        Me.Controls.Add(Me.lblGiveUp)
        Me.Controls.Add(Me.lblCrash)
        Me.Controls.Add(Me.lblLoseOgre)
        Me.Controls.Add(Me.lblLose)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblGO)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblGO As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents lblLose As System.Windows.Forms.Label
    Friend WithEvents lblLoseOgre As System.Windows.Forms.Label
    Friend WithEvents lblCrash As System.Windows.Forms.Label
    Friend WithEvents lblGiveUp As System.Windows.Forms.Label
End Class
