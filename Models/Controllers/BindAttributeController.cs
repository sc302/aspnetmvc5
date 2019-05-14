using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class BindAttributeController : Controller
    {
        // GET: BindAttribute
        public ActionResult Index()
        {
            return View(new CategoryViewModel() { CategoryId=1,CategoryName="Temizlik Urunleri",Stock=100});
        }

        public ActionResult ExcludePost(CategoryViewModel arg)
        {
            return RedirectToAction("Index");
        }
    }
}