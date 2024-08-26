using System.ComponentModel;

namespace TaskSystem_API.Enums
{
    public enum TaskStatus
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3
    }
}
