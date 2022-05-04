using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Milk:Product
    {
        public double Volume;   
        public double FatRate;   

        public Milk(string name):base(name) 
        {
            Count++;
            Name = name;
            Volume = default(double);
            FatRate = default(double);           
        }

       

    }
}
