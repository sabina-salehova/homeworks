using System;

namespace rrrtest
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = createdStringArray();

            Console.Write("\n 0-dan boyuk olmaqla axtarilmasi istenilen element uzunlugu daxil edin: ");
            int lengthOfElement = FindPositiveNumber();

            Console.WriteLine(" \n--- "+ lengthOfElement+" uzunlugundan boyuk array-in elementleri ---  ");
            findLengthOfElementInArray(arr, lengthOfElement);
        }

        public static void findLengthOfElementInArray(string[] arr, int lengthOfElement)
        {
            foreach (string item in arr)
            {
                if (item.Length > lengthOfElement)
                    Console.WriteLine(" \n  "+item);
            }
        }
        public static string[] createdStringArray()
        {
            Console.Write("\n 0-dan boyuk olmaqla array-in uzunlugunu daxil edin: ");
            int size = FindPositiveNumber();
            Console.WriteLine(" \n--- Elementlerin deyerlerini daxil edin ---");
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("\n arr[" + i + "]= ");
                arr[i] = Console.ReadLine();
            }
            return arr;

        }
        public static int FindPositiveNumber()
        {
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.Write(" Duzgun deyil, yeniden deyer daxil edin: ");
                }
            } while (number <= 0);

            return number;
        }
    }
}
