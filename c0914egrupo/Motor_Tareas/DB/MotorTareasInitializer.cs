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
          
                




                base.Seed(context);

            }
            
        }
    }
}
