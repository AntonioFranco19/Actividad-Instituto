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
        Console.WriteLine("Se ha añadido el alumno correctamente.");
    }
    
    public void RecorrerCiclos()
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("| CICLOS:" + new string(' ', 50) + "|");
        Console.WriteLine($"| {"NOMBRE", 20} | {"ID", 10} | {"TURNO", 20} |");
        foreach (var cicloFormativo in _listaCiclos)
        {
            Console.WriteLine(cicloFormativo);
        }
        Console.WriteLine(new string('=', 60));
    }

    public CicloFormativo? SeleccionarCiclo()
    {
        string? idCiclo = Utilidades.LeerCadena("INTRODUCE ID DEL CICLO A SELECCIONAR: ", true);
        if (_listaCiclos.Count() == 0)
        {
            Console.WriteLine("El centro no tiene ciclos formativos aún!");
            return null;
        }
        
        foreach (var ciclo in _listaCiclos)
        {
            if (idCiclo == ciclo.IdModulo)
            {
                return ciclo;
            }
        }

        return null;
    }
    
    public void ListarAlumnos()
    {
        foreach (Alumno alumno in _listaAlumno)
        {
            Console.WriteLine(alumno);
        }
    }
    
}