using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class HomeController : Controller
    {
        private Person person { get; set; }
        private Transcript transcript { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Transcript Page.";
            person = new Person(2, "Tran", "Elvis", 22, "");
            transcript = new Transcript(person);
            transcript.Grades.Add(new Grade("BTD310", "A"));
            transcript.Grades.Add(new Grade("BTP400", "A"));
            transcript.Grades.Add(new Grade("BTI210", "C"));
            return View(transcript);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            person = new Person(1, "Tran", "Elvis", 22, "Content/images/headshot.jpg");
            return View(person);
        }
    }
}
