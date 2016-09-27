using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Utiles
{
    public class ProcesoUtil
    {
        public ProcesoUtil()
        {
        }

        public Proceso ConvierteProcesoVOToEntity(ProcesoVO _proceso)
        {
            if (_proceso == null)
            {
                return null;
            }
            else
            {
                Proceso res = new Proceso();
                res.id = _proceso.id;
                res.nombre = _proceso.nombre;
                return res;
            }
        }

        public ProcesoVO ConvierteEntityToProcesoVO(Proceso _proceso)
        {
            if (_proceso == null)
            {
                return null;
            }
            else
            {
                ProcesoVO res = new ProcesoVO();
                res.id = _proceso.id;
                res.nombre = _proceso.nombre;
                return res;
            }
        }

        public List<Proceso> ConvierteProcesosVOToEntity(List<ProcesoVO> _procesos)
        {
            if (_procesos == null)
            {
                return null;
            }
            else
            {
                List<Proceso> res = new List<Proceso>();
                foreach (ProcesoVO procesoVO in _procesos)
                {
                    res.Add(this.ConvierteProcesoVOToEntity(procesoVO));
                }
                return res;
            }
        }

        public List<ProcesoVO> ConvierteEntityToProcesosVO(List<Proceso> _procesos)
        {
            if (_procesos == null)
            {
                return null;
            }
            else
            {
                List<ProcesoVO> res = new List<ProcesoVO>();
                foreach (Proceso proceso in _procesos)
                {
                    res.Add(this.ConvierteEntityToProcesoVO(proceso));
                }
                return res;
            }
        }
    }
}
