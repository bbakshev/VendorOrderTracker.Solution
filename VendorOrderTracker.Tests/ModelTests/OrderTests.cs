using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order ("Bread", "is done with flour", "5");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTittleDescriptionAndPrice_ReturnTittleDescriptionAndPrice()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      Order newOrder = new Order(orderTitle, orderDescription, price);

      Assert.AreEqual(orderTitle, newOrder.Title);
      Assert.AreEqual(orderDescription, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
    }

    [TestMethod]
    public void SetTitleDescriptionAndPrice()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      string newOrderTitle = "Cinnamon Rolls";
      string newOrderDescription = "a sweet roll commonly served in Northern Europ";
      string newPrice = "7";

      Order newOrder = new Order(orderTitle, orderDescription, price);

      newOrder.Title = newOrderTitle;
      newOrder.Description = newOrderDescription;
      newOrder.Price = newPrice;

      Assert.AreEqual(newOrderTitle, newOrder.Title);
      Assert.AreEqual(newOrderDescription, newOrder.Description);
      Assert.AreEqual(newPrice, newOrder.Price);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> {};
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);
    }

    public void GetID_ReturnsID_Int()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      Order newOrder = new Order(orderTitle, orderDescription, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      string newOrderTitle = "Cinnamon Rolls";
      string newOrderDescription = "a sweet roll commonly served in Northern Europ";
      string newPrice = "7";

      Order newOrder = new Order(orderTitle, orderDescription, price);
      Order newOrder1 = new Order(newOrderTitle, newOrderDescription, newPrice);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder1, result);
    }

    [TestMethod]
    public void SetDate_SetDateOnInstanceOfOrder()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      Order newOrder = new Order(orderTitle, orderDescription, price);

      DateTime currentDate = DateTime.Now;

      Assert.AreEqual(currentDate.ToString(), newOrder.CurrentDate.ToString());
    }
  }
}