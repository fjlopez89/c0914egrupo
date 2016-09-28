using Motor_Tareas.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Tareas.Clases
{
    public class TipoTarea: ITipoTarea
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

        public TipoTarea()
        { }
    }
}
