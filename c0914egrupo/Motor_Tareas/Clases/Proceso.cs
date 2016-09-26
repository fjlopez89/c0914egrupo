using Motor_Tareas.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    class Proceso : IProceso
    {

        public int id { get; set; }
        public string nombre { get; set; }


        public Proceso()
        {


        }

        public Proceso(int _id, string _nombre)
        {
            this.id = _id;
            this.nombre = _nombre; 
        }
    }
}
