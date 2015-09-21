using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarManager.Service;
using CarManager.Business;

namespace CarManager.Areas.Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        private ICarService _carService;

        public DashboardController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult Cars()
        {
            return View(_carService.GetCars());
        }

        [HttpGet]
        public ActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCar(Car newCar)
        {
            if(ModelState.IsValid)
            {
                _carService.Add(newCar);
                return RedirectToAction("Cars");
            }

            return View(newCar);
        }

        [HttpGet]
        public ActionResult EditCar(int carId)
        {
            return View(_carService.Get(carId));
        }

        [HttpPost]
        public ActionResult EditCar(Car editedCar)
        {
            if(ModelState.IsValid)
            {
                _carService.Update(editedCar);
                return RedirectToAction("Cars");
            }

            return View(editedCar);
        }

        [HttpGet]
        public ActionResult DeleteCar(int carId)
        {
            return View(_carService.Get(carId));
        }

        [HttpPost, ActionName("DeleteCar")]
        public ActionResult DeleteCarConfirm(int carId)
        {
            _carService.Delete(carId);
            return RedirectToAction("Cars");
        }

















        // GET: Dashboard/Dashboard
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dashboard/Dashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard/Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Dashboard/Create
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

        // GET: Dashboard/Dashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard/Dashboard/Edit/5
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

        // GET: Dashboard/Dashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Dashboard/Delete/5
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
