using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests{
    [TestClass]
    public class VendorTests : IDisposable{
        public void Dispose(){
            Order.ClearAll();
        }
        
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor(){
            Vendor newVendor = new Vendor("name", "description");
            Assert.AreEqual("name", newVendor.Name);
            Assert.AreEqual("description", newVendor.Description);
        }

        public void Vendor_CanModifyOrders(){
            Vendor newVendor = new Vendor("Bob", "cookies");
            Order chocolate = new Order("chocolate", "chocolate chip", 2.00, 20200102);
            Order vanilla = new Order("vanilla", "vanilla chip", 2.00, 20200102);
            newVendor.AddOrder(chocolate);
            newVendor.AddOrder(vanilla);
            List<Order> orderList = new List<Order>{};
            orderList.Add(chocolate);
            orderList.Add(vanilla);
            Assert.AreEqual(orderList, newVendor.GetAllOrders());
            Assert.AreEqual(chocolate, newVendor.GetAllOrders()[0]);
            newVendor.RemoveOrder(chocolate);
            Assert.AreEqual(0, newVendor.GetAllOrders().Count);
        }

        
        public void Vendor_CanFindVendor(){
            Vendor bobVendor = new Vendor("Bob", "cookies");
            Vendor joeVendor = new Vendor("Joe", "pants");
            Assert.AreEqual(bobVendor, Vendor.Find(1));
            List<Vendor> aList = new List<Vendor>();
            aList.Add(bobVendor);
            aList.Add(joeVendor);

            Assert.AreEqual(aList, Vendor.GetAll());
        }
    }
}