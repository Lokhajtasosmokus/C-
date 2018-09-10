using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstPractice.Controllers
{
    public class ToDoController : Controller
    {
        private ToDoService ToDoService;

        public ToDoController(ToDoService ToDoService)
        {
            this.ToDoService = ToDoService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}