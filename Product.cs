using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            var rnd = new Random();

            Name = "Товар №" + rnd.Next(0, 100);
            Price = rnd.Next(1000, 1000000);
        }
    }
}
