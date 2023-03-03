using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order 
  {
    private static List<Order> _instances = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get;  set; }
    public Order(string orderTitle, string orderDescription, int price)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = price;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}