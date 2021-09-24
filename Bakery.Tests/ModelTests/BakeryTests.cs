using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
        public void BreadConstructor_CreatesObjectBread_Bread()
    {
      Bread loaf = new Bread();
      Assert.AreEqual(typeof(Bread), loaf.GetType());
    }

    [TestMethod]
    public void AddLoaves_AddOneLoaf_QuantityOfOrder()
    {
      //Arrange 
      Bread bread = new Bread();

      //Act
      bread.AddLoaves(1);

      //Assert
      Assert.AreEqual(1, bread.QuantityOrdered);
    }

    [TestMethod]
    public void Total_AddMultipleLoafs_TotalCost()
    {
      //Arrange
      Bread bread = new Bread();
      bread.PricePer = 5;
      bread.AddLoaves(2);

      //Act
      bread.Total();
      
      //Assert
      Assert.AreEqual(10, bread.TotalCost);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesObjectPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void AddPastries_AddOne_QuantityOrdered()
    {
      //Arrange
      Pastry pastry = new Pastry();

      //Act
      pastry.AddPastries(1);

      //Assert
      Assert.AreEqual(1, pastry.QuantityOrdered);
    }
  }
}