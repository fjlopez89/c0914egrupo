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


        public List<TareaVO> Get()
        {
            TareaRepository tarearepository = new TareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TareaUtil tareautil = new TareaUtil(tipotareautil);
            TareaService tareaservice= new TareaService(tarearepository, tareautil);

            List<TareaVO> tareavo = new List<TareaVO>();
            tareavo = tareaservice.getTareas();
            return tareavo;
        }

        public TareaVO Get(int id)
        {
            TareaRepository tarearepository = new TareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TareaUtil tareautil = new TareaUtil(tipotareautil);
            TareaService tareaservice = new TareaService(tarearepository, tareautil);


            TareaVO tareavo = new TareaVO();
            tareavo = tareaservice.getTarea(id);
            return tareavo;
        }


        // POST api/values
        public TareaVO Post([FromBody]TareaVO _tareaVO)
        {
            TareaRepository tarearepository = new TareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TareaUtil tareautil = new TareaUtil(tipotareautil);
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            TareaVO respuesta = tareaservice.addTarea(_tareaVO);
            return respuesta;

        }

        // PUT api/values/5
        public TareaVO Put(int id, [FromBody]TareaVO _tareaVO)
        {
            TareaRepository tarearepository = new TareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TareaUtil tareautil = new TareaUtil(tipotareautil);
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            TareaVO tareavo = null;
            if (_tareaVO.id == id)
            {
                tareavo = tareaservice.modificaTarea(_tareaVO);
            }
            return tareavo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            TareaRepository tarearepository = new TareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TareaUtil tareautil = new TareaUtil(tipotareautil);
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            tareaservice.eliminaTarea(id);
         
        }



    }
}
