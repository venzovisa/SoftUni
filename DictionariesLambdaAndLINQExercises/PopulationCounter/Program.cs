using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopulationCounter
{             
    public class Country{
        public Dictionary<String, ulong> cities = new Dictionary<String, ulong>();
        public string name;
        public ulong population;
/*
        public int CompareTo(Country other) {
            return other.population.CompareTo(this.population);
        }*/
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {            
            String command = Console.ReadLine();
            String[] input = command.Split('|');
            String city = "";
            String country = "";
            ulong population = 0;
            List <Country> countries = new List <Country>();
          
            while (command.ToLower() != "report")        
            {              
                input = command.Split('|');
                city = input[0];
                country = input[1];
                population = ulong.Parse(input[2]);

                Country newCountry = new Country();

                // check existence of current country
                bool hasCountry = false;
                int countryIndex = 0;
                for (int i = 0; i < countries.Count; i++)
                {
                    if (country == countries[i].name) { hasCountry = true; countryIndex = i; break; }
                }

                if (!hasCountry)
                { // add country
                    newCountry.name = country;
                    newCountry.cities.Add(city, population);
                    countries.Add(newCountry);
                }
                else { // add city to existing country
                    if (!countries[countryIndex].cities.ContainsKey(city))
                        countries[countryIndex].cities.Add(city, population);
                } 
                                   
                command = Console.ReadLine();
            }

            // calculate country population
            for (int i = 0; i < countries.Count; i++)
            {
                ulong totalPopulation = 0;
                for (int x = 0; x < countries[i].cities.Count; x++)
                {
                    totalPopulation += (ulong)countries[i].cities.ElementAt(x).Value;
                }
                countries[i].population = totalPopulation;
            }

            // sort countries
            countries = countries
                .OrderByDescending(a => a.population)
                .ThenBy(a => a.name)
                .ToList();

            // sort cities
            for (int i = 0; i < countries.Count; i++)
            {
                countries[i].cities = countries[i].cities
                    .OrderByDescending(a => a.Value)
                    .ToDictionary(a => a.Key, a => a.Value);
            }

            // print result
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine("{0} (total population: {1})", countries[i].name, countries[i].population);
                for (int x = 0; x < countries[i].cities.Count; x++)
                {
                    Console.WriteLine("=>{0}: {1}", countries[i].cities.ElementAt(x).Key,
                       countries[i].cities.ElementAt(x).Value);
                }              
            }
        }
    }
}
