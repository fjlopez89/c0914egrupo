using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Utiles
{
    public class FlujoUtil
    {
        private ProcesoUtil procesoUtil;
        private TareaUtil tareaUtil;

        public FlujoUtil(ProcesoUtil _procesoUtil, TareaUtil _tareaUtil)
        {
            this.procesoUtil = _procesoUtil;
            this.tareaUtil = _tareaUtil;
        }

        public Flujo ConvierteFlujoVOToEntity(FlujoVO _flujo)
        {
            if (_flujo == null)
            {
                return null;
            }
            else
            {
                Flujo res = new Flujo();
                res.id = _flujo.id;
                res.ProcesoId = _flujo.ProcesoId;
                res.proceso = procesoUtil.ConvierteProcesoVOToEntity(_flujo.proceso);
                res.TareaDestinoId = _flujo.TareaDestinoId;
                res.tareaDestino = tareaUtil.ConvierteTareaVOToEntity(_flujo.tareaDestino);
                res.TareaOrigenId = _flujo.TareaOrigenId;
                res.tareaOrigen = tareaUtil.ConvierteTareaVOToEntity(_flujo.tareaOrigen);
                return res;
            }
        }

        public FlujoVO ConvierteEntityToFlujoVO(Flujo _flujo)
        {
            if (_flujo == null)
            {
                return null;
            }
            else
            {
                FlujoVO res = new FlujoVO();
                res.id = _flujo.id;
                res.ProcesoId = _flujo.ProcesoId;
                res.proceso = procesoUtil.ConvierteEntityToProcesoVO(_flujo.proceso);
                res.TareaDestinoId = _flujo.TareaDestinoId;
                res.tareaDestino = tareaUtil.ConvierteEntityToTareaVO(_flujo.tareaDestino);
                res.TareaOrigenId = _flujo.TareaOrigenId;
                res.tareaOrigen = tareaUtil.ConvierteEntityToTareaVO(_flujo.tareaOrigen);
                return res;
            }
        }

        public List<Flujo> ConvierteFlujosVOToEntity(List<FlujoVO> _flujos)
        {
            if (_flujos == null)
            {
                return null;
            }
            else
            {
                List<Flujo> res = new List<Flujo>();
                foreach (FlujoVO flujoVO in _flujos)
                {
                    res.Add(this.ConvierteFlujoVOToEntity(flujoVO));
                }
                return res;
            }
        }

        public List<FlujoVO> ConvierteEntityToFlujosVO(List<Flujo> _flujos)
        {
            if (_flujos == null)
            {
                return null;
            }
            else
            {
                List<FlujoVO> res = new List<FlujoVO>();
                foreach (Flujo flujo in _flujos)
                {
                    res.Add(this.ConvierteEntityToFlujoVO(flujo));
                }
                return res;
            }
        }
    }
}
