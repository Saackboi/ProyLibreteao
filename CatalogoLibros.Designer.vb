Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatalogoLibros
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
        ' PALETA DE COLORES AMIGABLE PARA NIÑOS
        Dim ColorFondoPrincipal As Color = Color.FromArgb(CType(230, Byte), CType(245, Byte), CType(255, Byte)) ' Azul muy claro / Cielo
        Dim ColorEncabezado As Color = Color.FromArgb(CType(79, Byte), CType(150, Byte), CType(205, Byte)) ' Azul Mediano (Cielo)
        Dim ColorAcentoPrincipal As Color = Color.FromArgb(CType(255, Byte), CType(165, Byte), CType(0, Byte)) ' Naranja brillante
        Dim ColorAcentoSecundario As Color = Color.FromArgb(CType(230, Byte), CType(70, Byte), CType(70, Byte)) ' Rojo Amigable

        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fest5 = New System.Windows.Forms.CheckBox()
        Me.fest4 = New System.Windows.Forms.CheckBox()
        Me.fest3 = New System.Windows.Forms.CheckBox()
        Me.fest2 = New System.Windows.Forms.CheckBox()
        Me.fest1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelContenedorLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelLateral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = Color.White
        Me.PanelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLateral.Controls.Add(Me.btnRegistrarse)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.Label3)
        Me.PanelLateral.Controls.Add(Me.btnRegresar)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.ForeColor = System.Drawing.Color.Gray
        Me.PanelLateral.Location = New System.Drawing.Point(0, 70)
        Me.PanelLateral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(221, 555)
        Me.PanelLateral.TabIndex = 0
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrarse.BackColor = ColorAcentoPrincipal ' Naranja Brillante
        Me.btnRegistrarse.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold) ' Fuente Amigable
        Me.btnRegistrarse.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarse.Location = New System.Drawing.Point(17, 411)
        Me.btnRegistrarse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(183, 58) ' Más Grande
        Me.btnRegistrarse.TabIndex = 5
        Me.btnRegistrarse.Text = "¡QUIERO REGISTRARME!"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        Me.btnRegistrarse.FlatStyle = FlatStyle.Flat ' Estilo más plano
        Me.btnRegistrarse.FlatAppearance.BorderSize = 0 ' Sin borde
        '
        'Panel2 (FILTROS DE ESTRELLAS)
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = ColorFondoPrincipal ' Azul claro de fondo
        Me.Panel2.Controls.Add(Me.fest5)
        Me.Panel2.Controls.Add(Me.fest4)
        Me.Panel2.Controls.Add(Me.fest3)
        Me.Panel2.Controls.Add(Me.fest2)
        Me.Panel2.Controls.Add(Me.fest1)
        Me.Panel2.Location = New System.Drawing.Point(11, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 185) ' Más alto para separar checkboxes
        Me.Panel2.TabIndex = 4
        '
        'fest5
        '
        Me.fest5.AutoSize = True
        Me.fest5.Font = New System.Drawing.Font("Arial Black", 14.0!) ' Fuente fuerte
        Me.fest5.ForeColor = System.Drawing.Color.Gold ' Color de estrella
        Me.fest5.Location = New System.Drawing.Point(23, 138)
        Me.fest5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest5.Name = "fest5"
        Me.fest5.Size = New System.Drawing.Size(149, 37) ' Tamaño aumentado
        Me.fest5.TabIndex = 4
        Me.fest5.Text = "★★★★★"
        Me.fest5.UseVisualStyleBackColor = True
        '
        'fest4
        '
        Me.fest4.AutoSize = True
        Me.fest4.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.fest4.ForeColor = System.Drawing.Color.Gold
        Me.fest4.Location = New System.Drawing.Point(23, 105)
        Me.fest4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest4.Name = "fest4"
        Me.fest4.Size = New System.Drawing.Size(125, 37)
        Me.fest4.TabIndex = 3
        Me.fest4.Text = "★★★★"
        Me.fest4.UseVisualStyleBackColor = True
        '
        'fest3
        '
        Me.fest3.AutoSize = True
        Me.fest3.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.fest3.ForeColor = System.Drawing.Color.Gold
        Me.fest3.Location = New System.Drawing.Point(23, 72)
        Me.fest3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest3.Name = "fest3"
        Me.fest3.Size = New System.Drawing.Size(101, 37)
        Me.fest3.TabIndex = 2
        Me.fest3.Text = "★★★"
        Me.fest3.UseVisualStyleBackColor = True
        '
        'fest2
        '
        Me.fest2.AutoSize = True
        Me.fest2.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.fest2.ForeColor = System.Drawing.Color.Gold
        Me.fest2.Location = New System.Drawing.Point(23, 39)
        Me.fest2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest2.Name = "fest2"
        Me.fest2.Size = New System.Drawing.Size(77, 37)
        Me.fest2.TabIndex = 1
        Me.fest2.Text = "★★"
        Me.fest2.UseVisualStyleBackColor = True
        '
        'fest1
        '
        Me.fest1.AutoSize = True
        Me.fest1.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.fest1.ForeColor = System.Drawing.Color.Gold
        Me.fest1.Location = New System.Drawing.Point(23, 6)
        Me.fest1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest1.Name = "fest1"
        Me.fest1.Size = New System.Drawing.Size(53, 37)
        Me.fest1.TabIndex = 0
        Me.fest1.Text = "★"
        Me.fest1.UseVisualStyleBackColor = True
        '
        'Label3 (FILTRO)
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = Color.FromArgb(CType(0, Byte), CType(128, Byte), CType(0, Byte)) ' Verde Amigable
        Me.Label3.Location = New System.Drawing.Point(13, 90) ' Baja un poco
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "¡Filtra!"
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.BackColor = ColorAcentoSecundario ' Rojo Amigable
        Me.btnRegresar.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(17, 489)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(183, 58) ' Más Grande
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "VOLVER"
        Me.btnRegresar.UseVisualStyleBackColor = False
        Me.btnRegresar.FlatStyle = FlatStyle.Flat
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        '
        'Panel1 (BUSCADOR)
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = ColorAcentoPrincipal ' Naranja
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Location = New System.Drawing.Point(11, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 48) ' Más grande
        Me.Panel1.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte)) ' Amarillo Brillante
        ' Mantengo la imagen de lupa, asumiendo que es amigable (Resources.Resources.buscar)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBuscar.Location = New System.Drawing.Point(155, 4)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(38, 38)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.UseVisualStyleBackColor = False
        Me.btnBuscar.FlatStyle = FlatStyle.Flat
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BackColor = Color.White
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscador.Font = New System.Drawing.Font("Comic Sans MS", 12.0!) ' Fuente Infantil
        Me.txtBuscador.ForeColor = System.Drawing.Color.Black
        Me.txtBuscador.Location = New System.Drawing.Point(7, 7)
        Me.txtBuscador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(143, 35) ' Más grande
        Me.txtBuscador.TabIndex = 0
        Me.txtBuscador.Text = "¡Busca aquí!"
        '
        'PanelSuperior (CABECERA)
        '
        Me.PanelSuperior.BackColor = ColorEncabezado ' Azul Cielo
        Me.PanelSuperior.Controls.Add(Me.PictureBox3)
        Me.PanelSuperior.Controls.Add(Me.lblUsuario)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Controls.Add(Me.Label2)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1084, 70)
        Me.PanelSuperior.TabIndex = 1
        '
        'PictureBox3 (Icono de Usuario)
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ' Asumiendo que Resources.Resources.user es un icono amigable de persona
        Me.PictureBox3.Location = New System.Drawing.Point(1021, 9)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(931, 20)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(84, 29)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Amig@!"
        '
        'PictureBox1 (Icono de Libro)
        '
        ' Asumiendo que Resources.Resources.iconVerlibro es un icono amigable de libro
        Me.PictureBox1.Location = New System.Drawing.Point(35, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2 (NOMBRE APP)
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mi Librería"
        '
        'Label1 (TÍTULO PRINCIPAL)
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 28.0!, System.Drawing.FontStyle.Bold) ' ¡Súper Grande!
        Me.Label1.ForeColor = Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte)) ' Amarillo brillante
        Me.Label1.Location = New System.Drawing.Point(400, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡Catálogo!"
        '
        'FlowLayoutPanelContenedorLibros (ÁREA PRINCIPAL)
        '
        Me.FlowLayoutPanelContenedorLibros.AutoScroll = True
        Me.FlowLayoutPanelContenedorLibros.BackColor = ColorFondoPrincipal ' Fondo Azul muy claro
        Me.FlowLayoutPanelContenedorLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelContenedorLibros.Location = New System.Drawing.Point(221, 70)
        Me.FlowLayoutPanelContenedorLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanelContenedorLibros.Name = "FlowLayoutPanelContenedorLibros"
        Me.FlowLayoutPanelContenedorLibros.Padding = New System.Windows.Forms.Padding(15, 15, 15, 15) ' Más padding
        Me.FlowLayoutPanelContenedorLibros.Size = New System.Drawing.Size(863, 555)
        Me.FlowLayoutPanelContenedorLibros.TabIndex = 2
        '
        'CatalogoLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 625)
        Me.Controls.Add(Me.FlowLayoutPanelContenedorLibros)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CatalogoLibros"
        Me.Text = "¡Mi Rincón de Libros!" ' Título de ventana amigable
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' Declaración de Controles
    Friend WithEvents PanelLateral As System.Windows.Forms.Panel
    Friend WithEvents PanelSuperior As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanelContenedorLibros As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents fest1 As CheckBox
    Friend WithEvents fest5 As CheckBox
    Friend WithEvents fest4 As CheckBox
    Friend WithEvents fest3 As CheckBox
    Friend WithEvents fest2 As CheckBox
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnBuscar As Button
End Class