<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.flowPanelCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCardLibros = New System.Windows.Forms.Panel()
        Me.lblNumLibros = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlCardUsuarios = New System.Windows.Forms.Panel()
        Me.lblNumUsuarios = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlCardPrestamos = New System.Windows.Forms.Panel()
        Me.lblNumPrestamos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCardMorosos = New System.Windows.Forms.Panel()
        Me.lblNumMorosos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpAccesos = New System.Windows.Forms.GroupBox()
        Me.btnIrCatalogo = New System.Windows.Forms.Button()
        Me.btnIrDevolucion = New System.Windows.Forms.Button()
        Me.btnIrPrestamo = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.flowPanelCards.SuspendLayout()
        Me.pnlCardLibros.SuspendLayout()
        Me.pnlCardUsuarios.SuspendLayout()
        Me.pnlCardPrestamos.SuspendLayout()
        Me.pnlCardMorosos.SuspendLayout()
        Me.grpAccesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblFecha)
        Me.pnlHeader.Controls.Add(Me.lblBienvenida)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(712, 65)
        Me.pnlHeader.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Gray
        Me.lblFecha.Location = New System.Drawing.Point(17, 39)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(114, 19)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Cargando fecha..."
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBienvenida.Location = New System.Drawing.Point(15, 7)
        Me.lblBienvenida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(226, 32)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "Hola, Bibliotecario"
        '
        'flowPanelCards
        '
        Me.flowPanelCards.Controls.Add(Me.pnlCardLibros)
        Me.flowPanelCards.Controls.Add(Me.pnlCardUsuarios)
        Me.flowPanelCards.Controls.Add(Me.pnlCardPrestamos)
        Me.flowPanelCards.Controls.Add(Me.pnlCardMorosos)
        Me.flowPanelCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowPanelCards.Location = New System.Drawing.Point(0, 65)
        Me.flowPanelCards.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flowPanelCards.Name = "flowPanelCards"
        Me.flowPanelCards.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.flowPanelCards.Size = New System.Drawing.Size(712, 130)
        Me.flowPanelCards.TabIndex = 1
        '
        'pnlCardLibros
        '
        Me.pnlCardLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlCardLibros.Controls.Add(Me.lblNumLibros)
        Me.pnlCardLibros.Controls.Add(Me.Label1)
        Me.pnlCardLibros.Location = New System.Drawing.Point(17, 18)
        Me.pnlCardLibros.Margin = New System.Windows.Forms.Padding(2, 2, 15, 2)
        Me.pnlCardLibros.Name = "pnlCardLibros"
        Me.pnlCardLibros.Size = New System.Drawing.Size(150, 89)
        Me.pnlCardLibros.TabIndex = 0
        '
        'lblNumLibros
        '
        Me.lblNumLibros.AutoSize = True
        Me.lblNumLibros.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLibros.ForeColor = System.Drawing.Color.White
        Me.lblNumLibros.Location = New System.Drawing.Point(8, 32)
        Me.lblNumLibros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumLibros.Name = "lblNumLibros"
        Me.lblNumLibros.Size = New System.Drawing.Size(33, 45)
        Me.lblNumLibros.TabIndex = 1
        Me.lblNumLibros.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total libros"
        '
        'pnlCardUsuarios
        '
        Me.pnlCardUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlCardUsuarios.Controls.Add(Me.lblNumUsuarios)
        Me.pnlCardUsuarios.Controls.Add(Me.Label3)
        Me.pnlCardUsuarios.Location = New System.Drawing.Point(184, 18)
        Me.pnlCardUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 15, 2)
        Me.pnlCardUsuarios.Name = "pnlCardUsuarios"
        Me.pnlCardUsuarios.Size = New System.Drawing.Size(150, 89)
        Me.pnlCardUsuarios.TabIndex = 1
        '
        'lblNumUsuarios
        '
        Me.lblNumUsuarios.AutoSize = True
        Me.lblNumUsuarios.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblNumUsuarios.Location = New System.Drawing.Point(8, 32)
        Me.lblNumUsuarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumUsuarios.Name = "lblNumUsuarios"
        Me.lblNumUsuarios.Size = New System.Drawing.Size(33, 45)
        Me.lblNumUsuarios.TabIndex = 1
        Me.lblNumUsuarios.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(10, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuarios"
        '
        'pnlCardPrestamos
        '
        Me.pnlCardPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlCardPrestamos.Controls.Add(Me.lblNumPrestamos)
        Me.pnlCardPrestamos.Controls.Add(Me.Label5)
        Me.pnlCardPrestamos.Location = New System.Drawing.Point(351, 18)
        Me.pnlCardPrestamos.Margin = New System.Windows.Forms.Padding(2, 2, 15, 2)
        Me.pnlCardPrestamos.Name = "pnlCardPrestamos"
        Me.pnlCardPrestamos.Size = New System.Drawing.Size(150, 89)
        Me.pnlCardPrestamos.TabIndex = 2
        '
        'lblNumPrestamos
        '
        Me.lblNumPrestamos.AutoSize = True
        Me.lblNumPrestamos.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPrestamos.ForeColor = System.Drawing.Color.White
        Me.lblNumPrestamos.Location = New System.Drawing.Point(8, 32)
        Me.lblNumPrestamos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumPrestamos.Name = "lblNumPrestamos"
        Me.lblNumPrestamos.Size = New System.Drawing.Size(33, 45)
        Me.lblNumPrestamos.TabIndex = 1
        Me.lblNumPrestamos.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(10, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Préstamos activos"
        '
        'pnlCardMorosos
        '
        Me.pnlCardMorosos.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlCardMorosos.Controls.Add(Me.lblNumMorosos)
        Me.pnlCardMorosos.Controls.Add(Me.Label7)
        Me.pnlCardMorosos.Location = New System.Drawing.Point(518, 18)
        Me.pnlCardMorosos.Margin = New System.Windows.Forms.Padding(2, 2, 15, 2)
        Me.pnlCardMorosos.Name = "pnlCardMorosos"
        Me.pnlCardMorosos.Size = New System.Drawing.Size(150, 89)
        Me.pnlCardMorosos.TabIndex = 3
        '
        'lblNumMorosos
        '
        Me.lblNumMorosos.AutoSize = True
        Me.lblNumMorosos.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMorosos.ForeColor = System.Drawing.Color.White
        Me.lblNumMorosos.Location = New System.Drawing.Point(8, 32)
        Me.lblNumMorosos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumMorosos.Name = "lblNumMorosos"
        Me.lblNumMorosos.Size = New System.Drawing.Size(33, 45)
        Me.lblNumMorosos.TabIndex = 1
        Me.lblNumMorosos.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(10, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Multas realizadas"
        '
        'grpAccesos
        '
        Me.grpAccesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAccesos.Controls.Add(Me.btnIrCatalogo)
        Me.grpAccesos.Controls.Add(Me.btnIrDevolucion)
        Me.grpAccesos.Controls.Add(Me.btnIrPrestamo)
        Me.grpAccesos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccesos.Location = New System.Drawing.Point(20, 211)
        Me.grpAccesos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAccesos.Name = "grpAccesos"
        Me.grpAccesos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAccesos.Size = New System.Drawing.Size(668, 162)
        Me.grpAccesos.TabIndex = 2
        Me.grpAccesos.TabStop = False
        Me.grpAccesos.Text = "Accesos Rápidos"
        '
        'btnIrCatalogo
        '
        Me.btnIrCatalogo.BackColor = System.Drawing.Color.White
        Me.btnIrCatalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIrCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrCatalogo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnIrCatalogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIrCatalogo.Location = New System.Drawing.Point(450, 41)
        Me.btnIrCatalogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIrCatalogo.Name = "btnIrCatalogo"
        Me.btnIrCatalogo.Size = New System.Drawing.Size(188, 81)
        Me.btnIrCatalogo.TabIndex = 2
        Me.btnIrCatalogo.Text = "📚 Gestionar Catálogo de Libros"
        Me.btnIrCatalogo.UseVisualStyleBackColor = False
        '
        'btnIrDevolucion
        '
        Me.btnIrDevolucion.BackColor = System.Drawing.Color.White
        Me.btnIrDevolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIrDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrDevolucion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnIrDevolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIrDevolucion.Location = New System.Drawing.Point(232, 41)
        Me.btnIrDevolucion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIrDevolucion.Name = "btnIrDevolucion"
        Me.btnIrDevolucion.Size = New System.Drawing.Size(188, 81)
        Me.btnIrDevolucion.TabIndex = 1
        Me.btnIrDevolucion.Text = "👨‍🦱 Gestionar Usuarios"
        Me.btnIrDevolucion.UseVisualStyleBackColor = False
        '
        'btnIrPrestamo
        '
        Me.btnIrPrestamo.BackColor = System.Drawing.Color.White
        Me.btnIrPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIrPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIrPrestamo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnIrPrestamo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIrPrestamo.Location = New System.Drawing.Point(15, 41)
        Me.btnIrPrestamo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIrPrestamo.Name = "btnIrPrestamo"
        Me.btnIrPrestamo.Size = New System.Drawing.Size(188, 81)
        Me.btnIrPrestamo.TabIndex = 0
        Me.btnIrPrestamo.Text = "🏷 Gestionar Préstamos"
        Me.btnIrPrestamo.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(712, 447)
        Me.Controls.Add(Me.grpAccesos)
        Me.Controls.Add(Me.flowPanelCards)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.flowPanelCards.ResumeLayout(False)
        Me.pnlCardLibros.ResumeLayout(False)
        Me.pnlCardLibros.PerformLayout()
        Me.pnlCardUsuarios.ResumeLayout(False)
        Me.pnlCardUsuarios.PerformLayout()
        Me.pnlCardPrestamos.ResumeLayout(False)
        Me.pnlCardPrestamos.PerformLayout()
        Me.pnlCardMorosos.ResumeLayout(False)
        Me.pnlCardMorosos.PerformLayout()
        Me.grpAccesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblBienvenida As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents flowPanelCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlCardLibros As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumLibros As System.Windows.Forms.Label
    Friend WithEvents pnlCardUsuarios As System.Windows.Forms.Panel
    Friend WithEvents lblNumUsuarios As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlCardPrestamos As System.Windows.Forms.Panel
    Friend WithEvents lblNumPrestamos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlCardMorosos As System.Windows.Forms.Panel
    Friend WithEvents lblNumMorosos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpAccesos As System.Windows.Forms.GroupBox
    Friend WithEvents btnIrPrestamo As System.Windows.Forms.Button
    Friend WithEvents btnIrCatalogo As System.Windows.Forms.Button
    Friend WithEvents btnIrDevolucion As System.Windows.Forms.Button
End Class