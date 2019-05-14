using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Helpers
{
    public static class ExtensionMetodCustomHelper
    {
        public static MvcHtmlString MyTextBox(this HtmlHelper helper,string id,string name="" )
        {
            //Eger ki name girilmezse bu helperi kullanan
            if (string.IsNullOrEmpty(name))
            {
                name = id;
            }

            var inputString = $"<input type='text' id={id} name={name} />";

            var returnHelper = MvcHtmlString.Create(inputString);

            return returnHelper;
        }

        public static MvcHtmlString MyLabel(this HtmlHelper helper,string target, string text)
        {

            var retstring = $"<label for ={target}>{text}</label>";

            return MvcHtmlString.Create(retstring);
        }

        public static MvcHtmlString MyCheckBoxFor(this HtmlHelper helper, bool val, int text)
        {

            var inputString = $"<input type='checkbox' value={val.ToString().ToLower()} name='{text.ToString()}' />";

            return MvcHtmlString.Create(inputString);
        }
    }
}