using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order 
  {
    private static List<Order> _instances = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get;  set; }
    public int Id { get; }

    public DateTime CurrentDate { get; set; }

    public Order(string orderTitle, string orderDescription, string price)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
      CurrentDate = DateTime.Now;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}