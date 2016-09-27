using Motor_Tareas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Repositorios.Interfaces
{
    public interface IProcesoRepository
    {
        Proceso getProceso(int _id);

        List<Proceso> getProcesos();

        Proceso addProceso(Proceso _proceso);

        void eliminaProceso(int _id);

        Proceso modificaProceso(Proceso _proceso);
    }
}
