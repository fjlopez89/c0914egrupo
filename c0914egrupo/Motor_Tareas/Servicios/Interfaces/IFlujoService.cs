using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Servicios.Interfaces
{
    interface IFlujoService
    {
        FlujoVO getFlujo(int _id);

        List<FlujoVO> getFlujos();

        FlujoVO addFlujo(FlujoVO _flujo);

        void eliminaFlujo(int _id);

        FlujoVO modificaFlujo(FlujoVO _flujo);
    }
}
