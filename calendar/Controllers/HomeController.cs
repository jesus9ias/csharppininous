using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using calendar.Models;

namespace calendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(CurrentDateVM data)
        {
            CalendarCreator Calendar = new CalendarCreator(data);
            BigCalendar myCalendar = new BigCalendar
            {
                calendar = Calendar.create()
            };
            return View(myCalendar);
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