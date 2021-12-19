using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving...");
        }
    }
}
