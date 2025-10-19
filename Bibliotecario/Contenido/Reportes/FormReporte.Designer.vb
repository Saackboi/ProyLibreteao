<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpReporte = New System.Windows.Forms.TableLayoutPanel()
        Me.tcReportes = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDescarga = New System.Windows.Forms.Button()
        Me.dgvTablaInfoReporte = New System.Windows.Forms.DataGridView()
        Me.btnFiltroReporte = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lblTituloTabControl = New System.Windows.Forms.Label()
        Me.tlpReporte.SuspendLayout()
        Me.tcReportes.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpReporte
        '
        Me.tlpReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tlpReporte.ColumnCount = 1
        Me.tlpReporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpReporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpReporte.Controls.Add(Me.tcReportes, 0, 1)
        Me.tlpReporte.Controls.Add(Me.lblTituloTabControl, 0, 0)
        Me.tlpReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpReporte.Location = New System.Drawing.Point(0, 0)
        Me.tlpReporte.Name = "tlpReporte"
        Me.tlpReporte.RowCount = 2
        Me.tlpReporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03086!))
        Me.tlpReporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.96914!))
        Me.tlpReporte.Size = New System.Drawing.Size(1200, 675)
        Me.tlpReporte.TabIndex = 3
        '
        'tcReportes
        '
        Me.tcReportes.Controls.Add(Me.TabPage5)
        Me.tcReportes.Controls.Add(Me.TabPage6)
        Me.tcReportes.Controls.Add(Me.TabPage7)
        Me.tcReportes.Controls.Add(Me.TabPage8)
        Me.tcReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcReportes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tcReportes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcReportes.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tcReportes.Location = New System.Drawing.Point(2, 69)
        Me.tcReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.tcReportes.Multiline = True
        Me.tcReportes.Name = "tcReportes"
        Me.tcReportes.SelectedIndex = 0
        Me.tcReportes.Size = New System.Drawing.Size(1196, 604)
        Me.tcReportes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tcReportes.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.ForeColor = System.Drawing.Color.Purple
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(1188, 566)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Resumen De Informe "
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.ForeColor = System.Drawing.Color.Purple
        Me.TabPage6.Location = New System.Drawing.Point(4, 34)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Size = New System.Drawing.Size(1188, 566)
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
        Me.TableLayoutPanel2.Controls.Add(Me.btnDescarga, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvTablaInfoReporte, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnFiltroReporte, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 505.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1184, 565)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnDescarga
        '
        Me.btnDescarga.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDescarga.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnDescarga.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescarga.ForeColor = System.Drawing.Color.White
        Me.btnDescarga.Location = New System.Drawing.Point(1031, 3)
        Me.btnDescarga.Name = "btnDescarga"
        Me.btnDescarga.Size = New System.Drawing.Size(96, 40)
        Me.btnDescarga.TabIndex = 3
        Me.btnDescarga.Text = "Descargar Reportes"
        Me.btnDescarga.UseVisualStyleBackColor = False
        '
        'dgvTablaInfoReporte
        '
        Me.dgvTablaInfoReporte.AllowUserToAddRows = False
        Me.dgvTablaInfoReporte.AllowUserToDeleteRows = False
        Me.dgvTablaInfoReporte.AllowUserToResizeColumns = False
        Me.dgvTablaInfoReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTablaInfoReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTablaInfoReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTablaInfoReporte.BackgroundColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTablaInfoReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTablaInfoReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTablaInfoReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTablaInfoReporte.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTablaInfoReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTablaInfoReporte.EnableHeadersVisualStyles = False
        Me.dgvTablaInfoReporte.GridColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.Location = New System.Drawing.Point(3, 63)
        Me.dgvTablaInfoReporte.Name = "dgvTablaInfoReporte"
        Me.dgvTablaInfoReporte.ReadOnly = True
        Me.dgvTablaInfoReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablaInfoReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTablaInfoReporte.RowHeadersVisible = False
        Me.dgvTablaInfoReporte.RowHeadersWidth = 62
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvTablaInfoReporte.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTablaInfoReporte.RowTemplate.Height = 28
        Me.dgvTablaInfoReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablaInfoReporte.Size = New System.Drawing.Size(969, 499)
        Me.dgvTablaInfoReporte.TabIndex = 0
        '
        'btnFiltroReporte
        '
        Me.btnFiltroReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFiltroReporte.BackColor = System.Drawing.Color.White
        Me.btnFiltroReporte.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnFiltroReporte.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltroReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnFiltroReporte.Image = Global.ProyLibreteao.My.Resources.Resources.iconoFiltro
        Me.btnFiltroReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltroReporte.Location = New System.Drawing.Point(3, 26)
        Me.btnFiltroReporte.Name = "btnFiltroReporte"
        Me.btnFiltroReporte.Size = New System.Drawing.Size(92, 31)
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
        Me.TabPage7.Location = New System.Drawing.Point(4, 34)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1188, 566)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "Libros Más Solicitados "
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage8.ForeColor = System.Drawing.Color.Purple
        Me.TabPage8.Location = New System.Drawing.Point(4, 34)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1188, 566)
        Me.TabPage8.TabIndex = 3
        Me.TabPage8.Text = "Multas Por Usuario"
        '
        'lblTituloTabControl
        '
        Me.lblTituloTabControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTituloTabControl.AutoSize = True
        Me.lblTituloTabControl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTabControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTituloTabControl.Location = New System.Drawing.Point(541, 0)
        Me.lblTituloTabControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloTabControl.Name = "lblTituloTabControl"
        Me.lblTituloTabControl.Size = New System.Drawing.Size(117, 67)
        Me.lblTituloTabControl.TabIndex = 0
        Me.lblTituloTabControl.Text = "Bienvenida"
        Me.lblTituloTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.tlpReporte)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormReporte"
        Me.tlpReporte.ResumeLayout(False)
        Me.tlpReporte.PerformLayout()
        Me.tcReportes.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvTablaInfoReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpReporte As TableLayoutPanel
    Friend WithEvents tcReportes As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnDescarga As Button
    Friend WithEvents dgvTablaInfoReporte As DataGridView
    Friend WithEvents btnFiltroReporte As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents lblTituloTabControl As Label
End Class
