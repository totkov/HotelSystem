using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HotelSystem.Data;

namespace HotelSystem.Web.Controllers
{
    class HomeController : Controller
    {
        public ActionResult Index()
        {
            HotelSystemDbContext db = new HotelSystemDbContext();


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