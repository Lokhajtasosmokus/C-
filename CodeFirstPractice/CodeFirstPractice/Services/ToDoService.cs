using CodeFirstPractice.Models;
using CodeFirstPractice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Services
{
    public class ToDoService
    {
        private ToDoRepositories toDoDBRepositories;

        public ToDoService(ToDoRepositories toDoDBRepositories)
        {
            this.toDoDBRepositories = toDoDBRepositories;
        }

        public void AddToDo(ToDo todo)
        {
            toDoDBRepositories.Create(todo);
        }

        public List<ToDo> GetAllToDo()
        {
            return toDoDBRepositories.Read();
        }

        public void ModifyToDo(ToDo toDo)
        {
            toDoDBRepositories.Update(toDo);
        }

        public void RemoveToDo(ToDo toDo)
        {
            toDoDBRepositories.Delete(toDo);
        }
    }
}
