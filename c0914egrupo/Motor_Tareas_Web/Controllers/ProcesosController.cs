using Microsoft.Practices.Unity;
using Motor_Tareas.Clases;
using Motor_Tareas.Clases.VO;
using Motor_Tareas.Repositorios;
using Motor_Tareas.Servicios;
using Motor_Tareas.Servicios.Interface;
using Motor_Tareas.Servicios.Interfaces;
using Motor_Tareas.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Motor_Tareas_Web.Controllers
{
    public class ProcesosController : ApiController
    {
        private IProcesoService procesoService;

        public ProcesosController()
        {
            var container = new UnityContainer();
            container.RegisterType<FlujoUtil, FlujoUtil>();
            container.RegisterType<TareaUtil, TareaUtil>();
            container.RegisterType<ProcesoUtil, ProcesoUtil>();
            container.RegisterType<TipoTareaUtil, TipoTareaUtil>();
            container.RegisterType<IFlujoRepository, FlujoRepository>();
            container.RegisterType<IFlujoService, FlujoService>();
            procesoService = container.Resolve<IProcesoService>();
        }


        public List<ProcesoVO> Get()
        {
            List<ProcesoVO> procesovo = new List<ProcesoVO>();
            procesovo = procesoService.getProcesos();
            return procesovo;
        }

        public ProcesoVO Get(int id)
        {
        
            ProcesoVO procesovo = new ProcesoVO();
            procesovo = procesoService.getProceso(id);
            return procesovo;
        }


        // POST api/values
        public ProcesoVO Post([FromBody]ProcesoVO _procesoVO)
        {

            ProcesoVO respuesta = procesoService.addProceso(_procesoVO);
            return respuesta;

        }

        // PUT api/values/5
        public ProcesoVO Put(int id, [FromBody]ProcesoVO _procesoVO)
        {
            ProcesoVO procesovo = null;
            if (_procesoVO.id == id)
            {
                procesovo = procesoService.modificaProceso(_procesoVO);
            }
            return procesovo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            procesoService.eliminaProceso(id);  
        }



    }
}
