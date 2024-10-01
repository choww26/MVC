using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace CM6.Controllers
{
    public class HomeController : Controller
    {
        public string Report(string Notice)
        {
            dynamic stuff = JObject.Parse(Notice);
            string Temp1 = stuff.ChineseName + "致死率高，請前線醫護人員小心。";
            string Temp2 = stuff.EnglishName + " is Terrible, plese be careful!";
            return ("收到:"+ Notice);
        }
        public ActionResult Index()
        {
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