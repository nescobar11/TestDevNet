Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Calificaciones

        Public Property CalificacionId As Integer

        <Required(ErrorMessage:="Seleccione un estudiante.")>
        <Display(Name:="Estudiante")>
        Public Property EstudianteId As Integer

        <Required(ErrorMessage:="La materia es obligatoria.")>
        <StringLength(100)>
        <Display(Name:="Materia")>
        Public Property Materia As String

        <Required(ErrorMessage:="El periodo es obligatorio.")>
        <StringLength(20)>
        <Display(Name:="Periodo")>
        Public Property Periodo As String

        <Required(ErrorMessage:="La nota es obligatoria.")>
        <Range(0.0, 10.0, ErrorMessage:="La nota debe estar entre 0.0 y 10.0.")>
        <Display(Name:="Nota")>
        Public Property Nota As Decimal

        ' Propiedades auxiliares para mostrar la información del estudiante asociado (vienen del JOIN del Stored Procedure)
        <Display(Name:="Nombre del Estudiante")>
        Public Property NombreEstudiante As String

        <Display(Name:="Apellido del Estudiante")>
        Public Property ApellidoEstudiante As String

        <Display(Name:="Documento")>
        Public Property DocumentoEstudiante As String

    End Class

End Namespace