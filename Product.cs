using System;

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

        public static bool operator < (Product p1, Product p2)
        {
            return p1.Price < p2.Price;
        }
        public static bool operator > (Product p1, Product p2)
        {
            return p1.Price > p2.Price;
        }
    }
}
