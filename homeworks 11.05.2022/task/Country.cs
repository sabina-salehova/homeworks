using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Country
    {
        public string Name;
        int _totalPopulation = default(int);
        List<City> City=new List<City>();
        public int TotalPopulation {get { return _totalPopulation; } }


        public Country(string name)
        {
            Name = name;            
        }

        public void AddCity(City city)
        {
            if (City.Contains(city))
            {
                Console.WriteLine("The included city already exists.");
                return;
            }
            City.Add(city);
            _totalPopulation += city.Population;
        }
        public List<City> FindAllByPopulation(int min, int max)
        {
            List<City> newCity = new List<City>();
            foreach (City item in City)
            {
                if (item.Population > min && item.Population < max)
                {
                    newCity.Add(item);
                }
            }
            return newCity;
        }

        public override string ToString()
        {
            return "\nName of Country: " + Name + ", Population of Country: " + _totalPopulation;
        }

    }
}
