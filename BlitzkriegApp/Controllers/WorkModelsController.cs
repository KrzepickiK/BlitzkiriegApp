using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BlitzkriegApp.DAL;
using BlitzkriegApp.Models;

namespace BlitzkriegApp.Controllers
{
    public class WorkModelsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: WorkModels
        public ActionResult Index()
        {
            return View(db.Work.ToList());
        }

        // GET: WorkModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkModels workModel = db.Work.Find(id);
            if (workModel == null)
            {
                return HttpNotFound();
            }
            return View(workModel);
        }

        // GET: WorkModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Details,Date,IsDone")] WorkModels workModel)
        {
            if (ModelState.IsValid)
            {
                db.Work.Add(workModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workModel);
        }

        // GET: WorkModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkModels workModel = db.Work.Find(id);
            if (workModel == null)
            {
                return HttpNotFound();
            }
            return View(workModel);
        }

        // POST: WorkModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Details,Date,IsDone")] WorkModels workModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workModel);
        }

        // GET: WorkModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkModels workModel = db.Work.Find(id);
            if (workModel == null)
            {
                return HttpNotFound();
            }
            return View(workModel);
        }

        // POST: WorkModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkModels workModel = db.Work.Find(id);
            db.Work.Remove(workModel);
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
