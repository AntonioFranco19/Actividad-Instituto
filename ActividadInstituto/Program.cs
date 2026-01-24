
namespace ActividadInstituto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Centro europa = new Centro(1, "IES Europa", "dirección", "telefono");
            CicloFormativo? cicloSeleccionado = null;
            
            /*
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
            */
            
            //List<Alumno> alumnos = new List<Alumno>();

            bool repetir = true;
            
            Bienvenida();

            do
            {
                Menu();
                Console.WriteLine(cicloSeleccionado == null ? $"\t| {"NINGÚN CICLO SELECCIONADO", -42} |" : $"\t| CICLO SELECCIONADO : {cicloSeleccionado.Nombre, 21} |");
                Console.WriteLine("\t==============================================");
                Console.WriteLine(" ");
                
                Console.Write(" > ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                            CicloFormativo cicloNuevo = Utilidades.CrearCicloFormativo();
                            europa.AñadirCicloFormativo(cicloNuevo);
                        
                        break;
                    case "2":
                            europa.RecorrerCiclos();
                        
                        break;
                    case "3":
                            cicloSeleccionado = europa.SeleccionarCiclo();
                            if (cicloSeleccionado == null)
                            {
                                Console.WriteLine("No se ha podido seleccionar ciclo formativo.");
                                break;
                            }
                            Console.WriteLine($"Se ha seleccionado el ciclo: {cicloSeleccionado.Nombre}");

                            break;
                    case "4":
                        if (cicloSeleccionado == null) Console.WriteLine("\nPrimero debes seleccionar un ciclo.");
                        else
                        {
                            cicloSeleccionado.VerDetalles();
                        }
                        break;
                    case "5":
                        if (cicloSeleccionado == null) Console.WriteLine("\nPrimero debes seleccionar un ciclo.");
                        else
                        {
                            cicloSeleccionado.AgregarModulo();
                        }
                        break;
                    case "6":
                        if (cicloSeleccionado == null) Console.WriteLine("\nPrimero debes seleccionar un ciclo.");
                        else
                        {
                           Alumno al = Utilidades.CrearAlumno(cicloSeleccionado);
                           europa.AñadirAlumno(al);
                        }
                        break;
                    case "7":
                        if (cicloSeleccionado == null) Console.WriteLine("\nPrimero debes seleccionar un ciclo.");
                        else
                        {
                            europa.ListarAlumnos();
                        }
                        break;
                    case "8":
                        europa.Estadísticas();
                        break;
                    case "9":
                        repetir = false;
                        Console.Clear();
                        Despedida();
                        break;
                    default:
                        Console.WriteLine("Comando no permitido.");
                        break;
                }

                
            } while (repetir);
        }

        public static void Menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\t================ M  E  N  Ú ==================");
            Console.WriteLine("\t| 1. Crear ciclo formativo.                  |");
            Console.WriteLine("\t| 2. Listar ciclos formativos.               |");
            Console.WriteLine("\t| 3. Seleccionar ciclo formativo.            |");
            Console.WriteLine("\t| 4. Mostrar detalle del ciclo seleccionado. |");
            Console.WriteLine("\t| 5. Agregar módulo.                         |");
            Console.WriteLine("\t| 6. Matricular alumno.                      |");
            Console.WriteLine("\t| 7. Listar Alumnos.                         |");
            Console.WriteLine("\t| 8. Ver resumen del centro.                 |");
            Console.WriteLine("\t| 9. Salir del programa.                     |");
            Console.WriteLine("\t==============================================");
        }

        public static void Bienvenida()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine("\t|                                          |");
            Console.WriteLine("\t|     BIENVENIDO A GESTIÓN ACADÉMICA       |");
            Console.WriteLine("\t|              Hecho por                   |");
            Console.WriteLine("\t|        Antonio Franco Cegarra            |");
            Console.WriteLine("\t|                                          |");
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine(" ");
        }

        public static void Despedida()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine("\t|                                          |");
            Console.WriteLine("\t|    ¡GRACIAS POR USAR GESTIÓN ACADÉMICA!  |");
            Console.WriteLine("\t|                                          |");
            Console.WriteLine("\t+==========================================+");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        
    }
}