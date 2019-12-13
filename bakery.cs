using System;
using System.Threading;
using System.Collections.Generic;

namespace PierresBakery
{
    public class Bakery
    {
        public static int BakeryBalance(int itemsBakery)
        {
            int priceBakery = Cost * itemsBakery;
            if (itemsBakery >= 2)
            int bakeryDiscount = itemsBakery/2;
            int bakeryPurchase = itemsBakery-bakeryDiscount;
            int bakeryRegular = Cost * itemsBakery;
        }
        return bakeryPurchase * Cost;
        else
        {
            return bakeryRegular;
        }
        
    }
}