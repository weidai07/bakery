using System;
using System.Threading;
using System.Collections.Generic;
using Bakery;



namespace Bakery
{
    public class Pastery
    {
        private int PasteryItems { get; set; }

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




// namespace Project7
// {

//     public class Pastery
//     {
//         private int ItemsPastery { get; set; }

//         public static int PasteryBalance(int itemsPastery)
//         {   
//             ItemsPastery = itemsPastery;
//             int Cost = 2;
//             int pricePastery = Cost * itemsPastery;
//             int pasteryDiscount = itemsPastery / 3;
//             int balancePastery = pricePastery - pasteryDiscount;
//             if (itemsPastery >= 3)
//             { 
//             return balancePastery; 
//             }   
//             else if (itemsPastery < 3)
//             { 
//             return pricePastery; 
//             }
//         int PasteryBalance = balancePastery + pricePastery;
//         return PasteryBalance;
//         }

//     }
// }


