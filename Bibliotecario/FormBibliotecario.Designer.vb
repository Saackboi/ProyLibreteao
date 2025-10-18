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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.tlpReporte = New System.Windows.Forms.TableLayoutPanel()
        Me.tcContenidoReportes = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblTituloTabControl = New System.Windows.Forms.Label()
        Me.PanelEncabezado = New System.Windows.Forms.Panel()
        Me.tlpEncabezado = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloMenuEncabezado = New System.Windows.Forms.Label()
        Me.lblTituloEncabezado = New System.Windows.Forms.Label()
        Me.pb2seccionMenuNav = New System.Windows.Forms.PictureBox()
        Me.pb1Perfil = New System.Windows.Forms.PictureBox()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnFiltroReporteAS = New System.Windows.Forms.Button()
        Me.dgvTablaInfoReporte = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tlpActividadSemenal = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelContenido.SuspendLayout()
        Me.tlpReporte.SuspendLayout()
        Me.tcContenidoReportes.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.PanelEncabezado.SuspendLayout()
        Me.tlpEncabezado.SuspendLayout()
        CType(Me.pb2seccionMenuNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.scNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scNav.Panel2.SuspendLayout()
        Me.scNav.SuspendLayout()
        CType(Me.scMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMenu.Panel1.SuspendLayout()
        Me.scMenu.SuspendLayout()
        Me.MenuStripMenuNavegacion.SuspendLayout()
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpActividadSemenal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenido
        '
        Me.PanelContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenido.Controls.Add(Me.tlpReporte)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(280, 105)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelContenido.Size = New System.Drawing.Size(1345, 839)
        Me.PanelContenido.TabIndex = 2
        '
        'tlpReporte
        '
        Me.tlpReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tlpReporte.ColumnCount = 1
        Me.tlpReporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpReporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpReporte.Controls.Add(Me.tcContenidoReportes, 0, 1)
        Me.tlpReporte.Controls.Add(Me.lblTituloTabControl, 0, 0)
        Me.tlpReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpReporte.Location = New System.Drawing.Point(3, 3)
        Me.tlpReporte.Name = "tlpReporte"
        Me.tlpReporte.RowCount = 2
        Me.tlpReporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03086!))
        Me.tlpReporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.96914!))
        Me.tlpReporte.Size = New System.Drawing.Size(1335, 829)
        Me.tlpReporte.TabIndex = 2
        '
        'tcContenidoReportes
        '
        Me.tcContenidoReportes.Controls.Add(Me.TabPage1)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage2)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage3)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage4)
        Me.tcContenidoReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcContenidoReportes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tcContenidoReportes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcContenidoReportes.HotTrack = True
        Me.tcContenidoReportes.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.tcContenidoReportes.Location = New System.Drawing.Point(2, 85)
        Me.tcContenidoReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.tcContenidoReportes.Multiline = True
        Me.tcContenidoReportes.Name = "tcContenidoReportes"
        Me.tcContenidoReportes.SelectedIndex = 0
        Me.tcContenidoReportes.Size = New System.Drawing.Size(1331, 742)
        Me.tcContenidoReportes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tcContenidoReportes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Controls.Add(Me.tlpActividadSemenal)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Purple
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1323, 704)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actividad Semanal"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.ForeColor = System.Drawing.Color.Purple
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1323, 704)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Libros Más Solicitados "
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.ForeColor = System.Drawing.Color.Purple
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1323, 704)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Multas Por Usuario"
        '
        'lblTituloTabControl
        '
        Me.lblTituloTabControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTituloTabControl.AutoSize = True
        Me.lblTituloTabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTabControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTituloTabControl.Location = New System.Drawing.Point(601, 0)
        Me.lblTituloTabControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloTabControl.Name = "lblTituloTabControl"
        Me.lblTituloTabControl.Size = New System.Drawing.Size(133, 83)
        Me.lblTituloTabControl.TabIndex = 0
        Me.lblTituloTabControl.Text = "BIENVENIDA"
        Me.lblTituloTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PanelEncabezado.Size = New System.Drawing.Size(1345, 105)
        Me.PanelEncabezado.TabIndex = 1
        '
        'tlpEncabezado
        '
        Me.tlpEncabezado.AutoSize = True
        Me.tlpEncabezado.ColumnCount = 4
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27596!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.72404!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.tlpEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.tlpEncabezado.Controls.Add(Me.lblTituloMenuEncabezado, 1, 0)
        Me.tlpEncabezado.Controls.Add(Me.lblTituloEncabezado, 2, 0)
        Me.tlpEncabezado.Controls.Add(Me.pb2seccionMenuNav, 0, 0)
        Me.tlpEncabezado.Controls.Add(Me.pb1Perfil, 3, 0)
        Me.tlpEncabezado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEncabezado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpEncabezado.Location = New System.Drawing.Point(4, 5)
        Me.tlpEncabezado.Name = "tlpEncabezado"
        Me.tlpEncabezado.RowCount = 1
        Me.tlpEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEncabezado.Size = New System.Drawing.Size(1337, 95)
        Me.tlpEncabezado.TabIndex = 1
        '
        'lblTituloMenuEncabezado
        '
        Me.lblTituloMenuEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTituloMenuEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloMenuEncabezado.Location = New System.Drawing.Point(117, 20)
        Me.lblTituloMenuEncabezado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloMenuEncabezado.Name = "lblTituloMenuEncabezado"
        Me.lblTituloMenuEncabezado.Size = New System.Drawing.Size(494, 55)
        Me.lblTituloMenuEncabezado.TabIndex = 0
        Me.lblTituloMenuEncabezado.Text = "REPORTES"
        Me.lblTituloMenuEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTituloEncabezado
        '
        Me.lblTituloEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTituloEncabezado.AutoSize = True
        Me.lblTituloEncabezado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTituloEncabezado.Location = New System.Drawing.Point(1029, 31)
        Me.lblTituloEncabezado.Name = "lblTituloEncabezado"
        Me.lblTituloEncabezado.Size = New System.Drawing.Size(190, 32)
        Me.lblTituloEncabezado.TabIndex = 0
        Me.lblTituloEncabezado.Text = "BIBLIOTECARIO"
        Me.lblTituloEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb2seccionMenuNav
        '
        Me.pb2seccionMenuNav.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb2seccionMenuNav.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.pb2seccionMenuNav.Location = New System.Drawing.Point(4, 21)
        Me.pb2seccionMenuNav.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pb2seccionMenuNav.Name = "pb2seccionMenuNav"
        Me.pb2seccionMenuNav.Size = New System.Drawing.Size(87, 52)
        Me.pb2seccionMenuNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2seccionMenuNav.TabIndex = 0
        Me.pb2seccionMenuNav.TabStop = False
        '
        'pb1Perfil
        '
        Me.pb1Perfil.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pb1Perfil.Image = Global.ProyLibreteao.My.Resources.Resources.icono_user
        Me.pb1Perfil.Location = New System.Drawing.Point(1265, 24)
        Me.pb1Perfil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pb1Perfil.Name = "pb1Perfil"
        Me.pb1Perfil.Size = New System.Drawing.Size(68, 46)
        Me.pb1Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1Perfil.TabIndex = 0
        Me.pb1Perfil.TabStop = False
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
        Me.PanelNavegacion.Size = New System.Drawing.Size(280, 944)
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
        Me.scNav.Size = New System.Drawing.Size(280, 944)
        Me.scNav.SplitterDistance = 133
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
        Me.scMenu.Size = New System.Drawing.Size(280, 810)
        Me.scMenu.SplitterDistance = 665
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
        Me.MenuStripMenuNavegacion.Size = New System.Drawing.Size(280, 665)
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Purple
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1323, 704)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resumen De Informe "
        '
        'btnFiltroReporteAS
        '
        Me.btnFiltroReporteAS.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltroReporteAS.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltroReporteAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnFiltroReporteAS.Image = Global.ProyLibreteao.My.Resources.Resources.iconoFiltro
        Me.btnFiltroReporteAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltroReporteAS.Location = New System.Drawing.Point(3, 3)
        Me.btnFiltroReporteAS.Name = "btnFiltroReporteAS"
        Me.btnFiltroReporteAS.Size = New System.Drawing.Size(118, 36)
        Me.btnFiltroReporteAS.TabIndex = 3
        Me.btnFiltroReporteAS.Text = "Filtros"
        Me.btnFiltroReporteAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltroReporteAS.UseVisualStyleBackColor = False
        '
        'dgvTablaInfoReporte
        '
        Me.dgvTablaInfoReporte.AllowUserToAddRows = False
        Me.dgvTablaInfoReporte.AllowUserToDeleteRows = False
        Me.dgvTablaInfoReporte.AllowUserToResizeColumns = False
        Me.dgvTablaInfoReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTablaInfoReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTablaInfoReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTablaInfoReporte.BackgroundColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTablaInfoReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTablaInfoReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTablaInfoReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTablaInfoReporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTablaInfoReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTablaInfoReporte.EnableHeadersVisualStyles = False
        Me.dgvTablaInfoReporte.GridColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.Location = New System.Drawing.Point(3, 60)
        Me.dgvTablaInfoReporte.Name = "dgvTablaInfoReporte"
        Me.dgvTablaInfoReporte.ReadOnly = True
        Me.dgvTablaInfoReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTablaInfoReporte.RowHeadersVisible = False
        Me.dgvTablaInfoReporte.RowHeadersWidth = 62
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTablaInfoReporte.RowTemplate.Height = 28
        Me.dgvTablaInfoReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablaInfoReporte.Size = New System.Drawing.Size(1080, 475)
        Me.dgvTablaInfoReporte.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1129, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Descargar Reportes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tlpActividadSemenal
        '
        Me.tlpActividadSemenal.AllowDrop = True
        Me.tlpActividadSemenal.BackColor = System.Drawing.Color.White
        Me.tlpActividadSemenal.ColumnCount = 2
        Me.tlpActividadSemenal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.38573!))
        Me.tlpActividadSemenal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.61427!))
        Me.tlpActividadSemenal.Controls.Add(Me.Button1, 1, 0)
        Me.tlpActividadSemenal.Controls.Add(Me.dgvTablaInfoReporte, 0, 1)
        Me.tlpActividadSemenal.Controls.Add(Me.btnFiltroReporteAS, 0, 0)
        Me.tlpActividadSemenal.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpActividadSemenal.Location = New System.Drawing.Point(2, 2)
        Me.tlpActividadSemenal.Name = "tlpActividadSemenal"
        Me.tlpActividadSemenal.RowCount = 2
        Me.tlpActividadSemenal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpActividadSemenal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481.0!))
        Me.tlpActividadSemenal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpActividadSemenal.Size = New System.Drawing.Size(1319, 538)
        Me.tlpActividadSemenal.TabIndex = 1
        '
        'FormBibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1625, 944)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelEncabezado)
        Me.Controls.Add(Me.PanelNavegacion)
        Me.MinimumSize = New System.Drawing.Size(1194, 708)
        Me.Name = "FormBibliotecario"
        Me.Text = "Formulario Bibliotecario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContenido.ResumeLayout(False)
        Me.tlpReporte.ResumeLayout(False)
        Me.tlpReporte.PerformLayout()
        Me.tcContenidoReportes.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.PanelEncabezado.ResumeLayout(False)
        Me.PanelEncabezado.PerformLayout()
        Me.tlpEncabezado.ResumeLayout(False)
        Me.tlpEncabezado.PerformLayout()
        CType(Me.pb2seccionMenuNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1Perfil, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpActividadSemenal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelNavegacion As Panel
    Friend WithEvents PanelEncabezado As Panel
    Friend WithEvents tlpEncabezado As TableLayoutPanel
    Friend WithEvents pb1Perfil As PictureBox
    Friend WithEvents pb2seccionMenuNav As PictureBox
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
    Friend WithEvents tlpReporte As TableLayoutPanel
    Friend WithEvents tcContenidoReportes As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblTituloTabControl As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tlpActividadSemenal As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvTablaInfoReporte As DataGridView
    Friend WithEvents btnFiltroReporteAS As Button
End Class
