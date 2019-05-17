using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionManagement.Controllers
{
    public class CookiesController : Controller
    {
        /*
         Response ile kullanici browserina cookie gonderilir.
         Request ile kullanicinin browserdan cookie alinir.
             */
        public ActionResult Index()
        {
            return View();
        }

        public void CreateCookie()
        {
            //Cookie yaratalim.
            var cookie = new HttpCookie("KullaniciAdi", "Mustafa");
            //cookie.Expires = DateTime.Now.AddSeconds(10); //cookienin silinecegi zaman
            Response.Cookies.Add(cookie);
            
            Response.Write("Cookie Eklendi!");

        }

        public void ReadCookieValue()
        {
            if (Request.Cookies["KullaniciAdi"] != null)
            {
                //Request.Cookies["KullaniciAdi"].Value!=null
                var cookieDegeri = Request.Cookies["KullaniciAdi"].Value;
                Response.Write($"Cookie Degeri = {cookieDegeri}");
            }
            else
            {
                Response.Write("No cookie!!");
            }
        }

        public void UpdateCookieValue()
        {
            if (Request.Cookies["KullaniciAdi"].Value != null)
            {

                //yada
                Response.Cookies.Set(new HttpCookie("KullaniciAdi", "mehmet"));
                Response.Write("Cookie degeri update edildi!");
            }
            else
            {
                Response.Write("No cookie!!");
            }
        }

        public void DeleteCookieValue()
        {
            //if (Request.Cookies["KullaniciAdi"].Value != null)
            //{
            //    Response.Cookies.Remove("KullaniciAdi");
            //    Response.Write("Cookie degeri silindi!");
            //}
            //else
            //{
            //    Response.Write("Cookie degeri yok!");
            //}
            if (Request.Cookies["KullaniciAdi"] != null)
            {
                Response.Cookies.Set(new HttpCookie("KullaniciAdi", null) {
                    Expires =DateTime.Now.AddMonths(-1)

                  });
                Response.Write("Cookie silindi!");
            }
            else
            {
                Response.Write("No cookie!!");
            }
        }
        public void DeleteCookieValue2()
        {
            if (Request.Cookies["KullaniciAdi"] != null)
            {
                Response.Cookies["KullaniciAdi"].Value = null;
                Response.Cookies["KullaniciAdi"].Expires = DateTime.Now.AddMonths(-1);
                Response.Write("Cookie silindi!");
            }
            else
            {
                Response.Write("No cookie!!");
            }
        }
}