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
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private PIEServiceContext db = new PIEServiceContext();

        // GET: api/User
        public IQueryable<sys_user> Getsys_user()
        {
            return db.sys_user;
        }

        // GET: api/User/5
        //Keys?name=admin&comp=WWTS
        [ResponseType(typeof(sys_user))]
        [Route("Keys")]
        public async Task<IHttpActionResult> Getsys_user(string name,string comp)
        {
            sys_user sys_user = await db.sys_user.FindAsync(name,comp);
            if (sys_user == null)
            {
                return NotFound();
            }

            return Ok(sys_user);
        }

        // PUT: api/User/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putsys_user(string id, sys_user sys_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sys_user.user_name)
            {
                return BadRequest();
            }

            db.Entry(sys_user).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sys_userExists(id))
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

        // POST: api/User
        [ResponseType(typeof(sys_user))]
        public async Task<IHttpActionResult> Postsys_user(sys_user sys_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sys_user.Add(sys_user);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (sys_userExists(sys_user.user_name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sys_user.user_name }, sys_user);
        }

        // DELETE: api/User/5
        [ResponseType(typeof(sys_user))]
        public async Task<IHttpActionResult> Deletesys_user(string id)
        {
            sys_user sys_user = await db.sys_user.FindAsync(id);
            if (sys_user == null)
            {
                return NotFound();
            }

            db.sys_user.Remove(sys_user);
            await db.SaveChangesAsync();

            return Ok(sys_user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sys_userExists(string id)
        {
            return db.sys_user.Count(e => e.user_name == id) > 0;
        }
    }
}