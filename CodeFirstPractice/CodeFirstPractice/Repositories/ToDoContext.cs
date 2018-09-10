using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Repositories
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
    }
}
