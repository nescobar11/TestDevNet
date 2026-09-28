@ModelType IEnumerable(Of TestEstudiantes.Models.Calificaciones)
@Code
    ViewData("Title") = "Listado de Calificaciones"
End Code

<div class="container mt-4">
    <h2>Listado de Calificaciones</h2>
    <hr />

    @If TempData("Mensaje") IsNot Nothing Then
        @<div class="alert alert-success alert-dismissible fade show" role="alert">
            @TempData("Mensaje")
        </div>
    End If

    <p>
        @Html.ActionLink("Registrar Nueva Calificación", "Create", Nothing, New With {.class = "btn btn-primary"})
    </p>

    <table class="table table-striped table-bordered">
        <thead class="thead-dark">
            <tr>
                <th>Estudiante</th>
                <th>Materia</th>
                <th>Periodo</th>
                <th>Nota</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                @<tr>
                    <td>@item.NombreEstudiante</td>
                    <td>@item.Materia</td>
                    <td>@item.Periodo</td>
                    <td>@item.Nota</td>
                    <td>
                        @Html.ActionLink("Editar", "Edit", New With {.id = item.CalificacionId}, New With {.class = "btn btn-sm btn-warning"}) |
                        @Html.ActionLink("Detalles", "Details", New With {.id = item.CalificacionId}, New With {.class = "btn btn-sm btn-info"}) |
                        @Html.ActionLink("Eliminar", "Delete", New With {.id = item.CalificacionId}, New With {.class = "btn btn-sm btn-danger"})
                    </td>
                </tr>
            Next
        </tbody>
    </table>
</div>