<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>
        @Code
            Dim titulo = If(ViewData("Title") IsNot Nothing, ViewData("Title").ToString(), "Class101")
            @titulo
        End Code
        - Class101
    </title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <!-- BARRA DE NAVEGACIÓN SUPERIOR -->
    <div class="navbar navbar-inverse navbar-fixed-top" style="background-color: #333; padding: 10px 0;">
        <div class="container" style="display: flex; justify-content: space-between; align-items: center;">
            <div>
                @Html.ActionLink("Class101", "Index", "Estudiante", New With {.area = ""}, New With {.style = "color: white; font-weight: bold; font-size: 20px; text-decoration: none;"})
            </div>
            <div>
                <ul style="list-style: none; margin: 0; padding: 0; display: flex; gap: 20px;">
                    <li>@Html.ActionLink("Estudiantes", "Index", "Estudiante", Nothing, New With {.style = "color: white; text-decoration: none;"})</li>
                    <li>@Html.ActionLink("Calificaciones", "Index", "Calificaciones", Nothing, New With {.style = "color: white; text-decoration: none;"})</li>
                    <li>@Html.ActionLink("Reportes", "Index", "Reportes", Nothing, New With {.style = "color: white; text-decoration: none;"})</li>
                </ul>
            </div>
        </div>
    </div>

    <!-- CONTENEDOR PRINCIPAL DE LAS VISTAS -->
    <div class="container body-content" style="margin-top: 80px;">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Class101</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>