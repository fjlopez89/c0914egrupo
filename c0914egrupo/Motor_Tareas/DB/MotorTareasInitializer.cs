using Motor_Tareas.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Motor_Tareas.DB.MotorTareaDB;

namespace Motor_Tareas.DB
{
    class MotorTareasInitializer
    {
        public class MotorTareasDBInitializer : DropCreateDatabaseAlways<MotorTareasDB>
        {
            protected override void Seed(MotorTareasDB context)
            {


                IList<TipoTarea> defaultTiposTarea = new List<TipoTarea>();
                IList<Tarea> defaultTareas = new List<Tarea>();

                TipoTarea tipoTarea1 = new TipoTarea();
                tipoTarea1.nombre = "Condicion";
                TipoTarea tipoTarea2 = new TipoTarea();
                tipoTarea2.nombre = "Paso";
                TipoTarea tipoTarea3 = new TipoTarea();
                tipoTarea3.nombre = "Inicio";
                TipoTarea tipoTarea4 = new TipoTarea();
                tipoTarea4.nombre = "Final";
                tipoTarea1 = context.tiposTarea.Add(tipoTarea1);
                tipoTarea2 = context.tiposTarea.Add(tipoTarea2);
                tipoTarea3 = context.tiposTarea.Add(tipoTarea3);
                tipoTarea4 = context.tiposTarea.Add(tipoTarea4);
                context.SaveChanges();

                Tarea tarea1 = new Tarea();
                tarea1.nombre = "If";
                tarea1.TipoTareaId = tipoTarea1.id;
                Tarea tarea2 = new Tarea();
                tarea2.nombre = "While";
                tarea2.TipoTareaId = tipoTarea1.id;
                Tarea tarea3 = new Tarea();
                tarea1.nombre = "Inicio";
                tarea1.TipoTareaId = tipoTarea3.id;
                Tarea tarea4 = new Tarea();
                tarea2.nombre = "Fin";
                tarea2.TipoTareaId = tipoTarea4.id;
                tarea1 = context.tareas.Add(tarea1);
                tarea2 = context.tareas.Add(tarea2);
                tarea3 = context.tareas.Add(tarea3);
                tarea4 = context.tareas.Add(tarea4);
                context.SaveChanges();
                base.Seed(context);



                base.Seed(context);

            }
        }
    }
}
