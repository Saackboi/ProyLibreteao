<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBibliotecario
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
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.PanelEncabezado = New System.Windows.Forms.Panel()
        Me.tlpEncabezado = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTituloMenuEncabezado = New System.Windows.Forms.Label()
        Me.lblTituloEncabezado = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelNavegacion = New System.Windows.Forms.Panel()
        Me.scNav = New System.Windows.Forms.SplitContainer()
        Me.scMenu = New System.Windows.Forms.SplitContainer()
        Me.MenuStripMenuNavegacion = New System.Windows.Forms.MenuStrip()
        Me.btn_NavInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavLIBROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavPRESTAMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavMENSAJERÍAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavVISTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavREPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavSOLICITUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UccReportes11 = New ProyLibreteao.UCCReportes1()
        Me.PanelContenido.SuspendLayout()
        Me.PanelEncabezado.SuspendLayout()
        Me.tlpEncabezado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.scNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scNav.Panel2.SuspendLayout()
        Me.scNav.SuspendLayout()
        CType(Me.scMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMenu.Panel1.SuspendLayout()
        Me.scMenu.SuspendLayout()
        Me.MenuStripMenuNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenido
        '
        Me.PanelContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenido.Controls.Add(Me.UccReportes11)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(280, 105)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelContenido.Size = New System.Drawing.Size(892, 547)
        Me.PanelContenido.TabIndex = 2
        '
        'PanelEncabezado
        '
        Me.PanelEncabezado.AutoScroll = True
        Me.PanelEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelEncabezado.Controls.Add(Me.tlpEncabezado)
        Me.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEncabezado.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEncabezado.Location = New System.Drawing.Point(280, 0)
        Me.PanelEncabezado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelEncabezado.Name = "PanelEncabezado"
        Me.PanelEncabezado.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEncabezado.Size = New System.Drawing.Size(892, 105)
        Me.PanelEncabezado.TabIndex = 1
        '
        'tlpEncabezado
        '
        Me.tlpEncabezado.AutoSize = True
        Me.tlpEncabezado.ColumnCount = 4
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.358!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.642!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tlpEncabezado.Controls.Add(Me.lblTituloMenuEncabezado, 1, 0)
        Me.tlpEncabezado.Controls.Add(Me.lblTituloEncabezado, 2, 0)
        Me.tlpEncabezado.Controls.Add(Me.PictureBox2, 0, 0)
        Me.tlpEncabezado.Controls.Add(Me.PictureBox1, 3, 0)
        Me.tlpEncabezado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEncabezado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpEncabezado.Location = New System.Drawing.Point(4, 5)
        Me.tlpEncabezado.Name = "tlpEncabezado"
        Me.tlpEncabezado.RowCount = 1
        Me.tlpEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEncabezado.Size = New System.Drawing.Size(884, 95)
        Me.tlpEncabezado.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.ProyLibreteao.My.Resources.Resources.icono_user
        Me.PictureBox1.Location = New System.Drawing.Point(812, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTituloMenuEncabezado
        '
        Me.lblTituloMenuEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloMenuEncabezado.Location = New System.Drawing.Point(192, 0)
        Me.lblTituloMenuEncabezado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloMenuEncabezado.Name = "lblTituloMenuEncabezado"
        Me.lblTituloMenuEncabezado.Size = New System.Drawing.Size(132, 55)
        Me.lblTituloMenuEncabezado.TabIndex = 0
        Me.lblTituloMenuEncabezado.Text = "REPORTES"
        Me.lblTituloMenuEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTituloEncabezado
        '
        Me.lblTituloEncabezado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTituloEncabezado.AutoSize = True
        Me.lblTituloEncabezado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTituloEncabezado.Location = New System.Drawing.Point(586, 0)
        Me.lblTituloEncabezado.Name = "lblTituloEncabezado"
        Me.lblTituloEncabezado.Size = New System.Drawing.Size(190, 32)
        Me.lblTituloEncabezado.TabIndex = 0
        Me.lblTituloEncabezado.Text = "BIBLIOTECARIO"
        Me.lblTituloEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.PictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelNavegacion
        '
        Me.PanelNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelNavegacion.Controls.Add(Me.scNav)
        Me.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNavegacion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.PanelNavegacion.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.PanelNavegacion.Name = "PanelNavegacion"
        Me.PanelNavegacion.Size = New System.Drawing.Size(280, 652)
        Me.PanelNavegacion.TabIndex = 0
        '
        'scNav
        '
        Me.scNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scNav.Location = New System.Drawing.Point(0, 0)
        Me.scNav.Name = "scNav"
        Me.scNav.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scNav.Panel2
        '
        Me.scNav.Panel2.Controls.Add(Me.scMenu)
        Me.scNav.Size = New System.Drawing.Size(280, 652)
        Me.scNav.SplitterDistance = 92
        Me.scNav.SplitterWidth = 1
        Me.scNav.TabIndex = 4
        '
        'scMenu
        '
        Me.scMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMenu.IsSplitterFixed = True
        Me.scMenu.Location = New System.Drawing.Point(0, 0)
        Me.scMenu.Name = "scMenu"
        Me.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMenu.Panel1
        '
        Me.scMenu.Panel1.Controls.Add(Me.MenuStripMenuNavegacion)
        Me.scMenu.Size = New System.Drawing.Size(280, 559)
        Me.scMenu.SplitterDistance = 459
        Me.scMenu.TabIndex = 0
        '
        'MenuStripMenuNavegacion
        '
        Me.MenuStripMenuNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MenuStripMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStripMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripMenuNavegacion.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStripMenuNavegacion.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStripMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_NavInicioToolStripMenuItem, Me.btn_NavLIBROSToolStripMenuItem, Me.btn_NavPRESTAMOSToolStripMenuItem, Me.btn_NavMENSAJERÍAToolStripMenuItem, Me.btn_NavCLIENTESToolStripMenuItem, Me.btn_NavVISTASToolStripMenuItem, Me.btn_NavREPORTESToolStripMenuItem, Me.btn_NavSOLICITUDToolStripMenuItem, Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem, Me.btn_NavCONSULTASToolStripMenuItem})
        Me.MenuStripMenuNavegacion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStripMenuNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMenuNavegacion.Name = "MenuStripMenuNavegacion"
        Me.MenuStripMenuNavegacion.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStripMenuNavegacion.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripMenuNavegacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStripMenuNavegacion.ShowItemToolTips = True
        Me.MenuStripMenuNavegacion.Size = New System.Drawing.Size(280, 459)
        Me.MenuStripMenuNavegacion.TabIndex = 4
        Me.MenuStripMenuNavegacion.Text = "MenuStrip1"
        '
        'btn_NavInicioToolStripMenuItem
        '
        Me.btn_NavInicioToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoInicio
        Me.btn_NavInicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.Name = "btn_NavInicioToolStripMenuItem"
        Me.btn_NavInicioToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavInicioToolStripMenuItem.Text = "INICO"
        Me.btn_NavInicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.ToolTipText = "Ir a inicio de página " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_NavLIBROSToolStripMenuItem
        '
        Me.btn_NavLIBROSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoLibros
        Me.btn_NavLIBROSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.Name = "btn_NavLIBROSToolStripMenuItem"
        Me.btn_NavLIBROSToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavLIBROSToolStripMenuItem.Text = "LIBROS "
        Me.btn_NavLIBROSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.ToolTipText = "Ver Libros disponibles "
        '
        'btn_NavPRESTAMOSToolStripMenuItem
        '
        Me.btn_NavPRESTAMOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.btn_NavPRESTAMOSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoPrestamo
        Me.btn_NavPRESTAMOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.Name = "btn_NavPRESTAMOSToolStripMenuItem"
        Me.btn_NavPRESTAMOSToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavPRESTAMOSToolStripMenuItem.Text = "PRESTAMOS "
        Me.btn_NavPRESTAMOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.ToolTipText = "Ver prestamos realizados "
        '
        'btn_NavMENSAJERÍAToolStripMenuItem
        '
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconomensajería
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Name = "btn_NavMENSAJERÍAToolStripMenuItem"
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Text = "MENSAJERÍA "
        Me.btn_NavMENSAJERÍAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ToolTipText = "Ver mensajes "
        '
        'btn_NavCLIENTESToolStripMenuItem
        '
        Me.btn_NavCLIENTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoClientes
        Me.btn_NavCLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.Name = "btn_NavCLIENTESToolStripMenuItem"
        Me.btn_NavCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavCLIENTESToolStripMenuItem.Text = "CLIENTES"
        Me.btn_NavCLIENTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.ToolTipText = "Ver Clientes "
        '
        'btn_NavVISTASToolStripMenuItem
        '
        Me.btn_NavVISTASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoVista
        Me.btn_NavVISTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavVISTASToolStripMenuItem.Name = "btn_NavVISTASToolStripMenuItem"
        Me.btn_NavVISTASToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavVISTASToolStripMenuItem.Text = "VISTAS"
        Me.btn_NavVISTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavREPORTESToolStripMenuItem
        '
        Me.btn_NavREPORTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.btn_NavREPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavREPORTESToolStripMenuItem.Name = "btn_NavREPORTESToolStripMenuItem"
        Me.btn_NavREPORTESToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavREPORTESToolStripMenuItem.Text = "REPORTES"
        Me.btn_NavREPORTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavSOLICITUDToolStripMenuItem
        '
        Me.btn_NavSOLICITUDToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoSolicitud
        Me.btn_NavSOLICITUDToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.Name = "btn_NavSOLICITUDToolStripMenuItem"
        Me.btn_NavSOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavSOLICITUDToolStripMenuItem.Text = "SOLICITUD DE LIBROS "
        Me.btn_NavSOLICITUDToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.ToolTipText = "Ver Solisitudes de los Clientes"
        '
        'btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem
        '
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoLibro
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Name = "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Text = "GESTIÓN DE CATÁLOGOS"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ToolTipText = "Ver Catálogos disponibles"
        '
        'btn_NavCONSULTASToolStripMenuItem
        '
        Me.btn_NavCONSULTASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoPreguntas
        Me.btn_NavCONSULTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCONSULTASToolStripMenuItem.Name = "btn_NavCONSULTASToolStripMenuItem"
        Me.btn_NavCONSULTASToolStripMenuItem.Size = New System.Drawing.Size(267, 29)
        Me.btn_NavCONSULTASToolStripMenuItem.Text = "CONSULTAS"
        Me.btn_NavCONSULTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UccReportes11
        '
        Me.UccReportes11.AutoSize = True
        Me.UccReportes11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UccReportes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UccReportes11.Location = New System.Drawing.Point(3, 3)
        Me.UccReportes11.Margin = New System.Windows.Forms.Padding(2)
        Me.UccReportes11.Name = "UccReportes11"
        Me.UccReportes11.Size = New System.Drawing.Size(882, 537)
        Me.UccReportes11.TabIndex = 0
        '
        'FormBibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 652)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelEncabezado)
        Me.Controls.Add(Me.PanelNavegacion)
        Me.MinimumSize = New System.Drawing.Size(1194, 708)
        Me.Name = "FormBibliotecario"
        Me.Text = "Formulario Bibliotecario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        Me.PanelEncabezado.ResumeLayout(False)
        Me.PanelEncabezado.PerformLayout()
        Me.tlpEncabezado.ResumeLayout(False)
        Me.tlpEncabezado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.scNav.Panel2.ResumeLayout(False)
        CType(Me.scNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scNav.ResumeLayout(False)
        Me.scMenu.Panel1.ResumeLayout(False)
        Me.scMenu.Panel1.PerformLayout()
        CType(Me.scMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMenu.ResumeLayout(False)
        Me.MenuStripMenuNavegacion.ResumeLayout(False)
        Me.MenuStripMenuNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelNavegacion As Panel
    Friend WithEvents PanelEncabezado As Panel
    Friend WithEvents tlpEncabezado As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTituloMenuEncabezado As Label
    Friend WithEvents lblTituloEncabezado As Label
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents scNav As SplitContainer
    Friend WithEvents scMenu As SplitContainer
    Friend WithEvents MenuStripMenuNavegacion As MenuStrip
    Friend WithEvents btn_NavInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavLIBROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavPRESTAMOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavMENSAJERÍAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavVISTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavREPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavSOLICITUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCONSULTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UccReportes11 As UCCReportes1
End Class
