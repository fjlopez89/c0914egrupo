using Motor_Tareas.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motor_Tareas.Clases;
using static Motor_Tareas.DB.MotorTareaDB;
using System.Data.Entity;

namespace Motor_Tareas.Repositorios
{
    public class ProcesoRepository : IProcesoRepository
    {
        public ProcesoRepository()
        {
        }

        public Proceso addProceso(Proceso _proceso)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Proceso res = null;
                res = motorTareasDB.procesos.Add(_proceso);
                motorTareasDB.SaveChanges();
                return res;
            }
        }

        public void eliminaProceso(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Proceso res = null;
                res = motorTareasDB.procesos.Find(_id);
                motorTareasDB.procesos.Remove(res);
                motorTareasDB.SaveChanges();
            }
        }

        public Proceso getProceso(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Proceso res = null;
                res = motorTareasDB.procesos.Find(_id);
                return res;
            }
        }

        public List<Proceso> getProcesos()
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                return motorTareasDB.procesos.ToList<Proceso>();
            }
        }

        public Proceso modificaProceso(Proceso _proceso)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Proceso res = motorTareasDB.procesos.Attach(_proceso);
                motorTareasDB.Entry(_proceso).State = EntityState.Modified;
                motorTareasDB.SaveChanges();
                return res;
            }
        }
    }
}
