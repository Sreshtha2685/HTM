using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTM.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Country()
        {
            return View();
        }
        public ActionResult State()
        {
            return View();
        }
        public ActionResult City()
        {
            return View();
        }

        public ActionResult Reception()
        {
            return View();
        }
    }
}