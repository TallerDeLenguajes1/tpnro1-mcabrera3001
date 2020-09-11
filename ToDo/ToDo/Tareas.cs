using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo
{
    public class Tareas
    {
        int id;
        string descripcion;
        int duracion;
        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }


    }
}
