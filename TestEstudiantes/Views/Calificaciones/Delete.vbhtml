@ModelType TestEstudiantes.Models.Calificaciones
@Code
    ViewData("Title") = "Eliminar Calificación"
End Code

<div class="container mt-4">
    <h2>Eliminar Calificación</h2>
    <h3 class="text-danger">¿Estás seguro de que deseas eliminar este registro?</h3>
    <hr />

    <div>
        <dl class="row">
            <dt class="col-sm-2 font-weight-bold">Estudiante:</dt>
            <dd class="col-sm-10">@Model.NombreEstudiante</dd>

            <dt class="col-sm-2 font-weight-bold">Materia:</dt>
            <dd class="col-sm-10">@Model.Materia</dd>

            <dt class="col-sm-2 font-weight-bold">Periodo:</dt>
            <dd class="col-sm-10">@Model.Periodo</dd>

            <dt class="col-sm-2 font-weight-bold">Nota:</dt>
            <dd class="col-sm-10">@Model.Nota</dd>
        </dl>

        @Using Html.BeginForm()
            @Html.AntiForgeryToken()

            @<div class="form-actions no-color mt-3">
                <input type="submit" value="Eliminar" class="btn btn-danger" />
                @Html.ActionLink("Volver a la lista", "Index", Nothing, New With {.class = "btn btn-secondary ml-2"})
            </div>
        End Using
    </div>
</div>