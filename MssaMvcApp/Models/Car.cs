using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MssaMvcApp.Models
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string CarModel { get; set; }
        public string NameOfCar { get; set; }
        public string VehicleID { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
