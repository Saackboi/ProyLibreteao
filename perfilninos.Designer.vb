<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class perfilninos
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnJuegos = New System.Windows.Forms.Button()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.pnlLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblLibros = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.pnlInsignias = New System.Windows.Forms.Panel()
        Me.lblInsignias = New System.Windows.Forms.Label()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.pbProgreso = New System.Windows.Forms.ProgressBar()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlLateral.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlInsignias.SuspendLayout()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(255, 192, 0)
        Me.pnlSuperior.Controls.Add(Me.lblTitulo)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(1000, 70)
        Me.pnlSuperior.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1000, 48)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "👦 Mi Perfil de Lector"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.FromArgb(255, 230, 180)
        Me.pnlLateral.Controls.Add(Me.btnSalir)
        Me.pnlLateral.Controls.Add(Me.btnJuegos)
        Me.pnlLateral.Controls.Add(Me.btnCatalogo)
        Me.pnlLateral.Controls.Add(Me.btnPerfil)
        Me.pnlLateral.Controls.Add(Me.lblMenu)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 70)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(220, 630)
        Me.pnlLateral.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(255, 99, 99)
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(30, 550)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(160, 55)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "❌ Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnJuegos
        '
        Me.btnJuegos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnJuegos.BackColor = System.Drawing.Color.FromArgb(255, 204, 102)
        Me.btnJuegos.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnJuegos.ForeColor = System.Drawing.Color.White
        Me.btnJuegos.Location = New System.Drawing.Point(30, 270)
        Me.btnJuegos.Name = "btnJuegos"
        Me.btnJuegos.Size = New System.Drawing.Size(160, 55)
        Me.btnJuegos.TabIndex = 3
        Me.btnJuegos.Text = "🎮 Juegos"
        Me.btnJuegos.UseVisualStyleBackColor = False
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(128, 200, 255)
        Me.btnCatalogo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatalogo.ForeColor = System.Drawing.Color.White
        Me.btnCatalogo.Location = New System.Drawing.Point(30, 200)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(160, 55)
        Me.btnCatalogo.TabIndex = 2
        Me.btnCatalogo.Text = "📚 Catálogo"
        Me.btnCatalogo.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(144, 238, 144)
        Me.btnPerfil.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Location = New System.Drawing.Point(30, 130)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(160, 55)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "👦 Mi Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0)
        Me.lblMenu.Location = New System.Drawing.Point(30, 40)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(160, 35)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "🌟 Menú"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.White
        Me.pnlPrincipal.Controls.Add(Me.pnlLibros)
        Me.pnlPrincipal.Controls.Add(Me.lblLibros)
        Me.pnlPrincipal.Controls.Add(Me.btnGuardar)
        Me.pnlPrincipal.Controls.Add(Me.btnEditar)
        Me.pnlPrincipal.Controls.Add(Me.pnlInsignias)
        Me.pnlPrincipal.Controls.Add(Me.lblProgreso)
        Me.pnlPrincipal.Controls.Add(Me.pbProgreso)
        Me.pnlPrincipal.Controls.Add(Me.lblNivel)
        Me.pnlPrincipal.Controls.Add(Me.lblNombre)
        Me.pnlPrincipal.Controls.Add(Me.picAvatar)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(220, 70)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(780, 630)
        Me.pnlPrincipal.TabIndex = 2
        '
        'pnlLibros
        '
        Me.pnlLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLibros.BackColor = System.Drawing.Color.FromArgb(245, 245, 255)
        Me.pnlLibros.Location = New System.Drawing.Point(60, 390)
        Me.pnlLibros.Name = "pnlLibros"
        Me.pnlLibros.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLibros.Size = New System.Drawing.Size(650, 130)
        Me.pnlLibros.TabIndex = 8
        '
        'lblLibros
        '
        Me.lblLibros.AutoSize = True
        Me.lblLibros.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblLibros.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblLibros.Location = New System.Drawing.Point(60, 355)
        Me.lblLibros.Name = "lblLibros"
        Me.lblLibros.Size = New System.Drawing.Size(268, 31)
        Me.lblLibros.TabIndex = 9
        Me.lblLibros.Text = "📖 Libros que he leído:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.LightPink
        Me.btnGuardar.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(392, 550)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 48)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "💾 Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditar.BackColor = System.Drawing.Color.LightGreen
        Me.btnEditar.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Location = New System.Drawing.Point(208, 550)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(150, 48)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "✏ Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'pnlInsignias
        '
        Me.pnlInsignias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInsignias.BackColor = System.Drawing.Color.FromArgb(255, 240, 200)
        Me.pnlInsignias.Controls.Add(Me.lblInsignias)
        Me.pnlInsignias.Location = New System.Drawing.Point(60, 250)
        Me.pnlInsignias.Name = "pnlInsignias"
        Me.pnlInsignias.Size = New System.Drawing.Size(650, 90)
        Me.pnlInsignias.TabIndex = 12
        '
        'lblInsignias
        '
        Me.lblInsignias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInsignias.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsignias.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblInsignias.Text = "🏅 Insignias: ⭐ Lector Curioso | 📚 Amigo de los Libros | 🌟 Aventurero"
        Me.lblInsignias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgreso.ForeColor = System.Drawing.Color.Gray
        Me.lblProgreso.Location = New System.Drawing.Point(250, 185)
        Me.lblProgreso.Text = "Progreso de lectura: 70%"
        '
        'pbProgreso
        '
        Me.pbProgreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgreso.Location = New System.Drawing.Point(250, 160)
        Me.pbProgreso.Size = New System.Drawing.Size(400, 23)
        Me.pbProgreso.Value = 70
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNivel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblNivel.Location = New System.Drawing.Point(250, 125)
        Me.lblNivel.Text = "Nivel de lectura: Explorador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.lblNombre.Location = New System.Drawing.Point(250, 90)
        Me.lblNombre.Text = "Nombre: Sofía López"
        '
        'picAvatar
        '
        Me.picAvatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picAvatar.BackColor = System.Drawing.Color.White
        Me.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAvatar.Image = Global.ProyLibreteao.My.Resources.Resources.user
        Me.picAvatar.Location = New System.Drawing.Point(60, 80)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(160, 140)
        Me.picAvatar.MinimumSize = New System.Drawing.Size(120, 120)
        Me.picAvatar.MaximumSize = New System.Drawing.Size(260, 320)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAvatar.TabIndex = 0
        Me.picAvatar.TabStop = False
        '
        'perfilninos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlSuperior)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "perfilninos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil del Lector"
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlInsignias.ResumeLayout(False)
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnJuegos As Button
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents pbProgreso As ProgressBar
    Friend WithEvents lblProgreso As Label
    Friend WithEvents pnlInsignias As Panel
    Friend WithEvents lblInsignias As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlLibros As FlowLayoutPanel
    Friend WithEvents lblLibros As Label
End Class