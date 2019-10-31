using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBEApp.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult AddEditTitles()
        {            
            return View();
        }
    }
}