namespace _7.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfProductsToAdd = int.Parse(Console.ReadLine()); // Number of products to add

            Dictionary<string, decimal> productsForSaleDict = new Dictionary<string, decimal>(); // Dictioanry to store products and prices

            /// Loop over and fill products and prices in dictionary
            /// If product exists overwrites the product
            for (int i = 0; i < numberOfProductsToAdd; i++)
            {
                string[] products = Console.ReadLine().Split('-');

                productsForSaleDict[products[0]] = decimal.Parse(products[1]);
            }

            /// Read customer orders
            string customerOrder = Console.ReadLine();
            //List<CustomerOrder> customerOrders = new List<CustomerOrder>(); /// List to save customer orders and bill
            var customerOrders = new SortedDictionary<string, Dictionary<string, int>>(); 
            while (customerOrder != "end of clients")
            {
                string[] currCustomerOrder = customerOrder
                    .Split("-,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                /// If ordered product is not in product dictionary, the order process is skipped
                if (!productsForSaleDict.ContainsKey(currCustomerOrder[1]))
                {
                    customerOrder = Console.ReadLine();
                    continue;
                }

                /// Fill data in CustomerOrder class and calculate user bill
                CustomerOrder currOrder = new CustomerOrder
                {
                    CustomerName = currCustomerOrder[0],
                    Product = currCustomerOrder[1],
                    Quantity = int.Parse(currCustomerOrder[2]),
                    ProductPrice = productsForSaleDict[currCustomerOrder[1]] 
                };

                if (!customerOrders.ContainsKey(currOrder.CustomerName))
                {
                    customerOrders[currOrder.CustomerName] = new Dictionary<string, int>();
                }

                if (!customerOrders[currOrder.CustomerName].ContainsKey(currOrder.Product))
                {
                    customerOrders[currOrder.CustomerName][currOrder.Product] = currOrder.Quantity;
                }
                else
                {
                    customerOrders[currOrder.CustomerName][currOrder.Product] += currOrder.Quantity;
                }
              
                customerOrder = Console.ReadLine();
            }

            /// Print result
            decimal totalBill = 0m;
            foreach (var customer in customerOrders)
            {
                decimal userBill = 0.0m;
                Console.WriteLine($"{customer.Key}");
                foreach (var product in customer.Value)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                    userBill += productsForSaleDict[product.Key] * product.Value;
                    totalBill += productsForSaleDict[product.Key] * product.Value;
                }
                Console.WriteLine($"Bill: {userBill:F2}");
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
