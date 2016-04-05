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
                new Task() {OwnerName = "Kate", Description = "Take a nap", IsFinished = false},
                new Task() {OwnerName = "Kate", Description = "cry", IsFinished = true},
                new Task() {OwnerName = "Kate", Description = "Get a job", IsFinished = false},
            };
            if (Session["tasks"] == null)
            {
                Session["tasks"] = new List<Task>(tasks);
            }
            var SessionTasks = (List<Task>)Session["tasks"];

            return View(SessionTasks);
        }


        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        public ActionResult Create(Task task)
        {
            if (Session["tasks"] == null)
            {
                Session["tasks"] = new List<Task>();
            }
            if (ModelState.IsValid)
            {
                var Tasks = (List<Task>)Session["tasks"];
                Tasks.Add(task);
                Session["tasks"] = Tasks;
            }

            return RedirectToAction("Index");
        }
    }
}
