using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Eden the Queen";
            return View();
        }

        public ActionResult MoviesList()
        {

            string[] arrayOfName = new string[] { "Eden", "Shay", "Daniel", "Oshra", "Bob", "Avner" };

            ViewBag.ListOfMovie = arrayOfName;

            return View();
        }
    }
}