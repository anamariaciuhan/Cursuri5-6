using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller // exercitiul 8 mvc curs 6
    {
        // GET: ActionResult
        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!");
        }

        public ActionResult RedirectPermanent()
        {
            return RedirectPermanent("http://www.google.com");
        }

        public ActionResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToActionInHomeController() // exercitiul 9 mvc curs 6
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "About" });
        }
      
        
           public ActionResult ReturnFile()
        {
            return File("~Content/Site.css", "text/css");
        }




    }
}