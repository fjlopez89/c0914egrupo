namespace Motor_Tareas.Clases.Interfaces
{
    public interface IFlujo
    {
        bool condicion { get; set; }
        int id { get; set; }
        Proceso proceso { get; set; }
        int ProcesoId { get; set; }
        Tarea tareaDestino { get; set; }
        int TareaDestinoId { get; set; }
        Tarea tareaOrigen { get; set; }
        int TareaOrigenId { get; set; }
    }
}