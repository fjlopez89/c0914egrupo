using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Utiles
{
    public class TareaUtil
    {
        private TipoTareaUtil tipoTareaUtil;

        public TareaUtil(TipoTareaUtil _tipoTareaUtil)
        {
            this.tipoTareaUtil = _tipoTareaUtil;
        }

        public Tarea ConvierteTareaVOToEntity(TareaVO _tarea)
        {
            if (_tarea == null)
            {
                return null;
            }
            else
            {
                Tarea res = new Tarea();
                res.id = _tarea.id;
                res.nombre = _tarea.nombre;
                res.TipoTareaId = _tarea.TipoTareaId;
                res.tipoTarea = tipoTareaUtil.ConvierteTipoTareaVOToEntity(_tarea.tipoTarea);
                return res;
            }
        }

        public TareaVO ConvierteEntityToTareaVO(Tarea _tarea)
        {
            if (_tarea == null)
            {
                return null;
            }
            else
            {
                TareaVO res = new TareaVO();
                res.id = _tarea.id;
                res.nombre = _tarea.nombre;
                res.TipoTareaId = _tarea.TipoTareaId;
                res.tipoTarea = tipoTareaUtil.ConvierteEntityToTipoTareaVO(_tarea.tipoTarea);
                return res;
            }
        }

        public List<Tarea> ConvierteTareasVOToEntity(List<TareaVO> _tareas)
        {
            if (_tareas == null)
            {
                return null;
            }
            else
            {
                List<Tarea> res = new List<Tarea>();
                foreach (TareaVO tareaVO in _tareas)
                {
                    res.Add(this.ConvierteTareaVOToEntity(tareaVO));
                }
                return res;
            }
        }

        public List<TareaVO> ConvierteEntityToTareasVO(List<Tarea> _tareas)
        {
            if (_tareas == null)
            {
                return null;
            }
            else
            {
                List<TareaVO> res = new List<TareaVO>();
                foreach (Tarea tarea in _tareas)
                {
                    res.Add(this.ConvierteEntityToTareaVO(tarea));
                }
                return res;
            }
        }
    }
}


