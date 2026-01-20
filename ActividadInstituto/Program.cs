
namespace ActividadInstituto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int idModulo = 1;
            
            Modulo programacion = new Modulo(idModulo++, "Programacion");
            Modulo baseDeDatos = new Modulo(idModulo++, "Base de datos", 50);
            Modulo entornosDeDesarrollo = new Modulo(idModulo++, "Entornos de desarrollo");
            Modulo lenguajeDeMarcas = new Modulo(idModulo, "Lenguaje de marcas", 70);

            CicloFormativo dam =
                new CicloFormativo("DAM", "Desarrollo de aplicaciones Multiplataforma", Turnos.Vespertino);
            dam.AgregarModulo(programacion);
            dam.AgregarModulo(baseDeDatos);
            dam.AgregarModulo(entornosDeDesarrollo);
            dam.AgregarModulo(lenguajeDeMarcas);

            Profesor diego = new Profesor("111223344A", "Diego Martínez Cazorla", "123456789", "Aguilas", "diego@murciaeduca.es");
            Profesor sebastian = new Profesor("111223344A", "Sebastian Martinez Perez", "123456789", "Aguilas", "sebastian@murciaeduca.es");

            programacion.AgregarProfesor(sebastian);
            baseDeDatos.AgregarProfesor(diego);
            entornosDeDesarrollo.AgregarProfesor(sebastian);
            lenguajeDeMarcas.AgregarProfesor(diego);
            
            List<Alumno> alumnos = new List<Alumno>();

            bool repetir = true;

            do
            {
                Menu();
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        try
                        {
                            Alumno alumno = MatricularAlumno(dam);
                            alumnos.Add(alumno);
                            Console.WriteLine($"Se ha añadido al ciclo {dam.Nombre}.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            throw;
                        }

                        break;
                    case "2":
                        try
                        {
                            ListarAlumnos(alumnos);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    case "3":
                        try
                        {
                            dam.VerDetalles();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "exit":
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("Comando no permitido.");
                        break;
                }

                PausarPrograma();
            } while (repetir);
        }

        public static void Menu()
        {
            Console.WriteLine("======= M E N Ú =======");
            Console.WriteLine("1. Matricular alumno.");
            Console.WriteLine("2. Listar alumnos.");
            Console.WriteLine("3. Ver detalle ciclo.");
            Console.WriteLine("exit. Salir del programa.");
            Console.WriteLine("=========================");
        }

        public static void PausarPrograma()
        {
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public static Alumno MatricularAlumno(CicloFormativo ciclo)
        {
            var nombre = LeerCadena("Ingrese nombre del alumno.", true);
            var nif = LeerCadena("Ingrese NIF:", true);
            var tel = LeerCadena("Ingrese telefono:", true);
            var direccion = LeerCadena("Ingrese dirección:", true);
            var email = LeerCadena("Ingrese email:", true);

            Alumno al = new Alumno(nif, nombre, tel, direccion, email, ciclo);
            
            Console.WriteLine("Se ha creado el alumno.");
            return al;
        }

        public static void ListarAlumnos(List<Alumno> lista)
        {
            foreach (Alumno alumno in lista)
            {
                Console.WriteLine(alumno);
            }
        }

        static string? LeerCadena(string message, bool obligatorio)
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
    }
}