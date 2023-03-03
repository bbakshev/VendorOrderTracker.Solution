using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }

    public Vendor(string vendorName, string vendorDesc)
    {
      Name = vendorName;
      Description = vendorDesc;
    }
  }
}