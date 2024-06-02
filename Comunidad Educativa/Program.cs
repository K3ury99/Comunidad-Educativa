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
            Console.WriteLine(" 1. Agregar Nuevo Miembro");
            Console.WriteLine(" 2. Mostrar Todos los Miembros");
            Console.WriteLine(" 3. Buscar Miembro por Nombre");
            Console.WriteLine(" 4. Mostrar Administradores");
            Console.WriteLine(" 5. Mostrar Maestros");
            Console.WriteLine(" 6. Mostrar Administrativos");
            Console.WriteLine(" 7. Mostrar Estudiantes");
            Console.WriteLine(" 8. Mostrar ExAlumnos");
            Console.WriteLine(" 9. Eliminar Miembro");
            Console.WriteLine("10. Salir");
            Console.WriteLine("==================================");
            Console.Write(" Seleccione una opción: ");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarNuevoMiembro(miembros);
                        break;
                    case 2:
                        MostrarTodosLosMiembros(miembros);
                        break;
                    case 3:
                        BuscarMiembroPorNombre(miembros);
                        break;
                    case 4:
                        MostrarMiembros<Administrador>(miembros);
                        break;
                    case 5:
                        MostrarMiembros<Maestro>(miembros);
                        break;
                    case 6:
                        MostrarMiembros<Administrativo>(miembros);
                        break;
                    case 7:
                        MostrarMiembros<Estudiante>(miembros);
                        break;
                    case 8:
                        MostrarMiembros<ExAlumno>(miembros);
                        break;
                    case 9:
                        EliminarMiembro(miembros);
                        break;
                    case 10:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida e intente de nuevo.");
                        break;
                }
                Console.WriteLine("==================================");
                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ingrese una opción válida e intente de nuevo.");
                Console.ReadKey();
            }
        }
    }

    static void MostrarMiembros<T>(List<MiembroDeLaComunidad> miembros) where T : MiembroDeLaComunidad
    {
        Console.WriteLine($"\n==================================");
        Console.WriteLine($"{typeof(T).Name}s:");
        Console.WriteLine("==================================");
        foreach (var miembro in miembros)
        {
            if (miembro is T)
            {
                miembro.MostrarInformacion();
                Console.WriteLine("----------------------------------");
            }
        }
    }

    static void MostrarTodosLosMiembros(List<MiembroDeLaComunidad> miembros)
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("     Todos los Miembros:");
        Console.WriteLine("==================================\n");
        foreach (var miembro in miembros)
        {
            miembro.MostrarInformacion();
            Console.WriteLine("----------------------------------");
        }
    }

    static void BuscarMiembroPorNombre(List<MiembroDeLaComunidad> miembros)
    {
        Console.WriteLine("\n==================================");
        Console.Write("Ingrese el nombre del miembro a buscar: ");
        string nombre = Console.ReadLine();
        var miembroEncontrado = miembros.Find(m => m.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (miembroEncontrado != null)
        {
            Console.WriteLine("\nMiembro encontrado:");
            miembroEncontrado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine("\nMiembro no encontrado.");
        }
    }

    static void AgregarNuevoMiembro(List<MiembroDeLaComunidad> miembros)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("\nSeleccione el tipo de miembro a agregar:");
        Console.WriteLine("1. Administrador");
        Console.WriteLine("2. Maestro");
        Console.WriteLine("3. Administrativo");
        Console.WriteLine("4. Estudiante");
        Console.WriteLine("5. ExAlumno");
        Console.WriteLine("6. Empleado");
        Console.Write("Seleccione una opción: ");
        int tipo;
        if (int.TryParse(Console.ReadLine(), out tipo))
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.Write("Ingrese el puesto: ");
                    string puestoAdmin = Console.ReadLine();
                    miembros.Add(new Administrador(nombre, edad, puestoAdmin));
                    break;
                case 2:
                    Console.Write("Ingrese el puesto: ");
                    string puestoMaestro = Console.ReadLine();
                    miembros.Add(new Maestro(nombre, edad, puestoMaestro));
                    break;
                case 3:
                    Console.Write("Ingrese el puesto: ");
                    string puestoAdminis = Console.ReadLine();
                    miembros.Add(new Administrativo(nombre, edad, puestoAdminis));
                    break;
                case 4:
                    Console.Write("Ingrese la carrera: ");
                    string carrera = Console.ReadLine();
                    miembros.Add(new Estudiante(nombre, edad, carrera));
                    break;
                case 5:
                    Console.Write("Ingrese el año de graduación: ");
                    int anoGraduacion = int.Parse(Console.ReadLine());
                    miembros.Add(new ExAlumno(nombre, edad, anoGraduacion));
                    break;
                case 6:
                    Console.Write("Ingrese el puesto: ");
                    string puestoEmpleado = Console.ReadLine();
                    miembros.Add(new Empleado(nombre, edad, puestoEmpleado));
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    static void EliminarMiembro(List<MiembroDeLaComunidad> miembros)
    {
        Console.WriteLine("\n==================================");
        Console.Write("Ingrese el nombre del miembro a eliminar: ");
        string nombre = Console.ReadLine();
        var miembroAEliminar = miembros.Find(m => m.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (miembroAEliminar != null)
        {
            miembros.Remove(miembroAEliminar);
            Console.WriteLine("\nMiembro eliminado.");
        }
        else
        {
            Console.WriteLine("\nMiembro no encontrado.");
        }
    }
}