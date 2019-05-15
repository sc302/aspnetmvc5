using Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.AppFilters
{
    /*
     Filtereler hangileri,
     -Action filters
     -Controller filters
     -Exeption filters vs vs
     Filtreleme yapmak için 
        
      Fıltereleme yapmak için ActionFilterAttribute classı (Zaten IActionFiltertı implemente etmiştir) yada
      IActionFilter interfacei implemente edilmelidir ve bu attribute bir filtereleme attribute olacagından, FilterAttribute adındaki class kalıtım olarak alınmalıdır.
      Bundan sonra attribute action bazında yada control bazında tanımlayabilirliz.
         */
    public class LogAttribute : FilterAttribute, IActionFilter,IResultFilter
    {
        #region ActionFilterImplementation
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogData.LogDataList.Add(new LogInfo()
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                Controller=filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ProcessTime=DateTime.Now,
                ProcessType="Actiondan sonra"
            });
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            LogData.LogDataList.Add(new LogInfo()
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ProcessTime = DateTime.Now,
                ProcessType = "Actiondan once"
            });
        }
        #endregion
        /*
    Result Filters,
    Action ve filterleri calistiktan view derlenmeye başlar,
    Viewin derlemenmesinden hemen once result filteresi devreye gire bu result filtersi de handellariyla o anda istenilen islem yaptirabilir.
    Yani
    ResultExecutedContext argumaniyla
    Result = geri donus degeri,
    Exception = varsa hata bilgisi 
    ExceptionHandled = hata var mi bilgisi
    Cancel iptal edildi mi bilgisi
    RouteData ve HttpContext ile 
    */
        #region ResultFilterImplementation
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
            LogData.LogDataList.Add(new LogInfo()
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ProcessTime = DateTime.Now,
                ProcessType = "Result dan sonra"
            });
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogData.LogDataList.Add(new LogInfo()
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ProcessTime = DateTime.Now,
                ProcessType = "Result dan önce"
            });
        }
#endregion
    }
   
}