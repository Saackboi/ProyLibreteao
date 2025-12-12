<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestamos
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.BtnMarcarDevuelto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBoxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.dgvPrestamos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnPDF = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnWord = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87726!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12273!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(945, 683)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(939, 76)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TABLA DE PRÉSTAMOS "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.73009!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgvPrestamos, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 79)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 468.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(939, 512)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Purple
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnEditar, Me.BtnEliminar, Me.BtnMarcarDevuelto, Me.ToolStripTextBoxBuscar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(755, 44)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(72, 33)
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.ToolTipText = "Agregar un Nuevo Pedido"
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(66, 33)
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.ToolTipText = "Modificar Pedido"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 33)
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.ToolTipText = "Eliminar Pedido"
        '
        'BtnMarcarDevuelto
        '
        Me.BtnMarcarDevuelto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMarcarDevuelto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMarcarDevuelto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMarcarDevuelto.Name = "BtnMarcarDevuelto"
        Me.BtnMarcarDevuelto.Size = New System.Drawing.Size(161, 33)
        Me.BtnMarcarDevuelto.Text = "Marcar devuelto "
        Me.BtnMarcarDevuelto.ToolTipText = "Marcar Pedido  Devuelto "
        '
        'ToolStripTextBoxBuscar
        '
        Me.ToolStripTextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBoxBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBoxBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ToolStripTextBoxBuscar.Name = "ToolStripTextBoxBuscar"
        Me.ToolStripTextBoxBuscar.Size = New System.Drawing.Size(300, 38)
        Me.ToolStripTextBoxBuscar.Text = "Buscar Préstamo 🔎"
        Me.ToolStripTextBoxBuscar.ToolTipText = "Búsqueda de Pedido"
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.AllowUserToAddRows = False
        Me.dgvPrestamos.AllowUserToDeleteRows = False
        Me.dgvPrestamos.AllowUserToResizeColumns = False
        Me.dgvPrestamos.AllowUserToResizeRows = False
        Me.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrestamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrestamos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrestamos.EnableHeadersVisualStyles = False
        Me.dgvPrestamos.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPrestamos.Location = New System.Drawing.Point(20, 64)
        Me.dgvPrestamos.Margin = New System.Windows.Forms.Padding(20)
        Me.dgvPrestamos.MultiSelect = False
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPrestamos.RowHeadersVisible = False
        Me.dgvPrestamos.RowHeadersWidth = 62
        Me.dgvPrestamos.RowTemplate.Height = 28
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(755, 428)
        Me.dgvPrestamos.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 597)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(939, 83)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnPDF)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnExcel)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnWord)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(329, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(320, 71)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'BtnPDF
        '
        Me.BtnPDF.BackgroundImage = Global.ProyLibreteao.My.Resources.Resources.iconoPdf
        Me.BtnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPDF.FlatAppearance.BorderSize = 0
        Me.BtnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.BtnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPDF.Location = New System.Drawing.Point(3, 3)
        Me.BtnPDF.Name = "BtnPDF"
        Me.BtnPDF.Size = New System.Drawing.Size(95, 65)
        Me.BtnPDF.TabIndex = 1
        Me.BtnPDF.UseVisualStyleBackColor = True
        '
        'BtnExcel
        '
        Me.BtnExcel.BackgroundImage = Global.ProyLibreteao.My.Resources.Resources.iconoExcel
        Me.BtnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnExcel.FlatAppearance.BorderSize = 0
        Me.BtnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.BtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcel.Location = New System.Drawing.Point(104, 3)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(81, 65)
        Me.BtnExcel.TabIndex = 2
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnWord
        '
        Me.BtnWord.BackgroundImage = Global.ProyLibreteao.My.Resources.Resources.iconoWord
        Me.BtnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnWord.FlatAppearance.BorderSize = 0
        Me.BtnWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.BtnWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.BtnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWord.Location = New System.Drawing.Point(191, 3)
        Me.BtnWord.Name = "BtnWord"
        Me.BtnWord.Size = New System.Drawing.Size(95, 65)
        Me.BtnWord.TabIndex = 0
        Me.BtnWord.UseVisualStyleBackColor = True
        '
        'FormPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 683)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormPrestamos"
        Me.Text = "FormPrestamos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnWord As Button
    Friend WithEvents BtnPDF As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents BtnMarcarDevuelto As ToolStripButton
    Friend WithEvents ToolStripTextBoxBuscar As ToolStripTextBox
End Class
