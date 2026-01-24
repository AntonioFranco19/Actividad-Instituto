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
    
    public static int LeerInt(string message)
    {
        int num;
        bool correcto;
        do
        {
            correcto = int.TryParse(LeerCadena(message, true), out num);
            if (!correcto) Console.WriteLine("No has introducido un número.");
            
        } while (!correcto);

        return num;
    }

    public static Turnos SeleccionarTurno(string message)
    {
        string? input;
        Turnos salida = Turnos.SinAsignar;
        Console.WriteLine(message);
        do
        {
            Console.WriteLine("OPCIONES: ");
            Console.WriteLine("  - Matutino (M)");
            Console.WriteLine("  - Vespertino (V)");
            Console.WriteLine("  - Nocturno (N)");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No has introducido nada. Este campo es obligatorio.");
            }
            else
            {
                switch (input.ToLower())
                {
                    case "matutino":
                    case "m":

                        salida = Turnos.Matutino;
                        break;
                    case "vespertino":
                    case "v":

                        salida = Turnos.Vespertino;
                        break;
                    case "nocturno":
                    case "n":
                        salida = Turnos.Nocturno;
                        break;
                    default:
                        Console.WriteLine("Comando no válido.");
                        break;
                }
            }
            
        } while (salida == Turnos.SinAsignar) ;
        
        return salida;
    }

    public static CicloFormativo CrearCicloFormativo()
    {
        CicloFormativo ciclo = new CicloFormativo(LeerCadena("Introdue ID del ciclo.....", true),
            LeerCadena("Introduce nombre del ciclo.....", true), SeleccionarTurno("Introduce turno....."));
        Console.WriteLine("\nSe ha creado el ciclo formativo.");
        return ciclo;
    }

    public static Alumno CrearAlumno(CicloFormativo ciclo)
    {
        Alumno alumno = new Alumno(LeerCadena("NIF:", true), LeerCadena("NOMBRE:", true),
            LeerCadena("TELEFONO:", false), LeerCadena("DIRECCIÓN:", false), LeerCadena("EMAIL:", false), ciclo);
        Console.WriteLine("\nSe ha creado el alumno.");
        return alumno;
    }
    
}