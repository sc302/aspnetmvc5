using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Models;

namespace Views.Controllers
{
    public class PartialViewsController : Controller
    {
        // GET: PartialViews
        public ActionResult Index()
        {
            return View(new StudentViewModel() { StudentId = 1, StudentName = "mustafa" });
        }

        public ActionResult GetPartialView()
        {
            //Kullanici action linke ile bir id ile bir sorgu yapar
            //sorgu sonucu baska bir viewa gonderilebilir.
            return PartialView("ResultView","Hello Result View");
        }

        public ActionResult GetResultView2(int id)
        {
            return PartialView("/Views/ResultView2.cshtml", id);
        }
    }
}