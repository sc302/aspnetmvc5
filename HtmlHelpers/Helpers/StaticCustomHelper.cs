using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Helpers
{
    public class StaticCustomHelper
    {
        public static MvcHtmlString MyTextBox(string id,string name="")
        {
            //Eger ki name girilmezse bu helperi kullanan
            if(string.IsNullOrEmpty(name))
            {
                name=id;
            }

            var inputString = $"<input type='text' id={id} name={name} />";

            var returnHelper = MvcHtmlString.Create(inputString);

            return returnHelper;
        }

        public static MvcHtmlString MyLabel(string target,string text)
        {

            var retstring = $"<label for ={target}>{text}</label>";

            return MvcHtmlString.Create(retstring);
        }
    }
}