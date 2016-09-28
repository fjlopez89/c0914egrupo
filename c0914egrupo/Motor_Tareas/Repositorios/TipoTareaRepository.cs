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
    public class TipoTareaRepository : ITipoTareaRepository
    {
        public TipoTareaRepository()
        {
        }

        public TipoTarea addTipoTarea(TipoTarea _tipotarea)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                TipoTarea res = null;
                res = motorTareasDB.tiposTarea.Add(_tipotarea);
                motorTareasDB.SaveChanges();
                return res;
            }
        }

        public void eliminaTipoTarea(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                TipoTarea res = null;
                res = motorTareasDB.tiposTarea.Find(_id);
                motorTareasDB.tiposTarea.Remove(res);
                motorTareasDB.SaveChanges();
            }
        }

        public TipoTarea getTipoTarea(int _id)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                TipoTarea res = null;
                res = motorTareasDB.tiposTarea.Find(_id);
                return res;
            }
        }

        public List<TipoTarea> getTipoTareas()
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                return motorTareasDB.tiposTarea.ToList<TipoTarea>();
            }
        }

        public TipoTarea modificaTipoTarea(TipoTarea _tipotarea)
        {
            using (var motorTareasDB = new MotorTareasDB())
            {
                TipoTarea res = motorTareasDB.tiposTarea.Attach(_tipotarea);
                motorTareasDB.Entry(_tipotarea).State = EntityState.Modified;
                motorTareasDB.SaveChanges();
                return res;
            }
        }
    }
}
