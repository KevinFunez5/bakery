namespace Bakery 
{
  public class Bread
  {
    public int QuantityOrdered { get; set; }
    public int TotalCost { get; set; }
    public int PricePer { get; set; }
    public void AddLoaves(int qty)
    {
      QuantityOrdered += qty;
      Total();
    }

    public void Total()
    {
      int unos = QuantityOrdered % 3;
      int setsOfThree = (QuantityOrdered - unos)/3;
      TotalCost = (unos * PricePer) + (setsOfThree * PricePer * 2);
    }
  }
  public class Pastry
  {
    public int QuantityOrdered { get; set;}
    public void AddPastries(int qty)
    {
      QuantityOrdered += qty;
    }
  }
}