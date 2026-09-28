@ModelType TestEstudiantes.Models.Calificaciones
@Code
    ViewData("Title") = "Detalles de Calificación"
End Code

<div class="container mt-4">
    <h2>Detalles de Calificación</h2>
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
    </div>

    <div class="mt-3">
        @Html.ActionLink("Editar", "Edit", New With {.id = Model.CalificacionId}, New With {.class = "btn btn-warning"})
        @Html.ActionLink("Volver a la lista", "Index", Nothing, New With {.class = "btn btn-secondary ml-2"})
    </div>
</div>