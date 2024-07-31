using SQLite;

namespace AppTask_ToDoList.Models
{
    [Table("SubTasks")]
    class SubTaskModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
