using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Bus:Vehicle
    {
        public byte PassengerCount;

        public Bus() : base() { }

        public Bus(string brand, string model) : base(brand, model) { }

        public Bus(string brand, string model, string color, double maxSpeed, byte passengerCount) : base(brand, model, color, maxSpeed) 
        {
            PassengerCount = passengerCount;
        }
       
        public override void info()
        {
            Console.WriteLine("\n\n --- B U S information ---");
            base.info();
            Console.WriteLine(" Passenger count: "+PassengerCount);
        }
    }
}
