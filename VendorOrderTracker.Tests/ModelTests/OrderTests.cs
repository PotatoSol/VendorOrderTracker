using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests{
    [TestClass]
    public class OrderTests : IDisposable{

        public void Dispose(){
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order(){
            Order newOrder = new Order("name", "description", 12.34, 20200102);
            Assert.AreEqual("name", newOrder.Name);
            Assert.AreEqual("description", newOrder.Description);
            Assert.AreEqual(12.34, newOrder.Price);
            Assert.AreEqual(20200102, newOrder.Date);
        }
    }
}