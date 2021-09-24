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
      Assert.AreEqual(0, bread.TotalCost);
    }
  }
}