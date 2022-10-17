using bch.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bch.Controllers
{
    public class AdminController : Controller
    {
        //Admin Dashboard to view all placed orders, as well as to add new cars to the carlisting.
        public ActionResult Admin()
        {
            return View();
        }

        //View a single rental order that was placed by a client, (More Information)
        public ActionResult ViewOrder(string rental_id)
        {
            Processing.getObject<Rental>(Processing.DataPath + $"\\cars\\{rental_id}.txt");
            return View();
        }

        //Create a new car entry to the carlistings.
        public ActionResult CreateCar()
        {
            return View();
        }
    }
}