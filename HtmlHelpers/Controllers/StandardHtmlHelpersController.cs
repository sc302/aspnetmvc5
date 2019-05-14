using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class StandardHtmlHelpersController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult TextArea(string txt,string lst,FormCollection frm)
        {
            var ilkdeger = frm["txt"];
            var ikincideger = frm["lst"];
            return View();
        }

        public ActionResult CheckBox(object ch,FormCollection frm)
        {
            return View();
        }

        public ActionResult RadioButton(string radio,FormCollection frm)
        {
            return View();
        }

        public ActionResult DropDownList()
        {
            return View();
        }

        public ActionResult ListBox()
        {
            return View();
        }

        public ActionResult Password()
        {
            return View();
        }
    }
}