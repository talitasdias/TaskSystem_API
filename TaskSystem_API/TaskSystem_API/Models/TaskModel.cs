namespace TaskSystem_API.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descricao { get; set; }
        public TaskStatus Status { get; set; }
    }
}
