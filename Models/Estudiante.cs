namespace Models;
/*
class Estudiante
{
    public string Nombre { get; set; }
    private Dictionary<Asignatura, double> calificaciones;

    public Estudiante(string nombre)
    {
        Nombre = nombre;
        calificaciones = new Dictionary<Asignatura, double>();
    }

    public void AñadirCalificacion(Asignatura asignatura, double calificacion)
    {
        calificaciones[asignatura] = calificacion;
    }

    public void MostrarCalificaciones()
    {
        Console.WriteLine($"\n--- Calificaciones de {Nombre} ---");
        foreach (var entrada in calificaciones)
        {
            Console.WriteLine($"{entrada.Key.Nombre}: {entrada.Value:F2}");
        }
    }

    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (var entrada in calificaciones)
        {
            suma += entrada.Value;
        }
        return calificaciones.Count > 0 ? suma / calificaciones.Count : 0;
    }

    public void ModificarCalificacion(Asignatura asignatura, double nuevaCalificacion)
    {
        if (calificaciones.ContainsKey(asignatura))
        {
            calificaciones[asignatura] = nuevaCalificacion;
            Console.WriteLine($"Calificación de {asignatura.Nombre} modificada a {nuevaCalificacion:F2}.");
        }
        else
        {
            Console.WriteLine($"El estudiante no tiene una calificación en {asignatura.Nombre}.");
        }
    }

}
*/
class Estudiante
{
    public string Nombre { get; set; }
    public Dictionary<string, double> Calificaciones { get; set; } = new Dictionary<string, double>();

    public void ModificarCalificacion(string asignatura, double nuevaCalificacion)
    {
        if (Calificaciones.ContainsKey(asignatura))
        {
            Calificaciones[asignatura] = nuevaCalificacion;
            Console.WriteLine($"La nota de {asignatura} ha sido cambiada a {nuevaCalificacion}");
        }
        else
        {
            Console.WriteLine($"Error: El estudiante no está inscrito en la asignatura {asignatura}");
        }
    }
}

/*    public void ModificarCalificacion(Asignatura asignatura, double nuevaCalificacion)
    {
        if (calificaciones.ContainsKey(asignatura))
        {
            calificaciones[asignatura] = nuevaCalificacion;
            Console.WriteLine($"Calificación de {asignatura.Nombre} modificada a {nuevaCalificacion:F2}.");
        }
        else
        {
            Console.WriteLine($"El estudiante no tiene una calificación en {asignatura.Nombre}.");
        }
    }*/

