IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1001')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Juan', @Apellido = 'Pérez Gómez', @Documento = '1001', @FechaNacimiento = '2010-05-12', @Genero = 'M', @Curso = '10-A';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1002')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'María', @Apellido = 'López Ruiz', @Documento = '1002', @FechaNacimiento = '2009-08-20', @Genero = 'F', @Curso = '11-B';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1003')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Carlos', @Apellido = 'Ramírez Soto', @Documento = '1003', @FechaNacimiento = '2011-02-15', @Genero = 'M', @Curso = '9-C';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1004')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Ana', @Apellido = 'Martínez Díaz', @Documento = '1004', @FechaNacimiento = '2010-11-05', @Genero = 'F', @Curso = '10-A';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1005')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Luis', @Apellido = 'Torres Vega', @Documento = '1005', @FechaNacimiento = '2008-07-30', @Genero = 'M', @Curso = '11-B';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1006')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Sofía', @Apellido = 'Hernández Castro', @Documento = '1006', @FechaNacimiento = '2011-09-18', @Genero = 'F', @Curso = '9-C';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1007')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Andrés', @Apellido = 'Gómez Rojas', @Documento = '1007', @FechaNacimiento = '2009-03-25', @Genero = 'M', @Curso = '11-A';

IF NOT EXISTS (SELECT 1 FROM dbo.Estudiantes WHERE Documento = '1008')
    EXEC dbo.sp_CRUD_Estudiantes @Opcion = 2, @Nombre = 'Valentina', @Apellido = 'Cruz Morales', @Documento = '1008', @FechaNacimiento = '2010-06-14', @Genero = 'F', @Curso = '10-B';
GO

EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 1, @Materia = 'Matemáticas', @Periodo = '2026-1', @Nota = 8.5;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 1, @Materia = 'Ciencias', @Periodo = '2026-1', @Nota = 7.2;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 2, @Materia = 'Matemáticas', @Periodo = '2026-1', @Nota = 9.1;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 2, @Materia = 'Historia', @Periodo = '2026-1', @Nota = 6.8;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 3, @Materia = 'Matemáticas', @Periodo = '2026-1', @Nota = 4.5;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 3, @Materia = 'Ciencias', @Periodo = '2026-1', @Nota = 5.0;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 4, @Materia = 'Inglés', @Periodo = '2026-1', @Nota = 8.9;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 4, @Materia = 'Matemáticas', @Periodo = '2026-1', @Nota = 7.5;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 5, @Materia = 'Historia', @Periodo = '2026-1', @Nota = 3.9;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 5, @Materia = 'Ciencias', @Periodo = '2026-1', @Nota = 6.0;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 6, @Materia = 'Matemáticas', @Periodo = '2026-1', @Nota = 9.8;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 7, @Materia = 'Inglés', @Periodo = '2026-1', @Nota = 5.5;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 7, @Materia = 'Ciencias', @Periodo = '2026-1', @Nota = 4.2;
EXEC dbo.sp_CRUD_Calificaciones @Opcion = 2, @EstudianteId = 8, @Materia = 'Historia', @Periodo = '2026-1', @Nota = 7.7;
GO