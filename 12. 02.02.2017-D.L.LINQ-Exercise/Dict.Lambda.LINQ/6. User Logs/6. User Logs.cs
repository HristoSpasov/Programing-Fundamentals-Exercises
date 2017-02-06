namespace _6.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var logDict = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArr = input.Trim()
                    .Split(' ')
                    .ToArray();

                string userName = inputArr[2].ToString().Substring(5);
                string currIP = inputArr[0].ToString().Substring(3);

                if (!logDict.ContainsKey(userName))
                {
                    logDict[userName] = new Dictionary<string, int>();
                }

                if (!logDict[userName].ContainsKey(currIP))
                {
                    logDict[userName][currIP] = 1;
                }
                else
                {
                    logDict[userName][currIP]++;
                }
                
                input = Console.ReadLine();
            }

            foreach (var user in logDict)
            {
                Console.WriteLine($"{user.Key}: ");
                Console.Write(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value)));
                Console.WriteLine(".");
            }
        }
    }
}
