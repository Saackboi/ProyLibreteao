<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsultas
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
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.PanelEncabezado = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloMenuEncabezado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb2seccionMenuNav = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.scNav = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.msMenuNavegacion = New System.Windows.Forms.MenuStrip()
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
        Me.PanelBase.SuspendLayout()
        Me.PanelEncabezado.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.pb2seccionMenuNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNav.SuspendLayout()
        CType(Me.scNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scNav.Panel2.SuspendLayout()
        Me.scNav.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.PanelBase.Size = New System.Drawing.Size(1178, 702)
        Me.PanelBase.TabIndex = 4
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.White
        Me.PanelContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(280, 89)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelContenido.Size = New System.Drawing.Size(898, 613)
        Me.PanelContenido.TabIndex = 3
        '
        'PanelEncabezado
        '
        Me.PanelEncabezado.AutoScroll = True
        Me.PanelEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelEncabezado.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEncabezado.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEncabezado.Location = New System.Drawing.Point(280, 0)
        Me.PanelEncabezado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelEncabezado.Name = "PanelEncabezado"
        Me.PanelEncabezado.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEncabezado.Size = New System.Drawing.Size(898, 89)
        Me.PanelEncabezado.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.44776!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.55224!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblTituloMenuEncabezado, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.pb2seccionMenuNav, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox2, 3, 0)
        Me.TableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(890, 79)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblTituloMenuEncabezado
        '
        Me.lblTituloMenuEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTituloMenuEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloMenuEncabezado.Location = New System.Drawing.Point(61, 10)
        Me.lblTituloMenuEncabezado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloMenuEncabezado.Name = "lblTituloMenuEncabezado"
        Me.lblTituloMenuEncabezado.Size = New System.Drawing.Size(485, 58)
        Me.lblTituloMenuEncabezado.TabIndex = 0
        Me.lblTituloMenuEncabezado.Text = "REPORTES"
        Me.lblTituloMenuEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(686, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BIBLIOTECARIO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb2seccionMenuNav
        '
        Me.pb2seccionMenuNav.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb2seccionMenuNav.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.pb2seccionMenuNav.Location = New System.Drawing.Point(4, 17)
        Me.pb2seccionMenuNav.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pb2seccionMenuNav.Name = "pb2seccionMenuNav"
        Me.pb2seccionMenuNav.Size = New System.Drawing.Size(49, 45)
        Me.pb2seccionMenuNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2seccionMenuNav.TabIndex = 0
        Me.pb2seccionMenuNav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Image = Global.ProyLibreteao.My.Resources.Resources.icono_user
        Me.PictureBox2.Location = New System.Drawing.Point(820, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelNav
        '
        Me.PanelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelNav.Controls.Add(Me.scNav)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNav.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelNav.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(280, 702)
        Me.PanelNav.TabIndex = 5
        '
        'scNav
        '
        Me.scNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scNav.IsSplitterFixed = True
        Me.scNav.Location = New System.Drawing.Point(0, 0)
        Me.scNav.Margin = New System.Windows.Forms.Padding(0)
        Me.scNav.Name = "scNav"
        Me.scNav.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scNav.Panel2
        '
        Me.scNav.Panel2.Controls.Add(Me.SplitContainer2)
        Me.scNav.Size = New System.Drawing.Size(280, 702)
        Me.scNav.SplitterDistance = 93
        Me.scNav.SplitterWidth = 1
        Me.scNav.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.msMenuNavegacion)
        Me.SplitContainer2.Size = New System.Drawing.Size(280, 608)
        Me.SplitContainer2.SplitterDistance = 474
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'msMenuNavegacion
        '
        Me.msMenuNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.msMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenuNavegacion.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.msMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_NavInicioToolStripMenuItem, Me.btn_NavLIBROSToolStripMenuItem, Me.btn_NavPRESTAMOSToolStripMenuItem, Me.btn_NavMENSAJERÍAToolStripMenuItem, Me.btn_NavCLIENTESToolStripMenuItem, Me.btn_NavVISTASToolStripMenuItem, Me.btn_NavREPORTESToolStripMenuItem, Me.btn_NavSOLICITUDToolStripMenuItem, Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem, Me.btn_NavCONSULTASToolStripMenuItem})
        Me.msMenuNavegacion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.msMenuNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.msMenuNavegacion.Name = "msMenuNavegacion"
        Me.msMenuNavegacion.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.msMenuNavegacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msMenuNavegacion.ShowItemToolTips = True
        Me.msMenuNavegacion.Size = New System.Drawing.Size(280, 474)
        Me.msMenuNavegacion.TabIndex = 4
        '
        'btn_NavInicioToolStripMenuItem
        '
        Me.btn_NavInicioToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoInicio
        Me.btn_NavInicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.Name = "btn_NavInicioToolStripMenuItem"
        Me.btn_NavInicioToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavInicioToolStripMenuItem.Text = "INICO"
        Me.btn_NavInicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.ToolTipText = "Ir a inicio de página " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_NavLIBROSToolStripMenuItem
        '
        Me.btn_NavLIBROSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoLibros
        Me.btn_NavLIBROSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.Name = "btn_NavLIBROSToolStripMenuItem"
        Me.btn_NavLIBROSToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
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
        Me.btn_NavPRESTAMOSToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavPRESTAMOSToolStripMenuItem.Text = "PRESTAMOS "
        Me.btn_NavPRESTAMOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.ToolTipText = "Ver prestamos realizados "
        '
        'btn_NavMENSAJERÍAToolStripMenuItem
        '
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconomensajería
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Name = "btn_NavMENSAJERÍAToolStripMenuItem"
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Text = "MENSAJERÍA "
        Me.btn_NavMENSAJERÍAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ToolTipText = "Ver mensajes "
        '
        'btn_NavCLIENTESToolStripMenuItem
        '
        Me.btn_NavCLIENTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoClientes
        Me.btn_NavCLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.Name = "btn_NavCLIENTESToolStripMenuItem"
        Me.btn_NavCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavCLIENTESToolStripMenuItem.Text = "CLIENTES"
        Me.btn_NavCLIENTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.ToolTipText = "Ver Clientes "
        '
        'btn_NavVISTASToolStripMenuItem
        '
        Me.btn_NavVISTASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoVista
        Me.btn_NavVISTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavVISTASToolStripMenuItem.Name = "btn_NavVISTASToolStripMenuItem"
        Me.btn_NavVISTASToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavVISTASToolStripMenuItem.Text = "VISTAS"
        Me.btn_NavVISTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavREPORTESToolStripMenuItem
        '
        Me.btn_NavREPORTESToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoReportes
        Me.btn_NavREPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavREPORTESToolStripMenuItem.Name = "btn_NavREPORTESToolStripMenuItem"
        Me.btn_NavREPORTESToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavREPORTESToolStripMenuItem.Text = "REPORTES"
        Me.btn_NavREPORTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavSOLICITUDToolStripMenuItem
        '
        Me.btn_NavSOLICITUDToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoSolicitud
        Me.btn_NavSOLICITUDToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.Name = "btn_NavSOLICITUDToolStripMenuItem"
        Me.btn_NavSOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavSOLICITUDToolStripMenuItem.Text = "SOLICITUD DE LIBROS "
        Me.btn_NavSOLICITUDToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.ToolTipText = "Ver Solisitudes de los Clientes"
        '
        'btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem
        '
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoGestionarCatálogo
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Name = "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Text = "GESTIÓN DE CATÁLOGOS"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ToolTipText = "Ver Catálogos disponibles"
        '
        'btn_NavCONSULTASToolStripMenuItem
        '
        Me.btn_NavCONSULTASToolStripMenuItem.Image = Global.ProyLibreteao.My.Resources.Resources.iconoPreguntas
        Me.btn_NavCONSULTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCONSULTASToolStripMenuItem.Name = "btn_NavCONSULTASToolStripMenuItem"
        Me.btn_NavCONSULTASToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.btn_NavCONSULTASToolStripMenuItem.Text = "CONSULTAS"
        Me.btn_NavCONSULTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 702)
        Me.Controls.Add(Me.PanelBase)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1194, 741)
        Me.Name = "FormConsultas"
        Me.Text = "Formulario Consultas"
        Me.PanelBase.ResumeLayout(False)
        Me.PanelEncabezado.ResumeLayout(False)
        Me.PanelEncabezado.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.pb2seccionMenuNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNav.ResumeLayout(False)
        Me.scNav.Panel2.ResumeLayout(False)
        CType(Me.scNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scNav.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
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
    Friend WithEvents pb2seccionMenuNav As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelNav As Panel
    Friend WithEvents scNav As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents msMenuNavegacion As MenuStrip
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
End Class
