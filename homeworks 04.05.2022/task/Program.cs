using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bs1= createBusObject();
            bs1.info();
        }

        public static Bus createBusObject()
        {
            Console.Write("Please enter Brand of bus: ");
            string brand = checkString(Console.ReadLine());
            Console.Write("Please enter Model of bus: ");
            string model = checkString(Console.ReadLine());
            Console.Write("Please enter Color of bus: ");
            string color = checkString(Console.ReadLine());
            Console.Write("Please enter Max speed of bus: ");
            double maxSpeed = checkPositiveDoubleNumber(Console.ReadLine());
            Console.Write("Please enter Passenger count of bus: ");
            byte passengerCount = checkPositiveByteNumber(Console.ReadLine());
            
            return new Bus(brand, model, color, maxSpeed, passengerCount);
        }

        public static double checkPositiveDoubleNumber(string str)
        {
            double number;
            while (!double.TryParse(str, out number) || number<=0)
            {
                Console.Write("Please enter correct value: ");
                str = Console.ReadLine();
            }

            return number;

        }

        public static byte checkPositiveByteNumber(string str)
        {
            byte number;
            while (!byte.TryParse(str, out number) || number <= 0)
            {
                Console.Write("Please enter correct value: ");
                str = Console.ReadLine();
            }

            return number;

        }

        public static string checkString(string str)
        {
            while (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                Console.Write("Please enter correct value: ");
                str = Console.ReadLine();
            }
            return str;
        }
    }
}
