<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interface_Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interface_Administrador))
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.PanelEncabezado = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloMenuEncabezado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb1MenuNav = New System.Windows.Forms.PictureBox()
        Me.pb2Perfil = New System.Windows.Forms.PictureBox()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.msMenuNavegacion = New System.Windows.Forms.MenuStrip()
        Me.btn_NavInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavLIBROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavPRESTAMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCATEGORIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavAUTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavREPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavSOLICITUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PanelBase.SuspendLayout()
        Me.PanelEncabezado.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.pb1MenuNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.msMenuNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBase
        '
        Me.PanelBase.BackColor = System.Drawing.Color.White
        Me.PanelBase.Controls.Add(Me.PanelContenido)
        Me.PanelBase.Controls.Add(Me.PanelEncabezado)
        Me.PanelBase.Controls.Add(Me.PanelNav)
        Me.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBase.Location = New System.Drawing.Point(0, 0)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(1178, 679)
        Me.PanelBase.TabIndex = 3
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.White
        Me.PanelContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(218, 89)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelContenido.Size = New System.Drawing.Size(960, 590)
        Me.PanelContenido.TabIndex = 3
        '
        'PanelEncabezado
        '
        Me.PanelEncabezado.AutoScroll = True
        Me.PanelEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelEncabezado.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEncabezado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEncabezado.Location = New System.Drawing.Point(218, 0)
        Me.PanelEncabezado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelEncabezado.Name = "PanelEncabezado"
        Me.PanelEncabezado.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEncabezado.Size = New System.Drawing.Size(960, 89)
        Me.PanelEncabezado.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.44776!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.55224!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblTituloMenuEncabezado, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.pb1MenuNav, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.pb2Perfil, 3, 0)
        Me.TableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(952, 79)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblTituloMenuEncabezado
        '
        Me.lblTituloMenuEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTituloMenuEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloMenuEncabezado.Location = New System.Drawing.Point(71, 24)
        Me.lblTituloMenuEncabezado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloMenuEncabezado.Name = "lblTituloMenuEncabezado"
        Me.lblTituloMenuEncabezado.Size = New System.Drawing.Size(314, 31)
        Me.lblTituloMenuEncabezado.TabIndex = 0
        Me.lblTituloMenuEncabezado.Text = "ÁREA ADMINISTRATIVA"
        Me.lblTituloMenuEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(665, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BIBLIOTECARIO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb1MenuNav
        '
        Me.pb1MenuNav.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb1MenuNav.Image = Global.ProyLibreteao.My.Resources.Resources.iconoLibro
        Me.pb1MenuNav.Location = New System.Drawing.Point(4, 19)
        Me.pb1MenuNav.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pb1MenuNav.Name = "pb1MenuNav"
        Me.pb1MenuNav.Size = New System.Drawing.Size(54, 40)
        Me.pb1MenuNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1MenuNav.TabIndex = 0
        Me.pb1MenuNav.TabStop = False
        '
        'pb2Perfil
        '
        Me.pb2Perfil.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pb2Perfil.Image = Global.ProyLibreteao.My.Resources.Resources.icono_user
        Me.pb2Perfil.Location = New System.Drawing.Point(888, 18)
        Me.pb2Perfil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pb2Perfil.Name = "pb2Perfil"
        Me.pb2Perfil.Size = New System.Drawing.Size(60, 43)
        Me.pb2Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2Perfil.TabIndex = 0
        Me.pb2Perfil.TabStop = False
        '
        'PanelNav
        '
        Me.PanelNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelNav.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(218, 679)
        Me.PanelNav.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.msMenuNavegacion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSalir, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23549!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.7645!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(218, 679)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'msMenuNavegacion
        '
        Me.msMenuNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.msMenuNavegacion.Dock = System.Windows.Forms.DockStyle.None
        Me.msMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenuNavegacion.GripMargin = New System.Windows.Forms.Padding(2)
        Me.msMenuNavegacion.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.msMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_NavInicioToolStripMenuItem, Me.btn_NavLIBROSToolStripMenuItem, Me.btn_NavPRESTAMOSToolStripMenuItem, Me.btn_NavCATEGORIASToolStripMenuItem, Me.NavAUTORESToolStripMenuItem, Me.btn_NavCLIENTESToolStripMenuItem, Me.btn_NavREPORTESToolStripMenuItem, Me.btn_NavSOLICITUDToolStripMenuItem, Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem, Me.btn_NavCONSULTASToolStripMenuItem})
        Me.msMenuNavegacion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.msMenuNavegacion.Location = New System.Drawing.Point(8, 109)
        Me.msMenuNavegacion.Margin = New System.Windows.Forms.Padding(5)
        Me.msMenuNavegacion.Name = "msMenuNavegacion"
        Me.msMenuNavegacion.Padding = New System.Windows.Forms.Padding(0)
        Me.msMenuNavegacion.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMenuNavegacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msMenuNavegacion.ShowItemToolTips = True
        Me.msMenuNavegacion.Size = New System.Drawing.Size(202, 358)
        Me.msMenuNavegacion.TabIndex = 4
        '
        'btn_NavInicioToolStripMenuItem
        '
        Me.btn_NavInicioToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoInicio
        Me.btn_NavInicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavInicioToolStripMenuItem.Name = "btn_NavInicioToolStripMenuItem"
        Me.btn_NavInicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btn_NavInicioToolStripMenuItem.Size = New System.Drawing.Size(195, 35)
        Me.btn_NavInicioToolStripMenuItem.Text = "INICIO"
        Me.btn_NavInicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.ToolTipText = "Ir a inicio de página " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_NavLIBROSToolStripMenuItem
        '
        Me.btn_NavLIBROSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoLibros
        Me.btn_NavLIBROSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavLIBROSToolStripMenuItem.Name = "btn_NavLIBROSToolStripMenuItem"
        Me.btn_NavLIBROSToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavLIBROSToolStripMenuItem.Text = "LIBROS "
        Me.btn_NavLIBROSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.ToolTipText = "Ver Libros disponibles "
        '
        'btn_NavPRESTAMOSToolStripMenuItem
        '
        Me.btn_NavPRESTAMOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.btn_NavPRESTAMOSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoPrestamo
        Me.btn_NavPRESTAMOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavPRESTAMOSToolStripMenuItem.Name = "btn_NavPRESTAMOSToolStripMenuItem"
        Me.btn_NavPRESTAMOSToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavPRESTAMOSToolStripMenuItem.Text = "PRESTAMOS "
        Me.btn_NavPRESTAMOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.ToolTipText = "Ver préstamos realizados "
        '
        'btn_NavCATEGORIASToolStripMenuItem
        '
        Me.btn_NavCATEGORIASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoCategoria
        Me.btn_NavCATEGORIASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCATEGORIASToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavCATEGORIASToolStripMenuItem.Name = "btn_NavCATEGORIASToolStripMenuItem"
        Me.btn_NavCATEGORIASToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavCATEGORIASToolStripMenuItem.Text = "CATEGORIAS"
        Me.btn_NavCATEGORIASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NavAUTORESToolStripMenuItem
        '
        Me.NavAUTORESToolStripMenuItem.Image = CType(resources.GetObject("NavAUTORESToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NavAUTORESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NavAUTORESToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.NavAUTORESToolStripMenuItem.Name = "NavAUTORESToolStripMenuItem"
        Me.NavAUTORESToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.NavAUTORESToolStripMenuItem.Text = "AUTORES"
        Me.NavAUTORESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NavAUTORESToolStripMenuItem.ToolTipText = "Ver mensajes "
        '
        'btn_NavCLIENTESToolStripMenuItem
        '
        Me.btn_NavCLIENTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoClientes
        Me.btn_NavCLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavCLIENTESToolStripMenuItem.Name = "btn_NavCLIENTESToolStripMenuItem"
        Me.btn_NavCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavCLIENTESToolStripMenuItem.Text = "CLIENTES"
        Me.btn_NavCLIENTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.ToolTipText = "Ver Clientes "
        '
        'btn_NavREPORTESToolStripMenuItem
        '
        Me.btn_NavREPORTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.btn_NavREPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavREPORTESToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavREPORTESToolStripMenuItem.Name = "btn_NavREPORTESToolStripMenuItem"
        Me.btn_NavREPORTESToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavREPORTESToolStripMenuItem.Text = "REPORTES"
        Me.btn_NavREPORTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavSOLICITUDToolStripMenuItem
        '
        Me.btn_NavSOLICITUDToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoSolicitud
        Me.btn_NavSOLICITUDToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavSOLICITUDToolStripMenuItem.Name = "btn_NavSOLICITUDToolStripMenuItem"
        Me.btn_NavSOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavSOLICITUDToolStripMenuItem.Text = "SOLICITUD DE LIBROS "
        Me.btn_NavSOLICITUDToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.ToolTipText = "Ver Solicitudes de los Clientes"
        '
        'btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem
        '
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoGestionarCatálogo
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Name = "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Text = "GESTIÓN DE CATÁLOGOS"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ToolTipText = "Ver Catálogos disponibles"
        '
        'btn_NavCONSULTASToolStripMenuItem
        '
        Me.btn_NavCONSULTASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoPreguntas
        Me.btn_NavCONSULTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCONSULTASToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3)
        Me.btn_NavCONSULTASToolStripMenuItem.Name = "btn_NavCONSULTASToolStripMenuItem"
        Me.btn_NavCONSULTASToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.btn_NavCONSULTASToolStripMenuItem.Text = "CONSULTAS"
        Me.btn_NavCONSULTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(5, 629)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(208, 45)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "❌ Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Interface_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 679)
        Me.Controls.Add(Me.PanelBase)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1194, 718)
        Me.Name = "Interface_Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario  Administrativo"
        Me.PanelBase.ResumeLayout(False)
        Me.PanelEncabezado.ResumeLayout(False)
        Me.PanelEncabezado.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.pb1MenuNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNav.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.msMenuNavegacion.ResumeLayout(False)
        Me.msMenuNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents PanelEncabezado As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblTituloMenuEncabezado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pb1MenuNav As PictureBox
    Friend WithEvents pb2Perfil As PictureBox
    Friend WithEvents msMenuNavegacion As MenuStrip
    Friend WithEvents btn_NavInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavLIBROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavPRESTAMOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavAUTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCATEGORIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavREPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavSOLICITUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCONSULTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelNav As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnSalir As Button
End Class
