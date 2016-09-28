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
    public class TareaRepository : ITareaRepository
    {
        public TareaRepository()
        {
        }

        public Tarea addTarea(Tarea _tarea)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Tarea res = null;
                res = motorTareasDB.tareas.Add(_tarea);
                motorTareasDB.SaveChanges();
                return res;
            }
        }

        public void eliminaTarea(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Tarea res = null;
                res = motorTareasDB.tareas.Find(_id);
                motorTareasDB.tareas.Remove(res);
                motorTareasDB.SaveChanges();
            }
        }

        public Tarea getTarea(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Tarea res = null;
                res = motorTareasDB.tareas.Find(_id);
                return res;
            }
        }

        public List<Tarea> getTareas()
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                return motorTareasDB.tareas.ToList<Tarea>();
        
            }
        }

        public Tarea modificaTarea(Tarea _tarea)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                Tarea res = motorTareasDB.tareas.Attach(_tarea);
                motorTareasDB.Entry(_tarea).State = EntityState.Modified;
                motorTareasDB.SaveChanges();
                return res;
            }
        }
    }
}
