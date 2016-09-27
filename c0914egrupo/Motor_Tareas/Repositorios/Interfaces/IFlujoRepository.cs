using Motor_Tareas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Repositorios
{
   public interface IFlujoRepository
    {
        Flujo getFlujo(int _id);

        List<Flujo> getFlujos();

        Flujo addFlujo(Flujo _flujo);

        void eliminaFlujo(int _id);

        Flujo modificaFlujo(Flujo _flujo);
    }
}
