<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interface_invitados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interface_invitados))
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblLibreria = New System.Windows.Forms.Label()
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkFiltro = New System.Windows.Forms.CheckedListBox()
        Me.lblFiltar = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.plLibro = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerlibro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlEncabezado.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLateral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.plLibro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.Black
        Me.pnlEncabezado.Controls.Add(Me.lblUsuario)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.picLogo)
        Me.pnlEncabezado.Controls.Add(Me.lblLibreria)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(1080, 80)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(976, 25)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(76, 23)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Invitado"
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(488, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(145, 41)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Catálogo"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(15, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(50, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lblLibreria
        '
        Me.lblLibreria.AutoSize = True
        Me.lblLibreria.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLibreria.ForeColor = System.Drawing.Color.White
        Me.lblLibreria.Location = New System.Drawing.Point(70, 26)
        Me.lblLibreria.Name = "lblLibreria"
        Me.lblLibreria.Size = New System.Drawing.Size(72, 23)
        Me.lblLibreria.TabIndex = 0
        Me.lblLibreria.Text = "Librería"
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.LightGray
        Me.pnlLateral.Controls.Add(Me.Panel1)
        Me.pnlLateral.Controls.Add(Me.btnRegistrar)
        Me.pnlLateral.Controls.Add(Me.btnRegresar)
        Me.pnlLateral.Controls.Add(Me.txtBuscar)
        Me.pnlLateral.Controls.Add(Me.btnFiltrar)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 80)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(250, 560)
        Me.pnlLateral.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkFiltro)
        Me.Panel1.Controls.Add(Me.lblFiltar)
        Me.Panel1.Location = New System.Drawing.Point(15, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 279)
        Me.Panel1.TabIndex = 8
        '
        'chkFiltro
        '
        Me.chkFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltro.FormattingEnabled = True
        Me.chkFiltro.Items.AddRange(New Object() {"★", "★★", "★★★", "★★★★", "★★★★★"})
        Me.chkFiltro.Location = New System.Drawing.Point(23, 53)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(158, 179)
        Me.chkFiltro.TabIndex = 1
        '
        'lblFiltar
        '
        Me.lblFiltar.AutoSize = True
        Me.lblFiltar.Location = New System.Drawing.Point(20, 20)
        Me.lblFiltar.Name = "lblFiltar"
        Me.lblFiltar.Size = New System.Drawing.Size(40, 16)
        Me.lblFiltar.TabIndex = 0
        Me.lblFiltar.Text = "Filtrar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(15, 433)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(220, 40)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrarse"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(15, 500)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(220, 40)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(15, 40)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(150, 27)
        Me.txtBuscar.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.DimGray
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrar.ForeColor = System.Drawing.Color.White
        Me.btnFiltrar.Location = New System.Drawing.Point(170, 38)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(65, 30)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "🔍"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'plLibro
        '
        Me.plLibro.Controls.Add(Me.Label4)
        Me.plLibro.Controls.Add(Me.Label3)
        Me.plLibro.Controls.Add(Me.Label2)
        Me.plLibro.Controls.Add(Me.Label1)
        Me.plLibro.Controls.Add(Me.btnVerlibro)
        Me.plLibro.Controls.Add(Me.PictureBox1)
        Me.plLibro.Location = New System.Drawing.Point(253, 80)
        Me.plLibro.Name = "plLibro"
        Me.plLibro.Size = New System.Drawing.Size(824, 172)
        Me.plLibro.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Emitido el 25/ 4/ 21"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ISBM: 9780739352984"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Paul Parsons"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Matemáticas en Segundos"
        '
        'btnVerlibro
        '
        Me.btnVerlibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerlibro.BackColor = System.Drawing.Color.Orange
        Me.btnVerlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerlibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVerlibro.ForeColor = System.Drawing.Color.White
        Me.btnVerlibro.Location = New System.Drawing.Point(640, 68)
        Me.btnVerlibro.Name = "btnVerlibro"
        Me.btnVerlibro.Size = New System.Drawing.Size(156, 42)
        Me.btnVerlibro.TabIndex = 9
        Me.btnVerlibro.Text = "Ver Libro"
        Me.btnVerlibro.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Interface_invitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 640)
        Me.Controls.Add(Me.plLibro)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlEncabezado)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Interface_invitados"
        Me.Text = "Catálogo de Libros"
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLateral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.plLibro.ResumeLayout(False)
        Me.plLibro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEncabezado As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLibreria As Label
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkFiltro As CheckedListBox
    Friend WithEvents lblFiltar As Label
    Friend WithEvents plLibro As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVerlibro As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class



