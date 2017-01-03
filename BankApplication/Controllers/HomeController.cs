﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApplication.Controllers
{
    public class HomeController : Controller
    {
        //GET ../home/index
        //Abstract class ActionResult
        public ActionResult Index()
        {
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