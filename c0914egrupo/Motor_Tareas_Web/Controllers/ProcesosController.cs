using Motor_Tareas.Clases;
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


        public List<Proceso> Get()
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            List<ProcesoVO> procesovo = new List<ProcesoVO>();
            procesovo = procesoservice.Lista();
            return procesovo;
        }

        public ProcesoVO Get(int id)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            ProcesoVO procesovo = new ProcesoVO();
            procesovo = procesoservice.Leer(id);
            return procesovo;
        }


        // POST api/values
        public ProcesoVO Post([FromBody]ProcesoVO _procesoVO)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            ProcesoVO respuesta = procesoservice.Create(_procesoVO);
            return respuesta;

        }

        // PUT api/values/5
        public bool Put(int id, [FromBody]ProgramaVO _programaVO)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            bool procesovo = false;
            if (_procesoVO.id == id)
            {
                procesovo = procesoservice.Modificar(_procesoVO);
            }
            return procesovo;


        }

        // DELETE api/values/5
        public bool Delete(int id)
        {

            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);


            bool procesovo = procesoservice.Delete(id);
            return procesovo;
        }



    }
}
