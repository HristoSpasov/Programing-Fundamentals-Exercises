namespace _7.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var populationDict = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputArr = input.Trim()
                    .Split('|')
                    .ToArray();

                string country = inputArr[1];
                string town = inputArr[0];
                int currPopulation = int.Parse(inputArr[2]);

                if (!populationDict.ContainsKey(country))
                {
                    populationDict[country] = new Dictionary<string, long>();
                }

                if (!populationDict[country].ContainsKey(town))
                {
                    populationDict[country][town] = currPopulation;
                }
                else
                {
                    populationDict[country][town] += currPopulation;
                }

                input = Console.ReadLine();
            }

            /// Print result
            foreach (var country in populationDict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var sumTownPopulation = country.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{country.Key} (total population: {sumTownPopulation.Sum()})");

                Console.Write($"=>{string.Join("=>", country.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\n"))}");
            }   
        }
    }
}
