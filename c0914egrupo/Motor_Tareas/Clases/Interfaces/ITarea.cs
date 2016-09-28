namespace Motor_Tareas.Clases.Interfaces
{
    public interface ITarea
    {
        int id { get; set; }
        string nombre { get; set; }
        TipoTarea tipoTarea { get; set; }
        int TipoTareaId { get; set; }
    }
}