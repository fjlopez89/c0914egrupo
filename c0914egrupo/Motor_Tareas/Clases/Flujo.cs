using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    public class Flujo
    {
        public int id { get; set; }

        public int ProcesoId { get; set; }
        public Proceso proceso { get; set; }

        public int TareaOrigenId { get; set; }
        public Tarea tareaOrigen { get; set; }

        public int TareaDestinoId { get; set; }
        public Tarea tareaDestino { get; set; }

        public bool condicion { get; set; }

        public Flujo()
        { }
    }
}
