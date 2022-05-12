using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            checkSolutionOfTask();
        }

        public static void checkSolutionOfTask()
        {
            City baki = new City("Baki", 2045815);
            City gence = new City("Gence", 313249);
            City sumqayit = new City("Sumqayit", 309446);

            Country azerbaijan = new Country("Azerbaijan");
            azerbaijan.AddCity(baki);
            azerbaijan.AddCity(sumqayit);
            azerbaijan.AddCity(gence);

            City paris = new City("Paris", 2181371);
            City marsel = new City("Marsel", 839043);

            Country france = new Country("France");
            france.AddCity(paris);
            france.AddCity(marsel);

            Console.WriteLine("\n      Cities of Azerbaijan (Population: min: 313248 - max: 2045816)");
            foreach (City item in azerbaijan.FindAllByPopulation(313248, 2045816))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n        Cities of France (Population: min: 313248 - max: 2045816)");

            foreach (City item in france.FindAllByPopulation(313248, 2045816))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(azerbaijan);
            Console.WriteLine(france);
        }
    }
}
