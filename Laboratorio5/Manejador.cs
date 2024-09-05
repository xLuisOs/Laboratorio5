using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class Manejador
    {
        public List<Tarea> tareas = new List<Tarea>();
        public Mensajes mensaje = new Mensajes();

        public void AgregarTarea()
        {
            try
            {
                Console.WriteLine("AGREGAR TAREA");
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la descripción de la tarea: ");
                string descripcion = Console.ReadLine();
                bool estado = false;

                Tarea nuevaTarea = new Tarea(nombre, descripcion, estado);
                tareas.Add(nuevaTarea);
                Console.WriteLine("Tarea agregada exitosamente");
            }
            catch (FormatException)
            {
                mensaje.ErrorDeFormato();
            }
        }
        public void MostrarTareas()
        {
            if (tareas.Count == 0)
            {
                mensaje.NoHayTareas();
            }
            else
            {
                foreach (var tarea in tareas)
                {
                    tarea.MostarInfo();
                }
            }
            mensaje.Continuar();
        }
    }
}
