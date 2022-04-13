using System;

namespace homeworks_13._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Daxil edilmish ededin tek ve ya cut oldugunun tapilmasi ---");

            Console.Write("Ededi daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " cut ededdir");
                }
                else
                    Console.WriteLine(number + " tek ededdir");
            }
            else
                Console.WriteLine(number + " Natural eded deyil");


            Console.WriteLine("--- Daxil edilmish ededlerden boyuk olanin tapilmasi ---");

            Console.Write("ilk  ededi daxil edin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("ededler beraberdir");
            }
            else if (number1 > number2)
            {
                Console.WriteLine(number1 + " ededi boyukdur");
            }
            else
                Console.WriteLine(number2 + " ededi boyukdur");
        }
    }
}
