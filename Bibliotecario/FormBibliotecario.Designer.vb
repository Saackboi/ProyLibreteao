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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UccReportes11 = New ProyLibreteao.UCCReportes1()
        Me.UcHeader2 = New ProyLibreteao.UCHeader()
        Me.UcNav2 = New ProyLibreteao.UCNav()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UccReportes11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(187, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Panel1.Size = New System.Drawing.Size(600, 373)
        Me.Panel1.TabIndex = 2
        '
        'UccReportes11
        '
        Me.UccReportes11.AutoSize = True
        Me.UccReportes11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UccReportes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UccReportes11.Location = New System.Drawing.Point(3, 3)
        Me.UccReportes11.Margin = New System.Windows.Forms.Padding(1)
        Me.UccReportes11.Name = "UccReportes11"
        Me.UccReportes11.Size = New System.Drawing.Size(590, 363)
        Me.UccReportes11.TabIndex = 0
        '
        'UcHeader2
        '
        Me.UcHeader2.AutoScroll = True
        Me.UcHeader2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.UcHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcHeader2.Location = New System.Drawing.Point(187, 0)
        Me.UcHeader2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcHeader2.Name = "UcHeader2"
        Me.UcHeader2.Padding = New System.Windows.Forms.Padding(3)
        Me.UcHeader2.Size = New System.Drawing.Size(600, 68)
        Me.UcHeader2.TabIndex = 1
        '
        'UcNav2
        '
        Me.UcNav2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.UcNav2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UcNav2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNav2.Location = New System.Drawing.Point(0, 0)
        Me.UcNav2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.UcNav2.Name = "UcNav2"
        Me.UcNav2.Size = New System.Drawing.Size(187, 441)
        Me.UcNav2.TabIndex = 0
        '
        'FormBibliotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UcHeader2)
        Me.Controls.Add(Me.UcNav2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(803, 480)
        Me.Name = "FormBibliotecario"
        Me.Text = "Formulario Bibliotecario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcNav2 As UCNav
    Friend WithEvents UcHeader2 As UCHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UccReportes11 As UCCReportes1
End Class
