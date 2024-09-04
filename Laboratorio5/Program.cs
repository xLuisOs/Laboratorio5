class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;   
        do
        {
            Console.Clear();   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("               BIENVENIDO");
            Console.WriteLine("-----------------------------------------"); Console.ResetColor();
            Console.WriteLine("1. Añadir Tarea");
            Console.WriteLine("2. Ver todas las tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Ingrese una opcion");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }catch (Exception ex)
            {

            }
        }while (opcion != 4);
        
    }
}