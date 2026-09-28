@ModelType IEnumerable(Of TestEstudiantes.Models.EstudianteNotMinima)
@Code
    ViewData("Title") = "Reporte de Estudiantes por Nota Mínima"
End Code

<div class="container mt-4">
    <h2>Reporte: Estudiantes por Nota Mínima</h2>
    <hr />

    @Using Html.BeginForm("Index", "Reportes", FormMethod.Get, New With {.class = "form-inline mb-4"})
        @<div class="input-group">
            <label for="notaMinima" class="mr-2 font-weight-bold align-self-center">Nota Mínima:</label>
            <input type="number" step="0.1" name="notaMinima" id="notaMinima" class="form-control mr-2" value="@Request.QueryString("notaMinima")" placeholder="3.0" required />
            <button type="submit" class="btn btn-primary">Filtrar</button>
        </div>
    End Using

    @If Model IsNot Nothing AndAlso Model.Any() Then
        @<table class="table table-striped table-bordered">
            <thead class="thead-dark">
                <tr>
                    <th>Estudiante</th>
                    <th>Curso</th>
                    <th>Materia</th>
                    <th>Periodo</th>
                    <th>Nota</th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>
                        <td>@item.Nombre @item.Apellido</td>
                        <td>@item.Curso</td>
                        <td>@item.Materia</td>
                        <td>@item.Periodo</td>
                        <td><strong>@item.Nota</strong></td>
                    </tr>
                Next
            </tbody>
        </table>
    Else
        @<div class="alert alert-warning" role="alert">
            No se encontraron registros con los criterios de búsqueda especificados o aún no se ha aplicado un filtro.
        </div>
    End If

    <div class="mt-3">
        @Html.ActionLink("Volver al Inicio", "Index", "Estudiantes", Nothing, New With {.class = "btn btn-secondary"})
    </div>
</div>