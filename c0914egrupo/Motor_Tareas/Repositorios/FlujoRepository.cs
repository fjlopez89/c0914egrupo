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
    public class FlujoRepository : IFlujoRepository
    {
        public FlujoRepository()
        {
        }

        public Flujo addFlujo(Flujo _flujo)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Flujo res = null;
                res = motorTareasDB.flujos.Add(_flujo);
                motorTareasDB.SaveChanges();
                return res;
            }
        }

        public void eliminaFlujo(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Flujo res = null;
                res = motorTareasDB.flujos.Find(_id);
                motorTareasDB.flujos.Remove(res);
                motorTareasDB.SaveChanges();
            }
        }

        public Flujo getFlujo(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Flujo res = null;
                res = motorTareasDB.flujos.Find(_id);
                motorTareasDB.Entry(res).Reference(x => x.proceso).Load();
                motorTareasDB.Entry(res).Reference(x => x.tareaOrigen).Load();
                motorTareasDB.Entry(res).Reference(x => x.tareaDestino).Load();
                return res;
            }
        }

        public List<Flujo> getFlujos()
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                return motorTareasDB.flujos
                    .Include("Tarea")
                    .Include("Proceso")
                    .ToList<Flujo>();
            }
        }

        public Flujo modificaFlujo(Flujo _flujo)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Flujo res = motorTareasDB.flujos.Attach(_flujo);
                motorTareasDB.Entry(_flujo).State = EntityState.Modified;
                motorTareasDB.SaveChanges();
                return res;
            }
        }
    }
}
