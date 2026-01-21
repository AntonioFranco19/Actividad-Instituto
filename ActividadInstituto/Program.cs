
namespace ActividadInstituto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int idModulo = 1;
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
            
            List<Alumno> alumnos = new List<Alumno>();

            bool repetir = true;

            do
            {
                Menu();
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                            CicloFormativo cicloNuevo = Utilidades.CrearCicloFormativo();
                            europa.AñadirCicloFormativo(cicloNuevo);
                        
                        break;
                    case "2":
                        try
                        {
                            
                            europa.RecorrerCiclos();
                            Console.WriteLine(new string('=', 50));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    case "3":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "6":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "7":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "8":
                        try
                        {
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "9":
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
            Console.WriteLine("================ M  E  N  Ú ==================");
            Console.WriteLine("| 1. Crear ciclo formativo.                  |");
            Console.WriteLine("| 2. Listar ciclos formativos.               |");
            Console.WriteLine("| 3. Seleccionar ciclo formativo.            |");
            Console.WriteLine("| 4. Mostrar detalle del ciclo seleccionado. |");
            Console.WriteLine("| 5. Agregar módulo.                         |");
            Console.WriteLine("| 6. Matricular alumno.                      |");
            Console.WriteLine("| 7. Listar Alumnos.                         |");
            Console.WriteLine("| 8. Ver resumen del centro.                 |");
            Console.WriteLine("| 9. Salir del programa.                     |");
            Console.WriteLine("==============================================");
        }

        public static void PausarPrograma()
        {
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public static Alumno MatricularAlumno(CicloFormativo ciclo)
        {
            var nombre = Utilidades.LeerCadena("Ingrese nombre del alumno.", true);
            var nif = Utilidades.LeerCadena("Ingrese NIF:", true);
            var tel = Utilidades.LeerCadena("Ingrese telefono:", true);
            var direccion = Utilidades.LeerCadena("Ingrese dirección:", true);
            var email = Utilidades.LeerCadena("Ingrese email:", true);

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
        
    }
}