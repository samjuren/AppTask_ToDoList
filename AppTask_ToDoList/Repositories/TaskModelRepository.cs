using AppTask_ToDoList.DbContext;
using AppTask_ToDoList.Models;

namespace AppTask_ToDoList.Repositories
{
    class TaskModelRepositories : ITaskModelRepository
    {
        public void Add(TaskModel task)
        {
            Database.Connection?.Insert(task);
        }

        public void Delete(TaskModel task)
        {
            Database.Connection?.Delete(task);
        }

        public IList<TaskModel> GetAll()
        {
            return Database.Connection?.Table<TaskModel>().ToList();
        }

        public TaskModel GetById(int id)
        {
            return Database.Connection?.Table<TaskModel>().FirstOrDefault(x => x.Id == id);
        }

        public void Update(TaskModel task)
        {
            Database.Connection?.Update(task);
        }
    }
}
