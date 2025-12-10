<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputs
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Purple
        Me.PanelHeader.Controls.Add(Me.LblTitulo)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(474, 75)
        Me.PanelHeader.TabIndex = 0
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Location = New System.Drawing.Point(172, 23)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(144, 28)
        Me.LblTitulo.TabIndex = 4
        Me.LblTitulo.Text = "Nuevo Pedido"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.OldLace
        Me.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnOk.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnOk.Location = New System.Drawing.Point(246, 189)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(212, 53)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "Aceptar"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(246, 71)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(204, 26)
        Me.Txt1.TabIndex = 2
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(246, 135)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(204, 26)
        Me.Txt2.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(13, 68)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(99, 21)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "ID USUARIO"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(13, 132)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(75, 21)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "ID LIBRO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.50215!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.49785!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOk, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 75)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 260)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INGRESE LOS DATOS "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmInputs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(474, 335)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "FrmInputs"
        Me.Text = "Nuevo Pedido"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents BtnOk As Button
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
