using System;

namespace Store
{
    class Seller : Person
    {
      
        public int SellerId { get; }
        public string Position { get; }
        public double Earned { get; set; }
        public int SalesAmount { get; set; }
        public double lastPurchase { get; set; }

        static Random rnd = new Random();
        public Seller() 
        {
           
            SellerId = rnd.Next(0, 1000000);
            Position = "Продавец-консультант";
            Earned = 0;
            SalesAmount = 0;
        }

     
        public void newPurchase(double sum)
        {
            Earned += sum;
            SalesAmount++;
            lastPurchase = sum;
        }


        public string getSalesInfo()
        {
            var info = $"Продавец id{SellerId} заработал {Earned:C} рублей сделав {SalesAmount} продаж";
            return info;
        }

        internal void newPurchase(Customer customer, Product product)
        {
            if (customer.Budget >= product.Price)
            {
                customer.Buy(product);
                Earned += product.Price;
                SalesAmount++;
                lastPurchase = product.Price;
            }
        }
    }
}
