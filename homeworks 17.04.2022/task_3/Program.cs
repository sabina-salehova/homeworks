using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = findNaturalNumber(number);

            if (number < 50)
            {
                printArray(createArrayOfDividedNumbers(number, 3));
            }
            else if (number <= 100)
            {
                printArray(createArrayOfDividedNumbers(number, 5));
            }
            else
                printArray(createArrayOfDividedNumbers(number, 8));
        }

        public static int[] createArrayOfDividedNumbers(int number, int divisor)
        {
            int newNumber = number;
            newNumber /= divisor;
            newNumber *= divisor;
            int size = 0;
            while (newNumber >= 0)
            {
                newNumber -= divisor;
                size++;
            }

            int[] array = new int[size];

            int elementsOfIndex = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = elementsOfIndex;
                elementsOfIndex += divisor;
            }
            return array;
        }

        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + arr[i]);
            }
        }

        public static int findNaturalNumber(int number)
        {
            while (number <= 0)
            {
                Console.Write("It is not a natural number, please enter again: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }


    }
}
