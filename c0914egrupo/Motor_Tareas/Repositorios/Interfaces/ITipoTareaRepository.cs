using System.Collections.Generic;
using Motor_Tareas.Clases;

namespace Motor_Tareas.Repositorios.Interfaces
{
    public interface ITipoTareaRepository
    {
        TipoTarea addTipoTarea(TipoTarea _tipotarea);
        void eliminaTipoTarea(int _id);
        TipoTarea getTipoTarea(int _id);
        List<TipoTarea> getTipoTareas();
        TipoTarea modificaTipoTarea(TipoTarea _tipotarea);
    }
}