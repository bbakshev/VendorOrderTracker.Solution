using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order 
  {
    public string Title { get; }
    public string Description { get; }
    public int Price { get;  }
    public Order(string orderTitle, string orderDescription, int price)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = price;
    }
  }
}