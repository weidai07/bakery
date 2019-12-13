using System;
using System.Threading;
using System.Collections.Generic;

namespace PierresPastery
{
    public class Pastery
    {
        public static int PasteryBalance(int itemsPastery)
        {
            int pricePastery = Cost * itemsPastery;
            if (itemsPastery >= 3)
            int pasteryDiscount = itemsPastery/3;
            balancePastery = balancePastery - pasteryDiscount;
        }
        return balancePastery; 
    }
}