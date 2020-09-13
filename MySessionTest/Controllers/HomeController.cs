using MySessionTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySessionTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // Session["Username"] = "Sam";
           // Session["UserId"] = 0123;

            Session["user"] = new User() { Name = "Dominic", Email = "domebingonye@gmail.com", Password = "12345678" };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Session.Clear();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}