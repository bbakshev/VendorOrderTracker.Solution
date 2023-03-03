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
      Vendor newVendor = new Vendor ("Suzie's Cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetVendorDescriotion_ReturnsVendorDescription_String()
    {
      string vendorDesc = "Needs a dozen cookies";
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDesc, result);
    }
  }
}