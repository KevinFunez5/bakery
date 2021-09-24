using System;
using Bakery;

public class Program
{
  static void Main()
  {
    Bread bread = new Bread();
    bread.PricePer = 5;
    Pastry pastry = new Pastry();
    pastry.PricePer = 2;

    Console.WriteLine("All loaves of bread are "+bread.PricePer.ToString("C2")+" and all pastries are "+pastry.PricePer.ToString("C2")+".");
    Console.WriteLine("Today we have 2 amazing specials - buy 2 loaves of bread get 1 free!!  Additionally, 3 pastries for $5!");
    Console.WriteLine("How many loafs of bread would you like to purchase? Enter quantity:");
    int breadQTY = Convert.ToInt32(Console.ReadLine());
    if (breadQTY != 0)
    {
      Console.WriteLine("How many pastries would you like to purchase? Enter quantity:");
      int pastryQTY = Convert.ToInt32(Console.ReadLine());
    } 
    else 
    {
      Console.WriteLine("Thankyou!");
    }
    bread.AddLoaves(breadQTY);
    pastry.AddPastries(pastryQTY);
    Console.WriteLine(breadQTY);
  }
    // string selection = "a";
    // while(selection != "c")
    // {
    //   if(bread.QuantityOrdered != 0)
    //   {
    //     Console.WriteLine("\r\nHow many additional loaves of bread would you like to purchase?\r\nEnter quantity: ");
    //   }
    //   else
    //   {
    //     Console.WriteLine("\r\nHow many loaves of bread would you like to purchase?\r\nEnter quantity: ");
    //   }
    //   int breadQty = Int32.Parse(Console.ReadLine());
    //   bread.AddLoaves(breadQty);
    //   if(pastry.QuantityOrdered != 0)
    //   {
    //     Console.WriteLine("\r\nHow many additional pastries would you like to purchase?\r\nEnter quantity: ");
    //   }
    //   else
    //   {
    //     Console.WriteLine("\r\nHow many pastries would you like to purchase?\r\nEnter quantity: ");
    //   }
    //   int pastryQty = Int32.Parse(Console.ReadLine());
    //   pastry.AddPastries(pastryQty);

    //   int total = bread.TotalCost + pastry.TotalCost;
    //   Console.WriteLine("\r\nYou have selected "+bread.QuantityOrdered+" loaves of bread and "+pastry.QuantityOrdered+" pastries.  Your total comes to "+total.ToString("C2"));
    
    //   Console.WriteLine("\r\nWould you like to add any more items?");
    //   Console.WriteLine("a. Add more\r\nb. Start Over\r\nc. Checkout");
    //   selection = Console.ReadLine();

    //   switch (selection) 
    //   {
    //     case "a":
    //       break;

    //     case "b":
    //       bread.QuantityOrdered = 0;
    //       pastry.QuantityOrdered = 0;
    //       Console.WriteLine("Your cart is currently empty.");
    //       break;

    //     case "c":
    //       Console.WriteLine("\r\nThat will be "+total.ToString("C2")+". Thank you have a great day!\r\n");
    //       break;

    //     default:
    //       break;
    //   }
    // }
}