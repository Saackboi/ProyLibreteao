<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class leerlibro
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
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTituloLibro = New System.Windows.Forms.Label()
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.btnGuardarNota = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnDisminuir = New System.Windows.Forms.Button()
        Me.btnAumentar = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnSubrayar = New System.Windows.Forms.Button()
        Me.txtContenido = New System.Windows.Forms.RichTextBox()
        Me.pnlInferior = New System.Windows.Forms.Panel()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlLateral.SuspendLayout()
        Me.pnlInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.Black
        Me.pnlSuperior.Controls.Add(Me.btnVolver)
        Me.pnlSuperior.Controls.Add(Me.lblTituloLibro)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(712, 45)
        Me.pnlSuperior.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.White
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(11, 8)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(117, 28)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "← Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTituloLibro
        '
        Me.lblTituloLibro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTituloLibro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloLibro.ForeColor = System.Drawing.Color.White
        Me.lblTituloLibro.Location = New System.Drawing.Point(150, 8)
        Me.lblTituloLibro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloLibro.Name = "lblTituloLibro"
        Me.lblTituloLibro.Size = New System.Drawing.Size(450, 28)
        Me.lblTituloLibro.TabIndex = 0
        Me.lblTituloLibro.Text = "Matemáticas en segundos"
        Me.lblTituloLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLateral.Controls.Add(Me.btnGuardarNota)
        Me.pnlLateral.Controls.Add(Me.btnBuscar)
        Me.pnlLateral.Controls.Add(Me.txtBuscar)
        Me.pnlLateral.Controls.Add(Me.btnDisminuir)
        Me.pnlLateral.Controls.Add(Me.btnAumentar)
        Me.pnlLateral.Controls.Add(Me.btnColor)
        Me.pnlLateral.Controls.Add(Me.btnSubrayar)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 45)
        Me.pnlLateral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.pnlLateral.Size = New System.Drawing.Size(128, 377)
        Me.pnlLateral.TabIndex = 5
        '
        'btnGuardarNota
        '
        Me.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardarNota.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGuardarNota.FlatAppearance.BorderSize = 0
        Me.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNota.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarNota.ForeColor = System.Drawing.Color.White
        Me.btnGuardarNota.Location = New System.Drawing.Point(8, 216)
        Me.btnGuardarNota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardarNota.Name = "btnGuardarNota"
        Me.btnGuardarNota.Size = New System.Drawing.Size(112, 37)
        Me.btnGuardarNota.TabIndex = 0
        Me.btnGuardarNota.Text = "💾 Guardar Nota"
        Me.btnGuardarNota.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(8, 179)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 37)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "🔎 Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(8, 156)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(112, 23)
        Me.txtBuscar.TabIndex = 2
        '
        'btnDisminuir
        '
        Me.btnDisminuir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisminuir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDisminuir.FlatAppearance.BorderSize = 0
        Me.btnDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisminuir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDisminuir.ForeColor = System.Drawing.Color.White
        Me.btnDisminuir.Location = New System.Drawing.Point(8, 119)
        Me.btnDisminuir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDisminuir.Name = "btnDisminuir"
        Me.btnDisminuir.Size = New System.Drawing.Size(112, 37)
        Me.btnDisminuir.TabIndex = 3
        Me.btnDisminuir.Text = "🔎 Disminuir"
        Me.btnDisminuir.UseVisualStyleBackColor = False
        '
        'btnAumentar
        '
        Me.btnAumentar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAumentar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAumentar.FlatAppearance.BorderSize = 0
        Me.btnAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAumentar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAumentar.ForeColor = System.Drawing.Color.White
        Me.btnAumentar.Location = New System.Drawing.Point(8, 82)
        Me.btnAumentar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAumentar.Name = "btnAumentar"
        Me.btnAumentar.Size = New System.Drawing.Size(112, 37)
        Me.btnAumentar.TabIndex = 4
        Me.btnAumentar.Text = "🔍 Aumentar"
        Me.btnAumentar.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnColor.FlatAppearance.BorderSize = 0
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnColor.ForeColor = System.Drawing.Color.White
        Me.btnColor.Location = New System.Drawing.Point(8, 45)
        Me.btnColor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(112, 37)
        Me.btnColor.TabIndex = 5
        Me.btnColor.Text = "🎨 Color"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnSubrayar
        '
        Me.btnSubrayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubrayar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubrayar.FlatAppearance.BorderSize = 0
        Me.btnSubrayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubrayar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubrayar.ForeColor = System.Drawing.Color.White
        Me.btnSubrayar.Location = New System.Drawing.Point(8, 8)
        Me.btnSubrayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubrayar.Name = "btnSubrayar"
        Me.btnSubrayar.Size = New System.Drawing.Size(112, 37)
        Me.btnSubrayar.TabIndex = 6
        Me.btnSubrayar.Text = "✏ Subrayar"
        Me.btnSubrayar.UseVisualStyleBackColor = False
        '
        'txtContenido
        '
        Me.txtContenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContenido.BackColor = System.Drawing.Color.White
        Me.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContenido.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtContenido.ForeColor = System.Drawing.Color.Black
        Me.txtContenido.Location = New System.Drawing.Point(132, 57)
        Me.txtContenido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(566, 349)
        Me.txtContenido.TabIndex = 4
        Me.txtContenido.Text = "Aquí aparecerá el contenido del libro..."
        '
        'pnlInferior
        '
        Me.pnlInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlInferior.Controls.Add(Me.lblPagina)
        Me.pnlInferior.Controls.Add(Me.btnAnterior)
        Me.pnlInferior.Controls.Add(Me.btnSiguiente)
        Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInferior.Location = New System.Drawing.Point(0, 422)
        Me.pnlInferior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlInferior.Name = "pnlInferior"
        Me.pnlInferior.Size = New System.Drawing.Size(712, 49)
        Me.pnlInferior.TabIndex = 2
        '
        'lblPagina
        '
        Me.lblPagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPagina.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Italic)
        Me.lblPagina.ForeColor = System.Drawing.Color.Gray
        Me.lblPagina.Location = New System.Drawing.Point(319, 15)
        Me.lblPagina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(75, 24)
        Me.lblPagina.TabIndex = 2
        Me.lblPagina.Text = "Página 1 de 5"
        Me.lblPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.ForeColor = System.Drawing.Color.White
        Me.btnAnterior.Location = New System.Drawing.Point(38, 11)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(124, 28)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.Text = "⬅ Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(585, 11)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(90, 28)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente ➡"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'leerlibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 471)
        Me.Controls.Add(Me.txtContenido)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlInferior)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "leerlibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "📖 Leer Libro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLateral.PerformLayout()
        Me.pnlInferior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblTituloLibro As Label
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnSubrayar As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnAumentar As Button
    Friend WithEvents btnDisminuir As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardarNota As Button
    Friend WithEvents txtContenido As RichTextBox
    Friend WithEvents pnlInferior As Panel
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lblPagina As Label
End Class