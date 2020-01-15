using System;

namespace Store
{
    class Product
    {
       

        public string Name { get; set; }
        public double Price { get; set; }

        static Random rnd = new Random();

        public Product()
        {
           

            Name = "Товар №" + rnd.Next(0, 100);
            Price = rnd.Next(10000, 100000);
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
