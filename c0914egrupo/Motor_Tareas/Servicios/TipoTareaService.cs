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
    public class TipoTareaService : ITipoTareaService
    {
        private ITipoTareaRepository tipotareaRepository;
        private TipoTareaUtil tipotareaUtil;

        public TipoTareaService(TipoTareaRepository _tipotareaRepository, TipoTareaUtil _tipotareaUtil)
        {
            this.tipotareaRepository = _tipotareaRepository;
            this.tipotareaUtil = _tipotareaUtil;
        }

        public TipoTareaVO addTipoTarea(TipoTareaVO _tipotarea)
        {
            TipoTarea tipotarea = tipotareaUtil.ConvierteTipoTareaVOToEntity(_tipotarea);
            tipotarea = tipotareaRepository.addTipoTarea(tipotarea);
            return tipotareaUtil.ConvierteEntityToTipoTareaVO(tipotarea);
        }

        public void eliminaTipoTarea(int _id)
        {
            tipotareaRepository.eliminaTipoTarea(_id);
        }

        public TipoTareaVO getTipoTarea(int _id)
        {
            TipoTarea tipotarea = tipotareaRepository.getTipoTarea(_id);
            return tipotareaUtil.ConvierteEntityToTipoTareaVO(tipotarea);
        }

        public List<TipoTareaVO> getTiposTareas()
        {
            List<TipoTarea> res = tipotareaRepository.getTipoTareas();
            return tipotareaUtil.ConvierteEntityToTiposTareaVO(res);
        }

        public TipoTareaVO modificaTipoTarea(TipoTareaVO _tarea)
        {
            TipoTarea tipotarea = tipotareaUtil.ConvierteTipoTareaVOToEntity(_tarea);
            tipotarea = tipotareaRepository.modificaTipoTarea(tipotarea);
            return tipotareaUtil.ConvierteEntityToTipoTareaVO(tipotarea);
        }
    }
}
