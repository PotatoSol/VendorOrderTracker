using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors/")]
        public ActionResult Index(){
            return View();
        }

        [HttpPost("/vendors/add/")]
        public ActionResult Add(){
            return View();
        }
    }
}