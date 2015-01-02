using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using IDR.API.Models;
using IDR.EF.PIE;

namespace IDR.API.Controllers
{
    public class RoleController : ApiController
    {
        private PIEServiceContext db = new PIEServiceContext();

        // GET: api/Role
        public IQueryable<sys_role> Getsys_role()
        {
            return db.sys_role;
        }

        // GET: api/Role/5
        [ResponseType(typeof(sys_role))]
        public async Task<IHttpActionResult> Getsys_role(int id)
        {
            sys_role sys_role = await db.sys_role.FindAsync(id);
            if (sys_role == null)
            {
                return NotFound();
            }

            return Ok(sys_role);
        }

        // PUT: api/Role/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putsys_role(int id, sys_role sys_role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sys_role.role_id)
            {
                return BadRequest();
            }

            db.Entry(sys_role).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sys_roleExists(id))
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

        // POST: api/Role
        [ResponseType(typeof(sys_role))]
        public async Task<IHttpActionResult> Postsys_role(sys_role sys_role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sys_role.Add(sys_role);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (sys_roleExists(sys_role.role_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sys_role.role_id }, sys_role);
        }

        // DELETE: api/Role/5
        [ResponseType(typeof(sys_role))]
        public async Task<IHttpActionResult> Deletesys_role(int id)
        {
            sys_role sys_role = await db.sys_role.FindAsync(id);
            if (sys_role == null)
            {
                return NotFound();
            }

            db.sys_role.Remove(sys_role);
            await db.SaveChangesAsync();

            return Ok(sys_role);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sys_roleExists(int id)
        {
            return db.sys_role.Count(e => e.role_id == id) > 0;
        }
    }
}