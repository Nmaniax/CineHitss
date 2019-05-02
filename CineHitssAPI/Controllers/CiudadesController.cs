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
    public class CiudadesController : ApiController
    {
        private CineHitssEntities db = new CineHitssEntities();

        // GET: Ciudades
        public IHttpActionResult Index()
        {
            return Ok(db.Ciudads.ToList());
        }

        // GET: Ciudades/Details/5
        public IHttpActionResult Details(int? id)
        {
            if (id == null)
            {
                return Conflict();
            }
            Ciudad ciudad = db.Ciudads.Find(id);
            if (ciudad == null)
            {
                return NotFound();
            }
            return Ok(ciudad);
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
