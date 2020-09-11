using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo
{
    public static class HelperTareas
    {
        public static Tareas BusquedaPorId(List<Tareas> tareaPendiente, List<Tareas> tareaRealizada, int id)
        {

            foreach (Tareas tareaX in tareaPendiente)
            {
                if (tareaX.Id == id)
                {
                    return tareaX;
                }
            }
            foreach (Tareas tareaX in tareaRealizada)
            {
                if (tareaX.Id == id)
                {
                    return tareaX;
                }
            }
            return null;
        }

        public static Tareas BusquedaPorPalabra(List<Tareas> tareaPendiente, List<Tareas> tareaRealizada, string nombreTarea)
        {
            foreach (Tareas tareaX in tareaPendiente)
            {
                if (String.Equals(tareaX.Descripcion, nombreTarea))
                {
                    return tareaX;
                }
            }
            foreach (Tareas tareaX in tareaRealizada)
            {
                if (String.Equals(tareaX.Descripcion, nombreTarea))
                {
                    return tareaX;
                }
            }
            return null;
        }
    }
}