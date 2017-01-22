using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {

        public double Media()  // exercitiul 3 mvc curs 6
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum / list.Count;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloWorld() // exercitiul 4 mvc curs 6
        {
            return Content("Hello World!");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Ciuhan Ana-Maria"; // exercitiul 6 mvc course 5

            var model = new AboutModel(); // exercitiul 7 mvc course 5
            model.Message = "Hello";
            model.Author = "Ciuhan Ana Maria";
            

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}