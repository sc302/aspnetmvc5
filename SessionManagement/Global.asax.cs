using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SessionManagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //protected void Application_End()
        //{

        //}
        protected void Session_Start(object sender,EventArgs e)
        {
            //Application.Add("ApplicationName", "SessionManagementUygulama"); //ekleme
            //                                                                 //YADA
            ////Application["ApplicationName"] = "SessionManagementUygulama";

            //Application.Set("ApplicationName", "SessionManagement2"); //update
            //Application.Remove("ApplicationName");

            //var appsesiondegeri = Application["ApplicationName"].ToString(); //erisilir.

            //if(Application["ApplicationName"]!=null)
            //{
            //    //kontrol edilir.
            //}
    
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }
    }
    /*
     Application_Start() metodu uygulama ilk calistigi anda tetiklenecektir,
     Yani uygulamanin ApplicationDomaini yaratildiginda olusturulur.

    Application_End() uygulama son buldugundan yani uygulama ApplicationDomainden ciktiginda calisir.

    Session_Start() uygulamaya bir istek geldiginde calisir, yani kullanici siteye girdiginde.

    Session_End() session sonlandiginda calisir, ancak browser kapatildiginda calismaz, neden server browserin kapandigini bilemez. dolayisiyla bu metod calismaz, kullanici tarafindan tetiklemek imkansiza yakindir.
     */
}
