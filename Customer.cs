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

        static Random rnd = new Random();

        public Customer()
        {
            CustomerId = rnd.Next(0, 1000000);
            Budget = rnd.Next(0, 1000000);
        }

        public Customer(double id, double budget)
        {
            CustomerId = id;
            Budget = budget;
        }
      

        public double Buy(Product product)
        {
            if (Budget - product.Price > 0)
                Budget -= product.Price;

            return product.Price; 
        }



    }
}
