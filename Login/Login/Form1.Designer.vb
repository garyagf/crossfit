<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tusername = New System.Windows.Forms.TextBox()
        Me.BTlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.BTcancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Tusername
        '
        Me.Tusername.Location = New System.Drawing.Point(113, 141)
        Me.Tusername.Name = "Tusername"
        Me.Tusername.Size = New System.Drawing.Size(100, 20)
        Me.Tusername.TabIndex = 1
        '
        'BTlogin
        '
        Me.BTlogin.Location = New System.Drawing.Point(32, 269)
        Me.BTlogin.Name = "BTlogin"
        Me.BTlogin.Size = New System.Drawing.Size(75, 23)
        Me.BTlogin.TabIndex = 2
        Me.BTlogin.Tag = "BTlogin"
        Me.BTlogin.Text = "Login"
        Me.BTlogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "contraseña"
        '
        'Tpassword
        '
        Me.Tpassword.Location = New System.Drawing.Point(113, 187)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpassword.Size = New System.Drawing.Size(100, 20)
        Me.Tpassword.TabIndex = 4
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(138, 269)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(75, 23)
        Me.BTcancel.TabIndex = 6
        Me.BTcancel.Text = "Cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 384)
        Me.Controls.Add(Me.BTcancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTlogin)
        Me.Controls.Add(Me.Tusername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Tusername As TextBox
    Friend WithEvents BTlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents BTcancel As Button
End Class
