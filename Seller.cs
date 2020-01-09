using System;

namespace Store
{
    class Seller : Person
    {
        public int SellerId { get; set; }

        public string Position { get; set; }


        public Seller() 
        {
            var rnd = new Random();
            SellerId = rnd.Next(0, 1000000);
            Position = "Продавец-консультант";
        }



    }
}
