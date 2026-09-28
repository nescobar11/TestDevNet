Imports System.Data
Imports System.Data.SqlClient
Imports TestEstudiantes.Models

Namespace Data

    Public Class ReportesRepository
        Public Function ObtenerEstudiantesConNotaMinima(notaMinima As Decimal) As List(Of EstudianteNotMinima)
            Dim lista As New List(Of EstudianteNotMinima)
            Using conn As SqlConnection = SqlHelper.GetConnection()
                Using cmd As New SqlCommand("sp_Estudiantes_ConNotaMinima", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@NotaMinima", notaMinima)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            lista.Add(New EstudianteNotMinima With {
                                .EstudianteId = Convert.ToInt32(reader("EstudianteId")),
                                .Nombre = reader("Nombre").ToString(),
                                .Apellido = reader("Apellido").ToString(),
                                .Curso = reader("Curso").ToString(),
                                .Materia = reader("Materia").ToString(),
                                .Periodo = reader("Periodo").ToString(),
                                .Nota = Convert.ToDecimal(reader("Nota"))
                            })
                        End While
                    End Using
                End Using
            End Using
            Return lista
        End Function

    End Class

End Namespace