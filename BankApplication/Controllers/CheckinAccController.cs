using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApplication.Controllers
{
    public class CheckinAccController : Controller
    {
        // GET: CheckinAcc
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckinAcc/Details/5
        public ActionResult Details()
        {
            var checkinAcc = new CheckingAcc
            {
                AccountNumber = "000012312312",
                FirstName = "Michael",
                LastName = "Sullivan",
                Balance = 500
            };
            return View(checkinAcc);

        }

        // GET: CheckinAcc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckinAcc/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckinAcc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckinAcc/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckinAcc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckinAcc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
