Imports System.Data
Imports System.Data.SqlClient
Imports TestEstudiantes.Models

Namespace Data

    Public Class EstudiantesRepository

        Public Function ObtenerTodos() As List(Of Estudiantes)
            Dim lista As New List(Of Estudiantes)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Estudiantes", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 1 para consultar todos 
                    cmd.Parameters.AddWithValue("@Opcion", 1)
                    cmd.Parameters.AddWithValue("@EstudianteId", DBNull.Value)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            lista.Add(MapEstudiante(reader))
                        End While
                    End Using
                End Using
            End Using
            Return lista
        End Function

        Public Function ObtenerPorId(id As Integer) As Estudiantes
            Dim estudiante As Estudiantes = Nothing
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Estudiantes", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 1 consultar por ID
                    cmd.Parameters.AddWithValue("@Opcion", 1)
                    cmd.Parameters.AddWithValue("@EstudianteId", id)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            estudiante = MapEstudiante(reader)
                        End If
                    End Using
                End Using
            End Using
            Return estudiante
        End Function

        Public Sub Insertar(e As Estudiantes)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Estudiantes", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 2 insertar un nuevo estudiante
                    cmd.Parameters.AddWithValue("@Opcion", 2)
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre)
                    cmd.Parameters.AddWithValue("@Apellido", e.Apellido)
                    cmd.Parameters.AddWithValue("@Documento", e.Documento)
                    cmd.Parameters.AddWithValue("@FechaNacimiento", If(e.FechaNacimiento = DateTime.MinValue, CType(DBNull.Value, Object), e.FechaNacimiento))
                    cmd.Parameters.AddWithValue("@Genero", If(String.IsNullOrEmpty(e.Genero), CType(DBNull.Value, Object), e.Genero))
                    cmd.Parameters.AddWithValue("@Curso", If(String.IsNullOrEmpty(e.Curso), CType(DBNull.Value, Object), e.Curso))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Actualizar(e As Estudiantes)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Estudiantes", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 3 actualizar
                    cmd.Parameters.AddWithValue("@Opcion", 3)
                    cmd.Parameters.AddWithValue("@EstudianteId", e.EstudianteId)
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre)
                    cmd.Parameters.AddWithValue("@Apellido", e.Apellido)
                    cmd.Parameters.AddWithValue("@Documento", e.Documento)
                    cmd.Parameters.AddWithValue("@FechaNacimiento", If(e.FechaNacimiento = DateTime.MinValue, CType(DBNull.Value, Object), e.FechaNacimiento))
                    cmd.Parameters.AddWithValue("@Genero", If(String.IsNullOrEmpty(e.Genero), CType(DBNull.Value, Object), e.Genero))
                    cmd.Parameters.AddWithValue("@Curso", If(String.IsNullOrEmpty(e.Curso), CType(DBNull.Value, Object), e.Curso))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Eliminar(id As Integer)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Estudiantes", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 4 eliminar
                    cmd.Parameters.AddWithValue("@Opcion", 4)
                    cmd.Parameters.AddWithValue("@EstudianteId", id)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Function MapEstudiante(reader As SqlDataReader) As Estudiantes
            Return New Estudiantes With {
                .EstudianteId = Convert.ToInt32(reader("EstudianteId")),
                .Nombre = reader("Nombre").ToString(),
                .Apellido = reader("Apellido").ToString(),
                .Documento = reader("Documento").ToString(),
                .FechaNacimiento = If(reader("FechaNacimiento") Is DBNull.Value, DateTime.MinValue, Convert.ToDateTime(reader("FechaNacimiento"))),
                .Genero = If(reader("Genero") Is DBNull.Value, String.Empty, reader("Genero").ToString()),
                .Curso = If(reader("Curso") Is DBNull.Value, String.Empty, reader("Curso").ToString()),
                .FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
            }
        End Function

    End Class

End Namespace