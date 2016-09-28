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
    public class Tarea : ITarea
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        
        public int TipoTareaId { get; set; }
        [ForeignKey("TipoTareaId")]
        public virtual TipoTarea tipoTarea { get; set; }

        public Tarea()
        { }
    }
}
