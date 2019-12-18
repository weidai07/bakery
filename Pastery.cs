using System;
using System.Threading;
using System.Collections.Generic;
using Project7;

namespace Project7
{

    public class Pastery
    {
        private int ItemsPastery { get; set; }

        public static int PasteryBalance(int itemsPastery)
        {   
            ItemsPastery = itemsPastery;
            int Cost = 2;
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
        int PasteryBalance = balancePastery + pricePastery;
        return PasteryBalance;
        }    
    }
}