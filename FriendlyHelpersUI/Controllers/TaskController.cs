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

            FriendlyHelper.GetAllTasksByUserEmail(may@may.com);
            return View();
        }
    }
}