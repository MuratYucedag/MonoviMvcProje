using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonoviMvcProje.Models.Entity;
namespace MonoviMvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbMonoviEntities db = new DbMonoviEntities();

        public ActionResult Index()
        {
            var categorylist = db.TblCategory.ToList();
            return View(categorylist);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory t)
        {
            db.TblCategory.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var cat = db.TblCategory.Find(id);
            db.TblCategory.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCategory(int id)
        {
            var cat = db.TblCategory.Find(id);
            return View("GetCategory", cat);
        }
        public ActionResult UpdateCategory(TblCategory t)
        {
            var c = db.TblCategory.Find(t.CategoryID);
            c.CategoryName = t.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}