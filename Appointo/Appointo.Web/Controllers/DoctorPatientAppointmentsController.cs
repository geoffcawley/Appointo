using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Appointo.Entity;

namespace Appointo.Web.Controllers
{
    public class DoctorPatientAppointmentsController : Controller
    {
        private DataEntityModelContainer db = new DataEntityModelContainer();

        // GET: DoctorPatientAppointments
        public ActionResult Index()
        {
            var doctorPatientAppointments = db.DoctorPatientAppointments.Include(d => d.Doctor).Include(d => d.Patient).Include(d => d.Appointment);
            return View(doctorPatientAppointments.ToList());
        }

        // GET: DoctorPatientAppointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorPatientAppointment doctorPatientAppointment = db.DoctorPatientAppointments.Find(id);
            if (doctorPatientAppointment == null)
            {
                return HttpNotFound();
            }
            return View(doctorPatientAppointment);
        }

        // GET: DoctorPatientAppointments/Create
        public ActionResult Create()
        {
            ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName");
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "FirstName");
            ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Reason");
            return View();
        }

        // POST: DoctorPatientAppointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DoctorId,PatientId,AppointmentId")] DoctorPatientAppointment doctorPatientAppointment)
        {
            if (ModelState.IsValid)
            {
                db.DoctorPatientAppointments.Add(doctorPatientAppointment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName", doctorPatientAppointment.DoctorId);
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "FirstName", doctorPatientAppointment.PatientId);
            ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Reason", doctorPatientAppointment.AppointmentId);
            return View(doctorPatientAppointment);
        }

        // GET: DoctorPatientAppointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorPatientAppointment doctorPatientAppointment = db.DoctorPatientAppointments.Find(id);
            if (doctorPatientAppointment == null)
            {
                return HttpNotFound();
            }
            ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName", doctorPatientAppointment.DoctorId);
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "FirstName", doctorPatientAppointment.PatientId);
            ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Reason", doctorPatientAppointment.AppointmentId);
            return View(doctorPatientAppointment);
        }

        // POST: DoctorPatientAppointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DoctorId,PatientId,AppointmentId")] DoctorPatientAppointment doctorPatientAppointment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorPatientAppointment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DoctorId = new SelectList(db.Doctors, "Id", "FirstName", doctorPatientAppointment.DoctorId);
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "FirstName", doctorPatientAppointment.PatientId);
            ViewBag.AppointmentId = new SelectList(db.Appointments, "Id", "Reason", doctorPatientAppointment.AppointmentId);
            return View(doctorPatientAppointment);
        }

        // GET: DoctorPatientAppointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorPatientAppointment doctorPatientAppointment = db.DoctorPatientAppointments.Find(id);
            if (doctorPatientAppointment == null)
            {
                return HttpNotFound();
            }
            return View(doctorPatientAppointment);
        }

        // POST: DoctorPatientAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorPatientAppointment doctorPatientAppointment = db.DoctorPatientAppointments.Find(id);
            db.DoctorPatientAppointments.Remove(doctorPatientAppointment);
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
