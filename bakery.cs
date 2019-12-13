using System;
using System.Threading;
using System.Collections.Generic;

namespace PierresBakery
{
    public class Bakery
    {
        public static int BakeryBalance(int itemsBakery)
        {
            int Cost = 5;
                if (itemsBakery >= 2)
                { 
                int bakeryDiscount = itemsBakery/2;
                int bakeryPurchase = itemsBakery-bakeryDiscount;
                int balanceBakery = Cost * bakeryPurchase;
                return balanceBakery;
                }
                else if (itemsBakery < 2)
                {
                int bakeryRegular = Cost * itemsBakery;
                return bakeryRegular;
                }   
        }    
    }
}