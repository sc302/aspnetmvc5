using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormGetAndPost.Controllers
{
    public class HomeController : Controller
    {
        
        //Varsayilan olarak action metodlar httpget yada httppost degil, dolayisila eger post ediliyorsa hangi action ediliyorsa o action metod HTTPost attribute ile belirtilmelidir.

        //Get ediliyosa, o metod HttpGet attribute ile post edilmeli.
    
        public ActionResult Index(string id) //varsayilan 
        {
            //FormGetAndPost/Home/Index/93209320
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(string Arguman)
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult PostMetod(string id)
        {
            var txt = Request["txt1"];
            var txt2 = Request.Form.Get("txt1");
           
            //Database den, id si 10 olan elemani update et,
            //ne ile? Post olarak aldigin degerlerle.
            // txt=> id olan elemani update et!
            return RedirectToAction("Index");
        }

        public ActionResult GetMetod(int id)
        {
            //Db den id si 10 olan elemani getir,
            //sonra o elemanlari ilgili view de ki elementlere gonder bind et.
            return RedirectToAction("Index");
        }
    }
}