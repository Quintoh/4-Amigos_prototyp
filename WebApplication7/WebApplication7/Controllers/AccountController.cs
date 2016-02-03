using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tavlor4Life.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }

        public ActionResult AddAndEdit()
        {
            return View();
        }
    }
}