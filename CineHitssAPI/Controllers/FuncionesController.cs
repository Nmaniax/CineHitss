using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using CineHitssAPI;


namespace CineHitssAPI.Controllers
{
    public class FuncionesController : ApiController
    {
        private CineHitssEntities db = new CineHitssEntities();

        // GET: Funciones
        public IHttpActionResult Index()
        {
            var funcions = new List<Funcion>();
            funcions = db.Funcions.ToList();
            return Ok(funcions.ToList());
        }

        // GET: Funciones/Details/5
        public IHttpActionResult Details(int? id)
        {
            if (id == null)
            {
                return Conflict();
            }
            Funcion funcion = db.Funcions.Find(id);
            if (funcion == null)
            {
                return NotFound();
            }
            return Ok(funcion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
