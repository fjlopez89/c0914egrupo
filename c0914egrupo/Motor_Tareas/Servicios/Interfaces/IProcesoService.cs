using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Servicios.Interface
{
    public interface IProcesoService
    {
        ProcesoVO getProceso(int _id);

        List<ProcesoVO> getProcesos();

        ProcesoVO addProceso(ProcesoVO _proceso);

        void eliminaProceso(int _id);

        ProcesoVO modificaProceso(ProcesoVO _proceso);
    }
}
