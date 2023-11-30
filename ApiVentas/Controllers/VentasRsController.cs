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
using ProyectoRopaDeportiva.Models;

namespace ApiVentas.Controllers
{
    public class VentasRsController : ApiController
    {
        private DesarrolloWebEntities db = new DesarrolloWebEntities();

        // GET: api/VentasRs
        public IQueryable<VentasR> GetVentasR()
        {
            return db.VentasR;
        }

        // GET: api/VentasRs/5
        [ResponseType(typeof(VentasR))]
        public IHttpActionResult GetVentasR(string id)
        {
            VentasR ventasR = db.VentasR.Find(id);
            if (ventasR == null)
            {
                return NotFound();
            }

            return Ok(ventasR);
        }

        // PUT: api/VentasRs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVentasR(string id, VentasR ventasR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ventasR.Ven_id)
            {
                return BadRequest();
            }

            db.Entry(ventasR).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentasRExists(id))
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

        // POST: api/VentasRs
        [ResponseType(typeof(VentasR))]
        public IHttpActionResult PostVentasR(VentasR ventasR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VentasR.Add(ventasR);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (VentasRExists(ventasR.Ven_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ventasR.Ven_id }, ventasR);
        }

        // DELETE: api/VentasRs/5
        [ResponseType(typeof(VentasR))]
        public IHttpActionResult DeleteVentasR(string id)
        {
            VentasR ventasR = db.VentasR.Find(id);
            if (ventasR == null)
            {
                return NotFound();
            }

            db.VentasR.Remove(ventasR);
            db.SaveChanges();

            return Ok(ventasR);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VentasRExists(string id)
        {
            return db.VentasR.Count(e => e.Ven_id == id) > 0;
        }
    }
}