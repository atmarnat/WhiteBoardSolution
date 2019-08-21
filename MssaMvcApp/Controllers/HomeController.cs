using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MssaMvcApp.Models;

namespace MssaMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Car abigail = new Car
            {
                Manufacturer = "Chevy",
                CarModel = "Corvette",
                NameOfCar = "Abigail",
                VehicleID = "ABC1"
            };

            Car cardi = new Car
            {
                Manufacturer = "Toyota",
                CarModel = "GT86",
                NameOfCar = "Cardi",
                VehicleID = "ABC2"
            };

            Car rentalCar = new Car
            {
                Manufacturer = "Ford",
                CarModel = "Focus"
            };

            Car[] cars = new Car[] { abigail, cardi, rentalCar };

            return View(cars);
        }

        public IActionResult CarDetail()
        {
            Car cardi = new Car
            {
                Manufacturer = "Toyota",
                CarModel = "GT86",
                NameOfCar = "Cardi",
                VehicleID = "ABC2",
                Year = 2013,
                Price = 65000M
            };

            return View(cardi);
        }
    }
}