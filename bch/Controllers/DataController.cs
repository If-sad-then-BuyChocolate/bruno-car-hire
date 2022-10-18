using bch.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace bch.Controllers
{
    public class DataController : Controller
    {

        //Async API call method to create a new Rental Order.
        public async Task<string> CreateOrder(string car_id, Client clientObj)
        {
            try
            {
                Rental rental = new Rental();
                rental.car_id = car_id;
                rental.client_id = Processing.GenerateID(6);
                Processing.SaveObject(rental, Processing.DataPath + $"\\rentals\\{Processing.GenerateID(6)}.txt");
                Processing.SaveObject(clientObj, Processing.DataPath + $"\\clients\\{rental.client_id}.txt");
                return "ok";
            }
            catch (Exception e)
            {
                return "fail";
            }
        }

        //Async API call method to Fetch a single car's information.
        public async Task<string> FetchCar_Single(string id)
        {
            try
            {
                return Processing.ConvertObjectToJSON(Processing.getObject<Car>(Processing.DataPath + $"\\cars\\{id}.txt"));
            }
            catch (Exception e)
            {
                return "fail";
            }          
        }

        //Async API call method to Fetch all car information.
        public async Task<string> FetchCar_All()
        {           
            try
            {
                return Processing.ConvertObjectToJSON(Processing.getObjects<Car>(Processing.DataPath + $"\\cars"));
            }
            catch (Exception e)
            {
                return "fail";
            }
        }

        //Async API call method to Save a car's information/ Create a new Car entry.
        public async Task<string> SaveCar(Car carObj)
        {
            try
            {
                Processing.SaveObject(carObj, Processing.DataPath + $"\\cars\\{Processing.GenerateID(6)}.txt");
                return "ok";
            }
            catch (Exception e)
            {
                return "fail";
            }            
        }

        //Async API call method to Delete a car's information/ Delete a Car entry.
        public async Task<string> DeleteCar(string car_id)
        {
            try
            {
                Processing.DeleteObject(Processing.DataPath + $"\\cars\\{car_id}.txt");
                return "ok";
            }
            catch (Exception)
            {
                return "fail";
            }
        }

        //Async API call method to Fetch all Rental information.
        public async Task<string> GetRentals_All()
        {            
            try
            {
                return Processing.ConvertObjectToJSON(Processing.getObject<Rental>(Processing.DataPath + $"\\rentals"));
            }
            catch (Exception e)
            {
                return "fail";
            }
        }

        //Async API call method to Fetch a single Rental order's information.
        public async Task<string> GetRentals_Single(string id)
        {            
            try
            {
                return Processing.ConvertObjectToJSON(Processing.getObject<Rental>(Processing.DataPath + $"\\rentals\\{id}.txt"));
            }
            catch (Exception e)
            {
                return "fail";
            }
        }
    }
}