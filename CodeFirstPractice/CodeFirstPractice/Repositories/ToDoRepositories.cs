using CodeFirstPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Repositories
{
    public class ToDoRepositories
    {
        private ToDoContext toDoDBContext;

        public ToDoRepositories(ToDoContext toDoDBContext)
        {
            this.toDoDBContext = toDoDBContext;
        }

        //CRUD create read update delete

        public void Create(ToDo toDo)
        {
            toDoDBContext.Add(toDo);
            toDoDBContext.SaveChanges();
        }

        public List<ToDo> Read()
        {
            return toDoDBContext.ToDos.ToList();
        }

        public void Update(ToDo toDo)
        {
            toDoDBContext.Update(toDo);
            toDoDBContext.SaveChanges();
        }

        public void Delete(ToDo toDo)
        {
            toDoDBContext.Remove(toDo);
            toDoDBContext.SaveChanges();
        }
    }
}
