' --- Importación de bibliotecas ---
Imports System.IO
' Proporciona acceso a clases para operaciones de lectura y escritura en archivos.'
' --- Definición de la clase principal ---
Public Class Form1
    ' Declaración de variables globales a utilizar'
    Dim A(,) As Integer
    Dim B(,) As Integer
    Dim C(,) As Integer
    Dim FILAS As Integer
    Dim COLUMNAS As Integer
    ' --- Evento del botón "Iniciar" ---
    Private Sub Btn_Iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click
        ' Abre un cuadro de diálogo para seleccionar un archivo de texto.
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        ' Verifica si se seleccionó un archivo.
        If openFileDialog.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("No se seleccionó un archivo.", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Procesa el archivo seleccionado.
        Dim archivo As String = openFileDialog.FileName
        Try
            LeerMatrices(archivo) ' Carga las matrices desde el archivo.
            MostrarMatriz(DataGridViewMatrizA, A, "Matriz A") ' Muestra matriz A.
            MostrarMatriz(DataGridViewMatrizB, B, "Matriz B") ' Muestra matriz B.
            ' Valida si las matrices son compatibles para la suma.
            If Not ValidarCompatibilidad() Then
                MessageBox.Show("Las matrices no tienen las mismas dimensiones y no pueden ser sumadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Habilita el botón para sumar matrices.
            Btn_Sumar.Enabled = True
            MessageBox.Show("Las matrices se cargaron correctamente. Ahora puede realizar la suma o guardar el resultado.", "Éxito", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al procesar el archivo: {ex.Message}", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Leer las matrices desde un archivo ---
    Private Sub LeerMatrices(ruta As String)
        ' Abre el archivo y lee las matrices, validando el formato y las dimensiones.
        Try
            Using lector As New StreamReader(ruta)
                ' Leer dimensiones y datos de la matriz A.
                Dim dimensionesA() As String = lector.ReadLine().Split(" "c)
                FILAS = Integer.Parse(dimensionesA(0))
                COLUMNAS = Integer.Parse(dimensionesA(1))
                ReDim A(FILAS - 1, COLUMNAS - 1)
                For i As Integer = 0 To FILAS - 1
                    Dim filaA() As String = lector.ReadLine().Split(" "c)
                    For j As Integer = 0 To COLUMNAS - 1
                        A(i, j) = Integer.Parse(filaA(j))
                    Next
                Next
                ' Leer dimensiones y datos de la matriz B.
                Dim dimensionesB() As String = lector.ReadLine().Split(" "c)
                If Integer.Parse(dimensionesB(0)) <> FILAS OrElse
               Integer.Parse(dimensionesB(1)) <> COLUMNAS Then
                    Throw New Exception("Las dimensiones de las matrices no coinciden.")
                End If
                ReDim B(FILAS - 1, COLUMNAS - 1)
                For i As Integer = 0 To FILAS - 1
                    Dim filaB() As String = lector.ReadLine().Split(" "c)
                    For j As Integer = 0 To COLUMNAS - 1
                        B(i, j) = Integer.Parse(filaB(j))
                    Next
                Next
            End Using
        Catch ex As IOException
            Throw New Exception("Error al leer el archivo: Verifique el formato y contenido del archivo.")
        Catch ex As FormatException
            Throw New Exception("Error en el formato de los datos: Asegúrese de que los valores sean numéricos.")
        End Try
    End Sub
    ' --- Validar la compatibilidad de las matrices ---
    Private Function ValidarCompatibilidad() As Boolean
        ' Comprueba si las dimensiones de A y B son iguales.
        Return A.GetLength(0) = B.GetLength(0) AndAlso A.GetLength(1) = B.GetLength(1)
    End Function
    ' --- Sumar las matrices ---
    Private Sub SumarMatrices()
        ' Calcula la suma de las matrices A y B, y almacena el resultado en C.
        ReDim C(FILAS - 1, COLUMNAS - 1)
        For i As Integer = 0 To FILAS - 1
            For j As Integer = 0 To COLUMNAS - 1
                C(i, j) = A(i, j) + B(i, j)
            Next
        Next
    End Sub
    ' --- Mostrar una matriz en un DataGridView ---
    Private Sub MostrarMatriz(dgv As DataGridView, matriz(,) As Integer, titulo As String)
        ' Limpia el contenido previo y configura las columnas del DataGridView.
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        dgv.Tag = titulo
        ' Crear las columnas.
        For j As Integer = 0 To matriz.GetLength(1) - 1
            dgv.Columns.Add($"Col{j + 1}", $"Columna {j + 1}")
        Next
        ' Agregar las filas con valores de la matriz.
        For i As Integer = 0 To matriz.GetLength(0) - 1
            Dim fila(matriz.GetLength(1) - 1) As String
            For j As Integer = 0 To matriz.GetLength(1) - 1
                fila(j) = matriz(i, j).ToString()
            Next
            dgv.Rows.Add(fila)
        Next
        dgv.Refresh()
    End Sub
    ' --- Guardar el resultado en un archivo ---
    Private Sub GuardarMatrizResultado()
        ' Guarda el contenido de la matriz C en un archivo de texto con formato de tabla.
        Dim ruta As String = "resultado_formato_tabla.txt"
        Try
            Using escritor As New StreamWriter(ruta)
                escritor.WriteLine("Resultado de la suma de las matrices (formato de tabla):")
                escritor.WriteLine(New String("-"c, 10 * COLUMNAS)) ' Separador superior
                For i As Integer = 0 To FILAS - 1
                    Dim linea As String = String.Join(" | ", Enumerable.Range(0,
                   COLUMNAS).Select(Function(j) C(i, j).ToString().PadLeft(5)))
                    escritor.WriteLine($"| {linea} |")
                Next
                escritor.WriteLine(New String("-"c, 10 * COLUMNAS)) ' Separador inferior
            End Using
            MessageBox.Show("El resultado fue guardado correctamente en formato de tabla.",
           "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show("Error al guardar el archivo de resultado con formato de tabla.",
           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Botón "Sumar" ---
    Private Sub Btn_Sumar_Click(sender As Object, e As EventArgs) Handles Btn_Sumar.Click
        Try
            ' Realiza la suma de las matrices A y B.
            If Not ValidarCompatibilidad() Then
                MessageBox.Show("Las matrices no son compatibles para la suma.", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SumarMatrices()
            MostrarMatriz(DataGridViewResultado, C, "Resultado") ' Muestra el resultado en el DataGridView.
            Btn_GuardarResultado.Enabled = True ' Habilita el botón para guardar la suma de las matrices.
        Catch ex As Exception
            MessageBox.Show($"Error al sumar las matrices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Botón "Guardar Resultado" ---
    Private Sub Btn_GuardarResultado_Click(sender As Object, e As EventArgs) Handles Btn_GuardarResultado.Click
        Try
            GuardarMatrizResultado()
        Catch ex As Exception
            MessageBox.Show($"Error al guardar el resultado: {ex.Message}", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Botón "Salir" ---
    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub
End Class