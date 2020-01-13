using System;
using System.Threading;
using System.Collections.Generic;
using Bakery;


namespace Bakery
{
    public class Bread
    {
        private int BreadCount { get; set; } 

        

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




 
// namespace Project7
// {
//     public class Bakery
//     {
//         public int BakeryBalance(int itemsBakery)
//         {
//             int Cost = 5;
//             int bakeryDiscount = itemsBakery/2;
//             int bakeryPurchase = itemsBakery-bakeryDiscount;
//             int balanceBakery = Cost * bakeryPurchase;
//             int bakeryRegular = Cost * itemsBakery;
//             if (itemsBakery >= 2)
//             { 
//             return balanceBakery;
//             }
//             else if (itemsBakery < 2)
//             {
//             return bakeryRegular;
//             }   
//         int BakeryBalance = balanceBakery + bakeryRegular;
//         return BakeryBalance;    
//         }    
//     }
// }


