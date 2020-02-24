using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RelationalDatabase.Models;

namespace RelationalDatabase.Controllers
{
    public class UncertaintyBudgetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UncertaintyBudgets
        public ActionResult Index()
        {
            return View(db.UncertaintyBudgets.ToList());
        }

        // GET: UncertaintyBudgets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UncertaintyBudget uncertaintyBudget = db.UncertaintyBudgets.Find(id);
            if (uncertaintyBudget == null)
            {
                return HttpNotFound();
            }
            return View(uncertaintyBudget);
        }

        // GET: UncertaintyBudgets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UncertaintyBudgets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdNumber,Name")] UncertaintyBudget uncertaintyBudget)
        {
            if (ModelState.IsValid)
            {
                db.UncertaintyBudgets.Add(uncertaintyBudget);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uncertaintyBudget);
        }

        // GET: UncertaintyBudgets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UncertaintyBudget uncertaintyBudget = db.UncertaintyBudgets.Find(id);
            if (uncertaintyBudget == null)
            {
                return HttpNotFound();
            }
            return View(uncertaintyBudget);
        }

        // POST: UncertaintyBudgets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNumber,Name")] UncertaintyBudget uncertaintyBudget)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uncertaintyBudget).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uncertaintyBudget);
        }

        // GET: UncertaintyBudgets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UncertaintyBudget uncertaintyBudget = db.UncertaintyBudgets.Find(id);
            if (uncertaintyBudget == null)
            {
                return HttpNotFound();
            }
            return View(uncertaintyBudget);
        }

        // POST: UncertaintyBudgets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UncertaintyBudget uncertaintyBudget = db.UncertaintyBudgets.Find(id);
            db.UncertaintyBudgets.Remove(uncertaintyBudget);
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
