using BankApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApplication.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //GET ../home/index
        //Abstract class ActionResult
        [Authorize]
        public ActionResult Index()
        {

            var userId = User.Identity.GetUserId();
            var checkingAccountId = db.CheckingAccs.Where(c => c.ApplicationUserId
            == userId).First().Id;
            ViewBag.CheckingAccountId = checkingAccountId;
            return View();
        }
        //GET ../home/about
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
        public ActionResult Foo()
        {
            return View("About");
        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase =="lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }

    }
}