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
    } 
    else 
    {
      Console.WriteLine("Thankyou!");
    }
    int pastryQTY = Convert.ToInt32(Console.ReadLine());
    bread.AddLoaves(breadQTY);
    pastry.AddPastries(pastryQTY);

    int Total = bread.TotalCost + pastry.TotalCost;
    Console.WriteLine("Your total is "+Total.ToString("C2")+"");
    // Console.WriteLine(pastryQTY);
  }
}