@ModelType TestEstudiantes.Models.Estudiantes
@Code
    ViewData("Title") = "Detalles del Estudiante"
End Code

<div class="container mt-4">
    <h2>Detalles del Estudiante</h2>
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
    </div>

    <div class="mt-3">
        @Html.ActionLink("Editar", "Edit", New With {.id = Model.EstudianteId}, New With {.class = "btn btn-warning"})
        @Html.ActionLink("Volver a la lista", "Index", Nothing, New With {.class = "btn btn-secondary ml-2"})
    </div>
</div>