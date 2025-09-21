using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01c_BT1.Controllers
{
    public class th03Controller : Controller
    {
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
        public ActionResult Lab01c_BT1()
        {
            ViewBag.Message = "Your Lab01c_BT1 page.";
            return View();
        }
        public ActionResult repass()
        {
            ViewBag.Message = "Your repass page.";
            return View();
        }
        public ActionResult regist()
        {
                       ViewBag.Message = "Your regsit page.";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";
            return View();
        }
        public ActionResult home()
        {
            ViewBag.Message = "Your home page.";
            return View();
        }
    }
}