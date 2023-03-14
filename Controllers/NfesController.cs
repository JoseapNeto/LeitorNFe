using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppLeitorNfe.Models;

namespace AppLeitorNfe.Controllers
{
    public class NfesController : Controller
    {
        private LeitorNfeContext3 db = new LeitorNfeContext3();

        
        public ActionResult Index()
        {
            var nfes = db.Nfes.Include(n => n.Destinatario).Include(n => n.Emitente).Include(n => n.Icms);
            return View(nfes.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nfe nfe = db.Nfes.Find(id);
            if (nfe == null)
            {
                return HttpNotFound();
            }
            return View(nfe);
        }

        
        public ActionResult Create()
        {
            ViewBag.DestinatarioId = new SelectList(db.Destinatarios, "id", "xNome");
            ViewBag.EmitenteId = new SelectList(db.Emitentes, "id", "id");
            ViewBag.IcmsId = new SelectList(db.Icms, "id", "vNF");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nNF,chNFe,dhEmi,EmitenteId,DestinatarioId,IcmsId")] Nfe nfe)
        {
            if (ModelState.IsValid)
            {
                db.Nfes.Add(nfe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestinatarioId = new SelectList(db.Destinatarios, "id", "xNome", nfe.DestinatarioId);
            ViewBag.EmitenteId = new SelectList(db.Emitentes, "id", "id", nfe.EmitenteId);
            ViewBag.IcmsId = new SelectList(db.Icms, "id", "vNF", nfe.IcmsId);
            return View(nfe);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nfe nfe = db.Nfes.Find(id);
            if (nfe == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestinatarioId = new SelectList(db.Destinatarios, "id", "xNome", nfe.DestinatarioId);
            ViewBag.EmitenteId = new SelectList(db.Emitentes, "id", "id", nfe.EmitenteId);
            ViewBag.IcmsId = new SelectList(db.Icms, "id", "vNF", nfe.IcmsId);
            return View(nfe);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nNF,chNFe,dhEmi,EmitenteId,DestinatarioId,IcmsId")] Nfe nfe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nfe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestinatarioId = new SelectList(db.Destinatarios, "id", "xNome", nfe.DestinatarioId);
            ViewBag.EmitenteId = new SelectList(db.Emitentes, "id", "id", nfe.EmitenteId);
            ViewBag.IcmsId = new SelectList(db.Icms, "id", "vNF", nfe.IcmsId);
            return View(nfe);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nfe nfe = db.Nfes.Find(id);
            if (nfe == null)
            {
                return HttpNotFound();
            }
            return View(nfe);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nfe nfe = db.Nfes.Find(id);
            db.Nfes.Remove(nfe);
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
