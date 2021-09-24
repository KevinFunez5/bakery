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
  }
}