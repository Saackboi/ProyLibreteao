<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatalogoLibros
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
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fest5 = New System.Windows.Forms.CheckBox()
        Me.fest4 = New System.Windows.Forms.CheckBox()
        Me.fest3 = New System.Windows.Forms.CheckBox()
        Me.fest2 = New System.Windows.Forms.CheckBox()
        Me.fest1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelContenedorLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelLateral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.White
        Me.PanelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLateral.Controls.Add(Me.btnRegistrarse)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.Label3)
        Me.PanelLateral.Controls.Add(Me.btnRegresar)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.ForeColor = System.Drawing.Color.Gray
        Me.PanelLateral.Location = New System.Drawing.Point(0, 70)
        Me.PanelLateral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(221, 555)
        Me.PanelLateral.TabIndex = 0
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRegistrarse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrarse.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegistrarse.Location = New System.Drawing.Point(17, 411)
        Me.btnRegistrarse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(183, 53)
        Me.btnRegistrarse.TabIndex = 5
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.fest5)
        Me.Panel2.Controls.Add(Me.fest4)
        Me.Panel2.Controls.Add(Me.fest3)
        Me.Panel2.Controls.Add(Me.fest2)
        Me.Panel2.Controls.Add(Me.fest1)
        Me.Panel2.Location = New System.Drawing.Point(11, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 173)
        Me.Panel2.TabIndex = 4
        '
        'fest5
        '
        Me.fest5.AutoSize = True
        Me.fest5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fest5.Location = New System.Drawing.Point(23, 123)
        Me.fest5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest5.Name = "fest5"
        Me.fest5.Size = New System.Drawing.Size(124, 32)
        Me.fest5.TabIndex = 4
        Me.fest5.Text = "★★★★★"
        Me.fest5.UseVisualStyleBackColor = True
        '
        'fest4
        '
        Me.fest4.AutoSize = True
        Me.fest4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fest4.Location = New System.Drawing.Point(23, 95)
        Me.fest4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest4.Name = "fest4"
        Me.fest4.Size = New System.Drawing.Size(106, 32)
        Me.fest4.TabIndex = 3
        Me.fest4.Text = "★★★★"
        Me.fest4.UseVisualStyleBackColor = True
        '
        'fest3
        '
        Me.fest3.AutoSize = True
        Me.fest3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fest3.Location = New System.Drawing.Point(23, 70)
        Me.fest3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest3.Name = "fest3"
        Me.fest3.Size = New System.Drawing.Size(88, 32)
        Me.fest3.TabIndex = 2
        Me.fest3.Text = "★★★"
        Me.fest3.UseVisualStyleBackColor = True
        '
        'fest2
        '
        Me.fest2.AutoSize = True
        Me.fest2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fest2.Location = New System.Drawing.Point(23, 43)
        Me.fest2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest2.Name = "fest2"
        Me.fest2.Size = New System.Drawing.Size(70, 32)
        Me.fest2.TabIndex = 1
        Me.fest2.Text = "★★"
        Me.fest2.UseVisualStyleBackColor = True
        '
        'fest1
        '
        Me.fest1.AutoSize = True
        Me.fest1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fest1.Location = New System.Drawing.Point(23, 17)
        Me.fest1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fest1.Name = "fest1"
        Me.fest1.Size = New System.Drawing.Size(52, 32)
        Me.fest1.TabIndex = 0
        Me.fest1.Text = "★"
        Me.fest1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filtro"
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRegresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegresar.Location = New System.Drawing.Point(17, 489)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(183, 53)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Location = New System.Drawing.Point(11, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 39)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.BackgroundImage = Global.ProyLibreteao.My.Resources.Resources.buscar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBuscar.Location = New System.Drawing.Point(158, 1)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(36, 36)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BackColor = System.Drawing.Color.DimGray
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscador.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtBuscador.ForeColor = System.Drawing.Color.White
        Me.txtBuscador.Location = New System.Drawing.Point(7, 4)
        Me.txtBuscador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(149, 31)
        Me.txtBuscador.TabIndex = 0
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.PictureBox3)
        Me.PanelSuperior.Controls.Add(Me.lblUsuario)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Controls.Add(Me.Label2)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1084, 70)
        Me.PanelSuperior.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.ProyLibreteao.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(1021, 9)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(931, 25)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(76, 23)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Invitado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyLibreteao.My.Resources.Resources.iconVerlibro
        Me.PictureBox1.Location = New System.Drawing.Point(35, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Librería"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(431, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo"
        '
        'FlowLayoutPanelContenedorLibros
        '
        Me.FlowLayoutPanelContenedorLibros.AutoScroll = True
        Me.FlowLayoutPanelContenedorLibros.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelContenedorLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelContenedorLibros.Location = New System.Drawing.Point(221, 70)
        Me.FlowLayoutPanelContenedorLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanelContenedorLibros.Name = "FlowLayoutPanelContenedorLibros"
        Me.FlowLayoutPanelContenedorLibros.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.FlowLayoutPanelContenedorLibros.Size = New System.Drawing.Size(863, 555)
        Me.FlowLayoutPanelContenedorLibros.TabIndex = 2
        '
        'CatalogoLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 625)
        Me.Controls.Add(Me.FlowLayoutPanelContenedorLibros)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CatalogoLibros"
        Me.Text = "CatalogoLibros"
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' Declaración de Controles
    Friend WithEvents PanelLateral As System.Windows.Forms.Panel
    Friend WithEvents PanelSuperior As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanelContenedorLibros As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents fest1 As CheckBox
    Friend WithEvents fest5 As CheckBox
    Friend WithEvents fest4 As CheckBox
    Friend WithEvents fest3 As CheckBox
    Friend WithEvents fest2 As CheckBox
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnBuscar As Button
End Class
