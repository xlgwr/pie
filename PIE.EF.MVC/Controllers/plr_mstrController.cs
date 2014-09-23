using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PIE.EF.Model.Dal;

namespace PIE.MVC.EF.Controllers
{
    public class plr_mstrController : Controller
    {
        private PIEEntities db = new PIEEntities();

        // GET: plr_mstr
        public ActionResult Index()
        {
            var plr_mstr = db.plr_mstr.Include(p => p.plr_batch_mstr);
            return View(plr_mstr.ToList());
        }

        // GET: plr_mstr/Details/5
        public ActionResult Details(string Batch_ID, int? LineID)
        {
            if (Batch_ID == null || LineID == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plr_mstr plr_mstr = db.plr_mstr.Find(Batch_ID, LineID);
            if (plr_mstr == null)
            {
                return HttpNotFound();
            }
            return View(plr_mstr);
        }

        // GET: plr_mstr/Create
        public ActionResult Create()
        {
            ViewBag.Batch_ID = new SelectList(db.plr_batch_mstr, "batch_id", "plr_suppliers_id");
            return View();
        }

        // POST: plr_mstr/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Batch_ID,LineID,plr_status,packingListID,InvoiceID,plr_pallet_no,CartonType,CartonID,plr_po,plr_co,plr_partno,plr_date_code,plr_vend_mfgr,Plr_vm_partno,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,plr_doc_type,re_mark,plr_suppliers_id,plr_site,plr_ttl,plr_um,plr_nw,plr_gw,plr_um_w,Plr_unitprice,plr_msm,plr_doc_no1,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2")] plr_mstr plr_mstr)
        {
            if (ModelState.IsValid)
            {
                db.plr_mstr.Add(plr_mstr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Batch_ID = new SelectList(db.plr_batch_mstr, "batch_id", "plr_suppliers_id", plr_mstr.Batch_ID);
            return View(plr_mstr);
        }

        // GET: plr_mstr/Edit/5
        public ActionResult Edit(string Batch_ID, int? LineID)
        {
            if (Batch_ID == null || LineID == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plr_mstr plr_mstr = db.plr_mstr.Find(Batch_ID, LineID);
            if (plr_mstr == null)
            {
                return HttpNotFound();
            }
            ViewBag.Batch_ID = new SelectList(db.plr_batch_mstr, "batch_id", "plr_suppliers_id", plr_mstr.Batch_ID);
            return View(plr_mstr);
        }

        // POST: plr_mstr/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Batch_ID,LineID,plr_status,packingListID,InvoiceID,plr_pallet_no,CartonType,CartonID,plr_po,plr_co,plr_partno,plr_date_code,plr_vend_mfgr,Plr_vm_partno,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,plr_doc_type,re_mark,plr_suppliers_id,plr_site,plr_ttl,plr_um,plr_nw,plr_gw,plr_um_w,Plr_unitprice,plr_msm,plr_doc_no1,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2")] plr_mstr plr_mstr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plr_mstr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Batch_ID = new SelectList(db.plr_batch_mstr, "batch_id", "plr_suppliers_id", plr_mstr.Batch_ID);
            return View(plr_mstr);
        }

        // GET: plr_mstr/Delete/5
        public ActionResult Delete(string Batch_ID, int? LineID)
        {
            if (Batch_ID == null || LineID == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            plr_mstr plr_mstr = db.plr_mstr.Find(Batch_ID, LineID);
            if (plr_mstr == null)
            {
                return HttpNotFound();
            }
            return View(plr_mstr);
        }

        // POST: plr_mstr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string Batch_ID, int? LineID)
        {
            plr_mstr plr_mstr = db.plr_mstr.Find(Batch_ID, LineID);
            db.plr_mstr.Remove(plr_mstr);
            db.SaveChanges();
            return RedirectToAction("Index");
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
