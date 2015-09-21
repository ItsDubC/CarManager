using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Areas.CarList.Controllers
{
    public class CarController : Controller
    {
        // GET: CarList/Car
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarList/Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarList/Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarList/Car/Create
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

        // GET: CarList/Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarList/Car/Edit/5
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

        // GET: CarList/Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarList/Car/Delete/5
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
