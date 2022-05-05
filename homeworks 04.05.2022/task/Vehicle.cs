using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public double MaxSpeed;

        public Vehicle()
        {
            Console.WriteLine("Car Created");            
        }
        public Vehicle(string brand, string model):this()
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle(string brand, string model, string color, double maxSpeed):this(brand, model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }
        public virtual void info()
        {

            Console.WriteLine("\n Brand: " + Brand + "\n Model: " + Model+"\n Color: "+Color+"\n Max speed: "+MaxSpeed);
        }
    }
}
