using System;
using System.Threading;
using System.Collections.Generic;
using Bakery;

public class Dough
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Pierre's Bakery! Fresh baked hourly, we offer loaves of bread and various pasteries for up to $5.00 USD each plus sales tax.");

        Console.WriteLine("How many loaves of bread would you like to purchase?");
        int itemsBread = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(itemsBread);
        int finalBreadCosts = breadOrder.BreadCosts();

        Console.WriteLine("How many pasteries woud you like to purchase?");
        int itemsPastery = int.Parse(Console.ReadLine());
        Pastery pasteryOrder = new Pastery(itemsPastery);
        int finalPasteryCosts = pasteryOrder.finalPasteryCosts();

        int totalBalance = finalBreadCosts + finalPasteryCosts;

        Console.WriteLine("The total of your balance due is: $" + totalBalance + ".00 USD. Thank you very much for supporting our business!");    
    } 
} 







        // Console.WriteLine("Welcome to Pierre's Bakery! Fresh baked hourly, we offer loaves of bread and various pasteries for up to $5.00 USD each plus sales tax.");

        // Bakery bakery = new Bakery();
        // Console.WriteLine("How many loaves of bread would you like to purchase?");
        // int itemsBakery = int.Parse(Console.ReadLine());
        // int balanceBakery = bakery.BakeryBalance(itemsBakery);
        
        // Console.WriteLine("How many pasteries woud you like to purchase?");
        // int itemsPastery = int.Parse(Console.ReadLine());
        // int balancePastery = Pastery.PasteryBalance(itemsPastery);

        // float totalBalance = (balancePastery + balanceBakery) * 10.10;
        // Console.WriteLine("The total of your balance due is: $" + totalBalance + ".00 USD. Thank you very much for supporting our business!");


