using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.Controllers
{
    public class ClassmateController : Controller
    {
        // GET: Classmate
        public ActionResult Index()
        {

            var brian = new Classmate("Brian", "Black", 5, 10);
            var trey = new Classmate("Trey", "Black", 5, 7);
            var kevin = new Classmate("Kevin", "Black", 5, 10);
            var tee = new Classmate("Tee", "Black", 5, 10);
            var kate = new Classmate("Kate", "Brown", 5, 6);
            var seth = new Classmate("Seth", "Black", 5, 11);
            var daniel = new Classmate("Daniel", "Brown", 5, 20);

            var classmates = new List<Classmate>() { brian, trey, kevin, tee, kate, seth, daniel };

            return View(classmates);
        }

        // GET: Classmate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Classmate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classmate/Create
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

        // GET: Classmate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Classmate/Edit/5
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

        // GET: Classmate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Classmate/Delete/5
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
