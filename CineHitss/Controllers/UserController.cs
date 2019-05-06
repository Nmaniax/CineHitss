using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CineHitss.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario cuenta)
        {
            using (CineHitssEntities db = new CineHitssEntities())
            {
                try
                { 
                    var user = db.Usuarios.Single(u => u.Correo == cuenta.Correo &&
                                                  u.Contrasenia == cuenta.Contrasenia);
                    if (user != null)
                    {
                        Session["ID"] = user.ID.ToString();
                        Session["Nombre"] = user.Nombre.ToString();
                        return RedirectToAction("GetCiudades", "CineV", new { area = "" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Correo o Contraseña incorrectos");
                    }
                }
                catch(Exception)
                {

                }
            }
            return View();
        }

        public ActionResult LogOut(Usuario cuenta)
        {
            Session.Abandon();
            return RedirectToAction("GetCiudades", "CineV", new { area = "" });
        }
    }
}