using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
