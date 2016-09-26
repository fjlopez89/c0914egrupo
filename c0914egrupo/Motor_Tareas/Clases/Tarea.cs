using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    class Tarea
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        public int procesoId { get; set; }

        [ForeignKey("ProcesoId ")]
        public virtual Proceso proceso { get; set; }


        public Tarea()
        {


        }

        public Tarea(int _id, string _nombre, string _descripcion, int _procesoId)
        {

            this.id = _id;
            this.nombre = _nombre;
            this.descripcion = _descripcion;
            this.procesoId = _procesoId;

        }

    }
}
