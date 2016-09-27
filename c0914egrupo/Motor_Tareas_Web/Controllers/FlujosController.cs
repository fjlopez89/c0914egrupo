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
using Motor_Tareas.Clases.VO;

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
            flujovo = flujoservice.Lista();
            return flujovo;
        }

        public FlujoVO Get(int id)
        {
            FlujoVO flujovo = new FlujoVO();
            flujovo = flujoservice.Leer(id);
            return flujovo;
        }


        // POST api/values
        public FlujoVO Post([FromBody]FlujoVO _flujoVO)
        {
            FlujoRepository flujorepository = new FlujoRepository();
            FlujoUtil flujoutil = new FlujoUtil();
            FlujoService flujoservice = new FlujoService(flujorepository, flujoutil);

            FlujoVO respuesta = flujoservice.Create(_flujoVO);
            return respuesta;

        }

        // PUT api/values/5
        public bool Put(int id, [FromBody]FlujoVO _flujoVO)
        {
            FlujoRepository flujorepository = new FlujoRepository();
            FlujoUtil flujoutil = new FlujoUtil();
            FlujoService flujoservice = new FlujoService(flujorepository, flujoutil);

            bool flujovo = false;
            if (_flujoVO.id == id)
            {
                flujovo = flujoservice.Modificar(_flujoVO);
            }
            return flujovo;


        }

        // DELETE api/values/5
        public bool Delete(int id)
        {

            FlujoRepository flujorepository = new FlujoRepository();
            FlujoUtil flujoutil = new FlujoUtil();
            FlujoService flujoservice = new FlujoService(flujorepository, flujoutil);


            bool flujovo = flujoservice.Delete(id);
            return flujovo;
        }



    }
}
