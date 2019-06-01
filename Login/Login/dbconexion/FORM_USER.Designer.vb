<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_USER
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_USER))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Thora = New System.Windows.Forms.Label()
        Me.Tmin = New System.Windows.Forms.Label()
        Me.Tseg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tiniciar = New System.Windows.Forms.Button()
        Me.Tstop = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(85, 45)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(579, 323)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'Thora
        '
        Me.Thora.AutoSize = True
        Me.Thora.Location = New System.Drawing.Point(369, 396)
        Me.Thora.Name = "Thora"
        Me.Thora.Size = New System.Drawing.Size(19, 13)
        Me.Thora.TabIndex = 2
        Me.Thora.Text = "00"
        '
        'Tmin
        '
        Me.Tmin.AutoSize = True
        Me.Tmin.Location = New System.Drawing.Point(394, 396)
        Me.Tmin.Name = "Tmin"
        Me.Tmin.Size = New System.Drawing.Size(19, 13)
        Me.Tmin.TabIndex = 3
        Me.Tmin.Text = "00"
        '
        'Tseg
        '
        Me.Tseg.AutoSize = True
        Me.Tseg.Location = New System.Drawing.Point(419, 396)
        Me.Tseg.Name = "Tseg"
        Me.Tseg.Size = New System.Drawing.Size(19, 13)
        Me.Tseg.TabIndex = 4
        Me.Tseg.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Tiniciar
        '
        Me.Tiniciar.Location = New System.Drawing.Point(444, 386)
        Me.Tiniciar.Name = "Tiniciar"
        Me.Tiniciar.Size = New System.Drawing.Size(75, 23)
        Me.Tiniciar.TabIndex = 5
        Me.Tiniciar.Text = "Iniciar"
        Me.Tiniciar.UseVisualStyleBackColor = True
        '
        'Tstop
        '
        Me.Tstop.Location = New System.Drawing.Point(537, 386)
        Me.Tstop.Name = "Tstop"
        Me.Tstop.Size = New System.Drawing.Size(75, 23)
        Me.Tstop.TabIndex = 6
        Me.Tstop.Text = "Stop"
        Me.Tstop.UseVisualStyleBackColor = True
        '
        'FORM_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tstop)
        Me.Controls.Add(Me.Tiniciar)
        Me.Controls.Add(Me.Tseg)
        Me.Controls.Add(Me.Tmin)
        Me.Controls.Add(Me.Thora)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORM_USER"
        Me.Text = "FORM_USER"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Thora As Label
    Friend WithEvents Tmin As Label
    Friend WithEvents Tseg As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Tiniciar As Button
    Friend WithEvents Tstop As Button
End Class
