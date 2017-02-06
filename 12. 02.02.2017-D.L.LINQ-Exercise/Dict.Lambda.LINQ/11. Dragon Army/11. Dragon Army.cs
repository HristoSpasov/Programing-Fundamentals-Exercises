namespace _11.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            /// Default stats values
            int defaultHealth = 250;
            int defaultDamage = 45;
            int defaultArmor = 10;

            var dragonDict = new Dictionary<string, SortedDictionary<string, double[]>>(); /// Dictionary to store dragon data
            int numberDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberDragons; i++)
            {
                string[] input = Console.ReadLine()
                    .Trim()
                    .Split();

                /// Get dragon parameters
                string dragonType = input[0];
                string dragonName = input[1];
                double dragonDamage = input[2] != "null" ? double.Parse(input[2]) : defaultDamage;
                double dragonHealth = input[3] != "null" ? double.Parse(input[3]) : defaultHealth;
                double dragonArmor = input[4] != "null" ? double.Parse(input[4]) : defaultArmor;

                /// Add dragon tyoe in dictionary
                if (!dragonDict.ContainsKey(dragonType))
                {
                    dragonDict[dragonType] = new SortedDictionary<string, double[]>();
                }

                /// Write/Rewrite dragon name and stats
                dragonDict[dragonType][dragonName]
                    = new double[] { dragonDamage, dragonHealth, dragonArmor };   
            }

            /// Print result
            foreach (var type in dragonDict)
            {   
                /// Print average dragon stats by type
                string dragonTypeAverage = type.Key;
                double damageAverage = type.Value.Values.Average(x => x[0]);
                double healthAverage = type.Value.Values.Average(x => x[1]);
                double armorAverage = type.Value.Values.Average(x => x[2]);

                Console.WriteLine($"{dragonTypeAverage}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

                /// Print parameters for each dragon
                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
