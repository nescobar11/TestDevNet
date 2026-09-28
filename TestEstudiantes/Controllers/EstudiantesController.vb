Imports System.Web.Mvc
Imports TestEstudiantes.Data
Imports TestEstudiantes.Models

Public Class EstudiantesController
    Inherits Controller

    Private repo As New EstudiantesRepository()

    ' GET: Estudiante
    Function Index() As ActionResult
        Return View(repo.ObtenerTodos())
    End Function

    ' GET: Estudiante/Details/5
    Function Details(id As Integer) As ActionResult
        Dim estudiante = repo.ObtenerPorId(id)
        If estudiante Is Nothing Then
            Return HttpNotFound()
        End If
        Return View(estudiante)
    End Function

    ' GET: Estudiante/Create
    Function Create() As ActionResult
        Return View(New Estudiantes())
    End Function

    ' POST: Estudiante/Create
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(estudiante As Estudiantes) As ActionResult
        If ModelState.IsValid Then
            Try
                repo.Insertar(estudiante)
                TempData("Mensaje") = "Estudiante creado correctamente."
                Return RedirectToAction("Index")
            Catch ex As Exception
                ModelState.AddModelError("", "Error al guardar: " & ex.Message)
            End Try
        End If
        Return View(estudiante)
    End Function

    ' GET: Estudiante/Edit/5
    Function Edit(id As Integer) As ActionResult
        Dim estudiante = repo.ObtenerPorId(id)
        If estudiante Is Nothing Then
            Return HttpNotFound()
        End If
        Return View(estudiante)
    End Function

    ' POST: Estudiante/Edit/5
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(estudiante As Estudiantes) As ActionResult
        If ModelState.IsValid Then
            Try
                repo.Actualizar(estudiante)
                TempData("Mensaje") = "Estudiante actualizado correctamente."
                Return RedirectToAction("Index")
            Catch ex As Exception
                ModelState.AddModelError("", "Error al actualizar: " & ex.Message)
            End Try
        End If
        Return View(estudiante)
    End Function

    ' GET: Estudiante/Delete/5
    Function Delete(id As Integer) As ActionResult
        Dim estudiante = repo.ObtenerPorId(id)
        If estudiante Is Nothing Then
            Return HttpNotFound()
        End If
        Return View(estudiante)
    End Function

    ' POST: Estudiante/Delete/5
    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(id As Integer) As ActionResult
        repo.Eliminar(id)
        TempData("Mensaje") = "Estudiante eliminado correctamente."
        Return RedirectToAction("Index")
    End Function

End Class