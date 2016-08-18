using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Xml.Linq;

namespace Hellothere.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Details()
        {
            Customer customer = new Customer()
            {
                ID = 1,
                Name = "Kutty"
            };

            ViewBag.Title = "Details";
            ViewBag.Customer = customer;

            return View();
        }
    }
}
