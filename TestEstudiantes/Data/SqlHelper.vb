Imports System.Data.SqlClient
Imports System.Configuration

Namespace Data

    Public Class SqlHelper
        Public Shared Function GetConnection() As SqlConnection
            Dim connStr As String = ConfigurationManager.ConnectionStrings("Class101Entities1").ConnectionString
            Return New SqlConnection(connStr)
        End Function
    End Class

End Namespace