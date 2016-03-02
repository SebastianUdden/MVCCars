using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCars.Models
{
    public class Car
    {
        public Car()
        { }

        public Car(string brand, int doors, int topSpeed)
        {
            Brand = brand;
            Doors = doors;
            TopSpeed = topSpeed;
        }

        public string Brand { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
    }
}

