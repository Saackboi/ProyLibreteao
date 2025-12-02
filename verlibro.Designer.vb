<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class verlibro
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMenuSuperior = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnlMenuInferior = New System.Windows.Forms.Panel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.LinkLabel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblCalificacion = New System.Windows.Forms.Label()
        Me.lblDisponibles = New System.Windows.Forms.Label()
        Me.btnHacerPedido = New System.Windows.Forms.Button()
        Me.lstComentarios = New System.Windows.Forms.ListBox()
        Me.picPortada = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picUsuario = New System.Windows.Forms.PictureBox()
        Me.pnlMenuSuperior.SuspendLayout()
        Me.pnlMenuInferior.SuspendLayout()
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenuSuperior
        '
        Me.pnlMenuSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMenuSuperior.Controls.Add(Me.picLogo)
        Me.pnlMenuSuperior.Controls.Add(Me.txtBuscar)
        Me.pnlMenuSuperior.Controls.Add(Me.btnBuscar)
        Me.pnlMenuSuperior.Controls.Add(Me.picUsuario)
        Me.pnlMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenuSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMenuSuperior.Name = "pnlMenuSuperior"
        Me.pnlMenuSuperior.Size = New System.Drawing.Size(690, 45)
        Me.pnlMenuSuperior.TabIndex = 9
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.Gray
        Me.txtBuscar.Location = New System.Drawing.Point(158, 11)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(338, 26)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(502, 11)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 26)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'pnlMenuInferior
        '
        Me.pnlMenuInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlMenuInferior.Controls.Add(Me.btnInicio)
        Me.pnlMenuInferior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenuInferior.Location = New System.Drawing.Point(0, 45)
        Me.pnlMenuInferior.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMenuInferior.Name = "pnlMenuInferior"
        Me.pnlMenuInferior.Size = New System.Drawing.Size(690, 37)
        Me.pnlMenuInferior.TabIndex = 10
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Location = New System.Drawing.Point(0, 6)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(97, 24)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "🏠 Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(232, 98)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(435, 28)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "MATEMÁTICAS EN SEGUNDOS"
        '
        'lblAutor
        '
        Me.lblAutor.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Underline)
        Me.lblAutor.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblAutor.Location = New System.Drawing.Point(234, 130)
        Me.lblAutor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(120, 19)
        Me.lblAutor.TabIndex = 6
        Me.lblAutor.TabStop = True
        Me.lblAutor.Text = "Paul Parsons"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(236, 158)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(428, 98)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.Text = "Pensadores, teorías, descubrimientos y conceptos relacionados con las matemáticas" &
    "..."
        '
        'lblISBN
        '
        Me.lblISBN.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblISBN.ForeColor = System.Drawing.Color.DimGray
        Me.lblISBN.Location = New System.Drawing.Point(236, 264)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(188, 19)
        Me.lblISBN.TabIndex = 4
        Me.lblISBN.Text = "ISBN: 9781402790027"
        '
        'lblCalificacion
        '
        Me.lblCalificacion.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Italic)
        Me.lblCalificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCalificacion.Location = New System.Drawing.Point(236, 284)
        Me.lblCalificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalificacion.Name = "lblCalificacion"
        Me.lblCalificacion.Size = New System.Drawing.Size(188, 19)
        Me.lblCalificacion.TabIndex = 3
        Me.lblCalificacion.Text = "⭐⭐⭐⭐☆ (12 valoraciones)"
        '
        'lblDisponibles
        '
        Me.lblDisponibles.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDisponibles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisponibles.Location = New System.Drawing.Point(529, 292)
        Me.lblDisponibles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisponibles.Name = "lblDisponibles"
        Me.lblDisponibles.Size = New System.Drawing.Size(150, 19)
        Me.lblDisponibles.TabIndex = 2
        Me.lblDisponibles.Text = "Disponibles: 5 unidades"
        '
        'btnHacerPedido
        '
        Me.btnHacerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHacerPedido.FlatAppearance.BorderSize = 0
        Me.btnHacerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHacerPedido.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnHacerPedido.ForeColor = System.Drawing.Color.White
        Me.btnHacerPedido.Location = New System.Drawing.Point(529, 258)
        Me.btnHacerPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHacerPedido.Name = "btnHacerPedido"
        Me.btnHacerPedido.Size = New System.Drawing.Size(135, 28)
        Me.btnHacerPedido.TabIndex = 1
        Me.btnHacerPedido.Text = "📚 Hacer pedido"
        Me.btnHacerPedido.UseVisualStyleBackColor = False
        '
        'lstComentarios
        '
        Me.lstComentarios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstComentarios.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lstComentarios.ForeColor = System.Drawing.Color.Black
        Me.lstComentarios.FormattingEnabled = True
        Me.lstComentarios.ItemHeight = 17
        Me.lstComentarios.Items.AddRange(New Object() {"Animesh ⭐⭐⭐⭐ - Muy buen libro bro.", "Vansh ⭐⭐⭐⭐ - Impresionante contenido."})
        Me.lstComentarios.Location = New System.Drawing.Point(37, 378)
        Me.lstComentarios.Margin = New System.Windows.Forms.Padding(2)
        Me.lstComentarios.Name = "lstComentarios"
        Me.lstComentarios.Size = New System.Drawing.Size(630, 68)
        Me.lstComentarios.TabIndex = 0
        '
        'picPortada
        '
        Me.picPortada.Image = Global.ProyLibreteao.My.Resources.Resources.libro
        Me.picPortada.Location = New System.Drawing.Point(34, 98)
        Me.picPortada.Margin = New System.Windows.Forms.Padding(2)
        Me.picPortada.Name = "picPortada"
        Me.picPortada.Size = New System.Drawing.Size(180, 260)
        Me.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPortada.TabIndex = 8
        Me.picPortada.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.ProyLibreteao.My.Resources.Resources.iconVerlibro
        Me.picLogo.Location = New System.Drawing.Point(11, 6)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(32, 34)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'picUsuario
        '
        Me.picUsuario.Image = Global.ProyLibreteao.My.Resources.Resources.usuario
        Me.picUsuario.Location = New System.Drawing.Point(645, 6)
        Me.picUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(32, 34)
        Me.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUsuario.TabIndex = 3
        Me.picUsuario.TabStop = False
        '
        'verlibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 488)
        Me.Controls.Add(Me.lstComentarios)
        Me.Controls.Add(Me.btnHacerPedido)
        Me.Controls.Add(Me.lblDisponibles)
        Me.Controls.Add(Me.lblCalificacion)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.picPortada)
        Me.Controls.Add(Me.pnlMenuInferior)
        Me.Controls.Add(Me.pnlMenuSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "verlibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "📖 Ver Libro"
        Me.pnlMenuSuperior.ResumeLayout(False)
        Me.pnlMenuSuperior.PerformLayout()
        Me.pnlMenuInferior.ResumeLayout(False)
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMenuSuperior As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents picUsuario As PictureBox
    Friend WithEvents pnlMenuInferior As Panel
    Friend WithEvents btnInicio As Button
    Friend WithEvents picPortada As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As LinkLabel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblDisponibles As Label
    Friend WithEvents btnHacerPedido As Button
    Friend WithEvents lstComentarios As ListBox
    Friend WithEvents lblCalificacion As Label
End Class