Imports System.Data.SqlClient

Public Class ClaseContenidoLibros
    ' Referencias a los controles del formulario
    Private ReadOnly dgvCatalogo As DataGridView

    ' Instancia de tu clase de base de datos
    Private db As New Database()

    ' Constructor: Recibe el DataGridView donde se mostrarán los datos
    Public Sub New(dgv As DataGridView)
        Me.dgvCatalogo = dgv
    End Sub

    ' ========================================================
    ' MÉTODO: CARGAR/BUSCAR LIBROS
    ' ========================================================
    Public Sub MostrarCatalogo(Optional filtro As String = "")
        If dgvCatalogo Is Nothing Then Return

        ' 1. Configurar diseño del Grid
        dgvCatalogo.Columns.Clear()
        dgvCatalogo.Rows.Clear()
        dgvCatalogo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvCatalogo.EnableHeadersVisualStyles = False
        dgvCatalogo.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvCatalogo.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' 2. Definir Columnas
        dgvCatalogo.Columns.Add("ID", "ID")
        dgvCatalogo.Columns.Add("Titulo", "Título")
        dgvCatalogo.Columns.Add("Autor", "Autor Principal") ' Mostramos el primer autor encontrado
        dgvCatalogo.Columns.Add("Categoria", "Categoría")
        dgvCatalogo.Columns.Add("Estado", "Disponibilidad")

        ' 3. Consulta SQL Optimizada
        ' Usamos una subconsulta para el Autor para evitar filas duplicadas si un libro tiene varios autores.
        Dim query As String = "
            SELECT 
                l.id_libro, 
                l.titulo, 
                c.nombre_categoria, 
                l.disponibilidad,
                ISNULL((SELECT TOP 1 a.nombre_autor 
                        FROM autores a 
                        INNER JOIN libro_autor la ON a.id_autor = la.id_autor 
                        WHERE la.id_libro = l.id_libro), 'Sin Autor') as AutorPrincipal
            FROM libro l
            INNER JOIN categorias c ON l.id_categoria = c.id_categoria
            WHERE 
                (@filtro = '' OR 
                 l.titulo LIKE '%' + @filtro + '%' OR 
                 c.nombre_categoria LIKE '%' + @filtro + '%')"

        Dim parametros As New List(Of SqlParameter)
        parametros.Add(New SqlParameter("@filtro", If(filtro, "")))

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, parametros)

            For Each row As DataRow In dt.Rows
                ' Convertir bit 1/0 a texto amigable
                Dim estado As String = If(Convert.ToBoolean(row("disponibilidad")), "Disponible", "Prestado")

                dgvCatalogo.Rows.Add(
                    row("id_libro"),
                    row("titulo"),
                    row("AutorPrincipal"),
                    row("nombre_categoria"),
                    estado
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar el catálogo: " & ex.Message)
        End Try
    End Sub

    ' ========================================================
    ' MÉTODO: ELIMINAR LIBRO
    ' Cumple con la funcionalidad de "Eliminar" del RF7
    ' ========================================================
    Public Sub EliminarLibroSeleccionado()
        ' Validar que haya una fila seleccionada
        If dgvCatalogo.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un libro para eliminar.")
            Return
        End If

        ' Obtener el ID de la fila seleccionada (Asumiendo que ID es la columna 0)
        Dim idLibro As Integer = Convert.ToInt32(dgvCatalogo.SelectedRows(0).Cells(0).Value)
        Dim titulo As String = dgvCatalogo.SelectedRows(0).Cells(1).Value.ToString()

        ' Confirmación de seguridad
        Dim confirmacion As DialogResult = MessageBox.Show(
            $"¿Está seguro que desea eliminar el libro '{titulo}'? Esta acción no se puede deshacer.",
            "Confirmar Eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirmacion = DialogResult.Yes Then
            ' Consulta DELETE
            Dim query As String = "DELETE FROM libro WHERE id_libro = @id"
            Dim parametros As New List(Of SqlParameter)
            parametros.Add(New SqlParameter("@id", idLibro))

            Try
                Dim filasAfectadas As Integer = db.ExecuteNonQuery(query, parametros)
                If filasAfectadas > 0 Then
                    MessageBox.Show("Libro eliminado correctamente.")
                    ' Recargar la tabla para reflejar cambios
                    MostrarCatalogo()
                Else
                    MessageBox.Show("No se pudo eliminar el libro.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar (Puede que tenga préstamos activos): " & ex.Message)
            End Try
        End If
    End Sub

End Class