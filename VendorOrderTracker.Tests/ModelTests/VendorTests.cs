using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
[TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor ("Suzie's Cafe", "Needs a dozen cookies");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Suzie's Cafe";
      string vendorDesc = "Needs a dozen cookies";
      Vendor newVendor = new Vendor(vendorName ,vendorDesc);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string vendorName = "Suzie's Cafe";
      string vendorDesc = "Needs a dozen cookies";
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDesc, result);
    }

    [TestMethod]
    public void GetID_ReturnsID_Int()
    {
      string vendorName = "Suzie's Cafe";
      string vendorDesc = "Needs a dozen cookies";
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObject_VendorList()
    {
      string vendorName1 = "Suzie's Cafe";
      string vendorDesc1 = "Needs a dozen cookies";
      string vendorName2 = "Bob's Cafe";
      string vendorDesc2 = "Needs a dozen pastry";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDesc1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDesc2);

      List<Vendor> newList = new List<Vendor>{ newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName1 = "Suzie's Cafe";
      string vendorDesc1 = "Needs a dozen cookies";
      string vendorName2 = "Bob's Cafe";
      string vendorDesc2 = "Needs a dozen pastry";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDesc1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDesc2);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "Bread";
      string orderDescription = "A food consisting of flour or meal that is moistened, kneaded into dough, and often fermented using yeast";
      string price = "5";

      Order newOrder = new Order(orderTitle, orderDescription, price);
      List<Order> newList = new List<Order> {newOrder};

      string vendorName = "Suzie's Cafe";
      string vendorDesc = "Best Cafe in lower Manhattan";

      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}