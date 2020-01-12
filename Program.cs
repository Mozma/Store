using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashBox = new StoreCashbox();
            var customers = new List<Customer>();
            var products = new List<Product>();
            var bigestPrice = new Product();
            var bigestPurchase = 0;

            var rnd = new Random();
            var tmp = rnd.Next(0, 1000);

            for(var i = 0; i < tmp; i++)
            {
                customers.Add(new Customer());
            }

            tmp = rnd.Next(10, 1000);
            for (var i = 0; i < tmp; i++)
            {
                products.Add(new Product());
            }

            

            tmp = rnd.Next(0, customers.Count);
            for (var i = 0; i < tmp; i++)
            {
                var rnd1 = rnd.Next(0, customers.Count);
                var rnd2 = rnd.Next(0, products.Count);
                
                cashBox.newPurchase(customers[rnd1].Buy(products[rnd2].Price));
                
                if (products[rnd2] > bigestPrice)
                {
                    bigestPrice = products[rnd2];
                    bigestPurchase = rnd1;
                }
            }



            Console.WriteLine($"В кассе: {cashBox.Money}");
            Console.WriteLine($"Пришло покупателей: {customers.Count}");
            Console.WriteLine($"Совершили покупку: {cashBox.Purchases}");
            Console.WriteLine($"Средний чек: {cashBox.Money / cashBox.Purchases }");
            Console.WriteLine($"\nБольше всех потратил покупатель: " +
                              $"\n\tId:{customers[bigestPurchase].CustomerId}" +
                              $"\n\tНаименование: {bigestPrice.Name}" +
                              $"\n\tЦена: {bigestPrice.Price}");

            Console.WriteLine("\n");


            //Test commit
        }
    }
}
