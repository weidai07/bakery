using System;
using System.Threading;
using System.Collections.Generic;

namespace PierresPastery
{
    public class Pastery
    {
        public static int PasteryBalance(int itemsPastery)
        {
            int Cost = 3;
            int pricePastery = Cost * itemsPastery;
            if (itemsPastery >= 3)
            { 
            int pasteryDiscount = itemsPastery / 3;
            int balancePastery = pricePastery - pasteryDiscount;
            return balancePastery; 
            }   
            else if (itemsPastery < 3)
            { 
            return pricePastery; 
            }
        }    
    }
}