using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Datamodel;

namespace WebApplication1.Controllers
{
    public class LicenciasController : Controller
    {
        private taxareEntities db = new taxareEntities();

        // GET: Licencias
        public ActionResult Index()
        {
            var licencias = db.Licencias.Include(l => l.Conductor).Include(l => l.Secretarias_transito);
            return View(licencias.ToList());
        }

        // GET: Licencias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencias.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            return View(licencia);
        }

        // GET: Licencias/Create
        public ActionResult Create()
        {
            ViewBag.id_conductor = new SelectList(db.Conductors, "id", "cedula");
            ViewBag.id_secretaria = new SelectList(db.Secretarias_transito, "id", "localidad");
            return View();
        }

        // POST: Licencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Numero_pase,id_conductor,id_secretaria,categoria,expedicon,vencimiento")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                db.Licencias.Add(licencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_conductor = new SelectList(db.Conductors, "id", "cedula", licencia.id_conductor);
            ViewBag.id_secretaria = new SelectList(db.Secretarias_transito, "id", "localidad", licencia.id_secretaria);
            return View(licencia);
        }

        // GET: Licencias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencias.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_conductor = new SelectList(db.Conductors, "id", "cedula", licencia.id_conductor);
            ViewBag.id_secretaria = new SelectList(db.Secretarias_transito, "id", "localidad", licencia.id_secretaria);
            return View(licencia);
        }

        // POST: Licencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Numero_pase,id_conductor,id_secretaria,categoria,expedicon,vencimiento")] Licencia licencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(licencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_conductor = new SelectList(db.Conductors, "id", "cedula", licencia.id_conductor);
            ViewBag.id_secretaria = new SelectList(db.Secretarias_transito, "id", "localidad", licencia.id_secretaria);
            return View(licencia);
        }

        // GET: Licencias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Licencia licencia = db.Licencias.Find(id);
            if (licencia == null)
            {
                return HttpNotFound();
            }
            return View(licencia);
        }

        // POST: Licencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Licencia licencia = db.Licencias.Find(id);
            db.Licencias.Remove(licencia);
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
