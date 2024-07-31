using AppTask_ToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTask_ToDoList.Repositories
{
    interface ITaskModelRepository 
    {
        void Add(TaskModel task);
        void Delete(TaskModel task);
        IList<TaskModel> GetAll();
        TaskModel GetById(int id);
        void Update(TaskModel task);
    }
}
