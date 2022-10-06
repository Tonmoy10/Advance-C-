using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation_Assignment.Models;

namespace Validation_Assignment.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Info",user);
            }
            return View(user);
        }

        public ActionResult Info(User user)
        {
            return View(user);
        }
    }
}