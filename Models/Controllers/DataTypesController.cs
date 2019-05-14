using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class DataTypesController : Controller
    {
        // GET: DataTypes
        public ActionResult Index(TeacherViewModel arg)
        {
            if(!ModelState.IsValid)
            {

            }

            return View();
        }
    }
}