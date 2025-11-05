<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class interfacesninos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnJuegos = New System.Windows.Forms.Button()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.flowLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlLateral.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSuperior.Controls.Add(Me.lblBienvenida)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(750, 57)
        Me.pnlSuperior.TabIndex = 0
        '
        'lblBienvenida
        '
        Me.lblBienvenida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBienvenida.ForeColor = System.Drawing.Color.White
        Me.lblBienvenida.Location = New System.Drawing.Point(150, 8)
        Me.lblBienvenida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(472, 38)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "¡Explora el mundo de los libros! 📚"
        Me.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlLateral.Controls.Add(Me.btnSalir)
        Me.pnlLateral.Controls.Add(Me.btnJuegos)
        Me.pnlLateral.Controls.Add(Me.btnCatalogo)
        Me.pnlLateral.Controls.Add(Me.btnPerfil)
        Me.pnlLateral.Controls.Add(Me.lblMenu)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 57)
        Me.pnlLateral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(165, 431)
        Me.pnlLateral.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(22, 366)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 45)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "❌ Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnJuegos
        '
        Me.btnJuegos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnJuegos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnJuegos.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnJuegos.ForeColor = System.Drawing.Color.White
        Me.btnJuegos.Location = New System.Drawing.Point(22, 211)
        Me.btnJuegos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJuegos.Name = "btnJuegos"
        Me.btnJuegos.Size = New System.Drawing.Size(120, 45)
        Me.btnJuegos.TabIndex = 3
        Me.btnJuegos.Text = "🎮 Juegos"
        Me.btnJuegos.UseVisualStyleBackColor = False
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCatalogo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatalogo.ForeColor = System.Drawing.Color.White
        Me.btnCatalogo.Location = New System.Drawing.Point(22, 154)
        Me.btnCatalogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(120, 45)
        Me.btnCatalogo.TabIndex = 2
        Me.btnCatalogo.Text = "📚 Catálogo"
        Me.btnCatalogo.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnPerfil.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Location = New System.Drawing.Point(22, 98)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(120, 45)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "👦 Mi Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(41, 32)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(95, 27)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "🌟 Menú"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.White
        Me.pnlPrincipal.Controls.Add(Me.flowLibros)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(165, 57)
        Me.pnlPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(585, 431)
        Me.pnlPrincipal.TabIndex = 2
        '
        'flowLibros
        '
        Me.flowLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.flowLibros.Location = New System.Drawing.Point(21, 41)
        Me.flowLibros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flowLibros.Name = "flowLibros"
        Me.flowLibros.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.flowLibros.Size = New System.Drawing.Size(555, 317)
        Me.flowLibros.TabIndex = 0
        '
        'interfacesninos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 488)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(604, 414)
        Me.Name = "interfacesninos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zona Infantil "
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLateral.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnJuegos As Button
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents flowLibros As FlowLayoutPanel
End Class