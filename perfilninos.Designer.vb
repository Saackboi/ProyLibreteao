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
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSuperior.Controls.Add(Me.lblTitulo)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(750, 57)
        Me.pnlSuperior.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(750, 39)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "👦 Mi Perfil de Lector"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlLateral.Controls.Add(Me.btnJuegos)
        Me.pnlLateral.Controls.Add(Me.btnCatalogo)
        Me.pnlLateral.Controls.Add(Me.btnPerfil)
        Me.pnlLateral.Controls.Add(Me.lblMenu)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 57)
        Me.pnlLateral.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(165, 512)
        Me.pnlLateral.TabIndex = 1
        '
        'btnJuegos
        '
        Me.btnJuegos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnJuegos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnJuegos.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnJuegos.ForeColor = System.Drawing.Color.White
        Me.btnJuegos.Location = New System.Drawing.Point(22, 219)
        Me.btnJuegos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJuegos.Name = "btnJuegos"
        Me.btnJuegos.Size = New System.Drawing.Size(120, 45)
        Me.btnJuegos.TabIndex = 3
        Me.btnJuegos.Text = "🎮 Juegos"
        Me.btnJuegos.UseVisualStyleBackColor = False
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCatalogo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatalogo.ForeColor = System.Drawing.Color.White
        Me.btnCatalogo.Location = New System.Drawing.Point(22, 162)
        Me.btnCatalogo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(120, 45)
        Me.btnCatalogo.TabIndex = 2
        Me.btnCatalogo.Text = "📚 Catálogo"
        Me.btnCatalogo.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnPerfil.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Location = New System.Drawing.Point(22, 106)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(120, 45)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "👦 Mi Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(22, 32)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(120, 28)
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
        Me.pnlPrincipal.Location = New System.Drawing.Point(165, 57)
        Me.pnlPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(585, 512)
        Me.pnlPrincipal.TabIndex = 2
        '
        'pnlLibros
        '
        Me.pnlLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlLibros.Location = New System.Drawing.Point(45, 317)
        Me.pnlLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLibros.Name = "pnlLibros"
        Me.pnlLibros.Padding = New System.Windows.Forms.Padding(8)
        Me.pnlLibros.Size = New System.Drawing.Size(488, 106)
        Me.pnlLibros.TabIndex = 8
        '
        'lblLibros
        '
        Me.lblLibros.AutoSize = True
        Me.lblLibros.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblLibros.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblLibros.Location = New System.Drawing.Point(45, 288)
        Me.lblLibros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLibros.Name = "lblLibros"
        Me.lblLibros.Size = New System.Drawing.Size(219, 25)
        Me.lblLibros.TabIndex = 9
        Me.lblLibros.Text = "📖 Libros que he leído:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.LightPink
        Me.btnGuardar.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(294, 447)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 39)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "💾 Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditar.BackColor = System.Drawing.Color.LightGreen
        Me.btnEditar.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Location = New System.Drawing.Point(156, 447)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(112, 39)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "✏ Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'pnlInsignias
        '
        Me.pnlInsignias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInsignias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnlInsignias.Controls.Add(Me.lblInsignias)
        Me.pnlInsignias.Location = New System.Drawing.Point(45, 203)
        Me.pnlInsignias.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInsignias.Name = "pnlInsignias"
        Me.pnlInsignias.Size = New System.Drawing.Size(488, 73)
        Me.pnlInsignias.TabIndex = 12
        '
        'lblInsignias
        '
        Me.lblInsignias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInsignias.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsignias.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblInsignias.Location = New System.Drawing.Point(0, 0)
        Me.lblInsignias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInsignias.Name = "lblInsignias"
        Me.lblInsignias.Size = New System.Drawing.Size(488, 73)
        Me.lblInsignias.TabIndex = 0
        Me.lblInsignias.Text = "🏅 Insignias: ⭐ Lector Curioso | 📚 Amigo de los Libros | 🌟 Aventurero"
        Me.lblInsignias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgreso.ForeColor = System.Drawing.Color.Gray
        Me.lblProgreso.Location = New System.Drawing.Point(188, 150)
        Me.lblProgreso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(183, 19)
        Me.lblProgreso.TabIndex = 13
        Me.lblProgreso.Text = "Progreso de lectura: 70%"
        '
        'pbProgreso
        '
        Me.pbProgreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgreso.Location = New System.Drawing.Point(188, 130)
        Me.pbProgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.pbProgreso.Name = "pbProgreso"
        Me.pbProgreso.Size = New System.Drawing.Size(300, 19)
        Me.pbProgreso.TabIndex = 14
        Me.pbProgreso.Value = 70
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNivel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblNivel.Location = New System.Drawing.Point(188, 102)
        Me.lblNivel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(230, 23)
        Me.lblNivel.TabIndex = 15
        Me.lblNivel.Text = "Nivel de lectura: Explorador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.lblNombre.Location = New System.Drawing.Point(188, 73)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(198, 25)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre: Sofía López"
        '
        'picAvatar
        '
        Me.picAvatar.BackColor = System.Drawing.Color.White
        Me.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAvatar.Image = Global.ProyLibreteao.My.Resources.Resources.user
        Me.picAvatar.Location = New System.Drawing.Point(45, 65)
        Me.picAvatar.Margin = New System.Windows.Forms.Padding(2)
        Me.picAvatar.MaximumSize = New System.Drawing.Size(196, 260)
        Me.picAvatar.MinimumSize = New System.Drawing.Size(90, 98)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(120, 114)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAvatar.TabIndex = 0
        Me.picAvatar.TabStop = False
        '
        'perfilninos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 569)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(604, 414)
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