using bch.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bch.Controllers
{
    public class ViewController : Controller
    {
        //About us infromation page for Clients.
        public ActionResult AboutUs()
        {
            return View();
        }

        //Contact Page for Clients.
        public ActionResult ContactUs()
        {
            return View();
        }

        // Landing Page for Clients.
        public ActionResult Home()
        {
            return View();
        }

        //View all cars added by admins.
        public ActionResult CarListings()
        {
            ViewData["cars"] = Processing.getObjects<Car>(Processing.DataPath + "\\cars");
            return View();
        }

        //View a single car's information page.
        public ActionResult Car(string id)
        {
            ViewData["car"] = Processing.getObject<Car>(Processing.DataPath + $"\\cars\\{id}.txt");
            return View();
        }

        //Fill in personal information for an order to hire a car.
        public ActionResult CreateOrder(string car_id)
        {
            return View();
        }
    }
}