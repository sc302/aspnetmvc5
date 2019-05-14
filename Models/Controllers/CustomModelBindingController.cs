using Models.CustomBinders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class CustomModelBindingController : Controller
    {
        // GET: CustomModelBinding
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetTime([ModelBinder(typeof(DateTimeModelBinder))] DateTime arg)
        {
            /*
             Action Cagrilamadan önce, arka plan işlemlerini yöneten, iki tane birleşen var.
             ValueProviderDictionary
             DefaultModelBinder.

             ValueProviderDictionary:
             HTTP request ile gelen parametreleri çekerek string halde depolar, bunu şu adımlara göre yapar.
             1-Request.Form["name"] varmi diye bakar.
             Yoksa
             RouteData.Values["name"] varmi diye bakar
             yoksa
             Request.QueryString["name"] varmi diye bakar
             yoksa
             null değer döndürü.

             DefaultModelBinder
             temel tipler için bir işlem yapmaz ancak model TEMPLATE için reflection ile propertyler ValueProviderDictionary sınıfı tarafından sağlanan değerleri alır.
              */

            return PartialView("Index", arg.ToString());
        }
    }
}