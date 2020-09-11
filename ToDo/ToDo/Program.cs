using System;
using System.Collections.Generic;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se solicita la cantidad de tareas a cargar
            Console.WriteLine("Indique la catidad de tareas a cargar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            //Agregando las tareas a la lista
            List<Tareas> ListaDeTareas = new List<Tareas>();
            List<Tareas> TareasRealizadas = new List<Tareas>();
            Random rnd = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la descripcion de la tarea");
                string descTarea = Console.ReadLine();

                Tareas tarea = new Tareas();
                tarea.Id = i;
                tarea.Descripcion = descTarea;
                tarea.Duracion = rnd.Next(1, 11);

                ListaDeTareas.Add(tarea);
            }

            //Se controla si la tarea fue realizada 
            for (int i = 0; i < ListaDeTareas.Count; i++)
            {
                Console.WriteLine("Descripcion Tarea: " + ListaDeTareas[i].Descripcion);
                Console.WriteLine("¿Se realizo la tarea? (s/n)");
                string respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    TareasRealizadas.Add(ListaDeTareas[i]);
                    ListaDeTareas.Remove(ListaDeTareas[i]);
                    i--;
                }
            }

            //Muestra las tareas realizadas
            foreach (Tareas tareaX in TareasRealizadas)
            {
                Console.WriteLine("Tareas Realizadas");
                Console.WriteLine("Descripcion Tarea: " + tareaX.Descripcion);
                Console.WriteLine("Duracion de Tarea: " + tareaX.Duracion);

            }
            Console.WriteLine("   ");

            //Muestra las tareas pendientes
            foreach (Tareas tareaX in ListaDeTareas)
            {
                Console.WriteLine("Tareas Pendientes");
                Console.WriteLine("Descripcion Tarea: " + tareaX.Descripcion);
                Console.WriteLine("Duracion de Tarea: " + tareaX.Duracion);
            }

            Console.WriteLine("Ingrese el ID buscado");
            int id = Convert.ToInt32(Console.ReadLine());
            Tareas tareaBuscada = HelperTareas.BusquedaPorId(ListaDeTareas, TareasRealizadas, id);
            Console.WriteLine("tarea BuscadaPorId: " + tareaBuscada.Descripcion);

            Console.WriteLine("Ingrese la descripcion de tarea a buscar");
            string palabraBuscada = Console.ReadLine();
            Tareas palabraEncontrada = HelperTareas.BusquedaPorPalabra(ListaDeTareas, TareasRealizadas, palabraBuscada);
            Console.WriteLine("tarea BuscadaPorPalabra: " + palabraEncontrada.Descripcion);
        }
      }
}
