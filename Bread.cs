using System;
using System.Threading;
using System.Collections.Generic;
using Bakery;


namespace Bakery
{
    public class Bread
    {
        public int BreadCount { get; set; } 

        

        public Bread(int breadCount)
        {
            BreadCount = breadCount;
            
        }

        public int BreadCosts()
        {
            int Cost = 5;
            int bakeryDiscount = BreadCount / 2;
            int bakeryPurchase = BreadCount-bakeryDiscount;
            int balanceBakery = Cost * bakeryPurchase;
            int bakeryRegular = Cost * BreadCount;
            int BakeryBalance = balanceBakery + bakeryRegular;
            if (BreadCount >= 2)
            { 
                return balanceBakery;
            }
            else if (BreadCount < 2)
            {
                return bakeryRegular;
            }   
            return BakeryBalance; 
        }
    }
}

