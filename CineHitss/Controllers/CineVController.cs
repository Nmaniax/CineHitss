using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CineHitss.Models;

namespace CineHitss.Controllers
{
    public class CineVController : Controller
    {
        CineHitssEntities db = new CineHitssEntities();
        
        public ActionResult GetCiudades()
        {
            var ciudades = db.Ciudads.ToList();
           
            return View(ciudades);
        }
        
        
    }
}