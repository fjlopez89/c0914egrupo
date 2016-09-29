using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases.Interfaces
{
    public interface ITipoTarea
    {
        int tipotareaId { get; set; }
        string nombre { get; set; }
    }
}
