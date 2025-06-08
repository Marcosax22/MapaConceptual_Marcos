using MapaConceptual_Marcos_;

using System;

class Program
{
    static void Main(string[] args)
    {
        Maestro maestro = new Maestro
        {
            ID = "MA001",
            Nombre = "Luis Mendoza",
            Edad = 45,
            Departamento = "Educación",
            Area = "Humanidades",
            Materia = "Historia"
        };

        maestro.MostrarInformacion();
        Console.WriteLine();

        Administrador administrador = new Administrador
        {
            ID = "AD002",
            Nombre = "Carla Ruiz",
            Edad = 50,
            Departamento = "Gestión Académica",
            Area = "Administración",
            Nivel = "Directora General"
        };

        administrador.MostrarInformacion();
        Console.WriteLine();

        Administrativo administrativo = new Administrativo
        {
            ID = "AF003",
            Nombre = "Miguel Torres",
            Edad = 38,
            Departamento = "Recursos Humanos",
            Puesto = "Jefe de Personal"
        };

        administrativo.MostrarInformacion();
        Console.WriteLine();

        Estudiante estudiante = new Estudiante
        {
            ID = "ES004",
            Nombre = "Daniela Gómez",
            Edad = 20,
            Carrera = "Arquitectura"
        };

        estudiante.MostrarInformacion();
        Console.WriteLine();

        ExAlumno exAlumno = new ExAlumno
        {
            ID = "EX005",
            Nombre = "Fernando Álvarez",
            Edad = 30,
            AñoGraduacion = 2015
        };

        exAlumno.MostrarInformacion();
        Console.WriteLine();
    }
}