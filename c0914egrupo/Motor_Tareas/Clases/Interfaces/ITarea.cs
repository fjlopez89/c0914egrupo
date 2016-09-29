namespace Motor_Tareas.Clases.Interfaces
{
    public interface ITarea
    {
        int id { get; set; }
        string nombre { get; set; }
        TipoTarea tipotarea { get; set; }
        int tipotareaId { get; set; }
    }
}