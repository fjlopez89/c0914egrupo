using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Motor_Tareas_Web.Controllers
{
    public class FlujoController : ApiController
    {


        public List<FlujoVO> Get()
        {
            FlujoRepository flujorepository = new FlujoRepository();
            FlujoUtil flujoutil = new FlujoUtil();
            FlujoService flujoservice = new FlujoService(flujorepository, flujoutil);

            List<FlujoVO> flujovo = new List<FlujoVO>();
            flujovo = flujoservice.Lista();
            return flujovo;
        }

        public FlujoVO Get(int id)
        {
            FlujoRepository flujorepository = new FlujoRepository();
            FlujoUtil flujoutil = new FlujoUtil();
            FlujoService flujoservice = new FlujoService(flujorepository, flujoutil);

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
