using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Utiles
{

    public class TipoTareaUtil
    {
        public TipoTareaUtil()
        {
        }

        public TipoTarea ConvierteTipoTareaVOToEntity(TipoTareaVO _tipoTarea)
        {
            if (_tipoTarea == null)
            {
                return null;
            }
            else
            {
                TipoTarea res = new TipoTarea();
                res.tipotareaId = _tipoTarea.tipotareaId;
                res.nombre = _tipoTarea.nombre;
                return res;
            }
        }

        public TipoTareaVO ConvierteEntityToTipoTareaVO(TipoTarea _tipoTarea)
        {
            if (_tipoTarea == null)
            {
                return null;
            }
            else
            {
                TipoTareaVO res = new TipoTareaVO();
                res.tipotareaId = _tipoTarea.tipotareaId;
                res.nombre = _tipoTarea.nombre;
                return res;
            }
        }

        public List<TipoTarea> ConvierteTiposTareaVOToEntity(List<TipoTareaVO> _tiposTarea)
        {
            if (_tiposTarea == null)
            {
                return null;
            }
            else
            {
                List<TipoTarea> res = new List<TipoTarea>();
                foreach(TipoTareaVO tipoTareaVO in _tiposTarea)
                {
                    res.Add(this.ConvierteTipoTareaVOToEntity(tipoTareaVO));
                }
                return res;
            }
        }

        public List<TipoTareaVO> ConvierteEntityToTiposTareaVO(List<TipoTarea> _tiposTarea)
        {
            if (_tiposTarea == null)
            {
                return null;
            }
            else
            {
                List<TipoTareaVO> res = new List<TipoTareaVO>();
                foreach (TipoTarea tipoTarea in _tiposTarea)
                {
                    res.Add(this.ConvierteEntityToTipoTareaVO(tipoTarea));
                }
                return res;
            }
        }
    }
}
