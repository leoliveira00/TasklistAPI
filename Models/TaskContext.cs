using Microsoft.EntityFrameworkCore;

namespace TasklistAPI.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options):base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}