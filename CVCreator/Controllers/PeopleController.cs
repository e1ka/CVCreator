using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CVCreator.DAL;
using CVCreator.Models;
using System.Web.Routing;

namespace CVCreator.Controllers
{
    public class PeopleController : Controller
    {
        private CVCreatorDbContext db = new CVCreatorDbContext();
        
        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }
        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        public ActionResult Create()
        {
            Person p = new Person();
            return View(p);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }
        [HttpPost]
        public ActionResult _Language()
        {
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult _Education()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult _Certification()
        {
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult _Skill()
        {
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult _Experience()
        {
            return PartialView();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.Persons.Find(id);
            db.Persons.Remove(person);
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
