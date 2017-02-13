using System;

namespace _7.AndreyAndBilliard
{
    using System;

    public class CustomerOrder
    {
        public string CustomerName { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal Bill => ProductPrice * Quantity;
    }
}
