using System;
using System.Threading;
using System.Collections.Generic;
using Project7;

public class Dough
    {
        public static void Main()
       {
           Console.WriteLine("Welcome to Pierre's Bakery! Fresh baked hourly, we offer loaves of bread and various pasteries for up to $5.00 USD each plus sales tax.");

           Bakery bakery = new Bakery();
           Console.WriteLine("How many loaves of bread would you like to purchase?");
           int itemsBakery = int.Parse(Console.ReadLine());
           int balanceBakery = bakery.BakeryBalance(itemsBakery);
           
           Console.WriteLine("How many pasteries woud you like to purchase?");
           int itemsPastery = int.Parse(Console.ReadLine());
           int balancePastery = Pastery.PasteryBalance(itemsPastery);

           int totalBalance = balancePastery + balanceBakery;
           Console.WriteLine("The total of your balance due is: $" + totalBalance + ".00 USD. Thank you very much for supporting our business!");
       } 
    }