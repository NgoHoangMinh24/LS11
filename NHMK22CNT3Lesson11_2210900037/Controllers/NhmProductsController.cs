using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NhmK22CNT3Lesson11_2210900037.Models;

namespace NhmK22CNT3Lesson11_2210900037.Controllers
{
    public class NhmProductsController : Controller
    {
        private NhmK22CNT3_Lesson11Entities db = new NhmK22CNT3_Lesson11Entities();

        // GET: NhmProducts
        public ActionResult NhmIndex()
        {
            var NhmProducts = db.NhmProducts.Include(l => l.NhmCategory);
            return View(NhmProducts.ToList());
        }

        // GET: NhmProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmProduct NhmProduct = db.NhmProducts.Find(id);
            if (NhmProduct == null)
            {
                return HttpNotFound();
            }
            return View(NhmProduct);
        }

        // GET: NhmProducts/Create
        public ActionResult Create()
        {
            ViewBag.NhmCateId = new SelectList(db.NhmCategories, "NhmId", "NhmCateName");
            return View();
        }

        // POST: NhmProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhmId2210900037,NhmProName,NhmQty,NhmPrice,NhmCateId,NhmActive")] NhmProduct NhmProduct)
        {
            if (ModelState.IsValid)
            {
                db.NhmProducts.Add(NhmProduct);
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }

            ViewBag.NhmCateId = new SelectList(db.NhmCategories, "NhmId", "NhmCateName", NhmProduct.NhmCateId);
            return View(NhmProduct);
        }

        // GET: NhmProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmProduct NhmProduct = db.NhmProducts.Find(id);
            if (NhmProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.NhmCateId = new SelectList(db.NhmCategories, "NhmId", "NhmCateName", NhmProduct.NhmCateId);
            return View(NhmProduct);
        }

        // POST: NhmProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhmId2210900037,NhmProName,NhmQty,NhmPrice,NhmCateId,NhmActive")] NhmProduct NhmProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(NhmProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }
            ViewBag.NhmCateId = new SelectList(db.NhmCategories, "NhmId", "NhmCateName", NhmProduct.NhmCateId);
            return View(NhmProduct);
        }

        // GET: NhmProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmProduct NhmProduct = db.NhmProducts.Find(id);
            if (NhmProduct == null)
            {
                return HttpNotFound();
            }
            return View(NhmProduct);
        }

        // POST: NhmProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhmProduct NhmProduct = db.NhmProducts.Find(id);
            db.NhmProducts.Remove(NhmProduct);
            db.SaveChanges();
            return RedirectToAction("NhmIndex");
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
