using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Please enter sentences: ");
             string mainStr = Console.ReadLine();
             Console.Write("Please enter a search term: ");
             string searchedStr = Console.ReadLine();

             Console.WriteLine("Result: " + mainStr.customContain(searchedStr));            
        }
    }
}
