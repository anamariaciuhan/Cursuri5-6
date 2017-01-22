using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {

        public ActionResult DoAnAction()  /// exercitiul 2 mvc curs 6
        {

            return Content("Hello World!");
        }


        public ActionResult search(string alpha) // exercitiul 5 mvc curs 6
        {
            var encoded_alpha = Server.HtmlEncode(alpha);
            if (encoded_alpha == null)
            {
                return Content("Your parameter is null");
            }
            else if (encoded_alpha.Length <= 5)
            {
                return Content("Your parameter length is smaller or equal with 5.");
            }
            else
            {
                return Content("Your parameter length is bigger than 5.");
            }
        }

        public ActionResult hellouser(string alpha) // exercitiul 6 + exercitiul 7 mvc curs 6 
        {
            var encoded_alpha = Server.HtmlEncode(alpha);
            return Content("Hello " + encoded_alpha);
        }


    }
}

