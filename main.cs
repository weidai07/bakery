using System;
using System.Threading;
using System.Collections.Generic;
using PierresBakery;
using PierresPastery;

namespace PierresBakeryProject
{
    public class Project1
    {
        public static void Main()
       {
           Console.WriteLine("Welcome to Pierre's Bakery! Fresh out the oven, we have loaves of bread and various pasteries for up to $5.00 USD each plus sales tax.");

           Bakery = new Bakery();
           Console.WriteLine("How many loaves of bread would you like to purchase?");
           int customerBakery = int.Parse(Console.ReadLine());
           int balanceBakery = Bakery.BakeryBalance(customerBakery);
           
           Pastery = new Pastery();
           Console.WriteLine("How many pasteries woud you like to purchase?");
           int customerPastery = int.Parse(Console.ReadLine());
           int balancePastery = Pastery.PasteryBalance(customerPastery);

           int totalBalance = balanceBakery + balancePastery + bakeryRegular;
           Console.WriteLine("The total of your balance due is: $\" + totalBalance + \". Thank you very much for supporting our business!");
       }
    }
}

