using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using October_6.Models;
using October_6.Controllers;
using System.Web.Mvc.Html;

namespace October_6.Controllers
{
    public class ProductsController : Controller
    {
        static List<Productmodel> products = new List<Productmodel>();
        static ProductsController()
        {
            products.Add(new Productmodel { Proid = 1, Proname = "tea", Qty = 10 , Mfgdate = new DateTime(2021, 10, 13) });
            products.Add(new Productmodel { Proid = 2, Proname = "Coffee", Qty = 20 , Mfgdate = new DateTime(2020, 2, 3) });
            products.Add(new Productmodel { Proid = 3, Proname = "Milk", Qty = 15, Mfgdate = new DateTime(2020, 5, 3) });


        }
        // GET: Products
        public ActionResult Index()
        {
            return View(products);
        }


        public ActionResult Details(int id)
        {
            Productmodel foundData = products.Find(product => product.Proid == id);
            return View(foundData);
        }
        
    }
}