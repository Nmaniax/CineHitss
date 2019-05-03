using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CineHitss.Controllers
{
    public class CineVController : Controller
    {
        public ActionResult IntroView()
        {
            return View();
        }

        public ActionResult GetCiudades()
        {
            CineHitssEntities db = new CineHitssEntities();
            var ciudades = db.Ciudads.ToList();
            ViewBag.Cities = ciudades;
            return View("IntroView");
        }

    }
}