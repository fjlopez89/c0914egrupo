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
        


        public List<ProcesoVO> Get()
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            List<ProcesoVO> procesovo = new List<ProcesoVO>();
            procesovo = procesoservice.getProcesos();
            return procesovo;
        }

        public ProcesoVO Get(int id)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            ProcesoVO procesovo = new ProcesoVO();
            procesovo = procesoservice.getProceso(id);
            return procesovo;
        }


        // POST api/values
        public ProcesoVO Post([FromBody]ProcesoVO _procesoVO)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            ProcesoVO respuesta = procesoservice.addProceso(_procesoVO);
            return respuesta;

        }

        // PUT api/values/5
        public ProcesoVO Put(int id, [FromBody]ProcesoVO _procesoVO)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);

            ProcesoVO procesovo = null;
            if (_procesoVO.id == id)
            {
                procesovo = procesoservice.modificaProceso(_procesoVO);
            }
            return procesovo;


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            ProcesoRepository procesorepository = new ProcesoRepository();
            ProcesoUtil procesoutil = new ProcesoUtil();
            ProcesoService procesoservice = new ProcesoService(procesorepository, procesoutil);
            procesoservice.eliminaProceso(id);  
        }



    }
}
