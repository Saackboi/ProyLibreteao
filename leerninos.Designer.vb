<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class leerninos
    Inherits System.Windows.Forms.Form

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
        Me.lblTituloSuperior = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnMarcador = New System.Windows.Forms.Button()
        Me.btnSubrayar = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnVoz = New System.Windows.Forms.Button()
        Me.txtLectura = New System.Windows.Forms.RichTextBox()
        Me.pnlInferior = New System.Windows.Forms.Panel()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.pnlSuperior.Controls.Add(Me.btnVolver)
        Me.pnlSuperior.Controls.Add(Me.lblTituloSuperior)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(950, 50)
        Me.pnlSuperior.TabIndex = 3
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnVolver.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(10, 8)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(140, 32)
        Me.btnVolver.TabIndex = 0
        Me.btnVolver.Text = "🔙 Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTituloSuperior
        '
        Me.lblTituloSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTituloSuperior.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloSuperior.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblTituloSuperior.Location = New System.Drawing.Point(250, 8)
        Me.lblTituloSuperior.Name = "lblTituloSuperior"
        Me.lblTituloSuperior.Size = New System.Drawing.Size(450, 32)
        Me.lblTituloSuperior.TabIndex = 1
        Me.lblTituloSuperior.Text = "Lectura Interactiva Infantil 📖"
        Me.lblTituloSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnMarcador)
        Me.pnlMenu.Controls.Add(Me.btnSubrayar)
        Me.pnlMenu.Controls.Add(Me.btnColor)
        Me.pnlMenu.Controls.Add(Me.btnVoz)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 50)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(180, 500)
        Me.pnlMenu.TabIndex = 2
        '
        'btnMarcador
        '
        Me.btnMarcador.BackColor = System.Drawing.Color.LightPink
        Me.btnMarcador.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMarcador.Location = New System.Drawing.Point(10, 20)
        Me.btnMarcador.Name = "btnMarcador"
        Me.btnMarcador.Size = New System.Drawing.Size(160, 35)
        Me.btnMarcador.TabIndex = 0
        Me.btnMarcador.Text = "📑 Marcador"
        Me.btnMarcador.UseVisualStyleBackColor = False
        '
        'btnSubrayar
        '
        Me.btnSubrayar.BackColor = System.Drawing.Color.LightYellow
        Me.btnSubrayar.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSubrayar.Location = New System.Drawing.Point(10, 70)
        Me.btnSubrayar.Name = "btnSubrayar"
        Me.btnSubrayar.Size = New System.Drawing.Size(160, 35)
        Me.btnSubrayar.TabIndex = 1
        Me.btnSubrayar.Text = "🖍 Subrayar"
        Me.btnSubrayar.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.LightBlue
        Me.btnColor.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnColor.Location = New System.Drawing.Point(10, 120)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(160, 35)
        Me.btnColor.TabIndex = 2
        Me.btnColor.Text = "🎨 Colorear"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnVoz
        '
        Me.btnVoz.BackColor = System.Drawing.Color.LightGreen
        Me.btnVoz.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnVoz.Location = New System.Drawing.Point(10, 170)
        Me.btnVoz.Name = "btnVoz"
        Me.btnVoz.Size = New System.Drawing.Size(160, 35)
        Me.btnVoz.TabIndex = 3
        Me.btnVoz.Text = "🔊 Leer Voz"
        Me.btnVoz.UseVisualStyleBackColor = False
        '
        'txtLectura
        '
        Me.txtLectura.BackColor = System.Drawing.Color.White
        Me.txtLectura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLectura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLectura.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.txtLectura.Location = New System.Drawing.Point(180, 50)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(770, 450)
        Me.txtLectura.TabIndex = 0
        Me.txtLectura.Text = "Había una vez un pequeño príncipe que vivía solo en un planeta muy pequeño llamad" &
    "o el asteroide B-612..."
        '
        'pnlInferior
        '
        Me.pnlInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlInferior.Controls.Add(Me.btnAnterior)
        Me.pnlInferior.Controls.Add(Me.btnSiguiente)
        Me.pnlInferior.Controls.Add(Me.lblPagina)
        Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInferior.Location = New System.Drawing.Point(180, 500)
        Me.pnlInferior.Name = "pnlInferior"
        Me.pnlInferior.Size = New System.Drawing.Size(770, 50)
        Me.pnlInferior.TabIndex = 1
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnterior.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAnterior.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.Location = New System.Drawing.Point(100, 6)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(152, 39)
        Me.btnAnterior.TabIndex = 0
        Me.btnAnterior.Text = "⬅ Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSiguiente.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSiguiente.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.Location = New System.Drawing.Point(500, 6)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(167, 39)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente ➡"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'lblPagina
        '
        Me.lblPagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPagina.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPagina.ForeColor = System.Drawing.Color.Gray
        Me.lblPagina.Location = New System.Drawing.Point(340, 14)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(100, 28)
        Me.lblPagina.TabIndex = 2
        Me.lblPagina.Text = "Página 1"
        Me.lblPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leerninos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.txtLectura)
        Me.Controls.Add(Me.pnlInferior)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlSuperior)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "leerninos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "📖 Lectura Interactiva para Niños"
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlInferior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblTituloSuperior As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMarcador As Button
    Friend WithEvents btnSubrayar As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnVoz As Button
    Friend WithEvents txtLectura As RichTextBox
    Friend WithEvents pnlInferior As Panel
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lblPagina As Label
End Class