namespace ActividadInstituto;

public class CicloFormativo(string? id, string? nombre, Turnos turno)
{
    private readonly List<Modulo> _asignaturas = [];
    public string? IdModulo { get; } = id;
    public string Nombre { get; } = nombre;
    public Turnos Turno { get; } = turno;

    public void AgregarModulo(Modulo m)
    {
        _asignaturas.Add(m);
        Console.WriteLine("Se ha añadido el módulo.");
    }

    public void VerDetalles()
    {
        
        Console.WriteLine($"\n| Nombre del módulo: {Nombre, 15} | ID: {IdModulo, 10} |");
       
        Console.WriteLine("\n| Asignaturas: ");
        foreach (var asignatura in _asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }

    public override string ToString()
    {
        return $"| {this.Nombre} | {IdModulo} | {Turno} |";
    }
}
