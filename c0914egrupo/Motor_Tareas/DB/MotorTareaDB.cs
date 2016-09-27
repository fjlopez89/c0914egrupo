using Motor_Tareas.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Motor_Tareas.DB.MotorTareasInitializer;

namespace Motor_Tareas.DB
{
    class MotorTareaDB
    {
        public class MotorTareasDB : DbContext
        {


            public DbSet<TipoTarea> tiposTarea { get; set; }
            public DbSet<Tarea> tareas { get; set; }
<<<<<<< HEAD



=======
            public DbSet<Flujo> flujos { get; set; }
            public DbSet<Proceso> procesos { get; set; }
>>>>>>> d5a9879e33f58f901674dcd1717fdc755639280a

            public MotorTareasDB() : base("MotorTareasDB")
            {
                Database.SetInitializer(new MotorTareasDBInitializer());

            }
        }
    }
}
