CREATE DATABASE ColegioDB;
GO
USE Class101;
GO

CREATE TABLE Estudiantes (
    EstudianteId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Documento VARCHAR(20) NOT NULL UNIQUE,
    FechaNacimiento DATE,
    Genero VARCHAR(20),
    Curso VARCHAR(50),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Calificaciones (
    CalificacionId INT IDENTITY(1,1) PRIMARY KEY,
    EstudianteId INT NOT NULL,
    Materia VARCHAR(100) NOT NULL,
    Nota DECIMAL(4,2) NOT NULL,
    Periodo VARCHAR(20) NOT NULL,

    CONSTRAINT FK_Calificaciones_Estudiantes
        FOREIGN KEY (EstudianteId)
        REFERENCES Estudiantes(EstudianteId)
);

CREATE TABLE dbo.ErrorLog (
    ErrorLogId      INT IDENTITY(1,1)  NOT NULL,
    ErrorProcedure  VARCHAR(200)       NULL,
    ErrorNumber     INT                NULL,
    ErrorSeverity   INT                NULL,
    ErrorState      INT                NULL,
    ErrorLine       INT                NULL,
    ErrorMessage    VARCHAR(4000)      NULL,
    ErrorDateTime   DATETIME           NOT NULL CONSTRAINT DF_ErrorLog_FechaError DEFAULT (GETDATE()),

    CONSTRAINT PK_ErrorLog PRIMARY KEY CLUSTERED (ErrorLogId ASC)
);
