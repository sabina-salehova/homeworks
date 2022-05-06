using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class PDF : IPrintable
    {
        public void printFile()
        {
            Console.WriteLine("PDF printed.");
        }
    }
}
