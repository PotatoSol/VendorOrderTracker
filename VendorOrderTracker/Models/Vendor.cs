using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id {get;}
    public List<Order> VendorsOrders { get; set;}
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name, string description) 
    {
      Name = name;
      Description = description;
      VendorsOrders = new List<Order>();
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddOrder(Order newOrder){
      VendorsOrders.Add(newOrder);
    }

    public void RemoveOrder(Order removeOrder){
      VendorsOrders.Remove(removeOrder);
    }

    public List<Order> GetAllOrders(){
      return VendorsOrders;
    }

    public static List<Vendor> GetAll(){
      return _instances;
    }

    public static Vendor Find(int searchId){
      return _instances[searchId - 1];
    }
  }
}