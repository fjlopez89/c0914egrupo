using Motor_Tareas.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    public class Flujo : IFlujo
    {
        public int id { get; set; }


        public int ProcesoId { get; set; }
        [ForeignKey("ProcesoId")]
        public virtual Proceso proceso { get; set; }

        public int TareaOrigenId { get; set; }
        [ForeignKey("TareaOrigenId")]
        public virtual Tarea tareaOrigen { get; set; }

        public int TareaDestinoId { get; set; }
        [ForeignKey("TareaDestinoId")]
        public virtual Tarea tareaDestino { get; set; }

        public bool condicion { get; set; }

        public Flujo()
        { }
    }
}
