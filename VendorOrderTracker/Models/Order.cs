using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Id {get;}

    public int Date { get; set; } //yyyymmdd -> 20230102 = January 1st, 2023
    private static List<Order> _instances = new List<Order> { };
    public Order(string name, string description, double price, int date) 
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

  public static void ClearAll(){
    _instances.Clear();
  }

  }
}