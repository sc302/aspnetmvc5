using Models.CustomBinders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class CustomDefaultModelBinderController : Controller
    {
        public ActionResult Index()
        {
            return View(new ProductViewModel() { ProductName = "Laptop" });
        }

        [HttpPost]
        public ActionResult PostProductInfo([ModelBinder(typeof(ProductInfoModelDefaultBinder))] ProductInfoViewModel arg)
        {
            return View();
        }
    }
}