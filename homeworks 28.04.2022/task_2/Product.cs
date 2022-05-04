using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    abstract class Product
    {
        public string Name;
        public static double Price;
        public static int Count;
        protected static double _totalIncome;
        public static double TotalIncome { get { return _totalIncome; } }

        static Product()
        {
            Count = default(int);
            Price = 10;
            _totalIncome = default(double);
        }
        public Product(string name)
        {
            Name = name;
        }

        public static void Sell()
        {
            if (Count > 0)
            {
                Count--;
                _totalIncome += Price;
                Console.WriteLine("The product was sold.");
            }
            else
                Console.WriteLine("There is no product in stock.");
        }

    }
}
