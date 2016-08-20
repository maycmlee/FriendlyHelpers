using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FriendlyHelpers;

namespace FriendlyHelpersUI.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {

            var tasks = FriendlyHelper.GetAllTasksByUserEmail("may@may.com");
            return View(tasks);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            
            //Need to revise addTask method
            FriendlyHelper.addTask(task.Category, task.TaskName, task.TaskDescription);
            return RedirectToAction("Index");
        }
    }
}