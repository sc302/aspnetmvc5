using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Models
{
    public class ProductInfoViewModel
    {
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class ProductViewModel
    {
        public string ProductName { get; set; }
    }
}