using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public ActionResult Index()
        {
            List<Task> tasks = new List<Task>
            {
                new Task() {Name = "Kate", Description = "Take a nap", IsFinished = false},
                new Task() {Name = "Kate", Description = "cry", IsFinished = true},
                new Task() {Name = "Kate", Description = "Get a job", IsFinished = false},
            };
            return View(tasks);
        }


        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            // TODO: Add insert logic here

            return RedirectToAction("Index");

        }
    }
}
