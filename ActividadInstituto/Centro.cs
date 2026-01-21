namespace ActividadInstituto;

public class Centro
{
    public int Id { get; }
    public string Nombre { get; }
    public string Direccion { get; }
    public string Telefono { get; }
    private readonly List<CicloFormativo> _listaCiclos = [];
    private readonly List<Alumno> _listaAlumno = [];

    public Centro(int id, string nombre, string direccion, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
    }

    public void AñadirCicloFormativo(CicloFormativo cf)
    {
        _listaCiclos.Add(cf);
        Console.WriteLine("Se ha añadido el ciclo correctamente.");
    }
    
    public void AñadirAlumno(Alumno a)
    {
        _listaAlumno.Add(a);
    }
    
    public void RecorrerCiclos()
    {
        foreach (var cicloFormativo in _listaCiclos)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("| CICLOS:" + new string(' ', 43) + "|");
            Console.WriteLine($"| {"NOMBRE", 20} | {"ID", 10} | {"TURNO", 20} |");
            Console.WriteLine(cicloFormativo);
        }
    } 
}