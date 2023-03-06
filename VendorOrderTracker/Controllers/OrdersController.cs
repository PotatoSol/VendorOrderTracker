using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers{
    public class OrdersController : Controller
    {
        [HttpGet("/orders/")]
        public ActionResult Index(Vendor aVendor){
            return View(aVendor);
        }

    }
}