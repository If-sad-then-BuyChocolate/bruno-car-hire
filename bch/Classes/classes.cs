using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bch.Classes
{
    public class Car
    {
        public string id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string image { get; set; }
    }

    public class Client
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string IDNumber { get; set; }
        public string Drivers { get; set; }
    }

    public class Rental
    {
        public string id { get; set; }
        public string car_id { get; set; }
        public string client_id { get; set; }
    }
}