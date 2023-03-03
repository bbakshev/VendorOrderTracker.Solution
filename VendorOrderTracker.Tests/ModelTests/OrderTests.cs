using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order ("Bread", "is done with flour", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTittleDescriptionAndPrice_ReturnTittleDescriptionAndPrice()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      int price = 5;

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
      int price = 5;

      string newOrderTitle = "Cinnamon Rolls";
      string newOrderDescription = "a sweet roll commonly served in Northern Europ";
      int newPrice = 7;

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
  }
}