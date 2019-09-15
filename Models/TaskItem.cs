using System;

namespace TasklistAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string TaskTitulo { get; set; }
        public string TaskDescricao { get; set; }
        public DateTime TaskDataCriacao { get; set; }
        public bool TaskFlgConcluido { get; set; }
    }
}
