using System;
using System.Threading;
using System.Collections.Generic;
using Bakery;



namespace Bakery
{
    public class Pastery
    {
        public int PasteryItems { get; set; }

        public Pastery(int pasteryItems)
        {
            PasteryItems = pasteryItems;
        }

        public int PasteryCosts()
        {
            int costs = 2;
            int pricePastery = costs * PasteryItems;
            int pasteryDiscount = PasteryItems / 3;
            int balancePastery = pricePastery - pasteryDiscount;
            int PasteryBalance = balancePastery + pricePastery;
            if (PasteryItems >= 3)
            { 
                return balancePastery; 
            }   
            else if (PasteryItems < 3)
            { 
                return pricePastery; 
            }
           return PasteryBalance;
        }
    }
}
