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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Ciuhan Ana-Maria"; // exercitiul 6 mvc course 5

            var model = new AboutModel(); // exercitiul 7 mvc course 5
            model.Message = "Hello";
            model.Author = "Ciuhan Ana Maria";
            return View(model);

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}