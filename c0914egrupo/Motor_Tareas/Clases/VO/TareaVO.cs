using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases.VO
{
    public class TareaVO
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int tipotareaId { get; set; }
        public TipoTareaVO tipotarea { get; set; }

        public TareaVO()
        { }
    }
}
