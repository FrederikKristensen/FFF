using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EventRest.Models;

namespace EventRest.Controllers
{
    // Her laver vi Controlleren til API'en
    public class EventtabsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Eventtabs
        public IQueryable<Eventtab> GetEventtab()
        {
            return db.Eventtab;
        }

        // GET: api/Eventtabs/5
        [ResponseType(typeof(Eventtab))]
        public IHttpActionResult GetEventtab(int id)
        {
            Eventtab eventtab = db.Eventtab.Find(id);
            if (eventtab == null)
            {
                return NotFound();
            }

            return Ok(eventtab);
        }

        // PUT: api/Eventtabs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEventtab(int id, Eventtab eventtab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventtab.EventId)
            {
                return BadRequest();
            }

            db.Entry(eventtab).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventtabExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Eventtabs
        [ResponseType(typeof(Eventtab))]
        public IHttpActionResult PostEventtab(Eventtab eventtab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Eventtab.Add(eventtab);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eventtab.EventId }, eventtab);
        }

        // DELETE: api/Eventtabs/5
        [ResponseType(typeof(Eventtab))]
        public IHttpActionResult DeleteEventtab(int id)
        {
            Eventtab eventtab = db.Eventtab.Find(id);
            if (eventtab == null)
            {
                return NotFound();
            }

            db.Eventtab.Remove(eventtab);
            db.SaveChanges();

            return Ok(eventtab);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventtabExists(int id)
        {
            return db.Eventtab.Count(e => e.EventId == id) > 0;
        }
    }
}