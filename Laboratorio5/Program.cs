using Laboratorio5;

class Program
{
    static void Main(string[] args)
    {
        Mensajes mensaje = new Mensajes();
        Manejador manejador = new Manejador();
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("               BIENVENIDO");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();
            Console.WriteLine("1. Añadir Tarea");
            Console.WriteLine("2. Ver todas las tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Ingrese una opción:");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        manejador.AgregarTarea();
                        break;
                    case 2:
                        manejador.MostrarTareas();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        mensaje.Default();
                        break;
                }
            }
            catch (FormatException)
            {
                mensaje.ErrorDeFormato();
            }
        } while (opcion != 4);
    }
}
