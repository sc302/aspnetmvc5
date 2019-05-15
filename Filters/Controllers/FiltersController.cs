using Filters.AppFilters;
using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [Log]
    public class FiltersController : Controller
    {

        //[Log]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowLogs()
        {
            var logs = LogData.LogDataList;
            return View(logs);
        }
    }
}