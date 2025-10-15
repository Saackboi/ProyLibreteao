<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario_Bibliotecario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserControlEncabezado1 = New ProyLibreteao.UCEncabezado()
        Me.UserControlNavegacion1 = New ProyLibreteao.UCNavegacion()
        Me.UserControlContenidoReportes11 = New ProyLibreteao.UCCReportes1()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UserControlContenidoReportes11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(281, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(893, 573)
        Me.Panel1.TabIndex = 2
        '
        'UserControlEncabezado1
        '
        Me.UserControlEncabezado1.AutoScroll = True
        Me.UserControlEncabezado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.UserControlEncabezado1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControlEncabezado1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlEncabezado1.Location = New System.Drawing.Point(281, 0)
        Me.UserControlEncabezado1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserControlEncabezado1.Name = "UserControlEncabezado1"
        Me.UserControlEncabezado1.Padding = New System.Windows.Forms.Padding(5)
        Me.UserControlEncabezado1.Size = New System.Drawing.Size(893, 100)
        Me.UserControlEncabezado1.TabIndex = 1
        '
        'UserControlNavegacion1
        '
        Me.UserControlNavegacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.UserControlNavegacion1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UserControlNavegacion1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlNavegacion1.Location = New System.Drawing.Point(0, 0)
        Me.UserControlNavegacion1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.UserControlNavegacion1.Name = "UserControlNavegacion1"
        Me.UserControlNavegacion1.Size = New System.Drawing.Size(281, 673)
        Me.UserControlNavegacion1.TabIndex = 0
        '
        'UserControlContenidoReportes11
        '
        Me.UserControlContenidoReportes11.AutoSize = True
        Me.UserControlContenidoReportes11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControlContenidoReportes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlContenidoReportes11.Location = New System.Drawing.Point(5, 5)
        Me.UserControlContenidoReportes11.Margin = New System.Windows.Forms.Padding(2)
        Me.UserControlContenidoReportes11.Name = "UserControlContenidoReportes11"
        Me.UserControlContenidoReportes11.Size = New System.Drawing.Size(879, 559)
        Me.UserControlContenidoReportes11.TabIndex = 0
        '
        'Formulario_Bibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserControlEncabezado1)
        Me.Controls.Add(Me.UserControlNavegacion1)
        Me.MinimumSize = New System.Drawing.Size(1196, 729)
        Me.Name = "Formulario_Bibliotecario"
        Me.Text = "Formulario_Bibliotecario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControlNavegacion1 As UCNavegacion
    Friend WithEvents UserControlEncabezado1 As UCEncabezado
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserControlContenidoReportes11 As UCCReportes1
End Class
