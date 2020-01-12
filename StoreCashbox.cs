using System;


namespace Store
{
    class StoreCashbox
    {
        public double Money { get; private set; }
        public int Purchases { get;  private set; }


        public StoreCashbox()
        {
            Money = 0;
            Purchases = 0;
        }

        public void newPurchase(double money){
            Money += money;
            Purchases++;
        }
        

    }
}
