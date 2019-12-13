using System;
using System.Threading;
using System.Collections.Generic;

namespace PierresBakeryProject
{

    public class Pastery
    {
        public static int PasteryBalance(int itemsPastery)
        {
            int Cost = 3;
            int pricePastery = Cost * itemsPastery;
            int pasteryDiscount = itemsPastery / 3;
            int balancePastery = pricePastery - pasteryDiscount;
            if (itemsPastery >= 3)
            { 
            return balancePastery; 
            }   
            else if (itemsPastery < 3)
            { 
            return pricePastery; 
            }
        }    
    }

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
        }    
    }
}