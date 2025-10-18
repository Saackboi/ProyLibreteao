<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportes
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
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.tlpReporte = New System.Windows.Forms.TableLayoutPanel()
        Me.tcContenidoReportes = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvTablaInfoReporte = New System.Windows.Forms.DataGridView()
        Me.btnFiltroReporte = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lblTituloTabControl = New System.Windows.Forms.Label()
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
        Me.PanelContenido.SuspendLayout()
        Me.tlpReporte.SuspendLayout()
        Me.tcContenidoReportes.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelBase.Size = New System.Drawing.Size(1364, 749)
        Me.PanelBase.TabIndex = 3
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.White
        Me.PanelContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContenido.Controls.Add(Me.tlpReporte)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(280, 89)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelContenido.Size = New System.Drawing.Size(1084, 660)
        Me.PanelContenido.TabIndex = 3
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
        Me.tlpReporte.Size = New System.Drawing.Size(1074, 650)
        Me.tlpReporte.TabIndex = 2
        '
        'tcContenidoReportes
        '
        Me.tcContenidoReportes.Controls.Add(Me.TabPage5)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage6)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage7)
        Me.tcContenidoReportes.Controls.Add(Me.TabPage8)
        Me.tcContenidoReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcContenidoReportes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tcContenidoReportes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcContenidoReportes.HotTrack = True
        Me.tcContenidoReportes.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.tcContenidoReportes.Location = New System.Drawing.Point(2, 67)
        Me.tcContenidoReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.tcContenidoReportes.Multiline = True
        Me.tcContenidoReportes.Name = "tcContenidoReportes"
        Me.tcContenidoReportes.SelectedIndex = 0
        Me.tcContenidoReportes.Size = New System.Drawing.Size(1070, 581)
        Me.tcContenidoReportes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tcContenidoReportes.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.ForeColor = System.Drawing.Color.Purple
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(1062, 553)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Resumen De Informe "
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.ForeColor = System.Drawing.Color.Purple
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Size = New System.Drawing.Size(1062, 553)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Actividad Semanal"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AllowDrop = True
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.38573!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.61427!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvTablaInfoReporte, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnFiltroReporte, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 505.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1058, 565)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(916, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Descargar Reportes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvTablaInfoReporte
        '
        Me.dgvTablaInfoReporte.AllowUserToAddRows = False
        Me.dgvTablaInfoReporte.AllowUserToDeleteRows = False
        Me.dgvTablaInfoReporte.AllowUserToResizeColumns = False
        Me.dgvTablaInfoReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTablaInfoReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvTablaInfoReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTablaInfoReporte.BackgroundColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTablaInfoReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTablaInfoReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvTablaInfoReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTablaInfoReporte.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgvTablaInfoReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTablaInfoReporte.EnableHeadersVisualStyles = False
        Me.dgvTablaInfoReporte.GridColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.Location = New System.Drawing.Point(3, 63)
        Me.dgvTablaInfoReporte.Name = "dgvTablaInfoReporte"
        Me.dgvTablaInfoReporte.ReadOnly = True
        Me.dgvTablaInfoReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvTablaInfoReporte.RowHeadersVisible = False
        Me.dgvTablaInfoReporte.RowHeadersWidth = 62
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvTablaInfoReporte.RowTemplate.Height = 28
        Me.dgvTablaInfoReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablaInfoReporte.Size = New System.Drawing.Size(865, 499)
        Me.dgvTablaInfoReporte.TabIndex = 0
        '
        'btnFiltroReporte
        '
        Me.btnFiltroReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFiltroReporte.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltroReporte.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltroReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnFiltroReporte.Image = Global.ProyLibreteao.My.Resources.Resources.iconoFiltro
        Me.btnFiltroReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltroReporte.Location = New System.Drawing.Point(3, 26)
        Me.btnFiltroReporte.Name = "btnFiltroReporte"
        Me.btnFiltroReporte.Size = New System.Drawing.Size(81, 31)
        Me.btnFiltroReporte.TabIndex = 3
        Me.btnFiltroReporte.Text = "Filtros"
        Me.btnFiltroReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltroReporte.UseVisualStyleBackColor = False
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.ForeColor = System.Drawing.Color.Purple
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1062, 553)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "Libros Más Solicitados "
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage8.ForeColor = System.Drawing.Color.Purple
        Me.TabPage8.Location = New System.Drawing.Point(4, 24)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1062, 553)
        Me.TabPage8.TabIndex = 3
        Me.TabPage8.Text = "Multas Por Usuario"
        '
        'lblTituloTabControl
        '
        Me.lblTituloTabControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTituloTabControl.AutoSize = True
        Me.lblTituloTabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTabControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTituloTabControl.Location = New System.Drawing.Point(491, 0)
        Me.lblTituloTabControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloTabControl.Name = "lblTituloTabControl"
        Me.lblTituloTabControl.Size = New System.Drawing.Size(91, 65)
        Me.lblTituloTabControl.TabIndex = 0
        Me.lblTituloTabControl.Text = "BIENVENIDA"
        Me.lblTituloTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PanelEncabezado.Size = New System.Drawing.Size(1084, 89)
        Me.PanelEncabezado.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.44776!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.55224!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1076, 79)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblTituloMenuEncabezado
        '
        Me.lblTituloMenuEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTituloMenuEncabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloMenuEncabezado.Location = New System.Drawing.Point(81, 10)
        Me.lblTituloMenuEncabezado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloMenuEncabezado.Name = "lblTituloMenuEncabezado"
        Me.lblTituloMenuEncabezado.Size = New System.Drawing.Size(494, 58)
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
        Me.Label3.Location = New System.Drawing.Point(873, 29)
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
        Me.pb2seccionMenuNav.Size = New System.Drawing.Size(66, 45)
        Me.pb2seccionMenuNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2seccionMenuNav.TabIndex = 0
        Me.pb2seccionMenuNav.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Image = Global.ProyLibreteao.My.Resources.Resources.icono_user
        Me.PictureBox2.Location = New System.Drawing.Point(1006, 15)
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
        Me.PanelNav.Size = New System.Drawing.Size(280, 749)
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
        Me.scNav.Size = New System.Drawing.Size(280, 749)
        Me.scNav.SplitterDistance = 100
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
        Me.SplitContainer2.Size = New System.Drawing.Size(280, 648)
        Me.SplitContainer2.SplitterDistance = 506
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
        Me.msMenuNavegacion.Size = New System.Drawing.Size(280, 506)
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
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.PanelBase)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1194, 741)
        Me.Name = "FormReportes"
        Me.Text = "Formulario Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBase.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        Me.tlpReporte.ResumeLayout(False)
        Me.tlpReporte.PerformLayout()
        Me.tcContenidoReportes.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tlpReporte As TableLayoutPanel
    Friend WithEvents tcContenidoReportes As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvTablaInfoReporte As DataGridView
    Friend WithEvents btnFiltroReporte As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents lblTituloTabControl As Label
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
