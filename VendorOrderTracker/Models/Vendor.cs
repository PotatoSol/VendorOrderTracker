using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> VendorsOrders { get; set;}

    public Vendor(string name, string description) 
    {
      Name = name;
      Description = description;
      VendorsOrders = new List<Order>();
    }

    public void AddOrder(Order newOrder){
      VendorsOrders.Add(newOrder);
    }

    public void RemoveOrder(Order removeOrder){
      VendorsOrders.Remove(removeOrder);
    }
  }
}