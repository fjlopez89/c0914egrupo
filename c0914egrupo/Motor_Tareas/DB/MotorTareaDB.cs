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
            public DbSet<Flujo> flujos { get; set; }
            public DbSet<Proceso> procesos { get; set; }

            public MotorTareasDB() : base("MotorTareasDB")
            {
                Database.SetInitializer(new MotorTareasDBInitializer());

            }
        }
    }
}
