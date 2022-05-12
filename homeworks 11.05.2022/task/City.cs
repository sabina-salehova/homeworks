using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class City
    {
        public string Name;
        public int Population;

        public City(string name, int population) 
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return "Name of City: " + Name + ", Population of City: " + Population;
        }
    }
}
