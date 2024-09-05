using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class Tarea
    {
        static int contador = 0;
        public int IdTarea {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Tarea(string nombre, string descripcion, bool estado)
        {
            IdTarea = contador++;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }

        public void MostarInfo()
        {

            Console.WriteLine($"Numero de Tarea: {IdTarea}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Estado: {(Estado ? "Completada" : "Pendiente")}");
            Console.WriteLine("----------------------------------------------");
            if (Estado )
            {
                Console.WriteLine("Tarea Completada");
            }
            else
            {
                Console.WriteLine("Tarea Pendiente");
            }

        }
    }
}
