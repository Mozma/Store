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
            var sellers = new List<Seller>();
            var bestSeller = new Seller();
            var bigestPrice = new Product();
            var bigestPurchase = 0;

            var rnd = new Random();
            var tmp = 100;                          //rnd.Next(0, 1000);

            for (var i = 0; i < tmp; i++)
            {
                customers.Add(new Customer());
            }

            tmp = 1000;
            for (var i = 0; i < tmp; i++)
            {
                products.Add(new Product());
            }

            tmp = 10;
            for (var i = 0; i < tmp; i++)
            {
                sellers.Add(new Seller());
            }

          
            foreach(var customer in customers)
            {

                var rnd1 = rnd.Next(rnd.Next(sellers.Count));
                var rnd2 = rnd.Next(products.Count);

                

                sellers[rnd1].newPurchase(customer, products[rnd2]);

                cashBox.newPurchase(sellers[rnd1].lastPurchase);

                if (products[rnd2] > bigestPrice)
                {
                    bigestPrice = products[rnd2];
                    bigestPurchase = rnd1;

                }
            }

            foreach (var seller in sellers)
            {
                if(bestSeller.Earned < seller.Earned)
                {
                    bestSeller = seller;
                }
            }

            


            Console.WriteLine($"В кассе: {cashBox.Money:C}");
            Console.WriteLine($"Пришло покупателей: {customers.Count}");
            Console.WriteLine($"Совершили покупку: {cashBox.Purchases}");
            Console.WriteLine($"Средний чек: {cashBox.Money / cashBox.Purchases :C}");
            Console.WriteLine($"\nБольше всех потратил покупатель: " +
                              $"\n\tId: {customers[bigestPurchase].CustomerId}" +
                              $"\n\tНаименование: {bigestPrice.Name}" +
                              $"\n\tЦена: {bigestPrice.Price}");
            Console.WriteLine($"Лучший работник:\n\t{bestSeller.getSalesInfo()}");

            Console.WriteLine("\n");

          
        }
    }
}
