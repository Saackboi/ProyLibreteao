<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewMatrizA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewMatrizB = New System.Windows.Forms.DataGridView()
        Me.DataGridViewResultado = New System.Windows.Forms.DataGridView()
        Me.Btn_GuardarResultado = New System.Windows.Forms.Button()
        Me.Btn_Sumar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Iniciar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewMatrizA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMatrizB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma de Matrices desde un Archivo"
        '
        'DataGridViewMatrizA
        '
        Me.DataGridViewMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatrizA.Location = New System.Drawing.Point(24, 89)
        Me.DataGridViewMatrizA.Name = "DataGridViewMatrizA"
        Me.DataGridViewMatrizA.Size = New System.Drawing.Size(362, 186)
        Me.DataGridViewMatrizA.TabIndex = 1
        '
        'DataGridViewMatrizB
        '
        Me.DataGridViewMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatrizB.Location = New System.Drawing.Point(413, 89)
        Me.DataGridViewMatrizB.Name = "DataGridViewMatrizB"
        Me.DataGridViewMatrizB.Size = New System.Drawing.Size(362, 186)
        Me.DataGridViewMatrizB.TabIndex = 2
        '
        'DataGridViewResultado
        '
        Me.DataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultado.Location = New System.Drawing.Point(24, 347)
        Me.DataGridViewResultado.Name = "DataGridViewResultado"
        Me.DataGridViewResultado.Size = New System.Drawing.Size(362, 186)
        Me.DataGridViewResultado.TabIndex = 3
        '
        'Btn_GuardarResultado
        '
        Me.Btn_GuardarResultado.Enabled = False
        Me.Btn_GuardarResultado.Location = New System.Drawing.Point(426, 459)
        Me.Btn_GuardarResultado.Name = "Btn_GuardarResultado"
        Me.Btn_GuardarResultado.Size = New System.Drawing.Size(178, 37)
        Me.Btn_GuardarResultado.TabIndex = 4
        Me.Btn_GuardarResultado.Text = "Guardar Suma"
        Me.Btn_GuardarResultado.UseVisualStyleBackColor = True
        '
        'Btn_Sumar
        '
        Me.Btn_Sumar.Enabled = False
        Me.Btn_Sumar.Location = New System.Drawing.Point(426, 385)
        Me.Btn_Sumar.Name = "Btn_Sumar"
        Me.Btn_Sumar.Size = New System.Drawing.Size(178, 37)
        Me.Btn_Sumar.TabIndex = 5
        Me.Btn_Sumar.Text = "Sumar Matrices"
        Me.Btn_Sumar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Salir.Location = New System.Drawing.Point(610, 459)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(178, 37)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_Iniciar
        '
        Me.Btn_Iniciar.Location = New System.Drawing.Point(610, 385)
        Me.Btn_Iniciar.Name = "Btn_Iniciar"
        Me.Btn_Iniciar.Size = New System.Drawing.Size(178, 37)
        Me.Btn_Iniciar.TabIndex = 7
        Me.Btn_Iniciar.Text = "Iniciar"
        Me.Btn_Iniciar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Matriz A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Matriz B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Resultado de la suma"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_GuardarResultado)
        Me.Controls.Add(Me.Btn_Sumar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Iniciar)
        Me.Controls.Add(Me.DataGridViewResultado)
        Me.Controls.Add(Me.DataGridViewMatrizB)
        Me.Controls.Add(Me.DataGridViewMatrizA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "PrintLine"
        CType(Me.DataGridViewMatrizA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMatrizB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMatrizA As DataGridView
    Friend WithEvents DataGridViewMatrizB As DataGridView
    Friend WithEvents DataGridViewResultado As DataGridView
    Friend WithEvents Btn_GuardarResultado As Button
    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Sumar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
