@ModelType TestEstudiantes.Models.Estudiantes
@Code
    ViewData("Title") = "Eliminar Estudiante"
End Code

<div class="container mt-4">
    <h2>Eliminar Estudiante</h2>
    <h3 class="text-danger">¿Estás seguro de que deseas eliminar este estudiante?</h3>
    <hr />

    <div>
        <dl class="row">
            <dt class="col-sm-2 font-weight-bold">Documento:</dt>
            <dd class="col-sm-10">@Model.Documento</dd>

            <dt class="col-sm-2 font-weight-bold">Nombre:</dt>
            <dd class="col-sm-10">@Model.Nombre</dd>

            <dt class="col-sm-2 font-weight-bold">Apellido:</dt>
            <dd class="col-sm-10">@Model.Apellido</dd>

            <dt class="col-sm-2 font-weight-bold">Curso:</dt>
            <dd class="col-sm-10">@Model.Curso</dd>
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