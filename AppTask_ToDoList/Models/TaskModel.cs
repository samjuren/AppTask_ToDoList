using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask_ToDoList.Models
{
    [Table("Tasks")]
    class TaskModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PrevisonDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey(nameof(TaskModel))]
        public List<SubTaskModel> SubTasks { get; set; } = new List<SubTaskModel>();
    }
}
