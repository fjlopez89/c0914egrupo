using System.Collections.Generic;
using Motor_Tareas.Clases.VO;

namespace Motor_Tareas.Servicios.Interfaces
{
    public interface ITipoTareaService
    {
        TipoTareaVO addTipoTarea(TipoTareaVO _tipotarea);
        void eliminaTipoTarea(int _id);
        List<TipoTareaVO> getTiposTareas();
        TipoTareaVO getTipoTarea(int _id);
        TipoTareaVO modificaTipoTarea(TipoTareaVO _tipotarea);
    }
}