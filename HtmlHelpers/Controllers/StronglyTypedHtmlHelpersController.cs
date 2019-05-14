using HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
    public class StronglyTypedHtmlHelpersController : Controller
    {

        public ActionResult Tanim()
        {
            StudentOrnekViewModel modelnesnem = new StudentOrnekViewModel();
            modelnesnem.StudentId = 1;
            modelnesnem.StudentName = "Mustafa";
            modelnesnem.IsPass = true;
            modelnesnem.Avarage = 10;

            return View(modelnesnem);
        }
        public ActionResult TextBoxFor()
        {
            StudentOrnekViewModel modelnesnem = new StudentOrnekViewModel();
            modelnesnem.StudentId = 2;
            modelnesnem.StudentName = "Mehmet";
            modelnesnem.IsPass = false;
            modelnesnem.Avarage = 30;
            return View(modelnesnem);
        }

        public ActionResult OutputPage(StudentOrnekViewModel arg,StudentInfoViewModel info)
        {
            return View(arg);
        }

        public ActionResult LabelFor()
        {
            StudentOrnekViewModel modelnesnem = new StudentOrnekViewModel();
            modelnesnem.StudentId = 3;
            modelnesnem.StudentName = "Alev";
            modelnesnem.IsPass = true;
            modelnesnem.Avarage = 50;

            return View(modelnesnem);
        }
        
        public ActionResult CheckboxFor()
        {
            StudentOrnekViewModel modelnesnem = new StudentOrnekViewModel();
            modelnesnem.StudentId = 3;
            modelnesnem.StudentName = "Alev";
            modelnesnem.IsPass = true;
            modelnesnem.Avarage = 50;
    
            return View(modelnesnem);
        }

        public ActionResult RadioButtonFor()
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            
            return View(model);
        }

        public ActionResult DropDownListFor(int? SelectedLecture, LectureListViewModel md,Ahmet a)
        {
            List<Lecture> lectureList = new List<Lecture>();
            lectureList.Add(new Lecture() { LectureId = 1, LectureName = "Matematik" ,IsOk=false});
            lectureList.Add(new Lecture() { LectureId = 2, LectureName = "Fizik",IsOk=false });
            lectureList.Add(new Lecture() { LectureId = 3, LectureName = "Biyoloji",IsOk=false });

            LectureListViewModel model = new LectureListViewModel();
            model.Dersler = new SelectList(lectureList, "LectureId", "LectureName");
            return View(model);
        }

        public ActionResult DisplayFor()
        {
            StudentOrnekViewModel modelnesnem = new StudentOrnekViewModel();
            modelnesnem.StudentId = 3;
            modelnesnem.StudentName = "Ahmet";
            modelnesnem.IsPass = true;
            modelnesnem.Avarage = 90;

            return View(modelnesnem);
        }

        public ActionResult DropDownListForModelList(Lecture lecture)
        {
            List<Lecture> lectureList = new List<Lecture>();
            lectureList.Add(new Lecture() { LectureId = 1, LectureName = "Matematik" });
            lectureList.Add(new Lecture() { LectureId = 2, LectureName = "Fizik" });
            lectureList.Add(new Lecture() { LectureId = 3, LectureName = "Biyoloji" ,IsOk=true});

            return View(lectureList);
        }

        public ActionResult DropDownListForViewBag(int? LectureId)
        {
            List<Lecture> lectureList = new List<Lecture>();
            lectureList.Add(new Lecture() { LectureId = 1, LectureName = "Matematik" });
            lectureList.Add(new Lecture() { LectureId = 2, LectureName = "Fizik" });
            lectureList.Add(new Lecture() { LectureId = 3, LectureName = "Biyoloji" });
            ViewBag.LectureList = lectureList;
            return View();
        }

        public ActionResult HiddenFor(StudentOrnekViewModel arg)
        {
            return View(new StudentOrnekViewModel() { StudentId = 1, StudentName = "Mustafa", Avarage = 19, IsPass = true });
        }

        public ActionResult ListBoxFor()
        {
            List<Lecture> lectureList = new List<Lecture>();
            lectureList.Add(new Lecture() { LectureId = 1, LectureName = "Matematik" });
            lectureList.Add(new Lecture() { LectureId = 2, LectureName = "Fizik" });
            lectureList.Add(new Lecture() { LectureId = 3, LectureName = "Biyoloji" });

            return View(lectureList);
        }

        public ActionResult PasswordFor()
        {
            var request = Request["Password"];
            return View();
        }

        public ActionResult EditorFor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModelListPost(FormCollection frm)
        {
            return RedirectToAction("DropDownListForModelList");
        }
     
    }

    class Student //Bu Bir domain objesi olabilirdi. 
    {
        //YANI Data accesden gelen bir tip.
        
    }

}