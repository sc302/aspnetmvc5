using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    public class LogData
    {
        static List<LogInfo> _loglar = new List<LogInfo>();

        public static List<LogInfo> LogDataList
        {
            get
            {
                return _loglar;
            }

        }
    }
}