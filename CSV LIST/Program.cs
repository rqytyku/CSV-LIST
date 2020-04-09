using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\romel\OneDrive\Documents\Book1.csv ";
            CSVreader reader = new CSVreader(filePath);
            List<Country> countries = reader.ReadAllCountries();
            Country italy = new Country("Italy", "IT", "Europe", 60_630_000);
            int italyIndex=countries.FindIndex(x=>x.population > 60_630_000);
            countries.Insert(italyIndex, italy);
            countries.RemoveAt(italyIndex);
            foreach (Country country in countries)
            {
          
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.population).PadLeft(15)}: {country.name}");
            }
            Console.WriteLine($"There are {countries.Count} countries");
            Console.ReadKey();
        }
    }
}
