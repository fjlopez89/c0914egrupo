using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Servicios.Interfaces
{
    interface ITareaService
    {
        TareaVO getTarea(int _id);

        List<TareaVO> getTareas();

        TareaVO addTarea(TareaVO _tarea);

        void eliminaTarea(int _id);

        TareaVO modificaTarea(TareaVO _tarea);
    }
}
