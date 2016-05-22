using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBailieCubeApp.Models;

namespace MVCBailieCubeApp.Controllers
{
    public class CubeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cube
        public ActionResult Index()
        {
            return View(db.Cubes.ToList());
        }

        // GET: Cube/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = db.Cubes.Find(id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        // GET: Cube/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cube/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CubeID,CubeTitle,UserID")] Cube cube)
        {
            if (ModelState.IsValid)
            {
                db.Cubes.Add(cube);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cube);
        }

        // GET: Cube/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = db.Cubes.Find(id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        // POST: Cube/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CubeID,CubeTitle,UserID")] Cube cube)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cube).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cube);
        }

        // GET: Cube/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = db.Cubes.Find(id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        // POST: Cube/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cube cube = db.Cubes.Find(id);
            db.Cubes.Remove(cube);
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
