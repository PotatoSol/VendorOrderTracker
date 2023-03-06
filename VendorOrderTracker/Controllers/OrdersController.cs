using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Controllers{
    public class OrdersController : Controller
    {
        
        [HttpPost("/orders/")]
        public ActionResult Index(int id){
            id = id+1;
            Vendor myVendor = Vendor.Find(id);
            return View(myVendor);
        }
        [HttpPost("/orders/add")]
        public ActionResult Add(string name, string description, double price, int date, int id){
            Console.WriteLine("name: " + name);
            Console.WriteLine("desc: " + description);
            Console.WriteLine("price: " + price);
            Console.WriteLine("date: " + date);
            Console.WriteLine("id: " + id);

            id = id+1;
            Vendor myVendor = Vendor.Find(id);
            Order newOrder = new Order(name, description, price, date);
            myVendor.AddOrder(newOrder);
            Console.WriteLine(myVendor.GetAllOrders()[0].Name);
            return View(myVendor);
        }
    }
}