using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class AttributesController : Controller
    {
        // GET: Attributes
        public ActionResult ServerSideValidation(StudentViewModel rd)
        {
            //ModelState.IsValid
            //Post gelen model nesnesinde ki propertylere verilen degerde herhangi bir eksiklik varsa ve egerki propertylere attribute ile kuralları sağlamıyorsa, ModelState.IsValid ozelligi false olur.
            //False oldugu zamanda validation calistirilir. View deki
            //Html.ValidationSummary()

            //ActionMetod argumani model tipinde olmalıdır ModelState kontrol edilebilmesi için.
            /*Validasyon (ModelState durumu)Modellerden Required attribute almayan string harici 
            tüm veri tipleri için geçerlidir.
            
             */

            if (!ModelState.IsValid)
            {

            }
            return View();
        }

        public ActionResult ClientSideValidationJquery()
        {
            return View();
        }
    }
}