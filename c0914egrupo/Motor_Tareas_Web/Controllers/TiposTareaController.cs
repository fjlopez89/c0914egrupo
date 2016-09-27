using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Motor_Tareas_Web.Controllers
{
    public class TiposTareaController : ApiController
    {


        public List<TipoTareaVO> Get()
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            List<TipoTareaVO> tipotareavo = new List<TipoTareaVO>();
            tipotareavo = tipotareaservice.Lista();
            return tipotareavo;
        }

        public TipoTareaVO Get(int id)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            TipoTareaVO tipotareavo = new TipoTareaVO();
            tipotareavo = tipotareaservice.Leer(id);
            return tipotareavo;
        }


        // POST api/values
        public TipoTareaVO Post([FromBody]TipoTareaVO _tipotareaVO)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            TipoTareaVO respuesta = tipotareaservice.Create(_tipotareaVO);
            return respuesta;

        }

        // PUT api/values/5
        public bool Put(int id, [FromBody]TipoTareaVO _tipotareaVO)
        {
            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);

            bool tipotareavo = false;
            if (_tipotareaVO.id == id)
            {
                tipotareavo = tipotareaservice.Modificar(_tipotareaVO);
            }
            return tipotareavo;


        }

        // DELETE api/values/5
        public bool Delete(int id)
        {

            TipoTareaRepository tipotarearepository = new TipoTareaRepository();
            TipoTareaUtil tipotareautil = new TipoTareaUtil();
            TipoTareaService tipotareaservice = new TipoTareaService(tipotarearepository, tipotareautil);


            bool tipotareavo = tipotareaservice.Delete(id);
            return tipotareavo;
        }



    }
}
