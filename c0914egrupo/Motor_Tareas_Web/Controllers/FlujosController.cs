
using Motor_Tareas.Clases.VO;
using Microsoft.Practices.Unity;
using Motor_Tareas.Repositorios;
using Motor_Tareas.Servicios;
using Motor_Tareas.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Motor_Tareas.Servicios.Interfaces;

namespace Motor_Tareas_Web.Controllers
{
    public class FlujoController : ApiController
    {
        private IFlujoService flujoService;

        public FlujoController()
        {
            var container = new UnityContainer();
            container.RegisterType<FlujoUtil, FlujoUtil>();
            container.RegisterType<TareaUtil, TareaUtil>();
            container.RegisterType<ProcesoUtil, ProcesoUtil>();
            container.RegisterType<TipoTareaUtil, TipoTareaUtil>();
            container.RegisterType<IFlujoRepository, FlujoRepository>();
            container.RegisterType<IFlujoService, FlujoService>();
            flujoService = container.Resolve<IFlujoService>();
        }

        public List<FlujoVO> Get()
        {
            List<FlujoVO> flujovo = new List<FlujoVO>();
            flujovo = flujoService.getFlujos();
            return flujovo;
        }

        public FlujoVO Get(int id)
        {
            FlujoVO flujovo = new FlujoVO();
            flujovo = flujoService.getFlujo(id);
            return flujovo;
        }


        // POST api/values
        public FlujoVO Post([FromBody]FlujoVO _flujoVO)
        {
          
            FlujoVO respuesta = flujoService.addFlujo(_flujoVO);
            return respuesta;

        }

        // PUT api/values/5
        public FlujoVO Put(int id, [FromBody]FlujoVO _flujoVO)
        {
            FlujoVO flujovo = null;
            if (_flujoVO.id == id)
            {
                flujovo = flujoService.modificaFlujo(_flujoVO);
            }
            return flujovo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            flujoService.eliminaFlujo(id);
         
        }



    }
}
