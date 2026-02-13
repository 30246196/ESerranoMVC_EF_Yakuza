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
    public class Principal_ClanController : Controller
    {
        private YakuzaContext db = new YakuzaContext();

        // GET: Principal_Clan
        public ActionResult Index()
        {
            var principalClans = db.PrincipalClans.Include(p => p.Yakuza);
            return View(principalClans.ToList());
        }

        // GET: Principal_Clan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Principal_Clan principal_Clan = db.PrincipalClans.Find(id);
            if (principal_Clan == null)
            {
                return HttpNotFound();
            }
            return View(principal_Clan);
        }

        // GET: Principal_Clan/Create
        public ActionResult Create()
        {
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin");
            return View();
        }

        // POST: Principal_Clan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clan_Number,Yakuza_ID,Clan_Name,Founding_Location,Years_Active,Territory,Ethnicity,Membership,Criminal_Activities")] Principal_Clan principal_Clan)
        {
            if (ModelState.IsValid)
            {
                db.PrincipalClans.Add(principal_Clan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", principal_Clan.Yakuza_ID);
            return View(principal_Clan);
        }

        // GET: Principal_Clan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Principal_Clan principal_Clan = db.PrincipalClans.Find(id);
            if (principal_Clan == null)
            {
                return HttpNotFound();
            }
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", principal_Clan.Yakuza_ID);
            return View(principal_Clan);
        }

        // POST: Principal_Clan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Clan_Number,Yakuza_ID,Clan_Name,Founding_Location,Years_Active,Territory,Ethnicity,Membership,Criminal_Activities")] Principal_Clan principal_Clan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(principal_Clan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Yakuza_ID = new SelectList(db.Yakuza, "Yakuza_ID", "Origin", principal_Clan.Yakuza_ID);
            return View(principal_Clan);
        }

        // GET: Principal_Clan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Principal_Clan principal_Clan = db.PrincipalClans.Find(id);
            if (principal_Clan == null)
            {
                return HttpNotFound();
            }
            return View(principal_Clan);
        }

        // POST: Principal_Clan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Principal_Clan principal_Clan = db.PrincipalClans.Find(id);
            db.PrincipalClans.Remove(principal_Clan);
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
