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
    public class TipoTareasController : ApiController
    {


        public List<TipoTareaVO> Get()
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            List<TipoTareaVO> tipotareavo = new List<TipoTareaVO>();
            tipotareavo = tipotareaservice.getTiposTareas();
            return tipotareavo;
        }

        public TipoTareaVO Get(int id)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);


            TipoTareaVO tipotareavo = new TipoTareaVO();
            tipotareavo = tipotareaservice.getTipoTarea(id);
            return tipotareavo;
        }


        // POST api/values
        public TipoTareaVO Post([FromBody]TipoTareaVO _tipotareaVO)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            TipoTareaVO respuesta = tipotareaservice.addTipoTarea(_tipotareaVO);
            return respuesta;

        }

        // PUT api/values/5
        public TipoTareaVO Put(int id, [FromBody]TipoTareaVO _tipotareaVO)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            TipoTareaVO tipotareavo = null;
            if (_tipotareaVO.id == id)
            {
                tipotareavo = tipotareaservice.modificaTipoTarea(_tipotareaVO);
            }
            return tipotareavo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            tipotareaservice.eliminaTipoTarea(id);
         
        }



    }
}
