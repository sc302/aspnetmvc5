using Ornek.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = new FakeDbRepo();
            var gelenlist = list.GetStudents().ToList();
             
            return View(gelenlist);
        }
        public ActionResult UpdateStudentInfo(List<Ornek.Models.StudentViewModel> listearg) //listearg 
            //[0].StudentName
        {
       
            return View();
        }
        //Model, studentid,studentname,studentnot,gecti?
        //Bunlar bir listeden List<Student> gelecek.
        //View da, tablo ya yazacak ogrenci listesi.
        //birden fazla ogrenci gectimi kaldimi, update edilecek
        //update dedigi zaman ogrenci listesi update olmus sekilde
        //kontrole gelecek.

        //Studentadi,not,gecti? 
        //ahmet 12 false ->CHECK TRUE
        //mehmet 23 false
        //ali   11 false

        //button==>UPDATE, birden cok ogrenci kontrole update olarak
        //gidecek.
        //liste post mvc kontroller
        
    }
}