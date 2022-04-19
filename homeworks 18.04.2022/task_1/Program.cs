using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Max number: "+findMaxNumberinArray(creatArray()));
        }

        public static int findMaxNumberinArray(int[] array)
        {
            int max =array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

        public static int[] creatArray()
        {
            Console.Write("Please enter a size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            size= findNaturalNumber(size);

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("array["+i+"]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());                
            }

           return array;       
        }

        public static int findNaturalNumber(int number)
        {
            while (number <= 0)
            {
                Console.Write("It is not natural number, please enter again: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;        
        }



    }
}
