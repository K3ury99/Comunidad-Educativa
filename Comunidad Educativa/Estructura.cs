using System;

namespace Comunidad_Educativa
{
    public class MiembroDeLaComunidad
    {
        // Propiedades comunes a todos los miembros de la comunidad
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    // Subclase de MiembroDeLaComunidad
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }

    // Subclase de Empleado
    public class Docente : Empleado
    {
        public Docente(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }
    }

    // Subclase de Docente
    public class Administrador : Docente
    {
        public Administrador(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }
    }

    // Subclase de Docente
    public class Maestro : Docente
    {
        public Maestro(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }
    }

    // Subclase de Empleado
    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }
    }

    // Subclase de MiembroDeLaComunidad
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    // Subclase de MiembroDeLaComunidad
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AnoDeGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, int anoDeGraduacion) : base(nombre, edad)
        {
            AnoDeGraduacion = anoDeGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AnoDeGraduacion}");
        }
    }
}
