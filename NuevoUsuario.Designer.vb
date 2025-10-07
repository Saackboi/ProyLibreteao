<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnYaTengo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E-MAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CONTRASEÑA"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(469, 94)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 26)
        Me.txtEmail.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(469, 183)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(266, 26)
        Me.txtUsuario.TabIndex = 4
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(469, 265)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(266, 26)
        Me.txtContrasena.TabIndex = 5
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.Gold
        Me.btnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrarse.Location = New System.Drawing.Point(475, 375)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(125, 41)
        Me.btnRegistrarse.TabIndex = 6
        Me.btnRegistrarse.Text = "REGISTRARSE"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.btnYaTengo)
        Me.Panel1.Location = New System.Drawing.Point(441, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 426)
        Me.Panel1.TabIndex = 7
        '
        'btnYaTengo
        '
        Me.btnYaTengo.AutoSize = True
        Me.btnYaTengo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnYaTengo.Location = New System.Drawing.Point(216, 377)
        Me.btnYaTengo.Name = "btnYaTengo"
        Me.btnYaTengo.Size = New System.Drawing.Size(86, 13)
        Me.btnYaTengo.TabIndex = 8
        Me.btnYaTengo.Text = "Ya tengo cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 37)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nuevo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(194, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 37)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Registro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "#Filtros eficientes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "#Sistemas automatizados"
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnYaTengo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
