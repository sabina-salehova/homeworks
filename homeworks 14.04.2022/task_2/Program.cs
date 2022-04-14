using System;

namespace rrtest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n  0-dan kicik olmayan eded daxil edin: ");
            int number = FindNumber();
                        
            Console.WriteLine("\n  Ededin reqemlerinin cemi: " + findTotalElementsOfNumber(number));
        }

        public static int findTotalElementsOfNumber(int number)
        {
            int total = 0, remainder;
            while (number > 0)
            {
                remainder = number % 10;
                total += remainder;
                number /= 10;
            }
            return total;
        }
        public static int FindNumber()
        {
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.Write("  Duzgun deyil, yeniden eded daxil edin: ");
                }
            } while (number < 0);

            return number;
        }


    }
}
