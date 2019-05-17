using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionManagement.Controllers
{
    public class SessionStateController : Controller
    {
        /*
         Session server tabanli durum yonetimi veri saklama yonetimidir, saklanan deger site icindeki tum sayfalardan erisilebilir. Bir oturum suresince hayatta kalir,
         uyelik islemlerinde kullanilabilir.
         Seession degerleri serverda yada tarayici uzerinde durabilir.
         Session TimeOut diye bir ozelligi vardir, yani gecerli olacagi sure, yani o sure icersinde herhangi bir islem olmazsa session sonlansin bilgisi, TimeOut ozelliginde dakika ya gore. TimeOut=1;
         Varsayilan timeout suresi 20 dk
             */
        public ActionResult Index()
        {
            return View();
        }

        public void CreateSessionValue()
        {
            Session.Add("UserName", "Mustafa");
            Session.Timeout = 1;
            //yada
            //Session["UserName"] = "Mustafa";
            Response.Write("Session değeri Oluşturuldu!");
        }

        public void ReadSessionValue()
        {
            //Check session value
            if (Session["UserName"] == null)
                Response.Write("Session da deger yok!");
            else
            {
                var sessiondeger = Session["UserName"].ToString();
                Response.Write($"Session Degeri= {sessiondeger}");
            }
        }

        public void DeleteSessionValue()
        {
            if (Session["UserName"] == null)
                Response.Write("Session da deger yok!");
            else
            {
                Session.Remove("UserName");
                Response.Write("Session dan deger silindi!");
            }
        }

        public void UpdateSessionValue()
        {
            if (Session["UserName"] == null)
                Response.Write("Session da deger yok!");
            else
            {
                Session["UserName"] = "Mehmet";
                Response.Write("Session dan deger update edildi!");
            }
        }
        public void AbandonSession()
        {
            Session.Abandon();
            Response.Write("Session kapatildi!");
        }
    }
}