using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using session.Models;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        private Boolean checkLogin()
        {
            if (HttpContext.Session.Contents["isLogued"] == null || HttpContext.Session.Contents["isLogued"].ToString() == "false")
            {
                HttpContext.Session.Add("isLogued", false);
                return false;
            }
            return true;
        }
        public ActionResult Index()
        {
            this.checkLogin();
            return View();
        }

        public ActionResult Login()
        {   
            /*if (this.checkLogin() == true)
            {
                Response.Redirect("/Home");
            }*/
            return View();
        }

        public void Logout()
        {
            HttpContext.Session.Add("isLogued", false);
            Response.Redirect("/Home/Login");
        }

        [HttpPost]
        public void DoLogin(Credentials credentials)
        {
            if (credentials.User == "test" && credentials.Password == "test")
            {
                HttpContext.Session.Add("isLogued", true);
                Response.Redirect("/Home");
            }
            Response.Redirect("/Home/Login");
        }
    }
}