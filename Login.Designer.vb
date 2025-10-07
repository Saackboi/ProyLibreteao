<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEntrarInvitado = New System.Windows.Forms.Label()
        Me.cbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegistrarse = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.btnIniciarSesion)
        Me.Panel1.Controls.Add(Me.btnRegistrarse)
        Me.Panel1.Controls.Add(Me.btnEntrarInvitado)
        Me.Panel1.Controls.Add(Me.cbTipoUsuario)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtContrasena)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(197, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 393)
        Me.Panel1.TabIndex = 0
        '
        'btnEntrarInvitado
        '
        Me.btnEntrarInvitado.AutoSize = True
        Me.btnEntrarInvitado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEntrarInvitado.Location = New System.Drawing.Point(279, 363)
        Me.btnEntrarInvitado.Name = "btnEntrarInvitado"
        Me.btnEntrarInvitado.Size = New System.Drawing.Size(104, 13)
        Me.btnEntrarInvitado.TabIndex = 9
        Me.btnEntrarInvitado.Text = "Entrar como invitado"
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoUsuario.FormattingEnabled = True
        Me.cbTipoUsuario.Items.AddRange(New Object() {"Estudiante", "Bibliotecario"})
        Me.cbTipoUsuario.Location = New System.Drawing.Point(56, 269)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(300, 23)
        Me.cbTipoUsuario.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(52, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO DE USUARIO"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(56, 212)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(300, 22)
        Me.txtContrasena.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(56, 155)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(300, 22)
        Me.txtUsuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(52, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(52, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USUARIO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Info
        Me.PictureBox1.Location = New System.Drawing.Point(149, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 112)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.AutoSize = True
        Me.btnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarse.Location = New System.Drawing.Point(66, 361)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(70, 15)
        Me.btnRegistrarse.TabIndex = 11
        Me.btnRegistrarse.Text = "Registrarse"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.Gold
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(56, 308)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(300, 40)
        Me.btnIniciarSesion.TabIndex = 12
        Me.btnIniciarSesion.Text = "INICIAR SESIÓN"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTipoUsuario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnEntrarInvitado As Label
    Friend WithEvents btnRegistrarse As Label
    Friend WithEvents btnIniciarSesion As Button
End Class
