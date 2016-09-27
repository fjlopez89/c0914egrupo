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
            TareaUtil tareautil = new TareaUtil();
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            List<TareaVO> tareavo = new List<TareaVO>();
            tareavo = tareaservice.Lista();
            return tareavo;
        }

        public TareaVO Get(int id)
        {
            TareaRepository tarearepository = new TareaRepository();
            TareaUtil tareautil = new TareaUtil();
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            TareaVO tareavo = new TareaVO();
            tareavo = tareaservice.Leer(id);
            return tareavo;
        }


        // POST api/values
        public TareaVO Post([FromBody]TareaVO _tareaVO)
        {
            TareaRepository tarearepository = new TareaRepository();
            TareaUtil tareautil = new TareaUtil();
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            TareaVO respuesta = tareaservice.Create(_tareaVO);
            return respuesta;

        }

        // PUT api/values/5
        public bool Put(int id, [FromBody]TareaVO _tareaVO)
        {
            TareaRepository tarearepository = new TareaRepository();
            TareaUtil tareautil = new TareaUtil();
            TareaService tareaservice = new TareaService(tarearepository, tareautil);

            bool tareavo = false;
            if (_tareaVO.id == id)
            {
                tareavo = tareaservice.Modificar(_tareaVO);
            }
            return tareavo;


        }

        // DELETE api/values/5
        public bool Delete(int id)
        {

            TareaRepository tarearepository = new TareaRepository();
            TareaUtil tareautil = new TareaUtil();
            TareaService tareaservice = new TareaService(tarearepository, tareautil);


            bool tareavo = tareaservice.Delete(id);
            return tareavo;
        }



    }
}
