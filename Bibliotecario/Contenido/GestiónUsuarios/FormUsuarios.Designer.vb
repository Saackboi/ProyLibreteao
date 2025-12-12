<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFondo = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.txtContraUsuario = New System.Windows.Forms.TextBox()
        Me.txtCorreoUsuario = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPanelInput = New System.Windows.Forms.Label()
        Me.txtInputNombreUsuario = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.pnlFondo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.PanelTop.SuspendLayout()
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
        Me.PanelContenedor.Controls.Add(Me.pnlInput)
        Me.PanelContenedor.Controls.Add(Me.dgvUsuarios)
        Me.PanelContenedor.Controls.Add(Me.PanelBottom)
        Me.PanelContenedor.Controls.Add(Me.PanelTop)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(27, 25)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelContenedor.Size = New System.Drawing.Size(1213, 688)
        Me.PanelContenedor.TabIndex = 0
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.White
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.txtContraUsuario)
        Me.pnlInput.Controls.Add(Me.txtCorreoUsuario)
        Me.pnlInput.Controls.Add(Me.label3)
        Me.pnlInput.Controls.Add(Me.Label2)
        Me.pnlInput.Controls.Add(Me.Label1)
        Me.pnlInput.Controls.Add(Me.lblPanelInput)
        Me.pnlInput.Controls.Add(Me.txtInputNombreUsuario)
        Me.pnlInput.Controls.Add(Me.btnGuardar)
        Me.pnlInput.Controls.Add(Me.btnCancelar)
        Me.pnlInput.Location = New System.Drawing.Point(330, 136)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(599, 340)
        Me.pnlInput.TabIndex = 20
        Me.pnlInput.Visible = False
        '
        'txtContraUsuario
        '
        Me.txtContraUsuario.Location = New System.Drawing.Point(138, 188)
        Me.txtContraUsuario.Name = "txtContraUsuario"
        Me.txtContraUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraUsuario.Size = New System.Drawing.Size(413, 22)
        Me.txtContraUsuario.TabIndex = 14
        '
        'txtCorreoUsuario
        '
        Me.txtCorreoUsuario.Location = New System.Drawing.Point(138, 139)
        Me.txtCorreoUsuario.Name = "txtCorreoUsuario"
        Me.txtCorreoUsuario.Size = New System.Drawing.Size(413, 22)
        Me.txtCorreoUsuario.TabIndex = 13
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(47, 188)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre:"
        '
        'lblPanelInput
        '
        Me.lblPanelInput.AutoSize = True
        Me.lblPanelInput.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPanelInput.Location = New System.Drawing.Point(46, 45)
        Me.lblPanelInput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPanelInput.Name = "lblPanelInput"
        Me.lblPanelInput.Size = New System.Drawing.Size(0, 23)
        Me.lblPanelInput.TabIndex = 0
        '
        'txtInputNombreUsuario
        '
        Me.txtInputNombreUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInputNombreUsuario.Location = New System.Drawing.Point(138, 89)
        Me.txtInputNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputNombreUsuario.Name = "txtInputNombreUsuario"
        Me.txtInputNombreUsuario.Size = New System.Drawing.Size(413, 22)
        Me.txtInputNombreUsuario.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(50, 242)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 55)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "GUARDAR USUARIO"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gray
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(311, 242)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(240, 55)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeight = 40
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUsuarios.Location = New System.Drawing.Point(13, 98)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 35
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(1187, 492)
        Me.dgvUsuarios.TabIndex = 2
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
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(432, 18)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(187, 43)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR USUARIO"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(220, 18)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(187, 43)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR USUARIO"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.LabelTitulo.Size = New System.Drawing.Size(230, 32)
        Me.LabelTitulo.TabIndex = 3
        Me.LabelTitulo.Text = "Gestionar Usuarios"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.Tomato
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(864, 25)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(309, 43)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "+ AÑADIR NUEVO USUARIO"
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
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 738)
        Me.Controls.Add(Me.pnlFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        Me.pnlFondo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
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
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblPanelInput As Label
    Friend WithEvents txtInputNombreUsuario As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtCorreoUsuario As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraUsuario As TextBox
End Class
