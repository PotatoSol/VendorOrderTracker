using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public int Date { get; set; } //yyyymmdd -> 20230102 = January 1st, 2023
    public List<Order> ListOfOrders { get; set;}
    public Order(string name, string description, double price, int date) 
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      ListOfOrders.Add(this);
    }
  
  }
}