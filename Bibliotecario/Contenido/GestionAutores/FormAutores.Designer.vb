<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAutores
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
        Me.pnlFondo = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.dgvAutores = New System.Windows.Forms.DataGridView()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblPanelInput = New System.Windows.Forms.Label()
        Me.txtInputNombreAutor = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.pnlFondo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFondo
        '
        Me.pnlFondo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFondo.Controls.Add(Me.PanelContenedor)
        Me.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFondo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFondo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFondo.Name = "pnlFondo"
        Me.pnlFondo.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.pnlFondo.Size = New System.Drawing.Size(1267, 738)
        Me.pnlFondo.TabIndex = 0
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Controls.Add(Me.dgvAutores)
        Me.PanelContenedor.Controls.Add(Me.PanelBottom)
        Me.PanelContenedor.Controls.Add(Me.PanelTop)
        Me.PanelContenedor.Controls.Add(Me.pnlInput)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(27, 25)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelContenedor.Size = New System.Drawing.Size(1213, 688)
        Me.PanelContenedor.TabIndex = 0
        '
        'dgvAutores
        '
        Me.dgvAutores.AllowUserToAddRows = False
        Me.dgvAutores.AllowUserToDeleteRows = False
        Me.dgvAutores.AllowUserToResizeRows = False
        Me.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAutores.BackgroundColor = System.Drawing.Color.White
        Me.dgvAutores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAutores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAutores.ColumnHeadersHeight = 40
        Me.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAutores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAutores.EnableHeadersVisualStyles = False
        Me.dgvAutores.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAutores.Location = New System.Drawing.Point(13, 98)
        Me.dgvAutores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAutores.MultiSelect = False
        Me.dgvAutores.Name = "dgvAutores"
        Me.dgvAutores.ReadOnly = True
        Me.dgvAutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAutores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAutores.RowHeadersVisible = False
        Me.dgvAutores.RowHeadersWidth = 51
        Me.dgvAutores.RowTemplate.Height = 35
        Me.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAutores.Size = New System.Drawing.Size(1187, 492)
        Me.dgvAutores.TabIndex = 2
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.btnModificar)
        Me.PanelBottom.Controls.Add(Me.btnEliminar)
        Me.PanelBottom.Controls.Add(Me.btnActualizar)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(13, 590)
        Me.PanelBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1187, 86)
        Me.PanelBottom.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(220, 18)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(187, 43)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR AUTOR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(7, 18)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(187, 43)
        Me.btnActualizar.TabIndex = 0
        Me.btnActualizar.Text = "ACTUALIZAR TABLA"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.LabelTitulo)
        Me.PanelTop.Controls.Add(Me.btnAgregar)
        Me.PanelTop.Controls.Add(Me.txtBusqueda)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(13, 12)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1187, 86)
        Me.PanelTop.TabIndex = 0
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 6)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(221, 32)
        Me.LabelTitulo.TabIndex = 3
        Me.LabelTitulo.Text = "Gestionar Autores"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.Tomato
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(953, 25)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(220, 43)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "+ AÑADIR NUEVO AUTOR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtBusqueda.ForeColor = System.Drawing.Color.Gray
        Me.txtBusqueda.Location = New System.Drawing.Point(7, 43)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(400, 31)
        Me.txtBusqueda.TabIndex = 0
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.White
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.lblPanelInput)
        Me.pnlInput.Controls.Add(Me.txtInputNombreAutor)
        Me.pnlInput.Controls.Add(Me.btnGuardar)
        Me.pnlInput.Controls.Add(Me.btnCancelar)
        Me.pnlInput.Location = New System.Drawing.Point(330, 216)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(599, 218)
        Me.pnlInput.TabIndex = 20
        Me.pnlInput.Visible = False
        '
        'lblPanelInput
        '
        Me.lblPanelInput.AutoSize = True
        Me.lblPanelInput.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPanelInput.Location = New System.Drawing.Point(40, 37)
        Me.lblPanelInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPanelInput.Name = "lblPanelInput"
        Me.lblPanelInput.Size = New System.Drawing.Size(0, 23)
        Me.lblPanelInput.TabIndex = 0
        '
        'txtInputNombreAutor
        '
        Me.txtInputNombreAutor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInputNombreAutor.Location = New System.Drawing.Point(40, 68)
        Me.txtInputNombreAutor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputNombreAutor.Name = "txtInputNombreAutor"
        Me.txtInputNombreAutor.Size = New System.Drawing.Size(505, 22)
        Me.txtInputNombreAutor.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(38, 135)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 55)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "GUARDAR AUTOR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gray
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(305, 135)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(240, 55)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(432, 18)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(187, 43)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR AUTOR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'FormAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 738)
        Me.Controls.Add(Me.pnlFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAutores"
        Me.Text = "FormAutores"
        Me.pnlFondo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFondo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgvAutores As DataGridView
    Friend WithEvents LabelTitulo As Label
    ' Variables para el Modal
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblPanelInput As Label
    Friend WithEvents txtInputNombreAutor As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
End Class