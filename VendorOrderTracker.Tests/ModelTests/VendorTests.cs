using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
[TestClass]
  public class VendorTests
  {
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
  }
}