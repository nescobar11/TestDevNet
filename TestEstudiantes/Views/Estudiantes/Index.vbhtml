@ModelType IEnumerable(Of TestEstudiantes.Models.Estudiantes)
@Code
    ViewData("Title") = "Listado de Estudiantes"
End Code

<div class="container mt-4">
    <h2>Listado de Estudiantes</h2>
    <hr />

    @If TempData("Mensaje") IsNot Nothing Then
        @<div class="alert alert-success alert-dismissible fade show" role="alert">
            @TempData("Mensaje")
        </div>
    End If

    <p>
        @Html.ActionLink("Registrar Nuevo Estudiante", "Create", Nothing, New With {.class = "btn btn-primary"})
    </p>

    <table class="table table-striped table-bordered">
        <thead class="thead-dark">
            <tr>
                <th>Documento</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Curso</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                @<tr>
                    <td>@item.Documento</td>
                    <td>@item.Nombre</td>
                    <td>@item.Apellido</td>
                    <td>@item.Curso</td>
                    <td>
                        @Html.ActionLink("Editar", "Edit", New With {.id = item.EstudianteId}, New With {.class = "btn btn-sm btn-warning"}) |
                        @Html.ActionLink("Detalles", "Details", New With {.id = item.EstudianteId}, New With {.class = "btn btn-sm btn-info"}) |
                        @Html.ActionLink("Eliminar", "Delete", New With {.id = item.EstudianteId}, New With {.class = "btn btn-sm btn-danger"})
                    </td>
                </tr>
            Next
        </tbody>
    </table>
</div>