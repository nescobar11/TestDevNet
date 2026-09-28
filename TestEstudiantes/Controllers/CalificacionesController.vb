Imports System.Web.Mvc
Imports TestEstudiantes.Data
Imports TestEstudiantes.Models

Public Class CalificacionesController
    Inherits Controller

    Private repo As New CalificacionesRepository()
    Private estudianteRepo As New EstudiantesRepository()

    ' GET: Calificaciones
    Function Index() As ActionResult
        Dim lista = repo.ObtenerTodos()
        Dim estudiantes = estudianteRepo.ObtenerTodos()

        For Each cal In lista
            Dim est = estudiantes.FirstOrDefault(Function(e) e.EstudianteId = cal.EstudianteId)
            cal.NombreEstudiante = If(est IsNot Nothing, est.NombreCompleto, "(desconocido)")
        Next

        Return View(lista)
    End Function

    ' GET: Calificaciones/Create
    Function Create() As ActionResult
        CargarDropdownEstudiantes()
        Return View(New Calificaciones())
    End Function

    ' POST: Calificaciones/Create
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(calificacion As Calificaciones) As ActionResult
        If ModelState.IsValid Then
            Try
                repo.Insertar(calificacion)
                TempData("Mensaje") = "Calificación registrada correctamente."
                Return RedirectToAction("Index")
            Catch ex As Exception
                ModelState.AddModelError("", "Ocurrió un error al guardar: " & ex.Message)
            End Try
        End If
        CargarDropdownEstudiantes(calificacion.EstudianteId)
        Return View(calificacion)
    End Function
    ' GET: Calificaciones/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Dim calificacion = repo.ObtenerPorId(id)
        If calificacion Is Nothing Then
            Return HttpNotFound()
        End If

        Dim estudiante = estudianteRepo.ObtenerPorId(calificacion.EstudianteId)
        If estudiante IsNot Nothing Then
            calificacion.NombreEstudiante = estudiante.NombreCompleto
        Else
            calificacion.NombreEstudiante = "(desconocido)"
        End If

        Return View(calificacion)
    End Function

    ' GET: Calificaciones/Edit/5
    Function Edit(id As Integer) As ActionResult
        Dim calificacion = repo.ObtenerPorId(id)
        If calificacion Is Nothing Then
            Return HttpNotFound()
        End If
        CargarDropdownEstudiantes(calificacion.EstudianteId)
        Return View(calificacion)
    End Function

    ' POST: Calificaciones/Edit/5
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(calificacion As Calificaciones) As ActionResult
        If ModelState.IsValid Then
            Try
                repo.Actualizar(calificacion)
                TempData("Mensaje") = "Calificación actualizada correctamente."
                Return RedirectToAction("Index")
            Catch ex As Exception
                ModelState.AddModelError("", "Ocurrió un error al actualizar: " & ex.Message)
            End Try
        End If
        CargarDropdownEstudiantes(calificacion.EstudianteId)
        Return View(calificacion)
    End Function

    ' GET: Calificaciones/Delete/5
    Function Delete(id As Integer) As ActionResult
        Dim calificacion = repo.ObtenerPorId(id)
        If calificacion Is Nothing Then
            Return HttpNotFound()
        End If
        Return View(calificacion)
    End Function

    ' POST: Calificaciones/Delete/5
    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(id As Integer) As ActionResult
        repo.Eliminar(id)
        TempData("Mensaje") = "Calificación eliminada."
        Return RedirectToAction("Index")
    End Function

    Private Sub CargarDropdownEstudiantes(Optional selectedId As Integer? = Nothing)
        Dim estudiantes = estudianteRepo.ObtenerTodos()
        ViewBag.EstudianteId = New SelectList(estudiantes, "EstudianteId", "NombreCompleto", selectedId)
    End Sub

End Class