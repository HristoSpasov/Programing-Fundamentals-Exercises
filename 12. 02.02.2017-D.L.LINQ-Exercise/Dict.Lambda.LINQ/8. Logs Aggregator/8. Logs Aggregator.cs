namespace _8.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var logDict = new SortedDictionary<string, SortedDictionary<string, int>>();
            int inputLogsCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < inputLogsCount; i++)
            {
                string[] inputArr = Console.ReadLine().Trim()
                    .Split()
                    .ToArray();

                string ip = inputArr[0];
                string userName = inputArr[1];
                int currentDuration = int.Parse(inputArr[2]);

                if (!logDict.ContainsKey(userName))
                {
                    logDict[userName] = new SortedDictionary<string, int>();
                }

                if (!logDict[userName].ContainsKey(ip))
                {
                    logDict[userName][ip] = currentDuration;
                }
                else
                {
                    logDict[userName][ip] += currentDuration;
                }
            }

            /// Print result
            foreach (var user in logDict)
            {
                var totalSeconds = user.Value.Select(x => x.Value).ToList().Sum();
                Console.WriteLine($"{user.Key}: {totalSeconds} [{string.Join(", ", user.Value.Select(x => x.Key))}]");
            }
        }
    }
}
