using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order 
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get;  set; }
    public Order(string orderTitle, string orderDescription, int price)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = price;
    }
  }
}