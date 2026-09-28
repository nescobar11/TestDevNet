Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Estudiantes

        Public Property EstudianteId As Integer

        <Required(ErrorMessage:="El nombre es obligatorio.")>
        <StringLength(50)>
        <Display(Name:="Nombre")>
        Public Property Nombre As String

        <Required(ErrorMessage:="El apellido es obligatorio.")>
        <StringLength(50)>
        <Display(Name:="Apellido")>
        Public Property Apellido As String

        <Required(ErrorMessage:="El documento es obligatorio.")>
        <StringLength(20)>
        <Display(Name:="Documento")>
        Public Property Documento As String

        <DataType(DataType.Date)>
        <Display(Name:="Fecha de Nacimiento")>
        Public Property FechaNacimiento As Date

        <StringLength(20)>
        <Display(Name:="Género")>
        Public Property Genero As String

        <StringLength(50)>
        <Display(Name:="Curso")>
        Public Property Curso As String

        <Display(Name:="Fecha de Registro")>
        Public Property FechaRegistro As DateTime
        Public ReadOnly Property NombreCompleto As String
            Get
                Return $"{Nombre} {Apellido}"
            End Get
        End Property

    End Class

End Namespace