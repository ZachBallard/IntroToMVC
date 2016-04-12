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
    }
}
