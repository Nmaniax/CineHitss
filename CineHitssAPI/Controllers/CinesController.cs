using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using CineHitssAPI;

namespace CineHitssAPI.Controllers
{
    public class CinesController : ApiController
    {
        private CineHitssEntities db = new CineHitssEntities();

        // GET: Cines
        public IHttpActionResult Index()
        {
            List<Cine> cines = new List<Cine>();
            cines = db.Cines.ToList();
            return Ok(cines);
        }

        // GET: Cines/Details/5
        public IHttpActionResult Details(int? id)
        {
            if (id == null)
            {
                return Conflict();
            }
            Cine cine = db.Cines.Find(id);
            if (cine == null)
            {
                return NotFound();
            }
            return Ok(cine);
        }

        // GET: Cines/Details/5
        public IHttpActionResult GetByCiudad(int id)
        {
            var cine = db.Cines.Include(c => c.Ciudad_ID == id);
            if (cine == null)
            {
                return NotFound();
            }
            return Ok(cine.ToList());
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
