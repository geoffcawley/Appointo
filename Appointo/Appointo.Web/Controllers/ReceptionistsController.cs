//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Appointo.Entity;

//namespace Appointo.Web.Controllers
//{
//    public class ReceptionistsController : Controller
//    {
//        private DataEntityModelContainer db = new DataEntityModelContainer();

//        // GET: Receptionists
//        public ActionResult Index()
//        {
//            var receptionists = db.Receptionists.Include(r => r.Login);
//            return View(receptionists.ToList());
//        }

//        // GET: Receptionists/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Receptionist receptionist = db.Receptionists.Find(id);
//            if (receptionist == null)
//            {
//                return HttpNotFound();
//            }
//            return View(receptionist);
//        }

//        // GET: Receptionists/Create
//        public ActionResult Create()
//        {
//            ViewBag.LoginId = new SelectList(db.Logins, "Id", "LoginID");
//            return View();
//        }

//        // POST: Receptionists/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,LoginId,FirstName,LastName")] Receptionist receptionist)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Receptionists.Add(receptionist);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.LoginId = new SelectList(db.Logins, "Id", "LoginID", receptionist.LoginId);
//            return View(receptionist);
//        }

//        // GET: Receptionists/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Receptionist receptionist = db.Receptionists.Find(id);
//            if (receptionist == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.LoginId = new SelectList(db.Logins, "Id", "LoginID", receptionist.LoginId);
//            return View(receptionist);
//        }

//        // POST: Receptionists/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,LoginId,FirstName,LastName")] Receptionist receptionist)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(receptionist).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.LoginId = new SelectList(db.Logins, "Id", "LoginID", receptionist.LoginId);
//            return View(receptionist);
//        }

//        // GET: Receptionists/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Receptionist receptionist = db.Receptionists.Find(id);
//            if (receptionist == null)
//            {
//                return HttpNotFound();
//            }
//            return View(receptionist);
//        }

//        // POST: Receptionists/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Receptionist receptionist = db.Receptionists.Find(id);
//            db.Receptionists.Remove(receptionist);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
