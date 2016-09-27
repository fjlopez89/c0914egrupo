using Motor_Tareas.Repositorios;
using Motor_Tareas.Repositorios.Interfaces;
using Motor_Tareas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motor_Tareas.Clases;
using Motor_Tareas.Utiles;
using Motor_Tareas.Clases.VO;

namespace Motor_Tareas.Servicios
{
    public class ProcesoService: IProcesoService
    {
        private IProcesoRepository procesoRepository;
        private ProcesoUtil procesoUtil;

        public ProcesoService(ProcesoRepository _procesoRepository, ProcesoUtil _procesoUtil)
        {
            this.procesoRepository = _procesoRepository;
            this.procesoUtil = _procesoUtil;
        }

        public ProcesoVO addProceso(ProcesoVO _proceso)
        {
            Proceso proceso = procesoUtil.ConvierteProcesoVOToEntity(_proceso);
            proceso = procesoRepository.addProceso(proceso);
            return procesoUtil.ConvierteEntityToProcesoVO(proceso);
        }

        public void eliminaProceso(int _id)
        {
            procesoRepository.eliminaProceso(_id);
        }

        public ProcesoVO getProceso(int _id)
        {
            Proceso proceso = procesoRepository.getProceso(_id);
            return procesoUtil.ConvierteEntityToProcesoVO(proceso);
        }

        public List<ProcesoVO> getProcesos()
        {
            List<Proceso> res = procesoRepository.getProcesos();
            return procesoUtil.ConvierteEntityToProcesosVO(res);
        }

        public ProcesoVO modificaProceso(ProcesoVO _proceso)
        {
            Proceso proceso = procesoUtil.ConvierteProcesoVOToEntity(_proceso);
            proceso = procesoRepository.modificaProceso(proceso);
            return procesoUtil.ConvierteEntityToProcesoVO(proceso);
        }
    }
}
