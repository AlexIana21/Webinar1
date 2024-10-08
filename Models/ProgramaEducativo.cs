namespace Models;
/*
class ProgramaEducativo
{
    private List<Estudiante> estudiantes;
    

    public ProgramaEducativo()
    {
        estudiantes = new List<Estudiante>();
    }

    public void AñadirEstudiante(Estudiante estudiante)
    {
        if (estudiantes.Exists(e => e.Nombre == estudiante.Nombre))
            {
                Console.WriteLine($"El estudiante {estudiante.Nombre} ya existe en el programa.");
            }
            else
            {
                // Añadir la asignatura a la lista global
                estudiantes.Add(estudiante);
                Console.WriteLine($"El estudiante {estudiante.Nombre} con ha sido añadido.");
            }
    }

    public void MostrarEstudiantes()
    {
        Console.WriteLine("\n--- Lista de Estudiantes ---");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
        }
    }

    public Estudiante ObtenerEstudiante(string nombre)
    {
        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Nombre == nombre)
            {
                return estudiante;
            }
        }
        return null;
    }

    public List<Estudiante> BuscarEstudiantesPorNombre(string parteDelNombre)
    {
        List<Estudiante> resultados = estudiantes.FindAll(e => e.Nombre.ToLower().Contains(parteDelNombre.ToLower()));
        return resultados;
    }

    public void EliminarEstudiante(string nombre)
    {
        Estudiante estudiante = ObtenerEstudiante(nombre);
        if (estudiante != null)
        {
            estudiantes.Remove(estudiante);
            Console.WriteLine($"El estudiante {nombre} ha sido eliminado.");
        }
        else
        {
            Console.WriteLine($"El estudiante {nombre} no fue encontrado.");
        }
    }

    public double CalcularPromedioGlobal()
    {
        double sumaPromedios = 0;
        int contadorEstudiantes = 0;

        foreach (var estudiante in estudiantes)
        {
            sumaPromedios += estudiante.CalcularPromedio();
            contadorEstudiantes++;
        }


        return contadorEstudiantes > 0 ? sumaPromedios / contadorEstudiantes : 0;
    }

    public void GenerarReporteEstudiante(Estudiante estudiante)
    {
        Console.WriteLine($"\n--- Reporte para {estudiante.Nombre} ---");
        estudiante.MostrarCalificaciones();
        double promedio = estudiante.CalcularPromedio();
        Console.WriteLine($"Promedio final: {promedio:F2}");
    }

}   
*/

public class SistemaEducativo
{   
    private List<Estudiante> Estudiante { get; set; } = new List<Estudiante>();

    public void EliminarEstudiante(string nombre)
    {
        Estudiante estudiante = Estudiante.FirstOrDefault(e => e.Nombre == nombre);
        if (estudiante != null)
        {
            Estudiante.Remove(estudiante);
            Console.WriteLine($"Estudiante {nombre} eliminado.");
        }
        else
        {
            Console.WriteLine($"Error: No se encontró al estudiante con el nombre {nombre}.");
        }
    }
}

/*
    public void EliminarEstudiante(string nombre)
    {
        Estudiante estudiante = ObtenerEstudiante(nombre);
        if (estudiante != null)
        {
            estudiantes.Remove(estudiante);
            Console.WriteLine($"El estudiante {nombre} ha sido eliminado.");
        }
        else
        {
            Console.WriteLine($"El estudiante {nombre} no fue encontrado.");
        }
    }
*/
   

