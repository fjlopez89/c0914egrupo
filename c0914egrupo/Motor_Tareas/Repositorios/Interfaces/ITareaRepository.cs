using Motor_Tareas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Repositorios.Interfaces
{
    public interface ITareaRepository
    {
        Tarea getTarea(int _id);

        List<Tarea> getTareas();

        Tarea addTarea(Tarea _tarea);

        void eliminaTarea(int _id);

        Tarea modificaTarea(Tarea _tarea);
    }
}
