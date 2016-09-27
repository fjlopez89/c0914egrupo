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
    public class TareaService: ITareaService
    {
        private ITareaRepository tareaRepository;
        private TareaUtil tareaUtil;

        public TareaService(TareaRepository _tareaRepository, TareaUtil _tareaUtil)
        {
            this.tareaRepository = _tareaRepository;
            this.tareaUtil = _tareaUtil;
        }

        public TareaVO addTarea(TareaVO _tarea)
        {
            Tarea tarea = tareaUtil.ConvierteTareaVOToEntity(_tarea);
            tarea = tareaRepository.addTarea(tarea);
            return tareaUtil.ConvierteEntityToTareaVO(tarea);
        }

        public void eliminaTarea(int _id)
        {
            tareaRepository.eliminaTarea(_id);
        }

        public TareaVO getTarea(int _id)
        {
            Tarea tarea = tareaRepository.getTarea(_id);
            return tareaUtil.ConvierteEntityToTareaVO(tarea);
        }

        public List<TareaVO> getTareas()
        {
            List<Tarea> res = tareaRepository.getTareas();
            return tareaUtil.ConvierteEntityToTareasVO(res);
        }

        public TareaVO modificaTarea(TareaVO _tarea)
        {
            Tarea tarea = tareaUtil.ConvierteTareaVOToEntity(_tarea);
            tarea = tareaRepository.modificaTarea(tarea);
            return tareaUtil.ConvierteEntityToTareaVO(tarea);
        }
    }
}
