namespace _5.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> input = File.ReadAllLines("./Input.txt".Trim()).ToList();
            
            input.Remove(input[input.Count - 1]);

            List<string> resourses = new List<string>();
            List<long> quantity = new List<long>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0)
                {
                    resourses.Add(input[i]);
                }
                else
                {
                    quantity.Add(long.Parse(input[i]));
                }
            }

            Dictionary<string, long> result = new Dictionary<string, long>();

            for (int i = 0; i < resourses.Count; i++)
            {
                string currentResourse = resourses[i];
                long currQuantity = quantity[i];

                if (!result.ContainsKey(currentResourse))
                {
                    result[currentResourse] = 0;
                }

                result[currentResourse] += currQuantity;  
            }

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var resourse in result.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                File.AppendAllText("./Output.txt", $"{resourse.Key} -> {resourse.Value}\r\n");
            }
        }
    }
}
