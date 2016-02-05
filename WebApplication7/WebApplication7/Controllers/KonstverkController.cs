using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class KonstverkController : Controller
    {
        KonstverkContext db = new KonstverkContext();

        public ActionResult Galleri()
        {
            return View(db.Konstverk.ToList());
        }


    }
}