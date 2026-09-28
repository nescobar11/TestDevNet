Imports System.Web.Mvc
Imports TestEstudiantes.Data

Public Class ReportesController
    Inherits Controller

    Private repo As New ReportesRepository()

    ' GET: /Reportes
    Function Index(Optional notaMinima As Decimal = 3.0) As ActionResult
        Dim lista = repo.ObtenerEstudiantesConNotaMinima(notaMinima)
        ViewBag.NotaMinima = notaMinima

        Return View("Index", lista)
    End Function

End Class