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


            public DbSet<Proceso> programas { get; set; }
            public DbSet<Tarea> tareas { get; set; }
     



            public MotorTareasDB() : base("MotorTareasDB")
            {
                Database.SetInitializer(new MotorTareasDBInitializer());

            }
        }
}
