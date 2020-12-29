using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonoviMvcProje.Models.Entity;
namespace MonoviMvcProje.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        DbMonoviEntities db = new DbMonoviEntities();
        public ActionResult Index()
        {
            var productlist = db.TblProduct.ToList();
            return View(productlist);
        }
    }
}