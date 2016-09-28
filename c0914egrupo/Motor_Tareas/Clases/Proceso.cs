using Motor_Tareas.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    public class Proceso : IProceso
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

        //[InverseProperty("proceso")]
        //public IList<Flujo> flujos { get; set; }

        public Proceso()
        { }
    }
}
