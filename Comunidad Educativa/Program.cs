using System;
using System.Collections.Generic;
using Comunidad_Educativa;

class Program
{
    static void Main(string[] args)
    {
        List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>
        {
            new Administrador("Ana Martinez", 50, "Director"),
            new Administrador("Juan Hernandez", 45, "Subdirector"),
            new Administrador("Carlos Fernandez", 52, "Gerente de TI"),
            new Administrador("Marta Garcia", 47, "Jefa de Finanzas"),
            new Administrador("Pedro Sanchez", 55, "Gerente de RRHH"),

            new Maestro("Luis Hernandez", 35, "Maestro de Matemáticas"),
            new Maestro("Claudia Jimenez", 40, "Maestra de Ciencias"),
            new Maestro("Jose Rodriguez", 45, "Maestro de Historia"),
            new Maestro("Laura Mejia", 38, "Maestra de Inglés"),
            new Maestro("Roberto Diaz", 42, "Maestro de Educación Física"),

            new Administrativo("Laura Sanchez", 25, "Secretaria"),
            new Administrativo("Carlos Lopez", 30, "Asistente Administrativo"),
            new Administrativo("Mariana Torres", 28, "Recepcionista"),
            new Administrativo("Andres Castillo", 35, "Contador"),
            new Administrativo("Sofia Rojas", 27, "Analista de Datos"),

            new Estudiante("Pedro Lopez", 20, "Ingeniería"),
            new Estudiante("Ana Lopez", 21, "Medicina"),
            new Estudiante("Carlos Ruiz", 22, "Derecho"),
            new Estudiante("Maria Gomez", 19, "Psicología"),
            new Estudiante("Luis Perez", 23, "Arquitectura"),

            new ExAlumno("Jose Ramirez", 28, 2015),
            new ExAlumno("Laura Perez", 30, 2012),
            new ExAlumno("Miguel Angel", 32, 2010),
            new ExAlumno("Lucia Mendoza", 29, 2014),
            new ExAlumno("Fernando Torres", 33, 2008),

            new Empleado("Maria Gomez", 30, "Contadora"),
            new Empleado("Ricardo Silva", 31, "Auditor"),
            new Empleado("Paola Fernandez", 29, "Gerente de Proyectos"),
            new Empleado("Sandra Gutierrez", 27, "Especialista en Marketing"),
            new Empleado("Hugo Marin", 34, "Ingeniero de Software")
        };

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("      Comunidad Educativa.");
            Console.WriteLine("==================================");
            Console.WriteLine(" 1. Mostrar Administradores");
            Console.WriteLine(" 2. Mostrar Maestros");
            Console.WriteLine(" 3. Mostrar Administrativos");
            Console.WriteLine(" 4. Mostrar Estudiantes");
            Console.WriteLine(" 5. Mostrar ExAlumnos");
            Console.WriteLine(" 6. Salir");
            Console.WriteLine("==================================");
            Console.Write(" Seleccione una opción: ");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n==================================");
                        Console.WriteLine("Administradores:");
                        Console.WriteLine("==================================");
                        MostrarMiembros<Administrador>(miembros);
                        break;
                    case 2:
                        Console.WriteLine("==================================");
                        Console.WriteLine("Maestros:");
                        Console.WriteLine("==================================");
                        MostrarMiembros<Maestro>(miembros);
                        break;
                    case 3:
                        Console.WriteLine("==================================");
                        Console.WriteLine("Administrativos:");
                        Console.WriteLine("==================================");
                        MostrarMiembros<Administrativo>(miembros);
                        break;
                    case 4:
                        Console.WriteLine("==================================");
                        Console.WriteLine("Estudiantes:");
                        Console.WriteLine("==================================");
                        MostrarMiembros<Estudiante>(miembros);
                        break;
                    case 5:
                        Console.WriteLine("==================================");
                        Console.WriteLine("ExAlumnos:");
                        Console.WriteLine("==================================");
                        MostrarMiembros<ExAlumno>(miembros);
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida e intente de nuevo.");
                        break;
                }
                Console.WriteLine("==================================");
                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para salir del programa...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ingrese una opcion valida e intente de nuevo.");
                Console.ReadKey();
            }
        }
    }

    static void MostrarMiembros<T>(List<MiembroDeLaComunidad> miembros) where T : MiembroDeLaComunidad
    {
        foreach (var miembro in miembros)
        {
            if (miembro is T)
            {
                miembro.MostrarInformacion();
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
