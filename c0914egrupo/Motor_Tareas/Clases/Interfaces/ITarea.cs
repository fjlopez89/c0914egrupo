using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases.Interfaces
{
    public interface ITarea
    {
        int id { get; set; }
        string nombre { get; set; }
        int TipoTareaId { get; set; }
        TipoTarea tipoTarea { get; set; }
    }
}
