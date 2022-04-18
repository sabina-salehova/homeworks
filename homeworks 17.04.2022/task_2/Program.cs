using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = findNaturalNumber(number);

            Console.Write("Please enter divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            divisor = findNaturalNumber(divisor);

            Console.WriteLine("Result: " + findNearestDividedNumber(number, divisor));

        }

        public static int findNearestDividedNumber(int number, int divisor)
        {
            if (number % divisor == 0)
            {
                return number;
            }

            int smallDividedNumber = (number / divisor) * divisor;
            int largeDividedNumber = smallDividedNumber + divisor;
            if ((number - smallDividedNumber) > (largeDividedNumber - number))
                return largeDividedNumber;
            else
                return smallDividedNumber;
        }

        public static int findNaturalNumber(int number)
        {
            while (number <= 0)
            {
                Console.Write("The number is not natural, please enter again: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }
    }
}
