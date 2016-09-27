using Motor_Tareas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motor_Tareas.Clases;
using Motor_Tareas.Repositorios;
using Motor_Tareas.Repositorios.Interfaces;
using Motor_Tareas.Utiles;
using Motor_Tareas.Clases.VO;

namespace Motor_Tareas.Servicios
{
    public class FlujoService: IFlujoService
    {
        private IFlujoRepository flujoRepository;
        private FlujoUtil flujoUtil;

        public FlujoService(FlujoRepository _flujoRepository, FlujoUtil _flujoUtil)
        {
            this.flujoRepository = _flujoRepository;
            this.flujoUtil = _flujoUtil;
        }

        public FlujoVO addFlujo(FlujoVO _flujo)
        {
            Flujo flujo = flujoUtil.ConvierteFlujoVOToEntity(_flujo);
            flujo =  flujoRepository.addFlujo(flujo);
            return flujoUtil.ConvierteEntityToFlujoVO(flujo);
        }

        public void eliminaFlujo(int _id)
        {
            flujoRepository.eliminaFlujo(_id);
        }

        public FlujoVO getFlujo(int _id)
        {
            Flujo flujo = flujoRepository.getFlujo(_id);
            return flujoUtil.ConvierteEntityToFlujoVO(flujo);
        }

        public List<FlujoVO> getFlujos()
        {
            List<Flujo> res = flujoRepository.getFlujos();
            return flujoUtil.ConvierteEntityToFlujosVO(res);
        }

        public FlujoVO modificaFlujo(FlujoVO _flujo)
        {
            Flujo flujo = flujoUtil.ConvierteFlujoVOToEntity(_flujo);
            flujo = flujoRepository.modificaFlujo(flujo);
            return flujoUtil.ConvierteEntityToFlujoVO(flujo);
        }
    }
}
