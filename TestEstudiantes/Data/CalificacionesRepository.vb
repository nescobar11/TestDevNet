Imports System.Data
Imports System.Data.SqlClient
Imports TestEstudiantes.Models

Namespace Data

    Public Class CalificacionesRepository

        Public Function ObtenerTodos() As List(Of Calificaciones)
            Dim lista As New List(Of Calificaciones)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Calificaciones", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 1 para SELECT (sin CalificacionId trae todos con JOIN)
                    cmd.Parameters.AddWithValue("@Opcion", 1)
                    cmd.Parameters.AddWithValue("@CalificacionId", DBNull.Value)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            lista.Add(MapCalificacion(reader))
                        End While
                    End Using
                End Using
            End Using
            Return lista
        End Function

        Public Function ObtenerPorId(id As Integer) As Calificaciones
            Dim calificacion As Calificaciones = Nothing
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Calificaciones", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 1 para SELECT con ID específico
                    cmd.Parameters.AddWithValue("@Opcion", 1)
                    cmd.Parameters.AddWithValue("@CalificacionId", id)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            calificacion = MapCalificacion(reader)
                        End If
                    End Using
                End Using
            End Using
            Return calificacion
        End Function

        Public Sub Insertar(c As Calificaciones)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Calificaciones", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 2 para INSERT
                    cmd.Parameters.AddWithValue("@Opcion", 2)
                    cmd.Parameters.AddWithValue("@EstudianteId", c.EstudianteId)
                    cmd.Parameters.AddWithValue("@Materia", c.Materia)
                    cmd.Parameters.AddWithValue("@Periodo", c.Periodo)
                    cmd.Parameters.AddWithValue("@Nota", c.Nota)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Actualizar(c As Calificaciones)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Calificaciones", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 3 para UPDATE
                    cmd.Parameters.AddWithValue("@Opcion", 3)
                    cmd.Parameters.AddWithValue("@CalificacionId", c.CalificacionId)
                    cmd.Parameters.AddWithValue("@EstudianteId", c.EstudianteId)
                    cmd.Parameters.AddWithValue("@Materia", c.Materia)
                    cmd.Parameters.AddWithValue("@Periodo", c.Periodo)
                    cmd.Parameters.AddWithValue("@Nota", c.Nota)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Eliminar(id As Integer)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_CRUD_Calificaciones", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' @Opcion = 4 para DELETE
                    cmd.Parameters.AddWithValue("@Opcion", 4)
                    cmd.Parameters.AddWithValue("@CalificacionId", id)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Function MapCalificacion(reader As SqlDataReader) As Calificaciones
            Dim cal As New Calificaciones With {
                .CalificacionId = Convert.ToInt32(reader("CalificacionId")),
                .EstudianteId = Convert.ToInt32(reader("EstudianteId")),
                .Materia = reader("Materia").ToString(),
                .Periodo = reader("Periodo").ToString(),
                .Nota = Convert.ToDecimal(reader("Nota"))
            }


            If HasColumn(reader, "Nombre") AndAlso Not reader("Nombre") Is DBNull.Value Then
                cal.NombreEstudiante = reader("Nombre").ToString()
            End If
            If HasColumn(reader, "Apellido") AndAlso Not reader("Apellido") Is DBNull.Value Then
                cal.ApellidoEstudiante = reader("Apellido").ToString()
            End If
            If HasColumn(reader, "Documento") AndAlso Not reader("Documento") Is DBNull.Value Then
                cal.DocumentoEstudiante = reader("Documento").ToString()
            End If

            Return cal
        End Function

        'valida si una columna existe en el DataReader (evita errores al cambiar entre consultas)
        Private Function HasColumn(reader As IDataRecord, columnName As String) As Boolean
            For i As Integer = 0 To reader.FieldCount - 1
                If reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase) Then
                    Return True
                End If
            Next
            Return False
        End Function

    End Class

End Namespace