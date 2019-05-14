using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormCollectionAndRequest.Controllers
{
    public class QueryStringController : Controller
    {
        // GET: QueryString
        public ActionResult Index(FormCollection frm)
        {
            var frmCollection = frm["txtBox"];
            var request = Request["txtBox"];
            Response.Write($"frmCollection={frmCollection},request={request}");
            return View();
        }
    }
}