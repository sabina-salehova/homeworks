using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = chooseNaturalNumber(number);

            Console.Write("Please enter a number to be written first: ");
            int prefixNumber = Convert.ToInt32(Console.ReadLine());
            prefixNumber = chooseNaturalNumber(prefixNumber);

            Console.WriteLine("Result: " + turnNumberToNewnumber(number, prefixNumber));

        }

        public static int turnNumberToNewnumber(int number, int prefixNumber)
        {
            int count = 0;
            int newNumber = number;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            number = 1;
            for (int i = 0; i < count; i++)
            {
                number *= 10;
            }

            newNumber += prefixNumber * number;
            return newNumber;
        }

        public static int chooseNaturalNumber(int number)
        {
            while (number <= 0)
            {
                Console.Write("It is not natural number, please enter again a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }
    }
}

