namespace _3.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            /// Create dictionary to store material name and quantity
            var materialDict = new Dictionary<string, List<int>>();

            /// Read input command
            string inputCommand = Console.ReadLine();

            /// Loop while receive stop command
            while (inputCommand != "stop")
            {
                /// If material not in dictionary, ads it
                if (!materialDict.ContainsKey(inputCommand))
                {
                    materialDict[inputCommand] = new List<int>();
                }

                materialDict[inputCommand].Add(int.Parse(Console.ReadLine()));
                
                inputCommand = Console.ReadLine();
            }

            /// Print dictionary on console
            foreach (var material in materialDict)
            {
                Console.WriteLine($"{material.Key} -> {material.Value.Sum()}");
            }
        }
    }
}
