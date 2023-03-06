using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors/")]
        public ActionResult Index(){
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/add/")]
        public ActionResult Add(){
            return View();
        }

        [HttpPost("/vendors/")]
        public ActionResult AddVendor(string name, string description){
            Vendor myVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id){
            Vendor myVendor = Vendor.Find(id);
            return View(myVendor);
        }
    }
}