@ModelType TestEstudiantes.Models.Estudiantes
@Code
    ViewData("Title") = "Editar Estudiante"
End Code

<div class="container mt-4">
    <h2>Editar Estudiante</h2>
    <hr />

    @Using Html.BeginForm()
        @Html.AntiForgeryToken()
        
        @Html.HiddenFor(Function(model) model.EstudianteId)

        @<div class="form-horizontal">
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Documento, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Documento, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Documento, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Nombre, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Nombre, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Apellido, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Apellido, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Apellido, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group row mb-3">
                @Html.LabelFor(Function(model) model.Curso, htmlAttributes:=New With {.class = "control-label col-md-2 font-weight-bold"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Curso, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Curso, "", New With {.class = "text-danger"})
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