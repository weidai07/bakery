using System;
using System.Threading;
using System.Collections.Generic;
using PierresBakeryProject;

public class PierresPastery
    {
        public static void Main()
       {
           Console.WriteLine("Welcome to Pierre's Bakery! Fresh out the oven, we have loaves of bread and various pasteries for up to $5.00 USD each plus sales tax.");

           Bakery pBakery = new Bakery();
           Console.WriteLine("How many loaves of bread would you like to purchase?");
           int itemsBakery = int.Parse(Console.ReadLine());
           int balanceBakery = pBakery.BakeryBalance(itemsBakery);
           
           Pastery pPastery= new Pastery();
           Console.WriteLine("How many pasteries woud you like to purchase?");
           int itemsPastery = int.Parse(Console.ReadLine());
           int balancePastery = pPastery.PasteryBalance(itemsPastery);

           int totalBalance = balanceBakery + balancePastery + bakeryRegular + pricePastery;
           Console.WriteLine("The total of your balance due is: $\" + totalBalance + \". Thank you very much for supporting our business!");
       }
    }