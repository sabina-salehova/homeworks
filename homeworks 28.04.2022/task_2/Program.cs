using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milkProduct1 = new Milk("Cow Milk 30%");
            Milk milkProduct2=new Milk("Super Milk 30%");
            Milk.Sell();
            Milk.Sell();
            Milk.Sell();
            Console.WriteLine("Milk count: " + Milk.Count);
            Console.WriteLine("Milk total income: " + Milk.TotalIncome);
        }

        
    }
}
