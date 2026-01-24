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
        if (_listaCiclos.Count() == 0)
        {
            Console.WriteLine("El centro no tiene ciclos formativos aún!");
            return null;
        }
        RecorrerCiclos();
        string? idCiclo = Utilidades.LeerCadena("INTRODUCE ID DEL CICLO A SELECCIONAR: ", true);
        
        foreach (var ciclo in _listaCiclos)
        {
            if (idCiclo == ciclo.IdModulo)
            {
                return ciclo;
            }
        }
        Console.WriteLine("No se ha encontrado el ciclo seleccionado.");
        return null;
    }
    
    public void ListarAlumnos()
    {
        Console.WriteLine(new string('=', 119));
        Console.WriteLine("| L I S T A  A L U M N O S "+ new string(' ', 91)+"|");
        Console.WriteLine(new string('=', 119));
        Console.WriteLine($"| {"Nombre", -20} | {"Nif", -10} | {"Telefono", -10} | {"Direccion", -20} | {"Email", -20} | {"Matriculado en", -20} |");
        foreach (Alumno alumno in _listaAlumno)
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine(new string('=', 119));
    }

    public void Estadísticas()
    {
        Console.WriteLine(" ");
        Console.WriteLine("==================================================");
        Console.WriteLine("|           ESTADÍSTICAS DEL CENTRO              |");
        Console.WriteLine("==================================================");
        Console.WriteLine($" > Centro:     {Nombre}");
        Console.WriteLine($" > ID:         {Id}");
        Console.WriteLine($" > Telefono:   {Telefono}");
        Console.WriteLine($" > Dirección:  {Direccion}");
        Console.WriteLine($" > Ciclos:     {_listaCiclos.Count}");
        Console.WriteLine($" > Alumnos:    {_listaAlumno.Count}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"| {"CICLO",-23} | {"ID",-10} | {"ALUMNOS",6} |");
        Console.WriteLine("--------------------------------------------------");

        foreach (var ciclo in _listaCiclos)
        {
            int countAl = 0;
            foreach (var al in _listaAlumno)
            {
                if (al.CicloMatriculado.Nombre == ciclo.Nombre)
                {
                    countAl++;
                }
            }

            Console.WriteLine($"| {ciclo.Nombre,-23} | {ciclo.IdModulo,-10} | {countAl,7} |");
        }

        Console.WriteLine("==================================================");
        Console.WriteLine(" ");

    }

}