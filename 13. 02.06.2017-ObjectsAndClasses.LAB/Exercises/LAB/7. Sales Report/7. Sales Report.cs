namespace _7.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var report = new SortedDictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] sale = Console.ReadLine().Split();

                var currSale = new Sale
                {
                    Town = sale[0],
                    Product = sale[1],
                    Price = decimal.Parse(sale[2]),
                    Quantity = decimal.Parse(sale[3])
                };

                if (!report.ContainsKey(currSale.Town))
                {
                    report[currSale.Town] = 0m;
                }

                report[currSale.Town] += currSale.Price * currSale.Quantity;
            }

            foreach (var record in report)
            {
                Console.WriteLine($"{record.Key:F2} -> {record.Value:F2}");
            }
        }
    }
}
