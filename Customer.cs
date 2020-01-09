using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Customer : Person
    {
        public double CustomerId { get; set; }
        public double Budget { get; set; }

        public Customer()
        {
            var rnd = new Random();
            CustomerId = rnd.Next(0, 1000000);
            Budget = rnd.Next(0, 10000000);
        }

        public double Buy(double price)
        {
            if (Budget - price > 0)
                Budget -= price;

            return price; 
        }



    }
}
