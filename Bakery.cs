using System;
using System.Threading;
using System.Collections.Generic;
using Project7;

namespace Project7
{
    public class Bakery
    {
        public int BakeryBalance(int itemsBakery)
        {
            int Cost = 5;
            int bakeryDiscount = itemsBakery/2;
            int bakeryPurchase = itemsBakery-bakeryDiscount;
            int balanceBakery = Cost * bakeryPurchase;
            int bakeryRegular = Cost * itemsBakery;
            if (itemsBakery >= 2)
            { 
            return balanceBakery;
            }
            else if (itemsBakery < 2)
            {
            return bakeryRegular;
            }   
        int BakeryBalance = balanceBakery + bakeryRegular;
        return BakeryBalance;    
        }    
    }
}
