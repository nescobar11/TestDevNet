@ModelType TestEstudiantes.Models.Calificaciones
@Code
    ViewData("Title") = "Editar Calificación"
End Code

<div class="container mt-4">
    <h2>Editar Calificación</h2>
    <hr />

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()

        @Html.HiddenFor(Function(model) model.CalificacionId)

        @<div class="form-horizontal">
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div class="form-group row mb-3">
                @Html.Label("Estudiante", htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.DropDownList("EstudianteId", Nothing, "-- Seleccione un Estudiante --", New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.EstudianteId, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Materia, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Materia, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Materia, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Periodo, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Periodo, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Periodo, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Nota, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Nota, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Nota, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Guardar Cambios" class="btn btn-primary" />
                    @Html.ActionLink("Volver a la lista", "Index", Nothing, New With {.class = "btn btn-secondary ml-2"})
                </div>
            </div>
        </div>
    End Using
</div>