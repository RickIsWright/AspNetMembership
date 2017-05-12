using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspNetMembership.Controllers
{
    
    public class SecureController : Controller
    {
        [Authorize(Roles = "SuperDuperUsers")]
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult List()
        {
            return View();
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Roles.CreateRole("SuperDuperUsers");
            Roles.AddUserToRole("<WindowsUserName>", "SuperDuperUsers");
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