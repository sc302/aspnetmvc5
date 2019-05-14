using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.CustomBinders
{
    public class DateTimeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
          var request=  controllerContext.HttpContext.Request;
           string gun= request["gun"];
            string ay = request["ay"];
            string yil = request["yil"];
            string saat = request["saat"];
            string dakika = request["dakika"];
            string saniye = request["saniye"];

            return new DateTime(int.Parse(yil), int.Parse(ay), int.Parse(gun), int.Parse(saat), int.Parse(dakika), int.Parse(saniye));
        }
    }

    public class ProductInfoModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            string gun = request["gun"];
            string ay = request["ay"];
            string yil = request["yil"];
            string model = request["ProductName"];

            return new ProductInfoViewModel()
            {
                ProductName = model,
                OrderDate = new DateTime(int.Parse(yil), int.Parse(ay), int.Parse(gun))
            };
        }
    }

    public class ProductInfoModelDefaultBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(ProductInfoViewModel))
            {
                var request = controllerContext.HttpContext.Request;
                string gun = request["gun"];
                string ay = request["ay"];
                string yil = request["yil"];
                string model = request["ProductName"];

                return new ProductInfoViewModel()
                {
                    ProductName = model,
                    OrderDate = new DateTime(int.Parse(yil), int.Parse(ay), int.Parse(gun))
                };
            }

            return base.BindModel(controllerContext, bindingContext);
        }
    }

}