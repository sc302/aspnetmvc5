﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    public class LogInfo
    {
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public DateTime ProcessTime { get; set; }

        public string ProcessType { get; set; }

    }
}