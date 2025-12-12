<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibroCard
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Controles agregados a la Card
    Friend WithEvents pbxPortada As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbxPortada = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        CType(Me.pbxPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxPortada
        '
        Me.pbxPortada.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxPortada.Location = New System.Drawing.Point(0, 35)
        Me.pbxPortada.Name = "pbxPortada"
        Me.pbxPortada.Size = New System.Drawing.Size(165, 200)
        Me.pbxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPortada.TabIndex = 0
        Me.pbxPortada.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(0, 235)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(165, 32)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutor
        '
        Me.lblAutor.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAutor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAutor.ForeColor = System.Drawing.Color.Gray
        Me.lblAutor.Location = New System.Drawing.Point(0, 267)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(165, 20)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "Autor"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LibroCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbxPortada)
        Me.Name = "LibroCard"
        Me.Padding = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.Size = New System.Drawing.Size(165, 260)
        CType(Me.pbxPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
