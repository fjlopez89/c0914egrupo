using Microsoft.Practices.Unity;
using Motor_Tareas.Clases.VO;
using Motor_Tareas.Repositorios;
using Motor_Tareas.Servicios;
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
    public class TareasController : ApiController
    {

        private ITareaService tareaService;

        public TareasController()
        {
            var container = new UnityContainer();
            container.RegisterType<FlujoUtil, FlujoUtil>();
            container.RegisterType<TareaUtil, TareaUtil>();
            container.RegisterType<ProcesoUtil, ProcesoUtil>();
            container.RegisterType<TipoTareaUtil, TipoTareaUtil>();
            container.RegisterType<IFlujoRepository, FlujoRepository>();
            container.RegisterType<IFlujoService, FlujoService>();
            tareaService = container.Resolve<ITareaService>();
        }


        public List<TareaVO> Get()
        {
            List<TareaVO> tareavo = new List<TareaVO>();
            tareavo = tareaService.getTareas();
            return tareavo;
        }

        public TareaVO Get(int id)
        {
            TareaVO tareavo = new TareaVO();
            tareavo = tareaService.getTarea(id);
            return tareavo;
        }


        // POST api/values
        public TareaVO Post([FromBody]TareaVO _tareaVO)
        {

            TareaVO respuesta = tareaService.addTarea(_tareaVO);
            return respuesta;

        }

        // PUT api/values/5
        public TareaVO Put(int id, [FromBody]TareaVO _tareaVO)
        {
            TareaVO tareavo = null;
            if (_tareaVO.id == id)
            {
                tareavo = tareaService.modificaTarea(_tareaVO);
            }
            return tareavo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            tareaService.eliminaTarea(id);
         
        }



    }
}
