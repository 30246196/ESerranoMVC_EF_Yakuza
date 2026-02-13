using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ESerranoMVC_EF_Yakuza.Models;

namespace ESerranoMVC_EF_Yakuza.Controllers
{
    public class Yakuza_HierarchyController : Controller
    {
        private YakuzaContext db = new YakuzaContext();

        // GET: Yakuza_Hierarchy
        public ActionResult Index()
        {
            var yakuzaHierarchies = db.YakuzaHierarchies.Include(y => y.Parent).Include(y => y.Yakuza);
            return View(yakuzaHierarchies.ToList());
        }

        // GET: Yakuza_Hierarchy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Create
        public ActionResult Create()
        {
            ViewBag.Parent_Entry_ID = new SelectList(db.YakuzaHierarchies, "Entry_ID", "English_Entry_Name");
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin");
            return View();
        }

        // POST: Yakuza_Hierarchy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Entry_ID,Parent_Entry_ID,Yakuza_ID,Level_Number,English_Entry_Name,Japanese_Entry_Name")] Yakuza_Hierarchy yakuza_Hierarchy)
        {
            if (ModelState.IsValid)
            {
                db.YakuzaHierarchies.Add(yakuza_Hierarchy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Parent_Entry_ID = new SelectList(db.YakuzaHierarchies, "Entry_ID", "English_Entry_Name", yakuza_Hierarchy.Parent_Entry_ID);
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", yakuza_Hierarchy.Yakuza_ID);
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            ViewBag.Parent_Entry_ID = new SelectList(db.YakuzaHierarchies, "Entry_ID", "English_Entry_Name", yakuza_Hierarchy.Parent_Entry_ID);
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", yakuza_Hierarchy.Yakuza_ID);
            return View(yakuza_Hierarchy);
        }

        // POST: Yakuza_Hierarchy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Entry_ID,Parent_Entry_ID,Yakuza_ID,Level_Number,English_Entry_Name,Japanese_Entry_Name")] Yakuza_Hierarchy yakuza_Hierarchy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yakuza_Hierarchy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Parent_Entry_ID = new SelectList(db.YakuzaHierarchies, "Entry_ID", "English_Entry_Name", yakuza_Hierarchy.Parent_Entry_ID);
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", yakuza_Hierarchy.Yakuza_ID);
            return View(yakuza_Hierarchy);
        }

        // GET: Yakuza_Hierarchy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            if (yakuza_Hierarchy == null)
            {
                return HttpNotFound();
            }
            return View(yakuza_Hierarchy);
        }

        // POST: Yakuza_Hierarchy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yakuza_Hierarchy yakuza_Hierarchy = db.YakuzaHierarchies.Find(id);
            db.YakuzaHierarchies.Remove(yakuza_Hierarchy);
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
