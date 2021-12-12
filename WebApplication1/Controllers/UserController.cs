using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowUserName()
        {
            ViewBag.UserName = "Eden";
            return View();
        }

        public ActionResult ShowUsersInfo()
        {
            ViewBag.userObj.firstN = "EDEN GENET";
            ViewBag.userObj.lastN = "TASAMA";
            ViewBag.userObj.age = 25;

            return View();

        }

        public ActionResult ShowAllUserNames()
        {
            string[] arrayOfNames = new string[] { "Eden", "Shay", "Daniel", "Oshra", "Bob", "Avner" } ;
            ViewBag.arrayOfNames = arrayOfNames;
            return View();
        }

        public ActionResult ShowAllUsersInfo()
        {
            return View();
        }
    }
}