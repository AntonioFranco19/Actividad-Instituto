namespace ActividadInstituto;

public static class Utilidades
{
    public static string? LeerCadena(string message, bool obligatorio)
    {
        string? entrada;
        do
        {
            Console.WriteLine(message);
            entrada = Console.ReadLine();
            if (string.IsNullOrEmpty(entrada))
            {
                if (obligatorio)
                {
                    Console.WriteLine("No ha escrito nada en la entrada");
                }
                else
                {
                    break;
                }
            }
        } while (string.IsNullOrEmpty(entrada));

        return entrada;
    }

    public static Turnos SeleccionarTurno(string message)
    {
        string? input = null;
        bool salir = false;
        Turnos salida = Turnos.SinAsignar;
        Console.WriteLine(message);
        do
        {
            Console.WriteLine("OPCIONES: ");
            Console.WriteLine("  - Matutino (M)");
            Console.WriteLine("  - Vespertino (V)");
            Console.WriteLine("  - Nocturno (N)");
            input = Console.ReadLine();

            switch (input?.ToLower())
            {
                case "matutino":
                case "m":
                    salir = true;
                    salida = Turnos.Matutino;
                    break;
                case "vespertino":
                case "v":
                    salir = true;
                    salida = Turnos.Vespertino;
                    break;
                case "nocturno":
                case "n":
                    salir = true;
                    salida = Turnos.Nocturno;
                    break;
                default:
                    Console.WriteLine("Comando no válido.");
                    break;
            }
        } while (!salir && !string.IsNullOrEmpty(input));

        return salida;
    }

    public static CicloFormativo CrearCicloFormativo()
    {
        CicloFormativo ciclo = new CicloFormativo(LeerCadena("Introdue ID del ciclo.....", true),
            LeerCadena("Introduce nombre del ciclo.....", true), SeleccionarTurno("Introduce turno....."));
        return ciclo;
    }
    
}