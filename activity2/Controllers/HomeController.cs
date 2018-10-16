using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace activity2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Products p = new Models.Products();
            p.Product_Code = "SOFT549";
            p.Product_Name = "Book";

            using (var db = new Models.ProductDB())
            {
                db.products.Add(p);
                db.SaveChanges();

                ViewBag.Message = "The number of products so far is " + db.products.Count().ToString();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}