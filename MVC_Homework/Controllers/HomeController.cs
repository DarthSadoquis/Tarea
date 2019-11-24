namespace MVC_Homework.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    public class HomeController : Controller
    {
        private static int actual = 0;
        private static int pass = 0;
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(ThreeNumbers model)
        {
            pass = actual;
            actual = model.RandomNumber;
            
            var text = actual > pass ? "mayor" : "menor";
            ViewBag.Text = "El número actual es " + text;
            ViewBag.Last = pass;
            ViewBag.Random = actual;
            return View(model);
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