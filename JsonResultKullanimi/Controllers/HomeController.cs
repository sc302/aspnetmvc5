using JsonResultKullanimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonResultKullanimi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetStudent(int id)
        {
            //data base den de getirebilir.
            List<Student> ogrenciler = new List<Student>();
            ogrenciler.Add(new Student()
            {
                StudentId = 1,
                StudentName = "Gülsüm",
                StudentLastName = "Solhan",
                Avarage = 4
            });
            ogrenciler.Add(new Student()
            {
                StudentId = 2,
                StudentName = "Tugce",
                StudentLastName = "Kokcu",
                Avarage = 5
            });
            ogrenciler.Add(new Student()
            {
                StudentId = 3,
                StudentName = "Ziya",
                StudentLastName = "Oses",
                Avarage = 9
            });

           var ogrenci=  ogrenciler.FirstOrDefault(x => x.StudentId == id);

            return Json(ogrenci, JsonRequestBehavior.AllowGet);

        }
    }
}