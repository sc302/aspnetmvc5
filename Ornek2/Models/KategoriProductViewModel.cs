using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ornek2.Models
{
    public class KategoriProductViewModel
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}