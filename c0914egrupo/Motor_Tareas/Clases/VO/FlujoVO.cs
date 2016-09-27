using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases.VO
{
    public class FlujoVO
    {
        public int id { get; set; }

        public int ProcesoId { get; set; }
        public ProcesoVO proceso { get; set; }

        public int TareaOrigenId { get; set; }
        public TareaVO tareaOrigen { get; set; }

        public int TareaDestinoId { get; set; }
        public TareaVO tareaDestino { get; set; }

        public bool condicion { get; set; }

        public FlujoVO()
        { }
    }
}
