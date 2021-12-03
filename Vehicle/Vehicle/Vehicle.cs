using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Speed;
        public string Colour;

        public Vehicle(string brand, string model, int speed, string colour)
        {
            Model = model;
            Brand = brand;
            Speed = speed;
            Colour = colour;

            Console.WriteLine($"{brand} {model}\nMax speed: {speed} kmph\nColour: {colour}\n");
        }
    }
}
