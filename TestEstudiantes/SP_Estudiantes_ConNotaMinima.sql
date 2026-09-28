SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Natalia Escobar Sotelo
-- Create date: 24-09-2026
-- Description:	Retorna información de calificaciones menor a 5  
-- =============================================

-- EXEC dbo.sp_Estudiantes_ConNotaMinima @NotaMinima = 5.0;


CREATE PROCEDURE dbo.sp_Estudiantes_ConNotaMinima
    @NotaMinima DECIMAL(3,1) = 5.0
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT
            e.EstudianteId,
            e.Nombre,
            e.Apellido,
            e.Curso,
            c.Materia,
            c.Periodo,
            c.Nota
        FROM dbo.Estudiantes e
        INNER JOIN dbo.Calificaciones c ON c.EstudianteId = e.EstudianteId
        WHERE c.Nota >= @NotaMinima
        ORDER BY c.Nota DESC, e.Apellido;
    END TRY
    BEGIN CATCH
        EXEC dbo.sp_LogError @ErrorProcedure = 'sp_Estudiantes_ConNotaMinima';
        THROW;
    END CATCH
END
GO

