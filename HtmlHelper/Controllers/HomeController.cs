using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ActionLink()
        {
            return View();
        }

        public ActionResult Ekran(string Arguman)
        {
            if (!string.IsNullOrEmpty(Arguman))
                ViewBag.Deger = Arguman;
            return View();
        }

        public ActionResult BeginForm()
        {
            return View();
        }

        public ActionResult TextBox(object adi)
        {
            return View();
        }

        public ActionResult Label()
        {
            return View();
        }
    }
}