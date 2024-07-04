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
    public class NhmCategoriesController : Controller
    {
        private NhmK22CNT3_Lesson11Entities db = new NhmK22CNT3_Lesson11Entities();

        // GET: NhmCategories
        public ActionResult NhmIndex()
        {
            return View(db.NhmCategories.ToList());
        }

        // GET: NhmCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmCategory NhmCategory = db.NhmCategories.Find(id);
            if (NhmCategory == null)
            {
                return HttpNotFound();
            }
            return View(NhmCategory);
        }

        // GET: NhmCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhmCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhmId,NhmCateName,NhmStatus")] NhmCategory NhmCategory)
        {
            if (ModelState.IsValid)
            {
                db.NhmCategories.Add(NhmCategory);
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }

            return View(NhmCategory);
        }

        // GET: NhmCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmCategory NhmCategory = db.NhmCategories.Find(id);
            if (NhmCategory == null)
            {
                return HttpNotFound();
            }
            return View(NhmCategory);
        }

        // POST: NhmCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhmId,NhmCateName,NhmStatus")] NhmCategory NhmCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(NhmCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }
            return View(NhmCategory);
        }

        // GET: NhmCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmCategory NhmCategory = db.NhmCategories.Find(id);
            if (NhmCategory == null)
            {
                return HttpNotFound();
            }
            return View(NhmCategory);
        }

        // POST: NhmCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhmCategory NhmCategory = db.NhmCategories.Find(id);
            db.NhmCategories.Remove(NhmCategory);
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
